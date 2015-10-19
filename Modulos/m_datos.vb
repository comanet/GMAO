Imports System.Data.SqlClient

Public Class m_datos

    Public ds As New DataSet
    Public bs As New BindingSource
    Public da As New SqlDataAdapter
    Private comando As SqlCommand
    Private cmb As SqlCommandBuilder

    'Public Function Mostrar() As DataSet
    '    Try
    '        ' ConectaBD()
    '        da = New OleDb.OleDbDataAdapter("SELECT NUMERO,FECHA,APELLIDOS,NOMBRE,TELEFONO,OBSERVACIONES FROM INGRESOS WHERE SC LIKE 'RH'", cnn) ' definicion dataAdapter
    '        da.Fill(ds, "INGRESOS")
    '        Return (ds)
    '    Catch ex As Exception
    '        MsgBox("Error " & ex.Message)
    '        Return Nothing
    '    End Try
    '    'desconectaBD()
    'End Function
    'insertar datos

    Public Function insertar(ByVal sql As String) As Boolean

        Dim i As Integer ' Nos devuelve el resultado del comando sql.

        cnn.Open()
        comando = New SqlCommand(sql, cnn)

        i = comando.ExecuteNonQuery
        cnn.Close()

        If i > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    ' actualizar/modificar: Recibe Nombre de Tabla, campos a actualizar y condicion.
    Public Function actualizar(ByVal tabla As String, ByVal campos As String, ByVal condicion As String) As Boolean

        Dim sql As String
        Dim i As Integer

        cnn.Open()
        sql = "Update " & tabla & " Set " & campos & " Where " & condicion
        ' update evorh set evolucion = Lo he conseguido actulizar where 
        comando = New SqlCommand(sql, cnn)
        i = comando.ExecuteNonQuery()
        cnn.Close()

        If i > 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    ' consultar
    Public Sub consultar(ByVal sql As String, ByVal tabla As String)

        da = New SqlDataAdapter(sql, cnn)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
        bs.DataSource = ds.Tables(tabla) ' añadido por cml

    End Sub

    'eliminar
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
        cnn.Close()

    End Function

    Public Function consultar2(ByVal sql As String, ByVal tabla As String) As DataTable

        Dim dts As New DataSet
        Dim dt As New DataTable

        da = New SqlDataAdapter(sql, cnn)
        da.Fill(dts, tabla)
        dt = dts.Tables(tabla)
        Return dt

    End Function

    Public Function consultar3(ByVal tabla As String) As DataTable ' original

        Dim sql As String
        Dim dts As New DataSet
        Dim dt As New DataTable

        sql = "select * from " & tabla
        da = New SqlDataAdapter(sql, cnn)
        da.Fill(dts, tabla)
        dt = dts.Tables(tabla)
        Return dt

    End Function

    'Public Function ObtenerBinding(ByVal NombreFORM As String) As BindingSource
    '   If NombreFORM = "frmAdmision" Then
    '       Return bsadmision
    '   ElseIf NombreFORM = "frmRehabilita" Then
    '       Return bsrh
    '   Else
    '       Return Nothing
    '   End If
    'End Function

End Class


