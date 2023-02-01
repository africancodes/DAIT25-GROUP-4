Public Class LoginAdmin
    Private Sub btnSubmitt_Click(sender As Object, e As EventArgs) Handles btnSubmitt.Click
        Dim username As String
        Dim password As String

        username = txtName.Text
        password = txtPass.Text

        If username.ToUpper = "DAIT25" Then
            If password = "dait" Then
                Me.Close()
                dashboard.Show()
            Else
                MsgBox("Wrong password")
            End If
        Else
            MsgBox("Wrong username")
        End If
    End Sub

    Private Sub btnCancell_Click(sender As Object, e As EventArgs) Handles btnCancell.Click
        End
    End Sub
End Class