Public Class FrmSeccion

    Public ClasSecciones As New clSecciones

    Dim tipoOperacion As String

    Private Sub FrmSeccion_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub FrmSeccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub FrmSeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ClasSecciones.ConsultaSeccion("SELECT IDSECCION,NOMBRE,DESCRIPCION FROM SECCIONES")
        dgvSecc.DataSource = ClasSecciones.bsSecciones
        dgvSecc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        'Asociar los Textbox con el Bindingsource para que muestre los datos.
        Enlacebin()

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click

        desconectaBD()
        Me.Close()

    End Sub

    ' Eliminar Registros.
    Private Sub tsDel_Click(sender As Object, e As EventArgs) Handles tsDel.Click

        Dim valor As Integer

        If MessageBox.Show("¿Esta seguro de que desea Eliminar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                valor = txt_ID.Text
                Limpiabinding()
                'ClasSecciones.Eliminar("SECCIONES", "idseccion = " & ClasSecciones.dsSecciones.Tables("SECCIONES").Rows(dgvSecc.CurrentRow.Index).Item("IDSECCION"))
                ClasSecciones.Eliminar("SECCIONES", "idseccion = " & valor)
                Actualizar()
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        End If

    End Sub

    ' Añadir Nuevo Registro de Secciones.
    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click

        Limpiabinding()
        Me.txt_Nom.Text = " "
        Me.txt_Des.Text = " "
        Me.txt_Nom.ReadOnly = False
        Me.txt_Des.ReadOnly = False
        Me.txt_ID.Text = ClasSecciones.UltimoRegistro("idseccion", "secciones")
        tsEdit.Enabled = False
        tsDel.Enabled = False
        tsSave.Enabled = True
        tipoOperacion = "A"

    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click

        If tipoOperacion = "A" Then ' Comprueba si es Alta nueva "A" o modificacion "M"
            If MessageBox.Show("¿Esta seguro de que desea Guardar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Try
                    If ClasSecciones.InsertaSeccion("Insert Into SECCIONES(IDSECCION,NOMBRE,DESCRIPCION) values(" & "'" & Me.txt_ID.Text & "'" & "," & "'" & Me.txt_Nom.Text & "'" & "," & "'" & Me.txt_Des.Text & "'" & ")") = True Then
                        'prueba = ("Insert Into Secciones(" + txt_ID.Text + ",'" + txt_Nom.Text + "','" + txt_Des.Text + "')")
                        'MsgBox(prueba)
                        'MsgBox("Registro Agregado Con Exito")
                        ' Para actualizar los valores nuevos insertados y que se muestren en el dvgrid
                        Actualizar()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error " & ex.Message)
                End Try
                txt_Nom.ReadOnly = True
                txt_Des.ReadOnly = True

                tsSave.Enabled = False
                'tsDel.Enabled = False
                tsEdit.Enabled = True
                tsSave.Enabled = True
                tsNew.Enabled = True
                tsDel.Enabled = True
            End If
        ElseIf tipoOperacion = "M" Then
            If ClasSecciones.actualizar("SECCIONES", "NOMBRE = " + "'" + txt_Nom.Text + "'" + "," + "DESCRIPCION =" + "'" + txt_Des.Text + "'", "IDSECCION= " + txt_ID.Text) Then
                ' MsgBox("NOMBRE = " + "'" + txt_Nom.Text + "'" + "," + "DESCRIPCION =" + "'" + txt_Des.Text + "'")
                Actualizar()
                txt_Nom.ReadOnly = True
                txt_Des.ReadOnly = True
                tsNew.Enabled = True
                tsDel.Enabled = True
                tsSave.Enabled = False
            End If
        End If

    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click

        Limpiabinding()
        Me.txt_Nom.ReadOnly = False
        Me.txt_Des.ReadOnly = False
        tsSave.Enabled = True
        tsNew.Enabled = False
        tsDel.Enabled = False
        tipoOperacion = "M"

    End Sub

    ' *** Libero variable cuando desactvo form para cumplir validacion que solo se abre 1 vez.
    Private Sub FrmSeccion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        FSecciones = Nothing

    End Sub

    Private Sub Limpiabinding()

        Me.txt_Nom.DataBindings.Clear()
        Me.txt_ID.DataBindings.Clear()
        Me.txt_Des.DataBindings.Clear()

    End Sub

    Private Sub Enlacebin()

        Me.txt_ID.DataBindings.Add("text", ClasSecciones.bsSecciones, "idseccion")
        Me.txt_Nom.DataBindings.Add("text", ClasSecciones.bsSecciones, "NOMBRE")
        Me.txt_Des.DataBindings.Add("text", ClasSecciones.bsSecciones, "Descripcion")


    End Sub

    Public Sub Actualizar(Optional ByVal bCargar As Boolean = True) ' Se utiliza para limpiar el datagridview y refrescar los datos modificados.

        '*** Actualizar y guardar cambios   
        If Not ClasSecciones.bsSecciones Is Nothing Then
            ClasSecciones.daSecciones.Update(CType(ClasSecciones.bsSecciones.DataSource, DataTable))
            If bCargar Then
                dgvSecc.Refresh()
                ClasSecciones.dsSecciones.Tables.Clear()
                FrmSeccion_Load(Me, New System.EventArgs)
            End If
        End If

    End Sub

    Private Sub dgvSecc_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSecc.CellContentDoubleClick

        'Dim dgv As DataGridViewRow = dgvSecc.Rows(e.RowIndex) ' selecciona el valor correcto aunque se ordene.
        'MsgBox(dgv.Cells(0).Value.ToString)

    End Sub
End Class