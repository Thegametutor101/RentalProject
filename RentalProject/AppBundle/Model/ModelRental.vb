Imports MySql.Data.MySqlClient

Public Class ModelRental
    Dim connectionString = "Server='localhost';Database='projetsession';Uid='root';Pwd='';Port=3308;Convert Zero Datetime=True"
    Dim connection As New MySqlConnection(connectionString)
    Shared instance As ModelRental = Nothing
    Public Shared Function getInstance() As ModelRental
        If IsNothing(instance) Then
            instance = New ModelRental()
        End If
        Return instance
    End Function

    Public Sub deleteRental(id As Integer)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Delete from emprunt where ID = {id}"
        updateStateEquipment(id)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    ''' <summary>
    ''' Mets l'équipement qui est retourné disponible.
    ''' </summary>
    ''' <param name="id"></param>
    Public Sub updateStateEquipment(id As Integer)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Update equipement set disponibilite = 'oui' where noEquipement = (Select noEquipement from emprunt where ID = {id})"
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Public Function addRental(ByVal noPersonne As Integer,
                              ByVal noEquipement As String,
                              ByVal autorisation As String,
                              ByVal dateEmprunt As Date,
                              ByVal duree As String,
                              ByVal dateRetour As Date,
                              ByVal commentaires As String)
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            connection.Open()
            command.CommandText = $"insert into emprunt
 
                values('',{noPersonne},'{noEquipement}', '{autorisation}', '{dateEmprunt.ToString("yyyy-MM-dd HH:mm:ss")}','{duree}', '{dateRetour.ToString("yyyy-MM-dd HH:mm:ss")}', '{commentaires}')"

            Dim result = command.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("L'emprunt à été ajouté avec succès.")
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de l'ajout.")
        End Try
    End Function

    ''' <summary>
    ''' Mets l'équipement qui est emprunté non disponible.
    ''' </summary>
    ''' <param name="id"></param>
    ''' <returns></returns>
    Public Function updateEquipementStatus(id As Integer) As Boolean
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"update equipement set disponibilite='non' where noEquipement='{id}'"
        connection.Open()
        Dim reader = command.ExecuteNonQuery()
        connection.Close()
        Return True
    End Function

    ''' <summary>
    ''' Cette fonction est appelé dans l'interface de modification
    ''' d'emprunt lorsque la date de retour est valide et
    ''' l'utilisateur appuie sur le bouton sauvegarder.
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="duree"></param>
    ''' <param name="dateRetour"></param>
    ''' <param name="commentaires"></param>
    ''' <returns></returns>
    Public Function updateRentalReturnDate(ByVal id As Integer,
                                           ByVal duree As String,
                                           ByVal dateRetour As Date,
                                           ByVal commentaires As String)
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            connection.Open()
            command.CommandText = $"update emprunt set duree = '{duree}', dateRetour = '{dateRetour.ToString("yyyy-MM-dd HH:mm:ss")}', commentaires = '{commentaires}' where ID = {id}"
            Dim result = command.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("L'emprunt à été modifié avec succès.")
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de la modification.")
        End Try
    End Function
End Class
