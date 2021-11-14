Imports System.Data.SqlClient

Public Class Frm_Add_Aqsat

    Private Sub Frm_Add_Aqsat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txt_date.Text = Aqsat_Inv.StartDate.Value.ToString("dd/MM/yyyy")
        Qast_Status.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try

            For i As Integer = 0 To Val(Aqsat_No.Text)

                If txt_id.Text = Val(Aqsat_No.Text) + 1 Then
                    Exit For
                Else
                    DataGridView1.Rows.Add(txt_id.Text, txt_date.Text, Qast_Amount.Text, Qast_Status.Text)
                End If
                txt_id.Text += 1
                Dim r As Date = txt_date.Text
                txt_date.Text = (r.AddMonths(1))
            Next
            txt_id.Text = Val(Aqsat_No.Text)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Insert_Qast_Details_Tbl()
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Insert Into Qast_Details_Tbl ( Aqsat_Sale_ID,Qast_ID,Qast_Amount,Qast_date,Qast_Status)values(@Aqsat_Sale_ID,@Qast_ID,@Qast_Amount,@Qast_date,@Qast_Status)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Aqsat_Sale_ID", SqlDbType.Int).Value = Aqsat_Sale_ID.Text
                .Parameters.AddWithValue("@Qast_ID", SqlDbType.Int).Value = DataGridView1.Rows(i).Cells(0).Value
                .Parameters.AddWithValue("@Qast_Amount", SqlDbType.Decimal).Value = DataGridView1.Rows(i).Cells(2).Value
                .Parameters.AddWithValue("@Qast_date", SqlDbType.Date).Value = DataGridView1.Rows(i).Cells(1).Value
                .Parameters.AddWithValue("@Qast_Status", SqlDbType.VarChar).Value = DataGridView1.Rows(i).Cells(3).Value
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()

            Cmd = Nothing

        Next
        MsgBox("تم اضافة جميع الاقساط بنجاح  ", MsgBoxStyle.Information, "حفظ")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Insert_Qast_Details_Tbl()
    End Sub
End Class