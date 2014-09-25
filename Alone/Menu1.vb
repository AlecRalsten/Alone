Public Class Menu1



    Private Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Integer, ByVal dwExtraInfo As Integer)

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles b2.Click
        Call Msgboxclose()
    End Sub

    Private Sub b3_Click(sender As System.Object, e As System.EventArgs) Handles b3.Click
        Windows.Forms.Cursor.Hide()
        Menu2.Close()
        Me.Close()
    End Sub

    Private Sub GMenu_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Menu2.Show()
        Me.Refresh()
    End Sub


    Private Sub Msgboxclose()
        Dim Response As Integer

        ' Displays a message box with the yes and no options.
        Response = MsgBox(Prompt:="Are you shure you want to quit?", Buttons:=vbYesNo)

        ' If statement to check if the yes button was selected.
        If Response = vbYes Then
            Application.Exit()
        Else
            ' The no button was selected.
            Me.Refresh()
        End If

    End Sub

    Private Sub Msgboxmenu()
        Dim Response As Integer

        ' Displays a message box with the yes and no options.
        Response = MsgBox(Prompt:="Are you shure you want to go to the menu?", Buttons:=vbYesNo)

        ' If statement to check if the yes button was selected.
        If Response = vbYes Then

            If IO.File.Exists(logedin.strname & "gold") = True Then
                logedin.inupdate2 = IO.File.OpenText(logedin.strname & "gold")

                logedin.strread2 = logedin.inupdate2.ReadLine

                logedin.intread2 = logedin.strread2.ToString

                logedin.strshow2 = logedin.intread2

                logedin.inupdate2.Close()
            Else
                logedin.strshow2 = ("0")
            End If

            logedin.Label2.Text = logedin.strshow2
            logedin.lblupdate.Text = logedin.strshow

            If IO.File.Exists("logedin") = True Then
                logedin.inuser = IO.File.OpenText("logedin")
                Do Until logedin.inuser.Peek = -1
                    ' read a name
                    logedin.strname = logedin.inuser.ReadLine
                    If IO.File.Exists(logedin.strname & "level") = True Then
                        logedin.inupdate2 = IO.File.OpenText(logedin.strname & "level")

                        logedin.strread2 = logedin.inupdate2.ReadLine

                        logedin.intread2 = logedin.strread2.ToString

                        logedin.inupdate2.Close()
                        Me.Refresh()
                    End If
                Loop
            End If

            If logedin.intread2 = 0 Then
                logedin.Button5.Enabled = False
                logedin.Button5.Hide()
                logedin.Button3.Text = "Start"
            Else
                logedin.Button5.Enabled = True
                logedin.Button5.Show()
                logedin.Button3.Text = "New Game"
            End If

            If level1.Created = True Then
                level1.Close()
            End If

            If level3.CanFocus = True Then
                level3.Close()
            End If

            If level5.Created = True Then
                level5.Close()
            End If

            If Level4.Created = True Then
                Level4.Close()
            End If

            If level6.Created = True Then
                level6.Close()
            End If

            If level2.Created = True Then
                level2.Close()
            End If

            If level8.Created = True Then
                level8.Close()
            End If

            If level7.Created = True Then
                level7.Close()
            End If

            If Menu2.Created = True Then
                Menu2.Close()
            End If


            logedin.Refresh()
            logedin.Show()

            Me.Close()

        Else
            ' The no button was selected.
            Me.Refresh()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Call keybd_event(CByte(System.Windows.Forms.Keys.VolumeUp), 0, 0, 0)
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Call keybd_event(CByte(System.Windows.Forms.Keys.VolumeDown), 0, 0, 0)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Call keybd_event(CByte(System.Windows.Forms.Keys.VolumeMute), 0, 0, 0)
    End Sub

    Private Sub b1_Click(sender As System.Object, e As System.EventArgs) Handles b1.Click
        Call Msgboxmenu()
    End Sub
End Class