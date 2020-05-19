'Imports MySql.Data.MySqlClient
Public Class IInventorySearch
    Dim Inventory As IInventory

    Sub New(IInventory As IInventory)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Inventory = IInventory
    End Sub

    Private Sub IInventorySearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'on copie la datagridview inventaire pour la mettre dans le contrôle utilisateur de recherche
        Try
            DataGridView1.DataSource = EntityEquipment.getInstance().getEquipment()
        Catch ex As Exception
            MessageBox.Show("Le chargement des données a échoué:" + ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'on vérifie quel radio button est sélectionné pour savoir quel est le critère de recherche
        Try
            If RadioButton1.Checked Then
                DataGridView1.DataSource = EntityEquipment.getInstance().getEquipmentByID(TextBox1.Text)
            ElseIf RadioButton2.Checked Then
                DataGridView1.DataSource = EntityEquipment.getInstance().getEquipmentByName(TextBox1.Text)
            ElseIf RadioButton3.Checked Then
                DataGridView1.DataSource = EntityEquipment.getInstance().getEquipmentByCategoryName(TextBox1.Text)
            ElseIf RadioButton4.Checked Then
                DataGridView1.DataSource = EntityEquipment.getInstance().getEquipmentByEtat(TextBox1.Text)
            Else
                'message d'erreur si aucun bouton n'est sélectionné
                MessageBox.Show("Veuillez sélectionner une valeur de recherche")
            End If
        Catch ex As Exception
            MessageBox.Show("La recherche a échoué:" + ex.Message)
        End Try
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        'Retour au UC inventaire
        Me.SendToBack()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'on s'assure qu'un équipement est sélectionné
        Try
            If DataGridView1.CurrentRow.Index >= 0 And DataGridView1.SelectedRows.Item(0).Cells(0).Value <> "" Then
                'on ouvre le contrôle utilisateur de détails
                Dim InventoryDetails As New IEquipmentDetails(Me)
                InventoryDetails.Dock = DockStyle.Fill
                MainForm.InterfacePanel.Controls.Add(InventoryDetails)
                InventoryDetails.BringToFront()
            Else
                'message d'erreur lorsque l'index est négatif
                MessageBox.Show("Veuillez sélectionner une élément à détailler")
            End If
        Catch
            'message d'erreur lorsque l'index n'est pas adéquat
            MessageBox.Show("Veuillez sélectionner une élément à détailler")
        End Try
    End Sub
End Class
