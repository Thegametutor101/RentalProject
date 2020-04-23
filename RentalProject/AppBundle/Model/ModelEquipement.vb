Imports MySql.Data.MySqlClient
Public Class ModelRental
    Dim connectionString = "Server='localhost';Database='projetsession';Uid='root';Pwd='';Port=3308;"
    Dim connection As New MySqlConnection(connectionString)
    Shared instance As ModelRental = Nothing
    Public Shared Function getInstance() As ModelRental
        If IsNothing(instance) Then
            instance = New ModelRental()
        End If
        Return instance
    End Function
    Public Function addRental(ByVal noPersonne As Integer,
                                   ByVal noEquipement As String,
                                   ByVal autorisation As String,
                                   ByVal duree As String,
                                   ByVal dateRetour As String,
                                   ByVal responsabilite As String)
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            connection.Open()
            command.CommandText = $"insert into emprunt
 
                values('','{noPersonne}','{noEquipement}', '{autorisation}', '{duree}', '{dateRetour}', '{responsabilite}')"

            Dim result = command.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("L'emprunt à été ajouté avec succès.")
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de l'ajout.")
        End Try

    End Function

    Public Function updateEquipementStatus(id As Integer) As Boolean
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"update equipement set disponibilite='non' where noEquipement='{id}'"
        connection.Open()
        Dim reader = command.ExecuteNonQuery()
        connection.Close()
        Return True
    End Function
End Class
