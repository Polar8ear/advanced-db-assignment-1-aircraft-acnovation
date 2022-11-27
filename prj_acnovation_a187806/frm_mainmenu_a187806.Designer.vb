<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_mainmenu_a187806
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_mainmenu_a187806))
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_products = New System.Windows.Forms.Button()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.btn_customer = New System.Windows.Forms.Button()
        Me.btn_staff = New System.Windows.Forms.Button()
        Me.lnk_github = New System.Windows.Forms.LinkLabel()
        Me.pnl_githublink = New System.Windows.Forms.Panel()
        Me.pic_github = New System.Windows.Forms.PictureBox()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.pnl_githublink.SuspendLayout()
        CType(Me.pic_github, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(160, 33)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(466, 40)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Acnovation Online Store"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_products
        '
        Me.btn_products.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_products.Location = New System.Drawing.Point(95, 292)
        Me.btn_products.Name = "btn_products"
        Me.btn_products.Size = New System.Drawing.Size(130, 52)
        Me.btn_products.TabIndex = 3
        Me.btn_products.Text = "Products"
        Me.btn_products.UseVisualStyleBackColor = True
        '
        'btn_order
        '
        Me.btn_order.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_order.Location = New System.Drawing.Point(255, 292)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(130, 52)
        Me.btn_order.TabIndex = 4
        Me.btn_order.Text = "Orders"
        Me.btn_order.UseVisualStyleBackColor = True
        '
        'btn_customer
        '
        Me.btn_customer.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_customer.Location = New System.Drawing.Point(415, 292)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(130, 52)
        Me.btn_customer.TabIndex = 5
        Me.btn_customer.Text = "Customers"
        Me.btn_customer.UseVisualStyleBackColor = True
        '
        'btn_staff
        '
        Me.btn_staff.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_staff.Location = New System.Drawing.Point(575, 292)
        Me.btn_staff.Name = "btn_staff"
        Me.btn_staff.Size = New System.Drawing.Size(130, 52)
        Me.btn_staff.TabIndex = 6
        Me.btn_staff.Text = "Staffs"
        Me.btn_staff.UseVisualStyleBackColor = True
        '
        'lnk_github
        '
        Me.lnk_github.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lnk_github.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnk_github.Location = New System.Drawing.Point(26, 0)
        Me.lnk_github.Name = "lnk_github"
        Me.lnk_github.Size = New System.Drawing.Size(113, 28)
        Me.lnk_github.TabIndex = 8
        Me.lnk_github.TabStop = True
        Me.lnk_github.Tag = "https://stackoverflow.com/questions/10786835/how-to-set-controls-on-center-of-the" &
    "-winform"
        Me.lnk_github.Text = "Repository Link"
        Me.lnk_github.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lnk_github.UseWaitCursor = True
        '
        'pnl_githublink
        '
        Me.pnl_githublink.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnl_githublink.Controls.Add(Me.lnk_github)
        Me.pnl_githublink.Controls.Add(Me.pic_github)
        Me.pnl_githublink.Location = New System.Drawing.Point(12, 410)
        Me.pnl_githublink.Name = "pnl_githublink"
        Me.pnl_githublink.Size = New System.Drawing.Size(139, 28)
        Me.pnl_githublink.TabIndex = 9
        '
        'pic_github
        '
        Me.pic_github.Dock = System.Windows.Forms.DockStyle.Left
        Me.pic_github.Image = Global.prj_acnovation_a187806.My.Resources.Resources.github
        Me.pic_github.Location = New System.Drawing.Point(0, 0)
        Me.pic_github.Name = "pic_github"
        Me.pic_github.Size = New System.Drawing.Size(26, 28)
        Me.pic_github.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_github.TabIndex = 7
        Me.pic_github.TabStop = False
        '
        'pic_logo
        '
        Me.pic_logo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pic_logo.Image = Global.prj_acnovation_a187806.My.Resources.Resources.logo
        Me.pic_logo.Location = New System.Drawing.Point(340, 100)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(128, 128)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_logo.TabIndex = 2
        Me.pic_logo.TabStop = False
        '
        'frm_mainmenu_a187806
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnl_githublink)
        Me.Controls.Add(Me.btn_staff)
        Me.Controls.Add(Me.btn_customer)
        Me.Controls.Add(Me.btn_order)
        Me.Controls.Add(Me.btn_products)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.lbl_title)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_mainmenu_a187806"
        Me.Text = "Acnovation"
        Me.pnl_githublink.ResumeLayout(False)
        CType(Me.pic_github, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents pic_logo As PictureBox
    Friend WithEvents btn_products As Button
    Friend WithEvents btn_order As Button
    Friend WithEvents btn_customer As Button
    Friend WithEvents btn_staff As Button
    Friend WithEvents pic_github As PictureBox
    Friend WithEvents lnk_github As LinkLabel
    Friend WithEvents pnl_githublink As Panel
End Class
