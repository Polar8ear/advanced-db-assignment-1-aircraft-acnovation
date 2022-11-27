Public Class frm_orders_a187806
    Private Sub frm_orders_a187806_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ordersDatatable = ExecuteSqlAndRetrieveDatatable("SELECT * FROM TBL_ORDERS_A187806")
        grd_table.DataSource = ordersDatatable
    End Sub
End Class