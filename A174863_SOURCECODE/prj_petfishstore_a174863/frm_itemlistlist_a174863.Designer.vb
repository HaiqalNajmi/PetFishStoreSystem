<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_itemlistlist_a174863
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.grd_itemlistlists = New System.Windows.Forms.DataGridView()
        Me.lbl_title = New System.Windows.Forms.Label()
        CType(Me.grd_itemlistlists, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.SlateBlue
        Me.btn_exit.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.LightYellow
        Me.btn_exit.Location = New System.Drawing.Point(833, 524)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(132, 43)
        Me.btn_exit.TabIndex = 8
        Me.btn_exit.Text = "RETURN"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'grd_itemlistlists
        '
        Me.grd_itemlistlists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_itemlistlists.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_itemlistlists.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.grd_itemlistlists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_itemlistlists.Location = New System.Drawing.Point(12, 68)
        Me.grd_itemlistlists.Name = "grd_itemlistlists"
        Me.grd_itemlistlists.RowHeadersWidth = 51
        Me.grd_itemlistlists.RowTemplate.Height = 24
        Me.grd_itemlistlists.Size = New System.Drawing.Size(953, 440)
        Me.grd_itemlistlists.TabIndex = 7
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Baskerville Old Face", 24.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.LightYellow
        Me.lbl_title.Location = New System.Drawing.Point(12, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(162, 45)
        Me.lbl_title.TabIndex = 6
        Me.lbl_title.Text = "Item List"
        '
        'frm_itemlistlist_a174863
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BackgroundImage = Global.prj_petfishstore_a174863.My.Resources.Resources.Night
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(991, 586)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.grd_itemlistlists)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_itemlistlist_a174863"
        Me.Text = "frm_itemlistlist_a174863"
        CType(Me.grd_itemlistlists, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_exit As Button
    Friend WithEvents grd_itemlistlists As DataGridView
    Friend WithEvents lbl_title As Label
End Class
