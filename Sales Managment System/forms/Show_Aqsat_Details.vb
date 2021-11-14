Public Class Show_Aqsat_Details

  
    Private Sub DataGridView1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.ColumnIndex = 5 Then
            If DataGridView1.CurrentRow.Cells(4).Value = "مدفوع" Then

                MsgBox("هذا القسط تم دفعه وهو مسدد لا يمكن تسديده مرة اخرى")
                Exit Sub
            Else
                Paid()
            End If

        End If
    End Sub

    Public Sub Paid()
        Frm_Paid_Qast.Sanad_ID.Text = Max_ID("Qast_Paid", "Sanad_ID") + 1
        Frm_Paid_Qast.Aqsat_Sale_ID.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        Frm_Paid_Qast.Qast_ID.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        Frm_Paid_Qast.PaidDate.Value = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        Frm_Paid_Qast.Money_Paid.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()

        Frm_Paid_Qast.ShowDialog()

    End Sub
End Class