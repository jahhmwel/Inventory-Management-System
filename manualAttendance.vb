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

        Dim currentDate As Date = Date.Now

        Dim timeInStr As String = InputBox("Enter the time in (HH:MM:SS AM/PM)", "Time In")
        Dim timeInDateTime As DateTime
        If Not DateTime.TryParseExact(timeInStr, "hh:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, timeInDateTime) Then
            MsgBox("Invalid time format. Please enter time in HH:MM:SS AM/PM format.")
            Return
        End If

        Dim timeIn As TimeSpan = timeInDateTime.TimeOfDay

        Try
            Connect_to_DB()

            Dim selectedDate As Date = datetimepck.Value.Date

            Dim query As String = "INSERT INTO attendance (student_id, date_attended, time_in) VALUES ((SELECT id FROM students WHERE student_name = @student_name), @date_attended, @time_in)"

            Using command As New MySqlCommand(query, myconn)
                command.Parameters.AddWithValue("@student_name", selectedName)
                command.Parameters.AddWithValue("@date_attended", selectedDate.Date)
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

            Dim selectedDate As Date = datetimepck.Value.Date

            Dim queryCheckTimeIn As String = "SELECT COUNT(*) FROM attendance WHERE student_id = @student_id AND date_attended = @date_attended AND time_in IS NOT NULL"
            Dim commandCheckTimeIn As New MySqlCommand(queryCheckTimeIn, myconn)
            commandCheckTimeIn.Parameters.AddWithValue("@student_id", studentId)
            commandCheckTimeIn.Parameters.AddWithValue("@date_attended", selectedDate)
            Dim timeInCount As Integer = Convert.ToInt32(commandCheckTimeIn.ExecuteScalar())

            If timeInCount = 0 Then
                MessageBox.Show("Please time in first before timing out.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim timeOutStr As String = InputBox("Enter the time out (HH:MM:SS AM/PM)", "Time Out")

            Dim timeOutDateTime As DateTime
            If Not DateTime.TryParseExact(timeOutStr, "hh:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, timeOutDateTime) Then
                MessageBox.Show("Invalid time format. Please enter time in HH:MM:SS AM/PM format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim timeOut As TimeSpan = timeOutDateTime.TimeOfDay

            Dim queryUpdateTimeOut As String = "UPDATE attendance SET time_out = @time_out, date_attended = @date_attended WHERE student_id = @student_id AND date_attended = @date_atended AND time_out IS NULL"
            Dim commandUpdateTimeOut As New MySqlCommand(queryUpdateTimeOut, myconn)
            commandUpdateTimeOut.Parameters.AddWithValue("@time_out", timeOut)
            commandUpdateTimeOut.Parameters.AddWithValue("@student_id", studentId)
            commandUpdateTimeOut.Parameters.AddWithValue("@date_attended", selectedDate)
            Dim rowsUpdated As Integer = commandUpdateTimeOut.ExecuteNonQuery()

            If rowsUpdated > 0 Then
                Dim queryCalculateTotalTime As String = "UPDATE attendance SET total_time = TIMEDIFF(time_out, time_in) WHERE student_id = @student_id AND date_attended = @date_atended AND total_time IS NULL"
                Dim commandCalculateTotalTime As New MySqlCommand(queryCalculateTotalTime, myconn)
                commandCalculateTotalTime.Parameters.AddWithValue("@student_id", studentId)
                commandCalculateTotalTime.Parameters.AddWithValue("@date_attended", selectedDate)
                commandCalculateTotalTime.ExecuteNonQuery()
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