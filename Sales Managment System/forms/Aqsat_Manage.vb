Imports System.Data.SqlClient

Public Class Aqsat_Manage

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
                DGV_Cus.Rows.Add(dr("Cus_ID").ToString, dr("CusName").ToString, dr("CusPhone").ToString, dr("Aqsat_Sale_ID").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try

    End Sub

    Private Sub Aqsat_Manage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Aqsat_Sale_ID()
    End Sub

    Private Sub DGV_Cus_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Cus.CellClick
        If e.ColumnIndex = 4 Then
            Get_Aqsat_Info()
        ElseIf e.ColumnIndex = 5 Then
            Aqsat_Details()
        ElseIf e.ColumnIndex = 6 Then

        End If
    End Sub

    Public Sub Get_Aqsat_Info()
        Try

            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from View_Aqsat Where Aqsat_Sale_ID=" & DGV_Cus.CurrentRow.Cells(3).Value & "", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Show_Aqsat_Info.Aqsat_Sale_ID.Text = dr("Aqsat_Sale_ID").ToString
                Show_Aqsat_Info.FinalTotal.Text = dr("FinalTotal").ToString
                Show_Aqsat_Info.Aqsat_No.Text = dr("Aqsat_All").ToString
                Show_Aqsat_Info.Qast_Amount.Text = dr("Qast_Amount").ToString
                Show_Aqsat_Info.Aqsat_Paid.Text = dr("Aqsat_Paid").ToString
                Show_Aqsat_Info.Aqsat_Unpaid.Text = dr("Aqsat_Unpaid").ToString
                Show_Aqsat_Info.Money_Paid.Text = dr("Money_Paid").ToString
                Show_Aqsat_Info.Money_Unpaid.Text = dr("Money_Unpaid").ToString
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try
        Show_Aqsat_Info.ShowDialog()
    End Sub

    Public Sub Aqsat_Details()
        Try
            Show_Aqsat_Details.DataGridView1.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from Qast_Details_Tbl Where Aqsat_Sale_ID=" & DGV_Cus.CurrentRow.Cells(3).Value & "", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Show_Aqsat_Details.DataGridView1.Rows.Add(dr("Aqsat_Sale_ID").ToString, dr("Qast_ID").ToString, Convert.ToDateTime(dr("Qast_date")).ToString("dd/MM/yyyy"), dr("Qast_Amount").ToString, dr("Qast_Status").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try

        Show_Aqsat_Details.ShowDialog()
    End Sub

    Public Sub Search_By_Name(ByVal CusName As String)
        Try
            DGV_Cus.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from View_Aqsat where CusName =@CusName ", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@CusName", SqlDbType.VarChar).Value = CusName
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                DGV_Cus.Rows.Add(dr("Cus_ID").ToString, dr("CusName").ToString, dr("CusPhone").ToString, dr("Aqsat_Sale_ID").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try

    End Sub

    Public Sub Search_By_Cus_ID()
        Try
            DGV_Cus.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from View_Aqsat where Cus_ID=" & TextBox1.Text & "", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                DGV_Cus.Rows.Add(dr("Cus_ID").ToString, dr("CusName").ToString, dr("CusPhone").ToString, dr("Aqsat_Sale_ID").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try

    End Sub

    Public Sub Search_By_CusPhone()
        Try
            DGV_Cus.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from View_Aqsat where CusPhone=" & TextBox1.Text & "", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                DGV_Cus.Rows.Add(dr("Cus_ID").ToString, dr("CusName").ToString, dr("CusPhone").ToString, dr("Aqsat_Sale_ID").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            CheckBox2.Checked = False
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            Search_By_Cus_ID()
        ElseIf CheckBox2.Checked = True Then
            Search_By_Name(TextBox1.Text)
        ElseIf CheckBox3.Checked = True Then
            Search_By_CusPhone()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Aqsat_Sale_ID()
    End Sub
End Class