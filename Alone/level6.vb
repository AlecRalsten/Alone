Public Class level6
    Dim shown1 As Integer
    Dim hidden As Integer
    Dim HP As Integer = 10
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
    Dim intGold1 As Integer
    Private Sub level6_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Dim Loc As Point
        Dim key As Integer

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
                If picPlayer.Bounds.IntersectsWith(Shadow1.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow10.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow11.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow12.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow13.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow15.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow16.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow17.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow19.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(Shadow2.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow20.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow24.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow3.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow4.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow5.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow6.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow7.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow8.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow9.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
            Case "d"  ' right
                picPlayer.Image = My.Resources.playerR
                If Not picPlayer.Location.X + 5 > Me.Width - picPlayer.Width - 5 Then
                    Loc = New Point(picPlayer.Location.X + 5, picPlayer.Location.Y)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(Shadow1.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow10.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow11.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow12.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow13.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow15.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow16.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow17.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow19.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(Shadow2.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow20.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow24.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow3.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow4.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow5.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow6.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow7.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow8.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow9.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
            Case "w"  ' up
                picPlayer.Image = My.Resources.playerU
                If Not picPlayer.Location.Y - 5 < 0 Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y - 5)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(Shadow1.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow10.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow11.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow12.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow13.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow15.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow16.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow17.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow19.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(Shadow2.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow20.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow24.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow3.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow4.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow5.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow6.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow7.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow8.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                    If HP = 0 Then
                        Me.Close()
                    End If
                End If
                If picPlayer.Bounds.IntersectsWith(shadow9.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
            Case "s"  ' down
                picPlayer.Image = My.Resources.player
                If Not picPlayer.Location.Y - 5 > Me.Height - picPlayer.Height * 1.2 Then
                    Loc = New Point(picPlayer.Location.X, picPlayer.Location.Y + 5)
                    picPlayer.Location = Loc
                End If
                If picPlayer.Bounds.IntersectsWith(Shadow1.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow10.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow11.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow12.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow13.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow15.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow16.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow17.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow19.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(Shadow2.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow20.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow24.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow3.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow4.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow5.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow6.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow7.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow8.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
                If picPlayer.Bounds.IntersectsWith(shadow9.Bounds) Then
                    Loc = New Point(269, 552)
                    picPlayer.Location = Loc
                    HP = HP - 2
                End If
        End Select


        ' get first key
        If picPlayer.Bounds.IntersectsWith(key1.Bounds) Then
            key = 1
            key1.Hide()
            portal1.Visible = True
            portal2.Visible = True
        End If

        ' teleport
        If picPlayer.Bounds.IntersectsWith(portal1.Bounds) Then
            Loc = New Point(12, 523)
            picPlayer.Location = Loc
            key2.Visible = True
        End If

        ' teleport
        If picPlayer.Bounds.IntersectsWith(portal2.Bounds) Then
            Loc = New Point(269, 552)
            picPlayer.Location = Loc
        End If

        ' get second key
        If picPlayer.Bounds.IntersectsWith(key2.Bounds) Then
            picend.Enabled = True
            key = 2
            key2.Hide()
            picend.Visible = True
        End If

        ' blink shadows
        If shown1 = 0 Then
            Shadow1.Show()
            shadow3.Show()
            shadow5.Hide()
            shadow6.Hide()
            shadow7.Hide()
            shadow12.Hide()
            shadow11.Hide()
            shadow15.Hide()
            shadow16.Hide()
            shadow17.Hide()
            shadow19.Hide()
            shadow20.Hide()
            shadow9.Hide()
            shadow24.Hide()
            shadow10.Show()
            shadow13.Show()
            shadow4.Show()
            shadow8.Show()
            shadow9.Show()
            Shadow2.Show()
        ElseIf shown1 = 1 Then
            Shadow1.Hide()
            shadow3.Hide()
            shadow5.Show()
            shadow6.Show()
            shadow7.Show()
            shadow12.Show()
            shadow11.Show()
            shadow15.Show()
            shadow16.Show()
            shadow17.Show()
            shadow19.Show()
            shadow20.Show()
            shadow9.Show()
            shadow24.Show()
            shadow10.Hide()
            shadow13.Hide()
            shadow4.Hide()
            shadow8.Hide()
            shadow9.Hide()
            Shadow2.Hide()
        End If

        If shown1 = 0 Then
            hidden = 0
        ElseIf shown1 = 1 Then
            hidden = 1
        ElseIf shown1 = 2 Then
            hidden = 1
        End If

        If hidden = 0 Then
            shown1 = Int(Rnd() * 2) + 0
        ElseIf hidden = 1 Then
            shown1 = Int(Rnd() * 2) + 0
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

                            intread = intread + 10
                            outupdate = IO.File.CreateText(strname & "gold")

                            outupdate.WriteLine(intread)

                            outupdate.Close()
                            intGold1 = 1
                            picGold.Hide()
                            Me.Refresh()
                        Else

                            outupdate = IO.File.CreateText(strname & "gold")

                            outupdate.WriteLine("10")

                            outupdate.Close()
                            intGold1 = 1
                            picGold.Hide()
                            Me.Refresh()
                        End If
                    Loop
                End If
            End If
        End If

        If picend.Enabled = True Then
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

                            intread2 = 7
                            outupdate = IO.File.CreateText(strname & "level")

                            outupdate.WriteLine(intread2)

                            strshow2 = intread2

                            outupdate.Close()

                        Else
                            intread2 = 7
                            outupdate = IO.File.CreateText(strname & "level")

                            outupdate.WriteLine(intread2)

                            strshow2 = intread2

                            outupdate.Close()
                        End If
                    Loop
                End If

                System.Threading.Thread.Sleep(200)
                level7.Show()
                Me.Close()
            End If
        End If


        lblHP.Text = HP.ToString

        If HP = 0 Then
            picPlayer.Image = My.Resources.shadow
            Windows.Forms.Cursor.Show()
            MsgBox("You have been consumed by the shadows")
            logedin.Refresh()
            logedin.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Level5_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        picend.Enabled = False
        portal1.Visible = False
        portal2.Visible = False
        picend.Visible = False
        key2.Visible = False
        shown1 = Int(Rnd() * 2) + 0
        hidden = 1
        lblHP.Text = HP.ToString
    End Sub
End Class