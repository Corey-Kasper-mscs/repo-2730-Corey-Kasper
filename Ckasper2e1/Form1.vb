'Name:          1e1
'Purpose:       If And Or
'Programmer:    Corey Kasper 10/16/2016

Option Strict On
Option Explicit On
Option Infer Off


Public Class Form1

    Private Sub btnCalcAnd_Click(sender As Object, e As EventArgs) Handles btnCalcAnd.Click
        Dim intOrderamt As Integer

        Integer.TryParse(txtOrderAmount.Text, intOrderamt)

        txtYandN.Text = UCase(txtYandN.Text)

        If txtYandN.Text = "Y" And intOrderamt >= 100 Then
            lblShippingCharge.Text = "0$"
        Else
            lblShippingCharge.Text = "9$"
        End If
    End Sub

    Private Sub btnCalcOr_Click(sender As Object, e As EventArgs) Handles btnCalcOr.Click
        Dim intOrderamt As Integer

        Integer.TryParse(txtOrderAmount.Text, intOrderamt)

        txtYandN.Text = UCase(txtYandN.Text)

        If txtYandN.Text <> "Y" Or intOrderamt < 100 Then
            lblShippingCharge.Text = "9$"
        Else
            lblShippingCharge.Text = "0$"
        End If
    End Sub

    Private Sub btnCalcEqual_Click(sender As Object, e As EventArgs) Handles btnCalcEqual.Click
        Dim dblSales As Double
        Dim dblCommsion As Double

        Double.TryParse(txtSales.Text, dblSales)

        txtID.Text = UCase(txtID.Text)

        If txtID.Text = "A1" Or txtID.Text = "B2" Or txtID.Text = "C3" And dblSales >= 25000 Then
            dblCommsion = dblSales * 0.15
            lblComm.Text = dblCommsion.ToString("C2")
        Else
            dblCommsion = dblSales * 0.12
            lblComm.Text = dblCommsion.ToString("C2")
        End If
    End Sub

    Private Sub btnCalcNotEqual_Click(sender As Object, e As EventArgs) Handles btnCalcNotEqual.Click
        Dim dblSales As Double
        Dim dblCommsion As Double

        Double.TryParse(txtSales.Text, dblSales)

        txtID.Text = UCase(txtID.Text)

        If txtID.Text <> "A1" Or txtID.Text <> "B2" Or txtID.Text <> "C3" And dblSales < 25000 Then
            dblCommsion = dblSales * 0.12
            lblComm.Text = dblCommsion.ToString("C2")
        Else
            dblCommsion = dblSales * 0.15
            lblComm.Text = dblCommsion.ToString("C2")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
