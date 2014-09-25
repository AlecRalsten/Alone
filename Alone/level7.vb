Public Class level7
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


    Private Sub level8_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim Loc As Point


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
                End If
            Case "d"  ' right
                picPlayer.Image = My.Resources.playerR
                If Not picPlayer.Location.X + 5 > Me.Width - picPlayer.Width - 5 Then
                    Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
            Case "w"  ' up
                picPlayer.Image = My.Resources.playerU
                If Not picPlayer.Location.Y - 5 < 0 Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                    picPlayer.Location = Loc
                End If
            Case "s"  ' down
                picPlayer.Image = My.Resources.player
                If Not picPlayer.Location.Y - 5 > Me.Height - picPlayer.Height * 1.2 Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc
                End If
        End Select

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

                        intread2 = 8
                        outupdate = IO.File.CreateText(strname & "level")

                        outupdate.WriteLine(intread2)

                        strshow2 = intread2

                        outupdate.Close()

                    Else
                        intread2 = 8
                        outupdate = IO.File.CreateText(strname & "level")

                        outupdate.WriteLine(intread2)

                        strshow2 = intread2

                        outupdate.Close()
                    End If
                Loop
            End If

            System.Threading.Thread.Sleep(200)
            level8.Show()
            Me.Close()
        End If

    End Sub
End Class