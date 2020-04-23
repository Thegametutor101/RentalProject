Public Class IRent

    Dim rentals As IRentals

    Sub New(Irentals As IRentals)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        rentals = Irentals
    End Sub

    Private Sub IRent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.SendToBack()
    End Sub
End Class
