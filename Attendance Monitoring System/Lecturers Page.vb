Public Class Lecturers_Page
    Dim tab As New Database
    Dim iExit As DialogResult

    'mark attendance button
    Private Sub btnMarkAttendance_Click(sender As Object, e As EventArgs) Handles btnMarkAttendance.Click
        TakeAttendance.ShowDialog()

    End Sub
    'view attendance button
    Private Sub btnViewAttendance_Click(sender As Object, e As EventArgs) Handles btnViewAttendance.Click
        Attendance.ShowDialog()
    End Sub

    'logout button
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        Sign_In.Show()
    End Sub

    'close button
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.ExitThread()
    End Sub

    'report buttom
    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        Report.ShowDialog()
    End Sub

    'form load
    Private Sub Lecturers_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim signin As New Sign_In
        Dim user As String = username
        lname.Text = "Welcome  " & user
        txtDate.Text = ("0" & Today.Day & "-0" & Today.Month & "-" & Today.Year)
        studentDetails.Visible = False

        ComboBox.Items.Add("---select---")
        ComboBox.Items.Add("Lecturer")
        ComboBox.Items.Add("Student")
        ComboBox.SelectedIndex = 0
    End Sub

    'student details button
    Private Sub btnStudentDetails_Click(sender As Object, e As EventArgs) Handles btnStudentDetails.Click
        studentDetails.Visible = True
    End Sub


    'search button
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim result As Integer

        'if student is selected
        If ComboBox.SelectedItem.Equals("Student") Then
            Try
                tab.ExecuteQuery("select student.stuID AS 'ID', student.fName AS 'FIRSTNAME',student.lName AS 'LASTNAME',
                          student.DoB,gender.gender AS GENDER,programme.proName AS PROGRAMME,student.phone AS PHONE,student.email AS EMAIL
                          from student,gender,programme WHERE student.genderID=gender.genderID AND student.programme=programme.proID 
                            AND (fName Like'" & txtsearch.Text & "' OR lName Like'" & txtsearch.Text & "' OR stuID Like'" & txtsearch.Text & "');")
                result = tab.DatabaseTable.Rows.Count
                If result = 0 Then
                    iExit = MessageBox.Show(txtsearch.Text & " " & "Student name not found", "Record Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    DetailsView.DataSource = tab.DatabaseTable
                    txtsearch.Clear()
                End If

            Catch ex As Exception
                iExit = MessageBox.Show("Record NOT found ", "Record Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            'if lecturer is selected
        ElseIf ComboBox.SelectedItem.Equals("Lecturer") Then
            Try
                tab.ExecuteQuery("select lecturer.lecID AS ID, lecturer.fullName AS NAME,lecturer.DoB AS BIRTHDATE,
                          gender.gender AS GENDER,lecturer.phone AS PHONE, lecturer.email AS EMAIL
                          from lecturer JOIN gender ON lecturer.gender=gender.genderID where
                          fullName LIKE '" & txtsearch.Text & "' OR lecID LIKE'" & txtsearch.Text & "';")

                result = tab.DatabaseTable.Rows.Count
                If result = 0 Then
                    iExit = MessageBox.Show(txtsearch.Text & " " & "Lecturer name not found", "Record Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    DetailsView.DataSource = tab.DatabaseTable
                    txtsearch.Clear()
                End If

            Catch ex As Exception
                iExit = MessageBox.Show("Record NOT found ", "Record Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    'close button
    Private Sub btnCose_Click(sender As Object, e As EventArgs) Handles btnCose.Click
        studentDetails.Visible = False
    End Sub

    Private Sub studentDetails_Paint(sender As Object, e As PaintEventArgs) Handles studentDetails.Paint

    End Sub
End Class