Public Class Form1
    Dim decTotal As Decimal
    Dim decDiscount As Decimal
    Dim decNet As Decimal
    Dim decCredit As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radCredit.Checked = False
        radMember.Checked = False
        radOther.Checked = False
        radPaid.Checked = False
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        decTotal = Val(txtPrice.Text) * Val(txtUnit.Text)
        lblTotal.Text = FormatNumber(decTotal)

    End Sub

    Private Sub txtUnit_TextChanged(sender As Object, e As EventArgs) Handles txtUnit.TextChanged


    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        decTotal = FormatNumber(txtPrice.Text) * FormatNumber(txtUnit.Text)
        lblTotal.Text = FormatNumber(decTotal)
        If txtProduct.Text = "" Or txtPrice.Text = "" Or txtUnit.Text = "" Or Val(txtPrice.Text) < 1 Or Val(txtUnit.Text) < 1 Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์")
            Exit Sub
        End If
        If radOther.Checked = True Then
            If radPaid.Checked = True Then
                If decTotal <= 999 Then
                    decDiscount = 0
                ElseIf decTotal <= 4999 Then
                    decDiscount = decTotal * 0.05
                ElseIf decTotal <= 9999 Then
                    decDiscount = decTotal * 0.1
                ElseIf decTotal >= 10000 Then
                    decDiscount = decTotal * 0.15
                End If
                lblDiscount.Text = FormatNumber(decDiscount)
                decNet = FormatNumber(decTotal) - FormatNumber(decDiscount)
                lblPaid.Text = FormatNumber(decNet)
                lblCredit.Text = 0


            ElseIf radCredit.Checked = True Then

                lblDiscount.Text = 0
                decCredit = FormatNumber(decTotal)
                lblCredit.Text = FormatNumber(decCredit)
                lblPaid.Text = FormatNumber(decCredit)

            End If
        End If
        If radMember.Checked = True Then
            lblDiscount.Text = 0
            lblCredit.Text = 0
            lblPaid.Text = FormatNumber(decTotal)

        End If
    End Sub



    Private Sub radOther_CheckedChanged(sender As Object, e As EventArgs) Handles radOther.CheckedChanged
        radCredit.Enabled = False
        radCredit.Checked = False
        radPaid.Checked = True
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub radMember_CheckedChanged(sender As Object, e As EventArgs) Handles radMember.CheckedChanged

        radCredit.Enabled = True
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub
End Class
