Public Class Department
    Dim query As New Database
    Dim iExit As DialogResult
    Private Sub btnCose_Click(sender As Object, e As EventArgs) Handles btnCose.Click
        Me.Hide()
    End Sub


    Private Sub Department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadFacultyComboBox()
        updateTable()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
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

    'Update Button
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

    'Delete button 
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

        'updateTable("select department.deptID as ID,department.deptName as DEPARTMENT,faculty.facultyName FACULTY 
        'from department JOIN faculty ON department.facultyID=faculty.facultyID")
    End Sub

    Sub updateTable()
        query.ExecuteQuery("select department.deptID as ID,department.deptName as DEPARTMENT,faculty.facultyName FACULTY 
                    from department JOIN faculty ON department.facultyID=faculty.facultyID")
        DepartmentData.DataSource = query.DatabaseTable
    End Sub

    Private Sub DepartmentData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DepartmentData.CellClick
        Dim selectedDG As New DataGridViewRow
        Dim index As Integer
        index = e.RowIndex
        selectedDG = DepartmentData.Rows(index)
        txtDeptID.Text = selectedDG.Cells(0).Value.ToString
        txtDeptName.Text = selectedDG.Cells(1).Value.ToString
        FacultyCombo.Text = selectedDG.Cells(2).Value.ToString
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'search button
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

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        updateTable()
    End Sub
End Class