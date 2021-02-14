Public Class frm_productdetails_a174863

    Private Sub frm_productdetails_a174863_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A174863"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_productid.DataSource = mydatatable
        lst_productid.DisplayMember = "FLD_PRODUCT_ID"
        refresh_text(lst_productid.Text)

    End Sub
    Private Sub refresh_text(product As String)
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A174863 WHERE FLD_PRODUCT_ID='" & product & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        txt_productid.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        txt_productname.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        txt_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        txt_size.Text = mydatatable.Rows(0).Item("FLD_SIZE")
        txt_type.Text = mydatatable.Rows(0).Item("FLD_TYPE")
        txt_description.Text = mydatatable.Rows(0).Item("FLD_DESCRIPTION")
        txt_quantity.Text = mydatatable.Rows(0).Item("FLD_QUANTITY")

        pic_product.BackgroundImage = Image.FromFile("pictures/" & txt_productid.Text & ".jpg")
    End Sub

    Private Sub lst_productid_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_productid.MouseClick
        refresh_text(lst_productid.Text)
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        frm_mainmenu_a174863.Show()
        Me.Hide()
    End Sub

End Class