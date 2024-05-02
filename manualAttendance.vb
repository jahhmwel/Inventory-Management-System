Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class manualAttendance
    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Hide()
        dashboardForm.Show()
    End Sub

    Private Sub attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataIntoComboBox()
    End Sub

    Private Sub LoadDataIntoComboBox()
        Try
            Module1.Connect_to_DB()

            Dim query As String = "SELECT student_name FROM students"
            Dim command As New MySqlCommand(query, myconn)

            Dim reader As MySqlDataReader = command.ExecuteReader()

            namecmb.Items.Clear()
            While reader.Read()
                namecmb.Items.Add(reader("student_name").ToString())
            End While

            reader.Close()

        Catch ex As MySqlException
            MsgBox("Error: " & ex.Message)
        Finally
            Module1.Disconnect_to_DB()
        End Try
    End Sub

    Private Sub timeinbtn_Click(sender As Object, e As EventArgs) Handles timeinbtn.Click
        Dim selectedName As String = namecmb.SelectedItem.ToString()

        If String.IsNullOrEmpty(selectedName) Then
            MsgBox("Please select a student.")
            Return
        End If

        Dim selectedDate As DateTime = datetimepck.Value
        Dim currentDate As String = selectedDate.ToString("dd-MM-yyyy")

        Dim timeInStr As String = InputBox("Enter the time in (HH:MM)", "Time In")
        Dim timeInDateTime As DateTime
        If Not DateTime.TryParseExact(timeInStr, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, timeInDateTime) Then
            MsgBox("Invalid time format. Please enter time in HH:MM format.")
            Return
        End If

        Dim timeIn As String = timeInDateTime.ToString("hh:mm")

        Try
            Connect_to_DB()

            Dim query As String = "INSERT INTO attendance (student_id, date_attended, time_in, status) VALUES ((SELECT id FROM students WHERE student_name = @student_name), @date_attended, @time_in, 'Present')"

            Using command As New MySqlCommand(query, myconn)
                command.Parameters.AddWithValue("@student_name", selectedName)
                command.Parameters.AddWithValue("@date_attended", currentDate)
                command.Parameters.AddWithValue("@time_in", timeIn)
                command.ExecuteNonQuery()
                MsgBox("Attendance recorded successfully.")
            End Using

        Catch ex As MySqlException
            MsgBox("Error: " & ex.Message)
        Finally
            Disconnect_to_DB()
        End Try
    End Sub

    Private Sub timeoutbtn_Click(sender As Object, e As EventArgs) Handles timeoutbtn.Click
        Try
            Connect_to_DB()

            Dim selectedStudentName As String = namecmb.SelectedItem.ToString()
            Dim queryStudentId As String = "SELECT id FROM students WHERE student_name = @student_name"
            Dim commandStudentId As New MySqlCommand(queryStudentId, myconn)
            commandStudentId.Parameters.AddWithValue("@student_name", selectedStudentName)
            Dim studentId As Integer = Convert.ToInt32(commandStudentId.ExecuteScalar())

            Dim selectedDate As String = datetimepck.Value.ToString("dd-MM-yyyy")

            ' Proceed with timing out
            Dim timeOutStr As String = InputBox("Enter the time out (HH:MM)", "Time Out")

            Dim timeOutDateTime As DateTime
            If Not DateTime.TryParseExact(timeOutStr, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, timeOutDateTime) Then
                MessageBox.Show("Invalid time format. Please enter time in HH:MM format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim timeOut As String = timeOutDateTime.ToString("HH:mm")

            ' Update the database with the time out and calculate total time within working hours
            Dim queryUpdateTimeOut As String = "UPDATE attendance SET time_out = @time_out WHERE student_id = @student_id AND date_attended = @date_attended AND time_out IS NULL"
            Dim commandUpdateTimeOut As New MySqlCommand(queryUpdateTimeOut, myconn)
            commandUpdateTimeOut.Parameters.AddWithValue("@time_out", timeOut)
            commandUpdateTimeOut.Parameters.AddWithValue("@student_id", studentId)
            commandUpdateTimeOut.Parameters.AddWithValue("@date_attended", selectedDate)
            Dim rowsUpdated As Integer = commandUpdateTimeOut.ExecuteNonQuery()

            If rowsUpdated > 0 Then
                ' Calculate total time within working hours
                Dim startTime1 As DateTime = timeOutDateTime.Date.AddHours(8) ' 8:00 AM
                Dim endTime1 As DateTime = timeOutDateTime.Date.AddHours(12) ' 12:00 PM
                Dim startTime2 As DateTime = timeOutDateTime.Date.AddHours(13) ' 1:00 PM
                Dim endTime2 As DateTime = timeOutDateTime.Date.AddHours(17) ' 5:00 PM

                ' Adjust time if necessary
                If timeOutDateTime > endTime1 AndAlso timeOutDateTime < startTime2 Then
                    timeOutDateTime = endTime1 ' Set time out to 12:00 PM
                End If

                Dim totalWorkingTime As TimeSpan = TimeSpan.Zero
                If timeOutDateTime >= startTime1 AndAlso timeOutDateTime <= endTime1 Then
                    ' Time out is between 8:00 AM and 12:00 PM
                    totalWorkingTime = timeOutDateTime - startTime1
                ElseIf timeOutDateTime >= startTime2 AndAlso timeOutDateTime <= endTime2 Then
                    ' Time out is between 1:00 PM and 5:00 PM
                    totalWorkingTime = timeOutDateTime - startTime2
                End If

                ' Update the database with the calculated total time
                Dim queryUpdateTotalTime As String = "UPDATE attendance SET total_time = @total_time WHERE student_id = @student_id AND date_attended = @date_attended AND total_time IS NULL"
                Dim commandUpdateTotalTime As New MySqlCommand(queryUpdateTotalTime, myconn)
                commandUpdateTotalTime.Parameters.AddWithValue("@total_time", totalWorkingTime.ToString("hh\:mm"))
                commandUpdateTotalTime.Parameters.AddWithValue("@student_id", studentId)
                commandUpdateTotalTime.Parameters.AddWithValue("@date_attended", selectedDate)
                commandUpdateTotalTime.ExecuteNonQuery()

                MessageBox.Show("Time out recorded successfully.")
            Else
                MessageBox.Show("Time out already recorded for today or no time in recorded.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            Disconnect_to_DB()
        End Try
    End Sub


    Private Sub printdtrbtn_Click(sender As Object, e As EventArgs) Handles printdtrbtn.Click
        Me.Hide()
        dtrForm.Show()
    End Sub
End Class