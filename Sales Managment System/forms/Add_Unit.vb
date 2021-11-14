Imports System.Data.SqlClient

Public Class Add_Unit
    Public Sub ClearControls()
        Me.Unit_ID.Text = vbNullString
        Me.UnitName.Text = vbNullString
    End Sub

    Private Sub Add_Unit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ClearControls()
        Unit_ID.Text = Max_ID("Unit_Tbl", "Unit_ID") + 909
        UnitName.Focus()
    End Sub
    Public Sub Insert_Unit_Tbl(ByVal Unit_ID As Int32, ByVal UnitName As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Unit_Tbl ( Unit_ID,UnitName)values(@Unit_ID,@UnitName)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Unit_ID", SqlDbType.Int).Value = Unit_ID
            .Parameters.AddWithValue("@UnitName", SqlDbType.VarChar).Value = UnitName
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة الوحدة بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Private Sub Btnsave_Click(sender As System.Object, e As System.EventArgs) Handles Btnsave.Click
        If UnitName.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If

        Insert_Unit_Tbl(Unit_ID.Text, UnitName.Text)
        If MessageBox.Show("هل تريد اضافة وحدة جديدة اخر ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Me.Close()
            Dim frm As New Frm_Unit
            frm.TopLevel = False
            Home.HomePanel.Controls.Add(frm)
            frm.BringToFront()
            frm.Show()
        Else
            ClearControls()
            Unit_ID.Text = Max_ID("Unit_Tbl", "Unit_ID") + 909
            UnitName.Focus()
        End If
    End Sub

    Private Sub BtnClose_Click(sender As System.Object, e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class