Public Class level2
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
    Dim inupdate2 As IO.StreamReader
    Dim strread2 As String
    Dim intread2 As Integer
    Dim strshow2 As String

    Dim hotkey As Boolean
    Dim hotkey2 As Boolean
    Dim hotkey3 As Boolean
    Dim hotkey4 As Boolean
    Dim hotkey5 As Boolean

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim Loc As Point
        Dim XYZ As Point

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
                If picPlayer.Bounds.IntersectsWith(wall1.Bounds) Then
                    Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall4.Bounds) Then
                    Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall5.Bounds) Then
                    Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall6.Bounds) Then
                    Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall6.Bounds) Then
                    Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall7.Bounds) Then
                    Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall8.Bounds) Then
                    Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall9.Bounds) Then
                    Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall10.Bounds) Then
                    Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall11.Bounds) Then
                    Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall12.Bounds) Then
                    Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall13.Bounds) Then
                    Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall14.Bounds) Then
                    Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If

                If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                    Loc = New Point(wall2.Location.X + 5, picPlayer.Location.Y)
                    wall2.Location = XYZ
                    If Not wall2.Location.X - 5 < 0 Then
                        XYZ = New Point(wall2.Location.X - 5, wall2.Location.Y)
                        wall2.Location = XYZ
                        If wall2.Bounds.IntersectsWith(wall4.Bounds) Then
                            XYZ = New Point(wall2.Location.X + 5, wall2.Location.Y)
                            wall2.Location = XYZ
                            If wall2.Bounds.IntersectsWith(wall5.Bounds) Then
                                XYZ = New Point(wall2.Location.X + 5, wall2.Location.Y)
                                wall2.Location = XYZ
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If hotkey4 = True Then  ' right
            picPlayer.Image = My.Resources.playerR
            If Not picPlayer.Location.X + 5 > Me.Width - picPlayer.Width - 5 Then
                Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                picPlayer.Location = Loc
                If picPlayer.Bounds.IntersectsWith(wall1.Bounds) Then
                    Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall4.Bounds) Then
                    Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall5.Bounds) Then
                    Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall6.Bounds) Then
                    Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall7.Bounds) Then
                    Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall8.Bounds) Then
                    Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall9.Bounds) Then
                    Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall11.Bounds) Then
                    Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall12.Bounds) Then
                    Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall13.Bounds) Then
                    Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall14.Bounds) Then
                    Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If

                If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                    Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                    If Not wall2.Location.X + 5 < 0 Then
                        XYZ = New Point(wall2.Location.X + 5, wall2.Location.Y)
                        wall2.Location = XYZ
                        If wall2.Bounds.IntersectsWith(wall4.Bounds) Then
                            XYZ = New Point(wall2.Location.X + 5, wall2.Location.Y)
                            wall2.Location = XYZ
                            If wall2.Bounds.IntersectsWith(wall5.Bounds) Then
                                XYZ = New Point(wall2.Location.X - 5, wall2.Location.Y)
                                wall2.Location = XYZ
                            End If
                        End If
                    End If
                End If
                If picPlayer.Bounds.IntersectsWith(wall3.Bounds) Then
                    Loc = New Point(picPlayer.Location.X - 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                    If Not wall3.Location.X + 5 < 0 Then
                        XYZ = New Point(wall3.Location.X + 5, wall3.Location.Y)
                        wall3.Location = XYZ
                        If wall3.Bounds.IntersectsWith(wall4.Bounds) Then
                            XYZ = New Point(wall3.Location.X + 5, wall3.Location.Y)
                            wall3.Location = XYZ
                            If wall3.Bounds.IntersectsWith(wall5.Bounds) Then
                                XYZ = New Point(wall3.Location.X - 5, wall3.Location.Y)
                                wall3.Location = XYZ
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If hotkey = True Then  ' up
            picPlayer.Image = My.Resources.playerU
            If Not picPlayer.Location.Y - 5 < 0 Then
                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                picPlayer.Location = Loc
                If picPlayer.Bounds.IntersectsWith(wall1.Bounds) Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall4.Bounds) Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall5.Bounds) Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall6.Bounds) Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall7.Bounds) Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall8.Bounds) Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall9.Bounds) Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall10.Bounds) Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall11.Bounds) Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall12.Bounds) Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall13.Bounds) Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall14.Bounds) Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc
                    If Not wall2.Location.Y - 5 < 0 Then
                        XYZ = New Point(wall2.Location.X, wall2.Location.Y - 5)
                        wall2.Location = XYZ
                        If wall2.Bounds.IntersectsWith(wall4.Bounds) Then
                            XYZ = New Point(wall2.Location.X, wall2.Location.Y + 5)
                            wall2.Location = XYZ
                        End If
                    End If
                End If
            End If
            If picPlayer.Bounds.IntersectsWith(wall3.Bounds) Then
                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                picPlayer.Location = Loc
                If Not wall2.Location.Y - 5 < 0 Then
                    XYZ = New Point(wall3.Location.X, wall3.Location.Y - 5)
                    wall3.Location = XYZ
                    If wall3.Bounds.IntersectsWith(wall4.Bounds) Then
                        XYZ = New Point(wall3.Location.X, wall3.Location.Y + 5)
                        wall3.Location = XYZ
                    End If
                End If
            End If
        End If

        If hotkey3 = True Then  ' down
            picPlayer.Image = My.Resources.player
            If Not picPlayer.Location.Y - 5 > Me.Height - picPlayer.Height * 1.5 Then
                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                picPlayer.Location = Loc
            End If
            If picPlayer.Bounds.IntersectsWith(wall1.Bounds) Then
                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                picPlayer.Location = Loc
            End If
            If picPlayer.Bounds.IntersectsWith(wall4.Bounds) Then
                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                picPlayer.Location = Loc
            End If
            If picPlayer.Bounds.IntersectsWith(wall5.Bounds) Then
                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                picPlayer.Location = Loc
            End If
            If picPlayer.Bounds.IntersectsWith(wall6.Bounds) Then
                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                picPlayer.Location = Loc
            End If
            If picPlayer.Bounds.IntersectsWith(wall7.Bounds) Then
                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                picPlayer.Location = Loc
            End If
            If picPlayer.Bounds.IntersectsWith(wall8.Bounds) Then
                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                picPlayer.Location = Loc
            End If
            If picPlayer.Bounds.IntersectsWith(wall9.Bounds) Then
                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                picPlayer.Location = Loc
            End If
            If picPlayer.Bounds.IntersectsWith(wall10.Bounds) Then
                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                picPlayer.Location = Loc
            End If
            If picPlayer.Bounds.IntersectsWith(wall11.Bounds) Then
                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                picPlayer.Location = Loc
            End If
            If picPlayer.Bounds.IntersectsWith(wall12.Bounds) Then
                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                picPlayer.Location = Loc
            End If
            If picPlayer.Bounds.IntersectsWith(wall13.Bounds) Then
                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                picPlayer.Location = Loc
            End If
            If picPlayer.Bounds.IntersectsWith(wall14.Bounds) Then
                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                picPlayer.Location = Loc
            End If
            If picPlayer.Bounds.IntersectsWith(wall2.Bounds) Then
                Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                picPlayer.Location = Loc
                If Not wall2.Location.Y - 5 < 0 Then
                    XYZ = New Point(wall2.Location.X, wall2.Location.Y - 5)
                    wall2.Location = XYZ
                    If wall2.Bounds.IntersectsWith(wall4.Bounds) Then
                        XYZ = New Point(wall2.Location.X, wall2.Location.Y + 5)
                        wall2.Location = XYZ
                    End If
                End If
                If picPlayer.Bounds.IntersectsWith(wall3.Bounds) Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                    picPlayer.Location = Loc
                    If Not wall3.Location.Y - 5 < 0 Then
                        XYZ = New Point(wall3.Location.X, wall3.Location.Y - 5)
                        wall2.Location = XYZ
                        If wall3.Bounds.IntersectsWith(wall4.Bounds) Then
                            XYZ = New Point(wall3.Location.X, wall3.Location.Y + 5)
                            wall3.Location = XYZ
                        End If
                    End If
                End If
            End If
        End If

        If picPlayer.Bounds.IntersectsWith(picend.Bounds) Then

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

                        intread2 = 3
                        outupdate = IO.File.CreateText(strname & "level")

                        outupdate.WriteLine(intread2)

                        strshow2 = intread2

                        outupdate.Close()

                    Else
                        intread2 = 3
                        outupdate = IO.File.CreateText(strname & "level")

                        outupdate.WriteLine(intread2)

                        strshow2 = intread2

                        outupdate.Close()
                    End If
                Loop
            End If


            System.Threading.Thread.Sleep(200)
            Back.BringToFront()
            level3.Show()
            Me.Close()
        End If
    End Sub
End Class