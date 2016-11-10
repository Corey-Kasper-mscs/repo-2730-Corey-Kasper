' Name:         Chapter 8, String functions, list boxes
' Purpose:      #2: Interprets color code
'               #5: Sets proper upper/lower case
'               #6: Interprets shipping code
' Programmer:   <Corey Kasper> on 11/9/2016

Option Strict On
Option Explicit On
Option Infer Off

Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ItemNumbers_TextChanged(sender As Object, e As EventArgs) _
            Handles txtItem1.TextChanged, txtItem2.TextChanged, txtItem3.TextChanged, txtItem4.TextChanged, txtItem5.TextChanged
        lstColors.Items.Clear()
    End Sub

    Private Sub btnDisplayColor_Click(sender As Object, e As EventArgs) Handles btnDisplayColor.Click
        'Needs 7 charters else show error msg, 4th is color based off letter
        'b for blue, g for green, r for red, w for white
        'lstColors.Items.Add()
        DisplayColor(txtItem1.Text)
        DisplayColor(txtItem2.Text)
        DisplayColor(txtItem3.Text)
        DisplayColor(txtItem4.Text)
        DisplayColor(txtItem5.Text)
    End Sub

    Private Sub DisplayColor(ByVal itemNum As String)
        Dim intLength As Integer
        Dim strItems As String
        'lstColors.Items.Add(itemNum)
        intLength = itemNum.Length
        itemNum = itemNum.ToLower

        If intLength < 7 Then
            itemNum = ("invailed")
        ElseIf itemNum.Contains("w") Then
            strItems = "White"

        ElseIf itemNum.Contains("r") Then
            strItems = "Red"

        ElseIf itemNum.Contains("g") Then
            strItems = "Green"

        ElseIf itemNum.Contains("b") Then
            strItems = "Blue"

        Else
            strItems = "Invaild"
        End If

        lstColors.Items.Add(itemNum & ": " & strItems)
    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        txtName.SelectAll()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        lblName.Text = String.Empty
    End Sub

    Private Sub btnDisplayDelivery_Click(sender As Object, e As EventArgs) Handles btnDisplayDelivery.Click
        DisplayDelivery(txtPartNum1.Text)
        DisplayDelivery(txtPartNum2.Text)
        DisplayDelivery(txtPartNum3.Text)
        DisplayDelivery(txtPartNum4.Text)
        DisplayDelivery(txtPartNum5.Text)
        DisplayDelivery(txtPartNum6.Text)
    End Sub

    Private Sub DisplayDelivery(ByVal partNum As String)
        'ms mail standard, mp mail priority, fx fedex standard, fo fedex overnight, u ups, anything else Invaild
        'length is 3 or 4
        'lstDelivery.Items.Add("Mail - Standard")
        Dim intMailLen As Integer
        Dim strMailName As String

        intMailLen = partNum.Length
        partNum = partNum.ToLower()

        If intMailLen <= 2 Or intMailLen >= 5 Then
            strMailName = "Invaild"
        ElseIf partNum.Contains("ms") Then
            strMailName = "Mail - Standard"
        ElseIf partNum.Contains("mp") Then
            strMailName = "Mail - Priority"
        ElseIf partNum.Contains("fs") Then
            strMailName = "FedEx - Standard"
        ElseIf partNum.Contains("fo") Then
            strMailName = "FedEx - Overnight"
        ElseIf partNum.Contains("u") Then
            strMailName = "UPS"
        Else
            strMailName = "Invaild"
        End If

        lstDelivery.Items.Add(strMailName)
    End Sub

    Private Sub PartNum_TextChanged(sender As Object, e As EventArgs) _
            Handles txtPartNum1.TextChanged, txtPartNum2.TextChanged, txtPartNum3.TextChanged, txtPartNum4.TextChanged, txtPartNum5.TextChanged, txtPartNum6.TextChanged
        lstDelivery.Items.Clear()
    End Sub

    'btnProper_Click pseudocode:
    '1) Convert txtName to lower case, store in strName
    '2) Use strName.Substring() to get first character of strName, convert to upper case, store in strFirstChar
    '3) Remove first character of strName
    '4) Insert strFirstChar at beginning of strName
    '5) Use strName.IndexOf() to find the space character. Add 1 and store in index
    '6) Repeat steps 2 - 4 to remove/insert first letter of last name

    Private Sub btnProper_Click(sender As Object, e As EventArgs) Handles btnProper.Click
        Dim strName As String = txtName.Text
        Dim strFirstChar As String
        Dim strSecChar As String
        Dim strNamefinal As String
        Dim strLastName As String
        Dim intName As Integer
        Dim intLengthName As Integer
        Dim intFirstname As Integer
        Dim strlastnamefinal As String
        Dim strFirstNameFinal As String

        If txtName.Text = ("") Then
            lblName.Text = "Invaild Name"
        Else
            intLengthName = strName.Length()

            'lower name, find frist char to upper, then remove 1st char
            strName = strName.ToLower()
            strFirstChar = strName.Substring(0, 1)
            strFirstChar = strFirstChar.ToUpper()
            strName = strName.Remove(0, 1)

            intName = strName.IndexOf(" ") + 1

            strLastName = strName.Substring(intName)

            strSecChar = strLastName.Substring(0, 1)
            strLastName = strLastName.Remove(0, 1)

            strSecChar = strSecChar.ToUpper()

            strlastnamefinal = strSecChar + strLastName

            intFirstname = intLengthName - intName - 1


            strNamefinal = strFirstChar + strName
            strFirstNameFinal = strNamefinal.Remove(intName)

            lblName.Text = strFirstNameFinal + " " + strlastnamefinal
        End If

    End Sub

End Class
