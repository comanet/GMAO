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

        ' Cargamos el combo con los planes en los que NO aparezca IdEquipo
        sql = "SELECT DISTINCT MANTEPLAN.IDPLAN " _
            & "FROM MANTEPLAN INNER JOIN PLANESGMAO " _
            & "ON MANTEPLAN.IDPLAN=PLANESGMAO.IDPLAN " _
            & "WHERE MANTEPLAN.IDPLAN NOT IN (SELECT DISTINCT IDPLAN " _
            & "FROM PLANESGMAO " _
            & "WHERE IDEQUIPO LIKE '" + IdEquipo + "') " _
            & "ORDER BY MANTEPLAN.IDPLAN"
        'Clipboard.SetText(sql)
        'MessageBox.Show(sql)
        cbPlan.Items.Clear()
        dtcbPlanes = ClasAddPlan.consultaAux(sql, "tbl_PLANES")
        For Each row As DataRow In dtcbPlanes.Rows
            cbPlan.Items.Add(CStr(row("IDPLAN")))
        Next

        'Enlacebin()

    End Sub

    Private Sub btnAddPlan_Click(sender As Object, e As EventArgs) Handles btnAddPlan.Click

        If Not (cbPlan.Text = "") Then
            MessageBox.Show("Asignamos el equipo " + IdEquipo + " " + NombreEquipo + " al plan " + cbPlan.Text + " con fecha de inicio " + dtpFInicio.Value.ToString)
        End If

    End Sub
End Class