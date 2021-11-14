<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Product
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Cmb_Unit = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmb_Cat = New System.Windows.Forms.ComboBox()
        Me.Prd_Name = New System.Windows.Forms.TextBox()
        Me.Prd_Code = New System.Windows.Forms.TextBox()
        Me.Prd_ID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Btnsave = New System.Windows.Forms.Button()
        Me.Prd_Pic = New System.Windows.Forms.PictureBox()
        Me.PrdLimit = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Prd_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 23)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "صورة المنتج"
        '
        'Cmb_Unit
        '
        Me.Cmb_Unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Unit.FormattingEnabled = True
        Me.Cmb_Unit.Location = New System.Drawing.Point(259, 250)
        Me.Cmb_Unit.Name = "Cmb_Unit"
        Me.Cmb_Unit.Size = New System.Drawing.Size(308, 31)
        Me.Cmb_Unit.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(260, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "تعديل بيانات المنتج"
        '
        'Cmb_Cat
        '
        Me.Cmb_Cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Cat.FormattingEnabled = True
        Me.Cmb_Cat.Location = New System.Drawing.Point(259, 203)
        Me.Cmb_Cat.Name = "Cmb_Cat"
        Me.Cmb_Cat.Size = New System.Drawing.Size(308, 31)
        Me.Cmb_Cat.TabIndex = 22
        '
        'Prd_Name
        '
        Me.Prd_Name.Location = New System.Drawing.Point(219, 157)
        Me.Prd_Name.Name = "Prd_Name"
        Me.Prd_Name.Size = New System.Drawing.Size(348, 31)
        Me.Prd_Name.TabIndex = 20
        Me.Prd_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Prd_Code
        '
        Me.Prd_Code.Location = New System.Drawing.Point(219, 111)
        Me.Prd_Code.Name = "Prd_Code"
        Me.Prd_Code.Size = New System.Drawing.Size(348, 31)
        Me.Prd_Code.TabIndex = 18
        Me.Prd_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Prd_ID
        '
        Me.Prd_ID.Location = New System.Drawing.Point(219, 67)
        Me.Prd_ID.Name = "Prd_ID"
        Me.Prd_ID.ReadOnly = True
        Me.Prd_ID.Size = New System.Drawing.Size(348, 31)
        Me.Prd_ID.TabIndex = 19
        Me.Prd_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(570, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 23)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "صنف المنتج :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(570, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "وحدة المنتج :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(570, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 23)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "اسم المنتج :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(570, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 23)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "باركود المنتج :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(570, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "رقم المنتج :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 414)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(679, 54)
        Me.Panel2.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(679, 54)
        Me.Panel1.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Sales_Managment_System.My.Resources.Resources.x_mark_3_32
        Me.PictureBox1.Location = New System.Drawing.Point(636, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Image = Global.Sales_Managment_System.My.Resources.Resources.plus_6_24
        Me.Button2.Location = New System.Drawing.Point(219, 250)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 31)
        Me.Button2.TabIndex = 28
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Image = Global.Sales_Managment_System.My.Resources.Resources.plus_6_24
        Me.Button1.Location = New System.Drawing.Point(220, 203)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 31)
        Me.Button1.TabIndex = 29
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnBrowse
        '
        Me.BtnBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Navy
        Me.BtnBrowse.FlatAppearance.BorderSize = 3
        Me.BtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBrowse.Image = Global.Sales_Managment_System.My.Resources.Resources.open_in_browser_32
        Me.BtnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBrowse.Location = New System.Drawing.Point(8, 335)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(182, 48)
        Me.BtnBrowse.TabIndex = 27
        Me.BtnBrowse.Text = "اختيار الصورة"
        Me.BtnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBrowse.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BtnClose.FlatAppearance.BorderSize = 3
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Image = Global.Sales_Managment_System.My.Resources.Resources.exit_2_32_blue
        Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnClose.Location = New System.Drawing.Point(259, 335)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(152, 48)
        Me.BtnClose.TabIndex = 26
        Me.BtnClose.Text = "اغلاق الشاشة"
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Btnsave
        '
        Me.Btnsave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btnsave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Btnsave.FlatAppearance.BorderSize = 3
        Me.Btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnsave.Image = Global.Sales_Managment_System.My.Resources.Resources.save_32_blue
        Me.Btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnsave.Location = New System.Drawing.Point(459, 335)
        Me.Btnsave.Name = "Btnsave"
        Me.Btnsave.Size = New System.Drawing.Size(152, 48)
        Me.Btnsave.TabIndex = 25
        Me.Btnsave.Text = "حفظ البيانات"
        Me.Btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnsave.UseVisualStyleBackColor = True
        '
        'Prd_Pic
        '
        Me.Prd_Pic.BackColor = System.Drawing.Color.Silver
        Me.Prd_Pic.Image = Global.Sales_Managment_System.My.Resources.Resources.pic
        Me.Prd_Pic.Location = New System.Drawing.Point(8, 94)
        Me.Prd_Pic.Name = "Prd_Pic"
        Me.Prd_Pic.Size = New System.Drawing.Size(182, 187)
        Me.Prd_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Prd_Pic.TabIndex = 23
        Me.Prd_Pic.TabStop = False
        '
        'PrdLimit
        '
        Me.PrdLimit.Location = New System.Drawing.Point(220, 298)
        Me.PrdLimit.Name = "PrdLimit"
        Me.PrdLimit.Size = New System.Drawing.Size(348, 31)
        Me.PrdLimit.TabIndex = 31
        Me.PrdLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(571, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 23)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "حد الطلب :"
        '
        'Edit_Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 468)
        Me.ControlBox = False
        Me.Controls.Add(Me.PrdLimit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.Btnsave)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Prd_Pic)
        Me.Controls.Add(Me.Cmb_Unit)
        Me.Controls.Add(Me.Cmb_Cat)
        Me.Controls.Add(Me.Prd_Name)
        Me.Controls.Add(Me.Prd_Code)
        Me.Controls.Add(Me.Prd_ID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Edit_Product"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Prd_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnBrowse As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents Btnsave As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Prd_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Cmb_Unit As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cmb_Cat As System.Windows.Forms.ComboBox
    Friend WithEvents Prd_Name As System.Windows.Forms.TextBox
    Friend WithEvents Prd_Code As System.Windows.Forms.TextBox
    Friend WithEvents Prd_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PrdLimit As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
