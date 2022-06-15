<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageProgrammes
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
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageProgrammes))
        Me.txtsearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ProgrammeDataGrid = New System.Windows.Forms.DataGridView()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.btnsearch = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.btnRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.txtPname = New System.Windows.Forms.TextBox()
        Me.VenueCombo = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.departmentCombo = New System.Windows.Forms.ComboBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnClear = New Guna.UI.WinForms.GunaButton()
        Me.btnAdd = New Guna.UI.WinForms.GunaButton()
        Me.btnDelete = New Guna.UI.WinForms.GunaButton()
        Me.btnUpdate = New Guna.UI.WinForms.GunaButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnProgramme = New Guna.UI.WinForms.GunaButton()
        Me.btnDashboard = New Guna.UI.WinForms.GunaButton()
        Me.btnClass = New Guna.UI.WinForms.GunaButton()
        Me.btnGenerateReports = New Guna.UI.WinForms.GunaButton()
        Me.btnManageCourses = New Guna.UI.WinForms.GunaButton()
        Me.btnStudentAttendance = New Guna.UI.WinForms.GunaButton()
        Me.btnStudentDetail = New Guna.UI.WinForms.GunaButton()
        Me.btnManageStudent = New Guna.UI.WinForms.GunaButton()
        Me.btnBackup = New Guna.UI.WinForms.GunaButton()
        Me.btnManageLecturers = New Guna.UI.WinForms.GunaButton()
        Me.btnVenue = New Guna.UI.WinForms.GunaButton()
        Me.btnFaculty = New Guna.UI.WinForms.GunaButton()
        Me.btnDepartment = New Guna.UI.WinForms.GunaButton()
        Me.btnRestore = New Guna.UI.WinForms.GunaButton()
        Me.btnUsers = New Guna.UI.WinForms.GunaButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtDate = New System.Windows.Forms.Label()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRestoreWindowState = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMinimize = New Guna.UI2.WinForms.Guna2Button()
        Me.buttonLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        CType(Me.ProgrammeDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
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
        Me.txtsearch.Location = New System.Drawing.Point(79, 12)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsearch.PlaceholderText = "search for programme"
        Me.txtsearch.SelectedText = ""
        Me.txtsearch.ShadowDecoration.Parent = Me.txtsearch
        Me.txtsearch.Size = New System.Drawing.Size(200, 25)
        Me.txtsearch.TabIndex = 42
        '
        'ProgrammeDataGrid
        '
        Me.ProgrammeDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ProgrammeDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.ProgrammeDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ProgrammeDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.ProgrammeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProgrammeDataGrid.DefaultCellStyle = DataGridViewCellStyle12
        Me.ProgrammeDataGrid.Location = New System.Drawing.Point(94, 80)
        Me.ProgrammeDataGrid.Name = "ProgrammeDataGrid"
        Me.ProgrammeDataGrid.ReadOnly = True
        Me.ProgrammeDataGrid.Size = New System.Drawing.Size(569, 209)
        Me.ProgrammeDataGrid.TabIndex = 46
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 17.75!, System.Drawing.FontStyle.Bold)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Purple
        Me.GunaLabel1.Location = New System.Drawing.Point(89, 31)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(249, 32)
        Me.GunaLabel1.TabIndex = 39
        Me.GunaLabel1.Text = "Manage Programme"
        '
        'btnsearch
        '
        Me.btnsearch.BorderRadius = 5
        Me.btnsearch.CheckedState.Parent = Me.btnsearch
        Me.btnsearch.CustomImages.Parent = Me.btnsearch
        Me.btnsearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.White
        Me.btnsearch.HoverState.Parent = Me.btnsearch
        Me.btnsearch.Location = New System.Drawing.Point(277, 12)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.ShadowDecoration.Parent = Me.btnsearch
        Me.btnsearch.Size = New System.Drawing.Size(75, 25)
        Me.btnsearch.TabIndex = 43
        Me.btnsearch.Text = "OK"
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 744)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(1318, 5)
        Me.GunaPanel2.TabIndex = 42
        '
        'btnRefresh
        '
        Me.btnRefresh.BorderRadius = 5
        Me.btnRefresh.CheckedState.Parent = Me.btnRefresh
        Me.btnRefresh.CustomImages.Parent = Me.btnRefresh
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.HoverState.Parent = Me.btnRefresh
        Me.btnRefresh.Location = New System.Drawing.Point(436, 12)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.ShadowDecoration.Parent = Me.btnRefresh
        Me.btnRefresh.Size = New System.Drawing.Size(64, 25)
        Me.btnRefresh.TabIndex = 41
        Me.btnRefresh.Text = "Refresh"
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaPanel4.Location = New System.Drawing.Point(1318, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(5, 749)
        Me.GunaPanel4.TabIndex = 43
        '
        'txtPname
        '
        Me.txtPname.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPname.Location = New System.Drawing.Point(227, 108)
        Me.txtPname.Name = "txtPname"
        Me.txtPname.Size = New System.Drawing.Size(184, 27)
        Me.txtPname.TabIndex = 20
        '
        'VenueCombo
        '
        Me.VenueCombo.AutoSize = True
        Me.VenueCombo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VenueCombo.Location = New System.Drawing.Point(103, 147)
        Me.VenueCombo.Name = "VenueCombo"
        Me.VenueCombo.Size = New System.Drawing.Size(94, 20)
        Me.VenueCombo.TabIndex = 8
        Me.VenueCombo.Text = "Department"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(103, 69)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(108, 20)
        Me.GunaLabel2.TabIndex = 13
        Me.GunaLabel2.Text = "ProgrammeID"
        '
        'departmentCombo
        '
        Me.departmentCombo.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.departmentCombo.FormattingEnabled = True
        Me.departmentCombo.Location = New System.Drawing.Point(227, 145)
        Me.departmentCombo.Name = "departmentCombo"
        Me.departmentCombo.Size = New System.Drawing.Size(184, 28)
        Me.departmentCombo.TabIndex = 14
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(103, 111)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(112, 20)
        Me.GunaLabel3.TabIndex = 12
        Me.GunaLabel3.Text = "ProgramName"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnsearch)
        Me.Panel6.Controls.Add(Me.txtsearch)
        Me.Panel6.Controls.Add(Me.btnRefresh)
        Me.Panel6.Controls.Add(Me.txtPname)
        Me.Panel6.Controls.Add(Me.txtId)
        Me.Panel6.Controls.Add(Me.departmentCombo)
        Me.Panel6.Controls.Add(Me.VenueCombo)
        Me.Panel6.Controls.Add(Me.GunaLabel3)
        Me.Panel6.Controls.Add(Me.GunaLabel2)
        Me.Panel6.Location = New System.Drawing.Point(94, 291)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(569, 199)
        Me.Panel6.TabIndex = 44
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(227, 69)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(184, 27)
        Me.txtId.TabIndex = 21
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.Panel4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Guna2Panel1)
        Me.Panel1.Controls.Add(Me.ProgrammeDataGrid)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.GunaLabel1)
        Me.Panel1.Location = New System.Drawing.Point(361, 82)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(735, 598)
        Me.Panel1.TabIndex = 48
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Guna2Panel1.Controls.Add(Me.btnClear)
        Me.Guna2Panel1.Controls.Add(Me.btnAdd)
        Me.Guna2Panel1.Controls.Add(Me.btnDelete)
        Me.Guna2Panel1.Controls.Add(Me.btnUpdate)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 544)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(735, 54)
        Me.Guna2Panel1.TabIndex = 48
        '
        'btnClear
        '
        Me.btnClear.Animated = True
        Me.btnClear.AnimationHoverSpeed = 0.07!
        Me.btnClear.AnimationSpeed = 0.03!
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.BorderColor = System.Drawing.Color.Black
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClear.FocusedColor = System.Drawing.Color.Empty
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Image = Nothing
        Me.btnClear.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnClear.Location = New System.Drawing.Point(364, 13)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClear.OnHoverImage = Nothing
        Me.btnClear.OnPressedColor = System.Drawing.Color.Black
        Me.btnClear.Radius = 3
        Me.btnClear.Size = New System.Drawing.Size(100, 30)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAdd
        '
        Me.btnAdd.AnimationHoverSpeed = 0.07!
        Me.btnAdd.AnimationSpeed = 0.03!
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BaseColor = System.Drawing.Color.Green
        Me.btnAdd.BorderColor = System.Drawing.Color.Green
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAdd.FocusedColor = System.Drawing.Color.Empty
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Image = Nothing
        Me.btnAdd.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAdd.Location = New System.Drawing.Point(136, 14)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.OnHoverBorderColor = System.Drawing.Color.Green
        Me.btnAdd.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAdd.OnHoverImage = Nothing
        Me.btnAdd.OnPressedColor = System.Drawing.Color.Black
        Me.btnAdd.Radius = 3
        Me.btnAdd.Size = New System.Drawing.Size(100, 30)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDelete
        '
        Me.btnDelete.Animated = True
        Me.btnDelete.AnimationHoverSpeed = 0.07!
        Me.btnDelete.AnimationSpeed = 0.03!
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.BaseColor = System.Drawing.Color.Red
        Me.btnDelete.BorderColor = System.Drawing.Color.Red
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDelete.FocusedColor = System.Drawing.Color.Empty
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Image = Nothing
        Me.btnDelete.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDelete.Location = New System.Drawing.Point(481, 14)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.OnHoverBorderColor = System.Drawing.Color.Red
        Me.btnDelete.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDelete.OnHoverImage = Nothing
        Me.btnDelete.OnPressedColor = System.Drawing.Color.Black
        Me.btnDelete.Radius = 3
        Me.btnDelete.Size = New System.Drawing.Size(100, 30)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnUpdate
        '
        Me.btnUpdate.Animated = True
        Me.btnUpdate.AnimationHoverSpeed = 0.07!
        Me.btnUpdate.AnimationSpeed = 0.03!
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.BaseColor = System.Drawing.Color.Orange
        Me.btnUpdate.BorderColor = System.Drawing.Color.Orange
        Me.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUpdate.FocusedColor = System.Drawing.Color.Empty
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Image = Nothing
        Me.btnUpdate.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnUpdate.Location = New System.Drawing.Point(249, 14)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Orange
        Me.btnUpdate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUpdate.OnHoverImage = Nothing
        Me.btnUpdate.OnPressedColor = System.Drawing.Color.Black
        Me.btnUpdate.Radius = 3
        Me.btnUpdate.Size = New System.Drawing.Size(100, 30)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Purple
        Me.Panel3.Controls.Add(Me.btnProgramme)
        Me.Panel3.Controls.Add(Me.btnDashboard)
        Me.Panel3.Controls.Add(Me.btnClass)
        Me.Panel3.Controls.Add(Me.btnGenerateReports)
        Me.Panel3.Controls.Add(Me.btnManageCourses)
        Me.Panel3.Controls.Add(Me.btnStudentAttendance)
        Me.Panel3.Controls.Add(Me.btnStudentDetail)
        Me.Panel3.Controls.Add(Me.btnManageStudent)
        Me.Panel3.Controls.Add(Me.btnBackup)
        Me.Panel3.Controls.Add(Me.btnManageLecturers)
        Me.Panel3.Controls.Add(Me.btnVenue)
        Me.Panel3.Controls.Add(Me.btnFaculty)
        Me.Panel3.Controls.Add(Me.btnDepartment)
        Me.Panel3.Controls.Add(Me.btnRestore)
        Me.Panel3.Controls.Add(Me.btnUsers)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(149, 706)
        Me.Panel3.TabIndex = 50
        '
        'btnProgramme
        '
        Me.btnProgramme.AnimationHoverSpeed = 0.07!
        Me.btnProgramme.AnimationSpeed = 0.03!
        Me.btnProgramme.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnProgramme.BorderColor = System.Drawing.Color.Black
        Me.btnProgramme.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnProgramme.FocusedColor = System.Drawing.Color.Empty
        Me.btnProgramme.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnProgramme.ForeColor = System.Drawing.Color.White
        Me.btnProgramme.Image = CType(resources.GetObject("btnProgramme.Image"), System.Drawing.Image)
        Me.btnProgramme.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnProgramme.Location = New System.Drawing.Point(0, 587)
        Me.btnProgramme.Name = "btnProgramme"
        Me.btnProgramme.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnProgramme.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnProgramme.OnHoverForeColor = System.Drawing.Color.White
        Me.btnProgramme.OnHoverImage = Nothing
        Me.btnProgramme.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnProgramme.Size = New System.Drawing.Size(149, 35)
        Me.btnProgramme.TabIndex = 17
        Me.btnProgramme.Text = "Programme"
        '
        'btnDashboard
        '
        Me.btnDashboard.AnimationHoverSpeed = 0.07!
        Me.btnDashboard.AnimationSpeed = 0.03!
        Me.btnDashboard.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDashboard.BorderColor = System.Drawing.Color.Black
        Me.btnDashboard.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDashboard.FocusedColor = System.Drawing.Color.Empty
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnDashboard.Location = New System.Drawing.Point(1, 168)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDashboard.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDashboard.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDashboard.OnHoverImage = Nothing
        Me.btnDashboard.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDashboard.Size = New System.Drawing.Size(149, 35)
        Me.btnDashboard.TabIndex = 16
        Me.btnDashboard.Text = "Dashboard"
        '
        'btnClass
        '
        Me.btnClass.AnimationHoverSpeed = 0.07!
        Me.btnClass.AnimationSpeed = 0.03!
        Me.btnClass.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClass.BorderColor = System.Drawing.Color.Black
        Me.btnClass.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClass.FocusedColor = System.Drawing.Color.Empty
        Me.btnClass.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnClass.ForeColor = System.Drawing.Color.White
        Me.btnClass.Image = CType(resources.GetObject("btnClass.Image"), System.Drawing.Image)
        Me.btnClass.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnClass.Location = New System.Drawing.Point(0, 203)
        Me.btnClass.Name = "btnClass"
        Me.btnClass.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClass.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnClass.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClass.OnHoverImage = Nothing
        Me.btnClass.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnClass.Size = New System.Drawing.Size(149, 35)
        Me.btnClass.TabIndex = 12
        Me.btnClass.Text = "Class"
        '
        'btnGenerateReports
        '
        Me.btnGenerateReports.AnimationHoverSpeed = 0.07!
        Me.btnGenerateReports.AnimationSpeed = 0.03!
        Me.btnGenerateReports.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGenerateReports.BorderColor = System.Drawing.Color.Black
        Me.btnGenerateReports.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGenerateReports.FocusedColor = System.Drawing.Color.Empty
        Me.btnGenerateReports.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnGenerateReports.ForeColor = System.Drawing.Color.White
        Me.btnGenerateReports.Image = CType(resources.GetObject("btnGenerateReports.Image"), System.Drawing.Image)
        Me.btnGenerateReports.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnGenerateReports.Location = New System.Drawing.Point(0, 238)
        Me.btnGenerateReports.Name = "btnGenerateReports"
        Me.btnGenerateReports.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGenerateReports.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnGenerateReports.OnHoverForeColor = System.Drawing.Color.White
        Me.btnGenerateReports.OnHoverImage = Nothing
        Me.btnGenerateReports.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGenerateReports.Size = New System.Drawing.Size(149, 35)
        Me.btnGenerateReports.TabIndex = 0
        Me.btnGenerateReports.Text = "Report"
        '
        'btnManageCourses
        '
        Me.btnManageCourses.AnimationHoverSpeed = 0.07!
        Me.btnManageCourses.AnimationSpeed = 0.03!
        Me.btnManageCourses.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnManageCourses.BorderColor = System.Drawing.Color.Black
        Me.btnManageCourses.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnManageCourses.FocusedColor = System.Drawing.Color.Empty
        Me.btnManageCourses.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnManageCourses.ForeColor = System.Drawing.Color.White
        Me.btnManageCourses.Image = CType(resources.GetObject("btnManageCourses.Image"), System.Drawing.Image)
        Me.btnManageCourses.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnManageCourses.Location = New System.Drawing.Point(0, 518)
        Me.btnManageCourses.Name = "btnManageCourses"
        Me.btnManageCourses.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnManageCourses.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnManageCourses.OnHoverForeColor = System.Drawing.Color.White
        Me.btnManageCourses.OnHoverImage = Nothing
        Me.btnManageCourses.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnManageCourses.Size = New System.Drawing.Size(149, 35)
        Me.btnManageCourses.TabIndex = 1
        Me.btnManageCourses.Text = "Course"
        '
        'btnStudentAttendance
        '
        Me.btnStudentAttendance.AnimationHoverSpeed = 0.07!
        Me.btnStudentAttendance.AnimationSpeed = 0.03!
        Me.btnStudentAttendance.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStudentAttendance.BorderColor = System.Drawing.Color.Black
        Me.btnStudentAttendance.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnStudentAttendance.FocusedColor = System.Drawing.Color.Empty
        Me.btnStudentAttendance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnStudentAttendance.ForeColor = System.Drawing.Color.White
        Me.btnStudentAttendance.Image = CType(resources.GetObject("btnStudentAttendance.Image"), System.Drawing.Image)
        Me.btnStudentAttendance.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnStudentAttendance.Location = New System.Drawing.Point(0, 483)
        Me.btnStudentAttendance.Name = "btnStudentAttendance"
        Me.btnStudentAttendance.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStudentAttendance.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnStudentAttendance.OnHoverForeColor = System.Drawing.Color.White
        Me.btnStudentAttendance.OnHoverImage = Nothing
        Me.btnStudentAttendance.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStudentAttendance.Size = New System.Drawing.Size(149, 35)
        Me.btnStudentAttendance.TabIndex = 2
        Me.btnStudentAttendance.Text = "Attendance"
        '
        'btnStudentDetail
        '
        Me.btnStudentDetail.AnimationHoverSpeed = 0.07!
        Me.btnStudentDetail.AnimationSpeed = 0.03!
        Me.btnStudentDetail.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStudentDetail.BorderColor = System.Drawing.Color.Black
        Me.btnStudentDetail.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnStudentDetail.FocusedColor = System.Drawing.Color.Empty
        Me.btnStudentDetail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnStudentDetail.ForeColor = System.Drawing.Color.White
        Me.btnStudentDetail.Image = CType(resources.GetObject("btnStudentDetail.Image"), System.Drawing.Image)
        Me.btnStudentDetail.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnStudentDetail.Location = New System.Drawing.Point(0, 448)
        Me.btnStudentDetail.Name = "btnStudentDetail"
        Me.btnStudentDetail.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStudentDetail.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnStudentDetail.OnHoverForeColor = System.Drawing.Color.White
        Me.btnStudentDetail.OnHoverImage = Nothing
        Me.btnStudentDetail.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStudentDetail.Size = New System.Drawing.Size(149, 35)
        Me.btnStudentDetail.TabIndex = 3
        Me.btnStudentDetail.Text = "Details"
        '
        'btnManageStudent
        '
        Me.btnManageStudent.AnimationHoverSpeed = 0.07!
        Me.btnManageStudent.AnimationSpeed = 0.03!
        Me.btnManageStudent.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnManageStudent.BorderColor = System.Drawing.Color.Black
        Me.btnManageStudent.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnManageStudent.FocusedColor = System.Drawing.Color.Empty
        Me.btnManageStudent.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnManageStudent.ForeColor = System.Drawing.Color.White
        Me.btnManageStudent.Image = CType(resources.GetObject("btnManageStudent.Image"), System.Drawing.Image)
        Me.btnManageStudent.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnManageStudent.Location = New System.Drawing.Point(0, 413)
        Me.btnManageStudent.Name = "btnManageStudent"
        Me.btnManageStudent.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnManageStudent.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnManageStudent.OnHoverForeColor = System.Drawing.Color.White
        Me.btnManageStudent.OnHoverImage = Nothing
        Me.btnManageStudent.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnManageStudent.Size = New System.Drawing.Size(149, 35)
        Me.btnManageStudent.TabIndex = 4
        Me.btnManageStudent.Text = "Student"
        '
        'btnBackup
        '
        Me.btnBackup.AnimationHoverSpeed = 0.07!
        Me.btnBackup.AnimationSpeed = 0.03!
        Me.btnBackup.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBackup.BorderColor = System.Drawing.Color.Black
        Me.btnBackup.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBackup.FocusedColor = System.Drawing.Color.Empty
        Me.btnBackup.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBackup.ForeColor = System.Drawing.Color.White
        Me.btnBackup.Image = CType(resources.GetObject("btnBackup.Image"), System.Drawing.Image)
        Me.btnBackup.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnBackup.Location = New System.Drawing.Point(0, 630)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnBackup.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnBackup.OnHoverForeColor = System.Drawing.Color.White
        Me.btnBackup.OnHoverImage = Nothing
        Me.btnBackup.OnPressedColor = System.Drawing.Color.Black
        Me.btnBackup.Size = New System.Drawing.Size(149, 35)
        Me.btnBackup.TabIndex = 11
        Me.btnBackup.Text = "Backup"
        '
        'btnManageLecturers
        '
        Me.btnManageLecturers.AnimationHoverSpeed = 0.07!
        Me.btnManageLecturers.AnimationSpeed = 0.03!
        Me.btnManageLecturers.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnManageLecturers.BorderColor = System.Drawing.Color.Black
        Me.btnManageLecturers.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnManageLecturers.FocusedColor = System.Drawing.Color.Empty
        Me.btnManageLecturers.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnManageLecturers.ForeColor = System.Drawing.Color.White
        Me.btnManageLecturers.Image = CType(resources.GetObject("btnManageLecturers.Image"), System.Drawing.Image)
        Me.btnManageLecturers.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnManageLecturers.Location = New System.Drawing.Point(1, 378)
        Me.btnManageLecturers.Name = "btnManageLecturers"
        Me.btnManageLecturers.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnManageLecturers.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnManageLecturers.OnHoverForeColor = System.Drawing.Color.White
        Me.btnManageLecturers.OnHoverImage = Nothing
        Me.btnManageLecturers.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnManageLecturers.Size = New System.Drawing.Size(149, 35)
        Me.btnManageLecturers.TabIndex = 4
        Me.btnManageLecturers.Text = "Lecturer"
        '
        'btnVenue
        '
        Me.btnVenue.AnimationHoverSpeed = 0.07!
        Me.btnVenue.AnimationSpeed = 0.03!
        Me.btnVenue.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVenue.BorderColor = System.Drawing.Color.Transparent
        Me.btnVenue.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnVenue.FocusedColor = System.Drawing.Color.Empty
        Me.btnVenue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnVenue.ForeColor = System.Drawing.Color.White
        Me.btnVenue.Image = CType(resources.GetObject("btnVenue.Image"), System.Drawing.Image)
        Me.btnVenue.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnVenue.Location = New System.Drawing.Point(1, 343)
        Me.btnVenue.Name = "btnVenue"
        Me.btnVenue.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVenue.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnVenue.OnHoverForeColor = System.Drawing.Color.White
        Me.btnVenue.OnHoverImage = Nothing
        Me.btnVenue.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVenue.Size = New System.Drawing.Size(149, 35)
        Me.btnVenue.TabIndex = 10
        Me.btnVenue.Text = "Venue"
        '
        'btnFaculty
        '
        Me.btnFaculty.AnimationHoverSpeed = 0.07!
        Me.btnFaculty.AnimationSpeed = 0.03!
        Me.btnFaculty.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFaculty.BorderColor = System.Drawing.Color.Transparent
        Me.btnFaculty.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFaculty.FocusedColor = System.Drawing.Color.Empty
        Me.btnFaculty.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnFaculty.ForeColor = System.Drawing.Color.White
        Me.btnFaculty.Image = CType(resources.GetObject("btnFaculty.Image"), System.Drawing.Image)
        Me.btnFaculty.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnFaculty.Location = New System.Drawing.Point(0, 308)
        Me.btnFaculty.Name = "btnFaculty"
        Me.btnFaculty.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFaculty.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnFaculty.OnHoverForeColor = System.Drawing.Color.White
        Me.btnFaculty.OnHoverImage = Nothing
        Me.btnFaculty.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnFaculty.Size = New System.Drawing.Size(149, 35)
        Me.btnFaculty.TabIndex = 10
        Me.btnFaculty.Text = "Faculty"
        '
        'btnDepartment
        '
        Me.btnDepartment.AnimationHoverSpeed = 0.07!
        Me.btnDepartment.AnimationSpeed = 0.03!
        Me.btnDepartment.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDepartment.BorderColor = System.Drawing.Color.Transparent
        Me.btnDepartment.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDepartment.FocusedColor = System.Drawing.Color.Empty
        Me.btnDepartment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDepartment.ForeColor = System.Drawing.Color.White
        Me.btnDepartment.Image = CType(resources.GetObject("btnDepartment.Image"), System.Drawing.Image)
        Me.btnDepartment.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnDepartment.Location = New System.Drawing.Point(0, 273)
        Me.btnDepartment.Name = "btnDepartment"
        Me.btnDepartment.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDepartment.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnDepartment.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDepartment.OnHoverImage = Nothing
        Me.btnDepartment.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDepartment.Size = New System.Drawing.Size(149, 35)
        Me.btnDepartment.TabIndex = 10
        Me.btnDepartment.Text = "Department"
        '
        'btnRestore
        '
        Me.btnRestore.AnimationHoverSpeed = 0.07!
        Me.btnRestore.AnimationSpeed = 0.03!
        Me.btnRestore.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRestore.BorderColor = System.Drawing.Color.Transparent
        Me.btnRestore.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRestore.FocusedColor = System.Drawing.Color.Empty
        Me.btnRestore.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnRestore.ForeColor = System.Drawing.Color.White
        Me.btnRestore.Image = CType(resources.GetObject("btnRestore.Image"), System.Drawing.Image)
        Me.btnRestore.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnRestore.Location = New System.Drawing.Point(0, 665)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRestore.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnRestore.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRestore.OnHoverImage = Nothing
        Me.btnRestore.OnPressedColor = System.Drawing.Color.Black
        Me.btnRestore.Size = New System.Drawing.Size(149, 35)
        Me.btnRestore.TabIndex = 10
        Me.btnRestore.Text = "Restore"
        '
        'btnUsers
        '
        Me.btnUsers.AnimationHoverSpeed = 0.07!
        Me.btnUsers.AnimationSpeed = 0.03!
        Me.btnUsers.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUsers.BorderColor = System.Drawing.Color.Black
        Me.btnUsers.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUsers.FocusedColor = System.Drawing.Color.Empty
        Me.btnUsers.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnUsers.ForeColor = System.Drawing.Color.White
        Me.btnUsers.Image = CType(resources.GetObject("btnUsers.Image"), System.Drawing.Image)
        Me.btnUsers.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnUsers.Location = New System.Drawing.Point(0, 553)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUsers.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUsers.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUsers.OnHoverImage = Nothing
        Me.btnUsers.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUsers.Size = New System.Drawing.Size(149, 35)
        Me.btnUsers.TabIndex = 9
        Me.btnUsers.Text = "Users"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(5, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(140, 140)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Purple
        Me.Panel4.Controls.Add(Me.txtDate)
        Me.Panel4.Controls.Add(Me.GunaPictureBox1)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.lblusername)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1318, 38)
        Me.Panel4.TabIndex = 49
        '
        'txtDate
        '
        Me.txtDate.AutoSize = True
        Me.txtDate.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtDate.ForeColor = System.Drawing.Color.Orange
        Me.txtDate.Location = New System.Drawing.Point(33, 6)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(70, 25)
        Me.txtDate.TabIndex = 0
        Me.txtDate.Text = "Label2"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(870, 3)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 16
        Me.GunaPictureBox1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnClose)
        Me.Panel5.Controls.Add(Me.btnRestoreWindowState)
        Me.Panel5.Controls.Add(Me.btnMinimize)
        Me.Panel5.Controls.Add(Me.buttonLogout)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(1075, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(243, 38)
        Me.Panel5.TabIndex = 18
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
        Me.btnClose.Location = New System.Drawing.Point(196, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Color = System.Drawing.Color.Plum
        Me.btnClose.ShadowDecoration.Enabled = True
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(48, 38)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "X"
        '
        'btnRestoreWindowState
        '
        Me.btnRestoreWindowState.CheckedState.Parent = Me.btnRestoreWindowState
        Me.btnRestoreWindowState.CustomImages.Parent = Me.btnRestoreWindowState
        Me.btnRestoreWindowState.FillColor = System.Drawing.Color.Silver
        Me.btnRestoreWindowState.Font = New System.Drawing.Font("Webdings", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnRestoreWindowState.ForeColor = System.Drawing.Color.Black
        Me.btnRestoreWindowState.HoverState.Parent = Me.btnRestoreWindowState
        Me.btnRestoreWindowState.Location = New System.Drawing.Point(151, 0)
        Me.btnRestoreWindowState.Name = "btnRestoreWindowState"
        Me.btnRestoreWindowState.ShadowDecoration.Parent = Me.btnRestoreWindowState
        Me.btnRestoreWindowState.Size = New System.Drawing.Size(45, 38)
        Me.btnRestoreWindowState.TabIndex = 8
        Me.btnRestoreWindowState.Text = ""
        '
        'btnMinimize
        '
        Me.btnMinimize.CheckedState.Parent = Me.btnMinimize
        Me.btnMinimize.CustomImages.Parent = Me.btnMinimize
        Me.btnMinimize.FillColor = System.Drawing.Color.Silver
        Me.btnMinimize.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.Black
        Me.btnMinimize.HoverState.Parent = Me.btnMinimize
        Me.btnMinimize.Location = New System.Drawing.Point(106, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.ShadowDecoration.Parent = Me.btnMinimize
        Me.btnMinimize.Size = New System.Drawing.Size(45, 38)
        Me.btnMinimize.TabIndex = 9
        Me.btnMinimize.Text = "-"
        '
        'buttonLogout
        '
        Me.buttonLogout.CheckedState.Parent = Me.buttonLogout
        Me.buttonLogout.CustomImages.Parent = Me.buttonLogout
        Me.buttonLogout.FillColor = System.Drawing.Color.Orange
        Me.buttonLogout.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.buttonLogout.ForeColor = System.Drawing.Color.GhostWhite
        Me.buttonLogout.HoverState.Parent = Me.buttonLogout
        Me.buttonLogout.Location = New System.Drawing.Point(12, 0)
        Me.buttonLogout.Name = "buttonLogout"
        Me.buttonLogout.ShadowDecoration.Parent = Me.buttonLogout
        Me.buttonLogout.Size = New System.Drawing.Size(94, 38)
        Me.buttonLogout.TabIndex = 10
        Me.buttonLogout.Text = "Log out"
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lblusername.ForeColor = System.Drawing.Color.White
        Me.lblusername.Location = New System.Drawing.Point(903, 5)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(96, 25)
        Me.lblusername.TabIndex = 12
        Me.lblusername.Text = "username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Purple
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Violet
        Me.Label1.Location = New System.Drawing.Point(268, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Attendance Monitoring System"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 544)
        Me.Panel2.TabIndex = 49
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.LightGray
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(730, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(5, 544)
        Me.Panel7.TabIndex = 49
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.LightGray
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(5, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(725, 5)
        Me.Panel8.TabIndex = 49
        '
        'ManageProgrammes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1323, 749)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.GunaPanel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageProgrammes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programmes"
        CType(Me.ProgrammeDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtsearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ProgrammeDataGrid As DataGridView
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnsearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents txtPname As TextBox
    Friend WithEvents VenueCombo As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents departmentCombo As ComboBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtId As TextBox
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnClear As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAdd As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDelete As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnUpdate As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnProgramme As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDashboard As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnClass As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnGenerateReports As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnManageCourses As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnStudentAttendance As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnStudentDetail As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnManageStudent As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnBackup As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnManageLecturers As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnVenue As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnFaculty As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDepartment As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnRestore As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnUsers As Guna.UI.WinForms.GunaButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtDate As Label
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRestoreWindowState As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMinimize As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents buttonLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblusername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel2 As Panel
End Class
