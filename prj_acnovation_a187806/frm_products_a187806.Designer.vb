<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_products_a187806
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_table = New System.Windows.Forms.DataGridView()
        CType(Me.grd_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(27, 8)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(68, 18)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Products"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grd_table
        '
        Me.grd_table.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grd_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_table.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grd_table.Location = New System.Drawing.Point(23, 45)
        Me.grd_table.Margin = New System.Windows.Forms.Padding(2)
        Me.grd_table.Name = "grd_table"
        Me.grd_table.RowHeadersWidth = 51
        Me.grd_table.RowTemplate.Height = 24
        Me.grd_table.Size = New System.Drawing.Size(754, 390)
        Me.grd_table.TabIndex = 1
        '
        'frm_products_a187806
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grd_table)
        Me.Controls.Add(Me.lbl_title)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(170, 86)
        Me.Name = "frm_products_a187806"
        Me.Padding = New System.Windows.Forms.Padding(2, 39, 2, 2)
        Me.Text = "Acnovation"
        Me.TopMost = True
        CType(Me.grd_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_table As DataGridView
End Class
