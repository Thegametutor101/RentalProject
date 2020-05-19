Imports MySql.Data.MySqlClient
Public Class ModelEquipment

    'Connection à la base de données
    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As ModelEquipment = Nothing

    Public Shared Function getInstance() As ModelEquipment
        If IsNothing(instance) Then
            instance = New ModelEquipment()
        End If
        Return instance
    End Function

    'on va modifier un équipement en fonction de certaines valeurs
    Public Function updateequipment(noequipement As Integer, nom As String, nocategorie As Integer, etat As String, disponibilite As String)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"update equipement set nom='{nom}',nocategorie='{nocategorie + 1}',etat='{etat}',disponibilite='{disponibilite}' where noequipement='{noequipement}'"
        connection.Open()
        Dim add As Integer = command.ExecuteNonQuery()
        connection.Close()
    End Function

    'on ajoute un équipement à la base de données en fonction de certaines valeurs
    Public Function addequipment(noequipement As String, nom As String, nocategorie As Integer, etat As String, disponibilite As String)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"insert into equipement values ('{noequipement}','{nom}','{nocategorie}','{etat}','{disponibilite}')"
        connection.Open()
        Dim add As Integer = command.ExecuteNonQuery()
        connection.Close()
    End Function

    'on supprime un Équipement de la table via son ID
    Public Function delequipement(noequipement As Integer)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Delete from equipement where noequipement = '{noequipement}'"
        connection.Open()
        Dim reader = command.ExecuteReader()
        connection.Close()
    End Function

    Public Function updateeEquipementCategorie(noequipement As Integer, nocategorie As Integer)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"update equipement set nocategorie={nocategorie} where noequipement={noequipement}"
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Function
End Class

