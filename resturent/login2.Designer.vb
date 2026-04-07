<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login2))
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.check = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.llforgpass = New System.Windows.Forms.LinkLabel()
        Me.txtpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), System.Drawing.Image)
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Controls.Add(Me.check)
        Me.Panel6.Controls.Add(Me.LinkLabel1)
        Me.Panel6.Controls.Add(Me.Guna2GradientButton1)
        Me.Panel6.Controls.Add(Me.llforgpass)
        Me.Panel6.Controls.Add(Me.txtpassword)
        Me.Panel6.Controls.Add(Me.txtname)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(783, 517)
        Me.Panel6.TabIndex = 20
        '
        'check
        '
        Me.check.AutoSize = True
        Me.check.BackColor = System.Drawing.Color.Transparent
        Me.check.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.check.CheckedState.BorderRadius = 0
        Me.check.CheckedState.BorderThickness = 0
        Me.check.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.check.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.check.Location = New System.Drawing.Point(507, 279)
        Me.check.Name = "check"
        Me.check.Size = New System.Drawing.Size(102, 19)
        Me.check.TabIndex = 92
        Me.check.Text = "show password"
        Me.check.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.check.UncheckedState.BorderRadius = 0
        Me.check.UncheckedState.BorderThickness = 0
        Me.check.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.check.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Peru
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(300, 55)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(184, 55)
        Me.LinkLabel1.TabIndex = 91
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LOGIN"
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.AutoRoundedCorners = True
        Me.Guna2GradientButton1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton1.BorderRadius = 19
        Me.Guna2GradientButton1.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(326, 372)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(117, 41)
        Me.Guna2GradientButton1.TabIndex = 3
        Me.Guna2GradientButton1.Text = "LOGIN"
        '
        'llforgpass
        '
        Me.llforgpass.ActiveLinkColor = System.Drawing.Color.Peru
        Me.llforgpass.AutoSize = True
        Me.llforgpass.BackColor = System.Drawing.Color.Transparent
        Me.llforgpass.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llforgpass.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.llforgpass.LinkColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.llforgpass.Location = New System.Drawing.Point(496, 427)
        Me.llforgpass.Name = "llforgpass"
        Me.llforgpass.Size = New System.Drawing.Size(122, 18)
        Me.llforgpass.TabIndex = 89
        Me.llforgpass.TabStop = True
        Me.llforgpass.Text = "Forgot Password?"
        '
        'txtpassword
        '
        Me.txtpassword.Animated = True
        Me.txtpassword.AutoRoundedCorners = True
        Me.txtpassword.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.txtpassword.BackColor = System.Drawing.Color.Transparent
        Me.txtpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtpassword.BorderColor = System.Drawing.Color.Black
        Me.txtpassword.BorderRadius = 21
        Me.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpassword.DefaultText = ""
        Me.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassword.FocusedState.BorderColor = System.Drawing.Color.SaddleBrown
        Me.txtpassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtpassword.HoverState.BorderColor = System.Drawing.Color.SaddleBrown
        Me.txtpassword.Location = New System.Drawing.Point(280, 254)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.txtpassword.PlaceholderText = "Password"
        Me.txtpassword.SelectedText = ""
        Me.txtpassword.Size = New System.Drawing.Size(219, 44)
        Me.txtpassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtpassword.TabIndex = 75
        '
        'txtname
        '
        Me.txtname.Animated = True
        Me.txtname.AutoRoundedCorners = True
        Me.txtname.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.txtname.BackColor = System.Drawing.Color.Transparent
        Me.txtname.BackgroundImage = CType(resources.GetObject("txtname.BackgroundImage"), System.Drawing.Image)
        Me.txtname.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtname.BorderColor = System.Drawing.Color.Black
        Me.txtname.BorderRadius = 21
        Me.txtname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtname.DefaultText = ""
        Me.txtname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtname.FocusedState.BorderColor = System.Drawing.Color.SaddleBrown
        Me.txtname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtname.HoverState.BorderColor = System.Drawing.Color.SaddleBrown
        Me.txtname.Location = New System.Drawing.Point(280, 165)
        Me.txtname.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.txtname.Name = "txtname"
        Me.txtname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtname.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(7, Byte), Integer))
        Me.txtname.PlaceholderText = "UserName"
        Me.txtname.SelectedText = ""
        Me.txtname.Size = New System.Drawing.Size(219, 44)
        Me.txtname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtname.TabIndex = 74
        '
        'login2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 517)
        Me.Controls.Add(Me.Panel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "login2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login2"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents llforgpass As LinkLabel
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents check As Guna.UI2.WinForms.Guna2CheckBox
End Class
