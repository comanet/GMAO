Imports System.Data.SqlClient

Public Class clAddPlan

    Public dsAddPlan As New DataSet
    Public daAddPlan As New SqlDataAdapter
    Public da As New SqlDataAdapter
    Public bsAddPlan As New BindingSource
    Private comando As SqlCommand

    Public Sub ConsultaAddPlan(ByVal sql As String)

        cnn.Open()
        daAddPlan = New SqlDataAdapter(sql, cnn)
        daAddPlan.Fill(dsAddPlan, "PLANESGMAO")
        bsAddPlan.DataSource = dsAddPlan.Tables("PLANESGMAO")

        cnn.Close()

    End Sub

    Public Function buscaID(ByVal valor As String)

        Dim i As Integer

        cnn.Open()
        Dim query As String
        query = "SELECT COUNT(*) FROM PLANESGMAO WHERE IdPM =" & "'" & valor & "'"
        comando = New SqlCommand(query, cnn)
        i = Convert.ToInt32(comando.ExecuteScalar())
        cnn.Close()
        If i > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function CargaDoc_AddPlan(ByVal sql As String, ByVal tabla As String) As DataTable

        ' Dim sql As String
        'sql = "select * from " & tabla
        Dim daAddPlan As SqlDataAdapter

        daAddPlan = New SqlDataAdapter(sql, cnn)

        Dim dts As New DataSet

        daAddPlan.Fill(dts, tabla)

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

    Public Function InsertaAddPlan(ByVal query As String) As Boolean

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