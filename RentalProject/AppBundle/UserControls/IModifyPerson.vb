Public Class IModifyPerson

    Dim mainForm As MainForm
    Dim data As DataTable

    Sub New(main As MainForm, items As DataTable)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        data = items
    End Sub

    Private Sub IModifyPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setDefaults()
    End Sub

    Private Function setDefaults()
        For Each it As DataRow In data.Rows
            'Inserting values into textBoxes
            ID.Text = it.Item(0)
            LastName.Text = it.Item(1)
            FirstName.Text = it.Item(2)
            Status.Text = it.Item(3)
            Department.Text = it.Item(4)
            Service.Text = it.Item(5)
            Office.Text = it.Item(6)
            Phone.Text = it.Item(7)
            Extension.Text = it.Item(8)
        Next
    End Function
End Class
