Public Class frm_splashscreen_a174863
    Private Sub frm_splashscreen_a174863_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click

        username = txt_name.Text
        frm_mainmenu_a174863.Show()
        Me.Hide()

    End Sub
End Class
