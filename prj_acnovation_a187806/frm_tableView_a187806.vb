Public Class frm_tableView_a187806
    Dim title As String = "Title"
    Dim sqlStatement As String = "SHOW TABLES"
    Sub New(title As String, sqlStatement As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.title = title
        Me.sqlStatement = sqlStatement
    End Sub

    Private Sub frm_tableView_a187806_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_title.Text = title

        Dim dataTable = GetDataTableFromSelectStatment(sqlStatement)
        grd_table.DataSource = dataTable
    End Sub
End Class