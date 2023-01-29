Public Class frm_orders_a187806
    Dim frm_ordersList_a187806 As frm_tableView_a187806
    Dim orderDetailsDatatable As DataTable
    Private Sub frm_orders_a187806_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshIds()
        refreshStaffs()
        refreshCustomers()

        btn_save.Enabled = False
        btn_addProductItem.Enabled = False
        btn_removeProductItem.Enabled = False

        orderDetailsDatatable = New DataTable()

        orderDetailsDatatable.Columns.AddRange({
            New DataColumn("FLD_PRODUCT_ID", GetType(Integer)),
            New DataColumn("FLD_QUANTITY", GetType(Integer)),
            New DataColumn("FLD_PRODUCT_NAME"),
            New DataColumn("FLD_PRICE", GetType(Double))
        })

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

        AddHandler lst_orders.SelectedIndexChanged, AddressOf lst_orders_SelectedIndexChanged
        lst_orders.DisplayMember = "FLD_ORDER_ID"
    End Sub

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
        refreshTotal()

        btn_save.Enabled = True
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

    Private Sub refreshData(orderId As Integer)
        Dim orderData = GetDataTableFromSelectStatment($"
            SELECT
                FLD_ORDER_ID,
                FLD_PROCESSED_BY_STAFF_ID,
                FLD_ORDERED_BY_CUSTOMER_ID
            From TBL_ORDERS_A187806
            WHERE FLD_ORDER_ID = {orderId}
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
            WHERE O.FLD_ORDER_ID= {orderId};
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
        Dim orderId = lst_orders.SelectedItem.Item("FLD_ORDER_ID")

        If orderId Is Nothing Then
            Return
        End If

        txt_id.Text = orderId
        refreshData(orderId)

        btn_save.Enabled = False
        btn_addProductItem.Enabled = False
        btn_removeProductItem.Enabled = False
    End Sub

    Private Sub btn_addProductItem_Click(sender As Object, e As EventArgs) Handles btn_addProductItem.Click
        frm_addProductLineItem_a187806.ShowDialog()
    End Sub

    Private Sub btn_removeProductItem_Click(sender As Object, e As EventArgs) Handles btn_removeProductItem.Click
        For Each cell As DataGridViewCell In grd_orders.SelectedCells
            orderDetailsDatatable.Rows(cell.RowIndex).Delete()
        Next
    End Sub

    Public Sub addProductLineItem(productId As String, quantity As Integer)

        Dim productDatatable = GetDataTableFromSelectStatment($"
            SELECT
                FLD_PRODUCT_NAME,
                FLD_PRICE,
                FLD_STOCK
            FROM TBL_PRODUCTS_A187806
            WHERE FLD_PRODUCT_ID={productId};
        ")
        Dim productData = productDatatable.Rows(0)

        If productData Is Nothing Then
            Beep()
            MessageBox.Show("The product id is invalid")
            Return
        End If

        For Each row As DataRow In orderDetailsDatatable.Rows
            If row.Field(Of Integer)("FLD_PRODUCT_ID") = productId Then
                Dim previousQuantity = row.Field(Of Integer)("FLD_QUANTITY")
                row.Item("FLD_QUANTITY") = Math.Min((previousQuantity + quantity), productData.Field(Of Integer)("FLD_STOCK"))
                Return
            End If
        Next

        Dim newRow = orderDetailsDatatable.NewRow()
        newRow.SetField(0, productId)
        newRow.SetField(1, quantity)
        newRow.SetField(2, productData.ItemArray(0))
        newRow.SetField(3, productData.ItemArray(1))

        orderDetailsDatatable.Rows.Add(newRow)

        refreshTotal()
    End Sub


    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_id.Text <> getNewId() Then
            Beep()
            MessageBox.Show("Current version of Acnovation App does not support updating order")
            Return
        End If

        Dim dbConnection = GetDbConnection()
        dbConnection.Open()
        Dim transaction = dbConnection.BeginTransaction
        Try
            Dim writer As New OleDb.OleDbCommand With {
                .Connection = dbConnection,
                .Transaction = transaction
            }

            If cmb_staff.SelectedItem Is Nothing Then
                Beep()
                MessageBox.Show("Please select a staff")
                Return
            End If

            If cmb_customer.SelectedItem Is Nothing Then
                Beep()
                MessageBox.Show("Please select a customer")
                Return
            End If

            Dim orderId = txt_id.Text
            Dim staffId = cmb_staff.SelectedItem.Item("FLD_STAFF_ID")
            Dim customerId = cmb_customer.SelectedItem.Item("FLD_CUSTOMER_ID")

            Dim insertOrderStatement = $"INSERT INTO TBL_ORDERS_A187806 (
                FLD_ORDER_ID, 
                FLD_PROCESSED_BY_STAFF_ID, 
                FLD_ORDERED_BY_CUSTOMER_ID 
            ) VALUES (
                {txt_id.Text},
                {staffId},
                {customerId}
            )"

            writer.CommandText = $"INSERT INTO TBL_ORDERS_A187806 (
                FLD_ORDER_ID, 
                FLD_PROCESSED_BY_STAFF_ID, 
                FLD_ORDERED_BY_CUSTOMER_ID 
            ) VALUES (
                {txt_id.Text},
                {staffId},
                {customerId}
            )"
            writer.ExecuteNonQuery()


            For Each row As DataRow In orderDetailsDatatable.Rows
                Dim productId = row.ItemArray(0)
                Dim quantity = row.ItemArray(1)

                writer.CommandText = $"INSERT INTO TBL_ORDER_DETAILS_A187806 (
                    FLD_ORDER_ID,
                    FLD_PRODUCT_ID,
                    FLD_QUANTITY
                ) VALUES (
                    {orderId},
                    {productId},
                    {quantity}
                )"
                writer.ExecuteNonQuery()

                Dim productDatatable = GetDataTableFromSelectStatment($"
                    SELECT
                        FLD_PRODUCT_NAME,
                        FLD_PRICE,
                        FLD_STOCK
                    FROM TBL_PRODUCTS_A187806
                    WHERE FLD_PRODUCT_ID={productId};
                ")
                Dim productData = productDatatable.Rows(0)

                Dim newStock = productData.Field(Of Integer)("FLD_STOCK") - quantity

                If newStock < 0 Then
                    newStock = 0
                End If

                writer.CommandText = $"UPDATE TBL_PRODUCTS_A187806
                    SET FLD_STOCK = {newStock}
                WHERE FLD_PRODUCT_ID = {orderId}
                "
                writer.ExecuteNonQuery()
            Next

            transaction.Commit()
        Catch ex As InvalidOperationException
            Beep()
            MessageBox.Show($"An error occured {vbCrLf} {vbCrLf} {ex.Message}")
            transaction.Rollback()
        Finally
            dbConnection.Close()

        End Try

        refreshIds()
    End Sub

    Private Sub grd_orders_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_orders.CellClick
        If txt_id.Text = getNewId() Then
            btn_removeProductItem.Enabled = True
        End If
        refreshTotal()
    End Sub
End Class
