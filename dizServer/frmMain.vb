Public Class frmMain
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

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
        Me.ShowIcon = False
        tsmMinimize.Visible = False
        tsmRestore.Visible = True

        Me.Text = "diznet Server " & Application.ProductVersion
        nicon.Text = "diznet Server " & Application.ProductVersion
        nicon.BalloonTipIcon = ToolTipIcon.Info
        nicon.BalloonTipText = "diznet Server is Starting"
        nicon.BalloonTipTitle = "diznet Server " & Application.ProductVersion
        nicon.ShowBalloonTip(3)

        tboIPServer.Text = "127.0.0.1"

        nudIPClient1.Value = 0
        nudIPClient2.Value = 0
        nudIPClient3.Value = 0
        nudIPClient4.Value = 0

        Dim this As New thisApps
        tboDBname.Text = dbname
        tboUsr.Text = dbuid
        tboPass.Text = dbpwd
        tboIPServer.ReadOnly = True
        tboDBname.ReadOnly = True
        tboUsr.ReadOnly = True
        tboPass.ReadOnly = True
        nudPC.ReadOnly = True
        tboLastCheck.ReadOnly = True

        Dim sqls As New dtsetSQLS(dbstring)
        sqls.DMLQuery("select value from sys_appsetting where variable='QtyClient'", "cekqty")
        fromLoad = True
        If sqls.getDataSetRowCount("cekqty") = 0 Then
            nudPC.Value = 0
        Else
            nudPC.Value = sqls.getDataSetValue("cekqty", 0, 0)
        End If
        fromLoad = False
        sqls.DMLQuery("select value from sys_appsetting where variable='LastActive'", "lastcheck")
        lastCheck = Now
        If sqls.getDataSetRowCount("lastcheck") = 0 Then
            tboLastCheck.Text = "Error"
            btnRun.Enabled = False
        Else
            tboLastCheck.Text = sqls.getDataSetValue("lastcheck", 0, 0)
            btnRun.Enabled = True
        End If
        xtcPage.SelectedTabPage = xtpDatabase
    End Sub

    Private fromLoad As Boolean = False
    Private lastCheck As Date
    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        If btnRun.Text = "Stop" Then
            btnRun_Click(btnRun, Nothing)
        End If
        Environment.Exit(0)
    End Sub

    Private Sub nudPC_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudPC.ValueChanged
        Dim sqls As New dtsetSQLS(dbstring)
        sqls.DMLQuery("select top " & nudPC.Value & " ipclient from sys_clientunit order by idclientunit asc", "clientpc")
        lbClient.DataSource = sqls.dataTable("clientpc")
        lbClient.ValueMember = "ipclient"
        lbClient.DisplayMember = "ipclient"

        If nudPC.Value > 0 Then
            If fromLoad = False Then
                sqls = New dtsetSQLS(dbstring)
                sqls.DMLQuery("delete from sys_ClientUnit where idclientunit not in(select top " & nudPC.Value & " idclientunit from sys_clientunit order by idclientunit asc)", False)
            End If
        End If
        If fromLoad = False Then
            sqls = New dtsetSQLS(dbstring)
            sqls.DMLQuery("update sys_appsetting set value=" & nudPC.Value & " where variable='QtyClient'", False)
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim ipclient As String = nudIPClient1.Value & "." & nudIPClient2.Value & "." & nudIPClient3.Value & "." & nudIPClient4.Value
        If ipclient = "0.0.0.0" Then
            MsgBox("IP Client tidak valid", MsgBoxStyle.Critical, "Kesalahan")
            Exit Sub
        End If
        'If ipclient = "127.0.0.1" Then
        '    MsgBox("IP Client tidak valid", MsgBoxStyle.Critical, "Kesalahan")
        '    Exit Sub
        'End If
        If ipclient = "255.255.255.255" Then
            MsgBox("IP Client tidak valid", MsgBoxStyle.Critical, "Kesalahan")
            Exit Sub
        End If
        Dim sqls As New dtsetSQLS(dbstring)
        sqls.DMLQuery("select ipclient from sys_clientunit", "cekall")
        If sqls.getDataSetRowCount("cek") >= nudPC.Value Then
            MsgBox("List PC Client sudah penuh", MsgBoxStyle.Critical, "Kesalahan")
            Exit Sub
        End If
        sqls.DMLQuery("select ipclient from sys_clientunit where ipclient='" & ipclient & "'", "cek")
        If sqls.getDataSetRowCount("cek") > 0 Then
            MsgBox("IP PC Client ini sudah terdaftar", MsgBoxStyle.Critical, "Kesalahan")
            Exit Sub
        Else
            sqls = New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idclientunit", "ipclient", "idunique"})
            value.AddRange(New Object() {-1, ipclient, "-"})
            sqls.datasetSave("sys_clientunit", -1, field, value, False)

            MsgBox("Data IP PC Client sudah tersimpan", MsgBoxStyle.Information, "Tersimpan")

            sqls = New dtsetSQLS(dbstring)
            sqls.DMLQuery("select top " & nudPC.Value & " ipclient from sys_clientunit", "clientpc")
            lbClient.DataSource = sqls.dataTable("clientpc")
            lbClient.ValueMember = "ipclient"
            lbClient.DisplayMember = "ipclient"
        End If
    End Sub

    Private Sub nudIPClient1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudIPClient1.GotFocus, nudIPClient2.GotFocus, nudIPClient3.GotFocus, nudIPClient4.GotFocus
        sender.Select(0, 3)
    End Sub

    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        If btnRun.Text = "Run" Then
            nicon.BalloonTipIcon = ToolTipIcon.Info
            nicon.BalloonTipText = "diznet Server is Running"
            nicon.BalloonTipTitle = "diznet Server " & Application.ProductVersion
            nicon.ShowBalloonTip(3)

            tmrAuto.Start()
            btnRun.Text = "Stop"
        ElseIf btnRun.Text = "Stop" Then
            nicon.BalloonTipIcon = ToolTipIcon.Error
            nicon.BalloonTipText = "diznet Server is Stopping"
            nicon.BalloonTipTitle = "diznet Server " & Application.ProductVersion
            nicon.ShowBalloonTip(3)

            tmrAuto.Stop()
            btnRun.Text = "Run"
        End If
    End Sub

    Private Sub tmrAuto_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrAuto.Tick
        If Now.Second Mod 3 = 0 Then
            Dim idsetting As String = ""
            Dim sqls As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            sqls.DMLQuery("select value,idappsetting from sys_appsetting where variable='LastActive'", "lastcheck")
            tboLastCheck.Text = sqls.getDataSetValue("lastcheck", 0, 0)
            idsetting = sqls.getDataSetValue("lastcheck", 0, 1)
            lastCheck = Now

            field.AddRange(New String() {"idappsetting", "value"})
            value.AddRange(New Object() {idsetting, Format(lastCheck, "dd-MM-yyyy HH:mm:ss")})
            sqls = New dtsetSQLS(dbstring)
            sqls.datasetSave("sys_appsetting", idsetting, field, value, False)
        End If
    End Sub

    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
        Me.ShowIcon = False
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub nicon_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles nicon.MouseDoubleClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Minimized
            Me.ShowInTaskbar = False
            Me.ShowIcon = False
        ElseIf Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
            Me.ShowInTaskbar = True
            Me.ShowIcon = True
        End If
    End Sub

    Private Sub tsmMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmMinimize.Click
        Me.WindowState = FormWindowState.Minimized
        Me.ShowInTaskbar = False
        Me.ShowIcon = False
        tsmMinimize.Visible = False
        tsmRestore.Visible = True
    End Sub

    Private Sub tsmRestore_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsmRestore.Click
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
        Me.ShowIcon = True
        tsmMinimize.Visible = True
        tsmRestore.Visible = False
    End Sub

    Private Sub tsmExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tsmExit.Click
        btnKeluar_Click(btnKeluar, Nothing)
    End Sub

    Private Sub UpdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdSave.Click

    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If lbClient.SelectedItems.Count = 0 Then
            Exit Sub
        End If
        If MsgBox("Delete this IP Client?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            Dim sqls As New dtsetSQLS(dbstring)
            sqls.DMLQuery("delete from sys_ClientUnit where ipclient='" & lbClient.SelectedValue & "'", False)

            nudPC_ValueChanged(nudPC, Nothing)
        End If
    End Sub

End Class
