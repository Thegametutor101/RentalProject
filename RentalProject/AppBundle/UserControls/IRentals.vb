Public Class IRentals

    Dim mainForm As MainForm

    Sub New(main As MainForm)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
        ShowButton.Enabled = False
    End Sub

    Private Sub IRentals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ListView1.Items.Count > 0 Then
            If ListView1.SelectedIndices(0) >= 0 Then
                ShowButton.Enabled = True
            End If
        End If
    End Sub

    Private Sub ShowButton_EnabledChanged(sender As Object, e As EventArgs) Handles ShowButton.EnabledChanged
        If ShowButton.Enabled Then
            WarningLabel.Hide()
        Else
            WarningLabel.Show()
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.Items.Count > 0 Then
            If ListView1.SelectedIndices(0) >= 0 Then
                ShowButton.Enabled = True
            Else
                ShowButton.Enabled = False
            End If
        End If
    End Sub

    Private Sub RentButton_Click(sender As Object, e As EventArgs) Handles RentButton.Click
        Dim rent As New IRent(Me)
        rent.Dock = DockStyle.Fill
        mainForm.InterfacePanel.Controls.Add(rent)
        rent.BringToFront()
    End Sub
End Class
