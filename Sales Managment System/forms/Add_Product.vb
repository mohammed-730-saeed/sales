Imports System.IO
Imports System.Data.SqlClient

Public Class Add_Product

    Private Sub Cmb_Cat_DropDown(sender As System.Object, e As System.EventArgs) Handles Cmb_Cat.DropDown
        fillcmb_Cat_Tbl(Cmb_Cat)
    End Sub

    Private Sub Cmb_Unit_DropDown(sender As System.Object, e As System.EventArgs) Handles Cmb_Unit.DropDown
        fillcmb_Unit_Tbl(Cmb_Unit)
    End Sub

    Private Sub BtnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles BtnBrowse.Click
        ChoosePicture(Prd_Pic)
    End Sub

    Private Sub Add_Product_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ClearControls()
        Prd_ID.Text = Max_ID("Product_Tbl", "Prd_ID") + 110
        Prd_Code.Focus()
    End Sub
    Public Sub ClearControls()
        Me.Prd_ID.Text = vbNullString
        Me.Prd_Code.Text = vbNullString
        Me.Prd_Name.Text = vbNullString
        Me.Cmb_Cat.Text = vbNullString
        Me.Cmb_Unit.Text = vbNullString
        Me.PrdLimit.Text = vbNullString
        Me.Prd_Pic.Image = My.Resources.pic
    End Sub
    Public Sub Insert_Product_Tbl(ByVal Prd_ID As Int32, ByVal Prd_Code As String, ByVal Prd_Name As String, ByVal Cat_ID As Int32, ByVal Unit_ID As Int32, ByVal PrdLimit As Int32, ByVal Prd_Pic As PictureBox)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Insert Into Product_Tbl ( Prd_ID,Prd_Code,Prd_Name,Cat_ID,Unit_ID,PrdLimit,Prd_Pic)values(@Prd_ID,@Prd_Code,@Prd_Name,@Cat_ID,@Unit_ID,@PrdLimit,@Prd_Pic)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Prd_ID", SqlDbType.Int).Value = Prd_ID
                .Parameters.AddWithValue("@Prd_Code", SqlDbType.VarChar).Value = Prd_Code
                .Parameters.AddWithValue("@Prd_Name", SqlDbType.VarChar).Value = Prd_Name
                .Parameters.AddWithValue("@Cat_ID", SqlDbType.Int).Value = Cat_ID
                .Parameters.AddWithValue("@Unit_ID", SqlDbType.Int).Value = Unit_ID
                .Parameters.AddWithValue("@PrdLimit", SqlDbType.Int).Value = PrdLimit
                Dim ms As New MemoryStream()
                Dim bmpImage As New Bitmap(Prd_Pic.Image)
                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim data As Byte() = ms.GetBuffer()
                Dim p As New SqlParameter("@Prd_Pic", SqlDbType.Image)
                p.Value = data
                .Parameters.Add(p)
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم إضافة بيانات المنتج بنجاح", MsgBoxStyle.Information, "حفظ")
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

        Insert_Product_Tbl(Prd_ID.Text, Prd_Code.Text, Prd_Name.Text, Cmb_Cat.SelectedValue, Cmb_Unit.SelectedValue, PrdLimit.Text, Prd_Pic)
        If MessageBox.Show("هل تريد اضافة منتج جديد اخر ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Me.Close()
            Dim frm As New Frm_Products
            frm.TopLevel = False
            Home.HomePanel.Controls.Add(frm)
            frm.BringToFront()
            frm.Show()
        Else
            ClearControls()
            Prd_ID.Text = Max_ID("Product_Tbl", "Prd_ID") + 110
            Prd_Code.Focus()
        End If
    End Sub



    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub BtnClose_Click(sender As System.Object, e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Add_Cat.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Add_Unit.ShowDialog()
    End Sub

    Private Sub Prd_Code_KeyDown(sender As Object, e As KeyEventArgs) Handles Prd_Code.KeyDown
        If e.KeyCode = Keys.Enter Then
            Prd_Name.Select()
        End If
    End Sub

    Private Sub Prd_Name_KeyDown(sender As Object, e As KeyEventArgs) Handles Prd_Name.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cmb_Cat.Select()
        End If
    End Sub
End Class