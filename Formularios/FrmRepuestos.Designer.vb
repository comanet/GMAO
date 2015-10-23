<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRepuestos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRepuestos))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsNew = New System.Windows.Forms.ToolStripButton()
        Me.tsEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsDel = New System.Windows.Forms.ToolStripButton()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbmar = New System.Windows.Forms.Label()
        Me.txt_Marc = New System.Windows.Forms.TextBox()
        Me.txt_Mod = New System.Windows.Forms.TextBox()
        Me.lbmodel = New System.Windows.Forms.Label()
        Me.txt_Nom = New System.Windows.Forms.TextBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbNotas = New System.Windows.Forms.Label()
        Me.lbRef = New System.Windows.Forms.Label()
        Me.txt_Notas = New System.Windows.Forms.TextBox()
        Me.txt_REF = New System.Windows.Forms.TextBox()
        Me.dgvRepuesto = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_StcMin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Precio = New System.Windows.Forms.TextBox()
        Me.txt_StcMax = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbUM = New System.Windows.Forms.ComboBox()
        Me.txt_Prov = New System.Windows.Forms.TextBox()
        Me.lbum = New System.Windows.Forms.Label()
        Me.LBPRO = New System.Windows.Forms.Label()
        Me.cbProveedores = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsNew, Me.tsEdit, Me.tsDel, Me.tsSave})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(854, 48)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbmar)
        Me.Panel1.Controls.Add(Me.txt_Marc)
        Me.Panel1.Controls.Add(Me.txt_Mod)
        Me.Panel1.Controls.Add(Me.lbmodel)
        Me.Panel1.Controls.Add(Me.txt_Nom)
        Me.Panel1.Controls.Add(Me.lbNombre)
        Me.Panel1.Controls.Add(Me.lbNotas)
        Me.Panel1.Controls.Add(Me.lbRef)
        Me.Panel1.Controls.Add(Me.txt_Notas)
        Me.Panel1.Controls.Add(Me.txt_REF)
        Me.Panel1.Location = New System.Drawing.Point(0, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(521, 163)
        Me.Panel1.TabIndex = 0
        '
        'lbmar
        '
        Me.lbmar.AutoSize = True
        Me.lbmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbmar.Location = New System.Drawing.Point(369, 15)
        Me.lbmar.Name = "lbmar"
        Me.lbmar.Size = New System.Drawing.Size(48, 20)
        Me.lbmar.TabIndex = 8
        Me.lbmar.Text = "Marc."
        '
        'txt_Marc
        '
        Me.txt_Marc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Marc.Location = New System.Drawing.Point(417, 12)
        Me.txt_Marc.MaxLength = 8
        Me.txt_Marc.Name = "txt_Marc"
        Me.txt_Marc.ReadOnly = True
        Me.txt_Marc.Size = New System.Drawing.Size(101, 26)
        Me.txt_Marc.TabIndex = 3
        '
        'txt_Mod
        '
        Me.txt_Mod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Mod.Location = New System.Drawing.Point(262, 12)
        Me.txt_Mod.MaxLength = 10
        Me.txt_Mod.Name = "txt_Mod"
        Me.txt_Mod.ReadOnly = True
        Me.txt_Mod.Size = New System.Drawing.Size(101, 26)
        Me.txt_Mod.TabIndex = 2
        '
        'lbmodel
        '
        Me.lbmodel.AutoSize = True
        Me.lbmodel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbmodel.Location = New System.Drawing.Point(212, 15)
        Me.lbmodel.Name = "lbmodel"
        Me.lbmodel.Size = New System.Drawing.Size(44, 20)
        Me.lbmodel.TabIndex = 5
        Me.lbmodel.Text = "Mod."
        '
        'txt_Nom
        '
        Me.txt_Nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nom.Location = New System.Drawing.Point(105, 47)
        Me.txt_Nom.MaxLength = 50
        Me.txt_Nom.Name = "txt_Nom"
        Me.txt_Nom.ReadOnly = True
        Me.txt_Nom.Size = New System.Drawing.Size(416, 26)
        Me.txt_Nom.TabIndex = 4
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
        'lbNotas
        '
        Me.lbNotas.AutoSize = True
        Me.lbNotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNotas.Location = New System.Drawing.Point(3, 87)
        Me.lbNotas.Name = "lbNotas"
        Me.lbNotas.Size = New System.Drawing.Size(51, 20)
        Me.lbNotas.TabIndex = 3
        Me.lbNotas.Text = "Notas"
        '
        'lbRef
        '
        Me.lbRef.AutoSize = True
        Me.lbRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbRef.Location = New System.Drawing.Point(3, 15)
        Me.lbRef.Name = "lbRef"
        Me.lbRef.Size = New System.Drawing.Size(91, 20)
        Me.lbRef.TabIndex = 2
        Me.lbRef.Text = "Referencia:"
        '
        'txt_Notas
        '
        Me.txt_Notas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Notas.Location = New System.Drawing.Point(105, 84)
        Me.txt_Notas.MaxLength = 200
        Me.txt_Notas.Multiline = True
        Me.txt_Notas.Name = "txt_Notas"
        Me.txt_Notas.ReadOnly = True
        Me.txt_Notas.Size = New System.Drawing.Size(416, 62)
        Me.txt_Notas.TabIndex = 5
        '
        'txt_REF
        '
        Me.txt_REF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_REF.Location = New System.Drawing.Point(105, 12)
        Me.txt_REF.MaxLength = 10
        Me.txt_REF.Name = "txt_REF"
        Me.txt_REF.ReadOnly = True
        Me.txt_REF.Size = New System.Drawing.Size(101, 26)
        Me.txt_REF.TabIndex = 1
        '
        'dgvRepuesto
        '
        Me.dgvRepuesto.AllowUserToAddRows = False
        Me.dgvRepuesto.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray
        Me.dgvRepuesto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRepuesto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRepuesto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvRepuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRepuesto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.DESCRIPCION, Me.NOMBRE})
        Me.dgvRepuesto.Location = New System.Drawing.Point(1, 220)
        Me.dgvRepuesto.Name = "dgvRepuesto"
        Me.dgvRepuesto.ReadOnly = True
        Me.dgvRepuesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRepuesto.Size = New System.Drawing.Size(853, 207)
        Me.dgvRepuesto.TabIndex = 12
        '
        'ID
        '
        Me.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ID.DataPropertyName = "REFERENCIA"
        Me.ID.HeaderText = "REFERENCIA"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DESCRIPCION.DataPropertyName = "MODELO"
        Me.DESCRIPCION.HeaderText = "MODELO"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.ReadOnly = True
        Me.DESCRIPCION.Width = 78
        '
        'NOMBRE
        '
        Me.NOMBRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NOMBRE.DataPropertyName = "NOMBRE"
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        '
        'btSalir
        '
        Me.btSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSalir.BackColor = System.Drawing.Color.DimGray
        Me.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.ForeColor = System.Drawing.Color.White
        Me.btSalir.Location = New System.Drawing.Point(742, 433)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(91, 36)
        Me.btSalir.TabIndex = 13
        Me.btSalir.Text = "&Salir"
        Me.btSalir.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbProveedores)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txt_StcMin)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txt_Precio)
        Me.Panel2.Controls.Add(Me.txt_StcMax)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cbUM)
        Me.Panel2.Controls.Add(Me.lbum)
        Me.Panel2.Controls.Add(Me.LBPRO)
        Me.Panel2.Location = New System.Drawing.Point(527, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(327, 163)
        Me.Panel2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Precio M"
        '
        'txt_StcMin
        '
        Me.txt_StcMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_StcMin.Location = New System.Drawing.Point(263, 87)
        Me.txt_StcMin.MaxLength = 4
        Me.txt_StcMin.Name = "txt_StcMin"
        Me.txt_StcMin.ReadOnly = True
        Me.txt_StcMin.Size = New System.Drawing.Size(53, 26)
        Me.txt_StcMin.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(178, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Stock Min"
        '
        'txt_Precio
        '
        Me.txt_Precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Precio.Location = New System.Drawing.Point(108, 120)
        Me.txt_Precio.MaxLength = 10
        Me.txt_Precio.Name = "txt_Precio"
        Me.txt_Precio.ReadOnly = True
        Me.txt_Precio.Size = New System.Drawing.Size(101, 26)
        Me.txt_Precio.TabIndex = 11
        '
        'txt_StcMax
        '
        Me.txt_StcMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_StcMax.Location = New System.Drawing.Point(108, 87)
        Me.txt_StcMax.MaxLength = 4
        Me.txt_StcMax.Name = "txt_StcMax"
        Me.txt_StcMax.ReadOnly = True
        Me.txt_StcMax.Size = New System.Drawing.Size(53, 26)
        Me.txt_StcMax.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Stock Max"
        '
        'cbUM
        '
        Me.cbUM.Enabled = False
        Me.cbUM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUM.FormattingEnabled = True
        Me.cbUM.Items.AddRange(New Object() {"UNIDADES", "METROS", "LITROS", "KG", ""})
        Me.cbUM.Location = New System.Drawing.Point(108, 42)
        Me.cbUM.Name = "cbUM"
        Me.cbUM.Size = New System.Drawing.Size(108, 28)
        Me.cbUM.TabIndex = 8
        '
        'txt_Prov
        '
        Me.txt_Prov.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Prov.Location = New System.Drawing.Point(515, 443)
        Me.txt_Prov.MaxLength = 50
        Me.txt_Prov.Name = "txt_Prov"
        Me.txt_Prov.ReadOnly = True
        Me.txt_Prov.Size = New System.Drawing.Size(211, 26)
        Me.txt_Prov.TabIndex = 7
        '
        'lbum
        '
        Me.lbum.AutoSize = True
        Me.lbum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbum.Location = New System.Drawing.Point(14, 50)
        Me.lbum.Name = "lbum"
        Me.lbum.Size = New System.Drawing.Size(81, 20)
        Me.lbum.TabIndex = 10
        Me.lbum.Text = "Unidad M."
        '
        'LBPRO
        '
        Me.LBPRO.AutoSize = True
        Me.LBPRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBPRO.Location = New System.Drawing.Point(14, 15)
        Me.LBPRO.Name = "LBPRO"
        Me.LBPRO.Size = New System.Drawing.Size(85, 20)
        Me.LBPRO.TabIndex = 9
        Me.LBPRO.Text = "Proveedor:"
        '
        'cbProveedores
        '
        Me.cbProveedores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbProveedores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedores.Enabled = False
        Me.cbProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedores.FormattingEnabled = True
        Me.cbProveedores.Location = New System.Drawing.Point(108, 8)
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.Size = New System.Drawing.Size(208, 28)
        Me.cbProveedores.TabIndex = 18
        '
        'FrmRepuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(854, 476)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.dgvRepuesto)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txt_Prov)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(870, 514)
        Me.Name = "FrmRepuestos"
        Me.Text = "Mantenimiento Repuestos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_Nom As System.Windows.Forms.TextBox
    Friend WithEvents lbNombre As System.Windows.Forms.Label
    Friend WithEvents lbNotas As System.Windows.Forms.Label
    Friend WithEvents lbRef As System.Windows.Forms.Label
    Friend WithEvents txt_Notas As System.Windows.Forms.TextBox
    Friend WithEvents txt_REF As System.Windows.Forms.TextBox
    Friend WithEvents dgvRepuesto As System.Windows.Forms.DataGridView
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents lbmar As System.Windows.Forms.Label
    Friend WithEvents txt_Marc As System.Windows.Forms.TextBox
    Friend WithEvents txt_Mod As System.Windows.Forms.TextBox
    Friend WithEvents lbmodel As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_Prov As System.Windows.Forms.TextBox
    Friend WithEvents lbum As System.Windows.Forms.Label
    Friend WithEvents LBPRO As System.Windows.Forms.Label
    Friend WithEvents cbUM As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_StcMin As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Precio As System.Windows.Forms.TextBox
    Friend WithEvents txt_StcMax As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbProveedores As System.Windows.Forms.ComboBox
End Class
