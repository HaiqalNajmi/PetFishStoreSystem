Public Class frm_mainmenu_a174863
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub frm_mainmenu_a174863_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim current_date As String = Date.Now
        lbl_date.Text = current_date
        lbl_welcome.Text = "Welcome " & username & " to our Pet Fish Store that is full of surprise!"

    End Sub

    Private Sub btn_productlist_Click(sender As Object, e As EventArgs) Handles btn_productlist.Click
        frm_productlist_a174863.Show()
        Me.Hide()

    End Sub

    Private Sub btn_customerlist_Click(sender As Object, e As EventArgs) Handles btn_customerlist.Click
        frm_customerlist_a174863.Show()
        Me.Hide()
    End Sub

    Private Sub btn_stafflist_Click(sender As Object, e As EventArgs) Handles btn_stafflist.Click
        frm_stafflist_a174863.Show()
        Me.Hide()
    End Sub

    Private Sub btn_orderlist_Click(sender As Object, e As EventArgs) Handles btn_orderlist.Click
        frm_orderlist_a174863.Show()
        Me.Hide()
    End Sub

    Private Sub btn_itemlistlist_Click(sender As Object, e As EventArgs) Handles btn_itemlistlist.Click
        frm_itemlistlist_a174863.Show()
        Me.Hide()
    End Sub

    Private Sub lbl_welcome_Click(sender As Object, e As EventArgs) Handles lbl_welcome.Click

    End Sub

    Private Sub btn_productdetails_Click(sender As Object, e As EventArgs) Handles btn_productdetails.Click
        frm_productdetails_a174863.Show()
        Me.Hide()

    End Sub

    Private Sub btn_insertproduct_Click(sender As Object, e As EventArgs) Handles btn_insertproduct.Click
        frm_insertproducts_a174863.Show()
        Me.Hide()

    End Sub

    Private Sub btn_insertcust_Click(sender As Object, e As EventArgs) Handles btn_insertcust.Click
        frm_insertcustomer_a174863.Show()
        Me.Hide()

    End Sub

    Private Sub btn_insertstaff_Click(sender As Object, e As EventArgs) Handles btn_insertstaff.Click
        frm_insertstaff_a174863.Show()
        Me.Hide()

    End Sub

    Private Sub btn_updateproduct_Click(sender As Object, e As EventArgs) Handles btn_updateproduct.Click
        frm_updateproducts_a174863.Show()
        Me.Hide()

    End Sub

    Private Sub btn_updatecust_Click(sender As Object, e As EventArgs) Handles btn_updatecust.Click
        frm_updatecustomer_a174863.Show()
        Me.Hide()

    End Sub

    Private Sub btn_updatestaff_Click(sender As Object, e As EventArgs) Handles btn_updatestaff.Click
        frm_updatestaff_a174863.Show()
        Me.Hide()

    End Sub

    Private Sub btn_makeorder_Click(sender As Object, e As EventArgs) Handles btn_makeorder.Click
        frm_makeorder_a174863.Show()
        'Me.Hide()
    End Sub

    Private Sub btn_vieworder_Click(sender As Object, e As EventArgs) Handles btn_vieworder.Click
        frm_vieworder_a174863.Show()
        'Me.Hide()
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        frm_order_a174863.Show()
        'Me.Hide()
    End Sub

    Private Sub frm_mainmenu_a174863_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()

    End Sub
End Class