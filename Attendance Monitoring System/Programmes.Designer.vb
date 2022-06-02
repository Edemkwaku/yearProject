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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtsearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ProgrammeDataGrid = New System.Windows.Forms.DataGridView()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnClear = New Guna.UI.WinForms.GunaButton()
        Me.btnAdd = New Guna.UI.WinForms.GunaButton()
        Me.btnDelete = New Guna.UI.WinForms.GunaButton()
        Me.btnUpdate = New Guna.UI.WinForms.GunaButton()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.btnsearch = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.btnRefresh = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.txtPname = New System.Windows.Forms.TextBox()
        Me.VenueCombo = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.departmentCombo = New System.Windows.Forms.ComboBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btnCose = New Guna.UI.WinForms.GunaButton()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        CType(Me.ProgrammeDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(3)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProgrammeDataGrid.DefaultCellStyle = DataGridViewCellStyle1
        Me.ProgrammeDataGrid.Location = New System.Drawing.Point(5, 42)
        Me.ProgrammeDataGrid.Name = "ProgrammeDataGrid"
        Me.ProgrammeDataGrid.ReadOnly = True
        Me.ProgrammeDataGrid.Size = New System.Drawing.Size(569, 209)
        Me.ProgrammeDataGrid.TabIndex = 46
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Guna2Panel1.Controls.Add(Me.btnClear)
        Me.Guna2Panel1.Controls.Add(Me.btnAdd)
        Me.Guna2Panel1.Controls.Add(Me.btnDelete)
        Me.Guna2Panel1.Controls.Add(Me.btnUpdate)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(5, 446)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(570, 54)
        Me.Guna2Panel1.TabIndex = 45
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
        Me.btnClear.Location = New System.Drawing.Point(279, 13)
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
        Me.btnAdd.Location = New System.Drawing.Point(51, 14)
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
        Me.btnDelete.Location = New System.Drawing.Point(396, 14)
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
        Me.btnUpdate.Location = New System.Drawing.Point(164, 14)
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
        'GunaPanel3
        '
        Me.GunaPanel3.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel3.Location = New System.Drawing.Point(0, 5)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(5, 495)
        Me.GunaPanel3.TabIndex = 41
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Purple
        Me.GunaLabel1.Location = New System.Drawing.Point(183, 8)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(213, 30)
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
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 500)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(575, 5)
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
        Me.GunaPanel4.Location = New System.Drawing.Point(575, 5)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(5, 500)
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
        'GunaPanel5
        '
        Me.GunaPanel5.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel5.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(580, 5)
        Me.GunaPanel5.TabIndex = 40
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
        Me.Panel6.Location = New System.Drawing.Point(8, 253)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(566, 199)
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
        Me.btnCose.Location = New System.Drawing.Point(533, 8)
        Me.btnCose.Name = "btnCose"
        Me.btnCose.OnHoverBaseColor = System.Drawing.Color.Red
        Me.btnCose.OnHoverBorderColor = System.Drawing.Color.Red
        Me.btnCose.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCose.OnHoverImage = Nothing
        Me.btnCose.OnPressedColor = System.Drawing.Color.Black
        Me.btnCose.Size = New System.Drawing.Size(37, 26)
        Me.btnCose.TabIndex = 47
        Me.btnCose.Text = "X"
        Me.btnCose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me
        '
        'ManageProgrammes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 505)
        Me.Controls.Add(Me.btnCose)
        Me.Controls.Add(Me.ProgrammeDataGrid)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.GunaPanel3)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Controls.Add(Me.GunaPanel5)
        Me.Controls.Add(Me.Panel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageProgrammes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Programmes"
        CType(Me.ProgrammeDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtsearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ProgrammeDataGrid As DataGridView
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnClear As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAdd As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDelete As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnUpdate As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnsearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents txtPname As TextBox
    Friend WithEvents VenueCombo As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents departmentCombo As ComboBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtId As TextBox
    Friend WithEvents btnCose As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
End Class
