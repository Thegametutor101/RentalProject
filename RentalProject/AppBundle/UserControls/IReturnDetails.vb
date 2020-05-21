Imports System.Text.RegularExpressions

Public Class IReturnDetails

    Dim rentals As IRentals
    Dim id As Integer

    Sub New(Irentals As IRentals, number As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        rentals = Irentals
        id = number
    End Sub

    ''' <summary>
    ''' Ce Sub applique les données récupérées dans les champs textes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub IReturnDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim item As DataTable = EntityRental.getInstance().getRentalDetailed(id)
        For Each it As DataRow In item.Rows
            RentalID.Text = it.Item(0)
            RenterFirstName.Text = it.Item(1)
            RenterLastName.Text = it.Item(2)
            RenterStatus.Text = it.Item(3)
            Email.Text = it.Item(4)
            Authorisation.Text = it.Item(5)
            RentalDate.Value = it.Item(6)
        Next
        RentalDate.CustomFormat = "dd-MM-yyyy hh:mm:ss"

        DGVEquipments.DataSource = EntityEquipment.getInstance.getEquipmentRented(RentalID.Text)

    End Sub

    Private Sub EquipReturnButton_Click(sender As Object, e As EventArgs) Handles EquipReturnButton.Click
        Dim comment As String = ""
        Dim reception As String = ""
        Dim equipmentName As String = ""
        Dim rentals As IRentals

        If MessageBox.Show("Êtes-vous sûr de vouloir effectuer le retour pour cet equipement?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            If MessageBox.Show("Voulez vous ajouter un commentaire à ce retour?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                comment = InputBox("Note:", "Commentaires")
            End If
            reception = InputBox("Votre Nom:", "La personne qui reçoit ce retour")
            Dim selectIndex As Integer = DGVEquipments.SelectedCells(0).RowIndex
            Dim selectRow As DataGridViewRow = DGVEquipments.Rows(selectIndex)
            Dim equipment As String = selectRow.Cells("No_Équipement").Value
            equipmentName = selectRow.Cells("Nom_Équipement").Value
            comment = Regex.Replace(comment, "'", "''")
            comment = Regex.Replace(comment, "[^A-Za-z0-9' ]", String.Empty)
            ModelReturn.getInstance().addReturn(reception, equipmentName, comment)
            ModelRental.getInstance().deleteEquipmentFromRental(equipment)
            DGVEquipments.DataSource = EntityEquipment.getInstance.getEquipmentRented(RentalID.Text)
            DGVEquipments.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Else
            DGVEquipments.Select()
        End If

        If DGVEquipments.Rows.Count = 0 Then
            Me.SendToBack()
        End If

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.SendToBack()
    End Sub

    Private Sub FullReturnButton_Click(sender As Object, e As EventArgs) Handles FullReturnButton.Click
        Dim comment As String = ""
        Dim reception As String = ""
        Dim equipmentName As String = ""
        If MessageBox.Show("Êtes-vous sûr de vouloir effectuer le retour?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            If MessageBox.Show("Voulez vous ajouter un commentaire à ce retour?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                comment = InputBox("Note:", "Commentaires")
            End If
            reception = InputBox("Votre Nom:", "La personne qui reçoit ce retour")
            Dim selectIndex As Integer = DGVEquipments.SelectedCells(0).RowIndex
            Dim selectRow As DataGridViewRow = DGVEquipments.Rows(selectIndex)
            Dim equipment As String = selectRow.Cells("No_Équipement").Value
            equipmentName = selectRow.Cells("Nom_Équipement").Value
            comment = Regex.Replace(comment, "'", "''")
            comment = Regex.Replace(comment, "[^A-Za-z0-9' ]", String.Empty)
            ModelReturn.getInstance().addReturn(reception, equipmentName, comment)
            ModelRental.getInstance().deleteRental(RentalID.Text, equipment)
            DGVEquipments.DataSource = EntityEquipment.getInstance.getEquipmentRented(RentalID.Text)
            DGVEquipments.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Else
            DGVEquipments.Select()
        End If
        Me.SendToBack()
    End Sub
End Class
