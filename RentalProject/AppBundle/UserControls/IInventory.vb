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
End Class
