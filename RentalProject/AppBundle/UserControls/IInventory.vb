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
        Dim con As New MySqlConnection("Server='localhost';Database='BD';Uid='root';Pwd='';Port=3306")
        Dim com As New MySqlCommand
        com.Connection = con
        'Dim i = DGVLocaux.CurrentRow.Index
        'Dim test As String = DGVLocaux.Item(0, i).Value
        com.CommandText = "Select * from equipement"
        Dim read As MySqlDataReader
        con.Open()
        read = com.ExecuteReader
        Dim tableequipement As New DataTable("equipement")
        tableequipement.Load(read)
        DataGridView1.DataSource = tableequipement
        con.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

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
