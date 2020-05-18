Imports MySql.Data.MySqlClient

Public Class ModelCategory

    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As ModelCategory = Nothing

    Public Shared Function getInstance() As ModelCategory
        If IsNothing(instance) Then
            instance = New ModelCategory()
        End If
        Return instance
    End Function

    Public Sub deleteCategory(id As Integer)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Delete from categorie where noCategorie = {id}"
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
        command.CommandText = $"Delete from equipement where noCategorie = {id}"
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Public Sub addCategory(ByVal nom As String)
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            connection.Open()
            command.CommandText = $"insert into categorie values('','{nom}',0)"

            Dim result = command.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("La categorie à été ajouté avec succès.")
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de l'ajout.")
        End Try
    End Sub

    Public Sub updateCategory(ByVal noCategorie As Integer, ByVal nom As String)
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            connection.Open()
            command.CommandText = $"update categorie set nom = '{nom}' where noCategorie = '{noCategorie}')"
            Dim result = command.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("La categorie à été modifiée avec succès.")
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de l'a modification")
        End Try
    End Sub
End Class
