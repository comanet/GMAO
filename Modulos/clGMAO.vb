﻿Imports System.Data.SqlClient

Public Class clGMAO

    ' Elementos para TODAS las lineas - dgvSecc
    Public dsGMAO As New DataSet
    Public daGMAO As New SqlDataAdapter
    Public da As New SqlDataAdapter
    Public bsGMAO As New BindingSource
    Private comando As SqlCommand

    ' Elementos para las ACTIVIDADES de un Plan - dgvActiv
    Public dsActiv As New DataSet
    Public daActiv As New SqlDataAdapter
    Public bsActiv As New BindingSource

    ' Elementos para los EQUIPOS de un Plan - dgvEquip
    Public dsEquip As New DataSet
    Public daEquip As New SqlDataAdapter
    Public bsEquip As New BindingSource

    Public Sub ConsultaGMAO(ByVal sql As String)

        cnn.Open()
        daGMAO = New SqlDataAdapter(sql, cnn)
        daGMAO.Fill(dsGMAO, "PLANESGMAO")
        bsGMAO.DataSource = dsGMAO.Tables("PLANESGMAO")

        cnn.Close()

    End Sub

    Public Sub ConsultaActiv(ByVal sql As String)

        cnn.Open()
        daActiv = New SqlDataAdapter(sql, cnn)
        daActiv.Fill(dsActiv, "ActivxPlan")
        bsActiv.DataSource = dsActiv.Tables("ActivxPlan")

        cnn.Close()

    End Sub

    Public Function buscaID(ByVal valor As String)

        Dim i As Integer

        cnn.Open()
        Dim query As String
        query = "SELECT COUNT(*) FROM PLANESGMAO WHERE IDPM =" & "'" & valor & "'"
        comando = New SqlCommand(query, cnn)
        i = Convert.ToInt32(comando.ExecuteScalar())
        cnn.Close()
        If i > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function CargaDoc_GMAO(ByVal sql As String, ByVal tabla As String) As DataTable

        ' Dim sql As String
        'sql = "select * from " & tabla
        Dim daGMAO As SqlDataAdapter

        daGMAO = New SqlDataAdapter(sql, cnn)

        Dim dts As New DataSet

        daGMAO.Fill(dts, tabla)

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
        'MessageBox.Show(query)
        'i = 1
        cnn.Close()

        If i > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function InsertaGMAO(ByVal query As String) As Boolean

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

    ' Metodo Eliminar Registros. Parametros: Nombre de Tabla y Condicion. Return: True
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

        Dim dts As New DataSet
        Dim dt As New DataTable

        da = New SqlDataAdapter(sql, cnn)
        da.Fill(dts, tabla)
        dt = dts.Tables(tabla)
        Return dt

    End Function
End Class
