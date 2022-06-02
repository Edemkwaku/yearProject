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
        dashboard.Visible = False
        Manage_Student.ShowDialog()
    End Sub

    Private Sub ViewAttendance_Button_Click(sender As Object, e As EventArgs)
        dashboard.Visible = False
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
        txtDate.Text = ("0" & Today.Day & "-0" & Today.Month & "-" & Today.Year)
        ' txtDate.Text = Today.Year & "-" & Today.Month & "-" & Today.Day
        studentDetails.Visible = False

        Dim signin As New Sign_In
        Dim user As String = username
        lblusername.Text = "Welcome " & user
        'dashboard.Visible = False

        fetchDataFromDatabase()

        ComboBox.Items.Add("---select---")
        ComboBox.Items.Add("Lecturer")
        ComboBox.Items.Add("Student")
        ComboBox.SelectedIndex = 0

    End Sub

    Private Sub btnManageStudent_Click(sender As Object, e As EventArgs)
        dashboard.Visible = False
        Manage_Student.ShowDialog()
    End Sub

    Private Sub btnViewAttendance_Click(sender As Object, e As EventArgs)
        dashboard.Visible = False
        Lecturers.ShowDialog()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        dashboard.Visible = False
        Users.ShowDialog()
    End Sub

    Private Sub btnDepartment_Click(sender As Object, e As EventArgs) Handles btnDepartment.Click
        dashboard.Visible = False
        Department.ShowDialog()
    End Sub

    Private Sub btnFaculty_Click(sender As Object, e As EventArgs) Handles btnFaculty.Click
        dashboard.Visible = False
        Faculty.ShowDialog()
    End Sub

    Private Sub btnVenue_Click(sender As Object, e As EventArgs) Handles btnVenue.Click
        dashboard.Visible = False
        Venue.ShowDialog()
    End Sub

    Private Sub AdminMenu_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        fetchDataFromDatabase()
        dashboard.Visible = True
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
        dashboard.Visible = False
        Lecturers.ShowDialog()
    End Sub

    'Student Details button
    Private Sub btnManageStudent_Click_2(sender As Object, e As EventArgs) Handles btnManageStudent.Click
        dashboard.Visible = False
        Manage_Student.ShowDialog()
    End Sub

    'Attendance button
    Private Sub btnStudentAttendance_Click_1(sender As Object, e As EventArgs) Handles btnStudentAttendance.Click
        dashboard.Visible = False
        Attendance.ShowDialog()
    End Sub

    'Course button
    Private Sub btnManageCourses_Click_1(sender As Object, e As EventArgs) Handles btnManageCourses.Click
        dashboard.Visible = False
        Courses.ShowDialog()
    End Sub

    'Report button
    Private Sub btnGenerateReports_Click_1(sender As Object, e As EventArgs) Handles btnGenerateReports.Click
        dashboard.Visible = False
        Report.ShowDialog()
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim result As Integer

        'for selected student
        If ComboBox.SelectedItem.Equals("Student") Then
            Try
                tab.ExecuteQuery("SELECT `student`.`stuID` AS `ID`, `student`.`fName` AS `FIRST NAME`, `student`.`lName` AS `LAST NAME`, `student`.`DoB`,
                            `gender`.`gender` AS `GENDER`, `programme`.`proName` AS `PROGRAMME`, `student`.`phone` AS `PHONE`, `student`.`email` AS `EMAIL`
                            FROM `student` LEFT JOIN `gender`  ON `student`.`genderID` = `gender`.`genderID` 
	                        LEFT JOIN `programme`  ON `student`.`programme` = `programme`.`proID`
                            WHERE (student.fName Like'" & txtsearch.Text & "' OR student.lName Like'" & txtsearch.Text & "' OR student.stuID Like'" & txtsearch.Text & "');")
                result = tab.DatabaseTable.Rows.Count
                If result < 1 Then
                    iExit = MessageBox.Show(txtsearch.Text & " " & "Student name not found", "Record Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    DetailsView.DataSource = tab.DatabaseTable
                    txtsearch.Clear()
                End If

            Catch ex As Exception
                iExit = MessageBox.Show(ex.ToString)
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
                iExit = MessageBox.Show("Sorry! something went wrong ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

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
        dashboard.Visible = False
        AddClass.ShowDialog()
    End Sub

    'Dashboard button
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        dashboard.Visible = True
    End Sub

    'panel dashboard
    Private Sub dashboard_Paint(sender As Object, e As PaintEventArgs) Handles dashboard.Paint
        fetchDataFromDatabase()
    End Sub

    'programme button
    Private Sub btnProgramme_Click(sender As Object, e As EventArgs) Handles btnProgramme.Click
        ManageProgrammes.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub StudentPanel_Click(sender As Object, e As EventArgs) Handles StudentPanel.Click
        Manage_Student.Show()
    End Sub

    Private Sub LecturesPanel_Click(sender As Object, e As EventArgs) Handles LecturesPanel.Click
        Lecturers.Show()
    End Sub

    Private Sub DepartmentPanel_Click(sender As Object, e As EventArgs) Handles DepartmentPanel.Click
        Department.Show()
    End Sub

    Private Sub FacultyPanel_Click(sender As Object, e As EventArgs) Handles FacultyPanel.Click
        Faculty.Show()
    End Sub

    Private Sub VenuePanel_Click(sender As Object, e As EventArgs) Handles VenuePanel.Click
        Venue.Show()
    End Sub

    Private Sub CoursesPanel_Click(sender As Object, e As EventArgs) Handles CoursesPanel.Click
        Courses.Show()
    End Sub

    Private Sub ProgrammesPanel_Click(sender As Object, e As EventArgs) Handles ProgrammesPanel.Click
        ManageProgrammes.Show()
    End Sub


    Private Sub dashboard_MouseHover(sender As Object, e As EventArgs) Handles dashboard.MouseHover
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
