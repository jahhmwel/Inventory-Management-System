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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inventoryForm))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.locationtxt = New System.Windows.Forms.TextBox()
        Me.propertytxt = New System.Windows.Forms.TextBox()
        Me.serialtxt = New System.Windows.Forms.TextBox()
        Me.modeltxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.submitbtn = New System.Windows.Forms.Button()
        Me.exitbtn = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.searchtxt = New System.Windows.Forms.TextBox()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.dginventory = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.idinventorytxt = New System.Windows.Forms.TextBox()
        Me.propertynotxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.remarkscmb = New System.Windows.Forms.ComboBox()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.printbtn = New System.Windows.Forms.Button()
        Me.inventoryprint = New System.Drawing.Printing.PrintDocument()
        Me.inventoryprintpreview = New System.Windows.Forms.PrintPreviewDialog()
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
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1023, 12)
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
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1063, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(34, 26)
        Me.Guna2ControlBox1.TabIndex = 38
        '
        'locationtxt
        '
        Me.locationtxt.Location = New System.Drawing.Point(193, 233)
        Me.locationtxt.Name = "locationtxt"
        Me.locationtxt.Size = New System.Drawing.Size(100, 22)
        Me.locationtxt.TabIndex = 48
        '
        'propertytxt
        '
        Me.propertytxt.Location = New System.Drawing.Point(193, 164)
        Me.propertytxt.Name = "propertytxt"
        Me.propertytxt.Size = New System.Drawing.Size(100, 22)
        Me.propertytxt.TabIndex = 47
        '
        'serialtxt
        '
        Me.serialtxt.Location = New System.Drawing.Point(193, 123)
        Me.serialtxt.Name = "serialtxt"
        Me.serialtxt.Size = New System.Drawing.Size(100, 22)
        Me.serialtxt.TabIndex = 46
        '
        'modeltxt
        '
        Me.modeltxt.Location = New System.Drawing.Point(193, 79)
        Me.modeltxt.Name = "modeltxt"
        Me.modeltxt.Size = New System.Drawing.Size(100, 22)
        Me.modeltxt.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "LOCATION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "PROPERTY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "SERIAL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "MODEL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "REMARKS"
        '
        'submitbtn
        '
        Me.submitbtn.Location = New System.Drawing.Point(290, 336)
        Me.submitbtn.Name = "submitbtn"
        Me.submitbtn.Size = New System.Drawing.Size(75, 36)
        Me.submitbtn.TabIndex = 52
        Me.submitbtn.Text = "SUBMIT"
        Me.submitbtn.UseVisualStyleBackColor = True
        '
        'exitbtn
        '
        Me.exitbtn.Location = New System.Drawing.Point(47, 336)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(75, 36)
        Me.exitbtn.TabIndex = 53
        Me.exitbtn.Text = "EXIT"
        Me.exitbtn.UseVisualStyleBackColor = True
        '
        'updatebtn
        '
        Me.updatebtn.Location = New System.Drawing.Point(209, 336)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(75, 36)
        Me.updatebtn.TabIndex = 54
        Me.updatebtn.Text = "UPDATE"
        Me.updatebtn.UseVisualStyleBackColor = True
        '
        'searchtxt
        '
        Me.searchtxt.Location = New System.Drawing.Point(805, 67)
        Me.searchtxt.Name = "searchtxt"
        Me.searchtxt.Size = New System.Drawing.Size(274, 22)
        Me.searchtxt.TabIndex = 55
        '
        'deletebtn
        '
        Me.deletebtn.Location = New System.Drawing.Point(128, 336)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(75, 36)
        Me.deletebtn.TabIndex = 57
        Me.deletebtn.Text = "DELETE"
        Me.deletebtn.UseVisualStyleBackColor = True
        '
        'dginventory
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.dginventory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dginventory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dginventory.ColumnHeadersHeight = 4
        Me.dginventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dginventory.DefaultCellStyle = DataGridViewCellStyle9
        Me.dginventory.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dginventory.Location = New System.Drawing.Point(480, 106)
        Me.dginventory.Name = "dginventory"
        Me.dginventory.RowHeadersVisible = False
        Me.dginventory.RowHeadersWidth = 51
        Me.dginventory.RowTemplate.Height = 24
        Me.dginventory.Size = New System.Drawing.Size(599, 522)
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(723, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "SEARCH:"
        '
        'idinventorytxt
        '
        Me.idinventorytxt.Location = New System.Drawing.Point(193, 41)
        Me.idinventorytxt.Name = "idinventorytxt"
        Me.idinventorytxt.Size = New System.Drawing.Size(100, 22)
        Me.idinventorytxt.TabIndex = 61
        Me.idinventorytxt.Visible = False
        '
        'propertynotxt
        '
        Me.propertynotxt.Location = New System.Drawing.Point(193, 202)
        Me.propertynotxt.Name = "propertynotxt"
        Me.propertynotxt.Size = New System.Drawing.Size(100, 22)
        Me.propertynotxt.TabIndex = 63
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(62, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 16)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "PROPERTY NO."
        '
        'remarkscmb
        '
        Me.remarkscmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.remarkscmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.remarkscmb.FormattingEnabled = True
        Me.remarkscmb.Items.AddRange(New Object() {"WORKING", "DEFECTIVE"})
        Me.remarkscmb.Location = New System.Drawing.Point(193, 270)
        Me.remarkscmb.Name = "remarkscmb"
        Me.remarkscmb.Size = New System.Drawing.Size(100, 24)
        Me.remarkscmb.TabIndex = 65
        '
        'clearbtn
        '
        Me.clearbtn.Location = New System.Drawing.Point(47, 390)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(75, 36)
        Me.clearbtn.TabIndex = 66
        Me.clearbtn.Text = "CLEAR"
        Me.clearbtn.UseVisualStyleBackColor = True
        '
        'printbtn
        '
        Me.printbtn.Location = New System.Drawing.Point(128, 390)
        Me.printbtn.Name = "printbtn"
        Me.printbtn.Size = New System.Drawing.Size(75, 36)
        Me.printbtn.TabIndex = 67
        Me.printbtn.Text = "PRINT"
        Me.printbtn.UseVisualStyleBackColor = True
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
        'inventoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 654)
        Me.Controls.Add(Me.printbtn)
        Me.Controls.Add(Me.clearbtn)
        Me.Controls.Add(Me.remarkscmb)
        Me.Controls.Add(Me.propertynotxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.idinventorytxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dginventory)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.searchtxt)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.exitbtn)
        Me.Controls.Add(Me.submitbtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.locationtxt)
        Me.Controls.Add(Me.propertytxt)
        Me.Controls.Add(Me.serialtxt)
        Me.Controls.Add(Me.modeltxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents locationtxt As TextBox
    Friend WithEvents propertytxt As TextBox
    Friend WithEvents serialtxt As TextBox
    Friend WithEvents modeltxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents submitbtn As Button
    Friend WithEvents exitbtn As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents searchtxt As TextBox
    Friend WithEvents deletebtn As Button
    Friend WithEvents dginventory As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents idinventorytxt As TextBox
    Friend WithEvents propertynotxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents remarkscmb As ComboBox
    Friend WithEvents clearbtn As Button
    Friend WithEvents printbtn As Button
    Friend WithEvents inventoryprint As Printing.PrintDocument
    Friend WithEvents inventoryprintpreview As PrintPreviewDialog
End Class
