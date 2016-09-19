'Name:          Photo Workshop Payroll
'Purpose:       Calulates Pay
'Programmer:    Corey Kasper 9/18/2016

Option Strict On



Public Class MainForm



    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Gross=hours*Payrate, FWT=.2*Gross, Fica=.08*Gross, State=.03*Gross, Net=Gross-FWT-Fica-State
        lblGross.Text = Format(Val(TxtHours.Text) * Val(txtPayRate.Text), "Fixed")
        lblFwt.Text = Format(Val(lblGross.Text) * 0.2, "Fixed")
        lblFICA.Text = Format(Val(lblGross.Text) * 0.08, "Fixed")
        lblState.Text = Format(Val(lblGross.Text) * 0.03, "Fixed")
        lblNet.Text = Format(Val(lblGross.Text) - Val(lblFwt.Text) - Val(lblFICA.Text) - Val(lblState.Text), "Fixed")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblGross.Text = String.Empty
        lblFwt.Text = String.Empty
        lblFICA.Text = String.Empty
        lblState.Text = String.Empty
        lblNet.Text = String.Empty
        TxtHours.Text = "0.00"
        txtPayRate.Text = "0.00"

        txtName.Text = String.Empty


    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class
