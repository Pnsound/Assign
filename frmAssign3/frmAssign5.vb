Public Class frmAssign5

    Private Sub lblSumSale_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        decSumSale = Val(txtProPrice.Text) * Val(txtProAmount.Text)
        lblSumSale.Text = decSumSale

    End Sub


    Private Sub txtProPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProPrice.TextChanged
        Call lblSumSale_Click(sender, e)


    End Sub

    Private Sub txtProAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProAmount.TextChanged
        Call lblSumSale_Click(sender, e)
        
    End Sub

    Private Sub radCustomer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCustomer.CheckedChanged
        lblCredit.Text = ""
        lblGrant.Text = ""
        lblDiscount.Text = ""
        gpbPaid.Enabled = True
        radCredit.Enabled = True




    End Sub

    Private Sub radNone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radNone.CheckedChanged
        radCash.Checked = True

        If Not radCredit.Checked Then
            radCredit.Enabled = False
        End If



    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        txtProAmount.Text = txtProAmount.Text.Trim
        txtProPrice.Text = txtProPrice.Text.Trim



        If Not IsNumeric(txtProPrice.Text) Then
            MessageBox.Show("ท่านป้อนราคาไม่ถูกต้อง", "กรุณาป้อนข้อมูลใหม่อีกครั้ง", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

        End If

        If Not IsNumeric(txtProAmount.Text) Then
            MessageBox.Show("ท่านไม่ได้ป้อนจำนวนสินค้า", "กรุณาป้อนข้อมูลใหม่อีกครั้ง", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        


        If radCustomer.Checked = True Then

            If radCash.Checked = True Then

                If decSumSale < 2500 Then
                    decDiscount = 0
                ElseIf decSumSale < 10000 Then
                    decDiscount = decSumSale * 0.1
                ElseIf decSumSale < 20000 Then
                    decDiscount = decSumSale * 0.15
                ElseIf decSumSale > 20000 Then
                    decDiscount = decSumSale * 0.2
                End If
            End If
            lblDiscount.Text = ""
        Else
            If radNone.Enabled = True Then
                radCash.Enabled = True
                decDiscount = 0
                decGrant = decSumSale
                lblGrant.Text = decSumSale

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