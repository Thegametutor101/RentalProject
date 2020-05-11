Public Class IReturn

    Dim rentals As IRentals

    Sub New(Irentals As IRentals)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        rentals = Irentals
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.SendToBack()
        rentals.loadData(EntityRental.getInstance().getRentals())
    End Sub

    Private Sub IReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RentTableDGV.DataSource = EntityRental.getInstance().getRentals()
        RentTableDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        SearchButton.Enabled = False
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If (SearchTextBox.Text.Trim.Length > 0) Then
            Dim rentalTable As New EntityRental
            RentTableDGV.DataSource = rentalTable.getRentalByID(SearchTextBox.Text)
            RentTableDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Else
            MessageBox.Show("Entrez l'ID de l'emprunt pour démarrer la recherche.")
            SearchTextBox.Select()
        End If
    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        If MessageBox.Show("Êtes-vous sûr de vouloir effectuer le retour?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then


            Dim selectIndex As Integer = RentTableDGV.SelectedCells(0).RowIndex
            Dim selectRow As DataGridViewRow = RentTableDGV.Rows(selectIndex)
            Dim id As Integer = selectRow.Cells("ID").Value


            ModelRental.getInstance().deleteRental(id)

            RentTableDGV.DataSource = EntityRental.getInstance().getRentals()
            RentTableDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Else
            SearchTextBox.Select()
        End If
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        SearchTextBox.Text = Trim(SearchTextBox.Text)
        If Not IsNumeric(SearchTextBox.Text) And SearchTextBox.Text.Length > 0 Then
            MessageBox.Show("Valeur numerique obligatoire")
            SearchTextBox.Clear()
            SearchButton.Enabled = False
        ElseIf Not SearchTextBox.Text.Length > 0 Then
            SearchButton.Enabled = False
        Else
            SearchButton.Enabled = True
        End If
    End Sub

    Private Sub SearchButton_EnabledChanged(sender As Object, e As EventArgs) Handles SearchButton.EnabledChanged
        If SearchButton.Enabled Then
            WarningLabel.Hide()
        Else
            WarningLabel.Show()
        End If
    End Sub
End Class
