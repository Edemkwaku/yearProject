<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.btnClose = New Guna.UI.WinForms.GunaButton()
        Me.ProgramCombo = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaDataGridView1 = New Guna.UI.WinForms.GunaDataGridView()
        Me.btnSubmit = New Guna.UI.WinForms.GunaButton()
        Me.txtStudentid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnPrint = New Guna.UI.WinForms.GunaButton()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel1.Controls.Add(Me.btnClose)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(780, 26)
        Me.GunaPanel1.TabIndex = 0
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaPanel2.Location = New System.Drawing.Point(775, 26)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(5, 373)
        Me.GunaPanel2.TabIndex = 0
        '
        'GunaPanel3
        '
        Me.GunaPanel3.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel3.Location = New System.Drawing.Point(0, 26)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(5, 373)
        Me.GunaPanel3.TabIndex = 0
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaPanel4.Location = New System.Drawing.Point(5, 394)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(770, 5)
        Me.GunaPanel4.TabIndex = 0
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Plum
        Me.GunaLabel1.Location = New System.Drawing.Point(9, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(104, 21)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Report Form"
        '
        'btnClose
        '
        Me.btnClose.AnimationHoverSpeed = 0.07!
        Me.btnClose.AnimationSpeed = 0.03!
        Me.btnClose.BaseColor = System.Drawing.Color.Red
        Me.btnClose.BorderColor = System.Drawing.Color.Red
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClose.FocusedColor = System.Drawing.Color.Empty
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = Nothing
        Me.btnClose.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnClose.Location = New System.Drawing.Point(743, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.OnHoverBorderColor = System.Drawing.Color.Red
        Me.btnClose.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClose.OnHoverImage = Nothing
        Me.btnClose.OnPressedColor = System.Drawing.Color.Black
        Me.btnClose.Size = New System.Drawing.Size(37, 26)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "X"
        Me.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProgramCombo
        '
        Me.ProgramCombo.BackColor = System.Drawing.Color.Transparent
        Me.ProgramCombo.BaseColor = System.Drawing.Color.White
        Me.ProgramCombo.BorderColor = System.Drawing.Color.Silver
        Me.ProgramCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ProgramCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProgramCombo.FocusedColor = System.Drawing.Color.Empty
        Me.ProgramCombo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgramCombo.ForeColor = System.Drawing.Color.Black
        Me.ProgramCombo.FormattingEnabled = True
        Me.ProgramCombo.Location = New System.Drawing.Point(13, 41)
        Me.ProgramCombo.Name = "ProgramCombo"
        Me.ProgramCombo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ProgramCombo.OnHoverItemForeColor = System.Drawing.Color.White
        Me.ProgramCombo.Size = New System.Drawing.Size(121, 24)
        Me.ProgramCombo.TabIndex = 1
        '
        'GunaDataGridView1
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.GunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GunaDataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.GunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GunaDataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.GunaDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GunaDataGridView1.DefaultCellStyle = DataGridViewCellStyle9
        Me.GunaDataGridView1.EnableHeadersVisualStyles = False
        Me.GunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.Location = New System.Drawing.Point(154, 91)
        Me.GunaDataGridView1.Name = "GunaDataGridView1"
        Me.GunaDataGridView1.RowHeadersVisible = False
        Me.GunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GunaDataGridView1.Size = New System.Drawing.Size(565, 273)
        Me.GunaDataGridView1.TabIndex = 2
        Me.GunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.GunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GunaDataGridView1.ThemeStyle.HeaderStyle.Height = 4
        Me.GunaDataGridView1.ThemeStyle.ReadOnly = False
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.Height = 22
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'btnSubmit
        '
        Me.btnSubmit.Animated = True
        Me.btnSubmit.AnimationHoverSpeed = 0.07!
        Me.btnSubmit.AnimationSpeed = 0.03!
        Me.btnSubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.BaseColor = System.Drawing.Color.Green
        Me.btnSubmit.BorderColor = System.Drawing.Color.Green
        Me.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSubmit.FocusedColor = System.Drawing.Color.Empty
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.Aquamarine
        Me.btnSubmit.Image = Nothing
        Me.btnSubmit.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSubmit.Location = New System.Drawing.Point(353, 41)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubmit.OnHoverBorderColor = System.Drawing.Color.Green
        Me.btnSubmit.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSubmit.OnHoverImage = Nothing
        Me.btnSubmit.OnPressedColor = System.Drawing.Color.Black
        Me.btnSubmit.Radius = 3
        Me.btnSubmit.Size = New System.Drawing.Size(53, 25)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStudentid
        '
        Me.txtStudentid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentid.DefaultText = ""
        Me.txtStudentid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtStudentid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtStudentid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentid.DisabledState.Parent = Me.txtStudentid
        Me.txtStudentid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtStudentid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentid.FocusedState.Parent = Me.txtStudentid
        Me.txtStudentid.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtStudentid.HoverState.Parent = Me.txtStudentid
        Me.txtStudentid.Location = New System.Drawing.Point(154, 41)
        Me.txtStudentid.Name = "txtStudentid"
        Me.txtStudentid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStudentid.PlaceholderText = "Enter student ID"
        Me.txtStudentid.SelectedText = ""
        Me.txtStudentid.ShadowDecoration.Parent = Me.txtStudentid
        Me.txtStudentid.Size = New System.Drawing.Size(199, 25)
        Me.txtStudentid.TabIndex = 5
        '
        'btnPrint
        '
        Me.btnPrint.AnimationHoverSpeed = 0.07!
        Me.btnPrint.AnimationSpeed = 0.03!
        Me.btnPrint.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint.BaseColor = System.Drawing.Color.Orange
        Me.btnPrint.BorderColor = System.Drawing.Color.Black
        Me.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPrint.FocusedColor = System.Drawing.Color.Empty
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Image = Nothing
        Me.btnPrint.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnPrint.Location = New System.Drawing.Point(650, 41)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPrint.OnHoverBorderColor = System.Drawing.Color.Orange
        Me.btnPrint.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPrint.OnHoverImage = Nothing
        Me.btnPrint.OnPressedColor = System.Drawing.Color.Black
        Me.btnPrint.Radius = 3
        Me.btnPrint.Size = New System.Drawing.Size(88, 24)
        Me.btnPrint.TabIndex = 6
        Me.btnPrint.Text = "Print Report"
        Me.btnPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 399)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtStudentid)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.GunaDataGridView1)
        Me.Controls.Add(Me.ProgramCombo)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Controls.Add(Me.GunaPanel3)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Report"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.GunaDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ProgramCombo As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaDataGridView1 As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents btnSubmit As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtStudentid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnPrint As Guna.UI.WinForms.GunaButton
End Class
