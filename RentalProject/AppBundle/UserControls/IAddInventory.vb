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
        loaddata(EntityCategory.getInstance.getCategory)
    End Sub

    Private Function loaddata(data As DataTable)
        'Création de la table comprenant toutes les catégories
        Dim categoryTable As DataTable = data
        For Each it As DataRow In categoryTable.Rows
            If Not IsNothing(it) Then
                CBCat.DataSource = categoryTable
                CBCat.DisplayMember = "nom"
                CBCat.ValueMember = "nocategorie"
            End If
        Next
    End Function

    Private Function insert_equipment()
        Dim equipementEntity As New EntityEquipment
        Dim noEquipement As Integer
        Dim nom As String
        Dim nocategorie As Integer
        Dim etat As String
        Dim disponibilite As String
        Try
            noEquipement = EntityEquipment.getInstance.nextid
            nom = TBName.Text
            nocategorie = CBCat.SelectedIndex
            etat = TBEtat.Text
            disponibilite = "oui"
            equipementEntity.addequipment(noEquipement, nom, nocategorie, etat, disponibilite)
        Catch ex As Exception
            MessageBox.Show("Valeur invalide - Veuillez vérifier tous les champs")
        End Try
    End Function

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click, CancelButton.Click
        'Retour au UC inventaire
        If MessageBox.Show($"Voulez-vous vraiment faire cette opération?{Environment.NewLine}Tous vos changement seront perdus.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.SendToBack()
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        'Confirmation que tous les champs sont remplis
        Dim con As New MySqlConnection("Server='localhost';Database='projetsession';Uid='root';Pwd='';Port=3308")
        Dim com As New MySqlCommand
        If TBName.Text = "" Or CBCat.Text = "" Or TBEtat.Text = "" Then
            MessageBox.Show("Veuillez remplir tous les champs avant d'ajouter un équipement", "Erreur")
        Else

            'confirmation de l'ajout
            Dim result As DialogResult = MessageBox.Show("Voulez vous ajouter un nouvel équipement à la base de donnée, ses informations sont:" & vbCrLf & "NoEquipement: " & EntityEquipment.getInstance.nextid & vbCrLf & "Nom: " & TBName.Text & vbCrLf & "Catégorie: " & CBCat.Text & vbCrLf & "État:" & TBEtat.Text, "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                insert_equipment()
                Inventory.DataGridView1.DataSource = EntityEquipment.getInstance().getEquipment()
                Me.SendToBack()
            End If
        End If
    End Sub
End Class
