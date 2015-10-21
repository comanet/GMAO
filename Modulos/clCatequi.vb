Imports System.Data.SqlClient
Public Class clCatEqui

    Public dsCatEqui As New DataSet
    Public daCatEqui As New SqlDataAdapter
    Public bsCatEqui As New BindingSource
    Private comando As SqlCommand
    Private cmb As SqlCommandBuilder

    Public Sub ConsultaSeccion(ByVal sql As String)

        cnn.Open()
        daCatEqui = New SqlDataAdapter(sql, cnn)
        ' cmb = New SqlCommandBuilder(daCatEqui)
        daCatEqui.Fill(dsCatEqui, "TIP_EQUIP")
        bsCatEqui.DataSource = dsCatEqui.Tables("TIP_EQUIP")
        cnn.Close()

    End Sub

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
        'MsgBox(sql)
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
