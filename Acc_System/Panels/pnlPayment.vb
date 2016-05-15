Imports MetroFramework

Public Class pnlPayment

    Dim vType As String
    Dim dtRef As New DataTable
    Dim dtSaveRef As New DataTable
    Private Sub pnlPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Initialize all the tables and put them over the instance
        'fill combobox for voucher
        Dim getPayment = From pay In Me.TbVouchersTableAdapter.GetData.AsEnumerable _
                         Where pay.Field(Of String)("Voucher_Type") = "Payment"
                         Select pay.Field(Of String)("Voucher_Name")

        Dim vName(0) As String
        For Each getP In getPayment
            vName(0) = getP
        Next

        cbVoucherType.DataSource = vName
        cbVoucherType.DisplayMember = "Voucher_Name"

        'fill combobox for accounts payable
        Dim getAcc As New DataTable

        getAcc = retrieveTableFunction("SELECT Account_Name FROM tbAccounts")

        cbAccount.DataSource = getAcc
        cbAccount.DisplayMember = "Account_Name"


        Me.TbCostCenterListTableAdapter.Fill(Me.ACCDBDataSet.tbCostCenterList)
        Me.TbAccountsTableAdapter.Fill(Me.ACCDBDataSet.tbAccounts)
        Me.TbAccountTransTableAdapter.Fill(Me.ACCDBDataSet.tbAccountTrans)

        'fill secondary account
        cbAccount.DataSource = Me.TbAccountsTableAdapter.GetData
        cbAccount.DisplayMember = "Account_Name"

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
        payeeSelected()
        payableSelected()

        'Columns for reference computation
        dtRef.Rows.Clear()
        dtRef.Columns.Add("Account_Name")
        dtRef.Columns.Add("Reference_ID")
        dtRef.Columns.Add("Ref_Debit")
        dtRef.Columns.Add("Ref_Credit")
        dtRef.Columns.Add("isOutstanding")

        'columns for reference saving
        dtSaveRef.Rows.Clear()
        dtSaveRef.Columns.Add("Account_Name")
        dtSaveRef.Columns.Add("Reference_ID")
        dtSaveRef.Columns.Add("Ref_Debit")
        dtSaveRef.Columns.Add("Ref_Credit")
        dtSaveRef.Columns.Add("isOutstanding")
    End Sub
    Private Sub payeeSelected()
        Dim TCR As Double = 0
        Dim TDR As Double = 0
        Dim tBal As Double = 0


        'Get the total values against the selected account
        'the values are: debit, credit and opening values
        Dim sumCR = Aggregate cr In Me.ACCDBDataSet.tbAccountTrans.AsEnumerable
                    Where cr.Field(Of String)("Account_Name") = cbMainAccount.Text _
                    Into Sum(cr.Field(Of Double)("Voucher_Credit"))

        Dim sumDR = Aggregate cr In Me.ACCDBDataSet.tbAccountTrans.AsEnumerable
                    Where cr.Field(Of String)("Account_Name") = cbMainAccount.Text _
                    Into Sum(cr.Field(Of Double)("Voucher_Debit"))

        TCR = sumCR
        TDR = sumDR

        If TCR > TDR Then
            tbDRCRMain.Text = "CR"
        Else
            tbDRCRMain.Text = "DR"
        End If
        tBal = Math.Abs(TDR - TCR)

        tbMainAccBalance.Text = FormatNumber(tBal)
    End Sub
    Private Sub payableSelected()
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
            tbDRCRAcc.Text = "CR"
        Else
            tbDRCRAcc.Text = "DR"
        End If
        tBal = Math.Abs(TDR - TCR)

        tbBalance.Text = FormatNumber(tBal)
    End Sub
    Private Sub tbMainAccSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbMainAccSearch.TextChanged
        Me.TbAccountsTableAdapter.FilterAccounts(Me.ACCDBDataSet.tbAccounts, tbMainAccSearch.Text)
        payeeSelected()
    End Sub
    Private Sub tbAccSearch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbAccSearch.TextChanged
        'filter combobox for accounts payable
        Dim getAcc As New DataTable

        getAcc = retrieveTableFunction("SELECT Account_Name FROM tbAccounts WHERE Account_Name LIKE '%" & _
                                       tbAccSearch.Text & "%'")

        cbAccount.DataSource = getAcc
        cbAccount.DisplayMember = "Account_Name"
        payableSelected()
    End Sub
    Private Sub btnAddAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAccount.Click
        Dim counter As Integer = 1
        counter += dgPayment.Rows.Count

        Dim amt As Double
        Try
            amt = tbAmount.Text
        Catch ex As Exception
            MetroMessageBox.Show(frmMain, "Invalid Amount. Please enter valid value", _
            "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try

        dgPayment.Rows.Add(counter, cbAccount.Text, amt)
        computeTotal()
        addReference()

        'Current display to last row
        dgPayment.FirstDisplayedScrollingRowIndex = dgPayment.RowCount - 1

        'Select the last row.
        dgPayment.Rows(dgPayment.RowCount - 1).Selected = True
        getReference(cbAccount.Text)
    End Sub
    Private Sub addReference()

        Dim getRef = From ref In Me.TbAccountTransTableAdapter.GetData.AsEnumerable _
                     Where ref.Field(Of String)("Account_Name") = cbAccount.Text _
                     And ref.Field(Of Boolean)("isOutstanding") = True _
                     Select ref

        If dtRef.Rows.Count = 0 Then
        Else
            For i = 0 To dtRef.Rows.Count - 1
                If dtRef.Rows(i).Item("Account_Name") = cbAccount.Text Then
                    Exit Sub
                Else
                End If
            Next
        End If
        Dim accName As String
        Dim accRef As String
        Dim accDebit As Double
        Dim accCredit As Double
        Dim accOutstanding As Boolean

        For Each gref In getRef
            accName = gref.Field(Of String)("Account_Name")
            accRef = gref.Field(Of String)("Reference_ID")
            accDebit = gref.Field(Of Double)("Voucher_Debit")
            accCredit = gref.Field(Of Double)("Voucher_Credit")
            accOutstanding = gref.Field(Of Boolean)("isOutstanding")
            dtRef.Rows.Add(accName, accRef, accDebit, accCredit, accOutstanding)
        Next

        DataGridView1.DataSource = dtRef
    End Sub
    Private Sub cmsRemoveAcc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsRemoveAcc.Click
        Dim removal = MetroMessageBox.Show(frmMain, _
        "Are you sure you want to remove this entry?", "Entry Remove", _
        MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If removal = DialogResult.Yes Then
            dgPayment.Rows.Remove(dgPayment.CurrentRow)
            itemNumbering(dgPayment)
        End If

        computeTotal()
    End Sub
    Private Sub computeTotal()
        Dim amt As Double
        If dgPayment.Rows.Count = 0 Then
        Else
            For i = 0 To dgPayment.Rows.Count - 1
                amt += dgPayment.Rows(i).Cells(2).Value
            Next

            tbTotal.Text = amt
        End If

    End Sub
    Public Sub itemNumbering(ByVal dgInvItem As MetroFramework.Controls.MetroGrid)
        Dim counter As Integer = 1
        For i = 0 To dgPayment.Rows.Count - 1
            dgPayment.Rows(i).Cells(0).Value = counter
            counter += 1
        Next
    End Sub
    Private Sub cmAccounts_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmAccounts.Opening
        contextOpening(dgPayment, cmAccounts)
    End Sub
    Private Sub btnSaveInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveInv.Click
        If dgPayment.Rows.Count = 0 Then
            MetroMessageBox.Show(frmMain, _
            "Empty Voucher: Saving has been cancelled?", "Save Cancel", _
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

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

            Dim arr() As String = returnInvNum("Payment")
            voucPrefix = arr(0)
            voucID = arr(1)

            'save voucher transaction to update instantly the invoice last entry
            saveVoucher(voucPrefix, voucID, dtDate.Text, cbVoucherType.Text, cbCostCenter.Text, cbMainAccount.Text, tbTotal.Text, _
            0, 0, tbReference.Text, "", "", tbNarration.Text, dtDate.Text, True, voucPrefix + voucID.ToString, frmMain.lblActiveYear.Text)

            Dim accName As String
            Dim accValue As Double
            Dim accNum As Integer

            'save payee account
            accName = cbMainAccount.Text
            accValue = tbTotal.Text


            saveAccount(cbVoucherType.Text, accName, 0, accValue, 0, _
            dtDate.Text, dtDate.Text, True, False, voucPrefix + voucID.ToString, _
            frmMain.lblActiveYear.Text, defcur, 1, "CR", 1)


            'save payable accounts
            For i = 0 To dgPayment.Rows.Count - 1
                accNum = dgPayment.Rows(i).Cells(0).Value
                accName = dgPayment.Rows(i).Cells(1).Value.ToString
                accValue = dgPayment.Rows(i).Cells(2).Value

                saveAccount(cbVoucherType.Text, accName, accValue, 0, 0, _
                dtDate.Text, dtDate.Text, True, False, voucPrefix + voucID.ToString, _
                frmMain.lblActiveYear.Text, defcur, 1, "DR", accNum)

            Next

            Dim pnl As New pnlPayment(frmMain)
            pnl.swipe(True)
        End If
    End Sub
    Private Sub cbMainAccount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbMainAccount.TextChanged
        payeeSelected()
    End Sub
    Private Sub cbAccount_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAccount.TextChanged
        payableSelected()
    End Sub
    Private Sub getSaveRef()
        Dim accName As String = dgPayment.CurrentRow.Cells(1).Value
        Dim vchNo As String = dgRef.CurrentRow.Cells(0).Value
        Dim accDebit As Double = dgRef.CurrentRow.Cells(1).Value
        Dim accCredit As Double = dgRef.CurrentRow.Cells(2).Value
        Dim isOutstanding As Boolean = dgRef.CurrentRow.Cells(3).Value

        Dim removeDuplicate = From iTable In dtRef.AsEnumerable _
                              Where iTable.Field(Of String)("Reference_ID") = vchNo _
                              Select iTable.Field(Of String)("Reference_ID")

        If dtSaveRef.Rows.Count = 0 Then
            dtSaveRef.Rows.Add(accName, vchNo, accDebit, accCredit, isOutstanding)
            Exit Sub
        End If

        For Each dup In removeDuplicate
            For i = 0 To dtSaveRef.Rows.Count
                If dup = dtSaveRef.Rows(i).Item("Reference_ID") Then
                    dtSaveRef.Rows.Remove(dtSaveRef.Rows(i))
                End If
                dtSaveRef.Rows.Add(accName, vchNo, accDebit, accCredit, isOutstanding)
            Next
        Next

        DataGridView2.DataSource = dtSaveRef

    End Sub
    Private Sub dgPayment_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgPayment.SelectionChanged
        getReference(dgPayment.CurrentRow.Cells(1).Value.ToString)
    End Sub
    Private Sub getReference(ByVal accName As String)

        'account name is declare because the current row != selected row
        Dim accDtRef = From ref In dtRef.AsEnumerable _
                       Where ref.Field(Of String)("Account_Name") = accName _
                       Select ref

        dgRef.Rows.Clear()
        Dim accRef As String
        Dim accDebit As Double
        Dim accCredit As Double
        Dim accOutstanding As Boolean

        For Each refRow In accDtRef
            accRef = refRow.Field(Of String)("Reference_ID")
            accDebit = refRow.Field(Of String)("Ref_Debit")
            accCredit = refRow.Field(Of String)("Ref_Credit")
            accOutstanding = refRow.Field(Of String)("isOutstanding")

            dgRef.Rows.Add(accRef, accDebit, accCredit, accOutstanding)

        Next
    End Sub
    Private Sub dgRef_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgRef.Validated
        getSaveRef()
    End Sub
End Class
