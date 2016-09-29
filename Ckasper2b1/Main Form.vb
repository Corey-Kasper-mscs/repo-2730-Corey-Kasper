'Name:          Cranston Barries Project
'Purpose:       Calulates projected sales
'Programmer:    Corey Kasper 9/28/2016

Option Strict On
Option Explicit On
Option Infer Off

Public Class Form1
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        Dim decResultCommission As Decimal
        Dim decSTAWsales As Integer
        Dim decBLUEsales As Integer
        Dim decRASPsales As Integer
        Dim totalSTAWsales As Decimal
        Dim totalBLUEsales As Decimal
        Dim totalRASPsales As Decimal

        Integer.TryParse(txtCurStraw.Text, decSTAWsales)
        Integer.TryParse(txtCurBlue.Text, decBLUEsales)
        Integer.TryParse(txtCurRasp.Text, decRASPsales)
        Decimal.TryParse(txtprojectIncrease.Text, decResultCommission)

        ' cheet cheet to convert in money format: lblTotalSales.Text = dectotalSales.ToString("C2")
        'Staw * projectIncrease then convert to string to lblprostraw.text
        totalSTAWsales = decSTAWsales * decResultCommission + decSTAWsales
        lblProStraw.Text = totalSTAWsales.ToString("C2")

        'for Blue
        totalBLUEsales = decBLUEsales * decResultCommission + decBLUEsales
        lblProBlue.Text = totalBLUEsales.ToString("C2")

        'for Rasp
        totalRASPsales = decRASPsales * decResultCommission + decRASPsales
        lblProRasp.Text = totalRASPsales.ToString("C2")

        'lblProStraw.Text = Format((1 + Val(txtprojectIncrease.Text)) * Val(txtCurStraw.Text), "currency")
        'lblProBlue.Text = Format((1 + Val(txtprojectIncrease.Text)) * Val(txtCurBlue.Text), "currency")
        'lblProRasp.Text = Format((1 + Val(txtprojectIncrease.Text)) * Val(txtCurRasp.Text), "currency")
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

    Private Sub btnRetirment_Click(sender As Object, e As EventArgs) Handles btnRetirment.Click
        Retirment_Form.Show()
    End Sub
End Class
