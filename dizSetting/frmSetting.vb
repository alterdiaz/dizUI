Public Class frmSetting

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

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Environment.Exit(0)
    End Sub

    Public culInfo As String
    Public dbname, dbsvr, dbid, dbpass, updpath, upddomain, updusername, updpassword, dbport, dbinstance, dbschema As String
    Private Sub UpdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdSave.Click
        'Application.DoEvents()
        'Dim unc As New UNCAccessWithCredentials
        'If unc.NetUseWithCredentials(tbouPath.Text, tbouUsername.Text, tbouDomain.Text, tbouPassword.Text) = True Then
        'If IO.Directory.Exists(tbouPath.Text) = False Then
        '    MsgBox("Update Path not valid", MsgBoxStyle.Critical, "Not Valid")
        '    Exit Sub
        'End If

        Me.dbname = tboDBname.Text
        Me.dbsvr = tboIPsvr.Text
        Me.dbinstance = tboInstance.Text
        Me.dbport = tboPort.Text
        Me.dbschema = tboSkema.Text
        Me.dbid = tboUsr.Text
        Me.dbpass = tboPass.Text

        writeSettingFile(Me.dbname & "|" & Me.dbsvr & "|" & Me.dbinstance & "|" & Me.dbport & "|" & Me.dbschema & "|" & Me.dbid & "|" & Me.dbpass)
        'Else
        'MsgBox("Can't access update path, please check network connection", MsgBoxStyle.Critical, "Error")
        'End If
    End Sub

    Public Sub setRegionalSetting()
        Dim dirReg As String = "HKEY_CURRENT_USER\Control Panel\International"

        '1-10
        My.Computer.Registry.SetValue(dirReg, "iCalendarType", "1")
        My.Computer.Registry.SetValue(dirReg, "iCountry", "1")
        My.Computer.Registry.SetValue(dirReg, "iCurrDigits", "2")
        My.Computer.Registry.SetValue(dirReg, "iCurrency", "0")
        My.Computer.Registry.SetValue(dirReg, "iDate", "1")

        My.Computer.Registry.SetValue(dirReg, "iDigits", "2")
        My.Computer.Registry.SetValue(dirReg, "iFirstDayOfWeek", "6")
        My.Computer.Registry.SetValue(dirReg, "iFirstWeekOfYear", "0")
        My.Computer.Registry.SetValue(dirReg, "iLZero", "1")
        My.Computer.Registry.SetValue(dirReg, "iMeasure", "0")

        '11-20
        My.Computer.Registry.SetValue(dirReg, "iNegCurr", "0")
        My.Computer.Registry.SetValue(dirReg, "iNegNumber", "1")
        My.Computer.Registry.SetValue(dirReg, "iPaperSize", "9")
        My.Computer.Registry.SetValue(dirReg, "iTime", "1")
        My.Computer.Registry.SetValue(dirReg, "iTimePrefix", "0")

        My.Computer.Registry.SetValue(dirReg, "iTLZero", "1")
        My.Computer.Registry.SetValue(dirReg, "Locale", "00000421")
        My.Computer.Registry.SetValue(dirReg, "LocaleName", "id-ID")
        My.Computer.Registry.SetValue(dirReg, "NumShape", "1")
        My.Computer.Registry.SetValue(dirReg, "s1159", "AM")
        culInfo = "id-ID"
        '21-30
        My.Computer.Registry.SetValue(dirReg, "s2359", "PM")
        My.Computer.Registry.SetValue(dirReg, "sCountry", "United States")
        My.Computer.Registry.SetValue(dirReg, "sCurrency", "Rp")
        My.Computer.Registry.SetValue(dirReg, "sDate", "-")
        My.Computer.Registry.SetValue(dirReg, "sDecimal", ",")

        My.Computer.Registry.SetValue(dirReg, "sGrouping", "3;0")
        My.Computer.Registry.SetValue(dirReg, "sLanguage", "ENU")
        My.Computer.Registry.SetValue(dirReg, "sList", ",")
        My.Computer.Registry.SetValue(dirReg, "sLongDate", "dd MMMM yyyy")
        My.Computer.Registry.SetValue(dirReg, "sMonDecimalSep", ".")

        '31-40
        My.Computer.Registry.SetValue(dirReg, "sMonGrouping", "3;0")
        My.Computer.Registry.SetValue(dirReg, "sMonThousandSep", ".")
        My.Computer.Registry.SetValue(dirReg, "sNativeDigits", "0123456789")
        My.Computer.Registry.SetValue(dirReg, "sNegativeSign", "-")
        My.Computer.Registry.SetValue(dirReg, "sPositiveSign", "")

        My.Computer.Registry.SetValue(dirReg, "sShortDate", "dd-MM-yyyy")
        My.Computer.Registry.SetValue(dirReg, "sShortTime", "HH:mm")
        My.Computer.Registry.SetValue(dirReg, "sThousand", ".")
        My.Computer.Registry.SetValue(dirReg, "sTime", ":")
        My.Computer.Registry.SetValue(dirReg, "sTimeFormat", "HH:mm:ss")

        '41
        My.Computer.Registry.SetValue(dirReg, "sYearMonth", "MMMM yyyy")
    End Sub

    Private Sub frmSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If My.Computer.FileSystem.GetDriveInfo(Application.StartupPath).DriveType.ToString() <> "Fixed" Then
                MsgBox("Aplikasi tidak bisa berjalan di folder sharing" & vbCrLf & "Silahkan copy aplikasi ke harddisk lokal", MsgBoxStyle.Critical, "Kesalahan")
                Threading.Thread.Sleep(500)
                Environment.Exit(0)
            End If
        Catch ex As Exception
            MsgBox("Aplikasi tidak bisa berjalan di folder sharing" & vbCrLf & "Silahkan copy aplikasi ke harddisk lokal", MsgBoxStyle.Critical, "Kesalahan")
            Threading.Thread.Sleep(500)
            Environment.Exit(0)
        End Try

        For Each p As Process In Process.GetProcesses
            If p.ProcessName = exeName Then
                p.Kill()
            End If
        Next

        Dim myProcess As System.Diagnostics.Process = System.Diagnostics.Process.GetCurrentProcess()
        myProcess.PriorityClass = System.Diagnostics.ProcessPriorityClass.RealTime

        setRegionalSetting()

        appPath = Application.StartupPath
        If appPath.Chars(appPath.Length - 1) <> "\" Then
            appPath &= "\"
        End If
        Dim de As New dizEngine.engine
        dblite = appPath & de.processD("l59ruEcWFgphomWNjDb5gA==")

        Dim val As String = readSettingFile()
        dbname = Val.Split("|")(0)
        dbsvr = val.Split("|")(1)
        dbinstance = val.Split("|")(2)
        dbport = val.Split("|")(3)
        dbschema = val.Split("|")(4)
        dbid = val.Split("|")(5)
        dbpass = val.Split("|")(6)

        If dbsvr = "" Then
            dbname = "" 'database aplikasi disini
            dbsvr = "127.0.0.1"
            dbinstance = ""
            dbport = "1433"
            dbschema = "dbo"
            dbid = "sa"
            dbpass = "sa"
        End If

        tboDBname.Text = dbname
        tboIPsvr.Text = dbsvr
        tboInstance.Text = dbinstance
        tboPort.Text = dbport
        tboSkema.Text = dbschema
        tboUsr.Text = dbid
        tboPass.Text = dbpass

        Dim cekFileExe As Boolean = False
        Dim cekFileUploader As Boolean = False
        Dim uppath As IO.DirectoryInfo = IO.Directory.GetParent(appPath)
        uppath = IO.Directory.GetParent(uppath.FullName)
        appUpPath = uppath.FullName

        If appUpPath.Chars(appUpPath.Length - 1) <> "\" Then
            appUpPath &= "\"
        End If
        updpath = appUpPath
        iconPath = appUpPath & "Icon\"

        If IO.File.Exists(appUpPath & "dizUI.exe") = True Then
            cekFileExe = True
            cekFileUploader = False
        ElseIf IO.File.Exists(appupPath & "dizUIdemo.exe") = True Then
            cekFileExe = True
            cekFileUploader = False
        End If
        If IO.File.Exists(appPath & "dizUploader.exe") = True Then
            cekFileExe = False
            cekFileUploader = True
        End If
        If cekFileExe = True Then
            If IO.File.Exists(appPath & "AutoCheck") = True Then
                cboAutoRun.Checked = True
                UpdSave_Click(UpdSave, Nothing)

                lblCounter.Text = "Aplikasi berjalan dalam " & vbCrLf & counter & " detik"
                pCounter.BringToFront()
                pCounter.Visible = True
                pCounter.BringToFront()
                pCounter.Dock = Dock.Fill
                tmrAuto.Start()
            Else
                cboAutoRun.Checked = True
                cboAutoRun.Enabled = True
                btnRun.Enabled = True
            End If
        Else
            If cekFileUploader = True Then
                cboAutoRun.Checked = False
                cboAutoRun.Enabled = False
                btnRun.Enabled = False
            Else
                cboAutoRun.Checked = False
                cboAutoRun.Enabled = False
                btnRun.Enabled = True
            End If
        End If
    End Sub

    Public Function readSettingFile() As String
        Dim retval As String = ""
        'retval = IO.File.ReadAllLines(pathSetting & filename)(0)

        Dim myi As New SQLi(dblite)
        myi.DMLQuery("select databasename || '|' || ipserver || '|' || instance || '|' || port || '|' || schema || '|' || username || '|' || password as dbstring from dbconn where dbtype='SQLS' and dblocation='SERVER'", "getdbstring")
        myi.DMLQuery("select ipserver from dbconn where dbtype='SQLS' and dblocation='SERVER'", "getipsvr")
        If myi.getDataSet("getdbstring") > 0 Then
            dbsvr = myi.getDataSet("getipsvr", 0, "ipserver")
            retval = myi.getDataSet("getdbstring", 0, "dbstring")
        End If
        Return retval
    End Function

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Public counter As Integer = 3
    Public exeName As String = "dizUI.exe"
    Public demoName As String = "dizUIdemo.exe"
    Public iconPath As String = Application.StartupPath & "\Icon\"
    Private cekIcon As Boolean = False
    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        Dim dbstring As String = dbname & "|" & dbsvr & "|" & dbinstance & "|" & dbport & "|" & dbschema & "|" & dbid & "|" & dbpass
        Dim sqls As New SQLs(dbstring)
        If sqls.checkConnection() = False Then
            MsgBox("Server tidak ditemukan", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        lblCounter.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblCounter.Text = "Update Aplikasi"
        pCounter.Visible = True
        pCounter.BringToFront()
        pCounter.Location = New Point(0, 29)
        pCounter.Size = New Size(382, 315)
        Me.Refresh()
        Application.DoEvents()
        Threading.Thread.Sleep(50)

        btnKeluar.Enabled = False
        UpdSave.Enabled = False
        btnRun.Enabled = False
        cboAutoRun.Enabled = False

        'hapus semua icon, replace dgn yang baru
        If IO.Directory.Exists(iconPath) = False Then
            IO.Directory.CreateDirectory(iconPath)
            cekIcon = False
        Else
            If IO.Directory.GetFiles(iconPath).Length = 0 Then
                cekIcon = False
            Else
                cekIcon = True
            End If
        End If

        If cekIcon = False Then
            For Each i As String In IO.Directory.GetFiles(iconPath)
                IO.File.Delete(i)
            Next

            sqls.DMLQuery("select idiconmenu,filename,right(replace(replace(filename,'\',''),':',''),22) as fakename from sys_iconmenu", "iconmenu")
            Dim tmpimg As Image = Nothing
            Dim filename As String = ""
            Dim fakename As String = ""
            Me.Cursor = Cursors.AppStarting
            lblCounter.Text = "Update Konten" & vbCrLf & "0 / " & sqls.getDataSet("iconmenu")
            For i As Integer = 0 To sqls.getDataSet("iconmenu") - 1
                GC.Collect()
                filename = sqls.getDataSet("iconmenu", i, "filename")
                fakename = sqls.getDataSet("iconmenu", i, "fakename")
                tmpimg = sqls.getImage("sys_iconmenu", "imagesicon", "filename", filename, False)
                Try
                    tmpimg.Save(iconPath & fakename, System.Drawing.Imaging.ImageFormat.Png)
                    Me.Refresh()
                    Application.DoEvents()
                    Threading.Thread.Sleep(50)
                    lblCounter.Text = "Update Konten" & vbCrLf & i + 1 & " / " & sqls.getDataSet("iconmenu")
                Catch ex As Exception
                End Try
            Next
        End If

        If updateApps() = True Then
            'If Application.StartupPath.Chars(Application.StartupPath.Length - 1) = "\" Then
            '    updpath = Application.StartupPath
            'Else
            '    updpath = Application.StartupPath & "\"
            'End If

            Dim inputName As String = ""
            Dim CommandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs
            For Each s As String In CommandLineArgs
                inputName = s.ToLower
            Next
            If inputName = exeName Then
                If IO.File.Exists(updpath & "\" & exeName) Then
                    pCounter.Visible = False
                    pCounter.SendToBack()

                    Me.Cursor = Cursors.Default
                    Me.Refresh()
                    Application.DoEvents()
                    Threading.Thread.Sleep(50)
                    Dim strfile As String = IO.Path.Combine(updpath, exeName)
                    Process.Start(strfile, "update")
                    Environment.Exit(0)
                End If
            ElseIf inputName = demoName Then
                If IO.File.Exists(updpath & "\" & demoName) Then
                    pCounter.Visible = False
                    pCounter.SendToBack()

                    Me.Cursor = Cursors.Default
                    Me.Refresh()
                    Application.DoEvents()
                    Threading.Thread.Sleep(50)
                    Dim strfile As String = IO.Path.Combine(updpath, demoName)
                    Process.Start(strfile, "update")
                    Environment.Exit(0)
                End If
            Else
                If IO.File.Exists(updpath & "\" & exeName) Then
                    pCounter.Visible = False
                    pCounter.SendToBack()

                    Me.Cursor = Cursors.Default
                    Me.Refresh()
                    Application.DoEvents()
                    Threading.Thread.Sleep(50)
                    Dim strfile As String = IO.Path.Combine(updpath, exeName)
                    Process.Start(strfile, "update")
                    Environment.Exit(0)
                Else
                    pCounter.Visible = False
                    pCounter.SendToBack()

                    Me.Cursor = Cursors.Default
                    MsgBox("Aplikasi tidak ditemukan" & vbCrLf & "Silahkan install ulang aplikasi ini", MsgBoxStyle.Critical, "Aplikasi Tidak Ditemukan")
                End If
            End If
        Else
            pCounter.Visible = False
            pCounter.SendToBack()

            Me.Cursor = Cursors.Default
            MsgBox("Tidak dapat mengakses server, silahkan cek koneksi jaringan", MsgBoxStyle.Critical, "Kesalahan")
            'System.Diagnostics.Process.Start(Application.StartupPath & "\" & exeName, "input=update")
            'MsgBox("""" & Application.StartupPath & "\" & exeName & """" & " /input=update")
            Me.Refresh()
            Application.DoEvents()
            Threading.Thread.Sleep(50)

            Dim strfile As String = ""
            If IO.File.Exists(IO.Path.Combine(updpath, exeName)) Then
                strfile = IO.Path.Combine(updpath, exeName)
            ElseIf IO.File.Exists(IO.Path.Combine(updpath, demoName)) Then
                strfile = IO.Path.Combine(updpath, demoName)
            End If
            Process.Start(strfile, "update")
            Environment.Exit(0)
        End If

        btnKeluar.Enabled = True
        UpdSave.Enabled = True
        btnRun.Enabled = True
        cboAutoRun.Enabled = False
    End Sub

    Dim imgByteArray As Byte() = Nothing
    Private Function updateApps() As Boolean
        Dim retval As Boolean = False

        Dim psi As ProcessStartInfo = New ProcessStartInfo
        Dim p As Process = New Process()
        psi.Arguments = " /f /im dizUI.exe"
        psi.FileName = "taskkill"
        p.StartInfo = psi
        p.Start()

        psi = New ProcessStartInfo
        p = New Process()
        psi.Arguments = " /f /im dizNotifikasi.exe"
        psi.FileName = "taskkill"
        p.StartInfo = psi
        p.Start()

        Threading.Thread.Sleep(500)
        Dim dbstring As String = dbname & "|" & dbsvr & "|" & dbinstance & "|" & dbport & "|" & dbschema & "|" & dbid & "|" & dbpass
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idappfiles,filename,appversion,createddate,filebinary from sys_appfiles where postdate=(select top 1 postdate from sys_appfiles order by postdate asc)", "appfilesawal")
        Dim tmpbyte As Byte() = Nothing
        Dim filename As String = ""

        'If Application.StartupPath.Chars(Application.StartupPath.Length - 1) = "\" Then
        '    updpath = Application.StartupPath
        'Else
        '    updpath = Application.StartupPath & "\"
        'End If

        'If IO.Directory.GetFiles(updpath).LongCount < 30 Then
        '    lblCounter.Text = "Download Versi Awal" & vbCrLf & "0 / " & sqls.getDataSet("appfilesawal")
        '    For i As Integer = 0 To sqls.getDataSet("appfilesawal") - 1
        '        Dim msqls As New SQLs(dbstring)
        '        GC.Collect()
        '        tmpbyte = Nothing
        '        filename = sqls.getDataSet("appfilesawal", i, "filename")
        '        If filename.ToLower <> IO.Path.GetFileName(Application.ExecutablePath).ToLower Then
        '            If filename <> "" Then
        '                tmpbyte = msqls.getData("sys_appfiles", "filebinary", "filename", filename, False)
        '            End If
        '            Try
        '                Dim errBool As Boolean = False
        '                If IO.File.Exists(updpath & filename) = True Then
        '                    Try
        '                        IO.File.Delete(updpath & filename)
        '                    Catch ex As Exception
        '                        'MsgBox("error delete" & vbCrLf & filename & vbCrLf & sqls.getDataSet("appfiles", i, "createddate"))
        '                        errBool = True
        '                    End Try
        '                    Me.Refresh()
        '                    Application.DoEvents()
        '                    Threading.Thread.Sleep(50)
        '                End If
        '                Try
        '                    IO.File.WriteAllBytes(updpath & filename, tmpbyte)
        '                Catch ex As Exception
        '                    'MsgBox("error write" & vbCrLf & filename & vbCrLf & sqls.getDataSet("appfiles", i, "createddate"))
        '                End Try
        '                'MsgBox(updpath & filename)
        '                Me.Refresh()
        '                Application.DoEvents()
        '                Threading.Thread.Sleep(50)
        '                lblCounter.Text = "Download Versi Awal" & vbCrLf & i + 1 & " / " & sqls.getDataSet("appfilesawal")
        '            Catch ex As Exception
        '                'MsgBox("unknown error" & vbCrLf & filename & vbCrLf & ex.Message)
        '            End Try
        '        End If
        '    Next
        'End If

        sqls.DMLQuery("select idappfiles,filename,appversion,createddate,filebinary from sys_appfiles where appversion=(select value from sys_appsetting where variable='ProductVersion')", "appfiles")
        'Dim fs As IO.FileStream
        lblCounter.Text = "Update Aplikasi" & vbCrLf & "0 / " & sqls.getDataSet("appfiles")
        For i As Integer = 0 To sqls.getDataSet("appfiles") - 1
            Dim msqls As New SQLs(dbstring)
            GC.Collect()
            tmpbyte = Nothing
            filename = sqls.getDataSet("appfiles", i, "filename")
            If filename.ToLower <> IO.Path.GetFileName(updpath).ToLower Then
                If filename <> "" Then
                    tmpbyte = msqls.getData("sys_appfiles", "filebinary", "filename", filename, False)
                End If
                Try
                    Dim errBool As Boolean = False
                    If IO.File.Exists(updpath & filename) = True Then
                        Try
                            IO.File.Delete(updpath & filename)
                        Catch ex As Exception
                            'MsgBox("error delete" & vbCrLf & filename & vbCrLf & sqls.getDataSet("appfiles", i, "createddate"))
                            errBool = True
                        End Try
                        Me.Refresh()
                        Application.DoEvents()
                        Threading.Thread.Sleep(50)
                    End If
                    If errBool = False Then
                        Try
                            IO.File.WriteAllBytes(updpath & filename, tmpbyte)
                        Catch ex As Exception
                            'MsgBox("error write" & vbCrLf & filename & vbCrLf & sqls.getDataSet("appfiles", i, "createddate"))
                        End Try
                    End If
                    'MsgBox(updpath & filename)
                    Me.Refresh()
                    Application.DoEvents()
                    Threading.Thread.Sleep(50)
                    lblCounter.Text = "Update Aplikasi" & vbCrLf & i + 1 & " / " & sqls.getDataSet("appfiles")
                Catch ex As Exception
                    'MsgBox("unknown error" & vbCrLf & filename & vbCrLf & ex.Message)
                End Try
            End If
        Next
        retval = True
        Return retval
    End Function

    Private Sub cboAutoRun_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAutoRun.CheckedChanged
        If cboAutoRun.Checked Then
            IO.File.Create(appPath & "AutoCheck")
        Else
            IO.File.Delete(appPath & "AutoCheck")
        End If
        Me.Refresh()
        GC.Collect()
        Me.Refresh()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        tmrAuto.Stop()
        pCounter.Visible = False
    End Sub

    Private Sub tmrAuto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAuto.Tick
        counter -= 1
        If counter > 1 Then
            lblCounter.Text = "Aplikasi berjalan dalam" & vbCrLf & counter & " detik"
        Else
            lblCounter.Text = "Aplikasi berjalan dalam" & vbCrLf & counter & " detik"
        End If
        If counter = 0 Then
            tmrAuto.Stop()
            btnRun_Click(btnRun, Nothing)
        End If
    End Sub

End Class
