Public Class FrmAddPlan

    Public numPlanes As Integer = 0

    Public ClasAddPlan As New clAddPlan

    Dim tipoOperacion As String
    Dim dtcbPlanes As DataTable

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click

        Me.Close()

    End Sub

    Private Sub FrmAddPlan_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        FAddPlan = Nothing

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

        ' Cargamos el dataGridView con los planes del equipo IdEquipo
        sql = "SELECT DISTINCT MANTEPLAN.IDPLAN, MANTEPLAN.NOMBRE, PLANESGMAO.FechaInicio " _
            & "FROM PLANESGMAO INNER JOIN MANTEPLAN " _
            & "ON PLANESGMAO.IDPLAN=MANTEPLAN.IDPLAN " _
            & "WHERE PLANESGMAO.IDEQUIPO = '" + IdEquipo + "'"
        Clipboard.SetText(sql)
        'MessageBox.Show(sql)
        ClasAddPlan.ConsultaAddPlan(sql)
        dgvSecc.DataSource = ClasAddPlan.bsAddPlan
        dgvSecc.AutoGenerateColumns = True
        dgvSecc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        ' Cargamos el combo con los planes en los que NO aparezca IdEquipo
        sql = "SELECT DISTINCT MANTEPLAN.IDPLAN " _
            & "FROM MANTEPLAN INNER JOIN PLANESGMAO " _
            & "ON MANTEPLAN.IDPLAN=PLANESGMAO.IDPLAN " _
            & "WHERE MANTEPLAN.IDPLAN NOT IN (SELECT DISTINCT IDPLAN " _
            & "FROM PLANESGMAO " _
            & "WHERE IDEQUIPO LIKE '" + IdEquipo + "') " _
            & "ORDER BY MANTEPLAN.IDPLAN"
        Clipboard.SetText(sql)
        'MessageBox.Show(sql)
        cbPlan.Items.Clear()
        dtcbPlanes = ClasAddPlan.consultaAux(sql, "tbl_PLANES")
        For Each row As DataRow In dtcbPlanes.Rows
            cbPlan.Items.Add(CStr(row("IDPLAN")))
        Next

        'Enlacebin()

    End Sub

    Private Sub btnAddPlan_Click(sender As Object, e As EventArgs) Handles btnAddPlan.Click

        Dim dtActXPlan As DataTable
        Dim comando As System.Data.SqlClient.SqlCommand
        Dim sql, query As String

        If Not (cbPlan.Text = "") Then
            MessageBox.Show("Asignamos el equipo " + IdEquipo + " " + NombreEquipo + " al plan " + Trim(cbPlan.Text) + " con fecha de inicio " + dtpFInicio.Value.ToString)

            ' Obtenemos un dataSet con las actividades del plan mostrado en cbPlan.text
            sql = "SELECT DISTINCT ACTIVIDADES.IDACTIVIDAD, ACTIVIDADES.NOMBRE, FRECUENCIAS.DIAS, PLANESGMAO.IDPLAN " _
                & "FROM ACTIVIDADES INNER JOIN FRECUENCIAS " _
                & "ON ACTIVIDADES.IDFRECUENCIA=FRECUENCIAS.DESCRIPCION " _
                & "INNER JOIN PLANESGMAO " _
                & "ON ACTIVIDADES.IDACTIVIDAD=PLANESGMAO.IDACTIVIDAD " _
                & "WHERE PLANESGMAO.IDPLAN LIKE '" + Trim(cbPlan.Text) + "%' " _
                & "ORDER BY ACTIVIDADES.NOMBRE ASC"

            dtActXPlan = ClasAddPlan.consultaAux(sql, "ACTIVIDADES")
            'MessageBox.Show(sql)
            'Clipboard.SetText(sql)

            ' Insertamos los registros correspondientes a la terna PLAN-ACTIVIDAD-EQUIPO en la tabla PLANESGMAO
            For Each row In dtActXPlan.Rows

                Try
                    query = "INSERT INTO PLANESGMAO(IDPLAN, IDACTIVIDAD, IDEQUIPO, FechaInicio) VALUES('"
                    query += Trim(cbPlan.Text) + "','" + row(dtActXPlan.Columns(0)).ToString + "','" + IdEquipo + "','" + dtpFInicio.Value.ToString + "')"
                    'MessageBox.Show(query)
                    'Clipboard.SetText(query)
                    'comando = New System.Data.SqlClient.SqlCommand(query, cnn)
                    'i = comando.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString)
                    Exit Sub
                End Try

            Next row

        End If

    End Sub
End Class