Imports MetroFramework

Public Class pnlMasters
    'if true, saves new; if false, saves edit
    Dim insertNewItem As Boolean = True


    Private Sub pnlMasters_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim year As New DateTime(DateTime.Now.Year, 1, 1)
        dtOpening.Value = year

        'Generate combobox members in creating new item
        getCbDgVal(dgNewItemUnit, "SELECT itm_Unit FROM tbItemUnits", "itm_Unit")
        getCbDgVal(dgNewItemCategory, "SELECT itm_Category FROM tbItemCategory", "itm_Category")
        getCbDgVal(dgNewItemSubCategory, "SELECT itm_Sub_Category FROM tbItemSubCategory", "itm_Sub_Category")
        getCbDgVal(dgNewItemColor, "SELECT itm_Color FROM tbItemColor", "itm_Color")
        getCbDgVal(dgNewItemSupplier, "SELECT itm_Supplier FROM tbItemSupplierList", "itm_Supplier")
        getCbDgVal(dgNewItemGroup, "SELECT itm_Group FROM tbItemGroupList", "itm_Group")

        Dim arrCRDR() As String = {"CR", "DR"}
        Dim arrAcc() As String = {"General Account", "Sales Account", "Purchase Account", "Bank Account"}
        Dim arrNature() As String = {"Assets", "Liabilities", "Income", "Expenses"}

        cbAccCRDR.DataSource = arrCRDR
        cbAccountAs.DataSource = arrAcc
        cbAccNature.DataSource = arrNature
    End Sub

    Private Sub lnkInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkInventory.Click
        mtbAccount.Height = 0
        mtbInventory.Dock = DockStyle.Fill
        mtbInventory.BringToFront()
    End Sub

    Private Sub lnkAccount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkAccount.Click
        mtbInventory.Height = 0
        mtbAccount.Dock = DockStyle.Fill
        mtbAccount.BringToFront()
    End Sub
    Private Sub btnEditItmGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditItmGroup.Click
        pnlItmGroupEdit.Visible = True
        tbItmGroupNameEdit.Text = cbItemGroup.Text
    End Sub

    Private Sub MetroButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton1.Click
        tbItmGroupNameEdit.Text = ""
        pnlItmGroupEdit.Visible = False
    End Sub
    Private Function generateSearchItems(ByVal strSearch As String) As DataTable
        Dim dtItemSelect As New DataTable

        dtItemSelect = retrieveTableFunction( _
            "SELECT itm_Code,itm_Desc,itm_Unit,itm_Price " & _
            "FROM tbItems WHERE itm_Desc LIKE '%" _
            & strSearch & "%'")

        Return dtItemSelect
    End Function
    Private Function generateItemDetails(ByVal strSearch As String) As DataTable
        Dim dtItemSelect As New DataTable

        dtItemSelect = retrieveTableFunction( _
            "SELECT itm_Code,itm_Desc,itm_Price, itm_Unit, itm_Group, itm_Supplier, " & _
            " itm_Category, itm_Sub_Category, itm_Color " & _
            "FROM tbItems WHERE itm_Desc ='" & strSearch & "'")

        Return dtItemSelect
    End Function
    Private Function generateIOpenBalance(ByVal iCode As String) As Array
        Dim dtItemSelect As New DataTable
        Dim arrOpen(1) As Double
        dtItemSelect = retrieveTableFunction( _
            "SELECT itm_Quantity_In, itm_Cost " & _
            "FROM tbItemTrans WHERE (itm_Code ='" & iCode & "' AND Voucher_Name = 'Opening')")

        Try
            arrOpen(0) = dtItemSelect.Rows(0).Item(0)
            arrOpen(1) = dtItemSelect.Rows(0).Item(1)
        Catch ex As Exception
            'Write something when rows return 0
            arrOpen = Nothing
            Return arrOpen
            Exit Function
        End Try

        Return arrOpen
    End Function
    Private Sub btnSaveNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
        Handles btnSaveNewItem.Click

        If dgAddNewItem.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim saveNow = MetroMessageBox.Show(frmMain, "Do you want to save now?", "Save", _
                                           MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If saveNow = MsgBoxResult.Ok Then
        Else
            Exit Sub
        End If

        For iRow = 0 To dgAddNewItem.Rows.Count - 1
            For icol = 0 To dgAddNewItem.ColumnCount - 1
                Try
                    If dgAddNewItem.Rows(iRow).Cells(icol).Value = "" Then
                        Dim cRow = iRow + 1

                    MetroMessageBox.Show(frmMain, "Missing parameter in Row " + cRow.ToString, _
                    "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    Exit Sub
                Else
                    End If
                Catch ex As Exception
                    'catches the exeption where the value of the cell is numeric
                End Try
            Next
        Next

        Dim pass As Boolean
        Dim curCode As String
        For iDup = 0 To dgAddNewItem.Rows.Count - 1
            curCode = dgAddNewItem.Rows(iDup).Cells(0).Value
            pass = validateDuplicate("SELECT itm_Code FROM tbItems WHERE itm_Code = '" & curCode & "'")
            If pass = False Then
                MetroMessageBox.Show(frmMain, "The code: " + curCode + " is duplicated", "Duplicate", _
                                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Next

        Dim arrObj(8) As String
        Dim loc As String
        loc = getDefaultLocation()

        For isave = 0 To dgAddNewItem.Rows.Count - 1
            Dim nCode = dgAddNewItem.Rows(isave).Cells(0).Value
            Dim nDesc = dgAddNewItem.Rows(isave).Cells(1).Value
            Dim nPrice = dgAddNewItem.Rows(isave).Cells(2).Value
            Dim nOpen = dgAddNewItem.Rows(isave).Cells(3).Value
            Dim nCost = dgAddNewItem.Rows(isave).Cells(4).Value
            Dim nUnit = dgAddNewItem.Rows(isave).Cells(5).Value
            Dim nGroup = dgAddNewItem.Rows(isave).Cells(6).Value
            Dim nSupplier = dgAddNewItem.Rows(isave).Cells(7).Value
            Dim nCategory = dgAddNewItem.Rows(isave).Cells(8).Value
            Dim nSubCategory = dgAddNewItem.Rows(isave).Cells(9).Value
            Dim nColor = dgAddNewItem.Rows(isave).Cells(10).Value

            Dim passPrice = validateNumber(nPrice)
            Dim passOpen = validateNumber(nOpen)
            Dim passCost = validateNumber(nCost)

            If passPrice = False Or passOpen = False Or passCost = False Then
                Exit Sub
            End If

            If insertNewItem = True Then
                'saving new item
                saveNewItem(nCode, nDesc, nUnit, nGroup, nSupplier, nPrice, _
                            nColor, nCategory, nSubCategory)

                'saving new opening balance
                Dim tCost As Double = nOpen * nCost
                saveItemTrans("Opening", dtOpening.Text, nCode, nDesc, nOpen, _
                              nUnit, nOpen, 0, loc, 0, 0, nCost, 0, "", True, _
                              "Opening", 0, frmMain.lblActiveYear.Text, tCost, 0)

            Else
                'saving changes into existing item

            End If
           
        Next

        dgAddNewItem.Rows.Clear()

        MetroMessageBox.Show(frmMain, "Item successfully added to database", "Item Saved", _
                             MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub
    Private Sub tbSearchEditExistItem_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbSearchEditExistItem.TextChanged
        Dim dt As DataTable
        dt = generateSearchItems(tbSearchEditExistItem.Text)

        cbSearchItemResult.DataSource = dt
        cbSearchItemResult.DisplayMember = "itm_Desc"
    End Sub
    Private Sub btnAddItemRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddItemRow.Click
        dgAddNewItem.Rows.Add()
    End Sub
    Private Sub btnNewItemRemoveRow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItemRemoveRow.Click
        If dgAddNewItem.Rows.Count = 0 Then
        Else
            dgAddNewItem.Rows.Remove(dgAddNewItem.CurrentRow)
        End If
    End Sub
    Private Sub lblEditExistingItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEditExistingItem.Click
        subEditItem()
        insertNewItem = False
    End Sub
    Private Sub subEditItem()
        lblEditExistingItem.ForeColor = Color.OrangeRed
        lblCreateNewItem.ForeColor = Color.Silver
        tbSearchEditExistItem.Visible = True
        cbSearchItemResult.Visible = True
        btnEditItem.Visible = True
        btnAddItemRow.Visible = False
        btnItemRemoveRow.Visible = False
    End Sub
    Private Sub subNewItem()
        lblEditExistingItem.ForeColor = Color.Silver
        lblCreateNewItem.ForeColor = Color.OrangeRed
        tbSearchEditExistItem.Visible = False
        cbSearchItemResult.Visible = False
        btnEditItem.Visible = False
        btnAddItemRow.Visible = True
        btnItemRemoveRow.Visible = True
        dgAddNewItem.Rows.Clear()
    End Sub
    Private Sub lblCreateNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblCreateNewItem.Click
        subNewItem()
        insertNewItem = True
    End Sub
    Private Sub btnEditItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditItem.Click
        If cbSearchItemResult.Text = "" Then
            Exit Sub
        End If

        Dim dt As DataTable
        dt = generateItemDetails(cbSearchItemResult.Text)

        If dgAddNewItem.Rows.Count = 0 Then
            dgAddNewItem.Rows.Add()
        End If

        dgAddNewItem.Rows(0).Cells(0).Value = dt.Rows(0).Item("itm_Code")
        dgAddNewItem.Rows(0).Cells(1).Value = dt.Rows(0).Item("itm_Desc")
        dgAddNewItem.Rows(0).Cells(2).Value = dt.Rows(0).Item("itm_Price")

        Dim arrOpen(1) As Double
        arrOpen = generateIOpenBalance(dt.Rows(0).Item("itm_Code"))

        dgAddNewItem.Rows(0).Cells(3).Value = arrOpen(0)
        dgAddNewItem.Rows(0).Cells(4).Value = arrOpen(1)
        dgAddNewItem.Rows(0).Cells(5).Value = dt.Rows(0).Item("itm_Unit")
        dgAddNewItem.Rows(0).Cells(6).Value = dt.Rows(0).Item("itm_Group")
        dgAddNewItem.Rows(0).Cells(7).Value = dt.Rows(0).Item("itm_Supplier")
        dgAddNewItem.Rows(0).Cells(8).Value = dt.Rows(0).Item("itm_Category")
        dgAddNewItem.Rows(0).Cells(9).Value = dt.Rows(0).Item("itm_Sub_Category")
        dgAddNewItem.Rows(0).Cells(10).Value = dt.Rows(0).Item("itm_Color")


    End Sub
End Class
