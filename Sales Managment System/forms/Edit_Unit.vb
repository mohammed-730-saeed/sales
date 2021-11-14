Imports System.Data.SqlClient

Public Class Edit_Unit

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub BtnClose_Click(sender As System.Object, e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Public Sub Update_Unit_Tbl(ByVal UnitName As String, ByVal Unit_IDW As Int32)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Update Unit_Tbl Set UnitName = @UnitName Where Unit_ID = @Unit_ID"
                .Parameters.Clear()
                .Parameters.AddWithValue("@UnitName", SqlDbType.VarChar).Value = UnitName
                .Parameters.AddWithValue("@Unit_ID", SqlDbType.Int).Value = Unit_IDW
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم تعديل بيانات الوحدة بنجاح", MsgBoxStyle.Information, "تعديل")
            Cmd = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Btnsave_Click(sender As System.Object, e As System.EventArgs) Handles Btnsave.Click
        If UnitName.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Update_Unit_Tbl(UnitName.Text, Unit_ID.Text)
        Me.Close()
        Dim frm As New Frm_Unit
        frm.TopLevel = False
        Home.HomePanel.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub
End Class