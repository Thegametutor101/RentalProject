Public Class IRentalsSearch

    Dim rentals As IRentals
    Dim mainForm As MainForm

    Sub New(main As MainForm, rental As IRentals)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        rentals = rental
    End Sub

    Private Sub IRentalsSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
