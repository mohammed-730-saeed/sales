<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock_Out
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
        Me.DateOut = New System.Windows.Forms.DateTimePicker()
        Me.Money_Available = New System.Windows.Forms.TextBox()
        Me.Money = New System.Windows.Forms.TextBox()
        Me.EmpName = New System.Windows.Forms.TextBox()
        Me.Reason = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cmb_Stock = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DateOut
        '
        Me.DateOut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateOut.Location = New System.Drawing.Point(140, 164)
        Me.DateOut.Name = "DateOut"
        Me.DateOut.Size = New System.Drawing.Size(252, 27)
        Me.DateOut.TabIndex = 48
        '
        'Money_Available
        '
        Me.Money_Available.Location = New System.Drawing.Point(140, 71)
        Me.Money_Available.Name = "Money_Available"
        Me.Money_Available.Size = New System.Drawing.Size(252, 27)
        Me.Money_Available.TabIndex = 45
        '
        'Money
        '
        Me.Money.Location = New System.Drawing.Point(140, 120)
        Me.Money.Name = "Money"
        Me.Money.Size = New System.Drawing.Size(252, 27)
        Me.Money.TabIndex = 44
        '
        'EmpName
        '
        Me.EmpName.Location = New System.Drawing.Point(140, 213)
        Me.EmpName.Name = "EmpName"
        Me.EmpName.Size = New System.Drawing.Size(252, 27)
        Me.EmpName.TabIndex = 47
        '
        'Reason
        '
        Me.Reason.Location = New System.Drawing.Point(140, 256)
        Me.Reason.Name = "Reason"
        Me.Reason.Size = New System.Drawing.Size(252, 27)
        Me.Reason.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 19)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "تاريخ السحب :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(54, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 19)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "اسم الساحب :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 19)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "رصيد الخزنة الحالي :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 19)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "سبب السحب :"
        '
        'Cmb_Stock
        '
        Me.Cmb_Stock.FormattingEnabled = True
        Me.Cmb_Stock.Location = New System.Drawing.Point(140, 22)
        Me.Cmb_Stock.Name = "Cmb_Stock"
        Me.Cmb_Stock.Size = New System.Drawing.Size(252, 27)
        Me.Cmb_Stock.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 19)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "قيمة المبلغ المسحوب :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 19)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "اختار الخزنة :"
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
        Me.btnAdd.Location = New System.Drawing.Point(78, 307)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(105, 40)
        Me.btnAdd.TabIndex = 49
        Me.btnAdd.Text = "حفــظ"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDelete.FlatAppearance.BorderSize = 2
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Image = Global.Sales_Managment_System.My.Resources.Resources.icons8_delete_32px
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.Location = New System.Drawing.Point(301, 307)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(105, 40)
        Me.btnDelete.TabIndex = 50
        Me.btnDelete.Text = "حـــذف"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Stock_Out
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(431, 370)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.DateOut)
        Me.Controls.Add(Me.Money_Available)
        Me.Controls.Add(Me.Money)
        Me.Controls.Add(Me.EmpName)
        Me.Controls.Add(Me.Reason)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cmb_Stock)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Stock_Out"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "شاشة سحب رصيد خزنة"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents DateOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents Money_Available As System.Windows.Forms.TextBox
    Friend WithEvents Money As System.Windows.Forms.TextBox
    Friend WithEvents EmpName As System.Windows.Forms.TextBox
    Friend WithEvents Reason As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cmb_Stock As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
