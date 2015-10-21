Public Class FrmRepuestos

    Public ClasRepuesto As New clRepuesto

    Dim tipoOperacion As String

    Private Sub FrmRepuesto_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub FrmRepuesto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub FrmRepuesto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        FRepuestos = Nothing

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click

        Me.Close()

    End Sub

    Private Sub FrmRepuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ClasRepuesto.ConsultaRepuesto("SELECT REFERENCIA,MODELO,NOMBRE,MARCA,NOTAS,PROVEEDOR,UNIDAD,STOCKMIN,STOCKMAX,PRECIO FROM REPUESTOS")
        dgvRepuesto.DataSource = ClasRepuesto.bsRepuesto
        'Asociar los Textbox con el Bindingsource para que muestre los datos.
        Enlacebin()

    End Sub

    Private Sub Enlacebin()

        Me.txt_REF.DataBindings.Add("text", ClasRepuesto.bsRepuesto, "REFERENCIA")
        Me.txt_Marc.DataBindings.Add("text", ClasRepuesto.bsRepuesto, "MARCA")
        Me.txt_Mod.DataBindings.Add("text", ClasRepuesto.bsRepuesto, "MODELO")
        Me.txt_Nom.DataBindings.Add("text", ClasRepuesto.bsRepuesto, "NOMBRE")
        Me.txt_Notas.DataBindings.Add("text", ClasRepuesto.bsRepuesto, "NOTAS")
        Me.txt_Prov.DataBindings.Add("text", ClasRepuesto.bsRepuesto, "PROVEEDOR")
        Me.txt_StcMax.DataBindings.Add("text", ClasRepuesto.bsRepuesto, "STOCKMAX")
        Me.txt_StcMin.DataBindings.Add("text", ClasRepuesto.bsRepuesto, "STOCKMIN")
        Me.txt_Precio.DataBindings.Add("text", ClasRepuesto.bsRepuesto, "PRECIO")
        Me.cbUM.DataBindings.Add("text", ClasRepuesto.bsRepuesto, "UNIDAD")

    End Sub

    Private Sub Limpiabinding()

        Me.txt_REF.DataBindings.Clear()
        Me.txt_Marc.DataBindings.Clear()
        Me.txt_Mod.DataBindings.Clear()
        Me.txt_Nom.DataBindings.Clear()
        Me.txt_Notas.DataBindings.Clear()
        Me.txt_Prov.DataBindings.Clear()
        Me.txt_StcMax.DataBindings.Clear()
        Me.txt_StcMin.DataBindings.Clear()
        Me.txt_Precio.DataBindings.Clear()
        Me.cbUM.DataBindings.Clear()

    End Sub
    Public Sub Actualizar(Optional ByVal bCargar As Boolean = True) ' Se utiliza para limpiar el datagridview y refrescar los datos modificados.

        '*** Actualizar y guardar cambios   
        If Not ClasRepuesto.bsRepuesto Is Nothing Then
            ClasRepuesto.daRepuesto.Update(CType(ClasRepuesto.bsRepuesto.DataSource, DataTable))
            If bCargar Then
                dgvRepuesto.Refresh()
                ClasRepuesto.dsRepuesto.Tables.Clear()
                FrmRepuestos_Load(Me, New System.EventArgs)
            End If
        End If

    End Sub

    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click

        Limpiabinding()

        Me.txt_REF.Text = ""
        Me.txt_Marc.Text = ""
        Me.txt_Mod.Text = ""
        Me.txt_Nom.Text = ""
        Me.txt_Notas.Text = ""
        Me.txt_Prov.Text = ""
        Me.txt_StcMax.Text = ""
        Me.txt_StcMin.Text = ""
        Me.txt_Precio.Text = ""
        Me.cbUM.SelectedIndex = 0

        Me.txt_REF.ReadOnly = False
        Me.txt_Marc.ReadOnly = False
        Me.txt_Mod.ReadOnly = False
        Me.txt_Nom.ReadOnly = False
        Me.txt_Notas.ReadOnly = False
        Me.txt_Prov.ReadOnly = False
        Me.txt_StcMax.ReadOnly = False
        Me.txt_StcMin.ReadOnly = False
        Me.txt_Precio.ReadOnly = False
        Me.cbUM.Enabled = True

        tsEdit.Enabled = False
        tsDel.Enabled = False
        tsSave.Enabled = True
        tipoOperacion = "A"

    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click

        Limpiabinding()

        Me.txt_REF.ReadOnly = False
        Me.txt_Marc.ReadOnly = False
        Me.txt_Mod.ReadOnly = False
        Me.txt_Nom.ReadOnly = False
        Me.txt_Notas.ReadOnly = False
        Me.txt_Prov.ReadOnly = False
        Me.txt_StcMax.ReadOnly = False
        Me.txt_StcMin.ReadOnly = False
        Me.txt_Precio.ReadOnly = False
        Me.cbUM.Enabled = True

        tsSave.Enabled = True
        tsNew.Enabled = False
        tsDel.Enabled = False
        tipoOperacion = "M"

    End Sub

    Private Sub tsDel_Click(sender As Object, e As EventArgs) Handles tsDel.Click

        Dim valor As String

        If MessageBox.Show("¿Esta seguro de que desea Eliminar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                valor = txt_REF.Text
                Limpiabinding()
                'ClasSecciones.Eliminar("SECCIONES", "idseccion = " & ClasSecciones.dsSecciones.Tables("SECCIONES").Rows(dgvSecc.CurrentRow.Index).Item("IDSECCION"))
                ClasRepuesto.Eliminar("REPUESTOS", "REFERENCIA = " & "'" & valor & "'") ' PUEDEN HABER 2 REPUESTOS CON MISMA REFERENCIA??? - ESTABLECIDO VALOR UNICO EN INDICE.
                Actualizar()
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click

        If tipoOperacion = "A" Then ' Comprueba si es Alta nueva "A" o modificacion "M"
            If MessageBox.Show("¿Esta seguro de que desea Guardar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Try
                    If ClasRepuesto.InsertaRepuesto("Insert Into REPUESTOS(REFERENCIA,NOMBRE,MARCA,MODELO,NOTAS,PROVEEDOR,STOCKMAX,STOCKMIN,UNIDAD,PRECIO)" & _
                                                   "values(" & "'" & Me.txt_REF.Text & "'" & "," & "'" & Me.txt_Nom.Text &
                                                   "'" & "," & "'" & Me.txt_Marc.Text & "'" & "," & "'" & Me.txt_Mod.Text &
                                                   "'" & "," & "'" & Me.txt_Notas.Text & "'" & "," & "'" & Me.txt_Prov.Text &
                                                   "'" & "," & "'" & Me.txt_StcMax.Text & "'" & "," & "'" & Me.txt_StcMin.Text &
                                                   "'" & "," & "'" & Me.cbUM.Text & "'" & "," & (Replace(Me.txt_Precio.Text, ",", ".")) & ")") = True Then
                        'prueba = ("Insert Into Secciones(" + txt_ID.Text + ",'" + txt_Nom.Text + "','" + txt_Des.Text + "')")
                        'MsgBox(prueba)
                        'MsgBox("Registro Agregado Con Exito", MsgBoxStyle.Information)
                        ' Para actualizar los valores nuevos insertados y que se muestren en el dvgrid
                        Actualizar()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error " & ex.Message)
                End Try
                Me.txt_REF.ReadOnly = True
                Me.txt_Marc.ReadOnly = True
                Me.txt_Mod.ReadOnly = True
                Me.txt_Nom.ReadOnly = True
                Me.txt_Notas.ReadOnly = True
                Me.txt_Prov.ReadOnly = True
                Me.txt_StcMax.ReadOnly = True
                Me.txt_StcMin.ReadOnly = True
                Me.txt_Precio.ReadOnly = True
                Me.cbUM.Enabled = False

                tsSave.Enabled = False
                tsEdit.Enabled = True
                tsSave.Enabled = True
                tsNew.Enabled = True
                tsDel.Enabled = True
            End If
        ElseIf tipoOperacion = "M" Then
            If ClasRepuesto.actualizar("REPUESTOS", "REFERENCIA = " + "'" + txt_REF.Text + "'" + "," + "MODELO =" + "'" + txt_Mod.Text + "'" + "," + "MARCA= " + "'" + txt_Marc.Text + "'" + "," + "NOMBRE= " + "'" + txt_Nom.Text +
                                       "'" + "," + "NOTAS = " + "'" + txt_Notas.Text + "'" + "," + "PROVEEDOR= " + "'" + txt_Prov.Text + "'" + "," + "UNIDAD = " + "'" + cbUM.Text + "'" + "," + "STOCKMAX= " + "'" + txt_StcMax.Text +
                                       "'" + "," + "STOCKMIN = " + "'" + txt_StcMin.Text + "'" + "," + "PRECIO= " + (Replace(Me.txt_Precio.Text, ",", ".")), "REFERENCIA= " + "'" + txt_REF.Text + "'") Then
                Actualizar()

                Me.txt_REF.ReadOnly = True
                Me.txt_Marc.ReadOnly = True
                Me.txt_Mod.ReadOnly = True
                Me.txt_Nom.ReadOnly = True
                Me.txt_Notas.ReadOnly = True
                Me.txt_Prov.ReadOnly = True
                Me.txt_StcMax.ReadOnly = True
                Me.txt_StcMin.ReadOnly = True
                Me.txt_Precio.ReadOnly = True
                Me.cbUM.Enabled = False

                'MsgBox("Registro Modificado Con Exito", MsgBoxStyle.Information)
                tsNew.Enabled = True
                tsDel.Enabled = True
                tsSave.Enabled = False
            End If
        End If

    End Sub

End Class