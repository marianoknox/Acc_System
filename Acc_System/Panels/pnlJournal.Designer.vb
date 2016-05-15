<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlJournal
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pnlJournal))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgJournal = New MetroFramework.Controls.MetroGrid()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colParticula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDebit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCredit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmAccounts = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.cmsAddRef = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsRemoveAcc = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetroTextBox4 = New MetroFramework.Controls.MetroTextBox()
        Me.btnCloseBank = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroDateTime2 = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.pnlBankDetails = New System.Windows.Forms.Panel()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroComboBox3 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroComboBox2 = New MetroFramework.Controls.MetroComboBox()
        Me.btnBankDetails = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.tbBalance = New MetroFramework.Controls.MetroTextBox()
        Me.btnAddAccount = New MetroFramework.Controls.MetroButton()
        Me.tbAmount = New MetroFramework.Controls.MetroTextBox()
        Me.ACCDBDataSet = New Acc_System.ACCDBDataSet()
        Me.cbDRCR = New MetroFramework.Controls.MetroComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbAccSearch = New MetroFramework.Controls.MetroTextBox()
        Me.lnkDetails = New MetroFramework.Controls.MetroLink()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbReference = New MetroFramework.Controls.MetroTextBox()
        Me.cbVoucherType = New MetroFramework.Controls.MetroComboBox()
        Me.TbVouchersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbCostCenter = New MetroFramework.Controls.MetroComboBox()
        Me.TbCostCenterListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MetroTextBox8 = New MetroFramework.Controls.MetroTextBox()
        Me.cbAccount = New MetroFramework.Controls.MetroComboBox()
        Me.TbAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtDate = New MetroFramework.Controls.MetroDateTime()
        Me.btnRollDown = New MetroFramework.Controls.MetroLink()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnRollUp = New MetroFramework.Controls.MetroLink()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.chkPrintPreview = New MetroFramework.Controls.MetroCheckBox()
        Me.chkPrint = New MetroFramework.Controls.MetroCheckBox()
        Me.tbTotalCR = New MetroFramework.Controls.MetroTextBox()
        Me.tbNarration = New MetroFramework.Controls.MetroTextBox()
        Me.lblInvNo = New System.Windows.Forms.Label()
        Me.btnSaveInv = New MetroFramework.Controls.MetroLink()
        Me.tbTotalDR = New MetroFramework.Controls.MetroTextBox()
        Me.pnlAgainstRef = New System.Windows.Forms.Panel()
        Me.MetroTextBox10 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroTextBox7 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox6 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.btnAccept = New MetroFramework.Controls.MetroButton()
        Me.dgItemSelect = New MetroFramework.Controls.MetroGrid()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TbAccountTransTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbAccountTransTableAdapter()
        Me.TbAccountsTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbAccountsTableAdapter()
        Me.TbReferenceTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbReferenceTableAdapter()
        Me.TbCostCenterListTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbCostCenterListTableAdapter()
        Me.TbVouchersTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbVouchersTableAdapter()
        Me.pnlAccDetails = New System.Windows.Forms.Panel()
        Me.tbAccBalance = New MetroFramework.Controls.MetroTextBox()
        Me.tbDRCR = New MetroFramework.Controls.MetroTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MetroLink2 = New MetroFramework.Controls.MetroLink()
        Me.TbVoucherTransTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbVoucherTransTableAdapter()
        CType(Me.dgJournal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmAccounts.SuspendLayout()
        Me.pnlBankDetails.SuspendLayout()
        CType(Me.ACCDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TbVouchersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCostCenterListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.pnlAgainstRef.SuspendLayout()
        CType(Me.dgItemSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAccDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgJournal
        '
        Me.dgJournal.AllowUserToAddRows = False
        Me.dgJournal.AllowUserToDeleteRows = False
        Me.dgJournal.AllowUserToResizeColumns = False
        Me.dgJournal.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgJournal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgJournal.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgJournal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgJournal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgJournal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgJournal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgJournal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column5, Me.colParticula, Me.colDebit, Me.colCredit})
        Me.dgJournal.ContextMenuStrip = Me.cmAccounts
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgJournal.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgJournal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgJournal.EnableHeadersVisualStyles = False
        Me.dgJournal.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgJournal.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgJournal.Location = New System.Drawing.Point(27, 86)
        Me.dgJournal.MultiSelect = False
        Me.dgJournal.Name = "dgJournal"
        Me.dgJournal.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgJournal.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgJournal.RowHeadersVisible = False
        Me.dgJournal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgJournal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgJournal.Size = New System.Drawing.Size(1173, 452)
        Me.dgJournal.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgJournal.TabIndex = 7
        '
        'Column2
        '
        Me.Column2.HeaderText = "No"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 40
        '
        'Column5
        '
        Me.Column5.HeaderText = "As"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'colParticula
        '
        Me.colParticula.HeaderText = "Account Name"
        Me.colParticula.Name = "colParticula"
        Me.colParticula.ReadOnly = True
        Me.colParticula.Width = 600
        '
        'colDebit
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colDebit.DefaultCellStyle = DataGridViewCellStyle3
        Me.colDebit.HeaderText = "Debit"
        Me.colDebit.Name = "colDebit"
        Me.colDebit.Width = 200
        '
        'colCredit
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colCredit.DefaultCellStyle = DataGridViewCellStyle4
        Me.colCredit.HeaderText = "Credit"
        Me.colCredit.Name = "colCredit"
        Me.colCredit.Width = 200
        '
        'cmAccounts
        '
        Me.cmAccounts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsAddRef, Me.cmsRemoveAcc})
        Me.cmAccounts.Name = "cmInv"
        Me.cmAccounts.Size = New System.Drawing.Size(127, 48)
        '
        'cmsAddRef
        '
        Me.cmsAddRef.Name = "cmsAddRef"
        Me.cmsAddRef.Size = New System.Drawing.Size(126, 22)
        Me.cmsAddRef.Text = "Reference"
        '
        'cmsRemoveAcc
        '
        Me.cmsRemoveAcc.Name = "cmsRemoveAcc"
        Me.cmsRemoveAcc.Size = New System.Drawing.Size(126, 22)
        Me.cmsRemoveAcc.Text = "Remove"
        '
        'MetroTextBox4
        '
        '
        '
        '
        Me.MetroTextBox4.CustomButton.Image = Nothing
        Me.MetroTextBox4.CustomButton.Location = New System.Drawing.Point(220, 1)
        Me.MetroTextBox4.CustomButton.Name = ""
        Me.MetroTextBox4.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox4.CustomButton.TabIndex = 1
        Me.MetroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox4.CustomButton.UseSelectable = True
        Me.MetroTextBox4.CustomButton.Visible = False
        Me.MetroTextBox4.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox4.Lines = New String(-1) {}
        Me.MetroTextBox4.Location = New System.Drawing.Point(167, 191)
        Me.MetroTextBox4.MaxLength = 32767
        Me.MetroTextBox4.Name = "MetroTextBox4"
        Me.MetroTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox4.SelectedText = ""
        Me.MetroTextBox4.SelectionLength = 0
        Me.MetroTextBox4.SelectionStart = 0
        Me.MetroTextBox4.Size = New System.Drawing.Size(248, 29)
        Me.MetroTextBox4.TabIndex = 40
        Me.MetroTextBox4.UseSelectable = True
        Me.MetroTextBox4.WaterMark = "Bank Name"
        Me.MetroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox4.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnCloseBank
        '
        Me.btnCloseBank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseBank.Image = CType(resources.GetObject("btnCloseBank.Image"), System.Drawing.Image)
        Me.btnCloseBank.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCloseBank.ImageSize = 30
        Me.btnCloseBank.Location = New System.Drawing.Point(386, 13)
        Me.btnCloseBank.Name = "btnCloseBank"
        Me.btnCloseBank.Size = New System.Drawing.Size(29, 34)
        Me.btnCloseBank.TabIndex = 41
        Me.btnCloseBank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCloseBank.UseSelectable = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel10.Location = New System.Drawing.Point(65, 160)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(96, 25)
        Me.MetroLabel10.TabIndex = 39
        Me.MetroLabel10.Text = "Inst. Date : "
        '
        'MetroDateTime2
        '
        Me.MetroDateTime2.Location = New System.Drawing.Point(167, 156)
        Me.MetroDateTime2.MinimumSize = New System.Drawing.Size(4, 29)
        Me.MetroDateTime2.Name = "MetroDateTime2"
        Me.MetroDateTime2.Size = New System.Drawing.Size(248, 29)
        Me.MetroDateTime2.TabIndex = 38
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.Location = New System.Drawing.Point(7, 88)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(154, 25)
        Me.MetroLabel7.TabIndex = 37
        Me.MetroLabel7.Text = "Transaction Type : "
        '
        'pnlBankDetails
        '
        Me.pnlBankDetails.BackColor = System.Drawing.Color.White
        Me.pnlBankDetails.Controls.Add(Me.btnCloseBank)
        Me.pnlBankDetails.Controls.Add(Me.MetroTextBox4)
        Me.pnlBankDetails.Controls.Add(Me.MetroLabel10)
        Me.pnlBankDetails.Controls.Add(Me.MetroDateTime2)
        Me.pnlBankDetails.Controls.Add(Me.MetroTextBox1)
        Me.pnlBankDetails.Controls.Add(Me.MetroLabel7)
        Me.pnlBankDetails.Controls.Add(Me.MetroComboBox3)
        Me.pnlBankDetails.Controls.Add(Me.MetroLabel6)
        Me.pnlBankDetails.Controls.Add(Me.MetroComboBox2)
        Me.pnlBankDetails.Controls.Add(Me.btnBankDetails)
        Me.pnlBankDetails.Controls.Add(Me.MetroLabel5)
        Me.pnlBankDetails.Location = New System.Drawing.Point(736, 45)
        Me.pnlBankDetails.Name = "pnlBankDetails"
        Me.pnlBankDetails.Size = New System.Drawing.Size(432, 268)
        Me.pnlBankDetails.TabIndex = 9
        Me.pnlBankDetails.Visible = False
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(220, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(167, 121)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.Size = New System.Drawing.Size(248, 29)
        Me.MetroTextBox1.TabIndex = 34
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMark = "Inst. Number"
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroComboBox3
        '
        Me.MetroComboBox3.FormattingEnabled = True
        Me.MetroComboBox3.ItemHeight = 23
        Me.MetroComboBox3.Location = New System.Drawing.Point(167, 84)
        Me.MetroComboBox3.Name = "MetroComboBox3"
        Me.MetroComboBox3.Size = New System.Drawing.Size(248, 29)
        Me.MetroComboBox3.TabIndex = 36
        Me.MetroComboBox3.UseSelectable = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel6.Location = New System.Drawing.Point(24, 53)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(137, 25)
        Me.MetroLabel6.TabIndex = 35
        Me.MetroLabel6.Text = "Received From : "
        '
        'MetroComboBox2
        '
        Me.MetroComboBox2.FormattingEnabled = True
        Me.MetroComboBox2.ItemHeight = 23
        Me.MetroComboBox2.Location = New System.Drawing.Point(167, 49)
        Me.MetroComboBox2.Name = "MetroComboBox2"
        Me.MetroComboBox2.Size = New System.Drawing.Size(248, 29)
        Me.MetroComboBox2.TabIndex = 34
        Me.MetroComboBox2.UseSelectable = True
        '
        'btnBankDetails
        '
        Me.btnBankDetails.Location = New System.Drawing.Point(319, 226)
        Me.btnBankDetails.Name = "btnBankDetails"
        Me.btnBankDetails.Size = New System.Drawing.Size(96, 34)
        Me.btnBankDetails.TabIndex = 32
        Me.btnBankDetails.Text = "Enter"
        Me.btnBankDetails.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.Location = New System.Drawing.Point(3, 13)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(228, 25)
        Me.MetroLabel5.TabIndex = 29
        Me.MetroLabel5.Text = "Bank Reconciliation Details : "
        '
        'tbBalance
        '
        '
        '
        '
        Me.tbBalance.CustomButton.Image = Nothing
        Me.tbBalance.CustomButton.Location = New System.Drawing.Point(236, 1)
        Me.tbBalance.CustomButton.Name = ""
        Me.tbBalance.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbBalance.CustomButton.TabIndex = 1
        Me.tbBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbBalance.CustomButton.UseSelectable = True
        Me.tbBalance.CustomButton.Visible = False
        Me.tbBalance.Enabled = False
        Me.tbBalance.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbBalance.Lines = New String(-1) {}
        Me.tbBalance.Location = New System.Drawing.Point(208, 46)
        Me.tbBalance.MaxLength = 32767
        Me.tbBalance.Name = "tbBalance"
        Me.tbBalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbBalance.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbBalance.SelectedText = ""
        Me.tbBalance.SelectionLength = 0
        Me.tbBalance.SelectionStart = 0
        Me.tbBalance.Size = New System.Drawing.Size(264, 29)
        Me.tbBalance.TabIndex = 33
        Me.tbBalance.UseSelectable = True
        Me.tbBalance.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbBalance.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnAddAccount
        '
        Me.btnAddAccount.Location = New System.Drawing.Point(752, 9)
        Me.btnAddAccount.Name = "btnAddAccount"
        Me.btnAddAccount.Size = New System.Drawing.Size(96, 66)
        Me.btnAddAccount.TabIndex = 31
        Me.btnAddAccount.Text = "Enter"
        Me.btnAddAccount.UseSelectable = True
        '
        'tbAmount
        '
        '
        '
        '
        Me.tbAmount.CustomButton.Image = Nothing
        Me.tbAmount.CustomButton.Location = New System.Drawing.Point(129, 1)
        Me.tbAmount.CustomButton.Name = ""
        Me.tbAmount.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbAmount.CustomButton.TabIndex = 1
        Me.tbAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbAmount.CustomButton.UseSelectable = True
        Me.tbAmount.CustomButton.Visible = False
        Me.tbAmount.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbAmount.Lines = New String(-1) {}
        Me.tbAmount.Location = New System.Drawing.Point(590, 9)
        Me.tbAmount.MaxLength = 32767
        Me.tbAmount.Name = "tbAmount"
        Me.tbAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbAmount.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbAmount.SelectedText = ""
        Me.tbAmount.SelectionLength = 0
        Me.tbAmount.SelectionStart = 0
        Me.tbAmount.Size = New System.Drawing.Size(157, 29)
        Me.tbAmount.TabIndex = 30
        Me.tbAmount.UseSelectable = True
        Me.tbAmount.WaterMark = "Amount"
        Me.tbAmount.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbAmount.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ACCDBDataSet
        '
        Me.ACCDBDataSet.DataSetName = "ACCDBDataSet"
        Me.ACCDBDataSet.EnforceConstraints = False
        Me.ACCDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbDRCR
        '
        Me.cbDRCR.FormattingEnabled = True
        Me.cbDRCR.ItemHeight = 23
        Me.cbDRCR.Location = New System.Drawing.Point(524, 9)
        Me.cbDRCR.Name = "cbDRCR"
        Me.cbDRCR.Size = New System.Drawing.Size(60, 29)
        Me.cbDRCR.TabIndex = 29
        Me.cbDRCR.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.tbAccSearch)
        Me.Panel1.Controls.Add(Me.lnkDetails)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.tbReference)
        Me.Panel1.Controls.Add(Me.cbVoucherType)
        Me.Panel1.Controls.Add(Me.cbCostCenter)
        Me.Panel1.Controls.Add(Me.MetroTextBox8)
        Me.Panel1.Controls.Add(Me.tbBalance)
        Me.Panel1.Controls.Add(Me.btnAddAccount)
        Me.Panel1.Controls.Add(Me.tbAmount)
        Me.Panel1.Controls.Add(Me.cbDRCR)
        Me.Panel1.Controls.Add(Me.cbAccount)
        Me.Panel1.Controls.Add(Me.dtDate)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 86)
        Me.Panel1.TabIndex = 5
        '
        'tbAccSearch
        '
        '
        '
        '
        Me.tbAccSearch.CustomButton.Image = Nothing
        Me.tbAccSearch.CustomButton.Location = New System.Drawing.Point(94, 1)
        Me.tbAccSearch.CustomButton.Name = ""
        Me.tbAccSearch.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbAccSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbAccSearch.CustomButton.TabIndex = 1
        Me.tbAccSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbAccSearch.CustomButton.UseSelectable = True
        Me.tbAccSearch.CustomButton.Visible = False
        Me.tbAccSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbAccSearch.Lines = New String(-1) {}
        Me.tbAccSearch.Location = New System.Drawing.Point(27, 9)
        Me.tbAccSearch.MaxLength = 32767
        Me.tbAccSearch.Name = "tbAccSearch"
        Me.tbAccSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbAccSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbAccSearch.SelectedText = ""
        Me.tbAccSearch.SelectionLength = 0
        Me.tbAccSearch.SelectionStart = 0
        Me.tbAccSearch.Size = New System.Drawing.Size(122, 29)
        Me.tbAccSearch.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbAccSearch.TabIndex = 43
        Me.tbAccSearch.UseSelectable = True
        Me.tbAccSearch.WaterMark = "Account"
        Me.tbAccSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbAccSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lnkDetails
        '
        Me.lnkDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkDetails.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.lnkDetails.ImageSize = 30
        Me.lnkDetails.Location = New System.Drawing.Point(481, 47)
        Me.lnkDetails.Name = "lnkDetails"
        Me.lnkDetails.Size = New System.Drawing.Size(37, 29)
        Me.lnkDetails.TabIndex = 78
        Me.lnkDetails.Text = ". . ."
        Me.lnkDetails.UseSelectable = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(27, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 28)
        Me.Button1.TabIndex = 67
        Me.Button1.Text = "Balance"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbReference
        '
        '
        '
        '
        Me.tbReference.CustomButton.Image = Nothing
        Me.tbReference.CustomButton.Location = New System.Drawing.Point(96, 1)
        Me.tbReference.CustomButton.Name = ""
        Me.tbReference.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbReference.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbReference.CustomButton.TabIndex = 1
        Me.tbReference.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbReference.CustomButton.UseSelectable = True
        Me.tbReference.CustomButton.Visible = False
        Me.tbReference.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbReference.Lines = New String(-1) {}
        Me.tbReference.Location = New System.Drawing.Point(875, 13)
        Me.tbReference.MaxLength = 32767
        Me.tbReference.Name = "tbReference"
        Me.tbReference.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbReference.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbReference.SelectedText = ""
        Me.tbReference.SelectionLength = 0
        Me.tbReference.SelectionStart = 0
        Me.tbReference.Size = New System.Drawing.Size(124, 29)
        Me.tbReference.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbReference.TabIndex = 38
        Me.tbReference.UseSelectable = True
        Me.tbReference.WaterMark = "Reference"
        Me.tbReference.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbReference.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cbVoucherType
        '
        Me.cbVoucherType.DataSource = Me.TbVouchersBindingSource
        Me.cbVoucherType.DisplayMember = "Voucher_Name"
        Me.cbVoucherType.FormattingEnabled = True
        Me.cbVoucherType.ItemHeight = 23
        Me.cbVoucherType.Location = New System.Drawing.Point(1002, 13)
        Me.cbVoucherType.Name = "cbVoucherType"
        Me.cbVoucherType.Size = New System.Drawing.Size(184, 29)
        Me.cbVoucherType.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbVoucherType.TabIndex = 37
        Me.cbVoucherType.UseSelectable = True
        '
        'TbVouchersBindingSource
        '
        Me.TbVouchersBindingSource.DataMember = "tbVouchers"
        Me.TbVouchersBindingSource.DataSource = Me.ACCDBDataSet
        '
        'cbCostCenter
        '
        Me.cbCostCenter.DataSource = Me.TbCostCenterListBindingSource
        Me.cbCostCenter.DisplayMember = "Cost_Center"
        Me.cbCostCenter.FormattingEnabled = True
        Me.cbCostCenter.ItemHeight = 23
        Me.cbCostCenter.Location = New System.Drawing.Point(875, 46)
        Me.cbCostCenter.Name = "cbCostCenter"
        Me.cbCostCenter.Size = New System.Drawing.Size(311, 29)
        Me.cbCostCenter.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbCostCenter.TabIndex = 36
        Me.cbCostCenter.UseSelectable = True
        '
        'TbCostCenterListBindingSource
        '
        Me.TbCostCenterListBindingSource.DataMember = "tbCostCenterList"
        Me.TbCostCenterListBindingSource.DataSource = Me.ACCDBDataSet
        '
        'MetroTextBox8
        '
        '
        '
        '
        Me.MetroTextBox8.CustomButton.Image = Nothing
        Me.MetroTextBox8.CustomButton.Location = New System.Drawing.Point(26, 1)
        Me.MetroTextBox8.CustomButton.Name = ""
        Me.MetroTextBox8.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox8.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox8.CustomButton.TabIndex = 1
        Me.MetroTextBox8.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox8.CustomButton.UseSelectable = True
        Me.MetroTextBox8.CustomButton.Visible = False
        Me.MetroTextBox8.Enabled = False
        Me.MetroTextBox8.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox8.Lines = New String(-1) {}
        Me.MetroTextBox8.Location = New System.Drawing.Point(151, 46)
        Me.MetroTextBox8.MaxLength = 32767
        Me.MetroTextBox8.Name = "MetroTextBox8"
        Me.MetroTextBox8.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox8.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox8.SelectedText = ""
        Me.MetroTextBox8.SelectionLength = 0
        Me.MetroTextBox8.SelectionStart = 0
        Me.MetroTextBox8.Size = New System.Drawing.Size(54, 29)
        Me.MetroTextBox8.TabIndex = 35
        Me.MetroTextBox8.UseSelectable = True
        Me.MetroTextBox8.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox8.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cbAccount
        '
        Me.cbAccount.DataSource = Me.TbAccountsBindingSource
        Me.cbAccount.DisplayMember = "Account_Name"
        Me.cbAccount.FormattingEnabled = True
        Me.cbAccount.ItemHeight = 23
        Me.cbAccount.Location = New System.Drawing.Point(151, 9)
        Me.cbAccount.Name = "cbAccount"
        Me.cbAccount.Size = New System.Drawing.Size(367, 29)
        Me.cbAccount.TabIndex = 27
        Me.cbAccount.UseSelectable = True
        '
        'TbAccountsBindingSource
        '
        Me.TbAccountsBindingSource.DataMember = "tbAccounts"
        Me.TbAccountsBindingSource.DataSource = Me.ACCDBDataSet
        '
        'dtDate
        '
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDate.Location = New System.Drawing.Point(524, 46)
        Me.dtDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(222, 29)
        Me.dtDate.TabIndex = 25
        '
        'btnRollDown
        '
        Me.btnRollDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRollDown.Image = CType(resources.GetObject("btnRollDown.Image"), System.Drawing.Image)
        Me.btnRollDown.ImageSize = 20
        Me.btnRollDown.Location = New System.Drawing.Point(3, 3)
        Me.btnRollDown.Name = "btnRollDown"
        Me.btnRollDown.NoFocusImage = CType(resources.GetObject("btnRollDown.NoFocusImage"), System.Drawing.Image)
        Me.btnRollDown.Size = New System.Drawing.Size(21, 24)
        Me.btnRollDown.TabIndex = 60
        Me.btnRollDown.UseSelectable = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.btnRollUp)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 86)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(27, 452)
        Me.Panel6.TabIndex = 21
        '
        'btnRollUp
        '
        Me.btnRollUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRollUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRollUp.Image = CType(resources.GetObject("btnRollUp.Image"), System.Drawing.Image)
        Me.btnRollUp.ImageSize = 20
        Me.btnRollUp.Location = New System.Drawing.Point(3, 426)
        Me.btnRollUp.Name = "btnRollUp"
        Me.btnRollUp.NoFocusImage = CType(resources.GetObject("btnRollUp.NoFocusImage"), System.Drawing.Image)
        Me.btnRollUp.Size = New System.Drawing.Size(21, 23)
        Me.btnRollUp.TabIndex = 60
        Me.btnRollUp.UseSelectable = True
        Me.btnRollUp.Visible = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.Controls.Add(Me.chkPrintPreview)
        Me.Panel9.Controls.Add(Me.chkPrint)
        Me.Panel9.Controls.Add(Me.tbTotalCR)
        Me.Panel9.Controls.Add(Me.tbNarration)
        Me.Panel9.Controls.Add(Me.lblInvNo)
        Me.Panel9.Controls.Add(Me.btnSaveInv)
        Me.Panel9.Controls.Add(Me.btnRollDown)
        Me.Panel9.Controls.Add(Me.tbTotalDR)
        Me.Panel9.Controls.Add(Me.pnlBankDetails)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 538)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1200, 105)
        Me.Panel9.TabIndex = 22
        '
        'chkPrintPreview
        '
        Me.chkPrintPreview.AutoSize = True
        Me.chkPrintPreview.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkPrintPreview.Location = New System.Drawing.Point(551, 68)
        Me.chkPrintPreview.Name = "chkPrintPreview"
        Me.chkPrintPreview.Size = New System.Drawing.Size(142, 19)
        Me.chkPrintPreview.TabIndex = 74
        Me.chkPrintPreview.Text = "Show Print Preview"
        Me.chkPrintPreview.UseSelectable = True
        '
        'chkPrint
        '
        Me.chkPrint.AutoSize = True
        Me.chkPrint.Checked = True
        Me.chkPrint.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrint.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkPrint.Location = New System.Drawing.Point(551, 45)
        Me.chkPrint.Name = "chkPrint"
        Me.chkPrint.Size = New System.Drawing.Size(117, 19)
        Me.chkPrint.TabIndex = 73
        Me.chkPrint.Text = "Print after save"
        Me.chkPrint.UseSelectable = True
        '
        'tbTotalCR
        '
        '
        '
        '
        Me.tbTotalCR.CustomButton.Image = Nothing
        Me.tbTotalCR.CustomButton.Location = New System.Drawing.Point(137, 1)
        Me.tbTotalCR.CustomButton.Name = ""
        Me.tbTotalCR.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbTotalCR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbTotalCR.CustomButton.TabIndex = 1
        Me.tbTotalCR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbTotalCR.CustomButton.UseSelectable = True
        Me.tbTotalCR.CustomButton.Visible = False
        Me.tbTotalCR.Enabled = False
        Me.tbTotalCR.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbTotalCR.Lines = New String(-1) {}
        Me.tbTotalCR.Location = New System.Drawing.Point(963, 9)
        Me.tbTotalCR.MaxLength = 32767
        Me.tbTotalCR.Name = "tbTotalCR"
        Me.tbTotalCR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTotalCR.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbTotalCR.SelectedText = ""
        Me.tbTotalCR.SelectionLength = 0
        Me.tbTotalCR.SelectionStart = 0
        Me.tbTotalCR.Size = New System.Drawing.Size(165, 29)
        Me.tbTotalCR.TabIndex = 34
        Me.tbTotalCR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbTotalCR.UseSelectable = True
        Me.tbTotalCR.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbTotalCR.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tbNarration
        '
        '
        '
        '
        Me.tbNarration.CustomButton.Image = Nothing
        Me.tbNarration.CustomButton.Location = New System.Drawing.Point(629, 2)
        Me.tbNarration.CustomButton.Name = ""
        Me.tbNarration.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.tbNarration.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbNarration.CustomButton.TabIndex = 1
        Me.tbNarration.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbNarration.CustomButton.UseSelectable = True
        Me.tbNarration.CustomButton.Visible = False
        Me.tbNarration.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbNarration.Lines = New String(-1) {}
        Me.tbNarration.Location = New System.Drawing.Point(32, 9)
        Me.tbNarration.MaxLength = 32767
        Me.tbNarration.Name = "tbNarration"
        Me.tbNarration.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNarration.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbNarration.SelectedText = ""
        Me.tbNarration.SelectionLength = 0
        Me.tbNarration.SelectionStart = 0
        Me.tbNarration.Size = New System.Drawing.Size(657, 30)
        Me.tbNarration.TabIndex = 64
        Me.tbNarration.UseSelectable = True
        Me.tbNarration.WaterMark = "Narration"
        Me.tbNarration.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbNarration.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblInvNo
        '
        Me.lblInvNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblInvNo.AutoSize = True
        Me.lblInvNo.BackColor = System.Drawing.Color.Transparent
        Me.lblInvNo.Font = New System.Drawing.Font("Segoe UI Light", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvNo.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblInvNo.Location = New System.Drawing.Point(21, 36)
        Me.lblInvNo.Name = "lblInvNo"
        Me.lblInvNo.Size = New System.Drawing.Size(179, 65)
        Me.lblInvNo.TabIndex = 63
        Me.lblInvNo.Text = "CR-001"
        '
        'btnSaveInv
        '
        Me.btnSaveInv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveInv.Enabled = False
        Me.btnSaveInv.Image = CType(resources.GetObject("btnSaveInv.Image"), System.Drawing.Image)
        Me.btnSaveInv.ImageSize = 25
        Me.btnSaveInv.Location = New System.Drawing.Point(1134, 9)
        Me.btnSaveInv.Name = "btnSaveInv"
        Me.btnSaveInv.NoFocusImage = CType(resources.GetObject("btnSaveInv.NoFocusImage"), System.Drawing.Image)
        Me.btnSaveInv.Size = New System.Drawing.Size(34, 30)
        Me.btnSaveInv.TabIndex = 61
        Me.btnSaveInv.UseSelectable = True
        '
        'tbTotalDR
        '
        '
        '
        '
        Me.tbTotalDR.CustomButton.Image = Nothing
        Me.tbTotalDR.CustomButton.Location = New System.Drawing.Point(137, 1)
        Me.tbTotalDR.CustomButton.Name = ""
        Me.tbTotalDR.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbTotalDR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbTotalDR.CustomButton.TabIndex = 1
        Me.tbTotalDR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbTotalDR.CustomButton.UseSelectable = True
        Me.tbTotalDR.CustomButton.Visible = False
        Me.tbTotalDR.Enabled = False
        Me.tbTotalDR.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbTotalDR.Lines = New String(-1) {}
        Me.tbTotalDR.Location = New System.Drawing.Point(792, 9)
        Me.tbTotalDR.MaxLength = 32767
        Me.tbTotalDR.Name = "tbTotalDR"
        Me.tbTotalDR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTotalDR.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbTotalDR.SelectedText = ""
        Me.tbTotalDR.SelectionLength = 0
        Me.tbTotalDR.SelectionStart = 0
        Me.tbTotalDR.Size = New System.Drawing.Size(165, 29)
        Me.tbTotalDR.TabIndex = 38
        Me.tbTotalDR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbTotalDR.UseSelectable = True
        Me.tbTotalDR.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbTotalDR.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'pnlAgainstRef
        '
        Me.pnlAgainstRef.BackColor = System.Drawing.Color.White
        Me.pnlAgainstRef.Controls.Add(Me.MetroTextBox10)
        Me.pnlAgainstRef.Controls.Add(Me.MetroButton1)
        Me.pnlAgainstRef.Controls.Add(Me.MetroTextBox7)
        Me.pnlAgainstRef.Controls.Add(Me.MetroLabel3)
        Me.pnlAgainstRef.Controls.Add(Me.MetroTextBox6)
        Me.pnlAgainstRef.Controls.Add(Me.MetroLabel2)
        Me.pnlAgainstRef.Controls.Add(Me.btnAccept)
        Me.pnlAgainstRef.Controls.Add(Me.dgItemSelect)
        Me.pnlAgainstRef.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlAgainstRef.Location = New System.Drawing.Point(1200, 120)
        Me.pnlAgainstRef.Name = "pnlAgainstRef"
        Me.pnlAgainstRef.Size = New System.Drawing.Size(360, 390)
        Me.pnlAgainstRef.TabIndex = 23
        '
        'MetroTextBox10
        '
        '
        '
        '
        Me.MetroTextBox10.CustomButton.Image = Nothing
        Me.MetroTextBox10.CustomButton.Location = New System.Drawing.Point(14, 1)
        Me.MetroTextBox10.CustomButton.Name = ""
        Me.MetroTextBox10.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox10.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox10.CustomButton.TabIndex = 1
        Me.MetroTextBox10.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox10.CustomButton.UseSelectable = True
        Me.MetroTextBox10.CustomButton.Visible = False
        Me.MetroTextBox10.Enabled = False
        Me.MetroTextBox10.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox10.Lines = New String(-1) {}
        Me.MetroTextBox10.Location = New System.Drawing.Point(109, 6)
        Me.MetroTextBox10.MaxLength = 32767
        Me.MetroTextBox10.Name = "MetroTextBox10"
        Me.MetroTextBox10.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox10.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox10.SelectedText = ""
        Me.MetroTextBox10.SelectionLength = 0
        Me.MetroTextBox10.SelectionStart = 0
        Me.MetroTextBox10.Size = New System.Drawing.Size(42, 29)
        Me.MetroTextBox10.TabIndex = 69
        Me.MetroTextBox10.UseSelectable = True
        Me.MetroTextBox10.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox10.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(174, 350)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(69, 30)
        Me.MetroButton1.TabIndex = 68
        Me.MetroButton1.Text = "Cancel"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroTextBox7
        '
        '
        '
        '
        Me.MetroTextBox7.CustomButton.Image = Nothing
        Me.MetroTextBox7.CustomButton.Location = New System.Drawing.Point(146, 1)
        Me.MetroTextBox7.CustomButton.Name = ""
        Me.MetroTextBox7.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox7.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox7.CustomButton.TabIndex = 1
        Me.MetroTextBox7.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox7.CustomButton.UseSelectable = True
        Me.MetroTextBox7.CustomButton.Visible = False
        Me.MetroTextBox7.Enabled = False
        Me.MetroTextBox7.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox7.Lines = New String(-1) {}
        Me.MetroTextBox7.Location = New System.Drawing.Point(147, 315)
        Me.MetroTextBox7.MaxLength = 32767
        Me.MetroTextBox7.Name = "MetroTextBox7"
        Me.MetroTextBox7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox7.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox7.SelectedText = ""
        Me.MetroTextBox7.SelectionLength = 0
        Me.MetroTextBox7.SelectionStart = 0
        Me.MetroTextBox7.Size = New System.Drawing.Size(174, 29)
        Me.MetroTextBox7.TabIndex = 67
        Me.MetroTextBox7.UseSelectable = True
        Me.MetroTextBox7.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox7.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(18, 325)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(133, 19)
        Me.MetroLabel3.TabIndex = 66
        Me.MetroLabel3.Text = "Remaining Amount : "
        '
        'MetroTextBox6
        '
        '
        '
        '
        Me.MetroTextBox6.CustomButton.Image = Nothing
        Me.MetroTextBox6.CustomButton.Location = New System.Drawing.Point(136, 1)
        Me.MetroTextBox6.CustomButton.Name = ""
        Me.MetroTextBox6.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox6.CustomButton.TabIndex = 1
        Me.MetroTextBox6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox6.CustomButton.UseSelectable = True
        Me.MetroTextBox6.CustomButton.Visible = False
        Me.MetroTextBox6.Enabled = False
        Me.MetroTextBox6.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox6.Lines = New String(-1) {}
        Me.MetroTextBox6.Location = New System.Drawing.Point(157, 6)
        Me.MetroTextBox6.MaxLength = 32767
        Me.MetroTextBox6.Name = "MetroTextBox6"
        Me.MetroTextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox6.SelectedText = ""
        Me.MetroTextBox6.SelectionLength = 0
        Me.MetroTextBox6.SelectionStart = 0
        Me.MetroTextBox6.Size = New System.Drawing.Size(164, 29)
        Me.MetroTextBox6.TabIndex = 65
        Me.MetroTextBox6.UseSelectable = True
        Me.MetroTextBox6.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox6.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(12, 16)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(95, 19)
        Me.MetroLabel2.TabIndex = 64
        Me.MetroLabel2.Text = "Acc. Amount : "
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(252, 350)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(69, 30)
        Me.btnAccept.TabIndex = 22
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseSelectable = True
        '
        'dgItemSelect
        '
        Me.dgItemSelect.AllowUserToAddRows = False
        Me.dgItemSelect.AllowUserToDeleteRows = False
        Me.dgItemSelect.AllowUserToResizeColumns = False
        Me.dgItemSelect.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgItemSelect.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgItemSelect.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgItemSelect.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgItemSelect.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgItemSelect.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgItemSelect.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgItemSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItemSelect.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column4, Me.Column6, Me.Column8})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgItemSelect.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgItemSelect.EnableHeadersVisualStyles = False
        Me.dgItemSelect.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgItemSelect.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgItemSelect.Location = New System.Drawing.Point(12, 41)
        Me.dgItemSelect.MultiSelect = False
        Me.dgItemSelect.Name = "dgItemSelect"
        Me.dgItemSelect.ReadOnly = True
        Me.dgItemSelect.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgItemSelect.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgItemSelect.RowHeadersVisible = False
        Me.dgItemSelect.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgItemSelect.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgItemSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgItemSelect.Size = New System.Drawing.Size(327, 268)
        Me.dgItemSelect.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgItemSelect.TabIndex = 19
        '
        'Column7
        '
        Me.Column7.HeaderText = "As"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 30
        '
        'Column4
        '
        Me.Column4.HeaderText = "Reference"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "Value"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Ck"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 30
        '
        'TbAccountTransTableAdapter
        '
        Me.TbAccountTransTableAdapter.ClearBeforeFill = True
        '
        'TbAccountsTableAdapter
        '
        Me.TbAccountsTableAdapter.ClearBeforeFill = True
        '
        'TbReferenceTableAdapter
        '
        Me.TbReferenceTableAdapter.ClearBeforeFill = True
        '
        'TbCostCenterListTableAdapter
        '
        Me.TbCostCenterListTableAdapter.ClearBeforeFill = True
        '
        'TbVouchersTableAdapter
        '
        Me.TbVouchersTableAdapter.ClearBeforeFill = True
        '
        'pnlAccDetails
        '
        Me.pnlAccDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAccDetails.BackColor = System.Drawing.Color.White
        Me.pnlAccDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAccDetails.Controls.Add(Me.tbAccBalance)
        Me.pnlAccDetails.Controls.Add(Me.tbDRCR)
        Me.pnlAccDetails.Controls.Add(Me.Button2)
        Me.pnlAccDetails.Controls.Add(Me.MetroLink2)
        Me.pnlAccDetails.Location = New System.Drawing.Point(254, 84)
        Me.pnlAccDetails.Name = "pnlAccDetails"
        Me.pnlAccDetails.Size = New System.Drawing.Size(264, 86)
        Me.pnlAccDetails.TabIndex = 77
        Me.pnlAccDetails.Visible = False
        '
        'tbAccBalance
        '
        '
        '
        '
        Me.tbAccBalance.CustomButton.Image = Nothing
        Me.tbAccBalance.CustomButton.Location = New System.Drawing.Point(159, 2)
        Me.tbAccBalance.CustomButton.Name = ""
        Me.tbAccBalance.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.tbAccBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbAccBalance.CustomButton.TabIndex = 1
        Me.tbAccBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbAccBalance.CustomButton.UseSelectable = True
        Me.tbAccBalance.CustomButton.Visible = False
        Me.tbAccBalance.Enabled = False
        Me.tbAccBalance.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbAccBalance.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.tbAccBalance.Lines = New String(-1) {}
        Me.tbAccBalance.Location = New System.Drawing.Point(63, 42)
        Me.tbAccBalance.MaxLength = 32767
        Me.tbAccBalance.Name = "tbAccBalance"
        Me.tbAccBalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbAccBalance.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbAccBalance.SelectedText = ""
        Me.tbAccBalance.SelectionLength = 0
        Me.tbAccBalance.SelectionStart = 0
        Me.tbAccBalance.Size = New System.Drawing.Size(187, 30)
        Me.tbAccBalance.TabIndex = 72
        Me.tbAccBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbAccBalance.UseSelectable = True
        Me.tbAccBalance.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbAccBalance.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tbDRCR
        '
        '
        '
        '
        Me.tbDRCR.CustomButton.Image = Nothing
        Me.tbDRCR.CustomButton.Location = New System.Drawing.Point(19, 2)
        Me.tbDRCR.CustomButton.Name = ""
        Me.tbDRCR.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.tbDRCR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbDRCR.CustomButton.TabIndex = 1
        Me.tbDRCR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbDRCR.CustomButton.UseSelectable = True
        Me.tbDRCR.CustomButton.Visible = False
        Me.tbDRCR.Enabled = False
        Me.tbDRCR.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbDRCR.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.tbDRCR.Lines = New String(-1) {}
        Me.tbDRCR.Location = New System.Drawing.Point(10, 42)
        Me.tbDRCR.MaxLength = 32767
        Me.tbDRCR.Name = "tbDRCR"
        Me.tbDRCR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbDRCR.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbDRCR.SelectedText = ""
        Me.tbDRCR.SelectionLength = 0
        Me.tbDRCR.SelectionStart = 0
        Me.tbDRCR.Size = New System.Drawing.Size(47, 30)
        Me.tbDRCR.TabIndex = 71
        Me.tbDRCR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbDRCR.UseSelectable = True
        Me.tbDRCR.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbDRCR.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(10, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(194, 30)
        Me.Button2.TabIndex = 70
        Me.Button2.Text = "Current Balance"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MetroLink2
        '
        Me.MetroLink2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroLink2.Image = CType(resources.GetObject("MetroLink2.Image"), System.Drawing.Image)
        Me.MetroLink2.ImageSize = 30
        Me.MetroLink2.Location = New System.Drawing.Point(210, 3)
        Me.MetroLink2.Name = "MetroLink2"
        Me.MetroLink2.Size = New System.Drawing.Size(37, 34)
        Me.MetroLink2.TabIndex = 41
        Me.MetroLink2.UseSelectable = True
        '
        'TbVoucherTransTableAdapter
        '
        Me.TbVoucherTransTableAdapter.ClearBeforeFill = True
        '
        'pnlJournal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlAccDetails)
        Me.Controls.Add(Me.pnlAgainstRef)
        Me.Controls.Add(Me.dgJournal)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "pnlJournal"
        Me.Size = New System.Drawing.Size(1200, 643)
        CType(Me.dgJournal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmAccounts.ResumeLayout(False)
        Me.pnlBankDetails.ResumeLayout(False)
        Me.pnlBankDetails.PerformLayout()
        CType(Me.ACCDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.TbVouchersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCostCenterListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.pnlAgainstRef.ResumeLayout(False)
        Me.pnlAgainstRef.PerformLayout()
        CType(Me.dgItemSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAccDetails.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgJournal As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroTextBox4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnCloseBank As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroDateTime2 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents pnlBankDetails As System.Windows.Forms.Panel
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroComboBox3 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroComboBox2 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnBankDetails As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tbBalance As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnAddAccount As MetroFramework.Controls.MetroButton
    Friend WithEvents tbAmount As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cbDRCR As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbAccount As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dtDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents ACCDBDataSet As Acc_System.ACCDBDataSet
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnRollUp As MetroFramework.Controls.MetroLink
    Friend WithEvents btnRollDown As MetroFramework.Controls.MetroLink
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents tbTotalCR As MetroFramework.Controls.MetroTextBox
    Friend WithEvents pnlAgainstRef As System.Windows.Forms.Panel
    Friend WithEvents btnAccept As MetroFramework.Controls.MetroButton
    Friend WithEvents dgItemSelect As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroTextBox7 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox6 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TbAccountTransTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbAccountTransTableAdapter
    Friend WithEvents TbAccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbAccountsTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbAccountsTableAdapter
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents cmAccounts As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents cmsAddRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsRemoveAcc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TbReferenceTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbReferenceTableAdapter
    Friend WithEvents MetroTextBox8 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbTotalDR As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox10 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnSaveInv As MetroFramework.Controls.MetroLink
    Friend WithEvents lblInvNo As System.Windows.Forms.Label
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colParticula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDebit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCredit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbCostCenter As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbVoucherType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents tbReference As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbNarration As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TbCostCenterListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbCostCenterListTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbCostCenterListTableAdapter
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TbVouchersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbVouchersTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbVouchersTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tbAccSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents chkPrintPreview As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkPrint As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents lnkDetails As MetroFramework.Controls.MetroLink
    Friend WithEvents pnlAccDetails As System.Windows.Forms.Panel
    Friend WithEvents tbAccBalance As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbDRCR As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MetroLink2 As MetroFramework.Controls.MetroLink
    Friend WithEvents TbVoucherTransTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbVoucherTransTableAdapter

End Class
