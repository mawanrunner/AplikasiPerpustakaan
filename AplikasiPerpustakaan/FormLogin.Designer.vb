<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Me.LblUsernamer = New System.Windows.Forms.Label()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblUsernamer
        '
        Me.LblUsernamer.AutoSize = True
        Me.LblUsernamer.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsernamer.Location = New System.Drawing.Point(36, 38)
        Me.LblUsernamer.Name = "LblUsernamer"
        Me.LblUsernamer.Size = New System.Drawing.Size(67, 16)
        Me.LblUsernamer.TabIndex = 0
        Me.LblUsernamer.Text = "Username"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.Location = New System.Drawing.Point(36, 79)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(64, 16)
        Me.LblPassword.TabIndex = 0
        Me.LblPassword.Text = "Password"
        '
        'TxtUsername
        '
        Me.TxtUsername.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsername.Location = New System.Drawing.Point(154, 35)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(264, 24)
        Me.TxtUsername.TabIndex = 1
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(154, 76)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(264, 24)
        Me.TxtPassword.TabIndex = 2
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'BtnLogin
        '
        Me.BtnLogin.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.Location = New System.Drawing.Point(344, 127)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(74, 28)
        Me.BtnLogin.TabIndex = 3
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'BtnRegister
        '
        Me.BtnRegister.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegister.Location = New System.Drawing.Point(254, 127)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(74, 28)
        Me.BtnRegister.TabIndex = 4
        Me.BtnRegister.Text = "Register"
        Me.BtnRegister.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 192)
        Me.Controls.Add(Me.BtnRegister)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblUsernamer)
        Me.Name = "FormLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUsernamer As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnRegister As Button
End Class
