<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddEquipo
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
        Me.LabelPlan = New System.Windows.Forms.Label()
        Me.lbEquipos = New System.Windows.Forms.ListBox()
        Me.LabelEquipos = New System.Windows.Forms.Label()
        Me.btEquipo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelPlan
        '
        Me.LabelPlan.AutoSize = True
        Me.LabelPlan.Location = New System.Drawing.Point(9, 9)
        Me.LabelPlan.Name = "LabelPlan"
        Me.LabelPlan.Size = New System.Drawing.Size(63, 13)
        Me.LabelPlan.TabIndex = 0
        Me.LabelPlan.Text = "Plan actual:"
        '
        'lbEquipos
        '
        Me.lbEquipos.FormattingEnabled = True
        Me.lbEquipos.Location = New System.Drawing.Point(12, 44)
        Me.lbEquipos.Name = "lbEquipos"
        Me.lbEquipos.Size = New System.Drawing.Size(224, 95)
        Me.lbEquipos.TabIndex = 1
        '
        'LabelEquipos
        '
        Me.LabelEquipos.AutoSize = True
        Me.LabelEquipos.Location = New System.Drawing.Point(9, 28)
        Me.LabelEquipos.Name = "LabelEquipos"
        Me.LabelEquipos.Size = New System.Drawing.Size(189, 13)
        Me.LabelEquipos.TabIndex = 2
        Me.LabelEquipos.Text = "Equipos que se pueden añadir al Plan:"
        '
        'btEquipo
        '
        Me.btEquipo.Location = New System.Drawing.Point(12, 145)
        Me.btEquipo.Name = "btEquipo"
        Me.btEquipo.Size = New System.Drawing.Size(224, 29)
        Me.btEquipo.TabIndex = 3
        Me.btEquipo.Text = "Insertar IdEquipo en BD"
        Me.btEquipo.UseVisualStyleBackColor = True
        '
        'FrmAddEquipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(248, 184)
        Me.Controls.Add(Me.btEquipo)
        Me.Controls.Add(Me.LabelEquipos)
        Me.Controls.Add(Me.lbEquipos)
        Me.Controls.Add(Me.LabelPlan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmAddEquipo"
        Me.Text = "Añadir Equipo a Plantilla"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelPlan As System.Windows.Forms.Label
    Friend WithEvents lbEquipos As System.Windows.Forms.ListBox
    Friend WithEvents LabelEquipos As System.Windows.Forms.Label
    Friend WithEvents btEquipo As System.Windows.Forms.Button
End Class
