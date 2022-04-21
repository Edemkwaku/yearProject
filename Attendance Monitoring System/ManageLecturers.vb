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