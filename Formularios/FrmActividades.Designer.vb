<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActividades
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
        Dim DESRIPCIONLabel As System.Windows.Forms.Label
        Dim IdAtividadLabel As System.Windows.Forms.Label
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmActividades))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsNew = New System.Windows.Forms.ToolStripButton()
        Me.tsEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsDel = New System.Windows.Forms.ToolStripButton()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnFiltro = New System.Windows.Forms.ToolStripButton()
        Me.TsbtnPrint = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbFrec = New System.Windows.Forms.ComboBox()
        Me.FRECUENCIALabel = New System.Windows.Forms.Label()
        Me.cbTMant = New System.Windows.Forms.ComboBox()
        Me.TIPMANTLabel = New System.Windows.Forms.Label()
        Me.txt_DESCRIPCION = New System.Windows.Forms.TextBox()
        Me.cbEspe = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_NOMBRE = New System.Windows.Forms.TextBox()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.dgvActividades = New System.Windows.Forms.DataGridView()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESPECIALIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        DESRIPCIONLabel = New System.Windows.Forms.Label()
        IdAtividadLabel = New System.Windows.Forms.Label()
        NOMBRELabel = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DESRIPCIONLabel
        '
        DESRIPCIONLabel.AutoSize = True
        DESRIPCIONLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DESRIPCIONLabel.Location = New System.Drawing.Point(6, 133)
        DESRIPCIONLabel.Name = "DESRIPCIONLabel"
        DESRIPCIONLabel.Size = New System.Drawing.Size(92, 15)
        DESRIPCIONLabel.TabIndex = 26
        DESRIPCIONLabel.Text = "DESCRIPCIÓN:"
        '
        'IdAtividadLabel
        '
        IdAtividadLabel.AutoSize = True
        IdAtividadLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdAtividadLabel.Location = New System.Drawing.Point(6, 27)
        IdAtividadLabel.Name = "IdAtividadLabel"
        IdAtividadLabel.Size = New System.Drawing.Size(54, 15)
        IdAtividadLabel.TabIndex = 23
        IdAtividadLabel.Text = "CODIGO"
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NOMBRELabel.Location = New System.Drawing.Point(6, 61)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(64, 15)
        NOMBRELabel.TabIndex = 28
        NOMBRELabel.Text = "NOMBRE:"
        AddHandler NOMBRELabel.Click, AddressOf Me.NOMBRELabel_Click
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsNew, Me.tsEdit, Me.tsDel, Me.tsSave, Me.ToolStripSeparator1, Me.tsbtnFiltro, Me.TsbtnPrint})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(797, 57)
        Me.ToolStrip1.TabIndex = 11
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
        Me.GroupBox1.Controls.Add(Me.cbFrec)
        Me.GroupBox1.Controls.Add(Me.FRECUENCIALabel)
        Me.GroupBox1.Controls.Add(Me.cbTMant)
        Me.GroupBox1.Controls.Add(Me.TIPMANTLabel)
        Me.GroupBox1.Controls.Add(Me.txt_DESCRIPCION)
        Me.GroupBox1.Controls.Add(Me.cbEspe)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_NOMBRE)
        Me.GroupBox1.Controls.Add(NOMBRELabel)
        Me.GroupBox1.Controls.Add(DESRIPCIONLabel)
        Me.GroupBox1.Controls.Add(Me.txt_ID)
        Me.GroupBox1.Controls.Add(IdAtividadLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(785, 204)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identifiacion de Tareas"
        '
        'cbFrec
        '
        Me.cbFrec.Enabled = False
        Me.cbFrec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFrec.FormattingEnabled = True
        Me.cbFrec.Location = New System.Drawing.Point(104, 93)
        Me.cbFrec.Name = "cbFrec"
        Me.cbFrec.Size = New System.Drawing.Size(181, 28)
        Me.cbFrec.TabIndex = 2
        '
        'FRECUENCIALabel
        '
        Me.FRECUENCIALabel.AutoSize = True
        Me.FRECUENCIALabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FRECUENCIALabel.Location = New System.Drawing.Point(6, 99)
        Me.FRECUENCIALabel.Name = "FRECUENCIALabel"
        Me.FRECUENCIALabel.Size = New System.Drawing.Size(86, 15)
        Me.FRECUENCIALabel.TabIndex = 35
        Me.FRECUENCIALabel.Text = "FRECUENCIA:"
        '
        'cbTMant
        '
        Me.cbTMant.Enabled = False
        Me.cbTMant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTMant.FormattingEnabled = True
        Me.cbTMant.Location = New System.Drawing.Point(348, 93)
        Me.cbTMant.Name = "cbTMant"
        Me.cbTMant.Size = New System.Drawing.Size(164, 28)
        Me.cbTMant.TabIndex = 3
        '
        'TIPMANTLabel
        '
        Me.TIPMANTLabel.AutoSize = True
        Me.TIPMANTLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TIPMANTLabel.Location = New System.Drawing.Point(305, 99)
        Me.TIPMANTLabel.Name = "TIPMANTLabel"
        Me.TIPMANTLabel.Size = New System.Drawing.Size(37, 15)
        Me.TIPMANTLabel.TabIndex = 33
        Me.TIPMANTLabel.Text = "TIPO:"
        '
        'txt_DESCRIPCION
        '
        Me.txt_DESCRIPCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DESCRIPCION.Location = New System.Drawing.Point(104, 127)
        Me.txt_DESCRIPCION.MaxLength = 255
        Me.txt_DESCRIPCION.Multiline = True
        Me.txt_DESCRIPCION.Name = "txt_DESCRIPCION"
        Me.txt_DESCRIPCION.ReadOnly = True
        Me.txt_DESCRIPCION.Size = New System.Drawing.Size(665, 57)
        Me.txt_DESCRIPCION.TabIndex = 5
        '
        'cbEspe
        '
        Me.cbEspe.Enabled = False
        Me.cbEspe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEspe.FormattingEnabled = True
        Me.cbEspe.Location = New System.Drawing.Point(619, 93)
        Me.cbEspe.Name = "cbEspe"
        Me.cbEspe.Size = New System.Drawing.Size(150, 28)
        Me.cbEspe.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(518, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 15)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "ESPECIALIDAD:"
        '
        'txt_NOMBRE
        '
        Me.txt_NOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NOMBRE.Location = New System.Drawing.Point(107, 55)
        Me.txt_NOMBRE.MaxLength = 50
        Me.txt_NOMBRE.Name = "txt_NOMBRE"
        Me.txt_NOMBRE.ReadOnly = True
        Me.txt_NOMBRE.Size = New System.Drawing.Size(662, 26)
        Me.txt_NOMBRE.TabIndex = 1
        '
        'txt_ID
        '
        Me.txt_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Location = New System.Drawing.Point(107, 21)
        Me.txt_ID.MaxLength = 8
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.ReadOnly = True
        Me.txt_ID.Size = New System.Drawing.Size(123, 26)
        Me.txt_ID.TabIndex = 0
        '
        'dgvActividades
        '
        Me.dgvActividades.AllowUserToAddRows = False
        Me.dgvActividades.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige
        Me.dgvActividades.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvActividades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvActividades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvActividades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOMBRE, Me.ESPECIALIDAD, Me.DESCRIPCION})
        Me.dgvActividades.Location = New System.Drawing.Point(0, 267)
        Me.dgvActividades.Name = "dgvActividades"
        Me.dgvActividades.ReadOnly = True
        Me.dgvActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActividades.Size = New System.Drawing.Size(785, 180)
        Me.dgvActividades.TabIndex = 24
        '
        'btSalir
        '
        Me.btSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSalir.BackColor = System.Drawing.Color.DimGray
        Me.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.ForeColor = System.Drawing.Color.White
        Me.btSalir.Location = New System.Drawing.Point(694, 466)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(91, 36)
        Me.btSalir.TabIndex = 7
        Me.btSalir.Text = "&Salir"
        Me.btSalir.UseVisualStyleBackColor = False
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
        'ESPECIALIDAD
        '
        Me.ESPECIALIDAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ESPECIALIDAD.DataPropertyName = "IDESPECIALIDAD"
        Me.ESPECIALIDAD.HeaderText = "ESPECIALIDAD"
        Me.ESPECIALIDAD.Name = "ESPECIALIDAD"
        Me.ESPECIALIDAD.ReadOnly = True
        Me.ESPECIALIDAD.Width = 109
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DESCRIPCION.DataPropertyName = "DESCRIPCION"
        Me.DESCRIPCION.HeaderText = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.ReadOnly = True
        Me.DESCRIPCION.Width = 105
        '
        'FrmActividades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(797, 514)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.dgvActividades)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "FrmActividades"
        Me.Text = "Actividades "
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txt_NOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents txt_DESCRIPCION As System.Windows.Forms.TextBox
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents cbEspe As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbFrec As System.Windows.Forms.ComboBox
    Friend WithEvents FRECUENCIALabel As System.Windows.Forms.Label
    Friend WithEvents cbTMant As System.Windows.Forms.ComboBox
    Friend WithEvents TIPMANTLabel As System.Windows.Forms.Label
    Friend WithEvents dgvActividades As System.Windows.Forms.DataGridView
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESPECIALIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
