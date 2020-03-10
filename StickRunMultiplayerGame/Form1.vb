Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim time As Integer
        time += 1
        Move()

    End Sub

    Function Move()
        Obs1.Left -= 3
        Obs2.Left -= 3
        Obs3.Left -= 3
    End Function
End Class
