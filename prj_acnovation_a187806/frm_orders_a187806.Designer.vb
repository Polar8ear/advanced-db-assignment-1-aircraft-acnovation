<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_orders_a187806
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_orders_a187806))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_table = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.lst_orders = New System.Windows.Forms.ListBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.lbl_customer = New System.Windows.Forms.Label()
        Me.lbl_staff = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.cmb_staff = New System.Windows.Forms.ComboBox()
        Me.btn_addProductItem = New System.Windows.Forms.Button()
        Me.btn_removeProductItem = New System.Windows.Forms.Button()
        Me.cmb_customer = New System.Windows.Forms.ComboBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.grd_orders = New System.Windows.Forms.DataGridView()
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.grd_orders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_table, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_new, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_delete, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_save, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(590, 318)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'btn_table
        '
        Me.btn_table.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_table.Location = New System.Drawing.Point(3, 4)
        Me.btn_table.Name = "btn_table"
        Me.btn_table.Size = New System.Drawing.Size(94, 41)
        Me.btn_table.TabIndex = 0
        Me.btn_table.Text = "Table"
        Me.btn_table.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_new.Location = New System.Drawing.Point(103, 4)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(94, 41)
        Me.btn_new.TabIndex = 1
        Me.btn_new.Text = "New"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_delete.Location = New System.Drawing.Point(3, 54)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(94, 41)
        Me.btn_delete.TabIndex = 2
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_save.Location = New System.Drawing.Point(103, 54)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(94, 41)
        Me.btn_save.TabIndex = 3
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'lst_orders
        '
        Me.lst_orders.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lst_orders.FormattingEnabled = True
        Me.lst_orders.ItemHeight = 16
        Me.lst_orders.Location = New System.Drawing.Point(41, 79)
        Me.lst_orders.Name = "lst_orders"
        Me.lst_orders.Size = New System.Drawing.Size(103, 324)
        Me.lst_orders.TabIndex = 7
        '
        'txt_id
        '
        Me.txt_id.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_id.Location = New System.Drawing.Point(245, 77)
        Me.txt_id.MinimumSize = New System.Drawing.Size(76, 22)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(76, 22)
        Me.txt_id.TabIndex = 15
        '
        'lbl_customer
        '
        Me.lbl_customer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_customer.AutoSize = True
        Me.lbl_customer.Location = New System.Drawing.Point(167, 153)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(68, 17)
        Me.lbl_customer.TabIndex = 12
        Me.lbl_customer.Text = "Customer"
        '
        'lbl_staff
        '
        Me.lbl_staff.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_staff.AutoSize = True
        Me.lbl_staff.Location = New System.Drawing.Point(167, 116)
        Me.lbl_staff.Name = "lbl_staff"
        Me.lbl_staff.Size = New System.Drawing.Size(37, 17)
        Me.lbl_staff.TabIndex = 11
        Me.lbl_staff.Text = "Staff"
        '
        'lbl_id
        '
        Me.lbl_id.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(167, 80)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(25, 17)
        Me.lbl_id.TabIndex = 10
        Me.lbl_id.Text = "ID:"
        '
        'cmb_staff
        '
        Me.cmb_staff.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_staff.FormattingEnabled = True
        Me.cmb_staff.Location = New System.Drawing.Point(245, 116)
        Me.cmb_staff.MinimumSize = New System.Drawing.Size(160, 0)
        Me.cmb_staff.Name = "cmb_staff"
        Me.cmb_staff.Size = New System.Drawing.Size(324, 24)
        Me.cmb_staff.TabIndex = 16
        '
        'btn_addProductItem
        '
        Me.btn_addProductItem.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_addProductItem.Location = New System.Drawing.Point(381, 373)
        Me.btn_addProductItem.Name = "btn_addProductItem"
        Me.btn_addProductItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_addProductItem.Size = New System.Drawing.Size(78, 32)
        Me.btn_addProductItem.TabIndex = 19
        Me.btn_addProductItem.Text = "Add Item"
        Me.btn_addProductItem.UseVisualStyleBackColor = True
        '
        'btn_removeProductItem
        '
        Me.btn_removeProductItem.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_removeProductItem.Location = New System.Drawing.Point(473, 373)
        Me.btn_removeProductItem.Name = "btn_removeProductItem"
        Me.btn_removeProductItem.Size = New System.Drawing.Size(78, 32)
        Me.btn_removeProductItem.TabIndex = 19
        Me.btn_removeProductItem.Text = "Remove"
        Me.btn_removeProductItem.UseVisualStyleBackColor = True
        '
        'cmb_customer
        '
        Me.cmb_customer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_customer.FormattingEnabled = True
        Me.cmb_customer.Location = New System.Drawing.Point(245, 150)
        Me.cmb_customer.MinimumSize = New System.Drawing.Size(160, 0)
        Me.cmb_customer.Name = "cmb_customer"
        Me.cmb_customer.Size = New System.Drawing.Size(324, 24)
        Me.cmb_customer.TabIndex = 16
        '
        'lbl_total
        '
        Me.lbl_total.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(187, 381)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(75, 17)
        Me.lbl_total.TabIndex = 10
        Me.lbl_total.Text = "Total (RM)"
        '
        'txt_total
        '
        Me.txt_total.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txt_total.Location = New System.Drawing.Point(274, 378)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(87, 22)
        Me.txt_total.TabIndex = 15
        '
        'grd_orders
        '
        Me.grd_orders.AllowUserToAddRows = False
        Me.grd_orders.AllowUserToDeleteRows = False
        Me.grd_orders.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grd_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grd_orders.Location = New System.Drawing.Point(173, 188)
        Me.grd_orders.Name = "grd_orders"
        Me.grd_orders.RowHeadersWidth = 51
        Me.grd_orders.RowTemplate.Height = 24
        Me.grd_orders.Size = New System.Drawing.Size(395, 174)
        Me.grd_orders.TabIndex = 20
        '
        'frm_orders_a187806
        '
        Me.AcceptButton = Me.btn_save
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(835, 493)
        Me.Controls.Add(Me.grd_orders)
        Me.Controls.Add(Me.btn_removeProductItem)
        Me.Controls.Add(Me.btn_addProductItem)
        Me.Controls.Add(Me.cmb_customer)
        Me.Controls.Add(Me.cmb_staff)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_customer)
        Me.Controls.Add(Me.lbl_staff)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lst_orders)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_orders_a187806"
        Me.Controls.SetChildIndex(Me.lst_orders, 0)
        Me.Controls.SetChildIndex(Me.TableLayoutPanel1, 0)
        Me.Controls.SetChildIndex(Me.lbl_id, 0)
        Me.Controls.SetChildIndex(Me.lbl_total, 0)
        Me.Controls.SetChildIndex(Me.lbl_staff, 0)
        Me.Controls.SetChildIndex(Me.lbl_customer, 0)
        Me.Controls.SetChildIndex(Me.txt_id, 0)
        Me.Controls.SetChildIndex(Me.txt_total, 0)
        Me.Controls.SetChildIndex(Me.cmb_staff, 0)
        Me.Controls.SetChildIndex(Me.cmb_customer, 0)
        Me.Controls.SetChildIndex(Me.btn_addProductItem, 0)
        Me.Controls.SetChildIndex(Me.btn_removeProductItem, 0)
        Me.Controls.SetChildIndex(Me.pic_home, 0)
        Me.Controls.SetChildIndex(Me.grd_orders, 0)
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.grd_orders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_table As Button
    Friend WithEvents btn_new As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents lst_orders As ListBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents lbl_customer As Label
    Friend WithEvents lbl_staff As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents cmb_staff As ComboBox
    Friend WithEvents btn_addProductItem As Button
    Friend WithEvents btn_removeProductItem As Button
    Friend WithEvents cmb_customer As ComboBox
    Friend WithEvents lbl_total As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents grd_orders As DataGridView
End Class
