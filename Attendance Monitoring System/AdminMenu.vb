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

        txt_Time.Text = (TimeOfDay)
        Dim signin As New Sign_In
        Dim user As String = username
        lblusername.Text = "Welcome " & user
        'populate Datagrids with data

        fetchDataFromDatabase()
        'DataGridStudent.DataSource = tab.DatabaseTable
    End Sub

    Private Sub btnManageCourse_Click(sender As Object, e As EventArgs)
        Courses.ShowDialog()
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
        Dim signIn As New Sign_In

        'fetch students data
        tab.ExecuteQuery("select student.stuID AS 'STUDENT-ID', concat(student.fName,' ',student.lName) AS NAME,
                          student.DoB,gender.gender AS GENDER,programme.proName AS PROGRAMME,student.phone AS PHONE,student.email AS EMAIL
                          from student,gender,programme WHERE student.genderID=gender.genderID AND student.programme=programme.proID ;")
        If tab.HasException(True) Then Exit Sub
        studentsData.DataSource = tab.DatabaseTable

        'fetch lectures data
        tab.ExecuteQuery("select lecturer.lecID AS ID,lecturer.fullName AS NAME,
                          gender.gender AS GENDER,lecturer.phone AS PHONE, lecturer.email AS EMAIL
                          from lecturer JOIN gender ON lecturer.gender=gender.genderID ;")
        If tab.HasException(True) Then Exit Sub
        LecturersData.DataSource = tab.DatabaseTable

        'fetch and display courses
        tab.ExecuteQuery("select courseID AS CODE,courseName AS COURSE,duration AS CREDIT,start_time AS TIME from course ;")
        If tab.HasException(True) Then Exit Sub
        CoursesData.DataSource = tab.DatabaseTable

        'fetch and display programmes
        tab.ExecuteQuery("select proID as ID, proName as PROGRAMME from programme ;")
        If tab.HasException(True) Then Exit Sub
        'programmesData.DataSource = tab.DatabaseTable

        'fetch and display venues
        tab.ExecuteQuery("select venueID AS ID, venueName AS VENUE from venue ;")
        If tab.HasException(True) Then Exit Sub
        'venueData.DataSource = tab.DatabaseTable


        'fetch and display facultis
        tab.ExecuteQuery("select facultyID AS ID, facultyName AS FACULTY from faculty ;")
        If tab.HasException(True) Then Exit Sub
        facultyData.DataSource = tab.DatabaseTable


        tab.ExecuteQuery("select deptID AS ID, deptName AS FACULTY from department ;")
        If tab.HasException(True) Then Exit Sub
        deptData.DataSource = tab.DatabaseTable

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

    Private Sub btnGenerateReports_Click(sender As Object, e As EventArgs) Handles btnGenerateReports.Click
        Report.ShowDialog()
    End Sub

    Private Sub btnManageCourses_Click(sender As Object, e As EventArgs) Handles btnManageCourses.Click
        Courses.ShowDialog()
    End Sub

    Private Sub btnStudentAttendance_Click(sender As Object, e As EventArgs) Handles btnStudentAttendance.Click
        Attendance.ShowDialog()
    End Sub

    Private Sub btnManageLecturers_Click(sender As Object, e As EventArgs) Handles btnManageLecturers.Click
        Lecturers.ShowDialog()
    End Sub

    Private Sub btnManageStudent_Click_1(sender As Object, e As EventArgs) Handles btnManageStudent.Click
        Manage_Student.ShowDialog()
    End Sub


    Private Sub Panel5_MouseHover(sender As Object, e As EventArgs) Handles Panel5.MouseHover
        fetchDataFromDatabase()
    End Sub

    Private Sub Panel8_Click(sender As Object, e As EventArgs) Handles Panel8.Click, Panel7.Click, Panel14.Click, Panel11.Click, Panel10.Click
        fetchDataFromDatabase()
    End Sub

    Private Sub Panel8_MouseHover(sender As Object, e As EventArgs) Handles Panel8.MouseHover
        fetchDataFromDatabase()
    End Sub

    Private Sub buttonLogout_Click_1(sender As Object, e As EventArgs) Handles buttonLogout.Click
        Me.Hide()
        Sign_In.Show()

    End Sub
End Class
