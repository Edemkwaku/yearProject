
Public Class AddStudentDetails
    Inherits Database

    Private studentID As String
    Private studentname As String
    Private mobile As String
    Private studentclass As String
  
    Property student_id As String
        Set(value As String)
            If value = "" Then
                MsgBox("Student ID filed is required", MsgBoxStyle.Critical, "Student ID missing")
            Else
                studentID = value
            End If
        End Set
        Get
            Return studentID
        End Get
    End Property

    Property student_name As String
        Set(value As String)
            If value = "" Then
                MsgBox("Student Name filed is required", MsgBoxStyle.Critical, "Student Name missing")
            Else
                studentname = value
            End If
        End Set
        Get
            Return studentname
        End Get
    End Property


    Property student_mobile As String
        Set(value As String)
            mobile = value
        End Set
        Get
            Return mobile
        End Get
    End Property


    Property student_class As String
        Set(value As String)
            If value = "" Then
                MsgBox("Student Class filed is required", MsgBoxStyle.Critical, "Student Class missing")
            Else
                studentclass = value
            End If
        End Set
        Get
            Return studentclass
        End Get
    End Property

    Dim AddStudent As New Database

    
End Class
