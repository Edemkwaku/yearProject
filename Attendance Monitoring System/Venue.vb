Public Class Venue
    Dim query As New Database
    Dim iExit As DialogResult

    'close button
    Private Sub btnCose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    'update table on form load
    Sub updateTable()
        query.ExecuteQuery("select venueID AS ID,venueName AS VENUE from venue")
        VenueDataGrid.DataSource = query.DatabaseTable
    End Sub

    'form load
    Private Sub Venue_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtDate.Text = ("0" & Today.Day & "-0" & Today.Month & "-" & Today.Year)

        Dim signin As New Sign_In
        Dim user As String = username
        lblusername.Text = "Welcome " & user

        updateTable()
    End Sub

    'cell click
    Private Sub VenueDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles VenueDataGrid.CellClick
        Dim selectedDG As DataGridViewRow
        Dim index As Integer
        index = e.RowIndex
        selectedDG = VenueDataGrid.Rows(index)
        txtId.Text = selectedDG.Cells(0).Value.ToString
        txtVenue.Text = selectedDG.Cells(1).Value.ToString

    End Sub

    'button search
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            query.ExecuteQuery("select venueID AS ID,venueName AS VENUE from venue WHERE venueID LIKE '" & txtsearch.Text & "' OR venueName LIKE '" & txtsearch.Text & "';")
            Dim result As Integer = query.RecordCount

            If result = 0 Then
                iExit = MessageBox.Show(txtsearch.Text & " NOT found", "Record not found", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                VenueDataGrid.DataSource = query.DatabaseTable
            End If

        Catch ex As Exception
            iExit = MessageBox.Show(ex.ToString, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        txtsearch.Clear()
    End Sub

    'refresh button
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        updateTable()
    End Sub

    'clear button
    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        clearInputControls()
    End Sub

    'clear sub
    Sub clearInputControls()
        txtId.Clear()
        txtVenue.Clear()
        txtsearch.Clear()

    End Sub

    'button add
    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtId.Text.Equals("") Or txtVenue.Text.Equals("") Then
            iExit = MessageBox.Show("All fields Required", "Required fields", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                query.ExecuteQuery("INSERT INTO `venue` (`venueID`, `venueName`) VALUES ('" & txtId.Text & "', '" & txtVenue.Text & "');")
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
        If txtId.Text.Equals("") Or txtVenue.Text.Equals("") Then
            iExit = MessageBox.Show("All fields Required", "Required fields", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                query.ExecuteQuery("UPDATE `venue` SET `venueID` = '" & txtId.Text & "', `venueName` = '" & txtVenue.Text & "' 
                            WHERE `venue`.`venueID` = '" & txtId.Text & "';")
                iExit = MessageBox.Show("Record Updated Successfull", "Record Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                updateTable()
            Catch ex As Exception
                iExit = MessageBox.Show("Record Update failed", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        clearInputControls()
    End Sub

    'button delete
    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            query.ExecuteQuery("delete from venue where venueID LIKE '" & txtId.Text & "' OR venueName LIKE '" & txtVenue.Text & "';")
            iExit = MessageBox.Show("Record Deleted Successfull", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            updateTable()
        Catch ex As Exception
            iExit = MessageBox.Show("Record Delete failed", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'button clear
    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        clearInputControls()
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

    'student Details
    Private Sub btnStudentDetail_Click(sender As Object, e As EventArgs) Handles btnStudentDetail.Click

    End Sub

    'button attendance
    Private Sub btnStudentAttendance_Click(sender As Object, e As EventArgs) Handles btnStudentAttendance.Click
        Attendance.ShowDialog()
    End Sub

    'button user
    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        Users.Show()
        Me.Hide()
    End Sub
End Class