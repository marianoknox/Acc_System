Imports MetroFramework

Public Class pnlJournal
    ' Dim dt As DataTable
    Dim dtDetails As New DataTable

    Private Sub pnlJournal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TbCostCenterListTableAdapter.Fill(Me.ACCDBDataSet.tbCostCenterList)
        Me.TbAccountsTableAdapter.Fill(Me.ACCDBDataSet.tbAccounts)
        Me.TbVouchersTableAdapter.FillJournal(Me.ACCDBDataSet.tbVouchers)
        Me.TbAccountTransTableAdapter.Fill(Me.ACCDBDataSet.tbAccountTrans)

        Dim arrDRCR() As String = {"DR", "CR"}
        cbDRCR.DataSource = arrDRCR

        Dim voucPrefix As String
        Dim voucID As Integer

        Dim arr() As String = returnInvNum("Journal")
        voucPrefix = arr(0)
        voucID = arr(1)

        lblInvNo.Text = voucPrefix + voucID.ToString

        CusSelected()


        'test variable for edit mode
        'use the same form for edit and new entry

        If EditEntry = True Then
            Dim arrDetails() As String
            arrDetails = getEditValues()
            selectCb(cbVoucherType, arrDetails(1))
            lblInvNo.Text = arrDetails(0)
            selectCb(cbCostCenter, arrDetails(2))
            tbReference.Text = arrDetails(4)
            dtDate.Text = arrDetails(7)



            'For iRow = 0 To dtItms.Rows.Count - 1

            '    For iCol = 0 To dtItms.Columns.Count - 1
            '        arrCol(iCol) = dtItms.Rows(iRow).Item(iCol)
            '    Next

            '    dgInvItem.Rows.Add(arrCol)
            'Next
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

        Dim arrDetails(9) As String
        For Each vchr In filterVoucher
            arrDetails(0) = vchr.Field(Of String)("Reference_ID")
            arrDetails(1) = vchr.Field(Of String)("Voucher_Name")
            arrDetails(2) = vchr.Field(Of String)("Cost_Center")
            'arrDetails(3) = getAccountLedger()
            arrDetails(4) = vchr.Field(Of String)("Voucher_Reference")
            arrDetails(5) = vchr.Field(Of String)("Voucher_Quot")
            arrDetails(6) = vchr.Field(Of String)("Voucher_LPO")
            arrDetails(7) = vchr.Field(Of Date)("Voucher_Date")
            arrDetails(8) = vchr.Field(Of Double)("Voucher_Discount")
            arrDetails(9) = vchr.Field(Of String)("Account_Name")
        Next

        Return arrDetails
    End Function
    Private Sub CusSelected()
        Dim TCR As Double = 0
        Dim TDR As Double = 0
        Dim tBal As Double = 0

        'Get the total values against the selected account
        'the values are: debit, credit and opening values
        Dim sumCR = Aggregate cr In Me.ACCDBDataSet.tbAccountTrans.AsEnumerable
                    Where cr.Field(Of String)("Account_Name") = cbAccount.Text _
                    Into Sum(cr.Field(Of Double)("Voucher_Credit"))

        Dim sumDR = Aggregate cr In Me.ACCDBDataSet.tbAccountTrans.AsEnumerable
                    Where cr.Field(Of String)("Account_Name") = cbAccount.Text _
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
    Private Sub btnAddAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAccount.Click
        'validate entries
        Dim pass = validateNumber(tbAmount.Text)
        If pass = False Then
            Exit Sub
        End If

        Dim counter As Integer = dgJournal.Rows.Count + 1
        Dim amt As Double = tbAmount.Text

        If cbDRCR.Text = "DR" Then
            dgJournal.Rows.Add(counter, cbDRCR.Text, cbAccount.Text, amt, "")
        Else
            dgJournal.Rows.Add(counter, cbDRCR.Text, cbAccount.Text, "", amt)
        End If

        computeDRCR()
    End Sub
    Private Sub cmAccounts_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmAccounts.Opening
        contextOpening(dgJournal, cmAccounts)
    End Sub
    Private Sub showReference()
        Dim accName As String
        If dgJournal.CurrentRow.Cells(2).Value = "" Then
            Exit Sub
        Else
            accName = dgJournal.CurrentRow.Cells(2).Value
        End If

        Dim getRef = From ref In TbAccountsTableAdapter.GetData.AsEnumerable
                     Where ref.Field(Of String)("Account_Name") = accName
                     Select ref.Field(Of Boolean)("Maintain_Balance")

        For Each ref In getRef
            If ref = False Then
                MetroMessageBox.Show(frmMain, "This account was not set to maintain balance. " & _
                " If you want to use references Bill by Bill, set the property to maintain balance " & _
                " under Account Creation Masters", "Reference not available", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else

            End If
        Next

        Dim dt As New DataTable
        dt = Me.TbReferenceTableAdapter.GetData

        dgItemSelect.Rows.Clear()
        Dim filterAcc = From acc In dt.AsEnumerable
                        Where acc.Field(Of String)("Account_Name") = accName _
                        And acc.Field(Of Boolean)("isOutstanding") = True _
                        Select acc

        If filterAcc.Count = 0 Then
            Exit Sub
        End If

        For Each row In filterAcc
            Dim ref = row.Field(Of String)("Reference_ID")
            Dim amts As Double = row.Field(Of Double)("Reference_Amount")
            Dim asCRDR As String = row.Field(Of String)("asCRDR")

            dgItemSelect.Rows.Add(asCRDR, ref, amts)
        Next
    End Sub
    Private Sub cmsAddRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsAddRef.Click
        showReference()

        Dim pointX As Integer = pnlAgainstRef.Location.X
        Dim pointY As Integer = pnlAgainstRef.Location.Y

        If pointX > 840 Then
            For i = 0 To 72
                pointX -= 5
                pnlAgainstRef.Location = New Point(pointX, pointY)
            Next
        End If
    End Sub
    Private Sub dgJournal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgJournal.Click
        Dim pointX As Integer = pnlAgainstRef.Location.X
        Dim pointY As Integer = pnlAgainstRef.Location.Y

        If pointX < 1200 Then
            For i = 0 To 72
                pointX += 5
                pnlAgainstRef.Location = New Point(pointX, pointY)
            Next
        End If
    End Sub
    Private Sub cmsRemoveAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsRemoveAcc.Click
        dgJournal.Rows.Remove(dgJournal.CurrentRow)
    End Sub
    Private Sub btnSaveInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveInv.Click
        Dim savePrint = _
          MetroMessageBox.Show(frmMain, _
          "Do you want to save now?", "Save Journal", _
          MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If savePrint = DialogResult.Yes Then
            'identify default currency
            Dim defcur As String
            defcur = getDefaultCurrency()


            Dim voucPrefix As String
            Dim voucID As Integer

            Dim arr() As String = returnInvNum("Journal")
            voucPrefix = arr(0)
            voucID = arr(1)

            'save voucher transaction to update instantly the invoice last entry
            saveVoucher(voucPrefix, voucID, dtDate.Text, cbVoucherType.Text, cbCostCenter.Text, dgJournal.Rows(0).Cells(2).Value, tbTotalDR.Text, _
            0, 0, tbReference.Text, "", "", tbNarration.Text, dtDate.Text, True, voucPrefix + voucID.ToString, frmMain.lblActiveYear.Text)

            Dim accAs As String
            Dim accName As String
            Dim accValue As Double
            Dim accNum As Integer

            For i = 0 To dgJournal.Rows.Count - 1

                accAs = dgJournal.Rows(i).Cells(1).Value.ToString
                accName = dgJournal.Rows(i).Cells(2).Value.ToString
                accNum = dgJournal.Rows(i).Cells(0).Value

                If accAs = "DR" Then
                    accValue = dgJournal.Rows(i).Cells(3).Value.ToString
                    'save DR account
                    saveAccount(cbVoucherType.Text, accName, accValue, 0, 0, _
                    dtDate.Text, dtDate.Text, True, False, voucPrefix + voucID.ToString, _
                    frmMain.lblActiveYear.Text, defcur, 1, accAs, accNum)
                Else
                    accValue = dgJournal.Rows(i).Cells(4).Value.ToString
                    'save CR account
                    saveAccount(cbVoucherType.Text, accName, 0, accValue, 0, _
                    dtDate.Text, dtDate.Text, True, False, voucPrefix + voucID.ToString, _
                    frmMain.lblActiveYear.Text, defcur, 1, accAs, accNum)
                End If
            Next

            Dim pnl As New pnlJournal(frmMain)
            pnl.swipe(True)
        End If
    End Sub
    Private Sub dgJournal_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgJournal.CellEndEdit
        computeDRCR()
    End Sub
    Private Sub computeDRCR()
        Dim DR As Double = 0
        Dim CR As Double = 0
        Dim tDR As Double = 0
        Dim tCR As Double = 0

        For I = 0 To dgJournal.Rows.Count - 1
            Try
                DR = dgJournal.Rows(I).Cells(3).Value
            Catch ex As Exception
                DR = 0
            End Try
            Try
                CR = dgJournal.Rows(I).Cells(4).Value
            Catch ex As Exception
                CR = 0
            End Try

            tDR += DR
            tCR += CR
        Next

        tbTotalDR.Text = tDR
        tbTotalCR.Text = tCR

        If tDR = tCR Then
            btnSaveInv.Enabled = True
        Else
            btnSaveInv.Enabled = False
        End If

    End Sub
    Private Sub tbCustomer_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbAccSearch.TextChanged
        Me.TbAccountsTableAdapter.FilterAccounts(Me.ACCDBDataSet.tbAccounts, tbAccSearch.Text)
        CusSelected()
    End Sub
    Private Sub lnkDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkDetails.Click
        pnlAccDetails.Visible = True
    End Sub
    Private Sub MetroLink2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroLink2.Click
        pnlAccDetails.Visible = False
    End Sub
    Private Sub cbAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAccount.SelectedIndexChanged
        CusSelected()
    End Sub
End Class
