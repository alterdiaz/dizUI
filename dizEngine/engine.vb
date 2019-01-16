Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

Public Class engine
    Private Shared DES As New TripleDESCryptoServiceProvider
    Private Shared MD5 As New MD5CryptoServiceProvider

    Private Function MD5Hash(ByVal value As String) As Byte()
        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
    End Function

    Public Function Encrypt(ByVal stringToEncrypt As String, ByVal key As String) As String
        DES.Key = MD5Hash(key)
        DES.Mode = CipherMode.ECB
        Dim Buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(stringToEncrypt)
        Return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function

    Public Function Decrypt(ByVal encryptedString As String, ByVal key As String) As String
        Dim retval As String = ""
        Try
            DES.Key = MD5Hash(key)
            DES.Mode = CipherMode.ECB
            Dim Buffer As Byte() = Convert.FromBase64String(encryptedString)
            retval = ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
        Catch ex As Exception
            MsgBox("Invalid, Decryption Failed", MsgBoxStyle.Exclamation, "Failed")
        End Try
        Return retval
    End Function

    Public Function processE(ByVal stringToEncrypt As String) As String
        Dim strDestination As String = Encrypt(stringToEncrypt, "diznet")
        Return strDestination
    End Function

    Public Function processD(ByVal stringToDecrypt As String) As String
        Dim strDestination As String = Decrypt(stringToDecrypt, "diznet")
        Return strDestination
    End Function

End Class
