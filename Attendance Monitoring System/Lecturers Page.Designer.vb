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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.btnClose = New Guna.UI.WinForms.GunaButton()
        Me.lname = New Guna.UI.WinForms.GunaLabel()
        Me.btnLogout = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.btnGenerateReport = New Guna.UI.WinForms.GunaButton()
        Me.btnMarkAttendance = New Guna.UI.WinForms.GunaButton()
        Me.btnViewAttendance = New Guna.UI.WinForms.GunaButton()
        Me.btnStudentDetails = New Guna.UI.WinForms.GunaButton()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.studentDetails = New System.Windows.Forms.Panel()
        Me.ComboBox = New System.Windows.Forms.ComboBox()
        Me.btnCose = New Guna.UI.WinForms.GunaButton()
        Me.DetailsView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.txtsearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaPanel1.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.studentDetails.SuspendLayout()
        CType(Me.DetailsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel1.Controls.Add(Me.btnClose)
        Me.GunaPanel1.Controls.Add(Me.lname)
        Me.GunaPanel1.Controls.Add(Me.btnLogout)
        Me.GunaPanel1.Controls.Add(Me.Label1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1071, 30)
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
        Me.btnClose.Location = New System.Drawing.Point(1031, 0)
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
        'lname
        '
        Me.lname.AutoSize = True
        Me.lname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lname.ForeColor = System.Drawing.Color.Violet
        Me.lname.Location = New System.Drawing.Point(677, 6)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(65, 17)
        Me.lname.TabIndex = 6
        Me.lname.Text = "Welcome"
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
        Me.btnLogout.Location = New System.Drawing.Point(939, 0)
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
        Me.GunaPanel5.Location = New System.Drawing.Point(0, 30)
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
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 704)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(1071, 5)
        Me.GunaPanel2.TabIndex = 6
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaPanel4.Location = New System.Drawing.Point(1066, 30)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(5, 674)
        Me.GunaPanel4.TabIndex = 10
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.GunaPanel1
        '
        'studentDetails
        '
        Me.studentDetails.BackColor = System.Drawing.Color.Silver
        Me.studentDetails.Controls.Add(Me.ComboBox)
        Me.studentDetails.Controls.Add(Me.btnCose)
        Me.studentDetails.Controls.Add(Me.DetailsView)
        Me.studentDetails.Controls.Add(Me.btnSearch)
        Me.studentDetails.Controls.Add(Me.txtsearch)
        Me.studentDetails.Location = New System.Drawing.Point(161, 209)
        Me.studentDetails.Name = "studentDetails"
        Me.studentDetails.Size = New System.Drawing.Size(870, 330)
        Me.studentDetails.TabIndex = 16
        '
        'ComboBox
        '
        Me.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Location = New System.Drawing.Point(37, 18)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(162, 29)
        Me.ComboBox.TabIndex = 36
        '
        'btnCose
        '
        Me.btnCose.AnimationHoverSpeed = 0.07!
        Me.btnCose.AnimationSpeed = 0.03!
        Me.btnCose.BaseColor = System.Drawing.SystemColors.Control
        Me.btnCose.BorderColor = System.Drawing.Color.Red
        Me.btnCose.BorderSize = 1
        Me.btnCose.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCose.FocusedColor = System.Drawing.Color.Empty
        Me.btnCose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCose.ForeColor = System.Drawing.Color.Black
        Me.btnCose.Image = Nothing
        Me.btnCose.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCose.Location = New System.Drawing.Point(821, 9)
        Me.btnCose.Name = "btnCose"
        Me.btnCose.OnHoverBaseColor = System.Drawing.Color.Red
        Me.btnCose.OnHoverBorderColor = System.Drawing.Color.Red
        Me.btnCose.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCose.OnHoverImage = Nothing
        Me.btnCose.OnPressedColor = System.Drawing.Color.Black
        Me.btnCose.Size = New System.Drawing.Size(37, 26)
        Me.btnCose.TabIndex = 35
        Me.btnCose.Text = "X"
        Me.btnCose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DetailsView
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.DetailsView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DetailsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DetailsView.BackgroundColor = System.Drawing.Color.White
        Me.DetailsView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetailsView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DetailsView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DetailsView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DetailsView.ColumnHeadersHeight = 18
        Me.DetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DetailsView.DefaultCellStyle = DataGridViewCellStyle9
        Me.DetailsView.EnableHeadersVisualStyles = False
        Me.DetailsView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DetailsView.Location = New System.Drawing.Point(37, 53)
        Me.DetailsView.Name = "DetailsView"
        Me.DetailsView.RowHeadersVisible = False
        Me.DetailsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DetailsView.Size = New System.Drawing.Size(804, 244)
        Me.DetailsView.TabIndex = 34
        Me.DetailsView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DetailsView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DetailsView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DetailsView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DetailsView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DetailsView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DetailsView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DetailsView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DetailsView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DetailsView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DetailsView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailsView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DetailsView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DetailsView.ThemeStyle.HeaderStyle.Height = 18
        Me.DetailsView.ThemeStyle.ReadOnly = False
        Me.DetailsView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DetailsView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DetailsView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailsView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DetailsView.ThemeStyle.RowsStyle.Height = 22
        Me.DetailsView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DetailsView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnSearch
        '
        Me.btnSearch.BorderRadius = 5
        Me.btnSearch.CheckedState.Parent = Me.btnSearch
        Me.btnSearch.CustomImages.Parent = Me.btnSearch
        Me.btnSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.HoverState.Parent = Me.btnSearch
        Me.btnSearch.Location = New System.Drawing.Point(550, 20)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.ShadowDecoration.Parent = Me.btnSearch
        Me.btnSearch.Size = New System.Drawing.Size(75, 25)
        Me.btnSearch.TabIndex = 33
        Me.btnSearch.Text = "OK"
        '
        'txtsearch
        '
        Me.txtsearch.BorderRadius = 5
        Me.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsearch.DefaultText = ""
        Me.txtsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsearch.DisabledState.Parent = Me.txtsearch
        Me.txtsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsearch.FocusedState.Parent = Me.txtsearch
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsearch.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtsearch.HoverState.Parent = Me.txtsearch
        Me.txtsearch.Location = New System.Drawing.Point(352, 20)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsearch.PlaceholderText = "search for student"
        Me.txtsearch.SelectedText = ""
        Me.txtsearch.ShadowDecoration.Parent = Me.txtsearch
        Me.txtsearch.Size = New System.Drawing.Size(200, 25)
        Me.txtsearch.TabIndex = 32
        '
        'Lecturers_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 709)
        Me.Controls.Add(Me.studentDetails)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.GunaPanel5)
        Me.Controls.Add(Me.GunaPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Lecturers_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lecturers_Page"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.studentDetails.ResumeLayout(False)
        CType(Me.DetailsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnLogout As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnGenerateReport As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnStudentDetails As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnViewAttendance As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnMarkAttendance As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents lname As Guna.UI.WinForms.GunaLabel
    Friend WithEvents studentDetails As Panel
    Friend WithEvents ComboBox As ComboBox
    Friend WithEvents btnCose As Guna.UI.WinForms.GunaButton
    Friend WithEvents DetailsView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtsearch As Guna.UI2.WinForms.Guna2TextBox
End Class
