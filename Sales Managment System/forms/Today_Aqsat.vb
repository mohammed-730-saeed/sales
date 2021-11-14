Imports System.Data.SqlClient

Public Class Today_Aqsat

    Private Sub Today_Aqsat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Aqsat_Details(Date.Now.ToString("dd/MM/yyyy"))
    End Sub
    Public Sub Aqsat_Details(ByVal Qast_date As Date)
        Try
            DataGridView1.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from Qast_Details_Tbl Where Qast_date=@Qast_date", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.Add("@Qast_date", SqlDbType.Date).Value = "#" & Qast_date & "#"
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr("Aqsat_Sale_ID").ToString, dr("Qast_ID").ToString, Convert.ToDateTime(dr("Qast_date")).ToString("dd/MM/yyyy"), dr("Qast_Amount").ToString, dr("Qast_Status").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()

        End Try
    End Sub
End Class