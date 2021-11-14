<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Emp
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
        Me.JobID = New System.Windows.Forms.ComboBox()
        Me.DepartmentID = New System.Windows.Forms.ComboBox()
        Me.BirthDate = New System.Windows.Forms.DateTimePicker()
        Me.StartWorkDate = New System.Windows.Forms.DateTimePicker()
        Me.Notes = New System.Windows.Forms.TextBox()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Mobile = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Salary = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmployeeName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmployeeID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.Emp_Pic = New System.Windows.Forms.PictureBox()
        CType(Me.Emp_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'JobID
        '
        Me.JobID.FormattingEnabled = True
        Me.JobID.Location = New System.Drawing.Point(112, 169)
        Me.JobID.Name = "JobID"
        Me.JobID.Size = New System.Drawing.Size(323, 27)
        Me.JobID.TabIndex = 67
        '
        'DepartmentID
        '
        Me.DepartmentID.FormattingEnabled = True
        Me.DepartmentID.Location = New System.Drawing.Point(112, 130)
        Me.DepartmentID.Name = "DepartmentID"
        Me.DepartmentID.Size = New System.Drawing.Size(323, 27)
        Me.DepartmentID.TabIndex = 68
        '
        'BirthDate
        '
        Me.BirthDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BirthDate.Location = New System.Drawing.Point(113, 89)
        Me.BirthDate.Name = "BirthDate"
        Me.BirthDate.Size = New System.Drawing.Size(322, 27)
        Me.BirthDate.TabIndex = 61
        '
        'StartWorkDate
        '
        Me.StartWorkDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.StartWorkDate.Location = New System.Drawing.Point(558, 8)
        Me.StartWorkDate.Name = "StartWorkDate"
        Me.StartWorkDate.Size = New System.Drawing.Size(283, 27)
        Me.StartWorkDate.TabIndex = 62
        '
        'Notes
        '
        Me.Notes.Location = New System.Drawing.Point(558, 56)
        Me.Notes.Multiline = True
        Me.Notes.Name = "Notes"
        Me.Notes.Size = New System.Drawing.Size(283, 67)
        Me.Notes.TabIndex = 58
        Me.Notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(113, 301)
        Me.Address.Multiline = True
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(322, 97)
        Me.Address.TabIndex = 59
        Me.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(45, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 19)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "العنوان :"
        '
        'Mobile
        '
        Me.Mobile.Location = New System.Drawing.Point(113, 257)
        Me.Mobile.Name = "Mobile"
        Me.Mobile.Size = New System.Drawing.Size(322, 27)
        Me.Mobile.TabIndex = 60
        Me.Mobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 19)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "رقم الهاتف :"
        '
        'Salary
        '
        Me.Salary.Location = New System.Drawing.Point(113, 212)
        Me.Salary.Name = "Salary"
        Me.Salary.Size = New System.Drawing.Size(322, 27)
        Me.Salary.TabIndex = 56
        Me.Salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 19)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "الراتب :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 19)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "الوظيفة :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 19)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "القسم :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 19)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "تاريخ الميلاد :"
        '
        'EmployeeName
        '
        Me.EmployeeName.Location = New System.Drawing.Point(113, 52)
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.Size = New System.Drawing.Size(322, 27)
        Me.EmployeeName.TabIndex = 55
        Me.EmployeeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(484, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 19)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "ملاحظات :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "اسم الموظف :"
        '
        'EmployeeID
        '
        Me.EmployeeID.Location = New System.Drawing.Point(113, 10)
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.Size = New System.Drawing.Size(322, 27)
        Me.EmployeeID.TabIndex = 57
        Me.EmployeeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(441, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 19)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "تاريخ بداية العمل :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 19)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "رقم الموظف :"
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
        Me.Button1.Location = New System.Drawing.Point(650, 350)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 48)
        Me.Button1.TabIndex = 66
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
        Me.BtnNew.Location = New System.Drawing.Point(454, 350)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(186, 48)
        Me.BtnNew.TabIndex = 65
        Me.BtnNew.Text = "حفظ بيانات الموظف"
        Me.BtnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNew.UseVisualStyleBackColor = False
        '
        'BtnBrowse
        '
        Me.BtnBrowse.BackColor = System.Drawing.Color.White
        Me.BtnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnBrowse.FlatAppearance.BorderSize = 3
        Me.BtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBrowse.Image = Global.Sales_Managment_System.My.Resources.Resources.open_in_browser_321
        Me.BtnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnBrowse.Location = New System.Drawing.Point(579, 295)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(151, 40)
        Me.BtnBrowse.TabIndex = 64
        Me.BtnBrowse.Text = "اختيار الصورة"
        Me.BtnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBrowse.UseVisualStyleBackColor = False
        '
        'Emp_Pic
        '
        Me.Emp_Pic.BackColor = System.Drawing.Color.Silver
        Me.Emp_Pic.Image = Global.Sales_Managment_System.My.Resources.Resources.flat_seo_30_512
        Me.Emp_Pic.Location = New System.Drawing.Point(580, 133)
        Me.Emp_Pic.Name = "Emp_Pic"
        Me.Emp_Pic.Size = New System.Drawing.Size(150, 156)
        Me.Emp_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Emp_Pic.TabIndex = 63
        Me.Emp_Pic.TabStop = False
        '
        'Edit_Emp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(857, 406)
        Me.Controls.Add(Me.JobID)
        Me.Controls.Add(Me.DepartmentID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Controls.Add(Me.Emp_Pic)
        Me.Controls.Add(Me.BirthDate)
        Me.Controls.Add(Me.StartWorkDate)
        Me.Controls.Add(Me.Notes)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Mobile)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Salary)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EmployeeName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EmployeeID)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Edit_Emp"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تعديل بيانات الموظف"
        CType(Me.Emp_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JobID As System.Windows.Forms.ComboBox
    Friend WithEvents DepartmentID As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnBrowse As System.Windows.Forms.Button
    Friend WithEvents Emp_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents BirthDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents StartWorkDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Notes As System.Windows.Forms.TextBox
    Friend WithEvents Address As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Mobile As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Salary As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents EmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
