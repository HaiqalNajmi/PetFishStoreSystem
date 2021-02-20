Public Class frm_updateproducts_a174863
    Dim current_code As String
    Private Sub frm_updateproducts_a174863_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        get_current_code()
    End Sub
    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A174863"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_products.DataSource = mydatatable
    End Sub
    Private Sub clear_fields()
        txt_productid.Text = ""
        txt_productname.Text = ""
        txt_desc.Text = ""
        txt_size.Text = ""
        txt_type.Text = ""
        txt_quantity.Text = ""
        txt_price.Text = ""
    End Sub
    Private Sub get_current_code()
        Dim current_row As Integer = grd_products.CurrentRow.Index
        current_code = grd_products(0, current_row).Value

        txt_productid.Text = current_code
        txt_productname.Text = grd_products(1, current_row).Value
        txt_price.Text = grd_products(2, current_row).Value
        txt_size.Text = grd_products(3, current_row).Value
        txt_type.Text = grd_products(4, current_row).Value
        txt_desc.Text = grd_products(5, current_row).Value
        txt_quantity.Text = grd_products(6, current_row).Value
    End Sub

    Private Sub grd_products_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_products.CellClick
        get_current_code()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_PRODUCTS_A174863 SET FLD_PRODUCT_NAME='" & txt_productname.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A174863 SET FLD_PRICE=" & txt_price.Text & " WHERE FLD_PRODUCT_ID='" & current_code & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A174863 SET FLD_SIZE='" & txt_size.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A174863 SET FLD_TYPE='" & txt_type.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A174863 SET FLD_DESCRIPTION='" & txt_desc.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")
        run_sql_command("UPDATE TBL_PRODUCTS_A174863 SET FLD_QUANTITY=" & txt_quantity.Text & " WHERE FLD_PRODUCT_ID='" & current_code & "'")
        Beep()
        MsgBox("You have successfully updated the product """ & current_code & """.")
        refresh_grid()
        clear_fields()
        get_current_code()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product """ & current_code & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_PRODUCTS_A174863 WHERE FLD_PRODUCT_ID='" & current_code & "'")

            Beep()
            MsgBox("The product """ & current_code & """ has been successfully deleted.")

            refresh_grid()
            clear_fields()
            get_current_code()
        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        frm_mainmenu_a174863.Show()
        Me.Hide()
    End Sub
End Class