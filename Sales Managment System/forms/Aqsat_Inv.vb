Imports System.Data.SqlClient

Public Class Aqsat_Inv

    Private Sub Money_Paid_TextChanged(sender As System.Object, e As System.EventArgs) Handles Money_Paid.TextChanged
        Money_Unpaid.Text = Val(FinalTotal.Text) - Val(Money_Paid.Text)
    End Sub

    Private Sub Aqsat_No_TextChanged(sender As System.Object, e As System.EventArgs) Handles Aqsat_No.TextChanged
        Qast_Amount.Text = Val(Money_Unpaid.Text) / Val(Aqsat_No.Text)
        Aqsat_Unpaid.Text = Val(Aqsat_No.Text)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Frm_Customers.ShowDialog()
    End Sub

    Private Sub BtnNew_Click(sender As System.Object, e As System.EventArgs) Handles BtnNew.Click

        Aqsat_Sale_ID.Text = Max_ID("Aqsat_Sale_Tbl", "Aqsat_Sale_ID") + 1
        SalesMan.Text = Home.LblUser.Text
    End Sub

    Private Sub Aqsat_Inv_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Aqsat_Sale_ID.Text = Max_ID("Aqsat_Sale_Tbl", "Aqsat_Sale_ID") + 1
        SalesMan.Text = Home.LblUser.Text
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
                    dgvSale(5, x).Value = 1
                    dgvSale(6, x).Value = dgvSale(5, x).Value * dgvSale(4, x).Value
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

    Private Sub Prd_ID_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Prd_ID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Insert_By_ID()
            Prd_ID.Text = ""
        End If
        InvoiceTotal()
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
                    dgvSale(5, x).Value = 1
                    dgvSale(6, x).Value = dgvSale(5, x).Value * dgvSale(4, x).Value
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

    Private Sub Prd_Code_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Prd_Code.KeyDown
        If e.KeyCode = Keys.Enter Then
            Insert_By_ID_2()
            Prd_Code.Text = ""
        End If
        InvoiceTotal()
    End Sub

    Public Sub InvoiceTotal()
        Dim Total1 As Decimal = "0.00"
        For Each row As DataGridViewRow In dgvSale.Rows
            Total1 += row.Cells(6).Value
        Next
        FinalTotal.Text = Total1
    End Sub

    Private Sub dgvSale_CellLeave(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSale.CellLeave
        If e.ColumnIndex = 5 Then
            dgvSale.CurrentRow.Cells(6).Value = dgvSale.CurrentRow.Cells(4).Value * dgvSale.CurrentRow.Cells(5).Value
        End If
        'Item_Count.Text = dgvSale.RowCount
        InvoiceTotal()
    End Sub

    Private Sub BtnSave_Click(sender As System.Object, e As System.EventArgs) Handles BtnSave.Click
        Insert_Aqsat_Sale_Tbl(Aqsat_Sale_ID.Text, Sale_Date.Value, Cus_ID.Text, FinalTotal.Text, Aqsat_No.Text, StartDate.Value)
        Insert_Aqsat_Sale_Details_Tbl()
        Insert_Aqsat_Tbl(Aqsat_Sale_ID.Text, Cus_ID.Text, FinalTotal.Text, Aqsat_No.Text, Qast_Amount.Text, Aqsat_Paid.Text, Aqsat_Unpaid.Text, Money_Paid.Text, Money_Unpaid.Text)
        UpdateStore()

        '*******************************************************
        Frm_Add_Aqsat.Money_Unpaid.Text = Money_Unpaid.Text
        Frm_Add_Aqsat.Qast_Amount.Text = Qast_Amount.Text
        Frm_Add_Aqsat.Aqsat_No.Text = Aqsat_No.Text
        Frm_Add_Aqsat.Aqsat_Sale_ID.Text = Aqsat_Sale_ID.Text
        Frm_Add_Aqsat.Show()
    End Sub

    Public Sub Insert_Aqsat_Sale_Tbl(ByVal Aqsat_Sale_ID As Int32, ByVal Sale_Date As Date, ByVal Cus_ID As Int32, ByVal FinalTotal As Double, ByVal Aqsat_No As Int32, ByVal StartDate As Date)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Aqsat_Sale_Tbl ( Aqsat_Sale_ID,Sale_Date,Cus_ID,FinalTotal,Aqsat_No,StartDate)values(@Aqsat_Sale_ID,@Sale_Date,@Cus_ID,@FinalTotal,@Aqsat_No,@StartDate)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Aqsat_Sale_ID", SqlDbType.Int).Value = Aqsat_Sale_ID
            .Parameters.AddWithValue("@Sale_Date", SqlDbType.Date).Value = Sale_Date
            .Parameters.AddWithValue("@Cus_ID", SqlDbType.Int).Value = Cus_ID
            .Parameters.AddWithValue("@FinalTotal", SqlDbType.Decimal).Value = FinalTotal
            .Parameters.AddWithValue("@Aqsat_No", SqlDbType.Int).Value = Aqsat_No
            .Parameters.AddWithValue("@StartDate", SqlDbType.Date).Value = StartDate
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Public Sub Insert_Aqsat_Sale_Details_Tbl()
        For i As Integer = 0 To dgvSale.Rows.Count - 1
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Insert Into Aqsat_Sale_Details_Tbl ( Aqsat_Sale_ID,Prd_ID,SalePrice,Qty,TotalAmount)values(@Aqsat_Sale_ID,@Prd_ID,@SalePrice,@Qty,@TotalAmount)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Aqsat_Sale_ID", SqlDbType.Int).Value = Aqsat_Sale_ID.Text
                .Parameters.AddWithValue("@Prd_ID", SqlDbType.Int).Value = dgvSale.Rows(i).Cells(0).Value
                .Parameters.AddWithValue("@SalePrice", SqlDbType.Decimal).Value = dgvSale.Rows(i).Cells(4).Value
                .Parameters.AddWithValue("@Qty", SqlDbType.Int).Value = dgvSale.Rows(i).Cells(5).Value
                .Parameters.AddWithValue("@TotalAmount", SqlDbType.Decimal).Value = dgvSale.Rows(i).Cells(6).Value
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
            Cmd = Nothing

        Next
     
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

    Public Sub Insert_Aqsat_Tbl(ByVal Aqsat_Sale_ID As Int32, ByVal Cus_ID As Int32, ByVal FinalTotal As Double, ByVal Aqsat_All As Int32, ByVal Qast_Amount As Double, ByVal Aqsat_Paid As Int32, ByVal Aqsat_Unpaid As Int32, ByVal Money_Paid As Double, ByVal Money_Unpaid As Double)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Aqsat_Tbl ( Aqsat_Sale_ID,Cus_ID,FinalTotal,Aqsat_All,Qast_Amount,Aqsat_Paid,Aqsat_Unpaid,Money_Paid,Money_Unpaid)values(@Aqsat_Sale_ID,@Cus_ID,@FinalTotal,@Aqsat_All,@Qast_Amount,@Aqsat_Paid,@Aqsat_Unpaid,@Money_Paid,@Money_Unpaid)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Aqsat_Sale_ID", SqlDbType.Int).Value = Aqsat_Sale_ID
            .Parameters.AddWithValue("@Cus_ID", SqlDbType.Int).Value = Cus_ID
            .Parameters.AddWithValue("@FinalTotal", SqlDbType.Decimal).Value = FinalTotal
            .Parameters.AddWithValue("@Aqsat_All", SqlDbType.Int).Value = Aqsat_All
            .Parameters.AddWithValue("@Qast_Amount", SqlDbType.Decimal).Value = Qast_Amount
            .Parameters.AddWithValue("@Aqsat_Paid", SqlDbType.Int).Value = Aqsat_Paid
            .Parameters.AddWithValue("@Aqsat_Unpaid", SqlDbType.Int).Value = Aqsat_Unpaid
            .Parameters.AddWithValue("@Money_Paid", SqlDbType.Decimal).Value = Money_Paid
            .Parameters.AddWithValue("@Money_Unpaid", SqlDbType.Decimal).Value = Money_Unpaid
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

End Class