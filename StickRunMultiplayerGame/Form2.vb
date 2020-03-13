Imports System.Net.Sockets
Public Class Form2
    Dim clientSocket As New TcpClient()
    Dim serverStream As NetworkStream
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        msg("Client Started")
        clientSocket.Connect("127.0.0.1", 8888)
    End Sub
    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        Me.Hide()
        Dim play As Form1
        play = New Form1
        play.Show()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Dispose()
        clientSocket.Close()
        Me.Close()
    End Sub

    Sub msg(ByVal mesg As String)
        Console.WriteLine(mesg)
    End Sub

End Class