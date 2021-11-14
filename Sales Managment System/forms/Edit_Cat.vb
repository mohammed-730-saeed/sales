Imports System.Data.SqlClient

Public Class Edit_Cat

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub BtnClose_Click(sender As System.Object, e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
    Public Sub Update_Cat_Tbl(ByVal CatName As String, ByVal Cat_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Cat_Tbl Set CatName = @CatName Where Cat_ID = @Cat_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@CatName", SqlDbType.varchar).Value = CatName
            .Parameters.AddWithValue("@Cat_ID", SqlDbType.Int).Value = Cat_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل بيانات الصنف بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub


    Private Sub Btnsave_Click(sender As System.Object, e As System.EventArgs) Handles Btnsave.Click
        If CatName.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Update_Cat_Tbl(CatName.Text, Cat_ID.Text)
        Me.Close()
        Dim frm As New Frm_Cat
        frm.TopLevel = False
        Home.HomePanel.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub
End Class