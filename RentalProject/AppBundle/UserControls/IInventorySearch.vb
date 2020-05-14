Imports MySql.Data.MySqlClient
Public Class IInventorySearch
    Dim Inventory As IInventory

    Sub New(IInventory As IInventory)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Inventory = IInventory
    End Sub

    Private Sub IInventorySearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = EntityEquipment.getInstance().getEquipment()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            DataGridView1.DataSource = EntityEquipment.getInstance().getEquipmentByID(TextBox1.Text)
        ElseIf RadioButton2.checked Then
            DataGridView1.DataSource = EntityEquipment.getInstance().getEquipmentByName(TextBox1.Text)
        ElseIf RadioButton3.checked Then
            DataGridView1.DataSource = EntityEquipment.getInstance().getEquipmentByCategoryName(TextBox1.Text)
        ElseIf RadioButton4.checked Then
            DataGridView1.DataSource = EntityEquipment.getInstance().getEquipmentByEtat(TextBox1.Text)
        Else MessageBox.Show("Veuillez sélectionner une valeur de recherche")
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        'Retour au UC inventaire
        If MessageBox.Show($"Voulez-vous vraiment faire cette opération?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.SendToBack()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim InventoryDetails As New IEquipmentDetails(Me)
        InventoryDetails.Dock = DockStyle.Fill
        MainForm.InterfacePanel.Controls.Add(InventoryDetails)
        InventoryDetails.BringToFront()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
