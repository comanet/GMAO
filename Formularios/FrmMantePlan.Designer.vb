<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantePlan
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
        Dim DESCRIPCIONLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim IDMANTEPLANLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantePlan))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsNew = New System.Windows.Forms.ToolStripButton()
        Me.tsEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsDel = New System.Windows.Forms.ToolStripButton()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnFiltro = New System.Windows.Forms.ToolStripButton()
        Me.TsbtnPrint = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_DESCRIPCION = New System.Windows.Forms.TextBox()
        Me.txt_NOMBRE = New System.Windows.Forms.TextBox()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.dgvmantep = New System.Windows.Forms.DataGridView()
        Me.IDPLAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btEquipos = New System.Windows.Forms.Button()
        Me.btnLimpiaDB = New System.Windows.Forms.Button()
        DESCRIPCIONLabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        IDMANTEPLANLabel = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvmantep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DESCRIPCIONLabel
        '
        DESCRIPCIONLabel.AutoSize = True
        DESCRIPCIONLabel.Location = New System.Drawing.Point(12, 103)
        DESCRIPCIONLabel.Name = "DESCRIPCIONLabel"
        DESCRIPCIONLabel.Size = New System.Drawing.Size(83, 13)
        DESCRIPCIONLabel.TabIndex = 28
        DESCRIPCIONLabel.Text = "DESCRIPCIÓN:"
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(12, 66)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(57, 13)
        NOMBRELabel.TabIndex = 26
        NOMBRELabel.Text = "NOMBRE:"
        '
        'IDMANTEPLANLabel
        '
        IDMANTEPLANLabel.AutoSize = True
        IDMANTEPLANLabel.Location = New System.Drawing.Point(12, 29)
        IDMANTEPLANLabel.Name = "IDMANTEPLANLabel"
        IDMANTEPLANLabel.Size = New System.Drawing.Size(49, 13)
        IDMANTEPLANLabel.TabIndex = 23
        IDMANTEPLANLabel.Text = "CODIGO"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsNew, Me.tsEdit, Me.tsDel, Me.tsSave, Me.ToolStripSeparator1, Me.tsbtnFiltro, Me.TsbtnPrint})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(633, 57)
        Me.ToolStrip1.TabIndex = 10
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_DESCRIPCION)
        Me.GroupBox1.Controls.Add(DESCRIPCIONLabel)
        Me.GroupBox1.Controls.Add(Me.txt_NOMBRE)
        Me.GroupBox1.Controls.Add(NOMBRELabel)
        Me.GroupBox1.Controls.Add(Me.txt_ID)
        Me.GroupBox1.Controls.Add(IDMANTEPLANLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(621, 214)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Planes de Mantenimiento"
        '
        'txt_DESCRIPCION
        '
        Me.txt_DESCRIPCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DESCRIPCION.Location = New System.Drawing.Point(107, 95)
        Me.txt_DESCRIPCION.MaxLength = 250
        Me.txt_DESCRIPCION.Multiline = True
        Me.txt_DESCRIPCION.Name = "txt_DESCRIPCION"
        Me.txt_DESCRIPCION.ReadOnly = True
        Me.txt_DESCRIPCION.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txt_DESCRIPCION.Size = New System.Drawing.Size(508, 94)
        Me.txt_DESCRIPCION.TabIndex = 29
        '
        'txt_NOMBRE
        '
        Me.txt_NOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NOMBRE.Location = New System.Drawing.Point(107, 58)
        Me.txt_NOMBRE.MaxLength = 250
        Me.txt_NOMBRE.Name = "txt_NOMBRE"
        Me.txt_NOMBRE.ReadOnly = True
        Me.txt_NOMBRE.Size = New System.Drawing.Size(508, 26)
        Me.txt_NOMBRE.TabIndex = 27
        '
        'txt_ID
        '
        Me.txt_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Location = New System.Drawing.Point(107, 21)
        Me.txt_ID.MaxLength = 15
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.ReadOnly = True
        Me.txt_ID.Size = New System.Drawing.Size(508, 26)
        Me.txt_ID.TabIndex = 24
        '
        'btSalir
        '
        Me.btSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSalir.BackColor = System.Drawing.Color.DimGray
        Me.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.ForeColor = System.Drawing.Color.White
        Me.btSalir.Location = New System.Drawing.Point(530, 456)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(91, 36)
        Me.btSalir.TabIndex = 13
        Me.btSalir.Text = "&Salir"
        Me.btSalir.UseVisualStyleBackColor = False
        '
        'dgvmantep
        '
        Me.dgvmantep.AllowUserToAddRows = False
        Me.dgvmantep.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Beige
        Me.dgvmantep.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvmantep.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvmantep.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvmantep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvmantep.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPLAN, Me.NOMBRE, Me.DESCRIPCION})
        Me.dgvmantep.Location = New System.Drawing.Point(0, 292)
        Me.dgvmantep.Name = "dgvmantep"
        Me.dgvmantep.ReadOnly = True
        Me.dgvmantep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvmantep.Size = New System.Drawing.Size(633, 147)
        Me.dgvmantep.TabIndex = 24
        '
        'IDPLAN
        '
        Me.IDPLAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IDPLAN.DataPropertyName = "IDPLAN"
        Me.IDPLAN.HeaderText = "IDPLAN"
        Me.IDPLAN.Name = "IDPLAN"
        Me.IDPLAN.ReadOnly = True
        Me.IDPLAN.Width = 71
        '
        'NOMBRE
        '
        Me.NOMBRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.NOMBRE.DataPropertyName = "NOMBRE"
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        Me.NOMBRE.Width = 79
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DESCRIPCION.DataPropertyName = "DESCRIPCION"
        Me.DESCRIPCION.HeaderText = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.ReadOnly = True
        '
        'btEquipos
        '
        Me.btEquipos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btEquipos.BackColor = System.Drawing.Color.DimGray
        Me.btEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEquipos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEquipos.ForeColor = System.Drawing.Color.White
        Me.btEquipos.Location = New System.Drawing.Point(433, 456)
        Me.btEquipos.Name = "btEquipos"
        Me.btEquipos.Size = New System.Drawing.Size(91, 36)
        Me.btEquipos.TabIndex = 25
        Me.btEquipos.Text = "&Relación de Equipos"
        Me.btEquipos.UseVisualStyleBackColor = False
        '
        'btnLimpiaDB
        '
        Me.btnLimpiaDB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiaDB.BackColor = System.Drawing.Color.DimGray
        Me.btnLimpiaDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiaDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiaDB.ForeColor = System.Drawing.Color.White
        Me.btnLimpiaDB.Location = New System.Drawing.Point(336, 456)
        Me.btnLimpiaDB.Name = "btnLimpiaDB"
        Me.btnLimpiaDB.Size = New System.Drawing.Size(91, 36)
        Me.btnLimpiaDB.TabIndex = 26
        Me.btnLimpiaDB.Text = "Formatea IDPLAN"
        Me.btnLimpiaDB.UseVisualStyleBackColor = False
        '
        'FrmMantePlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(633, 504)
        Me.Controls.Add(Me.btnLimpiaDB)
        Me.Controls.Add(Me.btEquipos)
        Me.Controls.Add(Me.dgvmantep)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "FrmMantePlan"
        Me.Text = "Planes de Mantenimiento"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvmantep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnFiltro As System.Windows.Forms.ToolStripButton
    Friend WithEvents TsbtnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_DESCRIPCION As System.Windows.Forms.TextBox
    Friend WithEvents txt_NOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents dgvmantep As System.Windows.Forms.DataGridView
    Friend WithEvents IDPLAN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btEquipos As System.Windows.Forms.Button
    Friend WithEvents btnLimpiaDB As System.Windows.Forms.Button
End Class
