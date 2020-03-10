﻿Public Class Form1
    Dim movementSpeed As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        movementSpeed = 3
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim count As Integer
        count += 1

        If count Mod 2 = 0 Then
            movementSpeed += 3
        End If

        MoveObs(movementSpeed)
        Collision()
        GenerateObs()
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

    Function MoveObs(movementSpeed)
        Obs1.Left -= movementSpeed
        Obs2.Left -= movementSpeed
        Obs3.Left -= movementSpeed
    End Function

    Function Collision()
        If Obs1.Left <= Player.Left + Player.Width And Player.Top <= Obs1.Top + Obs1.Height And Player.Top + Player.Height >= Obs1.Top Then
            Timer1.Stop()
            MessageBox.Show("You're Dead!")
        End If
    End Function

    Function GenerateObs()
        Dim obstacle As New PictureBox

        Dim randomNumber As Double
        Dim upperLimit As Integer = 3

        randomNumber = Math.Ceiling(Rnd() * upperLimit)

        If randomNumber = 1 Then
            obstacle.Top = Platform.Top - Player.Height - (Player.Height / 2)
            obstacle.Left = Me.Width - 100
            obstacle.Width = 50
            obstacle.Height = 100
        ElseIf randomNumber = 2 Then
            obstacle.Top = Platform.Top - (Player.Height / 2)
            obstacle.Left = Me.Width - 100
            obstacle.Width = 50
            obstacle.Height = 50
        ElseIf randomNumber = 3 Then
            obstacle.Top = Platform.Top - (Player.Height / 2)
            obstacle.Left = Me.Width - 100
            obstacle.Width = 100
            obstacle.Height = 50
        End If
        Me.Controls.Add(obstacle)

    End Function


End Class
