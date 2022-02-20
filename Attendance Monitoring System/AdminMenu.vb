Public Class AdminMenu
    Dim table As New Database
    Dim tab As Database
    Private Sub AddClass_Button_Click(sender As Object, e As EventArgs)
        'AddClass.ShowDialog()
        EmailForm.ShowDialog()
    End Sub

    Private Sub AddStudent_Button_Click(sender As Object, e As EventArgs)
        AddStudent.ShowDialog()
    End Sub

    Private Sub ViewAttendance_Button_Click(sender As Object, e As EventArgs)
        Attendance.ShowDialog()
    End Sub

    Private Sub buttonLogout_Click(sender As Object, e As EventArgs) Handles buttonLogout.Click
        Me.Close()
        Sign_In.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.ExitThread()
    End Sub

    Private Sub AdminMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDate.Text = (Today.Day & "-" & Today.Month & "-" & Today.Year)

        txt_Time.Text = (TimeOfDay.Hour & ":" & TimeOfDay.Minute & ":" & TimeOfDay.Second)

        'creating of table into the database
        table.ExecuteQuery("CREATE TABLE COURSES(
                            courseCode VARCHAR(10) PRIMARY KEY,
                            courseName VARCHAR(20) NOT NULL,
                            duration INT NOT NULL);")
        If table.HasException(True) Then Exit Sub
    End Sub

    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        Report.ShowDialog()
    End Sub

    Private Sub btnManageCourse_Click(sender As Object, e As EventArgs) Handles btnManageCourse.Click
        Courses.ShowDialog()
    End Sub

    Private Sub btnManageStudent_Click(sender As Object, e As EventArgs) Handles btnManageStudent.Click
        Manage_Student.ShowDialog()
    End Sub

    Private Sub btnViewAttendance_Click(sender As Object, e As EventArgs) Handles btnViewAttendance.Click
        Lecturers.ShowDialog()
    End Sub
End Class
