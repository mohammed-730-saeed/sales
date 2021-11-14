Imports System.Data.SqlClient

Public Class Stock_Bank_Rep
    Public dt_Stock_To_Bank As New DataTable
    Public Sub SelectAll_Stock_To_Bank(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Stock_To_Bank.Clear()
        da = New SqlDataAdapter("select * from Stock_To_Bank", Con)
        da.Fill(dt_Stock_To_Bank)
        dgv.DataSource = dt_Stock_To_Bank
    End Sub
    Public Sub DataGridViewHeaderText(ByVal DGV As DataGridView)
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("Bank_Transfer_ID").HeaderText = "رقم التحويل"
                .Columns("Bank_Transfer_ID").Width = 120
                .Columns("Money").HeaderText = "قيمة المبلغ"
                .Columns("Money").Width = 120
                .Columns("TransferDate").HeaderText = "تاريخ التحويل"
                .Columns("TransferDate").Width = 150
                .Columns("StockName").HeaderText = "من"
                .Columns("StockName").Width = 160
                .Columns("BankName").HeaderText = "الى"
                .Columns("BankName").Width = 150
                .Columns("EmpName").HeaderText = "اسم الموظف"
                .Columns("EmpName").Width = 130
                .Columns("Reason").HeaderText = "السبب"
                .Columns("Reason").Width = 130
            End With
        End If
    End Sub

    Private Sub Stock_Bank_Rep_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        SelectAll_Stock_To_Bank(DGV)
        DataGridViewHeaderText(DGV)
        Total()
    End Sub
    Public Sub Total()

        Dim Total1 As Decimal = "0.00"

        For Each row As DataGridViewRow In DGV.Rows
            Total1 += row.Cells(1).Value

        Next
        TotalMoney.Text = Total1

    End Sub

    Public DT_SEARCH As New DataTable()
    Public Sub SEARCH2DATE(ByVal TransferDate As Date, ByVal TransferDate2 As Date)
        DT_SEARCH.clear()
        Dim CMDSEARCH As New SqlCommand(" SELECT * FROM Stock_To_Bank WHERE TransferDate >= @TransferDate AND TransferDate <= @TransferDate2", con)
        CMDSEARCH.Parameters.Clear()
        CMDSEARCH.Parameters.Add("@TransferDate", SqlDbType.Date).Value = "#" & TransferDate & "#"
        CMDSEARCH.Parameters.Add("@TransferDate2", SqlDbType.Date).Value = "#" & TransferDate2 & "#"
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            DT_SEARCH.Load(CMDSEARCH.ExecuteReader)
            Con.Close()
            CMDSEARCH = Nothing
        Catch ex As Exception
            Con.Close()
            MsgBox(Err.Description, MsgBoxStyle.Information)
        Finally
            If Con.State = ConnectionState.Open Then Con.Close()
        End Try
    End Sub

    Private Sub BtnSearchDate_Click(sender As System.Object, e As System.EventArgs) Handles BtnSearchDate.Click
        SEARCH2DATE(Date1.Value, Date2.Value)
        DGV.DataSource = DT_SEARCH
        Total()
    End Sub

    Private Sub BtnShowAll_Click(sender As System.Object, e As System.EventArgs) Handles BtnShowAll.Click
        SelectAll_Stock_To_Bank(DGV)
        DataGridViewHeaderText(DGV)
        Total()
    End Sub
End Class