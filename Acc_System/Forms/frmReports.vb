Public Class frmReports

    Private Sub frmReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim refID As String = reference_Id

        'TODO: This line of code loads data into the 'ACCDBDataSet.tbVoucherTrans' table. You can move, or remove it, as needed.
        Me.tbVoucherTransTableAdapter.FillRefID(Me.ACCDBDataSet.tbVoucherTrans, refID)
        'TODO: This line of code loads data into the 'ACCDBDataSet.tbItemTrans' table. You can move, or remove it, as needed.
        Me.tbItemTransTableAdapter.FillRefID(Me.ACCDBDataSet.tbItemTrans, refID)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class