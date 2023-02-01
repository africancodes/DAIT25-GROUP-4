Public Class Submit
    Private Sub Submit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Hello welcome to Mobile Phone Record System " & vbNewLine & "Please Enter your catergory to proceed ")
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Me.Hide()
        LoginAdmin.Show()
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        Me.Hide()
        Supplier.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MsgBox("Hope to see you again. Byee.........")
        Threading.Thread.Sleep(3000)
        End
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Me.Hide()
        Customer.Show()
    End Sub
End Class