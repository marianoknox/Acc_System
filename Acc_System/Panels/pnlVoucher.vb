Imports MetroFramework

Public Class pnlVoucher
    Dim dtVouchers As DataTable

    Private Sub pnlVoucher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TbVouchersTableAdapter.Fill(Me.AccdbDataSet.tbVouchers)

        mtcVouchers.SelectTab(tabDefault)
        generateVouchers()
    End Sub
    Private Sub generateVouchers()
        dgVouchers.Rows.Clear()
        Dim vType As String = Nothing

        Dim filterVouchers = From vouchers In Me.TbVoucherTransTableAdapter.GetData()
                             Where vouchers.Field(Of String)("Voucher_Name") = cbVoucherType.Text _
                             And (vouchers.Field(Of Date)("Voucher_Date") >= dtStart.Text _
                             And vouchers.Field(Of Date)("Voucher_Date") <= dtEnd.Text)
                             Select vouchers

        Dim arrDG(3) As String

        For Each rows In filterVouchers

            arrDG(0) = rows.Field(Of Date)("Voucher_Date")
            arrDG(1) = rows.Field(Of String)("Reference_ID")
            arrDG(2) = rows.Field(Of String)("Account_Name")
            arrDG(3) = rows.Field(Of Double)("Voucher_Net")

            dgVouchers.Rows.Add(arrDG)
        Next

        Dim getvType = From getV In Me.TbVouchersTableAdapter.GetData.AsEnumerable _
                       Where getV.Field(Of String)("Voucher_Name") = cbVoucherType.Text _
                       Select getV.Field(Of String)("Voucher_Type")

        For Each vrow In getvType
            vType = vrow
        Next


        If vType = "Sales" Or vType = "Sales Return" Or vType = "Sales Order" Then
            If dgVouchers.RowCount = 0 Then
                mtcVouchers.SelectTab(tabDefault)
                Exit Sub
            End If
            viewSalesDetails()
            mtcVouchers.SelectTab(tabSales)
        ElseIf vType = "Purchase" Or vType = "Purchase Return" Then
            If dgVouchers.RowCount = 0 Then
                mtcVouchers.SelectTab(tabDefault)
                Exit Sub
            End If
            viewPurchaseDetails()
            mtcVouchers.SelectTab(tabPurchase)
        ElseIf vType = "Journal" Then
            If dgVouchers.RowCount = 0 Then
                mtcVouchers.SelectTab(tabDefault)
                Exit Sub
            End If
            viewJournalDetails()
            mtcVouchers.SelectTab(tabJournal)
        ElseIf vType = "Payment" Or vType = "Receipt" Or vType = "PDC" Then
            If dgVouchers.RowCount = 0 Then
                mtcVouchers.SelectTab(tabDefault)
                Exit Sub
            End If
            viewPaymentDetails()
            mtcVouchers.SelectTab(tabPayment)
        ElseIf vType = "Transfer" Then
            If dgVouchers.RowCount = 0 Then
                mtcVouchers.SelectTab(tabDefault)
                Exit Sub
            End If
            viewTransferDetails()
            mtcVouchers.SelectTab(tabTransfer)
        End If
    End Sub
    Private Sub cmVoucher_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmVoucher.Opening
        contextOpening(dgVouchers, cmVoucher)
    End Sub
    Private Sub cmsEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsEdit.Click
        EditEntry = True
        reference_Id = dgVouchers.CurrentRow.Cells(1).Value.ToString

        Dim dtVch As DataTable
        dtVch = retrieveTableFunction("SELECT Voucher_Type FROM tbVouchers WHERE Voucher_Name = '" & cbVoucherType.Text & "'")
        If dtVch.Rows.Count = 0 Then
            Exit Sub
        Else
            If dtVch.Rows(0).Item(0) = "Sales" Or dtVch.Rows(0).Item(0) = "Sales Return" Then
                Dim pnl As New pnlSales(frmMain)
                pnl.swipe(True)
            ElseIf dtVch.Rows(0).Item(0) = "Purchase" Or dtVch.Rows(0).Item(0) = "Purchase Return" Then
                Dim pnl As New pnlPurchase(frmMain)
                pnl.swipe(True)
            ElseIf dtVch.Rows(0).Item(0) = "Journal" Then
                Dim pnl As New pnlJournal(frmMain)
                pnl.swipe(True)
            ElseIf dtVch.Rows(0).Item(0) = "Sales Order" Then
                Dim pnl As New pnlQuotation(frmMain)
                pnl.swipe(True)
            Else
                EditEntry = False
            End If
        End If
    End Sub
    Private Sub cmsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsDelete.Click
        deleteRecord(dgVouchers.CurrentRow.Cells(1).Value)

        Dim pnl As New pnlVoucher(frmMain)
        pnl.swipe(True)
    End Sub
    Private Sub viewSalesDetails()
        dgInIvtem.Rows.Clear()

        Dim dgVoucherQuery = From vouc In Me.TbVoucherTransTableAdapter.GetData.AsEnumerable _
                             Where vouc.Field(Of String)("Reference_ID") = dgVouchers.CurrentRow.Cells(1).Value _
                             Select vouc

        Dim dgItemsQuery = From itms In Me.TbItemTransTableAdapter.GetData.AsEnumerable
                           Where itms.Field(Of String)("Reference_ID") = dgVouchers.CurrentRow.Cells(1).Value
                           Select itms


        Dim arrValue(12) As String
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
            arrValue(10) = vouc.Field(Of Date)("Voucher_Date")
            arrValue(11) = vouc.Field(Of String)("Voucher_Reference")
            arrValue(12) = vouc.Field(Of String)("Voucher_LPO")
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

            dgInIvtem.Rows.Add(arrItems)
        Next


        lblInvNo.Text = arrValue(0)
        tbCostCenter.Text = arrValue(1)
        tbCustomer.Text = arrValue(2)
        tbTotal.Text = arrValue(3)
        tbDiscount.Text = arrValue(4)
        tbNet.Text = arrValue(5)
        tbQuotation.Text = arrValue(7)
        tbNarration.Text = arrValue(9)
        tbDateSales.Text = arrValue(10)
        tbRefSales.Text = arrValue(11)
        tbLPOsales.Text = arrValue(12)

    End Sub
    Private Sub viewPurchaseDetails()
        dgPurchase.Rows.Clear()

        Dim dgVoucherQuery = From vouc In Me.TbVoucherTransTableAdapter.GetData.AsEnumerable _
                             Where vouc.Field(Of String)("Reference_ID") = dgVouchers.CurrentRow.Cells(1).Value _
                             Select vouc

        Dim dgItemsQuery = From itms In Me.TbItemTransTableAdapter.GetData.AsEnumerable
                           Where itms.Field(Of String)("Reference_ID") = dgVouchers.CurrentRow.Cells(1).Value
                           Select itms


        Dim arrValue(11) As String
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
            arrValue(10) = vouc.Field(Of Date)("Voucher_Date")
            arrValue(11) = vouc.Field(Of String)("Voucher_LPO")
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

            dgPurchase.Rows.Add(arrItems)
        Next


        lblInvNoPur.Text = arrValue(0)
        tbCostCenterPur.Text = arrValue(1)
        tbSupplier.Text = arrValue(2)
        tbTotalPur.Text = arrValue(3)
        tbDicountPur.Text = arrValue(4)
        tbNetPur.Text = arrValue(5)
        tbRefPur.Text = arrValue(6)
        tbNarrPur.Text = arrValue(7)
        tbDatePur.Text = arrValue(8)
        tbCurrPur.Text = arrValue(9)
        tbRateItem.Text = arrValue(10)
        tbRateLedger.Text = arrValue(11)

    End Sub
    Private Sub viewJournalDetails()

    End Sub
    Private Sub viewTransferDetails()

    End Sub
    Private Sub viewPaymentDetails()
        dgPay.Rows.Clear()

        Dim dgVoucherQuery = From vouc In Me.TbVoucherTransTableAdapter.GetData.AsEnumerable _
                             Where vouc.Field(Of String)("Reference_ID") = dgVouchers.CurrentRow.Cells(1).Value _
                             Select vouc

        Dim arrValue(12) As String
        For Each vouc In dgVoucherQuery
            arrValue(0) = vouc.Field(Of String)("Reference_ID")
            arrValue(1) = vouc.Field(Of String)("Cost_Center")
            arrValue(2) = vouc.Field(Of String)("Account_Name")
            arrValue(3) = vouc.Field(Of Double)("Voucher_Amount")
            arrValue(6) = vouc.Field(Of String)("Voucher_Reference")
            arrValue(9) = vouc.Field(Of String)("Voucher_Narration")
            arrValue(10) = vouc.Field(Of Date)("Voucher_Date")
        Next

        Dim dgItemsQuery = From itms In Me.TbAccountTransTableAdapter.GetData.AsEnumerable
                           Where (itms.Field(Of String)("Reference_ID") = dgVouchers.CurrentRow.Cells(1).Value _
                           And itms.Field(Of String)("Account_Name") IsNot (arrValue(2))) _
                           Select itms


        Dim arrItems(6) As String
        For Each itm In dgItemsQuery
            arrItems(0) = itm.Field(Of Integer)("itm_Pos")
            arrItems(1) = itm.Field(Of String)("itm_Code")
            arrItems(2) = itm.Field(Of String)("itm_Desc")
            arrItems(3) = itm.Field(Of Double)("itm_Quantity")
            arrItems(4) = itm.Field(Of String)("itm_Unit")
            arrItems(5) = itm.Field(Of Double)("itm_Sell_Price")
            arrItems(6) = itm.Field(Of Double)("itm_Total_Price")

            dgInIvtem.Rows.Add(arrItems)
        Next


        lblInvNo.Text = arrValue(0)
        tbCostCenter.Text = arrValue(1)
        tbCustomer.Text = arrValue(2)
        tbTotal.Text = arrValue(3)
        tbDiscount.Text = arrValue(4)
        tbNet.Text = arrValue(5)
        tbQuotation.Text = arrValue(7)
        tbNarration.Text = arrValue(9)
        tbDateSales.Text = arrValue(10)
        tbRefSales.Text = arrValue(11)
        tbLPOsales.Text = arrValue(12)
    End Sub
    Private Sub dgVouchers_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgVouchers.SelectionChanged
        viewSalesDetails()
    End Sub
    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        generateVouchers()
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        frmReports.Show()
        reference_Id = lblInvNo.Text
    End Sub
End Class
