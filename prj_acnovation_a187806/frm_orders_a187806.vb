Public Class frm_orders_a187806
    Dim frm_ordersList_a187806 As frm_tableView_a187806
    Dim orderDetailsDatatable As DataTable
    Private Sub frm_orders_a187806_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lst_orders.DisplayMember = "FLD_ORDER_ID"
        AddHandler lst_orders.SelectedIndexChanged, AddressOf lst_orders_SelectedIndexChanged
        refreshIds()
        refreshStaffs()
        refreshCustomers()
        refreshData()
        btn_save.Enabled = False
    End Sub

    'Private Sub btn_table_Click(sender As Object, e As EventArgs) Handles btn_table.Click
    '    If frm_ordersList_a187806 Is Nothing Then
    '        frm_ordersList_a187806 = New frm_tableView_a187806("orders",
    '            "SELECT  
    '                FLD_STAFF_ID AS [ID],  
    '                FLD_NAME AS [Name]  
    '            FROM TBL_orders_A187806")
    '    End If
    '    frm_ordersList_a187806.Show()
    '    Hide()
    'End Sub

    Private Function getNewId()
        Dim lastIdDataTable = GetDataTableFromSelectStatment("SELECT MAX(FLD_ORDER_ID) AS MAX_FLD_ID FROM TBL_ORDERS_A187806")

        If lastIdDataTable.Rows.Count <= 0 Or TypeOf lastIdDataTable.Rows(0).Item("MAX_FLD_ID") Is DBNull Then Return 1

        Dim lastId = Integer.Parse(lastIdDataTable.Rows(0).Item("MAX_FLD_ID"))

        Return lastId + 1
    End Function

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        txt_id.Text = getNewId()
        cmb_staff.SelectedIndex = -1
        cmb_customer.SelectedIndex = -1

        btn_addProductItem.Enabled = True

        orderDetailsDatatable.Clear()

    End Sub

    Private Sub refreshIds()
        Dim ids = GetDataTableFromSelectStatment("SELECT FLD_ORDER_ID FROM TBL_ORDERS_A187806 ORDER BY 1")
        lst_orders.DataSource = ids
    End Sub

    Private Sub refreshStaffs()
        Dim staffs = GetDataTableFromSelectStatment("SELECT FLD_STAFF_ID, FLD_NAME FROM TBL_STAFFS_A187806 ORDER BY FLD_STAFF_ID")
        cmb_staff.DataSource = staffs
        cmb_staff.DisplayMember = "FLD_NAME"
        cmb_staff.SelectedIndex = -1
    End Sub

    Private Sub refreshCustomers()
        Dim customers = GetDataTableFromSelectStatment("SELECT FLD_CUSTOMER_ID, FLD_NAME FROM TBL_CUSTOMERS_A187806 ORDER BY FLD_CUSTOMER_ID")
        cmb_customer.DataSource = customers
        cmb_customer.DisplayMember = "FLD_NAME"
        cmb_customer.SelectedIndex = -1
    End Sub

    Private Sub refreshTotal()
        Dim total As Double = 0
        For Each row As DataRow In orderDetailsDatatable.Rows
            total += row("FLD_SUBTOTAL")
        Next row

        txt_total.Text = total.ToString("F")
    End Sub

    Private Sub refreshData()
        Dim orderData = GetDataTableFromSelectStatment($"
            SELECT
                FLD_ORDER_ID,
                FLD_PROCESSED_BY_STAFF_ID,
                FLD_ORDERED_BY_CUSTOMER_ID
            From TBL_ORDERS_A187806
            WHERE FLD_ORDER_ID = {txt_id.Text}
        ").Rows(0)

        For Each staffRow As DataRowView In cmb_staff.Items
            If staffRow.Item("FLD_STAFF_ID") = orderData.Item("FLD_PROCESSED_BY_STAFF_ID") Then
                cmb_staff.SelectedItem = staffRow
                Exit For
            End If
        Next

        For Each customerRow As DataRowView In cmb_customer.Items
            If customerRow.Item("FLD_CUSTOMER_ID") = orderData.Item("FLD_ORDERED_BY_CUSTOMER_ID") Then
                cmb_customer.SelectedItem = customerRow
                Exit For
            End If
        Next

        orderDetailsDatatable = GetDataTableFromSelectStatment($"
            SELECT 
                O.FLD_PRODUCT_ID, 
                O.FLD_QUANTITY, 
                P.FLD_PRODUCT_NAME, 
                P.FLD_PRICE
            FROM TBL_PRODUCTS_A187806 AS P 
            INNER JOIN TBL_ORDER_DETAILS_A187806 AS O 
            ON P.FLD_PRODUCT_ID = O.FLD_PRODUCT_ID
            WHERE O.FLD_ORDER_ID= {txt_id.Text};
        ")

        Dim subtotalColumn = New DataColumn("FLD_SUBTOTAL", System.Type.GetType("System.Decimal"))
        subtotalColumn.Expression = "FLD_QUANTITY * FLD_PRICE"

        orderDetailsDatatable.Columns.Add(subtotalColumn)

        grd_orders.DataSource = orderDetailsDatatable

        With grd_orders
            .Columns(0).HeaderText = "ID"
            .Columns(1).HeaderText = "Quantity"
            .Columns(2).HeaderText = "Name"
            .Columns(3).HeaderText = "Price (RM)"
            .Columns(3).DefaultCellStyle.Format = "0.00##"
            .Columns(4).HeaderText = "Subtotal (RM)"
            .Columns(4).DefaultCellStyle.Format = "0.00##"
            .AutoResizeColumns()
        End With

        refreshTotal()
    End Sub

    Private Sub lst_orders_SelectedIndexChanged(sender As Object, e As EventArgs)
        txt_id.Text = lst_orders.SelectedItem.Item("FLD_ORDER_ID")
        refreshData()

        btn_save.Enabled = False
        btn_addProductItem.Enabled = False
        btn_removeProductItem.Enabled = False
    End Sub

    Private Sub btn_addProductItem_Click(sender As Object, e As EventArgs) Handles btn_addProductItem.Click
        frm_addProductLineItem_a187806.ShowDialog()
    End Sub

    Private Sub btn_removeProductItem_Click(sender As Object, e As EventArgs) Handles btn_removeProductItem.Click

    End Sub

    Public Sub addProductLineItem(productId As String, quantity As Integer)
    End Sub



    'Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
    '    Dim delete_confirmation = MsgBox($"Are you sure you want to delete staff of ID {txt_id.Text}",
    '                                     MsgBoxStyle.YesNo)

    '    If delete_confirmation = MsgBoxResult.Yes Then
    '        Beep()

    '        Dim state = ExecuteSqlStatement($"DELETE FROM TBL_orders_A187806 WHERE FLD_STAFF_ID = {txt_id.Text}")

    '        If state.success Then
    '            MsgBox($"The staff of ID {txt_id.Text} has been successfully deleted.")
    '            refreshIds()
    '        Else
    '            MsgBox($"Delete failed. {vbCrLf}{vbCrLf}{state.exception.Message}")
    '        End If
    '    End If
    'End Sub

    'Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
    '    Dim state As SuccessState

    '    If txt_id.Text = getNewId() Then
    '        state = ExecuteSqlStatement($"INSERT INTO TBL_orders_A187806 (
    '            FLD_STAFF_ID,
    '            FLD_NAME
    '        ) VALUES (
    '            {txt_id.Text},
    '            '{txt_name.Text}'
    '        )")
    '        refreshIds()
    '    Else
    '        state = ExecuteSqlStatement($"UPDATE TBL_orders_A187806 SET
    '            FLD_NAME = '{txt_name.Text}',
    '        WHERE FLD_STAFF_ID = {txt_id.Text}
    '        ")
    '    End If

    '    If state.success Then
    '        Beep()
    '        MsgBox("Succesffully saved.")
    '    Else
    '        MsgBox($"Error Occured:{vbCrLf}{vbCrLf}{state.exception.Message}")
    '    End If
    'End Sub
End Class
