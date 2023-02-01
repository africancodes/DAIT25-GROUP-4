Public Class Customer
    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MPRdbDataSet.cellphone' table. You can move, or remove it, as needed.
        Me.CellphoneTableAdapter.Fill(Me.MPRdbDataSet.cellphone)
        Dim customerName As String
        customerName = InputBox("Hello there, Im am Dait and you?")
        MsgBox("It's nice to meet you " & customerName & "  Below is a list of products we have in stock. Please enjoy your shopping........")
    End Sub

    Private Sub CellphoneBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CellphoneBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CellphoneBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MPRdbDataSet)
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.CellphoneTableAdapter.FillBy(Me.MPRdbDataSet.cellphone)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy1ToolStripButton.Click
        Try
            Me.CellphoneTableAdapter.FillBy1(Me.MPRdbDataSet.cellphone)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        End
    End Sub


End Class