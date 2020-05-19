Public Class ICategory
    Dim inventory As IInventory

    Sub New(invt As IInventory)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        inventory = invt
    End Sub
    Private Sub Category_Refresh()
        DGVCategory.DataSource = EntityCategory.getInstance.getCategory
        DGVCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Private Sub ICategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Category_Refresh()
        AddButton.Enabled = False
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim name = Trim(TBName.Text)

        If name.Trim.Length > 0 Then
            ModelCategory.getInstance.addCategory(name)
            Category_Refresh()
        Else
            MessageBox.Show("Vous devez entre un nom de categorie.")
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If MessageBox.Show("Effacer la catégorie, deplacera tous les equipements attachez à celle-ci dans la catégorie Autre, êtes-vous sûr?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim selectIndex As Integer = DGVCategory.SelectedCells(0).RowIndex
            Dim selectRow As DataGridViewRow = DGVCategory.Rows(selectIndex)
            Dim id As Integer = selectRow.Cells("noCategorie").Value

            ModelCategory.getInstance().deleteCategory(id)

            DGVCategory.DataSource = EntityCategory.getInstance().getCategory()
            DGVCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Else
            DGVCategory.Select()
        End If
        Category_Refresh()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.SendToBack()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim search As New ICategorySearch(Me)
        search.Dock = DockStyle.Fill
        MainForm.InterfacePanel.Controls.Add(search)
        search.BringToFront()
    End Sub

    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        Dim modifyMessage = InputBox("Entrez le noveau nom de la catégorie", "Modifier catégorie")

        ModelCategory.getInstance.updateCategory(DGVCategory.SelectedRows.Item(0).Cells(0).Value, modifyMessage)
        Category_Refresh()
    End Sub

    Private Sub TBName_TextChanged(sender As Object, e As EventArgs) Handles TBName.TextChanged
        TBName.Text = Trim(TBName.Text)
        If Not TBName.Text.Length > 0 Then
            AddButton.Enabled = False
        Else
            AddButton.Enabled = True
        End If
    End Sub

    Private Sub AddButton_EnabledChanged(sender As Object, e As EventArgs) Handles AddButton.EnabledChanged
        If AddButton.Enabled Then
            WarningLabel.Hide()
        Else
            WarningLabel.Show()
        End If
    End Sub


End Class
