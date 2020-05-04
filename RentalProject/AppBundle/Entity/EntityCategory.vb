Imports MySql.Data.MySqlClient
Public Class EntityCategory

    Dim connectionString = "Server='localhost';Database='projetsession';Uid='root';Pwd='';Port=3306;"
    Dim connection As New MySqlConnection(connectionString)
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
        command.CommandText = $"Select C.noCategorie, c.nom, c.quantite from categorie C"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("categorie")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

End Class
