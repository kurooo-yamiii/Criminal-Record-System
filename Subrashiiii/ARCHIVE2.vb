Public Class ARCHIVE2

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim Casess As String
        Dim Details As String

        Casess = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Details = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value

        nonquery("update criminall.cases set Status = '" & "Not" & "' where Casess = '" & Casess & "' and Details = '" & Details & "'")
        mypopulate("select Casess, Date, Details from criminall.cases where Status = '" & "Archived" & "' and Keynum = '" & RECORD2.Label2.Text & "'", DataGridView1)
        MsgBox("Restored Successfully")
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        Dim Num As Integer = RECORD2.Label2.Text
        mypopulate("select Casess, Date, Details from criminall.cases where Status = '" & "Not" & "' and Keynum = '" & Num & "'", RECORD2.DataGridView1)
        RECORD2.Show()
        Me.Hide()
    End Sub
End Class