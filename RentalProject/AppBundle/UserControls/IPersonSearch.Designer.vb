﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IPersonSearch
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CBStatut = New System.Windows.Forms.ComboBox()
        Me.ByStatut = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBPrenom = New System.Windows.Forms.TextBox()
        Me.ByName = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DGVPerson = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGVPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(781, 62)
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
        Me.BackButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(93, 62)
        Me.BackButton.TabIndex = 0
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CBStatut)
        Me.Panel2.Controls.Add(Me.ByStatut)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TBNom)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TBPrenom)
        Me.Panel2.Controls.Add(Me.ByName)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 62)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(351, 480)
        Me.Panel2.TabIndex = 4
        '
        'CBStatut
        '
        Me.CBStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBStatut.Enabled = False
        Me.CBStatut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBStatut.FormattingEnabled = True
        Me.CBStatut.Items.AddRange(New Object() {"Étudiant", "Professeur", "Technicien", "Administration"})
        Me.CBStatut.Location = New System.Drawing.Point(34, 219)
        Me.CBStatut.Margin = New System.Windows.Forms.Padding(4)
        Me.CBStatut.Name = "CBStatut"
        Me.CBStatut.Size = New System.Drawing.Size(299, 24)
        Me.CBStatut.TabIndex = 18
        '
        'ByStatut
        '
        Me.ByStatut.AutoSize = True
        Me.ByStatut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ByStatut.Location = New System.Drawing.Point(34, 187)
        Me.ByStatut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ByStatut.Name = "ByStatut"
        Me.ByStatut.Size = New System.Drawing.Size(74, 24)
        Me.ByStatut.TabIndex = 17
        Me.ByStatut.TabStop = True
        Me.ByStatut.Text = "Statut"
        Me.ByStatut.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(244, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Nom"
        '
        'TBNom
        '
        Me.TBNom.Enabled = False
        Me.TBNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNom.Location = New System.Drawing.Point(197, 128)
        Me.TBNom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBNom.Multiline = True
        Me.TBNom.Name = "TBNom"
        Me.TBNom.Size = New System.Drawing.Size(136, 34)
        Me.TBNom.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Prénom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Rechercher par..."
        '
        'TBPrenom
        '
        Me.TBPrenom.Enabled = False
        Me.TBPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPrenom.Location = New System.Drawing.Point(34, 128)
        Me.TBPrenom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBPrenom.Multiline = True
        Me.TBPrenom.Name = "TBPrenom"
        Me.TBPrenom.Size = New System.Drawing.Size(136, 34)
        Me.TBPrenom.TabIndex = 12
        '
        'ByName
        '
        Me.ByName.AutoSize = True
        Me.ByName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ByName.Location = New System.Drawing.Point(34, 76)
        Me.ByName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ByName.Name = "ByName"
        Me.ByName.Size = New System.Drawing.Size(65, 24)
        Me.ByName.TabIndex = 11
        Me.ByName.TabStop = True
        Me.ByName.Text = "Nom"
        Me.ByName.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DGVPerson)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(351, 62)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(430, 480)
        Me.Panel3.TabIndex = 5
        '
        'DGVPerson
        '
        Me.DGVPerson.AllowUserToAddRows = False
        Me.DGVPerson.AllowUserToDeleteRows = False
        Me.DGVPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVPerson.BackgroundColor = System.Drawing.Color.White
        Me.DGVPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPerson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVPerson.Location = New System.Drawing.Point(0, 0)
        Me.DGVPerson.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVPerson.Name = "DGVPerson"
        Me.DGVPerson.ReadOnly = True
        Me.DGVPerson.RowHeadersWidth = 51
        Me.DGVPerson.Size = New System.Drawing.Size(430, 417)
        Me.DGVPerson.TabIndex = 10
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.SearchButton)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 417)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(430, 63)
        Me.Panel4.TabIndex = 0
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.SearchButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.ForeColor = System.Drawing.Color.White
        Me.SearchButton.Location = New System.Drawing.Point(229, 0)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(201, 63)
        Me.SearchButton.TabIndex = 9
        Me.SearchButton.Text = "Rechercher"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'IPersonSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(781, 542)
        Me.Name = "IPersonSearch"
        Me.Size = New System.Drawing.Size(781, 542)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.DGVPerson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ByStatut As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents TBNom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TBPrenom As TextBox
    Friend WithEvents ByName As RadioButton
    Friend WithEvents CBStatut As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DGVPerson As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents SearchButton As Button
End Class
