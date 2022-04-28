Imports Guna.UI2.WinForms.Guna2DataGridView
Public Class Lecturers
    Dim id, fname, lname, gender, email, phone As String
    Dim DoB As Date
    Dim tab As New Database
    Dim iExit As DialogResult

    'Delete button
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        tab.ExecuteQuery("DELETE FROM lecturer WHERE lecID='" & txtId.Text & "';")

        iExit = MessageBox.Show("Record Deleted Successfull", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tab.HasException()

        updateTable()
        clear()
    End Sub

    'Update Button
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
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
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
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
    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then

        End If
    End Sub

    'clear button 
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
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

    'search button
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
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

    'Close button
    Private Sub btnCose_Click(sender As Object, e As EventArgs) Handles btnCose.Click
        Me.Close()
    End Sub

    Private Sub Lecturers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fetch lectures data
        updateTable()

        'loadGenderComboBox()
    End Sub

    'Add record button
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

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

    'update sub
    Sub updateTable()
        tab.ExecuteQuery("select lecturer.lecID AS ID, lecturer.fullName AS NAME,lecturer.DoB AS BIRTHDATE,
                          gender.gender AS GENDER,lecturer.phone AS PHONE, lecturer.email AS EMAIL
                          from lecturer JOIN gender ON lecturer.gender=gender.genderID ;")
        If tab.HasException(True) Then Exit Sub
        LecturersDataGrid.DataSource = tab.DatabaseTable
    End Sub


End Class