Imports System.Data.SqlClient

Public Class Frm_Manage_Buy_Inv
    Public DT_TwoDate_Buy_Tbl As New DataTable
    Public DT_Buy_Tbl As New DataTable
    Public DT_OneDate_BUY_TBL As New DataTable
    Public Sub fillcmb_Importers_Tbl(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Importers_Tbl ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.DisplayMember = "ImpName"
            cmb.ValueMember = "Imp_ID"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub
    Private Sub Cmb_Imp_DropDown(sender As System.Object, e As System.EventArgs) Handles Cmb_Imp.DropDown, ComboBox1.DropDown
        fillcmb_Importers_Tbl(Cmb_Imp)

    End Sub
    Private Sub Frm_Manage_Buy_Inv_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Load_Buy_Tbl(DGV_Buys, Me)
        FormatDGV_Buy_Tbl(DGV_Buys)
        LblDateDay.Text = Date.Now.ToString("dddd")
        LblData.Text = Date.Now.ToString("dd/MM/yyyy")
        Total()
    End Sub
    Public Sub Total()

        Dim Total1 As Decimal = "0.00"
        Dim Total2 As Decimal = "0.00"
        Dim Total3 As Decimal = "0.00"
        For Each row As DataGridViewRow In DGV_Buys.Rows
            Total1 += row.Cells(3).Value
            Total2 += row.Cells(4).Value
            Total3 += row.Cells(5).Value
        Next
        TotalMoney.Text = Total1
        TxtPaid.Text = Total2
        TxtUnPaid.Text = Total3
        InvoiceCount.Text = DGV_Buys.Rows.Count
    End Sub
 

    Public Sub Load_Buy_Tbl(ByVal DGV_Buy_Tbl As DataGridView, ByVal Meform As Form)
        DGV_Buy_Tbl.DataSource = Nothing
        DGV_Buy_Tbl.Rows.Clear()
        DT_Buy_Tbl.Clear()
        Dim Da As New SqlDataAdapter("Select Buy_Tbl.Buy_ID,Buy_Tbl.Buy_Date,Importers_Tbl.ImpName,Buy_Tbl.FinalTotal,Buy_Tbl.Paid,Buy_Tbl.UnPaid,Buy_Tbl.SalesMan From Buy_Tbl ,Importers_Tbl Where Buy_Tbl.Imp_ID = Importers_Tbl.Imp_ID ", Con) '
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Da.Fill(DT_Buy_Tbl)
            Con.Close()
            Da = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Con.Close()
        End Try
        If DT_Buy_Tbl.Rows.Count <> 0 Then
            With DGV_Buy_Tbl
                .DataSource = DT_Buy_Tbl

            End With
        End If
    End Sub

    Public Sub FormatDGV_Buy_Tbl(ByVal DGV As DataGridView)
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("Buy_ID").HeaderText = "رقم الفاتورة"
                .Columns("Buy_ID").Width = 100
                .Columns("Buy_Date").HeaderText = "تاريخ الفاتورة"
                .Columns("Buy_Date").Width = 150
                .Columns("ImpName").HeaderText = "اسم المورد"
                .Columns("ImpName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns("FinalTotal").HeaderText = "المبلغ الاجمالي"
                .Columns("FinalTotal").Width = 120
                .Columns("Paid").HeaderText = "المبلغ المدفوع"
                .Columns("Paid").Width = 120
                .Columns("UnPaid").HeaderText = "المبلغ المتبقي"
                .Columns("UnPaid").Width = 120
                .Columns("SalesMan").HeaderText = "اسم الموظف"
                .Columns("SalesMan").Width = 250


            End With
        End If
    End Sub
    Public Sub SearchBetweenTwoDate(ByVal Buy_Date As Date, ByVal Buy_Date2 As Date)
        DT_TwoDate_Buy_Tbl.Clear()
        Dim Cmd2Date As New SqlCommand("Select Buy_Tbl.Buy_ID,Buy_Tbl.Buy_Date,Importers_Tbl.ImpName,Buy_Tbl.FinalTotal,Buy_Tbl.Paid,Buy_Tbl.UnPaid,Buy_Tbl.SalesMan From Buy_Tbl ,Importers_Tbl Where Buy_Tbl.Imp_ID=Importers_Tbl.Imp_ID and Buy_Tbl.Buy_Date >= @Buy_Date And Buy_Date <= @Buy_Date2 ", Con) '
        Cmd2Date.Parameters.Clear()
        Cmd2Date.Parameters.Add("@Buy_Date", SqlDbType.Date).Value = "#" & Buy_Date & "#"
        Cmd2Date.Parameters.Add("@Buy_Date2", SqlDbType.Date).Value = "#" & Buy_Date2 & "#"
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            DT_TwoDate_Buy_Tbl.Load(Cmd2Date.ExecuteReader)
            Con.Close()
            Cmd2Date = Nothing
        Catch ex As Exception
            Con.Close()
            MsgBox(Err.Description, MsgBoxStyle.Information)
        Finally
            If Con.State = ConnectionState.Open Then Con.Close()
        End Try
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        SearchBetweenTwoDate(Date1.Value, Date2.Value)

        DGV_Buys.DataSource = DT_TwoDate_Buy_Tbl
        Total()
    End Sub

    Public Sub SearchBetweenOneDate(ByVal Buy_Date As Date)
        DT_OneDate_BUY_TBL.Clear()
        Dim Cmd2Date As New SqlCommand(" Select Buy_Tbl.Buy_ID,Buy_Tbl.Buy_Date,Importers_Tbl.ImpName,Buy_Tbl.FinalTotal,Buy_Tbl.Paid,Buy_Tbl.UnPaid,Buy_Tbl.SalesMan From Buy_Tbl ,Importers_Tbl Where Buy_Tbl.Imp_ID=Importers_Tbl.Imp_ID and Buy_Tbl.Buy_Date like @Buy_Date", Con) '
        Cmd2Date.Parameters.Clear()
        Cmd2Date.Parameters.Add("@Buy_Date", SqlDbType.Date).Value = "#" & Buy_Date & "#"
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            DT_OneDate_BUY_TBL.Load(Cmd2Date.ExecuteReader)
            Con.Close()
            Cmd2Date = Nothing
        Catch ex As Exception
            Con.Close()
            MsgBox(Err.Description, MsgBoxStyle.Information)
        Finally
            If Con.State = ConnectionState.Open Then Con.Close()
        End Try
    End Sub

    Private Sub BtnToday_Click(sender As System.Object, e As System.EventArgs) Handles BtnToday.Click
        SearchBetweenOneDate(LblData.Text.ToString)
        DGV_Buys.DataSource = DT_OneDate_BUY_TBL
        Total()
    End Sub
  
    Private Sub BtnShowAll_Click(sender As System.Object, e As System.EventArgs) Handles BtnShowAll.Click
        Cmb_Imp.SelectedIndex = -1
        Load_Buy_Tbl(DGV_Buys, Me)
        FormatDGV_Buy_Tbl(DGV_Buys)
        LblDateDay.Text = Date.Now.ToString("dddd")
        LblData.Text = Date.Now.ToString("dd/MM/yyyy")
        Total()
    End Sub
    Public Sub Get_Invoice_Buy()
        Try

            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from View_Show_All_Buy Where Buy_ID=@Buy_ID", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Buy_ID", SqlDbType.Int).Value = DGV_Buys.CurrentRow.Cells(0).Value.ToString
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Show_Buy_Inv.Buy_ID.Text = dr("Buy_ID").ToString
                Show_Buy_Inv.Buy_Date.Value = dr("Buy_Date").ToString
                Show_Buy_Inv.Imp_Inv_No.Text = dr("Imp_Inv_No").ToString
                Show_Buy_Inv.Inv_Type.Text = dr("Inv_Type").ToString
                Show_Buy_Inv.Imp_ID.Text = dr("Imp_ID").ToString
                Show_Buy_Inv.ImpName.Text = dr("ImpName").ToString
                Show_Buy_Inv.ImpPhone.Text = dr("ImpPhone").ToString
                Show_Buy_Inv.Paid.Text = dr("Paid").ToString
                Show_Buy_Inv.UnPaid.Text = dr("UnPaid").ToString
                Show_Buy_Inv.Total.Text = dr("Total").ToString
                Show_Buy_Inv.TaxValue.Text = dr("Tax_Per").ToString
                Show_Buy_Inv.TaxTotal.Text = dr("TaxTotal").ToString
                Show_Buy_Inv.DiscountValue.Text = dr("Discount_Per").ToString
                Show_Buy_Inv.DiscountTotal.Text = dr("DiscountTotal").ToString
                Show_Buy_Inv.Item_Count.Text = dr("Item_Count").ToString
                Show_Buy_Inv.FinalTotal.Text = dr("FinalTotal").ToString
                Show_Buy_Inv.SalesMan.Text = dr("SalesMan").ToString
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try

    End Sub

    Public Sub Get_Details()
        Try
            Show_Buy_Inv.dgv_buy2.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from View_BuyINV Where Buy_ID=@Buy_ID", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Buy_ID", SqlDbType.Int).Value = DGV_Buys.CurrentRow.Cells(0).Value.ToString
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Show_Buy_Inv.dgv_buy2.Rows.Add(dr("Prd_ID").ToString, dr("Prd_Code").ToString, dr("Prd_Name").ToString, dr("UnitName").ToString, dr("BuyPrice").ToString, dr("Qty").ToString, dr("TotalAmount").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try
    End Sub
    Private Sub BtnInvoice_Click(sender As System.Object, e As System.EventArgs) Handles BtnInvoice.Click
        Get_Invoice_Buy()
        Get_Details()
        Show_Buy_Inv.ShowDialog()
    End Sub


    Private Sub Cmb_Imp_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Cmb_Imp.SelectedIndexChanged
        Try

            Dim dv As DataView = DT_Buy_Tbl.DefaultView

            dv.RowFilter = "ImpName LIKE '%" & Cmb_Imp.Text & "%' "

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class