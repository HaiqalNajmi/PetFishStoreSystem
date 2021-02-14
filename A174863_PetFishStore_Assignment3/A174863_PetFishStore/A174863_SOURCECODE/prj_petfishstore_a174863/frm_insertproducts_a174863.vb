Public Class frm_insertproducts_a174863
    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"
    Private Sub frm_insertproducts_a174863_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A174863")
        txt_productid.Text = generate_matric()
        txt_picture.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)

    End Sub
    Private Function generate_matric() As String
        Dim lastmatric As String = run_sql_query("SELECT MAX(FLD_PRODUCT_ID) AS LASTMATRIC FROM TBL_PRODUCTS_A174863").Rows(0).Item("LASTMATRIC")

        Dim newmatric As String = "P0" & Mid(lastmatric, 2) + 1
        Return newmatric
    End Function

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A174863 VALUES ('" & txt_productid.Text & "', '" & txt_productname.Text & "', " & txt_price.Text & ", '" & txt_size.Text & "', '" & txt_type.Text & "', '" & txt_desc.Text & "', " & txt_quantity.Text & ")"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_picture.Text, "pictures\" & txt_productid.Text & ".jpg")

            grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A174863")
            txt_productid.Text = generate_matric()
            txt_productname.Text = ""
            txt_desc.Text = ""
            txt_size.Text = ""
            txt_type.Text = ""
            txt_quantity.Text = ""
            txt_price.Text = ""

            txt_picture.Text = defaultpicture
            pic_product.BackgroundImage = Image.FromFile(defaultpicture)

        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()
        End Try
    End Sub

    Private Sub btn_picture_Click(sender As Object, e As EventArgs) Handles btn_picture.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        Try
            pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)

        Catch ex As Exception

        End Try

        txt_picture.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        frm_mainmenu_a174863.Show()
        Me.Hide()
    End Sub
End Class