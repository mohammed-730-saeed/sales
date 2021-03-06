Imports System.Data.SqlClient

Public Class CustomerList
    Public DT_Customer_Tbl As New DataTable

    Public Sub Load_Customer_Tbl(ByVal DGV_Customer_Tbl As DataGridView, ByVal Meform As Form)
        DGV_Customer_Tbl.DataSource = Nothing
        DGV_Customer_Tbl.Rows.Clear()
        DT_Customer_Tbl.Clear()
        Dim Da As New SqlDataAdapter("Select Cus_ID,CusName,CusPhone,ToHim,Onhim From Customer_Tbl ", Con) '
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Da.Fill(DT_Customer_Tbl)
            Con.Close()
            Da = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Con.Close()
        End Try
        If DT_Customer_Tbl.Rows.Count <> 0 Then
            With DGV_Customer_Tbl
                .DataSource = DT_Customer_Tbl
            End With
        End If
    End Sub

    Private Sub CustomerList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Load_Customer_Tbl(DGV_Cus, Me)
        FormatDGV_Customer_Tbl(DGV_Cus)
    End Sub

    Public Sub FormatDGV_Customer_Tbl(ByVal DGV As DataGridView)
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("Cus_ID").HeaderText = "رقم العميل"
                .Columns("Cus_ID").Width = 110
                .Columns("CusName").HeaderText = "اسم العميل"
                .Columns("CusName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns("CusPhone").HeaderText = "رقم الهاتف"
                .Columns("CusPhone").Width = 160
                .Columns("ToHim").HeaderText = "دائن"
                .Columns("ToHim").Width = 100
                .Columns("Onhim").HeaderText = "مدين"
                .Columns("Onhim").Width = 100
                SettingAnyDGV(DGV)
            End With
        End If
    End Sub

    Public Sub SettingAnyDGV(ByVal DGV As DataGridView)

        DGV.AllowUserToAddRows = False
        DGV.AllowUserToDeleteRows = False
        DGV.AllowUserToOrderColumns = True
        DGV.AllowUserToResizeColumns = False
        DGV.AllowUserToResizeRows = False
        DGV.RightToLeft = RightToLeft.Yes
        DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        DGV.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.Khaki
        DGV.BackgroundColor = System.Drawing.Color.Azure
        DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DGV.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        DGV.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DGV.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DGV.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        DGV.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DGV.Cursor = System.Windows.Forms.Cursors.Hand
        DGV.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DGV.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control
        DGV.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        DGV.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkCyan
        DGV.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Yellow
        DGV.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        DGV.GridColor = System.Drawing.Color.Red
        DGV.RowsDefaultCellStyle.BackColor = System.Drawing.Color.Beige
        DGV.MultiSelect = False
        DGV.ColumnHeadersHeight = 33
        'Height Rows
        Dim RH As Integer = DGV.Rows.Count - 1
        Dim ii As Integer
        If DGV IsNot Nothing Then
            For ii = 0 To RH
                DGV.Rows.Item(ii).Height = 26
            Next
        End If
   
    End Sub

    Private Sub TxtSearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtSearch.TextChanged
        Try

            Dim dv As DataView = DT_Customer_Tbl.DefaultView

            dv.RowFilter = "CusName+CusPhone LIKE '%" & TxtSearch.Text & "%' "

        Catch ex As Exception

        End Try
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            With DGV_Cus.CurrentRow
                Frm_Receipt.Cus_ID.Text = .Cells("Cus_ID").Value.ToString()
                Frm_Receipt.CusName.Text = .Cells("CusName").Value.ToString()
                Frm_Receipt.CusPhone.Text = .Cells("CusPhone").Value.ToString()
                Frm_Receipt.ToHim.Text = .Cells("ToHim").Value.ToString()
                Frm_Receipt.Onhim.Text = .Cells("Onhim").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Frm_Receipt.ShowDialog()
        Me.Close()
    End Sub
End Class