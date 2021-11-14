<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bank_In
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
        Me.label3 = New System.Windows.Forms.Label()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.Reason = New System.Windows.Forms.TextBox()
        Me.EmpName = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.Date_IN = New System.Windows.Forms.DateTimePicker()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Money = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Black
        Me.label3.Location = New System.Drawing.Point(12, 25)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(157, 23)
        Me.label3.TabIndex = 25
        Me.label3.Text = "رصيد البنك الحالى هو:"
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney.ForeColor = System.Drawing.Color.Blue
        Me.lblMoney.Location = New System.Drawing.Point(210, 25)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(25, 23)
        Me.lblMoney.TabIndex = 28
        Me.lblMoney.Text = "..."
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.ForeColor = System.Drawing.Color.Black
        Me.label7.Location = New System.Drawing.Point(30, 228)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(83, 19)
        Me.label7.TabIndex = 42
        Me.label7.Text = "سبب الايداع:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.ForeColor = System.Drawing.Color.Black
        Me.label6.Location = New System.Drawing.Point(37, 184)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(76, 19)
        Me.label6.TabIndex = 41
        Me.label6.Text = "اسم المودع:"
        '
        'Reason
        '
        Me.Reason.Location = New System.Drawing.Point(119, 225)
        Me.Reason.Multiline = True
        Me.Reason.Name = "Reason"
        Me.Reason.Size = New System.Drawing.Size(230, 32)
        Me.Reason.TabIndex = 40
        Me.Reason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmpName
        '
        Me.EmpName.Location = New System.Drawing.Point(119, 180)
        Me.EmpName.Name = "EmpName"
        Me.EmpName.Size = New System.Drawing.Size(230, 27)
        Me.EmpName.TabIndex = 39
        Me.EmpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.ForeColor = System.Drawing.Color.Black
        Me.label4.Location = New System.Drawing.Point(29, 134)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(84, 19)
        Me.label4.TabIndex = 38
        Me.label4.Text = "تاريخ الايداع:"
        '
        'Date_IN
        '
        Me.Date_IN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_IN.Location = New System.Drawing.Point(119, 128)
        Me.Date_IN.Name = "Date_IN"
        Me.Date_IN.Size = New System.Drawing.Size(230, 27)
        Me.Date_IN.TabIndex = 37
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.ForeColor = System.Drawing.Color.Black
        Me.label2.Location = New System.Drawing.Point(25, 76)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(88, 19)
        Me.label2.TabIndex = 36
        Me.label2.Text = "المبلغ المودع :"
        '
        'Money
        '
        Me.Money.Location = New System.Drawing.Point(119, 73)
        Me.Money.Name = "Money"
        Me.Money.Size = New System.Drawing.Size(230, 27)
        Me.Money.TabIndex = 39
        Me.Money.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAdd.FlatAppearance.BorderSize = 2
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Image = Global.Sales_Managment_System.My.Resources.Resources.icons8_save_32px_1
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.Location = New System.Drawing.Point(119, 275)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(210, 40)
        Me.btnAdd.TabIndex = 50
        Me.btnAdd.Text = "حفــظ"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Bank_In
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(398, 327)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.Reason)
        Me.Controls.Add(Me.Money)
        Me.Controls.Add(Me.EmpName)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.Date_IN)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.label3)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Bank_In"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اضافة رصيد بنك"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents lblMoney As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents Reason As System.Windows.Forms.TextBox
    Private WithEvents EmpName As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents Date_IN As System.Windows.Forms.DateTimePicker
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents Money As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
End Class
