<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Customer
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cus_ID = New System.Windows.Forms.TextBox()
        Me.CusName = New System.Windows.Forms.TextBox()
        Me.CusPhone = New System.Windows.Forms.TextBox()
        Me.CusAddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToHim = New System.Windows.Forms.TextBox()
        Me.Onhim = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BStartCapture = New System.Windows.Forms.Button()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.CusPic = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.CusPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(693, 64)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(261, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "اضافة عميـــل جديــــد"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Sales_Managment_System.My.Resources.Resources.x_mark_3_32
        Me.PictureBox1.Location = New System.Drawing.Point(650, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 423)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(693, 52)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(594, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "رقم العميل :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(594, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "اسم العميل :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(594, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "رقم الهاتف :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(594, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "العنوان :"
        '
        'Cus_ID
        '
        Me.Cus_ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Cus_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Cus_ID.Location = New System.Drawing.Point(206, 86)
        Me.Cus_ID.Name = "Cus_ID"
        Me.Cus_ID.ReadOnly = True
        Me.Cus_ID.Size = New System.Drawing.Size(387, 31)
        Me.Cus_ID.TabIndex = 3
        Me.Cus_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CusName
        '
        Me.CusName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CusName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CusName.Location = New System.Drawing.Point(206, 127)
        Me.CusName.Name = "CusName"
        Me.CusName.Size = New System.Drawing.Size(387, 31)
        Me.CusName.TabIndex = 3
        Me.CusName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CusPhone
        '
        Me.CusPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CusPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CusPhone.Location = New System.Drawing.Point(206, 168)
        Me.CusPhone.Name = "CusPhone"
        Me.CusPhone.Size = New System.Drawing.Size(387, 31)
        Me.CusPhone.TabIndex = 3
        Me.CusPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CusAddress
        '
        Me.CusAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CusAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CusAddress.Location = New System.Drawing.Point(206, 211)
        Me.CusAddress.Multiline = True
        Me.CusAddress.Name = "CusAddress"
        Me.CusAddress.Size = New System.Drawing.Size(387, 83)
        Me.CusAddress.TabIndex = 3
        Me.CusAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(338, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "دائــن"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(129, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 23)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "مديــن"
        '
        'ToHim
        '
        Me.ToHim.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ToHim.ForeColor = System.Drawing.Color.White
        Me.ToHim.Location = New System.Drawing.Point(217, 9)
        Me.ToHim.Name = "ToHim"
        Me.ToHim.ReadOnly = True
        Me.ToHim.Size = New System.Drawing.Size(115, 31)
        Me.ToHim.TabIndex = 13
        Me.ToHim.Text = "0.00"
        Me.ToHim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Onhim
        '
        Me.Onhim.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Onhim.ForeColor = System.Drawing.Color.White
        Me.Onhim.Location = New System.Drawing.Point(8, 9)
        Me.Onhim.Name = "Onhim"
        Me.Onhim.ReadOnly = True
        Me.Onhim.Size = New System.Drawing.Size(115, 31)
        Me.Onhim.TabIndex = 14
        Me.Onhim.Text = "0.00"
        Me.Onhim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Onhim)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.ToHim)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(206, 302)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(387, 48)
        Me.Panel3.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.Sales_Managment_System.My.Resources.Resources.exit_2_321
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(206, 361)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 48)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "اغلاق الشاشــــة"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnNew
        '
        Me.BtnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnNew.FlatAppearance.BorderSize = 3
        Me.BtnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNew.Image = Global.Sales_Managment_System.My.Resources.Resources.save_321
        Me.BtnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNew.Location = New System.Drawing.Point(407, 361)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(186, 48)
        Me.BtnNew.TabIndex = 16
        Me.BtnNew.Text = "حفظ بيانات العميل"
        Me.BtnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNew.UseVisualStyleBackColor = False
        '
        'BStartCapture
        '
        Me.BStartCapture.BackColor = System.Drawing.Color.White
        Me.BStartCapture.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BStartCapture.FlatAppearance.BorderSize = 3
        Me.BStartCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BStartCapture.Image = Global.Sales_Managment_System.My.Resources.Resources.webcam_2_32
        Me.BStartCapture.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BStartCapture.Location = New System.Drawing.Point(11, 361)
        Me.BStartCapture.Name = "BStartCapture"
        Me.BStartCapture.Size = New System.Drawing.Size(182, 48)
        Me.BStartCapture.TabIndex = 11
        Me.BStartCapture.Text = "استخدام الكاميرا"
        Me.BStartCapture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BStartCapture.UseVisualStyleBackColor = False
        '
        'BtnBrowse
        '
        Me.BtnBrowse.BackColor = System.Drawing.Color.White
        Me.BtnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnBrowse.FlatAppearance.BorderSize = 3
        Me.BtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBrowse.Image = Global.Sales_Managment_System.My.Resources.Resources.open_in_browser_321
        Me.BtnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBrowse.Location = New System.Drawing.Point(12, 302)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(182, 48)
        Me.BtnBrowse.TabIndex = 11
        Me.BtnBrowse.Text = "اختيار الصورة"
        Me.BtnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBrowse.UseVisualStyleBackColor = False
        '
        'CusPic
        '
        Me.CusPic.BackColor = System.Drawing.Color.Silver
        Me.CusPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CusPic.Image = Global.Sales_Managment_System.My.Resources.Resources.flat_seo_30_512
        Me.CusPic.Location = New System.Drawing.Point(11, 86)
        Me.CusPic.Name = "CusPic"
        Me.CusPic.Size = New System.Drawing.Size(182, 210)
        Me.CusPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CusPic.TabIndex = 10
        Me.CusPic.TabStop = False
        '
        'Add_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 475)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.BStartCapture)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Controls.Add(Me.CusPic)
        Me.Controls.Add(Me.CusAddress)
        Me.Controls.Add(Me.CusPhone)
        Me.Controls.Add(Me.CusName)
        Me.Controls.Add(Me.Cus_ID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Add_Customer"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.CusPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cus_ID As System.Windows.Forms.TextBox
    Friend WithEvents CusName As System.Windows.Forms.TextBox
    Friend WithEvents CusPhone As System.Windows.Forms.TextBox
    Friend WithEvents CusAddress As System.Windows.Forms.TextBox
    Friend WithEvents BtnBrowse As System.Windows.Forms.Button
    Friend WithEvents CusPic As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ToHim As System.Windows.Forms.TextBox
    Friend WithEvents Onhim As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BStartCapture As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
