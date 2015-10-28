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
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.TabEquipos = New System.Windows.Forms.TabPage()
        Me.dgvEquipos = New System.Windows.Forms.DataGridView()
        Me.ToolStripIMG = New System.Windows.Forms.ToolStrip()
        Me.tsbAgreImg = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbDelImg = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbVerImg = New System.Windows.Forms.ToolStripButton()
        Me.TabTareas = New System.Windows.Forms.TabPage()
        Me.dgvActividades = New System.Windows.Forms.DataGridView()
        Me.tsbAgreTar = New System.Windows.Forms.ToolStrip()
        Me.tsbAgrTar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbDelTar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbVerTar = New System.Windows.Forms.ToolStripButton()
        Me.TabPlantillas = New System.Windows.Forms.TabPage()
        Me.dgvManteP = New System.Windows.Forms.DataGridView()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregardoc = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbDeldoc = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbVerdoc = New System.Windows.Forms.ToolStripButton()
        Me.TabNotas = New System.Windows.Forms.TabPage()
        Me.txt_Notas = New System.Windows.Forms.TextBox()
        DESCRIPCIONLabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        IDMANTEPLANLabel = New System.Windows.Forms.Label()
        LabelIDPLANTILLA = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabEquipos.SuspendLayout()
        CType(Me.dgvEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripIMG.SuspendLayout()
        Me.TabTareas.SuspendLayout()
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsbAgreTar.SuspendLayout()
        Me.TabPlantillas.SuspendLayout()
        CType(Me.dgvManteP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.TabNotas.SuspendLayout()
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
        LabelIDPLANTILLA.Location = New System.Drawing.Point(423, 29)
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
        Me.txt_IDPLANTILLA.Location = New System.Drawing.Point(516, 21)
        Me.txt_IDPLANTILLA.MaxLength = 15
        Me.txt_IDPLANTILLA.Name = "txt_IDPLANTILLA"
        Me.txt_IDPLANTILLA.ReadOnly = True
        Me.txt_IDPLANTILLA.Size = New System.Drawing.Size(99, 26)
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
        Me.txt_ID.Size = New System.Drawing.Size(300, 26)
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
        Me.TabControl1.Controls.Add(Me.TabEquipos)
        Me.TabControl1.Controls.Add(Me.TabTareas)
        Me.TabControl1.Controls.Add(Me.TabPlantillas)
        Me.TabControl1.Controls.Add(Me.TabNotas)
        Me.TabControl1.Location = New System.Drawing.Point(12, 264)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(609, 359)
        Me.TabControl1.TabIndex = 29
        '
        'TabEquipos
        '
        Me.TabEquipos.Controls.Add(Me.dgvEquipos)
        Me.TabEquipos.Controls.Add(Me.ToolStripIMG)
        Me.TabEquipos.Location = New System.Drawing.Point(4, 22)
        Me.TabEquipos.Name = "TabEquipos"
        Me.TabEquipos.Size = New System.Drawing.Size(601, 333)
        Me.TabEquipos.TabIndex = 2
        Me.TabEquipos.Text = "Equipos"
        Me.TabEquipos.UseVisualStyleBackColor = True
        '
        'dgvEquipos
        '
        Me.dgvEquipos.AllowUserToAddRows = False
        Me.dgvEquipos.AllowUserToDeleteRows = False
        Me.dgvEquipos.BackgroundColor = System.Drawing.Color.White
        Me.dgvEquipos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEquipos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvEquipos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEquipos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEquipos.Cursor = System.Windows.Forms.Cursors.IBeam
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEquipos.DefaultCellStyle = DataGridViewCellStyle20
        Me.dgvEquipos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEquipos.EnableHeadersVisualStyles = False
        Me.dgvEquipos.GridColor = System.Drawing.Color.White
        Me.dgvEquipos.Location = New System.Drawing.Point(0, 25)
        Me.dgvEquipos.MultiSelect = False
        Me.dgvEquipos.Name = "dgvEquipos"
        Me.dgvEquipos.ReadOnly = True
        Me.dgvEquipos.RowHeadersVisible = False
        Me.dgvEquipos.RowHeadersWidth = 40
        Me.dgvEquipos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEquipos.Size = New System.Drawing.Size(601, 308)
        Me.dgvEquipos.TabIndex = 3
        '
        'ToolStripIMG
        '
        Me.ToolStripIMG.BackColor = System.Drawing.Color.White
        Me.ToolStripIMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStripIMG.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgreImg, Me.ToolStripSeparator4, Me.tsbDelImg, Me.ToolStripSeparator5, Me.tsbVerImg})
        Me.ToolStripIMG.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripIMG.Name = "ToolStripIMG"
        Me.ToolStripIMG.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStripIMG.Size = New System.Drawing.Size(601, 25)
        Me.ToolStripIMG.TabIndex = 2
        Me.ToolStripIMG.Text = "ToolStrip3"
        '
        'tsbAgreImg
        '
        Me.tsbAgreImg.AutoSize = False
        Me.tsbAgreImg.BackColor = System.Drawing.Color.DimGray
        Me.tsbAgreImg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbAgreImg.ForeColor = System.Drawing.Color.White
        Me.tsbAgreImg.Image = CType(resources.GetObject("tsbAgreImg.Image"), System.Drawing.Image)
        Me.tsbAgreImg.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgreImg.Name = "tsbAgreImg"
        Me.tsbAgreImg.Size = New System.Drawing.Size(53, 22)
        Me.tsbAgreImg.Text = "Agregar"
        Me.tsbAgreImg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tsbDelImg
        '
        Me.tsbDelImg.AutoSize = False
        Me.tsbDelImg.BackColor = System.Drawing.Color.DimGray
        Me.tsbDelImg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbDelImg.Enabled = False
        Me.tsbDelImg.ForeColor = System.Drawing.Color.White
        Me.tsbDelImg.Image = CType(resources.GetObject("tsbDelImg.Image"), System.Drawing.Image)
        Me.tsbDelImg.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDelImg.Name = "tsbDelImg"
        Me.tsbDelImg.Size = New System.Drawing.Size(53, 22)
        Me.tsbDelImg.Text = "Eliminar"
        Me.tsbDelImg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'tsbVerImg
        '
        Me.tsbVerImg.AutoSize = False
        Me.tsbVerImg.BackColor = System.Drawing.Color.DimGray
        Me.tsbVerImg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbVerImg.ForeColor = System.Drawing.Color.White
        Me.tsbVerImg.Image = CType(resources.GetObject("tsbVerImg.Image"), System.Drawing.Image)
        Me.tsbVerImg.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbVerImg.Name = "tsbVerImg"
        Me.tsbVerImg.Size = New System.Drawing.Size(53, 22)
        Me.tsbVerImg.Text = "Ver"
        Me.tsbVerImg.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'TabTareas
        '
        Me.TabTareas.Controls.Add(Me.dgvActividades)
        Me.TabTareas.Controls.Add(Me.tsbAgreTar)
        Me.TabTareas.Location = New System.Drawing.Point(4, 22)
        Me.TabTareas.Name = "TabTareas"
        Me.TabTareas.Size = New System.Drawing.Size(601, 333)
        Me.TabTareas.TabIndex = 3
        Me.TabTareas.Text = "Tareas"
        Me.TabTareas.UseVisualStyleBackColor = True
        '
        'dgvActividades
        '
        Me.dgvActividades.AllowUserToAddRows = False
        Me.dgvActividades.AllowUserToDeleteRows = False
        Me.dgvActividades.BackgroundColor = System.Drawing.Color.White
        Me.dgvActividades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvActividades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvActividades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvActividades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActividades.Cursor = System.Windows.Forms.Cursors.IBeam
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvActividades.DefaultCellStyle = DataGridViewCellStyle22
        Me.dgvActividades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvActividades.EnableHeadersVisualStyles = False
        Me.dgvActividades.GridColor = System.Drawing.Color.White
        Me.dgvActividades.Location = New System.Drawing.Point(0, 25)
        Me.dgvActividades.MultiSelect = False
        Me.dgvActividades.Name = "dgvActividades"
        Me.dgvActividades.ReadOnly = True
        Me.dgvActividades.RowHeadersVisible = False
        Me.dgvActividades.RowHeadersWidth = 40
        Me.dgvActividades.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActividades.Size = New System.Drawing.Size(601, 308)
        Me.dgvActividades.TabIndex = 3
        '
        'tsbAgreTar
        '
        Me.tsbAgreTar.BackColor = System.Drawing.Color.White
        Me.tsbAgreTar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tsbAgreTar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgrTar, Me.ToolStripSeparator6, Me.tsbDelTar, Me.ToolStripSeparator7, Me.tsbVerTar})
        Me.tsbAgreTar.Location = New System.Drawing.Point(0, 0)
        Me.tsbAgreTar.Name = "tsbAgreTar"
        Me.tsbAgreTar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tsbAgreTar.Size = New System.Drawing.Size(601, 25)
        Me.tsbAgreTar.TabIndex = 2
        Me.tsbAgreTar.Text = "ToolStrip3"
        '
        'tsbAgrTar
        '
        Me.tsbAgrTar.AutoSize = False
        Me.tsbAgrTar.BackColor = System.Drawing.Color.DimGray
        Me.tsbAgrTar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbAgrTar.ForeColor = System.Drawing.Color.White
        Me.tsbAgrTar.Image = CType(resources.GetObject("tsbAgrTar.Image"), System.Drawing.Image)
        Me.tsbAgrTar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAgrTar.Name = "tsbAgrTar"
        Me.tsbAgrTar.Size = New System.Drawing.Size(53, 22)
        Me.tsbAgrTar.Text = "Agregar"
        Me.tsbAgrTar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tsbDelTar
        '
        Me.tsbDelTar.AutoSize = False
        Me.tsbDelTar.BackColor = System.Drawing.Color.DimGray
        Me.tsbDelTar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbDelTar.Enabled = False
        Me.tsbDelTar.ForeColor = System.Drawing.Color.White
        Me.tsbDelTar.Image = CType(resources.GetObject("tsbDelTar.Image"), System.Drawing.Image)
        Me.tsbDelTar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDelTar.Name = "tsbDelTar"
        Me.tsbDelTar.Size = New System.Drawing.Size(53, 22)
        Me.tsbDelTar.Text = "Eliminar"
        Me.tsbDelTar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'tsbVerTar
        '
        Me.tsbVerTar.AutoSize = False
        Me.tsbVerTar.BackColor = System.Drawing.Color.DimGray
        Me.tsbVerTar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbVerTar.ForeColor = System.Drawing.Color.White
        Me.tsbVerTar.Image = CType(resources.GetObject("tsbVerTar.Image"), System.Drawing.Image)
        Me.tsbVerTar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbVerTar.Name = "tsbVerTar"
        Me.tsbVerTar.Size = New System.Drawing.Size(53, 22)
        Me.tsbVerTar.Text = "Ver"
        Me.tsbVerTar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'TabPlantillas
        '
        Me.TabPlantillas.Controls.Add(Me.dgvManteP)
        Me.TabPlantillas.Controls.Add(Me.ToolStrip2)
        Me.TabPlantillas.Location = New System.Drawing.Point(4, 22)
        Me.TabPlantillas.Name = "TabPlantillas"
        Me.TabPlantillas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPlantillas.Size = New System.Drawing.Size(601, 333)
        Me.TabPlantillas.TabIndex = 1
        Me.TabPlantillas.Text = "Plantillas"
        Me.TabPlantillas.UseVisualStyleBackColor = True
        '
        'dgvManteP
        '
        Me.dgvManteP.AllowUserToAddRows = False
        Me.dgvManteP.AllowUserToDeleteRows = False
        Me.dgvManteP.BackgroundColor = System.Drawing.Color.White
        Me.dgvManteP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvManteP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvManteP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvManteP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.dgvManteP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvManteP.Cursor = System.Windows.Forms.Cursors.IBeam
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvManteP.DefaultCellStyle = DataGridViewCellStyle24
        Me.dgvManteP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvManteP.EnableHeadersVisualStyles = False
        Me.dgvManteP.GridColor = System.Drawing.Color.White
        Me.dgvManteP.Location = New System.Drawing.Point(3, 28)
        Me.dgvManteP.MultiSelect = False
        Me.dgvManteP.Name = "dgvManteP"
        Me.dgvManteP.ReadOnly = True
        Me.dgvManteP.RowHeadersVisible = False
        Me.dgvManteP.RowHeadersWidth = 40
        Me.dgvManteP.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvManteP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvManteP.Size = New System.Drawing.Size(595, 302)
        Me.dgvManteP.TabIndex = 2
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.White
        Me.ToolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregardoc, Me.ToolStripSeparator3, Me.tsbDeldoc, Me.ToolStripSeparator2, Me.tsbVerdoc})
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
        'tsbVerdoc
        '
        Me.tsbVerdoc.AutoSize = False
        Me.tsbVerdoc.BackColor = System.Drawing.Color.DimGray
        Me.tsbVerdoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbVerdoc.ForeColor = System.Drawing.Color.White
        Me.tsbVerdoc.Image = CType(resources.GetObject("tsbVerdoc.Image"), System.Drawing.Image)
        Me.tsbVerdoc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbVerdoc.Name = "tsbVerdoc"
        Me.tsbVerdoc.Size = New System.Drawing.Size(53, 22)
        Me.tsbVerdoc.Text = "Ver"
        Me.tsbVerdoc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'TabNotas
        '
        Me.TabNotas.Controls.Add(Me.txt_Notas)
        Me.TabNotas.Location = New System.Drawing.Point(4, 22)
        Me.TabNotas.Name = "TabNotas"
        Me.TabNotas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabNotas.Size = New System.Drawing.Size(601, 333)
        Me.TabNotas.TabIndex = 0
        Me.TabNotas.Text = "Notas"
        Me.TabNotas.UseVisualStyleBackColor = True
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
        'FrmMantePlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(633, 677)
        Me.Controls.Add(Me.TabControl1)
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
        Me.TabControl1.ResumeLayout(False)
        Me.TabEquipos.ResumeLayout(False)
        Me.TabEquipos.PerformLayout()
        CType(Me.dgvEquipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripIMG.ResumeLayout(False)
        Me.ToolStripIMG.PerformLayout()
        Me.TabTareas.ResumeLayout(False)
        Me.TabTareas.PerformLayout()
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsbAgreTar.ResumeLayout(False)
        Me.tsbAgreTar.PerformLayout()
        Me.TabPlantillas.ResumeLayout(False)
        Me.TabPlantillas.PerformLayout()
        CType(Me.dgvManteP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.TabNotas.ResumeLayout(False)
        Me.TabNotas.PerformLayout()
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
    Friend WithEvents txt_IDPLANTILLA As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabNotas As System.Windows.Forms.TabPage
    Friend WithEvents txt_Notas As System.Windows.Forms.TextBox
    Friend WithEvents TabPlantillas As System.Windows.Forms.TabPage
    Friend WithEvents dgvManteP As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregardoc As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbDeldoc As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbVerdoc As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabEquipos As System.Windows.Forms.TabPage
    Friend WithEvents dgvEquipos As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripIMG As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgreImg As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbDelImg As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbVerImg As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabTareas As System.Windows.Forms.TabPage
    Friend WithEvents dgvActividades As System.Windows.Forms.DataGridView
    Friend WithEvents tsbAgreTar As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgrTar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbDelTar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbVerTar As System.Windows.Forms.ToolStripButton
End Class
