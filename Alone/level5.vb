Public Class level5
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

    Dim intshown, inthiden, inthealth, intkey As Integer

    Private Sub level5_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Randomize()

        Dim Loc As Point

        Select Case e.KeyChar

            ' exit application
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

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow.Bounds) Then
                        Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow3.Bounds) Then
                        Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow5.Bounds) Then
                        Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow6.Bounds) Then
                        Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow7.Bounds) Then
                        Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow12.Bounds) Then
                        Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow14.Bounds) Then
                        Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow15.Bounds) Then
                        Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow16.Bounds) Then
                        Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow17.Bounds) Then
                        Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow19.Bounds) Then
                        Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow20.Bounds) Then
                        Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow22.Bounds) Then
                        Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow24.Bounds) Then
                        Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If
                End If


            Case "d"  ' right
                picPlayer.Image = My.Resources.playerR
                If Not picPlayer.Location.X + 5 > Me.Width - picPlayer.Width - 5 Then
                    Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc

                    ' if you touch the wall stop moving
                    If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow.Bounds) Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow3.Bounds) Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow5.Bounds) Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow6.Bounds) Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow7.Bounds) Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow12.Bounds) Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow14.Bounds) Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow15.Bounds) Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow16.Bounds) Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow17.Bounds) Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow19.Bounds) Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow20.Bounds) Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow22.Bounds) Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow24.Bounds) Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If
                End If


            Case "w"  ' up
                picPlayer.Image = My.Resources.playerU
                If Not picPlayer.Location.Y - 5 < 0 Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                    picPlayer.Location = Loc

                    ' if you touch the wall stop moving
                    If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                    End If

                    ' if you touch the wall stop moving
                    If picPlayer.Bounds.IntersectsWith(wall3.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow3.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow5.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow6.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow7.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow12.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow14.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow15.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow16.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow17.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow19.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow20.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow22.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow24.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If
                End If


            Case "s"  ' down
                picPlayer.Image = My.Resources.player
                If Not picPlayer.Location.Y - 5 > Me.Height - picPlayer.Height * 1.2 Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc

                    ' if you touch the wall stop moving
                    If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow3.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow5.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow6.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow7.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow12.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow14.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow15.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow16.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow17.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow19.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow20.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow22.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If

                    ' if you touch the shadow lose hp
                    If picPlayer.Bounds.IntersectsWith(shadow24.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                        inthealth = inthealth - 5
                    End If
                End If
        End Select

        ' if you touch the first key key = 1
        If picPlayer.Bounds.IntersectsWith(key1.Bounds) Then
            intkey = 1
            key2.Enabled = True
            key1.Hide()
        End If

        ' if you touch the second key key = 2
        If key2.Enabled = True Then
            If picPlayer.Bounds.IntersectsWith(key2.Bounds) Then
                intkey = 2
                key2.Hide()
            End If
        Else
            Me.Refresh()
        End If

        ' if you don't have the first key display a mesage
        If intkey = 0 Then
            If picPlayer.Bounds.IntersectsWith(picend.Bounds) Then
                MsgBox("You don't have the key")
                key1.Show()
            End If
        End If

        ' if you have the first key display a mesage
        If intkey = 1 Then
            If picPlayer.Bounds.IntersectsWith(picend.Bounds) Then
                MsgBox("That's not the right key")
                key2.Show()
            End If
        End If

        'if you have the second key go to next level
        If intkey = 2 Then
            If picPlayer.Bounds.IntersectsWith(picend.Bounds) Then
                'MsgBox("Finaly the right key")

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

                            intread2 = 6
                            outupdate = IO.File.CreateText(strname & "level")

                            outupdate.WriteLine(intread2)

                            strshow2 = intread2

                            outupdate.Close()

                        Else
                            intread2 = 6
                            outupdate = IO.File.CreateText(strname & "level")

                            outupdate.WriteLine(intread2)

                            strshow2 = intread2

                            outupdate.Close()
                        End If
                    Loop
                End If


                System.Threading.Thread.Sleep(200)
                level6.Show()
                Me.Close()
            End If
        End If

        ' method to hide and show the shadows
        If intshown = 0 Then
            shadow.Hide()
            shadow3.Hide()
            shadow5.Hide()
            shadow6.Hide()
            shadow7.Hide()
            shadow12.Hide()
            shadow14.Hide()
            shadow15.Hide()
            shadow16.Show()
            shadow17.Show()
            shadow19.Show()
            shadow20.Show()
            shadow22.Show()
            shadow24.Show()
        ElseIf intshown = 1 Then
            shadow.Show()
            shadow3.Show()
            shadow5.Show()
            shadow6.Show()
            shadow7.Show()
            shadow12.Show()
            shadow14.Show()
            shadow15.Show()
            shadow16.Hide()
            shadow17.Hide()
            shadow19.Hide()
            shadow20.Hide()
            shadow22.Hide()
            shadow24.Hide()
        End If
        If intshown = 0 Then
            inthiden = 0
        ElseIf intshown = 1 Then
            inthiden = 1
        ElseIf intshown = 2 Then
            inthiden = 1
        End If
        If inthiden = 0 Then
            intshown = Int(Rnd() * 2) + 0
        ElseIf inthiden = 1 Then
            intshown = Int(Rnd() * 2) + 0
        End If

        ' if your health is lese than 0 exit game
        If inthealth <= 0 Then
            Windows.Forms.Cursor.Show()
            picPlayer.Image = My.Resources.shadow
            Windows.Forms.Cursor.Show()
            MsgBox("You have been consumed by the shadows")
            logedin.Refresh()
            logedin.Show()
            Me.Close()
        End If

        ' show hp
        txthealth.Text = inthealth.ToString & " " & "HP"

    End Sub

    Private Sub level3_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Randomize()
        key2.Enabled = False
        shadow.Hide()
        shadow3.Hide()
        shadow5.Hide()
        shadow6.Hide()
        shadow7.Hide()
        shadow12.Hide()
        shadow14.Hide()
        shadow15.Hide()
        shadow16.Hide()
        shadow17.Hide()
        shadow19.Hide()
        shadow20.Hide()
        shadow22.Hide()
        shadow24.Hide()

        intshown = Int(Rnd() * 2) + 0

        inthiden = 1

        inthealth = 20

        txthealth.Text = inthealth.ToString & " " & "HP"

        key1.Hide()
        key2.Hide()
    End Sub
End Class