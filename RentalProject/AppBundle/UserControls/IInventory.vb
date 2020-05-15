Imports MySql.Data.MySqlClient
Public Class IInventory
    Dim mainForm As MainForm

    Sub New(main As MainForm)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
    End Sub

    Private Sub IInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = EntityEquipment.getInstance().getEquipment()
    End Sub


    Private Sub AddInventoryButton_Click(sender As Object, e As EventArgs) Handles AddInventoryButton.Click
        Dim Inventory As New IAddInventory(Me)
        Inventory.Dock = DockStyle.Fill
        mainForm.InterfacePanel.Controls.Add(Inventory)
        Inventory.BringToFront()
    End Sub

    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        Dim InventoryModif As New IModifyInventory(Me)
        InventoryModif.Dock = DockStyle.Fill
        mainForm.InterfacePanel.Controls.Add(InventoryModif)
        InventoryModif.BringToFront()
    End Sub

    Private Sub CategoryButton_Click(sender As Object, e As EventArgs) Handles CategoryButton.Click
        Dim category As New ICategory(Me)
        category.Dock = DockStyle.Fill
        mainForm.InterfacePanel.Controls.Add(category)
        category.BringToFront()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim result As DialogResult = MessageBox.Show("Voulez vous vraiment supprimer l'équipement selectionné?", "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim equipemententity As New EntityEquipment
            ModelEquipment.getInstance().delequipement(DataGridView1.SelectedRows.Item(0).Cells(0).Value)
            DataGridView1.DataSource = EntityEquipment.getInstance().getEquipment()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim InventorySearch As New IInventorySearch(Me)
        InventorySearch.Dock = DockStyle.Fill
        mainForm.InterfacePanel.Controls.Add(InventorySearch)
        InventorySearch.BringToFront()
    End Sub
End Class
