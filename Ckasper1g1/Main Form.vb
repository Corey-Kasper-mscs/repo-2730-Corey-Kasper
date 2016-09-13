'Name:          1G Tests Scores
'Purpose:       Calulates Test Scores
'Programmer:    Corey Kasper 9/13/2016

Option Strict On

Public Class frmMain
    Private Sub txtScore2_TextChanged(sender As Object, e As EventArgs) Handles txtScore2.TextChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblAverageTestScore.Text = String.Empty
        txtScore1.Text = String.Empty
        txtScore2.Text = String.Empty
        txtScore3.Text = String.Empty
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblAverageTestScore.Text = Format((Val(txtScore1.Text) + Val(txtScore2.Text) + Val(txtScore3.Text)) / 3, "0.00")
    End Sub
End Class
