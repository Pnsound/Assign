<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssign4
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblSumSalary = New System.Windows.Forms.Label()
        Me.lblBonus = New System.Windows.Forms.Label()
        Me.lblIncome = New System.Windows.Forms.Label()
        Me.lblAllowance = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtSale = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radLongDate = New System.Windows.Forms.RadioButton()
        Me.radGenDate = New System.Windows.Forms.RadioButton()
        Me.radShortDate = New System.Windows.Forms.RadioButton()
        Me.btnExcute = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณภาษัี(อย่างหยาบ)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "วันที่"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "เงินเดือน"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 132)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ยอดขายทั้งปี"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 164)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "เงินเดือนทั้งปี"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 210)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "รับโบนัส"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 252)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "รวมรายได้"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 287)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "หักค่าลดหย่อยส่วนตัว"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 332)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "ภาษีที่ต้องชำระ"
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Silver
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDate.Location = New System.Drawing.Point(191, 47)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(243, 28)
        Me.lblDate.TabIndex = 1
        '
        'lblSumSalary
        '
        Me.lblSumSalary.BackColor = System.Drawing.Color.Silver
        Me.lblSumSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSumSalary.Location = New System.Drawing.Point(191, 162)
        Me.lblSumSalary.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSumSalary.Name = "lblSumSalary"
        Me.lblSumSalary.Size = New System.Drawing.Size(243, 28)
        Me.lblSumSalary.TabIndex = 1
        '
        'lblBonus
        '
        Me.lblBonus.BackColor = System.Drawing.Color.Silver
        Me.lblBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBonus.Location = New System.Drawing.Point(191, 198)
        Me.lblBonus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBonus.Name = "lblBonus"
        Me.lblBonus.Size = New System.Drawing.Size(243, 28)
        Me.lblBonus.TabIndex = 1
        '
        'lblIncome
        '
        Me.lblIncome.BackColor = System.Drawing.Color.Silver
        Me.lblIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIncome.Location = New System.Drawing.Point(191, 240)
        Me.lblIncome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIncome.Name = "lblIncome"
        Me.lblIncome.Size = New System.Drawing.Size(243, 28)
        Me.lblIncome.TabIndex = 1
        '
        'lblAllowance
        '
        Me.lblAllowance.BackColor = System.Drawing.Color.Silver
        Me.lblAllowance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAllowance.Location = New System.Drawing.Point(191, 286)
        Me.lblAllowance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAllowance.Name = "lblAllowance"
        Me.lblAllowance.Size = New System.Drawing.Size(243, 28)
        Me.lblAllowance.TabIndex = 1
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.Color.Maroon
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Location = New System.Drawing.Point(191, 320)
        Me.lblTax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(243, 28)
        Me.lblTax.TabIndex = 1
        '
        'txtSalary
        '
        Me.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalary.Location = New System.Drawing.Point(191, 91)
        Me.txtSalary.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSalary.Multiline = True
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(243, 28)
        Me.txtSalary.TabIndex = 2
        '
        'txtSale
        '
        Me.txtSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSale.Location = New System.Drawing.Point(191, 127)
        Me.txtSale.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSale.Multiline = True
        Me.txtSale.Name = "txtSale"
        Me.txtSale.Size = New System.Drawing.Size(243, 28)
        Me.txtSale.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radLongDate)
        Me.GroupBox1.Controls.Add(Me.radGenDate)
        Me.GroupBox1.Controls.Add(Me.radShortDate)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(455, 54)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(268, 135)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รูปแบบวันที่"
        '
        'radLongDate
        '
        Me.radLongDate.AutoSize = True
        Me.radLongDate.Location = New System.Drawing.Point(51, 90)
        Me.radLongDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radLongDate.Name = "radLongDate"
        Me.radLongDate.Size = New System.Drawing.Size(163, 21)
        Me.radLongDate.TabIndex = 0
        Me.radLongDate.TabStop = True
        Me.radLongDate.Text = "วันที่แบบ Long Date"
        Me.radLongDate.UseVisualStyleBackColor = True
        '
        'radGenDate
        '
        Me.radGenDate.AutoSize = True
        Me.radGenDate.Location = New System.Drawing.Point(51, 62)
        Me.radGenDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radGenDate.Name = "radGenDate"
        Me.radGenDate.Size = New System.Drawing.Size(190, 21)
        Me.radGenDate.TabIndex = 0
        Me.radGenDate.TabStop = True
        Me.radGenDate.Text = "วันที่แบบ Genertal Date"
        Me.radGenDate.UseVisualStyleBackColor = True
        '
        'radShortDate
        '
        Me.radShortDate.AutoSize = True
        Me.radShortDate.Location = New System.Drawing.Point(51, 33)
        Me.radShortDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radShortDate.Name = "radShortDate"
        Me.radShortDate.Size = New System.Drawing.Size(166, 21)
        Me.radShortDate.TabIndex = 0
        Me.radShortDate.TabStop = True
        Me.radShortDate.Text = "วันที่แบบ Short Date"
        Me.radShortDate.UseVisualStyleBackColor = True
        '
        'btnExcute
        '
        Me.btnExcute.Location = New System.Drawing.Point(485, 222)
        Me.btnExcute.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExcute.Name = "btnExcute"
        Me.btnExcute.Size = New System.Drawing.Size(201, 80)
        Me.btnExcute.TabIndex = 4
        Me.btnExcute.Text = "คำนวณ"
        Me.btnExcute.UseVisualStyleBackColor = True
        '
        'frmAssign4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 398)
        Me.Controls.Add(Me.btnExcute)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSale)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblAllowance)
        Me.Controls.Add(Me.lblIncome)
        Me.Controls.Add(Me.lblBonus)
        Me.Controls.Add(Me.lblSumSalary)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmAssign4"
        Me.Text = "frmAssign4"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblSumSalary As System.Windows.Forms.Label
    Friend WithEvents lblBonus As System.Windows.Forms.Label
    Friend WithEvents lblIncome As System.Windows.Forms.Label
    Friend WithEvents lblAllowance As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents txtSale As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radLongDate As System.Windows.Forms.RadioButton
    Friend WithEvents radGenDate As System.Windows.Forms.RadioButton
    Friend WithEvents radShortDate As System.Windows.Forms.RadioButton
    Friend WithEvents btnExcute As System.Windows.Forms.Button
End Class
