<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Platform = New System.Windows.Forms.PictureBox()
        Me.Obs1 = New System.Windows.Forms.PictureBox()
        Me.Obs2 = New System.Windows.Forms.PictureBox()
        Me.Obs3 = New System.Windows.Forms.PictureBox()
        Me.bg1 = New System.Windows.Forms.PictureBox()
        Me.bg2 = New System.Windows.Forms.PictureBox()
        Me.btnjump = New System.Windows.Forms.PictureBox()
        Me.btnslide = New System.Windows.Forms.PictureBox()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Platform, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Obs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Obs2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Obs3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnjump, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnslide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Player.Location = New System.Drawing.Point(102, 172)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(50, 100)
        Me.Player.TabIndex = 0
        Me.Player.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'Platform
        '
        Me.Platform.BackColor = System.Drawing.Color.Transparent
        Me.Platform.Location = New System.Drawing.Point(0, 394)
        Me.Platform.Name = "Platform"
        Me.Platform.Size = New System.Drawing.Size(798, 54)
        Me.Platform.TabIndex = 1
        Me.Platform.TabStop = False
        Me.Platform.Visible = False
        '
        'Obs1
        '
        Me.Obs1.Location = New System.Drawing.Point(0, 0)
        Me.Obs1.Name = "Obs1"
        Me.Obs1.Size = New System.Drawing.Size(100, 50)
        Me.Obs1.TabIndex = 16
        Me.Obs1.TabStop = False
        '
        'Obs2
        '
        Me.Obs2.Location = New System.Drawing.Point(0, 0)
        Me.Obs2.Name = "Obs2"
        Me.Obs2.Size = New System.Drawing.Size(100, 50)
        Me.Obs2.TabIndex = 15
        Me.Obs2.TabStop = False
        '
        'Obs3
        '
        Me.Obs3.Location = New System.Drawing.Point(0, 0)
        Me.Obs3.Name = "Obs3"
        Me.Obs3.Size = New System.Drawing.Size(100, 50)
        Me.Obs3.TabIndex = 14
        Me.Obs3.TabStop = False
        '
        'bg1
        '
        Me.bg1.BackgroundImage = CType(resources.GetObject("bg1.BackgroundImage"), System.Drawing.Image)
        Me.bg1.Location = New System.Drawing.Point(12, 207)
        Me.bg1.Name = "bg1"
        Me.bg1.Size = New System.Drawing.Size(146, 149)
        Me.bg1.TabIndex = 2
        Me.bg1.TabStop = False
        '
        'bg2
        '
        Me.bg2.BackgroundImage = CType(resources.GetObject("bg2.BackgroundImage"), System.Drawing.Image)
        Me.bg2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bg2.Location = New System.Drawing.Point(1, 0)
        Me.bg2.Name = "bg2"
        Me.bg2.Size = New System.Drawing.Size(797, 448)
        Me.bg2.TabIndex = 3
        Me.bg2.TabStop = False
        '
        'btnjump
        '
        Me.btnjump.BackgroundImage = CType(resources.GetObject("btnjump.BackgroundImage"), System.Drawing.Image)
        Me.btnjump.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnjump.Location = New System.Drawing.Point(9, 106)
        Me.btnjump.Name = "btnjump"
        Me.btnjump.Size = New System.Drawing.Size(62, 50)
        Me.btnjump.TabIndex = 6
        Me.btnjump.TabStop = False
        '
        'btnslide
        '
        Me.btnslide.BackgroundImage = CType(resources.GetObject("btnslide.BackgroundImage"), System.Drawing.Image)
        Me.btnslide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnslide.Location = New System.Drawing.Point(77, 108)
        Me.btnslide.Name = "btnslide"
        Me.btnslide.Size = New System.Drawing.Size(62, 48)
        Me.btnslide.TabIndex = 7
        Me.btnslide.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 449)
        Me.Controls.Add(Me.Platform)
        Me.Controls.Add(Me.btnslide)
        Me.Controls.Add(Me.btnjump)
        Me.Controls.Add(Me.bg2)
        Me.Controls.Add(Me.bg1)
        Me.Controls.Add(Me.Obs3)
        Me.Controls.Add(Me.Obs2)
        Me.Controls.Add(Me.Obs1)
        Me.Controls.Add(Me.Player)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Platform, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Obs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Obs2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Obs3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnjump, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnslide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Player As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Platform As PictureBox
    Friend WithEvents Obs1 As PictureBox
    Friend WithEvents Obs2 As PictureBox
    Friend WithEvents Obs3 As PictureBox
    Friend WithEvents bg1 As PictureBox
    Friend WithEvents bg2 As PictureBox
    Friend WithEvents btnjump As PictureBox
    Friend WithEvents btnslide As PictureBox
End Class
