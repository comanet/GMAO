<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddPlan
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
        Dim NOMBRELabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.PanelPlanes = New System.Windows.Forms.Panel()
        Me.btnAddPlan = New System.Windows.Forms.Button()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.LabelPlan = New System.Windows.Forms.Label()
        Me.cbPlan = New System.Windows.Forms.ComboBox()
        Me.dgvSecc = New System.Windows.Forms.DataGridView()
        Me.IDPERSONAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APELLIDOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEFONO1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NOMBRELabel = New System.Windows.Forms.Label()
        Me.PanelPlanes.SuspendLayout()
        CType(Me.dgvSecc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NOMBRELabel
        '
        NOMBRELabel.AutoSize = True
        NOMBRELabel.Location = New System.Drawing.Point(15, 19)
        NOMBRELabel.Name = "NOMBRELabel"
        NOMBRELabel.Size = New System.Drawing.Size(57, 13)
        NOMBRELabel.TabIndex = 12
        NOMBRELabel.Text = "NOMBRE:"
        '
        'btSalir
        '
        Me.btSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSalir.BackColor = System.Drawing.Color.DimGray
        Me.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.ForeColor = System.Drawing.Color.White
        Me.btSalir.Location = New System.Drawing.Point(492, 343)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(91, 36)
        Me.btSalir.TabIndex = 11
        Me.btSalir.Text = "&Salir"
        Me.btSalir.UseVisualStyleBackColor = False
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nombre.Location = New System.Drawing.Point(92, 12)
        Me.txt_Nombre.MaxLength = 50
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.ReadOnly = True
        Me.txt_Nombre.Size = New System.Drawing.Size(491, 26)
        Me.txt_Nombre.TabIndex = 13
        '
        'PanelPlanes
        '
        Me.PanelPlanes.AutoScroll = True
        Me.PanelPlanes.Controls.Add(Me.btnAddPlan)
        Me.PanelPlanes.Controls.Add(Me.txtFecha)
        Me.PanelPlanes.Controls.Add(Me.LabelFecha)
        Me.PanelPlanes.Controls.Add(Me.LabelPlan)
        Me.PanelPlanes.Controls.Add(Me.cbPlan)
        Me.PanelPlanes.Location = New System.Drawing.Point(18, 61)
        Me.PanelPlanes.Name = "PanelPlanes"
        Me.PanelPlanes.Size = New System.Drawing.Size(565, 50)
        Me.PanelPlanes.TabIndex = 14
        '
        'btnAddPlan
        '
        Me.btnAddPlan.Location = New System.Drawing.Point(474, 17)
        Me.btnAddPlan.Name = "btnAddPlan"
        Me.btnAddPlan.Size = New System.Drawing.Size(79, 20)
        Me.btnAddPlan.TabIndex = 4
        Me.btnAddPlan.Text = "Asignar"
        Me.btnAddPlan.UseVisualStyleBackColor = True
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(341, 17)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(115, 20)
        Me.txtFecha.TabIndex = 3
        '
        'LabelFecha
        '
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFecha.Location = New System.Drawing.Point(284, 17)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(51, 17)
        Me.LabelFecha.TabIndex = 2
        Me.LabelFecha.Text = "Fecha:"
        '
        'LabelPlan
        '
        Me.LabelPlan.AutoSize = True
        Me.LabelPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPlan.Location = New System.Drawing.Point(3, 17)
        Me.LabelPlan.Name = "LabelPlan"
        Me.LabelPlan.Size = New System.Drawing.Size(40, 17)
        Me.LabelPlan.TabIndex = 1
        Me.LabelPlan.Text = "Plan:"
        '
        'cbPlan
        '
        Me.cbPlan.FormattingEnabled = True
        Me.cbPlan.Location = New System.Drawing.Point(49, 16)
        Me.cbPlan.Name = "cbPlan"
        Me.cbPlan.Size = New System.Drawing.Size(214, 21)
        Me.cbPlan.TabIndex = 0
        '
        'dgvSecc
        '
        Me.dgvSecc.AllowUserToAddRows = False
        Me.dgvSecc.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige
        Me.dgvSecc.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSecc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSecc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvSecc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSecc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPERSONAL, Me.NOMBRE, Me.APELLIDOS, Me.DNI, Me.TELEFONO1})
        Me.dgvSecc.Location = New System.Drawing.Point(18, 138)
        Me.dgvSecc.Name = "dgvSecc"
        Me.dgvSecc.ReadOnly = True
        Me.dgvSecc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSecc.Size = New System.Drawing.Size(565, 137)
        Me.dgvSecc.TabIndex = 22
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
        'FrmAddPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(595, 391)
        Me.Controls.Add(Me.dgvSecc)
        Me.Controls.Add(Me.PanelPlanes)
        Me.Controls.Add(NOMBRELabel)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.btSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmAddPlan"
        Me.Text = "Asignar Plan de Mantenimiento"
        Me.PanelPlanes.ResumeLayout(False)
        Me.PanelPlanes.PerformLayout()
        CType(Me.dgvSecc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents PanelPlanes As System.Windows.Forms.Panel
    Friend WithEvents btnAddPlan As System.Windows.Forms.Button
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents LabelFecha As System.Windows.Forms.Label
    Friend WithEvents LabelPlan As System.Windows.Forms.Label
    Friend WithEvents cbPlan As System.Windows.Forms.ComboBox
    Friend WithEvents dgvSecc As System.Windows.Forms.DataGridView
    Friend WithEvents IDPERSONAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APELLIDOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DNI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TELEFONO1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
