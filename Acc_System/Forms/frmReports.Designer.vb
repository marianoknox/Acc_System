<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tbItemTransBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACCDBDataSet = New Acc_System.ACCDBDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tbItemTransTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbItemTransTableAdapter()
        Me.tbVoucherTransBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbVoucherTransTableAdapter = New Acc_System.ACCDBDataSetTableAdapters.tbVoucherTransTableAdapter()
        CType(Me.tbItemTransBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACCDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbVoucherTransBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbItemTransBindingSource
        '
        Me.tbItemTransBindingSource.DataMember = "tbItemTrans"
        Me.tbItemTransBindingSource.DataSource = Me.ACCDBDataSet
        '
        'ACCDBDataSet
        '
        Me.ACCDBDataSet.DataSetName = "ACCDBDataSet"
        Me.ACCDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSetItems"
        ReportDataSource1.Value = Me.tbItemTransBindingSource
        ReportDataSource2.Name = "DataSetVoucher"
        ReportDataSource2.Value = Me.tbVoucherTransBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Acc_System.rptInvoice.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(20, 60)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(832, 645)
        Me.ReportViewer1.TabIndex = 0
        '
        'tbItemTransTableAdapter
        '
        Me.tbItemTransTableAdapter.ClearBeforeFill = True
        '
        'tbVoucherTransBindingSource
        '
        Me.tbVoucherTransBindingSource.DataMember = "tbVoucherTrans"
        Me.tbVoucherTransBindingSource.DataSource = Me.ACCDBDataSet
        '
        'tbVoucherTransTableAdapter
        '
        Me.tbVoucherTransTableAdapter.ClearBeforeFill = True
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 725)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReports"
        Me.Text = "Reports"
        CType(Me.tbItemTransBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACCDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbVoucherTransBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbItemTransBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACCDBDataSet As Acc_System.ACCDBDataSet
    Friend WithEvents tbItemTransTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbItemTransTableAdapter
    Friend WithEvents tbVoucherTransBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tbVoucherTransTableAdapter As Acc_System.ACCDBDataSetTableAdapters.tbVoucherTransTableAdapter
End Class
