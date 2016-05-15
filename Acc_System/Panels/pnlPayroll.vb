Imports MetroFramework

Public Class pnlPayroll

    Private Sub pnlPayroll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dtEmpList As DataTable
        dtEmpList = retrieveTableFunction("SELECT emp_Number, emp_Name FROM tbEmployeeList")

        Dim arrList(dtEmpList.Columns.Count - 1) As String
        For iEmp = 0 To dtEmpList.Rows.Count - 1
            arrList(0) = dtEmpList.Rows(iEmp).Item(0)
            arrList(1) = dtEmpList.Rows(iEmp).Item(1)

            dgLogListEntry.Rows.Add(arrList)
        Next

        cbEmpName.DataSource = dtEmpList
        cbEmpName.DisplayMember = "emp_Name"
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        Dim dtLogs As DataTable
        dtLogs = retrieveTableFunction("SELECT log_Date, amTimeIn, amTimeOut, " & _
        " pmTimeIn,pmTimeOut FROM tbAttendanceLog WHERE emp_Name = '" & cbEmpName.Text & "'")

        Dim dtEmpList As DataTable
        dtEmpList = retrieveTableFunction("SELECT emp_Number, emp_Shift, emp_Salary, " & _
        " emp_Hours FROM tbEmployeeList WHERE emp_Name = '" & cbEmpName.Text & "'")

        If dtLogs.Rows.Count = 0 Then
            MetroMessageBox.Show(frmMain, "No available Logs", "Empty log", _
                                 MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If

        Dim counter As Integer = 0
        Dim arrLog(7) As String

        For iLogRow = 0 To dtLogs.Rows.Count - 1
            arrLog(0) = iLogRow + 1
            arrLog(1) = dtLogs.Rows(iLogRow).Item(0)
            arrLog(2) = dtLogs.Rows(iLogRow).Item(1).ToString
            arrLog(3) = dtLogs.Rows(iLogRow).Item(2).ToString
            arrLog(4) = dtLogs.Rows(iLogRow).Item(3).ToString
            arrLog(5) = dtLogs.Rows(iLogRow).Item(4).ToString
            arrLog(6) = compTotalTime(arrLog(1), arrLog(2))
            ' arrLog(7) = dtEmpList.Rows(0).Item(3) - arrLog(6)

            dgLogReport.Rows.Add(arrLog)
        Next
    End Sub
    Private Function compTotalTime(ByVal timeStart As DateTime, ByVal timeEnd As DateTime) As String
        Dim totalHour As Integer
        Dim totalMins As Integer

        totalHour = DateDiff(DateInterval.Hour, timeStart, timeEnd)
        totalMins = DateDiff(DateInterval.Minute, timeStart, timeEnd)

        Dim tHour As String = totalHour.ToString + ":" + totalMins.ToString
        Return tHour
    End Function
End Class
