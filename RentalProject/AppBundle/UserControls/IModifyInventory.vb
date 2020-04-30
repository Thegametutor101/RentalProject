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
        loadData(EntityCategory.getInstance.getCategory)
    End Sub

    Public Function loadData(data As DataTable)
        'Création de la table comprenant toutes les catégories
        Dim categoryTable As DataTable = data
        For Each it As DataRow In categoryTable.Rows
            If Not IsNothing(it) Then
                CBCat.DataSource = categoryTable
                CBCat.DisplayMember = "nom"
                CBCat.ValueMember = "nocategorie"
            End If
        Next
        'Actualiser les informations selon l'équipement sélectionné
        LabelNo.Text = Inventory.DataGridView1.SelectedRows.Item(0).Cells(0).Value
        TBName.Text = Inventory.DataGridView1.SelectedRows.Item(0).Cells(1).Value
        CBCat.SelectedIndex = Inventory.DataGridView1.SelectedRows.Item(0).Cells(2).Value - 1
        TBEtat.Text = Inventory.DataGridView1.SelectedRows.Item(0).Cells(3).Value
        TBDispo.Text = Inventory.DataGridView1.SelectedRows.Item(0).Cells(4).Value
    End Function

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        'Retour au UC inventaire
        'Confirmation de retour
        Dim result As DialogResult = MessageBox.Show("Êtes vous sûr de vouloir revenir à la page précédente?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            TBName.Text = ""
            CBCat.SelectedText = ""
            TBEtat.Text = ""
            Me.SendToBack()
        End If
    End Sub

    Public Function UpdateEquipement()
        Dim equipementEntity As New EntityEquipment
        Dim noEquipement As Integer
        Dim nom As String
        Dim nocategorie As Integer
        Dim etat As String
        Dim disponibilite As String
        Try
            noEquipement = LabelNo.Text
            nom = TBName.Text
            nocategorie = CBCat.SelectedIndex
            etat = TBEtat.Text
            disponibilite = TBDispo.Text
            equipementEntity.updateequipment(noEquipement, nom, nocategorie, etat, disponibilite)
        Catch ex As Exception
            MessageBox.Show("Valeur invalide - Veuillez vérifier tous les champs")
        End Try
    End Function

    Private Sub ButtonModif_Click(sender As Object, e As EventArgs) Handles ButtonModif.Click
        Dim result As DialogResult = MessageBox.Show("Voulez vous modifier l'équipement de la base de donnée, ses nouvelles informations seront:" & vbCrLf & "NoEquipement: " & LabelNo.Text & vbCrLf & "Nom: " & TBName.Text & vbCrLf & "Catégorie: " & CBCat.Text & vbCrLf & "État:" & TBEtat.Text & vbCrLf & "Dispo: " & TBDispo.Text, "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            UpdateEquipement()
            Inventory.DataGridView1.DataSource = EntityEquipment.getInstance().getEquipment()
            Me.SendToBack()
        End If
    End Sub
End Class
