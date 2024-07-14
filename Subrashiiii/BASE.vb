Public Class BASE

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        RECORD.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        mypopulate("select * from criminall.users", REGISTER.DataGridView1)
        REGISTER.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        LOGIN.Show()
        Me.Hide()
    End Sub
End Class