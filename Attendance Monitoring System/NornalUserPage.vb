Public Class NornalUserPage

    'close button
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.ExitThread()
    End Sub

    'Mark attendance button
    Private Sub btnMarkAttendance_Click(sender As Object, e As EventArgs) Handles btnMarkAttendance.Click
        TakeAttendance.ShowDialog()
    End Sub

    'logout button
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Sign_In.Show()
    End Sub

    'view attendance button
    Private Sub btnViewAttendance_Click(sender As Object, e As EventArgs) Handles btnViewAttendance.Click
        Attendance.ShowDialog()
    End Sub

    'on form load
    Private Sub NornalUserPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim signin As New Sign_In
        Dim user As String = username
        lblusername.Text = "Welcome  " & user


        txtDate.Text = (Today.Day & "-0" & Today.Month & "-" & Today.Year)


    End Sub
End Class