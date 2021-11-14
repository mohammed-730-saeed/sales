Imports System.IO
Imports System.Data.SqlClient

Public Class Add_Importer
    Dim Photoname As String = ""
    Dim IsImageChanged As Boolean = False
    Public Sub Insert_Importers_Tbl(ByVal Imp_ID As Int32, ByVal ImpName As String, ByVal ImpPhone As String, ByVal ImpAddress As String, ByVal ToHim As Double, ByVal Onhim As Double, ByVal ImpPic As PictureBox)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Insert Into Importers_Tbl ( Imp_ID,ImpName,ImpPhone,ImpAddress,ToHim,Onhim,ImpPic)values(@Imp_ID,@ImpName,@ImpPhone,@ImpAddress,@ToHim,@Onhim,@ImpPic)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Imp_ID", SqlDbType.Int).Value = Imp_ID
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
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم إضافة بيانات المورد بنجاح", MsgBoxStyle.Information, "حفظ")
            Cmd = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnNew_Click(sender As System.Object, e As System.EventArgs) Handles BtnNew.Click
        If Imp_ID.Text = vbNullString Or ImpName.Text = vbNullString Or ImpAddress.Text = vbNullString Or ToHim.Text = vbNullString Or Onhim.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If

        Insert_Importers_Tbl(Imp_ID.Text, ImpName.Text, ImpPhone.Text, ImpAddress.Text, ToHim.Text, Onhim.Text, ImpPic)

        If MessageBox.Show("هل تريد اضافة عميل جديد اخر ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Me.Close()
            Dim frm As New Frm_Importers
            frm.TopLevel = False
            Home.HomePanel.Controls.Add(frm)
            frm.BringToFront()
            frm.Show()
        Else
            ClearControls()
            Imp_ID.Text = Max_ID("Importers_Tbl", "Imp_ID") + 100100
            ImpName.Focus()
        End If
    End Sub
    Public Sub ClearControls()
        Me.Imp_ID.Text = vbNullString
        Me.ImpName.Text = vbNullString
        Me.ImpPhone.Text = vbNullString
        Me.ImpAddress.Text = vbNullString
        Me.ImpPic.Image = My.Resources.flat_seo_30_512
    End Sub

    Private Sub Add_Importer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ClearControls()
        Imp_ID.Text = Max_ID("Importers_Tbl", "Imp_ID") + 100100
        ImpName.Focus()
    End Sub


    Private Sub BtnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles BtnBrowse.Click
        ChoosePicture(ImpPic)
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class