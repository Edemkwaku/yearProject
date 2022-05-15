Public Class AddClass
    Dim tab As New Database
    Private id, cname, programme As String

    'Add class button
    Private Sub buttonSubmit_Click(sender As Object, e As EventArgs) Handles buttonSubmit.Click

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
                    End If

                End If
            Catch ex As Exception
                MsgBox("Ooops' something went wrong !")
            End Try
        End If

    End Sub

    'close button
    Private Sub buttonClose_Click_1(sender As Object, e As EventArgs) Handles buttonClose.Click
        Me.Close()
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
        loadProgrammeComboBox()
    End Sub
End Class