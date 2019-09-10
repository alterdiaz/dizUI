Public Class frmChangeHardware
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
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
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

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private mysite As String = ""
    'Private mystring As String = ""
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)

        If tmpUserID = "-1" Then
            texUsername.Text = ""
            texPassword.Text = ""
            btnUserCheck.Enabled = True
            panelLogin.Visible = True
            panelLogin.BringToFront()
            tlpEntry.Visible = False
            btnSave.Enabled = False
            tlpEntry.SendToBack()
        End If

        idData = "-1"
        Dim lite As New SQLi(dblite)
        'lite.DMLQuery("select databasename || '|' || ipserver || '|' || port || '|' || username || '|' || password as dbstring from dbconn where dbtype='SQLS' and dblocation='DOMAIN'", "getdbstring")
        'If lite.getDataSet("getdbstring") > 0 Then
        '    mystring = lite.getDataSet("getdbstring", 0, "dbstring")
        'End If
        lite.DMLQuery("select siteurl from siteconn where active=1 order by idsiteconn desc", "getdbstring")
        If lite.getDataSet("getdbstring") > 0 Then
            'mystring = lite.getDataSet("getdbstring", 0, "dbstring")
            mysite = lite.getDataSet("getdbstring", 0, "siteurl")
            mysite = CheckAndRepairValidURL(mysite)
        End If

        'Dim sqls As New SQLs(mystring)
        'sqls.DMLQuery("select convert(varchar,getdate(),105) as tanggal,convert(varchar,getdate(),108) as waktu", "content")
        'If sqls.getDataSet("content") > 0 Then 'strvalue.Contains("ERROR") = False Then
        '    Dim tmptgl As String = sqls.getDataSet("content", 0, "tanggal") 'strvalue.Split(" ")(0)
        '    Dim tmpwaktu As String = sqls.getDataSet("content", 0, "waktu") 'strvalue.Split(" ")(1)
        '    tmpnowTime = Strdatetime2Datetime(tmptgl & " " & tmpwaktu)
        'Else
        '    tmpnowTime = Now
        'End If

        Dim json_result As String = ""
        Dim table As DataTable = Nothing
        Dim mparam As New List(Of String)
        Dim mvalue As New List(Of String)
        mparam.AddRange(New String() {"param", "tkey1", "tkey2"})
        mvalue.AddRange(New String() {"currentdatetime", tmptokenkey1, tmptokenkey2})
        json_result = modCore.HttpPOSTRequestSelect(mysite & "Core", mparam, mvalue)
        If json_result.Length > 2 Then 'table.Rows.Count > 0 Then 'strvalue.Contains("ERROR") = False Then
            table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
            Dim tmptgl As String = table.Rows(0).Item("tanggal") 'strvalue.Split(" ")(0)
            Dim tmpwaktu As String = table.Rows(0).Item("waktu") 'strvalue.Split(" ")(1)
            tmpnowTime = Strdatetime2Datetime(tmptgl & " " & tmpwaktu)
        Else
            tmpnowTime = nowTime
        End If

        'sqls = New SQLs(mystring)
        'sqls.DMLQuery("select top 1 idtoken,tokenkey1,tokenkey2 from token order by createddate desc", "content")
                        If table IsNot Nothing Then table.Clear()
        json_result = modCore.HttpPOSTRequestSelect(mysite & "CurrentToken")
        If json_result.Length > 2 Then 'table.Rows.Count > 0 Then 'IsNumeric(strvalue) = False Then 'MYs.getDataSet("token") > 0 Then
            table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
            tmpidtoken = table.Rows(0).Item("idtoken")
            tmptokenkey1 = table.Rows(0).Item("tokenkey1")
            tmptokenkey2 = table.Rows(0).Item("tokenkey2")
            'MYs.getDataSet("token", 0, "idtoken")
            'MYs.getDataSet("token", 0, "tokenkey1")
            'MYs.getDataSet("token", 0, "tokenkey2")
        Else
            tmpidtoken = "E82EC129-868C-4FEB-9AEB-0ADB46428F1E"
            tmptokenkey1 = "ABF"
            tmptokenkey2 = "123"
        End If
        idtoken = tmpidtoken
        tokenkey1 = tmptokenkey1
        tokenkey2 = tmptokenkey2

        tePerusahaanPIN.EditValue = Nothing
        teNamaPerusahaan.EditValue = Nothing
        teNamaPerusahaan.Tag = ""
        teKodeHardware.EditValue = Nothing

        tmphardwareid = getBoardID()

        Dim idhw As String = -1

        json_result = ""
                        If table IsNot Nothing Then table.Clear()
        mparam.Clear()
        mvalue.Clear()
        mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2", "hardwareid"})
        mvalue.AddRange(New String() {"cekhwid", "", tmptokenkey1, tmptokenkey2, tmphardwareid})
        json_result = modCore.HttpPOSTRequestSelect(mysite & "Hardware", mparam, mvalue)

        'SQLs.DMLQuery("select idhardware,idtoken,tokenkey1,tokenkey2 from hardware where hardwareid='" & tmphardwareid & "'", "idhw")
        If json_result.Length > 2 Then 'table.Rows.Count > 0 Then 'sqls.getDataSet("idhw") > 0 Then
            table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
            idhw = table.Rows(0).Item("idhardware") 'SQLs.getDataSet("idhw", 0, "idhardware")

            tmpidtoken = table.Rows(0).Item("idtoken") 'SQLs.getDataSet("idhw", 0, "idtoken")
            tmptokenkey1 = table.Rows(0).Item("tokenkey1") 'SQLs.getDataSet("idhw", 0, "tokenkey1")
            tmptokenkey2 = table.Rows(0).Item("tokenkey2") 'SQLs.getDataSet("idhw", 0, "tokenkey2")
        End If

        tmphardwarecode = getHardwareCode(tmphardwareid, tokenkey1, tokenkey2)
        teKodeHardware.Tag = tmphardwareid
        teKodeHardware.EditValue = tmphardwarecode
    End Sub

    Private Sub btnExistCompany_Click(sender As Object, e As EventArgs) Handles btnExistCompany.Click
        Dim json_result As String = ""
        Dim table As DataTable = Nothing
        Dim mparam As New List(Of String)
        Dim mvalue As New List(Of String)
        mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2", "companycode"})
        mvalue.AddRange(New String() {"cekcode", "", tmptokenkey1, tmptokenkey2, tePerusahaanPIN.EditValue})
        json_result = modCore.HttpPOSTRequestSelect(mysite & "Company", mparam, mvalue)

        'Dim sqlss As New SQLs(mystring)
        'sqlss.DMLQuery("select idcompany,companyofficialname from company where companycode='" & tePerusahaanPIN.Text & "'", "getperusahaan")

        If json_result.Length > 2 Then 'table.Rows.Count > 0 Then 'sqlss.getDataSet("getperusahaan") > 0 Then
            table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
            teNamaPerusahaan.Tag = table.Rows(0).Item("idcompany") 'sqlss.getDataSet("getperusahaan", 0, "idcompany")
            teNamaPerusahaan.EditValue = table.Rows(0).Item("companyofficialname") 'sqlss.getDataSet("getperusahaan", 0, "companyofficialname")
        Else
            dizMsgbox("Perusahaan tidak ditemukan", dizMsgboxStyle.Peringatan, me)
            teNamaPerusahaan.Tag = ""
            teNamaPerusahaan.EditValue = Nothing
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim bcek As Boolean = True
        If teNamaPerusahaan.Tag = "" Then
            bcek = False
        End If
        If bcek = False Then
            dizMsgbox("Produk / Perusahaan tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim json_result As String = ""
        Dim table As DataTable = Nothing
        Dim mparam As New List(Of String)
        Dim mvalue As New List(Of String)
        'mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2", "idcompany"})
        'mvalue.AddRange(New String() {"cekcomp", "", tmptokenkey1, tmptokenkey2, teNamaPerusahaan.Tag})
        'json_result = modCore.HttpPOSTRequestSelect(mysite & "CompanyProduct", mparam, mvalue)

        'Dim sqls As New SQLs(mystring)
        'SQLs.DMLQuery("select idcompanyproduct from companyproduct where idcompany='" & teNamaPerusahaan.Tag & "' and idproduct='" & teNamaProduk.Tag & "'", "getcp")
        'Dim idcp As String = "-1"
        'If json_result.Length > 2 Then 'table.Rows.Count > 0 Then 'sqls.getDataSet("getcp") > 0 Then
        '    table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
        '    idcp = table.Rows(0).Item("idcompanyproduct") 'SQLs.getDataSet("getcp", 0, "idcompanyproduct")
        'Else
        '    dizMsgbox("Produk / Perusahaan tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
        '    Exit Sub
        'End If

        json_result = ""
        If table IsNot Nothing Then table.Clear()
        mparam.Clear()
        mvalue.Clear()
        mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2", "hardwareid"})
        mvalue.AddRange(New String() {"cekhwid", "", tmptokenkey1, tmptokenkey2, tmphardwareid})
        json_result = modCore.HttpPOSTRequestSelect(mysite & "Hardware", mparam, mvalue)
        Dim idhw As String = "-1"
        'sqls.DMLQuery("select idhardware,idtoken,tokenkey1,tokenkey2 from hardware where hardwareid='" & tmphardwareid & "'", "idhw")
        If json_result.Length > 2 Then 'table.Rows.Count > 0 Then 'sqls.getDataSet("idhw") > 0 Then
            table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
            idhw = table.Rows(0).Item("idhardware") 'SQLs.getDataSet("idhw", 0, "idhardware")
        End If

        Dim lite As New SQLi(dblite)
        If idhw = "-1" Then
            idhw = GenerateGUID()
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            'Dim sqlset As New dtsetSQLS(mystring)
            field.AddRange(New String() {"idhardware", "hardwareid", "idtoken", "tokenkey1", "tokenkey2", "hardwarecode", "createdby", "createddate"})
            value.AddRange(New Object() {idhw, tmphardwareid, tmpidtoken, tmptokenkey1, tmptokenkey2, tmphardwarecode, tmpUserID, Format(nowTime, "yyyy-MM-dd HH:mm:ss")})
            'sqlset.datasetSave("hardware", idhw, field, value, False)

            json_result = ""
            If table IsNot Nothing Then table.Clear()
            mparam.Clear()
            mvalue.Clear()
            mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2"})
            mvalue.AddRange(New String() {"baru", idhw, tmptokenkey1, tmptokenkey2})
            mparam.AddRange(field)
            mvalue.AddRange(value)
            json_result = modCore.HttpPOSTRequestInsert(mysite & "Hardware", mparam, mvalue)
        Else
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            'Dim sqlset As New dtsetSQLS(mystring)
            field.AddRange(New String() {"idhardware", "hardwareid", "idtoken", "tokenkey1", "tokenkey2", "hardwarecode", "createdby", "createddate"})
            value.AddRange(New Object() {idhw, tmphardwareid, tmpidtoken, tmptokenkey1, tmptokenkey2, tmphardwarecode, tmpUserID, Format(nowTime, "yyyy-MM-dd HH:mm:ss")})
            'sqlset.datasetSave("hardware", idhw, field, value, False)

            json_result = ""
            If table IsNot Nothing Then table.Clear()
            mparam.Clear()
            mvalue.Clear()
            mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2"})
            mvalue.AddRange(New String() {"edit", idhw, tmptokenkey1, tmptokenkey2})
            mparam.AddRange(field)
            mvalue.AddRange(value)
            json_result = modCore.HttpPOSTRequestInsert(mysite & "Hardware", mparam, mvalue)
        End If

        json_result = ""
        If table IsNot Nothing Then table.Clear()
        mparam.Clear()
        mvalue.Clear()
        mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2", "hardwareid"})
        mvalue.AddRange(New String() {"cekhwid", "", tmptokenkey1, tmptokenkey2, tmphardwareid})
        json_result = modCore.HttpPOSTRequestSelect(mysite & "Hardware", mparam, mvalue)
        table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
        'SQLs.DMLQuery("select idhardware,idtoken,tokenkey1,tokenkey2 from hardware where hardwareid='" & tmphardwareid & "'", "idhw1")
        idhw = table.Rows(0).Item("idhardware") 'SQLs.getDataSet("idhw1", 0, "idhardware")
        tmpidtoken = table.Rows(0).Item("idtoken") 'SQLs.getDataSet("idhw1", 0, "idtoken")
        tmptokenkey1 = table.Rows(0).Item("tokenkey1") 'SQLs.getDataSet("idhw1", 0, "tokenkey1")
        tmptokenkey2 = table.Rows(0).Item("tokenkey2") 'SQLs.getDataSet("idhw1", 0, "tokenkey2")

        json_result = ""
        If table IsNot Nothing Then table.Clear()
        mparam.Clear()
        mvalue.Clear()
        mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2", "idhardware"})
        mvalue.AddRange(New String() {"sethw", tmpidcompany, tmptokenkey1, tmptokenkey2, idhw})
        json_result = modCore.HttpPOSTRequestSelect(mysite & "Company", mparam, mvalue)
        table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)

        lite.DMLQuery("update appsetting set value='" & idhw & "' where variable='HardwareID'", False)
        tmphardwareid = getBoardID()
        tmphardwarecode = getHardwareCode(tmphardwareid, tmptokenkey1, tmptokenkey2)
        teKodeHardware.Tag = tmphardwareid
        teKodeHardware.EditValue = tmphardwarecode
        lite.DMLQuery("update appsetting set value='" & tmphardwarecode & "' where variable='HardwareCode'", False)
        dizMsgbox("Data Hardware telah tersimpan", dizMsgboxStyle.Info, Me)
        Me.Dispose()
    End Sub

    Private Sub btnUserCheck_Click(sender As Object, e As EventArgs) Handles btnUserCheck.Click
        Me.Cursor = Cursors.WaitCursor
        'Dim sqls As New SQLs(mystring)

        Dim json_result As String = ""
        Dim table As DataTable = Nothing
        Dim mparam As New List(Of String)
        Dim mvalue As New List(Of String)
        mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2", "username"})
        mvalue.AddRange(New String() {"cekusername", "", tmptokenkey1, tmptokenkey2, texUsername.EditValue})
        json_result = modCore.HttpPOSTRequestSelect(mysite & "User", mparam, mvalue)
        'SQLs.DMLQuery("select iduser,idtoken,tokenkey1,tokenkey2,password from [user] where username='" & texUsername.Text & "'", "user")
        If json_result.Length > 2 Then 'table.Rows.Count > 0 Then 'sqls.getDataSet("user") > 0 Then
            table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
            tmpidtoken = table.Rows(0).Item("idtoken") 'SQLs.getDataSet("user", 0, "idtoken")
            tmptokenkey1 = table.Rows(0).Item("tokenkey1") ' SQLs.getDataSet("user", 0, "tokenkey1")
            tmptokenkey2 = table.Rows(0).Item("tokenkey2") 'SQLs.getDataSet("user", 0, "tokenkey2")
            Dim tmppassword As String = table.Rows(0).Item("password") ' SQLs.getDataSet("user", 0, "password")
            Dim strpassword As String = GeneratePass(texPassword.Text, tmptokenkey1, tmptokenkey2, 8000)
            If tmppassword = strpassword Then
                json_result = ""
                If table IsNot Nothing Then table.Clear()
                mparam.Clear()
                mvalue.Clear()
                mparam.AddRange(New String() {"param", "value", "tkey1", "tkey2", "username"})
                mvalue.AddRange(New String() {"cekusername", "", tmptokenkey1, tmptokenkey2, texUsername.EditValue})
                json_result = modCore.HttpPOSTRequestSelect(mysite & "User", mparam, mvalue)

                'SQLs.DMLQuery("select iduser,namalengkap,personalno,cardtype,address,zipcode,email,handphone,hint,recoveryquestion,recoveryanswer,username,password from [user] where username='" & texUsername.Text & "'", "useronline")
                If json_result.Length > 2 Then
                    table = Newtonsoft.Json.JsonConvert.DeserializeObject(Of DataTable)(json_result)
                    tmpUserID = table.Rows(0).Item("iduser") 'SQLs.getDataSet("useronline", 0, "iduser")
                End If
                tmpUserFromOnline = True
                Me.Cursor = Cursors.Default

                texUsername.Text = ""
                texPassword.Text = ""
                btnUserCheck.Enabled = False
                panelLogin.Visible = False
                panelLogin.SendToBack()
                tlpEntry.Visible = True

                btnSave.Enabled = True
                tlpEntry.BringToFront()
            Else
                tmpUserFromOnline = False
                dizMsgbox("Password tidak valid", dizMsgboxStyle.Info, Me)
                texPassword.Focus()
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
        Else
            tmpUserFromOnline = False
            dizMsgbox("Pengguna tidak ditemukan", dizMsgboxStyle.Info, Me)
            texUsername.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
    End Sub

End Class