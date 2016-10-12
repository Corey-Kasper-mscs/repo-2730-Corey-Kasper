'Name:          Money Conversion
'Purpose:       Test Data Types
'Programmer:    Corey Kasper 10/12/2016

Option Strict On
Option Explicit On
Option Infer Off

Public Class Form1
    Private Sub btnConvertEqual_Click(sender As Object, e As EventArgs) Handles btnConvertEqual.Click

        Const dblEruo_rate As Double = 0.9
        Const dblPound_rate As Double = 0.79
        Const dblRand_rate As Double = 13.89
        Dim dblAmDollar As Double
        Dim dblEuro As Double
        Dim dblPound As Double
        Dim dblRand As Double

        lblBritpound.Text = String.Empty
        lblEuro.Text = String.Empty
        lblSouthrand.Text = String.Empty

        If txtAmericanDollar.Text = String.Empty Then
            MessageBox.Show("Please enter number of American dollars.", "Currency Converter", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Double.TryParse(txtAmericanDollar.Text, dblAmDollar)

            dblEuro = dblAmDollar * dblEruo_rate
            dblPound = dblAmDollar * dblPound_rate
            dblRand = dblAmDollar * dblRand_rate

            lblEuro.Text = dblEuro.ToString("C2")
            lblBritpound.Text = dblPound.ToString("C2")
            lblSouthrand.Text = dblRand.ToString("C2")
        End If


    End Sub

    Private Sub btnConvertGreaterLess_Click(sender As Object, e As EventArgs) Handles btnConvertGreaterLess.Click

        Const dblEruo_rate As Double = 0.9
        Const dblPound_rate As Double = 0.79
        Const dblRand_rate As Double = 13.89
        Dim dblAmDollar As Double
        Dim dblEuro As Double
        Dim dblPound As Double
        Dim dblRand As Double

        lblBritpound.Text = String.Empty
        lblEuro.Text = String.Empty
        lblSouthrand.Text = String.Empty

        If txtAmericanDollar.Text <> String.Empty Then
            Double.TryParse(txtAmericanDollar.Text, dblAmDollar)

            dblEuro = dblAmDollar * dblEruo_rate
            dblPound = dblAmDollar * dblPound_rate
            dblRand = dblAmDollar * dblRand_rate

            lblEuro.Text = dblEuro.ToString()
            lblBritpound.Text = dblPound.ToString("C2")
            lblSouthrand.Text = dblRand.ToString("C2")
            'MessageBox.Show("Please enter number of American dollars.", "Currency Converter", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Please enter number of American dollars.", "Currency Converter", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblTotalDue As Double
        Dim dblPounds As Double
        Dim dblPricetoLB As Double
        Const dblShipping As Double = 15
        Dim Msg As DialogResult = MessageBox.Show("Charge for shipping?", "Shipping", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        lblTotalDue.Text = String.Empty

        Double.TryParse(txtPounds.Text, dblPounds)
        Double.TryParse(txtPriceperlb.Text, dblPricetoLB)


        'MessageBox.Show("Charge for shipping?", "Shipping", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If Msg = DialogResult.Yes Then
            dblTotalDue = dblPounds * dblPricetoLB + dblShipping
            lblTotalDue.Text = dblTotalDue.ToString("C2")

        Else
            dblTotalDue = dblPounds * dblPricetoLB
            lblTotalDue.Text = dblTotalDue.ToString("C2")

        End If


    End Sub

    Private Sub btnCalc4_Click(sender As Object, e As EventArgs) Handles btnCalc4.Click
        'current - Previous * .13
        Dim DblCurrent As Double
        Dim DblPrevious As Double
        Dim DblMonthlybill As Double

        Double.TryParse(txtCurrent.Text, DblCurrent)
        Double.TryParse(txtPrevious.Text, DblPrevious)

        If txtCurrent.Text = String.Empty Or txtPrevious.Text = String.Empty Or DblCurrent > DblPrevious Then
            MessageBox.Show("Current needs to be lower than Previous.", "Triple County", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            DblMonthlybill = (DblPrevious - DblCurrent) * 0.13
            lblMonthlyBill.Text = DblMonthlybill.ToString("C2")
        End If
    End Sub

    Private Sub btnCalcdiv_Click(sender As Object, e As EventArgs) Handles btnCalcdiv.Click
        Dim dblFrist As Double
        Dim dblSecond As Double
        Dim dblQuotient As Double

        Double.TryParse(txtFrist.Text, dblFrist)
        Double.TryParse(txtSecond.Text, dblSecond)

        If txtFrist.Text = "0" Or txtSecond.Text = "0" Or txtFrist.Text = String.Empty Or txtSecond.Text = String.Empty Then
            MessageBox.Show("Can not use 0", "Calculator", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf dblFrist > dblSecond Then
            dblQuotient = dblFrist / dblSecond
            lblQuotient.Text = dblQuotient.ToString()
        ElseIf dblSecond > dblFrist Then
            dblQuotient = dblSecond / dblFrist
            lblQuotient.Text = dblQuotient.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
