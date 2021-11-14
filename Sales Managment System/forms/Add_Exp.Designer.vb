<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Exp
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Exp_ID = New System.Windows.Forms.TextBox()
        Me.Exp_Value = New System.Windows.Forms.TextBox()
        Me.Exp_Des = New System.Windows.Forms.TextBox()
        Me.EmpName = New System.Windows.Forms.TextBox()
        Me.Exp_Date = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "رقم النفقة :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "تاريخ النفقة :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "قيمة النفقة :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "التفاصيل :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "اسم الموظف :"
        '
        'Exp_ID
        '
        Me.Exp_ID.Location = New System.Drawing.Point(110, 18)
        Me.Exp_ID.Name = "Exp_ID"
        Me.Exp_ID.ReadOnly = True
        Me.Exp_ID.Size = New System.Drawing.Size(322, 27)
        Me.Exp_ID.TabIndex = 1
        Me.Exp_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Exp_Value
        '
        Me.Exp_Value.Location = New System.Drawing.Point(110, 91)
        Me.Exp_Value.Name = "Exp_Value"
        Me.Exp_Value.Size = New System.Drawing.Size(322, 27)
        Me.Exp_Value.TabIndex = 1
        Me.Exp_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Exp_Des
        '
        Me.Exp_Des.Location = New System.Drawing.Point(110, 139)
        Me.Exp_Des.Multiline = True
        Me.Exp_Des.Name = "Exp_Des"
        Me.Exp_Des.Size = New System.Drawing.Size(322, 87)
        Me.Exp_Des.TabIndex = 1
        Me.Exp_Des.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmpName
        '
        Me.EmpName.Location = New System.Drawing.Point(110, 240)
        Me.EmpName.Name = "EmpName"
        Me.EmpName.ReadOnly = True
        Me.EmpName.Size = New System.Drawing.Size(322, 27)
        Me.EmpName.TabIndex = 1
        Me.EmpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Exp_Date
        '
        Me.Exp_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Exp_Date.Location = New System.Drawing.Point(110, 55)
        Me.Exp_Date.Name = "Exp_Date"
        Me.Exp_Date.Size = New System.Drawing.Size(322, 27)
        Me.Exp_Date.TabIndex = 2
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
        Me.Button1.Location = New System.Drawing.Point(290, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 48)
        Me.Button1.TabIndex = 20
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
        Me.BtnNew.Location = New System.Drawing.Point(110, 284)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(142, 48)
        Me.BtnNew.TabIndex = 19
        Me.BtnNew.Text = "حفظ البيانات"
        Me.BtnNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNew.UseVisualStyleBackColor = False
        '
        'Add_Exp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(461, 344)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.Exp_Date)
        Me.Controls.Add(Me.EmpName)
        Me.Controls.Add(Me.Exp_Des)
        Me.Controls.Add(Me.Exp_Value)
        Me.Controls.Add(Me.Exp_ID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Add_Exp"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اضافة نفقة جديدة"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Exp_ID As System.Windows.Forms.TextBox
    Friend WithEvents Exp_Value As System.Windows.Forms.TextBox
    Friend WithEvents Exp_Des As System.Windows.Forms.TextBox
    Friend WithEvents EmpName As System.Windows.Forms.TextBox
    Friend WithEvents Exp_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
End Class
