Imports System.Data.SqlClient
Public Class Frm_Sale_Inv_Manage
    Public Sub Load_All_Sale()
        Try
            Dgv_All_Sale.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from View_Sale_Inv_Mange", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dgv_All_Sale.Rows.Add(dr("Sale_ID").ToString, Convert.ToDateTime(dr("Sale_Date")).ToString("dd/MM/yyyy"), dr("CusName").ToString, dr("Item_Count").ToString, dr("FinalTotal").ToString, dr("Paid").ToString, dr("UnPaid").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try

        For i As Integer = 0 To Dgv_All_Sale.Rows.Count - 1
            If Dgv_All_Sale.Rows(i).Cells(6).Value <= 0 Then
                Dgv_All_Sale.Rows(i).Cells(7).Value = " مسددة"
            Else
                Dgv_All_Sale.Rows(i).Cells(7).Value = "غير مسددة"
            End If
        Next

    End Sub

    Private Sub Frm_Sale_Inv_Manage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Load_All_Sale()
        Timer1.Start()
        Total()
    End Sub

    Public Sub Total()

        Dim Total1 As Decimal = "0.00"
        Dim Total2 As Decimal = "0.00"
        Dim Total3 As Decimal = "0.00"
        For Each row As DataGridViewRow In Dgv_All_Sale.Rows
            Total1 += row.Cells(4).Value
            Total2 += row.Cells(5).Value
            Total3 += row.Cells(6).Value
        Next
        TotalMoney.Text = Total1
        TxtPaid.Text = Total2
        TxtUnPaid.Text = Total3
        InvoiceCount.Text = Dgv_All_Sale.Rows.Count
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label6.Text = My.Computer.Clock.LocalTime.Date
    End Sub

    Private Sub CkSale_ID_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CkSale_ID.CheckedChanged
        If CkSale_ID.Checked = True Then
            TxtSearch.Enabled = True
        Else
            TxtSearch.Enabled = False
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As System.Object, e As System.EventArgs) Handles BtnSearch.Click
        If CkSale_ID.Checked = True Then
            Search_By_Sale_ID()
            Total()
        ElseIf CheckBox1.Checked = True Then
            Search_By_CusPhone()
        Else

            MsgBox("ارجو اختيار طريقة البحث برقم الفاتورة")
        End If
    End Sub
    Public Sub Search_By_Sale_ID()
        Try
            Dgv_All_Sale.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from View_Sale_Inv_Mange where Sale_Id=" & TxtSearch.Text & "", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dgv_All_Sale.Rows.Add(dr("Sale_ID").ToString, Convert.ToDateTime(dr("Sale_Date")).ToString("dd/MM/yyyy"), dr("CusName").ToString, dr("Item_Count").ToString, dr("FinalTotal").ToString, dr("Paid").ToString, dr("UnPaid").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try
        For i As Integer = 0 To Dgv_All_Sale.Rows.Count - 1
            If Dgv_All_Sale.Rows(i).Cells(6).Value <= 0 Then
                Dgv_All_Sale.Rows(i).Cells(7).Value = " مسددة"
            Else
                Dgv_All_Sale.Rows(i).Cells(7).Value = "غير مسددة"
            End If
        Next

    End Sub
    Public Sub Search_By_Sale_Date(ByVal Sale_Date As Date)
        Try
            Dgv_All_Sale.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from View_Sale_Inv_Mange where Sale_Date like @Sale_Date", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.Add("@Sale_Date", SqlDbType.Date).Value = "#" & Sale_Date & "#"
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dgv_All_Sale.Rows.Add(dr("Sale_ID").ToString, Convert.ToDateTime(dr("Sale_Date")).ToString("dd/MM/yyyy"), dr("CusName").ToString, dr("Item_Count").ToString, dr("FinalTotal").ToString, dr("Paid").ToString, dr("UnPaid").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try
        For i As Integer = 0 To Dgv_All_Sale.Rows.Count - 1
            If Dgv_All_Sale.Rows(i).Cells(6).Value <= 0 Then
                Dgv_All_Sale.Rows(i).Cells(7).Value = " مسددة"
            Else
                Dgv_All_Sale.Rows(i).Cells(7).Value = "غير مسددة"
            End If
        Next

    End Sub

    Private Sub BtnToday_Click(sender As System.Object, e As System.EventArgs) Handles BtnToday.Click
        Search_By_Sale_Date(Label6.Text.ToString)
        Total()
    End Sub

    Private Sub BtnShowAll_Click(sender As System.Object, e As System.EventArgs) Handles BtnShowAll.Click
        Load_All_Sale()
        Total()
    End Sub

    Public Sub Search_By_Sale_2Date(ByVal Sale_Date As Date, ByVal Sale_Date2 As Date)
        Try
            Dgv_All_Sale.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from View_Sale_Inv_Mange where Sale_Date >= @Sale_Date And Sale_Date <= @Sale_Date2", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.Add("@Sale_Date", SqlDbType.Date).Value = "#" & Sale_Date & "#"
            cmd.Parameters.Add("@Sale_Date2", SqlDbType.Date).Value = "#" & Sale_Date2 & "#"
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dgv_All_Sale.Rows.Add(dr("Sale_ID").ToString, Convert.ToDateTime(dr("Sale_Date")).ToString("dd/MM/yyyy"), dr("CusName").ToString, dr("Item_Count").ToString, dr("FinalTotal").ToString, dr("Paid").ToString, dr("UnPaid").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try
        For i As Integer = 0 To Dgv_All_Sale.Rows.Count - 1
            If Dgv_All_Sale.Rows(i).Cells(6).Value <= 0 Then
                Dgv_All_Sale.Rows(i).Cells(7).Value = " مسددة"
            Else
                Dgv_All_Sale.Rows(i).Cells(7).Value = "غير مسددة"
            End If
        Next

    End Sub

    Private Sub BtnSearchDate_Click(sender As System.Object, e As System.EventArgs) Handles BtnSearchDate.Click
        Search_By_Sale_2Date(Date1.Value, Date2.Value)
        Total()
    End Sub

    Public Sub fillcmb_Cus_Tbl(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Customer_Tbl ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.DisplayMember = "CusName"
            cmb.ValueMember = "Cus_ID"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub

    Private Sub Cmb_Cus_DropDown(sender As System.Object, e As System.EventArgs) Handles Cmb_Cus.DropDown
        fillcmb_Cus_Tbl(Cmb_Cus)
    End Sub

    Public Sub Search_By_CusName()
        Try
            Dgv_All_Sale.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from View_Sale_Inv_Mange where Cus_ID=" & Cmb_Cus.SelectedValue & "", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dgv_All_Sale.Rows.Add(dr("Sale_ID").ToString, Convert.ToDateTime(dr("Sale_Date")).ToString("dd/MM/yyyy"), dr("CusName").ToString, dr("Item_Count").ToString, dr("FinalTotal").ToString, dr("Paid").ToString, dr("UnPaid").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try
        For i As Integer = 0 To Dgv_All_Sale.Rows.Count - 1
            If Dgv_All_Sale.Rows(i).Cells(6).Value <= 0 Then
                Dgv_All_Sale.Rows(i).Cells(7).Value = " مسددة"
            Else
                Dgv_All_Sale.Rows(i).Cells(7).Value = "غير مسددة"
            End If
        Next
    End Sub

    Private Sub Cmb_Cus_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Cmb_Cus.SelectedIndexChanged
        Search_By_CusName()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TxtSearch.Enabled = True

        Else
            TxtSearch.Enabled = False
        End If
    End Sub

    Public Sub Search_By_CusPhone()
        Try
            Dgv_All_Sale.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from View_Sale_Inv_Mange where CusPhone=@CusPhone", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@CusPhone", SqlDbType.VarChar).Value = TxtSearch.Text
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dgv_All_Sale.Rows.Add(dr("Sale_ID").ToString, Convert.ToDateTime(dr("Sale_Date")).ToString("dd/MM/yyyy"), dr("CusName").ToString, dr("Item_Count").ToString, dr("FinalTotal").ToString, dr("Paid").ToString, dr("UnPaid").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try
        For i As Integer = 0 To Dgv_All_Sale.Rows.Count - 1
            If Dgv_All_Sale.Rows(i).Cells(6).Value <= 0 Then
                Dgv_All_Sale.Rows(i).Cells(7).Value = " مسددة"
            Else
                Dgv_All_Sale.Rows(i).Cells(7).Value = "غير مسددة"
            End If
        Next

    End Sub
    Public Sub Get_Invoice_Sale()
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from View_Get_Sale_Inv Where Sale_ID=@Sale_ID", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Sale_ID", SqlDbType.Int).Value = Dgv_All_Sale.CurrentRow.Cells(0).Value.ToString
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Show_Sale_Inv.Sale_ID.Text = dr("Sale_ID").ToString
                Show_Sale_Inv.Sale_Date.Value = dr("Sale_Date").ToString
                Show_Sale_Inv.Inv_Type.Text = dr("Inv_Type").ToString
                Show_Sale_Inv.Cus_ID.Text = dr("Cus_ID").ToString
                Show_Sale_Inv.CusName.Text = dr("CusName").ToString
                Show_Sale_Inv.CusPhone.Text = dr("CusPhone").ToString
                Show_Sale_Inv.Paid.Text = dr("Paid").ToString
                Show_Sale_Inv.UnPaid.Text = dr("UnPaid").ToString
                Show_Sale_Inv.Total.Text = dr("Total").ToString
                Show_Sale_Inv.TaxValue.Text = dr("Tax_Per").ToString
                Show_Sale_Inv.TaxTotal.Text = dr("TaxTotal").ToString
                Show_Sale_Inv.DiscountValue.Text = dr("Discount_Per").ToString
                Show_Sale_Inv.DiscountTotal.Text = dr("DiscountTotal").ToString
                Show_Sale_Inv.Item_Count.Text = dr("Item_Count").ToString
                Show_Sale_Inv.FinalTotal.Text = dr("FinalTotal").ToString
                Show_Sale_Inv.SalesMan.Text = dr("SalesMan").ToString
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try
    End Sub

    Public Sub Get_Details()
        Try
            Show_Sale_Inv.dgvSale.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from View_2 Where Sale_ID=@Sale_ID", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Sale_ID", SqlDbType.Int).Value = Dgv_All_Sale.CurrentRow.Cells(0).Value.ToString
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Show_Sale_Inv.dgvSale.Rows.Add(dr("Prd_ID").ToString, dr("Prd_Code").ToString, dr("Prd_Name").ToString, dr("UnitName").ToString, dr("SalePrice").ToString, dr("Qty").ToString, dr("TotalAmount").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try
    End Sub

    Private Sub Dgv_All_Sale_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv_All_Sale.CellClick
        If e.ColumnIndex = 8 Then
            Get_Invoice_Sale()
            Get_Details()
            Show_Sale_Inv.Show()
        End If
    End Sub

    Private Sub Btn_Re_Sale_Click(sender As System.Object, e As System.EventArgs) Handles Btn_Re_Sale.Click
        Get_Sale_Inv()
    End Sub

    Public Sub Get_Sale_Inv()
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" select  *  from View_Re_sale  where  Sale_ID=@Sale_ID", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Sale_ID", SqlDbType.Int).Value = Dgv_All_Sale.CurrentRow.Cells(0).Value
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    Re_Sale_Inv.Sale_ID.Text = dr("Sale_ID").ToString
                    Re_Sale_Inv.Cus_ID.Text = dr("Cus_ID").ToString
                    Re_Sale_Inv.CusName.Text = dr("CusName").ToString
                    Re_Sale_Inv.CusPhone.Text = dr("CusPhone").ToString
                    Re_Sale_Inv.ToHim.Text = dr("ToHim").ToString
                    Re_Sale_Inv.Onhim.Text = dr("Onhim").ToString
                    Re_Sale_Inv.Sale_Date.Value = dr("Sale_Date").ToString
                End While
                dr.Close()
                Con.Close()
         
            End If

        Catch ex As Exception
            Con.Close()
        End Try
        Re_Sale_Inv.Show()
    End Sub
End Class