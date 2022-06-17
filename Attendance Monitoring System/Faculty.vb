Public Class Faculty
    Dim tab As New Database
    Dim iExit As DialogResult

    'close button
    Private Sub btnCose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    'form on load
    Private Sub Faculty_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtDate.Text = ("0" & Today.Day & "-0" & Today.Month & "-" & Today.Year)
        ' txtDate.Text = Today.Year & "-" & Today.Month & "-" & Today.Day

        Dim signin As New Sign_In
        Dim user As String = username
        lblusername.Text = "Welcome " & user

        'fetch and display facultis
        tab.ExecuteQuery("select facultyID AS ID, facultyName AS FACULTY from faculty ;")
        If tab.HasException(True) Then Exit Sub
        FacultyDataGrid.DataSource = tab.DatabaseTable
    End Sub

    'button user
    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Users.Show()
        Me.Hide()
    End Sub

    'Update sub
    Sub updateTable()
        tab.ExecuteQuery("select facultyID AS ID, facultyName AS FACULTY from faculty ;")
        If tab.HasException(True) Then Exit Sub
        FacultyDataGrid.DataSource = tab.DatabaseTable
    End Sub

    'clear sub
    Sub clearInputControls()
        txtFname.Clear()
        txtFname.Clear()
        txtsearch.clear()
    End Sub

    'button refresh
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        updateTable()
    End Sub

    'button search
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            tab.ExecuteQuery("select facultyID AS ID,facultyName AS FACULTY from faculty WHERE facultyID LIKE '" & txtsearch.Text & "' OR facultyName LIKE '" & txtsearch.Text & "';")
            Dim result As Integer = tab.RecordCount

            If result = 0 Then
                iExit = MessageBox.Show(txtsearch.Text & " NOT found", "Record not found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                FacultyDataGrid.DataSource = tab.DatabaseTable
            End If

        Catch ex As Exception
            iExit = MessageBox.Show(ex.ToString, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        txtsearch.Clear()
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

    'button class
    Private Sub btnClass_Click(sender As Object, e As EventArgs) Handles btnClass.Click
        AddClass.Show()
        Me.Hide()
    End Sub

    'button report
    Private Sub btnGenerateReports_Click(sender As Object, e As EventArgs) Handles btnGenerateReports.Click
        Report.ShowDialog()
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
        Attendance.ShowDialog()
    End Sub
    'cell click event
    Private Sub FacultyDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles FacultyDataGrid.CellClick
        Dim selectedDG As DataGridViewRow
        Dim index As Integer
        index = e.RowIndex
        selectedDG = FacultyDataGrid.Rows(index)
        txtId.Text = selectedDG.Cells(0).Value.ToString
        txtFname.Text = selectedDG.Cells(1).Value.ToString
    End Sub

    'button add
    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtId.Text.Equals("") Or txtFname.Text.Equals("") Then
            iExit = MessageBox.Show("All fields Required", "Required fields", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                tab.ExecuteQuery("INSERT INTO `faculty` (`facultyID`, `facultyName`) VALUES ('" & txtId.Text & "', '" & txtFname.Text & "');")
                iExit = MessageBox.Show("Record Inserted Successfull", "Record Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                updateTable()
            Catch ex As Exception
                iExit = MessageBox.Show("Record Insertion failed", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        clearInputControls()
    End Sub

    'button update
    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtId.Text.Equals("") Or txtFname.Text.Equals("") Then
            iExit = MessageBox.Show("All fields Required", "Required fields", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                tab.ExecuteQuery("UPDATE `faculty` SET `facultyID` = '" & txtId.Text & "', `facultyName` = '" & txtFname.Text & "' 
                            WHERE `faculty`.`facultyID` = '" & txtId.Text & "' OR facultyName LIKE '" & txtFname.Text & "';")
                iExit = MessageBox.Show("Record Updated Successfull", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                updateTable()
            Catch ex As Exception
                iExit = MessageBox.Show("Record Update failed", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        clearInputControls()
    End Sub

    'button clear
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearInputControls()
    End Sub

    'button delete
    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            tab.ExecuteQuery("delete from faculty where facultyID LIKE '" & txtId.Text & "' OR facultyName LIKE '" & txtFname.Text & "';")
            iExit = MessageBox.Show("Record Deleted Successfull", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            updateTable()
        Catch ex As Exception
            iExit = MessageBox.Show("Record Delete failed", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class