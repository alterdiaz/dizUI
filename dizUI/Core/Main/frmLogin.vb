Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports DirectShowLib
Imports System.Runtime.InteropServices.ComTypes

Public Class frmLogin

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If pbScan.Visible = True Then
            pbScan.Visible = False
            If Me.CurrentState = PlayState.Running Then
                closeinterfaces()
            End If
        End If
        closeinterfaces()
        MyBase.Dispose(True)

        Me.Dispose()
    End Sub

    Private Sub pbOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If isServer = True Then
            Dim idsetting As String = ""
            Dim dtsqls As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            dtsqls.DMLQuery("select value,idappsetting from sys_appsetting where variable='LastActive'", "lastcheck")
            idsetting = dtsqls.getDataSetValue("lastcheck", 0, 1)

            field.AddRange(New String() {"idappsetting", "value"})
            value.AddRange(New Object() {idsetting, Format(nowTime, "dd-MM-yyyy HH:mm:ss")})
            dtsqls = New dtsetSQLS(dbstring)
            dtsqls.datasetSave("sys_appsetting", idsetting, field, value, False)
        End If

        btnOK.DialogResult = DialogResult.None
        Dim sqls As New SQLs(dbstring)

        'If IO.Path.GetFileNameWithoutExtension(Application.ExecutablePath) = "dizUI" Then
        '    sqls.DMLQuery("select value from sys_appsetting where variable='ProductVersion'", "cekver")
        '    dbstring = readSettingFile()
        '    Dim versi As String = sqls.getDataSet("cekver", 0, "value")
        '    versi = versi.Replace(".", "")
        '    Dim thisversi As String = modCore.productversion
        '    thisversi = thisversi.Replace(".", "")
        '    If CInt(versi) <> CInt(thisversi) Then
        '        statLogin = False
        '        lblWarning.Text = "Harap gunakan versi " & sqls.getDataSet("cekver", 0, "value")
        '        lblWarning.Visible = True
        '        Exit Sub
        '    End If
        'End If

        'sqls.DMLQuery("select value from sys_appsetting where variable='LastActive'", "cekval")
        'If sqls.getDataSet("cekval") = 0 Then
        '    statLogin = False
        '    lblWarning.Text = "Aplikasi pada Server tidak berjalan"
        '    lblWarning.Visible = True
        '    Exit Sub
        'Else
        'Dim tmpstr As String = sqls.getDataSet("cekval", 0, 0)
        'Dim cekdate As Date = Strdatetime2Datetime(tmpstr)
        'If DateDiff(DateInterval.Second, cekdate, nowTime) > timeoutApps Then
        '        statLogin = False
        '        lblWarning.Text = "Aplikasi pada Server tidak berjalan"
        '        lblWarning.Visible = True
        '        Exit Sub
        '    End If
        'End If
        If isServer = False Then
            sqls.DMLQuery("select value from sys_appsetting where variable='QtyClient'", "cekqty")
            If sqls.getDataSet("cekqty") = 0 Then
                sqls.DMLQuery("select * from (select top 1 ipclient,idunique,idclientunit from sys_clientunit order by idclientunit asc) ipc where ipc.ipclient='" & modCore.getIPAddress(ipaddparam.IP) & "'", "cekip")
            Else
                sqls.DMLQuery("select * from (select top " & sqls.getDataSet("cekqty", 0, "value") & " ipclient,idunique,idclientunit from sys_clientunit order by idclientunit asc) ipc where ipc.ipclient='" & modCore.getIPAddress(ipaddparam.IP) & "'", "cekip")
            End If
            If sqls.getDataSet("cekip") = 0 Then
                statLogin = False
                lblWarning.Text = "Komputer ini tidak terdaftar di Server"
                lblWarning.Visible = True
                Exit Sub
            Else
                Dim tmpidunique As String = modCore.getBoardID 'modCore.getMacAddress(modCore.getIPAddress(ipaddparam.IP))
                Dim dizEngine As New dizEngine.engine
                tmpidunique = dizEngine.processE(tmpidunique)
                'tmpidunique = GenerateUniqueID(tmpidunique, 1000)
                If sqls.getDataSet("cekip", 0, "idunique") = "-" Then
                    Dim idcekip As String = sqls.getDataSet("cekip", 0, "idclientunit")
                    Dim dtsqls As New dtsetSQLS(dbstring)
                    Dim field As New List(Of String)
                    Dim value As New List(Of Object)
                    field.AddRange(New String() {"idclientunit", "idunique"})
                    value.AddRange(New Object() {idcekip, tmpidunique})
                    dtsqls.datasetSave("sys_clientunit", idcekip, field, value, False)
                Else
                    'MsgBox(sqls.getDataSet("cekip", 0, "idunique") & vbCrLf & tmpidunique)
                    If sqls.getDataSet("cekip", 0, "idunique") <> tmpidunique Then
                        statLogin = False
                        lblWarning.Text = "Komputer ini tidak terdaftar di Server"
                        lblWarning.Visible = True
                        Exit Sub
                    End If
                End If
            End If
        End If

        If captureType = 0 Then
            sqls.DMLQuery("select u.password,u.iduser,u.username,l.userlevel,u.userstatus,u.bannedreason,u.iduserlevel,l.userdata,l.issuperadmin,u.tokenkey1,u.tokenkey2 from sys_user u left join sys_userlevel l on l.iduserlevel=u.iduserlevel where u.username='" & tboUsername.Text & "'", "login")
        ElseIf captureType = 1 Then
            sqls.DMLQuery("select u.password,u.iduser,u.username,l.userlevel,u.userstatus,u.bannedreason,u.iduserlevel,l.userdata,l.issuperadmin,u.tokenkey1,u.tokenkey2 from sys_user u left join sys_userlevel l on l.iduserlevel=u.iduserlevel where u.qrpass='" & tboScan.Text & "'", "login")
        ElseIf captureType = 2 Then
            sqls.DMLQuery("select u.password,u.iduser,u.username,l.userlevel,u.userstatus,u.bannedreason,u.iduserlevel,l.userdata,l.issuperadmin,u.tokenkey1,u.tokenkey2 from sys_user u left join sys_userlevel l on l.iduserlevel=u.iduserlevel where u.qrpass='" & tboScan.Text & "'", "login")
        ElseIf captureType = 3 Then
            sqls.DMLQuery("select u.password,u.iduser,u.username,l.userlevel,u.userstatus,u.bannedreason,u.iduserlevel,l.userdata,l.issuperadmin,u.tokenkey1,u.tokenkey2 from sys_user u left join sys_userlevel l on l.iduserlevel=u.iduserlevel where u.nfcpass='" & tboScan.Text & "'", "login")
        End If

        Dim canLogin As Boolean = False        '
        If sqls.getDataSet("login") > 0 Then
            If captureType = 0 Then
                Dim pass As String = sqls.getDataSet("login", 0, "password")
                Dim tmptoken1 As String = sqls.getDataSet("login", 0, "tokenkey1")
                Dim tmptoken2 As String = sqls.getDataSet("login", 0, "tokenkey2")
                Dim passval As String = GeneratePass(tboPassword.Text, tmptoken1, tmptoken2, 8000)
                If pass = passval Then
                    canLogin = True
                End If
            Else
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
                field.AddRange(New String() {"iduser", "waktucek", "ipclient"})
                value.AddRange(New Object() {userid, nowTime, getIPAddress(ipaddparam.IP)})
                mys.datasetSave("sys_User", userid, field, value, False)

                field = New List(Of String)
                value = New List(Of Object)
                mys = New dtsetSQLS(dbstring)
                Dim idtmp As String = GenerateGUID()
                field.AddRange(New String() {"iduserlogin", "createddate", "createdby", "ipclient", "hostname"})
                value.AddRange(New Object() {idtmp, nowTime, userid, getIPAddress(ipaddparam.IP), getIPAddress(ipaddparam.Host)})
                mys.datasetSave("sys_UserLogin", idtmp, field, value, False)

                lblWarning.Visible = False
                statLogin = True
                btnOK.DialogResult = DialogResult.OK
                closeinterfaces()
                MyBase.Dispose(True)
                Me.Dispose()
            End If
        Else
            statLogin = False
            lblWarning.Text = "Username/Password tidak benar"
            lblWarning.Visible = True
        End If
    End Sub

    Private Sub frmLogin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If tboUsername.Text = "" Then
            tboUsername.Focus()
        Else
            tboPassword.Focus()
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        checkFieldMaxLength(dbstring, pnlField, "sys_user")

        tboUsername.Text = ""
        lblWarning.Visible = False
        captureType = 0
    End Sub

    Private Sub tboUsername_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tboUsername.GotFocus
        tboPassword.Text = ""
        lblWarning.Visible = False
    End Sub

    Private Sub tboUsername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboUsername.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rVarchar) = False And (Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13) Then
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
            pbOK_Click(Me, Nothing)
        End If
    End Sub

    Private Sub lnkNewUser_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkNewUser.LinkClicked
        Dim newuser As New frmNewProfile(False)
        newuser.ShowDialog()
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        UpdateStyles()
        Me.DoubleBuffered = True
    End Sub

    Enum PlayState
        Stopped
        Paused
        Running
        Init
    End Enum
    Dim CurrentState As PlayState = PlayState.Stopped
    Dim D As Integer = Convert.ToInt32("0X8000", 16)
    Dim WM_GRAPHNOTIFY As Integer = D + 1
    Dim VideoWindow As IVideoWindow = Nothing
    Dim MediaControl As IMediaControl = Nothing
    Dim MediaEventEx As IMediaEventEx = Nothing
    Dim GraphBuilder As IGraphBuilder = Nothing
    Dim CaptureGraphBuilder As ICaptureGraphBuilder2 = Nothing
    Dim rot As DsROTEntry = Nothing

    Private Sub CaptureVideo()
        Dim hr As Integer = 0
        Dim sourceFilter As IBaseFilter = Nothing
        Try
            GetInterfaces()

            hr = Me.CaptureGraphBuilder.SetFiltergraph(Me.GraphBuilder) 'Specifies filter graph "graphbuilder" for the capture graph builder "captureGraphBuilder" to use.
            DsError.ThrowExceptionForHR(hr)
            sourceFilter = FindCaptureDevice()
            hr = Me.GraphBuilder.AddFilter(sourceFilter, "Video Capture")
            DsError.ThrowExceptionForHR(hr)
            hr = Me.CaptureGraphBuilder.RenderStream(PinCategory.Preview, MediaType.Video, sourceFilter, Nothing, Nothing)
            DsError.ThrowExceptionForHR(hr)
            Marshal.ReleaseComObject(sourceFilter)
            SetupVideoWindow()
            rot = New DsROTEntry(Me.GraphBuilder)
            hr = Me.MediaControl.Run()
            DsError.ThrowExceptionForHR(hr)
            Me.CurrentState = PlayState.Running
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GetInterfaces()
        Dim hr As Integer = 0
        Me.GraphBuilder = CType(New FilterGraph, IGraphBuilder)
        Me.CaptureGraphBuilder = CType(New CaptureGraphBuilder2, ICaptureGraphBuilder2)
        Me.MediaControl = CType(Me.GraphBuilder, IMediaControl)
        Me.VideoWindow = CType(Me.GraphBuilder, IVideoWindow)
        Me.MediaEventEx = CType(Me.GraphBuilder, IMediaEventEx)
        hr = Me.MediaEventEx.SetNotifyWindow(Me.Handle, WM_GRAPHNOTIFY, IntPtr.Zero)
        DsError.ThrowExceptionForHR(hr)
    End Sub
    Public Function FindCaptureDevice() As IBaseFilter
        Dim hr As Integer = 0
        Dim classEnum As IEnumMoniker = Nothing
        Dim moniker As IMoniker() = New IMoniker(0) {}
        Dim source As Object = Nothing
        Dim devEnum As ICreateDevEnum = CType(New CreateDevEnum, ICreateDevEnum)
        hr = devEnum.CreateClassEnumerator(FilterCategory.VideoInputDevice, classEnum, 0)
        DsError.ThrowExceptionForHR(hr)
        Marshal.ReleaseComObject(devEnum)
        If classEnum Is Nothing Then
        End If
        If classEnum.Next(moniker.Length, moniker, IntPtr.Zero) = 0 Then
            Dim iid As Guid = GetType(IBaseFilter).GUID
            moniker(0).BindToObject(Nothing, Nothing, iid, source)
        Else
        End If
        Marshal.ReleaseComObject(moniker(0))
        Marshal.ReleaseComObject(classEnum)
        Return CType(source, IBaseFilter)
    End Function
    Public Sub SetupVideoWindow()
        Dim hr As Integer = 0
        hr = Me.VideoWindow.put_Owner(Me.Handle)
        DsError.ThrowExceptionForHR(hr)
        hr = Me.VideoWindow.put_WindowStyle(WindowStyle.Child Or WindowStyle.Visible)
        DsError.ThrowExceptionForHR(hr)
        ResizeVideoWindow()
        hr = Me.VideoWindow.put_Visible(OABool.True)
        DsError.ThrowExceptionForHR(hr)
        Me.btnCapture.BringToFront()
    End Sub
    Protected Overloads Sub WndProc(ByRef m As Message)
        Select Case m.Msg
            Case WM_GRAPHNOTIFY
                HandleGraphEvent()
        End Select
        If Not (Me.VideoWindow Is Nothing) Then
            Me.VideoWindow.NotifyOwnerMessage(m.HWnd, m.Msg, m.WParam.ToInt32, m.LParam.ToInt32)
        End If
        MyBase.WndProc(m)
    End Sub
    Public Sub HandleGraphEvent()
        Dim hr As Integer = 0
        Dim evCode As EventCode
        Dim evParam1 As Integer
        Dim evParam2 As Integer
        If Me.MediaEventEx Is Nothing Then
            Return
        End If
        While Me.MediaEventEx.GetEvent(evCode, evParam1, evParam2, 0) = 0
            hr = Me.MediaEventEx.FreeEventParams(evCode, evParam1, evParam2)
            DsError.ThrowExceptionForHR(hr)
        End While
    End Sub
    Public Sub closeinterfaces()
        '//stop previewing data
        If Not (Me.MediaControl Is Nothing) Then
            Me.MediaControl.StopWhenReady()
        End If

        Me.CurrentState = PlayState.Stopped

        '//stop recieving events
        If Not (Me.MediaEventEx Is Nothing) Then
            Me.MediaEventEx.SetNotifyWindow(IntPtr.Zero, WM_GRAPHNOTIFY, IntPtr.Zero)
        End If

        '// Relinquish ownership (IMPORTANT!) of the video window.
        '// Failing to call put_Owner can lead to assert failures within
        '// the video renderer, as it still assumes that it has a valid
        '// parent window.
        If Not (Me.VideoWindow Is Nothing) Then
            Me.VideoWindow.put_Visible(OABool.False)
            Me.VideoWindow.put_Owner(IntPtr.Zero)
        End If

        ' // Remove filter graph from the running object table
        If Not (rot Is Nothing) Then
            rot.Dispose()
            rot = Nothing
        End If

        '// Release DirectShow interfaces
        Try
            Marshal.ReleaseComObject(Me.MediaControl) : Me.MediaControl = Nothing
            Marshal.ReleaseComObject(Me.MediaEventEx) : Me.MediaEventEx = Nothing
            Marshal.ReleaseComObject(Me.VideoWindow) : Me.VideoWindow = Nothing
            Marshal.ReleaseComObject(Me.GraphBuilder) : Me.GraphBuilder = Nothing
            Marshal.ReleaseComObject(Me.CaptureGraphBuilder) : Me.CaptureGraphBuilder = Nothing
        Catch ex As Exception
        End Try
    End Sub
    Public Sub ChangePreviewState(ByVal showVideo As Boolean)
        Dim hr As Integer = 0
        If Me.MediaControl Is Nothing Then
            Return
        End If
        If showVideo = True Then
            If Not (Me.CurrentState = PlayState.Running) Then
                hr = Me.MediaControl.Run
                Me.CurrentState = PlayState.Running
            End If
        Else
            hr = Me.MediaControl.StopWhenReady
            Me.CurrentState = PlayState.Stopped
        End If
    End Sub
    Public Sub ResizeVideoWindow()
        If Not (Me.VideoWindow Is Nothing) Then 'if the videopreview is not nothing
            Me.VideoWindow.SetWindowPosition(Me.pbScan.Location.X, Me.pbScan.Location.Y, Me.pbScan.Size.Width, Me.pbScan.Size.Height)
            Me.btnCapture.BringToFront()
        End If
    End Sub

    Private Sub btnWebcam_Click(sender As Object, e As EventArgs) Handles btnWebcam.Click
        dizMsgbox("Fitur ini akan tersedia segera", dizMsgboxStyle.Info, Me)
        Exit Sub

        If pbScan.Visible = True Then
            pbScan.Visible = False
            tboScan.Visible = False
            If Me.CurrentState = PlayState.Running Then
                closeinterfaces()
            End If
        Else
            pbScan.Visible = True
            tboScan.Visible = False

            imgResult = Nothing
            pbScan.Image = Nothing

            Try
                If Me.CurrentState = PlayState.Running Then
                    closeinterfaces()
                End If
            Catch ex As Exception
                Exit Sub
            End Try
            Try
                CaptureVideo()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private captureType As Integer = 0
    Private Sub btnQRWebcam_Click(sender As Object, e As EventArgs) Handles btnQRWebcam.Click
        dizMsgbox("Fitur ini akan tersedia segera", dizMsgboxStyle.Info, Me)
        Exit Sub

        If pbScan.Visible = True Then
            pbScan.Visible = False
            tboScan.Text = ""
            tboScan.Visible = False
            btnQRWebcam.Focus()
            captureType = 0
            If CurrentState = PlayState.Running Then
                closeinterfaces()
            End If
        Else
            pbScan.Visible = True
            tboScan.Visible = True
            tboScan.Focus()
            captureType = 1

            imgResult = Nothing
            pbScan.Image = Nothing

            Try
                If Me.CurrentState = PlayState.Running Then
                    closeinterfaces()
                End If
            Catch ex As Exception
                Exit Sub
            End Try
            Try
                CaptureVideo()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub pbScan_VisibleChanged(sender As Object, e As EventArgs) Handles pbScan.VisibleChanged
        btnCapture.Visible = pbScan.Visible
        btnCapture.BringToFront()
    End Sub

    Private imgResult As Image = Nothing
    Private filename As String = ""

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        If Me.CurrentState = PlayState.Running Then
            closeinterfaces()
        Else
            Try
                If CurrentState = PlayState.Running Then
                    closeinterfaces()
                End If
            Catch ex As Exception
                Exit Sub
            End Try
            Try
                CaptureVideo()
                pbScan.Visible = False
                pbScan.Visible = True
                pbScan.Invalidate()
                pbScan.Refresh()
                Application.DoEvents()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Exit Sub
        End If

        pbScan.Refresh()
        imgResult = Nothing
        If imgResult IsNot Nothing Then
            imgResult = Nothing
        End If

        GC.Collect()
        imgResult = pbScan.Image
        If imgResult Is Nothing Then
            dizMsgbox("Foto atau Kamera tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If

        Try
            filename = System.IO.Path.Combine(pathTemp, Format(nowTime, "yyyyMMddHHmmssfff") & ".jpg")
            imgResult.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg)
            Threading.Thread.Sleep(100)

            pbScan.Image = Nothing
            pbScan.Refresh()

            imgResult = Image.FromFile(filename)
            pbScan.Image = imgResult
            imgResult = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnQR_Click(sender As Object, e As EventArgs) Handles btnQR.Click
        pbScan.Visible = False
        If tboScan.Visible = True Then
            tboScan.Text = ""
            tboScan.Visible = False
            tboUsername.Focus()
            captureType = 0
        Else
            tboScan.Visible = True
            tboScan.Focus()
            captureType = 2
        End If
    End Sub

    Private Sub btnNFC_Click(sender As Object, e As EventArgs) Handles btnNFC.Click
        pbScan.Visible = False
        If tboScan.Visible = True Then
            tboScan.Text = ""
            tboScan.Visible = False
            tboUsername.Focus()
            captureType = 0
        Else
            tboScan.Visible = True
            tboScan.Focus()
            captureType = 3
        End If
    End Sub

    Private Sub tboScan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tboScan.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            pbOK_Click(Me, Nothing)
        End If
    End Sub

End Class