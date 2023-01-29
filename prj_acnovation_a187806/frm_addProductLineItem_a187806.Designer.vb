<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_addProductLineItem_a187806
    Inherits prj_acnovation_a187806.frm_base_a187806

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_addProductLineItem_a187806))
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_condition = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_stock = New System.Windows.Forms.Label()
        Me.lbl_description = New System.Windows.Forms.Label()
        Me.lbl_condition = New System.Windows.Forms.Label()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lst_productIds = New System.Windows.Forms.ListBox()
        Me.num_quantity = New System.Windows.Forms.NumericUpDown()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_home
        '
        Me.pic_home.Size = New System.Drawing.Size(0, 0)
        Me.pic_home.Visible = False
        '
        'errorProvider
        '
        Me.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errorProvider.ContainerControl = Me
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(132, 257)
        Me.txt_description.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_description.Multiline = True
        Me.txt_description.Name = "txt_description"
        Me.txt_description.ReadOnly = True
        Me.txt_description.Size = New System.Drawing.Size(267, 69)
        Me.txt_description.TabIndex = 34
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(201, 93)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_name.Multiline = True
        Me.txt_name.Name = "txt_name"
        Me.txt_name.ReadOnly = True
        Me.txt_name.Size = New System.Drawing.Size(198, 35)
        Me.txt_name.TabIndex = 33
        '
        'txt_condition
        '
        Me.txt_condition.Location = New System.Drawing.Point(201, 204)
        Me.txt_condition.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_condition.Name = "txt_condition"
        Me.txt_condition.ReadOnly = True
        Me.txt_condition.Size = New System.Drawing.Size(198, 20)
        Me.txt_condition.TabIndex = 32
        '
        'txt_type
        '
        Me.txt_type.AutoCompleteCustomSource.AddRange(New String() {"halo", "is", "this", "a", "thing"})
        Me.txt_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_type.Location = New System.Drawing.Point(201, 174)
        Me.txt_type.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.ReadOnly = True
        Me.txt_type.Size = New System.Drawing.Size(198, 20)
        Me.txt_type.TabIndex = 31
        '
        'txt_stock
        '
        Me.txt_stock.Location = New System.Drawing.Point(370, 144)
        Me.txt_stock.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.ReadOnly = True
        Me.txt_stock.Size = New System.Drawing.Size(29, 20)
        Me.txt_stock.TabIndex = 30
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(201, 144)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.ReadOnly = True
        Me.txt_price.Size = New System.Drawing.Size(83, 20)
        Me.txt_price.TabIndex = 29
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(201, 62)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(32, 20)
        Me.txt_id.TabIndex = 28
        '
        'lbl_stock
        '
        Me.lbl_stock.AutoSize = True
        Me.lbl_stock.Location = New System.Drawing.Point(310, 147)
        Me.lbl_stock.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_stock.Name = "lbl_stock"
        Me.lbl_stock.Size = New System.Drawing.Size(59, 13)
        Me.lbl_stock.TabIndex = 27
        Me.lbl_stock.Text = "Stock Left:"
        '
        'lbl_description
        '
        Me.lbl_description.AutoSize = True
        Me.lbl_description.Location = New System.Drawing.Point(130, 235)
        Me.lbl_description.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_description.Name = "lbl_description"
        Me.lbl_description.Size = New System.Drawing.Size(60, 13)
        Me.lbl_description.TabIndex = 26
        Me.lbl_description.Text = "Description"
        '
        'lbl_condition
        '
        Me.lbl_condition.AutoSize = True
        Me.lbl_condition.Location = New System.Drawing.Point(130, 207)
        Me.lbl_condition.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_condition.Name = "lbl_condition"
        Me.lbl_condition.Size = New System.Drawing.Size(51, 13)
        Me.lbl_condition.TabIndex = 25
        Me.lbl_condition.Text = "Condition"
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.Location = New System.Drawing.Point(130, 177)
        Me.lbl_type.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(31, 13)
        Me.lbl_type.TabIndex = 24
        Me.lbl_type.Text = "Type"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Location = New System.Drawing.Point(130, 147)
        Me.lbl_price.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(54, 13)
        Me.lbl_price.TabIndex = 23
        Me.lbl_price.Text = "Price(RM)"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(130, 93)
        Me.lbl_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(35, 13)
        Me.lbl_name.TabIndex = 22
        Me.lbl_name.Text = "Name"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(29, 32)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(89, 22)
        Me.lbl_title.TabIndex = 21
        Me.lbl_title.Text = "Products"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(130, 65)
        Me.lbl_id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(21, 13)
        Me.lbl_id.TabIndex = 20
        Me.lbl_id.Text = "ID:"
        '
        'pic_product
        '
        Me.pic_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_product.Location = New System.Drawing.Point(432, 62)
        Me.pic_product.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(140, 134)
        Me.pic_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_product.TabIndex = 19
        Me.pic_product.TabStop = False
        '
        'lst_productIds
        '
        Me.lst_productIds.FormattingEnabled = True
        Me.lst_productIds.Location = New System.Drawing.Point(31, 65)
        Me.lst_productIds.Margin = New System.Windows.Forms.Padding(2)
        Me.lst_productIds.Name = "lst_productIds"
        Me.lst_productIds.Size = New System.Drawing.Size(79, 264)
        Me.lst_productIds.TabIndex = 18
        '
        'num_quantity
        '
        Me.num_quantity.Location = New System.Drawing.Point(512, 277)
        Me.num_quantity.Name = "num_quantity"
        Me.num_quantity.Size = New System.Drawing.Size(60, 20)
        Me.num_quantity.TabIndex = 35
        Me.num_quantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.Location = New System.Drawing.Point(439, 281)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(46, 13)
        Me.lbl_quantity.TabIndex = 36
        Me.lbl_quantity.Text = "Quantity"
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(432, 303)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(60, 23)
        Me.btn_add.TabIndex = 37
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(512, 303)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(60, 23)
        Me.btn_close.TabIndex = 38
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'frm_addProductLineItem_a187806
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.lbl_quantity)
        Me.Controls.Add(Me.num_quantity)
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
        Me.Name = "frm_addProductLineItem_a187806"
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
        Me.Controls.SetChildIndex(Me.num_quantity, 0)
        Me.Controls.SetChildIndex(Me.lbl_quantity, 0)
        Me.Controls.SetChildIndex(Me.btn_add, 0)
        Me.Controls.SetChildIndex(Me.btn_close, 0)
        Me.Controls.SetChildIndex(Me.pic_home, 0)
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents errorProvider As ErrorProvider
    Friend WithEvents txt_description As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_condition As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents txt_stock As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents lbl_stock As Label
    Friend WithEvents lbl_description As Label
    Friend WithEvents lbl_condition As Label
    Friend WithEvents lbl_type As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents lst_productIds As ListBox
    Friend WithEvents btn_close As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents num_quantity As NumericUpDown
End Class
