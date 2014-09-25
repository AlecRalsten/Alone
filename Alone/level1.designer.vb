<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class level1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.picGold = New System.Windows.Forms.PictureBox()
        Me.wall5 = New System.Windows.Forms.PictureBox()
        Me.wall4 = New System.Windows.Forms.PictureBox()
        Me.wall3 = New System.Windows.Forms.PictureBox()
        Me.wall2 = New System.Windows.Forms.PictureBox()
        Me.wall = New System.Windows.Forms.PictureBox()
        Me.picEnd = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picGold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picGold
        '
        Me.picGold.Image = Global.Alone.My.Resources.Resources.gold
        Me.picGold.Location = New System.Drawing.Point(30, 36)
        Me.picGold.Name = "picGold"
        Me.picGold.Size = New System.Drawing.Size(26, 29)
        Me.picGold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picGold.TabIndex = 7
        Me.picGold.TabStop = False
        '
        'wall5
        '
        Me.wall5.BackColor = System.Drawing.Color.White
        Me.wall5.Location = New System.Drawing.Point(254, 329)
        Me.wall5.Name = "wall5"
        Me.wall5.Size = New System.Drawing.Size(74, 125)
        Me.wall5.TabIndex = 6
        Me.wall5.TabStop = False
        '
        'wall4
        '
        Me.wall4.BackColor = System.Drawing.Color.White
        Me.wall4.Location = New System.Drawing.Point(204, 137)
        Me.wall4.Name = "wall4"
        Me.wall4.Size = New System.Drawing.Size(206, 50)
        Me.wall4.TabIndex = 5
        Me.wall4.TabStop = False
        '
        'wall3
        '
        Me.wall3.BackColor = System.Drawing.Color.White
        Me.wall3.Location = New System.Drawing.Point(334, 193)
        Me.wall3.Name = "wall3"
        Me.wall3.Size = New System.Drawing.Size(146, 261)
        Me.wall3.TabIndex = 4
        Me.wall3.TabStop = False
        '
        'wall2
        '
        Me.wall2.BackColor = System.Drawing.Color.White
        Me.wall2.Location = New System.Drawing.Point(12, 267)
        Me.wall2.Name = "wall2"
        Me.wall2.Size = New System.Drawing.Size(100, 187)
        Me.wall2.TabIndex = 3
        Me.wall2.TabStop = False
        '
        'wall
        '
        Me.wall.BackColor = System.Drawing.Color.Red
        Me.wall.Location = New System.Drawing.Point(118, 302)
        Me.wall.Name = "wall"
        Me.wall.Size = New System.Drawing.Size(124, 68)
        Me.wall.TabIndex = 2
        Me.wall.TabStop = False
        '
        'picEnd
        '
        Me.picEnd.BackColor = System.Drawing.Color.Black
        Me.picEnd.Image = Global.Alone.My.Resources.Resources.portal3
        Me.picEnd.Location = New System.Drawing.Point(416, 119)
        Me.picEnd.Name = "picEnd"
        Me.picEnd.Size = New System.Drawing.Size(64, 68)
        Me.picEnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEnd.TabIndex = 1
        Me.picEnd.TabStop = False
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picPlayer.Image = Global.Alone.My.Resources.Resources.player
        Me.picPlayer.Location = New System.Drawing.Point(118, 391)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(71, 63)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 25
        '
        'level1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(492, 466)
        Me.ControlBox = False
        Me.Controls.Add(Me.picGold)
        Me.Controls.Add(Me.wall5)
        Me.Controls.Add(Me.wall4)
        Me.Controls.Add(Me.wall3)
        Me.Controls.Add(Me.wall2)
        Me.Controls.Add(Me.wall)
        Me.Controls.Add(Me.picEnd)
        Me.Controls.Add(Me.picPlayer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "level1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Level 1"
        CType(Me.picGold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents picEnd As System.Windows.Forms.PictureBox
    Friend WithEvents wall As System.Windows.Forms.PictureBox
    Friend WithEvents wall2 As System.Windows.Forms.PictureBox
    Friend WithEvents wall3 As System.Windows.Forms.PictureBox
    Friend WithEvents wall4 As System.Windows.Forms.PictureBox
    Friend WithEvents wall5 As System.Windows.Forms.PictureBox
    Friend WithEvents picGold As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
