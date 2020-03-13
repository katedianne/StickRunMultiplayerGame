Imports System.Net.Sockets
Imports System.Text

Module ServerSocket

    Sub Main()
        Dim strHostName As String
        strHostName = Net.Dns.GetHostName()

        Dim serverSocket As New TcpListener(Net.Dns.GetHostEntry(strHostName).AddressList(0), 8888)
        Dim clientSocket As TcpClient
        Dim counter As Integer

        serverSocket.Start()
        Msg("Server Started at : " & strHostName & " " & Net.Dns.GetHostEntry(strHostName).AddressList(0).ToString)
        counter = 0
        clientSocket = Nothing
        While (True)
            counter += 1
            clientSocket = serverSocket.AcceptTcpClient()
            Msg("Client No:" + Convert.ToString(counter) + " started!")
            Dim client As New handleClient
            client.startClient(clientSocket, Convert.ToString(counter))
        End While

        clientSocket.Close()
        serverSocket.Stop()
        Msg("exit")
        Console.ReadLine()
    End Sub

    Sub Msg(ByVal message As String)
        message.Trim()
        Console.WriteLine(" >> " + message)
    End Sub

    Public Class handleClient
        Dim clientSocket As TcpClient
        Dim clNo As String
        Public Sub startClient(ByVal inClientSocket As TcpClient,
        ByVal clineNo As String)
            Me.clientSocket = inClientSocket
            Me.clNo = clineNo
            Dim ctThread As Threading.Thread = New Threading.Thread(AddressOf doChat)
            ctThread.Start()
        End Sub
        Private Sub doChat()
            Dim requestCount As Integer
            Dim bytesFrom(10024) As Byte
            Dim dataFromClient As String
            Dim sendBytes As [Byte]()
            Dim serverResponse As String
            Dim rCount As String
            requestCount = 0

            While (True)
                Try
                    requestCount = requestCount + 1
                    Dim networkStream As NetworkStream = clientSocket.GetStream()
                    networkStream.Read(bytesFrom, 0, CInt(clientSocket.ReceiveBufferSize))
                    dataFromClient = Encoding.ASCII.GetString(bytesFrom)
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"))
                    Msg("From client-" + clNo + dataFromClient)
                    rCount = Convert.ToString(requestCount)
                    serverResponse = "Server to clinet(" + clNo + ") " + rCount
                    sendBytes = Encoding.ASCII.GetBytes(serverResponse)
                    networkStream.Write(sendBytes, 0, sendBytes.Length)
                    networkStream.Flush()
                    Msg(serverResponse)
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End While
        End Sub
    End Class
End Module
