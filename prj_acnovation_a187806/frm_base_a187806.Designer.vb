<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_base_a187806
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
        Me.pic_home = New System.Windows.Forms.PictureBox()
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_home
        '
        Me.pic_home.Image = Global.prj_acnovation_a187806.My.Resources.Resources.homeIcon
        Me.pic_home.Location = New System.Drawing.Point(41, 26)
        Me.pic_home.Name = "pic_home"
        Me.pic_home.Size = New System.Drawing.Size(49, 42)
        Me.pic_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_home.TabIndex = 0
        Me.pic_home.TabStop = False
        '
        'frm_base_a187806
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pic_home)
        Me.Name = "frm_base_a187806"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_base_a187806"
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents pic_home As PictureBox
End Class
