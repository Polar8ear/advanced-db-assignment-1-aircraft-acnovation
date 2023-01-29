Imports System.ComponentModel

Public Class frm_mainmenu_a187806
    Private Sub btn_products_Click(sender As Object, e As EventArgs) Handles btn_products.Click
        frm_products_a187806.Show()
        Dispose()
    End Sub
    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        frm_orders_a187806.Show()
        Dispose()
    End Sub


    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        frm_customers_a187806.Show()
        Dispose()
    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_staffs_a187806.Show()
        Dispose()
    End Sub

    Private Sub frm_mainmenu_a187806_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Sub VisitLink()
        lnk_github.LinkVisited = True
        System.Diagnostics.Process.Start(GITHUB_LINK)
    End Sub

    Private Sub lnk_github_Clicked(sender As Object, e As EventArgs) Handles lnk_github.Click
        Try
            VisitLink()
        Catch ex As Exception
            ' The error message
            MessageBox.Show("Unable to open link that was clicked.")
        End Try
    End Sub

    Private Sub frm_mainmenu_a187806_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = My.Resources.icon
    End Sub
End Class
