Imports System.Data.SqlClient
Imports System.IO

Public Class Edit_Emp
    Public Sub Update_Employee_Tbl(ByVal EmployeeName As String, ByVal DepartmentID As Int32, ByVal JobID As Int32, ByVal BirthDate As Date, ByVal Salary As Double, ByVal Mobile As String, ByVal Address As String, ByVal Notes As String, ByVal StartWorkDate As Date, ByVal Emp_Pic As PictureBox, ByVal EmployeeIDW As Int32)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Update Employee_Tbl Set EmployeeName = @EmployeeName,DepartmentID = @DepartmentID,JobID = @JobID,BirthDate = @BirthDate,Salary = @Salary,Mobile = @Mobile,Address = @Address,Notes = @Notes,StartWorkDate = @StartWorkDate,Emp_Pic = @Emp_Pic Where EmployeeID = @EmployeeID"
                .Parameters.Clear()
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
                .Parameters.AddWithValue("@EmployeeID", SqlDbType.Int).Value = EmployeeIDW
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

    Private Sub BtnNew_Click(sender As System.Object, e As System.EventArgs) Handles BtnNew.Click
        If EmployeeName.Text = vbNullString Or DepartmentID.Text = vbNullString Or JobID.Text = vbNullString Or Mobile.Text = vbNullString Or Address.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Update_Employee_Tbl(EmployeeName.Text, DepartmentID.SelectedValue, JobID.SelectedValue, BirthDate.Value, Salary.Text, Mobile.Text, Address.Text, Notes.Text, StartWorkDate.Value, Emp_Pic, EmployeeID.Text)
        Me.Close()
        Frm_Emp.Show()
    End Sub

    Private Sub BtnBrowse_Click(sender As System.Object, e As System.EventArgs) Handles BtnBrowse.Click
        ChoosePicture(Emp_Pic)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class