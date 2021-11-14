Imports System.IO
Imports System.Data.SqlClient

Public Class Add_Customer
    Dim Photoname As String = ""
    Dim IsImageChanged As Boolean = False
    Private Sub BStartCapture_Click(sender As System.Object, e As System.EventArgs) Handles BStartCapture.Click
        Try
            Frm_Camera.ShowDialog()
            If TempFileNames2.Length > 0 Then

                CusPic.Image = Image.FromFile(TempFileNames2)
                Photoname = TempFileNames2
                IsImageChanged = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Add_Customer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ClearControls()
        Cus_ID.Text = Max_ID("Customer_Tbl", "Cus_ID") + 10
        CusName.Focus()

    End Sub

    Public Sub ClearControls()
        Me.Cus_ID.Text = vbNullString
        Me.CusName.Text = vbNullString
        Me.CusPhone.Text = vbNullString
        Me.CusAddress.Text = vbNullString
        Me.CusPic.Image = My.Resources.flat_seo_30_512
    End Sub

    Private Sub BtnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles BtnBrowse.Click
        ChoosePicture(CusPic)
    End Sub

    Public Sub Insert_Customer_Tbl(ByVal Cus_ID As Int32, ByVal CusName As String, ByVal CusPhone As String, ByVal CusAddress As String, ByVal ToHim As Double, ByVal Onhim As Double, ByVal CusPic As PictureBox)
        Try

            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Insert Into Customer_Tbl ( Cus_ID,CusName,CusPhone,CusAddress,ToHim,Onhim,CusPic)values(@Cus_ID,@CusName,@CusPhone,@CusAddress,@ToHim,@Onhim,@CusPic)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Cus_ID", SqlDbType.Int).Value = Cus_ID
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
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم إضافة بيانات العميل بنجاح", MsgBoxStyle.Information, "حفظ")
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

        Insert_Customer_Tbl(Cus_ID.Text, CusName.Text, CusPhone.Text, CusAddress.Text, ToHim.Text, Onhim.Text, CusPic)
        If MessageBox.Show("هل تريد اضافة عميل جديد اخر ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Me.Close()
            Dim frm As New Frm_Customers
            frm.TopLevel = False
            Home.HomePanel.Controls.Add(frm)
            frm.BringToFront()
            frm.Show()
        Else
            ClearControls()
            Cus_ID.Text = Max_ID("Customer_Tbl", "Cus_ID") + 10
            CusName.Focus()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub CusName_KeyDown(sender As Object, e As KeyEventArgs) Handles CusName.KeyDown
        If e.KeyCode = Keys.Enter Then
            CusPhone.Select()
        End If
    End Sub

    Private Sub CusPhone_KeyDown(sender As Object, e As KeyEventArgs) Handles CusPhone.KeyDown
        If e.KeyCode = Keys.Enter Then
            CusAddress.Select()
        End If
    End Sub
End Class