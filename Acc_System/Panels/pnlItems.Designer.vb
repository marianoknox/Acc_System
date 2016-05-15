<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlItems
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pnlItems))
        Me.dgItemTrans = New MetroFramework.Controls.MetroGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsFilter = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddFilterByToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmProp = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmQua = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearFiltersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.cbGroup = New MetroFramework.Controls.MetroComboBox()
        Me.rbSelectGroup = New MetroFramework.Controls.MetroRadioButton()
        Me.rbAllGroup = New MetroFramework.Controls.MetroRadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CustomPanel2 = New Acc_System.CustomPanel()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.pnlQuaFilter = New Acc_System.CustomPanel()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.btnQuaFilter = New MetroFramework.Controls.MetroButton()
        Me.MetroCheckBox7 = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroComboBox8 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroCheckBox8 = New MetroFramework.Controls.MetroCheckBox()
        Me.CustomPanel12 = New Acc_System.CustomPanel()
        Me.pnlPropFilter = New Acc_System.CustomPanel()
        Me.btnPropFilter = New MetroFramework.Controls.MetroButton()
        Me.cbColor = New MetroFramework.Controls.MetroComboBox()
        Me.chkColor = New MetroFramework.Controls.MetroCheckBox()
        Me.cbSubCategory = New MetroFramework.Controls.MetroComboBox()
        Me.chkSubCategory = New MetroFramework.Controls.MetroCheckBox()
        Me.cbCategory = New MetroFramework.Controls.MetroComboBox()
        Me.chkCategory = New MetroFramework.Controls.MetroCheckBox()
        Me.cbSupplier = New MetroFramework.Controls.MetroComboBox()
        Me.chkSupplier = New MetroFramework.Controls.MetroCheckBox()
        Me.CustomPanel10 = New Acc_System.CustomPanel()
        Me.CustomPanel4 = New Acc_System.CustomPanel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.btnPrint = New MetroFramework.Controls.MetroLink()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CustomPanel1 = New Acc_System.CustomPanel()
        Me.MetroCheckBox5 = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.dtEnd = New MetroFramework.Controls.MetroDateTime()
        Me.dtStart = New MetroFramework.Controls.MetroDateTime()
        Me.btnRun = New MetroFramework.Controls.MetroButton()
        Me.CustomPanel3 = New Acc_System.CustomPanel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        CType(Me.dgItemTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsFilter.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.CustomPanel2.SuspendLayout()
        Me.pnlQuaFilter.SuspendLayout()
        Me.pnlPropFilter.SuspendLayout()
        Me.CustomPanel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.CustomPanel1.SuspendLayout()
        Me.CustomPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgItemTrans
        '
        Me.dgItemTrans.AllowUserToAddRows = False
        Me.dgItemTrans.AllowUserToDeleteRows = False
        Me.dgItemTrans.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgItemTrans.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgItemTrans.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgItemTrans.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgItemTrans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgItemTrans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgItemTrans.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgItemTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItemTrans.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.Column5, Me.Column6, Me.Column3})
        Me.dgItemTrans.ContextMenuStrip = Me.cmsFilter
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgItemTrans.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgItemTrans.EnableHeadersVisualStyles = False
        Me.dgItemTrans.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgItemTrans.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgItemTrans.Location = New System.Drawing.Point(8, 29)
        Me.dgItemTrans.MultiSelect = False
        Me.dgItemTrans.Name = "dgItemTrans"
        Me.dgItemTrans.ReadOnly = True
        Me.dgItemTrans.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgItemTrans.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgItemTrans.RowHeadersVisible = False
        Me.dgItemTrans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgItemTrans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgItemTrans.Size = New System.Drawing.Size(1171, 415)
        Me.dgItemTrans.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgItemTrans.TabIndex = 29
        '
        'Column1
        '
        Me.Column1.HeaderText = "Code"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 250
        '
        'Column2
        '
        Me.Column2.HeaderText = "Description"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 500
        '
        'Column4
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle11
        Me.Column4.HeaderText = "In"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle12
        Me.Column5.HeaderText = "Out"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle13
        Me.Column6.HeaderText = "Close"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column3
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle14
        Me.Column3.HeaderText = "Price"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'cmsFilter
        '
        Me.cmsFilter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddFilterByToolStripMenuItem, Me.ClearFiltersToolStripMenuItem})
        Me.cmsFilter.Name = "ContextMenuStrip1"
        Me.cmsFilter.Size = New System.Drawing.Size(140, 48)
        '
        'AddFilterByToolStripMenuItem
        '
        Me.AddFilterByToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmProp, Me.cmQua})
        Me.AddFilterByToolStripMenuItem.Name = "AddFilterByToolStripMenuItem"
        Me.AddFilterByToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.AddFilterByToolStripMenuItem.Text = "Add filter by"
        '
        'cmProp
        '
        Me.cmProp.Name = "cmProp"
        Me.cmProp.Size = New System.Drawing.Size(119, 22)
        Me.cmProp.Text = "Property"
        '
        'cmQua
        '
        Me.cmQua.Name = "cmQua"
        Me.cmQua.Size = New System.Drawing.Size(119, 22)
        Me.cmQua.Text = "Physical"
        '
        'ClearFiltersToolStripMenuItem
        '
        Me.ClearFiltersToolStripMenuItem.Name = "ClearFiltersToolStripMenuItem"
        Me.ClearFiltersToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ClearFiltersToolStripMenuItem.Text = "Clear filters"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel5.Location = New System.Drawing.Point(24, 40)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(74, 25)
        Me.MetroLabel5.TabIndex = 21
        Me.MetroLabel5.Text = "Group : "
        Me.MetroLabel5.UseCustomBackColor = True
        '
        'cbGroup
        '
        Me.cbGroup.FormattingEnabled = True
        Me.cbGroup.ItemHeight = 23
        Me.cbGroup.Location = New System.Drawing.Point(104, 38)
        Me.cbGroup.Name = "cbGroup"
        Me.cbGroup.Size = New System.Drawing.Size(274, 29)
        Me.cbGroup.TabIndex = 1
        Me.cbGroup.UseSelectable = True
        '
        'rbSelectGroup
        '
        Me.rbSelectGroup.AutoSize = True
        Me.rbSelectGroup.Checked = True
        Me.rbSelectGroup.Location = New System.Drawing.Point(24, 91)
        Me.rbSelectGroup.Name = "rbSelectGroup"
        Me.rbSelectGroup.Size = New System.Drawing.Size(71, 15)
        Me.rbSelectGroup.TabIndex = 29
        Me.rbSelectGroup.TabStop = True
        Me.rbSelectGroup.Text = "Selection"
        Me.rbSelectGroup.UseCustomBackColor = True
        Me.rbSelectGroup.UseSelectable = True
        '
        'rbAllGroup
        '
        Me.rbAllGroup.AutoSize = True
        Me.rbAllGroup.Location = New System.Drawing.Point(24, 70)
        Me.rbAllGroup.Name = "rbAllGroup"
        Me.rbAllGroup.Size = New System.Drawing.Size(37, 15)
        Me.rbAllGroup.TabIndex = 27
        Me.rbAllGroup.Text = "All"
        Me.rbAllGroup.UseCustomBackColor = True
        Me.rbAllGroup.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.CustomPanel2)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 643)
        Me.Panel1.TabIndex = 39
        '
        'CustomPanel2
        '
        Me.CustomPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomPanel2.Controls.Add(Me.MetroLink1)
        Me.CustomPanel2.Controls.Add(Me.MetroButton3)
        Me.CustomPanel2.Controls.Add(Me.pnlQuaFilter)
        Me.CustomPanel2.Controls.Add(Me.pnlPropFilter)
        Me.CustomPanel2.Controls.Add(Me.CustomPanel4)
        Me.CustomPanel2.Controls.Add(Me.dgItemTrans)
        Me.CustomPanel2.Curvature = 10
        Me.CustomPanel2.Location = New System.Drawing.Point(6, 142)
        Me.CustomPanel2.Name = "CustomPanel2"
        Me.CustomPanel2.Size = New System.Drawing.Size(1191, 493)
        Me.CustomPanel2.TabIndex = 64
        '
        'MetroLink1
        '
        Me.MetroLink1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroLink1.Image = CType(resources.GetObject("MetroLink1.Image"), System.Drawing.Image)
        Me.MetroLink1.ImageSize = 25
        Me.MetroLink1.Location = New System.Drawing.Point(1144, 454)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(35, 30)
        Me.MetroLink1.TabIndex = 78
        Me.MetroLink1.UseSelectable = True
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(989, 455)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(149, 29)
        Me.MetroButton3.TabIndex = 53
        Me.MetroButton3.Text = "Show Complete Details"
        Me.MetroButton3.UseSelectable = True
        '
        'pnlQuaFilter
        '
        Me.pnlQuaFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlQuaFilter.Controls.Add(Me.MetroTextBox1)
        Me.pnlQuaFilter.Controls.Add(Me.btnQuaFilter)
        Me.pnlQuaFilter.Controls.Add(Me.MetroCheckBox7)
        Me.pnlQuaFilter.Controls.Add(Me.MetroComboBox8)
        Me.pnlQuaFilter.Controls.Add(Me.MetroCheckBox8)
        Me.pnlQuaFilter.Controls.Add(Me.CustomPanel12)
        Me.pnlQuaFilter.Curvature = 10
        Me.pnlQuaFilter.Location = New System.Drawing.Point(739, 57)
        Me.pnlQuaFilter.Name = "pnlQuaFilter"
        Me.pnlQuaFilter.Size = New System.Drawing.Size(449, 147)
        Me.pnlQuaFilter.TabIndex = 77
        Me.pnlQuaFilter.Visible = False
        '
        'MetroTextBox1
        '
        '
        '
        '
        Me.MetroTextBox1.CustomButton.Image = Nothing
        Me.MetroTextBox1.CustomButton.Location = New System.Drawing.Point(244, 1)
        Me.MetroTextBox1.CustomButton.Name = ""
        Me.MetroTextBox1.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.MetroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox1.CustomButton.TabIndex = 1
        Me.MetroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.CustomButton.UseSelectable = True
        Me.MetroTextBox1.CustomButton.Visible = False
        Me.MetroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(163, 72)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.SelectionLength = 0
        Me.MetroTextBox1.SelectionStart = 0
        Me.MetroTextBox1.Size = New System.Drawing.Size(272, 29)
        Me.MetroTextBox1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTextBox1.TabIndex = 57
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox1.WaterMarkFont = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnQuaFilter
        '
        Me.btnQuaFilter.Location = New System.Drawing.Point(326, 109)
        Me.btnQuaFilter.Name = "btnQuaFilter"
        Me.btnQuaFilter.Size = New System.Drawing.Size(109, 29)
        Me.btnQuaFilter.TabIndex = 53
        Me.btnQuaFilter.Text = "Run"
        Me.btnQuaFilter.UseSelectable = True
        '
        'MetroCheckBox7
        '
        Me.MetroCheckBox7.AutoSize = True
        Me.MetroCheckBox7.Checked = True
        Me.MetroCheckBox7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MetroCheckBox7.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.MetroCheckBox7.Location = New System.Drawing.Point(16, 76)
        Me.MetroCheckBox7.Name = "MetroCheckBox7"
        Me.MetroCheckBox7.Size = New System.Drawing.Size(96, 25)
        Me.MetroCheckBox7.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroCheckBox7.TabIndex = 47
        Me.MetroCheckBox7.Text = "Quantity"
        Me.MetroCheckBox7.UseSelectable = True
        '
        'MetroComboBox8
        '
        Me.MetroComboBox8.FormattingEnabled = True
        Me.MetroComboBox8.ItemHeight = 23
        Me.MetroComboBox8.Location = New System.Drawing.Point(163, 37)
        Me.MetroComboBox8.Name = "MetroComboBox8"
        Me.MetroComboBox8.Size = New System.Drawing.Size(272, 29)
        Me.MetroComboBox8.TabIndex = 46
        Me.MetroComboBox8.UseSelectable = True
        '
        'MetroCheckBox8
        '
        Me.MetroCheckBox8.AutoSize = True
        Me.MetroCheckBox8.Checked = True
        Me.MetroCheckBox8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MetroCheckBox8.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.MetroCheckBox8.Location = New System.Drawing.Point(16, 41)
        Me.MetroCheckBox8.Name = "MetroCheckBox8"
        Me.MetroCheckBox8.Size = New System.Drawing.Size(95, 25)
        Me.MetroCheckBox8.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroCheckBox8.TabIndex = 45
        Me.MetroCheckBox8.Text = "Location"
        Me.MetroCheckBox8.UseSelectable = True
        '
        'CustomPanel12
        '
        Me.CustomPanel12.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomPanel12.Curvature = 10
        Me.CustomPanel12.CurveMode = CType((Acc_System.CornerCurveMode.TopLeft Or Acc_System.CornerCurveMode.TopRight), Acc_System.CornerCurveMode)
        Me.CustomPanel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel12.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel12.Name = "CustomPanel12"
        Me.CustomPanel12.Size = New System.Drawing.Size(449, 23)
        Me.CustomPanel12.TabIndex = 44
        '
        'pnlPropFilter
        '
        Me.pnlPropFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPropFilter.Controls.Add(Me.btnPropFilter)
        Me.pnlPropFilter.Controls.Add(Me.cbColor)
        Me.pnlPropFilter.Controls.Add(Me.chkColor)
        Me.pnlPropFilter.Controls.Add(Me.cbSubCategory)
        Me.pnlPropFilter.Controls.Add(Me.chkSubCategory)
        Me.pnlPropFilter.Controls.Add(Me.cbCategory)
        Me.pnlPropFilter.Controls.Add(Me.chkCategory)
        Me.pnlPropFilter.Controls.Add(Me.cbSupplier)
        Me.pnlPropFilter.Controls.Add(Me.chkSupplier)
        Me.pnlPropFilter.Controls.Add(Me.CustomPanel10)
        Me.pnlPropFilter.Curvature = 10
        Me.pnlPropFilter.Location = New System.Drawing.Point(8, 57)
        Me.pnlPropFilter.Name = "pnlPropFilter"
        Me.pnlPropFilter.Size = New System.Drawing.Size(449, 221)
        Me.pnlPropFilter.TabIndex = 76
        Me.pnlPropFilter.Visible = False
        '
        'btnPropFilter
        '
        Me.btnPropFilter.Location = New System.Drawing.Point(326, 177)
        Me.btnPropFilter.Name = "btnPropFilter"
        Me.btnPropFilter.Size = New System.Drawing.Size(109, 29)
        Me.btnPropFilter.TabIndex = 53
        Me.btnPropFilter.Text = "Run"
        Me.btnPropFilter.UseSelectable = True
        '
        'cbColor
        '
        Me.cbColor.FormattingEnabled = True
        Me.cbColor.ItemHeight = 23
        Me.cbColor.Location = New System.Drawing.Point(163, 142)
        Me.cbColor.Name = "cbColor"
        Me.cbColor.Size = New System.Drawing.Size(272, 29)
        Me.cbColor.TabIndex = 52
        Me.cbColor.UseSelectable = True
        '
        'chkColor
        '
        Me.chkColor.AutoSize = True
        Me.chkColor.Checked = True
        Me.chkColor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkColor.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.chkColor.Location = New System.Drawing.Point(16, 146)
        Me.chkColor.Name = "chkColor"
        Me.chkColor.Size = New System.Drawing.Size(71, 25)
        Me.chkColor.Style = MetroFramework.MetroColorStyle.Teal
        Me.chkColor.TabIndex = 51
        Me.chkColor.Text = "Color"
        Me.chkColor.UseSelectable = True
        '
        'cbSubCategory
        '
        Me.cbSubCategory.FormattingEnabled = True
        Me.cbSubCategory.ItemHeight = 23
        Me.cbSubCategory.Location = New System.Drawing.Point(163, 107)
        Me.cbSubCategory.Name = "cbSubCategory"
        Me.cbSubCategory.Size = New System.Drawing.Size(272, 29)
        Me.cbSubCategory.TabIndex = 50
        Me.cbSubCategory.UseSelectable = True
        '
        'chkSubCategory
        '
        Me.chkSubCategory.AutoSize = True
        Me.chkSubCategory.Checked = True
        Me.chkSubCategory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSubCategory.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.chkSubCategory.Location = New System.Drawing.Point(16, 111)
        Me.chkSubCategory.Name = "chkSubCategory"
        Me.chkSubCategory.Size = New System.Drawing.Size(136, 25)
        Me.chkSubCategory.Style = MetroFramework.MetroColorStyle.Teal
        Me.chkSubCategory.TabIndex = 49
        Me.chkSubCategory.Text = "Sub Category"
        Me.chkSubCategory.UseSelectable = True
        '
        'cbCategory
        '
        Me.cbCategory.FormattingEnabled = True
        Me.cbCategory.ItemHeight = 23
        Me.cbCategory.Location = New System.Drawing.Point(163, 72)
        Me.cbCategory.Name = "cbCategory"
        Me.cbCategory.Size = New System.Drawing.Size(272, 29)
        Me.cbCategory.TabIndex = 48
        Me.cbCategory.UseSelectable = True
        '
        'chkCategory
        '
        Me.chkCategory.AutoSize = True
        Me.chkCategory.Checked = True
        Me.chkCategory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCategory.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.chkCategory.Location = New System.Drawing.Point(16, 76)
        Me.chkCategory.Name = "chkCategory"
        Me.chkCategory.Size = New System.Drawing.Size(100, 25)
        Me.chkCategory.Style = MetroFramework.MetroColorStyle.Teal
        Me.chkCategory.TabIndex = 47
        Me.chkCategory.Text = "Category"
        Me.chkCategory.UseSelectable = True
        '
        'cbSupplier
        '
        Me.cbSupplier.FormattingEnabled = True
        Me.cbSupplier.ItemHeight = 23
        Me.cbSupplier.Location = New System.Drawing.Point(163, 37)
        Me.cbSupplier.Name = "cbSupplier"
        Me.cbSupplier.Size = New System.Drawing.Size(272, 29)
        Me.cbSupplier.TabIndex = 46
        Me.cbSupplier.UseSelectable = True
        '
        'chkSupplier
        '
        Me.chkSupplier.AutoSize = True
        Me.chkSupplier.Checked = True
        Me.chkSupplier.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSupplier.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.chkSupplier.Location = New System.Drawing.Point(16, 41)
        Me.chkSupplier.Name = "chkSupplier"
        Me.chkSupplier.Size = New System.Drawing.Size(93, 25)
        Me.chkSupplier.Style = MetroFramework.MetroColorStyle.Teal
        Me.chkSupplier.TabIndex = 45
        Me.chkSupplier.Text = "Supplier"
        Me.chkSupplier.UseSelectable = True
        '
        'CustomPanel10
        '
        Me.CustomPanel10.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomPanel10.Curvature = 10
        Me.CustomPanel10.CurveMode = CType((Acc_System.CornerCurveMode.TopLeft Or Acc_System.CornerCurveMode.TopRight), Acc_System.CornerCurveMode)
        Me.CustomPanel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel10.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel10.Name = "CustomPanel10"
        Me.CustomPanel10.Size = New System.Drawing.Size(449, 23)
        Me.CustomPanel10.TabIndex = 44
        '
        'CustomPanel4
        '
        Me.CustomPanel4.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomPanel4.Controls.Add(Me.MetroLabel11)
        Me.CustomPanel4.Curvature = 10
        Me.CustomPanel4.CurveMode = CType((Acc_System.CornerCurveMode.TopLeft Or Acc_System.CornerCurveMode.TopRight), Acc_System.CornerCurveMode)
        Me.CustomPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel4.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel4.Name = "CustomPanel4"
        Me.CustomPanel4.Size = New System.Drawing.Size(1191, 23)
        Me.CustomPanel4.TabIndex = 44
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel11.Location = New System.Drawing.Point(293, 2)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(85, 19)
        Me.MetroLabel11.TabIndex = 50
        Me.MetroLabel11.Text = "Transactions"
        Me.MetroLabel11.UseCustomBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageSize = 25
        Me.btnPrint.Location = New System.Drawing.Point(636, 607)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(43, 30)
        Me.btnPrint.TabIndex = 59
        Me.btnPrint.UseCustomBackColor = True
        Me.btnPrint.UseSelectable = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CustomPanel1)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1194, 133)
        Me.Panel2.TabIndex = 40
        '
        'CustomPanel1
        '
        Me.CustomPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomPanel1.Controls.Add(Me.MetroCheckBox5)
        Me.CustomPanel1.Controls.Add(Me.MetroButton2)
        Me.CustomPanel1.Controls.Add(Me.dtEnd)
        Me.CustomPanel1.Controls.Add(Me.dtStart)
        Me.CustomPanel1.Controls.Add(Me.rbAllGroup)
        Me.CustomPanel1.Controls.Add(Me.btnRun)
        Me.CustomPanel1.Controls.Add(Me.CustomPanel3)
        Me.CustomPanel1.Controls.Add(Me.MetroLabel5)
        Me.CustomPanel1.Controls.Add(Me.rbSelectGroup)
        Me.CustomPanel1.Controls.Add(Me.cbGroup)
        Me.CustomPanel1.Curvature = 10
        Me.CustomPanel1.Location = New System.Drawing.Point(3, 3)
        Me.CustomPanel1.Name = "CustomPanel1"
        Me.CustomPanel1.Size = New System.Drawing.Size(1188, 118)
        Me.CustomPanel1.TabIndex = 64
        '
        'MetroCheckBox5
        '
        Me.MetroCheckBox5.AutoSize = True
        Me.MetroCheckBox5.Checked = True
        Me.MetroCheckBox5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MetroCheckBox5.Location = New System.Drawing.Point(280, 87)
        Me.MetroCheckBox5.Name = "MetroCheckBox5"
        Me.MetroCheckBox5.Size = New System.Drawing.Size(98, 15)
        Me.MetroCheckBox5.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroCheckBox5.TabIndex = 52
        Me.MetroCheckBox5.Text = "Including zero"
        Me.MetroCheckBox5.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(969, 70)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(65, 29)
        Me.MetroButton2.TabIndex = 48
        Me.MetroButton2.Text = "Clear"
        Me.MetroButton2.UseSelectable = True
        '
        'dtEnd
        '
        Me.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEnd.Location = New System.Drawing.Point(1047, 70)
        Me.dtEnd.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtEnd.Name = "dtEnd"
        Me.dtEnd.Size = New System.Drawing.Size(132, 29)
        Me.dtEnd.TabIndex = 46
        '
        'dtStart
        '
        Me.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtStart.Location = New System.Drawing.Point(1047, 35)
        Me.dtStart.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtStart.Name = "dtStart"
        Me.dtStart.Size = New System.Drawing.Size(132, 29)
        Me.dtStart.TabIndex = 45
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(899, 70)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(65, 29)
        Me.btnRun.TabIndex = 43
        Me.btnRun.Text = "Run"
        Me.btnRun.UseSelectable = True
        '
        'CustomPanel3
        '
        Me.CustomPanel3.BackColor = System.Drawing.Color.Gainsboro
        Me.CustomPanel3.Controls.Add(Me.MetroLabel3)
        Me.CustomPanel3.Curvature = 10
        Me.CustomPanel3.CurveMode = CType((Acc_System.CornerCurveMode.TopLeft Or Acc_System.CornerCurveMode.TopRight), Acc_System.CornerCurveMode)
        Me.CustomPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.CustomPanel3.Location = New System.Drawing.Point(0, 0)
        Me.CustomPanel3.Name = "CustomPanel3"
        Me.CustomPanel3.Size = New System.Drawing.Size(1188, 23)
        Me.CustomPanel3.TabIndex = 44
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(108, 2)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(85, 19)
        Me.MetroLabel3.TabIndex = 49
        Me.MetroLabel3.Text = "Transactions"
        Me.MetroLabel3.UseCustomBackColor = True
        '
        'pnlItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "pnlItems"
        Me.Size = New System.Drawing.Size(1200, 643)
        CType(Me.dgItemTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsFilter.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.CustomPanel2.ResumeLayout(False)
        Me.pnlQuaFilter.ResumeLayout(False)
        Me.pnlQuaFilter.PerformLayout()
        Me.pnlPropFilter.ResumeLayout(False)
        Me.pnlPropFilter.PerformLayout()
        Me.CustomPanel4.ResumeLayout(False)
        Me.CustomPanel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.CustomPanel1.ResumeLayout(False)
        Me.CustomPanel1.PerformLayout()
        Me.CustomPanel3.ResumeLayout(False)
        Me.CustomPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgItemTrans As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbGroup As MetroFramework.Controls.MetroComboBox
    Friend WithEvents rbSelectGroup As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbAllGroup As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnPrint As MetroFramework.Controls.MetroLink
    Friend WithEvents btnRun As MetroFramework.Controls.MetroButton
    Friend WithEvents CustomPanel1 As Acc_System.CustomPanel
    Friend WithEvents CustomPanel3 As Acc_System.CustomPanel
    Friend WithEvents CustomPanel2 As Acc_System.CustomPanel
    Friend WithEvents CustomPanel4 As Acc_System.CustomPanel
    Friend WithEvents dtEnd As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtStart As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents pnlPropFilter As Acc_System.CustomPanel
    Friend WithEvents btnPropFilter As MetroFramework.Controls.MetroButton
    Friend WithEvents cbColor As MetroFramework.Controls.MetroComboBox
    Friend WithEvents chkColor As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents cbSubCategory As MetroFramework.Controls.MetroComboBox
    Friend WithEvents chkSubCategory As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents cbCategory As MetroFramework.Controls.MetroComboBox
    Friend WithEvents chkCategory As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents cbSupplier As MetroFramework.Controls.MetroComboBox
    Friend WithEvents chkSupplier As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CustomPanel10 As Acc_System.CustomPanel
    Friend WithEvents cmsFilter As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddFilterByToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmProp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmQua As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearFiltersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlQuaFilter As Acc_System.CustomPanel
    Friend WithEvents btnQuaFilter As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroCheckBox7 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroComboBox8 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroCheckBox8 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents CustomPanel12 As Acc_System.CustomPanel
    Friend WithEvents MetroCheckBox5 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox

End Class
