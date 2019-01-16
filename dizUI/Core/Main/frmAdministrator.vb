Public Class frmAdministrator
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

    Private Sub pExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.Click
        bClose = False
        Me.Dispose()
    End Sub

    Private Sub pbMMX_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pExit.MouseDown
        If sender Is pExit Then
            sender.backcolor = justRead
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private Sub pbMMX_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.MouseEnter
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private Sub pbMMX_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.MouseLeave
        sender.backcolor = Color.Transparent
        If sender Is pExit Then
            sender.Image = My.Resources.exit_w
        End If
    End Sub

    Private Sub pbMMX_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pExit.MouseUp
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        loadGrid()

        kosongkanIsian(tlpPengguna)
        kosongkanIsian(tlpAdministrator)

        teUsername.Enabled = True
        teUsername.Properties.ReadOnly = False
        teUsername.BackColor = canWrite
        statData = statusData.Baru

        tePassword.Text = "default"
        tePassword.Enabled = False
        tePassword.Properties.ReadOnly = True
        tePassword.BackColor = justRead
    End Sub

    Private Sub btnIconMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIconMenu.Click
        If usersuper = 1 Then
            Dim icon As New frmIconManager
            icon.ShowDialog()
        Else
            dizMsgbox("Anda tidak memiliki hak akses ini", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

    Private Sub loadLOV()
        Dim mysqls As New SQLs(dbstring)
        lueStatus.Properties.DataSource = Nothing
        lueLevel.Properties.DataSource = Nothing

        mysqls.DMLQuery("select ul.iduserlevel, ul.userlevel, ud.generalcode as userdata, ass.generalcode as assuper from sys_userlevel ul left join sys_generalcode ud on ul.userdata=ud.idgeneral and ud.gctype='USERDATA' left join sys_generalcode ass on ul.issuperadmin=ass.idgeneral and ass.gctype='ISSUPERADMIN' order by ul.iduserlevel asc", "SL")
        lueLevel.Properties.DataSource = mysqls.dataTable("SL")
        lueLevel.Properties.DisplayMember = "userlevel"
        lueLevel.Properties.ValueMember = "iduserlevel"
        lueLevel.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

        mysqls.DMLQuery("select idgeneral as userstatus, generalcode as status from sys_generalcode where gctype='USER'", "SD")
        lueStatus.Properties.DataSource = mysqls.dataTable("SD")
        lueStatus.Properties.DisplayMember = "status"
        lueStatus.Properties.ValueMember = "userstatus"
        lueStatus.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
    End Sub

    Private Sub loadGrid()
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select i.images,u.iduser,u.iduserlevel,u.userstatus,u.username,'********' as password,l.userlevel,s.generalcode as status,u.bannedreason as reason,u.namalengkap,u.email,u.handphone,convert(varchar,u.waktucek,105) +' '+ convert(varchar,u.waktucek,108) as waktucek from sys_user u inner join sys_userlevel l on u.iduserlevel=l.iduserlevel inner join sys_generalcode s on s.idgeneral=u.userstatus and s.gctype='USER' inner join sys_userimages ui on ui.iduser=u.iduser inner join sys_images i on ui.idimages=i.idimages where ui.asprofile=1 and ui.isdeleted=0 and isnull(u.isuseronline,0)=0", "data")
        gcData.DataSource = mysqls.dataTable("data")
        gvData.BestFitColumns()
    End Sub

    Private Sub sync()
        If isServer = True Then
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

            'Dim mys As New MYs(mystring)
            ''If mys.checkConnection() = True Then

            'host offline sementara
            'syncToken()
            'syncUser(System.Net.Dns.GetHostName())

            ''End If
            'lblLoad.Text = "READY"
        End If
    End Sub

    Private Sub syncUser(ByVal hostname As String)
        isSync = True
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

        'Dim mys As New SQLs(mystring)
        'Dim myset As New dtsetSQLS(mystring)
        Dim sqls As New SQLs(dbstring)
        Dim sqlset As New dtsetSQLS(dbstring)

        Dim mysuccess As Boolean = False
        Dim localcnt As Integer = 0
        Dim servercnt As Integer = 0
        Dim idguest As String = 0
        sqls.DMLQuery("select iduserlevel from sys_userlevel where userlevel='Guest'", "getIDguest")
        If sqls.getDataSet("getIDguest") > 0 Then
            idguest = sqls.getDataSet("getIDguest", 0, "iduserlevel")
        End If
        Dim idinactive As String = 0
        sqls.DMLQuery("select idgeneral from sys_generalcode where gctype='USER' and generalcode='Inactive'", "getIDinactive")
        If sqls.getDataSet("getIDinactive") > 0 Then
            idinactive = sqls.getDataSet("getIDinactive", 0, "idgeneral")
        End If
        Dim idtoken As String = 0
        sqls.DMLQuery("select su.iduser,su.username,su.password,su.hint,su.recoveryquestion,su.recoveryanswer,su.namalengkap,su.personalno,su.cardtype,su.email,su.handphone,su.idtoken,st.idtokenonline,su.tokenkey1,su.tokenkey2 from sys_user su left join sys_token st on su.idtoken=st.idtoken order by su.username asc", "cnt")

        'hosting offline 
        'mysuccess = MYs.DMLQuery("select su.iduser,su.username,su.password,su.hint,su.recoveryquestion,su.recoveryanswer,su.namalengkap,su.personalno,su.cardtype,su.email,su.handphone,st.idtoken,su.tokenkey1,su.tokenkey2 from " & mydb & "." & myusr & ".[user] su left join " & mydb & "." & myusr & ".token st on su.idtoken=st.idtoken", "cnt")

        'If mysuccess = True Then
        '    localcnt = sqls.getDataSet("cnt")
        '    servercnt = mys.getDataSet("cnt")
        '    'If localcnt < servercnt Then
        '    'Download from server
        '    'lblLoad.Text = "DOWNLOAD (0/" & mys.getDataSet("cnt") & ")"

        '    For i As Integer = 0 To mys.getDataSet("cnt") - 1
        '        Dim striduser As String = mys.getDataSet("cnt", i, "iduser")
        '        Dim strusername As String = mys.getDataSet("cnt", i, "username")
        '        Dim stridtoken As String = mys.getDataSet("cnt", i, "idtoken")
        '        Dim strtokenkey1 As String = mys.getDataSet("cnt", i, "tokenkey1")
        '        Dim strtokenkey2 As String = mys.getDataSet("cnt", i, "tokenkey2")
        '        Dim strpassword As String = mys.getDataSet("cnt", i, "password")
        '        Dim strnamalengkap As String = mys.getDataSet("cnt", i, "namalengkap")
        '        Dim strpersonalno As String = mys.getDataSet("cnt", i, "personalno")
        '        Dim strcardtype As String = mys.getDataSet("cnt", i, "cardtype")
        '        Dim stremail As String = mys.getDataSet("cnt", i, "email")
        '        Dim strhandphone As String = mys.getDataSet("cnt", i, "handphone")
        '        Dim strhint As String = mys.getDataSet("cnt", i, "hint")
        '        Dim strrecoveryquestion As String = mys.getDataSet("cnt", i, "recoveryquestion")
        '        Dim strrecoveryanswer As String = mys.getDataSet("cnt", i, "recoveryanswer")

        '        sqls = New SQLs(dbstring)
        '        sqls.DMLQuery("select iduser from sys_user where username='" & strusername & "'", "cekusername")

        '        Dim field As New List(Of String)
        '        Dim value As New List(Of Object)
        '        If sqls.getDataSet("cekusername") > 0 Then
        '            idData = sqls.getDataSet("cekusername", 0, "iduser")
        '        Else
        '            idData = "-1"
        '        End If
        '        If idData = "-1" Then
        '            field.AddRange(New String() {"iduser", "iduserlevel", "userstatus", "username", "idtoken", "tokenkey1", "tokenkey2", "password", "namalengkap", "personalno", "cardtype", "email", "handphone", "hint", "recoveryquestion", "recoveryanswer", "bannedreason", "waktucek", "isdeleted", "isuseronline"})
        '        Else
        '            field.AddRange(New String() {"iduser",  "username", "namalengkap", "personalno", "cardtype", "email", "handphone", "hint", "recoveryquestion", "recoveryanswer", "bannedreason", "waktucek", "isdeleted"})
        '        End If

        '        sqlset = New dtsetSQLS(dbstring)
        '        sqlset.DMLQuery("select idtoken from sys_token where idtokenonline=" & stridtoken, "getidtoken")
        '        If sqlset.getDataSetRowCount("getidtoken") > 0 Then
        '            idtoken = sqlset.getDataSetValue("getidtoken", 0, "idtoken")
        '        End If

        '        value.Add(idData)
        '        value.Add(striduser)
        '        If idData = "-1" Then
        '            value.Add(idguest)
        '            value.Add(idinactive)
        '        End If
        '        value.Add(strusername) 'MYs.getDataSet("cnt", i, "username"))
        '        If idData = "-1" Then
        '            value.Add(idtoken)
        '            value.Add(strtokenkey1) 'MYs.getDataSet("cnt", i, "tokenkey1"))
        '            value.Add(strtokenkey2) 'MYs.getDataSet("cnt", i, "tokenkey2"))
        '            value.Add(strpassword) 'MYs.getDataSet("cnt", i, "password"))
        '        End If
        '        value.Add(strnamalengkap) 'MYs.getDataSet("cnt", i, "namalengkap"))
        '        value.Add(strpersonalno) 'MYs.getDataSet("cnt", i, "personalno"))
        '        value.Add(strcardtype) 'MYs.getDataSet("cnt", i, "cardtype"))
        '        value.Add(stremail) 'MYs.getDataSet("cnt", i, "email"))
        '        value.Add(strhandphone) 'MYs.getDataSet("cnt", i, "handphone"))
        '        value.Add(strhint) 'MYs.getDataSet("cnt", i, "hint"))
        '        value.Add(strrecoveryquestion) 'MYs.getDataSet("cnt", i, "recoveryquestion"))
        '        value.Add(strrecoveryanswer) 'MYs.getDataSet("cnt", i, "recoveryanswer"))
        '        If idData = "-1" Then
        '            value.Add("download from server")
        '        Else
        '            value.Add("")
        '        End If
        '        value.Add(nowTime)
        '        value.Add(0)
        '        If idData = "-1" Then
        '            value.Add("1")
        '        End If

        '        myset = New dtsetSQLS(mystring)
        '        Application.DoEvents()
        '        'Threading.Thread.Sleep(100)
        '        If sqlset.datasetSave("sys_user", idData, field, value, False) = False Then
        '            'lblLoad.Text = "DOWNLOAD (ERROR)"
        '            Exit For
        '        Else
        '            'lblLoad.Text = "DOWNLOAD (" & i & "/" & mys.getDataSet("cnt") & ")"
        '        End If
        '    Next
        '    'End If
        'End If

        localcnt = 0
        servercnt = 0
        'mys = New SQLs(mystring)
        sqls = New SQLs(dbstring)
        sqls.DMLQuery("select su.iduser,su.username,su.password,su.hint,su.recoveryquestion,su.recoveryanswer,su.namalengkap,su.personalno,su.cardtype,su.email,su.handphone,su.idtoken,st.idtokenonline,su.tokenkey1,su.tokenkey2 from sys_user su left join sys_token st on su.idtoken=st.idtoken", "cnt")

        'mysuccess = mys.DMLQuery("select su.iduser,su.username,su.password,su.hint,su.recoveryquestion,su.recoveryanswer,su.namalengkap,su.personalno,su.cardtype,su.email,su.handphone,st.idtoken,su.tokenkey1,su.tokenkey2 from " & mydb & "." & myusr & ".[user] su left join " & mydb & "." & myusr & ".token st on su.idtoken=st.idtoken", "cnt")
        'If mysuccess = True Then
        '    localcnt = sqls.getDataSet("cnt")
        '    servercnt = mys.getDataSet("cnt")

        '    'If localcnt > servercnt Then
        '    'Upload to server
        '    'lblLoad.Text = "UPLOAD (0/" & sqls.getDataSet("cnt") & ")"
        '    For i As Integer = 0 To sqls.getDataSet("cnt") - 1
        '        Dim striduser As String = sqls.getDataSet("cnt", i, "iduser") 'arrvalue(i).Split("|")(0)
        '        If striduser <> "" Then
        '            Dim strusername As String = sqls.getDataSet("cnt", i, "username") 'arrvalue(i).Split("|")(1)
        '            Dim stridtoken As String = sqls.getDataSet("cnt", i, "idtoken") 'arrvalue(i).Split("|")(11)
        '            Dim strtokenkey1 As String = sqls.getDataSet("cnt", i, "tokenkey1") 'arrvalue(i).Split("|")(12)
        '            Dim strtokenkey2 As String = sqls.getDataSet("cnt", i, "tokenkey2") 'arrvalue(i).Split("|")(13)
        '            Dim strpassword As String = sqls.getDataSet("cnt", i, "password") 'arrvalue(i).Split("|")(2)
        '            Dim strnamalengkap As String = sqls.getDataSet("cnt", i, "namalengkap") 'arrvalue(i).Split("|")(6)
        '            Dim strpersonalno As String = IIf(IsDBNull(sqls.getDataSet("cnt", i, "personalno")), "", sqls.getDataSet("cnt", i, "personalno")) 'arrvalue(i).Split("|")(7)
        '            Dim strcardtype As String = IIf(IsDBNull(sqls.getDataSet("cnt", i, "cardtype")), "", sqls.getDataSet("cnt", i, "cardtype")) 'arrvalue(i).Split("|")(8)
        '            Dim stremail As String = sqls.getDataSet("cnt", i, "email") 'arrvalue(i).Split("|")(9)
        '            Dim strhandphone As String = sqls.getDataSet("cnt", i, "handphone") 'arrvalue(i).Split("|")(10)
        '            Dim strhint As String = sqls.getDataSet("cnt", i, "hint") 'arrvalue(i).Split("|")(3)
        '            Dim strrecoveryquestion As String = sqls.getDataSet("cnt", i, "recoveryquestion") 'arrvalue(i).Split("|")(4)
        '            Dim strrecoveryanswer As String = sqls.getDataSet("cnt", i, "recoveryanswer") 'arrvalue(i).Split("|")(5)

        '            mys = New SQLs(mystring)
        '            mys.DMLQuery("select iduser from " & mydb & "." & myusr & ".[user] where username='" & sqls.getDataSet("cnt", i, "username") & "'", "cekusername")

        '            Dim field As New List(Of String)
        '            Dim value As New List(Of Object)
        '            If mys.getDataSet("cekusername") > 0 Then
        '                idData = mys.getDataSet("cekusername", 0, "iduser")
        '                field.AddRange(New String() {"iduser", "username", "idtoken", "tokenkey1", "tokenkey2", "password", "hint", "recoveryquestion", "recoveryanswer", "namalengkap", "personalno", "cardtype", "email", "isemailverified", "address", "zipcode", "isaddressverified", "handphone", "ishandphoneverified", "isuserverified", "isdeleted", "deletereason", "publicv4ipaddress", "computername", "updatedby", "updateddate"})
        '            Else
        '                idData = "-1"
        '                field.AddRange(New String() {"iduser", "username", "idtoken", "tokenkey1", "tokenkey2", "password", "hint", "recoveryquestion", "recoveryanswer", "namalengkap", "personalno", "cardtype", "email", "isemailverified", "address", "zipcode", "isaddressverified", "handphone", "ishandphoneverified", "isuserverified", "isdeleted", "deletereason", "publicv4ipaddress", "computername", "createdby", "createddate"})
        '            End If
        '            myset.DMLQuery("select idtoken from " & mydb & "." & myusr & ".token where idtoken=" & sqls.getDataSet("cnt", i, "idtokenonline"), "getidtoken")
        '            idtoken = 1

        '            idtoken = sqls.getDataSet("cnt", i, "idtokenonline")
        '            If myset.getDataSetRowCount("getidtoken") > 0 Then
        '                idtoken = CInt(myset.getDataSetValue("getidtoken", 0, 0))
        '            End If

        '            value.Add(idData)
        '            value.Add(sqls.getDataSet("cnt", i, "username"))
        '            value.Add(idtoken)
        '            value.Add(sqls.getDataSet("cnt", i, "tokenkey1"))
        '            value.Add(sqls.getDataSet("cnt", i, "tokenkey2"))
        '            value.Add(sqls.getDataSet("cnt", i, "password"))
        '            value.Add(sqls.getDataSet("cnt", i, "hint"))
        '            value.Add(sqls.getDataSet("cnt", i, "recoveryquestion"))
        '            value.Add(sqls.getDataSet("cnt", i, "recoveryanswer"))
        '            value.Add(sqls.getDataSet("cnt", i, "namalengkap"))
        '            value.Add(IIf(IsDBNull(sqls.getDataSet("cnt", i, "personalno")), DBNull.Value, sqls.getDataSet("cnt", i, "personalno")))
        '            value.Add(IIf(IsDBNull(sqls.getDataSet("cnt", i, "cardtype")), DBNull.Value, sqls.getDataSet("cnt", i, "cardtype")))
        '            value.Add(sqls.getDataSet("cnt", i, "email"))
        '            value.Add(0)
        '            value.Add("-")
        '            value.Add("0")
        '            value.Add(0)
        '            value.Add(sqls.getDataSet("cnt", i, "handphone"))
        '            value.Add(0)
        '            value.Add(0)
        '            value.Add(0)
        '            value.Add("-")
        '            value.Add(ippublic)
        '            value.Add(hostname)
        '            value.Add(1)
        '            value.Add(nowTime)

        '            myset = New dtsetSQLS(mystring)
        '            Application.DoEvents()
        '            'Threading.Thread.Sleep(100)
        '            If myset.datasetSave(mydb & "." & myusr & ".[user]", idData, field, value, False) = False Then
        '                'lblLoad.Text = "UPLOAD (ERROR)"
        '            Else
        '                'lblLoad.Text = "UPLOAD (" & i & "/" & sqls.getDataSet("cnt") & ")"
        '            End If
        '        End If
        '    Next
        '    'End If
        'End If

        localcnt = 0
        sqls = New SQLs(dbstring)
        sqls.DMLQuery("select su.iduser,su.username,su.password,su.hint,su.recoveryquestion,su.recoveryanswer,su.namalengkap,su.personalno,su.cardtype,su.email,su.handphone,su.idtoken,st.idtokenonline,su.tokenkey1,su.tokenkey2 from sys_user su left join sys_token st on su.idtoken=st.idtoken where iduseronline is null", "cnt")
        localcnt = sqls.getDataSet("cnt")

        'If localcnt > 0 Then
        '    'Get ID Online
        '    'lblLoad.Text = "SYNC (0/" & sqls.getDataSet("cnt") & ")"
        '    For i As Integer = 0 To sqls.getDataSet("cnt") - 1
        '        mys = New SQLs(mystring)
        '        mysuccess = mys.DMLQuery("select iduser from " & mydb & "." & myusr & ".[user] where username='" & sqls.getDataSet("cnt", i, "username") & "'", "cekusername")

        '        If mysuccess = True Then
        '            Dim field As New List(Of String)
        '            Dim value As New List(Of Object)
        '            If mys.getDataSet("cekusername") > 0 Then
        '                idData = sqls.getDataSet("cnt", i, "iduser")

        '                field.AddRange(New String() {"iduser", "iduseronline"})
        '                value.AddRange(New Object() {idData, mys.getDataSet("cekusername", 0, "iduser")})
        '                sqlset = New dtsetSQLS(dbstring)
        '                sqlset.datasetSave("sys_user", idData, field, value, False)
        '            End If
        '        End If
        '        Application.DoEvents()
        '        'Threading.Thread.Sleep(1000)
        '        'lblLoad.Text = "SYNC (" & i & "/" & sqls.getDataSet("cnt") & ")"
        '    Next
        'End If

        isSync = False
    End Sub

    Private Sub syncToken()
        isSync = True
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

        'Dim mys As New SQLs(mystring)
        'Dim sqlset As New dtsetSQLS(dbstring)

        'Dim sqls As New SQLs(dbstring)
        'Dim localcnt As Integer = 0
        'Dim servercnt As Integer = 0
        'sqls.DMLQuery("select idtoken,idtokenonline,tokenkey1,tokenkey2,isdeleted,deletereason from sys_token order by createddate asc", "cnt")
        'mys.DMLQuery("select idtoken,tokenkey1,tokenkey2,isdeleted,deletereason from " & mydb & "." & myusr & ".token order by createddate asc", "cnt")
        'If sqls.getDataSet("cnt") > 0 Then
        '    localcnt = sqls.getDataSet("cnt")
        'End If
        'If mys.getDataSet("cnt") > 0 Then
        '    servercnt = CInt(mys.getDataSet("cnt"))
        'End If
        'If localcnt <> servercnt Then
        '    For i As Integer = 0 To mys.getDataSet("cnt") - 1
        '        Dim stridtoken As String = mys.getDataSet("cnt", i, "idtoken")
        '        Dim strtokenkey1 As String = mys.getDataSet("cnt", i, "tokenkey1")
        '        Dim strtokenkey2 As String = mys.getDataSet("cnt", i, "tokenkey2")
        '        Dim strisdeleted As String = mys.getDataSet("cnt", i, "isdeleted")
        '        Dim strdeletereason As String = mys.getDataSet("cnt", i, "deletereason")
        '        Dim strcreatedby As String = mys.getDataSet("cnt", i, "createdby")
        '        Dim strcreateddate As String = mys.getDataSet("cnt", i, "created")
        '        Dim dtcreateddate As Date = strdatetime2datetime(strcreateddate)

        '        Dim field As New List(Of String)
        '        Dim value As New List(Of Object)

        '        field.AddRange(New String() {"idtoken", "idtokenonline", "tokenkey1", "tokenkey2", "isdeleted", "deletereason", "createdby", "createddate"})
        '        sqls.DMLQuery("select idtoken from sys_token where idtokenonline=" & stridtoken, "getid")
        '        If sqls.getDataSet("getid") = 0 Then
        '            idData = "-1"
        '            value.Add(-1)
        '        Else
        '            idData = sqls.getDataSet("getid", i, "idtoken")
        '            value.Add(sqls.getDataSet("getid", i, "idtoken"))
        '        End If
        '        value.Add(stridtoken) 'MYs.getDataSet("cnt", i, "idtoken"))
        '        value.Add(strtokenkey1) 'MYs.getDataSet("cnt", i, "tokenkey1"))
        '        value.Add(strtokenkey2) 'MYs.getDataSet("cnt", i, "tokenkey2"))
        '        value.Add(strisdeleted) 'MYs.getDataSet("cnt", i, "isdeleted"))
        '        value.Add(strdeletereason) 'MYs.getDataSet("cnt", i, "deletereason"))
        '        value.Add(1)
        '        value.Add(nowTime)
        '        sqlset.datasetSave("sys_token", idData, field, value, False)
        '        Application.DoEvents()
        '        'Threading.Thread.Sleep(100)
        '        'lblLoad.Text = "TOKEN (" & i & "/" & servercnt & ")"
        '        If i = servercnt - 1 Then
        '            Dim sqli As New SQLi(dblite)
        '            sqli.DMLQuery("update appsetting set value='" & stridtoken & "' where variable='TokenID'", False) 'MYs.getDataSet("cnt", i, "idtoken") 
        '            sqli.DMLQuery("update appsetting set value='" & strtokenkey1 & "' where variable='TokenKey1'", False) 'MYs.getDataSet("cnt", i, "tokenkey1")
        '            sqli.DMLQuery("update appsetting set value='" & strtokenkey2 & "' where variable='TokenKey2'", False) 'MYs.getDataSet("cnt", i, "tokenkey2")

        '            idtoken = stridtoken 'MYs.getDataSet("cnt", i, "idtoken")
        '            tokenkey1 = strtokenkey1 'MYs.getDataSet("cnt", i, "tokenkey1")
        '            tokenkey2 = strtokenkey2 'MYs.getDataSet("cnt", i, "tokenkey2")
        '        End If
        '    Next
        'End If
        isSync = False
    End Sub

    Private Function existUsername(ByVal username As String) As Integer
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

        'Dim mys As New MYs(mystring)
        Dim retval As Integer = -1

        'If mys.checkConnection() = True Then
        '    mys.DMLQuery("select iduser from " & mydb & "." & myusr & ".[user] where username='" & username & "'", "cekUsername")
        '    If mys.getDataSet("cekUsername") > 0 Then
        '        retval = mys.getDataSet("cekUsername", 0, "iduser")
        '    End If
        'End If
        Return retval
    End Function

    Dim isSync As Boolean = False
    Dim imgMemoryStream As IO.MemoryStream = New IO.MemoryStream()
    Dim imgByteArray As Byte() = Nothing
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim img As Image = My.Resources.defprofile200
        If checkEntry(tlpAdministrator) = False Or checkEntry(tlpPengguna) = False Or (checkEntry(tlpAdministrator) = False And checkEntry(tlpPengguna) = False) Then
            If statData = statusData.Baru And tePassword.Text = "" Then
                dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            End If
            Exit Sub
        End If
        If statData = statusData.Baru Then
            If teUsername.Text.Replace(" ", "").ToLower = "superadmin" Then
                dizMsgbox("Username tidak boleh superadmin", dizMsgboxStyle.Info, Me)
                teUsername.Focus()
                Exit Sub
            End If
            If existUsername(teUsername.Text) > -1 Then
                dizMsgbox("Username sudah ada", dizMsgboxStyle.Info, Me)
                teUsername.Focus()
                Exit Sub
            End If
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select username from sys_user where replace(username,' ','')='" & teUsername.Text.Replace(" ", "") & "'", "cekusername")
            If sqls.getDataSet("cekusername") = 0 Then
                idData = "-1"
            Else
                dizmsgbox("Username tersebut sudah ada", dizMsgboxStyle.info, Me)
                teUsername.Focus()
                Exit Sub
            End If
        End If
        Dim dtSQL As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        If statData = statusData.Baru Then
            idData = GenerateGUID()
            dtSQL = New dtsetSQLS(dbstring)
            field.Clear()
            field.AddRange(New String() {"iduser", "iduserlevel", "userstatus", "username", "idtoken", "tokenkey1", "tokenkey2", "password", "namalengkap", "email", "handphone", "hint", "recoveryquestion", "recoveryanswer", "bannedreason", "waktucek", "isdeleted", "isuseronline"})
            value.Clear()
            Dim passval As String = GeneratePass("0000", tokenkey1, tokenkey2, 8000)
            value.AddRange(New Object() {idData, If(lueLevel.EditValue, CObj(DBNull.Value)), If(lueStatus.EditValue, CObj(DBNull.Value)), teUsername.Text, idtoken, tokenkey1, tokenkey2, passval, teNama.Text, teEmail.Text, teHandphone.Text, teHint.Text, teRecQuestion.Text, teRecAnswer.Text, If(teReason.EditValue, "-"), nowTime, 0, 0})
            If dtSQL.datasetSave("sys_user", idData, field, value, False) = True Then
                isiLog(userid, dbstring, field, value, "sys_user")
                Dim mysqls As New SQLs(dbstring)
                img.Save(imgMemoryStream, System.Drawing.Imaging.ImageFormat.Png)
                imgByteArray = imgMemoryStream.GetBuffer()
                Dim idimages As String = GenerateGUID()

                dtSQL = New dtsetSQLS(dbstring)
                field.Clear()
                field.AddRange(New String() {"idimages", "datetime", "filename", "sizewidth", "sizeheight", "images"})
                value.Clear()
                value.AddRange(New Object() {idimages, nowTime, "defPP" & idData & ".png", img.Size.Width, img.Size.Height, imgByteArray})
                dtSQL.datasetSave("sys_images", idimages, field, value, False)

                Dim idtmp As String = GenerateGUID()
                dtSQL = New dtsetSQLS(dbstring)
                field.Clear()
                field.AddRange(New String() {"iduserimages", "idimages", "iduser", "description", "asprofile", "isdeleted"})
                value.Clear()
                value.AddRange(New String() {idtmp, idimages, idData, "default", 1, 0})
                dtSQL.datasetSave("sys_userimages", idtmp, field, value, False)
                isiLog(userid, dbstring, field, value, "sys_userimages")

                dizMsgbox("Data Pengguna telah tersimpan", dizMsgboxStyle.Info, Me)
            End If
        Else
            If tePassword.Text = "" Then
                field.AddRange(New String() {"iduser", "iduserlevel", "userstatus", "username", "namalengkap", "email", "handphone", "hint", "recoveryquestion", "recoveryanswer", "bannedreason", "isdeleted"})
                value.AddRange(New Object() {idData, If(lueLevel.EditValue, CObj(DBNull.Value)), If(lueStatus.EditValue, CObj(DBNull.Value)), teUsername.Text, teNama.Text, teEmail.Text, teHandphone.Text, teHint.Text, teRecQuestion.Text, teRecAnswer.Text, If(teReason.EditValue, "-"), 0})
                If dtSQL.datasetSave("sys_user", idData, field, value, False) = True Then
                    dizMsgbox("Data Pengguna telah tersimpan", dizMsgboxStyle.Info, Me)
                End If
            Else
                Dim sqls As New SQLs(dbstring)
                sqls.DMLQuery("select tokenkey1,tokenkey2 from sys_user where iduser='" & idData & "'", "gettoken")
                Dim tmptoken1 As String = sqls.getDataSet("gettoken", 0, "tokenkey1")
                Dim tmptoken2 As String = sqls.getDataSet("gettoken", 0, "tokenkey2")
                Dim passval As String = generatePass(tePassword.Text, tmptoken1, tmptoken2, 8000)
                field.AddRange(New String() {"iduser", "iduserlevel", "userstatus", "username", "password", "namalengkap", "email", "handphone", "hint", "recoveryquestion", "recoveryanswer", "bannedreason", "isdeleted"})
                value.AddRange(New Object() {idData, If(lueLevel.EditValue, CObj(DBNull.Value)), If(lueStatus.EditValue, CObj(DBNull.Value)), teUsername.Text, passval, teNama.Text, teEmail.Text, teHandphone.Text, teHint.Text, teRecQuestion.Text, teRecAnswer.Text, If(teReason.EditValue, "-"), 0})
                If dtSQL.datasetSave("sys_user", idData, field, value, False) = True Then
                    dizMsgbox("Data Pengguna telah tersimpan", dizMsgboxStyle.Info, Me)
                End If
            End If
        End If
        btnNew_Click(Me, Nothing)
    End Sub

    Private Sub teUsername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles teUsername.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rVarchar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        Dim dr As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
        idData = dr("iduser")
        lueLevel.EditValue = dr("iduserlevel")
        lueStatus.EditValue = dr("userstatus")
        teUsername.Text = dr("username")
        tePassword.Text = ""
        teNama.Text = dr("namalengkap")
        teEmail.Text = dr("email")
        teHandphone.Text = dr("handphone")
        teReason.Text = dr("reason")
        teLastCheck.Text = IIf(IsDBNull(dr("waktucek")), "-", dr("waktucek"))

        Dim drt As DataRow
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select hint,recoveryquestion,recoveryanswer from sys_user where iduser='" & idData & "'", "cekuser")
        drt = mysqls.dataTable("cekuser").Rows(0)
        teHint.Text = drt("hint")
        teRecQuestion.Text = drt("recoveryquestion")
        teRecAnswer.Text = drt("recoveryanswer")

        teUsername.Enabled = False
        teUsername.Properties.ReadOnly = True
        teUsername.BackColor = justRead

        statData = statusData.Edit

        tePassword.Enabled = True
        tePassword.Properties.ReadOnly = False
        tePassword.BackColor = canWrite
    End Sub

    Private ippublic As String = ""
    Private mystring As String = ""
    Private mydb As String = ""
    Private mysvr As String = ""
    Private myport As String = "0"
    Private myusr As String = ""
    Private mypass As String = ""
    Private bClose As Boolean = False
    Private Sub frmAdministrator_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = bClose
    End Sub

    Private Sub frmAdministrator_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)

        bClose = False
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

        If isLocalhost() = True Then
            isserver = True
            lblLoad.Visible = True
            lblLoad.Text = "SYNC USER TO DATACENTER"
            ippublic = GetIPPublic()
        Else
            isServer = False
            lblLoad.Visible = False
            lblLoad.Text = ""
        End If
        checkFieldMaxLength(dbstring, tlpAdministrator, "sys_user")
        checkFieldMaxLength(dbstring, tlpPengguna, "sys_user")
        loadLOV()
        tmrCounter.Start()
        btnNew_Click(Me, Nothing)
    End Sub

    Private Sub lueStatus_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueStatus.EditValueChanged
        If lueStatus.Text = "Banned" Then
            teReason.Properties.ReadOnly = False
            teReason.BackColor = canWrite
            teReason.Text = "Tdk Diketahui"
        Else
            teReason.Properties.ReadOnly = True
            teReason.BackColor = justRead
            teReason.Text = "-"
        End If
    End Sub

    Private Sub btnMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenu.Click
        If usersuper = 1 Then
            Dim menu As New frmMenu
            menu.ShowDialog()
        Else
            dizMsgbox("Anda tidak memiliki hak akses ini", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

    Private Sub btnAuthorization_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuthorization.Click
        If usersuper = 1 Then
            Dim auth As New frmAuthentication
            auth.ShowDialog()
            loadLOV()

            btnNew_Click(Me, Nothing)
        Else
            dizMsgbox("Anda tidak memiliki hak akses ini", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

    Private Sub btnSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetting.Click
        If usersuper = 1 Then
            Dim appset As New frmAppPDABSetting
            appset.ShowDialog()
        Else
            dizMsgbox("Anda tidak memiliki hak akses ini", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

    Private Sub teHandphone_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles teHandphone.EditValueChanged
        If teHandphone.EditValue Is Nothing Then
            teHandphone.EditValue = 0
        Else
            If teHandphone.Text = "" Then
                teHandphone.Text = 0
            End If
        End If
    End Sub

    Private Sub teHandphone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles teHandphone.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rNumeric) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub tmrCounter_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCounter.Tick
        'If isSync = False Then bwServer.RunWorkerAsync()
    End Sub

    Private Sub bwServer_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bwServer.DoWork
        sync()
        If bwServer.IsBusy = False Then
            bwServer.RunWorkerAsync()
        End If
        If bwServer.CancellationPending = True Then
            bwServer.RunWorkerAsync()
        End If
    End Sub

    Private Sub teEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teEmail.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rEmail) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnDevice_Click(sender As Object, e As EventArgs) Handles btnDevice.Click
        If usersuper = 1 Then
            Dim dev As New frmDevice
            dev.ShowDialog()
        Else
            dizMsgbox("Anda tidak memiliki hak akses ini", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

    Private Sub btnAppDevice_Click(sender As Object, e As EventArgs) Handles btnAppDevice.Click
        If usersuper = 1 Then
            Dim dev As New frmAppDevice
            dev.ShowDialog()
        Else
            dizMsgbox("Anda tidak memiliki hak akses ini", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

End Class
