Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

Public Class Form1

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim de As New dizEngine.engine
        appPath = CheckAndRepairValidPath(appPath)
        dblite = appPath & de.processD("l59ruEcWFgphomWNjDb5gA==")
        dbstring = readSettingFile()

        Dim str As String = GenerateUUID(dbstring)
        Clipboard.SetText(str)

        'Dim str As String = "AlterDiaz"
        'Dim tmp As Byte() = MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(str))
        'str = Convert.ToBase64String(tmp)
        'str = str.ToUpper
        'MsgBox(str)
        'str = Encrypt(str, "diznet")
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim str As String = GenerateUUID(dbstring)
        Clipboard.SetText(str)
    End Sub

End Class