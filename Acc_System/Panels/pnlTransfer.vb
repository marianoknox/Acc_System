Imports MetroFramework

Public Class pnlTransfer
    Dim editMode As Boolean = False

    Private Sub pnlTransfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TbVouchersTableAdapter.FillTrans(Me.ACCDBDataSet.tbVouchers)
        Me.TbCostCenterListTableAdapter.Fill(Me.ACCDBDataSet.tbCostCenterList)

        'Calls the method for index select in voucher type
        'returns initial invoice number
        Dim arr() As String = returnInvNum(cbVoucherType.Text)
        lblInvNo.Text = arr(0).ToString + arr(1).ToString

        Dim dtLoc As DataTable
        Dim dtLoc1 As DataTable
        dtLoc = retrieveTableFunction("SELECT itm_Location FROM tbLocationList")
        dtLoc1 = dtLoc.Copy
        cbFrom.DataSource = dtLoc
        cbFrom.DisplayMember = "itm_Location"
        cbTo.DataSource = dtLoc1
        cbTo.DisplayMember = "itm_Location"

        'fill datagrid view for item selection
        dgItemSelect.DataSource = retrieveTableFunction( _
            "SELECT itm_Code AS Code, itm_Desc AS Descrition, " & _
            "itm_Unit AS Unit FROM tbItems")

    End Sub
    Private Sub tbItemSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbItemSearch.TextChanged
        'fill datagrid view for item selection
        dgItemSelect.DataSource = retrieveTableFunction( _
            "SELECT itm_Code AS Code, itm_Desc AS Descrition, " & _
            "itm_Unit AS Unit FROM tbItems WHERE itm_Desc LIKE '%" & tbItemSearch.Text & "%'")

    End Sub
    Private Sub dgItemSelect_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgItemSelect.KeyDown
        If e.KeyCode = Keys.Enter Then
            addItems()
        End If
    End Sub
    Private Sub btnAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAccept.Click
        addItems()
    End Sub
    Private Sub addItems()
        Dim iNum As Integer = 0
        Dim iCode As String = dgItemSelect.CurrentRow.Cells(0).Value.ToString
        Dim iDesc As String = dgItemSelect.CurrentRow.Cells(1).Value.ToString
        Dim iQty As Double
        Dim iUnit As String = dgItemSelect.CurrentRow.Cells(2).Value.ToString

        Try
            iQty = tbQuantitySelect.Text
        Catch ex As Exception
            MetroMessageBox.Show(frmMain, "Invalid Item Quantity", _
            "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)

            tbQuantitySelect.Text = 1
            Exit Sub
        End Try

        If iQty = 0 Then
            MetroMessageBox.Show(frmMain, "Item quantity must be atleast 1", _
           "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)

            tbQuantitySelect.Text = 1
            Exit Sub
        End If


        iNum = dgTrans.Rows.Count + 1

        If editMode = True Then
            dgTrans.CurrentRow.SetValues(dgTrans.CurrentRow.Index + 1, iCode, iDesc, iQty, iUnit)
            pnlEditMode.Visible = False
        Else
            dgTrans.Rows.Add(iNum, iCode, iDesc, iQty, iUnit)
        End If

        'Current display to last row
        dgTrans.FirstDisplayedScrollingRowIndex = dgTrans.RowCount - 1

        'Select the last row.
        dgTrans.Rows(dgTrans.RowCount - 1).Selected = True
        getClosingItemBal(iCode)
    End Sub
    Private Sub cmInv_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmInv.Opening
        contextOpening(dgTrans, cmInv)
    End Sub
    Private Sub getClosingItemBal(ByVal itmCode)

        If dgTrans.RowCount = 0 Then
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
    Private Sub dgTrans_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgTrans.CellEndEdit
        Dim iVal As Double
        Try
            iVal = dgTrans.CurrentRow.Cells(3).Value
        Catch ex As Exception
            MetroMessageBox.Show(frmMain, "Invalid Item Quantity", _
            "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)

            dgTrans.CurrentRow.Cells(3).Value = 0
        End Try
    End Sub
    Private Sub dgTrans_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgTrans.SelectionChanged
        If dgTrans.RowCount = 0 Then
            Exit Sub
        End If
        getClosingItemBal(dgTrans.CurrentRow.Cells(1).Value)
    End Sub
    Private Sub cmsRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsRemove.Click
        Dim removal = MetroMessageBox.Show(frmMain, _
       "Are you sure you want to remove this item?", "Item Remove", _
       MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If removal = DialogResult.Yes Then
            dgTrans.Rows.Remove(dgTrans.CurrentRow)
            itemNumbering(dgTrans)
        End If
    End Sub
    Private Sub cmsEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsEdit.Click
        pnlEditMode.Visible = True
        editMode = True
    End Sub
    Private Sub btnCancelEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelEdit.Click
        pnlEditMode.Visible = False
        editMode = False
    End Sub
    Private Sub btnSaveInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveInv.Click
        If dgTrans.RowCount = 0 Then
            MetroMessageBox.Show(frmMain, _
          "Nothing to save", "Void Transfer", _
          MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim savePrint = _
           MetroMessageBox.Show(frmMain, _
           "Do you want to save now?", "Save Transfer", _
           MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If savePrint = DialogResult.Yes Then

            'Validation portion:
            'terminate saving if conditions are not satisfied
            '-----------------------------------------------------------------
            'refresh invoice numbering
            Dim voucPrefix As String
            Dim voucID As Integer

            Dim arr() As String = returnInvNum(cbVoucherType.Text)
            voucPrefix = arr(0)
            voucID = arr(1)
            Dim vNumber As String = voucPrefix + voucID.ToString

            'check again if the stock quantity are sufficient
            'identify default location
            Dim itmCode As String
            Dim itmQty As Double
            Dim curVal As Double
            Dim defLoc As String = cbFrom.Text

            For i = 0 To dgTrans.RowCount - 1
                itmCode = dgTrans.Rows(i).Cells(1).Value.ToString
                itmQty = dgTrans.Rows(i).Cells(3).Value
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
            saveVoucher(voucPrefix, voucID, dtInvDate.Text, cbVoucherType.Text, cbCostCenter.Text, "", 0, _
            0, 0, tbReference.Text, "", "", tbNarration.Text, dtInvDate.Text, False, vNumber, frmMain.lblActiveYear.Text)

            'save items transaction (Increase in Assets)

            For i = 0 To dgTrans.RowCount - 1
                Dim iPos As Integer = dgTrans.Rows(i).Cells(0).Value
                Dim iCode As String = dgTrans.Rows(i).Cells(1).Value
                Dim iDesc As String = dgTrans.Rows(i).Cells(2).Value
                Dim iQty As Double = dgTrans.Rows(i).Cells(3).Value
                Dim iUnit As String = dgTrans.Rows(i).Cells(4).Value

                'save items going to
                saveItemTrans(cbVoucherType.Text, dtInvDate.Text, iCode, iDesc, iQty, iUnit, _
                          iQty, 0, cbTo.Text, 0, 0, 0, 0, "", False, _
                          vNumber, iPos, frmMain.lblActiveYear.Text, 0, 0)

                'save items coming from
                saveItemTrans(cbVoucherType.Text, dtInvDate.Text, iCode, iDesc, iQty, iUnit, _
                          0, iQty, cbFrom.Text, 0, 0, 0, 0, "", False, _
                          vNumber, iPos, frmMain.lblActiveYear.Text, 0, 0)
            Next

            Dim pnl As New pnlTransfer(frmMain)
            pnl.swipe(True)
        End If
    End Sub
    Private Sub tbQuantitySelect_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbQuantitySelect.KeyDown
        If e.KeyCode = Keys.Enter Then
            addItems()
        End If
    End Sub
End Class
