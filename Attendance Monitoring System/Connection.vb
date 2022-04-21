Imports MySql.Data.MySqlClient
Module Connection
    Dim Sqlconn As New MySqlConnection("server=localhost;username=root;database=mdatabase")
    Dim SqlRd As MySqlDataReader
    Dim SqlDt As New DataTable
    Dim DtA As New MySqlDataAdapter
    Dim sqlQuery As String
    Dim SqlCmd As New MySqlCommand

    Dim OfficeID As Integer
    Dim iExit As DialogResult

    ReadOnly Property getConnection() As MySqlConnection
        Get
            Return Sqlconn
        End Get
    End Property

    Sub openConnection()
        If Sqlconn.State = ConnectionState.Closed Then
            Sqlconn.Open()
        End If
    End Sub

    Sub closeConnection()
        If Sqlconn.State = ConnectionState.Open Then
            Sqlconn.Close()
        End If
    End Sub
End Module
