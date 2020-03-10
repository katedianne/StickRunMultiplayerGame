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
        Me.Obs1 = New System.Windows.Forms.PictureBox()
        Me.Obs2 = New System.Windows.Forms.PictureBox()
        Me.Obs3 = New System.Windows.Forms.PictureBox()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Obs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Obs2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Obs3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Player.Location = New System.Drawing.Point(109, 166)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(55, 109)
        Me.Player.TabIndex = 0
        Me.Player.TabStop = False
        '
        'Timer1
        '
        '
        'Obs1
        '
        Me.Obs1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Obs1.Location = New System.Drawing.Point(409, 12)
        Me.Obs1.Name = "Obs1"
        Me.Obs1.Size = New System.Drawing.Size(55, 109)
        Me.Obs1.TabIndex = 0
        Me.Obs1.TabStop = False
        '
        'Obs2
        '
        Me.Obs2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Obs2.Location = New System.Drawing.Point(508, 207)
        Me.Obs2.Name = "Obs2"
        Me.Obs2.Size = New System.Drawing.Size(55, 68)
        Me.Obs2.TabIndex = 0
        Me.Obs2.TabStop = False
        '
        'Obs3
        '
        Me.Obs3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Obs3.Location = New System.Drawing.Point(619, 207)
        Me.Obs3.Name = "Obs3"
        Me.Obs3.Size = New System.Drawing.Size(116, 68)
        Me.Obs3.TabIndex = 0
        Me.Obs3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Obs3)
        Me.Controls.Add(Me.Obs2)
        Me.Controls.Add(Me.Obs1)
        Me.Controls.Add(Me.Player)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Obs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Obs2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Obs3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Player As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Obs1 As PictureBox
    Friend WithEvents Obs2 As PictureBox
    Friend WithEvents Obs3 As PictureBox
End Class
