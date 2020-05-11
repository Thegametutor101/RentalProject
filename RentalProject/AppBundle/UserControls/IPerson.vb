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
        Dim person As New IAddPerson(Me)
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
        Dim person As New IModifyPerson(Me)
        person.Dock = DockStyle.Fill
        mainForm.InterfacePanel.Controls.Add(person)
        person.BringToFront()
    End Sub
End Class
