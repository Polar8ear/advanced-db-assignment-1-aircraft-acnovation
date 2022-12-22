<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_staffs_a187806
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_staffs_a187806))
        Me.lst_staffs = New System.Windows.Forms.ListBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_table = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.err = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lst_staffs
        '
        Me.lst_staffs.FormattingEnabled = True
        Me.lst_staffs.ItemHeight = 16
        Me.lst_staffs.Location = New System.Drawing.Point(41, 88)
        Me.lst_staffs.Name = "lst_staffs"
        Me.lst_staffs.Size = New System.Drawing.Size(103, 292)
        Me.lst_staffs.TabIndex = 1
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(215, 204)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(25, 17)
        Me.lbl_id.TabIndex = 2
        Me.lbl_id.Text = "ID:"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Location = New System.Drawing.Point(215, 242)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(49, 17)
        Me.lbl_name.TabIndex = 3
        Me.lbl_name.Text = "Name:"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(270, 201)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(51, 22)
        Me.txt_id.TabIndex = 4
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(270, 239)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(221, 22)
        Me.txt_name.TabIndex = 5
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_table, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_new, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_delete, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_save, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(539, 280)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel1.TabIndex = 6
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
        'err
        '
        Me.err.ContainerControl = Me
        '
        'frm_staffs_a187806
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.lst_staffs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_staffs_a187806"
        Me.Controls.SetChildIndex(Me.lst_staffs, 0)
        Me.Controls.SetChildIndex(Me.pic_home, 0)
        Me.Controls.SetChildIndex(Me.lbl_id, 0)
        Me.Controls.SetChildIndex(Me.lbl_name, 0)
        Me.Controls.SetChildIndex(Me.txt_id, 0)
        Me.Controls.SetChildIndex(Me.txt_name, 0)
        Me.Controls.SetChildIndex(Me.TableLayoutPanel1, 0)
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lst_staffs As ListBox
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btn_table As Button
    Friend WithEvents btn_new As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents err As ErrorProvider
End Class
