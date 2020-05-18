<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IRentalsDetails
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ModifyButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RentalID = New System.Windows.Forms.TextBox()
        Me.ReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.RentalDate = New System.Windows.Forms.DateTimePicker()
        Me.Authorisation = New System.Windows.Forms.TextBox()
        Me.EquipmentState = New System.Windows.Forms.TextBox()
        Me.CategoryName = New System.Windows.Forms.TextBox()
        Me.EquipmentName = New System.Windows.Forms.TextBox()
        Me.RenterFirstName = New System.Windows.Forms.TextBox()
        Me.RenterLastName = New System.Windows.Forms.TextBox()
        Me.RenterStatus = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ModifyButton)
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(586, 50)
        Me.Panel1.TabIndex = 2
        '
        'ModifyButton
        '
        Me.ModifyButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ModifyButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ModifyButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.ModifyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ModifyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModifyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModifyButton.ForeColor = System.Drawing.Color.White
        Me.ModifyButton.Location = New System.Drawing.Point(393, 0)
        Me.ModifyButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ModifyButton.Name = "ModifyButton"
        Me.ModifyButton.Size = New System.Drawing.Size(193, 50)
        Me.ModifyButton.TabIndex = 2
        Me.ModifyButton.Text = "Modifier la date de retour"
        Me.ModifyButton.UseVisualStyleBackColor = False
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Email)
        Me.Panel2.Controls.Add(Me.RentalID)
        Me.Panel2.Controls.Add(Me.ReturnDate)
        Me.Panel2.Controls.Add(Me.RentalDate)
        Me.Panel2.Controls.Add(Me.Authorisation)
        Me.Panel2.Controls.Add(Me.EquipmentState)
        Me.Panel2.Controls.Add(Me.CategoryName)
        Me.Panel2.Controls.Add(Me.EquipmentName)
        Me.Panel2.Controls.Add(Me.RenterFirstName)
        Me.Panel2.Controls.Add(Me.RenterLastName)
        Me.Panel2.Controls.Add(Me.RenterStatus)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(586, 390)
        Me.Panel2.TabIndex = 3
        '
        'RentalID
        '
        Me.RentalID.Enabled = False
        Me.RentalID.Location = New System.Drawing.Point(64, 21)
        Me.RentalID.Margin = New System.Windows.Forms.Padding(2)
        Me.RentalID.Multiline = True
        Me.RentalID.Name = "RentalID"
        Me.RentalID.ReadOnly = True
        Me.RentalID.Size = New System.Drawing.Size(73, 19)
        Me.RentalID.TabIndex = 57
        '
        'ReturnDate
        '
        Me.ReturnDate.Enabled = False
        Me.ReturnDate.Location = New System.Drawing.Point(346, 341)
        Me.ReturnDate.Margin = New System.Windows.Forms.Padding(2)
        Me.ReturnDate.Name = "ReturnDate"
        Me.ReturnDate.Size = New System.Drawing.Size(189, 20)
        Me.ReturnDate.TabIndex = 56
        '
        'RentalDate
        '
        Me.RentalDate.Enabled = False
        Me.RentalDate.Location = New System.Drawing.Point(79, 341)
        Me.RentalDate.Margin = New System.Windows.Forms.Padding(2)
        Me.RentalDate.Name = "RentalDate"
        Me.RentalDate.Size = New System.Drawing.Size(189, 20)
        Me.RentalDate.TabIndex = 55
        '
        'Authorisation
        '
        Me.Authorisation.Enabled = False
        Me.Authorisation.Location = New System.Drawing.Point(174, 260)
        Me.Authorisation.Margin = New System.Windows.Forms.Padding(2)
        Me.Authorisation.Multiline = True
        Me.Authorisation.Name = "Authorisation"
        Me.Authorisation.ReadOnly = True
        Me.Authorisation.Size = New System.Drawing.Size(368, 19)
        Me.Authorisation.TabIndex = 54
        '
        'EquipmentState
        '
        Me.EquipmentState.Enabled = False
        Me.EquipmentState.Location = New System.Drawing.Point(380, 202)
        Me.EquipmentState.Margin = New System.Windows.Forms.Padding(2)
        Me.EquipmentState.Multiline = True
        Me.EquipmentState.Name = "EquipmentState"
        Me.EquipmentState.ReadOnly = True
        Me.EquipmentState.Size = New System.Drawing.Size(162, 19)
        Me.EquipmentState.TabIndex = 53
        '
        'CategoryName
        '
        Me.CategoryName.Enabled = False
        Me.CategoryName.Location = New System.Drawing.Point(164, 201)
        Me.CategoryName.Margin = New System.Windows.Forms.Padding(2)
        Me.CategoryName.Multiline = True
        Me.CategoryName.Name = "CategoryName"
        Me.CategoryName.ReadOnly = True
        Me.CategoryName.Size = New System.Drawing.Size(162, 19)
        Me.CategoryName.TabIndex = 52
        '
        'EquipmentName
        '
        Me.EquipmentName.Enabled = False
        Me.EquipmentName.Location = New System.Drawing.Point(174, 164)
        Me.EquipmentName.Margin = New System.Windows.Forms.Padding(2)
        Me.EquipmentName.Multiline = True
        Me.EquipmentName.Name = "EquipmentName"
        Me.EquipmentName.ReadOnly = True
        Me.EquipmentName.Size = New System.Drawing.Size(368, 19)
        Me.EquipmentName.TabIndex = 51
        '
        'RenterFirstName
        '
        Me.RenterFirstName.Enabled = False
        Me.RenterFirstName.Location = New System.Drawing.Point(164, 76)
        Me.RenterFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.RenterFirstName.Multiline = True
        Me.RenterFirstName.Name = "RenterFirstName"
        Me.RenterFirstName.ReadOnly = True
        Me.RenterFirstName.Size = New System.Drawing.Size(162, 19)
        Me.RenterFirstName.TabIndex = 49
        '
        'RenterLastName
        '
        Me.RenterLastName.Enabled = False
        Me.RenterLastName.Location = New System.Drawing.Point(380, 74)
        Me.RenterLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.RenterLastName.Multiline = True
        Me.RenterLastName.Name = "RenterLastName"
        Me.RenterLastName.ReadOnly = True
        Me.RenterLastName.Size = New System.Drawing.Size(162, 19)
        Me.RenterLastName.TabIndex = 48
        '
        'RenterStatus
        '
        Me.RenterStatus.Enabled = False
        Me.RenterStatus.Location = New System.Drawing.Point(164, 115)
        Me.RenterStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.RenterStatus.Multiline = True
        Me.RenterStatus.Name = "RenterStatus"
        Me.RenterStatus.ReadOnly = True
        Me.RenterStatus.Size = New System.Drawing.Size(162, 19)
        Me.RenterStatus.TabIndex = 47
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(343, 310)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 17)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Date de retour"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(76, 310)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 17)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Date d'emprunt"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(85, 262)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 17)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Autorisé par"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(343, 202)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 17)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "État"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(91, 202)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 17)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Catégorie"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(87, 166)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 17)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Équipement"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(118, 117)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Statut"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(76, 46)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 17)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Emprunté par"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(343, 76)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 17)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(108, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Prénom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(338, 117)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 17)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "Email"
        '
        'Email
        '
        Me.Email.Enabled = False
        Me.Email.Location = New System.Drawing.Point(380, 115)
        Me.Email.Margin = New System.Windows.Forms.Padding(2)
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Size = New System.Drawing.Size(162, 20)
        Me.Email.TabIndex = 106
        '
        'IRentalsDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(586, 440)
        Me.Name = "IRentalsDetails"
        Me.Size = New System.Drawing.Size(586, 440)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RentalID As TextBox
    Friend WithEvents ReturnDate As DateTimePicker
    Friend WithEvents RentalDate As DateTimePicker
    Friend WithEvents Authorisation As TextBox
    Friend WithEvents EquipmentState As TextBox
    Friend WithEvents CategoryName As TextBox
    Friend WithEvents EquipmentName As TextBox
    Friend WithEvents RenterFirstName As TextBox
    Friend WithEvents RenterLastName As TextBox
    Friend WithEvents RenterStatus As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ModifyButton As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Email As TextBox
End Class
