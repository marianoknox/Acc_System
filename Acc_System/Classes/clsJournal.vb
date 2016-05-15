Public Class clsJournal
    Public Sub itemNumbering(ByVal dgInvItem As MetroFramework.Controls.MetroGrid)
        Dim counter As Integer = 1
        For i = 0 To dgInvItem.Rows.Count - 1
            dgInvItem.Rows(i).Cells(0).Value = counter
            counter += 1
        Next
    End Sub
End Class
