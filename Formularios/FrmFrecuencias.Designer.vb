﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFrecuencias
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
        Dim IDFRECUENCIALabel As System.Windows.Forms.Label
        Dim DESCFRECLabel As System.Windows.Forms.Label
        Dim DIASLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFrecuencias))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsNew = New System.Windows.Forms.ToolStripButton()
        Me.tsEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsDel = New System.Windows.Forms.ToolStripButton()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnFiltro = New System.Windows.Forms.ToolStripButton()
        Me.TsbtnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.txt_DESCRIPCION = New System.Windows.Forms.TextBox()
        Me.txt_DIAS = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvSecc = New System.Windows.Forms.DataGridView()
        Me.IDFRECUENCIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IDFRECUENCIALabel = New System.Windows.Forms.Label()
        DESCFRECLabel = New System.Windows.Forms.Label()
        DIASLabel = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvSecc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDFRECUENCIALabel
        '
        IDFRECUENCIALabel.AutoSize = True
        IDFRECUENCIALabel.Location = New System.Drawing.Point(12, 29)
        IDFRECUENCIALabel.Name = "IDFRECUENCIALabel"
        IDFRECUENCIALabel.Size = New System.Drawing.Size(89, 13)
        IDFRECUENCIALabel.TabIndex = 23
        IDFRECUENCIALabel.Text = "IDFRECUENCIA:"
        '
        'DESCFRECLabel
        '
        DESCFRECLabel.AutoSize = True
        DESCFRECLabel.Location = New System.Drawing.Point(12, 66)
        DESCFRECLabel.Name = "DESCFRECLabel"
        DESCFRECLabel.Size = New System.Drawing.Size(83, 13)
        DESCFRECLabel.TabIndex = 26
        DESCFRECLabel.Text = "DESCRIPCIÓN:"
        '
        'DIASLabel
        '
        DIASLabel.AutoSize = True
        DIASLabel.Location = New System.Drawing.Point(12, 103)
        DIASLabel.Name = "DIASLabel"
        DIASLabel.Size = New System.Drawing.Size(35, 13)
        DIASLabel.TabIndex = 28
        DIASLabel.Text = "DIAS:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsNew, Me.tsEdit, Me.tsDel, Me.tsSave, Me.ToolStripSeparator1, Me.tsbtnFiltro, Me.TsbtnPrint})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(695, 57)
        Me.ToolStrip1.TabIndex = 9
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
        'btSalir
        '
        Me.btSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSalir.BackColor = System.Drawing.Color.DimGray
        Me.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.ForeColor = System.Drawing.Color.White
        Me.btSalir.Location = New System.Drawing.Point(592, 422)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(91, 36)
        Me.btSalir.TabIndex = 12
        Me.btSalir.Text = "&Salir"
        Me.btSalir.UseVisualStyleBackColor = False
        '
        'txt_ID
        '
        Me.txt_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Location = New System.Drawing.Point(107, 21)
        Me.txt_ID.MaxLength = 8
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.ReadOnly = True
        Me.txt_ID.Size = New System.Drawing.Size(100, 26)
        Me.txt_ID.TabIndex = 24
        '
        'txt_DESCRIPCION
        '
        Me.txt_DESCRIPCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DESCRIPCION.Location = New System.Drawing.Point(107, 58)
        Me.txt_DESCRIPCION.MaxLength = 255
        Me.txt_DESCRIPCION.Name = "txt_DESCRIPCION"
        Me.txt_DESCRIPCION.ReadOnly = True
        Me.txt_DESCRIPCION.Size = New System.Drawing.Size(576, 26)
        Me.txt_DESCRIPCION.TabIndex = 27
        '
        'txt_DIAS
        '
        Me.txt_DIAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DIAS.Location = New System.Drawing.Point(107, 95)
        Me.txt_DIAS.MaxLength = 8
        Me.txt_DIAS.Name = "txt_DIAS"
        Me.txt_DIAS.ReadOnly = True
        Me.txt_DIAS.Size = New System.Drawing.Size(100, 26)
        Me.txt_DIAS.TabIndex = 29
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_DIAS)
        Me.GroupBox1.Controls.Add(DIASLabel)
        Me.GroupBox1.Controls.Add(Me.txt_DESCRIPCION)
        Me.GroupBox1.Controls.Add(DESCFRECLabel)
        Me.GroupBox1.Controls.Add(Me.txt_ID)
        Me.GroupBox1.Controls.Add(IDFRECUENCIALabel)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(695, 150)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Planes de Mantenimiento de Mantenimientos"
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
        Me.dgvSecc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSecc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSecc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDFRECUENCIA, Me.DESCRIPCION, Me.DIAS})
        Me.dgvSecc.Location = New System.Drawing.Point(0, 213)
        Me.dgvSecc.Name = "dgvSecc"
        Me.dgvSecc.ReadOnly = True
        Me.dgvSecc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSecc.Size = New System.Drawing.Size(695, 203)
        Me.dgvSecc.TabIndex = 22
        '
        'IDFRECUENCIA
        '
        Me.IDFRECUENCIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IDFRECUENCIA.DataPropertyName = "IDFRECUENCIA"
        Me.IDFRECUENCIA.HeaderText = "IDFRECUENCIA"
        Me.IDFRECUENCIA.Name = "IDFRECUENCIA"
        Me.IDFRECUENCIA.ReadOnly = True
        Me.IDFRECUENCIA.Width = 111
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
        'DIAS
        '
        Me.DIAS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DIAS.DataPropertyName = "DIAS"
        Me.DIAS.HeaderText = "DIAS"
        Me.DIAS.Name = "DIAS"
        Me.DIAS.ReadOnly = True
        Me.DIAS.Width = 57
        '
        'FrmFrecuencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(695, 470)
        Me.Controls.Add(Me.dgvSecc)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimumSize = New System.Drawing.Size(711, 301)
        Me.Name = "FrmFrecuencias"
        Me.Text = "Frecuencia de Revisiones"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvSecc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
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
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
    Friend WithEvents txt_DESCRIPCION As System.Windows.Forms.TextBox
    Friend WithEvents txt_DIAS As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSecc As System.Windows.Forms.DataGridView
    Friend WithEvents IDFRECUENCIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIAS As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
