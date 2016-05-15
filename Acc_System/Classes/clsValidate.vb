Imports MetroFramework

Public Class clsValidate

    Public Function validateEntry(ByVal fieldName As String, ByVal strName As String, ByVal dt As DataTable) As Boolean
        Dim duplicated As Boolean = False

        Dim countQuery = Aggregate val In dt.AsEnumerable
                         Where val.Field(Of String)(fieldName) = strName
                           Into Count()

        If countQuery > 0 Then
            MetroMessageBox.Show(frmMain, "System traced a double entry, please input a different name", "Duplicate Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            duplicated = True
        End If

        Return duplicated
    End Function
End Class
