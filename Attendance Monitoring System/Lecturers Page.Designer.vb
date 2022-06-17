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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lecturers_Page))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.txtDate = New System.Windows.Forms.Label()
        Me.btnMinimize = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.btnClose = New Guna.UI.WinForms.GunaButton()
        Me.lname = New Guna.UI.WinForms.GunaLabel()
        Me.btnLogout = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.btnGenerateReport = New Guna.UI.WinForms.GunaButton()
        Me.btnMarkAttendance = New Guna.UI.WinForms.GunaButton()
        Me.btnViewAttendance = New Guna.UI.WinForms.GunaButton()
        Me.btnStudentDetails = New Guna.UI.WinForms.GunaButton()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.txtsearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.DetailsView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.btnCose = New Guna.UI.WinForms.GunaButton()
        Me.ComboBox = New System.Windows.Forms.ComboBox()
        Me.studentDetails = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel5.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.studentDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel1.Controls.Add(Me.txtDate)
        Me.GunaPanel1.Controls.Add(Me.btnMinimize)
        Me.GunaPanel1.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel1.Controls.Add(Me.btnClose)
        Me.GunaPanel1.Controls.Add(Me.lname)
        Me.GunaPanel1.Controls.Add(Me.btnLogout)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(155, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1168, 38)
        Me.GunaPanel1.TabIndex = 5
        '
        'txtDate
        '
        Me.txtDate.AutoSize = True
        Me.txtDate.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtDate.ForeColor = System.Drawing.Color.Orange
        Me.txtDate.Location = New System.Drawing.Point(28, 6)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(70, 25)
        Me.txtDate.TabIndex = 19
        Me.txtDate.Text = "Label2"
        '
        'btnMinimize
        '
        Me.btnMinimize.CheckedState.Parent = Me.btnMinimize
        Me.btnMinimize.CustomImages.Parent = Me.btnMinimize
        Me.btnMinimize.FillColor = System.Drawing.Color.Silver
        Me.btnMinimize.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.Black
        Me.btnMinimize.HoverState.Parent = Me.btnMinimize
        Me.btnMinimize.Location = New System.Drawing.Point(1078, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.ShadowDecoration.Parent = Me.btnMinimize
        Me.btnMinimize.Size = New System.Drawing.Size(45, 38)
        Me.btnMinimize.TabIndex = 18
        Me.btnMinimize.Text = "-"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(751, 4)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(28, 28)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 17
        Me.GunaPictureBox1.TabStop = False
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
        Me.btnClose.Location = New System.Drawing.Point(1123, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.OnHoverBorderColor = System.Drawing.Color.Red
        Me.btnClose.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClose.OnHoverImage = Nothing
        Me.btnClose.OnPressedColor = System.Drawing.Color.Black
        Me.btnClose.Size = New System.Drawing.Size(45, 38)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "X"
        Me.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lname
        '
        Me.lname.AutoSize = True
        Me.lname.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold)
        Me.lname.ForeColor = System.Drawing.Color.Violet
        Me.lname.Location = New System.Drawing.Point(781, 6)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(84, 23)
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
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 11.75!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = Nothing
        Me.btnLogout.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLogout.Location = New System.Drawing.Point(986, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogout.OnHoverBorderColor = System.Drawing.Color.Orange
        Me.btnLogout.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLogout.OnHoverImage = Nothing
        Me.btnLogout.OnPressedColor = System.Drawing.Color.Black
        Me.btnLogout.Size = New System.Drawing.Size(92, 38)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "log out"
        Me.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(156, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lecturers  Page"
        '
        'GunaPanel5
        '
        Me.GunaPanel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaPanel5.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.GunaPanel5.Controls.Add(Me.btnGenerateReport)
        Me.GunaPanel5.Controls.Add(Me.btnMarkAttendance)
        Me.GunaPanel5.Controls.Add(Me.btnViewAttendance)
        Me.GunaPanel5.Controls.Add(Me.btnStudentDetails)
        Me.GunaPanel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel5.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(155, 744)
        Me.GunaPanel5.TabIndex = 9
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(3, 31)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(149, 149)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox1.TabIndex = 6
        Me.Guna2CirclePictureBox1.TabStop = False
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
        Me.btnGenerateReport.Image = CType(resources.GetObject("btnGenerateReport.Image"), System.Drawing.Image)
        Me.btnGenerateReport.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnGenerateReport.Location = New System.Drawing.Point(0, 406)
        Me.btnGenerateReport.Name = "btnGenerateReport"
        Me.btnGenerateReport.OnHoverBaseColor = System.Drawing.Color.CornflowerBlue
        Me.btnGenerateReport.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGenerateReport.OnHoverForeColor = System.Drawing.Color.White
        Me.btnGenerateReport.OnHoverImage = Nothing
        Me.btnGenerateReport.OnPressedColor = System.Drawing.Color.Black
        Me.btnGenerateReport.Size = New System.Drawing.Size(155, 45)
        Me.btnGenerateReport.TabIndex = 5
        Me.btnGenerateReport.Text = "Generate Report"
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
        Me.btnMarkAttendance.Image = CType(resources.GetObject("btnMarkAttendance.Image"), System.Drawing.Image)
        Me.btnMarkAttendance.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnMarkAttendance.Location = New System.Drawing.Point(0, 271)
        Me.btnMarkAttendance.Name = "btnMarkAttendance"
        Me.btnMarkAttendance.OnHoverBaseColor = System.Drawing.Color.CornflowerBlue
        Me.btnMarkAttendance.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMarkAttendance.OnHoverForeColor = System.Drawing.Color.White
        Me.btnMarkAttendance.OnHoverImage = Nothing
        Me.btnMarkAttendance.OnPressedColor = System.Drawing.Color.Black
        Me.btnMarkAttendance.Size = New System.Drawing.Size(155, 45)
        Me.btnMarkAttendance.TabIndex = 5
        Me.btnMarkAttendance.Text = "Mark Attendance"
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
        Me.btnViewAttendance.Image = CType(resources.GetObject("btnViewAttendance.Image"), System.Drawing.Image)
        Me.btnViewAttendance.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnViewAttendance.Location = New System.Drawing.Point(-2, 316)
        Me.btnViewAttendance.Name = "btnViewAttendance"
        Me.btnViewAttendance.OnHoverBaseColor = System.Drawing.Color.CornflowerBlue
        Me.btnViewAttendance.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnViewAttendance.OnHoverForeColor = System.Drawing.Color.White
        Me.btnViewAttendance.OnHoverImage = Nothing
        Me.btnViewAttendance.OnPressedColor = System.Drawing.Color.Black
        Me.btnViewAttendance.Size = New System.Drawing.Size(155, 45)
        Me.btnViewAttendance.TabIndex = 5
        Me.btnViewAttendance.Text = "Attendance"
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
        Me.btnStudentDetails.Image = CType(resources.GetObject("btnStudentDetails.Image"), System.Drawing.Image)
        Me.btnStudentDetails.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnStudentDetails.Location = New System.Drawing.Point(-2, 361)
        Me.btnStudentDetails.Name = "btnStudentDetails"
        Me.btnStudentDetails.OnHoverBaseColor = System.Drawing.Color.CornflowerBlue
        Me.btnStudentDetails.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStudentDetails.OnHoverForeColor = System.Drawing.Color.White
        Me.btnStudentDetails.OnHoverImage = Nothing
        Me.btnStudentDetails.OnPressedColor = System.Drawing.Color.Black
        Me.btnStudentDetails.Size = New System.Drawing.Size(155, 45)
        Me.btnStudentDetails.TabIndex = 5
        Me.btnStudentDetails.Text = "Student Details"
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 744)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(1323, 5)
        Me.GunaPanel2.TabIndex = 6
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaPanel4.Location = New System.Drawing.Point(1318, 38)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(5, 706)
        Me.GunaPanel4.TabIndex = 10
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.GunaPanel1
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
        Me.txtsearch.Location = New System.Drawing.Point(425, 90)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsearch.PlaceholderText = "search for student"
        Me.txtsearch.SelectedText = ""
        Me.txtsearch.ShadowDecoration.Parent = Me.txtsearch
        Me.txtsearch.Size = New System.Drawing.Size(407, 36)
        Me.txtsearch.TabIndex = 32
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
        Me.btnSearch.Location = New System.Drawing.Point(827, 88)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.ShadowDecoration.Parent = Me.btnSearch
        Me.btnSearch.Size = New System.Drawing.Size(105, 38)
        Me.btnSearch.TabIndex = 33
        Me.btnSearch.Text = "OK"
        '
        'DetailsView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DetailsView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DetailsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DetailsView.BackgroundColor = System.Drawing.Color.White
        Me.DetailsView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DetailsView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DetailsView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DetailsView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DetailsView.ColumnHeadersHeight = 18
        Me.DetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DetailsView.DefaultCellStyle = DataGridViewCellStyle3
        Me.DetailsView.EnableHeadersVisualStyles = False
        Me.DetailsView.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DetailsView.Location = New System.Drawing.Point(38, 134)
        Me.DetailsView.Name = "DetailsView"
        Me.DetailsView.RowHeadersVisible = False
        Me.DetailsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DetailsView.Size = New System.Drawing.Size(1022, 391)
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
        Me.btnCose.Location = New System.Drawing.Point(1054, 11)
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
        'ComboBox
        '
        Me.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Location = New System.Drawing.Point(38, 88)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(180, 29)
        Me.ComboBox.TabIndex = 36
        '
        'studentDetails
        '
        Me.studentDetails.BackColor = System.Drawing.SystemColors.Control
        Me.studentDetails.Controls.Add(Me.Panel4)
        Me.studentDetails.Controls.Add(Me.Panel3)
        Me.studentDetails.Controls.Add(Me.Panel2)
        Me.studentDetails.Controls.Add(Me.Panel1)
        Me.studentDetails.Controls.Add(Me.ComboBox)
        Me.studentDetails.Controls.Add(Me.Label2)
        Me.studentDetails.Controls.Add(Me.btnCose)
        Me.studentDetails.Controls.Add(Me.DetailsView)
        Me.studentDetails.Controls.Add(Me.btnSearch)
        Me.studentDetails.Controls.Add(Me.txtsearch)
        Me.studentDetails.Location = New System.Drawing.Point(188, 126)
        Me.studentDetails.Name = "studentDetails"
        Me.studentDetails.Size = New System.Drawing.Size(1102, 544)
        Me.studentDetails.TabIndex = 16
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightGray
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(5, 539)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1092, 5)
        Me.Panel4.TabIndex = 38
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightGray
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1097, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 539)
        Me.Panel3.TabIndex = 37
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(5, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1097, 5)
        Me.Panel2.TabIndex = 37
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 544)
        Me.Panel1.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Purple
        Me.Label2.Location = New System.Drawing.Point(32, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 31)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Details"
        '
        'Lecturers_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1323, 749)
        Me.Controls.Add(Me.studentDetails)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.GunaPanel5)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Lecturers_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lecturers_Page"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel5.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.studentDetails.ResumeLayout(False)
        Me.studentDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents btnMinimize As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtDate As Label
    Friend WithEvents txtsearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DetailsView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnCose As Guna.UI.WinForms.GunaButton
    Friend WithEvents ComboBox As ComboBox
    Friend WithEvents studentDetails As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
End Class
