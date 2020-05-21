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

    Public Function getReturnByReception(reception As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from retour where upper(nomReception) like upper('%{reception}%')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("retour")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getReturnByEquipmentName(equipmentName As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from retour where upper(nomEquipement) like upper('%{equipmentName}%')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("retour")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getReturnByDate(returnDate As Date) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from retour where extract(DAY from dateRetour) = {returnDate.Day} and extract(MONTH from dateRetour) = {returnDate.Month} and extract(YEAR from dateRetour) = {returnDate.Year}"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("retour")
        table.Load(reader)
        connection.Close()
        Return table
    End Function
End Class
