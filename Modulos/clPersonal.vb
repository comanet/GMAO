Imports System.Data.SqlClient
Public Class clPersonal

    Public dsPersonal As New DataSet
    Public daPersonal As New SqlDataAdapter
    Public bsPersonal As New BindingSource
    Public da As New SqlDataAdapter
    Private comando As SqlCommand
    Private cmb As SqlCommandBuilder

    Public Sub ConsultaSeccion(ByVal sql As String)
        cnn.Open()
        daPersonal = New SqlDataAdapter(sql, cnn)
        'cmb = New SqlCommandBuilder(daPersonal)
        daPersonal.Fill(dsPersonal, "PERSONAL")
        bsPersonal.DataSource = dsPersonal.Tables("PERSONAL")
        cnn.Close()

    End Sub

    Public Function consultaAux(ByVal sql As String, ByVal tabla As String) As DataTable

        ' Dim sql As String
        'sql = "select * from " & tabla
        da = New SqlDataAdapter(sql, cnn)

        Dim dts As New DataSet

        da.Fill(dts, tabla)

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
        ' update evorh set evolucion = Lo he conseguido actulizar where 
        comando = New SqlCommand(query, cnn)
        i = comando.ExecuteNonQuery()
        cnn.Close()

        If i > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function InsertaSeccion(ByVal query As String) As Boolean

        cnn.Open()
        comando = New SqlCommand(query, cnn)

        'Dim comando As New SqlCommand(query, cnn)
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

    Function UltimoRegistro(ByVal campo As String, tabla As String) As Integer

        Dim query As String
        Dim idregistro As Integer

        cnn.Open()
        query = "select max(" + campo + ")" + "from " + tabla + ""
        comando = New SqlCommand(query, cnn)
        idregistro = comando.ExecuteScalar + 1
        cnn.Close()
        Return idregistro

    End Function
End Class
