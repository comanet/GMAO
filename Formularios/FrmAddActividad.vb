Public Class FrmAddActividad

    Public ClasAddActividad As New clAddActividad

    Dim dtActiv As DataTable

    Dim tipoOperacion As String

    Private Sub FrmAddActividad_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub FrmAddActividad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub FrmAddActividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LabelPlan.Text = "Plan actual: " & strIdPlan
        recarga = True

        dtActiv = ClasAddActividad.consultaAux("SELECT IDACTIVIDAD, NOMBRE FROM ACTIVIDADES ORDER BY NOMBRE", "tbl_ACTIVIDADES")
        For Each row As DataRow In dtActiv.Rows
            lbActividad.Items.Add(CStr(row("NOMBRE")))
            lbActividad.ValueMember = "IDACTIVIDAD"
            lbActividad.DisplayMember = "NOMBRE"
            lbActividad.DataSource = dtActiv
        Next

    End Sub

    Private Sub FrmAddActividad_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        FAddActividad = Nothing
        recarga = True
        noMod = False

        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("FrmAddActividad - " & ex.Message.ToString)
        End Try

    End Sub

    Private Sub btActividad_Click(sender As Object, e As EventArgs) Handles btActividad.Click

        Dim sql As String
        'Dim dt As DataTable

        'MessageBox.Show("El IdEquipo es: " & lbActividad.SelectedValue.ToString)
        IdActividad = lbActividad.SelectedValue.ToString
        sql = "INSERT INTO PLANTILLAS(IDPLAN,IDEQUIPO, IDACTIVIDAD) VALUES('" & strIdPlan & "','" & IdEquipo & "','" & IdActividad & "')"
        Try
            If ClasAddActividad.InsertaActividad(sql) Then
                MessageBox.Show("PLANTILLAS: " & sql)
            Else
                'MessageBox.Show("ERROR")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

        'Clipboard.SetText(sql)
        'MessageBox.Show(sql)

        '' Poner un número en formulario Padre
        'sql = "SELECT MAX(IDPLANTILLA) FROM PLANTILLAS"
        'dt = ClasAddActividad.consultaAux(sql, "PLANTILLAS")
        'IdPlantilla = dt.Rows(0).Item(0).ToString
        'MessageBox.Show(IdPlantilla)

    End Sub
End Class