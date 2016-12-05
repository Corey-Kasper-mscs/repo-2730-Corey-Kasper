' Name:         Conversion Solution
' Purpose:      Convert a measurement to either centimeters or inches
' Programmer:   Corey Kasper

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtMeasurement_Enter(sender As Object, e As EventArgs) Handles txtMeasurement.Enter
        txtMeasurement.SelectAll()
    End Sub

    Private Sub txtMeasurement_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMeasurement.KeyPress, txtEarthsweight.KeyPress
        ' allow only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub



    Private Sub InputChange(sender As Object, e As EventArgs) _
        Handles txtMeasurement.TextChanged, radFuncCentimeters.CheckedChanged, radFuncInches.CheckedChanged,
        radSubCentimeters.CheckedChanged, radSubInches.CheckedChanged

        Dim dblMeasurment As Double = 0.0
        Dim dblResult As Double = 0.0

        Double.TryParse(txtMeasurement.Text, dblMeasurment)

        If radSubCentimeters.Checked Then
            CalcCentimetersSub(dblMeasurment, dblResult)
        ElseIf radSubInches.Checked Then
            CalcInchesSub(dblMeasurment, dblResult)
        ElseIf radFuncCentimeters.Checked Then
            dblResult = CalcCentimetersFunc(dblMeasurment, dblResult)
        ElseIf radFuncInches.Checked Then
            dblResult = CalcInchesFunc(dblMeasurment, dblResult)
        End If

        lblResult.Text = dblResult.ToString("n2")
    End Sub

    Private Sub CalcCentimetersSub(ByVal dblMeas As Double, ByRef dblRes As Double)
        dblRes = dblMeas * 2.54
    End Sub

    Private Sub CalcInchesSub(ByRef dblMeas As Double, ByRef dblRes As Double)
        dblRes = dblMeas * 0.393
    End Sub

    Public Function CalcCentimetersFunc(ByVal dblmeas As Double, ByVal dblRes As Double) As Double
        Dim dblFun As Double
        dblFun = dblmeas * 2.54
        Return dblFun
    End Function

    Public Function CalcInchesFunc(ByVal dblmeas As Double, ByVal dblRes As Double) As Double
        Dim dblFun As Double
        dblFun = dblmeas * 0.393
        Return dblFun
    End Function

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        cobWeightOn.Items.Add("Earth")
        cobWeightOn.Items.Add("Jupiter")
        cobWeightOn.Items.Add("Mars")
        cobWeightOn.Items.Add("Mercury")
        cobWeightOn.Items.Add("Neptune")
        cobWeightOn.Items.Add("Pluto")
        cobWeightOn.Items.Add("Saturn")
        cobWeightOn.Items.Add("Uranus")
        cobWeightOn.Items.Add("Venus")
        cobWeightOn.Text = "Earth"


    End Sub
    Private Sub InputChangeWeight(sender As Object, e As EventArgs) _
        Handles radFunWeight.CheckedChanged, radSubWeight.CheckedChanged, txtEarthsweight.TextChanged, cobWeightOn.TextChanged

        Dim intWeight As Integer = 100
        Dim dblWeight As Double
        Dim strWeight As String
        'Dim dblWeight As Double

        strWeight = cobWeightOn.Text
        'Double.TryParse(txtEarthsweight.Text, intWeight)

        If radSubWeight.Checked Then
            subWeight(intWeight, dblWeight)
            lblWeightTotal.Text = dblWeight.ToString()
        ElseIf radFunWeight.Checked Then
            'funWeight(intWeight, dblWeight)
            dblWeight = funWeight(intWeight, dblWeight)
            lblWeightTotal.Text = dblWeight.ToString()
        End If



    End Sub
    Private Sub subWeight(ByVal intWeight As Integer, ByRef dblWeight As Double)


        Integer.TryParse(txtEarthsweight.Text, intWeight)
        Select Case cobWeightOn.Text
            Case "Earth"
                dblWeight = intWeight
            Case "Mercury"
                dblWeight = intWeight * 0.38
            Case "Mars"
                dblWeight = intWeight * 0.38
            Case "Venus"
                dblWeight = intWeight * 0.91
            Case "Jupiter"
                dblWeight = intWeight * 2.34
            Case "Saturn"
                dblWeight = intWeight * 1.06
            Case "Uranus"
                dblWeight = intWeight * 0.92
            Case "Neptune"
                dblWeight = intWeight * 1.14
            Case "Pluto"
                dblWeight = intWeight * 0.06
        End Select


    End Sub

    Public Function funWeight(ByVal intWeight As Integer, ByVal dblWeight As Double) As Double

        Integer.TryParse(txtEarthsweight.Text, intWeight)
        Select Case cobWeightOn.Text
            Case "Earth"
                dblWeight = intWeight
            Case "Mercury"
                dblWeight = intWeight * 0.38
            Case "Mars"
                dblWeight = intWeight * 0.38
            Case "Venus"
                dblWeight = intWeight * 0.91
            Case "Jupiter"
                dblWeight = intWeight * 2.34
            Case "Saturn"
                dblWeight = intWeight * 1.06
            Case "Uranus"
                dblWeight = intWeight * 0.92
            Case "Neptune"
                dblWeight = intWeight * 1.14
            Case "Pluto"
                dblWeight = intWeight * 0.06
        End Select

        Return dblWeight
    End Function

    Private Sub txtEarthsweight_Enter(sender As Object, e As EventArgs) Handles txtEarthsweight.Enter
        txtEarthsweight.SelectAll()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
