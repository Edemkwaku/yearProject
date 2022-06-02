<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Attendance
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridAttendance = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.CoursesCombo = New Guna.UI.WinForms.GunaComboBox()
        Me.txtsearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnSearch = New Guna.UI.WinForms.GunaButton()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.ClassCombo = New Guna.UI.WinForms.GunaComboBox()
        CType(Me.DataGridAttendance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Purple
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(722, 5)
        Me.Guna2Panel1.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Purple
        Me.btnClose.BorderColor = System.Drawing.Color.Red
        Me.btnClose.BorderThickness = 1
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.SystemColors.Control
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.HoverState.BorderColor = System.Drawing.Color.Red
        Me.btnClose.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnClose.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(675, 11)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(36, 26)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(253, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Students Attendance"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 570)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(722, 5)
        Me.Panel1.TabIndex = 3
        '
        'DataGridAttendance
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridAttendance.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridAttendance.BackgroundColor = System.Drawing.Color.White
        Me.DataGridAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridAttendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridAttendance.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridAttendance.ColumnHeadersHeight = 25
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridAttendance.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridAttendance.EnableHeadersVisualStyles = False
        Me.DataGridAttendance.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridAttendance.Location = New System.Drawing.Point(94, 159)
        Me.DataGridAttendance.Name = "DataGridAttendance"
        Me.DataGridAttendance.RowHeadersVisible = False
        Me.DataGridAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridAttendance.Size = New System.Drawing.Size(507, 344)
        Me.DataGridAttendance.TabIndex = 4
        Me.DataGridAttendance.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.DataGridAttendance.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridAttendance.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridAttendance.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridAttendance.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridAttendance.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridAttendance.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridAttendance.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridAttendance.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridAttendance.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridAttendance.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGridAttendance.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridAttendance.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridAttendance.ThemeStyle.HeaderStyle.Height = 25
        Me.DataGridAttendance.ThemeStyle.ReadOnly = False
        Me.DataGridAttendance.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridAttendance.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridAttendance.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGridAttendance.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DataGridAttendance.ThemeStyle.RowsStyle.Height = 22
        Me.DataGridAttendance.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridAttendance.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'CoursesCombo
        '
        Me.CoursesCombo.BackColor = System.Drawing.Color.Transparent
        Me.CoursesCombo.BaseColor = System.Drawing.Color.White
        Me.CoursesCombo.BorderColor = System.Drawing.Color.Silver
        Me.CoursesCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CoursesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CoursesCombo.FocusedColor = System.Drawing.Color.Empty
        Me.CoursesCombo.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoursesCombo.ForeColor = System.Drawing.Color.Black
        Me.CoursesCombo.FormattingEnabled = True
        Me.CoursesCombo.Items.AddRange(New Object() {"Select Course"})
        Me.CoursesCombo.Location = New System.Drawing.Point(18, 74)
        Me.CoursesCombo.Name = "CoursesCombo"
        Me.CoursesCombo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CoursesCombo.OnHoverItemForeColor = System.Drawing.Color.White
        Me.CoursesCombo.Size = New System.Drawing.Size(142, 28)
        Me.CoursesCombo.TabIndex = 5
        '
        'txtsearch
        '
        Me.txtsearch.Animated = True
        Me.txtsearch.BackColor = System.Drawing.Color.Transparent
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
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.ForeColor = System.Drawing.Color.Gray
        Me.txtsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsearch.HoverState.Parent = Me.txtsearch
        Me.txtsearch.Location = New System.Drawing.Point(207, 75)
        Me.txtsearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.txtsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsearch.PlaceholderText = "Enter student number"
        Me.txtsearch.SelectedText = ""
        Me.txtsearch.ShadowDecoration.BorderRadius = 2
        Me.txtsearch.ShadowDecoration.Depth = 5
        Me.txtsearch.ShadowDecoration.Enabled = True
        Me.txtsearch.ShadowDecoration.Parent = Me.txtsearch
        Me.txtsearch.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(3)
        Me.txtsearch.Size = New System.Drawing.Size(200, 23)
        Me.txtsearch.TabIndex = 6
        '
        'btnSearch
        '
        Me.btnSearch.AnimationHoverSpeed = 0.07!
        Me.btnSearch.AnimationSpeed = 0.03!
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.BaseColor = System.Drawing.Color.Green
        Me.btnSearch.BorderColor = System.Drawing.Color.Green
        Me.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSearch.FocusedColor = System.Drawing.Color.Empty
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Image = Nothing
        Me.btnSearch.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSearch.Location = New System.Drawing.Point(408, 75)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSearch.OnHoverBorderColor = System.Drawing.Color.Green
        Me.btnSearch.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSearch.OnHoverImage = Nothing
        Me.btnSearch.OnPressedColor = System.Drawing.Color.Black
        Me.btnSearch.Radius = 2
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaPanel1.Location = New System.Drawing.Point(717, 5)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(5, 565)
        Me.GunaPanel1.TabIndex = 8
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 5)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(5, 565)
        Me.GunaPanel2.TabIndex = 9
        '
        'ClassCombo
        '
        Me.ClassCombo.BackColor = System.Drawing.Color.Transparent
        Me.ClassCombo.BaseColor = System.Drawing.Color.White
        Me.ClassCombo.BorderColor = System.Drawing.Color.Silver
        Me.ClassCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ClassCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ClassCombo.FocusedColor = System.Drawing.Color.Empty
        Me.ClassCombo.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassCombo.ForeColor = System.Drawing.Color.Black
        Me.ClassCombo.FormattingEnabled = True
        Me.ClassCombo.Items.AddRange(New Object() {"Select Course"})
        Me.ClassCombo.Location = New System.Drawing.Point(541, 75)
        Me.ClassCombo.Name = "ClassCombo"
        Me.ClassCombo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClassCombo.OnHoverItemForeColor = System.Drawing.Color.White
        Me.ClassCombo.Size = New System.Drawing.Size(142, 28)
        Me.ClassCombo.TabIndex = 5
        '
        'Attendance
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 575)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.ClassCombo)
        Me.Controls.Add(Me.CoursesCombo)
        Me.Controls.Add(Me.DataGridAttendance)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Attendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Attendance"
        CType(Me.DataGridAttendance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridAttendance As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents CoursesCombo As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents txtsearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnSearch As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents ClassCombo As Guna.UI.WinForms.GunaComboBox
End Class
