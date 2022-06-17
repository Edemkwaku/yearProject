Public Class AddClass
    Dim tab As New Database
    Private id, cname, programme As String

    'close button
    Private Sub buttonClose_Click_1(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    'button Add
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtClassID.Text.Equals("") Or txtClassName.Text.Equals("") Or programmeCombo.SelectedIndex = 0 Then
            MsgBox("All fields are required", MsgBoxStyle.Information, "Fileds required")
        Else
            id = txtClassID.Text.ToUpper
            cname = txtClassName.Text.ToUpper
            programme = programmeCombo.SelectedItem

            Try
                tab.ExecuteQuery("select * from class where classID='" & id & "' and className like'" & cname & "'")
                Dim result As Integer = tab.RecordCount
                If result > 0 Then
                    MsgBox("Class already exist", MsgBoxStyle.Critical, "class exist")
                Else
                    tab.ExecuteQuery("select * from programme where proName like '" & programme & "'; ")
                    programme = tab.DatabaseTable(0)(0)

                    tab.ExecuteQuery("insert into class(classID,className,programme) values('" & id & "','" & cname & "','" & programme & "');")
                    If tab.HasException Then
                        tab.exception = "Record Inserting failed "
                        MsgBox(tab.exception, MsgBoxStyle.Critical, "Failed")
                    Else
                        MsgBox("Record inserted Successfully ", MsgBoxStyle.Information, "Record Inserted")
                        updateTable()
                    End If

                End If
            Catch ex As Exception
                MsgBox("Ooops' something went wrong !")
            End Try
        End If

    End Sub

    'load data into programme combobox
    Sub loadProgrammeComboBox()
        TAB.ExecuteQuery("SELECT * from programme ;")
        TAB.HasException()

        programmeCombo.Items.Clear()
        programmeCombo.Items.Add("---programme---")
        programmeCombo.SelectedIndex = 0

        For i = 0 To TAB.RecordCount - 1
            Dim x As Integer = 1
            programmeCombo.Items.Add(TAB.DatabaseTable(i)(x))
        Next
    End Sub

    'on class form load
    Private Sub AddClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
        loadProgrammeComboBox()
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

    'button user
    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Users.Show()
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

    'button dashboard
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        AdminMenu.Show()
        Me.Hide()
    End Sub

    'update button
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim id As String
        Dim classname As String
        Dim programme As String


        If txtClassID.Text = "" Then
            MessageBox.Show("Department ID can't be Empty ", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtClassID.Text.Length > 20 Then
            MessageBox.Show("Department ID can't be more than 20 characters ", "ID length", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtClassName.Text = "" Then
            MessageBox.Show("Department Name can't be Empty ", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtClassName.Text.Length > 50 Then
            MessageBox.Show("Department ID can't be more than 50 characters ", "ID length", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf programmeCombo.SelectedIndex = 0 Then
            MessageBox.Show("Faculty name is Required ", "Faculty name Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try

                tab.ExecuteQuery("SELECT * from programme WHERE proName='" & programmeCombo.SelectedItem & "'")
                If tab.HasException() Then
                    MsgBox(tab.exception)
                Else
                    programme = tab.DatabaseTable(0)(0)
                    id = txtClassID.Text
                    classname = txtClassName.Text


                    tab.ExecuteQuery("UPDATE class SET className='" & classname & "',programme='" & programme & "'
                                     WHERE classID='" & id & "' OR className='" & classname & "'")
                    If tab.HasException() Then
                        MsgBox(tab.exception)
                    Else
                        MessageBox.Show("Record Updated Successfully ", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        updateTable()
                    End If

                End If


            Catch ex As Exception
                'Error message
                tab.exception = "Record Not Updated"
                tab.HasException()
            End Try
        End If

        txtClassName.Clear()
        txtClassID.Clear()
        programmeCombo.SelectedIndex = 0
    End Sub

    'button lecturer
    Private Sub btnManageLecturers_Click(sender As Object, e As EventArgs) Handles btnManageLecturers.Click
        Lecturers.Show()
        Me.Hide()
    End Sub

    'on cell click
    Private Sub CoursesDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CoursesDataGrid.CellClick
        Dim selectedDG As DataGridViewRow
        Dim index As Integer
        index = e.RowIndex
        selectedDG = CoursesDataGrid.Rows(index)
        txtClassID.Text = selectedDG.Cells(0).Value.ToString
        txtClassName.Text = selectedDG.Cells(1).Value.ToString
        programmeCombo.SelectedItem = selectedDG.Cells(2).Value.ToString
    End Sub

    'button clear
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtClassName.Clear()
        txtClassID.Clear()
        programmeCombo.SelectedIndex = 0
    End Sub

    'delete button
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As Integer
        Try
            tab.ExecuteQuery("DELETE FROM `class` WHERE `class`.`classID` ='" & txtClassID.Text & "' 
                            OR `class`.`className` = '" & txtClassName.Text & "';")

            tab.ExecuteQuery("select * from class where classID='" & txtClassID.Text & "';")
            result = tab.RecordCount

            If result > 0 Then
                MessageBox.Show("Record NOT Deleted ", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Record Deleted Successfully ", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                updateTable()
            End If

        Catch ex As Exception
            MessageBox.Show("Record NOT Deleted " + ex.ToString, "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'button department
    Private Sub btnDepartment_Click(sender As Object, e As EventArgs) Handles btnDepartment.Click
        Department.Show()
        Me.Hide()
    End Sub

    'button student
    Private Sub btnManageStudent_Click(sender As Object, e As EventArgs) Handles btnManageStudent.Click
        Manage_Student.Show()
        Me.Hide()
    End Sub


    Sub updateTable()
        tab.ExecuteQuery("select class.classID AS ID,class.className AS CLASS,programme.proName AS PROGRAMME 
                    from class JOIN programme ON class.programme=programme.proID")
        If tab.HasException Then
            MsgBox(tab.exception)
        Else
            CoursesDataGrid.DataSource = tab.DatabaseTable
        End If
    End Sub
End Class