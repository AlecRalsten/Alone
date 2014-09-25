Public Class Achievements
    Dim strname As String
    Dim inupdate As IO.StreamReader
    Dim inupdate2 As IO.StreamReader
    Dim strread As String
    Dim intread As Integer
    Dim strshow As String
    Dim inuser As IO.StreamReader
    Dim inA1 As IO.StreamReader
    Dim strA1 As String
    Dim intRead2 As Integer
    Dim strShow2 As String
    Dim outuser As IO.StreamWriter

    Private Sub Achevments_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Label1.Hide()
        Label2.Hide()

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
                End If
            Loop
        End If

        If strshow >= 25 Then
            If IO.File.Exists(strname & "A2") = True Then
                inA1 = IO.File.OpenText(strname & "A2")
                Do Until inA1.Peek = -1

                    strA1 = inA1.ReadLine

                    inA1.Close()

                    If strA1 = ("A2U") Then
                        Label1.Show()
                        Label2.Show()
                    Else
                        Label1.Hide()
                        Label2.Hide()
                    End If
                Loop
            Else
                outuser = IO.File.AppendText(strname & "A2")

                outuser.WriteLine("A2U")

                outuser.Close()

                Label1.Show()
                Label2.Show()
            End If
        ElseIf strshow >= 5 Then
            If IO.File.Exists(strname & "A1") = True Then
                inA1 = IO.File.OpenText(strname & "A1")
                Do Until inA1.Peek = -1

                    strA1 = inA1.ReadLine

                    inA1.Close()

                    If strA1 = ("A1U") Then
                        Label2.Show()
                    Else
                        Label2.Hide()
                    End If
                Loop
            Else
                outuser = IO.File.AppendText(strname & "A1")

                outuser.WriteLine("A1U")

                outuser.Close()

                Label2.Show()
            End If
        Else
            Label2.Hide()
        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        logedin.Show()
        Me.Close()
    End Sub
End Class