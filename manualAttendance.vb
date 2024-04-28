Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class manualAttendance
    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Hide()
        dashboardForm.Show()
    End Sub

    Private Sub attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call the method to load data into ComboBox when the form loads
        LoadDataIntoComboBox()
    End Sub

    Private Sub LoadDataIntoComboBox()
        Try
            ' Connect to the database
            Module1.Connect_to_DB()

            ' Query to select data
            Dim query As String = "SELECT student_name FROM students"

            ' Create a MySqlCommand and set its connection and query
            Dim command As New MySqlCommand(query, myconn)

            ' Execute the query and get the MySqlDataReader
            Dim reader As MySqlDataReader = command.ExecuteReader()

            ' Clear ComboBox before adding new items
            namecmb.Items.Clear()

            ' Iterate through the MySqlDataReader and add items to ComboBox
            While reader.Read()
                namecmb.Items.Add(reader("student_name").ToString())
            End While

            ' Close the reader
            reader.Close()

        Catch ex As MySqlException
            MsgBox("Error: " & ex.Message)
        Finally
            ' Disconnect from the database
            Module1.Disconnect_to_DB()
        End Try
    End Sub

    Private Sub timeinbtn_Click(sender As Object, e As EventArgs) Handles timeinbtn.Click
        ' Retrieve the selected student name
        Dim selectedName As String = namecmb.SelectedItem.ToString()

        ' Check if a student is selected
        If String.IsNullOrEmpty(selectedName) Then
            MsgBox("Please select a student.")
            Return
        End If

        ' Get the current date
        Dim currentDate As Date = Date.Now

        ' Get the time_in value from the user
        Dim timeInStr As String = InputBox("Enter the time in (HH:MM:SS AM/PM)", "Time In")

        ' Parse the user input to a DateTime object
        Dim timeInDateTime As DateTime
        If Not DateTime.TryParseExact(timeInStr, "hh:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, timeInDateTime) Then
            MsgBox("Invalid time format. Please enter time in HH:MM:SS AM/PM format.")
            Return
        End If

        ' Extract the time portion from the DateTime object
        Dim timeIn As TimeSpan = timeInDateTime.TimeOfDay

        Try
            ' Connect to the database
            Connect_to_DB()

            ' Insert the attendance record into the database
            ' Get the current date from the DateTimePicker
            Dim selectedDate As Date = datetimepck.Value.Date

            ' Insert the attendance record into the database
            Dim query As String = "INSERT INTO attendance (student_id, date_attended, time_in) VALUES ((SELECT id FROM students WHERE student_name = @student_name), @date_attended, @time_in)"

            ' Create a MySqlCommand and set its connection and query
            Using command As New MySqlCommand(query, myconn)
                ' Add parameters for the student name, date attended, and time in
                command.Parameters.AddWithValue("@student_name", selectedName)
                command.Parameters.AddWithValue("@date_attended", selectedDate.Date)
                command.Parameters.AddWithValue("@time_in", timeIn)

                ' Execute the command
                command.ExecuteNonQuery()

                ' Inform the user that attendance has been recorded
                MsgBox("Attendance recorded successfully.")
            End Using

        Catch ex As MySqlException
            MsgBox("Error: " & ex.Message)
        Finally
            ' Disconnect from the database
            Disconnect_to_DB()
        End Try
    End Sub

    Private Sub timeoutbtn_Click(sender As Object, e As EventArgs) Handles timeoutbtn.Click
        Try
            ' Connect to the database
            Connect_to_DB()

            ' Get the selected student name from the ComboBox
            Dim selectedStudentName As String = namecmb.SelectedItem.ToString()

            ' Get the student_id for the selected student name
            Dim queryStudentId As String = "SELECT id FROM students WHERE student_name = @student_name"
            Dim commandStudentId As New MySqlCommand(queryStudentId, myconn)
            commandStudentId.Parameters.AddWithValue("@student_name", selectedStudentName)
            Dim studentId As Integer = Convert.ToInt32(commandStudentId.ExecuteScalar())

            ' Get the current date
            Dim selectedDate As Date = datetimepck.Value.Date

            ' Check if the student has already timed in for the selected date
            Dim queryCheckTimeIn As String = "SELECT COUNT(*) FROM attendance WHERE student_id = @student_id AND date_attended = @date_attended AND time_in IS NOT NULL"
            Dim commandCheckTimeIn As New MySqlCommand(queryCheckTimeIn, myconn)
            commandCheckTimeIn.Parameters.AddWithValue("@student_id", studentId)
            commandCheckTimeIn.Parameters.AddWithValue("@date_attended", selectedDate) ' Use selectedDate instead of currentDate
            Dim timeInCount As Integer = Convert.ToInt32(commandCheckTimeIn.ExecuteScalar())

            ' If the student hasn't timed in, display a notification and exit
            If timeInCount = 0 Then
                MessageBox.Show("Please time in first before timing out.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub ' Exit the sub to prevent further execution
            End If

            ' Get the time out from the user
            Dim timeOutStr As String = InputBox("Enter the time out (HH:MM:SS AM/PM)", "Time Out")

            ' Parse the user input to a DateTime object
            Dim timeOutDateTime As DateTime
            If Not DateTime.TryParseExact(timeOutStr, "hh:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, timeOutDateTime) Then
                MessageBox.Show("Invalid time format. Please enter time in HH:MM:SS AM/PM format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Extract the time portion from the DateTime object
            Dim timeOut As TimeSpan = timeOutDateTime.TimeOfDay

            ' Update the time_out column in the attendance table for the selected student
            Dim queryUpdateTimeOut As String = "UPDATE attendance SET time_out = @time_out, date_attended = @date_attended WHERE student_id = @student_id AND date_attended = @date_atended AND time_out IS NULL"
            Dim commandUpdateTimeOut As New MySqlCommand(queryUpdateTimeOut, myconn)
            commandUpdateTimeOut.Parameters.AddWithValue("@time_out", timeOut)
            commandUpdateTimeOut.Parameters.AddWithValue("@student_id", studentId)
            commandUpdateTimeOut.Parameters.AddWithValue("@date_attended", selectedDate)
            Dim rowsUpdated As Integer = commandUpdateTimeOut.ExecuteNonQuery()

            ' Check if any rows were updated
            If rowsUpdated > 0 Then
                ' Calculate total time worked
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
            ' Disconnect from the database
            Disconnect_to_DB()
        End Try
    End Sub

    Private Sub printdtrbtn_Click(sender As Object, e As EventArgs) Handles printdtrbtn.Click
        Me.Hide()
        dtrForm.Show()
    End Sub
End Class