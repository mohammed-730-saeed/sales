Imports System.Data.SqlClient

Public Class Frm_Login

    Public Sub login(ByVal txtusername As String, ByVal txtpassword As String, Frm As Form)

        Con.Open()
        Dim cmd As New SqlCommand("select * from User_Tbl  where UserName = @UserName and Password = @Password", Con)
        cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = txtusername
        cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = txtpassword
        Dim adp As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        adp.Fill(dt)
        If dt.Rows.Count() <= 0 Then
            MessageBox.Show("اسم المستخدم او كلمة المرور غير صحيحين")
        Else
            Dim dr As SqlDataReader = cmd.ExecuteReader
            dr.Read()
            If dr("Is_User") = True Then
                Me.Close()
                Home.Show()

                Home.ToolStripMenuItem1.Enabled = dr("M_Product")
                Home.ToolStripMenuItem2.Enabled = dr("M_Customer")
                Home.ToolStripMenuItem4.Enabled = dr("M_Importer")
                Home.ToolStripMenuItem6.Enabled = dr("M_Buy")
                Home.ToolStripMenuItem8.Enabled = dr("M_Sale")
                Home.ToolStripMenuItem12.Enabled = dr("M_Store")
                Home.ToolStripMenuItem13.Enabled = dr("M_Users")

                Home.ToolStripMenuItem17.Enabled = dr("M_Employee")
                Home.ToolStripMenuItem10.Enabled = dr("M_Setting")

                Home.ToolStripMenuItem16.Enabled = dr("M_Database")
                Home.LblUser.Text = dr("FullName").ToString
                Home.Show()
                dr.Close()
                Con.Close()
            Else
                MessageBox.Show("المعذرة حسابك مغلق يرجى مراجعة مدير النظام", "الحساب", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            End If

        End If
        Con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        login(TxtUserName.Text, TxtPassword.Text, Me)
    End Sub
End Class