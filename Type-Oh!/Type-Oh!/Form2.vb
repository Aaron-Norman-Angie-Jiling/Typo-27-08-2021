Public Module quakee
    Public quakeStatus As Boolean = False
    Public flashStatus As Boolean = False
End Module


Public Class Form2
    Function switchForms()
        Form1.Show()
        Me.Hide()
    End Function
    Private Sub btnToGame_Click(sender As Object, e As EventArgs) Handles btnToGame.Click
        switchForms()
    End Sub

    Private Sub btnShake_Click(sender As Object, e As EventArgs) Handles btnShake.Click
        switchForms()
        quakeStatus = True
        Form3.Show()
    End Sub

    Private Sub btnBlackOut_Click(sender As Object, e As EventArgs) Handles btnBlackOut.Click
        flashStatus = True
        switchForms()
    End Sub
End Class