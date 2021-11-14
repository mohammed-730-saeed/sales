Imports System.Data.SqlClient

Public Class Bank_IN_Rep
    Public dt_Bank_IN_tbl As New DataTable
    Public Sub SelectAll_Bank_IN_tbl(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Bank_IN_tbl.Clear()
        da = New SqlDataAdapter("select * from Bank_IN_tbl", Con)
        da.Fill(dt_Bank_IN_tbl)
        dgv.DataSource = dt_Bank_IN_tbl
    End Sub
    Public Sub DataGridViewHeaderText(ByVal DGV As DataGridView)
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("Bank_IN_ID").HeaderText = "رقم الايداع"
                .Columns("Bank_IN_ID").width = 120
                .Columns("Money").HeaderText = "قيمة الايداع"
                .Columns("Money").width = 120
                .Columns("Date_IN").HeaderText = "تاريخ الايداع"
                .Columns("Date_IN").width = 150
                .Columns("EmpName").HeaderText = "اسم المودع"
                .Columns("EmpName").width = 150
                .Columns("Reason").HeaderText = "السبب"
                .Columns("Reason").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        End If
    End Sub

    Private Sub Bank_IN_Rep_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        SelectAll_Bank_IN_tbl(DGV)
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
    Public Sub SEARCH2DATE(ByVal Date_IN As Date, ByVal Date_IN2 As Date)
        DT_SEARCH.clear()
        Dim CMDSEARCH As New SqlCommand(" SELECT * FROM Bank_IN_tbl WHERE Date_IN >= @Date_IN AND Date_IN <= @Date_IN2", con)
        CMDSEARCH.Parameters.Clear()
        CMDSEARCH.Parameters.Add("@Date_IN", SqlDbType.Date).Value = "#" & Date_IN & "#"
        CMDSEARCH.Parameters.Add("@Date_IN2", SqlDbType.Date).Value = "#" & Date_IN2 & "#"
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
        SelectAll_Bank_IN_tbl(DGV)
        DataGridViewHeaderText(DGV)
        Total()
    End Sub
End Class