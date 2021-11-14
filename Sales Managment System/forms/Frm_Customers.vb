Imports System.Data.SqlClient
Imports System.IO
Imports MSwordDllFiles

Public Class Frm_Customers

    Private Sub BtnNew_Click(sender As System.Object, e As System.EventArgs) Handles BtnNew.Click
        Me.Close()
        Add_Customer.ShowDialog()

    End Sub

    Public Sub LoadCustomers()
        Try
            DGV_Cus.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from Customer_Tbl", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                DGV_Cus.Rows.Add(dr("Cus_ID").ToString, dr("CusName").ToString, dr("CusPhone").ToString, dr("CusAddress").ToString, dr("ToHim").ToString, dr("Onhim").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try

    End Sub

    Private Sub Frm_Customers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadCustomers()
    End Sub

    Private Sub BtnEdit_Click(sender As System.Object, e As System.EventArgs) Handles BtnEdit.Click

        Get_Info_To_Edit()
    End Sub

    Public Sub Get_Info_To_Edit()

        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" select  *  from Customer_Tbl  where  Cus_ID=@Cus_ID", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Cus_ID", SqlDbType.Int).Value = DGV_Cus.CurrentRow.Cells(0).Value.ToString
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Edit_Customer.Cus_ID.Text = dr("Cus_ID").ToString
                Edit_Customer.CusName.Text = dr("CusName").ToString
                Edit_Customer.CusPhone.Text = dr("CusPhone").ToString
                Edit_Customer.CusAddress.Text = dr("CusAddress").ToString
                Edit_Customer.ToHim.Text = dr("ToHim").ToString
                Edit_Customer.Onhim.Text = dr("Onhim").ToString
                Dim data As Byte() = DirectCast(dr("CusPic"), Byte())
                Dim ms As New MemoryStream(data)
                Edit_Customer.CusPic.Image = Image.FromStream(ms)

            End While
            dr.Close()
            Con.Close()
            Edit_Customer.Show()
        Catch ex As Exception
            Con.Close()

        End Try

        Me.Close()
    End Sub

    Public Sub Get_Pic()
        Try
            Con.Open()
            Dim cmd As New SqlCommand("Select CusPic From Customer_Tbl Where Cus_ID=@Cus_ID", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Cus_ID", SqlDbType.Int).Value = DGV_Cus.CurrentRow.Cells(0).Value.ToString
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read()

                    Dim data As Byte() = DirectCast(dr("CusPic"), Byte())
                    Dim ms As New MemoryStream(data)
                    Show_Pic.Prd_Pic.Image = Image.FromStream(ms)

                End While
                dr.Close()
                Con.Close()
                Show_Pic.Label1.Text = "صورة العميل"
                Show_Pic.ShowDialog()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Con.Close()
        End Try
    End Sub

    Private Sub DGV_Cus_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Cus.CellClick
        If e.ColumnIndex = 6 Then
            Get_Pic()
        ElseIf e.ColumnIndex = 7 Then
            Get_Cus_Move()
        End If
    End Sub

    Public Sub Delete_Customer_Tbl(ByVal dgv_Cus As DataGridView)
        Dim Position As Integer = dgv_Cus.CurrentRow.Index
        Dim ID_Position As Integer = dgv_Cus.Rows(Position).Cells(0).Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Customer_Tbl Where Cus_ID = @Cus_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Cus_ID", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف بيانات  العميل بنجاح.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub

    Private Sub BtnDelete_Click(sender As System.Object, e As System.EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Delete_Customer_Tbl(DGV_Cus)
        End If
        LoadCustomers()
    End Sub


    Public Function Get_All_cus()
        Con.Open()
        Dim dt1 As New DataTable
        Dim cmd As New SqlCommand("Select * From Customer_Tbl ", Con)
        Dim adp As New SqlDataAdapter(cmd)
        adp.Fill(dt1)
        Con.Close()
        Return dt1
    End Function

    Public Sub Search_By_Phone()
        Try
            DGV_Cus.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from Customer_Tbl  where CusPhone LIKE '%" & TxtSearch.Text & "%'", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                DGV_Cus.Rows.Add(dr("Cus_ID").ToString, dr("CusName").ToString, dr("CusPhone").ToString, dr("CusAddress").ToString, dr("ToHim").ToString, dr("Onhim").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Con.Close()
        End Try

    End Sub

    Private Sub BtnSearch_Click(sender As System.Object, e As System.EventArgs) Handles BtnSearch.Click

        Search_By_Phone()

    End Sub

    Private Sub BtnShowAll_Click(sender As System.Object, e As System.EventArgs) Handles BtnShowAll.Click
        LoadCustomers()
        TxtSearch.Clear()
    End Sub

    Private Sub DGV_Cus_DoubleClick(sender As System.Object, e As System.EventArgs) Handles DGV_Cus.DoubleClick
        Get_Info_To_Sale_Inv()
    End Sub
    Public Sub Get_Info_To_Sale_Inv()

        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" select  *  from Customer_Tbl  where  Cus_ID=@Cus_ID", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Cus_ID", SqlDbType.Int).Value = DGV_Cus.CurrentRow.Cells(0).Value.ToString
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Sale_Inv.Cus_ID.Text = dr("Cus_ID").ToString
                Sale_Inv.CusName.Text = dr("CusName").ToString
                Sale_Inv.CusPhone.Text = dr("CusPhone").ToString
                Sale_Inv.ToHim.Text = dr("ToHim").ToString
                Sale_Inv.Onhim.Text = dr("Onhim").ToString
                Aqsat_Inv.Cus_ID.Text = dr("Cus_ID").ToString
                Aqsat_Inv.CusName.Text = dr("CusName").ToString
                Aqsat_Inv.CusPhone.Text = dr("CusPhone").ToString
            End While
            dr.Close()
            'Con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Con.Close()
        End Try
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
    Public Sub Get_Cus_Balance()
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Dim cmd As New SqlCommand(" Select * from Customer_Tbl Where Cus_ID=" & DGV_Cus.CurrentRow.Cells(0).Value & "", Con)
        Dim adp As New SqlDataAdapter(cmd)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            Customer_Move.ToHim.Text = dr("ToHim").ToString
            Customer_Move.Onhim.Text = dr("Onhim").ToString
        End While
    End Sub
    Public Sub Get_Cus_Move()
       
        Try
            Customer_Move.DGV_Move.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from View_Cus_move where Cus_id=" & DGV_Cus.CurrentRow.Cells(0).Value & "", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Customer_Move.DGV_Move.Rows.Add(Convert.ToDateTime(dr("Move_Date")).ToString("dd/MM/yyyy"), dr("Move_Type").ToString, dr("Move_Total").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try
        Get_Cus_Balance()
        Customer_Move.ShowDialog()
    End Sub
End Class