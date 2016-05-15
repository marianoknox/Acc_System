Public Class pnlItems
    Dim retData As New DataTable

    Private Sub pnlItems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getCbVal(cbSupplier, "SELECT itm_Supplier FROM tbItemSupplierList", "itm_Supplier")
        getCbVal(cbCategory, "SELECT itm_Category FROM tbItemCategory", "itm_Category")
        getCbVal(cbSubCategory, "SELECT itm_Sub_Category FROM tbItemSubCategory", "itm_Sub_Category")
        getCbVal(cbColor, "SELECT itm_Color FROM tbItemColor", "itm_Color")
        getCbVal(cbGroup, "SELECT itm_Group FROM tbItemGroupList", "itm_Group")

        
    End Sub
    Private Sub generateRepSelect()
        dgItemTrans.Rows.Clear()
        retData.Rows.Clear()
        Dim dtItems As New DataTable

        'test data
        'isPosted field is not yet included
        dtItems = retrieveTableFunction("SELECT tbItems.itm_Code, tbItems.itm_Desc, tbItems.itm_Unit, " & _
        " tbItems.itm_Price, tbItems.itm_Group, tbItems.itm_Category, tbItems.itm_Sub_Category, tbItems.itm_Color, " & _
        " tbItems.itm_Supplier, SUM(tbItemTrans.itm_Quantity_In) AS SUMIN, SUM(tbItemTrans.itm_Quantity_Out) AS SUMOUT " & _
        " FROM tbItems LEFT JOIN tbItemTrans ON tbItems.itm_Code = tbItemTrans.itm_Code " & _
        " GROUP BY tbItems.itm_Code, tbItems.itm_Desc, tbItems.itm_Unit, tbItems.itm_Price, tbItems.itm_Group," & _
        " tbItems.itm_Category, tbItems.itm_Sub_Category, tbItems.itm_Color, tbItems.itm_Supplier")

        'WHERE (tbItemTrans.isPosted = 'True')
        'dgItemTrans.DataSource = dtsamp

        retData = dtItems


        Dim getItems = From itms In retData.AsEnumerable _
                       Where itms.Field(Of String)("itm_Group") = cbGroup.Text _
                       Select itms

        ''If in case the SQL Query become slow, use this instead

        'Dim dtItems As New DataTable
        'Dim dtTrans As New DataTable
        'dtItems = retrieveTableFunction("SELECT itm_Code, itm_Desc FROM tbItems")
        'dtTrans = retrieveTableFunction("SELECT itm_Code, itm_Quantity_In, itm_Quantity_Out, isPosted FROM tbItemTrans")

        'Dim getItems = From itms In dtItems.AsEnumerable _
        '               Join trans In dtTrans.AsEnumerable _
        '               On itms.Field(Of String)("itm_Code") Equals trans.Field(Of String)("itm_Code") _
        '               Where trans.Field(Of Boolean)("isPosted") = True _
        '               Group By iCode = itms.Field(Of String)("itm_Code"), iDesc = itms.Field(Of String)("itm_Desc") _
        '               Into tIncoming = Sum(trans.Field(Of Double)("itm_Quantity_In")), tOutgoing = Sum(trans.Field(Of Double)("itm_Quantity_Out")) _
        '               Select iCode, iDesc, tIncoming, tOutgoing, closing = tIncoming - tOutgoing

        For Each getI In getItems
            Dim gCode = getI.Field(Of String)("itm_Code")
            Dim gDesc = getI.Field(Of String)("itm_Desc")
            Dim gSumIn As Double = getI.Field(Of Double)("SUMIN")
            Dim gSumOut As Double = getI.Field(Of Double)("SUMOUT")
            Dim gClose As Double = gSumIn - gSumOut
            Dim gPrice As Double = getI.Field(Of Double)("itm_Price")

            dgItemTrans.Rows.Add(gCode, gDesc, gSumIn, gSumOut, gClose, gPrice)
        Next
    End Sub
    Private Sub generateRepAll()
        dgItemTrans.Rows.Clear()
        retData.Rows.Clear()
        Dim dtItems As New DataTable

        'test data
        'isPosted field is not yet included
        dtItems = retrieveTableFunction("SELECT tbItems.itm_Code, tbItems.itm_Desc, tbItems.itm_Unit, " & _
        " tbItems.itm_Price, tbItems.itm_Group, tbItems.itm_Category, tbItems.itm_Sub_Category, tbItems.itm_Color, " & _
        " tbItems.itm_Supplier, SUM(tbItemTrans.itm_Quantity_In) AS SUMIN, SUM(tbItemTrans.itm_Quantity_Out) AS SUMOUT " & _
        " FROM tbItems LEFT JOIN tbItemTrans ON tbItems.itm_Code = tbItemTrans.itm_Code " & _
        " GROUP BY tbItems.itm_Code, tbItems.itm_Desc, tbItems.itm_Unit, tbItems.itm_Price, tbItems.itm_Group," & _
        " tbItems.itm_Category, tbItems.itm_Sub_Category, tbItems.itm_Color, tbItems.itm_Supplier")

        'WHERE (tbItemTrans.isPosted = 'True')
        'dgItemTrans.DataSource = dtsamp

        retData = dtItems


        Dim getItems = From itms In retData.AsEnumerable _
                       Select itms

        For Each getI In getItems
            Dim gCode = getI.Field(Of String)("itm_Code")
            Dim gDesc = getI.Field(Of String)("itm_Desc")
            Dim gSumIn As Double = getI.Field(Of Double)("SUMIN")
            Dim gSumOut As Double = getI.Field(Of Double)("SUMOUT")
            Dim gClose As Double = gSumIn - gSumOut
            Dim gPrice As Double = getI.Field(Of Double)("itm_Price")

            dgItemTrans.Rows.Add(gCode, gDesc, gSumIn, gSumOut, gClose, gPrice)
        Next
    End Sub
    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        If rbAllGroup.Checked = True Then
            generateRepAll()
        Else
            generateRepSelect()
        End If

    End Sub

    Private Sub cmProp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmProp.Click
        pnlPropFilter.Visible = True
    End Sub

    Private Sub cmQua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmQua.Click
        pnlQuaFilter.Visible = True
    End Sub
    Private Sub dgItemTrans_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgItemTrans.Click
        pnlPropFilter.Visible = False
        pnlQuaFilter.Visible = False
    End Sub
    Private Sub addFilter(ByVal strField As String, ByVal strFilter As String, ByVal caseSelect As Integer)
        dgItemTrans.Rows.Clear()

        'This line of code will get really slow
        'make something that will get a sing chunk of data without using LINQ

        Select Case caseSelect
            Case 1
                Dim filterData = From dtItm In retData.AsEnumerable _
                                 Where dtItm.Field(Of String)(strField) = strFilter _
                                 Select dtItm
                For Each getI In filterData
                    Dim gCode = getI.Field(Of String)("itm_Code")
                    Dim gDesc = getI.Field(Of String)("itm_Desc")
                    Dim gSumIn As Double = getI.Field(Of Double)("SUMIN")
                    Dim gSumOut As Double = getI.Field(Of Double)("SUMOUT")
                    Dim gClose As Double = gSumIn - gSumOut
                    Dim gPrice As Double = getI.Field(Of Double)("itm_Price")

                    dgItemTrans.Rows.Add(gCode, gDesc, gSumIn, gSumOut, gClose, gPrice)
                Next
                ' fillTable(filterData)
            Case 2
                Dim filterData = From dtItm In retData.AsEnumerable _
                                 Where dtItm.Field(Of String)(strField) = strFilter _
                                 And dtItm.Field(Of String)(strField) = strFilter _
                                 Select dtItm

                fillTable(filterData)

            Case 3
                Dim filterData = From dtItm In retData.AsEnumerable _
                                 Where dtItm.Field(Of String)(strField) = strFilter _
                                 And dtItm.Field(Of String)(strField) = strFilter _
                                 And dtItm.Field(Of String)(strField) = strFilter _
                                 Select dtItm

                fillTable(filterData)
            Case 4
                Dim filterData = From dtItm In retData.AsEnumerable _
                                 Where dtItm.Field(Of String)(strField) = strFilter _
                                 And dtItm.Field(Of String)(strField) = strFilter _
                                 And dtItm.Field(Of String)(strField) = strFilter _
                                 And dtItm.Field(Of String)(strField) = strFilter _
                                 Select dtItm

                fillTable(filterData)
        End Select

    End Sub
    Private Sub fillTable(ByVal filterData As System.Data.EnumerableRowCollection)
        For Each getI In filterData
            Dim gCode = getI.Field(Of String)("itm_Code")
            Dim gDesc = getI.Field(Of String)("itm_Desc")
            Dim gSumIn As Double = getI.Field(Of Double)("SUMIN")
            Dim gSumOut As Double = getI.Field(Of Double)("SUMOUT")
            Dim gClose As Double = gSumIn - gSumOut
            Dim gPrice As Double = getI.Field(Of Double)("itm_Price")

            dgItemTrans.Rows.Add(gCode, gDesc, gSumIn, gSumOut, gClose, gPrice)
        Next
    End Sub

    Private Sub btnPropFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPropFilter.Click
        Dim arrFilter() As MetroFramework.Controls.MetroCheckBox = {chkSupplier, chkCategory, chkSubCategory, chkColor}

        Dim counter As Integer = 0
        For i = 0 To arrFilter.Length - 1
            If arrFilter(i).Checked = True Then
                counter += 1
            End If
        Next

        addFilter("itm_Supplier", cbSupplier.Text, 1)

        pnlPropFilter.Visible = False
    End Sub
End Class
