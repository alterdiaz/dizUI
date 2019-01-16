Imports System.Runtime.InteropServices

Public Class frmMain

    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True, ExactSpelling:=True)> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Sub lblTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        'This code can be used in the MouseDown event of any control(s) you want to be able to move your form with   
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
    End Sub

    Private Sub btnDBSetting_Click(sender As Object, e As EventArgs) Handles btnDBSetting.Click
        Dim setdb As New frmSettingDB
        setdb.ShowDialog()
    End Sub

    Private Sub btnAppMin_Click(sender As Object, e As EventArgs) Handles btnAppMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnAppMax_Click(sender As Object, e As EventArgs) Handles btnAppMax.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnAppExit_Click(sender As Object, e As EventArgs) Handles btnAppExit.Click
        Environment.Exit(0)
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        appPath = Application.StartupPath
        If appPath.Chars(appPath.Length - 1) <> "\" Then
            appPath &= "\"
        End If
        Application.DoEvents()

        Dim de As New dizEngine.engine
        dblite = appPath & de.processD("l59ruEcWFgphomWNjDb5gA==")

        Try
            If My.Computer.FileSystem.GetDriveInfo(Application.StartupPath).DriveType <> IO.DriveType.Fixed Then
                splashClosed = True
                dizMsgbox("Aplikasi tidak bisa berjalan di folder sharing" & vbCrLf & "Silahkan copy aplikasi ke harddisk lokal", dizMsgboxStyle.Kesalahan, Me)
                Environment.Exit(0)
            End If
        Catch ex As Exception
            splashClosed = True
            dizMsgbox("Aplikasi tidak bisa berjalan di folder sharing" & vbCrLf & "Silahkan copy aplikasi ke harddisk lokal", dizMsgboxStyle.Kesalahan, Me)
            Environment.Exit(0)
        End Try

        dbstring = readSettingFile()

        Dim sql As New SQLs(dbstring)
        Try
            If sql.checkConnection = True Then
                Dim sqli As New SQLi(dblite)
                sql.DMLQuery("select getdate() as tanggal", "cekwaktu")
                sql.DMLQuery("select top 1 idtoken,tokenkey1,tokenkey2 from sys_token order by createddate desc", "tokenid")

                sqli.DMLQuery("select value as idtoken from appsetting where variable='tokenid'", "tokenid")
                If sql.getDataSet("tokenid", 0, "idtoken") <> sql.getDataSet("tokenid", 0, "idtoken") Then
                    sqli.DMLQuery("update appsetting set value='" & sql.getDataSet("cnt", 0, "idtoken") & "' where variable='TokenID'", False)
                    sqli.DMLQuery("update appsetting set value='" & sql.getDataSet("cnt", 0, "tokenkey1") & "' where variable='TokenKey1'", False)
                    sqli.DMLQuery("update appsetting set value='" & sql.getDataSet("cnt", 0, "tokenkey2") & "' where variable='TokenKey2'", False)

                    sqli = New SQLi(dblite)
                    sqli.DMLQuery("select value as idtoken from appsetting where variable='tokenid'", "tokenid")
                    sqli.DMLQuery("select value as tokenkey1 from appsetting where variable='tokenkey1'", "tokenkey1")
                    sqli.DMLQuery("select value as tokenkey2 from appsetting where variable='tokenkey2'", "tokenkey2")
                Else
                    sqli.DMLQuery("select value as idtoken from appsetting where variable='tokenid'", "tokenid")
                    sqli.DMLQuery("select value as tokenkey1 from appsetting where variable='tokenkey1'", "tokenkey1")
                    sqli.DMLQuery("select value as tokenkey2 from appsetting where variable='tokenkey2'", "tokenkey2")
                End If

                tokenkey1 = sql.getDataSet("tokenid", 0, "tokenkey1")
                tokenkey2 = sql.getDataSet("tokenid", 0, "tokenkey2")
                idtoken = sql.getDataSet("tokenid", 0, "idtoken")

                isServer = modCore.isLocalhost
            Else
                splashClosed = True
                dizMsgbox("Server not found", dizMsgboxStyle.Kesalahan, Me)
                Me.Cursor = Cursors.Default
                Me.Enabled = True

                Dim dbset As New frmSettingDB
                dbset.ShowDialog()

                Environment.Exit(0)
            End If
        Catch ex As Exception
            splashClosed = True
            Threading.Thread.Sleep(1000)
            dizMsgbox("Server not found", dizMsgboxStyle.Kesalahan, Me)
            Me.Cursor = Cursors.Default
            Me.Enabled = True

            Dim dbset As New frmSettingDB
            dbset.ShowDialog()

            Environment.Exit(0)
        End Try

        If sql.getDataSet("cekwaktu") > 0 Then
            Dim tmpstr As String = sql.getDataSet("cekwaktu", 0, "tanggal")
            Dim cekdate As Date = New Date(tmpstr.Split(" ")(0).Split("-")(2), tmpstr.Split(" ")(0).Split("-")(1), tmpstr.Split(" ")(0).Split("-")(0), tmpstr.Split(" ")(1).Split(":")(0), tmpstr.Split(" ")(1).Split(":")(1), tmpstr.Split(" ")(1).Split(":")(2))
            nowTime = cekdate 'CDate(mys.getDataSet("cekwaktu", 0, "tanggal"))
        Else
            nowTime = Now
        End If
    End Sub
End Class
