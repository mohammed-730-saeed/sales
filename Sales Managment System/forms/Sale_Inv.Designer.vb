﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sale_Inv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sale_Inv))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Inv_Type = New System.Windows.Forms.ComboBox()
        Me.Sale_Date = New System.Windows.Forms.DateTimePicker()
        Me.SalesMan = New System.Windows.Forms.TextBox()
        Me.Sale_ID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Onhim = New System.Windows.Forms.TextBox()
        Me.CusPhone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToHim = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CusName = New System.Windows.Forms.TextBox()
        Me.Cus_ID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
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
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Prd_Code = New System.Windows.Forms.TextBox()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.Prd_ID = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.UnPaid = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Paid = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(4, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 220)
        Me.GroupBox1.TabIndex = 0
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Onhim)
        Me.GroupBox2.Controls.Add(Me.CusPhone)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ToHim)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.CusName)
        Me.GroupBox2.Controls.Add(Me.Cus_ID)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(354, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(340, 215)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "بيانات العميل :"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(210, 27)
        Me.TextBox1.TabIndex = 52
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Teal
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(16, 50)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 29)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "اختيار عميل"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Onhim
        '
        Me.Onhim.BackColor = System.Drawing.Color.White
        Me.Onhim.ForeColor = System.Drawing.Color.Black
        Me.Onhim.Location = New System.Drawing.Point(16, 182)
        Me.Onhim.Name = "Onhim"
        Me.Onhim.Size = New System.Drawing.Size(210, 27)
        Me.Onhim.TabIndex = 14
        Me.Onhim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CusPhone
        '
        Me.CusPhone.BackColor = System.Drawing.Color.White
        Me.CusPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CusPhone.ForeColor = System.Drawing.Color.Black
        Me.CusPhone.Location = New System.Drawing.Point(16, 117)
        Me.CusPhone.Name = "CusPhone"
        Me.CusPhone.Size = New System.Drawing.Size(210, 27)
        Me.CusPhone.TabIndex = 20
        Me.CusPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(249, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "دائــن :"
        '
        'ToHim
        '
        Me.ToHim.BackColor = System.Drawing.Color.White
        Me.ToHim.ForeColor = System.Drawing.Color.Black
        Me.ToHim.Location = New System.Drawing.Point(16, 150)
        Me.ToHim.Name = "ToHim"
        Me.ToHim.Size = New System.Drawing.Size(210, 27)
        Me.ToHim.TabIndex = 13
        Me.ToHim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(249, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "مديــن :"
        '
        'CusName
        '
        Me.CusName.BackColor = System.Drawing.Color.White
        Me.CusName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CusName.ForeColor = System.Drawing.Color.Black
        Me.CusName.Location = New System.Drawing.Point(16, 84)
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
        Me.Cus_ID.Location = New System.Drawing.Point(108, 51)
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
        Me.Label5.Location = New System.Drawing.Point(249, 120)
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
        Me.Label8.Location = New System.Drawing.Point(249, 87)
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
        Me.Label9.Location = New System.Drawing.Point(249, 54)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 19)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "رقم العميل :"
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
        Me.Panel5.Location = New System.Drawing.Point(700, 12)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(479, 191)
        Me.Panel5.TabIndex = 6
        '
        'FinalTotal
        '
        Me.FinalTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FinalTotal.BackColor = System.Drawing.Color.Gray
        Me.FinalTotal.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinalTotal.ForeColor = System.Drawing.Color.Yellow
        Me.FinalTotal.Location = New System.Drawing.Point(89, 148)
        Me.FinalTotal.Name = "FinalTotal"
        Me.FinalTotal.ReadOnly = True
        Me.FinalTotal.Size = New System.Drawing.Size(143, 32)
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
        'Panel7
        '
        Me.Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.Prd_Code)
        Me.Panel7.Controls.Add(Me.BtnRemove)
        Me.Panel7.Controls.Add(Me.Prd_ID)
        Me.Panel7.Controls.Add(Me.Label24)
        Me.Panel7.Controls.Add(Me.Label23)
        Me.Panel7.Location = New System.Drawing.Point(6, 233)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(914, 47)
        Me.Panel7.TabIndex = 8
        '
        'Prd_Code
        '
        Me.Prd_Code.BackColor = System.Drawing.Color.White
        Me.Prd_Code.ForeColor = System.Drawing.Color.Black
        Me.Prd_Code.Location = New System.Drawing.Point(257, 11)
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
        Me.BtnRemove.Location = New System.Drawing.Point(6, 9)
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
        Me.Prd_ID.Location = New System.Drawing.Point(609, 11)
        Me.Prd_ID.Name = "Prd_ID"
        Me.Prd_ID.Size = New System.Drawing.Size(138, 27)
        Me.Prd_ID.TabIndex = 2
        Me.Prd_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(436, 14)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(164, 19)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "ادخال حسب باركود المنتج :"
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(753, 14)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(151, 19)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "ادخال حسب رقم المنتج :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.dgvSale)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 284)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(908, 287)
        Me.GroupBox3.TabIndex = 9
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
        Me.Button1.Location = New System.Drawing.Point(861, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 241)
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
        Me.dgvSale.Location = New System.Drawing.Point(12, 34)
        Me.dgvSale.Name = "dgvSale"
        Me.dgvSale.RowHeadersVisible = False
        Me.dgvSale.RowTemplate.Height = 30
        Me.dgvSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSale.Size = New System.Drawing.Size(843, 241)
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnClose)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.BtnSave)
        Me.GroupBox4.Controls.Add(Me.BtnNew)
        Me.GroupBox4.Location = New System.Drawing.Point(926, 302)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(253, 247)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ادارة المبيعات"
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnClose.FlatAppearance.BorderSize = 3
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.ForeColor = System.Drawing.Color.Black
        Me.BtnClose.Image = Global.Sales_Managment_System.My.Resources.Resources.exit_2_32_blue
        Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnClose.Location = New System.Drawing.Point(39, 172)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(177, 42)
        Me.BtnClose.TabIndex = 56
        Me.BtnClose.Text = "اغلاق الشاشة"
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.FlatAppearance.BorderSize = 3
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = Global.Sales_Managment_System.My.Resources.Resources.printer_32
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(39, 122)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(177, 44)
        Me.Button3.TabIndex = 55
        Me.Button3.Text = "طباعة الفاتورة"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
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
        Me.BtnSave.Location = New System.Drawing.Point(39, 74)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(177, 42)
        Me.BtnSave.TabIndex = 54
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
        Me.BtnNew.Location = New System.Drawing.Point(39, 26)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(177, 42)
        Me.BtnNew.TabIndex = 53
        Me.BtnNew.Text = "فاتورة بيع جديدة"
        Me.BtnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNew.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.UnPaid)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.Paid)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Location = New System.Drawing.Point(926, 209)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(253, 87)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "بيانات الدفع"
        '
        'UnPaid
        '
        Me.UnPaid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UnPaid.BackColor = System.Drawing.Color.Gray
        Me.UnPaid.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnPaid.ForeColor = System.Drawing.Color.Yellow
        Me.UnPaid.Location = New System.Drawing.Point(32, 50)
        Me.UnPaid.Name = "UnPaid"
        Me.UnPaid.ReadOnly = True
        Me.UnPaid.Size = New System.Drawing.Size(94, 32)
        Me.UnPaid.TabIndex = 53
        Me.UnPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(126, 57)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(90, 19)
        Me.Label21.TabIndex = 52
        Me.Label21.Text = "المبلغ المتبقي :"
        '
        'Paid
        '
        Me.Paid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Paid.BackColor = System.Drawing.Color.Gray
        Me.Paid.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Paid.ForeColor = System.Drawing.Color.Yellow
        Me.Paid.Location = New System.Drawing.Point(32, 15)
        Me.Paid.Name = "Paid"
        Me.Paid.Size = New System.Drawing.Size(94, 32)
        Me.Paid.TabIndex = 54
        Me.Paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(126, 23)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 19)
        Me.Label20.TabIndex = 51
        Me.Label20.Text = "المبلغ المدفوع :"
        '
        'Sale_Inv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1184, 576)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Sale_Inv"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اضافة فاتورة مبيعات جديدة"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Sale_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents SalesMan As System.Windows.Forms.TextBox
    Friend WithEvents Sale_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Inv_Type As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Onhim As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToHim As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CusPhone As System.Windows.Forms.TextBox
    Friend WithEvents CusName As System.Windows.Forms.TextBox
    Friend WithEvents Cus_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
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
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Prd_Code As System.Windows.Forms.TextBox
    Friend WithEvents BtnRemove As System.Windows.Forms.Button
    Friend WithEvents Prd_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSale As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents UnPaid As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Paid As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As TextBox
End Class
