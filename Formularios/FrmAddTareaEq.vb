Public Class FrmAddTareaEq

    Public ClasAddtareaEq As New clAddTareaEq

    Dim dtTareas As DataTable

    Private Sub FrmAddTareaEq_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub FrmAddTareaEq_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub
    Private Sub FrmAddTareaEq_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim IdStr, sql As String

        Me.Text = Me.Text & " " & NombreEquipo
        IdStr = "Equipo: " & IdEquipo

        If Not (NombreEquipo = "") Then
            IdStr = IdStr & vbCrLf & "    - Nombre Equipo: " & NombreEquipo
        End If

        If Not (Seccion = "") Then
            IdStr = IdStr & vbCrLf & "    - Seccion: " & Seccion
        End If

        If Not (NSerie = "") Then
            IdStr = IdStr & vbCrLf & "    - Número de Serie: " & NSerie
        End If

        LabelEquipo.Text = IdStr

        sql = "SELECT IDACTIVIDAD, NOMBRE " & vbCrLf _
            & "FROM ACTIVIDADES " & vbCrLf _
            & "WHERE IDACTIVIDAD NOT IN ( " & vbCrLf _
                & "SELECT DISTINCT PLANESGMAO.IDACTIVIDAD " & vbCrLf _
                & "FROM ACTIVIDADES INNER JOIN PLANESGMAO " & vbCrLf _
                & "ON ACTIVIDADES.IDACTIVIDAD=PLANESGMAO.IDACTIVIDAD " & vbCrLf _
                & "INNER JOIN EQUIPOS " & vbCrLf _
                & "ON PLANESGMAO.IDEQUIPO=EQUIPOS.IDEQUIPO " & vbCrLf _
                & "WHERE PLANESGMAO.IDEQUIPO LIKE '" & IdEquipo & "%') " & vbCrLf _
            & "ORDER BY NOMBRE"

        'MessageBox.Show(sql)
        'Clipboard.SetText(sql)

        dtTareas = ClasAddtareaEq.consultaAux(sql, "tbl_TAREAS")
        For Each row As DataRow In dtTareas.Rows
            lbTareas.Items.Add(CStr(row("NOMBRE")))
            lbTareas.ValueMember = "IDACTIVIDAD"
            lbTareas.DisplayMember = "NOMBRE"
            lbTareas.DataSource = dtTareas
        Next

        If lbTareas.Items.Count = 0 Then
            btTarea.Enabled = False
            MessageBox.Show("No hay tareas nuevas para asignar al equipo " & IdEquipo & "-" & NombreEquipo)
            Me.Close()
        End If

    End Sub

    Private Sub FrmAddTareaEq_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        FAddTareaEq = Nothing

        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            errorConn = ex.Message.ToString
        End Try

    End Sub

    Private Sub lbTareas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbTareas.SelectedIndexChanged

        Dim IdTarea, NombreTarea As String

        IdTarea = lbTareas.SelectedValue.ToString
        NombreTarea = lbTareas.Text
        'MessageBox.Show("IdActividad: " & IdTarea & ", Nombre: " & NombreTarea)

    End Sub

    Private Sub btTarea_Click(sender As Object, e As EventArgs) Handles btTarea.Click

        Dim IdTarea, sql As String

        IdTarea = lbTareas.SelectedValue.ToString
        sql = "INSERT INTO PLANESGMAO(IDEQUIPO, IDACTIVIDAD, FechaInicio) VALUES('" & IdEquipo & "','" & IdTarea & "','" & Now.ToString & "')"

        'Clipboard.SetText(sql)
        'MessageBox.Show(sql)

        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
            If ClasAddtareaEq.InsertaTareaEq(sql) Then
                'MessageBox.Show("TAREAS: " & sql)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub
End Class