<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class FrmEntrada
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents lbUsuario As System.Windows.Forms.Label
    Friend WithEvents lbPass As System.Windows.Forms.Label
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEntrada))
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.lbPass = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.lbTitulo2 = New System.Windows.Forms.Label()
        Me.DBCOMBO1 = New System.Windows.Forms.ComboBox()
        Me.lbCentro = New System.Windows.Forms.Label()
        Me.btOK = New System.Windows.Forms.Button()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbUsuario
        '
        Me.lbUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuario.Location = New System.Drawing.Point(386, 95)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(141, 23)
        Me.lbUsuario.TabIndex = 10
        Me.lbUsuario.Text = "&Usuario"
        Me.lbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbPass
        '
        Me.lbPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPass.Location = New System.Drawing.Point(386, 158)
        Me.lbPass.Name = "lbPass"
        Me.lbPass.Size = New System.Drawing.Size(166, 23)
        Me.lbPass.TabIndex = 1
        Me.lbPass.Text = "&Clave"
        Me.lbPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.AcceptsReturn = True
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(386, 184)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(220, 26)
        Me.PasswordTextBox.TabIndex = 2
        '
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbTitulo.Location = New System.Drawing.Point(381, 37)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(95, 22)
        Me.lbTitulo.TabIndex = 8
        Me.lbTitulo.Text = " G.M.A.O."
        '
        'lbTitulo2
        '
        Me.lbTitulo2.AutoSize = True
        Me.lbTitulo2.BackColor = System.Drawing.SystemColors.Window
        Me.lbTitulo2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lbTitulo2.Location = New System.Drawing.Point(106, 158)
        Me.lbTitulo2.Name = "lbTitulo2"
        Me.lbTitulo2.Size = New System.Drawing.Size(74, 19)
        Me.lbTitulo2.TabIndex = 9
        Me.lbTitulo2.Text = "Terminal"
        '
        'DBCOMBO1
        '
        Me.DBCOMBO1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DBCOMBO1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DBCOMBO1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DBCOMBO1.FormattingEnabled = True
        Me.DBCOMBO1.Items.AddRange(New Object() {"  "})
        Me.DBCOMBO1.Location = New System.Drawing.Point(386, 121)
        Me.DBCOMBO1.Name = "DBCOMBO1"
        Me.DBCOMBO1.Size = New System.Drawing.Size(220, 28)
        Me.DBCOMBO1.TabIndex = 0
        '
        'lbCentro
        '
        Me.lbCentro.AutoSize = True
        Me.lbCentro.BackColor = System.Drawing.SystemColors.Window
        Me.lbCentro.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCentro.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbCentro.Location = New System.Drawing.Point(386, 59)
        Me.lbCentro.Name = "lbCentro"
        Me.lbCentro.Size = New System.Drawing.Size(187, 22)
        Me.lbCentro.TabIndex = 10
        Me.lbCentro.Text = "INDUSTRIAS JOVIR"
        '
        'btOK
        '
        Me.btOK.BackColor = System.Drawing.Color.DimGray
        Me.btOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btOK.ForeColor = System.Drawing.Color.White
        Me.btOK.Location = New System.Drawing.Point(385, 230)
        Me.btOK.Name = "btOK"
        Me.btOK.Size = New System.Drawing.Size(93, 36)
        Me.btOK.TabIndex = 11
        Me.btOK.Text = "&Aceptar"
        Me.btOK.UseVisualStyleBackColor = False
        '
        'btSalir
        '
        Me.btSalir.BackColor = System.Drawing.Color.DimGray
        Me.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.ForeColor = System.Drawing.Color.White
        Me.btSalir.Location = New System.Drawing.Point(515, 230)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(91, 36)
        Me.btSalir.TabIndex = 12
        Me.btSalir.Text = "&Salir"
        Me.btSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(176, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "lbUsuario"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(50, 37)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(273, 118)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'FrmEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(632, 293)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.btOK)
        Me.Controls.Add(Me.lbCentro)
        Me.Controls.Add(Me.DBCOMBO1)
        Me.Controls.Add(Me.lbTitulo2)
        Me.Controls.Add(Me.lbTitulo)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.lbPass)
        Me.Controls.Add(Me.lbUsuario)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEntrada"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrada Aplicación"
        Me.TopMost = True
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbTitulo As System.Windows.Forms.Label
    Friend WithEvents lbTitulo2 As System.Windows.Forms.Label
    Friend WithEvents lbCentro As System.Windows.Forms.Label
    Friend WithEvents btOK As System.Windows.Forms.Button
    Friend WithEvents btSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Protected WithEvents DBCOMBO1 As System.Windows.Forms.ComboBox

End Class
