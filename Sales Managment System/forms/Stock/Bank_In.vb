Imports System.Data.SqlClient

Public Class Bank_In
    Public Sub GetBalance()

        Try

            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select Money from bank_Tbl ", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Me.lblMoney.Text = dr("Money").ToString
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try

    End Sub

    Private Sub Bank_In_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GetBalance()
    End Sub

    Public Sub Insert_Bank_IN_tbl(ByVal Money As Double, ByVal Date_IN As Date, ByVal EmpName As String, ByVal Reason As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Bank_IN_tbl ( Money,Date_IN,EmpName,Reason)values(@Money,@Date_IN,@EmpName,@Reason)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Money", SqlDbType.Decimal).Value = Money
            .Parameters.AddWithValue("@Date_IN", SqlDbType.Date).Value = Date_IN
            .Parameters.AddWithValue("@EmpName", SqlDbType.VarChar).Value = EmpName
            .Parameters.AddWithValue("@Reason", SqlDbType.VarChar).Value = Reason
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Insert_Bank_IN_tbl(Money.Text, Date_IN.Value, EmpName.Text, Reason.Text)
        Update_Bank_Money_Tbl()
        ClearControls()
        GetBalance()
    End Sub
    Public Sub ClearControls()
        Me.Money.Text = vbNullString
        Me.Date_IN.Value = Today
        Me.EmpName.Text = vbNullString
        Me.Reason.Text = vbNullString
    End Sub

    Public Sub Update_Bank_Money_Tbl()

        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update bank_Tbl Set Money = Money + " & Money.Text & " "


        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
End Class