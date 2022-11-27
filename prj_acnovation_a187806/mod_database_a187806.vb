Module mod_database_a187806
    Const dbConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../data/DB_ACNOVATION_A187806.accdb;Persist Security Info=False;"

    Public Function ExecuteSqlAndRetrieveDatatable(ByVal sqlStatement As String) As DataTable
        Dim datatable As New DataTable
        Dim reader As New OleDb.OleDbDataAdapter(sqlStatement, dbConnectionString)
        reader.Fill(datatable)
        Return datatable
    End Function

End Module
