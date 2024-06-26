﻿Imports System.IO
Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class dtrForm
    Private Sub DTR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoComboBox()
    End Sub

    Private Sub LoadDataIntoComboBox()
        Try
            Module1.Connect_to_DB()
            Dim query As String = "SELECT student_name FROM students"

            Using command As New MySqlCommand(query, Module1.myconn)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    namecmb.Items.Clear()
                    While reader.Read()
                        namecmb.Items.Add(reader("student_name").ToString())
                    End While
                End Using
            End Using

        Catch ex As MySqlException
            MsgBox("Error: " & ex.Message)
        Finally
            Module1.Disconnect_to_DB()
        End Try
    End Sub

    Private Sub namecmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles namecmb.SelectedIndexChanged
        dgdtr.DataSource = Nothing

        Try
            Module1.Connect_to_DB()

            If Module1.myconn IsNot Nothing AndAlso Module1.myconn.State = ConnectionState.Open Then
                Dim selectedName As String = namecmb.SelectedItem?.ToString()

                If Not String.IsNullOrEmpty(selectedName) Then
                    Dim selectedStudentId As Integer

                    ' Get the student ID based on the selected name
                    Using command As New MySqlCommand("SELECT id FROM students WHERE student_name = @student_name", Module1.myconn)
                        command.Parameters.AddWithValue("@student_name", selectedName)
                        selectedStudentId = Convert.ToInt32(command.ExecuteScalar())
                    End Using

                    ' Fetch attendance data for the selected student
                    Dim query As String = "SELECT date_attended, time_in, time_out, total_time FROM attendance WHERE student_id = @student_id"

                    Using command As New MySqlCommand(query, Module1.myconn)
                        command.Parameters.AddWithValue("@student_id", selectedStudentId)

                        Dim dt As New DataTable()
                        Dim adapter As New MySqlDataAdapter(command)
                        adapter.Fill(dt)

                        ' Set the data source for the DataGridView
                        dgdtr.DataSource = dt

                        ' Optionally, auto-generate columns based on the data source
                        ' dgdtr.AutoGenerateColumns = True

                        ' Update column headers
                        dgdtr.Columns("date_attended").HeaderText = "Date Attended"
                        dgdtr.Columns("time_in").HeaderText = "Time In"
                        dgdtr.Columns("time_out").HeaderText = "Time Out"
                        dgdtr.Columns("total_time").HeaderText = "Total Time"

                        ' Calculate and display total hours
                        Dim totalSum As TimeSpan = TimeSpan.Zero
                        For Each row As DataRow In dt.Rows
                            If Not IsDBNull(row("total_time")) Then
                                Dim totalTimeString As String = row("total_time").ToString()
                                Dim timeParts As String() = totalTimeString.Split(":") ' Split the time string into hours and minutes
                                If timeParts.Length = 2 Then
                                    Dim hours As Integer = 0
                                    Dim minutes As Integer = 0
                                    If Integer.TryParse(timeParts(0), hours) AndAlso Integer.TryParse(timeParts(1), minutes) Then
                                        totalSum = totalSum.Add(New TimeSpan(hours, minutes, 0)) ' Create TimeSpan from hours and minutes
                                    End If
                                End If
                            End If
                        Next

                        ' Display total hours in the TextBox
                        totalhourstxt.Text = totalSum.Hours.ToString("00") & " hours " & totalSum.Minutes.ToString("00") & " minutes"

                    End Using
                End If
            Else
                MessageBox.Show("Database connection is not valid or open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As MySqlException
            MsgBox("Error: " & ex.Message)
        Finally
            Module1.Disconnect_to_DB()
        End Try
    End Sub


    Private Sub printdtrbtn_Click(sender As Object, e As EventArgs) Handles printdtrbtn.Click
        Try
            Module1.Connect_to_DB()
            If Module1.myconn IsNot Nothing AndAlso Module1.myconn.State = ConnectionState.Open Then
                If dgdtr IsNot Nothing AndAlso dgdtr.Rows.Count > 0 Then
                    Dim saveFileDialog1 As New SaveFileDialog()
                    saveFileDialog1.FileName = "DTR"
                    saveFileDialog1.DefaultExt = ".pdf"
                    saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
                    saveFileDialog1.FilterIndex = 1
                    saveFileDialog1.RestoreDirectory = True

                    If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                        Dim selectedStudentName As String = namecmb.SelectedItem.ToString()
                        Dim doc As New Document(PageSize.A4.Rotate())
                        Dim filePath As String = saveFileDialog1.FileName
                        Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(filePath, FileMode.Create))
                        doc.Open()

                        ' Document content such as Title, Name, etc.
                        Dim titleParagraph As New Paragraph("DAILY TIME RECORD")
                        titleParagraph.Alignment = Element.ALIGN_CENTER
                        doc.Add(titleParagraph)
                        doc.Add(New Paragraph(" ")) ' Adding space

                        Dim nameParagraph As New Paragraph(selectedStudentName)
                        nameParagraph.Alignment = Element.ALIGN_CENTER
                        doc.Add(nameParagraph)
                        doc.Add(New Paragraph(" ")) ' Adding space

                        ' Add DataGridView content to PDF
                        Dim pdfTable As New PdfPTable(dgdtr.ColumnCount)
                        pdfTable.WidthPercentage = 100 ' Set table width to 100% of the page

                        ' Adding headers
                        For Each column As DataGridViewColumn In dgdtr.Columns
                            Dim cell As New PdfPCell(New Phrase(column.HeaderText))
                            cell.HorizontalAlignment = Element.ALIGN_CENTER ' Center header cells
                            pdfTable.AddCell(cell)
                        Next

                        ' Adding data rows
                        For Each row As DataGridViewRow In dgdtr.Rows
                            For Each cell As DataGridViewCell In row.Cells
                                Dim value As String = If(cell.Value IsNot Nothing, cell.Value.ToString(), "")
                                Dim pdfCell As New PdfPCell(New Phrase(value))
                                pdfCell.HorizontalAlignment = Element.ALIGN_CENTER ' Center data cells
                                pdfTable.AddCell(pdfCell)
                            Next
                        Next

                        doc.Add(pdfTable)

                        ' Finalize and close the document
                        doc.Close()
                        MessageBox.Show("PDF file saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("No data to export to PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Database connection is not valid or open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Module1.Disconnect_to_DB()
        End Try
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Hide()
        dashboardForm.Show()
    End Sub
End Class
