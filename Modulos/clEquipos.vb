﻿Imports System.Data.SqlClient

Public Class clEquipos

    Public dsEquipos As New DataSet
    Public daEquipos As New SqlDataAdapter
    Public da As New SqlDataAdapter
    Public bsEquipos As New BindingSource

    Public dsPlanes As New DataSet
    Public daPlanes As New SqlDataAdapter
    Public daP As New SqlDataAdapter
    Public bsPlanes As New BindingSource

    Public dsTareas As New DataSet
    Public daTareas As New SqlDataAdapter
    Public daT As New SqlDataAdapter
    Public bsTareas As New BindingSource

    Private comando As SqlCommand

    Public Sub ConsultaPlanes(ByVal sql As String)

        cnn.Open()

        daPlanes = New SqlDataAdapter(sql, cnn)
        daPlanes.Fill(dsTareas, "PLANES")
        bsPlanes.DataSource = dsPlanes.Tables("PLANES")

        cnn.Close()

    End Sub

    Public Sub ConsultaTareas(ByVal sql As String)

        cnn.Open()

        daTareas = New SqlDataAdapter(sql, cnn)
        daTareas.Fill(dsTareas, "TAREAS")
        bsTareas.DataSource = dsTareas.Tables("TAREAS")

        cnn.Close()

    End Sub

    Public Sub ConsultaEquipos(ByVal sql As String)

        cnn.Open()

        daEquipos = New SqlDataAdapter(sql, cnn)
        daEquipos.Fill(dsEquipos, "EQUIPOS")
        bsEquipos.DataSource = dsEquipos.Tables("EQUIPOS")

        cnn.Close()

    End Sub

    Public Function buscaID(ByVal valor As String)

        Dim i As Integer

        cnn.Open()

        Dim query As String
        query = "SELECT COUNT(*) FROM EQUIPOS WHERE IDEQUIPO =" & "'" & valor & "'"
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

        Dim daequipos As SqlDataAdapter
        Dim dts As New DataSet
        Dim dt As New DataTable

        daequipos = New SqlDataAdapter(sql, cnn)
        daequipos.Fill(dts, tabla)
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

    Public Function InsertaEquipo(ByVal query As String) As Boolean

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
        ' cnn.Close()

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
