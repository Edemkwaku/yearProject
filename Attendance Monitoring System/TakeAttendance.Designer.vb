<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TakeAttendance
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.buttonClose = New Guna.UI2.WinForms.Guna2Button()
        Me.t = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.courseCombo = New System.Windows.Forms.ComboBox()
        Me.comboLecturer = New System.Windows.Forms.ComboBox()
        Me.ClassComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Purple
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(628, 5)
        Me.Guna2Panel1.TabIndex = 2
        '
        'buttonClose
        '
        Me.buttonClose.BackColor = System.Drawing.SystemColors.Control
        Me.buttonClose.BorderColor = System.Drawing.Color.Red
        Me.buttonClose.BorderThickness = 1
        Me.buttonClose.CheckedState.Parent = Me.buttonClose
        Me.buttonClose.CustomImages.Parent = Me.buttonClose
        Me.buttonClose.FillColor = System.Drawing.SystemColors.Control
        Me.buttonClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonClose.ForeColor = System.Drawing.Color.Black
        Me.buttonClose.HoverState.BorderColor = System.Drawing.Color.Red
        Me.buttonClose.HoverState.FillColor = System.Drawing.Color.Red
        Me.buttonClose.HoverState.ForeColor = System.Drawing.Color.White
        Me.buttonClose.HoverState.Parent = Me.buttonClose
        Me.buttonClose.Location = New System.Drawing.Point(583, 8)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.ShadowDecoration.Parent = Me.buttonClose
        Me.buttonClose.Size = New System.Drawing.Size(36, 30)
        Me.buttonClose.TabIndex = 1
        Me.buttonClose.Text = "X"
        '
        't
        '
        Me.t.AutoSize = True
        Me.t.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t.ForeColor = System.Drawing.Color.Purple
        Me.t.Location = New System.Drawing.Point(252, 15)
        Me.t.Name = "t"
        Me.t.Size = New System.Drawing.Size(176, 30)
        Me.t.TabIndex = 0
        Me.t.Text = "Take Attendance"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 316)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(628, 5)
        Me.Panel1.TabIndex = 4
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 5
        Me.Guna2Panel2.Controls.Add(Me.btnSubmit)
        Me.Guna2Panel2.Controls.Add(Me.txtID)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(26, 105)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Color = System.Drawing.Color.Gray
        Me.Guna2Panel2.ShadowDecoration.Enabled = True
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(278, 183)
        Me.Guna2Panel2.TabIndex = 5
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.BorderColor = System.Drawing.Color.Green
        Me.btnSubmit.BorderRadius = 2
        Me.btnSubmit.BorderThickness = 1
        Me.btnSubmit.CheckedState.Parent = Me.btnSubmit
        Me.btnSubmit.CustomImages.Parent = Me.btnSubmit
        Me.btnSubmit.FillColor = System.Drawing.Color.White
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.Green
        Me.btnSubmit.HoverState.BorderColor = System.Drawing.Color.Lime
        Me.btnSubmit.HoverState.FillColor = System.Drawing.Color.Green
        Me.btnSubmit.HoverState.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubmit.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.HoverState.Parent = Me.btnSubmit
        Me.btnSubmit.Location = New System.Drawing.Point(51, 133)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.ShadowDecoration.Color = System.Drawing.Color.Gray
        Me.btnSubmit.ShadowDecoration.Depth = 20
        Me.btnSubmit.ShadowDecoration.Enabled = True
        Me.btnSubmit.ShadowDecoration.Parent = Me.btnSubmit
        Me.btnSubmit.Size = New System.Drawing.Size(136, 36)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Mark"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(108, 82)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(151, 27)
        Me.txtID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Student ID "
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderRadius = 5
        Me.Guna2Panel3.Controls.Add(Me.courseCombo)
        Me.Guna2Panel3.Controls.Add(Me.comboLecturer)
        Me.Guna2Panel3.Controls.Add(Me.ClassComboBox)
        Me.Guna2Panel3.Controls.Add(Me.Label4)
        Me.Guna2Panel3.Controls.Add(Me.Label3)
        Me.Guna2Panel3.Controls.Add(Me.Label5)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(310, 105)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Color = System.Drawing.Color.Gray
        Me.Guna2Panel3.ShadowDecoration.Enabled = True
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(297, 183)
        Me.Guna2Panel3.TabIndex = 6
        '
        'courseCombo
        '
        Me.courseCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.courseCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.courseCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.courseCombo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseCombo.FormattingEnabled = True
        Me.courseCombo.Location = New System.Drawing.Point(125, 140)
        Me.courseCombo.Name = "courseCombo"
        Me.courseCombo.Size = New System.Drawing.Size(151, 29)
        Me.courseCombo.TabIndex = 3
        '
        'comboLecturer
        '
        Me.comboLecturer.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.comboLecturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboLecturer.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboLecturer.FormattingEnabled = True
        Me.comboLecturer.Location = New System.Drawing.Point(125, 91)
        Me.comboLecturer.Name = "comboLecturer"
        Me.comboLecturer.Size = New System.Drawing.Size(151, 29)
        Me.comboLecturer.TabIndex = 3
        '
        'ClassComboBox
        '
        Me.ClassComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ClassComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ClassComboBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassComboBox.FormattingEnabled = True
        Me.ClassComboBox.Location = New System.Drawing.Point(125, 40)
        Me.ClassComboBox.Name = "ClassComboBox"
        Me.ClassComboBox.Size = New System.Drawing.Size(151, 29)
        Me.ClassComboBox.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Class Lecture "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Course"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(63, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Class "
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 5)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(5, 311)
        Me.GunaPanel1.TabIndex = 7
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaPanel2.Location = New System.Drawing.Point(623, 5)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(5, 311)
        Me.GunaPanel2.TabIndex = 8
        '
        'TakeAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 321)
        Me.Controls.Add(Me.t)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TakeAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TakeAttendance"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents buttonClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents t As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ClassComboBox As ComboBox
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents comboLecturer As ComboBox
    Friend WithEvents courseCombo As ComboBox
End Class
