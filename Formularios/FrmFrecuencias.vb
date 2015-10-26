Imports Microsoft.VisualBasic.FileIO

Public Class FrmFrecuencias

    Public ClasFrecuencias As New clFrecuencias

    Dim tipoOperacion As String

    Private Sub FrmFrecuencias_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub FrmFrecuencias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub FrmFrecuencias_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        FFrecuencias = Nothing

        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            errorConn = ex.Message.ToString
        End Try

    End Sub

    Private Sub FrmFrecuencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ClasFrecuencias.ConsultaFrecuencias("SELECT * FROM FRECUENCIAS ORDER BY DIAS ASC")

        dgvSecc.DataSource = ClasFrecuencias.bsFrecuencias
        dgvSecc.AutoGenerateColumns = True
        dgvSecc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'dgvSecc.AutoGenerateColumns = False
        'dgvSecc.Columns("IDFRECUENCIA").Visible = False
        'dgvSecc.Columns("DESCRIPCION").Visible = False
        'dgvSecc.Columns("DIAS").Visible = False

        'Asociar los Textbox con el Bindingsource para que muestre los datos.
        Enlacebin()

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click

        Me.Close()

    End Sub

    Private Sub Limpiabinding()

        Me.txt_ID.DataBindings.Clear()
        Me.txt_DESCRIPCION.DataBindings.Clear()
        Me.txt_DIAS.DataBindings.Clear()

    End Sub

    Private Sub Enlacebin()

        Me.txt_ID.DataBindings.Add("text", ClasFrecuencias.bsFrecuencias, "IDFRECUENCIA")
        Me.txt_DESCRIPCION.DataBindings.Add("text", ClasFrecuencias.bsFrecuencias, "DESCRIPCION")
        Me.txt_DIAS.DataBindings.Add("text", ClasFrecuencias.bsFrecuencias, "DIAS")

    End Sub

    Public Sub Actualizar(Optional ByVal bCargar As Boolean = True) ' Se utiliza para limpiar el datagridview y refrescar los datos modificados.

        '*** Actualizar y guardar cambios   
        If Not ClasFrecuencias.bsFrecuencias Is Nothing Then
            ClasFrecuencias.daFrecuencias.Update(CType(ClasFrecuencias.bsFrecuencias.DataSource, DataTable))
            If bCargar Then
                dgvSecc.Refresh()
                ClasFrecuencias.dsFrecuencias.Tables.Clear()
                FrmFrecuencias_Load(Me, New System.EventArgs)
            End If
        End If

    End Sub

    Private Sub tsDel_Click(sender As Object, e As EventArgs) Handles tsDel.Click

        Dim valor As String

        If MessageBox.Show("¿Esta seguro de que desea Eliminar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                valor = txt_ID.Text
                Limpiabinding()
                ClasFrecuencias.Eliminar("FRECUENCIAS", "IDFRECUENCIA = " & "'" & valor & "'")
                actualizar()
            Catch ex As Exception
                MessageBox.Show("Error " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click

        'Añadir Nuevo Registro

        Limpiabinding()
        Me.txt_ID.Text = ""
        Me.txt_DESCRIPCION.Text = ""
        Me.txt_DIAS.Text = ""

        'Me.txt_ID.ReadOnly = False
        Me.txt_DESCRIPCION.ReadOnly = False
        Me.txt_DIAS.ReadOnly = False

        tsEdit.Enabled = False
        tsDel.Enabled = False
        tsSave.Enabled = True
        tipoOperacion = "A"

    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click

        If tipoOperacion = "A" Then ' Comprueba si es Alta nueva "A" o modificacion "M"
            'ANTES DE GUARDAR COMPROBAR SI REGISTRO YA EXISTE EN BBDD.
            '  MsgBox(ClasEquipos.buscaID(Me.txt_ID.Text))

            If ClasFrecuencias.buscaID(Me.txt_ID.Text) Then
                MsgBox("Atención, el IDFRECUENCIA ya está siendo utilizado en el Sistema.", MsgBoxStyle.Exclamation)
                ActiveControl = Me.txt_ID
                Me.txt_ID.Text = ""
                Exit Sub  ' Si el ID existe, se vuelve al Textbox para modificar valor.
            End If

            If MessageBox.Show("¿Esta seguro de que desea Guardar el Registro Seleccionado?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Try
                    If ClasFrecuencias.InsertaFrecuencia("Insert Into FRECUENCIAS(DESCRIPCION,DIAS)" & _
                                                   "values(" & "'" & Me.txt_DESCRIPCION.Text & "'" & "," & "'" & Me.txt_DIAS.Text & "'" & ")") Then

                        'MsgBox("Registro Agregado Con Exito", MsgBoxStyle.Information)

                        Actualizar()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error " & ex.Message)
                End Try

                'Me.txt_ID.ReadOnly = True
                Me.txt_DESCRIPCION.ReadOnly = True
                Me.txt_DIAS.ReadOnly = True

                tsSave.Enabled = False
                tsEdit.Enabled = True
                tsNew.Enabled = True
                tsDel.Enabled = True

            End If
        ElseIf tipoOperacion = "M" Then
            If ClasFrecuencias.actualizar("FRECUENCIAS", "DESCRIPCION = " + "'" + txt_DESCRIPCION.Text + "'" + "," + "DIAS = " + "'" + txt_DIAS.Text + "'", " IDFRECUENCIA= " + "'" + txt_ID.Text + "'") Then

                Actualizar()
                'Me.txt_ID.ReadOnly = False
                Me.txt_DESCRIPCION.ReadOnly = True
                Me.txt_DIAS.ReadOnly = True

                tsNew.Enabled = True
                tsDel.Enabled = True
                tsSave.Enabled = False
                'MsgBox("Registro Modificado Con Exito", MsgBoxStyle.Information)
            End If
        End If

    End Sub

    Private Sub tsEdit_Click(sender As Object, e As EventArgs) Handles tsEdit.Click

        Limpiabinding()

        'Me.txt_ID.ReadOnly = False
        Me.txt_DESCRIPCION.ReadOnly = False
        Me.txt_DIAS.ReadOnly = False

        tsSave.Enabled = True
        tsNew.Enabled = False
        tsDel.Enabled = False
        tipoOperacion = "M"

    End Sub
End Class