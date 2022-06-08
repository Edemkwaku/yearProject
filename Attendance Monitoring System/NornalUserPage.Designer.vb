<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NornalUserPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NornalUserPage))
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.username = New Guna.UI.WinForms.GunaLabel()
        Me.btnLogout = New Guna.UI.WinForms.GunaButton()
        Me.btnClose = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.btnViewAttendance = New Guna.UI.WinForms.GunaButton()
        Me.btnMarkAttendance = New Guna.UI.WinForms.GunaButton()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.btnMinimize = New Guna.UI2.WinForms.Guna2Button()
        Me.txtDate = New System.Windows.Forms.Label()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.GunaPanel1.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel1.Controls.Add(Me.txtDate)
        Me.GunaPanel1.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel1.Controls.Add(Me.btnMinimize)
        Me.GunaPanel1.Controls.Add(Me.username)
        Me.GunaPanel1.Controls.Add(Me.btnLogout)
        Me.GunaPanel1.Controls.Add(Me.btnClose)
        Me.GunaPanel1.Controls.Add(Me.Label1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1219, 38)
        Me.GunaPanel1.TabIndex = 0
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.ForeColor = System.Drawing.Color.Violet
        Me.username.Location = New System.Drawing.Point(819, 9)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(74, 20)
        Me.username.TabIndex = 6
        Me.username.Text = "Welcome"
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
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = Nothing
        Me.btnLogout.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLogout.Location = New System.Drawing.Point(1029, 0)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLogout.OnHoverBorderColor = System.Drawing.Color.Orange
        Me.btnLogout.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLogout.OnHoverImage = Nothing
        Me.btnLogout.OnPressedColor = System.Drawing.Color.Black
        Me.btnLogout.Size = New System.Drawing.Size(92, 38)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnClose.Location = New System.Drawing.Point(1166, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClose.OnHoverBorderColor = System.Drawing.Color.Red
        Me.btnClose.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClose.OnHoverImage = Nothing
        Me.btnClose.OnPressedColor = System.Drawing.Color.Black
        Me.btnClose.Size = New System.Drawing.Size(50, 38)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "X"
        Me.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Plum
        Me.Label1.Location = New System.Drawing.Point(265, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Course Representative Page"
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 697)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(1219, 5)
        Me.GunaPanel2.TabIndex = 1
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaPanel4.Location = New System.Drawing.Point(1214, 38)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(5, 659)
        Me.GunaPanel4.TabIndex = 3
        '
        'GunaPanel5
        '
        Me.GunaPanel5.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel5.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.GunaPanel5.Controls.Add(Me.btnViewAttendance)
        Me.GunaPanel5.Controls.Add(Me.btnMarkAttendance)
        Me.GunaPanel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel5.Location = New System.Drawing.Point(0, 38)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(155, 659)
        Me.GunaPanel5.TabIndex = 4
        '
        'btnViewAttendance
        '
        Me.btnViewAttendance.AnimationHoverSpeed = 0.07!
        Me.btnViewAttendance.AnimationSpeed = 0.03!
        Me.btnViewAttendance.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnViewAttendance.BorderColor = System.Drawing.Color.Blue
        Me.btnViewAttendance.BorderSize = 1
        Me.btnViewAttendance.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnViewAttendance.FocusedColor = System.Drawing.Color.Empty
        Me.btnViewAttendance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnViewAttendance.ForeColor = System.Drawing.Color.White
        Me.btnViewAttendance.Image = CType(resources.GetObject("btnViewAttendance.Image"), System.Drawing.Image)
        Me.btnViewAttendance.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnViewAttendance.Location = New System.Drawing.Point(0, 276)
        Me.btnViewAttendance.Name = "btnViewAttendance"
        Me.btnViewAttendance.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnViewAttendance.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnViewAttendance.OnHoverForeColor = System.Drawing.Color.White
        Me.btnViewAttendance.OnHoverImage = Nothing
        Me.btnViewAttendance.OnPressedColor = System.Drawing.Color.Black
        Me.btnViewAttendance.Size = New System.Drawing.Size(155, 46)
        Me.btnViewAttendance.TabIndex = 5
        Me.btnViewAttendance.Text = " View Attendance"
        Me.btnViewAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnMarkAttendance
        '
        Me.btnMarkAttendance.AnimationHoverSpeed = 0.07!
        Me.btnMarkAttendance.AnimationSpeed = 0.03!
        Me.btnMarkAttendance.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMarkAttendance.BorderColor = System.Drawing.Color.Blue
        Me.btnMarkAttendance.BorderSize = 1
        Me.btnMarkAttendance.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMarkAttendance.FocusedColor = System.Drawing.Color.Empty
        Me.btnMarkAttendance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnMarkAttendance.ForeColor = System.Drawing.Color.White
        Me.btnMarkAttendance.Image = CType(resources.GetObject("btnMarkAttendance.Image"), System.Drawing.Image)
        Me.btnMarkAttendance.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnMarkAttendance.Location = New System.Drawing.Point(-1, 321)
        Me.btnMarkAttendance.Name = "btnMarkAttendance"
        Me.btnMarkAttendance.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnMarkAttendance.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnMarkAttendance.OnHoverForeColor = System.Drawing.Color.White
        Me.btnMarkAttendance.OnHoverImage = Nothing
        Me.btnMarkAttendance.OnPressedColor = System.Drawing.Color.Black
        Me.btnMarkAttendance.Size = New System.Drawing.Size(155, 46)
        Me.btnMarkAttendance.TabIndex = 5
        Me.btnMarkAttendance.Text = "         Mark Attendance"
        Me.btnMarkAttendance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.GunaPanel1
        '
        'btnMinimize
        '
        Me.btnMinimize.CheckedState.Parent = Me.btnMinimize
        Me.btnMinimize.CustomImages.Parent = Me.btnMinimize
        Me.btnMinimize.FillColor = System.Drawing.Color.Silver
        Me.btnMinimize.Font = New System.Drawing.Font("Segoe UI Black", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.Black
        Me.btnMinimize.HoverState.Parent = Me.btnMinimize
        Me.btnMinimize.Location = New System.Drawing.Point(1121, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.ShadowDecoration.Parent = Me.btnMinimize
        Me.btnMinimize.Size = New System.Drawing.Size(45, 38)
        Me.btnMinimize.TabIndex = 19
        Me.btnMinimize.Text = "-"
        '
        'txtDate
        '
        Me.txtDate.AutoSize = True
        Me.txtDate.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtDate.ForeColor = System.Drawing.Color.Orange
        Me.txtDate.Location = New System.Drawing.Point(33, 5)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(70, 25)
        Me.txtDate.TabIndex = 21
        Me.txtDate.Text = "Label2"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(771, 6)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(28, 28)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 20
        Me.GunaPictureBox1.TabStop = False
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(3, 29)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(149, 149)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox1.TabIndex = 6
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'NornalUserPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 702)
        Me.Controls.Add(Me.GunaPanel5)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NornalUserPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NornalUserPage"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnViewAttendance As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnMarkAttendance As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnLogout As Guna.UI.WinForms.GunaButton
    Friend WithEvents username As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents btnMinimize As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtDate As Label
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
End Class
