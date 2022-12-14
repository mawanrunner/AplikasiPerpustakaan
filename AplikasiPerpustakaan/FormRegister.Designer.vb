<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegister
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
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.LblUsernamer = New System.Windows.Forms.Label()
        Me.LblRegister = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnRegister
        '
        Me.BtnRegister.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegister.Location = New System.Drawing.Point(347, 176)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(74, 28)
        Me.BtnRegister.TabIndex = 3
        Me.BtnRegister.Text = "Register"
        Me.BtnRegister.UseVisualStyleBackColor = True
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(157, 128)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(264, 24)
        Me.TxtPassword.TabIndex = 2
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'TxtUsername
        '
        Me.TxtUsername.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsername.Location = New System.Drawing.Point(157, 87)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(264, 24)
        Me.TxtUsername.TabIndex = 1
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.Location = New System.Drawing.Point(39, 131)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(64, 16)
        Me.LblPassword.TabIndex = 3
        Me.LblPassword.Text = "Password"
        '
        'LblUsernamer
        '
        Me.LblUsernamer.AutoSize = True
        Me.LblUsernamer.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsernamer.Location = New System.Drawing.Point(39, 90)
        Me.LblUsernamer.Name = "LblUsernamer"
        Me.LblUsernamer.Size = New System.Drawing.Size(67, 16)
        Me.LblUsernamer.TabIndex = 4
        Me.LblUsernamer.Text = "Username"
        '
        'LblRegister
        '
        Me.LblRegister.AutoSize = True
        Me.LblRegister.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegister.Location = New System.Drawing.Point(37, 41)
        Me.LblRegister.Name = "LblRegister"
        Me.LblRegister.Size = New System.Drawing.Size(161, 26)
        Me.LblRegister.TabIndex = 8
        Me.LblRegister.Text = "Registrasi Akun"
        '
        'FormRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 247)
        Me.Controls.Add(Me.LblRegister)
        Me.Controls.Add(Me.BtnRegister)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUsernamer)
        Me.Name = "FormRegister"
        Me.Text = "FormRegister"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRegister As Button
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents LblUsernamer As Label
    Friend WithEvents LblRegister As Label
End Class
