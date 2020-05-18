Imports MySql.Data.MySqlClient

Public Class EntityEquipment

    'création de la connection à la base de données
    Dim connectionString = "Server='localhost';Database='projetsession';Uid='root';Pwd='';Port=3308;"
    'création de la connection mysql
    Dim connection As New MySqlConnection(connectionString)
    Shared instance As EntityEquipment = Nothing

    Public Shared Function getInstance() As EntityEquipment
        If IsNothing(instance) Then
            instance = New EntityEquipment()
        End If
        Return instance
    End Function

    'on va chercher les informations nécessaires pour la datagridview inventaire (select all de équipement, mais on remplace le noCategorie par le nom de la dite catégorie)
    Public Function getEquipment() As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select e.noequipement, e.nom, c.nom as categorie, e.etat, e.disponibilite from equipement e inner join categorie c on c.nocategorie=e.nocategorie"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("equipement")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    'on va chercher toutes les informations des équipements (select all)
    Public Function getEquipment_noCategorie() As DataTable
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

    'On va chercher le(s) équipement(s) qui ont un certain ID
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

    'On va chercher le(s) équipement(s) qui ont un certain Nom
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

    'On va chercher le(s) équipement(s) qui ont un certain nom de catégorie
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

    'On va chercher le(s) équipement(s) qui ont un certain noCategorie
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

    'On va chercher le(s) équipement(s) qui ont un certain Etat
    Public Function getEquipmentByEtat(etat As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from equipement where upper(etat) like upper('{etat}')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("equipement")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    'On va chercher les infroamtions d'un équipement en fonction de son Id, ainsi que de l'emprunt qui lui est associé et de la personne qui l'a emprunté
    Public Function getEquipmentDetailed(id As Integer) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        connection.Open()
        command.CommandText = $"Select E.noEquipement, initcap(E.nom), initcap(C2.nom), initcap(E.etat),initcap(P.prenom), initcap(P.nom), initcap(P.statut), P.noBureau, initcap(E2.autorisation), E2.DateEmprunt, E2.dateRetour from equipement E left join emprunt E2 on E.noEquipement = E2.noEquipement left join personne P on E2.noPersonne = P.noPersonne inner join categorie C2 on E.noCategorie = C2.noCategorie where E.NoEquipement = {id}"
        Dim reader = command.ExecuteReader()
        Dim equipmentTable As New DataTable("equipement")
        equipmentTable.Load(reader)
        connection.Close()
        Return equipmentTable
    End Function

    Public Function getEquipmentIDs() As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        connection.Open()
        command.CommandText = $"Select noEquipement from equipement"
        Dim reader = command.ExecuteReader()
        Dim equipmentTable As New DataTable("equipement")
        equipmentTable.Load(reader)
        connection.Close()
        Return equipmentTable
    End Function

End Class
