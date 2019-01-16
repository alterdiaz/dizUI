Module modApps

    Public thisappsName As String
    Public thisappsDescription As String
    Public thisappsVersion As String
    Public thisclientName As String
    Public thisclientDescription As String
    Public thisstartDevelopment As Date
    Public thisfinalDevelopment As Date
    Public thisoriginalFileName As String
    Public thislastUserIDAccess As String
    Public thislastDateTimeAccess As DateTime
    Public thisSettingFilename As String
    Public thisConnectionString As String
    Public pathSetting As String = Application.StartupPath & "\Setting\"
    Public nowTime As DateTime = Now

    Public Function readSettingFile(ByVal filename As String) As String
        Dim retval As String
        retval = IO.File.ReadAllLines(pathSetting & filename)(0)
        Return retval
    End Function

    Public Sub writeSettingFile(ByVal content As String, ByVal filename As String)
        Try
            If IO.File.Exists(pathSetting & filename) Then
                IO.File.Delete(pathSetting & filename)
            End If
            Dim arrStr(0) As String
            arrStr(0) = content
            IO.File.WriteAllLines(pathSetting & filename, arrStr)
        Catch ex As Exception
            'MsgBox(setPath & filename & vbCrLf & ex.Message)
        End Try
    End Sub

    Public dbname As String
    Public dbsvr As String
    Public dbuid As String
    Public dbpwd As String
    Public dbport As String = 1433
    Public dbstring As String
    Public trustConn As Boolean = False
    Public culInfo As String = "id-ID"

End Module
