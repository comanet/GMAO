Imports Microsoft.VisualBasic
Public Class FrmGMAO

    Public ClasGMAO As New clGMAO

    Dim dtGMAO As DataTable
    Dim dtEquipos As DataTable
    Dim dtActividades As DataTable
    Dim dtPlanes As DataTable
    Dim tipoOperacion As String

    Public Sub CargaCombos()

        ' Carga los combos con los datos de cada lista
        cbEquipo.Enabled = True
        cbActiv.Enabled = True
        cbPlan.Enabled = True

        ' Borramos TODOS los datos de los combos
        cbEquipo.Items.Clear()
        cbActiv.Items.Clear()
        cbPlan.Items.Clear()

        ' Cargamos combo con EQUIPOS
        dtEquipos = ClasGMAO.consultaAux("SELECT IDEQUIPO, (IDEQUIPO + ' ' + NOMBRE) AS NEQUIPO FROM EQUIPOS ORDER BY IDEQUIPO, NOMBRE", "tbl_EQUIPOS")

        For Each row As DataRow In dtEquipos.Rows
            cbEquipo.Items.Add(CStr(row("NEQUIPO")))
        Next

        ' Cargamos combo con ACTIVIDADES
        dtActividades = ClasGMAO.consultaAux("SELECT IDACTIVIDAD, (CAST(IDACTIVIDAD AS varchar(10)) + ' ' + NOMBRE) AS NACTIVIDAD FROM ACTIVIDADES ORDER BY IDACTIVIDAD, NOMBRE", "tbl_ACTIVIDADES")

        For Each row As DataRow In dtActividades.Rows
            cbActiv.Items.Add(CStr(row("NACTIVIDAD")))
        Next

        ' Cargamos combo con PLANES
        dtPlanes = ClasGMAO.consultaAux("SELECT IDPLAN FROM MANTEPLAN ORDER BY IDPLAN", "tbl_PLANES")

        For Each row As DataRow In dtPlanes.Rows
            cbPlan.Items.Add(CStr(row("IDPLAN")))
        Next

        cbEquipo.Enabled = False
        cbActiv.Enabled = False
        cbPlan.Enabled = False

    End Sub

    Private Sub Enlacebin()

        CargaCombos()

        Me.txt_ID.DataBindings.Add("text", ClasGMAO.bsGMAO, "IDPLAN")
        Me.txt_IDPM.DataBindings.Add("text", ClasGMAO.bsGMAO, "IDPM")

        Me.txt_IDACTIV.DataBindings.Add("text", ClasGMAO.bsGMAO, "IDACTIVIDAD")
        Me.txt_IDEQUIPO.DataBindings.Add("text", ClasGMAO.bsGMAO, "IDEQUIPO")
        Me.txt_FIni.DataBindings.Add("text", ClasGMAO.bsGMAO, "FechaInicio")
        If IsDate(txt_FIni.Text) Then
            Me.calFInicio.SetDate(txt_FIni.Text)
        Else
            Me.calFInicio.SetDate(Now)
        End If

    End Sub

    Private Sub FrmGMAO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_ID.Text = ""
        txt_IDPM.Text = ""
        txt_IDACTIV.Text = ""
        txt_IDEQUIPO.Text = ""
        txt_FIni.Text = ""

        ' Rellenamos el dataGridView con TODAS las lineas - dgvSecc
        ClasGMAO.ConsultaGMAO("SELECT PLANESGMAO.IDPM, PLANESGMAO.IDPLAN, PLANESGMAO.IDEQUIPO, EQUIPOS.NOMBRE AS NombreEquipo, " _
                              & "PLANESGMAO.IDACTIVIDAD, ACTIVIDADES.NOMBRE AS NombreActividad, PLANESGMAO.FechaInicio " _
                              & "FROM PLANESGMAO INNER JOIN ACTIVIDADES " _
                              & "ON PLANESGMAO.IDACTIVIDAD=ACTIVIDADES.IDACTIVIDAD " _
                              & "INNER JOIN EQUIPOS ON PLANESGMAO.IDEQUIPO=EQUIPOS.IDEQUIPO")
        dgvSecc.DataSource = ClasGMAO.bsGMAO
        dgvSecc.AutoGenerateColumns = True
        dgvSecc.Columns("IDPM").Visible = False
        dgvSecc.Columns("IDEQUIPO").Visible = False
        dgvSecc.Columns("IDACTIVIDAD").Visible = False

        ' Los otros dos grids (dgvActiv y dgvEquip) se rellenan cuando se rellene el primero y se pueblen los combos

        'Asociar los Textbox con el Bindingsource para que muestre los datos.
        Enlacebin()

    End Sub

    Private Sub Limpiabinding()

        Me.txt_ID.DataBindings.Clear()
        Me.txt_IDPM.DataBindings.Clear()
        Me.txt_IDACTIV.DataBindings.Clear()
        Me.txt_IDEQUIPO.DataBindings.Clear()
        Me.txt_FIni.DataBindings.Clear()

        Me.cbEquipo.DataBindings.Clear()
        Me.cbActiv.DataBindings.Clear()
        Me.cbPlan.DataBindings.Clear()

        Me.calFInicio.DataBindings.Clear()

        Me.calFInicio.SetDate(Now)

    End Sub

    Public Sub Actualizar(Optional ByVal bCargar As Boolean = True) ' Se utiliza para limpiar el datagridview y refrescar los datos modificados.

        '*** Actualizar y guardar cambios   
        If Not ClasGMAO.bsGMAO Is Nothing Then
            ClasGMAO.daGMAO.Update(CType(ClasGMAO.bsGMAO.DataSource, DataTable))
            If bCargar Then
                dgvSecc.Refresh()
                ClasGMAO.dsGMAO.Tables.Clear()
                FrmGMAO_Load(Me, New System.EventArgs)
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

    End Sub

    Private Sub tsDel_Click(sender As Object, e As EventArgs) Handles tsDel.Click

        Dim valor As Integer

        If MessageBox.Show("¿Esta seguro de que desea Eliminar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                valor = txt_IDPM.Text
                Limpiabinding()
                ClasGMAO.Eliminar("PLANESGMAO", "IDPM = " & valor)
                Actualizar()
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub calFInicio_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calFInicio.DateChanged

        txt_FIni.Text = calFInicio.SelectionRange.Start.ToString

    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click

        If tipoOperacion = "A" Then ' Comprueba si es Alta nueva "A" o modificacion "M"
            If MessageBox.Show("¿Esta seguro de que desea Guardar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Try
                    If (txt_FIni.Text = "") Then
                        txt_FIni.Text = calFInicio.SelectionRange.Start.ToString
                    End If
                    If ClasGMAO.InsertaGMAO("Insert Into PLANESGMAO(IDPLAN, IDACTIVIDAD, IDEQUIPO, FechaInicio)" & _
                                                   "values(" & "'" & Me.txt_ID.Text & "'" & "," & "'" & Me.txt_IDACTIV.Text &
                                                   "'" & "," & "'" & Me.txt_IDEQUIPO.Text & "'" & "," & "'" & Me.txt_FIni.Text & "'" & ")") = True Then
                        'MsgBox("Registro Agregado Con Exito", MsgBoxStyle.Information)
                        ' Para actualizar los valores nuevos insertados y que se muestren en el dvgrid
                        Actualizar()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error " & ex.Message)
                End Try

                Me.txt_ID.ReadOnly = True
                Me.txt_FIni.ReadOnly = True
                Me.txt_IDEQUIPO.ReadOnly = True
                Me.txt_IDACTIV.ReadOnly = True
                Me.cbEquipo.Enabled = False
                Me.cbActiv.Enabled = False
                Me.cbPlan.Enabled = False

                tsSave.Enabled = False
                tsEdit.Enabled = True
                tsNew.Enabled = True
                tsDel.Enabled = True
            End If
        ElseIf tipoOperacion = "M" Then

            If ClasGMAO.actualizar("PLANESGMAO", "IDPLAN = " + "'" + Trim(txt_ID.Text) + "'" + "," + "IDACTIVIDAD =" + "'" + Trim(txt_IDACTIV.Text) + "'" + "," + "IDEQUIPO= " + "'" + txt_IDEQUIPO.Text + "'" + "," + "FechaInicio= " + "'" + Trim(txt_FIni.Text) + "'", "IDPM= " + Trim(txt_IDPM.Text)) Then

                Actualizar()
                Me.txt_ID.ReadOnly = True
                Me.txt_FIni.ReadOnly = True
                Me.txt_IDEQUIPO.ReadOnly = True
                Me.txt_IDACTIV.ReadOnly = True
                Me.cbEquipo.Enabled = False
                Me.cbActiv.Enabled = False
                Me.cbPlan.Enabled = False

                tsSave.Enabled = False
                tsEdit.Enabled = True
                tsNew.Enabled = True
                tsDel.Enabled = True

                'MsgBox("Registro Modificado Con Exito", MsgBoxStyle.Information)
            End If
        End If

        btSalir.Enabled = True

    End Sub

    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click

        'Añadir Nuevo Registro
        Limpiabinding()

        Me.txt_FIni.Text = " "
        Me.txt_IDEQUIPO.Text = " "
        Me.txt_IDACTIV.Text = " "

        'Me.txt_ID.ReadOnly = False
        Me.txt_FIni.ReadOnly = False
        Me.txt_IDEQUIPO.ReadOnly = False
        Me.txt_IDACTIV.ReadOnly = False

        Me.cbEquipo.Enabled = True
        Me.cbActiv.Enabled = True
        Me.cbPlan.Enabled = True

        tsEdit.Enabled = False
        tsDel.Enabled = False
        tsSave.Enabled = True
        tipoOperacion = "A"

    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click

        Limpiabinding()

        btSalir.Enabled = False

        Me.txt_FIni.ReadOnly = False
        Me.txt_IDEQUIPO.ReadOnly = False
        Me.txt_IDACTIV.ReadOnly = False

        Me.cbEquipo.Enabled = True
        Me.cbActiv.Enabled = True
        Me.cbPlan.Enabled = True

        tsSave.Enabled = True
        tsNew.Enabled = False
        tsDel.Enabled = False
        tipoOperacion = "M"

    End Sub

    Private Sub cbEquipo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbEquipo.SelectedValueChanged

        Dim codigo As String = ""

        codigo = cbEquipo.Text.Substring(0, 2)
        txt_IDEQUIPO.Text = codigo

    End Sub

    Private Sub cbActiv_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbActiv.SelectedValueChanged

        Dim codigo As String = ""

        codigo = Trim(cbActiv.Text)
        codigo = codigo.Substring(0, 2)
        codigo = Trim(codigo)
        'MessageBox.Show("El índice de la Actividad es: " + codigo)
        If IsNumeric(codigo) Then
            txt_IDACTIV.Text = codigo
        End If

    End Sub

    Private Sub cbPlan_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbPlan.SelectedValueChanged

        Dim codigo As String = ""
        Dim i As Integer = 0

        codigo = Trim(cbPlan.Text)

        txt_ID.Text = codigo

        ' Rellenamos el grid de ACTIVIDADES - dgvActiv
        ClasGMAO.dsActiv.Clear()

        ClasGMAO.ConsultaActiv("SELECT PLANESGMAO.IDPM, PLANESGMAO.IDPLAN, PLANESGMAO.IDEQUIPO, " _
                               & "EQUIPOS.NOMBRE AS NombreEquipo, PLANESGMAO.IDACTIVIDAD, ACTIVIDADES.NOMBRE AS NombreActividad, " _
                               & "PLANESGMAO.FechaInicio " _
                               & "FROM PLANESGMAO INNER JOIN ACTIVIDADES " _
                               & "ON PLANESGMAO.IDACTIVIDAD=ACTIVIDADES.IDACTIVIDAD " _
                               & "INNER JOIN EQUIPOS " _
                               & "ON PLANESGMAO.IDEQUIPO=EQUIPOS.IDEQUIPO " _
                               & "WHERE PLANESGMAO.IDPLAN = '" & txt_ID.Text & "'")

        dgvActiv.DataSource = ClasGMAO.bsActiv
        dgvActiv.AutoGenerateColumns = True
        dgvActiv.Columns("IDPM").Visible = False
        dgvActiv.Columns("IDPLAN").Visible = False
        dgvActiv.Columns("IDEQUIPO").Visible = False
        dgvActiv.Columns("IDACTIVIDAD").Visible = False
        dgvActiv.Update()

        ' Rellenamos el grid de EQUIPOS - dgvEquip
        dgvEquip.DataSource = ClasGMAO.bsActiv
        dgvEquip.AutoGenerateColumns = True
        dgvEquip.Columns("IDPM").Visible = False
        dgvEquip.Columns("IDPLAN").Visible = False
        dgvEquip.Columns("IDACTIVIDAD").Visible = False
        dgvEquip.Columns("NombreActividad").Visible = False
        dgvEquip.Columns("FechaInicio").Visible = False

    End Sub

    Private Sub txt_IDEQUIPO_TextChanged(sender As Object, e As EventArgs) Handles txt_IDEQUIPO.TextChanged

        Dim i As Integer = cbEquipo.FindString(txt_IDEQUIPO.Text)
        'MessageBox.Show("El índice de Equipo es " + i.ToString)

        If i >= 0 Then
            cbEquipo.SelectedIndex = i
        End If

    End Sub

    Private Sub txt_IDACTIV_TextChanged(sender As Object, e As EventArgs) Handles txt_IDACTIV.TextChanged

        Dim i As Integer = cbActiv.FindString(txt_IDACTIV.Text)
        'MessageBox.Show("El índice de Actividad es " + i.ToString)

        If i >= 0 Then
            cbActiv.SelectedIndex = i
        End If

    End Sub

    Private Sub txt_FIni_TextChanged(sender As Object, e As EventArgs) Handles txt_FIni.TextChanged

        Dim fInicio As Date

        If IsDate(txt_FIni.Text) Then
            fInicio = txt_FIni.Text
            calFInicio.SetDate(fInicio)
        End If

    End Sub

    Private Sub txt_ID_TextChanged(sender As Object, e As EventArgs) Handles txt_ID.TextChanged

        cbPlan.Text = txt_ID.Text

    End Sub
End Class