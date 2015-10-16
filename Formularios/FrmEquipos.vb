Imports Microsoft.VisualBasic.FileIO
Public Class FrmEquipos

    Public ClasEquipos As New clEquipos

    Dim dtCategorias As DataTable
    Dim dtTipoEquipo As DataTable
    Dim dtSeccion As DataTable
    Dim tipoOperacion As String

    Private Sub FrmEquipos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub FrmEquipos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub FrmEquipos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        FEquipos = Nothing

    End Sub

    Private Sub Limpiabinding()

        Me.txt_ID.DataBindings.Clear()
        Me.txt_Nombre.DataBindings.Clear()
        Me.txt_Marca.DataBindings.Clear()
        Me.txt_Mod.DataBindings.Clear()
        Me.txt_Pro.DataBindings.Clear()
        Me.txtDescrip.DataBindings.Clear()
        Me.cbseccion.DataBindings.Clear()
        Me.txt_Nserie.DataBindings.Clear()
        Me.txt_Notas.DataBindings.Clear()
        Me.CBtipoEquipo.DataBindings.Clear()
        Me.cbseccion.DataBindings.Clear()
        Me.CBEstado.DataBindings.Clear()
        Me.dtFcompra.DataBindings.Clear()
        Me.dtFGarantia.DataBindings.Clear()

    End Sub

    Private Sub Enlacebin()

        Me.txt_ID.DataBindings.Add("text", ClasEquipos.bsEquipos, "IDEQUIPO")
        Me.txt_Nombre.DataBindings.Add("text", ClasEquipos.bsEquipos, "NOMBRE")
        Me.txt_Marca.DataBindings.Add("text", ClasEquipos.bsEquipos, "MARCA")
        Me.txt_Mod.DataBindings.Add("text", ClasEquipos.bsEquipos, "MODELO")
        Me.txt_Pro.DataBindings.Add("text", ClasEquipos.bsEquipos, "PROVEEDOR")
        Me.txtDescrip.DataBindings.Add("text", ClasEquipos.bsEquipos, "DESCRIPCION")
        Me.txt_Nserie.DataBindings.Add("text", ClasEquipos.bsEquipos, "NSERIE")
        Me.txt_Notas.DataBindings.Add("text", ClasEquipos.bsEquipos, "NOTAS")

        Me.CBtipoEquipo.DataBindings.Add("text", ClasEquipos.bsEquipos, "TIPOEQUIPO")
        Me.cbseccion.DataBindings.Add("text", ClasEquipos.bsEquipos, "SECCION")
        Me.CBEstado.DataBindings.Add("text", ClasEquipos.bsEquipos, "ESTADO")
        Me.dtFcompra.DataBindings.Add("text", ClasEquipos.bsEquipos, "FCOMPRA")
        Me.dtFGarantia.DataBindings.Add("text", ClasEquipos.bsEquipos, "FGARANTIA")

    End Sub

    Private Sub FrmEquipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NombreEquipo = ""
        ClasEquipos.ConsultaEquipos("SELECT * FROM EQUIPOS")
        Enlacebin()

    End Sub

    Private Sub dtFGarantia_Leave(sender As Object, e As EventArgs) Handles dtFGarantia.Leave

        If dtFcompra.Value > Me.dtFGarantia.Value Then
            MsgBox("Fecha Fin Garantia menor que fecha de Compra.", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Public Sub Actualizar(Optional ByVal bCargar As Boolean = True) ' Se utiliza para limpiar el datagridview y refrescar los datos modificados.

        '*** Actualizar y guardar cambios   
        If Not ClasEquipos.bsEquipos Is Nothing Then
            ClasEquipos.daEquipos.Update(CType(ClasEquipos.bsEquipos.DataSource, DataTable))
            If bCargar Then
                ' dgvSecc.Refresh()
                ClasEquipos.dsEquipos.Tables.Clear()
                FrmEquipos_Load(Me, New System.EventArgs)
            End If
        End If

    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click

        Limpiabinding()

        'Me.txt_ID.ReadOnly = False
        Me.txt_Nombre.ReadOnly = False
        Me.txt_Marca.ReadOnly = False
        Me.txt_Mod.ReadOnly = False
        Me.txt_Pro.ReadOnly = False
        Me.txtDescrip.ReadOnly = False
        Me.txt_Nserie.ReadOnly = False
        Me.txt_Notas.ReadOnly = False

        Me.CBtipoEquipo.Enabled = True
        Me.cbseccion.Enabled = True
        Me.CBEstado.Enabled = True

        Me.dtFcompra.Enabled = True
        Me.dtFGarantia.Enabled = True

        ' botones de agregar doc e img
        Me.tsbAgregardoc.Enabled = True
        Me.tsbDeldoc.Enabled = True
        Me.tsbagreImg.Enabled = True
        Me.tsbdelimg.Enabled = True

        dtTipoEquipo = ClasEquipos.consultaAux("SELECT NOMBRE FROM TIP_EQUIP ", "tbl_TIPOEQUIP")
        For Each row As DataRow In dtTipoEquipo.Rows
            CBtipoEquipo.Items.Add(CStr(row("NOMBRE")))
        Next

        dtSeccion = ClasEquipos.consultaAux("SELECT NOMBRE FROM SECCIONES ORDER BY NOMBRE ASC", "SECCIONES")
        For Each row As DataRow In dtSeccion.Rows
            cbseccion.Items.Add(CStr(row("NOMBRE")))
        Next

        tsSave.Enabled = True
        tsNew.Enabled = False
        tsDel.Enabled = False
        tipoOperacion = "M"

    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click

        If tipoOperacion = "A" Then ' Comprueba si es Alta nueva "A" o modificacion "M"
            'aNTES DE GUARDAR COMPROBAR SI REGISTRO YA EXISTE EN BBDD.
            '  MsgBox(ClasEquipos.buscaID(Me.txt_ID.Text))

            If ClasEquipos.buscaID(Me.txt_ID.Text) = True Then
                MsgBox("Atención, el IDEQUIPO ya está siendo utilizado en el Sistema.", MsgBoxStyle.Exclamation)
                ActiveControl = Me.txt_ID
                Me.txt_ID.Text = ""
                Exit Sub  ' Si el ID existe, se vuelve al Textbox para modificar valor.
            End If

            If MessageBox.Show("¿Esta seguro de que desea Guardar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Try
                    If ClasEquipos.InsertaEquipo("Insert Into EQUIPOS(IDEQUIPO,NOMBRE,DESCRIPCION,MARCA,MODELO,NSERIE,SECCION,TIPOEQUIPO,PROVEEDOR,FCOMPRA,FGARANTIA,ESTADO,NOTAS)" & _
                                                   "values(" & "'" & Me.txt_ID.Text & "'" & "," & "'" & Me.txt_Nombre.Text &
                                                   "'" & "," & "'" & Me.txtDescrip.Text & "'" & "," & "'" & Me.txt_Marca.Text &
                                                   "'" & "," & "'" & Me.txt_Mod.Text & "'" & "," & "'" & Me.txt_Nserie.Text &
                                                   "'" & "," & "'" & Me.cbseccion.Text & "'" & "," & "'" & Me.CBtipoEquipo.Text &
                                                   "'" & "," & "'" & Me.txt_Pro.Text & "'" & "," & "'" & Me.dtFcompra.Text &
                                                   "'" & "," & "'" & Me.dtFGarantia.Text & "'" & "," & "'" & Me.CBEstado.Text &
                                                   "'" & "," & "'" & Me.txt_Notas.Text & "'" & ")") = True Then

                        MsgBox("Registro Agregado Con Exito", MsgBoxStyle.Information)

                        Actualizar()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error " & ex.Message)
                End Try

                Me.txt_ID.ReadOnly = True
                Me.txt_Nombre.ReadOnly = True
                Me.txt_Marca.ReadOnly = True
                Me.txt_Mod.ReadOnly = True
                Me.txt_Pro.ReadOnly = True
                Me.txtDescrip.ReadOnly = True
                Me.txt_Nserie.ReadOnly = True
                Me.txt_Notas.ReadOnly = True

                Me.CBtipoEquipo.Enabled = False
                Me.cbseccion.Enabled = False
                Me.CBEstado.Enabled = False

                Me.dtFcompra.Enabled = False
                Me.dtFGarantia.Enabled = False

                tsSave.Enabled = False
                'tsDel.Enabled = False
                tsEdit.Enabled = True
                tsNew.Enabled = True
                tsDel.Enabled = True

            End If
        ElseIf tipoOperacion = "M" Then
            If ClasEquipos.actualizar("EQUIPOS", "NOMBRE = " + "'" + txt_Nombre.Text + "'" + "," + "DESCRIPCION =" + "'" + txtDescrip.Text + "'" + "," + "MARCA= " + "'" + txt_Marca.Text + "'" + "," + "MODELO= " + "'" + txt_Mod.Text +
                                       "'" + "," + "NSERIE = " + "'" + txt_Nserie.Text + "'" + "," + "PROVEEDOR= " + "'" + txt_Pro.Text + "'" + "," + "SECCION = " + "'" + cbseccion.Text + "'" + "," + "TIPOEQUIPO= " + "'" + CBtipoEquipo.Text +
                                       "'" + "," + "FCOMPRA = " + "'" + dtFcompra.Text + "'" + "," + "FGARANTIA= " + "'" + dtFGarantia.Text + "'" + "," + "ESTADO = " + "'" + CBEstado.Text + "'" + "," + "NOTAS = " + "'" + txt_Notas.Text + "'", " IDEQUIPO= " + "'" + txt_ID.Text + "'") Then

                Actualizar()
                'Me.txt_ID.ReadOnly = False
                Me.txt_Nombre.ReadOnly = True
                Me.txt_Marca.ReadOnly = True
                Me.txt_Mod.ReadOnly = True
                Me.txt_Pro.ReadOnly = True
                Me.txtDescrip.ReadOnly = True
                Me.txt_Nserie.ReadOnly = True
                Me.txt_Notas.ReadOnly = True

                Me.CBtipoEquipo.Enabled = False
                Me.cbseccion.Enabled = False
                Me.CBEstado.Enabled = False

                Me.dtFcompra.Enabled = False
                Me.dtFGarantia.Enabled = False

                Me.tsbAgregardoc.Enabled = False
                Me.tsbDeldoc.Enabled = False
                Me.tsbagreImg.Enabled = False
                Me.tsbdelimg.Enabled = False


                tsNew.Enabled = True
                tsDel.Enabled = True
                tsSave.Enabled = False
                MsgBox("Registro Modificado Con Exito", MsgBoxStyle.Information)
            End If
        End If

    End Sub

    Private Sub tsDel_Click(sender As Object, e As EventArgs) Handles tsDel.Click

        Dim valor As String

        If MessageBox.Show("¿Esta seguro de que desea Eliminar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                valor = txt_ID.Text
                Limpiabinding()
                ClasEquipos.Eliminar("EQUIPOS", "idEquipo = " & "'" & valor & "'")
                Actualizar()
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click

        'Añadir Nuevo Registro

        Limpiabinding()
        Me.txt_ID.Text = ""
        Me.txt_Nombre.Text = ""
        Me.txt_Marca.Text = ""
        Me.txt_Mod.Text = ""
        Me.txt_Pro.Text = ""
        Me.txtDescrip.Text = ""
        Me.txt_Nserie.Text = ""
        Me.txt_Notas.Text = ""

        Me.CBtipoEquipo.Text = ""
        Me.cbseccion.Text = ""
        Me.CBEstado.Text = ""

        Me.dtFcompra.Text = ""
        Me.dtFGarantia.Text = ""


        Me.txt_ID.ReadOnly = False
        Me.txt_Nombre.ReadOnly = False
        Me.txt_Marca.ReadOnly = False
        Me.txt_Mod.ReadOnly = False
        Me.txt_Pro.ReadOnly = False
        Me.txtDescrip.ReadOnly = False
        Me.txt_Nserie.ReadOnly = False
        Me.txt_Notas.ReadOnly = False

        Me.CBtipoEquipo.Enabled = True
        Me.cbseccion.Enabled = True
        Me.CBEstado.Enabled = True

        Me.dtFcompra.Enabled = True
        Me.dtFGarantia.Enabled = True

        dtTipoEquipo = ClasEquipos.consultaAux("SELECT NOMBRE FROM TIP_EQUIP ", "tbl_TIPOEQUIP")
        For Each row As DataRow In dtTipoEquipo.Rows
            CBtipoEquipo.Items.Add(CStr(row("NOMBRE")))
        Next

        dtSeccion = ClasEquipos.consultaAux("SELECT NOMBRE FROM SECCIONES", "SECCIONES")
        For Each row As DataRow In dtSeccion.Rows
            cbseccion.Items.Add(CStr(row("NOMBRE")))
        Next

        tsEdit.Enabled = False
        tsDel.Enabled = False
        tsSave.Enabled = True
        tipoOperacion = "A"

    End Sub

    Private Sub tsbAgregar_Click(sender As Object, e As EventArgs) Handles tsbAgregardoc.Click 'Agregar Adjuntos.

        Dim destinofile As String
        Dim tipofile As String
        Dim nombrefile As String
        Dim appPath As String = Application.StartupPath()

        OpenFileDialog1.Filter = "Archivos PDF|*.pdf|WORD 97-2003|*.doc|WORD 2007-2013|*.docx|EXCEL 2003|*.xls|EXCEL 2007-2013|*.xlsx|TEXTO|*.txt"
        OpenFileDialog1.Title = "Seleccione un archivo"
        OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Asignar solo el nombre del archivo.
            nombrefile = System.IO.Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName)
            ' Asignar la extension del archivo
            tipofile = System.IO.Path.GetExtension(OpenFileDialog1.FileName)
            destinofile = appPath + "\res\doc\" + txt_ID.Text + "_" + nombrefile + tipofile

            Try
                'Grabar en tabla equip_doc datos documento.
                If ClasEquipos.InsertaEquipo("Insert Into EQUIP_DOC(IDEQUIPO,NOMBRE,TIPO) VALUES(" + "'" + Me.txt_ID.Text + "'" + "," + "'" + nombrefile + "'" + "," + "'" + tipofile + "'" + ")") = True Then
                    MsgBox("Registro Agregado Con Exito", MsgBoxStyle.Information)

                    'Copiar el Archivo a la Carpeta \res\doc
                    FileSystem.CopyFile(OpenFileDialog1.FileName.ToString(), destinofile, True)
                    ' actualizar con la llamada al Evento 
                    Me.TabPage2_Enter(Me, New System.EventArgs)
                End If

            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
                MsgBox("Error al adjuntar documento.", MsgBoxStyle.Critical, "Aplicaciones Jovir")
            End Try
        End If

    End Sub

    Private Sub TabPage2_Enter(sender As Object, e As EventArgs) Handles TabPage2.Enter

        dgvDoc.DataSource = ClasEquipos.CargaDoc_Equip("SELECT * FROM EQUIP_DOC WHERE IDEQUIPO= " + "'" + Me.txt_ID.Text + "'" & "AND TIPO <> '.jpg' AND TIPO <>'.BMP'", "EQUIP_DOC")
        dgvDoc.AutoGenerateColumns = False
        dgvDoc.Columns("IDFILE").Visible = False
        dgvDoc.Columns("IDEQUIPO").Visible = False

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles tsbDeldoc.Click ' Eliminar adjuntos de tabla EQUIP_DOC y de la carpeta relacionada.

        Dim Fila As Integer
        Dim valor As Integer

        If MessageBox.Show("¿Esta seguro de que desea Eliminar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                'Elimina registro de BBBDD
                Fila = dgvDoc.CurrentRow.Index
                valor = Me.dgvDoc.Item(0, Fila).Value ' obtine el valor activo del campo idFile.
                MsgBox(valor)
                ClasEquipos.Eliminar("EQUIP_DOC", "idFILE = " & valor)
                Me.TabPage2_Enter(Me, New System.EventArgs) ' actualizar con la llamada al Evento 
                'Eliminar archivo de carpeta.
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        Dim appPath As String = Application.StartupPath()
        Dim fila As Integer
        Dim tipofile As String
        Dim nombrefile As String

        fila = dgvDoc.CurrentRow.Index
        nombrefile = Me.dgvDoc.Item(2, fila).Value
        tipofile = Me.dgvDoc.Item(3, fila).Value

        Try
            Process.Start(appPath + "\res\doc\" + txt_ID.Text + "_" + nombrefile + tipofile)
            '  MsgBox(appPath + "\res\doc\" + txt_ID.Text + "_" + nombrefile + tipofile)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub tsbagreImg_Click(sender As Object, e As EventArgs) Handles tsbagreImg.Click

        Dim destinofile As String
        Dim tipofile As String
        Dim nombrefile As String
        Dim appPath As String = Application.StartupPath()

        OpenFileDialog1.Filter = "Archivos IMAGEN|*.jpg|Bitmap|*.bmp"
        OpenFileDialog1.Title = "Seleccione un archivo"
        OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Asignar solo el nombre del archivo.
            nombrefile = System.IO.Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName)
            ' Asignar la extension del archivo
            tipofile = System.IO.Path.GetExtension(OpenFileDialog1.FileName)
            destinofile = appPath + "\res\doc\" + txt_ID.Text + "_" + nombrefile + tipofile

            Try
                'Grabar en tabla equip_doc datos documento.
                If ClasEquipos.InsertaEquipo("Insert Into EQUIP_DOC(IDEQUIPO,NOMBRE,TIPO) VALUES(" + "'" + Me.txt_ID.Text + "'" + "," + "'" + nombrefile + "'" + "," + "'" + tipofile + "'" + ")") = True Then
                    MsgBox("Registro Agregado Con Exito", MsgBoxStyle.Information)

                    'Copiar el Archivo a la Carpeta \res\doc
                    FileSystem.CopyFile(OpenFileDialog1.FileName.ToString(), destinofile, True)
                    ' actualizar con la llamada al Evento 
                    Me.TabPage3_Enter(Me, New System.EventArgs)
                End If

            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
                MsgBox("Error al adjuntar documento.", MsgBoxStyle.Critical, "Aplicaciones Jovir")
            End Try

        End If

    End Sub

    Private Sub TabPage3_Enter(sender As Object, e As EventArgs) Handles TabPage3.Enter

        dgvimages.DataSource = ClasEquipos.CargaDoc_Equip("SELECT * FROM EQUIP_DOC WHERE IDEQUIPO= " + "'" + Me.txt_ID.Text + "'" & "AND TIPO = '.jpg' OR TIPO ='.BMP'", "EQUIP_DOC")
        dgvimages.AutoGenerateColumns = False
        dgvimages.Columns("IDFILE").Visible = False
        dgvimages.Columns("IDEQUIPO").Visible = False

    End Sub

    Private Sub tsbverimg_Click(sender As Object, e As EventArgs) Handles tsbverimg.Click

        Dim appPath As String = Application.StartupPath()
        Dim fila As Integer
        Dim tipofile As String
        Dim nombrefile As String

        fila = dgvimages.CurrentRow.Index
        nombrefile = Me.dgvimages.Item(2, fila).Value
        tipofile = Me.dgvimages.Item(3, fila).Value

        Try
            Process.Start(appPath + "\res\doc\" + txt_ID.Text + "_" + nombrefile + tipofile)
            '  MsgBox(appPath + "\res\doc\" + txt_ID.Text + "_" + nombrefile + tipofile)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub txt_ID_TextChanged(sender As Object, e As EventArgs) Handles txt_ID.TextChanged

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ' Siempre que cambie el valor del ID del Equipo, se pasa al tabcontrol1 
        ' para así que se muestren las notas y se actualizen los tab de imagenes y de documentos.
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Me.TabControl1.SelectedTab = TabPage1

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click

        Me.Close()

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        NombreEquipo = txt_Nombre.Text

        If (FAddPlan Is Nothing) Then
            FAddPlan = New FrmAddPlan()
            'FAddPlan.MdiParent = Me
            FAddPlan.ShowDialog(Me)
        End If

    End Sub
End Class