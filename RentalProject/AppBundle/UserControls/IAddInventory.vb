Imports MySql.Data.MySqlClient
Public Class IAddInventory
    Dim Inventory As IInventory


    Sub New(IInventory As IInventory)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Inventory = IInventory
    End Sub

    Private Sub IAddInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Connection à la BD
        Dim con As New MySqlConnection("Server='localhost';Database='BD';Uid='root';Pwd='';Port=3306")
        'Aller chercher les catégories
        Dim com As New MySqlCommand
        com.Connection = con
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



    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        'Confirmation d'annulation
        Dim result As DialogResult = MessageBox.Show("Êtes vous sûr de vouloir annuler la création de cet équipement?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            TBName.Text = ""
            CBCat.SelectedText = ""
            TBEtat.Text = ""
            Me.SendToBack()
        End If


    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        'Retour au UC inventaire
        Me.SendToBack()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        'Confirmation que tous les champs sont remplis
        Dim con As New MySqlConnection("Server='localhost';Database='BD';Uid='root';Pwd='';Port=3306")
        Dim com As New MySqlCommand
        If TBName.Text = "" Or CBCat.Text = "" Or TBEtat.Text = "" Then
            MessageBox.Show("Veuillez remplir tous les champs avant d'ajouter un équipement", "Erreur")
        Else
            'Préparation des informations de la BD

            Dim ID As Integer

            com.Connection = con
            com.CommandText = "Select max(noequipement) from equipement"
            Dim read As MySqlDataReader

            Try
                con.Open()
                read = com.ExecuteReader
                read.Read()
                ID = read(0) + 1
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Erreur")
            Finally
                If con IsNot Nothing Then
                    con.Dispose()
                End If
            End Try

            'confirmation de l'ajout
            Dim result As DialogResult = MessageBox.Show("Voulez vous ajouter un nouvel équipement à la base de donnée, ses informations sont:" & vbCrLf & "NoEquipement: " & ID & vbCrLf & "Nom: " & TBName.Text & vbCrLf & "Catégorie: " & CBCat.Text & vbCrLf & "État:" & TBEtat.Text, "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                'ajout dans la base de données
                Dim No As Integer
                'Sélection du nocategorie en fonction du nom choisi
                com.CommandText = $"select nocategorie from categorie where nom = '{CBCat.Text}'"

                Try
                    con.Open()
                    read = com.ExecuteReader
                    read.Read()
                    No = read(0)
                    con.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Erreur")
                Finally
                    If con IsNot Nothing Then
                        con.Dispose()
                    End If
                End Try

                'ajout dans la BD
                com.CommandText = $"insert into equipement values('{ID}','{TBName.Text}','{No}','{TBEtat.Text}','Oui')"
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

                MessageBox.Show("L'équipement a été ajouté", "Confirmation")

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
