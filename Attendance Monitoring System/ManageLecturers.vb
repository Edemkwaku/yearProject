Imports Guna.UI2.WinForms.Guna2DataGridView
Public Class Lecturers
    Dim id, fname, lname, gender, email, phone As String
    Dim DoB As Date
    Dim tab As New Database
    Dim iExit As DialogResult



    Private Sub LecturersDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LecturersDataGrid.CellClick
        Dim selectedGD As DataGridViewRow
        Dim index As Integer
        index = e.RowIndex
        selectedGD = LecturersDataGrid.Rows(index)

        txtId.Text = selectedGD.Cells(0).Value.ToString
        txtFname.Text = selectedGD.Cells(1).Value.ToString
        txtDoB.Text = selectedGD.Cells(2).Value.ToString
        txtEmail.Text = selectedGD.Cells(5).Value.ToString
        txtPhone.Text = selectedGD.Cells(4).Value.ToString
        If selectedGD.Cells(3).Value.ToString.Equals("male") Then
            maleRadio.Checked = True
        Else
            femaleRadio.Checked = True
        End If
    End Sub

    'refresh button
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs)
        updateTable()
    End Sub

    'email text box
    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim a As String
        Dim count As Integer = 0
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            email = txtEmail.Text
            If (email.Contains("@") = False Or email.Contains(".") = False) Then
                MsgBox("Enter valid Email", MsgBoxStyle.Information, "Error")
                txtEmail.Clear()
            Else
                For x = 0 To email.Length - 1
                    a = email.Substring(x, 1)
                    If a.Equals("@") Then
                        count += 1
                    End If
                Next
                If count > 1 Then
                    MsgBox("Invalid Email format", MsgBoxStyle.Information, "Error")
                    txtEmail.Clear()
                End If
            End If

        End If
    End Sub

    'phone number validation
    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then

        End If
    End Sub

    'clear button 
    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        clear()
    End Sub

    'clear button sub 
    Sub clear()
        txtPhone.Clear()
        txtId.Clear()
        txtFname.Clear()
        txtEmail.Clear()
        txtDoB.Text = Today.Date
        txtsearch.Clear()
        maleRadio.Checked = False
        femaleRadio.Checked = False
    End Sub

    'button dashboard
    Private Sub Dashboard_Click(sender As Object, e As EventArgs) Handles Dashboard.Click
        AdminMenu.Show()
        Me.Hide()
    End Sub



    'button update
    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtId.Text = "" Or txtFname.Text = "" Or txtDoB.Value.ToString = "" Or txtEmail.Text = "" Or txtPhone.Text = "" Then
            MsgBox("All fields are Required", MsgBoxStyle.Information, "Required fild")

        Else
            If maleRadio.Checked = True Then
                gender = 1
            ElseIf femaleRadio.Checked = True Then
                gender = 2
            Else
                MsgBox("All fields are Required", MsgBoxStyle.Critical)
            End If

            id = txtId.Text
            fname = txtFname.Text
            email = txtEmail.Text
            phone = txtPhone.Text

            Try
                tab.ExecuteQuery("Update `lecturer` SET `fullName` = '" & fname & "',`DoB` = '" & txtDoB.Text & "', `email` = '" & email & "', `gender` = '" & gender & "', `phone` = '" & phone & "' WHERE `lecturer`.`lecID` = '" & id & "';")
                iExit = MessageBox.Show("Record Updated Successfull", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Information)

                updateTable()

            Catch ex As Exception
                MsgBox("Record update failed" & ex.ToString)
            End Try

        End If
        clear()
    End Sub

    'button clear
    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    'button delete
    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        tab.ExecuteQuery("DELETE FROM lecturer WHERE lecID='" & txtId.Text & "';")

        If (tab.HasException) Then
            MsgBox(tab.exception)
        Else
            iExit = MessageBox.Show("Record Deleted Successfull", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
            updateTable()
        End If

        clear()
    End Sub

    'button refresh
    Private Sub btnRefresh_Click_1(sender As Object, e As EventArgs) Handles btnRefresh.Click
        updateTable()
    End Sub

    'button student
    Private Sub btnManageStudent_Click(sender As Object, e As EventArgs) Handles btnManageStudent.Click
        Manage_Student.Show()
        Me.Hide()
    End Sub

    'button courses
    Private Sub btnManageCourses_Click(sender As Object, e As EventArgs) Handles btnManageCourses.Click
        Courses.Show()
        Me.Hide()
    End Sub

    'button search
    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim result As Integer
        Try
            tab.ExecuteQuery("select lecturer.lecID AS ID, lecturer.fullName AS NAME,lecturer.DoB AS BIRTHDATE,
                          gender.gender AS GENDER,lecturer.phone AS PHONE, lecturer.email AS EMAIL
                          from lecturer JOIN gender ON lecturer.gender=gender.genderID where
                          fullName LIKE '" & txtsearch.Text & "' OR lecID LIKE'" & txtsearch.Text & "';")
            result = tab.DatabaseTable.Rows.Count
            If result = 0 Then
                iExit = MessageBox.Show(txtsearch.Text & " " & "Do not match Any record", "Record Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                LecturersDataGrid.DataSource = tab.DatabaseTable
                txtsearch.Clear()
            End If

        Catch ex As Exception
            iExit = MessageBox.Show("Failed To Add Record ", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'button add
    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtId.Text = "" Or txtFname.Text = "" Or txtDoB.Value.ToString = "" Or txtEmail.Text = "" Or txtPhone.Text = "" Then
            MsgBox("All fields are Required", MsgBoxStyle.Information, "Required fild")
        ElseIf IsNumeric(txtPhone.Text) = False Then
            MsgBox("Only numbers Accepted", MsgBoxStyle.Information, "Error")
            txtPhone.Clear()
        ElseIf Len(Trim(txtPhone.Text)) <> 10 Then
            MsgBox("Only 10 digits Allowed", MsgBoxStyle.Critical, "Error")
        ElseIf Not txtPhone.Text.StartsWith(0) Then
            MsgBox("Phone number should start with 0 ", MsgBoxStyle.Critical, "Error")
            txtPhone.Clear()

        Else
            If maleRadio.Checked = True Then
                gender = 1
            ElseIf femaleRadio.Checked = True Then
                gender = 2
            Else
                MsgBox("All fields are Required", MsgBoxStyle.Critical)
            End If

            id = txtId.Text
            fname = txtFname.Text
            MsgBox(gender)
            email = txtEmail.Text
            phone = txtPhone.Text


            tab.ExecuteQuery("INSERT INTO `lecturer` (`lecID`, `fullName`,`DoB`,
                                `email`, `gender`, `phone`) VALUES('" & id & "','" & fname & "',
                                '" & txtDoB.Text & "','" & email & "','" & gender & "','" & phone & "');")

            iExit = MessageBox.Show("Record Added Successfull", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tab.HasException()

            updateTable()

        End If
        clear()
    End Sub

    'Close button
    Private Sub btnCose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    'button user
    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Users.Show()
        Me.Hide()
    End Sub

    Private Sub Lecturers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDate.Text = ("0" & Today.Day & "-0" & Today.Month & "-" & Today.Year)
        ' txtDate.Text = Today.Year & "-" & Today.Month & "-" & Today.Day

        Dim signin As New Sign_In
        Dim user As String = username
        lblusername.Text = "Welcome " & user

        'fetch lectures data
        updateTable()

        'loadGenderComboBox()
    End Sub


    'button class
    Private Sub btnClass_Click(sender As Object, e As EventArgs) Handles btnClass.Click
        AddClass.Show()
        Me.Hide()
    End Sub

    'button report
    Private Sub btnGenerateReports_Click(sender As Object, e As EventArgs) Handles btnGenerateReports.Click
        Report.ShowDialog()
    End Sub

    'button faculty
    Private Sub btnFaculty_Click(sender As Object, e As EventArgs) Handles btnFaculty.Click
        Faculty.Show()
        Me.Hide()
    End Sub

    'button venue
    Private Sub btnVenue_Click(sender As Object, e As EventArgs) Handles btnVenue.Click
        Venue.Show()
        Me.Hide()
    End Sub

    'student Details
    Private Sub btnStudentDetail_Click(sender As Object, e As EventArgs) Handles btnStudentDetail.Click

    End Sub

    'button attendance
    Private Sub btnStudentAttendance_Click(sender As Object, e As EventArgs) Handles btnStudentAttendance.Click
        Attendance.Show()
        Me.Hide()
    End Sub


    'update sub
    Sub updateTable()
        tab.ExecuteQuery("select lecturer.lecID AS ID, lecturer.fullName AS NAME,lecturer.DoB AS BIRTHDATE,
                          gender.gender AS GENDER,lecturer.phone AS PHONE, lecturer.email AS EMAIL
                          from lecturer JOIN gender ON lecturer.gender=gender.genderID ;")
        If tab.HasException(True) Then Exit Sub
        LecturersDataGrid.DataSource = tab.DatabaseTable
    End Sub


End Class