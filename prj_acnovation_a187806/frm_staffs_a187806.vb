Public Class frm_staffs_a187806
    Dim frm_staffsList_a187806 As frm_tableView_a187806

    Private Sub btn_table_Click(sender As Object, e As EventArgs) Handles btn_table.Click
        If frm_staffsList_a187806 Is Nothing Then
            frm_staffsList_a187806 = New frm_tableView_a187806("Staffs",
                "SELECT  
                    FLD_STAFF_ID AS [ID],  
                    FLD_NAME AS [Name]  
                FROM TBL_STAFFS_A187806")
        End If
        frm_staffsList_a187806.Show()
        Hide()
    End Sub

    Function validateName()
        Return txt_name.Text.Length <= 255
    End Function

    Private Sub txt_name_TextChanged(sender As Object, e As EventArgs) Handles txt_name.TextChanged
        If validateName() Then
            err.Clear()
            btn_save.Enabled = True
        Else
            err.SetError(txt_name, "PLease enter a name less than 255 characters")
        End If
    End Sub

    Private Function getNewId()
        Dim lastIdDataTable = GetDataTableFromSelectStatment("SELECT MAX(FLD_STAFF_ID) AS MAX_FLD_ID FROM TBL_STAFFS_A187806")

        If lastIdDataTable.Rows.Count <= 0 Then Return 0

        Dim lastId = Integer.Parse(lastIdDataTable.Rows(0).Item("MAX_FLD_ID"))

        Return lastId + 1
    End Function
    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        txt_id.Text = getNewId()
        txt_name.Clear()
    End Sub

    Private Sub refreshIds()
        Dim ids = GetDataTableFromSelectStatment("SELECT FLD_STAFF_ID FROM TBL_STAFFS_A187806 ORDER BY 1")
        lst_staffs.DataSource = ids
    End Sub

    Private Sub refreshData()
        Dim dataTable = GetDataTableFromSelectStatment($"
            SELECT
                FLD_NAME  
            From TBL_STAFFS_A187806
            WHERE FLD_STAFF_ID = {txt_id.Text}")

        Dim staffData = dataTable.Rows(0)
        txt_name.Text = staffData.Item("FLD_NAME")
    End Sub
    Private Sub lst_staffs_SelectedIndexChanged(sender As Object, e As EventArgs)
        txt_id.Text = lst_staffs.SelectedItem.Item("FLD_STAFF_ID")
        refreshData()

        btn_save.Enabled = False
    End Sub

    Private Sub frm_staffs_a187806_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lst_staffs.DisplayMember = "FLD_STAFF_ID"
        AddHandler lst_staffs.SelectedIndexChanged, AddressOf lst_staffs_SelectedIndexChanged
        refreshIds()

        btn_save.Enabled = False
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox($"Are you sure you want to delete staff of ID {txt_id.Text}",
                                         MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then
            Beep()

            Dim state = ExecuteSqlStatement($"DELETE FROM TBL_STAFFS_A187806 WHERE FLD_STAFF_ID = {txt_id.Text}")

            If state.success Then
                MsgBox($"The staff of ID {txt_id.Text} has been successfully deleted.")
                refreshIds()
            Else
                MsgBox($"Delete failed. {vbCrLf}{vbCrLf}{state.exception.Message}")
            End If
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If Not validateName() Then
            MsgBox("Please ensure your name is less than 255 characters")
            Exit Sub
        End If

        Dim state As SuccessState

        If txt_id.Text = getNewId() Then
            state = ExecuteSqlStatement($"INSERT INTO TBL_STAFFS_A187806 (
                FLD_STAFF_ID,
                FLD_NAME
            ) VALUES (
                {txt_id.Text},
                '{txt_name.Text}'
            )")
            refreshIds()
        Else
            state = ExecuteSqlStatement($"UPDATE TBL_STAFFS_A187806 SET
                FLD_NAME = '{txt_name.Text}',
            WHERE FLD_STAFF_ID = {txt_id.Text}
            ")
        End If

        If state.success Then
            Beep()
            MsgBox("Succesffully saved.")
        Else
            MsgBox($"Error Occured:{vbCrLf}{vbCrLf}{state.exception.Message}")
        End If
    End Sub
End Class


