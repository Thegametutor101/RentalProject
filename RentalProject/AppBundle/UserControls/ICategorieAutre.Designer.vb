<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ICategorieAutre
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.noEquipement = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.noCategorie = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Etat = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Disponibilite = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CbCategorie = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.noEquipement, Me.Nom, Me.noCategorie, Me.Etat, Me.Disponibilite})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(209, 91)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(319, 304)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'noEquipement
        '
        Me.noEquipement.Text = "noEquipement"
        Me.noEquipement.Width = 56
        '
        'Nom
        '
        Me.Nom.Text = "Nom"
        '
        'noCategorie
        '
        Me.noCategorie.Text = "noCategorie"
        Me.noCategorie.Width = 74
        '
        'Etat
        '
        Me.Etat.Text = "Etat"
        '
        'Disponibilite
        '
        Me.Disponibilite.Text = "Disponibilite"
        Me.Disponibilite.Width = 69
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(56, 337)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Appliqué"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CbCategorie
        '
        Me.CbCategorie.FormattingEnabled = True
        Me.CbCategorie.Location = New System.Drawing.Point(48, 295)
        Me.CbCategorie.Name = "CbCategorie"
        Me.CbCategorie.Size = New System.Drawing.Size(121, 21)
        Me.CbCategorie.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Catégorie qui sera attribué"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(254, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Liste d'équipement dans la catégorie Autre"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(586, 58)
        Me.Panel1.TabIndex = 5
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
        Me.BackButton.Size = New System.Drawing.Size(70, 58)
        Me.BackButton.TabIndex = 12
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(586, 58)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Équipements sans Catégorie"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ICategorieAutre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbCategorie)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListView1)
        Me.MinimumSize = New System.Drawing.Size(586, 440)
        Me.Name = "ICategorieAutre"
        Me.Size = New System.Drawing.Size(586, 440)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents CbCategorie As ComboBox
    Friend WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Friend WithEvents noEquipement As ColumnHeader
    Friend WithEvents Nom As ColumnHeader
    Friend WithEvents noCategorie As ColumnHeader
    Friend WithEvents Etat As ColumnHeader
    Friend WithEvents Disponibilite As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackButton As Button
    Friend WithEvents Label5 As Label
End Class
