Public Class Attendance
    Dim Student As New Database
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CoursesCombo.SelectedIndex = 0
        'LoadGrid()
    End Sub

    Private Sub LoadGrid()
        Student.ExecuteQuery("Select * from student;")
        If Student.HasException(True) Then Exit Sub
        DataGridAttendance.DataSource = Student.DatabaseTable

    End Sub
End Class