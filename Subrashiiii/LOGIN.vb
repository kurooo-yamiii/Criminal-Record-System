Public Class LOGIN

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim Username As String
        Dim Password As String
        Username = selectspecific("select Username from criminall.users where username = '" & BunifuMaterialTextbox1.Text & "'")
        Password = selectspecific("select Password from criminall.users where username = '" & BunifuMaterialTextbox1.Text & "'")

        If Username = BunifuMaterialTextbox1.Text And Password = BunifuMaterialTextbox2.Text Then
            MsgBox("Login Successfully")
            BASE.Show()
            Me.Hide()
        ElseIf BunifuMaterialTextbox1.Text = "" And BunifuMaterialTextbox2.Text = "" Then
            MsgBox("Unable to Login")

        Else
            MsgBox("Unable to Login")
        End If
    End Sub
End Class
