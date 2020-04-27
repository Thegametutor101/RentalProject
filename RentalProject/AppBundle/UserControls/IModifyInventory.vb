Imports MySql.Data.MySqlClient

Public Class IModifyInventory

    Dim Inventory As IInventory

    Sub New(IInventory As IInventory)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Inventory = IInventory
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        'Confirmation d'annulation
        Dim result As DialogResult = MessageBox.Show("Êtes vous sûr de vouloir annuler la modification de cet équipement?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            TBName.Text = ""
            CBCat.SelectedText = ""
            TBEtat.Text = ""
            Me.SendToBack()
        End If
    End Sub

    Private Sub IModifyInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sélection des données de la BD
        Dim con As New MySqlConnection("Server='localhost';Database='BD';Uid='root';Pwd='';Port=3306")
        Dim com As New MySqlCommand
        com.Connection = con
        Dim equip As Integer
        Try

            com.CommandText = $"Select * from equipement where noequipement='{Inventory.DataGridView1.SelectedRows.Item(0).Cells(0).Value}'"
            Dim r As MySqlDataReader

            Try
                con.Open()
                r = com.ExecuteReader
                r.Read()
                LabelNo.Text = r(0)
                TBName.Text = r(1)
                CBCat.Text = r(2)
                TBEtat.Text = r(3)
                TBDispo.Text = r(4)
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erreur")
            Finally
                If con IsNot Nothing Then
                    con.Dispose()
                End If
            End Try
        Catch ex As Exception
            MessageBox.Show("Veuillez sélectionner une rangée")
        End Try
        'Aller chercher les catégories
        com.CommandText = "Select * from categorie"
        'Entrer les catégories dans la combo box
        Dim read As MySqlDataReader
        Try
            con.Open()
            read = com.ExecuteReader
            'ajout dans la combobox
            Dim Categories As New DataTable("categorie")
            Categories.Load(read)
            CBCat.DataSource = Categories
            CBCat.DisplayMember = "nom"
            CBCat.ValueMember = "nocategorie"
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erreur")
        Finally
            If con IsNot Nothing Then
                con.Dispose()
            End If
        End Try
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        'Retour au UC inventaire
        Me.SendToBack()
    End Sub

    Private Sub ButtonModif_Click(sender As Object, e As EventArgs) Handles ButtonModif.Click
        Dim con As New MySqlConnection("Server='localhost';Database='BD';Uid='root';Pwd='';Port=3306")
        Dim com As New MySqlCommand
        Dim read As MySqlDataReader
        'Confirmation que tous les champs sont remplis

        If TBName.Text = "" Or CBCat.Text = "" Or TBEtat.Text = "" Or TBDispo.Text = "" Then
            MessageBox.Show("Veuillez remplir tous les champs avant d'ajouter un équipement", "Erreur")
        Else

            'confirmation de la modification
            Dim result As DialogResult = MessageBox.Show("Voulez vous modifier l'équipement de la base de donnée, ses nouvelles informations seront:" & vbCrLf & "NoEquipement: " & LabelNo.Text & vbCrLf & "Nom: " & TBName.Text & vbCrLf & "Catégorie: " & CBCat.Text & vbCrLf & "État:" & TBEtat.Text & vbCrLf & "Dispo: " & TBDispo.Text, "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                'ajout dans la base de données
                Dim No As Integer
                'Sélection du nocategorie en fonction du nom choisi
                com.CommandText = $"select nocategorie from categorie where nom = '{CBCat.Text}'"

                'Try
                con.Open()
                read = com.ExecuteReader
                    read.Read()
                    No = read(0)
                    con.Close()
                'Catch ex As Exception
                'MessageBox.Show(ex.Message, "Erreur")
                'Finally
                'If con IsNot Nothing Then
                'con.Dispose()
                'End If
                '   End Try

                'ajout dans la BD
                MessageBox.Show(No, "Erreur")
                com.CommandText = $"update equipement set nom='{TBName.Text}',nocategorie='{No}',etat='{TBEtat.Text}',disponibilite='{TBDispo.Text}' where noequipement='{LabelNo.Text}'"
                Try
                    con.Open()
                    Dim add As Integer = com.ExecuteNonQuery
                    con.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Erreur")
                Finally
                    If con IsNot Nothing Then
                        con.Dispose()
                    End If
                End Try


                MessageBox.Show("L'équipement a été modifié", "Confirmation")

                com.Connection = con
                com.CommandText = "Select * from equipement"
                Dim r As MySqlDataReader

                Try
                    con.Open()
                    r = com.ExecuteReader
                    Dim tableequipement As New DataTable("equipement")
                    tableequipement.Load(r)
                    Inventory.DataGridView1.DataSource = tableequipement
                    con.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Erreur")
                Finally
                    If con IsNot Nothing Then
                        con.Dispose()
                    End If
                End Try
            End If

            Me.SendToBack()
        End If


    End Sub
End Class
