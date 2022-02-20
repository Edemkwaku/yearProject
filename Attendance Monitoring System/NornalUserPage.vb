Public Class NornalUserPage
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.ExitThread()
    End Sub

    Private Sub btnMarkAttendance_Click(sender As Object, e As EventArgs) Handles btnMarkAttendance.Click
        TakeAttendance.ShowDialog()
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        Sign_In.Show()
    End Sub

    Private Sub btnViewAttendance_Click(sender As Object, e As EventArgs) Handles btnViewAttendance.Click
        Attendance.ShowDialog()
    End Sub
End Class