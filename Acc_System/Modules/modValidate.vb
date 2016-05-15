Imports MetroFramework

Module modValidate
    Public Function validateNumber(ByVal strNum As String)
        Dim pass As Boolean = True

        Try
            Dim num As Double = strNum
        Catch ex As Exception
            MetroMessageBox.Show(frmMain, "Invalid entry, Please provide number value", _
            "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information)
            pass = False
        End Try

        Return pass
    End Function
    Public Function validateEmpty(ByVal strVal As String)
        Dim pass As Boolean = True

        If strVal = "" Then
            MetroMessageBox.Show(frmMain, "One or more parameter(s) are empty", "Validate Error", _
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            pass = False
        Else
            pass = True
        End If

        Return pass
    End Function
    Public Function validateDuplicate(ByVal strQuery As String)
        Dim pass As Boolean = True
        Dim dt As New DataTable
        dt = retrieveTableFunction(strQuery)

        If dt.Rows.Count > 0 Then
            pass = False
        End If

        Return pass
    End Function
End Module
