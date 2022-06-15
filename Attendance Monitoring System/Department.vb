Public Class Department
    Dim query As New Database
    Dim iExit As DialogResult

    'form load
    Private Sub Department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDate.Text = ("0" & Today.Day & "-0" & Today.Month & "-" & Today.Year)
        ' txtDate.Text = Today.Year & "-" & Today.Month & "-" & Today.Day


        Dim signin As New Sign_In
        Dim user As String = username
        lblusername.Text = "Welcome " & user
        loadFacultyComboBox()
        updateTable()
    End Sub

    'button dashboard
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        AdminMenu.Show()
        Me.Hide()
    End Sub

    'button lecturer
    Private Sub btnManageLecturers_Click(sender As Object, e As EventArgs) Handles btnManageLecturers.Click
        Lecturers.Show()
        Me.Hide()
    End Sub

    'button students
    Private Sub btnManageStudent_Click(sender As Object, e As EventArgs) Handles btnManageStudent.Click
        Manage_Student.Show()
        Me.Hide()
    End Sub

    'button course
    Private Sub btnManageCourses_Click(sender As Object, e As EventArgs) Handles btnManageCourses.Click
        Courses.Show()
        Me.Hide()
    End Sub


    'load data into faculty combobox
    Sub loadFacultyComboBox()
        query.ExecuteQuery("SELECT * from faculty ;")
        query.HasException()

        FacultyCombo.Items.Clear()
        FacultyCombo.Items.Add("  ----Select Faculty----")
        FacultyCombo.SelectedIndex = 0

        For i = 0 To query.RecordCount - 1
            Dim x As Integer = 1
            FacultyCombo.Items.Add(query.DatabaseTable(i)(x))
        Next
    End Sub

    'sub to updating tables
    Sub updateTable(queryString As String)
        query.ExecuteQuery(queryString)
        DepartmentData.DataSource = query.DatabaseTable
    End Sub

    'button user
    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Users.Show()
        Me.Hide()
    End Sub

    'oncell click
    Private Sub DepartmentData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DepartmentData.CellClick
        Dim selectedDG As New DataGridViewRow
        Dim index As Integer
        index = e.RowIndex
        selectedDG = DepartmentData.Rows(index)
        txtDeptID.Text = selectedDG.Cells(0).Value.ToString
        txtDeptName.Text = selectedDG.Cells(1).Value.ToString
        FacultyCombo.Text = selectedDG.Cells(2).Value.ToString
    End Sub

    'search button
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim result As Integer
        Try
            query.ExecuteQuery("select department.deptID as ID,department.deptName as DEPARTMENT,faculty.facultyName FACULTY 
                    from department JOIN faculty ON department.facultyID=faculty.facultyID where
                    (deptID Like'" & txtsearch.Text & "' OR deptName Like'" & txtsearch.Text & "');")
            result = query.DatabaseTable.Rows.Count
            If result = 0 Then
                iExit = MessageBox.Show(txtsearch.Text & " " & "Do not match Any record", "Record Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                DepartmentData.DataSource = query.DatabaseTable
                txtsearch.Clear()
            End If

        Catch ex As Exception
            iExit = MessageBox.Show("Failed To Add Record ", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'button refresh
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        updateTable()
    End Sub


    'update table sub
    Sub updateTable()
        query.ExecuteQuery("select department.deptID as ID,department.deptName as DEPARTMENT,faculty.facultyName FACULTY 
                    from department JOIN faculty ON department.facultyID=faculty.facultyID")
        DepartmentData.DataSource = query.DatabaseTable
    End Sub

    'button delete
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As Integer
        Try
            query.ExecuteQuery("DELETE FROM `department` WHERE `department`.`deptID` ='" & txtDeptID.Text & "' 
                            OR `department`.`deptName` = '" & txtDeptName.Text & "';")

            query.ExecuteQuery("select * from department where deptID='" & txtDeptID.Text & "';")
            result = query.RecordCount

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

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDeptName.Clear()
        txtDeptID.Clear()
        FacultyCombo.SelectedIndex = 0
    End Sub

    'button update
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim id As String
        Dim deptname As String
        Dim faculty As String


        If txtDeptID.Text = "" Then
            MessageBox.Show("Department ID can't be Empty ", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtDeptID.Text.Length > 20 Then
            MessageBox.Show("Department ID can't be more than 20 characters ", "ID length", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtDeptName.Text = "" Then
            MessageBox.Show("Department Name can't be Empty ", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtDeptName.Text.Length > 50 Then
            MessageBox.Show("Department ID can't be more than 50 characters ", "ID length", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf FacultyCombo.SelectedIndex = 0 Then
            MessageBox.Show("Faculty name is Required ", "Faculty name Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try

                query.ExecuteQuery("SELECT * from faculty WHERE facultyName='" & FacultyCombo.SelectedItem & "'")
                query.HasException()

                id = txtDeptID.Text
                deptname = txtDeptName.Text
                faculty = query.DatabaseTable(0)(0)

                query.ExecuteQuery("UPDATE department SET  deptID='" & id & "', 
                                    deptName='" & deptname & "',facultyID='" & faculty & "'
                                     WHERE deptID='" & id & "' OR deptName='" & deptname & "'")
                query.HasException()

                MessageBox.Show("Record Updated Successfully ", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Information)

                updateTable("select department.deptID as ID,department.deptName as DEPARTMENT,faculty.facultyName FACULTY 
                    from department JOIN faculty ON department.facultyID=faculty.facultyID")

            Catch ex As Exception
                'Error message
                query.exception = "Record Not Updated"
                query.HasException()
            End Try
        End If

        txtDeptName.Clear()
        txtDeptID.Clear()
        FacultyCombo.SelectedIndex = 0
    End Sub

    'button add
    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim id As String
        Dim deptname As String
        Dim faculty As String



        query.ExecuteQuery("SELECT * from faculty WHERE facultyName='" & FacultyCombo.SelectedItem & "'")
        query.HasException()

        If txtDeptID.Text = "" Then
            MessageBox.Show("Department ID can't be Empty ", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtDeptID.Text.Length > 20 Then
            MessageBox.Show("Department ID can't be more than 20 characters ", "ID length", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtDeptName.Text = "" Then
            MessageBox.Show("Department Name can't be Empty ", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtDeptName.Text.Length > 50 Then
            MessageBox.Show("Department ID can't be more than 50 characters ", "ID length", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf FacultyCombo.SelectedIndex = 0 Then
            MessageBox.Show("Faculty name is Required ", "Faculty name Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                id = txtDeptID.Text
                deptname = txtDeptName.Text
                faculty = query.DatabaseTable(0)(0)

                query.ExecuteQuery("INSERT INTO department(`deptID`,`deptName`,`facultyID`) values('" & id & "','" & deptname & "','" & faculty & "')")
                query.HasException()

                MessageBox.Show("Record Inserted Successfully ", "Record Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information)

                updateTable("select department.deptID as ID,department.deptName as DEPARTMENT,faculty.facultyName FACULTY 
                    from department JOIN faculty ON department.facultyID=faculty.facultyID")

            Catch ex As Exception
                'Error message
                query.exception = "Record Not Inserted"
                query.HasException()
            End Try
        End If

        txtDeptName.Clear()
        txtDeptID.Clear()
        FacultyCombo.SelectedIndex = 0
    End Sub

    'button class
    Private Sub btnClass_Click(sender As Object, e As EventArgs) Handles btnClass.Click
        AddClass.Show()
        Me.Hide()
    End Sub

    'button report
    Private Sub btnGenerateReports_Click(sender As Object, e As EventArgs) Handles btnGenerateReports.Click
        Report.Show()
        Me.Hide()
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
End Class