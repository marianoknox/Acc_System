Imports MetroFramework

Public Class pnlOutstanding

    Private Sub pnlOutstanding_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TbAccountsTableAdapter.Fill(Me.ACCDBDataSet.tbAccounts)
    End Sub
    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        dgOutstanding.Rows.Clear()
        If rbAccounts.Checked = True Then
            getByAccount()
        ElseIf rbPayables.Checked = True Then
            getByPayable()
        Else
            getByReceivable()
        End If

    End Sub
    Private Sub getByAccount()
     
        Dim getOutstanding = From outs In Me.TbAccountTransTableAdapter.GetData.AsEnumerable _
                             Where outs.Field(Of String)("Account_Name") = cbAccount.Text _
                             And (outs.Field(Of Date)("Voucher_Date") >= dtStart.Text _
                             And outs.Field(Of Date)("Voucher_Date") <= dtEnd.Text)
                             Select oDate = outs.Field(Of Date)("Voucher_Date"), _
                             vNum = outs.Field(Of String)("Reference_ID"), _
                             accName = outs.Field(Of String)("Account_Name"), _
                             accAmt = Math.Abs(outs.Field(Of Double)("Voucher_Debit") - outs.Field(Of Double)("Voucher_Credit")), _
                             dueDate = outs.Field(Of Date)("Voucher_Due"), _
                             asOut = outs.Field(Of Boolean)("isOutstanding")
        

        For Each outs In getOutstanding
            dgOutstanding.Rows.Add(FormatDateTime(outs.oDate, DateFormat.ShortDate), outs.vNum, outs.accName, _
            outs.accAmt, FormatDateTime(outs.dueDate, DateFormat.ShortDate), outs.asOut)
        Next
    End Sub
    Private Sub getByReceivable()
        Dim getOutstanding = From acc In Me.TbAccountsTableAdapter.GetData.AsEnumerable _
                             Join trans In Me.TbAccountTransTableAdapter.GetData.AsEnumerable _
                             On acc.Field(Of String)("Account_Name") Equals trans.Field(Of String)("Account_Name") _
                             Where acc.Field(Of String)("Account_As") = "Accounts Receivable" _
                             And (trans.Field(Of Date)("Voucher_Date") >= dtStart.Text _
                             And trans.Field(Of Date)("Voucher_Date") <= dtEnd.Text)
                             Select oDate = trans.Field(Of Date)("Voucher_Date"), _
                             vNum = trans.Field(Of String)("Reference_ID"), _
                             accName = acc.Field(Of String)("Account_Name"), _
                             accAmt = Math.Abs(trans.Field(Of Double)("Voucher_Debit") - trans.Field(Of Double)("Voucher_Credit")), _
                             dueDate = trans.Field(Of Date)("Voucher_Due"), _
                             asOut = trans.Field(Of Boolean)("isOutstanding")


        For Each outs In getOutstanding
            dgOutstanding.Rows.Add(FormatDateTime(outs.oDate, DateFormat.ShortDate), outs.vNum, _
            outs.accName, outs.accAmt, FormatDateTime(outs.dueDate, _
            DateFormat.ShortDate), outs.asOut)
        Next
    End Sub
    Private Sub getByPayable()
        Dim getOutstanding = From acc In Me.TbAccountsTableAdapter.GetData.AsEnumerable _
                             Join trans In Me.TbAccountTransTableAdapter.GetData.AsEnumerable _
                             On acc.Field(Of String)("Account_Name") Equals trans.Field(Of String)("Account_Name") _
                             Where acc.Field(Of String)("Account_As") = "Accounts Payable" _
                             And (trans.Field(Of Date)("Voucher_Date") >= dtStart.Text _
                             And trans.Field(Of Date)("Voucher_Date") <= dtEnd.Text)
                             Select oDate = trans.Field(Of Date)("Voucher_Date"), _
                             vNum = trans.Field(Of String)("Reference_ID"), _
                             accName = acc.Field(Of String)("Account_Name"), _
                             accAmt = Math.Abs(trans.Field(Of Double)("Voucher_Debit") - trans.Field(Of Double)("Voucher_Credit")), _
                             dueDate = trans.Field(Of Date)("Voucher_Due"), _
                             asOut = trans.Field(Of Boolean)("isOutstanding")


        For Each outs In getOutstanding
            dgOutstanding.Rows.Add(FormatDateTime(outs.oDate, DateFormat.ShortDate), outs.vNum, _
            outs.accName, outs.accAmt, FormatDateTime(outs.dueDate, _
            DateFormat.ShortDate), outs.asOut)
        Next
    End Sub
    Private Sub fillDG(ByVal getQuery As Collection)
        For Each outs In getQuery
            dgOutstanding.Rows.Add(FormatDateTime(outs.oDate, DateFormat.ShortDate), outs.vNum, _
            outs.accName, outs.accAmt, FormatDateTime(outs.dueDate, _
            DateFormat.ShortDate), outs.asOut)
        Next
    End Sub
End Class
