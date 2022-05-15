Imports MySql.Data.MySqlClient
Public Class AdminMenu
    Dim table As New Database
    Dim tab As New Database
    Dim iExit As DialogResult
    Private Sub AddClass_Button_Click(sender As Object, e As EventArgs)
        'AddClass.ShowDialog()
        EmailForm.ShowDialog()
    End Sub

    Private Sub AddStudent_Button_Click(sender As Object, e As EventArgs)
        Manage_Student.ShowDialog()
    End Sub

    Private Sub ViewAttendance_Button_Click(sender As Object, e As EventArgs)
        Attendance.ShowDialog()
    End Sub

    Private Sub buttonLogout_Click(sender As Object, e As EventArgs)
        Me.Close()
        Sign_In.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Application.ExitThread()
    End Sub

    Private Sub AdminMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDate.Text = (Today.Day & "-" & Today.Month & "-" & Today.Year)
        studentDetails.Visible = False
        txt_Time.Text = (TimeOfDay)
        Dim signin As New Sign_In
        Dim user As String = username
        lblusername.Text = "Welcome " & user


        fetchDataFromDatabase()

        ComboBox.Items.Add("---select---")
        ComboBox.Items.Add("Lecturer")
        ComboBox.Items.Add("Student")
        ComboBox.SelectedIndex = 0

    End Sub

    Private Sub btnManageStudent_Click(sender As Object, e As EventArgs)
        Manage_Student.ShowDialog()
    End Sub

    Private Sub btnViewAttendance_Click(sender As Object, e As EventArgs)
        Lecturers.ShowDialog()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Users.ShowDialog()
    End Sub

    Private Sub btnDepartment_Click(sender As Object, e As EventArgs) Handles btnDepartment.Click
        Department.ShowDialog()
    End Sub

    Private Sub btnFaculty_Click(sender As Object, e As EventArgs) Handles btnFaculty.Click
        Faculty.ShowDialog()
    End Sub

    Private Sub btnVenue_Click(sender As Object, e As EventArgs) Handles btnVenue.Click
        Venue.ShowDialog()
    End Sub

    Private Sub AdminMenu_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        fetchDataFromDatabase()
    End Sub



    'Fetch Data From Database
    Sub fetchDataFromDatabase()

        'count students 
        tab.ExecuteQuery("select * from student;")
        student.Text = tab.RecordCount

        'count lectures
        tab.ExecuteQuery("select * from lecturer;")
        lectures.Text = tab.RecordCount

        'count courses
        tab.ExecuteQuery("select * from course ;")
        course.Text = tab.RecordCount

        'count programmes
        tab.ExecuteQuery("select * from programme ;")
        programmes.Text = tab.RecordCount


        'count venues
        tab.ExecuteQuery("select count(venueID) from venue ;")
        venues.Text = tab.RecordCount

        'count faculties
        tab.ExecuteQuery("select * from faculty ;")
        faculties.Text = tab.RecordCount

        'count department
        tab.ExecuteQuery("select * from department ;")
        departments.Text = tab.RecordCount

    End Sub

    'Close Button
    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        iExit = MessageBox.Show("Are sure you want to Exit the Application ",
                                "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If iExit = DialogResult.Yes Then
            Application.ExitThread()
        End If

    End Sub

    'Window restore button
    Private Sub btnRestoreWindowState_Click_1(sender As Object, e As EventArgs) Handles btnRestoreWindowState.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    'Window Minimized Button
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Logout button
    Private Sub buttonLogout_Click_1(sender As Object, e As EventArgs) Handles buttonLogout.Click
        Me.Hide()
        Sign_In.Show()

    End Sub

    'Lecture button
    Private Sub btnManageLecturers_Click_1(sender As Object, e As EventArgs) Handles btnManageLecturers.Click
        Lecturers.ShowDialog()
    End Sub

    'Student Details button
    Private Sub btnManageStudent_Click_2(sender As Object, e As EventArgs) Handles btnManageStudent.Click
        Manage_Student.ShowDialog()
    End Sub

    'Attendance button
    Private Sub btnStudentAttendance_Click_1(sender As Object, e As EventArgs) Handles btnStudentAttendance.Click
        Attendance.ShowDialog()
    End Sub

    'Course button
    Private Sub btnManageCourses_Click_1(sender As Object, e As EventArgs) Handles btnManageCourses.Click
        Courses.ShowDialog()
    End Sub

    'Report button
    Private Sub btnGenerateReports_Click_1(sender As Object, e As EventArgs) Handles btnGenerateReports.Click
        Report.ShowDialog()
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Dim path As String = "C:\Backup.sql"
        Dim cmd = New MySqlCommand()


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim result As Integer

        'for selected student
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

    Private Sub btnStudentDetail_Click(sender As Object, e As EventArgs) Handles btnStudentDetail.Click
        studentDetails.Visible = True
    End Sub

    Private Sub btnCose_Click(sender As Object, e As EventArgs) Handles btnCose.Click
        studentDetails.Visible = False
    End Sub

End Class
