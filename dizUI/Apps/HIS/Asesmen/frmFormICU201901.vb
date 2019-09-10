Imports DevExpress.XtraGrid.Views.Base
Public Class frmFormICU201901
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1

    'API functions   
    <System.Runtime.InteropServices.DllImport("user32.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto, SetLastError:=True, ExactSpelling:=True)>
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

    Private Sub pExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pExit.Click
        splashClosed = True
        Me.Dispose()
    End Sub

    Private Sub pMaximize_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pMaximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        ElseIf Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub pMinimize_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pMinimize.Click
        Me.WindowState = FormWindowState.Minimized
        Me.Visible = False
        Me.Hide()
    End Sub

    Private Sub pbMMX_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pMinimize.MouseDown, pMaximize.MouseDown, pExit.MouseDown
        If sender Is pExit Then
            sender.backcolor = justRead
            sender.Image = My.Resources.exit_n
        ElseIf sender Is pMaximize Then
            sender.backcolor = canWrite
            sender.Image = My.Resources.max_n
        ElseIf sender Is pMinimize Then
            sender.backcolor = canWrite
            sender.Image = My.Resources.min_n
        End If
    End Sub

    Private Sub pbMMX_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles pMinimize.MouseEnter, pMaximize.MouseEnter, pExit.MouseEnter
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        ElseIf sender Is pMaximize Then
            sender.backcolor = Color.Lime
            sender.Image = My.Resources.max_n
        ElseIf sender Is pMinimize Then
            sender.backcolor = Color.Lime
            sender.Image = My.Resources.min_n
        End If
    End Sub

    Private Sub pbMMX_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles pMinimize.MouseLeave, pMaximize.MouseLeave, pExit.MouseLeave
        sender.backcolor = Color.Transparent
        If sender Is pExit Then
            sender.Image = My.Resources.exit_w
        ElseIf sender Is pMaximize Then
            sender.Image = My.Resources.max_w
        ElseIf sender Is pMinimize Then
            sender.Image = My.Resources.min_w
        End If
    End Sub

    Private Sub pbMMX_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pMinimize.MouseUp, pMaximize.MouseUp, pExit.MouseUp
        If sender Is pExit Then
            sender.backcolor = Color.FromArgb(206, 0, 0)
            sender.Image = My.Resources.exit_n
        ElseIf sender Is pMaximize Then
            sender.backcolor = Color.Lime
            sender.Image = My.Resources.max_n
        ElseIf sender Is pMinimize Then
            sender.backcolor = Color.Lime
            sender.Image = My.Resources.min_n
        End If
    End Sub

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)

        sqls.DMLQuery("select idparamedis as id,nama as content from paramedis where paramedistype in (select idgeneral from sys_generalcode where gctype='paramedistype' and priority in (1,2,3)) and isservice=1 and isdeleted=0 order by nama asc", "param")
        lueParamedis.Properties.DataSource = sqls.dataTable("param")
        lueParamedis.Properties.DisplayMember = "content"
        lueParamedis.Properties.ValueMember = "id"
        lueParamedis.EditValue = Nothing
        If sqls.getDataSet("param") = 0 Then
            dizMsgbox("Paramedis tidak ditemukan" & vbCrLf & "Paramedis harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idparamedis as id,nama as content from paramedis where isservice=1 and isdeleted=0 order by nama asc", "param1")
        lueParamedisSOAP.Properties.DataSource = sqls.dataTable("param1")
        lueParamedisSOAP.Properties.DisplayMember = "content"
        lueParamedisSOAP.Properties.ValueMember = "id"
        lueParamedisSOAP.EditValue = Nothing
        If sqls.getDataSet("param1") = 0 Then
            dizMsgbox("Paramedis tidak ditemukan" & vbCrLf & "Paramedis harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='DPJPTYPE' order by idgeneral asc", "dpjptype")
        lueSebagai.Properties.DataSource = sqls.dataTable("dpjptype")
        lueSebagai.Properties.DisplayMember = "content"
        lueSebagai.Properties.ValueMember = "id"
        lueSebagai.EditValue = Nothing
        If sqls.getDataSet("dpjptype") = 0 Then
            dizMsgbox("DPJP Type tidak ditemukan" & vbCrLf & "DPJP Type harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If
    End Sub

    Private idselect As String = "-1"

    Private iddeptselect As String = "-1"
    Private idunitselect As String = "-1"
    Private isFromLoad As Boolean = True

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub kosongkan()
        kosongkanIsian(tlpRegistrasi)
        kosongkanIsian(tlpPasien)
        kosongkanIsian(tlpAlamat)
        kosongkanIsian(tlppParamedis)
        If lueParamedis.EditValue Is Nothing Then
            lueSpesialis.Properties.DataSource = Nothing
            lueSpesialis.EditValue = Nothing
        End If

        teNoRegistrasi.Text = ""
        teNoRegistrasi.Tag = 0
        teNoRM.Tag = 0
        teNoRM.Text = 0
        teTanggalRegistrasi.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        teGolonganDarah.Tag = ""
        teJenisKelamin.Tag = ""
        teWarganegara.Tag = ""

        btnSearch.Enabled = True
        statData = statusData.Baru

        iddeptselect = 0
        idunitselect = 0
        idselect = "-1"
        loadDPJP(idselect)
        'showCPPT(idselect, 1)
        showCPPT(idselect, 1, Nothing)

        tmrCek.Stop()
        tlpParamedis.Enabled = True

        btnSearch.Enabled = True
        btnAllDPJP.Enabled = False
        btnHapusCPPT.Enabled = False

        btnBaruParamedis.Enabled = False
        btnSimpanParamedis.Enabled = False
        btnDeleteParamedis.Enabled = False

        btnNew.Enabled = False
        btnSimpanSOAP.Enabled = False
    End Sub

    Private iddso As String = "-1"
    Private jenistransselectso As String = ""
    Private idtransselectso As String = "0"
    Private formatstringso As String = ""
    Private formatperiodeso As String = ""

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If isFromLoad = True Then
            kosongkanIsian(tlpRegistrasi)
            kosongkanIsian(tlpPasien)
            kosongkanIsian(tlpAlamat)
            kosongkanIsian(tlppParamedis)
            If lueParamedis.EditValue Is Nothing Then
                lueSpesialis.Properties.DataSource = Nothing
                lueSpesialis.EditValue = Nothing
            End If

            btnBaruParamedis_Click(Me, Nothing)
            btnNew_Click(Me, Nothing)

            teNoRegistrasi.Text = ""
            teNoRegistrasi.Tag = 0
            teNoRM.Tag = 0
            teNoRM.Text = 0
            teTanggalRegistrasi.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
            teGolonganDarah.Tag = ""
            teJenisKelamin.Tag = ""
            teWarganegara.Tag = ""

            btnSearch.Enabled = True
            statData = statusData.Baru

            iddeptselect = 0
            idunitselect = 0
            idselect = "-1"
            loadDPJP(idselect)
            'showCPPT(idselect, 1)
            showCPPT(idselect, 1, Nothing)

            tmrCek.Stop()
            tlpParamedis.Enabled = True

            btnSearch.Enabled = True
            btnAllDPJP.Enabled = False
            btnHapusCPPT.Enabled = False

            btnBaruParamedis.Enabled = False
            btnSimpanParamedis.Enabled = False
            btnDeleteParamedis.Enabled = False

            btnNew.Enabled = False
            btnSimpanSOAP.Enabled = False
        Else
            If idselect <> "-1" Then
                If dizMsgbox("Perubahan Form ICU sudah disimpan ?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
                    Exit Sub
                End If
            End If
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select r.idregistrasi,convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as 'Tgl Registrasi',case when r.isoneday=1 then r.registrasino + ' (ODS)' else r.registrasino end as 'No Registrasi',pm.nama as 'Tenaga Medis',dbo.fformatnorm(rm.rekammedisno) as 'No RM',rm.nama as 'Nama Pasien',jk.generalcode as 'Jenis Kelamin',convert(varchar,rm.tanggallahir,105) as 'Tgl Lahir',dbo.fUmurRegister(rm.tanggallahir,r.registrasidate) as 'Umur',kw.wilayah as 'Kewarganegaraan' from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' left join wilayah kw on rm.kewarganegaraan=kw.idwilayah  left join paramedis pm on r.iddokterruangan=pm.idparamedis where r.registrasistatus=0 and rm.rekammedisno<>0 and r.iddepartment in (select top 1 [value] from sys_appsetting where variable in ('IDICUDept','IDICCUDept','IDHCUDept')) order by r.registrasidate desc", "search")
            Dim cari As New frmSearch(sqls.dataSet, "search", "idregistrasi")
            tambahChild(cari)

            If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
                btnBaruParamedis_Click(Me, Nothing)
                btnNew_Click(Me, Nothing)

                kosongkan()

                sqls = New SQLs(dbstring)
                sqls.DMLQuery("select isnull(dbo.fGetUsername(lockby),0) as username,isnull(dbo.fGetUsernama(lockby),'-') as nama,isnull(lockipaddress,'0.0.0.0') as lockipaddress from registrasi where datediff(second,lockdate,getdate())<=convert(int,(select isnull(value,4) from sys_appsetting where variable='TimeoutRegister')) and idregistrasi='" & CStr(cari.GetIDSelectData) & "'", "ceklock")
                If sqls.getDataSet("ceklock") > 0 Then
                    dizMsgbox("Sedang digunakan oleh" & vbCrLf &
                              sqls.getDataSet("ceklock", 0, "username") & " (" & sqls.getDataSet("ceklock", 0, "username") & ")" & vbCrLf &
                              "IP Address " & sqls.getDataSet("ceklock", 0, "lockipaddress"), dizMsgboxStyle.Info, Me)
                    Exit Sub
                End If

                teNoRegistrasi.Text = ""

                idselect = CStr(cari.GetIDSelectData)
                tmrCek.Start()

                sqls.DMLQuery("select r.isoneday,r.asalpx,r.asalpx2,r.asalrujukan,r.iddokterrujukan,r.idrekammedis,r.iddepartment,r.idunit,r.registrasino,convert(varchar,r.registrasidate,105) + ' '+convert(varchar,r.registrasidate,108) as registrasidate,ha.generalcode as hamil from registrasi r left join sys_generalcode ha on r.ishamil=ha.idgeneral and ha.gctype='ISHAMIL' where r.idregistrasi='" & idselect & "'", "getidrm")
                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                field.AddRange(New String() {"@idrm"})
                value.AddRange(New Object() {sqls.getDataSet("getidrm", 0, "idrekammedis")})
                sqls.CallSP("spGetPasienRegistrasi", "registrasi", field, value)

                iddeptselect = sqls.getDataSet("getidrm", 0, "iddepartment")
                idunitselect = sqls.getDataSet("getidrm", 0, "idunit")

                teNoRegistrasi.Tag = idselect
                noreg = sqls.getDataSet("getidrm", 0, "registrasino")
                teNoRegistrasi.Text = noreg

                idreg = idselect
                teTanggalRegistrasi.Text = sqls.getDataSet("getidrm", 0, "registrasidate")

                teNoRM.Text = sqls.getDataSet("registrasi", 0, "rekammedisno")
                teJenisKartu.Text = sqls.getDataSet("registrasi", 0, "jeniskartu")
                teNomorKartu.Text = sqls.getDataSet("registrasi", 0, "nomorkartu")
                teHamil.Text = sqls.getDataSet("getidrm", 0, "hamil")
                teGolonganDarah.Text = sqls.getDataSet("registrasi", 0, "golongandarah")
                teRhesus.Text = sqls.getDataSet("registrasi", 0, "rhesus")

                teNoRM.Tag = sqls.getDataSet("registrasi", 0, "idrekammedis")
                teNamaPanggilan.Text = sqls.getDataSet("registrasi", 0, "namapanggilan")
                teNama.Text = sqls.getDataSet("registrasi", 0, "namapanggilan")
                teJenisKelamin.Text = sqls.getDataSet("registrasi", 0, "jeniskelamin")
                teJenisKelamin.Tag = sqls.getDataSet("registrasi", 0, "idjeniskelamin")

                teWarganegara.Text = sqls.getDataSet("registrasi", 0, "warganegara")
                teTanggalLahir.Text = sqls.getDataSet("registrasi", 0, "tanggallahir")
                teUmur.Text = sqls.getDataSet("registrasi", 0, "usia")

                Dim pair2 As KeyValuePair(Of String, String) = generateno2(idunitselect, iddeptselect, "SOAPMedis", True)
                idtransselectso = pair2.Key
                teNoSOAP.Text = pair2.Value
                teTanggalSOAP.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")

                sqls.DMLQuery("select jenistransaksi,formatstring,formatperiode from transactiontype where idtransactiontype='" & idtransselectso & "'", "getttso")
                jenistransselectso = sqls.getDataSet("getttso", 0, "jenistransaksi")
                formatstringso = sqls.getDataSet("getttso", 0, "formatstring")
                formatperiodeso = sqls.getDataSet("getttso", 0, "formatperiode")

                loadDPJP(idselect)
                'showCPPT(idselect, 1)
                showCPPT(idselect, 1, Nothing)
                btnAllDPJP.Text = "SEMUA CPPT"

                tlpParamedis.Enabled = True

                btnSearch.Enabled = True
                btnAllDPJP.Enabled = True
                btnHapusCPPT.Enabled = True

                btnBaruParamedis.Enabled = True
                btnSimpanParamedis.Enabled = True
                btnDeleteParamedis.Enabled = True

                btnNew.Enabled = True
                btnSimpanSOAP.Enabled = True
                btnNew_Click(btnNew, Nothing)
                btnBaruParamedis_Click(btnBaruParamedis, Nothing)
            End If
        End If
        isFromLoad = False
    End Sub

    Private ipadd As String
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        tmrCek.Stop()
        ipadd = getIPAddress(ipaddparam.IP)

        loadLOV()
        btnSearch_Click(Me, Nothing)
    End Sub

    Private noreg As String = ""
    Private idreg As String = "-1"

    Private Sub PrintPageHandler(ByVal sender As Object,
       ByVal args As Printing.PrintPageEventArgs)
    End Sub

    Private Sub PreviewForm_Load(sender As Object, ByVal e As EventArgs)
        Dim frm As DevExpress.XtraPrinting.Preview.PrintPreviewFormEx = CType(sender, DevExpress.XtraPrinting.Preview.PrintPreviewFormEx)
        frm.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.Scale, New Object() {1.0F})
    End Sub

    Private Sub btnAllDPJP_Click(sender As Object, e As EventArgs) Handles btnAllDPJP.Click
        If btnAllDPJP.Text = "SEMUA CPPT" Then
            'showCPPT(idselect, 1)
            showCPPT(idselect, 1, deTanggalCPPT.EditValue)
            btnAllDPJP.Text = "CPPT AKTIF"
        Else
            'showCPPT(idselect, 0)
            showCPPT(idselect, 0, deTanggalCPPT.EditValue)
            btnAllDPJP.Text = "SEMUA CPPT"
        End If
    End Sub

    Private iddpjp As String = "-1"
    Private Sub btnSimpanParamedis_Click(sender As Object, e As EventArgs) Handles btnSimpanParamedis.Click
        Dim cek As Boolean = True
        If lueParamedis.EditValue Is Nothing Then
            cek = False
        End If
        If lueSpesialis.EditValue Is Nothing Then
            cek = False
        End If
        If lueSebagai.EditValue Is Nothing Then
            cek = False
        End If
        If cek = False Then
            dizMsgbox("Isian Paramedis belum benar", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        iddpjp = GenerateGUID()
        Dim dts As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idregistrasidpjp", "idregistrasi", "idparamedis", "idspesialis", "dpjptype", "remarks", "createdby", "idcompany"})
        value.AddRange(New Object() {iddpjp, idselect, lueParamedis.EditValue, If(lueSpesialis.EditValue, 0), lueSebagai.EditValue, "", userid, idcomp})
        Dim cekb As Boolean = dts.datasetSave("registrasidpjp", iddpjp, field, value, False)

        If cekb = True Then
            dizMsgbox("Paramedis telah tersimpan", dizMsgboxStyle.Info, Me)
            dpjpbaru()
        End If
        loadDPJP(idselect)
    End Sub

    Private Sub loadDPJP(idreg As String)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select jp.idregistrasidpjp,jp.idparamedis,jp.idspesialis,jp.dpjptype,p.nama as paramedis,s.nama as spesialis,jp.isdeleted,dt.generalcode as sebagai,del.generalcode as statdata,p.nama + ' - ' + dt.generalcode + char(13) + char(10) + s.nama as remarks from registrasidpjp jp left join paramedis p on jp.idparamedis=p.idparamedis left join spesialis s on jp.idspesialis=s.idspesialis left join sys_generalcode dt on jp.dpjptype=dt.idgeneral and dt.gctype='DPJPTYPE' left join sys_generalcode del on jp.isdeleted=del.idgeneral and del.gctype='DELETE' where jp.idregistrasi='" & idreg & "' order by p.nama asc", "paramedis")
        gcParamedis.DataSource = sqls.dataTable("paramedis")
        gvParamedis.BestFitColumns()
    End Sub

    Private Sub dpjpbaru()
        lueParamedis.EditValue = Nothing
        lueSpesialis.EditValue = Nothing
        iddpjp = "-1"
    End Sub

    Private Sub lueParamedis_EditValueChanged(sender As Object, e As EventArgs) Handles lueParamedis.EditValueChanged
        If lueParamedis.EditValue Is Nothing Then
            lueSpesialis.Properties.DataSource = Nothing
            lueSpesialis.EditValue = Nothing
        Else
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select sp.idspesialis as id,sp.nama as content from spesialis sp left join paramedisspesialis ps on sp.idspesialis=ps.idspesialis where ps.idparamedis='" & lueParamedis.EditValue & "'", "sp")
            lueSpesialis.Properties.DataSource = sqls.dataTable("sp")
            lueSpesialis.Properties.ValueMember = "id"
            lueSpesialis.Properties.DisplayMember = "content"
            If sqls.getDataSet("sp") = 1 Then
                lueSpesialis.EditValue = sqls.getDataSet("sp", 0, "id")
            Else
                lueSpesialis.EditValue = Nothing
            End If
        End If
    End Sub


    Private Sub tmrCek_Tick(sender As Object, e As EventArgs) Handles tmrCek.Tick
        If idselect = "-1" Then
            Exit Sub
        End If

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim dtst As New dtsetSQLS(dbstring)
        field.AddRange(New String() {"idregistrasi", "lockby", "lockdate", "lockipaddress"})
        value.AddRange(New Object() {idselect, userid, nowTime, ipadd})
        dtst.datasetSave("registrasi", idselect, field, value, False)
    End Sub

    Private Sub btnDeleteParamedis_Click(sender As Object, e As EventArgs) Handles btnDeleteParamedis.Click
        If gvParamedis.FocusedRowHandle < 0 Then
            dizMsgbox("DPJP yang akan dihapus belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If

        Dim id As String = gvParamedis.GetRowCellValue(gvParamedis.FocusedRowHandle, "idregistrasidpjp")
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("update registrasidpjp set isdeleted=1,updatedby='" & userid & "',updateddate=getdate() where idregistrasidpjp='" & id & "'", False)
        loadDPJP(idselect)
    End Sub

    Private Sub btnCetakGelang_Click(sender As Object, e As EventArgs) Handles btnCetakGelang.Click
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select r.idregistrasi,convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as 'Tgl Registrasi',r.registrasino as 'No Registrasi',pm.nama as 'Tenaga Medis',dbo.fformatnorm(rm.rekammedisno) as 'No RM',rm.nama as 'Nama Pasien',jk.generalcode as 'Jenis Kelamin',convert(varchar,rm.tanggallahir,105) as 'Tgl Lahir',dbo.fUmurRegister(rm.tanggallahir,r.registrasidate) as 'Umur',kw.wilayah as 'Kewarganegaraan' from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' left join wilayah kw on rm.kewarganegaraan=kw.idwilayah  left join paramedis pm on r.iddokterruangan=pm.idparamedis where (r.registrasistatus=0 and rm.rekammedisno<>0 and r.iddepartment=(select top 1 [value] from sys_appsetting where variable='idirnadept')) or (r.registrasistatus=0 and rm.rekammedisno<>0 and r.isoneday=1 and r.iddepartment=(select top 1 [value] from sys_appsetting where variable='idigddept')) order by r.registrasidate desc", "search")
        Dim cari As New frmSearch(sqls.dataSet, "search", "idregistrasi")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim idselectu As String = CStr(cari.GetIDSelectData)
            sqls.DMLQuery("select idregistrasi,registrasino,convert(varchar,registrasidate,105) + ' ' + convert(varchar,registrasidate,108) as registrasidate,idrekammedis from registrasi where idregistrasi='" & idselectu & "'", "getid")
            Dim idregu As String = CStr(sqls.getDataSet("getid", 0, "idregistrasi"))
            Dim strnodata As String = sqls.getDataSet("getid", 0, "registrasino")
            Dim strregdate As String = sqls.getDataSet("getid", 0, "registrasidate")
            Dim idrmu As String = CStr(sqls.getDataSet("getid", 0, "idrekammedis"))

            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"@idrm"})
            value.AddRange(New Object() {idrmu})
            sqls.CallSP("spGetPasienRegistrasi", "getpasienreg", field, value)

            Dim strnama As String = sqls.getDataSet("getpasienreg", 0, "nama")
            Dim strjnskelamin As String = sqls.getDataSet("getpasienreg", 0, "jeniskelamin")
            Dim strnorm As String = sqls.getDataSet("getpasienreg", 0, "rekammedisno")
            Dim strTglLahir As String = sqls.getDataSet("getpasienreg", 0, "tanggallahir")
            Dim dtTglLahir = Strdate2Date(strTglLahir)
            Dim strUmur As String = sqls.getDataSet("getpasienreg", 0, "usia")
            Dim idjnskelamin As String = sqls.getDataSet("getpasienreg", 0, "idjeniskelamin")

            Dim lstdata As New List(Of String)
            lstdata.Add(idregu)
            lstdata.Add(strnama)
            lstdata.Add(strnorm)
            lstdata.Add("Tgl. Lahir " & dtTglLahir.Day & " " & NamaBulan(dtTglLahir.Month) & " " & dtTglLahir.Year)
            lstdata.Add(strnodata)
            lstdata.Add("Umur " & strUmur)
            lstdata.Add(strregdate)
            lstdata.Add(strjnskelamin)

            'Dim prntname As String = ""
            'Dim sd As New frmSelectDevice
            'tambahChild(sd)
            'If sd.ShowDialog() = DialogResult.OK Then
            '    prntname = sd.getdevicename
            Dim selectWB As New frmWristbandSelect
            tambahChild(selectWB)
            selectWB.ShowDialog()
            If selectWB.getStringPilih = "Dewasa" Then
                If idjnskelamin = "0" Then
                    Dim sharename As String = getPrinter("WRBAF")
                    If sharename <> "" Then
                        cetakWristband(lstdata, sharename)
                    Else
                        dizMsgbox("Printer belum disetting untuk cetak dokumen ini", dizMsgboxStyle.Peringatan, Me)
                    End If
                Else
                    Dim sharename As String = getPrinter("WRBAM")
                    If sharename <> "" Then
                        cetakWristband(lstdata, sharename)
                    Else
                        dizMsgbox("Printer belum disetting untuk cetak dokumen ini", dizMsgboxStyle.Peringatan, Me)
                    End If
                End If
            ElseIf selectWB.getStringPilih = "Anak" Then
                Dim sharename As String = getPrinter("WRBB")
                If sharename <> "" Then
                    cetakWristband(lstdata, sharename)
                Else
                    dizMsgbox("Printer belum disetting untuk cetak dokumen ini", dizMsgboxStyle.Peringatan, Me)
                End If
            End If
            'End If
            'cetakWristband(lstdata, "")
        End If
    End Sub

    Private Sub btnHistoriPasien_Click(sender As Object, e As EventArgs) Handles btnHistoriPasien.Click
        If idselect = "-1" Then
            dizMsgbox("Register belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        formTitle = ""
        Dim frmMon As New frmMonHistoriPasien(teNoRM.Tag)
        tambahChild(frmMon)
        frmMon.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        frmMon.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        frmMon.StartPosition = FormStartPosition.CenterScreen
        frmMon.pMinimize.Enabled = False
        frmMon.pMaximize.Enabled = False
        frmMon.tlpForm.RowCount = 4
        frmMon.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        frmMon.ShowDialog(Me)
        formTitle = Me.lblTitle.Text
    End Sub

    Private Sub btnRegStatus_Click(sender As Object, e As EventArgs) Handles btnRegStatus.Click
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select variable,value from sys_appsetting where variable in('idicudept','idiccudept','idhcudept')", "getid")
        Dim rs As New frmRegistrasiUpdate(sqls.getDataSet("getid", 0, "value").ToString)
        tambahChild(rs)
        rs.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        rs.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        rs.StartPosition = FormStartPosition.CenterScreen
        rs.tlpForm.RowCount = 4
        rs.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        rs.ShowDialog(Me)
    End Sub

    Private Sub btnMonReg_Click(sender As Object, e As EventArgs) Handles btnMonReg.Click
        formTitle = ""
        Dim rs As New frmMonRegisterICUday()
        tambahChild(rs)
        rs.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        rs.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        rs.StartPosition = FormStartPosition.CenterScreen
        rs.tlpForm.RowCount = 4
        rs.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        rs.ShowDialog(Me)
    End Sub


    Private Sub gvParamedis_FocusedColumnChanged(sender As Object, e As FocusedColumnChangedEventArgs) Handles gvParamedis.FocusedColumnChanged
        If gvParamedis.RowCount = 1 Then
            Try
                Dim dcol As DataRow = gvParamedis.GetDataRow(0)
                lueParamedis.EditValue = dcol("idparamedis")
                lueSpesialis.EditValue = dcol("idspesialis")

                iddpjp = dcol("idregistrasidpjp")

                Dim isdeleted As Integer = dcol("isdeleted")
                If isdeleted = 1 Then
                    btnDeleteParamedis.Text = "AKTIF"
                Else
                    btnDeleteParamedis.Text = "HAPUS"
                End If

                btnSimpanParamedis.Enabled = True
                btnDeleteParamedis.Enabled = True
            Catch ex As Exception
                dpjpbaru()
            End Try
        End If
    End Sub

    Private Sub btnBaruParamedis_Click(sender As Object, e As EventArgs) Handles btnBaruParamedis.Click
        dpjpbaru()
    End Sub

    Private Sub btnoRadiologi_Click(sender As Object, e As EventArgs) Handles btnoRadiologi.Click
        If idselect = "-1" Then
            dizMsgbox("Register belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        formTitle = ""
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select iddepartment,idunit from registrasi where idregistrasi='" & idselect & "'", "getiddeptunit")
        Dim idtmpunit As String = sqls.getDataSet("getiddeptunit", 0, "idunit")
        Dim idtmpdept As String = sqls.getDataSet("getiddeptunit", 0, "iddepartment")
        Dim frmOrder As New frmOrderRadiologi(idtmpunit, idtmpdept, idselect)
        tambahChild(frmOrder)
        frmOrder.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        frmOrder.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        frmOrder.StartPosition = FormStartPosition.CenterScreen
        frmOrder.pMinimize.Enabled = False
        frmOrder.pMaximize.Enabled = False
        frmOrder.tlpForm.RowCount = 4
        frmOrder.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        frmOrder.ShowDialog(Me)
        formTitle = Me.lblTitle.Text
    End Sub

    Private Sub btnoLaborat_Click(sender As Object, e As EventArgs) Handles btnoLaborat.Click
        If idselect = "-1" Then
            dizMsgbox("Register belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        formTitle = ""
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select iddepartment,idunit from registrasi where idregistrasi='" & idselect & "'", "getiddeptunit")
        Dim idtmpunit As String = sqls.getDataSet("getiddeptunit", 0, "idunit")
        Dim idtmpdept As String = sqls.getDataSet("getiddeptunit", 0, "iddepartment")
        Dim frmOrder As New frmOrderLaboratorium(idtmpunit, idtmpdept, idselect)
        tambahChild(frmOrder)
        frmOrder.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        frmOrder.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        frmOrder.StartPosition = FormStartPosition.CenterScreen
        frmOrder.pMinimize.Enabled = False
        frmOrder.pMaximize.Enabled = False
        frmOrder.tlpForm.RowCount = 4
        frmOrder.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        frmOrder.ShowDialog(Me)
        formTitle = Me.lblTitle.Text
    End Sub

    Private Sub btnInfoPasien_Click(sender As Object, e As EventArgs) Handles btnInfoPasien.Click
        If idselect = "-1" Then
            dizMsgbox("Register belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        formTitle = ""
        Dim frminfopx As New frmInfoPasien(teNoRM.Tag)
        tambahChild(frminfopx)
        frminfopx.StartPosition = FormStartPosition.CenterScreen
        frminfopx.pMinimize.Enabled = False
        frminfopx.pMaximize.Enabled = False
        frminfopx.tlpForm.RowCount = 4
        frminfopx.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        frminfopx.ShowDialog(Me)
        formTitle = Me.lblTitle.Text
    End Sub

    Private Sub btnSimpanSOAP_Click(sender As Object, e As EventArgs) Handles btnSimpanSOAP.Click
        If lueParamedisSOAP.EditValue Is Nothing Then
            dizMsgbox("Paramedis belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        Dim cekbool As Boolean = True

        If meSubjektif.Text = "" Then cekbool = False
        If meObjektif.Text = "" Then cekbool = False
        If meAssessment.Text = "" Then cekbool = False
        If mePlanning.Text = "" Then cekbool = False

        If cekbool = False Then
            dizMsgbox("SOAP belum lengkap", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If

        prosesSimpanSOAP()
        showCPPT(idselect, 0, deTanggalCPPT.EditValue)
    End Sub

    Private Function prosesSimpanSOAP() As Boolean
        Dim cek As Boolean = True
        If modCore.checkEntry(tlppSOAP) = False Then
            dizMsgbox("SOAP belum benar", dizMsgboxStyle.Peringatan, Me)
            cek = False
        End If
        Dim strdk As String = mePlanning.Text.Replace(" ", "")
        strdk = strdk.ToLower
        If strdk.Contains("rencanadiagnosa") Then
            dizMsgbox("Rencana Diagnosa tidak perlu mencantumkan 'Rencana Diagnosa'", dizMsgboxStyle.Peringatan, Me)
            cek = False
        End If
        'Dim strdb As String = meRencanaTerapi.Text.Replace(" ", "")
        'strdb = strdb.ToLower
        'If strdb.Contains("rencanaterapi/program/tindakan") Then
        '    dizMsgbox("Rencana Terapi tidak perlu mencantumkan 'Rencana Terapi/Program/Tindakan'", dizMsgboxStyle.Peringatan, Me)
        '    cek = False
        'End If
        'If mouseClicked = False Then
        '    dizMsgbox("Anatomi belum benar", dizMsgboxStyle.Peringatan, Me)
        '    cek = False
        'End If

        If cek = True Then
            If iddso = "-1" Then
                Dim pair As KeyValuePair(Of String, String) = generateno2(idunitselect, iddeptselect, "SOAPMedis", False)
                idtransselectso = pair.Key
                teNoSOAP.Text = pair.Value
            End If

            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select iddokterruangan,idspesialisruangan from registrasi where idregistrasi='" & idreg & "'", "getidsp")
            Dim idparru As String = sqls.getDataSet("getidsp", 0, "iddokterruangan")
            Dim idspru As String = sqls.getDataSet("getidsp", 0, "idspesialisruangan")

            'sqls.DMLQuery("select d.idanalisarmdt,d.idicd,d.jenisdiagnosa,jd.generalcode as jnsdiagnosa,i.icdtype,i.kode,i.diagnosa,i.remarks,d.isdeleted,del.generalcode as statdata,it.generalcode as jenisicd from analisarmdt d left join icd i on d.idicd=i.idicd left join sys_generalcode del on d.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode it on i.icdtype=it.idgeneral and it.gctype='ICDTYPE' left join sys_generalcode jd on d.jenisdiagnosa=jd.idgeneral and jd.gctype='JENISDIAGNOSA' where d.analisarmtype=1 and d.isdeleted=0 and d.idsoapnote='" & iddso & "' and d.idregistrasi='" & idreg & "' order by d.jenisdiagnosa asc,d.createddate desc", "getdiagnosa")
            'If sqls.getDataSet("getdiagnosa") > 0 Then
            '    Me.meAssessment.Text = ""
            '    For i As Integer = 0 To sqls.getDataSet("getdiagnosa") - 1
            '        meAssessment.Text &= sqls.getDataSet("getdiagnosa", i, "diagnosa")
            '        If i < sqls.getDataSet("getdiagnosa") - 1 Then
            '            meAssessment.Text &= vbCrLf
            '        End If
            '    Next
            'Else
            '    meAssessment.Text = ""
            'End If

            iddso = GenerateGUID()
            'Dim strguid As String = GenerateUniqueID(GenerateHash(Format(nowTime, "ddMMyyyyHHmmssff") & idhostname), 1000)
            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            Dim dtsqls2 As New dtsetSQLS(dbstring)
            Dim field2 As New List(Of String)
            Dim value2 As New List(Of Object)
            field2.AddRange(New String() {"idsoapnote", "idregistrasi", "transactiontype", "soapnotetype", "soapnoteno", "soapnotedate", "subyektif", "obyektif", "asesmen", "planning", "createdby", "createddate", "idparamediscreator", "idspesialiscreator", "paramediscreatortype"})
            value2.AddRange(New Object() {iddso, idselect, idtransselectso, 4, teNoSOAP.Text, nowTime, meSubjektif.Text, meObjektif.Text, meAssessment.Text, mePlanning.Text, userid, nowTime, If(lueParamedisSOAP.EditValue, "0"), If(lueSpesialisSOAP.EditValue, "0"), 8}) 'idparru, idspru,
            cek = dtsqls2.datasetSave("soapnote", iddso, field2, value2, False)
            'sqls.DMLQuery("select idsoapnote from soapnote where hashcode='" & strguid & "'", "getidso")
            '    iddso = cstr(sqls.getDataSet("getidso", 0, "idsoapnote"))
        End If

        If cek = True Then
            dizMsgbox("SOAP Note telah tersimpan", dizMsgboxStyle.Info, Me)
            btnNew_Click(btnNew, Nothing)
        End If
        Return cek
    End Function

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        iddso = "-1"
        teNoSOAP.EditValue = Nothing
        teTanggalSOAP.EditValue = Nothing

        Dim pair2 As KeyValuePair(Of String, String) = generateno2(idunitselect, iddeptselect, "SOAPMedis", True)
        idtransselectso = pair2.Key
        teNoSOAP.Text = pair2.Value
        teTanggalSOAP.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")

        meSubjektif.Text = ""
        meObjektif.Text = ""
        meAssessment.Text = ""
        mePlanning.Text = ""
        lueSpesialisSOAP.EditValue = Nothing
        lueParamedisSOAP.EditValue = Nothing
    End Sub

    Private Sub btnBaruDiagnosaKerja_Click(sender As Object, e As EventArgs)
        If idselect = "-1" Then
            dizMsgbox("Registrasi belum dipilih", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If
        If iddso = "-1" Then
            dizMsgbox("Soap Note disimpan terlebih dulu", dizMsgboxStyle.Kesalahan, Me)
            Exit Sub
        End If

        Dim diagkerja As New frmDiagnosaKerja(iddso, idreg, "ICU")
        tambahChild(diagkerja)
        diagkerja.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        diagkerja.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        diagkerja.StartPosition = FormStartPosition.CenterScreen
        diagkerja.tlpForm.RowCount = 4
        diagkerja.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        diagkerja.ShowDialog(Me)

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select d.idanalisarmdt,d.idicd,d.jenisdiagnosa,jd.generalcode as jnsdiagnosa,i.icdtype,i.kode,i.diagnosa,d.remarks,d.isdeleted,del.generalcode as statdata,it.generalcode as jenisicd from analisarmdt d left join icd i on d.idicd=i.idicd left join sys_generalcode del on d.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode it on i.icdtype=it.idgeneral and it.gctype='ICDTYPE' left join sys_generalcode jd on d.jenisdiagnosa=jd.idgeneral and jd.gctype='JENISDIAGNOSA' where d.analisarmtype=1 and d.isdeleted=0 and d.idsoapnote='" & iddso & "' and d.idregistrasi='" & idreg & "' order by d.jenisdiagnosa asc,d.createddate desc", "getdiagnosa")
        If sqls.getDataSet("getdiagnosa") > 0 Then
            Me.meAssessment.Text = ""
            For i As Integer = 0 To sqls.getDataSet("getdiagnosa") - 1
                If sqls.getDataSet("getdiagnosa", i, "remarks") = "-" Then
                    meAssessment.Text &= sqls.getDataSet("getdiagnosa", i, "diagnosa")
                Else
                    meAssessment.Text &= sqls.getDataSet("getdiagnosa", i, "diagnosa") & " - " & sqls.getDataSet("getdiagnosa", i, "remarks")
                End If
                If i < sqls.getDataSet("getdiagnosa") - 1 Then
                    meAssessment.Text &= vbCrLf
                End If
            Next
        Else
            meAssessment.Text = ""
        End If
        diagkerja.Dispose()

        If iddso <> "-1" Then
            Dim dtsqls2 As New dtsetSQLS(dbstring)
            Dim field2 As New List(Of String)
            Dim value2 As New List(Of Object)
            field2.AddRange(New String() {"idsoapnote", "asesmen", "updatedby", "updateddate"})
            value2.AddRange(New Object() {teNoSOAP.Tag, meAssessment.Text, userid, nowTime})
            dtsqls2.datasetSave("soapnote", teNoSOAP.Tag, field2, value2, False)
        End If
    End Sub

    'Private Sub showCPPT(Optional idreg As String = "0", Optional isdeleted As Long = 0)
    Private Sub showCPPT(Optional idreg As String = "0", Optional isdeleted As Long = 0, Optional tanggal As Object = Nothing)
        'DPJP
        If tanggal Is Nothing Then tanggal = nowTime
        Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select idregistrasiparent,idrekammedis from registrasi where idregistrasi='" & idreg & "'", "getidparent")
        Dim idparent As String = "-"
        Dim idrm As String = "-"
        If sqls.getDataSet("getidparent") > 0 Then
            idparent = sqls.getDataSet("getidparent", 0, "idregistrasiparent").ToString
            idrm = sqls.getDataSet("getidparent", 0, "idrekammedis").ToString
        End If

        If isdeleted = 1 Then
            sqls.DMLQuery("select case when tt.iddepartment in (select value from sys_appsetting where variable in('IDICUDept','IDICCUDept','IDHCUDept')) then 'OK' else 'NOT' end as cekdept,dp.idsoapnote,dp.idparamediscreator,dp.idspesialiscreator,dp.paramediscreatortype,pa.nama as paramedis,ps.nama as spesialis,dt.generalcode as dpjptype,sd.generalcode as statdata,dp.planning,dt.priority as dpjpprioritas,dp.isdeleted,case when pt.idreff=1 then isnull(pa.nama,0) + isnull(' (' + ps.nama + ')' ,'') + case when reviewedby is null then ' - Belum Direview' else ' - Sudah Direview' end + char(13) + char(10) + 'sebagai ' + dt.generalcode + ' ' + convert(varchar,dp.createddate,105) + ' ' + convert(varchar,dp.createddate,108) + char(13) + char(10) + 'S: ' + dp.subyektif + char(13) + char(10) + 'B: ' + dp.obyektif + char(13) + char(10) + 'A: ' + dp.asesmen + char(13) + char(10) + 'R: ' + dp.planning else isnull(pa.nama,0) + isnull(' (' + ps.nama + ')' ,'') + case when reviewedby is null then ' - Belum Direview' else ' - Sudah Direview' end + char(13) + char(10) + 'sebagai ' + dt.generalcode + ' ' + convert(varchar,dp.createddate,105) + ' ' + convert(varchar,dp.createddate,108) + char(13) + char(10) + 'S: ' + dp.subyektif + char(13) + char(10) + 'O: ' + dp.obyektif + char(13) + char(10) + 'A: ' + dp.asesmen + char(13) + char(10) + 'P: ' + dp.planning end as note from soapnote dp left join registrasi reg on dp.idregistrasi=reg.idregistrasi left join transactiontype tt on dp.transactiontype=tt.idtransactiontype left join spesialis ps on dp.idspesialiscreator=ps.idspesialis left join paramedis pa on dp.idparamediscreator=pa.idparamedis left join sys_generalcode pt on pa.paramedistype=pt.idgeneral and pt.gctype='PARAMEDISTYPE' left join sys_generalcode dt on dp.paramediscreatortype=dt.idgeneral and dt.gctype='DPJPTYPE' left join sys_generalcode sd on dp.isdeleted=sd.idgeneral and sd.gctype='DELETE' where reg.idrekammedis='" & idrm & "' and convert(varchar,dp.soapnotedate,105)='" & Format(tanggal, "dd-MM-yyyy") & "' and dp.soapnotetype=4 order by dp.createddate desc", "dpjp")
            'sqls.DMLQuery("select case when tt.iddepartment in (select value from sys_appsetting where variable in('IDICUDept','IDICCUDept','IDHCUDept')) then 'OK' else 'NOT' end as cekdept,dp.idsoapnote,dp.idparamediscreator,dp.idspesialiscreator,dp.paramediscreatortype,pa.nama as paramedis,ps.nama as spesialis,dt.generalcode as dpjptype,sd.generalcode as statdata,dp.planning,dt.priority as dpjpprioritas,dp.isdeleted,case when pt.idreff=1 then isnull(pa.nama,0) + isnull(' (' + ps.nama + ')' ,'') + case when reviewedby is null then ' - Belum Direview' else ' - Sudah Direview' end + char(13) + char(10) + 'sebagai ' + dt.generalcode + ' ' + convert(varchar,dp.createddate,105) + ' ' + convert(varchar,dp.createddate,108) + char(13) + char(10) + 'S: ' + dp.subyektif + char(13) + char(10) + 'B: ' + dp.obyektif + char(13) + char(10) + 'A: ' + dp.asesmen + char(13) + char(10) + 'R: ' + dp.planning else isnull(pa.nama,0) + isnull(' (' + ps.nama + ')' ,'') + case when reviewedby is null then ' - Belum Direview' else ' - Sudah Direview' end + char(13) + char(10) + 'sebagai ' + dt.generalcode + ' ' + convert(varchar,dp.createddate,105) + ' ' + convert(varchar,dp.createddate,108) + char(13) + char(10) + 'S: ' + dp.subyektif + char(13) + char(10) + 'O: ' + dp.obyektif + char(13) + char(10) + 'A: ' + dp.asesmen + char(13) + char(10) + 'P: ' + dp.planning end as note from soapnote dp left join transactiontype tt on dp.transactiontype=tt.idtransactiontype left join spesialis ps on dp.idspesialiscreator=ps.idspesialis left join paramedis pa on dp.idparamediscreator=pa.idparamedis left join sys_generalcode pt on pa.paramedistype=pt.idgeneral and pt.gctype='PARAMEDISTYPE' left join sys_generalcode dt on dp.paramediscreatortype=dt.idgeneral and dt.gctype='DPJPTYPE' left join sys_generalcode sd on dp.isdeleted=sd.idgeneral and sd.gctype='DELETE' where (dp.idregistrasi='" & idparent & "' or dp.idregistrasi='" & idreg & "') and dp.soapnotetype=4 order by dp.createddate desc", "dpjp")
        Else
            sqls.DMLQuery("select case when tt.iddepartment in (select value from sys_appsetting where variable in('IDICUDept','IDICCUDept','IDHCUDept')) then 'OK' else 'NOT' end as cekdept,dp.idsoapnote,dp.idparamediscreator,dp.idspesialiscreator,dp.paramediscreatortype,pa.nama as paramedis,ps.nama as spesialis,dt.generalcode as dpjptype,sd.generalcode as statdata,dp.planning,dt.priority as dpjpprioritas,dp.isdeleted,case when pt.idreff=1 then isnull(pa.nama,0) + isnull(' (' + ps.nama + ')' ,'') + case when reviewedby is null then ' - Belum Direview' else ' - Sudah Direview' end + char(13) + char(10) + 'sebagai ' + dt.generalcode + ' ' + convert(varchar,dp.createddate,105) + ' ' + convert(varchar,dp.createddate,108) + char(13) + char(10) + 'S: ' + dp.subyektif + char(13) + char(10) + 'B: ' + dp.obyektif + char(13) + char(10) + 'A: ' + dp.asesmen + char(13) + char(10) + 'R: ' + dp.planning else isnull(pa.nama,0) + isnull(' (' + ps.nama + ')' ,'') + case when reviewedby is null then ' - Belum Direview' else ' - Sudah Direview' end + char(13) + char(10) + 'sebagai ' + dt.generalcode + ' ' + convert(varchar,dp.createddate,105) + ' ' + convert(varchar,dp.createddate,108) + char(13) + char(10) + 'S: ' + dp.subyektif + char(13) + char(10) + 'O: ' + dp.obyektif + char(13) + char(10) + 'A: ' + dp.asesmen + char(13) + char(10) + 'P: ' + dp.planning end as note from soapnote dp left join registrasi reg on dp.idregistrasi=reg.idregistrasi left join transactiontype tt on dp.transactiontype=tt.idtransactiontype left join spesialis ps on dp.idspesialiscreator=ps.idspesialis left join paramedis pa on dp.idparamediscreator=pa.idparamedis left join sys_generalcode pt on pa.paramedistype=pt.idgeneral and pt.gctype='PARAMEDISTYPE' left join sys_generalcode dt on dp.paramediscreatortype=dt.idgeneral and dt.gctype='DPJPTYPE' left join sys_generalcode sd on dp.isdeleted=sd.idgeneral and sd.gctype='DELETE' where reg.idrekammedis='" & idrm & "' and convert(varchar,dp.soapnotedate,105)='" & Format(tanggal, "dd-MM-yyyy") & "' and dp.soapnotetype=4 and dp.isdeleted=0 order by dp.createddate desc", "dpjp")
            '            sqls.DMLQuery("select case when tt.iddepartment in (select value from sys_appsetting where variable in('IDICUDept','IDICCUDept','IDHCUDept')) then 'OK' else 'NOT' end as cekdept,dp.idsoapnote,dp.idparamediscreator,dp.idspesialiscreator,dp.paramediscreatortype,pa.nama as paramedis,ps.nama as spesialis,dt.generalcode as dpjptype,sd.generalcode as statdata,dp.planning,dt.priority as dpjpprioritas,dp.isdeleted,case when pt.idreff=1 then isnull(pa.nama,0) + isnull(' (' + ps.nama + ')' ,'') + case when reviewedby is null then ' - Belum Direview' else ' - Sudah Direview' end + char(13) + char(10) + 'sebagai ' + dt.generalcode + ' ' + convert(varchar,dp.createddate,105) + ' ' + convert(varchar,dp.createddate,108) + char(13) + char(10) + 'S: ' + dp.subyektif + char(13) + char(10) + 'B: ' + dp.obyektif + char(13) + char(10) + 'A: ' + dp.asesmen + char(13) + char(10) + 'R: ' + dp.planning else isnull(pa.nama,0) + isnull(' (' + ps.nama + ')' ,'') + case when reviewedby is null then ' - Belum Direview' else ' - Sudah Direview' end + char(13) + char(10) + 'sebagai ' + dt.generalcode + ' ' + convert(varchar,dp.createddate,105) + ' ' + convert(varchar,dp.createddate,108) + char(13) + char(10) + 'S: ' + dp.subyektif + char(13) + char(10) + 'O: ' + dp.obyektif + char(13) + char(10) + 'A: ' + dp.asesmen + char(13) + char(10) + 'P: ' + dp.planning end as note from soapnote dp left join transactiontype tt on dp.transactiontype=tt.idtransactiontype left join spesialis ps on dp.idspesialiscreator=ps.idspesialis left join paramedis pa on dp.idparamediscreator=pa.idparamedis left join sys_generalcode pt on pa.paramedistype=pt.idgeneral and pt.gctype='PARAMEDISTYPE' left join sys_generalcode dt on dp.paramediscreatortype=dt.idgeneral and dt.gctype='DPJPTYPE' left join sys_generalcode sd on dp.isdeleted=sd.idgeneral and sd.gctype='DELETE' where (dp.idregistrasi='" & idparent & "' or dp.idregistrasi='" & idreg & "') and dp.soapnotetype=4 and dp.isdeleted=0 order by dp.createddate desc", "dpjp")
        End If
        gcDPJP.DataSource = sqls.dataTable("dpjp")
        gvDPJP.BestFitColumns()
    End Sub

    Private Sub btnHapusCPPT_Click(sender As Object, e As EventArgs) Handles btnHapusCPPT.Click
        If gvDPJP.RowCount = 0 Then
            dizMsgbox("DPJP tidak ditemukan", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If gvDPJP.FocusedRowHandle < 0 Then
            dizMsgbox("DPJP yang akan dihapus belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If

        Dim id As String = gvDPJP.GetRowCellValue(gvDPJP.FocusedRowHandle, "idsoapnote")
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("update soapnote set isdeleted=1,updatedby='" & userid & "',updateddate=getdate() where idsoapnote='" & id & "'", False)
        'sqls.DMLQuery("update registrasidpjp set isdeleted=1,updatedby='" & userid & "',updateddate=getdate() where idregistrasidpjp='" & id & "'", False)

        dizMsgbox("DPJP yang dipilih telah dihapus", dizMsgboxStyle.Info, Me)
        If btnAllDPJP.Text = "SEMUA DPJP" Then
            showCPPT(idselect, 1, deTanggalCPPT.EditValue)
        Else
            showCPPT(idselect, 0, deTanggalCPPT.EditValue)
        End If
    End Sub

    Private soaptype As Long = 0
    Private Sub lueParamedisSOAP_EditValueChanged(sender As Object, e As EventArgs) Handles lueParamedisSOAP.EditValueChanged
        If lueParamedisSOAP.EditValue Is Nothing Then
            lueSpesialisSOAP.Properties.DataSource = Nothing
            lueSpesialisSOAP.EditValue = Nothing
            soaptype = 0
        Else
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select sp.idspesialis as id,sp.nama as content from spesialis sp left join paramedisspesialis ps on sp.idspesialis=ps.idspesialis where ps.idparamedis='" & lueParamedisSOAP.EditValue & "'", "sp")
            lueSpesialisSOAP.Properties.DataSource = sqls.dataTable("sp")
            lueSpesialisSOAP.Properties.ValueMember = "id"
            lueSpesialisSOAP.Properties.DisplayMember = "content"

            If sqls.getDataSet("sp") = 1 Then
                lueSpesialisSOAP.EditValue = sqls.getDataSet("sp", 0, "id")
            Else
                lueSpesialisSOAP.EditValue = Nothing
            End If
        End If
    End Sub

    Private Sub deTanggalCPPT_EditValueChanged(sender As Object, e As EventArgs) Handles deTanggalCPPT.EditValueChanged
        If btnAllDPJP.Text = "SEMUA DPJP" Then
            showCPPT(idselect, 1, deTanggalCPPT.EditValue)
        Else
            showCPPT(idselect, 0, deTanggalCPPT.EditValue)
        End If
    End Sub

    Private Sub btnRefreshCPPT_Click(sender As Object, e As EventArgs) Handles btnRefreshCPPT.Click
        If btnAllDPJP.Text = "SEMUA DPJP" Then
            showCPPT(idselect, 1, deTanggalCPPT.EditValue)
        Else
            showCPPT(idselect, 0, deTanggalCPPT.EditValue)
        End If
    End Sub

End Class