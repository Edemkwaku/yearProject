Public Class TakeAttendance
    Dim tab As New Database
    Private id, cclass, lec, course, fname, lname As String
    Private daydate As Date

    Dim result As Integer

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Me.Close()

    End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtID.Text.Equals("") Or ClassCombo.SelectedIndex = 0 Or comboLecturer.SelectedIndex = 0 Then
            MsgBox("All fields are Required", MsgBoxStyle.Critical, "Required fields")
        Else
            id = txtID.Text
            cclass = ClassCombo.SelectedItem
            lec = comboLecturer.SelectedItem
            course = courseCombo.SelectedItem


            tab.ExecuteQuery("select * from student where stuID like '" & id & "'")
            Dim data As String = tab.RecordCount
            If data = 0 Then
                MsgBox("No student found", MsgBoxStyle.Critical, "Unknown")
            Else
                fname = tab.DatabaseTable(0)(1)
                lname = tab.DatabaseTable(0)(2)
            End If

            tab.ExecuteQuery("select * from lecturer where fullName like '" & lec & "'")
            lec = tab.DatabaseTable(0)(0)

            tab.ExecuteQuery("select * from course where courseName like '" & course & "'")
            course = tab.DatabaseTable(0)(0)

            tab.ExecuteQuery("select * from class where className like '" & cclass & "'")
            cclass = tab.DatabaseTable(0)(0)


            tab.ExecuteQuery("select stuID from attendance where stuID='" & id & "' AND class='" & cclass & "' AND course='" & course & "';")
            result = tab.RecordCount

            If result > 0 Then
                Try
                    tab.ExecuteQuery("select attend from attendance where stuID='" & id & "' and class='" & cclass & "' and course='" & course & "';")
                    Dim attendance As Integer = tab.DatabaseTable(0)(0)

                    tab.ExecuteQuery("UPDATE `attendance` SET `attend` = '" & attendance + 1 & "', attend_date='" & DateTime.Text & "' WHERE stuID like '" & id & "' and class ='" & cclass & "' and course='" & course & "';")
                    If tab.HasException Then
                        tab.exception = "Failed to Mark attendance"
                        MsgBox(tab.exception, MsgBoxStyle.Critical, "Mark failed")
                    Else
                        MsgBox(fname & " " & lname & " " & "Attendance Checked", MsgBoxStyle.Information, "Checked")
                    End If

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            Else
                Try
                    daydate = Today.Date.ToShortDateString
                    tab.ExecuteQuery("insert into attendance(stuID,class,course,attend,attend_date) values('" & id & "','" & cclass & "','" & course & "',1,'" & DateTime.Text & "')")
                    If tab.HasException Then
                        tab.exception = "Failed to Mark attendance"
                        MsgBox(tab.exception, MsgBoxStyle.Critical, "Mark failed")
                    Else
                        MsgBox(fname & " " & lname & " " & "Attendance Checked", MsgBoxStyle.Information, "Checked")
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            End If

        End If
    End Sub

    'on form load
    Private Sub TakeAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadClassComboBox()
        loadCourseComboBox()
        loadLecturerComboBox()
    End Sub


    'load data into class combobox
    Sub loadClassComboBox()
        tab.ExecuteQuery("SELECT * from class where className ='" & s_class & "';")
        tab.HasException()

        ClassCombo.Items.Clear()
        ClassCombo.Items.Add("---class---")
        ClassCombo.SelectedIndex = 0

        For i = 0 To tab.RecordCount - 1
            Dim x As Integer = 1
            ClassCombo.Items.Add(tab.DatabaseTable(i)(x))
        Next
    End Sub

    'load data into course combobox
    Sub loadCourseComboBox()
        tab.ExecuteQuery("SELECT * from course;")
        tab.HasException()

        courseCombo.Items.Clear()
        courseCombo.Items.Add("---course---")
        courseCombo.SelectedIndex = 0

        For i = 0 To tab.RecordCount - 1
            Dim x As Integer = 1
            courseCombo.Items.Add(tab.DatabaseTable(i)(x))
        Next
    End Sub

    'load data into lecturer combobox
    Sub loadLecturerComboBox()
        tab.ExecuteQuery("SELECT * from lecturer ;")
        tab.HasException()

        comboLecturer.Items.Clear()
        comboLecturer.Items.Add("---lecturer---")
        comboLecturer.SelectedIndex = 0

        For i = 0 To tab.RecordCount - 1
            Dim x As Integer = 1
            comboLecturer.Items.Add(tab.DatabaseTable(i)(x))
        Next
    End Sub
End Class