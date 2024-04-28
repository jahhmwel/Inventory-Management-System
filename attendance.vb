Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class attendance
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
        Try
            Module1.Connect_to_DB()

            Dim selectedStudentName = namecmb.SelectedItem.ToString
            Dim queryStudentId = "SELECT id FROM students WHERE student_name = @student_name"
            Dim commandStudentId As New MySqlCommand(queryStudentId, myconn)
            commandStudentId.Parameters.AddWithValue("@student_name", selectedStudentName)
            Dim studentId = Convert.ToInt32(commandStudentId.ExecuteScalar)

            Dim currentDate = Date.Today
            Dim currentTime = Date.Now

            Dim queryUpdateTimeIn = "INSERT INTO attendance (student_id, date_attended, time_in, status) VALUES (@student_id, @date_attended, @time_in, 'Present')"
            Dim commandUpdateTimeIn As New MySqlCommand(queryUpdateTimeIn, myconn)
            commandUpdateTimeIn.Parameters.AddWithValue("@student_id", studentId)
            commandUpdateTimeIn.Parameters.AddWithValue("@date_attended", currentDate)
            commandUpdateTimeIn.Parameters.AddWithValue("@time_in", currentTime.TimeOfDay)
            commandUpdateTimeIn.ExecuteNonQuery()

            MessageBox.Show("Time in recorded successfully.")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            Module1.Disconnect_to_DB()
        End Try
    End Sub

    Private Sub timeoutbtn_Click(sender As Object, e As EventArgs) Handles timeoutbtn.Click
        Try
            Module1.Connect_to_DB()

            Dim selectedStudentName As String = namecmb.SelectedItem.ToString()
            Dim queryStudentId As String = "SELECT id FROM students WHERE student_name = @student_name"
            Dim commandStudentId As New MySqlCommand(queryStudentId, myconn)
            commandStudentId.Parameters.AddWithValue("@student_name", selectedStudentName)
            Dim studentId As Integer = Convert.ToInt32(commandStudentId.ExecuteScalar())

            Dim currentDate As Date = Date.Today

            Dim queryCheckTimeIn As String = "SELECT COUNT(*) FROM attendance WHERE student_id = @student_id AND date_attended = @date_attended AND time_in IS NOT NULL"
            Dim commandCheckTimeIn As New MySqlCommand(queryCheckTimeIn, myconn)
            commandCheckTimeIn.Parameters.AddWithValue("@student_id", studentId)
            commandCheckTimeIn.Parameters.AddWithValue("@date_attended", currentDate)
            Dim timeInCount As Integer = Convert.ToInt32(commandCheckTimeIn.ExecuteScalar())

            If timeInCount = 0 Then
                MessageBox.Show("Time in first.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim currentTime As DateTime = DateTime.Now

            Dim queryUpdateTimeOut As String = "UPDATE attendance SET time_out = @time_out WHERE student_id = @student_id AND date_attended = @date_attended"
            Dim commandUpdateTimeOut As New MySqlCommand(queryUpdateTimeOut, myconn)
            commandUpdateTimeOut.Parameters.AddWithValue("@time_out", currentTime.TimeOfDay)
            commandUpdateTimeOut.Parameters.AddWithValue("@student_id", studentId)
            commandUpdateTimeOut.Parameters.AddWithValue("@date_attended", currentDate)
            commandUpdateTimeOut.ExecuteNonQuery()

            Dim queryCalculateTotalTime As String = "UPDATE attendance SET total_time = TIMEDIFF(time_out, time_in) WHERE student_id = @student_id AND date_attended = @date_attended"
            Dim commandCalculateTotalTime As New MySqlCommand(queryCalculateTotalTime, myconn)
            commandCalculateTotalTime.Parameters.AddWithValue("@student_id", studentId)
            commandCalculateTotalTime.Parameters.AddWithValue("@date_attended", currentDate)
            commandCalculateTotalTime.ExecuteNonQuery()

            MessageBox.Show("Time out recorded successfully.")


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            Module1.Disconnect_to_DB()
        End Try
    End Sub

    Private Sub printdtrbtn_Click(sender As Object, e As EventArgs) Handles printdtrbtn.Click
        Me.Hide()
        dtrForm.Show()
    End Sub

    Private Sub timemanualabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles timemanualabel.LinkClicked
        Me.Hide()
        manualAttendance.Show()
    End Sub

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Hide()
        dashboardForm.Show()
    End Sub
End Class