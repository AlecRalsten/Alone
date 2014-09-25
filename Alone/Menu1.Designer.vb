<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu1
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
        Me.b2 = New System.Windows.Forms.Button()
        Me.b3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.b1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'b2
        '
        Me.b2.AutoSize = True
        Me.b2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b2.ForeColor = System.Drawing.Color.Black
        Me.b2.Location = New System.Drawing.Point(384, 264)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(168, 41)
        Me.b2.TabIndex = 0
        Me.b2.Text = "Close game"
        Me.b2.UseVisualStyleBackColor = True
        '
        'b3
        '
        Me.b3.AutoSize = True
        Me.b3.BackColor = System.Drawing.Color.Transparent
        Me.b3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b3.ForeColor = System.Drawing.Color.Black
        Me.b3.Location = New System.Drawing.Point(351, 311)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(225, 41)
        Me.b3.TabIndex = 1
        Me.b3.Text = "Return To Game"
        Me.b3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(384, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Pause Menu"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(108, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 41)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Up"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(95, 311)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 41)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Down"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(102, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 31)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Volume"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(108, 358)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 41)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Mute"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'b1
        '
        Me.b1.AutoSize = True
        Me.b1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b1.ForeColor = System.Drawing.Color.Black
        Me.b1.Location = New System.Drawing.Point(384, 358)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(168, 41)
        Me.b1.TabIndex = 2
        Me.b1.Text = "Menu"
        Me.b1.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(764, 579)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.b3)
        Me.Controls.Add(Me.b2)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menu"
        Me.TransparencyKey = System.Drawing.Color.DarkSlateBlue
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents b2 As System.Windows.Forms.Button
    Friend WithEvents b3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents b1 As System.Windows.Forms.Button
End Class
