<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginAdmin
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginAdmin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnSubmitt = New System.Windows.Forms.Button()
        Me.btnCancell = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LogoPictureBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 228)
        Me.Panel1.TabIndex = 0
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(201, 229)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 16
        Me.LogoPictureBox.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.lblHeading)
        Me.Panel2.Controls.Add(Me.btnSubmitt)
        Me.Panel2.Controls.Add(Me.btnCancell)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtPass)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(218, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(271, 228)
        Me.Panel2.TabIndex = 1
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeading.Font = New System.Drawing.Font("Wide Latin", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblHeading.Location = New System.Drawing.Point(13, 22)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(225, 18)
        Me.lblHeading.TabIndex = 10
        Me.lblHeading.Text = "   LOGIN      PAGE      "
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSubmitt
        '
        Me.btnSubmitt.BackColor = System.Drawing.Color.Green
        Me.btnSubmitt.Location = New System.Drawing.Point(13, 153)
        Me.btnSubmitt.Name = "btnSubmitt"
        Me.btnSubmitt.Size = New System.Drawing.Size(95, 35)
        Me.btnSubmitt.TabIndex = 6
        Me.btnSubmitt.Text = "SUBMIT"
        Me.btnSubmitt.UseVisualStyleBackColor = False
        '
        'btnCancell
        '
        Me.btnCancell.BackColor = System.Drawing.Color.Red
        Me.btnCancell.Location = New System.Drawing.Point(139, 153)
        Me.btnCancell.Name = "btnCancell"
        Me.btnCancell.Size = New System.Drawing.Size(99, 35)
        Me.btnCancell.TabIndex = 5
        Me.btnCancell.Text = "CANCEL"
        Me.btnCancell.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SimSun-ExtB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "USERNAME"
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(92, 110)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(146, 20)
        Me.txtPass.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(92, 70)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(146, 20)
        Me.txtName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("SimSun-ExtB", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PASSWORD"
        '
        'LoginAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(527, 299)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "LoginAdmin"
        Me.Text = "LoginAdmin"
        Me.Panel1.ResumeLayout(False)
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSubmitt As Button
    Friend WithEvents btnCancell As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents LogoPictureBox As PictureBox
End Class
