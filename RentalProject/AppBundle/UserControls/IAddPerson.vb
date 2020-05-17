Public Class IAddPerson

    Dim person As IPerson

    Sub New(pers As IPerson)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        person = pers
    End Sub

    Private Sub IAddPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBService.Enabled = False
        TBBureau.Enabled = False
        TBPoste.Enabled = False
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Try
            If CBStatut.Text <> "Étudiant" Then
                ModelPerson.getInstance.addPerson(TBNom.Text, TBPrenom.Text, CBStatut.Text, TBDepartement.Text, TBService.Text, TBBureau.Text, TBTelephone.Text, TBPoste.Text)
            Else
                ModelPerson.getInstance.addPerson(TBNom.Text, TBPrenom.Text, CBStatut.Text, TBDepartement.Text, "", "", TBTelephone.Text, "")
            End If

        Catch ex As Exception
            MessageBox.Show("Valeur invalide - Veuillez vérifier tous les champs")
        End Try
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click, CancelButton.Click
        'Retour au UC person
        If MessageBox.Show($"Voulez-vous vraiment faire cette opération?{Environment.NewLine}Tous vos changement seront perdus.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.SendToBack()
        End If
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

    Private Sub TBPoste_TextChanged(sender As Object, e As EventArgs) Handles TBPoste.TextChanged
        If Not IsNumeric(TBPoste.Text) And TBPoste.Text.Length > 0 Then
            MessageBox.Show("Valeur numerique obligatoire")
            TBPoste.Clear()
        End If

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        If MessageBox.Show($"Voulez-vous vraiment faire cette opération?{Environment.NewLine}Tous vos changement seront perdus.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.SendToBack()
        End If
    End Sub
End Class
