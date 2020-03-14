Imports System.IO

Public Class Form1
    Dim movementSpeed As Integer = 0
    Dim count As Integer
    Dim jumpUp As Boolean = False
    Dim jumpDown As Boolean = False
    Dim slide As Boolean = False
    Dim obstacles_arr As ArrayList = New ArrayList()
    Dim players_arr As ArrayList = New ArrayList()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        GeneratePlayers()
        movementSpeed = 3

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        count += 20


        If count Mod 2000 = 0 Then
            movementSpeed += 1
        End If

        MoveObs(movementSpeed)
        Collision()

        'Generate obs every 2 seconds
        If count Mod 750 = 0 Then
            GenerateObs()
        End If


        MovePlayer()


    End Sub

    Class Obs
        Private xPosition As Integer
        Private yPosition As Integer
        Public Property UxPosition As Integer
            Get
                Return xPosition
            End Get
            Set(value As Integer)
                xPosition = value
            End Set
        End Property
        Public Property UyPosition As Integer
            Get
                Return yPosition
            End Get
            Set(value As Integer)
                yPosition = value
            End Set
        End Property
    End Class

    Function MovePlayer()
        For Each player_generated In players_arr
            If jumpUp = True Then
                player_generated.Top -= 13
            End If

            If player_generated.Top <= Platform.Top - player_generated.Height - 170 Then
                jumpUp = False
                jumpDown = True
            End If

            If jumpDown = True Then
                player_generated.Top += 5
                If player_generated.Bottom >= Platform.Top Then
                    player_generated.Top = Platform.Top - player_generated.Height
                    jumpDown = False
                End If
            End If
        Next


        'If slide = True Then
        '    Player.Height -= 10
        '    Player.Top = Platform.Top - Player.Height
        '    If Player.Height <= 40 Then
        '        Player.Height = 40
        '    End If
        'End If
    End Function


    Function MoveObs(movementSpeed)
        Dim removeOne As Boolean = False

        For Each _obs In obstacles_arr
            _obs.Left -= movementSpeed

            For Each player_generated In players_arr
                If _obs.Right <= player_generated.Left - 100 Then
                    _obs.Visible = False
                    removeOne = True
                End If
            Next

        Next

        If removeOne Then
            obstacles_arr.RemoveAt(0)
        End If
    End Function

    Function Collision()
        'If Obs1.Left <= Player.Left + Player.Width And Player.Top <= Obs1.Top + Obs1.Height And Player.Top + Player.Height >= Obs1.Top Then
        '    Timer1.Stop()
        '    MessageBox.Show("You're Dead!")
        'End If


        For Each _obs In obstacles_arr
            For Each player_generated In players_arr
                If _obs.Left <= player_generated.Right And player_generated.Top <= _obs.Bottom And player_generated.Bottom >= _obs.Top And player_generated.Left <= _obs.Right Then
                    Timer1.Stop()
                    MessageBox.Show("You're Dead!")
                End If
            Next
        Next
    End Function

    Function GeneratePlayers()
        Dim player As New PictureBox
        player.Parent = bg2
        player.BackColor = Color.Transparent
        player.ImageLocation = "C:\Users\Anne\source\repos\StickRunMultiplayerGame\StickRunMultiplayerGame\bin\Debug\pictures\Characters\Dex\Run\Run Dex.gif"
        player.BackgroundImageLayout = ImageLayout.Stretch
        player.Height = 65
        player.Width = 50
        player.Top = Platform.Top - player.Height
        player.Left = Me.Left + 10

        players_arr.Add(player)
        bg2.Controls.Add(player)
    End Function



    Function GenerateObs()
        Dim obstacle As New PictureBox

        Dim randomNumber As Double
        Dim upperLimit As Integer = 3

        Dim image_src As Image = My.Resources.spike_obs

        randomNumber = Math.Ceiling(Rnd() * upperLimit)

        If randomNumber = 1 Then
            obstacle.Parent = bg2
            obstacle.BackColor = Color.Transparent
            obstacle.BackgroundImage = image_src
            obstacle.BackgroundImageLayout = ImageLayout.Stretch
            obstacle.Top = Platform.Top - Player.Height - (Player.Height / 2)
            obstacle.Left = Me.Width - 100
            obstacle.Width = 50
            obstacle.Height = 100
        ElseIf randomNumber = 2 Then
            obstacle.Parent = bg2
            obstacle.BackColor = Color.Transparent
            obstacle.BackgroundImage = image_src
            obstacle.BackgroundImageLayout = ImageLayout.Stretch
            obstacle.Top = Platform.Top - (Player.Height / 2)
            obstacle.Left = Me.Width - 100
            obstacle.Width = 50
            obstacle.Height = 50
        ElseIf randomNumber = 3 Then
            obstacle.Parent = bg2
            obstacle.BackColor = Color.Transparent
            obstacle.BackgroundImage = image_src
            obstacle.BackgroundImageLayout = ImageLayout.Stretch
            obstacle.Top = Platform.Top - (Player.Height / 2)
            obstacle.Left = Me.Width - 100
            obstacle.Width = 100
            obstacle.Height = 50
        End If
        obstacles_arr.Add(obstacle)
        bg2.Controls.Add(obstacle)
        'MessageBox.Show(randomNumber)

    End Function

    Private Sub btnjump_Click(sender As Object, e As EventArgs) Handles btnjump.Click
        jumpUp = True
    End Sub

    Private Sub btnslide_Click(sender As Object, e As EventArgs) Handles btnslide.Click
        slide = True
    End Sub
End Class
