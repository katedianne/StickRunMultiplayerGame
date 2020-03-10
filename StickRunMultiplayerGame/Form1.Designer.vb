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
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Platform = New System.Windows.Forms.PictureBox()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Platform, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Player.Location = New System.Drawing.Point(109, 166)
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
        Me.Platform.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Platform.Location = New System.Drawing.Point(1, 272)
        Me.Platform.Name = "Platform"
        Me.Platform.Size = New System.Drawing.Size(798, 177)
        Me.Platform.TabIndex = 1
        Me.Platform.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Platform)
        Me.Controls.Add(Me.Player)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Platform, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Player As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Platform As PictureBox
End Class
