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
        loadData(EntityRental.getInstance().getRentals(), True)
    End Sub

    Public Function loadData(data As DataTable, type As Boolean)
        ListView1.Items.Clear()
        Dim rentalTable As DataTable = data
        If Not rentalTable.Rows.Count > 0 Then
            If type Then
                MessageBox.Show("Aucun Emprunt dans la base de donnée.")
                Me.SendToBack()
            Else
                RenterFirstName.Text = ""
                RenterLastName.Text = ""
                CategoryName.Text = ""
                AuthorisationName.Text = ""
                MessageBox.Show($"Aucun Emprunt correspondant à vos critères{Environment.NewLine}dans la base de donnée.")
                loadData(EntityRental.getInstance().getRentals(), True)
            End If
        Else
            For Each it As DataRow In rentalTable.Rows
                If Not IsNothing(it) Then
                    ListView1.Items.Add(New ListViewItem({it.Item(0), it.Item(1), it.Item(2), it.Item(3)}))
                End If
            Next
        End If
    End Function

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If Not IsNothing(ListView1.FocusedItem) AndAlso ListView1.FocusedItem.Index >= 0 Then
            DetailsButton.Enabled = True
        Else
            DetailsButton.Enabled = False
        End If
    End Sub

    Private Sub Radio_CheckedChanged(sender As Object, e As EventArgs) Handles ByRenterName.CheckedChanged, ByAuthorisationName.CheckedChanged, ByCategoryName.CheckedChanged
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
        RenterFirstName.Text = Trim(RenterFirstName.Text)
        RenterLastName.Text = Trim(RenterLastName.Text)
        CategoryName.Text = Trim(CategoryName.Text)
        AuthorisationName.Text = Trim(AuthorisationName.Text)
        If (RenterFirstName.Text.Length > 0 Or RenterLastName.Text.Length > 0) Or CategoryName.Text.Length > 0 Or AuthorisationName.Text.Length > 0 Then
            SearchButton.Enabled = True
        Else
            SearchButton.Enabled = False
        End If
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim firstName = Trim(RenterFirstName.Text)
        Dim lastName = Trim(RenterLastName.Text)
        Dim category = Trim(CategoryName.Text)
        Dim authorisor = Trim(AuthorisationName.Text)
        Dim data As DataTable
        If (firstName.Length > 0 Or lastName.Length > 0) Then
            If (firstName.Length > 0 And lastName.Length > 0) Then
                data = EntityRental.getInstance().getRentalsByRenterFirstAndLastName(firstName, lastName)
            ElseIf (Not (firstName.Length > 0) And lastName.Length > 0) Then
                data = EntityRental.getInstance().getRentalsByRenterLastName(lastName)
            ElseIf (firstName.Length > 0 And Not (lastName.Length > 0)) Then
                data = EntityRental.getInstance().getRentalsByRenterFirstName(firstName)
            End If
            loadData(data, False)
        ElseIf CategoryName.Text.Length > 0 Then
            data = EntityRental.getInstance().getRentalsByCategoryName(category)
            loadData(data, False)
        ElseIf AuthorisationName.Text.Length > 0 Then
            data = EntityRental.getInstance().getRentalsByRenteeName(authorisor)
            loadData(data, False)
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.SendToBack()
    End Sub

    Private Sub DetailsButton_Click(sender As Object, e As EventArgs) Handles DetailsButton.Click
        If Not IsNothing(ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text) Then
            Dim detail As New IRentalsDetails(mainForm, CInt(ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text))
            detail.Dock = DockStyle.Fill
            mainForm.InterfacePanel.Controls.Add(detail)
            detail.BringToFront()
        End If
    End Sub
End Class
