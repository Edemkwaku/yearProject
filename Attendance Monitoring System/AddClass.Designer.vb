<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddClass
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.buttonSubmit = New Guna.UI2.WinForms.Guna2Button()
        Me.txtCourseName = New System.Windows.Forms.TextBox()
        Me.txtCourseLecturer = New System.Windows.Forms.TextBox()
        Me.lable = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Green
        Me.Guna2Panel1.Controls.Add(Me.buttonClose)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(685, 43)
        Me.Guna2Panel1.TabIndex = 0
        '
        'buttonClose
        '
        Me.buttonClose.CheckedState.Parent = Me.buttonClose
        Me.buttonClose.CustomImages.Parent = Me.buttonClose
        Me.buttonClose.FillColor = System.Drawing.Color.Green
        Me.buttonClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonClose.ForeColor = System.Drawing.Color.White
        Me.buttonClose.HoverState.Parent = Me.buttonClose
        Me.buttonClose.Location = New System.Drawing.Point(640, 7)
        Me.buttonClose.Name = "buttonClose"
        Me.buttonClose.ShadowDecoration.Parent = Me.buttonClose
        Me.buttonClose.Size = New System.Drawing.Size(36, 30)
        Me.buttonClose.TabIndex = 1
        Me.buttonClose.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(19, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Class"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel2.BorderRadius = 5
        Me.Guna2Panel2.Controls.Add(Me.buttonSubmit)
        Me.Guna2Panel2.Controls.Add(Me.txtCourseName)
        Me.Guna2Panel2.Controls.Add(Me.txtCourseLecturer)
        Me.Guna2Panel2.Controls.Add(Me.lable)
        Me.Guna2Panel2.Controls.Add(Me.txtCode)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(132, 95)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Color = System.Drawing.Color.Gray
        Me.Guna2Panel2.ShadowDecoration.Enabled = True
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(442, 247)
        Me.Guna2Panel2.TabIndex = 1
        '
        'buttonSubmit
        '
        Me.buttonSubmit.CheckedState.Parent = Me.buttonSubmit
        Me.buttonSubmit.CustomImages.Parent = Me.buttonSubmit
        Me.buttonSubmit.FillColor = System.Drawing.Color.White
        Me.buttonSubmit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonSubmit.ForeColor = System.Drawing.Color.Green
        Me.buttonSubmit.HoverState.Parent = Me.buttonSubmit
        Me.buttonSubmit.Location = New System.Drawing.Point(158, 186)
        Me.buttonSubmit.Name = "buttonSubmit"
        Me.buttonSubmit.ShadowDecoration.Color = System.Drawing.Color.Gray
        Me.buttonSubmit.ShadowDecoration.Depth = 20
        Me.buttonSubmit.ShadowDecoration.Enabled = True
        Me.buttonSubmit.ShadowDecoration.Parent = Me.buttonSubmit
        Me.buttonSubmit.Size = New System.Drawing.Size(136, 36)
        Me.buttonSubmit.TabIndex = 2
        Me.buttonSubmit.Text = "Submit"
        '
        'txtCourseName
        '
        Me.txtCourseName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourseName.Location = New System.Drawing.Point(183, 93)
        Me.txtCourseName.Name = "txtCourseName"
        Me.txtCourseName.Size = New System.Drawing.Size(207, 27)
        Me.txtCourseName.TabIndex = 1
        '
        'txtCourseLecturer
        '
        Me.txtCourseLecturer.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourseLecturer.Location = New System.Drawing.Point(183, 139)
        Me.txtCourseLecturer.Name = "txtCourseLecturer"
        Me.txtCourseLecturer.Size = New System.Drawing.Size(207, 27)
        Me.txtCourseLecturer.TabIndex = 1
        '
        'lable
        '
        Me.lable.AutoSize = True
        Me.lable.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lable.Location = New System.Drawing.Point(45, 93)
        Me.lable.Name = "lable"
        Me.lable.Size = New System.Drawing.Size(111, 20)
        Me.lable.TabIndex = 0
        Me.lable.Text = "Course Name :-"
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(183, 42)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(207, 27)
        Me.txtCode.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Course Lecturer :-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Course Code :-"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 375)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(685, 10)
        Me.Panel1.TabIndex = 2
        '
        'AddClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 385)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddClass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Class"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents buttonClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents buttonSubmit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtCourseLecturer As TextBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents lable As Label
End Class
