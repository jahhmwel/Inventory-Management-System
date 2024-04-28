<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        Me.numberlabel = New System.Windows.Forms.LinkLabel()
        Me.emaillabel = New System.Windows.Forms.LinkLabel()
        Me.facebooklabel = New System.Windows.Forms.LinkLabel()
        Me.websitelabel = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.loginbtn = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.usernametxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.passwordtxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2CheckBox1 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.LinkLabel5 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.registerlink = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'numberlabel
        '
        Me.numberlabel.AutoSize = True
        Me.numberlabel.BackColor = System.Drawing.Color.Transparent
        Me.numberlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numberlabel.Location = New System.Drawing.Point(908, 551)
        Me.numberlabel.Name = "numberlabel"
        Me.numberlabel.Size = New System.Drawing.Size(88, 15)
        Me.numberlabel.TabIndex = 19
        Me.numberlabel.TabStop = True
        Me.numberlabel.Text = "0905-3782611"
        Me.numberlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'emaillabel
        '
        Me.emaillabel.AutoSize = True
        Me.emaillabel.BackColor = System.Drawing.Color.Transparent
        Me.emaillabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emaillabel.Location = New System.Drawing.Point(670, 551)
        Me.emaillabel.Name = "emaillabel"
        Me.emaillabel.Size = New System.Drawing.Size(148, 15)
        Me.emaillabel.TabIndex = 18
        Me.emaillabel.TabStop = True
        Me.emaillabel.Text = "bu-library@bicol-u.edu.ph"
        Me.emaillabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'facebooklabel
        '
        Me.facebooklabel.AutoSize = True
        Me.facebooklabel.BackColor = System.Drawing.Color.Transparent
        Me.facebooklabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.facebooklabel.Location = New System.Drawing.Point(404, 551)
        Me.facebooklabel.Name = "facebooklabel"
        Me.facebooklabel.Size = New System.Drawing.Size(151, 15)
        Me.facebooklabel.TabIndex = 17
        Me.facebooklabel.TabStop = True
        Me.facebooklabel.Text = "/aklatangunibersidad.bicol"
        Me.facebooklabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'websitelabel
        '
        Me.websitelabel.AutoSize = True
        Me.websitelabel.BackColor = System.Drawing.Color.Transparent
        Me.websitelabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.websitelabel.Location = New System.Drawing.Point(81, 551)
        Me.websitelabel.Name = "websitelabel"
        Me.websitelabel.Size = New System.Drawing.Size(207, 15)
        Me.websitelabel.TabIndex = 16
        Me.websitelabel.TabStop = True
        Me.websitelabel.Text = "sites.google.com/bicol-u.edu.ph/buls"
        Me.websitelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.IndianRed
        Me.Label2.Location = New System.Drawing.Point(125, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "PASSWORD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.IndianRed
        Me.Label1.Location = New System.Drawing.Point(124, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "USERNAME"
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
        Me.Guna2ControlBox1.TabIndex = 20
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'loginbtn
        '
        Me.loginbtn.Animated = True
        Me.loginbtn.AutoRoundedCorners = True
        Me.loginbtn.BackColor = System.Drawing.Color.Transparent
        Me.loginbtn.BorderColor = System.Drawing.Color.Transparent
        Me.loginbtn.BorderRadius = 18
        Me.loginbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.loginbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.loginbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.loginbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.loginbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.loginbtn.FillColor = System.Drawing.Color.DodgerBlue
        Me.loginbtn.FillColor2 = System.Drawing.Color.DarkOrange
        Me.loginbtn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold)
        Me.loginbtn.ForeColor = System.Drawing.Color.White
        Me.loginbtn.Location = New System.Drawing.Point(129, 432)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(261, 38)
        Me.loginbtn.TabIndex = 21
        Me.loginbtn.Text = "LOGIN"
        '
        'usernametxt
        '
        Me.usernametxt.BackColor = System.Drawing.Color.Transparent
        Me.usernametxt.BorderRadius = 10
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
        Me.usernametxt.IconLeft = CType(resources.GetObject("usernametxt.IconLeft"), System.Drawing.Image)
        Me.usernametxt.Location = New System.Drawing.Point(128, 252)
        Me.usernametxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.usernametxt.PlaceholderText = ""
        Me.usernametxt.SelectedText = ""
        Me.usernametxt.Size = New System.Drawing.Size(261, 37)
        Me.usernametxt.TabIndex = 35
        '
        'passwordtxt
        '
        Me.passwordtxt.AutoRoundedCorners = True
        Me.passwordtxt.BackColor = System.Drawing.Color.Transparent
        Me.passwordtxt.BorderRadius = 17
        Me.passwordtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwordtxt.DefaultText = ""
        Me.passwordtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.passwordtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.passwordtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.passwordtxt.FillColor = System.Drawing.Color.WhiteSmoke
        Me.passwordtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordtxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.passwordtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.passwordtxt.IconLeft = CType(resources.GetObject("passwordtxt.IconLeft"), System.Drawing.Image)
        Me.passwordtxt.Location = New System.Drawing.Point(128, 333)
        Me.passwordtxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.passwordtxt.PlaceholderText = ""
        Me.passwordtxt.SelectedText = ""
        Me.passwordtxt.Size = New System.Drawing.Size(261, 37)
        Me.passwordtxt.TabIndex = 36
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
        Me.Guna2ControlBox2.TabIndex = 37
        '
        'Guna2CheckBox1
        '
        Me.Guna2CheckBox1.AutoSize = True
        Me.Guna2CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2CheckBox1.CheckedState.BorderRadius = 0
        Me.Guna2CheckBox1.CheckedState.BorderThickness = 0
        Me.Guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CheckBox1.CheckMarkColor = System.Drawing.Color.Black
        Me.Guna2CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.Guna2CheckBox1.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2CheckBox1.Location = New System.Drawing.Point(135, 384)
        Me.Guna2CheckBox1.Name = "Guna2CheckBox1"
        Me.Guna2CheckBox1.Size = New System.Drawing.Size(125, 20)
        Me.Guna2CheckBox1.TabIndex = 44
        Me.Guna2CheckBox1.Text = "Show Password"
        Me.Guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2CheckBox1.UncheckedState.BorderRadius = 0
        Me.Guna2CheckBox1.UncheckedState.BorderThickness = 0
        Me.Guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CheckBox1.UseVisualStyleBackColor = False
        '
        'LinkLabel5
        '
        Me.LinkLabel5.AutoSize = True
        Me.LinkLabel5.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel5.ForeColor = System.Drawing.Color.Transparent
        Me.LinkLabel5.LinkColor = System.Drawing.Color.Blue
        Me.LinkLabel5.Location = New System.Drawing.Point(280, 385)
        Me.LinkLabel5.Name = "LinkLabel5"
        Me.LinkLabel5.Size = New System.Drawing.Size(109, 16)
        Me.LinkLabel5.TabIndex = 45
        Me.LinkLabel5.TabStop = True
        Me.LinkLabel5.Text = "Forgot Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(134, 496)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 19)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Don't have an account?"
        '
        'registerlink
        '
        Me.registerlink.AutoSize = True
        Me.registerlink.BackColor = System.Drawing.Color.Transparent
        Me.registerlink.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.registerlink.ForeColor = System.Drawing.Color.Transparent
        Me.registerlink.LinkColor = System.Drawing.Color.Blue
        Me.registerlink.Location = New System.Drawing.Point(295, 496)
        Me.registerlink.Name = "registerlink"
        Me.registerlink.Size = New System.Drawing.Size(91, 19)
        Me.registerlink.TabIndex = 47
        Me.registerlink.TabStop = True
        Me.registerlink.Text = "Register Here"
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1060, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.registerlink)
        Me.Controls.Add(Me.LinkLabel5)
        Me.Controls.Add(Me.Guna2CheckBox1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.passwordtxt)
        Me.Controls.Add(Me.usernametxt)
        Me.Controls.Add(Me.loginbtn)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.numberlabel)
        Me.Controls.Add(Me.emaillabel)
        Me.Controls.Add(Me.facebooklabel)
        Me.Controls.Add(Me.websitelabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "loginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "loginForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents numberlabel As LinkLabel
    Friend WithEvents emaillabel As LinkLabel
    Friend WithEvents facebooklabel As LinkLabel
    Friend WithEvents websitelabel As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents loginbtn As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents passwordtxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents usernametxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2CheckBox1 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents LinkLabel5 As LinkLabel
    Friend WithEvents registerlink As LinkLabel
    Friend WithEvents Label3 As Label
End Class
