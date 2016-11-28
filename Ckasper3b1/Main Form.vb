' Name:         Multiplication Project
' Purpose:      Display a multiplication table that shows
'               the multiplicand, multiplier, and product
' Programmer:   Corey Kasper on 11/22/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Const dblTaxRate As Double = 0.05

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        ' displays a multiplication table
        Dim number, product, count As Integer
        lstMutTable.Items.Clear()
        lstMutTable.Items.Add("For Loop:")
        Integer.TryParse(txtNumber.Text, number)
        'for loop
        Dim intcode As Integer = 1

        Do While intcode < 10
            count = intcode
            product = number * count

            Dim strOutput As String = "    " & number.ToString() & " * " & count.ToString() & " = " & product.ToString()
            lstMutTable.Items.Add(strOutput)
            'add strOutput to list box
            intcode = intcode + 1
        Loop
    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' displays a multiplication table
        ' displays a multiplication table
        Dim number, product, count As Integer
        lstMutTable.Items.Clear()
        lstMutTable.Items.Add("For Loop:")
        Integer.TryParse(txtNumber.Text, number)
        'for loop


        For intcode As Integer = 1 To 9
            count = intcode
            product = number * count

            Dim strOutput As String = "    " & number.ToString() & " * " & count.ToString() & " = " & product.ToString()
            lstMutTable.Items.Add(strOutput)
            'add strOutput to list box
        Next intcode

    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        ' allows only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        lstMutTable.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load listbox with test data
        '   repeat for each number 1 to 4
        '       add the number to the list box
        Dim intLoadList As Integer = 1
        Dim dblPretaxtotal As Double = 0
        Dim strSelectedPrices As String
        Dim dblSelectedPrice, dblTotalPrice As Double
        Dim dblTaxamount As Double
        'Dim intTesting As Integer

        Do While intLoadList < 5

            'lstPrices.SelectedIndex = intLoadList
            lstPrices.Items.Add(intLoadList)
            dblPretaxtotal = dblPretaxtotal + intLoadList
            intLoadList = intLoadList + 1

        Loop

        dblTaxamount = dblPretaxtotal * dblTaxRate
        dblTotalPrice = dblTaxamount + dblPretaxtotal

        lstPrices.SelectedIndex = -1
        lblPretax.Text = dblPretaxtotal.ToString()
        lblTax.Text = dblTaxamount.ToString()
        lblTotal.Text = dblTotalPrice.ToString()
        'calculate pretax total
        '   'decale dblpretaxtotal and initialize to 0
        '   repeat for each index 0 to lstPrices.items.count - 1
        '       set ListBox SelectedIndex to index
        '       set strSelectedPrices to double and set dblSelectedPrice
        '       Add dblSelected Price to dblPretaxTotal
        '   next index






        '   display dblPretaxTotal
        '   Calculate and display dblTax
        '   Calculate and display dblTotal
        '   Deselect ListBox items

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'get strPrice using inputbox
        Dim strPrice As String
        Dim dblPrice As Double
        Dim intLoadList As Integer = 1
        Dim intSUM As Integer
        Dim dblPretaxtotal As Double = 0
        Dim strSelectedPrices As String
        Dim dblSelectedPrice, dblTotalPrice, dblListitems As Double
        Dim dblTaxamount As Double

        strPrice = InputBox("Enter value from 1 - 9.99", "title", "1")
        Double.TryParse(strPrice, dblPrice)
        'convert strPrice to double: dblPrice
        'repeat as long as price is invaild: outside range of 1 - 9.99
        If dblPrice > 1 And dblPrice < 10 Then
            lstPrices.Items.Add(dblPrice)
        Else
            MessageBox.Show("Enter Value from 1 to 9.99", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dblPrice = 0
        End If
        '   get strPrice using inputBox
        '   Convert strPrice to double: dblPrice
        'end repeat
        'add dblPrice to listbox
        'Calculate and display totals , copy display from other sub

        Do While intLoadList < 5

            'lstPrices.SelectedIndex = intLoadList
            'lstPrices.Items.Add(intLoadList)
            dblPretaxtotal = dblPretaxtotal + intLoadList
            intLoadList = intLoadList + 1

        Loop
        dblPretaxtotal = dblPretaxtotal + dblPrice
        dblTaxamount = dblPretaxtotal * dblTaxRate
        dblTotalPrice = dblTaxamount + dblPretaxtotal

        lstPrices.SelectedIndex = -1
        lblPretax.Text = dblPretaxtotal.ToString()
        lblTax.Text = dblTaxamount.ToString()
        lblTotal.Text = dblTotalPrice.ToString()

        'add press down key to remove list items
    End Sub

    Private Sub lstPrices_KeyDown(sender As Object, e As KeyEventArgs) Handles lstPrices.KeyDown

        Dim strPrice As String
        Dim dblPrice As Double
        Dim intLoadList As Integer = 1
        Dim intSUM As Integer
        Dim dblPretaxtotal As Double = 0
        Dim strSelectedPrices As String
        Dim dblSelectedPrice, dblTotalPrice, dblListitems As Double
        Dim dblTaxamount As Double


        If lstPrices.SelectedIndex <> -1 AndAlso (e.KeyCode = Keys.KeyCode.Back OrElse e.KeyCode = Keys.KeyCode.Delete) Then
            lstPrices.Items.RemoveAt(lstPrices.SelectedIndex)

            Do While intLoadList < 5

                'lstPrices.SelectedIndex = intLoadList
                'lstPrices.Items.Add(intLoadList)
                dblPretaxtotal = dblPretaxtotal + intLoadList
                intLoadList = intLoadList + 1

            Loop
            dblPretaxtotal = dblPretaxtotal + dblPrice
            dblTaxamount = dblPretaxtotal * dblTaxRate
            dblTotalPrice = dblTaxamount + dblPretaxtotal

            lstPrices.SelectedIndex = -1
            lblPretax.Text = dblPretaxtotal.ToString()
            lblTax.Text = dblTaxamount.ToString()
            lblTotal.Text = dblTotalPrice.ToString()
        End If
    End Sub
End Class
