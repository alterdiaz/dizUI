Imports System.Runtime.InteropServices
Public Class frmMain

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function FindWindow(
     ByVal lpClassName As String,
     ByVal lpWindowName As String) As IntPtr
    End Function

    <DllImport("user32.dll")>
    Private Shared Function SetForegroundWindow(ByVal hWnd As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("User32")>
    Public Shared Function GetGuiResources(ByVal hProcess As IntPtr, ByVal uiFlags As Integer) As Integer
    End Function

    Public Shared Function GetGuiResourcesUserCount() As Integer
        Return GetGuiResources(Process.GetCurrentProcess().Handle, 1)
    End Function

    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto, SetLastError:=True, ExactSpelling:=True)>
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    Private Sub lblTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        'This code can be used in the MouseDown event of any control(s) you want to be able to move your form with   
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        tmrCek.Stop()
        tmrProses.Stop()
        'tmrIGD.Stop()
        'tmrIRJ.Stop()
        'tmrIRNA.Stop()
        'tmrNotes.Stop()
        'tmrRM.Stop()

        Application.Exit()
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
        niNotify.Visible = True
        niNotify.ShowBalloonTip(3000, "Notifikasi", "Notifikasi masih berjalan di background", ToolTipIcon.Info)
    End Sub

    'Private notifset As String = ""

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
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

        Me.Cursor = Cursors.WaitCursor
        Dim myProcess As System.Diagnostics.Process = System.Diagnostics.Process.GetCurrentProcess()
        myProcess.PriorityClass = System.Diagnostics.ProcessPriorityClass.RealTime

        pnlField.Visible = False
        lblProses.Visible = True
        lblProses.Text = "Menunggu login dari aplikasi induk"

        Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.SupportsTransparentBackColor, True)
        UpdateStyles()
        Me.DoubleBuffered = True
        setRegionalSetting()
        Me.Refresh()
        Application.DoEvents()

        appPath = Application.StartupPath
        If appPath.Chars(appPath.Length - 1) <> "\" Then
            appPath &= "\"
        End If
        checkPath()
        'If IO.File.Exists(appPath & "notifset") = False Then
        '    dizMsgbox("File notification setting tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
        '    Application.Exit()
        'End If
        'If IO.File.ReadAllLines(appPath & "notifset").Count = 0 Then
        '    notifset = ""
        'Else
        '    notifset = IO.File.ReadAllLines(appPath & "notifset")(0)
        'End If

        Dim pnt As New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Size.Width - 8, Screen.PrimaryScreen.WorkingArea.Height - Me.Size.Height - 8)
        Me.Location = pnt

        btnMinimize.Enabled = True
        btnMaximize.Enabled = False
        btnExit.Enabled = True

        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
        niNotify.Visible = False

        Dim de As New dizEngine.engine
        dblite = appPath & de.processD("l59ruEcWFgphomWNjDb5gA==")
        dbstring = readSettingFile()

        getRegex(dbstring)
        tmrCek.Start()

        Dim sql As New SQLs(dbstring)
        sql.DMLQuery("select getdate() as tanggal", "cekwaktu")
        If sql.getDataSet("cekwaktu") > 0 Then
            Dim tmpstr As String = sql.getDataSet("cekwaktu", 0, "tanggal")
            Dim cekdate As Date = New Date(tmpstr.Split(" ")(0).Split("-")(2), tmpstr.Split(" ")(0).Split("-")(1), tmpstr.Split(" ")(0).Split("-")(0), tmpstr.Split(" ")(1).Split(":")(0), tmpstr.Split(" ")(1).Split(":")(1), tmpstr.Split(" ")(1).Split(":")(2))
            nowTime = cekdate
        Else
            nowTime = Now
        End If
        Me.Cursor = Cursors.Default
        fNotif.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - 433, 0)
        fNotif.Size = New Size(433, Screen.PrimaryScreen.WorkingArea.Height)
        fNotif.btnMaximize.Visible = False
        'fNotif.Show()
        'tmrNotes.Start()
        tmrProses.Start()

        'If notifset = "RM" Then
        '    tmrRM.Start()
        'ElseIf notifset = "IRM" Then
        '    tmrIRM.Start()
        'ElseIf notifset = "IRNA" Then
        '    tmrIRNA.Start()
        'ElseIf notifset = "IRJ" Then
        '    tmrIRJ.Start()
        'ElseIf notifset = "IGD" Then
        '    tmrIGD.Start()
        'End If
    End Sub

    Private totalsec As Long = 0
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select u.password,u.iduser,u.username,l.userlevel,u.userstatus,u.bannedreason,u.iduserlevel,l.userdata,l.issuperadmin,u.tokenkey1,u.tokenkey2 from sys_user u left join sys_userlevel l on l.iduserlevel=u.iduserlevel where u.username='" & tboUsername.Text & "'", "login")

        Dim canLogin As Boolean = False        '
        If sqls.getDataSet("login") > 0 Then
            Dim pass As String = sqls.getDataSet("login", 0, "password")
            Dim tmptoken1 As String = sqls.getDataSet("login", 0, "tokenkey1")
            Dim tmptoken2 As String = sqls.getDataSet("login", 0, "tokenkey2")
            Dim passval As String = GeneratePass(tboPassword.Text, tmptoken1, tmptoken2, 8000)
            If pass = passval Then
                canLogin = True
            End If
        End If

        If canLogin = True Then
            If sqls.getDataSet("login", 0, "userstatus") = 1 Then
                statLogin = False
                lblWarning.Text = "Username ini tidak aktif"
                lblWarning.Visible = True
            ElseIf sqls.getDataSet("login", 0, "userstatus") = 3 Then
                statLogin = False
                lblWarning.Text = "Diblokir: " & sqls.getDataSet("login", 0, "bannedreason")
                lblWarning.Visible = True
            Else
                userid = sqls.getDataSet("login", 0, "iduser")
                username = sqls.getDataSet("login", 0, "username")
                userlevel = sqls.getDataSet("login", 0, "userlevel")
                userlevelid = sqls.getDataSet("login", 0, "iduserlevel")
                userdata = sqls.getDataSet("login", 0, "userdata")
                usersuper = sqls.getDataSet("login", 0, "issuperadmin")

                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                Dim mys As New dtsetSQLS(dbstring)
                Dim idtmp As String = GenerateGUID()

                field = New List(Of String)
                value = New List(Of Object)
                mys = New dtsetSQLS(dbstring)
                field.AddRange(New String() {"iduserlogin", "createddate", "createdby", "ipclient", "hostname"})
                value.AddRange(New Object() {idtmp, nowTime, userid, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host)})
                mys.datasetSave("sys_UserLogin", idtmp, field, value, False)

                'field = New List(Of String)
                'value = New List(Of Object)
                'field.AddRange(New String() {"@iduserlevel"})
                'value.AddRange(New Object() {userlevelid})
                'sqls.CallSP("spUserLevelNotification", "ulnotif", field, value)

                'notifkode.Clear()
                'notifcolor.Clear()
                'notiftype.Clear()

                'For i As Integer = 0 To sqls.getDataSet("ulnotif") - 1
                '    notifkode.Add(sqls.getDataSet("ulnotif", i, "kode"))
                '    notifcolor.Add(CInt(sqls.getDataSet("ulnotif", i, "color")))
                '    notiftype.Add(CInt(sqls.getDataSet("ulnotif", i, "notiftype")))
                'Next

                lblWarning.Visible = False
                statLogin = True
                isauto = False

                niNotify.Visible = True
                Me.WindowState = FormWindowState.Minimized
                Me.ShowInTaskbar = False
                'niNotify.ShowBalloonTip(2000, "Masih Berjalan", "Aplikasi masih berjalan di background", ToolTipIcon.Info)

                pnlField.Visible = False
                lblProses.Visible = True
                lblProses.Text = "Sedang Proses"
            End If
        Else
            statLogin = False
            isauto = False
            lblWarning.Text = "Username/Password tidak benar"
            lblWarning.Visible = True
        End If
    End Sub

    Private Sub tboUsername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboUsername.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rVarcharSmall) = False And (Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13) Then
            e.Handled = True
        Else
            If Asc(e.KeyChar) = 13 Then
                SendKeys.Send(vbTab)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tboPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            btnOK_Click(Me, Nothing)
        End If
    End Sub

    Private Sub tmrCek_Tick(sender As Object, e As EventArgs) Handles tmrCek.Tick
        nowTime = nowTime.AddSeconds(1)

        If isauto = False Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select iduser from sys_user where left(convert(varchar,waktucek,105)+' '+convert(varchar,waktucek,108),16) like '" & Format(nowTime, "dd-MM-yyyy HH:mm").Remove(15, 1) & "%' and ipclient='" & getIPAddress(ipaddparam.IP) & "'", "cekuser")
            If sqls.getDataSet("cekuser") > 0 Then
                If statLogin = False Then
                    autoLogin(CStr(sqls.getDataSet("cekuser", 0, "iduser").ToString))
                End If
            Else
                If isauto = True Then
                    clearchild()
                    tboUsername.Text = ""
                    tboPassword.Text = ""
                    Me.WindowState = FormWindowState.Normal
                    Me.ShowInTaskbar = True
                    statLogin = False
                    isauto = False
                    tboUsername.Focus()
                End If
            End If
        End If
        cekProses()
        cekNotif()
    End Sub

    Private Sub cekProses()
        Dim bcek As Boolean = False
        For Each p As Process In Process.GetProcessesByName("dizui")
            If p.ProcessName.ToString.ToLower = "dizui" Then
                bcek = True
                Exit For
            End If
        Next
        If bcek = False Then
            tmrProses.Stop()
            tmrCek.Stop()
            'tmrIGD.Stop()
            'tmrIRJ.Stop()
            'tmrIRNA.Stop()
            'tmrNotes.Stop()
            'tmrRM.Stop()

            Environment.Exit(0)
        End If
    End Sub

    Private cntNotifSound As Integer = 0
    Private Sub cekNotif()
        cntNotifSound += 1
        If cntNotifSound <= 4 Then Exit Sub
        If idnotif.Count > 0 Then
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
            cntNotifSound = 0
        Else
            cntNotifSound = 0
        End If
    End Sub

    Dim isauto As Boolean = False
    Private Sub autoLogin(iduser As String)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select u.password,u.iduser,u.username,l.userlevel,u.userstatus,u.bannedreason,u.iduserlevel,l.userdata,l.issuperadmin,u.tokenkey1,u.tokenkey2 from sys_user u left join sys_userlevel l on l.iduserlevel=u.iduserlevel where u.iduser='" & iduser & "'", "login")

        Dim canLogin As Boolean = False        '
        If sqls.getDataSet("login") > 0 Then
            Dim pass As String = sqls.getDataSet("login", 0, "password")
            Dim tmptoken1 As String = sqls.getDataSet("login", 0, "tokenkey1")
            Dim tmptoken2 As String = sqls.getDataSet("login", 0, "tokenkey2")
            Dim passval As String = GeneratePass(tboPassword.Text, tmptoken1, tmptoken2, 8000)
            If pass = passval Then
                canLogin = True
            End If
        End If

        userid = sqls.getDataSet("login", 0, "iduser")
        username = sqls.getDataSet("login", 0, "username")
        userlevel = sqls.getDataSet("login", 0, "userlevel")
        userlevelid = sqls.getDataSet("login", 0, "iduserlevel")
        userdata = sqls.getDataSet("login", 0, "userdata")
        usersuper = sqls.getDataSet("login", 0, "issuperadmin")

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim mys As New dtsetSQLS(dbstring)
        Dim idtmp As String = GenerateGUID()

        field = New List(Of String)
        value = New List(Of Object)
        mys = New dtsetSQLS(dbstring)
        field.AddRange(New String() {"iduserlogin", "createddate", "createdby", "ipclient", "hostname"})
        value.AddRange(New Object() {idtmp, nowTime, userid, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host)})
        mys.datasetSave("sys_UserLogin", idtmp, field, value, False)

        'field = New List(Of String)
        'value = New List(Of Object)
        'field.AddRange(New String() {"@iduserlevel"})
        'value.AddRange(New Object() {userlevelid})
        'sqls.CallSP("spUserLevelNotification", "ulnotif", field, value)

        'notifkode.Clear()
        'notifcolor.Clear()
        'notiftype.Clear()

        'For i As Integer = 0 To sqls.getDataSet("ulnotif") - 1
        '    notifkode.Add(sqls.getDataSet("ulnotif", i, "kode"))
        '    notifcolor.Add(CInt(sqls.getDataSet("ulnotif", i, "color")))
        '    notiftype.Add(CInt(sqls.getDataSet("ulnotif", i, "notiftype")))
        'Next

        lblWarning.Visible = False
        statLogin = True
        isauto = True
        niNotify.Visible = True
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False

        pnlField.Visible = False
        lblProses.Visible = True
        lblProses.Text = "Sedang Proses"
        'niNotify.ShowBalloonTip(2000, "Masih Berjalan", "Aplikasi masih berjalan di background", ToolTipIcon.Info)
    End Sub

    Private Sub tsmiKeluar_Click(sender As Object, e As EventArgs) Handles tsmiKeluar.Click
        Environment.Exit(0)
    End Sub

    Private Sub tsmiTampilkan_Click(sender As Object, e As EventArgs) Handles tsmiTampilkan.Click
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
        niNotify.Visible = False
    End Sub

    Private Sub tsmiLogout_Click(sender As Object, e As EventArgs) Handles tsmiLogout.Click
        pnlField.Visible = False
        lblProses.Visible = True
        lblProses.Text = "Menunggu login dari aplikasi induk"

        tsmiTampilkan_Click(tsmiTampilkan, Nothing)

        isauto = False
        statLogin = False
        userid = 0
        username = ""
        userlevelid = 0
        userlevel = ""
        usersuper = 0
        userdata = 0

        tmrCek.Start()
    End Sub

    Private Sub niNotify_DoubleClick(sender As Object, e As EventArgs) Handles niNotify.DoubleClick
        tsmiTampilkan_Click(tsmiTampilkan, Nothing)
    End Sub

    Private isProses As Boolean = False
    Private isAdding As Boolean = False
    Private Sub tmrProses_Tick(sender As Object, e As EventArgs) Handles tmrProses.Tick
        Try
            If statLogin = True Then
                totalsec += 1
                If nowTime.Second Mod 3 = 0 Then
                    If isProses = False Then
                        isProses = True

                        Dim sqls As New SQLs(dbstring)
                        If usersuper = "1" Then
                            'sqls.DMLQuery("select TOP 50 ROW_NUMBER() OVER (partition by n.kode Order by n.createddate asc) as nomor,n.idnotifications,n.kode,n.judul,n.konten,n.frmname,n.tableid,n.tablename,n.tablecolumnid,n.tablecolumndate,n.tablecolumnflag,n.tablecolumniduser,isnull(a.color,16777344) as color,isnull(a.notiftype,1) as notiftype from sys_notifications n left join sys_appnotification a on n.kode=a.kode where n.iskonfirm=0 and n.duedate<=getdate() and (n.kode<>'0' AND n.kode<>'-') order by n.createddate asc", "allnotif")
                            sqls.DMLQuery("select TOP 50 ROW_NUMBER() OVER (partition by n.kode Order by n.createddate asc) as nomor,n.idnotifications,n.kode,n.judul,n.konten,n.frmname,n.tableid,n.tablename,n.tablecolumnid,n.tablecolumndate,n.tablecolumnflag,n.tablecolumniduser,isnull(n.color,16777344) as color,isnull(n.notiftype,1) as notiftype,urutdate from (select n.idnotifications,n.kode,n.judul,n.konten,n.frmname,n.tableid,n.tablename,n.tablecolumnid,n.tablecolumndate,n.tablecolumnflag,n.tablecolumniduser,isnull(a.color,16777344) as color,isnull(a.notiftype,1) as notiftype,n.createddate,replace(replace(replace(convert(varchar,n.createddate,120),' ',''),':',''),'-','') as urutdate from sys_notifications n left join sys_appnotification a on n.kode=a.kode where isnull(n.kodedept,'0')='0' and n.iskonfirm=0 and n.duedate<=getdate() and (n.kode<>'0' AND n.kode<>'-') union select n.idnotifications,n.kode,n.judul,n.konten,n.frmname,n.tableid,n.tablename,n.tablecolumnid,n.tablecolumndate,n.tablecolumnflag,n.tablecolumniduser,isnull(a.color,16777344) as color,isnull(a.notiftype,1) as notiftype,n.createddate,replace(replace(replace(convert(varchar,n.createddate,120),' ',''),':',''),'-','') as urutdate from sys_notifications n left join sys_appnotification a on n.kode=a.kode where isnull(n.kodedept,'0')<>'0' and n.iskonfirm=0 and n.duedate<=getdate() and (n.kode<>'0' AND n.kode<>'-') and n.kodedept in (select d.kode from department d)) n order by n.createddate desc", "allnotif")
                        Else
                            'sqls.DMLQuery("select TOP 50 ROW_NUMBER() OVER (partition by n.kode Order by n.createddate asc) as nomor,n.idnotifications,n.kode,n.judul,n.konten,n.frmname,n.tableid,n.tablename,n.tablecolumnid,n.tablecolumndate,n.tablecolumnflag,n.tablecolumniduser,isnull(a.color,16777344) as color,isnull(a.notiftype,1) as notiftype from sys_notifications n left join sys_appnotification a on n.kode=a.kode where (n.kode<>'0' and n.kode<>'-') and ((n.kode in (select kode from sys_userlevelnotification where iduserlevel='" & userlevelid & "') and n.iskonfirm=0 and n.duedate<=getdate()) or (n.iduser='" & userid & "' and n.iskonfirm=0 and n.duedate<=getdate())) order by n.createddate asc", "allnotif")
                            sqls.DMLQuery("select TOP 50 ROW_NUMBER() OVER (partition by n.kode Order by n.createddate asc) as nomor,n.idnotifications,n.kode,n.judul,n.konten,n.frmname,n.tableid,n.tablename,n.tablecolumnid,n.tablecolumndate,n.tablecolumnflag,n.tablecolumniduser,isnull(n.color,16777344) as color,isnull(n.notiftype,1) as notiftype,urutdate from (select n.idnotifications,n.kode,n.judul,n.konten,n.frmname,n.tableid,n.tablename,n.tablecolumnid,n.tablecolumndate,n.tablecolumnflag,n.tablecolumniduser,isnull(a.color,16777344) as color,isnull(a.notiftype,1) as notiftype,n.createddate,replace(replace(replace(convert(varchar,n.createddate,120),' ',''),':',''),'-','') as urutdate from sys_notifications n left join sys_appnotification a on n.kode=a.kode where isnull(n.kodedept,'0')='0' and (n.kode<>'0' and n.kode<>'-') and ((n.kode in (select kode from sys_userlevelnotification where iduserlevel='" & userlevelid & "') and n.iskonfirm=0 and n.duedate<=getdate()) or (n.iduser='" & userid & "' and n.iskonfirm=0 and n.duedate<=getdate())) union select n.idnotifications,n.kode,n.judul,n.konten,n.frmname,n.tableid,n.tablename,n.tablecolumnid,n.tablecolumndate,n.tablecolumnflag,n.tablecolumniduser,isnull(a.color,16777344) as color,isnull(a.notiftype,1) as notiftype,n.createddate,replace(replace(replace(convert(varchar,n.createddate,120),' ',''),':',''),'-','') as urutdate from sys_notifications n left join sys_appnotification a on n.kode=a.kode where isnull(n.kodedept,'0')<>'0' and n.iskonfirm=0 and n.duedate<=getdate() and (n.kode<>'0' AND n.kode<>'-') and n.kodedept in (select top 1 d.kode from department d left join staff s on s.iddepartment=d.iddepartment where s.iduser='" & userid & "')) n order by n.createddate desc", "allnotif")
                        End If
                        isAdding = False

                        For i As Integer = 0 To sqls.getDataSet("allnotif") - 1
                            Try
                                Dim notifid As String = sqls.getDataSet("allnotif", i, "idnotifications")
                                Dim notifkode As String = sqls.getDataSet("allnotif", i, "kode")
                                Dim notifjudul As String = sqls.getDataSet("allnotif", i, "judul")
                                Dim notifkonten As String = sqls.getDataSet("allnotif", i, "konten")
                                Dim notiffrmname As String = sqls.getDataSet("allnotif", i, "frmname")
                                Dim notiftbid As String = sqls.getDataSet("allnotif", i, "tableid")
                                Dim notiftbname As String = sqls.getDataSet("allnotif", i, "tablename")
                                Dim notiftbcolid As String = sqls.getDataSet("allnotif", i, "tablecolumnid")
                                Dim notiftbcoldate As String = sqls.getDataSet("allnotif", i, "tablecolumndate")
                                Dim notiftbcolflag As String = sqls.getDataSet("allnotif", i, "tablecolumnflag")
                                Dim notiftbcoliduser As String = sqls.getDataSet("allnotif", i, "tablecolumniduser")
                                Dim notifcolor As Integer = CInt(sqls.getDataSet("allnotif", i, "color"))
                                Dim notiftype As Integer = CInt(sqls.getDataSet("allnotif", i, "notiftype"))
                                Dim notifurut As Long = CLng(sqls.getDataSet("allnotif", i, "urutdate"))

                                If idnotif.Count = 0 Then
                                    idnotif.Add(notifid)
                                    Dim infobox As New frmNotifbox(notifid, notifjudul, notifkonten, notiftype, notiftbid, notiftbname, notiftbcolid, notiftbcoldate, notiftbcolflag, notiftbcoliduser, notifcolor)
                                    'MsgBox("A")
                                    infobox.Name = notifid
                                    infobox.Tag = notifurut
                                    infobox.WindowState = FormWindowState.Normal
                                    infobox.TopMost = False
                                    infobox.TopLevel = False
                                    infobox.Anchor = AnchorStyles.None
                                    infobox.lblTitle.TextAlign = ContentAlignment.MiddleLeft
                                    infobox.PictureBox1.Visible = False
                                    infobox.btnMaximize.Visible = False
                                    infobox.btnMinimize.Visible = False
                                    infobox.Parent = pBody
                                    fNotif.pBody.Controls.Add(infobox)
                                    tambahChild(infobox)
                                    infobox.Show()
                                    infobox.BringToFront()
                                    infobox.Dock = Dock.Top
                                    isAdding = True
                                Else
                                    Dim id As String = idnotif.Find(Function(val As String)
                                                                        Return val = sqls.getDataSet("allnotif", i, "idnotifications").ToString
                                                                    End Function)
                                    If id = String.Empty Then
                                        idnotif.Add(notifid)
                                        Dim infobox As New frmNotifbox(notifid, notifjudul, notifkonten, notiftype, notiftbid, notiftbname, notiftbcolid, notiftbcoldate, notiftbcolflag, notiftbcoliduser, notifcolor)
                                        'MsgBox("B")
                                        infobox.Name = notifid
                                        infobox.Tag = notifurut
                                        infobox.WindowState = FormWindowState.Normal
                                        infobox.TopMost = False
                                        infobox.TopLevel = False
                                        infobox.Anchor = AnchorStyles.None
                                        infobox.lblTitle.TextAlign = ContentAlignment.MiddleLeft
                                        infobox.PictureBox1.Visible = False
                                        infobox.btnMaximize.Visible = False
                                        infobox.btnMinimize.Visible = False
                                        infobox.Parent = pBody
                                        fNotif.pBody.Controls.Add(infobox)
                                        tambahChild(infobox)
                                        infobox.Show()
                                        infobox.BringToFront()
                                        infobox.Dock = Dock.Top
                                        isAdding = True
                                    End If
                                End If
                            Catch ex As Exception
                                MsgBox(sqls.getDataSet("allnotif", i, "idnotifications") & vbCrLf & sqls.getDataSet("allnotif", i, "judul") & vbCrLf & ex.Message)
                            End Try
                        Next
                        'fNotif.pBody.Visible = False
                        'fNotif.pBody.Invalidate()
                        'fNotif.pBody.Visible = True

                        'Dim maxcnt As Long = 0
                        'For i As Integer = 0 To fNotif.pBody.Controls.Count - 1
                        '    For a As Integer = 0 To fNotif.pBody.Controls.Count - 1
                        '        If fNotif.pBody.Controls.Item(a).Tag > maxcnt Then
                        '            maxcnt = CLng(fNotif.pBody.Controls.Item(a).Tag)
                        '            'fNotif.pBody.Controls.Item(a).Dock = DockStyle.None
                        '            fNotif.pBody.Controls.Item(a).BringToFront()
                        '            'fNotif.pBody.Controls.Item(a).Location = New Point(0, 162 * i)
                        '            'fNotif.pBody.Invalidate()
                        '            Application.DoEvents()
                        '        End If
                        '    Next
                        'Next
                    End If
                    isProses = False
                End If
                If fNotif.pBody.Controls.Count = 0 Then
                    isfocus = False
                    fNotif.TopLevel = False
                    fNotif.TopMost = False
                    fNotif.SendToBack()
                    fNotif.Visible = False
                    fNotif.Hide()
                Else
                    If isAdding = True Then
                        fNotif.WindowState = FormWindowState.Normal
                        fNotif.Show()
                        fNotif.TopLevel = True
                        fNotif.Visible = True
                        fNotif.TopMost = True
                        fNotif.BringToFront()
                        fNotif.Activate()

                        Dim Name As String = "Notifikasi"
                        Dim ptr As IntPtr = FindWindow(Nothing, Name)
                        SetForegroundWindow(ptr)
                        isfocus = True
                        fNotif.TopMost = False
                    End If
                End If
                If isauto = False Then
                    If totalsec >= 28800 Then
                        clearchild()
                        tboUsername.Text = ""
                        tboPassword.Text = ""
                        Me.WindowState = FormWindowState.Normal
                        Me.ShowInTaskbar = True
                        statLogin = False
                        tboUsername.Focus()
                    End If
                End If
            Else
                totalsec = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim fNotif As New frmNotifikasi
    Private Sub tsmiForceClose_Click(sender As Object, e As EventArgs) Handles tsmiForceClose.Click
        Shell("taskkill -im dizUI.exe -f", AppWinStyle.Hide)
        Shell("taskkill -im dizUIdemo.exe -f", AppWinStyle.Hide)
    End Sub

End Class