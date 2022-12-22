Imports System.Text.RegularExpressions

Public Class frm_customers_a187806
    Dim frm_customersList_a187806 As frm_tableView_a187806

    Private Function validateContact()
        Return Regex.IsMatch(txt_contact.Text, isContactRegex)
    End Function

    Private Sub txt_contact_TextChanged(sender As Object, e As EventArgs) Handles txt_contact.TextChanged
        If validateContact() Then
            err.Clear()
            btn_save.Enabled = True
        Else
            err.SetError(txt_contact, "PLease enter a valid contact number following the format +XXXXXXXXXX")
        End If
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_table.Click
        If frm_customersList_a187806 Is Nothing Then
            frm_customersList_a187806 = New frm_tableView_a187806("Customers",
                "SELECT  
                    FLD_CUSTOMER_ID AS [ID],
                    FLD_NAME As [Name],  
                    FLD_CONTACT_NUMBER AS [Contact Number]  
                From TBL_CUSTOMERS_A187806")
        End If
        frm_customersList_a187806.Show()
        Hide()
    End Sub

    Private Function getNewId()
        Dim lastIdDataTable = GetDataTableFromSelectStatment("SELECT MAX(FLD_CUSTOMER_ID) AS MAX_FLD_ID FROM TBL_CUSTOMERS_A187806")

        If lastIdDataTable.Rows.Count <= 0 Then Return 0

        Dim lastId = Integer.Parse(lastIdDataTable.Rows(0).Item("MAX_FLD_ID"))

        Return lastId + 1
    End Function
    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        txt_id.Text = getNewId()
        txt_name.Clear()
        txt_contact.Clear()
    End Sub

    Private Sub refreshIds()
        Dim ids = GetDataTableFromSelectStatment("SELECT FLD_CUSTOMER_ID FROM TBL_CUSTOMERS_A187806 ORDER BY 1")
        lst_customers.DataSource = ids
    End Sub

    Private Sub refreshData()
        Dim dataTable = GetDataTableFromSelectStatment($"
            SELECT
                FLD_NAME,  
                FLD_CONTACT_NUMBER  
            From TBL_CUSTOMERS_A187806
            WHERE FLD_CUSTOMER_ID = {txt_id.Text}")

        Dim customerData = dataTable.Rows(0)
        txt_name.Text = customerData.Item("FLD_NAME")
        txt_contact.Text = customerData.Item("FLD_CONTACT_NUMBER")
    End Sub
    Private Sub lst_customers_SelectedIndexChanged(sender As Object, e As EventArgs)
        txt_id.Text = lst_customers.SelectedItem.Item("FLD_CUSTOMER_ID")
        refreshData()

        btn_save.Enabled = False
    End Sub

    Private Sub frm_customers_a187806_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lst_customers.DisplayMember = "FLD_CUSTOMER_ID"
        AddHandler lst_customers.SelectedIndexChanged, AddressOf lst_customers_SelectedIndexChanged
        refreshIds()

        btn_save.Enabled = False
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox($"Are you sure you want to delete customer of ID {txt_id.Text}",
                                         MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then
            Beep()

            ExecuteSqlStatement($"DELETE FROM TBL_CUSTOMERS_A187806 WHERE FLD_CUSTOMER_ID = {txt_id.Text}")

            MsgBox($"The product of ID {txt_id.Text} has been successfully deleted.")

            refreshIds()
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If Not validateContact() Then
            MsgBox("Please ensure your contact number follows the format: +XXXXXXXXXXX")
            Exit Sub
        End If

        If Not validateName() Then
            MsgBox("Please ensure your name is less than 255 characters")
            Exit Sub
        End If

        Dim state As SuccessState

        If txt_id.Text = getNewId() Then
            state = ExecuteSqlStatement($"INSERT INTO TBL_CUSTOMERS_A187806 (
                FLD_CUSTOMER_ID,
                FLD_NAME,
                FLD_CONTACT_NUMBER
            ) VALUES (
                {txt_id.Text},
                '{txt_name.Text}',
                '{txt_contact.Text}'
            )")
            refreshIds()
        Else
            state = ExecuteSqlStatement($"UPDATE TBL_CUSTOMERS_A187806 SET
                FLD_NAME = '{txt_name.Text}',
                FLD_CONTACT_NUMBER = '{txt_contact.Text}'
            WHERE FLD_CUSTOMER_ID = {txt_id.Text}
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
