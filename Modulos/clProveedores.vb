Imports System.Data.SqlClient

Public Class clProveedores

    Public dsProveedores As New DataSet
    Public daProveedores As New SqlDataAdapter
    Public da As New SqlDataAdapter
    Public bsProveedores As New BindingSource
    Private comando As SqlCommand
    Private cmb As SqlCommandBuilder

    Public Sub ConsultaProveedores(ByVal sql As String)

        cnn.Open()

        daProveedores = New SqlDataAdapter(sql, cnn)
        'cmb = New SqlCommandBuilder(daProveedores)
        daProveedores.Fill(dsProveedores, "PROVEEDOR")
        bsProveedores.DataSource = dsProveedores.Tables("PROVEEDOR")

        cnn.Close()

    End Sub

    ' Actualizar/Modificar. Registros.
    Public Function actualizar(ByVal tabla As String, ByVal campos As String, ByVal condicion As String) As Boolean

        Dim query As String
        Dim i As Integer

        cnn.Open()

        query = "Update " & tabla & " Set " & campos & " Where " & condicion
        comando = New SqlCommand(query, cnn)
        i = comando.ExecuteNonQuery()

        cnn.Close()

        If i > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function InsertaProveedores(ByVal query As String) As Boolean

        Dim i As Integer

        cnn.Open()

        comando = New SqlCommand(query, cnn)
        i = comando.ExecuteNonQuery

        cnn.Close()

        If i > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    ' Metodo Eliminar Registros. Paramentros :Nombre de Tabla y Condicion. Return : True
    Public Function Eliminar(ByVal tablas As String, ByVal condicion As String) As Boolean

        Dim sql As String
        Dim i As Integer

        Try
            cnn.Open()
        Catch ex As Exception
            cnn.Close()
            MessageBox.Show(ex.Message.ToString)
            Return False
            Exit Function
        End Try

        sql = "delete from " & tablas & " where " & condicion
        comando = New SqlCommand(sql, cnn)
        i = comando.ExecuteNonQuery()

        cnn.Close()

        If i > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function consultaAux(ByVal sql As String, ByVal tabla As String) As DataTable

        Dim dts As New DataSet
        Dim dt As New DataTable

        da = New SqlDataAdapter(sql, cnn)
        da.Fill(dts, tabla)
        dt = dts.Tables(tabla)

        Return dt

    End Function

    Public Function buscaID(ByVal valor As String)

        Dim i As Integer
        Dim query As String

        cnn.Open()

        query = "SELECT COUNT(*) FROM PROVEEDOR WHERE IDPROVEEDOR =" & "'" & valor & "'"
        comando = New SqlCommand(query, cnn)
        i = Convert.ToInt32(comando.ExecuteScalar())

        cnn.Close()

        If i > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
End Class
