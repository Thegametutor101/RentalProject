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
        Me.CbPersonne = New System.Windows.Forms.ComboBox()
        Me.CbCategorie = New System.Windows.Forms.ComboBox()
        Me.CbEquipement = New System.Windows.Forms.ComboBox()
        Me.NumericUpDownJour = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumericUpDownHeure = New System.Windows.Forms.NumericUpDown()
        Me.LbEmprunt = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownJour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownHeure, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Emprunt par"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Categorie Equipement"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Equipement"
        '
        'TbAutorise
        '
        Me.TbAutorise.Location = New System.Drawing.Point(120, 192)
        Me.TbAutorise.MaxLength = 30
        Me.TbAutorise.Name = "TbAutorise"
        Me.TbAutorise.Size = New System.Drawing.Size(200, 20)
        Me.TbAutorise.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(120, 297)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'CbPersonne
        '
        Me.CbPersonne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbPersonne.FormattingEnabled = True
        Me.CbPersonne.Location = New System.Drawing.Point(120, 44)
        Me.CbPersonne.Name = "CbPersonne"
        Me.CbPersonne.Size = New System.Drawing.Size(200, 21)
        Me.CbPersonne.TabIndex = 8
        '
        'CbCategorie
        '
        Me.CbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbCategorie.FormattingEnabled = True
        Me.CbCategorie.Location = New System.Drawing.Point(120, 97)
        Me.CbCategorie.Name = "CbCategorie"
        Me.CbCategorie.Size = New System.Drawing.Size(200, 21)
        Me.CbCategorie.TabIndex = 9
        '
        'CbEquipement
        '
        Me.CbEquipement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbEquipement.Enabled = False
        Me.CbEquipement.FormattingEnabled = True
        Me.CbEquipement.Location = New System.Drawing.Point(120, 143)
        Me.CbEquipement.Name = "CbEquipement"
        Me.CbEquipement.Size = New System.Drawing.Size(200, 21)
        Me.CbEquipement.TabIndex = 10
        '
        'NumericUpDownJour
        '
        Me.NumericUpDownJour.Location = New System.Drawing.Point(120, 255)
        Me.NumericUpDownJour.Maximum = New Decimal(New Integer() {720, 0, 0, 0})
        Me.NumericUpDownJour.Name = "NumericUpDownJour"
        Me.NumericUpDownJour.Size = New System.Drawing.Size(102, 20)
        Me.NumericUpDownJour.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Autorisé par "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(117, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Durer de l'emprunt (J)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Date/heure de retour"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(141, 351)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Sauvegarder l'emprunt"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(337, 297)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(88, 17)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "Par date Fixe"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(237, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Durer de l'emprunt (H)"
        '
        'NumericUpDownHeure
        '
        Me.NumericUpDownHeure.Location = New System.Drawing.Point(240, 253)
        Me.NumericUpDownHeure.Maximum = New Decimal(New Integer() {720, 0, 0, 0})
        Me.NumericUpDownHeure.Name = "NumericUpDownHeure"
        Me.NumericUpDownHeure.Size = New System.Drawing.Size(102, 20)
        Me.NumericUpDownHeure.TabIndex = 17
        '
        'LbEmprunt
        '
        Me.LbEmprunt.FormattingEnabled = True
        Me.LbEmprunt.Location = New System.Drawing.Point(337, 39)
        Me.LbEmprunt.Name = "LbEmprunt"
        Me.LbEmprunt.Size = New System.Drawing.Size(246, 173)
        Me.LbEmprunt.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(421, 215)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Emprunt en cours"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(350, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Equipement     -    Date de retour"
        '
        'IEmprunt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LbEmprunt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NumericUpDownHeure)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumericUpDownJour)
        Me.Controls.Add(Me.CbEquipement)
        Me.Controls.Add(Me.CbCategorie)
        Me.Controls.Add(Me.CbPersonne)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TbAutorise)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "IEmprunt"
        Me.Size = New System.Drawing.Size(586, 440)
        CType(Me.NumericUpDownJour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownHeure, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TbAutorise As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CbPersonne As ComboBox
    Friend WithEvents CbCategorie As ComboBox
    Friend WithEvents CbEquipement As ComboBox
    Friend WithEvents NumericUpDownJour As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents NumericUpDownHeure As NumericUpDown
    Friend WithEvents LbEmprunt As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
