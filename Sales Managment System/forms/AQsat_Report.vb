Imports System.Data.SqlClient

Public Class AQsat_Report

    Public Sub Aqsat_Sale_ID()
        Try
            DGV_Cus.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from View_Aqsat", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                DGV_Cus.Rows.Add(dr("Aqsat_Sale_ID").ToString, dr("CusName").ToString, dr("FinalTotal").ToString, dr("Aqsat_All").ToString, dr("Qast_Amount").ToString, dr("Aqsat_Paid").ToString, dr("Aqsat_Unpaid").ToString, dr("Money_Paid").ToString, dr("Money_Unpaid").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try

    End Sub

    Private Sub AQsat_Report_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Aqsat_Sale_ID()
        Total()
    End Sub
    Public Sub Total()
        Dim Total1 As Decimal = "0.00"
        Dim Total2 As Decimal = "0.00"
        Dim Total3 As Integer = "0"
        Dim Total4 As Decimal = "0.00"
        Dim Total5 As Decimal = "0.00"
        Dim Total6 As Decimal = "0.00"
        For Each row As DataGridViewRow In DGV_Cus.Rows
            Total1 += row.Cells(2).Value
            Total2 += row.Cells(3).Value
            Total3 += row.Cells(5).Value
            Total4 += row.Cells(6).Value
            Total5 += row.Cells(7).Value
            Total6 += row.Cells(8).Value
        Next
        MoneyAll.Text = Total1
        Aqsat_All.Text = Total2
        AqsatPaid.Text = Total3
        AqsatUnpaid.Text = Total4
        MoneyPaid.Text = Total5
        MoneyUnpaid.Text = Total6
        InvCount.Text = DGV_Cus.Rows.Count
    End Sub
End Class