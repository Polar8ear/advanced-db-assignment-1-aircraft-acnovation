Public Class frm_base_a187806
    Private Sub frm_base_a187806_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = My.Resources.icon
    End Sub

    Overridable Sub frm_base_a187806_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub pic_home_Click(sender As Object, e As EventArgs) Handles pic_home.Click
        frm_mainmenu_a187806.Show()
        Dispose()
    End Sub
End Class