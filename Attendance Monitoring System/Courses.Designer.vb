<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Courses
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
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.btnCose = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Duration = New System.Windows.Forms.TextBox()
        Me.txtEnd = New System.Windows.Forms.TextBox()
        Me.txtStart = New System.Windows.Forms.TextBox()
        Me.txtCoursename = New System.Windows.Forms.TextBox()
        Me.txtCoursecode = New System.Windows.Forms.TextBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.LecturerCombo = New System.Windows.Forms.ComboBox()
        Me.ProgrammeCombo = New System.Windows.Forms.ComboBox()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.VenueCombo = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.btnAdd = New Guna.UI.WinForms.GunaButton()
        Me.btnUpdate = New Guna.UI.WinForms.GunaButton()
        Me.btnClear = New Guna.UI.WinForms.GunaButton()
        Me.btnDelete = New Guna.UI.WinForms.GunaButton()
        Me.GunaPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 304)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(579, 5)
        Me.GunaPanel2.TabIndex = 0
        '
        'GunaPanel3
        '
        Me.GunaPanel3.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel3.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(5, 304)
        Me.GunaPanel3.TabIndex = 0
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel4.Controls.Add(Me.btnCose)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel4.Location = New System.Drawing.Point(5, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(574, 26)
        Me.GunaPanel4.TabIndex = 0
        '
        'btnCose
        '
        Me.btnCose.AnimationHoverSpeed = 0.07!
        Me.btnCose.AnimationSpeed = 0.03!
        Me.btnCose.BaseColor = System.Drawing.Color.Red
        Me.btnCose.BorderColor = System.Drawing.Color.Red
        Me.btnCose.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCose.FocusedColor = System.Drawing.Color.Empty
        Me.btnCose.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCose.ForeColor = System.Drawing.Color.White
        Me.btnCose.Image = Nothing
        Me.btnCose.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCose.Location = New System.Drawing.Point(537, 0)
        Me.btnCose.Name = "btnCose"
        Me.btnCose.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCose.OnHoverBorderColor = System.Drawing.Color.Red
        Me.btnCose.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCose.OnHoverImage = Nothing
        Me.btnCose.OnPressedColor = System.Drawing.Color.Black
        Me.btnCose.Size = New System.Drawing.Size(37, 26)
        Me.btnCose.TabIndex = 4
        Me.btnCose.Text = "X"
        Me.btnCose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Plum
        Me.GunaLabel1.Location = New System.Drawing.Point(7, 2)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(139, 21)
        Me.GunaLabel1.TabIndex = 2
        Me.GunaLabel1.Text = "Manage Courses "
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaPanel1.Location = New System.Drawing.Point(574, 26)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(5, 278)
        Me.GunaPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Duration)
        Me.Panel1.Controls.Add(Me.txtEnd)
        Me.Panel1.Controls.Add(Me.txtStart)
        Me.Panel1.Controls.Add(Me.txtCoursename)
        Me.Panel1.Controls.Add(Me.txtCoursecode)
        Me.Panel1.Controls.Add(Me.ComboBox3)
        Me.Panel1.Controls.Add(Me.LecturerCombo)
        Me.Panel1.Controls.Add(Me.ProgrammeCombo)
        Me.Panel1.Controls.Add(Me.GunaLabel9)
        Me.Panel1.Controls.Add(Me.GunaLabel8)
        Me.Panel1.Controls.Add(Me.VenueCombo)
        Me.Panel1.Controls.Add(Me.GunaLabel6)
        Me.Panel1.Controls.Add(Me.GunaLabel5)
        Me.Panel1.Controls.Add(Me.GunaLabel4)
        Me.Panel1.Controls.Add(Me.GunaLabel3)
        Me.Panel1.Controls.Add(Me.GunaLabel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(556, 177)
        Me.Panel1.TabIndex = 2
        '
        'Duration
        '
        Me.Duration.Location = New System.Drawing.Point(119, 88)
        Me.Duration.Name = "Duration"
        Me.Duration.Size = New System.Drawing.Size(135, 20)
        Me.Duration.TabIndex = 17
        '
        'txtEnd
        '
        Me.txtEnd.Location = New System.Drawing.Point(393, 119)
        Me.txtEnd.Name = "txtEnd"
        Me.txtEnd.Size = New System.Drawing.Size(135, 20)
        Me.txtEnd.TabIndex = 18
        '
        'txtStart
        '
        Me.txtStart.Location = New System.Drawing.Point(393, 89)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(135, 20)
        Me.txtStart.TabIndex = 19
        '
        'txtCoursename
        '
        Me.txtCoursename.Location = New System.Drawing.Point(119, 56)
        Me.txtCoursename.Name = "txtCoursename"
        Me.txtCoursename.Size = New System.Drawing.Size(135, 20)
        Me.txtCoursename.TabIndex = 20
        '
        'txtCoursecode
        '
        Me.txtCoursecode.Location = New System.Drawing.Point(119, 26)
        Me.txtCoursecode.Name = "txtCoursecode"
        Me.txtCoursecode.Size = New System.Drawing.Size(135, 20)
        Me.txtCoursecode.TabIndex = 21
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(393, 58)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(135, 21)
        Me.ComboBox3.TabIndex = 14
        '
        'LecturerCombo
        '
        Me.LecturerCombo.FormattingEnabled = True
        Me.LecturerCombo.Location = New System.Drawing.Point(393, 28)
        Me.LecturerCombo.Name = "LecturerCombo"
        Me.LecturerCombo.Size = New System.Drawing.Size(135, 21)
        Me.LecturerCombo.TabIndex = 15
        '
        'ProgrammeCombo
        '
        Me.ProgrammeCombo.FormattingEnabled = True
        Me.ProgrammeCombo.Location = New System.Drawing.Point(119, 123)
        Me.ProgrammeCombo.Name = "ProgrammeCombo"
        Me.ProgrammeCombo.Size = New System.Drawing.Size(135, 21)
        Me.ProgrammeCombo.TabIndex = 16
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel9.Location = New System.Drawing.Point(309, 124)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(56, 15)
        Me.GunaLabel9.TabIndex = 6
        Me.GunaLabel9.Text = "End Time"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel8.Location = New System.Drawing.Point(309, 92)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(60, 15)
        Me.GunaLabel8.TabIndex = 7
        Me.GunaLabel8.Text = "Start Time"
        '
        'VenueCombo
        '
        Me.VenueCombo.AutoSize = True
        Me.VenueCombo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.VenueCombo.Location = New System.Drawing.Point(309, 60)
        Me.VenueCombo.Name = "VenueCombo"
        Me.VenueCombo.Size = New System.Drawing.Size(39, 15)
        Me.VenueCombo.TabIndex = 8
        Me.VenueCombo.Text = "Venue"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel6.Location = New System.Drawing.Point(309, 28)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(50, 15)
        Me.GunaLabel6.TabIndex = 9
        Me.GunaLabel6.Text = "Lecturer"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel5.Location = New System.Drawing.Point(20, 122)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(70, 15)
        Me.GunaLabel5.TabIndex = 10
        Me.GunaLabel5.Text = "Programme"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel4.Location = New System.Drawing.Point(20, 90)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(53, 15)
        Me.GunaLabel4.TabIndex = 11
        Me.GunaLabel4.Text = "Duration"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(20, 58)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(79, 15)
        Me.GunaLabel3.TabIndex = 12
        Me.GunaLabel3.Text = "Course Name"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(20, 26)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(73, 15)
        Me.GunaLabel2.TabIndex = 13
        Me.GunaLabel2.Text = "Course code"
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
        Me.btnAdd.Location = New System.Drawing.Point(146, 254)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdd.OnHoverBorderColor = System.Drawing.Color.Green
        Me.btnAdd.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAdd.OnHoverImage = Nothing
        Me.btnAdd.OnPressedColor = System.Drawing.Color.Black
        Me.btnAdd.Radius = 3
        Me.btnAdd.Size = New System.Drawing.Size(76, 25)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnUpdate.Location = New System.Drawing.Point(228, 254)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Orange
        Me.btnUpdate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUpdate.OnHoverImage = Nothing
        Me.btnUpdate.OnPressedColor = System.Drawing.Color.Black
        Me.btnUpdate.Radius = 3
        Me.btnUpdate.Size = New System.Drawing.Size(76, 25)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnClear.Location = New System.Drawing.Point(310, 254)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClear.OnHoverImage = Nothing
        Me.btnClear.OnPressedColor = System.Drawing.Color.Black
        Me.btnClear.Radius = 3
        Me.btnClear.Size = New System.Drawing.Size(76, 25)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnDelete.Location = New System.Drawing.Point(392, 254)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDelete.OnHoverBorderColor = System.Drawing.Color.Red
        Me.btnDelete.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDelete.OnHoverImage = Nothing
        Me.btnDelete.OnPressedColor = System.Drawing.Color.Black
        Me.btnDelete.Radius = 3
        Me.btnDelete.Size = New System.Drawing.Size(76, 25)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Courses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 309)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Controls.Add(Me.GunaPanel3)
        Me.Controls.Add(Me.GunaPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Courses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Courses"
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnCose As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Duration As TextBox
    Friend WithEvents txtEnd As TextBox
    Friend WithEvents txtStart As TextBox
    Friend WithEvents txtCoursename As TextBox
    Friend WithEvents txtCoursecode As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents LecturerCombo As ComboBox
    Friend WithEvents ProgrammeCombo As ComboBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents VenueCombo As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnAdd As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnUpdate As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnClear As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnDelete As Guna.UI.WinForms.GunaButton
End Class
