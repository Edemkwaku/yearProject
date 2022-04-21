Public Class Faculty
    Dim tab As New Database
    Dim iExit As DialogResult

    'close button
    Private Sub btnCose_Click(sender As Object, e As EventArgs) Handles btnCose.Click
        Me.Close()
    End Sub

    'form on load
    Private Sub Faculty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fetch and display facultis
        TAB.ExecuteQuery("select facultyID AS ID, facultyName AS FACULTY from faculty ;")
        If TAB.HasException(True) Then Exit Sub
        FacultyDataGrid.DataSource = tab.DatabaseTable
    End Sub

    'Add button
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
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

    'Update button
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
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

    'Update sub
    Sub updateTable()
        tab.ExecuteQuery("select facultyID AS ID, facultyName AS FACULTY from faculty ;")
        If tab.HasException(True) Then Exit Sub
        FacultyDataGrid.DataSource = tab.DatabaseTable
    End Sub

    'Delete button
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            tab.ExecuteQuery("delete from faculty where facultyID LIKE '" & txtId.Text & "' OR facultyName LIKE '" & txtFname.Text & "';")
            iExit = MessageBox.Show("Record Deleted Successfull", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            updateTable()
        Catch ex As Exception
            iExit = MessageBox.Show("Record Delete failed", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    'cell click event
    Private Sub FacultyDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles FacultyDataGrid.CellClick
        Dim selectedDG As DataGridViewRow
        Dim index As Integer
        index = e.RowIndex
        selectedDG = FacultyDataGrid.Rows(index)
        txtId.Text = selectedDG.Cells(0).Value.ToString
        txtFname.Text = selectedDG.Cells(1).Value.ToString
    End Sub
End Class