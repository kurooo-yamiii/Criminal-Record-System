Imports MySql.Data.MySqlClient


Module Module1
    Dim mycon As New MySqlConnection("server=localhost; port=3306;uid= 'root'; password = '';")

    Public Sub nonquery(ByVal utos As String)
        Dim sqlutos As New MySqlCommand(utos, mycon)
        Try
            mycon.Open()
            sqlutos.ExecuteNonQuery()
            mycon.Close()
        Catch ex As Exception
            mycon.Close()
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub mypopulate(ByVal utos As String, ByVal grid As DataGridView)
        Dim sqlutos As New MySqlCommand(utos, mycon)
        Dim adapter As New MySqlDataAdapter()
        Dim lamesa As New DataTable
        Try
            mycon.Open()
            adapter.SelectCommand = sqlutos
            adapter.Fill(lamesa)
            grid.DataSource = lamesa
            mycon.Close()
        Catch ex As Exception
            mycon.Close()
            MsgBox(ex.ToString)
        End Try
    End Sub
    Function selectspecific(ByVal utos As String)
        Dim sqlutos As New MySqlCommand(utos, mycon)
        Dim reader As MySqlDataReader
        Dim result As String = ""
        Try
            mycon.Open()
            reader = sqlutos.ExecuteReader()
            While reader.Read()
                result = reader(0)
            End While
            mycon.Close()
            Return result
        Catch ex As Exception
            mycon.Close()
            MsgBox(ex.ToString)
            Return Nothing
        End Try
    End Function
End Module
