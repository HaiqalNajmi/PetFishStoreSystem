<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertcustomer_a174863
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
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.txt_customerid = New System.Windows.Forms.TextBox()
        Me.txt_customername = New System.Windows.Forms.TextBox()
        Me.txt_phonenum = New System.Windows.Forms.TextBox()
        Me.lbl_customerid = New System.Windows.Forms.Label()
        Me.lbl_customername = New System.Windows.Forms.Label()
        Me.lbl_phonenum = New System.Windows.Forms.Label()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Baskerville Old Face", 24.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.LightYellow
        Me.lbl_title.Location = New System.Drawing.Point(12, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(339, 45)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Add New Customer"
        '
        'grd_customer
        '
        Me.grd_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_customer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_customer.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.Location = New System.Drawing.Point(12, 71)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.RowHeadersWidth = 51
        Me.grd_customer.RowTemplate.Height = 24
        Me.grd_customer.Size = New System.Drawing.Size(638, 261)
        Me.grd_customer.TabIndex = 1
        '
        'txt_customerid
        '
        Me.txt_customerid.Location = New System.Drawing.Point(674, 103)
        Me.txt_customerid.Name = "txt_customerid"
        Me.txt_customerid.Size = New System.Drawing.Size(241, 22)
        Me.txt_customerid.TabIndex = 2
        '
        'txt_customername
        '
        Me.txt_customername.Location = New System.Drawing.Point(674, 175)
        Me.txt_customername.Name = "txt_customername"
        Me.txt_customername.Size = New System.Drawing.Size(241, 22)
        Me.txt_customername.TabIndex = 3
        '
        'txt_phonenum
        '
        Me.txt_phonenum.Location = New System.Drawing.Point(674, 251)
        Me.txt_phonenum.Name = "txt_phonenum"
        Me.txt_phonenum.Size = New System.Drawing.Size(241, 22)
        Me.txt_phonenum.TabIndex = 4
        '
        'lbl_customerid
        '
        Me.lbl_customerid.AutoSize = True
        Me.lbl_customerid.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customerid.ForeColor = System.Drawing.Color.LightYellow
        Me.lbl_customerid.Location = New System.Drawing.Point(670, 71)
        Me.lbl_customerid.Name = "lbl_customerid"
        Me.lbl_customerid.Size = New System.Drawing.Size(114, 19)
        Me.lbl_customerid.TabIndex = 5
        Me.lbl_customerid.Text = "Customer ID"
        '
        'lbl_customername
        '
        Me.lbl_customername.AutoSize = True
        Me.lbl_customername.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customername.ForeColor = System.Drawing.Color.LightYellow
        Me.lbl_customername.Location = New System.Drawing.Point(670, 142)
        Me.lbl_customername.Name = "lbl_customername"
        Me.lbl_customername.Size = New System.Drawing.Size(142, 19)
        Me.lbl_customername.TabIndex = 6
        Me.lbl_customername.Text = "Customer Name"
        '
        'lbl_phonenum
        '
        Me.lbl_phonenum.AutoSize = True
        Me.lbl_phonenum.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phonenum.ForeColor = System.Drawing.Color.LightYellow
        Me.lbl_phonenum.Location = New System.Drawing.Point(670, 216)
        Me.lbl_phonenum.Name = "lbl_phonenum"
        Me.lbl_phonenum.Size = New System.Drawing.Size(132, 19)
        Me.lbl_phonenum.TabIndex = 7
        Me.lbl_phonenum.Text = "Phone Number"
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_insert.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.ForeColor = System.Drawing.Color.LightYellow
        Me.btn_insert.Location = New System.Drawing.Point(797, 292)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(118, 40)
        Me.btn_insert.TabIndex = 8
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.SlateBlue
        Me.btn_exit.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.LightYellow
        Me.btn_exit.Location = New System.Drawing.Point(797, 353)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(118, 40)
        Me.btn_exit.TabIndex = 9
        Me.btn_exit.Text = "RETURN"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'frm_insertcustomer_a174863
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BackgroundImage = Global.prj_petfishstore_a174863.My.Resources.Resources.Night
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(941, 436)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.lbl_phonenum)
        Me.Controls.Add(Me.lbl_customername)
        Me.Controls.Add(Me.lbl_customerid)
        Me.Controls.Add(Me.txt_phonenum)
        Me.Controls.Add(Me.txt_customername)
        Me.Controls.Add(Me.txt_customerid)
        Me.Controls.Add(Me.grd_customer)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_insertcustomer_a174863"
        Me.Text = "frm_insertcustomer_a174863"
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents txt_customerid As TextBox
    Friend WithEvents txt_customername As TextBox
    Friend WithEvents txt_phonenum As TextBox
    Friend WithEvents lbl_customerid As Label
    Friend WithEvents lbl_customername As Label
    Friend WithEvents lbl_phonenum As Label
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_exit As Button
End Class
