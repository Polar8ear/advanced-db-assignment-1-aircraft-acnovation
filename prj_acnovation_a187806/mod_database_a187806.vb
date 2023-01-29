Module mod_database_a187806
    Private Const dbConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_ACNOVATION_A187806.accdb;Persist Security Info=False;"
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
        Using dbConnection As OleDb.OleDbConnection = GetDbConnection()
            Dim reader As New OleDb.OleDbDataAdapter(sqlStatement, dbConnection)
            reader.Fill(datatable)
            Return datatable
        End Using
    End Function

    Public Function ExecuteSqlStatement(ByVal sqlStatement As String) As SuccessState
        Using dbConnection As OleDb.OleDbConnection = GetDbConnection()
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
        End Using
    End Function

    Public Function GetDbConnection() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection(dbConnectionString)
    End Function
End Module
