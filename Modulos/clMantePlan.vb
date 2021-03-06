﻿Imports System.Data.SqlClient

Public Class clMantePlan

    Public dsMantePlan As New DataSet
    Public daMantePlan As New SqlDataAdapter
    Public da As New SqlDataAdapter
    Public bsMantePlan As New BindingSource

    Public dsEquipos As New DataSet
    Public daEquipos As New SqlDataAdapter
    Public daEq As New SqlDataAdapter
    Public bsEquipos As New BindingSource

    Public dsActiv As New DataSet
    Public daActiv As New SqlDataAdapter
    Public daAct As New SqlDataAdapter
    Public bsActiv As New BindingSource

    Private comando As SqlCommand

    Public Sub ConsultaMantePlan(ByVal sql As String)

        cnn.Open()

        daMantePlan = New SqlDataAdapter(sql, cnn)
        daMantePlan.Fill(dsMantePlan, "MANTEPLAN")
        bsMantePlan.DataSource = dsMantePlan.Tables("MANTEPLAN")

        cnn.Close()

    End Sub

    Public Sub ConsultaEquipos(ByVal sql As String)

        cnn.Open()

        daEquipos = New SqlDataAdapter(sql, cnn)
        daEquipos.Fill(dsEquipos, "tbl_EQUIPOS")
        bsEquipos.DataSource = dsEquipos.Tables("tbl_EQUIPOS")

        cnn.Close()

    End Sub

    Public Sub ConsultaActividades(ByVal sql As String)

        cnn.Open()

        daActiv = New SqlDataAdapter(sql, cnn)
        daActiv.Fill(dsActiv, "tbl_ACTIVIDADES")
        bsActiv.DataSource = dsActiv.Tables("tbl_ACTIVIDADES")

        cnn.Close()

    End Sub

    Public Function buscaID(ByVal valor As String) As Boolean

        Dim i As Integer

        cnn.Open()

        Dim query As String
        query = "SELECT COUNT(*) FROM MANTEPLAN WHERE IDPLAN LIKE " & "'" & valor & "%'"
        comando = New SqlCommand(query, cnn)
        i = Convert.ToInt32(comando.ExecuteScalar())

        cnn.Close()

        If i > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function CargaDoc_MantePlan(ByVal sql As String, ByVal tabla As String) As DataTable

        Dim daMantePlan As SqlDataAdapter
        Dim dts As New DataSet
        Dim dt As New DataTable

        daMantePlan = New SqlDataAdapter(sql, cnn)
        daMantePlan.Fill(dts, tabla)
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
        Clipboard.SetText(query)

        cnn.Close()

        If i > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function InsertaMantePLan(ByVal query As String) As Boolean

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
