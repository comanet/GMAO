Public Class FrmPersonal

    Public ClasPersonal As New clPersonal

    Dim dtCategorias As DataTable
    Dim dtEspecialidad As DataTable
    Dim tipoOperacion As String

    Private Sub FrmPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ClasPersonal.ConsultaSeccion("SELECT IDPERSONAL,NOMBRE,APELLIDOS,DNI,TELEFONO1,TELEFONO2,MOVIL,DIRECCION,HORA_COSTO,HORA_EXTRA,ESPECIALIDAD,CATEGORIA,EMAIL FROM PERSONAL")
        dgvSecc.DataSource = ClasPersonal.bsPersonal
        dgvSecc.AutoGenerateColumns = False
        dgvSecc.Columns("DIRECCION").Visible = False
        dgvSecc.Columns("HORA_COSTO").Visible = False
        dgvSecc.Columns("HORA_EXTRA").Visible = False
        dgvSecc.Columns("ESPECIALIDAD").Visible = False
        dgvSecc.Columns("CATEGORIA").Visible = False
        dgvSecc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        'Asociar los Textbox con el Bindingsource para que muestre los datos.
        Enlacebin()

    End Sub

    Private Sub FrmPersonal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub FrmPersonal_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click

        'Añadir Nuevo Registro
        Limpiabinding()
        Me.txt_Nom.Text = " "
        Me.txt_Ape.Text = " "
        Me.txt_DNI.Text = " "
        Me.txt_tlf1.Text = " "
        Me.txt_tlf2.Text = " "
        Me.txt_tlf3.Text = " "
        Me.txt_dir.Text = " "
        Me.cbCat.Text = " "
        Me.txt_email.Text = " "
        Me.txt_Hora.Text = " "
        Me.txt_HoraE.Text = " "

        Me.txt_Nom.ReadOnly = False
        Me.txt_Ape.ReadOnly = False
        Me.txt_DNI.ReadOnly = False
        Me.txt_tlf1.ReadOnly = False
        Me.txt_tlf2.ReadOnly = False
        Me.txt_tlf3.ReadOnly = False
        Me.txt_dir.ReadOnly = False 
        Me.txt_email.ReadOnly = False
        Me.txt_Hora.ReadOnly = False
        Me.txt_HoraE.ReadOnly = False
        Me.cbCat.Enabled = True
        Me.cbEspe.Enabled = True

        Me.txt_ID.Text = ClasPersonal.UltimoRegistro("idPersonal", "PERSONAL")

        'habilitar datos en los cb.
        dtCategorias = ClasPersonal.consultaAux("SELECT IDCATEGORIA,DESCRIPCION FROM CAT_PERSONAL", "tbl_CATPERSONAL")
        cbCat.DataSource = dtCategorias
        cbCat.DisplayMember = dtCategorias.Columns(1).Caption.ToString
        cbCat.SelectedIndex = -1

        dtEspecialidad = ClasPersonal.consultaAux("SELECT IDESPECIALIDAD,DESCRIPCION FROM ESPECIALIDADES", "tbl_ESPECIALIDAD")
        cbEspe.DataSource = dtEspecialidad
        cbEspe.DisplayMember = dtEspecialidad.Columns(1).Caption.ToString
        cbEspe.SelectedIndex = -1

        tsEdit.Enabled = False
        tsDel.Enabled = False
        tsSave.Enabled = True
        tipoOperacion = "A"

    End Sub

    Private Sub tsDel_Click(sender As Object, e As EventArgs) Handles tsDel.Click

        Dim valor As Integer

        If MessageBox.Show("¿Esta seguro de que desea Eliminar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                valor = txt_ID.Text
                Limpiabinding()
                ClasPersonal.Eliminar("PERSONAL", "idPersonal = " & valor)
                Actualizar()
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub Enlacebin()

        Me.txt_ID.DataBindings.Add("text", ClasPersonal.bsPersonal, "idPersonal")
        Me.txt_Nom.DataBindings.Add("text", ClasPersonal.bsPersonal, "NOMBRE")
        Me.txt_Ape.DataBindings.Add("text", ClasPersonal.bsPersonal, "APELLIDOS")
        Me.txt_DNI.DataBindings.Add("text", ClasPersonal.bsPersonal, "DNI")
        Me.txt_dir.DataBindings.Add("text", ClasPersonal.bsPersonal, "DIRECCION")
        Me.txt_tlf1.DataBindings.Add("text", ClasPersonal.bsPersonal, "TELEFONO1")
        Me.txt_tlf2.DataBindings.Add("text", ClasPersonal.bsPersonal, "TELEFONO2")
        Me.txt_tlf3.DataBindings.Add("text", ClasPersonal.bsPersonal, "MOVIL")
        Me.txt_Hora.DataBindings.Add("text", ClasPersonal.bsPersonal, "HORA_COSTO")
        Me.txt_HoraE.DataBindings.Add("text", ClasPersonal.bsPersonal, "HORA_EXTRA")

        Me.cbCat.DataBindings.Add("text", ClasPersonal.bsPersonal, "CATEGORIA")
        Me.cbEspe.DataBindings.Add("text", ClasPersonal.bsPersonal, "ESPECIALIDAD")

        Me.txt_email.DataBindings.Add("text", ClasPersonal.bsPersonal, "EMAIL")

    End Sub

    Private Sub Limpiabinding()

        Me.txt_ID.DataBindings.Clear()
        Me.txt_Nom.DataBindings.Clear()
        Me.txt_Ape.DataBindings.Clear()
        Me.txt_DNI.DataBindings.Clear()
        Me.txt_tlf1.DataBindings.Clear()
        Me.txt_tlf2.DataBindings.Clear()
        Me.txt_tlf3.DataBindings.Clear()
        Me.txt_dir.DataBindings.Clear()
        Me.txt_Hora.DataBindings.Clear()
        Me.txt_HoraE.DataBindings.Clear()
        Me.cbCat.DataBindings.Clear()
        Me.cbEspe.DataBindings.Clear()
        Me.txt_email.DataBindings.Clear()

    End Sub

    Public Sub Actualizar(Optional ByVal bCargar As Boolean = True) ' Se utiliza para limpiar el datagridview y refrescar los datos modificados.

        '*** Actualizar y guardar cambios   
        If Not ClasPersonal.bsPersonal Is Nothing Then
            ClasPersonal.daPersonal.Update(CType(ClasPersonal.bsPersonal.DataSource, DataTable))
            If bCargar Then
                dgvSecc.Refresh()
                ClasPersonal.dsPersonal.Tables.Clear()
                FrmPersonal_Load(Me, New System.EventArgs)
            End If
        End If

    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click

        Limpiabinding()

        Me.txt_Nom.ReadOnly = False
        Me.txt_Ape.ReadOnly = False
        Me.txt_DNI.ReadOnly = False
        Me.txt_tlf1.ReadOnly = False
        Me.txt_tlf2.ReadOnly = False
        Me.txt_tlf3.ReadOnly = False
        Me.txt_dir.ReadOnly = False
        Me.txt_email.ReadOnly = False
        Me.txt_Hora.ReadOnly = False
        Me.txt_HoraE.ReadOnly = False

        Me.cbCat.Enabled = True
        Me.cbEspe.Enabled = True

        ' Carga los COMBOS CON LAS TABLAS AUXILIARES NECESARIAS.

        dtEspecialidad = ClasPersonal.consultaAux("SELECT DESCRIPCION FROM ESPECIALIDADES", "tbl_ESPECIALIDAD")
        For Each row As DataRow In dtEspecialidad.Rows
            cbEspe.Items.Add(CStr(row("DESCRIPCION")))
        Next

        dtCategorias = ClasPersonal.consultaAux("SELECT DESCRIPCION FROM CAT_PERSONAL", "tbl_CATEGORIAS")
        For Each row As DataRow In dtCategorias.Rows
            cbCat.Items.Add(CStr(row("DESCRIPCION")))
        Next

        tsSave.Enabled = True
        tsNew.Enabled = False
        tsDel.Enabled = False
        tipoOperacion = "M"

    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click

        If tipoOperacion = "A" Then ' Comprueba si es Alta nueva "A" o modificacion "M"
            If MessageBox.Show("¿Esta seguro de que desea Guardar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Try
                    If ClasPersonal.InsertaSeccion("Insert Into PERSONAL(IDPERSONAL,NOMBRE,APELLIDOS,DNI,DIRECCION,TELEFONO1,TELEFONO2,MOVIL,HORA_COSTO,HORA_EXTRA,CATEGORIA,ESPECIALIDAD,EMAIL)" & _
                                                   "values(" & "'" & Me.txt_ID.Text & "'" & "," & "'" & Me.txt_Nom.Text &
                                                   "'" & "," & "'" & Me.txt_Ape.Text & "'" & "," & "'" & Me.txt_DNI.Text &
                                                   "'" & "," & "'" & Me.txt_dir.Text & "'" & "," & "'" & Me.txt_tlf1.Text &
                                                   "'" & "," & "'" & Me.txt_tlf2.Text & "'" & "," & "'" & Me.txt_tlf3.Text &
                                                   "'" & "," & (Replace(Me.txt_Hora.Text, ",", ".")) & "," & (Replace(Me.txt_HoraE.Text, ",", ".")) &
                                                   "," & "'" & Me.cbCat.Text & "'" & "," & "'" & Me.cbEspe.Text &
                                                   "'" & "," & "'" & Me.txt_email.Text & "'" & ")") = True Then
                        'prueba = ("Insert Into Secciones(" + txt_ID.Text + ",'" + txt_Nom.Text + "','" + txt_Des.Text + "')")
                        'MsgBox(prueba)
                        'MsgBox("Registro Agregado Con Exito", MsgBoxStyle.Information)
                        ' Para actualizar los valores nuevos insertados y que se muestren en el dvgrid
                        Actualizar()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error " & ex.Message)
                End Try
                txt_Nom.ReadOnly = True
                txt_Ape.ReadOnly = True
                Me.txt_DNI.ReadOnly = True
                Me.txt_tlf1.ReadOnly = True
                Me.txt_tlf2.ReadOnly = True
                Me.txt_tlf3.ReadOnly = True
                Me.txt_dir.ReadOnly = True
                Me.txt_email.ReadOnly = True
                Me.txt_Hora.ReadOnly = True
                Me.txt_HoraE.ReadOnly = True
                Me.cbCat.Enabled = False
                Me.cbEspe.Enabled = False

                tsSave.Enabled = False
                'tsDel.Enabled = False
                tsEdit.Enabled = True
                tsSave.Enabled = True
                tsNew.Enabled = True
                tsDel.Enabled = True
            End If
        ElseIf tipoOperacion = "M" Then

            If ClasPersonal.actualizar("PERSONAL", "NOMBRE = " + "'" + txt_Nom.Text + "'" + "," + "APELLIDOS =" + "'" + txt_Ape.Text + "'" + "," + "DNI= " + "'" + txt_DNI.Text + "'" + "," + "DIRECCION= " + "'" + txt_dir.Text +
                                       "'" + "," + "TELEFONO1 = " + "'" + txt_tlf1.Text + "'" + "," + "TELEFONO2= " + "'" + txt_tlf2.Text + "'" + "," + "MOVIL = " + "'" + txt_tlf3.Text + "'" + "," + "HORA_COSTO= " + (Replace(Me.txt_Hora.Text, ",", ".")) +
                                        "," + "HORA_EXTRA = " + (Replace(Me.txt_HoraE.Text, ",", ".")) + "," + "ESPECIALIDAD= " + "'" + cbEspe.Text + "'" + "," + "CATEGORIA = " + "'" + cbCat.Text + "'" + "," + "EMAIL = " + "'" + txt_email.Text + "'", " IDPERSONAL= " + txt_ID.Text) Then

                Actualizar()
                txt_Nom.ReadOnly = True
                txt_Ape.ReadOnly = True
                Me.txt_DNI.ReadOnly = True
                Me.txt_tlf1.ReadOnly = True
                Me.txt_tlf2.ReadOnly = True
                Me.txt_tlf3.ReadOnly = True
                Me.txt_dir.ReadOnly = True
                Me.txt_email.ReadOnly = True
                Me.txt_Hora.ReadOnly = True
                Me.txt_HoraE.ReadOnly = True
                Me.cbCat.Enabled = False
                Me.cbEspe.Enabled = False

                tsNew.Enabled = True
                tsDel.Enabled = True
                tsSave.Enabled = False
                'MsgBox("Registro Modificado Con Exito", MsgBoxStyle.Information)
            End If
        End If

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click

        Me.Close()

    End Sub

    Private Sub FrmPersonal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        FPersonal = Nothing

    End Sub

    Private Sub txt_Hora_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Hora.KeyPress, txt_HoraE.KeyPress

        If InStr(1, "0123456789," & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If

    End Sub

    'Private Sub txt_HoraE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_HoraE.KeyPress

    '    If InStr(1, "0123456789," & Chr(8), e.KeyChar) = 0 Then
    '        e.KeyChar = ""
    '    End If

    'End Sub

End Class