Public Class SelectionNotManager

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Edit.Show()
    End Sub

    Private Sub SelectionNotManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = LoginPage.username
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        LoginPage.Show()
    End Sub
End Class