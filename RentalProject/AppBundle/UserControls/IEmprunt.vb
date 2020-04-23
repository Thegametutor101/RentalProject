Imports MySql.Data.MySqlClient
Public Class IEmprunt
    Dim connectionString = "Server='localhost';Database='projetsession';Uid='root';Pwd='';Port=3308;"
    Dim connection As New MySqlConnection(connectionString)

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
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
    End Sub

    Private Sub IEmprunt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Dim noCategorie As String
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd-MM-yyyy hh:mm:ss"
        DateTimePicker1.Enabled = False
        CbCategorie.Text = "Sélectionnez une catégorie"

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
        connection.Close()
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
        connection.Close()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        DateTimePicker1.Value = Date.Now.AddHours(NumericUpDown1.Value)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbCategorie.SelectedIndexChanged
        Dim noCategorie As String
        Dim ctrEquipement As Integer
        CbEquipement.Items.Clear()
        CbEquipement.Text = "Sélectionnez un equipement"
        noCategorie = ListCategorie(CbCategorie.SelectedIndex, 0)
        ctrEquipement = 0
        connection.Open()

        com.CommandText = slEquipement + noCategorie + ";"
        reader = com.ExecuteReader
        While (reader.Read)
            CbEquipement.Items.Add(reader.GetString(0) + "-" + reader.GetString(1) + " " + reader.GetString(2))
            ListEquipement(ctrEquipement, 0) = reader.GetString(0)
            ListEquipement(ctrEquipement, 1) = reader.GetString(1)
            ListEquipement(ctrEquipement, 2) = reader.GetString(2)
            ctrEquipement += 1
        End While
        connection.Close()
    End Sub

    Private Sub CbPersonne_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbPersonne.SelectedIndexChanged

        nomComplet = ListPersonne(CbPersonne.SelectedIndex, 1) + " " + ListPersonne(CbPersonne.SelectedIndex, 2)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim empruntEntity As New ModelRental
        Dim equipementEntity As New EntityEquipment
        Dim no_personne As Integer
        Dim no_equipement As String
        Dim autorisation As String
        Dim duree As String
        Dim dateRetour As String
        Try
            no_personne = CInt(ListPersonne(CbPersonne.SelectedIndex, 0))
            no_equipement = ListEquipement(CbEquipement.SelectedIndex, 0)
            autorisation = TbAutorise.Text
            duree = NumericUpDown1.Value
            dateRetour = DateTimePicker1.Text
            empruntEntity.addRental(no_personne, no_equipement, autorisation, duree, DateTimePicker1.Text, nomComplet)
            empruntEntity.updateEquipementStatus(no_equipement)
        Catch ex As Exception
            MessageBox.Show("Valeur invalide - Veuillez vérifier tous les champs")
        End Try

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
