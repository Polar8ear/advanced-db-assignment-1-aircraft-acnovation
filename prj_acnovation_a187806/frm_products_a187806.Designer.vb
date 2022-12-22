<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_products_a187806
    Inherits prj_acnovation_a187806.frm_base_a187806

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_products_a187806))
        Me.lst_productIds = New System.Windows.Forms.ListBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.lbl_condition = New System.Windows.Forms.Label()
        Me.lbl_description = New System.Windows.Forms.Label()
        Me.lbl_stock = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_condition = New System.Windows.Forms.TextBox()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_table = New System.Windows.Forms.Button()
        Me.btn_selectPicture = New System.Windows.Forms.Button()
        Me.btn_clearPicture = New System.Windows.Forms.Button()
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lst_productIds
        '
        Me.lst_productIds.FormattingEnabled = True
        Me.lst_productIds.ItemHeight = 16
        Me.lst_productIds.Location = New System.Drawing.Point(41, 85)
        Me.lst_productIds.Name = "lst_productIds"
        Me.lst_productIds.Size = New System.Drawing.Size(104, 324)
        Me.lst_productIds.TabIndex = 0
        '
        'pic_product
        '
        Me.pic_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_product.Location = New System.Drawing.Point(573, 85)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(186, 165)
        Me.pic_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_product.TabIndex = 1
        Me.pic_product.TabStop = False
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(171, 88)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(25, 17)
        Me.lbl_id.TabIndex = 2
        Me.lbl_id.Text = "ID:"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(171, 123)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(45, 17)
        Me.lbl_name.TabIndex = 3
        Me.lbl_name.Text = "Name"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Location = New System.Drawing.Point(171, 189)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(71, 17)
        Me.lbl_price.TabIndex = 4
        Me.lbl_price.Text = "Price(RM)"
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.Location = New System.Drawing.Point(171, 226)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(40, 17)
        Me.lbl_type.TabIndex = 5
        Me.lbl_type.Text = "Type"
        '
        'lbl_condition
        '
        Me.lbl_condition.AutoSize = True
        Me.lbl_condition.Location = New System.Drawing.Point(171, 263)
        Me.lbl_condition.Name = "lbl_condition"
        Me.lbl_condition.Size = New System.Drawing.Size(67, 17)
        Me.lbl_condition.TabIndex = 6
        Me.lbl_condition.Text = "Condition"
        '
        'lbl_description
        '
        Me.lbl_description.AutoSize = True
        Me.lbl_description.Location = New System.Drawing.Point(171, 298)
        Me.lbl_description.Name = "lbl_description"
        Me.lbl_description.Size = New System.Drawing.Size(79, 17)
        Me.lbl_description.TabIndex = 7
        Me.lbl_description.Text = "Description"
        '
        'lbl_stock
        '
        Me.lbl_stock.AutoSize = True
        Me.lbl_stock.Location = New System.Drawing.Point(410, 189)
        Me.lbl_stock.Name = "lbl_stock"
        Me.lbl_stock.Size = New System.Drawing.Size(75, 17)
        Me.lbl_stock.TabIndex = 8
        Me.lbl_stock.Text = "Stock Left:"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(265, 85)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(41, 22)
        Me.txt_id.TabIndex = 9
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(265, 123)
        Me.txt_name.Multiline = True
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(263, 42)
        Me.txt_name.TabIndex = 10
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(265, 186)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(109, 22)
        Me.txt_price.TabIndex = 9
        '
        'txt_stock
        '
        Me.txt_stock.Location = New System.Drawing.Point(491, 186)
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(37, 22)
        Me.txt_stock.TabIndex = 9
        '
        'txt_type
        '
        Me.txt_type.AutoCompleteCustomSource.AddRange(New String() {"halo", "is", "this", "a", "thing"})
        Me.txt_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_type.Location = New System.Drawing.Point(265, 223)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(263, 22)
        Me.txt_type.TabIndex = 9
        '
        'txt_condition
        '
        Me.txt_condition.Location = New System.Drawing.Point(265, 260)
        Me.txt_condition.Name = "txt_condition"
        Me.txt_condition.Size = New System.Drawing.Size(263, 22)
        Me.txt_condition.TabIndex = 9
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(173, 325)
        Me.txt_description.Multiline = True
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Size = New System.Drawing.Size(355, 84)
        Me.txt_description.TabIndex = 10
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(105, 34)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(106, 26)
        Me.lbl_title.TabIndex = 2
        Me.lbl_title.Text = "Products"
        '
        'btn_new
        '
        Me.btn_new.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_new.Location = New System.Drawing.Point(97, 3)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(84, 36)
        Me.btn_new.TabIndex = 11
        Me.btn_new.Text = "New"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_delete, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_new, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_save, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_table, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(573, 326)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(186, 84)
        Me.TableLayoutPanel1.TabIndex = 15
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_delete.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_delete.Location = New System.Drawing.Point(4, 45)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(84, 36)
        Me.btn_delete.TabIndex = 11
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_save.Location = New System.Drawing.Point(97, 45)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(84, 36)
        Me.btn_save.TabIndex = 11
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_table
        '
        Me.btn_table.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_table.Location = New System.Drawing.Point(4, 3)
        Me.btn_table.Name = "btn_table"
        Me.btn_table.Size = New System.Drawing.Size(84, 36)
        Me.btn_table.TabIndex = 11
        Me.btn_table.Text = "Table"
        Me.btn_table.UseVisualStyleBackColor = True
        '
        'btn_selectPicture
        '
        Me.btn_selectPicture.Location = New System.Drawing.Point(573, 259)
        Me.btn_selectPicture.Name = "btn_selectPicture"
        Me.btn_selectPicture.Size = New System.Drawing.Size(75, 33)
        Me.btn_selectPicture.TabIndex = 16
        Me.btn_selectPicture.Text = "Select"
        Me.btn_selectPicture.UseVisualStyleBackColor = True
        '
        'btn_clearPicture
        '
        Me.btn_clearPicture.Location = New System.Drawing.Point(684, 259)
        Me.btn_clearPicture.Name = "btn_clearPicture"
        Me.btn_clearPicture.Size = New System.Drawing.Size(75, 33)
        Me.btn_clearPicture.TabIndex = 17
        Me.btn_clearPicture.Text = "Clear"
        Me.btn_clearPicture.UseVisualStyleBackColor = True
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'frm_products_a187806
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_clearPicture)
        Me.Controls.Add(Me.btn_selectPicture)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.txt_description)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_condition)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_stock)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_stock)
        Me.Controls.Add(Me.lbl_description)
        Me.Controls.Add(Me.lbl_condition)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.lst_productIds)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_products_a187806"
        Me.Text = "Acnovation"
        Me.Controls.SetChildIndex(Me.lst_productIds, 0)
        Me.Controls.SetChildIndex(Me.pic_product, 0)
        Me.Controls.SetChildIndex(Me.lbl_id, 0)
        Me.Controls.SetChildIndex(Me.lbl_title, 0)
        Me.Controls.SetChildIndex(Me.lbl_name, 0)
        Me.Controls.SetChildIndex(Me.lbl_price, 0)
        Me.Controls.SetChildIndex(Me.lbl_type, 0)
        Me.Controls.SetChildIndex(Me.lbl_condition, 0)
        Me.Controls.SetChildIndex(Me.lbl_description, 0)
        Me.Controls.SetChildIndex(Me.lbl_stock, 0)
        Me.Controls.SetChildIndex(Me.txt_id, 0)
        Me.Controls.SetChildIndex(Me.txt_price, 0)
        Me.Controls.SetChildIndex(Me.txt_stock, 0)
        Me.Controls.SetChildIndex(Me.txt_type, 0)
        Me.Controls.SetChildIndex(Me.txt_condition, 0)
        Me.Controls.SetChildIndex(Me.txt_name, 0)
        Me.Controls.SetChildIndex(Me.txt_description, 0)
        Me.Controls.SetChildIndex(Me.TableLayoutPanel1, 0)
        Me.Controls.SetChildIndex(Me.btn_selectPicture, 0)
        Me.Controls.SetChildIndex(Me.btn_clearPicture, 0)
        Me.Controls.SetChildIndex(Me.pic_home, 0)
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lst_productIds As ListBox
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_type As Label
    Friend WithEvents lbl_condition As Label
    Friend WithEvents lbl_description As Label
    Friend WithEvents lbl_stock As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_stock As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents txt_condition As TextBox
    Friend WithEvents txt_description As TextBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_new As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_selectPicture As Button
    Friend WithEvents btn_clearPicture As Button
    Friend WithEvents errorProvider As ErrorProvider
    Friend WithEvents btn_table As Button
End Class
