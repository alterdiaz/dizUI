Public Class frmMain

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
        tmrIGD.Stop()
        tmrIRJ.Stop()
        tmrIRNA.Stop()
        tmrNotes.Stop()
        tmrRM.Stop()

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

    Private notifset As String = ""
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
        If IO.File.Exists(appPath & "notifset") = False Then
            dizMsgbox("File notification setting tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
            Application.Exit()
        End If
        If IO.File.ReadAllLines(appPath & "notifset").Count = 0 Then
            notifset = ""
        Else
            notifset = IO.File.ReadAllLines(appPath & "notifset")(0)
        End If

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
        tmrNotes.Start()
        If notifset = "RM" Then
            tmrRM.Start()
        ElseIf notifset = "IRM" Then
            tmrIRM.Start()
        ElseIf notifset = "IRNA" Then
            tmrIRNA.Start()
        ElseIf notifset = "IRJ" Then
            tmrIRJ.Start()
        ElseIf notifset = "IGD" Then
            tmrIGD.Start()
        End If
    End Sub

    Private totalsec As Long = 0
    Private Sub tmrNotes_Tick(sender As Object, e As EventArgs) Handles tmrNotes.Tick
        If statLogin = True Then
            If nowTime.Second Mod 3 = 0 Then
                Dim sqls As New SQLs(dbstring)
                Dim sqls2 As New SQLs(dbstring)
                Dim strttl As String = ""
                Dim strmsg As String = ""

                sqls.DMLQuery("select idusernotes from sys_usernotes where (warningdate<=getdate() and warningdate is not null) and iscomplete=0 and iduser='" & userid & "'", "notesnull")
                For i As Integer = 0 To sqls.getDataSet("notesnull") - 1
                    strttl = ""
                    strmsg = ""

                    If idnotes.Count = 0 Then
                        sqls2 = New SQLs(dbstring)

                        Dim id As String = sqls.getDataSet("notesnull", i, "idusernotes").ToString
                        idnotes.Add(sqls.getDataSet("notesnull", i, "idusernotes").ToString)
                        sqls2.DMLQuery("select title from sys_usernotes where idusernotes='" & idnotes(idnotes.Count - 1) & "'", "ceknotes")
                        If sqls2.getDataSet("ceknotes") > 0 Then
                            strttl = sqls2.getDataSet("ceknotes", 0, "title")
                            strmsg = "Ada catatan yang perlu anda baca segera"

                            Dim infobox As New frmInfoboxNotes(strttl, strmsg, frmInfoboxNotes.MsgType.InfoIcon, sqls.getDataSet("notesnull", i, "idusernotes").ToString)
                            infobox.BringToFront()
                            infobox.TopMost = True
                            tambahChild(infobox)
                            infobox.Show()
                        End If
                    Else
                        Dim id As String = idnotes.Find(Function(val As String)
                                                            Return val = sqls.getDataSet("notesnull", i, "idusernotes").ToString
                                                        End Function)
                        If id = String.Empty Then
                            sqls2 = New SQLs(dbstring)

                            idnotes.Add(sqls.getDataSet("notesnull", i, "idusernotes").ToString)
                            sqls2.DMLQuery("select title from sys_usernotes where idusernotes='" & idnotes(idnotes.Count - 1) & "'", "ceknotes")
                            If sqls2.getDataSet("ceknotes") > 0 Then
                                strttl = sqls2.getDataSet("ceknotes", 0, "title")
                                strmsg = "Ada catatan yang perlu anda baca segera"

                                Dim infobox As New frmInfoboxNotes(strttl, strmsg, frmInfoboxNotes.MsgType.InfoIcon, sqls.getDataSet("notesnull", i, "idusernotes").ToString)
                                infobox.BringToFront()
                                infobox.TopMost = True
                                tambahChild(infobox)
                                infobox.Show()
                            End If
                        End If
                    End If
                Next
            End If
        Else
            totalsec = 0
        End If
    End Sub

    Private Sub tmrRM_Tick(sender As Object, e As EventArgs) Handles tmrRM.Tick
        If statLogin = True Then
            totalsec += 1
            If nowTime.Second Mod 3 = 0 Then
                Dim sqls As New SQLs(dbstring)
                Dim sqls2 As New SQLs(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                Dim strttl As String = ""
                Dim strmsg As String = ""

                field.Add("@idreg")
                sqls.DMLQuery("select idregistrasi from registrasi where preparedby is null", "regnull")
                For i As Integer = 0 To sqls.getDataSet("regnull") - 1
                    value = New List(Of Object)
                    strttl = ""
                    strmsg = ""

                    If idreg.Count = 0 Then
                        sqls2 = New SQLs(dbstring)

                        Dim id As String = sqls.getDataSet("regnull", i, "idregistrasi").ToString
                        idreg.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                        value.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                        sqls2.CallSP("spRegistrasiSlip", "regslip", field, value)
                        If sqls2.getDataSet("regslip") > 0 Then
                            strttl = sqls2.getDataSet("regslip", 0, "regno")
                            strmsg = sqls2.getDataSet("regslip", 0, "norm") & " (" & sqls2.getDataSet("regslip", 0, "sex") & ")" & vbCrLf & sqls2.getDataSet("regslip", 0, "namapasien") & vbCrLf & sqls2.getDataSet("regslip", 0, "paramedis") & vbCrLf & sqls2.getDataSet("regslip", 0, "spesialis")

                            Dim infobox As New frmInfoboxRegPrepare(strttl, strmsg, frmInfoboxRegPrepare.MsgType.InfoIcon, sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            infobox.BringToFront()
                            infobox.TopMost = True
                            tambahChild(infobox)
                            infobox.Show()
                        End If
                    Else
                        Dim id As String = idreg.Find(Function(val As String)
                                                          Return val = sqls.getDataSet("regnull", i, "idregistrasi").ToString
                                                      End Function)
                        If id = String.Empty Then
                            sqls2 = New SQLs(dbstring)

                            idreg.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            value.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            sqls2.CallSP("spRegistrasiSlip", "regslip", field, value)
                            If sqls2.getDataSet("regslip") > 0 Then
                                strttl = sqls2.getDataSet("regslip", 0, "regno")
                                strmsg = sqls2.getDataSet("regslip", 0, "norm") & " (" & sqls2.getDataSet("regslip", 0, "sex") & ")" & vbCrLf & sqls2.getDataSet("regslip", 0, "namapasien") & vbCrLf & sqls2.getDataSet("regslip", 0, "paramedis") & vbCrLf & sqls2.getDataSet("regslip", 0, "spesialis")

                                Dim infobox As New frmInfoboxRegPrepare(strttl, strmsg, frmInfoboxRegPrepare.MsgType.InfoIcon, sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                                infobox.BringToFront()
                                infobox.TopMost = True
                                tambahChild(infobox)
                                infobox.Show()
                            End If
                        End If
                    End If
                Next
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
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select u.password,u.iduser,u.username,l.userlevel,u.iduserstatus,u.bannedreason,u.iduserlevel,l.userdata,l.issuperadmin,u.tokenkey1,u.tokenkey2 from sys_user u left join sys_userlevel l on l.iduserlevel=u.iduserlevel where u.username='" & tboUsername.Text & "'", "login")

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
            If sqls.getDataSet("login", 0, "iduserstatus") = 1 Then
                statLogin = False
                lblWarning.Text = "Username ini tidak aktif"
                lblWarning.Visible = True
            ElseIf sqls.getDataSet("login", 0, "iduserstatus") = 3 Then
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
            tmrCek.Stop()
            tmrIGD.Stop()
            tmrIRJ.Stop()
            tmrIRNA.Stop()
            tmrNotes.Stop()
            tmrRM.Stop()

            Application.Exit()
        End If
    End Sub

    Dim isauto As Boolean = False
    Private Sub autoLogin(iduser As String)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select u.password,u.iduser,u.username,l.userlevel,u.iduserstatus,u.bannedreason,u.iduserlevel,l.userdata,l.issuperadmin,u.tokenkey1,u.tokenkey2 from sys_user u left join sys_userlevel l on l.iduserlevel=u.iduserlevel where u.iduser='" & iduser & "'", "login")

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

    Private Sub tmrIRNA_Tick(sender As Object, e As EventArgs) Handles tmrIRNA.Tick
        If statLogin = True Then
            totalsec += 1
            If nowTime.Second Mod 3 = 0 Then
                Dim sqls As New SQLs(dbstring)
                Dim sqls2 As New SQLs(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                Dim strttl As String = ""
                Dim strmsg As String = ""

                field.Add("@idreg")
                sqls.DMLQuery("select idregistrasi from registrasi where iddepartment=(select top 1 [value] from sys_appsetting where variable='IDInpatientDept') and respondby is null", "respondnull")
                For i As Integer = 0 To sqls.getDataSet("regnull") - 1
                    value = New List(Of Object)
                    strttl = ""
                    strmsg = ""

                    If idreg.Count = 0 Then
                        sqls2 = New SQLs(dbstring)

                        Dim id As String = sqls.getDataSet("regnull", i, "idregistrasi").ToString
                        idreg.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                        value.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                        sqls2.CallSP("spRegistrasiSlip", "regslip", field, value)
                        If sqls2.getDataSet("regslip") > 0 Then
                            strttl = sqls2.getDataSet("regslip", 0, "regno")
                            strmsg = sqls2.getDataSet("regslip", 0, "norm") & " (" & sqls2.getDataSet("regslip", 0, "sex") & ")" & vbCrLf & sqls2.getDataSet("regslip", 0, "namapasien") & vbCrLf & sqls2.getDataSet("regslip", 0, "paramedis") & vbCrLf & sqls2.getDataSet("regslip", 0, "spesialis") & vbCrLf & "Menunggu Respon Department Penerima"

                            Dim infobox As New frmInfoboxRegRespond(strttl, strmsg, frmInfoboxRegPrepare.MsgType.InfoIcon, sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            infobox.BringToFront()
                            infobox.TopMost = True
                            tambahChild(infobox)
                            infobox.Show()
                        End If
                    Else
                        Dim id As String = idreg.Find(Function(val As String)
                                                          Return val = sqls.getDataSet("regnull", i, "idregistrasi").ToString
                                                      End Function)
                        If id = String.Empty Then
                            sqls2 = New SQLs(dbstring)

                            idreg.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            value.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            sqls2.CallSP("spRegistrasiSlip", "regslip", field, value)
                            If sqls2.getDataSet("regslip") > 0 Then
                                strttl = sqls2.getDataSet("regslip", 0, "regno")
                                strmsg = sqls2.getDataSet("regslip", 0, "norm") & " (" & sqls2.getDataSet("regslip", 0, "sex") & ")" & vbCrLf & sqls2.getDataSet("regslip", 0, "namapasien") & vbCrLf & sqls2.getDataSet("regslip", 0, "paramedis") & vbCrLf & sqls2.getDataSet("regslip", 0, "spesialis") & vbCrLf & "Menunggu Respon Department Penerima"

                                Dim infobox As New frmInfoboxRegRespond(strttl, strmsg, frmInfoboxRegPrepare.MsgType.InfoIcon, sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                                infobox.BringToFront()
                                infobox.TopMost = True
                                tambahChild(infobox)
                                infobox.Show()
                            End If
                        End If
                    End If
                Next
            End If

            If nowTime.Second Mod 3 = 0 Then
                Dim sqls As New SQLs(dbstring)
                Dim sqls2 As New SQLs(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                Dim strttl As String = ""
                Dim strmsg As String = ""

                field.Add("@idreg")
                sqls.DMLQuery("select idregistrasi from registrasi where iddepartment=(select top 1 [value] from sys_appsetting where variable='IDInpatientDept') and preparedby is not null and receivedby is null", "regnull")
                For i As Integer = 0 To sqls.getDataSet("regnull") - 1
                    value = New List(Of Object)
                    strttl = ""
                    strmsg = ""

                    If idregi.Count = 0 Then
                        sqls2 = New SQLs(dbstring)

                        Dim id As String = sqls.getDataSet("regnull", i, "idregistrasi").ToString
                        idregi.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                        value.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                        sqls2.CallSP("spRegistrasiSlip", "regslip", field, value)
                        If sqls2.getDataSet("regslip") > 0 Then
                            strttl = sqls2.getDataSet("regslip", 0, "regno")
                            strmsg = sqls2.getDataSet("regslip", 0, "norm") & " (" & sqls2.getDataSet("regslip", 0, "sex") & ")" & vbCrLf & sqls2.getDataSet("regslip", 0, "namapasien") & vbCrLf & sqls2.getDataSet("regslip", 0, "paramedis") & vbCrLf & sqls2.getDataSet("regslip", 0, "spesialis") & vbCrLf & "RM sedang disiapkan, konfirm jika sudah diterima"

                            Dim infobox As New frmInfoboxRegReceiver(strttl, strmsg, frmInfoboxRegReceiver.MsgType.InfoIcon, sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            infobox.BringToFront()
                            infobox.TopMost = True
                            tambahChild(infobox)
                            infobox.Show()
                        End If
                    Else
                        Dim id As String = idregi.Find(Function(val As String)
                                                           Return val = sqls.getDataSet("regnull", i, "idregistrasi").ToString
                                                       End Function)
                        If id = String.Empty Then
                            sqls2 = New SQLs(dbstring)

                            idregi.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            value.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            sqls2.CallSP("spRegistrasiSlip", "regslip", field, value)
                            If sqls2.getDataSet("regslip") > 0 Then
                                strttl = sqls2.getDataSet("regslip", 0, "regno")
                                strmsg = sqls2.getDataSet("regslip", 0, "norm") & " (" & sqls2.getDataSet("regslip", 0, "sex") & ")" & vbCrLf & sqls2.getDataSet("regslip", 0, "namapasien") & vbCrLf & sqls2.getDataSet("regslip", 0, "paramedis") & vbCrLf & sqls2.getDataSet("regslip", 0, "spesialis") & vbCrLf & "RM sedang disiapkan, konfirm jika sudah diterima"

                                Dim infobox As New frmInfoboxRegReceiver(strttl, strmsg, frmInfoboxRegReceiver.MsgType.InfoIcon, sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                                infobox.BringToFront()
                                infobox.TopMost = True
                                tambahChild(infobox)
                                infobox.Show()
                            End If
                        End If
                    End If
                Next
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
    End Sub

    Private Sub tmrIRJ_Tick(sender As Object, e As EventArgs) Handles tmrIRJ.Tick
        If statLogin = True Then
            totalsec += 1
            If nowTime.Second Mod 3 = 0 Then
                Dim sqls As New SQLs(dbstring)
                Dim sqls2 As New SQLs(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                Dim strttl As String = ""
                Dim strmsg As String = ""

                field.Add("@idreg")
                sqls.DMLQuery("select idregistrasi from registrasi where iddepartment=(select top 1 [value] from sys_appsetting where variable='IDOutpatientDept') and respondby is null", "respondnull")
                For i As Integer = 0 To sqls.getDataSet("regnull") - 1
                    value = New List(Of Object)
                    strttl = ""
                    strmsg = ""

                    If idreg.Count = 0 Then
                        sqls2 = New SQLs(dbstring)

                        Dim id As String = sqls.getDataSet("regnull", i, "idregistrasi").ToString
                        idreg.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                        value.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                        sqls2.CallSP("spRegistrasiSlip", "regslip", field, value)
                        If sqls2.getDataSet("regslip") > 0 Then
                            strttl = sqls2.getDataSet("regslip", 0, "regno")
                            strmsg = sqls2.getDataSet("regslip", 0, "norm") & " (" & sqls2.getDataSet("regslip", 0, "sex") & ")" & vbCrLf & sqls2.getDataSet("regslip", 0, "namapasien") & vbCrLf & sqls2.getDataSet("regslip", 0, "paramedis") & vbCrLf & sqls2.getDataSet("regslip", 0, "spesialis") & vbCrLf & "Menunggu Respon Department Penerima"

                            Dim infobox As New frmInfoboxRegRespond(strttl, strmsg, frmInfoboxRegPrepare.MsgType.InfoIcon, sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            infobox.BringToFront()
                            infobox.TopMost = True
                            tambahChild(infobox)
                            infobox.Show()
                        End If
                    Else
                        Dim id As String = idreg.Find(Function(val As String)
                                                          Return val = sqls.getDataSet("regnull", i, "idregistrasi").ToString
                                                      End Function)
                        If id = String.Empty Then
                            sqls2 = New SQLs(dbstring)

                            idreg.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            value.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            sqls2.CallSP("spRegistrasiSlip", "regslip", field, value)
                            If sqls2.getDataSet("regslip") > 0 Then
                                strttl = sqls2.getDataSet("regslip", 0, "regno")
                                strmsg = sqls2.getDataSet("regslip", 0, "norm") & " (" & sqls2.getDataSet("regslip", 0, "sex") & ")" & vbCrLf & sqls2.getDataSet("regslip", 0, "namapasien") & vbCrLf & sqls2.getDataSet("regslip", 0, "paramedis") & vbCrLf & sqls2.getDataSet("regslip", 0, "spesialis") & vbCrLf & "Menunggu Respon Department Penerima"

                                Dim infobox As New frmInfoboxRegRespond(strttl, strmsg, frmInfoboxRegPrepare.MsgType.InfoIcon, sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                                infobox.BringToFront()
                                infobox.TopMost = True
                                tambahChild(infobox)
                                infobox.Show()
                            End If
                        End If
                    End If
                Next
            End If

            If nowTime.Second Mod 3 = 0 Then
                Dim sqls As New SQLs(dbstring)
                Dim sqls2 As New SQLs(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                Dim strttl As String = ""
                Dim strmsg As String = ""

                field.Add("@idreg")
                sqls.DMLQuery("select idregistrasi from registrasi where iddepartment=(select top 1 [value] from sys_appsetting where variable='IDOutpatientDept') and preparedby is not null and receivedby is null", "regnull")
                For i As Integer = 0 To sqls.getDataSet("regnull") - 1
                    value = New List(Of Object)
                    strttl = ""
                    strmsg = ""

                    If idregi.Count = 0 Then
                        sqls2 = New SQLs(dbstring)

                        Dim id As String = sqls.getDataSet("regnull", i, "idregistrasi").ToString
                        idregi.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                        value.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                        sqls2.CallSP("spRegistrasiSlip", "regslip", field, value)
                        If sqls2.getDataSet("regslip") > 0 Then
                            strttl = sqls2.getDataSet("regslip", 0, "regno")
                            strmsg = sqls2.getDataSet("regslip", 0, "norm") & " (" & sqls2.getDataSet("regslip", 0, "sex") & ")" & vbCrLf & sqls2.getDataSet("regslip", 0, "namapasien") & vbCrLf & sqls2.getDataSet("regslip", 0, "paramedis") & vbCrLf & sqls2.getDataSet("regslip", 0, "spesialis") & vbCrLf & "RM sedang disiapkan, konfirm jika sudah diterima"

                            Dim infobox As New frmInfoboxRegReceiver(strttl, strmsg, frmInfoboxRegReceiver.MsgType.InfoIcon, sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            infobox.BringToFront()
                            infobox.TopMost = True
                            tambahChild(infobox)
                            infobox.Show()
                        End If
                    Else
                        Dim id As String = idregi.Find(Function(val As String)
                                                           Return val = sqls.getDataSet("regnull", i, "idregistrasi").ToString
                                                       End Function)
                        If id = String.Empty Then
                            sqls2 = New SQLs(dbstring)

                            idregi.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            value.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            sqls2.CallSP("spRegistrasiSlip", "regslip", field, value)
                            If sqls2.getDataSet("regslip") > 0 Then
                                strttl = sqls2.getDataSet("regslip", 0, "regno")
                                strmsg = sqls2.getDataSet("regslip", 0, "norm") & " (" & sqls2.getDataSet("regslip", 0, "sex") & ")" & vbCrLf & sqls2.getDataSet("regslip", 0, "namapasien") & vbCrLf & sqls2.getDataSet("regslip", 0, "paramedis") & vbCrLf & sqls2.getDataSet("regslip", 0, "spesialis") & vbCrLf & "RM sedang disiapkan, konfirm jika sudah diterima"

                                Dim infobox As New frmInfoboxRegReceiver(strttl, strmsg, frmInfoboxRegReceiver.MsgType.InfoIcon, sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                                infobox.BringToFront()
                                infobox.TopMost = True
                                tambahChild(infobox)
                                infobox.Show()
                            End If
                        End If
                    End If
                Next
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
    End Sub

    Private Sub tmrIGD_Tick(sender As Object, e As EventArgs) Handles tmrIGD.Tick
        If statLogin = True Then
            totalsec += 1
            If nowTime.Second Mod 3 = 0 Then
                Dim sqls As New SQLs(dbstring)
                Dim sqls2 As New SQLs(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                Dim strttl As String = ""
                Dim strmsg As String = ""

                field.Add("@idreg")
                sqls.DMLQuery("select idregistrasi from registrasi where iddepartment=(select top 1 [value] from sys_appsetting where variable='IDEmergencyDept') and respondby is null", "respondnull")
                For i As Integer = 0 To sqls.getDataSet("regnull") - 1
                    value = New List(Of Object)
                    strttl = ""
                    strmsg = ""

                    If idreg.Count = 0 Then
                        sqls2 = New SQLs(dbstring)

                        Dim id As String = sqls.getDataSet("regnull", i, "idregistrasi").ToString
                        idreg.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                        value.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                        sqls2.CallSP("spRegistrasiSlip", "regslip", field, value)
                        If sqls2.getDataSet("regslip") > 0 Then
                            strttl = sqls2.getDataSet("regslip", 0, "regno")
                            strmsg = sqls2.getDataSet("regslip", 0, "norm") & " (" & sqls2.getDataSet("regslip", 0, "sex") & ")" & vbCrLf & sqls2.getDataSet("regslip", 0, "namapasien") & vbCrLf & sqls2.getDataSet("regslip", 0, "paramedis") & vbCrLf & sqls2.getDataSet("regslip", 0, "spesialis") & vbCrLf & "Menunggu Respon Department Penerima"

                            Dim infobox As New frmInfoboxRegRespond(strttl, strmsg, frmInfoboxRegPrepare.MsgType.InfoIcon, sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            infobox.BringToFront()
                            infobox.TopMost = True
                            tambahChild(infobox)
                            infobox.Show()
                        End If
                    Else
                        Dim id As String = idreg.Find(Function(val As String)
                                                          Return val = sqls.getDataSet("regnull", i, "idregistrasi").ToString
                                                      End Function)
                        If id = String.Empty Then
                            sqls2 = New SQLs(dbstring)

                            idreg.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            value.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            sqls2.CallSP("spRegistrasiSlip", "regslip", field, value)
                            If sqls2.getDataSet("regslip") > 0 Then
                                strttl = sqls2.getDataSet("regslip", 0, "regno")
                                strmsg = sqls2.getDataSet("regslip", 0, "norm") & " (" & sqls2.getDataSet("regslip", 0, "sex") & ")" & vbCrLf & sqls2.getDataSet("regslip", 0, "namapasien") & vbCrLf & sqls2.getDataSet("regslip", 0, "paramedis") & vbCrLf & sqls2.getDataSet("regslip", 0, "spesialis") & vbCrLf & "Menunggu Respon Department Penerima"

                                Dim infobox As New frmInfoboxRegRespond(strttl, strmsg, frmInfoboxRegPrepare.MsgType.InfoIcon, sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                                infobox.BringToFront()
                                infobox.TopMost = True
                                tambahChild(infobox)
                                infobox.Show()
                            End If
                        End If
                    End If
                Next
            End If

            If nowTime.Second Mod 3 = 0 Then
                Dim sqls As New SQLs(dbstring)
                Dim sqls2 As New SQLs(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                Dim strttl As String = ""
                Dim strmsg As String = ""

                field.Add("@idreg")
                sqls.DMLQuery("select idregistrasi from registrasi where iddepartment=(select top 1 [value] from sys_appsetting where variable='IDEmergencyDept') and preparedby is not null and receivedby is null", "regnull")
                For i As Integer = 0 To sqls.getDataSet("regnull") - 1
                    value = New List(Of Object)
                    strttl = ""
                    strmsg = ""

                    If idregi.Count = 0 Then
                        sqls2 = New SQLs(dbstring)

                        Dim id As String = sqls.getDataSet("regnull", i, "idregistrasi").ToString
                        idregi.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                        value.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                        sqls2.CallSP("spRegistrasiSlip", "regslip", field, value)
                        If sqls2.getDataSet("regslip") > 0 Then
                            strttl = sqls2.getDataSet("regslip", 0, "regno")
                            strmsg = sqls2.getDataSet("regslip", 0, "norm") & " (" & sqls2.getDataSet("regslip", 0, "sex") & ")" & vbCrLf & sqls2.getDataSet("regslip", 0, "namapasien") & vbCrLf & sqls2.getDataSet("regslip", 0, "paramedis") & vbCrLf & sqls2.getDataSet("regslip", 0, "spesialis") & vbCrLf & "RM sedang disiapkan, konfirm jika sudah diterima"

                            Dim infobox As New frmInfoboxRegReceiver(strttl, strmsg, frmInfoboxRegReceiver.MsgType.InfoIcon, sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            infobox.BringToFront()
                            infobox.TopMost = True
                            tambahChild(infobox)
                            infobox.Show()
                        End If
                    Else
                        Dim id As String = idregi.Find(Function(val As String)
                                                           Return val = sqls.getDataSet("regnull", i, "idregistrasi").ToString
                                                       End Function)
                        If id = String.Empty Then
                            sqls2 = New SQLs(dbstring)

                            idregi.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            value.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            sqls2.CallSP("spRegistrasiSlip", "regslip", field, value)
                            If sqls2.getDataSet("regslip") > 0 Then
                                strttl = sqls2.getDataSet("regslip", 0, "regno")
                                strmsg = sqls2.getDataSet("regslip", 0, "norm") & " (" & sqls2.getDataSet("regslip", 0, "sex") & ")" & vbCrLf & sqls2.getDataSet("regslip", 0, "namapasien") & vbCrLf & sqls2.getDataSet("regslip", 0, "paramedis") & vbCrLf & sqls2.getDataSet("regslip", 0, "spesialis") & vbCrLf & "RM sedang disiapkan, konfirm jika sudah diterima"

                                Dim infobox As New frmInfoboxRegReceiver(strttl, strmsg, frmInfoboxRegReceiver.MsgType.InfoIcon, sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                                infobox.BringToFront()
                                infobox.TopMost = True
                                tambahChild(infobox)
                                infobox.Show()
                            End If
                        End If
                    End If
                Next
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

    Private Sub tmrIRM_Tick(sender As Object, e As EventArgs) Handles tmrIRM.Tick
        If statLogin = True Then
            totalsec += 1
            If nowTime.Second Mod 3 = 0 Then
                Dim sqls As New SQLs(dbstring)
                Dim sqls2 As New SQLs(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                Dim strttl As String = ""
                Dim strmsg As String = ""

                field.Add("@idreg")
                sqls.DMLQuery("select idregistrasi from registrasi where iddepartment=(select top 1 [value] from sys_appsetting where variable='IDPhysioDept') and respondby is null", "respondnull")
                For i As Integer = 0 To sqls.getDataSet("regnull") - 1
                    value = New List(Of Object)
                    strttl = ""
                    strmsg = ""

                    If idreg.Count = 0 Then
                        sqls2 = New SQLs(dbstring)

                        Dim id As String = sqls.getDataSet("regnull", i, "idregistrasi").ToString
                        idreg.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                        value.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                        sqls2.CallSP("spRegistrasiSlip", "regslip", field, value)
                        If sqls2.getDataSet("regslip") > 0 Then
                            strttl = sqls2.getDataSet("regslip", 0, "regno")
                            strmsg = sqls2.getDataSet("regslip", 0, "norm") & " (" & sqls2.getDataSet("regslip", 0, "sex") & ")" & vbCrLf & sqls2.getDataSet("regslip", 0, "namapasien") & vbCrLf & sqls2.getDataSet("regslip", 0, "paramedis") & vbCrLf & sqls2.getDataSet("regslip", 0, "spesialis") & vbCrLf & "Menunggu Respon Department Penerima"

                            Dim infobox As New frmInfoboxRegRespond(strttl, strmsg, frmInfoboxRegPrepare.MsgType.InfoIcon, sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            infobox.BringToFront()
                            infobox.TopMost = True
                            tambahChild(infobox)
                            infobox.Show()
                        End If
                    Else
                        Dim id As String = idreg.Find(Function(val As String)
                                                          Return val = sqls.getDataSet("regnull", i, "idregistrasi").ToString
                                                      End Function)
                        If id = String.Empty Then
                            sqls2 = New SQLs(dbstring)

                            idreg.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            value.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            sqls2.CallSP("spRegistrasiSlip", "regslip", field, value)
                            If sqls2.getDataSet("regslip") > 0 Then
                                strttl = sqls2.getDataSet("regslip", 0, "regno")
                                strmsg = sqls2.getDataSet("regslip", 0, "norm") & " (" & sqls2.getDataSet("regslip", 0, "sex") & ")" & vbCrLf & sqls2.getDataSet("regslip", 0, "namapasien") & vbCrLf & sqls2.getDataSet("regslip", 0, "paramedis") & vbCrLf & sqls2.getDataSet("regslip", 0, "spesialis") & vbCrLf & "Menunggu Respon Department Penerima"

                                Dim infobox As New frmInfoboxRegRespond(strttl, strmsg, frmInfoboxRegPrepare.MsgType.InfoIcon, sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                                infobox.BringToFront()
                                infobox.TopMost = True
                                tambahChild(infobox)
                                infobox.Show()
                            End If
                        End If
                    End If
                Next
            End If

            If nowTime.Second Mod 3 = 0 Then
                Dim sqls As New SQLs(dbstring)
                Dim sqls2 As New SQLs(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                Dim strttl As String = ""
                Dim strmsg As String = ""

                field.Add("@idreg")
                sqls.DMLQuery("select idregistrasi from registrasi where iddepartment=(select top 1 [value] from sys_appsetting where variable='IDPhysioDept') and preparedby is not null and receivedby is null", "regnull")
                For i As Integer = 0 To sqls.getDataSet("regnull") - 1
                    value = New List(Of Object)
                    strttl = ""
                    strmsg = ""

                    If idregi.Count = 0 Then
                        sqls2 = New SQLs(dbstring)

                        Dim id As String = sqls.getDataSet("regnull", i, "idregistrasi").ToString
                        idregi.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                        value.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                        sqls2.CallSP("spRegistrasiSlip", "regslip", field, value)
                        If sqls2.getDataSet("regslip") > 0 Then
                            strttl = sqls2.getDataSet("regslip", 0, "regno")
                            strmsg = sqls2.getDataSet("regslip", 0, "norm") & " (" & sqls2.getDataSet("regslip", 0, "sex") & ")" & vbCrLf & sqls2.getDataSet("regslip", 0, "namapasien") & vbCrLf & sqls2.getDataSet("regslip", 0, "paramedis") & vbCrLf & sqls2.getDataSet("regslip", 0, "spesialis") & vbCrLf & "RM sedang disiapkan, konfirm jika sudah diterima"

                            Dim infobox As New frmInfoboxRegReceiver(strttl, strmsg, frmInfoboxRegReceiver.MsgType.InfoIcon, sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            infobox.BringToFront()
                            infobox.TopMost = True
                            tambahChild(infobox)
                            infobox.Show()
                        End If
                    Else
                        Dim id As String = idregi.Find(Function(val As String)
                                                           Return val = sqls.getDataSet("regnull", i, "idregistrasi").ToString
                                                       End Function)
                        If id = String.Empty Then
                            sqls2 = New SQLs(dbstring)

                            idregi.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            value.Add(sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                            sqls2.CallSP("spRegistrasiSlip", "regslip", field, value)
                            If sqls2.getDataSet("regslip") > 0 Then
                                strttl = sqls2.getDataSet("regslip", 0, "regno")
                                strmsg = sqls2.getDataSet("regslip", 0, "norm") & " (" & sqls2.getDataSet("regslip", 0, "sex") & ")" & vbCrLf & sqls2.getDataSet("regslip", 0, "namapasien") & vbCrLf & sqls2.getDataSet("regslip", 0, "paramedis") & vbCrLf & sqls2.getDataSet("regslip", 0, "spesialis") & vbCrLf & "RM sedang disiapkan, konfirm jika sudah diterima"

                                Dim infobox As New frmInfoboxRegReceiver(strttl, strmsg, frmInfoboxRegReceiver.MsgType.InfoIcon, sqls.getDataSet("regnull", i, "idregistrasi").ToString)
                                infobox.BringToFront()
                                infobox.TopMost = True
                                tambahChild(infobox)
                                infobox.Show()
                            End If
                        End If
                    End If
                Next
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
    End Sub

End Class