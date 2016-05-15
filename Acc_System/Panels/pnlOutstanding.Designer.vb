<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlOutstanding
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnRun = New MetroFramework.Controls.MetroButton()
        Me.cbAccount = New MetroFramework.Controls.MetroComboBox()
        Me.TbAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACCDBDataSet = New Acc_System.ACCDBDataSet()
        Me.dgOutstanding = New MetroFramework.Controls.MetroGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.rbAccounts = New MetroFramework.Controls.MetroRadioButton()
        Me.rbReceivables = New MetroFramework.Controls.MetroRadioButton()
        Me.rbPayables = New MetroFramework.Controls.MetroRadioButton()
        Me.CustomPanel1 = New Acc_System.CustomPanel()
        Me.tbAccount = New MetroFramework.Controls.MetroTextBox()
        Me.CustomPanel2 = New Acc_System.CustomPanel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.dtEnd = New MetroFramework.Controls.MetroDateTime()
        Me.dtStart = New MetroFramework.Controls.MetroDateTime()
        Me.CustomPanel5 = New Acc_System.CustomPanel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.CustomPanel6 = New Acc_System.CustomPanel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.CustomPanel3 = New Acc_System.CustomPanel()
        Me.CustomPanel4 = New Acc_System.CustomPanel()
        Me.TbAccountsTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbAccountsTableAdapter()
        Me.TbAccountTransTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbAccountTransTableAdapter()
        Me.rbAll = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroRadioButton1 = New MetroFramework.Controls.MetroRadioButton()
        CType(Me.TbAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACCDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgOutstanding, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomPanel1.SuspendLayout()
        Me.CustomPanel2.SuspendLayout()
        Me.CustomPanel5.SuspendLayout()
        Me.CustomPanel6.SuspendLayout()
        Me.CustomPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(514, 67)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(114, 29)
        Me.btnRun.TabIndex = 70
        Me.btnRun.Text = "Run"
        Me.btnRun.UseSelectable = True
        '
        'cbAccount
        '
        Me.cbAccount.DataSource = Me.TbAccountsBindingSource
        Me.cbAccount.DisplayMember = "Account_Name"
        Me.cbAccount.FormattingEnabled = True
        Me.cbAccount.ItemHeight = 23
        Me.cbAccount.Location = New System.Drawing.Point(146, 67)
        Me.cbAccount.Name = "cbAccount"
        Me.cbAccount.Size = New System.Drawing.Size(362, 29)
        Me.cbAccount.TabIndex = 69
        Me.cbAccount.UseSelectable = True
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
        'dgOutstanding
        '
        Me.dgOutstanding.AllowUserToAddRows = False
        Me.dgOutstanding.AllowUserToDeleteRows = False
        Me.dgOutstanding.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgOutstanding.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgOutstanding.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgOutstanding.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgOutstanding.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgOutstanding.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgOutstanding.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgOutstanding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOutstanding.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column7})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgOutstanding.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgOutstanding.EnableHeadersVisualStyles = False
        Me.dgOutstanding.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgOutstanding.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgOutstanding.Location = New System.Drawing.Point(15, 29)
        Me.dgOutstanding.MultiSelect = False
        Me.dgOutstanding.Name = "dgOutstanding"
        Me.dgOutstanding.ReadOnly = True
        Me.dgOutstanding.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgOutstanding.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgOutstanding.RowHeadersVisible = False
        Me.dgOutstanding.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgOutstanding.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgOutstanding.Size = New System.Drawing.Size(1152, 433)
        Me.dgOutstanding.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgOutstanding.TabIndex = 61
        '
        'Column1
        '
        Me.Column1.HeaderText = "Date"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Vch No."
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Account"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 450
        '
        'Column4
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column4.HeaderText = "Amount"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 130
        '
        'Column6
        '
        Me.Column6.HeaderText = "Due Date"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 130
        '
        'Column7
        '
        Me.Column7.HeaderText = "Paid"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column7.Width = 40
        '
        'rbAccounts
        '
        Me.rbAccounts.AutoSize = True
        Me.rbAccounts.Checked = True
        Me.rbAccounts.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.rbAccounts.Location = New System.Drawing.Point(15, 35)
        Me.rbAccounts.Name = "rbAccounts"
        Me.rbAccounts.Size = New System.Drawing.Size(125, 19)
        Me.rbAccounts.TabIndex = 71
        Me.rbAccounts.TabStop = True
        Me.rbAccounts.Text = "Choose Account"
        Me.rbAccounts.UseSelectable = True
        '
        'rbReceivables
        '
        Me.rbReceivables.AutoSize = True
        Me.rbReceivables.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.rbReceivables.Location = New System.Drawing.Point(303, 35)
        Me.rbReceivables.Name = "rbReceivables"
        Me.rbReceivables.Size = New System.Drawing.Size(167, 19)
        Me.rbReceivables.TabIndex = 72
        Me.rbReceivables.Text = "All Accounts Receivable"
        Me.rbReceivables.UseSelectable = True
        '
        'rbPayables
        '
        Me.rbPayables.AutoSize = True
        Me.rbPayables.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.rbPayables.Location = New System.Drawing.Point(146, 35)
        Me.rbPayables.Name = "rbPayables"
        Me.rbPayables.Size = New System.Drawing.Size(151, 19)
        Me.rbPayables.TabIndex = 73
        Me.rbPayables.Text = "All Accounts Payable"
        Me.rbPayables.UseSelectable = True
        '
        'CustomPanel1
        '
        Me.CustomPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomPanel1.Controls.Add(Me.tbAccount)
        Me.CustomPanel1.Controls.Add(Me.CustomPanel2)
        Me.CustomPanel1.Controls.Add(Me.cbAccount)
        Me.CustomPanel1.Controls.Add(Me.btnRun)
        Me.CustomPanel1.Controls.Add(Me.rbReceivables)
        Me.CustomPanel1.Controls.Add(Me.rbAccounts)
        Me.CustomPanel1.Controls.Add(Me.rbPayables)
        Me.CustomPanel1.Curvature = 10
        Me.CustomPanel1.Location = New System.Drawing.Point(16, 11)
        Me.CustomPanel1.Name = "CustomPanel1"
        Me.CustomPanel1.Size = New System.Drawing.Size(646, 106)
        Me.CustomPanel1.TabIndex = 75
        '
        'tbAccount
        '
        '
        '
        '
        Me.tbAccount.CustomButton.Image = Nothing
        Me.tbAccount.CustomButton.Location = New System.Drawing.Point(97, 1)
        Me.tbAccount.CustomButton.Name = ""
        Me.tbAccount.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.tbAccount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.tbAccount.CustomButton.TabIndex = 1
        Me.tbAccount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tbAccount.CustomButton.UseSelectable = True
        Me.tbAccount.CustomButton.Visible = False
        Me.tbAccount.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.tbAccount.Lines = New String(-1) {}
        Me.tbAccount.Location = New System.Drawing.Point(15, 67)
        Me.tbAccount.MaxLength = 32767
        Me.tbAccount.Name = "tbAccount"
        Me.tbAccount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbAccount.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.tbAccount.SelectedText = ""
        Me.tbAccount.SelectionLength = 0
        Me.tbAccount.SelectionStart = 0
        Me.tbAccount.Size = New System.Drawing.Size(125, 29)
        Me.tbAccount.Style = MetroFramework.MetroColorStyle.Teal
        Me.tbAccount.TabIndex = 74
        Me.tbAccount.UseSelectable = True
        Me.tbAccount.WaterMark = "Account"
        Me.tbAccount.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.tbAccount.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'CustomPanel2
        '
        Me.CustomPanel2.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomPanel2.Controls.Add(Me.MetroLabel9)
        Me.CustomPanel2.Curvature = 10
        Me.CustomPanel2.CurveMode = CType((Acc_System.CornerCurveMode.TopLeft Or Acc_System.CornerCurveMode.TopRight), Acc_System.CornerCurveMode)
        Me.CustomPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel2.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel2.Name = "CustomPanel2"
        Me.CustomPanel2.Size = New System.Drawing.Size(646, 23)
        Me.CustomPanel2.TabIndex = 44
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel9.Location = New System.Drawing.Point(15, 1)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel9.TabIndex = 48
        Me.MetroLabel9.Text = "Filter"
        Me.MetroLabel9.UseCustomBackColor = True
        '
        'dtEnd
        '
        Me.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEnd.Location = New System.Drawing.Point(271, 67)
        Me.dtEnd.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtEnd.Name = "dtEnd"
        Me.dtEnd.Size = New System.Drawing.Size(239, 29)
        Me.dtEnd.TabIndex = 75
        '
        'dtStart
        '
        Me.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtStart.Location = New System.Drawing.Point(271, 32)
        Me.dtStart.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtStart.Name = "dtStart"
        Me.dtStart.Size = New System.Drawing.Size(239, 29)
        Me.dtStart.TabIndex = 74
        '
        'CustomPanel5
        '
        Me.CustomPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomPanel5.Controls.Add(Me.MetroButton1)
        Me.CustomPanel5.Controls.Add(Me.CustomPanel6)
        Me.CustomPanel5.Controls.Add(Me.dgOutstanding)
        Me.CustomPanel5.Curvature = 10
        Me.CustomPanel5.Location = New System.Drawing.Point(16, 123)
        Me.CustomPanel5.Name = "CustomPanel5"
        Me.CustomPanel5.Size = New System.Drawing.Size(1170, 505)
        Me.CustomPanel5.TabIndex = 76
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(1024, 470)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(114, 29)
        Me.MetroButton1.TabIndex = 76
        Me.MetroButton1.Text = "Save Changes"
        Me.MetroButton1.UseSelectable = True
        '
        'CustomPanel6
        '
        Me.CustomPanel6.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomPanel6.Controls.Add(Me.MetroLabel10)
        Me.CustomPanel6.Curvature = 10
        Me.CustomPanel6.CurveMode = CType((Acc_System.CornerCurveMode.TopLeft Or Acc_System.CornerCurveMode.TopRight), Acc_System.CornerCurveMode)
        Me.CustomPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel6.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel6.Name = "CustomPanel6"
        Me.CustomPanel6.Size = New System.Drawing.Size(1170, 23)
        Me.CustomPanel6.TabIndex = 44
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel10.Location = New System.Drawing.Point(543, 2)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(85, 19)
        Me.MetroLabel10.TabIndex = 49
        Me.MetroLabel10.Text = "Transactions"
        Me.MetroLabel10.UseCustomBackColor = True
        '
        'CustomPanel3
        '
        Me.CustomPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomPanel3.Controls.Add(Me.MetroRadioButton1)
        Me.CustomPanel3.Controls.Add(Me.rbAll)
        Me.CustomPanel3.Controls.Add(Me.dtEnd)
        Me.CustomPanel3.Controls.Add(Me.CustomPanel4)
        Me.CustomPanel3.Controls.Add(Me.dtStart)
        Me.CustomPanel3.Curvature = 10
        Me.CustomPanel3.Location = New System.Drawing.Point(668, 11)
        Me.CustomPanel3.Name = "CustomPanel3"
        Me.CustomPanel3.Size = New System.Drawing.Size(518, 106)
        Me.CustomPanel3.TabIndex = 77
        '
        'CustomPanel4
        '
        Me.CustomPanel4.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomPanel4.Curvature = 10
        Me.CustomPanel4.CurveMode = CType((Acc_System.CornerCurveMode.TopLeft Or Acc_System.CornerCurveMode.TopRight), Acc_System.CornerCurveMode)
        Me.CustomPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel4.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel4.Name = "CustomPanel4"
        Me.CustomPanel4.Size = New System.Drawing.Size(518, 23)
        Me.CustomPanel4.TabIndex = 44
        '
        'TbAccountsTableAdapter
        '
        Me.TbAccountsTableAdapter.ClearBeforeFill = True
        '
        'TbAccountTransTableAdapter
        '
        Me.TbAccountTransTableAdapter.ClearBeforeFill = True
        '
        'rbAll
        '
        Me.rbAll.AutoSize = True
        Me.rbAll.Checked = True
        Me.rbAll.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.rbAll.Location = New System.Drawing.Point(16, 42)
        Me.rbAll.Name = "rbAll"
        Me.rbAll.Size = New System.Drawing.Size(135, 19)
        Me.rbAll.TabIndex = 76
        Me.rbAll.TabStop = True
        Me.rbAll.Text = "Outstanding Only"
        Me.rbAll.UseSelectable = True
        '
        'MetroRadioButton1
        '
        Me.MetroRadioButton1.AutoSize = True
        Me.MetroRadioButton1.FontSize = MetroFramework.MetroCheckBoxSize.Medium
        Me.MetroRadioButton1.Location = New System.Drawing.Point(16, 67)
        Me.MetroRadioButton1.Name = "MetroRadioButton1"
        Me.MetroRadioButton1.Size = New System.Drawing.Size(40, 19)
        Me.MetroRadioButton1.TabIndex = 77
        Me.MetroRadioButton1.Text = "All"
        Me.MetroRadioButton1.UseSelectable = True
        '
        'pnlOutstanding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CustomPanel3)
        Me.Controls.Add(Me.CustomPanel5)
        Me.Controls.Add(Me.CustomPanel1)
        Me.Name = "pnlOutstanding"
        Me.Size = New System.Drawing.Size(1200, 643)
        CType(Me.TbAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACCDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgOutstanding, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomPanel1.ResumeLayout(False)
        Me.CustomPanel1.PerformLayout()
        Me.CustomPanel2.ResumeLayout(False)
        Me.CustomPanel2.PerformLayout()
        Me.CustomPanel5.ResumeLayout(False)
        Me.CustomPanel6.ResumeLayout(False)
        Me.CustomPanel6.PerformLayout()
        Me.CustomPanel3.ResumeLayout(False)
        Me.CustomPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRun As MetroFramework.Controls.MetroButton
    Friend WithEvents cbAccount As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dgOutstanding As MetroFramework.Controls.MetroGrid
    Friend WithEvents rbAccounts As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbReceivables As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbPayables As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents CustomPanel1 As Acc_System.CustomPanel
    Friend WithEvents CustomPanel2 As Acc_System.CustomPanel
    Friend WithEvents dtEnd As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtStart As MetroFramework.Controls.MetroDateTime
    Friend WithEvents CustomPanel5 As Acc_System.CustomPanel
    Friend WithEvents CustomPanel6 As Acc_System.CustomPanel
    Friend WithEvents CustomPanel3 As Acc_System.CustomPanel
    Friend WithEvents CustomPanel4 As Acc_System.CustomPanel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TbAccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACCDBDataSet As Acc_System.ACCDBDataSet
    Friend WithEvents TbAccountsTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbAccountsTableAdapter
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents TbAccountTransTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbAccountTransTableAdapter
    Friend WithEvents tbAccount As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MetroRadioButton1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbAll As MetroFramework.Controls.MetroRadioButton

End Class
