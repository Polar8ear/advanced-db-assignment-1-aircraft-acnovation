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

    Private Sub btn_mainmenu_Click(sender As Object, e As EventArgs) Handles btn_mainmenu.Click
        Hide()
        frm_mainmenu_a187806.Show()
    End Sub

    Private Sub frm_tableView_a187806_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub
End Class