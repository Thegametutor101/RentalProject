Public Class IPersonSearch

    Dim person As IPerson
    Dim mainForm As MainForm

    Sub New(pers As IPerson)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        person = pers
        SearchButton.Enabled = False
        ByName.Checked = True
    End Sub

    Private Sub IPersonSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVPerson.DataSource = EntityPerson.getInstance.getPerson
        DGVPerson.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub Radio_CheckedChanged(sender As Object, e As EventArgs) Handles ByName.CheckedChanged, ByStatut.CheckedChanged
        TBNom.Text = ""
        TBPrenom.Text = ""
        CBStatut.Text = ""
        If ByName.Checked Then
            TBNom.Enabled = True
            TBPrenom.Enabled = True
            CBStatut.Enabled = False
        ElseIf ByStatut.Checked Then
            CBStatut.Enabled = True
            TBNom.Enabled = False
            TBPrenom.Enabled = False
        End If
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        SearchItems()
    End Sub

    Private Sub PressedEnter(sender As Object, e As KeyEventArgs) Handles TBPrenom.KeyUp, TBNom.KeyUp, CBStatut.KeyUp
        If e.KeyCode = Keys.Enter Then
            SearchItems()
        End If
    End Sub

    Private Function SearchItems()
        Dim lastName = Trim(TBNom.Text)
        Dim firstName = Trim(TBPrenom.Text)
        Dim statut = Trim(CBStatut.Text)

        If lastName.Length > 0 Or firstName.Length > 0 Then
            If lastName.Length > 0 And firstName.Length > 0 Then
                DGVPerson.DataSource = EntityPerson.getInstance.getPersonneByFirstNameAndLastName(firstName, lastName)
            ElseIf lastName.Length > 0 And Not firstName.Length > 0 Then
                DGVPerson.DataSource = EntityPerson.getInstance.getPersonneByLastName(lastName)
            ElseIf Not lastName.Length > 0 And firstName.Length > 0 Then
                DGVPerson.DataSource = EntityPerson.getInstance.getPersonneByLastName(firstName)
            End If
        ElseIf CBStatut.Text.Length > 0 Then
            DGVPerson.DataSource = EntityPerson.getInstance.getPersonneByStatut(statut)
        End If
    End Function

    Private Sub SearchBoxes_TextChanged(sender As Object, e As EventArgs) Handles TBPrenom.TextChanged, TBNom.TextChanged, CBStatut.TextChanged
        Dim lastName = Trim(TBNom.Text)
        Dim firstName = Trim(TBPrenom.Text)
        Dim statut = Trim(CBStatut.Text)
        If (firstName.Length > 0 Or lastName.Length > 0) Or statut.Length > 0 Then
            SearchButton.Enabled = True
        Else
            SearchButton.Enabled = False
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.SendToBack()
    End Sub
End Class
