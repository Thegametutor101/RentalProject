﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IRentals
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.WarningLabel = New System.Windows.Forms.Label()
        Me.ShowButton = New System.Windows.Forms.Button()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.RentButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ViewPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.MenuPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ViewPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuPanel
        '
        Me.MenuPanel.Controls.Add(Me.WarningLabel)
        Me.MenuPanel.Controls.Add(Me.ShowButton)
        Me.MenuPanel.Controls.Add(Me.SearchButton)
        Me.MenuPanel.Controls.Add(Me.ReturnButton)
        Me.MenuPanel.Controls.Add(Me.RentButton)
        Me.MenuPanel.Controls.Add(Me.Panel3)
        Me.MenuPanel.Controls.Add(Me.Panel2)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(236, 440)
        Me.MenuPanel.TabIndex = 0
        '
        'WarningLabel
        '
        Me.WarningLabel.AutoSize = True
        Me.WarningLabel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.WarningLabel.Location = New System.Drawing.Point(0, 377)
        Me.WarningLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.WarningLabel.Name = "WarningLabel"
        Me.WarningLabel.Size = New System.Drawing.Size(146, 13)
        Me.WarningLabel.TabIndex = 6
        Me.WarningLabel.Text = "* Veuillez en choisir un avant."
        '
        'ShowButton
        '
        Me.ShowButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ShowButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ShowButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ShowButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ShowButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowButton.ForeColor = System.Drawing.Color.White
        Me.ShowButton.Location = New System.Drawing.Point(0, 390)
        Me.ShowButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ShowButton.Name = "ShowButton"
        Me.ShowButton.Size = New System.Drawing.Size(172, 50)
        Me.ShowButton.TabIndex = 5
        Me.ShowButton.Text = "Afficher un Emprunt"
        Me.ShowButton.UseVisualStyleBackColor = False
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.SearchButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.ForeColor = System.Drawing.Color.White
        Me.SearchButton.Location = New System.Drawing.Point(0, 150)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(172, 50)
        Me.SearchButton.TabIndex = 4
        Me.SearchButton.Text = "Rechercher un Emprunt"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'ReturnButton
        '
        Me.ReturnButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ReturnButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.ReturnButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ReturnButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ReturnButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnButton.ForeColor = System.Drawing.Color.White
        Me.ReturnButton.Location = New System.Drawing.Point(0, 100)
        Me.ReturnButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(172, 50)
        Me.ReturnButton.TabIndex = 3
        Me.ReturnButton.Text = "Retourner un Équipement"
        Me.ReturnButton.UseVisualStyleBackColor = False
        '
        'RentButton
        '
        Me.RentButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.RentButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.RentButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.RentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.RentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RentButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RentButton.ForeColor = System.Drawing.Color.White
        Me.RentButton.Location = New System.Drawing.Point(0, 50)
        Me.RentButton.Margin = New System.Windows.Forms.Padding(2)
        Me.RentButton.Name = "RentButton"
        Me.RentButton.Size = New System.Drawing.Size(172, 50)
        Me.RentButton.TabIndex = 2
        Me.RentButton.Text = "Ajouter un Emprunt"
        Me.RentButton.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(172, 50)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(64, 390)
        Me.Panel3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(236, 50)
        Me.Panel2.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(350, 440)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ViewPanel
        '
        Me.ViewPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ViewPanel.Controls.Add(Me.ListView1)
        Me.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewPanel.Location = New System.Drawing.Point(236, 0)
        Me.ViewPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.ViewPanel.Name = "ViewPanel"
        Me.ViewPanel.Size = New System.Drawing.Size(350, 440)
        Me.ViewPanel.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(236, 50)
        Me.Panel1.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(236, 50)
        Me.Panel4.TabIndex = 1
        '
        'IRentals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.ViewPanel)
        Me.Controls.Add(Me.MenuPanel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(586, 440)
        Me.Name = "IRentals"
        Me.Size = New System.Drawing.Size(586, 440)
        Me.MenuPanel.ResumeLayout(False)
        Me.MenuPanel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ViewPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuPanel As Panel
    Friend WithEvents RentButton As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents WarningLabel As Label
    Friend WithEvents ShowButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents ReturnButton As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ViewPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
End Class
