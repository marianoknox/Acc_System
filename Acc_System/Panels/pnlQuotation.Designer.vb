<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlQuotation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pnlQuotation))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmInv = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.cmsEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsPrice = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbNarration = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLink8 = New MetroFramework.Controls.MetroLink()
        Me.lblInvNo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbShowroomQty = New MetroFramework.Controls.MetroTextBox()
        Me.tbStoreQty = New MetroFramework.Controls.MetroTextBox()
        Me.lblLoc2 = New System.Windows.Forms.Button()
        Me.lblLoc1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnPrint = New MetroFramework.Controls.MetroLink()
        Me.btnSaveInv = New MetroFramework.Controls.MetroLink()
        Me.tbNetAmount = New MetroFramework.Controls.MetroTextBox()
        Me.tbDiscAmt = New MetroFramework.Controls.MetroTextBox()
        Me.tbDiscPerc = New MetroFramework.Controls.MetroTextBox()
        Me.tbTotalPrice = New MetroFramework.Controls.MetroTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancelEdit = New MetroFramework.Controls.MetroLink()
        Me.pnlEditMode = New System.Windows.Forms.Panel()
        Me.tbCustomer = New MetroFramework.Controls.MetroTextBox()
        Me.btnShowSelection = New MetroFramework.Controls.MetroLink()
        Me.tbLPO = New MetroFramework.Controls.MetroTextBox()
        Me.cbCostCenter = New MetroFramework.Controls.MetroComboBox()
        Me.TbCostCenterListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACCDBDataSet = New Acc_System.ACCDBDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.tbReference = New MetroFramework.Controls.MetroTextBox()
        Me.dtInvDate = New MetroFramework.Controls.MetroDateTime()
        Me.cbCustomer = New MetroFramework.Controls.MetroComboBox()
        Me.TbAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbVoucherType = New MetroFramework.Controls.MetroComboBox()
        Me.TbVouchersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbLocationListTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbLocationListTableAdapter()
        Me.TbItemsTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbItemsTableAdapter()
        Me.TbAccountTransTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbAccountTransTableAdapter()
        Me.TbItemTransTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbItemTransTableAdapter()
        Me.TbAccountsTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbAccountsTableAdapter()
        Me.TbCostCenterListTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbCostCenterListTableAdapter()
        Me.TbVouchersTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbVouchersTableAdapter()
        Me.TbVoucherTransTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbVoucherTransTableAdapter()
        Me.dgInvItem = New MetroFramework.Controls.MetroGrid()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlItemsInv = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbQuantitySelect = New MetroFramework.Controls.MetroTextBox()
        Me.btnAccept = New MetroFramework.Controls.MetroButton()
        Me.dgItemSelect = New MetroFramework.Controls.MetroGrid()
        Me.tbItemSearch = New MetroFramework.Controls.MetroTextBox()
        Me.btnHideSelection = New MetroFramework.Controls.MetroLink()
        Me.chkPrintPreview = New MetroFramework.Controls.MetroCheckBox()
        Me.chkPrint = New MetroFramework.Controls.MetroCheckBox()
        Me.cmInv.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlEditMode.SuspendLayout()
        CType(Me.TbCostCenterListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACCDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TbAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbVouchersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgInvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlItemsInv.SuspendLayout()
        CType(Me.dgItemSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmInv
        '
        Me.cmInv.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsEdit, Me.cmsRemove, Me.cmsPrice})
        Me.cmInv.Name = "cmInv"
        Me.cmInv.Size = New System.Drawing.Size(145, 70)
        '
        'cmsEdit
        '
        Me.cmsEdit.Name = "cmsEdit"
        Me.cmsEdit.Size = New System.Drawing.Size(144, 22)
        Me.cmsEdit.Text = "Edit"
        '
        'cmsRemove
        '
        Me.cmsRemove.Name = "cmsRemove"
        Me.cmsRemove.Size = New System.Drawing.Size(144, 22)
        Me.cmsRemove.Text = "Remove"
        '
        'cmsPrice
        '
        Me.cmsPrice.Name = "cmsPrice"
        Me.cmsPrice.Size = New System.Drawing.Size(144, 22)
        Me.cmsPrice.Text = "Change Price"
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
        Me.tbNarration.Location = New System.Drawing.Point(21, 13)
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
        'lblInvNo
        '
        Me.lblInvNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblInvNo.AutoSize = True
        Me.lblInvNo.BackColor = System.Drawing.Color.Transparent
        Me.lblInvNo.Font = New System.Drawing.Font("Segoe UI Light", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvNo.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblInvNo.Location = New System.Drawing.Point(16, 44)
        Me.lblInvNo.Name = "lblInvNo"
        Me.lblInvNo.Size = New System.Drawing.Size(179, 65)
        Me.lblInvNo.TabIndex = 40
        Me.lblInvNo.Text = "CR-001"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.chkPrintPreview)
        Me.Panel2.Controls.Add(Me.chkPrint)
        Me.Panel2.Controls.Add(Me.tbShowroomQty)
        Me.Panel2.Controls.Add(Me.tbStoreQty)
        Me.Panel2.Controls.Add(Me.lblLoc2)
        Me.Panel2.Controls.Add(Me.lblLoc1)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.lblInvNo)
        Me.Panel2.Controls.Add(Me.tbNarration)
        Me.Panel2.Controls.Add(Me.MetroLink8)
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.btnSaveInv)
        Me.Panel2.Controls.Add(Me.tbNetAmount)
        Me.Panel2.Controls.Add(Me.tbDiscAmt)
        Me.Panel2.Controls.Add(Me.tbDiscPerc)
        Me.Panel2.Controls.Add(Me.tbTotalPrice)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 528)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1200, 115)
        Me.Panel2.TabIndex = 23
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
        Me.tbShowroomQty.Location = New System.Drawing.Point(672, 79)
        Me.tbShowroomQty.MaxLength = 32767
        Me.tbShowroomQty.Name = "tbShowroomQty"
        Me.tbShowroomQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbShowroomQty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbShowroomQty.SelectedText = ""
        Me.tbShowroomQty.SelectionLength = 0
        Me.tbShowroomQty.SelectionStart = 0
        Me.tbShowroomQty.Size = New System.Drawing.Size(70, 30)
        Me.tbShowroomQty.TabIndex = 74
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
        Me.tbStoreQty.Location = New System.Drawing.Point(672, 48)
        Me.tbStoreQty.MaxLength = 32767
        Me.tbStoreQty.Name = "tbStoreQty"
        Me.tbStoreQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbStoreQty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbStoreQty.SelectedText = ""
        Me.tbStoreQty.SelectionLength = 0
        Me.tbStoreQty.SelectionStart = 0
        Me.tbStoreQty.Size = New System.Drawing.Size(70, 30)
        Me.tbStoreQty.TabIndex = 73
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
        Me.lblLoc2.Location = New System.Drawing.Point(549, 79)
        Me.lblLoc2.Name = "lblLoc2"
        Me.lblLoc2.Size = New System.Drawing.Size(120, 30)
        Me.lblLoc2.TabIndex = 72
        Me.lblLoc2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblLoc2.UseVisualStyleBackColor = True
        '
        'lblLoc1
        '
        Me.lblLoc1.Enabled = False
        Me.lblLoc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLoc1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoc1.Location = New System.Drawing.Point(549, 48)
        Me.lblLoc1.Name = "lblLoc1"
        Me.lblLoc1.Size = New System.Drawing.Size(120, 30)
        Me.lblLoc1.TabIndex = 71
        Me.lblLoc1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblLoc1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(831, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 30)
        Me.Button3.TabIndex = 68
        Me.Button3.Text = "Total Amount"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(831, 44)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 30)
        Me.Button2.TabIndex = 67
        Me.Button2.Text = "Discount"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(831, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 30)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "Net"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 80)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(27, 448)
        Me.Panel3.TabIndex = 27
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
        Me.pnlEditMode.Location = New System.Drawing.Point(33, 211)
        Me.pnlEditMode.Name = "pnlEditMode"
        Me.pnlEditMode.Size = New System.Drawing.Size(174, 47)
        Me.pnlEditMode.TabIndex = 26
        Me.pnlEditMode.Visible = False
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
        Me.tbLPO.CustomButton.Location = New System.Drawing.Point(133, 1)
        Me.tbLPO.CustomButton.Name = ""
        Me.tbLPO.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbLPO.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbLPO.CustomButton.TabIndex = 1
        Me.tbLPO.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbLPO.CustomButton.UseSelectable = True
        Me.tbLPO.CustomButton.Visible = False
        Me.tbLPO.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbLPO.Lines = New String(-1) {}
        Me.tbLPO.Location = New System.Drawing.Point(344, 43)
        Me.tbLPO.MaxLength = 32767
        Me.tbLPO.Name = "tbLPO"
        Me.tbLPO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbLPO.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbLPO.SelectedText = ""
        Me.tbLPO.SelectionLength = 0
        Me.tbLPO.SelectionStart = 0
        Me.tbLPO.Size = New System.Drawing.Size(161, 29)
        Me.tbLPO.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbLPO.TabIndex = 5
        Me.tbLPO.UseSelectable = True
        Me.tbLPO.WaterMark = "LPO"
        Me.tbLPO.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbLPO.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cbCostCenter
        '
        Me.cbCostCenter.DataSource = Me.TbCostCenterListBindingSource
        Me.cbCostCenter.DisplayMember = "Cost_Center"
        Me.cbCostCenter.FormattingEnabled = True
        Me.cbCostCenter.ItemHeight = 23
        Me.cbCostCenter.Location = New System.Drawing.Point(133, 42)
        Me.cbCostCenter.Name = "cbCostCenter"
        Me.cbCostCenter.Size = New System.Drawing.Size(205, 29)
        Me.cbCostCenter.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbCostCenter.TabIndex = 1
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.tbCustomer)
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
        Me.Panel1.TabIndex = 22
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(27, 43)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 28)
        Me.Button5.TabIndex = 69
        Me.Button5.Text = "Cost Center"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(27, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 28)
        Me.Button4.TabIndex = 68
        Me.Button4.Text = "Voucher Type"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
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
        Me.dtInvDate.Location = New System.Drawing.Point(511, 43)
        Me.dtInvDate.MinimumSize = New System.Drawing.Size(0, 29)
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
        'TbAccountsBindingSource
        '
        Me.TbAccountsBindingSource.DataMember = "tbAccounts"
        Me.TbAccountsBindingSource.DataSource = Me.ACCDBDataSet
        '
        'cbVoucherType
        '
        Me.cbVoucherType.DataSource = Me.TbVouchersBindingSource
        Me.cbVoucherType.DisplayMember = "Voucher_Name"
        Me.cbVoucherType.FormattingEnabled = True
        Me.cbVoucherType.ItemHeight = 23
        Me.cbVoucherType.Location = New System.Drawing.Point(133, 7)
        Me.cbVoucherType.Name = "cbVoucherType"
        Me.cbVoucherType.Size = New System.Drawing.Size(205, 29)
        Me.cbVoucherType.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbVoucherType.TabIndex = 0
        Me.cbVoucherType.UseSelectable = True
        '
        'TbVouchersBindingSource
        '
        Me.TbVouchersBindingSource.DataMember = "tbVouchers"
        Me.TbVouchersBindingSource.DataSource = Me.ACCDBDataSet
        '
        'TbLocationListTableAdapter
        '
        Me.TbLocationListTableAdapter.ClearBeforeFill = True
        '
        'TbItemsTableAdapter
        '
        Me.TbItemsTableAdapter.ClearBeforeFill = True
        '
        'TbAccountTransTableAdapter
        '
        Me.TbAccountTransTableAdapter.ClearBeforeFill = True
        '
        'TbItemTransTableAdapter
        '
        Me.TbItemTransTableAdapter.ClearBeforeFill = True
        '
        'TbAccountsTableAdapter
        '
        Me.TbAccountsTableAdapter.ClearBeforeFill = True
        '
        'TbCostCenterListTableAdapter
        '
        Me.TbCostCenterListTableAdapter.ClearBeforeFill = True
        '
        'TbVouchersTableAdapter
        '
        Me.TbVouchersTableAdapter.ClearBeforeFill = True
        '
        'TbVoucherTransTableAdapter
        '
        Me.TbVoucherTransTableAdapter.ClearBeforeFill = True
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
        Me.dgInvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
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
        Me.dgInvItem.Size = New System.Drawing.Size(1173, 448)
        Me.dgInvItem.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgInvItem.TabIndex = 28
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
        Me.Column5.HeaderText = "Price"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column6.HeaderText = "Total"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 200
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
        Me.pnlItemsInv.TabIndex = 29
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
        'dgItemSelect
        '
        Me.dgItemSelect.AllowUserToAddRows = False
        Me.dgItemSelect.AllowUserToDeleteRows = False
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
        Me.dgItemSelect.Location = New System.Drawing.Point(10, 50)
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
        Me.dgItemSelect.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgItemSelect.Size = New System.Drawing.Size(582, 293)
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
        'chkPrintPreview
        '
        Me.chkPrintPreview.AutoSize = True
        Me.chkPrintPreview.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkPrintPreview.Location = New System.Drawing.Point(385, 90)
        Me.chkPrintPreview.Name = "chkPrintPreview"
        Me.chkPrintPreview.Size = New System.Drawing.Size(142, 19)
        Me.chkPrintPreview.TabIndex = 76
        Me.chkPrintPreview.Text = "Show Print Preview"
        Me.chkPrintPreview.UseSelectable = True
        '
        'chkPrint
        '
        Me.chkPrint.AutoSize = True
        Me.chkPrint.Checked = True
        Me.chkPrint.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrint.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkPrint.Location = New System.Drawing.Point(385, 67)
        Me.chkPrint.Name = "chkPrint"
        Me.chkPrint.Size = New System.Drawing.Size(117, 19)
        Me.chkPrint.TabIndex = 75
        Me.chkPrint.Text = "Print after save"
        Me.chkPrint.UseSelectable = True
        '
        'pnlQuotation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlItemsInv)
        Me.Controls.Add(Me.pnlEditMode)
        Me.Controls.Add(Me.dgInvItem)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "pnlQuotation"
        Me.Size = New System.Drawing.Size(1200, 643)
        Me.cmInv.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlEditMode.ResumeLayout(False)
        CType(Me.TbCostCenterListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACCDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.TbAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbVouchersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgInvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlItemsInv.ResumeLayout(False)
        Me.pnlItemsInv.PerformLayout()
        CType(Me.dgItemSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbNarration As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLink8 As MetroFramework.Controls.MetroLink
    Friend WithEvents lblInvNo As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnPrint As MetroFramework.Controls.MetroLink
    Friend WithEvents btnSaveInv As MetroFramework.Controls.MetroLink
    Friend WithEvents tbNetAmount As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbDiscAmt As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbDiscPerc As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbTotalPrice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnCancelEdit As MetroFramework.Controls.MetroLink
    Friend WithEvents pnlEditMode As System.Windows.Forms.Panel
    Friend WithEvents tbCustomer As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnShowSelection As MetroFramework.Controls.MetroLink
    Friend WithEvents tbLPO As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cbCostCenter As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tbReference As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dtInvDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cbCustomer As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbVoucherType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmInv As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents cmsEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsPrice As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TbLocationListTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbLocationListTableAdapter
    Friend WithEvents TbItemsTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbItemsTableAdapter
    Friend WithEvents TbAccountTransTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbAccountTransTableAdapter
    Friend WithEvents TbItemTransTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbItemTransTableAdapter
    Friend WithEvents TbAccountsTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbAccountsTableAdapter
    Friend WithEvents TbCostCenterListTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbCostCenterListTableAdapter
    Friend WithEvents TbVouchersTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbVouchersTableAdapter
    Friend WithEvents TbAccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACCDBDataSet As Acc_System.ACCDBDataSet
    Friend WithEvents TbCostCenterListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbVouchersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbVoucherTransTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbVoucherTransTableAdapter
    Friend WithEvents dgInvItem As MetroFramework.Controls.MetroGrid
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tbShowroomQty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbStoreQty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblLoc2 As System.Windows.Forms.Button
    Friend WithEvents lblLoc1 As System.Windows.Forms.Button
    Friend WithEvents pnlItemsInv As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbQuantitySelect As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnAccept As MetroFramework.Controls.MetroButton
    Friend WithEvents dgItemSelect As MetroFramework.Controls.MetroGrid
    Friend WithEvents tbItemSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnHideSelection As MetroFramework.Controls.MetroLink
    Friend WithEvents chkPrintPreview As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkPrint As MetroFramework.Controls.MetroCheckBox

End Class
