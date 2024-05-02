<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addStudentForm
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addStudentForm))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.studentnotxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.studentnametxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.submitbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.updatebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.deletebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.clearbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.searchtxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dgstudents = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.cmbcollege = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbcourse = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.exitbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        CType(Me.dgstudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1490, 12)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(34, 26)
        Me.Guna2ControlBox2.TabIndex = 43
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1530, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(34, 26)
        Me.Guna2ControlBox1.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(73, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 23)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "STUDENT NO."
        '
        'studentnotxt
        '
        Me.studentnotxt.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.studentnotxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.studentnotxt.DefaultText = ""
        Me.studentnotxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.studentnotxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.studentnotxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.studentnotxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.studentnotxt.FillColor = System.Drawing.Color.WhiteSmoke
        Me.studentnotxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.studentnotxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.studentnotxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.studentnotxt.Location = New System.Drawing.Point(77, 70)
        Me.studentnotxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.studentnotxt.Name = "studentnotxt"
        Me.studentnotxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.studentnotxt.PlaceholderText = ""
        Me.studentnotxt.SelectedText = ""
        Me.studentnotxt.Size = New System.Drawing.Size(352, 36)
        Me.studentnotxt.TabIndex = 65
        '
        'studentnametxt
        '
        Me.studentnametxt.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.studentnametxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.studentnametxt.DefaultText = ""
        Me.studentnametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.studentnametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.studentnametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.studentnametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.studentnametxt.FillColor = System.Drawing.Color.WhiteSmoke
        Me.studentnametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.studentnametxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.studentnametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.studentnametxt.Location = New System.Drawing.Point(77, 164)
        Me.studentnametxt.Margin = New System.Windows.Forms.Padding(6, 9, 6, 9)
        Me.studentnametxt.Name = "studentnametxt"
        Me.studentnametxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.studentnametxt.PlaceholderText = ""
        Me.studentnametxt.SelectedText = ""
        Me.studentnametxt.Size = New System.Drawing.Size(352, 36)
        Me.studentnametxt.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(73, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 23)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "STUDENT NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(73, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 23)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "COLLEGE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(73, 399)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 23)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "COURSE"
        '
        'submitbtn
        '
        Me.submitbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.submitbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.submitbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.submitbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.submitbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.submitbtn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold)
        Me.submitbtn.ForeColor = System.Drawing.Color.White
        Me.submitbtn.Location = New System.Drawing.Point(299, 435)
        Me.submitbtn.Name = "submitbtn"
        Me.submitbtn.Size = New System.Drawing.Size(130, 45)
        Me.submitbtn.TabIndex = 83
        Me.submitbtn.Text = "ADD"
        '
        'updatebtn
        '
        Me.updatebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.updatebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.updatebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.updatebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.updatebtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.updatebtn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold)
        Me.updatebtn.ForeColor = System.Drawing.Color.White
        Me.updatebtn.Location = New System.Drawing.Point(77, 435)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(130, 45)
        Me.updatebtn.TabIndex = 84
        Me.updatebtn.Text = "UPDATE"
        '
        'deletebtn
        '
        Me.deletebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.deletebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.deletebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.deletebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.deletebtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.deletebtn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold)
        Me.deletebtn.ForeColor = System.Drawing.Color.White
        Me.deletebtn.Location = New System.Drawing.Point(77, 509)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(130, 45)
        Me.deletebtn.TabIndex = 85
        Me.deletebtn.Text = "DELETE"
        '
        'clearbtn
        '
        Me.clearbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.clearbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.clearbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.clearbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.clearbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.clearbtn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold)
        Me.clearbtn.ForeColor = System.Drawing.Color.White
        Me.clearbtn.Location = New System.Drawing.Point(299, 519)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(130, 45)
        Me.clearbtn.TabIndex = 86
        Me.clearbtn.Text = "CLEAR"
        '
        'searchtxt
        '
        Me.searchtxt.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.searchtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchtxt.DefaultText = ""
        Me.searchtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.searchtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.searchtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.searchtxt.FillColor = System.Drawing.Color.WhiteSmoke
        Me.searchtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchtxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.searchtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.searchtxt.IconLeft = CType(resources.GetObject("searchtxt.IconLeft"), System.Drawing.Image)
        Me.searchtxt.Location = New System.Drawing.Point(778, 10)
        Me.searchtxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.searchtxt.Name = "searchtxt"
        Me.searchtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchtxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.searchtxt.PlaceholderText = "SEARCH"
        Me.searchtxt.SelectedText = ""
        Me.searchtxt.Size = New System.Drawing.Size(290, 38)
        Me.searchtxt.TabIndex = 87
        '
        'dgstudents
        '
        Me.dgstudents.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgstudents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgstudents.BackgroundColor = System.Drawing.Color.Silver
        Me.dgstudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgstudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgstudents.ColumnHeadersHeight = 4
        Me.dgstudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgstudents.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgstudents.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgstudents.Location = New System.Drawing.Point(494, 151)
        Me.dgstudents.Name = "dgstudents"
        Me.dgstudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgstudents.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgstudents.RowHeadersVisible = False
        Me.dgstudents.RowHeadersWidth = 51
        Me.dgstudents.RowTemplate.Height = 24
        Me.dgstudents.Size = New System.Drawing.Size(1054, 616)
        Me.dgstudents.TabIndex = 88
        Me.dgstudents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgstudents.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgstudents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.dgstudents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgstudents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgstudents.ThemeStyle.BackColor = System.Drawing.Color.Silver
        Me.dgstudents.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgstudents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgstudents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgstudents.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgstudents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgstudents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgstudents.ThemeStyle.HeaderStyle.Height = 4
        Me.dgstudents.ThemeStyle.ReadOnly = False
        Me.dgstudents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgstudents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgstudents.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgstudents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgstudents.ThemeStyle.RowsStyle.Height = 24
        Me.dgstudents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgstudents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'cmbcollege
        '
        Me.cmbcollege.BackColor = System.Drawing.Color.Transparent
        Me.cmbcollege.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbcollege.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbcollege.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcollege.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbcollege.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbcollege.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbcollege.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbcollege.ItemHeight = 25
        Me.cmbcollege.Location = New System.Drawing.Point(77, 332)
        Me.cmbcollege.Name = "cmbcollege"
        Me.cmbcollege.Size = New System.Drawing.Size(352, 31)
        Me.cmbcollege.TabIndex = 89
        '
        'cmbcourse
        '
        Me.cmbcourse.BackColor = System.Drawing.Color.Transparent
        Me.cmbcourse.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmbcourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbcourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbcourse.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbcourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbcourse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cmbcourse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbcourse.ItemHeight = 25
        Me.cmbcourse.Location = New System.Drawing.Point(77, 425)
        Me.cmbcourse.Name = "cmbcourse"
        Me.cmbcourse.Size = New System.Drawing.Size(352, 31)
        Me.cmbcourse.TabIndex = 90
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(287, 38)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Student Registration"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.exitbtn)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.clearbtn)
        Me.Guna2Panel1.Controls.Add(Me.studentnametxt)
        Me.Guna2Panel1.Controls.Add(Me.deletebtn)
        Me.Guna2Panel1.Controls.Add(Me.studentnotxt)
        Me.Guna2Panel1.Controls.Add(Me.updatebtn)
        Me.Guna2Panel1.Controls.Add(Me.submitbtn)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 79)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(474, 722)
        Me.Guna2Panel1.TabIndex = 92
        '
        'exitbtn
        '
        Me.exitbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.exitbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.exitbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.exitbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.exitbtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.exitbtn.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold)
        Me.exitbtn.ForeColor = System.Drawing.Color.White
        Me.exitbtn.Location = New System.Drawing.Point(189, 599)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(130, 45)
        Me.exitbtn.TabIndex = 94
        Me.exitbtn.Text = "MENU"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.AutoRoundedCorners = True
        Me.Guna2Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.RosyBrown
        Me.Guna2Panel2.BorderRadius = 342
        Me.Guna2Panel2.Controls.Add(Me.searchtxt)
        Me.Guna2Panel2.Location = New System.Drawing.Point(480, 96)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1084, 686)
        Me.Guna2Panel2.TabIndex = 93
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Guna2Panel3.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Guna2Panel3.Controls.Add(Me.Label4)
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, -4)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(1586, 94)
        Me.Guna2Panel3.TabIndex = 0
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(7, 14)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(67, 77)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox1.TabIndex = 92
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'addStudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1584, 794)
        Me.Controls.Add(Me.cmbcourse)
        Me.Controls.Add(Me.cmbcollege)
        Me.Controls.Add(Me.dgstudents)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addStudentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addStudentForm"
        CType(Me.dgstudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents studentnametxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents studentnotxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents submitbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents dgstudents As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents searchtxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents clearbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents deletebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents updatebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cmbcollege As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbcourse As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents exitbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
End Class
