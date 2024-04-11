Imports MySql.Data.MySqlClient

Public Class ForgotPassForm
    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Me.Hide()
        loginForm.Show()
    End Sub

    Private Sub changepassbtn_Click(sender As Object, e As EventArgs) Handles changepassbtn.Click
        Try
            Module1.Connect_to_DB()
            Dim cmd As New MySqlCommand("SELECT * FROM users WHERE username = @username AND password = @password", Module1.myconn)
            cmd.Parameters.AddWithValue("@username", usernametxt.Text)
            cmd.Parameters.AddWithValue("@password", oldpasstxt.Text)

            Dim dr As MySqlDataReader = cmd.ExecuteReader()
            If dr.Read() Then
                dr.Close()
                updatePass()
                MsgBox("Password updated successfully.", MsgBoxStyle.Information)
                Me.Hide()
                loginForm.Show()
            Else
                MsgBox("Incorrect username or old password.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Module1.Disconnect_to_DB()
            usernametxt.Text = ""
            oldpasstxt.Text = ""
            newpasstxt.Text = ""
            confirmpasstxt.Text = ""
        End Try
    End Sub

    Private Sub updatePass()
        Try
            Module1.Connect_to_DB()
            Dim cmd As New MySqlCommand("UPDATE users SET password = @newPassword WHERE username = @username", Module1.myconn)
            cmd.Parameters.AddWithValue("@newPassword", newpasstxt.Text)
            cmd.Parameters.AddWithValue("@username", usernametxt.Text)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Module1.Disconnect_to_DB()
        End Try
    End Sub
End Class
