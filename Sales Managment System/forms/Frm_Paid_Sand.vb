Imports System.Data.SqlClient
Imports MSwordDllFiles

Public Class Frm_Paid_Sand

    Private Sub Frm_Paid_Sand_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Paid_Sand_ID.Text = Max_ID("Paid_Sand_Tbl", "Paid_Sand_ID") + 6060
    End Sub

    Public Sub Insert_Paid_Sand_Tbl(ByVal Paid_Sand_ID As Int32, ByVal Paid_date As Date, ByVal Imp_ID As Int32, ByVal PaidTotal As Double, ByVal SalesMan As String)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Insert Into Paid_Sand_Tbl ( Paid_Sand_ID,Paid_date,Imp_ID,PaidTotal,SalesMan)values(@Paid_Sand_ID,@Paid_date,@Imp_ID,@PaidTotal,@SalesMan)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Paid_Sand_ID", SqlDbType.Int).Value = Paid_Sand_ID
                .Parameters.AddWithValue("@Paid_date", SqlDbType.Date).Value = Paid_date
                .Parameters.AddWithValue("@Imp_ID", SqlDbType.Int).Value = Imp_ID
                .Parameters.AddWithValue("@PaidTotal", SqlDbType.Decimal).Value = PaidTotal
                .Parameters.AddWithValue("@SalesMan", SqlDbType.VarChar).Value = SalesMan
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم إضافة سند الدفع بنجاح", MsgBoxStyle.Information, "حفظ")
            Cmd = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnNew_Click(sender As System.Object, e As System.EventArgs) Handles BtnNew.Click
        If PaidTotal.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Insert_Paid_Sand_Tbl(Paid_Sand_ID.Text, Paid_date.Value, Imp_ID.Text, PaidTotal.Text, SalesMan.Text)
        Insert_Imp_Move(Paid_date.Value, Imp_ID.Text, " دفعة نقدية", PaidTotal.Text, ToHim.Text, Onhim.Text, SalesMan.Text)
        Update_Importers_Tbl(ToHim.Text, Onhim.Text, Imp_ID.Text)

    End Sub

    Public Sub Insert_Imp_Move(ByVal Move_Date As Date, ByVal Imp_ID As Int32, ByVal Move_Type As String, ByVal Move_Total As Double, ByVal Paid As Double, ByVal UnPaid As Double, ByVal SalesMan As String)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Insert Into Imp_Move ( Move_Date,Imp_ID,Move_Type,Move_Total,Paid,UnPaid,SalesMan)values(@Move_Date,@Imp_ID,@Move_Type,@Move_Total,@Paid,@UnPaid,@SalesMan)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Move_Date", SqlDbType.Date).Value = Move_Date
                .Parameters.AddWithValue("@Imp_ID", SqlDbType.Int).Value = Imp_ID
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub PaidTotal_Leave(sender As System.Object, e As System.EventArgs) Handles PaidTotal.Leave
        ToHim.Text = Val(ToHim.Text) - Val(PaidTotal.Text)
    End Sub

    Public Sub Update_Importers_Tbl(ByVal ToHim As Double, ByVal Onhim As Double, ByVal Imp_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Importers_Tbl Set ToHim = @ToHim,Onhim = @Onhim Where Imp_ID = @Imp_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@ToHim", SqlDbType.Decimal).Value = ToHim
            .Parameters.AddWithValue("@Onhim", SqlDbType.Decimal).Value = Onhim
            .Parameters.AddWithValue("@Imp_ID", SqlDbType.Int).Value = Imp_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ImportersList.Show()
    End Sub

    Public Sub Print()

        Try
            '--------------------------------------------------------------
            ' مهم جداً أن تستدعي هذا الأمر قبل كتابة أي سطر برمجي يخص الطباعة
            MSO.SetDllFiles()
            '--------------------------------------------------------------
            Dim MyWord As MSO.MSWord
            MyWord = New MSO.MSWord(Me)

            Dim TemplatePath As String = My.Application.Info.DirectoryPath & "\PaisSanad.dotx"

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
            .AddText(Paid_Sand_ID.Text, "Paid_Sand_ID")
            .AddText(Paid_date.Value.Date, "Paid_date")
            .AddText(Imp_ID.Text, "Imp_ID")
            .AddText(ImpName.Text, "ImpName")
            .AddText(PaidTotal.Text, "PaidTotal")
            .AddText(SalesMan.Text, "SalesMan")
        End With
        Return PrintJob
    End Function

    Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
        Print()
    End Sub
End Class