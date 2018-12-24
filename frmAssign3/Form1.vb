Public Class Form1

    Private Sub cboSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSize.SelectedIndexChanged

        txtSize.Font = New Font(txtSize.Font.Name, cboSize.SelectedItem, FontStyle.Regular)

    End Sub

    Private Sub lblFRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFRed.Click
        txtSize.ForeColor = Color.Red

    End Sub

    Private Sub lblFBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBlue.Click
        txtSize.ForeColor = Color.Blue


    End Sub

    Private Sub lblFGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFGreen.Click
        txtSize.ForeColor = Color.Green

    End Sub

    Private Sub lblFViolet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFViolet.Click
        txtSize.ForeColor = Color.Violet

    End Sub

    Private Sub lblFBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBlack.Click
        txtSize.ForeColor = Color.Black

    End Sub

    Private Sub lblFOrange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFOrange.Click
        txtSize.ForeColor = Color.Orange

    End Sub

    Private Sub lblFYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFYellow.Click
        txtSize.ForeColor = Color.Yellow

    End Sub

    Private Sub lblFBrown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBrown.Click
        txtSize.ForeColor = Color.Brown

    End Sub

    Private Sub lblFWhite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFWhite.Click
        txtSize.ForeColor = Color.White

    End Sub

    Private Sub lblFBlueSky_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBlueSky.Click
        txtSize.ForeColor = Color.SkyBlue

    End Sub

    Private Sub lblBRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBRed.Click
        txtSize.BackColor = Color.Red

    End Sub

    Private Sub lblBBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBBlue.Click
        txtSize.BackColor = Color.Blue

    End Sub

    Private Sub lblBGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBGreen.Click
        txtSize.BackColor = Color.Green

    End Sub

    Private Sub lblBViolet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBViolet.Click
        txtSize.BackColor = Color.Violet

    End Sub

    Private Sub lblBBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBBlack.Click
        txtSize.BackColor = Color.Black

    End Sub

    Private Sub lblBOrange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBOrange.Click
        txtSize.BackColor = Color.Orange

    End Sub

    Private Sub lblBYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBYellow.Click
        txtSize.BackColor = Color.Yellow

    End Sub

    Private Sub lblBBrown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBBrown.Click
        txtSize.BackColor = Color.Brown

    End Sub

    Private Sub lblBWhite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBWhite.Click
        txtSize.BackColor = Color.White

    End Sub

    Private Sub lblBBlueSky_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBBlueSky.Click
        txtSize.BackColor = Color.SkyBlue
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim n2 As Integer
        n2 = Val(txtSize.Text)
        n2 = n2 + 3
        txtSize.Text = n2

    End Sub

    Private Sub btnSubtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubtract.Click
        Dim n3 As Integer
        n3 = Val(txtSize.Text)
        n3 = n3 - 3
        txtSize.Text = n3

    End Sub

    Private Sub txtSize_TextChanged(sender As Object, e As EventArgs) Handles txtSize.TextChanged

    End Sub
End Class
