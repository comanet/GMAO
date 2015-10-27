<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddActividad
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
        Me.btActividad = New System.Windows.Forms.Button()
        Me.LabelActividades = New System.Windows.Forms.Label()
        Me.lbActividad = New System.Windows.Forms.ListBox()
        Me.LabelPlan = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btActividad
        '
        Me.btActividad.Location = New System.Drawing.Point(12, 144)
        Me.btActividad.Name = "btActividad"
        Me.btActividad.Size = New System.Drawing.Size(224, 29)
        Me.btActividad.TabIndex = 7
        Me.btActividad.Text = "Insertar IdActividad en BD"
        Me.btActividad.UseVisualStyleBackColor = True
        '
        'LabelActividades
        '
        Me.LabelActividades.AutoSize = True
        Me.LabelActividades.Location = New System.Drawing.Point(9, 27)
        Me.LabelActividades.Name = "LabelActividades"
        Me.LabelActividades.Size = New System.Drawing.Size(206, 13)
        Me.LabelActividades.TabIndex = 6
        Me.LabelActividades.Text = "Actividades que se pueden añadir al Plan:"
        '
        'lbActividad
        '
        Me.lbActividad.FormattingEnabled = True
        Me.lbActividad.Location = New System.Drawing.Point(12, 43)
        Me.lbActividad.Name = "lbActividad"
        Me.lbActividad.Size = New System.Drawing.Size(224, 95)
        Me.lbActividad.TabIndex = 5
        '
        'LabelPlan
        '
        Me.LabelPlan.AutoSize = True
        Me.LabelPlan.Location = New System.Drawing.Point(9, 8)
        Me.LabelPlan.Name = "LabelPlan"
        Me.LabelPlan.Size = New System.Drawing.Size(63, 13)
        Me.LabelPlan.TabIndex = 4
        Me.LabelPlan.Text = "Plan actual:"
        '
        'FrmAddActividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(242, 182)
        Me.Controls.Add(Me.btActividad)
        Me.Controls.Add(Me.LabelActividades)
        Me.Controls.Add(Me.lbActividad)
        Me.Controls.Add(Me.LabelPlan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmAddActividad"
        Me.Text = "Actividades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btActividad As System.Windows.Forms.Button
    Friend WithEvents LabelActividades As System.Windows.Forms.Label
    Friend WithEvents lbActividad As System.Windows.Forms.ListBox
    Friend WithEvents LabelPlan As System.Windows.Forms.Label
End Class
