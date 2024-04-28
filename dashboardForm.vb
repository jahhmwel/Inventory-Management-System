Public Class dashboardForm
    Private Sub addstudentbtn_Click(sender As Object, e As EventArgs) Handles addstudentbtn.Click
        Me.Hide()
        addStudentForm.Show()
    End Sub

    Private Sub addmodelbtn_Click(sender As Object, e As EventArgs) Handles addmodelbtn.Click
        Me.Hide()
        inventoryForm.Show()
    End Sub

    Private Sub manualattendancebtn_Click(sender As Object, e As EventArgs) Handles manualattendancebtn.Click
        Me.Hide()
        manualAttendance.Show()
    End Sub

    Private Sub attendancebtn_Click(sender As Object, e As EventArgs) Handles attendancebtn.Click
        Me.Hide()
        attendance.Show()
    End Sub
End Class