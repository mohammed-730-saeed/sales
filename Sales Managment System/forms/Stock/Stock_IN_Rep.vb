Imports System.Data.SqlClient

Public Class Stock_IN_Rep
    Public dt_Stock_IN_Tbl As New DataTable
    Public Sub SelectAll_Stock_IN_Tbl(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Stock_IN_Tbl.Clear()
        da = New SqlDataAdapter("select * from View_Stock_IN", Con)
        da.Fill(dt_Stock_IN_Tbl)
        dgv.DataSource = dt_Stock_IN_Tbl
    End Sub
    Public Sub DataGridViewHeaderText(ByVal DGV As DataGridView)
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("Stock_IN_ID").HeaderText = "رقم الايداع"
                .Columns("Stock_IN_ID").width = 120
                .Columns("Stock_Name").HeaderText = "اسم الخزنة"
                .Columns("Stock_Name").Width = 160
                .Columns("Money").HeaderText = "المبلغ المودع"
                .Columns("Money").width = 120
                .Columns("Date_In").HeaderText = "تاريخ الايداع"
                .Columns("Date_In").width = 150
                .Columns("EmpName").HeaderText = "اسم المودع"
                .Columns("EmpName").width = 160
                .Columns("Reason").HeaderText = "السبب"
                .Columns("Reason").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        End If
    End Sub

    Private Sub Stock_IN_Rep_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        SelectAll_Stock_IN_Tbl(DGV)
        DataGridViewHeaderText(DGV)
        Total()
    End Sub

    Public DT_SEARCH As New DataTable()
    Public Sub SEARCH2DATE(ByVal Date_In As Date, ByVal Date_In2 As Date)
        DT_SEARCH.clear()
        Dim CMDSEARCH As New SqlCommand(" SELECT * FROM View_Stock_IN WHERE Date_In >= @Date_In AND Date_In <= @Date_In2", Con)
        CMDSEARCH.Parameters.Clear()
        CMDSEARCH.Parameters.Add("@Date_In", SqlDbType.Date).Value = "#" & Date_In & "#"
        CMDSEARCH.Parameters.Add("@Date_In2", SqlDbType.Date).Value = "#" & Date_In2 & "#"
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

    Public Sub Total()

        Dim Total1 As Decimal = "0.00"
        
        For Each row As DataGridViewRow In DGV.Rows
            Total1 += row.Cells(2).Value
         
        Next
        TotalMoney.Text = Total1
       
    End Sub

    Private Sub BtnShowAll_Click(sender As System.Object, e As System.EventArgs) Handles BtnShowAll.Click
        SelectAll_Stock_IN_Tbl(DGV)
        DataGridViewHeaderText(DGV)
        Total()
    End Sub
End Class