Imports System.Data.SqlClient

Public Class clEspecialidades

    Public dsEspecialidades As New DataSet
    Public daEspecialidades As New SqlDataAdapter
    Public da As New SqlDataAdapter
    Public bsEspecialidades As New BindingSource
    Private comando As SqlCommand

    Public Sub ConsultaEspecialidades(ByVal sql As String)

        cnn.Open()

        daEspecialidades = New SqlDataAdapter(sql, cnn)
        daEspecialidades.Fill(dsEspecialidades, "ESPECIALIDADES")
        bsEspecialidades.DataSource = dsEspecialidades.Tables("ESPECIALIDADES")

        cnn.Close()

    End Sub

    Public Function buscaID(ByVal valor As String)

        Dim i As Integer

        cnn.Open()
        Dim query As String
        query = "SELECT COUNT(*) FROM ESPECIALIDADES WHERE IDESPECIALIDAD =" & "'" & valor & "'"
        comando = New SqlCommand(query, cnn)
        i = Convert.ToInt32(comando.ExecuteScalar())
        cnn.Close()
        If i > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function CargaDoc_Equip(ByVal sql As String, ByVal tabla As String) As DataTable

        Dim daEspecialidades As SqlDataAdapter

        daEspecialidades = New SqlDataAdapter(sql, cnn)

        Dim dts As New DataSet

        daEspecialidades.Fill(dts, tabla)

        Dim dt As New DataTable

        dt = dts.Tables(tabla)
        Return dt

    End Function

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

    Public Function InsertaEspecialidades(ByVal query As String) As Boolean

        cnn.Open()
        comando = New SqlCommand(query, cnn)

        Dim i As Integer

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
        'MsgBox(sql)
        comando = New SqlCommand(sql, cnn)
        i = comando.ExecuteNonQuery()
        cnn.Close()
        If i > 0 Then
            Return True
        Else
            Return False
        End If
        ' cnn.Close()

    End Function

    Public Function consultaAux(ByVal sql As String, ByVal tabla As String) As DataTable

        da = New SqlDataAdapter(sql, cnn)

        Dim dts As New DataSet

        da.Fill(dts, tabla)

        Dim dt As New DataTable

        dt = dts.Tables(tabla)
        Return dt

    End Function
End Class