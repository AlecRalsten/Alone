Public Class Level4
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


    Private Sub tell()
        If picPlayer.Bounds.IntersectsWith(t1.Bounds) Then
            picPlayer.Location = t4.Location
            t1.Hide()
        Else
            t1.Show()
        End If

        If picPlayer.Bounds.IntersectsWith(t4.Bounds) Then
            t4.Hide()
        Else
            t4.Show()
        End If

        If picPlayer.Bounds.IntersectsWith(t2.Bounds) Then
            picPlayer.Location = t8.Location
            t2.Hide()
        Else
            t2.Show()
        End If

        If picPlayer.Bounds.IntersectsWith(t8.Bounds) Then
            t8.Hide()
        Else
            t8.Show()
        End If

        If picPlayer.Bounds.IntersectsWith(t3.Bounds) Then
            picPlayer.Location = t12.Location
            t3.Hide()
        Else
            t3.Show()
        End If

        If picPlayer.Bounds.IntersectsWith(t12.Bounds) Then
            t12.Hide()
        Else
            t12.Show()
        End If

        If picPlayer.Bounds.IntersectsWith(t5.Bounds) Then
            picPlayer.Location = t15.Location
            t5.Hide()
        Else
            t5.Show()
        End If

        If picPlayer.Bounds.IntersectsWith(t15.Bounds) Then
            t15.Hide()
        Else
            t15.Show()
        End If

        If picPlayer.Bounds.IntersectsWith(t9.Bounds) Then
            picPlayer.Location = t6.Location
            t9.Hide()
        Else
            t9.Show()
        End If

        If picPlayer.Bounds.IntersectsWith(t6.Bounds) Then
            t6.Hide()
        Else
            t6.Show()
        End If

        If picPlayer.Bounds.IntersectsWith(t7.Bounds) Then
            picPlayer.Location = te.Location
            t7.Hide()
            te.Hide()
        Else
            t7.Show()
        End If

        If picPlayer.Bounds.IntersectsWith(t14.Bounds) Then
            picPlayer.Location = t10.Location
            t14.Hide()
        Else
            t14.Show()
        End If

        If picPlayer.Bounds.IntersectsWith(t10.Bounds) Then
            t10.Hide()
        Else
            t10.Show()
        End If

        If picPlayer.Bounds.IntersectsWith(t11.Bounds) Then
            picPlayer.Location = t6.Location
            t11.Hide()
        Else
            t11.Show()
        End If

        If picPlayer.Bounds.IntersectsWith(t13.Bounds) Then
            picPlayer.Location = tb.Location
            t13.Hide()
        Else
            t13.Show()
        End If

        If picPlayer.Bounds.IntersectsWith(tb.Bounds) Then
            tb.Hide()
        Else
            tb.Show()
        End If

    End Sub

    Private Sub Level4_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim Loc As Point

        Call tell()

        Select Case e.KeyChar
            Case ChrW(Keys.Escape)
                Dim m As New Menu1
                Windows.Forms.Cursor.Show()
                m.Show()
                m.Refresh()
            Case "a"  ' left
                picPlayer.Image = My.Resources.playerL
                If Not picPlayer.Location.X - 5 < 0 Then
                    Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                    If picPlayer.Bounds.IntersectsWith(wall1.Bounds) Then
                        Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                        Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall3.Bounds) Then
                        Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall4.Bounds) Then
                        Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                    End If
                End If
            Case "d"  ' right
                picPlayer.Image = My.Resources.playerR
                If Not picPlayer.Location.X + 5 > Me.Width - picPlayer.Width - 5 Then
                    Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                    If picPlayer.Bounds.IntersectsWith(wall1.Bounds) Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall3.Bounds) Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall4.Bounds) Then
                        Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                        picPlayer.Location = Loc
                    End If
                End If
            Case "w"  ' up
                picPlayer.Image = My.Resources.playerU
                If Not picPlayer.Location.Y - 5 < 0 Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                    picPlayer.Location = Loc
                    If picPlayer.Bounds.IntersectsWith(wall1.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall3.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall4.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                    End If
                End If
            Case "s"  ' down
                picPlayer.Image = My.Resources.player
                If Not picPlayer.Location.Y - 5 > Me.Height - picPlayer.Height * 1.2 Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc
                    If picPlayer.Bounds.IntersectsWith(wall1.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall3.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                    End If
                    If picPlayer.Bounds.IntersectsWith(wall4.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                    End If
                End If
        End Select

        If picPlayer.Bounds.IntersectsWith(picEnd.Bounds) Then
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

                        intread2 = 5
                        outupdate = IO.File.CreateText(strname & "level")

                        outupdate.WriteLine(intread2)

                        strshow2 = intread2

                        outupdate.Close()

                    Else
                        intread2 = 5
                        outupdate = IO.File.CreateText(strname & "level")

                        outupdate.WriteLine(intread2)

                        strshow2 = intread2

                        outupdate.Close()
                    End If
                Loop
            End If

            System.Threading.Thread.Sleep(200)
            level5.Show()
            Me.Close()
        End If

    End Sub
End Class