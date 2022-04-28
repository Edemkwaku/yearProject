<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lecturers_Page
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
        Me.components = New System.ComponentModel.Container()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.btnClose = New Guna.UI.WinForms.GunaButton()
        Me.txtusername = New Guna.UI.WinForms.GunaLabel()
        Me.btnLogout = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.btnGenerateReport = New Guna.UI.WinForms.GunaButton()
        Me.btnStudentDetails = New Guna.UI.WinForms.GunaButton()
        Me.btnViewAttendance = New Guna.UI.WinForms.GunaButton()
        Me.btnMarkAttendance = New Guna.UI.WinForms.GunaButton()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaPanel1.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel1.Controls.Add(Me.btnClose)
        Me.GunaPanel1.Controls.Add(Me.txtusername)
        Me.GunaPanel1.Controls.Add(Me.btnLogout)
        Me.GunaPanel1.Controls.Add(Me.Label1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(5, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1006, 30)
        Me.GunaPanel1.TabIndex = 5
        '
        'btnClose
        '
        Me.btnClose.Animated = True
        Me.btnClose.AnimationHoverSpeed = 0.07!
        Me.btnClose.AnimationSpeed = 0.03!
        Me.btnClose.BaseColor = System.Drawing.Color.Red
        Me.btnClose.BorderColor = System.Drawing.Color.Black
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClose.FocusedColor = System.Drawing.Color.Empty
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = Nothing
        Me.btnClose.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnClose.Location = New System.Drawing.Point(967, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.OnHoverBorderColor = System.Drawing.Color.Red
        Me.btnClose.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClose.OnHoverImage = Nothing
        Me.btnClose.OnPressedColor = System.Drawing.Color.Black
        Me.btnClose.Size = New System.Drawing.Size(38, 30)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "X"
        Me.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtusername
        '
        Me.txtusername.AutoSize = True
        Me.txtusername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.Color.Violet
        Me.txtusername.Location = New System.Drawing.Point(643, 6)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(65, 17)
        Me.txtusername.TabIndex = 6
        Me.txtusername.Text = "Welcome"
        '
        'btnLogout
        '
        Me.btnLogout.Animated = True
        Me.btnLogout.AnimationHoverSpeed = 0.07!
        Me.btnLogout.AnimationSpeed = 0.03!
        Me.btnLogout.BaseColor = System.Drawing.Color.Orange
        Me.btnLogout.BorderColor = System.Drawing.Color.Orange
        Me.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogout.FocusedColor = System.Drawing.Color.Empty
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = Nothing
        Me.btnLogout.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLogout.Location = New System.Drawing.Point(876, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogout.OnHoverBorderColor = System.Drawing.Color.Orange
        Me.btnLogout.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLogout.OnHoverImage = Nothing
        Me.btnLogout.OnPressedColor = System.Drawing.Color.Black
        Me.btnLogout.Size = New System.Drawing.Size(92, 30)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "log out"
        Me.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Plum
        Me.Label1.Location = New System.Drawing.Point(12, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lecturers  Page"
        '
        'GunaPanel5
        '
        Me.GunaPanel5.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel5.Controls.Add(Me.btnGenerateReport)
        Me.GunaPanel5.Controls.Add(Me.btnMarkAttendance)
        Me.GunaPanel5.Controls.Add(Me.btnViewAttendance)
        Me.GunaPanel5.Controls.Add(Me.btnStudentDetails)
        Me.GunaPanel5.Location = New System.Drawing.Point(5, 30)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(119, 676)
        Me.GunaPanel5.TabIndex = 9
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.AnimationHoverSpeed = 0.07!
        Me.btnGenerateReport.AnimationSpeed = 0.03!
        Me.btnGenerateReport.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGenerateReport.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGenerateReport.BorderSize = 1
        Me.btnGenerateReport.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGenerateReport.FocusedColor = System.Drawing.Color.Empty
        Me.btnGenerateReport.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateReport.ForeColor = System.Drawing.Color.White
        Me.btnGenerateReport.Image = Nothing
        Me.btnGenerateReport.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGenerateReport.Location = New System.Drawing.Point(0, 350)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.OnHoverBaseColor = System.Drawing.Color.CornflowerBlue
        Me.btnGenerateReport.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGenerateReport.OnHoverForeColor = System.Drawing.Color.White
        Me.btnGenerateReport.OnHoverImage = Nothing
        Me.btnGenerateReport.OnPressedColor = System.Drawing.Color.Black
        Me.btnGenerateReport.Size = New System.Drawing.Size(121, 45)
        Me.btnGenerateReport.TabIndex = 5
        Me.btnGenerateReport.Text = "Generate Report"
        Me.btnGenerateReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnStudentDetails
        '
        Me.btnStudentDetails.AnimationHoverSpeed = 0.07!
        Me.btnStudentDetails.AnimationSpeed = 0.03!
        Me.btnStudentDetails.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStudentDetails.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStudentDetails.BorderSize = 1
        Me.btnStudentDetails.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnStudentDetails.FocusedColor = System.Drawing.Color.Empty
        Me.btnStudentDetails.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentDetails.ForeColor = System.Drawing.Color.White
        Me.btnStudentDetails.Image = Nothing
        Me.btnStudentDetails.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnStudentDetails.Location = New System.Drawing.Point(-2, 285)
        Me.btnStudentDetails.Name = "btnStudentDetails"
        Me.btnStudentDetails.OnHoverBaseColor = System.Drawing.Color.CornflowerBlue
        Me.btnStudentDetails.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStudentDetails.OnHoverForeColor = System.Drawing.Color.White
        Me.btnStudentDetails.OnHoverImage = Nothing
        Me.btnStudentDetails.OnPressedColor = System.Drawing.Color.Black
        Me.btnStudentDetails.Size = New System.Drawing.Size(121, 45)
        Me.btnStudentDetails.TabIndex = 5
        Me.btnStudentDetails.Text = "Student Details"
        Me.btnStudentDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnViewAttendance
        '
        Me.btnViewAttendance.AnimationHoverSpeed = 0.07!
        Me.btnViewAttendance.AnimationSpeed = 0.03!
        Me.btnViewAttendance.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnViewAttendance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnViewAttendance.BorderSize = 1
        Me.btnViewAttendance.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnViewAttendance.FocusedColor = System.Drawing.Color.Empty
        Me.btnViewAttendance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAttendance.ForeColor = System.Drawing.Color.White
        Me.btnViewAttendance.Image = Nothing
        Me.btnViewAttendance.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnViewAttendance.Location = New System.Drawing.Point(-2, 225)
        Me.btnViewAttendance.Name = "btnViewAttendance"
        Me.btnViewAttendance.OnHoverBaseColor = System.Drawing.Color.CornflowerBlue
        Me.btnViewAttendance.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnViewAttendance.OnHoverForeColor = System.Drawing.Color.White
        Me.btnViewAttendance.OnHoverImage = Nothing
        Me.btnViewAttendance.OnPressedColor = System.Drawing.Color.Black
        Me.btnViewAttendance.Size = New System.Drawing.Size(121, 45)
        Me.btnViewAttendance.TabIndex = 5
        Me.btnViewAttendance.Text = "Attendance"
        Me.btnViewAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnMarkAttendance
        '
        Me.btnMarkAttendance.AnimationHoverSpeed = 0.07!
        Me.btnMarkAttendance.AnimationSpeed = 0.03!
        Me.btnMarkAttendance.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMarkAttendance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMarkAttendance.BorderSize = 1
        Me.btnMarkAttendance.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMarkAttendance.FocusedColor = System.Drawing.Color.Empty
        Me.btnMarkAttendance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarkAttendance.ForeColor = System.Drawing.Color.White
        Me.btnMarkAttendance.Image = Nothing
        Me.btnMarkAttendance.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnMarkAttendance.Location = New System.Drawing.Point(0, 164)
        Me.btnMarkAttendance.Name = "btnMarkAttendance"
        Me.btnMarkAttendance.OnHoverBaseColor = System.Drawing.Color.CornflowerBlue
        Me.btnMarkAttendance.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMarkAttendance.OnHoverForeColor = System.Drawing.Color.White
        Me.btnMarkAttendance.OnHoverImage = Nothing
        Me.btnMarkAttendance.OnPressedColor = System.Drawing.Color.Black
        Me.btnMarkAttendance.Size = New System.Drawing.Size(121, 45)
        Me.btnMarkAttendance.TabIndex = 5
        Me.btnMarkAttendance.Text = "Mark Attendance"
        Me.btnMarkAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPanel3
        '
        Me.GunaPanel3.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel3.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(5, 704)
        Me.GunaPanel3.TabIndex = 7
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 704)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(1011, 5)
        Me.GunaPanel2.TabIndex = 6
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaPanel4.Location = New System.Drawing.Point(1006, 30)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(5, 674)
        Me.GunaPanel4.TabIndex = 10
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.GunaPanel1
        '
        'Lecturers_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 709)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.GunaPanel5)
        Me.Controls.Add(Me.GunaPanel3)
        Me.Controls.Add(Me.GunaPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Lecturers_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lecturers_Page"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtusername As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnLogout As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnGenerateReport As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnStudentDetails As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnViewAttendance As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnMarkAttendance As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
End Class
