Public Class FrmOT

    Public ClasOT As New clOT

    Private Sub FrmOT_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub FrmOT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub FrmOT_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        FOT = Nothing

        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub

    Private Sub FrmOT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim str As String

        str = "SELECT PLANESGMAO.IDPLAN AS IdPlan, PLANESGMAO.IDACTIVIDAD AS IdActividad, PLANESGMAO.IDEQUIPO AS IdEquipo, " & vbCrLf _
                & "FechaInicio, FechaEjecucion, " & vbCrLf _
                & "MANTEPLAN.NOMBRE AS NombrePlan, ACTIVIDADES.NOMBRE AS NombreActividad, EQUIPOS.NOMBRE AS NombreEquipo " & vbCrLf _
                & "FROM PLANESGMAO LEFT JOIN MANTEPLAN " & vbCrLf _
                & "ON PLANESGMAO.IDPLAN=MANTEPLAN.IDPLAN " & vbCrLf _
                & "LEFT JOIN ACTIVIDADES " & vbCrLf _
                & "ON PLANESGMAO.IDACTIVIDAD=ACTIVIDADES.IDACTIVIDAD " & vbCrLf _
                & "LEFT JOIN EQUIPOS " & vbCrLf _
                & "ON PLANESGMAO.IDEQUIPO=EQUIPOS.IDEQUIPO " & vbCrLf _
                & "WHERE FechaEjecucion IS NULL"

        'Clipboard.SetText(str)
        'MessageBox.Show("Consulta copiada a ClipBoard")

        ClasOT.ConsultaOT(str)
        dgvOT.DataSource = ClasOT.bsOT
        dgvOT.AutoGenerateColumns = True
        dgvOT.Columns("IdPlan").Visible = False
        dgvOT.Columns("IdActividad").Visible = False
        dgvOT.Columns("IdEquipo").Visible = False
        dgvOT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        MessageBox.Show("Para editar o eliminar una Orden de Trabajo tiene que hacer doble click con el ratón encima de la orden en el grid.", "Editar/Eliminar OT", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub dgvOT_DoubleClick(sender As Object, e As EventArgs) Handles dgvOT.DoubleClick

        If (FOTEdit Is Nothing) Then
            FOTEdit = New FrmOTEdit()
            'FOTEdit.MdiParent = Me
            FOTEdit.ShowDialog()
        End If

    End Sub
End Class