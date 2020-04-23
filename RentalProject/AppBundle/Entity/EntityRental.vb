Imports MySql.Data.MySqlClient

Public Class EntityRental

    Dim connectionString = "Server='localhost';Database='projetsession';Uid='root';Pwd='';Port=3308;"
    Dim connection As New MySqlConnection(connectionString)
    Shared instance As EntityRental = Nothing

    Public Shared Function getInstance() As EntityRental
        If IsNothing(instance) Then
            instance = New EntityRental()
        End If
        Return instance
    End Function

    'Public Function getRentals() As DataTable
    '    Dim command As New MySqlCommand
    '    command.Connection = connection
    '    command.CommandText = $"Select * from emprunt"
    '    connection.Open()
    '    Dim reader = command.ExecuteReader()
    '    Dim table As New DataTable("emprunt")
    '    table.Load(reader)
    '    connection.Close()
    '    Return table
    'End Function

    Public Function getRentals() As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select initcap(P.nom||', '||P.prenom) as Emprunté_Par, E2.nom as Nom_Équipement, E.autorisation from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("emprunt")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentalsById(id As Integer) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from emprunt where ID = {id}"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("emprunt")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentalsByRenterId(id As Integer) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from emprunt where noPersonne = {id}"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("emprunt")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentalsByRenterFirstName(firstName As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from emprunt E inner join personne P on E.noPersonne = P.noPersonne where upper(prenom) like upper('{firstName}')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("emprunt")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentalsByRenterLastName(lastName As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from emprunt E inner join personne P on E.noPersonne = P.noPersonne where upper(nom) like upper('{lastName}')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("emprunt")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentalsByRenterFirstAndLastName(firstName As String, lastName As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from emprunt E inner join personne P on E.noPersonne = P.noPersonne where upper(prenom) like upper('{firstName}') and upper(nom) like upper('{lastName}')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("emprunt")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentalsByEquipmentNumber(id As Integer) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from emprunt where noEquipement = {id}"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("emprunt")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentalsByEquipmentName(name As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement where upper(E2.nom) like upper('{name}')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("emprunt")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentalsByCategoryNumber(id As Integer) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement where noCategorie = {id}"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("emprunt")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentalsByCategoryName(name As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join categorie C2 on E2.noCategorie = C2.noCategorie where upper(C2.nom) like upper('{name}')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("emprunt")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentalsByRenteeName(name As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from emprunt where upper(authorisation) like upper('{name}')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("emprunt")
        table.Load(reader)
        connection.Close()
        Return table
    End Function
End Class