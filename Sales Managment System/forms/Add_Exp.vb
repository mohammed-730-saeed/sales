Imports System.Data.SqlClient

Public Class Add_Exp

    Private Sub Add_Exp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ClearControls()
        Exp_ID.Text = Max_ID("Exp_Tbl", "Exp_ID") + 1
        EmpName.Text = Home.LblUser.Text
    End Sub
    Public Sub ClearControls()
        Me.Exp_ID.Text = vbNullString
        Me.Exp_Date.Value = Today
        Me.Exp_Value.Text = vbNullString
        Me.Exp_Des.Text = vbNullString
        'Me.EmpName.Text = vbNullString
    End Sub
    Public Sub Insert_Exp_Tbl(ByVal Exp_ID As Int32, ByVal Exp_Date As Date, ByVal Exp_Value As Double, ByVal Exp_Des As String, ByVal EmpName As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Exp_Tbl ( Exp_ID,Exp_Date,Exp_Value,Exp_Des,EmpName)values(@Exp_ID,@Exp_Date,@Exp_Value,@Exp_Des,@EmpName)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Exp_ID", SqlDbType.Int).Value = Exp_ID
            .Parameters.AddWithValue("@Exp_Date", SqlDbType.Date).Value = Exp_Date
            .Parameters.AddWithValue("@Exp_Value", SqlDbType.Decimal).Value = Exp_Value
            .Parameters.AddWithValue("@Exp_Des", SqlDbType.VarChar).Value = Exp_Des
            .Parameters.AddWithValue("@EmpName", SqlDbType.VarChar).Value = EmpName
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة النفقة بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Private Sub BtnNew_Click(sender As System.Object, e As System.EventArgs) Handles BtnNew.Click
        If Exp_Value.Text = vbNullString Or Exp_Des.Text = vbNullString Or EmpName.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If

        Insert_Exp_Tbl(Exp_ID.Text, Exp_Date.Value, Exp_Value.Text, Exp_Des.Text, EmpName.Text)
        ClearControls()
        Exp_ID.Text = Max_ID("Exp_Tbl", "Exp_ID") + 1
        EmpName.Text = Home.LblUser.Text
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class