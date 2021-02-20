Public Class frm_order_a174863
    Private Sub frm_order_a174863_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM TBL_ORDER_A174863"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_order.DataSource = mydatatable
    End Sub
    Private Sub btn_orderdetails_Click(sender As Object, e As EventArgs) Handles btn_orderdetails.Click
        frm_vieworder_a174863.Show()
    End Sub
    Private Sub btn_makeorder_Click(sender As Object, e As EventArgs) Handles btn_makeorder.Click
        frm_makeorder_a174863.Show()
    End Sub
End Class