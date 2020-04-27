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


    Public Function getRentals() As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)) as Emprunté_par, E2.nom as Nom_Équipement, initcap(E.autorisation) as autorisation from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("emprunt")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentalsByIdFormat(id As Integer) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation) from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne where ID = {id}"
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
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation) from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne where noPersonne = {id}"
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
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation) from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne where upper(P.prenom) like upper('{firstName}')"
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
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation) from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne where upper(P.nom) like upper('{lastName}')"
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
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation) from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne where upper(P.prenom) like upper('{firstName}') and upper(P.nom) like upper('{lastName}')"
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
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation) from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne where noEquipement = {id}"
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
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation) from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne where upper(E2.nom) like upper('{name}')"
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
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation) from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne where noCategorie = {id}"
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
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation) from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne inner join categorie C2 on E2.noCategorie = C2.noCategorie where upper(C2.nom) like upper('{name}')"
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
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation) from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne where upper(E.autorisation) like upper('{name}')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("emprunt")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getRentalByID(id As Integer) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        connection.Open()
        command.CommandText = $"Select * from emprunt where ID = {id}"
        Dim reader = command.ExecuteReader()
        Dim rentalTable As New DataTable("emprunt")
        rentalTable.Load(reader)
        connection.Close()
        Return rentalTable
    End Function

End Class