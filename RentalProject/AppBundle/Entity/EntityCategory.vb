Imports MySql.Data.MySqlClient

Public Class EntityCategory
    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As EntityCategory = Nothing

    Public Shared Function getInstance() As EntityCategory
        If IsNothing(instance) Then
            instance = New EntityCategory()
        End If
        Return instance
    End Function

    Public Function getCategory() As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from categorie"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("categorie")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getCategoryByID(id As Integer) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from categorie where upper(noCategorie) = upper('{id}')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("categorie")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getCategoryByName(name As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from categorie where upper(nom) like upper('{name}')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("categorie")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getCategoryByQuantity(quantity As Integer) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from categorie where upper(quantite) like upper('{quantity}')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("categorie")
        table.Load(reader)
        connection.Close()
        Return table
    End Function
End Class
