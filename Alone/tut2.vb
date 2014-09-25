Public Class tut2
    Dim strname As String
    Dim inupdate As IO.StreamReader
    Dim strread As String
    Dim intread As Integer
    Dim strshow As String
    Dim inuser As IO.StreamReader
    Dim outupdate As IO.StreamWriter
    Dim intentered As Integer
    Dim intGold1 As Integer
    Dim intGold2 As Integer
    Dim inupdate2 As IO.StreamReader
    Dim strread2 As String
    Dim intread2 As Integer
    Dim strshow2 As String

    Private Sub tut2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
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
                    If picPlayer.Bounds.IntersectsWith(wall.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                        picPlayer.Location = Loc
                    End If
                End If
            Case "s"  ' down
                picPlayer.Image = My.Resources.player
                If Not picPlayer.Location.Y - 5 > Me.Height - picPlayer.Height * 1.2 Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc
                    If picPlayer.Bounds.IntersectsWith(wall.Bounds) Then
                        Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                        picPlayer.Location = Loc
                    End If
                End If
        End Select

        If picPlayer.Location.X = 114 Then
            gold.Hide()
            gold1.Show()
        End If

        If picPlayer.Location.X = 112 Then
            lblShadows.Hide()
            picend.Show()
        End If

        If picPlayer.Location.X = 532 Then
            finalt.Show()
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
                            gold1.Hide()
                            gold2.Show()
                            Me.Refresh()
                        Else

                            outupdate = IO.File.CreateText(strname & "gold")

                            outupdate.WriteLine("1")

                            outupdate.Close()
                            intGold1 = 1
                            picGold.Hide()
                            gold1.Hide()
                            gold2.Show()
                            Me.Refresh()
                        End If
                    Loop
                End If
            End If
        End If


        If picPlayer.Bounds.IntersectsWith(picGold2.Bounds) Then
            If intGold2 = 0 Then
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

                            intread = intread + 10
                            outupdate = IO.File.CreateText(strname & "gold")

                            outupdate.WriteLine(intread)

                            outupdate.Close()
                            intGold2 = 1
                            picGold2.Hide()
                            gold2.Hide()
                            lblPortal.Show()
                            button1.Show()
                            Me.Refresh()
                        Else

                            outupdate = IO.File.CreateText(strname & "gold")

                            outupdate.WriteLine("10")

                            outupdate.Close()
                            intGold2 = 1
                            picGold2.Hide()
                            lblPortal.Show()
                            gold2.Hide()
                            button1.Show()
                            Me.Refresh()
                        End If
                    Loop
                End If
            End If
        End If

        If picPlayer.Bounds.IntersectsWith(button1.Bounds) Then
            button1.Hide()
            portal1.Show()
            portal2.Show()
            portal1.Enabled = True
        End If

        If picPlayer.Bounds.IntersectsWith(portal1.Bounds) Then
            If portal1.Enabled = True Then
                Loc = New Point(portal2.Location.X, portal2.Location.Y)
                picPlayer.Location = Loc
                portal2.Hide()
                portal1.Hide()
                lblPortal.Hide()
                lblShadows.Show()
                shadow.Show()
                shadow2.Show()
                shadow3.Show()
                shadow4.Show()
                shadow5.Show()
                shadow6.Show()
                shadow7.Show()
            End If
        End If

        If picPlayer.Bounds.IntersectsWith(picend.Bounds) Then
            System.Threading.Thread.Sleep(200)
            Windows.Forms.Cursor.Show()
            level1.Show()
            Me.Close()
        End If

        Label1.Text = picPlayer.Location.X
    End Sub

    Private Sub tut2_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        finalt.Hide()
        gold1.Hide()
        gold2.Hide()
        lblShadows.Hide()
        lblPortal.Hide()
        button1.Hide()
        portal1.Hide()
        portal2.Hide()
        picend.Hide()
        shadow.Hide()
        shadow2.Hide()
        shadow3.Hide()
        shadow4.Hide()
        shadow5.Hide()
        shadow6.Hide()
        shadow7.Hide()
        portal1.Enabled = False
    End Sub
End Class