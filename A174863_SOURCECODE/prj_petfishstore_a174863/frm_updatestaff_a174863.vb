Public Class frm_updatestaff_a174863
    Dim current_code As String
    Private Sub frm_updatestaff_a174863_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        get_current_code()
    End Sub
    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_STAFF_A174863"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_staff.DataSource = mydatatable
    End Sub
    Private Sub clear_fields()
        txt_staffid.Text = ""
        txt_staffname.Text = ""
        txt_email.Text = ""
    End Sub
    Private Sub get_current_code()
        Dim current_row As Integer = grd_staff.CurrentRow.Index
        current_code = grd_staff(0, current_row).Value

        txt_staffid.Text = current_code
        txt_staffname.Text = grd_staff(1, current_row).Value
        txt_email.Text = grd_staff(2, current_row).Value

    End Sub

    Private Sub grd_staff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellClick
        get_current_code()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        run_sql_command("UPDATE TBL_STAFF_A174863 SET FLD_STAFF_NAME='" & txt_staffname.Text & "' WHERE FLD_STAFF_ID='" & current_code & "'")
        run_sql_command("UPDATE TBL_STAFF_A174863 SET FLD_EMAIL='" & txt_email.Text & "' WHERE FLD_STAFF_ID='" & current_code & "'")
        Beep()
        MsgBox("You have successfully updated the staff """ & current_code & """.")
        refresh_grid()
        clear_fields()
        get_current_code()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the staff """ & current_code & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            run_sql_command("DELETE FROM TBL_STAFF_A174863 WHERE FLD_STAFF_ID='" & current_code & "'")

            Beep()
            MsgBox("The staff """ & current_code & """ has been successfully deleted.")

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