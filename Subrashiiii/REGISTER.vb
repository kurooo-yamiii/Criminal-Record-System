Public Class REGISTER

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        nonquery("insert into criminall.users values('" & BunifuMaterialTextbox2.Text & "','" & BunifuMaterialTextbox3.Text & "')")
        mypopulate("select * from criminall.users", DataGridView1)
        MsgBox("Account was created successfully")
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        Dim Username As String

        Username = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value

        MsgBox("Are you sure you want to delete this account?", MsgBoxStyle.YesNo)
        If MsgBoxResult.Yes Then
            nonquery("delete from criminall.users where Username = '" & Username & "'")
            mypopulate("select * from criminall.users", DataGridView1)
        ElseIf MsgBoxResult.No Then
            Me.Show()
        End If
        

    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        BASE.Show()
        Me.Hide()
    End Sub
End Class