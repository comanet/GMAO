Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration

Module conexion

    Public cnn As New SqlConnection(ConfigurationManager.ConnectionStrings("GMAO.My.MySettings.cnn").ToString())
    'Public Mibinding As BindingSource

    Public Function ConectaBD()
        Try
            cnn.Open()
            Return True
        Catch ex As Exception
            ' MsgBox(ex.Message)
            MsgBox("Error de conexion a BBDD. Por favor comprueba configuración", MsgBoxStyle.Critical, "Aplicaciones Jovir")
            Return False
        End Try

    End Function
 

    Public Function desconectaBD()
    Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
                'MsgBox("BBDD Desconectada")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function



End Module
