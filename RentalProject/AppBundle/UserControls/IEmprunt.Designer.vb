﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IEmprunt
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbAutorise = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CbCategorie = New System.Windows.Forms.ComboBox()
        Me.CbEquipement = New System.Windows.Forms.ComboBox()
        Me.NumericUpDownJour = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumericUpDownHeure = New System.Windows.Forms.NumericUpDown()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.CbPersonne = New System.Windows.Forms.ComboBox()
        Me.Comments = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SelectButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EquipmentCollection = New System.Windows.Forms.ListView()
        Me.EquipmentID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EquipmentName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.NumericUpDownJour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownHeure, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Emprunté par"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Categorie"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Équipement"
        '
        'TbAutorise
        '
        Me.TbAutorise.Location = New System.Drawing.Point(119, 203)
        Me.TbAutorise.MaxLength = 30
        Me.TbAutorise.Name = "TbAutorise"
        Me.TbAutorise.Size = New System.Drawing.Size(200, 20)
        Me.TbAutorise.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(46, 340)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(234, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'CbCategorie
        '
        Me.CbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbCategorie.FormattingEnabled = True
        Me.CbCategorie.Location = New System.Drawing.Point(119, 121)
        Me.CbCategorie.Name = "CbCategorie"
        Me.CbCategorie.Size = New System.Drawing.Size(200, 21)
        Me.CbCategorie.TabIndex = 9
        '
        'CbEquipement
        '
        Me.CbEquipement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbEquipement.Enabled = False
        Me.CbEquipement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbEquipement.FormattingEnabled = True
        Me.CbEquipement.Location = New System.Drawing.Point(119, 164)
        Me.CbEquipement.Name = "CbEquipement"
        Me.CbEquipement.Size = New System.Drawing.Size(164, 21)
        Me.CbEquipement.TabIndex = 10
        '
        'NumericUpDownJour
        '
        Me.NumericUpDownJour.Location = New System.Drawing.Point(46, 289)
        Me.NumericUpDownJour.Maximum = New Decimal(New Integer() {720, 0, 0, 0})
        Me.NumericUpDownJour.Name = "NumericUpDownJour"
        Me.NumericUpDownJour.Size = New System.Drawing.Size(61, 20)
        Me.NumericUpDownJour.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Autorisé par"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Durée de l'emprunt (J)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(64, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Date de retour"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(202, 317)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(86, 21)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "Date Fixe"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(182, 271)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Durée de l'emprunt (H)"
        '
        'NumericUpDownHeure
        '
        Me.NumericUpDownHeure.Location = New System.Drawing.Point(218, 291)
        Me.NumericUpDownHeure.Maximum = New Decimal(New Integer() {720, 0, 0, 0})
        Me.NumericUpDownHeure.Name = "NumericUpDownHeure"
        Me.NumericUpDownHeure.Size = New System.Drawing.Size(61, 20)
        Me.NumericUpDownHeure.TabIndex = 17
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
        Me.Panel1.TabIndex = 22
        '
        'BackButton
        '
        Me.BackButton.Cursor = System.Windows.Forms.Cursors.Hand
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
        'CbPersonne
        '
        Me.CbPersonne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPersonne.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CbPersonne.FormattingEnabled = True
        Me.CbPersonne.Location = New System.Drawing.Point(119, 76)
        Me.CbPersonne.Name = "CbPersonne"
        Me.CbPersonne.Size = New System.Drawing.Size(200, 21)
        Me.CbPersonne.TabIndex = 85
        '
        'Comments
        '
        Me.Comments.Location = New System.Drawing.Point(336, 271)
        Me.Comments.Margin = New System.Windows.Forms.Padding(2)
        Me.Comments.MaxLength = 1000
        Me.Comments.Multiline = True
        Me.Comments.Name = "Comments"
        Me.Comments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Comments.Size = New System.Drawing.Size(246, 87)
        Me.Comments.TabIndex = 87
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(333, 253)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 17)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "Commentaires"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SaveButton)
        Me.Panel2.Controls.Add(Me.ResetButton)
        Me.Panel2.Controls.Add(Me.CancelButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 382)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(586, 58)
        Me.Panel2.TabIndex = 88
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.SaveButton.Location = New System.Drawing.Point(196, 0)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(130, 58)
        Me.SaveButton.TabIndex = 87
        Me.SaveButton.Text = "Sauvegarder"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ResetButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.ResetButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.ResetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ResetButton.Location = New System.Drawing.Point(326, 0)
        Me.ResetButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(130, 58)
        Me.ResetButton.TabIndex = 86
        Me.ResetButton.Text = "Réinitialiser"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.CancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.CancelButton.Location = New System.Drawing.Point(456, 0)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(130, 58)
        Me.CancelButton.TabIndex = 85
        Me.CancelButton.Text = "Annuler"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(333, 54)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(171, 17)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Équipements à emprunter"
        '
        'SelectButton
        '
        Me.SelectButton.Location = New System.Drawing.Point(289, 164)
        Me.SelectButton.Name = "SelectButton"
        Me.SelectButton.Size = New System.Drawing.Size(30, 21)
        Me.SelectButton.TabIndex = 94
        Me.SelectButton.Text = "->"
        Me.SelectButton.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(343, 226)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 13)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "* Pour retirer, Double-clicker sur l'item."
        '
        'EquipmentCollection
        '
        Me.EquipmentCollection.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.EquipmentID, Me.EquipmentName})
        Me.EquipmentCollection.HideSelection = False
        Me.EquipmentCollection.Location = New System.Drawing.Point(336, 74)
        Me.EquipmentCollection.Name = "EquipmentCollection"
        Me.EquipmentCollection.Size = New System.Drawing.Size(246, 149)
        Me.EquipmentCollection.TabIndex = 97
        Me.EquipmentCollection.UseCompatibleStateImageBehavior = False
        Me.EquipmentCollection.View = System.Windows.Forms.View.Details
        '
        'EquipmentID
        '
        Me.EquipmentID.Text = "ID"
        Me.EquipmentID.Width = 38
        '
        'EquipmentName
        '
        Me.EquipmentName.Text = "Nom d'équipement"
        Me.EquipmentName.Width = 173
        '
        'IEmprunt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.EquipmentCollection)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SelectButton)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Comments)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CbPersonne)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NumericUpDownHeure)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumericUpDownJour)
        Me.Controls.Add(Me.CbEquipement)
        Me.Controls.Add(Me.CbCategorie)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TbAutorise)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(586, 440)
        Me.Name = "IEmprunt"
        Me.Size = New System.Drawing.Size(586, 440)
        CType(Me.NumericUpDownJour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownHeure, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TbAutorise As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CbCategorie As ComboBox
    Friend WithEvents CbEquipement As ComboBox
    Friend WithEvents NumericUpDownJour As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents NumericUpDownHeure As NumericUpDown
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackButton As Button
    Friend WithEvents CbPersonne As ComboBox
    Friend WithEvents Comments As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SaveButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents SelectButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents EquipmentCollection As ListView
    Friend WithEvents EquipmentID As ColumnHeader
    Friend WithEvents EquipmentName As ColumnHeader
End Class
