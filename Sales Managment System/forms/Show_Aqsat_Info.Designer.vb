<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Show_Aqsat_Info
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
        Me.Aqsat_Sale_ID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FinalTotal = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Qast_Amount = New System.Windows.Forms.TextBox()
        Me.Aqsat_Unpaid = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Money_Paid = New System.Windows.Forms.TextBox()
        Me.Aqsat_No = New System.Windows.Forms.TextBox()
        Me.Money_Unpaid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Aqsat_Paid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Aqsat_Sale_ID
        '
        Me.Aqsat_Sale_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Aqsat_Sale_ID.BackColor = System.Drawing.Color.White
        Me.Aqsat_Sale_ID.Location = New System.Drawing.Point(166, 22)
        Me.Aqsat_Sale_ID.Margin = New System.Windows.Forms.Padding(4)
        Me.Aqsat_Sale_ID.Name = "Aqsat_Sale_ID"
        Me.Aqsat_Sale_ID.ReadOnly = True
        Me.Aqsat_Sale_ID.Size = New System.Drawing.Size(295, 27)
        Me.Aqsat_Sale_ID.TabIndex = 3
        Me.Aqsat_Sale_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "رقم الفاتورة :"
        '
        'FinalTotal
        '
        Me.FinalTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FinalTotal.BackColor = System.Drawing.Color.White
        Me.FinalTotal.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinalTotal.ForeColor = System.Drawing.Color.Black
        Me.FinalTotal.Location = New System.Drawing.Point(166, 56)
        Me.FinalTotal.Name = "FinalTotal"
        Me.FinalTotal.ReadOnly = True
        Me.FinalTotal.Size = New System.Drawing.Size(295, 30)
        Me.FinalTotal.TabIndex = 56
        Me.FinalTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(9, 67)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(149, 19)
        Me.Label19.TabIndex = 55
        Me.Label19.Text = "القيمة الاجمالية للفاتورة :"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(67, 226)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 19)
        Me.Label7.TabIndex = 358
        Me.Label7.Text = "قسط متبقي :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(67, 143)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 19)
        Me.Label11.TabIndex = 354
        Me.Label11.Text = "قيمة القسط :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(64, 262)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 19)
        Me.Label20.TabIndex = 348
        Me.Label20.Text = "المبلغ المدفوع :"
        '
        'Qast_Amount
        '
        Me.Qast_Amount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Qast_Amount.BackColor = System.Drawing.Color.White
        Me.Qast_Amount.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qast_Amount.Location = New System.Drawing.Point(166, 135)
        Me.Qast_Amount.Margin = New System.Windows.Forms.Padding(4)
        Me.Qast_Amount.Name = "Qast_Amount"
        Me.Qast_Amount.ReadOnly = True
        Me.Qast_Amount.Size = New System.Drawing.Size(295, 29)
        Me.Qast_Amount.TabIndex = 355
        Me.Qast_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Aqsat_Unpaid
        '
        Me.Aqsat_Unpaid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Aqsat_Unpaid.BackColor = System.Drawing.Color.White
        Me.Aqsat_Unpaid.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aqsat_Unpaid.Location = New System.Drawing.Point(166, 212)
        Me.Aqsat_Unpaid.Margin = New System.Windows.Forms.Padding(4)
        Me.Aqsat_Unpaid.Name = "Aqsat_Unpaid"
        Me.Aqsat_Unpaid.ReadOnly = True
        Me.Aqsat_Unpaid.Size = New System.Drawing.Size(295, 29)
        Me.Aqsat_Unpaid.TabIndex = 359
        Me.Aqsat_Unpaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(67, 103)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 19)
        Me.Label12.TabIndex = 352
        Me.Label12.Text = "عدد الاقساط :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Money_Paid
        '
        Me.Money_Paid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Money_Paid.BackColor = System.Drawing.Color.White
        Me.Money_Paid.ForeColor = System.Drawing.Color.Black
        Me.Money_Paid.Location = New System.Drawing.Point(166, 254)
        Me.Money_Paid.Name = "Money_Paid"
        Me.Money_Paid.ReadOnly = True
        Me.Money_Paid.Size = New System.Drawing.Size(297, 27)
        Me.Money_Paid.TabIndex = 351
        Me.Money_Paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Aqsat_No
        '
        Me.Aqsat_No.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Aqsat_No.BackColor = System.Drawing.Color.White
        Me.Aqsat_No.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aqsat_No.Location = New System.Drawing.Point(166, 98)
        Me.Aqsat_No.Margin = New System.Windows.Forms.Padding(4)
        Me.Aqsat_No.Name = "Aqsat_No"
        Me.Aqsat_No.ReadOnly = True
        Me.Aqsat_No.Size = New System.Drawing.Size(295, 29)
        Me.Aqsat_No.TabIndex = 353
        Me.Aqsat_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Money_Unpaid
        '
        Me.Money_Unpaid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Money_Unpaid.BackColor = System.Drawing.Color.White
        Me.Money_Unpaid.ForeColor = System.Drawing.Color.Black
        Me.Money_Unpaid.Location = New System.Drawing.Point(166, 296)
        Me.Money_Unpaid.Name = "Money_Unpaid"
        Me.Money_Unpaid.ReadOnly = True
        Me.Money_Unpaid.Size = New System.Drawing.Size(295, 27)
        Me.Money_Unpaid.TabIndex = 350
        Me.Money_Unpaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(67, 185)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 19)
        Me.Label6.TabIndex = 356
        Me.Label6.Text = "قسط مدفوع :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(68, 304)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(90, 19)
        Me.Label21.TabIndex = 349
        Me.Label21.Text = "المبلغ المتبقي :"
        '
        'Aqsat_Paid
        '
        Me.Aqsat_Paid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Aqsat_Paid.BackColor = System.Drawing.Color.White
        Me.Aqsat_Paid.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aqsat_Paid.Location = New System.Drawing.Point(166, 175)
        Me.Aqsat_Paid.Margin = New System.Windows.Forms.Padding(4)
        Me.Aqsat_Paid.Name = "Aqsat_Paid"
        Me.Aqsat_Paid.ReadOnly = True
        Me.Aqsat_Paid.Size = New System.Drawing.Size(295, 29)
        Me.Aqsat_Paid.TabIndex = 357
        Me.Aqsat_Paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Show_Aqsat_Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 345)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Qast_Amount)
        Me.Controls.Add(Me.Aqsat_Unpaid)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Money_Paid)
        Me.Controls.Add(Me.Aqsat_No)
        Me.Controls.Add(Me.Money_Unpaid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Aqsat_Paid)
        Me.Controls.Add(Me.FinalTotal)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Aqsat_Sale_ID)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Show_Aqsat_Info"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تفاصيل فاتورة الاقساط"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Aqsat_Sale_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FinalTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Qast_Amount As System.Windows.Forms.TextBox
    Friend WithEvents Aqsat_Unpaid As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Money_Paid As System.Windows.Forms.TextBox
    Friend WithEvents Aqsat_No As System.Windows.Forms.TextBox
    Friend WithEvents Money_Unpaid As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Aqsat_Paid As System.Windows.Forms.TextBox
End Class
