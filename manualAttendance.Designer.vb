<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manualAttendance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manualAttendance))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.namecmb = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.timeinbtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.timeoutbtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.printdtrbtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.backbtn = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.backbtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(907, 12)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(34, 26)
        Me.Guna2ControlBox2.TabIndex = 45
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(947, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(34, 26)
        Me.Guna2ControlBox1.TabIndex = 44
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
        Me.namecmb.Location = New System.Drawing.Point(290, 146)
        Me.namecmb.Name = "namecmb"
        Me.namecmb.Size = New System.Drawing.Size(636, 36)
        Me.namecmb.TabIndex = 47
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.Animated = True
        Me.Guna2DateTimePicker1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2DateTimePicker1.Checked = True
        Me.Guna2DateTimePicker1.FillColor = System.Drawing.SystemColors.InactiveCaption
        Me.Guna2DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.IndicateFocus = True
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(676, 211)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(250, 36)
        Me.Guna2DateTimePicker1.TabIndex = 48
        Me.Guna2DateTimePicker1.UseTransparentBackground = True
        Me.Guna2DateTimePicker1.Value = New Date(2024, 4, 28, 1, 17, 9, 619)
        '
        'timeinbtn
        '
        Me.timeinbtn.Animated = True
        Me.timeinbtn.AutoRoundedCorners = True
        Me.timeinbtn.BackColor = System.Drawing.Color.Transparent
        Me.timeinbtn.BorderRadius = 21
        Me.timeinbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.timeinbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.timeinbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.timeinbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.timeinbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.timeinbtn.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.timeinbtn.FillColor2 = System.Drawing.SystemColors.Highlight
        Me.timeinbtn.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.timeinbtn.ForeColor = System.Drawing.Color.White
        Me.timeinbtn.Location = New System.Drawing.Point(536, 274)
        Me.timeinbtn.Name = "timeinbtn"
        Me.timeinbtn.Size = New System.Drawing.Size(180, 45)
        Me.timeinbtn.TabIndex = 49
        Me.timeinbtn.Text = "TIME IN"
        '
        'timeoutbtn
        '
        Me.timeoutbtn.Animated = True
        Me.timeoutbtn.AutoRoundedCorners = True
        Me.timeoutbtn.BackColor = System.Drawing.Color.Transparent
        Me.timeoutbtn.BorderRadius = 21
        Me.timeoutbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.timeoutbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.timeoutbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.timeoutbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.timeoutbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.timeoutbtn.FillColor = System.Drawing.SystemColors.ActiveCaption
        Me.timeoutbtn.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.timeoutbtn.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.timeoutbtn.ForeColor = System.Drawing.Color.White
        Me.timeoutbtn.Location = New System.Drawing.Point(746, 274)
        Me.timeoutbtn.Name = "timeoutbtn"
        Me.timeoutbtn.Size = New System.Drawing.Size(180, 45)
        Me.timeoutbtn.TabIndex = 50
        Me.timeoutbtn.Text = "TIME OUT"
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
        Me.printdtrbtn.Location = New System.Drawing.Point(746, 410)
        Me.printdtrbtn.Name = "printdtrbtn"
        Me.printdtrbtn.Size = New System.Drawing.Size(180, 45)
        Me.printdtrbtn.TabIndex = 51
        Me.printdtrbtn.Text = "PRINT DTR"
        '
        'backbtn
        '
        Me.backbtn.BackColor = System.Drawing.Color.Transparent
        Me.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.backbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backbtn.Image = CType(resources.GetObject("backbtn.Image"), System.Drawing.Image)
        Me.backbtn.ImageRotate = 0!
        Me.backbtn.Location = New System.Drawing.Point(12, 12)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(41, 39)
        Me.backbtn.TabIndex = 62
        Me.backbtn.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(285, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 26)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Select Name:"
        '
        'manualAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.printdtrbtn)
        Me.Controls.Add(Me.timeoutbtn)
        Me.Controls.Add(Me.timeinbtn)
        Me.Controls.Add(Me.Guna2DateTimePicker1)
        Me.Controls.Add(Me.namecmb)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "manualAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "manualAttendance"
        CType(Me.backbtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents timeinbtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents namecmb As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents printdtrbtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents timeoutbtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents backbtn As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
End Class
