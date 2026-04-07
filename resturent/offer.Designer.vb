<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class offer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(offer))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtempsearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmbsts = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtitemname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtdis = New Guna.UI2.WinForms.Guna2TextBox()
        Me.enddate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Stardate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Disper = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(829, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(241, 249)
        Me.Panel1.TabIndex = 175
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 21)
        Me.Label3.TabIndex = 169
        Me.Label3.Text = " Discription"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(370, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 21)
        Me.Label5.TabIndex = 171
        Me.Label5.Text = "       End Date"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(370, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 21)
        Me.Label6.TabIndex = 172
        Me.Label6.Text = "       Start Date"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(16, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 21)
        Me.Label1.TabIndex = 173
        Me.Label1.Text = " Offer Name"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(16, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 21)
        Me.Label2.TabIndex = 174
        Me.Label2.Text = "   ID Offer"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(5, 9)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(127, 43)
        Me.ToolStrip1.TabIndex = 176
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButton1.BackgroundImage = CType(resources.GetObject("ToolStripButton1.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(40, 40)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoSize = False
        Me.ToolStripButton2.BackgroundImage = CType(resources.GetObject("ToolStripButton2.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(40, 40)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.AutoSize = False
        Me.ToolStripButton3.BackgroundImage = CType(resources.GetObject("ToolStripButton3.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(35, 35)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(18, 281)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 21)
        Me.Label7.TabIndex = 178
        Me.Label7.Text = "     status"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(390, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 21)
        Me.Label8.TabIndex = 181
        Me.Label8.Text = "Discount Percentage"
        '
        'txtempsearch
        '
        Me.txtempsearch.Animated = True
        Me.txtempsearch.AutoRoundedCorners = True
        Me.txtempsearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.txtempsearch.BorderRadius = 13
        Me.txtempsearch.BorderThickness = 2
        Me.txtempsearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtempsearch.DefaultText = ""
        Me.txtempsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtempsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtempsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtempsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtempsearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.txtempsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtempsearch.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtempsearch.ForeColor = System.Drawing.Color.White
        Me.txtempsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtempsearch.IconLeft = CType(resources.GetObject("txtempsearch.IconLeft"), System.Drawing.Image)
        Me.txtempsearch.Location = New System.Drawing.Point(431, 23)
        Me.txtempsearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtempsearch.Name = "txtempsearch"
        Me.txtempsearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtempsearch.PlaceholderForeColor = System.Drawing.Color.FloralWhite
        Me.txtempsearch.PlaceholderText = "Search...."
        Me.txtempsearch.SelectedText = ""
        Me.txtempsearch.Size = New System.Drawing.Size(197, 29)
        Me.txtempsearch.TabIndex = 184
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(4, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(93, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(93, Byte), Integer))
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(123, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(20, 357)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(116, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Size = New System.Drawing.Size(1048, 289)
        Me.DataGridView1.TabIndex = 185
        '
        'cmbsts
        '
        Me.cmbsts.AutoRoundedCorners = True
        Me.cmbsts.BackColor = System.Drawing.Color.Transparent
        Me.cmbsts.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.cmbsts.BorderRadius = 17
        Me.cmbsts.BorderThickness = 2
        Me.cmbsts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbsts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsts.FocusedColor = System.Drawing.Color.Peru
        Me.cmbsts.FocusedState.BorderColor = System.Drawing.Color.Peru
        Me.cmbsts.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmbsts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbsts.ItemHeight = 30
        Me.cmbsts.Location = New System.Drawing.Point(127, 271)
        Me.cmbsts.Name = "cmbsts"
        Me.cmbsts.Size = New System.Drawing.Size(166, 36)
        Me.cmbsts.TabIndex = 188
        '
        'txtitemname
        '
        Me.txtitemname.Animated = True
        Me.txtitemname.AutoRoundedCorners = True
        Me.txtitemname.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.txtitemname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.txtitemname.BorderRadius = 13
        Me.txtitemname.BorderThickness = 2
        Me.txtitemname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtitemname.DefaultText = ""
        Me.txtitemname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtitemname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtitemname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtitemname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtitemname.FocusedState.BorderColor = System.Drawing.Color.Peru
        Me.txtitemname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtitemname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtitemname.HoverState.BorderColor = System.Drawing.Color.Peru
        Me.txtitemname.Location = New System.Drawing.Point(129, 153)
        Me.txtitemname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtitemname.Name = "txtitemname"
        Me.txtitemname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtitemname.PlaceholderText = "Offer Name"
        Me.txtitemname.SelectedText = ""
        Me.txtitemname.Size = New System.Drawing.Size(164, 29)
        Me.txtitemname.TabIndex = 187
        '
        'txtno
        '
        Me.txtno.Animated = True
        Me.txtno.AutoRoundedCorners = True
        Me.txtno.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.txtno.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.txtno.BorderRadius = 13
        Me.txtno.BorderThickness = 2
        Me.txtno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtno.DefaultText = ""
        Me.txtno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtno.FocusedState.BorderColor = System.Drawing.Color.Peru
        Me.txtno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtno.HoverState.BorderColor = System.Drawing.Color.Peru
        Me.txtno.Location = New System.Drawing.Point(129, 96)
        Me.txtno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtno.Name = "txtno"
        Me.txtno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtno.PlaceholderText = "ID Offer"
        Me.txtno.ReadOnly = True
        Me.txtno.SelectedText = ""
        Me.txtno.Size = New System.Drawing.Size(164, 29)
        Me.txtno.TabIndex = 186
        '
        'txtdis
        '
        Me.txtdis.Animated = True
        Me.txtdis.AutoRoundedCorners = True
        Me.txtdis.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.txtdis.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.txtdis.BorderRadius = 13
        Me.txtdis.BorderThickness = 2
        Me.txtdis.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdis.DefaultText = ""
        Me.txtdis.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtdis.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtdis.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdis.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtdis.FocusedState.BorderColor = System.Drawing.Color.Peru
        Me.txtdis.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txtdis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtdis.HoverState.BorderColor = System.Drawing.Color.Peru
        Me.txtdis.Location = New System.Drawing.Point(129, 213)
        Me.txtdis.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdis.Name = "txtdis"
        Me.txtdis.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdis.PlaceholderText = "Discription"
        Me.txtdis.SelectedText = ""
        Me.txtdis.Size = New System.Drawing.Size(164, 29)
        Me.txtdis.TabIndex = 189
        '
        'enddate
        '
        Me.enddate.BorderRadius = 17
        Me.enddate.Checked = True
        Me.enddate.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.enddate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.enddate.ForeColor = System.Drawing.Color.Black
        Me.enddate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.enddate.Location = New System.Drawing.Point(535, 240)
        Me.enddate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.enddate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.enddate.Name = "enddate"
        Me.enddate.Size = New System.Drawing.Size(200, 36)
        Me.enddate.TabIndex = 190
        Me.enddate.Value = New Date(2025, 1, 30, 10, 17, 42, 110)
        '
        'Stardate
        '
        Me.Stardate.BorderRadius = 17
        Me.Stardate.Checked = True
        Me.Stardate.FillColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.Stardate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Stardate.ForeColor = System.Drawing.Color.Black
        Me.Stardate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Stardate.Location = New System.Drawing.Point(535, 161)
        Me.Stardate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Stardate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Stardate.Name = "Stardate"
        Me.Stardate.Size = New System.Drawing.Size(200, 36)
        Me.Stardate.TabIndex = 191
        Me.Stardate.Value = New Date(2025, 1, 30, 10, 17, 42, 110)
        '
        'Disper
        '
        Me.Disper.Animated = True
        Me.Disper.AutoRoundedCorners = True
        Me.Disper.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.Disper.BorderColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.Disper.BorderRadius = 13
        Me.Disper.BorderThickness = 2
        Me.Disper.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Disper.DefaultText = ""
        Me.Disper.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Disper.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Disper.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Disper.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Disper.FocusedState.BorderColor = System.Drawing.Color.Peru
        Me.Disper.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Disper.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Disper.HoverState.BorderColor = System.Drawing.Color.Peru
        Me.Disper.Location = New System.Drawing.Point(568, 99)
        Me.Disper.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Disper.Name = "Disper"
        Me.Disper.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Disper.PlaceholderText = "%"
        Me.Disper.SelectedText = ""
        Me.Disper.Size = New System.Drawing.Size(164, 29)
        Me.Disper.TabIndex = 192
        '
        'offer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1182, 788)
        Me.Controls.Add(Me.Disper)
        Me.Controls.Add(Me.Stardate)
        Me.Controls.Add(Me.enddate)
        Me.Controls.Add(Me.txtdis)
        Me.Controls.Add(Me.cmbsts)
        Me.Controls.Add(Me.txtitemname)
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtempsearch)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "offer"
        Me.Text = "offer"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtempsearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmbsts As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtitemname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtdis As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents enddate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Stardate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Disper As Guna.UI2.WinForms.Guna2TextBox
End Class
