Imports System.Data.SqlClient

Public Class Frm_Job

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        ClearControls()
        JobID.Text = Max_ID("Job_Tbl", "JobID") + 202010
        JobName.Focus()
    End Sub
    Public Sub ClearControls()
        Me.JobID.Text = vbNullString
        Me.JobName.Text = vbNullString
    End Sub
    Public Sub LoadJob()
        Try
            DGVJob.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from Job_Tbl", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                DGVJob.Rows.Add(dr("JobID").ToString, dr("JobName").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Con.Close()
        End Try

    End Sub

    Public Sub Insert_Job_Tbl(ByVal JobID As Int32, ByVal JobName As String)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Insert Into Job_Tbl ( JobID,JobName)values(@JobID,@JobName)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@JobID", SqlDbType.Int).Value = JobID
                .Parameters.AddWithValue("@JobName", SqlDbType.VarChar).Value = JobName
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
            Cmd = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Try
            If JobName.Text = vbNullString Then
                MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Exit Sub
            End If

            Insert_Job_Tbl(JobID.Text, JobName.Text)
            ClearControls()
            LoadJob()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Try
            If JobName.Text = vbNullString Then
                MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Exit Sub
            End If
            Update_Job_Tbl(JobName.Text, JobID.Text)
            ClearControls()
            LoadJob()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Update_Job_Tbl(ByVal JobName As String, ByVal JobIDW As Int32)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Update Job_Tbl Set JobName = @JobName Where JobID = @JobID"
                .Parameters.Clear()
                .Parameters.AddWithValue("@JobName", SqlDbType.VarChar).Value = JobName
                .Parameters.AddWithValue("@JobID", SqlDbType.Int).Value = JobIDW
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
            Cmd = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub Delete_Job_Tbl(ByVal dgv_Job_Tbl As DataGridView)
        Try
            Dim Position As Integer = dgv_Job_Tbl.CurrentRow.Index
            Dim ID_Position As Integer = dgv_Job_Tbl.Rows(Position).Cells(0).Value
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Delete  From Job_Tbl Where JobID = @JobID"
                .Parameters.Clear()
                .Parameters.AddWithValue("@JobID", SqlDbType.Int).Value = ID_Position
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
            Cmd = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Delete_Job_Tbl(DGVJob)
        End If
        ClearControls()
        LoadJob()
    End Sub

    Private Sub DGVJob_Click(sender As System.Object, e As System.EventArgs) Handles DGVJob.Click
        Try
            With DGVJob
                Me.JobID.Text = .CurrentRow.Cells(0).Value.ToString()
                Me.JobName.Text = .CurrentRow.Cells(1).Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Frm_Job_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadJob()
    End Sub


End Class