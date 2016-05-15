<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlLedger
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pnlLedger))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgLedger = New MetroFramework.Controls.MetroGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmVoucher = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.cmsEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mtcVouchers = New MetroFramework.Controls.MetroTabControl()
        Me.tabSales = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.btnPrint = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.dgInvItem = New System.Windows.Forms.DataGridView()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.lblNarration = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lblQuotation = New MetroFramework.Controls.MetroLabel()
        Me.lblNet = New MetroFramework.Controls.MetroLabel()
        Me.lblDiscount = New MetroFramework.Controls.MetroLabel()
        Me.lblTotal = New MetroFramework.Controls.MetroLabel()
        Me.lblCostCenter = New MetroFramework.Controls.MetroLabel()
        Me.lblCustomer = New MetroFramework.Controls.MetroLabel()
        Me.lblInvNo = New System.Windows.Forms.Label()
        Me.tabPurchase = New MetroFramework.Controls.MetroTabPage()
        Me.tabJournal = New MetroFramework.Controls.MetroTabPage()
        Me.tabPayment = New MetroFramework.Controls.MetroTabPage()
        Me.tabTransfer = New MetroFramework.Controls.MetroTabPage()
        Me.tabDefault = New MetroFramework.Controls.MetroTabPage()
        Me.dtEnd = New MetroFramework.Controls.MetroDateTime()
        Me.cbVoucherType = New MetroFramework.Controls.MetroComboBox()
        Me.TbAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACCDBDataSet = New Acc_System.ACCDBDataSet()
        Me.dtStart = New MetroFramework.Controls.MetroDateTime()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.CustomPanel1 = New Acc_System.CustomPanel()
        Me.CustomPanel3 = New Acc_System.CustomPanel()
        Me.tbAccount = New MetroFramework.Controls.MetroTextBox()
        Me.btnRun = New MetroFramework.Controls.MetroButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CustomPanel2 = New Acc_System.CustomPanel()
        Me.CustomPanel4 = New Acc_System.CustomPanel()
        Me.MetroTextBox5 = New MetroFramework.Controls.MetroTextBox()
        Me.tbTotalBalance = New MetroFramework.Controls.MetroTextBox()
        Me.tbReference = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.tbTotalDR = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.tbTotalCR = New MetroFramework.Controls.MetroTextBox()
        Me.TbAccountsTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbAccountsTableAdapter()
        Me.TbAccountTransTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbAccountTransTableAdapter()
        Me.TbVoucherTransTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbVoucherTransTableAdapter()
        Me.TbItemTransTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbItemTransTableAdapter()
        CType(Me.dgLedger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmVoucher.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.mtcVouchers.SuspendLayout()
        Me.tabSales.SuspendLayout()
        CType(Me.dgInvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACCDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel2.SuspendLayout()
        Me.CustomPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.CustomPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgLedger
        '
        Me.dgLedger.AllowUserToAddRows = False
        Me.dgLedger.AllowUserToDeleteRows = False
        Me.dgLedger.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.dgLedger.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgLedger.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgLedger.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgLedger.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgLedger.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLedger.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLedger.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column12, Me.Column13})
        Me.dgLedger.ContextMenuStrip = Me.cmVoucher
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgLedger.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgLedger.EnableHeadersVisualStyles = False
        Me.dgLedger.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgLedger.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgLedger.Location = New System.Drawing.Point(7, 74)
        Me.dgLedger.MultiSelect = False
        Me.dgLedger.Name = "dgLedger"
        Me.dgLedger.ReadOnly = True
        Me.dgLedger.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgLedger.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgLedger.RowHeadersVisible = False
        Me.dgLedger.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgLedger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgLedger.Size = New System.Drawing.Size(582, 263)
        Me.dgLedger.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgLedger.TabIndex = 30
        '
        'Column1
        '
        Me.Column1.HeaderText = "Date"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Vch No"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Vch Type"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column5
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column5.HeaderText = "Debit"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column12
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column12.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column12.HeaderText = "Credit"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column13
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column13.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column13.HeaderText = "Balance"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'cmVoucher
        '
        Me.cmVoucher.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsEdit, Me.cmsDelete})
        Me.cmVoucher.Name = "cmInv"
        Me.cmVoucher.Size = New System.Drawing.Size(153, 70)
        '
        'cmsEdit
        '
        Me.cmsEdit.Name = "cmsEdit"
        Me.cmsEdit.Size = New System.Drawing.Size(152, 22)
        Me.cmsEdit.Text = "Edit"
        '
        'cmsDelete
        '
        Me.cmsDelete.Name = "cmsDelete"
        Me.cmsDelete.Size = New System.Drawing.Size(152, 22)
        Me.cmsDelete.Text = "Delete"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.mtcVouchers)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(615, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(585, 643)
        Me.Panel1.TabIndex = 32
        '
        'mtcVouchers
        '
        Me.mtcVouchers.Controls.Add(Me.tabSales)
        Me.mtcVouchers.Controls.Add(Me.tabPurchase)
        Me.mtcVouchers.Controls.Add(Me.tabJournal)
        Me.mtcVouchers.Controls.Add(Me.tabPayment)
        Me.mtcVouchers.Controls.Add(Me.tabTransfer)
        Me.mtcVouchers.Controls.Add(Me.tabDefault)
        Me.mtcVouchers.Location = New System.Drawing.Point(10, 16)
        Me.mtcVouchers.Name = "mtcVouchers"
        Me.mtcVouchers.SelectedIndex = 0
        Me.mtcVouchers.Size = New System.Drawing.Size(564, 606)
        Me.mtcVouchers.Style = MetroFramework.MetroColorStyle.Orange
        Me.mtcVouchers.TabIndex = 0
        Me.mtcVouchers.UseCustomBackColor = True
        Me.mtcVouchers.UseSelectable = True
        '
        'tabSales
        '
        Me.tabSales.Controls.Add(Me.MetroLabel6)
        Me.tabSales.Controls.Add(Me.MetroLabel7)
        Me.tabSales.Controls.Add(Me.btnPrint)
        Me.tabSales.Controls.Add(Me.MetroLabel8)
        Me.tabSales.Controls.Add(Me.dgInvItem)
        Me.tabSales.Controls.Add(Me.MetroLabel4)
        Me.tabSales.Controls.Add(Me.MetroLabel3)
        Me.tabSales.Controls.Add(Me.MetroLabel1)
        Me.tabSales.Controls.Add(Me.lblNarration)
        Me.tabSales.Controls.Add(Me.MetroLabel2)
        Me.tabSales.Controls.Add(Me.lblQuotation)
        Me.tabSales.Controls.Add(Me.lblNet)
        Me.tabSales.Controls.Add(Me.lblDiscount)
        Me.tabSales.Controls.Add(Me.lblTotal)
        Me.tabSales.Controls.Add(Me.lblCostCenter)
        Me.tabSales.Controls.Add(Me.lblCustomer)
        Me.tabSales.Controls.Add(Me.lblInvNo)
        Me.tabSales.HorizontalScrollbarBarColor = True
        Me.tabSales.HorizontalScrollbarHighlightOnWheel = False
        Me.tabSales.HorizontalScrollbarSize = 10
        Me.tabSales.Location = New System.Drawing.Point(4, 38)
        Me.tabSales.Name = "tabSales"
        Me.tabSales.Size = New System.Drawing.Size(556, 564)
        Me.tabSales.TabIndex = 0
        Me.tabSales.Text = "Sales"
        Me.tabSales.VerticalScrollbarBarColor = True
        Me.tabSales.VerticalScrollbarHighlightOnWheel = False
        Me.tabSales.VerticalScrollbarSize = 10
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel6.Location = New System.Drawing.Point(24, 104)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel6.TabIndex = 57
        Me.MetroLabel6.Text = "Quotation"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel7.Location = New System.Drawing.Point(14, 79)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(82, 19)
        Me.MetroLabel7.TabIndex = 56
        Me.MetroLabel7.Text = "Cost Center"
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageSize = 25
        Me.btnPrint.Location = New System.Drawing.Point(510, 523)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(43, 30)
        Me.btnPrint.TabIndex = 58
        Me.btnPrint.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel8.Location = New System.Drawing.Point(27, 52)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel8.TabIndex = 55
        Me.MetroLabel8.Text = "Customer"
        '
        'dgInvItem
        '
        Me.dgInvItem.AllowUserToAddRows = False
        Me.dgInvItem.AllowUserToDeleteRows = False
        Me.dgInvItem.AllowUserToResizeRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgInvItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgInvItem.BackgroundColor = System.Drawing.Color.White
        Me.dgInvItem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgInvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgInvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgInvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18, Me.Column19, Me.Column20})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgInvItem.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgInvItem.Location = New System.Drawing.Point(10, 132)
        Me.dgInvItem.MultiSelect = False
        Me.dgInvItem.Name = "dgInvItem"
        Me.dgInvItem.ReadOnly = True
        Me.dgInvItem.RowHeadersVisible = False
        Me.dgInvItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgInvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgInvItem.Size = New System.Drawing.Size(545, 301)
        Me.dgInvItem.TabIndex = 59
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
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column19.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column19.HeaderText = "Price"
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        Me.Column19.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column19.Width = 70
        '
        'Column20
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column20.DefaultCellStyle = DataGridViewCellStyle10
        Me.Column20.HeaderText = "Total"
        Me.Column20.Name = "Column20"
        Me.Column20.ReadOnly = True
        Me.Column20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column20.Width = 90
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(10, 442)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel4.TabIndex = 54
        Me.MetroLabel4.Text = "Narration"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(38, 471)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel3.TabIndex = 51
        Me.MetroLabel3.Text = "Total"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(46, 521)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(31, 19)
        Me.MetroLabel1.TabIndex = 53
        Me.MetroLabel1.Text = "Net"
        '
        'lblNarration
        '
        Me.lblNarration.AutoSize = True
        Me.lblNarration.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblNarration.Location = New System.Drawing.Point(83, 442)
        Me.lblNarration.Name = "lblNarration"
        Me.lblNarration.Size = New System.Drawing.Size(67, 19)
        Me.lblNarration.TabIndex = 50
        Me.lblNarration.Text = "Narration"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(14, 496)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel2.TabIndex = 52
        Me.MetroLabel2.Text = "Discount"
        '
        'lblQuotation
        '
        Me.lblQuotation.AutoSize = True
        Me.lblQuotation.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblQuotation.Location = New System.Drawing.Point(102, 104)
        Me.lblQuotation.Name = "lblQuotation"
        Me.lblQuotation.Size = New System.Drawing.Size(72, 19)
        Me.lblQuotation.TabIndex = 45
        Me.lblQuotation.Text = "Quotation"
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblNet.Location = New System.Drawing.Point(83, 521)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(31, 19)
        Me.lblNet.TabIndex = 49
        Me.lblNet.Text = "Net"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblDiscount.Location = New System.Drawing.Point(83, 496)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(63, 19)
        Me.lblDiscount.TabIndex = 48
        Me.lblDiscount.Text = "Discount"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblTotal.Location = New System.Drawing.Point(83, 471)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(39, 19)
        Me.lblTotal.TabIndex = 47
        Me.lblTotal.Text = "Total"
        '
        'lblCostCenter
        '
        Me.lblCostCenter.AutoSize = True
        Me.lblCostCenter.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblCostCenter.Location = New System.Drawing.Point(102, 79)
        Me.lblCostCenter.Name = "lblCostCenter"
        Me.lblCostCenter.Size = New System.Drawing.Size(82, 19)
        Me.lblCostCenter.TabIndex = 43
        Me.lblCostCenter.Text = "Cost Center"
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblCustomer.Location = New System.Drawing.Point(102, 52)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(69, 19)
        Me.lblCustomer.TabIndex = 42
        Me.lblCustomer.Text = "Customer"
        '
        'lblInvNo
        '
        Me.lblInvNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblInvNo.AutoSize = True
        Me.lblInvNo.BackColor = System.Drawing.Color.Transparent
        Me.lblInvNo.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvNo.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblInvNo.Location = New System.Drawing.Point(3, 12)
        Me.lblInvNo.Name = "lblInvNo"
        Me.lblInvNo.Size = New System.Drawing.Size(112, 40)
        Me.lblInvNo.TabIndex = 41
        Me.lblInvNo.Text = "CR-001"
        '
        'tabPurchase
        '
        Me.tabPurchase.HorizontalScrollbarBarColor = True
        Me.tabPurchase.HorizontalScrollbarHighlightOnWheel = False
        Me.tabPurchase.HorizontalScrollbarSize = 10
        Me.tabPurchase.Location = New System.Drawing.Point(4, 38)
        Me.tabPurchase.Name = "tabPurchase"
        Me.tabPurchase.Size = New System.Drawing.Size(556, 564)
        Me.tabPurchase.TabIndex = 1
        Me.tabPurchase.Text = "Purchase"
        Me.tabPurchase.VerticalScrollbarBarColor = True
        Me.tabPurchase.VerticalScrollbarHighlightOnWheel = False
        Me.tabPurchase.VerticalScrollbarSize = 10
        '
        'tabJournal
        '
        Me.tabJournal.HorizontalScrollbarBarColor = True
        Me.tabJournal.HorizontalScrollbarHighlightOnWheel = False
        Me.tabJournal.HorizontalScrollbarSize = 10
        Me.tabJournal.Location = New System.Drawing.Point(4, 38)
        Me.tabJournal.Name = "tabJournal"
        Me.tabJournal.Size = New System.Drawing.Size(556, 564)
        Me.tabJournal.TabIndex = 2
        Me.tabJournal.Text = "Journal"
        Me.tabJournal.VerticalScrollbarBarColor = True
        Me.tabJournal.VerticalScrollbarHighlightOnWheel = False
        Me.tabJournal.VerticalScrollbarSize = 10
        '
        'tabPayment
        '
        Me.tabPayment.HorizontalScrollbarBarColor = True
        Me.tabPayment.HorizontalScrollbarHighlightOnWheel = False
        Me.tabPayment.HorizontalScrollbarSize = 10
        Me.tabPayment.Location = New System.Drawing.Point(4, 38)
        Me.tabPayment.Name = "tabPayment"
        Me.tabPayment.Size = New System.Drawing.Size(556, 564)
        Me.tabPayment.TabIndex = 3
        Me.tabPayment.Text = "Payment"
        Me.tabPayment.VerticalScrollbarBarColor = True
        Me.tabPayment.VerticalScrollbarHighlightOnWheel = False
        Me.tabPayment.VerticalScrollbarSize = 10
        '
        'tabTransfer
        '
        Me.tabTransfer.HorizontalScrollbarBarColor = True
        Me.tabTransfer.HorizontalScrollbarHighlightOnWheel = False
        Me.tabTransfer.HorizontalScrollbarSize = 10
        Me.tabTransfer.Location = New System.Drawing.Point(4, 38)
        Me.tabTransfer.Name = "tabTransfer"
        Me.tabTransfer.Size = New System.Drawing.Size(556, 564)
        Me.tabTransfer.TabIndex = 6
        Me.tabTransfer.Text = "Transfer"
        Me.tabTransfer.VerticalScrollbarBarColor = True
        Me.tabTransfer.VerticalScrollbarHighlightOnWheel = False
        Me.tabTransfer.VerticalScrollbarSize = 10
        '
        'tabDefault
        '
        Me.tabDefault.HorizontalScrollbarBarColor = True
        Me.tabDefault.HorizontalScrollbarHighlightOnWheel = False
        Me.tabDefault.HorizontalScrollbarSize = 10
        Me.tabDefault.Location = New System.Drawing.Point(4, 38)
        Me.tabDefault.Name = "tabDefault"
        Me.tabDefault.Size = New System.Drawing.Size(556, 564)
        Me.tabDefault.TabIndex = 8
        Me.tabDefault.Text = "Default"
        Me.tabDefault.VerticalScrollbarBarColor = True
        Me.tabDefault.VerticalScrollbarHighlightOnWheel = False
        Me.tabDefault.VerticalScrollbarSize = 10
        '
        'dtEnd
        '
        Me.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEnd.Location = New System.Drawing.Point(312, 138)
        Me.dtEnd.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtEnd.Name = "dtEnd"
        Me.dtEnd.Size = New System.Drawing.Size(203, 29)
        Me.dtEnd.TabIndex = 3
        '
        'cbVoucherType
        '
        Me.cbVoucherType.DataSource = Me.TbAccountsBindingSource
        Me.cbVoucherType.DisplayMember = "Account_Name"
        Me.cbVoucherType.FormattingEnabled = True
        Me.cbVoucherType.ItemHeight = 23
        Me.cbVoucherType.Location = New System.Drawing.Point(11, 63)
        Me.cbVoucherType.Name = "cbVoucherType"
        Me.cbVoucherType.Size = New System.Drawing.Size(578, 29)
        Me.cbVoucherType.TabIndex = 1
        Me.cbVoucherType.UseSelectable = True
        '
        'TbAccountsBindingSource
        '
        Me.TbAccountsBindingSource.DataMember = "tbAccounts"
        Me.TbAccountsBindingSource.DataSource = Me.ACCDBDataSet
        '
        'ACCDBDataSet
        '
        Me.ACCDBDataSet.DataSetName = "ACCDBDataSet"
        Me.ACCDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtStart
        '
        Me.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtStart.Location = New System.Drawing.Point(312, 100)
        Me.dtStart.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtStart.Name = "dtStart"
        Me.dtStart.Size = New System.Drawing.Size(203, 29)
        Me.dtStart.TabIndex = 2
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MetroPanel2.Controls.Add(Me.CustomPanel1)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(615, 203)
        Me.MetroPanel2.TabIndex = 31
        Me.MetroPanel2.UseCustomBackColor = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'CustomPanel1
        '
        Me.CustomPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomPanel1.Controls.Add(Me.CustomPanel3)
        Me.CustomPanel1.Controls.Add(Me.tbAccount)
        Me.CustomPanel1.Controls.Add(Me.dtEnd)
        Me.CustomPanel1.Controls.Add(Me.cbVoucherType)
        Me.CustomPanel1.Controls.Add(Me.btnRun)
        Me.CustomPanel1.Controls.Add(Me.dtStart)
        Me.CustomPanel1.Curvature = 10
        Me.CustomPanel1.Location = New System.Drawing.Point(9, 16)
        Me.CustomPanel1.Name = "CustomPanel1"
        Me.CustomPanel1.Size = New System.Drawing.Size(603, 181)
        Me.CustomPanel1.TabIndex = 62
        '
        'CustomPanel3
        '
        Me.CustomPanel3.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomPanel3.Curvature = 10
        Me.CustomPanel3.CurveMode = CType((Acc_System.CornerCurveMode.TopLeft Or Acc_System.CornerCurveMode.TopRight), Acc_System.CornerCurveMode)
        Me.CustomPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel3.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel3.Name = "CustomPanel3"
        Me.CustomPanel3.Size = New System.Drawing.Size(603, 22)
        Me.CustomPanel3.TabIndex = 44
        '
        'tbAccount
        '
        '
        '
        '
        Me.tbAccount.CustomButton.Image = Nothing
        Me.tbAccount.CustomButton.Location = New System.Drawing.Point(184, 1)
        Me.tbAccount.CustomButton.Name = ""
        Me.tbAccount.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbAccount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbAccount.CustomButton.TabIndex = 1
        Me.tbAccount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbAccount.CustomButton.UseSelectable = True
        Me.tbAccount.CustomButton.Visible = False
        Me.tbAccount.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbAccount.Lines = New String(-1) {}
        Me.tbAccount.Location = New System.Drawing.Point(11, 28)
        Me.tbAccount.MaxLength = 32767
        Me.tbAccount.Name = "tbAccount"
        Me.tbAccount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbAccount.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbAccount.SelectedText = ""
        Me.tbAccount.SelectionLength = 0
        Me.tbAccount.SelectionStart = 0
        Me.tbAccount.Size = New System.Drawing.Size(212, 29)
        Me.tbAccount.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbAccount.TabIndex = 43
        Me.tbAccount.UseSelectable = True
        Me.tbAccount.WaterMark = "Account Name"
        Me.tbAccount.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbAccount.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(521, 99)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(69, 67)
        Me.btnRun.TabIndex = 4
        Me.btnRun.Text = "Run"
        Me.btnRun.UseSelectable = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.CustomPanel2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 203)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(615, 440)
        Me.Panel2.TabIndex = 33
        '
        'CustomPanel2
        '
        Me.CustomPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomPanel2.Controls.Add(Me.CustomPanel4)
        Me.CustomPanel2.Controls.Add(Me.MetroTextBox5)
        Me.CustomPanel2.Controls.Add(Me.dgLedger)
        Me.CustomPanel2.Controls.Add(Me.tbTotalBalance)
        Me.CustomPanel2.Controls.Add(Me.tbReference)
        Me.CustomPanel2.Controls.Add(Me.MetroLink1)
        Me.CustomPanel2.Controls.Add(Me.MetroTextBox1)
        Me.CustomPanel2.Controls.Add(Me.tbTotalDR)
        Me.CustomPanel2.Controls.Add(Me.MetroLabel9)
        Me.CustomPanel2.Controls.Add(Me.tbTotalCR)
        Me.CustomPanel2.Curvature = 10
        Me.CustomPanel2.Location = New System.Drawing.Point(9, 6)
        Me.CustomPanel2.Name = "CustomPanel2"
        Me.CustomPanel2.Size = New System.Drawing.Size(603, 422)
        Me.CustomPanel2.TabIndex = 62
        '
        'CustomPanel4
        '
        Me.CustomPanel4.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomPanel4.Curvature = 10
        Me.CustomPanel4.CurveMode = CType((Acc_System.CornerCurveMode.TopLeft Or Acc_System.CornerCurveMode.TopRight), Acc_System.CornerCurveMode)
        Me.CustomPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel4.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel4.Name = "CustomPanel4"
        Me.CustomPanel4.Size = New System.Drawing.Size(603, 22)
        Me.CustomPanel4.TabIndex = 62
        '
        'MetroTextBox5
        '
        '
        '
        '
        Me.MetroTextBox5.CustomButton.Image = Nothing
        Me.MetroTextBox5.CustomButton.Location = New System.Drawing.Point(18, 1)
        Me.MetroTextBox5.CustomButton.Name = ""
        Me.MetroTextBox5.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox5.CustomButton.TabIndex = 1
        Me.MetroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox5.CustomButton.UseSelectable = True
        Me.MetroTextBox5.CustomButton.Visible = False
        Me.MetroTextBox5.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox5.Lines = New String(-1) {}
        Me.MetroTextBox5.Location = New System.Drawing.Point(356, 384)
        Me.MetroTextBox5.MaxLength = 32767
        Me.MetroTextBox5.Name = "MetroTextBox5"
        Me.MetroTextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox5.SelectedText = ""
        Me.MetroTextBox5.SelectionLength = 0
        Me.MetroTextBox5.SelectionStart = 0
        Me.MetroTextBox5.Size = New System.Drawing.Size(46, 29)
        Me.MetroTextBox5.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTextBox5.TabIndex = 61
        Me.MetroTextBox5.UseSelectable = True
        Me.MetroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox5.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tbTotalBalance
        '
        '
        '
        '
        Me.tbTotalBalance.CustomButton.Image = Nothing
        Me.tbTotalBalance.CustomButton.Location = New System.Drawing.Point(112, 1)
        Me.tbTotalBalance.CustomButton.Name = ""
        Me.tbTotalBalance.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbTotalBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbTotalBalance.CustomButton.TabIndex = 1
        Me.tbTotalBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbTotalBalance.CustomButton.UseSelectable = True
        Me.tbTotalBalance.CustomButton.Visible = False
        Me.tbTotalBalance.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbTotalBalance.Lines = New String(-1) {}
        Me.tbTotalBalance.Location = New System.Drawing.Point(408, 383)
        Me.tbTotalBalance.MaxLength = 32767
        Me.tbTotalBalance.Name = "tbTotalBalance"
        Me.tbTotalBalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTotalBalance.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbTotalBalance.SelectedText = ""
        Me.tbTotalBalance.SelectionLength = 0
        Me.tbTotalBalance.SelectionStart = 0
        Me.tbTotalBalance.Size = New System.Drawing.Size(140, 29)
        Me.tbTotalBalance.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbTotalBalance.TabIndex = 60
        Me.tbTotalBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbTotalBalance.UseSelectable = True
        Me.tbTotalBalance.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbTotalBalance.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tbReference
        '
        '
        '
        '
        Me.tbReference.CustomButton.Image = Nothing
        Me.tbReference.CustomButton.Location = New System.Drawing.Point(112, 1)
        Me.tbReference.CustomButton.Name = ""
        Me.tbReference.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbReference.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbReference.CustomButton.TabIndex = 1
        Me.tbReference.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbReference.CustomButton.UseSelectable = True
        Me.tbReference.CustomButton.Visible = False
        Me.tbReference.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbReference.Lines = New String(-1) {}
        Me.tbReference.Location = New System.Drawing.Point(408, 39)
        Me.tbReference.MaxLength = 32767
        Me.tbReference.Name = "tbReference"
        Me.tbReference.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbReference.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbReference.SelectedText = ""
        Me.tbReference.SelectionLength = 0
        Me.tbReference.SelectionStart = 0
        Me.tbReference.Size = New System.Drawing.Size(140, 29)
        Me.tbReference.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbReference.TabIndex = 31
        Me.tbReference.UseSelectable = True
        Me.tbReference.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbReference.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLink1
        '
        Me.MetroLink1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MetroLink1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroLink1.Image = CType(resources.GetObject("MetroLink1.Image"), System.Drawing.Image)
        Me.MetroLink1.ImageSize = 25
        Me.MetroLink1.Location = New System.Drawing.Point(554, 349)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(43, 30)
        Me.MetroLink1.TabIndex = 59
        Me.MetroLink1.UseCustomBackColor = True
        Me.MetroLink1.UseSelectable = True
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(18, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(356, 39)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.Size = New System.Drawing.Size(46, 29)
        Me.MetroTextBox1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTextBox1.TabIndex = 32
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tbTotalDR
        '
        '
        '
        '
        Me.tbTotalDR.CustomButton.Image = Nothing
        Me.tbTotalDR.CustomButton.Location = New System.Drawing.Point(112, 1)
        Me.tbTotalDR.CustomButton.Name = ""
        Me.tbTotalDR.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbTotalDR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbTotalDR.CustomButton.TabIndex = 1
        Me.tbTotalDR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbTotalDR.CustomButton.UseSelectable = True
        Me.tbTotalDR.CustomButton.Visible = False
        Me.tbTotalDR.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbTotalDR.Lines = New String(-1) {}
        Me.tbTotalDR.Location = New System.Drawing.Point(262, 349)
        Me.tbTotalDR.MaxLength = 32767
        Me.tbTotalDR.Name = "tbTotalDR"
        Me.tbTotalDR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTotalDR.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbTotalDR.SelectedText = ""
        Me.tbTotalDR.SelectionLength = 0
        Me.tbTotalDR.SelectionStart = 0
        Me.tbTotalDR.Size = New System.Drawing.Size(140, 29)
        Me.tbTotalDR.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbTotalDR.TabIndex = 34
        Me.tbTotalDR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbTotalDR.UseSelectable = True
        Me.tbTotalDR.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbTotalDR.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel9.Location = New System.Drawing.Point(193, 43)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(157, 25)
        Me.MetroLabel9.TabIndex = 22
        Me.MetroLabel9.Text = "Opening Balance : "
        Me.MetroLabel9.UseCustomBackColor = True
        '
        'tbTotalCR
        '
        '
        '
        '
        Me.tbTotalCR.CustomButton.Image = Nothing
        Me.tbTotalCR.CustomButton.Location = New System.Drawing.Point(112, 1)
        Me.tbTotalCR.CustomButton.Name = ""
        Me.tbTotalCR.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbTotalCR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbTotalCR.CustomButton.TabIndex = 1
        Me.tbTotalCR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbTotalCR.CustomButton.UseSelectable = True
        Me.tbTotalCR.CustomButton.Visible = False
        Me.tbTotalCR.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbTotalCR.Lines = New String(-1) {}
        Me.tbTotalCR.Location = New System.Drawing.Point(408, 349)
        Me.tbTotalCR.MaxLength = 32767
        Me.tbTotalCR.Name = "tbTotalCR"
        Me.tbTotalCR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTotalCR.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbTotalCR.SelectedText = ""
        Me.tbTotalCR.SelectionLength = 0
        Me.tbTotalCR.SelectionStart = 0
        Me.tbTotalCR.Size = New System.Drawing.Size(140, 29)
        Me.tbTotalCR.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbTotalCR.TabIndex = 33
        Me.tbTotalCR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbTotalCR.UseSelectable = True
        Me.tbTotalCR.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbTotalCR.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TbAccountsTableAdapter
        '
        Me.TbAccountsTableAdapter.ClearBeforeFill = True
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
        'pnlLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "pnlLedger"
        Me.Size = New System.Drawing.Size(1200, 643)
        CType(Me.dgLedger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmVoucher.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.mtcVouchers.ResumeLayout(False)
        Me.tabSales.ResumeLayout(False)
        Me.tabSales.PerformLayout()
        CType(Me.dgInvItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACCDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel2.ResumeLayout(False)
        Me.CustomPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.CustomPanel2.ResumeLayout(False)
        Me.CustomPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgLedger As MetroFramework.Controls.MetroGrid
    Friend WithEvents cmVoucher As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents cmsEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtEnd As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cbVoucherType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dtStart As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnRun As MetroFramework.Controls.MetroButton
    Friend WithEvents mtcVouchers As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabSales As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnPrint As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNarration As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblQuotation As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNet As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblDiscount As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCostCenter As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCustomer As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblInvNo As System.Windows.Forms.Label
    Friend WithEvents tabPurchase As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabJournal As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabPayment As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabTransfer As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabDefault As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents tbTotalDR As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbTotalCR As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbReference As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TbAccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACCDBDataSet As Acc_System.ACCDBDataSet
    Friend WithEvents TbAccountsTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbAccountsTableAdapter
    Friend WithEvents TbAccountTransTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbAccountTransTableAdapter
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgInvItem As System.Windows.Forms.DataGridView
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tbAccount As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox5 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbTotalBalance As MetroFramework.Controls.MetroTextBox
    Friend WithEvents TbVoucherTransTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbVoucherTransTableAdapter
    Friend WithEvents TbItemTransTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbItemTransTableAdapter
    Friend WithEvents CustomPanel1 As Acc_System.CustomPanel
    Friend WithEvents CustomPanel2 As Acc_System.CustomPanel
    Friend WithEvents CustomPanel3 As Acc_System.CustomPanel
    Friend WithEvents CustomPanel4 As Acc_System.CustomPanel

End Class
