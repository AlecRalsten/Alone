Public Class Back

    Private Sub Back_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.BringToFront()
        Me.Enabled = False
    End Sub
End Class