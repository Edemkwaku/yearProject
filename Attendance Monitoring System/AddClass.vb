Public Class AddClass

    Private Sub buttonClose_Click(sender As Object, e As EventArgs) Handles buttonClose.Click
        Me.Close()
    End Sub

    Private Sub buttonSubmit_Click(sender As Object, e As EventArgs) Handles buttonSubmit.Click
        Dim StudentClass As New ClassDetails
        StudentClass.course_code = txtCode.Text
        StudentClass.course_name = txtCourseName.Text
        StudentClass.course_lecturer = txtCourseLecturer.Text


    End Sub

End Class