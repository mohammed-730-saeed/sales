Imports System.Data.SqlClient

Public Class Bank_Out
    Public Sub Insert_Bank_Out_Tbl(ByVal Money As Double, ByVal Date_Out As Date, ByVal EmpName As String, ByVal Reason As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Bank_Out_Tbl ( Money,Date_Out,EmpName,Reason)values(@Money,@Date_Out,@EmpName,@Reason)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Money", SqlDbType.Decimal).Value = Money
            .Parameters.AddWithValue("@Date_Out", SqlDbType.Date).Value = Date_Out
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

    Private Sub Bank_Out_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GetBalance()
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Insert_Bank_Out_Tbl(Money.Text, Date_Out.Value, EmpName.Text, Reason.Text)
        Update_Bank_Money_Tbl()
        ClearControls()
        GetBalance()
    End Sub
    Public Sub ClearControls()
        Me.Money.Text = vbNullString
        Me.Date_Out.Value = Today
        Me.EmpName.Text = vbNullString
        Me.Reason.Text = vbNullString
    End Sub
    Public Sub Update_Bank_Money_Tbl()

        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update bank_Tbl Set Money = Money - " & Money.Text & " "
            .Parameters.Clear()

        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
End Class