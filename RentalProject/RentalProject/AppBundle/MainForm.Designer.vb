<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.HeaderBar = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MinimizeButton = New System.Windows.Forms.Button()
        Me.MaximizeButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.HeaderBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderBar
        '
        Me.HeaderBar.BackColor = System.Drawing.SystemColors.ControlDark
        Me.HeaderBar.Controls.Add(Me.Label1)
        Me.HeaderBar.Controls.Add(Me.MinimizeButton)
        Me.HeaderBar.Controls.Add(Me.MaximizeButton)
        Me.HeaderBar.Controls.Add(Me.ExitButton)
        Me.HeaderBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderBar.Location = New System.Drawing.Point(0, 0)
        Me.HeaderBar.Name = "HeaderBar"
        Me.HeaderBar.Size = New System.Drawing.Size(982, 44)
        Me.HeaderBar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10, 8, 0, 4)
        Me.Label1.Size = New System.Drawing.Size(246, 41)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Gestion d'Inventaire"
        '
        'MinimizeButton
        '
        Me.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.MinimizeButton.FlatAppearance.BorderSize = 0
        Me.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinimizeButton.Image = Global.RentalProject.My.Resources.Resources.baseline_minimize_black_18dp
        Me.MinimizeButton.Location = New System.Drawing.Point(811, 0)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(57, 44)
        Me.MinimizeButton.TabIndex = 2
        Me.MinimizeButton.UseVisualStyleBackColor = True
        '
        'MaximizeButton
        '
        Me.MaximizeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaximizeButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.MaximizeButton.FlatAppearance.BorderSize = 0
        Me.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaximizeButton.Image = Global.RentalProject.My.Resources.Resources.baseline_maximize_black_18dp
        Me.MaximizeButton.Location = New System.Drawing.Point(868, 0)
        Me.MaximizeButton.Name = "MaximizeButton"
        Me.MaximizeButton.Size = New System.Drawing.Size(57, 44)
        Me.MaximizeButton.TabIndex = 1
        Me.MaximizeButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.ExitButton.FlatAppearance.BorderSize = 0
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Image = Global.RentalProject.My.Resources.Resources.baseline_clear_black_18dp
        Me.ExitButton.Location = New System.Drawing.Point(925, 0)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(57, 44)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 586)
        Me.Controls.Add(Me.HeaderBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.HeaderBar.ResumeLayout(False)
        Me.HeaderBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HeaderBar As Panel
    Friend WithEvents MinimizeButton As Button
    Friend WithEvents MaximizeButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label1 As Label
End Class
