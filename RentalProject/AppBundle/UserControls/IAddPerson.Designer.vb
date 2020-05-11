<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IAddPerson
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
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.CBStatut = New System.Windows.Forms.ComboBox()
        Me.TBNom = New System.Windows.Forms.TextBox()
        Me.LAStatut = New System.Windows.Forms.Label()
        Me.LANom = New System.Windows.Forms.Label()
        Me.TBPrenom = New System.Windows.Forms.TextBox()
        Me.LAPrenom = New System.Windows.Forms.Label()
        Me.LATelephone = New System.Windows.Forms.Label()
        Me.TBBureau = New System.Windows.Forms.TextBox()
        Me.LABureau = New System.Windows.Forms.Label()
        Me.TBService = New System.Windows.Forms.TextBox()
        Me.LAService = New System.Windows.Forms.Label()
        Me.TBDepartement = New System.Windows.Forms.TextBox()
        Me.LADepartement = New System.Windows.Forms.Label()
        Me.TBPoste = New System.Windows.Forms.TextBox()
        Me.LAPoste = New System.Windows.Forms.Label()
        Me.TBTelephone = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
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
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelButton.Location = New System.Drawing.Point(329, 352)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 17
        Me.CancelButton.Text = "Annuler"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddButton.Location = New System.Drawing.Point(189, 352)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 16
        Me.AddButton.Text = "Ajouter"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'CBStatut
        '
        Me.CBStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBStatut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBStatut.FormattingEnabled = True
        Me.CBStatut.Items.AddRange(New Object() {"Étudiant", "Professeur", "Technicien", "Administration"})
        Me.CBStatut.Location = New System.Drawing.Point(143, 244)
        Me.CBStatut.Name = "CBStatut"
        Me.CBStatut.Size = New System.Drawing.Size(121, 21)
        Me.CBStatut.TabIndex = 15
        '
        'TBNom
        '
        Me.TBNom.Location = New System.Drawing.Point(143, 129)
        Me.TBNom.Name = "TBNom"
        Me.TBNom.Size = New System.Drawing.Size(121, 20)
        Me.TBNom.TabIndex = 13
        '
        'LAStatut
        '
        Me.LAStatut.AutoSize = True
        Me.LAStatut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAStatut.Location = New System.Drawing.Point(38, 247)
        Me.LAStatut.Name = "LAStatut"
        Me.LAStatut.Size = New System.Drawing.Size(41, 16)
        Me.LAStatut.TabIndex = 12
        Me.LAStatut.Text = "Statut"
        '
        'LANom
        '
        Me.LANom.AutoSize = True
        Me.LANom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LANom.Location = New System.Drawing.Point(38, 132)
        Me.LANom.Name = "LANom"
        Me.LANom.Size = New System.Drawing.Size(37, 16)
        Me.LANom.TabIndex = 10
        Me.LANom.Text = "Nom"
        '
        'TBPrenom
        '
        Me.TBPrenom.Location = New System.Drawing.Point(143, 166)
        Me.TBPrenom.Name = "TBPrenom"
        Me.TBPrenom.Size = New System.Drawing.Size(121, 20)
        Me.TBPrenom.TabIndex = 19
        '
        'LAPrenom
        '
        Me.LAPrenom.AutoSize = True
        Me.LAPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAPrenom.Location = New System.Drawing.Point(38, 169)
        Me.LAPrenom.Name = "LAPrenom"
        Me.LAPrenom.Size = New System.Drawing.Size(55, 16)
        Me.LAPrenom.TabIndex = 18
        Me.LAPrenom.Text = "Prénom"
        '
        'LATelephone
        '
        Me.LATelephone.AutoSize = True
        Me.LATelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LATelephone.Location = New System.Drawing.Point(38, 207)
        Me.LATelephone.Name = "LATelephone"
        Me.LATelephone.Size = New System.Drawing.Size(74, 16)
        Me.LATelephone.TabIndex = 24
        Me.LATelephone.Text = "Téléphone"
        '
        'TBBureau
        '
        Me.TBBureau.Location = New System.Drawing.Point(416, 204)
        Me.TBBureau.Name = "TBBureau"
        Me.TBBureau.Size = New System.Drawing.Size(121, 20)
        Me.TBBureau.TabIndex = 31
        '
        'LABureau
        '
        Me.LABureau.AutoSize = True
        Me.LABureau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LABureau.Location = New System.Drawing.Point(311, 207)
        Me.LABureau.Name = "LABureau"
        Me.LABureau.Size = New System.Drawing.Size(75, 16)
        Me.LABureau.TabIndex = 30
        Me.LABureau.Text = "No. Bureau"
        '
        'TBService
        '
        Me.TBService.Location = New System.Drawing.Point(416, 166)
        Me.TBService.Name = "TBService"
        Me.TBService.Size = New System.Drawing.Size(121, 20)
        Me.TBService.TabIndex = 29
        '
        'LAService
        '
        Me.LAService.AutoSize = True
        Me.LAService.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAService.Location = New System.Drawing.Point(311, 169)
        Me.LAService.Name = "LAService"
        Me.LAService.Size = New System.Drawing.Size(54, 16)
        Me.LAService.TabIndex = 28
        Me.LAService.Text = "Service"
        '
        'TBDepartement
        '
        Me.TBDepartement.Location = New System.Drawing.Point(416, 129)
        Me.TBDepartement.Name = "TBDepartement"
        Me.TBDepartement.Size = New System.Drawing.Size(121, 20)
        Me.TBDepartement.TabIndex = 27
        '
        'LADepartement
        '
        Me.LADepartement.AutoSize = True
        Me.LADepartement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LADepartement.Location = New System.Drawing.Point(311, 132)
        Me.LADepartement.Name = "LADepartement"
        Me.LADepartement.Size = New System.Drawing.Size(86, 16)
        Me.LADepartement.TabIndex = 26
        Me.LADepartement.Text = "Département"
        '
        'TBPoste
        '
        Me.TBPoste.Location = New System.Drawing.Point(416, 244)
        Me.TBPoste.Name = "TBPoste"
        Me.TBPoste.Size = New System.Drawing.Size(121, 20)
        Me.TBPoste.TabIndex = 33
        '
        'LAPoste
        '
        Me.LAPoste.AutoSize = True
        Me.LAPoste.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAPoste.Location = New System.Drawing.Point(311, 247)
        Me.LAPoste.Name = "LAPoste"
        Me.LAPoste.Size = New System.Drawing.Size(43, 16)
        Me.LAPoste.TabIndex = 32
        Me.LAPoste.Text = "Poste"
        '
        'TBTelephone
        '
        Me.TBTelephone.Location = New System.Drawing.Point(143, 204)
        Me.TBTelephone.Mask = "(000) 0000-000"
        Me.TBTelephone.Name = "TBTelephone"
        Me.TBTelephone.Size = New System.Drawing.Size(121, 20)
        Me.TBTelephone.TabIndex = 34
        '
        'IAddPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.TBTelephone)
        Me.Controls.Add(Me.TBPoste)
        Me.Controls.Add(Me.LAPoste)
        Me.Controls.Add(Me.TBBureau)
        Me.Controls.Add(Me.LABureau)
        Me.Controls.Add(Me.TBService)
        Me.Controls.Add(Me.LAService)
        Me.Controls.Add(Me.TBDepartement)
        Me.Controls.Add(Me.LADepartement)
        Me.Controls.Add(Me.LATelephone)
        Me.Controls.Add(Me.TBPrenom)
        Me.Controls.Add(Me.LAPrenom)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.CBStatut)
        Me.Controls.Add(Me.TBNom)
        Me.Controls.Add(Me.LAStatut)
        Me.Controls.Add(Me.LANom)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "IAddPerson"
        Me.Size = New System.Drawing.Size(586, 440)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents CBStatut As ComboBox
    Friend WithEvents TBNom As TextBox
    Friend WithEvents LAStatut As Label
    Friend WithEvents LANom As Label
    Friend WithEvents TBPrenom As TextBox
    Friend WithEvents LAPrenom As Label
    Friend WithEvents LATelephone As Label
    Friend WithEvents TBBureau As TextBox
    Friend WithEvents LABureau As Label
    Friend WithEvents TBService As TextBox
    Friend WithEvents LAService As Label
    Friend WithEvents TBDepartement As TextBox
    Friend WithEvents LADepartement As Label
    Friend WithEvents TBPoste As TextBox
    Friend WithEvents LAPoste As Label
    Friend WithEvents TBTelephone As MaskedTextBox
End Class
