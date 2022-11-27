Imports System.ComponentModel

Public Class frm_mainmenu_a187806
    Const GITHUB_LINK = "https://github.com/Polar8ear/advanced-db-assignment-1-aircraft-acnovation"

    ' Currently I'm using a general tableView template form for all the tables, but I have also
    ' created individual forms just in case there are customisation for each of them
    Dim productsForm As New frm_tableView_a187806("Products", "SELECT * FROM TBL_PRODUCTS_A187806")
    Dim customersForm As New frm_tableView_a187806("Customers", "SELECT * FROM TBL_CUSTOMERS_A187806")
    Dim ordersForm As New frm_tableView_a187806("Orders", "SELECT * FROM TBL_ORDERS_A187806")
    Dim staffsForm As New frm_tableView_a187806("Staffs", "SELECT * FROM TBL_STAFFS_A187806")
    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        ordersForm.Show()
        Hide()
    End Sub

    Private Sub btn_products_Click(sender As Object, e As EventArgs) Handles btn_products.Click
        productsForm.Show()
        Hide()
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        customersForm.Show()
        Hide()
    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        staffsForm.Show()
        Hide()
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
End Class
