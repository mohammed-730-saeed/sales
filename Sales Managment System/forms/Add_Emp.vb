Imports System.Data.SqlClient
Imports System.IO

Public Class Add_Emp

    Private Sub Add_Emp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ClearControls()
        EmployeeID.Text = Max_ID("Employee_Tbl", "EmployeeID") + 20201
    End Sub
    Public Sub ClearControls()
        Me.EmployeeName.Text = vbNullString
        Me.DepartmentID.Text = vbNullString
        Me.JobID.Text = vbNullString
        Me.BirthDate.Value = Today
        Me.Mobile.Text = vbNullString
        Me.Address.Text = vbNullString
        Me.Salary.Text = vbNullString
        Me.Notes.Text = vbNullString
        Me.StartWorkDate.Value = Today
        Me.Emp_Pic.Image = My.Resources.flat_seo_30_512
    End Sub
    Public Sub fillcmb_Department_Tbl(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Department_Tbl ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.DisplayMember = "DepartmentName"
            cmb.ValueMember = "DepartmentID"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub

    Private Sub DepartmentID_DropDown(sender As System.Object, e As System.EventArgs) Handles DepartmentID.DropDown
        fillcmb_Department_Tbl(DepartmentID)
    End Sub

    Public Sub fillcmb_Job_Tbl(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Job_Tbl ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.DisplayMember = "JobName"
            cmb.ValueMember = "JobID"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub

    Private Sub JobID_DropDown(sender As System.Object, e As System.EventArgs) Handles JobID.DropDown
        fillcmb_Job_Tbl(JobID)
    End Sub

    Private Sub BtnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles BtnBrowse.Click
        ChoosePicture(Emp_Pic)
    End Sub

    Public Sub Insert_Employee_Tbl(ByVal EmployeeID As Int32, ByVal EmployeeName As String, ByVal DepartmentID As Int32, ByVal JobID As Int32, ByVal BirthDate As Date, ByVal Salary As Double, ByVal Mobile As String, ByVal Address As String, ByVal Notes As String, ByVal StartWorkDate As Date, ByVal Emp_Pic As PictureBox)
        Try

            Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Employee_Tbl ( EmployeeID,EmployeeName,DepartmentID,JobID,BirthDate,Salary,Mobile,Address,Notes,StartWorkDate,Emp_Pic)values(@EmployeeID,@EmployeeName,@DepartmentID,@JobID,@BirthDate,@Salary,@Mobile,@Address,@Notes,@StartWorkDate,@Emp_Pic)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@EmployeeID", SqlDbType.Int).Value = EmployeeID
            .Parameters.AddWithValue("@EmployeeName", SqlDbType.VarChar).Value = EmployeeName
            .Parameters.AddWithValue("@DepartmentID", SqlDbType.Int).Value = DepartmentID
            .Parameters.AddWithValue("@JobID", SqlDbType.Int).Value = JobID
            .Parameters.AddWithValue("@BirthDate", SqlDbType.Date).Value = BirthDate
            .Parameters.AddWithValue("@Salary", SqlDbType.Decimal).Value = Salary
            .Parameters.AddWithValue("@Mobile", SqlDbType.VarChar).Value = Mobile
            .Parameters.AddWithValue("@Address", SqlDbType.VarChar).Value = Address
            .Parameters.AddWithValue("@Notes", SqlDbType.VarChar).Value = Notes
            .Parameters.AddWithValue("@StartWorkDate", SqlDbType.Date).Value = StartWorkDate
            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(Emp_Pic.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@Emp_Pic", SqlDbType.Image)
            p.Value = data
            .Parameters.Add(p)
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

    Private Sub BtnNew_Click(sender As System.Object, e As System.EventArgs) Handles BtnNew.Click
        If EmployeeName.Text = vbNullString Or JobID.Text = vbNullString Or Mobile.Text = vbNullString Or Address.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If

        Insert_Employee_Tbl(EmployeeID.Text, EmployeeName.Text, DepartmentID.SelectedValue, JobID.SelectedValue, BirthDate.Value, Salary.Text, Mobile.Text, Address.Text, Notes.Text, StartWorkDate.Value, Emp_Pic)
        ClearControls()
        EmployeeID.Text = Max_ID("Employee_Tbl", "EmployeeID") + 20201
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub EmployeeName_KeyDown(sender As Object, e As KeyEventArgs) Handles EmployeeName.KeyDown
        If e.KeyCode = Keys.Enter Then
            BirthDate.Select()
        End If
    End Sub

    Private Sub BirthDate_KeyDown(sender As Object, e As KeyEventArgs) Handles BirthDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            JobID.Select()
        End If
    End Sub

    Private Sub JobID_KeyDown(sender As Object, e As KeyEventArgs) Handles JobID.KeyDown
        If e.KeyCode = Keys.Enter Then
            Salary.Select()
        End If
    End Sub

    Private Sub Salary_KeyDown(sender As Object, e As KeyEventArgs) Handles Salary.KeyDown
        If e.KeyCode = Keys.Enter Then
            Mobile.Select()
        End If
    End Sub

    Private Sub Mobile_KeyDown(sender As Object, e As KeyEventArgs) Handles Mobile.KeyDown
        If e.KeyCode = Keys.Enter Then
            Address.Select()
        End If
    End Sub

    Private Sub Address_KeyDown(sender As Object, e As KeyEventArgs) Handles Address.KeyDown
        If e.KeyCode = Keys.Enter Then
            StartWorkDate.Select()
        End If
    End Sub

    Private Sub StartWorkDate_KeyDown(sender As Object, e As KeyEventArgs) Handles StartWorkDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            Notes.Select()
        End If
    End Sub


End Class