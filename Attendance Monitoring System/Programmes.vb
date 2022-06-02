﻿Public Class ManageProgrammes
    Dim tab As New Database
    Dim iExit As DialogResult
    Private id, pname, dept As String

    Private Sub btnCose_Click(sender As Object, e As EventArgs) Handles btnCose.Click
        Me.Hide()
    End Sub

    'Add record button
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtId.Text.Equals("") Or txtPname.Text.Equals("") Or departmentCombo.SelectedIndex = 0 Then
            MsgBox("All fields are required", MsgBoxStyle.Critical, "Fileds required")
        Else
            id = txtId.Text
            pname = txtPname.Text
            dept = departmentCombo.SelectedItem

            Try
                tab.ExecuteQuery("select * from department where deptName like '" & dept & "';")
                dept = tab.DatabaseTable.Rows(0)(0)
            Catch ex As Exception
                MsgBox(ex.ToString & " department side")
            End Try

            Try
                tab.ExecuteQuery("select * from programme where proID like '" & id & "' OR proName like '" & pname & "';")
                Dim result As Integer = tab.RecordCount
                If result > 0 Then
                    MsgBox("Programme already exist ", MsgBoxStyle.Critical, "Record exist")
                Else
                    Try
                        tab.ExecuteQuery("insert into programme(proID,proName,deptID) values('" & id & "','" & pname & "','" & dept & "');")
                        If tab.HasException Then
                            MsgBox("Insertion error")
                        Else
                            MsgBox("Programme Added successfully", MsgBoxStyle.Information, "Record added")
                            updateTable()
                        End If
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Information, "Error")
            End Try
        End If
        clear()
    End Sub

    'Update button
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtId.Text.Equals("") Or txtPname.Text.Equals("") Or departmentCombo.SelectedIndex = 0 Then
            MsgBox("All fields are required", MsgBoxStyle.Critical, "Fileds required")
        Else
            id = txtId.Text
            pname = txtPname.Text
            dept = departmentCombo.SelectedItem

            Try

                tab.ExecuteQuery("select * from department where deptName like '" & dept & "';")
                dept = tab.DatabaseTable.Rows(0)(0)

                tab.ExecuteQuery("update programme SET deptID='" & dept & "', proName='" & pname & "' where proID ='" & id & "';")
                        If tab.HasException Then
                            MsgBox(tab.exception & "Update error")
                        Else
                            MsgBox("Programme Updated successfully", MsgBoxStyle.Information, "Record Update")
                            updateTable()
                        End If

            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error")
            End Try
        End If
        clear()
    End Sub

    Private Sub ManageProgrammes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDepartmentComboBox()
        updateTable()
    End Sub

    'oncell click
    Private Sub ProgrammeDataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProgrammeDataGrid.CellClick
        Dim selectedDG As New DataGridViewRow
        Dim index As Integer
        index = e.RowIndex
        selectedDG = ProgrammeDataGrid.Rows(index)
        txtId.Text = selectedDG.Cells(0).Value.ToString
        txtPname.Text = selectedDG.Cells(1).Value.ToString
        departmentCombo.Text = selectedDG.Cells(2).Value.ToString
    End Sub

    'search button
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim search As String = txtsearch.Text
        'search button
        Try
            tab.ExecuteQuery("select * from department where deptName like '" & departmentCombo.SelectedItem & "';")
            Dim deptm As String = tab.DatabaseTable.Rows(0)(0)

            tab.ExecuteQuery("Select programme.proID As ID, programme.proName As PROGRAMME, Department.deptName AS DEPARTMENT from programme
                            Join Department ON programme.deptID=department.deptID Where (programme.proName like'" & search & "'
                            OR programme.proID like '" & search & "' OR programme.deptID like '" & deptm & "');")

            Dim result As Integer = tab.RecordCount
            Dim pro_name As String = tab.DatabaseTable(0)(1)
            'result = tab.DatabaseTable.Rows.Count
            If result = 0 Then
                iExit = MessageBox.Show(search & " " & "Do not match Any record", "Record Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                ProgrammeDataGrid.DataSource = tab.DatabaseTable
                txtsearch.Clear()
            End If

        Catch ex As Exception
            iExit = MessageBox.Show("Failed To Add Record  " & ex.ToString, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'refresh button
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        updateTable()
    End Sub




    'load data into programme combobox
    Sub loadDepartmentComboBox()
        tab.ExecuteQuery("SELECT * from department ;")
        tab.HasException()

        departmentCombo.Items.Clear()
        departmentCombo.Items.Add("---department---")
        departmentCombo.SelectedIndex = 0

        For i = 0 To tab.RecordCount - 1
            Dim x As Integer = 1
            departmentCombo.Items.Add(tab.DatabaseTable(i)(x))
        Next
    End Sub

    'clear button
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    'delete button
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        tab.ExecuteQuery("delete from programme where proID like '" & txtId.Text & "' OR proName like '" & txtPname.Text & "';")
        If tab.HasException Then
            MsgBox("Programme Deletion failed  " & tab.exception, MsgBoxStyle.Information, "Delete Error")
        Else
            MsgBox("Programme Deleted successfully", MsgBoxStyle.Information, "Record Deleted")
            updateTable()
        End If

    End Sub

    'laod data into datagrid
    Sub updateTable()
        tab.ExecuteQuery("Select programme.proID AS ID,programme.proName AS PROGRAMME,department.deptName AS DEPARTMENT from programme
                            JOIN department ON programme.deptID=department.deptID")
        If tab.HasException Then
            MsgBox("Ooops! something happened")
        Else
            ProgrammeDataGrid.DataSource = tab.DatabaseTable
        End If
    End Sub

    'clear sub
    Sub clear()
        txtId.Clear()
        txtPname.Clear()
        departmentCombo.SelectedIndex = 0
        txtsearch.Clear()
    End Sub

End Class