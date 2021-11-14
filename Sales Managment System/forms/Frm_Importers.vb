Imports System.Data.SqlClient
Imports System.IO
Imports MSwordDllFiles

Public Class Frm_Importers

    Private Sub BtnNew_Click(sender As System.Object, e As System.EventArgs) Handles BtnNew.Click
        Me.Close()
        Add_Importer.ShowDialog()
    End Sub
    Public Sub LoadImporters()
        Try
            DGV_Imp.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from Importers_Tbl", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                DGV_Imp.Rows.Add(dr("Imp_ID").ToString, dr("ImpName").ToString, dr("ImpPhone").ToString, dr("ImpAddress").ToString, dr("ToHim").ToString, dr("Onhim").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try

    End Sub

    Private Sub Frm_Importers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadImporters()
    End Sub

    Public Sub Get_Info_To_Edit()

        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" select  *  from Importers_Tbl  where  Imp_ID=@Imp_ID", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Imp_ID", SqlDbType.Int).Value = DGV_Imp.CurrentRow.Cells(0).Value.ToString
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Edit_Importer.Imp_ID.Text = dr("Imp_ID").ToString
                Edit_Importer.ImpName.Text = dr("ImpName").ToString
                Edit_Importer.ImpPhone.Text = dr("ImpPhone").ToString
                Edit_Importer.ImpAddress.Text = dr("ImpAddress").ToString
                Edit_Importer.ToHim.Text = dr("ToHim").ToString
                Edit_Importer.Onhim.Text = dr("Onhim").ToString
                Dim data As Byte() = DirectCast(dr("ImpPic"), Byte())
                Dim ms As New MemoryStream(data)
                Edit_Importer.ImpPic.Image = Image.FromStream(ms)

            End While
            dr.Close()
            Con.Close()
            Edit_Importer.Show()
        Catch ex As Exception
            Con.Close()

        End Try

        Me.Close()
    End Sub

    Private Sub BtnEdit_Click(sender As System.Object, e As System.EventArgs) Handles BtnEdit.Click
        Get_Info_To_Edit()
    End Sub

    Public Sub Get_Pic()
        Try
            Con.Open()
            Dim cmd As New SqlCommand("Select ImpPic From Importers_Tbl Where Imp_ID=@Imp_ID", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Imp_ID", SqlDbType.Int).Value = DGV_Imp.CurrentRow.Cells(0).Value.ToString
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read()

                    Dim data As Byte() = DirectCast(dr("ImpPic"), Byte())
                    Dim ms As New MemoryStream(data)
                    Show_Pic.Prd_Pic.Image = Image.FromStream(ms)

                End While
                dr.Close()
                Con.Close()
                Show_Pic.Label1.Text = "صورة المورد"
                Show_Pic.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Con.Close()
        End Try



    End Sub

    Private Sub DGV_Imp_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Imp.CellClick
        If e.ColumnIndex = 6 Then
            Get_Pic()
        ElseIf e.ColumnIndex = 7 Then
            Get_Imp_Move()
        End If
    End Sub

    Public Sub Delete_Imporets_Tbl(ByVal DGV_Imp As DataGridView)
        Dim Position As Integer = DGV_Imp.CurrentRow.Index
        Dim ID_Position As Integer = DGV_Imp.Rows(Position).Cells(0).Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Importers_Tbl Where Imp_ID = @Imp_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Imp_ID", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف بيانات  المورد بنجاح.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub

    Private Sub BtnDelete_Click(sender As System.Object, e As System.EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Delete_Imporets_Tbl(DGV_Imp)
        End If
        LoadImporters()
    End Sub


    Public Function Get_All_Imp()
        Con.Open()
        Dim dt1 As New DataTable
        Dim cmd As New SqlCommand("Select * From Importers_Tbl ", Con)
        Dim adp As New SqlDataAdapter(cmd)
        adp.Fill(dt1)
        Con.Close()
        Return dt1
    End Function

    Public Sub Search_By_Phone()
        Try
            DGV_Imp.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from Importers_Tbl  where ImpPhone LIKE '%" & TxtSearch.Text & "%'", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                DGV_Imp.Rows.Add(dr("Imp_ID").ToString, dr("ImpName").ToString, dr("ImpPhone").ToString, dr("ImpAddress").ToString, dr("ToHim").ToString, dr("Onhim").ToString)
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
        LoadImporters()
        TxtSearch.Clear()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub DGV_Imp_DoubleClick(sender As System.Object, e As System.EventArgs) Handles DGV_Imp.DoubleClick
        Get_Info_To_Edit2()
    End Sub
    Public Sub Get_Info_To_Edit2()

        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" select  *  from Importers_Tbl  where  Imp_ID=@Imp_ID", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Imp_ID", SqlDbType.Int).Value = DGV_Imp.CurrentRow.Cells(0).Value.ToString
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Buy_Inv.Imp_ID.Text = dr("Imp_ID").ToString
                Buy_Inv.ImpName.Text = dr("ImpName").ToString
                Buy_Inv.ImpPhone.Text = dr("ImpPhone").ToString
                Buy_Inv.ToHim.Text = dr("ToHim").ToString
                Buy_Inv.Onhim.Text = dr("Onhim").ToString


            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Con.Close()

        End Try

        Me.Close()
    End Sub

    Public Sub Get_Imp_Move()

        Try
            Importers_Move.DGV_Move.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from View_Imp_Move where Imp_ID=@Imp_ID", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Imp_ID", SqlDbType.Int).Value = DGV_Imp.CurrentRow.Cells(0).Value
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Importers_Move.DGV_Move.Rows.Add(Convert.ToDateTime(dr("Move_Date")).ToString("dd/MM/yyyy"), dr("Move_Type").ToString, dr("Move_Total").ToString)
                Importers_Move.ToHim.Text = dr("ToHim").ToString
                Importers_Move.Onhim.Text = dr("Onhim").ToString
            End While
            dr.Close()
            Con.Close()
            Importers_Move.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Con.Close()
        End Try

    End Sub
End Class