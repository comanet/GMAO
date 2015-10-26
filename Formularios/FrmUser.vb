Imports System.Text.RegularExpressions

Public Class FrmUser

    Public ClasUser As New clUser
    Dim dtPerfil As DataTable
    Dim tipoOperacion As String

    Private Sub FrmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ClasUser.ConsultaUser("SELECT NOMBRE,USUARIO,PASSWD,ACT,PERFIL,EMAIL FROM USUARIOS ")
        dgvUser.DataSource = ClasUser.bsUser
        dgvUser.AutoGenerateColumns = True
        dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        'Asociar los Textbox con el Bindingsource para que muestre los datos.
        Enlacebin()

    End Sub

    Private Sub FrmUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub FrmUser_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click

        Me.Close()

    End Sub

    Private Sub FrmUser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        FUser = Nothing

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
        Me.txt_Nom.DataBindings.Clear()
        Me.txt_pass.DataBindings.Clear()
        Me.cbPerfil.DataBindings.Clear()
        Me.cbox1.DataBindings.Clear()
        Me.txt_email.DataBindings.Clear()
        Me.cbox1.DataBindings.Clear()

    End Sub

    Private Sub Enlacebin()

        Me.txt_ID.DataBindings.Add("text", ClasUser.bsUser, "USUARIO")
        Me.txt_Nom.DataBindings.Add("text", ClasUser.bsUser, "NOMBRE")
        Me.txt_pass.DataBindings.Add("text", ClasUser.bsUser, "PASSWD")
        Me.cbPerfil.DataBindings.Add("text", ClasUser.bsUser, "PERFIL")
        Me.txt_email.DataBindings.Add("text", ClasUser.bsUser, "EMAIL")
        Me.cbox1.DataBindings.Add("checked", ClasUser.bsUser, "ACT")

    End Sub

    Public Sub Actualizar(Optional ByVal bCargar As Boolean = True) ' Se utiliza para refrescar los datos modificados.

        '*** Actualizar y guardar cambios   
        If Not ClasUser.bsUser Is Nothing Then
            ClasUser.daUser.Update(CType(ClasUser.bsUser.DataSource, DataTable))
            If bCargar Then
                ClasUser.dsUser.Tables.Clear()
                FrmUser_Load(Me, New System.EventArgs)
            End If
        End If

    End Sub

    Private Sub tsDel_Click(sender As Object, e As EventArgs) Handles tsDel.Click

        Dim valor As String

        If MessageBox.Show("¿Esta seguro de que desea Eliminar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                valor = txt_ID.Text
                Limpiabinding()
                ClasUser.Eliminar("USUARIOS", "USUARIO = " & "'" & valor & "'")
                Actualizar()
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message.ToString)
            End Try
        End If

    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click
        ' Editar Datos de Usuario.

        Limpiabinding()
        Me.txt_ID.ReadOnly = True
        Me.txt_Nom.ReadOnly = False
        Me.txt_pass.ReadOnly = False
        Me.txt_email.ReadOnly = False
        Me.cbPerfil.Enabled = True
        Me.cbox1.Enabled = True

        dtPerfil = ClasUser.consultaAux("SELECT DESCRIPCION FROM PERFILES", "tbl_PERFILES")
        For Each row As DataRow In dtPerfil.Rows
            cbPerfil.Items.Add(CStr(row("DESCRIPCION")))
        Next

        tsSave.Enabled = True
        tsNew.Enabled = False
        tsDel.Enabled = False
        tipoOperacion = "M"

    End Sub

    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click

        Limpiabinding()
        Me.txt_ID.Text = ""
        Me.txt_Nom.Text = ""
        Me.txt_pass.Text = ""
        Me.cbPerfil.Text = ""
        Me.cbox1.Checked = True
        Me.txt_email.Text = ""

        Me.txt_ID.ReadOnly = False
        Me.txt_Nom.ReadOnly = False
        Me.txt_pass.ReadOnly = False
        Me.txt_email.ReadOnly = False
        Me.cbPerfil.Enabled = True
        Me.cbox1.Enabled = True

        dtPerfil = ClasUser.consultaAux("SELECT DESCRIPCION FROM PERFILES", "tbl_PERFILES")
        For Each row As DataRow In dtPerfil.Rows
            cbPerfil.Items.Add(CStr(row("DESCRIPCION")))
        Next
        dtPerfil.Clear() ' Limpia Tabla.
        tsEdit.Enabled = False
        tsDel.Enabled = False
        tsSave.Enabled = True
        tipoOperacion = "A"
        ActiveControl = Me.txt_ID

    End Sub

    Private Sub txt_ID_Leave(sender As Object, e As EventArgs) Handles txt_ID.Leave

        Dim dtUser As DataTable
        Dim row As DataRow

        dtUser = ClasUser.ConsultaUserTabla("SELECT USUARIO FROM USUARIOS", "USUARIOS")
        For index As Integer = 0 To dtUser.Rows.Count - 1 Step 1 ' Comprobar si existe el pass 
            row = dtUser.Rows(index)

            If row(0).ToString = Me.txt_ID.Text Then
                MsgBox("Usuario ya Existe en el Sistema, pruebe con otro", MsgBoxStyle.Information)
                Me.txt_ID.Text = ""
                ActiveControl = Me.txt_ID
            End If
            ' MsgBox(row(0).ToString)
        Next index

    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click

        Dim passmd5 As String

        If tipoOperacion = "A" Then ' Comprueba si es Alta nueva "A" o modificacion "M"
            passmd5 = Encriptar(Me.txt_pass.Text)
            If MessageBox.Show("¿Esta seguro de que desea Guardar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Try
                    If ClasUser.InsertaUser("Insert Into USUARIOS(USUARIO,NOMBRE,PASSWD,ACT,PERFIL,EMAIL) values(" & "'" & Me.txt_ID.Text & "'" & "," & "'" & Me.txt_Nom.Text & "'" & "," &
                                            "'" & passmd5 & "'" & "," & "'" & Me.cbox1.Checked.ToString & "'" & "," & "'" & Me.cbPerfil.Text & "'" & "," & "'" & Me.txt_email.Text & "'" & ")") = True Then
                        'MsgBox("Registro Agregado Con Exito", MsgBoxStyle.Information)
                        ' Para actualizar los valores nuevos insertados y que se muestren en el dvgrid
                        Actualizar()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error " & ex.Message)
                End Try
                txt_ID.ReadOnly = True
                txt_Nom.ReadOnly = True
                txt_pass.ReadOnly = True
                txt_email.ReadOnly = True
                cbox1.Enabled = False
                cbPerfil.Enabled = False

                tsSave.Enabled = False
                'tsDel.Enabled = False
                tsEdit.Enabled = True
                tsSave.Enabled = True
                tsNew.Enabled = True
                tsDel.Enabled = True
            End If
        ElseIf tipoOperacion = "M" Then
            ' de momento no actualizo el password, para encryptar y desencriptar bien.
            If ClasUser.actualizar("USUARIOS", "NOMBRE = " + "'" + txt_Nom.Text + "'" + "," + "PERFIL= " + "'" + cbPerfil.Text + "'" +
                                   "," + "EMAIL= " + "'" + txt_email.Text + "'" + "," + "ACT=" + "'" + cbox1.Checked.ToString + "'", "USUARIO = " + "'" + txt_ID.Text + "'") Then
                Actualizar()
                txt_ID.ReadOnly = True
                txt_Nom.ReadOnly = True
                txt_pass.ReadOnly = True
                cbox1.Enabled = True
                txt_email.ReadOnly = True
                cbox1.Enabled = False
                cbPerfil.Enabled = False
                cbox1.Enabled = False

                tsNew.Enabled = True
                tsDel.Enabled = True
                tsSave.Enabled = False
                'MsgBox("Registro Modificado Con Exito", MsgBoxStyle.Information)
            End If
        End If

    End Sub

    Private Sub txt_pass_Leave(sender As Object, e As EventArgs) Handles txt_pass.Leave
        'Label2.Text = Encriptar(txt_pass.Text)
        'Label4.Text = Desencriptar(Label2.Text)
    End Sub

    Public Function validar_Mail(ByVal sMail As String) As Boolean

        Dim re As Regex = New Regex("^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$", RegexOptions.IgnoreCase)
        Dim m As Match = re.Match(txt_email.Text)

        If m.Captures.Count = 0 Then
            MessageBox.Show("El email proporcionado no es correcto.")
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub txt_email_Validated(sender As Object, e As EventArgs) Handles txt_email.Validated

        If Not (txt_email.Text.Length = 0) Then
            If Not (validar_Mail(LCase(txt_email.Text))) Then
                MessageBox.Show("El email no es válido, debe tener el formato: nombre@dominio.com", "Validación de email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_email.Text = ""
            End If
        End If

    End Sub
End Class