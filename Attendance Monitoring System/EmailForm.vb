Imports System.Net.Mail
Public Class EmailForm
    Dim SenderEmail As String = "edenkwaku85@gmail.com"

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Try
            Dim smtpServer As New SmtpClient
            Dim email As New MailMessage
            With smtpServer
                .UseDefaultCredentials = False
                .Credentials = New Net.NetworkCredential(SenderEmail, "Edem9815*")
                .Port = 587
                .EnableSsl = True
                .Host = "smtp.gmail.com"
            End With
            email = New MailMessage
            With email
                .From = New MailAddress(txtFrom.Text)
                .To.Add(txtTo.Text)
                .Subject = txtSubject.Text
                .IsBodyHtml = False
                .Body = txtMessage.Text
            End With
            smtpServer.Send(email)
            MsgBox("Mail Successfully Send", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EmailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFrom.Text = SenderEmail
        txtFrom.Enabled = False
    End Sub
End Class