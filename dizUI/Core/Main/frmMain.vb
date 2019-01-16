Imports System.Runtime.InteropServices
Imports System.Drawing.Drawing2D
Imports System.Reflection

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

    Private mLastState As FormWindowState
    Private Sub frmMain_ClientSizeChanged(sender As Object, e As EventArgs) Handles Me.ClientSizeChanged
        If Me.WindowState <> mLastState Then
            mLastState = Me.WindowState
            onWindowStateChanged(e)
        End If
    End Sub

    Private Sub invalidateObject(sender As Object)
        If TypeOf (sender) Is Windows.Forms.Label Then
            CType(sender, Windows.Forms.Label).Invalidate()
        ElseIf TypeOf (sender) Is Windows.Forms.PictureBox Then
            CType(sender, Windows.Forms.PictureBox).Invalidate()
        ElseIf TypeOf (sender) Is Windows.Forms.Button Then
            CType(sender, Windows.Forms.Button).Invalidate()
        ElseIf TypeOf (sender) Is Windows.Forms.Panel Then
            CType(sender, Windows.Forms.Panel).Invalidate()
        ElseIf TypeOf (sender) Is Windows.Forms.TableLayoutPanel Then
            CType(sender, Windows.Forms.TableLayoutPanel).Invalidate()
        ElseIf TypeOf (sender) Is Windows.Forms.FlowLayoutPanel Then
            CType(sender, Windows.Forms.FlowLayoutPanel).Invalidate()
        ElseIf TypeOf (sender) Is Windows.Forms.MenuStrip Then
            CType(sender, Windows.Forms.MenuStrip).Invalidate()
        ElseIf TypeOf (sender) Is Windows.Forms.LinkLabel Then
            CType(sender, Windows.Forms.LinkLabel).Invalidate()
        End If
    End Sub

    Protected Sub OnWindowStateChanged(e As EventArgs)
        Me.Update()
        tlpHeader.Update()
        pHeader.Update()
        pTitle.Update()
        tlpFooter.Update()
        pFooter.Update()

        For Each ctrl As Object In Me.Controls
            invalidateObject(ctrl)
        Next
        For Each ctrl As Object In tlpHeader.Controls
            invalidateObject(ctrl)
        Next
        For Each ctrl As Object In pHeader.Controls
            invalidateObject(ctrl)
        Next
        For Each ctrl As Object In pTitle.Controls
            invalidateObject(ctrl)
        Next
        For Each ctrl As Object In tlpFooter.Controls
            invalidateObject(ctrl)
        Next
        For Each ctrl As Object In pFooter.Controls
            invalidateObject(ctrl)
        Next
    End Sub

    Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Update()
        tlpHeader.Update()
        pHeader.Update()
        pTitle.Update()
        tlpFooter.Update()
        pFooter.Update()

        For Each ctrl As Object In Me.Controls
            invalidateObject(ctrl)
        Next
        For Each ctrl As Object In tlpHeader.Controls
            invalidateObject(ctrl)
        Next
        For Each ctrl As Object In pHeader.Controls
            invalidateObject(ctrl)
        Next
        For Each ctrl As Object In pTitle.Controls
            invalidateObject(ctrl)
        Next
        For Each ctrl As Object In tlpFooter.Controls
            invalidateObject(ctrl)
        Next
        For Each ctrl As Object In pFooter.Controls
            invalidateObject(ctrl)
        Next
    End Sub

    Dim GripDrag As Boolean
    Dim InitialSizeX As Integer
    Dim InitialSizeY As Integer

    Private Sub presize_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pResize.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then 'If the control is being left-clicked
            GripDrag = True 'Confirms the grip is ready to be dragged
            InitialSizeX = Me.Width 'Sets the initial width
            InitialSizeY = Me.Height 'Sets the initial height
        End If
    End Sub

    Private Sub presize_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pResize.MouseMove
        If GripDrag = True Then
            Me.Width = InitialSizeX + (Windows.Forms.Cursor.Position.X - (Me.Width + Me.Location.X)) 'Increases the width of the form by the amount the grip has been dragged towards the right
            Me.Height = InitialSizeY + (Windows.Forms.Cursor.Position.Y - (Me.Height + Me.Location.Y)) 'Increases the height of the form by the amount the grip has been dragged downward

            InitialSizeX = Me.Width 'Resets the value to the form's current width
            InitialSizeY = Me.Height 'Resets the value to the form's current height

            Me.Refresh()
            Application.DoEvents()
        End If
    End Sub

    Private Sub presize_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pResize.MouseUp
        GripDrag = False 'Confirms the grip is no longer being dragged
    End Sub

    Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal process As IntPtr, ByVal minimumWorkingSetSize As Integer, ByVal maximumWorkingSetSize As Integer) As Integer
    Public Sub FlushMemory()
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            If (Environment.OSVersion.Platform = PlatformID.Win32NT Or Environment.OSVersion.Platform = PlatformID.Win32S Or Environment.OSVersion.Platform = PlatformID.Win32Windows) Then
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
                Dim myProcesses As Process() = Process.GetProcessesByName(Application.ProductName)
                Dim myProcess As Process
                For Each myProcess In myProcesses
                    SetProcessWorkingSetSize(myProcess.Handle, -1, -1)
                Next myProcess
            End If
        Catch ex As Exception
            Dim err = ex.Message
        End Try
    End Sub

    Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)
        intIdle = 1

        If cntIdle >= 15 Then
            If userid <> "-1" Then
                btnLogin_Click(btnLogin, Nothing)
                FlushMemory()
            End If
        End If
    End Sub

    Public Sub resizeForm(ByVal obj As Object)
        Try
            If obj.Controls.ContainsKey("tlpForm") Then
                If obj.Controls("tlpForm").Dock = DockStyle.Fill Then
                    pForm.AutoScroll = False
                    obj.Size = pForm.Size
                Else
                    pForm.AutoScroll = True
                    centerMe()
                End If
            ElseIf obj.Controls.ContainsKey("pForm") Then
                If obj.Controls("pForm").Dock = DockStyle.Fill Then
                    pForm.AutoScroll = False
                    obj.Size = pForm.Size
                Else
                    pForm.AutoScroll = True
                    centerMe()
                End If
            End If
        Catch ex As Exception
            dizMsgbox(ex.Message, dizMsgboxStyle.Kesalahan)
        End Try
    End Sub

    Private Sub centerMe()
        If pForm.Controls.Count > 0 Then
            If TypeOf pForm.Controls(0) Is Form Then
                If pForm.Controls(0).Controls.ContainsKey("pForm") = False Then Exit Sub
                If pForm.Controls(0).Controls("pForm").Width < pForm.Width Then
                    pForm.Controls(0).Width = pForm.Width
                Else
                    pForm.Controls(0).Width = pForm.Controls(0).Controls("pForm").Width
                End If
                If pForm.Controls(0).Controls("pForm").Height < pForm.Height Then
                    pForm.Controls(0).Height = pForm.Height
                Else
                    pForm.Controls(0).Height = pForm.Controls(0).Controls("pForm").Height
                End If
                If pForm.Controls(0).Controls("pForm").Dock = DockStyle.None Then centerMe(pForm.Controls(0).Controls("pForm"))
            End If
        End If
    End Sub

    Private Sub centerMe(ByVal pnl As Object)
        pnl.visible = False
        pnl.left = (pnl.parent.width - pnl.width) / 2
        If pnl.Left < 0 Then pnl.left = 0
        pnl.top = 5 ' (pnl.parent.height - pnl.height) / 2
        pnl.visible = True
    End Sub

    Private Sub centerMe(ByVal frm As Form)
        Dim res As Double
        If pForm.Width > frm.Width Then
            res = pForm.Width - frm.Width
            frm.Left = Int(res / 2)
            If frm.Left < 0 Then frm.Left = 0
        End If
        frm.Top = 0
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If pHeader.Enabled = False Then
            e.Cancel = False
            rClose = e.CloseReason.ToString
        Else
            e.Cancel = bClose
            rClose = e.CloseReason.ToString
        End If
    End Sub

    Private intNotif As Integer = 0
    Private Sub showNotification(ByVal Icon As iconNotif, ByVal content As String)
        If Icon = iconNotif.critical Then
            pbNotification.Image = My.Resources.ico_critical
            pbNotification.BackColor = Color.Tomato
        ElseIf Icon = iconNotif.info Then
            pbNotification.Image = My.Resources.ico_info
            pbNotification.BackColor = Color.Gainsboro
        ElseIf Icon = iconNotif.warning Then
            pbNotification.Image = My.Resources.ico_warning
            pbNotification.BackColor = color.fromargb(240, 240, 240)
        End If
        lblNotification.Text = Format(nowTime, "HH:mm:ss") & " " & content
        intNotif = 5
    End Sub

    Private Sub ParseCommandLineArgs()
        Dim inputArgument As String = "/input="
        Dim inputName As String = ""

        For Each s As String In My.Application.CommandLineArgs
            If s.ToLower = "update" Then
                inputName = s.ToLower
            End If
            'If s.ToLower.StartsWith(inputArgument) Then
            '    inputName = s.Remove(0, inputArgument.Length)
            'End If
        Next

        If inputName = "" Then
            'MsgBox("No input name")
            If IO.File.Exists(Application.StartupPath & "\dizSetting20.exe") Then
                Threading.Thread.Sleep(1000)
                System.Diagnostics.Process.Start(Application.StartupPath & "\dizSetting20.exe")
                Threading.Thread.Sleep(1000)
                Environment.Exit(0)
            End If
        ElseIf inputName <> "update" Then
            dizMsgbox("Wrong Parameter", dizMsgboxStyle.Kesalahan, Me)
            Environment.Exit(0)
            'MsgBox("Input name: " & inputName)
        End If
    End Sub

    Private Sub hideTaskList(ByVal isHide As Boolean)
        If isHide = True Then
            pnlTaskList.Hide()
            pnlTaskList.Visible = False
            pnlTaskList.SendToBack()
        Else
            pnlTaskList.Show()
            pnlTaskList.Visible = True
            pnlTaskList.BringToFront()
        End If
    End Sub

    Private Sub clearTaskList(ByVal img As Collection, ByVal obj As Collection)
        If obj IsNot Nothing Then
            obj.Clear()
            img.Clear()
        End If
        tlpTaskList.Controls.Clear()
        tlpTaskList.RowStyles.Clear()

        'tlpTaskList.RowCount = 2
        'tlpTaskList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        'tlpTaskList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
    End Sub

    Private Sub btnTaskList(ByVal obj As Object, ByVal e As EventArgs)
        CType(coll_form.Item(obj.name), Windows.Forms.Form).Visible = True
        CType(coll_form.Item(obj.name), Windows.Forms.Form).WindowState = FormWindowState.Normal
        CType(coll_form.Item(obj.name), Windows.Forms.Form).BringToFront()
        CType(coll_form.Item(obj.name), Windows.Forms.Form).Show()
        hideTaskList(True)
    End Sub

    Private Sub addTaskList(ByVal obj As Collection)
        clearTaskList(Nothing, Nothing)

        tlpTaskList.RowCount = 1
        tlpTaskList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        'tlpTaskList.Size = New Size(200, (4))
        For i As Integer = 1 To obj.Count
            Dim btn As New Button
            btn.Image = coll_img.Item(i)
            btn.ImageAlign = ContentAlignment.MiddleLeft

            btn.Dock = System.Windows.Forms.DockStyle.Fill
            btn.FlatAppearance.MouseOverBackColor = Color.Gainsboro
            btn.FlatAppearance.MouseDownBackColor = Color.White
            btn.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64)
            btn.FlatAppearance.BorderSize = 1
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            btn.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular)
            btn.BackColor = Color.White
            btn.ForeColor = Color.FromArgb(64, 64, 64)
            btn.Location = New System.Drawing.Point(764, 0)
            btn.Name = obj.Item(i).name
            btn.Size = New System.Drawing.Size(42, 42)
            btn.Text = "          " & CType(obj.Item(i), Windows.Forms.Form).Text
            btn.AutoEllipsis = True

            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            btn.UseVisualStyleBackColor = False
            AddHandler btn.Click, AddressOf btnTaskList

            tlpTaskList.RowCount = tlpTaskList.RowCount + 1
            tlpTaskList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
            tlpTaskList.Controls.Add(btn, 1, tlpTaskList.RowCount - 1)
            tlpTaskList.Size = New Size(200, 8 + (42 * i))
        Next
        tlpTaskList.RowCount = tlpTaskList.RowCount + 1
        'tlpTaskList.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
    End Sub

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pTitle.Enabled = True
        pHeader.Enabled = False
        pFooter.Enabled = False
        pForm.Enabled = False
        Me.ShowInTaskbar = True

        Me.Cursor = Cursors.WaitCursor
        Dim myProcess As System.Diagnostics.Process = System.Diagnostics.Process.GetCurrentProcess()
        myProcess.PriorityClass = System.Diagnostics.ProcessPriorityClass.RealTime

        Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.SupportsTransparentBackColor, True)
        UpdateStyles()
        Me.DoubleBuffered = True

        Me.MinimumSize = New Size(900, 560)
        Me.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height)

        clearTaskList(Nothing, Nothing)
        tcTile.Groups.Clear()
        msMenu.Items.Clear()

        lblQuota.Visible = False
        setRegionalSetting()

        Me.Text = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetEntryAssembly().Location).OriginalFilename.Split(".")(0)
        lblTitle.Text = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetEntryAssembly().Location).OriginalFilename.Split(".")(0)

        If IO.Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location).Split(".")(0) <> System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetEntryAssembly().Location).OriginalFilename.Split(".")(0) Then
            Me.Cursor = Cursors.Default
            splashClosed = True
            dizMsgbox("Dilarang melakukan modifikasi terhadap aplikasi ini" & vbCrLf &
                        "Aplikasi anda rusak, silahkan install ulang aplikasi ini" & vbCrLf & "Filename error", dizMsgboxStyle.Kesalahan, Me)
            Application.Exit()
        End If

        Me.Visible = True
        Me.WindowState = FormWindowState.Maximized

        btnServer.Visible = True
        btnNote.Visible = False
        btnMemo.Visible = False
        btnMessage.Visible = False
        btnProfile.Visible = False

        btnCompList.Visible = False
        Label3.BringToFront()

        tcTile.Groups.Clear()
        tcTile.Visible = False
        tcTile.SendToBack()
        tcTile.Dock = DockStyle.None
        pForm.Visible = True
        pForm.BringToFront()
        pForm.Dock = DockStyle.Fill

        Me.Refresh()
        Application.DoEvents()

        appPath = Application.StartupPath
        appPath = CheckAndRepairValidPath(appPath)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\SIEPAM", "Path", appPath, Microsoft.Win32.RegistryValueKind.String)
        checkPath()
        If IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath) = "dizUI" Then
            If IO.File.Exists(appPath & "default_live.jpg") Then
                Me.Icon = My.Resources.dizLive1
                imgBack = Image.FromFile(appPath & "default_live.jpg")
                tcTile.BackgroundImage = imgBack
                tcTile.BackgroundImageLayout = ImageLayout.Stretch
                pForm.BackgroundImage = imgBack
                pForm.BackgroundImageLayout = ImageLayout.Stretch
            End If
        ElseIf IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath) = "dizUIdemo" Then
            If IO.File.Exists(appPath & "default_demo.jpg") Then
                Me.Icon = My.Resources.dizDemo1
                imgBack = Image.FromFile(appPath & "default_demo.jpg")
                tcTile.BackgroundImage = imgBack
                tcTile.BackgroundImageLayout = ImageLayout.Stretch
                pForm.BackgroundImage = imgBack
                pForm.BackgroundImageLayout = ImageLayout.Stretch
            End If
        End If

        Try
            splashClosed = False
            Dim spl As New frmDizSplash
            spl.Location = New Point(Me.Location.X + CInt(Me.Size.Width / 2) - CInt(spl.Size.Width / 2), Me.Location.Y + CInt(Me.Size.Height / 2) - CInt(spl.Size.Height / 2))
            spl.Show(Me)
            spl.BringToFront()
            Application.DoEvents()
        Catch
        End Try

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

        Try
            tcTile.AppearanceItem.Normal.ForeColor = Color.White
            tcTile.AppearanceItem.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!)
            tcTile.AppearanceItem.Normal.BackColor = Color.FromArgb(64, 0, 64)
            tcTile.AppearanceItem.Normal.BackColor2 = Color.Purple
            tcTile.AppearanceItem.Hovered.Font = New System.Drawing.Font("Tahoma", 12.0!)
            tcTile.AppearanceItem.Hovered.BackColor = Color.FromArgb(0, 57, 64)
            tcTile.AppearanceItem.Selected.Font = New System.Drawing.Font("Tahoma", 12.0!)
            tcTile.AppearanceItem.Selected.BackColor = Color.FromArgb(0, 57, 175)
            clearUser()

            siteonline = readSiteOnline()
            dbonline = readSettingFileOnline()
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

                    Dim stripaddress As String = getIPAddress(ipaddparam.IP)
                    idhostname = stripaddress.Replace(".", "")
                    iphostname = stripaddress
                Else
                    splashClosed = True
                    dizMsgbox("Server tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
                    Me.Cursor = Cursors.Default
                    pTitle.Enabled = True
                    pHeader.Enabled = False
                    pFooter.Enabled = False
                    pForm.Enabled = False

                    Dim dbset As New frmSettingDB
                    dbset.ShowDialog()

                    Environment.Exit(0)
                End If
            Catch ex As Exception
                splashClosed = True
                Threading.Thread.Sleep(1000)
                dizMsgbox("Server tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
                Me.Cursor = Cursors.Default
                pTitle.Enabled = True
                pHeader.Enabled = False
                pFooter.Enabled = False
                pForm.Enabled = False

                Dim dbset As New frmSettingDB
                dbset.ShowDialog()

                Environment.Exit(0)
            End Try

            If sql.getDataSet("cekwaktu") > 0 Then
                Dim tmpstr As String = sql.getDataSet("cekwaktu", 0, "tanggal")
                Dim cekdate As Date = Strdatetime2Datetime(tmpstr)
                nowTime = cekdate
            Else
                nowTime = Now
            End If

            If isServer = True Then
                'sql = New SQLs(dbonline)
                'sql.DMLQuery("select top 1 idtoken,tokenkey1,tokenkey2 from token order by createddate desc", "content")
                'If sql.getDataSet("content") > 0 Then 'IsNumeric(strvalue) = False Then 'MYs.getDataSet("token") > 0 Then
                '    tmpidtoken = sql.getDataSet("content", 0, "idtoken")
                '    'MYs.getDataSet("token", 0, "idtoken")
                '    tmptokenkey1 = sql.getDataSet("content", 0, "tokenkey1")
                '    'MYs.getDataSet("token", 0, "tokenkey1")
                '    tmptokenkey2 = sql.getDataSet("content", 0, "tokenkey2")
                '    'MYs.getDataSet("token", 0, "tokenkey2")
                'Else
                tmpidtoken = "E82EC129-868C-4FEB-9AEB-0ADB46428F1E"
                    tmptokenkey1 = "ABF"
                    tmptokenkey2 = "123"
                'End If

                tmphardwareid = getBoardID()
                tmphardwarecode = getHardwareCode(tmphardwareid, tmptokenkey1, tmptokenkey2)

                Dim sqli As New SQLi(dblite)
                sqli.DMLQuery("select value from appsetting where variable='HardwareID'", "GetHID")
                If sqli.getDataSet("GetHID", 0, "value") = "NULL" Then
                    sql.DMLQuery("select idhardware from hardware where hardwareid='" & tmphardwareid & "'", "existhw")
                    If sql.getDataSet("existhw") = 0 Then
                        dizMsgbox("Hardware tidak terdaftar", dizMsgboxStyle.Peringatan, "Peringatan", Me)
                        Dim welcome As New frmNewData
                        welcome.ShowDialog(Me)
                        Environment.Exit(0)
                    End If
                End If
                sql = New SQLs(dbstring)
                sql.DMLQuery("update sys_appsetting set value='" & Format(nowTime, "dd-MM-yyyy HH:mm:ss") & "' where variable='LastActive'", False)
                sql.DMLQuery("update sys_appsetting set value='" & thisCompanyName & "' where variable='CompanyName'", False)

                sqli = New SQLi(dblite)
                sqli.DMLQuery("select value from appsetting where variable='QuotaAmount'", "QuotaAmount")
                sqli.DMLQuery("select value from appsetting where variable='QuotaAmountCode'", "QuotaAmountCode")
                Dim qa As String = sqli.getDataSet("QuotaAmount", 0, "value")
                Dim qacode As String = sqli.getDataSet("QuotaAmountCode", 0, "value")

                sqli.DMLQuery("select value from appsetting where variable='StartActivated'", "StartActivated")
                sqli.DMLQuery("select value from appsetting where variable='StartActivatedCode'", "StartActivatedCode")
                Dim sa As String = sqli.getDataSet("StartActivated", 0, "value")
                Dim sacode As String = sqli.getDataSet("StartActivatedCode", 0, "value")
                Dim de20 As New dizEngine.engine
                If de20.processE(qa) = qacode Then
                    qtyQuota = CDec(qa)
                Else
                    Me.Cursor = Cursors.Default
                    splashClosed = True
                    dizMsgbox("Dilarang melakukan modifikasi aplikasi ini" & vbCrLf &
                        "Aplikasi anda rusak, silahkan install ulang aplikasi ini" & vbCrLf & "Activated Error", dizMsgboxStyle.Kesalahan, Me)
                    Application.Exit()
                End If
                If de20.processE(sa) = sacode Then
                    If sa = "NULL" Then
                        Me.Cursor = Cursors.Default
                        splashClosed = True
                        pTitle.Enabled = True
                        pHeader.Enabled = False
                        pFooter.Enabled = False
                        pForm.Enabled = False

                        Dim welcome As New frmNewData
                        welcome.ShowDialog(Me)

                        sqli = New SQLi(dblite)
                        sqli.DMLQuery("select value from appsetting where variable='StartActivated'", "StartActivated")
                        sqli.DMLQuery("select value from appsetting where variable='StartActivatedCode'", "StartActivatedCode")

                        sa = sqli.getDataSet("StartActivated", 0, "value")
                        sacode = sqli.getDataSet("StartActivatedCode", 0, "value")
                        de20 = New dizEngine.engine
                        If de20.processE(sa) = sacode Then
                            If sa = "NULL" Then
                                dizMsgbox("Registrasi Pengguna dan Perusahaan belum dilakukan", dizMsgboxStyle.Kesalahan, Me)
                                Application.Exit()
                            End If
                        End If
                    End If
                Else
                    Me.Cursor = Cursors.Default
                    splashClosed = True
                    dizMsgbox("Dilarang melakukan modifikasi terhadap aplikasi ini" & vbCrLf &
                        "Aplikasi anda rusak, silahkan install ulang aplikasi ini" & vbCrLf & "User Company Error", dizMsgboxStyle.Kesalahan, Me)
                    Application.Exit()
                End If
            End If

            Me.Cursor = Cursors.WaitCursor
            sql = New SQLs(dbstring)
            sql.DMLQuery("select value from sys_appsetting where variable='ProductVersion'", "cekver")
            Dim versi As String = sql.getDataSet("cekver", 0, "value")
            versi = versi.Replace(".", "")

            modCore.productversion = Application.ProductVersion
            Dim thisversi As String = modCore.productversion
            thisversi = thisversi.Replace(".", "")
            If CInt(versi) <> CInt(thisversi) Then
                ParseCommandLineArgs()
            End If

            Me.Cursor = Cursors.Default
            tmrWaktu.Start()
            bwServer.WorkerReportsProgress = True
            If isServer = True Then
                'bwServer.RunWorkerAsync()
            Else
                bwServer.CancelAsync()
            End If
            lblUserActive.Text = username & " (" & userlevel & ")"

            If isServer = True Then
                Dim lite As New SQLi(dblite)
                Dim sqls As New SQLs(dbstring)
                lite.DMLQuery("select value from appsetting where variable='CompanyCode'", "CCD")
                modCore.companycode = lite.getDataSet("CCD", 0, "value")
                sqls.DMLQuery("update sys_appsetting set value='" & modCore.companycode & "' where variable='CompanyCode'", False)

                lite.DMLQuery("select value from appsetting where variable='CompanyID'", "CID")
                modCore.idcompany = lite.getDataSet("CID", 0, "value")
                sqls.DMLQuery("update sys_appsetting set value='" & modCore.idcompany & "' where variable='CompanyID'", False)

                lite.DMLQuery("select value from appsetting where variable='CompanyName'", "CN")
                modCore.companyname = lite.getDataSet("CN", 0, "value")
                sqls.DMLQuery("update sys_appsetting set value='" & modCore.companyname & "' where variable='CompanyName'", False)

                lite.DMLQuery("select value from appsetting where variable='CompanyProductID'", "CPID")
                If IsNumeric(lite.getDataSet("CPID", 0, "value")) = True Then
                    modCore.idcompanyproduct = lite.getDataSet("CPID", 0, "value")
                End If

                lite.DMLQuery("select value from appsetting where variable='HardwareCode'", "HCD")
                modCore.hardwarecode = lite.getDataSet("HCD", 0, "value")

                lite.DMLQuery("select value from appsetting where variable='HardwareID'", "HID")
                modCore.idhardware = lite.getDataSet("HID", 0, "value")

                lite.DMLQuery("select value from appsetting where variable='ProductCode'", "PCD")
                modCore.productcode = lite.getDataSet("PCD", 0, "value")
                sqls.DMLQuery("update sys_appsetting set value='" & modCore.productcode & "' where variable='ProductCode'", False)

                lite.DMLQuery("select value from appsetting where variable='ProductName'", "PN")
                modCore.productname = lite.getDataSet("PN", 0, "value")
                sqls.DMLQuery("update sys_appsetting set value='" & modCore.productname & "' where variable='ProductName'", False)

                lite.DMLQuery("select value from appsetting where variable='ProductID'", "PID")
                modCore.idproduct = lite.getDataSet("PID", 0, "value")
                sqls.DMLQuery("update sys_appsetting set value='" & modCore.idproduct & "' where variable='ProductID'", False)

                lite.DMLQuery("select value from appsetting where variable='ProductTypeID'", "PTypeID")
                modCore.idproducttype = lite.getDataSet("PTypeID", 0, "value")
                sqls.DMLQuery("update sys_appsetting set value='" & modCore.idproducttype & "' where variable='ProductTypeID'", False)
            Else
                Dim lite As New SQLi(dblite)
                Dim sqls As New SQLs(dbstring)

                sqls.DMLQuery("select value from sys_appsetting where variable='CompanyName'", "CN")
                modCore.companyname = sqls.getDataSet("CN", 0, "value")
                lite.DMLQuery("update appsetting set value='" & CompanyName & "' where variable='CompanyName'", False)

                sqls.DMLQuery("select value from sys_appsetting where variable='ProductName'", "PN")
                modCore.productname = sqls.getDataSet("PN", 0, "value")
                lite.DMLQuery("update appsetting set value='" & ProductName & "' where variable='ProductName'", False)

                sqls.DMLQuery("select value from sys_appsetting where variable='ProductID'", "PID")
                modCore.idproduct = sqls.getDataSet("PID", 0, "value")
                lite.DMLQuery("update appsetting set value='" & idproduct & "' where variable='ProductID'", False)

                sqls.DMLQuery("select value from sys_appsetting where variable='ProductTypeID'", "PTypeID")
                modCore.idproducttype = sqls.getDataSet("PTypeID", 0, "value")
                lite.DMLQuery("update appsetting set value='" & idproducttype & "' where variable='ProductTypeID'", False)
            End If

            Me.Text = modCore.productname
            lblTitle.Text = modCore.productversion & " " & modCore.productname
            writeLog(lblTitle.Text & " start running")
            showNotification(iconNotif.info, Me.Text & " start running")

            pForm.Visible = False
            pForm.SendToBack()
            pForm.Dock = DockStyle.None
            tcTile.Groups.Clear()
            tcTile.Visible = True
            tcTile.BringToFront()
            tcTile.Dock = DockStyle.Fill
            tcTile.Focus()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            splashClosed = True
            dizMsgbox(ex.Message, dizMsgboxStyle.Kesalahan)
        End Try

        ttCtrl.SetToolTip(tcTile, Me.Text)
        Me.Cursor = Cursors.Default
        splashClosed = True

        pTitle.Enabled = True
        pHeader.Enabled = True
        pFooter.Enabled = True
        pForm.Enabled = True

        If isServer = True Then
            btnCompList.Visible = True
            Label3.BringToFront()
        End If
    End Sub

    Private isSync As Boolean = False
    Private Sub bwServer_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwServer.DoWork
        If nowTime.Second Mod 6 = 0 Then
            If isServer = True Then
                If isSync = False Then
                    isSync = True
                    Dim sqli As New SQLi(dblite)
                    Dim sqls As New SQLs(dbstring)

                    sqli.DMLQuery("select value from appsetting where variable='CompanyName'", "company")
                    sqls.DMLQuery("select value from sys_appsetting where variable='CompanyName'", "company")
                    If sqli.getDataSet("company", 0, "value") <> sqls.getDataSet("company", 0, "value") Then
                        sqls.DMLQuery("update sys_appsetting set value='" & sqli.getDataSet("company", 0, "value") & "' where variable='CompanyName'", False)
                    End If

                    sqli.DMLQuery("select value from appsetting where variable='ProductName'", "product")
                    sqls.DMLQuery("select value from sys_appsetting where variable='ProductName'", "product")
                    If sqli.getDataSet("product", 0, "value") <> sqls.getDataSet("product", 0, "value") Then
                        sqls.DMLQuery("update sys_appsetting set value='" & sqli.getDataSet("product", 0, "value") & "' where variable='ProductName'", False)
                    End If

                    sqli.DMLQuery("select value from appsetting where variable='QtyClient'", "qtyclient")
                    sqls.DMLQuery("select value from sys_appsetting where variable='QtyClient'", "qtyclient")
                    If sqli.getDataSet("qtyclient", 0, "value") <> sqls.getDataSet("qtyclient", 0, "value") Then
                        sqls.DMLQuery("update sys_appsetting set value='" & sqli.getDataSet("qtyclient", 0, "value") & "' where variable='QtyClient'", False)
                    End If

                    'server offline
                    'syncToken()
                    isSync = False

                    If bwServer.IsBusy = False Then
                        bwServer.CancelAsync()
                        bwServer.RunWorkerAsync()
                    End If
                    If bwServer.CancellationPending = True Then
                        bwServer.CancelAsync()
                        bwServer.RunWorkerAsync()
                    End If
                End If
            End If
        End If
        If nowTime.Second = 0 And nowTime.Minute Mod 3 = 0 Then
            If isServer = True Then
                Dim sqls As New SQLs(dbstring)
                sqls.DMLQuery("SELECT sum(i.rowcnt) as rowtotal FROM sysindexes AS i INNER JOIN sysobjects AS o ON i.id = o.id WHERE i.indid < 2  AND OBJECTPROPERTY(o.id, 'IsMSShipped') = 0 and o.name in (select tb.table_name from information_schema.tables tb where tb.table_type='BASE TABLE' and tb.table_name not like 'sys_%')", "rowcount")
                Dim rowtotal As Decimal = 0
                Dim rowcode As String = ""
                If sqls.getDataSet("rowcount") > 0 Then
                    rowtotal = sqls.getDataSet("rowcount", 0, "rowtotal")
                End If
                Dim lite As New SQLi(dblite)
                sqls.DMLQuery("update sys_appsetting set value='" & rowtotal & "' where variable='QuotaUsed'", False)
                lite.DMLQuery("update appsetting set value='" & rowtotal & "' where variable='QuotaUsed'", False)
                Dim dizEngine As New dizEngine.engine
                rowcode = dizEngine.processE(rowtotal)
                sqls.DMLQuery("update sys_appsetting set value='" & rowcode & "' where variable='QuotaUsedCode'", False)
                lite.DMLQuery("update appsetting set value='" & rowcode & "' where variable='QuotaUsedCode'", False)

                sqls.DMLQuery("SELECT o.name, i.rowcnt as rowtotal FROM sysindexes AS i INNER JOIN sysobjects AS o ON i.id = o.id WHERE i.rowcnt > 0 AND i.indid < 2 AND OBJECTPROPERTY(o.id, 'IsMSShipped') = 0 and o.name in (select tb.table_name from information_schema.tables tb where tb.table_type='BASE TABLE' and tb.table_name not like 'sys_%') order by o.name asc ", "rowdetailcount")

                sqls.DMLQuery("SELECT sum(i.rowcnt) as rowtotal FROM sysindexes AS i INNER JOIN sysobjects AS o ON i.id = o.id WHERE i.rowcnt > 0 AND i.indid < 2 AND OBJECTPROPERTY(o.id, 'IsMSShipped') = 0 and o.name in (select tb.table_name from information_schema.tables tb where tb.table_type='BASE TABLE' and tb.table_name not like 'sys_%')", "rowcount")
                Dim freezeTime As Date = nowTime
                Dim fs As New List(Of String)
                Dim vs As New List(Of Object)
                Try
                    'For i As Integer = 0 To sqls.getDataSet("rowdetailcount") - 1
                    '    fs.Clear()
                    '    vs.Clear()

                    '    Dim iddu As Long = -1
                    '    Dim dtmys As New dtsetSQLS(dbonline)
                    '    Dim mys As New SQLs(dbonline)

                    '    Dim tbl As String = sqls.getDataSet("rowdetailcount", i, "name")
                    '    Dim rowcnt As Decimal = CDec(sqls.getDataSet("rowdetailcount", i, "rowtotal"))
                    '    Dim rowcntcode As String = getGenerateCode(rowcnt, tokenkey1, tokenkey2, 4000, getFrom.belakang)

                    '    mys.DMLQuery("delete from alterdiaz_app.datausage where idcompanyproduct='" & idcompanyproduct & "' and tablename='" & tbl & "' and convert(varchar,postdate,105)='" & Format(freezeTime, "dd-MM-yyyy") & "'", False)
                    '    mys.DMLQuery("select iddatausage from datausage where idcompanyproduct='" & idcompanyproduct & "' and tablename='" & tbl & "' and convert(varchar,postdate,105)='" & Format(freezeTime, "dd-MM-yyyy") & "'", "getid")

                    '    If mys.getDataSet("getid") > 0 Then
                    '        fs.AddRange(New String() {"iddatausage", "idcompanyproduct", "tablename", "nominaldata", "idtoken", "tokenkey1", "tokenkey2", "nominaldatacode", "isdeleted", "deletereason", "remarks", "postdate", "updateddate"})

                    '        iddu = CLng(sqls.getDataSet("getid", 0, "iddatausage"))
                    '    Else
                    '        fs.AddRange(New String() {"iddatausage", "idcompanyproduct", "tablename", "nominaldata", "idtoken", "tokenkey1", "tokenkey2", "nominaldatacode", "isdeleted", "deletereason", "remarks", "postdate", "createddate"})
                    '    End If

                    '    vs.AddRange(New Object() {iddu, idcompanyproduct, tbl, rowcnt, idtoken, tokenkey1, tokenkey2, rowcntcode, 0, "", "", freezeTime, freezeTime})
                    '    dtmys.datasetSave("datausage", iddu, fs, vs, False)
                    'Next
                    fs.Clear()
                    vs.Clear()

                    Dim iddu As String = "-1"
                    Dim dtmys As New dtsetSQLS(dbonline)
                    Dim mys As New SQLs(dbonline)

                    Dim rowcnt As Decimal = CDec(sqls.getDataSet("rowcount", 0, "rowtotal"))
                    Dim rowcntcode As String = getGenerateCode(rowcnt, tokenkey1, tokenkey2, 4000, getFrom.belakang)

                    'mys.DMLQuery("delete from alterdiaz_app.dailyusage where idcompanyproduct='" & idcompanyproduct & "' and convert(varchar,postdate,105)='" & Format(freezeTime, "dd-MM-yyyy") & "'", False)
                    'mys.DMLQuery("select iddailyusage from alterdiaz_app.dailyusage where idcompanyproduct='" & idcompanyproduct & "' and convert(varchar,postdate,105)='" & Format(freezeTime, "dd-MM-yyyy") & "'", "getid")

                    'If mys.getDataSet("getid") > 0 Then
                    '    fs.AddRange(New String() {"iddailyusage", "idcompanyproduct", "nominaldata", "idtoken", "tokenkey1", "tokenkey2", "nominaldatacode", "isdeleted", "deletereason", "remarks", "postdate", "updateddate"})

                    '    iddu = CStr(sqls.getDataSet("getid", 0, "iddailyusage"))
                    'Else
                    '    fs.AddRange(New String() {"iddailyusage", "idcompanyproduct", "nominaldata", "idtoken", "tokenkey1", "tokenkey2", "nominaldatacode", "isdeleted", "deletereason", "remarks", "postdate", "createddate"})
                    'End If

                    'vs.AddRange(New Object() {iddu, idcompanyproduct, rowcnt, idtoken, tokenkey1, tokenkey2, rowcntcode, 0, "", "", freezeTime, freezeTime})
                    'dtmys.datasetSave("dailyusage", iddu, fs, vs, False)

                    Dim MYs2 = New SQLs(dbonline)
                    'sqls.DMLQuery("select convert(decimal(20,0),VALUE) as used from sys_appsetting where variable='QuotaUsed'", "qu")
                    'MYs2.DMLQuery("update companyproduct set quotaused='" & sqls.getDataSet("qu", 0, "used") & "' where idcompanyproduct='" & idcompanyproduct & "'", False)

                    If bwServer.IsBusy = False Then
                        bwServer.CancelAsync()
                        bwServer.RunWorkerAsync()
                    End If
                    If bwServer.CancellationPending = True Then
                        bwServer.CancelAsync()
                        bwServer.RunWorkerAsync()
                    End If
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub syncToken()
        isSync = True
        Dim mystring As String = ""
        Dim mydb As String = ""
        Dim mysvr As String = ""
        Dim myport As String = "0"
        Dim myusr As String = ""
        Dim mypass As String = ""

        Dim lite As New SQLi(dblite)
        lite.DMLQuery("select databasename || '|' || ipserver || '|' || port || '|' || username || '|' || password as dbstring from dbconn where dbtype='SQLS' and dblocation='DOMAIN'", "getdbstring")
        If lite.getDataSet("getdbstring") > 0 Then
            mystring = lite.getDataSet("getdbstring", 0, "dbstring")

            lite.DMLQuery("select databasename,ipserver,port,username,password from dbconn where dbtype='SQLS' and dblocation='DOMAIN'", "getdbseparate")

            mydb = lite.getDataSet("getdbseparate", 0, "databasename")
            mysvr = lite.getDataSet("getdbseparate", 0, "ipserver")
            myport = lite.getDataSet("getdbseparate", 0, "port")
            myusr = lite.getDataSet("getdbseparate", 0, "username")
            mypass = lite.getDataSet("getdbseparate", 0, "password")
        End If

        Dim mys As New SQLs(mystring)
        Dim sqlset As New dtsetSQLS(dbstring)

        Dim sqls As New SQLs(dbstring)
        Dim localcnt As Integer = 0
        Dim servercnt As Integer = 0
        sqls.DMLQuery("select idtoken,idtokenonline,tokenkey1,tokenkey2,isdeleted,deletereason from sys_token order by createddate asc", "cnt")
        mys.DMLQuery("select idtoken,tokenkey1,tokenkey2,isdeleted,deletereason from " & mydb & "." & myusr & ".token order by createddate asc", "cnt")
        If sqls.getDataSet("cnt") > 0 Then
            localcnt = sqls.getDataSet("cnt")
        End If
        If mys.getDataSet("cnt") > 0 Then
            servercnt = CInt(mys.getDataSet("cnt"))
        End If
        If localcnt <> servercnt Then
            For i As Integer = 0 To mys.getDataSet("cnt") - 1
                Dim stridtoken As String = mys.getDataSet("cnt", i, "idtoken")
                Dim strtokenkey1 As String = mys.getDataSet("cnt", i, "tokenkey1")
                Dim strtokenkey2 As String = mys.getDataSet("cnt", i, "tokenkey2")
                Dim strisdeleted As String = mys.getDataSet("cnt", i, "isdeleted")
                Dim strdeletereason As String = mys.getDataSet("cnt", i, "deletereason")
                Dim strcreatedby As String = mys.getDataSet("cnt", i, "createdby")
                Dim strcreateddate As String = mys.getDataSet("cnt", i, "created")
                Dim dtcreateddate As Date = Strdatetime2Datetime(strcreateddate)

                Dim field As New List(Of String)
                Dim value As New List(Of Object)

                field.AddRange(New String() {"idtoken", "tokenkey1", "tokenkey2", "isdeleted", "deletereason", "createdby", "createddate"})
                value.Add(stridtoken) 'MYs.getDataSet("cnt", i, "idtoken"))
                value.Add(strtokenkey1) 'MYs.getDataSet("cnt", i, "tokenkey1"))
                value.Add(strtokenkey2) 'MYs.getDataSet("cnt", i, "tokenkey2"))
                value.Add(strisdeleted) 'MYs.getDataSet("cnt", i, "isdeleted"))
                value.Add(strdeletereason) 'MYs.getDataSet("cnt", i, "deletereason"))
                value.Add(1)
                value.Add(nowTime)
                sqlset.datasetSave("sys_token", idData, field, value, False)
                Application.DoEvents()
                'Threading.Thread.Sleep(100)
                'lblLoad.Text = "TOKEN (" & i & "/" & servercnt & ")"
                If i = servercnt - 1 Then
                    Dim sqli As New SQLi(dblite)
                    sqli.DMLQuery("update appsetting set value='" & stridtoken & "' where variable='TokenID'", False) 'MYs.getDataSet("cnt", i, "idtoken") 
                    sqli.DMLQuery("update appsetting set value='" & strtokenkey1 & "' where variable='TokenKey1'", False) 'MYs.getDataSet("cnt", i, "tokenkey1")
                    sqli.DMLQuery("update appsetting set value='" & strtokenkey2 & "' where variable='TokenKey2'", False) 'MYs.getDataSet("cnt", i, "tokenkey2")

                    idtoken = stridtoken 'MYs.getDataSet("cnt", i, "idtoken")
                    tokenkey1 = strtokenkey1 'MYs.getDataSet("cnt", i, "tokenkey1")
                    tokenkey2 = strtokenkey2 'MYs.getDataSet("cnt", i, "tokenkey2")
                End If
            Next
        End If
        isSync = False
    End Sub

    Dim imgBack As Image
    Dim objLogin As Object
    Dim it As DevExpress.XtraEditors.TileItem
    Private Sub createMenu(Optional ByVal idParent As String = "", Optional ByVal menuObj As Object = Nothing, Optional ByVal menuGroup As Object = Nothing)
        Dim strSistem As String = "Sistem"
        Dim sqls As New SQLs(dbstring)
        Dim idP As String = ""
        If idParent = "" Then
            sqls.DMLQuery("select m.idmenu,m.idparent,m.idiconmenu,m.menuname,m.frmname,m.description,right(replace(replace(g.filename,'\',''),':',''),22) as fakename,m.asdialog from sys_menu m left join sys_iconmenu g on g.idiconmenu=m.idiconmenu where (m.idproducttype='0' or m.idproducttype='" & idproducttype & "') and m.menuname='" & strSistem & "' order by m.menuname asc", "sistem")
            idP = sqls.getDataSet("sistem", 0, "idmenu")
        Else
            idP = idParent
        End If
        If idParent = "" Then
            If userlevel = "SuperAdmin" Or userlevel = "Guest" Or userlevel = "Administrator" Then
                sqls.DMLQuery("select m.idmenu,m.idparent,m.idiconmenu,m.menuname,m.frmname,m.description,right(replace(replace(g.filename,'\',''),':',''),22) as fakename,m.asdialog from sys_menu m left join sys_iconmenu g on g.idiconmenu=m.idiconmenu where (m.idproducttype='0' or m.idproducttype='" & idproducttype & "') and m.idparent='0' order by m.menuname asc", "menu")
            Else
                sqls.DMLQuery("select m.idmenu,m.idparent,m.idiconmenu,m.menuname,m.frmname,m.description,right(replace(replace(g.filename,'\',''),':',''),22) as fakename,m.asdialog from sys_menu m left join sys_iconmenu g on g.idiconmenu=m.idiconmenu left join sys_userpermission sup on m.idmenu=sup.idmenu where (m.idproducttype='0' or m.idproducttype='" & idproducttype & "') and m.idparent='0' and sup.iduserlevel='" & userlevelid & "' and sup.isactive=1 order by m.menuname asc", "menu")
            End If
        Else
            If userlevel = "SuperAdmin" Or userlevel = "Guest" Or userlevel = "Administrator" Then
                sqls.DMLQuery("select m.idmenu,m.idparent,m.idiconmenu,m.menuname,m.frmname,m.description,right(replace(replace(g.filename,'\',''),':',''),22) as fakename,m.asdialog from sys_menu m left join sys_iconmenu g on g.idiconmenu=m.idiconmenu where (m.idproducttype='0' or m.idproducttype='" & idproducttype & "') and m.idparent='" & idP & "' order by len(m.menuname) asc,m.menuname asc", "menu")
            Else
                sqls.DMLQuery("select m.idmenu,m.idparent,m.idiconmenu,m.menuname,m.frmname,m.description,right(replace(replace(g.filename,'\',''),':',''),22) as fakename,m.asdialog from sys_menu m left join sys_iconmenu g on g.idiconmenu=m.idiconmenu left join sys_userpermission sup on m.idmenu=sup.idmenu where (m.idproducttype='0' or m.idproducttype='" & idproducttype & "') and m.idparent='" & idP & "' and sup.iduserlevel='" & userlevelid & "' and sup.isactive=1 order by len(m.menuname) asc,m.menuname asc", "menu")
            End If
        End If
        Dim menux As ToolStripMenuItem
        Dim ig As DevExpress.XtraEditors.TileGroup = Nothing
        Dim cnt As Long = 1
        For Each dr As DataRow In sqls.dataTable("menu").Rows
            Dim img As Image = Image.FromFile(pathIcon & dr("fakename"))
            menux = New ToolStripMenuItem("", img, AddressOf MenuClick)
            menux.ImageScaling = ToolStripItemImageScaling.SizeToFit
            menux.ImageAlign = ContentAlignment.MiddleCenter
            menux.Font = New System.Drawing.Font("Tahoma", 12.0!)
            menux.Text = dr("menuname").ToString  'dsete.Tables(0).Rows(i).Item("caption").ToString
            menux.Name = dr("idmenu").ToString 'dsete.Tables(0).Rows(i).Item("nm_menu").ToString
            menux.AccessibleDescription = dr("asdialog").ToString

            If TypeOf menuGroup Is DevExpress.XtraEditors.TileControl Then
                ig = New DevExpress.XtraEditors.TileGroup
                ig.Text = dr("menuname").ToString  'dsete.Tables(0).Rows(i).Item("caption").ToString
                ig.Name = dr("idmenu").ToString 'dsete.Tables(0).Rows(i).Item("nm_menu").ToString
                ig.Tag = dr("asdialog").ToString

                CType(menuGroup, DevExpress.XtraEditors.TileControl).Groups.Add(ig)
            ElseIf TypeOf menuGroup Is DevExpress.XtraEditors.TileGroup Then
                it = New DevExpress.XtraEditors.TileItem
                it.TextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always

                it.Image = img
                it.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight
                it.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale
                it.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.None

                If dr("menuname").ToString.Length > 10 Then
                    it.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
                    it.BackgroundImage = My.Resources.tileLarge
                    it.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
                    it.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
                Else
                    it.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
                    it.BackgroundImage = My.Resources.tileSmall
                    it.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
                    it.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
                End If
                Dim elementDescription As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
                elementDescription.Text = dr("menuname").ToString
                elementDescription.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft

                it.AppearanceItem.Normal.Font = New System.Drawing.Font("Tahoma", 11.0!, FontStyle.Regular)
                it.AppearanceItem.Normal.ForeColor = Color.FromArgb(66, 66, 66)
                it.AppearanceItem.Normal.BorderColor = Color.OrangeRed
                it.AppearanceItem.Normal.Options.UseFont = True
                it.AppearanceItem.Normal.Options.UseBorderColor = True
                it.AppearanceItem.Normal.Options.UseBackColor = True
                it.AppearanceItem.Normal.Options.UseForeColor = True
                it.AppearanceItem.Normal.Options.UseTextOptions = True

                it.AppearanceItem.Hovered.Font = New System.Drawing.Font("Tahoma", 11.0!, FontStyle.Bold)
                it.AppearanceItem.Hovered.Options.UseFont = True
                it.AppearanceItem.Hovered.Options.UseBorderColor = True
                it.AppearanceItem.Hovered.Options.UseBackColor = True
                it.AppearanceItem.Hovered.Options.UseForeColor = True
                it.AppearanceItem.Hovered.Options.UseTextOptions = True

                it.AppearanceItem.Hovered.BackColor = Color.FromArgb(255, 255, 255)
                it.AppearanceItem.Hovered.ForeColor = Color.OrangeRed
                it.AppearanceItem.Hovered.BorderColor = Color.Purple

                it.Text = dr("menuname").ToString  'dsete.Tables(0).Rows(i).Item("caption").ToString
                it.Id = cnt
                it.Name = dr("idmenu").ToString 'dsete.Tables(0).Rows(i).Item("nm_menu").ToString
                it.Tag = dr("frmname").ToString & "~" & dr("asdialog").ToString
                it.Elements.Add(elementDescription)
                it.TextShowMode = DevExpress.XtraEditors.TileItemContentShowMode.Always

                CType(menuGroup, DevExpress.XtraEditors.TileGroup).Items.Add(it)
            End If

            If TypeOf menuObj Is MenuStrip Then
                'menuObj.renderer = New MyRenderer()
                menux.Owner = menuObj
                menux.Tag = "-"
            Else
                menuObj.DropDownItems.Add(menux)
                menux.Tag = dr("frmname").ToString 'dsete.Tables(0).Rows(i).Item("call_form").ToString
            End If
            createMenu(menux.Name, menux, ig)
            cnt += 1
        Next
    End Sub

    Private Sub MenuClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If sender.tag <> "-" Then
                hideTaskList(True)
                If sender.AccessibleDescription = 1 Then
                    formTitle = ""
                    TampilkanForm(sender.image, sender.tag, False)
                Else
                    formTitle = sender.text
                    TampilkanForm(sender.image, sender.tag, True)
                End If
            End If
        Catch ex As NullReferenceException
            'MsgBox(ex.Message)
        End Try
    End Sub

    'Private errStat As Boolean = False
    Private coll_form As New Collection
    Private coll_img As New Collection

    Private Sub TampilkanForm(ByVal img As Image, ByVal namaForm As String, ByVal fromFrmMain As Boolean)
        GC.Collect()
        If fromFrmMain = True Then
            'ClearForm(pForm)
        End If

        Dim myasm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim nsud As Form
        Try
            'nsud = myasm.CreateInstance(myasm.GetName.Name.Replace(" ", "_") & "." & namaForm)
            nsud = myasm.CreateInstance(GetType(frmMain).Namespace.Replace(" ", "_") & "." & namaForm)
            If coll_form.Contains(nsud.Name.ToString) = True Then
                CType(coll_form.Item(nsud.Name.ToString), Windows.Forms.Form).WindowState = FormWindowState.Maximized
                CType(coll_form.Item(nsud.Name.ToString), Windows.Forms.Form).BringToFront()
                CType(coll_form.Item(nsud.Name.ToString), Windows.Forms.Form).Show()
                Exit Sub
            End If

            'If DateDiff(DateInterval.Second, My.Settings.LastAccess, nowTime) < 0 Then
            '    If errStat = False Then
            '        dizmsgbox("Akses data terakhir pada " & Format(My.Settings.LastAccess, shortDateFormat) & vbCrLf & _
            '        "Untuk keamanan data, aplikasi ini tidak bisa dijalankan", dizMsgboxStyle.Kesalahan, me)
            '    End If
            '    errStat = True
            '    appStatus = appStat.close
            '    Environment.Exit(0)
            '    Exit Sub
            'End If

            fromMain = fromFrmMain
            If fromMain = True Then
                nsud.TopLevel = False
                nsud.Location = New Point(0, 0)
                AddHandler nsud.Disposed, AddressOf Form_Disposed

                pForm.AutoScroll = False
                'nsud.Size = New Size(pForm.Size.Width, pForm.Size.Height)
                nsud.Size = New Size(790, 400)
                nsud.WindowState = FormWindowState.Maximized

                'pForm.BringToFront()
                pForm.Dock = DockStyle.Fill
                pForm.Visible = True
                pForm.BringToFront()
                pForm.Focus()
                pForm.Controls.Add(nsud)
                nsud.Show()
                coll_img.Add(img, nsud.Name.ToString)
                coll_form.Add(nsud, nsud.Name.ToString)
                addTaskList(coll_form)

                tcTile.Dock = DockStyle.None
                tcTile.Visible = False
                tcTile.SendToBack()
            Else
                Dim res As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
                nsud.Icon = CType(res.GetObject("$this.Icon"), System.Drawing.Icon)
                nsud.ShowInTaskbar = False
                nsud.StartPosition = FormStartPosition.CenterScreen
                nsud.ShowDialog()
            End If
        Catch ex As Exception
            dizMsgbox("Menu tidak tersedia atau Aplikasi masih menggunakan versi lama", dizMsgboxStyle.Peringatan)
            ClearForm(pForm)
        End Try
    End Sub

    Public Sub Form_Disposed(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            coll_img.Remove(CType(sender, Windows.Forms.Form).Name)
            coll_form.Remove(CType(sender, Windows.Forms.Form).Name)
            addTaskList(coll_form)
            If coll_form.Count = 0 Then
                tcTile.Dock = DockStyle.Fill
                tcTile.Visible = True
                tcTile.BringToFront()
                tcTile.Focus()
                gcSearch.Visible = True
                gcSearch.BringToFront()
                pForm.Dock = DockStyle.None
                pForm.Visible = False
                pForm.SendToBack()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ClearForm(ByVal pform As Panel)
        tcTile.Dock = DockStyle.Fill
        tcTile.Visible = True
        tcTile.BringToFront()
        tcTile.Focus()
        gcSearch.Visible = True
        gcSearch.BringToFront()
        pform.Dock = DockStyle.None
        pform.Visible = False
        pform.SendToBack()

        pform.Controls.Clear()
    End Sub

    Private cntIdle As Integer = 0
    Private intIdle As Integer = 0
    Private Sub tmrWaktu_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrWaktu.Tick
        Try
            nowTime = nowTime.AddSeconds(1)
            If isServer = True Then
                If nowTime.Minute Mod 10 = 0 Then
                    nowTime = Now
                    Dim idsetting As String = ""
                    Dim sqls As New dtsetSQLS(dbstring)
                    Dim field As New List(Of String)
                    Dim value As New List(Of Object)
                    sqls.DMLQuery("select value,idappsetting from sys_appsetting where variable='LastActive'", "lastcheck")
                    idsetting = sqls.getDataSetValue("lastcheck", 0, 1)

                    field.AddRange(New String() {"idappsetting", "value"})
                    value.AddRange(New Object() {idsetting, Format(nowTime, "dd-MM-yyyy HH:mm:ss")})
                    sqls = New dtsetSQLS(dbstring)
                    sqls.datasetSave("sys_appsetting", idsetting, field, value, False)
                End If
            End If
            If statLogin = True Then
                If nowTime.Minute Mod 10 = 0 And nowTime.Second = 0 Then
                    Dim mys As New SQLs(dbstring)
                    mys.DMLQuery("select getdate() as tanggal", "cekwaktu")
                    If mys.getDataSet("cekwaktu") > 0 Then
                        nowTime = CDate(mys.getDataSet("cekwaktu", 0, "tanggal"))
                    Else
                        nowTime = Now
                    End If
                End If
                If nowTime.Second Mod 10 = 0 Then
                    'Dim sqls As New SQLs(dbstring)
                    'sqls.DMLQuery("select value from sys_appsetting where variable='LastActive'", "cekval")
                    'If sqls.getDataSet("cekval") = 0 Then
                    '    writeLog("Aplikasi Server tidak berjalan")
                    '    showNotification(iconNotif.critical, "Aplikasi Server tidak berjalan")
                    '    btnLogin_Click(btnLogin, Nothing)
                    'Else
                    '    Dim tmpstr As String = sqls.getDataSet("cekval", 0, 0)
                    '    Dim cekdate As Date = Strdatetime2Datetime(tmpstr)
                    '    If DateDiff(DateInterval.Second, cekdate, nowTime) > timeoutApps Then
                    '        writeLog("Aplikasi Server tidak berjalan")
                    '        showNotification(iconNotif.critical, "Aplikasi Server tidak berjalan")
                    '        btnLogin_Click(btnLogin, Nothing)
                    '    End If
                    'End If
                End If
                If nowTime.Second Mod 5 = 0 Then
                    Dim sqls As New SQLs(dbstring)
                    sqls.DMLQuery("select ipclient from sys_user where iduser='" & userid & "'", "cekuser")
                    If sqls.getDataSet("cekuser") > 0 Then
                        If sqls.getDataSet("cekuser", 0, 0) <> getIPAddress(ipaddparam.IP) Then
                            writeLog("Pengguna " & username & " sedang menggunakan komputer lain")
                            showNotification(iconNotif.critical, "Pengguna " & username & " sedang menggunakan komputer lain")
                            btnLogin_Click(btnLogin, Nothing)
                        End If
                        'ElseIf sqls.getDataSet("cekuser") = 0 Then
                        '    writeLog("Pengguna tidak dapat masuk")
                        '    showNotification(iconNotif.critical, "Pengguna tidak dapat masuk")
                        '    btnLogin_Click(btnLogin, Nothing)
                    End If
                End If
                If nowTime.Second Mod 3 = 0 Then
                    Dim sqls As New SQLs(dbstring)
                    sqls.DMLQuery("update sys_user set waktucek=getdate() where iduser='" & userid & "'", False)
                End If

                If IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath) = "dizUI" Then
                    Dim bcek As Boolean = False
                    For Each p As Process In Process.GetProcessesByName("dizui")
                        If p.ProcessName.ToString.ToLower = "dizui" Then
                            bcek = True
                            Exit For
                        End If
                    Next
                    If bcek = True Then
                        If IO.File.Exists(appPath & "dizNotifikasi.exe") = True Then
                            Dim bcek1 As Boolean = False
                            For Each p As Process In Process.GetProcessesByName("diznotifikasi")
                                If p.ProcessName.ToString.ToLower = "diznotifikasi" Then
                                    bcek1 = True
                                End If
                            Next
                            If bcek1 = False Then
                                Process.Start(appPath & "dizNotifikasi.exe")
                            End If
                        End If
                    End If
                End If
            End If
            If nowTime.Second Mod 5 = 0 Then
                Dim sqls As New SQLs(dbstring)
                sqls.DMLQuery("select (select convert(decimal(20,0),VALUE) as amount from sys_appsetting where variable='QuotaAmount') - (select convert(decimal(20,0),VALUE) as used from sys_appsetting where variable='QuotaUsed') as quota", "cekquota")
                qtyQuota = CDec(sqls.getDataSet("cekquota", 0, "quota"))
                If qtyQuota <= CDec(500) Then
                    lblQuota.Text = "Kuota Tersisa: " & qtyQuota
                    lblQuota.Visible = True

                    If qtyQuota <= 0 Then
                        isQuotaValid = False
                    Else
                        isQuotaValid = True
                    End If
                Else
                    lblQuota.Visible = False
                    isQuotaValid = True
                End If
            End If
            If nowTime.Second = 4 Or nowTime.Second = 9 Or nowTime.Second = 14 Or nowTime.Second = 19 Or nowTime.Second = 24 Or nowTime.Second = 29 Or nowTime.Second = 34 Or nowTime.Second = 39 Or nowTime.Second = 44 Or nowTime.Second = 49 Or nowTime.Second = 54 Or nowTime.Second = 59 Then
                If isServer = True Then
                    If isQuotaValid = True Then
                        Dim idsetting As String = ""
                        Dim sqls As New dtsetSQLS(dbstring)
                        Dim field As New List(Of String)
                        Dim value As New List(Of Object)
                        sqls.DMLQuery("select value,idappsetting from sys_appsetting where variable='LastActive'", "lastcheck")
                        idsetting = sqls.getDataSetValue("lastcheck", 0, 1)

                        field.AddRange(New String() {"idappsetting", "value"})
                        value.AddRange(New Object() {idsetting, Format(nowTime, "dd-MM-yyyy HH:mm:ss")})
                        sqls = New dtsetSQLS(dbstring)
                        sqls.datasetSave("sys_appsetting", idsetting, field, value, False)
                    End If
                End If
            End If

            intNotif -= 1
            If intNotif <= 0 Then
                pbNotification.Image = Nothing
                pbNotification.BackColor = Color.Transparent 'FromArgb(0, 57, 64)
                'lblNotification.Text = ""
                lblNotification.Text = NamaHari(nowTime.DayOfWeek) & Format(nowTime, ", dd ") & NamaBulan(nowTime.Month) & Format(nowTime, " yyyy | HH:mm:ss")
                lblNotification.Refresh()
                Application.DoEvents()
            End If

            'gantinya backgroundworker
            cntIdle += intIdle
        Catch ex As Exception
            dizMsgbox(ex.Message, dizMsgboxStyle.Kesalahan)
        End Try
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        initiate()

        ' Add any initialization after the InitializeComponent() call.
        'SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        'SetStyle(ControlStyles.ResizeRedraw, True)
        'SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        'SetStyle(ControlStyles.Opaque, False)
        'SetStyle(ControlStyles.DoubleBuffer, True)
        'SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        'SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.SupportsTransparentBackColor, True)
        UpdateStyles()
        Me.DoubleBuffered = True
        Me.Invalidate(True)
        mLastState = Me.WindowState

        If IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath) = "dizUI" Then
            If IO.File.Exists(appPath & "default_live.jpg") Then
                imgBack = Image.FromFile(appPath & "default_live.jpg")
                tcTile.BackgroundImage = imgBack
                tcTile.BackgroundImageLayout = ImageLayout.Stretch
                pForm.BackgroundImage = imgBack
                pForm.BackgroundImageLayout = ImageLayout.Stretch
            End If
        ElseIf IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath) = "dizUIdemo" Then
            If IO.File.Exists(appPath & "default_demo.jpg") Then
                imgBack = Image.FromFile(appPath & "default_demo.jpg")
                tcTile.BackgroundImage = imgBack
                tcTile.BackgroundImageLayout = ImageLayout.Stretch
                pForm.BackgroundImage = imgBack
                pForm.BackgroundImageLayout = ImageLayout.Stretch
            End If
        End If
    End Sub

    Private Sub initiate()
        For Each ctrl As Control In pTitle.Controls
            If TypeOf ctrl Is Button Then
                If CType(ctrl, System.Windows.Forms.Button).Tag = "exit" Then
                    CType(ctrl, System.Windows.Forms.Button).FlatAppearance.MouseDownBackColor = AppsXDown
                    CType(ctrl, System.Windows.Forms.Button).FlatAppearance.MouseOverBackColor = AppsXHover
                    CType(ctrl, System.Windows.Forms.Button).BackColor = AppsXNormal
                ElseIf CType(ctrl, System.Windows.Forms.Button).Tag = "special" Then
                    CType(ctrl, System.Windows.Forms.Button).FlatAppearance.MouseDownBackColor = AppsButtonSpDown
                    CType(ctrl, System.Windows.Forms.Button).FlatAppearance.MouseOverBackColor = AppsButtonSpHover
                    CType(ctrl, System.Windows.Forms.Button).BackColor = AppsButtonSpNormal
                ElseIf CType(ctrl, System.Windows.Forms.Button).Tag = "" Then
                    CType(ctrl, System.Windows.Forms.Button).FlatAppearance.MouseDownBackColor = AppsButtonDown
                    CType(ctrl, System.Windows.Forms.Button).FlatAppearance.MouseOverBackColor = AppsButtonHover
                    CType(ctrl, System.Windows.Forms.Button).BackColor = AppsButtonNormal
                End If
            End If
        Next
    End Sub

    Private Sub clearUser()
        userid = -1
        userlevelid = -1
        userlevel = "Guest"
        username = "guest"
        usersuper = 0
        userdata = 0
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        hideTaskList(True)
        If userid = "-1" Then
            Dim login As New frmLogin
            login.Location = New Point(Me.Location.X + CInt(Me.Size.Width / 2) - CInt(login.Size.Width / 2), Me.Location.Y + CInt(Me.Size.Height / 2) - CInt(login.Size.Height / 2))
            login.ShowDialog()

            If statLogin = True Then
                clearchild()
                coll_form.Clear()
                coll_img.Clear()
                clearTaskList(Nothing, Nothing)

                msMenu.Items.Clear()
                tcTile.Groups.Clear()
                createMenu("", msMenu, tcTile)

                sender.text = "Logout"
                lblUserActive.Text = username & " (" & userlevel & ")"

                btnServer.Visible = True
                btnNote.Visible = True
                btnMemo.Visible = True
                btnMessage.Visible = True
                btnProfile.Visible = True
                btnServer.SendToBack()
                btnNote.SendToBack()
                btnMemo.SendToBack()
                btnMessage.SendToBack()
                btnProfile.SendToBack()

                If tcTile.Visible = True Then
                    If tcTile.Groups.Count = 0 Then
                        gcSearch.Visible = False
                        gcSearch.SendToBack()
                        teSearch.Text = ""
                    Else
                        gcSearch.Visible = True
                        gcSearch.BringToFront()
                        teSearch.Text = ""
                    End If
                Else
                    gcSearch.Visible = False
                    gcSearch.SendToBack()
                    teSearch.Text = ""
                End If
            Else
                clearchild()
                coll_form.Clear()
                coll_img.Clear()
                clearTaskList(Nothing, Nothing)

                msMenu.Items.Clear()
                tcTile.Groups.Clear()
                ClearForm(pForm)
                clearUser()
                sender.text = "Login"
                lblUserActive.Text = username & " (" & userlevel & ")"

                btnServer.Visible = True
                btnNote.Visible = False
                btnMemo.Visible = False
                btnMessage.Visible = False
                btnProfile.Visible = False

                gcSearch.Visible = False
                gcSearch.SendToBack()
                teSearch.Text = ""
            End If
        Else
            clearchild()
            coll_form.Clear()
            coll_img.Clear()
            clearTaskList(Nothing, Nothing)
            statLogin = False
            msMenu.Items.Clear()
            tcTile.Groups.Clear()
            ClearForm(pForm)
            clearUser()
            sender.text = "Login"
            lblUserActive.Text = username & " (" & userlevel & ")"
            'pCompList.Visible = False
            'Label3.BringToFront()

            FlushMemory()

            btnServer.Visible = True
            btnNote.Visible = False
            btnMemo.Visible = False
            btnMessage.Visible = False
            btnProfile.Visible = False

            gcSearch.Visible = False
            gcSearch.SendToBack()
            teSearch.Text = ""
        End If
    End Sub

    Private Sub pForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles pForm.Resize
        Try
            If pForm.Controls.Count > 0 Then
                For Each ctrl As Control In pForm.Controls
                    Dim obj As Object = ctrl
                    If CType(obj, Windows.Forms.Form).WindowState = FormWindowState.Maximized Then
                        pForm.AutoScroll = False
                        obj.WindowState = FormWindowState.Minimized
                        'obj.Size = New Size(pForm.Size.Width, pForm.Size.Height)
                        obj.WindowState = FormWindowState.Maximized
                        pForm.Refresh()
                        pForm.Invalidate()
                    End If
                Next
            End If
        Catch ex As Exception
            dizMsgbox(ex.Message, dizMsgboxStyle.Kesalahan)
        End Try
    End Sub

    Private Sub tcTile_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tcTile.GotFocus
        If tcTile.Groups.Count = 0 Then
            btnLogin.Focus()
        End If
    End Sub

    Private Sub tcTile_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.TileItemEventArgs) Handles tcTile.ItemClick
        If e.Item.Tag.ToString.Split("~")(0) <> "-" Then
            hideTaskList(True)
            If CInt(e.Item.Tag.ToString.Split("~")(1)) = 1 Then
                formTitle = ""
                TampilkanForm(e.Item.Image, e.Item.Tag.ToString.Split("~")(0), False)
            Else
                formTitle = e.Item.Text
                TampilkanForm(e.Item.Image, e.Item.Tag.ToString.Split("~")(0), True)
            End If
        End If
    End Sub

    Private Sub lblQuota_VisibleChanged(sender As Object, e As EventArgs) Handles lblQuota.VisibleChanged
        If lblQuota.Visible = False Then
            lblQuota.SendToBack()
        Else
            lblQuota.BringToFront()
        End If
    End Sub

    Private Sub bwServer_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwServer.ProgressChanged

    End Sub

    Private Sub bwServer_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwServer.RunWorkerCompleted
        If bwServer.IsBusy = False Then
            bwServer.RunWorkerAsync()
        End If
        If bwServer.CancellationPending = True Then
            bwServer.RunWorkerAsync()
        End If
    End Sub

    Private Sub btnAppBorder_Click(sender As Object, e As EventArgs) Handles btnAppBorder.Click
        If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            btnAppBorder.Image = My.Resources.bordernon_n
            btnAppBorder.Invalidate()
        Else
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            btnAppBorder.Image = My.Resources.bordersingle_n
            btnAppBorder.Invalidate()
        End If
        If pForm.Controls.Count > 0 Then
            Dim obj As Object = pForm.Controls(0)
            resizeForm(obj)
            'Dim obj As Object = pForm.Controls(0)
            'resizeForm(obj)
        End If
    End Sub

    Private Sub btnAppMax_Click(sender As Object, e As EventArgs) Handles btnAppMax.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnAppMin_Click(sender As Object, e As EventArgs) Handles btnAppMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnAppExit_Click(sender As Object, e As EventArgs) Handles btnAppExit.Click
        Try
            showNotification(iconNotif.warning, "Konfirmasi keluar aplikasi")

            If dizMsgbox("Keluar dari Aplikasi?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
                Exit Sub
            End If
            'If dizmsgbox("Keluar dari Aplikasi?", dizMsgboxStyle.konfirmasi, me) = dizMsgboxValue.Batal Then
            '    Exit Sub
            'End If

            bClose = False
            bwServer.CancelAsync()
            tmrWaktu.Stop()
            Application.Exit()
        Catch ex As Exception
            Application.Exit()
        End Try
    End Sub

    Private Sub btnServer_Click(sender As Object, e As EventArgs) Handles btnServer.Click
        hideTaskList(True)
        Dim perf As New frmPerformance
        perf.ShowDialog()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        hideTaskList(True)
        If statLogin = True Then
            If userdata = 1 Then
                TampilkanForm(Nothing, "frmAdministrator", False)
            Else
                TampilkanForm(Nothing, "frmProfile", False)
            End If
        End If
    End Sub

    Private Sub btnMemo_Click(sender As Object, e As EventArgs) Handles btnMemo.Click
        hideTaskList(True)
        If statLogin = True Then
            Dim memo As New frmMemo
            tambahChild(memo)
            memo.ShowDialog(Me)
            disposechild(memo, Nothing)
        End If
    End Sub

    Private Sub btnNote_Click(sender As Object, e As EventArgs) Handles btnNote.Click
        hideTaskList(True)

        If statLogin = True Then
            Dim notes As New frmNotes
            tambahChild(notes)
            notes.ShowDialog(Me)
            disposechild(notes, Nothing)
        End If
    End Sub

    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        hideTaskList(True)
        If statLogin = True Then
            Dim msg As New frmMessages
            tambahChild(msg)
            msg.ShowDialog(Me)
            disposechild(msg, Nothing)
        End If
    End Sub

    Private Sub btnCompList_Click(sender As Object, e As EventArgs) Handles btnCompList.Click
        If isServer = True Then
            Dim clist As New frmFiturServer
            tambahChild(clist)
            clist.ShowDialog()
            disposechild(clist, Nothing)
        End If
    End Sub

    Private Sub btnDBSetting_Click(sender As Object, e As EventArgs) Handles btnDBSetting.Click
        Dim dbset As New frmSettingDB
        If dbset.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                Environment.Exit(0)
            Catch ex As Exception
                Environment.Exit(0)
            End Try
        End If
    End Sub

    Private Sub btnTaskManager_Click(sender As Object, e As EventArgs) Handles btnTaskManager.Click
        If pnlTaskList.Visible = False Then
            hideTaskList(False)
        Else
            hideTaskList(True)
        End If
    End Sub

    Private Sub pHeader_EnabledChanged(sender As Object, e As EventArgs) Handles pHeader.EnabledChanged
        btnLogin.Enabled = pHeader.Enabled
        If pHeader.Enabled = True Then
            btnLogin.Focus()
        Else
            btnAppExit.Focus()
        End If
    End Sub

    Private Sub tcTile_VisibleChanged(sender As Object, e As EventArgs) Handles tcTile.VisibleChanged
        If statLogin = True Then
            If tcTile.Visible = True Then
                If tcTile.Groups.Count = 0 Then
                    gcSearch.Visible = False
                    gcSearch.SendToBack()
                    teSearch.Text = ""
                Else
                    gcSearch.Visible = True
                    gcSearch.BringToFront()
                    teSearch.Text = ""
                End If
            Else
                gcSearch.Visible = False
                gcSearch.SendToBack()
                teSearch.Text = ""
            End If
        Else
            gcSearch.Visible = False
            gcSearch.SendToBack()
            teSearch.Text = ""
        End If
    End Sub

    Private Sub teSearch_TextChanged(sender As Object, e As EventArgs) Handles teSearch.TextChanged
        If gcSearch.Visible = False Then Exit Sub
        If teSearch.Text = "" Then
            For Each cg As DevExpress.XtraEditors.TileGroup In tcTile.Groups
                For Each ci As DevExpress.XtraEditors.TileItem In tcTile.Groups(cg.Name).Items
                    ci.Visible = True
                Next
            Next
        Else
            For Each cg As DevExpress.XtraEditors.TileGroup In tcTile.Groups
                For Each ci As DevExpress.XtraEditors.TileItem In tcTile.Groups(cg.Name).Items
                    If ci.Text.ToLower.Contains(teSearch.Text.ToLower) Then
                        ci.Visible = True
                    Else
                        ci.Visible = False
                    End If
                Next
            Next
        End If
    End Sub

End Class
