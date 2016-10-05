'Name:          Data Types
'Purpose:       Test Data Types
'Programmer:    Corey Kasper 10/3/2016

Option Strict On
Option Explicit On
Option Infer Off

Public Class Form1
    'Added btn(+,-,*,/)
    '   BtnDisplay_click(Nothing, Nothing)
    '   On Error Resume Next
    '       After Private Sub
    'Byte3 = byte1 + byte2: Then dispay byte

    Private String1, String2, String3 As String
    Private Byte1, Byte2, Byte3 As Byte
    Private Short1, Short2, Short3 As Short
    Private Integer1, Integer2, Integer3 As Integer
    Private Long1, Long2, Long3 As Long
    Private Single1, Single2, Single3 As Single
    Private double1, double2, double3 As Double
    Private decimal1, decimal2, decimal3 As Decimal
    Private date1, date2 As Date
    Private Timespan2 As TimeSpan

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        btnDisplay_Click(Nothing, Nothing)
        On Error Resume Next

        String3 = String1 + String2
        lblString3.Text = String3
        Byte3 = Byte1 + Byte2
        lblByte3.Text = Byte3.ToString()
        Short3 = Short1 + Short2
        lblShort3.Text = Short3.ToString()
        Integer3 = Integer1 + Integer2
        lblInteger3.Text = Integer3.ToString()
        Long3 = Long1 + Long2
        lblLong3.Text = Long3.ToString()
        Single3 = Single1 + Single2
        lblSingle3.Text = Single3.ToString()
        double3 = double1 + double2
        lblDouble3.Text = double3.ToString()
        decimal3 = decimal1 + decimal2
        lblDecimal3.Text = decimal3.ToString()

    End Sub

    Private Sub btnTimes_Click(sender As Object, e As EventArgs) Handles btnTimes.Click
        btnDisplay_Click(Nothing, Nothing)
        On Error Resume Next
        'String3 = String1 * String2
        'lblString3.Text = String3
        Byte3 = Byte1 * Byte2
        lblByte3.Text = Byte3.ToString()
        Short3 = Short1 * Short2
        lblShort3.Text = Short3.ToString()
        Integer3 = Integer1 * Integer2
        lblInteger3.Text = Integer3.ToString()
        Long3 = Long1 * Long2
        lblLong3.Text = Long3.ToString()
        Single3 = Single1 * Single2
        lblSingle3.Text = Single3.ToString()
        double3 = double1 * double2
        lblDouble3.Text = double3.ToString()
        decimal3 = decimal1 * decimal2
        lblDecimal3.Text = decimal3.ToString()
    End Sub

    Private Sub btnDivid_Click(sender As Object, e As EventArgs) Handles btnDivid.Click
        btnDisplay_Click(Nothing, Nothing)
        On Error Resume Next
        'String3 = String1 / String2
        'lblString3.Text = String3
        Byte3 = Byte1 / Byte2
        lblByte3.Text = Byte3.ToString()
        Short3 = Short1 / Short2
        lblShort3.Text = Short3.ToString()
        Integer3 = Integer1 / Integer2
        lblInteger3.Text = Integer3.ToString()
        Long3 = Long1 / Long2
        lblLong3.Text = Long3.ToString()
        Single3 = Single1 / Single2
        lblSingle3.Text = Single3.ToString()
        double3 = double1 / double2
        lblDouble3.Text = double3.ToString()
        decimal3 = decimal1 / decimal2
        lblDecimal3.Text = decimal3.ToString()
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        btnDisplay_Click(Nothing, Nothing)
        On Error Resume Next
        'String3 = String1 - String2
        'lblString3.Text = String3
        Byte3 = Byte1 - Byte2
        lblByte3.Text = Byte3.ToString()
        Short3 = Short1 - Short2
        lblShort3.Text = Short3.ToString()
        Integer3 = Integer1 - Integer2
        lblInteger3.Text = Integer3.ToString()
        Long3 = Long1 - Long2
        lblLong3.Text = Long3.ToString()
        Single3 = Single1 - Single2
        lblSingle3.Text = Single3.ToString()
        double3 = double1 - double2
        lblDouble3.Text = double3.ToString()
        decimal3 = decimal1 - decimal2
        lblDecimal3.Text = decimal3.ToString()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'Literal type Char, S=short I=Integer, L=long, D=Decimal 0.0D, F=single, R=double 0.0, 
        String1 = String.Empty
        String2 = String.Empty
        String3 = String.Empty
        Byte1 = 0
        Byte2 = 0
        Short1 = 0S
        Short2 = 0S
        Integer1 = 0I
        Integer2 = 0I
        Long1 = 0L
        Long2 = 0L
        decimal1 = 0.0D
        decimal2 = 0.0D
        Single1 = 0F
        Single2 = 0F
        double1 = 0.0R
        double2 = 0.0R

        lblByte3.Text = String.Empty
        lblDate3.Text = String.Empty
        lblDecimal3.Text = String.Empty
        lblDouble3.Text = String.Empty
        lblInteger3.Text = String.Empty
        lblLong3.Text = String.Empty
        lblShort3.Text = String.Empty
        lblSingle3.Text = String.Empty
        lblString3.Text = String.Empty

        String1 = txtInput1.Text
        String2 = txtInput2.Text
        lblString1.Text = String1
        lblString2.Text = String2

        Byte.TryParse(txtInput1.Text, Byte1)
        Byte.TryParse(txtInput2.Text, Byte2)
        lblByte1.Text = Byte1.ToString()
        lblByte2.Text = Byte2.ToString()

        Short.TryParse(txtInput1.Text, Short1)
        Short.TryParse(txtInput2.Text, Short2)
        lblShort1.Text = Short1.ToString()
        lblShort2.Text = Short2.ToString()

        Integer.TryParse(txtInput1.Text, Integer1)
        Integer.TryParse(txtInput2.Text, Integer2)
        lblInteger1.Text = Integer1.ToString()
        lblInteger2.Text = Integer2.ToString()

        Long.TryParse(txtInput1.Text, Long1)
        Long.TryParse(txtInput2.Text, Long2)
        lblLong1.Text = Long1.ToString()
        lblLong2.Text = Long2.ToString()

        Single.TryParse(txtInput1.Text, Single1)
        Single.TryParse(txtInput2.Text, Single2)
        lblSingle1.Text = Single1.ToString()
        lblSingle2.Text = Single2.ToString()

        Double.TryParse(txtInput1.Text, double1)
        Double.TryParse(txtInput2.Text, double2)
        lblDouble1.Text = double1.ToString()
        lblDouble2.Text = double2.ToString()

        Decimal.TryParse(txtInput1.Text, decimal1)
        Decimal.TryParse(txtInput2.Text, decimal2)
        lblDecimal1.Text = decimal1.ToString()
        lblDecimal2.Text = decimal2.ToString()

        Date.TryParse(txtInput1.Text, date1)
        Date.TryParse(txtInput2.Text, date2)
        TimeSpan.TryParse(txtInput2.Text, Timespan2)
        lblDate1.Text = date1.ToString()
        lblDate2.Text = date2.ToString()


    End Sub
End Class
