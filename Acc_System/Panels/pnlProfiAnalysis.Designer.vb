<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pnlProfiAnalysis
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgVouchers = New MetroFramework.Controls.MetroGrid()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomPanel1 = New Acc_System.CustomPanel()
        Me.CustomPanel3 = New Acc_System.CustomPanel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.dtEnd = New MetroFramework.Controls.MetroDateTime()
        Me.dtStart = New MetroFramework.Controls.MetroDateTime()
        Me.btnRun = New MetroFramework.Controls.MetroButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.dgVouchers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomPanel1.SuspendLayout()
        Me.CustomPanel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgVouchers
        '
        Me.dgVouchers.AllowUserToAddRows = False
        Me.dgVouchers.AllowUserToDeleteRows = False
        Me.dgVouchers.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.dgVouchers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgVouchers.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgVouchers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgVouchers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgVouchers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgVouchers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgVouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVouchers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column1, Me.Column2, Me.Column3, Me.Column5})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgVouchers.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgVouchers.EnableHeadersVisualStyles = False
        Me.dgVouchers.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgVouchers.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgVouchers.Location = New System.Drawing.Point(16, 125)
        Me.dgVouchers.MultiSelect = False
        Me.dgVouchers.Name = "dgVouchers"
        Me.dgVouchers.ReadOnly = True
        Me.dgVouchers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgVouchers.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgVouchers.RowHeadersVisible = False
        Me.dgVouchers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgVouchers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVouchers.Size = New System.Drawing.Size(1169, 239)
        Me.dgVouchers.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgVouchers.TabIndex = 27
        '
        'Column4
        '
        Me.Column4.HeaderText = "Groups"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 600
        '
        'Column1
        '
        Me.Column1.HeaderText = "Gross Cost"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Gross Sales"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Gross Profit"
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
        Me.Column5.HeaderText = "% Profit"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'CustomPanel1
        '
        Me.CustomPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomPanel1.Controls.Add(Me.CustomPanel3)
        Me.CustomPanel1.Controls.Add(Me.dtEnd)
        Me.CustomPanel1.Controls.Add(Me.dtStart)
        Me.CustomPanel1.Controls.Add(Me.btnRun)
        Me.CustomPanel1.Curvature = 10
        Me.CustomPanel1.Location = New System.Drawing.Point(16, 14)
        Me.CustomPanel1.Name = "CustomPanel1"
        Me.CustomPanel1.Size = New System.Drawing.Size(349, 105)
        Me.CustomPanel1.TabIndex = 65
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
        Me.CustomPanel3.Size = New System.Drawing.Size(349, 23)
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
        'dtEnd
        '
        Me.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtEnd.Location = New System.Drawing.Point(10, 66)
        Me.dtEnd.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtEnd.Name = "dtEnd"
        Me.dtEnd.Size = New System.Drawing.Size(214, 29)
        Me.dtEnd.TabIndex = 3
        '
        'dtStart
        '
        Me.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtStart.Location = New System.Drawing.Point(10, 31)
        Me.dtStart.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtStart.Name = "dtStart"
        Me.dtStart.Size = New System.Drawing.Size(214, 29)
        Me.dtStart.TabIndex = 2
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(230, 66)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(99, 28)
        Me.btnRun.TabIndex = 4
        Me.btnRun.Text = "Run"
        Me.btnRun.UseSelectable = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(42, 435)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(784, 180)
        Me.DataGridView1.TabIndex = 66
        '
        'pnlProfiAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CustomPanel1)
        Me.Controls.Add(Me.dgVouchers)
        Me.Name = "pnlProfiAnalysis"
        Me.Size = New System.Drawing.Size(1200, 643)
        CType(Me.dgVouchers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomPanel1.ResumeLayout(False)
        Me.CustomPanel3.ResumeLayout(False)
        Me.CustomPanel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgVouchers As MetroFramework.Controls.MetroGrid
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomPanel1 As Acc_System.CustomPanel
    Friend WithEvents CustomPanel3 As Acc_System.CustomPanel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtEnd As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtStart As MetroFramework.Controls.MetroDateTime
    Friend WithEvents btnRun As MetroFramework.Controls.MetroButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
