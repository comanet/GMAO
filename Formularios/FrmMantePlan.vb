Imports System.Data.SqlClient

Public Class FrmMantePlan

    Public ClasMantePlan As New clMantePlan

    Dim tipoOperacion As String
    Dim noMod As Boolean = False

    Private Sub FrmMantePlan_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub FrmMantePlan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub FrmMantePlan_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        FMantePlan = Nothing

        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub limpiaDataGrid()

        dgvManteP.DataSource = Nothing
        dgvManteP.Rows.Clear()
        dgvEquipos.DataSource = Nothing
        dgvEquipos.Rows.Clear()
        dgvActividades.DataSource = Nothing
        dgvActividades.Rows.Clear()

    End Sub

    Private Sub FrmMantePlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        limpiaDataGrid()

        ClasMantePlan.ConsultaMantePlan("SELECT DISTINCT * FROM MANTEPLAN")
        dgvManteP.DataSource = ClasMantePlan.bsMantePlan
        dgvManteP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        'Asociar los Textbox con el Bindingsource para que muestre los datos.
        Enlacebin()

    End Sub

    Private Sub Limpiabinding()

        Me.txt_ID.DataBindings.Clear()
        Me.txt_NOMBRE.DataBindings.Clear()
        Me.txt_DESCRIPCION.DataBindings.Clear()

    End Sub

    Private Sub Enlacebin()

        Me.txt_ID.DataBindings.Add("text", ClasMantePlan.bsMantePlan, "IDPLAN")
        Me.txt_NOMBRE.DataBindings.Add("text", ClasMantePlan.bsMantePlan, "NOMBRE")
        Me.txt_DESCRIPCION.DataBindings.Add("text", ClasMantePlan.bsMantePlan, "DESCRIPCION")
        strIdPlan = txt_ID.Text

    End Sub

    Public Sub Actualizar(Optional ByVal bCargar As Boolean = True) ' Se utiliza para limpiar el datagridview y refrescar los datos modificados.

        '*** Actualizar y guardar cambios

        If Not (ClasMantePlan.bsMantePlan Is Nothing) And (ClasMantePlan.bsActiv Is Nothing) And (ClasMantePlan.bsActiv Is Nothing) Then
            ClasMantePlan.daMantePlan.Update(CType(ClasMantePlan.bsMantePlan.DataSource, DataTable))
            ClasMantePlan.daEquipos.Update(CType(ClasMantePlan.bsEquipos.DataSource, DataTable))
            ClasMantePlan.daActiv.Update(CType(ClasMantePlan.bsActiv.DataSource, DataTable))
            If bCargar Then
                dgvManteP.Refresh()
                ClasMantePlan.dsMantePlan.Tables.Clear()
                dgvEquipos.Refresh()
                ClasMantePlan.dsEquipos.Tables.Clear()
                dgvActividades.Refresh()
                ClasMantePlan.dsActiv.Tables.Clear()
                FrmMantePlan_Load(Me, New System.EventArgs)
            End If
        End If

    End Sub

    Private Sub tsDel_Click(sender As Object, e As EventArgs) Handles tsDel.Click

        Dim valor As String

        If MessageBox.Show("¿Esta seguro de que desea Eliminar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                valor = Trim(txt_ID.Text)
                Limpiabinding()
                ClasMantePlan.Eliminar("MANTEPLAN", "IDPLAN LIKE " & "'" & valor & "%'")
                Actualizar()
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click

        Me.Close()

    End Sub

    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click

        'Añadir Nuevo Registro

        Limpiabinding()
        Me.txt_ID.Text = ""
        Me.txt_DESCRIPCION.Text = ""
        Me.txt_NOMBRE.Text = ""

        'Me.txt_ID.ReadOnly = False
        Me.txt_DESCRIPCION.ReadOnly = False
        Me.txt_NOMBRE.ReadOnly = False

        tsEdit.Enabled = False
        tsDel.Enabled = False
        tsSave.Enabled = True
        tipoOperacion = "A"
        noMod = True

    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click

        Dim query As String

        If tipoOperacion = "A" Then ' Comprueba si es Alta nueva "A" o modificacion "M"
            'ANTES DE GUARDAR COMPROBAR SI REGISTRO YA EXISTE EN BBDD.

            If ClasMantePlan.buscaID(Me.txt_ID.Text) Then
                MsgBox("Atención, el IDPLAN ya está siendo utilizado en el Sistema.", MsgBoxStyle.Exclamation)
                ActiveControl = Me.txt_ID
                Me.txt_ID.Text = ""
                Me.txt_ID.Focus()
                Exit Sub  ' Si el ID existe, se vuelve al Textbox para modificar valor.
            End If

            If MessageBox.Show("¿Esta seguro de que desea Guardar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Try
                    query = "INSERT INTO MANTEPLAN(IDPLAN,NOMBRE,DESCRIPCION) " & _
                       "VALUES('" & Me.txt_ID.Text & "', '" & Me.txt_NOMBRE.Text & "', '" & Me.txt_DESCRIPCION.Text & "')"
                    MessageBox.Show(query)
                    Clipboard.SetText(query)
                    If ClasMantePlan.InsertaMantePLan(query) Then

                        MsgBox("Registro Agregado correctamente", MsgBoxStyle.Information)

                        Actualizar()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error " & ex.Message)
                End Try

                Me.txt_ID.ReadOnly = True
                Me.txt_NOMBRE.ReadOnly = True
                Me.txt_DESCRIPCION.ReadOnly = True

                tsSave.Enabled = False
                tsEdit.Enabled = True
                tsNew.Enabled = True
                tsDel.Enabled = True

            End If
        Else
            If tipoOperacion = "M" Then
                query = "IDPLAN = " + "'" + txt_ID.Text + "'" + "," + "NOMBRE = " + "'" + txt_NOMBRE.Text + "'" + "," + "DESCRIPCION = " + "'" + txt_DESCRIPCION.Text + "'"
                'MessageBox.Show(query)
                If ClasMantePlan.actualizar("MANTEPLAN", query, " IDPLAN LIKE " + "'" + Trim(txt_ID.Text) + "%'") Then Actualizar()
                Me.txt_ID.ReadOnly = True
                Me.txt_DESCRIPCION.ReadOnly = True
                Me.txt_NOMBRE.ReadOnly = True

                tsNew.Enabled = True
                tsDel.Enabled = True
                tsSave.Enabled = False
                'MsgBox("Registro Modificado Con Exito", MsgBoxStyle.Information)
            End If
        End If

        Try
            If (cnn.State = ConnectionState.Open) Then
                cnn.Close()
            End If
        Catch ex As Exception
            errorConn = ex.Message.ToString
        End Try

        noMod = False

    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click

        Limpiabinding()

        'Me.txt_ID.ReadOnly = False
        Me.txt_DESCRIPCION.ReadOnly = False
        Me.txt_NOMBRE.ReadOnly = False

        tsSave.Enabled = True
        tsNew.Enabled = False
        tsDel.Enabled = False
        tipoOperacion = "M"

    End Sub

    Private Sub txt_ID_TextChanged(sender As Object, e As EventArgs) Handles txt_ID.TextChanged

        Dim sql As String

        If noMod Then
            sql = ""
            cargaGrids()
            TabControl1.SelectTab(TabEquipos)

            'Mostramos PLANTILLAS.IDPLANTILLA EN txt_IDPLANTILLA.Text

            cargaIdPlantilla()

            'strIndex = ClasMantePlan.consultaAux(sql, "IDPLANTILLA").Rows(0).Item(0).ToString
        End If

    End Sub

    Public Sub cargaIdPlantilla()

        ' Muestra el IdPlantilla según los datos mostrado en el FORM
        Dim sql As String

        'Mostramos PLANTILLAS.IDPLANTILLA EN txt_IDPLANTILLA.Text

        sql = "SELECT IDPLANTILLA " _
            & "FROM PLANTILLAS " _
            & "WHERE IDPLAN LIKE '" & Trim(txt_ID.Text) & "%' "

        If dgvEquipos.RowCount > 1 Then
            IdEquipo = dgvEquipos.Rows(dgvEquipos.CurrentCell.RowIndex).Cells(0).Value.ToString
            sql = sql & "AND IDEQUIPO LIKE '" & IdEquipo & "%' "
        Else
            IdEquipo = ""
            sql = sql & "AND IDEQUIPO IS NULL "
        End If

        If dgvActividades.RowCount > 1 Then
            IdActividad = dgvActividades.Rows(dgvActividades.CurrentCell.RowIndex).Cells(0).Value.ToString
            sql = sql & "AND IDACTIVIDAD LIKE '" & IdActividad & "%' "
        Else
            IdActividad = ""
            sql = sql & "AND IDACTIVIDAD IS NULL "
        End If

        sql = sql & "ORDER BY IDPLANTILLA DESC"

        'Clipboard.SetText(sql)
        'MessageBox.Show(sql)

    End Sub

    Private Sub cargaGrids()

        ' Actualiza los dataGridView dgvEquipos y dgvActividades según IdPlantilla
        Dim consulta As String

        strIdPlan = Trim(txt_ID.Text)

        dgvEquipos.DataSource = Nothing
        dgvEquipos.Rows.Clear()
        dgvActividades.DataSource = Nothing
        dgvActividades.Rows.Clear()

        ' EQUIPOS
        consulta = "SELECT DISTINCT EQUIPOS.IDEQUIPO, EQUIPOS.NOMBRE AS NombreEquipo  " _
            & "FROM EQUIPOS INNER JOIN PLANTILLAS " _
            & "ON EQUIPOS.IDEQUIPO=PLANTILLAS.IDEQUIPO " _
            & "WHERE PLANTILLAS.IDPLAN LIKE '" & Trim(strIdPlan) & "%' " _
            & "ORDER BY NombreEquipo ASC"

        dgvEquipos.AutoGenerateColumns = True
        dgvEquipos.DataSource = ClasMantePlan.consultaAux(consulta, "EQUIPOS_PLAN")
        dgvEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        If dgvEquipos.RowCount > 1 Then
            IdEquipo = dgvEquipos.Rows(dgvEquipos.CurrentCell.RowIndex).Cells(0).Value.ToString
            'MessageBox.Show(IdEquipo)
        Else
            IdEquipo = ""
        End If

        ' ACTIVIDADES
        consulta = "SELECT ACTIVIDADES.IDACTIVIDAD, ACTIVIDADES.NOMBRE AS NombreActividad " _
                & "FROM ACTIVIDADES INNER JOIN PLANTILLAS " _
                & "ON ACTIVIDADES.IDACTIVIDAD=PLANTILLAS.IDACTIVIDAD " _
                & "INNER JOIN EQUIPOS " _
                & "ON EQUIPOS.IDEQUIPO=PLANTILLAS.IDEQUIPO " _
                & "WHERE PLANTILLAS.IDPLAN LIKE '" & Trim(strIdPlan) & "%' " _
                & "AND EQUIPOS.IDEQUIPO LIKE '" & Trim(IdEquipo) & "%' " _
                & "ORDER BY IDPLAN ASC"

        'Clipboard.SetText(consulta)
        'MessageBox.Show(consulta)
        dgvActividades.AutoGenerateColumns = True
        dgvActividades.DataSource = ClasMantePlan.consultaAux(consulta, "ACTIVIDADES_PLAN")
        dgvActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        If dgvActividades.RowCount > 1 Then
            IdActividad = dgvActividades.Rows(dgvActividades.CurrentCell.RowIndex).Cells(dgvActividades.CurrentCell.ColumnIndex).Value.ToString
            'MessageBox.Show(IdActividad)
        Else
            IdActividad = ""
        End If

    End Sub

    Public Sub cargaTareas()

        ' Carga listado de las tareas de IdPlantilla e IdEquipo en el dataGridView dgvActividades
        Dim consulta As String

        If dgvEquipos.RowCount > 1 Then
            IdEquipo = dgvEquipos.Rows(dgvEquipos.CurrentCell.RowIndex).Cells(0).Value.ToString
            'MessageBox.Show(IdActividad)
        Else
            IdEquipo = ""
        End If
        strIdPlan = Trim(txt_ID.Text)

        ' ACTIVIDADES
        consulta = "SELECT ACTIVIDADES.IDACTIVIDAD, ACTIVIDADES.NOMBRE AS NombreActividad " _
                & "FROM ACTIVIDADES INNER JOIN PLANTILLAS " _
                & "ON ACTIVIDADES.IDACTIVIDAD=PLANTILLAS.IDACTIVIDAD " _
                & "INNER JOIN EQUIPOS " _
                & "ON EQUIPOS.IDEQUIPO=PLANTILLAS.IDEQUIPO " _
                & "WHERE PLANTILLAS.IDPLAN LIKE '" & Trim(strIdPlan) & "%' " _
                & "AND EQUIPOS.IDEQUIPO LIKE '" & Trim(IdEquipo) & "%' " _
                & "ORDER BY IDPLAN ASC"

        'Clipboard.SetText(consulta)
        'MessageBox.Show(consulta)
        dgvActividades.AutoGenerateColumns = True
        dgvActividades.DataSource = ClasMantePlan.consultaAux(consulta, "ACTIVIDADES_PLAN")
        dgvActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        If dgvActividades.RowCount > 1 Then
            'IdActividad = dgvActividades.Rows(dgvActividades.CurrentCell.RowIndex).Cells(dgvActividades.CurrentCell.ColumnIndex).Value.ToString
            IdActividad = dgvActividades.Rows(dgvActividades.CurrentCell.RowIndex).Cells(0).Value.ToString
            'MessageBox.Show(IdActividad)
        Else
            IdActividad = Nothing
        End If

    End Sub

    Public Sub cargaEquipos()

        ' Carga listado de los Equipos al cambiar IdPlantilla y IdActividad en el dataGridView dgvEquipos
        ' ¡OJO! No se utiliza
        Dim consulta As String

        If dgvActividades.RowCount > 1 Then
            IdActividad = dgvActividades.Rows(dgvActividades.CurrentCell.RowIndex).Cells(0).Value.ToString
            'MessageBox.Show(IdActividad)
        Else
            IdActividad = ""
        End If
        strIdPlan = Trim(txt_ID.Text)

        ' EQUIPOS
        consulta = "SELECT DISTINCT EQUIPOS.IDEQUIPO, EQUIPOS.NOMBRE AS NombreEquipo  " _
            & "FROM EQUIPOS INNER JOIN PLANTILLAS " _
            & "ON EQUIPOS.IDEQUIPO=PLANTILLAS.IDEQUIPO " _
            & "WHERE PLANTILLAS.IDPLAN LIKE '" & Trim(strIdPlan) & "%' " _
            & "AND PLANTILLAS.IDACTIVIDAD LIKE '" & Trim(IdActividad.ToString) & "%' " _
            & "ORDER BY NombreEquipo ASC"

        dgvEquipos.AutoGenerateColumns = True
        dgvEquipos.DataSource = ClasMantePlan.consultaAux(consulta, "EQUIPOS_PLAN")
        dgvEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

    End Sub

    Private Sub txt_ID_Enter(sender As Object, e As EventArgs) Handles txt_ID.Enter

        txt_ID.SelectionStart = 0
        txt_ID.SelectionLength = 0

    End Sub

    Private Sub tsbagreImg_Click(sender As Object, e As EventArgs) Handles tsbAgreImg.Click

        strIdPlan = txt_ID.Text
        recarga = True

        If (dgvManteP.RowCount > 0) Then
            If (FAddEquipo Is Nothing) Then
                FAddEquipo = New FrmAddEquipo()
                FAddEquipo.ShowDialog()
            End If
        Else
            MessageBox.Show("Primero debe crear una plantilla para agregarle un equipo.")
        End If

    End Sub

    Private Sub tsbAgrTar_Click(sender As Object, e As EventArgs) Handles tsbAgrTar.Click

        strIdPlan = txt_ID.Text
        recarga = True

        If (dgvManteP.RowCount > 0) Then
            If (FAddActividad Is Nothing) Then
                FAddActividad = New FrmAddActividad()
                FAddActividad.ShowDialog()
            End If
        Else
            MessageBox.Show("Primero debe crear una plantilla para agregarle una actividad.")
        End If

    End Sub

    Private Sub dgvEquipos_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEquipos.RowLeave

        cargaTareas()

    End Sub

    Private Sub tsbVerImg_Click(sender As Object, e As EventArgs) Handles tsbVerImg.Click

        cargaIdPlantilla()

    End Sub
End Class