<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Paid_Qast
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
        Me.Sanad_ID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Aqsat_Sale_ID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Qast_ID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Money_Paid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PaidDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Emp_Name = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "رقم الوصل :"
        '
        'Sanad_ID
        '
        Me.Sanad_ID.Location = New System.Drawing.Point(108, 23)
        Me.Sanad_ID.Name = "Sanad_ID"
        Me.Sanad_ID.Size = New System.Drawing.Size(226, 27)
        Me.Sanad_ID.TabIndex = 1
        Me.Sanad_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "رقم الفاتورة :"
        '
        'Aqsat_Sale_ID
        '
        Me.Aqsat_Sale_ID.Location = New System.Drawing.Point(108, 59)
        Me.Aqsat_Sale_ID.Name = "Aqsat_Sale_ID"
        Me.Aqsat_Sale_ID.Size = New System.Drawing.Size(226, 27)
        Me.Aqsat_Sale_ID.TabIndex = 1
        Me.Aqsat_Sale_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "رقم القسط :"
        '
        'Qast_ID
        '
        Me.Qast_ID.Location = New System.Drawing.Point(108, 97)
        Me.Qast_ID.Name = "Qast_ID"
        Me.Qast_ID.Size = New System.Drawing.Size(226, 27)
        Me.Qast_ID.TabIndex = 1
        Me.Qast_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "المبلغ المدفوع :"
        '
        'Money_Paid
        '
        Me.Money_Paid.Location = New System.Drawing.Point(108, 134)
        Me.Money_Paid.Name = "Money_Paid"
        Me.Money_Paid.Size = New System.Drawing.Size(226, 27)
        Me.Money_Paid.TabIndex = 1
        Me.Money_Paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "تاريخ الدفع :"
        '
        'PaidDate
        '
        Me.PaidDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.PaidDate.Location = New System.Drawing.Point(108, 170)
        Me.PaidDate.Name = "PaidDate"
        Me.PaidDate.Size = New System.Drawing.Size(226, 27)
        Me.PaidDate.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "اسم المستلم :"
        '
        'Emp_Name
        '
        Me.Emp_Name.Location = New System.Drawing.Point(108, 208)
        Me.Emp_Name.Name = "Emp_Name"
        Me.Emp_Name.Size = New System.Drawing.Size(226, 27)
        Me.Emp_Name.TabIndex = 1
        Me.Emp_Name.Text = "admin"
        Me.Emp_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 33)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "حفظ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(130, 264)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 33)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "طباعة"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(255, 264)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 33)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "خروج"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Frm_Paid_Qast
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 318)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PaidDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Emp_Name)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Money_Paid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Qast_ID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Aqsat_Sale_ID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Sanad_ID)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Paid_Qast"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تسديد قسط"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Sanad_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Aqsat_Sale_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Qast_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Money_Paid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PaidDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Emp_Name As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
