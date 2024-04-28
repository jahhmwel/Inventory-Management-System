<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPassForm))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.usernametxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.oldpasstxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.newpasstxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.confirmpasstxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.changepassbtn = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(974, 12)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(34, 26)
        Me.Guna2ControlBox2.TabIndex = 41
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1014, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(34, 26)
        Me.Guna2ControlBox1.TabIndex = 40
        '
        'usernametxt
        '
        Me.usernametxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernametxt.DefaultText = ""
        Me.usernametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.usernametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.usernametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usernametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usernametxt.FillColor = System.Drawing.Color.WhiteSmoke
        Me.usernametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usernametxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.usernametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usernametxt.Location = New System.Drawing.Point(399, 146)
        Me.usernametxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.usernametxt.PlaceholderText = ""
        Me.usernametxt.SelectedText = ""
        Me.usernametxt.Size = New System.Drawing.Size(290, 38)
        Me.usernametxt.TabIndex = 52
        '
        'oldpasstxt
        '
        Me.oldpasstxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.oldpasstxt.DefaultText = ""
        Me.oldpasstxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.oldpasstxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.oldpasstxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.oldpasstxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.oldpasstxt.FillColor = System.Drawing.Color.WhiteSmoke
        Me.oldpasstxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.oldpasstxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.oldpasstxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.oldpasstxt.Location = New System.Drawing.Point(399, 226)
        Me.oldpasstxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.oldpasstxt.Name = "oldpasstxt"
        Me.oldpasstxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.oldpasstxt.PlaceholderText = ""
        Me.oldpasstxt.SelectedText = ""
        Me.oldpasstxt.Size = New System.Drawing.Size(290, 38)
        Me.oldpasstxt.TabIndex = 53
        '
        'newpasstxt
        '
        Me.newpasstxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.newpasstxt.DefaultText = ""
        Me.newpasstxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.newpasstxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.newpasstxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.newpasstxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.newpasstxt.FillColor = System.Drawing.Color.WhiteSmoke
        Me.newpasstxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.newpasstxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.newpasstxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.newpasstxt.Location = New System.Drawing.Point(399, 307)
        Me.newpasstxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.newpasstxt.Name = "newpasstxt"
        Me.newpasstxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.newpasstxt.PlaceholderText = ""
        Me.newpasstxt.SelectedText = ""
        Me.newpasstxt.Size = New System.Drawing.Size(290, 38)
        Me.newpasstxt.TabIndex = 54
        '
        'confirmpasstxt
        '
        Me.confirmpasstxt.Animated = True
        Me.confirmpasstxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.confirmpasstxt.DefaultText = ""
        Me.confirmpasstxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.confirmpasstxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.confirmpasstxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirmpasstxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.confirmpasstxt.FillColor = System.Drawing.Color.WhiteSmoke
        Me.confirmpasstxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.confirmpasstxt.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.confirmpasstxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.confirmpasstxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.confirmpasstxt.Location = New System.Drawing.Point(399, 389)
        Me.confirmpasstxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.confirmpasstxt.Name = "confirmpasstxt"
        Me.confirmpasstxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.confirmpasstxt.PlaceholderText = ""
        Me.confirmpasstxt.SelectedText = ""
        Me.confirmpasstxt.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.confirmpasstxt.Size = New System.Drawing.Size(290, 38)
        Me.confirmpasstxt.TabIndex = 55
        Me.confirmpasstxt.TextOffset = New System.Drawing.Point(1, 1)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(418, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 33)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "RESET PASSWORD"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.IndianRed
        Me.Label6.Location = New System.Drawing.Point(395, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 23)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "USERNAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.IndianRed
        Me.Label1.Location = New System.Drawing.Point(395, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 23)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "CURRENT PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.IndianRed
        Me.Label2.Location = New System.Drawing.Point(395, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 23)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "NEW PASSWORD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.IndianRed
        Me.Label3.Location = New System.Drawing.Point(399, 365)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 23)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "CONFIRM PASSWORD"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(266, 60)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(41, 39)
        Me.Guna2PictureBox1.TabIndex = 61
        Me.Guna2PictureBox1.TabStop = False
        '
        'changepassbtn
        '
        Me.changepassbtn.Animated = True
        Me.changepassbtn.AutoRoundedCorners = True
        Me.changepassbtn.BackColor = System.Drawing.Color.Transparent
        Me.changepassbtn.BorderRadius = 18
        Me.changepassbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.changepassbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.changepassbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.changepassbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.changepassbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.changepassbtn.FillColor = System.Drawing.Color.DodgerBlue
        Me.changepassbtn.FillColor2 = System.Drawing.Color.DarkOrange
        Me.changepassbtn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold)
        Me.changepassbtn.ForeColor = System.Drawing.Color.White
        Me.changepassbtn.Location = New System.Drawing.Point(438, 452)
        Me.changepassbtn.Name = "changepassbtn"
        Me.changepassbtn.Size = New System.Drawing.Size(203, 38)
        Me.changepassbtn.TabIndex = 62
        Me.changepassbtn.Text = "CONFIRM"
        '
        'ForgotPassForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1060, 600)
        Me.Controls.Add(Me.changepassbtn)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.confirmpasstxt)
        Me.Controls.Add(Me.newpasstxt)
        Me.Controls.Add(Me.oldpasstxt)
        Me.Controls.Add(Me.usernametxt)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ForgotPassForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ForgotPassForm"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents confirmpasstxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents newpasstxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents oldpasstxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents usernametxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents changepassbtn As Guna.UI2.WinForms.Guna2GradientButton
End Class
