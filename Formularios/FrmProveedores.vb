Imports System.Text.RegularExpressions

Public Class FrmProveedores

    Public ClasProveedores As New clProveedores

    Dim dtProveedores As DataTable
    Dim dtProvincias As DataTable
    Dim dtPaises As DataTable
    Dim dtEspecialidad As DataTable
    Dim tipoOperacion As String

    Public Sub fillCombo()

        If Not (cbPais.Items.Count > 1) Then
            cnn.Open()

            cbPais.Enabled = True
            cbProvincia.Enabled = True
            cbEspecialidad.Enabled = True

            ' Rellenamos los combos cbPais - cbProvincia - cbEspecialidad
            dtPaises = ClasProveedores.consultaAux("SELECT NOMBREPAIS FROM PAIS ORDER BY NOMBREPAIS", "PAIS")
            For Each row As DataRow In dtPaises.Rows
                cbPais.Items.Add(CStr(row("NOMBREPAIS")))
            Next

            dtProvincias = ClasProveedores.consultaAux("SELECT NOMBREPROV FROM PROVINCIAS ORDER BY NOMBREPROV ASC", "PROVINCIAS")
            For Each row As DataRow In dtProvincias.Rows
                cbProvincia.Items.Add(CStr(row("NOMBREPROV")))
            Next

            dtEspecialidad = ClasProveedores.consultaAux("SELECT NOMBRE FROM ESPECIALIDADES ORDER BY NOMBRE", "ESPECIALIDADES")
            For Each row As DataRow In dtEspecialidad.Rows
                cbEspecialidad.Items.Add(CStr(row("NOMBRE")))
            Next

            cbPais.Enabled = False
            cbProvincia.Enabled = False
            cbEspecialidad.Enabled = False

            cnn.Close()
        End If

    End Sub

    Private Sub FrmProveedores_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub FrmProveedores_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub txt_CP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_CP.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click

        Me.Close()

    End Sub

    Public Function validar_Mail(ByVal sMail As String) As Boolean

        Dim re As Regex = New Regex("^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$", RegexOptions.IgnoreCase)
        Dim m As Match = re.Match(txt_Email.Text)

        If m.Captures.Count = 0 Then
            MessageBox.Show("El email proporcionado no es correcto.")
            Return False
        Else
            Return True
        End If

    End Function

    Public Function validar_URL(ByVal sURL As String) As Boolean

        Dim re As Regex = New Regex("^(https?|ftp|file)://[-A-Z0-9+&@#/%?=~_|!:,.;]*[-A-Z0-9+&@#/%=~_|]", RegexOptions.IgnoreCase)
        Dim m As Match = re.Match(txt_web.Text)

        If m.Captures.Count = 0 Then
            'MessageBox.Show("La dirección web proporcionada no es correcta.")
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub txt_Email_Validated(sender As Object, e As EventArgs) Handles txt_Email.Validated

        If Not (txt_Email.Text.Length = 0) Then
            If Not (validar_Mail(LCase(txt_Email.Text))) Then
                'MessageBox.Show("El email no es válido, debe tener el formato: nombre@dominio.com", "Validación de email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_Email.Text = ""
            End If
        End If

    End Sub

    Private Sub txt_web_Validated(sender As Object, e As EventArgs) Handles txt_web.Validated

        Dim Peticion As System.Net.WebRequest
        Dim Respuesta As System.Net.HttpWebResponse

        If Not (txt_web.Text = "") Then
            ' Prueba que la dirección esté correctamente formada
            If Not (validar_URL(LCase(txt_web.Text))) Then
                If (MessageBox.Show("URL no válida. Debe escribir una dirección válida. ¿Desea escribir otra dirección?", "Validación URL", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
                    txt_web.Text = ""
                    txt_web.Focus()
                    Exit Sub
                Else
                    txt_web.Text = ""
                    txt_Email.Focus()
                    Exit Sub
                End If
            End If

            ' Hace una petición a la dirección indicada para ver si está activa
            Try
                Peticion = System.Net.WebRequest.Create(txt_web.Text)
                Respuesta = Peticion.GetResponse()
            Catch ex As System.Net.WebException
                If ex.Status = Net.WebExceptionStatus.NameResolutionFailure Then
                    If (MessageBox.Show("El Sitio indicado no está activo. ¿Desea escribir otra dirección?", "Validación URL", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes) Then
                        txt_web.Text = ""
                        txt_web.Focus()
                    End If
                Else
                    txt_web.Text = ""
                    txt_Email.Focus()
                End If
            End Try
        End If

    End Sub

    Private Sub FrmProveedores_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        FProveedores = Nothing

        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            errorConn = ex.Message.ToString
        End Try

    End Sub

    Private Sub Limpiabinding()

        Me.txt_ID.DataBindings.Clear()
        Me.txt_Nombre.DataBindings.Clear()
        Me.txt_Direccion.DataBindings.Clear()
        Me.txt_Poblacion.DataBindings.Clear()
        Me.txt_CP.DataBindings.Clear()
        Me.txt_Telefono.DataBindings.Clear()
        Me.txt_web.DataBindings.Clear()
        Me.txt_Email.DataBindings.Clear()

        Me.cbProvincia.DataBindings.Clear()
        Me.cbPais.DataBindings.Clear()
        Me.cbEspecialidad.DataBindings.Clear()

    End Sub

    Private Sub Enlacebin()

        Me.txt_ID.DataBindings.Add("text", ClasProveedores.bsProveedores, "IDPROVEEDOR")
        Me.txt_Nombre.DataBindings.Add("text", ClasProveedores.bsProveedores, "NOMBRE")
        Me.txt_Direccion.DataBindings.Add("text", ClasProveedores.bsProveedores, "DIRECCION")
        Me.txt_Poblacion.DataBindings.Add("text", ClasProveedores.bsProveedores, "POBLACION")
        Me.txt_CP.DataBindings.Add("text", ClasProveedores.bsProveedores, "CPOSTAL")
        Me.txt_Telefono.DataBindings.Add("text", ClasProveedores.bsProveedores, "TELEFONO")
        Me.txt_web.DataBindings.Add("text", ClasProveedores.bsProveedores, "WEB")
        Me.txt_Email.DataBindings.Add("text", ClasProveedores.bsProveedores, "EMAIL")

        Me.cbProvincia.DataBindings.Add("text", ClasProveedores.bsProveedores, "PROVINCIA")
        Me.cbPais.DataBindings.Add("text", ClasProveedores.bsProveedores, "PAIS")
        Me.cbEspecialidad.DataBindings.Add("text", ClasProveedores.bsProveedores, "ESPECIALIDAD")

    End Sub

    Private Sub txt_Telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Telefono.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

    End Sub

    Private Sub FrmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fillCombo()

        ClasProveedores.ConsultaProveedores("SELECT * FROM PROVEEDORES")
        dgvProv.DataSource = ClasProveedores.bsProveedores
        dgvProv.AutoGenerateColumns = True
        dgvProv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        'Asociar los Textbox con el Bindingsource para que muestre los datos.
        Enlacebin()

    End Sub

    Public Sub Actualizar(Optional ByVal bCargar As Boolean = True) ' Se utiliza para limpiar el datagridview y refrescar los datos modificados.

        '*** Actualizar y guardar cambios   
        If Not ClasProveedores.bsProveedores Is Nothing Then
            ClasProveedores.daProveedores.Update(CType(ClasProveedores.bsProveedores.DataSource, DataTable))
            If bCargar Then
                ' dgvProv.Refresh()
                ClasProveedores.dsProveedores.Tables.Clear()
                FrmProveedores_Load(Me, New System.EventArgs)
            End If
        End If

    End Sub

    Private Sub tsDel_Click(sender As Object, e As EventArgs) Handles tsDel.Click

        Dim valor As String

        If MessageBox.Show("¿Esta seguro de que desea ELIMINAR EL REGISTRO SELECCIONADO?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                valor = txt_ID.Text
                Limpiabinding()
                ClasProveedores.Eliminar("PROVEEDORES", "IDPROVEEDOR = " & "'" & valor & "'")
                Actualizar()
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click

        'Añadir Nuevo Registro

        Limpiabinding()

        Me.txt_ID.Text = ""
        Me.txt_Nombre.Text = ""
        Me.txt_Direccion.Text = ""
        Me.txt_Poblacion.Text = ""
        Me.txt_CP.Text = ""
        Me.txt_Telefono.Text = ""
        Me.txt_web.Text = ""
        Me.txt_Email.Text = ""

        Me.cbProvincia.Text = ""
        Me.cbPais.Text = ""
        Me.cbEspecialidad.Text = ""

        Me.txt_ID.ReadOnly = False
        Me.txt_Nombre.ReadOnly = False
        Me.txt_Direccion.ReadOnly = False
        Me.txt_Poblacion.ReadOnly = False
        Me.txt_CP.ReadOnly = False
        Me.txt_Telefono.ReadOnly = False
        Me.txt_web.ReadOnly = False
        Me.txt_Email.ReadOnly = False

        Me.cbProvincia.Enabled = True
        Me.cbPais.Enabled = True
        Me.cbEspecialidad.Enabled = True

        tsEdit.Enabled = False
        tsDel.Enabled = False
        tsNew.Enabled = False
        tsSave.Enabled = True
        tipoOperacion = "A"

    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click

        If tipoOperacion = "A" Then ' Comprueba si es Alta nueva "A" o modificacion "M"
            'ANTES DE GUARDAR COMPROBAR SI REGISTRO YA EXISTE EN BBDD.

            If ClasProveedores.buscaID(Me.txt_ID.Text) = True Then
                MsgBox("Atención, el IDPROVEEDOR ya está siendo utilizado en el Sistema.", MsgBoxStyle.Exclamation)
                ActiveControl = Me.txt_ID
                Me.txt_ID.Text = ""
                Exit Sub  ' Si el ID existe, se vuelve al Textbox para modificar valor.
            End If

            If MessageBox.Show("¿Esta seguro de que desea Guardar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Try
                    If ClasProveedores.InsertaProveedores("Insert Into PROVEEDORES(NOMBRE, ESPECIALIDAD, DIRECCION, POBLACION, PROVINCIA, PAIS, TELEFONO, WEB, EMAIL, CPOSTAL)" & _
                                                   "values(" & "'" & Me.txt_Nombre.Text & "'" & "," & "'" & Me.cbEspecialidad.Text &
                                                   "'" & "," & "'" & Me.txt_Direccion.Text & "'" & "," & "'" & Me.txt_Poblacion.Text &
                                                   "'" & "," & "'" & Me.cbProvincia.Text & "'" & "," & "'" & Me.cbPais.Text &
                                                   "'" & "," & "'" & Me.txt_Telefono.Text & "'" & "," & "'" & Me.txt_web.Text &
                                                   "'" & "," & "'" & Me.txt_Email.Text & "'" & "," & "'" & Me.txt_CP.Text & "'" & ")") = True Then

                        'MsgBox("Registro Agregado Con Exito", MsgBoxStyle.Information)

                        Actualizar()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error " & ex.Message)
                End Try

                Me.txt_ID.ReadOnly = True
                Me.txt_Nombre.ReadOnly = True
                Me.txt_Direccion.ReadOnly = True
                Me.txt_Poblacion.ReadOnly = True
                Me.txt_Telefono.ReadOnly = True
                Me.txt_web.ReadOnly = True
                Me.txt_Email.ReadOnly = True
                Me.txt_CP.ReadOnly = True

                Me.cbProvincia.Enabled = False
                Me.cbPais.Enabled = False
                Me.cbEspecialidad.Enabled = False

                tsSave.Enabled = False
                tsEdit.Enabled = True
                tsNew.Enabled = True
                tsDel.Enabled = True

            End If
        ElseIf tipoOperacion = "M" Then
            If ClasProveedores.actualizar("PROVEEDORES", "NOMBRE = " + "'" + txt_Nombre.Text + "'" + "," + "ESPECIALIDAD =" + "'" + cbEspecialidad.Text + "'" + "," + "DIRECCION= " + "'" + txt_Direccion.Text + "'" + "," + "POBLACION= " + "'" + txt_Poblacion.Text +
                                       "'" + "," + "PROVINCIA = " + "'" + cbProvincia.Text + "'" + "," + "PAIS= " + "'" + cbPais.Text + "'" + "," + "TELEFONO = " + "'" + txt_Telefono.Text + "'" + "," + "WEB= " + "'" + txt_web.Text +
                                       "'" + "," + "EMAIL = " + "'" + txt_Email.Text + "'" + "," + "CPOSTAL= " + "'" + txt_CP.Text + "'", " IDPROVEEDOR= " + "'" + txt_ID.Text + "'") Then

                Actualizar()
                Me.txt_ID.ReadOnly = True
                Me.txt_Nombre.ReadOnly = True
                Me.txt_Direccion.ReadOnly = True
                Me.txt_Poblacion.ReadOnly = True
                Me.txt_Telefono.ReadOnly = True
                Me.txt_web.ReadOnly = True
                Me.txt_Email.ReadOnly = True
                Me.txt_CP.ReadOnly = True

                Me.cbProvincia.Enabled = False
                Me.cbPais.Enabled = False
                Me.cbEspecialidad.Enabled = False

                tsNew.Enabled = True
                tsEdit.Enabled = True
                tsDel.Enabled = True
                tsSave.Enabled = False
                'MsgBox("Registro Modificado Con Exito", MsgBoxStyle.Information)
            End If
        End If

    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click

        Limpiabinding()

        Me.txt_ID.ReadOnly = True
        Me.txt_Nombre.ReadOnly = False
        Me.txt_Direccion.ReadOnly = False
        Me.txt_Poblacion.ReadOnly = False
        Me.txt_Telefono.ReadOnly = False
        Me.txt_web.ReadOnly = False
        Me.txt_Email.ReadOnly = False
        Me.txt_CP.ReadOnly = False

        Me.cbProvincia.Enabled = True
        Me.cbPais.Enabled = True
        Me.cbEspecialidad.Enabled = True

        tsSave.Enabled = True
        tsEdit.Enabled = False
        tsNew.Enabled = False
        tsDel.Enabled = False
        tipoOperacion = "M"

    End Sub
End Class