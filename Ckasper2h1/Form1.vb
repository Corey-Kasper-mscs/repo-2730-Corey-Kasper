' Name:         Marshal sales
' Purpose:      Display the commisions
' Programmer:   Corey Kasper on 10/24/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSales.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> "." AndAlso
            e.KeyChar <> ControlChars.Back Then
            'Cancel the key
            e.Handled = True
        End If
    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnIfThen_Click(sender As Object, e As EventArgs) Handles btnIfThen.Click
        lblAdditionalAmount.Text = String.Empty
        lblCommissions.Text = String.Empty
        lblTotalCommiss.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalCommission As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number formate Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If boolSalesOK AndAlso dblSales < 1.0 Then
            dblCommissionOnly = 0.0
        End If

        If boolSalesOK AndAlso dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
            dblCommissionOnly = dblSales * 0.1
        End If

        If boolSalesOK AndAlso dblSales >= 6000.0 AndAlso dblSales < 30000.0 Then
            dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
        End If
        If boolSalesOK AndAlso dblSales >= 30000.0 Then
            dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
        End If
        '4 above is what to change

        If chkOverTenYears.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTravelling.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalCommission = dblCommissionOnly + dblAdditional

        If boolSalesOK Then
            lblCommissions.Text = dblCommissionOnly.ToString("c2")
            lblAdditionalAmount.Text = dblAdditional.ToString("c2")
            lblTotalCommiss.Text = dblTotalCommission.ToString("c2")
        End If

        txtSales.Focus()
    End Sub



    Private Sub CleartextChange(sender As Object, e As EventArgs) Handles txtSales.TextChanged, chkOverTenYears.CheckedChanged, chkTravelling.CheckedChanged
        lblAdditionalAmount.Text = String.Empty
        lblCommissions.Text = String.Empty
        lblTotalCommiss.Text = String.Empty

    End Sub

    Private Sub btnNestedIf_Click(sender As Object, e As EventArgs) Handles btnNestedIf.Click
        lblAdditionalAmount.Text = String.Empty
        lblCommissions.Text = String.Empty
        lblTotalCommiss.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalCommission As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number formate Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'Changed part
        If boolSalesOK AndAlso dblSales < 1.0 Then
            dblCommissionOnly = 0.0
        Else
            If dblSales < 6000.0 Then
                dblCommissionOnly = dblSales * 0.1
            Else
                If dblSales < 30000.0 Then
                    dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
                Else
                    If dblSales >= 30000.0 Then
                        dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14

                    End If
                End If
            End If
        End If

        'If boolSalesOK AndAlso dblSales < 1.0 Then
        '    dblCommissionOnly = 0.0
        'End If

        'If boolSalesOK AndAlso dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
        '    dblCommissionOnly = dblSales * 0.1
        'End If

        'If boolSalesOK AndAlso dblSales >= 6000.0 AndAlso dblSales < 30000.0 Then
        '    dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
        'End If
        'If boolSalesOK AndAlso dblSales >= 30000.0 Then
        '    dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
        'End If


        If chkOverTenYears.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTravelling.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalCommission = dblCommissionOnly + dblAdditional

        If boolSalesOK Then
            lblCommissions.Text = dblCommissionOnly.ToString("c2")
            lblAdditionalAmount.Text = dblAdditional.ToString("c2")
            lblTotalCommiss.Text = dblTotalCommission.ToString("c2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub btnIfElseIF_Click(sender As Object, e As EventArgs) Handles btnIfElseIF.Click
        lblAdditionalAmount.Text = String.Empty
        lblCommissions.Text = String.Empty
        lblTotalCommiss.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalCommission As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number formate Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If boolSalesOK AndAlso dblSales < 1.0 Then
            dblCommissionOnly = 0.0
        ElseIf dblSales < 6000.0 Then
            dblCommissionOnly = dblSales * 0.1
        ElseIf dblSales < 30000.0 Then
            dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
        ElseIf dblSales >= 30000.0 Then
            dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14

                    End If

        '4 above is what to change

        If chkOverTenYears.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTravelling.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalCommission = dblCommissionOnly + dblAdditional

        If boolSalesOK Then
            lblCommissions.Text = dblCommissionOnly.ToString("c2")
            lblAdditionalAmount.Text = dblAdditional.ToString("c2")
            lblTotalCommiss.Text = dblTotalCommission.ToString("c2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub btnSelectCase_Click(sender As Object, e As EventArgs) Handles btnSelectCase.Click
        lblAdditionalAmount.Text = String.Empty
        lblCommissions.Text = String.Empty
        lblTotalCommiss.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalCommission As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid input", "Number formate Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If boolSalesOK Then
            Select Case dblSales
                Case 0 To 0.9
                    dblCommissionOnly = 0.0
                Case 1.0 To 5999.99
                    dblCommissionOnly = dblSales * 0.1
                Case 6000 To 29999.99
                    dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
                Case Else
                    dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
            End Select
        End If


        If chkOverTenYears.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTravelling.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalCommission = dblCommissionOnly + dblAdditional

        If boolSalesOK Then
            lblCommissions.Text = dblCommissionOnly.ToString("c2")
            lblAdditionalAmount.Text = dblAdditional.ToString("c2")
            lblTotalCommiss.Text = dblTotalCommission.ToString("c2")
        End If

        txtSales.Focus()
    End Sub
End Class
