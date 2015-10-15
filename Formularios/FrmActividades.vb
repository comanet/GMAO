Imports System.Data.SqlClient

Public Class FrmActividades

    Public ClasActividades As New clActividades

    Dim dtEspecialidades As DataTable
    Dim dtTiposMantenimiento As DataTable
    Dim dtFrecuencias As DataTable
    Dim tipoOperacion As String

    Private Sub FrmActividades_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub FrmActividades_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub FrmActividades_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        FEquipos = Nothing

    End Sub

    Private Sub Limpiabinding()

        Me.txt_ID.DataBindings.Clear()
        Me.txt_Nombre.DataBindings.Clear()
        Me.txt_DESCRIPCION.DataBindings.Clear()
        Me.cbEspe.DataBindings.Clear()
        Me.cbTMant.DataBindings.Clear()
        Me.cbFrec.DataBindings.Clear()

    End Sub

    Public Sub Actualizar(Optional ByVal bCargar As Boolean = True) ' Se utiliza para limpiar el datagridview y refrescar los datos modificados.

        '*** Actualizar y guardar cambios   
        If Not ClasActividades.bsActividades Is Nothing Then
            ClasActividades.daActividades.Update(CType(ClasActividades.bsActividades.DataSource, DataTable))
            If bCargar Then
                dgvSecc.Refresh()
                ClasActividades.dsActividades.Tables.Clear()
                FrmActividades_Load(Me, New System.EventArgs)
            End If
        End If

    End Sub

    Private Sub Enlacebin()

        Me.txt_ID.DataBindings.Add("text", ClasActividades.bsActividades, "IDACTIVIDAD")
        Me.txt_NOMBRE.DataBindings.Add("text", ClasActividades.bsActividades, "NOMBRE")
        Me.txt_DESCRIPCION.DataBindings.Add("text", ClasActividades.bsActividades, "DESCRIPCION")

        Me.cbEspe.DataBindings.Add("text", ClasActividades.bsActividades, "IDESPECIALIDAD")
        Me.cbTMant.DataBindings.Add("text", ClasActividades.bsActividades, "IdTipOT")
        Me.cbFrec.DataBindings.Add("text", ClasActividades.bsActividades, "IDFRECUENCIA")

    End Sub

    Private Sub CargaCombosActividades()

        Try
            cbEspe.Items.Clear()
            dtEspecialidades = ClasActividades.consultaAux("SELECT NOMBRE FROM ESPECIALIDADES", "tbl_ESPECIALIDADES")
            For Each row As DataRow In dtEspecialidades.Rows
                cbEspe.Items.Add(CStr(row("NOMBRE")))
            Next

            cbTMant.Items.Clear()
            dtTiposMantenimiento = ClasActividades.consultaAux("SELECT Descripcion FROM TIPOTS", "tbl_TIPOTS")
            For Each row As DataRow In dtTiposMantenimiento.Rows
                cbTMant.Items.Add(CStr(row("Descripcion")))
            Next

            cbFrec.Items.Clear()
            dtFrecuencias = ClasActividades.consultaAux("SELECT DESCRIPCION FROM FRECUENCIAS", "tbl_FRECUENCIAS")
            For Each row As DataRow In dtFrecuencias.Rows
                cbFrec.Items.Add(CStr(row("DESCRIPCION")))
            Next
        Catch
            MessageBox.Show("Error al cargar los combos de Actividades")
        End Try

    End Sub

    Private Sub FrmActividades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargaCombosActividades()

        ClasActividades.ConsultaActividades("SELECT * FROM ACTIVIDADES")
        dgvSecc.DataSource = ClasActividades.bsActividades
        dgvSecc.AutoGenerateColumns = True

        'Asociar los Textbox con el Bindingsource para que muestre los datos.
        Enlacebin()

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click

        Me.Close()

    End Sub

    Private Sub tsDel_Click(sender As Object, e As EventArgs) Handles tsDel.Click

        Dim valor As String

        If MessageBox.Show("¿Esta seguro de que desea Eliminar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                valor = txt_ID.Text
                Limpiabinding()
                ClasActividades.Eliminar("ACTIVIDADES", "IDACTIVIDAD = " & "'" & valor & "'")
                Actualizar()
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click

        If tipoOperacion = "A" Then ' Comprueba si es Alta nueva "A" o modificacion "M"
            'aNTES DE GUARDAR COMPROBAR SI REGISTRO YA EXISTE EN BBDD.
            '  MsgBox(ClasEquipos.buscaID(Me.txt_ID.Text))

            If ClasActividades.buscaID(Me.txt_ID.Text) = True Then
                MsgBox("Atención, el IdActividad ya está siendo utilizado en el Sistema.", MsgBoxStyle.Exclamation)
                ActiveControl = Me.txt_ID
                Me.txt_ID.Text = ""
                Exit Sub  ' Si el ID existe, se vuelve al Textbox para modificar valor.
            End If

            If MessageBox.Show("¿Esta seguro de que desea Guardar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Try
                    If ClasActividades.InsertaActividades("Insert Into ACTIVIDADES(NOMBRE,DESCRIPCION,IdTipOT,IDFRECUENCIA,IDESPECIALIDAD)" & _
                                                   "values(" & "'" & Me.txt_NOMBRE.Text & "'" & "," & "'" & Me.txt_DESCRIPCION.Text & "'" & "," & "'" & Me.cbEspe.ValueMember.ToString &
                                                   "'" & "," & "'" & Me.cbFrec.ValueMember.ToString & "'" & "," & "'" & Me.cbTMant.ValueMember.ToString & "'" & ")") = True Then

                        MsgBox("Registro Agregado Con Exito", MsgBoxStyle.Information)

                        Actualizar()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error " & ex.Message)
                End Try

                Me.txt_ID.ReadOnly = True
                Me.txt_NOMBRE.ReadOnly = True
                Me.txt_DESCRIPCION.ReadOnly = True

                Me.cbEspe.Enabled = False
                Me.cbFrec.Enabled = False
                Me.cbTMant.Enabled = False

                tsSave.Enabled = False
                tsEdit.Enabled = True
                tsNew.Enabled = True
                tsDel.Enabled = True

            End If
        ElseIf tipoOperacion = "M" Then
            If ClasActividades.actualizar("ACTIVIDADES", "NOMBRE = " + "'" + txt_NOMBRE.Text + "'" + "," + "DESCRIPCION =" + "'" + txt_DESCRIPCION.Text + "'" + "," + "IdTipOT= " + "'" + cbTMant.Text + "'" + "," + "IDFRECUENCIA= " + "'" + cbFrec.Text +
                                       "'" + "," + "IDESPECIALIDAD = " + "'" + cbEspe.Text + "'", " IDACTIVIDAD= " + "'" + txt_ID.Text + "'") Then

                Actualizar()
                Me.txt_ID.ReadOnly = True
                Me.txt_NOMBRE.ReadOnly = True
                Me.txt_DESCRIPCION.ReadOnly = True

                Me.cbEspe.Enabled = False
                Me.cbTMant.Enabled = False
                Me.cbFrec.Enabled = False

                tsNew.Enabled = True
                tsDel.Enabled = True
                tsSave.Enabled = False
                MsgBox("Registro Modificado Con Exito", MsgBoxStyle.Information)
            End If
        End If

    End Sub

    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click

        'Añadir Nuevo Registro

        Limpiabinding()
        Me.txt_ID.Text = ""
        Me.txt_NOMBRE.Text = ""
        Me.txt_DESCRIPCION.Text = ""

        Me.cbEspe.Text = ""
        Me.cbTMant.Text = ""
        Me.cbFrec.Text = ""

        'Me.txt_ID.ReadOnly = False
        Me.txt_NOMBRE.ReadOnly = False
        Me.txt_DESCRIPCION.ReadOnly = False

        Me.cbEspe.Enabled = True
        Me.cbTMant.Enabled = True
        Me.cbFrec.Enabled = True

        CargaCombosActividades()

        tsEdit.Enabled = False
        tsDel.Enabled = False
        tsSave.Enabled = True
        tipoOperacion = "A"

    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click

        Limpiabinding()

        'Me.txt_ID.ReadOnly = False
        Me.txt_NOMBRE.ReadOnly = False
        Me.txt_DESCRIPCION.ReadOnly = False

        Me.cbEspe.Enabled = True
        Me.cbTMant.Enabled = True
        Me.cbFrec.Enabled = True

        CargaCombosActividades()

        tsSave.Enabled = True
        tsNew.Enabled = False
        tsDel.Enabled = False
        tipoOperacion = "M"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim valor As String

        valor = cbEspe.SelectedValue.ToString

        If Not (valor Is Nothing) Then
            MessageBox.Show(valor)
        End If

    End Sub
End Class