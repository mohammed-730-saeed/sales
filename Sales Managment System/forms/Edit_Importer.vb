Imports System.IO
Imports System.Data.SqlClient

Public Class Edit_Importer
    Dim Photoname As String = ""
    Dim IsImageChanged As Boolean = False

    Private Sub BtnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles BtnBrowse.Click
        ChoosePicture(ImpPic)
    End Sub



    Public Sub Update_Importers_Tbl(ByVal ImpName As String, ByVal ImpPhone As String, ByVal ImpAddress As String, ByVal ToHim As Double, ByVal Onhim As Double, ByVal ImpPic As PictureBox, ByVal Imp_IDW As Int32)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Update Importers_Tbl Set ImpName = @ImpName,ImpPhone = @ImpPhone,ImpAddress = @ImpAddress,ToHim = @ToHim,Onhim = @Onhim,ImpPic = @ImpPic Where Imp_ID = @Imp_ID"
                .Parameters.Clear()
                .Parameters.AddWithValue("@ImpName", SqlDbType.VarChar).Value = ImpName
                .Parameters.AddWithValue("@ImpPhone", SqlDbType.VarChar).Value = ImpPhone
                .Parameters.AddWithValue("@ImpAddress", SqlDbType.VarChar).Value = ImpAddress
                .Parameters.AddWithValue("@ToHim", SqlDbType.Decimal).Value = ToHim
                .Parameters.AddWithValue("@Onhim", SqlDbType.Decimal).Value = Onhim
                Dim ms As New MemoryStream()
                Dim bmpImage As New Bitmap(ImpPic.Image)
                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim data As Byte() = ms.GetBuffer()
                Dim p As New SqlParameter("@ImpPic", SqlDbType.Image)
                p.Value = data
                .Parameters.Add(p)
                .Parameters.AddWithValue("@Imp_ID", SqlDbType.Int).Value = Imp_IDW
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم تعديل بيانات المورد بنجاح", MsgBoxStyle.Information, "تعديل")
            Cmd = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnNew_Click(sender As System.Object, e As System.EventArgs) Handles BtnNew.Click
        If Imp_ID.Text = vbNullString Or ImpName.Text = vbNullString Or ImpPhone.Text = vbNullString Or ImpAddress.Text = vbNullString Or ToHim.Text = vbNullString Or Onhim.Text = vbNullString Or IsNothing(ImpPic) Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Update_Importers_Tbl(ImpName.Text, ImpPhone.Text, ImpAddress.Text, ToHim.Text, Onhim.Text, ImpPic, Imp_ID.Text)
        Me.Close()
        Dim frm As New Frm_Importers
        frm.TopLevel = False
        Home.HomePanel.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class