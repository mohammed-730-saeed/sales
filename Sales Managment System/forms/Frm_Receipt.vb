Imports System.Data.SqlClient
Imports MSwordDllFiles

Public Class Frm_Receipt

    Private Sub Frm_Receipt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ClearControls()
        Receipt_ID.Text = Max_ID("Receipt_Tbl", "Receipt_ID") + 707
    End Sub
    Public Sub ClearControls()
        Me.Receipt_ID.Text = vbNullString
        Me.Receipt_date.Value = Today
        Me.PaidTotal.Text = vbNullString
    End Sub
    Public Sub InsertNewRowIn_Receipt_Tbl(ByVal Receipt_ID As Int32, ByVal Receipt_date As DateTime, ByVal Cus_ID As Int32, ByVal PaidTotal As Decimal, ByVal SalesMan As String)

        Dim CmdInsert As New SqlCommand
        With CmdInsert
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Receipt_Tbl (Receipt_ID , Receipt_date , Cus_ID , PaidTotal , SalesMan)values( @Receipt_ID ,  @Receipt_date ,  @Cus_ID ,  @PaidTotal ,  @SalesMan)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Receipt_ID", SqlDbType.Int).Value = Receipt_ID
            .Parameters.AddWithValue("@Receipt_date", SqlDbType.Date).Value = Receipt_date
            .Parameters.AddWithValue("@Cus_ID", SqlDbType.Int).Value = Cus_ID
            .Parameters.AddWithValue("@PaidTotal", SqlDbType.Decimal).Value = PaidTotal
            .Parameters.AddWithValue("@SalesMan", SqlDbType.VarChar).Value = SalesMan
        End With
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            CmdInsert.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم إضافة سند القبض بنجاح", MsgBoxStyle.Information, "حفظ")
            CmdInsert = Nothing
        Catch ex As Exception
            Con.Close()
            MsgBox(Err.Description, MsgBoxStyle.Information)
        Finally
            If Con.State = ConnectionState.Open Then Con.Close()
        End Try
    End Sub

    Private Sub BtnNew_Click(sender As System.Object, e As System.EventArgs) Handles BtnNew.Click
        Try
            InsertNewRowIn_Receipt_Tbl(Receipt_ID.Text, Receipt_date.Value, Cus_ID.Text, PaidTotal.Text, SalesMan.Text)
            Insert_Cus_Move_Tbl(Receipt_date.Value, Cus_ID.Text, "استلام دفعة", PaidTotal.Text, ToHim.Text, Onhim.Text, SalesMan.Text)
            Update_Customer_Tbl(ToHim.Text, Onhim.Text, Cus_ID.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        CustomerList.Show()
    End Sub

    Private Sub PaidTotal_Leave(sender As System.Object, e As System.EventArgs) Handles PaidTotal.Leave
        Onhim.Text = Val(Onhim.Text) - Val(PaidTotal.Text)

    End Sub
    Public Sub Insert_Cus_Move_Tbl(ByVal Move_Date As Date, ByVal Cus_ID As Int32, ByVal Move_Type As String, ByVal Move_Total As Double, ByVal Paid As Double, ByVal UnPaid As Double, ByVal SalesMan As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Cus_Move_Tbl ( Move_Date,Cus_ID,Move_Type,Move_Total,Paid,UnPaid,SalesMan)values(@Move_Date,@Cus_ID,@Move_Type,@Move_Total,@Paid,@UnPaid,@SalesMan)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Move_Date", SqlDbType.Date).Value = Move_Date
            .Parameters.AddWithValue("@Cus_ID", SqlDbType.Int).Value = Cus_ID
            .Parameters.AddWithValue("@Move_Type", SqlDbType.VarChar).Value = Move_Type
            .Parameters.AddWithValue("@Move_Total", SqlDbType.Decimal).Value = Move_Total
            .Parameters.AddWithValue("@Paid", SqlDbType.Decimal).Value = Paid
            .Parameters.AddWithValue("@UnPaid", SqlDbType.Decimal).Value = UnPaid
            .Parameters.AddWithValue("@SalesMan", SqlDbType.VarChar).Value = SalesMan
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub
    Public Sub Update_Customer_Tbl(ByVal ToHim As Double, ByVal Onhim As Double, ByVal Cus_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Customer_Tbl Set ToHim = @ToHim,Onhim = @Onhim Where Cus_ID = @Cus_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@ToHim", SqlDbType.Decimal).Value = ToHim
            .Parameters.AddWithValue("@Onhim", SqlDbType.Decimal).Value = Onhim
            .Parameters.AddWithValue("@Cus_ID", SqlDbType.Int).Value = Cus_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    Public Sub Print()

        Try
            '--------------------------------------------------------------
            ' مهم جداً أن تستدعي هذا الأمر قبل كتابة أي سطر برمجي يخص الطباعة
            MSO.SetDllFiles()
            '--------------------------------------------------------------
            Dim MyWord As MSO.MSWord
            MyWord = New MSO.MSWord(Me)

            Dim TemplatePath As String = My.Application.Info.DirectoryPath & "\Recipt1.dotx"

            Dim TemplateInfo As New MSO.TemplateInfo(TemplatePath)
            With TemplateInfo
                '-------------------------------------
                .Caption = " سند دفع "
                .PrintJob = GetPrintableJob()
                With .ViewOptions
                    '-------------------------------------
                    .ShowBookmarks = False
                    .ShowTableGridlines = False
                    .ArabicNumeral = MSO.Enums.MSArabicNumeral.NumeralContext
                    .DisplayPageBoundaries = True
                    .NormalViewDisplayRulers = True
                    .ViewType = MSO.Enums.MSViewType.PrintPreview
                    .WindowState = MSO.Enums.MSWindowState.Maximize
                    .NormalViewZoomPageFit = MSO.Enums.MSPageFit.PageFitBestFit
                    .NormalViewZoomPercentage = Nothing
                    '------------------------
                    .PrintPreviewDisplayRulers = True
                    .PrintPreviewPageFitness = New MSO.PrintPreviewPageFitness(0, 0)
                    .PrintPreviewZoomPageFit = MSO.Enums.MSPageFit.PageFitBestFit
                    .PrintPreviewZoomPercentage = Nothing
                    '-------------------------------------
                End With
            End With
            MyWord.AddNewTemplateInfo(TemplateInfo)
            '---------------------------------------
            'MyWord.PrintOut()
            MyWord.PrintPreview()

        Catch ex As Exception
            MSO.PrintingProcess.ShowErrorMsgAndClose(ex.Message)
        End Try

    End Sub
    Private Function GetPrintableJob() As MSO.Printing.PrintJob

        Dim PrintJob As New MSO.Printing.PrintJob

        With PrintJob
            '    '####################################################################################
            .AddText(Receipt_ID.Text, "Receipt_ID")
            .AddText(Receipt_date.Value.Date, "Receipt_date")
            .AddText(Cus_ID.Text, "Cus_ID")
            .AddText(CusName.Text, "CusName")
            .AddText(PaidTotal.Text, "PaidTotal")
            .AddText(SalesMan.Text, "SalesMan")
        End With
        Return PrintJob
    End Function

    Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
        Print()
    End Sub
End Class