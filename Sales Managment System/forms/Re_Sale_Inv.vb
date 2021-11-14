Imports System.Data.SqlClient

Public Class Re_Sale_Inv

    Private Sub Re_Sale_Inv_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Get_Tax()
        Re_Sale_ID.Text = Max_ID("R_Sale_Tbl", "R_Sale_ID") + 1000
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

    Public Sub Insert_By_ID()
        For i As Integer = 0 To dgvSale.Rows.Count - 1
            If dgvSale.Rows(i).Cells(0).Value = Prd_ID.Text Then
                MsgBox(" المنتج المراد ادخاله تم اضافته للفاتورة مسبقا")
                Exit Sub
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
        End Try
    End Sub

    Private Sub Prd_ID_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles Prd_ID.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            Insert_By_ID()
            Prd_ID.Text = ""
        End If
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
            Dim cmd As New SqlCommand(" select  *  from View_Store  where  Prd_Code=@Prd_Code", Con)
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
            Con.Close()
        End Try
    End Sub

    Private Sub Prd_Code_PreviewKeyDown(sender As System.Object, e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles Prd_Code.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            Insert_By_ID_2()
            Prd_Code.Text = ""
        End If
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
                    .CommandText = "Update Store_Tbl Set Qty = Qty + " & dgvSale.Rows(i).Cells(5).Value & " Where Prd_ID = @Prd_ID"
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
        SendKeys.Send("{left}")
    End Sub

    Private Sub DiscountValue_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles DiscountValue.KeyDown
        If e.KeyCode = Keys.Enter Then
            DiscountTotal.Text = Val(DiscountValue.Text) * Val(Total.Text) / 100
            Total.Text = Val(Total.Text) - Val(DiscountTotal.Text)
            TaxTotal.Text = Val(Total.Text) * Val(TaxValue.Text) / 100
            FinalTotal.Text = Val(Total.Text) + Val(TaxTotal.Text)
        End If
    End Sub
    Public Sub Update_Cus_Balance()

        Dim Cmd2 As New SqlCommand
        With Cmd2
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Customer_Tbl Set Tohim = Tohim + " & FinalTotal.Text & " Where Cus_ID = @Cus_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Cus_ID", SqlDbType.Int).Value = Cus_ID.Text
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd2.ExecuteNonQuery()
        Con.Close()
        Cmd2 = Nothing
    End Sub

    Public Sub Insert_Re_Sale_Tbl(ByVal R_Sale_ID As Int32, ByVal R_Sale_Date As Date, ByVal Cus_ID As Int32, ByVal Item_Count As Int32, ByVal FinalTotal As Double, ByVal SalesMan As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Re_Sale_Tbl ( R_Sale_ID,R_Sale_Date,Cus_ID,Item_Count,FinalTotal,SalesMan)values(@R_Sale_ID,@R_Sale_Date,@Cus_ID,@Item_Count,@FinalTotal,@SalesMan)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@R_Sale_ID", SqlDbType.Int).Value = R_Sale_ID
            .Parameters.AddWithValue("@R_Sale_Date", SqlDbType.Date).Value = R_Sale_Date
            .Parameters.AddWithValue("@Cus_ID", SqlDbType.Int).Value = Cus_ID
            .Parameters.AddWithValue("@Item_Count", SqlDbType.Int).Value = Item_Count
            .Parameters.AddWithValue("@FinalTotal", SqlDbType.Decimal).Value = FinalTotal
            .Parameters.AddWithValue("@SalesMan", SqlDbType.varchar).Value = SalesMan
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click
        Try
            Insert_Re_Sale_Tbl(Re_Sale_ID.Text, Re_Sale_Date.Value, Cus_ID.Text, Item_Count.Text, FinalTotal.Text, SalesMan.Text)
            Insert_Re_Sale_Details_Tbl()
            Update_Cus_Balance()
            UpdateStore()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub Insert_Re_Sale_Details_Tbl()

        For i As Integer = 0 To dgvSale.Rows.Count - 1


            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Insert Into Re_Sale_Details_Tbl ( R_Sale_ID,Prd_ID,SalePrice,Qty,TotalAmount)values(@R_Sale_ID,@Prd_ID,@SalePrice,@Qty,@TotalAmount)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@R_Sale_ID", SqlDbType.Int).Value = Re_Sale_ID.Text
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
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")

    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try

            Con.Open()
            Dim cmd As New SqlCommand(" select  *  from Customer_Tbl  where CusName+convert(varchar,Cus_ID) like '%" + TextBox1.Text + "%'", Con)
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
                MsgBox("رقم المورد الذي قمت بادخاله غير موجود")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)


        Finally

            Con.Close()

        End Try
    End Sub

End Class