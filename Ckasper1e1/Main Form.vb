Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Calculates assassed and property *0.5
        txtprob.Text = Val(txtassessed.Text) * 0.5
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtassessed.Text = String.Empty
        txtprob.Text = String.Empty
    End Sub
End Class
