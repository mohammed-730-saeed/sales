Imports System.Data.SqlClient

Public Class Stock_To_Stock
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

    Public Sub GetBalance2()

        Try

            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from Stock_Money_Tbl where Stock_ID=" & Cmb_Stock1.SelectedValue & "", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Me.Label8.Text = dr("Money").ToString
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Cmb_Stock1.SelectedIndexChanged
        GetBalance2()
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
    Public Sub fillcmb_Stock_Tbl2(ByVal cmb As ComboBox)
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

    Private Sub Cmb_Stock_DropDown(sender As System.Object, e As System.EventArgs) Handles Cmb_Stock.DropDown
        fillcmb_Stock_Tbl(Cmb_Stock)
    End Sub

    Private Sub Cmb_Stock1_DropDown(sender As System.Object, e As System.EventArgs) Handles Cmb_Stock1.DropDown
        fillcmb_Stock_Tbl2(Cmb_Stock1)
    End Sub

    Public Sub Insert_Stock_To_Stock_Tbl(ByVal Money As Double, ByVal TransferDate As Date, ByVal StockFrom As String, ByVal StockTo As String, ByVal EmpName As String, ByVal Reason As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Stock_To_Stock_Tbl ( Money,TransferDate,StockFrom,StockTo,EmpName,Reason)values(@Money,@TransferDate,@StockFrom,@StockTo,@EmpName,@Reason)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Money", SqlDbType.Decimal).Value = Money
            .Parameters.AddWithValue("@TransferDate", SqlDbType.Date).Value = TransferDate
            .Parameters.AddWithValue("@StockFrom", SqlDbType.VarChar).Value = StockFrom
            .Parameters.AddWithValue("@StockTo", SqlDbType.VarChar).Value = StockTo
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
     
        Insert_Stock_To_Stock_Tbl(Money.Text, TransferDate.Value, Cmb_Stock.Text, Cmb_Stock1.Text, EmpName.Text, Reason.Text)
        Update_Stock_Money_Tbl()
        Update_Stock_Money_Tbl2()
        GetBalance()
        GetBalance2()
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
            .CommandText = "Update Stock_Money_Tbl Set Money = Money + " & Money.Text & " Where Stock_ID = " & Cmb_Stock1.SelectedValue & ""
            .Parameters.Clear()

        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Private Sub Money_Leave(sender As System.Object, e As System.EventArgs) Handles Money.Leave
        If Val(Money.Text) > Val(Label7.Text) Then
            MsgBox("الرصيد المراد تحويله اكبر من الرصيد المجود بالخزنة ")
            Money.Text = ""
            Money.Focus()
        End If

    End Sub
End Class