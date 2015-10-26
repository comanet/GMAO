Public Class FrmAlmacen

    Public ClasAlma As New clAlmacen

    Dim tipoOperacion As String

    Private Sub FrmAlmacen_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub FrmAlmacen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub FrmAlmacen_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        FAlmacen = Nothing

        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            errorConn = ex.Message.ToString
        End Try

    End Sub

    Private Sub FrmAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ClasAlma.ConsultaAlmacen("SELECT IDALMACEN,DESCRIPCION,UBICACION FROM ALMACEN")
        dgvAlma.DataSource = ClasAlma.bsAlmacen
        dgvAlma.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'Asociar los Textbox con el Bindingsource para que muestre los datos.
        Enlacebin()

    End Sub

    Private Sub Limpiabinding()

        Me.txt_Des.DataBindings.Clear()
        Me.txt_ID.DataBindings.Clear()
        Me.txt_Ubi.DataBindings.Clear()

    End Sub

    Private Sub Enlacebin()

        Me.txt_ID.DataBindings.Add("text", ClasAlma.bsAlmacen, "IDALMACEN")
        Me.txt_Des.DataBindings.Add("text", ClasAlma.bsAlmacen, "DESCRIPCION")
        Me.txt_Ubi.DataBindings.Add("text", ClasAlma.bsAlmacen, "UBICACION")

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click

        Me.Close()

    End Sub

    Private Sub tsNew_Click(sender As Object, e As EventArgs)

        Limpiabinding()
        Me.txt_ID.Text = ""
        Me.txt_Des.Text = ""
        Me.txt_Ubi.Text = ""

        Me.txt_ID.ReadOnly = False
        Me.txt_Des.ReadOnly = False
        Me.txt_Ubi.ReadOnly = False

        tsEdit.Enabled = False
        tsDel.Enabled = False
        tsSave.Enabled = True
        tipoOperacion = "A"

    End Sub

    Private Sub tsDel_Click(sender As Object, e As EventArgs)

        Dim valor As Integer

        If MessageBox.Show("¿Esta seguro de que desea Eliminar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                valor = txt_ID.Text
                Limpiabinding()
                'ClasSecciones.Eliminar("SECCIONES", "idseccion = " & ClasSecciones.dsSecciones.Tables("SECCIONES").Rows(dgvSecc.CurrentRow.Index).Item("IDSECCION"))
                ClasAlma.Eliminar("ALMACEN", "IDALMACEN = " & valor)
                Actualizar()
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs)
        Limpiabinding()
        Me.txt_ID.ReadOnly = False
        Me.txt_Des.ReadOnly = False
        Me.txt_Ubi.ReadOnly = False

        tsSave.Enabled = True
        tsNew.Enabled = False
        tsDel.Enabled = False
        tipoOperacion = "M"

    End Sub

    Public Sub Actualizar(Optional ByVal bCargar As Boolean = True) ' Se utiliza para limpiar el datagridview y refrescar los datos modificados.

        '*** Actualizar y guardar cambios   
        If Not ClasAlma.bsAlmacen Is Nothing Then
            ClasAlma.daAlmacen.Update(CType(ClasAlma.bsAlmacen.DataSource, DataTable))
            If bCargar Then
                dgvAlma.Refresh()
                ClasAlma.dsAlmacen.Tables.Clear()
                FrmAlmacen_Load(Me, New System.EventArgs)
            End If
        End If

    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs)

        If tipoOperacion = "A" Then ' Comprueba si es Alta nueva "A" o modificacion "M"
            If MessageBox.Show("¿Esta seguro de que desea Guardar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Try
                    If ClasAlma.InsertaAlma("Insert Into ALMACEN(IDALMACEN,DESCRIPCION,UBICACION) values(" & "'" & Me.txt_ID.Text & "'" & "," & "'" & Me.txt_Des.Text & "'" & "," & "'" & Me.txt_Ubi.Text & "'" & ")") = True Then
                        'prueba = ("Insert Into Secciones(" + txt_ID.Text + ",'" + txt_Nom.Text + "','" + txt_Des.Text + "')")
                        'MsgBox(prueba)
                        'MsgBox("Registro Agregado Con Exito", MsgBoxStyle.Information)
                        ' Para actualizar los valores nuevos insertados y que se muestren en el dvgrid
                        Actualizar()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error " & ex.Message)
                End Try
                txt_ID.ReadOnly = True
                txt_Des.ReadOnly = True
                txt_Ubi.ReadOnly = True

                tsSave.Enabled = False
                'tsDel.Enabled = False
                tsEdit.Enabled = True
                tsSave.Enabled = True
                tsNew.Enabled = True
                tsDel.Enabled = True
            End If
        ElseIf tipoOperacion = "M" Then
            If ClasAlma.actualizar("ALMACEN", "IDALMACEN = " + "'" + txt_ID.Text + "'" + "," + "DESCRIPCION = " + "'" + txt_Des.Text + "'" + "," + "UBICACION = " + "'" + txt_Ubi.Text + "'", "IDALMACEN= " + "'" + txt_ID.Text + "'") Then
                ' MsgBox("NOMBRE = " + "'" + txt_Nom.Text + "'" + "," + "DESCRIPCION =" + "'" + txt_Des.Text + "'")
                Actualizar()
                txt_ID.ReadOnly = True
                txt_Des.ReadOnly = True
                txt_Ubi.ReadOnly = True
                tsNew.Enabled = True
                tsDel.Enabled = True
                tsSave.Enabled = False
                'MsgBox("Registro Modificado Con Exito", MsgBoxStyle.Information)
            End If
        End If

    End Sub
End Class