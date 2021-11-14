<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Show_Sale_Inv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Show_Sale_Inv))
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.FinalTotal = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DiscountTotal = New System.Windows.Forms.TextBox()
        Me.TaxTotal = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TaxValue = New System.Windows.Forms.TextBox()
        Me.DiscountValue = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Item_Count = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CusPhone = New System.Windows.Forms.TextBox()
        Me.CusName = New System.Windows.Forms.TextBox()
        Me.Cus_ID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Inv_Type = New System.Windows.Forms.ComboBox()
        Me.Sale_Date = New System.Windows.Forms.DateTimePicker()
        Me.SalesMan = New System.Windows.Forms.TextBox()
        Me.Sale_ID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvSale = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnPaid = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Paid = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.FinalTotal)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.DiscountTotal)
        Me.Panel5.Controls.Add(Me.TaxTotal)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.TaxValue)
        Me.Panel5.Controls.Add(Me.DiscountValue)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.Total)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.Item_Count)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Location = New System.Drawing.Point(698, 12)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(479, 191)
        Me.Panel5.TabIndex = 9
        '
        'FinalTotal
        '
        Me.FinalTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FinalTotal.BackColor = System.Drawing.Color.White
        Me.FinalTotal.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinalTotal.ForeColor = System.Drawing.Color.Black
        Me.FinalTotal.Location = New System.Drawing.Point(89, 148)
        Me.FinalTotal.Name = "FinalTotal"
        Me.FinalTotal.ReadOnly = True
        Me.FinalTotal.Size = New System.Drawing.Size(143, 30)
        Me.FinalTotal.TabIndex = 52
        Me.FinalTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(240, 65)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(24, 23)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "%"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(241, 110)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 23)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "%"
        '
        'DiscountTotal
        '
        Me.DiscountTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DiscountTotal.BackColor = System.Drawing.Color.White
        Me.DiscountTotal.ForeColor = System.Drawing.Color.Black
        Me.DiscountTotal.Location = New System.Drawing.Point(18, 60)
        Me.DiscountTotal.Name = "DiscountTotal"
        Me.DiscountTotal.ReadOnly = True
        Me.DiscountTotal.Size = New System.Drawing.Size(129, 27)
        Me.DiscountTotal.TabIndex = 50
        Me.DiscountTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TaxTotal
        '
        Me.TaxTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TaxTotal.BackColor = System.Drawing.Color.White
        Me.TaxTotal.ForeColor = System.Drawing.Color.Black
        Me.TaxTotal.Location = New System.Drawing.Point(18, 105)
        Me.TaxTotal.Name = "TaxTotal"
        Me.TaxTotal.ReadOnly = True
        Me.TaxTotal.Size = New System.Drawing.Size(129, 27)
        Me.TaxTotal.TabIndex = 50
        Me.TaxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(384, 108)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 19)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "نسبة الضريبة :"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(147, 65)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(87, 19)
        Me.Label18.TabIndex = 49
        Me.Label18.Text = "قيمة الخصم :"
        '
        'TaxValue
        '
        Me.TaxValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TaxValue.BackColor = System.Drawing.Color.White
        Me.TaxValue.ForeColor = System.Drawing.Color.Black
        Me.TaxValue.Location = New System.Drawing.Point(270, 104)
        Me.TaxValue.Name = "TaxValue"
        Me.TaxValue.ReadOnly = True
        Me.TaxValue.Size = New System.Drawing.Size(113, 27)
        Me.TaxValue.TabIndex = 50
        Me.TaxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DiscountValue
        '
        Me.DiscountValue.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DiscountValue.BackColor = System.Drawing.Color.White
        Me.DiscountValue.ForeColor = System.Drawing.Color.Black
        Me.DiscountValue.Location = New System.Drawing.Point(270, 58)
        Me.DiscountValue.Name = "DiscountValue"
        Me.DiscountValue.Size = New System.Drawing.Size(113, 27)
        Me.DiscountValue.TabIndex = 50
        Me.DiscountValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(147, 110)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 19)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "قيمة الضريبة :"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(238, 151)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(175, 23)
        Me.Label19.TabIndex = 49
        Me.Label19.Text = "القيمة الاجمالية للفاتورة :"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(383, 63)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 19)
        Me.Label16.TabIndex = 49
        Me.Label16.Text = "نسبة الخصم :"
        '
        'Total
        '
        Me.Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Total.BackColor = System.Drawing.Color.White
        Me.Total.ForeColor = System.Drawing.Color.Black
        Me.Total.Location = New System.Drawing.Point(18, 8)
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Size = New System.Drawing.Size(129, 27)
        Me.Total.TabIndex = 50
        Me.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(147, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 19)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "المجموع الكلي :"
        '
        'Item_Count
        '
        Me.Item_Count.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Item_Count.BackColor = System.Drawing.Color.White
        Me.Item_Count.ForeColor = System.Drawing.Color.Black
        Me.Item_Count.Location = New System.Drawing.Point(270, 8)
        Me.Item_Count.Name = "Item_Count"
        Me.Item_Count.ReadOnly = True
        Me.Item_Count.Size = New System.Drawing.Size(113, 27)
        Me.Item_Count.TabIndex = 50
        Me.Item_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(383, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 19)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "عدد المواد :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.UnPaid)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Paid)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.CusPhone)
        Me.GroupBox2.Controls.Add(Me.CusName)
        Me.GroupBox2.Controls.Add(Me.Cus_ID)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(352, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(340, 197)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "بيانات العميل :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Teal
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(16, 21)
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
        Me.CusPhone.Location = New System.Drawing.Point(16, 91)
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
        Me.CusName.Location = New System.Drawing.Point(16, 56)
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
        Me.Cus_ID.Location = New System.Drawing.Point(108, 22)
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
        Me.Label5.Location = New System.Drawing.Point(249, 94)
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
        Me.Label8.Location = New System.Drawing.Point(249, 59)
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
        Me.Label9.Location = New System.Drawing.Point(249, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 19)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "رقم العميل :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Inv_Type)
        Me.GroupBox1.Controls.Add(Me.Sale_Date)
        Me.GroupBox1.Controls.Add(Me.SalesMan)
        Me.GroupBox1.Controls.Add(Me.Sale_ID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 198)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "البيانات الاساسية"
        '
        'Inv_Type
        '
        Me.Inv_Type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Inv_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Inv_Type.FormattingEnabled = True
        Me.Inv_Type.Items.AddRange(New Object() {"نقدي", "ذمم"})
        Me.Inv_Type.Location = New System.Drawing.Point(11, 136)
        Me.Inv_Type.Name = "Inv_Type"
        Me.Inv_Type.Size = New System.Drawing.Size(221, 27)
        Me.Inv_Type.TabIndex = 4
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
        Me.SalesMan.Text = "admin"
        Me.SalesMan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Sale_ID
        '
        Me.Sale_ID.Location = New System.Drawing.Point(11, 32)
        Me.Sale_ID.Name = "Sale_ID"
        Me.Sale_ID.ReadOnly = True
        Me.Sale_ID.Size = New System.Drawing.Size(221, 27)
        Me.Sale_ID.TabIndex = 1
        Me.Sale_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "نوع الفاتورة :"
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvSale)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 209)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(908, 256)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "تفاصيل الفاتورة"
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
        Me.dgvSale.Location = New System.Drawing.Point(13, 26)
        Me.dgvSale.Name = "dgvSale"
        Me.dgvSale.RowHeadersVisible = False
        Me.dgvSale.RowTemplate.Height = 30
        Me.dgvSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSale.Size = New System.Drawing.Size(889, 213)
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
        'UnPaid
        '
        Me.UnPaid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UnPaid.BackColor = System.Drawing.Color.White
        Me.UnPaid.ForeColor = System.Drawing.Color.Black
        Me.UnPaid.Location = New System.Drawing.Point(16, 157)
        Me.UnPaid.Name = "UnPaid"
        Me.UnPaid.ReadOnly = True
        Me.UnPaid.Size = New System.Drawing.Size(210, 27)
        Me.UnPaid.TabIndex = 57
        Me.UnPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(226, 160)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(90, 19)
        Me.Label21.TabIndex = 56
        Me.Label21.Text = "المبلغ المتبقي :"
        '
        'Paid
        '
        Me.Paid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Paid.BackColor = System.Drawing.Color.White
        Me.Paid.ForeColor = System.Drawing.Color.Black
        Me.Paid.Location = New System.Drawing.Point(16, 124)
        Me.Paid.Name = "Paid"
        Me.Paid.Size = New System.Drawing.Size(210, 27)
        Me.Paid.TabIndex = 58
        Me.Paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(226, 127)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 19)
        Me.Label20.TabIndex = 55
        Me.Label20.Text = "المبلغ المدفوع :"
        '
        'Show_Sale_Inv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 480)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Show_Sale_Inv"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "عرض فاتورة المبيعات"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents FinalTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DiscountTotal As System.Windows.Forms.TextBox
    Friend WithEvents TaxTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TaxValue As System.Windows.Forms.TextBox
    Friend WithEvents DiscountValue As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Total As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Item_Count As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CusPhone As System.Windows.Forms.TextBox
    Friend WithEvents CusName As System.Windows.Forms.TextBox
    Friend WithEvents Cus_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Inv_Type As System.Windows.Forms.ComboBox
    Friend WithEvents Sale_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents SalesMan As System.Windows.Forms.TextBox
    Friend WithEvents Sale_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSale As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnPaid As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Paid As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
End Class
