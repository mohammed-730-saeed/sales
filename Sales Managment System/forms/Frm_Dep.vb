Imports System.Data.SqlClient

Public Class Frm_Dep
    Public Sub LoadDep()
        Try
            DGVDep.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from Department_Tbl", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                DGVDep.Rows.Add(dr("DepartmentID").ToString, dr("DepartmentName").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try

    End Sub
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        If DepartmentName.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Insert_Department_Tbl(DepartmentID.Text, DepartmentName.Text)
        LoadDep()
        ClearControls()
    End Sub
    Public Sub Insert_Department_Tbl(ByVal DepartmentID As Int32, ByVal DepartmentName As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Department_Tbl ( DepartmentID,DepartmentName)values(@DepartmentID,@DepartmentName)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@DepartmentID", SqlDbType.Int).Value = DepartmentID
            .Parameters.AddWithValue("@DepartmentName", SqlDbType.VarChar).Value = DepartmentName
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        ClearControls()
        DepartmentID.Text = Max_ID("Department_Tbl", "DepartmentID") + 1
        DepartmentName.Focus()
    End Sub
    Public Sub ClearControls()
        Me.DepartmentID.Text = vbNullString
        Me.DepartmentName.Text = vbNullString
    End Sub

    Private Sub Frm_Dep_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadDep()
    End Sub

    Public Sub Update_Department_Tbl(ByVal DepartmentName As String, ByVal DepartmentIDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Department_Tbl Set DepartmentName = @DepartmentName Where DepartmentID = @DepartmentID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@DepartmentName", SqlDbType.varchar).Value = DepartmentName
            .Parameters.AddWithValue("@DepartmentID", SqlDbType.Int).Value = DepartmentIDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If DepartmentName.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Update_Department_Tbl(DepartmentName.Text, DepartmentID.Text)
        LoadDep()
        ClearControls()
    End Sub
    Public Sub Delete_Department_Tbl(ByVal dgv_Department_Tbl As DataGridView)
        Dim Position As Integer = dgv_Department_Tbl.CurrentRow.Index
        Dim ID_Position As Integer = dgv_Department_Tbl.Rows(Position).Cells(0).Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Department_Tbl Where DepartmentID = @DepartmentID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@DepartmentID", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Delete_Department_Tbl(DGVDep)
        End If
        LoadDep()
        ClearControls()
    End Sub

    Private Sub DGVDep_Click(sender As System.Object, e As System.EventArgs) Handles DGVDep.Click
        Try
            With DGVDep
                Me.DepartmentID.Text = .CurrentRow.Cells(0).Value.ToString()
                Me.DepartmentName.Text = .CurrentRow.Cells(1).Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class