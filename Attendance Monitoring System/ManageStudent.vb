Public Class Manage_Student
    Dim tab As New Database
    Dim query As New Database
    Dim iExit As DialogResult

    Dim id, fname, lname, gender, email, phone, program As String
    Dim DoB As Date

    'Update Button
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If txtId.Text = "" Or txtFname.Text = "" Or txtLname.Text = "" Or programmeCombo.SelectedIndex = 0 Or txtDoB.Value.ToString = "" Or txtEmail.Text = "" Or txtPhone.Text = "" Then
            MsgBox("All fields are Required", MsgBoxStyle.Information, "Required fild")

        Else
            If maleRadio.Checked = True Then
                gender = 1
            ElseIf femaleRadio.Checked = True Then
                gender = 2
            Else
                MsgBox("All fields are Required", MsgBoxStyle.Critical)
            End If

            tab.ExecuteQuery("Select * from programme WHERE proName='" & programmeCombo.SelectedItem & "';")
            tab.HasException()

            id = txtId.Text
            fname = txtFname.Text
            lname = txtLname.Text
            MsgBox(gender)
            email = txtEmail.Text
            phone = txtPhone.Text
            program = tab.DatabaseTable(0)(0)


            tab.ExecuteQuery("UPDATE `student` SET `fName` = '" & fname & "', `lName` = '" & lname & "', `DoB` = '" & txtDoB.Text & "',
                            `genderID` = '" & gender & "', `programme` = '" & program & "', `phone` = '" & phone & "', `email` = '" & email & "' WHERE `student`.`stuID` = '" & id & "';")

            iExit = MessageBox.Show("Record Updated Successfull", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tab.HasException()

            updateTable()

        End If
    End Sub

    'on cell clicked
    Private Sub StudentsDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentsDataGrid.CellClick
        Dim selectedGD As DataGridViewRow
        Dim index As Integer
        index = e.RowIndex
        selectedGD = StudentsDataGrid.Rows(index)

        txtId.Text = selectedGD.Cells(0).Value.ToString
        txtFname.Text = selectedGD.Cells(1).Value.ToString
        txtLname.Text = selectedGD.Cells(2).Value.ToString
        txtDoB.Text = selectedGD.Cells(3).Value.ToString
        programmeCombo.Text = selectedGD.Cells(5).Value.ToString
        txtPhone.Text = selectedGD.Cells(6).Value.ToString
        txtEmail.Text = selectedGD.Cells(7).Value.ToString
        If selectedGD.Cells(4).Value.ToString.Equals("male") Then
            maleRadio.Checked = True
        Else
            femaleRadio.Checked = True
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'search button
        Dim result As Integer
        Try
            tab.ExecuteQuery("select student.stuID AS 'STUDENT-ID', student.fName AS 'FIRSTNAME',student.lName AS 'LASTNAME',
                          student.DoB,gender.gender AS GENDER,programme.proName AS PROGRAMME,student.phone AS PHONE,student.email AS EMAIL
                          from student,gender,programme WHERE student.genderID=gender.genderID AND student.programme=programme.proID 
                            AND (fName Like'" & txtsearch.Text & "' OR lName Like'" & txtsearch.Text & "' OR stuID Like'" & txtsearch.Text & "'  OR programme.proName Like'" & txtsearch.Text & "');")
            result = tab.DatabaseTable.Rows.Count
            If result = 0 Then
                iExit = MessageBox.Show(txtsearch.Text & " " & "Do not match Any record", "Record Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                StudentsDataGrid.DataSource = tab.DatabaseTable
                txtsearch.Clear()
            End If

        Catch ex As Exception
            iExit = MessageBox.Show("Failed To Add Record ", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        updateTable()
    End Sub

    Private Sub btnCose_Click(sender As Object, e As EventArgs) Handles btnCose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearInput()
    End Sub

    Private Sub Manage_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadProgrammeComboBox()
        updateTable()
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    'Load gender combobox with Data


    'Load programme combobox with Data
    Sub loadProgrammeComboBox()
        query.ExecuteQuery("SELECT * from programme ;")
        query.HasException()

        programmeCombo.Items.Clear()
        programmeCombo.Items.Add("---Programme---")
        programmeCombo.SelectedIndex = 0

        For i = 0 To query.RecordCount - 1
            Dim x As Integer = 1
            programmeCombo.Items.Add(query.DatabaseTable(i)(x))
        Next
    End Sub

    'delete button
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        tab.ExecuteQuery("DELETE FROM student WHERE stuID='" & txtId.Text & "';")

        iExit = MessageBox.Show("Record Deleted Successfull", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tab.HasException()

        updateTable()
    End Sub

    'Add button
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtId.Text = "" Or txtFname.Text = "" Or txtLname.Text = "" Or txtDoB.Value.ToString = "" Or txtEmail.Text = "" Or txtPhone.Text = "" Or programmeCombo.SelectedIndex = 0 Then
            MsgBox("All fields are Required", MsgBoxStyle.Information, "Required fild")

        Else
            If maleRadio.Checked = True Then
                gender = 1
            ElseIf femaleRadio.Checked = True Then
                gender = 2
            Else
                MsgBox("All fields are Required", MsgBoxStyle.Critical)
            End If

            tab.ExecuteQuery("Select * from programme WHERE proName='" & programmeCombo.SelectedItem & "';")
            tab.HasException()

            id = txtId.Text
            fname = txtFname.Text
            lname = txtLname.Text
            program = tab.DatabaseTable(0)(0)
            MsgBox(program)
            email = txtEmail.Text
            phone = txtPhone.Text


            tab.ExecuteQuery("INSERT INTO `student` (`stuID`, `fName`, `lName`, `DoB`, `genderID`, `programme`, `phone`, `email`)
                               VALUES ('" & id & "', '" & fname & "', '" & lname & "', '" & txtDoB.Text & "', '" & gender & "', '" & program & "', '" & phone & "', '" & email & "');")

            iExit = MessageBox.Show("Record Added Successfull", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tab.HasException()

            updateTable()

            clearInput()
        End If
    End Sub

    'update sub
    Sub updateTable()
        Try
            tab.ExecuteQuery("SELECT `student`.`stuID` AS `ID`, `student`.`fName` AS `fName`, `student`.`lName` AS `LNAme`, `student`.`DoB`,
                            `gender`.`gender` AS `gender`, `programme`.`proName` AS `Programme`, `student`.`phone` AS `Phone`, `student`.`email` AS `Email`
                            FROM `student` AS `student` LEFT JOIN `gender`  ON `student`.`genderID` = `gender`.`genderID` 
	                        LEFT JOIN `programme`  ON `student`.`programme` = `programme`.`proID`;")
            If tab.HasException Then
                MsgBox(tab.exception)
            Else
                StudentsDataGrid.DataSource = tab.DatabaseTable
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Sub clearInput()
        txtDoB.Text = Date.Today.ToShortDateString
        txtEmail.Clear()
        txtFname.Clear()
        txtLname.Clear()
        txtId.Clear()
        txtPhone.Clear()
        programmeCombo.SelectedIndex = 0
        If maleRadio.Checked = True Then
            maleRadio.Checked = False
        Else
            femaleRadio.Checked = False
        End If
    End Sub
End Class