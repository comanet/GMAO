<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPersonal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPersonal))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GbEconomico = New System.Windows.Forms.GroupBox()
        Me.txt_HoraE = New System.Windows.Forms.TextBox()
        Me.txt_Hora = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbCat = New System.Windows.Forms.ComboBox()
        Me.gbimagen = New System.Windows.Forms.GroupBox()
        Me.cbEspe = New System.Windows.Forms.ComboBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_dir = New System.Windows.Forms.TextBox()
        Me.txt_tlf3 = New System.Windows.Forms.TextBox()
        Me.txt_tlf2 = New System.Windows.Forms.TextBox()
        Me.txt_tlf1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_DNI = New System.Windows.Forms.TextBox()
        Me.txt_Nom = New System.Windows.Forms.TextBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbDes = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.txt_Ape = New System.Windows.Forms.TextBox()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsNew = New System.Windows.Forms.ToolStripButton()
        Me.tsEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsDel = New System.Windows.Forms.ToolStripButton()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.dgvSecc = New System.Windows.Forms.DataGridView()
        Me.IDPERSONAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEFONO1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.GbEconomico.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvSecc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GbEconomico)
        Me.Panel1.Controls.Add(Me.gbimagen)
        Me.Panel1.Controls.Add(Me.cbEspe)
        Me.Panel1.Controls.Add(Me.txt_email)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txt_dir)
        Me.Panel1.Controls.Add(Me.txt_tlf3)
        Me.Panel1.Controls.Add(Me.txt_tlf2)
        Me.Panel1.Controls.Add(Me.txt_tlf1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt_DNI)
        Me.Panel1.Controls.Add(Me.txt_Nom)
        Me.Panel1.Controls.Add(Me.lbNombre)
        Me.Panel1.Controls.Add(Me.lbDes)
        Me.Panel1.Controls.Add(Me.lbID)
        Me.Panel1.Controls.Add(Me.txt_Ape)
        Me.Panel1.Controls.Add(Me.txt_ID)
        Me.Panel1.Location = New System.Drawing.Point(12, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(739, 303)
        Me.Panel1.TabIndex = 1
        '
        'GbEconomico
        '
        Me.GbEconomico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbEconomico.Controls.Add(Me.txt_HoraE)
        Me.GbEconomico.Controls.Add(Me.txt_Hora)
        Me.GbEconomico.Controls.Add(Me.Label8)
        Me.GbEconomico.Controls.Add(Me.Label7)
        Me.GbEconomico.Controls.Add(Me.Label6)
        Me.GbEconomico.Controls.Add(Me.cbCat)
        Me.GbEconomico.Location = New System.Drawing.Point(527, 148)
        Me.GbEconomico.Name = "GbEconomico"
        Me.GbEconomico.Size = New System.Drawing.Size(209, 145)
        Me.GbEconomico.TabIndex = 19
        Me.GbEconomico.TabStop = False
        Me.GbEconomico.Text = "Economicos"
        '
        'txt_HoraE
        '
        Me.txt_HoraE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_HoraE.Location = New System.Drawing.Point(95, 113)
        Me.txt_HoraE.MaxLength = 6
        Me.txt_HoraE.Name = "txt_HoraE"
        Me.txt_HoraE.ReadOnly = True
        Me.txt_HoraE.Size = New System.Drawing.Size(108, 26)
        Me.txt_HoraE.TabIndex = 12
        '
        'txt_Hora
        '
        Me.txt_Hora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Hora.Location = New System.Drawing.Point(95, 74)
        Me.txt_Hora.MaxLength = 6
        Me.txt_Hora.Name = "txt_Hora"
        Me.txt_Hora.ReadOnly = True
        Me.txt_Hora.Size = New System.Drawing.Size(108, 26)
        Me.txt_Hora.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 20)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "C.H.Ex:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "C.Hora:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Categoria:"
        '
        'cbCat
        '
        Me.cbCat.Enabled = False
        Me.cbCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCat.FormattingEnabled = True
        Me.cbCat.Location = New System.Drawing.Point(95, 33)
        Me.cbCat.Name = "cbCat"
        Me.cbCat.Size = New System.Drawing.Size(108, 28)
        Me.cbCat.TabIndex = 10
        '
        'gbimagen
        '
        Me.gbimagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbimagen.Location = New System.Drawing.Point(527, 12)
        Me.gbimagen.Name = "gbimagen"
        Me.gbimagen.Size = New System.Drawing.Size(209, 130)
        Me.gbimagen.TabIndex = 18
        Me.gbimagen.TabStop = False
        Me.gbimagen.Text = "Foto"
        Me.gbimagen.Visible = False
        '
        'cbEspe
        '
        Me.cbEspe.Enabled = False
        Me.cbEspe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEspe.FormattingEnabled = True
        Me.cbEspe.Location = New System.Drawing.Point(105, 225)
        Me.cbEspe.Name = "cbEspe"
        Me.cbEspe.Size = New System.Drawing.Size(268, 28)
        Me.cbEspe.TabIndex = 8
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.Location = New System.Drawing.Point(105, 267)
        Me.txt_email.MaxLength = 50
        Me.txt_email.Name = "txt_email"
        Me.txt_email.ReadOnly = True
        Me.txt_email.Size = New System.Drawing.Size(416, 26)
        Me.txt_email.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Especialidad:"
        '
        'txt_dir
        '
        Me.txt_dir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dir.Location = New System.Drawing.Point(105, 148)
        Me.txt_dir.MaxLength = 100
        Me.txt_dir.Name = "txt_dir"
        Me.txt_dir.ReadOnly = True
        Me.txt_dir.Size = New System.Drawing.Size(416, 26)
        Me.txt_dir.TabIndex = 4
        '
        'txt_tlf3
        '
        Me.txt_tlf3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tlf3.Location = New System.Drawing.Point(408, 183)
        Me.txt_tlf3.MaxLength = 10
        Me.txt_tlf3.Name = "txt_tlf3"
        Me.txt_tlf3.ReadOnly = True
        Me.txt_tlf3.Size = New System.Drawing.Size(113, 26)
        Me.txt_tlf3.TabIndex = 7
        '
        'txt_tlf2
        '
        Me.txt_tlf2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tlf2.Location = New System.Drawing.Point(260, 183)
        Me.txt_tlf2.MaxLength = 10
        Me.txt_tlf2.Name = "txt_tlf2"
        Me.txt_tlf2.ReadOnly = True
        Me.txt_tlf2.Size = New System.Drawing.Size(113, 26)
        Me.txt_tlf2.TabIndex = 6
        '
        'txt_tlf1
        '
        Me.txt_tlf1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tlf1.Location = New System.Drawing.Point(105, 183)
        Me.txt_tlf1.MaxLength = 10
        Me.txt_tlf1.Name = "txt_tlf1"
        Me.txt_tlf1.ReadOnly = True
        Me.txt_tlf1.Size = New System.Drawing.Size(113, 26)
        Me.txt_tlf1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Dirección:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Teléfonos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "DNI:"
        '
        'txt_DNI
        '
        Me.txt_DNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DNI.Location = New System.Drawing.Point(105, 116)
        Me.txt_DNI.MaxLength = 10
        Me.txt_DNI.Name = "txt_DNI"
        Me.txt_DNI.ReadOnly = True
        Me.txt_DNI.Size = New System.Drawing.Size(113, 26)
        Me.txt_DNI.TabIndex = 3
        '
        'txt_Nom
        '
        Me.txt_Nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nom.Location = New System.Drawing.Point(105, 47)
        Me.txt_Nom.MaxLength = 50
        Me.txt_Nom.Name = "txt_Nom"
        Me.txt_Nom.ReadOnly = True
        Me.txt_Nom.Size = New System.Drawing.Size(416, 26)
        Me.txt_Nom.TabIndex = 1
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
        Me.lbDes.Size = New System.Drawing.Size(77, 20)
        Me.lbDes.TabIndex = 3
        Me.lbDes.Text = "Apellidos:"
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
        'txt_Ape
        '
        Me.txt_Ape.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Ape.Location = New System.Drawing.Point(105, 84)
        Me.txt_Ape.MaxLength = 50
        Me.txt_Ape.Name = "txt_Ape"
        Me.txt_Ape.ReadOnly = True
        Me.txt_Ape.Size = New System.Drawing.Size(416, 26)
        Me.txt_Ape.TabIndex = 2
        '
        'txt_ID
        '
        Me.txt_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Location = New System.Drawing.Point(105, 12)
        Me.txt_ID.MaxLength = 6
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.ReadOnly = True
        Me.txt_ID.Size = New System.Drawing.Size(101, 26)
        Me.txt_ID.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsNew, Me.tsEdit, Me.tsDel, Me.tsSave})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(763, 48)
        Me.ToolStrip1.TabIndex = 2
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
        Me.tsSave.Image = CType(resources.GetObject("tsSave.Image"), System.Drawing.Image)
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(53, 45)
        Me.tsSave.Text = "Aplicar"
        '
        'btSalir
        '
        Me.btSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSalir.BackColor = System.Drawing.Color.DimGray
        Me.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.ForeColor = System.Drawing.Color.White
        Me.btSalir.Location = New System.Drawing.Point(660, 504)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(91, 36)
        Me.btSalir.TabIndex = 22
        Me.btSalir.Text = "&Salir"
        Me.btSalir.UseVisualStyleBackColor = False
        '
        'dgvSecc
        '
        Me.dgvSecc.AllowUserToAddRows = False
        Me.dgvSecc.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige
        Me.dgvSecc.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSecc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSecc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvSecc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSecc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPERSONAL, Me.NOMBRE, Me.APELLIDOS, Me.DNI, Me.TELEFONO1})
        Me.dgvSecc.Location = New System.Drawing.Point(12, 361)
        Me.dgvSecc.Name = "dgvSecc"
        Me.dgvSecc.ReadOnly = True
        Me.dgvSecc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSecc.Size = New System.Drawing.Size(739, 137)
        Me.dgvSecc.TabIndex = 21
        '
        'IDPERSONAL
        '
        Me.IDPERSONAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.IDPERSONAL.DataPropertyName = "IDPERSONAL"
        Me.IDPERSONAL.HeaderText = "ID"
        Me.IDPERSONAL.Name = "IDPERSONAL"
        Me.IDPERSONAL.ReadOnly = True
        Me.IDPERSONAL.Width = 43
        '
        'NOMBRE
        '
        Me.NOMBRE.DataPropertyName = "NOMBRE"
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        '
        'APELLIDOS
        '
        Me.APELLIDOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.APELLIDOS.DataPropertyName = "APELLIDOS"
        Me.APELLIDOS.HeaderText = "APELLIDOS"
        Me.APELLIDOS.Name = "APELLIDOS"
        Me.APELLIDOS.ReadOnly = True
        Me.APELLIDOS.Width = 91
        '
        'DNI
        '
        Me.DNI.DataPropertyName = "DNI"
        Me.DNI.HeaderText = "DNI"
        Me.DNI.Name = "DNI"
        Me.DNI.ReadOnly = True
        '
        'TELEFONO1
        '
        Me.TELEFONO1.DataPropertyName = "TELEFONO1"
        Me.TELEFONO1.HeaderText = "TELEFONO"
        Me.TELEFONO1.Name = "TELEFONO1"
        Me.TELEFONO1.ReadOnly = True
        '
        'FrmPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(763, 552)
        Me.Controls.Add(Me.dgvSecc)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(779, 590)
        Me.Name = "FrmPersonal"
        Me.Text = "Mantenimiento Personal"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GbEconomico.ResumeLayout(False)
        Me.GbEconomico.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvSecc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_Nom As System.Windows.Forms.TextBox
    Friend WithEvents lbNombre As System.Windows.Forms.Label
    Friend WithEvents lbDes As System.Windows.Forms.Label
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents txt_Ape As System.Windows.Forms.TextBox
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents dgvSecc As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_DNI As System.Windows.Forms.TextBox
    Friend WithEvents cbCat As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_dir As System.Windows.Forms.TextBox
    Friend WithEvents txt_tlf3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_tlf2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_tlf1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents GbEconomico As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gbimagen As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_HoraE As System.Windows.Forms.TextBox
    Friend WithEvents txt_Hora As System.Windows.Forms.TextBox
    Friend WithEvents cbEspe As System.Windows.Forms.ComboBox
    Friend WithEvents IDPERSONAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DNI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TELEFONO1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
