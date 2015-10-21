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
        Me.LabelFecha = New System.Windows.Forms.Label()
        Me.LabelPlan = New System.Windows.Forms.Label()
        Me.cbPlan = New System.Windows.Forms.ComboBox()
        Me.dgvSecc = New System.Windows.Forms.DataGridView()
        Me.dtpFInicio = New System.Windows.Forms.DateTimePicker()
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
        Me.btSalir.Location = New System.Drawing.Point(660, 343)
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
        Me.txt_Nombre.Size = New System.Drawing.Size(659, 26)
        Me.txt_Nombre.TabIndex = 13
        '
        'PanelPlanes
        '
        Me.PanelPlanes.AutoScroll = True
        Me.PanelPlanes.Controls.Add(Me.dtpFInicio)
        Me.PanelPlanes.Controls.Add(Me.btnAddPlan)
        Me.PanelPlanes.Controls.Add(Me.LabelFecha)
        Me.PanelPlanes.Controls.Add(Me.LabelPlan)
        Me.PanelPlanes.Controls.Add(Me.cbPlan)
        Me.PanelPlanes.Location = New System.Drawing.Point(18, 57)
        Me.PanelPlanes.Name = "PanelPlanes"
        Me.PanelPlanes.Size = New System.Drawing.Size(733, 90)
        Me.PanelPlanes.TabIndex = 14
        '
        'btnAddPlan
        '
        Me.btnAddPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPlan.Location = New System.Drawing.Point(442, 17)
        Me.btnAddPlan.Name = "btnAddPlan"
        Me.btnAddPlan.Size = New System.Drawing.Size(288, 43)
        Me.btnAddPlan.TabIndex = 4
        Me.btnAddPlan.Text = "Asignar Plantilla a "
        Me.btnAddPlan.UseVisualStyleBackColor = True
        '
        'LabelFecha
        '
        Me.LabelFecha.AutoSize = True
        Me.LabelFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFecha.Location = New System.Drawing.Point(3, 43)
        Me.LabelFecha.Name = "LabelFecha"
        Me.LabelFecha.Size = New System.Drawing.Size(107, 17)
        Me.LabelFecha.TabIndex = 2
        Me.LabelFecha.Text = "Fecha de inicio:"
        '
        'LabelPlan
        '
        Me.LabelPlan.AutoSize = True
        Me.LabelPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPlan.Location = New System.Drawing.Point(3, 17)
        Me.LabelPlan.Name = "LabelPlan"
        Me.LabelPlan.Size = New System.Drawing.Size(144, 17)
        Me.LabelPlan.TabIndex = 1
        Me.LabelPlan.Text = "Planes no asignados:"
        '
        'cbPlan
        '
        Me.cbPlan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbPlan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlan.FormattingEnabled = True
        Me.cbPlan.Location = New System.Drawing.Point(153, 17)
        Me.cbPlan.Name = "cbPlan"
        Me.cbPlan.Size = New System.Drawing.Size(264, 21)
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
        Me.dgvSecc.Location = New System.Drawing.Point(18, 153)
        Me.dgvSecc.Name = "dgvSecc"
        Me.dgvSecc.ReadOnly = True
        Me.dgvSecc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSecc.Size = New System.Drawing.Size(733, 184)
        Me.dgvSecc.TabIndex = 22
        '
        'dtpFInicio
        '
        Me.dtpFInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFInicio.Location = New System.Drawing.Point(153, 41)
        Me.dtpFInicio.Name = "dtpFInicio"
        Me.dtpFInicio.Size = New System.Drawing.Size(264, 22)
        Me.dtpFInicio.TabIndex = 23
        '
        'FrmAddPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(763, 391)
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
    Friend WithEvents LabelFecha As System.Windows.Forms.Label
    Friend WithEvents LabelPlan As System.Windows.Forms.Label
    Friend WithEvents cbPlan As System.Windows.Forms.ComboBox
    Friend WithEvents dgvSecc As System.Windows.Forms.DataGridView
    Friend WithEvents dtpFInicio As System.Windows.Forms.DateTimePicker
End Class
