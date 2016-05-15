<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlPurchase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pnlPurchase))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cbAccounts = New MetroFramework.Controls.MetroComboBox()
        Me.dgInvItem = New MetroFramework.Controls.MetroGrid()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmInv = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.cmsEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSaveInv = New MetroFramework.Controls.MetroLink()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.tbDiscAmtDefault = New MetroFramework.Controls.MetroTextBox()
        Me.lblDefCur2 = New MetroFramework.Controls.MetroLabel()
        Me.lblDefCur1 = New MetroFramework.Controls.MetroLabel()
        Me.lblNet = New MetroFramework.Controls.MetroLabel()
        Me.lblCurrTotal = New MetroFramework.Controls.MetroLabel()
        Me.tbTotalPriceDefault = New MetroFramework.Controls.MetroTextBox()
        Me.chkPrintPreview = New MetroFramework.Controls.MetroCheckBox()
        Me.chkPrint = New MetroFramework.Controls.MetroCheckBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnRollDown = New MetroFramework.Controls.MetroLink()
        Me.tbLedgerRate = New MetroFramework.Controls.MetroTextBox()
        Me.tbNet = New MetroFramework.Controls.MetroTextBox()
        Me.tbAccounts = New MetroFramework.Controls.MetroTextBox()
        Me.btnAddAccount = New MetroFramework.Controls.MetroButton()
        Me.tbNarration = New MetroFramework.Controls.MetroTextBox()
        Me.dgLedger = New MetroFramework.Controls.MetroGrid()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmLedger = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.cmLedgerRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbNetDefault = New MetroFramework.Controls.MetroTextBox()
        Me.tbDiscAmt = New MetroFramework.Controls.MetroTextBox()
        Me.tbTotalPrice = New MetroFramework.Controls.MetroTextBox()
        Me.lblInvNo = New System.Windows.Forms.Label()
        Me.TbAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACCDBDataSet = New Acc_System.ACCDBDataSet()
        Me.btnCancelEdit = New MetroFramework.Controls.MetroLink()
        Me.pnlEditMode = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnRollUp = New MetroFramework.Controls.MetroLink()
        Me.tbSupplier = New MetroFramework.Controls.MetroTextBox()
        Me.btnShowSelection = New MetroFramework.Controls.MetroLink()
        Me.tbReference = New MetroFramework.Controls.MetroTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.lnkDetails = New MetroFramework.Controls.MetroLink()
        Me.cbCurrency = New MetroFramework.Controls.MetroComboBox()
        Me.TbCurrencyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button9 = New System.Windows.Forms.Button()
        Me.cbAccRevenue = New MetroFramework.Controls.MetroComboBox()
        Me.tbItemRate = New MetroFramework.Controls.MetroTextBox()
        Me.dtInvDate = New MetroFramework.Controls.MetroDateTime()
        Me.cbSupplier = New MetroFramework.Controls.MetroComboBox()
        Me.cbCostCenter = New MetroFramework.Controls.MetroComboBox()
        Me.TbCostCenterListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbVoucherType = New MetroFramework.Controls.MetroComboBox()
        Me.TbVouchersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbVouchersTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbVouchersTableAdapter()
        Me.TbCostCenterListTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbCostCenterListTableAdapter()
        Me.TbAccountsTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbAccountsTableAdapter()
        Me.pnlItemsInv = New System.Windows.Forms.Panel()
        Me.tbCostSelect = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbQuantitySelect = New MetroFramework.Controls.MetroTextBox()
        Me.btnAccept = New MetroFramework.Controls.MetroButton()
        Me.dgItemSelect = New MetroFramework.Controls.MetroGrid()
        Me.tbItemSearch = New MetroFramework.Controls.MetroTextBox()
        Me.btnHideSelection = New MetroFramework.Controls.MetroLink()
        Me.TbCurrencyTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbCurrencyTableAdapter()
        Me.pnlAccDetails = New System.Windows.Forms.Panel()
        Me.tbAccBalance = New MetroFramework.Controls.MetroTextBox()
        Me.tbDRCR = New MetroFramework.Controls.MetroTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MetroLink2 = New MetroFramework.Controls.MetroLink()
        Me.TbAccountTransTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbAccountTransTableAdapter()
        Me.TbVoucherTransTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbVoucherTransTableAdapter()
        Me.TbItemTransTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbItemTransTableAdapter()
        CType(Me.dgInvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmInv.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgLedger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmLedger.SuspendLayout()
        CType(Me.TbAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACCDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEditMode.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.TbCurrencyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCostCenterListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbVouchersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlItemsInv.SuspendLayout()
        CType(Me.dgItemSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAccDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbAccounts
        '
        Me.cbAccounts.FormattingEnabled = True
        Me.cbAccounts.ItemHeight = 23
        Me.cbAccounts.Items.AddRange(New Object() {"Cash Account", "Credit Account"})
        Me.cbAccounts.Location = New System.Drawing.Point(142, 10)
        Me.cbAccounts.Name = "cbAccounts"
        Me.cbAccounts.Size = New System.Drawing.Size(309, 29)
        Me.cbAccounts.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbAccounts.TabIndex = 41
        Me.cbAccounts.UseSelectable = True
        '
        'dgInvItem
        '
        Me.dgInvItem.AllowUserToAddRows = False
        Me.dgInvItem.AllowUserToDeleteRows = False
        Me.dgInvItem.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgInvItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgInvItem.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgInvItem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgInvItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgInvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgInvItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgInvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgInvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column11})
        Me.dgInvItem.ContextMenuStrip = Me.cmInv
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgInvItem.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgInvItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgInvItem.EnableHeadersVisualStyles = False
        Me.dgInvItem.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgInvItem.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgInvItem.Location = New System.Drawing.Point(27, 80)
        Me.dgInvItem.MultiSelect = False
        Me.dgInvItem.Name = "dgInvItem"
        Me.dgInvItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgInvItem.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgInvItem.RowHeadersVisible = False
        Me.dgInvItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgInvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgInvItem.Size = New System.Drawing.Size(1173, 367)
        Me.dgInvItem.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgInvItem.TabIndex = 14
        '
        'Column7
        '
        Me.Column7.HeaderText = "No"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 50
        '
        'Column1
        '
        Me.Column1.HeaderText = "Code"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 180
        '
        'Column2
        '
        Me.Column2.HeaderText = "Description"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 450
        '
        'Column3
        '
        Me.Column3.HeaderText = "Qty"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Unit"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 50
        '
        'Column5
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.HeaderText = "Cost"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column6.HeaderText = "Total"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 170
        '
        'Column11
        '
        Me.Column11.HeaderText = "Cu"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 40
        '
        'cmInv
        '
        Me.cmInv.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsEdit, Me.cmsRemove})
        Me.cmInv.Name = "cmInv"
        Me.cmInv.Size = New System.Drawing.Size(118, 48)
        '
        'cmsEdit
        '
        Me.cmsEdit.Name = "cmsEdit"
        Me.cmsEdit.Size = New System.Drawing.Size(117, 22)
        Me.cmsEdit.Text = "Edit"
        '
        'cmsRemove
        '
        Me.cmsRemove.Name = "cmsRemove"
        Me.cmsRemove.Size = New System.Drawing.Size(117, 22)
        Me.cmsRemove.Text = "Remove"
        '
        'btnSaveInv
        '
        Me.btnSaveInv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveInv.Image = CType(resources.GetObject("btnSaveInv.Image"), System.Drawing.Image)
        Me.btnSaveInv.ImageSize = 25
        Me.btnSaveInv.Location = New System.Drawing.Point(1154, 159)
        Me.btnSaveInv.Name = "btnSaveInv"
        Me.btnSaveInv.NoFocusImage = CType(resources.GetObject("btnSaveInv.NoFocusImage"), System.Drawing.Image)
        Me.btnSaveInv.Size = New System.Drawing.Size(43, 30)
        Me.btnSaveInv.TabIndex = 33
        Me.btnSaveInv.UseSelectable = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.MetroLabel1)
        Me.Panel2.Controls.Add(Me.tbDiscAmtDefault)
        Me.Panel2.Controls.Add(Me.lblDefCur2)
        Me.Panel2.Controls.Add(Me.lblDefCur1)
        Me.Panel2.Controls.Add(Me.lblNet)
        Me.Panel2.Controls.Add(Me.lblCurrTotal)
        Me.Panel2.Controls.Add(Me.tbTotalPriceDefault)
        Me.Panel2.Controls.Add(Me.chkPrintPreview)
        Me.Panel2.Controls.Add(Me.chkPrint)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.btnRollDown)
        Me.Panel2.Controls.Add(Me.tbLedgerRate)
        Me.Panel2.Controls.Add(Me.tbNet)
        Me.Panel2.Controls.Add(Me.tbAccounts)
        Me.Panel2.Controls.Add(Me.btnAddAccount)
        Me.Panel2.Controls.Add(Me.tbNarration)
        Me.Panel2.Controls.Add(Me.dgLedger)
        Me.Panel2.Controls.Add(Me.cbAccounts)
        Me.Panel2.Controls.Add(Me.btnSaveInv)
        Me.Panel2.Controls.Add(Me.tbNetDefault)
        Me.Panel2.Controls.Add(Me.tbDiscAmt)
        Me.Panel2.Controls.Add(Me.tbTotalPrice)
        Me.Panel2.Controls.Add(Me.lblInvNo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 447)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1200, 196)
        Me.Panel2.TabIndex = 16
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(1161, 46)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(28, 19)
        Me.MetroLabel1.TabIndex = 83
        Me.MetroLabel1.Text = "QR"
        '
        'tbDiscAmtDefault
        '
        Me.tbDiscAmtDefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tbDiscAmtDefault.CustomButton.Image = Nothing
        Me.tbDiscAmtDefault.CustomButton.Location = New System.Drawing.Point(124, 2)
        Me.tbDiscAmtDefault.CustomButton.Name = ""
        Me.tbDiscAmtDefault.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.tbDiscAmtDefault.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbDiscAmtDefault.CustomButton.TabIndex = 1
        Me.tbDiscAmtDefault.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbDiscAmtDefault.CustomButton.UseSelectable = True
        Me.tbDiscAmtDefault.CustomButton.Visible = False
        Me.tbDiscAmtDefault.Enabled = False
        Me.tbDiscAmtDefault.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbDiscAmtDefault.Lines = New String() {"0"}
        Me.tbDiscAmtDefault.Location = New System.Drawing.Point(1007, 43)
        Me.tbDiscAmtDefault.MaxLength = 32767
        Me.tbDiscAmtDefault.Name = "tbDiscAmtDefault"
        Me.tbDiscAmtDefault.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbDiscAmtDefault.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbDiscAmtDefault.SelectedText = ""
        Me.tbDiscAmtDefault.SelectionLength = 0
        Me.tbDiscAmtDefault.SelectionStart = 0
        Me.tbDiscAmtDefault.Size = New System.Drawing.Size(152, 30)
        Me.tbDiscAmtDefault.TabIndex = 82
        Me.tbDiscAmtDefault.Text = "0"
        Me.tbDiscAmtDefault.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbDiscAmtDefault.UseSelectable = True
        Me.tbDiscAmtDefault.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbDiscAmtDefault.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblDefCur2
        '
        Me.lblDefCur2.AutoSize = True
        Me.lblDefCur2.Location = New System.Drawing.Point(1161, 84)
        Me.lblDefCur2.Name = "lblDefCur2"
        Me.lblDefCur2.Size = New System.Drawing.Size(28, 19)
        Me.lblDefCur2.TabIndex = 81
        Me.lblDefCur2.Text = "QR"
        '
        'lblDefCur1
        '
        Me.lblDefCur1.AutoSize = True
        Me.lblDefCur1.Location = New System.Drawing.Point(1161, 14)
        Me.lblDefCur1.Name = "lblDefCur1"
        Me.lblDefCur1.Size = New System.Drawing.Size(28, 19)
        Me.lblDefCur1.TabIndex = 80
        Me.lblDefCur1.Text = "QR"
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.Location = New System.Drawing.Point(962, 84)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(28, 19)
        Me.lblNet.TabIndex = 79
        Me.lblNet.Text = "QR"
        '
        'lblCurrTotal
        '
        Me.lblCurrTotal.AutoSize = True
        Me.lblCurrTotal.Location = New System.Drawing.Point(962, 14)
        Me.lblCurrTotal.Name = "lblCurrTotal"
        Me.lblCurrTotal.Size = New System.Drawing.Size(28, 19)
        Me.lblCurrTotal.TabIndex = 78
        Me.lblCurrTotal.Text = "QR"
        '
        'tbTotalPriceDefault
        '
        Me.tbTotalPriceDefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tbTotalPriceDefault.CustomButton.Image = Nothing
        Me.tbTotalPriceDefault.CustomButton.Location = New System.Drawing.Point(124, 2)
        Me.tbTotalPriceDefault.CustomButton.Name = ""
        Me.tbTotalPriceDefault.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.tbTotalPriceDefault.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbTotalPriceDefault.CustomButton.TabIndex = 1
        Me.tbTotalPriceDefault.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbTotalPriceDefault.CustomButton.UseSelectable = True
        Me.tbTotalPriceDefault.CustomButton.Visible = False
        Me.tbTotalPriceDefault.Enabled = False
        Me.tbTotalPriceDefault.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbTotalPriceDefault.Lines = New String() {"0"}
        Me.tbTotalPriceDefault.Location = New System.Drawing.Point(1007, 9)
        Me.tbTotalPriceDefault.MaxLength = 32767
        Me.tbTotalPriceDefault.Name = "tbTotalPriceDefault"
        Me.tbTotalPriceDefault.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTotalPriceDefault.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbTotalPriceDefault.SelectedText = ""
        Me.tbTotalPriceDefault.SelectionLength = 0
        Me.tbTotalPriceDefault.SelectionStart = 0
        Me.tbTotalPriceDefault.Size = New System.Drawing.Size(152, 30)
        Me.tbTotalPriceDefault.TabIndex = 76
        Me.tbTotalPriceDefault.Text = "0"
        Me.tbTotalPriceDefault.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbTotalPriceDefault.UseSelectable = True
        Me.tbTotalPriceDefault.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbTotalPriceDefault.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'chkPrintPreview
        '
        Me.chkPrintPreview.AutoSize = True
        Me.chkPrintPreview.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkPrintPreview.Location = New System.Drawing.Point(1009, 169)
        Me.chkPrintPreview.Name = "chkPrintPreview"
        Me.chkPrintPreview.Size = New System.Drawing.Size(142, 19)
        Me.chkPrintPreview.TabIndex = 75
        Me.chkPrintPreview.Text = "Show Print Preview"
        Me.chkPrintPreview.UseSelectable = True
        '
        'chkPrint
        '
        Me.chkPrint.AutoSize = True
        Me.chkPrint.Checked = True
        Me.chkPrint.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrint.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkPrint.Location = New System.Drawing.Point(1009, 146)
        Me.chkPrint.Name = "chkPrint"
        Me.chkPrint.Size = New System.Drawing.Size(117, 19)
        Me.chkPrint.TabIndex = 74
        Me.chkPrint.Text = "Print after save"
        Me.chkPrint.UseSelectable = True
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(563, 10)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(72, 30)
        Me.Button6.TabIndex = 71
        Me.Button6.Text = "Forex"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(707, 43)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(103, 30)
        Me.Button5.TabIndex = 70
        Me.Button5.Text = "Discount"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(707, 78)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 30)
        Me.Button4.TabIndex = 69
        Me.Button4.Text = "Net"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(707, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 30)
        Me.Button3.TabIndex = 66
        Me.Button3.Text = "Total Amount"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
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
        Me.btnRollDown.TabIndex = 59
        Me.btnRollDown.UseSelectable = True
        '
        'tbLedgerRate
        '
        '
        '
        '
        Me.tbLedgerRate.CustomButton.Image = Nothing
        Me.tbLedgerRate.CustomButton.Location = New System.Drawing.Point(32, 1)
        Me.tbLedgerRate.CustomButton.Name = ""
        Me.tbLedgerRate.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbLedgerRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbLedgerRate.CustomButton.TabIndex = 1
        Me.tbLedgerRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbLedgerRate.CustomButton.UseSelectable = True
        Me.tbLedgerRate.CustomButton.Visible = False
        Me.tbLedgerRate.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbLedgerRate.Lines = New String() {"1"}
        Me.tbLedgerRate.Location = New System.Drawing.Point(641, 11)
        Me.tbLedgerRate.MaxLength = 32767
        Me.tbLedgerRate.Name = "tbLedgerRate"
        Me.tbLedgerRate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbLedgerRate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbLedgerRate.SelectedText = ""
        Me.tbLedgerRate.SelectionLength = 0
        Me.tbLedgerRate.SelectionStart = 0
        Me.tbLedgerRate.Size = New System.Drawing.Size(60, 29)
        Me.tbLedgerRate.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbLedgerRate.TabIndex = 58
        Me.tbLedgerRate.Text = "1"
        Me.tbLedgerRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbLedgerRate.UseSelectable = True
        Me.tbLedgerRate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbLedgerRate.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tbNet
        '
        Me.tbNet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tbNet.CustomButton.Image = Nothing
        Me.tbNet.CustomButton.Location = New System.Drawing.Point(122, 2)
        Me.tbNet.CustomButton.Name = ""
        Me.tbNet.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.tbNet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbNet.CustomButton.TabIndex = 1
        Me.tbNet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbNet.CustomButton.UseSelectable = True
        Me.tbNet.CustomButton.Visible = False
        Me.tbNet.Enabled = False
        Me.tbNet.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbNet.Lines = New String() {"0"}
        Me.tbNet.Location = New System.Drawing.Point(812, 78)
        Me.tbNet.MaxLength = 32767
        Me.tbNet.Name = "tbNet"
        Me.tbNet.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNet.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbNet.SelectedText = ""
        Me.tbNet.SelectionLength = 0
        Me.tbNet.SelectionStart = 0
        Me.tbNet.Size = New System.Drawing.Size(150, 30)
        Me.tbNet.TabIndex = 57
        Me.tbNet.Text = "0"
        Me.tbNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbNet.UseSelectable = True
        Me.tbNet.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbNet.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tbAccounts
        '
        '
        '
        '
        Me.tbAccounts.CustomButton.Image = Nothing
        Me.tbAccounts.CustomButton.Location = New System.Drawing.Point(81, 1)
        Me.tbAccounts.CustomButton.Name = ""
        Me.tbAccounts.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbAccounts.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbAccounts.CustomButton.TabIndex = 1
        Me.tbAccounts.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbAccounts.CustomButton.UseSelectable = True
        Me.tbAccounts.CustomButton.Visible = False
        Me.tbAccounts.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbAccounts.Lines = New String(-1) {}
        Me.tbAccounts.Location = New System.Drawing.Point(27, 9)
        Me.tbAccounts.MaxLength = 32767
        Me.tbAccounts.Name = "tbAccounts"
        Me.tbAccounts.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbAccounts.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbAccounts.SelectedText = ""
        Me.tbAccounts.SelectionLength = 0
        Me.tbAccounts.SelectionStart = 0
        Me.tbAccounts.Size = New System.Drawing.Size(109, 29)
        Me.tbAccounts.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbAccounts.TabIndex = 55
        Me.tbAccounts.UseSelectable = True
        Me.tbAccounts.WaterMark = "Accounts"
        Me.tbAccounts.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbAccounts.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnAddAccount
        '
        Me.btnAddAccount.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnAddAccount.Location = New System.Drawing.Point(457, 10)
        Me.btnAddAccount.Name = "btnAddAccount"
        Me.btnAddAccount.Size = New System.Drawing.Size(100, 29)
        Me.btnAddAccount.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAddAccount.TabIndex = 54
        Me.btnAddAccount.Text = "Add"
        Me.btnAddAccount.UseCustomBackColor = True
        Me.btnAddAccount.UseSelectable = True
        Me.btnAddAccount.UseStyleColors = True
        '
        'tbNarration
        '
        '
        '
        '
        Me.tbNarration.CustomButton.Image = Nothing
        Me.tbNarration.CustomButton.Location = New System.Drawing.Point(646, 1)
        Me.tbNarration.CustomButton.Name = ""
        Me.tbNarration.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbNarration.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbNarration.CustomButton.TabIndex = 1
        Me.tbNarration.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbNarration.CustomButton.UseSelectable = True
        Me.tbNarration.CustomButton.Visible = False
        Me.tbNarration.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbNarration.Lines = New String(-1) {}
        Me.tbNarration.Location = New System.Drawing.Point(27, 159)
        Me.tbNarration.MaxLength = 32767
        Me.tbNarration.Name = "tbNarration"
        Me.tbNarration.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNarration.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbNarration.SelectedText = ""
        Me.tbNarration.SelectionLength = 0
        Me.tbNarration.SelectionStart = 0
        Me.tbNarration.Size = New System.Drawing.Size(674, 29)
        Me.tbNarration.TabIndex = 38
        Me.tbNarration.UseSelectable = True
        Me.tbNarration.WaterMark = "Narration"
        Me.tbNarration.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbNarration.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dgLedger
        '
        Me.dgLedger.AllowUserToAddRows = False
        Me.dgLedger.AllowUserToDeleteRows = False
        Me.dgLedger.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgLedger.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgLedger.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgLedger.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgLedger.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgLedger.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLedger.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLedger.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column9, Me.Column10})
        Me.dgLedger.ContextMenuStrip = Me.cmLedger
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgLedger.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgLedger.EnableHeadersVisualStyles = False
        Me.dgLedger.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgLedger.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgLedger.Location = New System.Drawing.Point(27, 46)
        Me.dgLedger.MultiSelect = False
        Me.dgLedger.Name = "dgLedger"
        Me.dgLedger.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLedger.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgLedger.RowHeadersVisible = False
        Me.dgLedger.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgLedger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgLedger.Size = New System.Drawing.Size(674, 109)
        Me.dgLedger.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgLedger.TabIndex = 52
        '
        'Column8
        '
        Me.Column8.HeaderText = "Account Name"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 300
        '
        'Column9
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column9.HeaderText = "Value"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 170
        '
        'Column10
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle10
        Me.Column10.HeaderText = "Value in QR"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 170
        '
        'cmLedger
        '
        Me.cmLedger.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmLedgerRemove})
        Me.cmLedger.Name = "cmInv"
        Me.cmLedger.Size = New System.Drawing.Size(118, 26)
        '
        'cmLedgerRemove
        '
        Me.cmLedgerRemove.Name = "cmLedgerRemove"
        Me.cmLedgerRemove.Size = New System.Drawing.Size(117, 22)
        Me.cmLedgerRemove.Text = "Remove"
        '
        'tbNetDefault
        '
        Me.tbNetDefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tbNetDefault.CustomButton.Image = Nothing
        Me.tbNetDefault.CustomButton.Location = New System.Drawing.Point(124, 2)
        Me.tbNetDefault.CustomButton.Name = ""
        Me.tbNetDefault.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.tbNetDefault.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbNetDefault.CustomButton.TabIndex = 1
        Me.tbNetDefault.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbNetDefault.CustomButton.UseSelectable = True
        Me.tbNetDefault.CustomButton.Visible = False
        Me.tbNetDefault.Enabled = False
        Me.tbNetDefault.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbNetDefault.Lines = New String() {"0"}
        Me.tbNetDefault.Location = New System.Drawing.Point(1007, 78)
        Me.tbNetDefault.MaxLength = 32767
        Me.tbNetDefault.Name = "tbNetDefault"
        Me.tbNetDefault.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNetDefault.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbNetDefault.SelectedText = ""
        Me.tbNetDefault.SelectionLength = 0
        Me.tbNetDefault.SelectionStart = 0
        Me.tbNetDefault.Size = New System.Drawing.Size(152, 30)
        Me.tbNetDefault.TabIndex = 9
        Me.tbNetDefault.Text = "0"
        Me.tbNetDefault.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbNetDefault.UseSelectable = True
        Me.tbNetDefault.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbNetDefault.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tbDiscAmt
        '
        Me.tbDiscAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tbDiscAmt.CustomButton.Image = Nothing
        Me.tbDiscAmt.CustomButton.Location = New System.Drawing.Point(122, 2)
        Me.tbDiscAmt.CustomButton.Name = ""
        Me.tbDiscAmt.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.tbDiscAmt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbDiscAmt.CustomButton.TabIndex = 1
        Me.tbDiscAmt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbDiscAmt.CustomButton.UseSelectable = True
        Me.tbDiscAmt.CustomButton.Visible = False
        Me.tbDiscAmt.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbDiscAmt.Lines = New String() {"0"}
        Me.tbDiscAmt.Location = New System.Drawing.Point(812, 43)
        Me.tbDiscAmt.MaxLength = 32767
        Me.tbDiscAmt.Name = "tbDiscAmt"
        Me.tbDiscAmt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbDiscAmt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbDiscAmt.SelectedText = ""
        Me.tbDiscAmt.SelectionLength = 0
        Me.tbDiscAmt.SelectionStart = 0
        Me.tbDiscAmt.Size = New System.Drawing.Size(150, 30)
        Me.tbDiscAmt.TabIndex = 8
        Me.tbDiscAmt.Text = "0"
        Me.tbDiscAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbDiscAmt.UseSelectable = True
        Me.tbDiscAmt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbDiscAmt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tbTotalPrice
        '
        Me.tbTotalPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tbTotalPrice.CustomButton.Image = Nothing
        Me.tbTotalPrice.CustomButton.Location = New System.Drawing.Point(122, 2)
        Me.tbTotalPrice.CustomButton.Name = ""
        Me.tbTotalPrice.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.tbTotalPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbTotalPrice.CustomButton.TabIndex = 1
        Me.tbTotalPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbTotalPrice.CustomButton.UseSelectable = True
        Me.tbTotalPrice.CustomButton.Visible = False
        Me.tbTotalPrice.Enabled = False
        Me.tbTotalPrice.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbTotalPrice.Lines = New String() {"0"}
        Me.tbTotalPrice.Location = New System.Drawing.Point(812, 9)
        Me.tbTotalPrice.MaxLength = 32767
        Me.tbTotalPrice.Name = "tbTotalPrice"
        Me.tbTotalPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTotalPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbTotalPrice.SelectedText = ""
        Me.tbTotalPrice.SelectionLength = 0
        Me.tbTotalPrice.SelectionStart = 0
        Me.tbTotalPrice.Size = New System.Drawing.Size(150, 30)
        Me.tbTotalPrice.TabIndex = 6
        Me.tbTotalPrice.Text = "0"
        Me.tbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbTotalPrice.UseSelectable = True
        Me.tbTotalPrice.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbTotalPrice.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblInvNo
        '
        Me.lblInvNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblInvNo.AutoSize = True
        Me.lblInvNo.BackColor = System.Drawing.Color.Transparent
        Me.lblInvNo.Font = New System.Drawing.Font("Segoe UI Light", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvNo.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblInvNo.Location = New System.Drawing.Point(707, 124)
        Me.lblInvNo.Name = "lblInvNo"
        Me.lblInvNo.Size = New System.Drawing.Size(179, 65)
        Me.lblInvNo.TabIndex = 40
        Me.lblInvNo.Text = "CR-001"
        '
        'TbAccountsBindingSource
        '
        Me.TbAccountsBindingSource.DataMember = "tbAccounts"
        Me.TbAccountsBindingSource.DataSource = Me.ACCDBDataSet
        '
        'ACCDBDataSet
        '
        Me.ACCDBDataSet.DataSetName = "ACCDBDataSet"
        Me.ACCDBDataSet.EnforceConstraints = False
        Me.ACCDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnCancelEdit
        '
        Me.btnCancelEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelEdit.Image = CType(resources.GetObject("btnCancelEdit.Image"), System.Drawing.Image)
        Me.btnCancelEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelEdit.ImageSize = 30
        Me.btnCancelEdit.Location = New System.Drawing.Point(30, 7)
        Me.btnCancelEdit.Name = "btnCancelEdit"
        Me.btnCancelEdit.Size = New System.Drawing.Size(135, 34)
        Me.btnCancelEdit.TabIndex = 37
        Me.btnCancelEdit.Text = "Cancel Edit Mode"
        Me.btnCancelEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelEdit.UseSelectable = True
        '
        'pnlEditMode
        '
        Me.pnlEditMode.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlEditMode.Controls.Add(Me.btnCancelEdit)
        Me.pnlEditMode.Location = New System.Drawing.Point(33, 224)
        Me.pnlEditMode.Name = "pnlEditMode"
        Me.pnlEditMode.Size = New System.Drawing.Size(174, 47)
        Me.pnlEditMode.TabIndex = 19
        Me.pnlEditMode.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.btnRollUp)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 80)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(27, 367)
        Me.Panel3.TabIndex = 20
        '
        'btnRollUp
        '
        Me.btnRollUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRollUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRollUp.Image = CType(resources.GetObject("btnRollUp.Image"), System.Drawing.Image)
        Me.btnRollUp.ImageSize = 20
        Me.btnRollUp.Location = New System.Drawing.Point(3, 341)
        Me.btnRollUp.Name = "btnRollUp"
        Me.btnRollUp.NoFocusImage = CType(resources.GetObject("btnRollUp.NoFocusImage"), System.Drawing.Image)
        Me.btnRollUp.Size = New System.Drawing.Size(21, 23)
        Me.btnRollUp.TabIndex = 60
        Me.btnRollUp.UseSelectable = True
        Me.btnRollUp.Visible = False
        '
        'tbSupplier
        '
        '
        '
        '
        Me.tbSupplier.CustomButton.Image = Nothing
        Me.tbSupplier.CustomButton.Location = New System.Drawing.Point(156, 1)
        Me.tbSupplier.CustomButton.Name = ""
        Me.tbSupplier.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbSupplier.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbSupplier.CustomButton.TabIndex = 1
        Me.tbSupplier.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbSupplier.CustomButton.UseSelectable = True
        Me.tbSupplier.CustomButton.Visible = False
        Me.tbSupplier.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbSupplier.Lines = New String(-1) {}
        Me.tbSupplier.Location = New System.Drawing.Point(344, 7)
        Me.tbSupplier.MaxLength = 32767
        Me.tbSupplier.Name = "tbSupplier"
        Me.tbSupplier.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSupplier.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbSupplier.SelectedText = ""
        Me.tbSupplier.SelectionLength = 0
        Me.tbSupplier.SelectionStart = 0
        Me.tbSupplier.Size = New System.Drawing.Size(184, 29)
        Me.tbSupplier.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbSupplier.TabIndex = 42
        Me.tbSupplier.UseSelectable = True
        Me.tbSupplier.WaterMark = "Supplier"
        Me.tbSupplier.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbSupplier.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnShowSelection
        '
        Me.btnShowSelection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowSelection.Image = CType(resources.GetObject("btnShowSelection.Image"), System.Drawing.Image)
        Me.btnShowSelection.ImageSize = 30
        Me.btnShowSelection.Location = New System.Drawing.Point(1154, 39)
        Me.btnShowSelection.Name = "btnShowSelection"
        Me.btnShowSelection.NoFocusImage = CType(resources.GetObject("btnShowSelection.NoFocusImage"), System.Drawing.Image)
        Me.btnShowSelection.Size = New System.Drawing.Size(37, 34)
        Me.btnShowSelection.TabIndex = 16
        Me.btnShowSelection.UseSelectable = True
        '
        'tbReference
        '
        '
        '
        '
        Me.tbReference.CustomButton.Image = Nothing
        Me.tbReference.CustomButton.Location = New System.Drawing.Point(156, 1)
        Me.tbReference.CustomButton.Name = ""
        Me.tbReference.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbReference.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbReference.CustomButton.TabIndex = 1
        Me.tbReference.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbReference.CustomButton.UseSelectable = True
        Me.tbReference.CustomButton.Visible = False
        Me.tbReference.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbReference.Lines = New String(-1) {}
        Me.tbReference.Location = New System.Drawing.Point(534, 42)
        Me.tbReference.MaxLength = 32767
        Me.tbReference.Name = "tbReference"
        Me.tbReference.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbReference.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbReference.SelectedText = ""
        Me.tbReference.SelectionLength = 0
        Me.tbReference.SelectionStart = 0
        Me.tbReference.Size = New System.Drawing.Size(184, 29)
        Me.tbReference.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbReference.TabIndex = 4
        Me.tbReference.UseSelectable = True
        Me.tbReference.WaterMark = "Reference"
        Me.tbReference.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbReference.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.lnkDetails)
        Me.Panel1.Controls.Add(Me.cbCurrency)
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.cbAccRevenue)
        Me.Panel1.Controls.Add(Me.tbItemRate)
        Me.Panel1.Controls.Add(Me.tbSupplier)
        Me.Panel1.Controls.Add(Me.btnShowSelection)
        Me.Panel1.Controls.Add(Me.tbReference)
        Me.Panel1.Controls.Add(Me.dtInvDate)
        Me.Panel1.Controls.Add(Me.cbSupplier)
        Me.Panel1.Controls.Add(Me.cbCostCenter)
        Me.Panel1.Controls.Add(Me.cbVoucherType)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 80)
        Me.Panel1.TabIndex = 15
        '
        'Button8
        '
        Me.Button8.Enabled = False
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(925, 43)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(79, 28)
        Me.Button8.TabIndex = 77
        Me.Button8.Text = "Forex"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.UseVisualStyleBackColor = True
        '
        'lnkDetails
        '
        Me.lnkDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkDetails.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.lnkDetails.ImageSize = 30
        Me.lnkDetails.Location = New System.Drawing.Point(1114, 45)
        Me.lnkDetails.Name = "lnkDetails"
        Me.lnkDetails.Size = New System.Drawing.Size(37, 29)
        Me.lnkDetails.TabIndex = 76
        Me.lnkDetails.Text = ". . ."
        Me.lnkDetails.UseSelectable = True
        '
        'cbCurrency
        '
        Me.cbCurrency.DataSource = Me.TbCurrencyBindingSource
        Me.cbCurrency.DisplayMember = "Currency_Symbol"
        Me.cbCurrency.FormattingEnabled = True
        Me.cbCurrency.ItemHeight = 23
        Me.cbCurrency.Location = New System.Drawing.Point(812, 42)
        Me.cbCurrency.Name = "cbCurrency"
        Me.cbCurrency.Size = New System.Drawing.Size(87, 29)
        Me.cbCurrency.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbCurrency.TabIndex = 75
        Me.cbCurrency.UseSelectable = True
        '
        'TbCurrencyBindingSource
        '
        Me.TbCurrencyBindingSource.DataMember = "tbCurrency"
        Me.TbCurrencyBindingSource.DataSource = Me.ACCDBDataSet
        '
        'Button9
        '
        Me.Button9.Enabled = False
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(731, 42)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(79, 29)
        Me.Button9.TabIndex = 74
        Me.Button9.Text = "Currency"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.UseVisualStyleBackColor = True
        '
        'cbAccRevenue
        '
        Me.cbAccRevenue.FormattingEnabled = True
        Me.cbAccRevenue.ItemHeight = 23
        Me.cbAccRevenue.Location = New System.Drawing.Point(27, 42)
        Me.cbAccRevenue.Name = "cbAccRevenue"
        Me.cbAccRevenue.Size = New System.Drawing.Size(311, 29)
        Me.cbAccRevenue.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbAccRevenue.TabIndex = 42
        Me.cbAccRevenue.UseSelectable = True
        '
        'tbItemRate
        '
        '
        '
        '
        Me.tbItemRate.CustomButton.Image = Nothing
        Me.tbItemRate.CustomButton.Location = New System.Drawing.Point(72, 1)
        Me.tbItemRate.CustomButton.Name = ""
        Me.tbItemRate.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbItemRate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbItemRate.CustomButton.TabIndex = 1
        Me.tbItemRate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbItemRate.CustomButton.UseSelectable = True
        Me.tbItemRate.CustomButton.Visible = False
        Me.tbItemRate.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbItemRate.Lines = New String() {"1"}
        Me.tbItemRate.Location = New System.Drawing.Point(1007, 43)
        Me.tbItemRate.MaxLength = 32767
        Me.tbItemRate.Name = "tbItemRate"
        Me.tbItemRate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbItemRate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbItemRate.SelectedText = ""
        Me.tbItemRate.SelectionLength = 0
        Me.tbItemRate.SelectionStart = 0
        Me.tbItemRate.Size = New System.Drawing.Size(100, 29)
        Me.tbItemRate.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbItemRate.TabIndex = 46
        Me.tbItemRate.Text = "1"
        Me.tbItemRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbItemRate.UseSelectable = True
        Me.tbItemRate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbItemRate.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dtInvDate
        '
        Me.dtInvDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInvDate.Location = New System.Drawing.Point(1007, 7)
        Me.dtInvDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtInvDate.Name = "dtInvDate"
        Me.dtInvDate.Size = New System.Drawing.Size(184, 29)
        Me.dtInvDate.Style = MetroFramework.MetroColorStyle.Teal
        Me.dtInvDate.TabIndex = 3
        '
        'cbSupplier
        '
        Me.cbSupplier.DataSource = Me.TbAccountsBindingSource
        Me.cbSupplier.DisplayMember = "Account_Name"
        Me.cbSupplier.FormattingEnabled = True
        Me.cbSupplier.ItemHeight = 23
        Me.cbSupplier.Location = New System.Drawing.Point(534, 7)
        Me.cbSupplier.Name = "cbSupplier"
        Me.cbSupplier.Size = New System.Drawing.Size(468, 29)
        Me.cbSupplier.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbSupplier.TabIndex = 2
        Me.cbSupplier.UseSelectable = True
        '
        'cbCostCenter
        '
        Me.cbCostCenter.DataSource = Me.TbCostCenterListBindingSource
        Me.cbCostCenter.DisplayMember = "Cost_Center"
        Me.cbCostCenter.FormattingEnabled = True
        Me.cbCostCenter.ItemHeight = 23
        Me.cbCostCenter.Location = New System.Drawing.Point(344, 43)
        Me.cbCostCenter.Name = "cbCostCenter"
        Me.cbCostCenter.Size = New System.Drawing.Size(184, 29)
        Me.cbCostCenter.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbCostCenter.TabIndex = 1
        Me.cbCostCenter.UseSelectable = True
        '
        'TbCostCenterListBindingSource
        '
        Me.TbCostCenterListBindingSource.DataMember = "tbCostCenterList"
        Me.TbCostCenterListBindingSource.DataSource = Me.ACCDBDataSet
        '
        'cbVoucherType
        '
        Me.cbVoucherType.DataSource = Me.TbVouchersBindingSource
        Me.cbVoucherType.DisplayMember = "Voucher_Name"
        Me.cbVoucherType.FormattingEnabled = True
        Me.cbVoucherType.ItemHeight = 23
        Me.cbVoucherType.Location = New System.Drawing.Point(27, 7)
        Me.cbVoucherType.Name = "cbVoucherType"
        Me.cbVoucherType.Size = New System.Drawing.Size(311, 29)
        Me.cbVoucherType.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbVoucherType.TabIndex = 0
        Me.cbVoucherType.UseSelectable = True
        '
        'TbVouchersBindingSource
        '
        Me.TbVouchersBindingSource.DataMember = "tbVouchers"
        Me.TbVouchersBindingSource.DataSource = Me.ACCDBDataSet
        '
        'TbVouchersTableAdapter
        '
        Me.TbVouchersTableAdapter.ClearBeforeFill = True
        '
        'TbCostCenterListTableAdapter
        '
        Me.TbCostCenterListTableAdapter.ClearBeforeFill = True
        '
        'TbAccountsTableAdapter
        '
        Me.TbAccountsTableAdapter.ClearBeforeFill = True
        '
        'pnlItemsInv
        '
        Me.pnlItemsInv.BackColor = System.Drawing.Color.White
        Me.pnlItemsInv.Controls.Add(Me.tbCostSelect)
        Me.pnlItemsInv.Controls.Add(Me.Label1)
        Me.pnlItemsInv.Controls.Add(Me.tbQuantitySelect)
        Me.pnlItemsInv.Controls.Add(Me.btnAccept)
        Me.pnlItemsInv.Controls.Add(Me.dgItemSelect)
        Me.pnlItemsInv.Controls.Add(Me.tbItemSearch)
        Me.pnlItemsInv.Controls.Add(Me.btnHideSelection)
        Me.pnlItemsInv.Location = New System.Drawing.Point(1200, 114)
        Me.pnlItemsInv.Name = "pnlItemsInv"
        Me.pnlItemsInv.Size = New System.Drawing.Size(650, 327)
        Me.pnlItemsInv.TabIndex = 21
        '
        'tbCostSelect
        '
        '
        '
        '
        Me.tbCostSelect.CustomButton.Image = Nothing
        Me.tbCostSelect.CustomButton.Location = New System.Drawing.Point(109, 2)
        Me.tbCostSelect.CustomButton.Name = ""
        Me.tbCostSelect.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.tbCostSelect.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbCostSelect.CustomButton.TabIndex = 1
        Me.tbCostSelect.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbCostSelect.CustomButton.UseSelectable = True
        Me.tbCostSelect.CustomButton.Visible = False
        Me.tbCostSelect.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbCostSelect.Lines = New String() {"0"}
        Me.tbCostSelect.Location = New System.Drawing.Point(150, 285)
        Me.tbCostSelect.MaxLength = 32767
        Me.tbCostSelect.Name = "tbCostSelect"
        Me.tbCostSelect.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCostSelect.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbCostSelect.SelectedText = ""
        Me.tbCostSelect.SelectionLength = 0
        Me.tbCostSelect.SelectionStart = 0
        Me.tbCostSelect.Size = New System.Drawing.Size(137, 30)
        Me.tbCostSelect.TabIndex = 63
        Me.tbCostSelect.Text = "0"
        Me.tbCostSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbCostSelect.UseSelectable = True
        Me.tbCostSelect.WaterMark = "Quantity"
        Me.tbCostSelect.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbCostSelect.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(416, -75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 34)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Quick Info : You can only sell items" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "under default location."
        '
        'tbQuantitySelect
        '
        '
        '
        '
        Me.tbQuantitySelect.CustomButton.Image = Nothing
        Me.tbQuantitySelect.CustomButton.Location = New System.Drawing.Point(109, 2)
        Me.tbQuantitySelect.CustomButton.Name = ""
        Me.tbQuantitySelect.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.tbQuantitySelect.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbQuantitySelect.CustomButton.TabIndex = 1
        Me.tbQuantitySelect.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbQuantitySelect.CustomButton.UseSelectable = True
        Me.tbQuantitySelect.CustomButton.Visible = False
        Me.tbQuantitySelect.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbQuantitySelect.Lines = New String() {"0"}
        Me.tbQuantitySelect.Location = New System.Drawing.Point(7, 285)
        Me.tbQuantitySelect.MaxLength = 32767
        Me.tbQuantitySelect.Name = "tbQuantitySelect"
        Me.tbQuantitySelect.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbQuantitySelect.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbQuantitySelect.SelectedText = ""
        Me.tbQuantitySelect.SelectionLength = 0
        Me.tbQuantitySelect.SelectionStart = 0
        Me.tbQuantitySelect.Size = New System.Drawing.Size(137, 30)
        Me.tbQuantitySelect.TabIndex = 23
        Me.tbQuantitySelect.Text = "0"
        Me.tbQuantitySelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbQuantitySelect.UseSelectable = True
        Me.tbQuantitySelect.WaterMark = "Quantity"
        Me.tbQuantitySelect.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbQuantitySelect.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnAccept
        '
        Me.btnAccept.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAccept.Location = New System.Drawing.Point(293, 285)
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
        Me.dgItemSelect.AllowUserToResizeRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgItemSelect.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgItemSelect.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgItemSelect.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgItemSelect.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgItemSelect.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgItemSelect.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgItemSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgItemSelect.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgItemSelect.EnableHeadersVisualStyles = False
        Me.dgItemSelect.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgItemSelect.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgItemSelect.Location = New System.Drawing.Point(10, 50)
        Me.dgItemSelect.MultiSelect = False
        Me.dgItemSelect.Name = "dgItemSelect"
        Me.dgItemSelect.ReadOnly = True
        Me.dgItemSelect.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgItemSelect.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgItemSelect.RowHeadersVisible = False
        Me.dgItemSelect.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgItemSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgItemSelect.Size = New System.Drawing.Size(582, 229)
        Me.dgItemSelect.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgItemSelect.TabIndex = 19
        '
        'tbItemSearch
        '
        '
        '
        '
        Me.tbItemSearch.CustomButton.Image = Nothing
        Me.tbItemSearch.CustomButton.Location = New System.Drawing.Point(325, 2)
        Me.tbItemSearch.CustomButton.Name = ""
        Me.tbItemSearch.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbItemSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbItemSearch.CustomButton.TabIndex = 1
        Me.tbItemSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbItemSearch.CustomButton.UseSelectable = True
        Me.tbItemSearch.DisplayIcon = True
        Me.tbItemSearch.Icon = CType(resources.GetObject("tbItemSearch.Icon"), System.Drawing.Image)
        Me.tbItemSearch.Lines = New String(-1) {}
        Me.tbItemSearch.Location = New System.Drawing.Point(45, 14)
        Me.tbItemSearch.MaxLength = 32767
        Me.tbItemSearch.Name = "tbItemSearch"
        Me.tbItemSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbItemSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbItemSearch.SelectedText = ""
        Me.tbItemSearch.SelectionLength = 0
        Me.tbItemSearch.SelectionStart = 0
        Me.tbItemSearch.ShowButton = True
        Me.tbItemSearch.Size = New System.Drawing.Size(349, 26)
        Me.tbItemSearch.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbItemSearch.TabIndex = 18
        Me.tbItemSearch.UseSelectable = True
        Me.tbItemSearch.WaterMark = "Search Item Keyword"
        Me.tbItemSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbItemSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnHideSelection
        '
        Me.btnHideSelection.BackColor = System.Drawing.Color.Transparent
        Me.btnHideSelection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHideSelection.Image = CType(resources.GetObject("btnHideSelection.Image"), System.Drawing.Image)
        Me.btnHideSelection.ImageSize = 30
        Me.btnHideSelection.Location = New System.Drawing.Point(3, 9)
        Me.btnHideSelection.Name = "btnHideSelection"
        Me.btnHideSelection.NoFocusImage = CType(resources.GetObject("btnHideSelection.NoFocusImage"), System.Drawing.Image)
        Me.btnHideSelection.Size = New System.Drawing.Size(36, 34)
        Me.btnHideSelection.TabIndex = 16
        Me.btnHideSelection.UseSelectable = True
        '
        'TbCurrencyTableAdapter
        '
        Me.TbCurrencyTableAdapter.ClearBeforeFill = True
        '
        'pnlAccDetails
        '
        Me.pnlAccDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAccDetails.BackColor = System.Drawing.Color.White
        Me.pnlAccDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAccDetails.Controls.Add(Me.tbAccBalance)
        Me.pnlAccDetails.Controls.Add(Me.tbDRCR)
        Me.pnlAccDetails.Controls.Add(Me.Button1)
        Me.pnlAccDetails.Controls.Add(Me.MetroLink2)
        Me.pnlAccDetails.Location = New System.Drawing.Point(914, 79)
        Me.pnlAccDetails.Name = "pnlAccDetails"
        Me.pnlAccDetails.Size = New System.Drawing.Size(264, 86)
        Me.pnlAccDetails.TabIndex = 22
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
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(10, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 30)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "Current Balance"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
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
        'TbAccountTransTableAdapter
        '
        Me.TbAccountTransTableAdapter.ClearBeforeFill = True
        '
        'TbVoucherTransTableAdapter
        '
        Me.TbVoucherTransTableAdapter.ClearBeforeFill = True
        '
        'TbItemTransTableAdapter
        '
        Me.TbItemTransTableAdapter.ClearBeforeFill = True
        '
        'pnlPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlAccDetails)
        Me.Controls.Add(Me.pnlItemsInv)
        Me.Controls.Add(Me.pnlEditMode)
        Me.Controls.Add(Me.dgInvItem)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "pnlPurchase"
        Me.Size = New System.Drawing.Size(1200, 643)
        CType(Me.dgInvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmInv.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgLedger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmLedger.ResumeLayout(False)
        CType(Me.TbAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACCDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEditMode.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.TbCurrencyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCostCenterListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbVouchersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlItemsInv.ResumeLayout(False)
        Me.pnlItemsInv.PerformLayout()
        CType(Me.dgItemSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAccDetails.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbAccounts As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dgInvItem As MetroFramework.Controls.MetroGrid
    Friend WithEvents cmInv As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents cmsEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSaveInv As MetroFramework.Controls.MetroLink
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblInvNo As System.Windows.Forms.Label
    Friend WithEvents tbNarration As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbNetDefault As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbDiscAmt As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbTotalPrice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnCancelEdit As MetroFramework.Controls.MetroLink
    Friend WithEvents pnlEditMode As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents tbSupplier As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnShowSelection As MetroFramework.Controls.MetroLink
    Friend WithEvents tbReference As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtInvDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cbSupplier As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbCostCenter As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbVoucherType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dgLedger As MetroFramework.Controls.MetroGrid
    Friend WithEvents ACCDBDataSet As Acc_System.ACCDBDataSet
    Friend WithEvents TbCostCenterListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbVouchersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbVouchersTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbVouchersTableAdapter
    Friend WithEvents TbCostCenterListTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbCostCenterListTableAdapter
    Friend WithEvents btnAddAccount As MetroFramework.Controls.MetroButton
    Friend WithEvents tbAccounts As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cmLedger As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents cmLedgerRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbItemRate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TbAccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbAccountsTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbAccountsTableAdapter
    Friend WithEvents tbNet As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbLedgerRate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cbAccRevenue As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnRollDown As MetroFramework.Controls.MetroLink
    Friend WithEvents btnRollUp As MetroFramework.Controls.MetroLink
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents pnlItemsInv As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbQuantitySelect As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnAccept As MetroFramework.Controls.MetroButton
    Friend WithEvents dgItemSelect As MetroFramework.Controls.MetroGrid
    Friend WithEvents tbItemSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnHideSelection As MetroFramework.Controls.MetroLink
    Friend WithEvents tbCostSelect As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cbCurrency As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TbCurrencyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbCurrencyTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbCurrencyTableAdapter
    Friend WithEvents chkPrintPreview As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkPrint As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents lnkDetails As MetroFramework.Controls.MetroLink
    Friend WithEvents pnlAccDetails As System.Windows.Forms.Panel
    Friend WithEvents tbAccBalance As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbDRCR As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MetroLink2 As MetroFramework.Controls.MetroLink
    Friend WithEvents TbAccountTransTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbAccountTransTableAdapter
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents tbTotalPriceDefault As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCurrTotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNet As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblDefCur2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblDefCur1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbDiscAmtDefault As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TbVoucherTransTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbVoucherTransTableAdapter
    Friend WithEvents TbItemTransTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbItemTransTableAdapter

End Class
