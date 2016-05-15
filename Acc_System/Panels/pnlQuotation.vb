Imports MetroFramework

Public Class pnlQuotation

    Dim invCls As New clsSalesInvoice
    Dim editMode As Boolean = False

    Private Sub pnlQuotation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbTotalPrice.Text = 0

        'Initialize all the tables and them over the instance
        Me.TbVouchersTableAdapter.FillQuotation(Me.ACCDBDataSet.tbVouchers)
        Me.TbCostCenterListTableAdapter.Fill(Me.ACCDBDataSet.tbCostCenterList)
        Me.TbAccountsTableAdapter.Fill(Me.ACCDBDataSet.tbAccounts)
        Me.TbAccountTransTableAdapter.Fill(Me.ACCDBDataSet.tbAccountTrans)
        Me.TbItemsTableAdapter.Fill(Me.ACCDBDataSet.tbItems)
        Me.TbLocationListTableAdapter.Fill(Me.ACCDBDataSet.tbLocationList)
        Me.TbItemTransTableAdapter.Fill(Me.ACCDBDataSet.tbItemTrans)
        Me.TbVoucherTransTableAdapter.Fill(Me.ACCDBDataSet.tbVoucherTrans)

        'Calls the method for index select in voucher type
        'returns initial invoice number
        Dim arr() As String = returnInvNum(cbVoucherType.Text)
        lblInvNo.Text = arr(0).ToString + arr(1).ToString

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
            tbReference.Text = arrDetails(3)
            tbLPO.Text = arrDetails(4)
            dtInvDate.Text = arrDetails(5)
            tbDiscAmt.Text = arrDetails(6)
            selectCb(cbCustomer, arrDetails(7))
            tbNarration.Text = arrDetails(8)

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
    End Sub
    Private Sub selectCb(ByVal cb As MetroFramework.Controls.MetroComboBox, ByVal strFind As String)
        Dim index As Integer = cb.FindString(strFind)
        cb.SelectedIndex = index
    End Sub
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
            arrDetails(3) = vchr.Field(Of String)("Voucher_Reference")
            arrDetails(4) = vchr.Field(Of String)("Voucher_LPO")
            arrDetails(5) = vchr.Field(Of Date)("Voucher_Date")
            arrDetails(6) = vchr.Field(Of Double)("Voucher_Discount")
            arrDetails(7) = vchr.Field(Of String)("Account_Name")
            arrDetails(8) = vchr.Field(Of String)("Voucher_Narration")
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
    ByVal e As System.EventArgs)
        invCls.HideSelection(pnlItemsInv)
    End Sub
    Private Sub btnSaveInv_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles btnSaveInv.Click
      
        'check for null reference
        If dgInvItem.RowCount = 0 Then
            MetroMessageBox.Show(frmMain, "Invoice is Empty.", "Null Invoice", _
            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        invCls.saveQuotation(cbVoucherType.Text, cbCostCenter.Text, tbReference.Text, "", _
        cbCustomer.Text, tbLPO.Text, dtInvDate.Text, tbNarration.Text, "", tbTotalPrice.Text, _
        tbDiscAmt.Text, tbNetAmount.Text, dtInvDate.Text, dgInvItem, "", _
        frmMain.lblActiveYear.Text, chkPrint.CheckState, chkPrintPreview.CheckState)
    End Sub
    Private Sub tbItemSearch_TextChanged(ByVal sender As Object, _
    ByVal e As System.EventArgs)
        invCls.searchItem(dgItemSelect, tbItemSearch.Text)
    End Sub
    Private Sub btnAccept_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs)
        editMode = invCls.addInvoiceItem(tbQuantitySelect.Text, dgInvItem, dgItemSelect, editMode, pnlEditMode)
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
    End Sub
    Private Sub cmsRemove_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles cmsRemove.Click
        Dim removal = MetroMessageBox.Show(frmMain, _
        "Are you sure you want to remove this item?", "Item Remove", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If removal = DialogResult.Yes Then
            dgInvItem.Rows.Remove(dgInvItem.CurrentRow)
            invCls.itemNumbering(dgInvItem)
        End If
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
    ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgInvItem.CellValueChanged
        If dgInvItem.Rows.Count < 1 Then
        Else
            tbTotalPrice.Text = invCls.totalComp(dgInvItem)
        End If
    End Sub
    Private Sub cmsEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsEdit.Click
        pnlEditMode.Visible = True
        invCls.ShowSelection(pnlItemsInv)
        editMode = True
    End Sub
    Private Sub btnCancelEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelEdit.Click
        pnlEditMode.Visible = False
        invCls.HideSelection(pnlItemsInv)
        editMode = False
    End Sub
    Private Sub cbVoucherType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbVoucherType.SelectedIndexChanged
        'fill again the table before getting the invoice number
        Me.TbVoucherTransTableAdapter.Fill(Me.ACCDBDataSet.tbVoucherTrans)

        'get invoice number
        Dim arr() As String = returnInvNum(cbVoucherType.Text)
        Try
            lblInvNo.Text = arr(0).ToString + arr(1).ToString
        Catch ex As Exception
            'it catches a null reference when closing
            'dispose the command when returned null
            Exit Sub
        End Try
    End Sub
    Private Sub dgInvItem_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgInvItem.CellEndEdit
        invCls.dgInvItemEdit(dgInvItem)
    End Sub
    Private Sub tbTotalPrice_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbTotalPrice.TextChanged
        tbNetAmount.Text = invCls.netCompute(tbTotalPrice.Text, tbDiscAmt.Text)
    End Sub
    Private Sub tbDiscAmt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbDiscAmt.KeyDown
        If e.KeyCode = Keys.Enter Then
            tbNetAmount.Text = invCls.validateDiscount(tbDiscAmt, tbTotalPrice.Text)
            tbNarration.Focus()
        End If
    End Sub
    Private Sub tbDiscAmt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbDiscAmt.LostFocus
        tbDiscAmt_KeyDown(sender, e)
    End Sub
    Private Sub tbItemSearch_TextChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbItemSearch.TextChanged
        invCls.searchItem(dgItemSelect, tbItemSearch.Text)
    End Sub

    Private Sub btnAccept_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        editMode = invCls.addInvoiceItem(tbQuantitySelect.Text, _
        dgInvItem, dgItemSelect, editMode, pnlEditMode)

        getClosingItemBal(dgItemSelect.CurrentRow.Cells(0).Value)
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
    Private Sub dgItemSelect_KeyDown(ByVal sender As Object, _
   ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgItemSelect.KeyDown
        If e.KeyCode = Keys.Enter Then
            editMode = invCls.addInvoiceItem(tbQuantitySelect.Text, _
            dgInvItem, dgItemSelect, editMode, pnlEditMode)

            getClosingItemBal(dgItemSelect.CurrentRow.Cells(0).Value)
        End If
    End Sub
    Private Sub dgInvItem_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgInvItem.SelectionChanged
        If dgInvItem.RowCount = 0 Then
            Exit Sub
            tbStoreQty.Text = 0
            tbShowroomQty.Text = 0
        End If
        getClosingItemBal(dgInvItem.CurrentRow.Cells(1).Value)
    End Sub
End Class
