Imports MetroFramework

Public Class pnlProfiAnalysis

    Dim dtCost As New DataTable

    Private Sub pnlProfiAnalysis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtCost.Columns.Add("iGroup")
        dtCost.Columns.Add("iCode")
        dtCost.Columns.Add("iDesc")
        dtCost.Columns.Add("iQty")
        dtCost.Columns.Add("iCost")

        computeCost()
    End Sub
    Private Sub computeCost()
        Dim dtTrans As New DataTable
        Dim dtVtype As New DataTable
        Dim dtItms As New DataTable
        dtTrans = retrieveTableFunction("SELECT itm_Code, itm_Quantity_In, itm_Total_Cost, Voucher_Name FROM tbItemTrans")
        dtVtype = retrieveTableFunction("SELECT Voucher_Type, Voucher_Name FROM tbVouchers")
        dtItms = retrieveTableFunction("SELECT itm_Group, itm_Code, itm_Desc, itm_Unit FROM tbItems")

        Dim getCost = From gCost In dtTrans.AsEnumerable _
                      Join gVch In dtVtype.AsEnumerable _
                      On gCost.Field(Of String)("Voucher_Name") Equals gVch.Field(Of String)("Voucher_Name") _
                      Join gItms In dtItms.AsEnumerable _
                      On gCost.Field(Of String)("itm_Code") Equals gItms.Field(Of String)("itm_Code")
                      Where gVch.Field(Of String)("Voucher_Type") = "Purchase" _
                      Or gCost.Field(Of String)("Voucher_Name") = "Opening" _
                      Group By itmCode = gItms.Field(Of String)("itm_Code"), _
                      itmDesc = gItms.Field(Of String)("itm_Desc"), _
                      itmGroup = gItms.Field(Of String)("itm_Group")
                      Into tQty = Sum(gCost.Field(Of Double)("itm_Quantity_In")), _
                      tCost = Sum(gCost.Field(Of Double)("itm_Total_Cost"))
                      Select itmGroup, itmCode, itmDesc, tQty, tCost

        Dim arrItms(4) As String
        For Each gcost In getCost
            arrItms(0) = gcost.itmGroup
            arrItms(1) = gcost.itmCode
            arrItms(2) = gcost.itmDesc
            arrItms(3) = gcost.tQty
            arrItms(4) = gcost.tCost

            dtCost.Rows.Add(arrItms)
        Next

        DataGridView1.DataSource = dtCost
    End Sub
End Class
