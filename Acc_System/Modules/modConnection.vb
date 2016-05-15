Imports MetroFramework
Imports System.Data.SqlClient
Imports System.Configuration

Module modConnection
    Public Function testConnect()
        Dim pass As Boolean = True
        Dim StringConnection As String = System.Configuration.ConfigurationManager. _
              ConnectionStrings("Acc_System.My.MySettings.ACCDBConnectionString").ConnectionString
        Dim cnnADODB As New SqlConnection
        Try
            cnnADODB.ConnectionString = StringConnection
            cnnADODB.Open()
        Catch ex As Exception
            'MsgBox(ex.Message.ToString)
            MetroMessageBox.Show(frmMain, "Data source not found. Please contact system administrator", _
                                 "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            pass = False
            Return pass
        End Try

        cnnADODB.Close()
        cnnADODB.Dispose()
        cnnADODB = Nothing

        Return pass
    End Function

    Public Function retriveString(ByVal cmdString As String) As String
        Dim StringConnection As String = System.Configuration.ConfigurationManager. _
            ConnectionStrings("Acc_System.My.MySettings.ACCDBConnectionString").ConnectionString
        Dim cnnADODB As New SqlConnection
        Dim cmdRead As New SqlCommand

        Dim reader As SqlDataReader
        Dim str As String

        Try
            cnnADODB.ConnectionString = StringConnection
            cnnADODB.Open()

            cmdRead.CommandText = cmdString
            cmdRead.CommandType = CommandType.Text
            cmdRead.Connection = cnnADODB
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        reader = cmdRead.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            str = reader.Item(0)
        Else
            str = ""
        End If

        cnnADODB.Close()

        cnnADODB.Dispose()

        Return str
    End Function
    Public Function retrieveTableFunction(ByVal cmdString As String) As DataTable
        Dim StringConnection As String = System.Configuration.ConfigurationManager. _
          ConnectionStrings("Acc_System.My.MySettings.ACCDBConnectionString").ConnectionString
        Dim cnnADODB As New SqlConnection

        Try
            cnnADODB.ConnectionString = StringConnection
            cnnADODB.Open()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Dim dbCommand As New SqlCommand(cmdString, cnnADODB)

        Dim dbDataAdapter As New SqlDataAdapter(dbCommand)
        Dim dbDataTable As New DataTable()
        Dim dtTable As DataTable
        dbDataAdapter.Fill(dbDataTable)
        dtTable = dbDataTable.Copy


        cnnADODB.Close()
        cnnADODB.Dispose()
        cnnADODB = Nothing
        dbCommand.Dispose()
        dbCommand = Nothing
        dbDataAdapter.Dispose()
        dbDataAdapter = Nothing

        'Release resources
        dbDataTable.Dispose()
        dbDataTable = Nothing

        Return dtTable

    End Function
    Public Sub saveVoucher(ByVal prefix As String, ByVal voucID As Integer, _
    ByVal voucDate As Date, ByVal vouchName As String, ByVal CostCenter As String, _
    ByVal accName As String, ByVal vouchAmount As Double, ByVal vouchDiscount As Double, _
    ByVal vouchNet As Double, ByVal vouchRef As String, ByVal voucLPO As String, _
    ByVal vouchQuot As String, ByVal voucNarr As String, ByVal vouDue As Date, _
    ByVal isPosted As Boolean, ByVal Reference_ID As String, ByVal curYear As Integer)

        Dim StringConnection As String = System.Configuration.ConfigurationManager. _
          ConnectionStrings("Acc_System.My.MySettings.ACCDBConnectionString").ConnectionString
        Dim cnnADODB As New SqlConnection

        Try
            cnnADODB.ConnectionString = StringConnection
            cnnADODB.Open()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Dim cmdString As String

        cmdString = "INSERT INTO tbVoucherTrans(Voucher_Prefix, Voucher_ID, Voucher_Date, Voucher_Name, " & _
        " Cost_Center, Account_Name, Voucher_Amount, Voucher_Discount, Voucher_Net,  " & _
        " Voucher_Reference, Voucher_LPO, Voucher_Narration, Voucher_Due,  isPosted, Reference_ID, Active_Year, Voucher_Quot) " & _
        " VALUES(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14, @p15, @p16, @p17)"

        Dim dbCommand As New SqlCommand(cmdString, cnnADODB)
        dbCommand.CommandType = CommandType.Text

        dbCommand.Parameters.AddWithValue("@p1", prefix)
        dbCommand.Parameters.AddWithValue("@p2", voucID)
        dbCommand.Parameters.AddWithValue("@p3", voucDate)
        dbCommand.Parameters.AddWithValue("@p4", vouchName)
        dbCommand.Parameters.AddWithValue("@p5", CostCenter)
        dbCommand.Parameters.AddWithValue("@p6", accName)
        dbCommand.Parameters.AddWithValue("@p7", vouchAmount)
        dbCommand.Parameters.AddWithValue("@p8", vouchDiscount)
        dbCommand.Parameters.AddWithValue("@p9", vouchNet)
        dbCommand.Parameters.AddWithValue("@p10", vouchRef)
        dbCommand.Parameters.AddWithValue("@p11", voucLPO)
        dbCommand.Parameters.AddWithValue("@p12", voucNarr)
        dbCommand.Parameters.AddWithValue("@p13", vouDue)
        dbCommand.Parameters.AddWithValue("@p14", isPosted)
        dbCommand.Parameters.AddWithValue("@p15", Reference_ID)
        dbCommand.Parameters.AddWithValue("@p16", curYear)
        dbCommand.Parameters.AddWithValue("@p17", vouchQuot)

        dbCommand.ExecuteNonQuery()
        dbCommand.Parameters.Clear()

        cnnADODB.Close()
        dbCommand.Dispose()
        cnnADODB.Dispose()

    End Sub
    Public Sub updateVoucher(ByVal voucDate As Date, ByVal CostCenter As String, _
    ByVal accName As String, ByVal vouchAmount As Double, ByVal vouchDiscount As Double, _
    ByVal vouchNet As Double, ByVal vouchRef As String, ByVal voucLPO As String, _
    ByVal vouchQuot As String, ByVal voucNarr As String, ByVal vouDue As Date, _
    ByVal isPosted As Boolean, ByVal Reference_ID As String, ByVal curYear As Integer)

        Dim StringConnection As String = System.Configuration.ConfigurationManager. _
        ConnectionStrings("Acc_System.My.MySettings.ACCDBConnectionString").ConnectionString
        Dim cnnADODB As New SqlConnection

        Try
            cnnADODB.ConnectionString = StringConnection
            cnnADODB.Open()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Dim cmdString As String

        cmdString = "UPDATE tbVoucherTrans SET(Voucher_Date," & _
        " Cost_Center, Account_Name, Voucher_Amount, Voucher_Discount, Voucher_Net,  " & _
        " Voucher_Reference, Voucher_LPO, Voucher_Narration, Voucher_Due,  isPosted, Reference_ID, Active_Year) " & _
        " VALUES(@p3, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14, @p15, @p16)"

        Dim dbCommand As New SqlCommand(cmdString, cnnADODB)
        dbCommand.CommandType = CommandType.Text

        dbCommand.Parameters.AddWithValue("@p3", voucDate)
        dbCommand.Parameters.AddWithValue("@p5", CostCenter)
        dbCommand.Parameters.AddWithValue("@p6", accName)
        dbCommand.Parameters.AddWithValue("@p7", vouchAmount)
        dbCommand.Parameters.AddWithValue("@p8", vouchDiscount)
        dbCommand.Parameters.AddWithValue("@p9", vouchNet)
        dbCommand.Parameters.AddWithValue("@p10", vouchRef)
        dbCommand.Parameters.AddWithValue("@p11", voucLPO)
        dbCommand.Parameters.AddWithValue("@p12", voucNarr)
        dbCommand.Parameters.AddWithValue("@p13", vouDue)
        dbCommand.Parameters.AddWithValue("@p14", isPosted)
        dbCommand.Parameters.AddWithValue("@p15", Reference_ID)
        dbCommand.Parameters.AddWithValue("@p16", curYear)

        dbCommand.ExecuteNonQuery()
        dbCommand.Parameters.Clear()

        cnnADODB.Close()
        dbCommand.Dispose()
        cnnADODB.Dispose()

    End Sub
    Public Sub saveAccount(ByVal vouchName As String, ByVal accName As String, _
    ByVal vouchDebit As Double, ByVal vouchCredit As Double, ByVal vouchBalance As Double, _
    ByVal voucDate As Date, ByVal voucDue As Date, ByVal isPosted As Boolean, _
    ByVal isOutstanding As Boolean, ByVal Reference_ID As String, ByVal curYear As Integer, _
    ByVal accCurrency As String, ByVal forex As Double, ByVal accountAs As String, ByVal accPos As Integer)

        Dim StringConnection As String = System.Configuration.ConfigurationManager. _
          ConnectionStrings("Acc_System.My.MySettings.ACCDBConnectionString").ConnectionString
        Dim cnnADODB As New SqlConnection

        Try
            cnnADODB.ConnectionString = StringConnection
            cnnADODB.Open()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Dim cmdString As String

        cmdString = "INSERT INTO tbAccountTrans( Voucher_Name, Account_Name, Voucher_Debit, Voucher_Credit, " & _
        " Voucher_Balance, Voucher_Date, Voucher_Due,  isPosted, isOutstanding, Reference_ID, Active_Year, " & _
        "Account_Currency, Exchange_Rate, Account_As, Account_Pos) " & _
        " VALUES(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14, @p15 )"

        Dim dbCommand As New SqlCommand(cmdString, cnnADODB)
        dbCommand.CommandType = CommandType.Text

        dbCommand.Parameters.AddWithValue("@p1", vouchName)
        dbCommand.Parameters.AddWithValue("@p2", accName)
        dbCommand.Parameters.AddWithValue("@p3", vouchDebit)
        dbCommand.Parameters.AddWithValue("@p4", vouchCredit)
        dbCommand.Parameters.AddWithValue("@p5", vouchBalance)
        dbCommand.Parameters.AddWithValue("@p6", voucDate)
        dbCommand.Parameters.AddWithValue("@p7", voucDue)
        dbCommand.Parameters.AddWithValue("@p8", isPosted)
        dbCommand.Parameters.AddWithValue("@p9", isOutstanding)
        dbCommand.Parameters.AddWithValue("@p10", Reference_ID)
        dbCommand.Parameters.AddWithValue("@p11", curYear)
        dbCommand.Parameters.AddWithValue("@p12", accCurrency)
        dbCommand.Parameters.AddWithValue("@p13", forex)
        dbCommand.Parameters.AddWithValue("@p14", accountAs)
        dbCommand.Parameters.AddWithValue("@p15", accPos)

        dbCommand.ExecuteNonQuery()
        dbCommand.Parameters.Clear()

        cnnADODB.Close()
        dbCommand.Dispose()
        cnnADODB.Dispose()

    End Sub
    Public Sub saveItemTrans(ByVal vouchName As String, ByVal Voucher_Date As Date, ByVal itm_Code As String, ByVal itm_Desc As String, _
    ByVal itm_Quantity As Double, ByVal itm_Unit As String, ByVal itm_Quantity_In As Double, ByVal itm_Quantity_Out As Double, _
    ByVal itm_Location As String, ByVal itm_Sell_Price As Double, ByVal itm_Total_Price As Double, ByVal itm_Cost As Double, _
    ByVal itm_Discount As Double, ByVal Account_Name As String, ByVal isPosted As Boolean, ByVal Reference_ID As String, _
    ByVal itm_Pos As Integer, ByVal curYear As Integer, ByVal itm_Total_Cost As Double, ByVal itm_Exp As Double)

        Dim StringConnection As String = System.Configuration.ConfigurationManager. _
          ConnectionStrings("Acc_System.My.MySettings.ACCDBConnectionString").ConnectionString
        Dim cnnADODB As New SqlConnection

        Try
            cnnADODB.ConnectionString = StringConnection
            cnnADODB.Open()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Dim cmdString As String

        cmdString = "INSERT INTO tbItemTrans(Voucher_Name, Voucher_Date, " & _
        " itm_Code, itm_Desc, itm_Quantity, itm_Unit, itm_Quantity_In, itm_Quantity_Out, itm_Location, " & _
        " itm_Sell_Price, itm_Total_Price, itm_Cost, itm_Discount, Account_Name, isPosted, Reference_ID, itm_Pos, Active_Year, itm_Total_Cost, itm_Expense) " & _
        " VALUES( @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, " & _
        " @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20, @p21, @p22)"

        Dim dbCommand As New SqlCommand(cmdString, cnnADODB)
        dbCommand.CommandType = CommandType.Text

        dbCommand.Parameters.AddWithValue("@p3", vouchName)
        dbCommand.Parameters.AddWithValue("@p4", Voucher_Date)
        dbCommand.Parameters.AddWithValue("@p5", itm_Code)
        dbCommand.Parameters.AddWithValue("@p6", itm_Desc)
        dbCommand.Parameters.AddWithValue("@p7", itm_Quantity)
        dbCommand.Parameters.AddWithValue("@p8", itm_Unit)
        dbCommand.Parameters.AddWithValue("@p9", itm_Quantity_In)
        dbCommand.Parameters.AddWithValue("@p10", itm_Quantity_Out)
        dbCommand.Parameters.AddWithValue("@p11", itm_Location)
        dbCommand.Parameters.AddWithValue("@p12", itm_Sell_Price)
        dbCommand.Parameters.AddWithValue("@p13", itm_Total_Price)
        dbCommand.Parameters.AddWithValue("@p14", itm_Cost)
        dbCommand.Parameters.AddWithValue("@p15", itm_Discount)
        dbCommand.Parameters.AddWithValue("@p16", Account_Name)
        dbCommand.Parameters.AddWithValue("@p17", isPosted)
        dbCommand.Parameters.AddWithValue("@p18", Reference_ID)
        dbCommand.Parameters.AddWithValue("@p19", itm_Pos)
        dbCommand.Parameters.AddWithValue("@p20", curYear)
        dbCommand.Parameters.AddWithValue("@p21", itm_Total_Cost)
        dbCommand.Parameters.AddWithValue("@p22", itm_Exp)

        dbCommand.ExecuteNonQuery()
        dbCommand.Parameters.Clear()

        cnnADODB.Close()
        dbCommand.Dispose()
        cnnADODB.Dispose()

    End Sub
    Public Sub saveNewItem(ByVal itm_Code As String, ByVal itm_Desc As String, _
    ByVal itm_Unit As String, ByVal itm_Group As String, ByVal itm_Supplier As String, ByVal itm_Price As Double, _
    ByVal itm_Color As String, ByVal itm_Category As String, ByVal itm_Sub_Category As String)

        Dim StringConnection As String = System.Configuration.ConfigurationManager. _
          ConnectionStrings("Acc_System.My.MySettings.ACCDBConnectionString").ConnectionString
        Dim cnnADODB As New SqlConnection

        Try
            cnnADODB.ConnectionString = StringConnection
            cnnADODB.Open()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Dim cmdString As String

        cmdString = "INSERT INTO tbItems(itm_Code, itm_Desc, itm_Unit, itm_Group, itm_Supplier, itm_Price, itm_Color, itm_Category, itm_Sub_Category )" & _
        " VALUES( @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9 )"

        Dim dbCommand As New SqlCommand(cmdString, cnnADODB)
        dbCommand.CommandType = CommandType.Text

        dbCommand.Parameters.AddWithValue("@p1", itm_Code)
        dbCommand.Parameters.AddWithValue("@p2", itm_Desc)
        dbCommand.Parameters.AddWithValue("@p3", itm_Unit)
        dbCommand.Parameters.AddWithValue("@p4", itm_Group)
        dbCommand.Parameters.AddWithValue("@p5", itm_Supplier)
        dbCommand.Parameters.AddWithValue("@p6", itm_Price)
        dbCommand.Parameters.AddWithValue("@p7", itm_Color)
        dbCommand.Parameters.AddWithValue("@p8", itm_Category)
        dbCommand.Parameters.AddWithValue("@p9", itm_Sub_Category)


        dbCommand.ExecuteNonQuery()
        dbCommand.Parameters.Clear()

        cnnADODB.Close()
        dbCommand.Dispose()
        cnnADODB.Dispose()

    End Sub
    Public Sub saveReference(ByVal Account_Name As String, ByVal Reference_ID As String, _
    ByVal asCRDR As String, ByVal Ref_Amount As Double, ByVal Ref_Balance As Double, _
    ByVal isOutstanding As Boolean, ByVal curYear As Integer)

        Dim StringConnection As String = System.Configuration.ConfigurationManager. _
          ConnectionStrings("Acc_System.My.MySettings.ACCDBConnectionString").ConnectionString
        Dim cnnADODB As New SqlConnection

        Try
            cnnADODB.ConnectionString = StringConnection
            cnnADODB.Open()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Dim cmdString As String

        cmdString = "INSERT INTO tbReference(Account_Name, Reference_ID, asCRDR, Reference_Amount, Reference_Balance, isOutstanding, Active_Year) " & _
        " VALUES(@p1, @p2, @p3, @p4, @p5, @p6, @p7)"

        Dim dbCommand As New SqlCommand(cmdString, cnnADODB)
        dbCommand.CommandType = CommandType.Text

        dbCommand.Parameters.AddWithValue("@p1", Account_Name)
        dbCommand.Parameters.AddWithValue("@p2", Reference_ID)
        dbCommand.Parameters.AddWithValue("@p3", asCRDR)
        dbCommand.Parameters.AddWithValue("@p4", Ref_Amount)
        dbCommand.Parameters.AddWithValue("@p5", Ref_Balance)
        dbCommand.Parameters.AddWithValue("@p6", isOutstanding)
        dbCommand.Parameters.AddWithValue("@p7", curYear)


        dbCommand.ExecuteNonQuery()
        dbCommand.Parameters.Clear()

        cnnADODB.Close()
        dbCommand.Dispose()
        cnnADODB.Dispose()

    End Sub
    Public Sub deleteTransaction(ByVal cmdString As String)

        Dim StringConnection As String = System.Configuration.ConfigurationManager. _
          ConnectionStrings("Acc_System.My.MySettings.ACCDBConnectionString").ConnectionString
        Dim cnnADODB As New SqlConnection

        Try
            cnnADODB.ConnectionString = StringConnection
            cnnADODB.Open()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Dim dbCommand As New SqlCommand(cmdString, cnnADODB)
        dbCommand.CommandType = CommandType.Text

        dbCommand.ExecuteNonQuery()
        dbCommand.Parameters.Clear()

        cnnADODB.Close()
        dbCommand.Dispose()
        cnnADODB.Dispose()

    End Sub
    Public Sub updateRecord(ByVal cmdString As String)
        Dim StringConnection As String = System.Configuration.ConfigurationManager. _
        ConnectionStrings("Acc_System.My.MySettings.ACCDBConnectionString").ConnectionString
        Dim cnnADODB As New SqlConnection

        Try
            cnnADODB.ConnectionString = StringConnection
            cnnADODB.Open()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Dim dbCommand As New SqlCommand(cmdString, cnnADODB)
        dbCommand.CommandType = CommandType.Text

        dbCommand.ExecuteNonQuery()
        dbCommand.Parameters.Clear()

        cnnADODB.Close()
        dbCommand.Dispose()
        cnnADODB.Dispose()
    End Sub
End Module
