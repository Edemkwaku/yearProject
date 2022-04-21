Public Class Venue
    Dim query As New Database
    Dim iExit As DialogResult

    'close button
    Private Sub btnCose_Click(sender As Object, e As EventArgs) Handles btnCose.Click
        Me.Close()
    End Sub

    'button delete
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            query.ExecuteQuery("delete from venue where venueID LIKE '" & txtId.Text & "' OR venueName LIKE '" & txtVenue.Text & "';")
            iExit = MessageBox.Show("Record Deleted Successfull", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            updateTable()
        Catch ex As Exception
            iExit = MessageBox.Show("Record Delete failed", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Add button
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
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

    'update table on form load
    Sub updateTable()
        query.ExecuteQuery("select venueID AS ID,venueName AS VENUE from venue")
        VenueDataGrid.DataSource = query.DatabaseTable
    End Sub

    'form load
    Private Sub Venue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
    End Sub

    'update button
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
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
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearInputControls()
    End Sub

    'clear sub
    Sub clearInputControls()
        txtId.Clear()
        txtVenue.Clear()
        txtsearch.Clear()

    End Sub
End Class