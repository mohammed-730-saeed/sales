Imports System.Data.SqlClient
Imports MSwordDllFiles

Public Class Buy_Inv
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Frm_Products.ShowDialog()
    End Sub
    Private Sub dgv_buy_CellLeave(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_buy.CellLeave
        If e.ColumnIndex = 6 Then
            dgv_buy.CurrentRow.Cells(7).Value = dgv_buy.CurrentRow.Cells(4).Value * dgv_buy.CurrentRow.Cells(6).Value
        End If
        Item_Count.Text = dgv_buy.RowCount
        InvoiceTotal()
    End Sub
    Public Sub InvoiceTotal()
        Dim Total1 As Decimal = "0.00"
        For Each row As DataGridViewRow In dgv_buy.Rows
            Total1 += row.Cells(7).Value
        Next
        Total.Text = Total1
        FinalTotal.Text = Total1
    End Sub
    Private Sub dgv_buy_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dgv_buy.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{left}")
        End If
    End Sub
    Private Sub dgv_buy_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_buy.CellEndEdit
        SendKeys.Send("{left}")
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
            Con.Close()
        End Try
    End Sub
    Private Sub Buy_Inv_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Get_Tax()
        Buy_ID.Text = Max_ID("Buy_Tbl", "Buy_ID") + 10112
        ImpName.Focus()
    End Sub
    Private Sub DiscountValue_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles DiscountValue.KeyDown
        If e.KeyCode = Keys.Enter Then
            DiscountTotal.Text = Val(DiscountValue.Text) * Val(Total.Text) / 100
            Total.Text = Val(Total.Text) - Val(DiscountTotal.Text)
            TaxTotal.Text = Val(Total.Text) * Val(TaxValue.Text) / 100
            FinalTotal.Text = Val(Total.Text) + Val(TaxTotal.Text)
        End If
    End Sub
    Public Sub InsertStore()
        For i As Integer = 0 To dgv_buy.Rows.Count - 1
            Dim cmd1 As New SqlCommand("select * from Store_Tbl where Prd_ID =@Prd_ID ", Con)
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("@Prd_ID", SqlDbType.Int).Value = dgv_buy.Rows(i).Cells(0).Value
            Dim dt As New DataTable
            Dim adp As New SqlDataAdapter(cmd1)
            adp.Fill(dt)
            If dt.Rows.Count > 0 Then
                Dim Cmd2 As New SqlCommand
                With Cmd2
                    .Connection = Con
                    .CommandType = CommandType.Text
                    .CommandText = "Update Store_Tbl Set Qty = Qty + " & dgv_buy.Rows(i).Cells(6).Value & " Where Prd_ID = @Prd_ID"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Prd_ID", SqlDbType.Int).Value = dgv_buy.Rows(i).Cells(0).Value
                End With
                If Con.State = 1 Then Con.Close()
                Con.Open()
                Cmd2.ExecuteNonQuery()
                Con.Close()
                Cmd2 = Nothing
            Else
                Dim Cmd3 As New SqlCommand
                With Cmd3
                    .Connection = Con
                    .CommandType = CommandType.Text
                    .CommandText = "Insert Into Store_Tbl ( Prd_ID,Qty,BuyPrice,SellPrice)values(@Prd_ID,@Qty,@BuyPrice,@SellPrice)"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Prd_ID", SqlDbType.Int).Value = dgv_buy.Rows(i).Cells(0).Value
                    .Parameters.AddWithValue("@Qty", SqlDbType.VarChar).Value = dgv_buy.Rows(i).Cells(6).Value
                    .Parameters.AddWithValue("@BuyPrice", SqlDbType.Decimal).Value = dgv_buy.Rows(i).Cells(4).Value
                    .Parameters.AddWithValue("@SellPrice", SqlDbType.Decimal).Value = dgv_buy.Rows(i).Cells(5).Value
                End With
                If Con.State = 1 Then Con.Close()
                Con.Open()
                Cmd3.ExecuteNonQuery()
                Con.Close()
                Cmd3 = Nothing
            End If
        Next
        MsgBox("تم اضافة الكميات الى رصيد المستودع بنجاح", MsgBoxStyle.Information, "تعديل")
    End Sub
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Frm_Importers.ShowDialog()
    End Sub
    Public Sub Get_Imp()
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" select  *  from Importers_Tbl  where  Imp_ID=@Imp_ID", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Imp_ID", SqlDbType.Int).Value = Imp_ID.Text
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.HasRows Then

                While dr.Read
                    Imp_ID.Text = dr("Imp_ID").ToString
                    ImpName.Text = dr("ImpName").ToString
                    ImpPhone.Text = dr("ImpPhone").ToString
                    ToHim.Text = dr("ToHim").ToString
                    Onhim.Text = dr("Onhim").ToString
                End While
                dr.Close()
                Con.Close()
            Else
                MsgBox("رقم المورد الذي قمت بادخاله غير موجود")
                Imp_ID.Text = ""
            End If

        Catch ex As Exception
            Con.Close()
        End Try
    End Sub
    Public Sub Insert_By_ID()
        For i As Integer = 0 To dgv_buy.Rows.Count - 1
            If dgv_buy.Rows(i).Cells(0).Value = Prd_ID.Text Then
                MsgBox(" المنتج المراد ادخاله تم اضافته للفاتورة مسبقا")
                Exit Sub
            End If
        Next
       
        Dim x As Integer
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" select  *  from View_AllPrd  where  Prd_ID=@Prd_ID", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Prd_ID", SqlDbType.Int).Value = Prd_ID.Text
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    dgv_buy.Rows.Add()
                    x = dgv_buy.Rows.Count - 1
                    dgv_buy(0, x).Value = dr("Prd_ID").ToString
                    dgv_buy(1, x).Value = dr("Prd_Code").ToString
                    dgv_buy(2, x).Value = dr("Prd_Name").ToString
                    dgv_buy(3, x).Value = dr("UnitName").ToString
                End While
                dr.Close()
                Con.Close()

            Else
                MsgBox("رقم المنتج الذي قمت بادخاله غير موجود")
            End If

        Catch ex As Exception
            Con.Close()
        End Try
    End Sub
    Private Sub Prd_ID_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles Prd_ID.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            Insert_By_ID()
            Prd_ID.Text = ""
        End If
    End Sub
    Private Sub Paid_TextChanged(sender As System.Object, e As System.EventArgs) Handles Paid.TextChanged
        UnPaid.Text = Val(FinalTotal.Text) - Val(Paid.Text)
    End Sub
    Public Sub Insert_Buy_Tbl(ByVal Buy_ID As Int32, ByVal Buy_Date As Date, ByVal Imp_Inv_No As String, ByVal Inv_Type As String, ByVal SalesMan As String, ByVal Imp_ID As Int32, ByVal Item_Count As Int32, ByVal Total As Double, ByVal Tax_Per As Double, ByVal TaxTotal As Double, ByVal Discount_Per As Double, ByVal DiscountTotal As Double, ByVal FinalTotal As Double, ByVal Paid As Double, ByVal UnPaid As Double)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Buy_Tbl ( Buy_ID,Buy_Date,Imp_Inv_No,Inv_Type,SalesMan,Imp_ID,Item_Count,Total,Tax_Per,TaxTotal,Discount_Per,DiscountTotal,FinalTotal,Paid,UnPaid)values(@Buy_ID,@Buy_Date,@Imp_Inv_No,@Inv_Type,@SalesMan,@Imp_ID,@Item_Count,@Total,@Tax_Per,@TaxTotal,@Discount_Per,@DiscountTotal,@FinalTotal,@Paid,@UnPaid)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Buy_ID", SqlDbType.Int).Value = Buy_ID
            .Parameters.AddWithValue("@Buy_Date", SqlDbType.Date).Value = Buy_Date
            .Parameters.AddWithValue("@Imp_Inv_No", SqlDbType.VarChar).Value = Imp_Inv_No
            .Parameters.AddWithValue("@Inv_Type", SqlDbType.VarChar).Value = Inv_Type
            .Parameters.AddWithValue("@SalesMan", SqlDbType.VarChar).Value = SalesMan
            .Parameters.AddWithValue("@Imp_ID", SqlDbType.Int).Value = Imp_ID
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
        Cmd = Nothing
    End Sub
    Public Sub Insert_Buy_Details_Tbl()
        For i As Integer = 0 To dgv_buy.Rows.Count - 1
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Insert Into Buy_Details_Tbl ( Buy_ID,Prd_ID,BuyPrice,Qty,TotalAmount)values(@Buy_ID,@Prd_ID,@BuyPrice,@Qty,@TotalAmount)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Buy_ID", SqlDbType.Int).Value = Buy_ID.Text
                .Parameters.AddWithValue("@Prd_ID", SqlDbType.Int).Value = dgv_buy.Rows(i).Cells(0).Value
                .Parameters.AddWithValue("@BuyPrice", SqlDbType.Decimal).Value = dgv_buy.Rows(i).Cells(4).Value
                .Parameters.AddWithValue("@Qty", SqlDbType.Int).Value = dgv_buy.Rows(i).Cells(6).Value
                .Parameters.AddWithValue("@TotalAmount", SqlDbType.Decimal).Value = dgv_buy.Rows(i).Cells(7).Value
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()

            Cmd = Nothing

        Next
        MsgBox("تم إضافة فاتورة المشتريات بنجاح ", MsgBoxStyle.Information, "حفظ")
    End Sub
    Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click, BtnClose.Click
        Total.Text = Val(Total.Text) + Val(DiscountTotal.Text)
        Insert_Buy_Tbl(Buy_ID.Text, Buy_Date.Value, Imp_Inv_No.Text, Inv_Type.Text, SalesMan.Text, Imp_ID.Text, Item_Count.Text, Total.Text, TaxValue.Text, TaxTotal.Text, DiscountValue.Text, DiscountTotal.Text, FinalTotal.Text, Paid.Text, UnPaid.Text)
        Insert_Buy_Details_Tbl()
        InsertStore()
        Update_Imp_Balance()
        Insert_Imp_Move(Buy_Date.Value, Imp_ID.Text, "فاتورة شراء", FinalTotal.Text, Paid.Text, UnPaid.Text, SalesMan.Text)
    End Sub

    Public Sub Insert_Imp_Move(ByVal Move_Date As Date, ByVal Imp_ID As Int32, ByVal Move_Type As String, ByVal Move_Total As Double, ByVal Paid As Double, ByVal UnPaid As Double, ByVal SalesMan As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Imp_Move ( Move_Date,Imp_ID,Move_Type,Move_Total,Paid,UnPaid,SalesMan)values(@Move_Date,@Imp_ID,@Move_Type,@Move_Total,@Paid,@UnPaid,@SalesMan)"
            .Parameters.Clear()

            .Parameters.AddWithValue("@Move_Date", SqlDbType.Date).Value = Move_Date
            .Parameters.AddWithValue("@Imp_ID", SqlDbType.Int).Value = Imp_ID
            .Parameters.AddWithValue("@Move_Type", SqlDbType.VarChar).Value = Move_Type
            .Parameters.AddWithValue("@Move_Total", SqlDbType.Decimal).Value = Move_Total
            .Parameters.AddWithValue("@Paid", SqlDbType.Decimal).Value = Paid
            .Parameters.AddWithValue("@UnPaid", SqlDbType.Decimal).Value = UnPaid
            .Parameters.AddWithValue("@SalesMan", SqlDbType.VarChar).Value = SalesMan
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Public Sub reset()
        dgv_buy.Rows.Clear()
        Me.Buy_ID.Text = vbNullString
        Me.Buy_Date.Value = Today
        Me.Imp_Inv_No.Text = vbNullString
        Me.Inv_Type.Text = vbNullString
        Me.Imp_ID.Text = vbNullString
        Me.ImpName.Text = vbNullString
        Me.ImpPhone.Text = vbNullString
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
        Buy_ID.Text = Max_ID("Buy_Tbl", "Buy_ID") + 10112
    End Sub
    Private Sub BtnNew_Click(sender As System.Object, e As System.EventArgs) Handles BtnNew.Click
        reset()
    End Sub
    Private Sub Imp_ID_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles Imp_ID.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            Get_Imp()
        End If
    End Sub
    Public Sub Print()
        Try
            '--------------------------------------------------------------
            ' مهم جداً أن تستدعي هذا الأمر قبل كتابة أي سطر برمجي يخص الطباعة
            MSO.SetDllFiles()
            '--------------------------------------------------------------
            Dim MyWord As MSO.MSWord
            MyWord = New MSO.MSWord(Me)

            Dim TemplatePath As String = My.Application.Info.DirectoryPath & "\buy.dotx"

            Dim TemplateInfo As New MSO.TemplateInfo(TemplatePath)
            With TemplateInfo
                '-------------------------------------
                .Caption = " فاتورة مشتريات"
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
            MSO.PrintingProcess.ShowErrorMsgAndClose(ex.Message)
        End Try

    End Sub
    Private Function GetPrintableJob() As MSO.Printing.PrintJob

        Dim PrintJob As New MSO.Printing.PrintJob

        With PrintJob
            '    '####################################################################################
            .AddText(Buy_ID.Text, "Buy_ID")
            .AddText(Buy_Date.Value.Date, "Buy_Date")
            .AddText(Imp_Inv_No.Text, "Imp_Inv_No")
            .AddText(Inv_Type.Text, "Inv_Type")
            .AddText(Imp_ID.Text, "Imp_ID")
            .AddText(ImpName.Text, "ImpName")
            .AddText(ImpPhone.Text, "ImpPhone")
            .AddText(SalesMan.Text, "SalesMan")
            .AddText(Total.Text, "Total")
            .AddText(Item_Count.Text, "Item_Count")
            '  .AddText(TaxValue.Text, "TaxValue")
            ' .AddText(DiscountValue.Text, "DiscountValue")
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
                .AddTextColumn("BuyPrice")
                .AddTextColumn("Qty")
                .AddTextColumn("TotalAmount")
            End With
        End With


        Return PrintJob
    End Function
    Public Function Get_All_Prd()
        Con.Open()
        Dim dt1 As New DataTable
        Dim cmd As New SqlCommand("Select * From View_BuyINV where Buy_ID=@Buy_ID", Con)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@Buy_ID", SqlDbType.Int).Value = Buy_ID.Text
        Dim adp As New SqlDataAdapter(cmd)
        adp.Fill(dt1)
        Con.Close()
        Return dt1
    End Function
    Public Sub Update_Imp_Balance()

        Dim Cmd2 As New SqlCommand
        With Cmd2
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Importers_Tbl Set ToHim = ToHim + " & UnPaid.Text & " Where Imp_ID = @Imp_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Imp_ID", SqlDbType.Int).Value = Imp_ID.Text
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd2.ExecuteNonQuery()
        Con.Close()
        Cmd2 = Nothing
    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Print()
    End Sub
    Private Sub BtnRemove_Click(sender As System.Object, e As System.EventArgs) Handles BtnRemove.Click
        If dgv_buy.SelectedRows.Count > 0 Then

            If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                Exit Sub
            Else

                dgv_buy.Rows.Remove(dgv_buy.SelectedRows(0))
                Item_Count.Text = dgv_buy.RowCount
                InvoiceTotal()
            End If
        Else
            MessageBox.Show("يجب ان تختار مادة لازالتها من الفاتورة")
        End If

    End Sub
    Public Sub Insert_By_ID_2()
        For i As Integer = 0 To dgv_buy.Rows.Count - 1
            If dgv_buy.Rows(i).Cells(1).Value = TextBox1.Text Then
                MsgBox(" المنتج المراد ادخاله تم اضافته للفاتورة مسبقا")
                Exit Sub
            End If
        Next

        Dim x As Integer
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" select  *  from View_AllPrd  where  Prd_Code=@Prd_Code", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Prd_Code", SqlDbType.VarChar).Value = TextBox1.Text
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    dgv_buy.Rows.Add()
                    x = dgv_buy.Rows.Count - 1
                    dgv_buy(0, x).Value = dr("Prd_ID").ToString
                    dgv_buy(1, x).Value = dr("Prd_Code").ToString
                    dgv_buy(2, x).Value = dr("Prd_Name").ToString
                    dgv_buy(3, x).Value = dr("UnitName").ToString
                End While
                dr.Close()
                Con.Close()

            Else
                MsgBox("رقم المنتج الذي قمت بادخاله غير موجود")
            End If

        Catch ex As Exception
            Con.Close()
        End Try
    End Sub
    Private Sub TextBox1_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles TextBox1.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            Insert_By_ID_2()
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Inv_Type_KeyDown(sender As Object, e As KeyEventArgs) Handles Inv_Type.KeyDown
        If e.KeyCode = Keys.Enter Then
            Prd_ID.Select()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Try

            Con.Open()
            Dim cmd As New SqlCommand(" select  *  from Importers_Tbl  where ImpName+convert(varchar,Imp_ID) like '%" + TextBox2.Text + "%'", Con)
            cmd.Parameters.Clear()
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.HasRows Then

                While dr.Read
                    Imp_ID.Text = dr("Imp_ID").ToString
                    ImpName.Text = dr("ImpName").ToString
                    ImpPhone.Text = dr("ImpPhone").ToString
                    ToHim.Text = dr("ToHim").ToString
                    Onhim.Text = dr("Onhim").ToString
                End While
                dr.Close()

            Else
                MsgBox("رقم المورد الذي قمت بادخاله غير موجود")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        Finally

            Con.Close()

        End Try
    End Sub
End Class