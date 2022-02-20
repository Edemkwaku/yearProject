Public Class Sign_In
    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Application.ExitThread()
    End Sub

    Private Sub button_SignIn_Click(sender As Object, e As EventArgs) Handles button_SignIn.Click
        If checkAdmin.Checked = True Then
            AdminMenu.Show()
            Me.Hide()

        ElseIf checkLecturer.Checked = True Then
            Lecturers_Page.Show()
            Me.Hide()
        Else
            NornalUserPage.Show()
            Me.Hide()
        End If

    End Sub
End Class