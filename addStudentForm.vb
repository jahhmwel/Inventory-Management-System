Imports System.Windows.Forms.Design
Imports MySql.Data.MySqlClient

Public Class addStudentForm
    Dim dbDataSet As New DataTable
    Dim bSource As New BindingSource

    Private Sub submitbtn_Click(sender As Object, e As EventArgs) Handles submitbtn.Click
        Try
            Module1.Connect_to_DB()

            ' Validate input for empty fields
            If String.IsNullOrEmpty(studentnotxt.Text) OrElse
           String.IsNullOrEmpty(studentnametxt.Text) OrElse
           String.IsNullOrEmpty(cmbcollege.Text) OrElse
           String.IsNullOrEmpty(cmbcourse.Text) Then

                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Check for duplicate data
            If CheckDuplicateData(studentnotxt.Text, studentnametxt.Text, cmbcollege.Text, cmbcourse.Text) Then
                MessageBox.Show("Student already exists in the database. Duplicate entry not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Continue with database operation if input is valid
            Dim sql As String = "INSERT INTO students (student_no, student_name, college, course) VALUES (@student_no, @student_name, @college, @course)"
            Using mycmd As New MySqlCommand(sql, Module1.myconn)
                mycmd.Parameters.AddWithValue("@student_no", studentnotxt.Text)
                mycmd.Parameters.AddWithValue("@student_name", studentnametxt.Text)
                mycmd.Parameters.AddWithValue("@college", cmbcollege.Text)
                mycmd.Parameters.AddWithValue("@course", cmbcourse.Text)

                mycmd.ExecuteNonQuery()
                MessageBox.Show("Student Successfully Registered!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Clear_Boxes()

                LoadDataGridView()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Module1.Disconnect_to_DB()
        End Try
    End Sub

    Private Sub studentnotxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles studentnotxt.KeyPress
        ' Check if the pressed key is a digit (0-9), hyphen (-), or the backspace key (to allow editing)
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True ' Ignore the key press event
        End If
    End Sub

    Private Sub studentnametxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles studentnametxt.KeyPress
        ' Check if the pressed key is a letter (alphabetic character), space, or the backspace key (to allow editing)
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " " AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True ' Ignore the key press event
        End If
    End Sub

    Private Function CheckDuplicateData(studentno As String, studentname As String, college As String, course As String) As Boolean
        Dim isDuplicate As Boolean = False
        Dim query As String = "SELECT COUNT(*) FROM students WHERE student_no = @student_no AND student_name = @student_name AND college = @college AND course = @course"
        Using connection As New MySqlConnection(Module1.myConnectionString)
            connection.Open()
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@student_no", studentno)
                cmd.Parameters.AddWithValue("@student_name", studentname)
                cmd.Parameters.AddWithValue("@college", college)
                cmd.Parameters.AddWithValue("@course", course)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    isDuplicate = True
                End If
            End Using
        End Using
        Return isDuplicate
    End Function

    Private Sub Clear_Boxes()
        studentnotxt.Text = ""
        studentnametxt.Text = ""
        cmbcollege.SelectedIndex = -0
        cmbcourse.SelectedIndex = -0
    End Sub


    Private Sub dgstudents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgstudents.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgstudents.Rows(e.RowIndex)
            studentnotxt.Text = row.Cells("student_no").Value.ToString
            studentnametxt.Text = row.Cells("student_name").Value.ToString
            cmbcollege.Text = row.Cells("college").Value.ToString
            cmbcourse.Text = row.Cells("course").Value.ToString
        End If
    End Sub

    Private Sub inventoryForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        LoadDataGridView()
    End Sub

    Private Sub LoadDataGridView()
        Try
            Module1.Connect_to_DB()
            Dim Query As String = "SELECT * FROM students"

            Using Command As New MySqlCommand(Query, Module1.myconn)
                Using myreader As MySqlDataReader = Command.ExecuteReader()
                    dbDataSet.Load(myreader)
                End Using
            End Using

            dgstudents.DataSource = dbDataSet
            dgstudents.ReadOnly = True
            dgstudents.ColumnHeadersHeight = 30

            Dim columnTitles() As String = {"ID", "Student Number", "Student Name", "College", "Course", "Date Added"}
            For i As Integer = 0 To dgstudents.Columns.Count - 1
                If i < columnTitles.Length Then
                    dgstudents.Columns(i).HeaderText = columnTitles(i)
                End If
            Next

            ' Set the font size to 12
            dgstudents.Font = New Font(dgstudents.Font.FontFamily, 9.5)

            ' Set the height of each cell to 20
            For Each row As DataGridViewRow In dgstudents.Rows
                If row.IsNewRow Then Continue For ' Skip the new row
                row.Height = 40
            Next

            ' Adjust column widths
            For Each col As DataGridViewColumn In dgstudents.Columns
                Dim maxTextLength As Integer = 0
                For Each row As DataGridViewRow In dgstudents.Rows
                    If Not row.IsNewRow AndAlso row.Cells(col.Index).Value IsNot Nothing Then
                        Dim cellTextLength As Integer = row.Cells(col.Index).Value.ToString().Length
                        If cellTextLength > maxTextLength Then
                            maxTextLength = cellTextLength
                        End If
                    End If
                Next
                Dim minWidth As Integer = TextRenderer.MeasureText(col.HeaderText, dgstudents.Font).Width + 50
                col.MinimumWidth = minWidth
                col.Width = Math.Max(minWidth, TextRenderer.MeasureText(New String("X", maxTextLength), dgstudents.Font).Width + 50)
            Next

            dgstudents.AllowUserToAddRows = False
            dgstudents.AllowUserToResizeRows = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Module1.Disconnect_to_DB()
        End Try
    End Sub

    Private Sub backpicbtn_Click(sender As Object, e As EventArgs) Handles backpicbtn.Click
        Me.Hide()
        dashboardForm.Show()
    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        Try
            If dgstudents.SelectedRows.Count > 0 Then
                Dim id As Integer = Convert.ToInt32(dgstudents.SelectedRows(0).Cells("id").Value)

                Module1.Connect_to_DB()
                Dim mycmd As New MySqlCommand
                Dim strSQL As String = "UPDATE students SET student_no = @student_no, student_name = @student_name, college = @college, course = @course WHERE id = @id"

                mycmd.CommandText = strSQL
                mycmd.Connection = Module1.myconn
                mycmd.Parameters.AddWithValue("@id", id)

                ' Check if any textbox is empty, and skip updating if any are empty
                If String.IsNullOrEmpty(studentnotxt.Text) OrElse
                String.IsNullOrEmpty(studentnametxt.Text) OrElse
                String.IsNullOrEmpty(cmbcollege.Text) OrElse
                String.IsNullOrEmpty(cmbcourse.Text) Then
                    MessageBox.Show("Please select record to be updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                mycmd.Parameters.AddWithValue("@student_no", studentnotxt.Text)
                mycmd.Parameters.AddWithValue("@student_name", studentnametxt.Text)
                mycmd.Parameters.AddWithValue("@college", cmbcollege.Text)
                mycmd.Parameters.AddWithValue("@course", cmbcourse.Text)

                mycmd.ExecuteNonQuery()
                MsgBox("Successfully Updated")
                Clear_Boxes()
                LoadDataGridView()
            End If
        Catch ex As MySqlException
            MsgBox(ex.Number & " " & ex.Message)
        Finally
            Module1.Disconnect_to_DB()
        End Try
    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click
        Try
            Module1.Connect_to_DB()

            If String.IsNullOrEmpty(studentnotxt.Text) Then
                MessageBox.Show("Please select a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim Query As String = "DELETE FROM students WHERE student_no = @student_no"
            Dim answer As MsgBoxResult

            answer = MsgBox("Are you sure you want to delete this record", MsgBoxStyle.YesNo)
            If answer = MsgBoxResult.Yes Then
                Using Command As New MySqlCommand(Query, Module1.myconn)
                    Command.Parameters.AddWithValue("@student_no", studentnotxt.Text)

                    Dim rowsAffected As Integer = Command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Successfully Deleted")
                        Dim rowToDelete As DataRow = dbDataSet.Rows.Cast(Of DataRow)().FirstOrDefault(Function(row) row("student_no").ToString() = studentnotxt.Text)
                        If rowToDelete IsNot Nothing Then
                            dbDataSet.Rows.Remove(rowToDelete)
                        End If
                        dgstudents.DataSource = dbDataSet
                    Else
                        MessageBox.Show("No record found.")
                    End If
                    Clear_Boxes()

                End Using
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            Module1.Disconnect_to_DB()
        End Try
    End Sub

    Private Sub searchtxt_TextChanged(sender As Object, e As EventArgs) Handles searchtxt.TextChanged
        PerformSearch(searchtxt.Text)
    End Sub

    Private Sub PerformSearch(searchText As String)
        Try
            Module1.Connect_to_DB()
            Dim Query As String = "SELECT * FROM students WHERE student_no LIKE @searchText OR student_name LIKE @searchText OR college LIKE @searchText OR course LIKE @searchText"

            Using Command As New MySqlCommand(Query, Module1.myconn)
                Command.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
                Using myreader As MySqlDataReader = Command.ExecuteReader()
                    Dim dtSearchResult As New DataTable
                    dtSearchResult.Load(myreader)
                    dgstudents.DataSource = dtSearchResult
                    dgstudents.Font = New Font(dgstudents.Font.FontFamily, 9.5)
                    For Each row As DataGridViewRow In dgstudents.Rows
                        If row.IsNewRow Then Continue For
                        row.Height = 40
                    Next
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Module1.Disconnect_to_DB()
        End Try
    End Sub

    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        Clear_Boxes()
    End Sub

    Private Sub addStudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbcollege.Items.Add("College of Arts and Letters")
        cmbcollege.Items.Add("College of Education")
        cmbcollege.Items.Add("College of Nursing")
        cmbcollege.Items.Add("College of Science")
        cmbcollege.Items.Add("Institute of Physical Education, Sports & Recreation")
        cmbcollege.Items.Add("College of Business Economics and Management")
        cmbcollege.Items.Add("College of Social Sciences and Philosophy")
        cmbcollege.Items.Add("College of Engineering")
        cmbcollege.Items.Add("Graduate School")
        cmbcollege.Items.Add("Open University")
        cmbcollege.Items.Add("Institute of Design and Architecture")
        cmbcollege.Items.Add("Jesse M. Robredo Institute of Good Governance")
        cmbcollege.Items.Add("College of Industrial Technology")
        cmbcollege.Items.Add("Guinobatan Campus")
        cmbcollege.Items.Add("Polangui Campus")
        cmbcollege.Items.Add("Tabaco Campus")
        cmbcollege.Items.Add("Gubat Campus")
        cmbcollege.Items.Add("College of Medicine")
        cmbcollege.Items.Add("College of Law")
        cmbcollege.Items.Add("Externals")
    End Sub

    Private Sub cmbcollege_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcollege.SelectedIndexChanged
        cmbcourse.Items.Clear()

        ' Get the selected college from cmbCollege
        Dim selectedCollege As String = cmbcollege.SelectedItem.ToString()

        ' Populate cmbCourse based on the selected college
        Select Case selectedCollege
            Case "College of Arts and Letters"
                cmbcourse.Items.Add("BA English Language")
                cmbcourse.Items.Add("BA Communication")
                cmbcourse.Items.Add("BA Broadcasting")
                cmbcourse.Items.Add("BA Journalism")
                cmbcourse.Items.Add("B Performing Arts Theater")
                cmbcourse.Items.Add("BA Literature")
            Case "College of Education"
                cmbcourse.Items.Add("B Elemetary Education")
                cmbcourse.Items.Add("B Early Childhood Education")
                cmbcourse.Items.Add("B Secondary Education")
                cmbcourse.Items.Add("B Culture & Arts Education")
            Case "College of Nursing"
                cmbcourse.Items.Add("BS Nursing")
                ' Add more cases as needed for additional colleges
            Case "College of Science"
                cmbcourse.Items.Add("BS Biology")
                cmbcourse.Items.Add("BS Computer Science")
                cmbcourse.Items.Add("BS Information Technology")
                cmbcourse.Items.Add("BS Chemistry")
                cmbcourse.Items.Add("Meteorology")

            Case "Institute of Physical Education, Sports & Recreation"
                cmbcourse.Items.Add("B Physical Education")
                cmbcourse.Items.Add("BS Exercise & Sport Sciences Major in Fitness and Sport Coaching")
                cmbcourse.Items.Add("BS Exercise & Sport Sciences Major in Fitness and Sport Management")

            Case "College of Business Economics and Management"
                cmbcourse.Items.Add("BS Economics")
                cmbcourse.Items.Add("BS Accountancy")
                cmbcourse.Items.Add("BS Entrepreneurship")
                cmbcourse.Items.Add("BS Business Administration Major in Management")
                cmbcourse.Items.Add("BS Business Administration Major in Financial Management")
                cmbcourse.Items.Add("BS Business Administration Major in Human Resource Management")
                cmbcourse.Items.Add("BS Business Administration Major in Marketing Management")
                cmbcourse.Items.Add("BS Business Administration Major in Microfinance")
                cmbcourse.Items.Add("BS Business Administration Major in Operations Management")

            Case "College of Social Sciences and Philosophy"
                cmbcourse.Items.Add("BA Peace Studies")
                cmbcourse.Items.Add("BA Philosophy")
                cmbcourse.Items.Add("BA Sociology")
                cmbcourse.Items.Add("BA Political Science")
                cmbcourse.Items.Add("BA Social Work")
                cmbcourse.Items.Add("BS Psychology")

            Case "College of Engineering"
                cmbcourse.Items.Add("BS Chemical Engineering")
                cmbcourse.Items.Add("BS Civil Engineering")
                cmbcourse.Items.Add("BS Geodetic Engineering")
                cmbcourse.Items.Add("BS Mechanical Engineering")
                cmbcourse.Items.Add("BS Mining Engineering")

            Case "Graduate School"
                cmbcourse.Items.Add("EdD in Educational Leadership & Management")
                cmbcourse.Items.Add("PhD in Educational Foundations")
                cmbcourse.Items.Add("PhD in Mathematics Education")
                cmbcourse.Items.Add("PhD in Filipino")
                cmbcourse.Items.Add("PhD in Development Management")
                cmbcourse.Items.Add("PhD in Public Administration")
                cmbcourse.Items.Add("PhD in Peace and Security Administration")
                cmbcourse.Items.Add("MA in Biology Education")
                cmbcourse.Items.Add("MA in Chemistry Education")
                cmbcourse.Items.Add("MA in Guidance & Counseling")
                cmbcourse.Items.Add("MA in Cultural Education")
                cmbcourse.Items.Add("MA in Educational Leadership & Management")
                cmbcourse.Items.Add("MA in English Education")
                cmbcourse.Items.Add("MA in Filipino Education")
                cmbcourse.Items.Add("MA in General Science Education")
                cmbcourse.Items.Add("MA in Industrial Education Major in Instructional Technology")
                cmbcourse.Items.Add("MA in Industrial Education Major in Teaching TLE")
                cmbcourse.Items.Add("MA in Literature")
                cmbcourse.Items.Add("MA in Mathematics Education")
                cmbcourse.Items.Add("MA in Music Education")
                cmbcourse.Items.Add("MA in Nursing")
                cmbcourse.Items.Add("MA in Peace & Security and Studies")
                cmbcourse.Items.Add("MA in Physical Education")
                cmbcourse.Items.Add("MA in Physics Education")
                cmbcourse.Items.Add("MA in Pre-School Education")
                cmbcourse.Items.Add("MA in Reading Education")
                cmbcourse.Items.Add("MA in Social Studies Education")
                cmbcourse.Items.Add("MS in Architecture")
                cmbcourse.Items.Add("MS in Biology")
                cmbcourse.Items.Add("MS in Sustainable Food Systems")
                cmbcourse.Items.Add("Master in Cooperative Management")
                cmbcourse.Items.Add("Masater in Economics")
                cmbcourse.Items.Add("Master in Entrepreneurship")
                cmbcourse.Items.Add("Master in Entrepreneurship Major in Environmental Entrepreneurship")
                cmbcourse.Items.Add("Master in FIlipino")
                cmbcourse.Items.Add("Master in Information System")
                cmbcourse.Items.Add("Master in Local Government Management")
                cmbcourse.Items.Add("Master in Management")
                cmbcourse.Items.Add("Master in Management Major in Human Resourece Management")
                cmbcourse.Items.Add("Master in Public Administration")
                cmbcourse.Items.Add("Master in Public Administration Major in Health Emergency & Disaster Management")
                cmbcourse.Items.Add("Master in Public Administration Major in Public Procurement")
                cmbcourse.Items.Add("MS in Agriculture Major in Agricultural Education")
                cmbcourse.Items.Add("MS in Agriculture Major in Agronomy")
                cmbcourse.Items.Add("MS in Agriculture Major in Animal Science")
                cmbcourse.Items.Add("MS in Biodiversity & Environmental Management")
                cmbcourse.Items.Add("Master in Rural Development")
                cmbcourse.Items.Add("MS in Fisheries")
                cmbcourse.Items.Add("MS in Fisheries Major in Aquaculture")
                cmbcourse.Items.Add("MS in Fisheries Major in Coastal Resource Management")
                cmbcourse.Items.Add("MS in Fisheries Technology")
                cmbcourse.Items.Add("Diploma in Cultural Education")
                cmbcourse.Items.Add("Diploma in Pre-School Education")

            Case "Open Univeristy"
                cmbcourse.Items.Add("MA Educational Leadership & Management")
                cmbcourse.Items.Add("MA English Education")
                cmbcourse.Items.Add("MA Social Studies Education")
                cmbcourse.Items.Add("M Management")
                cmbcourse.Items.Add("M Public Administration")
                cmbcourse.Items.Add("MA Peace & Studies")
                cmbcourse.Items.Add("M Local Government Management")
                cmbcourse.Items.Add("PhD in Peace and Security Administration")
                cmbcourse.Items.Add("EdD Educational Leadership & Management")

            Case "Institute of Industrial of Design and Architecture"
                cmbcourse.Items.Add("BS Architecture")

            Case "Jesse M. Robredo Institute of Good Governance"
                cmbcourse.Items.Add("B Public Administration")
                cmbcourse.Items.Add("Doctor of Philosophy in Public Administration")

            Case "College of Industrial Technology"
                cmbcourse.Items.Add("B Technical-Vocational Teacher Education")
                cmbcourse.Items.Add("BS Food Technology")
                cmbcourse.Items.Add("BS Electrical Technology")
                cmbcourse.Items.Add("BS Mechanical Technology")
                cmbcourse.Items.Add("BS Automotive Technology")
                cmbcourse.Items.Add("BS Civil Technology")
                cmbcourse.Items.Add("BS Electronics Technology")

            Case "Guinobatan Campus"
                cmbcourse.Items.Add("B Agricultural Technology")
                cmbcourse.Items.Add("B Technical-Vocational Teacher Education")
                cmbcourse.Items.Add("BS Forestry")
                cmbcourse.Items.Add("BS Agriculture")
                cmbcourse.Items.Add("BS AgiBusiness")
                cmbcourse.Items.Add("BS Agricultural and Biosystems Engineering")

            Case "Polangui Campus"
                cmbcourse.Items.Add("B Elemetary Education")
                cmbcourse.Items.Add("B Secondary Education (English & Math)")
                cmbcourse.Items.Add("BS Nursing")
                cmbcourse.Items.Add("BS Information Technology with Specialization in Animation")
                cmbcourse.Items.Add("BS Information Technology")
                cmbcourse.Items.Add("BS Food Technology")
                cmbcourse.Items.Add("BS Entrepreneurship")
                cmbcourse.Items.Add("BS Electronics Technology")
                cmbcourse.Items.Add("Electrical Technology")
                cmbcourse.Items.Add("BS Computer Science")
                cmbcourse.Items.Add("BS Computer Engineering")
                cmbcourse.Items.Add("BS Mechanical Technology")
                cmbcourse.Items.Add("BS Automotive Technology")
                cmbcourse.Items.Add("Bachelor of Technology and Livelihood Education (BTLEd)")

            Case "Tabaco Campus"
                cmbcourse.Items.Add("B Secondary Education")
                cmbcourse.Items.Add("BS Entrepreneurship")
                cmbcourse.Items.Add("BS Food Technology")
                cmbcourse.Items.Add("BS Fisheries")
                cmbcourse.Items.Add("BS Social Work")
                cmbcourse.Items.Add("BS Nursing")

            Case "Gubat Campus"
                cmbcourse.Items.Add("B Agricultural Technology")
                cmbcourse.Items.Add("B Elementary Education")
                cmbcourse.Items.Add("B Secondary Education (Filipino and Social Studies)")

            Case "College of Medicine"
                cmbcourse.Items.Add("Dental Medicine")
                cmbcourse.Items.Add("Medicine")

            Case "College of Law"
                cmbcourse.Items.Add("B of Laws")
            Case "Externals"
                cmbcourse.Items.Add("Technical")
                cmbcourse.Items.Add("Auxiliary")
        End Select
        cmbcourse.SelectedIndex = 0
    End Sub
End Class
