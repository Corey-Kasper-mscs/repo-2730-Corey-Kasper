' Name:         Bakery Project
' Purpose:      Calculates the total number of
'               items sold and the total sales
' Programmer:   Corey Kasper on 9/27/2016

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    ' Class-level veriable for storing salesclerk's name
    Private strClerk As String

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate number of items sold and total sales
        Const decITEM_PRICE As Decimal = 0.5D
        Const decTAX_Rate As Decimal = 0.02D
        Dim intDounts As Integer
        Dim intMuffins As Integer
        Dim intTotalItems As Integer
        Dim decSubtotal As Decimal
        Dim decSalesTax As Decimal
        Dim dectotalSales As Decimal
        Static strClerk As String

        Const strPROMPT As String = "Salesclerk's name:"
        Const strTITLE As String = "Name Entry"
        ' assign name to class-level variable
        strClerk = InputBox(strPROMPT, strTITLE, strClerk)

        Integer.TryParse(txtDonuts.Text, intDounts)
        Integer.TryParse(txtMuffins.Text, intMuffins)

        intTotalItems = intDounts + intMuffins

        'calculate the subtotal
        decSubtotal = intTotalItems * decITEM_PRICE

        ' calculate the sales tax
        decSalesTax = decSubtotal * decTAX_Rate

        ' calculate the total sales
        dectotalSales = decSubtotal + decSalesTax

        ' display total amounts
        lblTotalItems.Text = Convert.ToString(intTotalItems)
        lblTotalSales.Text = dectotalSales.ToString("C2")

        ' display tax and salesclerk's name
        lblMsg.Text = "The sales tax was " &
            decSalesTax.ToString("C2") & "." &
        ControlChars.NewLine & strClerk

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' prepare screen for the next sale

        txtDonuts.Text = String.Empty
        txtMuffins.Text = String.Empty
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        lblMsg.Text = String.Empty
        ' send the focus to the Doughnuts box
        txtDonuts.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'get the sakesclerk's Name

        'Const strPROMPT As String = "Salesclerk's name:"
        'Const strTITLE As String = "Name Entry"
        ' assign name to class-level variable
        'strClerk = InputBox(strPROMPT, strTITLE)
    End Sub

    Private Sub txtDonuts_TextChanged(sender As Object, e As EventArgs) Handles txtDonuts.TextChanged, txtMuffins.TextChanged
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        lblMsg.Text = String.Empty
    End Sub
End Class
