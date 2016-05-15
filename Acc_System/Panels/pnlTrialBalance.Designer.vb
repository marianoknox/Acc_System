<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlTrialBalance
    Inherits pnlSlidingControl
    Sub New(ByVal owner As Form)
        MyBase.New(owner)

        InitializeComponent()
    End Sub
    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pnlTrialBalance))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgTrial = New MetroFramework.Controls.MetroGrid()
        Me.dtStart = New MetroFramework.Controls.MetroDateTime()
        Me.dtEnd = New MetroFramework.Controls.MetroDateTime()
        Me.tbTotalDebit = New MetroFramework.Controls.MetroTextBox()
        Me.tbTotalCredit = New MetroFramework.Controls.MetroTextBox()
        Me.btnRun = New MetroFramework.Controls.MetroButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CustomPanel7 = New Acc_System.CustomPanel()
        Me.MetroTextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox4 = New MetroFramework.Controls.MetroTextBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.CustomPanel8 = New Acc_System.CustomPanel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.CustomPanel5 = New Acc_System.CustomPanel()
        Me.CustomPanel6 = New Acc_System.CustomPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CustomPanel3 = New Acc_System.CustomPanel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.tbAccBalance = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.tbAccDR = New MetroFramework.Controls.MetroTextBox()
        Me.tbAccCR = New MetroFramework.Controls.MetroTextBox()
        Me.dgAccTrans = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmVoucher = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.cmsEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomPanel4 = New Acc_System.CustomPanel()
        Me.CustomPanel1 = New Acc_System.CustomPanel()
        Me.btnPrint = New MetroFramework.Controls.MetroLink()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CustomPanel2 = New Acc_System.CustomPanel()
        Me.TbAccountTransTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbAccountTransTableAdapter()
        Me.TbAccountsTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbAccountsTableAdapter()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgTrial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.CustomPanel7.SuspendLayout()
        Me.CustomPanel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.CustomPanel3.SuspendLayout()
        CType(Me.dgAccTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmVoucher.SuspendLayout()
        Me.CustomPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgTrial
        '
        Me.dgTrial.AllowUserToAddRows = False
        Me.dgTrial.AllowUserToDeleteRows = False
        Me.dgTrial.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgTrial.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgTrial.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgTrial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgTrial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgTrial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTrial.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgTrial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTrial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgTrial.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgTrial.EnableHeadersVisualStyles = False
        Me.dgTrial.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgTrial.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgTrial.Location = New System.Drawing.Point(15, 29)
        Me.dgTrial.MultiSelect = False
        Me.dgTrial.Name = "dgTrial"
        Me.dgTrial.ReadOnly = True
        Me.dgTrial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTrial.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgTrial.RowHeadersVisible = False
        Me.dgTrial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgTrial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTrial.Size = New System.Drawing.Size(722, 420)
        Me.dgTrial.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgTrial.TabIndex = 26
        '
        'dtStart
        '
        Me.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtStart.Location = New System.Drawing.Point(79, 32)
        Me.dtStart.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtStart.Name = "dtStart"
        Me.dtStart.Size = New System.Drawing.Size(258, 29)
        Me.dtStart.TabIndex = 0
        '
        'dtEnd
        '
        Me.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEnd.Location = New System.Drawing.Point(79, 67)
        Me.dtEnd.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtEnd.Name = "dtEnd"
        Me.dtEnd.Size = New System.Drawing.Size(258, 29)
        Me.dtEnd.TabIndex = 1
        '
        'tbTotalDebit
        '
        '
        '
        '
        Me.tbTotalDebit.CustomButton.Image = Nothing
        Me.tbTotalDebit.CustomButton.Location = New System.Drawing.Point(107, 1)
        Me.tbTotalDebit.CustomButton.Name = ""
        Me.tbTotalDebit.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbTotalDebit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbTotalDebit.CustomButton.TabIndex = 1
        Me.tbTotalDebit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbTotalDebit.CustomButton.UseSelectable = True
        Me.tbTotalDebit.CustomButton.Visible = False
        Me.tbTotalDebit.Enabled = False
        Me.tbTotalDebit.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbTotalDebit.Lines = New String(-1) {}
        Me.tbTotalDebit.Location = New System.Drawing.Point(398, 455)
        Me.tbTotalDebit.MaxLength = 32767
        Me.tbTotalDebit.Name = "tbTotalDebit"
        Me.tbTotalDebit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTotalDebit.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbTotalDebit.SelectedText = ""
        Me.tbTotalDebit.SelectionLength = 0
        Me.tbTotalDebit.SelectionStart = 0
        Me.tbTotalDebit.Size = New System.Drawing.Size(135, 29)
        Me.tbTotalDebit.TabIndex = 40
        Me.tbTotalDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbTotalDebit.UseSelectable = True
        Me.tbTotalDebit.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbTotalDebit.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tbTotalCredit
        '
        '
        '
        '
        Me.tbTotalCredit.CustomButton.Image = Nothing
        Me.tbTotalCredit.CustomButton.Location = New System.Drawing.Point(107, 1)
        Me.tbTotalCredit.CustomButton.Name = ""
        Me.tbTotalCredit.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbTotalCredit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbTotalCredit.CustomButton.TabIndex = 1
        Me.tbTotalCredit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbTotalCredit.CustomButton.UseSelectable = True
        Me.tbTotalCredit.CustomButton.Visible = False
        Me.tbTotalCredit.Enabled = False
        Me.tbTotalCredit.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbTotalCredit.Lines = New String(-1) {}
        Me.tbTotalCredit.Location = New System.Drawing.Point(577, 455)
        Me.tbTotalCredit.MaxLength = 32767
        Me.tbTotalCredit.Name = "tbTotalCredit"
        Me.tbTotalCredit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTotalCredit.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbTotalCredit.SelectedText = ""
        Me.tbTotalCredit.SelectionLength = 0
        Me.tbTotalCredit.SelectionStart = 0
        Me.tbTotalCredit.Size = New System.Drawing.Size(135, 29)
        Me.tbTotalCredit.TabIndex = 39
        Me.tbTotalCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbTotalCredit.UseSelectable = True
        Me.tbTotalCredit.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbTotalCredit.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(343, 32)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(52, 64)
        Me.btnRun.TabIndex = 22
        Me.btnRun.Text = "Run"
        Me.btnRun.UseSelectable = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.CustomPanel7)
        Me.Panel2.Controls.Add(Me.CustomPanel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1200, 128)
        Me.Panel2.TabIndex = 28
        '
        'CustomPanel7
        '
        Me.CustomPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomPanel7.Controls.Add(Me.MetroTextBox3)
        Me.CustomPanel7.Controls.Add(Me.MetroTextBox4)
        Me.CustomPanel7.Controls.Add(Me.Button11)
        Me.CustomPanel7.Controls.Add(Me.Button12)
        Me.CustomPanel7.Controls.Add(Me.MetroTextBox2)
        Me.CustomPanel7.Controls.Add(Me.MetroTextBox1)
        Me.CustomPanel7.Controls.Add(Me.CustomPanel8)
        Me.CustomPanel7.Controls.Add(Me.Button7)
        Me.CustomPanel7.Controls.Add(Me.Button10)
        Me.CustomPanel7.Curvature = 10
        Me.CustomPanel7.Location = New System.Drawing.Point(437, 10)
        Me.CustomPanel7.Name = "CustomPanel7"
        Me.CustomPanel7.Size = New System.Drawing.Size(740, 107)
        Me.CustomPanel7.TabIndex = 75
        '
        'MetroTextBox3
        '
        '
        '
        '
        Me.MetroTextBox3.CustomButton.Image = Nothing
        Me.MetroTextBox3.CustomButton.Location = New System.Drawing.Point(219, 1)
        Me.MetroTextBox3.CustomButton.Name = ""
        Me.MetroTextBox3.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox3.CustomButton.TabIndex = 1
        Me.MetroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox3.CustomButton.UseSelectable = True
        Me.MetroTextBox3.CustomButton.Visible = False
        Me.MetroTextBox3.Enabled = False
        Me.MetroTextBox3.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox3.Lines = New String(-1) {}
        Me.MetroTextBox3.Location = New System.Drawing.Point(472, 68)
        Me.MetroTextBox3.MaxLength = 32767
        Me.MetroTextBox3.Name = "MetroTextBox3"
        Me.MetroTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox3.SelectedText = ""
        Me.MetroTextBox3.SelectionLength = 0
        Me.MetroTextBox3.SelectionStart = 0
        Me.MetroTextBox3.Size = New System.Drawing.Size(247, 29)
        Me.MetroTextBox3.TabIndex = 79
        Me.MetroTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MetroTextBox3.UseSelectable = True
        Me.MetroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox3.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox4
        '
        '
        '
        '
        Me.MetroTextBox4.CustomButton.Image = Nothing
        Me.MetroTextBox4.CustomButton.Location = New System.Drawing.Point(219, 1)
        Me.MetroTextBox4.CustomButton.Name = ""
        Me.MetroTextBox4.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox4.CustomButton.TabIndex = 1
        Me.MetroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox4.CustomButton.UseSelectable = True
        Me.MetroTextBox4.CustomButton.Visible = False
        Me.MetroTextBox4.Enabled = False
        Me.MetroTextBox4.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox4.Lines = New String(-1) {}
        Me.MetroTextBox4.Location = New System.Drawing.Point(472, 32)
        Me.MetroTextBox4.MaxLength = 32767
        Me.MetroTextBox4.Name = "MetroTextBox4"
        Me.MetroTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox4.SelectedText = ""
        Me.MetroTextBox4.SelectionLength = 0
        Me.MetroTextBox4.SelectionStart = 0
        Me.MetroTextBox4.Size = New System.Drawing.Size(247, 29)
        Me.MetroTextBox4.TabIndex = 78
        Me.MetroTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MetroTextBox4.UseSelectable = True
        Me.MetroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox4.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Button11
        '
        Me.Button11.Enabled = False
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(352, 68)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(118, 29)
        Me.Button11.TabIndex = 77
        Me.Button11.Text = "Over All CR"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Enabled = False
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(352, 32)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(118, 29)
        Me.Button12.TabIndex = 76
        Me.Button12.Text = "Over All DR"
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button12.UseVisualStyleBackColor = True
        '
        'MetroTextBox2
        '
        '
        '
        '
        Me.MetroTextBox2.CustomButton.Image = Nothing
        Me.MetroTextBox2.CustomButton.Location = New System.Drawing.Point(151, 1)
        Me.MetroTextBox2.CustomButton.Name = ""
        Me.MetroTextBox2.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox2.CustomButton.TabIndex = 1
        Me.MetroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox2.CustomButton.UseSelectable = True
        Me.MetroTextBox2.CustomButton.Visible = False
        Me.MetroTextBox2.Enabled = False
        Me.MetroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox2.Lines = New String(-1) {}
        Me.MetroTextBox2.Location = New System.Drawing.Point(133, 68)
        Me.MetroTextBox2.MaxLength = 32767
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.SelectionLength = 0
        Me.MetroTextBox2.SelectionStart = 0
        Me.MetroTextBox2.Size = New System.Drawing.Size(179, 29)
        Me.MetroTextBox2.TabIndex = 75
        Me.MetroTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox2.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(151, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.Enabled = False
        Me.MetroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(133, 32)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.Size = New System.Drawing.Size(179, 29)
        Me.MetroTextBox1.TabIndex = 74
        Me.MetroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'CustomPanel8
        '
        Me.CustomPanel8.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomPanel8.Curvature = 10
        Me.CustomPanel8.CurveMode = CType((Acc_System.CornerCurveMode.TopLeft Or Acc_System.CornerCurveMode.TopRight), Acc_System.CornerCurveMode)
        Me.CustomPanel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel8.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel8.Name = "CustomPanel8"
        Me.CustomPanel8.Size = New System.Drawing.Size(740, 23)
        Me.CustomPanel8.TabIndex = 44
        '
        'Button7
        '
        Me.Button7.Enabled = False
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(13, 68)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(118, 29)
        Me.Button7.TabIndex = 73
        Me.Button7.Text = "Opening CR"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Enabled = False
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(13, 32)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(118, 29)
        Me.Button10.TabIndex = 72
        Me.Button10.Text = "Opening DR"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button10.UseVisualStyleBackColor = True
        '
        'CustomPanel5
        '
        Me.CustomPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomPanel5.Controls.Add(Me.CustomPanel6)
        Me.CustomPanel5.Controls.Add(Me.btnRun)
        Me.CustomPanel5.Controls.Add(Me.Button1)
        Me.CustomPanel5.Controls.Add(Me.Button3)
        Me.CustomPanel5.Controls.Add(Me.dtEnd)
        Me.CustomPanel5.Controls.Add(Me.dtStart)
        Me.CustomPanel5.Curvature = 10
        Me.CustomPanel5.Location = New System.Drawing.Point(23, 10)
        Me.CustomPanel5.Name = "CustomPanel5"
        Me.CustomPanel5.Size = New System.Drawing.Size(408, 107)
        Me.CustomPanel5.TabIndex = 74
        '
        'CustomPanel6
        '
        Me.CustomPanel6.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomPanel6.Curvature = 10
        Me.CustomPanel6.CurveMode = CType((Acc_System.CornerCurveMode.TopLeft Or Acc_System.CornerCurveMode.TopRight), Acc_System.CornerCurveMode)
        Me.CustomPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel6.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel6.Name = "CustomPanel6"
        Me.CustomPanel6.Size = New System.Drawing.Size(408, 23)
        Me.CustomPanel6.TabIndex = 44
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(13, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 29)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "Until"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(13, 32)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 29)
        Me.Button3.TabIndex = 72
        Me.Button3.Text = "From"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.CustomPanel3)
        Me.Panel3.Controls.Add(Me.CustomPanel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 128)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1200, 515)
        Me.Panel3.TabIndex = 29
        '
        'CustomPanel3
        '
        Me.CustomPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomPanel3.Controls.Add(Me.MetroLabel5)
        Me.CustomPanel3.Controls.Add(Me.Button9)
        Me.CustomPanel3.Controls.Add(Me.Button8)
        Me.CustomPanel3.Controls.Add(Me.tbAccBalance)
        Me.CustomPanel3.Controls.Add(Me.MetroLink1)
        Me.CustomPanel3.Controls.Add(Me.Button5)
        Me.CustomPanel3.Controls.Add(Me.Button6)
        Me.CustomPanel3.Controls.Add(Me.tbAccDR)
        Me.CustomPanel3.Controls.Add(Me.tbAccCR)
        Me.CustomPanel3.Controls.Add(Me.dgAccTrans)
        Me.CustomPanel3.Controls.Add(Me.CustomPanel4)
        Me.CustomPanel3.Curvature = 10
        Me.CustomPanel3.Location = New System.Drawing.Point(781, 6)
        Me.CustomPanel3.Name = "CustomPanel3"
        Me.CustomPanel3.Size = New System.Drawing.Size(396, 497)
        Me.CustomPanel3.TabIndex = 67
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.Location = New System.Drawing.Point(9, 32)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(166, 25)
        Me.MetroLabel5.TabIndex = 85
        Me.MetroLabel5.Text = "Account Transaction"
        Me.MetroLabel5.UseCustomBackColor = True
        '
        'Button9
        '
        Me.Button9.Enabled = False
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(62, 455)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(117, 29)
        Me.Button9.TabIndex = 84
        Me.Button9.Text = "Balance"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Enabled = False
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(187, 455)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(39, 29)
        Me.Button8.TabIndex = 83
        Me.Button8.Text = "CR"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.UseVisualStyleBackColor = True
        '
        'tbAccBalance
        '
        '
        '
        '
        Me.tbAccBalance.CustomButton.Image = Nothing
        Me.tbAccBalance.CustomButton.Location = New System.Drawing.Point(89, 1)
        Me.tbAccBalance.CustomButton.Name = ""
        Me.tbAccBalance.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbAccBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbAccBalance.CustomButton.TabIndex = 1
        Me.tbAccBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbAccBalance.CustomButton.UseSelectable = True
        Me.tbAccBalance.CustomButton.Visible = False
        Me.tbAccBalance.Enabled = False
        Me.tbAccBalance.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbAccBalance.Lines = New String(-1) {}
        Me.tbAccBalance.Location = New System.Drawing.Point(227, 455)
        Me.tbAccBalance.MaxLength = 32767
        Me.tbAccBalance.Name = "tbAccBalance"
        Me.tbAccBalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbAccBalance.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbAccBalance.SelectedText = ""
        Me.tbAccBalance.SelectionLength = 0
        Me.tbAccBalance.SelectionStart = 0
        Me.tbAccBalance.Size = New System.Drawing.Size(117, 29)
        Me.tbAccBalance.TabIndex = 82
        Me.tbAccBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbAccBalance.UseSelectable = True
        Me.tbAccBalance.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbAccBalance.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLink1
        '
        Me.MetroLink1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroLink1.Image = CType(resources.GetObject("MetroLink1.Image"), System.Drawing.Image)
        Me.MetroLink1.ImageSize = 25
        Me.MetroLink1.Location = New System.Drawing.Point(354, 455)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(31, 30)
        Me.MetroLink1.TabIndex = 80
        Me.MetroLink1.UseSelectable = True
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(187, 420)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(39, 29)
        Me.Button5.TabIndex = 79
        Me.Button5.Text = "CR"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(21, 420)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(39, 29)
        Me.Button6.TabIndex = 78
        Me.Button6.Text = "DR"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'tbAccDR
        '
        '
        '
        '
        Me.tbAccDR.CustomButton.Image = Nothing
        Me.tbAccDR.CustomButton.Location = New System.Drawing.Point(89, 1)
        Me.tbAccDR.CustomButton.Name = ""
        Me.tbAccDR.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbAccDR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbAccDR.CustomButton.TabIndex = 1
        Me.tbAccDR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbAccDR.CustomButton.UseSelectable = True
        Me.tbAccDR.CustomButton.Visible = False
        Me.tbAccDR.Enabled = False
        Me.tbAccDR.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbAccDR.Lines = New String(-1) {}
        Me.tbAccDR.Location = New System.Drawing.Point(62, 420)
        Me.tbAccDR.MaxLength = 32767
        Me.tbAccDR.Name = "tbAccDR"
        Me.tbAccDR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbAccDR.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbAccDR.SelectedText = ""
        Me.tbAccDR.SelectionLength = 0
        Me.tbAccDR.SelectionStart = 0
        Me.tbAccDR.Size = New System.Drawing.Size(117, 29)
        Me.tbAccDR.TabIndex = 77
        Me.tbAccDR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbAccDR.UseSelectable = True
        Me.tbAccDR.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbAccDR.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tbAccCR
        '
        '
        '
        '
        Me.tbAccCR.CustomButton.Image = Nothing
        Me.tbAccCR.CustomButton.Location = New System.Drawing.Point(89, 1)
        Me.tbAccCR.CustomButton.Name = ""
        Me.tbAccCR.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbAccCR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbAccCR.CustomButton.TabIndex = 1
        Me.tbAccCR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbAccCR.CustomButton.UseSelectable = True
        Me.tbAccCR.CustomButton.Visible = False
        Me.tbAccCR.Enabled = False
        Me.tbAccCR.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbAccCR.Lines = New String(-1) {}
        Me.tbAccCR.Location = New System.Drawing.Point(227, 420)
        Me.tbAccCR.MaxLength = 32767
        Me.tbAccCR.Name = "tbAccCR"
        Me.tbAccCR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbAccCR.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbAccCR.SelectedText = ""
        Me.tbAccCR.SelectionLength = 0
        Me.tbAccCR.SelectionStart = 0
        Me.tbAccCR.Size = New System.Drawing.Size(117, 29)
        Me.tbAccCR.TabIndex = 76
        Me.tbAccCR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbAccCR.UseSelectable = True
        Me.tbAccCR.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbAccCR.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dgAccTrans
        '
        Me.dgAccTrans.AllowUserToAddRows = False
        Me.dgAccTrans.AllowUserToDeleteRows = False
        Me.dgAccTrans.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgAccTrans.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgAccTrans.BackgroundColor = System.Drawing.Color.White
        Me.dgAccTrans.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgAccTrans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgAccTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAccTrans.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgAccTrans.ContextMenuStrip = Me.cmVoucher
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgAccTrans.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgAccTrans.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgAccTrans.Location = New System.Drawing.Point(9, 64)
        Me.dgAccTrans.MultiSelect = False
        Me.dgAccTrans.Name = "dgAccTrans"
        Me.dgAccTrans.ReadOnly = True
        Me.dgAccTrans.RowHeadersVisible = False
        Me.dgAccTrans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgAccTrans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgAccTrans.Size = New System.Drawing.Size(376, 350)
        Me.dgAccTrans.TabIndex = 75
        '
        'Column4
        '
        Me.Column4.HeaderText = "Date"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 80
        '
        'Column5
        '
        Me.Column5.HeaderText = "Vch No."
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column6.HeaderText = "Debit"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column7.HeaderText = "Credit"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'cmVoucher
        '
        Me.cmVoucher.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsEdit, Me.cmsDelete})
        Me.cmVoucher.Name = "cmInv"
        Me.cmVoucher.Size = New System.Drawing.Size(108, 48)
        '
        'cmsEdit
        '
        Me.cmsEdit.Name = "cmsEdit"
        Me.cmsEdit.Size = New System.Drawing.Size(107, 22)
        Me.cmsEdit.Text = "Edit"
        '
        'cmsDelete
        '
        Me.cmsDelete.Name = "cmsDelete"
        Me.cmsDelete.Size = New System.Drawing.Size(107, 22)
        Me.cmsDelete.Text = "Delete"
        '
        'CustomPanel4
        '
        Me.CustomPanel4.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomPanel4.Curvature = 10
        Me.CustomPanel4.CurveMode = CType((Acc_System.CornerCurveMode.TopLeft Or Acc_System.CornerCurveMode.TopRight), Acc_System.CornerCurveMode)
        Me.CustomPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel4.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel4.Name = "CustomPanel4"
        Me.CustomPanel4.Size = New System.Drawing.Size(396, 23)
        Me.CustomPanel4.TabIndex = 44
        '
        'CustomPanel1
        '
        Me.CustomPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomPanel1.Controls.Add(Me.btnPrint)
        Me.CustomPanel1.Controls.Add(Me.Button4)
        Me.CustomPanel1.Controls.Add(Me.Button2)
        Me.CustomPanel1.Controls.Add(Me.tbTotalDebit)
        Me.CustomPanel1.Controls.Add(Me.dgTrial)
        Me.CustomPanel1.Controls.Add(Me.tbTotalCredit)
        Me.CustomPanel1.Controls.Add(Me.CustomPanel2)
        Me.CustomPanel1.Curvature = 10
        Me.CustomPanel1.Location = New System.Drawing.Point(23, 6)
        Me.CustomPanel1.Name = "CustomPanel1"
        Me.CustomPanel1.Size = New System.Drawing.Size(752, 497)
        Me.CustomPanel1.TabIndex = 66
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageSize = 25
        Me.btnPrint.Location = New System.Drawing.Point(715, 454)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(31, 30)
        Me.btnPrint.TabIndex = 76
        Me.btnPrint.UseSelectable = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(537, 455)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(39, 29)
        Me.Button4.TabIndex = 75
        Me.Button4.Text = "CR"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(357, 455)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 29)
        Me.Button2.TabIndex = 74
        Me.Button2.Text = "DR"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CustomPanel2
        '
        Me.CustomPanel2.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomPanel2.Curvature = 10
        Me.CustomPanel2.CurveMode = CType((Acc_System.CornerCurveMode.TopLeft Or Acc_System.CornerCurveMode.TopRight), Acc_System.CornerCurveMode)
        Me.CustomPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel2.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel2.Name = "CustomPanel2"
        Me.CustomPanel2.Size = New System.Drawing.Size(752, 23)
        Me.CustomPanel2.TabIndex = 44
        '
        'TbAccountTransTableAdapter
        '
        Me.TbAccountTransTableAdapter.ClearBeforeFill = True
        '
        'TbAccountsTableAdapter
        '
        Me.TbAccountsTableAdapter.ClearBeforeFill = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Account Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 400
        '
        'Column2
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column2.HeaderText = "Debit"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column3.HeaderText = "Credit"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'pnlTrialBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "pnlTrialBalance"
        Me.Size = New System.Drawing.Size(1200, 643)
        CType(Me.dgTrial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.CustomPanel7.ResumeLayout(False)
        Me.CustomPanel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.CustomPanel3.ResumeLayout(False)
        Me.CustomPanel3.PerformLayout()
        CType(Me.dgAccTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmVoucher.ResumeLayout(False)
        Me.CustomPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgTrial As MetroFramework.Controls.MetroGrid
    Friend WithEvents dtStart As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtEnd As MetroFramework.Controls.MetroDateTime
    Friend WithEvents btnRun As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents tbTotalDebit As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbTotalCredit As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CustomPanel5 As Acc_System.CustomPanel
    Friend WithEvents CustomPanel6 As Acc_System.CustomPanel
    Friend WithEvents CustomPanel1 As Acc_System.CustomPanel
    Friend WithEvents CustomPanel2 As Acc_System.CustomPanel
    Friend WithEvents CustomPanel3 As Acc_System.CustomPanel
    Friend WithEvents CustomPanel4 As Acc_System.CustomPanel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnPrint As MetroFramework.Controls.MetroLink
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents tbAccDR As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbAccCR As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dgAccTrans As System.Windows.Forms.DataGridView
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents TbAccountTransTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbAccountTransTableAdapter
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents tbAccBalance As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TbAccountsTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbAccountsTableAdapter
    Friend WithEvents CustomPanel7 As Acc_System.CustomPanel
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents CustomPanel8 As Acc_System.CustomPanel
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents MetroTextBox3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents cmVoucher As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents cmsEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
