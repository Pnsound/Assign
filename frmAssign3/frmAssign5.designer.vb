<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssign5
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.txtProPrice = New System.Windows.Forms.TextBox()
        Me.txtProAmount = New System.Windows.Forms.TextBox()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblGrant = New System.Windows.Forms.Label()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radNone = New System.Windows.Forms.RadioButton()
        Me.radCustomer = New System.Windows.Forms.RadioButton()
        Me.gpbPaid = New System.Windows.Forms.GroupBox()
        Me.radCredit = New System.Windows.Forms.RadioButton()
        Me.radCash = New System.Windows.Forms.RadioButton()
        Me.lblSumSale = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gpbPaid.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(186, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณการขาย"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชื่อสินค้า"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ราคา"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "จำนวน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "เป็นเงิน"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ส่วนลด"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 289)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "จำนวนเงินต้องชำระ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 327)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 24)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ยอดค้างชำระ"
        '
        'txtProduct
        '
        Me.txtProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProduct.Location = New System.Drawing.Point(131, 48)
        Me.txtProduct.Multiline = True
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(267, 28)
        Me.txtProduct.TabIndex = 1
        '
        'txtProPrice
        '
        Me.txtProPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProPrice.Location = New System.Drawing.Point(206, 82)
        Me.txtProPrice.Multiline = True
        Me.txtProPrice.Name = "txtProPrice"
        Me.txtProPrice.Size = New System.Drawing.Size(192, 28)
        Me.txtProPrice.TabIndex = 1
        '
        'txtProAmount
        '
        Me.txtProAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProAmount.Location = New System.Drawing.Point(206, 116)
        Me.txtProAmount.Multiline = True
        Me.txtProAmount.Name = "txtProAmount"
        Me.txtProAmount.Size = New System.Drawing.Size(192, 28)
        Me.txtProAmount.TabIndex = 1
        '
        'lblDiscount
        '
        Me.lblDiscount.BackColor = System.Drawing.Color.White
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiscount.Location = New System.Drawing.Point(206, 260)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(172, 23)
        Me.lblDiscount.TabIndex = 2
        '
        'lblGrant
        '
        Me.lblGrant.BackColor = System.Drawing.Color.White
        Me.lblGrant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrant.Location = New System.Drawing.Point(206, 292)
        Me.lblGrant.Name = "lblGrant"
        Me.lblGrant.Size = New System.Drawing.Size(172, 23)
        Me.lblGrant.TabIndex = 2
        '
        'lblCredit
        '
        Me.lblCredit.BackColor = System.Drawing.Color.White
        Me.lblCredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCredit.Location = New System.Drawing.Point(206, 327)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(172, 23)
        Me.lblCredit.TabIndex = 2
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(248, 362)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(139, 37)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "คำนวณ"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.GroupBox1.Controls.Add(Me.radNone)
        Me.GroupBox1.Controls.Add(Me.radCustomer)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 189)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(143, 61)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "กลุ่มลูกค้า"
        '
        'radNone
        '
        Me.radNone.AutoSize = True
        Me.radNone.Location = New System.Drawing.Point(70, 19)
        Me.radNone.Name = "radNone"
        Me.radNone.Size = New System.Drawing.Size(65, 17)
        Me.radNone.TabIndex = 0
        Me.radNone.TabStop = True
        Me.radNone.Text = "ภายนอก"
        Me.radNone.UseVisualStyleBackColor = True
        '
        'radCustomer
        '
        Me.radCustomer.AutoSize = True
        Me.radCustomer.Location = New System.Drawing.Point(6, 19)
        Me.radCustomer.Name = "radCustomer"
        Me.radCustomer.Size = New System.Drawing.Size(58, 17)
        Me.radCustomer.TabIndex = 0
        Me.radCustomer.TabStop = True
        Me.radCustomer.Text = "ภายใน"
        Me.radCustomer.UseVisualStyleBackColor = True
        '
        'gpbPaid
        '
        Me.gpbPaid.BackColor = System.Drawing.SystemColors.Menu
        Me.gpbPaid.Controls.Add(Me.radCredit)
        Me.gpbPaid.Controls.Add(Me.radCash)
        Me.gpbPaid.Enabled = False
        Me.gpbPaid.Location = New System.Drawing.Point(190, 189)
        Me.gpbPaid.Name = "gpbPaid"
        Me.gpbPaid.Size = New System.Drawing.Size(143, 61)
        Me.gpbPaid.TabIndex = 4
        Me.gpbPaid.TabStop = False
        Me.gpbPaid.Text = "การชำระเงิน"
        '
        'radCredit
        '
        Me.radCredit.AutoSize = True
        Me.radCredit.Location = New System.Drawing.Point(70, 18)
        Me.radCredit.Name = "radCredit"
        Me.radCredit.Size = New System.Drawing.Size(57, 17)
        Me.radCredit.TabIndex = 0
        Me.radCredit.TabStop = True
        Me.radCredit.Text = "เครดิต"
        Me.radCredit.UseVisualStyleBackColor = True
        '
        'radCash
        '
        Me.radCash.AutoSize = True
        Me.radCash.Location = New System.Drawing.Point(26, 19)
        Me.radCash.Name = "radCash"
        Me.radCash.Size = New System.Drawing.Size(38, 17)
        Me.radCash.TabIndex = 0
        Me.radCash.TabStop = True
        Me.radCash.Text = "สด"
        Me.radCash.UseVisualStyleBackColor = True
        '
        'lblSumSale
        '
        Me.lblSumSale.BackColor = System.Drawing.Color.White
        Me.lblSumSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSumSale.Location = New System.Drawing.Point(206, 147)
        Me.lblSumSale.Name = "lblSumSale"
        Me.lblSumSale.Size = New System.Drawing.Size(192, 38)
        Me.lblSumSale.TabIndex = 2
        '
        'frmAssign5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 413)
        Me.Controls.Add(Me.gpbPaid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.lblGrant)
        Me.Controls.Add(Me.lblSumSale)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.txtProAmount)
        Me.Controls.Add(Me.txtProPrice)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAssign5"
        Me.Text = "กลุ่มลูกค้า"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gpbPaid.ResumeLayout(False)
        Me.gpbPaid.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtProduct As System.Windows.Forms.TextBox
    Friend WithEvents txtProPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtProAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblGrant As System.Windows.Forms.Label
    Friend WithEvents lblCredit As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radNone As System.Windows.Forms.RadioButton
    Friend WithEvents radCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents gpbPaid As System.Windows.Forms.GroupBox
    Friend WithEvents radCredit As System.Windows.Forms.RadioButton
    Friend WithEvents radCash As System.Windows.Forms.RadioButton
    Friend WithEvents lblSumSale As System.Windows.Forms.Label
End Class
