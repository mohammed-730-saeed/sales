Imports System.Data.SqlClient

Public Class Frm_Select_Inv
    Public DT_Buy_Tbl As New DataTable
    Public DT_OneDate_BUY_TBL As New DataTable
    Public Sub Load_Buy_Tbl(ByVal DGV_Buy_Tbl As DataGridView, ByVal Meform As Form)
        DGV_Buy_Tbl.DataSource = Nothing
        DGV_Buy_Tbl.Rows.Clear()
        DT_Buy_Tbl.Clear()
        Dim Da As New SqlDataAdapter("Select Buy_Tbl.Buy_ID,Buy_Tbl.Buy_Date,Importers_Tbl.ImpName From Buy_Tbl ,Importers_Tbl Where Buy_Tbl.Imp_ID = Importers_Tbl.Imp_ID ", Con) '
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Da.Fill(DT_Buy_Tbl)
            Con.Close()
            Da = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Con.Close()
        End Try
        If DT_Buy_Tbl.Rows.Count <> 0 Then
            With DGV_Buy_Tbl
                .DataSource = DT_Buy_Tbl

            End With
        End If
    End Sub
    Public Sub FormatDGV_Buy_Tbl(ByVal DGV As DataGridView)
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("Buy_ID").HeaderText = "رقم الفاتورة"
                .Columns("Buy_ID").Width = 150
                .Columns("Buy_Date").HeaderText = "تاريخ الفاتورة"
                .Columns("Buy_Date").Width = 180
                .Columns("ImpName").HeaderText = "اسم المورد"
                .Columns("ImpName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
               
            End With
        End If
    End Sub

    Private Sub Frm_Select_Inv_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Load_Buy_Tbl(DGV_Buys, Me)
        FormatDGV_Buy_Tbl(DGV_Buys)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Get_Inv()
    End Sub
    Public Sub Get_Inv()
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" select  *  from View_Show_All_Buy  where  Buy_ID=@Buy_ID", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Buy_ID", SqlDbType.Int).Value = DGV_Buys.CurrentRow.Cells(0).Value
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    Re_Buy_Inv.Buy_ID.Text = dr("Buy_ID").ToString
                    Re_Buy_Inv.Imp_ID.Text = dr("Imp_ID").ToString
                    Re_Buy_Inv.ImpName.Text = dr("ImpName").ToString
                    Re_Buy_Inv.ImpPhone.Text = dr("ImpPhone").ToString
                    Re_Buy_Inv.ToHim.Text = dr("ToHim").ToString
                    Re_Buy_Inv.Onhim.Text = dr("Onhim").ToString
                    Re_Buy_Inv.Buy_Date.Value = dr("Buy_Date").ToString
                End While
                dr.Close()
                Con.Close()
            Else
                MsgBox("رقم المورد الذي قمت بادخاله غير موجود")

            End If

        Catch ex As Exception
            Con.Close()
        End Try
        Re_Buy_Inv.Show()
    End Sub

    Private Sub Cmb_Imp_DropDown(sender As System.Object, e As System.EventArgs) Handles Cmb_Imp.DropDown
        Frm_Manage_Buy_Inv.fillcmb_Importers_Tbl(Cmb_Imp)
    End Sub

    Private Sub Cmb_Imp_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Cmb_Imp.SelectedIndexChanged
        Try

            Dim dv As DataView = DT_Buy_Tbl.DefaultView

            dv.RowFilter = "ImpName LIKE '%" & Cmb_Imp.Text & "%' "

        Catch ex As Exception

        End Try
    End Sub
    
    Public Sub SearchBetweenOneDate(ByVal Buy_Date As Date)
        DT_OneDate_BUY_TBL.Clear()
        Dim Cmd2Date As New SqlCommand(" Select Buy_Tbl.Buy_ID,Buy_Tbl.Buy_Date,Importers_Tbl.ImpName From Buy_Tbl ,Importers_Tbl Where Buy_Tbl.Imp_ID = Importers_Tbl.Imp_ID and Buy_Tbl.Buy_Date like @Buy_Date", Con) '
        Cmd2Date.Parameters.Clear()
        Cmd2Date.Parameters.Add("@Buy_Date", SqlDbType.Date).Value = "#" & Buy_Date & "#"
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            DT_OneDate_BUY_TBL.Load(Cmd2Date.ExecuteReader)
            Con.Close()
            Cmd2Date = Nothing
        Catch ex As Exception
            Con.Close()
            MsgBox(Err.Description, MsgBoxStyle.Information)
        Finally
            If Con.State = ConnectionState.Open Then Con.Close()
        End Try
    End Sub

    Private Sub BtnToday_Click(sender As System.Object, e As System.EventArgs) Handles BtnToday.Click
        SearchBetweenOneDate(Date2.Value.ToString("dd/MM/yyyy"))
        DGV_Buys.DataSource = DT_OneDate_BUY_TBL
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Public Sub Load_Buy2_Tbl(ByVal DGV_Buy_Tbl As DataGridView, ByVal Meform As Form)
        DGV_Buy_Tbl.DataSource = Nothing
        DGV_Buy_Tbl.Rows.Clear()
        DT_Buy_Tbl.Clear()
        Dim Da As New SqlDataAdapter("Select Buy_Tbl.Buy_ID,Buy_Tbl.Buy_Date,Importers_Tbl.ImpName From Buy_Tbl ,Importers_Tbl Where Buy_Tbl.Imp_ID = Importers_Tbl.Imp_ID And  Buy_Tbl.Buy_ID=" & Prd_ID.Text & "", Con) '
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Da.Fill(DT_Buy_Tbl)
            Con.Close()
            Da = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Con.Close()
        End Try
        If DT_Buy_Tbl.Rows.Count <> 0 Then
            With DGV_Buy_Tbl
                .DataSource = DT_Buy_Tbl

            End With
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Load_Buy2_Tbl(DGV_Buys, Me)
        FormatDGV_Buy_Tbl(DGV_Buys)
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class