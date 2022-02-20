<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStudent
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
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.buttonSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.txtClass = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Purple
        Me.Guna2Panel1.Controls.Add(Me.btnClose)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(720, 28)
        Me.Guna2Panel1.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.Red
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(681, 1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(36, 26)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Student"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 5
        Me.Guna2Panel2.Controls.Add(Me.GunaButton2)
        Me.Guna2Panel2.Controls.Add(Me.GunaPictureBox1)
        Me.Guna2Panel2.Controls.Add(Me.GunaButton1)
        Me.Guna2Panel2.Controls.Add(Me.buttonSubmit)
        Me.Guna2Panel2.Controls.Add(Me.txtClass)
        Me.Guna2Panel2.Controls.Add(Me.txtMobile)
        Me.Guna2Panel2.Controls.Add(Me.txtStudentName)
        Me.Guna2Panel2.Controls.Add(Me.txtStudentID)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.Label5)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(25, 76)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Color = System.Drawing.Color.Gray
        Me.Guna2Panel2.ShadowDecoration.Enabled = True
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(668, 376)
        Me.Guna2Panel2.TabIndex = 2
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.Green
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton2.ForeColor = System.Drawing.Color.Aquamarine
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(540, 337)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Radius = 5
        Me.GunaButton2.Size = New System.Drawing.Size(111, 35)
        Me.GunaButton2.TabIndex = 5
        Me.GunaButton2.Text = "Take FingurePrint"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GunaPictureBox1.Location = New System.Drawing.Point(559, 244)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(84, 72)
        Me.GunaPictureBox1.TabIndex = 4
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.White
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(368, 337)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 5
        Me.GunaButton1.Size = New System.Drawing.Size(100, 36)
        Me.GunaButton1.TabIndex = 3
        Me.GunaButton1.Text = "Clear"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'buttonSubmit
        '
        Me.buttonSubmit.CheckedState.Parent = Me.buttonSubmit
        Me.buttonSubmit.CustomImages.Parent = Me.buttonSubmit
        Me.buttonSubmit.FillColor = System.Drawing.Color.White
        Me.buttonSubmit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonSubmit.ForeColor = System.Drawing.Color.Green
        Me.buttonSubmit.HoverState.Parent = Me.buttonSubmit
        Me.buttonSubmit.Location = New System.Drawing.Point(156, 337)
        Me.buttonSubmit.Name = "buttonSubmit"
        Me.buttonSubmit.ShadowDecoration.Color = System.Drawing.Color.Gray
        Me.buttonSubmit.ShadowDecoration.Depth = 20
        Me.buttonSubmit.ShadowDecoration.Enabled = True
        Me.buttonSubmit.ShadowDecoration.Parent = Me.buttonSubmit
        Me.buttonSubmit.Size = New System.Drawing.Size(136, 36)
        Me.buttonSubmit.TabIndex = 2
        Me.buttonSubmit.Text = "Submit"
        '
        'txtClass
        '
        Me.txtClass.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClass.Location = New System.Drawing.Point(115, 206)
        Me.txtClass.Name = "txtClass"
        Me.txtClass.Size = New System.Drawing.Size(158, 27)
        Me.txtClass.TabIndex = 1
        '
        'txtMobile
        '
        Me.txtMobile.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobile.Location = New System.Drawing.Point(115, 149)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(158, 27)
        Me.txtMobile.TabIndex = 1
        '
        'txtStudentName
        '
        Me.txtStudentName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentName.Location = New System.Drawing.Point(115, 93)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(158, 27)
        Me.txtStudentName.TabIndex = 1
        '
        'txtStudentID
        '
        Me.txtStudentID.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.Location = New System.Drawing.Point(115, 42)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(158, 27)
        Me.txtStudentID.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Name :-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Class :-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Mobile No :-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Student ID :-"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 489)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(720, 5)
        Me.Panel1.TabIndex = 3
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaPanel1.Location = New System.Drawing.Point(715, 28)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(5, 461)
        Me.GunaPanel1.TabIndex = 4
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.Purple
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 28)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(5, 461)
        Me.GunaPanel2.TabIndex = 5
        '
        'AddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 494)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AddStudent"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents buttonSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtClass As TextBox
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
End Class
