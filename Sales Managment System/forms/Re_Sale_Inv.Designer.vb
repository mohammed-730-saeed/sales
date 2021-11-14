<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Re_Sale_Inv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Re_Sale_Inv))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Sale_Date = New System.Windows.Forms.DateTimePicker()
        Me.Inv_Type = New System.Windows.Forms.ComboBox()
        Me.Re_Sale_Date = New System.Windows.Forms.DateTimePicker()
        Me.SalesMan = New System.Windows.Forms.TextBox()
        Me.Sale_ID = New System.Windows.Forms.TextBox()
        Me.Re_Sale_ID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Onhim = New System.Windows.Forms.TextBox()
        Me.CusPhone = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToHim = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CusName = New System.Windows.Forms.TextBox()
        Me.Cus_ID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
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
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Prd_Code = New System.Windows.Forms.TextBox()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.Prd_ID = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvSale = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Sale_Date)
        Me.GroupBox1.Controls.Add(Me.Inv_Type)
        Me.GroupBox1.Controls.Add(Me.Re_Sale_Date)
        Me.GroupBox1.Controls.Add(Me.SalesMan)
        Me.GroupBox1.Controls.Add(Me.Sale_ID)
        Me.GroupBox1.Controls.Add(Me.Re_Sale_ID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 244)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "البيانات الاساسية"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(255, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "تاريخ فاتورة البيع :"
        '
        'Sale_Date
        '
        Me.Sale_Date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sale_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Sale_Date.Location = New System.Drawing.Point(28, 206)
        Me.Sale_Date.Name = "Sale_Date"
        Me.Sale_Date.ShowUpDown = True
        Me.Sale_Date.Size = New System.Drawing.Size(221, 27)
        Me.Sale_Date.TabIndex = 5
        '
        'Inv_Type
        '
        Me.Inv_Type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Inv_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Inv_Type.FormattingEnabled = True
        Me.Inv_Type.Items.AddRange(New Object() {"نقدي", "ذمم"})
        Me.Inv_Type.Location = New System.Drawing.Point(28, 140)
        Me.Inv_Type.Name = "Inv_Type"
        Me.Inv_Type.Size = New System.Drawing.Size(221, 27)
        Me.Inv_Type.TabIndex = 4
        '
        'Re_Sale_Date
        '
        Me.Re_Sale_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Re_Sale_Date.Location = New System.Drawing.Point(28, 65)
        Me.Re_Sale_Date.Name = "Re_Sale_Date"
        Me.Re_Sale_Date.Size = New System.Drawing.Size(221, 27)
        Me.Re_Sale_Date.TabIndex = 2
        '
        'SalesMan
        '
        Me.SalesMan.Location = New System.Drawing.Point(28, 104)
        Me.SalesMan.Name = "SalesMan"
        Me.SalesMan.Size = New System.Drawing.Size(221, 27)
        Me.SalesMan.TabIndex = 1
        Me.SalesMan.Text = "admin"
        Me.SalesMan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Sale_ID
        '
        Me.Sale_ID.Location = New System.Drawing.Point(28, 173)
        Me.Sale_ID.Name = "Sale_ID"
        Me.Sale_ID.Size = New System.Drawing.Size(221, 27)
        Me.Sale_ID.TabIndex = 1
        Me.Sale_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Re_Sale_ID
        '
        Me.Re_Sale_ID.Location = New System.Drawing.Point(28, 32)
        Me.Re_Sale_ID.Name = "Re_Sale_ID"
        Me.Re_Sale_ID.ReadOnly = True
        Me.Re_Sale_ID.Size = New System.Drawing.Size(221, 27)
        Me.Re_Sale_ID.TabIndex = 1
        Me.Re_Sale_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(255, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "نوع الفاتورة :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(255, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "اسم الموظف :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(255, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "رقم الفاتورة البيع :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(255, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "تاريخ الفاتورة :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(255, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "رقم الفاتورة :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Onhim)
        Me.GroupBox2.Controls.Add(Me.CusPhone)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.ToHim)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.CusName)
        Me.GroupBox2.Controls.Add(Me.Cus_ID)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Location = New System.Drawing.Point(385, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(304, 240)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "بيانات العميل :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(11, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 27)
        Me.TextBox1.TabIndex = 23
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Onhim
        '
        Me.Onhim.BackColor = System.Drawing.Color.White
        Me.Onhim.ForeColor = System.Drawing.Color.Black
        Me.Onhim.Location = New System.Drawing.Point(11, 203)
        Me.Onhim.Name = "Onhim"
        Me.Onhim.Size = New System.Drawing.Size(180, 27)
        Me.Onhim.TabIndex = 14
        Me.Onhim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CusPhone
        '
        Me.CusPhone.BackColor = System.Drawing.Color.White
        Me.CusPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CusPhone.ForeColor = System.Drawing.Color.Black
        Me.CusPhone.Location = New System.Drawing.Point(11, 134)
        Me.CusPhone.Name = "CusPhone"
        Me.CusPhone.Size = New System.Drawing.Size(180, 27)
        Me.CusPhone.TabIndex = 20
        Me.CusPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(214, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "دائــن :"
        '
        'ToHim
        '
        Me.ToHim.BackColor = System.Drawing.Color.White
        Me.ToHim.ForeColor = System.Drawing.Color.Black
        Me.ToHim.Location = New System.Drawing.Point(11, 169)
        Me.ToHim.Name = "ToHim"
        Me.ToHim.Size = New System.Drawing.Size(180, 27)
        Me.ToHim.TabIndex = 13
        Me.ToHim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(214, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 19)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "مديــن :"
        '
        'CusName
        '
        Me.CusName.BackColor = System.Drawing.Color.White
        Me.CusName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CusName.ForeColor = System.Drawing.Color.Black
        Me.CusName.Location = New System.Drawing.Point(11, 99)
        Me.CusName.Name = "CusName"
        Me.CusName.Size = New System.Drawing.Size(180, 27)
        Me.CusName.TabIndex = 21
        Me.CusName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Cus_ID
        '
        Me.Cus_ID.BackColor = System.Drawing.Color.White
        Me.Cus_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cus_ID.ForeColor = System.Drawing.Color.Black
        Me.Cus_ID.Location = New System.Drawing.Point(11, 65)
        Me.Cus_ID.Name = "Cus_ID"
        Me.Cus_ID.Size = New System.Drawing.Size(180, 27)
        Me.Cus_ID.TabIndex = 19
        Me.Cus_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(214, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 19)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "رقم الهاتف :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(214, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 19)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "اسم العميل :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(214, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 19)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "رقم العميل :"
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
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.Location = New System.Drawing.Point(695, 12)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(479, 191)
        Me.Panel5.TabIndex = 7
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
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(383, 11)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(75, 19)
        Me.Label20.TabIndex = 49
        Me.Label20.Text = "عدد المواد :"
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.Prd_Code)
        Me.Panel7.Controls.Add(Me.BtnRemove)
        Me.Panel7.Controls.Add(Me.Prd_ID)
        Me.Panel7.Controls.Add(Me.Label24)
        Me.Panel7.Controls.Add(Me.Label23)
        Me.Panel7.Location = New System.Drawing.Point(7, 246)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(927, 49)
        Me.Panel7.TabIndex = 9
        '
        'Prd_Code
        '
        Me.Prd_Code.BackColor = System.Drawing.Color.White
        Me.Prd_Code.ForeColor = System.Drawing.Color.Black
        Me.Prd_Code.Location = New System.Drawing.Point(270, 10)
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
        Me.Prd_ID.Location = New System.Drawing.Point(622, 10)
        Me.Prd_ID.Name = "Prd_ID"
        Me.Prd_ID.Size = New System.Drawing.Size(138, 27)
        Me.Prd_ID.TabIndex = 2
        Me.Prd_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(449, 13)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(164, 19)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "ادخال حسب باركود المنتج :"
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(766, 13)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(151, 19)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "ادخال حسب رقم المنتج :"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.dgvSale)
        Me.Panel4.Location = New System.Drawing.Point(57, 301)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(877, 185)
        Me.Panel4.TabIndex = 13
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
        Me.dgvSale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSale.EnableHeadersVisualStyles = False
        Me.dgvSale.Location = New System.Drawing.Point(0, 0)
        Me.dgvSale.Name = "dgvSale"
        Me.dgvSale.RowHeadersVisible = False
        Me.dgvSale.RowTemplate.Height = 30
        Me.dgvSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSale.Size = New System.Drawing.Size(873, 181)
        Me.dgvSale.TabIndex = 2
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
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(7, 299)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 185)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.BtnClose.FlatAppearance.BorderSize = 3
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Image = Global.Sales_Managment_System.My.Resources.Resources.exit_2_32_blue
        Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnClose.Location = New System.Drawing.Point(19, 154)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(177, 42)
        Me.BtnClose.TabIndex = 56
        Me.BtnClose.Text = "اغلاق الشاشة"
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSave.FlatAppearance.BorderSize = 3
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Image = Global.Sales_Managment_System.My.Resources.Resources.save_321
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.Location = New System.Drawing.Point(19, 96)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(177, 42)
        Me.BtnSave.TabIndex = 54
        Me.BtnSave.Text = "حفظ الفاتورة"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnNew
        '
        Me.BtnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnNew.FlatAppearance.BorderSize = 3
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNew.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.ForeColor = System.Drawing.Color.White
        Me.BtnNew.Image = Global.Sales_Managment_System.My.Resources.Resources.plus_6_24
        Me.BtnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNew.Location = New System.Drawing.Point(19, 37)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(177, 42)
        Me.BtnNew.TabIndex = 55
        Me.BtnNew.Text = "فاتورة مرتجع شراء جديدة"
        Me.BtnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNew.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Controls.Add(Me.BtnNew)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Location = New System.Drawing.Point(946, 246)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(227, 235)
        Me.Panel1.TabIndex = 57
        '
        'Re_Sale_Inv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1184, 488)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Re_Sale_Inv"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Re_Sale_Inv"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgvSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Inv_Type As System.Windows.Forms.ComboBox
    Friend WithEvents Re_Sale_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents SalesMan As System.Windows.Forms.TextBox
    Friend WithEvents Sale_ID As System.Windows.Forms.TextBox
    Friend WithEvents Re_Sale_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Sale_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Onhim As System.Windows.Forms.TextBox
    Friend WithEvents CusPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ToHim As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CusName As System.Windows.Forms.TextBox
    Friend WithEvents Cus_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
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
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Prd_Code As System.Windows.Forms.TextBox
    Friend WithEvents BtnRemove As System.Windows.Forms.Button
    Friend WithEvents Prd_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents dgvSale As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
End Class
