<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_staffs_a187806
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
        Me.grd_table = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        CType(Me.grd_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_table
        '
        Me.grd_table.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grd_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_table.Location = New System.Drawing.Point(38, 79)
        Me.grd_table.Name = "grd_table"
        Me.grd_table.RowHeadersWidth = 51
        Me.grd_table.RowTemplate.Height = 24
        Me.grd_table.Size = New System.Drawing.Size(724, 352)
        Me.grd_table.TabIndex = 3
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(44, 19)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(128, 41)
        Me.lbl_title.TabIndex = 2
        Me.lbl_title.Text = "Staffs"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frm_staffs_a187806
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grd_table)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_staffs_a187806"
        Me.Text = "frm_staffs_a187806"
        CType(Me.grd_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_table As DataGridView
    Friend WithEvents lbl_title As Label
End Class
