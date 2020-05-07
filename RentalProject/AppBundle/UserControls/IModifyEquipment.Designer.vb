<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IModifyEquipment
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelNo = New System.Windows.Forms.Label()
        Me.TBName = New System.Windows.Forms.TextBox()
        Me.CBCat = New System.Windows.Forms.ComboBox()
        Me.TBEtat = New System.Windows.Forms.TextBox()
        Me.TBDispo = New System.Windows.Forms.TextBox()
        Me.ButtonModif = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(586, 50)
        Me.Panel1.TabIndex = 2
        '
        'BackButton
        '
        Me.BackButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Image = Global.RentalProject.My.Resources.Resources.baseline_backward_black_18dp_4x
        Me.BackButton.Location = New System.Drawing.Point(0, 0)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(70, 50)
        Me.BackButton.TabIndex = 0
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(161, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(161, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Catégorie"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(161, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "État"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(161, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Disponibilité"
        '
        'LabelNo
        '
        Me.LabelNo.AutoSize = True
        Me.LabelNo.Location = New System.Drawing.Point(237, 105)
        Me.LabelNo.Name = "LabelNo"
        Me.LabelNo.Size = New System.Drawing.Size(22, 13)
        Me.LabelNo.TabIndex = 8
        Me.LabelNo.Text = "NA"
        '
        'TBName
        '
        Me.TBName.Location = New System.Drawing.Point(240, 144)
        Me.TBName.Name = "TBName"
        Me.TBName.Size = New System.Drawing.Size(121, 20)
        Me.TBName.TabIndex = 9
        '
        'CBCat
        '
        Me.CBCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBCat.FormattingEnabled = True
        Me.CBCat.Location = New System.Drawing.Point(240, 191)
        Me.CBCat.Name = "CBCat"
        Me.CBCat.Size = New System.Drawing.Size(121, 21)
        Me.CBCat.TabIndex = 10
        '
        'TBEtat
        '
        Me.TBEtat.Location = New System.Drawing.Point(240, 241)
        Me.TBEtat.Name = "TBEtat"
        Me.TBEtat.Size = New System.Drawing.Size(121, 20)
        Me.TBEtat.TabIndex = 11
        '
        'TBDispo
        '
        Me.TBDispo.Location = New System.Drawing.Point(240, 286)
        Me.TBDispo.Name = "TBDispo"
        Me.TBDispo.Size = New System.Drawing.Size(121, 20)
        Me.TBDispo.TabIndex = 12
        '
        'ButtonModif
        '
        Me.ButtonModif.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModif.Location = New System.Drawing.Point(183, 361)
        Me.ButtonModif.Name = "ButtonModif"
        Me.ButtonModif.Size = New System.Drawing.Size(75, 23)
        Me.ButtonModif.TabIndex = 13
        Me.ButtonModif.Text = "Modifier"
        Me.ButtonModif.UseVisualStyleBackColor = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Location = New System.Drawing.Point(321, 361)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 14
        Me.ButtonCancel.Text = "Annuler"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'IModifyInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonModif)
        Me.Controls.Add(Me.TBDispo)
        Me.Controls.Add(Me.TBEtat)
        Me.Controls.Add(Me.CBCat)
        Me.Controls.Add(Me.TBName)
        Me.Controls.Add(Me.LabelNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "IModifyInventory"
        Me.Size = New System.Drawing.Size(586, 440)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelNo As Label
    Friend WithEvents TBName As TextBox
    Friend WithEvents CBCat As ComboBox
    Friend WithEvents TBEtat As TextBox
    Friend WithEvents TBDispo As TextBox
    Friend WithEvents ButtonModif As Button
    Friend WithEvents ButtonCancel As Button
End Class
