Imports System.Data.SqlClient

Public Class Stock_To_Bank
    Public Sub GetBalance()
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from Stock_Money_Tbl where Stock_ID=" & Cmb_Stock.SelectedValue & "", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Me.Label7.Text = dr("Money").ToString
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try

    End Sub

    Private Sub Cmb_Stock_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Cmb_Stock.SelectedIndexChanged
        GetBalance()
    End Sub

    Private Sub Cmb_Stock_DropDown(sender As System.Object, e As System.EventArgs) Handles Cmb_Stock.DropDown
        fillcmb_Stock_Tbl(Cmb_Stock)
    End Sub
    Public Sub fillcmb_Stock_Tbl(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Stock_Tbl ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.DisplayMember = "Stock_Name"
            cmb.ValueMember = "Stock_ID"
            cmb.SelectedIndex = -1
        Else
            cmb.DataSource = Nothing
        End If
    End Sub
    Public Sub GetBalanceBank()

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

    Private Sub Stock_To_Bank_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GetBalanceBank()
    End Sub


    Private Sub CkStock_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CkStock.CheckedChanged
        If CkStock.Checked = True Then
            CkBank.Checked = False
        End If
    End Sub

    Private Sub CkBank_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CkBank.CheckedChanged
        If CkBank.Checked = True Then
            CkStock.Checked = False
        End If
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        If CkBank.Checked = False And CkStock.Checked = False Then

            MsgBox("يجب ان تختار نوع عملية التحويل")

        ElseIf CkStock.Checked = True Then
            Insert_Stock_To_Bank(Money.Text, TransferDate.Value, Cmb_Stock.Text, "البنك", EmpName.Text, Reason.Text)
            Update_Bank_Money_Tbl()
            Update_Stock_Money_Tbl()

        ElseIf CkBank.Checked = True Then
            Insert_Stock_To_Bank(Money.Text, TransferDate.Value, "البنك", Cmb_Stock.Text, EmpName.Text, Reason.Text)
            Update_Bank_Money_Tbl2()
            Update_Stock_Money_Tbl2()
        End If
        GetBalanceBank()
        GetBalance()
    End Sub

    Public Sub Insert_Stock_To_Bank(ByVal Money As Double, ByVal TransferDate As Date, ByVal StockName As String, ByVal BankName As String, ByVal EmpName As String, ByVal Reason As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Stock_To_Bank ( Money,TransferDate,StockName,BankName,EmpName,Reason)values(@Money,@TransferDate,@StockName,@BankName,@EmpName,@Reason)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Money", SqlDbType.Decimal).Value = Money
            .Parameters.AddWithValue("@TransferDate", SqlDbType.Date).Value = TransferDate
            .Parameters.AddWithValue("@StockName", SqlDbType.varchar).Value = StockName
            .Parameters.AddWithValue("@BankName", SqlDbType.varchar).Value = BankName
            .Parameters.AddWithValue("@EmpName", SqlDbType.varchar).Value = EmpName
            .Parameters.AddWithValue("@Reason", SqlDbType.varchar).Value = Reason
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
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
    Public Sub Update_Bank_Money_Tbl2()

        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update bank_Tbl Set Money = Money - " & Money.Text & " "


        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Update_Stock_Money_Tbl()

        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Stock_Money_Tbl Set Money = Money - " & Money.Text & " Where Stock_ID = " & Cmb_Stock.SelectedValue & ""
            .Parameters.Clear()

        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    Public Sub Update_Stock_Money_Tbl2()

        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Stock_Money_Tbl Set Money = Money + " & Money.Text & " Where Stock_ID = " & Cmb_Stock.SelectedValue & ""
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