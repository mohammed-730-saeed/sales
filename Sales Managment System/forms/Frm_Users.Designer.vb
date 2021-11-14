<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Users
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.UseridLbl = New System.Windows.Forms.Label()
        Me.UserNameLbl = New System.Windows.Forms.Label()
        Me.PasswordLbl = New System.Windows.Forms.Label()
        Me.TxtUserid = New System.Windows.Forms.TextBox()
        Me.TxtUserName = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.ChkIs_User = New System.Windows.Forms.CheckBox()
        Me.ChkM_Product = New System.Windows.Forms.CheckBox()
        Me.ChkM_Customer = New System.Windows.Forms.CheckBox()
        Me.ChkM_Importer = New System.Windows.Forms.CheckBox()
        Me.ChkM_Buy = New System.Windows.Forms.CheckBox()
        Me.ChkM_Sale = New System.Windows.Forms.CheckBox()
        Me.ChkM_Store = New System.Windows.Forms.CheckBox()
        Me.ChkM_Users = New System.Windows.Forms.CheckBox()
        Me.ChkM_Employee = New System.Windows.Forms.CheckBox()
        Me.ChkM_Setting = New System.Windows.Forms.CheckBox()
        Me.ChkM_Database = New System.Windows.Forms.CheckBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.DGV_User_Tbl = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtFullName = New System.Windows.Forms.TextBox()
        Me.ChkM_File = New System.Windows.Forms.CheckBox()
        Me.ChkM_Expensive = New System.Windows.Forms.CheckBox()
        Me.ChkM_Stock_Bank = New System.Windows.Forms.CheckBox()
        CType(Me.DGV_User_Tbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UseridLbl
        '
        Me.UseridLbl.Location = New System.Drawing.Point(9, 22)
        Me.UseridLbl.Name = "UseridLbl"
        Me.UseridLbl.Size = New System.Drawing.Size(107, 26)
        Me.UseridLbl.TabIndex = 0
        Me.UseridLbl.Text = "رقم المستخدم"
        Me.UseridLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserNameLbl
        '
        Me.UserNameLbl.Location = New System.Drawing.Point(9, 97)
        Me.UserNameLbl.Name = "UserNameLbl"
        Me.UserNameLbl.Size = New System.Drawing.Size(107, 26)
        Me.UserNameLbl.TabIndex = 1
        Me.UserNameLbl.Text = "اسم المستخدم"
        Me.UserNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PasswordLbl
        '
        Me.PasswordLbl.Location = New System.Drawing.Point(9, 130)
        Me.PasswordLbl.Name = "PasswordLbl"
        Me.PasswordLbl.Size = New System.Drawing.Size(107, 26)
        Me.PasswordLbl.TabIndex = 2
        Me.PasswordLbl.Text = "كلمة المرور"
        Me.PasswordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtUserid
        '
        Me.TxtUserid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtUserid.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserid.ForeColor = System.Drawing.Color.Blue
        Me.TxtUserid.Location = New System.Drawing.Point(116, 22)
        Me.TxtUserid.Name = "TxtUserid"
        Me.TxtUserid.Size = New System.Drawing.Size(267, 29)
        Me.TxtUserid.TabIndex = 17
        Me.TxtUserid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtUserName
        '
        Me.TxtUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtUserName.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUserName.ForeColor = System.Drawing.Color.Blue
        Me.TxtUserName.Location = New System.Drawing.Point(116, 97)
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(267, 29)
        Me.TxtUserName.TabIndex = 18
        Me.TxtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtPassword.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.ForeColor = System.Drawing.Color.Blue
        Me.TxtPassword.Location = New System.Drawing.Point(116, 130)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(267, 29)
        Me.TxtPassword.TabIndex = 19
        Me.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ChkIs_User
        '
        Me.ChkIs_User.Location = New System.Drawing.Point(396, 22)
        Me.ChkIs_User.Name = "ChkIs_User"
        Me.ChkIs_User.Size = New System.Drawing.Size(145, 26)
        Me.ChkIs_User.TabIndex = 20
        Me.ChkIs_User.Text = "مستخدم للنظام"
        Me.ChkIs_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkM_Product
        '
        Me.ChkM_Product.Location = New System.Drawing.Point(396, 91)
        Me.ChkM_Product.Name = "ChkM_Product"
        Me.ChkM_Product.Size = New System.Drawing.Size(145, 26)
        Me.ChkM_Product.TabIndex = 22
        Me.ChkM_Product.Text = "ادارة المنتجات"
        Me.ChkM_Product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkM_Customer
        '
        Me.ChkM_Customer.Location = New System.Drawing.Point(396, 124)
        Me.ChkM_Customer.Name = "ChkM_Customer"
        Me.ChkM_Customer.Size = New System.Drawing.Size(145, 26)
        Me.ChkM_Customer.TabIndex = 23
        Me.ChkM_Customer.Text = "ادارة العملاء"
        Me.ChkM_Customer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkM_Importer
        '
        Me.ChkM_Importer.Location = New System.Drawing.Point(396, 158)
        Me.ChkM_Importer.Name = "ChkM_Importer"
        Me.ChkM_Importer.Size = New System.Drawing.Size(145, 26)
        Me.ChkM_Importer.TabIndex = 24
        Me.ChkM_Importer.Text = "ادارة الموردين"
        Me.ChkM_Importer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkM_Buy
        '
        Me.ChkM_Buy.Location = New System.Drawing.Point(551, 158)
        Me.ChkM_Buy.Name = "ChkM_Buy"
        Me.ChkM_Buy.Size = New System.Drawing.Size(145, 26)
        Me.ChkM_Buy.TabIndex = 25
        Me.ChkM_Buy.Text = "ادارة المشتريات"
        Me.ChkM_Buy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkM_Sale
        '
        Me.ChkM_Sale.Location = New System.Drawing.Point(396, 54)
        Me.ChkM_Sale.Name = "ChkM_Sale"
        Me.ChkM_Sale.Size = New System.Drawing.Size(156, 26)
        Me.ChkM_Sale.TabIndex = 26
        Me.ChkM_Sale.Text = "ادارة المبيعات"
        Me.ChkM_Sale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkM_Store
        '
        Me.ChkM_Store.Location = New System.Drawing.Point(551, 22)
        Me.ChkM_Store.Name = "ChkM_Store"
        Me.ChkM_Store.Size = New System.Drawing.Size(165, 26)
        Me.ChkM_Store.TabIndex = 27
        Me.ChkM_Store.Text = "ادارة المخزن"
        Me.ChkM_Store.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkM_Users
        '
        Me.ChkM_Users.Location = New System.Drawing.Point(551, 57)
        Me.ChkM_Users.Name = "ChkM_Users"
        Me.ChkM_Users.Size = New System.Drawing.Size(165, 26)
        Me.ChkM_Users.TabIndex = 28
        Me.ChkM_Users.Text = "ادارة المستخدمين"
        Me.ChkM_Users.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkM_Employee
        '
        Me.ChkM_Employee.Location = New System.Drawing.Point(551, 91)
        Me.ChkM_Employee.Name = "ChkM_Employee"
        Me.ChkM_Employee.Size = New System.Drawing.Size(156, 26)
        Me.ChkM_Employee.TabIndex = 30
        Me.ChkM_Employee.Text = "ادارة الموظفين"
        Me.ChkM_Employee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkM_Setting
        '
        Me.ChkM_Setting.Location = New System.Drawing.Point(728, 23)
        Me.ChkM_Setting.Name = "ChkM_Setting"
        Me.ChkM_Setting.Size = New System.Drawing.Size(165, 26)
        Me.ChkM_Setting.TabIndex = 31
        Me.ChkM_Setting.Text = "ادارة الاعدادات"
        Me.ChkM_Setting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChkM_Database
        '
        Me.ChkM_Database.Location = New System.Drawing.Point(551, 124)
        Me.ChkM_Database.Name = "ChkM_Database"
        Me.ChkM_Database.Size = New System.Drawing.Size(156, 26)
        Me.ChkM_Database.TabIndex = 32
        Me.ChkM_Database.Text = "ادارة قاعدة البيانات"
        Me.ChkM_Database.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(899, 15)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(123, 40)
        Me.btnNew.TabIndex = 34
        Me.btnNew.Text = "إضافة"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(899, 70)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(123, 40)
        Me.btnEdit.TabIndex = 35
        Me.btnEdit.Text = "تعديل"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(1044, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(124, 40)
        Me.btnSave.TabIndex = 36
        Me.btnSave.Text = "حفظ"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(1044, 69)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(124, 40)
        Me.btnDelete.TabIndex = 37
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(964, 122)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(146, 40)
        Me.btnClose.TabIndex = 38
        Me.btnClose.Text = "إغلاق"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'DGV_User_Tbl
        '
        Me.DGV_User_Tbl.AllowUserToAddRows = False
        Me.DGV_User_Tbl.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_User_Tbl.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_User_Tbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_User_Tbl.EnableHeadersVisualStyles = False
        Me.DGV_User_Tbl.Location = New System.Drawing.Point(9, 198)
        Me.DGV_User_Tbl.Name = "DGV_User_Tbl"
        Me.DGV_User_Tbl.ReadOnly = True
        Me.DGV_User_Tbl.RowHeadersVisible = False
        Me.DGV_User_Tbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_User_Tbl.Size = New System.Drawing.Size(1173, 262)
        Me.DGV_User_Tbl.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 26)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "الاسم الكامل"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtFullName
        '
        Me.TxtFullName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtFullName.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFullName.ForeColor = System.Drawing.Color.Blue
        Me.TxtFullName.Location = New System.Drawing.Point(116, 60)
        Me.TxtFullName.Name = "TxtFullName"
        Me.TxtFullName.Size = New System.Drawing.Size(267, 29)
        Me.TxtFullName.TabIndex = 41
        Me.TxtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ChkM_File
        '
        Me.ChkM_File.Location = New System.Drawing.Point(821, 166)
        Me.ChkM_File.Name = "ChkM_File"
        Me.ChkM_File.Size = New System.Drawing.Size(19, 26)
        Me.ChkM_File.TabIndex = 21
        Me.ChkM_File.Text = "قائمة ملف"
        Me.ChkM_File.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkM_File.Visible = False
        '
        'ChkM_Expensive
        '
        Me.ChkM_Expensive.Location = New System.Drawing.Point(846, 164)
        Me.ChkM_Expensive.Name = "ChkM_Expensive"
        Me.ChkM_Expensive.Size = New System.Drawing.Size(18, 26)
        Me.ChkM_Expensive.TabIndex = 29
        Me.ChkM_Expensive.Text = "ادارة النفقات"
        Me.ChkM_Expensive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkM_Expensive.Visible = False
        '
        'ChkM_Stock_Bank
        '
        Me.ChkM_Stock_Bank.Location = New System.Drawing.Point(870, 164)
        Me.ChkM_Stock_Bank.Name = "ChkM_Stock_Bank"
        Me.ChkM_Stock_Bank.Size = New System.Drawing.Size(23, 26)
        Me.ChkM_Stock_Bank.TabIndex = 33
        Me.ChkM_Stock_Bank.Text = "ادارة الخزنة والبنك"
        Me.ChkM_Stock_Bank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkM_Stock_Bank.Visible = False
        '
        'Frm_Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1194, 472)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtFullName)
        Me.Controls.Add(Me.DGV_User_Tbl)
        Me.Controls.Add(Me.UseridLbl)
        Me.Controls.Add(Me.UserNameLbl)
        Me.Controls.Add(Me.PasswordLbl)
        Me.Controls.Add(Me.TxtUserid)
        Me.Controls.Add(Me.TxtUserName)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.ChkIs_User)
        Me.Controls.Add(Me.ChkM_File)
        Me.Controls.Add(Me.ChkM_Product)
        Me.Controls.Add(Me.ChkM_Customer)
        Me.Controls.Add(Me.ChkM_Importer)
        Me.Controls.Add(Me.ChkM_Buy)
        Me.Controls.Add(Me.ChkM_Sale)
        Me.Controls.Add(Me.ChkM_Store)
        Me.Controls.Add(Me.ChkM_Users)
        Me.Controls.Add(Me.ChkM_Expensive)
        Me.Controls.Add(Me.ChkM_Employee)
        Me.Controls.Add(Me.ChkM_Setting)
        Me.Controls.Add(Me.ChkM_Database)
        Me.Controls.Add(Me.ChkM_Stock_Bank)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClose)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Frm_Users"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "شاشة ادارة المستخدمين"
        CType(Me.DGV_User_Tbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtUserid As System.Windows.Forms.TextBox
    Friend WithEvents TxtUserName As System.Windows.Forms.TextBox
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents ChkIs_User As System.Windows.Forms.CheckBox
    Friend WithEvents ChkM_Product As System.Windows.Forms.CheckBox
    Friend WithEvents ChkM_Customer As System.Windows.Forms.CheckBox
    Friend WithEvents ChkM_Importer As System.Windows.Forms.CheckBox
    Friend WithEvents ChkM_Buy As System.Windows.Forms.CheckBox
    Friend WithEvents ChkM_Sale As System.Windows.Forms.CheckBox
    Friend WithEvents ChkM_Store As System.Windows.Forms.CheckBox
    Friend WithEvents ChkM_Users As System.Windows.Forms.CheckBox
    Friend WithEvents ChkM_Employee As System.Windows.Forms.CheckBox
    Friend WithEvents ChkM_Setting As System.Windows.Forms.CheckBox
    Friend WithEvents ChkM_Database As System.Windows.Forms.CheckBox

    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button


    Friend WithEvents UseridLbl As System.Windows.Forms.Label
    Friend WithEvents UserNameLbl As System.Windows.Forms.Label
    Friend WithEvents PasswordLbl As System.Windows.Forms.Label
    Friend WithEvents DGV_User_Tbl As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtFullName As System.Windows.Forms.TextBox
    Friend WithEvents ChkM_File As CheckBox
    Friend WithEvents ChkM_Expensive As CheckBox
    Friend WithEvents ChkM_Stock_Bank As CheckBox
End Class
