' Name:         3a1, Loops
' Purpose:      Learning how to loop p 371 #13, p 
' Programmer:   <Corey Kasper> on 11/15/2016

Option Strict On
Option Explicit On
Option Infer Off

Public Class Form1
    Private Sub btnPretestDoWhile_Click(sender As Object, e As EventArgs) Handles btnPretestDoWhile.Click
        'PreTest Do while
        lbl347num13.Text = "Prestest Do While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do While i <= 20
            lbl347num13.Text = lbl347num13.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop
    End Sub

    Private Sub btnPretestDoUntil_Click(sender As Object, e As EventArgs) Handles btnPretestDoUntil.Click
        'PreTest Do Until
        lbl347num13.Text = "Prestest Do Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do Until i > 20
            lbl347num13.Text = lbl347num13.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop
    End Sub

    Private Sub btnPostLoopWhile_Click(sender As Object, e As EventArgs) Handles btnPostLoopWhile.Click
        'Post Loop While
        lbl347num13.Text = "Post While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lbl347num13.Text = lbl347num13.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop While i <= 20
    End Sub

    Private Sub btnPostLoopUntil_Click(sender As Object, e As EventArgs) Handles btnPostLoopUntil.Click
        ' Post Loop Until
        lbl347num13.Text = "Post Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lbl347num13.Text = lbl347num13.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop Until i > 20
    End Sub

    Private Sub btnPretestFor_Click(sender As Object, e As EventArgs) Handles btnPretestFor.Click
        ' PreTest For
        lbl347num13.Text = "Prestest Do While" & ControlChars.NewLine
        Dim i As Integer = 2
        For i = 2 To 20 Step 2
            lbl347num13.Text = lbl347num13.Text & i.ToString & ControlChars.NewLine

        Next
    End Sub

    Private Sub btnSumDoWhile_Click(sender As Object, e As EventArgs) Handles btnSumDoWhile.Click
        lblCount.Text = String.Empty
        lblAverage.Text = String.Empty
        lblListNum22.Text = String.Empty
        'calc average
        Const strPROMPT As String =
            "Enter a number." &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer = 0
        Dim dblAVG As Double



        'Get first sales amount
        strNum = InputBox(strPROMPT, strTITLE, "0")

        'Start loop here!
        Do While strNum <> ""

            Int32.TryParse(strNum, intNum)
                lblListNum22.Text = lblListNum22.Text &
                intNum.ToString & ControlChars.NewLine

                intCount = intCount + 1
            intSum = intSum + intNum

            strNum = InputBox(strPROMPT, strTITLE, "0")

            'Loop
            ' Update control variable
            'End Loop!!!
        Loop
        'End If
        lblCount.Text = intCount.ToString

        If intCount > 0 Then
            dblAVG = intSum / intCount
            lblAverage.Text = dblAVG.ToString("n2")
        Else
            lblAverage.Text = "N/A"
        End If

    End Sub

    Private Sub btnSumLoopUntil_Click(sender As Object, e As EventArgs) Handles btnSumLoopUntil.Click
        lblCount.Text = String.Empty
        lblAverage.Text = String.Empty
        lblListNum22.Text = String.Empty
        'calc average
        Const strPROMPT As String =
            "Enter a number." &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer = 0
        Dim dblAVG As Double



        'Get first sales amount
        strNum = InputBox(strPROMPT, strTITLE, "0")

        'Start loop here!
        Do

            Int32.TryParse(strNum, intNum)
            lblListNum22.Text = lblListNum22.Text &
                intNum.ToString & ControlChars.NewLine

            intCount = intCount + 1
            intSum = intSum + intNum

            strNum = InputBox(strPROMPT, strTITLE, "0")

            'Loop
            ' Update control variable
            'End Loop!!!
        Loop Until strNum = ""
        'End If
        lblCount.Text = intCount.ToString

        If intCount > 0 Then
            dblAVG = intSum / intCount
            lblAverage.Text = dblAVG.ToString("n2")
        Else
            lblAverage.Text = "N/A"
        End If

    End Sub

    Private Sub btnSumForNext_Click(sender As Object, e As EventArgs) Handles btnSumForNext.Click
        lblCount.Text = String.Empty
        lblAverage.Text = String.Empty
        lblListNum22.Text = String.Empty
        'calc average
        Const strPROMPT As String =
            "Enter a number." &
            ControlChars.NewLine &
            "Click Cancel or leave blank to end."
        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer = 0
        Dim dblAVG As Double
        Dim intNew As Integer
        Dim intText As Integer
        Dim strNew As String



        'Get first sales amount
        strNew = InputBox("How Many?", strTITLE, "0")
        Integer.TryParse(strNew, intNew)
        'strNum = InputBox(strPROMPT, strTITLE, "0")

        'Start loop here!
        For intText = 1 To intNew

            strNum = InputBox(strPROMPT, strTITLE, "0")

            Int32.TryParse(strNum, intNum)
            lblListNum22.Text = lblListNum22.Text &
                intNum.ToString & ControlChars.NewLine

            intCount = intCount + 1
            intSum = intSum + intNum



            'Loop
            ' Update control variable
            'End Loop!!!
        Next
        'End If
        lblCount.Text = intCount.ToString

        If intCount > 0 Then
            dblAVG = intSum / intCount
            lblAverage.Text = dblAVG.ToString("n2")
        Else
            lblAverage.Text = "N/A"
        End If

    End Sub
End Class
