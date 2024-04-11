Imports MySql.Data.MySqlClient

Public Class loginForm
    Private Sub loginbtn_Click_1(sender As Object, e As EventArgs) Handles loginbtn.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            strSQL = "Select * from users where username = '" _
                & .usernametxt.Text & "' and password = ('" _
                & .passwordtxt.Text & "')"
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                Me.Hide()
                inventoryForm.Show()
            Else
                MessageBox.Show("Invalid username or password")
            End If
            Call Disconnect_to_DB()
        End With
    End Sub

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub loginForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            loginbtn.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckStateChanged
        If Guna2CheckBox1.Checked = False Then
            passwordtxt.PasswordChar = "*"
        Else
            passwordtxt.PasswordChar = ""
        End If
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Me.Hide()
        ForgotPassForm.Show()
    End Sub

    Private Sub registerlink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles registerlink.LinkClicked
        Me.Hide()
        registerForm.Show()
    End Sub
End Class


