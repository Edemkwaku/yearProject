Public Class Lecturers_Page
    Dim tab As New Database
    Dim iExit As DialogResult

    'mark attendance button
    Private Sub btnMarkAttendance_Click(sender As Object, e As EventArgs) Handles btnMarkAttendance.Click
        TakeAttendance.ShowDialog()

    End Sub
    'view attendance button
    Private Sub btnViewAttendance_Click(sender As Object, e As EventArgs) Handles btnViewAttendance.Click
        Attendance.ShowDialog()
    End Sub

    'logout button
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        Sign_In.Show()
    End Sub

    'close button
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.ExitThread()
    End Sub

    'report buttom
    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        Report.ShowDialog()
    End Sub

    'form load
    Private Sub Lecturers_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim signin As New Sign_In
        Dim user As String = username
        lname.Text = "Welcome  " & user
        txtDate.Text = ("0" & Today.Day & "-0" & Today.Month & "-" & Today.Year)

        studentDetails.Visible = False
    End Sub

    'student details button
    Private Sub btnStudentDetails_Click(sender As Object, e As EventArgs) Handles btnStudentDetails.Click
        studentDetails.Visible = True
    End Sub

    Private Sub btnCose_Click(sender As Object, e As EventArgs) Handles btnCose.Click
        studentDetails.Visible = False
    End Sub

    'button search
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim result As Integer

        'for selected student
        If (ComboBox.SelectedItem.Equals("Student") And Not txtsearch.Text.Equals("")) Then
            Try
                tab.ExecuteQuery("SELECT `student`.`stuID` AS `ID`, `student`.`fName` AS `FIRST NAME`, `student`.`lName` AS `LAST NAME`, `student`.`DoB`,
                            `gender`.`gender` AS `GENDER`,`faculty`.`facultyName` AS `FACULTY`, `department`.`deptName` AS DEPARTMENT, `programme`.`proName` AS `PROGRAMME`, `student`.`phone` AS `PHONE`, `student`.`email` AS `EMAIL`
                            FROM `student` LEFT JOIN `gender`  ON `student`.`genderID` = `gender`.`genderID` 
	                        LEFT JOIN `programme`  ON `student`.`programme` = `programme`.`proID` JOIN `department` ON `programme`.`deptID` = `department`.`deptID` LEFT JOIN `faculty` ON `department`.`facultyID`=`faculty`.`facultyID`
                            WHERE (student.fName Like'" & txtsearch.Text & "' OR student.lName Like'" & txtsearch.Text & "' OR student.stuID Like'" & txtsearch.Text & "');")
                result = tab.DatabaseTable.Rows.Count
                If result < 1 Then
                    iExit = MessageBox.Show(txtsearch.Text & " " & "Student name not found", "Record Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    DetailsView.DataSource = tab.DatabaseTable
                    txtsearch.Clear()
                End If

            Catch ex As Exception
                iExit = MessageBox.Show(ex.ToString)
            End Try

        ElseIf (ComboBox.SelectedItem.Equals("Student") And txtsearch.Text.Equals("")) Then
            Try
                    tab.ExecuteQuery("SELECT `student`.`stuID` AS `ID`, `student`.`fName` AS `FIRST NAME`, `student`.`lName` AS `LAST NAME`, `student`.`DoB`,
                            `gender`.`gender` AS `GENDER`,`faculty`.`facultyName` AS `FACULTY`, `department`.`deptName` AS DEPARTMENT, `programme`.`proName` AS `PROGRAMME`, `student`.`phone` AS `PHONE`, `student`.`email` AS `EMAIL`
                            FROM `student` LEFT JOIN `gender`  ON `student`.`genderID` = `gender`.`genderID` 
	                        LEFT JOIN `programme`  ON `student`.`programme` = `programme`.`proID` JOIN `department` ON `programme`.`deptID` = `department`.`deptID` LEFT JOIN `faculty` ON `department`.`facultyID`=`faculty`.`facultyID`;")
                    result = tab.DatabaseTable.Rows.Count
                    If result < 1 Then
                        iExit = MessageBox.Show(txtsearch.Text & " " & "Student name not found", "Record Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        DetailsView.DataSource = tab.DatabaseTable
                        txtsearch.Clear()
                    End If

                Catch ex As Exception
                    iExit = MessageBox.Show(ex.ToString)
                End Try

            ElseIf ComboBox.SelectedItem.Equals("Lecturer") Then
            Try
                tab.ExecuteQuery("select lecturer.lecID AS ID, lecturer.fullName AS NAME,lecturer.DoB AS BIRTHDATE,
                          gender.gender AS GENDER,lecturer.phone AS PHONE, lecturer.email AS EMAIL
                          from lecturer JOIN gender ON lecturer.gender=gender.genderID where
                          fullName LIKE '" & txtsearch.Text & "' OR lecID LIKE'" & txtsearch.Text & "';")

                result = tab.DatabaseTable.Rows.Count
                If result = 0 Then
                    iExit = MessageBox.Show(txtsearch.Text & " " & "Lecturer name not found", "Record Exist", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    DetailsView.DataSource = tab.DatabaseTable
                    txtsearch.Clear()
                End If

            Catch ex As Exception
                iExit = MessageBox.Show("Sorry! something went wrong ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    'on panel load
    Private Sub studentDetails_Paint(sender As Object, e As PaintEventArgs) Handles studentDetails.Paint

        ComboBox.Items.Add("---select---")
        ComboBox.Items.Add("Lecturer")
        ComboBox.Items.Add("Student")
        ComboBox.SelectedIndex = 0
    End Sub
End Class