<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_vieworder_a174863
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_total2 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_orderid3 = New System.Windows.Forms.Label()
        Me.txt_customerid = New System.Windows.Forms.TextBox()
        Me.cbb_orderid = New System.Windows.Forms.ComboBox()
        Me.lbl_orderid = New System.Windows.Forms.Label()
        Me.lbl_staffid = New System.Windows.Forms.Label()
        Me.lbl_customerid = New System.Windows.Forms.Label()
        Me.lbl_orderid2 = New System.Windows.Forms.Label()
        Me.txt_staffid = New System.Windows.Forms.TextBox()
        Me.grd_orderdetails = New System.Windows.Forms.DataGridView()
        Me.lbl_company = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        CType(Me.grd_orderdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_total2
        '
        Me.lbl_total2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_total2.AutoSize = True
        Me.lbl_total2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total2.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lbl_total2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_total2.Location = New System.Drawing.Point(698, 539)
        Me.lbl_total2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_total2.Name = "lbl_total2"
        Me.lbl_total2.Size = New System.Drawing.Size(103, 37)
        Me.lbl_total2.TabIndex = 113
        Me.lbl_total2.Text = "TOTAL"
        Me.lbl_total2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_total2.UseMnemonic = False
        '
        'lbl_total
        '
        Me.lbl_total.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.LightYellow
        Me.lbl_total.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_total.Location = New System.Drawing.Point(564, 539)
        Me.lbl_total.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(103, 37)
        Me.lbl_total.TabIndex = 112
        Me.lbl_total.Text = "TOTAL"
        Me.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_total.UseMnemonic = False
        '
        'lbl_orderid3
        '
        Me.lbl_orderid3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_orderid3.AutoSize = True
        Me.lbl_orderid3.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderid3.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid3.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lbl_orderid3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_orderid3.Location = New System.Drawing.Point(352, 539)
        Me.lbl_orderid3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_orderid3.Name = "lbl_orderid3"
        Me.lbl_orderid3.Size = New System.Drawing.Size(158, 37)
        Me.lbl_orderid3.TabIndex = 111
        Me.lbl_orderid3.Text = "ORDER ID "
        Me.lbl_orderid3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_orderid3.UseMnemonic = False
        '
        'txt_customerid
        '
        Me.txt_customerid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_customerid.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customerid.Location = New System.Drawing.Point(859, 204)
        Me.txt_customerid.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_customerid.Name = "txt_customerid"
        Me.txt_customerid.ReadOnly = True
        Me.txt_customerid.Size = New System.Drawing.Size(135, 24)
        Me.txt_customerid.TabIndex = 110
        '
        'cbb_orderid
        '
        Me.cbb_orderid.FormattingEnabled = True
        Me.cbb_orderid.Location = New System.Drawing.Point(182, 206)
        Me.cbb_orderid.Margin = New System.Windows.Forms.Padding(4)
        Me.cbb_orderid.Name = "cbb_orderid"
        Me.cbb_orderid.Size = New System.Drawing.Size(135, 24)
        Me.cbb_orderid.TabIndex = 109
        '
        'lbl_orderid
        '
        Me.lbl_orderid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_orderid.AutoSize = True
        Me.lbl_orderid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderid.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lbl_orderid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_orderid.Location = New System.Drawing.Point(39, 209)
        Me.lbl_orderid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_orderid.Name = "lbl_orderid"
        Me.lbl_orderid.Size = New System.Drawing.Size(91, 19)
        Me.lbl_orderid.TabIndex = 108
        Me.lbl_orderid.Text = "ORDER ID "
        Me.lbl_orderid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_orderid.UseMnemonic = False
        '
        'lbl_staffid
        '
        Me.lbl_staffid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_staffid.AutoSize = True
        Me.lbl_staffid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_staffid.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_staffid.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lbl_staffid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_staffid.Location = New System.Drawing.Point(365, 206)
        Me.lbl_staffid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_staffid.Name = "lbl_staffid"
        Me.lbl_staffid.Size = New System.Drawing.Size(76, 19)
        Me.lbl_staffid.TabIndex = 107
        Me.lbl_staffid.Text = "STAFF ID"
        Me.lbl_staffid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_staffid.UseMnemonic = False
        '
        'lbl_customerid
        '
        Me.lbl_customerid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_customerid.AutoSize = True
        Me.lbl_customerid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customerid.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customerid.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lbl_customerid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_customerid.Location = New System.Drawing.Point(683, 206)
        Me.lbl_customerid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_customerid.Name = "lbl_customerid"
        Me.lbl_customerid.Size = New System.Drawing.Size(118, 19)
        Me.lbl_customerid.TabIndex = 106
        Me.lbl_customerid.Text = "CUSTOMER ID"
        Me.lbl_customerid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_customerid.UseMnemonic = False
        '
        'lbl_orderid2
        '
        Me.lbl_orderid2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lbl_orderid2.AutoSize = True
        Me.lbl_orderid2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_orderid2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_orderid2.ForeColor = System.Drawing.Color.LightYellow
        Me.lbl_orderid2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_orderid2.Location = New System.Drawing.Point(159, 539)
        Me.lbl_orderid2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_orderid2.Name = "lbl_orderid2"
        Me.lbl_orderid2.Size = New System.Drawing.Size(158, 37)
        Me.lbl_orderid2.TabIndex = 105
        Me.lbl_orderid2.Text = "ORDER ID "
        Me.lbl_orderid2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_orderid2.UseMnemonic = False
        '
        'txt_staffid
        '
        Me.txt_staffid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_staffid.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_staffid.Location = New System.Drawing.Point(496, 204)
        Me.txt_staffid.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_staffid.Name = "txt_staffid"
        Me.txt_staffid.ReadOnly = True
        Me.txt_staffid.Size = New System.Drawing.Size(135, 24)
        Me.txt_staffid.TabIndex = 104
        '
        'grd_orderdetails
        '
        Me.grd_orderdetails.AllowUserToAddRows = False
        Me.grd_orderdetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_orderdetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_orderdetails.BackgroundColor = System.Drawing.Color.Lavender
        Me.grd_orderdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orderdetails.Location = New System.Drawing.Point(13, 263)
        Me.grd_orderdetails.Margin = New System.Windows.Forms.Padding(4)
        Me.grd_orderdetails.Name = "grd_orderdetails"
        Me.grd_orderdetails.ReadOnly = True
        Me.grd_orderdetails.RowHeadersWidth = 51
        Me.grd_orderdetails.Size = New System.Drawing.Size(1003, 224)
        Me.grd_orderdetails.TabIndex = 103
        '
        'lbl_company
        '
        Me.lbl_company.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_company.AutoSize = True
        Me.lbl_company.BackColor = System.Drawing.Color.Transparent
        Me.lbl_company.Font = New System.Drawing.Font("Harlow Solid Italic", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_company.ForeColor = System.Drawing.Color.LightYellow
        Me.lbl_company.Location = New System.Drawing.Point(422, 76)
        Me.lbl_company.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_company.Name = "lbl_company"
        Me.lbl_company.Size = New System.Drawing.Size(187, 35)
        Me.lbl_company.TabIndex = 101
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
        Me.lbl_title.Location = New System.Drawing.Point(360, 9)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(300, 49)
        Me.lbl_title.TabIndex = 102
        Me.lbl_title.Text = "VIEW ORDER"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbl_title.UseMnemonic = False
        '
        'frm_vieworder_a174863
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BackgroundImage = Global.prj_petfishstore_a174863.My.Resources.Resources.Night
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1029, 624)
        Me.Controls.Add(Me.lbl_total2)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_orderid3)
        Me.Controls.Add(Me.txt_customerid)
        Me.Controls.Add(Me.cbb_orderid)
        Me.Controls.Add(Me.lbl_orderid)
        Me.Controls.Add(Me.lbl_staffid)
        Me.Controls.Add(Me.lbl_customerid)
        Me.Controls.Add(Me.lbl_orderid2)
        Me.Controls.Add(Me.txt_staffid)
        Me.Controls.Add(Me.grd_orderdetails)
        Me.Controls.Add(Me.lbl_company)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_vieworder_a174863"
        Me.Text = "frm_vieworder_a174863"
        CType(Me.grd_orderdetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_total2 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_orderid3 As Label
    Friend WithEvents txt_customerid As TextBox
    Friend WithEvents cbb_orderid As ComboBox
    Friend WithEvents lbl_orderid As Label
    Friend WithEvents lbl_staffid As Label
    Friend WithEvents lbl_customerid As Label
    Friend WithEvents lbl_orderid2 As Label
    Friend WithEvents txt_staffid As TextBox
    Friend WithEvents grd_orderdetails As DataGridView
    Friend WithEvents lbl_company As Label
    Friend WithEvents lbl_title As Label
End Class
