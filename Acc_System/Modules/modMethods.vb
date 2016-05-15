Imports MetroFramework
Module modMethods
    Public Function returnInvNum(ByVal voucherType As String) As Array

        Dim dtVouchers As New DataTable
        Dim dtVoucherTrans As New DataTable

        dtVouchers = retrieveTableFunction("SELECT Voucher_Name, Voucher_Prefix, Voucher_Starting FROM tbVouchers")
        dtVoucherTrans = retrieveTableFunction("SELECT Voucher_Prefix, Voucher_ID FROM tbVoucherTrans")

        'Public variable for prefix
        'Declared public to retrieve the value to be used as reference in invoice numbering
        Dim pref As String = Nothing

        'query to filter the table 
        'returns specific accounts only
        Dim query = From row In dtVouchers.AsEnumerable
                    Where row.Field(Of String)("Voucher_Name") = voucherType _
                    Select row

        Dim starting As Integer = 0

        'get the prefix for the voucher type and starting number
        'use starting number only if there are no transaction from the voucher type
        'else, increament by 1
        For Each r In query
            pref = r.Field(Of String)("Voucher_Prefix")
            starting = r.Field(Of Integer)("Voucher_Starting")
        Next


        Dim voucherCount = From vRow In dtVoucherTrans.AsEnumerable
                          Where vRow.Field(Of String)("Voucher_Prefix") = pref
                          Select vRow.Field(Of Integer)("Voucher_ID")

        Dim voucID As Double = starting

        If voucherCount.Count > 0 Then
            For Each rVouch In voucherCount
                If rVouch > voucID Then
                    voucID = rVouch
                End If
            Next
        Else
            voucID = starting
        End If

        voucID += 1

        Dim arrInvNum() As String = {pref, voucID}

        Return arrInvNum
    End Function
    Public Sub contextOpening(ByVal dg As MetroFramework.Controls.MetroGrid, _
    ByVal cms As MetroFramework.Controls.MetroContextMenu)

        If dg.RowCount < 1 Then
            cms.Enabled = False
        Else
            cms.Enabled = True
        End If
    End Sub
    Public Sub deleteRecord(ByVal Reference_ID As String)
        Dim delTrans = MetroMessageBox.Show(frmMain, "Are you sure you want to delete this transaction?", _
       "CAUTION : Deleted transaction will be permanently removed", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

        If delTrans = DialogResult.OK Then
            deleteTransaction("DELETE FROM tbItemTrans WHERE Reference_ID = '" & Reference_ID & "'")
            deleteTransaction("DELETE FROM tbVoucherTrans WHERE Reference_ID = '" & Reference_ID & "'")
            deleteTransaction("DELETE FROM tbAccountTrans WHERE Reference_ID = '" & Reference_ID & "'")
            deleteTransaction("DELETE FROM tbReference WHERE Reference_ID = '" & Reference_ID & "'")
        End If
    End Sub
    Public Sub deleteRecordnoMsg(ByVal Reference_ID As String)
        deleteTransaction("DELETE FROM tbItemTrans WHERE Reference_ID = '" & Reference_ID & "'")
        deleteTransaction("DELETE FROM tbVoucherTrans WHERE Reference_ID = '" & Reference_ID & "'")
        deleteTransaction("DELETE FROM tbAccountTrans WHERE Reference_ID = '" & Reference_ID & "'")
        deleteTransaction("DELETE FROM tbReference WHERE Reference_ID = '" & Reference_ID & "'")
    End Sub
    Public Function getItemBalance(ByVal itmCode As String) As DataTable
        Dim dtLocList As New DataTable
        Dim dtItemTrans As New DataTable
        Dim locTable As New DataTable

        locTable.Columns.Add("Location")
        locTable.Columns.Add("Quantity")

        dtItemTrans = retrieveTableFunction("SELECT itm_Code, itm_Location, itm_Quantity_In, itm_Quantity_Out FROM tbItemTrans WHERE isPosted = 'True'")
        dtLocList = retrieveTableFunction("SELECT * FROM tbLocationList")

        Dim LocQuery = From locs In dtLocList.AsEnumerable
                       Select locs.Field(Of String)("itm_Location")

        Dim arrLoc(LocQuery.Count - 1) As String
        Dim counter As Integer = 0
        For Each lc In LocQuery
            locTable.Rows.Add()
            locTable.Rows(counter).Item(0) = lc
            counter += 1
        Next

        For i = 0 To arrLoc.Length - 1
            Dim loopCount As Integer = i
            'opening balance is not included in this query
            Dim itmQuery = Aggregate itmTrans In dtItemTrans.AsEnumerable _
                      Where (itmTrans.Field(Of String)("itm_Code") = itmCode _
                      And itmTrans.Field(Of String)("itm_Location") = locTable.Rows(loopCount).Item(0)) _
                      Into locIn = Sum(itmTrans.Field(Of Double)("itm_Quantity_In")), _
                      locOut = Sum(itmTrans.Field(Of Double)("itm_Quantity_Out"))

            locTable.Rows(i).Item(1) = itmQuery.locIn - itmQuery.locOut
        Next

        Return locTable

    End Function
    Public Function getItemBalance(ByVal iCodeLoc As String, ByVal Defloc As String) As Double
        Dim dtItemTrans As New DataTable

        dtItemTrans = retrieveTableFunction("SELECT itm_Code, itm_Location, itm_Quantity_In, itm_Quantity_Out FROM tbItemTrans WHERE isPosted = 'True'")

        'opening balance is not included in this query
        Dim itmQuery = Aggregate itmTrans In dtItemTrans.AsEnumerable _
                  Where (itmTrans.Field(Of String)("itm_Code") = iCodeLoc _
                  And itmTrans.Field(Of String)("itm_Location") = Defloc) _
                  Into locIn = Sum(itmTrans.Field(Of Double)("itm_Quantity_In")), locOut = Sum(itmTrans.Field(Of Double)("itm_Quantity_Out"))


        Dim iVal As Double = itmQuery.locIn - itmQuery.locOut

        Return iVal

    End Function
    Public Function getDefaultCurrency() As String
        Dim dtDefCur As New DataTable
        Dim defCur As String = Nothing
        dtDefCur = retrieveTableFunction("SELECT Currency_Symbol FROM tbCurrency WHERE Use_Default = 'True'")
        If dtDefCur.Rows.Count = 0 Then
            MetroMessageBox.Show(frmMain, "No default currency selected", "Deafault Currency", _
            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            defCur = dtDefCur.Rows(0).Item(0)
        End If

        Return defCur
    End Function
    Public Function getDefaultLocation() As String
        Dim dtDefLoc As New DataTable
        Dim defLoc As String = Nothing
        dtDefLoc = retrieveTableFunction("SELECT itm_Location FROM tbLocationList WHERE Default_Location = 'True'")
        If dtDefLoc.Rows.Count = 0 Then
            MetroMessageBox.Show(frmMain, "No default Location selected", "Deafault Location", _
            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            defLoc = dtDefLoc.Rows(0).Item(0)
        End If

        Return defLoc
    End Function
    Public Function viewSales(ByVal viewRefID As String, ByVal dg As MetroFramework.Controls.MetroGrid) As Array
        Dim dtVoucherData As New DataTable

        dtVoucherData = retrieveTableFunction("SELECT Reference_ID, Cost_Center," & _
        "Account_Name,Voucher_Amount,Voucher_Discount,Voucher_Net,Voucher_Reference, " & _
        "Voucher_LPO,Voucher_Quot,Voucher_Narration FROM tbVoucherTrans WHERE Reference_ID = '" & _
        viewRefID & "'")
        
        If dtVoucherData.Rows.Count = 0 Then
            Dim arr() = Nothing
            Return arr
            Exit Function
        End If

        Dim arrValue(9) As String
        For iVouch = 0 To dtVoucherData.Rows.Count - 1
            arrValue(0) = dtVoucherData.Rows(iVouch).Item("Reference_ID")
            arrValue(1) = dtVoucherData.Rows(iVouch).Item("Cost_Center")
            arrValue(2) = dtVoucherData.Rows(iVouch).Item("Account_Name")
            arrValue(3) = dtVoucherData.Rows(iVouch).Item("Voucher_Amount")
            arrValue(4) = dtVoucherData.Rows(iVouch).Item("Voucher_Discount")
            arrValue(5) = dtVoucherData.Rows(iVouch).Item("Voucher_Net")
            arrValue(6) = dtVoucherData.Rows(iVouch).Item("Voucher_Reference")
            arrValue(7) = dtVoucherData.Rows(iVouch).Item("Voucher_LPO")
            arrValue(8) = dtVoucherData.Rows(iVouch).Item("Voucher_Quot")
            arrValue(9) = dtVoucherData.Rows(iVouch).Item("Voucher_Narration")
        Next

        

        Return arrValue

    End Function
    Public Sub itemNumbering(ByVal dgInvItem As MetroFramework.Controls.MetroGrid)
        Dim counter As Integer = 1
        For i = 0 To dgInvItem.Rows.Count - 1
            dgInvItem.Rows(i).Cells(0).Value = counter
            counter += 1
        Next
    End Sub
    Public Sub checkDuplicate(ByVal valCheck As String)
        Dim dt As New DataTable
        dt = retrieveTableFunction("SELECT Reference_ID FROM tbVoucherTrans WHERE Reference_ID = '" & valCheck & "'")

        If dt.Rows.Count = 0 Then
        Else
            MetroMessageBox.Show(frmMain, "The system traced a duplicated entry with Reference: " & valCheck & ". Please inform the developer to fix the bug", _
                                 "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub
    Public Sub getCbDgVal(ByVal cb As DataGridViewComboBoxColumn, _
                      ByVal cbQuery As String, ByVal cbField As String)

        Dim dt As New DataTable
        dt = retrieveTableFunction(cbQuery)

        cb.DataSource = dt
        cb.DisplayMember = cbField

    End Sub
    Public Sub getCbVal(ByVal cb As MetroFramework.Controls.MetroComboBox, _
                      ByVal cbQuery As String, ByVal cbField As String)

        Dim dt As New DataTable
        dt = retrieveTableFunction(cbQuery)

        cb.DataSource = dt
        cb.DisplayMember = cbField

    End Sub
End Module
