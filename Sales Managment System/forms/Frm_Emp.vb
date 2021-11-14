Imports System.Data.SqlClient
Imports System.IO

Public Class Frm_Emp

    Public Sub Load_Emp()
        Try
            DGVEmp.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from Employee_Tbl", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                DGVEmp.Rows.Add(dr("EmployeeID").ToString, dr("EmployeeName").ToString, dr("Mobile").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            MessageBox.Show("هناك خطاء الرجاء التاكد !" + ex.Message)
            Con.Close()
        End Try

    End Sub

    Private Sub Frm_Emp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Load_Emp()
    End Sub

    Private Sub DGVEmp_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVEmp.CellClick
        If e.ColumnIndex = 3 Then
            Get_Info_To_Edit()
        ElseIf e.ColumnIndex = 5 Then
            Get_Pic()
        ElseIf e.ColumnIndex = 4 Then
            If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                Exit Sub
            Else
                Delete_Employee_Tbl(DGVEmp)
            End If
            Load_Emp()

        ElseIf e.ColumnIndex = 6 Then
            Edit_Emp.Text = "بيانات الموظف"
            Edit_Emp.BtnNew.Visible = False
            Edit_Emp.BtnBrowse.Visible = False
            Edit_Emp.Button1.Visible = False
            Get_Info_To_Edit()

        ElseIf e.ColumnIndex = 7 Then
            PaidSalary()
        End If
    End Sub

    Public Sub Get_Pic()
        Con.Open()
        Dim cmd As New SqlCommand("Select Emp_Pic From Employee_Tbl Where EmployeeID=@EmployeeID", Con)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@EmployeeID", SqlDbType.Int).Value = DGVEmp.CurrentRow.Cells(0).Value.ToString
        Dim adp As New SqlDataAdapter(cmd)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read()

                Dim data As Byte() = DirectCast(dr("Emp_Pic"), Byte())
                Dim ms As New MemoryStream(data)
                Show_Pic.Prd_Pic.Image = Image.FromStream(ms)

            End While
            dr.Close()
            Con.Close()
            Show_Pic.Label1.Text = "صورة الموظف"
            Show_Pic.ShowDialog()
        End If


    End Sub

    Public Sub Get_Info_To_Edit()
        Add_Emp.fillcmb_Department_Tbl(Edit_Emp.DepartmentID)
        Add_Emp.fillcmb_Job_Tbl(Edit_Emp.JobID)
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" select  *  from Employee_Tbl  where  EmployeeID=@EmployeeID", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@EmployeeID", SqlDbType.Int).Value = DGVEmp.CurrentRow.Cells(0).Value.ToString
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Edit_Emp.EmployeeID.Text = dr("EmployeeID").ToString
                Edit_Emp.EmployeeName.Text = dr("EmployeeName").ToString
                Edit_Emp.DepartmentID.SelectedValue = dr("DepartmentID").ToString
                Edit_Emp.JobID.SelectedValue = dr("JobID").ToString
                Edit_Emp.BirthDate.Value = dr("BirthDate").ToString
                Edit_Emp.Salary.Text = dr("Salary").ToString
                Edit_Emp.Mobile.Text = dr("Mobile").ToString
                Edit_Emp.Address.Text = dr("Address").ToString
                Edit_Emp.Notes.Text = dr("Notes").ToString
                Edit_Emp.StartWorkDate.Value = dr("StartWorkDate").ToString

                Dim data As Byte() = DirectCast(dr("Emp_Pic"), Byte())
                Dim ms As New MemoryStream(data)
                Edit_Emp.Emp_Pic.Image = Image.FromStream(ms)

            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            MessageBox.Show("هناك خطاء الرجاء التاكد !" + ex.Message)
            Con.Close()

        End Try
        Edit_Emp.ShowDialog()
        Me.Close()
    End Sub
    Public Sub Delete_Employee_Tbl(ByVal dgv_Employee_Tbl As DataGridView)
        Dim Position As Integer = dgv_Employee_Tbl.CurrentRow.Index
        Dim ID_Position As Integer = dgv_Employee_Tbl.Rows(Position).Cells(0).Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Employee_Tbl Where EmployeeID = @EmployeeID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@EmployeeID", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

    End Sub

    Public Sub PaidSalary()
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" select  *  from Employee_Tbl  where  EmployeeID=@EmployeeID", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@EmployeeID", SqlDbType.Int).Value = DGVEmp.CurrentRow.Cells(0).Value.ToString
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Frm_Salary.EmployeeID.Text = dr("EmployeeID").ToString
                Frm_Salary.EmployeeName.Text = dr("EmployeeName").ToString
                Frm_Salary.Salary.Text = dr("Salary").ToString
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            MessageBox.Show("هناك خطاء الرجاء التاكد !" + ex.Message)
            Con.Close()

        End Try
        Frm_Salary.ShowDialog()
        Me.Close()
    End Sub
End Class