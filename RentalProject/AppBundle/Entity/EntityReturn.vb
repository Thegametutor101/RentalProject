Imports MySql.Data.MySqlClient

Public Class EntityReturn

    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As EntityReturn = Nothing

    Public Shared Function getInstance() As EntityReturn
        If IsNothing(instance) Then
            instance = New EntityReturn()
        End If
        Return instance
    End Function

    Public Function getReturn() As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from retour"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("retour")
        table.Load(reader)
        connection.Close()
        Return table
    End Function
End Class
