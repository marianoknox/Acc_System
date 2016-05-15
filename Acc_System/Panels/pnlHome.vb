Imports MetroFramework

Public Class pnlHome

    Private Sub pnlHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'set year
        Dim curYear As DataTable
        curYear = retrieveTableFunction("SELECT System_Year FROM tbYear WHERE Year_in_Use = 'True'")
        If curYear.Rows.Count = 0 Then
            MetroMessageBox.Show(Me, "Default is not set. Please set a default year first before using the system", _
            "Default Year", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim pnl As New pnlLogin(frmMain)
            pnl.swipe(True)
        Else
            frmMain.lblActiveYear.Visible = True
            frmMain.lblActiveYear.Text = curYear.Rows(0).Item(0)
        End If

        generatePending()
    End Sub
    Private Sub generatePending()
        Dim dtTransfer As New DataTable
        Dim dtVouchers As New DataTable
        dtVouchers = retrieveTableFunction("SELECT Voucher_Type, Voucher_Name FROM tbVouchers")
        dtTransfer = retrieveTableFunction("SELECT Voucher_Name,isPosted FROM tbVoucherTrans")

        Dim arrVal() As String = {"Transfer", "Sales Return", "Sales"}
        Dim arrRet(2) As String
        Dim counter As Integer = 0
        For i = 0 To 2
            Dim getTrans = From vch In dtVouchers.AsEnumerable _
                       Join trans In dtTransfer.AsEnumerable _
                       On vch.Field(Of String)("Voucher_Name") Equals trans.Field(Of String)("Voucher_Name") _
                       Where vch.Field(Of String)("Voucher_Type") = arrVal(counter) _
                       And trans.Field(Of Boolean)("isPosted") = False
                       Select trans

            arrRet(counter) = getTrans.Count
            counter += 1
        Next


        'generating pending or !posted entries
        lblTransfer.Text = arrRet(0) & " " & "Transfer"
        lblReturn.Text = arrRet(1) & " " & "Sales Return"
        lblOverdue.Text = arrRet(2) & " " & "Invoice OverDue"
    End Sub
    Private Sub MetroLink1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroLink1.Click
        Dim pnl As New pnlLogin(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub MetroTile13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile13.Click
        Dim pnl As New pnlSales(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub lnkMasters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkMasters.Click
        Dim pnl As New pnlMasters(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub MetroTile3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile3.Click
        Dim pnl As New pnlPurchase(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub MetroTile1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile1.Click
        Dim pnl As New pnlQuotation(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub MetroTile2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile2.Click
        Dim pnl As New pnlTransfer(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub MetroTile7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile7.Click
        Dim pnl As New pnlItems(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub MetroTile6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile6.Click
        Dim pnl As New pnlLedger(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub tlVouchers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tlVouchers.Click
        Dim pnl As New pnlVoucher(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub MetroTile8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile8.Click
        Dim pnl As New pnlSalesman(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub MetroLink7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroLink7.Click
        Dim pnl As New pnlStockMove(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub MetroLink15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroLink15.Click
        Dim pnl As New pnlAgeing(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub MetroLink8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroLink8.Click
        Dim pnl As New pnlOutstanding(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub MetroLink9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroLink9.Click
        Dim pnl As New pnlTrialBalance(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub MetroLink10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroLink10.Click
        Dim pnl As New pnlBalanceSheet(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub MetroLink11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroLink11.Click
        Dim pnl As New pnlIncomeStatement(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub MetroLink12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroLink12.Click
        Dim pnl As New pnlDaybook(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub MetroLink4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroLink4.Click
        Dim pnl As New pnlProfiAnalysis(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub MetroLink2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroLink2.Click
        Dim pnl As New pnlSettings(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub MetroTile4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile4.Click
        Dim pnl As New pnlPayment(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub MetroTile10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile10.Click
        Dim pnl As New pnlJournal(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub MetroTile5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile5.Click
        Dim pnl As New pnlReceipt(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub MetroTile12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile12.Click
        Dim pnl As New pnlPDC(frmMain)
        pnl.swipe(True)
    End Sub
    Private Sub lblTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTransfer.Click
        vchPending = "Transfer"
        Dim pnl As New pnlPending(frmMain)
        pnl.swipe(True)
    End Sub
    Private Sub lblReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblReturn.Click
        vchPending = "Sales Return"
        Dim pnl As New pnlPending(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub lblOverdue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblOverdue.Click
        vchPending = "Sales"
        Dim pnl As New pnlPending(frmMain)
        pnl.swipe(True)
    End Sub

    Private Sub MetroTile9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroTile9.Click
        Dim pnl As New pnlPayroll(frmMain)
        pnl.swipe(True)
    End Sub
End Class
