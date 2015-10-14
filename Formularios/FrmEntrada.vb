
Public Class FrmEntrada
    Dim cldatos As New m_datos ' Definicion de la Clave que contiene metodos manejo de datos.
    Dim dtUsuarios As DataTable ' Tabla que almacena Usuario y Pass de Personal.
    Dim Usuario, Pass As String
    Dim NumeroIntentos As Integer

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub FrmEntrada_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress, PasswordTextBox.KeyPress, DBCOMBO1.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOK.Click
        Dim row As DataRow
        Dim i As Integer

        i = 0 ' si se cumple condificion i= 1
        ' Usuario = DBCOMBO1.Text
        ' Pass = PasswordTextBox.Text
        Usuario = DBCOMBO1.Text
        Pass = PasswordTextBox.Text

        If NumeroIntentos < 2 Then ' Numero maximo intentos password incorrecto.

            For index As Integer = 0 To dtUsuarios.Rows.Count - 1 Step 1 ' Comprobar si existe el pass 
                row = dtUsuarios.Rows(index)
                If Desencriptar(row(1).ToString) = PasswordTextBox.Text And row(0).ToString = DBCOMBO1.Text Then
                    i = 1
                    Exit For
                End If
            Next index
            If i = 0 Then

                MsgBox("Usuario InCorrecto", vbCritical)
                PasswordTextBox.Clear()
                PasswordTextBox.Focus()
                NumeroIntentos += 1

            ElseIf i = 1 Then
                Me.Hide()
                FrmPrincipal.ToolStripStatusLabel3.Text = Usuario
                FrmPrincipal.ShowDialog()

            End If
            desconectaBD()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub FrmEntrada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try ' COMPROBAMOS LA CONEXION CON LA BBDD ACTIVA.
            ConectaBD()
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
            MsgBox("Error de conexion a BBDD. Por favor comprueba configuración", MsgBoxStyle.Critical, "Aplicaciones Jovir")
        End Try

        Label1.Text = Environment.MachineName ' Nombre pc que entra al sistema.
        'Environment.UserName ' Nombre usuario windows que accede.
        dtUsuarios = cldatos.consultar2("Select Usuario,Passwd From Usuarios Where ACT = 'True'", "tblUsuarios")
        ' Cargar el combo con los valores de la tabla Personal.
        DBCOMBO1.DataSource = dtUsuarios
        DBCOMBO1.DisplayMember = dtUsuarios.Columns(0).Caption.ToString
        DBCOMBO1.SelectedIndex = -1
        NumeroIntentos = 0 ' Intentos disponibles antes de Cerrar.
        desconectaBD()


        'Me.Text = (configApp.GetValue("AplicationTitulo", GetType(String)))
        ' Leer la ruta de la BBDD del fichero XML app.config
        'Dim configurationAppSettings As System.Configuration.AppSettingsReader
        'configurationAppSettings = New System.Configuration.AppSettingsReader
        ' bt2.Text = CType(configurationAppSettings.GetValue("NBoton", GetType(System.String)), String)
        'Me.Text = CType(configurationAppSettings.GetValue("cadenaconexion", GetType(System.String)), String)
        'MsgBox(CType(configurationAppSettings.GetValue("cadenaconexion", GetType(System.String)), String))



    End Sub

    Private Sub btSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

End Class
