Public Class frmNewProfile
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

    Private Sub teEmail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles teEmail.GotFocus, teHandphone.GotFocus, teHint.GotFocus, teNamaLengkap.GotFocus, tePassword.GotFocus, teRecAns.GotFocus, teRecQuest.GotFocus, teUsername.GotFocus, btnSave.GotFocus, teID.GotFocus, lueJenis.GotFocus, teAlamat.GotFocus, teKodepos.GotFocus
        If sender Is teUsername Then
            lblInfo.Visible = True
            lblInfo.Text = "Username digunakan untuk login"
        ElseIf sender Is tePassword Then
            lblInfo.Visible = True
            lblInfo.Text = "Password digunakan untuk login"
        ElseIf sender Is teID Then
            lblInfo.Visible = True
            lblInfo.Text = "No Identitas untuk identifikasi pengguna"
        ElseIf sender Is lueJenis Then
            lblInfo.Visible = True
            lblInfo.Text = "Jenis Kartu Identitas untuk identifikasi pengguna"
        ElseIf sender Is teEmail Then
            lblInfo.Visible = True
            lblInfo.Text = "Email digunakan untuk menerima password" & vbCrLf & "jika anda lupa password"
        ElseIf sender Is teAlamat Then
            lblInfo.Visible = True
            lblInfo.Text = "Alamat tempat tinggal sekarang" & vbCrLf & "Mulai nama jalan, nomor rumah, kecamatan, kota/kabupaten"
        ElseIf sender Is teKodepos Then
            lblInfo.Visible = True
            lblInfo.Text = "Kodepos tempat tinggal sekarang"
        ElseIf sender Is teHandphone Then
            lblInfo.Visible = True
            lblInfo.Text = "Handphone digunakan untuk identifikasi pengguna"
        ElseIf sender Is teHint Then
            lblInfo.Visible = True
            lblInfo.Text = "Hint digunakan untuk petunjuk" & vbCrLf & "anda lupa password"
        ElseIf sender Is teNamaLengkap Then
            lblInfo.Visible = True
            lblInfo.Text = "Nama Lengkap digunakan untuk data pengguna"
        ElseIf sender Is teRecAns Then
            lblInfo.Visible = True
            lblInfo.Text = "Recovery Answer digunakan untuk petunjuk" & vbCrLf & "anda lupa password"
        ElseIf sender Is teRecQuest Then
            lblInfo.Visible = True
            lblInfo.Text = "Recovery Question digunakan untuk petunjuk" & vbCrLf & "anda lupa password"
        Else
            lblInfo.Visible = False
            lblInfo.Text = ""
        End If
    End Sub

    Private Function cekIsian() As Boolean
        Dim retval As Boolean = True
        If teID.Text = "" Then
            retval = False
        End If
        If getNumber(getNoSpace(teID.Text)) = "" Then
            retval = False
        End If
        If teNamaLengkap.Text = "" Then
            retval = False
        End If
        If teAlamat.Text = "" Then
            retval = False
        End If
        If teKodepos.Text = "" Then
            retval = False
        End If
        If IsNumeric(teKodepos.Text) Then
            If CInt(teKodepos.Text) = 0 Then
                retval = False
            End If
        End If
        If teEmail.Text = "" Then
            retval = False
        End If
        If isEmail(teEmail.Text) = False Then
            retval = False
        End If
        If teHandphone.Text = "" Then
            retval = False
        End If
        If teHandphone.Text = "0" Then
            retval = False
        End If
        If lueJenis.EditValue Is Nothing Then
            retval = False
        End If
        If teHint.Text = "" Then
            retval = False
        End If
        If teRecQuest.Text = "" Then
            retval = False
        End If
        If teRecAns.Text = "" Then
            retval = False
        End If
        If teUsername.Text = "" Then
            retval = False
        End If
        If tePassword.Text = "" Then
            retval = False
        End If
        Return retval
    End Function

    Private Function existUsernameOnline(ByVal username As String) As Integer
        Dim sqls As New SQLs(mystring)
        Dim retval As Integer = -1
        If sqls.checkConnection() = True Then
            sqls.DMLQuery("select iduser from [user] where username='" & username & "'", "cekUsername")
            If sqls.getDataSet("cekUsername") > 0 Then
                retval = sqls.getDataSet("cekUsername", 0, "iduser")
            End If
        End If
        Return retval
    End Function

    Private Function existUsernameOffline(ByVal username As String) As Integer
        Dim sqls As New SQLs(dbstring)
        Dim retval As Integer = -1
        If sqls.checkConnection() = True Then
            sqls.DMLQuery("select iduser from sys_user where username='" & username & "'", "cekUsername")
            If sqls.getDataSet("cekUsername") > 0 Then
                retval = sqls.getDataSet("cekUsername", 0, "iduser")
            End If
        End If
        Return retval
    End Function

    Private statData As statusData = statusData.Baru
    Private idData As Long = -1

    Dim imgMemoryStream As IO.MemoryStream = New IO.MemoryStream()
    Dim imgByteArray As Byte() = Nothing
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Cursor = Cursors.WaitCursor

        If cekIsian() = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        If teUsername.Text.Replace(" ", "").ToLower = "superadmin" Then
            dizmsgbox("Username tidak boleh superadmin", dizMsgboxStyle.info, Me)
            teUsername.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        If tmpUserFromOnline = False Then
            If existUsernameOnline(teUsername.Text) > -1 Then
                dizMsgbox("Username tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teUsername.Focus()
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
        End If

        Dim iduserstatus As Integer = 0
        Dim iduserlevel As Integer = 0
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select username,iduser,iduserlevel,iduserstatus from sys_user where replace(username,' ','')='" & teUsername.Text.Replace(" ", "") & "'", "cekusername")
        If sqls.getDataSet("cekusername") = 0 Then
            idData = -1
        Else
            idData = sqls.getDataSet("cekusername", 0, "iduser")
            iduserstatus = sqls.getDataSet("cekusername", 0, "iduserstatus")
            iduserlevel = sqls.getDataSet("cekusername", 0, "iduserlevel")
        End If
        If idData = -1 Then
            sqls.DMLQuery("select idgeneral as idstatusdata from sys_generalcode where gctype='USER' and generalcode='Inactive'", "iduserstatus")
            If sqls.getDataSet("iduserstatus") > 0 Then
                iduserstatus = sqls.getDataSet("iduserstatus", 0, "idstatusdata")
            End If
            sqls.DMLQuery("select iduserlevel from sys_userlevel where userlevel='Guest'", "iduserlevel")
            If sqls.getDataSet("iduserlevel") > 0 Then
                iduserlevel = sqls.getDataSet("iduserlevel", 0, "iduserlevel")
            End If
        End If

        Dim dtSQL As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        Dim sqlss As New SQLs(mystring)
        If tmpUserFromOnline = False Then
            sqlss.DMLQuery("select top 1 idtoken,tokenkey1,tokenkey2 from token order by createddate desc", "lasttoken")
            If sqlss.getDataSet("lasttoken") > 0 Then 'strvalue.Contains("ERROR") = True Then
                tmpidtoken = sqlss.getDataSet("lasttoken", 0, "idtoken") 'strvalue.Split("|")(0)
                tmptokenkey1 = sqlss.getDataSet("lasttoken", 0, "tokenkey1") 'strvalue.Split("|")(1)
                tmptokenkey2 = sqlss.getDataSet("lasttoken", 0, "tokenkey2") 'strvalue.Split("|")(2)
            Else
                tmpidtoken = 1
                tmptokenkey1 = "ABF"
                tmptokenkey2 = "123"
            End If

            sqlss.DMLQuery("select convert(varchar,getdate(),105) as tanggal,convert(varchar,getdate(),108) as waktu", "content")
            If sqlss.getDataSet("content") > 0 Then 'strvalue.Contains("ERROR") = False Then
                Dim tmptgl As String = sqlss.getDataSet("content", 0, "tanggal") 'strvalue.Split(" ")(0)
                Dim tmpwaktu As String = sqlss.getDataSet("content", 0, "waktu") 'strvalue.Split(" ")(1)
                tmpnowTime = New Date(tmptgl.Split("-")(2), tmptgl.Split("-")(1), tmptgl.Split("-")(0), tmpwaktu.Split(":")(0), tmpwaktu.Split(":")(1), tmpwaktu.Split(":")(2))
            Else
                tmpnowTime = Now
            End If
        End If
        Dim passval As String = GeneratePass(tePassword.Text, tmptokenkey1, tmptokenkey2, 8000)

        dtSQL = New dtsetSQLS(dbstring)
        field.Clear()
        field.AddRange(New String() {"iduser", "iduserlevel", "iduserstatus", "username", "password", "idtoken", "tokenkey1", "tokenkey2", "namalengkap", "email", "handphone", "hint", "recoveryquestion", "recoveryanswer", "bannedreason", "waktucek", "isdeleted", "isuseronline"})
        value.Clear()
        value.AddRange(New Object() {idData, iduserlevel, iduserstatus, teUsername.Text, passval, idtoken, tokenkey1, tokenkey2, teNamaLengkap.Text, teEmail.Text, teHandphone.Text, teHint.Text, teRecQuest.Text, teRecAns.Text, "-", tmpnowTime, 0, 0})

        If dtSQL.datasetSave("sys_user", idData, field, value, False) = True Then
            isiLog(userid, dbstring, field, value, "sys_user")
            sqls = New SQLs(dbstring)

            If idData = -1 Then
                Dim iduser As String
                Dim img As Image = My.Resources.defprofile200
                sqls.DMLQuery("select iduser from sys_user where replace(username,' ','')='" & teUsername.Text.Replace(" ", "") & "'", "cekuserid")
                iduser = sqls.getDataSet("cekuserid", 0, "iduser")
                img.Save(imgMemoryStream, System.Drawing.Imaging.ImageFormat.Png)
                imgByteArray = imgMemoryStream.GetBuffer()
                sqls.InsertImage("sys_images", "datetime,filename,sizewidth,sizeheight", "'" & Format(nowTime, "MM/dd/yyyy HH:mm:ss") & "','defPP" & iduser & ".png','" & img.Size.Width & "','" & img.Size.Height & "'", "images", "gambar", imgByteArray, False)
                Dim idimages As String
                sqls.DMLQuery("select idimages from sys_images where replace(filename,' ','')='defPP" & iduser & ".png'", "cekidimg")
                idimages = sqlss.getDataSet("cekidimg", 0, "idimages")
                dtSQL = New dtsetSQLS(dbstring)
                field.Clear()
                field.AddRange(New String() {"iduserimages", "idimages", "iduser", "description", "asprofile", "isdeleted"})
                value.Clear()
                value.AddRange(New String() {-1, idimages, iduser, "default", 1, 0})
                dtSQL.datasetSave("sys_userimages", -1, field, value, False)
                isiLog(userid, dbstring, field, value, "sys_userimages")
            End If

            If tmpUserFromOnline = False Then
                Dim dsql As New dtsetSQLS(mystring)
                Dim fs As New List(Of String)
                Dim vs As New List(Of Object)

                Dim emailpin As String = getGenerateCode(teEmail.Text, tmptokenkey1, tmptokenkey2, 20, getFrom.depan)
                Dim addresspin As String = getGenerateCode(teAlamat.Text, tmptokenkey1, tmptokenkey2, 20, getFrom.depan)
                Dim hppin As String = getGenerateCode(teHandphone.Text, tmptokenkey1, tmptokenkey2, 20, getFrom.depan)
                Dim ippublic As String = GetIPPublic()
                Dim pcname As String = getIPAddress(ipaddparam.Host)
                fs.AddRange(New String() {"iduser", "username", "idtoken", "tokenkey1", "tokenkey2", "password", "hint", "recoveryquestion", "recoveryanswer", "namalengkap", "personalno", "idcardtype", "email", "emailpin", "emailpinexpired", "isemailverified", "address", "zipcode", "addresspin", "addresspinexpired", "isaddressverified", "handphone", "handphonepin", "handphonepinexpired", "ishandphoneverified", "isuserverified", "isdeleted", "deletereason", "publicv4ipaddress", "computername", "createdby", "createddate"})
                vs.AddRange(New Object() {-1, teUsername.Text, tmpidtoken, tmptokenkey1, tmptokenkey2, passval, teHint.Text, teRecQuest.Text, teRecAns.Text, teNamaLengkap.Text, teID.Text, lueJenis.EditValue, teEmail.Text, emailpin, tmpnowTime.AddDays(30), 0, teAlamat.Text, teKodepos.Text, addresspin, tmpnowTime.AddDays(30), 0, teHandphone.Text, hppin, tmpnowTime.AddDays(30), 0, 0, 0, "", ippublic, pcname, 1, tmpnowTime})
                dsql.datasetSave("[user]", -1, fs, vs, False)
            End If

            sqlss.DMLQuery("select iduser from [user] where username='" & teUsername.Text & "'", "getuserid")
            If sqlss.getDataSet("getuserid") > 0 Then
                tmpUserID = sqlss.getDataSet("getuserid", 0, "iduser")
                tmpUsername = teUsername.Text
                sqls.DMLQuery("update sys_user set iduseronline=" & tmpUserID & " where username='" & teUsername.Text & "'", False)
            End If

            Me.Cursor = Cursors.Default
            If idData = -1 Then
                dizMsgbox("Data Pengguna telah tersimpan" & vbCrLf & "Silahkan menunggu aktivasi user dari superadmin", dizMsgboxStyle.Info, Me)
            Else
                dizMsgbox("Data Pengguna telah diperbarui", dizMsgboxStyle.Info, Me)
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Dispose()
        End If
    End Sub

    Private Sub teUsername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles teUsername.KeyPress, texUsername.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rVarcharSmall) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub teHandphone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles teHandphone.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rNumeric) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private mystring As String = ""
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        tmpUserFromOnline = False
        Dim lite As New SQLi(dblite)
        lite.DMLQuery("select databasename || '|' || ipserver || '|' || port || '|' || username || '|' || password as dbstring from dbconn where dbtype='SQLS' and dblocation='DOMAIN'", "getdbstring")
        If lite.getDataSet("getdbstring") > 0 Then
            mystring = lite.getDataSet("getdbstring", 0, "dbstring")
        End If

        checkFieldMaxLength(dbstring, tlpPengguna, "sys_user")
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='CARDTYPE'", "CT")
        lueJenis.Properties.DataSource = sqls.dataTable("CT")
        lueJenis.Properties.ValueMember = "id"
        lueJenis.Properties.DisplayMember = "content"
        lueJenis.EditValue = Nothing
        lueJenis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        lueJenis.Properties.BestFit()

        teNamaLengkap.Focus()
        teID.Text = ""
        teEmail.Text = ""
        teHandphone.Text = ""
        teHint.Text = ""
        teNamaLengkap.Text = ""
        tePassword.Text = ""
        teRecAns.Text = ""
        teRecQuest.Text = ""
        teUsername.Text = ""
        teAlamat.Text = ""
        teKodepos.Text = ""
    End Sub

    Private Sub teID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles teID.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rNumeric) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnExistCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExistCheck.Click
        Me.Cursor = Cursors.WaitCursor
        
        Dim sqls As New SQLs(mystring)
        sqls.DMLQuery("select iduser,idtoken,tokenkey1,tokenkey2,password from [user] where username='" & texUsername.Text & "'", "user")
        If sqls.getDataSet("user") > 0 Then 'strvalue.Contains("ERROR") = False Then
            tmpidtoken = sqls.getDataSet("user", 0, "idtoken") 'strvalue.Split("|")(1) 
            tmptokenkey1 = sqls.getDataSet("user", 0, "tokenkey1") 'strvalue.Split("|")(2)
            tmptokenkey2 = sqls.getDataSet("user", 0, "tokenkey2") 'strvalue.Split("|")(3)
            Dim tmppassword As String = sqls.getDataSet("user", 0, "password") 'strvalue.Split("|")(4) 
            Dim strpassword As String = GeneratePass(texPassword.Text, tmptokenkey1, tmptokenkey2, 8000)
            If tmppassword = strpassword Then

                sqls.DMLQuery("select iduser,namalengkap,personalno,idcardtype,address,zipcode,email,handphone,hint,recoveryquestion,recoveryanswer,username,password from [user] where username='" & texUsername.Text & "'", "useronline")
                tmpUserID = sqls.getDataSet("useronline", 0, "iduser") 'strvalue.Split("|")(0) 
                teNamaLengkap.Text = sqls.getDataSet("useronline", 0, "namalengkap") 'strvalue.Split("|")(1)
                teID.Text = sqls.getDataSet("useronline", 0, "personalno") 'strvalue.Split("|")(2) 
                lueJenis.EditValue = sqls.getDataSet("useronline", 0, "idcardtype") 'strvalue.Split("|")(3) 
                teEmail.Text = sqls.getDataSet("useronline", 0, "email") 'strvalue.Split("|")(6) 
                teHandphone.Text = sqls.getDataSet("useronline", 0, "handphone") 'strvalue.Split("|")(7) 
                teHint.Text = sqls.getDataSet("useronline", 0, "hint") 'strvalue.Split("|")(8) 
                teRecQuest.Text = sqls.getDataSet("useronline", 0, "recoveryquestion") 'strvalue.Split("|")(9) 
                teRecAns.Text = sqls.getDataSet("useronline", 0, "recoveryanswer") 'strvalue.Split("|")(10) 
                teAlamat.Text = sqls.getDataSet("useronline", 0, "address") 'strvalue.Split("|")(4) 
                teKodepos.Text = sqls.getDataSet("useronline", 0, "zipcode") 'strvalue.Split("|")(5) 
                teUsername.Text = texUsername.Text
                tePassword.Text = texPassword.Text
                tmpUserFromOnline = True
                Me.Cursor = Cursors.Default
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

    Public Sub New(ByVal ExistUser As Boolean)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pExist.Visible = ExistUser
        If ExistUser = False Then
            tlpEntry.RowStyles.Item(1).Height = 0
        End If
    End Sub

    Private Sub teEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teEmail.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rEmail) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub teKodepos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teKodepos.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rNumeric) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

End Class