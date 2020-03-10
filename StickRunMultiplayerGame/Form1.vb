Public Class Form1
    Dim movementSpeed As Integer = 0
    Dim count As Integer
    Dim obstacles_arr As ArrayList = New ArrayList()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        movementSpeed = 3
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        count += 20

        'If count Mod 10 = 0 Then
        '    movementSpeed += 3
        'End If

        MoveObs(movementSpeed)
        Collision()

        If count Mod 750 = 0 Then
            GenerateObs()
            'MessageBox.Show(count)
        End If

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
    End Function

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
    End Function

    Function GenerateObs()
        Dim obstacle As New PictureBox

        Dim randomNumber As Double
        Dim upperLimit As Integer = 3

        randomNumber = Math.Ceiling(Rnd() * upperLimit)

        If randomNumber = 1 Then
            obstacle.BackColor = Color.Aquamarine
            obstacle.Top = Platform.Top - Player.Height - (Player.Height / 2)
            obstacle.Left = Me.Width - 100
            obstacle.Width = 50
            obstacle.Height = 100
        ElseIf randomNumber = 2 Then
            obstacle.BackColor = Color.Red
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
