Imports System.Text.RegularExpressions

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
    Public FActividades As FrmActividades = Nothing
    Public FAddPlan As FrmAddPlan = Nothing
    Public FGMAO As FrmGMAO = Nothing
    Public FProveedores As FrmProveedores = Nothing
    Public FAddEquipo As FrmAddEquipo = Nothing
    Public FAddActividad As FrmAddActividad = Nothing
    Public FAddTareaEq As FrmAddTareaEq = Nothing

    Public IdEquipo As String = ""
    Public NombreEquipo As String = ""
    Public Seccion As String = ""
    Public NSerie As String = ""
    Public strIdPlan As String
    Public IdPlantilla As Integer = 0
    Public IdActividad As String = ""
    Public ProxReg As Integer = 0
    Public errorConn As String = ""
    Public recarga As Boolean
    Public noMod As Boolean = False

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
