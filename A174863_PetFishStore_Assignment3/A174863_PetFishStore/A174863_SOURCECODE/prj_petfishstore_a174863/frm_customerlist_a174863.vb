Public Class frm_customerlist_a174863
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        frm_mainmenu_a174863.Show()
        Me.Hide()

    End Sub

    Private Sub frm_customerlist_a174863_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myconnection As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=DB_PETFISHSTORE_A174863.accdb;Persist Security Info=False;"
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A174863"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_customers.DataSource = mydatatable
    End Sub
End Class