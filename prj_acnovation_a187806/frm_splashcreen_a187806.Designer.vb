<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_splashcreen_a187806
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_splashcreen_a187806))
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.lbl_info = New System.Windows.Forms.Label()
        Me.btn_start = New System.Windows.Forms.Button()
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_home
        '
        Me.pic_home.Size = New System.Drawing.Size(0, 0)
        Me.pic_home.Visible = False
        '
        'pic_logo
        '
        Me.pic_logo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pic_logo.Image = Global.prj_acnovation_a187806.My.Resources.Resources.logo
        Me.pic_logo.Location = New System.Drawing.Point(255, 39)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(291, 294)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_logo.TabIndex = 3
        Me.pic_logo.TabStop = False
        '
        'lbl_info
        '
        Me.lbl_info.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_info.AutoSize = True
        Me.lbl_info.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_info.ForeColor = System.Drawing.Color.White
        Me.lbl_info.Location = New System.Drawing.Point(12, 413)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(251, 28)
        Me.lbl_info.TabIndex = 5
        Me.lbl_info.Text = "Chuo Ngiu Bing | A187806"
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(354, 339)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(93, 38)
        Me.btn_start.TabIndex = 6
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'frm_splashcreen_a187806
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.lbl_info)
        Me.Controls.Add(Me.pic_logo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_splashcreen_a187806"
        Me.Controls.SetChildIndex(Me.pic_home, 0)
        Me.Controls.SetChildIndex(Me.pic_logo, 0)
        Me.Controls.SetChildIndex(Me.lbl_info, 0)
        Me.Controls.SetChildIndex(Me.btn_start, 0)
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic_logo As PictureBox
    Friend WithEvents lbl_info As Label
    Friend WithEvents btn_start As Button
End Class
