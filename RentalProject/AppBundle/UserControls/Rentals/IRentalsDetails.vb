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
            RentalID.Text = it.Item(0)
            RenterFirstName.Text = it.Item(1)
            RenterLastName.Text = it.Item(2)
            RenterStatus.Text = it.Item(3)
            RenterOffice.Text = it.Item(4)
            EquipmentName.Text = it.Item(5)
            CategoryName.Text = it.Item(6)
            EquipmentState.Text = it.Item(7)
            Authorisation.Text = it.Item(8)
            RentalDate.Value = it.Item(9)
            ReturnDate.Value = it.Item(10)
        Next
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.SendToBack()
    End Sub

    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        Dim data As DataTable = EntityRental.getInstance().getRentalDatesbyID(RentalID.Text)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
