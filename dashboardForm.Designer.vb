<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboardForm
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
        Me.addstudentbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.addmodelbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.manualattendancebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.attendancebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'addstudentbtn
        '
        Me.addstudentbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addstudentbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addstudentbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addstudentbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addstudentbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.addstudentbtn.ForeColor = System.Drawing.Color.White
        Me.addstudentbtn.Location = New System.Drawing.Point(96, 88)
        Me.addstudentbtn.Name = "addstudentbtn"
        Me.addstudentbtn.Size = New System.Drawing.Size(180, 45)
        Me.addstudentbtn.TabIndex = 0
        Me.addstudentbtn.Text = "STUDENT REGISTRATION"
        '
        'addmodelbtn
        '
        Me.addmodelbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.addmodelbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.addmodelbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.addmodelbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.addmodelbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.addmodelbtn.ForeColor = System.Drawing.Color.White
        Me.addmodelbtn.Location = New System.Drawing.Point(460, 88)
        Me.addmodelbtn.Name = "addmodelbtn"
        Me.addmodelbtn.Size = New System.Drawing.Size(180, 45)
        Me.addmodelbtn.TabIndex = 1
        Me.addmodelbtn.Text = "INVENTORY"
        '
        'manualattendancebtn
        '
        Me.manualattendancebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.manualattendancebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.manualattendancebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.manualattendancebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.manualattendancebtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.manualattendancebtn.ForeColor = System.Drawing.Color.White
        Me.manualattendancebtn.Location = New System.Drawing.Point(96, 217)
        Me.manualattendancebtn.Name = "manualattendancebtn"
        Me.manualattendancebtn.Size = New System.Drawing.Size(180, 45)
        Me.manualattendancebtn.TabIndex = 2
        Me.manualattendancebtn.Text = "MANUAL ATTENDANCE"
        '
        'attendancebtn
        '
        Me.attendancebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.attendancebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.attendancebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.attendancebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.attendancebtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.attendancebtn.ForeColor = System.Drawing.Color.White
        Me.attendancebtn.Location = New System.Drawing.Point(460, 217)
        Me.attendancebtn.Name = "attendancebtn"
        Me.attendancebtn.Size = New System.Drawing.Size(180, 45)
        Me.attendancebtn.TabIndex = 3
        Me.attendancebtn.Text = "ATTENDANCE"
        '
        'dashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.attendancebtn)
        Me.Controls.Add(Me.manualattendancebtn)
        Me.Controls.Add(Me.addmodelbtn)
        Me.Controls.Add(Me.addstudentbtn)
        Me.Name = "dashboardForm"
        Me.Text = "dashboardForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents addstudentbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents addmodelbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents manualattendancebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents attendancebtn As Guna.UI2.WinForms.Guna2Button
End Class
