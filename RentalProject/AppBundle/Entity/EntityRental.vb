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

    Public Function getRental() As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from emprunt"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim rentalTable As New DataTable("emprunt")
        rentalTable.Load(reader)
        connection.Close()
        Return rentalTable
    End Function

    Public Function getRentalByID(id As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select * from emprunt where upper(ID) = upper('{id}')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim rentalTable As New DataTable("emprunt")
        rentalTable.Load(reader)
        connection.Close()
        Return rentalTable
    End Function

    Public Sub deleteRental(id As String)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Delete from emprunt where upper(ID) = upper('{id}')"
        updateStateEquipment(id)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Public Sub updateStateEquipment(id As String)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Update equipement set disponibilite = 'oui' where noEquipement = (Select noEquipement from emprunt where upper(ID) = upper('{id}'))"
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

End Class
