Public Class RECORD2

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        nonquery("insert into criminall.cases values('" & Label2.Text & "','" & Label1.Text & "','" & BunifuMaterialTextbox2.Text & "','" & BunifuMaterialTextbox3.Text & "','" & BunifuMaterialTextbox1.Text & "','" & "Not" & "')")
        mypopulate("select Casess, Date, Details from criminall.cases where Keynum = '" & Label2.Text & "' and Status = '" & "Not" & "'", DataGridView1)
        MsgBox("Added Successfully")
        BunifuMaterialTextbox2.Text = "Cases"
        BunifuMaterialTextbox3.Text = "Date"
        BunifuMaterialTextbox1.Text = "Details"
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim laman As Integer = DataGridView1.Rows.Count
        Dim Qt As String

        Qt = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        If laman = 0 Then
            Exit Sub
        End If
        Try
            MsgBox(Qt)

        Catch ex As Exception
            MsgBox("Fill the missing blank", MsgBoxStyle.YesNo)
        End Try
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        Dim Casess As String
        Dim Details As String
        Dim Num As Integer

        Casess = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Details = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        Num = Label2.Text

        MsgBox("Are you sure you want to delete this case?", MsgBoxStyle.YesNo)
        If MsgBoxResult.Yes Then
            nonquery("update criminall.cases set Status = '" & "Archived" & "' where Keynum = '" & Num & "' and Details = '" & Details & "'")
            mypopulate("select Casess, Date, Details from criminall.cases where Status = '" & "Not" & "' and Keynum = '" & Num & "'", DataGridView1)
        ElseIf MsgBoxResult.No Then
            Me.Show()
        End If
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        RECORD.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        mypopulate("select Casess, Date, Details from criminall.cases where Status = '" & "Archived" & "' and Keynum = '" & Label2.Text & "'", ARCHIVE2.DataGridView1)
        ARCHIVE2.Show()
        Me.Hide()
    End Sub
End Class