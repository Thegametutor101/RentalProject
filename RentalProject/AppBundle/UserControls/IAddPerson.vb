Public Class IAddPerson

    Dim person As IPerson

    Sub New(pers As IPerson)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        person = pers
    End Sub

    Private Sub IAddPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LADepartement.Hide()
        LAService.Hide()
        LABureau.Hide()
        LAPoste.Hide()
        TBDepartement.Hide()
        TBService.Hide()
        TBBureau.Hide()
        TBPoste.Hide()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        If CBStatut.Text <> "Étudiant" Then
            ModelPerson.getInstance.addPerson(TBNom.Text, TBPrenom.Text, CBStatut.Text, TBDepartement.Text, TBService.Text, TBBureau.Text, TBTelephone.Text, TBPoste.Text)
        Else
            ModelPerson.getInstance.addPerson(TBNom.Text, TBPrenom.Text, CBStatut.Text, "", "", "", TBTelephone.Text, "")
        End If

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click, CancelButton.Click
        'Retour au UC person
        If MessageBox.Show($"Voulez-vous vraiment faire cette opération?{Environment.NewLine}Tous vos changement seront perdus.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Me.SendToBack()
        End If
    End Sub

    Private Sub CBStatut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBStatut.SelectedIndexChanged
        If CBStatut.Text <> "Étudiant" Then
            LADepartement.Show()
            LAService.Show()
            LABureau.Show()
            LAPoste.Show()
            TBDepartement.Show()
            TBService.Show()
            TBBureau.Show()
            TBPoste.Show()
        Else
            LADepartement.Hide()
            LAService.Hide()
            LABureau.Hide()
            LAPoste.Hide()
            TBDepartement.Hide()
            TBService.Hide()
            TBBureau.Hide()
            TBPoste.Hide()
        End If
    End Sub

    Private Sub TBTelephone_TextChanged(sender As Object, e As EventArgs) Handles TBTelephone.TextChanged
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
End Class
