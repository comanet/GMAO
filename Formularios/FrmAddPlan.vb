Public Class FrmAddPlan

    Public numPlanes As Integer = 0

    Public ClasAddPlan As New clAddPlan

    Dim IdPlantilla As Integer
    Dim tipoOperacion As String
    Dim dtcbPlanes As DataTable

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click

        Me.Close()

    End Sub

    Private Sub FrmAddPlan_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        FAddPlan = Nothing

        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            errorConn = ex.Message.ToString
        End Try

    End Sub

    Private Sub Enlacebin()

        ' No es necesario enlazar txt_Nombre, porque ese valor viene del form FrmEquipos (padre) y no se puede cambiar
        'Me.txt_Nombre.DataBindings.Add("text", ClasAddPlan.bsAddPlan, "IDPLAN")        

    End Sub

    Private Sub FrmAddPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sql As String

        FAddPlan.Text = FAddPlan.Text + " " + IdEquipo + " " + NombreEquipo + "-" + Seccion
        txt_Nombre.Enabled = True
        txt_Nombre.Text = NombreEquipo + ", No. Serie: " + NSerie
        txt_Nombre.Enabled = False
        btnAddPlan.Text = btnAddPlan.Text + IdEquipo + " " + NombreEquipo

        numPlanes = 1

        'MessageBox.Show("IdEquipo = " & IdEquipo)

        ' Cargamos el dataGridView con los planes del equipo IdEquipo
        sql = "SELECT DISTINCT PLANTILLAS.IDPLAN, MANTEPLAN.NOMBRE, PLANESGMAO.FechaInicio, ACTIVIDADES.NOMBRE AS NombreActividad " _
            & "FROM PLANESGMAO INNER JOIN PLANTILLAS " _
            & "ON PLANESGMAO.IDPLAN=PLANTILLAS.IDPLAN " _
            & "INNER JOIN MANTEPLAN " _
            & "ON MANTEPLAN.IDPLAN=PLANTILLAS.IDPLAN " _
            & "INNER JOIN ACTIVIDADES " _
            & "ON ACTIVIDADES.IDACTIVIDAD=PLANTILLAS.IDACTIVIDAD " _
            & "WHERE PLANTILLAS.IDEQUIPO LIKE '" + IdEquipo + "'"
        Clipboard.SetText(sql)
        'MessageBox.Show(sql)

        Try
            ClasAddPlan.ConsultaAddPlan(sql)
            dgvSecc.DataSource = ClasAddPlan.bsAddPlan
            dgvSecc.AutoGenerateColumns = True
            dgvSecc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Catch ex As Exception
            MessageBox.Show("Error al cargar dataGridView con los planes del equipo " & IdEquipo & "." & vbCrLf _
                            & ex.Message.ToString)
        End Try

        ' Cargamos el combo con los planes en los que NO aparezca IdEquipo
        sql = "SELECT DISTINCT MANTEPLAN.IDPLAN " _
            & "FROM MANTEPLAN " _
            & "WHERE MANTEPLAN.IDPLAN NOT IN ( " _
            & "SELECT DISTINCT IDPLAN " _
            & "FROM PLANTILLAS " _
            & "WHERE IDEQUIPO LIKE '" + IdEquipo + "%') " _
            & "ORDER BY MANTEPLAN.IDPLAN"
        Clipboard.SetText(sql)
        'MessageBox.Show(sql)

        Try
            cbPlan.Items.Clear()
            dtcbPlanes = ClasAddPlan.consultaAux(sql, "tbl_PLANES")
            For Each row As DataRow In dtcbPlanes.Rows
                cbPlan.Items.Add(CStr(row("IDPLAN")))
            Next
        Catch ex As Exception
            MessageBox.Show("Error al cargar comboBox con los planes a los que se puede asignar el equipo " & IdEquipo & "." & vbCrLf _
                            & ex.Message.ToString)
        End Try

        'Enlacebin()

    End Sub

    Private Sub btnAddPlan_Click(sender As Object, e As EventArgs) Handles btnAddPlan.Click

        Dim dtActXPlan As DataTable
        'Dim comando As System.Data.SqlClient.SqlCommand
        Dim sql As String

        If Not (cbPlan.Text = "") Then
            MessageBox.Show("Asignamos el equipo " + IdEquipo + " " + NombreEquipo + " al plan " + Trim(cbPlan.Text) + " con fecha de inicio " + dtpFInicio.Value.ToString)

            ' Obtenemos un dataSet con las actividades del plan mostrado en cbPlan.text
            sql = "SELECT DISTINCT PLANTILLAS.IDACTIVIDAD, ACTIVIDADES.NOMBRE, FRECUENCIAS.DIAS, PLANTILLAS.IDPLAN " _
                & "FROM ACTIVIDADES INNER JOIN FRECUENCIAS " _
                & "ON ACTIVIDADES.IDFRECUENCIA=FRECUENCIAS.DESCRIPCION " _
                & "INNER JOIN PLANTILLAS " _
                & "ON ACTIVIDADES.IDACTIVIDAD=PLANTILLAS.IDACTIVIDAD " _
                & "WHERE PLANTILLAS.IDPLAN LIKE '" + Trim(cbPlan.Text) + "%' " _
                & "ORDER BY ACTIVIDADES.NOMBRE ASC "

            dtActXPlan = ClasAddPlan.consultaAux(sql, "ACTIVIDADES")
            'MessageBox.Show(sql)
            Clipboard.SetText(sql)

            ' Hallamos el IdPlantilla de la plantilla mostrada en cbPlan.Text


            ' Insertamos los registros correspondientes a la terna PLAN-ACTIVIDAD-EQUIPO en la tabla PLANESGMAO
            'For Each row In dtActXPlan.Rows

            '    Try
            '        query = "INSERT INTO PLANESGMAO(IDPLANTILLA, FechaInicio) VALUES('"
            '        query += Trim(cbPlan.Text) + "','" + row(dtActXPlan.Columns(0)).ToString + "','" + IdEquipo + "','" + dtpFInicio.Value.ToString + "')"
            '        'MessageBox.Show(query)
            '        'Clipboard.SetText(query)
            '        'comando = New System.Data.SqlClient.SqlCommand(query, cnn)
            '        'i = comando.ExecuteNonQuery()
            '    Catch ex As Exception
            '        MessageBox.Show(ex.Message.ToString)
            '        Exit Sub
            '    End Try

            'Next row
        Else

            MessageBox.Show(" No se han encontrado plantillas para asignar al equipo." & vbCrLf _
                            & "Puede ser que no haya selecccionado ninguna plantilla, que esté asignado a todas las plantillas existentes o que no existan plantillas válidas para éste equipo." & vbCrLf _
                            & "Si tiene dudas contacte con el servicio técnico.")

        End If

    End Sub
End Class