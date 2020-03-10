Public Class Form1
    Dim movementSpeed As Integer = 0
    Dim count As Integer
<<<<<<< HEAD

=======
    Dim jumpUp As Boolean = False
    Dim jumpDown As Boolean = False
>>>>>>> 0a9a71133a21806565b9373932f531c7ce108925
    Dim obstacles_arr As ArrayList = New ArrayList()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        movementSpeed = 3
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
<<<<<<< HEAD
        count += 20

        'If count Mod 2000 = 0 Then
=======

        count += 20

        'If count Mod 10 = 0 Then
>>>>>>> 0a9a71133a21806565b9373932f531c7ce108925
        '    movementSpeed += 3
        'End If

        MoveObs(movementSpeed)
        Collision()

<<<<<<< HEAD
        'Generate obs every 2 seconds
        If count Mod 750 = 0 Then
            GenerateObs()
        End If
=======
        If count Mod 750 = 0 Then
            GenerateObs()
            'MessageBox.Show(count)
        End If

        MovePlayer()



>>>>>>> 0a9a71133a21806565b9373932f531c7ce108925
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
        If jumpUp = True Then
            Player.Top -= 15
        End If

        If Player.Top <= Platform.Top - Player.Height - 150 Then
            jumpUp = False
            jumpDown = True
        End If

        If jumpDown = True Then
            Player.Top += 7
            If Player.Bottom >= Platform.Top Then
                Player.Top = Platform.Top - Player.Height
                jumpDown = False
            End If
        End If
    End Function

    Public Sub JumpButton_Click(sender As Object, e As EventArgs) Handles JumpButton.Click
        jumpUp = True
    End Sub


    Function MoveObs(movementSpeed)
        Dim removeOne As Boolean = False

        For Each obs In obstacles_arr
            obs.Left -= movementSpeed

            If obs.Right <= Player.Left - 100 Then
                obs.Visible = False
                removeOne = True
            End If
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
<<<<<<< HEAD
=======

        For Each obs In obstacles_arr
            If obs.Left <= Player.Right And Player.Top <= obs.Bottom And Player.Bottom >= obs.Top Then
                Timer1.Stop()
                MessageBox.Show("You're Dead!")
            End If
        Next
>>>>>>> 0a9a71133a21806565b9373932f531c7ce108925
    End Function

    Function GenerateObs()
        Dim obstacle As New PictureBox

        Dim randomNumber As Double
        Dim upperLimit As Integer = 3

        randomNumber = Math.Ceiling(Rnd() * upperLimit)

        If randomNumber = 1 Then
<<<<<<< HEAD
            obstacle.BackColor = Color.Red
=======
            obstacle.BackColor = Color.Aquamarine
>>>>>>> 0a9a71133a21806565b9373932f531c7ce108925
            obstacle.Top = Platform.Top - Player.Height - (Player.Height / 2)
            obstacle.Left = Me.Width - 100
            obstacle.Width = 50
            obstacle.Height = 100
        ElseIf randomNumber = 2 Then
<<<<<<< HEAD
            obstacle.BackColor = Color.Blue
=======
            obstacle.BackColor = Color.Red
>>>>>>> 0a9a71133a21806565b9373932f531c7ce108925
            obstacle.Top = Platform.Top - (Player.Height / 2)
            obstacle.Left = Me.Width - 100
            obstacle.Width = 50
            obstacle.Height = 50
        ElseIf randomNumber = 3 Then
            obstacle.BackColor = Color.Green
            obstacle.Top = Platform.Top - (Player.Height / 2)
            obstacle.Left = Me.Width - 100
            obstacle.Width = 100
            obstacle.Height = 50
        End If
        obstacles_arr.Add(obstacle)
        Me.Controls.Add(obstacle)
        'MessageBox.Show(randomNumber)

    End Function


End Class
