Public Class Menu2

    Private Sub Menu2_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Windows.Forms.Cursor.Hide()
    End Sub

    Private Sub Menu2_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Opacity = 0.75
        Me.Enabled = False
        Windows.Forms.Cursor.Show()
    End Sub
End Class