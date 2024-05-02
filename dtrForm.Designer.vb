<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dtrForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dtrForm))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.printdtrbtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.namecmb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.totalhourstxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dgdtr = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.backbtn = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.dgdtr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.backbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'printdtrbtn
        '
        Me.printdtrbtn.Animated = True
        Me.printdtrbtn.AutoRoundedCorners = True
        Me.printdtrbtn.BackColor = System.Drawing.Color.Transparent
        Me.printdtrbtn.BorderRadius = 21
        Me.printdtrbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.printdtrbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.printdtrbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.printdtrbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.printdtrbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.printdtrbtn.FillColor = System.Drawing.Color.Coral
        Me.printdtrbtn.FillColor2 = System.Drawing.SystemColors.MenuHighlight
        Me.printdtrbtn.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.printdtrbtn.ForeColor = System.Drawing.Color.White
        Me.printdtrbtn.Location = New System.Drawing.Point(748, 442)
        Me.printdtrbtn.Name = "printdtrbtn"
        Me.printdtrbtn.Size = New System.Drawing.Size(180, 45)
        Me.printdtrbtn.TabIndex = 67
        Me.printdtrbtn.Text = "PRINT DTR"
        '
        'namecmb
        '
        Me.namecmb.BackColor = System.Drawing.Color.Transparent
        Me.namecmb.BorderColor = System.Drawing.SystemColors.Highlight
        Me.namecmb.BorderThickness = 3
        Me.namecmb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.namecmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.namecmb.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.namecmb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.namecmb.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.namecmb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.namecmb.ItemHeight = 30
        Me.namecmb.Location = New System.Drawing.Point(292, 145)
        Me.namecmb.Name = "namecmb"
        Me.namecmb.Size = New System.Drawing.Size(636, 36)
        Me.namecmb.TabIndex = 64
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(909, 11)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(34, 26)
        Me.Guna2ControlBox2.TabIndex = 62
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(949, 11)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(34, 26)
        Me.Guna2ControlBox1.TabIndex = 61
        '
        'totalhourstxt
        '
        Me.totalhourstxt.Animated = True
        Me.totalhourstxt.BorderColor = System.Drawing.Color.Transparent
        Me.totalhourstxt.BorderRadius = 4
        Me.totalhourstxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.totalhourstxt.DefaultText = ""
        Me.totalhourstxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.totalhourstxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.totalhourstxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.totalhourstxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.totalhourstxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.totalhourstxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.totalhourstxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.totalhourstxt.Location = New System.Drawing.Point(738, 55)
        Me.totalhourstxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.totalhourstxt.Name = "totalhourstxt"
        Me.totalhourstxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.totalhourstxt.PlaceholderText = ""
        Me.totalhourstxt.SelectedText = ""
        Me.totalhourstxt.Size = New System.Drawing.Size(194, 28)
        Me.totalhourstxt.TabIndex = 68
        '
        'dgdtr
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgdtr.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgdtr.BackgroundColor = System.Drawing.Color.LightGray
        Me.dgdtr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgdtr.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgdtr.ColumnHeadersHeight = 4
        Me.dgdtr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgdtr.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgdtr.GridColor = System.Drawing.Color.Silver
        Me.dgdtr.Location = New System.Drawing.Point(292, 203)
        Me.dgdtr.Name = "dgdtr"
        Me.dgdtr.RowHeadersVisible = False
        Me.dgdtr.RowHeadersWidth = 51
        Me.dgdtr.RowTemplate.Height = 24
        Me.dgdtr.Size = New System.Drawing.Size(636, 233)
        Me.dgdtr.TabIndex = 69
        Me.dgdtr.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgdtr.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgdtr.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgdtr.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgdtr.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgdtr.ThemeStyle.BackColor = System.Drawing.Color.LightGray
        Me.dgdtr.ThemeStyle.GridColor = System.Drawing.Color.Silver
        Me.dgdtr.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgdtr.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgdtr.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgdtr.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgdtr.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgdtr.ThemeStyle.HeaderStyle.Height = 4
        Me.dgdtr.ThemeStyle.ReadOnly = False
        Me.dgdtr.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgdtr.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgdtr.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgdtr.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgdtr.ThemeStyle.RowsStyle.Height = 24
        Me.dgdtr.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgdtr.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(507, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 26)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Total Hours Attended:"
        '
        'backbtn
        '
        Me.backbtn.BackColor = System.Drawing.Color.Transparent
        Me.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.backbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backbtn.Image = CType(resources.GetObject("backbtn.Image"), System.Drawing.Image)
        Me.backbtn.ImageRotate = 0!
        Me.backbtn.Location = New System.Drawing.Point(25, 21)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(41, 39)
        Me.backbtn.TabIndex = 71
        Me.backbtn.TabStop = False
        '
        'dtrForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.totalhourstxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgdtr)
        Me.Controls.Add(Me.printdtrbtn)
        Me.Controls.Add(Me.namecmb)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dtrForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dtrForm"
        CType(Me.dgdtr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.backbtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents printdtrbtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents namecmb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents totalhourstxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgdtr As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents backbtn As Guna.UI2.WinForms.Guna2PictureBox
End Class
