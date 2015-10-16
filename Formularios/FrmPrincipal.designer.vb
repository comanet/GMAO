<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuGeneral = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoEquiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambioClaveAccesoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoSeccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeElementosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TablasAuxiliaresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoDeFrecuenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoDeFabricantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoDeCategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EspecialidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnutxtSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdmision = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralAdminisiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepuestosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidosMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradasDeMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegularizaciónStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimentoPreventivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanesDeMantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TareasDeMantenimientoPreventivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GMAOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenesDeTrabajoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoOTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OTProgramadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AcerdaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsmInicio = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmEmp = New System.Windows.Forms.ToolStripButton()
        Me.tsmChangeUser = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSBAceptar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPri = New System.Windows.Forms.ToolStripButton()
        Me.btnPrev = New System.Windows.Forms.ToolStripButton()
        Me.btnNext = New System.Windows.Forms.ToolStripButton()
        Me.btnLas = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsbtnPrint = New System.Windows.Forms.ToolStripButton()
        Me.TSBBuscar = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnFiltro = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuGeneral, Me.mnuAdmision, Me.MantenimentoPreventivoToolStripMenuItem, Me.OrdenesDeTrabajoToolStripMenuItem, Me.InformesToolStripMenuItem, Me.VentanasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.VentanasToolStripMenuItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1026, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuGeneral
        '
        Me.mnuGeneral.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoUsuariosToolStripMenuItem, Me.MantenimientoEquiposToolStripMenuItem, Me.CambioClaveAccesoToolStripMenuItem, Me.MantenimientoSeccionesToolStripMenuItem, Me.TiposDeElementosToolStripMenuItem, Me.TablasAuxiliaresToolStripMenuItem, Me.mnutxtSalir})
        Me.mnuGeneral.Name = "mnuGeneral"
        Me.mnuGeneral.Size = New System.Drawing.Size(59, 20)
        Me.mnuGeneral.Text = "&General"
        '
        'MantenimientoUsuariosToolStripMenuItem
        '
        Me.MantenimientoUsuariosToolStripMenuItem.Name = "MantenimientoUsuariosToolStripMenuItem"
        Me.MantenimientoUsuariosToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.MantenimientoUsuariosToolStripMenuItem.Text = "Mantenimiento Usuarios"
        '
        'MantenimientoEquiposToolStripMenuItem
        '
        Me.MantenimientoEquiposToolStripMenuItem.Name = "MantenimientoEquiposToolStripMenuItem"
        Me.MantenimientoEquiposToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.MantenimientoEquiposToolStripMenuItem.Text = "Mantenimiento Equipos"
        '
        'CambioClaveAccesoToolStripMenuItem
        '
        Me.CambioClaveAccesoToolStripMenuItem.Name = "CambioClaveAccesoToolStripMenuItem"
        Me.CambioClaveAccesoToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.CambioClaveAccesoToolStripMenuItem.Text = "Mantenimiento Personal"
        '
        'MantenimientoSeccionesToolStripMenuItem
        '
        Me.MantenimientoSeccionesToolStripMenuItem.Name = "MantenimientoSeccionesToolStripMenuItem"
        Me.MantenimientoSeccionesToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.MantenimientoSeccionesToolStripMenuItem.Text = "Mantenimiento Secciones"
        '
        'TiposDeElementosToolStripMenuItem
        '
        Me.TiposDeElementosToolStripMenuItem.Name = "TiposDeElementosToolStripMenuItem"
        Me.TiposDeElementosToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.TiposDeElementosToolStripMenuItem.Text = "Tipos de Elementos"
        '
        'TablasAuxiliaresToolStripMenuItem
        '
        Me.TablasAuxiliaresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoDeFrecuenciasToolStripMenuItem, Me.MantenimientoDeToolStripMenuItem, Me.MantenimientoDeFabricantesToolStripMenuItem, Me.MantenimientoDeCategoriasToolStripMenuItem, Me.EspecialidadesToolStripMenuItem})
        Me.TablasAuxiliaresToolStripMenuItem.Name = "TablasAuxiliaresToolStripMenuItem"
        Me.TablasAuxiliaresToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.TablasAuxiliaresToolStripMenuItem.Text = "Tablas Auxiliares"
        '
        'MantenimientoDeFrecuenciasToolStripMenuItem
        '
        Me.MantenimientoDeFrecuenciasToolStripMenuItem.Name = "MantenimientoDeFrecuenciasToolStripMenuItem"
        Me.MantenimientoDeFrecuenciasToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.MantenimientoDeFrecuenciasToolStripMenuItem.Text = " Frecuencias"
        '
        'MantenimientoDeToolStripMenuItem
        '
        Me.MantenimientoDeToolStripMenuItem.Name = "MantenimientoDeToolStripMenuItem"
        Me.MantenimientoDeToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.MantenimientoDeToolStripMenuItem.Text = " Estados"
        '
        'MantenimientoDeFabricantesToolStripMenuItem
        '
        Me.MantenimientoDeFabricantesToolStripMenuItem.Name = "MantenimientoDeFabricantesToolStripMenuItem"
        Me.MantenimientoDeFabricantesToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.MantenimientoDeFabricantesToolStripMenuItem.Text = " Fabricantes"
        '
        'MantenimientoDeCategoriasToolStripMenuItem
        '
        Me.MantenimientoDeCategoriasToolStripMenuItem.Name = "MantenimientoDeCategoriasToolStripMenuItem"
        Me.MantenimientoDeCategoriasToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.MantenimientoDeCategoriasToolStripMenuItem.Text = " Categorias"
        '
        'EspecialidadesToolStripMenuItem
        '
        Me.EspecialidadesToolStripMenuItem.Name = "EspecialidadesToolStripMenuItem"
        Me.EspecialidadesToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.EspecialidadesToolStripMenuItem.Text = "Especialidades"
        '
        'mnutxtSalir
        '
        Me.mnutxtSalir.Name = "mnutxtSalir"
        Me.mnutxtSalir.Size = New System.Drawing.Size(211, 22)
        Me.mnutxtSalir.Text = "Salir"
        '
        'mnuAdmision
        '
        Me.mnuAdmision.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneralAdminisiónToolStripMenuItem, Me.RepuestosToolStripMenuItem, Me.PedidosMaterialToolStripMenuItem, Me.EntradasDeMaterialToolStripMenuItem, Me.RegularizaciónStockToolStripMenuItem})
        Me.mnuAdmision.Name = "mnuAdmision"
        Me.mnuAdmision.Size = New System.Drawing.Size(66, 20)
        Me.mnuAdmision.Text = "&Almacén"
        '
        'GeneralAdminisiónToolStripMenuItem
        '
        Me.GeneralAdminisiónToolStripMenuItem.Name = "GeneralAdminisiónToolStripMenuItem"
        Me.GeneralAdminisiónToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.GeneralAdminisiónToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.GeneralAdminisiónToolStripMenuItem.Text = "Mantenimiento Almacenes"
        '
        'RepuestosToolStripMenuItem
        '
        Me.RepuestosToolStripMenuItem.Name = "RepuestosToolStripMenuItem"
        Me.RepuestosToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.RepuestosToolStripMenuItem.Text = "Articulos/Repuestos"
        '
        'PedidosMaterialToolStripMenuItem
        '
        Me.PedidosMaterialToolStripMenuItem.Name = "PedidosMaterialToolStripMenuItem"
        Me.PedidosMaterialToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.PedidosMaterialToolStripMenuItem.Text = "Pedidos Material"
        '
        'EntradasDeMaterialToolStripMenuItem
        '
        Me.EntradasDeMaterialToolStripMenuItem.Name = "EntradasDeMaterialToolStripMenuItem"
        Me.EntradasDeMaterialToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.EntradasDeMaterialToolStripMenuItem.Text = "Entradas de Material"
        '
        'RegularizaciónStockToolStripMenuItem
        '
        Me.RegularizaciónStockToolStripMenuItem.Name = "RegularizaciónStockToolStripMenuItem"
        Me.RegularizaciónStockToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.RegularizaciónStockToolStripMenuItem.Text = "Regularización Stock"
        '
        'MantenimentoPreventivoToolStripMenuItem
        '
        Me.MantenimentoPreventivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlanesDeMantenimientoToolStripMenuItem, Me.TareasDeMantenimientoPreventivoToolStripMenuItem, Me.GMAOToolStripMenuItem})
        Me.MantenimentoPreventivoToolStripMenuItem.Name = "MantenimentoPreventivoToolStripMenuItem"
        Me.MantenimentoPreventivoToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.MantenimentoPreventivoToolStripMenuItem.Text = "Planificación"
        '
        'PlanesDeMantenimientoToolStripMenuItem
        '
        Me.PlanesDeMantenimientoToolStripMenuItem.Name = "PlanesDeMantenimientoToolStripMenuItem"
        Me.PlanesDeMantenimientoToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.PlanesDeMantenimientoToolStripMenuItem.Text = "Planes de Mantenimiento"
        '
        'TareasDeMantenimientoPreventivoToolStripMenuItem
        '
        Me.TareasDeMantenimientoPreventivoToolStripMenuItem.Name = "TareasDeMantenimientoPreventivoToolStripMenuItem"
        Me.TareasDeMantenimientoPreventivoToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.TareasDeMantenimientoPreventivoToolStripMenuItem.Text = "Tareas programadas"
        '
        'GMAOToolStripMenuItem
        '
        Me.GMAOToolStripMenuItem.Name = "GMAOToolStripMenuItem"
        Me.GMAOToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.GMAOToolStripMenuItem.Text = "GMAO"
        '
        'OrdenesDeTrabajoToolStripMenuItem
        '
        Me.OrdenesDeTrabajoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoOTToolStripMenuItem, Me.OTProgramadasToolStripMenuItem})
        Me.OrdenesDeTrabajoToolStripMenuItem.Name = "OrdenesDeTrabajoToolStripMenuItem"
        Me.OrdenesDeTrabajoToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.OrdenesDeTrabajoToolStripMenuItem.Text = "&Ordenes de Trabajo"
        '
        'MantenimientoOTToolStripMenuItem
        '
        Me.MantenimientoOTToolStripMenuItem.Name = "MantenimientoOTToolStripMenuItem"
        Me.MantenimientoOTToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.MantenimientoOTToolStripMenuItem.Text = "Mantenimiento OT'S"
        '
        'OTProgramadasToolStripMenuItem
        '
        Me.OTProgramadasToolStripMenuItem.Name = "OTProgramadasToolStripMenuItem"
        Me.OTProgramadasToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.OTProgramadasToolStripMenuItem.Text = "OT'S Programadas"
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.InformesToolStripMenuItem.Text = "&Informes"
        '
        'VentanasToolStripMenuItem
        '
        Me.VentanasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadaToolStripMenuItem, Me.HorizontalToolStripMenuItem})
        Me.VentanasToolStripMenuItem.Name = "VentanasToolStripMenuItem"
        Me.VentanasToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.VentanasToolStripMenuItem.Text = "Ventanas"
        '
        'CascadaToolStripMenuItem
        '
        Me.CascadaToolStripMenuItem.Name = "CascadaToolStripMenuItem"
        Me.CascadaToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.CascadaToolStripMenuItem.Text = "Cascada"
        '
        'HorizontalToolStripMenuItem
        '
        Me.HorizontalToolStripMenuItem.Name = "HorizontalToolStripMenuItem"
        Me.HorizontalToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.HorizontalToolStripMenuItem.Text = "Horizontal"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.ToolStripSeparator1, Me.AcerdaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "&Ayuda"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(174, 22)
        Me.ToolStripTextBox1.Text = "Indice"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(171, 6)
        '
        'AcerdaDeToolStripMenuItem
        '
        Me.AcerdaDeToolStripMenuItem.Name = "AcerdaDeToolStripMenuItem"
        Me.AcerdaDeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AcerdaDeToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.AcerdaDeToolStripMenuItem.Text = "Acerda de..."
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 552)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1026, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(53, 17)
        Me.ToolStripStatusLabel.Text = "Usuario: "
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(13, 17)
        Me.ToolStripStatusLabel1.Text = "1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(55, 17)
        Me.ToolStripStatusLabel2.Text = "Empresa:"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(13, 17)
        Me.ToolStripStatusLabel4.Text = "4"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(13, 17)
        Me.ToolStripStatusLabel5.Text = "5"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmInicio, Me.ToolStripSeparator2, Me.tsmEmp, Me.tsmChangeUser, Me.ToolStripSeparator3, Me.TSBAceptar, Me.ToolStripSeparator4, Me.btnPri, Me.btnPrev, Me.btnNext, Me.btnLas, Me.ToolStripSeparator5, Me.TsbtnPrint, Me.TSBBuscar, Me.tsbtnFiltro})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1026, 45)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsmInicio
        '
        Me.tsmInicio.AutoSize = False
        Me.tsmInicio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsmInicio.Image = CType(resources.GetObject("tsmInicio.Image"), System.Drawing.Image)
        Me.tsmInicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsmInicio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmInicio.Name = "tsmInicio"
        Me.tsmInicio.Size = New System.Drawing.Size(53, 45)
        Me.tsmInicio.Text = "Principal"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 45)
        '
        'tsmEmp
        '
        Me.tsmEmp.AutoSize = False
        Me.tsmEmp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsmEmp.Image = CType(resources.GetObject("tsmEmp.Image"), System.Drawing.Image)
        Me.tsmEmp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsmEmp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmEmp.Name = "tsmEmp"
        Me.tsmEmp.Size = New System.Drawing.Size(53, 45)
        Me.tsmEmp.Text = "Selección Empresa"
        '
        'tsmChangeUser
        '
        Me.tsmChangeUser.AutoSize = False
        Me.tsmChangeUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsmChangeUser.Image = CType(resources.GetObject("tsmChangeUser.Image"), System.Drawing.Image)
        Me.tsmChangeUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsmChangeUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmChangeUser.Name = "tsmChangeUser"
        Me.tsmChangeUser.Size = New System.Drawing.Size(53, 45)
        Me.tsmChangeUser.Text = "Cambiar Usuario"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 45)
        '
        'TSBAceptar
        '
        Me.TSBAceptar.AutoSize = False
        Me.TSBAceptar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBAceptar.Enabled = False
        Me.TSBAceptar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBAceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBAceptar.Name = "TSBAceptar"
        Me.TSBAceptar.Size = New System.Drawing.Size(53, 45)
        Me.TSBAceptar.Text = "Aplicar Cambios"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 45)
        '
        'btnPri
        '
        Me.btnPri.AutoSize = False
        Me.btnPri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPri.Image = CType(resources.GetObject("btnPri.Image"), System.Drawing.Image)
        Me.btnPri.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPri.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPri.Name = "btnPri"
        Me.btnPri.Size = New System.Drawing.Size(52, 45)
        Me.btnPri.Text = "Primer Registro"
        '
        'btnPrev
        '
        Me.btnPrev.AutoSize = False
        Me.btnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrev.Image = CType(resources.GetObject("btnPrev.Image"), System.Drawing.Image)
        Me.btnPrev.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(53, 45)
        Me.btnPrev.Text = "Anterior"
        Me.btnPrev.ToolTipText = "Anterior"
        '
        'btnNext
        '
        Me.btnNext.AutoSize = False
        Me.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNext.Image = CType(resources.GetObject("btnNext.Image"), System.Drawing.Image)
        Me.btnNext.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(53, 45)
        Me.btnNext.Text = "Siguiente"
        Me.btnNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNext.ToolTipText = "Siguiente"
        '
        'btnLas
        '
        Me.btnLas.AutoSize = False
        Me.btnLas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLas.Image = CType(resources.GetObject("btnLas.Image"), System.Drawing.Image)
        Me.btnLas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnLas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLas.Name = "btnLas"
        Me.btnLas.Size = New System.Drawing.Size(53, 45)
        Me.btnLas.Text = "Ultimo Registro"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 45)
        '
        'TsbtnPrint
        '
        Me.TsbtnPrint.AutoSize = False
        Me.TsbtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TsbtnPrint.Image = CType(resources.GetObject("TsbtnPrint.Image"), System.Drawing.Image)
        Me.TsbtnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TsbtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TsbtnPrint.Name = "TsbtnPrint"
        Me.TsbtnPrint.Size = New System.Drawing.Size(53, 54)
        Me.TsbtnPrint.Text = "Imprimir"
        '
        'TSBBuscar
        '
        Me.TSBBuscar.AutoSize = False
        Me.TSBBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TSBBuscar.Image = CType(resources.GetObject("TSBBuscar.Image"), System.Drawing.Image)
        Me.TSBBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBBuscar.Name = "TSBBuscar"
        Me.TSBBuscar.Size = New System.Drawing.Size(53, 45)
        Me.TSBBuscar.Text = "Buscar"
        '
        'tsbtnFiltro
        '
        Me.tsbtnFiltro.AutoSize = False
        Me.tsbtnFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnFiltro.Image = CType(resources.GetObject("tsbtnFiltro.Image"), System.Drawing.Image)
        Me.tsbtnFiltro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnFiltro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnFiltro.Name = "tsbtnFiltro"
        Me.tsbtnFiltro.Size = New System.Drawing.Size(53, 45)
        Me.tsbtnFiltro.Text = "Filtro"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1026, 574)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión Mantenimiento "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuGeneral As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcerdaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnutxtSalir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambioClaveAccesoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAdmision As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneralAdminisiónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnFiltro As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TsbtnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPrev As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSBAceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsmInicio As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSBBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPri As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnLas As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsmEmp As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmChangeUser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MantenimientoSeccionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TiposDeElementosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoUsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TablasAuxiliaresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoDeFrecuenciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoDeFabricantesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoDeCategoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EspecialidadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdenesDeTrabajoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoEquiposToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents RepuestosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PedidosMaterialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntradasDeMaterialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegularizaciónStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoOTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OTProgramadasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimentoPreventivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TareasDeMantenimientoPreventivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlanesDeMantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentanasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GMAOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
