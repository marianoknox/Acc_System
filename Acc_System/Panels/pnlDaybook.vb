Public Class pnlDaybook
    Private Sub pnlDaybook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        Dim dtDaybook As New DataTable
        dtDaybook = retrieveTableFunction("SELECT Voucher_Date, Reference_ID, Voucher_Name, Voucher_Amount FROM tbVoucherTrans")

        Dim getDay = From day In dtDaybook.AsEnumerable _
                     Where day.Field(Of Date)("Voucher_Date") = dtStart.Text _
                     Select day

        Dim arrDays(2) As String
        For Each gDay In getDay
            arrDays(0) = gDay.Field(Of String)("Reference_ID")
            arrDays(1) = gDay.Field(Of String)("Voucher_Name")
            arrDays(2) = gDay.Field(Of Double)("Voucher_Amount")

            dgDayBook.Rows.Add(arrDays)
        Next

    End Sub
End Class
