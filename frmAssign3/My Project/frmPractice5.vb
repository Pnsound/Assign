Public Class frmLab5
    Dim decTotal, decDiscount, DecNet, decCredit, decPaid, decGrant As Decimal

    Private Sub lblSumSale_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        decTotal = Val(txtPrice.Text) * Val(txtUnit.Text)
        lblTotal.Text = decTotal

    End Sub


    Private Sub txtProPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.TextChanged
        Call lblTotal_Click(sender, e)


    End Sub

    Private Sub txtProAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnit.TextChanged
        Call lblTotal_click(sender, e)

    End Sub

    Private Sub radOther_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOther.CheckedChanged
        lblCredit.Text = ""
        lblPaid.Text = ""
        lblDiscount.Text = ""
        gpbPaid.Enabled = True
        radCredit.Enabled = True




    End Sub

    Private Sub radNone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMember.CheckedChanged
        radPaid.Checked = True

        If Not radCredit.Checked Then
            radCredit.Enabled = False
        End If



    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        txtUnit.Text = txtUnit.Text.Trim
        txtPrice.Text = txtPrice.Text.Trim



        If Not IsNumeric(radOther.Text) Then
            MessageBox.Show("สามารถใช้งานได้", "กรุณาป้อนข้อมูลใหม่อีกครั้ง", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End If

        If Not IsNumeric(radMember.Text) Then
            MessageBox.Show("ไม่สามารถใช้งานได้", "กรุณาป้อนข้อมูลใหม่อีกครั้ง", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If




        If radOther.Checked = True Then

            If radPaid.Checked = True Then

                If decTotal < 2500 Then
                    decDiscount = 0
                ElseIf decTotal < 10000 Then
                    decDiscount = decTotal * 0.1
                ElseIf decTotal < 20000 Then
                    decDiscount = decTotal * 0.15
                ElseIf decTotal > 20000 Then
                    decDiscount = decTotal * 0.2
                End If
            End If
            lblDiscount.Text = ""
        Else
            If radMember.Enabled = True Then
                radPaid.Enabled = True
                decDiscount = 0
                decPaid = decTotal
                lblPaid.Text = decTotal

            End If
        End If

        decGrant = decSumSale - decDiscount
        lblGrant.Text = decGrant
        lblDiscount.Text = decDiscount

        If radCash.Checked Then
            decCredit = 0
        Else
            decCredit = decSumSale
            lblDiscount.Text = ""
            lblGrant.Text = ""
        End If

        lblCredit.Text = decCredit

    End Sub



    Private Sub frmAssign5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class