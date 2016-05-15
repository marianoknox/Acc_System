Public Class pnlTrialBalance
    Private Sub pnlTrialBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        dgTrial.Rows.Clear()

        Dim returnTrial = (From Acc In Me.TbAccountsTableAdapter.GetData _
                          Join AccTrans In Me.TbAccountTransTableAdapter.GetData _
                          On Acc.Field(Of String)("Account_Name") Equals AccTrans.Field(Of String)("Account_Name") _
                          Where (AccTrans.Field(Of Date)("Voucher_Date") >= dtStart.Text _
                          And AccTrans.Field(Of Date)("Voucher_Date") <= dtEnd.Text) _
                          Group By ac = Acc.Field(Of String)("Account_Name") _
                          Into TotalDebit = Sum(AccTrans.Field(Of Double)("Voucher_Debit")), TotalCredit = Sum(AccTrans.Field(Of Double)("Voucher_Credit"))
                          Select ac, TotalDebit, TotalCredit)


        Dim arr(2) As String
        For Each retTrial In returnTrial
            arr(0) = retTrial.ac
            arr(1) = retTrial.TotalDebit
            arr(2) = retTrial.TotalCredit

            dgTrial.Rows.Add(arr)
        Next

        Dim tDebit As Double
        Dim tCredit As Double

        For i = 0 To dgTrial.RowCount - 1
            tDebit += dgTrial.Rows(i).Cells(1).Value
            tCredit += dgTrial.Rows(i).Cells(2).Value
        Next

        tbTotalDebit.Text = tDebit
        tbTotalCredit.Text = tCredit

    End Sub
    Private Sub generateAccount()
        dgAccTrans.Rows.Clear()

        Dim filterLedger = From vouchers In Me.TbAccountTransTableAdapter.GetData()
                            Where vouchers.Field(Of String)("Account_Name") = dgTrial.CurrentRow.Cells(0).Value _
                            And (vouchers.Field(Of Date)("Voucher_Date") >= dtStart.Text _
                             And vouchers.Field(Of Date)("Voucher_Date") <= dtEnd.Text)
                            Select vouchers

        Dim arrLedger(3) As String

        For Each rows In filterLedger.AsEnumerable
            arrLedger(0) = rows.Field(Of Date)("Voucher_Date")
            arrLedger(1) = rows.Field(Of String)("Reference_ID")
            arrLedger(2) = rows.Field(Of Double)("Voucher_Debit")
            arrLedger(3) = rows.Field(Of Double)("Voucher_Credit")

            dgAccTrans.Rows.Add(arrLedger)
            computeCRDR()
        Next
    End Sub
    Private Sub computeCRDR()
        If dgAccTrans.RowCount = 0 Then
            Exit Sub
        End If

        Dim dr As Double = 0
        Dim cr As Double = 0

        For i = 0 To dgAccTrans.RowCount - 1
            dr += dgAccTrans.Rows(i).Cells(2).Value
            cr += dgAccTrans.Rows(i).Cells(3).Value
        Next

        tbAccCR.Text = cr
        tbAccDR.Text = dr
        tbAccBalance.Text = Math.Abs(dr - cr)
    End Sub
    Private Sub dgTrial_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgTrial.SelectionChanged
        generateAccount()
    End Sub
    Private Sub cmsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsDelete.Click
        deleteRecord(dgAccTrans.CurrentRow.Cells(1).Value)

        btnRun_Click(sender, e)
    End Sub
    Private Sub cmVoucher_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmVoucher.Opening
        If dgAccTrans.RowCount < 1 Then
            cmVoucher.Enabled = False
        Else
            cmVoucher.Enabled = True
        End If
    End Sub
End Class
