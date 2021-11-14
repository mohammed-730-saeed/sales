<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Paid_Sand
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Paid_Sand))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.Paid_date = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SalesMan = New System.Windows.Forms.TextBox()
        Me.PaidTotal = New System.Windows.Forms.TextBox()
        Me.Paid_Sand_ID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Onhim = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToHim = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ImpPhone = New System.Windows.Forms.TextBox()
        Me.ImpName = New System.Windows.Forms.TextBox()
        Me.Imp_ID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnPrint)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.BtnNew)
        Me.GroupBox2.Controls.Add(Me.Paid_date)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.SalesMan)
        Me.GroupBox2.Controls.Add(Me.PaidTotal)
        Me.GroupBox2.Controls.Add(Me.Paid_Sand_ID)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 172)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(587, 212)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "بيانات سند الدفع"
        '
        'BtnPrint
        '
        Me.BtnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPrint.BackColor = System.Drawing.Color.White
        Me.BtnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnPrint.FlatAppearance.BorderSize = 3
        Me.BtnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrint.ForeColor = System.Drawing.Color.Black
        Me.BtnPrint.Image = Global.Sales_Managment_System.My.Resources.Resources.printer_321
        Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPrint.Location = New System.Drawing.Point(16, 83)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(167, 48)
        Me.BtnPrint.TabIndex = 19
        Me.BtnPrint.Text = "طباعة السند"
        Me.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Sales_Managment_System.My.Resources.Resources.exit_2_321
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(16, 139)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 48)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "اغلاق الشاشــــة"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnNew
        '
        Me.BtnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNew.BackColor = System.Drawing.Color.White
        Me.BtnNew.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnNew.FlatAppearance.BorderSize = 3
        Me.BtnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNew.Image = Global.Sales_Managment_System.My.Resources.Resources.save_321
        Me.BtnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNew.Location = New System.Drawing.Point(16, 28)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(167, 48)
        Me.BtnNew.TabIndex = 17
        Me.BtnNew.Text = "حفظ البيانات"
        Me.BtnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNew.UseVisualStyleBackColor = False
        '
        'Paid_date
        '
        Me.Paid_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Paid_date.Location = New System.Drawing.Point(208, 77)
        Me.Paid_date.Name = "Paid_date"
        Me.Paid_date.Size = New System.Drawing.Size(258, 27)
        Me.Paid_date.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(474, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 19)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "اسم الموظف :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(474, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 19)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "قيمة الدفعة :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(474, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "تاريخ السند :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(474, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "رقم سند الدفع :"
        '
        'SalesMan
        '
        Me.SalesMan.BackColor = System.Drawing.Color.White
        Me.SalesMan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesMan.Location = New System.Drawing.Point(208, 152)
        Me.SalesMan.Name = "SalesMan"
        Me.SalesMan.ReadOnly = True
        Me.SalesMan.Size = New System.Drawing.Size(258, 27)
        Me.SalesMan.TabIndex = 9
        Me.SalesMan.Text = "admin"
        Me.SalesMan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PaidTotal
        '
        Me.PaidTotal.BackColor = System.Drawing.Color.White
        Me.PaidTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PaidTotal.Location = New System.Drawing.Point(208, 114)
        Me.PaidTotal.Name = "PaidTotal"
        Me.PaidTotal.Size = New System.Drawing.Size(258, 27)
        Me.PaidTotal.TabIndex = 9
        Me.PaidTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Paid_Sand_ID
        '
        Me.Paid_Sand_ID.BackColor = System.Drawing.Color.White
        Me.Paid_Sand_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Paid_Sand_ID.Location = New System.Drawing.Point(208, 39)
        Me.Paid_Sand_ID.Name = "Paid_Sand_ID"
        Me.Paid_Sand_ID.ReadOnly = True
        Me.Paid_Sand_ID.Size = New System.Drawing.Size(258, 27)
        Me.Paid_Sand_ID.TabIndex = 9
        Me.Paid_Sand_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.ImpPhone)
        Me.GroupBox1.Controls.Add(Me.ImpName)
        Me.GroupBox1.Controls.Add(Me.Imp_ID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(591, 153)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بيانات المورد"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Onhim)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.ToHim)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(23, 26)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(182, 109)
        Me.Panel3.TabIndex = 53
        '
        'Onhim
        '
        Me.Onhim.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Onhim.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Onhim.ForeColor = System.Drawing.Color.White
        Me.Onhim.Location = New System.Drawing.Point(14, 58)
        Me.Onhim.Name = "Onhim"
        Me.Onhim.ReadOnly = True
        Me.Onhim.Size = New System.Drawing.Size(115, 30)
        Me.Onhim.TabIndex = 14
        Me.Onhim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(135, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "دائــن"
        '
        'ToHim
        '
        Me.ToHim.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToHim.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToHim.ForeColor = System.Drawing.Color.White
        Me.ToHim.Location = New System.Drawing.Point(14, 15)
        Me.ToHim.Name = "ToHim"
        Me.ToHim.ReadOnly = True
        Me.ToHim.Size = New System.Drawing.Size(115, 30)
        Me.ToHim.TabIndex = 13
        Me.ToHim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(135, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 19)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "مديــن"
        '
        'ImpPhone
        '
        Me.ImpPhone.BackColor = System.Drawing.Color.White
        Me.ImpPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImpPhone.Location = New System.Drawing.Point(211, 108)
        Me.ImpPhone.Name = "ImpPhone"
        Me.ImpPhone.Size = New System.Drawing.Size(291, 27)
        Me.ImpPhone.TabIndex = 52
        Me.ImpPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ImpName
        '
        Me.ImpName.BackColor = System.Drawing.Color.White
        Me.ImpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImpName.Location = New System.Drawing.Point(211, 67)
        Me.ImpName.Name = "ImpName"
        Me.ImpName.Size = New System.Drawing.Size(291, 27)
        Me.ImpName.TabIndex = 50
        Me.ImpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Imp_ID
        '
        Me.Imp_ID.BackColor = System.Drawing.Color.White
        Me.Imp_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Imp_ID.Location = New System.Drawing.Point(294, 26)
        Me.Imp_ID.Name = "Imp_ID"
        Me.Imp_ID.Size = New System.Drawing.Size(208, 27)
        Me.Imp_ID.TabIndex = 51
        Me.Imp_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(503, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 19)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "رقم الهاتف :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(503, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "اسم المورد :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(503, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 19)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "رقم المورد :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(213, 26)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 29)
        Me.Button2.TabIndex = 54
        Me.Button2.Text = "اختيار مورد"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Frm_Paid_Sand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(620, 396)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Paid_Sand"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "سند تسليم دفعة نقدية"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents Paid_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SalesMan As System.Windows.Forms.TextBox
    Friend WithEvents PaidTotal As System.Windows.Forms.TextBox
    Friend WithEvents Paid_Sand_ID As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ImpPhone As System.Windows.Forms.TextBox
    Friend WithEvents ImpName As System.Windows.Forms.TextBox
    Friend WithEvents Imp_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Onhim As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToHim As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
