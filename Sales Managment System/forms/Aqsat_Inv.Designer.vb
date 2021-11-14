<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Aqsat_Inv
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Sale_Date = New System.Windows.Forms.DateTimePicker()
        Me.SalesMan = New System.Windows.Forms.TextBox()
        Me.Aqsat_Sale_ID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CusPhone = New System.Windows.Forms.TextBox()
        Me.CusName = New System.Windows.Forms.TextBox()
        Me.Cus_ID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvSale = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Prd_Code = New System.Windows.Forms.TextBox()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.Prd_ID = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.FinalTotal = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Money_Unpaid = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Money_Paid = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Qast_Amount = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Aqsat_No = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Aqsat_Unpaid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Aqsat_Paid = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.StartDate = New System.Windows.Forms.DateTimePicker()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Sale_Date)
        Me.GroupBox1.Controls.Add(Me.SalesMan)
        Me.GroupBox1.Controls.Add(Me.Aqsat_Sale_ID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 146)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "البيانات الاساسية"
        '
        'Sale_Date
        '
        Me.Sale_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Sale_Date.Location = New System.Drawing.Point(11, 66)
        Me.Sale_Date.Name = "Sale_Date"
        Me.Sale_Date.Size = New System.Drawing.Size(221, 27)
        Me.Sale_Date.TabIndex = 2
        '
        'SalesMan
        '
        Me.SalesMan.Location = New System.Drawing.Point(11, 101)
        Me.SalesMan.Name = "SalesMan"
        Me.SalesMan.Size = New System.Drawing.Size(221, 27)
        Me.SalesMan.TabIndex = 1
        Me.SalesMan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Aqsat_Sale_ID
        '
        Me.Aqsat_Sale_ID.Location = New System.Drawing.Point(11, 32)
        Me.Aqsat_Sale_ID.Name = "Aqsat_Sale_ID"
        Me.Aqsat_Sale_ID.ReadOnly = True
        Me.Aqsat_Sale_ID.Size = New System.Drawing.Size(221, 27)
        Me.Aqsat_Sale_ID.TabIndex = 1
        Me.Aqsat_Sale_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(238, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "اسم الموظف :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(238, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "تاريخ الفاتورة :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(238, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "رقم الفاتورة :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.CusPhone)
        Me.GroupBox2.Controls.Add(Me.CusName)
        Me.GroupBox2.Controls.Add(Me.Cus_ID)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(469, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(340, 146)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "بيانات العميل :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Teal
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(16, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 29)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "اختيار عميل"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'CusPhone
        '
        Me.CusPhone.BackColor = System.Drawing.Color.White
        Me.CusPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CusPhone.ForeColor = System.Drawing.Color.Black
        Me.CusPhone.Location = New System.Drawing.Point(16, 103)
        Me.CusPhone.Name = "CusPhone"
        Me.CusPhone.Size = New System.Drawing.Size(210, 27)
        Me.CusPhone.TabIndex = 20
        Me.CusPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CusName
        '
        Me.CusName.BackColor = System.Drawing.Color.White
        Me.CusName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CusName.ForeColor = System.Drawing.Color.Black
        Me.CusName.Location = New System.Drawing.Point(16, 68)
        Me.CusName.Name = "CusName"
        Me.CusName.Size = New System.Drawing.Size(210, 27)
        Me.CusName.TabIndex = 21
        Me.CusName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cus_ID
        '
        Me.Cus_ID.BackColor = System.Drawing.Color.White
        Me.Cus_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cus_ID.ForeColor = System.Drawing.Color.Black
        Me.Cus_ID.Location = New System.Drawing.Point(108, 34)
        Me.Cus_ID.Name = "Cus_ID"
        Me.Cus_ID.Size = New System.Drawing.Size(118, 27)
        Me.Cus_ID.TabIndex = 19
        Me.Cus_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(249, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 19)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "رقم الهاتف :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(249, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "اسم العميل :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(249, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 19)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "رقم العميل :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.dgvSale)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 223)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(914, 256)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "تفاصيل الفاتورة"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(868, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 213)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dgvSale
        '
        Me.dgvSale.AllowUserToAddRows = False
        Me.dgvSale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSale.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSale.ColumnHeadersHeight = 30
        Me.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column7, Me.Column8})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSale.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSale.EnableHeadersVisualStyles = False
        Me.dgvSale.Location = New System.Drawing.Point(17, 26)
        Me.dgvSale.Name = "dgvSale"
        Me.dgvSale.RowHeadersVisible = False
        Me.dgvSale.RowTemplate.Height = 30
        Me.dgvSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSale.Size = New System.Drawing.Size(843, 213)
        Me.dgvSale.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "رقم المنتج"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "باركود المنتج"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "اسم المنتج"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "وحدة المنتج"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "سعر البيع"
        Me.Column5.Name = "Column5"
        '
        'Column7
        '
        Me.Column7.HeaderText = "الكمية"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 80
        '
        'Column8
        '
        Me.Column8.HeaderText = "المبلغ الاجمالي"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 115
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.Prd_Code)
        Me.Panel7.Controls.Add(Me.BtnRemove)
        Me.Panel7.Controls.Add(Me.Prd_ID)
        Me.Panel7.Controls.Add(Me.Label24)
        Me.Panel7.Controls.Add(Me.Label23)
        Me.Panel7.Location = New System.Drawing.Point(12, 164)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(914, 49)
        Me.Panel7.TabIndex = 10
        '
        'Prd_Code
        '
        Me.Prd_Code.BackColor = System.Drawing.Color.White
        Me.Prd_Code.ForeColor = System.Drawing.Color.Black
        Me.Prd_Code.Location = New System.Drawing.Point(257, 10)
        Me.Prd_Code.Name = "Prd_Code"
        Me.Prd_Code.Size = New System.Drawing.Size(173, 27)
        Me.Prd_Code.TabIndex = 52
        Me.Prd_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnRemove
        '
        Me.BtnRemove.BackColor = System.Drawing.Color.Teal
        Me.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemove.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRemove.ForeColor = System.Drawing.Color.White
        Me.BtnRemove.Image = Global.Sales_Managment_System.My.Resources.Resources.Turbo32o80
        Me.BtnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRemove.Location = New System.Drawing.Point(6, 8)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(237, 29)
        Me.BtnRemove.TabIndex = 51
        Me.BtnRemove.Text = "حذف المادة المحددة من الفاتورة"
        Me.BtnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRemove.UseVisualStyleBackColor = False
        '
        'Prd_ID
        '
        Me.Prd_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Prd_ID.BackColor = System.Drawing.Color.White
        Me.Prd_ID.ForeColor = System.Drawing.Color.Black
        Me.Prd_ID.Location = New System.Drawing.Point(608, 10)
        Me.Prd_ID.Name = "Prd_ID"
        Me.Prd_ID.Size = New System.Drawing.Size(141, 27)
        Me.Prd_ID.TabIndex = 2
        Me.Prd_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(438, 13)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(164, 19)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "ادخال حسب باركود المنتج :"
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(755, 13)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(151, 19)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "ادخال حسب رقم المنتج :"
        '
        'FinalTotal
        '
        Me.FinalTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FinalTotal.BackColor = System.Drawing.Color.White
        Me.FinalTotal.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinalTotal.ForeColor = System.Drawing.Color.Black
        Me.FinalTotal.Location = New System.Drawing.Point(995, 23)
        Me.FinalTotal.Name = "FinalTotal"
        Me.FinalTotal.ReadOnly = True
        Me.FinalTotal.Size = New System.Drawing.Size(143, 30)
        Me.FinalTotal.TabIndex = 54
        Me.FinalTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(815, 30)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(175, 23)
        Me.Label19.TabIndex = 53
        Me.Label19.Text = "القيمة الاجمالية للفاتورة :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Money_Unpaid)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.Money_Paid)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Location = New System.Drawing.Point(819, 59)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(333, 87)
        Me.GroupBox5.TabIndex = 55
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "بيانات الدفع"
        '
        'Money_Unpaid
        '
        Me.Money_Unpaid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Money_Unpaid.BackColor = System.Drawing.Color.White
        Me.Money_Unpaid.ForeColor = System.Drawing.Color.Black
        Me.Money_Unpaid.Location = New System.Drawing.Point(48, 54)
        Me.Money_Unpaid.Name = "Money_Unpaid"
        Me.Money_Unpaid.ReadOnly = True
        Me.Money_Unpaid.Size = New System.Drawing.Size(158, 27)
        Me.Money_Unpaid.TabIndex = 53
        Me.Money_Unpaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(206, 57)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(90, 19)
        Me.Label21.TabIndex = 52
        Me.Label21.Text = "المبلغ المتبقي :"
        '
        'Money_Paid
        '
        Me.Money_Paid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Money_Paid.BackColor = System.Drawing.Color.White
        Me.Money_Paid.ForeColor = System.Drawing.Color.Black
        Me.Money_Paid.Location = New System.Drawing.Point(48, 21)
        Me.Money_Paid.Name = "Money_Paid"
        Me.Money_Paid.Size = New System.Drawing.Size(158, 27)
        Me.Money_Paid.TabIndex = 54
        Me.Money_Paid.Text = "0.00"
        Me.Money_Paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(206, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 19)
        Me.Label20.TabIndex = 51
        Me.Label20.Text = "المبلغ المدفوع :"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(933, 201)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 19)
        Me.Label11.TabIndex = 342
        Me.Label11.Text = "قيمة القسط"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Qast_Amount
        '
        Me.Qast_Amount.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Qast_Amount.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qast_Amount.Location = New System.Drawing.Point(1036, 196)
        Me.Qast_Amount.Margin = New System.Windows.Forms.Padding(4)
        Me.Qast_Amount.Name = "Qast_Amount"
        Me.Qast_Amount.ReadOnly = True
        Me.Qast_Amount.Size = New System.Drawing.Size(95, 29)
        Me.Qast_Amount.TabIndex = 343
        Me.Qast_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(933, 164)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 19)
        Me.Label12.TabIndex = 340
        Me.Label12.Text = "عدد الاقساط"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Aqsat_No
        '
        Me.Aqsat_No.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Aqsat_No.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aqsat_No.Location = New System.Drawing.Point(1036, 159)
        Me.Aqsat_No.Margin = New System.Windows.Forms.Padding(4)
        Me.Aqsat_No.Name = "Aqsat_No"
        Me.Aqsat_No.Size = New System.Drawing.Size(95, 29)
        Me.Aqsat_No.TabIndex = 341
        Me.Aqsat_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(942, 275)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 19)
        Me.Label7.TabIndex = 346
        Me.Label7.Text = "قسط متبقي"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Aqsat_Unpaid
        '
        Me.Aqsat_Unpaid.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Aqsat_Unpaid.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aqsat_Unpaid.Location = New System.Drawing.Point(1036, 270)
        Me.Aqsat_Unpaid.Margin = New System.Windows.Forms.Padding(4)
        Me.Aqsat_Unpaid.Name = "Aqsat_Unpaid"
        Me.Aqsat_Unpaid.Size = New System.Drawing.Size(95, 29)
        Me.Aqsat_Unpaid.TabIndex = 347
        Me.Aqsat_Unpaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(929, 238)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 19)
        Me.Label6.TabIndex = 344
        Me.Label6.Text = "قسط مدفوع"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Aqsat_Paid
        '
        Me.Aqsat_Paid.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Aqsat_Paid.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aqsat_Paid.Location = New System.Drawing.Point(1036, 233)
        Me.Aqsat_Paid.Margin = New System.Windows.Forms.Padding(4)
        Me.Aqsat_Paid.Name = "Aqsat_Paid"
        Me.Aqsat_Paid.Size = New System.Drawing.Size(95, 29)
        Me.Aqsat_Paid.TabIndex = 345
        Me.Aqsat_Paid.Text = "0"
        Me.Aqsat_Paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(991, 313)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 19)
        Me.Label13.TabIndex = 348
        Me.Label13.Text = "تاريخ بداية الاقساط :"
        '
        'StartDate
        '
        Me.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.StartDate.Location = New System.Drawing.Point(984, 335)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(147, 27)
        Me.StartDate.TabIndex = 349
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.White
        Me.BtnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnSave.FlatAppearance.BorderSize = 3
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.ForeColor = System.Drawing.Color.Black
        Me.BtnSave.Image = Global.Sales_Managment_System.My.Resources.Resources.save_321
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.Location = New System.Drawing.Point(961, 416)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(177, 42)
        Me.BtnSave.TabIndex = 351
        Me.BtnSave.Text = "حفظ الفاتورة"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnNew
        '
        Me.BtnNew.BackColor = System.Drawing.Color.White
        Me.BtnNew.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnNew.FlatAppearance.BorderSize = 3
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNew.ForeColor = System.Drawing.Color.Black
        Me.BtnNew.Image = Global.Sales_Managment_System.My.Resources.Resources.plus_6_24
        Me.BtnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNew.Location = New System.Drawing.Point(961, 368)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(177, 42)
        Me.BtnNew.TabIndex = 350
        Me.BtnNew.Text = "فاتورة بيع جديدة"
        Me.BtnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNew.UseVisualStyleBackColor = False
        '
        'Aqsat_Inv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1176, 491)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.StartDate)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Qast_Amount)
        Me.Controls.Add(Me.Aqsat_Unpaid)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Aqsat_No)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Aqsat_Paid)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.FinalTotal)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Aqsat_Inv"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "فاتورة بيع بالاقساط"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Sale_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents SalesMan As System.Windows.Forms.TextBox
    Friend WithEvents Aqsat_Sale_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CusPhone As System.Windows.Forms.TextBox
    Friend WithEvents CusName As System.Windows.Forms.TextBox
    Friend WithEvents Cus_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvSale As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Prd_Code As System.Windows.Forms.TextBox
    Friend WithEvents BtnRemove As System.Windows.Forms.Button
    Friend WithEvents Prd_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents FinalTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Money_Unpaid As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Money_Paid As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Qast_Amount As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Aqsat_No As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Aqsat_Unpaid As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Aqsat_Paid As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents StartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
End Class
