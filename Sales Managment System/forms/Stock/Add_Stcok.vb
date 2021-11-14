Imports System.Data.SqlClient

Public Class Add_Stcok
    Public Sub LoadStock()
        Try
            DGVStock.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from Stock_Tbl", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                DGVStock.Rows.Add(dr("Stock_ID").ToString, dr("Stock_Name").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try

    End Sub
    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        ClearControls()
        Stock_ID.Text = Max_ID("Stock_Tbl", "Stock_ID") + 1
        Stock_Name.Focus()
    End Sub
    Public Sub ClearControls()
        Me.Stock_ID.Text = vbNullString
        Me.Stock_Name.Text = vbNullString
        Me.Money.Text = vbNullString
    End Sub

    Private Sub Add_Stcok_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadStock()
    End Sub
    Public Sub Insert_Stock_Tbl(ByVal Stock_ID As Int32, ByVal Stock_Name As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Stock_Tbl ( Stock_ID,Stock_Name)values(@Stock_ID,@Stock_Name)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Stock_ID", SqlDbType.Int).Value = Stock_ID
            .Parameters.AddWithValue("@Stock_Name", SqlDbType.varchar).Value = Stock_Name
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        If Stock_Name.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Insert_Stock_Tbl(Stock_ID.Text, Stock_Name.Text)
        Insert_Stock_Money_Tbl(Stock_ID.Text, Money.Text)

        LoadStock()
        ClearControls()
    End Sub
    Public Sub Update_Stock_Tbl(ByVal Stock_Name As String, ByVal Stock_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Stock_Tbl Set Stock_Name = @Stock_Name Where Stock_ID = @Stock_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Stock_Name", SqlDbType.varchar).Value = Stock_Name
            .Parameters.AddWithValue("@Stock_ID", SqlDbType.Int).Value = Stock_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If Stock_Name.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Update_Stock_Tbl(Stock_Name.Text, Stock_ID.Text)
        LoadStock()
        ClearControls()
    End Sub

    Public Sub Delete_Stock_Tbl(ByVal dgv_Stock_Tbl As DataGridView)
        Dim Position As Integer = dgv_Stock_Tbl.CurrentRow.Index
        Dim ID_Position As Integer = dgv_Stock_Tbl.Rows(Position).Cells(0).Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Stock_Tbl Where Stock_ID = @Stock_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Stock_ID", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Delete_Stock_Tbl(DGVStock)
        End If
        LoadStock()
        ClearControls()
    End Sub
    Public Sub Insert_Stock_Money_Tbl(ByVal Stock_ID As Int32, ByVal Money As Double)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Stock_Money_Tbl ( Stock_ID,Money)values(@Stock_ID,@Money)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Stock_ID", SqlDbType.Int).Value = Stock_ID
            .Parameters.AddWithValue("@Money", SqlDbType.Decimal).Value = Money
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub


    Private Sub DGVStock_Click(sender As System.Object, e As System.EventArgs) Handles DGVStock.Click
        Try
            With DGVStock
                Me.Stock_ID.Text = .CurrentRow.Cells(0).Value.ToString()
                Me.Stock_Name.Text = .CurrentRow.Cells(1).Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class