Module modApps

    Public dbname As String
    Public dbsvr As String
    Public dbid As String
    Public dbpass As String
    Public dbport As String = 1433
    Public dbinstance As String
    Public dbschema As String

    Public dbstring As String

    Public appPath As String = Application.StartupPath
    Public appUpPath As String = Application.StartupPath
    Public dblite As String = ""

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
    Public culInfo As String = "id-ID"

    Public Sub writeSettingFile(ByVal content As String)
        Try
            'If IO.File.Exists(pathSetting & filename) Then
            '    IO.File.Delete(pathSetting & filename)
            'End If

            'Dim arrStr(0) As String
            'arrStr(0) = content
            'IO.File.WriteAllLines(pathSetting & filename, arrStr)

            Dim iset As New dtsetSQLI(dblite)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            Dim myi As New SQLi(dblite)
            Dim tmplist As String()
            tmplist = content.Split("|")
            myi.DMLQuery("delete from dbconn where dbtype='SQLS' and dblocation='SERVER'", False)
            myi.DMLQuery("select iddbconn from dbconn where ipserver='" & tmplist(1) & "' and databasename='" & tmplist(0) & "' and dbtype='SQLS' and dblocation='SERVER'", "getid")
            Dim iddbconn As Integer = -1
            If myi.getDataSet("getid") > 0 Then
                iddbconn = myi.getDataSet("getid", 0, "iddbconn")
            End If
            '        myi.DMLQuery("select databasename || '|' || ipserver || '|' || instance || '|' || port || '|' || schema || '|' || username || '|' || password as dbstring from dbconn where dbtype='SQLS' and dblocation='SERVER'", "getdbstring")

            field.AddRange(New String() {"iddbconn", "databasename", "ipserver", "instance", "port", "schema", "username", "password", "dbtype", "dblocation"})
            value.AddRange(New Object() {iddbconn, tmplist(0), tmplist(1), tmplist(2), tmplist(3), tmplist(4), tmplist(5), tmplist(6), "SQLS", "SERVER"})
            iset.datasetSave("dbconn", iddbconn, field, value, False)

        Catch ex As Exception
            'MsgBox(setPath & filename & vbCrLf & ex.Message)
        End Try
    End Sub

    Public Function readSettingFile() As String
        Dim retval As String = ""
        'retval = IO.File.ReadAllLines(pathSetting & filename)(0)

        Dim myi As New SQLi(dblite)
        myi.DMLQuery("select databasename || '|' || ipserver || '|' || instance || '|' || port || '|' || schema || '|' || username || '|' || password as dbstring from dbconn where dbtype='SQLS' and dblocation='SERVER'", "getdbstring")
        If myi.getDataSet("getdbstring") > 0 Then
            retval = myi.getDataSet("getdbstring", 0, "dbstring")
        End If
        Return retval
    End Function

End Module
