Imports System.IO

Public Class Form1
    Dim playerNumber As Integer = 2
    Dim movementSpeed As Integer = 0
    Dim obsGenRate As Integer = 750
    Dim count As Integer
    Dim p1 As playerProperty = New playerProperty()
    Dim p2 As playerProperty = New playerProperty()
    Dim obstacles_arr As ArrayList = New ArrayList()
    Dim players_arr As ArrayList = New ArrayList()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Timer1.Start()
        players_arr.Add(p1)
        players_arr.Add(p2)
        players_arr(0).UpathRun = "pictures\Characters\Dex\Run\Run Dex.gif"
        players_arr(0).UpathSlide = "pictures\Characters\Dex\Slide\Slide Dex.gif"
        players_arr(1).UpathRun = "pictures\Characters\Xavier\RUn\Run.gif"
        players_arr(1).UpathSlide = "pictures\Characters\Xavier\Slide\Slide.gif"
        For i = 1 To playerNumber
            GeneratePlayers(i)
        Next
        movementSpeed = 3

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        count += 20


        If count Mod 2000 = 0 Then
            movementSpeed += 1
            obsGenRate -= 5
        End If

        MoveObs(movementSpeed)
        Collision()

        'Generate obs every 2 seconds
        If count Mod obsGenRate = 0 Then
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

    Class playerProperty
        Private slidePrepare As Boolean = False
        Private maxSlideTime As Long = 0
        Private slideState As Boolean = False
        Private jumpUp As Boolean = False
        Private jumpDown As Boolean = False
        Private pictureBox As PictureBox
        Private pathSlide As String
        Private pathRun As String

        Public Property UpathRun As String
            Get
                Return pathRun
            End Get
            Set(value As String)
                pathRun = value
            End Set
        End Property
        Public Property UpathSlide As String
            Get
                Return pathSlide
            End Get
            Set(value As String)
                pathSlide = value
            End Set
        End Property
        Public Property UpictureBox As PictureBox
            Get
                Return pictureBox
            End Get
            Set(value As PictureBox)
                pictureBox = value
            End Set
        End Property
        Public Property UslidePrepare As Boolean
            Get
                Return slidePrepare
            End Get
            Set(value As Boolean)
                slidePrepare = value
            End Set
        End Property
        Public Property UmaxSlideTime As Long
            Get
                Return maxSlideTime
            End Get
            Set(value As Long)
                maxSlideTime = value
            End Set
        End Property
        Public Property UslideState As Boolean
            Get
                Return slideState
            End Get
            Set(value As Boolean)
                slideState = value
            End Set
        End Property
        Public Property UjumpUp As Boolean
            Get
                Return jumpUp
            End Get
            Set(value As Boolean)
                jumpUp = value
            End Set
        End Property
        Public Property UjumpDown As Boolean
            Get
                Return jumpDown
            End Get
            Set(value As Boolean)
                jumpDown = value
            End Set
        End Property
    End Class

    Function MovePlayer()
        For Each player_generated In players_arr
            If player_generated.UjumpUp Then
                player_generated.UpictureBox.Top -= 13
            End If

            If player_generated.UpictureBox.Top <= Platform.Top - player_generated.UpictureBox.Height - 120 Then
                player_generated.UjumpUp = False
                player_generated.UjumpDown = True
            End If

            If player_generated.UjumpDown Then
                player_generated.UpictureBox.Top += 8
                If player_generated.UpictureBox.Bottom >= Platform.Top Then
                    player_generated.UpictureBox.Top = Platform.Top - player_generated.UpictureBox.Height
                    player_generated.UjumpDown = False
                End If
            End If

            If player_generated.UslidePrepare Then
                player_generated.UmaxSlideTime = count + 1000
                player_generated.UslideState = True
                player_generated.UslidePrepare = False
                player_generated.UpictureBox.ImageLocation = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, player_generated.UpathSlide))
            End If
            If player_generated.UslideState Then
                If count <= player_generated.UmaxSlideTime Then
                    player_generated.UpictureBox.Height = 50
                    player_generated.UpictureBox.Width = 65
                    player_generated.UpictureBox.Top = Platform.Top - player_generated.UpictureBox.Height
                Else
                    player_generated.UpictureBox.Height = 65
                    player_generated.UpictureBox.Width = 50
                    player_generated.UpictureBox.Top = Platform.Top - player_generated.UpictureBox.Height
                    player_generated.UpictureBox.ImageLocation = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, player_generated.UpathRun))
                    player_generated.UslideState = False
                End If
            End If
        Next
    End Function

    Function slide_time()
        For Each player_generated In players_arr
            If player_generated.UslidePrepare Then
                player_generated.UmaxSlideTime = count + 3000
                player_generated.UslideState = True
                player_generated.UslidePrepare = False
            End If
        Next
    End Function



    Function MoveObs(movementSpeed)
        Dim removeOne As Boolean = False

        For Each _obs In obstacles_arr
            _obs.Left -= movementSpeed

            For Each player_generated In players_arr
                If _obs.Right <= player_generated.UpictureBox.Left - 100 Then
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
                If _obs.Left <= player_generated.UpictureBox.Right - 5 And player_generated.UpictureBox.Top + 5 <= _obs.Bottom And player_generated.UpictureBox.Bottom >= _obs.Top And player_generated.UpictureBox.Left + 2 <= _obs.Right Then
                    Timer1.Stop()
                    MessageBox.Show("You're Dead!")
                End If
            Next
        Next
    End Function

    Function GeneratePlayers(playerNumber)
        Dim player As New PictureBox

        If playerNumber = 1 Then
            player.Parent = bg2
            player.BackColor = Color.Transparent
            player.ImageLocation = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pictures\Characters\Dex\Run\Run Dex.gif"))
            player.BackgroundImageLayout = ImageLayout.Stretch
            player.Height = 65
            player.Width = 50
            player.Top = Platform.Top - player.Height
            player.Left = Me.Left + 10
        ElseIf playerNumber = 2 Then
            player.Parent = bg2
            player.BackColor = Color.Transparent
            player.ImageLocation = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pictures\Characters\Xavier\RUn\Run.gif"))
            player.BackgroundImageLayout = ImageLayout.Stretch
            player.Height = 65
            player.Width = 50
            player.Top = Platform.Top - player.Height
            player.Left = Me.Left + 80
        End If
        players_arr(playerNumber - 1).UpictureBox = player
        bg2.Controls.Add(players_arr(playerNumber - 1).UpictureBox)
    End Function



    Function GenerateObs()
        Dim obstacle As New PictureBox

        Dim randomNumber As Double
        Dim upperLimit As Integer = 3

        Dim image_src As Image = My.Resources.spike

        randomNumber = Math.Ceiling(Rnd() * upperLimit)

        If randomNumber = 1 Then
            obstacle.Parent = bg2
            obstacle.BackColor = Color.Transparent
            obstacle.ImageLocation = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pictures\Obs\lamok.gif"))
            obstacle.SizeMode = PictureBoxSizeMode.StretchImage
            obstacle.Width = 25
            obstacle.Height = 25
            obstacle.Top = Platform.Top - (obstacle.Height * 3)
            obstacle.Left = Me.Width - 100
        ElseIf randomNumber = 2 Then
            obstacle.Parent = bg2
            obstacle.BackColor = Color.Transparent
            obstacle.BackgroundImage = My.Resources.snake
            obstacle.BackgroundImageLayout = ImageLayout.Stretch
            obstacle.Width = 25
            obstacle.Height = 25
            obstacle.Top = Platform.Top - obstacle.Height
            obstacle.Left = Me.Width - 100
        ElseIf randomNumber = 3 Then
            obstacle.Parent = bg2
            obstacle.BackColor = Color.Transparent
            obstacle.BackgroundImage = My.Resources.spike
            obstacle.BackgroundImageLayout = ImageLayout.Stretch
            obstacle.Width = 50
            obstacle.Height = 25
            obstacle.Top = Platform.Top - obstacle.Height
            obstacle.Left = Me.Width - 100
        End If
        obstacles_arr.Add(obstacle)
        bg2.Controls.Add(obstacle)
        'MessageBox.Show(randomNumber)

    End Function

    Private Sub btnjump_Click(sender As Object, e As EventArgs) Handles btnjump.Click
        players_arr(0).UjumpUp = True
    End Sub

    Private Sub btnslide_Click(sender As Object, e As EventArgs) Handles btnslide.Click
        players_arr(0).UslidePrepare = True
    End Sub


    Private Sub Form1_KeyDown_S(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.S Then
            players_arr(1).UslidePrepare = True

            e.Handled = False
        End If
    End Sub
    Private Sub Form1_KeyDown_W(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.W Then
            players_arr(1).UjumpUp = True

            e.Handled = False
        End If
    End Sub
End Class
