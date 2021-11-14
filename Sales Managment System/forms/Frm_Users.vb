Imports System.Data.SqlClient

Public Class Frm_Users
    Public DT_User_Tbl As New DataTable

    Public Sub Load_User_Tbl(ByVal DGV_User_Tbl As DataGridView, ByVal Meform As Form)
        DGV_User_Tbl.DataSource = Nothing
        DGV_User_Tbl.Rows.Clear()
        DT_User_Tbl.Clear()
        Dim Cmd As New SqlCommand("Select Userid,FullName,UserName,Password,Is_User,M_File,M_Product,M_Customer,M_Importer,M_Buy,M_Sale,M_Store,M_Users,M_Expensive,M_Employee,M_Setting,M_Database,M_Stock_Bank From User_Tbl ", Con) '
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            DT_User_Tbl.Load(Cmd.ExecuteReader)
            Con.Close()
            Cmd = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Con.Close()
        End Try
        If DT_User_Tbl.Rows.Count <> 0 Then
            With DGV_User_Tbl
                .DataSource = DT_User_Tbl
            End With
        End If
    End Sub

    Private Sub Frm_Users_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Load_User_Tbl(DGV_User_Tbl, Me)
        FormatDGV_User_Tbl(DGV_User_Tbl)
    End Sub

    Public Sub FormatDGV_User_Tbl(ByVal DGV As DataGridView)
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("Userid").HeaderText = "رقم المستخدم"
                .Columns("FullName").HeaderText = "الاسم الكامل"
                .Columns("UserName").HeaderText = "اسم المستخدم"
                .Columns("Password").HeaderText = "كلمة المرور"
                .Columns("Is_User").HeaderText = "مستخدم للنظام"
                .Columns("M_File").HeaderText = "ملف"
                .Columns("M_Product").HeaderText = "ادارة المنتجات"
                .Columns("M_Customer").HeaderText = "ادارة العملاء"
                .Columns("M_Importer").HeaderText = "ادارة الموردين"
                .Columns("M_Buy").HeaderText = "ادارة المشتريات"
                .Columns("M_Sale").HeaderText = "ادارة المبيعات"
                .Columns("M_Store").HeaderText = "ادارة المخزن"
                .Columns("M_Users").HeaderText = "ادارة المستخدمين"
                .Columns("M_Expensive").HeaderText = "ادارة النفقات"
                .Columns("M_Employee").HeaderText = "ادارة الموظفين"
                .Columns("M_Setting").HeaderText = "ادارة الاعدادات"
                .Columns("M_Database").HeaderText = "ادارة قاعدة البيانات"
                .Columns("M_Stock_Bank").HeaderText = "ادارة الخزنة والبنك"
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            End With
        End If
    End Sub
    Public Sub InsertNewRowIn_User_Tbl(ByVal TxtUserid As Int32, ByVal TxtFullName As String, ByVal TxtUserName As String, ByVal TxtPassword As String, ByVal ChkIs_User As Boolean, ByVal ChkM_File As Boolean, ByVal ChkM_Product As Boolean, ByVal ChkM_Customer As Boolean, ByVal ChkM_Importer As Boolean, ByVal ChkM_Buy As Boolean, ByVal ChkM_Sale As Boolean, ByVal ChkM_Store As Boolean, ByVal ChkM_Users As Boolean, ByVal ChkM_Expensive As Boolean, ByVal ChkM_Employee As Boolean, ByVal ChkM_Setting As Boolean, ByVal ChkM_Database As Boolean, ByVal ChkM_Stock_Bank As Boolean)
        Dim CmdInsert As New SqlCommand
        With CmdInsert
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into User_Tbl (Userid , FullName , UserName , Password , Is_User , M_File , M_Product , M_Customer , M_Importer , M_Buy , M_Sale , M_Store , M_Users , M_Expensive , M_Employee , M_Setting , M_Database , M_Stock_Bank)values( @Userid ,  @FullName ,  @UserName ,  @Password ,  @Is_User ,  @M_File ,  @M_Product ,  @M_Customer ,  @M_Importer ,  @M_Buy ,  @M_Sale ,  @M_Store ,  @M_Users ,  @M_Expensive ,  @M_Employee ,  @M_Setting ,  @M_Database ,  @M_Stock_Bank)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Userid", SqlDbType.Int).Value = TxtUserid
            .Parameters.AddWithValue("@FullName", SqlDbType.VarChar).Value = TxtFullName
            .Parameters.AddWithValue("@UserName", SqlDbType.VarChar).Value = TxtUserName
            .Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = TxtPassword
            .Parameters.AddWithValue("@Is_User", SqlDbType.bit).Value = ChkIs_User
            .Parameters.AddWithValue("@M_File", SqlDbType.bit).Value = ChkM_File
            .Parameters.AddWithValue("@M_Product", SqlDbType.bit).Value = ChkM_Product
            .Parameters.AddWithValue("@M_Customer", SqlDbType.bit).Value = ChkM_Customer
            .Parameters.AddWithValue("@M_Importer", SqlDbType.bit).Value = ChkM_Importer
            .Parameters.AddWithValue("@M_Buy", SqlDbType.bit).Value = ChkM_Buy
            .Parameters.AddWithValue("@M_Sale", SqlDbType.bit).Value = ChkM_Sale
            .Parameters.AddWithValue("@M_Store", SqlDbType.bit).Value = ChkM_Store
            .Parameters.AddWithValue("@M_Users", SqlDbType.bit).Value = ChkM_Users
            .Parameters.AddWithValue("@M_Expensive", SqlDbType.bit).Value = ChkM_Expensive
            .Parameters.AddWithValue("@M_Employee", SqlDbType.bit).Value = ChkM_Employee
            .Parameters.AddWithValue("@M_Setting", SqlDbType.bit).Value = ChkM_Setting
            .Parameters.AddWithValue("@M_Database", SqlDbType.bit).Value = ChkM_Database
            .Parameters.AddWithValue("@M_Stock_Bank", SqlDbType.bit).Value = ChkM_Stock_Bank
        End With
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            CmdInsert.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم إضافة المستخدم بنجاح", MsgBoxStyle.Information, "حفظ")
            CmdInsert = Nothing
        Catch ex As Exception
            Con.Close()
            MsgBox(Err.Description, MsgBoxStyle.Information)
        Finally
            If Con.State = ConnectionState.Open Then Con.Close()
        End Try
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Try
            InsertNewRowIn_User_Tbl(TxtUserid.Text, TxtFullName.Text, TxtUserName.Text, TxtPassword.Text, ChkIs_User.CheckState, ChkM_File.CheckState, ChkM_Product.CheckState, ChkM_Customer.CheckState, ChkM_Importer.CheckState, ChkM_Buy.CheckState, ChkM_Sale.CheckState, ChkM_Store.CheckState, ChkM_Users.CheckState, ChkM_Expensive.CheckState, ChkM_Employee.CheckState, ChkM_Setting.CheckState, ChkM_Database.CheckState, ChkM_Stock_Bank.CheckState)
            ClearText()
            Load_User_Tbl(DGV_User_Tbl, Me)
            FormatDGV_User_Tbl(DGV_User_Tbl)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub ClearText()
        Me.TxtUserid.Text = vbNullString
        Me.TxtFullName.Text = vbNullString
        Me.TxtUserName.Text = vbNullString
        Me.TxtPassword.Text = vbNullString
        Me.ChkIs_User.Checked = False
        Me.ChkM_File.Checked = False
        Me.ChkM_Product.Checked = False
        Me.ChkM_Customer.Checked = False
        Me.ChkM_Importer.Checked = False
        Me.ChkM_Buy.Checked = False
        Me.ChkM_Sale.Checked = False
        Me.ChkM_Store.Checked = False
        Me.ChkM_Users.Checked = False
        Me.ChkM_Expensive.Checked = False
        Me.ChkM_Employee.Checked = False
        Me.ChkM_Setting.Checked = False
        Me.ChkM_Database.Checked = False
        Me.ChkM_Stock_Bank.Checked = False
    End Sub
    Public Sub UpdateRowIn_User_Tbl(ByVal TxtFullName As String, ByVal TxtUserName As String, ByVal TxtPassword As String, ByVal ChkIs_User As Boolean, ByVal ChkM_File As Boolean, ByVal ChkM_Product As Boolean, ByVal ChkM_Customer As Boolean, ByVal ChkM_Importer As Boolean, ByVal ChkM_Buy As Boolean, ByVal ChkM_Sale As Boolean, ByVal ChkM_Store As Boolean, ByVal ChkM_Users As Boolean, ByVal ChkM_Expensive As Boolean, ByVal ChkM_Employee As Boolean, ByVal ChkM_Setting As Boolean, ByVal ChkM_Database As Boolean, ByVal ChkM_Stock_Bank As Boolean, ByVal TxtUseridW As Int32)
        Dim CmdUpdate As New SqlCommand
        With CmdUpdate
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update User_Tbl Set FullName = @FullName , UserName = @UserName , Password = @Password , Is_User = @Is_User , M_File = @M_File , M_Product = @M_Product , M_Customer = @M_Customer , M_Importer = @M_Importer , M_Buy = @M_Buy , M_Sale = @M_Sale , M_Store = @M_Store , M_Users = @M_Users , M_Expensive = @M_Expensive , M_Employee = @M_Employee , M_Setting = @M_Setting , M_Database = @M_Database , M_Stock_Bank = @M_Stock_Bank Where Userid = @Userid"
            .Parameters.Clear()
            .Parameters.AddWithValue("@FullName", SqlDbType.VarChar).Value = TxtFullName
            .Parameters.AddWithValue("@UserName", SqlDbType.VarChar).Value = TxtUserName
            .Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = TxtPassword
            .Parameters.AddWithValue("@Is_User", SqlDbType.Bit).Value = ChkIs_User
            .Parameters.AddWithValue("@M_File", SqlDbType.Bit).Value = ChkM_File
            .Parameters.AddWithValue("@M_Product", SqlDbType.Bit).Value = ChkM_Product
            .Parameters.AddWithValue("@M_Customer", SqlDbType.Bit).Value = ChkM_Customer
            .Parameters.AddWithValue("@M_Importer", SqlDbType.Bit).Value = ChkM_Importer
            .Parameters.AddWithValue("@M_Buy", SqlDbType.Bit).Value = ChkM_Buy
            .Parameters.AddWithValue("@M_Sale", SqlDbType.Bit).Value = ChkM_Sale
            .Parameters.AddWithValue("@M_Store", SqlDbType.Bit).Value = ChkM_Store
            .Parameters.AddWithValue("@M_Users", SqlDbType.Bit).Value = ChkM_Users
            .Parameters.AddWithValue("@M_Expensive", SqlDbType.Bit).Value = ChkM_Expensive
            .Parameters.AddWithValue("@M_Employee", SqlDbType.Bit).Value = ChkM_Employee
            .Parameters.AddWithValue("@M_Setting", SqlDbType.Bit).Value = ChkM_Setting
            .Parameters.AddWithValue("@M_Database", SqlDbType.Bit).Value = ChkM_Database
            .Parameters.AddWithValue("@M_Stock_Bank", SqlDbType.Bit).Value = ChkM_Stock_Bank
            .Parameters.AddWithValue("@Userid", SqlDbType.Int).Value = TxtUseridW
        End With
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            CmdUpdate.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم تحديث المستخدم بنجاح", MsgBoxStyle.Information, "تحديث")
            CmdUpdate = Nothing
        Catch ex As Exception
            Con.Close()
            MsgBox(Err.Description, MsgBoxStyle.Information)
        Finally
            If Con.State = ConnectionState.Open Then Con.Close()
        End Try
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        Try
            UpdateRowIn_User_Tbl(TxtFullName.Text, TxtUserName.Text, TxtPassword.Text, ChkIs_User.CheckState, ChkM_File.CheckState, ChkM_Product.CheckState, ChkM_Customer.CheckState, ChkM_Importer.CheckState, ChkM_Buy.CheckState, ChkM_Sale.CheckState, ChkM_Store.CheckState, ChkM_Users.CheckState, ChkM_Expensive.CheckState, ChkM_Employee.CheckState, ChkM_Setting.CheckState, ChkM_Database.CheckState, ChkM_Stock_Bank.CheckState, TxtUserid.Text)
            ClearText()
            Load_User_Tbl(DGV_User_Tbl, Me)
            FormatDGV_User_Tbl(DGV_User_Tbl)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        ClearText()

        TxtUserid.Text = Max_ID("User_Tbl", "Userid") + 20211010

    End Sub

    Public Sub DeleteRowFrom_User_Tbl(ByVal DGV_User_Tbl As DataGridView)
        Dim Position As Integer = DGV_User_Tbl.CurrentRow.Index
        Dim ID_Position As Integer = DGV_User_Tbl.Rows(Position).Cells("Userid").Value
        Dim CmdDelete As New SqlCommand
        With CmdDelete
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From User_Tbl Where Userid = @Userid"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Userid", SqlDbType.Int).Value = ID_Position
        End With
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            CmdDelete.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
            CmdDelete = Nothing
        Catch ex As Exception
            Con.Close()
            MsgBox(Err.Description, MsgBoxStyle.Information)
        Finally
            If Con.State = ConnectionState.Open Then Con.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            DeleteRowFrom_User_Tbl(DGV_User_Tbl)
        End If
        Load_User_Tbl(DGV_User_Tbl, Me)
        FormatDGV_User_Tbl(DGV_User_Tbl)
    End Sub

    Private Sub DGV_User_Tbl_Click(sender As System.Object, e As System.EventArgs) Handles DGV_User_Tbl.Click

        Try
            With DGV_User_Tbl.CurrentRow
                Me.TxtUserid.Text = .Cells("Userid").Value.ToString()
                Me.TxtFullName.Text = .Cells("FullName").Value.ToString()
                Me.TxtUserName.Text = .Cells("UserName").Value.ToString()
                Me.TxtPassword.Text = .Cells("Password").Value.ToString()
                Me.ChkIs_User.Checked = .Cells("Is_User").Value.ToString()
                Me.ChkM_File.Checked = .Cells("M_File").Value.ToString()
                Me.ChkM_Product.Checked = .Cells("M_Product").Value.ToString()
                Me.ChkM_Customer.Checked = .Cells("M_Customer").Value.ToString()
                Me.ChkM_Importer.Checked = .Cells("M_Importer").Value.ToString()
                Me.ChkM_Buy.Checked = .Cells("M_Buy").Value.ToString()
                Me.ChkM_Sale.Checked = .Cells("M_Sale").Value.ToString()
                Me.ChkM_Store.Checked = .Cells("M_Store").Value.ToString()
                Me.ChkM_Users.Checked = .Cells("M_Users").Value.ToString()
                Me.ChkM_Expensive.Checked = .Cells("M_Expensive").Value.ToString()
                Me.ChkM_Employee.Checked = .Cells("M_Employee").Value.ToString()
                Me.ChkM_Setting.Checked = .Cells("M_Setting").Value.ToString()
                Me.ChkM_Database.Checked = .Cells("M_Database").Value.ToString()
                Me.ChkM_Stock_Bank.Checked = .Cells("M_Stock_Bank").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class