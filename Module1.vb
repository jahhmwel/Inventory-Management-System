Imports MySql.Data.MySqlClient

Module Module1
    Public myConnectionString As String = "server=localhost;port=3306;" _
                                            & "uid=root;" _
                                            & "pwd=jmtn0630naz;" _
                                            & "database=records"
    Public myconn As New MySqlConnection(myConnectionString)
    Public strSQL As String

    Public Sub Connect_to_DB()
        Try
            If myconn.State = ConnectionState.Closed Then
                myconn.Open()
            End If
        Catch ex As MySqlException
            Select Case ex.Number
                Case 0
                    MessageBox.Show("Cannot Connect to Server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case 1045
                    MessageBox.Show("Invalid Username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Case Else
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End Try
    End Sub

    Public Sub Disconnect_to_DB()
        If myconn.State = ConnectionState.Open Then
            myconn.Close()
        End If
    End Sub
End Module
