Public Class ARCHIVE

    Private Sub ARCHIVE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mypopulate("select Name, Address from criminall.basic where Status = '" & "Archived" & "'", DataGridView1)
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim Name As String
        Dim Num As Integer
        Dim Address As String
       
        Address = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        Name = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Num = selectspecific("select Keynum from criminall.basic where Name = '" & Name & "' and Address = '" & Address & "'")
        
        nonquery("update criminall.basic set Status = '" & "Not" & "' where Keynum = '" & Num & "'")
        nonquery("update criminall.cases set Status = '" & "Not" & "' where Keynum = '" & Num & "'")
        mypopulate("select Name, Address from criminall.basic where Status = '" & "Archived" & "'", DataGridView1)
        MsgBox("Restored Successfully")
    End Sub
    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        mypopulate("select Name, Address from criminall.basic where Status = '" & "Not" & "'", RECORD.DataGridView1)
        RECORD.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class