Imports MySql.Data.MySqlClient
Public Class ModelEquipment
    Dim connectionString = "Server='localhost';Database='projetsession';Uid='root';Pwd='';Port=3308;"
    Dim connection As New MySqlConnection(connectionString)
    Shared instance As ModelRental = Nothing
    Public Shared Function getInstance() As ModelRental
        If IsNothing(instance) Then
            instance = New ModelRental()
        End If
        Return instance
    End Function
End Class
