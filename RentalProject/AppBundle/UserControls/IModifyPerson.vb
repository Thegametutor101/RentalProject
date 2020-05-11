Public Class IModifyPerson

    Dim person As IPerson

    Sub New(pers As IPerson)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        person = pers
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.SendToBack()
    End Sub

    Private Sub IModifyPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData(EntityPerson.getInstance.getPerson)
    End Sub

    Public Sub loadData(data As DataTable)
        TBNo.Text = person.DGVPerson.SelectedRows.Item(0).Cells(0).Value
        TBNom.Text = person.DGVPerson.SelectedRows.Item(0).Cells(1).Value
        TBPrenom.Text = person.DGVPerson.SelectedRows.Item(0).Cells(2).Value
        TBTelephone.Text = person.DGVPerson.SelectedRows.Item(0).Cells(7).Value
        CBStatut.Text = person.DGVPerson.SelectedRows.Item(0).Cells(3).Value
        TBDepartement.Text = person.DGVPerson.SelectedRows.Item(0).Cells(4).Value
        TBService.Text = person.DGVPerson.SelectedRows.Item(0).Cells(5).Value
        TBBureau.Text = person.DGVPerson.SelectedRows.Item(0).Cells(6).Value
        TBPoste.Text = person.DGVPerson.SelectedRows.Item(0).Cells(8).Value
    End Sub

    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles ModifyButton.Click
        Try
            If CBStatut.Text <> "Étudiant" Then
                ModelPerson.getInstance.updatePerson(TBNo.Text, TBNom.Text, TBPrenom.Text, CBStatut.Text, TBDepartement.Text, TBService.Text, TBBureau.Text, TBTelephone.Text, TBPoste.Text)
            Else
                ModelPerson.getInstance.updatePerson(TBNo.Text, TBNom.Text, TBPrenom.Text, CBStatut.Text, TBDepartement.Text, "", "", TBTelephone.Text, "")
            End If

        Catch ex As Exception
            MessageBox.Show("Valeur invalide - Veuillez vérifier tous les champs")
        End Try
    End Sub

    Private Sub CBStatut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBStatut.SelectedIndexChanged
        If CBStatut.Text <> "Étudiant" Then
            TBService.Enabled = True
            TBBureau.Enabled = True
            TBPoste.Enabled = True
        Else
            TBService.Enabled = False
            TBBureau.Enabled = False
            TBPoste.Enabled = False
        End If
    End Sub

    Private Sub TBTelephone_TextChanged(sender As Object, e As EventArgs)
        If Not IsNumeric(TBTelephone.Text) And TBTelephone.Text.Length > 0 Then
            MessageBox.Show("Valeur numerique obligatoire")
            TBTelephone.Clear()
        End If
    End Sub

    Private Sub TBPoste_TextChanged(sender As Object, e As EventArgs) Handles TBPoste.TextChanged
        If Not IsNumeric(TBPoste.Text) And TBPoste.Text.Length > 0 Then
            MessageBox.Show("Valeur numerique obligatoire")
            TBPoste.Clear()
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.SendToBack()
    End Sub
End Class
