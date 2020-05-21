﻿Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class ICategorieAutre
    Dim dt As New DataTable
    Dim ds As New DataSet
    Public connectionString = $"{MainForm.getInstance.connectionString}Convert Zero Datetime=True"
    Dim connection As New MySqlConnection(connectionString)
    Dim reader As MySqlDataReader
    Dim com As New MySqlCommand
    Dim adapter As New MySqlDataAdapter



    Public Function LoadListViewAutre(data As DataTable)
        ListView1.Items.Clear()
        Dim rentalTable As DataTable = data

        For Each it As DataRow In rentalTable.Rows
            If Not IsNothing(it) Then
                ListView1.Items.Add(New ListViewItem({it.Item(0), it.Item(1), it.Item(2), it.Item(3), it.Item(4)}))
            End If
        Next
    End Function
    Private Sub ICategorieAutre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadListViewAutre(EntityEquipment.getInstance.getEquipmentByCategoryID(0))
        refreshCategorie()
    End Sub

    Public Function refreshCategorie()
        CbCategorie.Items.Clear()
        CbCategorie.Enabled = True
        Dim ctr1 As Integer
        ctr1 = 0
        com.CommandText = $"select nom from categorie where nocategorie<>0"
        com.Connection = connection
        connection.Open()
        reader = com.ExecuteReader
        While (reader.Read)
            CbCategorie.Items.Add(reader.GetString(0))
            ctr1 += 1
        End While
        connection.Close()
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim NoEquipement As Integer
        Dim NomCategorie As String
        Dim NoCategorie As Integer
        NomCategorie = CbCategorie.Text
        If MessageBox.Show($"Vous êtes sur le point de changer la catégorie de{ListView1.SelectedItems.Count} equipement(s) pour la catégorie {NomCategorie}, êtes-vous sûr?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

            com.CommandText = $"select nocategorie from categorie where nom= '{NomCategorie}'"
            com.Connection = connection
            connection.Open()
            reader = com.ExecuteReader
            While (reader.Read)
                NoCategorie = reader.GetString(0)
            End While
            connection.Close()
            For Each item As ListViewItem In Me.ListView1.SelectedItems
                NoEquipement = CInt(item.SubItems.Item(0).Text)
                ModelEquipment.getInstance.updateeEquipementCategorie(NoEquipement, NoCategorie)
            Next
            LoadListViewAutre(EntityEquipment.getInstance.getEquipmentByCategoryID(0))

        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.SendToBack()
    End Sub
End Class
