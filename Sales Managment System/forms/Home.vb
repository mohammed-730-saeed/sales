Imports System.IO
Imports Microsoft.SqlServer.Management.Smo
Imports System.Globalization
Imports System.Data.SqlClient

Public Class Home
    Dim Filename As String
    Dim i1, i2 As Integer
    Sub Backup()
        Try
            Dim dt As DateTime = Today
            Dim destdir As String = "script " & System.DateTime.Now.ToString("dd-MM-yyyy_h-mm-ss") & ".bak"
            Dim objdlg As New SaveFileDialog
            objdlg.FileName = destdir
            objdlg.ShowDialog()
            Filename = objdlg.FileName
            Cursor = Cursors.WaitCursor
            Timer2.Enabled = True
            con.Open()
            Dim sql As String = "backup database script to disk='" & Filename & "'with init,stats=10"
            Dim cmd As New SqlCommand(Sql)
            cmd.Connection = con
            cmd.ExecuteReader()
            con.Close()
            MessageBox.Show("تم حفظ النسخة الاحتياطية من قاعدة البيانات")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub

    Public Sub RestoreDatabase()
        Try
            With OpenFileDialog1
                .Filter = ("DB Backup File|*.bak;")
                .FilterIndex = 4
            End With
            'Clear the file name
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Cursor = Cursors.WaitCursor
                Timer2.Enabled = True
                SqlConnection.ClearAllPools()
                Con.Open()
                Dim sql As String = "USE (localdb)\ProjectsV13 ALTER DATABASE script SET Single_User WITH Rollback Immediate Restore database script FROM disk='" & OpenFileDialog1.FileName & "' WITH REPLACE ALTER DATABASE script SET Multi_User "
                Dim cmd As New SqlCommand(sql)
                cmd.Connection = Con
                cmd.ExecuteReader()
                Con.Close()
                MessageBox.Show("تمت استعادة قاعدة البيانات بنجاح", "استعادة القاعدة ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub




    Private Sub ادارةالاصنافToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ادارةالاصنافToolStripMenuItem.Click
        Dim frm As New Frm_Cat
        frm.TopLevel = False
        HomePanel.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub

    Private Sub ادارةالوحداتToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ادارةالوحداتToolStripMenuItem.Click
        Dim frm As New Frm_Unit
        frm.TopLevel = False
        HomePanel.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub

    Private Sub اضافةمنتججديدToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles اضافةمنتججديدToolStripMenuItem.Click
        Add_Product.ShowDialog()
    End Sub

    Private Sub ادارةالمنتجاتToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ادارةالمنتجاتToolStripMenuItem.Click
        Dim frm As New Frm_Products
        frm.TopLevel = False
        HomePanel.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub
    Public Sub Check()
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Dim cmd As New SqlCommand(" select  *  from View_Store ", Con)
        Dim adp As New SqlDataAdapter(cmd)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            If dr("Qty").ToString > dr("PrdLimit").ToString Then
                MsgBox(" المنتج وصل حد الطلب " & dr("Prd_Name").ToString)
            End If
        End While
        dr.Close()
        Con.Close()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Dim frm As New Frm_Customers
        frm.TopLevel = False
        HomePanel.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem5.Click
        Dim frm As New Frm_Importers
        frm.TopLevel = False
        HomePanel.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub

    Private Sub فاتورةمشترياتجديدةToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles فاتورةمشترياتجديدةToolStripMenuItem.Click

        Buy_Inv.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem11.Click
        Frm_Tax.Show()
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New Frm_Manage_Buy_Inv
        frm.TopLevel = False
        HomePanel.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub


    Private Sub ادارةالمخزنToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ادارةالمخزنToolStripMenuItem.Click
        Dim frm As New Frm_Store
        frm.TopLevel = False
        HomePanel.Controls.Add(frm)
        frm.BringToFront()
        frm.Show()
    End Sub

    Private Sub مرتحعشراءToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles مرتحعشراءToolStripMenuItem.Click
        Re_Buy_Inv.ShowDialog()
    End Sub

    Private Sub فاتورةبيعجديدةToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles فاتورةبيعجديدةToolStripMenuItem.Click
        Sale_Inv.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem9.Click

        Re_Sale_Inv.ShowDialog()
    End Sub



    Private Sub تسديدفاتورةToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles تسديدفاتورةToolStripMenuItem1.Click
        ImportersList.ShowDialog()
    End Sub

    Private Sub Home_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Frm_Login.ShowDialog()
        'Label6.Text = DateTime.Now.ToLongTimeString()

        Timer1.Start()

    End Sub

    Private Sub اضافةجديدToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Add_Exp.ShowDialog()
    End Sub



    Private Sub ادارةالوظائفToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ادارةالوظائفToolStripMenuItem.Click
        Frm_Job.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem18_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem18.Click
        Add_Emp.ShowDialog()
    End Sub

    Private Sub ادارةالموظفينToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ادارةالموظفينToolStripMenuItem.Click
        Frm_Emp.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem19_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem19.Click
        Backup()
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Cursor = Cursors.Default
        Timer2.Enabled = False
    End Sub

    Private Sub الاستعادةToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles الاستعادةToolStripMenuItem.Click
        RestoreDatabase()
    End Sub

    Private Sub ToolStripMenuItem14_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem14.Click
        Frm_Users.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem7_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        Frm_Login.ShowDialog()
    End Sub

    Private Sub القائمةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles القائمةToolStripMenuItem.Click
        CustomerList.ShowDialog()

    End Sub

    Private Sub ادارةالمبيعاتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ادارةالمبيعاتToolStripMenuItem.Click
        Frm_Sale_Inv_Manage.Show()
    End Sub

    Private Sub ادارةالمشترياتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ادارةالمشترياتToolStripMenuItem.Click
        Frm_Manage_Buy_Inv.Show()
    End Sub

    Private Sub فواتيرToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles فواتيرToolStripMenuItem.Click
        Frm_Select_Inv.Show()
    End Sub

    Private Sub اضافةعميلجديدToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles اضافةعميلجديدToolStripMenuItem.Click
        Add_Customer.Show()
    End Sub
End Class
