Public Class Store
    Dim strname As String
    Dim inupdate As IO.StreamReader
    Dim inupdate2 As IO.StreamReader
    Dim strread As String
    Dim strread2 As String
    Dim intread As Integer
    Dim intread2 As Integer
    Dim strshow As String
    Dim strshow2 As String
    Dim inuser As IO.StreamReader
    Dim outupdate As IO.StreamWriter

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        logedin.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        If IO.File.Exists("logedin") = True Then
            inuser = IO.File.OpenText("logedin")
            Do Until inuser.Peek = -1
                ' read a name
                strname = inuser.ReadLine
                If IO.File.Exists(strname & "gold") = True Then
                    inupdate2 = IO.File.OpenText(strname & "gold")

                    strread2 = inupdate2.ReadLine

                    intread2 = strread2.ToString

                    inupdate2.Close()

                    If intread2 >= 10 Then
                        intread2 = intread2 - 10
                        outupdate = IO.File.CreateText(strname & "gold")

                        outupdate.WriteLine(intread2)

                        strshow2 = intread2

                        outupdate.Close()

                        If IO.File.Exists(strname & "reveal") = True Then

                            inupdate = IO.File.OpenText(strname & "reveal")

                            strread = inupdate.ReadLine

                            intread = strread.ToString

                            inupdate.Close()

                            intread = intread + 1
                            outupdate = IO.File.CreateText(strname & "reveal")

                            outupdate.WriteLine(intread)

                            outupdate.Close()
                        Else
                            intread = intread + 1
                            outupdate = IO.File.CreateText(strname & "reveal")

                            outupdate.WriteLine(intread)

                            outupdate.Close()
                        End If
                    Else
                        MsgBox("You don't have enough Gold")
                    End If


                Else
                    strshow2 = ("0")
                End If
            Loop
        End If

        Label2.Text = strshow2
        Me.Refresh()

    End Sub

    Private Sub Store_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If IO.File.Exists("logedin") = True Then
            inuser = IO.File.OpenText("logedin")
            Do Until inuser.Peek = -1
                ' read a name
                strname = inuser.ReadLine
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
        End If

        Label2.Text = strshow2
    End Sub
End Class