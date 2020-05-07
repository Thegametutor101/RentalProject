Imports MySql.Data.MySqlClient
Public Class IEmprunt
    Dim connectionString = "Server='localhost';Database='projetsession';Uid='root';Pwd='';Port=3308;Convert Zero Datetime=True"
    Dim connection As New MySqlConnection(connectionString)
    Dim validDate As Boolean = False
    Dim reader As MySqlDataReader
    Dim readdate As MySqlDataReader
    Dim com As New MySqlCommand
    Dim comdate As New MySqlCommand
    Dim ListPersonne(999, 3) As String
    Dim ListCategorie(999, 2) As String
    Dim ListEquipement(999, 3) As String
    Dim slPersonne As String = "SELECT noPersonne,prenom,nom from personne;"
    Dim slCategorie As String = "select noCategorie,nom from categorie;"
    Dim slEquipement As String = "select noEquipement,nom,Etat from Equipement where noCategorie="
    Dim nomComplet As String
    Dim rentals As IRentals

    Sub New(rental As IRentals)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        rentals = rental
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
    End Sub

    Private Sub IEmprunt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Dim noCategorie As String
        DateTimePicker1.MinDate = Date.Now
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dddd dd-MM-yyyy hh:mm:ss"
        DateTimePicker1.Enabled = False
        CbCategorie.Text = "Sélectionnez une catégorie"

        refreshPersonne()


    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownJour.ValueChanged
        DateTimePicker1.Value = Date.Now.AddHours(NumericUpDownHeure.Value + (NumericUpDownJour.Value * 24))
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If (DateTimePicker1.Value.DayOfWeek = 6) Then
            MessageBox.Show("La date donné est en dehors des heures du cégep")
            validDate = False
        Else validDate = True
        End If

        If (DateTimePicker1.Value.DayOfWeek = 0) Then
            MessageBox.Show("La date donné est en dehors des heures du cégep")
            validDate = False
        Else validDate = True
        End If
        NumericUpDownJour.Value = DateTimePicker1.Value.DayOfYear - Date.Now.DayOfYear
        NumericUpDownHeure.Value = DateTimePicker1.Value.Hour - Date.Now.Hour
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbCategorie.SelectedIndexChanged
        RefreshEquipement()
    End Sub

    Private Sub CbPersonne_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbPersonne.SelectedIndexChanged
        refreshEmpruntEnCours()
        refreshCategorie()
        nomComplet = ListPersonne(CbPersonne.SelectedIndex, 1) + " " + ListPersonne(CbPersonne.SelectedIndex, 2)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Not String.IsNullOrEmpty(TbAutorise.Text) And DateTimePicker1.Value > DateTime.Now And validDate = True) Then
            insertToRental()
            RefreshEquipement()
        Else MessageBox.Show("Valeur invalide - Veuillez vérifier tous les champs")
        End If
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            DateTimePicker1.Enabled = True
            NumericUpDownJour.ReadOnly = True
            NumericUpDownHeure.ReadOnly = True
        Else
            DateTimePicker1.Enabled = False
            NumericUpDownJour.ReadOnly = False
            NumericUpDownHeure.ReadOnly = False
        End If
    End Sub

    Private Sub NumericUpDownHeure_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownHeure.ValueChanged
        DateTimePicker1.Value = Date.Now.AddHours(NumericUpDownHeure.Value + (NumericUpDownJour.Value * 24))
    End Sub

    Public Function RefreshEquipement()
        CbEquipement.Enabled = True
        Dim noCategorie As String
        Dim ctrEquipement As Integer
        CbEquipement.Items.Clear()
        CbEquipement.Text = "Sélectionnez un equipement"
        If (CbCategorie.SelectedIndex > -1) Then
            noCategorie = ListCategorie(CbCategorie.SelectedIndex, 0)

            ctrEquipement = 0
            connection.Open()

            com.CommandText = slEquipement + noCategorie + " and disponibilite='oui';"
            reader = com.ExecuteReader
            While (reader.Read)
                CbEquipement.Items.Add(reader.GetString(0) + "-" + reader.GetString(1) + " " + reader.GetString(2))
                ListEquipement(ctrEquipement, 0) = reader.GetString(0)
                ListEquipement(ctrEquipement, 1) = reader.GetString(1)
                ListEquipement(ctrEquipement, 2) = reader.GetString(2)
                ctrEquipement += 1
            End While
            connection.Close()
        Else MessageBox.Show("Aucune Categorie sélectionné")
        End If


    End Function

    Public Function insertToRental()
        Dim empruntEntity As New ModelRental
        Dim equipementEntity As New EntityEquipment
        Dim no_personne As Integer
        Dim no_equipement As String
        Dim autorisation As String
        Dim duree As String
        Dim dateRetour As Date
        Try
            no_personne = CInt(ListPersonne(CbPersonne.SelectedIndex, 0))
            no_equipement = ListEquipement(CbEquipement.SelectedIndex, 0)
            autorisation = TbAutorise.Text
            duree = (NumericUpDownJour.Value * 24) + NumericUpDownHeure.Value
            dateRetour = DateTimePicker1.Value
            empruntEntity.addRental(no_personne, no_equipement, autorisation, Date.Now, duree, dateRetour, Trim(Comments.Text))
            empruntEntity.updateEquipementStatus(no_equipement)
        Catch ex As Exception
            MessageBox.Show("Valeur invalide - Veuillez vérifier tous les champs")
        End Try
    End Function
    Public Function refreshCategorie()
        CbCategorie.Enabled = True
        Dim ctr1 As Integer
        ctr1 = 0
        com.CommandText = slCategorie
        connection.Open()
        reader = com.ExecuteReader
        While (reader.Read)
            CbCategorie.Items.Add(reader.GetString(0) + " - " + reader.GetString(1))
            ListCategorie(ctr1, 0) = reader.GetString(0)
            ListCategorie(ctr1, 1) = reader.GetString(1)
            ctr1 += 1
        End While
        CbEquipement.Items.Clear()
        connection.Close()
    End Function

    Public Function refreshPersonne()
        Dim ctr As Integer
        ctr = 0
        connection.Open()
        com.Connection = connection
        com.CommandText = "SELECT noPersonne,nom,prenom from personne"

        reader = com.ExecuteReader
        While (reader.Read)
            CbPersonne.Items.Add(reader.GetString(0) + "-" + reader.GetString(1) + " " + reader.GetString(2))
            ListPersonne(ctr, 0) = reader.GetString(0)
            ListPersonne(ctr, 1) = reader.GetString(1)
            ListPersonne(ctr, 2) = reader.GetString(2)
            ctr += 1
        End While
        CbCategorie.Items.Clear()
        connection.Close()
    End Function

    Public Function refreshEmpruntEnCours()
        Dim noPersonne As String
        Dim ctrEmprunt As Integer
        LbEmprunt.Items.Clear()
        CbEquipement.Text = "Sélectionnez un equipement"
        noPersonne = ListPersonne(CbPersonne.SelectedIndex, 0)
        ctrEmprunt = 0
        connection.Open()

        com.CommandText = "select e.noCategorie,e.nom,em.dateRetour from emprunt em
inner join equipement e on e.noEquipement=em.noEquipement where em.noPersonne=" + noPersonne + ";"
        reader = com.ExecuteReader
        While (reader.Read)
            LbEmprunt.Items.Add(reader.GetString(0) + " - " + reader.GetString(1) + " " + reader.GetDateTime(2).ToString())
            ctrEmprunt += 1
        End While
        connection.Close()
    End Function

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click, CancelButton.Click
        If MessageBox.Show($"Voulez-vous vraiment faire cette opération?{Environment.NewLine}Tous vos changement seront perdus.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.SendToBack()
            rentals.loadData(EntityRental.getInstance().getRentals())
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        insertToRental()
        RefreshEquipement()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        If MessageBox.Show($"Voulez-vous vraiment faire cette opération?{Environment.NewLine}Tous vos changement seront perdus.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            CbEquipement.Text = ""
            CbCategorie.Text = ""
            CbPersonne.Text = ""
            TbAutorise.Text = ""
            NumericUpDownJour.Value = 0
            NumericUpDownHeure.Value = 0
            DateTimePicker1.Value = Date.Now
        End If
    End Sub
End Class


