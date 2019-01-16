﻿Public Class frmMain

    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto, SetLastError:=True, ExactSpelling:=True)> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Sub lblTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        'This code can be used in the MouseDown event of any control(s) you want to be able to move your form with   
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
    End Sub

    Private versionstr As String = 0
    Private versionint As Integer = 0
    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim folderdlg As New OpenFileDialog()
        If IO.Directory.Exists(tboPath.Text) = False Then
            folderdlg.InitialDirectory = Environment.SpecialFolder.MyComputer
            folderdlg.FileName = Nothing 'IO.Directory.GetDirectoryRoot(Application.StartupPath)
        Else
            folderdlg.InitialDirectory = IO.Directory.GetDirectoryRoot(Application.StartupPath)
            folderdlg.FileName = tboPath.Text
        End If
        folderdlg.Multiselect = False
        folderdlg.ShowHelp = False
        folderdlg.Title = "Select Update Path"
        If folderdlg.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor
            tboPath.Text = CheckAndRepairValidPath(IO.Path.GetDirectoryName(folderdlg.FileName))
            sender.Focus()

            Dim files As String()
            files = IO.Directory.GetFiles(tboPath.Text)
            Dim bfound As Boolean = False
            For i As Integer = 0 To files.Length - 1
                files(i) = files(i).Remove(0, tboPath.Text.Length)

                If files(i) = "dizUI.exe" Then
                    Dim file As String = tboPath.Text & files(i)
                    Dim fvi As System.Diagnostics.FileVersionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(file)
                    versionstr = fvi.FileVersion
                    versionint = CLng(fvi.FileVersion.Replace(".", ""))
                    lblVersion.Text = "File Version " & fvi.FileVersion
                    bfound = True
                End If
            Next
            If bfound = False Then
                versionstr = 0
                versionint = 0
                lblVersion.Text = "File tidak ditemukan"
                btnUpload.Enabled = False
            Else
                btnUpload.Enabled = True
            End If

            lbFilenames.Items.Clear()
            lbFilenames.Items.AddRange(files)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Environment.Exit(0)
    End Sub

    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lbFilenames_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lbFilenames.KeyDown
        If e.KeyData = System.Windows.Forms.Keys.Delete Then
            If lbFilenames.Items.Count > 0 Then
                If lbFilenames.SelectedIndex >= 0 Then
                    lbFilenames.Items.RemoveAt(lbFilenames.SelectedIndex)
                    lbFilenames.Refresh()
                End If
            End If
        End If
    End Sub

    Private Function GetStreamAsByteArray(ByVal stream As System.IO.Stream) As Byte()
        Dim streamLength As Integer = Convert.ToInt32(stream.Length)
        Dim fileData As Byte() = New Byte(streamLength) {}

        ' Read the file into a byte array
        stream.Read(fileData, 0, streamLength)
        stream.Flush()
        stream.Close()

        Return fileData
    End Function

    'Dim imgMemoryStream As IO.MemoryStream = New IO.MemoryStream()
    Dim imgByteArray As Byte() = Nothing
    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        If lbFilenames.Items.Count = 0 Then
            MsgBox("File tidak ditemukan", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        If lblVersion.Text = "File tidak ditemukan" Then
            MsgBox("File tidak ditemukan", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim sqls As New SQLs(dbstring)
        'sqls.DMLQuery("delete from sys_AppFiles", False)

        'Dim img As Image = Nothing
        Dim retval As Boolean = False
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim nowTime As Date = Now
        Dim idtmp As String = GenerateGUID()
        field.AddRange(New String() {"idappversion", "appversion", "appversionnumber", "createddate", "postdate"})
        value.AddRange(New Object() {idtmp, versionstr, versionint, nowTime, nowTime})

        dtsql = New dtsetSQLS(dbstring)
        retval = dtsql.datasetSave("sys_AppVersion", idtmp, field, value, False)

        field.Clear()
        value.Clear()

        field.AddRange(New String() {"idappfiles", "filename", "appversion", "createddate", "postdate", "filebinary"})
        'Dim fs As IO.FileStream
        For Each Str As String In lbFilenames.Items
            If Str.ToLower <> IO.Path.GetFileName(Application.ExecutablePath).ToLower Then
                Try
                    idtmp = GenerateGUID()
                    dtsql = New dtsetSQLS(dbstring)
                    value = New List(Of Object)
                    imgByteArray = Nothing

                    Dim fi As New IO.FileInfo(tboPath.Text & Str)
                    Dim createddate As Date = fi.CreationTime
                    imgByteArray = IO.File.ReadAllBytes(tboPath.Text & Str)
                    'fs = Nothing
                    'fs = New IO.FileStream(tboPath.Text & Str, IO.FileMode.Open)
                    'Dim sr As IO.Stream
                    'sr = fs
                    'imgByteArray = GetStreamAsByteArray(fs)

                    'img = Nothing
                    'img = Image.FromFile(tboPath.Text & Str)
                    'img.Save(imgMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    'imgByteArray = imgMemoryStream.GetBuffer()

                    value.AddRange(New Object() {idtmp, Str, versionstr, createddate, nowTime, imgByteArray})
                    retval = dtsql.datasetSave("sys_AppFiles", idtmp, field, value, False)
                    'sqls = New mySQLs(dbstring)
                    'retval = sqls.InsertImage("sys_AppFiles", "filename,appversion,createddate", "'" & Str & "','" & versionstr & "','" & Format(Now, "MM/dd/yyyy HH:mm:ss") & "'", "filebinary", "filebinary", imgByteArray, False)
                    If retval = False Then
                        MsgBox(Str)
                        Exit For
                    End If
                    Threading.Thread.Sleep(100)
                    GC.Collect()
                    'fs.Close()
                    'img = Nothing
                Catch ex As Exception
                End Try
            End If
        Next
        If retval = True Then
            sqls = New SQLs(dbstring)
            sqls.DMLQuery("update sys_appsetting set Value='" & versionstr & "' where Variable='ProductVersion'", False)
            btnUpload.Enabled = False
            lblVersion.Text = "Upload Berhasil"
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If My.Computer.FileSystem.GetDriveInfo(Application.StartupPath).DriveType.ToString() <> "Fixed" Then
                MsgBox("Aplikasi tidak bisa berjalan di folder sharing" & vbCrLf & "Silahkan copy aplikasi ke harddisk lokal", MsgBoxStyle.Critical, "Kesalahan")
                Threading.Thread.Sleep(1000)
                Environment.Exit(0)
            End If
        Catch ex As Exception
            MsgBox("Aplikasi tidak bisa berjalan di folder sharing" & vbCrLf & "Silahkan copy aplikasi ke harddisk lokal", MsgBoxStyle.Critical, "Kesalahan")
            Threading.Thread.Sleep(1000)
            Environment.Exit(0)
        End Try

        appPath = Application.StartupPath
        If appPath.Chars(appPath.Length - 1) <> "\" Then
            appPath &= "\"
        End If
        Dim de As New dizEngine.engine
        dblite = appPath & de.processD("VSnIwDye76lhomWNjDb5gA==")
        dbstring = readSettingFile()
        Dim mys As New SQLs(dbstring)
        If mys.checkConnection() = False Then
            MsgBox("Harap dijalankan di komputer server", MsgBoxStyle.Critical, "Kesalahan")
            Environment.Exit(0)
        End If
    End Sub

    Dim appPath As String = ""
    Dim dblite As String = ""

    Public Function readSettingFile() As String
        Dim retval As String = ""
        'retval = IO.File.ReadAllLines(pathSetting & filename)(0)

        Dim myi As New SQLi(dblite)
        myi.DMLQuery("select databasename || '|' || '127.0.0.1' || '|' || port || '|' || username || '|' || password as dbstring from dbconn where dbtype='SQLS' and dblocation='SERVER'", "getdbstring")
        myi.DMLQuery("select ipserver from dbconn where dbtype='SQLS' and dblocation='SERVER'", "getipsvr")
        If myi.getDataSet("getdbstring") > 0 Then
            dbsvr = myi.getDataSet("getipsvr", 0, "ipserver")
            retval = myi.getDataSet("getdbstring", 0, "dbstring")
        End If
        Return retval
    End Function

End Class
