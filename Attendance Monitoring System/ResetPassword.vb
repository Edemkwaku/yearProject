Public Class ResetPassword
    Dim tab As New Database
    Dim iExit As DialogResult

    'on form load
    Private Sub ResetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblpassword.Visible = False
        lblpassconfirm.Visible = False
        txtpassword.Visible = False
        txtpassconfirm.Visible = False
        lblerror.Visible = False
        btnDone.Visible = False
    End Sub

    'continue button
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        If txtusername.Text = "" Then
            txtusername.BorderColor = Color.Red
            MsgBox("username field can't be empty")
        Else
            Try
                tab.ExecuteQuery("select * from users where username LIKE '" & txtusername.Text & "'")
                Dim result As Integer = tab.RecordCount
                username = tab.DatabaseTable.Rows(0)(0)

                If result = 1 Then
                    txtusername.BorderColor = Color.Green
                    txtusername.ForeColor = Color.Green
                    txtusername.Text = username
                    lblpassword.Visible = True
                    txtpassword.Visible = True
                    txtpassconfirm.Visible = True
                    lblpassconfirm.Visible = True
                    btnContinue.Visible = False
                    btnDone.Visible = True
                Else
                    txtusername.BorderColor = Color.Red
                    txtusername.ForeColor = Color.Red
                    txtusername.Text = "wrong username *"
                End If

            Catch ex As Exception
                txtusername.ForeColor = Color.Red
                txtusername.Text = "wrong username *"
            End Try
        End If
    End Sub

    Private Sub txtusername_MouseClick(sender As Object, e As MouseEventArgs) Handles txtusername.MouseClick
        txtusername.ForeColor = Color.Gray
    End Sub

    'done butting
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim user As String = username
        If txtpassword.Text = " " Or txtpassword.Text.Trim("").ToLower.Equals("enternewpassword") Or txtpassconfirm.Text = " " Or txtpassconfirm.Text.Trim.ToLower.Equals("confirmpassword") Then
            lblerror.Visible = True
            MsgBox("All fields are Required")
        ElseIf Not txtpassword.Text.Equals(txtpassconfirm.Text) Then
            iExit = MessageBox.Show("password did not match ", "mismatch password", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try
                tab.ExecuteQuery("UPDATE `users` SET `password` = '" & txtpassword.Text & "' WHERE `users`.`username` = '" & txtusername.Text & "';")
                iExit = MessageBox.Show("Password Reset Successfully", "Password reset", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                iExit = MessageBox.Show("Something went wrong", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        Sign_In.Show()
        Me.Hide()
    End Sub

    'button close
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Hide()
        Sign_In.Show()
    End Sub
End Class