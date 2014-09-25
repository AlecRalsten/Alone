Public Class level8
    Dim inuser As IO.StreamReader
    Dim outupdate As IO.StreamWriter
    Dim intentered As Integer
    Dim intGold1 As Integer
    Dim inupdate2 As IO.StreamReader
    Dim strread2 As String
    Dim intread2 As Integer
    Dim strshow2 As String
    Dim strname As String
    Dim inupdate As IO.StreamReader
    Dim strread As String
    Dim intread As Integer
    Dim strshow As String

    Private Sub level7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim Loc As Point
        Select Case e.KeyChar
            Case ChrW(Keys.Escape)
                Dim m As New Menu1
                Windows.Forms.Cursor.Show()
                m.Show()
                m.Refresh()

            Case "q"

                If IO.File.Exists("logedin") = True Then
                    inuser = IO.File.OpenText("logedin")
                    Do Until inuser.Peek = -1
                        ' read a name
                        strname = inuser.ReadLine
                        If IO.File.Exists(strname & "reveal") = True Then

                            inupdate = IO.File.OpenText(strname & "reveal")

                            strread = inupdate.ReadLine

                            intread = strread.ToString

                            inupdate.Close()

                            If intread > 0 Then
                                wall1.BackColor = Color.White
                                wall2.BackColor = Color.White
                                wall3.BackColor = Color.White
                                wall4.BackColor = Color.White
                                wall5.BackColor = Color.White
                                wall6.BackColor = Color.White
                                wall7.BackColor = Color.White

                                intread = intread - 1
                                outupdate = IO.File.CreateText(strname & "reveal")

                                outupdate.WriteLine(intread)

                                outupdate.Close()
                            Else
                                MsgBox("No Reveals left")
                            End If

                        Else
                            MsgBox("No Reveals left")
                        End If
                    Loop
                End If


                ' determines what happens when you hit the "A" key and what happens whe it iteract with a wall
            Case "a"  ' left
                picPlayer.Image = My.Resources.playerL
                If Not picPlayer.Location.X - 5 < 0 Then
                    Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                    wall1.BackColor = Color.Black
                    wall2.BackColor = Color.Black
                    wall3.BackColor = Color.Black
                    wall4.BackColor = Color.Black
                    wall5.BackColor = Color.Black
                    wall6.BackColor = Color.Black
                    wall7.BackColor = Color.Black
                    If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                        Loc = New Point(12, 338)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall3.Bounds) Then
                        Loc = New Point(12, 388)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall4.Bounds) Then
                        Loc = New Point(12, 388)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall5.Bounds) Then
                        Loc = New Point(12, 388)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall6.Bounds) Then
                        Loc = New Point(12, 388)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall7.Bounds) Then
                        Loc = New Point(12, 388)
                        picPlayer.Location = Loc
                    End If
                End If

                ' determines what happens when you hit the "D" key and what happens whe it iteract with a wall
            Case "d"  ' right
                picPlayer.Image = My.Resources.playerR
                If Not picPlayer.Location.X + 5 > Me.Width - picPlayer.Width - 5 Then
                    Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                    wall1.BackColor = Color.Black
                    wall2.BackColor = Color.Black
                    wall3.BackColor = Color.Black
                    wall4.BackColor = Color.Black
                    wall5.BackColor = Color.Black
                    wall6.BackColor = Color.Black
                    wall7.BackColor = Color.Black
                    If picPlayer.Bounds.IntersectsWith(wall1.Bounds) Then
                        Loc = New Point(12, 388)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                        Loc = New Point(12, 388)
                        picPlayer.Location = Loc
                    End If

                    If picPlayer.Bounds.IntersectsWith(wall3.Bounds) Then
                        Loc = New Point(12, 388)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall4.Bounds) Then
                        Loc = New Point(12, 388)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall5.Bounds) Then
                        Loc = New Point(12, 388)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall6.Bounds) Then
                        Loc = New Point(12, 388)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall7.Bounds) Then
                        Loc = New Point(12, 388)
                        picPlayer.Location = Loc
                    End If
                End If

                ' determines what happens when you hit the "W" key and what happens whe it iteract with a wall
            Case "w"  ' up
                picPlayer.Image = My.Resources.playerU
                If Not picPlayer.Location.Y - 5 < 0 Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                    picPlayer.Location = Loc
                    wall1.BackColor = Color.Black
                    wall2.BackColor = Color.Black
                    wall3.BackColor = Color.Black
                    wall4.BackColor = Color.Black
                    wall5.BackColor = Color.Black
                    wall6.BackColor = Color.Black
                    wall7.BackColor = Color.Black
                    If picPlayer.Bounds.IntersectsWith(wall1.Bounds) Then
                        Loc = New Point(12, 388)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                        Loc = New Point(12, 338)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall3.Bounds) Then
                        Loc = New Point(12, 388)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall4.Bounds) Then
                        Loc = New Point(12, 388)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall5.Bounds) Then
                        Loc = New Point(12, 388)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall6.Bounds) Then
                        Loc = New Point(12, 388)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall7.Bounds) Then
                        Loc = New Point(12, 388)
                        picPlayer.Location = Loc
                    End If
                End If

                ' determines what happens when you hit the "S" key and what happens whe it iteract with a wall        
            Case "s"  ' down
                picPlayer.Image = My.Resources.player
                If Not picPlayer.Location.Y - 5 > Me.Height - picPlayer.Height * 1.5 Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc
                    wall1.BackColor = Color.Black
                    wall2.BackColor = Color.Black
                    wall3.BackColor = Color.Black
                    wall4.BackColor = Color.Black
                    wall5.BackColor = Color.Black
                    wall6.BackColor = Color.Black
                    wall7.BackColor = Color.Black
                    If picPlayer.Bounds.IntersectsWith(wall1.Bounds) Then
                        Loc = New Point(12, 388)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                        Loc = New Point(12, 338)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall3.Bounds) Then
                        Loc = New Point(12, 338)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall3.Bounds) Then
                        Loc = New Point(12, 388)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall4.Bounds) Then
                        Loc = New Point(12, 388)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall5.Bounds) Then
                        Loc = New Point(12, 388)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall6.Bounds) Then
                        Loc = New Point(12, 388)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall7.Bounds) Then
                        Loc = New Point(12, 388)
                        picPlayer.Location = Loc
                    End If
                End If
        End Select

        If picPlayer.Bounds.IntersectsWith(picend.Bounds) Then
            Dim s As New start
            My.Computer.Audio.Play(My.Resources.Bazinga, AudioPlayMode.Background)
            Me.Hide()
            Windows.Forms.Cursor.Show()
            MsgBox("You have beat the game!!")
            System.Threading.Thread.Sleep(200)
            s.Show()
            Me.Close()
        End If

    End Sub

    Private Sub level7_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        wall1.BackColor = Color.White
        wall2.BackColor = Color.White
        wall3.BackColor = Color.White
        wall4.BackColor = Color.White
        wall5.BackColor = Color.White
        wall6.BackColor = Color.White
        wall7.BackColor = Color.White
    End Sub
End Class
