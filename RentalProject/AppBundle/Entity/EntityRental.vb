Imports MySql.Data.MySqlClient

Public Class EntityRental

    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
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

    Public Function getRentalsByRenterFirstName(firstName As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation) from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne where upper(P.prenom) like upper('{firstName}%')"
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
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation) from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne where upper(P.nom) like upper('{lastName}%')"
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
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation) from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne where upper(P.prenom) like upper('{firstName}%') and upper(P.nom) like upper('{lastName}%')"
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
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation) from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne inner join categorie C2 on E2.noCategorie = C2.noCategorie where upper(C2.nom) like upper('%{name}%')"
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
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation) from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne where upper(E.autorisation) like upper('{name}%')"
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

    Public Function getRentalDetailed(id As Integer) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        connection.Open()
        command.CommandText = $"Select E.ID, initcap(P.prenom), initcap(P.nom), initcap(P.statut), P.email, initcap(E2.nom), initcap(C2.nom), initcap(E2.etat), initcap(E.autorisation), E.DateEmprunt, E.dateRetour from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne inner join categorie C2 on E2.noCategorie = C2.noCategorie where E.ID = {id}"
        Dim reader = command.ExecuteReader()
        Dim rentalTable As New DataTable("emprunt")
        rentalTable.Load(reader)
        connection.Close()
        Return rentalTable
    End Function

    Public Function getRentalDatesbyID(id As Integer) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        connection.Open()
        command.CommandText = $"Select E.ID, initcap(concat(P.nom, ', ', P.prenom)), E2.nom as Nom_Équipement, initcap(E.autorisation), E.DateEmprunt, E.duree, E.dateRetour, E.commentaires from emprunt E inner join equipement E2 on E.noEquipement = E2.noEquipement inner join personne P on E.noPersonne = P.noPersonne where E.ID = {id}"
        Dim reader = command.ExecuteReader()
        Dim rentalTable As New DataTable("emprunt")
        rentalTable.Load(reader)
        connection.Close()
        Return rentalTable
    End Function
End Class