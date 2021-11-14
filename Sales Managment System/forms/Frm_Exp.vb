Imports System.Data.SqlClient

Public Class Frm_Exp
    Public Sub Get_Exp()

        Try
            dgvExp.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from Exp_Tbl ", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                dgvExp.Rows.Add(dr("Exp_ID").ToString, Convert.ToDateTime(dr("Exp_Date")).ToString("dd/MM/yyyy"), dr("Exp_Value").ToString, dr("Exp_Des").ToString, dr("EmpName").ToString)

            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try

    End Sub

    Private Sub Frm_Exp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Get_Exp()
        Total()
    End Sub
    Public Sub Search_By_Exp_2Date(ByVal Exp_Date As Date, ByVal Exp_Date2 As Date)
        Try
            dgvExp.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from Exp_Tbl where Exp_Date >= @Exp_Date And Exp_Date <= @Exp_Date2", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.Add("@Exp_Date", SqlDbType.Date).Value = "#" & Exp_Date & "#"
            cmd.Parameters.Add("@Exp_Date2", SqlDbType.Date).Value = "#" & Exp_Date2 & "#"
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                dgvExp.Rows.Add(dr("Exp_ID").ToString, Convert.ToDateTime(dr("Exp_Date")).ToString("dd/MM/yyyy"), dr("Exp_Value").ToString, dr("Exp_Des").ToString, dr("EmpName").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Search_By_Exp_2Date(Date1.Value, Date2.Value)
        Total()
    End Sub
    Public Sub Total()

        Dim Total1 As Decimal = "0.00"
      
        For Each row As DataGridViewRow In dgvExp.Rows
            Total1 += row.Cells(2).Value
        Next
        TotalMoney.Text = Total1
        InvoiceCount.Text = dgvExp.Rows.Count
    End Sub


End Class