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
        MessageBox.Show(mensaje, "Asignación de tareas a GMAO", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

    'Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click

    '    If tipoOperacion = "A" Then ' Comprueba si es Alta nueva "A" o modificacion "M"
    '        If MessageBox.Show("¿Esta seguro de que desea Guardar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
    '            Try
    '                If (txt_FIni.Text = "") Then
    '                    txt_FIni.Text = calFInicio.SelectionRange.Start.ToString
    '                End If
    '                ProxReg = ProxReg + 1
    '                If ClasGMAO.InsertaGMAO("Insert Into PLANTILLAS(IDPLAN, IDACTIVIDAD, IDEQUIPO, NUMPLANTILLA)" & _
    '                                               "values(" & "'" & Me.txt_ID.Text & "', '" & txt_IDACTIV.Text & "', '" & txt_IDEQUIPO.Text & "', '" & ProxReg.ToString & "')") = True Then
    '                    Actualizar()
    '                End If
    '            Catch ex As Exception
    '                MessageBox.Show("Error tsSave_Click" & vbCrLf & ex.Message.ToString)
    '                ProxReg = ProxReg - 1
    '            End Try

    '            Me.txt_ID.ReadOnly = True
    '            Me.txt_EQUIPO.ReadOnly = True
    '            Me.txt_ACTIVIDAD.ReadOnly = True

    '            tsSave.Enabled = False
    '            tsEdit.Enabled = True
    '            tsNew.Enabled = True
    '            tsDel.Enabled = True
    '        End If
    '    ElseIf tipoOperacion = "M" Then

    '        If ClasGMAO.actualizar("PLANESGMAO", "IDPLAN = " + "'" + Trim(txt_ID.Text) + "'" + "," + "FechaInicio= " + "'" + Trim(txt_FIni.Text) + "'", "IDPM= " + Trim(txt_IDPM.Text)) Then

    '            Actualizar()
    '            Me.txt_ID.ReadOnly = True
    '            Me.txt_EQUIPO.ReadOnly = True
    '            Me.txt_ACTIVIDAD.ReadOnly = True

    '            tsSave.Enabled = False
    '            tsEdit.Enabled = True
    '            tsNew.Enabled = True
    '            tsDel.Enabled = True
    '        End If
    '    End If

    '    btSalir.Enabled = True

    'End Sub

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

        Dim str As String = ""

        str = "Se crea la OT para el equipo " & dgvEquip.Rows(dgvEquip.CurrentCell.RowIndex).Cells(0).Value.ToString & " - " & dgvEquip.Rows(dgvEquip.CurrentCell.RowIndex).Cells(1).Value.ToString
        str = str & "," & vbCrLf & "Tarea: " & dgvActiv.Rows(dgvActiv.CurrentCell.RowIndex).Cells(1).Value.ToString
        If Not (txt_PLAN.Text = "") Then
            str = str & "," & vbCrLf & "Asignado al plan: " & dgvPlanes.Rows(dgvPlanes.CurrentCell.RowIndex).Cells(1).Value.ToString
        End If
        str = str & "," & vbCrLf & "Fecha de Inicio: " & calFInicio.SelectionStart.ToString

        MessageBox.Show(str)

    End Sub

    Private Sub btBorrar_Click(sender As Object, e As EventArgs) Handles btBorrar.Click

        txt_PLAN.Text = ""

    End Sub
End Class