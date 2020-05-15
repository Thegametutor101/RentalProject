Imports MySql.Data.MySqlClient
Public Class ModelEquipment
    'Connection à la base de données
    Dim connectionString = "Server='localhost';Database='projetsession';Uid='root';Pwd='';Port=3308;"
    Dim connection As New MySqlConnection(connectionString)
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

    'On va chercher les prochain ID pour éviter un doublon de clé primaire
    Public Function nextid() As Integer
        Dim command As New MySqlCommand
        Dim ID As Integer
        command.Connection = connection
        command.CommandText = "select max(noequipement) from equipement"
        connection.Open()
        Dim reader = command.ExecuteReader()
        reader.Read()
        ID = reader(0)
        connection.Close()
        Return (ID + 1)
    End Function

    'on ajoute un équipement à la base de données en fonction de certaines valeurs
    Public Function addequipment(noequipement As Integer, nom As String, nocategorie As Integer, etat As String, disponibilite As String)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"insert into equipement values ('{noequipement}','{nom}','{nocategorie + 1}','{etat}','{disponibilite}')"
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
End Class

