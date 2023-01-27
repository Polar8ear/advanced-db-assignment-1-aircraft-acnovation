Public Class frm_addProductLineItem_a187806
    Dim frm_productsTable_a187806 As frm_tableView_a187806
    Dim textBoxFields() As TextBoxField
    Dim currentImage As Image

    Private Sub frm_addProductLineItem_a187806_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textBoxFields = {
            New TextBoxField(txt_id, "FLD_PRODUCT_ID"),
            New TextBoxField(txt_name, "FLD_PRODUCT_NAME"),
            New TextBoxField(txt_price, "FLD_PRICE"),
            New TextBoxField(txt_stock, "FLD_STOCK"),
            New TextBoxField(txt_type, "FLD_TYPE"),
            New TextBoxField(txt_condition, "FLD_CONDITION"),
            New TextBoxField(txt_description, "FLD_DESCRIPTION")
        }

        AddHandler lst_productIds.SelectedIndexChanged, AddressOf lst_productIds_SelectedIndexChanged

        refreshIds()
    End Sub
    Private Sub lst_productIds_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim selected As DataRowView = lst_productIds.SelectedItem
        Dim productDatatable = GetDataTableFromSelectStatment("SELECT 
            FLD_PRODUCT_ID, 
            FLD_PRODUCT_NAME, 
            FLD_PRICE, 
            FLD_STOCK, 
            FLD_TYPE, 
            FLD_CONDITION, 
            FLD_DESCRIPTION 
        FROM TBL_PRODUCTS_A187806
        WHERE FLD_PRODUCT_ID=" & selected.Item("FLD_PRODUCT_ID"))

        If productDatatable.Rows.Count <= 0 Then
            Beep()
            MsgBox("There's no relevant data for the id selected in the database. It might has been deleted.")
            Exit Sub
        End If


        Dim productData = productDatatable.Rows(0)

        For Each textBoxField As TextBoxField In textBoxFields
            If textBoxField.textBox Is txt_price Then
                textBoxField.textBox.Text = $"{productData.Item(textBoxField.field):f}"
                Continue For
            End If

            textBoxField.textBox.Text = productData.Item(textBoxField.field)
        Next

        changeImage($"./images/{productData.Item("FLD_PRODUCT_ID")}.jpg")

        num_quantity.Maximum = productData.Item("FLD_STOCK")
    End Sub

    Private Sub refreshIds()
        Dim ids = GetDataTableFromSelectStatment("SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A187806 ORDER BY FLD_PRODUCT_ID")
        lst_productIds.DisplayMember = "FLD_PRODUCT_ID"
        lst_productIds.DataSource = ids
    End Sub
    Private Sub changeImage(filePath As String)
        If currentImage IsNot Nothing Then currentImage.Dispose()

        Try
            currentImage = Image.FromFile(filePath)
            pic_product.Image = currentImage
        Catch ex As IO.FileNotFoundException
            pic_product.Image = My.Resources.noimage
        End Try
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim selectedProduct As DataRowView = lst_productIds.SelectedItem
        frm_orders_a187806.addProductLineItem(selectedProduct.Item("FLD_PRODUCT_ID"), num_quantity.Value)
        clear()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Hide()
    End Sub

    Private Sub clear()
        lst_productIds.SelectedIndex = 0
        num_quantity.ResetText()
    End Sub

    Overrides Sub frm_base_a187806_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    End Sub

End Class