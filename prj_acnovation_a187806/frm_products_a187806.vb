Public Class frm_products_a187806
    Private Sub frm_products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim productsDatatable = ExecuteSqlAndRetrieveDatatable("SELECT * FROM TBL_PRODUCTS_A187806")
        grd_table.DataSource = productsDatatable
    End Sub
End Class