﻿Imports MySql.Data.MySqlClient

Public Class IModifyInventory

    Dim Inventory As IInventory

    Sub New(IInventory As IInventory)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Inventory = IInventory
    End Sub

    Private Sub IModifyInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'on va chercher les différentes catégories existantes pour la combobox
        loadData(EntityCategory.getInstance.getCategory)
    End Sub

    Public Function loadData(data As DataTable)
        'Création de la table comprenant toutes les catégories
        Dim categoryTable As DataTable = data
        For Each it As DataRow In categoryTable.Rows
            If Not IsNothing(it) Then
                CBCat.DataSource = categoryTable
                CBCat.DisplayMember = "nom"
                CBCat.ValueMember = "nocategorie"
            End If
        Next
        'Inscrire les informations de l;'équipement Sélectionné
        'on ne doit pas permettre la modification de l'ID c'Est pourquoi c'Est un label
        LabelNo.Text = Inventory.DataGridView1.SelectedRows.Item(0).Cells(0).Value
        TBName.Text = Inventory.DataGridView1.SelectedRows.Item(0).Cells(1).Value
        CBCat.Text = Inventory.DataGridView1.SelectedRows.Item(0).Cells(2).Value
        TBEtat.Text = Inventory.DataGridView1.SelectedRows.Item(0).Cells(3).Value
        TBDispo.Text = Inventory.DataGridView1.SelectedRows.Item(0).Cells(4).Value
    End Function

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click, ButtonCancel.Click
        'Retour au UC inventaire
        If MessageBox.Show($"Voulez-vous vraiment faire cette opération?{Environment.NewLine}Tous vos changement seront perdus.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.SendToBack()
        End If
    End Sub

    Public Function UpdateEquipement()
        'Création des variables pour l'update
        Dim equipementEntity As New EntityEquipment
        Dim noEquipement As Integer
        Dim nom As String
        Dim nocategorie As Integer
        Dim etat As String
        Dim disponibilite As String
        Try
            'on vérifie si tous les champs sont Remplis
            noEquipement = LabelNo.Text
            nom = TBName.Text
            nocategorie = CBCat.SelectedIndex
            etat = TBEtat.Text
            disponibilite = TBDispo.Text
            'on update l'équipement dans la table
            ModelEquipment.getInstance.updateequipment(noEquipement, nom, nocategorie, etat, disponibilite)
        Catch ex As Exception
            'message d'erreur lorsque l'un des champs n'est pas rempli
            MessageBox.Show("Valeur invalide - Veuillez vérifier tous les champs")
        End Try
    End Function

    Private Sub ButtonModif_Click(sender As Object, e As EventArgs) Handles ButtonModif.Click
        'Confirmation de la modification
        Dim result As DialogResult = MessageBox.Show("Voulez vous modifier l'équipement de la base de donnée, ses nouvelles informations seront:" & vbCrLf & "NoEquipement: " & LabelNo.Text & vbCrLf & "Nom: " & TBName.Text & vbCrLf & "Catégorie: " & CBCat.Text & vbCrLf & "État:" & TBEtat.Text & vbCrLf & "Dispo: " & TBDispo.Text, "Confirmation", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            'appel de la procédure de mise à jour
            UpdateEquipement()
            'mise à jour de la datagridview Inventaire
            Inventory.DataGridView1.DataSource = EntityEquipment.getInstance().getEquipment()
            Me.SendToBack()
        End If
    End Sub
End Class
