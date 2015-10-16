Imports System.IO
Public Class FrmPrincipal
    Dim Mibinding As BindingSource

    Private Sub FrmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.ToolStripStatusLabel.Text = Me.ToolStripStatusLabel.Text & "INDUSTRIAS JOVIR"
        Me.ToolStripStatusLabel2.Text = Format(Date.Today)
        Me.ActiveControl = Nothing
        FrmEntrada.Close() ' Cierro formulario FrmEntrada para evitar que se quede en memoria.
        ' Tambien modificado Modo Apagado de la Propiedades de la Aplicacion a "Al cerrar ultimo formulario"

    End Sub

    Private Sub FrmPrincipal_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        'Controla el Cierre de la aplicion.
        If MessageBox.Show("¿Esta seguro Que Desea Salir de la Aplicación?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    Private Sub mnutxtSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnutxtSalir.Click

        'Me.Close()
        Application.Exit() ' Cerrar Aplicacion

    End Sub

    Private Sub TsbtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsbtnPrint.Click

        'If Not ActiveControl Is Nothing Then
        '    Dim FReport As New frmPrintView ' listado de Adminision.

        '    If ActiveControl.Name = "frmAdmision" Then
        '        Dim report As New ListadoPacientes() ' Creo la instancia del reporte
        '        FReport.CrystalReportViewer1.ReportSource = report ' ' Asigno el reporte a visor.


        '        FReport.MdiParent = Me
        '        FReport.WindowState = FormWindowState.Normal
        '        FReport.MdiParent = Me
        '        FReport.WindowState = FormWindowState.Normal

        '    ElseIf ActiveControl.Name = "frmRehabilita" Then ' Informe de Alta del Paciente.
        '        Dim report As New InformeAltaRh() ' Creo la instancia del reporte
        '        report.RecordSelectionFormula = "{Ingresos.NUMERO}= '" & fadmision.DGVingresos.CurrentRow.Cells(0).Value & "'" ' fORMULA DE SELECCION.
        '        FReport.CrystalReportViewer1.ReportSource = report ' ' 'Asigno el reporte a visor.
        '        ' Asigno la ruta de la BBDD.
        '        Dim rutadb As String = Path.Combine(Application.StartupPath, "clinica.mdb")
        '        report.DataSourceConnections(0).SetConnection("", rutadb, False)

        '    End If

        '    FReport.Show()
        ' End If

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click, btnPrev.Click, btnPri.Click, btnLas.Click

        'Depende de FormActiva, se debe de asignar una ds diferente a Mibindig.
        'Antes compruebo que tenga algun valor asignado ActiveControl para evitar errores.
        If Not ActiveControl Is Nothing Then
            'MsgBox(ActiveControl.Name)
            If ActiveControl.Name = "FrmSeccion" Then
                Mibinding = FSecciones.ClasSecciones.bsSecciones
            ElseIf ActiveControl.Name = "FrmCatEqui" Then
                Mibinding = FCatEqui.ClasTipEqui.bsCatEqui
            ElseIf ActiveControl.Name = "FrmPersonal" Then
                Mibinding = FPersonal.ClasPersonal.bsPersonal
            ElseIf ActiveControl.Name = "FrmUser" Then
                Mibinding = FUser.ClasUser.bsUser
            ElseIf ActiveControl.Name = "FrmEquipos" Then
                Mibinding = FEquipos.ClasEquipos.bsEquipos
            ElseIf ActiveControl.Name = "FrmAlmacen" Then
                Mibinding = FAlmacen.ClasAlma.bsAlmacen
            ElseIf ActiveControl.Name = "FrmRepuestos" Then
                Mibinding = FRepuestos.ClasRepuesto.bsRepuesto
            ElseIf ActiveControl.Name = "FrmEspecialidades" Then
                Mibinding = FEspecialidades.ClasEspecialidades.bsEspecialidades
            ElseIf ActiveControl.Name = "FrmFrecuencias" Then
                Mibinding = FFrecuencias.ClasFrecuencias.bsFrecuencias
            ElseIf ActiveControl.Name = "FrmMantePlan" Then
                Mibinding = FMantePlan.ClasMantePlan.bsMantePlan
            ElseIf ActiveControl.Name = "FrmActividades" Then
                Mibinding = FActividades.ClasActividades.bsActividades
            ElseIf ActiveControl.Name = "frmPrintView" Or ActiveControl.Name = " " Then
                'MsgBox("aqui")
                Mibinding = Nothing
            End If

            If sender Is btnPrev Then
                Mibinding.MovePrevious()
            ElseIf sender Is btnNext Then
                Mibinding.MoveNext()
            ElseIf sender Is btnPri Then
                Mibinding.MoveFirst()
            ElseIf sender Is btnLas Then
                Mibinding.MoveLast()
            ElseIf sender Is tsmChangeUser Then
                Mibinding.RemoveFilter()
            End If

        End If

    End Sub

    Private Sub TSBEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmEmp.Click

        'If ActiveControl.Name = "frmAdmision" Then
        '    Dim FRehabilita As New frmRehabilita

        '    FRehabilita.MdiParent = Me
        '    ' FRehabilita.WindowState = FormWindowState.Normal
        '    ' Form1 es la form instanciada en FormInstancia para abrir solo una vez Fadmision.
        '    FRehabilita.lbHis.Text = fadmision.DGVingresos.CurrentRow.Cells(0).Value
        '    FRehabilita.lbFec.Text = fadmision.DGVingresos.CurrentRow.Cells(5).Value
        '    FRehabilita.lbApe.Text = fadmision.DGVingresos.CurrentRow.Cells(1).Value
        '    FRehabilita.lbNom.Text = fadmision.DGVingresos.CurrentRow.Cells(2).Value
        '    FRehabilita.lbTlf.Text = fadmision.DGVingresos.CurrentRow.Cells(4).Value
        '    FRehabilita.lbDoc.Text = fadmision.DGVingresos.CurrentRow.Cells(6).Value

        '    FRehabilita.Show()

        'End If

    End Sub

    Private Sub TSBBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSBBuscar.Click

        ' If Not ActiveControl Is Nothing Then
        '    If ActiveControl.Name = "frmAdmision" Then
        '        Mibinding = bsadmision
        '        fadmision.TSBUSCAR.Visible = True
        '        fadmision.TSCbCampo.SelectedIndex = 0
        '        fadmision.TxtBuscar.Focus()
        '    End If
        ' End If

    End Sub

    Private Sub tsbtnFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnFiltro.Click

        ' Dim sql As String
        ' bsIngresos.Filter = "NUMERO LIKE 'A12111%'"
        ' If Not ActiveControl Is Nothing Then
        '    If ActiveControl.Name = "frmAdmision" Then
        '        If Not String.IsNullOrEmpty(fadmision.TxtBuscar.Text) Then ' comprobamos que este vacio. 

        '            sql = fadmision.TSCbCampo.Text & " LIKE " & "'" & fadmision.TxtBuscar.Text & "'"
        '            bsadmision.Filter = sql
        '        End If
        '    End If
        ' End If

    End Sub

    Private Sub AcerdaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcerdaDeToolStripMenuItem.Click

        If (FAcercade Is Nothing) Then
            FAcercade = New FrmAcercade()
            FAcercade.MdiParent = Me
            FAcercade.Show()
        End If

    End Sub

    Private Sub MantenimientoSeccionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoSeccionesToolStripMenuItem.Click

        If (FSecciones Is Nothing) Then
            '    ' Creamos una nueva instancia del formulario
            FSecciones = New FrmSeccion()

            ' Mostramos el formulario
            ' ToolStrip1.Enabled = True
            FSecciones.MdiParent = Me
            FSecciones.Show()
        End If

    End Sub

    Private Sub CambioClaveAccesoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambioClaveAccesoToolStripMenuItem.Click

        If (FPersonal Is Nothing) Then
            ' Creamos una nueva instancia del formulario
            FPersonal = New FrmPersonal()
            ' Mostramos el formulario
            ' ToolStrip1.Enabled = True
            FPersonal.MdiParent = Me
            FPersonal.Show()
        End If

    End Sub

    Private Sub tsmChangeUser_Click(sender As Object, e As EventArgs) Handles tsmChangeUser.Click

        ' Dim fEntrada As New FrmEntrada
        ' fEntrada.ShowDialog()

    End Sub

    Private Sub TiposDeElementosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeElementosToolStripMenuItem.Click

        If (FCatEqui Is Nothing) Then
            '    ' Creamos una nueva instancia del formulario
            FCatEqui = New FrmCatEqui()
            FCatEqui.MdiParent = Me
            FCatEqui.Show()
        End If

    End Sub

    Private Sub MantenimientoUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoUsuariosToolStripMenuItem.Click

        If (FUser Is Nothing) Then
            FUser = New FrmUser()
            FUser.MdiParent = Me
            FUser.Show()
        End If

    End Sub

    Private Sub MantenimientoEquiposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoEquiposToolStripMenuItem.Click

        If (FEquipos Is Nothing) Then
            FEquipos = New FrmEquipos()
            FEquipos.MdiParent = Me
            FEquipos.Show()
        End If

    End Sub

    Private Sub GeneralAdminisiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneralAdminisiónToolStripMenuItem.Click

        If (FAlmacen Is Nothing) Then
            FAlmacen = New FrmAlmacen()
            FAlmacen.MdiParent = Me
            FAlmacen.Show()
        End If

    End Sub

    Private Sub RepuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RepuestosToolStripMenuItem.Click

        If (FRepuestos Is Nothing) Then
            FRepuestos = New FrmRepuestos()
            FRepuestos.MdiParent = Me
            FRepuestos.Show()
        End If

    End Sub

    Private Sub CascadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadaToolStripMenuItem.Click

        LayoutMdi(MdiLayout.Cascade)

    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click

        LayoutMdi(MdiLayout.TileHorizontal)

    End Sub

    Private Sub MantenimientoDeFrecuenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoDeFrecuenciasToolStripMenuItem.Click

        ' Manejo de la tabla FRECUENCIAS
        If (FFrecuencias Is Nothing) Then
            FFrecuencias = New FrmFrecuencias()
            FFrecuencias.MdiParent = Me
            FFrecuencias.Show()
        End If

    End Sub

    Private Sub EspecialidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EspecialidadesToolStripMenuItem.Click

        ' Manejo de la tabla ESPECIALIDADES
        If (FEspecialidades Is Nothing) Then
            FEspecialidades = New FrmEspecialidades()
            FEspecialidades.MdiParent = Me
            FEspecialidades.Show()
        End If

    End Sub

    Private Sub PlanesDeMantenimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanesDeMantenimientoToolStripMenuItem.Click

        If (FMantePlan Is Nothing) Then
            FMantePlan = New FrmMantePlan()
            FMantePlan.MdiParent = Me
            FMantePlan.Show()
        End If

    End Sub

    Private Sub TareasDeMantenimientoPreventivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TareasDeMantenimientoPreventivoToolStripMenuItem.Click

        If (FActividades Is Nothing) Then
            FActividades = New FrmActividades()
            FActividades.MdiParent = Me
            FActividades.Show()
        End If

    End Sub

    Private Sub GMAOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GMAOToolStripMenuItem.Click

        If (FGMAO Is Nothing) Then
            FGMAO = New FrmGMAO()
            FGMAO.MdiParent = Me
            FGMAO.Show()
        End If

    End Sub
End Class
