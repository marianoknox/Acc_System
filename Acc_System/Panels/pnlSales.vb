Imports MetroFramework

Public Class pnlSales
    Dim invCls As New clsSalesInvoice
    Dim editMode As Boolean = False
    Dim vType As String

    Private Sub pnlSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'initialize value
        'needs refactoring
        tbTotalPrice.Text = 0

        'Initialize all the tables and them over the instance
        Me.TbVouchersTableAdapter.FillSales(Me.ACCDBDataSet.tbVouchers)
        Me.TbCostCenterListTableAdapter.Fill(Me.ACCDBDataSet.tbCostCenterList)
        Me.TbAccountsTableAdapter.Fill(Me.ACCDBDataSet.tbAccounts)
        Me.TbAccountTransTableAdapter.Fill(Me.ACCDBDataSet.tbAccountTrans)
        Me.TbItemsTableAdapter.Fill(Me.ACCDBDataSet.tbItems)
        Me.TbLocationListTableAdapter.Fill(Me.ACCDBDataSet.tbLocationList)
        Me.TbVoucherTransTableAdapter.Fill(Me.ACCDBDataSet.tbVoucherTrans)

        'fill secondary account
        cbAccRevenue.DataSource = Me.TbAccountsTableAdapter.GetDataAccAs("Sales Account")
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

        'fill datagrid view for item selection
        dgItemSelect.DataSource = retrieveTableFunction( _
            "SELECT itm_Code, itm_Desc, " & _
            "itm_Unit, itm_Price " & _
            "FROM tbItems")

        invCls.dgProperties(dgItemSelect)

        'test variable for edit mode
        'use the same form for edit and new entry

        If EditEntry = True Then
            cbVoucherType.Enabled = False
            Dim arrDetails() As String
            arrDetails = getEditValues()
            selectCb(cbVoucherType, arrDetails(1))
            lblInvNo.Text = arrDetails(0)
            selectCb(cbCostCenter, arrDetails(2))
            tbReference.Text = arrDetails(4)
            tbQuotaion.Text = arrDetails(5)
            tbLPO.Text = arrDetails(6)
            dtInvDate.Text = arrDetails(7)
            tbDiscAmt.Text = arrDetails(8)
            selectCb(cbCustomer, arrDetails(9))
            selectCb(cbAccRevenue, arrDetails(3))
            tbNarration.Text = arrDetails(10)

            Dim dtItms As DataTable
            Dim arrCol(6) As String
            dtItms = getItemValues()

            For iRow = 0 To dtItms.Rows.Count - 1

                For iCol = 0 To dtItms.Columns.Count - 1
                    arrCol(iCol) = dtItms.Rows(iRow).Item(iCol)
                Next

                dgInvItem.Rows.Add(arrCol)
            Next
        Else

        End If

        'calls the method to generate sales order reference
        getSalesOrderDetails()

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
                                Where sled.Field(Of String)("Account_As") = "Sales Account" _
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

        Dim arrDetails(10) As String
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
            arrDetails(10) = vchr.Field(Of String)("Voucher_Narration")
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


        Dim filterItems = From itm In Me.TbItemTransTableAdapter.GetData.AsEnumerable _
                          Where itm.Field(Of String)("Reference_ID") = reference_Id _
                          Select itm

        Dim iPos, iCode, iDesc, iQty, iUnit, iPrice, iTotal As String
        For Each itms In filterItems
            iPos = itms.Field(Of Integer)("itm_Pos")
            iCode = itms.Field(Of String)("itm_Code")
            iDesc = itms.Field(Of String)("itm_Desc")
            iQty = itms.Field(Of Double)("itm_Quantity")
            iUnit = itms.Field(Of String)("itm_Unit")
            iPrice = itms.Field(Of Double)("itm_Sell_Price")
            iTotal = itms.Field(Of Double)("itm_Total_Price")

            dtItms.Rows.Add(iPos, iCode, iDesc, iQty, iUnit, iPrice, iTotal)
        Next

        Return dtItms
    End Function
    Private Sub btnShowSelection_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles btnShowSelection.Click
        invCls.ShowSelection(pnlItemsInv)
    End Sub
    Private Sub btnHideSelection_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles btnHideSelection.Click
        invCls.HideSelection(pnlItemsInv)
    End Sub
    Private Sub btnSaveInv_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles btnSaveInv.Click
        Dim accBalance As Double
        Dim netInv As Double
        Dim crLimit As Double

        Try
            accBalance = tbAccBalance.Text
            netInv = tbNetAmount.Text
            crLimit = tbCreditLimit.Text
        Catch ex As Exception
            Exit Sub
        End Try

        'check for null reference
        If dgInvItem.RowCount = 0 Then
            MetroMessageBox.Show(frmMain, "Invoice is Empty.", "Null Invoice", _
            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        'credit limit validation
        'when edit, subtract the amount of invoice to be edited from the credit limit
        If crLimit = 0 Then
        Else
            If tbDRCR.Text = "DR" Then
                If accBalance + netInv > crLimit Then
                    MetroMessageBox.Show(frmMain, "The invoice is above credit limit", "Credit limit", _
                    MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
            Else
                If netInv - accBalance > crLimit Then
                    MetroMessageBox.Show(frmMain, "The invoice is above credit limit", "Credit limit", _
                    MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
            End If
        End If

        Dim due As Date
        Dim startDate As Date
        Dim creditDays As Integer
        Try
            creditDays = tbDays.Text
        Catch ex As Exception
            creditDays = 0
        End Try
        startDate = dtInvDate.Text
        due = startDate.AddDays(creditDays)

        invCls.saveInvoice(cbVoucherType.Text, cbCostCenter.Text, tbReference.Text, tbQuotaion.Text, _
        cbCustomer.Text, tbLPO.Text, dtInvDate.Text, tbNarration.Text, cbAccRevenue.Text, tbTotalPrice.Text, _
        tbDiscAmt.Text, tbNetAmount.Text, FormatDateTime(due, DateFormat.ShortDate), dgInvItem, vType, _
        frmMain.lblActiveYear.Text, chkPrint.CheckState, chkPrintPreview.CheckState)

        Me.Finalize()
        GC.Collect()
    End Sub
    Private Sub MetroLink4_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles MetroLink4.Click

        hideQuotation()

        Dim arrQ(6) As String
        For i = 0 To dgQuot.Rows.Count - 1
            arrQ(0) = 0
            arrQ(1) = dgQuot.Rows(i).Cells(0).Value
            arrQ(2) = dgQuot.Rows(i).Cells(1).Value
            arrQ(3) = dgQuot.Rows(i).Cells(2).Value
            arrQ(4) = dgQuot.Rows(i).Cells(3).Value
            arrQ(5) = dgQuot.Rows(i).Cells(4).Value
            arrQ(6) = dgQuot.Rows(i).Cells(5).Value

            dgInvItem.Rows.Add(arrQ)
        Next

        itemNumbering(dgInvItem)

        tbQuotaion.Text = cbSO.Text
    End Sub
    Private Sub MetroLink5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroLink5.Click
        hideQuotation()
    End Sub
    Private Sub hideQuotation()
        Dim pointX As Integer = pnlQuot.Location.X
        Dim pointY As Integer = pnlQuot.Location.Y

        If pointY < Me.Height - 80 Then
            For i = 0 To 70
                pointY += 5
                pnlQuot.Location = New Point(pointX, pointY)
            Next
        End If
    End Sub
    Private Sub getQuotItems()
        dgQuot.Rows.Clear()
        Dim dtQuot As DataTable
        dtQuot = retrieveTableFunction("SELECT itm_Code, itm_Desc, itm_Quantity, itm_Unit, itm_Sell_Price, " & _
                                       "itm_Total_Price FROM tbItemTrans WHERE Reference_ID = '" & cbSO.Text & "'")

        Dim arrQ(5) As String
        For i = 0 To dtQuot.Rows.Count - 1
            arrQ(0) = dtQuot.Rows(i).Item(0)
            arrQ(1) = dtQuot.Rows(i).Item(1)
            arrQ(2) = dtQuot.Rows(i).Item(2)
            arrQ(3) = dtQuot.Rows(i).Item(3)
            arrQ(4) = dtQuot.Rows(i).Item(4)
            arrQ(5) = dtQuot.Rows(i).Item(5)

            dgQuot.Rows.Add(arrQ)

        Next

    End Sub
    Private Sub tbQuotaionButton_Click(ByVal sender As System.Object, _
   ByVal e As System.EventArgs) Handles tbQuotaion.ButtonClick
        Dim pointX As Integer = pnlQuot.Location.X
        Dim pointY As Integer = pnlQuot.Location.Y

        If pointY > 500 Then
            For i = 0 To 70
                pointY -= 5
                pnlQuot.Location = New Point(pointX, pointY)
            Next
        End If

    End Sub
    Private Sub cbSO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSO.SelectedIndexChanged
        getQuotItems()
    End Sub
    Private Sub tbItemSearch_TextChanged(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles tbItemSearch.TextChanged
        invCls.searchItem(dgItemSelect, tbItemSearch.Text)
    End Sub  
    Private Sub getSalesOrderDetails()
        Dim getSO = From gso In Me.TbVoucherTransTableAdapter.GetData.AsEnumerable _
                    Join vch In Me.TbVouchersTableAdapter.GetData.AsEnumerable _
                    On gso.Field(Of String)("Voucher_Name") Equals vch.Field(Of String)("Voucher_Name") _
                    Where gso.Field(Of String)("Account_Name") = cbCustomer.Text _
                    And vch.Field(Of String)("Voucher_Type") = "Sales Order" _
                    Select gso.Field(Of String)("Reference_ID")

        Dim arrRef(getSO.Count - 1) As String
        Dim counter As Integer = 0
        For Each igso In getSO
            arrRef(counter) = igso
            counter += 1
        Next

        cbSO.DataSource = arrRef

        'Dim dtSOV As New DataTable
        'dtSOV = retrieveTableFunction("SELECT ")
    End Sub
    Private Sub btnAccept_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles btnAccept.Click
        editMode = invCls.addInvoiceItem(tbQuantitySelect.Text, _
        dgInvItem, dgItemSelect, editMode, pnlEditMode)

        getClosingItemBal(dgItemSelect.CurrentRow.Cells(0).Value)
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles btnPrint.Click
        'invCls.printInvoice()
    End Sub
    Private Sub cmInv_Opening(ByVal sender As System.Object, _
    ByVal e As System.ComponentModel.CancelEventArgs) Handles cmInv.Opening
        contextOpening(dgInvItem, cmInv)
    End Sub
    Private Sub dgInvItem_Click(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles dgInvItem.Click
        invCls.HideSelection(pnlItemsInv)
        pnlChangePrice.Visible = False
        pnlAccDetails.Visible = False
        pnlEditMode.Visible = False
        editMode = False
        hideQuotation()
    End Sub
    Private Sub dgInvItem_RowsAdded(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles dgInvItem.RowsAdded
        If dgInvItem.Rows.Count < 1 Then
        Else
            tbTotalPrice.Text = invCls.totalComp(dgInvItem)
        End If
    End Sub
    Private Sub dgInvItem_RowsRemoved(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles dgInvItem.RowsRemoved
        If dgInvItem.Rows.Count < 1 Then
        Else
            tbTotalPrice.Text = invCls.totalComp(dgInvItem)
        End If
        If dgInvItem.RowCount < 1 Then
            tbNetAmount.Text = 0
            tbTotalPrice.Text = 0
            tbDiscAmt.Text = 0
        End If
    End Sub
    Private Sub dgInvItem_CellValueChanged(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) _
    Handles dgInvItem.CellValueChanged

        If dgInvItem.Rows.Count < 1 Then
        Else
            tbTotalPrice.Text = invCls.totalComp(dgInvItem)
        End If
    End Sub
    Private Sub cmsEdit_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles cmsEdit.Click
        pnlEditMode.Visible = True
        invCls.ShowSelection(pnlItemsInv)
        editMode = True
    End Sub
    Private Sub btnCancelEdit_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles btnCancelEdit.Click

        pnlEditMode.Visible = False
        invCls.HideSelection(pnlItemsInv)
        editMode = False
    End Sub
    Private Sub cbVoucherType_SelectedIndexChanged(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles cbVoucherType.SelectedIndexChanged

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
    Private Sub cbCustomer_SelectedIndexChanged(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles cbCustomer.SelectedIndexChanged
        CusSelected()
        getSalesOrderDetails()
        getQuotItems()
    End Sub
    Private Sub CusSelected()
        Dim TCR As Double = 0
        Dim TDR As Double = 0
        Dim openCR As Double = 0
        Dim openDR As Double = 0
        Dim tBal As Double = 0
        Dim crDays As Double = 0
        Dim crLimit As Double = 0

        'Get the total values against the selected account
        'the values are: debit, credit and opening values
        Dim sumCR = Aggregate cr In Me.ACCDBDataSet.tbAccountTrans.AsEnumerable
                    Where cr.Field(Of String)("Account_Name") = cbCustomer.Text _
                    Into Sum(cr.Field(Of Double)("Voucher_Credit"))

        Dim sumDR = Aggregate cr In Me.ACCDBDataSet.tbAccountTrans.AsEnumerable
                    Where cr.Field(Of String)("Account_Name") = cbCustomer.Text _
                    Into Sum(cr.Field(Of Double)("Voucher_Debit"))

        For i = 0 To Me.ACCDBDataSet.tbAccounts.Rows.Count - 1
            If Me.ACCDBDataSet.tbAccounts.Rows(i).Item("Account_Name") = cbCustomer.Text Then
                ' openCR = Me.ACCDBDataSet.tbAccounts.Rows(i).Item("Open_CR")
                ' openDR = Me.ACCDBDataSet.tbAccounts.Rows(i).Item("Open_DR")
                crDays = Me.ACCDBDataSet.tbAccounts.Rows(i).Item("Credit_Days")
                crLimit = Me.ACCDBDataSet.tbAccounts.Rows(i).Item("Credit_Limit")
            End If
        Next

        TCR = sumCR
        TDR = sumDR

        If TCR > TDR Then
            tbDRCR.Text = "CR"
        Else
            tbDRCR.Text = "DR"
        End If
        tBal = Math.Abs(TDR - TCR)

        tbAccBalance.Text = FormatNumber(tBal)
        tbDays.Text = crDays
        tbCreditLimit.Text = FormatNumber(crLimit)
    End Sub
    Private Sub cbCostCenter_SelectedIndexChanged(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles cbCostCenter.SelectedIndexChanged
        'Me.TbAccountsTableAdapter.Fill(Me.ACCDBDataSet.tbAccounts) 'why??
        'CusSelected()
    End Sub
    Private Sub tbCustomer_TextChanged(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles tbCustomer.TextChanged
        Me.TbAccountsTableAdapter.FilterAccounts(Me.ACCDBDataSet.tbAccounts, tbCustomer.Text)
        CusSelected()
    End Sub
    Private Sub lnkDetails_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles lnkDetails.Click
        pnlAccDetails.Visible = True
    End Sub
    Private Sub MetroLink2_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles MetroLink2.Click
        pnlAccDetails.Visible = False
    End Sub
    Private Sub dgInvItem_CellEndEdit(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgInvItem.CellEndEdit
        invCls.dgInvItemEdit(dgInvItem)
    End Sub
    Private Sub tbTotalPrice_TextChanged(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles tbTotalPrice.TextChanged
        tbNetAmount.Text = invCls.netCompute(tbTotalPrice.Text, tbDiscAmt.Text)
    End Sub
    Private Sub tbDiscAmt_KeyDown(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbDiscAmt.KeyDown
        If e.KeyCode = Keys.Enter Then
            tbNetAmount.Text = invCls.validateDiscount(tbDiscAmt, tbTotalPrice.Text)
            tbNarration.Focus()
        End If
    End Sub
    Private Sub tbDiscAmt_LostFocus(ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles tbDiscAmt.LostFocus
        tbNetAmount.Text = invCls.validateDiscount(tbDiscAmt, tbTotalPrice.Text)
        tbNarration.Focus()
    End Sub
    Private Sub dgItemSelect_KeyDown(ByVal sender As Object, _
    ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgItemSelect.KeyDown
        If e.KeyCode = Keys.Enter Then
            editMode = invCls.addInvoiceItem(tbQuantitySelect.Text, _
            dgInvItem, dgItemSelect, editMode, pnlEditMode)

            getClosingItemBal(dgItemSelect.CurrentRow.Cells(0).Value)
        End If
    End Sub
    Private Sub btnRollDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRollDown.Click
        For i = 0 To Panel2.Height
            Panel2.Height -= 1
        Next
        btnRollUp.Visible = True
    End Sub
    Private Sub btnRollUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRollUp.Click
        btnRollUp.Visible = False
        For i = 0 To 58
            Panel2.Height += 2
        Next
    End Sub
    Private Sub dgInvItem_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgInvItem.CellFormatting
        '    If e.ColumnIndex = Me.dgInvItem.Columns("colQty").Index _
        '    AndAlso (e.Value IsNot Nothing) Then

        '        With Me.dgInvItem.Rows(e.RowIndex).Cells(e.ColumnIndex)
        '            ' invCls.showBalance(dgInvItem)

        '            .ToolTipText = getItemBalance()

        '        End With
        '    End If
    End Sub
    Private Sub dgInvItem_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgInvItem.SelectionChanged
        If dgInvItem.RowCount = 0 Then
            Exit Sub
            tbStoreQty.Text = 0
            tbShowroomQty.Text = 0
        End If
        getClosingItemBal(dgInvItem.CurrentRow.Cells(1).Value)
    End Sub
    Private Sub getClosingItemBal(ByVal itmCode As String)
        If dgInvItem.RowCount = 0 Then
            Exit Sub
        End If
        'Dim arrVal() As String
        'arrVal = getItemBalance(itmCode)

        Dim locTable As DataTable
        locTable = getItemBalance(itmCode)
        lblLoc1.Text = locTable.Rows(0).Item(0)
        lblLoc2.Text = locTable.Rows(1).Item(0)
        tbStoreQty.Text = locTable.Rows(0).Item(1)
        tbShowroomQty.Text = locTable.Rows(1).Item(1)

    End Sub
    Private Sub cmsShowBal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsShowBal.Click
        pnlChangePrice.Visible = True
        tbOrPrice.Text = dgInvItem.CurrentRow.Cells(5).Value
        tbNewPrice.Text = ""
        tbNewPrice.Focus()
    End Sub
    Private Sub btnOkPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkPrice.Click
        changePrice()
    End Sub
    Private Sub changePrice()
        Dim nPrice As Double
        Try
            nPrice = tbNewPrice.Text
        Catch ex As Exception
            MetroMessageBox.Show(frmMain, "Please input a valid Price range", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            tbNewPrice.Text = ""
            Exit Sub
        End Try

        dgInvItem.CurrentRow.Cells(5).Value = tbNewPrice.Text
        dgInvItem.CurrentRow.Cells(6).Value = dgInvItem.CurrentRow.Cells(3).Value _
        * dgInvItem.CurrentRow.Cells(5).Value

        pnlChangePrice.Visible = False
    End Sub
    Private Sub btnCancelPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelPrice.Click
        pnlChangePrice.Visible = False
    End Sub
    Private Sub tbNewPrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbNewPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            changePrice()
        End If
    End Sub
    Private Sub CurrentItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrentItemToolStripMenuItem.Click
        Dim removal = MetroMessageBox.Show(frmMain, _
       "Are you sure you want to remove this item?", "Item Remove", _
       MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If removal = DialogResult.Yes Then
            dgInvItem.Rows.Remove(dgInvItem.CurrentRow)
            invCls.itemNumbering(dgInvItem)
        End If
    End Sub
    Private Sub AllItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllItemsToolStripMenuItem.Click
        Dim removal = MetroMessageBox.Show(frmMain, _
       "Are you sure you want to remove all the Items?", "Items Clear", _
       MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If removal = DialogResult.Yes Then
            dgInvItem.Rows.Clear()
        End If
    End Sub
End Class
