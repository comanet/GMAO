<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEquipos
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
        Dim Label1 As System.Windows.Forms.Label
        Dim TIPOEQUIPOLabel As System.Windows.Forms.Label
        Dim IDESTADOLabel As System.Windows.Forms.Label
        Dim FCOMPRALabel As System.Windows.Forms.Label
        Dim PROVEEDORLabel As System.Windows.Forms.Label
        Dim SECCIONLabel As System.Windows.Forms.Label
        Dim NSERIELabel As System.Windows.Forms.Label
        Dim MODELOLabel As System.Windows.Forms.Label
        Dim MARCALabel As System.Windows.Forms.Label
        Dim IDEQUIPOLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim DESCRIPCIONLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEquipos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBEstado = New System.Windows.Forms.ComboBox()
        Me.cbseccion = New System.Windows.Forms.ComboBox()
        Me.CBtipoEquipo = New System.Windows.Forms.ComboBox()
        Me.dtFGarantia = New System.Windows.Forms.DateTimePicker()
        Me.dtFcompra = New System.Windows.Forms.DateTimePicker()
        Me.txt_Pro = New System.Windows.Forms.TextBox()
        Me.txt_Nserie = New System.Windows.Forms.TextBox()
        Me.txt_Mod = New System.Windows.Forms.TextBox()
        Me.txt_Marca = New System.Windows.Forms.TextBox()
        Me.txtDescrip = New System.Windows.Forms.TextBox()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsDel = New System.Windows.Forms.ToolStripButton()
        Me.tsNew = New System.Windows.Forms.ToolStripButton()
        Me.tsEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnFiltro = New System.Windows.Forms.ToolStripButton()
        Me.TsbtnPrint = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_Notas = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvDoc = New System.Windows.Forms.DataGridView()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbAgregardoc = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbDeldoc = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvimages = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripIMG = New System.Windows.Forms.ToolStrip()
        Me.tsbagreImg = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbdelimg = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbverimg = New System.Windows.Forms.ToolStripButton()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Label1 = New System.Windows.Forms.Label()
        TIPOEQUIPOLabel = New System.Windows.Forms.Label()
        IDESTADOLabel = New System.Windows.Forms.Label()
        FCOMPRALabel = New System.Windows.Forms.Label()
        PROVEEDORLabel = New System.Windows.Forms.Label()
        SECCIONLabel = New System.Windows.Forms.Label()
        NSERIELabel = New System.Windows.Forms.Label()
        MODELOLabel = New System.Windows.Forms.Label()
        MARCALabel = New System.Windows.Forms.Label()
        IDEQUIPOLabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        DESCRIPCIONLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvimages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStripIMG.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(765, 114)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(75, 13)
        Label1.TabIndex = 28
        Label1.Text = "FIN GARANT."
        '
        'TIPOEQUIPOLabel
        '
        TIPOEQUIPOLabel.AutoSize = True
        TIPOEQUIPOLabel.Location = New System.Drawing.Point(262, 20)
        TIPOEQUIPOLabel.Name = "TIPOEQUIPOLabel"
        TIPOEQUIPOLabel.Size = New System.Drawing.Size(79, 13)
        TIPOEQUIPOLabel.TabIndex = 22
        TIPOEQUIPOLabel.Text = "TIPO EQUIPO:"
        '
        'IDESTADOLabel
        '
        IDESTADOLabel.AutoSize = True
        IDESTADOLabel.Location = New System.Drawing.Point(528, 22)
        IDESTADOLabel.Name = "IDESTADOLabel"
        IDESTADOLabel.Size = New System.Drawing.Size(54, 13)
        IDESTADOLabel.TabIndex = 20
        IDESTADOLabel.Text = "ESTADO:"
        '
        'FCOMPRALabel
        '
        FCOMPRALabel.AutoSize = True
        FCOMPRALabel.Location = New System.Drawing.Point(528, 112)
        FCOMPRALabel.Name = "FCOMPRALabel"
        FCOMPRALabel.Size = New System.Drawing.Size(65, 13)
        FCOMPRALabel.TabIndex = 16
        FCOMPRALabel.Text = "F.COMPRA:"
        '
        'PROVEEDORLabel
        '
        PROVEEDORLabel.AutoSize = True
        PROVEEDORLabel.Location = New System.Drawing.Point(11, 109)
        PROVEEDORLabel.Name = "PROVEEDORLabel"
        PROVEEDORLabel.Size = New System.Drawing.Size(78, 13)
        PROVEEDORLabel.TabIndex = 14
        PROVEEDORLabel.Text = "PROVEEDOR:"
        '
        'SECCIONLabel
        '
        SECCIONLabel.AutoSize = True
        SECCIONLabel.Location = New System.Drawing.Point(528, 80)
        SECCIONLabel.Name = "SECCIONLabel"
        SECCIONLabel.Size = New System.Drawing.Size(57, 13)
        SECCIONLabel.TabIndex = 12
        SECCIONLabel.Text = "SECCION:"
        '
        'NSERIELabel
        '
        NSERIELabel.AutoSize = True
        NSERIELabel.Location = New System.Drawing.Point(765, 83)
        NSERIELabel.Name = "NSERIELabel"
        NSERIELabel.Size = New System.Drawing.Size(50, 13)
        NSERIELabel.TabIndex = 10
        NSERIELabel.Text = "NSERIE:"
        '
        'MODELOLabel
        '
        MODELOLabel.AutoSize = True
        MODELOLabel.Location = New System.Drawing.Point(262, 80)
        MODELOLabel.Name = "MODELOLabel"
        MODELOLabel.Size = New System.Drawing.Size(56, 13)
        MODELOLabel.TabIndex = 8
        MODELOLabel.Text = "MODELO:"
        '
        'MARCALabel
        '
        MARCALabel.AutoSize = True
        MARCALabel.Location = New System.Drawing.Point(11, 80)
        MARCALabel.Name = "MARCALabel"
        MARCALabel.Size = New System.Drawing.Size(48, 13)
        MARCALabel.TabIndex = 6
        MARCALabel.Text = "MARCA:"
        '
        'IDEQUIPOLabel
        '
        IDEQUIPOLabel.AutoSize = True
        IDEQUIPOLabel.Location = New System.Drawing.Point(11, 22)
        IDEQUIPOLabel.Name = "IDEQUIPOLabel"
        IDEQUIPOLabel.Size = New System.Drawing.Size(62, 13)
        IDEQUIPOLabel.TabIndex = 0
        IDEQUIPOLabel.Text = "IDEQUIPO:"
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(11, 53)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(57, 13)
        NOMBRELabel.TabIndex = 2
        NOMBRELabel.Text = "NOMBRE:"
        '
        'DESCRIPCIONLabel
        '
        DESCRIPCIONLabel.AutoSize = True
        DESCRIPCIONLabel.Location = New System.Drawing.Point(528, 49)
        DESCRIPCIONLabel.Name = "DESCRIPCIONLabel"
        DESCRIPCIONLabel.Size = New System.Drawing.Size(83, 13)
        DESCRIPCIONLabel.TabIndex = 4
        DESCRIPCIONLabel.Text = "DESCRIPCION:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBEstado)
        Me.GroupBox1.Controls.Add(Me.cbseccion)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.CBtipoEquipo)
        Me.GroupBox1.Controls.Add(Me.dtFGarantia)
        Me.GroupBox1.Controls.Add(Me.dtFcompra)
        Me.GroupBox1.Controls.Add(TIPOEQUIPOLabel)
        Me.GroupBox1.Controls.Add(IDESTADOLabel)
        Me.GroupBox1.Controls.Add(FCOMPRALabel)
        Me.GroupBox1.Controls.Add(PROVEEDORLabel)
        Me.GroupBox1.Controls.Add(Me.txt_Pro)
        Me.GroupBox1.Controls.Add(SECCIONLabel)
        Me.GroupBox1.Controls.Add(NSERIELabel)
        Me.GroupBox1.Controls.Add(Me.txt_Nserie)
        Me.GroupBox1.Controls.Add(MODELOLabel)
        Me.GroupBox1.Controls.Add(Me.txt_Mod)
        Me.GroupBox1.Controls.Add(MARCALabel)
        Me.GroupBox1.Controls.Add(Me.txt_Marca)
        Me.GroupBox1.Controls.Add(Me.txtDescrip)
        Me.GroupBox1.Controls.Add(Me.txt_ID)
        Me.GroupBox1.Controls.Add(IDEQUIPOLabel)
        Me.GroupBox1.Controls.Add(NOMBRELabel)
        Me.GroupBox1.Controls.Add(DESCRIPCIONLabel)
        Me.GroupBox1.Controls.Add(Me.txt_Nombre)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(4, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(989, 164)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Catálogos - Equipos"
        '
        'CBEstado
        '
        Me.CBEstado.Enabled = False
        Me.CBEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBEstado.FormattingEnabled = True
        Me.CBEstado.Items.AddRange(New Object() {"EN SERVICIO", "FUERA DE SERVICIO", "BAJA"})
        Me.CBEstado.Location = New System.Drawing.Point(617, 12)
        Me.CBEstado.Name = "CBEstado"
        Me.CBEstado.Size = New System.Drawing.Size(232, 28)
        Me.CBEstado.TabIndex = 7
        '
        'cbseccion
        '
        Me.cbseccion.Enabled = False
        Me.cbseccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbseccion.FormattingEnabled = True
        Me.cbseccion.Location = New System.Drawing.Point(617, 75)
        Me.cbseccion.Name = "cbseccion"
        Me.cbseccion.Size = New System.Drawing.Size(142, 28)
        Me.cbseccion.TabIndex = 9
        '
        'CBtipoEquipo
        '
        Me.CBtipoEquipo.Enabled = False
        Me.CBtipoEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBtipoEquipo.FormattingEnabled = True
        Me.CBtipoEquipo.Location = New System.Drawing.Point(344, 14)
        Me.CBtipoEquipo.Name = "CBtipoEquipo"
        Me.CBtipoEquipo.Size = New System.Drawing.Size(177, 28)
        Me.CBtipoEquipo.TabIndex = 2
        '
        'dtFGarantia
        '
        Me.dtFGarantia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtFGarantia.Enabled = False
        Me.dtFGarantia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFGarantia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFGarantia.Location = New System.Drawing.Point(845, 107)
        Me.dtFGarantia.Name = "dtFGarantia"
        Me.dtFGarantia.Size = New System.Drawing.Size(135, 26)
        Me.dtFGarantia.TabIndex = 12
        '
        'dtFcompra
        '
        Me.dtFcompra.Enabled = False
        Me.dtFcompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFcompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFcompra.Location = New System.Drawing.Point(617, 109)
        Me.dtFcompra.Name = "dtFcompra"
        Me.dtFcompra.Size = New System.Drawing.Size(142, 26)
        Me.dtFcompra.TabIndex = 11
        '
        'txt_Pro
        '
        Me.txt_Pro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Pro.Location = New System.Drawing.Point(100, 106)
        Me.txt_Pro.MaxLength = 50
        Me.txt_Pro.Name = "txt_Pro"
        Me.txt_Pro.ReadOnly = True
        Me.txt_Pro.Size = New System.Drawing.Size(421, 26)
        Me.txt_Pro.TabIndex = 6
        '
        'txt_Nserie
        '
        Me.txt_Nserie.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nserie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nserie.Location = New System.Drawing.Point(845, 75)
        Me.txt_Nserie.MaxLength = 10
        Me.txt_Nserie.Name = "txt_Nserie"
        Me.txt_Nserie.ReadOnly = True
        Me.txt_Nserie.Size = New System.Drawing.Size(135, 26)
        Me.txt_Nserie.TabIndex = 10
        '
        'txt_Mod
        '
        Me.txt_Mod.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Mod.Location = New System.Drawing.Point(344, 75)
        Me.txt_Mod.MaxLength = 25
        Me.txt_Mod.Name = "txt_Mod"
        Me.txt_Mod.ReadOnly = True
        Me.txt_Mod.Size = New System.Drawing.Size(177, 26)
        Me.txt_Mod.TabIndex = 5
        '
        'txt_Marca
        '
        Me.txt_Marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Marca.Location = New System.Drawing.Point(100, 74)
        Me.txt_Marca.MaxLength = 25
        Me.txt_Marca.Name = "txt_Marca"
        Me.txt_Marca.ReadOnly = True
        Me.txt_Marca.Size = New System.Drawing.Size(152, 26)
        Me.txt_Marca.TabIndex = 4
        '
        'txtDescrip
        '
        Me.txtDescrip.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrip.Location = New System.Drawing.Point(617, 46)
        Me.txtDescrip.MaxLength = 50
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.ReadOnly = True
        Me.txtDescrip.Size = New System.Drawing.Size(363, 26)
        Me.txtDescrip.TabIndex = 8
        '
        'txt_ID
        '
        Me.txt_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Location = New System.Drawing.Point(100, 16)
        Me.txt_ID.MaxLength = 8
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.ReadOnly = True
        Me.txt_ID.Size = New System.Drawing.Size(100, 26)
        Me.txt_ID.TabIndex = 1
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nombre.Location = New System.Drawing.Point(100, 46)
        Me.txt_Nombre.MaxLength = 50
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.ReadOnly = True
        Me.txt_Nombre.Size = New System.Drawing.Size(421, 26)
        Me.txt_Nombre.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsDel, Me.tsNew, Me.tsEdit, Me.tsSave, Me.ToolStripSeparator1, Me.tsbtnFiltro, Me.TsbtnPrint})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1003, 57)
        Me.ToolStrip1.TabIndex = 8
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
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(4, 230)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(987, 176)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_Notas)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(979, 150)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Notas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_Notas
        '
        Me.txt_Notas.AcceptsReturn = True
        Me.txt_Notas.AcceptsTab = True
        Me.txt_Notas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Notas.Location = New System.Drawing.Point(3, 3)
        Me.txt_Notas.Multiline = True
        Me.txt_Notas.Name = "txt_Notas"
        Me.txt_Notas.ReadOnly = True
        Me.txt_Notas.Size = New System.Drawing.Size(973, 144)
        Me.txt_Notas.TabIndex = 13
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvDoc)
        Me.TabPage2.Controls.Add(Me.ToolStrip2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(979, 150)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Documentos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvDoc
        '
        Me.dgvDoc.BackgroundColor = System.Drawing.Color.White
        Me.dgvDoc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvDoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDoc.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOMBRE, Me.TIPO})
        Me.dgvDoc.Cursor = System.Windows.Forms.Cursors.IBeam
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDoc.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDoc.EnableHeadersVisualStyles = False
        Me.dgvDoc.GridColor = System.Drawing.Color.White
        Me.dgvDoc.Location = New System.Drawing.Point(10, 31)
        Me.dgvDoc.MultiSelect = False
        Me.dgvDoc.Name = "dgvDoc"
        Me.dgvDoc.ReadOnly = True
        Me.dgvDoc.RowHeadersVisible = False
        Me.dgvDoc.RowHeadersWidth = 40
        Me.dgvDoc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDoc.Size = New System.Drawing.Size(963, 102)
        Me.dgvDoc.TabIndex = 2
        '
        'NOMBRE
        '
        Me.NOMBRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NOMBRE.DataPropertyName = "NOMBRE"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.NOMBRE.DefaultCellStyle = DataGridViewCellStyle2
        Me.NOMBRE.HeaderText = "NOMBRE DEL ARCHIVO"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        '
        'TIPO
        '
        Me.TIPO.DataPropertyName = "TIPO"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TIPO.DefaultCellStyle = DataGridViewCellStyle3
        Me.TIPO.HeaderText = "TIPO DOC"
        Me.TIPO.Name = "TIPO"
        Me.TIPO.ReadOnly = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.White
        Me.ToolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbAgregardoc, Me.ToolStripSeparator3, Me.tsbDeldoc, Me.ToolStripSeparator2, Me.ToolStripButton2})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.Size = New System.Drawing.Size(973, 25)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbAgregardoc
        '
        Me.tsbAgregardoc.AutoSize = False
        Me.tsbAgregardoc.BackColor = System.Drawing.Color.DimGray
        Me.tsbAgregardoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbAgregardoc.Enabled = False
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
        Me.TabPage3.Controls.Add(Me.dgvimages)
        Me.TabPage3.Controls.Add(Me.ToolStripIMG)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(979, 150)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Imagenes"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgvimages
        '
        Me.dgvimages.AllowUserToDeleteRows = False
        Me.dgvimages.BackgroundColor = System.Drawing.Color.White
        Me.dgvimages.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvimages.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvimages.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvimages.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvimages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvimages.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgvimages.Cursor = System.Windows.Forms.Cursors.IBeam
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvimages.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvimages.EnableHeadersVisualStyles = False
        Me.dgvimages.GridColor = System.Drawing.Color.White
        Me.dgvimages.Location = New System.Drawing.Point(8, 25)
        Me.dgvimages.MultiSelect = False
        Me.dgvimages.Name = "dgvimages"
        Me.dgvimages.ReadOnly = True
        Me.dgvimages.RowHeadersVisible = False
        Me.dgvimages.RowHeadersWidth = 40
        Me.dgvimages.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvimages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvimages.Size = New System.Drawing.Size(963, 102)
        Me.dgvimages.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NOMBRE"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn1.HeaderText = "NOMBRE DEL ARCHIVO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TIPO"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn2.HeaderText = "TIPO DOC"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'ToolStripIMG
        '
        Me.ToolStripIMG.BackColor = System.Drawing.Color.White
        Me.ToolStripIMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStripIMG.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbagreImg, Me.ToolStripSeparator4, Me.tsbdelimg, Me.ToolStripSeparator5, Me.tsbverimg})
        Me.ToolStripIMG.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripIMG.Name = "ToolStripIMG"
        Me.ToolStripIMG.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStripIMG.Size = New System.Drawing.Size(979, 25)
        Me.ToolStripIMG.TabIndex = 2
        Me.ToolStripIMG.Text = "ToolStrip3"
        '
        'tsbagreImg
        '
        Me.tsbagreImg.AutoSize = False
        Me.tsbagreImg.BackColor = System.Drawing.Color.DimGray
        Me.tsbagreImg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbagreImg.Enabled = False
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
        Me.TabPage4.Controls.Add(Me.DataGridView1)
        Me.TabPage4.Controls.Add(Me.ToolStrip3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(979, 150)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Plan Mantenimiento"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.IBeam
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.White
        Me.DataGridView1.Location = New System.Drawing.Point(8, 24)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 40
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(963, 102)
        Me.DataGridView1.TabIndex = 3
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NOMBRE"
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn3.HeaderText = "NOMBRE DEL PLAN"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "FECHAINICIO"
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn4.HeaderText = "FECHA INICIO"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.White
        Me.ToolStrip3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator6, Me.ToolStripButton3, Me.ToolStripSeparator7, Me.ToolStripButton4})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip3.Size = New System.Drawing.Size(979, 25)
        Me.ToolStrip3.TabIndex = 2
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.BackColor = System.Drawing.Color.DimGray
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
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
        Me.ToolStripButton3.AutoSize = False
        Me.ToolStripButton3.BackColor = System.Drawing.Color.DimGray
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Enabled = False
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
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
        Me.ToolStripButton4.AutoSize = False
        Me.ToolStripButton4.BackColor = System.Drawing.Color.DimGray
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripButton4.Text = "Ver"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'btSalir
        '
        Me.btSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSalir.BackColor = System.Drawing.Color.DimGray
        Me.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.ForeColor = System.Drawing.Color.White
        Me.btSalir.Location = New System.Drawing.Point(896, 412)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(91, 36)
        Me.btSalir.TabIndex = 10
        Me.btSalir.Text = "&Salir"
        Me.btSalir.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmEquipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1003, 460)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(1019, 498)
        Me.Name = "FrmEquipos"
        Me.Text = "Mantenimiento Equipos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.dgvimages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStripIMG.ResumeLayout(False)
        Me.ToolStripIMG.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CBEstado As System.Windows.Forms.ComboBox
    Friend WithEvents cbseccion As System.Windows.Forms.ComboBox
    Friend WithEvents CBtipoEquipo As System.Windows.Forms.ComboBox
    Friend WithEvents dtFGarantia As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFcompra As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_Pro As System.Windows.Forms.TextBox
    Friend WithEvents txt_Nserie As System.Windows.Forms.TextBox
    Friend WithEvents txt_Mod As System.Windows.Forms.TextBox
    Friend WithEvents txt_Marca As System.Windows.Forms.TextBox
    Friend WithEvents txtDescrip As System.Windows.Forms.TextBox
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnFiltro As System.Windows.Forms.ToolStripButton
    Friend WithEvents TsbtnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents txt_Notas As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbAgregardoc As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbDeldoc As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dgvDoc As System.Windows.Forms.DataGridView
    Friend WithEvents dgvimages As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripIMG As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbagreImg As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbdelimg As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbverimg As System.Windows.Forms.ToolStripButton
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
End Class
