﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IInventory
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CategoryButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.ModifyButton = New System.Windows.Forms.Button()
        Me.AddInventoryButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ViewPanel = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.CompleteInventory = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RentedInventory = New System.Windows.Forms.TabPage()
        Me.DammagedInventory = New System.Windows.Forms.TabPage()
        Me.OrderedInventory = New System.Windows.Forms.TabPage()
        Me.Panel1.SuspendLayout()
        Me.ViewPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.CompleteInventory.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CategoryButton)
        Me.Panel1.Controls.Add(Me.DeleteButton)
        Me.Panel1.Controls.Add(Me.ModifyButton)
        Me.Panel1.Controls.Add(Me.AddInventoryButton)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(333, 542)
        Me.Panel1.TabIndex = 0
        '
        'CategoryButton
        '
        Me.CategoryButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.CategoryButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CategoryButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.CategoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.CategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CategoryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryButton.ForeColor = System.Drawing.Color.White
        Me.CategoryButton.Location = New System.Drawing.Point(0, 480)
        Me.CategoryButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CategoryButton.Name = "CategoryButton"
        Me.CategoryButton.Size = New System.Drawing.Size(276, 62)
        Me.CategoryButton.TabIndex = 7
        Me.CategoryButton.Text = "Categories"
        Me.CategoryButton.UseVisualStyleBackColor = False
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.DeleteButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.Color.White
        Me.DeleteButton.Location = New System.Drawing.Point(0, 138)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(276, 62)
        Me.DeleteButton.TabIndex = 6
        Me.DeleteButton.Text = "Supprimer un Équipement"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'ModifyButton
        '
        Me.ModifyButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ModifyButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.ModifyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ModifyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ModifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ModifyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModifyButton.ForeColor = System.Drawing.Color.White
        Me.ModifyButton.Location = New System.Drawing.Point(0, 76)
        Me.ModifyButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ModifyButton.Name = "ModifyButton"
        Me.ModifyButton.Size = New System.Drawing.Size(276, 62)
        Me.ModifyButton.TabIndex = 5
        Me.ModifyButton.Text = "Modifier un Équipement"
        Me.ModifyButton.UseVisualStyleBackColor = False
        '
        'AddInventoryButton
        '
        Me.AddInventoryButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.AddInventoryButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddInventoryButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.AddInventoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.AddInventoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddInventoryButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddInventoryButton.ForeColor = System.Drawing.Color.White
        Me.AddInventoryButton.Location = New System.Drawing.Point(0, 14)
        Me.AddInventoryButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AddInventoryButton.Name = "AddInventoryButton"
        Me.AddInventoryButton.Size = New System.Drawing.Size(276, 62)
        Me.AddInventoryButton.TabIndex = 4
        Me.AddInventoryButton.Text = "Ajouter un Équipement"
        Me.AddInventoryButton.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(276, 14)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(57, 528)
        Me.Panel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(333, 14)
        Me.Panel4.TabIndex = 2
        '
        'ViewPanel
        '
        Me.ViewPanel.Controls.Add(Me.TabControl1)
        Me.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewPanel.Location = New System.Drawing.Point(333, 0)
        Me.ViewPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ViewPanel.Name = "ViewPanel"
        Me.ViewPanel.Size = New System.Drawing.Size(448, 542)
        Me.ViewPanel.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.CompleteInventory)
        Me.TabControl1.Controls.Add(Me.RentedInventory)
        Me.TabControl1.Controls.Add(Me.DammagedInventory)
        Me.TabControl1.Controls.Add(Me.OrderedInventory)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(448, 542)
        Me.TabControl1.TabIndex = 0
        '
        'CompleteInventory
        '
        Me.CompleteInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.CompleteInventory.Controls.Add(Me.DataGridView1)
        Me.CompleteInventory.ForeColor = System.Drawing.Color.White
        Me.CompleteInventory.Location = New System.Drawing.Point(4, 25)
        Me.CompleteInventory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CompleteInventory.Name = "CompleteInventory"
        Me.CompleteInventory.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CompleteInventory.Size = New System.Drawing.Size(440, 513)
        Me.CompleteInventory.TabIndex = 0
        Me.CompleteInventory.Text = "Inventaire Complet"
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.Location = New System.Drawing.Point(3, 2)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(434, 509)
        Me.DataGridView1.TabIndex = 0
        '
        'RentedInventory
        '
        Me.RentedInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.RentedInventory.ForeColor = System.Drawing.Color.White
        Me.RentedInventory.Location = New System.Drawing.Point(4, 25)
        Me.RentedInventory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RentedInventory.Name = "RentedInventory"
        Me.RentedInventory.Size = New System.Drawing.Size(440, 513)
        Me.RentedInventory.TabIndex = 1
        Me.RentedInventory.Text = "Inventaire Emprunté"
        '
        'DammagedInventory
        '
        Me.DammagedInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DammagedInventory.ForeColor = System.Drawing.Color.White
        Me.DammagedInventory.Location = New System.Drawing.Point(4, 25)
        Me.DammagedInventory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DammagedInventory.Name = "DammagedInventory"
        Me.DammagedInventory.Size = New System.Drawing.Size(440, 513)
        Me.DammagedInventory.TabIndex = 2
        Me.DammagedInventory.Text = "Inventaire Endommagé"
        '
        'OrderedInventory
        '
        Me.OrderedInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.OrderedInventory.ForeColor = System.Drawing.Color.White
        Me.OrderedInventory.Location = New System.Drawing.Point(4, 25)
        Me.OrderedInventory.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OrderedInventory.Name = "OrderedInventory"
        Me.OrderedInventory.Size = New System.Drawing.Size(440, 513)
        Me.OrderedInventory.TabIndex = 3
        Me.OrderedInventory.Text = "Inventaire en Commande"
        '
        'IInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.ViewPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(781, 542)
        Me.Name = "IInventory"
        Me.Size = New System.Drawing.Size(781, 542)
        Me.Panel1.ResumeLayout(False)
        Me.ViewPanel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.CompleteInventory.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ViewPanel As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents AddInventoryButton As Button
    Friend WithEvents ModifyButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents CompleteInventory As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RentedInventory As TabPage
    Friend WithEvents DammagedInventory As TabPage
    Friend WithEvents OrderedInventory As TabPage
    Friend WithEvents CategoryButton As Button
End Class
