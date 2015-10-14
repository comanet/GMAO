Module variables

    Public FSecciones As FrmSeccion = Nothing
    Public FPersonal As FrmPersonal = Nothing
    Public FAcercade As FrmAcercade = Nothing
    Public FCatEqui As FrmCatEqui = Nothing
    Public FUser As FrmUser = Nothing
    Public FEquipos As FrmEquipos = Nothing
    Public FAlmacen As FrmAlmacen = Nothing
    Public FRepuestos As FrmRepuestos = Nothing
    Public FFrecuencias As FrmFrecuencias = Nothing
    Public FEspecialidades As FrmEspecialidades = Nothing
    Public FMantePlan As FrmMantePlan = Nothing

    Public Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Dim fEntrada As New FrmEntrada
        If fEntrada.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            fEntrada.Close()
            Application.Run(New FrmPrincipal)
        End If
    End Sub

End Module
