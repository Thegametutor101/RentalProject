Imports MySql.Data.MySqlClient

Public Class EntityEquipment

    Dim connectionString = "Server='localhost';Database='projetsession';Uid='root';Pwd='';Port=3308;"
    Dim connection As New MySqlConnection(connectionString)
    Shared instance As EntityEquipment = Nothing

    Public Shared Function getInstance() As EntityEquipment
        If IsNothing(instance) Then
            instance = New EntityEquipment()
        End If
        Return instance
    End Function

    Public Function getEquipment() As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from equipement"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("equipement")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getEquipmentByID(id As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from equipement where upper(noEquipement) = upper('{id}')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("equipement")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getEquipmentByName(name As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from equipement where upper(nom) like upper('{name}')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("equipement")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getEquipmentByCategoryName(name As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from equipement E inner join categorie C2 on E.noCategorie = C2.noCategorie where upper(C2.nom) = upper('{name}')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("equipement")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getEquipmentByCategoryID(id As Integer) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from equipement where noCategorie = '{id}'"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("equipement")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

End Class
