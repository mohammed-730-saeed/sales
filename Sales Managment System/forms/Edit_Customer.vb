Imports System.Data.SqlClient
Imports System.IO

Public Class Edit_Customer
    Dim Photoname As String = ""
    Dim IsImageChanged As Boolean = False
    Private Sub BtnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles BtnBrowse.Click
        ChoosePicture(CusPic)
    End Sub

    Private Sub BStartCapture_Click(sender As System.Object, e As System.EventArgs) Handles BStartCapture.Click
        Try
            Dim k As New Frm_Camera
            k.ShowDialog()
            If TempFileNames2.Length > 0 Then

                CusPic.Image = Image.FromFile(TempFileNames2)
                Photoname = TempFileNames2
                IsImageChanged = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Public Sub Update_Customer_Tbl(ByVal CusName As String, ByVal CusPhone As String, ByVal CusAddress As String, ByVal ToHim As Double, ByVal Onhim As Double, ByVal CusPic As PictureBox, ByVal Cus_IDW As Int32)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Update Customer_Tbl Set CusName = @CusName,CusPhone = @CusPhone,CusAddress = @CusAddress,ToHim = @ToHim,Onhim = @Onhim,CusPic = @CusPic Where Cus_ID = @Cus_ID"
                .Parameters.Clear()
                .Parameters.AddWithValue("@CusName", SqlDbType.VarChar).Value = CusName
                .Parameters.AddWithValue("@CusPhone", SqlDbType.VarChar).Value = CusPhone
                .Parameters.AddWithValue("@CusAddress", SqlDbType.VarChar).Value = CusAddress
                .Parameters.AddWithValue("@ToHim", SqlDbType.Decimal).Value = ToHim
                .Parameters.AddWithValue("@Onhim", SqlDbType.Decimal).Value = Onhim
                Dim ms As New MemoryStream()
                Dim bmpImage As New Bitmap(CusPic.Image)
                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim data As Byte() = ms.GetBuffer()
                Dim p As New SqlParameter("@CusPic", SqlDbType.Image)
                p.Value = data
                .Parameters.Add(p)
                .Parameters.AddWithValue("@Cus_ID", SqlDbType.Int).Value = Cus_IDW
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم تعديل بيانات العميل بنجاح", MsgBoxStyle.Information, "تعديل")
            Cmd = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnNew_Click(sender As System.Object, e As System.EventArgs) Handles BtnNew.Click
        If CusName.Text = vbNullString Or CusPhone.Text = vbNullString Or CusAddress.Text = vbNullString Or ToHim.Text = vbNullString Or Onhim.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Update_Customer_Tbl(CusName.Text, CusPhone.Text, CusAddress.Text, ToHim.Text, Onhim.Text, CusPic, Cus_ID.Text)
        Me.Close()
        Dim frm As New Frm_Customers
        frm.TopLevel = False
        Home.HomePanel.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub
End Class