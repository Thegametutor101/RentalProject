<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.ViewPanel = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.CompleteInventory = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RentedInventory = New System.Windows.Forms.TabPage()
        Me.DammagedInventory = New System.Windows.Forms.TabPage()
        Me.OrderedInventory = New System.Windows.Forms.TabPage()
        Me.ViewPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.CompleteInventory.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuPanel
        '
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(224, 440)
        Me.MenuPanel.TabIndex = 0
        '
        'ViewPanel
        '
        Me.ViewPanel.Controls.Add(Me.TabControl1)
        Me.ViewPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewPanel.Location = New System.Drawing.Point(224, 0)
        Me.ViewPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.ViewPanel.Name = "ViewPanel"
        Me.ViewPanel.Size = New System.Drawing.Size(362, 440)
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
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(362, 440)
        Me.TabControl1.TabIndex = 0
        '
        'CompleteInventory
        '
        Me.CompleteInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.CompleteInventory.Controls.Add(Me.DataGridView1)
        Me.CompleteInventory.ForeColor = System.Drawing.Color.White
        Me.CompleteInventory.Location = New System.Drawing.Point(4, 22)
        Me.CompleteInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.CompleteInventory.Name = "CompleteInventory"
        Me.CompleteInventory.Padding = New System.Windows.Forms.Padding(2)
        Me.CompleteInventory.Size = New System.Drawing.Size(354, 414)
        Me.CompleteInventory.TabIndex = 0
        Me.CompleteInventory.Text = "Inventaire Complet"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.Location = New System.Drawing.Point(2, 2)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(350, 410)
        Me.DataGridView1.TabIndex = 0
        '
        'RentedInventory
        '
        Me.RentedInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.RentedInventory.ForeColor = System.Drawing.Color.White
        Me.RentedInventory.Location = New System.Drawing.Point(4, 22)
        Me.RentedInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.RentedInventory.Name = "RentedInventory"
        Me.RentedInventory.Size = New System.Drawing.Size(354, 414)
        Me.RentedInventory.TabIndex = 1
        Me.RentedInventory.Text = "Inventaire Emprunté"
        '
        'DammagedInventory
        '
        Me.DammagedInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.DammagedInventory.ForeColor = System.Drawing.Color.White
        Me.DammagedInventory.Location = New System.Drawing.Point(4, 22)
        Me.DammagedInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.DammagedInventory.Name = "DammagedInventory"
        Me.DammagedInventory.Size = New System.Drawing.Size(354, 414)
        Me.DammagedInventory.TabIndex = 2
        Me.DammagedInventory.Text = "Inventaire Endommagé"
        '
        'OrderedInventory
        '
        Me.OrderedInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.OrderedInventory.ForeColor = System.Drawing.Color.White
        Me.OrderedInventory.Location = New System.Drawing.Point(4, 22)
        Me.OrderedInventory.Margin = New System.Windows.Forms.Padding(2)
        Me.OrderedInventory.Name = "OrderedInventory"
        Me.OrderedInventory.Size = New System.Drawing.Size(354, 414)
        Me.OrderedInventory.TabIndex = 3
        Me.OrderedInventory.Text = "Inventaire en Commande"
        '
        'IInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.ViewPanel)
        Me.Controls.Add(Me.MenuPanel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "IInventory"
        Me.Size = New System.Drawing.Size(586, 440)
        Me.ViewPanel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.CompleteInventory.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuPanel As Panel
    Friend WithEvents ViewPanel As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents CompleteInventory As TabPage
    Friend WithEvents RentedInventory As TabPage
    Friend WithEvents DammagedInventory As TabPage
    Friend WithEvents OrderedInventory As TabPage
    Friend WithEvents DataGridView1 As DataGridView
End Class
