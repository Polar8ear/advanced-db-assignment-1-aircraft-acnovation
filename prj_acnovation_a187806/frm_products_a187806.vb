Imports System.Text.RegularExpressions

Public Class frm_products_a187806
    Dim frm_productsTable_a187806 As frm_tableView_a187806
    Dim textBoxFields() As TextBoxField
    Dim newImageText As String
    Dim currentImage As Image
    Private Sub frm_products_a187806_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textBoxFields = {
            New TextBoxField(txt_id, "FLD_PRODUCT_ID"),
            New TextBoxField(txt_name, "FLD_PRODUCT_NAME"),
            New TextBoxField(txt_price, "FLD_PRICE"),
            New TextBoxField(txt_stock, "FLD_STOCK"),
            New TextBoxField(txt_type, "FLD_TYPE"),
            New TextBoxField(txt_condition, "FLD_CONDITION"),
            New TextBoxField(txt_description, "FLD_DESCRIPTION")
        }

        refreshIds()

        AddHandler lst_productIds.SelectedIndexChanged, AddressOf lst_productIds_SelectedIndexChanged
        lst_productIds.DisplayMember = "FLD_PRODUCT_ID"

        For index = 0 To textBoxFields.Length - 1
            AddHandler textBoxFields(index).textBox.TextChanged, AddressOf HandleDataChanged
        Next index

        'Explicitlty set the handler after enabling save to toggle btn_save enabled if doesnt pass test
        AddHandler txt_price.TextChanged, AddressOf ValidateNumberTextBox
        AddHandler txt_stock.TextChanged, AddressOf ValidateIntegerTextBox
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

        btn_save.Enabled = False
        newImageText = Nothing
    End Sub

    Private Sub ValidateIntegerTextBox(sender As TextBox, e As EventArgs)
        If Not Regex.IsMatch(sender.Text, isIntegerRegex) Then
            errorProvider.SetError(sender, "Please insert a valid integer")
            btn_save.Enabled = False

        Else
            errorProvider.Clear()
        End If
    End Sub

    Private Sub ValidateNumberTextBox(sender As TextBox, e As EventArgs)
        If Not Regex.IsMatch(sender.Text, isNumberRegex) Then
            errorProvider.SetError(sender, "Please insert a valid number")
            btn_save.Enabled = False

        Else
            errorProvider.Clear()
        End If
    End Sub

    Private Sub HandleDataChanged(sender As Object, e As EventArgs)
        btn_save.Enabled = True
    End Sub

    Private Sub refreshIds()
        Dim ids = GetDataTableFromSelectStatment("SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A187806 ORDER BY FLD_PRODUCT_ID")
        lst_productIds.DataSource = ids
    End Sub

    Private Function getNewId()
        Dim lastIdDataTable = GetDataTableFromSelectStatment("SELECT MAX(FLD_PRODUCT_ID) AS MAX_FLD_ID FROM TBL_PRODUCTS_A187806")

        If lastIdDataTable.Rows.Count <= 0 Then Return 0

        Dim lastId = Integer.Parse(lastIdDataTable.Rows(0).Item("MAX_FLD_ID"))

        Return lastId + 1
    End Function

    Private Sub changeImage(filePath As String)
        If currentImage IsNot Nothing Then currentImage.Dispose()

        Try
            currentImage = Image.FromFile(filePath)
            pic_product.Image = currentImage
        Catch ex As IO.FileNotFoundException
            pic_product.Image = My.Resources.noimage
        End Try
    End Sub

    Private Sub clearImage()
        If currentImage IsNot Nothing Then currentImage.Dispose()
        currentImage = Nothing
        pic_product.Image = My.Resources.noimage
        btn_save.Enabled = True
    End Sub

    Private Sub btn_table_Click(sender As Object, e As EventArgs) Handles btn_table.Click
        If frm_productsTable_a187806 Is Nothing Then
            frm_productsTable_a187806 = New frm_tableView_a187806("Products",
               "SELECT 
                    FLD_PRODUCT_ID AS [ID], 
                    FLD_PRODUCT_NAME AS [Product Name], 
                    FORMAT(FLD_PRICE, '.00') AS [Price (Sen)], 
                    FLD_TYPE AS [Type], 
                    FLD_CONDITION AS [Condition], 
                    FLD_DESCRIPTION AS [Description], 
                    FLD_STOCK AS [Stock] 
                FROM TBL_PRODUCTS_A187806"
            )
        End If

        frm_productsTable_a187806.Show()
        Hide()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If Not Regex.IsMatch(txt_price.Text, isNumberRegex) Then
            MsgBox("Please enter a valid number for price.")
            Exit Sub
        End If

        If Not Regex.IsMatch(txt_stock.Text, isIntegerRegex) Then
            MsgBox("Please enter a valid integer for stock.")
            Exit Sub
        End If

        'Handles new record creation
        If txt_id.Text = getNewId() Then
            Dim prevId = txt_id.Text
            ExecuteSqlStatement($"INSERT INTO TBL_PRODUCTS_A187806 (
                    FLD_PRODUCT_ID, 
                    FLD_PRODUCT_NAME, 
                    FLD_PRICE, 
                    FLD_STOCK, 
                    FLD_TYPE, 
                    FLD_CONDITION, 
                    FLD_DESCRIPTION
                ) VALUES (
                    {txt_id.Text},
                    '{txt_name.Text}',
                    {txt_price.Text},
                    {txt_stock.Text},
                    '{txt_type.Text}',
                    '{txt_condition.Text}',
                    '{txt_description.Text}'
                )
            ")
        Else
            ExecuteSqlStatement($"UPDATE TBL_PRODUCTS_A187806 SET
                    FLD_PRODUCT_NAME = '{txt_name.Text}', 
                    FLD_PRICE = {txt_price.Text},
                    FLD_STOCK = {txt_stock.Text}, 
                    FLD_TYPE = '{txt_type.Text}', 
                    FLD_CONDITION = '{txt_condition.Text}', 
                    FLD_DESCRIPTION = '{txt_description.Text}'
                WHERE FLD_PRODUCT_ID = {txt_id.Text}
            ")
        End If

        Dim isNewImageTextExists = newImageText IsNot Nothing And newImageText?.Length > 0

        Dim filePath = $"./images/{txt_id.Text}.jpg"
        If isNewImageTextExists Or currentImage Is Nothing Then
            If My.Computer.FileSystem.FileExists(filePath) Then
                My.Computer.FileSystem.DeleteFile(filePath)
            End If
        End If

        If isNewImageTextExists Then
            My.Computer.FileSystem.CopyFile(newImageText, filePath)
        End If
        btn_save.Enabled = False
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox($"Are you sure you want to delete product of ID {txt_id.Text}",
                                         MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then
            Beep()

            ExecuteSqlStatement($"DELETE FROM TBL_PRODUCTS_A187806 WHERE FLD_PRODUCT_ID = {txt_id.Text}")

            MsgBox($"The product of ID {txt_id.Text} has been successfully deleted.")

            currentImage.Dispose()
            My.Computer.FileSystem.DeleteFile($"./images/{txt_id.Text}.jpg")


            refreshIds()
        End If
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Dim newId = getNewId()
        For Each textBoxField As TextBoxField In textBoxFields
            textBoxField.textBox.Clear()
        Next
        txt_id.Text = getNewId()
    End Sub

    Private Sub btn_clearPicture_Click(sender As Object, e As EventArgs) Handles btn_clearPicture.Click
        clearImage()
    End Sub

    Private Sub btn_selectPicture_Click(sender As Object, e As EventArgs) Handles btn_selectPicture.Click
        Dim desktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop
        Dim fileDialog As New OpenFileDialog

        fileDialog.InitialDirectory = desktop
        fileDialog.FileName = ""
        fileDialog.Filter = "JPG files (*.jpg)|*.jpg"
        fileDialog.ShowDialog()

        If fileDialog.FileName.Length > 0 Then
            changeImage(fileDialog.FileName)
            newImageText = fileDialog.FileName
            btn_save.Enabled = True
        End If
    End Sub
End Class

Class TextBoxField
    Public textBox As TextBox
    Public field As String

    Sub New(textBox As TextBox, field As String)
        Me.textBox = textBox
        Me.field = field
    End Sub
End Class