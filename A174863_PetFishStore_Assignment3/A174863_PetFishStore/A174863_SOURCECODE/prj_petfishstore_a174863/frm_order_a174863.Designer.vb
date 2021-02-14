<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_order_a174863
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
        Me.btn_makeorder = New System.Windows.Forms.Button()
        Me.btn_orderdetails = New System.Windows.Forms.Button()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.lbl_company = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_makeorder
        '
        Me.btn_makeorder.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_makeorder.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_makeorder.ForeColor = System.Drawing.Color.LightYellow
        Me.btn_makeorder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_makeorder.Location = New System.Drawing.Point(267, 593)
        Me.btn_makeorder.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_makeorder.Name = "btn_makeorder"
        Me.btn_makeorder.Size = New System.Drawing.Size(183, 49)
        Me.btn_makeorder.TabIndex = 15
        Me.btn_makeorder.Text = "MAKE ORDER"
        Me.btn_makeorder.UseVisualStyleBackColor = False
        '
        'btn_orderdetails
        '
        Me.btn_orderdetails.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_orderdetails.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_orderdetails.ForeColor = System.Drawing.Color.LightYellow
        Me.btn_orderdetails.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_orderdetails.Location = New System.Drawing.Point(547, 593)
        Me.btn_orderdetails.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_orderdetails.Name = "btn_orderdetails"
        Me.btn_orderdetails.Size = New System.Drawing.Size(185, 49)
        Me.btn_orderdetails.TabIndex = 14
        Me.btn_orderdetails.Text = "VIEW ORDER"
        Me.btn_orderdetails.UseVisualStyleBackColor = False
        '
        'grd_order
        '
        Me.grd_order.AllowUserToAddRows = False
        Me.grd_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_order.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_order.BackgroundColor = System.Drawing.Color.White
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(13, 306)
        Me.grd_order.Margin = New System.Windows.Forms.Padding(4)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.ReadOnly = True
        Me.grd_order.RowHeadersWidth = 51
        Me.grd_order.Size = New System.Drawing.Size(1006, 269)
        Me.grd_order.TabIndex = 13
        '
        'lbl_company
        '
        Me.lbl_company.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_company.AutoSize = True
        Me.lbl_company.BackColor = System.Drawing.Color.Transparent
        Me.lbl_company.Font = New System.Drawing.Font("Harlow Solid Italic", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_company.ForeColor = System.Drawing.Color.LightYellow
        Me.lbl_company.Location = New System.Drawing.Point(428, 69)
        Me.lbl_company.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_company.Name = "lbl_company"
        Me.lbl_company.Size = New System.Drawing.Size(162, 30)
        Me.lbl_company.TabIndex = 11
        Me.lbl_company.Text = "Pet Fish Store"
        Me.lbl_company.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbl_company.UseMnemonic = False
        '
        'lbl_title
        '
        Me.lbl_title.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Baskerville Old Face", 25.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.LightYellow
        Me.lbl_title.Location = New System.Drawing.Point(307, 9)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(425, 49)
        Me.lbl_title.TabIndex = 12
        Me.lbl_title.Text = "CUSTOMER ORDER"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbl_title.UseMnemonic = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightYellow
        Me.Label7.Location = New System.Drawing.Point(541, 219)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 19)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "Fax : 04-6422582"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightYellow
        Me.Label6.Location = New System.Drawing.Point(375, 254)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(274, 19)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "Email : petfishstore@gmail.com"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightYellow
        Me.Label5.Location = New System.Drawing.Point(312, 219)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 19)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "Tel : 017-3276246"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightYellow
        Me.Label2.Location = New System.Drawing.Point(386, 177)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 19)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "53300 Setapak, Kuala Lumpur."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightYellow
        Me.Label9.Location = New System.Drawing.Point(386, 145)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(224, 19)
        Me.Label9.TabIndex = 103
        Me.Label9.Text = "Seksyen 10 Wangsa Maju,"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.LightYellow
        Me.Label10.Location = New System.Drawing.Point(386, 113)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(242, 19)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "Lot 16, Jalan Metro Wangsa,"
        '
        'frm_order_a174863
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BackgroundImage = Global.prj_petfishstore_a174863.My.Resources.Resources.Night
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1032, 663)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_makeorder)
        Me.Controls.Add(Me.btn_orderdetails)
        Me.Controls.Add(Me.grd_order)
        Me.Controls.Add(Me.lbl_company)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_order_a174863"
        Me.Text = "frm_invoice_a174863"
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_makeorder As Button
    Friend WithEvents btn_orderdetails As Button
    Friend WithEvents grd_order As DataGridView
    Friend WithEvents lbl_company As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
