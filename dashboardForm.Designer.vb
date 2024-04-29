<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboardForm
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.addstudentbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.addmodelbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.manualattendancebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.attendancebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Guna2CircleProgressBar1 = New Guna.UI2.WinForms.Guna2CircleProgressBar()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.addstudentbtn.Location = New System.Drawing.Point(28, 58)
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
        Me.addmodelbtn.Location = New System.Drawing.Point(28, 125)
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
        Me.manualattendancebtn.Location = New System.Drawing.Point(28, 251)
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
        Me.attendancebtn.Location = New System.Drawing.Point(28, 185)
        Me.attendancebtn.Name = "attendancebtn"
        Me.attendancebtn.Size = New System.Drawing.Size(180, 45)
        Me.attendancebtn.TabIndex = 3
        Me.attendancebtn.Text = "ATTENDANCE"
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
        Me.Guna2ControlBox2.TabIndex = 55
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
        Me.Guna2ControlBox1.TabIndex = 54
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(283, 80)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(436, 300)
        Me.Chart1.TabIndex = 56
        Me.Chart1.Text = "Chart1"
        '
        'Guna2CircleProgressBar1
        '
        Me.Guna2CircleProgressBar1.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2CircleProgressBar1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2CircleProgressBar1.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleProgressBar1.Location = New System.Drawing.Point(639, 443)
        Me.Guna2CircleProgressBar1.Minimum = 0
        Me.Guna2CircleProgressBar1.Name = "Guna2CircleProgressBar1"
        Me.Guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleProgressBar1.Size = New System.Drawing.Size(130, 130)
        Me.Guna2CircleProgressBar1.TabIndex = 57
        Me.Guna2CircleProgressBar1.Text = "Guna2CircleProgressBar1"
        '
        'dashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Guna2CircleProgressBar1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.attendancebtn)
        Me.Controls.Add(Me.manualattendancebtn)
        Me.Controls.Add(Me.addmodelbtn)
        Me.Controls.Add(Me.addstudentbtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "dashboardForm"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents addstudentbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents addmodelbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents manualattendancebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents attendancebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Guna2CircleProgressBar1 As Guna.UI2.WinForms.Guna2CircleProgressBar
End Class
