Imports System.Data.SqlClient

Public Class clUser

    Public dsUser As New DataSet
    Public daUser As New SqlDataAdapter
    Public da As New SqlDataAdapter
    Public bsUser As New BindingSource
    Private comando As SqlCommand
    Private cmb As SqlCommandBuilder

    Public Sub ConsultaUser(ByVal sql As String)

        cnn.Open()

        daUser = New SqlDataAdapter(sql, cnn)
        cmb = New SqlCommandBuilder(daUser)
        daUser.Fill(dsUser, "USUARIOS")
        bsUser.DataSource = dsUser.Tables("USUARIOS")

        cnn.Close()

    End Sub

    Public Function ConsultaUserTabla(ByVal sql As String, ByVal tabla As String) As DataTable

        Dim dauser2 As SqlDataAdapter
        Dim dts As New DataSet
        Dim dt As New DataTable

        dauser2 = New SqlDataAdapter(sql, cnn)
        dauser2.Fill(dts, tabla)
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
    Public Function InsertaUser(ByVal query As String) As Boolean

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
