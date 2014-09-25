Public Class create

    Private Sub btnCreate_Click(sender As System.Object, e As System.EventArgs) Handles btnCreate.Click

        Dim outuser As IO.StreamWriter
        Dim outpass As IO.StreamWriter
        Dim inuser As IO.StreamReader
        Dim inpass As IO.StreamReader
        Dim strname As String
        Dim strpass As String
        Dim intcheck1 As Integer
        Dim intcheck2 As Integer

        If txtName.Text = String.Empty Or txtPass.Text = String.Empty Then
            MsgBox("Username and Password can't be empty.")
        Else

            If IO.File.Exists("usernames") = True And IO.File.Exists("passwords") = True Then
                inuser = IO.File.OpenText("usernames")
                inpass = IO.File.OpenText("passwords")
                Do Until inuser.Peek = -1 And inpass.Peek = -1
                    ' read a name
                    strname = inuser.ReadLine
                    strpass = inpass.ReadLine
                    If strname = txtName.Text.Trim Then
                        MsgBox("Username already exists.")
                        intcheck1 = 1
                    End If
                    If strpass = txtPass.Text.Trim Then
                        MsgBox("password already exists.")
                        intcheck2 = 1
                    End If
                Loop
                If intcheck1 = 1 Then
                    inuser.Close()
                    Me.Refresh()
                ElseIf intcheck2 = 1 Then
                    inpass.Close()

                    Me.Refresh()
                Else
                    If txtPass.Text.Trim = txtpass2.Text.Trim Then
                        inuser.Close()

                        outuser = IO.File.AppendText("usernames")

                        outuser.WriteLine(txtName.Text.Trim)

                        outuser.Close()

                        inpass.Close()

                        outpass = IO.File.AppendText("passwords")

                        outpass.WriteLine(txtPass.Text.Trim)

                        outpass.Close()

                        start.Show()
                        Me.Close()
                    Else
                        MsgBox("Passwords do not match.")
                    End If
                End If

                ' close the file
                inuser.Close()
                inpass.Close()
            Else
                If txtPass.Text.Trim = txtpass2.Text.Trim Then
                    outuser = IO.File.AppendText("usernames")

                    outuser.WriteLine(txtName.Text.Trim)

                    outuser.Close()
                    outpass = IO.File.AppendText("passwords")

                    outpass.WriteLine(txtPass.Text.Trim)

                    outpass.Close()

                    start.Show()
                    Me.Close()
                Else
                    MsgBox("Passwords do not match.")
                End If
                End If
        End If

        'txtName.Text = String.Empty
        'txtPass.Text = String.Empty
        'txtName.Focus()

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        start.Show()
        Me.Close()
    End Sub
End Class