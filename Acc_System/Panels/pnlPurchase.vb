Imports MetroFramework

Public Class pnlPurchase

    Dim clsPurchase As New clsSalesInvoice
    Dim dtAccounts As DataTable
    Dim editMode As Boolean = False
    Dim vType As String
    Dim defcur As String
    Private Sub pnlPurchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TbVouchersTableAdapter.FillPurchase(Me.ACCDBDataSet.tbVouchers)
        Me.TbCostCenterListTableAdapter.Fill(Me.ACCDBDataSet.tbCostCenterList)
        Me.TbAccountsTableAdapter.Fill(Me.ACCDBDataSet.tbAccounts)
        Me.TbCurrencyTableAdapter.Fill(Me.ACCDBDataSet.tbCurrency)
        Me.TbAccountTransTableAdapter.Fill(Me.ACCDBDataSet.tbAccountTrans)

        'identify default currency
        'disable forex when default
        defcur = getDefaultCurrency()
        lblDefCur1.Text = defcur
        lblDefCur2.Text = defcur

        selectCurrency()

        lblCurrTotal.Text = cbCurrency.Text
        lblNet.Text = cbCurrency.Text

        'fill secondary account
        cbAccRevenue.DataSource = Me.TbAccountsTableAdapter.GetDataAccAs("Purchase Account")
        cbAccRevenue.DisplayMember = "Account_Name"

        'Calls the method for index select in voucher type
        'returns initial invoice number
        Dim arr() As String = returnInvNum(cbVoucherType.Text)
        lblInvNo.Text = arr(0).ToString + arr(1).ToString

        'retrieve type of voucher to be used in account saving allocations
        Dim getAllocation = From aloc In Me.TbVouchersTableAdapter.GetData.AsEnumerable
                            Where aloc.Field(Of String)("Voucher_Name") = cbVoucherType.Text
                            Select aloc.Field(Of String)("Voucher_Type")

        For Each aloc In getAllocation
            vType = aloc
        Next

        'Calls the method for index select in accounts
        'returns balance, credit limit and days
        CusSelected()

        'Disable sort mode in all invoice column
        For Each column In dgInvItem.Columns
            column.SortMode = DataGridViewColumnSortMode.NotSortable
        Next

        'Align the values from invoice to the right
        dgInvItem.Columns(4).HeaderCell.Style.Alignment _
            = DataGridViewContentAlignment.MiddleRight
        dgInvItem.Columns(5).HeaderCell.Style.Alignment _
            = DataGridViewContentAlignment.MiddleRight

        'populate accounts combo box
        dtAccounts = Me.TbAccountsTableAdapter.GetData
        cbAccounts.DataSource = dtAccounts
        cbAccounts.DisplayMember = "Account_Name"

        'fill datagrid view for item selection
        dgItemSelect.DataSource = retrieveTableFunction( _
            "SELECT itm_Code, itm_Desc, " & _
            "itm_Unit, itm_Price " & _
            "FROM tbItems")

        clsPurchase.dgProperties(dgItemSelect)

        'test variable for edit mode
        'use the same form for edit and new entry

        If EditEntry = True Then
            cbVoucherType.Enabled = False
            Dim arrDetails() As String
            arrDetails = getEditValues()
            selectCb(cbVoucherType, arrDetails(1))
            lblInvNo.Text = arrDetails(0)
            selectCb(cbCostCenter, arrDetails(2))
            selectCb(cbAccRevenue, arrDetails(3))
            tbReference.Text = arrDetails(4)
            '  tbQuotaion.Text = arrDetails(5)
            ' tbLPO.Text = arrDetails(6)
            dtInvDate.Text = arrDetails(7)
            tbDiscAmt.Text = arrDetails(8)
            selectCb(cbSupplier, arrDetails(9))

            Dim dtItms As DataTable
            Dim arrCol(7) As String
            dtItms = getItemValues()

            For iRow = 0 To dtItms.Rows.Count - 1

                For iCol = 0 To dtItms.Columns.Count - 1
                    arrCol(iCol) = dtItms.Rows(iRow).Item(iCol)
                Next

                dgInvItem.Rows.Add(arrCol)
            Next
        Else

        End If
    End Sub
    Private Sub selectCb(ByVal cb As MetroFramework.Controls.MetroComboBox, ByVal strFind As String)
        Dim index As Integer = cb.FindString(strFind)
        cb.SelectedIndex = index
    End Sub
    Private Function getAccountLedger() As String

        Dim filterAcc = From acc In Me.TbAccountTransTableAdapter.GetData.AsEnumerable _
                        Where acc.Field(Of String)("Reference_ID") = reference_Id _
                        Select acc.Field(Of String)("Account_Name")

        Dim arrAcc(filterAcc.Count - 1) As String
        Dim counter As Integer = 0
        For Each aAcc In filterAcc
            arrAcc(counter) = aAcc
            counter += 1
        Next


        Dim filterSalesLedger = From sled In Me.TbAccountsTableAdapter.GetData.AsEnumerable _
                                Where sled.Field(Of String)("Account_As") = "Purchase Account" _
                                Select sled.Field(Of String)("Account_Name")

        Dim arrLed(filterSalesLedger.Count - 1) As String
        counter = 0
        For Each fsled In filterSalesLedger
            arrLed(counter) = fsled
            counter += 1
        Next

        Dim accLed As String = Nothing
        For iAcc = 0 To arrAcc.Length - 1
            For iLed = 0 To arrLed.Length - 1
                If arrAcc(iAcc) = arrLed(iLed) Then
                    accLed = arrAcc(iAcc)
                End If
            Next
        Next

        Return accLed
    End Function
    Private Function getEditValues() As Array
        Dim dtDetails As New DataTable
        Dim dtInvItems As New DataTable

        Dim filterVoucher = From vch In Me.TbVoucherTransTableAdapter.GetData.AsEnumerable _
                            Where vch.Field(Of String)("Reference_ID") = reference_Id _
                            Select vch

        Dim arrDetails(9) As String
        For Each vchr In filterVoucher
            arrDetails(0) = vchr.Field(Of String)("Reference_ID")
            arrDetails(1) = vchr.Field(Of String)("Voucher_Name")
            arrDetails(2) = vchr.Field(Of String)("Cost_Center")
            arrDetails(3) = getAccountLedger()
            arrDetails(4) = vchr.Field(Of String)("Voucher_Reference")
            arrDetails(5) = vchr.Field(Of String)("Voucher_Quot")
            arrDetails(6) = vchr.Field(Of String)("Voucher_LPO")
            arrDetails(7) = vchr.Field(Of Date)("Voucher_Date")
            arrDetails(8) = vchr.Field(Of Double)("Voucher_Discount")
            arrDetails(9) = vchr.Field(Of String)("Account_Name")
        Next

        Return arrDetails
    End Function
    Private Function getItemValues() As DataTable
        Dim dtItms As New DataTable
        dtItms.Columns.Add("No")
        dtItms.Columns.Add("eCode")
        dtItms.Columns.Add("eDescription")
        dtItms.Columns.Add("eQty")
        dtItms.Columns.Add("eUnit")
        dtItms.Columns.Add("ePrice")
        dtItms.Columns.Add("eTotal")
        dtItms.Columns.Add("eCu")

        Dim filterItems = From itm In Me.TbItemTransTableAdapter.GetData.AsEnumerable _
                          Where itm.Field(Of String)("Reference_ID") = reference_Id _
                          Select itm

        Dim iPos, iCode, iDesc, iQty, iUnit, iPrice, iTotal, iCu As String
        For Each itms In filterItems
            iPos = itms.Field(Of Integer)("itm_Pos")
            iCode = itms.Field(Of String)("itm_Code")
            iDesc = itms.Field(Of String)("itm_Desc")
            iQty = itms.Field(Of Double)("itm_Quantity")
            iUnit = itms.Field(Of String)("itm_Unit")
            iPrice = itms.Field(Of Double)("itm_Sell_Price")
            iTotal = itms.Field(Of Double)("itm_Total_Price")
            iCu = cbCurrency.Text

            dtItms.Rows.Add(iPos, iCode, iDesc, iQty, iUnit, iPrice, iTotal, iCu)
        Next

        Return dtItms
    End Function
    Private Sub CusSelected()
        Dim TCR As Double = 0
        Dim TDR As Double = 0
        Dim tBal As Double = 0

        'Get the total values against the selected account
        'the values are: debit, credit and opening values
        Dim sumCR = Aggregate cr In Me.ACCDBDataSet.tbAccountTrans.AsEnumerable
                    Where cr.Field(Of String)("Account_Name") = cbSupplier.Text _
                    Into Sum(cr.Field(Of Double)("Voucher_Credit"))

        Dim sumDR = Aggregate cr In Me.ACCDBDataSet.tbAccountTrans.AsEnumerable
                    Where cr.Field(Of String)("Account_Name") = cbSupplier.Text _
                    Into Sum(cr.Field(Of Double)("Voucher_Debit"))

        TCR = sumCR
        TDR = sumDR

        If TCR > TDR Then
            tbDRCR.Text = "CR"
        Else
            tbDRCR.Text = "DR"
        End If
        tBal = Math.Abs(TDR - TCR)

        tbAccBalance.Text = FormatNumber(tBal)

    End Sub
    Private Sub btnHideSelection_Click(ByVal sender As System.Object, _
   ByVal e As System.EventArgs)
        clsPurchase.HideSelection(pnlItemsInv)
    End Sub
    Private Sub cmsRemove_Click(ByVal sender As System.Object, _
  ByVal e As System.EventArgs) Handles cmsRemove.Click
        Dim removal = MetroMessageBox.Show(frmMain, _
        "Are you sure you want to remove this item?", "Item Remove", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If removal = DialogResult.Yes Then
            dgInvItem.Rows.Remove(dgInvItem.CurrentRow)
            clsPurchase.itemNumbering(dgInvItem)
        End If
    End Sub
    Private Sub dgInvItem_RowsAdded(ByVal sender As Object, _
ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgInvItem.RowsAdded
        If dgInvItem.Rows.Count < 1 Then
        Else
            tbTotalPrice.Text = clsPurchase.totalComp(dgInvItem)
        End If
    End Sub
    Private Sub dgInvItem_RowsRemoved(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgInvItem.RowsRemoved
        If dgInvItem.Rows.Count < 1 Then
        Else
            tbTotalPrice.Text = clsPurchase.totalComp(dgInvItem)
        End If
        If dgInvItem.RowCount < 1 Then
            tbNetDefault.Text = 0
            tbTotalPrice.Text = 0
            tbDiscAmt.Text = 0
        End If
    End Sub
    Private Sub dgInvItem_CellValueChanged(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) _
    Handles dgInvItem.CellValueChanged

        If dgInvItem.Rows.Count < 1 Then
        Else
            tbTotalPrice.Text = clsPurchase.totalComp(dgInvItem)
        End If
    End Sub
    Private Sub dgItemSelect_KeyDown(ByVal sender As Object, _
   ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgItemSelect.KeyDown
        If e.KeyCode = Keys.Enter Then
            editMode = clsPurchase.addPurchaseItem(tbQuantitySelect.Text, tbCostSelect.Text, _
            dgInvItem, dgItemSelect, editMode, pnlEditMode, cbCurrency.Text)
        End If
    End Sub
    Private Sub dgInvItem_CellEndEdit(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgInvItem.CellEndEdit
        clsPurchase.dgInvItemEditPur(dgInvItem)
    End Sub
    Private Sub btnCancelEdit_Click(ByVal sender As System.Object, _
   ByVal e As System.EventArgs) Handles btnCancelEdit.Click

        pnlEditMode.Visible = False
        clsPurchase.HideSelection(pnlItemsInv)
        editMode = False
    End Sub
    Private Sub cmsEdit_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles cmsEdit.Click
        pnlEditMode.Visible = True
        clsPurchase.ShowSelection(pnlItemsInv)
        editMode = True
    End Sub
    Private Sub tbItemSearch_TextChanged(ByVal sender As Object, _
   ByVal e As System.EventArgs)
        clsPurchase.searchItem(dgItemSelect, tbItemSearch.Text)
    End Sub
    Private Sub tbAccounts_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbAccounts.TextChanged
        dtAccounts = Me.TbAccountsTableAdapter.GetDataFilterAccounts(tbAccounts.Text)
        cbAccounts.DataSource = dtAccounts
        cbAccounts.DisplayMember = "Account_Name"
    End Sub
    Private Sub btnAddAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAccount.Click
        dgLedger.Rows.Add(cbAccounts.Text)
    End Sub
    Private Sub cmLedgerRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmLedgerRemove.Click
        dgLedger.Rows.Remove(dgLedger.CurrentRow)
        computeNet()
    End Sub
    Private Sub cbVoucherType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbVoucherType.SelectedIndexChanged
        'generate invoice number
        Dim arr() As String = returnInvNum(cbVoucherType.Text)
        Try
            lblInvNo.Text = arr(0).ToString + arr(1).ToString
        Catch ex As Exception
            'it catches a null reference when closing
            'dispose the method when returned null
            Exit Sub
        End Try

        Dim getAllocation = From aloc In Me.TbVouchersTableAdapter.GetData.AsEnumerable
                            Where aloc.Field(Of String)("Voucher_Name") = cbVoucherType.Text
                            Select aloc.Field(Of String)("Voucher_Type")

        For Each aloc In getAllocation
            vType = aloc
        Next
    End Sub
    Private Sub btnShowSelection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowSelection.Click
        clsPurchase.ShowSelection(pnlItemsInv)
    End Sub
    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        editMode = clsPurchase.addPurchaseItem(tbQuantitySelect.Text, tbCostSelect.Text, _
       dgInvItem, dgItemSelect, editMode, pnlEditMode, cbCurrency.Text)
    End Sub
    Private Sub cmInv_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmInv.Opening
        contextOpening(dgInvItem, cmInv)
    End Sub
    Private Sub dgInvItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgInvItem.Click
        clsPurchase.HideSelection(pnlItemsInv)
    End Sub
    Private Sub MetroLink1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRollDown.Click
        For i = 0 To Panel2.Height
            Panel2.Height -= 2
        Next
        btnRollUp.Visible = True
    End Sub
    Private Sub btnRollUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRollUp.Click
        btnRollUp.Visible = False
        For i = 0 To 49
            Panel2.Height += 4
        Next
    End Sub
    Private Sub btnSaveInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveInv.Click
        clsPurchase.savePurchase(cbVoucherType.Text, cbCostCenter.Text, tbReference.Text, "", _
        cbSupplier.Text, "", dtInvDate.Text, tbNarration.Text, cbAccRevenue.Text, tbTotalPrice.Text, _
        tbDiscAmtDefault.Text, tbNetDefault.Text, dtInvDate.Text, dgInvItem, vType, frmMain.lblActiveYear.Text, _
        chkPrint.CheckState, chkPrintPreview.CheckState, dgLedger, cbCurrency.Text, tbItemRate.Text, tbLedgerRate.Text)
    End Sub
    Private Sub cbCurrency_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCurrency.SelectedIndexChanged
        selectCurrency()
    End Sub
    Private Sub selectCurrency()
        If cbCurrency.Text = defcur Then
            tbItemRate.Text = 1
            tbLedgerRate.Text = 1
            tbItemRate.Enabled = False
            tbLedgerRate.Enabled = False
        Else
            tbItemRate.Enabled = True
            tbLedgerRate.Enabled = True
        End If

        lblCurrTotal.Text = cbCurrency.Text
        lblNet.Text = cbCurrency.Text

        If dgInvItem.RowCount = 0 Then
        Else
            For i = 0 To dgInvItem.RowCount - 1
                dgInvItem.Rows(i).Cells(7).Value = cbCurrency.Text
            Next
        End If
    End Sub
    Private Sub lnkDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkDetails.Click
        pnlAccDetails.Visible = True
    End Sub
    Private Sub MetroLink2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroLink2.Click
        pnlAccDetails.Visible = False
    End Sub
    Private Sub cbSupplier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSupplier.SelectedIndexChanged
        CusSelected()
    End Sub
    Private Sub dgLedger_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgLedger.CellEndEdit
        Dim valLedger As Double
        Dim rateLedger As Double
        Try
            valLedger = dgLedger.CurrentRow.Cells(1).Value
        Catch ex As Exception
            MetroMessageBox.Show(frmMain, "Invalid value, please enter a valid amount", _
            "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgLedger.CurrentRow.Cells(1).Value = 0
            Exit Sub
        End Try

        validateRate(rateLedger, tbLedgerRate)
        Try
            rateLedger = tbLedgerRate.Text
        Catch ex As Exception
            MetroMessageBox.Show(frmMain, "Invalid forex value. The forex value will now be 1", _
            "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)

            tbLedgerRate.Text = 1
            rateLedger = 1
        End Try

        dgLedger.CurrentRow.Cells(2).Value = valLedger * rateLedger
        computeNet()
    End Sub
    Private Sub validateRate(ByVal rateVal As Double, ByVal tb As MetroFramework.Controls.MetroTextBox)
        Try
            rateVal = tb.Text
        Catch ex As Exception
            MetroMessageBox.Show(frmMain, "Invalid forex value. The forex value will now be 1", _
            "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)

            tb.Text = 1
            rateVal = 1
        End Try
    End Sub
    Private Sub tbTotalPrice_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbTotalPrice.TextChanged
        computeDefaultTotalPrice()
    End Sub
    Private Sub computeDefaultTotalPrice()
        Dim priceTotal As Double
        Dim priceRate As Double

        If tbItemRate.Text = "" Then
            Exit Sub
        Else
            Try
                priceRate = tbItemRate.Text
            Catch ex As Exception
                priceRate = 1
            End Try
            Try
                priceTotal = tbTotalPrice.Text
            Catch ex As Exception
                priceTotal = 0
            End Try
        End If

        tbTotalPriceDefault.Text = priceRate * priceTotal
        computeNet()
    End Sub
    Private Sub computeNet()

        Dim totalPrice As Double = validateVal(tbTotalPrice.Text)
        Dim defTotalPrice As Double = validateVal(tbTotalPriceDefault.Text)
        Dim accVal As Double = 0
        Dim discVal As Double = validateVal(tbDiscAmt.Text)
        Dim discValDef As Double = validateVal(tbDiscAmtDefault.Text)
        Dim ledRate As Double = validateVal(tbLedgerRate.Text)

        If dgLedger.RowCount = 0 Then
        Else
            For i = 0 To dgLedger.RowCount - 1
                accVal += dgLedger.Rows(i).Cells(1).Value
            Next
        End If

        tbNet.Text = totalPrice + accVal + discVal
        tbNetDefault.Text = (accVal * ledRate) + defTotalPrice + discValDef
    End Sub
    Private Sub tbItemRate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbItemRate.TextChanged
        computeDefaultTotalPrice()

        Dim disAmount As Double = validateVal(tbDiscAmt.Text)
        Dim itmRate As Double = validateVal(tbItemRate.Text)
        tbDiscAmtDefault.Text = disAmount * itmRate
    End Sub
    Private Sub tbLedgerRate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbLedgerRate.TextChanged
        Dim ledgerAmount As Double
        Dim ledRate As Double = validateVal(tbLedgerRate.Text)

        If dgLedger.RowCount = 0 Then
        Else
            For i = 0 To dgLedger.RowCount - 1
                ledgerAmount = dgLedger.Rows(i).Cells(1).Value
                dgLedger.Rows(i).Cells(2).Value = ledgerAmount * ledRate
            Next
        End If

        computeNet()
    End Sub
    Private Function validateVal(ByVal valStr As String) As Double
        Dim val As Double
        Try
            val = valStr
        Catch ex As Exception
            val = 0
        End Try
        Return val
    End Function
    Private Sub tbDiscAmt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbDiscAmt.TextChanged
        Dim disAmount As Double = validateVal(tbDiscAmt.Text)
        Dim itmRate As Double = validateVal(tbItemRate.Text)
        tbDiscAmtDefault.Text = disAmount * itmRate
        computeNet()
    End Sub
    Private Sub tbSupplier_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbSupplier.TextChanged
        Me.TbAccountsTableAdapter.FilterAccounts(Me.ACCDBDataSet.tbAccounts, tbSupplier.Text)
        CusSelected()
    End Sub
    Private Sub pnlAccDetails_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlAccDetails.Paint

    End Sub
End Class
