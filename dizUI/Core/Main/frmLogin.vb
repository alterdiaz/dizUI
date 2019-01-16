Public Class frmLogin

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
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
        sqls.DMLQuery("select value from sys_appsetting where variable='ProductVersion'", "cekver")
        dbstring = readSettingFile()
        Dim versi As String = sqls.getDataSet("cekver", 0, "value")
        versi = versi.Replace(".", "")
        Dim thisversi As String = modCore.productversion
        thisversi = thisversi.Replace(".", "")
        If CInt(versi) <> CInt(thisversi) Then
            statLogin = False
            lblWarning.Text = "Harap gunakan versi " & sqls.getDataSet("cekver", 0, "value")
            lblWarning.Visible = True
            Exit Sub
        End If
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

        sqls.DMLQuery("select u.password,u.iduser,u.username,l.userlevel,u.userstatus,u.bannedreason,u.iduserlevel,l.userdata,l.issuperadmin,u.tokenkey1,u.tokenkey2 from sys_user u left join sys_userlevel l on l.iduserlevel=u.iduserlevel where u.username='" & tboUsername.Text & "'", "login")

        Dim canLogin As Boolean = False        '
        If sqls.getDataSet("login") > 0 Then
            Dim pass As String = sqls.getDataSet("login", 0, "password")
            Dim tmptoken1 As String = sqls.getDataSet("login", 0, "tokenkey1")
            Dim tmptoken2 As String = sqls.getDataSet("login", 0, "tokenkey2")
            Dim passval As String = generatePass(tboPassword.Text, tmptoken1, tmptoken2, 8000)
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
End Class