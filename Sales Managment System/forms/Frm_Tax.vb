Imports System.Data.SqlClient

Public Class Frm_Tax

    Private Sub Frm_Tax_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Get_Tax()
    End Sub

    Public Sub Get_Tax()
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" select  *  from Tax_Tbl  where  Tax_ID=1", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            While dr.Read
                Tax_ID.Text = dr("Tax_ID").ToString
                TaxValue.Text = dr("TaxValue").ToString
            End While




            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try
    End Sub

   
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Public Sub Update_Tax_Tbl(ByVal TaxValue As Int32, ByVal Tax_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tax_Tbl Set TaxValue = @TaxValue Where Tax_ID = @Tax_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@TaxValue", SqlDbType.Int).Value = TaxValue
            .Parameters.AddWithValue("@Tax_ID", SqlDbType.Int).Value = Tax_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل نسبة الضريبة بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Update_Tax_Tbl(TaxValue.Text, Tax_ID.Text)
        Me.Close()
    End Sub
End Class