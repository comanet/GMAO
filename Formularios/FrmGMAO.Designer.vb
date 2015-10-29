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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGMAO))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.btBorrar = New System.Windows.Forms.Button()
        Me.btOT = New System.Windows.Forms.Button()
        Me.btAddPlan = New System.Windows.Forms.Button()
        Me.txt_ACTIVIDAD = New System.Windows.Forms.TextBox()
        Me.txt_EQUIPO = New System.Windows.Forms.TextBox()
        Me.calFInicio = New System.Windows.Forms.MonthCalendar()
        Me.txt_PLAN = New System.Windows.Forms.TextBox()
        Me.dgvPlanes = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageEquipos = New System.Windows.Forms.TabPage()
        Me.dgvEquip = New System.Windows.Forms.DataGridView()
        Me.TabPageAct = New System.Windows.Forms.TabPage()
        Me.dgvActiv = New System.Windows.Forms.DataGridView()
        Me.TabPagePlanes = New System.Windows.Forms.TabPage()
        EQUIPOLabel = New System.Windows.Forms.Label()
        IDPLANLabel = New System.Windows.Forms.Label()
        ACTIVIDADLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPlanes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPageEquipos.SuspendLayout()
        CType(Me.dgvEquip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageAct.SuspendLayout()
        CType(Me.dgvActiv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePlanes.SuspendLayout()
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
        ACTIVIDADLabel.Location = New System.Drawing.Point(9, 140)
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
        'btSalir
        '
        Me.btSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSalir.BackColor = System.Drawing.Color.DimGray
        Me.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.ForeColor = System.Drawing.Color.White
        Me.btSalir.Location = New System.Drawing.Point(598, 563)
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
        Me.tsNew.Enabled = False
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
        Me.tsEdit.Enabled = False
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
        Me.tsDel.Enabled = False
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
        Me.GroupBox1.Controls.Add(Me.btBorrar)
        Me.GroupBox1.Controls.Add(Me.btOT)
        Me.GroupBox1.Controls.Add(Me.btAddPlan)
        Me.GroupBox1.Controls.Add(Me.txt_ACTIVIDAD)
        Me.GroupBox1.Controls.Add(Me.txt_EQUIPO)
        Me.GroupBox1.Controls.Add(Me.calFInicio)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(ACTIVIDADLabel)
        Me.GroupBox1.Controls.Add(EQUIPOLabel)
        Me.GroupBox1.Controls.Add(Me.txt_PLAN)
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
        'btBorrar
        '
        Me.btBorrar.BackColor = System.Drawing.Color.DimGray
        Me.btBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBorrar.ForeColor = System.Drawing.Color.White
        Me.btBorrar.Location = New System.Drawing.Point(80, 170)
        Me.btBorrar.Name = "btBorrar"
        Me.btBorrar.Size = New System.Drawing.Size(111, 36)
        Me.btBorrar.TabIndex = 31
        Me.btBorrar.Text = "&Borrar Formulario"
        Me.btBorrar.UseVisualStyleBackColor = False
        '
        'btOT
        '
        Me.btOT.BackColor = System.Drawing.Color.DimGray
        Me.btOT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btOT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btOT.ForeColor = System.Drawing.Color.White
        Me.btOT.Location = New System.Drawing.Point(211, 170)
        Me.btOT.Name = "btOT"
        Me.btOT.Size = New System.Drawing.Size(111, 36)
        Me.btOT.TabIndex = 30
        Me.btOT.Text = "&Crear Orden de Trabajo"
        Me.btOT.UseVisualStyleBackColor = False
        '
        'btAddPlan
        '
        Me.btAddPlan.BackColor = System.Drawing.Color.DimGray
        Me.btAddPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAddPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAddPlan.ForeColor = System.Drawing.Color.White
        Me.btAddPlan.Location = New System.Drawing.Point(342, 170)
        Me.btAddPlan.Name = "btAddPlan"
        Me.btAddPlan.Size = New System.Drawing.Size(111, 36)
        Me.btAddPlan.TabIndex = 29
        Me.btAddPlan.Text = "&Asignar a Plantilla"
        Me.btAddPlan.UseVisualStyleBackColor = False
        '
        'txt_ACTIVIDAD
        '
        Me.txt_ACTIVIDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ACTIVIDAD.Location = New System.Drawing.Point(80, 132)
        Me.txt_ACTIVIDAD.MaxLength = 50
        Me.txt_ACTIVIDAD.Name = "txt_ACTIVIDAD"
        Me.txt_ACTIVIDAD.ReadOnly = True
        Me.txt_ACTIVIDAD.Size = New System.Drawing.Size(373, 26)
        Me.txt_ACTIVIDAD.TabIndex = 28
        '
        'txt_EQUIPO
        '
        Me.txt_EQUIPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EQUIPO.Location = New System.Drawing.Point(80, 88)
        Me.txt_EQUIPO.MaxLength = 50
        Me.txt_EQUIPO.Name = "txt_EQUIPO"
        Me.txt_EQUIPO.ReadOnly = True
        Me.txt_EQUIPO.Size = New System.Drawing.Size(373, 26)
        Me.txt_EQUIPO.TabIndex = 27
        '
        'calFInicio
        '
        Me.calFInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calFInicio.Location = New System.Drawing.Point(465, 44)
        Me.calFInicio.Name = "calFInicio"
        Me.calFInicio.TabIndex = 26
        '
        'txt_PLAN
        '
        Me.txt_PLAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PLAN.Location = New System.Drawing.Point(80, 44)
        Me.txt_PLAN.MaxLength = 50
        Me.txt_PLAN.Name = "txt_PLAN"
        Me.txt_PLAN.ReadOnly = True
        Me.txt_PLAN.Size = New System.Drawing.Size(373, 26)
        Me.txt_PLAN.TabIndex = 1
        '
        'dgvPlanes
        '
        Me.dgvPlanes.AllowUserToAddRows = False
        Me.dgvPlanes.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGray
        Me.dgvPlanes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPlanes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPlanes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPlanes.Location = New System.Drawing.Point(3, 3)
        Me.dgvPlanes.Name = "dgvPlanes"
        Me.dgvPlanes.ReadOnly = True
        Me.dgvPlanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPlanes.Size = New System.Drawing.Size(687, 227)
        Me.dgvPlanes.TabIndex = 15
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPageEquipos)
        Me.TabControl1.Controls.Add(Me.TabPageAct)
        Me.TabControl1.Controls.Add(Me.TabPagePlanes)
        Me.TabControl1.Location = New System.Drawing.Point(0, 284)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(701, 265)
        Me.TabControl1.TabIndex = 36
        '
        'TabPageEquipos
        '
        Me.TabPageEquipos.Controls.Add(Me.dgvEquip)
        Me.TabPageEquipos.Location = New System.Drawing.Point(4, 22)
        Me.TabPageEquipos.Name = "TabPageEquipos"
        Me.TabPageEquipos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEquipos.Size = New System.Drawing.Size(693, 239)
        Me.TabPageEquipos.TabIndex = 1
        Me.TabPageEquipos.Text = "Equipos"
        Me.TabPageEquipos.UseVisualStyleBackColor = True
        '
        'dgvEquip
        '
        Me.dgvEquip.AllowUserToAddRows = False
        Me.dgvEquip.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray
        Me.dgvEquip.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvEquip.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEquip.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvEquip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvEquip.Location = New System.Drawing.Point(3, 3)
        Me.dgvEquip.Name = "dgvEquip"
        Me.dgvEquip.ReadOnly = True
        Me.dgvEquip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEquip.Size = New System.Drawing.Size(687, 230)
        Me.dgvEquip.TabIndex = 17
        '
        'TabPageAct
        '
        Me.TabPageAct.Controls.Add(Me.dgvActiv)
        Me.TabPageAct.Location = New System.Drawing.Point(4, 22)
        Me.TabPageAct.Name = "TabPageAct"
        Me.TabPageAct.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAct.Size = New System.Drawing.Size(693, 239)
        Me.TabPageAct.TabIndex = 0
        Me.TabPageAct.Text = "Actividades"
        Me.TabPageAct.UseVisualStyleBackColor = True
        '
        'dgvActiv
        '
        Me.dgvActiv.AllowUserToAddRows = False
        Me.dgvActiv.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightGray
        Me.dgvActiv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvActiv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvActiv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvActiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvActiv.Location = New System.Drawing.Point(3, 3)
        Me.dgvActiv.Name = "dgvActiv"
        Me.dgvActiv.ReadOnly = True
        Me.dgvActiv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActiv.Size = New System.Drawing.Size(687, 230)
        Me.dgvActiv.TabIndex = 16
        '
        'TabPagePlanes
        '
        Me.TabPagePlanes.Controls.Add(Me.dgvPlanes)
        Me.TabPagePlanes.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePlanes.Name = "TabPagePlanes"
        Me.TabPagePlanes.Size = New System.Drawing.Size(693, 239)
        Me.TabPagePlanes.TabIndex = 2
        Me.TabPagePlanes.Text = "Planes"
        Me.TabPagePlanes.UseVisualStyleBackColor = True
        '
        'FrmGMAO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(701, 611)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FrmGMAO"
        Me.Text = "Planes GMAO"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvPlanes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageEquipos.ResumeLayout(False)
        CType(Me.dgvEquip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageAct.ResumeLayout(False)
        CType(Me.dgvActiv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePlanes.ResumeLayout(False)
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
    Friend WithEvents txt_PLAN As System.Windows.Forms.TextBox
    Friend WithEvents dgvPlanes As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageAct As System.Windows.Forms.TabPage
    Friend WithEvents TabPageEquipos As System.Windows.Forms.TabPage
    Friend WithEvents TabPagePlanes As System.Windows.Forms.TabPage
    Friend WithEvents dgvActiv As System.Windows.Forms.DataGridView
    Friend WithEvents dgvEquip As System.Windows.Forms.DataGridView
    Friend WithEvents txt_ACTIVIDAD As System.Windows.Forms.TextBox
    Friend WithEvents txt_EQUIPO As System.Windows.Forms.TextBox
    Friend WithEvents btAddPlan As System.Windows.Forms.Button
    Friend WithEvents btOT As System.Windows.Forms.Button
    Friend WithEvents btBorrar As System.Windows.Forms.Button
End Class
