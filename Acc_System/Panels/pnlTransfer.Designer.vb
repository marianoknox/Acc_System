<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlTransfer
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pnlTransfer))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cbCostCenter = New MetroFramework.Controls.MetroComboBox()
        Me.TbCostCenterListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACCDBDataSet = New Acc_System.ACCDBDataSet()
        Me.cbVoucherType = New MetroFramework.Controls.MetroComboBox()
        Me.TbVouchersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbTo = New MetroFramework.Controls.MetroComboBox()
        Me.dgTrans = New MetroFramework.Controls.MetroGrid()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmInv = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.cmsEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.dtInvDate = New MetroFramework.Controls.MetroDateTime()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tbNarration = New MetroFramework.Controls.MetroTextBox()
        Me.lblInvNo = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cbFrom = New MetroFramework.Controls.MetroComboBox()
        Me.tbReference = New MetroFramework.Controls.MetroTextBox()
        Me.chkPrintPreview = New MetroFramework.Controls.MetroCheckBox()
        Me.chkPrint = New MetroFramework.Controls.MetroCheckBox()
        Me.tbShowroomQty = New MetroFramework.Controls.MetroTextBox()
        Me.tbStoreQty = New MetroFramework.Controls.MetroTextBox()
        Me.lblLoc2 = New System.Windows.Forms.Button()
        Me.lblLoc1 = New System.Windows.Forms.Button()
        Me.btnSaveInv = New MetroFramework.Controls.MetroLink()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbQuantitySelect = New MetroFramework.Controls.MetroTextBox()
        Me.btnAccept = New MetroFramework.Controls.MetroButton()
        Me.tbItemSearch = New MetroFramework.Controls.MetroTextBox()
        Me.CustomPanel5 = New Acc_System.CustomPanel()
        Me.dgItemSelect = New System.Windows.Forms.DataGridView()
        Me.CustomPanel6 = New Acc_System.CustomPanel()
        Me.TbVouchersTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbVouchersTableAdapter()
        Me.TbCostCenterListTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbCostCenterListTableAdapter()
        Me.pnlEditMode = New System.Windows.Forms.Panel()
        Me.btnCancelEdit = New MetroFramework.Controls.MetroLink()
        CType(Me.TbCostCenterListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACCDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbVouchersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmInv.SuspendLayout()
        Me.CustomPanel5.SuspendLayout()
        CType(Me.dgItemSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEditMode.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(17, 48)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(112, 28)
        Me.Button5.TabIndex = 71
        Me.Button5.Text = "Cost Center"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(17, 14)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 28)
        Me.Button4.TabIndex = 70
        Me.Button4.Text = "Voucher Type"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cbCostCenter
        '
        Me.cbCostCenter.DataSource = Me.TbCostCenterListBindingSource
        Me.cbCostCenter.DisplayMember = "Cost_Center"
        Me.cbCostCenter.FormattingEnabled = True
        Me.cbCostCenter.ItemHeight = 23
        Me.cbCostCenter.Location = New System.Drawing.Point(131, 47)
        Me.cbCostCenter.Name = "cbCostCenter"
        Me.cbCostCenter.Size = New System.Drawing.Size(193, 29)
        Me.cbCostCenter.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbCostCenter.TabIndex = 69
        Me.cbCostCenter.UseSelectable = True
        '
        'TbCostCenterListBindingSource
        '
        Me.TbCostCenterListBindingSource.DataMember = "tbCostCenterList"
        Me.TbCostCenterListBindingSource.DataSource = Me.ACCDBDataSet
        '
        'ACCDBDataSet
        '
        Me.ACCDBDataSet.DataSetName = "ACCDBDataSet"
        Me.ACCDBDataSet.EnforceConstraints = False
        Me.ACCDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbVoucherType
        '
        Me.cbVoucherType.DataSource = Me.TbVouchersBindingSource
        Me.cbVoucherType.DisplayMember = "Voucher_Name"
        Me.cbVoucherType.FormattingEnabled = True
        Me.cbVoucherType.ItemHeight = 23
        Me.cbVoucherType.Location = New System.Drawing.Point(131, 13)
        Me.cbVoucherType.Name = "cbVoucherType"
        Me.cbVoucherType.Size = New System.Drawing.Size(193, 29)
        Me.cbVoucherType.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbVoucherType.TabIndex = 68
        Me.cbVoucherType.UseSelectable = True
        '
        'TbVouchersBindingSource
        '
        Me.TbVouchersBindingSource.DataMember = "tbVouchers"
        Me.TbVouchersBindingSource.DataSource = Me.ACCDBDataSet
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(539, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 28)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "Going To"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbTo
        '
        Me.cbTo.DisplayMember = "Voucher_Name"
        Me.cbTo.FormattingEnabled = True
        Me.cbTo.ItemHeight = 23
        Me.cbTo.Location = New System.Drawing.Point(653, 47)
        Me.cbTo.Name = "cbTo"
        Me.cbTo.Size = New System.Drawing.Size(193, 29)
        Me.cbTo.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbTo.TabIndex = 72
        Me.cbTo.UseSelectable = True
        '
        'dgTrans
        '
        Me.dgTrans.AllowUserToAddRows = False
        Me.dgTrans.AllowUserToDeleteRows = False
        Me.dgTrans.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgTrans.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgTrans.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgTrans.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgTrans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgTrans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTrans.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTrans.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.colCode, Me.Column2, Me.colQty, Me.Column4})
        Me.dgTrans.ContextMenuStrip = Me.cmInv
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgTrans.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgTrans.EnableHeadersVisualStyles = False
        Me.dgTrans.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgTrans.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgTrans.Location = New System.Drawing.Point(17, 117)
        Me.dgTrans.MultiSelect = False
        Me.dgTrans.Name = "dgTrans"
        Me.dgTrans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTrans.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgTrans.RowHeadersVisible = False
        Me.dgTrans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgTrans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgTrans.Size = New System.Drawing.Size(858, 417)
        Me.dgTrans.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgTrans.TabIndex = 74
        '
        'Column7
        '
        Me.Column7.HeaderText = "No"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 50
        '
        'colCode
        '
        Me.colCode.HeaderText = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.ReadOnly = True
        Me.colCode.Width = 180
        '
        'Column2
        '
        Me.Column2.HeaderText = "Description"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 450
        '
        'colQty
        '
        Me.colQty.HeaderText = "Qty"
        Me.colQty.Name = "colQty"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Unit"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 50
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
        Me.cmsEdit.Size = New System.Drawing.Size(152, 22)
        Me.cmsEdit.Text = "Edit"
        '
        'cmsRemove
        '
        Me.cmsRemove.Name = "cmsRemove"
        Me.cmsRemove.Size = New System.Drawing.Size(152, 22)
        Me.cmsRemove.Text = "Remove"
        '
        'dtInvDate
        '
        Me.dtInvDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInvDate.Location = New System.Drawing.Point(653, 81)
        Me.dtInvDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtInvDate.Name = "dtInvDate"
        Me.dtInvDate.Size = New System.Drawing.Size(193, 29)
        Me.dtInvDate.Style = MetroFramework.MetroColorStyle.Teal
        Me.dtInvDate.TabIndex = 75
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(539, 82)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 28)
        Me.Button2.TabIndex = 76
        Me.Button2.Text = "Date"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.tbNarration.Location = New System.Drawing.Point(17, 541)
        Me.tbNarration.MaxLength = 32767
        Me.tbNarration.Name = "tbNarration"
        Me.tbNarration.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNarration.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbNarration.SelectedText = ""
        Me.tbNarration.SelectionLength = 0
        Me.tbNarration.SelectionStart = 0
        Me.tbNarration.Size = New System.Drawing.Size(721, 30)
        Me.tbNarration.TabIndex = 77
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
        Me.lblInvNo.Location = New System.Drawing.Point(6, 573)
        Me.lblInvNo.Name = "lblInvNo"
        Me.lblInvNo.Size = New System.Drawing.Size(179, 65)
        Me.lblInvNo.TabIndex = 78
        Me.lblInvNo.Text = "CR-001"
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(539, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 28)
        Me.Button3.TabIndex = 80
        Me.Button3.Text = "Coming From"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cbFrom
        '
        Me.cbFrom.DisplayMember = "Voucher_Name"
        Me.cbFrom.FormattingEnabled = True
        Me.cbFrom.ItemHeight = 23
        Me.cbFrom.Location = New System.Drawing.Point(653, 13)
        Me.cbFrom.Name = "cbFrom"
        Me.cbFrom.Size = New System.Drawing.Size(193, 29)
        Me.cbFrom.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbFrom.TabIndex = 79
        Me.cbFrom.UseSelectable = True
        '
        'tbReference
        '
        '
        '
        '
        Me.tbReference.CustomButton.Image = Nothing
        Me.tbReference.CustomButton.Location = New System.Drawing.Point(165, 1)
        Me.tbReference.CustomButton.Name = ""
        Me.tbReference.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbReference.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbReference.CustomButton.TabIndex = 1
        Me.tbReference.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbReference.CustomButton.UseSelectable = True
        Me.tbReference.CustomButton.Visible = False
        Me.tbReference.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbReference.Lines = New String(-1) {}
        Me.tbReference.Location = New System.Drawing.Point(131, 81)
        Me.tbReference.MaxLength = 32767
        Me.tbReference.Name = "tbReference"
        Me.tbReference.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbReference.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbReference.SelectedText = ""
        Me.tbReference.SelectionLength = 0
        Me.tbReference.SelectionStart = 0
        Me.tbReference.Size = New System.Drawing.Size(193, 29)
        Me.tbReference.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbReference.TabIndex = 81
        Me.tbReference.UseSelectable = True
        Me.tbReference.WaterMark = "Reference"
        Me.tbReference.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbReference.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'chkPrintPreview
        '
        Me.chkPrintPreview.AutoSize = True
        Me.chkPrintPreview.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkPrintPreview.Location = New System.Drawing.Point(384, 615)
        Me.chkPrintPreview.Name = "chkPrintPreview"
        Me.chkPrintPreview.Size = New System.Drawing.Size(142, 19)
        Me.chkPrintPreview.TabIndex = 83
        Me.chkPrintPreview.Text = "Show Print Preview"
        Me.chkPrintPreview.UseSelectable = True
        '
        'chkPrint
        '
        Me.chkPrint.AutoSize = True
        Me.chkPrint.Checked = True
        Me.chkPrint.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrint.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkPrint.Location = New System.Drawing.Point(384, 592)
        Me.chkPrint.Name = "chkPrint"
        Me.chkPrint.Size = New System.Drawing.Size(117, 19)
        Me.chkPrint.TabIndex = 82
        Me.chkPrint.Text = "Print after save"
        Me.chkPrint.UseSelectable = True
        '
        'tbShowroomQty
        '
        Me.tbShowroomQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tbShowroomQty.CustomButton.Image = Nothing
        Me.tbShowroomQty.CustomButton.Location = New System.Drawing.Point(42, 2)
        Me.tbShowroomQty.CustomButton.Name = ""
        Me.tbShowroomQty.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.tbShowroomQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbShowroomQty.CustomButton.TabIndex = 1
        Me.tbShowroomQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbShowroomQty.CustomButton.UseSelectable = True
        Me.tbShowroomQty.CustomButton.Visible = False
        Me.tbShowroomQty.Enabled = False
        Me.tbShowroomQty.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbShowroomQty.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.tbShowroomQty.Lines = New String(-1) {}
        Me.tbShowroomQty.Location = New System.Drawing.Point(668, 604)
        Me.tbShowroomQty.MaxLength = 32767
        Me.tbShowroomQty.Name = "tbShowroomQty"
        Me.tbShowroomQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbShowroomQty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbShowroomQty.SelectedText = ""
        Me.tbShowroomQty.SelectionLength = 0
        Me.tbShowroomQty.SelectionStart = 0
        Me.tbShowroomQty.Size = New System.Drawing.Size(70, 30)
        Me.tbShowroomQty.TabIndex = 87
        Me.tbShowroomQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbShowroomQty.UseSelectable = True
        Me.tbShowroomQty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbShowroomQty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'tbStoreQty
        '
        Me.tbStoreQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.tbStoreQty.CustomButton.Image = Nothing
        Me.tbStoreQty.CustomButton.Location = New System.Drawing.Point(42, 2)
        Me.tbStoreQty.CustomButton.Name = ""
        Me.tbStoreQty.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.tbStoreQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbStoreQty.CustomButton.TabIndex = 1
        Me.tbStoreQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbStoreQty.CustomButton.UseSelectable = True
        Me.tbStoreQty.CustomButton.Visible = False
        Me.tbStoreQty.Enabled = False
        Me.tbStoreQty.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbStoreQty.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.tbStoreQty.Lines = New String(-1) {}
        Me.tbStoreQty.Location = New System.Drawing.Point(668, 573)
        Me.tbStoreQty.MaxLength = 32767
        Me.tbStoreQty.Name = "tbStoreQty"
        Me.tbStoreQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbStoreQty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbStoreQty.SelectedText = ""
        Me.tbStoreQty.SelectionLength = 0
        Me.tbStoreQty.SelectionStart = 0
        Me.tbStoreQty.Size = New System.Drawing.Size(70, 30)
        Me.tbStoreQty.TabIndex = 86
        Me.tbStoreQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbStoreQty.UseSelectable = True
        Me.tbStoreQty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbStoreQty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblLoc2
        '
        Me.lblLoc2.Enabled = False
        Me.lblLoc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLoc2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoc2.Location = New System.Drawing.Point(545, 604)
        Me.lblLoc2.Name = "lblLoc2"
        Me.lblLoc2.Size = New System.Drawing.Size(120, 30)
        Me.lblLoc2.TabIndex = 85
        Me.lblLoc2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblLoc2.UseVisualStyleBackColor = True
        '
        'lblLoc1
        '
        Me.lblLoc1.Enabled = False
        Me.lblLoc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLoc1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoc1.Location = New System.Drawing.Point(545, 573)
        Me.lblLoc1.Name = "lblLoc1"
        Me.lblLoc1.Size = New System.Drawing.Size(120, 30)
        Me.lblLoc1.TabIndex = 84
        Me.lblLoc1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblLoc1.UseVisualStyleBackColor = True
        '
        'btnSaveInv
        '
        Me.btnSaveInv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveInv.Image = CType(resources.GetObject("btnSaveInv.Image"), System.Drawing.Image)
        Me.btnSaveInv.ImageSize = 25
        Me.btnSaveInv.Location = New System.Drawing.Point(744, 541)
        Me.btnSaveInv.Name = "btnSaveInv"
        Me.btnSaveInv.NoFocusImage = CType(resources.GetObject("btnSaveInv.NoFocusImage"), System.Drawing.Image)
        Me.btnSaveInv.Size = New System.Drawing.Size(43, 30)
        Me.btnSaveInv.TabIndex = 88
        Me.btnSaveInv.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(881, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 51)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Quick Info : Transfered items will not be allocated " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "upon creation. An administr" & _
            "ator should verify it" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "first to be marked as posted." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tbQuantitySelect
        '
        '
        '
        '
        Me.tbQuantitySelect.CustomButton.Image = Nothing
        Me.tbQuantitySelect.CustomButton.Location = New System.Drawing.Point(92, 2)
        Me.tbQuantitySelect.CustomButton.Name = ""
        Me.tbQuantitySelect.CustomButton.Size = New System.Drawing.Size(25, 25)
        Me.tbQuantitySelect.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbQuantitySelect.CustomButton.TabIndex = 1
        Me.tbQuantitySelect.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbQuantitySelect.CustomButton.UseSelectable = True
        Me.tbQuantitySelect.CustomButton.Visible = False
        Me.tbQuantitySelect.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbQuantitySelect.Lines = New String() {"1"}
        Me.tbQuantitySelect.Location = New System.Drawing.Point(12, 492)
        Me.tbQuantitySelect.MaxLength = 32767
        Me.tbQuantitySelect.Name = "tbQuantitySelect"
        Me.tbQuantitySelect.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbQuantitySelect.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbQuantitySelect.SelectedText = ""
        Me.tbQuantitySelect.SelectionLength = 0
        Me.tbQuantitySelect.SelectionStart = 0
        Me.tbQuantitySelect.Size = New System.Drawing.Size(120, 30)
        Me.tbQuantitySelect.TabIndex = 23
        Me.tbQuantitySelect.Text = "1"
        Me.tbQuantitySelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbQuantitySelect.UseSelectable = True
        Me.tbQuantitySelect.WaterMark = "Quantity"
        Me.tbQuantitySelect.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbQuantitySelect.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(138, 492)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(69, 30)
        Me.btnAccept.TabIndex = 22
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseSelectable = True
        '
        'tbItemSearch
        '
        '
        '
        '
        Me.tbItemSearch.CustomButton.Image = Nothing
        Me.tbItemSearch.CustomButton.Location = New System.Drawing.Point(230, 2)
        Me.tbItemSearch.CustomButton.Name = ""
        Me.tbItemSearch.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.tbItemSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbItemSearch.CustomButton.TabIndex = 1
        Me.tbItemSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbItemSearch.CustomButton.UseSelectable = True
        Me.tbItemSearch.DisplayIcon = True
        Me.tbItemSearch.Icon = CType(resources.GetObject("tbItemSearch.Icon"), System.Drawing.Image)
        Me.tbItemSearch.Lines = New String(-1) {}
        Me.tbItemSearch.Location = New System.Drawing.Point(11, 32)
        Me.tbItemSearch.MaxLength = 32767
        Me.tbItemSearch.Name = "tbItemSearch"
        Me.tbItemSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbItemSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbItemSearch.SelectedText = ""
        Me.tbItemSearch.SelectionLength = 0
        Me.tbItemSearch.SelectionStart = 0
        Me.tbItemSearch.ShowButton = True
        Me.tbItemSearch.Size = New System.Drawing.Size(254, 26)
        Me.tbItemSearch.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbItemSearch.TabIndex = 18
        Me.tbItemSearch.UseSelectable = True
        Me.tbItemSearch.WaterMark = "Search Item Keyword"
        Me.tbItemSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbItemSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'CustomPanel5
        '
        Me.CustomPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomPanel5.Controls.Add(Me.dgItemSelect)
        Me.CustomPanel5.Controls.Add(Me.tbQuantitySelect)
        Me.CustomPanel5.Controls.Add(Me.CustomPanel6)
        Me.CustomPanel5.Controls.Add(Me.btnAccept)
        Me.CustomPanel5.Controls.Add(Me.tbItemSearch)
        Me.CustomPanel5.Curvature = 10
        Me.CustomPanel5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomPanel5.Location = New System.Drawing.Point(881, 81)
        Me.CustomPanel5.Name = "CustomPanel5"
        Me.CustomPanel5.Size = New System.Drawing.Size(312, 553)
        Me.CustomPanel5.TabIndex = 90
        '
        'dgItemSelect
        '
        Me.dgItemSelect.AllowUserToAddRows = False
        Me.dgItemSelect.AllowUserToDeleteRows = False
        Me.dgItemSelect.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgItemSelect.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgItemSelect.BackgroundColor = System.Drawing.Color.White
        Me.dgItemSelect.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgItemSelect.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgItemSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgItemSelect.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgItemSelect.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgItemSelect.Location = New System.Drawing.Point(12, 64)
        Me.dgItemSelect.MultiSelect = False
        Me.dgItemSelect.Name = "dgItemSelect"
        Me.dgItemSelect.ReadOnly = True
        Me.dgItemSelect.RowHeadersVisible = False
        Me.dgItemSelect.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgItemSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgItemSelect.Size = New System.Drawing.Size(288, 422)
        Me.dgItemSelect.TabIndex = 62
        '
        'CustomPanel6
        '
        Me.CustomPanel6.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomPanel6.Curvature = 10
        Me.CustomPanel6.CurveMode = CType((Acc_System.CornerCurveMode.TopLeft Or Acc_System.CornerCurveMode.TopRight), Acc_System.CornerCurveMode)
        Me.CustomPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel6.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel6.Name = "CustomPanel6"
        Me.CustomPanel6.Size = New System.Drawing.Size(312, 23)
        Me.CustomPanel6.TabIndex = 44
        '
        'TbVouchersTableAdapter
        '
        Me.TbVouchersTableAdapter.ClearBeforeFill = True
        '
        'TbCostCenterListTableAdapter
        '
        Me.TbCostCenterListTableAdapter.ClearBeforeFill = True
        '
        'pnlEditMode
        '
        Me.pnlEditMode.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlEditMode.Controls.Add(Me.btnCancelEdit)
        Me.pnlEditMode.Location = New System.Drawing.Point(17, 289)
        Me.pnlEditMode.Name = "pnlEditMode"
        Me.pnlEditMode.Size = New System.Drawing.Size(174, 47)
        Me.pnlEditMode.TabIndex = 91
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
        'pnlTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlEditMode)
        Me.Controls.Add(Me.CustomPanel5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSaveInv)
        Me.Controls.Add(Me.tbShowroomQty)
        Me.Controls.Add(Me.tbStoreQty)
        Me.Controls.Add(Me.lblLoc2)
        Me.Controls.Add(Me.lblLoc1)
        Me.Controls.Add(Me.chkPrintPreview)
        Me.Controls.Add(Me.chkPrint)
        Me.Controls.Add(Me.tbReference)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cbFrom)
        Me.Controls.Add(Me.lblInvNo)
        Me.Controls.Add(Me.tbNarration)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dtInvDate)
        Me.Controls.Add(Me.dgTrans)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbTo)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.cbCostCenter)
        Me.Controls.Add(Me.cbVoucherType)
        Me.Name = "pnlTransfer"
        Me.Size = New System.Drawing.Size(1200, 643)
        CType(Me.TbCostCenterListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACCDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbVouchersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmInv.ResumeLayout(False)
        Me.CustomPanel5.ResumeLayout(False)
        CType(Me.dgItemSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEditMode.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cbCostCenter As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbVoucherType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbTo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dgTrans As MetroFramework.Controls.MetroGrid
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtInvDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tbNarration As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblInvNo As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cbFrom As MetroFramework.Controls.MetroComboBox
    Friend WithEvents tbReference As MetroFramework.Controls.MetroTextBox
    Friend WithEvents chkPrintPreview As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkPrint As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents tbShowroomQty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbStoreQty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblLoc2 As System.Windows.Forms.Button
    Friend WithEvents lblLoc1 As System.Windows.Forms.Button
    Friend WithEvents btnSaveInv As MetroFramework.Controls.MetroLink
    Friend WithEvents tbQuantitySelect As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnAccept As MetroFramework.Controls.MetroButton
    Friend WithEvents tbItemSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CustomPanel5 As Acc_System.CustomPanel
    Friend WithEvents CustomPanel6 As Acc_System.CustomPanel
    Friend WithEvents dgItemSelect As System.Windows.Forms.DataGridView
    Friend WithEvents TbVouchersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACCDBDataSet As Acc_System.ACCDBDataSet
    Friend WithEvents TbVouchersTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbVouchersTableAdapter
    Friend WithEvents TbCostCenterListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbCostCenterListTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbCostCenterListTableAdapter
    Friend WithEvents cmInv As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents cmsEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlEditMode As System.Windows.Forms.Panel
    Friend WithEvents btnCancelEdit As MetroFramework.Controls.MetroLink

End Class
