Imports MetroFramework

Public Class clsSalesInvoice

    'sample encapsulation
    'not sure if gonna use it

    'always use underscore for encapsulated properties
    Private _vtypeSample As String

    Public Property vouchType() As String
        Get
            Return _vtypeSample
        End Get
        Set(ByVal value As String)
            _vtypeSample = value
        End Set
    End Property
    '-----------------------------------------------------


    Public Sub dgProperties(ByVal dgItemSelect As MetroFramework.Controls.MetroGrid)
        With dgItemSelect
            .Columns(0).Width = 100
            .Columns(1).Width = 300
        End With
        For i = 2 To dgItemSelect.Columns.Count - 1
            dgItemSelect.Columns(i).Width = 70
            dgItemSelect.Columns(i).DefaultCellStyle.Alignment = _
            DataGridViewContentAlignment.MiddleRight
        Next
    End Sub
    Public Sub searchItem(ByVal dgItemSelect As MetroFramework.Controls.MetroGrid, _
        ByVal strSearch As String)

        'filter items from datagrid view for item selection
        dgItemSelect.DataSource = retrieveTableFunction( _
            "SELECT itm_Code,itm_Desc,itm_Unit,itm_Price " & _
            "FROM tbItems WHERE itm_Desc LIKE '%" _
            & strSearch & "%'")

        dgProperties(dgItemSelect)
    End Sub
    Public Function addInvoiceItem(ByVal valQty As String, _
    ByVal dgInvItem As MetroFramework.Controls.MetroGrid, _
    ByVal dgItemSelect As MetroFramework.Controls.MetroGrid, _
    ByVal editMode As Boolean, ByVal pnlEditMode As Panel) As Boolean


        Dim testVal = IsNumeric(valQty)
        If testVal = False Then
            MetroMessageBox.Show(frmMain, _
            "Invalid quantity: Please enter a valid integer", "Invalid", _
            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        '------------------------------------------------------------------------------------

        Dim itemNum As Integer = dgInvItem.Rows.Count + 1
        Dim itemCode As String = dgItemSelect.CurrentRow.Cells("itm_Code").Value
        Dim itemDesc As String = dgItemSelect.CurrentRow.Cells("itm_Desc").Value
        Dim itemQty As Double = valQty
        Dim itemUnit As String = dgItemSelect.CurrentRow.Cells("itm_Unit").Value
        Dim itemPrice As Double = dgItemSelect.CurrentRow.Cells("itm_Price").Value
        Dim itemTotal As Double = itemQty * itemPrice

        'array to insert the entire line in invoice items
        Dim arrItems(6) As String
        arrItems(0) = itemNum
        arrItems(1) = itemCode
        arrItems(2) = itemDesc
        arrItems(3) = itemQty
        arrItems(4) = itemUnit
        arrItems(5) = itemPrice
        arrItems(6) = itemTotal

        If editMode = True Then
            dgInvItem.CurrentRow.SetValues(arrItems)
            pnlEditMode.Visible = False
        Else
            dgInvItem.Rows.Add(arrItems)
        End If

        'Current display to last row
        dgInvItem.FirstDisplayedScrollingRowIndex = dgInvItem.RowCount - 1

        'Select the last row.
        dgInvItem.Rows(dgInvItem.RowCount - 1).Selected = True

        Return False

    End Function
    Public Function addPurchaseItem(ByVal valQty As String, ByVal valCost As String, _
    ByVal dgInvItem As MetroFramework.Controls.MetroGrid, _
    ByVal dgItemSelect As MetroFramework.Controls.MetroGrid, _
    ByVal editMode As Boolean, ByVal pnlEditMode As Panel, ByVal curSymbol As String) As Boolean


        Dim testVal = IsNumeric(valQty)
        If testVal = False Then
            MetroMessageBox.Show(frmMain, _
            "Invalid quantity: Please enter a valid integer", "Invalid", _
            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        Dim testCost = IsNumeric(valCost)
        If testCost = False Then
            MetroMessageBox.Show(frmMain, _
            "Invalid quantity: Please enter a valid integer", "Invalid", _
            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        '------------------------------------------------------------------------------------
        'compare if the value is less than the balance available
        'Dim num1 As Double = tbQuantitySelect.Text
        'Dim num2 As Double = dgItemSelect.CurrentRow.Cells(3).Value

        'If frmMain.lblPosition.Text = "Admin" Then
        'Else
        '    If num1 > num2 Then
        '        MetroMessageBox.Show(frmMain, _
        '        "Please enter a lower value", "Insuficient amount", _
        '        MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        tbQuantitySelect.Text = ""
        '        Exit Sub
        '    End If
        'End If

        Dim itemNum As Integer = dgInvItem.Rows.Count + 1
        Dim itemCode As String = dgItemSelect.CurrentRow.Cells("itm_Code").Value
        Dim itemDesc As String = dgItemSelect.CurrentRow.Cells("itm_Desc").Value
        Dim itemQty As Double = valQty
        Dim itemUnit As String = dgItemSelect.CurrentRow.Cells("itm_Unit").Value
        Dim itemPrice As Double = valCost
        Dim itemTotal As Double = itemQty * itemPrice

        'array to insert the entire line in invoice items
        Dim arrItems(7) As String
        arrItems(0) = itemNum
        arrItems(1) = itemCode
        arrItems(2) = itemDesc
        arrItems(3) = itemQty
        arrItems(4) = itemUnit
        arrItems(5) = itemPrice
        arrItems(6) = itemTotal
        arrItems(7) = curSymbol

        If editMode = True Then
            dgInvItem.CurrentRow.SetValues(arrItems)
            pnlEditMode.Visible = False
        Else
            dgInvItem.Rows.Add(arrItems)
        End If

        'Current display to last row
        dgInvItem.FirstDisplayedScrollingRowIndex = dgInvItem.RowCount - 1

        'Select the last row.
        dgInvItem.Rows(dgInvItem.RowCount - 1).Selected = True

        Return False
    End Function
    Public Sub itemNumbering(ByVal dgInvItem As MetroFramework.Controls.MetroGrid)
        Dim counter As Integer = 1
        For i = 0 To dgInvItem.Rows.Count - 1
            dgInvItem.Rows(i).Cells(0).Value = counter
            counter += 1
        Next
    End Sub
    Public Sub printInvoice(ByVal Reference_ID As String)

    End Sub
    Public Function totalComp(ByVal dgInvItem As MetroFramework.Controls.MetroGrid) As String
        Dim totalAmt As Double
        Dim curVal As Double
        For i = 0 To dgInvItem.Rows.Count - 1
            curVal = dgInvItem.Rows(i).Cells(6).Value
            totalAmt += curVal
        Next

        Return totalAmt
    End Function
    Public Function netCompute(ByVal tbTotalPrice As String _
        , ByVal tbDiscAmt As String) As String
        If tbTotalPrice = "" Then
            tbTotalPrice = 0
        End If
        Dim totaAmount As Double = tbTotalPrice
        Dim discAmount As Double = tbDiscAmt
        Dim netAmount As Double

        netAmount = totaAmount + discAmount

        Return netAmount
    End Function
    Public Function validateDiscount(ByVal tbDiscAmt As MetroFramework.Controls.MetroTextBox, _
                                 ByVal tbTotalPrice As String) As String
        Dim testVal = IsNumeric(tbDiscAmt.Text)
        Dim netAmount As Double

        If testVal = False Then
            MetroMessageBox.Show(frmMain, "Invalid Discount Amount", "Invalid", _
            MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbDiscAmt.Text = 0
            netAmount = netCompute(tbTotalPrice, tbDiscAmt.Text)
        Else
            netAmount = netCompute(tbTotalPrice, tbDiscAmt.Text)
        End If

        Return netAmount
    End Function
    Public Sub ShowSelection(ByVal pnlItemsInv As Panel)

        Dim pointX As Integer = pnlItemsInv.Location.X
        Dim pointY As Integer = pnlItemsInv.Location.Y

        If pointX > 550 Then
            For i = 0 To 130
                pointX -= 5
                pnlItemsInv.Location = New Point(pointX, pointY)
            Next
        End If

    End Sub
    Public Sub HideSelection(ByVal pnlItemsInv As Panel)

        Dim pointX As Integer = pnlItemsInv.Location.X
        Dim pointY As Integer = pnlItemsInv.Location.Y

        If pointX < 1200 Then
            For i = 0 To 130
                pointX += 5
                pnlItemsInv.Location = New Point(pointX, pointY)
            Next
        End If
    End Sub
    Public Sub saveInvoice(ByVal cbVoucherType As String, ByVal cbCostCenter As String, _
    ByVal tbReference As String, ByVal tbQuotation As String, ByVal cbCustomer As String, ByVal tbLPO As String, _
    ByVal dtDate As Date, ByVal tbNarration As String, ByVal cbAccRevenue As String, ByVal tbTotalPrice As Double, _
    ByVal tbDiscount As Double, ByVal tbNet As Double, ByVal dueDate As Date, _
    ByVal dgItems As MetroFramework.Controls.MetroGrid, ByVal vType As String, ByVal Active_Year As Integer, _
    ByVal printSave As Boolean, ByVal printPreview As Boolean)
        'identify default location
        Dim defLoc As String
        defLoc = getDefaultLocation()

        'identify default currency
        Dim defcur As String
        defcur = getDefaultCurrency()

        Dim voucPrefix As String = Nothing
        Dim voucID As Integer = Nothing

        Dim savePrint = _
            MetroMessageBox.Show(frmMain, _
            "Do you want to save now?", "Save Sales Invoice", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If savePrint = DialogResult.Yes Then
            Dim vNumber As String
            'Validation portion:
            'terminate saving if conditions are not satisfied
            '-----------------------------------------------------------------
            'refresh invoice numbering
            Dim arr() As String = returnInvNum(cbVoucherType)
            Dim dtPrefID As DataTable
            dtPrefID = retrieveTableFunction("SELECT Voucher_Prefix, Voucher_ID FROM tbVoucherTrans WHERE Reference_ID = '" & reference_Id & "'")

            If EditEntry = True Then
                vNumber = reference_Id
                If dtPrefID.Rows.Count = 0 Then
                Else
                    voucPrefix = dtPrefID.Rows(0).Item(0)
                    voucID = dtPrefID.Rows(0).Item(1)
                End If
                deleteRecordnoMsg(reference_Id)
            Else
                voucPrefix = arr(0)
                voucID = arr(1)
                vNumber = voucPrefix + voucID.ToString
            End If

            'validate for duplicate reference
            checkDuplicate(vNumber)

            'check again if the stock quantity are sufficient
            'identify default location
            Dim itmCode As String
            Dim itmQty As Double
            Dim curVal As Double

            For i = 0 To dgItems.RowCount - 1
                itmCode = dgItems.Rows(i).Cells(1).Value.ToString
                itmQty = dgItems.Rows(i).Cells(3).Value
                curVal = getItemBalance(itmCode, defLoc)

                If itmQty > curVal Then
                    MetroMessageBox.Show(frmMain, "The item " + itmCode + _
                    ", " + "is now insufficient, please enter a lower quantity", _
                    "Insuficient Balance", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
            Next

            '---------------------------------------------------------------end of validation

            'save voucher transaction to update instantly the invoice last entry
            If vType = "Sales Return" Then
                saveVoucher(voucPrefix, voucID, dtDate, cbVoucherType, cbCostCenter, cbCustomer, tbTotalPrice, _
                tbDiscount, tbNet, tbReference, tbLPO, tbQuotation, tbNarration, dueDate, False, vNumber, Active_Year)
            Else
                saveVoucher(voucPrefix, voucID, dtDate, cbVoucherType, cbCostCenter, cbCustomer, tbTotalPrice, _
                tbDiscount, tbNet, tbReference, tbLPO, tbQuotation, tbNarration, dueDate, True, vNumber, Active_Year)
            End If

            'identify if return or not
            If vType = "Sales Return" Then
                'save accounts transaction
                'save personal account (Customer)
                saveAccount(cbVoucherType, cbCustomer, 0, tbNet, 0, _
                dtDate, dueDate, True, True, vNumber, Active_Year, defcur, 1, "CR", 1)
                'save discount account
                saveAccount(cbVoucherType, "Sales Discount", 0, Math.Abs(tbDiscount), 0, _
                dtDate, dueDate, True, False, vNumber, Active_Year, defcur, 1, "CR", 1)
                'save nominal account
                saveAccount(cbVoucherType, cbAccRevenue, tbTotalPrice, 0, 0, _
                dtDate, dueDate, True, False, vNumber, Active_Year, defcur, 1, "DR", 2)


                'save items transaction (Increase in Assets)

                For i = 0 To dgItems.RowCount - 1
                    Dim iPos As Integer = dgItems.Rows(i).Cells(0).Value
                    Dim iCode As String = dgItems.Rows(i).Cells(1).Value
                    Dim iDesc As String = dgItems.Rows(i).Cells(2).Value
                    Dim iQty As Double = dgItems.Rows(i).Cells(3).Value
                    Dim iUnit As String = dgItems.Rows(i).Cells(4).Value
                    Dim iPrice As Double = dgItems.Rows(i).Cells(5).Value
                    Dim iTotal As Double = dgItems.Rows(i).Cells(6).Value
                    Dim iDisc As Double

                    'in case of inventory adjustment:
                    'nulify the value of discount
                    If tbTotalPrice = 0 Then
                        iDisc = 0
                    Else
                        iDisc = (iTotal / tbTotalPrice) * tbDiscount
                    End If

                    saveItemTrans(cbVoucherType, dtDate, iCode, iDesc, iQty, iUnit, _
                              iQty, 0, defLoc, iPrice, iTotal, 0, iDisc, cbCustomer, True, _
                              voucPrefix + voucID.ToString, iPos, Active_Year, 0, 0)
                Next


                'save reference if the account is maintaining balance
                saveReference(cbCustomer, voucPrefix + voucID.ToString, "CR", tbNet, tbNet, False, Active_Year)
            Else
                'save accounts transaction
                'save customer account
                saveAccount(cbVoucherType, cbCustomer, tbNet, 0, 0, _
                dtDate, dueDate, True, True, vNumber, Active_Year, defcur, 1, "DR", 1)
                'save discount account
                saveAccount(cbVoucherType, "Sales Discount", Math.Abs(tbDiscount), 0, 0, _
                dtDate, dueDate, True, True, vNumber, Active_Year, defcur, 1, "DR", 1)
                'save nominal account (Income)
                saveAccount(cbVoucherType, cbAccRevenue, 0, tbTotalPrice, 0, _
                dtDate, dueDate, True, True, vNumber, Active_Year, defcur, 1, "CR", 2)


                'save items transaction (Reduction of Assets)

                For i = 0 To dgItems.RowCount - 1
                    Dim iPos As Integer = dgItems.Rows(i).Cells(0).Value
                    Dim iCode As String = dgItems.Rows(i).Cells(1).Value
                    Dim iDesc As String = dgItems.Rows(i).Cells(2).Value
                    Dim iQty As Double = dgItems.Rows(i).Cells(3).Value
                    Dim iUnit As String = dgItems.Rows(i).Cells(4).Value
                    Dim iPrice As Double = dgItems.Rows(i).Cells(5).Value
                    Dim iTotal As Double = dgItems.Rows(i).Cells(6).Value
                    Dim iDisc As Double
                    'in case of inventory adjustment:
                    'nulify the value of discount
                    If tbTotalPrice = 0 Then
                        iDisc = 0
                    Else
                        iDisc = (iTotal / tbTotalPrice) * tbDiscount
                    End If

                    saveItemTrans(cbVoucherType, dtDate, iCode, iDesc, iQty, iUnit, _
                              0, iQty, defLoc, iPrice, iTotal, 0, iDisc, cbCustomer, True, _
                              voucPrefix + voucID.ToString, iPos, Active_Year, 0, 0)
                Next

                'save reference if the account is maintaining balance
                saveReference(cbCustomer, vNumber, "DR", tbNet, tbNet, True, Active_Year)

                If printSave = True Then

                End If
                If printPreview = True Then
                    printInvoice(voucPrefix + voucID.ToString)
                End If
            End If

            EditEntry = False

            Dim pnl As New pnlSales(frmMain)
            pnl.swipe(True)
        Else

        End If

    End Sub

    Public Sub savePurchase(ByVal cbVoucherType As String, ByVal cbCostCenter As String, _
    ByVal tbReference As String, ByVal tbQuotation As String, ByVal cbSupplier As String, ByVal tbLPO As String, _
    ByVal dtDate As Date, ByVal tbNarration As String, ByVal cbAccRevenue As String, ByVal tbTotalPrice As Double, _
    ByVal tbDiscount As Double, ByVal tbNet As Double, ByVal dueDate As Date, _
    ByVal dgItems As MetroFramework.Controls.MetroGrid, ByVal vType As String, ByVal Active_Year As Integer, _
    ByVal printSave As Boolean, ByVal printPreview As Boolean, ByVal dgLedger As MetroFramework.Controls.MetroGrid, _
    ByVal usedCurrency As String, ByVal forexItem As Double, ByVal forexLedger As Double)

        'identify default location
        Dim defLoc As String
        defLoc = getDefaultLocation()

        Dim voucPrefix As String
        Dim voucID As Integer

        Dim savePrint = _
            MetroMessageBox.Show(frmMain, _
            "Do you want to save now?", "Save Purchase Invoice", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If savePrint = DialogResult.Yes Then

            'Validation portion:
            'terminate saving if conditions are not satisfied
            '-----------------------------------------------------------------
            'refresh invoice numbering
            Dim vNumber As String
            Dim arr() As String = returnInvNum(cbVoucherType)
            voucPrefix = arr(0)
            voucID = arr(1)
            Dim dtPrefID As DataTable
            dtPrefID = retrieveTableFunction("SELECT Voucher_Prefix, Voucher_ID FROM tbVoucherTrans WHERE Reference_ID = '" & reference_Id & "'")

            If EditEntry = True Then
                vNumber = reference_Id
                If dtPrefID.Rows.Count = 0 Then
                Else
                    voucPrefix = dtPrefID.Rows(0).Item(0)
                    voucID = dtPrefID.Rows(0).Item(1)
                End If
                deleteRecordnoMsg(reference_Id)
            Else
                voucPrefix = arr(0)
                voucID = arr(1)
                vNumber = voucPrefix + voucID.ToString
            End If

            'validate for duplicate reference
            checkDuplicate(vNumber)

            '---------------------------------------------------------------end of validation

            'save voucher transaction to update instantly the invoice last entry
            saveVoucher(voucPrefix, voucID, dtDate, cbVoucherType, cbCostCenter, cbSupplier, tbTotalPrice, _
            tbDiscount, tbNet, tbReference, tbLPO, tbQuotation, tbNarration, dueDate, True, vNumber, Active_Year)

            'identify if return or not

            If vType = "Purchase" Then

                'save accounts transaction
                'save personal account (Supplier)

                saveAccount(cbVoucherType, cbSupplier, 0, tbNet, 0, _
                dtDate, dueDate, True, True, vNumber, Active_Year, usedCurrency, forexItem, "CR", 1)
                'save discount account
                saveAccount(cbVoucherType, "Purchase Discount", 0, Math.Abs(tbDiscount), 0, _
                dtDate, dueDate, True, True, vNumber, Active_Year, usedCurrency, forexItem, "CR", 1)

                'save personal accounts (creditors)
                Dim tAcc As Double = 0
                If dgLedger.RowCount = 0 Then
                Else
                    Dim accLedgerName As String
                    Dim accValue As Double
                    Dim counter As Integer = 0
                    For i = 0 To dgLedger.RowCount - 1
                        counter += 1
                        accLedgerName = dgLedger.Rows(i).Cells(0).Value.ToString
                        accValue = dgLedger.Rows(i).Cells(2).Value.ToString

                        saveAccount(cbVoucherType, accLedgerName, 0, Math.Abs(accValue), 0, _
                        dtDate, dueDate, True, False, vNumber, Active_Year, usedCurrency, forexLedger, "CR", counter)

                        tAcc += accValue
                    Next
                End If

                'save nominal account (Expense)
                saveAccount(cbVoucherType, cbAccRevenue, tbTotalPrice, 0, 0, _
                dtDate, dueDate, True, True, vNumber, Active_Year, usedCurrency, forexItem, "DR", 2)


                'save items transaction (Increase in Assets)

                For i = 0 To dgItems.RowCount - 1
                    Dim iPos As Integer = dgItems.Rows(i).Cells(0).Value
                    Dim iCode As String = dgItems.Rows(i).Cells(1).Value
                    Dim iDesc As String = dgItems.Rows(i).Cells(2).Value
                    Dim iQty As Double = dgItems.Rows(i).Cells(3).Value
                    Dim iUnit As String = dgItems.Rows(i).Cells(4).Value
                    Dim iCost As Double = dgItems.Rows(i).Cells(5).Value
                    Dim iTotal As Double = dgItems.Rows(i).Cells(6).Value
                    Dim iDisc As Double

                    'in case of inventory adjustment:
                    'nulify the value of discount
                    If tbTotalPrice = 0 Then
                        iDisc = 0
                    Else
                        iDisc = (iTotal / tbTotalPrice) * tbDiscount
                    End If

                    Dim iExp = (iTotal / tbTotalPrice) * tAcc
                    saveItemTrans(cbVoucherType, dtDate, iCode, iDesc, iQty, iUnit, _
                               iQty, 0, defLoc, 0, 0, iCost, iDisc, cbSupplier, True, _
                              voucPrefix + voucID.ToString, iPos, Active_Year, iTotal, iExp)
                Next


                'save reference if the account is maintaining balance
                saveReference(cbSupplier, voucPrefix + voucID.ToString, "CR", tbNet, tbNet, True, Active_Year)
            Else
                'save accounts transaction
                'save personal account (Supplier)
                saveAccount(cbVoucherType, cbSupplier, tbNet, 0, 0, _
                dtDate, dueDate, True, False, vNumber, Active_Year, usedCurrency, forexItem, "DR", 1)
                'save discount account
                saveAccount(cbVoucherType, "Purchase Discount", Math.Abs(tbDiscount), 0, 0, _
                dtDate, dueDate, True, True, vNumber, Active_Year, usedCurrency, forexItem, "DR", 1)

                'save personal accounts (creditors)
                Dim tAcc As Double = 0
                If dgLedger.RowCount = 0 Then
                Else
                    Dim accLedgerName As String
                    Dim accValue As Double
                    Dim counter As Integer = 0
                    For i = 0 To dgLedger.RowCount - 1
                        counter += 1
                        accLedgerName = dgLedger.Rows(i).Cells(0).Value.ToString
                        accValue = dgLedger.Rows(i).Cells(2).Value.ToString

                        saveAccount(cbVoucherType, accLedgerName, Math.Abs(accValue), 0, 0, _
                        dtDate, dueDate, True, False, vNumber, Active_Year, usedCurrency, forexLedger, "DR", counter)

                        tAcc += accValue
                    Next
                End If

                'save nominal account (Expense)
                saveAccount(cbVoucherType, cbAccRevenue, 0, tbTotalPrice, 0, _
                dtDate, dueDate, True, True, vNumber, Active_Year, usedCurrency, forexItem, "CR", 2)


                'save items transaction (Decrease in Assets)

                For i = 0 To dgItems.RowCount - 1
                    Dim iPos As Integer = dgItems.Rows(i).Cells(0).Value
                    Dim iCode As String = dgItems.Rows(i).Cells(1).Value
                    Dim iDesc As String = dgItems.Rows(i).Cells(2).Value
                    Dim iQty As Double = dgItems.Rows(i).Cells(3).Value
                    Dim iUnit As String = dgItems.Rows(i).Cells(4).Value
                    Dim iCost As Double = dgItems.Rows(i).Cells(5).Value
                    Dim iTotal As Double = dgItems.Rows(i).Cells(6).Value
                    Dim iDisc As Double
                    'in case of inventory adjustment:
                    'nulify the value of discount
                    If tbTotalPrice = 0 Then
                        iDisc = 0
                    Else
                        iDisc = (iTotal / tbTotalPrice) * tbDiscount
                    End If

                    Dim iExp = (iTotal / tbTotalPrice) * tAcc
                    saveItemTrans(cbVoucherType, dtDate, iCode, iDesc, iQty, iUnit, _
                              0, iQty, defLoc, 0, iTotal, iCost, iDisc, cbSupplier, True, _
                              voucPrefix + voucID.ToString, iPos, Active_Year, iTotal, iExp)
                Next


                'save reference if the account is maintaining balance
                saveReference(cbSupplier, voucPrefix + voucID.ToString, "CR", tbNet, tbNet, True, Active_Year)


                'Printing settings
                If printSave = True Then

                End If
                If printPreview = True Then
                    printInvoice(voucPrefix + voucID.ToString)
                End If
            End If

            EditEntry = False

            Dim pnl As New pnlPurchase(frmMain)
            pnl.swipe(True)
        Else

        End If
    End Sub
    Public Sub saveQuotation(ByVal cbVoucherType As String, ByVal cbCostCenter As String, _
    ByVal tbReference As String, ByVal tbQuotation As String, ByVal cbCustomer As String, ByVal tbLPO As String, _
    ByVal dtDate As Date, ByVal tbNarration As String, ByVal cbAccRevenue As String, ByVal tbTotalPrice As Double, _
    ByVal tbDiscount As Double, ByVal tbNet As Double, ByVal dueDate As Date, _
    ByVal dgItems As MetroFramework.Controls.MetroGrid, ByVal vType As String, ByVal Active_Year As Integer, _
    ByVal printSave As Boolean, ByVal printPreview As Boolean)

        'identify default location
        Dim defLoc As String
        defLoc = getDefaultLocation()

        'identify default currency
        Dim defcur As String
        defcur = getDefaultCurrency()

        Dim voucPrefix As String = Nothing
        Dim voucID As Integer = Nothing

        Dim savePrint = _
            MetroMessageBox.Show(frmMain, _
            "Do you want to save now?", "Save Sales Order", _
            MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If savePrint = DialogResult.Yes Then
            Dim vNumber As String
            'Validation portion:
            'terminate saving if conditions are not satisfied
            '-----------------------------------------------------------------
            'refresh invoice numbering
            Dim arr() As String = returnInvNum(cbVoucherType)
            Dim dtPrefID As DataTable
            dtPrefID = retrieveTableFunction("SELECT Voucher_Prefix, Voucher_ID FROM tbVoucherTrans WHERE Reference_ID = '" & reference_Id & "'")

            If EditEntry = True Then
                vNumber = reference_Id
                If dtPrefID.Rows.Count = 0 Then
                Else
                    voucPrefix = dtPrefID.Rows(0).Item(0)
                    voucID = dtPrefID.Rows(0).Item(1)
                End If
                deleteRecordnoMsg(reference_Id)
            Else
                voucPrefix = arr(0)
                voucID = arr(1)
                vNumber = voucPrefix + voucID.ToString
            End If

            'validate for duplicate reference
            checkDuplicate(vNumber)

            'check again if the stock quantity are sufficient
            'identify default location
            Dim itmCode As String
            Dim itmQty As Double
            Dim curVal As Double

            For i = 0 To dgItems.RowCount - 1
                itmCode = dgItems.Rows(i).Cells(1).Value.ToString
                itmQty = dgItems.Rows(i).Cells(3).Value
                curVal = getItemBalance(itmCode, defLoc)

                If itmQty > curVal Then
                    MetroMessageBox.Show(frmMain, "The item " + itmCode + _
                    ", " + "is now insufficient, please enter a lower quantity", _
                    "Insuficient Balance", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub
                End If
            Next

            '---------------------------------------------------------------end of validation

            'save voucher transaction to update instantly the invoice last entry
            saveVoucher(voucPrefix, voucID, dtDate, cbVoucherType, cbCostCenter, cbCustomer, tbTotalPrice, _
            tbDiscount, tbNet, tbReference, tbLPO, tbQuotation, tbNarration, dueDate, True, vNumber, Active_Year)

            'save items transaction (Increase in Assets)

            For i = 0 To dgItems.RowCount - 1
                Dim iPos As Integer = dgItems.Rows(i).Cells(0).Value
                Dim iCode As String = dgItems.Rows(i).Cells(1).Value
                Dim iDesc As String = dgItems.Rows(i).Cells(2).Value
                Dim iQty As Double = dgItems.Rows(i).Cells(3).Value
                Dim iUnit As String = dgItems.Rows(i).Cells(4).Value
                Dim iPrice As Double = dgItems.Rows(i).Cells(5).Value
                Dim iTotal As Double = dgItems.Rows(i).Cells(6).Value
                Dim iDisc As Double

                'in case of inventory adjustment:
                'nulify the value of discount
                If tbTotalPrice = 0 Then
                    iDisc = 0
                Else
                    iDisc = (iTotal / tbTotalPrice) * tbDiscount
                End If

                saveItemTrans(cbVoucherType, dtDate, iCode, iDesc, iQty, iUnit, _
                          iQty, 0, defLoc, iPrice, iTotal, 0, iDisc, cbCustomer, False, _
                          voucPrefix + voucID.ToString, iPos, Active_Year, 0, 0)
            Next


            'save reference if the account is maintaining balance
            saveReference(cbCustomer, voucPrefix + voucID.ToString, "CR", tbNet, tbNet, False, Active_Year)

            If printSave = True Then

                If printPreview = True Then
                    printInvoice(voucPrefix + voucID.ToString)
                End If
            End If

            EditEntry = False

            Dim pnl As New pnlQuotation(frmMain)
            pnl.swipe(True)
        Else

        End If

    End Sub
    Public Sub dgInvItemEdit(ByVal dgInvItem As MetroFramework.Controls.MetroGrid)
        Dim currPos As Integer = dgInvItem.CurrentRow.Index

        Dim newTotalPrice As Double
        Dim qty As Double
        Dim price As Double
        Try
            qty = dgInvItem.Rows(currPos).Cells(3).Value
            price = dgInvItem.Rows(currPos).Cells(5).Value
        Catch ex As Exception
            MetroMessageBox.Show(frmMain, "Invalid Entry: Please provide a valid integer", _
            "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgInvItem.Rows(currPos).Cells(3).Value = 0
        End Try

        newTotalPrice = qty * price
        dgInvItem.Rows(currPos).Cells(6).Value = newTotalPrice
    End Sub
    Public Sub dgInvItemEditPur(ByVal dgInvItem As MetroFramework.Controls.MetroGrid)
        Dim currPos As Integer = dgInvItem.CurrentRow.Index

        Dim newTotalPrice As Double
        Dim qty As Double
        Dim price As Double
        Try
            qty = dgInvItem.Rows(currPos).Cells(3).Value
            price = dgInvItem.Rows(currPos).Cells(5).Value
        Catch ex As Exception
            MetroMessageBox.Show(frmMain, "Invalid Entry: Please provide a valid integer", _
            "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgInvItem.Rows(currPos).Cells(3).Value = 0
            dgInvItem.Rows(currPos).Cells(5).Value = 0
        End Try

        newTotalPrice = qty * price
        dgInvItem.Rows(currPos).Cells(6).Value = newTotalPrice
    End Sub
    Public Function showBalance(ByVal iCode As String) As String
        Dim tipBalance As New ToolTip
        Dim retDt As New DataTable

        Dim dtFromItems As New DataTable
        dtFromItems.Columns.Add("Code")
        dtFromItems.Rows.Add(iCode)

        Dim retItemVal As New clsItems
        retItemVal.dtItems = dtFromItems
        retDt = retItemVal.generateTable()

        Dim strVal(retDt.Columns.Count - 1) As String
        For i = 0 To retDt.Rows.Count - 1

        Next


        Return ""

    End Function

    '------------------------------------------------
    'Destructor functions goes here
    'Dispose everything and empty memory cache
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
