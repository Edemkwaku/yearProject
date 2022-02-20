<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmailForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmailForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSend = New Guna.UI.WinForms.GunaButton()
        Me.txtMessage = New Guna.UI.WinForms.GunaTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSubject = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTo = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFrom = New Guna.UI.WinForms.GunaTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnSend)
        Me.Panel1.Controls.Add(Me.txtMessage)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtSubject)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtTo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtFrom)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(558, 338)
        Me.Panel1.TabIndex = 0
        '
        'btnSend
        '
        Me.btnSend.AnimationHoverSpeed = 0.07!
        Me.btnSend.AnimationSpeed = 0.03!
        Me.btnSend.BackColor = System.Drawing.Color.Transparent
        Me.btnSend.BaseColor = System.Drawing.Color.Green
        Me.btnSend.BorderColor = System.Drawing.Color.Black
        Me.btnSend.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSend.FocusedColor = System.Drawing.Color.Empty
        Me.btnSend.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSend.Image = CType(resources.GetObject("btnSend.Image"), System.Drawing.Image)
        Me.btnSend.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSend.Location = New System.Drawing.Point(153, 257)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSend.OnHoverBorderColor = System.Drawing.Color.Green
        Me.btnSend.OnHoverForeColor = System.Drawing.Color.Lime
        Me.btnSend.OnHoverImage = Nothing
        Me.btnSend.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSend.Radius = 5
        Me.btnSend.Size = New System.Drawing.Size(160, 42)
        Me.btnSend.TabIndex = 14
        Me.btnSend.Text = "Send Email"
        '
        'txtMessage
        '
        Me.txtMessage.BaseColor = System.Drawing.Color.White
        Me.txtMessage.BorderColor = System.Drawing.Color.Silver
        Me.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMessage.FocusedBaseColor = System.Drawing.Color.White
        Me.txtMessage.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMessage.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtMessage.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessage.Location = New System.Drawing.Point(153, 146)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMessage.SelectedText = ""
        Me.txtMessage.Size = New System.Drawing.Size(323, 91)
        Me.txtMessage.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 21)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Message :"
        '
        'txtSubject
        '
        Me.txtSubject.BaseColor = System.Drawing.Color.White
        Me.txtSubject.BorderColor = System.Drawing.Color.Silver
        Me.txtSubject.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubject.FocusedBaseColor = System.Drawing.Color.White
        Me.txtSubject.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSubject.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSubject.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubject.Location = New System.Drawing.Point(153, 108)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubject.SelectedText = ""
        Me.txtSubject.Size = New System.Drawing.Size(204, 32)
        Me.txtSubject.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 21)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Subject :"
        '
        'txtTo
        '
        Me.txtTo.BaseColor = System.Drawing.Color.White
        Me.txtTo.BorderColor = System.Drawing.Color.Silver
        Me.txtTo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTo.FocusedBaseColor = System.Drawing.Color.White
        Me.txtTo.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTo.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTo.Location = New System.Drawing.Point(153, 72)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTo.SelectedText = ""
        Me.txtTo.Size = New System.Drawing.Size(204, 32)
        Me.txtTo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 21)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "To :"
        '
        'txtFrom
        '
        Me.txtFrom.BaseColor = System.Drawing.Color.White
        Me.txtFrom.BorderColor = System.Drawing.Color.Silver
        Me.txtFrom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFrom.FocusedBaseColor = System.Drawing.Color.White
        Me.txtFrom.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFrom.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtFrom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFrom.Location = New System.Drawing.Point(153, 36)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFrom.SelectedText = ""
        Me.txtFrom.Size = New System.Drawing.Size(204, 32)
        Me.txtFrom.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 21)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "From :"
        '
        'EmailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 338)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EmailForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EmailForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSend As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtMessage As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSubject As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTo As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFrom As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
