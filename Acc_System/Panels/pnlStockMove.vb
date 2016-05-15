Public Class pnlStockMove

    Private Sub pnlStockMove_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TbItemGroupListTableAdapter.Fill(Me.ACCDBDataSet.tbItemGroupList)
    End Sub
    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        Dim dtSales As New DataTable
        dtSales.Columns.Add("sCode")
        dtSales.Columns.Add("sQty")

        Dim getSales = From itms In Me.TbItemsTableAdapter.GetData.AsEnumerable _
                       Join sales In Me.TbItemTransTableAdapter.GetData.AsEnumerable _
                       On itms.Field(Of String)("itm_Code") Equals sales.Field(Of String)("itm_Code") _
                       Join vch In Me.TbVouchersTableAdapter.GetData.AsEnumerable _
                       On vch.Field(Of String)("Voucher_Name") Equals sales.Field(Of String)("Voucher_Name")
                       Where vch.Field(Of String)("Voucher_Type") = "Sales" _
                       Group By iCode = itms.Field(Of String)("itm_Code") _
                       Into tSales = Sum(sales.Field(Of Double)("itm_Quantity_Out")) _
                       Select iCode, tSales

        For Each itm In getSales
            dtSales.Rows.Add(itm.iCode, itm.tSales)
        Next

        '-------------------------------------------------------------------------------------------------------------
        Dim dtSReturn As New DataTable
        dtSReturn.Columns.Add("srCode")
        dtSReturn.Columns.Add("srQty")

        Dim getSalesReturn = From itms In Me.TbItemsTableAdapter.GetData.AsEnumerable _
                       Join sales In Me.TbItemTransTableAdapter.GetData.AsEnumerable _
                       On itms.Field(Of String)("itm_Code") Equals sales.Field(Of String)("itm_Code") _
                       Join vch In Me.TbVouchersTableAdapter.GetData.AsEnumerable _
                       On vch.Field(Of String)("Voucher_Name") Equals sales.Field(Of String)("Voucher_Name")
                       Where vch.Field(Of String)("Voucher_Type") = "Sales Return" _
                       Group By iCode = itms.Field(Of String)("itm_Code") _
                       Into tSRetun = Sum(sales.Field(Of Double)("itm_Quantity_In")) _
                       Select iCode, tSRetun

        For Each itm In getSalesReturn
            dtSReturn.Rows.Add(itm.iCode, itm.tSRetun)
        Next

        '-------------------------------------------------------------------------------------------------------------
        Dim dtPurchase As New DataTable
        dtPurchase.Columns.Add("pCode")
        dtPurchase.Columns.Add("pQty")

        Dim getPurchase = From itms In Me.TbItemsTableAdapter.GetData.AsEnumerable _
                       Join sales In Me.TbItemTransTableAdapter.GetData.AsEnumerable _
                       On itms.Field(Of String)("itm_Code") Equals sales.Field(Of String)("itm_Code") _
                       Join vch In Me.TbVouchersTableAdapter.GetData.AsEnumerable _
                       On vch.Field(Of String)("Voucher_Name") Equals sales.Field(Of String)("Voucher_Name")
                       Where vch.Field(Of String)("Voucher_Type") = "Purchase" _
                       Group By iCode = itms.Field(Of String)("itm_Code") _
                       Into tPurchase = Sum(sales.Field(Of Double)("itm_Quantity_In")) _
                       Select iCode, tPurchase

        For Each itm In getPurchase
            dtPurchase.Rows.Add(itm.iCode, itm.tPurchase)
        Next

        '-------------------------------------------------------------------------------------------------------------
        Dim dtPReturn As New DataTable
        dtPReturn.Columns.Add("prCode")
        dtPReturn.Columns.Add("prQty")

        Dim getPurchaseReturn = From itms In Me.TbItemsTableAdapter.GetData.AsEnumerable _
                       Join sales In Me.TbItemTransTableAdapter.GetData.AsEnumerable _
                       On itms.Field(Of String)("itm_Code") Equals sales.Field(Of String)("itm_Code") _
                       Join vch In Me.TbVouchersTableAdapter.GetData.AsEnumerable _
                       On vch.Field(Of String)("Voucher_Name") Equals sales.Field(Of String)("Voucher_Name")
                       Where vch.Field(Of String)("Voucher_Type") = "Purchase Return" _
                       Group By iCode = itms.Field(Of String)("itm_Code") _
                       Into tPRetun = Sum(sales.Field(Of Double)("itm_Quantity_Out")) _
                       Select iCode, tPRetun

        For Each itm In getPurchaseReturn
            dtPReturn.Rows.Add(itm.iCode, itm.tPRetun)
        Next

        '-------------------------------------------------------------------------------------------------------------
        DataGridView1.DataSource = dtSales
        DataGridView2.DataSource = dtSReturn
        DataGridView3.DataSource = dtPurchase
        DataGridView4.DataSource = dtPReturn






        'Dim getTables = From itms In Me.TbItemsTableAdapter.GetData.AsEnumerable _
        '               Group Join sales In dtSales.AsEnumerable On itms.Field(Of String)("itm_Code") Equals sales.Field(Of String)("sCode") Into a = Group _
        '               Group Join sRet In dtSReturn.AsEnumerable On itms.Field(Of String)("itm_Code") Equals sRet.Field(Of String)("srCode") Into b = Group _
        '               Group Join pur In dtSReturn.AsEnumerable On itms.Field(Of String)("itm_Code") Equals pur.Field(Of String)("pCode") Into c = Group _
        '               Group Join pRet In dtSReturn.AsEnumerable On itms.Field(Of String)("itm_Code") Equals pRet.Field(Of String)("prCode") Into d = Group _
        '                Select iCode = itms.Field(Of String)("itm_Code"), iDesc = itms.Field(Of String)("itm_Desc"), _
        '                a.tSales = Field(Of Double)("sQty"), tsRet = sRet.Field(Of Double)("srQty"), tPur = pur.Field(Of Double)("pQty"), _
        '                tpRet = pRet.Field(Of Double)("prQty")

        'For Each getT In getTables
        '    dgItemTrans.Rows.Add(getT.iCode, getT.iDesc, _
        '    getT.tSales, getT.tsRet, getT.tPur, getT.tpRet)
        'Next


    End Sub
End Class
