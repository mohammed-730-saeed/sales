Imports System.Data.SqlClient

Public Class Add_Cat

    Private Sub Add_Cat_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ClearControls()
        Cat_ID.Text = Max_ID("Cat_Tbl", "Cat_ID") + 100
        CatName.Focus()
    End Sub
    Public Sub ClearControls()
        Me.Cat_ID.Text = vbNullString
        Me.CatName.Text = vbNullString
    End Sub
    Public Sub Insert_Cat_Tbl(ByVal Cat_ID As Int32, ByVal CatName As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Cat_Tbl ( Cat_ID,CatName)values(@Cat_ID,@CatName)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Cat_ID", SqlDbType.Int).Value = Cat_ID
            .Parameters.AddWithValue("@CatName", SqlDbType.VarChar).Value = CatName
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة الصنف بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Private Sub Btnsave_Click(sender As System.Object, e As System.EventArgs) Handles Btnsave.Click
        If CatName.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If

        Insert_Cat_Tbl(Cat_ID.Text, CatName.Text)
        If MessageBox.Show("هل تريد اضافة صنف جديد اخر ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Me.Close()
            Dim frm As New Frm_Cat
            frm.TopLevel = False
            Home.HomePanel.Controls.Add(frm)
            frm.BringToFront()
            frm.Show()
        Else
            ClearControls()
            Cat_ID.Text = Max_ID("Cat_Tbl", "Cat_ID") + 100
            CatName.Focus()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub BtnClose_Click(sender As System.Object, e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class