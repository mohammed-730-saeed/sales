Imports System.IO
Imports System.Data.SqlClient

Public Class Edit_Product

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub BtnClose_Click(sender As System.Object, e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles BtnBrowse.Click
        ChoosePicture(Prd_Pic)
    End Sub

    Public Sub Update_Product_Tbl(ByVal Prd_Code As String, ByVal Prd_Name As String, ByVal Cat_ID As Int32, ByVal Unit_ID As Int32, ByVal PrdLimit As Int32, ByVal Prd_Pic As PictureBox, ByVal Prd_IDW As Int32)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Update Product_Tbl Set Prd_Code = @Prd_Code,Prd_Name = @Prd_Name,Cat_ID = @Cat_ID,Unit_ID = @Unit_ID,PrdLimit=@PrdLimit,Prd_Pic = @Prd_Pic Where Prd_ID = @Prd_ID"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Prd_Code", SqlDbType.VarChar).Value = Prd_Code
                .Parameters.AddWithValue("@Prd_Name", SqlDbType.VarChar).Value = Prd_Name
                .Parameters.AddWithValue("@Cat_ID", SqlDbType.Int).Value = Cat_ID
                .Parameters.AddWithValue("@Unit_ID", SqlDbType.Int).Value = Unit_ID
                .Parameters.AddWithValue("@prdLimit", SqlDbType.Int).Value = PrdLimit
                Dim ms As New MemoryStream()
                Dim bmpImage As New Bitmap(Prd_Pic.Image)
                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim data As Byte() = ms.GetBuffer()
                Dim p As New SqlParameter("@Prd_Pic", SqlDbType.Image)
                p.Value = data
                .Parameters.Add(p)
                .Parameters.AddWithValue("@Prd_ID", SqlDbType.Int).Value = Prd_IDW
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم تعديل بيانات المنتج بنجاح", MsgBoxStyle.Information, "تعديل")
            Cmd = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Btnsave_Click(sender As System.Object, e As System.EventArgs) Handles Btnsave.Click
        If Prd_ID.Text = vbNullString Or Prd_Code.Text = vbNullString Or Prd_Name.Text = vbNullString Or Cmb_Cat.Text = vbNullString Or Cmb_Unit.Text = vbNullString Or IsNothing(Prd_Pic) Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Update_Product_Tbl(Prd_Code.Text, Prd_Name.Text, Cmb_Cat.SelectedValue, Cmb_Unit.SelectedValue, PrdLimit.Text, Prd_Pic, Prd_ID.Text)
        Me.Close()
        Dim frm As New Frm_Products
        frm.TopLevel = False
        Home.HomePanel.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Frm_Cat.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Frm_Unit.ShowDialog()
    End Sub
End Class