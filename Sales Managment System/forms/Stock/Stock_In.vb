Imports System.Data.SqlClient

Public Class Stock_In
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

    Private Sub Stock_In_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fillcmb_Stock_Tbl(Cmb_Stock)
    End Sub

    Public Sub GetBalance()

        Try

            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from Stock_Money_Tbl where Stock_ID=" & Cmb_Stock.SelectedValue & "", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Me.Money_Available.Text = dr("Money").ToString
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

    Public Sub Insert_Stock_IN_Tbl(ByVal Stock_ID As Int32, ByVal Money As Double, ByVal Date_In As Date, ByVal EmpName As String, ByVal Reason As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Stock_IN_Tbl ( Stock_ID,Money,Date_In,EmpName,Reason)values(@Stock_ID,@Money,@Date_In,@EmpName,@Reason)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Stock_ID", SqlDbType.Int).Value = Stock_ID
            .Parameters.AddWithValue("@Money", SqlDbType.Decimal).Value = Money
            .Parameters.AddWithValue("@Date_In", SqlDbType.Date).Value = Date_In
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
    Public Sub ClearControls()

        Me.Money.Text = vbNullString
        Me.Date_In.Value = Today
        Me.EmpName.Text = vbNullString
        Me.Reason.Text = vbNullString
    End Sub


    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

        Insert_Stock_IN_Tbl(Cmb_Stock.SelectedValue, Money.Text, Date_In.Value, EmpName.Text, Reason.Text)
        Update_Stock_Money_Tbl()
        ClearControls()
        GetBalance()
    End Sub

    Public Sub Update_Stock_Money_Tbl()

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