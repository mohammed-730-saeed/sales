Imports System.Data.SqlClient

Public Class frmSplash

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Try
            Dim Con As New SqlClient.SqlConnection("Data Source=(localdb)\ProjectsV13;Initial Catalog = MyNew_Sales_DB;integrated security=true")
            Con.Open()
            Dim cb2 As String = "Select * from sysdatabases where name='MyNew_Sales_DB'"
            Dim cmd As New SqlCommand(cb2)
            cmd.Connection = Con
            Dim rdr As SqlDataReader
            rdr = cmd.ExecuteReader()
            If rdr.HasRows Then
                ProgressBar1.Visible = True
                ProgressBar1.Value = ProgressBar1.Value + 2
                If (ProgressBar1.Value = 10) Then
                    lblSet.Text = "تحميل ملفات التشغيل ....."
                ElseIf (ProgressBar1.Value = 20) Then
                    lblSet.Text = "تهيئة ملفات التشغيل ...."
                ElseIf (ProgressBar1.Value = 40) Then
                    lblSet.Text = "ضبط الاعدادات ...."
                ElseIf (ProgressBar1.Value = 60) Then
                    lblSet.Text = "اعداد الملفات ..."
                ElseIf (ProgressBar1.Value = 80) Then
                    lblSet.Text = "نهاية فحص النظام ..."
                ElseIf (ProgressBar1.Value = 100) Then
                    check_User()

                End If
            Else
                ProgressBar1.Visible = True
                ProgressBar1.Value = ProgressBar1.Value + 2
                If (ProgressBar1.Value = 10) Then
                    lblSet.Text = "تحميل ملفات التشغيل.."
                ElseIf (ProgressBar1.Value = 20) Then
                    lblSet.Text = "تهيئة ملفات التشغيل."
                ElseIf (ProgressBar1.Value = 40) Then
                    lblSet.Text = "ضبط الاعدادات.."
                ElseIf (ProgressBar1.Value = 60) Then
                    lblSet.Text = "اعداد الملفات.."
                ElseIf (ProgressBar1.Value = 80) Then
                    lblSet.Text = "نهاية فحص النظام.."
                ElseIf (ProgressBar1.Value = 100) Then
                    Frm_Sql_Setting.Reset()
                    Frm_Sql_Setting.Show()
                    Timer1.Enabled = False
                    Me.Hide()
                End If
            End If
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")

        End Try
    End Sub

    Public Sub check_User()

        Dim dt As New DataTable
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Dim Cmd As New SqlCommand("Select * From User_Tbl ", Con) '
        Dim adp As New SqlDataAdapter(Cmd)
        adp.Fill(dt)
        If dt.Rows.Count > 0 Then
            Frm_Login.Show()
            Timer1.Enabled = False
            Me.Hide()
        Else
            Frm_Users.Show()
            Timer1.Enabled = False
            Me.Hide()
        End If
        Con.Close()
    End Sub

    Private Sub frmSplash_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
End Class