Imports MySql.Data.MySqlClient

Public Class registerForm
    Private Sub registerbtn_Click(sender As Object, e As EventArgs) Handles registerbtn.Click
        Call Connect_to_DB()
        Dim mycmd As New MySqlCommand

        Dim username As String = usernametxt.Text
        Dim password As String = passwordtxt.Text
        Dim email As String = emailtxt.Text
        Dim address As String = addresstxt.Text

        Dim sql As String = "INSERT INTO users (name, password, email, address) VALUES (@name, @password, @email, @address)"
        mycmd = New MySqlCommand(sql, myconn)

        mycmd.Parameters.AddWithValue("@name", username)
        mycmd.Parameters.AddWithValue("@password", password)
        mycmd.Parameters.AddWithValue("@email", email)
        mycmd.Parameters.AddWithValue("@address", address)
        mycmd.ExecuteNonQuery()
        MessageBox.Show("Account Successfully Created!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Call Disconnect_to_DB()
        loginForm.Show()
        Hide()
    End Sub

    Private Sub cancelbtn_Click(sender As Object, e As EventArgs) Handles cancelbtn.Click
        Me.Hide()
        loginForm.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        loginForm.Show()
    End Sub
End Class