Public Class FormLogin

    Public Shared User As New User()

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        Dim plainUsername As String = TxtUsername.Text
        Dim plainPassword As String = TxtPassword.Text

        Dim AuthStatus As Integer = User.CheckAuth(plainUsername, plainPassword)

        If AuthStatus = 2 Then
            FormPerpustakaan.Show()
        ElseIf AuthStatus = 1 Then
            MessageBox.Show("Wrong Password")
        ElseIf AuthStatus = 0 Then
            MessageBox.Show("No User Found")
        End If
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        FormRegister.Show()
    End Sub

End Class