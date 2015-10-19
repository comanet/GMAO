Imports Microsoft.VisualBasic
Public Class FrmGMAO

    Public ClasGMAO As New clGMAO

    Dim dtGMAO As DataTable
    Dim dtEquipos As DataTable
    Dim dtActividades As DataTable
    Dim tipoOperacion As String

    Private Sub Enlacebin()

        CargaCombos()

        Me.txt_ID.DataBindings.Add("text", ClasGMAO.bsGMAO, "IDPLAN")

        Me.txt_IDACTIV.DataBindings.Add("text", ClasGMAO.bsGMAO, "IDACTIVIDAD")
        Me.txt_IDEQUIPO.DataBindings.Add("text", ClasGMAO.bsGMAO, "IDEQUIPO")
        Me.txt_FIni.DataBindings.Add("text", ClasGMAO.bsGMAO, "FechaInicio")
        Me.calFInicio.SetDate(txt_FIni.Text)

        'Me.cbEquipo.DataBindings.Add("text", ClasGMAO.bsGMAO, "NombreEquipo")
        'Me.cbActiv.DataBindings.Add("text", ClasGMAO.bsGMAO, "NombreActividad")

        'Me.calFInicio.DataBindings.Add("text", ClasGMAO.bsGMAO, "FechaInicio")

        cbEquipo.FindString(txt_IDEQUIPO.Text)
        cbActiv.FindString(txt_IDACTIV.Text)

    End Sub

    Private Sub FrmGMAO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ClasGMAO.ConsultaGMAO("SELECT PLANESGMAO.IDPLAN, PLANESGMAO.IDEQUIPO, EQUIPOS.NOMBRE AS NombreEquipo, " _
                              & "PLANESGMAO.IDACTIVIDAD, ACTIVIDADES.NOMBRE AS NombreActividad, PLANESGMAO.FechaInicio " _
                              & "FROM PLANESGMAO INNER JOIN ACTIVIDADES " _
                              & "ON PLANESGMAO.IDACTIVIDAD=ACTIVIDADES.IDACTIVIDAD " _
                              & "INNER JOIN EQUIPOS ON PLANESGMAO.IDEQUIPO=EQUIPOS.IDEQUIPO")
        dgvSecc.DataSource = ClasGMAO.bsGMAO
        dgvSecc.AutoGenerateColumns = True
        dgvSecc.Columns("IDEQUIPO").Visible = False
        dgvSecc.Columns("IDACTIVIDAD").Visible = False

        'Asociar los Textbox con el Bindingsource para que muestre los datos.
        Enlacebin()

    End Sub

    Private Sub Limpiabinding()

        Me.txt_ID.DataBindings.Clear()
        Me.txt_IDACTIV.DataBindings.Clear()
        Me.txt_IDEQUIPO.DataBindings.Clear()
        Me.txt_FIni.DataBindings.Clear()

        Me.cbEquipo.DataBindings.Clear()
        Me.cbActiv.DataBindings.Clear()

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
                valor = txt_ID.Text
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
        'MessageBox.Show(calFInicio.SelectionRange.Start.ToString)

    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click

        If tipoOperacion = "A" Then ' Comprueba si es Alta nueva "A" o modificacion "M"
            If MessageBox.Show("¿Esta seguro de que desea Guardar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Try
                    If ClasGMAO.InsertaGMAO("Insert Into PLANESGMAO(IDPLAN,IDACTIVIDAD,IDEQUIPO,FechaInicio)" & _
                                                   "values(" & "'" & Me.txt_ID.Text & "'" & "," & "'" & Me.txt_IDACTIV.Text &
                                                   "'" & "," & "'" & Me.txt_IDEQUIPO.Text & "'" & "," & "'" & Me.txt_FIni.Text & "'" & ")") = True Then
                        MsgBox("Registro Agregado Con Exito", MsgBoxStyle.Information)
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

                tsSave.Enabled = False
                tsEdit.Enabled = True
                tsSave.Enabled = True
                tsNew.Enabled = True
                tsDel.Enabled = True
            End If
        ElseIf tipoOperacion = "M" Then

            If ClasGMAO.actualizar("PLANESGMAO", "IDPLAN = " + "'" + txt_ID.Text + "'" + "," + "IDACTIVIDAD =" + "'" + txt_IDACTIV.Text + "'" + "," + "IDEQUIPO= " + "'" + txt_IDEQUIPO.Text + "'" + "," + "FechaInicio= " + "'" + txt_FIni.Text + "'", " IDPM= " + txt_ID.Text) Then

                Actualizar()
                Me.txt_ID.ReadOnly = True
                Me.txt_FIni.ReadOnly = True
                Me.txt_IDEQUIPO.ReadOnly = True
                Me.txt_IDACTIV.ReadOnly = True
                Me.cbEquipo.Enabled = False
                Me.cbActiv.Enabled = False

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
        Me.txt_FIni.Text = " "
        Me.txt_IDEQUIPO.Text = " "
        Me.txt_IDACTIV.Text = " "

        'Me.txt_ID.ReadOnly = False
        Me.txt_FIni.ReadOnly = False
        Me.txt_IDEQUIPO.ReadOnly = False
        Me.txt_IDACTIV.ReadOnly = False

        Me.cbEquipo.Enabled = True
        Me.cbActiv.Enabled = True

        tsEdit.Enabled = False
        tsDel.Enabled = False
        tsSave.Enabled = True
        tipoOperacion = "A"

    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click

        Limpiabinding()

        Me.txt_FIni.ReadOnly = False
        Me.txt_IDEQUIPO.ReadOnly = False
        Me.txt_IDACTIV.ReadOnly = False

        Me.cbEquipo.Enabled = True
        Me.cbActiv.Enabled = True

        tsSave.Enabled = True
        tsNew.Enabled = False
        tsDel.Enabled = False
        tipoOperacion = "M"

    End Sub

    Public Sub CargaCombos()

        ' Carga los COMBOS CON LAS TABLAS AUXILIARES NECESARIAS.

        cbEquipo.Enabled = True
        cbActiv.Enabled = True

        dtEquipos = ClasGMAO.consultaAux("SELECT IDEQUIPO, (IDEQUIPO + ' ' + NOMBRE) AS NEQUIPO FROM EQUIPOS ORDER BY IDEQUIPO, NOMBRE", "tbl_EQUIPOS")

        For Each row As DataRow In dtEquipos.Rows
            cbEquipo.Items.Add(CStr(row("NEQUIPO")))
        Next

        dtActividades = ClasGMAO.consultaAux("SELECT IDACTIVIDAD, (CAST(IDACTIVIDAD AS varchar(10)) + ' ' + NOMBRE) AS NACTIVIDAD FROM ACTIVIDADES ORDER BY IDACTIVIDAD, NOMBRE", "tbl_ACTIVIDADES")

        For Each row As DataRow In dtActividades.Rows
            cbActiv.Items.Add(CStr(row("NACTIVIDAD")))
        Next

        cbEquipo.Enabled = False
        cbActiv.Enabled = False

    End Sub

    Private Sub cbEquipo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbEquipo.SelectedValueChanged

        Dim codigo As String = ""

        codigo = cbEquipo.Text.Substring(0, 2)
        txt_IDEQUIPO.Text = codigo

    End Sub

    Private Sub cbActiv_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbActiv.SelectedValueChanged

        Dim codigo As String = ""
        Dim indice As Integer = 0

        codigo = cbActiv.Text.Substring(0, 2)
        'MessageBox.Show("El índice de la Actividad es: " + codigo)
        If IsNumeric(Trim(codigo)) Then
            txt_IDACTIV.Text = Trim(codigo)
        End If

        'txt_IDACTIV.Text = codigo

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
End Class