Imports System.Data.SqlClient
Public Class FrmAddEquipo

    Public ClasAddEquipo As New clAddEquipo

    Dim dtEquipos As DataTable

    Dim tipoOperacion As String

    Private Sub FrmAddEquipo_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub FrmAddEquipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub FrmAddEquipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LabelPlan.Text = "Plan actual: " & strIdPlan
        recarga = True

        dtEquipos = ClasAddEquipo.consultaAux("SELECT IDEQUIPO, NOMBRE FROM EQUIPOS ORDER BY NOMBRE", "tbl_EQUIPOS")
        For Each row As DataRow In dtEquipos.Rows
            lbEquipos.Items.Add(CStr(row("NOMBRE")))
            lbEquipos.ValueMember = "IDEQUIPO"
            lbEquipos.DisplayMember = "NOMBRE"
            lbEquipos.DataSource = dtEquipos
        Next

    End Sub

    Private Sub btEquipo_Click(sender As Object, e As EventArgs) Handles btEquipo.Click

        Dim sql As String
        Dim dt As DataTable

        'MessageBox.Show("El IdEquipo es: " & lbEquipos.SelectedValue.ToString)
        IdEquipo = lbEquipos.SelectedValue.ToString
        sql = "INSERT INTO PLANTILLAS(IDPLAN,IDEQUIPO) VALUES('" & strIdPlan & "','" & IdEquipo & "')"
        Try
            If ClasAddEquipo.InsertaEquipo(sql) Then
                MessageBox.Show("PLANTILLAS: " & sql)
            Else
                'MessageBox.Show("ERROR")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

        ' Poner un número en formulario Padre
        sql = "SELECT MAX(IDPLANTILLA) FROM PLANTILLAS"
        dt = ClasAddEquipo.consultaAux(sql, "PLANTILLAS")
        IdPlantilla = dt.Rows(0).Item(0).ToString
        'MessageBox.Show(IdPlantilla)

    End Sub

    Private Sub FrmAddEquipo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        FAddEquipo = Nothing
        recarga = True

        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("FrmAddEquipo - " & ex.Message.ToString)
        End Try

    End Sub
End Class