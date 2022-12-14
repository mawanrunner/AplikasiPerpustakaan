Imports System.Security.Cryptography

Public Class User

    Private TripleDes As New TripleDESCryptoServiceProvider
    Private listOfAccount As New ArrayList()

    Public Sub New()
        listOfAccount.Add({"admin", EncryptData("admin")})
    End Sub

    Public Function Register(registeredUsername As String, registeredPassword As String) As Boolean

        For Each account In listOfAccount
            If String.Compare(registeredUsername, account(0)) = 0 Then
                Return False
            Else
                listOfAccount.Add({registeredUsername, EncryptData(registeredPassword)})
                Return True
            End If
        Next

    End Function

    Public Function EncryptData(plaintext As String) As String

        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)

        Dim ms As New System.IO.MemoryStream
        Dim encStream As New CryptoStream(ms,
            TripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray)

    End Function

    Public Function CheckAuth(plainUsername As String, plainPassword As String) As Integer

        Dim returnValue = 0

        For Each account In listOfAccount
            If String.Compare(plainUsername, account(0)) = 0 Then
                If String.Compare(EncryptData(plainPassword), account(1)) = 0 Then
                    returnValue = 2
                    Exit For
                Else
                    returnValue = 1
                    Exit For
                End If
            Else
                returnValue = 0
            End If
        Next

        Return returnValue

    End Function

End Class

