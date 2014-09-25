Public Class logedin
    Public strname As String
    Public inupdate As IO.StreamReader
    Public inupdate2 As IO.StreamReader
    Dim strread As String
    Public strread2 As String
    Dim intread As Integer
    Public intread2 As Integer
    Public strshow As String
    Public strshow2 As String
    Public inuser As IO.StreamReader
    Dim outupdate As IO.StreamWriter
    Dim intentered As Integer
    Private load1, load2, load3 As String

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Call Msgbox_exit()
    End Sub

    Private Sub Msgbox_exit()
        Dim Response As Integer

        ' Displays a message box with the yes and no options.
        Response = MsgBox(Prompt:="Are you sure you want to exit the game?", Buttons:=vbYesNo)

        ' If statement to check if the yes button was selected.
        If Response = vbYes Then
            Application.Exit()
        Else
            ' The no button was selected.
            Me.Refresh()
        End If

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
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

                End If
            Loop
            inuser.Close()
        End If

        If intread2 = 0 Then
            ' Shows mesage box
            Call Msgbox_Yes_No()
            Me.Hide()
        Else
            Call Msgbox_newg()
        End If

    End Sub

    Sub Play()
        My.Computer.Audio.Play(My.Resources.Lost,
              AudioPlayMode.BackgroundLoop)
        Me.Close()
    End Sub

    Private Sub Msgbox_Yes_No()
        Dim Response As Integer

        ' Displays a message box with the yes and no options.
        Response = MsgBox(Prompt:="Do you want to see the tutorial?", Buttons:=vbYesNo)

        ' If statement to check if the yes button was selected.
        If Response = vbYes Then
            tut.Show()
            ' Call Play()
        Else
            ' The no button was selected.
            level1.Show()
            ' Call Play()
        End If

    End Sub

    Private Sub Msgbox_newg()
        Dim Response As Integer

        ' Displays a message box with the yes and no options.
        Response = MsgBox(Prompt:="If you start a new game you will loose your progress, are you sure you want to start a new game?", Buttons:=vbYesNo)

        ' If statement to check if the yes button was selected.
        If Response = vbYes Then

            Dim strLogedin

            If IO.File.Exists("username1") = True Then
                inuser = IO.File.OpenText("username1")
                Do Until inuser.Peek = -1
                    load1 = inuser.ReadLine
                Loop
                inuser.Close()
                If strname = load1 Then
                    strLogedin = "username1"
                End If
            End If

            If IO.File.Exists("username2") = True Then
                inuser = IO.File.OpenText("username2")
                Do Until inuser.Peek = -1
                    load2 = inuser.ReadLine
                Loop
                inuser.Close()
                If strname = load2 Then
                    strLogedin = "username2"
                    inuser.Close()
                End If
            End If

            If IO.File.Exists("username3") = True Then
                inuser = IO.File.OpenText("username3")
                Do Until inuser.Peek = -1
                    load3 = inuser.ReadLine
                Loop
                inuser.Close()
                If strname = load3 Then
                    strLogedin = "username3"
                End If
            End If


            If IO.File.Exists(strname) = True Then
                My.Computer.FileSystem.DeleteFile(strname)
            End If

            If IO.File.Exists(strLogedin) = True Then
                My.Computer.FileSystem.DeleteFile(strLogedin)
            End If

            If IO.File.Exists(strname & "gold") = True Then
                My.Computer.FileSystem.DeleteFile(strname & "gold")
            End If

            If IO.File.Exists(strname & "level") = True Then
                My.Computer.FileSystem.DeleteFile(strname & "level")
            End If

            If IO.File.Exists(strname & "reveal") = True Then
                My.Computer.FileSystem.DeleteFile(strname & "reveal")
            End If


            start.Show()
            Me.Close()

            'Back.Show()
            'Call Msgbox_Yes_No()
            'Me.Hide()
        Else
            ' The no button was selected.
            Me.Refresh()
        End If

    End Sub

    Private Sub logedin_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Refresh()
        If IO.File.Exists("logedin") = True Then
            inuser = IO.File.OpenText("logedin")
            Do Until inuser.Peek = -1
                ' read a name
                strname = inuser.ReadLine
                If IO.File.Exists(strname) = True Then
                    inupdate = IO.File.OpenText(strname)

                    strread = inupdate.ReadLine

                    intread = strread.ToString

                    strshow = intread

                    inupdate.Close()
                Else
                    strshow = ("0")
                End If
                If IO.File.Exists(strname & "gold") = True Then
                    inupdate2 = IO.File.OpenText(strname & "gold")

                    strread2 = inupdate2.ReadLine

                    intread2 = strread2.ToString

                    strshow2 = intread2

                    inupdate2.Close()
                Else
                    strshow2 = ("0")
                End If
            Loop
            inuser.Close()
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
                    Me.Refresh()
                End If
            Loop
            inuser.Close()
        End If

        If intread2 = 0 Then
            Button5.Enabled = False
            Button5.Hide()
            Button3.Text = "Start"
        Else
            Button5.Enabled = True
            Button5.Show()
            Button3.Text = "New Game"
        End If

        Label2.Text = strshow2
        lblupdate.Text = strshow
        Me.Refresh()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Achievements.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Store.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If intread2 = 1 Then
            level1.Show()
            Windows.Forms.Cursor.Hide()
            Me.Close()
        ElseIf intread2 = 2 Then
            level2.Show()
            Windows.Forms.Cursor.Hide()
            Me.Close()
        ElseIf intread2 = 3 Then
            level3.Show()
            Windows.Forms.Cursor.Hide()
            Me.Close()
        ElseIf intread2 = 4 Then
            Level4.Show()
            Windows.Forms.Cursor.Hide()
            Me.Close()
        ElseIf intread2 = 5 Then
            level5.Show()
            Windows.Forms.Cursor.Hide()
            Me.Close()
        ElseIf intread2 = 6 Then
            level6.Show()
            Windows.Forms.Cursor.Hide()
            Me.Close()
        ElseIf intread2 = 7 Then
            level7.Show()
            Windows.Forms.Cursor.Hide()
            Me.Close()
        ElseIf intread2 = 8 Then
            level8.Show()
            Windows.Forms.Cursor.Hide()
            Me.Close()
        End If

        Windows.Forms.Cursor.Hide()

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        levelselect.Show()
        Me.Close()
    End Sub
End Class