Public Class IInventory
    Dim mainForm As MainForm

    Sub New(main As MainForm)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
    End Sub

    Private Sub IInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Lors de l'inventaire, on va chercher les équipements pour les mettre dans une datagridview
        Try
            DataGridView1.DataSource = EntityEquipment.getInstance().getEquipment()
        Catch ex As Exception
            MessageBox.Show("Il y a eu une erreur lors de l'accès aux données:" + ex.Message)
        End Try
    End Sub


    Private Sub AddInventoryButton_Click(sender As Object, e As EventArgs) Handles AddInventoryButton.Click
        'Ouverture du contrôle utilisateur d'ajout d'équipement
        Try
            Dim Inventory As New IAddInventory(Me)
            Inventory.Dock = DockStyle.Fill
            mainForm.InterfacePanel.Controls.Add(Inventory)
            Inventory.BringToFront()
        Catch ex As Exception
            MessageBox.Show("L'ouverture de la page d'ajout a échoué:" + ex.Message)
        End Try
    End Sub

    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        'Ouverture du Contrôle utilisateur de modification d'équipement
        Try
            Dim InventoryModif As New IModifyInventory(Me)
            InventoryModif.Dock = DockStyle.Fill
            mainForm.InterfacePanel.Controls.Add(InventoryModif)
            InventoryModif.BringToFront()
        Catch ex As Exception
            MessageBox.Show("L'ouverture de la page de modifications a échoué:" + ex.Message)
        End Try
    End Sub

    Private Sub CategoryButton_Click(sender As Object, e As EventArgs) Handles CategoryButton.Click
        'Ouverture du contrôle utilisateur des catégories d'équipement
        Try
            Dim category As New ICategory(Me)
            category.Dock = DockStyle.Fill
            mainForm.InterfacePanel.Controls.Add(category)
            category.BringToFront()
        Catch ex As Exception
            MessageBox.Show("L'ouverture de la page de Catégories a échoué:" + ex.Message)
        End Try
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        'Bouton permettant la suppression d'un équipement
        'Confirmation de la suppression
        Try
            Dim result As DialogResult = MessageBox.Show("Voulez vous vraiment supprimer l'équipement selectionné?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim equipemententity As New EntityEquipment
                'Suppression
                ModelEquipment.getInstance().delequipement(DataGridView1.SelectedRows.Item(0).Cells(0).Value)
                'mise à jour de la Datagridview
                DataGridView1.DataSource = EntityEquipment.getInstance().getEquipment()
            End If
        Catch ex As Exception
            MessageBox.Show("La tentative de supression de l'équipement a échoué:" + ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Ouverture du contrôle utilisateur de recherche d'équipement
        Try
            Dim InventorySearch As New IInventorySearch(Me)
            InventorySearch.Dock = DockStyle.Fill
            mainForm.InterfacePanel.Controls.Add(InventorySearch)
            InventorySearch.BringToFront()
        Catch ex As Exception
            MessageBox.Show("L'ouverture de la page de recherche a échoué:" + ex.Message)
        End Try
    End Sub

    Private Sub BtAutre_Click(sender As Object, e As EventArgs) Handles BtAutre.Click
        'Ouverture du contrôle utilisateur de recherche d'équipement
        Dim ICategorieAutre As New ICategorieAutre()
        ICategorieAutre.Dock = DockStyle.Fill
        mainForm.InterfacePanel.Controls.Add(ICategorieAutre)
        ICategorieAutre.BringToFront()
    End Sub
End Class
