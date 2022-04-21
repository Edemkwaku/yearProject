Imports MySql.Data.MySqlClient
Public Class ClassDetails

    Private coursecode As String
    Private coursename As String
    Private courselecturer As String

    Property course_code As String
        Set(value As String)
            If value <> " " Then
                coursecode = value
            Else
                MsgBox("Course code filed is required", MsgBoxStyle.Critical, "Course code missing")
            End If
        End Set
        Get
            Return coursecode
        End Get
    End Property


    Property course_name As String
        Set(value As String)
            If value = "" Then
                coursename = value
            Else
                MsgBox("Course name filed is required", MsgBoxStyle.Critical, "Course name missing")
            End If
        End Set
        Get
            Return coursename
        End Get
    End Property


    Property course_lecturer As String
        Set(value As String)
            If value = "" Then
                coursecode = value
            Else
                MsgBox("Course code filed is required", MsgBoxStyle.Critical, "Course lecturer missing")
            End If
        End Set
        Get
            Return courselecturer
        End Get
    End Property





End Class
