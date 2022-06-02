Imports System.Security.Cryptography
Public Class Users

    ' Dim encrypt As New EncryptAnd_Decrypt()
    Dim query As New Database
    Dim iExit As DialogResult
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    'InsertData button
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        InsertIntoUserTable()
    End Sub


    'Update Button
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateDatabaseRecord()
    End Sub


    'validate input box
    Sub InsertIntoUserTable()
        If txtUsername.Text.Equals(" ") Then
            MessageBox.Show("Username is required ", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtPassword.Text.Equals("") Then
            MessageBox.Show("Password is required ", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Try
                If txtUsername.Text.Length > 20 Then
                    MessageBox.Show("Username can't be more than 20 characters ", "Username Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf txtPassword.Text.Length < 8 Then
                    MessageBox.Show("Password must atleast 8 characters ", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf IsNumeric(txtPassword) Then
                    MessageBox.Show("Password can't be numbers only", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim username As String = txtUsername.Text
                    Dim password As String = txtPassword.Text
                    Dim role As Integer

                    If lectureRule.Checked = True Then
                        role = 2
                    ElseIf studentRole.Checked = True Then
                        role = 3
                    ElseIf AdminRole.Checked = True Then
                        role = 1
                    Else
                        MessageBox.Show("Please select role for User", "Role Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                    Try
                        'check if username already exist
                        query.ExecuteQuery("select * from users where username like '" & username & "';")
                        Dim result As Integer = query.RecordCount

                        If result > 0 Then
                            MsgBox("username is already taken", MsgBoxStyle.Critical, "Username exist")
                        Else
                            'Insert data into User Table
                            query.ExecuteQuery("INSERT INTO users(username,password,role,class) values ('" & username & "','" & password & "','" & role & "','" & studentClass.SelectedItem & "')")

                            MsgBox("Record Inserted Successfully", MsgBoxStyle.Information)

                            'update Table
                            updateTable()
                        End If

                    Catch ex As Exception
                        'Error message
                        MsgBox(ex.ToString)
                    End Try

                End If
            Catch ex As Exception
                MsgBox(ex, MsgBoxStyle.Critical)
            End Try
        End If



    End Sub

    'sub to updating tables
    Sub updateTable()
        query.ExecuteQuery("select users.username AS USERNAME,
                    role.role AS ROLE from users JOIN role ON users.role=role.roleID")
        UsersDataGrid.DataSource = query.DatabaseTable
    End Sub

    'form Onload
    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load user data
        updateTable()

        studentClass.Visible = False
    End Sub


    'sub for database records updates
    Sub UpdateDatabaseRecord()

        If txtUsername.Text.Equals(" ") Then
            MessageBox.Show("Username is required ", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtPassword.Text.Equals("") Then
            MessageBox.Show("Password is required ", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Try
                If txtUsername.Text.Length > 20 Then
                    MessageBox.Show("Username can't be more than 20 characters ", "Username Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf txtPassword.Text.Length < 8 Then
                    MessageBox.Show("Password must atleast 8 characters ", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim username As String = txtUsername.Text
                    Dim password As String = txtPassword.Text
                    Dim role As Integer

                    If lectureRule.Checked = True Then
                        role = 2
                    ElseIf studentRole.Checked = True Then
                        role = 3
                    Else
                        role = 1
                    End If

                    Try

                        'Update data into User Table
                        query.ExecuteQuery("UPDATE users SET username= '" & username & "',
                                            password='" & password & "',role='" & role & "'
                                            WHERE username ='" & txtUsername.Text & "'")

                        query.HasException()

                        MsgBox("Record Updated Successfully", MsgBoxStyle.Information)

                        'update Table
                        updateTable()

                    Catch ex As Exception
                        'Error message
                        query.HasException()
                    End Try

                End If
            Catch ex As Exception
                MsgBox(ex, MsgBoxStyle.Critical)
            End Try
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub studentRole_CheckedChanged(sender As Object, e As EventArgs) Handles studentRole.CheckedChanged
        If CheckState.Checked Then
            studentClass.Visible = True
            loadStydentClass()
        End If
    End Sub

    Private Sub lectureRule_CheckedChanged(sender As Object, e As EventArgs) Handles lectureRule.CheckedChanged
        If CheckState.Checked Then
            studentClass.Visible = False
        End If
    End Sub

    Private Sub AdminRole_CheckedChanged(sender As Object, e As EventArgs) Handles AdminRole.CheckedChanged
        If CheckState.Checked Then
            studentClass.Visible = False
        End If
    End Sub


    Sub loadStydentClass()
        query.ExecuteQuery("SELECT * from class ;")
        query.HasException()

        studentClass.Items.Clear()
        studentClass.Items.Add("---course or class---")
        studentClass.SelectedIndex = 0

        For i = 0 To query.RecordCount - 1
            Dim x As Integer = 1
            studentClass.Items.Add(query.DatabaseTable(i)(x))
        Next
    End Sub


End Class