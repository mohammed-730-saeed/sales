Imports System.Data.SqlClient

Public Class Re_Buy_Inv
    Public Sub reset()
        dgv_buy1.Rows.Clear()
        Me.Re_Buy_ID.Text = vbNullString
        Me.Re_Buy_Date.Value = Today
        Me.Imp_ID.Text = vbNullString
        Me.ImpName.Text = vbNullString
        Me.ImpPhone.Text = vbNullString
        Me.TaxTotal.Text = vbNullString
        Me.DiscountTotal.Text = vbNullString
        Me.DiscountValue.Text = vbNullString
        Me.FinalTotal.Text = vbNullString
        Me.Total.Text = vbNullString
        Item_Count.Text = 0
        Get_Tax()
        Re_Buy_ID.Text = Max_ID("R_Buy_Tbl", "R_Buy_ID") + 1
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
            MessageBox.Show(ex.Message)
            Con.Close()
        End Try
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Frm_Products.ShowDialog()
    End Sub
    Public Sub InvoiceTotal()
        Dim Total1 As Decimal = "0.00"
        For Each row As DataGridViewRow In dgv_buy1.Rows
            Total1 += row.Cells(6).Value
        Next
        Total.Text = Total1
    End Sub
    Private Sub dgv_buy_CellLeave(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_buy1.CellLeave
        If e.ColumnIndex = 5 Then
            dgv_buy1.CurrentRow.Cells(6).Value = dgv_buy1.CurrentRow.Cells(4).Value * dgv_buy1.CurrentRow.Cells(5).Value
        End If
        Item_Count.Text = dgv_buy1.RowCount
        InvoiceTotal()
    End Sub
    Private Sub dgv_buy_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles dgv_buy1.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{left}")
        End If
    End Sub
    Private Sub dgv_buy_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_buy1.CellEndEdit
        SendKeys.Send("{left}")
    End Sub
    Private Sub Re_Buy_Inv_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Get_Tax()
        Re_Buy_ID.Text = Max_ID("R_Buy_Tbl", "R_Buy_ID") + 1

    End Sub
    Private Sub DiscountValue_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles DiscountValue.KeyDown
        If e.KeyCode = Keys.Enter Then
            DiscountTotal.Text = Val(DiscountValue.Text) * Val(Total.Text) / 100
            Total.Text = Val(Total.Text) - Val(DiscountTotal.Text)
            TaxTotal.Text = Val(Total.Text) * Val(TaxValue.Text) / 100
            FinalTotal.Text = Val(Total.Text) + Val(TaxTotal.Text)
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
    Public Sub Insert_By_ID()

   
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
                    dgv_buy1.Rows.Add()
                    x = dgv_buy1.Rows.Count - 1
                    dgv_buy1(0, x).Value = dr("Prd_ID").ToString
                    dgv_buy1(1, x).Value = dr("Prd_Code").ToString
                    dgv_buy1(2, x).Value = dr("Prd_Name").ToString
                    dgv_buy1(3, x).Value = dr("UnitName").ToString
                End While
                dr.Close()
                Con.Close()
            Else
                MsgBox("رقم المنتج الذي قمت بادخاله غير موجود")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Con.Close()
        End Try
    End Sub
    Public Sub Insert_By_ID2()

        For i As Integer = 0 To dgv_buy1.Rows.Count - 1
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim dt1 As New DataTable
            Dim cmd1 As New SqlCommand(" select  *  from View_AllPrd  where  Prd_Code=@Prd_Code", Con)
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("@Prd_Code", SqlDbType.Int).Value = dgv_buy1.Rows(i).Cells(1).Value
            Dim adp As New SqlDataAdapter(cmd1)
            adp.Fill(dt1)
            If dt1.Rows.Count > 0 Then
                MsgBox(" المنتج المراد ادخاله تم اضافته للفاتورة مسبقا")
                Exit Sub
            End If
            TextBox1.Text = "'"
            TextBox1.Focus()
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
                    dgv_buy1.Rows.Add()
                    x = dgv_buy1.Rows.Count - 1
                    dgv_buy1(0, x).Value = dr("Prd_ID").ToString
                    dgv_buy1(1, x).Value = dr("Prd_Code").ToString
                    dgv_buy1(2, x).Value = dr("Prd_Name").ToString
                    dgv_buy1(3, x).Value = dr("UnitName").ToString
                End While
                dr.Close()
                Con.Close()
            Else
                MsgBox("رقم الباركود الذي قمت بادخاله غير موجود")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Con.Close()
        End Try
    End Sub
    Private Sub TextBox1_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles TextBox1.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            Insert_By_ID2()
            TextBox1.Text = ""
        End If
    End Sub
    Private Sub Prd_ID_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles Prd_ID.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            Insert_By_ID()
            TextBox2.Select()
        End If
    End Sub
    Public Sub InsertRe_Buy_Details_Tbl()
        For i As Integer = 0 To dgv_buy1.Rows.Count - 1
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Insert Into R_BuyDetails_Tbl ( R_Buy_ID,Prd_ID,BuyPrice,Qty,TotalAmount)values(@R_Buy_ID,@Prd_ID,@BuyPrice,@Qty,@TotalAmount)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@R_Buy_ID", SqlDbType.Int).Value = Buy_ID.Text
                .Parameters.AddWithValue("@Prd_ID", SqlDbType.Int).Value = dgv_buy1.Rows(i).Cells(0).Value
                .Parameters.AddWithValue("@BuyPrice", SqlDbType.Decimal).Value = dgv_buy1.Rows(i).Cells(4).Value
                .Parameters.AddWithValue("@Qty", SqlDbType.Int).Value = dgv_buy1.Rows(i).Cells(5).Value
                .Parameters.AddWithValue("@TotalAmount", SqlDbType.Decimal).Value = dgv_buy1.Rows(i).Cells(6).Value
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()

            Cmd = Nothing
        Next
        MsgBox("تم إضافة فاتورة مرتجع الشراء بنجاح ", MsgBoxStyle.Information, "حفظ")
    End Sub
    Public Sub Update_Imp_Balance()

        Dim Cmd2 As New SqlCommand
        With Cmd2
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Importers_Tbl Set ToHim = ToHim - " & FinalTotal.Text & " Where Imp_ID = @Imp_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Imp_ID", SqlDbType.Int).Value = Imp_ID.Text
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd2.ExecuteNonQuery()
        Con.Close()
        Cmd2 = Nothing
    End Sub
    Public Sub Insert_R_Buy_Tbl(ByVal Re_Buy_ID As Int32, ByVal Re_Buy_Date As Date, ByVal Imp_ID As Int32, ByVal Item_Count As Int32, ByVal FinalTotal As Double, ByVal SalesMan As String)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Insert Into R_Buy_Tbl ( R_Buy_ID,R_Buy_Date,Imp_ID,Item_Count,FinalTotal,SalesMan)values(@R_Buy_ID,@R_Buy_Date,@Imp_ID,@Item_Count,@FinalTotal,@SalesMan)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@R_Buy_ID", SqlDbType.Int).Value = Re_Buy_ID
                .Parameters.AddWithValue("@R_Buy_Date", SqlDbType.Date).Value = Re_Buy_Date
                .Parameters.AddWithValue("@Imp_ID", SqlDbType.Int).Value = Imp_ID
                .Parameters.AddWithValue("@Item_Count", SqlDbType.Int).Value = Item_Count
                .Parameters.AddWithValue("@FinalTotal", SqlDbType.Decimal).Value = FinalTotal
                .Parameters.AddWithValue("@SalesMan", SqlDbType.VarChar).Value = SalesMan
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            'MsgBox("تم إضافة فاتورة مرتجع الشراء بنجاح ", MsgBoxStyle.Information, "حفظ")
            Cmd = Nothing
        Catch ex As Exception
            MessageBox.Show("هناك خطاء الرجاء التاكد !" + ex.Message)
        End Try

    End Sub
    Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click
        Try
            Insert_R_Buy_Tbl(Re_Buy_ID.Text, Re_Buy_Date.Value, Imp_ID.Text, Item_Count.Text, FinalTotal.Text, SalesMan.Text)
            InsertRe_Buy_Details_Tbl()
            Update_Imp_Balance()
            UpdateStore()
        Catch ex As Exception
            MessageBox.Show("هناك خطاء الرجاء التاكد !" + ex.Message)
        End Try

    End Sub
    Public Sub UpdateStore()
        For i As Integer = 0 To dgv_buy1.Rows.Count - 1
            Dim cmd1 As New SqlCommand("select * from Store_Tbl where Prd_ID =@Prd_ID ", Con)
            cmd1.Parameters.Clear()
            cmd1.Parameters.AddWithValue("@Prd_ID", SqlDbType.Int).Value = dgv_buy1.Rows(i).Cells(0).Value
            Dim dt As New DataTable
            Dim adp As New SqlDataAdapter(cmd1)
            adp.Fill(dt)
            If dt.Rows.Count > 0 Then
                Dim Cmd2 As New SqlCommand
                With Cmd2
                    .Connection = Con
                    .CommandType = CommandType.Text
                    .CommandText = "Update Store_Tbl Set Qty = Qty - " & dgv_buy1.Rows(i).Cells(5).Value & " Where Prd_ID = @Prd_ID"
                    .Parameters.Clear()
                    .Parameters.AddWithValue("@Prd_ID", SqlDbType.Int).Value = dgv_buy1.Rows(i).Cells(0).Value
                End With
                If Con.State = 1 Then Con.Close()
                Con.Open()
                Cmd2.ExecuteNonQuery()
                Con.Close()
                Cmd2 = Nothing
            End If
        Next
        MsgBox("تم تعديل الكميات في رصيد المستودع بنجاح", MsgBoxStyle.Information, "تعديل")
    End Sub


    Private Sub ToHim_TextChanged(sender As Object, e As EventArgs) Handles ToHim.TextChanged

    End Sub

    Private Sub Imp_ID_TextChanged(sender As Object, e As EventArgs) Handles Imp_ID.TextChanged

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

    Private Sub Buy_Date_KeyDown(sender As Object, e As KeyEventArgs) Handles Buy_Date.KeyDown

    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            DiscountValue.Select()
        End If
    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        If dgv_buy1.SelectedRows.Count > 0 Then

            If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                Exit Sub
            Else

                dgv_buy1.Rows.Remove(dgv_buy1.SelectedRows(0))
                Item_Count.Text = dgv_buy1.RowCount
                InvoiceTotal()
            End If
        Else
            MessageBox.Show("يجب ان تختار مادة لازالتها من الفاتورة")
        End If
    End Sub
End Class