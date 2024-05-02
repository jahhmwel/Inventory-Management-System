Imports System.Drawing.Printing
Imports System.Reflection
Imports System.Security.Authentication.ExtendedProtection
Imports MySql.Data.MySqlClient

Public Class inventoryForm
    Dim dbDataSet As New DataTable
    Dim bSource As New BindingSource

    Private Sub submitbtn_Click(sender As Object, e As EventArgs) Handles submitbtn.Click
        Try
            Module1.Connect_to_DB()
            If String.IsNullOrEmpty(modeltxt.Text) OrElse
            String.IsNullOrEmpty(serialtxt.Text) OrElse
            String.IsNullOrEmpty(propertytxt.Text) OrElse
            String.IsNullOrEmpty(propertynotxt.Text) OrElse
            String.IsNullOrEmpty(locationcmb.Text) OrElse
            String.IsNullOrEmpty(remarkscmb.Text) Then

                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If CheckDuplicateData(modeltxt.Text, serialtxt.Text, propertytxt.Text, propertynotxt.Text, locationcmb.Text, remarkscmb.Text) Then
                MessageBox.Show("Data already exists in the database. Duplicate entry not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim sql As String = "INSERT INTO inventory (model, serial, property, propertyno, location, remarks) VALUES (@model, @serial, @property, @propertyno, @location, @remarks)"
            Using mycmd As New MySqlCommand(sql, Module1.myconn)
                mycmd.Parameters.AddWithValue("@model", modeltxt.Text)
                mycmd.Parameters.AddWithValue("@serial", serialtxt.Text)
                mycmd.Parameters.AddWithValue("@property", propertytxt.Text)
                mycmd.Parameters.AddWithValue("@propertyno", propertynotxt.Text)
                mycmd.Parameters.AddWithValue("@location", locationcmb.Text)
                mycmd.Parameters.AddWithValue("@remarks", remarkscmb.Text)

                mycmd.ExecuteNonQuery()
                MessageBox.Show("Successfully Submitted!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Clear_Boxes()

                LoadDataGridView()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Module1.Disconnect_to_DB()
        End Try
    End Sub

    Private Function CheckDuplicateData(model As String, serial As String, prop As String, propertyno As String, loc As String, remarks As String) As Boolean
        Dim isDuplicate As Boolean = False
        Dim query As String = "SELECT COUNT(*) FROM inventory WHERE model = @model AND serial = @serial AND property = @property AND propertyno = @propertyno AND location = @location AND remarks = @remarks"
        Using connection As New MySqlConnection(Module1.myConnectionString)
            connection.Open()
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@model", model)
                cmd.Parameters.AddWithValue("@serial", serial)
                cmd.Parameters.AddWithValue("@property", prop)
                cmd.Parameters.AddWithValue("@propertyno", propertyno)
                cmd.Parameters.AddWithValue("@location", loc)
                cmd.Parameters.AddWithValue("@remarks", remarks)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    isDuplicate = True
                End If
            End Using
        End Using
        Return isDuplicate
    End Function

    Private Sub Clear_Boxes()
        modeltxt.Text = ""
        serialtxt.Text = ""
        propertytxt.Text = ""
        propertynotxt.Text = ""
        locationcmb.Text = ""
        remarkscmb.Text = ""
    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        Try
            If dginventory.SelectedRows.Count > 0 Then
                Dim id As Integer = Convert.ToInt32(dginventory.SelectedRows(0).Cells("idinventory").Value)

                Module1.Connect_to_DB()
                Dim mycmd As New MySqlCommand
                Dim strSQL As String = "UPDATE inventory SET model = @Model, serial = @Serial, property = @Property, propertyno = @Propertyno, location = @Location, remarks = @Remarks WHERE idinventory = @idinventory"

                mycmd.CommandText = strSQL
                mycmd.Connection = Module1.myconn
                mycmd.Parameters.AddWithValue("@idinventory", id)

                ' Check if any textbox is empty, and skip updating if any are empty
                If String.IsNullOrEmpty(modeltxt.Text) OrElse
                String.IsNullOrEmpty(serialtxt.Text) OrElse
                String.IsNullOrEmpty(propertytxt.Text) OrElse
                String.IsNullOrEmpty(propertynotxt.Text) OrElse
                String.IsNullOrEmpty(locationcmb.Text) OrElse
                String.IsNullOrEmpty(remarkscmb.Text) Then
                    MessageBox.Show("Please select record to be updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                mycmd.Parameters.AddWithValue("@Model", modeltxt.Text)
                mycmd.Parameters.AddWithValue("@Serial", serialtxt.Text)
                mycmd.Parameters.AddWithValue("@Property", propertytxt.Text)
                mycmd.Parameters.AddWithValue("@Propertyno", propertynotxt.Text)
                mycmd.Parameters.AddWithValue("@Location", locationcmb.Text)
                mycmd.Parameters.AddWithValue("@Remarks", remarkscmb.Text)

                mycmd.ExecuteNonQuery()
                MsgBox("Successfully Updated")
                Clear_Boxes()
                LoadDataGridView()
            End If
        Catch ex As MySqlException
            MsgBox(ex.Number & " " & ex.Message)
        Finally
            Module1.Disconnect_to_DB()
        End Try
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        Try
            Module1.Connect_to_DB()

            ' Check if modeltxt is empty, and skip deletion if it is empty
            If String.IsNullOrEmpty(modeltxt.Text) Then
                MessageBox.Show("Please select a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim Query As String = "DELETE FROM inventory WHERE model = @Model"
            Dim answer As MsgBoxResult

            answer = MsgBox("Are you sure you want to delete this record", MsgBoxStyle.YesNo)
            If answer = MsgBoxResult.Yes Then
                Using Command As New MySqlCommand(Query, Module1.myconn)
                    Command.Parameters.AddWithValue("@Model", modeltxt.Text)

                    Dim rowsAffected As Integer = Command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Successfully Deleted")
                        Dim rowToDelete As DataRow = dbDataSet.Rows.Cast(Of DataRow)().FirstOrDefault(Function(row) row("MODEL").ToString() = modeltxt.Text)
                        If rowToDelete IsNot Nothing Then
                            dbDataSet.Rows.Remove(rowToDelete)
                        End If
                        dginventory.DataSource = dbDataSet
                    Else
                        MessageBox.Show("No record found.")
                    End If
                    Clear_Boxes()

                End Using
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            Module1.Disconnect_to_DB()
        End Try
    End Sub

    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        Clear_Boxes()
    End Sub

    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Me.Close()
        dashboardForm.Show()
    End Sub

    Private Sub dginventory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dginventory.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dginventory.Rows(e.RowIndex)
            modeltxt.Text = row.Cells("model").Value.ToString
            serialtxt.Text = row.Cells("serial").Value.ToString
            propertytxt.Text = row.Cells("property").Value.ToString
            propertynotxt.Text = row.Cells("propertyno").Value.ToString
            locationcmb.Text = row.Cells("location").Value.ToString
            remarkscmb.Text = row.Cells("remarks").Value.ToString
        End If
    End Sub

    Private Sub inventoryForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        LoadDataGridView()
    End Sub

    Private Sub LoadDataGridView()
        Try
            Module1.Connect_to_DB()
            Dim Query As String = "SELECT * FROM inventory"

            Using Command As New MySqlCommand(Query, Module1.myconn)
                Using myreader As MySqlDataReader = Command.ExecuteReader()
                    dbDataSet.Load(myreader)
                End Using
            End Using

            dginventory.DataSource = dbDataSet
            dginventory.ReadOnly = True
            dginventory.ColumnHeadersHeight = 30

            Dim columnTitles() As String = {"ID", "Model", "Serial Number", "Property", "Property Number", "Location", "Remarks"}
            For i As Integer = 0 To dginventory.Columns.Count - 1
                If i < columnTitles.Length Then
                    dginventory.Columns(i).HeaderText = columnTitles(i)
                End If
            Next

            ' Set the font size to 12
            dginventory.Font = New Font(dginventory.Font.FontFamily, 9.5)

            ' Set the height of each cell to 20
            For Each row As DataGridViewRow In dginventory.Rows
                If row.IsNewRow Then Continue For ' Skip the new row
                row.Height = 40
            Next

            ' Adjust column widths
            For Each col As DataGridViewColumn In dginventory.Columns
                Dim maxTextLength As Integer = 0
                For Each row As DataGridViewRow In dginventory.Rows
                    If Not row.IsNewRow AndAlso row.Cells(col.Index).Value IsNot Nothing Then
                        Dim cellTextLength As Integer = row.Cells(col.Index).Value.ToString().Length
                        If cellTextLength > maxTextLength Then
                            maxTextLength = cellTextLength
                        End If
                    End If
                Next
                Dim minWidth As Integer = TextRenderer.MeasureText(col.HeaderText, dginventory.Font).Width + 50
                col.MinimumWidth = minWidth
                col.Width = Math.Max(minWidth, TextRenderer.MeasureText(New String("X", maxTextLength), dginventory.Font).Width + 50)
            Next

            dginventory.AllowUserToAddRows = False
            dginventory.AllowUserToResizeRows = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Module1.Disconnect_to_DB()
        End Try
    End Sub

    Private Sub inventoryForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim answer As MsgBoxResult
        answer = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo)
        If answer = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub


    Private Sub printbtn_Click(sender As Object, e As EventArgs) Handles printbtn.Click
        Try
            If dginventory.Rows.Count = 0 Then
                MessageBox.Show("There are no records to print.", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' Reset mRow to 0 before showing the print preview dialog
            mRow = 0

            inventoryprintpreview.Document = inventoryprint
            inventoryprintpreview.WindowState = FormWindowState.Maximized
            inventoryprintpreview.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Error occurred while preparing the print preview: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private mRow As Integer = 0
    Private newPage As Boolean

    Private Sub inventoryprint_PrintPage(sender As Object, e As PrintPageEventArgs) Handles inventoryprint.PrintPage
        Dim titleFont As New Font("Arial", 20, FontStyle.Bold)
        Dim contentFont As New Font("Arial", 12)
        Dim headerBrush As New SolidBrush(Color.Gray)
        Dim contentBrush As New SolidBrush(Color.Black)
        Dim startX As Integer = 35
        Dim startY As Integer = 100
        Dim cellHeight As Integer = 40
        Dim cellPadding As Integer = 1
        Dim cellWidthMultiplier As Single = 1  ' Adjust this multiplier for wider cells

        ' Print title
        Dim title As String = "Inventory List"
        Dim titleFormat As New StringFormat With {.Alignment = StringAlignment.Center}
        Dim titleRect As New Rectangle(0, 50, e.PageBounds.Width, 60)
        e.Graphics.DrawString(title, titleFont, Brushes.Black, titleRect, titleFormat)

        ' Print column headers
        Dim x As Integer = startX
        For Each column As DataGridViewColumn In dginventory.Columns
            If column.Visible Then
                ' Calculate adjusted width for the cell with multiplier
                Dim adjustedCellWidth As Single = column.Width * cellWidthMultiplier - 2 * cellPadding

                Dim headerRect As New Rectangle(x, startY, column.Width * cellWidthMultiplier, cellHeight)
                e.Graphics.FillRectangle(headerBrush, headerRect)
                e.Graphics.DrawRectangle(Pens.Black, headerRect)

                ' Create a StringFormat for center alignment
                Dim headerFormat As New StringFormat()
                headerFormat.Alignment = StringAlignment.Center
                headerFormat.LineAlignment = StringAlignment.Center

                ' Draw header text with center alignment
                e.Graphics.DrawString(column.HeaderText, contentFont, Brushes.Black, New RectangleF(x + cellPadding, startY + cellPadding, adjustedCellWidth, cellHeight - 2 * cellPadding), headerFormat)
                x += column.Width * cellWidthMultiplier
            End If
        Next

        ' Print data rows
        startY += cellHeight
        Dim cellRect As Rectangle
        Do While mRow < dginventory.Rows.Count
            x = startX
            Dim row As DataGridViewRow = dginventory.Rows(mRow)
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    ' Calculate adjusted width for the cell with multiplier
                    Dim adjustedCellWidth As Single = cell.OwningColumn.Width * cellWidthMultiplier - 2 * cellPadding

                    cellRect = New Rectangle(x, startY, cell.OwningColumn.Width * cellWidthMultiplier, cellHeight)
                    e.Graphics.DrawRectangle(Pens.Black, cellRect)

                    ' Create a StringFormat for center alignment
                    Dim cellFormat As New StringFormat()
                    cellFormat.Alignment = StringAlignment.Center
                    cellFormat.LineAlignment = StringAlignment.Center

                    ' Draw cell text with center alignment
                    e.Graphics.DrawString(cell.FormattedValue.ToString(), contentFont, contentBrush, New RectangleF(x + cellPadding, startY + cellPadding, adjustedCellWidth, cellHeight - 2 * cellPadding), cellFormat)
                    x += cell.OwningColumn.Width * cellWidthMultiplier
                End If
            Next
            startY += cellHeight
            mRow += 1

            ' Check if new page needed
            If startY + cellHeight > e.PageBounds.Height - 100 Then
                newPage = True
                Exit Do
            End If
        Loop
        e.HasMorePages = newPage
        newPage = False
    End Sub

    Private Sub searchtext_TextChanged(sender As Object, e As EventArgs) Handles searchtext.TextChanged
        PerformSearch(searchtext.Text)
    End Sub

    Private Sub PerformSearch(searchText As String)
        Try
            Module1.Connect_to_DB()
            Dim Query As String = "SELECT * FROM inventory WHERE model LIKE @searchText OR serial LIKE @searchText OR location LIKE @searchText OR property LIKE @searchText OR propertyno LIKE @searchText OR remarks LIKE @searchText"

            Using Command As New MySqlCommand(Query, Module1.myconn)
                Command.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
                Using myreader As MySqlDataReader = Command.ExecuteReader()
                    Dim dtSearchResult As New DataTable
                    dtSearchResult.Load(myreader)
                    dginventory.DataSource = dtSearchResult
                    dginventory.Font = New Font(dginventory.Font.FontFamily, 9.5)
                    For Each row As DataGridViewRow In dginventory.Rows
                        If row.IsNewRow Then Continue For
                        row.Height = 40
                    Next
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Module1.Disconnect_to_DB()
        End Try
    End Sub
End Class