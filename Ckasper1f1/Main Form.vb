'Name:          Cranston Barries Project
'Purpose:       Calulates projected sales
'Programmer:    Corey Kasper 9/12/2016

Option Strict On

Public Class Form1
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        lblProStraw.Text = Format((1 + Val(txtprojectIncrease.Text)) * Val(txtCurStraw.Text), "currency")
        lblProBlue.Text = Format((1 + Val(txtprojectIncrease.Text)) * Val(txtCurBlue.Text), "currency")
        lblProRasp.Text = Format((1 + Val(txtprojectIncrease.Text)) * Val(txtCurRasp.Text), "currency")
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblProStraw.Text = String.Empty
        lblProBlue.Text = String.Empty
        lblProRasp.Text = String.Empty
        txtCurStraw.Text = String.Empty
        txtCurBlue.Text = String.Empty
        txtCurRasp.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
