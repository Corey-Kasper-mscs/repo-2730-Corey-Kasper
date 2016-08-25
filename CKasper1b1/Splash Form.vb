Public Class frmSplash
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub tmrExit_Tick(sender As Object, e As EventArgs) Handles tmrExit.Tick
        Me.Close()
    End Sub
End Class
