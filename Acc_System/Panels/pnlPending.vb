Imports MetroFramework

Public Class pnlPending

    Private Sub pnlPending_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        generatePending()
    End Sub
    Private Sub generatePending()
        Dim dtTransfer As New DataTable
        Dim dtVouchers As New DataTable
        dtVouchers = retrieveTableFunction("SELECT Voucher_Type, Voucher_Name FROM tbVouchers")
        dtTransfer = retrieveTableFunction("SELECT Voucher_Date, Voucher_Name, Reference_ID, isPosted FROM tbVoucherTrans")

        Dim getTrans = From vch In dtVouchers.AsEnumerable _
                       Join trans In dtTransfer.AsEnumerable _
                       On vch.Field(Of String)("Voucher_Name") Equals trans.Field(Of String)("Voucher_Name") _
                       Where vch.Field(Of String)("Voucher_Type") = vchPending _
                       And trans.Field(Of Boolean)("isPosted") = False
                       Select trans

        Dim tDate As String
        Dim tVchName As String
        Dim refID As String
        Dim tPosted As Boolean

        For Each tran In getTrans
            tDate = tran.Field(Of Date)("Voucher_Date")
            tVchName = tran.Field(Of String)("Voucher_Name")
            refID = tran.Field(Of String)("Reference_ID")
            tPosted = tran.Field(Of Boolean)("isPosted")

            dgPending.Rows.Add(tDate, tVchName, refID, tPosted)
        Next
    End Sub
    Private Sub generatePendingAll()
        Dim dtTransfer As New DataTable
        Dim dtVouchers As New DataTable
        dtVouchers = retrieveTableFunction("SELECT Voucher_Type, Voucher_Name FROM tbVouchers")
        dtTransfer = retrieveTableFunction("SELECT Voucher_Date, Voucher_Name, Reference_ID, isPosted FROM tbVoucherTrans")

        Dim getTrans = From vch In dtVouchers.AsEnumerable _
                       Join trans In dtTransfer.AsEnumerable _
                       On vch.Field(Of String)("Voucher_Name") Equals trans.Field(Of String)("Voucher_Name") _
                       Where vch.Field(Of String)("Voucher_Type") = vchPending _
                       Select trans

        Dim tDate As String
        Dim tVchName As String
        Dim refID As String
        Dim tPosted As Boolean

        For Each tran In getTrans
            tDate = tran.Field(Of Date)("Voucher_Date")
            tVchName = tran.Field(Of String)("Voucher_Name")
            refID = tran.Field(Of String)("Reference_ID")
            tPosted = tran.Field(Of Boolean)("isPosted")

            dgPending.Rows.Add(tDate, tVchName, refID, tPosted)
        Next
    End Sub
    Private Sub generateSalesReturn()

    End Sub
    Private Sub cmsSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsSet.Click
        Dim updatePost = MetroMessageBox.Show(frmMain, "Set as posted now?", "Post Voucher", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If updatePost = DialogResult.Yes Then
            updateRecord("UPDATE tbVoucherTrans SET isPosted = 'True' WHERE Reference_ID = '" _
                         & dgPending.CurrentRow.Cells(2).Value & "'")

            updateRecord("UPDATE tbItemTrans SET isPosted = 'True' WHERE Reference_ID = '" _
                        & dgPending.CurrentRow.Cells(2).Value & "'")
        End If

        Dim pnl As New pnlPending(frmMain)
        pnl.swipe(True)

    End Sub
    Private Sub cmsNotSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsNotSet.Click
        Dim updatePost = MetroMessageBox.Show(frmMain, "Set as pending now?", "Pending Voucher", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If updatePost = DialogResult.Yes Then
            updateRecord("UPDATE tbVoucherTrans SET isPosted = 'False' WHERE Reference_ID = '" _
                         & dgPending.CurrentRow.Cells(2).Value & "'")

            updateRecord("UPDATE tbItemTrans SET isPosted = 'False' WHERE Reference_ID = '" _
                        & dgPending.CurrentRow.Cells(2).Value & "'")
        End If

        Dim pnl As New pnlPending(frmMain)
        pnl.swipe(True)
    End Sub
    Private Sub rbAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAll.CheckedChanged
        If rbAll.Checked = True Then
            dgPending.Rows.Clear()
            generatePendingAll()
        Else
            dgPending.Rows.Clear()
            generatePending()
        End If    
    End Sub
    Private Sub cmsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsDelete.Click
        deleteRecord(dgPending.CurrentRow.Cells(1).Value)

        generatePending()
    End Sub
End Class
