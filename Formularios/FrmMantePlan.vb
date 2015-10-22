Public Class FrmMantePlan

    Public ClasMantePlan As New clMantePlan

    Dim tipoOperacion As String

    Private Sub FrmMantePlan_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub FrmMantePlan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub FrmMantePlan_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FMantePlan = Nothing
    End Sub

    Private Sub FrmMantePlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ClasMantePlan.ConsultaMantePlan("SELECT * FROM MANTEPLAN ORDER BY IDPLAN ASC")
        dgvmantep.DataSource = ClasMantePlan.bsMantePlan
        dgvmantep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        'Asociar los Textbox con el Bindingsource para que muestre los datos.
        Enlacebin()

    End Sub

    Private Sub Limpiabinding()

        Me.txt_ID.DataBindings.Clear()
        Me.txt_NOMBRE.DataBindings.Clear()
        Me.txt_DESCRIPCION.DataBindings.Clear()

    End Sub

    Private Sub Enlacebin()

        Me.txt_ID.DataBindings.Add("text", ClasMantePlan.bsMantePlan, "IDPLAN")
        Me.txt_NOMBRE.DataBindings.Add("text", ClasMantePlan.bsMantePlan, "NOMBRE")
        Me.txt_DESCRIPCION.DataBindings.Add("text", ClasMantePlan.bsMantePlan, "DESCRIPCION")

        Me.txt_ID.Text = Trim(Me.txt_ID.Text)
        Me.txt_NOMBRE.Text = Trim(Me.txt_NOMBRE.Text)
        Me.txt_DESCRIPCION.Text = Trim(Me.txt_DESCRIPCION.Text)

    End Sub

    Public Sub Actualizar(Optional ByVal bCargar As Boolean = True) ' Se utiliza para limpiar el datagridview y refrescar los datos modificados.

        '*** Actualizar y guardar cambios
        Me.txt_ID.Text = Trim(Me.txt_ID.Text)
        Me.txt_NOMBRE.Text = Trim(Me.txt_NOMBRE.Text)
        Me.txt_DESCRIPCION.Text = Trim(Me.txt_DESCRIPCION.Text)

        If Not ClasMantePlan.bsMantePlan Is Nothing Then
            ClasMantePlan.daMantePlan.Update(CType(ClasMantePlan.bsMantePlan.DataSource, DataTable))
            If bCargar Then
                dgvmantep.Refresh()
                ClasMantePlan.dsMantePlan.Tables.Clear()
                FrmMantePlan_Load(Me, New System.EventArgs)
            End If
        End If

    End Sub

    Private Sub tsDel_Click(sender As Object, e As EventArgs) Handles tsDel.Click

        Dim valor As String

        If MessageBox.Show("¿Esta seguro de que desea Eliminar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                valor = txt_ID.Text
                Limpiabinding()
                ClasMantePlan.Eliminar("MANTEPLAN", "IDPLAN = " & "'" & valor & "'")
                actualizar()
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click

        Me.Close()

    End Sub

    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click

        'Añadir Nuevo Registro

        Limpiabinding()
        Me.txt_ID.Text = ""
        Me.txt_DESCRIPCION.Text = ""
        Me.txt_NOMBRE.Text = ""

        Me.txt_ID.ReadOnly = False
        Me.txt_DESCRIPCION.ReadOnly = False
        Me.txt_NOMBRE.ReadOnly = False

        tsEdit.Enabled = False
        tsDel.Enabled = False
        tsSave.Enabled = True
        tipoOperacion = "A"

    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click

        If tipoOperacion = "A" Then ' Comprueba si es Alta nueva "A" o modificacion "M"
            'ANTES DE GUARDAR COMPROBAR SI REGISTRO YA EXISTE EN BBDD.

            If ClasMantePlan.buscaID(Me.txt_ID.Text) Then
                MsgBox("Atención, el IDPLAN ya está siendo utilizado en el Sistema.", MsgBoxStyle.Exclamation)
                ActiveControl = Me.txt_ID
                Me.txt_ID.Text = ""
                Exit Sub  ' Si el ID existe, se vuelve al Textbox para modificar valor.
            End If

            If MessageBox.Show("¿Esta seguro de que desea Guardar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Try
                    If ClasMantePlan.InsertaMantePLan("Insert Into MANTEPLAN(IDPLAN,NOMBRE,DESCRIPCION)" & _
                                                   "values(" & "'" & Me.txt_ID.Text & "'" & "," & "'" & Me.txt_NOMBRE.Text & "'" & "," & "'" & Me.txt_DESCRIPCION.Text & "'" & ")") Then

                        'MsgBox("Registro Agregado Con Exito", MsgBoxStyle.Information)

                        Actualizar()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error " & ex.Message)
                End Try

                Me.txt_ID.ReadOnly = True
                Me.txt_NOMBRE.ReadOnly = True
                Me.txt_DESCRIPCION.ReadOnly = True

                tsSave.Enabled = False
                tsEdit.Enabled = True
                tsNew.Enabled = True
                tsDel.Enabled = True

            End If
        ElseIf tipoOperacion = "M" Then
            If ClasMantePlan.actualizar("MANTEPLAN", "IDPLAN = " + "'" + txt_ID.Text + "'" + "," + "NOMBRE = " + "'" + txt_NOMBRE.Text + "'" + "," + "DESCRIPCION = " + "'" + txt_DESCRIPCION.Text + "'", " IDPLAN= " + "'" + txt_ID.Text + "'") Then

                Actualizar()
                Me.txt_ID.ReadOnly = True
                Me.txt_DESCRIPCION.ReadOnly = True
                Me.txt_NOMBRE.ReadOnly = True

                tsNew.Enabled = True
                tsDel.Enabled = True
                tsSave.Enabled = False
                'MsgBox("Registro Modificado Con Exito", MsgBoxStyle.Information)
            End If
        End If

    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click

        Limpiabinding()

        Me.txt_ID.ReadOnly = False
        Me.txt_DESCRIPCION.ReadOnly = False
        Me.txt_NOMBRE.ReadOnly = False

        tsSave.Enabled = True
        tsNew.Enabled = False
        tsDel.Enabled = False
        tipoOperacion = "M"

    End Sub
End Class