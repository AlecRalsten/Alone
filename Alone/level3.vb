Public Class level3
    Dim strname As String
    Dim inupdate As IO.StreamReader
    Dim strread As String
    Dim intread As Integer
    Dim strshow As String
    Dim inuser As IO.StreamReader
    Dim outupdate As IO.StreamWriter
    Dim inupdate2 As IO.StreamReader
    Dim strread2 As String
    Dim intread2 As Integer
    Dim strshow2 As String


    Dim intkey1, intkey2, intunlock As Integer

    Private Sub level3_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        ' variables for new points
        Dim Loc As Point
        Dim wall1 As Point
        Dim wallp2 As Point

        ' if you have the first key and you are infront of the door press e to open it
        If picPlayer.Location.Y = 104 Or 107 Then
            If e.KeyChar = "e" Then
                If intkey1 = 1 Then
                    If e.KeyChar = "e" Then
                        door1.Hide()
                        intunlock = 1
                    End If
                End If
            End If
        End If

        Select Case e.KeyChar

            ' exit the game
            Case ChrW(Keys.Escape)
                Dim m As New Menu1
                Windows.Forms.Cursor.Show()
                m.Show()
                m.Refresh()

                ' move left with a
            Case "a"
                picPlayer.Image = My.Resources.playerL
                If Not picPlayer.Location.X - 5 < 0 Then
                    Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc

                    ' if you touch the wall stop moving
                    If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                        Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                    End If

                    ' if you touch the wall stop moving
                    If picPlayer.Bounds.IntersectsWith(wall3.Bounds) Then
                        Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                    End If

                    ' if you touch the wall stop moving
                    If picPlayer.Bounds.IntersectsWith(wall6.Bounds) Then
                        Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                    End If

                    ' move the block
                    If picPlayer.Bounds.IntersectsWith(wall.Bounds) Then
                        Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        If Not wall.Location.X - 5 < 0 Then
                            wall1 = New Point(wall.Location.X - 5, wall.Location.Y)
                            wall.Location = wall1
                            If wall.Bounds.IntersectsWith(wall2.Bounds) Then
                                wall1 = New Point(wall.Location.X + 5, wall.Location.Y)
                                wall.Location = wall1
                            End If
                            If wall.Bounds.IntersectsWith(wall3.Bounds) Then
                                wall1 = New Point(wall.Location.X + 5, wall.Location.Y)
                                wall.Location = wall1
                            End If
                        End If
                    End If
                End If

                ' move right with d
            Case "d"
                picPlayer.Image = My.Resources.playerR
                If Not picPlayer.Location.X + 5 > Me.Width - picPlayer.Width - 5 Then
                    Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc

                    ' if you touch the wall stop moving
                    If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                    End If

                    ' if you touch the wall stop moving
                    If picPlayer.Bounds.IntersectsWith(wall6.Bounds) Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                    End If

                    ' if you touch the wall stop moving
                    If picPlayer.Bounds.IntersectsWith(wall4.Bounds) Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                    End If

                    ' move the block
                    If picPlayer.Bounds.IntersectsWith(wall5.Bounds) Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        If Not wall5.Location.X + 5 > Me.Width - wall5.Width - 5 Then
                            wallp2 = New Point(wall5.Location.X + 5, wall5.Location.Y)
                            wall5.Location = wallp2
                            If wall5.Bounds.IntersectsWith(wall6.Bounds) Then
                                wallp2 = New Point(wall5.Location.X - 5, wall5.Location.Y)
                                wall5.Location = wallp2
                            End If
                            If picPlayer.Bounds.IntersectsWith(wall.Bounds) Then
                                Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                                picPlayer.Location = Loc
                                If Not wall.Location.X + 5 > Me.Width - wall.Width - 5 Then
                                    wall1 = New Point(wall.Location.X + 5, wall.Location.Y)
                                    wall.Location = wall1
                                    If wall.Bounds.IntersectsWith(wall2.Bounds) Then
                                        wall1 = New Point(wall.Location.X - 5, wall.Location.Y)
                                        wall.Location = wall1
                                    End If
                                End If
                            End If
                        End If
                    End If
                    If wall.Bounds.IntersectsWith(wall2.Bounds) Then
                        wall1 = New Point(wall.Location.X - 5, wall.Location.Y)
                        wall.Location = wall1
                    End If
                End If

                ' move up with w
            Case "w"
                picPlayer.Image = My.Resources.playerU
                If Not picPlayer.Location.Y - 5 < 0 Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                    picPlayer.Location = Loc

                    ' if you touch the wall stop moving
                    If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                    End If

                    ' if you touch the door stop moving, if you dont have the key show a mesage box
                    If picPlayer.Bounds.IntersectsWith(door1.Bounds) Then
                        If intkey1 = 0 Then
                            MsgBox("You don't have the first key.")
                            Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                            picPlayer.Location = Loc
                        ElseIf intkey1 = 1 And intunlock = 0 Then
                            Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                            picPlayer.Location = Loc
                        End If
                    End If
                End If

                ' if you touch the wall stop moving
                If picPlayer.Bounds.IntersectsWith(wall4.Bounds) Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc
                End If

                ' if you touch the wall stop moving
                If picPlayer.Bounds.IntersectsWith(wall3.Bounds) Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc
                End If

                ' move the block
                If picPlayer.Bounds.IntersectsWith(wall.Bounds) Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc
                    If Not wall.Location.Y - 5 < 0 Then
                        wall1 = New Point(wall.Location.X, wall.Location.Y - 5)
                        wall.Location = wall1
                        If wall.Bounds.IntersectsWith(wall2.Bounds) Then
                            wall1 = New Point(wall.Location.X, wall.Location.Y + 5)
                            wall.Location = wall1
                        End If
                        If wall.Bounds.IntersectsWith(wall3.Bounds) Then
                            wall1 = New Point(wall.Location.X, wall.Location.Y + 5)
                            wall.Location = wall1
                        End If
                        If wall.Bounds.IntersectsWith(wall4.Bounds) Then
                            wall1 = New Point(wall.Location.X, wall.Location.Y + 5)
                            wall.Location = wall1
                        End If
                    End If
                End If

                ' move down with s
            Case "s"
                picPlayer.Image = My.Resources.player
                If Not picPlayer.Location.Y - 1 > Me.Height - picPlayer.Height * 1.2 Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc

                    ' if you touch the wall stop moving
                    If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                    End If

                    ' move the block
                    If picPlayer.Bounds.IntersectsWith(wall5.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                        If Not wall.Location.Y - 5 > Me.Height - wall.Height * 1.5 Then
                            wall1 = New Point(wall.Location.X, wall.Location.Y + 5)
                            wall.Location = wall1
                            If wall.Bounds.IntersectsWith(wall2.Bounds) Then
                                wall1 = New Point(wall.Location.X, wall.Location.Y - 5)
                                wall.Location = wall1
                            End If
                        End If
                    End If
                End If
        End Select

        ' if you touch the first key your key1 variable = 1
        If picPlayer.Bounds.IntersectsWith(key1.Bounds) Then
            transport3.Enabled = True
            transport1.Hide()
            transport2.Hide()
            transport3.Show()
            transport4.Show()
            intkey1 = 1
            key1.Hide()
        End If

        ' if you touch the second key your key2 variable = 1
        If picPlayer.Bounds.IntersectsWith(key2.Bounds) Then
            transport1.Show()
            transport2.Show()
            transport3.Hide()
            transport4.Hide()
            intkey2 = 1
            key2.Hide()
        End If

        ' if you have the second key and you touch the end, hide the curent form
        ' and load the next level
        If picPlayer.Bounds.IntersectsWith(picEnd.Bounds) Then
            If intkey2 = 1 Then

                If IO.File.Exists("logedin") = True Then
                    inuser = IO.File.OpenText("logedin")
                    Do Until inuser.Peek = -1
                        ' read a name
                        strname = inuser.ReadLine
                        If IO.File.Exists(strname & "level") = True Then
                            inupdate2 = IO.File.OpenText(strname & "level")

                            strread2 = inupdate2.ReadLine

                            intread2 = strread2.ToString

                            inupdate2.Close()

                            intread2 = 4
                            outupdate = IO.File.CreateText(strname & "level")

                            outupdate.WriteLine(intread2)

                            strshow2 = intread2

                            outupdate.Close()

                        Else
                            intread2 = 4
                            outupdate = IO.File.CreateText(strname & "level")

                            outupdate.WriteLine(intread2)

                            strshow2 = intread2

                            outupdate.Close()
                        End If
                    Loop
                End If


                System.Threading.Thread.Sleep(200)
                Level4.Show()
                Me.Close()
            Else
                MsgBox("You don't have the second key.")
            End If
        End If

        ' if you touch transport1 then hide the wall
        If picPlayer.Bounds.IntersectsWith(transport1.Bounds) Then
            wall5.Hide()
            transport1.Show()
        End If

        '' if you dont have the first key hide transport 3 and 4, or if you touch transport 4 hide it
        'If intkey1 = 0 Then
        '    transport3.Hide()
        '    transport4.Hide()
        'Else
        '    transport3.Show()
        '    transport4.Show()
        'End If

        If picPlayer.Bounds.IntersectsWith(transport4.Bounds) Then
            transport4.Hide()
        End If

        ' if you touch transport 2 hide it
        If picPlayer.Bounds.IntersectsWith(transport2.Bounds) Then
            transport2.Hide()
        End If

        ' if you touch transport 3 you move to transport 4
        If transport3.Enabled = True Then
            If picPlayer.Bounds.IntersectsWith(transport3.Bounds) Then
                Loc = New Point(transport4.Location.X, transport4.Location.Y)
                picPlayer.Location = Loc
            End If
        Else
            Me.Refresh()
        End If


        ' if you touch transport 1 you move to transport 2
        If picPlayer.Bounds.IntersectsWith(transport1.Bounds) Then
            transport2.Show()
            Loc = New Point(transport2.Location.X, transport2.Location.Y)
            picPlayer.Location = Loc
        End If

    End Sub
    Private Sub level2_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        transport3.Enabled = False
        transport2.Hide()
        transport3.Hide()
        transport4.Hide()
        ' if wall5 is touching transport 1, hide transport 1
        If wall5.Bounds.IntersectsWith(transport1.Bounds) Then
            transport1.Hide()
        Else
            transport1.Show()
        End If

        ' if you do not have the first key hide transport 3 and 4
        If intkey1 = 0 Then
            transport3.Hide()
            transport4.Hide()
        Else
            transport3.Show()
            transport4.Show()
        End If

    End Sub
End Class