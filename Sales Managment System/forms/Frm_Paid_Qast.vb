Imports System.Data.SqlClient

Public Class Frm_Paid_Qast

    Public Sub Insert_Qast_Paid(ByVal Sanad_ID As Int32, ByVal Aqsat_Sale_ID As Int32, ByVal Qast_ID As Int32, ByVal Money_Paid As Double, ByVal PaidDate As Date, ByVal Emp_Name As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Qast_Paid ( Sanad_ID,Aqsat_Sale_ID,Qast_ID,Money_Paid,PaidDate,Emp_Name)values(@Sanad_ID,@Aqsat_Sale_ID,@Qast_ID,@Money_Paid,@PaidDate,@Emp_Name)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Sanad_ID", SqlDbType.Int).Value = Sanad_ID
            .Parameters.AddWithValue("@Aqsat_Sale_ID", SqlDbType.Int).Value = Aqsat_Sale_ID
            .Parameters.AddWithValue("@Qast_ID", SqlDbType.Int).Value = Qast_ID
            .Parameters.AddWithValue("@Money_Paid", SqlDbType.Decimal).Value = Money_Paid
            .Parameters.AddWithValue("@PaidDate", SqlDbType.Date).Value = PaidDate
            .Parameters.AddWithValue("@Emp_Name", SqlDbType.VarChar).Value = Emp_Name
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Insert_Qast_Paid(Sanad_ID.Text, Aqsat_Sale_ID.Text, Qast_ID.Text, Money_Paid.Text, PaidDate.Value, Emp_Name.Text)
        Update_Aqsat_Tbl()
        Update_Qast_Details_Tbl()
        ClearControls()
        Show_Aqsat_Details.Close()
        Me.Close()
    End Sub
    Public Sub ClearControls()
        Me.Sanad_ID.Text = vbNullString
        Me.Aqsat_Sale_ID.Text = vbNullString
        Me.Qast_ID.Text = vbNullString
        Me.Money_Paid.Text = vbNullString
        Me.PaidDate.Value = Today
        Me.Emp_Name.Text = vbNullString
    End Sub

    Public Sub Update_Aqsat_Tbl()
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Aqsat_Tbl Set Aqsat_Paid = Aqsat_Paid +1,Aqsat_Unpaid = Aqsat_Unpaid -1,Money_Paid = Money_Paid + " & Money_Paid.Text & ",Money_Unpaid = Money_Unpaid - " & Money_Paid.Text & " Where Aqsat_Sale_ID = " & Aqsat_Sale_ID.Text & ""
      
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    Public Sub Update_Qast_Details_Tbl()
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Qast_Details_Tbl Set Qast_Status = @Qast_Status Where Aqsat_Sale_ID = " & Aqsat_Sale_ID.Text & " and Qast_ID=" & Qast_ID.Text & ""
            .Parameters.Clear()
            .Parameters.AddWithValue("@Qast_Status", SqlDbType.VarChar).Value = "مدفوع"

        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

End Class