Public Class FrmAddPlan

    Public numPlanes As Integer = 0

    Public ClasAddPlan As New clAddPlan

    Dim tipoOperacion As String

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click

        Me.Close()

    End Sub

    Private Sub FrmAddPlan_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        FAddPlan = Nothing

    End Sub

    Private Sub Enlacebin()

        ' No es necesario enlazar txt:Nombre, porque ese valor viene del form FrmEquipos (padre) y no se puede cambiar
        'Me.txt_Nombre.DataBindings.Add("text", ClasAddPlan.bsAddPlan, "IDPLAN")        

    End Sub

    Private Sub CargaCombo()



    End Sub

    Private Sub FrmAddPlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FAddPlan.Text = FAddPlan.Text + " " + NombreEquipo + "-" + Seccion
        txt_Nombre.Enabled = True
        txt_Nombre.Text = NombreEquipo + ", No. Serie: " + NSerie
        txt_Nombre.Enabled = False

        numPlanes = 1

        ClasAddPlan.ConsultaAddPlan("SELECT * FROM PLANESGMAO WHERE IDEQUIPO LIKE '" + IdEquipo + "'")
        dgvSecc.DataSource = ClasAddPlan.bsAddPlan
        dgvSecc.AutoGenerateColumns = True
        'Enlacebin()

    End Sub
End Class