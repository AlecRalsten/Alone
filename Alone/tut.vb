Public Class tut
    Dim intup, intmove, intkey, intunlock, intfinal As Integer
    Public intclose As Integer

  
    Private Sub tut_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim Loc As Point
        Dim wall1 As Point
        If picPlayer.Location.Y = 102 Or picPlayer.Location.X = 529 Then
            If e.KeyChar = "e" Then
                If intkey = 1 Then
                    If e.KeyChar = "e" Then
                        door1.Hide()
                        door2.Hide()
                        intunlock = 1
                        intfinal = 1
                    End If
                End If
            End If
        End If

        If intfinal = 1 Then
            endt.Hide()
            finalt.Show()
            escape.Show()
        End If

        

        If intup = 0 Then
            Select Case e.KeyChar

                Case ChrW(Keys.Escape)
                    Dim m As New Menu1
                    Windows.Forms.Cursor.Show()
                    m.Show()
                    m.Refresh()

                Case "w"  ' up
                    picPlayer.Image = My.Resources.playerU
                    If Not picPlayer.Location.Y - 5 < 0 Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                        If picPlayer.Bounds.IntersectsWith(up.Bounds) Then
                            up.Hide()
                            right.Show()
                            intup = 1
                        End If
                    End If
            End Select

        ElseIf intup = 3 Then
            Select Case e.KeyChar
                Case "a"  ' left
                    picPlayer.Image = My.Resources.playerL
                    If Not picPlayer.Location.X - 5 < 0 Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        If picPlayer.Bounds.IntersectsWith(left.Bounds) Then
                            left.Hide()
                            intup = 4
                            wall2.Show()
                            slow.Show()
                            intmove = 1
                        End If
                    End If
            End Select

        ElseIf intup = 1 Then
            Select Case e.KeyChar
                Case "d"  ' right
                    picPlayer.Image = My.Resources.playerR
                    If Not picPlayer.Location.X + 5 > Me.Width - picPlayer.Width - 5 Then
                        Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        If picPlayer.Bounds.IntersectsWith(right.Bounds) Then
                            right.Hide()
                            down.Show()
                            intup = 2
                        End If
                    End If
            End Select

        ElseIf intup = 2 Then
            Select Case e.KeyChar
                Case "s"  ' down
                    picPlayer.Image = My.Resources.player
                    If Not picPlayer.Location.Y - 5 > Me.Height - picPlayer.Height * 1.6 Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                        If picPlayer.Bounds.IntersectsWith(down.Bounds) Then
                            down.Hide()
                            left.Show()
                            intup = 3
                        End If
                    End If
            End Select

        ElseIf intup = 4 Then
            Select Case e.KeyChar

                Case "w"  ' up
                    picPlayer.Image = My.Resources.playerU
                    If Not picPlayer.Location.Y - 5 < 0 Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                        If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                            Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                            picPlayer.Location = Loc
                        End If
                        If picPlayer.Bounds.IntersectsWith(wall3.Bounds) Then
                            Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                            picPlayer.Location = Loc
                            If Not wall3.Location.Y - 80 < 0 Then
                                wall1 = New Point(wall3.Location.X, wall3.Location.Y - 5)
                                wall3.Location = wall1
                                If wall3.Bounds.IntersectsWith(wall2.Bounds) Then
                                    wall1 = New Point(wall3.Location.X, wall3.Location.Y + 5)
                                    wall3.Location = wall1
                                End If
                            End If
                        End If
                        If picPlayer.Bounds.IntersectsWith(door1.Bounds) Then
                            If intkey = 0 Then
                                MsgBox("You don't have the first key.")
                                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                                picPlayer.Location = Loc
                            ElseIf intkey = 1 And intunlock = 0 Then
                                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                                picPlayer.Location = Loc
                            End If
                        End If
                        If picPlayer.Bounds.IntersectsWith(door2.Bounds) Then
                            If intkey = 0 Then
                                MsgBox("You don't have the first key.")
                                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                                picPlayer.Location = Loc
                            ElseIf intkey = 1 And intunlock = 0 Then
                                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                                picPlayer.Location = Loc
                            End If
                        End If
                    End If

                Case "d"  ' right
                    picPlayer.Image = My.Resources.playerR
                    If Not picPlayer.Location.X + 5 > Me.Width - picPlayer.Width - 5 Then
                        Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                            Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                            picPlayer.Location = Loc
                        End If
                        If picPlayer.Bounds.IntersectsWith(wall3.Bounds) Then
                            Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                            picPlayer.Location = Loc
                        End If
                        If picPlayer.Bounds.IntersectsWith(door1.Bounds) Then
                            If intkey = 0 Then
                                MsgBox("You don't have the first key.")
                                Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                                picPlayer.Location = Loc
                            ElseIf intkey = 1 And intunlock = 0 Then
                                Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                                picPlayer.Location = Loc
                            End If
                        End If
                        If picPlayer.Bounds.IntersectsWith(door2.Bounds) Then
                            If intkey = 0 Then
                                MsgBox("You don't have the first key.")
                                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                                picPlayer.Location = Loc
                            ElseIf intkey = 1 And intunlock = 0 Then
                                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                                picPlayer.Location = Loc
                            End If
                        End If
                    End If

                Case "s"  ' down
                    picPlayer.Image = My.Resources.player
                    If Not picPlayer.Location.Y - 5 > Me.Height - picPlayer.Height * 1.6 Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                        If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                            Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                            picPlayer.Location = Loc
                        End If
                        If picPlayer.Bounds.IntersectsWith(wall3.Bounds) Then
                            Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                            picPlayer.Location = Loc
                        End If
                    End If

                Case "a"  ' left
                    picPlayer.Image = My.Resources.playerL
                    If Not picPlayer.Location.X - 5 < 0 Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                            Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                            picPlayer.Location = Loc
                        End If
                        If picPlayer.Bounds.IntersectsWith(wall3.Bounds) Then
                            Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                            picPlayer.Location = Loc
                            If Not wall3.Location.X - 5 < 0 Then
                                wall1 = New Point(wall3.Location.X - 5, wall3.Location.Y)
                                wall3.Location = wall1
                                If wall3.Bounds.IntersectsWith(wall2.Bounds) Then
                                    wall1 = New Point(wall3.Location.X + 5, wall3.Location.Y)
                                    wall3.Location = wall1
                                End If
                            End If
                        End If
                    End If
            End Select
        End If

        If picPlayer.Location.X = 154 And intmove = 1 Then
            slow.Hide()
            wall3.Show()
            movea.Show()
            wall2.Hide()
        End If

        If picPlayer.Location.X = 154 And picPlayer.Location.Y = 137 Then
            movea.Hide()
            key.Show()
            keyt.Show()
            wall3.Hide()
        End If

        If picPlayer.Bounds.IntersectsWith(key.Bounds) Then
            intkey = 1
            key.Hide()
            door1.Show()
            door2.Show()
            picend.Show()
            endt.Show()
            keyt.Hide()
        End If

        If picPlayer.Bounds.IntersectsWith(picend.Bounds) Then
            System.Threading.Thread.Sleep(200)
            tut2.Show()
            Me.Close()
        End If

    End Sub

    Private Sub tut_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Windows.Forms.Cursor.Hide()
        intclose = 1
        Me.Refresh()
        right.Hide()
        wall2.Hide()
        slow.Hide()
        down.Hide()
        left.Hide()
        wall3.Hide()
        movea.Hide()
        key.Hide()
        keyt.Hide()
        door1.Hide()
        door2.Hide()
        picend.Hide()
        endt.Hide()
        finalt.Hide()
        escape.Hide()
    End Sub
End Class