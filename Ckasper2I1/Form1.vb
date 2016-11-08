' Name:         Stringing stuff
' Purpose:      String Manipulation
' Programmer:   Corey Kasper on 11/5/2016

Option Explicit On
Option Strict On
Option Infer Off


Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        '03 Remove/insert
        Dim strWord As String = txt03.Text
        strWord = strWord.Remove(0, 1)
        strWord = strWord.Insert(0, "cr")
        lbl03.Text = strWord

        '04 Substring
        Dim strItem As String = txt04.Text
        Dim strColor As String
        strColor = strItem.Substring(2, 4)
        lbl04.Text = strColor

        '05a Length
        Dim strMSG As String = txt05a.Text
        Dim strSize As Integer
        strSize = strMSG.Length
        lbl05a.Text = strSize.ToString()

        '05b Trim
        Dim strState As String = txt05b.Text
        strState = strState.Trim
        lbl05b.Text = strState

        '05c Remove/insert
        Dim strWord05c As String = txt05c.Text
        strWord05c = strWord05c.Remove(1, 1)
        strWord05c = strWord05c.Insert(1, "rit")
        lbl05c.Text = strWord05c

        '05d insert
        Dim strDay As String = txt05d.Text
        strDay = strDay.Insert(0, "Mon")
        lbl05d.Text = strDay

        '05e Pad
        Dim strPad As String = txt05e.Text
        strPad = strPad.PadLeft(10, CChar("*"))
        lbl05e.Text = strPad

        '06 Remove
        Dim strAmount As String = txt06.Text
        strAmount = strAmount.Remove(1, 1)
        strAmount = strAmount.Remove(4, 1)
        lbl06.Text = strAmount

        '07 Contains
        Dim strAddress As String = txt07.Text
        Dim blnIsContained As Boolean = False

        strAddress = strAddress.ToLower
        If strAddress.Contains("jeff") Then
            blnIsContained = True
        End If

        If blnIsContained = True Then
            lbl07.Text = "Jeff St. Found"
        Else
            lbl07.Text = "Jeff St. Not Found"
        End If

        '12 Len/remove
        '*1000
        'Remove last 2 Chars!
        Dim str12Len As String = txt12.Text
        Dim int12Len As Integer
        Dim dec12Next As Decimal

        int12Len = str12Len.Length
        int12Len = int12Len - 2
        str12Len = str12Len.Remove(int12Len, 2)

        Decimal.TryParse(str12Len, dec12Next)

        dec12Next = (dec12Next / 100) * 1000

        lbl12.Text = dec12Next.ToString()


        '13 Like
        'if 605xx then 25 shiping
        'if 606xx then 30 shipping
        'else invalde zip
        Dim str13Life As String = txt13.Text

        If str13Life.Contains("605") Then
            lbl13.Text = "Shipping $30:"
        ElseIf str13Life.Contains("606") Then
            lbl13.Text = "Shipping $25:"
        Else
            lbl13.Text = "invaild Zip"
        End If


    End Sub

End Class
