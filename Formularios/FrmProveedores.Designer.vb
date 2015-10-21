<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProveedores
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProveedores))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txt_Email = New System.Windows.Forms.TextBox()
        Me.lblWeb = New System.Windows.Forms.Label()
        Me.txt_web = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txt_Telefono = New System.Windows.Forms.TextBox()
        Me.lblEspecialidad = New System.Windows.Forms.Label()
        Me.cbEspecialidad = New System.Windows.Forms.ComboBox()
        Me.lblCP = New System.Windows.Forms.Label()
        Me.txt_CP = New System.Windows.Forms.TextBox()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.cbPais = New System.Windows.Forms.ComboBox()
        Me.lblProvincia = New System.Windows.Forms.Label()
        Me.cbProvincia = New System.Windows.Forms.ComboBox()
        Me.lblPoblacion = New System.Windows.Forms.Label()
        Me.txt_Poblacion = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbDireccion = New System.Windows.Forms.Label()
        Me.txt_Direccion = New System.Windows.Forms.TextBox()
        Me.dgvProv = New System.Windows.Forms.DataGridView()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsDel = New System.Windows.Forms.ToolStripButton()
        Me.tsNew = New System.Windows.Forms.ToolStripButton()
        Me.tsEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnFiltro = New System.Windows.Forms.ToolStripButton()
        Me.TsbtnPrint = New System.Windows.Forms.ToolStripButton()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.txt_Email)
        Me.Panel1.Controls.Add(Me.lblWeb)
        Me.Panel1.Controls.Add(Me.txt_web)
        Me.Panel1.Controls.Add(Me.lblTelefono)
        Me.Panel1.Controls.Add(Me.txt_Telefono)
        Me.Panel1.Controls.Add(Me.lblEspecialidad)
        Me.Panel1.Controls.Add(Me.cbEspecialidad)
        Me.Panel1.Controls.Add(Me.lblCP)
        Me.Panel1.Controls.Add(Me.txt_CP)
        Me.Panel1.Controls.Add(Me.lblPais)
        Me.Panel1.Controls.Add(Me.cbPais)
        Me.Panel1.Controls.Add(Me.lblProvincia)
        Me.Panel1.Controls.Add(Me.cbProvincia)
        Me.Panel1.Controls.Add(Me.lblPoblacion)
        Me.Panel1.Controls.Add(Me.txt_Poblacion)
        Me.Panel1.Controls.Add(Me.txt_Nombre)
        Me.Panel1.Controls.Add(Me.lbNombre)
        Me.Panel1.Controls.Add(Me.lbDireccion)
        Me.Panel1.Controls.Add(Me.txt_Direccion)
        Me.Panel1.Location = New System.Drawing.Point(0, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(902, 146)
        Me.Panel1.TabIndex = 2
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(454, 109)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(52, 20)
        Me.lblEmail.TabIndex = 21
        Me.lblEmail.Text = "Email:"
        '
        'txt_Email
        '
        Me.txt_Email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txt_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Email.Location = New System.Drawing.Point(575, 109)
        Me.txt_Email.MaxLength = 100
        Me.txt_Email.Name = "txt_Email"
        Me.txt_Email.ReadOnly = True
        Me.txt_Email.Size = New System.Drawing.Size(315, 26)
        Me.txt_Email.TabIndex = 9
        '
        'lblWeb
        '
        Me.lblWeb.AutoSize = True
        Me.lblWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeb.Location = New System.Drawing.Point(454, 77)
        Me.lblWeb.Name = "lblWeb"
        Me.lblWeb.Size = New System.Drawing.Size(112, 20)
        Me.lblWeb.TabIndex = 19
        Me.lblWeb.Text = "Dirección web:"
        '
        'txt_web
        '
        Me.txt_web.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txt_web.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_web.Location = New System.Drawing.Point(575, 74)
        Me.txt_web.MaxLength = 100
        Me.txt_web.Name = "txt_web"
        Me.txt_web.ReadOnly = True
        Me.txt_web.Size = New System.Drawing.Size(315, 26)
        Me.txt_web.TabIndex = 8
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(669, 13)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(75, 20)
        Me.lblTelefono.TabIndex = 17
        Me.lblTelefono.Text = "Teléfono:"
        '
        'txt_Telefono
        '
        Me.txt_Telefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Telefono.Location = New System.Drawing.Point(754, 10)
        Me.txt_Telefono.MaxLength = 10
        Me.txt_Telefono.Name = "txt_Telefono"
        Me.txt_Telefono.ReadOnly = True
        Me.txt_Telefono.Size = New System.Drawing.Size(136, 26)
        Me.txt_Telefono.TabIndex = 6
        '
        'lblEspecialidad
        '
        Me.lblEspecialidad.AutoSize = True
        Me.lblEspecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspecialidad.Location = New System.Drawing.Point(454, 45)
        Me.lblEspecialidad.Name = "lblEspecialidad"
        Me.lblEspecialidad.Size = New System.Drawing.Size(103, 20)
        Me.lblEspecialidad.TabIndex = 14
        Me.lblEspecialidad.Text = "Especialidad:"
        '
        'cbEspecialidad
        '
        Me.cbEspecialidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbEspecialidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEspecialidad.Enabled = False
        Me.cbEspecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEspecialidad.FormattingEnabled = True
        Me.cbEspecialidad.Location = New System.Drawing.Point(575, 40)
        Me.cbEspecialidad.MaxLength = 50
        Me.cbEspecialidad.Name = "cbEspecialidad"
        Me.cbEspecialidad.Size = New System.Drawing.Size(315, 28)
        Me.cbEspecialidad.TabIndex = 7
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCP.Location = New System.Drawing.Point(454, 13)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(72, 20)
        Me.lblCP.TabIndex = 11
        Me.lblCP.Text = "C.Postal:"
        '
        'txt_CP
        '
        Me.txt_CP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_CP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CP.Location = New System.Drawing.Point(575, 10)
        Me.txt_CP.MaxLength = 5
        Me.txt_CP.Name = "txt_CP"
        Me.txt_CP.ReadOnly = True
        Me.txt_CP.Size = New System.Drawing.Size(69, 26)
        Me.txt_CP.TabIndex = 5
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPais.Location = New System.Drawing.Point(234, 112)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(43, 20)
        Me.lblPais.TabIndex = 10
        Me.lblPais.Text = "País:"
        '
        'cbPais
        '
        Me.cbPais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbPais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPais.Enabled = False
        Me.cbPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPais.FormattingEnabled = True
        Me.cbPais.Location = New System.Drawing.Point(283, 109)
        Me.cbPais.MaxLength = 50
        Me.cbPais.Name = "cbPais"
        Me.cbPais.Size = New System.Drawing.Size(152, 28)
        Me.cbPais.TabIndex = 4
        '
        'lblProvincia
        '
        Me.lblProvincia.AutoSize = True
        Me.lblProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProvincia.Location = New System.Drawing.Point(3, 112)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(76, 20)
        Me.lblProvincia.TabIndex = 8
        Me.lblProvincia.Text = "Provincia:"
        '
        'cbProvincia
        '
        Me.cbProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProvincia.Enabled = False
        Me.cbProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProvincia.FormattingEnabled = True
        Me.cbProvincia.Location = New System.Drawing.Point(92, 109)
        Me.cbProvincia.MaxLength = 50
        Me.cbProvincia.Name = "cbProvincia"
        Me.cbProvincia.Size = New System.Drawing.Size(136, 28)
        Me.cbProvincia.TabIndex = 3
        '
        'lblPoblacion
        '
        Me.lblPoblacion.AutoSize = True
        Me.lblPoblacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoblacion.Location = New System.Drawing.Point(3, 77)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(82, 20)
        Me.lblPoblacion.TabIndex = 5
        Me.lblPoblacion.Text = "Población:"
        '
        'txt_Poblacion
        '
        Me.txt_Poblacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Poblacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Poblacion.Location = New System.Drawing.Point(92, 74)
        Me.txt_Poblacion.MaxLength = 50
        Me.txt_Poblacion.Name = "txt_Poblacion"
        Me.txt_Poblacion.ReadOnly = True
        Me.txt_Poblacion.Size = New System.Drawing.Size(343, 26)
        Me.txt_Poblacion.TabIndex = 2
        '
        'txt_Nombre
        '
        Me.txt_Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nombre.Location = New System.Drawing.Point(92, 10)
        Me.txt_Nombre.MaxLength = 50
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.ReadOnly = True
        Me.txt_Nombre.Size = New System.Drawing.Size(343, 26)
        Me.txt_Nombre.TabIndex = 0
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.Location = New System.Drawing.Point(3, 13)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(69, 20)
        Me.lbNombre.TabIndex = 4
        Me.lbNombre.Text = "Nombre:"
        '
        'lbDireccion
        '
        Me.lbDireccion.AutoSize = True
        Me.lbDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDireccion.Location = New System.Drawing.Point(3, 45)
        Me.lbDireccion.Name = "lbDireccion"
        Me.lbDireccion.Size = New System.Drawing.Size(79, 20)
        Me.lbDireccion.TabIndex = 3
        Me.lbDireccion.Text = "Dirección:"
        '
        'txt_Direccion
        '
        Me.txt_Direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Direccion.Location = New System.Drawing.Point(92, 42)
        Me.txt_Direccion.MaxLength = 100
        Me.txt_Direccion.Name = "txt_Direccion"
        Me.txt_Direccion.ReadOnly = True
        Me.txt_Direccion.Size = New System.Drawing.Size(343, 26)
        Me.txt_Direccion.TabIndex = 1
        '
        'dgvProv
        '
        Me.dgvProv.AllowUserToAddRows = False
        Me.dgvProv.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray
        Me.dgvProv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvProv.Location = New System.Drawing.Point(0, 212)
        Me.dgvProv.Name = "dgvProv"
        Me.dgvProv.ReadOnly = True
        Me.dgvProv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProv.Size = New System.Drawing.Size(902, 171)
        Me.dgvProv.TabIndex = 3
        '
        'btSalir
        '
        Me.btSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSalir.BackColor = System.Drawing.Color.DimGray
        Me.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.ForeColor = System.Drawing.Color.White
        Me.btSalir.Location = New System.Drawing.Point(799, 389)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(91, 36)
        Me.btSalir.TabIndex = 3
        Me.btSalir.Text = "&Salir"
        Me.btSalir.UseVisualStyleBackColor = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsDel, Me.tsNew, Me.tsEdit, Me.tsSave, Me.ToolStripSeparator1, Me.tsbtnFiltro, Me.TsbtnPrint})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(902, 57)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 57)
        '
        'tsbtnFiltro
        '
        Me.tsbtnFiltro.AutoSize = False
        Me.tsbtnFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnFiltro.Image = CType(resources.GetObject("tsbtnFiltro.Image"), System.Drawing.Image)
        Me.tsbtnFiltro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnFiltro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnFiltro.Name = "tsbtnFiltro"
        Me.tsbtnFiltro.Size = New System.Drawing.Size(53, 45)
        Me.tsbtnFiltro.Text = "Filtro"
        '
        'TsbtnPrint
        '
        Me.TsbtnPrint.AutoSize = False
        Me.TsbtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbtnPrint.Image = CType(resources.GetObject("TsbtnPrint.Image"), System.Drawing.Image)
        Me.TsbtnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TsbtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbtnPrint.Name = "TsbtnPrint"
        Me.TsbtnPrint.Size = New System.Drawing.Size(53, 54)
        Me.TsbtnPrint.Text = "Imprimir"
        '
        'txt_ID
        '
        Me.txt_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Location = New System.Drawing.Point(-200, 393)
        Me.txt_ID.MaxLength = 50
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.ReadOnly = True
        Me.txt_ID.Size = New System.Drawing.Size(111, 26)
        Me.txt_ID.TabIndex = 4
        '
        'FrmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(902, 432)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.dgvProv)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmProveedores"
        Me.Text = "FrmProveedores"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbNombre As System.Windows.Forms.Label
    Friend WithEvents lbDireccion As System.Windows.Forms.Label
    Friend WithEvents txt_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents dgvProv As System.Windows.Forms.DataGridView
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents lblEspecialidad As System.Windows.Forms.Label
    Friend WithEvents cbEspecialidad As System.Windows.Forms.ComboBox
    Friend WithEvents lblCP As System.Windows.Forms.Label
    Friend WithEvents txt_CP As System.Windows.Forms.TextBox
    Friend WithEvents lblPais As System.Windows.Forms.Label
    Friend WithEvents cbPais As System.Windows.Forms.ComboBox
    Friend WithEvents lblProvincia As System.Windows.Forms.Label
    Friend WithEvents cbProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents lblPoblacion As System.Windows.Forms.Label
    Friend WithEvents txt_Poblacion As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txt_Telefono As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txt_Email As System.Windows.Forms.TextBox
    Friend WithEvents lblWeb As System.Windows.Forms.Label
    Friend WithEvents txt_web As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnFiltro As System.Windows.Forms.ToolStripButton
    Friend WithEvents TsbtnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
End Class
