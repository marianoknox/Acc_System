<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlSalesView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pnlSalesView))
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlEditMode = New System.Windows.Forms.Panel()
        Me.btnCancelEdit = New MetroFramework.Controls.MetroLink()
        Me.tbItemSearch = New MetroFramework.Controls.MetroTextBox()
        Me.dgItemSelect = New MetroFramework.Controls.MetroGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSaveInv = New MetroFramework.Controls.MetroLink()
        Me.tbQuantitySelect = New MetroFramework.Controls.MetroTextBox()
        Me.lblAccDiscount = New MetroFramework.Controls.MetroLabel()
        Me.btnAccept = New MetroFramework.Controls.MetroButton()
        Me.pnlItemsInv = New System.Windows.Forms.Panel()
        Me.btnHideSelection = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.dgInvItem = New MetroFramework.Controls.MetroGrid()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmInv = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.cmsEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnRollDown = New MetroFramework.Controls.MetroLink()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblInvNo = New System.Windows.Forms.Label()
        Me.tbNarration = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLink8 = New MetroFramework.Controls.MetroLink()
        Me.btnPrint = New MetroFramework.Controls.MetroLink()
        Me.tbNetAmount = New MetroFramework.Controls.MetroTextBox()
        Me.tbDiscAmt = New MetroFramework.Controls.MetroTextBox()
        Me.tbDiscPerc = New MetroFramework.Controls.MetroTextBox()
        Me.tbTotalPrice = New MetroFramework.Controls.MetroTextBox()
        Me.btnRollUp = New MetroFramework.Controls.MetroLink()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tbCustomer = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.lblLimit = New MetroFramework.Controls.MetroLabel()
        Me.lblCusBalance = New MetroFramework.Controls.MetroLabel()
        Me.lblDays = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.tbQuotaion = New MetroFramework.Controls.MetroTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlAccDetails = New System.Windows.Forms.Panel()
        Me.MetroLink2 = New MetroFramework.Controls.MetroLink()
        Me.cbAccRevenue = New MetroFramework.Controls.MetroComboBox()
        Me.lnkDetails = New MetroFramework.Controls.MetroLink()
        Me.btnShowSelection = New MetroFramework.Controls.MetroLink()
        Me.tbLPO = New MetroFramework.Controls.MetroTextBox()
        Me.tbReference = New MetroFramework.Controls.MetroTextBox()
        Me.dtInvDate = New MetroFramework.Controls.MetroDateTime()
        Me.cbCustomer = New MetroFramework.Controls.MetroComboBox()
        Me.cbCostCenter = New MetroFramework.Controls.MetroComboBox()
        Me.cbVoucherType = New MetroFramework.Controls.MetroComboBox()
        Me.TbVoucherTransTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbVoucherTransTableAdapter()
        Me.ACCDBDataSet = New Acc_System.ACCDBDataSet()
        Me.TbVouchersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbVouchersTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbVouchersTableAdapter()
        Me.TbCostCenterListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbCostCenterListTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbCostCenterListTableAdapter()
        Me.TbAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbAccountsTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbAccountsTableAdapter()
        Me.pnlEditMode.SuspendLayout()
        CType(Me.dgItemSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlItemsInv.SuspendLayout()
        CType(Me.dgInvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmInv.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlAccDetails.SuspendLayout()
        CType(Me.ACCDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbVouchersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCostCenterListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlEditMode
        '
        Me.pnlEditMode.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlEditMode.Controls.Add(Me.btnCancelEdit)
        Me.pnlEditMode.Location = New System.Drawing.Point(-292, 78)
        Me.pnlEditMode.Name = "pnlEditMode"
        Me.pnlEditMode.Size = New System.Drawing.Size(174, 47)
        Me.pnlEditMode.TabIndex = 19
        Me.pnlEditMode.Visible = False
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
        'dgItemSelect
        '
        Me.dgItemSelect.AllowUserToAddRows = False
        Me.dgItemSelect.AllowUserToDeleteRows = False
        Me.dgItemSelect.AllowUserToResizeRows = False
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgItemSelect.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgItemSelect.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgItemSelect.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgItemSelect.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgItemSelect.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgItemSelect.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgItemSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgItemSelect.DefaultCellStyle = DataGridViewCellStyle19
        Me.dgItemSelect.EnableHeadersVisualStyles = False
        Me.dgItemSelect.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgItemSelect.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgItemSelect.Location = New System.Drawing.Point(10, 50)
        Me.dgItemSelect.MultiSelect = False
        Me.dgItemSelect.Name = "dgItemSelect"
        Me.dgItemSelect.ReadOnly = True
        Me.dgItemSelect.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgItemSelect.RowHeadersDefaultCellStyle = DataGridViewCellStyle20
        Me.dgItemSelect.RowHeadersVisible = False
        Me.dgItemSelect.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgItemSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgItemSelect.Size = New System.Drawing.Size(629, 293)
        Me.dgItemSelect.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgItemSelect.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(416, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 34)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Quick Info : You can only sell items" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "under default location."
        '
        'btnSaveInv
        '
        Me.btnSaveInv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveInv.Image = CType(resources.GetObject("btnSaveInv.Image"), System.Drawing.Image)
        Me.btnSaveInv.ImageSize = 25
        Me.btnSaveInv.Location = New System.Drawing.Point(1152, 80)
        Me.btnSaveInv.Name = "btnSaveInv"
        Me.btnSaveInv.NoFocusImage = CType(resources.GetObject("btnSaveInv.NoFocusImage"), System.Drawing.Image)
        Me.btnSaveInv.Size = New System.Drawing.Size(43, 30)
        Me.btnSaveInv.TabIndex = 33
        Me.btnSaveInv.UseSelectable = True
        '
        'tbQuantitySelect
        '
        '
        '
        '
        Me.tbQuantitySelect.CustomButton.Image = Nothing
        Me.tbQuantitySelect.CustomButton.Location = New System.Drawing.Point(186, 2)
        Me.tbQuantitySelect.CustomButton.Name = ""
        Me.tbQuantitySelect.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.tbQuantitySelect.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbQuantitySelect.CustomButton.TabIndex = 1
        Me.tbQuantitySelect.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbQuantitySelect.CustomButton.UseSelectable = True
        Me.tbQuantitySelect.CustomButton.Visible = False
        Me.tbQuantitySelect.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbQuantitySelect.Lines = New String() {"0"}
        Me.tbQuantitySelect.Location = New System.Drawing.Point(10, 361)
        Me.tbQuantitySelect.MaxLength = 32767
        Me.tbQuantitySelect.Name = "tbQuantitySelect"
        Me.tbQuantitySelect.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbQuantitySelect.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbQuantitySelect.SelectedText = ""
        Me.tbQuantitySelect.SelectionLength = 0
        Me.tbQuantitySelect.SelectionStart = 0
        Me.tbQuantitySelect.Size = New System.Drawing.Size(214, 30)
        Me.tbQuantitySelect.TabIndex = 23
        Me.tbQuantitySelect.Text = "0"
        Me.tbQuantitySelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbQuantitySelect.UseSelectable = True
        Me.tbQuantitySelect.WaterMark = "Quantity"
        Me.tbQuantitySelect.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbQuantitySelect.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblAccDiscount
        '
        Me.lblAccDiscount.AutoSize = True
        Me.lblAccDiscount.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblAccDiscount.Location = New System.Drawing.Point(816, 49)
        Me.lblAccDiscount.Name = "lblAccDiscount"
        Me.lblAccDiscount.Size = New System.Drawing.Size(121, 25)
        Me.lblAccDiscount.TabIndex = 29
        Me.lblAccDiscount.Text = "Sales Discount"
        '
        'btnAccept
        '
        Me.btnAccept.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAccept.Location = New System.Drawing.Point(230, 361)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(69, 30)
        Me.btnAccept.TabIndex = 22
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseSelectable = True
        '
        'pnlItemsInv
        '
        Me.pnlItemsInv.BackColor = System.Drawing.Color.White
        Me.pnlItemsInv.Controls.Add(Me.Label1)
        Me.pnlItemsInv.Controls.Add(Me.tbQuantitySelect)
        Me.pnlItemsInv.Controls.Add(Me.btnAccept)
        Me.pnlItemsInv.Controls.Add(Me.dgItemSelect)
        Me.pnlItemsInv.Controls.Add(Me.tbItemSearch)
        Me.pnlItemsInv.Controls.Add(Me.btnHideSelection)
        Me.pnlItemsInv.Location = New System.Drawing.Point(1200, 120)
        Me.pnlItemsInv.Name = "pnlItemsInv"
        Me.pnlItemsInv.Size = New System.Drawing.Size(650, 408)
        Me.pnlItemsInv.TabIndex = 17
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
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel12.Location = New System.Drawing.Point(898, 85)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(53, 25)
        Me.MetroLabel12.TabIndex = 30
        Me.MetroLabel12.Text = "Net : "
        '
        'dgInvItem
        '
        Me.dgInvItem.AllowUserToAddRows = False
        Me.dgInvItem.AllowUserToDeleteRows = False
        Me.dgInvItem.AllowUserToResizeRows = False
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgInvItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle27
        Me.dgInvItem.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgInvItem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgInvItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgInvItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgInvItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle28
        Me.dgInvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgInvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgInvItem.ContextMenuStrip = Me.cmInv
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgInvItem.DefaultCellStyle = DataGridViewCellStyle31
        Me.dgInvItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgInvItem.EnableHeadersVisualStyles = False
        Me.dgInvItem.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgInvItem.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgInvItem.Location = New System.Drawing.Point(27, 80)
        Me.dgInvItem.MultiSelect = False
        Me.dgInvItem.Name = "dgInvItem"
        Me.dgInvItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle32.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgInvItem.RowHeadersDefaultCellStyle = DataGridViewCellStyle32
        Me.dgInvItem.RowHeadersVisible = False
        Me.dgInvItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgInvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgInvItem.Size = New System.Drawing.Size(1173, 447)
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
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle29
        Me.Column5.HeaderText = "Price"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle30
        Me.Column6.HeaderText = "Total"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 200
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
        'btnRollDown
        '
        Me.btnRollDown.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRollDown.Image = CType(resources.GetObject("btnRollDown.Image"), System.Drawing.Image)
        Me.btnRollDown.ImageSize = 20
        Me.btnRollDown.Location = New System.Drawing.Point(3, 6)
        Me.btnRollDown.Name = "btnRollDown"
        Me.btnRollDown.NoFocusImage = CType(resources.GetObject("btnRollDown.NoFocusImage"), System.Drawing.Image)
        Me.btnRollDown.Size = New System.Drawing.Size(21, 24)
        Me.btnRollDown.TabIndex = 61
        Me.btnRollDown.UseSelectable = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel10.Location = New System.Drawing.Point(846, 13)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(106, 25)
        Me.MetroLabel10.TabIndex = 28
        Me.MetroLabel10.Text = "Total Sales : "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnRollDown)
        Me.Panel2.Controls.Add(Me.lblInvNo)
        Me.Panel2.Controls.Add(Me.tbNarration)
        Me.Panel2.Controls.Add(Me.MetroLink8)
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.btnSaveInv)
        Me.Panel2.Controls.Add(Me.MetroLabel12)
        Me.Panel2.Controls.Add(Me.lblAccDiscount)
        Me.Panel2.Controls.Add(Me.MetroLabel10)
        Me.Panel2.Controls.Add(Me.tbNetAmount)
        Me.Panel2.Controls.Add(Me.tbDiscAmt)
        Me.Panel2.Controls.Add(Me.tbDiscPerc)
        Me.Panel2.Controls.Add(Me.tbTotalPrice)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 527)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1200, 116)
        Me.Panel2.TabIndex = 16
        '
        'lblInvNo
        '
        Me.lblInvNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblInvNo.AutoSize = True
        Me.lblInvNo.BackColor = System.Drawing.Color.Transparent
        Me.lblInvNo.Font = New System.Drawing.Font("Segoe UI Light", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvNo.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblInvNo.Location = New System.Drawing.Point(22, 46)
        Me.lblInvNo.Name = "lblInvNo"
        Me.lblInvNo.Size = New System.Drawing.Size(179, 65)
        Me.lblInvNo.TabIndex = 40
        Me.lblInvNo.Text = "CR-001"
        '
        'tbNarration
        '
        '
        '
        '
        Me.tbNarration.CustomButton.Image = Nothing
        Me.tbNarration.CustomButton.Location = New System.Drawing.Point(693, 2)
        Me.tbNarration.CustomButton.Name = ""
        Me.tbNarration.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.tbNarration.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbNarration.CustomButton.TabIndex = 1
        Me.tbNarration.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbNarration.CustomButton.UseSelectable = True
        Me.tbNarration.CustomButton.Visible = False
        Me.tbNarration.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbNarration.Lines = New String(-1) {}
        Me.tbNarration.Location = New System.Drawing.Point(27, 12)
        Me.tbNarration.MaxLength = 32767
        Me.tbNarration.Name = "tbNarration"
        Me.tbNarration.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNarration.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbNarration.SelectedText = ""
        Me.tbNarration.SelectionLength = 0
        Me.tbNarration.SelectionStart = 0
        Me.tbNarration.Size = New System.Drawing.Size(721, 30)
        Me.tbNarration.TabIndex = 38
        Me.tbNarration.UseSelectable = True
        Me.tbNarration.WaterMark = "Narration"
        Me.tbNarration.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbNarration.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLink8
        '
        Me.MetroLink8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroLink8.Image = CType(resources.GetObject("MetroLink8.Image"), System.Drawing.Image)
        Me.MetroLink8.ImageSize = 30
        Me.MetroLink8.Location = New System.Drawing.Point(1154, 4)
        Me.MetroLink8.Name = "MetroLink8"
        Me.MetroLink8.Size = New System.Drawing.Size(37, 34)
        Me.MetroLink8.TabIndex = 26
        Me.MetroLink8.UseSelectable = True
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageSize = 25
        Me.btnPrint.Location = New System.Drawing.Point(1152, 44)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(43, 30)
        Me.btnPrint.TabIndex = 34
        Me.btnPrint.UseSelectable = True
        '
        'tbNetAmount
        '
        Me.tbNetAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tbNetAmount.CustomButton.Image = Nothing
        Me.tbNetAmount.CustomButton.Location = New System.Drawing.Point(165, 2)
        Me.tbNetAmount.CustomButton.Name = ""
        Me.tbNetAmount.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.tbNetAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbNetAmount.CustomButton.TabIndex = 1
        Me.tbNetAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbNetAmount.CustomButton.UseSelectable = True
        Me.tbNetAmount.CustomButton.Visible = False
        Me.tbNetAmount.Enabled = False
        Me.tbNetAmount.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbNetAmount.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.tbNetAmount.Lines = New String() {"0"}
        Me.tbNetAmount.Location = New System.Drawing.Point(953, 80)
        Me.tbNetAmount.MaxLength = 32767
        Me.tbNetAmount.Name = "tbNetAmount"
        Me.tbNetAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNetAmount.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbNetAmount.SelectedText = ""
        Me.tbNetAmount.SelectionLength = 0
        Me.tbNetAmount.SelectionStart = 0
        Me.tbNetAmount.Size = New System.Drawing.Size(193, 30)
        Me.tbNetAmount.TabIndex = 9
        Me.tbNetAmount.Text = "0"
        Me.tbNetAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbNetAmount.UseSelectable = True
        Me.tbNetAmount.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbNetAmount.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tbDiscAmt
        '
        Me.tbDiscAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tbDiscAmt.CustomButton.Image = Nothing
        Me.tbDiscAmt.CustomButton.Location = New System.Drawing.Point(102, 2)
        Me.tbDiscAmt.CustomButton.Name = ""
        Me.tbDiscAmt.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.tbDiscAmt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbDiscAmt.CustomButton.TabIndex = 1
        Me.tbDiscAmt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbDiscAmt.CustomButton.UseSelectable = True
        Me.tbDiscAmt.CustomButton.Visible = False
        Me.tbDiscAmt.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbDiscAmt.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.tbDiscAmt.Lines = New String() {"0"}
        Me.tbDiscAmt.Location = New System.Drawing.Point(1016, 44)
        Me.tbDiscAmt.MaxLength = 32767
        Me.tbDiscAmt.Name = "tbDiscAmt"
        Me.tbDiscAmt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbDiscAmt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbDiscAmt.SelectedText = ""
        Me.tbDiscAmt.SelectionLength = 0
        Me.tbDiscAmt.SelectionStart = 0
        Me.tbDiscAmt.Size = New System.Drawing.Size(130, 30)
        Me.tbDiscAmt.TabIndex = 8
        Me.tbDiscAmt.Text = "0"
        Me.tbDiscAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbDiscAmt.UseSelectable = True
        Me.tbDiscAmt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbDiscAmt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tbDiscPerc
        '
        Me.tbDiscPerc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tbDiscPerc.CustomButton.Image = Nothing
        Me.tbDiscPerc.CustomButton.Location = New System.Drawing.Point(29, 2)
        Me.tbDiscPerc.CustomButton.Name = ""
        Me.tbDiscPerc.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.tbDiscPerc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbDiscPerc.CustomButton.TabIndex = 1
        Me.tbDiscPerc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbDiscPerc.CustomButton.UseSelectable = True
        Me.tbDiscPerc.CustomButton.Visible = False
        Me.tbDiscPerc.Enabled = False
        Me.tbDiscPerc.Lines = New String(-1) {}
        Me.tbDiscPerc.Location = New System.Drawing.Point(953, 44)
        Me.tbDiscPerc.MaxLength = 32767
        Me.tbDiscPerc.Name = "tbDiscPerc"
        Me.tbDiscPerc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbDiscPerc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbDiscPerc.SelectedText = ""
        Me.tbDiscPerc.SelectionLength = 0
        Me.tbDiscPerc.SelectionStart = 0
        Me.tbDiscPerc.Size = New System.Drawing.Size(57, 30)
        Me.tbDiscPerc.TabIndex = 7
        Me.tbDiscPerc.UseSelectable = True
        Me.tbDiscPerc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbDiscPerc.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tbTotalPrice
        '
        Me.tbTotalPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tbTotalPrice.CustomButton.Image = Nothing
        Me.tbTotalPrice.CustomButton.Location = New System.Drawing.Point(165, 2)
        Me.tbTotalPrice.CustomButton.Name = ""
        Me.tbTotalPrice.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.tbTotalPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbTotalPrice.CustomButton.TabIndex = 1
        Me.tbTotalPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbTotalPrice.CustomButton.UseSelectable = True
        Me.tbTotalPrice.CustomButton.Visible = False
        Me.tbTotalPrice.Enabled = False
        Me.tbTotalPrice.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbTotalPrice.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.tbTotalPrice.Lines = New String() {"0"}
        Me.tbTotalPrice.Location = New System.Drawing.Point(953, 8)
        Me.tbTotalPrice.MaxLength = 32767
        Me.tbTotalPrice.Name = "tbTotalPrice"
        Me.tbTotalPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTotalPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbTotalPrice.SelectedText = ""
        Me.tbTotalPrice.SelectionLength = 0
        Me.tbTotalPrice.SelectionStart = 0
        Me.tbTotalPrice.Size = New System.Drawing.Size(193, 30)
        Me.tbTotalPrice.TabIndex = 6
        Me.tbTotalPrice.Text = "0"
        Me.tbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbTotalPrice.UseSelectable = True
        Me.tbTotalPrice.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbTotalPrice.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnRollUp
        '
        Me.btnRollUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRollUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRollUp.Image = CType(resources.GetObject("btnRollUp.Image"), System.Drawing.Image)
        Me.btnRollUp.ImageSize = 20
        Me.btnRollUp.Location = New System.Drawing.Point(3, 421)
        Me.btnRollUp.Name = "btnRollUp"
        Me.btnRollUp.NoFocusImage = CType(resources.GetObject("btnRollUp.NoFocusImage"), System.Drawing.Image)
        Me.btnRollUp.Size = New System.Drawing.Size(21, 23)
        Me.btnRollUp.TabIndex = 62
        Me.btnRollUp.UseSelectable = True
        Me.btnRollUp.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.btnRollUp)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 80)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(27, 447)
        Me.Panel3.TabIndex = 20
        '
        'tbCustomer
        '
        '
        '
        '
        Me.tbCustomer.CustomButton.Image = Nothing
        Me.tbCustomer.CustomButton.Location = New System.Drawing.Point(156, 1)
        Me.tbCustomer.CustomButton.Name = ""
        Me.tbCustomer.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbCustomer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbCustomer.CustomButton.TabIndex = 1
        Me.tbCustomer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbCustomer.CustomButton.UseSelectable = True
        Me.tbCustomer.CustomButton.Visible = False
        Me.tbCustomer.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbCustomer.Lines = New String(-1) {}
        Me.tbCustomer.Location = New System.Drawing.Point(511, 8)
        Me.tbCustomer.MaxLength = 32767
        Me.tbCustomer.Name = "tbCustomer"
        Me.tbCustomer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbCustomer.SelectedText = ""
        Me.tbCustomer.SelectionLength = 0
        Me.tbCustomer.SelectionStart = 0
        Me.tbCustomer.Size = New System.Drawing.Size(184, 29)
        Me.tbCustomer.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbCustomer.TabIndex = 42
        Me.tbCustomer.UseSelectable = True
        Me.tbCustomer.WaterMark = "Customer"
        Me.tbCustomer.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbCustomer.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(2, 6)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(85, 25)
        Me.MetroLabel4.TabIndex = 19
        Me.MetroLabel4.Text = "Balance : "
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.Location = New System.Drawing.Point(3, 37)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(62, 25)
        Me.MetroLabel7.TabIndex = 22
        Me.MetroLabel7.Text = "Limit : "
        '
        'lblLimit
        '
        Me.lblLimit.AutoSize = True
        Me.lblLimit.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblLimit.Location = New System.Drawing.Point(61, 38)
        Me.lblLimit.Name = "lblLimit"
        Me.lblLimit.Size = New System.Drawing.Size(57, 25)
        Me.lblLimit.TabIndex = 40
        Me.lblLimit.Text = "20000"
        '
        'lblCusBalance
        '
        Me.lblCusBalance.AutoSize = True
        Me.lblCusBalance.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblCusBalance.Location = New System.Drawing.Point(82, 6)
        Me.lblCusBalance.Name = "lblCusBalance"
        Me.lblCusBalance.Size = New System.Drawing.Size(57, 25)
        Me.lblCusBalance.TabIndex = 41
        Me.lblCusBalance.Text = "20000"
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblDays.Location = New System.Drawing.Point(265, 38)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(30, 25)
        Me.lblDays.TabIndex = 39
        Me.lblDays.Text = "30"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(206, 38)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(62, 25)
        Me.MetroLabel1.TabIndex = 37
        Me.MetroLabel1.Text = "Days : "
        '
        'tbQuotaion
        '
        '
        '
        '
        Me.tbQuotaion.CustomButton.Image = Nothing
        Me.tbQuotaion.CustomButton.Location = New System.Drawing.Point(156, 1)
        Me.tbQuotaion.CustomButton.Name = ""
        Me.tbQuotaion.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbQuotaion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbQuotaion.CustomButton.TabIndex = 1
        Me.tbQuotaion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbQuotaion.CustomButton.UseSelectable = True
        Me.tbQuotaion.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbQuotaion.Lines = New String(-1) {}
        Me.tbQuotaion.Location = New System.Drawing.Point(511, 43)
        Me.tbQuotaion.MaxLength = 32767
        Me.tbQuotaion.Name = "tbQuotaion"
        Me.tbQuotaion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbQuotaion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbQuotaion.SelectedText = ""
        Me.tbQuotaion.SelectionLength = 0
        Me.tbQuotaion.SelectionStart = 0
        Me.tbQuotaion.ShowButton = True
        Me.tbQuotaion.Size = New System.Drawing.Size(184, 29)
        Me.tbQuotaion.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbQuotaion.TabIndex = 38
        Me.tbQuotaion.UseSelectable = True
        Me.tbQuotaion.WaterMark = "Quotation"
        Me.tbQuotaion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbQuotaion.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.pnlAccDetails)
        Me.Panel1.Controls.Add(Me.cbAccRevenue)
        Me.Panel1.Controls.Add(Me.lnkDetails)
        Me.Panel1.Controls.Add(Me.tbCustomer)
        Me.Panel1.Controls.Add(Me.tbQuotaion)
        Me.Panel1.Controls.Add(Me.btnShowSelection)
        Me.Panel1.Controls.Add(Me.tbLPO)
        Me.Panel1.Controls.Add(Me.tbReference)
        Me.Panel1.Controls.Add(Me.dtInvDate)
        Me.Panel1.Controls.Add(Me.cbCustomer)
        Me.Panel1.Controls.Add(Me.cbCostCenter)
        Me.Panel1.Controls.Add(Me.cbVoucherType)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 80)
        Me.Panel1.TabIndex = 15
        '
        'pnlAccDetails
        '
        Me.pnlAccDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAccDetails.BackColor = System.Drawing.Color.White
        Me.pnlAccDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAccDetails.Controls.Add(Me.MetroLink2)
        Me.pnlAccDetails.Controls.Add(Me.lblLimit)
        Me.pnlAccDetails.Controls.Add(Me.lblCusBalance)
        Me.pnlAccDetails.Controls.Add(Me.MetroLabel7)
        Me.pnlAccDetails.Controls.Add(Me.MetroLabel4)
        Me.pnlAccDetails.Controls.Add(Me.lblDays)
        Me.pnlAccDetails.Controls.Add(Me.MetroLabel1)
        Me.pnlAccDetails.Location = New System.Drawing.Point(779, 6)
        Me.pnlAccDetails.Name = "pnlAccDetails"
        Me.pnlAccDetails.Size = New System.Drawing.Size(347, 71)
        Me.pnlAccDetails.TabIndex = 14
        Me.pnlAccDetails.Visible = False
        '
        'MetroLink2
        '
        Me.MetroLink2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroLink2.Image = CType(resources.GetObject("MetroLink2.Image"), System.Drawing.Image)
        Me.MetroLink2.ImageSize = 30
        Me.MetroLink2.Location = New System.Drawing.Point(295, 6)
        Me.MetroLink2.Name = "MetroLink2"
        Me.MetroLink2.Size = New System.Drawing.Size(37, 34)
        Me.MetroLink2.TabIndex = 41
        Me.MetroLink2.UseSelectable = True
        '
        'cbAccRevenue
        '
        Me.cbAccRevenue.FormattingEnabled = True
        Me.cbAccRevenue.ItemHeight = 23
        Me.cbAccRevenue.Items.AddRange(New Object() {"Cash Sales Account", "Credit Sales Account", "Return Sales Account"})
        Me.cbAccRevenue.Location = New System.Drawing.Point(344, 42)
        Me.cbAccRevenue.Name = "cbAccRevenue"
        Me.cbAccRevenue.Size = New System.Drawing.Size(161, 29)
        Me.cbAccRevenue.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbAccRevenue.TabIndex = 41
        Me.cbAccRevenue.UseSelectable = True
        '
        'lnkDetails
        '
        Me.lnkDetails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkDetails.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.lnkDetails.ImageSize = 30
        Me.lnkDetails.Location = New System.Drawing.Point(1089, 43)
        Me.lnkDetails.Name = "lnkDetails"
        Me.lnkDetails.Size = New System.Drawing.Size(37, 29)
        Me.lnkDetails.TabIndex = 43
        Me.lnkDetails.Text = ". . ."
        Me.lnkDetails.UseSelectable = True
        '
        'btnShowSelection
        '
        Me.btnShowSelection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShowSelection.Image = CType(resources.GetObject("btnShowSelection.Image"), System.Drawing.Image)
        Me.btnShowSelection.ImageSize = 30
        Me.btnShowSelection.Location = New System.Drawing.Point(1132, 38)
        Me.btnShowSelection.Name = "btnShowSelection"
        Me.btnShowSelection.NoFocusImage = CType(resources.GetObject("btnShowSelection.NoFocusImage"), System.Drawing.Image)
        Me.btnShowSelection.Size = New System.Drawing.Size(37, 34)
        Me.btnShowSelection.TabIndex = 16
        Me.btnShowSelection.UseSelectable = True
        '
        'tbLPO
        '
        '
        '
        '
        Me.tbLPO.CustomButton.Image = Nothing
        Me.tbLPO.CustomButton.Location = New System.Drawing.Point(156, 1)
        Me.tbLPO.CustomButton.Name = ""
        Me.tbLPO.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbLPO.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbLPO.CustomButton.TabIndex = 1
        Me.tbLPO.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbLPO.CustomButton.UseSelectable = True
        Me.tbLPO.CustomButton.Visible = False
        Me.tbLPO.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbLPO.Lines = New String(-1) {}
        Me.tbLPO.Location = New System.Drawing.Point(701, 43)
        Me.tbLPO.MaxLength = 32767
        Me.tbLPO.Name = "tbLPO"
        Me.tbLPO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbLPO.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbLPO.SelectedText = ""
        Me.tbLPO.SelectionLength = 0
        Me.tbLPO.SelectionStart = 0
        Me.tbLPO.Size = New System.Drawing.Size(184, 29)
        Me.tbLPO.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbLPO.TabIndex = 5
        Me.tbLPO.UseSelectable = True
        Me.tbLPO.WaterMark = "LPO"
        Me.tbLPO.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbLPO.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tbReference
        '
        '
        '
        '
        Me.tbReference.CustomButton.Image = Nothing
        Me.tbReference.CustomButton.Location = New System.Drawing.Point(133, 1)
        Me.tbReference.CustomButton.Name = ""
        Me.tbReference.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbReference.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbReference.CustomButton.TabIndex = 1
        Me.tbReference.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbReference.CustomButton.UseSelectable = True
        Me.tbReference.CustomButton.Visible = False
        Me.tbReference.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbReference.Lines = New String(-1) {}
        Me.tbReference.Location = New System.Drawing.Point(344, 8)
        Me.tbReference.MaxLength = 32767
        Me.tbReference.Name = "tbReference"
        Me.tbReference.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbReference.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbReference.SelectedText = ""
        Me.tbReference.SelectionLength = 0
        Me.tbReference.SelectionStart = 0
        Me.tbReference.Size = New System.Drawing.Size(161, 29)
        Me.tbReference.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbReference.TabIndex = 4
        Me.tbReference.UseSelectable = True
        Me.tbReference.WaterMark = "Reference"
        Me.tbReference.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbReference.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dtInvDate
        '
        Me.dtInvDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInvDate.Location = New System.Drawing.Point(891, 43)
        Me.dtInvDate.MinimumSize = New System.Drawing.Size(4, 29)
        Me.dtInvDate.Name = "dtInvDate"
        Me.dtInvDate.Size = New System.Drawing.Size(184, 29)
        Me.dtInvDate.Style = MetroFramework.MetroColorStyle.Teal
        Me.dtInvDate.TabIndex = 3
        '
        'cbCustomer
        '
        Me.cbCustomer.DataSource = Me.TbAccountsBindingSource
        Me.cbCustomer.DisplayMember = "Account_Name"
        Me.cbCustomer.FormattingEnabled = True
        Me.cbCustomer.ItemHeight = 23
        Me.cbCustomer.Location = New System.Drawing.Point(701, 8)
        Me.cbCustomer.Name = "cbCustomer"
        Me.cbCustomer.Size = New System.Drawing.Size(468, 29)
        Me.cbCustomer.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbCustomer.TabIndex = 2
        Me.cbCustomer.UseSelectable = True
        '
        'cbCostCenter
        '
        Me.cbCostCenter.DataSource = Me.TbCostCenterListBindingSource
        Me.cbCostCenter.DisplayMember = "Cost_Center"
        Me.cbCostCenter.FormattingEnabled = True
        Me.cbCostCenter.ItemHeight = 23
        Me.cbCostCenter.Location = New System.Drawing.Point(27, 42)
        Me.cbCostCenter.Name = "cbCostCenter"
        Me.cbCostCenter.Size = New System.Drawing.Size(311, 29)
        Me.cbCostCenter.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbCostCenter.TabIndex = 1
        Me.cbCostCenter.UseSelectable = True
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
        'TbVoucherTransTableAdapter
        '
        Me.TbVoucherTransTableAdapter.ClearBeforeFill = True
        '
        'ACCDBDataSet
        '
        Me.ACCDBDataSet.DataSetName = "ACCDBDataSet"
        Me.ACCDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TbCostCenterListBindingSource
        '
        Me.TbCostCenterListBindingSource.DataMember = "tbCostCenterList"
        Me.TbCostCenterListBindingSource.DataSource = Me.ACCDBDataSet
        '
        'TbCostCenterListTableAdapter
        '
        Me.TbCostCenterListTableAdapter.ClearBeforeFill = True
        '
        'TbAccountsBindingSource
        '
        Me.TbAccountsBindingSource.DataMember = "tbAccounts"
        Me.TbAccountsBindingSource.DataSource = Me.ACCDBDataSet
        '
        'TbAccountsTableAdapter
        '
        Me.TbAccountsTableAdapter.ClearBeforeFill = True
        '
        'pnlSalesView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgInvItem)
        Me.Controls.Add(Me.pnlItemsInv)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnlEditMode)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "pnlSalesView"
        Me.Size = New System.Drawing.Size(1200, 643)
        Me.pnlEditMode.ResumeLayout(False)
        CType(Me.dgItemSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlItemsInv.ResumeLayout(False)
        Me.pnlItemsInv.PerformLayout()
        CType(Me.dgInvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmInv.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.pnlAccDetails.ResumeLayout(False)
        Me.pnlAccDetails.PerformLayout()
        CType(Me.ACCDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbVouchersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCostCenterListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlEditMode As System.Windows.Forms.Panel
    Friend WithEvents btnCancelEdit As MetroFramework.Controls.MetroLink
    Friend WithEvents tbItemSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dgItemSelect As MetroFramework.Controls.MetroGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSaveInv As MetroFramework.Controls.MetroLink
    Friend WithEvents tbQuantitySelect As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblAccDiscount As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnAccept As MetroFramework.Controls.MetroButton
    Friend WithEvents pnlItemsInv As System.Windows.Forms.Panel
    Friend WithEvents btnHideSelection As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgInvItem As MetroFramework.Controls.MetroGrid
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmInv As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents cmsEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRollDown As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblInvNo As System.Windows.Forms.Label
    Friend WithEvents tbNarration As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLink8 As MetroFramework.Controls.MetroLink
    Friend WithEvents btnPrint As MetroFramework.Controls.MetroLink
    Friend WithEvents tbNetAmount As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbDiscAmt As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbDiscPerc As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbTotalPrice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnRollUp As MetroFramework.Controls.MetroLink
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents tbCustomer As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblLimit As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCusBalance As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblDays As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tbQuotaion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnlAccDetails As System.Windows.Forms.Panel
    Friend WithEvents MetroLink2 As MetroFramework.Controls.MetroLink
    Friend WithEvents cbAccRevenue As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lnkDetails As MetroFramework.Controls.MetroLink
    Friend WithEvents btnShowSelection As MetroFramework.Controls.MetroLink
    Friend WithEvents tbLPO As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbReference As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dtInvDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cbCustomer As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbCostCenter As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbVoucherType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents TbVoucherTransTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbVoucherTransTableAdapter
    Friend WithEvents TbVouchersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACCDBDataSet As Acc_System.ACCDBDataSet
    Friend WithEvents TbVouchersTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbVouchersTableAdapter
    Friend WithEvents TbCostCenterListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbCostCenterListTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbCostCenterListTableAdapter
    Friend WithEvents TbAccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbAccountsTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbAccountsTableAdapter

End Class
