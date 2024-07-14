
Public Class RECORD

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim laman As Integer = DataGridView1.Rows.Count
        Dim Qt As String = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Dim Address As String = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        Dim Num As Integer = selectspecific("select Keynum from criminall.basic where Name = '" & Qt & "' and Address = '" & Address & "'")

        If laman = 0 Then
            Exit Sub
        End If
        Try
            RECORD2.Label1.Text = Qt
            RECORD2.Label2.Text = Num
            RECORD2.Show()
            Me.Hide()
            mypopulate("select Casess, Date, Details from criminall.cases where Keynum = '" & Num & "' and Status = '" & "Not" & "'", RECORD2.DataGridView1)

        Catch ex As Exception
            MsgBox("Fill the missing blank", MsgBoxStyle.YesNo)
        End Try
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Dim latest As Integer
        latest = Val(selectspecific("select Keynum from criminall.basic order by Keynum desc limit 1")) + 1
        nonquery("insert into criminall.basic values(" & latest & ",'" & BunifuMaterialTextbox1.Text & "','" & BunifuMaterialTextbox2.Text & "','" & "Not" & "')")
        mypopulate("select Name, Address from criminall.basic where Status = '" & "Not" & "'", DataGridView1)
        BunifuMaterialTextbox1.Text = "Name"
        BunifuMaterialTextbox2.Text = "Address"
        MsgBox("Successfully Added")
    End Sub

    Private Sub RECORD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mypopulate("select Name, Address from criminall.basic where Status = '" & "Not" & "'", DataGridView1)
    End Sub

    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        Dim Name As String
        Dim Address As String
        Dim Num As Integer

        Name = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        Address = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        Num = selectspecific("select Keynum from criminall.basic where Name = '" & Name & "' and Address = '" & Address & "'")

        MsgBox("Are you sure you want to delete this information?", MsgBoxStyle.YesNo)
        If MsgBoxResult.Yes Then
            nonquery("update criminall.basic set Status = '" & "Archived" & "' where Keynum = '" & Num & "'")
            nonquery("update criminall.cases set Status = '" & "Archived" & "' where Keynum = '" & Num & "'")
            mypopulate("select Name, Address from criminall.basic where Status = '" & "Not" & "'", DataGridView1)
        ElseIf MsgBoxResult.No Then
            Me.Show()
        End If
    End Sub

    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        mypopulate("select Name, Address from criminall.basic where Status = '" & "Archived" & "'", ARCHIVE.DataGridView1)
        ARCHIVE.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuThinButton23_Click(sender As Object, e As EventArgs) Handles BunifuThinButton23.Click
        BASE.Show()
        Me.Hide()
    End Sub
End Class

