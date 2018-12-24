<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLab5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radOther = New System.Windows.Forms.RadioButton()
        Me.radMember = New System.Windows.Forms.RadioButton()
        Me.gpbPaid = New System.Windows.Forms.GroupBox()
        Me.radCredit = New System.Windows.Forms.RadioButton()
        Me.radPaid = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gpbPaid.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(290, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณการขาย"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชื่อสินค้า"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ราคาขาย"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "จำนวนซื้อ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "เป็นเงิน"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 313)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ส่วนลด"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 385)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ยอดค้างชำระ"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 347)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "จำนวนเงินต้องชำระ"
        '
        'lblCredit
        '
        Me.lblCredit.AutoSize = True
        Me.lblCredit.Location = New System.Drawing.Point(206, 385)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(51, 17)
        Me.lblCredit.TabIndex = 0
        Me.lblCredit.Text = "Label1"
        '
        'lblPaid
        '
        Me.lblPaid.AutoSize = True
        Me.lblPaid.Location = New System.Drawing.Point(206, 347)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(51, 17)
        Me.lblPaid.TabIndex = 0
        Me.lblPaid.Text = "Label1"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(206, 313)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(51, 17)
        Me.lblDiscount.TabIndex = 0
        Me.lblDiscount.Text = "Label1"
        '
        'txtProduct
        '
        Me.txtProduct.Location = New System.Drawing.Point(209, 69)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(100, 22)
        Me.txtProduct.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(209, 102)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtPrice.TabIndex = 1
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(209, 136)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(100, 22)
        Me.txtUnit.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radMember)
        Me.GroupBox1.Controls.Add(Me.radOther)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 209)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 85)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ประเภทลูกค้า"
        '
        'radOther
        '
        Me.radOther.AutoSize = True
        Me.radOther.Location = New System.Drawing.Point(17, 31)
        Me.radOther.Name = "radOther"
        Me.radOther.Size = New System.Drawing.Size(66, 21)
        Me.radOther.TabIndex = 0
        Me.radOther.TabStop = True
        Me.radOther.Text = "สมาชิก"
        Me.radOther.UseVisualStyleBackColor = True
        '
        'radMember
        '
        Me.radMember.AutoSize = True
        Me.radMember.Location = New System.Drawing.Point(138, 31)
        Me.radMember.Name = "radMember"
        Me.radMember.Size = New System.Drawing.Size(88, 21)
        Me.radMember.TabIndex = 0
        Me.radMember.TabStop = True
        Me.radMember.Text = "ลูกค้าทั่วไป"
        Me.radMember.UseVisualStyleBackColor = True
        '
        'gpbPaid
        '
        Me.gpbPaid.Controls.Add(Me.radCredit)
        Me.gpbPaid.Controls.Add(Me.radPaid)
        Me.gpbPaid.Location = New System.Drawing.Point(293, 209)
        Me.gpbPaid.Name = "gpbPaid"
        Me.gpbPaid.Size = New System.Drawing.Size(239, 85)
        Me.gpbPaid.TabIndex = 2
        Me.gpbPaid.TabStop = False
        Me.gpbPaid.Text = "การชำระเงิน"
        '
        'radCredit
        '
        Me.radCredit.AutoSize = True
        Me.radCredit.Location = New System.Drawing.Point(138, 31)
        Me.radCredit.Name = "radCredit"
        Me.radCredit.Size = New System.Drawing.Size(48, 21)
        Me.radCredit.TabIndex = 0
        Me.radCredit.TabStop = True
        Me.radCredit.Text = "เชื่อ"
        Me.radCredit.UseVisualStyleBackColor = True
        '
        'radPaid
        '
        Me.radPaid.AutoSize = True
        Me.radPaid.Location = New System.Drawing.Point(17, 31)
        Me.radPaid.Name = "radPaid"
        Me.radPaid.Size = New System.Drawing.Size(44, 21)
        Me.radPaid.TabIndex = 0
        Me.radPaid.TabStop = True
        Me.radPaid.Text = "สด"
        Me.radPaid.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(198, 429)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "คำนวณ"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(209, 177)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(51, 17)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "Label1"
        '
        'frmLab5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 514)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.gpbPaid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.lblPaid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab5"
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gpbPaid.ResumeLayout(False)
        Me.gpbPaid.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblCredit As Label
    Friend WithEvents lblPaid As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents txtProduct As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radMember As RadioButton
    Friend WithEvents radOther As RadioButton
    Friend WithEvents gpbPaid As GroupBox
    Friend WithEvents radCredit As RadioButton
    Friend WithEvents radPaid As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblTotal As Label
End Class
