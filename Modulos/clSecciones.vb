﻿Imports System.Data.SqlClient

Public Class clSecciones

    Public dsSecciones As New DataSet
    Public daSecciones As New SqlDataAdapter
    Public bsSecciones As New BindingSource
    Private comando As SqlCommand
    Private cmb As SqlCommandBuilder

    Public Sub ConsultaSeccion(ByVal sql As String)

        cnn.Open()

        daSecciones = New SqlDataAdapter(sql, cnn)
        cmb = New SqlCommandBuilder(daSecciones)
        daSecciones.Fill(dsSecciones, "SECCIONES")
        bsSecciones.DataSource = dsSecciones.Tables("SECCIONES")

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

    Public Function InsertaSeccion(ByVal query As String) As Boolean

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
        comando = New SqlCommand(sql, cnn)
        i = comando.ExecuteNonQuery()

        cnn.Close()

        If i > 0 Then
            Return True
        Else
            Return False
        End If

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
