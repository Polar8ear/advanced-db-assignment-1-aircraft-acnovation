<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customers_a187806
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_customers_a187806))
        Me.lst_customers = New System.Windows.Forms.ListBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_table = New System.Windows.Forms.Button()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.lbl_contact = New System.Windows.Forms.Label()
        Me.txt_contact = New System.Windows.Forms.TextBox()
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lst_customers
        '
        Me.lst_customers.FormattingEnabled = True
        Me.lst_customers.ItemHeight = 16
        Me.lst_customers.Location = New System.Drawing.Point(41, 85)
        Me.lst_customers.Name = "lst_customers"
        Me.lst_customers.Size = New System.Drawing.Size(104, 324)
        Me.lst_customers.TabIndex = 1
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(105, 34)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(127, 26)
        Me.lbl_title.TabIndex = 3
        Me.lbl_title.Text = "Customers"
        '
        'btn_table
        '
        Me.btn_table.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_table.Location = New System.Drawing.Point(3, 3)
        Me.btn_table.Name = "btn_table"
        Me.btn_table.Size = New System.Drawing.Size(94, 44)
        Me.btn_table.TabIndex = 4
        Me.btn_table.Text = "Table"
        Me.btn_table.UseVisualStyleBackColor = True
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(196, 182)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(25, 17)
        Me.lbl_id.TabIndex = 5
        Me.lbl_id.Text = "ID:"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(196, 231)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(49, 17)
        Me.lbl_name.TabIndex = 6
        Me.lbl_name.Text = "Name:"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(286, 176)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(50, 22)
        Me.txt_id.TabIndex = 7
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(286, 228)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(222, 22)
        Me.txt_name.TabIndex = 8
        '
        'err
        '
        Me.err.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.err.ContainerControl = Me
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_save, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_delete, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_new, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_table, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(538, 309)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'btn_save
        '
        Me.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_save.Location = New System.Drawing.Point(103, 53)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(94, 44)
        Me.btn_save.TabIndex = 2
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_delete.Location = New System.Drawing.Point(3, 53)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(94, 44)
        Me.btn_delete.TabIndex = 1
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_new.Location = New System.Drawing.Point(103, 3)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(94, 44)
        Me.btn_new.TabIndex = 0
        Me.btn_new.Text = "New"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'lbl_contact
        '
        Me.lbl_contact.AutoSize = True
        Me.lbl_contact.Location = New System.Drawing.Point(196, 280)
        Me.lbl_contact.Name = "lbl_contact"
        Me.lbl_contact.Size = New System.Drawing.Size(82, 17)
        Me.lbl_contact.TabIndex = 10
        Me.lbl_contact.Text = "Contact No:"
        '
        'txt_contact
        '
        Me.txt_contact.Location = New System.Drawing.Point(286, 277)
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.Size = New System.Drawing.Size(222, 22)
        Me.txt_contact.TabIndex = 11
        '
        'frm_customers_a187806
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_contact)
        Me.Controls.Add(Me.lbl_contact)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lst_customers)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_customers_a187806"
        Me.Controls.SetChildIndex(Me.pic_home, 0)
        Me.Controls.SetChildIndex(Me.lst_customers, 0)
        Me.Controls.SetChildIndex(Me.lbl_title, 0)
        Me.Controls.SetChildIndex(Me.lbl_id, 0)
        Me.Controls.SetChildIndex(Me.lbl_name, 0)
        Me.Controls.SetChildIndex(Me.txt_id, 0)
        Me.Controls.SetChildIndex(Me.txt_name, 0)
        Me.Controls.SetChildIndex(Me.TableLayoutPanel1, 0)
        Me.Controls.SetChildIndex(Me.lbl_contact, 0)
        Me.Controls.SetChildIndex(Me.txt_contact, 0)
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lst_customers As ListBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_table As Button
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents err As ErrorProvider
    Friend WithEvents txt_contact As TextBox
    Friend WithEvents lbl_contact As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_new As Button
End Class
