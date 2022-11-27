Public Class frm_customers_a187806
    Private Sub frm_customers_a187806_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim customersDatatable = ExecuteSqlAndRetrieveDatatable("SELECT * FROM TBL_CUSTOMERS_A187806")
        grd_table.DataSource = customersDatatable
    End Sub
End Class