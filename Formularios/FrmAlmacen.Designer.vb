<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlmacen
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAlmacen))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_Des = New System.Windows.Forms.TextBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbDes = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.txt_Ubi = New System.Windows.Forms.TextBox()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.dgvAlma = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.tsDel = New System.Windows.Forms.ToolStripButton()
        Me.tsEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvAlma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsNew, Me.tsEdit, Me.tsDel, Me.tsSave})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(532, 48)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt_Des)
        Me.Panel1.Controls.Add(Me.lbNombre)
        Me.Panel1.Controls.Add(Me.lbDes)
        Me.Panel1.Controls.Add(Me.lbID)
        Me.Panel1.Controls.Add(Me.txt_Ubi)
        Me.Panel1.Controls.Add(Me.txt_ID)
        Me.Panel1.Location = New System.Drawing.Point(0, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(521, 163)
        Me.Panel1.TabIndex = 17
        '
        'txt_Des
        '
        Me.txt_Des.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Des.Location = New System.Drawing.Point(105, 47)
        Me.txt_Des.MaxLength = 50
        Me.txt_Des.Name = "txt_Des"
        Me.txt_Des.ReadOnly = True
        Me.txt_Des.Size = New System.Drawing.Size(416, 26)
        Me.txt_Des.TabIndex = 2
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.Location = New System.Drawing.Point(3, 50)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(69, 20)
        Me.lbNombre.TabIndex = 4
        Me.lbNombre.Text = "Nombre:"
        '
        'lbDes
        '
        Me.lbDes.AutoSize = True
        Me.lbDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDes.Location = New System.Drawing.Point(3, 87)
        Me.lbDes.Name = "lbDes"
        Me.lbDes.Size = New System.Drawing.Size(87, 20)
        Me.lbDes.TabIndex = 3
        Me.lbDes.Text = "Ubicación :"
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(3, 15)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(59, 20)
        Me.lbID.TabIndex = 2
        Me.lbID.Text = "Codigo"
        '
        'txt_Ubi
        '
        Me.txt_Ubi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Ubi.Location = New System.Drawing.Point(105, 84)
        Me.txt_Ubi.MaxLength = 50
        Me.txt_Ubi.Multiline = True
        Me.txt_Ubi.Name = "txt_Ubi"
        Me.txt_Ubi.ReadOnly = True
        Me.txt_Ubi.Size = New System.Drawing.Size(416, 62)
        Me.txt_Ubi.TabIndex = 3
        '
        'txt_ID
        '
        Me.txt_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Location = New System.Drawing.Point(105, 12)
        Me.txt_ID.MaxLength = 4
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.ReadOnly = True
        Me.txt_ID.Size = New System.Drawing.Size(101, 26)
        Me.txt_ID.TabIndex = 1
        '
        'dgvAlma
        '
        Me.dgvAlma.AllowUserToAddRows = False
        Me.dgvAlma.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray
        Me.dgvAlma.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAlma.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAlma.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvAlma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAlma.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.NOMBRE, Me.DESCRIPCION})
        Me.dgvAlma.Location = New System.Drawing.Point(1, 220)
        Me.dgvAlma.Name = "dgvAlma"
        Me.dgvAlma.ReadOnly = True
        Me.dgvAlma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlma.Size = New System.Drawing.Size(531, 214)
        Me.dgvAlma.TabIndex = 4
        '
        'ID
        '
        Me.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ID.DataPropertyName = "IDALMACEN"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 43
        '
        'NOMBRE
        '
        Me.NOMBRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOMBRE.DataPropertyName = "DESCRIPCION"
        Me.NOMBRE.HeaderText = "DESCRIPCION"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        Me.NOMBRE.Width = 105
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DESCRIPCION.DataPropertyName = "UBICACION"
        Me.DESCRIPCION.HeaderText = "UBICACION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.ReadOnly = True
        '
        'btSalir
        '
        Me.btSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSalir.BackColor = System.Drawing.Color.DimGray
        Me.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.ForeColor = System.Drawing.Color.White
        Me.btSalir.Location = New System.Drawing.Point(430, 440)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(91, 36)
        Me.btSalir.TabIndex = 5
        Me.btSalir.Text = "&Salir"
        Me.btSalir.UseVisualStyleBackColor = False
        '
        'tsSave
        '
        Me.tsSave.AutoSize = False
        Me.tsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsSave.Enabled = False
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(53, 45)
        Me.tsSave.Text = "Aplicar"
        '
        'tsDel
        '
        Me.tsDel.AutoSize = False
        Me.tsDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsDel.Image = CType(resources.GetObject("tsDel.Image"), System.Drawing.Image)
        Me.tsDel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDel.Name = "tsDel"
        Me.tsDel.Size = New System.Drawing.Size(53, 45)
        Me.tsDel.Text = "Eliminar"
        '
        'tsEdit
        '
        Me.tsEdit.AutoSize = False
        Me.tsEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsEdit.Image = CType(resources.GetObject("tsEdit.Image"), System.Drawing.Image)
        Me.tsEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEdit.Name = "tsEdit"
        Me.tsEdit.Size = New System.Drawing.Size(53, 45)
        Me.tsEdit.Text = "Editar Registros"
        '
        'tsNew
        '
        Me.tsNew.AutoSize = False
        Me.tsNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsNew.Image = CType(resources.GetObject("tsNew.Image"), System.Drawing.Image)
        Me.tsNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsNew.Name = "tsNew"
        Me.tsNew.Size = New System.Drawing.Size(53, 45)
        Me.tsNew.Text = "Nuevo"
        Me.tsNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsNew.ToolTipText = "Nuevo"
        '
        'FrmAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 483)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.dgvAlma)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(548, 521)
        Me.Name = "FrmAlmacen"
        Me.Text = "Mantenimiento Almacén"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvAlma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_Des As System.Windows.Forms.TextBox
    Friend WithEvents lbNombre As System.Windows.Forms.Label
    Friend WithEvents lbDes As System.Windows.Forms.Label
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents txt_Ubi As System.Windows.Forms.TextBox
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents dgvAlma As System.Windows.Forms.DataGridView
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tsNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
End Class