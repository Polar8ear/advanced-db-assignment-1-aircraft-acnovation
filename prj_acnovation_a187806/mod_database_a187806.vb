Module mod_database_a187806
    Private Const dbConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../data/DB_ACNOVATION_A187806.accdb;Persist Security Info=False;"
    Private dbConnection As New OleDb.OleDbConnection(dbConnectionString)

    Public Function GetDataTableFromSelectStatment(ByVal sqlStatement As String) As DataTable
        Dim datatable As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(sqlStatement, dbConnection)
        reader.Fill(datatable)
        Return datatable
    End Function

End Module
