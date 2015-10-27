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
        Dim LabelIDPLANTILLA As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantePlan))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsNew = New System.Windows.Forms.ToolStripButton()
        Me.tsEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsDel = New System.Windows.Forms.ToolStripButton()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnFiltro = New System.Windows.Forms.ToolStripButton()
        Me.TsbtnPrint = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_IDPLANTILLA = New System.Windows.Forms.TextBox()
        Me.txt_DESCRIPCION = New System.Windows.Forms.TextBox()
        Me.txt_NOMBRE = New System.Windows.Forms.TextBox()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_Notas = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvManteP = New System.Windows.Forms.DataGridView()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregardoc = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbDeldoc = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvEquipos = New System.Windows.Forms.DataGridView()
        Me.ToolStripIMG = New System.Windows.Forms.ToolStrip()
        Me.tsbagreImg = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbdelimg = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbverimg = New System.Windows.Forms.ToolStripButton()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.dgvActividades = New System.Windows.Forms.DataGridView()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        DESCRIPCIONLabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        IDMANTEPLANLabel = New System.Windows.Forms.Label()
        LabelIDPLANTILLA = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvManteP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripIMG.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
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
        IDMANTEPLANLabel.Size = New System.Drawing.Size(52, 13)
        IDMANTEPLANLabel.TabIndex = 23
        IDMANTEPLANLabel.Text = "CODIGO:"
        '
        'LabelIDPLANTILLA
        '
        LabelIDPLANTILLA.AutoSize = True
        LabelIDPLANTILLA.Location = New System.Drawing.Point(337, 29)
        LabelIDPLANTILLA.Name = "LabelIDPLANTILLA"
        LabelIDPLANTILLA.Size = New System.Drawing.Size(78, 13)
        LabelIDPLANTILLA.TabIndex = 30
        LabelIDPLANTILLA.Text = "IDPLANTILLA:"
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
        Me.GroupBox1.Controls.Add(Me.txt_IDPLANTILLA)
        Me.GroupBox1.Controls.Add(LabelIDPLANTILLA)
        Me.GroupBox1.Controls.Add(Me.txt_DESCRIPCION)
        Me.GroupBox1.Controls.Add(DESCRIPCIONLabel)
        Me.GroupBox1.Controls.Add(Me.txt_NOMBRE)
        Me.GroupBox1.Controls.Add(NOMBRELabel)
        Me.GroupBox1.Controls.Add(Me.txt_ID)
        Me.GroupBox1.Controls.Add(IDMANTEPLANLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(621, 201)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Planes de Mantenimiento"
        '
        'txt_IDPLANTILLA
        '
        Me.txt_IDPLANTILLA.Enabled = False
        Me.txt_IDPLANTILLA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IDPLANTILLA.Location = New System.Drawing.Point(432, 21)
        Me.txt_IDPLANTILLA.MaxLength = 15
        Me.txt_IDPLANTILLA.Name = "txt_IDPLANTILLA"
        Me.txt_IDPLANTILLA.ReadOnly = True
        Me.txt_IDPLANTILLA.Size = New System.Drawing.Size(183, 26)
        Me.txt_IDPLANTILLA.TabIndex = 31
        '
        'txt_DESCRIPCION
        '
        Me.txt_DESCRIPCION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
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
        Me.txt_NOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
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
        Me.txt_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Location = New System.Drawing.Point(107, 21)
        Me.txt_ID.MaxLength = 50
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.ReadOnly = True
        Me.txt_ID.Size = New System.Drawing.Size(183, 26)
        Me.txt_ID.TabIndex = 24
        '
        'btSalir
        '
        Me.btSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSalir.BackColor = System.Drawing.Color.DimGray
        Me.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.ForeColor = System.Drawing.Color.White
        Me.btSalir.Location = New System.Drawing.Point(530, 629)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(91, 36)
        Me.btSalir.TabIndex = 13
        Me.btSalir.Text = "&Salir"
        Me.btSalir.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(12, 264)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(609, 359)
        Me.TabControl1.TabIndex = 29
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_Notas)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(601, 302)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Notas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_Notas
        '
        Me.txt_Notas.AcceptsReturn = True
        Me.txt_Notas.AcceptsTab = True
        Me.txt_Notas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Notas.Location = New System.Drawing.Point(3, 3)
        Me.txt_Notas.Multiline = True
        Me.txt_Notas.Name = "txt_Notas"
        Me.txt_Notas.ReadOnly = True
        Me.txt_Notas.Size = New System.Drawing.Size(592, 293)
        Me.txt_Notas.TabIndex = 13
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvManteP)
        Me.TabPage2.Controls.Add(Me.ToolStrip2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(601, 302)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Plantillas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvManteP
        '
        Me.dgvManteP.AllowUserToAddRows = False
        Me.dgvManteP.AllowUserToDeleteRows = False
        Me.dgvManteP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvManteP.BackgroundColor = System.Drawing.Color.White
        Me.dgvManteP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvManteP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvManteP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvManteP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvManteP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvManteP.Cursor = System.Windows.Forms.Cursors.IBeam
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvManteP.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgvManteP.EnableHeadersVisualStyles = False
        Me.dgvManteP.GridColor = System.Drawing.Color.White
        Me.dgvManteP.Location = New System.Drawing.Point(3, 31)
        Me.dgvManteP.MultiSelect = False
        Me.dgvManteP.Name = "dgvManteP"
        Me.dgvManteP.ReadOnly = True
        Me.dgvManteP.RowHeadersVisible = False
        Me.dgvManteP.RowHeadersWidth = 40
        Me.dgvManteP.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvManteP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvManteP.Size = New System.Drawing.Size(592, 265)
        Me.dgvManteP.TabIndex = 2
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.White
        Me.ToolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregardoc, Me.ToolStripSeparator3, Me.tsbDeldoc, Me.ToolStripSeparator2, Me.ToolStripButton2})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.Size = New System.Drawing.Size(595, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbAgregardoc
        '
        Me.tsbAgregardoc.AutoSize = False
        Me.tsbAgregardoc.BackColor = System.Drawing.Color.DimGray
        Me.tsbAgregardoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbAgregardoc.ForeColor = System.Drawing.Color.White
        Me.tsbAgregardoc.Image = CType(resources.GetObject("tsbAgregardoc.Image"), System.Drawing.Image)
        Me.tsbAgregardoc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgregardoc.Name = "tsbAgregardoc"
        Me.tsbAgregardoc.Size = New System.Drawing.Size(53, 22)
        Me.tsbAgregardoc.Text = "Agregar"
        Me.tsbAgregardoc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tsbDeldoc
        '
        Me.tsbDeldoc.AutoSize = False
        Me.tsbDeldoc.BackColor = System.Drawing.Color.DimGray
        Me.tsbDeldoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbDeldoc.Enabled = False
        Me.tsbDeldoc.ForeColor = System.Drawing.Color.White
        Me.tsbDeldoc.Image = CType(resources.GetObject("tsbDeldoc.Image"), System.Drawing.Image)
        Me.tsbDeldoc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDeldoc.Name = "tsbDeldoc"
        Me.tsbDeldoc.Size = New System.Drawing.Size(53, 22)
        Me.tsbDeldoc.Text = "Eliminar"
        Me.tsbDeldoc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoSize = False
        Me.ToolStripButton2.BackColor = System.Drawing.Color.DimGray
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripButton2.Text = "Ver"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgvEquipos)
        Me.TabPage3.Controls.Add(Me.ToolStripIMG)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(601, 302)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Equipos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgvEquipos
        '
        Me.dgvEquipos.AllowUserToAddRows = False
        Me.dgvEquipos.AllowUserToDeleteRows = False
        Me.dgvEquipos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEquipos.BackgroundColor = System.Drawing.Color.White
        Me.dgvEquipos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEquipos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvEquipos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEquipos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEquipos.Cursor = System.Windows.Forms.Cursors.IBeam
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEquipos.DefaultCellStyle = DataGridViewCellStyle16
        Me.dgvEquipos.EnableHeadersVisualStyles = False
        Me.dgvEquipos.GridColor = System.Drawing.Color.White
        Me.dgvEquipos.Location = New System.Drawing.Point(3, 28)
        Me.dgvEquipos.MultiSelect = False
        Me.dgvEquipos.Name = "dgvEquipos"
        Me.dgvEquipos.ReadOnly = True
        Me.dgvEquipos.RowHeadersVisible = False
        Me.dgvEquipos.RowHeadersWidth = 40
        Me.dgvEquipos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEquipos.Size = New System.Drawing.Size(595, 271)
        Me.dgvEquipos.TabIndex = 3
        '
        'ToolStripIMG
        '
        Me.ToolStripIMG.BackColor = System.Drawing.Color.White
        Me.ToolStripIMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStripIMG.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbagreImg, Me.ToolStripSeparator4, Me.tsbdelimg, Me.ToolStripSeparator5, Me.tsbverimg})
        Me.ToolStripIMG.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripIMG.Name = "ToolStripIMG"
        Me.ToolStripIMG.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStripIMG.Size = New System.Drawing.Size(601, 25)
        Me.ToolStripIMG.TabIndex = 2
        Me.ToolStripIMG.Text = "ToolStrip3"
        '
        'tsbagreImg
        '
        Me.tsbagreImg.AutoSize = False
        Me.tsbagreImg.BackColor = System.Drawing.Color.DimGray
        Me.tsbagreImg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbagreImg.ForeColor = System.Drawing.Color.White
        Me.tsbagreImg.Image = CType(resources.GetObject("tsbagreImg.Image"), System.Drawing.Image)
        Me.tsbagreImg.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbagreImg.Name = "tsbagreImg"
        Me.tsbagreImg.Size = New System.Drawing.Size(53, 22)
        Me.tsbagreImg.Text = "Agregar"
        Me.tsbagreImg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tsbdelimg
        '
        Me.tsbdelimg.AutoSize = False
        Me.tsbdelimg.BackColor = System.Drawing.Color.DimGray
        Me.tsbdelimg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbdelimg.Enabled = False
        Me.tsbdelimg.ForeColor = System.Drawing.Color.White
        Me.tsbdelimg.Image = CType(resources.GetObject("tsbdelimg.Image"), System.Drawing.Image)
        Me.tsbdelimg.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbdelimg.Name = "tsbdelimg"
        Me.tsbdelimg.Size = New System.Drawing.Size(53, 22)
        Me.tsbdelimg.Text = "Eliminar"
        Me.tsbdelimg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tsbverimg
        '
        Me.tsbverimg.AutoSize = False
        Me.tsbverimg.BackColor = System.Drawing.Color.DimGray
        Me.tsbverimg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbverimg.ForeColor = System.Drawing.Color.White
        Me.tsbverimg.Image = CType(resources.GetObject("tsbverimg.Image"), System.Drawing.Image)
        Me.tsbverimg.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbverimg.Name = "tsbverimg"
        Me.tsbverimg.Size = New System.Drawing.Size(53, 22)
        Me.tsbverimg.Text = "Ver"
        Me.tsbverimg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.dgvActividades)
        Me.TabPage4.Controls.Add(Me.ToolStrip3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(601, 333)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Tareas"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'dgvActividades
        '
        Me.dgvActividades.AllowUserToAddRows = False
        Me.dgvActividades.AllowUserToDeleteRows = False
        Me.dgvActividades.BackgroundColor = System.Drawing.Color.White
        Me.dgvActividades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvActividades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvActividades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvActividades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActividades.Cursor = System.Windows.Forms.Cursors.IBeam
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvActividades.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvActividades.EnableHeadersVisualStyles = false
        Me.dgvActividades.GridColor = System.Drawing.Color.White
        Me.dgvActividades.Location = New System.Drawing.Point(3, 28)
        Me.dgvActividades.MultiSelect = false
        Me.dgvActividades.Name = "dgvActividades"
        Me.dgvActividades.ReadOnly = true
        Me.dgvActividades.RowHeadersVisible = false
        Me.dgvActividades.RowHeadersWidth = 40
        Me.dgvActividades.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActividades.Size = New System.Drawing.Size(400, 119)
        Me.dgvActividades.TabIndex = 3
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.White
        Me.ToolStrip3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator6, Me.ToolStripButton3, Me.ToolStripSeparator7, Me.ToolStripButton4})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(601, 25)
        Me.ToolStrip3.TabIndex = 2
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = false
        Me.ToolStripButton1.BackColor = System.Drawing.Color.DimGray
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"),System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripButton1.Text = "Agregar"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.AutoSize = false
        Me.ToolStripButton3.BackColor = System.Drawing.Color.DimGray
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Enabled = false
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"),System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripButton3.Text = "Eliminar"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.AutoSize = false
        Me.ToolStripButton4.BackColor = System.Drawing.Color.DimGray
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"),System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripButton4.Text = "Ver"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'FrmMantePlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(633, 677)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = true
        Me.Name = "FrmMantePlan"
        Me.Text = "Planes de Mantenimiento"
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.TabControl1.ResumeLayout(false)
        Me.TabPage1.ResumeLayout(false)
        Me.TabPage1.PerformLayout
        Me.TabPage2.ResumeLayout(false)
        Me.TabPage2.PerformLayout
        CType(Me.dgvManteP,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip2.ResumeLayout(false)
        Me.ToolStrip2.PerformLayout
        Me.TabPage3.ResumeLayout(false)
        Me.TabPage3.PerformLayout
        CType(Me.dgvEquipos,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStripIMG.ResumeLayout(false)
        Me.ToolStripIMG.PerformLayout
        Me.TabPage4.ResumeLayout(false)
        Me.TabPage4.PerformLayout
        CType(Me.dgvActividades,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip3.ResumeLayout(false)
        Me.ToolStrip3.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

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
    Friend WithEvents txt_IDPLANTILLA As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txt_Notas As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgvManteP As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregardoc As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbDeldoc As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents dgvEquipos As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripIMG As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbagreImg As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbdelimg As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbverimg As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents dgvActividades As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
End Class
