Public Class frm_staffs_a187806
    Private Sub frm_staffs_a187806_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim staffsDatatable = ExecuteSqlAndRetrieveDatatable("SELECT * FROM TBL_STAFFS_A187806")
        grd_table.DataSource = staffsDatatable
    End Sub
End Class