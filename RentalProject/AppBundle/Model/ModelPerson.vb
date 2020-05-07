Imports MySql.Data.MySqlClient

Public Class ModelPerson
    Dim connectionString = "Server='localhost';Database='projetsession';Uid='root';Pwd='';Port=3308;Convert Zero Datetime=True"
    Dim connection As New MySqlConnection(connectionString)
    Shared instance As ModelPerson = Nothing

    Public Shared Function getInstance() As ModelPerson
        If IsNothing(instance) Then
            instance = New ModelPerson()
        End If
        Return instance
    End Function

    Public Sub deletePerson(id As Integer)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Delete from personne where noPersonne = {id}"
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Public Sub addPerson(ByVal nom As String,
                         ByVal prenom As String,
                         ByVal statut As String,
                         ByVal departement As String,
                         ByVal service As String,
                         ByVal bureau As String,
                         ByVal telephone As Integer,
                         ByVal poste As Integer)
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            connection.Open()
            command.CommandText = $"insert into personne
            values('','{nom}','{prenom}', '{statut}', '{departement}', '{service}', '{bureau}', '{telephone}', '{poste}')"

            Dim result = command.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("La personne à été ajouté avec succès.")
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de l'ajout.")
        End Try
    End Sub

End Class
