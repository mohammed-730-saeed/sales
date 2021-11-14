Imports System.Data.SqlClient

Public Class Frm_Store
    Public Sub LoadStore()
        Try
            DGV_Store.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from View_Store", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                DGV_Store.Rows.Add(dr("Prd_ID").ToString, dr("Prd_Code").ToString, dr("Prd_Name").ToString, dr("CatName").ToString, dr("UnitName").ToString, dr("BuyPrice").ToString, dr("SellPrice").ToString, dr("Qty").ToString, dr("PrdLimit").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try
        For i As Integer = 0 To DGV_Store.Rows.Count - 1
            DGV_Store.Rows(i).Cells(9).Value = DGV_Store.Rows(i).Cells(5).Value * DGV_Store.Rows(i).Cells(7).Value
            DGV_Store.Rows(i).Cells(10).Value = DGV_Store.Rows(i).Cells(6).Value * DGV_Store.Rows(i).Cells(7).Value
        Next
        For i As Integer = 0 To DGV_Store.Rows.Count - 1
            If DGV_Store.Rows(i).Cells(8).Value <= DGV_Store.Rows(i).Cells(7).Value Then
                DGV_Store.Rows(i).DefaultCellStyle.BackColor = Color.Red
            End If
        Next
    End Sub

    Private Sub Frm_Store_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadStore()
      
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub DGV_Store_DoubleClick(sender As System.Object, e As System.EventArgs) Handles DGV_Store.DoubleClick
        GetProduct()
    End Sub

    Public Sub GetProduct()

        For i As Integer = 0 To Re_Buy_Inv.dgv_buy1.Rows.Count - 1
            If Sale_Inv.dgvSale.Rows(i).Cells(0).Value = DGV_Store.CurrentRow.Cells(0).Value Then
                MsgBox(" المنتج المراد ادخاله تم اضافته للفاتورة مسبقا")
                Exit Sub
            End If
        Next
        Dim x As Integer
        Sale_Inv.dgvSale.Rows.Add()
        x = Sale_Inv.dgvSale.Rows.Count - 1
        Sale_Inv.dgvSale(0, x).Value = DGV_Store.CurrentRow.Cells(0).Value
        Sale_Inv.dgvSale(1, x).Value = DGV_Store.CurrentRow.Cells(1).Value
        Sale_Inv.dgvSale(2, x).Value = DGV_Store.CurrentRow.Cells(2).Value
        Sale_Inv.dgvSale(3, x).Value = DGV_Store.CurrentRow.Cells(4).Value
        Sale_Inv.dgvSale(4, x).Value = DGV_Store.CurrentRow.Cells(6).Value
        Me.Close()
    End Sub

    Public Sub Check_Limit()
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Dim cmd As New SqlCommand(" select  *  from View_Store  where  Prd_ID=@Prd_ID", Con)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@Prd_ID", SqlDbType.Int).Value = DGV_Store.CurrentRow.Cells(0).Value.ToString
        Dim adp As New SqlDataAdapter(cmd)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            Dim QtyLimit As Integer = dr("PrdLimit").ToString()
        End While
        dr.Close()
        Con.Close()
    End Sub
End Class