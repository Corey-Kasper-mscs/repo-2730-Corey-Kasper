' Name:         Treeline 1f1
' Purpose:      Display the total room charge, tax, 
'               total resort fee, and total due
' Programmer:   Corey Kasper on 10/19/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) _
        Handles txtRooms.TextChanged, txtNights.TextChanged,
        txtAdults.TextChanged, txtChildren.TextChanged
        ' clear calculated amounts

        lblRoomChg.Text = String.Empty
        lblTax.Text = String.Empty
        lblResortFee.Text = String.Empty
        lblTotalDue.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculate and display total room charge

        Const intMAX_PER_ROOM As Integer = 6
        Const dblDAILY_ROOM_CHG As Double = 225.5
        Const dblTAX_RATE As Double = 0.1625
        Const dblDAILY_RESORT_FEE As Double = 12.5
        Const strMSG As String = "You have execeeded the maximum guest per room."
        Dim intRoomReserved As Integer
        Dim intNights As Integer
        Dim intAdults As Integer
        Dim intChildren As Integer
        Dim intNumGuest As Integer
        Dim dblRoomsRequired As Double
        Dim dblTotalRoomChg As Double
        Dim dblTax As Double
        Dim dblTotalResortFee As Double
        Dim dblTotalDue As Double

        'Store input in variables
        Integer.TryParse(txtRooms.Text, intRoomReserved)
        Integer.TryParse(txtNights.Text, intNights)
        Integer.TryParse(txtAdults.Text, intAdults)
        Integer.TryParse(txtChildren.Text, intChildren)

        'Calculate total number of guest
        intNumGuest = intAdults + intChildren
        'Calculate number of rooms
        dblRoomsRequired = intNumGuest / intMAX_PER_ROOM

        'determine whether number of reserved rooms is
        'adequate and then either display a message or
        'calculate and display the charges
        If intRoomReserved < dblRoomsRequired Then
            MessageBox.Show(strMSG, "Treeline Resort", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'calclate charges
            dblTotalRoomChg = intRoomReserved * intNights * dblDAILY_ROOM_CHG
            dblTax = dblTotalRoomChg * dblTAX_RATE
            dblTotalResortFee = intRoomReserved * intNights * dblDAILY_RESORT_FEE
            dblTotalDue = dblTotalRoomChg + dblTax + dblTotalResortFee

            'display charges
            lblRoomChg.Text = dblTotalRoomChg.ToString("n2")
            lblTax.Text = dblTax.ToString("n2")
            lblResortFee.Text = dblTotalResortFee.ToString("n2")
            lblTotalDue.Text = dblTotalDue.ToString("n2")
        End If



    End Sub

    Private Sub Cancel_keys(sender As Object, e As KeyPressEventArgs) Handles txtRooms.KeyPress,
        txtAdults.KeyPress, txtChildren.KeyPress, txtNights.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back Then
            'Cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub txtRooms_Enter(sender As Object, e As EventArgs) Handles txtRooms.Enter
        txtRooms.SelectAll()
    End Sub

    Private Sub txtNights_Enter(sender As Object, e As EventArgs) Handles txtNights.Enter
        txtNights.SelectAll()
    End Sub

    Private Sub txtAdults_Enter(sender As Object, e As EventArgs) Handles txtAdults.Enter
        txtAdults.SelectAll()
    End Sub

    Private Sub txtChildren_Enter(sender As Object, e As EventArgs) Handles txtChildren.Enter
        txtChildren.SelectAll()
    End Sub
End Class
