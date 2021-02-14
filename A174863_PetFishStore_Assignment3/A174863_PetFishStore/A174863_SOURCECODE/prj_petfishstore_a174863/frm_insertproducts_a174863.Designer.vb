<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertproducts_a174863
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
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.txt_productid = New System.Windows.Forms.TextBox()
        Me.txt_productname = New System.Windows.Forms.TextBox()
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.txt_size = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.lbl_productid = New System.Windows.Forms.Label()
        Me.lbl_productname = New System.Windows.Forms.Label()
        Me.lbl_desc = New System.Windows.Forms.Label()
        Me.lbl_size = New System.Windows.Forms.Label()
        Me.lbl_type = New System.Windows.Forms.Label()
        Me.lbl_quantity = New System.Windows.Forms.Label()
        Me.lbl_price = New System.Windows.Forms.Label()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.txt_picture = New System.Windows.Forms.TextBox()
        Me.btn_picture = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbl_title.Size = New System.Drawing.Size(323, 45)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Add New Products"
        '
        'grd_products
        '
        Me.grd_products.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_products.Location = New System.Drawing.Point(12, 68)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.RowHeadersWidth = 51
        Me.grd_products.RowTemplate.Height = 24
        Me.grd_products.Size = New System.Drawing.Size(917, 265)
        Me.grd_products.TabIndex = 1
        '
        'txt_productid
        '
        Me.txt_productid.Location = New System.Drawing.Point(346, 354)
        Me.txt_productid.Name = "txt_productid"
        Me.txt_productid.Size = New System.Drawing.Size(129, 22)
        Me.txt_productid.TabIndex = 2
        '
        'txt_productname
        '
        Me.txt_productname.Location = New System.Drawing.Point(346, 385)
        Me.txt_productname.Name = "txt_productname"
        Me.txt_productname.Size = New System.Drawing.Size(249, 22)
        Me.txt_productname.TabIndex = 3
        '
        'txt_desc
        '
        Me.txt_desc.Location = New System.Drawing.Point(346, 422)
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(583, 22)
        Me.txt_desc.TabIndex = 4
        '
        'txt_size
        '
        Me.txt_size.Location = New System.Drawing.Point(346, 461)
        Me.txt_size.Name = "txt_size"
        Me.txt_size.Size = New System.Drawing.Size(129, 22)
        Me.txt_size.TabIndex = 5
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(346, 498)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(129, 22)
        Me.txt_type.TabIndex = 6
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(639, 498)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(123, 22)
        Me.txt_price.TabIndex = 7
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(639, 461)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(123, 22)
        Me.txt_quantity.TabIndex = 8
        '
        'lbl_productid
        '
        Me.lbl_productid.AutoSize = True
        Me.lbl_productid.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productid.ForeColor = System.Drawing.Color.LightYellow
        Me.lbl_productid.Location = New System.Drawing.Point(175, 355)
        Me.lbl_productid.Name = "lbl_productid"
        Me.lbl_productid.Size = New System.Drawing.Size(97, 19)
        Me.lbl_productid.TabIndex = 9
        Me.lbl_productid.Text = "Product ID"
        '
        'lbl_productname
        '
        Me.lbl_productname.AutoSize = True
        Me.lbl_productname.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productname.ForeColor = System.Drawing.Color.LightYellow
        Me.lbl_productname.Location = New System.Drawing.Point(175, 386)
        Me.lbl_productname.Name = "lbl_productname"
        Me.lbl_productname.Size = New System.Drawing.Size(125, 19)
        Me.lbl_productname.TabIndex = 10
        Me.lbl_productname.Text = "Product Name"
        '
        'lbl_desc
        '
        Me.lbl_desc.AutoSize = True
        Me.lbl_desc.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_desc.ForeColor = System.Drawing.Color.LightYellow
        Me.lbl_desc.Location = New System.Drawing.Point(175, 423)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(107, 19)
        Me.lbl_desc.TabIndex = 11
        Me.lbl_desc.Text = "Description"
        '
        'lbl_size
        '
        Me.lbl_size.AutoSize = True
        Me.lbl_size.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_size.ForeColor = System.Drawing.Color.LightYellow
        Me.lbl_size.Location = New System.Drawing.Point(175, 464)
        Me.lbl_size.Name = "lbl_size"
        Me.lbl_size.Size = New System.Drawing.Size(43, 19)
        Me.lbl_size.TabIndex = 12
        Me.lbl_size.Text = "Size"
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_type.ForeColor = System.Drawing.Color.LightYellow
        Me.lbl_type.Location = New System.Drawing.Point(175, 499)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(48, 19)
        Me.lbl_type.TabIndex = 13
        Me.lbl_type.Text = "Type"
        '
        'lbl_quantity
        '
        Me.lbl_quantity.AutoSize = True
        Me.lbl_quantity.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_quantity.ForeColor = System.Drawing.Color.LightYellow
        Me.lbl_quantity.Location = New System.Drawing.Point(506, 462)
        Me.lbl_quantity.Name = "lbl_quantity"
        Me.lbl_quantity.Size = New System.Drawing.Size(80, 19)
        Me.lbl_quantity.TabIndex = 14
        Me.lbl_quantity.Text = "Quantity"
        '
        'lbl_price
        '
        Me.lbl_price.AutoSize = True
        Me.lbl_price.Font = New System.Drawing.Font("Lucida Sans", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_price.ForeColor = System.Drawing.Color.LightYellow
        Me.lbl_price.Location = New System.Drawing.Point(506, 500)
        Me.lbl_price.Name = "lbl_price"
        Me.lbl_price.Size = New System.Drawing.Size(89, 19)
        Me.lbl_price.TabIndex = 15
        Me.lbl_price.Text = "Price(RM)"
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.DeepPink
        Me.btn_insert.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.ForeColor = System.Drawing.Color.LightYellow
        Me.btn_insert.Location = New System.Drawing.Point(421, 557)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(129, 39)
        Me.btn_insert.TabIndex = 16
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'txt_picture
        '
        Me.txt_picture.Location = New System.Drawing.Point(12, 518)
        Me.txt_picture.Name = "txt_picture"
        Me.txt_picture.Size = New System.Drawing.Size(146, 22)
        Me.txt_picture.TabIndex = 18
        '
        'btn_picture
        '
        Me.btn_picture.BackColor = System.Drawing.Color.DeepPink
        Me.btn_picture.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_picture.ForeColor = System.Drawing.Color.LightYellow
        Me.btn_picture.Location = New System.Drawing.Point(12, 557)
        Me.btn_picture.Name = "btn_picture"
        Me.btn_picture.Size = New System.Drawing.Size(155, 39)
        Me.btn_picture.TabIndex = 19
        Me.btn_picture.Text = "SELECT"
        Me.btn_picture.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.SlateBlue
        Me.btn_exit.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.LightYellow
        Me.btn_exit.Location = New System.Drawing.Point(806, 557)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(123, 39)
        Me.btn_exit.TabIndex = 20
        Me.btn_exit.Text = "RETURN"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.Color.White
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(12, 352)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(146, 150)
        Me.pic_product.TabIndex = 17
        Me.pic_product.TabStop = False
        '
        'frm_insertproducts_a174863
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BackgroundImage = Global.prj_petfishstore_a174863.My.Resources.Resources.Night
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(941, 608)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_picture)
        Me.Controls.Add(Me.txt_picture)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.lbl_price)
        Me.Controls.Add(Me.lbl_quantity)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.lbl_size)
        Me.Controls.Add(Me.lbl_desc)
        Me.Controls.Add(Me.lbl_productname)
        Me.Controls.Add(Me.lbl_productid)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_size)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.txt_productname)
        Me.Controls.Add(Me.txt_productid)
        Me.Controls.Add(Me.grd_products)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_insertproducts_a174863"
        Me.Text = "frm_insertproducts_a174863"
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_products As DataGridView
    Friend WithEvents txt_productid As TextBox
    Friend WithEvents txt_productname As TextBox
    Friend WithEvents txt_desc As TextBox
    Friend WithEvents txt_size As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents lbl_productid As Label
    Friend WithEvents lbl_productname As Label
    Friend WithEvents lbl_desc As Label
    Friend WithEvents lbl_size As Label
    Friend WithEvents lbl_type As Label
    Friend WithEvents lbl_quantity As Label
    Friend WithEvents lbl_price As Label
    Friend WithEvents btn_insert As Button
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents txt_picture As TextBox
    Friend WithEvents btn_picture As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_exit As Button
End Class
