Public Class FrmOT

    Public ClasOT As New clOT

    Private Sub FrmOT_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        FOT = Nothing

        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub
End Class