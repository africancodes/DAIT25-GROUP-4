<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Submit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.Green
        Me.btnAdmin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdmin.Location = New System.Drawing.Point(148, 73)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(135, 37)
        Me.btnAdmin.TabIndex = 0
        Me.btnAdmin.Text = "Admin"
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnSupplier
        '
        Me.btnSupplier.BackColor = System.Drawing.Color.Green
        Me.btnSupplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSupplier.Location = New System.Drawing.Point(148, 132)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(135, 37)
        Me.btnSupplier.TabIndex = 1
        Me.btnSupplier.Text = "Supplier"
        Me.btnSupplier.UseVisualStyleBackColor = False
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.Color.Green
        Me.btnCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCustomer.Location = New System.Drawing.Point(148, 188)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(135, 37)
        Me.btnCustomer.TabIndex = 3
        Me.btnCustomer.Text = "Customer"
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnExit.Location = New System.Drawing.Point(158, 245)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 37)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(24, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(432, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mobile Phone Records Management System"
        '
        'Submit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Sienna
        Me.ClientSize = New System.Drawing.Size(468, 333)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.btnSupplier)
        Me.Controls.Add(Me.btnAdmin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Submit"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnSupplier As Button
    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
End Class
