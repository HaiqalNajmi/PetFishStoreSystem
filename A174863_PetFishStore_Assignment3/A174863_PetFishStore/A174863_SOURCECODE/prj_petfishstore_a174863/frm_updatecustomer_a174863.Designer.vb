<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updatecustomer_a174863
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
        Me.txt_custname = New System.Windows.Forms.TextBox()
        Me.txt_phonenum = New System.Windows.Forms.TextBox()
        Me.lbl_customerid = New System.Windows.Forms.Label()
        Me.lbl_custname = New System.Windows.Forms.Label()
        Me.lbl_phonenum = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
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
        Me.lbl_title.Size = New System.Drawing.Size(420, 45)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Update/Delete Customer"
        '
        'grd_customer
        '
        Me.grd_customer.AllowUserToAddRows = False
        Me.grd_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_customer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.grd_customer.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.Location = New System.Drawing.Point(20, 72)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.ReadOnly = True
        Me.grd_customer.RowHeadersWidth = 51
        Me.grd_customer.RowTemplate.Height = 24
        Me.grd_customer.Size = New System.Drawing.Size(671, 286)
        Me.grd_customer.TabIndex = 1
        '
        'txt_customerid
        '
        Me.txt_customerid.Location = New System.Drawing.Point(715, 118)
        Me.txt_customerid.Name = "txt_customerid"
        Me.txt_customerid.ReadOnly = True
        Me.txt_customerid.Size = New System.Drawing.Size(283, 22)
        Me.txt_customerid.TabIndex = 2
        '
        'txt_custname
        '
        Me.txt_custname.Location = New System.Drawing.Point(715, 184)
        Me.txt_custname.Name = "txt_custname"
        Me.txt_custname.Size = New System.Drawing.Size(283, 22)
        Me.txt_custname.TabIndex = 3
        '
        'txt_phonenum
        '
        Me.txt_phonenum.Location = New System.Drawing.Point(715, 251)
        Me.txt_phonenum.Name = "txt_phonenum"
        Me.txt_phonenum.Size = New System.Drawing.Size(283, 22)
        Me.txt_phonenum.TabIndex = 4
        '
        'lbl_customerid
        '
        Me.lbl_customerid.AutoSize = True
        Me.lbl_customerid.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customerid.ForeColor = System.Drawing.Color.LightYellow
        Me.lbl_customerid.Location = New System.Drawing.Point(711, 86)
        Me.lbl_customerid.Name = "lbl_customerid"
        Me.lbl_customerid.Size = New System.Drawing.Size(114, 19)
        Me.lbl_customerid.TabIndex = 5
        Me.lbl_customerid.Text = "Customer ID"
        '
        'lbl_custname
        '
        Me.lbl_custname.AutoSize = True
        Me.lbl_custname.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_custname.ForeColor = System.Drawing.Color.LightYellow
        Me.lbl_custname.Location = New System.Drawing.Point(711, 153)
        Me.lbl_custname.Name = "lbl_custname"
        Me.lbl_custname.Size = New System.Drawing.Size(142, 19)
        Me.lbl_custname.TabIndex = 6
        Me.lbl_custname.Text = "Customer Name"
        '
        'lbl_phonenum
        '
        Me.lbl_phonenum.AutoSize = True
        Me.lbl_phonenum.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phonenum.ForeColor = System.Drawing.Color.LightYellow
        Me.lbl_phonenum.Location = New System.Drawing.Point(711, 220)
        Me.lbl_phonenum.Name = "lbl_phonenum"
        Me.lbl_phonenum.Size = New System.Drawing.Size(132, 19)
        Me.lbl_phonenum.TabIndex = 7
        Me.lbl_phonenum.Text = "Phone Number"
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_update.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.LightYellow
        Me.btn_update.Location = New System.Drawing.Point(715, 318)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(128, 40)
        Me.btn_update.TabIndex = 8
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Crimson
        Me.btn_delete.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.LightYellow
        Me.btn_delete.Location = New System.Drawing.Point(881, 318)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(117, 40)
        Me.btn_delete.TabIndex = 9
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.SlateBlue
        Me.btn_exit.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.LightYellow
        Me.btn_exit.Location = New System.Drawing.Point(881, 382)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(117, 45)
        Me.btn_exit.TabIndex = 10
        Me.btn_exit.Text = "RETURN"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'frm_updatecustomer_a174863
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BackgroundImage = Global.prj_petfishstore_a174863.My.Resources.Resources.Night
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1037, 450)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.lbl_phonenum)
        Me.Controls.Add(Me.lbl_custname)
        Me.Controls.Add(Me.lbl_customerid)
        Me.Controls.Add(Me.txt_phonenum)
        Me.Controls.Add(Me.txt_custname)
        Me.Controls.Add(Me.txt_customerid)
        Me.Controls.Add(Me.grd_customer)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_updatecustomer_a174863"
        Me.Text = "frm_updatecustomer_a174863"
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents txt_customerid As TextBox
    Friend WithEvents txt_custname As TextBox
    Friend WithEvents txt_phonenum As TextBox
    Friend WithEvents lbl_customerid As Label
    Friend WithEvents lbl_custname As Label
    Friend WithEvents lbl_phonenum As Label
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_exit As Button
End Class
