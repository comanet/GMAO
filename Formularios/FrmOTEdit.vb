Public Class FrmOTEdit

    Private Sub FrmOTEdit_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        FOTEdit = Nothing

        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub
End Class