'Name:          Retirment Form
'Purpose:       Calulates Retirment funds
'Programmer:    Corey Kasper 9/29/2016

Option Strict On
Option Explicit On
Option Infer Off

Public Class Retirment_Form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'annual = gross * 52
        'employee annual cont = annual * employee cont rate Then convert to text put in currency
        'employer annual cont = annual * employer cont rate Then convert to text put in currency
        'total annual cont = emploee cont rate + employer cont rate Then convert to text put in currency

        Dim decGROSSpay As Decimal
        Dim decANNUAL As Decimal
        Dim decEmployeeContRate As Decimal
        Dim decEmployerContRate As Decimal
        Dim decEmployeeAnn As Decimal
        Dim decEmployerAnn As Decimal
        Dim decTotalAnn As Decimal

        Decimal.TryParse(txtGrosspay.Text, decGROSSpay)
        Decimal.TryParse(txtEmployeeCont.Text, decEmployeeContRate)
        Decimal.TryParse(txtEmployerCont.Text, decEmployerContRate)

        decANNUAL = decGROSSpay * 52

        ' cheet cheet to convert in money format: lblTotalSales.Text = dectotalSales.ToString("C2")

        decEmployeeAnn = decANNUAL * decEmployeeContRate
        lblEmployeeAnn.Text = decEmployeeAnn.ToString("C2")

        decEmployerAnn = decANNUAL * decEmployerContRate
        lblEmployerAnn.Text = decEmployerAnn.ToString("C2")

        decTotalAnn = decEmployeeAnn + decEmployerAnn
        lblTotalAnn.Text = decTotalAnn.ToString("C2")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEmployeeCont.Text = String.Empty
        txtEmployerCont.Text = String.Empty
        txtGrosspay.Text = String.Empty
        lblEmployeeAnn.Text = String.Empty
        lblEmployerAnn.Text = String.Empty
        lblTotalAnn.Text = String.Empty
    End Sub
End Class