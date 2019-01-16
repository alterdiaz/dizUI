Public Class frmNewCompany
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto, SetLastError:=True, ExactSpelling:=True)> _
    Public Shared Function ReleaseCapture() As Boolean
    End Function
    Declare Auto Function SendMessage Lib "user32.dll" (ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    Private Sub lblTitle_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lblTitle.MouseDown
        'This code can be used in the MouseDown event of any control(s) you want to be able to move your form with   
        'If Me.WindowState = FormWindowState.Normal Then
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0&)
        'End If
    End Sub

    Private Function cekIsian() As Boolean
        Dim retval As Boolean = True
        If lueCompJenis.BackColor = canWrite Then
            If lueCompJenis.EditValue Is Nothing Then
                retval = False
            End If
        End If
        If teCompNickname.BackColor = canWrite Then
            If teCompNickname.Text = "" Then
                retval = False
            End If
        End If
        If teCompFullname.BackColor = canWrite Then
            If teCompFullname.Text = "" Then
                retval = False
            End If
        End If
        If teCompEmail.BackColor = canWrite Then
            If teCompEmail.Text = "" Then
                retval = False
            End If
        End If
        If teCompEmail.BackColor = canWrite Then
            If isEmail(teCompEmail.Text) = False Then
                retval = False
            End If
        End If
        If teCompNPWP.BackColor = canWrite Then
            If teCompNPWP.Text = "" Then
                retval = False
            End If
        End If
        If teAlamat.BackColor = canWrite Then
            If teAlamat.Text = "" Then
                retval = False
            End If
        End If
        If teKodepos.BackColor = canWrite Then
            If teKodepos.Text = "" Then
                retval = False
            End If
        End If
        If lueRegion1.BackColor = canWrite Then
            If lueRegion1.EditValue Is Nothing Then
                retval = False
            End If
        End If
        If lueRegion2.BackColor = canWrite Then
            If lueRegion2.EditValue Is Nothing Then
                retval = False
            End If
        End If
        If teFax.BackColor = canWrite Then
            If teFax.Text = "" Then
                retval = False
            End If
        End If
        If tePhone1.BackColor = canWrite Then
            If tePhone1.Text = "" Then
                retval = False
            End If
        End If
        If tePhone1.BackColor = canWrite Then
            If tePhone1.Text = "0" Then
                retval = False
            End If
        End If
        If tePhone2.BackColor = canWrite Then
            If tePhone2.Text = "" Then
                retval = False
            End If
        End If
        If teCPname.BackColor = canWrite Then
            If teCPname.Text = "" Then
                retval = False
            End If
        End If
        If teCPemail.BackColor = canWrite Then
            If teCPemail.Text = "" Then
                retval = False
            End If
        End If
        If teCPemail.BackColor = canWrite Then
            If isEmail(teCPemail.Text) = False Then
                retval = False
            End If
        End If
        If teCPno.BackColor = canWrite Then
            If teCPno.Text = "" Then
                retval = False
            End If
        End If
        If teCPno.BackColor = canWrite Then
            If teCPno.Text = "0" Then
                retval = False
            End If
        End If
        Return retval
    End Function

    Private Sub Angka_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles teCPno.KeyPress, teFax.KeyPress, tePhone1.KeyPress, tePhone2.KeyPress, teKodepos.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rNumeric) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Function getsharecontractid(sharecontractcode As String) As Long
        Dim retval As Long = -1
        Dim sqls As New SQLs(mystring)
        sqls.DMLQuery("select idcompanyreferral from sharecontract where sharecontractcode='" & sharecontractcode & "' and isdeleted=0 and duedate is null", "getcompreff")
        
        If sqls.getDataSet("getcompreff") > 0 Then
            retval = sqls.getDataSet("getcompreff", 0, "idcompanyreferral")
        End If
        Return retval
    End Function

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private mystring As String = ""
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Cursor = Cursors.WaitCursor
        If cekIsian() = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        If tmpCompanyFromOnline = False Then
            If cekCompany(teCompNPWP.Text, teCompFullname.Text, teCompEmail.Text) = False Then
                dizMsgbox("Perusahaan ini sudah terdaftar", dizMsgboxStyle.Kesalahan, Me)
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
        End If

        Dim sqls As New SQLs(mystring)
        If tmpCompanyFromOnline = False Then
            sqls.DMLQuery("select top 1 idtoken,tokenkey1,tokenkey2 from token order by createddate desc", "token")
            If sqls.getDataSet("token") > 0 Then
                tmpidtoken = sqls.getDataSet("token", 0, "idtoken")
                tmptokenkey1 = sqls.getDataSet("token", 0, "tokenkey1")
                tmptokenkey2 = sqls.getDataSet("token", 0, "tokenkey2")
            Else
                tmpidtoken = 1
                tmptokenkey1 = "ABF"
                tmptokenkey2 = "123"
            End If
        End If
        sqls.DMLQuery("select convert(varchar,getdate(),105) as tanggal,convert(varchar,getdate(),108) as waktu", "lasttime")
        If sqls.getDataSet("lasttime") > 0 Then
            Dim tmptgl As String = sqls.getDataSet("lasttime", 0, "tanggal")
            Dim tmpwaktu As String = sqls.getDataSet("lasttime", 0, "waktu")
            tmpnowTime = Strdatetime2Datetime(tmptgl & " " & tmpwaktu)
        Else
            tmpnowTime = Now
        End If

        If tmpCompanyFromOnline = False Then
            tmpidcompanyrefferal = -1
            If teRefferalCode.Text <> "" Then
                sqls.DMLQuery("select idcompanyreferral from sharecontract where sharecontractcode='" & teRefferalCode.Text & "' and isdeleted=0 and duedate > getdate()", "getidcompreff")
                If sqls.getDataSet("getidcompreff") > 0 Then
                    tmpidcompanyrefferal = sqls.getDataSet("getidcompreff", 0, "idcompanyreferral")
                Else
                    dizMsgbox("Refferal Code tidak ditemukan", dizMsgboxStyle.Kesalahan)
                    Exit Sub
                End If
            End If
        End If

        Dim dtmys As New dtsetSQLS(mystring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idcompany", "idcompanyrefferal", "companycode", "companynicknameunique", "companynickname", "companyofficialname", "companytype", "companylegalnumber", "companyemail", "emailpin", "emailpinexpired", "isemailverified", "address", "zipcode", "idnegara", "idpropinsi", "idkabupaten", "idkecamatan", "idkelurahan", "addresspin", "addresspinexpired", "isaddressverified", "faxno", "phoneno1", "phoneno2", "ispersonal", "isdeleted", "deletereason", "contactpersonname", "contactpersonno", "contactpersonemail", "createdby", "createddate", "idtoken", "tokenkey1", "tokenkey2"})
        'Dim emailpin As String = GenerateUniqueID(getCharsUpperNumeric(teCompEmail.Text), 20)
        'Dim emailpin As String = getCharsNumeric(GeneratePass(teCompEmail.Text, tmptokenkey1, tmptokenkey2, 20))
        Dim emailpin As String = getGenerateCode(teCompEmail.Text, tmptokenkey1, tmptokenkey2, 20, getFrom.depan)
        'Dim addresspin As String = GenerateUniqueID(getCharsUpperNumeric(teAlamat.Text.Replace(Chr(13), "")), 20)
        'Dim addresspin As String = getCharsNumeric(GeneratePass(teAlamat.Text, tmptokenkey1, tmptokenkey2, 20))
        Dim addresspin As String = getGenerateCode(teAlamat.Text, tmptokenkey1, tmptokenkey2, 20, getFrom.depan)
        'Dim compcode As String = GenerateUniqueID(getCharsUpper(teCompFullname.Text), 20)
        'Dim compcode As String = getCharsNumeric(GeneratePass(getCharsNumeric(teCompFullname.Text), tmptokenkey1, tmptokenkey2, 20))
        Dim compcode As String = getGenerateCode(teCompFullname.Text, tmptokenkey1, tmptokenkey2, 20, getFrom.depan)

        Dim compnameunique As String = getCharsNumeric(teCompFullname.Text)
        value.AddRange(New Object() {idData, IIf(tmpidcompanyrefferal = -1, 0, tmpidcompanyrefferal), compcode, compnameunique, teCompNickname.Text, teCompFullname.Text, lueCompJenis.EditValue, teCompNPWP.Text, teCompEmail.Text, emailpin, tmpnowTime.AddDays(30), 0, teAlamat.Text, teKodepos.Text, lueRegion1.EditValue, lueRegion2.EditValue, Nothing, Nothing, Nothing, addresspin, tmpnowTime.AddDays(30), 0, teFax.Text, tePhone1.Text, tePhone2.Text, IIf(lueCompJenis.EditValue = 0, 1, 0), 0, "-", teCPname.Text, teCPno.Text, teCPemail.Text, tmpUserID, tmpnowTime, tmpidtoken, tmptokenkey1, tmptokenkey2})

        Me.Cursor = Cursors.Default
        If dtmys.datasetSave("company", idData, field, value, False) = True Then
            Dim idcomp As Integer = getIDCompany(teCompNPWP.Text, teCompFullname.Text, teCompEmail.Text)
            Dim lite As New SQLi(dblite)

            modCore.idcompany = idcomp
            modCore.companyname = teCompFullname.Text
            modCore.companycode = compcode
            modCore.idcompanyrefferal = tmpidcompanyrefferal

            lite.DMLQuery("update appsetting set value='" & idcomp & "' where variable='CompanyID'", False)
            lite.DMLQuery("update appsetting set value='" & teCompFullname.Text & "' where variable='CompanyName'", False)
            lite.DMLQuery("update appsetting set value='" & compcode & "' where variable='CompanyCode'", False)

            Dim sqlss As New SQLs(dbstring)
            sqlss.DMLQuery("update sys_appsetting set value='" & idcomp & "' where variable='CompanyID'", False)
            sqlss.DMLQuery("update sys_appsetting set value='" & teCompFullname.Text & "' where variable='CompanyName'", False)
            sqlss.DMLQuery("update sys_appsetting set value='" & compcode & "' where variable='CompanyCode'", False)

            dizMsgbox("Data Perusahaan tersimpan", dizMsgboxStyle.Info, Me)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Dispose()
        End If
    End Sub

    Private Function getIDCompanyByEmail(ByVal emailcomp As String, ByVal emailpin As String) As Integer
        Dim retval As Integer = 0

        Dim sqls As New SQLs(mystring)
        sqls.DMLQuery("select idcompany from company where emailpin='" & emailpin & "' and companyemail='" & emailcomp & "' and isemailverified=1", "cekcomp")
        If sqls.getDataSet("cekcomp") > 0 Then
            retval = sqls.getDataSet("cekcomp", 0, "idcompany")
        End If
        Return retval
    End Function

    Private Function getIDCompany(ByVal npwp As String, ByVal fullname As String, ByVal emailcomp As String) As Integer
        Dim retval As Integer = 0
        Dim strnpwp As String = npwp
        Dim strnickunique As String = getCharsNumeric(fullname)

        Dim sqls As New SQLs(mystring)
        sqls.DMLQuery("select idcompany from company where companylegalnumber='" & strnpwp & "' or companynicknameunique='" & strnickunique & "' or companyemail='" & emailcomp & "'", "cekcomp")

        If sqls.getDataSet("cekcomp") > 0 Then
            retval = sqls.getDataSet("cekcomp", 0, "idcompany")
        End If
        Return retval
    End Function

    Private Function cekCompany(ByVal npwp As String, ByVal nickname As String, ByVal emailcomp As String) As Boolean
        Dim retval As Boolean = True
        Dim strnpwp As String = getNumber(npwp)
        Dim strnickunique As String = getCharsUpper(nickname)

        Dim sqls As New SQLs(mystring)
        sqls.DMLQuery("select idcompany from company where companylegalnumber='" & strnpwp & "' or companynicknameunique='" & strnickunique & "' or companyemail='" & emailcomp & "'", "content")
        If sqls.getDataSet("content") > 0 Then
            retval = False
        End If
        Return retval
    End Function

    Private Sub frmNewCompany_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        tmpCompanyFromOnline = False
        idData = "-1"
        Dim lite As New SQLi(dblite)
        lite.DMLQuery("select databasename || '|' || ipserver || '|' || port || '|' || username || '|' || password as dbstring from dbconn where dbtype='SQLS' and dblocation='DOMAIN'", "getdbstring")
        If lite.getDataSet("getdbstring") > 0 Then
            mystring = lite.getDataSet("getdbstring", 0, "dbstring")
        End If

        Dim sqls As New SQLs(mystring)
        sqls.DMLQuery("select idgeneral as idjenis,generalcode as jenis from generalcode where gctype='COMPANYTYPE'", "getcomptype")
        lueCompJenis.Properties.DataSource = sqls.dataTable("getcomptype")
        lueCompJenis.Properties.DisplayMember = "jenis"
        lueCompJenis.Properties.ValueMember = "idjenis"
        lueCompJenis.EditValue = Nothing

        sqls.DMLQuery("select idwilayah as idregion,wilayah as region from wilayah where levelwilayah=1 and isdeleted=0", "region1")
        lueRegion1.Properties.DataSource = sqls.dataTable("region1")
        lueRegion1.Properties.ValueMember = "idregion"
        lueRegion1.Properties.DisplayMember = "region"
        lueRegion1.EditValue = Nothing

        teFax.Text = 0
        tePhone1.Text = 0
        tePhone2.Text = 0

        xtcEntry.SelectedTabPage = xtpCompany
        lueCompJenis.Focus()
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

    Private Sub btnExistCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExistCheck.Click
        Me.Cursor = Cursors.WaitCursor
        Dim sqls As New SQLs(mystring)
        sqls.DMLQuery("select idcompany from company where companyemail='" & teExistCompEmail.Text & "' and isdeleted=0 and (emailpin='" & teExistCompEmailPIN.Text & "' or addresspin='" & teExistCompEmailPIN.Text & "')", "getidcomp")
        If sqls.getDataSet("getidcomp") > 0 Then
            idData = sqls.getDataSet("getidcomp", 0, "idcompany")

            sqls.DMLQuery("select isnull(idcompanyrefferal,-1) as idcompanyrefferal,companytype,companyofficialname,companynickname,companyemail,companylegalnumber,address,zipcode,idnegara,idpropinsi,idkabupaten,idkecamatan,idkelurahan,faxno,phoneno1,phoneno2,contactpersonname,contactpersonno,contactpersonemail,idtoken,tokenkey1,tokenkey2 from company where idcompany='" & idData & "'", "getcompdata")

            tmpidcompanyrefferal = sqls.getDataSet("getcompdata", 0, "idcompanyrefferal")
            lueCompJenis.EditValue = sqls.getDataSet("getcompdata", 0, "companytype")
            teCompNickname.Text = sqls.getDataSet("getcompdata", 0, "companynickname")
            teCompFullname.Text = sqls.getDataSet("getcompdata", 0, "companyofficialname")
            teCompEmail.Text = sqls.getDataSet("getcompdata", 0, "companyemail")
            teCompNPWP.Text = sqls.getDataSet("getcompdata", 0, "companylegalnumber")

            teAlamat.Text = sqls.getDataSet("getcompdata", 0, "address")
            teKodepos.Text = sqls.getDataSet("getcompdata", 0, "zipcode")
            teFax.Text = sqls.getDataSet("getcompdata", 0, "faxno")
            tePhone1.Text = sqls.getDataSet("getcompdata", 0, "phoneno1")
            tePhone2.Text = sqls.getDataSet("getcompdata", 0, "phoneno2")

            lueRegion1.EditValue = sqls.getDataSet("getcompdata", 0, "idnegara")
            lueRegion2.EditValue = sqls.getDataSet("getcompdata", 0, "idpropinsi")
            lueRegion3.EditValue = sqls.getDataSet("getcompdata", 0, "idkabupaten")
            lueRegion4.EditValue = sqls.getDataSet("getcompdata", 0, "idkecamatan")
            lueRegion5.EditValue = sqls.getDataSet("getcompdata", 0, "idkelurahan")

            teCPname.Text = sqls.getDataSet("getcompdata", 0, "contactpersonname")
            teCPno.Text = sqls.getDataSet("getcompdata", 0, "contactpersonno")
            teCPemail.Text = sqls.getDataSet("getcompdata", 0, "contactpersonemail")

            tmpidtoken = sqls.getDataSet("getcompdata", 0, "idtoken")
            tmptokenkey1 = sqls.getDataSet("getcompdata", 0, "tokenkey1")
            tmptokenkey2 = sqls.getDataSet("getcompdata", 0, "tokenkey2")
            teRefferalCode.Text = ""

            If tmpidcompanyrefferal <> "-1" Then
                sqls.DMLQuery("select sharecontractcode from sharecontract where idcompanyreferral='" & tmpidcompanyrefferal & "' and isdeleted=0 and duedate > getdate()", "getreff")
                If sqls.getDataSet("getreff") > 0 Then
                    teRefferalCode.Text = sqls.getDataSet("getreff", 0, "sharecontractcode")
                    teRefferalCode.ReadOnly = True
                    teRefferalCode.Enabled = False
                    teRefferalCode.BackColor = justRead
                    teRefferalCode.ForeColor = Color.Black
                End If
            End If

            teRefferalCode.ReadOnly = True
            teRefferalCode.Enabled = False
            teRefferalCode.BackColor = justRead
            teRefferalCode.ForeColor = Color.Black

            tmpCompanyFromOnline = True
            Me.Cursor = Cursors.Default
        Else
            dizMsgbox("Data Perusahaan tidak ditemukan atau tidak aktif", dizMsgboxStyle.Peringatan, Me)

            teRefferalCode.ReadOnly = False
            teRefferalCode.Enabled = True
            teRefferalCode.BackColor = canWrite
            teRefferalCode.ForeColor = Color.Black

            tmpCompanyFromOnline = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub lueRegion1_EditValueChanged(sender As Object, e As EventArgs) Handles lueRegion1.EditValueChanged
        If sender.editvalue Is Nothing Then
            lueRegion2.Properties.DataSource = Nothing
            lueRegion2.EditValue = Nothing
        Else
            Dim sqls As New SQLs(mystring)
            sqls.DMLQuery("select idwilayah as idregion,wilayah as region from wilayah where levelwilayah=2 and isdeleted=0 and idparent='" & sender.editvalue & "'", "region2")
            lueRegion2.Properties.DataSource = sqls.dataTable("region2")
            lueRegion2.Properties.ValueMember = "idregion"
            lueRegion2.Properties.DisplayMember = "region"
            lueRegion2.EditValue = Nothing
        End If
    End Sub

    Private Sub lueRegion2_EditValueChanged(sender As Object, e As EventArgs) Handles lueRegion2.EditValueChanged
        If sender.editvalue Is Nothing Then
            lueRegion3.Properties.DataSource = Nothing
            lueRegion3.EditValue = Nothing
        Else
            Dim sqls As New SQLs(mystring)
            sqls.DMLQuery("select idwilayah as idregion,wilayah as region from wilayah where levelwilayah=3 and isdeleted=0 and idparent='" & sender.editvalue & "'", "region3")
            lueRegion3.Properties.DataSource = sqls.dataTable("region3")
            lueRegion3.Properties.ValueMember = "idregion"
            lueRegion3.Properties.DisplayMember = "region"
            lueRegion3.EditValue = Nothing
        End If
    End Sub

    Private Sub lueRegion3_EditValueChanged(sender As Object, e As EventArgs) Handles lueRegion3.EditValueChanged
        If sender.editvalue Is Nothing Then
            lueRegion4.Properties.DataSource = Nothing
            lueRegion4.EditValue = Nothing
        Else
            Dim sqls As New SQLs(mystring)
            sqls.DMLQuery("select idwilayah as idregion,wilayah as region from wilayah where levelwilayah=4 and isdeleted=0 and idparent='" & sender.editvalue & "'", "region4")
            lueRegion4.Properties.DataSource = sqls.dataTable("region4")
            lueRegion4.Properties.ValueMember = "idregion"
            lueRegion4.Properties.DisplayMember = "region"
            lueRegion4.EditValue = Nothing
        End If
    End Sub

    Private Sub lueRegion4_EditValueChanged(sender As Object, e As EventArgs) Handles lueRegion4.EditValueChanged
        If sender.editvalue Is Nothing Then
            lueRegion5.Properties.DataSource = Nothing
            lueRegion5.EditValue = Nothing
        Else
            Dim mys As New SQLs(mystring)
            mys.DMLQuery("select idwilayah as idregion,wilayah as region from wilayah where idregionlevel=5 and isdeleted=0 and idparent='" & sender.editvalue & "'", "region5")
            lueRegion5.Properties.DataSource = mys.dataTable("region5")
            lueRegion5.Properties.ValueMember = "idregion"
            lueRegion5.Properties.DisplayMember = "region"
            lueRegion5.EditValue = Nothing
        End If
    End Sub

    Private Sub teCompNPWP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teCompNPWP.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rVarchar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub teCompEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teCompEmail.KeyPress, teCPemail.KeyPress, teExistCompEmail.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rEmail) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub lueCompJenis_EditValueChanged(sender As Object, e As EventArgs) Handles lueCompJenis.EditValueChanged
        If lueCompJenis.EditValue Is Nothing Then
            lblNama.Text = "Nama Perusahaan"
            lblNamaResmi.Text = "Nama Resmi Perusahaan"
            lblEmail.Text = "Email Perusahaan"
            lblNPWP.Text = "NPWP Perusahaan"
            Exit Sub
        End If

        If lueCompJenis.Text = "Personal" Then
            lblNama.Text = "Nama Panggilan Anda"
            lblNamaResmi.Text = "Nama Lengkap Anda"
            lblEmail.Text = "Email Anda"
            lblNPWP.Text = "NPWP Pribadi Anda"

            teFax.Text = 0
            tePhone1.Text = 0
            tePhone2.Text = 0
            teCPname.Text = ""
            teCPno.Text = 0
            teCPemail.Text = ""

            teFax.Properties.ReadOnly = True
            tePhone1.Properties.ReadOnly = False
            tePhone2.Properties.ReadOnly = True
            teCPname.Properties.ReadOnly = True
            teCPno.Properties.ReadOnly = True
            teCPemail.Properties.ReadOnly = True

            teFax.BackColor = justRead
            tePhone1.BackColor = canWrite
            tePhone2.BackColor = justRead
            teCPname.BackColor = justRead
            teCPno.BackColor = justRead
            teCPemail.BackColor = justRead
        Else
            lblNama.Text = "Nama Perusahaan"
            lblNamaResmi.Text = "Nama Resmi Perusahaan"
            lblEmail.Text = "Email Perusahaan"
            lblNPWP.Text = "NPWP Perusahaan"

            teFax.Text = 0
            tePhone1.Text = 0
            tePhone2.Text = 0
            teCPname.Text = ""
            teCPno.Text = 0
            teCPemail.Text = ""

            teFax.Properties.ReadOnly = False
            tePhone1.Properties.ReadOnly = False
            tePhone2.Properties.ReadOnly = False
            teCPname.Properties.ReadOnly = False
            teCPno.Properties.ReadOnly = False
            teCPemail.Properties.ReadOnly = False

            teFax.BackColor = canWrite
            tePhone1.BackColor = canWrite
            tePhone2.BackColor = canWrite
            teCPname.BackColor = canWrite
            teCPno.BackColor = canWrite
            teCPemail.BackColor = canWrite
        End If
    End Sub

    Private Sub Isian_GotFocus(sender As Object, e As EventArgs) Handles lueCompJenis.GotFocus, teCompNickname.GotFocus, teCompFullname.GotFocus, teCompEmail.GotFocus, teCompNPWP.GotFocus, teAlamat.GotFocus, teKodepos.GotFocus, lueRegion1.GotFocus, lueRegion2.GotFocus, lueRegion3.GotFocus, lueRegion4.GotFocus, lueRegion5.GotFocus, teFax.GotFocus, tePhone1.GotFocus, tePhone2.GotFocus, teCPname.GotFocus, teCPno.GotFocus, teCPemail.GotFocus, teRefferalCode.GotFocus
        If sender Is lueCompJenis Then
            lblInfo.Visible = True
            lblInfo.Text = "Jenis Perusahaan"
        ElseIf sender Is teCompNickname Then
            lblInfo.Visible = True
            lblInfo.Text = "Nama Branding Perusahaan/Perorangan"
        ElseIf sender Is teCompFullname Then
            lblInfo.Visible = True
            lblInfo.Text = "Nama Perusahaan Resmi lengkap dengan badan hukum" & vbCrLf & "Nama Lengkap Perorangan untuk perorangan"
        ElseIf sender Is teCompEmail Then
            lblInfo.Visible = True
            lblInfo.Text = "Email Perusahaan yang sedang aktif" & vbCrLf & "Kami akan validasi email anda"
        ElseIf sender Is teCompNPWP Then
            lblInfo.Visible = True
            lblInfo.Text = "NPWP akan kami gunakan untuk" & vbCrLf & "validasi data perusahaan berdasarkan NPWP"
        ElseIf sender Is teAlamat Then
            lblInfo.Visible = True
            lblInfo.Text = "Alamat Domisili sekarang" & vbCrLf & "Mulai nama jalan, dan nomor bangunan/kavling" & vbCrLf & "Kami akan validasi alamat anda"
        ElseIf sender Is teKodepos Then
            lblInfo.Visible = True
            lblInfo.Text = "Kodepos Domisili sekarang"
        ElseIf sender Is lueRegion1 Or sender Is lueRegion2 Or sender Is lueRegion3 Or sender Is lueRegion4 Or sender Is lueRegion5 Then
            lblInfo.Visible = True
            lblInfo.Text = "Wilayah Domisili sekarang"
        ElseIf sender Is teFax Then
            lblInfo.Visible = True
            lblInfo.Text = "Nomor Fax yang masih aktif"
        ElseIf sender Is tePhone1 Then
            lblInfo.Visible = True
            lblInfo.Text = "Nomor Telepon yang masih aktif"
        ElseIf sender Is tePhone2 Then
            lblInfo.Visible = True
            lblInfo.Text = "Nomor Telepon Alternatif"
        ElseIf sender Is teCPname Then
            lblInfo.Visible = True
            lblInfo.Text = "Nama Contact Person yang dapat dihubungi"
        ElseIf sender Is teCPno Then
            lblInfo.Visible = True
            lblInfo.Text = "Nomor Telepon Contact Person yang dapat dihubungi"
        ElseIf sender Is teCPemail Then
            lblInfo.Visible = True
            lblInfo.Text = "Email Contact Person yang dapat dihubungi"
        ElseIf sender Is teRefferalCode Then
            lblInfo.Visible = True
            lblInfo.Text = "Kode Refferal yang masih aktif"
        Else
            lblInfo.Visible = False
            lblInfo.Text = ""
        End If
    End Sub
End Class