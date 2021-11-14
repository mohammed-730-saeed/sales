Imports System.Data.SqlClient
Imports MSwordDllFiles

Public Class Show_Buy_Inv

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Public Sub Print()

        Try
            '--------------------------------------------------------------
            ' مهم جداً أن تستدعي هذا الأمر قبل كتابة أي سطر برمجي يخص الطباعة
            MSO.SetDllFiles()
            '--------------------------------------------------------------
            Dim MyWord As MSO.MSWord
            MyWord = New MSO.MSWord(Me)

            Dim TemplatePath As String = My.Application.Info.DirectoryPath & "\Buy_Inv.dotx"

            Dim TemplateInfo As New MSO.TemplateInfo(TemplatePath)
            With TemplateInfo
                '-------------------------------------
                .Caption = " فاتورة مشتريات"
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
            .AddText(Buy_ID.Text, "Buy_ID")
            .AddText(Buy_Date.Value.Date, "Buy_Date")
            .AddText(Imp_Inv_No.Text, "Imp_Inv_No")
            .AddText(Inv_Type.Text, "Inv_Type")
            .AddText(Imp_ID.Text, "Imp_ID")
            .AddText(ImpName.Text, "ImpName")
            .AddText(ImpPhone.Text, "ImpPhone")
            .AddText(SalesMan.Text, "SalesMan")
            .AddText(Total.Text, "Total")
            .AddText(Item_Count.Text, "Item_Count")
            .AddText(TaxValue.Text, "TaxValue")
            .AddText(DiscountValue.Text, "DiscountValue")
            .AddText(TaxTotal.Text, "TaxTotal")
            .AddText(DiscountTotal.Text, "DiscountTotal")
            .AddText(FinalTotal.Text, "FinalTotal")
            .AddText(Paid.Text, "Paid")
            .AddText(UnPaid.Text, "UnPaid")
            With .AddTable()
                .DataTable = Get_All_Prd()
                '-------------------------------------
                '.MinimumRowsAtTheBeginningOfTable = 3
                .IsFirstColumnAutoNumber = False
                .TableHeadBookMarkName = "TableHead_1"
                .FirstRowBookMarkName = "TableFirstRow_1"
                .DeleteTableIfNoData = False
                '-------------------------------------
                .AddTextColumn("Prd_ID")
                .AddTextColumn("Prd_Code")
                .AddTextColumn("Prd_Name")
                .AddTextColumn("BuyPrice")
                .AddTextColumn("Qty")
                .AddTextColumn("TotalAmount")
            End With
        End With


        Return PrintJob
    End Function
    Public Function Get_All_Prd()
        Con.Open()
        Dim dt1 As New DataTable
        Dim cmd As New SqlCommand("Select * From View_BuyINV where Buy_ID=@Buy_ID", Con)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@Buy_ID", SqlDbType.Int).Value = Buy_ID.Text
        Dim adp As New SqlDataAdapter(cmd)
        adp.Fill(dt1)
        Con.Close()
        Return dt1
    End Function

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Print()
    End Sub

    Private Sub BtnClose_Click(sender As System.Object, e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class