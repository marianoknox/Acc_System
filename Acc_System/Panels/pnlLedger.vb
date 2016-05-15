Public Class pnlLedger

    Private Sub pnlLedger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TbAccountsTableAdapter.Fill(Me.ACCDBDataSet.tbAccounts)

        generateLedger()
        computeCRDR()
        viewSalesDetails()
    End Sub

    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        generateLedger()
    End Sub

    Private Sub generateLedger()
        dgLedger.Rows.Clear()

        Dim filterLedger = From vouchers In Me.TbAccountTransTableAdapter.GetData()
                            Where vouchers.Field(Of String)("Account_Name") = cbVoucherType.Text _
                            And (vouchers.Field(Of Date)("Voucher_Date") >= dtStart.Text _
                             And vouchers.Field(Of Date)("Voucher_Date") <= dtEnd.Text)
                            Select vouchers

        Dim arrLedger(5) As String

        For Each rows In filterLedger.AsEnumerable
            arrLedger(0) = rows.Field(Of Date)("Voucher_Date")
            arrLedger(1) = rows.Field(Of String)("Reference_ID")
            arrLedger(2) = rows.Field(Of String)("Voucher_Name")
            arrLedger(3) = rows.Field(Of Double)("Voucher_Debit")
            arrLedger(4) = rows.Field(Of Double)("Voucher_Credit")
            arrLedger(5) = rows.Field(Of Double)("Voucher_Balance")

            dgLedger.Rows.Add(arrLedger)
            computeCRDR()
        Next
    End Sub

    Private Sub tbAccount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbAccount.TextChanged
        Me.TbAccountsTableAdapter.FilterAccounts(Me.ACCDBDataSet.tbAccounts, tbAccount.Text)
    End Sub
    Private Sub computeCRDR()
        If dgLedger.RowCount = 0 Then
            Exit Sub
        End If

        Dim dr As Double = 0
        Dim cr As Double = 0

        For i = 0 To dgLedger.RowCount - 1
            dr += dgLedger.Rows(i).Cells(3).Value
            cr += dgLedger.Rows(i).Cells(4).Value
        Next

        tbTotalCR.Text = cr
        tbTotalDR.Text = dr
        tbTotalBalance.Text = Math.Abs(dr - cr)
    End Sub
    Private Sub dgLedger_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgLedger.SelectionChanged
        viewSalesDetails()
    End Sub
    Private Sub viewSalesDetails()
        dgInvItem.Rows.Clear()
        mtcVouchers.SelectTab(tabSales)
        If dgLedger.RowCount = 0 Then
            mtcVouchers.SelectTab(tabDefault)

            Exit Sub
        End If

        Dim dgVoucherQuery = From vouc In Me.TbVoucherTransTableAdapter.GetData.AsEnumerable
                        Where vouc.Field(Of String)("Reference_ID") = dgLedger.CurrentRow.Cells(1).Value
                        Select vouc

        Dim dgItemsQuery = From itms In Me.TbItemTransTableAdapter.GetData.AsEnumerable
                           Where itms.Field(Of String)("Reference_ID") = dgLedger.CurrentRow.Cells(1).Value
                           Select itms

        Dim arrValue(9) As String
        For Each vouc In dgVoucherQuery
            arrValue(0) = vouc.Field(Of String)("Reference_ID")
            arrValue(1) = vouc.Field(Of String)("Cost_Center")
            arrValue(2) = vouc.Field(Of String)("Account_Name")
            arrValue(3) = vouc.Field(Of Double)("Voucher_Amount")
            arrValue(4) = vouc.Field(Of Double)("Voucher_Discount")
            arrValue(5) = vouc.Field(Of Double)("Voucher_Net")
            arrValue(6) = vouc.Field(Of String)("Voucher_Reference")
            arrValue(7) = vouc.Field(Of String)("Voucher_LPO")
            arrValue(8) = vouc.Field(Of String)("Voucher_Quot")
            arrValue(9) = vouc.Field(Of String)("Voucher_Narration")
        Next

        Dim arrItems(6) As String
        For Each itm In dgItemsQuery
            arrItems(0) = itm.Field(Of Integer)("itm_Pos")
            arrItems(1) = itm.Field(Of String)("itm_Code")
            arrItems(2) = itm.Field(Of String)("itm_Desc")
            arrItems(3) = itm.Field(Of Double)("itm_Quantity")
            arrItems(4) = itm.Field(Of String)("itm_Unit")
            arrItems(5) = itm.Field(Of Double)("itm_Sell_Price")
            arrItems(6) = itm.Field(Of Double)("itm_Total_Price")

            dgInvItem.Rows.Add(arrItems)
        Next

        lblInvNo.Text = arrValue(0)
        lblCostCenter.Text = arrValue(1)
        lblCustomer.Text = arrValue(2)
        lblTotal.Text = arrValue(3)
        lblDiscount.Text = arrValue(4)
        lblNet.Text = arrValue(5)
        lblQuotation.Text = arrValue(7)
        lblNarration.Text = arrValue(9)

    End Sub

    Private Sub cmsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsDelete.Click
        deleteRecord(dgLedger.CurrentRow.Cells(1).Value)

        Dim pnl As New pnlLedger(frmMain)
        pnl.swipe(True)
    End Sub
End Class
