Imports System.Data.SqlClient
Imports MSwordDllFiles
Public Class Sale_Inv
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Frm_Customers.ShowDialog()
    End Sub
    Public Sub Get_Customer()
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" select  *  from Customer_Tbl  where  Cus_ID=@Cus_ID", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Cus_ID", SqlDbType.Int).Value = Cus_ID.Text
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Cus_ID.Text = dr("Cus_ID").ToString
                    CusName.Text = dr("CusName").ToString
                    CusPhone.Text = dr("CusPhone").ToString
                    ToHim.Text = dr("ToHim").ToString
                    Onhim.Text = dr("Onhim").ToString
                End While
                dr.Close()
                Con.Close()
            Else
                MsgBox("رقم العميل الذي قمت بادخاله غير موجود")
                Cus_ID.Text = ""
            End If

        Catch ex As Exception
            MessageBox.Show("هناك خطاء الرجاء التاكد !" + ex.Message)
            Con.Close()
        End Try
    End Sub

    Private Sub Cus_ID_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles Cus_ID.PreviewKeyDown
        Get_Customer()
    End Sub

    Public Sub Get_CustomerPhone()
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" select  *  from Customer_Tbl  where  CusPhone=@CusPhone", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@CusPhone", SqlDbType.VarChar).Value = CusPhone.Text
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.HasRows Then

                While dr.Read
                    Cus_ID.Text = dr("Cus_ID").ToString
                    CusName.Text = dr("CusName").ToString
                    CusPhone.Text = dr("CusPhone").ToString
                    ToHim.Text = dr("ToHim").ToString
                    Onhim.Text = dr("Onhim").ToString
                End While
                dr.Close()
                Con.Close()
            Else
                MsgBox("رقم العميل الذي قمت بادخاله غير موجود")
                Cus_ID.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show("هناك خطاء الرجاء التاكد !" + ex.Message)
            Con.Close()
        End Try
    End Sub

    Private Sub CusPhone_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles CusPhone.PreviewKeyDown
        Get_CustomerPhone()
    End Sub

    Private Sub Sale_Inv_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Get_Tax()
        Sale_ID.Text = Max_ID("Sale_Tbl", "Sale_ID") + 10100
    End Sub
    Public Sub Get_Tax()
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from Tax_Tbl where Tax_ID = 1", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                TaxValue.Text = dr("TaxValue").ToString
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            MessageBox.Show("هناك خطاء الرجاء التاكد !" + ex.Message)
            Con.Close()
        End Try
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Frm_Store.ShowDialog()
    End Sub
 
    Public Sub Insert_By_ID()
        For i As Integer = 0 To dgvSale.Rows.Count - 1
            If dgvSale.Rows(i).Cells(0).Value = Prd_ID.Text Then
                If MessageBox.Show("هذه المادة موجودة مسبقا هل تريد تحديث الكمية لنفس المادة واضافتها  للفاتورة", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                    Exit Sub

                End If
            End If


        Next

                Dim x As Integer
                Try
                    If Con.State = 1 Then Con.Close()
                    Con.Open()
                    Dim cmd As New SqlCommand(" select  *  from View_Store  where  Prd_ID=@Prd_ID", Con)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@Prd_ID", SqlDbType.Int).Value = Prd_ID.Text
                    Dim adp As New SqlDataAdapter(cmd)
                    Dim dr As SqlDataReader
                    dr = cmd.ExecuteReader
                    If dr.HasRows Then
                While dr.Read

                    dgvSale.Rows.Add()
                    x = dgvSale.Rows.Count - 1

                    dgvSale(0, x).Value = dr("Prd_ID").ToString
                    dgvSale(1, x).Value = dr("Prd_Code").ToString
                    dgvSale(2, x).Value = dr("Prd_Name").ToString
                    dgvSale(3, x).Value = dr("UnitName").ToString
                    dgvSale(4, x).Value = dr("SellPrice").ToString
                End While
                        dr.Close()
                        Con.Close()

                    Else
                        MsgBox("رقم المنتج الذي قمت بادخاله غير موجود")
                    End If

                Catch ex As Exception
                    Con.Close()
            MessageBox.Show("هناك خطاء الرجاء التاكد !" + ex.Message)
        End Try
         
    End Sub



    Public Sub Insert_By_ID_2()
        For i As Integer = 0 To dgvSale.Rows.Count - 1
            If dgvSale.Rows(i).Cells(1).Value = Prd_Code.Text Then
                MsgBox(" المنتج المراد ادخاله تم اضافته للفاتورة مسبقا")
                Exit Sub
            End If
        Next

        Dim x As Integer
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" select  *  from View_Store  where Prd_Code=@Prd_Code ", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Prd_Code", SqlDbType.VarChar).Value = Prd_Code.Text
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    dgvSale.Rows.Add()
                    x = dgvSale.Rows.Count - 1
                    dgvSale(0, x).Value = dr("Prd_ID").ToString
                    dgvSale(1, x).Value = dr("Prd_Code").ToString
                    dgvSale(2, x).Value = dr("Prd_Name").ToString
                    dgvSale(3, x).Value = dr("UnitName").ToString
                    dgvSale(4, x).Value = dr("SellPrice").ToString
                End While
                dr.Close()
                Con.Close()

            Else
                MsgBox("رقم المنتج الذي قمت بادخاله غير موجود")
            End If

        Catch ex As Exception
            MessageBox.Show("هناك خطاء الرجاء التاكد !" + ex.Message)
            Con.Close()
        End Try
    End Sub

    Private Sub Prd_Code_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles Prd_Code.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            Insert_By_ID_2()
            Prd_Code.Text = ""
        End If

    End Sub

    Public Sub Insert_Sale_Tbl(ByVal Sale_ID As Int32, ByVal Sale_Date As Date, ByVal Inv_Type As String, ByVal SalesMan As String, ByVal Cus_ID As Int32, ByVal Item_Count As Int32, ByVal Total As Double, ByVal Tax_Per As Double, ByVal TaxTotal As Double, ByVal Discount_Per As Double, ByVal DiscountTotal As Double, ByVal FinalTotal As Double, ByVal Paid As Double, ByVal UnPaid As Double)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Insert Into Sale_Tbl ( Sale_ID,Sale_Date,Inv_Type,SalesMan,Cus_ID,Item_Count,Total,Tax_Per,TaxTotal,Discount_Per,DiscountTotal,FinalTotal,Paid,UnPaid)values(@Sale_ID,@Sale_Date,@Inv_Type,@SalesMan,@Cus_ID,@Item_Count,@Total,@Tax_Per,@TaxTotal,@Discount_Per,@DiscountTotal,@FinalTotal,@Paid,@UnPaid)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Sale_ID", SqlDbType.Int).Value = Sale_ID
                .Parameters.AddWithValue("@Sale_Date", SqlDbType.Date).Value = Sale_Date
                .Parameters.AddWithValue("@Inv_Type", SqlDbType.VarChar).Value = Inv_Type
                .Parameters.AddWithValue("@SalesMan", SqlDbType.VarChar).Value = SalesMan
                .Parameters.AddWithValue("@Cus_ID", SqlDbType.Int).Value = Cus_ID
                .Parameters.AddWithValue("@Item_Count", SqlDbType.Int).Value = Item_Count
                .Parameters.AddWithValue("@Total", SqlDbType.Decimal).Value = Total
                .Parameters.AddWithValue("@Tax_Per", SqlDbType.Decimal).Value = Tax_Per
                .Parameters.AddWithValue("@TaxTotal", SqlDbType.Decimal).Value = TaxTotal
                .Parameters.AddWithValue("@Discount_Per", SqlDbType.Decimal).Value = Discount_Per
                .Parameters.AddWithValue("@DiscountTotal", SqlDbType.Decimal).Value = DiscountTotal
                .Parameters.AddWithValue("@FinalTotal", SqlDbType.Decimal).Value = FinalTotal
                .Parameters.AddWithValue("@Paid", SqlDbType.Decimal).Value = Paid
                .Parameters.AddWithValue("@UnPaid", SqlDbType.Decimal).Value = UnPaid
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
            Cmd = Nothing
        Catch ex As Exception
            MessageBox.Show("هناك خطاء الرجاء التاكد !" + ex.Message)
        End Try

    End Sub



    Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click
        Try
            Total.Text = Val(Total.Text) + Val(DiscountTotal.Text)
            Insert_Sale_Tbl(Sale_ID.Text, Sale_Date.Value, Inv_Type.Text, SalesMan.Text, Cus_ID.Text, Item_Count.Text, Total.Text, TaxValue.Text, TaxTotal.Text, DiscountValue.Text, DiscountTotal.Text, FinalTotal.Text, Paid.Text, UnPaid.Text)
            Insert_Sale_Details_Tbl()
            UpdateStore()
            Update_Cus_Balance()
            Insert_Cus_Move_Tbl(Sale_Date.Value, Cus_ID.Text, "فاتورة مبيعات", FinalTotal.Text, Paid.Text, UnPaid.Text, SalesMan.Text)
        Catch ex As Exception

            MessageBox.Show("هناك خطاء الرجاء التاكد !" + ex.Message)
        End Try


    End Sub

    Public Sub Insert_Sale_Details_Tbl()
        For i As Integer = 0 To dgvSale.Rows.Count - 1
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Insert Into Sale_Details_Tbl ( Sale_ID,Prd_ID,SalePrice,Qty,TotalAmount)values(@Sale_ID,@Prd_ID,@SalePrice,@Qty,@TotalAmount)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Sale_ID", SqlDbType.Int).Value = Sale_ID.Text
                .Parameters.AddWithValue("@Prd_ID", SqlDbType.Int).Value = dgvSale.Rows(i).Cells(0).Value
                .Parameters.AddWithValue("@SalePrice", SqlDbType.Decimal).Value = dgvSale.Rows(i).Cells(4).Value
                .Parameters.AddWithValue("@Qty", SqlDbType.Int).Value = dgvSale.Rows(i).Cells(5).Value
                .Parameters.AddWithValue("@TotalAmount", SqlDbType.Decimal).Value = dgvSale.Rows(i).Cells(6).Value
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()

            Cmd = Nothing

        Next
        MsgBox("تم إضافة فاتورة المبيعات بنجاح ", MsgBoxStyle.Information, "حفظ")
    End Sub

    Public Sub UpdateStore()
        For i As Integer = 0 To dgvSale.Rows.Count - 1
            Dim cmd1 As New SqlCommand("select * from Store_Tbl where Prd_ID =@Prd_ID ", Con)
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("@Prd_ID", SqlDbType.Int).Value = dgvSale.Rows(i).Cells(0).Value
            Dim dt As New DataTable
            Dim adp As New SqlDataAdapter(cmd1)
            adp.Fill(dt)
            If dt.Rows.Count > 0 Then
                Dim Cmd2 As New SqlCommand
                With Cmd2
                    .Connection = Con
                    .CommandType = CommandType.Text
                    .CommandText = "Update Store_Tbl Set Qty = Qty - " & dgvSale.Rows(i).Cells(5).Value & " Where Prd_ID = @Prd_ID"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Prd_ID", SqlDbType.Int).Value = dgvSale.Rows(i).Cells(0).Value
                End With
                If Con.State = 1 Then Con.Close()
                Con.Open()
                Cmd2.ExecuteNonQuery()
                Con.Close()
                Cmd2 = Nothing

            End If
        Next
        MsgBox("تم تعديل الكميات  في المستودع بنجاح", MsgBoxStyle.Information, "تعديل")
    End Sub

    Private Sub dgvSale_CellLeave(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSale.CellLeave
        If e.ColumnIndex = 5 Then
            dgvSale.CurrentRow.Cells(6).Value = dgvSale.CurrentRow.Cells(4).Value * dgvSale.CurrentRow.Cells(5).Value
        End If
        Item_Count.Text = dgvSale.RowCount
        InvoiceTotal()
    End Sub

    Public Sub InvoiceTotal()
        Dim Total1 As Decimal = "0.00"
        For Each row As DataGridViewRow In dgvSale.Rows
            Total1 += row.Cells(6).Value
        Next
        Total.Text = Total1
    End Sub

    Private Sub dgvSale_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dgvSale.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{left}")
        End If
    End Sub

    Private Sub dgvSale_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSale.CellEndEdit
        Check_Limit()
        If QtyLimit < dgvSale.CurrentRow.Cells(5).Value Then
            MsgBox("الكمية المراد ادخالها غير متوفرة بالمستودع")
            dgvSale.CurrentRow.Cells(5).Value = ""
        Else
            SendKeys.Send("{left}")
        End If

    End Sub
    Public QtyLimit As Integer
    Public Sub Check_Limit()
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Dim cmd As New SqlCommand(" select  Qty  from View_Store  where  Prd_ID=@Prd_ID", Con)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@Prd_ID", SqlDbType.Int).Value = dgvSale.CurrentRow.Cells(0).Value.ToString
        Dim adp As New SqlDataAdapter(cmd)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            QtyLimit = dr("Qty").ToString()
        End While
        dr.Close()
        Con.Close()
    End Sub
    Private Sub DiscountValue_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles DiscountValue.KeyDown
        If e.KeyCode = Keys.Enter Then
            DiscountTotal.Text = Val(DiscountValue.Text) * Val(Total.Text) / 100
            Total.Text = Val(Total.Text) - Val(DiscountTotal.Text)
            TaxTotal.Text = Val(Total.Text) * Val(TaxValue.Text) / 100
            FinalTotal.Text = Val(Total.Text) + Val(TaxTotal.Text)
            Paid.Select()
        End If
    End Sub

    Private Sub Paid_TextChanged(sender As System.Object, e As System.EventArgs) Handles Paid.TextChanged
        UnPaid.Text = Val(FinalTotal.Text) - Val(Paid.Text)
    End Sub

    Public Sub Update_Cus_Balance()

        Dim Cmd2 As New SqlCommand
        With Cmd2
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Customer_Tbl Set Onhim = Onhim + " & UnPaid.Text & " Where Cus_ID = @Cus_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Cus_ID", SqlDbType.Int).Value = Cus_ID.Text
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd2.ExecuteNonQuery()
        Con.Close()
        Cmd2 = Nothing
    End Sub

    Public Sub Print()

        Try
            '--------------------------------------------------------------
            ' مهم جداً أن تستدعي هذا الأمر قبل كتابة أي سطر برمجي يخص الطباعة
            MSO.SetDllFiles()
            '--------------------------------------------------------------
            Dim MyWord As MSO.MSWord
            MyWord = New MSO.MSWord(Me)

            Dim TemplatePath As String = My.Application.Info.DirectoryPath & "\sale.dotx"

            Dim TemplateInfo As New MSO.TemplateInfo(TemplatePath)
            With TemplateInfo
                '-------------------------------------
                .Caption = " فاتورة مبيعات"
                .PrintJob = GetPrintableJob()
                With .ViewOptions
                    '-------------------------------------
                    .ShowBookmarks = False
                    .ShowTableGridlines = False
                    .ArabicNumeral = MSO.Enums.MSArabicNumeral.NumeralContext
                    .DisplayPageBoundaries = True
                    .NormalViewDisplayRulers = True
                    .ViewType = MSO.Enums.MSViewType.PrintPreview
                    .WindowState = MSO.Enums.MSWindowState.Maximize
                    .NormalViewZoomPageFit = MSO.Enums.MSPageFit.PageFitBestFit
                    .NormalViewZoomPercentage = Nothing
                    '------------------------
                    .PrintPreviewDisplayRulers = True
                    .PrintPreviewPageFitness = New MSO.PrintPreviewPageFitness(0, 0)
                    .PrintPreviewZoomPageFit = MSO.Enums.MSPageFit.PageFitBestFit
                    .PrintPreviewZoomPercentage = Nothing
                    '-------------------------------------
                End With
            End With
            MyWord.AddNewTemplateInfo(TemplateInfo)
            '---------------------------------------
            'MyWord.PrintOut()
            MyWord.PrintPreview()

        Catch ex As Exception
            MessageBox.Show("هناك خطاء الرجاء التاكد !" + ex.Message)
            MSO.PrintingProcess.ShowErrorMsgAndClose(ex.Message)
        End Try

    End Sub
    Private Function GetPrintableJob() As MSO.Printing.PrintJob

        Dim PrintJob As New MSO.Printing.PrintJob

        With PrintJob
            '    '####################################################################################
            .AddText(Sale_ID.Text, "Sale_ID")
            .AddText(Sale_Date.Value.Date, "Sale_Date")
            .AddText(Inv_Type.Text, "Inv_Type")
            .AddText(Cus_ID.Text, "Cus_ID")
            .AddText(CusName.Text, "CusName")
            .AddText(CusPhone.Text, "CusPhone")
            .AddText(SalesMan.Text, "SalesMan")
            .AddText(Total.Text, "Total")
            .AddText(Item_Count.Text, "Item_Count")
            ' .AddText(TaxValue.Text, "Tax_Per")
            ' .AddText(DiscountValue.Text, "Discount_Per")
            ' .AddText(TaxTotal.Text, "TaxTotal")
            ' .AddText(DiscountTotal.Text, "DiscountTotal")
            .AddText(FinalTotal.Text, "FinalTotal")
            .AddText(Paid.Text, "Paid")
            .AddText(UnPaid.Text, "UnPaid")
            With .AddTable()
                .DataTable = Get_All_Prd()
                '-------------------------------------
                '.MinimumRowsAtTheBeginningOfTable = 3
                .IsFirstColumnAutoNumber = False
                .TableHeadBookMarkName = "TableHead_1"
                .TableHeadBookMarkName = "Head_2"
                .TableHeadBookMarkName = "Head_3"
                .FirstRowBookMarkName = "TableFirstRow_1"
                .DeleteTableIfNoData = False
                '-------------------------------------
                .AddTextColumn("Prd_ID")
                .AddTextColumn("Prd_Code")
                .AddTextColumn("Prd_Name")
                .AddTextColumn("SalePrice")
                .AddTextColumn("Qty")
                .AddTextColumn("TotalAmount")
            End With
        End With


        Return PrintJob
    End Function
    Public Function Get_All_Prd()
        Con.Open()
        Dim dt1 As New DataTable
        Dim cmd As New SqlCommand("Select * From View_Sale_Inv where Sale_ID=@Sale_ID", Con)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@Sale_ID", SqlDbType.Int).Value = Sale_ID.Text
        Dim adp As New SqlDataAdapter(cmd)
        adp.Fill(dt1)
        Con.Close()
        Return dt1
    End Function

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Print()
    End Sub

    Private Sub BtnNew_Click(sender As System.Object, e As System.EventArgs) Handles BtnNew.Click
        reset()
    End Sub

    Public Sub reset()
        dgvSale.Rows.Clear()
        Me.Sale_ID.Text = vbNullString
        Me.Sale_Date.Value = Today
        Me.Inv_Type.Text = vbNullString
        Me.Cus_ID.Text = vbNullString
        Me.CusName.Text = vbNullString
        Me.CusPhone.Text = vbNullString
        Me.ToHim.Text = vbNullString
        Me.Onhim.Text = vbNullString
        Me.TaxTotal.Text = vbNullString
        Me.DiscountTotal.Text = vbNullString
        Me.DiscountValue.Text = vbNullString
        Me.FinalTotal.Text = vbNullString
        Me.Paid.Text = vbNullString
        Me.UnPaid.Text = vbNullString
        Me.Total.Text = vbNullString
        Item_Count.Text = 0
        Get_Tax()
        Sale_ID.Text = Max_ID("Sale_Tbl", "Sale_ID") + 1000
    End Sub

    Public Sub Insert_Cus_Move_Tbl(ByVal Move_Date As Date, ByVal Cus_ID As Int32, ByVal Move_Type As String, ByVal Move_Total As Double, ByVal Paid As Double, ByVal UnPaid As Double, ByVal SalesMan As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Cus_Move_Tbl ( Move_Date,Cus_ID,Move_Type,Move_Total,Paid,UnPaid,SalesMan)values(@Move_Date,@Cus_ID,@Move_Type,@Move_Total,@Paid,@UnPaid,@SalesMan)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Move_Date", SqlDbType.Date).Value = Move_Date
            .Parameters.AddWithValue("@Cus_ID", SqlDbType.Int).Value = Cus_ID
            .Parameters.AddWithValue("@Move_Type", SqlDbType.varchar).Value = Move_Type
            .Parameters.AddWithValue("@Move_Total", SqlDbType.Decimal).Value = Move_Total
            .Parameters.AddWithValue("@Paid", SqlDbType.Decimal).Value = Paid
            .Parameters.AddWithValue("@UnPaid", SqlDbType.Decimal).Value = UnPaid
            .Parameters.AddWithValue("@SalesMan", SqlDbType.varchar).Value = SalesMan
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try

            Con.Open()
            Dim cmd As New SqlCommand(" select  *  from Customer_Tbl  where CusName+convert(varchar,Cus_ID) like '%" + Cus_ID.Text + "%'", Con)
            cmd.Parameters.Clear()
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.HasRows Then

                While dr.Read
                    Cus_ID.Text = dr("Cus_ID").ToString
                    CusName.Text = dr("CusName").ToString
                    CusPhone.Text = dr("CusPhone").ToString
                    ToHim.Text = dr("ToHim").ToString
                    Onhim.Text = dr("Onhim").ToString
                End While
                dr.Close()

            Else
                MsgBox("رقم العميل الذي قمت بادخاله غير موجود")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

            Con.Close()

        End Try
    End Sub

    Private Sub SalesMan_KeyDown(sender As Object, e As KeyEventArgs) Handles SalesMan.KeyDown
        If e.KeyCode = Keys.Enter Then
            Inv_Type.Select()
        End If
    End Sub

    Private Sub Inv_Type_KeyDown(sender As Object, e As KeyEventArgs) Handles Inv_Type.KeyDown
        If e.KeyCode = Keys.Enter Then
            Prd_ID.Select()
        End If
    End Sub

    Private Sub Prd_ID_KeyDown(sender As Object, e As KeyEventArgs) Handles Prd_ID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Insert_By_ID()
            Prd_ID.Text = ""
        End If
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class