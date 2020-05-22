Imports MySql.Data.MySqlClient

Public Class EntityReturn

    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As EntityReturn = Nothing

    Public Shared Function getInstance() As EntityReturn
        If IsNothing(instance) Then
            instance = New EntityReturn()
        End If
        Return instance
    End Function

    Public Function getReturn() As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select distinct R.noRetour, initcap(R.nomReception) as Reçu_par, initcap(concat(P.nom, ', ', P.prenom)) as Retourné_par, R.note from retour R inner join personne P on R.noPersonne = P.noPersonne order by R.noRetour"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("retour")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function testConnection() As Boolean
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim cmd As New MySqlCommand("SELECT IF(EXISTS (SELECT SCHEMA_NAME " &
        "FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = @DbName), 'Y','N')", connection)
        cmd.Parameters.AddWithValue("@DbName", "projetsession")
        connection.Open()
        Dim exists As String = cmd.ExecuteScalar().ToString()
        Console.WriteLine(exists)
        connection.Close()
        Return IF(exists = "Y", True, False)
    End Function

    Public Function getReturnByID(id As Integer) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select distinct R.noRetour, initcap(R.nomReception) as Reçu_par, P.nom, P.prenom, P.statut, P.email, R.dateRetour, R.note from retour R inner join personne P on R.noPersonne = P.noPersonne where noRetour = {id}"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("retour")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getReturnEquipments(id As Integer) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select R.noEquipement, E.nom from retour R inner join equipement E on R.noEquipement = E.noEquipement where noRetour = {id} order by R.noEquipement"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("retour")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getReturnByReception(reception As String) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select distinct noRetour, initcap(nomReception) as Reçu_par, initcap(concat(P.nom, ', ', P.prenom)) as Retourné_par, note from retour R inner join personne P on R.noPersonne = P.noPersonne where upper(R.nomReception) like upper('%{reception}%') order by R.noRetour"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("retour")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getReturnByRenterName(name As String) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select distinct noRetour, initcap(nomReception) as Reçu_par, initcap(concat(P.nom, ', ', P.prenom)) as Retourné_par, note from retour R inner join personne P on R.noPersonne = P.noPersonne where upper(initcap(concat(P.nom, ', ', P.prenom))) like upper('%{name}%') order by R.noRetour"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("retour")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getReturnByDate(returnDate As Date) As DataTable
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select distinct noRetour, initcap(nomReception) as Reçu_par, initcap(concat(P.nom, ', ', P.prenom)) as Retourné_par, note from retour R inner join personne P on R.noPersonne = P.noPersonne where extract(DAY from R.dateRetour) = {returnDate.Day} and extract(MONTH from R.dateRetour) = {returnDate.Month} and extract(YEAR from R.dateRetour) = {returnDate.Year} order by R.noRetour"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("retour")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function verifPersonHasReturn(id As Integer) As Boolean
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Select noPersonne from retour where noPersonne = {id}"
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim rentalTable As New DataTable("retout")
            rentalTable.Load(reader)
            connection.Close()
            If rentalTable.Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show("Erreur lors de la vérification des retour de cette personne.")
        End Try
    End Function
End Class
