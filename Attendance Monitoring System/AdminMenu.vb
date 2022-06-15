Imports System.IO
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
        Manage_Student.Show()
        Me.Hide()
    End Sub

    Private Sub ViewAttendance_Button_Click(sender As Object, e As EventArgs)
        Attendance.Show()
        Me.Hide()
    End Sub

    Private Sub buttonLogout_Click(sender As Object, e As EventArgs)
        Me.Close()
        Sign_In.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Application.ExitThread()
    End Sub

    Private Sub AdminMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDate.Text = ("0" & Today.Day & "-0" & Today.Month & "-" & Today.Year)
        ' txtDate.Text = Today.Year & "-" & Today.Month & "-" & Today.Day
        studentDetails.Visible = False

        Dim signin As New Sign_In
        Dim user As String = username
        lblusername.Text = "Welcome " & user
        'dashboard.Visible = False

        fetchDataFromDatabase()

    End Sub

    Private Sub btnManageStudent_Click(sender As Object, e As EventArgs)
        Manage_Student.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewAttendance_Click(sender As Object, e As EventArgs)
        Lecturers.Show()
        Me.Hide()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Users.Show()
        Me.Hide()
    End Sub

    Private Sub btnDepartment_Click(sender As Object, e As EventArgs) Handles btnDepartment.Click
        Department.Show()
        Me.Hide()
    End Sub

    Private Sub btnFaculty_Click(sender As Object, e As EventArgs) Handles btnFaculty.Click
        Faculty.Show()
        Me.Hide()
    End Sub

    Private Sub btnVenue_Click(sender As Object, e As EventArgs) Handles btnVenue.Click
        Venue.Show()
        Me.Hide()
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
        tab.ExecuteQuery("select * from venue ;")
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
        Lecturers.Show()
        Me.Hide()
    End Sub

    'Student Details button
    Private Sub btnManageStudent_Click_2(sender As Object, e As EventArgs) Handles btnManageStudent.Click
        Manage_Student.Show()
        Me.Hide()
    End Sub

    'Attendance button
    Private Sub btnStudentAttendance_Click_1(sender As Object, e As EventArgs) Handles btnStudentAttendance.Click
        Attendance.ShowDialog()
    End Sub

    'Course button
    Private Sub btnManageCourses_Click_1(sender As Object, e As EventArgs) Handles btnManageCourses.Click
        Courses.Show()
        Me.Hide()
    End Sub

    'Report button
    Private Sub btnGenerateReports_Click_1(sender As Object, e As EventArgs) Handles btnGenerateReports.Click
        Report.Show()
        Me.Hide()
    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

    End Sub

    'student details button
    Private Sub btnStudentDetail_Click(sender As Object, e As EventArgs) Handles btnStudentDetail.Click
        studentDetails.Visible = True
    End Sub

    'close button
    Private Sub btnCose_Click(sender As Object, e As EventArgs) Handles btnCose.Click
        studentDetails.Visible = False
    End Sub

    'Class button
    Private Sub btnClass_Click(sender As Object, e As EventArgs) Handles btnClass.Click
        AddClass.Show()
        Me.Hide()
    End Sub

    'panel dashboard
    Private Sub dashboard_Paint(sender As Object, e As PaintEventArgs)
        fetchDataFromDatabase()
    End Sub

    'programme button
    Private Sub btnProgramme_Click(sender As Object, e As EventArgs) Handles btnProgramme.Click
        ManageProgrammes.Show()
        Me.Hide()
    End Sub

    Private Sub StudentPanel_Click(sender As Object, e As EventArgs)
        Manage_Student.Show()
    End Sub

    Private Sub LecturesPanel_Click(sender As Object, e As EventArgs)
        Lecturers.Show()
    End Sub

    Private Sub DepartmentPanel_Click(sender As Object, e As EventArgs)
        Department.Show()
    End Sub

    Private Sub FacultyPanel_Click(sender As Object, e As EventArgs)
        Faculty.Show()
    End Sub

    Private Sub VenuePanel_Click(sender As Object, e As EventArgs)
        Venue.Show()
    End Sub

    Private Sub CoursesPanel_Click(sender As Object, e As EventArgs)
        Courses.Show()
    End Sub

    Private Sub ProgrammesPanel_Click(sender As Object, e As EventArgs)
        ManageProgrammes.Show()
    End Sub


    Private Sub dashboard_MouseHover(sender As Object, e As EventArgs)
        fetchDataFromDatabase()
    End Sub

    'Retore data
    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        Using myProcess As New Process()
            myProcess.StartInfo.FileName = "cmd.exe"

            myProcess.StartInfo.UseShellExecute = False

            myProcess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin\"

            myProcess.StartInfo.RedirectStandardInput = True

            myProcess.StartInfo.RedirectStandardOutput = True

            myProcess.Start()

            Dim myStreamWriter As StreamWriter = myProcess.StandardInput

            Dim mystreamreader As StreamReader = myProcess.StandardOutput

            myStreamWriter.WriteLine("mysql -u root -pPASSWORD "" < C:\xampp\mysql\database backup\backup.sql")

            myStreamWriter.Close()

            myProcess.WaitForExit()

            myProcess.Close()

        End Using
    End Sub
End Class
