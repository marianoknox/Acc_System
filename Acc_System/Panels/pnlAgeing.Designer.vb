<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlAgeing
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pnlAgeing))
        Me.cbVoucherType = New MetroFramework.Controls.MetroComboBox()
        Me.dgInvItem = New MetroFramework.Controls.MetroGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroCheckBox1 = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroCheckBox2 = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroCheckBox3 = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroCheckBox4 = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroCheckBox6 = New MetroFramework.Controls.MetroCheckBox()
        Me.dtInvDate = New MetroFramework.Controls.MetroDateTime()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLink8 = New MetroFramework.Controls.MetroLink()
        Me.btnPrint = New MetroFramework.Controls.MetroLink()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        CType(Me.dgInvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbVoucherType
        '
        Me.cbVoucherType.DisplayMember = "Voucher_Name"
        Me.cbVoucherType.FormattingEnabled = True
        Me.cbVoucherType.ItemHeight = 23
        Me.cbVoucherType.Location = New System.Drawing.Point(38, 18)
        Me.cbVoucherType.Name = "cbVoucherType"
        Me.cbVoucherType.Size = New System.Drawing.Size(311, 29)
        Me.cbVoucherType.TabIndex = 1
        Me.cbVoucherType.UseSelectable = True
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
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgInvItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgInvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgInvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column12, Me.Column4, Me.Column8, Me.Column5, Me.Column9, Me.Column6, Me.Column10, Me.Column7, Me.Column11, Me.Column13, Me.Column14})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgInvItem.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgInvItem.EnableHeadersVisualStyles = False
        Me.dgInvItem.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgInvItem.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgInvItem.Location = New System.Drawing.Point(38, 88)
        Me.dgInvItem.MultiSelect = False
        Me.dgInvItem.Name = "dgInvItem"
        Me.dgInvItem.ReadOnly = True
        Me.dgInvItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgInvItem.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgInvItem.RowHeadersVisible = False
        Me.dgInvItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgInvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgInvItem.Size = New System.Drawing.Size(1124, 535)
        Me.dgInvItem.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.HeaderText = "Code"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Description"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 350
        '
        'Column3
        '
        Me.Column3.HeaderText = "Quantity"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "Amt"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "< 30"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Amt"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "30 - 60"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Amt"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "60 - 90 "
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "Amt"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "90 - 180"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "Amt"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column13
        '
        Me.Column13.HeaderText = "1 Year"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'Column14
        '
        Me.Column14.HeaderText = "Amt"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        '
        'MetroCheckBox1
        '
        Me.MetroCheckBox1.AutoSize = True
        Me.MetroCheckBox1.Checked = True
        Me.MetroCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MetroCheckBox1.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.MetroCheckBox1.Location = New System.Drawing.Point(430, 21)
        Me.MetroCheckBox1.Name = "MetroCheckBox1"
        Me.MetroCheckBox1.Size = New System.Drawing.Size(65, 25)
        Me.MetroCheckBox1.TabIndex = 9
        Me.MetroCheckBox1.Text = "< 30"
        Me.MetroCheckBox1.UseSelectable = True
        '
        'MetroCheckBox2
        '
        Me.MetroCheckBox2.AutoSize = True
        Me.MetroCheckBox2.Checked = True
        Me.MetroCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MetroCheckBox2.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.MetroCheckBox2.Location = New System.Drawing.Point(430, 51)
        Me.MetroCheckBox2.Name = "MetroCheckBox2"
        Me.MetroCheckBox2.Size = New System.Drawing.Size(85, 25)
        Me.MetroCheckBox2.TabIndex = 10
        Me.MetroCheckBox2.Text = "30 - 60"
        Me.MetroCheckBox2.UseSelectable = True
        '
        'MetroCheckBox3
        '
        Me.MetroCheckBox3.AutoSize = True
        Me.MetroCheckBox3.Checked = True
        Me.MetroCheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MetroCheckBox3.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.MetroCheckBox3.Location = New System.Drawing.Point(534, 51)
        Me.MetroCheckBox3.Name = "MetroCheckBox3"
        Me.MetroCheckBox3.Size = New System.Drawing.Size(95, 25)
        Me.MetroCheckBox3.TabIndex = 12
        Me.MetroCheckBox3.Text = "90 - 180"
        Me.MetroCheckBox3.UseSelectable = True
        '
        'MetroCheckBox4
        '
        Me.MetroCheckBox4.AutoSize = True
        Me.MetroCheckBox4.Checked = True
        Me.MetroCheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MetroCheckBox4.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.MetroCheckBox4.Location = New System.Drawing.Point(534, 21)
        Me.MetroCheckBox4.Name = "MetroCheckBox4"
        Me.MetroCheckBox4.Size = New System.Drawing.Size(85, 25)
        Me.MetroCheckBox4.TabIndex = 11
        Me.MetroCheckBox4.Text = "60 - 90"
        Me.MetroCheckBox4.UseSelectable = True
        '
        'MetroCheckBox6
        '
        Me.MetroCheckBox6.AutoSize = True
        Me.MetroCheckBox6.Checked = True
        Me.MetroCheckBox6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MetroCheckBox6.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.MetroCheckBox6.Location = New System.Drawing.Point(633, 21)
        Me.MetroCheckBox6.Name = "MetroCheckBox6"
        Me.MetroCheckBox6.Size = New System.Drawing.Size(77, 25)
        Me.MetroCheckBox6.TabIndex = 13
        Me.MetroCheckBox6.Text = "1 Year"
        Me.MetroCheckBox6.UseSelectable = True
        '
        'dtInvDate
        '
        Me.dtInvDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInvDate.Location = New System.Drawing.Point(925, 15)
        Me.dtInvDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtInvDate.Name = "dtInvDate"
        Me.dtInvDate.Size = New System.Drawing.Size(184, 29)
        Me.dtInvDate.TabIndex = 14
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MetroDateTime1.Location = New System.Drawing.Point(925, 51)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(184, 29)
        Me.MetroDateTime1.TabIndex = 15
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(854, 19)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(65, 25)
        Me.MetroLabel1.TabIndex = 38
        Me.MetroLabel1.Text = "From : "
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(851, 55)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(68, 25)
        Me.MetroLabel2.TabIndex = 39
        Me.MetroLabel2.Text = "Up to : "
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.DisplayMember = "Voucher_Name"
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Location = New System.Drawing.Point(38, 51)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(311, 29)
        Me.MetroComboBox1.TabIndex = 40
        Me.MetroComboBox1.UseSelectable = True
        '
        'MetroLink8
        '
        Me.MetroLink8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroLink8.Image = CType(resources.GetObject("MetroLink8.Image"), System.Drawing.Image)
        Me.MetroLink8.ImageSize = 30
        Me.MetroLink8.Location = New System.Drawing.Point(1121, 10)
        Me.MetroLink8.Name = "MetroLink8"
        Me.MetroLink8.Size = New System.Drawing.Size(37, 34)
        Me.MetroLink8.TabIndex = 42
        Me.MetroLink8.UseSelectable = True
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageSize = 25
        Me.btnPrint.Location = New System.Drawing.Point(1119, 50)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(43, 30)
        Me.btnPrint.TabIndex = 43
        Me.btnPrint.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(356, 18)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(64, 61)
        Me.MetroButton1.TabIndex = 44
        Me.MetroButton1.Text = "Run"
        Me.MetroButton1.UseSelectable = True
        '
        'pnlAgeing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroLink8)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.MetroComboBox1)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroDateTime1)
        Me.Controls.Add(Me.dtInvDate)
        Me.Controls.Add(Me.MetroCheckBox6)
        Me.Controls.Add(Me.MetroCheckBox3)
        Me.Controls.Add(Me.MetroCheckBox4)
        Me.Controls.Add(Me.MetroCheckBox2)
        Me.Controls.Add(Me.MetroCheckBox1)
        Me.Controls.Add(Me.dgInvItem)
        Me.Controls.Add(Me.cbVoucherType)
        Me.Name = "pnlAgeing"
        Me.Size = New System.Drawing.Size(1200, 643)
        CType(Me.dgInvItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbVoucherType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dgInvItem As MetroFramework.Controls.MetroGrid
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MetroCheckBox1 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroCheckBox2 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroCheckBox3 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroCheckBox4 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroCheckBox6 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents dtInvDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLink8 As MetroFramework.Controls.MetroLink
    Friend WithEvents btnPrint As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton

End Class
