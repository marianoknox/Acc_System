<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlPayment
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pnlPayment))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlAgainstRef = New System.Windows.Forms.Panel()
        Me.dgRef = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.MetroTextBox7 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox6 = New MetroFramework.Controls.MetroTextBox()
        Me.tbTotal = New MetroFramework.Controls.MetroTextBox()
        Me.tbNarration = New MetroFramework.Controls.MetroTextBox()
        Me.lblInvNo = New System.Windows.Forms.Label()
        Me.btnSaveInv = New MetroFramework.Controls.MetroLink()
        Me.btnRollUp = New MetroFramework.Controls.MetroLink()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnRollDown = New MetroFramework.Controls.MetroLink()
        Me.tbAccSearch = New MetroFramework.Controls.MetroTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.chkPrintPreview = New MetroFramework.Controls.MetroCheckBox()
        Me.chkPrint = New MetroFramework.Controls.MetroCheckBox()
        Me.tbReference = New MetroFramework.Controls.MetroTextBox()
        Me.cbVoucherType = New MetroFramework.Controls.MetroComboBox()
        Me.TbVouchersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACCDBDataSet = New Acc_System.ACCDBDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.tbDRCRMain = New MetroFramework.Controls.MetroTextBox()
        Me.tbMainAccBalance = New MetroFramework.Controls.MetroTextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tbMainAccSearch = New MetroFramework.Controls.MetroTextBox()
        Me.cbMainAccount = New MetroFramework.Controls.MetroComboBox()
        Me.TbAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbCostCenter = New MetroFramework.Controls.MetroComboBox()
        Me.TbCostCenterListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbDRCRAcc = New MetroFramework.Controls.MetroTextBox()
        Me.tbBalance = New MetroFramework.Controls.MetroTextBox()
        Me.btnAddAccount = New MetroFramework.Controls.MetroButton()
        Me.tbAmount = New MetroFramework.Controls.MetroTextBox()
        Me.cbAccount = New MetroFramework.Controls.MetroComboBox()
        Me.dtDate = New MetroFramework.Controls.MetroDateTime()
        Me.cmsRemoveAcc = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsAddRef = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmAccounts = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.dgPayment = New MetroFramework.Controls.MetroGrid()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colParticula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDebit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbVouchersTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbVouchersTableAdapter()
        Me.TbCostCenterListTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbCostCenterListTableAdapter()
        Me.TbAccountsTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbAccountsTableAdapter()
        Me.TbAccountTransTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbAccountTransTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.pnlAgainstRef.SuspendLayout()
        CType(Me.dgRef, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.TbVouchersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACCDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TbAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbCostCenterListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmAccounts.SuspendLayout()
        CType(Me.dgPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlAgainstRef
        '
        Me.pnlAgainstRef.BackColor = System.Drawing.Color.White
        Me.pnlAgainstRef.Controls.Add(Me.dgRef)
        Me.pnlAgainstRef.Controls.Add(Me.Button6)
        Me.pnlAgainstRef.Controls.Add(Me.Button5)
        Me.pnlAgainstRef.Controls.Add(Me.MetroTextBox7)
        Me.pnlAgainstRef.Controls.Add(Me.MetroTextBox6)
        Me.pnlAgainstRef.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlAgainstRef.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlAgainstRef.Location = New System.Drawing.Point(803, 155)
        Me.pnlAgainstRef.Name = "pnlAgainstRef"
        Me.pnlAgainstRef.Size = New System.Drawing.Size(397, 383)
        Me.pnlAgainstRef.TabIndex = 28
        '
        'dgRef
        '
        Me.dgRef.AllowUserToAddRows = False
        Me.dgRef.AllowUserToDeleteRows = False
        Me.dgRef.AllowUserToResizeRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgRef.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgRef.BackgroundColor = System.Drawing.Color.White
        Me.dgRef.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgRef.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRef.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column3, Me.Column1})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgRef.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgRef.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgRef.Location = New System.Drawing.Point(17, 41)
        Me.dgRef.MultiSelect = False
        Me.dgRef.Name = "dgRef"
        Me.dgRef.RowHeadersVisible = False
        Me.dgRef.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgRef.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRef.Size = New System.Drawing.Size(377, 301)
        Me.dgRef.TabIndex = 74
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Vch No."
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Debit"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'Column3
        '
        Me.Column3.HeaderText = "Credit"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 80
        '
        'Column1
        '
        Me.Column1.HeaderText = "Outstanding"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(17, 6)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(139, 29)
        Me.Button6.TabIndex = 73
        Me.Button6.Text = "Payee Amount"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(17, 348)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(142, 29)
        Me.Button5.TabIndex = 72
        Me.Button5.Text = "Remaining Amount"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'MetroTextBox7
        '
        '
        '
        '
        Me.MetroTextBox7.CustomButton.Image = Nothing
        Me.MetroTextBox7.CustomButton.Location = New System.Drawing.Point(181, 1)
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
        Me.MetroTextBox7.Location = New System.Drawing.Point(165, 348)
        Me.MetroTextBox7.MaxLength = 32767
        Me.MetroTextBox7.Name = "MetroTextBox7"
        Me.MetroTextBox7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox7.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox7.SelectedText = ""
        Me.MetroTextBox7.SelectionLength = 0
        Me.MetroTextBox7.SelectionStart = 0
        Me.MetroTextBox7.Size = New System.Drawing.Size(209, 29)
        Me.MetroTextBox7.TabIndex = 67
        Me.MetroTextBox7.UseSelectable = True
        Me.MetroTextBox7.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox7.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTextBox6
        '
        '
        '
        '
        Me.MetroTextBox6.CustomButton.Image = Nothing
        Me.MetroTextBox6.CustomButton.Location = New System.Drawing.Point(184, 1)
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
        Me.MetroTextBox6.Location = New System.Drawing.Point(162, 6)
        Me.MetroTextBox6.MaxLength = 32767
        Me.MetroTextBox6.Name = "MetroTextBox6"
        Me.MetroTextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox6.SelectedText = ""
        Me.MetroTextBox6.SelectionLength = 0
        Me.MetroTextBox6.SelectionStart = 0
        Me.MetroTextBox6.Size = New System.Drawing.Size(212, 29)
        Me.MetroTextBox6.TabIndex = 65
        Me.MetroTextBox6.UseSelectable = True
        Me.MetroTextBox6.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox6.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tbTotal
        '
        '
        '
        '
        Me.tbTotal.CustomButton.Image = Nothing
        Me.tbTotal.CustomButton.Location = New System.Drawing.Point(208, 1)
        Me.tbTotal.CustomButton.Name = ""
        Me.tbTotal.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbTotal.CustomButton.TabIndex = 1
        Me.tbTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbTotal.CustomButton.UseSelectable = True
        Me.tbTotal.CustomButton.Visible = False
        Me.tbTotal.Enabled = False
        Me.tbTotal.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbTotal.Lines = New String(-1) {}
        Me.tbTotal.Location = New System.Drawing.Point(695, 9)
        Me.tbTotal.MaxLength = 32767
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbTotal.SelectedText = ""
        Me.tbTotal.SelectionLength = 0
        Me.tbTotal.SelectionStart = 0
        Me.tbTotal.Size = New System.Drawing.Size(236, 29)
        Me.tbTotal.TabIndex = 34
        Me.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbTotal.UseSelectable = True
        Me.tbTotal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbTotal.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnSaveInv.Image = CType(resources.GetObject("btnSaveInv.Image"), System.Drawing.Image)
        Me.btnSaveInv.ImageSize = 25
        Me.btnSaveInv.Location = New System.Drawing.Point(937, 9)
        Me.btnSaveInv.Name = "btnSaveInv"
        Me.btnSaveInv.NoFocusImage = CType(resources.GetObject("btnSaveInv.NoFocusImage"), System.Drawing.Image)
        Me.btnSaveInv.Size = New System.Drawing.Size(34, 30)
        Me.btnSaveInv.TabIndex = 61
        Me.btnSaveInv.UseSelectable = True
        '
        'btnRollUp
        '
        Me.btnRollUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRollUp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRollUp.Image = CType(resources.GetObject("btnRollUp.Image"), System.Drawing.Image)
        Me.btnRollUp.ImageSize = 20
        Me.btnRollUp.Location = New System.Drawing.Point(3, 357)
        Me.btnRollUp.Name = "btnRollUp"
        Me.btnRollUp.NoFocusImage = CType(resources.GetObject("btnRollUp.NoFocusImage"), System.Drawing.Image)
        Me.btnRollUp.Size = New System.Drawing.Size(21, 23)
        Me.btnRollUp.TabIndex = 60
        Me.btnRollUp.UseSelectable = True
        Me.btnRollUp.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.btnRollUp)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 155)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(27, 383)
        Me.Panel6.TabIndex = 26
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
        'tbAccSearch
        '
        '
        '
        '
        Me.tbAccSearch.CustomButton.Image = Nothing
        Me.tbAccSearch.CustomButton.Location = New System.Drawing.Point(109, 1)
        Me.tbAccSearch.CustomButton.Name = ""
        Me.tbAccSearch.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbAccSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbAccSearch.CustomButton.TabIndex = 1
        Me.tbAccSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbAccSearch.CustomButton.UseSelectable = True
        Me.tbAccSearch.CustomButton.Visible = False
        Me.tbAccSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbAccSearch.Lines = New String(-1) {}
        Me.tbAccSearch.Location = New System.Drawing.Point(820, 14)
        Me.tbAccSearch.MaxLength = 32767
        Me.tbAccSearch.Name = "tbAccSearch"
        Me.tbAccSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbAccSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbAccSearch.SelectedText = ""
        Me.tbAccSearch.SelectionLength = 0
        Me.tbAccSearch.SelectionStart = 0
        Me.tbAccSearch.Size = New System.Drawing.Size(137, 29)
        Me.tbAccSearch.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbAccSearch.TabIndex = 43
        Me.tbAccSearch.UseSelectable = True
        Me.tbAccSearch.WaterMark = "Account"
        Me.tbAccSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbAccSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(820, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 29)
        Me.Button1.TabIndex = 67
        Me.Button1.Text = "Balance"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.Controls.Add(Me.chkPrintPreview)
        Me.Panel9.Controls.Add(Me.chkPrint)
        Me.Panel9.Controls.Add(Me.tbTotal)
        Me.Panel9.Controls.Add(Me.tbNarration)
        Me.Panel9.Controls.Add(Me.lblInvNo)
        Me.Panel9.Controls.Add(Me.btnSaveInv)
        Me.Panel9.Controls.Add(Me.btnRollDown)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 538)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1200, 105)
        Me.Panel9.TabIndex = 27
        '
        'chkPrintPreview
        '
        Me.chkPrintPreview.AutoSize = True
        Me.chkPrintPreview.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.chkPrintPreview.Location = New System.Drawing.Point(547, 71)
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
        Me.chkPrint.Location = New System.Drawing.Point(547, 48)
        Me.chkPrint.Name = "chkPrint"
        Me.chkPrint.Size = New System.Drawing.Size(117, 19)
        Me.chkPrint.TabIndex = 75
        Me.chkPrint.Text = "Print after save"
        Me.chkPrint.UseSelectable = True
        '
        'tbReference
        '
        '
        '
        '
        Me.tbReference.CustomButton.Image = Nothing
        Me.tbReference.CustomButton.Location = New System.Drawing.Point(194, 1)
        Me.tbReference.CustomButton.Name = ""
        Me.tbReference.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbReference.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbReference.CustomButton.TabIndex = 1
        Me.tbReference.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbReference.CustomButton.UseSelectable = True
        Me.tbReference.CustomButton.Visible = False
        Me.tbReference.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbReference.Lines = New String(-1) {}
        Me.tbReference.Location = New System.Drawing.Point(393, 48)
        Me.tbReference.MaxLength = 32767
        Me.tbReference.Name = "tbReference"
        Me.tbReference.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbReference.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbReference.SelectedText = ""
        Me.tbReference.SelectionLength = 0
        Me.tbReference.SelectionStart = 0
        Me.tbReference.Size = New System.Drawing.Size(222, 29)
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
        Me.cbVoucherType.Location = New System.Drawing.Point(137, 14)
        Me.cbVoucherType.Name = "cbVoucherType"
        Me.cbVoucherType.Size = New System.Drawing.Size(250, 29)
        Me.cbVoucherType.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbVoucherType.TabIndex = 37
        Me.cbVoucherType.UseSelectable = True
        '
        'TbVouchersBindingSource
        '
        Me.TbVouchersBindingSource.DataMember = "tbVouchers"
        Me.TbVouchersBindingSource.DataSource = Me.ACCDBDataSet
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
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.tbDRCRMain)
        Me.Panel1.Controls.Add(Me.tbMainAccBalance)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.tbMainAccSearch)
        Me.Panel1.Controls.Add(Me.cbMainAccount)
        Me.Panel1.Controls.Add(Me.tbAccSearch)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.tbReference)
        Me.Panel1.Controls.Add(Me.cbVoucherType)
        Me.Panel1.Controls.Add(Me.cbCostCenter)
        Me.Panel1.Controls.Add(Me.tbDRCRAcc)
        Me.Panel1.Controls.Add(Me.tbBalance)
        Me.Panel1.Controls.Add(Me.btnAddAccount)
        Me.Panel1.Controls.Add(Me.tbAmount)
        Me.Panel1.Controls.Add(Me.cbAccount)
        Me.Panel1.Controls.Add(Me.dtDate)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 155)
        Me.Panel1.TabIndex = 24
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(27, 115)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 29)
        Me.Button4.TabIndex = 74
        Me.Button4.Text = "Balance"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'tbDRCRMain
        '
        '
        '
        '
        Me.tbDRCRMain.CustomButton.Image = Nothing
        Me.tbDRCRMain.CustomButton.Location = New System.Drawing.Point(15, 1)
        Me.tbDRCRMain.CustomButton.Name = ""
        Me.tbDRCRMain.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbDRCRMain.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbDRCRMain.CustomButton.TabIndex = 1
        Me.tbDRCRMain.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbDRCRMain.CustomButton.UseSelectable = True
        Me.tbDRCRMain.CustomButton.Visible = False
        Me.tbDRCRMain.Enabled = False
        Me.tbDRCRMain.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbDRCRMain.Lines = New String(-1) {}
        Me.tbDRCRMain.Location = New System.Drawing.Point(137, 115)
        Me.tbDRCRMain.MaxLength = 32767
        Me.tbDRCRMain.Name = "tbDRCRMain"
        Me.tbDRCRMain.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbDRCRMain.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbDRCRMain.SelectedText = ""
        Me.tbDRCRMain.SelectionLength = 0
        Me.tbDRCRMain.SelectionStart = 0
        Me.tbDRCRMain.Size = New System.Drawing.Size(43, 29)
        Me.tbDRCRMain.TabIndex = 73
        Me.tbDRCRMain.UseSelectable = True
        Me.tbDRCRMain.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbDRCRMain.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tbMainAccBalance
        '
        '
        '
        '
        Me.tbMainAccBalance.CustomButton.Image = Nothing
        Me.tbMainAccBalance.CustomButton.Location = New System.Drawing.Point(177, 1)
        Me.tbMainAccBalance.CustomButton.Name = ""
        Me.tbMainAccBalance.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbMainAccBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbMainAccBalance.CustomButton.TabIndex = 1
        Me.tbMainAccBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbMainAccBalance.CustomButton.UseSelectable = True
        Me.tbMainAccBalance.CustomButton.Visible = False
        Me.tbMainAccBalance.Enabled = False
        Me.tbMainAccBalance.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbMainAccBalance.Lines = New String(-1) {}
        Me.tbMainAccBalance.Location = New System.Drawing.Point(182, 115)
        Me.tbMainAccBalance.MaxLength = 32767
        Me.tbMainAccBalance.Name = "tbMainAccBalance"
        Me.tbMainAccBalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbMainAccBalance.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbMainAccBalance.SelectedText = ""
        Me.tbMainAccBalance.SelectionLength = 0
        Me.tbMainAccBalance.SelectionStart = 0
        Me.tbMainAccBalance.Size = New System.Drawing.Size(205, 29)
        Me.tbMainAccBalance.TabIndex = 72
        Me.tbMainAccBalance.UseSelectable = True
        Me.tbMainAccBalance.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbMainAccBalance.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(27, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 29)
        Me.Button3.TabIndex = 71
        Me.Button3.Text = "Voucher Type"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(27, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 28)
        Me.Button2.TabIndex = 70
        Me.Button2.Text = "Cost Center"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tbMainAccSearch
        '
        '
        '
        '
        Me.tbMainAccSearch.CustomButton.Image = Nothing
        Me.tbMainAccSearch.CustomButton.Location = New System.Drawing.Point(80, 1)
        Me.tbMainAccSearch.CustomButton.Name = ""
        Me.tbMainAccSearch.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbMainAccSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbMainAccSearch.CustomButton.TabIndex = 1
        Me.tbMainAccSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbMainAccSearch.CustomButton.UseSelectable = True
        Me.tbMainAccSearch.CustomButton.Visible = False
        Me.tbMainAccSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbMainAccSearch.Lines = New String(-1) {}
        Me.tbMainAccSearch.Location = New System.Drawing.Point(27, 82)
        Me.tbMainAccSearch.MaxLength = 32767
        Me.tbMainAccSearch.Name = "tbMainAccSearch"
        Me.tbMainAccSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbMainAccSearch.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbMainAccSearch.SelectedText = ""
        Me.tbMainAccSearch.SelectionLength = 0
        Me.tbMainAccSearch.SelectionStart = 0
        Me.tbMainAccSearch.Size = New System.Drawing.Size(108, 29)
        Me.tbMainAccSearch.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbMainAccSearch.TabIndex = 69
        Me.tbMainAccSearch.UseSelectable = True
        Me.tbMainAccSearch.WaterMark = "Account"
        Me.tbMainAccSearch.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbMainAccSearch.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cbMainAccount
        '
        Me.cbMainAccount.DataSource = Me.TbAccountsBindingSource
        Me.cbMainAccount.DisplayMember = "Account_Name"
        Me.cbMainAccount.FormattingEnabled = True
        Me.cbMainAccount.ItemHeight = 23
        Me.cbMainAccount.Location = New System.Drawing.Point(137, 82)
        Me.cbMainAccount.Name = "cbMainAccount"
        Me.cbMainAccount.Size = New System.Drawing.Size(478, 29)
        Me.cbMainAccount.TabIndex = 68
        Me.cbMainAccount.UseSelectable = True
        '
        'TbAccountsBindingSource
        '
        Me.TbAccountsBindingSource.DataMember = "tbAccounts"
        Me.TbAccountsBindingSource.DataSource = Me.ACCDBDataSet
        '
        'cbCostCenter
        '
        Me.cbCostCenter.DataSource = Me.TbCostCenterListBindingSource
        Me.cbCostCenter.DisplayMember = "Cost_Center"
        Me.cbCostCenter.FormattingEnabled = True
        Me.cbCostCenter.ItemHeight = 23
        Me.cbCostCenter.Location = New System.Drawing.Point(137, 48)
        Me.cbCostCenter.Name = "cbCostCenter"
        Me.cbCostCenter.Size = New System.Drawing.Size(250, 29)
        Me.cbCostCenter.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbCostCenter.TabIndex = 36
        Me.cbCostCenter.UseSelectable = True
        '
        'TbCostCenterListBindingSource
        '
        Me.TbCostCenterListBindingSource.DataMember = "tbCostCenterList"
        Me.TbCostCenterListBindingSource.DataSource = Me.ACCDBDataSet
        '
        'tbDRCRAcc
        '
        '
        '
        '
        Me.tbDRCRAcc.CustomButton.Image = Nothing
        Me.tbDRCRAcc.CustomButton.Location = New System.Drawing.Point(15, 1)
        Me.tbDRCRAcc.CustomButton.Name = ""
        Me.tbDRCRAcc.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbDRCRAcc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbDRCRAcc.CustomButton.TabIndex = 1
        Me.tbDRCRAcc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbDRCRAcc.CustomButton.UseSelectable = True
        Me.tbDRCRAcc.CustomButton.Visible = False
        Me.tbDRCRAcc.Enabled = False
        Me.tbDRCRAcc.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbDRCRAcc.Lines = New String(-1) {}
        Me.tbDRCRAcc.Location = New System.Drawing.Point(899, 115)
        Me.tbDRCRAcc.MaxLength = 32767
        Me.tbDRCRAcc.Name = "tbDRCRAcc"
        Me.tbDRCRAcc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbDRCRAcc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbDRCRAcc.SelectedText = ""
        Me.tbDRCRAcc.SelectionLength = 0
        Me.tbDRCRAcc.SelectionStart = 0
        Me.tbDRCRAcc.Size = New System.Drawing.Size(43, 29)
        Me.tbDRCRAcc.TabIndex = 35
        Me.tbDRCRAcc.UseSelectable = True
        Me.tbDRCRAcc.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbDRCRAcc.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tbBalance
        '
        '
        '
        '
        Me.tbBalance.CustomButton.Image = Nothing
        Me.tbBalance.CustomButton.Location = New System.Drawing.Point(214, 1)
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
        Me.tbBalance.Location = New System.Drawing.Point(944, 115)
        Me.tbBalance.MaxLength = 32767
        Me.tbBalance.Name = "tbBalance"
        Me.tbBalance.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbBalance.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbBalance.SelectedText = ""
        Me.tbBalance.SelectionLength = 0
        Me.tbBalance.SelectionStart = 0
        Me.tbBalance.Size = New System.Drawing.Size(242, 29)
        Me.tbBalance.TabIndex = 33
        Me.tbBalance.UseSelectable = True
        Me.tbBalance.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbBalance.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnAddAccount
        '
        Me.btnAddAccount.Location = New System.Drawing.Point(1062, 82)
        Me.btnAddAccount.Name = "btnAddAccount"
        Me.btnAddAccount.Size = New System.Drawing.Size(124, 29)
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
        Me.tbAmount.CustomButton.Location = New System.Drawing.Point(208, 1)
        Me.tbAmount.CustomButton.Name = ""
        Me.tbAmount.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbAmount.CustomButton.TabIndex = 1
        Me.tbAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbAmount.CustomButton.UseSelectable = True
        Me.tbAmount.CustomButton.Visible = False
        Me.tbAmount.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbAmount.Lines = New String(-1) {}
        Me.tbAmount.Location = New System.Drawing.Point(820, 82)
        Me.tbAmount.MaxLength = 32767
        Me.tbAmount.Name = "tbAmount"
        Me.tbAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbAmount.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbAmount.SelectedText = ""
        Me.tbAmount.SelectionLength = 0
        Me.tbAmount.SelectionStart = 0
        Me.tbAmount.Size = New System.Drawing.Size(236, 29)
        Me.tbAmount.TabIndex = 30
        Me.tbAmount.UseSelectable = True
        Me.tbAmount.WaterMark = "Amount"
        Me.tbAmount.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbAmount.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cbAccount
        '
        Me.cbAccount.FormattingEnabled = True
        Me.cbAccount.ItemHeight = 23
        Me.cbAccount.Location = New System.Drawing.Point(820, 48)
        Me.cbAccount.Name = "cbAccount"
        Me.cbAccount.Size = New System.Drawing.Size(366, 29)
        Me.cbAccount.TabIndex = 27
        Me.cbAccount.UseSelectable = True
        '
        'dtDate
        '
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDate.Location = New System.Drawing.Point(393, 14)
        Me.dtDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(222, 29)
        Me.dtDate.TabIndex = 25
        '
        'cmsRemoveAcc
        '
        Me.cmsRemoveAcc.Name = "cmsRemoveAcc"
        Me.cmsRemoveAcc.Size = New System.Drawing.Size(126, 22)
        Me.cmsRemoveAcc.Text = "Remove"
        '
        'cmsAddRef
        '
        Me.cmsAddRef.Name = "cmsAddRef"
        Me.cmsAddRef.Size = New System.Drawing.Size(126, 22)
        Me.cmsAddRef.Text = "Reference"
        '
        'cmAccounts
        '
        Me.cmAccounts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsAddRef, Me.cmsRemoveAcc})
        Me.cmAccounts.Name = "cmInv"
        Me.cmAccounts.Size = New System.Drawing.Size(127, 48)
        '
        'dgPayment
        '
        Me.dgPayment.AllowUserToAddRows = False
        Me.dgPayment.AllowUserToDeleteRows = False
        Me.dgPayment.AllowUserToResizeColumns = False
        Me.dgPayment.AllowUserToResizeRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgPayment.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgPayment.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgPayment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgPayment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgPayment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPayment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPayment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.colParticula, Me.colDebit})
        Me.dgPayment.ContextMenuStrip = Me.cmAccounts
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPayment.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgPayment.EnableHeadersVisualStyles = False
        Me.dgPayment.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgPayment.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgPayment.Location = New System.Drawing.Point(27, 155)
        Me.dgPayment.MultiSelect = False
        Me.dgPayment.Name = "dgPayment"
        Me.dgPayment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPayment.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgPayment.RowHeadersVisible = False
        Me.dgPayment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPayment.Size = New System.Drawing.Size(770, 383)
        Me.dgPayment.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgPayment.TabIndex = 25
        '
        'Column2
        '
        Me.Column2.HeaderText = "No"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 40
        '
        'colParticula
        '
        Me.colParticula.HeaderText = "Account Name"
        Me.colParticula.Name = "colParticula"
        Me.colParticula.ReadOnly = True
        Me.colParticula.Width = 500
        '
        'colDebit
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.colDebit.DefaultCellStyle = DataGridViewCellStyle12
        Me.colDebit.HeaderText = "Amount"
        Me.colDebit.Name = "colDebit"
        Me.colDebit.Width = 200
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
        'TbAccountTransTableAdapter
        '
        Me.TbAccountTransTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(49, 258)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(379, 239)
        Me.DataGridView1.TabIndex = 77
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(435, 258)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(379, 239)
        Me.DataGridView2.TabIndex = 78
        '
        'pnlPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.pnlAgainstRef)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dgPayment)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "pnlPayment"
        Me.Size = New System.Drawing.Size(1200, 643)
        Me.pnlAgainstRef.ResumeLayout(False)
        CType(Me.dgRef, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.TbVouchersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACCDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.TbAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbCostCenterListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmAccounts.ResumeLayout(False)
        CType(Me.dgPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlAgainstRef As System.Windows.Forms.Panel
    Friend WithEvents MetroTextBox7 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox6 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbTotal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbNarration As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblInvNo As System.Windows.Forms.Label
    Friend WithEvents btnSaveInv As MetroFramework.Controls.MetroLink
    Friend WithEvents btnRollUp As MetroFramework.Controls.MetroLink
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnRollDown As MetroFramework.Controls.MetroLink
    Friend WithEvents tbAccSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents tbReference As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cbVoucherType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents tbDRCRMain As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbMainAccBalance As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tbMainAccSearch As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cbMainAccount As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbCostCenter As MetroFramework.Controls.MetroComboBox
    Friend WithEvents tbDRCRAcc As MetroFramework.Controls.MetroTextBox
    Friend WithEvents tbBalance As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnAddAccount As MetroFramework.Controls.MetroButton
    Friend WithEvents tbAmount As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cbAccount As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dtDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cmsRemoveAcc As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsAddRef As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmAccounts As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents dgPayment As MetroFramework.Controls.MetroGrid
    Friend WithEvents TbVouchersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACCDBDataSet As Acc_System.ACCDBDataSet
    Friend WithEvents TbAccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbCostCenterListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TbVouchersTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbVouchersTableAdapter
    Friend WithEvents TbCostCenterListTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbCostCenterListTableAdapter
    Friend WithEvents TbAccountsTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbAccountsTableAdapter
    Friend WithEvents TbAccountTransTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbAccountTransTableAdapter
    Friend WithEvents chkPrintPreview As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkPrint As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colParticula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDebit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgRef As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView

End Class
