Imports System.Data.SqlClient
Public Class clRepuesto
    Public dsRepuesto As New DataSet
    Public daRepuesto As New SqlDataAdapter
    Public bsRepuesto As New BindingSource
    Private comando As SqlCommand
    Private cmb As SqlCommandBuilder

    Public Sub ConsultaRepuesto(ByVal sql As String)
        cnn.Open()
        daRepuesto = New SqlDataAdapter(sql, cnn)
        cmb = New SqlCommandBuilder(daRepuesto)
        daRepuesto.Fill(dsRepuesto, "Repuesto")
        bsRepuesto.DataSource = dsRepuesto.Tables("Repuesto")
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


    Public Function InsertaRepuesto(ByVal query As String) As Boolean
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
    End Function
End Class
