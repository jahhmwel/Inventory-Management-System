<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class inventoryForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inventoryForm))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dginventory = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.remarkscmb = New System.Windows.Forms.ComboBox()
        Me.inventoryprint = New System.Drawing.Printing.PrintDocument()
        Me.inventoryprintpreview = New System.Windows.Forms.PrintPreviewDialog()
        Me.idinventorytxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.modeltxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.serialtxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.propertytxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.propertynotxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.locationtxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.submitbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.updatebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.deletebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.clearbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.printbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.exitbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.searchtxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dginventory, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1483, 12)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(34, 26)
        Me.Guna2ControlBox2.TabIndex = 39
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1523, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(34, 26)
        Me.Guna2ControlBox1.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 395)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 42
        '
        'dginventory
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dginventory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dginventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dginventory.ColumnHeadersHeight = 4
        Me.dginventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dginventory.DefaultCellStyle = DataGridViewCellStyle3
        Me.dginventory.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dginventory.Location = New System.Drawing.Point(499, 106)
        Me.dginventory.Name = "dginventory"
        Me.dginventory.RowHeadersVisible = False
        Me.dginventory.RowHeadersWidth = 51
        Me.dginventory.RowTemplate.Height = 24
        Me.dginventory.Size = New System.Drawing.Size(1027, 641)
        Me.dginventory.TabIndex = 58
        Me.dginventory.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dginventory.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dginventory.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dginventory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dginventory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dginventory.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dginventory.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dginventory.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dginventory.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dginventory.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dginventory.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dginventory.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dginventory.ThemeStyle.HeaderStyle.Height = 4
        Me.dginventory.ThemeStyle.ReadOnly = False
        Me.dginventory.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dginventory.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dginventory.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dginventory.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dginventory.ThemeStyle.RowsStyle.Height = 24
        Me.dginventory.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dginventory.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'remarkscmb
        '
        Me.remarkscmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.remarkscmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.remarkscmb.BackColor = System.Drawing.SystemColors.HighlightText
        Me.remarkscmb.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.remarkscmb.FormattingEnabled = True
        Me.remarkscmb.Items.AddRange(New Object() {"WORKING", "DEFECTIVE"})
        Me.remarkscmb.Location = New System.Drawing.Point(185, 456)
        Me.remarkscmb.Name = "remarkscmb"
        Me.remarkscmb.Size = New System.Drawing.Size(290, 31)
        Me.remarkscmb.TabIndex = 65
        '
        'inventoryprint
        '
        '
        'inventoryprintpreview
        '
        Me.inventoryprintpreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.inventoryprintpreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.inventoryprintpreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.inventoryprintpreview.Enabled = True
        Me.inventoryprintpreview.Icon = CType(resources.GetObject("inventoryprintpreview.Icon"), System.Drawing.Icon)
        Me.inventoryprintpreview.Name = "inventoryprintpreview"
        Me.inventoryprintpreview.Visible = False
        '
        'idinventorytxt
        '
        Me.idinventorytxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.idinventorytxt.DefaultText = ""
        Me.idinventorytxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.idinventorytxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.idinventorytxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.idinventorytxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.idinventorytxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.idinventorytxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.idinventorytxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.idinventorytxt.Location = New System.Drawing.Point(185, 39)
        Me.idinventorytxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.idinventorytxt.Name = "idinventorytxt"
        Me.idinventorytxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.idinventorytxt.PlaceholderText = ""
        Me.idinventorytxt.SelectedText = ""
        Me.idinventorytxt.Size = New System.Drawing.Size(290, 37)
        Me.idinventorytxt.TabIndex = 70
        Me.idinventorytxt.Visible = False
        '
        'modeltxt
        '
        Me.modeltxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.modeltxt.DefaultText = ""
        Me.modeltxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.modeltxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.modeltxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.modeltxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.modeltxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.modeltxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.modeltxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.modeltxt.Location = New System.Drawing.Point(185, 106)
        Me.modeltxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.modeltxt.Name = "modeltxt"
        Me.modeltxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.modeltxt.PlaceholderText = ""
        Me.modeltxt.SelectedText = ""
        Me.modeltxt.Size = New System.Drawing.Size(290, 37)
        Me.modeltxt.TabIndex = 71
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 25)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "MODEL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 25)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "SERIAL"
        '
        'serialtxt
        '
        Me.serialtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.serialtxt.DefaultText = ""
        Me.serialtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.serialtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.serialtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.serialtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.serialtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.serialtxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.serialtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.serialtxt.Location = New System.Drawing.Point(185, 174)
        Me.serialtxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.serialtxt.Name = "serialtxt"
        Me.serialtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.serialtxt.PlaceholderText = ""
        Me.serialtxt.SelectedText = ""
        Me.serialtxt.Size = New System.Drawing.Size(290, 37)
        Me.serialtxt.TabIndex = 74
        '
        'propertytxt
        '
        Me.propertytxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.propertytxt.DefaultText = ""
        Me.propertytxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.propertytxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.propertytxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.propertytxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.propertytxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.propertytxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.propertytxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.propertytxt.Location = New System.Drawing.Point(185, 244)
        Me.propertytxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.propertytxt.Name = "propertytxt"
        Me.propertytxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.propertytxt.PlaceholderText = ""
        Me.propertytxt.SelectedText = ""
        Me.propertytxt.Size = New System.Drawing.Size(290, 37)
        Me.propertytxt.TabIndex = 75
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 25)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "PROPERTY"
        '
        'propertynotxt
        '
        Me.propertynotxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.propertynotxt.DefaultText = ""
        Me.propertynotxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.propertynotxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.propertynotxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.propertynotxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.propertynotxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.propertynotxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.propertynotxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.propertynotxt.Location = New System.Drawing.Point(185, 312)
        Me.propertynotxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.propertynotxt.Name = "propertynotxt"
        Me.propertynotxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.propertynotxt.PlaceholderText = ""
        Me.propertynotxt.SelectedText = ""
        Me.propertynotxt.Size = New System.Drawing.Size(290, 37)
        Me.propertynotxt.TabIndex = 77
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 324)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 25)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "PROPERTY NO."
        '
        'locationtxt
        '
        Me.locationtxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.locationtxt.DefaultText = ""
        Me.locationtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.locationtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.locationtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.locationtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.locationtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.locationtxt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.locationtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.locationtxt.Location = New System.Drawing.Point(185, 383)
        Me.locationtxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.locationtxt.Name = "locationtxt"
        Me.locationtxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.locationtxt.PlaceholderText = ""
        Me.locationtxt.SelectedText = ""
        Me.locationtxt.Size = New System.Drawing.Size(290, 37)
        Me.locationtxt.TabIndex = 79
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 395)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 25)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "LOCATION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 460)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 25)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "REMARKS"
        '
        'submitbtn
        '
        Me.submitbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.submitbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.submitbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.submitbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.submitbtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitbtn.ForeColor = System.Drawing.Color.White
        Me.submitbtn.Location = New System.Drawing.Point(345, 553)
        Me.submitbtn.Name = "submitbtn"
        Me.submitbtn.Size = New System.Drawing.Size(130, 45)
        Me.submitbtn.TabIndex = 82
        Me.submitbtn.Text = "SUBMIT"
        '
        'updatebtn
        '
        Me.updatebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.updatebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.updatebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.updatebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.updatebtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatebtn.ForeColor = System.Drawing.Color.White
        Me.updatebtn.Location = New System.Drawing.Point(185, 553)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(130, 45)
        Me.updatebtn.TabIndex = 83
        Me.updatebtn.Text = "UPDATE"
        '
        'deletebtn
        '
        Me.deletebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.deletebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.deletebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.deletebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.deletebtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletebtn.ForeColor = System.Drawing.Color.White
        Me.deletebtn.Location = New System.Drawing.Point(25, 553)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(130, 45)
        Me.deletebtn.TabIndex = 84
        Me.deletebtn.Text = "DELETE"
        '
        'clearbtn
        '
        Me.clearbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.clearbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.clearbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.clearbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.clearbtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearbtn.ForeColor = System.Drawing.Color.White
        Me.clearbtn.Location = New System.Drawing.Point(345, 623)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(130, 45)
        Me.clearbtn.TabIndex = 85
        Me.clearbtn.Text = "CLEAR"
        '
        'printbtn
        '
        Me.printbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.printbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.printbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.printbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.printbtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printbtn.ForeColor = System.Drawing.Color.White
        Me.printbtn.Location = New System.Drawing.Point(185, 623)
        Me.printbtn.Name = "printbtn"
        Me.printbtn.Size = New System.Drawing.Size(130, 45)
        Me.printbtn.TabIndex = 86
        Me.printbtn.Text = "PRINT"
        '
        'exitbtn
        '
        Me.exitbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.exitbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.exitbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.exitbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.exitbtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitbtn.ForeColor = System.Drawing.Color.White
        Me.exitbtn.Location = New System.Drawing.Point(25, 623)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(130, 45)
        Me.exitbtn.TabIndex = 87
        Me.exitbtn.Text = "EXIT"
        '
        'searchtxt
        '
        Me.searchtxt.Location = New System.Drawing.Point(1172, 61)
        Me.searchtxt.Multiline = True
        Me.searchtxt.Name = "searchtxt"
        Me.searchtxt.Size = New System.Drawing.Size(274, 37)
        Me.searchtxt.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1071, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 25)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "SEARCH"
        '
        'inventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1569, 769)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.exitbtn)
        Me.Controls.Add(Me.printbtn)
        Me.Controls.Add(Me.clearbtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.submitbtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.locationtxt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.propertynotxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.propertytxt)
        Me.Controls.Add(Me.serialtxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.modeltxt)
        Me.Controls.Add(Me.idinventorytxt)
        Me.Controls.Add(Me.remarkscmb)
        Me.Controls.Add(Me.dginventory)
        Me.Controls.Add(Me.searchtxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "inventoryForm"
        Me.Text = "inventoryForm"
        CType(Me.dginventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dginventory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents remarkscmb As ComboBox
    Friend WithEvents inventoryprint As Printing.PrintDocument
    Friend WithEvents inventoryprintpreview As PrintPreviewDialog
    Friend WithEvents idinventorytxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents modeltxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents locationtxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents propertynotxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents propertytxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents serialtxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents submitbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents updatebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents deletebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents clearbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents printbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents exitbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents searchtxt As TextBox
    Friend WithEvents Label5 As Label
End Class
