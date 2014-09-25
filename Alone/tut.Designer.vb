<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tut))
        Me.up = New System.Windows.Forms.Label()
        Me.right = New System.Windows.Forms.Label()
        Me.down = New System.Windows.Forms.Label()
        Me.left = New System.Windows.Forms.Label()
        Me.slow = New System.Windows.Forms.Label()
        Me.movea = New System.Windows.Forms.Label()
        Me.keyt = New System.Windows.Forms.Label()
        Me.endt = New System.Windows.Forms.Label()
        Me.finalt = New System.Windows.Forms.Label()
        Me.escape = New System.Windows.Forms.Label()
        Me.key = New System.Windows.Forms.PictureBox()
        Me.door2 = New System.Windows.Forms.PictureBox()
        Me.door1 = New System.Windows.Forms.PictureBox()
        Me.picend = New System.Windows.Forms.PictureBox()
        Me.wall3 = New System.Windows.Forms.PictureBox()
        Me.wall2 = New System.Windows.Forms.PictureBox()
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        CType(Me.key, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.door2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.door1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'up
        '
        Me.up.AutoSize = True
        Me.up.BackColor = System.Drawing.Color.Transparent
        Me.up.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.up.ForeColor = System.Drawing.Color.White
        Me.up.Location = New System.Drawing.Point(12, 196)
        Me.up.Name = "up"
        Me.up.Size = New System.Drawing.Size(271, 31)
        Me.up.TabIndex = 1
        Me.up.Text = "Press ""w"" to move up"
        '
        'right
        '
        Me.right.AutoSize = True
        Me.right.BackColor = System.Drawing.Color.Transparent
        Me.right.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.right.ForeColor = System.Drawing.Color.White
        Me.right.Location = New System.Drawing.Point(415, 227)
        Me.right.Name = "right"
        Me.right.Size = New System.Drawing.Size(289, 31)
        Me.right.TabIndex = 3
        Me.right.Text = "Press ""d"" to move right"
        '
        'down
        '
        Me.down.AutoSize = True
        Me.down.BackColor = System.Drawing.Color.Transparent
        Me.down.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.down.ForeColor = System.Drawing.Color.White
        Me.down.Location = New System.Drawing.Point(404, 392)
        Me.down.Name = "down"
        Me.down.Size = New System.Drawing.Size(300, 31)
        Me.down.TabIndex = 4
        Me.down.Text = "Press ""s"" to move down"
        '
        'left
        '
        Me.left.AutoSize = True
        Me.left.BackColor = System.Drawing.Color.Transparent
        Me.left.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.left.ForeColor = System.Drawing.Color.White
        Me.left.Location = New System.Drawing.Point(10, 321)
        Me.left.Name = "left"
        Me.left.Size = New System.Drawing.Size(273, 31)
        Me.left.TabIndex = 5
        Me.left.Text = "Press ""a"" to move left"
        '
        'slow
        '
        Me.slow.AutoSize = True
        Me.slow.BackColor = System.Drawing.Color.Transparent
        Me.slow.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slow.ForeColor = System.Drawing.Color.White
        Me.slow.Location = New System.Drawing.Point(12, 269)
        Me.slow.Name = "slow"
        Me.slow.Size = New System.Drawing.Size(324, 31)
        Me.slow.TabIndex = 6
        Me.slow.Text = "Some blocks will stop you"
        '
        'movea
        '
        Me.movea.AutoSize = True
        Me.movea.BackColor = System.Drawing.Color.Transparent
        Me.movea.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.movea.ForeColor = System.Drawing.Color.White
        Me.movea.Location = New System.Drawing.Point(68, 44)
        Me.movea.Name = "movea"
        Me.movea.Size = New System.Drawing.Size(293, 31)
        Me.movea.TabIndex = 9
        Me.movea.Text = "Some blocks can move"
        '
        'keyt
        '
        Me.keyt.AutoSize = True
        Me.keyt.BackColor = System.Drawing.Color.Transparent
        Me.keyt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keyt.ForeColor = System.Drawing.Color.White
        Me.keyt.Location = New System.Drawing.Point(373, 209)
        Me.keyt.Name = "keyt"
        Me.keyt.Size = New System.Drawing.Size(167, 31)
        Me.keyt.TabIndex = 15
        Me.keyt.Text = "Pick up keys"
        '
        'endt
        '
        Me.endt.AutoSize = True
        Me.endt.BackColor = System.Drawing.Color.Transparent
        Me.endt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endt.ForeColor = System.Drawing.Color.White
        Me.endt.Location = New System.Drawing.Point(12, 9)
        Me.endt.Name = "endt"
        Me.endt.Size = New System.Drawing.Size(449, 31)
        Me.endt.TabIndex = 16
        Me.endt.Text = "Go to a door and press ""e"" to open it"
        '
        'finalt
        '
        Me.finalt.AutoSize = True
        Me.finalt.BackColor = System.Drawing.Color.Transparent
        Me.finalt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finalt.ForeColor = System.Drawing.Color.White
        Me.finalt.Location = New System.Drawing.Point(12, 22)
        Me.finalt.Name = "finalt"
        Me.finalt.Size = New System.Drawing.Size(532, 31)
        Me.finalt.TabIndex = 17
        Me.finalt.Text = "Go through the portal to go to the next level"
        '
        'escape
        '
        Me.escape.AutoSize = True
        Me.escape.BackColor = System.Drawing.Color.Transparent
        Me.escape.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.escape.ForeColor = System.Drawing.Color.White
        Me.escape.Location = New System.Drawing.Point(12, 178)
        Me.escape.Name = "escape"
        Me.escape.Size = New System.Drawing.Size(608, 31)
        Me.escape.TabIndex = 18
        Me.escape.Text = "If you want to exit the game press the escape key"
        '
        'key
        '
        Me.key.BackColor = System.Drawing.Color.Transparent
        Me.key.Image = Global.Alone.My.Resources.Resources.door
        Me.key.Location = New System.Drawing.Point(421, 134)
        Me.key.Name = "key"
        Me.key.Size = New System.Drawing.Size(40, 38)
        Me.key.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.key.TabIndex = 14
        Me.key.TabStop = False
        '
        'door2
        '
        Me.door2.BackColor = System.Drawing.Color.Silver
        Me.door2.Image = CType(resources.GetObject("door2.Image"), System.Drawing.Image)
        Me.door2.Location = New System.Drawing.Point(610, 81)
        Me.door2.Name = "door2"
        Me.door2.Size = New System.Drawing.Size(94, 20)
        Me.door2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.door2.TabIndex = 13
        Me.door2.TabStop = False
        '
        'door1
        '
        Me.door1.BackColor = System.Drawing.Color.Silver
        Me.door1.Image = Global.Alone.My.Resources.Resources.keyhole1
        Me.door1.Location = New System.Drawing.Point(610, 12)
        Me.door1.Name = "door1"
        Me.door1.Size = New System.Drawing.Size(21, 63)
        Me.door1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.door1.TabIndex = 12
        Me.door1.TabStop = False
        '
        'picend
        '
        Me.picend.BackColor = System.Drawing.Color.Transparent
        Me.picend.Image = Global.Alone.My.Resources.Resources.portal3
        Me.picend.Location = New System.Drawing.Point(637, 12)
        Me.picend.Name = "picend"
        Me.picend.Size = New System.Drawing.Size(67, 63)
        Me.picend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picend.TabIndex = 11
        Me.picend.TabStop = False
        '
        'wall3
        '
        Me.wall3.BackColor = System.Drawing.Color.Red
        Me.wall3.Location = New System.Drawing.Point(149, 260)
        Me.wall3.Name = "wall3"
        Me.wall3.Size = New System.Drawing.Size(100, 58)
        Me.wall3.TabIndex = 10
        Me.wall3.TabStop = False
        '
        'wall2
        '
        Me.wall2.BackColor = System.Drawing.Color.White
        Me.wall2.Location = New System.Drawing.Point(51, 336)
        Me.wall2.Name = "wall2"
        Me.wall2.Size = New System.Drawing.Size(100, 50)
        Me.wall2.TabIndex = 2
        Me.wall2.TabStop = False
        '
        'picPlayer
        '
        Me.picPlayer.Image = Global.Alone.My.Resources.Resources.player
        Me.picPlayer.Location = New System.Drawing.Point(74, 392)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(77, 62)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'tut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(716, 466)
        Me.ControlBox = False
        Me.Controls.Add(Me.escape)
        Me.Controls.Add(Me.finalt)
        Me.Controls.Add(Me.endt)
        Me.Controls.Add(Me.keyt)
        Me.Controls.Add(Me.key)
        Me.Controls.Add(Me.door2)
        Me.Controls.Add(Me.door1)
        Me.Controls.Add(Me.picend)
        Me.Controls.Add(Me.wall3)
        Me.Controls.Add(Me.movea)
        Me.Controls.Add(Me.slow)
        Me.Controls.Add(Me.left)
        Me.Controls.Add(Me.down)
        Me.Controls.Add(Me.right)
        Me.Controls.Add(Me.wall2)
        Me.Controls.Add(Me.up)
        Me.Controls.Add(Me.picPlayer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "tut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "tutorial"
        CType(Me.key, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.door2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.door1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents up As System.Windows.Forms.Label
    Friend WithEvents wall2 As System.Windows.Forms.PictureBox
    Friend WithEvents right As System.Windows.Forms.Label
    Friend WithEvents down As System.Windows.Forms.Label
    Friend WithEvents left As System.Windows.Forms.Label
    Friend WithEvents slow As System.Windows.Forms.Label
    Friend WithEvents movea As System.Windows.Forms.Label
    Friend WithEvents wall3 As System.Windows.Forms.PictureBox
    Friend WithEvents picend As System.Windows.Forms.PictureBox
    Friend WithEvents door1 As System.Windows.Forms.PictureBox
    Friend WithEvents door2 As System.Windows.Forms.PictureBox
    Friend WithEvents key As System.Windows.Forms.PictureBox
    Friend WithEvents keyt As System.Windows.Forms.Label
    Friend WithEvents endt As System.Windows.Forms.Label
    Friend WithEvents finalt As System.Windows.Forms.Label
    Friend WithEvents escape As System.Windows.Forms.Label
End Class
