<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.buttonLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txt_Time = New System.Windows.Forms.Label()
        Me.Guna2Panel6 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtDate = New System.Windows.Forms.Label()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.btnManageStudent = New Guna.UI.WinForms.GunaButton()
        Me.btnViewAttendance = New Guna.UI.WinForms.GunaButton()
        Me.btnStudentDetail = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.btnManageCourse = New Guna.UI.WinForms.GunaButton()
        Me.btnGenerateReport = New Guna.UI.WinForms.GunaButton()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.Guna2Panel6.SuspendLayout()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonLogout
        '
        Me.buttonLogout.CheckedState.Parent = Me.buttonLogout
        Me.buttonLogout.CustomImages.Parent = Me.buttonLogout
        Me.buttonLogout.FillColor = System.Drawing.Color.Orange
        Me.buttonLogout.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonLogout.ForeColor = System.Drawing.Color.GhostWhite
        Me.buttonLogout.HoverState.Parent = Me.buttonLogout
        Me.buttonLogout.Location = New System.Drawing.Point(960, 0)
        Me.buttonLogout.Name = "buttonLogout"
        Me.buttonLogout.ShadowDecoration.Parent = Me.buttonLogout
        Me.buttonLogout.Size = New System.Drawing.Size(94, 31)
        Me.buttonLogout.TabIndex = 6
        Me.buttonLogout.Text = "log out"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.buttonLogout)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1102, 31)
        Me.Panel1.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.Red
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.BorderColor = System.Drawing.Color.Red
        Me.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(1054, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Color = System.Drawing.Color.Plum
        Me.btnClose.ShadowDecoration.Enabled = True
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(48, 31)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Purple
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Violet
        Me.Label1.Location = New System.Drawing.Point(257, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Attendance Monitoring System"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Purple
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 623)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1102, 5)
        Me.Panel2.TabIndex = 6
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.Controls.Add(Me.txt_Time)
        Me.Guna2Panel5.Location = New System.Drawing.Point(978, 63)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.ShadowDecoration.Color = System.Drawing.Color.Gray
        Me.Guna2Panel5.ShadowDecoration.Enabled = True
        Me.Guna2Panel5.ShadowDecoration.Parent = Me.Guna2Panel5
        Me.Guna2Panel5.Size = New System.Drawing.Size(112, 32)
        Me.Guna2Panel5.TabIndex = 7
        '
        'txt_Time
        '
        Me.txt_Time.AutoSize = True
        Me.txt_Time.Location = New System.Drawing.Point(21, 8)
        Me.txt_Time.Name = "txt_Time"
        Me.txt_Time.Size = New System.Drawing.Size(43, 15)
        Me.txt_Time.TabIndex = 0
        Me.txt_Time.Text = "Label2"
        '
        'Guna2Panel6
        '
        Me.Guna2Panel6.Controls.Add(Me.txtDate)
        Me.Guna2Panel6.Location = New System.Drawing.Point(14, 63)
        Me.Guna2Panel6.Name = "Guna2Panel6"
        Me.Guna2Panel6.ShadowDecoration.Color = System.Drawing.Color.Gray
        Me.Guna2Panel6.ShadowDecoration.Enabled = True
        Me.Guna2Panel6.ShadowDecoration.Parent = Me.Guna2Panel6
        Me.Guna2Panel6.Size = New System.Drawing.Size(114, 32)
        Me.Guna2Panel6.TabIndex = 8
        '
        'txtDate
        '
        Me.txtDate.AutoSize = True
        Me.txtDate.Location = New System.Drawing.Point(20, 8)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(43, 15)
        Me.txtDate.TabIndex = 0
        Me.txtDate.Text = "Label2"
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaPanel1.Location = New System.Drawing.Point(1097, 31)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(5, 592)
        Me.GunaPanel1.TabIndex = 9
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Controls.Add(Me.btnManageStudent)
        Me.GunaShadowPanel1.Controls.Add(Me.btnViewAttendance)
        Me.GunaShadowPanel1.Controls.Add(Me.btnStudentDetail)
        Me.GunaShadowPanel1.Controls.Add(Me.GunaButton3)
        Me.GunaShadowPanel1.Controls.Add(Me.btnManageCourse)
        Me.GunaShadowPanel1.Controls.Add(Me.btnGenerateReport)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(3, 31)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.ShadowDepth = 0
        Me.GunaShadowPanel1.ShadowShift = 1
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(1096, 28)
        Me.GunaShadowPanel1.TabIndex = 10
        '
        'btnManageStudent
        '
        Me.btnManageStudent.AnimationHoverSpeed = 0.07!
        Me.btnManageStudent.AnimationSpeed = 0.03!
        Me.btnManageStudent.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnManageStudent.BorderColor = System.Drawing.Color.Black
        Me.btnManageStudent.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnManageStudent.FocusedColor = System.Drawing.Color.Empty
        Me.btnManageStudent.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageStudent.ForeColor = System.Drawing.Color.White
        Me.btnManageStudent.Image = Nothing
        Me.btnManageStudent.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnManageStudent.Location = New System.Drawing.Point(849, 3)
        Me.btnManageStudent.Name = "btnManageStudent"
        Me.btnManageStudent.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnManageStudent.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnManageStudent.OnHoverForeColor = System.Drawing.Color.White
        Me.btnManageStudent.OnHoverImage = Nothing
        Me.btnManageStudent.OnPressedColor = System.Drawing.Color.Black
        Me.btnManageStudent.Size = New System.Drawing.Size(160, 22)
        Me.btnManageStudent.TabIndex = 4
        Me.btnManageStudent.Text = "Manage Student"
        Me.btnManageStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnViewAttendance
        '
        Me.btnViewAttendance.AnimationHoverSpeed = 0.07!
        Me.btnViewAttendance.AnimationSpeed = 0.03!
        Me.btnViewAttendance.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnViewAttendance.BorderColor = System.Drawing.Color.Black
        Me.btnViewAttendance.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnViewAttendance.FocusedColor = System.Drawing.Color.Empty
        Me.btnViewAttendance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAttendance.ForeColor = System.Drawing.Color.White
        Me.btnViewAttendance.Image = Nothing
        Me.btnViewAttendance.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnViewAttendance.Location = New System.Drawing.Point(683, 3)
        Me.btnViewAttendance.Name = "btnViewAttendance"
        Me.btnViewAttendance.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnViewAttendance.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnViewAttendance.OnHoverForeColor = System.Drawing.Color.White
        Me.btnViewAttendance.OnHoverImage = Nothing
        Me.btnViewAttendance.OnPressedColor = System.Drawing.Color.Black
        Me.btnViewAttendance.Size = New System.Drawing.Size(160, 22)
        Me.btnViewAttendance.TabIndex = 4
        Me.btnViewAttendance.Text = "Manage Lecturer"
        Me.btnViewAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnStudentDetail
        '
        Me.btnStudentDetail.AnimationHoverSpeed = 0.07!
        Me.btnStudentDetail.AnimationSpeed = 0.03!
        Me.btnStudentDetail.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStudentDetail.BorderColor = System.Drawing.Color.Black
        Me.btnStudentDetail.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnStudentDetail.FocusedColor = System.Drawing.Color.Empty
        Me.btnStudentDetail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudentDetail.ForeColor = System.Drawing.Color.White
        Me.btnStudentDetail.Image = Nothing
        Me.btnStudentDetail.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnStudentDetail.Location = New System.Drawing.Point(517, 3)
        Me.btnStudentDetail.Name = "btnStudentDetail"
        Me.btnStudentDetail.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStudentDetail.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnStudentDetail.OnHoverForeColor = System.Drawing.Color.White
        Me.btnStudentDetail.OnHoverImage = Nothing
        Me.btnStudentDetail.OnPressedColor = System.Drawing.Color.Black
        Me.btnStudentDetail.Size = New System.Drawing.Size(160, 22)
        Me.btnStudentDetail.TabIndex = 3
        Me.btnStudentDetail.Text = "View Student Details"
        Me.btnStudentDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton3
        '
        Me.GunaButton3.AnimationHoverSpeed = 0.07!
        Me.GunaButton3.AnimationSpeed = 0.03!
        Me.GunaButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton3.ForeColor = System.Drawing.Color.White
        Me.GunaButton3.Image = Nothing
        Me.GunaButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton3.Location = New System.Drawing.Point(342, 2)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Size = New System.Drawing.Size(169, 23)
        Me.GunaButton3.TabIndex = 2
        Me.GunaButton3.Text = "View Student Attendance"
        Me.GunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnManageCourse
        '
        Me.btnManageCourse.AnimationHoverSpeed = 0.07!
        Me.btnManageCourse.AnimationSpeed = 0.03!
        Me.btnManageCourse.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnManageCourse.BorderColor = System.Drawing.Color.Black
        Me.btnManageCourse.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnManageCourse.FocusedColor = System.Drawing.Color.Empty
        Me.btnManageCourse.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageCourse.ForeColor = System.Drawing.Color.White
        Me.btnManageCourse.Image = Nothing
        Me.btnManageCourse.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnManageCourse.Location = New System.Drawing.Point(204, 3)
        Me.btnManageCourse.Name = "btnManageCourse"
        Me.btnManageCourse.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnManageCourse.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnManageCourse.OnHoverForeColor = System.Drawing.Color.White
        Me.btnManageCourse.OnHoverImage = Nothing
        Me.btnManageCourse.OnPressedColor = System.Drawing.Color.Black
        Me.btnManageCourse.Size = New System.Drawing.Size(132, 22)
        Me.btnManageCourse.TabIndex = 1
        Me.btnManageCourse.Text = "Manage Course"
        Me.btnManageCourse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnGenerateReport
        '
        Me.btnGenerateReport.AnimationHoverSpeed = 0.07!
        Me.btnGenerateReport.AnimationSpeed = 0.03!
        Me.btnGenerateReport.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGenerateReport.BorderColor = System.Drawing.Color.Black
        Me.btnGenerateReport.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGenerateReport.FocusedColor = System.Drawing.Color.Empty
        Me.btnGenerateReport.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateReport.ForeColor = System.Drawing.Color.White
        Me.btnGenerateReport.Image = Nothing
        Me.btnGenerateReport.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGenerateReport.Location = New System.Drawing.Point(66, 3)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGenerateReport.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnGenerateReport.OnHoverForeColor = System.Drawing.Color.White
        Me.btnGenerateReport.OnHoverImage = Nothing
        Me.btnGenerateReport.OnPressedColor = System.Drawing.Color.Black
        Me.btnGenerateReport.Size = New System.Drawing.Size(132, 22)
        Me.btnGenerateReport.TabIndex = 0
        Me.btnGenerateReport.Text = "Generate Report"
        Me.btnGenerateReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 31)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(5, 592)
        Me.GunaPanel2.TabIndex = 11
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.Panel1
        '
        'AdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 628)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.Guna2Panel6)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdminMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        Me.Guna2Panel6.ResumeLayout(False)
        Me.Guna2Panel6.PerformLayout()
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents buttonLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txt_Time As Label
    Friend WithEvents Guna2Panel6 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtDate As Label
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents btnGenerateReport As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnStudentDetail As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnManageCourse As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnViewAttendance As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnManageStudent As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
End Class
