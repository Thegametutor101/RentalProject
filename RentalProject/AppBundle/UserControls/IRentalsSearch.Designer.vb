<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IRentalsSearch
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
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ViewPanel = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.RentedBy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EquipmentName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Authorisation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.DetailsButton = New System.Windows.Forms.Button()
        Me.ByRenterName = New System.Windows.Forms.RadioButton()
        Me.RenterFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RenterLastName = New System.Windows.Forms.TextBox()
        Me.CategoryName = New System.Windows.Forms.TextBox()
        Me.ByCategoryName = New System.Windows.Forms.RadioButton()
        Me.AuthorisationName = New System.Windows.Forms.TextBox()
        Me.ByAuthorisationName = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.ViewPanel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BackButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(586, 50)
        Me.Panel1.TabIndex = 1
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
        'ViewPanel
        '
        Me.ViewPanel.Controls.Add(Me.ListView1)
        Me.ViewPanel.Controls.Add(Me.Panel3)
        Me.ViewPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.ViewPanel.Location = New System.Drawing.Point(289, 50)
        Me.ViewPanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ViewPanel.Name = "ViewPanel"
        Me.ViewPanel.Size = New System.Drawing.Size(297, 390)
        Me.ViewPanel.TabIndex = 2
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.RentedBy, Me.EquipmentName, Me.Authorisation})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(297, 348)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'RentedBy
        '
        Me.RentedBy.Text = "Emprunté par"
        Me.RentedBy.Width = 125
        '
        'EquipmentName
        '
        Me.EquipmentName.Text = "Nom Équipement"
        Me.EquipmentName.Width = 137
        '
        'Authorisation
        '
        Me.Authorisation.Text = "Autorisation"
        Me.Authorisation.Width = 118
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.SearchButton)
        Me.Panel3.Controls.Add(Me.DetailsButton)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 348)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(297, 42)
        Me.Panel3.TabIndex = 0
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
        Me.SearchButton.Location = New System.Drawing.Point(0, 0)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(119, 42)
        Me.SearchButton.TabIndex = 0
        Me.SearchButton.Text = "Rechercher"
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'DetailsButton
        '
        Me.DetailsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.DetailsButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.DetailsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DetailsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DetailsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailsButton.ForeColor = System.Drawing.Color.White
        Me.DetailsButton.Location = New System.Drawing.Point(119, 0)
        Me.DetailsButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DetailsButton.Name = "DetailsButton"
        Me.DetailsButton.Size = New System.Drawing.Size(178, 42)
        Me.DetailsButton.TabIndex = 1
        Me.DetailsButton.Text = "Afficher les Détails"
        Me.DetailsButton.UseVisualStyleBackColor = False
        '
        'ByRenterName
        '
        Me.ByRenterName.AutoSize = True
        Me.ByRenterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ByRenterName.Location = New System.Drawing.Point(30, 101)
        Me.ByRenterName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ByRenterName.Name = "ByRenterName"
        Me.ByRenterName.Size = New System.Drawing.Size(158, 21)
        Me.ByRenterName.TabIndex = 0
        Me.ByRenterName.TabStop = True
        Me.ByRenterName.Text = "Nom de l'emprunteur"
        Me.ByRenterName.UseVisualStyleBackColor = True
        '
        'RenterFirstName
        '
        Me.RenterFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RenterFirstName.Location = New System.Drawing.Point(29, 142)
        Me.RenterFirstName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RenterFirstName.Multiline = True
        Me.RenterFirstName.Name = "RenterFirstName"
        Me.RenterFirstName.Size = New System.Drawing.Size(103, 28)
        Me.RenterFirstName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Rechercher par..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 126)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Prénom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 126)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nom"
        '
        'RenterLastName
        '
        Me.RenterLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RenterLastName.Location = New System.Drawing.Point(161, 142)
        Me.RenterLastName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RenterLastName.Multiline = True
        Me.RenterLastName.Name = "RenterLastName"
        Me.RenterLastName.Size = New System.Drawing.Size(103, 28)
        Me.RenterLastName.TabIndex = 5
        '
        'CategoryName
        '
        Me.CategoryName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryName.Location = New System.Drawing.Point(29, 215)
        Me.CategoryName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CategoryName.Multiline = True
        Me.CategoryName.Name = "CategoryName"
        Me.CategoryName.Size = New System.Drawing.Size(235, 28)
        Me.CategoryName.TabIndex = 8
        '
        'ByCategoryName
        '
        Me.ByCategoryName.AutoSize = True
        Me.ByCategoryName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ByCategoryName.Location = New System.Drawing.Point(30, 191)
        Me.ByCategoryName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ByCategoryName.Name = "ByCategoryName"
        Me.ByCategoryName.Size = New System.Drawing.Size(138, 21)
        Me.ByCategoryName.TabIndex = 7
        Me.ByCategoryName.TabStop = True
        Me.ByCategoryName.Text = "Nom de catégorie"
        Me.ByCategoryName.UseVisualStyleBackColor = True
        '
        'AuthorisationName
        '
        Me.AuthorisationName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AuthorisationName.Location = New System.Drawing.Point(29, 286)
        Me.AuthorisationName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AuthorisationName.Multiline = True
        Me.AuthorisationName.Name = "AuthorisationName"
        Me.AuthorisationName.Size = New System.Drawing.Size(235, 28)
        Me.AuthorisationName.TabIndex = 10
        '
        'ByAuthorisationName
        '
        Me.ByAuthorisationName.AutoSize = True
        Me.ByAuthorisationName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ByAuthorisationName.Location = New System.Drawing.Point(30, 262)
        Me.ByAuthorisationName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ByAuthorisationName.Name = "ByAuthorisationName"
        Me.ByAuthorisationName.Size = New System.Drawing.Size(144, 21)
        Me.ByAuthorisationName.TabIndex = 9
        Me.ByAuthorisationName.TabStop = True
        Me.ByAuthorisationName.Text = "Nom d'autorisation"
        Me.ByAuthorisationName.UseVisualStyleBackColor = True
        '
        'IRentalsSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.AuthorisationName)
        Me.Controls.Add(Me.ByAuthorisationName)
        Me.Controls.Add(Me.CategoryName)
        Me.Controls.Add(Me.ByCategoryName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RenterLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RenterFirstName)
        Me.Controls.Add(Me.ByRenterName)
        Me.Controls.Add(Me.ViewPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(586, 440)
        Me.Name = "IRentalsSearch"
        Me.Size = New System.Drawing.Size(586, 440)
        Me.Panel1.ResumeLayout(False)
        Me.ViewPanel.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ViewPanel As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DetailsButton As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents RentedBy As ColumnHeader
    Friend WithEvents EquipmentName As ColumnHeader
    Friend WithEvents Authorisation As ColumnHeader
    Friend WithEvents SearchButton As Button
    Friend WithEvents ByRenterName As RadioButton
    Friend WithEvents RenterFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RenterLastName As TextBox
    Friend WithEvents CategoryName As TextBox
    Friend WithEvents ByCategoryName As RadioButton
    Friend WithEvents AuthorisationName As TextBox
    Friend WithEvents ByAuthorisationName As RadioButton
End Class
