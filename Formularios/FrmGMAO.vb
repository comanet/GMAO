Imports Microsoft.VisualBasic
Public Class FrmGMAO

    Public ClasGMAO As New clGMAO

    Dim dtGMAO As DataTable
    Dim dtEquipos As DataTable
    Dim dtActividades As DataTable
    Dim dtPlanes As DataTable
    Dim tipoOperacion As String

    Private Sub Enlacebin()

        Me.txt_PLAN.DataBindings.Add("text", ClasGMAO.bsGMAO, "IDPLAN")
        Me.txt_EQUIPO.DataBindings.Add("text", ClasGMAO.bsGMAO, "NombreEquipo")
        Me.txt_ACTIVIDAD.DataBindings.Add("text", ClasGMAO.bsGMAO, "NombreActividad")

    End Sub

    Private Sub FrmGMAO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sql, mensaje As String

        mensaje = "¡ATENCIÓN! Para crear órdenes de trabajo (OT) se deben seleccionar al menos " _
                & "un EQUIPO y una TAREA de las tablas situadas en la parte inferior. El PLAN " _
                & "se puede dejar vacío, pero si se escoge uno se asignará la dupla EQUIPO/TAREA" _
                & "a la plantilla seleccionada." & vbCrLf & vbCrLf & "La escritura de la Base de Datos todavía no está disponible."
        'MessageBox.Show(mensaje, "Asignación de tareas a GMAO", MessageBoxButtons.OK, MessageBoxIcon.Information)

        txt_PLAN.Text = ""
        txt_ACTIVIDAD.Text = ""
        txt_EQUIPO.Text = ""

        ' Rellenamos el dataGridView de ACTIVIDADES
        sql = "SELECT DISTINCT IDACTIVIDAD, NOMBRE " _
            & "FROM ACTIVIDADES " _
            & "ORDER BY NOMBRE"

        'Clipboard.SetText(sql)
        ClasGMAO.ConsultaActiv(sql)
        dgvActiv.DataSource = ClasGMAO.bsActiv
        dgvActiv.AutoGenerateColumns = True
        dgvActiv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        ' Rellenamos el dataGridView de EQUIPOS
        sql = "SELECT DISTINCT IDEQUIPO, NOMBRE " _
            & "FROM EQUIPOS " _
            & "ORDER BY NOMBRE"

        Clipboard.SetText(sql)
        ClasGMAO.ConsultaEquip(sql)
        dgvEquip.DataSource = ClasGMAO.bsEquip
        dgvEquip.AutoGenerateColumns = True
        dgvEquip.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        ' Rellenamos el dataGridView de PLANES
        sql = "SELECT DISTINCT IDPLAN, NOMBRE " _
            & "FROM MANTEPLAN " _
            & "ORDER BY NOMBRE"

        Clipboard.SetText(sql)
        ClasGMAO.ConsultaPlanes(sql)
        dgvPlanes.DataSource = ClasGMAO.bsPlanes
        dgvPlanes.AutoGenerateColumns = True
        dgvPlanes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        'Asociar los Textbox con el Bindingsource para que muestre los datos.
        Enlacebin()

        calFInicio.SelectionStart = Now

    End Sub

    Private Sub Limpiabinding()

        Me.txt_PLAN.DataBindings.Clear()
        Me.txt_ACTIVIDAD.DataBindings.Clear()
        Me.txt_EQUIPO.DataBindings.Clear()

        Me.calFInicio.DataBindings.Clear()

        Me.calFInicio.SetDate(Now)

    End Sub

    Public Sub Actualizar(Optional ByVal bCargar As Boolean = True) ' Se utiliza para limpiar el datagridview y refrescar los datos modificados.

        '*** Actualizar y guardar cambios   
        If Not ClasGMAO.bsActiv Is Nothing Then
            ClasGMAO.daActiv.Update(CType(ClasGMAO.bsActiv.DataSource, DataTable))
            If Not ClasGMAO.bsEquip Is Nothing Then
                ClasGMAO.daEquip.Update(CType(ClasGMAO.bsEquip.DataSource, DataTable))
                If Not ClasGMAO.bsPlanes Is Nothing Then
                    ClasGMAO.daPlanes.Update(CType(ClasGMAO.bsPlanes.DataSource, DataTable))

                    If bCargar Then
                        dgvActiv.Refresh()
                        dgvEquip.Refresh()
                        dgvPlanes.Refresh()
                        ClasGMAO.dsActiv.Tables.Clear()
                        ClasGMAO.dsEquip.Tables.Clear()
                        ClasGMAO.dsPlanes.Tables.Clear()
                        FrmGMAO_Load(Me, New System.EventArgs)
                    End If

                End If
            End If
        End If

    End Sub

    Private Sub FrmGMAO_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub FrmGMAO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click

        Me.Close()

    End Sub

    Private Sub FrmGMAO_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        FGMAO = Nothing

        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            errorConn = ex.Message.ToString
        End Try

    End Sub

    Private Sub tsDel_Click(sender As Object, e As EventArgs) Handles tsDel.Click

        Dim valor As String

        If MessageBox.Show("¿Esta seguro de que desea Eliminar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                valor = "IDPLAN='" & txt_PLAN.Text & "' " _
                    & "IDEQUIPO='" & txt_EQUIPO.Text & "' " _
                    & "IDACTIVIDAD='" & txt_ACTIVIDAD.Text & "' "

                Limpiabinding()
                ClasGMAO.Eliminar("PLANESGMAO", valor)
                Actualizar()
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click

        Dim sql As String = ""
        Dim IdPlan, IdActividad, IdEquipo As String

        If tipoOperacion = "A" Then ' Comprueba si es Alta nueva "A" o modificacion "M"
            If MessageBox.Show("¿Esta seguro de que desea Guardar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Try
                    IdPlan = dgvPlanes.Rows(dgvPlanes.CurrentCell.RowIndex).Cells(0).Value.ToString
                    IdActividad = dgvActiv.Rows(dgvActiv.CurrentCell.RowIndex).Cells(0).Value.ToString
                    IdEquipo = dgvEquip.Rows(dgvEquip.CurrentCell.RowIndex).Cells(0).Value.ToString
                    sql = "INSERT INTO PLANTILLAS(IDPLAN, IDACTIVIDAD, IDEQUIPO) " & vbCrLf _
                        & "VALUES('" & IdPlan & "', '" & IdActividad & "', '" & IdEquipo & "')"
                    Clipboard.SetText(sql)
                    MessageBox.Show(sql)
                    'If ClasGMAO.InsertaGMAO(sql) Then
                    '    Actualizar()
                    'End If
                Catch ex As Exception
                    MessageBox.Show("Error tsSave_Click" & vbCrLf & ex.Message.ToString)
                End Try

                Me.txt_PLAN.ReadOnly = True
                Me.txt_EQUIPO.ReadOnly = True
                Me.txt_ACTIVIDAD.ReadOnly = True

                'tsSave.Enabled = False
                'tsEdit.Enabled = True
                'tsNew.Enabled = True
                'tsDel.Enabled = True
            End If
        Else
            If tipoOperacion = "M" Then
                ' ¡OJO! Revisar y CORREGIR
                ' ¿Realmente vamos a tener que actualizar AQUÍ? 
                ' Echar una pensada ;-)

                IdPlan = dgvPlanes.Rows(dgvPlanes.CurrentCell.RowIndex).Cells(0).Value.ToString
                IdActividad = dgvActiv.Rows(dgvActiv.CurrentCell.RowIndex).Cells(0).Value.ToString
                IdEquipo = dgvEquip.Rows(dgvEquip.CurrentCell.RowIndex).Cells(0).Value.ToString

                MessageBox.Show("Modificamos el registro de tabla PLANTILLAS. Parámetros:" & vbCrLf _
                                & "    - Plan: " & IdPlan & vbCrLf _
                                & "    - Equipo: " & IdEquipo & vbCrLf _
                                & "    - Tarea: " & IdActividad & vbCrLf, "Modificación PLANTILLAS - GMSQL", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'If ClasGMAO.actualizar("PLANTILLAS", "IDPLAN = " + "'" + IdPlan + "', " + "FechaInicio='" + calFInicio.SelectionStart.ToString + "'", "IDPM= " + Trim(txt_IDPM.Text)) Then

                'Actualizar()
                Me.txt_PLAN.ReadOnly = True
                Me.txt_EQUIPO.ReadOnly = True
                Me.txt_ACTIVIDAD.ReadOnly = True

                'tsSave.Enabled = False
                'tsEdit.Enabled = True
                'tsNew.Enabled = True
                'tsDel.Enabled = True
                'End If
            End If
        End If

        btSalir.Enabled = True

    End Sub

    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click

        subAdd()

    End Sub

    Private Sub subAdd()

        'Añadir Nuevo Registro
        Limpiabinding()

        Me.txt_PLAN.Text = ""
        Me.txt_EQUIPO.Text = " "
        Me.txt_ACTIVIDAD.Text = " "

        Me.txt_PLAN.ReadOnly = False
        Me.txt_EQUIPO.ReadOnly = False
        Me.txt_ACTIVIDAD.ReadOnly = False

        tsEdit.Enabled = False
        tsDel.Enabled = False
        tsSave.Enabled = True
        tipoOperacion = "A"

    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click

        Limpiabinding()

        btSalir.Enabled = False

        Me.txt_PLAN.ReadOnly = False
        Me.txt_EQUIPO.ReadOnly = False
        Me.txt_ACTIVIDAD.ReadOnly = False

        tsSave.Enabled = True
        tsNew.Enabled = False
        tsDel.Enabled = False
        tipoOperacion = "M"

    End Sub

    Private Sub dgvActiv_Click(sender As Object, e As EventArgs) Handles dgvActiv.Click

        Dim str As String

        str = dgvActiv.Rows(dgvActiv.CurrentCell.RowIndex).Cells(1).Value.ToString
        txt_ACTIVIDAD.Text = str
        'MessageBox.Show(str)

    End Sub

    Private Sub dgvEquip_Click(sender As Object, e As EventArgs) Handles dgvEquip.Click

        Dim str As String

        str = dgvEquip.Rows(dgvEquip.CurrentCell.RowIndex).Cells(1).Value.ToString
        txt_EQUIPO.Text = str

    End Sub

    Private Sub dgvPlanes_Click(sender As Object, e As EventArgs) Handles dgvPlanes.Click

        Dim str As String

        str = dgvPlanes.Rows(dgvPlanes.CurrentCell.RowIndex).Cells(1).Value.ToString
        txt_PLAN.Text = str

    End Sub

    Private Sub btOT_Click(sender As Object, e As EventArgs) Handles btOT.Click

        ' ¡OJO! La ORDEN DE TRABAJO se crea como un registro en la tabla PLANESGMAO,
        ' en la que se guarda FechaInicio (obligatorio), Actividad (obligatorio),
        ' Equipo (opcional) y Plan (opcional).
        ' Se entiende que puede haber Tareas/Actividades no asignadas a ningún Equipo o Plan, 
        ' pero que deben de ser ejecutadas.

        Dim str, mensaje As String
        Dim IdPlan, IdEquipo, IdActividad As String
        Dim FInicio As Date

        IdPlan = ""
        IdEquipo = ""
        IdActividad = ""
        FInicio = calFInicio.SelectionStart

        mensaje = ""
        If txt_ACTIVIDAD.Text = "" Then
            MessageBox.Show("Se debe seleccionar una ACTIVIDAD para guardar la Orden de Trabajo.", "Seleccionar ACTIVIDAD", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            TabControl1.SelectTab(1)
            Exit Sub
        Else
            IdActividad = dgvActiv.Rows(dgvActiv.CurrentCell.RowIndex).Cells(0).Value.ToString
            mensaje = "Se crea OT"

            If Not (txt_EQUIPO.Text = "") Then
                IdEquipo = dgvEquip.Rows(dgvEquip.CurrentCell.RowIndex).Cells(0).Value.ToString
                mensaje = mensaje & vbCrLf & " Equipo: " & IdEquipo & " - " & Trim(txt_EQUIPO.Text)
            End If

            mensaje = mensaje & "," & vbCrLf & "Tarea: " & Trim(txt_ACTIVIDAD.Text)

            If Not (txt_PLAN.Text = "") Then
                IdPlan = dgvPlanes.Rows(dgvPlanes.CurrentCell.RowIndex).Cells(0).Value.ToString
                mensaje = mensaje & "," & vbCrLf & "Asignado al plan: " & Trim(txt_PLAN.Text)
            End If

            mensaje = mensaje & "," & vbCrLf & "Fecha de Inicio: " & calFInicio.SelectionStart.ToString

            ' Guardar a BD
            str = ""

            Try
                If (IdEquipo = "") And (IdPlan = "") Then
                    str = "INSERT INTO PLANESGMAO(FechaInicio, IDACTIVIDAD) " & vbCrLf _
                        & "VALUES('" & FInicio.ToString & "', '" & IdActividad & "')"
                End If

                If Not (IdEquipo = "") And (IdPlan = "") Then
                    str = "INSERT INTO PLANESGMAO(FechaInicio, IDACTIVIDAD, IDEQUIPO) " & vbCrLf _
                        & "VALUES('" & FInicio.ToString & "', '" & IdActividad & "', '" & IdEquipo & "')"
                End If

                If (IdEquipo = "") And Not (IdPlan = "") Then
                    str = "INSERT INTO PLANESGMAO(FechaInicio, IDACTIVIDAD, IDPLAN) " & vbCrLf _
                        & "VALUES('" & FInicio.ToString & "', '" & IdActividad & "', '" & IdPlan & "')"
                End If

                If Not (IdEquipo = "") And Not (IdPlan = "") Then
                    str = "INSERT INTO PLANESGMAO(FechaInicio, IDEQUIPO, IDACTIVIDAD, IDPLAN) " & vbCrLf _
                        & "VALUES('" & FInicio.ToString & "', '" & IdEquipo & "', '" & IdActividad & "', '" & IdPlan & "')"
                End If

                If (str = "") Then
                    MessageBox.Show("ERROR - No se ha asignado una consulta válida en el INSERT a la tabla PLANESGMAO")
                Else
                    MessageBox.Show(str)
                    Clipboard.SetText(str)
                    txt_PLAN.Text = ""
                    txt_EQUIPO.Text = ""
                    txt_ACTIVIDAD.Text = ""

                    If ClasGMAO.InsertaGMAO(str) Then
                        MessageBox.Show(mensaje, "OT creada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'Actualizar()
                        Exit Sub
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("¡¡¡JODERRR!!!")
                errorConn = ex.Message.ToString
            Finally
                If cnn.State = ConnectionState.Open Then
                    cnn.Close()
                End If
            End Try
        End If

    End Sub

    Private Sub btBorrar_Click(sender As Object, e As EventArgs) Handles btBorrar.Click

        txt_PLAN.Text = ""
        txt_EQUIPO.Text = ""
        txt_ACTIVIDAD.Text = ""

    End Sub

    Private Sub btAddPlan_Click(sender As Object, e As EventArgs) Handles btAddPlan.Click

        If txt_EQUIPO.Text = "" Then
            If MessageBox.Show("Se debe seleccionar un EQUIPO para guardar la plantilla.", "Seleccionar EQUIPO", MessageBoxButtons.OK, MessageBoxIcon.Stop) Then
                TabControl1.SelectTab(0)
                Exit Sub
            End If
        End If

        If txt_ACTIVIDAD.Text = "" Then
            If MessageBox.Show("Se debe seleccionar una ACTIVIDAD para guardar la plantilla.", "Seleccionar ACTIVIDAD", MessageBoxButtons.OK, MessageBoxIcon.Stop) Then
                TabControl1.SelectTab(1)
                Exit Sub
            End If
        End If

        If txt_PLAN.Text = "" Then
            If MessageBox.Show("Se debe seleccionar un PLAN para guardar la plantilla.", "Seleccionar PLAN", MessageBoxButtons.OK, MessageBoxIcon.Stop) Then
                TabControl1.SelectTab(2)
                Exit Sub
            End If
        End If

        ' Insertar en GMSQL
        ' Se inserta registro en la tabla PLANTILLAS
        tipoOperacion = "A"
        tsSave_Click(Me, New System.EventArgs)

    End Sub
End Class