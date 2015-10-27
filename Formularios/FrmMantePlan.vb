Imports System.Data.SqlClient

Public Class FrmMantePlan

    Public ClasMantePlan As New clMantePlan

    Dim tipoOperacion As String

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
        'Recarga formulario
        'FrmMantePlan_Load(Me, New System.EventArgs)

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

        cargaGrids()

    End Sub

    Private Sub cargaGrids()

        Dim consulta As String

        strIdPlan = Trim(txt_ID.Text)

        dgvEquipos.DataSource = Nothing
        dgvEquipos.Rows.Clear()
        dgvActividades.DataSource = Nothing
        dgvActividades.Rows.Clear()

        consulta = "SELECT DISTINCT EQUIPOS.IDEQUIPO, EQUIPOS.NOMBRE AS NombreEquipo  " _
            & "FROM EQUIPOS INNER JOIN PLANTILLAS " _
            & "ON EQUIPOS.IDEQUIPO=PLANTILLAS.IDEQUIPO " _
            & "WHERE PLANTILLAS.IDPLAN LIKE '" & Trim(strIdPlan) & "%' " _
            & "ORDER BY NombreEquipo ASC"

        dgvEquipos.AutoGenerateColumns = True
        dgvEquipos.DataSource = ClasMantePlan.consultaAux(consulta, "EQUIPOS_PLAN")
        dgvEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        IdEquipo = dgvEquipos.SelectedCells.ToString
        'MessageBox.Show(IdEquipo)

        consulta = "SELECT ACTIVIDADES.NOMBRE AS NombreActividad " _
                & "FROM ACTIVIDADES INNER JOIN PLANTILLAS " _
                & "ON ACTIVIDADES.IDACTIVIDAD=PLANTILLAS.IDACTIVIDAD " _
                & "INNER JOIN EQUIPOS " _
                & "ON EQUIPOS.IDEQUIPO=PLANTILLAS.IDEQUIPO " _
                & "WHERE PLANTILLAS.IDPLAN LIKE '" & Trim(strIdPlan) & "%' " _
                & "AND EQUIPOS.IDEQUIPO LIKE '" & Trim(IdEquipo) & "%' " _
                & "ORDER BY IDPLAN ASC"

        dgvActividades.AutoGenerateColumns = True
        dgvActividades.DataSource = ClasMantePlan.consultaAux(consulta, "ACTIVIDADES_PLAN")
        dgvActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

    End Sub

    Private Sub btEquipos_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub txt_ID_Enter(sender As Object, e As EventArgs) Handles txt_ID.Enter

        txt_ID.SelectionStart = 0
        txt_ID.SelectionLength = 0

    End Sub

    Private Sub tsbagreImg_Click(sender As Object, e As EventArgs) Handles tsbagreImg.Click

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

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

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
End Class