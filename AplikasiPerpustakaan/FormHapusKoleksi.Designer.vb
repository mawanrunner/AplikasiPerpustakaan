<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHapusKoleksi
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
        Me.LblConfirmation = New System.Windows.Forms.Label()
        Me.LblHapusKoleksi = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblConfirmation
        '
        Me.LblConfirmation.AutoSize = True
        Me.LblConfirmation.Location = New System.Drawing.Point(122, 53)
        Me.LblConfirmation.Name = "LblConfirmation"
        Me.LblConfirmation.Size = New System.Drawing.Size(163, 13)
        Me.LblConfirmation.TabIndex = 0
        Me.LblConfirmation.Text = "Apakah ingin menghapus koleksi"
        '
        'LblHapusKoleksi
        '
        Me.LblHapusKoleksi.AllowDrop = True
        Me.LblHapusKoleksi.AutoSize = True
        Me.LblHapusKoleksi.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHapusKoleksi.ForeColor = System.Drawing.Color.Maroon
        Me.LblHapusKoleksi.Location = New System.Drawing.Point(27, 98)
        Me.LblHapusKoleksi.MaximumSize = New System.Drawing.Size(350, 0)
        Me.LblHapusKoleksi.MinimumSize = New System.Drawing.Size(350, 31)
        Me.LblHapusKoleksi.Name = "LblHapusKoleksi"
        Me.LblHapusKoleksi.Size = New System.Drawing.Size(350, 31)
        Me.LblHapusKoleksi.TabIndex = 0
        Me.LblHapusKoleksi.Text = "Koleksi A"
        Me.LblHapusKoleksi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(164, 198)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapus.TabIndex = 1
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'FormHapusKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 261)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LblHapusKoleksi)
        Me.Controls.Add(Me.LblConfirmation)
        Me.Name = "FormHapusKoleksi"
        Me.Text = "Hapus Koleksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblConfirmation As Label
    Friend WithEvents LblHapusKoleksi As Label
    Friend WithEvents BtnHapus As Button
End Class
