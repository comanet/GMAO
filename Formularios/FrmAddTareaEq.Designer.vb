<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddTareaEq
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
        Me.LabelEquipo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btTarea = New System.Windows.Forms.Button()
        Me.lbTareas = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LabelEquipo
        '
        Me.LabelEquipo.AutoSize = True
        Me.LabelEquipo.Location = New System.Drawing.Point(13, 13)
        Me.LabelEquipo.Name = "LabelEquipo"
        Me.LabelEquipo.Size = New System.Drawing.Size(62, 52)
        Me.LabelEquipo.TabIndex = 0
        Me.LabelEquipo.Text = "labelEquipo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tareas NO ASIGNADAS"
        '
        'btTarea
        '
        Me.btTarea.Location = New System.Drawing.Point(12, 200)
        Me.btTarea.Name = "btTarea"
        Me.btTarea.Size = New System.Drawing.Size(236, 26)
        Me.btTarea.TabIndex = 3
        Me.btTarea.Text = "Asignar tarea"
        Me.btTarea.UseVisualStyleBackColor = True
        '
        'lbTareas
        '
        Me.lbTareas.FormattingEnabled = True
        Me.lbTareas.Location = New System.Drawing.Point(12, 99)
        Me.lbTareas.Name = "lbTareas"
        Me.lbTareas.Size = New System.Drawing.Size(236, 95)
        Me.lbTareas.TabIndex = 4
        '
        'FrmAddTareaEq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(260, 232)
        Me.Controls.Add(Me.lbTareas)
        Me.Controls.Add(Me.btTarea)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelEquipo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmAddTareaEq"
        Me.Text = "Agregar tarea a Equipo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelEquipo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btTarea As System.Windows.Forms.Button
    Friend WithEvents lbTareas As System.Windows.Forms.ListBox
End Class
