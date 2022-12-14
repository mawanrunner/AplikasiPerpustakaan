Public Class FormRegister
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Dim registeredUsername = TxtUsername.Text
        Dim registeredPassword = TxtPassword.Text

        Dim regist = FormLogin.User.Register(registeredUsername, registeredPassword)

        If regist Then
            MessageBox.Show("Registration Success")
            Me.Close()
        Else
            MessageBox.Show("Username Already Registered")
        End If
    End Sub
End Class