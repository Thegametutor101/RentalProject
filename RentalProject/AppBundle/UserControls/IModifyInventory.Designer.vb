﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IModifyInventory
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelNo = New System.Windows.Forms.Label()
        Me.CBCat = New System.Windows.Forms.ComboBox()
        Me.TBName = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtonModif = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.CBEtat = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBDispo = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(70, 50)
        Me.BackButton.TabIndex = 0
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(195, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(157, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Catégorie"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(188, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "État"
        '
        'LabelNo
        '
        Me.LabelNo.AutoSize = True
        Me.LabelNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNo.Location = New System.Drawing.Point(230, 74)
        Me.LabelNo.Name = "LabelNo"
        Me.LabelNo.Size = New System.Drawing.Size(27, 17)
        Me.LabelNo.TabIndex = 8
        Me.LabelNo.Text = "NA"
        '
        'CBCat
        '
        Me.CBCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBCat.FormattingEnabled = True
        Me.CBCat.Location = New System.Drawing.Point(233, 171)
        Me.CBCat.Name = "CBCat"
        Me.CBCat.Size = New System.Drawing.Size(166, 21)
        Me.CBCat.TabIndex = 10
        '
        'TBName
        '
        Me.TBName.Location = New System.Drawing.Point(233, 121)
        Me.TBName.Name = "TBName"
        Me.TBName.Size = New System.Drawing.Size(166, 20)
        Me.TBName.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ButtonModif)
        Me.Panel2.Controls.Add(Me.ButtonCancel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 382)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(586, 58)
        Me.Panel2.TabIndex = 13
        '
        'ButtonModif
        '
        Me.ButtonModif.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ButtonModif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonModif.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonModif.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ButtonModif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ButtonModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModif.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ButtonModif.Location = New System.Drawing.Point(326, 0)
        Me.ButtonModif.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonModif.Name = "ButtonModif"
        Me.ButtonModif.Size = New System.Drawing.Size(130, 58)
        Me.ButtonModif.TabIndex = 85
        Me.ButtonModif.Text = "Sauvegarder"
        Me.ButtonModif.UseVisualStyleBackColor = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCancel.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ButtonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ButtonCancel.Location = New System.Drawing.Point(456, 0)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(130, 58)
        Me.ButtonCancel.TabIndex = 84
        Me.ButtonCancel.Text = "Annuler"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'CBEtat
        '
        Me.CBEtat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEtat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBEtat.FormattingEnabled = True
        Me.CBEtat.Items.AddRange(New Object() {"Neuf", "Endommagé", "En réparation", "Brisé"})
        Me.CBEtat.Location = New System.Drawing.Point(233, 216)
        Me.CBEtat.Name = "CBEtat"
        Me.CBEtat.Size = New System.Drawing.Size(166, 21)
        Me.CBEtat.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(142, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Disponibilité"
        '
        'TBDispo
        '
        Me.TBDispo.Enabled = False
        Me.TBDispo.Location = New System.Drawing.Point(232, 268)
        Me.TBDispo.Name = "TBDispo"
        Me.TBDispo.Size = New System.Drawing.Size(166, 20)
        Me.TBDispo.TabIndex = 12
        '
        'IModifyInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.CBEtat)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TBDispo)
        Me.Controls.Add(Me.CBCat)
        Me.Controls.Add(Me.TBName)
        Me.Controls.Add(Me.LabelNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(586, 440)
        Me.Name = "IModifyInventory"
        Me.Size = New System.Drawing.Size(586, 440)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelNo As Label
    Friend WithEvents CBCat As ComboBox
    Friend WithEvents TBName As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ButtonModif As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents CBEtat As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBDispo As TextBox
End Class
