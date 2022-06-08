<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sign_In
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sign_In))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.buttonClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtforgetpassword = New Guna.UI.WinForms.GunaLabel()
        Me.button_SignIn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUserPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel2.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Purple
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(440, 5)
        Me.Guna2Panel1.TabIndex = 2
        '
        'buttonClose
        '
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
        Me.buttonClose.Location = New System.Drawing.Point(395, 9)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.ShadowDecoration.Parent = Me.buttonClose
        Me.buttonClose.Size = New System.Drawing.Size(36, 30)
        Me.buttonClose.TabIndex = 1
        Me.buttonClose.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Purple
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Login"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.txtUserPassword)
        Me.Guna2Panel2.Controls.Add(Me.txtUsername)
        Me.Guna2Panel2.Controls.Add(Me.txtforgetpassword)
        Me.Guna2Panel2.Controls.Add(Me.button_SignIn)
        Me.Guna2Panel2.Location = New System.Drawing.Point(23, 74)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(391, 203)
        Me.Guna2Panel2.TabIndex = 3
        '
        'txtforgetpassword
        '
        Me.txtforgetpassword.AutoSize = True
        Me.txtforgetpassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtforgetpassword.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtforgetpassword.Location = New System.Drawing.Point(200, 120)
        Me.txtforgetpassword.Name = "txtforgetpassword"
        Me.txtforgetpassword.Size = New System.Drawing.Size(107, 17)
        Me.txtforgetpassword.TabIndex = 4
        Me.txtforgetpassword.Text = "Forget password"
        '
        'button_SignIn
        '
        Me.button_SignIn.CheckedState.Parent = Me.button_SignIn
        Me.button_SignIn.CustomImages.Parent = Me.button_SignIn
        Me.button_SignIn.FillColor = System.Drawing.Color.RoyalBlue
        Me.button_SignIn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_SignIn.ForeColor = System.Drawing.Color.White
        Me.button_SignIn.HoverState.Parent = Me.button_SignIn
        Me.button_SignIn.Location = New System.Drawing.Point(133, 155)
        Me.button_SignIn.Name = "button_SignIn"
        Me.button_SignIn.ShadowDecoration.Color = System.Drawing.Color.Gray
        Me.button_SignIn.ShadowDecoration.Depth = 20
        Me.button_SignIn.ShadowDecoration.Enabled = True
        Me.button_SignIn.ShadowDecoration.Parent = Me.button_SignIn
        Me.button_SignIn.Size = New System.Drawing.Size(105, 30)
        Me.button_SignIn.TabIndex = 3
        Me.button_SignIn.Text = "Login"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 311)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(440, 5)
        Me.Panel1.TabIndex = 5
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel1.Controls.Add(Me.GunaPanel2)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaPanel1.Location = New System.Drawing.Point(435, 5)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(5, 306)
        Me.GunaPanel1.TabIndex = 6
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(5, 306)
        Me.GunaPanel2.TabIndex = 7
        '
        'GunaPanel3
        '
        Me.GunaPanel3.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel3.Location = New System.Drawing.Point(0, 5)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(5, 306)
        Me.GunaPanel3.TabIndex = 4
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.Guna2Panel1
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(206, 26)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(55, 55)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 7
        Me.GunaPictureBox1.TabStop = False
        '
        'txtUsername
        '
        Me.txtUsername.BorderRadius = 8
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.Parent = Me.txtUsername
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.FocusedState.Parent = Me.txtUsername
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.HoverState.Parent = Me.txtUsername
        Me.txtUsername.IconLeft = CType(resources.GetObject("txtUsername.IconLeft"), System.Drawing.Image)
        Me.txtUsername.IconLeftSize = New System.Drawing.Size(30, 30)
        Me.txtUsername.Location = New System.Drawing.Point(73, 40)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderText = "username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.ShadowDecoration.Parent = Me.txtUsername
        Me.txtUsername.Size = New System.Drawing.Size(239, 33)
        Me.txtUsername.TabIndex = 5
        '
        'txtUserPassword
        '
        Me.txtUserPassword.BorderRadius = 8
        Me.txtUserPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserPassword.DefaultText = ""
        Me.txtUserPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUserPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUserPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUserPassword.DisabledState.Parent = Me.txtUserPassword
        Me.txtUserPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUserPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUserPassword.FocusedState.Parent = Me.txtUserPassword
        Me.txtUserPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtUserPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUserPassword.HoverState.Parent = Me.txtUserPassword
        Me.txtUserPassword.IconLeft = CType(resources.GetObject("txtUserPassword.IconLeft"), System.Drawing.Image)
        Me.txtUserPassword.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.txtUserPassword.Location = New System.Drawing.Point(73, 81)
        Me.txtUserPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUserPassword.Name = "txtUserPassword"
        Me.txtUserPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUserPassword.PlaceholderText = "password"
        Me.txtUserPassword.SelectedText = ""
        Me.txtUserPassword.ShadowDecoration.Parent = Me.txtUserPassword
        Me.txtUserPassword.Size = New System.Drawing.Size(239, 33)
        Me.txtUserPassword.TabIndex = 5
        Me.txtUserPassword.UseSystemPasswordChar = True
        Me.txtUserPassword.WordWrap = False
        '
        'Sign_In
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 316)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buttonClose)
        Me.Controls.Add(Me.GunaPanel3)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Sign_In"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign_In"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.GunaPanel1.ResumeLayout(False)
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents buttonClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents button_SignIn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents txtforgetpassword As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents txtUserPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
End Class
