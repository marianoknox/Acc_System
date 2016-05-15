<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlVoucher
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
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pnlVoucher))
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgVouchers = New MetroFramework.Controls.MetroGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmVoucher = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.cmsEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.dtEnd = New MetroFramework.Controls.MetroDateTime()
        Me.cbVoucherType = New MetroFramework.Controls.MetroComboBox()
        Me.TbVouchersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccdbDataSet = New Acc_System.ACCDBDataSet()
        Me.dtStart = New MetroFramework.Controls.MetroDateTime()
        Me.btnRun = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.CustomPanel5 = New Acc_System.CustomPanel()
        Me.CustomPanel6 = New Acc_System.CustomPanel()
        Me.CustomPanel1 = New Acc_System.CustomPanel()
        Me.CustomPanel3 = New Acc_System.CustomPanel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.dgInIvtem = New System.Windows.Forms.DataGridView()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mtcVouchers = New MetroFramework.Controls.MetroTabControl()
        Me.tabSales = New MetroFramework.Controls.MetroTabPage()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.tbAccLedger = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.tbLPOsales = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.tbRefSales = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.tbNet = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.tbDiscount = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.tbNarration = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.tbDateSales = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tbQuotation = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbCostCenter = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.tbCustomer = New System.Windows.Forms.TextBox()
        Me.btnPrint = New MetroFramework.Controls.MetroLink()
        Me.lblInvNo = New System.Windows.Forms.Label()
        Me.tabPurchase = New MetroFramework.Controls.MetroTabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.tbRateLedger = New System.Windows.Forms.TextBox()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.tbDatePur = New System.Windows.Forms.TextBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.tbAccLedgerPur = New System.Windows.Forms.TextBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.tbRefPur = New System.Windows.Forms.TextBox()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.tbRateItem = New System.Windows.Forms.TextBox()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.tbNetPur = New System.Windows.Forms.TextBox()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.tbDicountPur = New System.Windows.Forms.TextBox()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.tbTotalPur = New System.Windows.Forms.TextBox()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.tbNarrPur = New System.Windows.Forms.TextBox()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.tbCurrPur = New System.Windows.Forms.TextBox()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.tbCostCenterPur = New System.Windows.Forms.TextBox()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.tbSupplier = New System.Windows.Forms.TextBox()
        Me.dgPurchase = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblInvNoPur = New System.Windows.Forms.Label()
        Me.tabJournal = New MetroFramework.Controls.MetroTabPage()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.tbNarrJou = New System.Windows.Forms.TextBox()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.tbCostCenterJou = New System.Windows.Forms.TextBox()
        Me.tbTotalCRJou = New System.Windows.Forms.TextBox()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.tbTotalDRJou = New System.Windows.Forms.TextBox()
        Me.lblInvNoJou = New System.Windows.Forms.Label()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.tbDateJou = New System.Windows.Forms.TextBox()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.tbRefJou = New System.Windows.Forms.TextBox()
        Me.dgJournal = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabPayment = New MetroFramework.Controls.MetroTabPage()
        Me.Button32 = New System.Windows.Forms.Button()
        Me.tbNarrPay = New System.Windows.Forms.TextBox()
        Me.tbTotalPay = New System.Windows.Forms.TextBox()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.tbDatePay = New System.Windows.Forms.TextBox()
        Me.tbRefPay = New System.Windows.Forms.TextBox()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.Button34 = New System.Windows.Forms.Button()
        Me.tbCostCenterPay = New System.Windows.Forms.TextBox()
        Me.Button35 = New System.Windows.Forms.Button()
        Me.tbAccountPay = New System.Windows.Forms.TextBox()
        Me.lblInvNoPay = New System.Windows.Forms.Label()
        Me.dgPay = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabTransfer = New MetroFramework.Controls.MetroTabPage()
        Me.Button33 = New System.Windows.Forms.Button()
        Me.tbToTrans = New System.Windows.Forms.TextBox()
        Me.Button36 = New System.Windows.Forms.Button()
        Me.tbCostCenterTrans = New System.Windows.Forms.TextBox()
        Me.Button41 = New System.Windows.Forms.Button()
        Me.tbNarrTrans = New System.Windows.Forms.TextBox()
        Me.Button44 = New System.Windows.Forms.Button()
        Me.tbFromTrans = New System.Windows.Forms.TextBox()
        Me.Button42 = New System.Windows.Forms.Button()
        Me.tbDateTrans = New System.Windows.Forms.TextBox()
        Me.dgTransfer = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblInvNoTrans = New System.Windows.Forms.Label()
        Me.tabDefault = New MetroFramework.Controls.MetroTabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.CustomPanel2 = New Acc_System.CustomPanel()
        Me.CustomPanel4 = New Acc_System.CustomPanel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.TbVoucherTransTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbVoucherTransTableAdapter()
        Me.TbItemTransTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbItemTransTableAdapter()
        Me.TbVouchersTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbVouchersTableAdapter()
        Me.TbAccountTransTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbAccountTransTableAdapter()
        Me.tbReference = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        CType(Me.dgVouchers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmVoucher.SuspendLayout()
        CType(Me.TbVouchersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel2.SuspendLayout()
        Me.CustomPanel5.SuspendLayout()
        Me.CustomPanel1.SuspendLayout()
        Me.CustomPanel3.SuspendLayout()
        CType(Me.dgInIvtem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.mtcVouchers.SuspendLayout()
        Me.tabSales.SuspendLayout()
        Me.tabPurchase.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabJournal.SuspendLayout()
        CType(Me.dgJournal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPayment.SuspendLayout()
        CType(Me.dgPay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTransfer.SuspendLayout()
        CType(Me.dgTransfer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDefault.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.CustomPanel2.SuspendLayout()
        Me.CustomPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgVouchers
        '
        Me.dgVouchers.AllowUserToAddRows = False
        Me.dgVouchers.AllowUserToDeleteRows = False
        Me.dgVouchers.AllowUserToResizeRows = False
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle22.Format = "N2"
        DataGridViewCellStyle22.NullValue = Nothing
        Me.dgVouchers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle22
        Me.dgVouchers.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgVouchers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgVouchers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgVouchers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgVouchers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.dgVouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVouchers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5})
        Me.dgVouchers.ContextMenuStrip = Me.cmVoucher
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle25.Format = "N2"
        DataGridViewCellStyle25.NullValue = Nothing
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgVouchers.DefaultCellStyle = DataGridViewCellStyle25
        Me.dgVouchers.EnableHeadersVisualStyles = False
        Me.dgVouchers.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgVouchers.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgVouchers.Location = New System.Drawing.Point(9, 38)
        Me.dgVouchers.MultiSelect = False
        Me.dgVouchers.Name = "dgVouchers"
        Me.dgVouchers.ReadOnly = True
        Me.dgVouchers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgVouchers.RowHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.dgVouchers.RowHeadersVisible = False
        Me.dgVouchers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgVouchers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVouchers.Size = New System.Drawing.Size(331, 542)
        Me.dgVouchers.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgVouchers.TabIndex = 26
        '
        'Column1
        '
        Me.Column1.HeaderText = "Date"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.HeaderText = "Vch No"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Account"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 140
        '
        'Column5
        '
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle24.Format = "N2"
        DataGridViewCellStyle24.NullValue = Nothing
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle24
        Me.Column5.HeaderText = "Amount"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        Me.Column5.Width = 70
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
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.Location = New System.Drawing.Point(8, 36)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(131, 25)
        Me.MetroLabel5.TabIndex = 21
        Me.MetroLabel5.Text = "Voucher Type : "
        Me.MetroLabel5.UseCustomBackColor = True
        '
        'dtEnd
        '
        Me.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEnd.Location = New System.Drawing.Point(8, 137)
        Me.dtEnd.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtEnd.Name = "dtEnd"
        Me.dtEnd.Size = New System.Drawing.Size(214, 29)
        Me.dtEnd.TabIndex = 3
        '
        'cbVoucherType
        '
        Me.cbVoucherType.DataSource = Me.TbVouchersBindingSource
        Me.cbVoucherType.DisplayMember = "Voucher_Name"
        Me.cbVoucherType.FormattingEnabled = True
        Me.cbVoucherType.ItemHeight = 23
        Me.cbVoucherType.Location = New System.Drawing.Point(8, 67)
        Me.cbVoucherType.Name = "cbVoucherType"
        Me.cbVoucherType.Size = New System.Drawing.Size(214, 29)
        Me.cbVoucherType.TabIndex = 1
        Me.cbVoucherType.UseSelectable = True
        '
        'TbVouchersBindingSource
        '
        Me.TbVouchersBindingSource.DataMember = "tbVouchers"
        Me.TbVouchersBindingSource.DataSource = Me.AccdbDataSet
        '
        'AccdbDataSet
        '
        Me.AccdbDataSet.DataSetName = "ACCDBDataSet"
        Me.AccdbDataSet.EnforceConstraints = False
        Me.AccdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtStart
        '
        Me.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtStart.Location = New System.Drawing.Point(8, 102)
        Me.dtStart.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtStart.Name = "dtStart"
        Me.dtStart.Size = New System.Drawing.Size(214, 29)
        Me.dtStart.TabIndex = 2
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(123, 172)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(99, 28)
        Me.btnRun.TabIndex = 4
        Me.btnRun.Text = "Run"
        Me.btnRun.UseSelectable = True
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MetroPanel2.Controls.Add(Me.CustomPanel5)
        Me.MetroPanel2.Controls.Add(Me.CustomPanel1)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(254, 643)
        Me.MetroPanel2.TabIndex = 28
        Me.MetroPanel2.UseCustomBackColor = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'CustomPanel5
        '
        Me.CustomPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomPanel5.Controls.Add(Me.MetroLabel1)
        Me.CustomPanel5.Controls.Add(Me.MetroButton1)
        Me.CustomPanel5.Controls.Add(Me.tbReference)
        Me.CustomPanel5.Controls.Add(Me.CustomPanel6)
        Me.CustomPanel5.Curvature = 10
        Me.CustomPanel5.Location = New System.Drawing.Point(9, 247)
        Me.CustomPanel5.Name = "CustomPanel5"
        Me.CustomPanel5.Size = New System.Drawing.Size(236, 378)
        Me.CustomPanel5.TabIndex = 65
        '
        'CustomPanel6
        '
        Me.CustomPanel6.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomPanel6.Curvature = 10
        Me.CustomPanel6.CurveMode = CType((Acc_System.CornerCurveMode.TopLeft Or Acc_System.CornerCurveMode.TopRight), Acc_System.CornerCurveMode)
        Me.CustomPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel6.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel6.Name = "CustomPanel6"
        Me.CustomPanel6.Size = New System.Drawing.Size(236, 23)
        Me.CustomPanel6.TabIndex = 44
        '
        'CustomPanel1
        '
        Me.CustomPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomPanel1.Controls.Add(Me.CustomPanel3)
        Me.CustomPanel1.Controls.Add(Me.MetroLabel5)
        Me.CustomPanel1.Controls.Add(Me.dtEnd)
        Me.CustomPanel1.Controls.Add(Me.cbVoucherType)
        Me.CustomPanel1.Controls.Add(Me.dtStart)
        Me.CustomPanel1.Controls.Add(Me.btnRun)
        Me.CustomPanel1.Curvature = 10
        Me.CustomPanel1.Location = New System.Drawing.Point(9, 27)
        Me.CustomPanel1.Name = "CustomPanel1"
        Me.CustomPanel1.Size = New System.Drawing.Size(236, 214)
        Me.CustomPanel1.TabIndex = 64
        '
        'CustomPanel3
        '
        Me.CustomPanel3.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomPanel3.Controls.Add(Me.MetroLabel9)
        Me.CustomPanel3.Curvature = 10
        Me.CustomPanel3.CurveMode = CType((Acc_System.CornerCurveMode.TopLeft Or Acc_System.CornerCurveMode.TopRight), Acc_System.CornerCurveMode)
        Me.CustomPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel3.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel3.Name = "CustomPanel3"
        Me.CustomPanel3.Size = New System.Drawing.Size(236, 23)
        Me.CustomPanel3.TabIndex = 44
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel9.Location = New System.Drawing.Point(11, 2)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel9.TabIndex = 47
        Me.MetroLabel9.Text = "Filter"
        Me.MetroLabel9.UseCustomBackColor = True
        '
        'dgInIvtem
        '
        Me.dgInIvtem.AllowUserToAddRows = False
        Me.dgInIvtem.AllowUserToDeleteRows = False
        Me.dgInIvtem.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgInIvtem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgInIvtem.BackgroundColor = System.Drawing.Color.White
        Me.dgInIvtem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgInIvtem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgInIvtem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgInIvtem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Column19, Me.Column20})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgInIvtem.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgInIvtem.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgInIvtem.Location = New System.Drawing.Point(10, 133)
        Me.dgInIvtem.MultiSelect = False
        Me.dgInIvtem.Name = "dgInIvtem"
        Me.dgInIvtem.ReadOnly = True
        Me.dgInIvtem.RowHeadersVisible = False
        Me.dgInIvtem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgInIvtem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgInIvtem.Size = New System.Drawing.Size(555, 301)
        Me.dgInIvtem.TabIndex = 60
        '
        'Column14
        '
        Me.Column14.HeaderText = "No"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column14.Width = 30
        '
        'Column15
        '
        Me.Column15.HeaderText = "Code"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column15.Width = 70
        '
        'Column16
        '
        Me.Column16.HeaderText = "Description"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column16.Width = 170
        '
        'Column17
        '
        Me.Column17.HeaderText = "Qty"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        Me.Column17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column17.Width = 50
        '
        'Column18
        '
        Me.Column18.HeaderText = "Unit"
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        Me.Column18.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column18.Width = 50
        '
        'Column19
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column19.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column19.HeaderText = "Price"
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        Me.Column19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column19.Width = 70
        '
        'Column20
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Column20.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column20.HeaderText = "Total"
        Me.Column20.Name = "Column20"
        Me.Column20.ReadOnly = True
        Me.Column20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column20.Width = 90
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.mtcVouchers)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(604, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(596, 643)
        Me.Panel1.TabIndex = 29
        '
        'mtcVouchers
        '
        Me.mtcVouchers.Controls.Add(Me.tabSales)
        Me.mtcVouchers.Controls.Add(Me.tabPurchase)
        Me.mtcVouchers.Controls.Add(Me.tabJournal)
        Me.mtcVouchers.Controls.Add(Me.tabPayment)
        Me.mtcVouchers.Controls.Add(Me.tabTransfer)
        Me.mtcVouchers.Controls.Add(Me.tabDefault)
        Me.mtcVouchers.Location = New System.Drawing.Point(7, 27)
        Me.mtcVouchers.Name = "mtcVouchers"
        Me.mtcVouchers.SelectedIndex = 3
        Me.mtcVouchers.Size = New System.Drawing.Size(576, 598)
        Me.mtcVouchers.Style = MetroFramework.MetroColorStyle.Orange
        Me.mtcVouchers.TabIndex = 0
        Me.mtcVouchers.UseCustomBackColor = True
        Me.mtcVouchers.UseSelectable = True
        '
        'tabSales
        '
        Me.tabSales.Controls.Add(Me.Button11)
        Me.tabSales.Controls.Add(Me.tbAccLedger)
        Me.tabSales.Controls.Add(Me.Button10)
        Me.tabSales.Controls.Add(Me.tbLPOsales)
        Me.tabSales.Controls.Add(Me.Button9)
        Me.tabSales.Controls.Add(Me.tbRefSales)
        Me.tabSales.Controls.Add(Me.Button8)
        Me.tabSales.Controls.Add(Me.tbNet)
        Me.tabSales.Controls.Add(Me.Button6)
        Me.tabSales.Controls.Add(Me.tbDiscount)
        Me.tabSales.Controls.Add(Me.Button5)
        Me.tabSales.Controls.Add(Me.tbTotal)
        Me.tabSales.Controls.Add(Me.Button4)
        Me.tabSales.Controls.Add(Me.tbNarration)
        Me.tabSales.Controls.Add(Me.Button3)
        Me.tabSales.Controls.Add(Me.tbDateSales)
        Me.tabSales.Controls.Add(Me.Button2)
        Me.tabSales.Controls.Add(Me.tbQuotation)
        Me.tabSales.Controls.Add(Me.Button1)
        Me.tabSales.Controls.Add(Me.tbCostCenter)
        Me.tabSales.Controls.Add(Me.Button7)
        Me.tabSales.Controls.Add(Me.tbCustomer)
        Me.tabSales.Controls.Add(Me.btnPrint)
        Me.tabSales.Controls.Add(Me.dgInIvtem)
        Me.tabSales.Controls.Add(Me.lblInvNo)
        Me.tabSales.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabSales.HorizontalScrollbarBarColor = True
        Me.tabSales.HorizontalScrollbarHighlightOnWheel = False
        Me.tabSales.HorizontalScrollbarSize = 10
        Me.tabSales.Location = New System.Drawing.Point(4, 38)
        Me.tabSales.Name = "tabSales"
        Me.tabSales.Size = New System.Drawing.Size(568, 556)
        Me.tabSales.TabIndex = 0
        Me.tabSales.Text = "Sales"
        Me.tabSales.VerticalScrollbarBarColor = True
        Me.tabSales.VerticalScrollbarHighlightOnWheel = False
        Me.tabSales.VerticalScrollbarSize = 10
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.White
        Me.Button11.Enabled = False
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(318, 20)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(93, 22)
        Me.Button11.TabIndex = 89
        Me.Button11.Text = "Acc Ledger"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button11.UseVisualStyleBackColor = False
        '
        'tbAccLedger
        '
        Me.tbAccLedger.Location = New System.Drawing.Point(412, 20)
        Me.tbAccLedger.Name = "tbAccLedger"
        Me.tbAccLedger.Size = New System.Drawing.Size(133, 22)
        Me.tbAccLedger.TabIndex = 88
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.White
        Me.Button10.Enabled = False
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(318, 103)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(93, 22)
        Me.Button10.TabIndex = 87
        Me.Button10.Text = "LPO"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button10.UseVisualStyleBackColor = False
        '
        'tbLPOsales
        '
        Me.tbLPOsales.Location = New System.Drawing.Point(412, 103)
        Me.tbLPOsales.Name = "tbLPOsales"
        Me.tbLPOsales.Size = New System.Drawing.Size(133, 22)
        Me.tbLPOsales.TabIndex = 86
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.White
        Me.Button9.Enabled = False
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(318, 75)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(93, 22)
        Me.Button9.TabIndex = 85
        Me.Button9.Text = "Reference"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button9.UseVisualStyleBackColor = False
        '
        'tbRefSales
        '
        Me.tbRefSales.Location = New System.Drawing.Point(412, 75)
        Me.tbRefSales.Name = "tbRefSales"
        Me.tbRefSales.Size = New System.Drawing.Size(133, 22)
        Me.tbRefSales.TabIndex = 84
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.White
        Me.Button8.Enabled = False
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(10, 523)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(93, 22)
        Me.Button8.TabIndex = 83
        Me.Button8.Text = "Net"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button8.UseVisualStyleBackColor = False
        '
        'tbNet
        '
        Me.tbNet.Location = New System.Drawing.Point(104, 523)
        Me.tbNet.Name = "tbNet"
        Me.tbNet.Size = New System.Drawing.Size(165, 22)
        Me.tbNet.TabIndex = 82
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Enabled = False
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(10, 496)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(93, 22)
        Me.Button6.TabIndex = 81
        Me.Button6.Text = "Discount"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = False
        '
        'tbDiscount
        '
        Me.tbDiscount.Location = New System.Drawing.Point(104, 496)
        Me.tbDiscount.Name = "tbDiscount"
        Me.tbDiscount.Size = New System.Drawing.Size(165, 22)
        Me.tbDiscount.TabIndex = 80
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Enabled = False
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(10, 470)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(93, 22)
        Me.Button5.TabIndex = 79
        Me.Button5.Text = "Total"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = False
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(104, 470)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(165, 22)
        Me.tbTotal.TabIndex = 78
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Enabled = False
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(10, 444)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(93, 22)
        Me.Button4.TabIndex = 77
        Me.Button4.Text = "Narration"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'tbNarration
        '
        Me.tbNarration.Location = New System.Drawing.Point(104, 444)
        Me.tbNarration.Name = "tbNarration"
        Me.tbNarration.Size = New System.Drawing.Size(441, 22)
        Me.tbNarration.TabIndex = 76
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Enabled = False
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(318, 47)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 22)
        Me.Button3.TabIndex = 75
        Me.Button3.Text = "Date"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'tbDateSales
        '
        Me.tbDateSales.Location = New System.Drawing.Point(412, 47)
        Me.tbDateSales.Name = "tbDateSales"
        Me.tbDateSales.Size = New System.Drawing.Size(133, 22)
        Me.tbDateSales.TabIndex = 74
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(10, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 22)
        Me.Button2.TabIndex = 73
        Me.Button2.Text = "Quotation"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'tbQuotation
        '
        Me.tbQuotation.Location = New System.Drawing.Point(104, 103)
        Me.tbQuotation.Name = "tbQuotation"
        Me.tbQuotation.Size = New System.Drawing.Size(165, 22)
        Me.tbQuotation.TabIndex = 72
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(10, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 22)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "Cost Center"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tbCostCenter
        '
        Me.tbCostCenter.Location = New System.Drawing.Point(104, 75)
        Me.tbCostCenter.Name = "tbCostCenter"
        Me.tbCostCenter.Size = New System.Drawing.Size(165, 22)
        Me.tbCostCenter.TabIndex = 70
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.White
        Me.Button7.Enabled = False
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(10, 47)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(93, 22)
        Me.Button7.TabIndex = 69
        Me.Button7.Text = "Customer"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = False
        '
        'tbCustomer
        '
        Me.tbCustomer.Location = New System.Drawing.Point(104, 47)
        Me.tbCustomer.Name = "tbCustomer"
        Me.tbCustomer.Size = New System.Drawing.Size(165, 22)
        Me.tbCustomer.TabIndex = 68
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageSize = 25
        Me.btnPrint.Location = New System.Drawing.Point(525, 526)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(43, 30)
        Me.btnPrint.TabIndex = 58
        Me.btnPrint.UseSelectable = True
        '
        'lblInvNo
        '
        Me.lblInvNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblInvNo.AutoSize = True
        Me.lblInvNo.BackColor = System.Drawing.Color.Transparent
        Me.lblInvNo.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvNo.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblInvNo.Location = New System.Drawing.Point(3, 4)
        Me.lblInvNo.Name = "lblInvNo"
        Me.lblInvNo.Size = New System.Drawing.Size(112, 40)
        Me.lblInvNo.TabIndex = 41
        Me.lblInvNo.Text = "CR-001"
        '
        'tabPurchase
        '
        Me.tabPurchase.Controls.Add(Me.DataGridView3)
        Me.tabPurchase.Controls.Add(Me.Button23)
        Me.tabPurchase.Controls.Add(Me.tbRateLedger)
        Me.tabPurchase.Controls.Add(Me.Button20)
        Me.tabPurchase.Controls.Add(Me.tbDatePur)
        Me.tabPurchase.Controls.Add(Me.Button12)
        Me.tabPurchase.Controls.Add(Me.tbAccLedgerPur)
        Me.tabPurchase.Controls.Add(Me.Button13)
        Me.tabPurchase.Controls.Add(Me.tbRefPur)
        Me.tabPurchase.Controls.Add(Me.Button14)
        Me.tabPurchase.Controls.Add(Me.tbRateItem)
        Me.tabPurchase.Controls.Add(Me.Button15)
        Me.tabPurchase.Controls.Add(Me.tbNetPur)
        Me.tabPurchase.Controls.Add(Me.Button16)
        Me.tabPurchase.Controls.Add(Me.tbDicountPur)
        Me.tabPurchase.Controls.Add(Me.Button17)
        Me.tabPurchase.Controls.Add(Me.tbTotalPur)
        Me.tabPurchase.Controls.Add(Me.Button18)
        Me.tabPurchase.Controls.Add(Me.tbNarrPur)
        Me.tabPurchase.Controls.Add(Me.Button19)
        Me.tabPurchase.Controls.Add(Me.tbCurrPur)
        Me.tabPurchase.Controls.Add(Me.Button21)
        Me.tabPurchase.Controls.Add(Me.tbCostCenterPur)
        Me.tabPurchase.Controls.Add(Me.Button22)
        Me.tabPurchase.Controls.Add(Me.tbSupplier)
        Me.tabPurchase.Controls.Add(Me.dgPurchase)
        Me.tabPurchase.Controls.Add(Me.lblInvNoPur)
        Me.tabPurchase.HorizontalScrollbarBarColor = True
        Me.tabPurchase.HorizontalScrollbarHighlightOnWheel = False
        Me.tabPurchase.HorizontalScrollbarSize = 10
        Me.tabPurchase.Location = New System.Drawing.Point(4, 38)
        Me.tabPurchase.Name = "tabPurchase"
        Me.tabPurchase.Size = New System.Drawing.Size(568, 556)
        Me.tabPurchase.TabIndex = 1
        Me.tabPurchase.Text = "Purchase"
        Me.tabPurchase.VerticalScrollbarBarColor = True
        Me.tabPurchase.VerticalScrollbarHighlightOnWheel = False
        Me.tabPurchase.VerticalScrollbarSize = 10
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AllowUserToResizeRows = False
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle27
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView3.DefaultCellStyle = DataGridViewCellStyle28
        Me.DataGridView3.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView3.Location = New System.Drawing.Point(246, 474)
        Me.DataGridView3.MultiSelect = False
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(299, 73)
        Me.DataGridView3.TabIndex = 118
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Account"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 210
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 70
        '
        'Button23
        '
        Me.Button23.BackColor = System.Drawing.Color.White
        Me.Button23.Enabled = False
        Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button23.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.Location = New System.Drawing.Point(403, 446)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(48, 22)
        Me.Button23.TabIndex = 117
        Me.Button23.Text = "Rate"
        Me.Button23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button23.UseVisualStyleBackColor = False
        '
        'tbRateLedger
        '
        Me.tbRateLedger.Location = New System.Drawing.Point(457, 448)
        Me.tbRateLedger.Name = "tbRateLedger"
        Me.tbRateLedger.Size = New System.Drawing.Size(88, 20)
        Me.tbRateLedger.TabIndex = 116
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.White
        Me.Button20.Enabled = False
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.Location = New System.Drawing.Point(318, 23)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(93, 22)
        Me.Button20.TabIndex = 115
        Me.Button20.Text = "Date"
        Me.Button20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button20.UseVisualStyleBackColor = False
        '
        'tbDatePur
        '
        Me.tbDatePur.Location = New System.Drawing.Point(412, 23)
        Me.tbDatePur.Name = "tbDatePur"
        Me.tbDatePur.Size = New System.Drawing.Size(133, 20)
        Me.tbDatePur.TabIndex = 114
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.White
        Me.Button12.Enabled = False
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(10, 107)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(93, 22)
        Me.Button12.TabIndex = 113
        Me.Button12.Text = "Acc Ledger"
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button12.UseVisualStyleBackColor = False
        '
        'tbAccLedgerPur
        '
        Me.tbAccLedgerPur.Location = New System.Drawing.Point(104, 107)
        Me.tbAccLedgerPur.Name = "tbAccLedgerPur"
        Me.tbAccLedgerPur.Size = New System.Drawing.Size(165, 20)
        Me.tbAccLedgerPur.TabIndex = 112
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.White
        Me.Button13.Enabled = False
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(318, 107)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(93, 22)
        Me.Button13.TabIndex = 111
        Me.Button13.Text = "Reference"
        Me.Button13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button13.UseVisualStyleBackColor = False
        '
        'tbRefPur
        '
        Me.tbRefPur.Location = New System.Drawing.Point(412, 107)
        Me.tbRefPur.Name = "tbRefPur"
        Me.tbRefPur.Size = New System.Drawing.Size(133, 20)
        Me.tbRefPur.TabIndex = 110
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.White
        Me.Button14.Enabled = False
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(318, 79)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(93, 22)
        Me.Button14.TabIndex = 109
        Me.Button14.Text = "Rate"
        Me.Button14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button14.UseVisualStyleBackColor = False
        '
        'tbRateItem
        '
        Me.tbRateItem.Location = New System.Drawing.Point(412, 79)
        Me.tbRateItem.Name = "tbRateItem"
        Me.tbRateItem.Size = New System.Drawing.Size(133, 20)
        Me.tbRateItem.TabIndex = 108
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.White
        Me.Button15.Enabled = False
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(10, 527)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(93, 22)
        Me.Button15.TabIndex = 107
        Me.Button15.Text = "Net"
        Me.Button15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button15.UseVisualStyleBackColor = False
        '
        'tbNetPur
        '
        Me.tbNetPur.Location = New System.Drawing.Point(104, 527)
        Me.tbNetPur.Name = "tbNetPur"
        Me.tbNetPur.Size = New System.Drawing.Size(136, 20)
        Me.tbNetPur.TabIndex = 106
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.White
        Me.Button16.Enabled = False
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(10, 500)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(93, 22)
        Me.Button16.TabIndex = 105
        Me.Button16.Text = "Discount"
        Me.Button16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button16.UseVisualStyleBackColor = False
        '
        'tbDicountPur
        '
        Me.tbDicountPur.Location = New System.Drawing.Point(104, 500)
        Me.tbDicountPur.Name = "tbDicountPur"
        Me.tbDicountPur.Size = New System.Drawing.Size(136, 20)
        Me.tbDicountPur.TabIndex = 104
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.White
        Me.Button17.Enabled = False
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.Location = New System.Drawing.Point(10, 474)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(93, 22)
        Me.Button17.TabIndex = 103
        Me.Button17.Text = "Total"
        Me.Button17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button17.UseVisualStyleBackColor = False
        '
        'tbTotalPur
        '
        Me.tbTotalPur.Location = New System.Drawing.Point(104, 474)
        Me.tbTotalPur.Name = "tbTotalPur"
        Me.tbTotalPur.Size = New System.Drawing.Size(136, 20)
        Me.tbTotalPur.TabIndex = 102
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.White
        Me.Button18.Enabled = False
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.Location = New System.Drawing.Point(10, 448)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(93, 22)
        Me.Button18.TabIndex = 101
        Me.Button18.Text = "Narration"
        Me.Button18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button18.UseVisualStyleBackColor = False
        '
        'tbNarrPur
        '
        Me.tbNarrPur.Location = New System.Drawing.Point(104, 448)
        Me.tbNarrPur.Name = "tbNarrPur"
        Me.tbNarrPur.Size = New System.Drawing.Size(282, 20)
        Me.tbNarrPur.TabIndex = 100
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.White
        Me.Button19.Enabled = False
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.Location = New System.Drawing.Point(318, 51)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(93, 22)
        Me.Button19.TabIndex = 99
        Me.Button19.Text = "Currency"
        Me.Button19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button19.UseVisualStyleBackColor = False
        '
        'tbCurrPur
        '
        Me.tbCurrPur.Location = New System.Drawing.Point(412, 51)
        Me.tbCurrPur.Name = "tbCurrPur"
        Me.tbCurrPur.Size = New System.Drawing.Size(133, 20)
        Me.tbCurrPur.TabIndex = 98
        '
        'Button21
        '
        Me.Button21.BackColor = System.Drawing.Color.White
        Me.Button21.Enabled = False
        Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button21.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.Location = New System.Drawing.Point(10, 79)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(93, 22)
        Me.Button21.TabIndex = 95
        Me.Button21.Text = "Cost Center"
        Me.Button21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button21.UseVisualStyleBackColor = False
        '
        'tbCostCenterPur
        '
        Me.tbCostCenterPur.Location = New System.Drawing.Point(104, 79)
        Me.tbCostCenterPur.Name = "tbCostCenterPur"
        Me.tbCostCenterPur.Size = New System.Drawing.Size(165, 20)
        Me.tbCostCenterPur.TabIndex = 94
        '
        'Button22
        '
        Me.Button22.BackColor = System.Drawing.Color.White
        Me.Button22.Enabled = False
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.Location = New System.Drawing.Point(10, 51)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(93, 22)
        Me.Button22.TabIndex = 93
        Me.Button22.Text = "Supplier"
        Me.Button22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button22.UseVisualStyleBackColor = False
        '
        'tbSupplier
        '
        Me.tbSupplier.Location = New System.Drawing.Point(104, 51)
        Me.tbSupplier.Name = "tbSupplier"
        Me.tbSupplier.Size = New System.Drawing.Size(165, 20)
        Me.tbSupplier.TabIndex = 92
        '
        'dgPurchase
        '
        Me.dgPurchase.AllowUserToAddRows = False
        Me.dgPurchase.AllowUserToDeleteRows = False
        Me.dgPurchase.AllowUserToResizeRows = False
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgPurchase.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle29
        Me.dgPurchase.BackgroundColor = System.Drawing.Color.White
        Me.dgPurchase.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgPurchase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPurchase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPurchase.DefaultCellStyle = DataGridViewCellStyle32
        Me.dgPurchase.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgPurchase.Location = New System.Drawing.Point(10, 137)
        Me.dgPurchase.MultiSelect = False
        Me.dgPurchase.Name = "dgPurchase"
        Me.dgPurchase.ReadOnly = True
        Me.dgPurchase.RowHeadersVisible = False
        Me.dgPurchase.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgPurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPurchase.Size = New System.Drawing.Size(555, 301)
        Me.dgPurchase.TabIndex = 91
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 30
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 170
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Unit"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn5.Width = 50
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle30.Format = "N2"
        DataGridViewCellStyle30.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle30
        Me.DataGridViewTextBoxColumn6.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn6.Width = 70
        '
        'DataGridViewTextBoxColumn7
        '
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle31.Format = "N2"
        DataGridViewCellStyle31.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle31
        Me.DataGridViewTextBoxColumn7.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn7.Width = 90
        '
        'lblInvNoPur
        '
        Me.lblInvNoPur.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblInvNoPur.AutoSize = True
        Me.lblInvNoPur.BackColor = System.Drawing.Color.Transparent
        Me.lblInvNoPur.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvNoPur.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblInvNoPur.Location = New System.Drawing.Point(3, 8)
        Me.lblInvNoPur.Name = "lblInvNoPur"
        Me.lblInvNoPur.Size = New System.Drawing.Size(112, 40)
        Me.lblInvNoPur.TabIndex = 90
        Me.lblInvNoPur.Text = "CR-001"
        '
        'tabJournal
        '
        Me.tabJournal.Controls.Add(Me.Button28)
        Me.tabJournal.Controls.Add(Me.tbNarrJou)
        Me.tabJournal.Controls.Add(Me.Button27)
        Me.tabJournal.Controls.Add(Me.tbCostCenterJou)
        Me.tabJournal.Controls.Add(Me.tbTotalCRJou)
        Me.tabJournal.Controls.Add(Me.Button26)
        Me.tabJournal.Controls.Add(Me.tbTotalDRJou)
        Me.tabJournal.Controls.Add(Me.lblInvNoJou)
        Me.tabJournal.Controls.Add(Me.Button24)
        Me.tabJournal.Controls.Add(Me.tbDateJou)
        Me.tabJournal.Controls.Add(Me.Button25)
        Me.tabJournal.Controls.Add(Me.tbRefJou)
        Me.tabJournal.Controls.Add(Me.dgJournal)
        Me.tabJournal.HorizontalScrollbarBarColor = True
        Me.tabJournal.HorizontalScrollbarHighlightOnWheel = False
        Me.tabJournal.HorizontalScrollbarSize = 10
        Me.tabJournal.Location = New System.Drawing.Point(4, 38)
        Me.tabJournal.Name = "tabJournal"
        Me.tabJournal.Size = New System.Drawing.Size(568, 556)
        Me.tabJournal.TabIndex = 2
        Me.tabJournal.Text = "Journal"
        Me.tabJournal.VerticalScrollbarBarColor = True
        Me.tabJournal.VerticalScrollbarHighlightOnWheel = False
        Me.tabJournal.VerticalScrollbarSize = 10
        '
        'Button28
        '
        Me.Button28.BackColor = System.Drawing.Color.White
        Me.Button28.Enabled = False
        Me.Button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button28.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button28.Location = New System.Drawing.Point(10, 464)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(93, 22)
        Me.Button28.TabIndex = 127
        Me.Button28.Text = "Narration"
        Me.Button28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button28.UseVisualStyleBackColor = False
        '
        'tbNarrJou
        '
        Me.tbNarrJou.Location = New System.Drawing.Point(104, 464)
        Me.tbNarrJou.Name = "tbNarrJou"
        Me.tbNarrJou.Size = New System.Drawing.Size(442, 20)
        Me.tbNarrJou.TabIndex = 126
        '
        'Button27
        '
        Me.Button27.BackColor = System.Drawing.Color.White
        Me.Button27.Enabled = False
        Me.Button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button27.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button27.Location = New System.Drawing.Point(7, 97)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(93, 22)
        Me.Button27.TabIndex = 125
        Me.Button27.Text = "Cost Center"
        Me.Button27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button27.UseVisualStyleBackColor = False
        '
        'tbCostCenterJou
        '
        Me.tbCostCenterJou.Location = New System.Drawing.Point(101, 97)
        Me.tbCostCenterJou.Name = "tbCostCenterJou"
        Me.tbCostCenterJou.Size = New System.Drawing.Size(178, 20)
        Me.tbCostCenterJou.TabIndex = 124
        '
        'tbTotalCRJou
        '
        Me.tbTotalCRJou.Location = New System.Drawing.Point(448, 435)
        Me.tbTotalCRJou.Name = "tbTotalCRJou"
        Me.tbTotalCRJou.Size = New System.Drawing.Size(98, 20)
        Me.tbTotalCRJou.TabIndex = 123
        '
        'Button26
        '
        Me.Button26.BackColor = System.Drawing.Color.White
        Me.Button26.Enabled = False
        Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button26.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button26.Location = New System.Drawing.Point(249, 435)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(93, 22)
        Me.Button26.TabIndex = 122
        Me.Button26.Text = "Total"
        Me.Button26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button26.UseVisualStyleBackColor = False
        '
        'tbTotalDRJou
        '
        Me.tbTotalDRJou.Location = New System.Drawing.Point(344, 435)
        Me.tbTotalDRJou.Name = "tbTotalDRJou"
        Me.tbTotalDRJou.Size = New System.Drawing.Size(98, 20)
        Me.tbTotalDRJou.TabIndex = 121
        '
        'lblInvNoJou
        '
        Me.lblInvNoJou.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblInvNoJou.AutoSize = True
        Me.lblInvNoJou.BackColor = System.Drawing.Color.Transparent
        Me.lblInvNoJou.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvNoJou.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblInvNoJou.Location = New System.Drawing.Point(3, 1)
        Me.lblInvNoJou.Name = "lblInvNoJou"
        Me.lblInvNoJou.Size = New System.Drawing.Size(112, 40)
        Me.lblInvNoJou.TabIndex = 120
        Me.lblInvNoJou.Text = "CR-001"
        '
        'Button24
        '
        Me.Button24.BackColor = System.Drawing.Color.White
        Me.Button24.Enabled = False
        Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button24.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button24.Location = New System.Drawing.Point(310, 71)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(93, 22)
        Me.Button24.TabIndex = 119
        Me.Button24.Text = "Date"
        Me.Button24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button24.UseVisualStyleBackColor = False
        '
        'tbDateJou
        '
        Me.tbDateJou.Location = New System.Drawing.Point(404, 71)
        Me.tbDateJou.Name = "tbDateJou"
        Me.tbDateJou.Size = New System.Drawing.Size(133, 20)
        Me.tbDateJou.TabIndex = 118
        '
        'Button25
        '
        Me.Button25.BackColor = System.Drawing.Color.White
        Me.Button25.Enabled = False
        Me.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button25.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button25.Location = New System.Drawing.Point(310, 97)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(93, 22)
        Me.Button25.TabIndex = 117
        Me.Button25.Text = "Reference"
        Me.Button25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button25.UseVisualStyleBackColor = False
        '
        'tbRefJou
        '
        Me.tbRefJou.Location = New System.Drawing.Point(404, 97)
        Me.tbRefJou.Name = "tbRefJou"
        Me.tbRefJou.Size = New System.Drawing.Size(133, 20)
        Me.tbRefJou.TabIndex = 116
        '
        'dgJournal
        '
        Me.dgJournal.AllowUserToAddRows = False
        Me.dgJournal.AllowUserToDeleteRows = False
        Me.dgJournal.AllowUserToResizeRows = False
        DataGridViewCellStyle33.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgJournal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle33
        Me.dgJournal.BackgroundColor = System.Drawing.Color.White
        Me.dgJournal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgJournal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgJournal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.Column8, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.Column9})
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgJournal.DefaultCellStyle = DataGridViewCellStyle34
        Me.dgJournal.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgJournal.Location = New System.Drawing.Point(7, 128)
        Me.dgJournal.MultiSelect = False
        Me.dgJournal.Name = "dgJournal"
        Me.dgJournal.ReadOnly = True
        Me.dgJournal.RowHeadersVisible = False
        Me.dgJournal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgJournal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgJournal.Size = New System.Drawing.Size(555, 301)
        Me.dgJournal.TabIndex = 62
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "No."
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 40
        '
        'Column8
        '
        Me.Column8.HeaderText = "As"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 40
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Account"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 250
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Debit"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Credit"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'tabPayment
        '
        Me.tabPayment.Controls.Add(Me.Button32)
        Me.tabPayment.Controls.Add(Me.tbNarrPay)
        Me.tabPayment.Controls.Add(Me.tbTotalPay)
        Me.tabPayment.Controls.Add(Me.Button30)
        Me.tabPayment.Controls.Add(Me.tbDatePay)
        Me.tabPayment.Controls.Add(Me.tbRefPay)
        Me.tabPayment.Controls.Add(Me.Button29)
        Me.tabPayment.Controls.Add(Me.Button31)
        Me.tabPayment.Controls.Add(Me.Button34)
        Me.tabPayment.Controls.Add(Me.tbCostCenterPay)
        Me.tabPayment.Controls.Add(Me.Button35)
        Me.tabPayment.Controls.Add(Me.tbAccountPay)
        Me.tabPayment.Controls.Add(Me.lblInvNoPay)
        Me.tabPayment.Controls.Add(Me.dgPay)
        Me.tabPayment.HorizontalScrollbarBarColor = True
        Me.tabPayment.HorizontalScrollbarHighlightOnWheel = False
        Me.tabPayment.HorizontalScrollbarSize = 10
        Me.tabPayment.Location = New System.Drawing.Point(4, 38)
        Me.tabPayment.Name = "tabPayment"
        Me.tabPayment.Size = New System.Drawing.Size(568, 556)
        Me.tabPayment.TabIndex = 3
        Me.tabPayment.Text = "Payment"
        Me.tabPayment.VerticalScrollbarBarColor = True
        Me.tabPayment.VerticalScrollbarHighlightOnWheel = False
        Me.tabPayment.VerticalScrollbarSize = 10
        '
        'Button32
        '
        Me.Button32.BackColor = System.Drawing.Color.White
        Me.Button32.Enabled = False
        Me.Button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button32.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button32.Location = New System.Drawing.Point(10, 463)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(93, 22)
        Me.Button32.TabIndex = 134
        Me.Button32.Text = "Narration"
        Me.Button32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button32.UseVisualStyleBackColor = False
        '
        'tbNarrPay
        '
        Me.tbNarrPay.Location = New System.Drawing.Point(104, 463)
        Me.tbNarrPay.Name = "tbNarrPay"
        Me.tbNarrPay.Size = New System.Drawing.Size(442, 20)
        Me.tbNarrPay.TabIndex = 133
        '
        'tbTotalPay
        '
        Me.tbTotalPay.Location = New System.Drawing.Point(412, 437)
        Me.tbTotalPay.Name = "tbTotalPay"
        Me.tbTotalPay.Size = New System.Drawing.Size(133, 20)
        Me.tbTotalPay.TabIndex = 132
        '
        'Button30
        '
        Me.Button30.BackColor = System.Drawing.Color.White
        Me.Button30.Enabled = False
        Me.Button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button30.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button30.Location = New System.Drawing.Point(317, 435)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(93, 22)
        Me.Button30.TabIndex = 131
        Me.Button30.Text = "Total"
        Me.Button30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button30.UseVisualStyleBackColor = False
        '
        'tbDatePay
        '
        Me.tbDatePay.Location = New System.Drawing.Point(412, 73)
        Me.tbDatePay.Name = "tbDatePay"
        Me.tbDatePay.Size = New System.Drawing.Size(133, 20)
        Me.tbDatePay.TabIndex = 130
        '
        'tbRefPay
        '
        Me.tbRefPay.Location = New System.Drawing.Point(412, 99)
        Me.tbRefPay.Name = "tbRefPay"
        Me.tbRefPay.Size = New System.Drawing.Size(133, 20)
        Me.tbRefPay.TabIndex = 129
        '
        'Button29
        '
        Me.Button29.BackColor = System.Drawing.Color.White
        Me.Button29.Enabled = False
        Me.Button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button29.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button29.Location = New System.Drawing.Point(317, 71)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(93, 22)
        Me.Button29.TabIndex = 126
        Me.Button29.Text = "Date"
        Me.Button29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button29.UseVisualStyleBackColor = False
        '
        'Button31
        '
        Me.Button31.BackColor = System.Drawing.Color.White
        Me.Button31.Enabled = False
        Me.Button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button31.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button31.Location = New System.Drawing.Point(317, 97)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(93, 22)
        Me.Button31.TabIndex = 123
        Me.Button31.Text = "Reference"
        Me.Button31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button31.UseVisualStyleBackColor = False
        '
        'Button34
        '
        Me.Button34.BackColor = System.Drawing.Color.White
        Me.Button34.Enabled = False
        Me.Button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button34.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button34.Location = New System.Drawing.Point(9, 99)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(93, 22)
        Me.Button34.TabIndex = 120
        Me.Button34.Text = "Cost Center"
        Me.Button34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button34.UseVisualStyleBackColor = False
        '
        'tbCostCenterPay
        '
        Me.tbCostCenterPay.Location = New System.Drawing.Point(103, 99)
        Me.tbCostCenterPay.Name = "tbCostCenterPay"
        Me.tbCostCenterPay.Size = New System.Drawing.Size(165, 20)
        Me.tbCostCenterPay.TabIndex = 119
        '
        'Button35
        '
        Me.Button35.BackColor = System.Drawing.Color.White
        Me.Button35.Enabled = False
        Me.Button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button35.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button35.Location = New System.Drawing.Point(9, 71)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(93, 22)
        Me.Button35.TabIndex = 118
        Me.Button35.Text = "Account"
        Me.Button35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button35.UseVisualStyleBackColor = False
        '
        'tbAccountPay
        '
        Me.tbAccountPay.Location = New System.Drawing.Point(103, 71)
        Me.tbAccountPay.Name = "tbAccountPay"
        Me.tbAccountPay.Size = New System.Drawing.Size(165, 20)
        Me.tbAccountPay.TabIndex = 117
        '
        'lblInvNoPay
        '
        Me.lblInvNoPay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblInvNoPay.AutoSize = True
        Me.lblInvNoPay.BackColor = System.Drawing.Color.Transparent
        Me.lblInvNoPay.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvNoPay.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblInvNoPay.Location = New System.Drawing.Point(3, 0)
        Me.lblInvNoPay.Name = "lblInvNoPay"
        Me.lblInvNoPay.Size = New System.Drawing.Size(112, 40)
        Me.lblInvNoPay.TabIndex = 116
        Me.lblInvNoPay.Text = "CR-001"
        '
        'dgPay
        '
        Me.dgPay.AllowUserToAddRows = False
        Me.dgPay.AllowUserToDeleteRows = False
        Me.dgPay.AllowUserToResizeRows = False
        DataGridViewCellStyle35.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgPay.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle35
        Me.dgPay.BackgroundColor = System.Drawing.Color.White
        Me.dgPay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgPay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPay.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column6, Me.Column7})
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPay.DefaultCellStyle = DataGridViewCellStyle36
        Me.dgPay.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgPay.Location = New System.Drawing.Point(7, 128)
        Me.dgPay.MultiSelect = False
        Me.dgPay.Name = "dgPay"
        Me.dgPay.ReadOnly = True
        Me.dgPay.RowHeadersVisible = False
        Me.dgPay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgPay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPay.Size = New System.Drawing.Size(555, 301)
        Me.dgPay.TabIndex = 61
        '
        'Column4
        '
        Me.Column4.HeaderText = "No."
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 50
        '
        'Column6
        '
        Me.Column6.HeaderText = "Account"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 300
        '
        'Column7
        '
        Me.Column7.HeaderText = "Amount"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 150
        '
        'tabTransfer
        '
        Me.tabTransfer.Controls.Add(Me.Button33)
        Me.tabTransfer.Controls.Add(Me.tbToTrans)
        Me.tabTransfer.Controls.Add(Me.Button36)
        Me.tabTransfer.Controls.Add(Me.tbCostCenterTrans)
        Me.tabTransfer.Controls.Add(Me.Button41)
        Me.tabTransfer.Controls.Add(Me.tbNarrTrans)
        Me.tabTransfer.Controls.Add(Me.Button44)
        Me.tabTransfer.Controls.Add(Me.tbFromTrans)
        Me.tabTransfer.Controls.Add(Me.Button42)
        Me.tabTransfer.Controls.Add(Me.tbDateTrans)
        Me.tabTransfer.Controls.Add(Me.dgTransfer)
        Me.tabTransfer.Controls.Add(Me.lblInvNoTrans)
        Me.tabTransfer.HorizontalScrollbarBarColor = True
        Me.tabTransfer.HorizontalScrollbarHighlightOnWheel = False
        Me.tabTransfer.HorizontalScrollbarSize = 10
        Me.tabTransfer.Location = New System.Drawing.Point(4, 38)
        Me.tabTransfer.Name = "tabTransfer"
        Me.tabTransfer.Size = New System.Drawing.Size(568, 556)
        Me.tabTransfer.TabIndex = 6
        Me.tabTransfer.Text = "Transfer"
        Me.tabTransfer.VerticalScrollbarBarColor = True
        Me.tabTransfer.VerticalScrollbarHighlightOnWheel = False
        Me.tabTransfer.VerticalScrollbarSize = 10
        '
        'Button33
        '
        Me.Button33.BackColor = System.Drawing.Color.White
        Me.Button33.Enabled = False
        Me.Button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button33.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button33.Location = New System.Drawing.Point(10, 105)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(93, 22)
        Me.Button33.TabIndex = 109
        Me.Button33.Text = "To"
        Me.Button33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button33.UseVisualStyleBackColor = False
        '
        'tbToTrans
        '
        Me.tbToTrans.Location = New System.Drawing.Point(104, 105)
        Me.tbToTrans.Name = "tbToTrans"
        Me.tbToTrans.Size = New System.Drawing.Size(165, 20)
        Me.tbToTrans.TabIndex = 108
        '
        'Button36
        '
        Me.Button36.BackColor = System.Drawing.Color.White
        Me.Button36.Enabled = False
        Me.Button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button36.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button36.Location = New System.Drawing.Point(318, 105)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(93, 22)
        Me.Button36.TabIndex = 111
        Me.Button36.Text = "Cost Center"
        Me.Button36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button36.UseVisualStyleBackColor = False
        '
        'tbCostCenterTrans
        '
        Me.tbCostCenterTrans.Location = New System.Drawing.Point(412, 105)
        Me.tbCostCenterTrans.Name = "tbCostCenterTrans"
        Me.tbCostCenterTrans.Size = New System.Drawing.Size(133, 20)
        Me.tbCostCenterTrans.TabIndex = 110
        '
        'Button41
        '
        Me.Button41.BackColor = System.Drawing.Color.White
        Me.Button41.Enabled = False
        Me.Button41.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button41.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button41.Location = New System.Drawing.Point(10, 448)
        Me.Button41.Name = "Button41"
        Me.Button41.Size = New System.Drawing.Size(93, 22)
        Me.Button41.TabIndex = 101
        Me.Button41.Text = "Narration"
        Me.Button41.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button41.UseVisualStyleBackColor = False
        '
        'tbNarrTrans
        '
        Me.tbNarrTrans.Location = New System.Drawing.Point(104, 448)
        Me.tbNarrTrans.Name = "tbNarrTrans"
        Me.tbNarrTrans.Size = New System.Drawing.Size(441, 20)
        Me.tbNarrTrans.TabIndex = 100
        '
        'Button44
        '
        Me.Button44.BackColor = System.Drawing.Color.White
        Me.Button44.Enabled = False
        Me.Button44.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button44.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button44.Location = New System.Drawing.Point(10, 79)
        Me.Button44.Name = "Button44"
        Me.Button44.Size = New System.Drawing.Size(93, 22)
        Me.Button44.TabIndex = 95
        Me.Button44.Text = "From"
        Me.Button44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button44.UseVisualStyleBackColor = False
        '
        'tbFromTrans
        '
        Me.tbFromTrans.Location = New System.Drawing.Point(104, 79)
        Me.tbFromTrans.Name = "tbFromTrans"
        Me.tbFromTrans.Size = New System.Drawing.Size(165, 20)
        Me.tbFromTrans.TabIndex = 94
        '
        'Button42
        '
        Me.Button42.BackColor = System.Drawing.Color.White
        Me.Button42.Enabled = False
        Me.Button42.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button42.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button42.Location = New System.Drawing.Point(318, 77)
        Me.Button42.Name = "Button42"
        Me.Button42.Size = New System.Drawing.Size(93, 22)
        Me.Button42.TabIndex = 99
        Me.Button42.Text = "Date"
        Me.Button42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button42.UseVisualStyleBackColor = False
        '
        'tbDateTrans
        '
        Me.tbDateTrans.Location = New System.Drawing.Point(412, 77)
        Me.tbDateTrans.Name = "tbDateTrans"
        Me.tbDateTrans.Size = New System.Drawing.Size(133, 20)
        Me.tbDateTrans.TabIndex = 98
        '
        'dgTransfer
        '
        Me.dgTransfer.AllowUserToAddRows = False
        Me.dgTransfer.AllowUserToDeleteRows = False
        Me.dgTransfer.AllowUserToResizeRows = False
        DataGridViewCellStyle37.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgTransfer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle37
        Me.dgTransfer.BackgroundColor = System.Drawing.Color.White
        Me.dgTransfer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgTransfer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTransfer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgTransfer.DefaultCellStyle = DataGridViewCellStyle38
        Me.dgTransfer.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgTransfer.Location = New System.Drawing.Point(10, 137)
        Me.dgTransfer.MultiSelect = False
        Me.dgTransfer.Name = "dgTransfer"
        Me.dgTransfer.ReadOnly = True
        Me.dgTransfer.RowHeadersVisible = False
        Me.dgTransfer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgTransfer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTransfer.Size = New System.Drawing.Size(555, 301)
        Me.dgTransfer.TabIndex = 91
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "No"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn13.Width = 40
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn15.Width = 200
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "Unit"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn17.Width = 50
        '
        'lblInvNoTrans
        '
        Me.lblInvNoTrans.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblInvNoTrans.AutoSize = True
        Me.lblInvNoTrans.BackColor = System.Drawing.Color.Transparent
        Me.lblInvNoTrans.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvNoTrans.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblInvNoTrans.Location = New System.Drawing.Point(3, 8)
        Me.lblInvNoTrans.Name = "lblInvNoTrans"
        Me.lblInvNoTrans.Size = New System.Drawing.Size(112, 40)
        Me.lblInvNoTrans.TabIndex = 90
        Me.lblInvNoTrans.Text = "CR-001"
        '
        'tabDefault
        '
        Me.tabDefault.Controls.Add(Me.Label5)
        Me.tabDefault.HorizontalScrollbarBarColor = True
        Me.tabDefault.HorizontalScrollbarHighlightOnWheel = False
        Me.tabDefault.HorizontalScrollbarSize = 10
        Me.tabDefault.Location = New System.Drawing.Point(4, 38)
        Me.tabDefault.Name = "tabDefault"
        Me.tabDefault.Size = New System.Drawing.Size(568, 556)
        Me.tabDefault.TabIndex = 8
        Me.tabDefault.Text = "Default"
        Me.tabDefault.VerticalScrollbarBarColor = True
        Me.tabDefault.VerticalScrollbarHighlightOnWheel = False
        Me.tabDefault.VerticalScrollbarSize = 10
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label5.Location = New System.Drawing.Point(14, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(283, 40)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "No available preview"
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MetroPanel1.Controls.Add(Me.CustomPanel2)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(254, 0)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(350, 643)
        Me.MetroPanel1.TabIndex = 30
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'CustomPanel2
        '
        Me.CustomPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomPanel2.Controls.Add(Me.CustomPanel4)
        Me.CustomPanel2.Controls.Add(Me.dgVouchers)
        Me.CustomPanel2.Curvature = 10
        Me.CustomPanel2.Location = New System.Drawing.Point(0, 27)
        Me.CustomPanel2.Name = "CustomPanel2"
        Me.CustomPanel2.Size = New System.Drawing.Size(349, 598)
        Me.CustomPanel2.TabIndex = 64
        '
        'CustomPanel4
        '
        Me.CustomPanel4.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomPanel4.Controls.Add(Me.MetroLabel10)
        Me.CustomPanel4.Curvature = 10
        Me.CustomPanel4.CurveMode = CType((Acc_System.CornerCurveMode.TopLeft Or Acc_System.CornerCurveMode.TopRight), Acc_System.CornerCurveMode)
        Me.CustomPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel4.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel4.Name = "CustomPanel4"
        Me.CustomPanel4.Size = New System.Drawing.Size(349, 23)
        Me.CustomPanel4.TabIndex = 44
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel10.Location = New System.Drawing.Point(6, 2)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(85, 19)
        Me.MetroLabel10.TabIndex = 48
        Me.MetroLabel10.Text = "Transactions"
        Me.MetroLabel10.UseCustomBackColor = True
        '
        'TbVoucherTransTableAdapter
        '
        Me.TbVoucherTransTableAdapter.ClearBeforeFill = True
        '
        'TbItemTransTableAdapter
        '
        Me.TbItemTransTableAdapter.ClearBeforeFill = True
        '
        'TbVouchersTableAdapter
        '
        Me.TbVouchersTableAdapter.ClearBeforeFill = True
        '
        'TbAccountTransTableAdapter
        '
        Me.TbAccountTransTableAdapter.ClearBeforeFill = True
        '
        'tbReference
        '
        '
        '
        '
        Me.tbReference.CustomButton.Image = Nothing
        Me.tbReference.CustomButton.Location = New System.Drawing.Point(183, 1)
        Me.tbReference.CustomButton.Name = ""
        Me.tbReference.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbReference.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbReference.CustomButton.TabIndex = 1
        Me.tbReference.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbReference.CustomButton.UseSelectable = True
        Me.tbReference.CustomButton.Visible = False
        Me.tbReference.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbReference.Lines = New String(-1) {}
        Me.tbReference.Location = New System.Drawing.Point(11, 61)
        Me.tbReference.MaxLength = 32767
        Me.tbReference.Name = "tbReference"
        Me.tbReference.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbReference.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbReference.SelectedText = ""
        Me.tbReference.SelectionLength = 0
        Me.tbReference.SelectionStart = 0
        Me.tbReference.Size = New System.Drawing.Size(211, 29)
        Me.tbReference.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbReference.TabIndex = 45
        Me.tbReference.UseSelectable = True
        Me.tbReference.WaterMark = "Reference"
        Me.tbReference.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbReference.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(123, 96)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(99, 28)
        Me.MetroButton1.TabIndex = 45
        Me.MetroButton1.Text = "Search"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(8, 35)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(175, 19)
        Me.MetroLabel1.TabIndex = 46
        Me.MetroLabel1.Text = "Type any key word to search"
        Me.MetroLabel1.UseCustomBackColor = True
        '
        'pnlVoucher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Name = "pnlVoucher"
        Me.Size = New System.Drawing.Size(1200, 643)
        CType(Me.dgVouchers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmVoucher.ResumeLayout(False)
        CType(Me.TbVouchersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel2.ResumeLayout(False)
        Me.CustomPanel5.ResumeLayout(False)
        Me.CustomPanel5.PerformLayout()
        Me.CustomPanel1.ResumeLayout(False)
        Me.CustomPanel1.PerformLayout()
        Me.CustomPanel3.ResumeLayout(False)
        Me.CustomPanel3.PerformLayout()
        CType(Me.dgInIvtem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.mtcVouchers.ResumeLayout(False)
        Me.tabSales.ResumeLayout(False)
        Me.tabSales.PerformLayout()
        Me.tabPurchase.ResumeLayout(False)
        Me.tabPurchase.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabJournal.ResumeLayout(False)
        Me.tabJournal.PerformLayout()
        CType(Me.dgJournal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPayment.ResumeLayout(False)
        Me.tabPayment.PerformLayout()
        CType(Me.dgPay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTransfer.ResumeLayout(False)
        Me.tabTransfer.PerformLayout()
        CType(Me.dgTransfer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDefault.ResumeLayout(False)
        Me.tabDefault.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.CustomPanel2.ResumeLayout(False)
        Me.CustomPanel4.ResumeLayout(False)
        Me.CustomPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgVouchers As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtEnd As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cbVoucherType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dtStart As MetroFramework.Controls.MetroDateTime
    Friend WithEvents btnRun As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents cmVoucher As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents cmsEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents mtcVouchers As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabSales As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabPurchase As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabJournal As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabPayment As MetroFramework.Controls.MetroTabPage
    Friend WithEvents lblInvNo As System.Windows.Forms.Label
    Friend WithEvents tabTransfer As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabDefault As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnPrint As MetroFramework.Controls.MetroLink
    Friend WithEvents dgInIvtem As System.Windows.Forms.DataGridView
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomPanel1 As Acc_System.CustomPanel
    Friend WithEvents CustomPanel3 As Acc_System.CustomPanel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents CustomPanel2 As Acc_System.CustomPanel
    Friend WithEvents CustomPanel4 As Acc_System.CustomPanel
    Friend WithEvents CustomPanel5 As Acc_System.CustomPanel
    Friend WithEvents CustomPanel6 As Acc_System.CustomPanel
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TbVoucherTransTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbVoucherTransTableAdapter
    Friend WithEvents TbItemTransTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbItemTransTableAdapter
    Friend WithEvents TbVouchersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccdbDataSet As Acc_System.ACCDBDataSet
    Friend WithEvents TbVouchersTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbVouchersTableAdapter
    Friend WithEvents tbCustomer As System.Windows.Forms.TextBox
    Friend WithEvents dgPay As System.Windows.Forms.DataGridView
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tbQuotation As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tbCostCenter As System.Windows.Forms.TextBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents tbNet As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents tbDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents tbTotal As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents tbNarration As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents tbDateSales As System.Windows.Forms.TextBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents tbRefSales As System.Windows.Forms.TextBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents tbLPOsales As System.Windows.Forms.TextBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents tbAccLedger As System.Windows.Forms.TextBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents tbAccLedgerPur As System.Windows.Forms.TextBox
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents tbRefPur As System.Windows.Forms.TextBox
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents tbRateItem As System.Windows.Forms.TextBox
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents tbNetPur As System.Windows.Forms.TextBox
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents tbDicountPur As System.Windows.Forms.TextBox
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents tbTotalPur As System.Windows.Forms.TextBox
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents tbNarrPur As System.Windows.Forms.TextBox
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents tbCurrPur As System.Windows.Forms.TextBox
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents tbCostCenterPur As System.Windows.Forms.TextBox
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents tbSupplier As System.Windows.Forms.TextBox
    Friend WithEvents dgPurchase As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblInvNoPur As System.Windows.Forms.Label
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents tbDatePur As System.Windows.Forms.TextBox
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents tbRateLedger As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgJournal As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblInvNoJou As System.Windows.Forms.Label
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents tbDateJou As System.Windows.Forms.TextBox
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents tbRefJou As System.Windows.Forms.TextBox
    Friend WithEvents tbTotalCRJou As System.Windows.Forms.TextBox
    Friend WithEvents Button26 As System.Windows.Forms.Button
    Friend WithEvents tbTotalDRJou As System.Windows.Forms.TextBox
    Friend WithEvents Button27 As System.Windows.Forms.Button
    Friend WithEvents tbCostCenterJou As System.Windows.Forms.TextBox
    Friend WithEvents Button28 As System.Windows.Forms.Button
    Friend WithEvents tbNarrJou As System.Windows.Forms.TextBox
    Friend WithEvents tbDatePay As System.Windows.Forms.TextBox
    Friend WithEvents tbRefPay As System.Windows.Forms.TextBox
    Friend WithEvents Button29 As System.Windows.Forms.Button
    Friend WithEvents Button31 As System.Windows.Forms.Button
    Friend WithEvents Button34 As System.Windows.Forms.Button
    Friend WithEvents tbCostCenterPay As System.Windows.Forms.TextBox
    Friend WithEvents Button35 As System.Windows.Forms.Button
    Friend WithEvents tbAccountPay As System.Windows.Forms.TextBox
    Friend WithEvents lblInvNoPay As System.Windows.Forms.Label
    Friend WithEvents tbTotalPay As System.Windows.Forms.TextBox
    Friend WithEvents Button30 As System.Windows.Forms.Button
    Friend WithEvents Button32 As System.Windows.Forms.Button
    Friend WithEvents tbNarrPay As System.Windows.Forms.TextBox
    Friend WithEvents Button36 As System.Windows.Forms.Button
    Friend WithEvents tbCostCenterTrans As System.Windows.Forms.TextBox
    Friend WithEvents Button33 As System.Windows.Forms.Button
    Friend WithEvents tbToTrans As System.Windows.Forms.TextBox
    Friend WithEvents Button41 As System.Windows.Forms.Button
    Friend WithEvents tbNarrTrans As System.Windows.Forms.TextBox
    Friend WithEvents Button42 As System.Windows.Forms.Button
    Friend WithEvents tbDateTrans As System.Windows.Forms.TextBox
    Friend WithEvents Button44 As System.Windows.Forms.Button
    Friend WithEvents tbFromTrans As System.Windows.Forms.TextBox
    Friend WithEvents dgTransfer As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblInvNoTrans As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TbAccountTransTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbAccountTransTableAdapter
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents tbReference As MetroFramework.Controls.MetroTextBox

End Class
