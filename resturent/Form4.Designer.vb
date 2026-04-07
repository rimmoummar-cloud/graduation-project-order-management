<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.dateend = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.datestart = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsupp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtsalary = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtresult = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtorder = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsave = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dateend
        '
        Me.dateend.BorderRadius = 17
        Me.dateend.Checked = True
        Me.dateend.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.dateend.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dateend.ForeColor = System.Drawing.Color.White
        Me.dateend.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dateend.Location = New System.Drawing.Point(714, 143)
        Me.dateend.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dateend.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dateend.Name = "dateend"
        Me.dateend.Size = New System.Drawing.Size(204, 36)
        Me.dateend.TabIndex = 199
        Me.dateend.Value = New Date(2025, 1, 30, 10, 17, 42, 110)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(625, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 21)
        Me.Label6.TabIndex = 198
        Me.Label6.Text = "To Date"
        '
        'datestart
        '
        Me.datestart.BorderRadius = 17
        Me.datestart.Checked = True
        Me.datestart.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.datestart.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.datestart.ForeColor = System.Drawing.Color.White
        Me.datestart.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.datestart.Location = New System.Drawing.Point(319, 143)
        Me.datestart.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.datestart.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.datestart.Name = "datestart"
        Me.datestart.Size = New System.Drawing.Size(203, 36)
        Me.datestart.TabIndex = 201
        Me.datestart.Value = New Date(2025, 1, 30, 10, 17, 42, 110)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(212, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 21)
        Me.Label1.TabIndex = 200
        Me.Label1.Text = "From Date"
        '
        'txtsupp
        '
        Me.txtsupp.Animated = True
        Me.txtsupp.AutoRoundedCorners = True
        Me.txtsupp.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.txtsupp.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.txtsupp.BorderRadius = 13
        Me.txtsupp.BorderThickness = 2
        Me.txtsupp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsupp.DefaultText = ""
        Me.txtsupp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtsupp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtsupp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsupp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsupp.FocusedState.BorderColor = System.Drawing.Color.Peru
        Me.txtsupp.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtsupp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtsupp.HoverState.BorderColor = System.Drawing.Color.Peru
        Me.txtsupp.Location = New System.Drawing.Point(319, 234)
        Me.txtsupp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtsupp.Name = "txtsupp"
        Me.txtsupp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsupp.PlaceholderText = ""
        Me.txtsupp.SelectedText = ""
        Me.txtsupp.Size = New System.Drawing.Size(203, 29)
        Me.txtsupp.TabIndex = 205
        '
        'txtsalary
        '
        Me.txtsalary.Animated = True
        Me.txtsalary.AutoRoundedCorners = True
        Me.txtsalary.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.txtsalary.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.txtsalary.BorderRadius = 13
        Me.txtsalary.BorderThickness = 2
        Me.txtsalary.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsalary.DefaultText = ""
        Me.txtsalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtsalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtsalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsalary.FocusedState.BorderColor = System.Drawing.Color.Peru
        Me.txtsalary.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtsalary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtsalary.HoverState.BorderColor = System.Drawing.Color.Peru
        Me.txtsalary.Location = New System.Drawing.Point(319, 197)
        Me.txtsalary.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtsalary.Name = "txtsalary"
        Me.txtsalary.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsalary.PlaceholderText = ""
        Me.txtsalary.ReadOnly = True
        Me.txtsalary.SelectedText = ""
        Me.txtsalary.Size = New System.Drawing.Size(203, 29)
        Me.txtsalary.TabIndex = 204
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(145, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 21)
        Me.Label2.TabIndex = 202
        Me.Label2.Text = "Supplier Expenses :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(145, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 21)
        Me.Label3.TabIndex = 203
        Me.Label3.Text = "Employee's Salary :"
        '
        'txtresult
        '
        Me.txtresult.Animated = True
        Me.txtresult.AutoRoundedCorners = True
        Me.txtresult.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.txtresult.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.txtresult.BorderRadius = 13
        Me.txtresult.BorderThickness = 2
        Me.txtresult.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtresult.DefaultText = ""
        Me.txtresult.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtresult.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtresult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtresult.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtresult.FocusedState.BorderColor = System.Drawing.Color.Peru
        Me.txtresult.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtresult.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtresult.HoverState.BorderColor = System.Drawing.Color.Peru
        Me.txtresult.Location = New System.Drawing.Point(714, 234)
        Me.txtresult.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtresult.Name = "txtresult"
        Me.txtresult.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtresult.PlaceholderText = ""
        Me.txtresult.SelectedText = ""
        Me.txtresult.Size = New System.Drawing.Size(204, 29)
        Me.txtresult.TabIndex = 209
        '
        'txtorder
        '
        Me.txtorder.Animated = True
        Me.txtorder.AutoRoundedCorners = True
        Me.txtorder.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.txtorder.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.txtorder.BorderRadius = 13
        Me.txtorder.BorderThickness = 2
        Me.txtorder.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtorder.DefaultText = ""
        Me.txtorder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtorder.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtorder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtorder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtorder.FocusedState.BorderColor = System.Drawing.Color.Peru
        Me.txtorder.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtorder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtorder.HoverState.BorderColor = System.Drawing.Color.Peru
        Me.txtorder.Location = New System.Drawing.Point(714, 197)
        Me.txtorder.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtorder.Name = "txtorder"
        Me.txtorder.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtorder.PlaceholderText = ""
        Me.txtorder.ReadOnly = True
        Me.txtorder.SelectedText = ""
        Me.txtorder.Size = New System.Drawing.Size(204, 29)
        Me.txtorder.TabIndex = 208
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(591, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 21)
        Me.Label4.TabIndex = 206
        Me.Label4.Text = "Result :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(591, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 21)
        Me.Label5.TabIndex = 207
        Me.Label5.Text = "Total Orders :"
        '
        'txtsave
        '
        Me.txtsave.AutoRoundedCorners = True
        Me.txtsave.BorderRadius = 16
        Me.txtsave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.txtsave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.txtsave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.txtsave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.txtsave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txtsave.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.txtsave.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(8, Byte), Integer))
        Me.txtsave.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsave.ForeColor = System.Drawing.Color.White
        Me.txtsave.Location = New System.Drawing.Point(12, 8)
        Me.txtsave.Name = "txtsave"
        Me.txtsave.Size = New System.Drawing.Size(140, 34)
        Me.txtsave.TabIndex = 210
        Me.txtsave.Text = "Save All "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(439, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(266, 34)
        Me.Label7.TabIndex = 212
        Me.Label7.Text = "The Profit In Month"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(296, 282)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(649, 300)
        Me.Chart1.TabIndex = 213
        Me.Chart1.Text = "Chart1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(355, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 56)
        Me.PictureBox1.TabIndex = 214
        Me.PictureBox1.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1245, 781)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtsave)
        Me.Controls.Add(Me.txtresult)
        Me.Controls.Add(Me.txtorder)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtsupp)
        Me.Controls.Add(Me.txtsalary)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.datestart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dateend)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dateend As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents datestart As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtsupp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtsalary As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtresult As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtorder As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtsave As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents PictureBox1 As PictureBox
End Class
