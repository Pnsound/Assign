Public Class frmAssign4
    Const decR__BONUS = 0.25
    Const decR_Tax = 0.07
    Dim Day As Date = Date.Now
    Dim saraly, sale As Double
   
   
    Private Sub frmAssign4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


       

    End Sub

    Private Sub btnExcute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcute.Click
       
        dblSumSalary = Val(txtSalary.Text) * 12
        dblBonus = Val(txtSale.Text) * decR__BONUS
        dblIncome = dblSumSalary + dblBonus
        dblAllowance = dblIncome * 0.01
        dblTax = (dblIncome - dblAllowance) * decR_Tax


        lblSumSalary.Text = FormatNumber(dblSumSalary)

        lblBonus.Text = FormatNumber(dblBonus)

        lblIncome.Text = FormatNumber(dblIncome)
        lblAllowance.Text = FormatNumber(dblAllowance)

        lblTax.Text = FormatNumber(dblTax)


    End Sub

    Private Sub radShortDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radShortDate.CheckedChanged
        If radShortDate.Checked Then

            lblDate.Text = FormatDateTime(Day, DateFormat.ShortDate)
        End If
    End Sub

    Private Sub radLongDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLongDate.CheckedChanged
        If radLongDate.Checked Then

            lblDate.Text = FormatDateTime(Day, DateFormat.LongDate)

        End If
    End Sub

    Private Sub lblDate_Click(sender As Object, e As EventArgs) Handles lblDate.Click

    End Sub

    Private Sub radGenDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGenDate.CheckedChanged
        If radGenDate.Checked Then
            lblDate.Text = FormatDateTime(Day, DateFormat.GeneralDate)
        End If



    End Sub
End Class