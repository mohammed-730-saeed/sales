Imports System.Data.SqlClient
Imports System.IO
Imports MSwordDllFiles

Public Class Frm_Products
    Private Sub Frm_Products_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadPrd()
    End Sub
    Public Sub LoadPrd()
        Try
            DGV_prd.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from View_AllPrd", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                DGV_prd.Rows.Add(dr("Prd_ID").ToString, dr("Prd_Code").ToString, dr("Prd_Name").ToString, dr("CatName").ToString, dr("UnitName").ToString, dr("PrdLimit").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try
    End Sub
    Private Sub BtnNew_Click(sender As System.Object, e As System.EventArgs) Handles BtnNew.Click
        Add_Product.ShowDialog()
    End Sub

    Private Sub BtnEdit_Click(sender As System.Object, e As System.EventArgs) Handles BtnEdit.Click
        Get_Info_To_Edit()
        Me.Close()
    End Sub
    Public Sub Get_Info_To_Edit()
        fillcmb_Cat_Tbl(Edit_Product.Cmb_Cat)
        fillcmb_Unit_Tbl(Edit_Product.Cmb_Unit)
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" select  *  from View_AllPrd  where  Prd_ID=@Prd_ID", Con)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@Prd_ID", SqlDbType.Int).Value = DGV_prd.CurrentRow.Cells(0).Value.ToString
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Edit_Product.Prd_ID.Text = dr("Prd_ID").ToString
                Edit_Product.Prd_Code.Text = dr("Prd_Code").ToString
                Edit_Product.Prd_Name.Text = dr("Prd_Name").ToString
                Edit_Product.Cmb_Cat.Text = dr("CatName").ToString
                Edit_Product.Cmb_Unit.Text = dr("UnitName").ToString
                Edit_Product.PrdLimit.Text = dr("PrdLimit").ToString
                Dim data As Byte() = DirectCast(dr("Prd_Pic"), Byte())
                Dim ms As New MemoryStream(data)
                Edit_Product.Prd_Pic.Image = Image.FromStream(ms)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
        End Try
        Edit_Product.Show()
    End Sub
    Private Sub BtnDelete_Click(sender As System.Object, e As System.EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Delete_Product_Tbl(DGV_prd)
        End If
    End Sub
    Public Sub Delete_Product_Tbl(ByVal Dgv_prd As DataGridView)
        Dim Position As Integer = Dgv_prd.CurrentRow.Index
        Dim ID_Position As Integer = Dgv_prd.Rows(Position).Cells(0).Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Product_Tbl Where Prd_ID = @Prd_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Prd_ID", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف بيانات المنتج بنجاح .", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub
    Public Sub Get_Pic()
        Con.Open()
        Dim cmd As New SqlCommand("Select Prd_Pic From Product_Tbl Where Prd_Id=@Prd_Id", Con)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("@Prd_Id", SqlDbType.Int).Value = DGV_prd.CurrentRow.Cells(0).Value.ToString
        Dim adp As New SqlDataAdapter(cmd)
        Dim dr As SqlDataReader = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read()
                Dim data As Byte() = DirectCast(dr("Prd_Pic"), Byte())
                Dim ms As New MemoryStream(data)
                Show_Pic.Prd_Pic.Image = Image.FromStream(ms)
            End While
            dr.Close()
            Con.Close()
            Show_Pic.Show()
        End If
    End Sub
    Private Sub DGV_prd_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_prd.CellClick
        If e.ColumnIndex = 6 Then
            Get_Pic()
        End If
    End Sub
    '*************  المنتجات طباعة  ***********
    Public Sub Print()
        Try
            '--------------------------------------------------------------
            ' مهم جداً أن تستدعي هذا الأمر قبل كتابة أي سطر برمجي يخص الطباعة
            MSO.SetDllFiles()
            '--------------------------------------------------------------
            Dim MyWord As MSO.MSWord
            MyWord = New MSO.MSWord(Me)
            Dim TemplatePath As String = My.Application.Info.DirectoryPath & "\product.dotx"
            Dim TemplateInfo As New MSO.TemplateInfo(TemplatePath)
            With TemplateInfo
                '-------------------------------------
                .Caption = " قائمة  المنتجات"
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
    '************* دالة خاصة بالطباعة ***********
    Private Function GetPrintableJob() As MSO.Printing.PrintJob

        Dim PrintJob As New MSO.Printing.PrintJob
        With PrintJob

            'إضافة الجدول الثاني

            '---------------------  Table 2 That Exist In Word Document ------------------
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
                .AddTextColumn("CatName")
                .AddTextColumn("UnitName")
            End With
            '####################################################################################
        End With
        Return PrintJob
    End Function
    Public Function Get_All_Prd()
        Con.Open()
        Dim dt1 As New DataTable
        Dim cmd As New SqlCommand("Select * From View_AllPrd ", Con)
        Dim adp As New SqlDataAdapter(cmd)
        adp.Fill(dt1)
        Con.Close()
        Return dt1
    End Function

    Private Sub BtnPrint_Click(sender As System.Object, e As System.EventArgs) Handles BtnPrint.Click
        Print()
    End Sub
    Public Sub GetProduct()

        For i As Integer = 0 To Re_Buy_Inv.dgv_buy1.Rows.Count - 1
            If Re_Buy_Inv.dgv_buy1.Rows(i).Cells(0).Value = DGV_prd.CurrentRow.Cells(0).Value Then
                MsgBox(" المنتج المراد ادخاله تم اضافته للفاتورة مسبقا")
                Exit Sub
            End If
        Next
        Dim x As Integer
        Re_Buy_Inv.dgv_buy1.Rows.Add()
        x = Re_Buy_Inv.dgv_buy1.Rows.Count - 1
        Re_Buy_Inv.dgv_buy1(0, x).Value = DGV_prd.CurrentRow.Cells(0).Value
        Re_Buy_Inv.dgv_buy1(1, x).Value = DGV_prd.CurrentRow.Cells(1).Value
        Re_Buy_Inv.dgv_buy1(2, x).Value = DGV_prd.CurrentRow.Cells(2).Value
        Re_Buy_Inv.dgv_buy1(3, x).Value = DGV_prd.CurrentRow.Cells(4).Value

        Me.Close()


    End Sub
    Private Sub DGV_prd_DoubleClick(sender As System.Object, e As System.EventArgs) Handles DGV_prd.DoubleClick
        GetProduct()
        For i As Integer = 0 To Buy_Inv.dgv_buy.Rows.Count - 1
            If Buy_Inv.dgv_buy.Rows(i).Cells(0).Value = DGV_prd.CurrentRow.Cells(0).Value Then
                MsgBox(" المنتج المراد ادخاله تم اضافته للفاتورة مسبقا")
                Exit Sub
            End If
        Next
        Dim x As Integer
        Buy_Inv.dgv_buy.Rows.Add()
        x = Buy_Inv.dgv_buy.Rows.Count - 1
        Buy_Inv.dgv_buy(0, x).Value = DGV_prd.CurrentRow.Cells(0).Value
        Buy_Inv.dgv_buy(1, x).Value = DGV_prd.CurrentRow.Cells(1).Value
        Buy_Inv.dgv_buy(2, x).Value = DGV_prd.CurrentRow.Cells(2).Value
        Buy_Inv.dgv_buy(3, x).Value = DGV_prd.CurrentRow.Cells(4).Value

        Me.Close()



    End Sub
   
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

End Class