Public Class IRentalsSearch

    Dim rentals As IRentals
    Dim mainForm As MainForm

    Sub New(main As MainForm, rental As IRentals)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        rentals = rental
        DetailsButton.Enabled = False
        SearchButton.Enabled = False
        ByRenterName.Checked = True
    End Sub

    Private Sub IRentalsSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData(EntityRental.getInstance().getRentals())
    End Sub

    Public Function loadData(data As DataTable)
        ListView1.Items.Clear()
        Dim rentalTable As DataTable = data
        For Each it As DataRow In rentalTable.Rows
            If Not IsNothing(it) Then
                ListView1.Items.Add(New ListViewItem({it.Item(1), it.Item(2), it.Item(3)}))
            End If
        Next
    End Function

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.Items.Count > 0 Then
            If Not IsNothing(ListView1.FocusedItem) AndAlso ListView1.FocusedItem.Index >= 0 Then
                DetailsButton.Enabled = True
            Else
                DetailsButton.Enabled = False
            End If
        End If
    End Sub

    Private Sub Radio_CheckedChanged(sender As Object, e As EventArgs) Handles ByRenterName.CheckedChanged, ByCategoryName.CheckedChanged, ByAuthorisationName.CheckedChanged
        RenterFirstName.Text = ""
        RenterLastName.Text = ""
        CategoryName.Text = ""
        AuthorisationName.Text = ""
        If ByRenterName.Checked Then
            RenterFirstName.Enabled = True
            RenterLastName.Enabled = True
            CategoryName.Enabled = False
            AuthorisationName.Enabled = False
        ElseIf ByCategoryName.Checked Then
            RenterFirstName.Enabled = False
            RenterLastName.Enabled = False
            CategoryName.Enabled = True
            AuthorisationName.Enabled = False
        ElseIf ByAuthorisationName.Checked Then
            RenterFirstName.Enabled = False
            RenterLastName.Enabled = False
            CategoryName.Enabled = False
            AuthorisationName.Enabled = True
        End If
    End Sub

    Private Sub SearchBoxes_TextChanged(sender As Object, e As EventArgs) Handles RenterFirstName.TextChanged, RenterLastName.TextChanged, CategoryName.TextChanged, AuthorisationName.TextChanged
        If (RenterFirstName.Text.Length > 0 Or RenterLastName.Text.Length > 0) Or CategoryName.Text.Length > 0 Or AuthorisationName.Text.Length > 0 Then
            SearchButton.Enabled = True
        Else
            SearchButton.Enabled = False
        End If
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If (RenterFirstName.Text.Length > 0 Or RenterLastName.Text.Length > 0) Then
            MessageBox.Show("ok renter name")
        ElseIf CategoryName.Text.Length > 0 Then
            MessageBox.Show("ok category name")
        ElseIf AuthorisationName.Text.Length > 0 Then
            MessageBox.Show("ok rentee name")
        End If
    End Sub
End Class
