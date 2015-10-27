Imports System.Data.SqlClient
Public Class clAddActividad

    Public dsAddActividad As New DataSet
    Public daAddActividad As New SqlDataAdapter
    Public da As New SqlDataAdapter
    Public bsAddActividad As New BindingSource

    Private comando As SqlCommand

    Public Sub ConsultaActividad(ByVal sql As String)

        cnn.Open()

        daAddActividad = New SqlDataAdapter(sql, cnn)
        daAddActividad.Fill(dsAddActividad, "ACTIVIDADES")
        bsAddActividad.DataSource = dsAddActividad.Tables("ACTIVIDADES")

        cnn.Close()

    End Sub

    Public Function buscaID(ByVal valor As String) As Boolean

        Dim i As Integer

        cnn.Open()

        Dim query As String
        query = "SELECT COUNT(*) FROM ACTIVIDADES WHERE IDACTIVIDAD LIKE " & "'" & valor & "%'"
        comando = New SqlCommand(query, cnn)
        i = Convert.ToInt32(comando.ExecuteScalar())

        cnn.Close()

        If i > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    ' Actualizar/Modificar. Registros.
    Public Function actualizar(ByVal tabla As String, ByVal campos As String, ByVal condicion As String) As Boolean

        Dim query As String
        Dim i As Integer

        cnn.Open()

        query = "Update " & tabla & " Set " & campos & " Where " & condicion
        comando = New SqlCommand(query, cnn)
        i = comando.ExecuteNonQuery()
        Clipboard.SetText(query)

        cnn.Close()

        If i > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function InsertaActividad(ByVal query As String) As Boolean

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

        cnn.Open()

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

End Class
