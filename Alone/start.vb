Public Class start

    'Private Sub Msgbox_Yes_No()
    '    Dim Response As Integer

    '    ' Displays a message box with the yes and no options.
    '    Response = MsgBox(Prompt:="Do you want to see the tutorial?", Buttons:=vbYesNo)

    '    ' If statement to check if the yes button was selected.
    '    If Response = vbYes Then
    '        Dim lt As New tut
    '        lt.Show()
    '        Call Play()
    '    Else
    '        ' The no button was selected.
    '        Dim l1 As New level1
    '        l1.Show()
    '        Call Play()
    '    End If

    'End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        login.Show()
        Me.Close()

        'Dim bc As New Back
        '' Display the white background
        'bc.Show()
        '' Shows mesage box
        'Call Msgbox_Yes_No()
        'Me.Hide()
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
    'Sub Play()
    '    My.Computer.Audio.Play(My.Resources.lost,
    '          AudioPlayMode.BackgroundLoop)
    'End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)
        create.Show()
    End Sub

    Private Sub start_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Back.Show()
    End Sub
End Class