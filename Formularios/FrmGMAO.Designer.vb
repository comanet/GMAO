<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGMAO
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
        Dim EQUIPOLabel As System.Windows.Forms.Label
        Dim IDPLANLabel As System.Windows.Forms.Label
        Dim ACTIVIDADLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGMAO))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsNew = New System.Windows.Forms.ToolStripButton()
        Me.tsEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsDel = New System.Windows.Forms.ToolStripButton()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnFiltro = New System.Windows.Forms.ToolStripButton()
        Me.TsbtnPrint = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbPlan = New System.Windows.Forms.ComboBox()
        Me.calFInicio = New System.Windows.Forms.MonthCalendar()
        Me.cbActiv = New System.Windows.Forms.ComboBox()
        Me.cbEquipo = New System.Windows.Forms.ComboBox()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.txt_IDPM = New System.Windows.Forms.TextBox()
        Me.txt_FIni = New System.Windows.Forms.TextBox()
        Me.txt_IDEQUIPO = New System.Windows.Forms.TextBox()
        Me.txt_IDACTIV = New System.Windows.Forms.TextBox()
        Me.dgvSecc = New System.Windows.Forms.DataGridView()
        EQUIPOLabel = New System.Windows.Forms.Label()
        IDPLANLabel = New System.Windows.Forms.Label()
        ACTIVIDADLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSecc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EQUIPOLabel
        '
        EQUIPOLabel.AutoSize = True
        EQUIPOLabel.Location = New System.Drawing.Point(9, 96)
        EQUIPOLabel.Name = "EQUIPOLabel"
        EQUIPOLabel.Size = New System.Drawing.Size(51, 13)
        EQUIPOLabel.TabIndex = 22
        EQUIPOLabel.Text = "EQUIPO:"
        '
        'IDPLANLabel
        '
        IDPLANLabel.AutoSize = True
        IDPLANLabel.Location = New System.Drawing.Point(9, 52)
        IDPLANLabel.Name = "IDPLANLabel"
        IDPLANLabel.Size = New System.Drawing.Size(49, 13)
        IDPLANLabel.TabIndex = 0
        IDPLANLabel.Text = "IDPLAN:"
        '
        'ACTIVIDADLabel
        '
        ACTIVIDADLabel.AutoSize = True
        ACTIVIDADLabel.Location = New System.Drawing.Point(9, 142)
        ACTIVIDADLabel.Name = "ACTIVIDADLabel"
        ACTIVIDADLabel.Size = New System.Drawing.Size(67, 13)
        ACTIVIDADLabel.TabIndex = 24
        ACTIVIDADLabel.Text = "ACTIVIDAD:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(464, 22)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(153, 13)
        Label1.TabIndex = 25
        Label1.Text = "FECHA DE INICIO DEL PLAN:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(79, 309)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(38, 13)
        Label2.TabIndex = 30
        Label2.Text = "FInicio"
        Label2.Visible = False
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(241, 309)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(59, 13)
        Label3.TabIndex = 31
        Label3.Text = "IDEQUIPO"
        Label3.Visible = False
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(241, 331)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(49, 13)
        Label4.TabIndex = 32
        Label4.Text = "IDACTIV"
        Label4.Visible = False
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(79, 331)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(34, 13)
        Label5.TabIndex = 35
        Label5.Text = "IDPM"
        Label5.Visible = False
        '
        'btSalir
        '
        Me.btSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSalir.BackColor = System.Drawing.Color.DimGray
        Me.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.ForeColor = System.Drawing.Color.White
        Me.btSalir.Location = New System.Drawing.Point(601, 436)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(91, 36)
        Me.btSalir.TabIndex = 12
        Me.btSalir.Text = "&Salir"
        Me.btSalir.UseVisualStyleBackColor = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsNew, Me.tsEdit, Me.tsDel, Me.tsSave, Me.ToolStripSeparator1, Me.tsbtnFiltro, Me.TsbtnPrint})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(701, 57)
        Me.ToolStrip1.TabIndex = 13
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
        Me.GroupBox1.Controls.Add(Me.cbPlan)
        Me.GroupBox1.Controls.Add(Me.calFInicio)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.cbActiv)
        Me.GroupBox1.Controls.Add(ACTIVIDADLabel)
        Me.GroupBox1.Controls.Add(Me.cbEquipo)
        Me.GroupBox1.Controls.Add(EQUIPOLabel)
        Me.GroupBox1.Controls.Add(Me.txt_ID)
        Me.GroupBox1.Controls.Add(IDPLANLabel)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(0, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(701, 221)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle Planes GMAO"
        '
        'cbPlan
        '
        Me.cbPlan.Enabled = False
        Me.cbPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPlan.FormattingEnabled = True
        Me.cbPlan.Location = New System.Drawing.Point(80, 42)
        Me.cbPlan.Name = "cbPlan"
        Me.cbPlan.Size = New System.Drawing.Size(314, 28)
        Me.cbPlan.TabIndex = 33
        '
        'calFInicio
        '
        Me.calFInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calFInicio.Location = New System.Drawing.Point(465, 44)
        Me.calFInicio.Name = "calFInicio"
        Me.calFInicio.TabIndex = 26
        '
        'cbActiv
        '
        Me.cbActiv.Enabled = False
        Me.cbActiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbActiv.FormattingEnabled = True
        Me.cbActiv.Location = New System.Drawing.Point(82, 132)
        Me.cbActiv.Name = "cbActiv"
        Me.cbActiv.Size = New System.Drawing.Size(312, 28)
        Me.cbActiv.TabIndex = 23
        '
        'cbEquipo
        '
        Me.cbEquipo.Enabled = False
        Me.cbEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEquipo.FormattingEnabled = True
        Me.cbEquipo.Location = New System.Drawing.Point(80, 84)
        Me.cbEquipo.Name = "cbEquipo"
        Me.cbEquipo.Size = New System.Drawing.Size(314, 28)
        Me.cbEquipo.TabIndex = 2
        '
        'txt_ID
        '
        Me.txt_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Location = New System.Drawing.Point(80, 44)
        Me.txt_ID.MaxLength = 50
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.ReadOnly = True
        Me.txt_ID.Size = New System.Drawing.Size(314, 26)
        Me.txt_ID.TabIndex = 1
        '
        'txt_IDPM
        '
        Me.txt_IDPM.Location = New System.Drawing.Point(152, 328)
        Me.txt_IDPM.Name = "txt_IDPM"
        Me.txt_IDPM.Size = New System.Drawing.Size(42, 20)
        Me.txt_IDPM.TabIndex = 34
        '
        'txt_FIni
        '
        Me.txt_FIni.Location = New System.Drawing.Point(152, 306)
        Me.txt_FIni.Name = "txt_FIni"
        Me.txt_FIni.Size = New System.Drawing.Size(83, 20)
        Me.txt_FIni.TabIndex = 29
        '
        'txt_IDEQUIPO
        '
        Me.txt_IDEQUIPO.Location = New System.Drawing.Point(306, 306)
        Me.txt_IDEQUIPO.Name = "txt_IDEQUIPO"
        Me.txt_IDEQUIPO.Size = New System.Drawing.Size(42, 20)
        Me.txt_IDEQUIPO.TabIndex = 28
        '
        'txt_IDACTIV
        '
        Me.txt_IDACTIV.Location = New System.Drawing.Point(306, 328)
        Me.txt_IDACTIV.Name = "txt_IDACTIV"
        Me.txt_IDACTIV.Size = New System.Drawing.Size(42, 20)
        Me.txt_IDACTIV.TabIndex = 27
        '
        'dgvSecc
        '
        Me.dgvSecc.AllowUserToAddRows = False
        Me.dgvSecc.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray
        Me.dgvSecc.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSecc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSecc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvSecc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSecc.Location = New System.Drawing.Point(12, 284)
        Me.dgvSecc.Name = "dgvSecc"
        Me.dgvSecc.ReadOnly = True
        Me.dgvSecc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSecc.Size = New System.Drawing.Size(680, 146)
        Me.dgvSecc.TabIndex = 15
        '
        'FrmGMAO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(701, 484)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.dgvSecc)
        Me.Controls.Add(Me.txt_IDPM)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.txt_IDACTIV)
        Me.Controls.Add(Me.txt_FIni)
        Me.Controls.Add(Me.txt_IDEQUIPO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmGMAO"
        Me.Text = "Planes GMAO"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvSecc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnFiltro As System.Windows.Forms.ToolStripButton
    Friend WithEvents TsbtnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents calFInicio As System.Windows.Forms.MonthCalendar
    Friend WithEvents cbActiv As System.Windows.Forms.ComboBox
    Friend WithEvents cbEquipo As System.Windows.Forms.ComboBox
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents dgvSecc As System.Windows.Forms.DataGridView
    Friend WithEvents txt_IDACTIV As System.Windows.Forms.TextBox
    Friend WithEvents txt_IDEQUIPO As System.Windows.Forms.TextBox
    Friend WithEvents txt_FIni As System.Windows.Forms.TextBox
    Friend WithEvents cbPlan As System.Windows.Forms.ComboBox
    Friend WithEvents txt_IDPM As System.Windows.Forms.TextBox
End Class
