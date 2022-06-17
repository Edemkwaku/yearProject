Public Class Attendance
    Dim data As String
    Dim tab As New Database
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CoursesCombo.SelectedIndex = 0
        loadClassComboBox()
        loadCourseComboBox()
        'LoadGrid()
    End Sub

    Private Sub LoadGrid()
        tab.ExecuteQuery("Select * from student;")
        If tab.HasException Then
            DataGridAttendance.DataSource = tab.DatabaseTable
        End If

    End Sub

    'load data into class combobox
    Sub loadClassComboBox()
        tab.ExecuteQuery("SELECT * from class where className ='" & s_class & "';")
        If tab.HasException() Then
            MsgBox(tab.exception)
        Else
            ClassCombo.Items.Clear()
            ClassCombo.Items.Add("---class---")
            ClassCombo.SelectedIndex = 0

            For i = 0 To tab.RecordCount - 1
                Dim x As Integer = 1
                ClassCombo.Items.Add(tab.DatabaseTable(i)(x))
            Next
        End If
    End Sub

    'load data into course combobox
    Sub loadCourseComboBox()
        Try
            tab.ExecuteQuery("select * from class where className LIKE'" & s_class & "';")
            data = tab.DatabaseTable(0)(1)

            tab.ExecuteQuery("SELECT course from attendance where class ='" & data & "';")

            If tab.HasException Then
                MsgBox(tab.exception)
            Else
                CoursesCombo.Items.Clear()
                CoursesCombo.Items.Add("---course---")
                CoursesCombo.SelectedIndex = 0

                For i = 0 To tab.RecordCount - 1
                    Dim x As Integer = 1
                    CoursesCombo.Items.Add(tab.DatabaseTable(i)(x))
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        If CoursesCombo.SelectedIndex = 0 And ClassCombo.SelectedIndex = 0 Then
            Try
                tab.ExecuteQuery("select attendance.stuID AS 'INDEX NO' ,class.className AS CLASS,attendance.attend AS
                                    ATTENDANCE,attendance.remark AS REMARK from attendance JOIN class ON attendance.class=class.classID
                                    where attendance.stuID = '" & txtsearch.Text & "' OR class.className like'" & txtsearch.Text & "'")
                Dim result As Integer = tab.RecordCount
                If result < 1 Then
                    MsgBox("No Attendance record(s) for " & txtsearch.Text)
                Else
                    DataGridAttendance.DataSource = tab.DatabaseTable
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
End Class