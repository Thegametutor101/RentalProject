Imports MySql.Data.MySqlClient

Public Class EntityEquipment

    Dim connectionString = "Server='localhost';Database='projetsession';Uid='root';Pwd='';Port=3306;"
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

    Public Function updateequipment(noequipement As Integer, nom As String, nocategorie As Integer, etat As String, disponibilite As String)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"update equipement set nom='{nom}',nocategorie='{nocategorie + 1}',etat='{etat}',disponibilite='{disponibilite}' where noequipement='{noequipement}'"
        connection.Open()
        Dim add As Integer = command.ExecuteNonQuery()
        connection.Close()
    End Function

    Public Function addequipment(noequipement As Integer, nom As String, nocategorie As Integer, etat As String, disponibilite As String)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"insert into equipement values ('{noequipement}','{nom}','{nocategorie + 1}','{etat}','{disponibilite}')"
        connection.Open()
        Dim add As Integer = command.ExecuteNonQuery()
        connection.Close()
    End Function

    Public Function nextid() As Integer
        Dim command As New MySqlCommand
        Dim ID As Integer
        command.Connection = connection
        command.CommandText = "select max(noequipement) from equipement"
        connection.Open()
        Dim reader = command.ExecuteReader()
        reader.Read()
        ID = reader(0)
        connection.Close()
        Return (ID + 1)
    End Function

    Public Function delequipement(noequipement As Integer)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Delete from equipement where noequipement = '{noequipement}'"
        connection.Open()
        Dim reader = command.ExecuteReader()
        connection.Close()
    End Function

End Class
