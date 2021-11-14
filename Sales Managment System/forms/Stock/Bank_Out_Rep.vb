Imports System.Data.SqlClient

Public Class Bank_Out_Rep
    Public dt_Bank_Out_Tbl As New DataTable
    Public Sub SelectAll_Bank_Out_Tbl(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Bank_Out_Tbl.Clear()
        da = New SqlDataAdapter("select * from Bank_Out_Tbl", con)
        da.Fill(dt_Bank_Out_Tbl)
        dgv.DataSource = dt_Bank_Out_Tbl
    End Sub

    Public Sub DataGridViewHeaderText(ByVal DGV As DataGridView)
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("Bank_Out_ID").HeaderText = "رقم الايداع"
                .Columns("Bank_Out_ID").Width = 120
                .Columns("Money").HeaderText = "قيمة الايداع"
                .Columns("Money").Width = 120
                .Columns("Date_Out").HeaderText = "تاريخ الايداع"
                .Columns("Date_Out").Width = 150
                .Columns("EmpName").HeaderText = "اسم المودع"
                .Columns("EmpName").Width = 150
                .Columns("Reason").HeaderText = "السبب"
                .Columns("Reason").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        End If
    End Sub

    Private Sub Bank_Out_Rep_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        SelectAll_Bank_Out_Tbl(DGV)
        DataGridViewHeaderText(DGV)
        Total()
    End Sub

    Public DT_SEARCH As New DataTable()
    Public Sub SEARCH2DATE(ByVal Date_Out As Date, ByVal Date_Out2 As Date)
        DT_SEARCH.clear()
        Dim CMDSEARCH As New SqlCommand(" SELECT * FROM Bank_Out_Tbl WHERE Date_Out >= @Date_Out AND Date_Out <= @Date_Out2", con)
        CMDSEARCH.Parameters.Clear()
        CMDSEARCH.Parameters.Add("@Date_Out", SqlDbType.Date).Value = "#" & Date_Out & "#"
        CMDSEARCH.Parameters.Add("@Date_Out2", SqlDbType.Date).Value = "#" & Date_Out2 & "#"
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


    Private Sub BtnSearchDate_Click(sender As System.Object, e As System.EventArgs)
        SEARCH2DATE(Date1.Value, Date2.Value)
        DGV.DataSource = DT_SEARCH
        Total()
    End Sub
    Public Sub Total()

        Dim Total1 As Decimal = "0.00"

        For Each row As DataGridViewRow In DGV.Rows
            Total1 += row.Cells(1).Value

        Next
        TotalMoney.Text = Total1

    End Sub

    

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        SelectAll_Bank_Out_Tbl(DGV)
        DataGridViewHeaderText(DGV)
        Total()
    End Sub
End Class