Imports MetroFramework


Public Class clsItems

    'several datatables are created in methods
    'not sure if they are disposing after each call
    'or created repeatedly, Caution!!!

    Public dtItems As DataTable
    Private dtItemTrans As New DataTable
    Private dtLocation As New DataTable
    Private Sub getItemTrans()
        dtItemTrans = retrieveTableFunction("SELECT * FROM tbItemTrans")
    End Sub
    Private Sub getLocation()
        dtLocation = retrieveTableFunction("SELECT * FROM tbLocationList")
    End Sub
    Public Function generateTable() As DataTable
        getItemTrans()
        getLocation()

        'create table with columns: code, description and locations
        Dim dt As New DataTable

        dt.Columns.Add("Code")

        For iItems = 0 To dtItems.Rows.Count - 1
            dt.Rows.Add(dtItems.Rows(iItems).Item(0))
        Next

        For iLoc = 0 To dtLocation.Rows.Count - 1
            Dim locName As String = dtLocation.Rows(iLoc).Item("itm_Location")
            dt.Columns.Add(locName)
            For i = 0 To dt.Rows.Count - 1
                Dim closeBal As Double = filterItm(dt.Rows(i).Item("Code"), locName)
                dt.Rows(i).Item(locName) = closeBal
            Next
        Next

        Return dt
    End Function
    Private Function filterLoc(ByVal location As String) As DataTable
        'filter the item transactions by location   

        Dim dtLoc As New DataTable
        dtLoc.Columns.Add("Code")
        dtLoc.Columns.Add("Balance")

        Dim locQuery = From loc In dtItemTrans.AsEnumerable
                       Where loc.Field(Of String)("itm_Location") = location
                       Select loc

        For Each row In locQuery
            Dim iIn As Double = row.Item("itm_Quantity_In")
            Dim iOut As Double = row.Item("itm_Quantity_Out")
            Dim bal As Double = iIn - iOut
            Dim iRow() As String = {row.Item("itm_Code"), bal}

            dtLoc.Rows.Add(iRow)
        Next

        Return dtLoc

    End Function
    Private Function filterItm(ByVal iCode As String, ByVal location As String) As Double
        'get the table filter by location
        'and filter it by item

        Dim dt As New DataTable
        dt = filterLoc(location)

        'this code is temporary
        'it will get slower as the process progresses
        Dim bal As Double = 0
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).Item("Code") = iCode Then
                bal += dt.Rows(i).Item("Balance")
            End If
        Next

        Return bal

    End Function

    Public Overloads Function getItemBalance(ByVal itmCode As String) As Array
        Return _getItemBalance(itmCode)
    End Function
    Private Overloads Function _getItemBalance(ByVal itmCode As String) As Array
        Dim dtLocList As New DataTable
        Dim dtItemTrans As New DataTable

        dtItemTrans = retrieveTableFunction("SELECT itm_Code, itm_Location, itm_Quantity_In, itm_Quantity_Out FROM tbItemTrans")
        dtLocList = retrieveTableFunction("SELECT * FROM tbLocationList")

        Dim LocQuery = From locs In dtLocList.AsEnumerable
                       Select locs.Field(Of String)("itm_Location")

        Dim arrLoc(LocQuery.Count - 1) As String
        Dim counter As Integer = 0

        For Each lc In LocQuery
            arrLoc(counter) = lc
            counter += 1
        Next

        'Dim itmQuery = From itms In Me.TbItemsTableAdapter.GetData.AsEnumerable _
        '               Join itmTrans In Me.TbItemTransTableAdapter.GetData.AsEnumerable _
        '               On itms.Field(Of String)("itm_Code") Equals itmTrans.Field(Of String)("itm_Code")
        '               Where (itms.Field(Of String)("itm_Code") = dgInvItem.CurrentRow.Cells(1).Value _
        '               And itms.Field(Of String)("itm_Location") = arrLoc(0))
        '               Group By itmCode = itms.Field(Of String)("itm_Code") _
        '               Into locIn = Sum(itmTrans.Field(Of Double)("itm_Quantity_In")), locOut = Sum(itmTrans.Field(Of Double)("itm_Quantity_Out"))
        '               Select itmCode, locBal = locIn - locOut

        Dim arrVal(arrLoc.Length - 1) As String
        For i = 0 To arrLoc.Length - 1
            Dim loopCount As Integer = i
            'opening balance is not included in this query
            Dim itmQuery = Aggregate itmTrans In dtItemTrans.AsEnumerable _
                      Where (itmTrans.Field(Of String)("itm_Code") = itmCode _
                      And itmTrans.Field(Of String)("itm_Location") = arrLoc(loopCount)) _
                      Into locIn = Sum(itmTrans.Field(Of Double)("itm_Quantity_In")), locOut = Sum(itmTrans.Field(Of Double)("itm_Quantity_Out"))


            arrVal(i) = itmQuery.locIn - itmQuery.locOut
        Next

        Return arrVal

    End Function
End Class

