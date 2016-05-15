<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlDaybook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pnlDaybook))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mtcVouchers = New MetroFramework.Controls.MetroTabControl()
        Me.tabSales = New MetroFramework.Controls.MetroTabPage()
        Me.btnPrint = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.dgInIvtem = New System.Windows.Forms.DataGridView()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
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
        Me.CustomPanel1 = New Acc_System.CustomPanel()
        Me.dgDayBook = New MetroFramework.Controls.MetroGrid()
        Me.CustomPanel2 = New Acc_System.CustomPanel()
        Me.CustomPanel5 = New Acc_System.CustomPanel()
        Me.dtStart = New MetroFramework.Controls.MetroDateTime()
        Me.btnRun = New MetroFramework.Controls.MetroButton()
        Me.CustomPanel6 = New Acc_System.CustomPanel()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.mtcVouchers.SuspendLayout()
        Me.tabSales.SuspendLayout()
        CType(Me.dgInIvtem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomPanel1.SuspendLayout()
        CType(Me.dgDayBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.mtcVouchers)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(604, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(596, 643)
        Me.Panel1.TabIndex = 68
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
        Me.mtcVouchers.SelectedIndex = 0
        Me.mtcVouchers.Size = New System.Drawing.Size(576, 598)
        Me.mtcVouchers.Style = MetroFramework.MetroColorStyle.Orange
        Me.mtcVouchers.TabIndex = 0
        Me.mtcVouchers.UseCustomBackColor = True
        Me.mtcVouchers.UseSelectable = True
        '
        'tabSales
        '
        Me.tabSales.Controls.Add(Me.btnPrint)
        Me.tabSales.Controls.Add(Me.MetroLabel6)
        Me.tabSales.Controls.Add(Me.dgInIvtem)
        Me.tabSales.Controls.Add(Me.MetroLabel7)
        Me.tabSales.Controls.Add(Me.MetroLabel8)
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgInIvtem.DefaultCellStyle = DataGridViewCellStyle4
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column20.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column20.HeaderText = "Total"
        Me.Column20.Name = "Column20"
        Me.Column20.ReadOnly = True
        Me.Column20.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Column20.Width = 90
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
        Me.lblInvNo.Location = New System.Drawing.Point(3, 4)
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
        Me.tabPurchase.Size = New System.Drawing.Size(568, 556)
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
        Me.tabJournal.Size = New System.Drawing.Size(568, 556)
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
        Me.tabPayment.Size = New System.Drawing.Size(568, 556)
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
        Me.tabTransfer.Size = New System.Drawing.Size(568, 556)
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
        Me.tabDefault.Size = New System.Drawing.Size(568, 556)
        Me.tabDefault.TabIndex = 8
        Me.tabDefault.Text = "Default"
        Me.tabDefault.VerticalScrollbarBarColor = True
        Me.tabDefault.VerticalScrollbarHighlightOnWheel = False
        Me.tabDefault.VerticalScrollbarSize = 10
        '
        'CustomPanel1
        '
        Me.CustomPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomPanel1.Controls.Add(Me.dgDayBook)
        Me.CustomPanel1.Controls.Add(Me.CustomPanel2)
        Me.CustomPanel1.Curvature = 10
        Me.CustomPanel1.Location = New System.Drawing.Point(7, 126)
        Me.CustomPanel1.Name = "CustomPanel1"
        Me.CustomPanel1.Size = New System.Drawing.Size(591, 499)
        Me.CustomPanel1.TabIndex = 67
        '
        'dgDayBook
        '
        Me.dgDayBook.AllowUserToAddRows = False
        Me.dgDayBook.AllowUserToDeleteRows = False
        Me.dgDayBook.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.dgDayBook.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgDayBook.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDayBook.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgDayBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgDayBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDayBook.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgDayBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDayBook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column4, Me.Column5})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = Nothing
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgDayBook.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgDayBook.EnableHeadersVisualStyles = False
        Me.dgDayBook.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgDayBook.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgDayBook.Location = New System.Drawing.Point(8, 30)
        Me.dgDayBook.MultiSelect = False
        Me.dgDayBook.Name = "dgDayBook"
        Me.dgDayBook.ReadOnly = True
        Me.dgDayBook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgDayBook.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgDayBook.RowHeadersVisible = False
        Me.dgDayBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgDayBook.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgDayBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDayBook.Size = New System.Drawing.Size(575, 449)
        Me.dgDayBook.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgDayBook.TabIndex = 45
        '
        'CustomPanel2
        '
        Me.CustomPanel2.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomPanel2.Curvature = 10
        Me.CustomPanel2.CurveMode = CType((Acc_System.CornerCurveMode.TopLeft Or Acc_System.CornerCurveMode.TopRight), Acc_System.CornerCurveMode)
        Me.CustomPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel2.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel2.Name = "CustomPanel2"
        Me.CustomPanel2.Size = New System.Drawing.Size(591, 23)
        Me.CustomPanel2.TabIndex = 44
        '
        'CustomPanel5
        '
        Me.CustomPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomPanel5.Controls.Add(Me.dtStart)
        Me.CustomPanel5.Controls.Add(Me.btnRun)
        Me.CustomPanel5.Controls.Add(Me.CustomPanel6)
        Me.CustomPanel5.Curvature = 10
        Me.CustomPanel5.Location = New System.Drawing.Point(7, 12)
        Me.CustomPanel5.Name = "CustomPanel5"
        Me.CustomPanel5.Size = New System.Drawing.Size(236, 108)
        Me.CustomPanel5.TabIndex = 66
        '
        'dtStart
        '
        Me.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtStart.Location = New System.Drawing.Point(11, 29)
        Me.dtStart.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtStart.Name = "dtStart"
        Me.dtStart.Size = New System.Drawing.Size(214, 29)
        Me.dtStart.TabIndex = 45
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(126, 64)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(99, 28)
        Me.btnRun.TabIndex = 47
        Me.btnRun.Text = "Run"
        Me.btnRun.UseSelectable = True
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
        'Column2
        '
        Me.Column2.HeaderText = "Vch No"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Vch Type"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 200
        '
        'Column5
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column5.HeaderText = "Amount"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 130
        '
        'pnlDaybook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CustomPanel1)
        Me.Controls.Add(Me.CustomPanel5)
        Me.Name = "pnlDaybook"
        Me.Size = New System.Drawing.Size(1200, 643)
        Me.UseCustomBackColor = True
        Me.Panel1.ResumeLayout(False)
        Me.mtcVouchers.ResumeLayout(False)
        Me.tabSales.ResumeLayout(False)
        Me.tabSales.PerformLayout()
        CType(Me.dgInIvtem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomPanel1.ResumeLayout(False)
        CType(Me.dgDayBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomPanel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CustomPanel5 As Acc_System.CustomPanel
    Friend WithEvents CustomPanel6 As Acc_System.CustomPanel
    Friend WithEvents dtStart As MetroFramework.Controls.MetroDateTime
    Friend WithEvents btnRun As MetroFramework.Controls.MetroButton
    Friend WithEvents CustomPanel1 As Acc_System.CustomPanel
    Friend WithEvents CustomPanel2 As Acc_System.CustomPanel
    Friend WithEvents dgDayBook As MetroFramework.Controls.MetroGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents mtcVouchers As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabSales As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnPrint As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgInIvtem As System.Windows.Forms.DataGridView
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column20 As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
