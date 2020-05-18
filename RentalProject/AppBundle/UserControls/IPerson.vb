Public Class IPerson
    Dim mainForm As MainForm

    Sub New(main As MainForm)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
    End Sub

    Private Sub IPeople_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVPerson.DataSource = EntityPerson.getInstance().getPerson()
        DGVPerson.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim person As New IAddPerson(New IEmprunt(New IRentals(mainForm)))
        person.Dock = DockStyle.Fill
        mainForm.InterfacePanel.Controls.Add(person)
        person.BringToFront()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If MessageBox.Show("Êtes-vous sûr de vouloir effacer cette personne?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim selectIndex As Integer = DGVPerson.SelectedCells(0).RowIndex
            Dim selectRow As DataGridViewRow = DGVPerson.Rows(selectIndex)
            Dim id As Integer = selectRow.Cells("noPersonne").Value

            ModelPerson.getInstance().deletePerson(id)

            DGVPerson.DataSource = EntityPerson.getInstance().getPerson()
            DGVPerson.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Else
            DGVPerson.Select()
        End If
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim person As New IPersonSearch(Me)
        person.Dock = DockStyle.Fill
        mainForm.InterfacePanel.Controls.Add(person)
        person.BringToFront()
    End Sub

    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        If Not IsNothing(DGVPerson.Rows(DGVPerson.SelectedRows.Item(0).Index).Cells(0).Value) Then
            Dim data As DataTable = EntityPerson.getInstance().getPersonByID(DGVPerson.Rows(DGVPerson.SelectedRows.Item(0).Index).Cells(0).Value)
            Dim modifyPerson As New IModifyPerson(mainForm, data)
            modifyPerson.Dock = DockStyle.Fill
            mainForm.InterfacePanel.Controls.Add(modifyPerson)
            modifyPerson.BringToFront()
        End If
    End Sub

    Private Sub DetailsButton_Click(sender As Object, e As EventArgs) Handles DetailsButton.Click
        If Not IsNothing(DGVPerson.Rows(DGVPerson.SelectedRows.Item(0).Index).Cells(0).Value) Then
            Dim data As DataTable = EntityPerson.getInstance().getPersonByID(DGVPerson.Rows(DGVPerson.SelectedRows.Item(0).Index).Cells(0).Value)
            Dim detailsPerson As New IPersonDetails(mainForm, data)
            detailsPerson.Dock = DockStyle.Fill
            mainForm.InterfacePanel.Controls.Add(detailsPerson)
            detailsPerson.BringToFront()
        End If
    End Sub
End Class
