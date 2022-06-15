Public Class Details
    Private tab As New Database
    Private iExit As DialogResult
    Private Sub Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox.Items.Add("---select---")
        ComboBox.Items.Add("Lecturer")
        ComboBox.Items.Add("Student")
        ComboBox.SelectedIndex = 0


        txtDate.Text = ("0" & Today.Day & "-0" & Today.Month & "-" & Today.Year)
        ' txtDate.Text = Today.Year & "-" & Today.Month & "-" & Today.Day

        Dim signin As New Sign_In
        Dim user As String = username
        lblusername.Text = "Welcome " & user
    End Sub

    'button search
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim result As Integer

        'for selected student
        If ComboBox.SelectedItem.Equals("Student") Then
            Try
                TAB.ExecuteQuery("SELECT `student`.`stuID` AS `ID`, `student`.`fName` AS `FIRST NAME`, `student`.`lName` AS `LAST NAME`, `student`.`DoB`,
                            `gender`.`gender` AS `GENDER`,`faculty`.`facultyName` AS `FACULTY`, `department`.`deptName` AS DEPARTMENT, `programme`.`proName` AS `PROGRAMME`, `student`.`phone` AS `PHONE`, `student`.`email` AS `EMAIL`
                            FROM `student` LEFT JOIN `gender`  ON `student`.`genderID` = `gender`.`genderID` 
	                        LEFT JOIN `programme`  ON `student`.`programme` = `programme`.`proID` JOIN `department` ON `programme`.`deptID` = `department`.`deptID` LEFT JOIN `faculty` ON `department`.`facultyID`=`faculty`.`facultyID`
                            WHERE (student.fName Like'" & txtsearch.Text & "' OR student.lName Like'" & txtsearch.Text & "' OR student.stuID Like'" & txtsearch.Text & "');")
                result = TAB.DatabaseTable.Rows.Count
                If result < 1 Then
                    iExit = MessageBox.Show(txtsearch.Text & " " & "Student name not found", "Record Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    DetailsView.DataSource = TAB.DatabaseTable
                    txtsearch.Clear()
                End If

            Catch ex As Exception
                iExit = MessageBox.Show(ex.ToString)
            End Try

        ElseIf ComboBox.SelectedItem.Equals("Lecturer") Then
            Try
                TAB.ExecuteQuery("select lecturer.lecID AS ID, lecturer.fullName AS NAME,lecturer.DoB AS BIRTHDATE,
                          gender.gender AS GENDER,lecturer.phone AS PHONE, lecturer.email AS EMAIL
                          from lecturer JOIN gender ON lecturer.gender=gender.genderID where
                          fullName LIKE '" & txtsearch.Text & "' OR lecID LIKE'" & txtsearch.Text & "';")

                result = TAB.DatabaseTable.Rows.Count
                If result = 0 Then
                    iExit = MessageBox.Show(txtsearch.Text & " " & "Lecturer name not found", "Record Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    DetailsView.DataSource = TAB.DatabaseTable
                    txtsearch.Clear()
                End If

            Catch ex As Exception
                iExit = MessageBox.Show("Sorry! something went wrong ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    'button class
    Private Sub btnClass_Click(sender As Object, e As EventArgs) Handles btnClass.Click
        AddClass.Show()
        Me.Hide()
    End Sub

    'button report
    Private Sub btnGenerateReports_Click(sender As Object, e As EventArgs) Handles btnGenerateReports.Click
        Report.Show()
        Me.Hide()
    End Sub

    'button faculty
    Private Sub btnFaculty_Click(sender As Object, e As EventArgs) Handles btnFaculty.Click
        Faculty.Show()
        Me.Hide()
    End Sub

    'button user
    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Users.Show()
        Me.Hide()
    End Sub

    'student Details
    Private Sub btnStudentDetail_Click(sender As Object, e As EventArgs) Handles btnStudentDetail.Click

    End Sub

    'button attendance
    Private Sub btnStudentAttendance_Click(sender As Object, e As EventArgs) Handles btnStudentAttendance.Click
        Attendance.Show()
        Me.Hide()
    End Sub

    'button dashboard
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        AdminMenu.Show()
        Me.Hide()
    End Sub

    'button lecturer
    Private Sub btnManageLecturers_Click(sender As Object, e As EventArgs) Handles btnManageLecturers.Click
        Lecturers.Show()
        Me.Hide()
    End Sub

    'button student
    Private Sub btnManageStudent_Click(sender As Object, e As EventArgs) Handles btnManageStudent.Click
        Manage_Student.Show()
        Me.Hide()
    End Sub

End Class