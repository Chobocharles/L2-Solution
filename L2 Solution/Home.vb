Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 5000
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        frmPageTwo.Show()
        Me.Hide()
        Timer1.Stop()
    End Sub


End Class