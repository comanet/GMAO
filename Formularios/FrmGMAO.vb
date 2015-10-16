Public Class FrmGMAO

    Public ClasGMAO As New clGMAO

    Dim dtGMAO As DataTable
    Dim tipoOperacion As String

    Private Sub FrmGMAO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ClasGMAO.ConsultaGMAO("SELECT PLANESGMAO.IDPLAN, PLANESGMAO.IDEQUIPO,ACTIVIDADES.NOMBRE,PLANESGMAO.FechaInicio FROM PLANESGMAO INNER JOIN ACTIVIDADES ON PLANESGMAO.IDACTIVIDAD=ACTIVIDADES.IDACTIVIDAD")
        dgvSecc.DataSource = ClasGMAO.bsGMAO
        dgvSecc.AutoGenerateColumns = True

        'Asociar los Textbox con el Bindingsource para que muestre los datos.
        Enlacebin()

    End Sub

    Private Sub Enlacebin()

        Me.txt_ID.DataBindings.Add("text", ClasGMAO.bsGMAO, "IDPM")

        Me.cbEquipo.DataBindings.Add("text", ClasGMAO.bsGMAO, "IDEQUIPO")
        Me.cbActiv.DataBindings.Add("text", ClasGMAO.bsGMAO, "IDACTIVIDAD")

        Me.calFInicio.DataBindings.Add("text", ClasGMAO.bsGMAO, "FechaInicio")

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
End Class