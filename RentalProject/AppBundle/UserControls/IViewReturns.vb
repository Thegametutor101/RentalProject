Public Class IViewReturns

    Dim mainForm As MainForm

    Sub New(main As MainForm)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        mainForm = main
    End Sub

    Private Sub IViewReturns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Function loadData()
        Dim returns As DataTable = EntityReturn.getInstance().getReturn()
        If returns.Rows.Count = 0 Then
            MessageBox.Show("Il n'y à aucun retour à afficher.")
            mainForm.InterfacePanel.Controls.Clear()
            Dim home As New IHome()
            home.Dock = DockStyle.Fill
            mainForm.InterfacePanel.Controls.Add(home)
            home.BringToFront()
        End If
        DataGridView1.DataSource = returns
    End Function

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If Not IsNothing(DataGridView1.SelectedRows.Item(0).Cells(0).Value) And DataGridView1.Rows.Count > 0 Then
            If MessageBox.Show($"Êtes-vous sur de vouloir supprimer cet enregistrement?{Environment.NewLine}ATTENTION!!{Environment.NewLine}Si vous confirmez vous ne pourrez plus jamais y avoir accès.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                ModelReturn.getInstance().deleteReturn(DataGridView1.SelectedRows.Item(0).Cells(0).Value)
                loadData()
            End If
        End If
    End Sub
End Class
