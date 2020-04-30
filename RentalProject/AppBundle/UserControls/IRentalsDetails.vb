Public Class IRentalsDetails

    Dim mainForm As MainForm
    Dim id As Integer

    Sub New(main As MainForm, number As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        id = number
    End Sub

    Private Sub IRentalsDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim item As DataTable = EntityRental.getInstance().getRentalDetailed(id)
        For Each it As DataRow In item.Rows
            MessageBox.Show($"{it.Item(0)}|{it.Item(1)}|{it.Item(2)}|{it.Item(3)}|{it.Item(4)}|{it.Item(5)}|{it.Item(6)}|{it.Item(7)}|{it.Item(8)}|{it.Item(9)}|{it.Item(10)}|{it.Item(11)}|")
        Next
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.SendToBack()
    End Sub
End Class
