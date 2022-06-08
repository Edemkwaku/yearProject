Public Class Sign_In
    Public user, stuClass As String
    Dim iExit As DialogResult
    Dim sqlQuery As New Database


    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Application.ExitThread()
    End Sub

    Private Sub button_SignIn_Click(sender As Object, e As EventArgs) Handles button_SignIn.Click
        loginCheck()
    End Sub

    Sub loginCheck()
        If txtUsername.Text = "username" Or txtUsername.Text.Equals("") Or txtUserPassword.Text.Equals("") Or txtUserPassword.Text = "password" Then
            iExit = MessageBox.Show("Enter Your Username and password To Login", "Missing field", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else
            If (txtUserPassword.Text.Length < 8) Then
                iExit = MessageBox.Show("password must be atleast 8 characters ", "Password Lenght", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            Else
                Try
                    sqlQuery.ExecuteQuery("select * from users where username LIKE '" & txtUsername.Text & "' AND password LIKE '" & txtUserPassword.Text & "';")
                    Dim result As Integer = sqlQuery.RecordCount
                    Dim role As Integer = sqlQuery.DatabaseTable.Rows(0)(2)
                    stuClass = sqlQuery.DatabaseTable(0)(3).ToString

                    If result = 1 Then
                        user = sqlQuery.DatabaseTable(0)(0)
                        username = user
                        If role = 1 Then
                            Me.Hide()
                            AdminMenu.Show()
                        ElseIf role = 2 Then
                            Me.Hide()
                            Lecturers_Page.Show()
                        Else
                            s_class = stuClass
                            Me.Hide()
                            NornalUserPage.Show()
                        End If
                    Else
                        iExit = MessageBox.Show("Wrong username or password ", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                    txtUsername.Clear()
                    txtUserPassword.Clear()

                Catch ex As Exception
                    iExit = MessageBox.Show(ex.ToString, " ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
        End If
    End Sub

    Private Sub Sign_In_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtforgetpassword_Click(sender As Object, e As EventArgs) Handles txtforgetpassword.Click
        ResetPassword.Show()
        Me.Hide()
    End Sub

End Class