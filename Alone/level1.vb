Public Class level1
    <System.Runtime.InteropServices.DllImport("user32.dll")> _
    Private Shared Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short
    End Function
    Dim strname As String
    Dim inupdate As IO.StreamReader
    Dim strread As String
    Dim intread As Integer
    Dim strshow As String
    Dim inuser As IO.StreamReader
    Dim outupdate As IO.StreamWriter
    Dim intentered As Integer
    Dim intGold1 As Integer
    Dim inupdate2 As IO.StreamReader
    Dim strread2 As String
    Dim intread2 As Integer
    Dim strshow2 As String

    Dim hotkey As Boolean
    Dim hotkey2 As Boolean
    Dim hotkey3 As Boolean
    Dim hotkey4 As Boolean
    Dim hotkey5 As Boolean

    Private Sub level1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If tut.intclose = 1 Then
            tut.Close()
        End If
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

                    intread2 = 1
                    outupdate = IO.File.CreateText(strname & "level")

                    outupdate.WriteLine(intread2)

                    strshow2 = intread2

                    outupdate.Close()
                    
                Else
                    intread2 = 1
                    outupdate = IO.File.CreateText(strname & "level")

                    outupdate.WriteLine(intread2)

                    strshow2 = intread2

                    outupdate.Close()
                End If
            Loop
            inuser.Close()
        End If
        Windows.Forms.Cursor.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Loc As Point
        Dim wall1 As Point

        hotkey = GetAsyncKeyState(Keys.W)
        hotkey2 = GetAsyncKeyState(Keys.A)
        hotkey3 = GetAsyncKeyState(Keys.S)
        hotkey4 = GetAsyncKeyState(Keys.D)
        hotkey5 = GetAsyncKeyState(Keys.Escape)

        If hotkey5 = True Then
            Windows.Forms.Cursor.Show()
            Menu1.Show()
            Menu1.Refresh()
        End If


        If hotkey2 = True Then  ' left
            picPlayer.Image = My.Resources.playerL
            If Not picPlayer.Location.X - 5 < 0 Then
                Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                picPlayer.Location = Loc
                If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                    Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall4.Bounds) Then
                    Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
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
                        If wall.Bounds.IntersectsWith(wall4.Bounds) Then
                            wall1 = New Point(wall.Location.X + 5, wall.Location.Y)
                            wall.Location = wall1
                        End If
                    End If
                End If
            End If
        End If

        If hotkey4 = True Then  ' right
            picPlayer.Image = My.Resources.playerR
            If Not picPlayer.Location.X + 4 > Me.Width - picPlayer.Width - 4 Then
                Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                picPlayer.Location = Loc
                If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                    Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall5.Bounds) Then
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
                        If wall.Bounds.IntersectsWith(wall3.Bounds) Then
                            wall1 = New Point(wall.Location.X - 5, wall.Location.Y)
                            wall.Location = wall1
                        End If
                        If wall.Bounds.IntersectsWith(wall4.Bounds) Then
                            wall1 = New Point(wall.Location.X - 5, wall.Location.Y)
                            wall.Location = wall1
                        End If
                    End If
                End If
            End If
        End If

        If hotkey = True Then  ' up
            picPlayer.Image = My.Resources.playerU
            If Not picPlayer.Location.Y - 6 < 0 Then
                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                picPlayer.Location = Loc
                If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall4.Bounds) Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc
                End If
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
                        If wall.Bounds.IntersectsWith(wall4.Bounds) Then
                            wall1 = New Point(wall.Location.X, wall.Location.Y + 5)
                            wall.Location = wall1
                        End If
                    End If
                End If
            End If
        End If

        If hotkey3 = True Then  ' down
            picPlayer.Image = My.Resources.player
            If Not picPlayer.Location.Y - 4 > Me.Height - picPlayer.Height * 1.2 Then
                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                picPlayer.Location = Loc
                If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall5.Bounds) Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall4.Bounds) Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall3.Bounds) Then
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
                        If wall.Bounds.IntersectsWith(wall5.Bounds) Then
                            wall1 = New Point(wall.Location.X, wall.Location.Y - 5)
                            wall.Location = wall1
                        End If
                        If wall.Bounds.IntersectsWith(wall4.Bounds) Then
                            wall1 = New Point(wall.Location.X, wall.Location.Y - 5)
                            wall.Location = wall1
                        End If
                        If wall.Bounds.IntersectsWith(wall3.Bounds) Then
                            wall1 = New Point(wall.Location.X, wall.Location.Y - 5)
                            wall.Location = wall1
                        End If
                    End If
                End If
            End If
        End If

        If picPlayer.Bounds.IntersectsWith(picGold.Bounds) Then
            If intGold1 = 0 Then
                If IO.File.Exists("logedin") = True Then
                    inuser = IO.File.OpenText("logedin")
                    Do Until inuser.Peek = -1
                        ' read a name
                        strname = inuser.ReadLine
                        If IO.File.Exists(strname & "gold") = True Then

                            inupdate = IO.File.OpenText(strname & "gold")

                            strread = inupdate.ReadLine

                            intread = strread.ToString

                            inupdate.Close()

                            intread = intread + 1
                            outupdate = IO.File.CreateText(strname & "gold")

                            outupdate.WriteLine(intread)

                            outupdate.Close()
                            intGold1 = 1
                            picGold.Hide()
                            Me.Refresh()
                        Else

                            outupdate = IO.File.CreateText(strname & "gold")

                            outupdate.WriteLine("1")

                            outupdate.Close()
                            intGold1 = 1
                            picGold.Hide()
                            Me.Refresh()
                        End If
                    Loop
                End If
            End If
        End If

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

                        intread2 = 2
                        outupdate = IO.File.CreateText(strname & "level")

                        outupdate.WriteLine(intread2)

                        strshow2 = intread2

                        outupdate.Close()

                    Else
                        intread2 = 2
                        outupdate = IO.File.CreateText(strname & "level")

                        outupdate.WriteLine(intread2)

                        strshow2 = intread2

                        outupdate.Close()
                    End If
                Loop
            End If
            System.Threading.Thread.Sleep(200)
            level2.Show()
            Me.Close()
        End If
    End Sub
End Class