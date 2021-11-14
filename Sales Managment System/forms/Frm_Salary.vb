Imports System.Data.SqlClient

Public Class Frm_Salary
    Public Sub Insert_Salary_Tbl(ByVal EmployeeID As Int32, ByVal PaidDate As Date, ByVal SalaryValue As Double, ByVal EmployeeName As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Salary_Tbl ( EmployeeID,PaidDate,SalaryValue,EmployeeName)values(@EmployeeID,@PaidDate,@SalaryValue,@EmployeeName)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@EmployeeID", SqlDbType.Int).Value = EmployeeID
            .Parameters.AddWithValue("@PaidDate", SqlDbType.Date).Value = PaidDate
            .Parameters.AddWithValue("@SalaryValue", SqlDbType.Decimal).Value = SalaryValue
            .Parameters.AddWithValue("@EmployeeName", SqlDbType.VarChar).Value = EmployeeName
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Private Sub BtnNew_Click(sender As System.Object, e As System.EventArgs) Handles BtnNew.Click
        Insert_Salary_Tbl(EmployeeID.Text, PaidDate.Value, Salary.Text, EmpName.Text)

    End Sub
End Class