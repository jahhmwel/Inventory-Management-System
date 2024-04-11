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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.oldpasstxt = New System.Windows.Forms.TextBox()
        Me.usernametxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.newpasstxt = New System.Windows.Forms.TextBox()
        Me.confirmpasstxt = New System.Windows.Forms.TextBox()
        Me.changepassbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.cancelbtn = New Guna.UI2.WinForms.Guna2Button()
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
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(714, 12)
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
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(754, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(34, 26)
        Me.Guna2ControlBox1.TabIndex = 40
        '
        'oldpasstxt
        '
        Me.oldpasstxt.Location = New System.Drawing.Point(271, 114)
        Me.oldpasstxt.Name = "oldpasstxt"
        Me.oldpasstxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.oldpasstxt.Size = New System.Drawing.Size(241, 22)
        Me.oldpasstxt.TabIndex = 45
        '
        'usernametxt
        '
        Me.usernametxt.Location = New System.Drawing.Point(271, 67)
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.Size = New System.Drawing.Size(241, 22)
        Me.usernametxt.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 16)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Current Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Username :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(111, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 16)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Confirm Password :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(111, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 16)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "New Password :"
        '
        'newpasstxt
        '
        Me.newpasstxt.Location = New System.Drawing.Point(271, 157)
        Me.newpasstxt.Name = "newpasstxt"
        Me.newpasstxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.newpasstxt.Size = New System.Drawing.Size(241, 22)
        Me.newpasstxt.TabIndex = 48
        '
        'confirmpasstxt
        '
        Me.confirmpasstxt.Location = New System.Drawing.Point(271, 199)
        Me.confirmpasstxt.Name = "confirmpasstxt"
        Me.confirmpasstxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.confirmpasstxt.Size = New System.Drawing.Size(241, 22)
        Me.confirmpasstxt.TabIndex = 49
        '
        'changepassbtn
        '
        Me.changepassbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.changepassbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.changepassbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.changepassbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.changepassbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.changepassbtn.ForeColor = System.Drawing.Color.White
        Me.changepassbtn.Location = New System.Drawing.Point(388, 272)
        Me.changepassbtn.Name = "changepassbtn"
        Me.changepassbtn.Size = New System.Drawing.Size(180, 45)
        Me.changepassbtn.TabIndex = 50
        Me.changepassbtn.Text = "Change Password"
        '
        'cancelbtn
        '
        Me.cancelbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cancelbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cancelbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cancelbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cancelbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cancelbtn.ForeColor = System.Drawing.Color.White
        Me.cancelbtn.Location = New System.Drawing.Point(151, 272)
        Me.cancelbtn.Name = "cancelbtn"
        Me.cancelbtn.Size = New System.Drawing.Size(180, 45)
        Me.cancelbtn.TabIndex = 51
        Me.cancelbtn.Text = "Cancel"
        '
        'ForgotPassForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cancelbtn)
        Me.Controls.Add(Me.changepassbtn)
        Me.Controls.Add(Me.confirmpasstxt)
        Me.Controls.Add(Me.newpasstxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.oldpasstxt)
        Me.Controls.Add(Me.usernametxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ForgotPassForm"
        Me.Text = "ForgotPassForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents confirmpasstxt As TextBox
    Friend WithEvents newpasstxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents oldpasstxt As TextBox
    Friend WithEvents usernametxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents changepassbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cancelbtn As Guna.UI2.WinForms.Guna2Button
End Class
