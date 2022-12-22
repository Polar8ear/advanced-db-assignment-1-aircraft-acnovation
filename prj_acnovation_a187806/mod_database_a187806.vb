Module mod_database_a187806
    Private Const dbConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../data/DB_ACNOVATION_A187806.accdb;Persist Security Info=False;"
    Private dbConnection As New OleDb.OleDbConnection(dbConnectionString)
    Class SuccessState
        Public ReadOnly success As Boolean
        Public ReadOnly exception As Exception

        Public Sub New()
            Me.success = True
        End Sub

        Public Sub New(exception As Exception)
            Me.success = False
            Me.exception = exception
        End Sub
    End Class

    Public Function GetDataTableFromSelectStatment(ByVal sqlStatement As String) As DataTable
        Dim datatable As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(sqlStatement, dbConnection)
        reader.Fill(datatable)
        Return datatable
    End Function

    Public Function ExecuteSqlStatement(ByVal sqlStatement As String) As SuccessState
        Dim writer As New OleDb.OleDbCommand(sqlStatement, dbConnection)

        Try
            writer.Connection.Open()
            writer.ExecuteNonQuery()
        Catch ex As Exception
            Return New SuccessState(ex)
        Finally
            writer.Connection.Close()
        End Try

        Return New SuccessState()
    End Function
End Module
