Imports MySql.Data.MySqlClient

Public Class registerForm
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Call Connect_to_DB()
        Dim mycmd As New MySqlCommand

        Dim customer_name As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        Dim email As String = TextBox3.Text
        Dim address As String = TextBox4.Text

        Dim sql As String = "INSERT INTO users (name, password, email, address) VALUES (@name, @password, @email, @address)"
        mycmd = New MySqlCommand(sql, myconn)

        mycmd.Parameters.AddWithValue("@name", customer_name)
        mycmd.Parameters.AddWithValue("@password", password)
        mycmd.Parameters.AddWithValue("@email", email)
        mycmd.Parameters.AddWithValue("@address", address)
        mycmd.ExecuteNonQuery()
        MessageBox.Show("Account Successfully Created!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Call Disconnect_to_DB()
        loginForm.Show()
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        loginForm.Show()
    End Sub
End Class