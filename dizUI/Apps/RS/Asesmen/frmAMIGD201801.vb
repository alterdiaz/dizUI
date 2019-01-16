Imports DevExpress.XtraGrid.Views.Base
Public Class frmAMIGD201801
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

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='SKALATRIAGE' order by idgeneral asc", "skalatriage")
        lueSkalaTriage.Properties.DataSource = sqls.dataTable("skalatriage")
        lueSkalaTriage.Properties.DisplayMember = "content"
        lueSkalaTriage.Properties.ValueMember = "id"
        lueSkalaTriage.EditValue = Nothing
        If sqls.getDataSet("skalatriage") = 0 Then
            dizMsgbox("Skala Triage tidak ditemukan" & vbCrLf & "Skala Triage harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISNADI' order by idgeneral asc", "isnadi")
        lueNadiJenis.Properties.DataSource = sqls.dataTable("isnadi")
        lueNadiJenis.Properties.DisplayMember = "content"
        lueNadiJenis.Properties.ValueMember = "id"
        lueNadiJenis.EditValue = Nothing
        If sqls.getDataSet("isnadi") = 0 Then
            dizMsgbox("Jenis Nadi tidak ditemukan" & vbCrLf & "Jenis Nadi harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISAKRAL' order by idgeneral asc", "isakral")
        lueAkral.Properties.DataSource = sqls.dataTable("isakral")
        lueAkral.Properties.DisplayMember = "content"
        lueAkral.Properties.ValueMember = "id"
        lueAkral.EditValue = Nothing
        If sqls.getDataSet("isakral") = 0 Then
            dizMsgbox("Akral tidak ditemukan" & vbCrLf & "Akral harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISKESADARAN' order by idgeneral asc", "issadar")
        lueKesadaran.Properties.DataSource = sqls.dataTable("issadar")
        lueKesadaran.Properties.DisplayMember = "content"
        lueKesadaran.Properties.ValueMember = "id"
        lueKesadaran.EditValue = Nothing
        If sqls.getDataSet("issadar") = 0 Then
            dizMsgbox("Kesadaran tidak ditemukan" & vbCrLf & "Kesadaran harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISREFCAHAYA' order by idgeneral asc", "isrefcahaya")
        lueRefleks.Properties.DataSource = sqls.dataTable("isrefcahaya")
        lueRefleks.Properties.DisplayMember = "content"
        lueRefleks.Properties.ValueMember = "id"
        lueRefleks.EditValue = Nothing
        If sqls.getDataSet("isrefcahaya") = 0 Then
            dizMsgbox("Reflek Cahaya tidak ditemukan" & vbCrLf & "Reflek Cahaya harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISRIWAYAT' order by idgeneral asc", "isriwayat")
        lueAlergi.Properties.DataSource = sqls.dataTable("isriwayat")
        lueAlergi.Properties.DisplayMember = "content"
        lueAlergi.Properties.ValueMember = "id"
        lueAlergi.EditValue = Nothing
        If sqls.getDataSet("isriwayat") = 0 Then
            dizMsgbox("Riwayat Alergi tidak ditemukan" & vbCrLf & "Riwayat Alergi harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISGANGGUANPERILAKU' order by idgeneral asc", "isgangguanperilaku")
        lueGangguan.Properties.DataSource = sqls.dataTable("isgangguanperilaku")
        lueGangguan.Properties.DisplayMember = "content"
        lueGangguan.Properties.ValueMember = "id"
        lueGangguan.EditValue = Nothing
        If sqls.getDataSet("isgangguanperilaku") = 0 Then
            dizMsgbox("Gangguan Perilaku tidak ditemukan" & vbCrLf & "Gangguan Perilaku harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISPERILAKUBERBAHAYA' order by idgeneral asc", "isperilakuberbahaya")
        lueMembahayakan.Properties.DataSource = sqls.dataTable("isperilakuberbahaya")
        lueMembahayakan.Properties.DisplayMember = "content"
        lueMembahayakan.Properties.ValueMember = "id"
        lueMembahayakan.EditValue = Nothing
        If sqls.getDataSet("isperilakuberbahaya") = 0 Then
            dizMsgbox("Perilaku Berbahaya tidak ditemukan" & vbCrLf & "Perilaku Berbahaya harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISINFORMASI' order by idgeneral asc", "sumberinfo")
        lueSumberInfo.Properties.DataSource = sqls.dataTable("sumberinfo")
        lueSumberInfo.Properties.DisplayMember = "content"
        lueSumberInfo.Properties.ValueMember = "id"
        lueSumberInfo.EditValue = Nothing
        If sqls.getDataSet("sumberinfo") = 0 Then
            dizMsgbox("Sumber Informasi tidak ditemukan" & vbCrLf & "Sumber Informasi harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where idgeneral<>0 and gctype='FAMILYTYPE' order by idgeneral asc", "familytype")
        lueHubungan.Properties.DataSource = sqls.dataTable("familytype")
        lueHubungan.Properties.DisplayMember = "content"
        lueHubungan.Properties.ValueMember = "id"
        lueHubungan.EditValue = Nothing
        If sqls.getDataSet("familytype") = 0 Then
            dizMsgbox("Perilaku Berbahaya tidak ditemukan" & vbCrLf & "Perilaku Berbahaya harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISCARAMASUK' order by idgeneral asc", "iscaramasuk")
        lueCaraMasuk.Properties.DataSource = sqls.dataTable("iscaramasuk")
        lueCaraMasuk.Properties.DisplayMember = "content"
        lueCaraMasuk.Properties.ValueMember = "id"
        lueCaraMasuk.EditValue = Nothing
        If sqls.getDataSet("iscaramasuk") = 0 Then
            dizMsgbox("Cara Masuk tidak ditemukan" & vbCrLf & "Cara Masuk harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISPENGANTAR' order by idgeneral asc", "pengantar")
        luePengantar.Properties.DataSource = sqls.dataTable("pengantar")
        luePengantar.Properties.DisplayMember = "content"
        luePengantar.Properties.ValueMember = "id"
        luePengantar.EditValue = Nothing
        If sqls.getDataSet("pengantar") = 0 Then
            dizMsgbox("Pengantar tidak ditemukan" & vbCrLf & "Pengantar harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISPENYEBAB' order by idgeneral asc", "penyebab")
        luePenyebab.Properties.DataSource = sqls.dataTable("penyebab")
        luePenyebab.Properties.DisplayMember = "content"
        luePenyebab.Properties.ValueMember = "id"
        luePenyebab.EditValue = Nothing
        If sqls.getDataSet("penyebab") = 0 Then
            dizMsgbox("Penyebab tidak ditemukan" & vbCrLf & "Penyebab harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='GAYAHIDUP' order by idgeneral asc", "gayahidup")
        lueGayaHidup.Properties.DataSource = sqls.dataTable("gayahidup")
        lueGayaHidup.Properties.DisplayMember = "content"
        lueGayaHidup.Properties.ValueMember = "id"
        lueGayaHidup.EditValue = Nothing
        If sqls.getDataSet("gayahidup") = 0 Then
            dizMsgbox("Gaya Hidup tidak ditemukan" & vbCrLf & "Gaya Hidup harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ASALPX' order by idgeneral asc", "asalpx1")
        lueAsalPx.Properties.DataSource = sqls.dataTable("asalpx1")
        lueAsalPx.Properties.DisplayMember = "content"
        lueAsalPx.Properties.ValueMember = "id"
        lueAsalPx.EditValue = Nothing
        If sqls.getDataSet("asalpx1") = 0 Then
            dizMsgbox("Asal Pasien tidak ditemukan" & vbCrLf & "Asal Pasien harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select value from sys_appsetting where variable='GCSEmin'", "GCSEmin")
        If sqls.getDataSet("GCSEmin") = 0 Then
            dizMsgbox("Setting GCSE tidak ditemukan" & vbCrLf & "Setting GCSE harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        Else
            nudGCSE.Properties.MinValue = CDec(sqls.getDataSet("GCSEmin", 0, "value"))
        End If
        sqls.DMLQuery("select value from sys_appsetting where variable='GCSEmax'", "GCSEmax")
        If sqls.getDataSet("GCSEmax") = 0 Then
            dizMsgbox("Setting GCSE tidak ditemukan" & vbCrLf & "Setting GCSE harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        Else
            nudGCSE.Properties.MaxValue = CDec(sqls.getDataSet("GCSEmax", 0, "value"))
        End If
        sqls.DMLQuery("select value from sys_appsetting where variable='GCSVmin'", "GCSVmin")
        If sqls.getDataSet("GCSVmin") = 0 Then
            dizMsgbox("Setting GCSV tidak ditemukan" & vbCrLf & "Setting GCSV harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        Else
            nudGCSV.Properties.MinValue = CDec(sqls.getDataSet("GCSVmin", 0, "value"))
        End If
        sqls.DMLQuery("select value from sys_appsetting where variable='GCSVmax'", "GCSVmax")
        If sqls.getDataSet("GCSVmax") = 0 Then
            dizMsgbox("Setting GCSV tidak ditemukan" & vbCrLf & "Setting GCSV harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        Else
            nudGCSV.Properties.MaxValue = CDec(sqls.getDataSet("GCSVmax", 0, "value"))
        End If
        sqls.DMLQuery("select value from sys_appsetting where variable='GCSMmin'", "GCSMmin")
        If sqls.getDataSet("GCSMmin") = 0 Then
            dizMsgbox("Setting GCSM tidak ditemukan" & vbCrLf & "Setting GCSM harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        Else
            nudGCSM.Properties.MinValue = CDec(sqls.getDataSet("GCSMmin", 0, "value"))
        End If
        sqls.DMLQuery("select value from sys_appsetting where variable='GCSMmax'", "GCSMmax")
        If sqls.getDataSet("GCSMmax") = 0 Then
            dizMsgbox("Setting GCSM tidak ditemukan" & vbCrLf & "Setting GCSM harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        Else
            nudGCSM.Properties.MaxValue = CDec(sqls.getDataSet("GCSMmax", 0, "value"))
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='DPJPTYPE' and idreff=1 order by idgeneral asc", "dpjptype")
        lueSebagai.Properties.DataSource = sqls.dataTable("dpjptype")
        lueSebagai.Properties.DisplayMember = "content"
        lueSebagai.Properties.ValueMember = "id"
        lueSebagai.EditValue = Nothing
        If sqls.getDataSet("dpjptype") = 0 Then
            dizMsgbox("DPJP Type tidak ditemukan" & vbCrLf & "DPJP Type harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

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

    End Sub

    Private idselect As String = "-1"

    Private jenistransselectso As String = ""
    Private idtransselectso As String = 0
    Private formatstringso As String = ""
    Private formatperiodeso As String = ""

    Private jenistransselectas As String = ""
    Private idtransselectas As String = 0
    Private formatstringas As String = ""
    Private formatperiodeas As String = ""

    Private iddeptselect As String = "-1"
    Private idunitselect As String = "-1"
    Private isFromLoad As Boolean = True
    Private imgAnatomi As Image = Nothing

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub kosongkan()
        kosongkanIsian(tlpRegistrasi)
        kosongkanIsian(tlpPasien)
        kosongkanIsian(tlpAlamat)
        kosongkanIsian(tlpTriage)
        kosongkanIsian(tlpTandaVital1)
        kosongkanIsian(tlpTandaVital2)
        kosongkanIsian(tlpTandaVital3)
        kosongkanIsian(tlpLainlain)
        kosongkanIsian(tlppSOAP)
        kosongkanIsian(tlppPenunjang)
        kosongkanIsian(tlppDPJP)
        meDiagnosaKerja.Text = ""
        meDiagnosaKerja.EditValue = Nothing

        If lueAlergi.EditValue Is Nothing Then
            meAlergi.Text = "-"
            meReaksiAlergi.Text = "-"
            meAlergi.Properties.ReadOnly = True
            meReaksiAlergi.Properties.ReadOnly = True
        End If
        If luePengantar.EditValue Is Nothing Then
            tePengantar.Text = "-"
            tePengantar.Properties.ReadOnly = True
        End If
        If luePenyebab.EditValue Is Nothing Then
            tePenyebab.Text = "-"
            tePenyebab.Properties.ReadOnly = True
        End If
        If lueHubungan.EditValue Is Nothing Then
            teHubungan.Text = "-"
            teHubungan.Properties.ReadOnly = True
        End If
        If lueGangguan.EditValue Is Nothing Then
            lueMembahayakan.EditValue = Nothing
            lueMembahayakan.Properties.ReadOnly = True
        End If
        If lueSumberInfo.EditValue Is Nothing Then
            lueHubungan.Properties.DataSource = Nothing
            lueHubungan.EditValue = Nothing
            lueHubungan.Properties.ReadOnly = True
            teHubungan.EditValue = Nothing
            teHubungan.Properties.ReadOnly = False
        End If
        If lueParamedis.EditValue Is Nothing Then
            lueSpesialis.Properties.DataSource = Nothing
            lueSpesialis.EditValue = Nothing
        End If
        If lueAsalPx.EditValue Is Nothing Then
            lblAsalPx2.Text = ""
            lblAsalPx2.Visible = False
            lueAsalPx2.Visible = False
            lblAsalPx3.Text = ""
            lblAsalPx3.Visible = False
            lueAsalPx3.Visible = False
            lblAsalPx4.Text = ""
            lblAsalPx4.Visible = False
            lueAsalPx4.Visible = False
        End If
        If lueSkalaTriage.EditValue Is Nothing Then
            teWaktuTunggu.Text = ""
        End If
        If lueGayaHidup.EditValue Is Nothing Then
            teGayaHidup.Text = "-"
            teGayaHidup.ReadOnly = True
        End If
        For Each btn As Button In tlpAnatomiTools.Controls
            btn.BackColor = Color.FromArgb(224, 224, 224)
        Next
        btnNumbering.BackColor = Color.FromArgb(224, 224, 224)
        _anatomi = anatomiType.ZZ

        teNoRegistrasi.Text = ""
        teNoRegistrasi.Tag = 0
        teNoRM.Tag = 0
        teNoRM.Text = 0
        teTanggalRegistrasi.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        teTanggalAsesmen.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        teTanggalSOAP.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        teGolonganDarah.Tag = ""
        teJenisKelamin.Tag = ""
        teWarganegara.Tag = ""

        btnSearch.Enabled = True
        btnSimpanASESMEN.Enabled = True
        btnCetakASESMEN.Enabled = True
        statData = statusData.Baru

        iddeptselect = 0
        idunitselect = 0
        idselect = "-1"

        isoneday = 0
        If isoneday = 0 Then
            btnODS.Text = "ODS / ODC"
            teNoRegistrasi.Text = ""
        ElseIf isoneday = 1 Then
            btnODS.Text = "REGULER"
            teNoRegistrasi.Text = ""
        End If

        iddas = "-1"
        idtransselectas = 0
        jenistransselectas = ""
        formatstringas = ""
        formatperiodeas = ""

        iddso = "-1"
        idtransselectso = 0
        jenistransselectso = ""
        formatstringso = ""
        formatperiodeso = ""

        teNoAsesmen.Text = "XXXX/IGD/ASM/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
        teNoSOAP.Text = "XXXX/IGD/SOAPM/" & Format(nowTime, "yyyyMMdd") & "/XXXX"

        lblAsalPx2.Visible = False
        lueAsalPx2.Visible = False
        lueAsalPx2.EditValue = Nothing
        lblAsalPx3.Visible = False
        lueAsalPx3.Visible = False
        lueAsalPx3.EditValue = Nothing
        lblAsalPx4.Visible = False
        lueAsalPx4.Visible = False
        lueAsalPx4.EditValue = Nothing

        lueAlergi.EditValue = Nothing
        lueHubungan.EditValue = Nothing
        luePengantar.EditValue = Nothing
        luePenyebab.EditValue = Nothing

        imgAnatomi = Nothing
        peAnatomi.Image = Nothing
        isPoint = False

        tmrCek.Stop()
        tlpAsesmen.Enabled = False
        tlpSOAP.Enabled = False
        tlpPenunjang.Enabled = False
        tlpDPJP.Enabled = False

        btnSearch.Enabled = True
        btnSimpanASESMEN.Enabled = False
        btnCetakASESMEN.Enabled = False
        btnSimpanSOAP.Enabled = False
        btnCetakSOAP.Enabled = False
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If isFromLoad = True Then
            kosongkanIsian(tlpRegistrasi)
            kosongkanIsian(tlpPasien)
            kosongkanIsian(tlpAlamat)
            kosongkanIsian(tlpTriage)
            kosongkanIsian(tlpTandaVital1)
            kosongkanIsian(tlpTandaVital2)
            kosongkanIsian(tlpTandaVital3)
            kosongkanIsian(tlpLainlain)
            kosongkanIsian(tlppSOAP)
            kosongkanIsian(tlppPenunjang)
            kosongkanIsian(tlppDPJP)
            meDiagnosaKerja.Text = ""
            meDiagnosaKerja.EditValue = Nothing

            If lueAlergi.EditValue Is Nothing Then
                meAlergi.Text = "-"
                meReaksiAlergi.Text = "-"
                meAlergi.Properties.ReadOnly = True
                meReaksiAlergi.Properties.ReadOnly = True
            End If
            If luePengantar.EditValue Is Nothing Then
                tePengantar.Text = "-"
                tePengantar.Properties.ReadOnly = True
            End If
            If luePenyebab.EditValue Is Nothing Then
                tePenyebab.Text = "-"
                tePenyebab.Properties.ReadOnly = True
            End If
            If lueHubungan.EditValue Is Nothing Then
                teHubungan.Text = "-"
                teHubungan.Properties.ReadOnly = True
            End If
            If lueGangguan.EditValue Is Nothing Then
                lueMembahayakan.EditValue = Nothing
                lueMembahayakan.Properties.ReadOnly = True
            End If
            If lueSumberInfo.EditValue Is Nothing Then
                lueHubungan.Properties.DataSource = Nothing
                lueHubungan.EditValue = Nothing
                lueHubungan.Properties.ReadOnly = True
                teHubungan.EditValue = Nothing
                teHubungan.Properties.ReadOnly = False
            End If
            If lueParamedis.EditValue Is Nothing Then
                lueSpesialis.Properties.DataSource = Nothing
                lueSpesialis.EditValue = Nothing
            End If
            If lueAsalPx.EditValue Is Nothing Then
                lblAsalPx2.Text = ""
                lblAsalPx2.Visible = False
                lueAsalPx2.Visible = False
                lblAsalPx3.Text = ""
                lblAsalPx3.Visible = False
                lueAsalPx3.Visible = False
                lblAsalPx4.Text = ""
                lblAsalPx4.Visible = False
                lueAsalPx4.Visible = False
            End If
            If lueSkalaTriage.EditValue Is Nothing Then
                teWaktuTunggu.Text = ""
            End If
            If lueGayaHidup.EditValue Is Nothing Then
                teGayaHidup.Text = "-"
                teGayaHidup.ReadOnly = True
            End If
            For Each btn As Button In tlpAnatomiTools.Controls
                btn.BackColor = Color.FromArgb(224, 224, 224)
            Next
            btnNumbering.BackColor = Color.FromArgb(224, 224, 224)
            _anatomi = anatomiType.ZZ

            teNoRegistrasi.Text = ""
            teNoRegistrasi.Tag = 0
            teNoRM.Tag = 0
            teNoRM.Text = 0
            teTanggalRegistrasi.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
            teTanggalAsesmen.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
            teTanggalSOAP.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
            teGolonganDarah.Tag = ""
            teJenisKelamin.Tag = ""
            teWarganegara.Tag = ""

            btnSearch.Enabled = True
            btnSimpanASESMEN.Enabled = True
            btnCetakASESMEN.Enabled = True
            statData = statusData.Baru

            iddeptselect = 0
            idunitselect = 0
            idselect = "-1"

            isoneday = 0
            If isoneday = 0 Then
                btnODS.Text = "ODS / ODC"
                teNoRegistrasi.Text = ""
            ElseIf isoneday = 1 Then
                btnODS.Text = "REGULER"
                teNoRegistrasi.Text = ""
            End If

            iddas = "-1"
            idtransselectas = 0
            jenistransselectas = ""
            formatstringas = ""
            formatperiodeas = ""

            iddso = "-1"
            idtransselectso = 0
            jenistransselectso = ""
            formatstringso = ""
            formatperiodeso = ""

            teNoAsesmen.Text = "XXXX/IGD/ASM/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
            teNoSOAP.Text = "XXXX/IGD/SOAPM/" & Format(nowTime, "yyyyMMdd") & "/XXXX"

            lblAsalPx2.Visible = False
            lueAsalPx2.Visible = False
            lueAsalPx2.EditValue = Nothing
            lblAsalPx3.Visible = False
            lueAsalPx3.Visible = False
            lueAsalPx3.EditValue = Nothing
            lblAsalPx4.Visible = False
            lueAsalPx4.Visible = False
            lueAsalPx4.EditValue = Nothing

            lueAlergi.EditValue = Nothing
            lueHubungan.EditValue = Nothing
            luePengantar.EditValue = Nothing
            luePenyebab.EditValue = Nothing

            imgAnatomi = Nothing
            peAnatomi.Image = Nothing
            isPoint = False

            tmrCek.Stop()
            tlpAsesmen.Enabled = False
            tlpSOAP.Enabled = False
            tlpPenunjang.Enabled = False
            tlpDPJP.Enabled = False

            btnSearch.Enabled = True
            btnSimpanASESMEN.Enabled = False
            btnCetakASESMEN.Enabled = False
            btnSimpanSOAP.Enabled = False
            btnCetakSOAP.Enabled = False
        Else
            If idselect <> "-1" Then
                If dizMsgbox("Perubahan Asesmen Medis sudah disimpan ?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
                    Exit Sub
                End If
            End If
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select r.idregistrasi,convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as 'Tgl Registrasi',case when r.isoneday=1 then r.registrasino + ' (ODS)' else r.registrasino end as 'No Registrasi',pm.nama as 'Tenaga Medis',dbo.fformatnorm(rm.rekammedisno) as 'No RM',rm.nama as 'Nama Pasien',jk.generalcode as 'Jenis Kelamin',convert(varchar,rm.tanggallahir,105) as 'Tgl Lahir',dbo.fUmurRegister(rm.tanggallahir,r.registrasidate) as 'Umur',kw.wilayah as 'Kewarganegaraan' from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' left join wilayah kw on rm.kewarganegaraan=kw.idwilayah  left join paramedis pm on r.iddokterruangan=pm.idparamedis where r.registrasistatus=0 and rm.rekammedisno<>0 and r.iddepartment=(select top 1 [value] from sys_appsetting where variable='IDEmergencyDept') order by r.registrasidate desc", "search")
            Dim cari As New frmSearch(sqls.dataSet, "search", "idregistrasi")
            tambahChild(cari)

            If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
                kosongkan()

                For Each btn As Button In tlpAnatomiTools.Controls
                    btn.BackColor = Color.FromArgb(224, 224, 224)
                Next
                _anatomi = anatomiType.ZZ

                sqls = New SQLs(dbstring)
                sqls.DMLQuery("select isnull(dbo.fGetUsername(lockby),0) as username,isnull(dbo.fGetUsernama(lockby),'-') as nama,isnull(lockipaddress,'0.0.0.0') as lockipaddress from registrasi where datediff(second,lockdate,getdate())<=convert(int,(select isnull(value,4) from sys_appsetting where variable='TimeoutRegister')) and idregistrasi='" & CStr(cari.GetIDSelectData) & "'", "ceklock")
                If sqls.getDataSet("ceklock") > 0 Then
                    dizMsgbox("Sedang digunakan oleh" & vbCrLf &
                              sqls.getDataSet("ceklock", 0, "username") & " (" & sqls.getDataSet("ceklock", 0, "username") & ")" & vbCrLf &
                              "IP Address " & sqls.getDataSet("ceklock", 0, "lockipaddress"), dizMsgboxStyle.Info, Me)
                    Exit Sub
                End If

                isoneday = 0
                If isoneday = 0 Then
                    btnODS.Text = "ODS / ODC"
                    teNoRegistrasi.Text = ""
                ElseIf isoneday = 1 Then
                    btnODS.Text = "REGULER"
                    teNoRegistrasi.Text = ""
                End If

                iddas = "-1"
                iddso = "-1"
                'btnBaruDiagnosaKerja.Enabled = False

                teNoAsesmen.Tag = "-1"
                teNoSOAP.Tag = "-1"
                isPoint = False

                idselect = CStr(cari.GetIDSelectData)
                tmrCek.Start()

                sqls.DMLQuery("select r.isoneday,r.asalpx,r.asalpx2,r.asalrujukan,r.iddokterrujukan,r.idrekammedis,r.iddepartment,r.idunit,r.registrasino,convert(varchar,r.registrasidate,105) + ' '+convert(varchar,r.registrasidate,108) as registrasidate,ha.generalcode as hamil from registrasi r left join sys_generalcode ha on r.ishamil=ha.idgeneral and ha.gctype='ISHAMIL' where r.idregistrasi='" & idselect & "'", "getidrm")
                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                field.AddRange(New String() {"@idrm"})
                value.AddRange(New Object() {sqls.getDataSet("getidrm", 0, "idrekammedis")})
                sqls.CallSP("spGetPasienRegistrasi", "registrasi", field, value)

                isoneday = sqls.getDataSet("getidrm", 0, "isoneday")
                If isoneday = 0 Then
                    btnODS.Text = "ODS / ODC"
                ElseIf isoneday = 1 Then
                    btnODS.Text = "REGULER"
                End If

                iddeptselect = sqls.getDataSet("getidrm", 0, "iddepartment")
                idunitselect = sqls.getDataSet("getidrm", 0, "idunit")

                Dim pair As KeyValuePair(Of String, String) = generateno2(idunitselect, iddeptselect, "AssessmentMedis", True)
                idtransselectas = pair.Key
                teNoAsesmen.Text = pair.Value

                sqls.DMLQuery("select jenistransaksi,formatstring,formatperiode from transactiontype where idtransactiontype='" & idtransselectas & "'", "getttas")
                jenistransselectas = sqls.getDataSet("getttas", 0, "jenistransaksi")
                formatstringas = sqls.getDataSet("getttas", 0, "formatstring")
                formatperiodeas = sqls.getDataSet("getttas", 0, "formatperiode")

                Dim pair2 As KeyValuePair(Of String, String) = generateno2(idunitselect, iddeptselect, "SOAPMedis", True)
                idtransselectso = pair2.Key
                teNoSOAP.Text = pair2.Value

                sqls.DMLQuery("select jenistransaksi,formatstring,formatperiode from transactiontype where idtransactiontype='" & idtransselectas & "'", "getttso")
                jenistransselectso = sqls.getDataSet("getttso", 0, "jenistransaksi")
                formatstringso = sqls.getDataSet("getttso", 0, "formatstring")
                formatperiodeso = sqls.getDataSet("getttso", 0, "formatperiode")

                teNoRegistrasi.Tag = idselect
                noreg = sqls.getDataSet("getidrm", 0, "registrasino")
                If isoneday = 0 Then
                    teNoRegistrasi.Text = noreg
                ElseIf isoneday = 1 Then
                    teNoRegistrasi.Text = noreg & " (ODS)"
                End If

                idreg = idselect
                teTanggalRegistrasi.Text = sqls.getDataSet("getidrm", 0, "registrasidate")
                teTanggalAsesmen.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
                teTanggalSOAP.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")

                lueAsalPx.EditValue = sqls.getDataSet("getidrm", 0, "asalpx")
                lueAsalPx2.EditValue = sqls.getDataSet("getidrm", 0, "asalpx2")
                lueAsalPx3.EditValue = sqls.getDataSet("getidrm", 0, "asalrujukan")
                lueAsalPx4.EditValue = sqls.getDataSet("getidrm", 0, "iddokterrujukan")

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
                If sqls.getDataSet("registrasi", 0, "idjeniskelamin") = 0 Then
                    imgAnatomi = My.Resources.anatomi_w
                ElseIf sqls.getDataSet("registrasi", 0, "idjeniskelamin") = 1 Then
                    imgAnatomi = My.Resources.anatomi_p
                End If
                sqls.DMLQuery("select images from anatomi a left join sys_images i on a.idimages=i.idimages where a.idregistrasi='" & idselect & "' and a.isdeleted=0", "getimg")
                If sqls.getDataSet("getimg") > 0 Then
                    imgAnatomi = Image.FromStream(New IO.MemoryStream(DirectCast(sqls.getDataSet("getimg", 0, "images"), Byte())))
                    mouseClicked = True
                End If
                peAnatomi.Image = imgAnatomi

                teWarganegara.Text = sqls.getDataSet("registrasi", 0, "warganegara")
                teTanggalLahir.Text = sqls.getDataSet("registrasi", 0, "tanggallahir")
                teUmur.Text = sqls.getDataSet("registrasi", 0, "usia")

                'Assessment
                sqls.DMLQuery("select idassessment from assessment where idregistrasi='" & idselect & "' and transactiontype='" & idtransselectas & "' and isdeleted=0 order by createddate desc", "getidass")
                If sqls.getDataSet("getidass") > 0 Then
                    iddas = sqls.getDataSet("getidass", 0, "idassessment")
                End If

                If iddas <> "-1" Then
                    sqls.DMLQuery("select assessmentno,skalatriage,convert(varchar,tanggaldatang,105) as tanggaldatang,convert(varchar,tanggaldatang,108) as waktudatang,convert(varchar,tanggalkejadian,105) as tanggalkejadian,convert(varchar,tanggalkejadian,108) as waktukejadian,gcse,gcsv,gcsm,tdsis,tddias,denyutnadi,isnadi,suhu,isakral,iskesadaran,pupila,pupilb,isrefcahaya,nafas,oksigendarah,isgangguanperilaku,isperilakubahaya,isinformasi,familytype,namainformasi,iscaramasuk,caramasuk,ispengantar,namapengantar,ispenyebab,penyebab,gayahidup,gayahidupnote,asalpx,asalpx2,asalrujukan,iddokterrujukan from assessment where idregistrasi='" & idreg & "'", "getass")

                    teNoAsesmen.Tag = iddas
                    teNoAsesmen.Text = sqls.getDataSet("getass", 0, "assessmentno")
                    lueSkalaTriage.EditValue = sqls.getDataSet("getass", 0, "skalatriage")
                    sqls.DMLQuery("select generalcode as content from sys_generalcode where gctype='SKALATRIAGE' and idgeneral='" & lueSkalaTriage.EditValue & "'", "getcontent")
                    Dim splt() As String = sqls.getDataSet("getcontent", 0, "content").ToString.Split("/")
                    If splt.Length <> 2 Then
                        teWaktuTunggu.Text = ""
                    Else
                        teWaktuTunggu.Text = splt(1)
                    End If

                    Dim strtgldatang As String = sqls.getDataSet("getass", 0, "tanggaldatang")
                    Dim strwktdatang As String = sqls.getDataSet("getass", 0, "waktudatang")
                    Dim dtdatang = Strdatetime2Datetime(strtgldatang & " " & strwktdatang)

                    Dim strtglkejadian As String = sqls.getDataSet("getass", 0, "tanggalkejadian")
                    Dim strwktkejadian As String = sqls.getDataSet("getass", 0, "waktukejadian")
                    Dim dtkejadian = Strdatetime2Datetime(strtglkejadian & " " & strwktkejadian)

                    deDatang.EditValue = dtdatang 'CDate(sqls.getDataSet("getass", 0, "tanggaldatang"))
                    deKejadian.EditValue = dtkejadian 'CDate(sqls.getDataSet("getass", 0, "tanggalkejadian"))
                    nudGCSE.Value = sqls.getDataSet("getass", 0, "gcse")
                    nudGCSV.Value = sqls.getDataSet("getass", 0, "gcsv")
                    nudGCSM.Value = sqls.getDataSet("getass", 0, "gcsm")
                    nudSistol.Value = sqls.getDataSet("getass", 0, "tdsis")
                    nudDiastol.Value = sqls.getDataSet("getass", 0, "tddias")
                    nudNadi.Value = sqls.getDataSet("getass", 0, "denyutnadi")
                    lueNadiJenis.EditValue = sqls.getDataSet("getass", 0, "isnadi")
                    nudSuhu.Value = sqls.getDataSet("getass", 0, "suhu")
                    lueAkral.EditValue = sqls.getDataSet("getass", 0, "isakral")
                    lueKesadaran.EditValue = sqls.getDataSet("getass", 0, "iskesadaran")
                    nudPupil1.Value = sqls.getDataSet("getass", 0, "pupila")
                    nudPupil2.Value = sqls.getDataSet("getass", 0, "pupilb")
                    lueRefleks.EditValue = sqls.getDataSet("getass", 0, "isrefcahaya")
                    nudNafas.Value = sqls.getDataSet("getass", 0, "nafas")
                    nudSpO2.Value = sqls.getDataSet("getass", 0, "oksigendarah")
                    lueMembahayakan.EditValue = If(sqls.getDataSet("getass", 0, "isperilakuberbahaya"), Nothing)
                    lueGangguan.EditValue = sqls.getDataSet("getass", 0, "isgangguanperilaku")

                    lueSumberInfo.EditValue = sqls.getDataSet("getass", 0, "isinformasi")
                    lueHubungan.EditValue = If(sqls.getDataSet("getass", 0, "familytype"), Nothing)
                    teHubungan.Text = sqls.getDataSet("getass", 0, "namainformasi")
                    lueCaraMasuk.EditValue = sqls.getDataSet("getass", 0, "iscaramasuk")
                    teCaraMasuk.EditValue = sqls.getDataSet("getass", 0, "caramasuk")

                    luePengantar.EditValue = sqls.getDataSet("getass", 0, "ispengantar")
                    tePengantar.Text = sqls.getDataSet("getass", 0, "namapengantar")
                    luePenyebab.EditValue = sqls.getDataSet("getass", 0, "ispenyebab")
                    tePenyebab.Text = sqls.getDataSet("getass", 0, "penyebab")
                    lueGayaHidup.EditValue = sqls.getDataSet("getass", 0, "gayahidup")
                    teGayaHidup.Text = sqls.getDataSet("getass", 0, "gayahidupnote")

                    lueAsalPx.EditValue = If(sqls.getDataSet("getass", 0, "asalpx"), Nothing)
                    lueAsalPx2.EditValue = If(sqls.getDataSet("getass", 0, "asalpx2"), Nothing)
                    lueAsalPx3.EditValue = If(sqls.getDataSet("getass", 0, "asalrujukan"), Nothing)
                    lueAsalPx4.EditValue = If(sqls.getDataSet("getass", 0, "iddokterrujukkan"), Nothing)
                End If

                'SOAP
                sqls.DMLQuery("select idsoapnote from soapnote where idregistrasi='" & idselect & "' and transactiontype='" & idtransselectso & "' and isdeleted=0 and soapnotetype=1", "getidso")
                If sqls.getDataSet("getidso") > 0 Then
                    iddso = sqls.getDataSet("getidso", 0, "idsoapnote")
                    btnBaruDiagnosaKerja.Enabled = True
                End If

                If iddso <> "-1" Then
                    sqls.DMLQuery("select soapnoteno,convert(varchar,soapnotedate,105)+' '+convert(varchar,soapnotedate,108) as soapnotedate,subyektif,obyektif,asesmen,planning from soapnote where idregistrasi='" & idreg & "' and soapnotetype=1", "getso")
                    teNoSOAP.Tag = iddso

                    Dim oTrim() As Char = {vbCr, vbLf}
                    Dim ases As String = sqls.getDataSet("getso", 0, "asesmen")
                    ases = ases.Replace("Diagnosa Kerja:", "`")
                    ases = ases.Replace("Diagnosa Banding:", "`")

                    teNoSOAP.Text = sqls.getDataSet("getso", 0, "soapnoteno")
                    meCC.Text = sqls.getDataSet("getso", 0, "subyektif")
                    meObjektif.Text = sqls.getDataSet("getso", 0, "obyektif")

                    Dim asesk As String = ""
                    If ases <> "" Then
                        asesk = ases.Split("`")(1)
                        If asesk.EndsWith(vbCrLf) Then
                            asesk = asesk.TrimEnd(oTrim)
                        End If
                        If asesk.StartsWith(vbCrLf) Then
                            asesk = asesk.TrimStart(oTrim)
                        End If
                    End If
                    meDiagnosaKerja.Text = asesk

                    Dim asesb As String = ""
                    If ases <> "" Then
                        asesb = ases.Split("`")(2)
                        If asesb.EndsWith(vbCrLf) Then
                            asesb = asesb.TrimEnd(oTrim)
                        End If
                        If asesb.StartsWith(vbCrLf) Then
                            asesb = asesb.TrimStart(oTrim)
                        End If
                    End If
                    meDiagnosaBanding.Text = asesb

                    mePlanning.Text = sqls.getDataSet("getso", 0, "planning")
                End If

                If meDiagnosaKerja.Text = "" Then
                    sqls.DMLQuery("select d.idanalisarmdt,d.idicd,d.jenisdiagnosa,jd.generalcode as jnsdiagnosa,i.icdtype,i.kode,i.diagnosa,d.remarks,d.isdeleted,del.generalcode as statdata,it.generalcode as jenisicd from analisarmdt d left join icd i on d.idicd=i.idicd left join sys_generalcode del on d.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode it on i.icdtype=it.idgeneral and it.gctype='ICDTYPE' left join sys_generalcode jd on d.jenisdiagnosa=jd.idgeneral and jd.gctype='JENISDIAGNOSA' where d.analisarmtype=1 and d.isdeleted=0 and d.idregistrasi='" & idreg & "' order by d.jenisdiagnosa asc,d.createddate desc", "getdiagnosa")
                    If sqls.getDataSet("getdiagnosa") > 0 Then
                        Me.meDiagnosaKerja.Text = ""
                        For i As Integer = 0 To sqls.getDataSet("getdiagnosa") - 1
                            If sqls.getDataSet("getdiagnosa", i, "remarks") = "-" Then
                                meDiagnosaKerja.Text &= sqls.getDataSet("getdiagnosa", i, "diagnosa")
                            Else
                                meDiagnosaKerja.Text &= sqls.getDataSet("getdiagnosa", i, "diagnosa") & " - " & sqls.getDataSet("getdiagnosa", i, "remarks")
                            End If
                            If i < sqls.getDataSet("getdiagnosa") - 1 Then
                                meDiagnosaKerja.Text &= vbCrLf
                            End If
                        Next
                    Else
                        meDiagnosaKerja.Text = ""
                    End If
                End If

                sqls.DMLQuery("select riwayat,reaksi from riwayatpasien where isdeleted=0 and riwayattype=1 and riwayatalergitype=0 and tablereff2='REGISTRASI' and idreff2='" & idreg & "' and tablereff='PASIEN' and idreff='" & teNoRM.Tag & "'", "getskrg")
                If sqls.getDataSet("getskrg") > 0 Then
                    For i As Integer = 0 To sqls.getDataSet("getskrg") - 1
                        If i > 0 Then
                            meSekarang.Text &= vbCrLf
                        End If
                        meSekarang.Text &= sqls.getDataSet("getskrg", i, "riwayat")
                    Next
                Else
                    meSekarang.Text = ""
                End If

                sqls.DMLQuery("select riwayat,reaksi from riwayatpasien where isdeleted=0 and riwayattype=2 and riwayatalergitype=0 and tablereff2='REGISTRASI' and idreff2='" & idreg & "' and tablereff='PASIEN' and idreff='" & teNoRM.Tag & "'", "getdahulu")
                If sqls.getDataSet("getdahulu") > 0 Then
                    For i As Integer = 0 To sqls.getDataSet("getdahulu") - 1
                        If i > 0 Then
                            meDahulu.Text &= vbCrLf
                        End If
                        meDahulu.Text &= sqls.getDataSet("getdahulu", i, "riwayat")
                    Next
                Else
                    meDahulu.Text = ""
                End If

                sqls.DMLQuery("select riwayat,reaksi from riwayatpasien where isdeleted=0 and riwayattype=3 and riwayatalergitype=0 and tablereff2='REGISTRASI' and idreff2='" & idreg & "' and tablereff='PASIEN' and idreff='" & teNoRM.Tag & "'", "getobat")
                If sqls.getDataSet("getobat") > 0 Then
                    For i As Integer = 0 To sqls.getDataSet("getobat") - 1
                        If i > 0 Then
                            meObat.Text &= vbCrLf
                        End If
                        meObat.Text &= sqls.getDataSet("getobat", i, "riwayat")
                    Next
                Else
                    meObat.Text = ""
                End If

                sqls.DMLQuery("select riwayat,reaksi from riwayatpasien where isdeleted=0 and riwayattype=4 and riwayatalergitype=8 and tablereff2='REGISTRASI' and idreff2='" & idreg & "' and tablereff='PASIEN' and idreff='" & teNoRM.Tag & "'", "getriwayat")
                If sqls.getDataSet("getriwayat") > 0 Then
                    lueAlergi.EditValue = CLng(1)
                    For i As Integer = 0 To sqls.getDataSet("getriwayat") - 1
                        If i > 0 Then
                            meAlergi.Text &= vbCrLf
                            meReaksiAlergi.Text &= vbCrLf
                        End If
                        meAlergi.Text &= sqls.getDataSet("getriwayat", i, "riwayat")
                        meReaksiAlergi.Text &= sqls.getDataSet("getriwayat", i, "reaksi")
                    Next
                Else
                    lueAlergi.EditValue = CLng(0)
                End If

                'EKG
                sqls.DMLQuery("select idpemeriksaanpenunjang,hasilpemeriksaan from pemeriksaanpenunjang where penunjangtype=1 and isdeleted=0 and idregistrasi='" & idselect & "'", "ekg")
                If sqls.getDataSet("ekg") > 0 Then
                    meEKG.Tag = sqls.getDataSet("ekg", 0, "idpemeriksaanpenunjang")
                    meEKG.Text = sqls.getDataSet("ekg", 0, "hasilpemeriksaan")
                Else
                    meEKG.Tag = "-1"
                    meEKG.Text = ""
                End If

                'LAB
                sqls.DMLQuery("select idpemeriksaanpenunjang,hasilpemeriksaan from pemeriksaanpenunjang where penunjangtype=2 and isdeleted=0 and idregistrasi='" & idselect & "'", "lab")
                If sqls.getDataSet("lab") > 0 Then
                    meLAB.Tag = sqls.getDataSet("lab", 0, "idpemeriksaanpenunjang")
                    meLAB.Text = sqls.getDataSet("lab", 0, "hasilpemeriksaan")
                Else
                    meLAB.Tag = "-1"
                    meLAB.Text = ""
                End If

                'RAD
                sqls.DMLQuery("select idpemeriksaanpenunjang,hasilpemeriksaan from pemeriksaanpenunjang where penunjangtype=3 and isdeleted=0 and idregistrasi='" & idselect & "'", "rad")
                If sqls.getDataSet("rad") > 0 Then
                    meRAD.Tag = sqls.getDataSet("rad", 0, "idpemeriksaanpenunjang")
                    meRAD.Text = sqls.getDataSet("rad", 0, "hasilpemeriksaan")
                Else
                    meRAD.Tag = "-1"
                    meRAD.Text = ""
                End If

                showDPJP(idselect, 0)
                btnAllDPJP.Text = "SEMUA DPJP"

                tlpAsesmen.Enabled = True
                tlpSOAP.Enabled = True
                tlpPenunjang.Enabled = True
                tlpDPJP.Enabled = True

                btnSearch.Enabled = True
                btnSimpanASESMEN.Enabled = True
                btnCetakASESMEN.Enabled = True
                btnSimpanSOAP.Enabled = True
                btnCetakSOAP.Enabled = True
            End If
        End If
        isFromLoad = False
    End Sub

    Private Sub showDPJP(Optional idreg As String = "0", Optional isdeleted As Long = 0)
        'DPJP
        Dim sqls As New SQLs(dbstring)
        If isdeleted = 1 Then
            sqls.DMLQuery("select dp.idsoapnote,dp.idparamediscreator,dp.idspesialiscreator,dp.paramediscreatortype,pa.nama as paramedis,ps.nama as spesialis,dt.generalcode as dpjptype,sd.generalcode as statdata,dp.planning,dt.priority as dpjpprioritas,dp.isdeleted,isnull(pa.nama,0) + ' (' + isnull(ps.nama,0) + ')' + char(13) + char(10) + 'sebagai ' + dt.generalcode + ' ' + convert(varchar,dp.createddate,105) + ' ' + convert(varchar,dp.createddate,108) + char(13) + char(10) + dp.planning as note from soapnote dp left join spesialis ps on dp.idspesialiscreator=ps.idspesialis left join paramedis pa on dp.idparamediscreator=pa.idparamedis left join sys_generalcode dt on dp.paramediscreatortype=dt.idgeneral and dt.gctype='DPJPTYPE' left join sys_generalcode sd on dp.isdeleted=sd.idgeneral and sd.gctype='DELETE' where dp.idregistrasi='" & idreg & "' and dp.soapnotetype=2 order by dp.createddate asc", "dpjp")

            'sqls.DMLQuery("select dp.idregistrasidpjp,dp.idparamedis,dp.idspesialis,dp.dpjptype,pa.nama as paramedis,ps.nama as spesialis,dt.generalcode as dpjptype,sd.generalcode as statdata,dp.remarks,dt.priority as dpjpprioritas,dp.isdeleted,pa.nama + ' (' + ps.nama + ')' + char(13) + char(10) + 'sebagai ' + dt.generalcode + ' ' + convert(varchar,dp.createddate,105) + ' ' + convert(varchar,dp.createddate,108) + char(13) + char(10) + dp.remarks as note from registrasidpjp dp left join spesialis ps on dp.idspesialis=ps.idspesialis left join paramedis pa on dp.idparamedis=pa.idparamedis left join sys_generalcode dt on dp.dpjptype=dt.idgeneral and dt.gctype='DPJPTYPE' left join sys_generalcode sd on dp.isdeleted=sd.idgeneral and sd.gctype='DELETE' where dp.idregistrasi='" & idreg & "' order by dp.createddate asc", "dpjp")
        Else
            sqls.DMLQuery("select dp.idsoapnote,dp.idparamediscreator,dp.idspesialiscreator,dp.paramediscreatortype,pa.nama as paramedis,ps.nama as spesialis,dt.generalcode as dpjptype,sd.generalcode as statdata,dp.planning,dt.priority as dpjpprioritas,dp.isdeleted,isnull(pa.nama,0) + ' (' + isnull(ps.nama,0) + ')' + char(13) + char(10) + 'sebagai ' + dt.generalcode + ' ' + convert(varchar,dp.createddate,105) + ' ' + convert(varchar,dp.createddate,108) + char(13) + char(10) + dp.planning as note from soapnote dp left join spesialis ps on dp.idspesialiscreator=ps.idspesialis left join paramedis pa on dp.idparamediscreator=pa.idparamedis left join sys_generalcode dt on dp.paramediscreatortype=dt.idgeneral and dt.gctype='DPJPTYPE' left join sys_generalcode sd on dp.isdeleted=sd.idgeneral and sd.gctype='DELETE' where dp.idregistrasi='" & idreg & "' and dp.soapnotetype=2 and dp.isdeleted=0 order by dp.createddate asc", "dpjp")

            'sqls.DMLQuery("select dp.idregistrasidpjp,dp.idparamedis,dp.idspesialis,dp.dpjptype,pa.nama as paramedis,ps.nama as spesialis,dt.generalcode as dpjptype,sd.generalcode as statdata,dp.remarks,dt.priority as dpjpprioritas,dp.isdeleted,pa.nama + ' (' + ps.nama + ')' + char(13) + char(10) + 'sebagai ' + dt.generalcode + ' ' + convert(varchar,dp.createddate,105) + ' ' + convert(varchar,dp.createddate,108) + char(13) + char(10) + dp.remarks as note from registrasidpjp dp left join spesialis ps on dp.idspesialis=ps.idspesialis left join paramedis pa on dp.idparamedis=pa.idparamedis left join sys_generalcode dt on dp.dpjptype=dt.idgeneral and dt.gctype='DPJPTYPE' left join sys_generalcode sd on dp.isdeleted=sd.idgeneral and sd.gctype='DELETE' where dp.idregistrasi='" & idreg & "' and dp.isdeleted=0 order by dp.createddate asc", "dpjp")
        End If
        gcDPJP.DataSource = sqls.dataTable("dpjp")
        gvDPJP.BestFitColumns()

        btnBaruDPJP_Click(btnBaruDPJP, Nothing)
    End Sub

    Private isMouseDown As Boolean = False
    Private mouseClicked As Boolean = False
    Private mousePos As Point
    Private sizeShape As Single = 50
    Private Sub peAnatomi_Paint(sender As Object, e As PaintEventArgs) Handles peAnatomi.Paint
        If mouseClicked Then
            If isMouseDown Then
                If isClearImg = False Then
                    If mousePos.X > 0 And mousePos.Y > 0 Then
                        Using bmp As New Bitmap(peAnatomi.Image) 'lets get the original image
                            Using g As Graphics = Graphics.FromImage(bmp)
                                DrawACircle(g, mousePos, 40)
                                'DrawACircle(e.Graphics, mousePos, 50)
                                peAnatomi.Image = CType(bmp.Clone, Image)
                                isMouseDown = False
                            End Using
                        End Using
                    End If
                Else
                    peAnatomi.Image = Nothing
                End If
            End If
        End If
    End Sub

    Private Sub peAnatomi_MouseDown(sender As Object, e As MouseEventArgs) Handles peAnatomi.MouseDown
        If _anatomi = anatomiType.ZZ Then
            dizMsgbox("Pilih jenis Mark disisi samping kiri", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        mouseClicked = True
        mousePos = New Point(e.X - 42, e.Y - 20)
        'mousePos = New Point(peAnatomi.PointToClient(Control.MousePosition))
        isMouseDown = True
        peAnatomi.Invalidate()
    End Sub

    Private Sub peAnatomi_MouseUp(sender As Object, e As MouseEventArgs) Handles peAnatomi.MouseUp
        peAnatomi.Invalidate()
        isPoint = True
    End Sub

    Private Sub DrawACircle(ByRef g As Graphics, ByRef center As Point, ByVal radius As Integer)
        Dim pn As New Pen(Color.Red)
        pn.Width = 4
        Dim rect As New Rectangle(center.X - (radius / 2), center.Y - (radius / 2), radius, radius)
        Dim df As New StringFormat
        df.Alignment = StringAlignment.Center
        df.LineAlignment = StringAlignment.Center

        If _anatomi = anatomiType.A Then
            g.DrawEllipse(pn, rect)
            g.DrawString("A", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.B Then
            g.DrawEllipse(pn, rect)
        ElseIf _anatomi = anatomiType.C Then
            g.DrawEllipse(pn, rect)
            g.DrawString("C", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.CF Then
            g.DrawEllipse(pn, rect)
            g.DrawString("CF", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.D Then
            g.DrawEllipse(pn, rect)
            g.DrawString("D", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.H Then
            g.DrawEllipse(pn, rect)
            g.DrawString("H", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.N Then
            g.DrawEllipse(pn, rect)
            g.DrawString("N", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.OF1 Then
            g.DrawEllipse(pn, rect)
            g.DrawString("OF", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.U Then
            g.DrawEllipse(pn, rect)
            g.DrawString("U", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.V Then
            g.DrawEllipse(pn, rect)
            g.DrawString("V", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.SD Then
            g.DrawEllipse(pn, rect)
            g.DrawString("SD", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.ST Then
            g.DrawEllipse(pn, rect)
            g.DrawString("ST", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.OE Then
            g.DrawEllipse(pn, rect)
            g.DrawString("OE", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.CR Then
            g.DrawEllipse(pn, rect)
            g.DrawString("CR", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.W Then
            g.DrawEllipse(pn, rect)
            g.DrawString("W", New Font("Calibri", 18.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        ElseIf _anatomi = anatomiType.Int Then
            g.DrawString(nudNumbering.Value, New Font("Calibri", 16.0!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte)), New SolidBrush(Color.Red), rect, df)
        End If
    End Sub

    Private isClearImg As Boolean = False
    Private isPoint As Boolean = False
    Private Sub btnAnatomiCLear_Click(sender As Object, e As EventArgs) Handles btnAnatomiClear.Click
        isClearImg = True
        peAnatomi.Image = Nothing
        peAnatomi.Invalidate()
        mousePos.X = 0
        mousePos.Y = 0
        Threading.Thread.Sleep(1000)

        If teJenisKelamin.Tag = 0 Then
            imgAnatomi = My.Resources.anatomi_w
        ElseIf teJenisKelamin.Tag = 1 Then
            imgAnatomi = My.Resources.anatomi_p
        End If

        peAnatomi.Image = imgAnatomi
        isClearImg = False
        isPoint = False

        For Each btn As Button In tlpAnatomiTools.Controls
            btn.BackColor = Color.FromArgb(224, 224, 224)
        Next
        _anatomi = anatomiType.ZZ
    End Sub

    Private ipadd As String
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        tlpAsesmen.Dock = DockStyle.Top

        checkFieldMaxLength(dbstring, tlpTriage, "assessment")
        checkFieldMaxLength(dbstring, tlpTandaVital1, "assessment")
        checkFieldMaxLength(dbstring, tlpTandaVital2, "assessment")
        checkFieldMaxLength(dbstring, tlpTandaVital3, "assessment")
        checkFieldMaxLength(dbstring, tlpLainlain, "assessment")
        checkFieldMaxLength(dbstring, tlppSOAP, "soapnote")
        checkFieldMaxLength(dbstring, tlppPenunjang, "pemeriksaanpenunjang")
        imgAnatomi = Nothing
        tmrCek.Stop()
        ipadd = getIPAddress(ipaddparam.IP)

        loadLOV()
        btnSearch_Click(Me, Nothing)

        Dim pntx As Integer = (Me.Size.Width / 2) - (pAnatomi.Size.Width / 2)
        Dim pnty As Integer = (Me.Size.Height / 2) - (pAnatomi.Size.Height / 2)
        pAnatomi.Location = New Point(pntx, pnty)
        pAnatomi.SendToBack()

        btnAnatomiClear.Size = New Size(100, 30)
        nudNumbering.Size = New Size(48, 30)
        btnNumbering.Size = New Size(50, 30)

        gcAntrian.Size = New Size(196, 527)
        tlpAntrian.ColumnStyles.Item(0).Width = 162
        tlpAntrian.ColumnStyles.Item(1).Width = 30

        tlpAntrian.RowStyles.Item(0).Height = 30
        tlpAntrian.RowStyles.Item(1).Height = 90
        tlpAntrian.RowStyles.Item(2).Height = 6
        tlpAntrian.RowStyles.Item(3).Height = 90
        tlpAntrian.RowStyles.Item(4).Height = 6
        tlpAntrian.RowStyles.Item(5).Height = 90
        tlpAntrian.RowStyles.Item(6).Height = 6
        tlpAntrian.RowStyles.Item(7).Height = 90
        tlpAntrian.RowStyles.Item(8).Height = 6
        tlpAntrian.RowStyles.Item(9).Height = 90

        tlpAntrian.Size = New Size(192, 504)

        gcAntrian.Location = New Point(gcAntrian.Location.X, Me.Size.Height - ((gcAntrian.Size.Height - tlpAntrian.Size.Height) + lblAntrian.Size.Height - 2))
        btnAntrianMin.Tag = "Max"

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select iduser from paramedis where iduser='" & userid & "'", "cekuser")
        If sqls.getDataSet("cekuser") > 0 Then
            gcAntrian.Visible = True
        Else
            gcAntrian.Visible = False
        End If
    End Sub

    Private Sub lueAsalPx_EditValueChanged(sender As Object, e As EventArgs) Handles lueAsalPx.EditValueChanged
        If lueAsalPx.EditValue Is Nothing Then
            lblAsalPx2.Text = ""
            lblAsalPx2.Visible = False
            lueAsalPx2.Visible = False
            lblAsalPx3.Text = ""
            lblAsalPx3.Visible = False
            lueAsalPx3.Visible = False
            lblAsalPx4.Text = ""
            lblAsalPx4.Visible = False
            lueAsalPx4.Visible = False
        Else
            lblAsalPx2.Visible = True
            lueAsalPx2.Visible = True
            lblAsalPx3.Text = ""
            lblAsalPx3.Visible = False
            lueAsalPx3.Visible = False
            lblAsalPx4.Text = ""
            lblAsalPx4.Visible = False
            lueAsalPx4.Visible = False

            If lueAsalPx.EditValue = 1 Then
                lblAsalPx2.Text = "dari *2"
                lblAsalPx2.Visible = True
                lueAsalPx2.Visible = True
                lueAsalPx2.EditValue = Nothing

                lblAsalPx3.Text = ""
                lblAsalPx3.Visible = False
                lueAsalPx3.Visible = False
                lueAsalPx3.EditValue = Nothing
                lueAsalPx3.Properties.DataSource = Nothing

                lblAsalPx4.Text = ""
                lblAsalPx4.Visible = False
                lueAsalPx4.Visible = False
                lueAsalPx4.EditValue = Nothing
                lueAsalPx4.Properties.DataSource = Nothing

                Dim mysqls As New SQLs(dbstring)
                mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ASALPXRUJ' order by idgeneral asc", "asalpx2")
                lueAsalPx2.Properties.DataSource = mysqls.dataTable("asalpx2")
                lueAsalPx2.Properties.DisplayMember = "content"
                lueAsalPx2.Properties.ValueMember = "id"
                If mysqls.getDataSet("asalpx2") = 0 Then
                    dizMsgbox("Asal Pasien tidak ditemukan" & vbCrLf & "Asal Pasien harap entry dulu", dizMsgboxStyle.Peringatan, Me)
                    pExit_Click(Me, Nothing)
                    Exit Sub
                End If
            ElseIf lueAsalPx.EditValue = 2 Then
                lblAsalPx2.Text = "Tahu dari *2"
                lblAsalPx2.Visible = True
                lueAsalPx2.Visible = True
                lueAsalPx2.EditValue = Nothing
                lblAsalPx3.Text = ""
                lblAsalPx3.Visible = False
                lueAsalPx3.Visible = False
                lueAsalPx3.EditValue = Nothing
                lblAsalPx4.Text = ""
                lblAsalPx4.Visible = False
                lueAsalPx4.Visible = False
                lueAsalPx4.EditValue = Nothing

                Dim mysqls As New SQLs(dbstring)
                mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ASALPXDTG' order by idgeneral asc", "asalpx2")
                lueAsalPx2.Properties.DataSource = mysqls.dataTable("asalpx2")
                lueAsalPx2.Properties.DisplayMember = "content"
                lueAsalPx2.Properties.ValueMember = "id"
                If mysqls.getDataSet("asalpx2") = 0 Then
                    dizMsgbox("Asal Pasien tidak ditemukan" & vbCrLf & "Asal Pasien harap entry dulu", dizMsgboxStyle.Peringatan, Me)
                    pExit_Click(Me, Nothing)
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub lueAsalPx2_EditValueChanged(sender As Object, e As EventArgs) Handles lueAsalPx2.EditValueChanged
        If lueAsalPx.EditValue = 2 Then
            lueAsalPx3.Properties.DataSource = Nothing
            lueAsalPx4.Properties.DataSource = Nothing

            lblAsalPx3.Text = ""
            lblAsalPx3.Visible = False
            lueAsalPx3.Visible = False
            lueAsalPx3.EditValue = Nothing
            lueAsalPx3.Properties.DataSource = Nothing
            lblAsalPx4.Text = ""
            lblAsalPx4.Visible = False
            lueAsalPx4.Visible = False
            lueAsalPx4.EditValue = Nothing
            lueAsalPx4.Properties.DataSource = Nothing

            Exit Sub
        End If
        If lueAsalPx2.EditValue = 1 Then
            lblAsalPx3.Text = "Dokter *3"
            lblAsalPx3.Visible = True
            lueAsalPx3.Visible = True
            lueAsalPx3.EditValue = Nothing
            lblAsalPx4.Text = ""
            lblAsalPx4.Visible = False
            lueAsalPx4.Visible = False
            lueAsalPx4.EditValue = Nothing
            lueAsalPx4.Properties.DataSource = Nothing

            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select p.idparamedis as id,p.nama + ' ('+ gc.generalcode + ')' as content from paramedis p left join sys_generalcode gc on p.paramedistype=gc.idgeneral and gc.gctype='PARAMEDISTYPE' where p.paramedistype>0 and p.isdeleted=0 order by gc.generalcode asc,p.nama asc", "asalpx3")
            lueAsalPx3.Properties.DataSource = mysqls.dataTable("asalpx3")
            lueAsalPx3.Properties.DisplayMember = "content"
            lueAsalPx3.Properties.ValueMember = "id"
            lueAsalPx3.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            lueAsalPx3.Properties.BestFit()
            If mysqls.getDataSet("asalpx3") = 0 Then
                dizMsgbox("Dokter tidak ditemukan" & vbCrLf & "Dokter harap entry dulu", dizMsgboxStyle.Peringatan, Me)
                pExit_Click(Me, Nothing)
                Exit Sub
            End If
        ElseIf lueAsalPx2.EditValue = 2 Then
            lblAsalPx3.Text = "Rumah Sakit/Klinik *3"
            lblAsalPx3.Visible = True
            lueAsalPx3.Visible = True
            lueAsalPx3.EditValue = Nothing
            lblAsalPx4.Text = ""
            lblAsalPx4.Visible = False
            lueAsalPx4.Visible = False
            lueAsalPx4.EditValue = Nothing
            lueAsalPx4.Properties.DataSource = Nothing

            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select idbusinesspartner as id,nama as content from businesspartner where businesspartnertype=5 order by idbusinesspartner asc", "asalpx3")
            lueAsalPx3.Properties.DataSource = mysqls.dataTable("asalpx3")
            lueAsalPx3.Properties.DisplayMember = "content"
            lueAsalPx3.Properties.ValueMember = "id"
            If mysqls.getDataSet("asalpx3") = 0 Then
                dizMsgbox("Rumah Sakit/Klinik tidak ditemukan" & vbCrLf & "Rumah Sakit/Klinik harap entry dulu", dizMsgboxStyle.Peringatan, Me)
                pExit_Click(Me, Nothing)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub lueAsalPx3_EditValueChanged(sender As Object, e As EventArgs) Handles lueAsalPx3.EditValueChanged
        If lueAsalPx3.EditValue Is Nothing Then
            lueAsalPx4.Properties.DataSource = Nothing
            lblAsalPx4.Text = ""
            lblAsalPx4.Visible = False
            lueAsalPx4.Visible = False
            lueAsalPx4.EditValue = Nothing
        Else
            If lueAsalPx.EditValue = 1 Then
                If lueAsalPx2.EditValue <> 2 Then
                    lblAsalPx4.Text = ""
                    lblAsalPx4.Visible = False
                    lueAsalPx4.Visible = False
                    lueAsalPx4.EditValue = Nothing
                    lueAsalPx4.Properties.DataSource = Nothing
                ElseIf lueAsalPx2.EditValue = 2 Then
                    lblAsalPx4.Text = "Dokter/Ahli *4"
                    lblAsalPx4.Visible = True
                    lueAsalPx4.Visible = True
                    lueAsalPx4.EditValue = Nothing

                    Dim mysqls As New SQLs(dbstring)
                    mysqls.DMLQuery("select p.idparamedis as id,p.nama + ' ('+ gc.generalcode + ')' as content from paramedis p left join sys_generalcode gc on p.paramedistype=gc.idgeneral and gc.gctype='PARAMEDISTYPE' where p.isdeleted=0 order by gc.generalcode asc,p.nama asc", "asalpx4")
                    lueAsalPx4.Properties.DataSource = mysqls.dataTable("asalpx4")
                    lueAsalPx4.Properties.DisplayMember = "content"
                    lueAsalPx4.Properties.ValueMember = "id"
                    lueAsalPx4.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                    lueAsalPx4.Properties.BestFit()
                    If mysqls.getDataSet("asalpx4") = 0 Then
                        dizMsgbox("Dokter tidak ditemukan" & vbCrLf & "Dokter harap entry dulu", dizMsgboxStyle.Peringatan, Me)
                        pExit_Click(Me, Nothing)
                        Exit Sub
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub lueSkalaTriage_EditValueChanged(sender As Object, e As EventArgs) Handles lueSkalaTriage.EditValueChanged
        If lueSkalaTriage.EditValue Is Nothing Then
            teWaktuTunggu.Text = ""
            Exit Sub
        End If

        Dim splt() As String = lueSkalaTriage.Text.Split("/")
        If splt.Length <> 2 Then
            teWaktuTunggu.Text = ""
        Else
            teWaktuTunggu.Text = splt(1)
        End If
    End Sub

    Private Function checkEntry() As Boolean
        Dim retval As Boolean = True
        retval = modCore.checkEntry(tlpTriage)
        retval = modCore.checkEntry(tlpTandaVital1)
        retval = modCore.checkEntry(tlpTandaVital2)
        retval = modCore.checkEntry(tlpTandaVital3)
        retval = modCore.checkEntry(tlpLainlain)
        If idselect = "-1" Then retval = False
        Return retval
    End Function

    Private isoneday As Long = 0
    Private noreg As String = ""
    Private idreg As String = "-1"
    Private iddas As String = "-1"
    Private iddso As String = "-1"
    Private Sub btnSimpanASESMEN_Click(sender As Object, e As EventArgs) Handles btnSimpanASESMEN.Click
        Dim cek As Boolean = True
        'cek = mouseClicked
        'If cek = False Then
        '    dizMsgbox("Anatomi belum benar", dizMsgboxStyle.Info, Me)
        '    Exit Sub
        'End If
        cek = prosesSimpan()
        If cek = False Then
            dizMsgbox("Asesmen belum benar", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        cek = prosesSimpanSOAP()
        If cek = False Then
            dizMsgbox("SOAP belum benar", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        cek = prosesSimpanPENUNJANG()
        If cek = False Then
            dizMsgbox("PENUNJANG belum benar", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If cek = True Then
            dizMsgbox("Asesmen telah tersimpan", dizMsgboxStyle.Info, Me)
        End If
    End Sub

    Private Sub btnCetakASESMEN_Click(sender As Object, e As EventArgs) Handles btnCetakASESMEN.Click
        Dim cek As Boolean = True
        'cek = mouseClicked
        'If cek = False Then
        '    dizMsgbox("Anatomi belum benar", dizMsgboxStyle.Info, Me)
        '    Exit Sub
        'End If
        cek = prosesSimpan()
        If cek = False Then
            dizMsgbox("Asesmen belum benar", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        cek = prosesSimpanSOAP()
        If cek = False Then
            dizMsgbox("SOAP belum benar", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        cek = prosesSimpanPENUNJANG()
        If cek = False Then
            dizMsgbox("PENUNJANG belum benar", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If

        If cek = True Then
            dizMsgbox("Asesmen telah tersimpan", dizMsgboxStyle.Info, Me)
            cetakBerkasAMIGD(iddas, iddas)
        End If
    End Sub

    Private Function prosesSimpan() As Boolean
        Dim cek As Boolean = True
        If checkEntry() = False Then
            dizMsgbox("Isian belum benar", dizMsgboxStyle.Peringatan, Me)
            cek = False
        End If
        If lueAlergi.EditValue = CLng(1) Then
            If meAlergi.Text = "" Then
                dizMsgbox("Isian Alergi dan Reaksi belum diisi", dizMsgboxStyle.Peringatan, Me)
                cek = False
            End If
        End If
        If meAlergi.Lines.Count <> meReaksiAlergi.Lines.Count Then
            dizMsgbox("Isian Alergi dan Reaksi tidak sama", dizMsgboxStyle.Peringatan, Me)
            cek = False
        End If
        If cek = True Then
            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            Dim dtsqls As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            If iddas <> "-1" Then
                field.AddRange(New String() {"idassessment", "isdeleted", "updatedby", "updateddate"})
                value.AddRange(New Object() {iddas, 1, userid, nowTime})
                dtsqls.datasetSave("assessment", iddas, field, value, False)
            End If

            If iddas = "-1" Then
                Dim pair As KeyValuePair(Of String, String) = generateno2(idunitselect, iddeptselect, "AssessmentMedis", False)
                idtransselectas = pair.Key
                teNoAsesmen.Text = pair.Value
                iddas = GenerateGUID()
            End If

            Dim dtsqls1 As New dtsetSQLS(dbstring)
            Dim field1 As New List(Of String)
            Dim value1 As New List(Of Object)

            'Dim strguid As String = GenerateUniqueID(GenerateHash(Format(nowTime, "ddMMyyyyHHmmssff") & idhostname), 1000)
            field1.AddRange(New String() {"idassessment", "idregistrasi", "transactiontype", "assessmentno", "skalatriage", "tanggaldatang", "tanggalkejadian", "gcse", "gcsv", "gcsm", "iskesadaran", "pupila", "pupilb", "isrefcahaya", "tdsis", "tddias", "denyutnadi", "isnadi", "suhu", "nafas", "oksigendarah", "isakral", "isgangguanperilaku", "isperilakubahaya", "isinformasi", "familytype", "namainformasi", "iscaramasuk", "caramasuk", "ispengantar", "namapengantar", "ispenyebab", "penyebab", "gayahidup", "gayahidupnote", "asalpx", "asalpx2", "asalrujukan", "iddokterrujukan", "isdeleted", "createdby", "idcompany", "nomorform"})

            value1.AddRange(New Object() {iddas, idselect, idtransselectas, teNoAsesmen.Text, lueSkalaTriage.EditValue, CDate(deDatang.EditValue), CDate(deKejadian.EditValue), nudGCSE.EditValue, nudGCSV.EditValue, nudGCSM.EditValue, If(lueKesadaran.EditValue, 1), nudPupil1.EditValue, nudPupil2.EditValue, If(lueRefleks.EditValue, 0), nudSistol.EditValue, nudDiastol.EditValue, nudNadi.EditValue, If(lueNadiJenis.EditValue, 1), nudSuhu.EditValue, nudNafas.EditValue, nudSpO2.EditValue, If(lueAkral.EditValue, 1), If(lueGangguan.EditValue, 0), If(lueMembahayakan.EditValue, 0), If(lueSumberInfo.EditValue, 0), If(lueHubungan.EditValue, 0), If(lueHubungan.EditValue, teNama.Text, teHubungan.Text), If(lueCaraMasuk.EditValue, 0), If(teCaraMasuk.EditValue, "-"), If(luePengantar.EditValue, 0), tePengantar.Text, If(luePenyebab.EditValue, 0), tePenyebab.Text, If(lueGayaHidup.EditValue, 0), teGayaHidup.Text, If(lueAsalPx.EditValue, 0), If(lueAsalPx2.EditValue, 0), If(lueAsalPx3.EditValue, 0), If(lueAsalPx4.EditValue, 0), 0, userid, idcomp, "AMIGD201801"})

            cek = dtsqls1.datasetSave("assessment", iddas, field1, value1, False)
            Dim sqls As New SQLs(dbstring)
            'sqls.DMLQuery("select idassessment from assessment where guid='" & strguid & "'", "getidas")
            'iddas = CLng(sqls.getDataSet("getidas", 0, "idassessment"))

            If lueAlergi.EditValue = CLng(1) Then
                sqls.DMLQuery("update riwayatpasien set isdeleted=1,updatedby='" & userid & "',updateddate=getdate() where riwayattype=4 and riwayatalergitype=8 and tablereff2='REGISTRASI' and idreff2='" & idreg & "' and tablereff='PASIEN' and idreff='" & teNoRM.Tag & "'", False)

                Dim friwayat As New List(Of String)
                Dim vriwayat As New List(Of Object)
                friwayat.AddRange(New String() {"idriwayatpasien", "idreff", "tablereff", "idreff2", "tablereff2", "riwayattype", "isriwayat", "riwayat", "riwayatalergitype", "remarks", "reaksi", "dosis", "durasi", "isdeleted", "deletereason", "createdby", "createddate", "idcompany"})
                For i As Integer = 0 To meAlergi.Lines.Count - 1
                    dtsqls = New dtsetSQLS(dbstring)

                    Dim idriwayatpasien As String = GenerateGUID()
                    vriwayat.Clear()
                    vriwayat.AddRange(New Object() {idriwayatpasien, teNoRM.Tag, "PASIEN", idreg, "REGISTRASI", 4, 0, meAlergi.Lines(i).ToString, 8, "-", meReaksiAlergi.Lines(i).ToString, 0, 0, 0, "-", userid, nowTime, idcomp})
                    dtsqls.datasetSave("riwayatpasien", idriwayatpasien, friwayat, vriwayat, False)
                Next
            Else
                sqls.DMLQuery("update riwayatpasien set isdeleted=1,updatedby='" & userid & "',updateddate=getdate() where tablereff2='REGISTRASI' and idreff2='" & idreg & "' and tablereff='PASIEN' and idreff='" & teNoRM.Tag & "'", False)
            End If

            sqls.DMLQuery("update registrasi set isasesmenmedis=1 where idregistrasi='" & idselect & "'", False)
        End If

        If cek = True Then
            'dizMsgbox("Asesmen telah tersimpan", dizMsgboxStyle.Info, Me)
        End If
        Return cek
    End Function

    Private Sub cetakBerkasAMIGD(iddata As String, idreg As String)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@id"})
        value.AddRange(New Object() {iddata})

        Dim field2 As New List(Of String)
        Dim value2 As New List(Of Object)
        field2.AddRange(New String() {"@id"})
        value2.AddRange(New Object() {idreg})

        Dim mys As New SQLs(dbstring)
        mys.CallSP("spAMIGD201801", "asmigd", field, value)

        Dim mysSOAP As New SQLs(dbstring)
        mysSOAP.CallSP("spSN201801", "soap", field2, value2)

        Dim mysAMU As New SQLs(dbstring)
        mysAMU.CallSP("spAMunit", "unit", field, value)

        Dim mysA As New SQLs(dbstring)
        mysA.CallSP("spRiwayatA201801", "a", field2, value2)

        Dim mysS As New SQLs(dbstring)
        mysS.CallSP("spRiwayatS201801", "s", field2, value2)

        Dim mysD As New SQLs(dbstring)
        mysD.CallSP("spRiwayatD201801", "d", field2, value2)

        Dim mysO As New SQLs(dbstring)
        mysO.CallSP("spRiwayatO201801", "o", field2, value2)

        Dim mysSNU As New SQLs(dbstring)
        mysSNU.CallSP("spSNunit", "unit", field2, value2)

        Dim mysAn As New SQLs(dbstring)
        mysAn.CallSP("spAnatomi", "anatomi", field2, value2)

        Dim mysE As New SQLs(dbstring)
        mysE.CallSP("spPenunjangEKG", "ekg", field2, value2)

        Dim mysL As New SQLs(dbstring)
        mysL.CallSP("spPenunjangLAB", "lab", field2, value2)

        Dim mysR As New SQLs(dbstring)
        mysR.CallSP("spPenunjangRAD", "rad", field2, value2)

        Dim mysP As New SQLs(dbstring)
        mysP.CallSP("spRegDPJP", "dpjp", field2, value2)

        Dim rptA As New xrRiwayatA201801
        rptA.RequestParameters = False
        rptA.DataAdapter = mysA.getDataAdapter
        rptA.DataSource = mysA.dataSet
        rptA.DataMember = "a"

        Dim rptS As New xrRiwayatS201801
        rptS.RequestParameters = False
        rptS.DataAdapter = mysS.getDataAdapter
        rptS.DataSource = mysS.dataSet
        rptS.DataMember = "s"

        Dim rptD As New xrRiwayatD201801
        rptD.RequestParameters = False
        rptD.DataAdapter = mysD.getDataAdapter
        rptD.DataSource = mysD.dataSet
        rptD.DataMember = "d"

        Dim rptO As New xrRiwayatO201801
        rptO.RequestParameters = False
        rptO.DataAdapter = mysO.getDataAdapter
        rptO.DataSource = mysO.dataSet
        rptO.DataMember = "o"

        Dim rptAn As New xrAnatomiSQ
        rptAn.RequestParameters = False
        rptAn.DataAdapter = mysAn.getDataAdapter
        rptAn.DataSource = mysAn.dataSet
        rptAn.DataMember = "anatomi"

        Dim rptE As New xrPenunjangE201801
        rptE.RequestParameters = False
        rptE.DataAdapter = mysE.getDataAdapter
        rptE.DataSource = mysE.dataSet
        rptE.DataMember = "ekg"

        Dim rptL As New xrPenunjangL201801
        rptL.RequestParameters = False
        rptL.DataAdapter = mysL.getDataAdapter
        rptL.DataSource = mysL.dataSet
        rptL.DataMember = "lab"

        Dim rptR As New xrPenunjangR201801
        rptR.RequestParameters = False
        rptR.DataAdapter = mysR.getDataAdapter
        rptR.DataSource = mysR.dataSet
        rptR.DataMember = "rad"

        Dim rptDPJP As New xrDPJPIGD201801
        rptDPJP.RequestParameters = False
        rptDPJP.DataAdapter = mysP.getDataAdapter
        rptDPJP.DataSource = mysP.dataSet
        rptDPJP.DataMember = "dpjp"

        Dim rptSOAP As New xrSOAPIncIGD201801
        rptSOAP.subAnatomi.ReportSource = rptAn
        rptSOAP.subEKG.ReportSource = rptE
        rptSOAP.subLAB.ReportSource = rptL
        rptSOAP.subRAD.ReportSource = rptR
        rptSOAP.subSkrg.ReportSource = rptS
        rptSOAP.subDulu.ReportSource = rptD
        rptSOAP.subObat.ReportSource = rptO
        rptSOAP.RequestParameters = False
        rptSOAP.DataAdapter = mysSOAP.getDataAdapter
        rptSOAP.DataSource = mysSOAP.dataSet
        rptSOAP.DataMember = "soap"

        Dim rpt As New xrAMIGD201801
        rpt.subAlergi.ReportSource = rptA
        rpt.subSOAP.ReportSource = rptSOAP
        rpt.subDPJP.ReportSource = rptDPJP
        rpt.RequestParameters = False
        rpt.DataAdapter = mys.getDataAdapter
        rpt.DataSource = mys.dataSet
        rpt.DataMember = "asmigd"
        rpt.DisplayName = "AMIGD201801"
        rpt.Parameters("pID").Value = iddata
        rpt.Parameters("pNo").Value = iddata
        rpt.Parameters("pUnit").Value = mysAMU.getDataSet("unit", 0, "unit")
        rpt.Parameters("pNotes").Value = mysSNU.getDataSet("unit", 0, "notes")
        rpt.Parameters("pFooter").Value = "dicetak oleh " & username & " pada " & Format(nowTime, "dd ") & NamaBulan(nowTime.Month) & Format(nowTime, " yyyy HH: mm")
        rpt.ShowPrintMarginsWarning = False

        Dim pt As New DevExpress.XtraReports.UI.ReportPrintTool(rpt)
        pt.Report.CreateDocument(False)
        AddHandler pt.PreviewForm.Load, AddressOf PreviewForm_Load

        Dim sharename As String = getPrinter("ASMIGD")
        If sharename <> "" Then
            Try
                pt.Print(sharename)
            Catch ex As Exception
                dizMsgbox("Printer tidak ditemukan/tidak ada akses", dizMsgboxStyle.Peringatan)
            End Try
        Else
            dizMsgbox("Printer belum disetting untuk cetak dokumen ini", dizMsgboxStyle.Peringatan, Me)
        End If
        'Dim sd As New frmSelectDevice
        'tambahChild(sd)
        'If sd.ShowDialog() = DialogResult.OK Then
        '    pt.Print(sd.getdevicename)
        'End If
    End Sub

    Private Sub PrintPageHandler(ByVal sender As Object,
       ByVal args As Printing.PrintPageEventArgs)
    End Sub

    Private Sub PreviewForm_Load(sender As Object, ByVal e As EventArgs)
        Dim frm As DevExpress.XtraPrinting.Preview.PrintPreviewFormEx = CType(sender, DevExpress.XtraPrinting.Preview.PrintPreviewFormEx)
        frm.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.Scale, New Object() {1.0F})
    End Sub

    Private Sub lueAlergi_EditValueChanged(sender As Object, e As EventArgs) Handles lueAlergi.EditValueChanged
        If lueAlergi.EditValue Is Nothing Then
            meAlergi.Text = "-"
            meReaksiAlergi.Text = "-"

            meAlergi.Properties.ReadOnly = True
            meReaksiAlergi.Properties.ReadOnly = True
        Else
            If lueAlergi.EditValue = CLng(0) Then
                meAlergi.Text = "-"
                meReaksiAlergi.Text = "-"

                meAlergi.Properties.ReadOnly = True
                meReaksiAlergi.Properties.ReadOnly = True
            Else
                meAlergi.Text = ""
                meReaksiAlergi.Text = ""

                meAlergi.Properties.ReadOnly = False
                meReaksiAlergi.Properties.ReadOnly = False
            End If
        End If
    End Sub

    Private Sub luePengantar_EditValueChanged(sender As Object, e As EventArgs) Handles luePengantar.EditValueChanged
        If luePengantar.EditValue Is Nothing Then
            tePengantar.Text = "-"

            tePengantar.Properties.ReadOnly = True
        Else
            If luePengantar.EditValue = CLng(0) Then
                tePengantar.Text = "-"

                tePengantar.Properties.ReadOnly = True
            Else
                tePengantar.Text = ""

                tePengantar.Properties.ReadOnly = False
            End If
        End If
    End Sub

    Private Sub luePenyebab_EditValueChanged(sender As Object, e As EventArgs) Handles luePenyebab.EditValueChanged
        If luePenyebab.EditValue Is Nothing Then
            tePenyebab.Text = "-"

            tePenyebab.Properties.ReadOnly = True
        Else
            If luePenyebab.EditValue = CLng(0) Then
                tePenyebab.Text = "-"

                tePenyebab.Properties.ReadOnly = True
            Else
                tePenyebab.Text = ""

                tePenyebab.Properties.ReadOnly = False
            End If
        End If
    End Sub

    Private Sub lueHubungan_EditValueChanged(sender As Object, e As EventArgs) Handles lueHubungan.EditValueChanged
        If lueHubungan.EditValue Is Nothing Then
            teHubungan.Text = "-"

            teHubungan.Properties.ReadOnly = True
        Else
            If lueHubungan.EditValue = CLng(0) Then
                teHubungan.Text = "-"

                teHubungan.Properties.ReadOnly = True
            Else
                teHubungan.Text = ""

                teHubungan.Properties.ReadOnly = False
            End If
        End If
    End Sub

    Private Sub lueGangguan_EditValueChanged(sender As Object, e As EventArgs) Handles lueGangguan.EditValueChanged
        If lueGangguan.EditValue Is Nothing Then
            lueMembahayakan.EditValue = Nothing

            lueMembahayakan.Properties.ReadOnly = True
        Else
            If lueGangguan.EditValue = CLng(0) Then
                lueMembahayakan.EditValue = Nothing

                lueMembahayakan.Properties.ReadOnly = True
            Else
                lueMembahayakan.EditValue = Nothing

                lueMembahayakan.Properties.ReadOnly = False
            End If
        End If
    End Sub

    Private Sub lueSumberInfo_EditValueChanged(sender As Object, e As EventArgs) Handles lueSumberInfo.EditValueChanged
        If lueSumberInfo.EditValue Is Nothing Then
            lueHubungan.Properties.DataSource = Nothing
            lueHubungan.EditValue = Nothing
            lueHubungan.Properties.ReadOnly = True
            teHubungan.EditValue = Nothing
            teHubungan.Properties.ReadOnly = False
        Else
            If lueSumberInfo.EditValue = CLng(0) Then
                Dim sqls As New SQLs(dbstring)
                sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where idgeneral=0 and gctype='FAMILYTYPE' order by idgeneral asc", "familytype")
                lueHubungan.Properties.DataSource = sqls.dataTable("familytype")
                lueHubungan.EditValue = CLng(0)
                lueHubungan.Properties.ReadOnly = True
                teHubungan.Text = teNama.Text
                teHubungan.Properties.ReadOnly = True
            Else
                Dim sqls As New SQLs(dbstring)
                sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where idgeneral<>0 and gctype='FAMILYTYPE' order by idgeneral asc", "familytype")
                lueHubungan.Properties.DataSource = sqls.dataTable("familytype")
                lueHubungan.EditValue = Nothing
                lueHubungan.Properties.ReadOnly = False
                teHubungan.Text = ""
                teHubungan.Properties.ReadOnly = False
            End If
        End If
    End Sub

    Private Sub btnSimpanSOAP_Click(sender As Object, e As EventArgs) Handles btnSimpanSOAP.Click
        prosesSimpanSOAP()
    End Sub

    Private Sub btnCetakSOAP_Click(sender As Object, e As EventArgs) Handles btnCetakSOAP.Click
        If prosesSimpanSOAP() = True Then
            cetakBerkasAMIGD(iddas, iddas)
        End If
    End Sub

    Private Sub cetakBerkasSOAP(iddata As String, nodata As String)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@id"})
        value.AddRange(New Object() {iddata})

        Dim mys As New SQLs(dbstring)
        mys.CallSP("spSN201801", "soap", field, value)

        Dim mys2 As New SQLs(dbstring)
        mys2.CallSP("spRiwayatS201801", "s", field, value)

        Dim mys3 As New SQLs(dbstring)
        mys3.CallSP("spRiwayatD201801", "d", field, value)

        Dim mys4 As New SQLs(dbstring)
        mys4.CallSP("spRiwayatO201801", "o", field, value)

        Dim mys5 As New SQLs(dbstring)
        mys5.CallSP("spSNunit", "unit", field, value)

        Dim mys6 As New SQLs(dbstring)
        mys6.CallSP("spAnatomi", "anatomi", field, value)

        Dim mys7 As New SQLs(dbstring)
        mys7.CallSP("spPenunjangEKG", "ekg", field, value)

        Dim mys8 As New SQLs(dbstring)
        mys8.CallSP("spPenunjangLAB", "lab", field, value)

        Dim mys9 As New SQLs(dbstring)
        mys9.CallSP("spPenunjangRAD", "rad", field, value)

        Dim rpt2 As New xrRiwayatS201801
        rpt2.RequestParameters = False
        rpt2.DataAdapter = mys2.getDataAdapter
        rpt2.DataSource = mys2.dataSet
        rpt2.DataMember = "s"

        Dim rpt3 As New xrRiwayatD201801
        rpt3.RequestParameters = False
        rpt3.DataAdapter = mys3.getDataAdapter
        rpt3.DataSource = mys3.dataSet
        rpt3.DataMember = "d"

        Dim rpt4 As New xrRiwayatO201801
        rpt4.RequestParameters = False
        rpt4.DataAdapter = mys4.getDataAdapter
        rpt4.DataSource = mys4.dataSet
        rpt4.DataMember = "o"

        Dim rpt5 As New xrAnatomi
        rpt5.RequestParameters = False
        rpt5.DataAdapter = mys6.getDataAdapter
        rpt5.DataSource = mys6.dataSet
        rpt5.DataMember = "anatomi"

        Dim rpt6 As New xrPenunjangE201801
        rpt6.RequestParameters = False
        rpt6.DataAdapter = mys7.getDataAdapter
        rpt6.DataSource = mys7.dataSet
        rpt6.DataMember = "ekg"

        Dim rpt7 As New xrPenunjangL201801
        rpt7.RequestParameters = False
        rpt7.DataAdapter = mys8.getDataAdapter
        rpt7.DataSource = mys8.dataSet
        rpt7.DataMember = "lab"

        Dim rpt8 As New xrPenunjangR201801
        rpt8.RequestParameters = False
        rpt8.DataAdapter = mys9.getDataAdapter
        rpt8.DataSource = mys9.dataSet
        rpt8.DataMember = "rad"

        Dim rpt As New xrSOAP201801
        rpt.XrSubreport1.ReportSource = rpt2
        rpt.XrSubreport2.ReportSource = rpt3
        rpt.XrSubreport3.ReportSource = rpt4
        rpt.XrSubreport4.ReportSource = rpt5
        rpt.XrSubreport5.ReportSource = rpt6
        rpt.XrSubreport6.ReportSource = rpt7
        rpt.XrSubreport7.ReportSource = rpt8
        rpt.RequestParameters = False
        rpt.DataAdapter = mys.getDataAdapter
        rpt.DataSource = mys.dataSet
        rpt.DataMember = "soap"
        rpt.DisplayName = teNama.Text
        rpt.Parameters("pID").Value = iddata
        rpt.Parameters("pNo").Value = nodata
        rpt.Parameters("pUnit").Value = mys5.getDataSet("unit", 0, "unit")
        rpt.Parameters("pNotes").Value = mys5.getDataSet("unit", 0, "notes")
        rpt.Parameters("pFooter").Value = "dicetak oleh " & username & " pada " & Format(nowTime, "dd ") & NamaBulan(nowTime.Month) & Format(nowTime, " yyyy HH: mm")
        rpt.ShowPrintMarginsWarning = False

        Dim pt As New DevExpress.XtraReports.UI.ReportPrintTool(rpt)
        pt.Report.CreateDocument(False)
        AddHandler pt.PreviewForm.Load, AddressOf PreviewForm_Load
        pt.Print()
    End Sub

    Private Function prosesSimpanSOAP() As Boolean
        Dim cek As Boolean = True
        If modCore.checkEntry(tlppSOAP) = False Then
            dizMsgbox("SOAP belum benar", dizMsgboxStyle.Peringatan, Me)
            cek = False
        End If
        Dim strdk As String = meDiagnosaKerja.Text.Replace(" ", "")
        strdk = strdk.ToLower
        If strdk.Contains("diagnosakerja") Then
            dizMsgbox("Diagnosa Kerja tidak perlu mencantumkan 'Diagnosa Kerja'", dizMsgboxStyle.Peringatan, Me)
            cek = False
        End If
        Dim strdb As String = meDiagnosaBanding.Text.Replace(" ", "")
        strdb = strdb.ToLower
        If strdb.Contains("diagnosabanding") Then
            dizMsgbox("Diagnosa Banding tidak perlu mencantumkan 'Diagnosa Banding'", dizMsgboxStyle.Peringatan, Me)
            cek = False
        End If
        'If mouseClicked = False Then
        '    dizMsgbox("Anatomi belum benar", dizMsgboxStyle.Peringatan, Me)
        '    cek = False
        'End If

        If cek = True Then
            If iddso = "-1" Then
                Dim pair As KeyValuePair(Of String, String) = generateno2(idunitselect, iddeptselect, "SOAPMedis", False)
                idtransselectso = pair.Key
                teNoSOAP.Text = pair.Value
                'btnBaruDiagnosaKerja.Enabled = False
            End If

            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select iddokterruangan,idspesialisruangan from registrasi where idregistrasi='" & idreg & "'", "getidsp")
            Dim idparru As String = sqls.getDataSet("getidsp", 0, "iddokterruangan")
            Dim idspru As String = sqls.getDataSet("getidsp", 0, "idspesialisruangan")

            sqls.DMLQuery("select d.idanalisarmdt,d.idicd,d.jenisdiagnosa,jd.generalcode as jnsdiagnosa,i.icdtype,i.kode,i.diagnosa,d.remarks,d.isdeleted,del.generalcode as statdata,it.generalcode as jenisicd from analisarmdt d left join icd i on d.idicd=i.idicd left join sys_generalcode del on d.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode it on i.icdtype=it.idgeneral and it.gctype='ICDTYPE' left join sys_generalcode jd on d.jenisdiagnosa=jd.idgeneral and jd.gctype='JENISDIAGNOSA' where d.analisarmtype=1 and d.isdeleted=0 and d.idregistrasi='" & idreg & "' order by d.jenisdiagnosa asc,d.createddate desc", "getdiagnosa")
            If sqls.getDataSet("getdiagnosa") > 0 Then
                Me.meDiagnosaKerja.Text = ""
                For i As Integer = 0 To sqls.getDataSet("getdiagnosa") - 1
                    If sqls.getDataSet("getdiagnosa", i, "remarks") = "-" Then
                        meDiagnosaKerja.Text &= sqls.getDataSet("getdiagnosa", i, "diagnosa")
                    Else
                        meDiagnosaKerja.Text &= sqls.getDataSet("getdiagnosa", i, "diagnosa") & " - " & sqls.getDataSet("getdiagnosa", i, "remarks")
                    End If
                    If i < sqls.getDataSet("getdiagnosa") - 1 Then
                        meDiagnosaKerja.Text &= vbCrLf
                    End If
                Next
            Else
                meDiagnosaKerja.Text = ""
            End If

            'Dim strguid As String = GenerateUniqueID(GenerateHash(Format(nowTime, "ddMMyyyyHHmmssff") & idhostname), 1000)
            iddso = GenerateGUID()
            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            Dim dtsqls2 As New dtsetSQLS(dbstring)
            Dim field2 As New List(Of String)
            Dim value2 As New List(Of Object)
            field2.AddRange(New String() {"idsoapnote", "idregistrasi", "transactiontype", "soapnotetype", "soapnoteno", "soapnotedate", "subyektif", "obyektif", "asesmen", "planning", "createdby", "createddate", "idparamediscreator", "idspesialiscreator", "paramediscreatortype"})

            value2.AddRange(New Object() {iddso, idselect, idtransselectso, 1, teNoSOAP.Text, nowTime, meCC.Text, meObjektif.Text, "Diagnosa Kerja:" & vbCrLf & meDiagnosaKerja.Text & vbCrLf & "Diagnosa Banding:" & vbCrLf & meDiagnosaBanding.Text, mePlanning.Text, userid, nowTime, idparru, idspru, 8})
            cek = dtsqls2.datasetSave("soapnote", iddso, field2, value2, False)
            'sqls.DMLQuery("select idsoapnote from soapnote where hashcode='" & strguid & "'", "getidso")
            'iddso = cstr(sqls.getDataSet("getidso", 0, "idsoapnote"))

            Dim friwayat2 As New List(Of String)
            Dim vriwayat2 As New List(Of Object)
            friwayat2.AddRange(New String() {"idriwayatpasien", "idreff", "tablereff", "idreff2", "tablereff2", "riwayattype", "isriwayat", "riwayat", "riwayatalergitype", "remarks", "reaksi", "dosis", "durasi", "isdeleted", "deletereason", "createdby", "createddate", "idcompany"})
            If meSekarang.Lines.Count > 0 Then
                sqls.DMLQuery("update riwayatpasien set isdeleted=1,updatedby='" & userid & "',updateddate=getdate() where riwayattype=1 and riwayatalergitype=0 and tablereff2='REGISTRASI' and idreff2='" & idreg & "' and tablereff='PASIEN' and idreff='" & teNoRM.Tag & "'", False)
                For i As Integer = 0 To meSekarang.Lines.Count - 1
                    Dim dtsqls3 = New dtsetSQLS(dbstring)
                    Dim idriwayatpasien As String = GenerateGUID()

                    vriwayat2.Clear()
                    vriwayat2.AddRange(New Object() {idriwayatpasien, teNoRM.Tag, "PASIEN", idreg, "REGISTRASI", 1, 0, meSekarang.Lines(i).ToString, 0, "-", "", 0, 0, 0, "-", userid, nowTime, idcomp})
                    cek = dtsqls3.datasetSave("riwayatpasien", idriwayatpasien, friwayat2, vriwayat2, False)
                Next
            End If
            If meDahulu.Lines.Count > 0 Then
                sqls.DMLQuery("update riwayatpasien set isdeleted=1,updatedby='" & userid & "',updateddate=getdate() where riwayattype=2 and riwayatalergitype=0 and tablereff2='REGISTRASI' and idreff2='" & idreg & "' and tablereff='PASIEN' and idreff='" & teNoRM.Tag & "'", False)
                For i As Integer = 0 To meDahulu.Lines.Count - 1
                    Dim dtsqls3 = New dtsetSQLS(dbstring)
                    Dim idriwayatpasien As String = GenerateGUID()

                    vriwayat2.Clear()
                    vriwayat2.AddRange(New Object() {idriwayatpasien, teNoRM.Tag, "PASIEN", idreg, "REGISTRASI", 2, 0, meDahulu.Lines(i).ToString, 0, "-", "", 0, 0, 0, "-", userid, nowTime, idcomp})
                    cek = dtsqls3.datasetSave("riwayatpasien", idriwayatpasien, friwayat2, vriwayat2, False)
                Next
            End If
            If meObat.Lines.Count > 0 Then
                sqls.DMLQuery("update riwayatpasien set isdeleted=1,updatedby='" & userid & "',updateddate=getdate() where riwayattype=3 and riwayatalergitype=0 and tablereff2='REGISTRASI' and idreff2='" & idreg & "' and tablereff='PASIEN' and idreff='" & teNoRM.Tag & "'", False)
                For i As Integer = 0 To meObat.Lines.Count - 1
                    Dim dtsqls3 = New dtsetSQLS(dbstring)
                    Dim idriwayatpasien As String = GenerateGUID()

                    vriwayat2.Clear()
                    vriwayat2.AddRange(New Object() {idriwayatpasien, teNoRM.Tag, "PASIEN", idreg, "REGISTRASI", 3, 0, meObat.Lines(i).ToString, 0, "-", "", 0, 0, 0, "-", userid, nowTime, idcomp})
                    cek = dtsqls3.datasetSave("riwayatpasien", idriwayatpasien, friwayat2, vriwayat2, False)
                Next
            End If
            cek = prosesSimpanIMG(idreg)
        End If

        If cek = True Then
            'dizMsgbox("SOAP Note telah tersimpan", dizMsgboxStyle.Info, Me)
        End If
        Return cek
    End Function

    Private Function prosesSimpanIMG(idregistrasi As String) As Boolean
        Dim retval As Boolean = False
        Dim imgMemoryStream As IO.MemoryStream = New IO.MemoryStream()
        Dim imgByteArray As Byte() = Nothing
        Dim img As Image = peAnatomi.Image
        Dim mysqls As New SQLs(dbstring)
        Dim tglskrg As Date = nowTime

        img.Save(imgMemoryStream, System.Drawing.Imaging.ImageFormat.Png)
        imgByteArray = imgMemoryStream.GetBuffer()
        Dim idimages As String = GenerateGUID()
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        field.AddRange(New String() {"idimages", "datetime", "filename", "sizewidth", "sizeheight", "images"})
        value.AddRange(New Object() {idimages, nowTime, "Anatomi" & idregistrasi & Format(tglskrg, "MMddyyyyHHmmss") & ".png", img.Size.Width, img.Size.Height, imgByteArray})
        dtsql.datasetSave("sys_images", idimages, field, value, False)

        dtsql = New dtsetSQLS(dbstring)
        field.Clear()
        value.Clear()

        Dim idanatomi As String = GenerateGUID()
        field.AddRange(New String() {"idanatomi", "idregistrasi", "idimages", "createdby"})
        value.AddRange(New Object() {idanatomi, idregistrasi, idimages, userid})
        retval = dtsql.datasetSave("anatomi", idanatomi, field, value, False)
        If retval = True Then
            mysqls.DMLQuery("update anatomi set isdeleted=1 where idimages<>'" & idimages & "' and idregistrasi='" & idregistrasi & "'", False)
        End If
        Return retval
    End Function

    Private Sub btnAnatomi_Click(sender As Object, e As EventArgs) Handles btnAnatomi.Click
        If imgAnatomi Is Nothing Then
            dizMsgbox("Belum memilih registrasi", dizMsgboxStyle.Info, "Belum memilih", Me)
            Exit Sub
        End If
        pAnatomi.Visible = True
        pAnatomi.BringToFront()
        tlpForm.Enabled = False
    End Sub

    Private Sub btnAnatomiExit_Click(sender As Object, e As EventArgs) Handles btnAnatomiExit.Click
        pAnatomi.SendToBack()
        pAnatomi.Visible = False
        tlpForm.Enabled = True
    End Sub

    Private Sub btnSimpanPENUNJANG_Click(sender As Object, e As EventArgs) Handles btnSimpanPENUNJANG.Click
        prosesSimpanPENUNJANG()
    End Sub

    Private Sub btnCetakPENUNJANG_Click(sender As Object, e As EventArgs) Handles btnCetakPENUNJANG.Click
        If prosesSimpanPENUNJANG() = True Then
            cetakBerkasAMIGD(iddas, iddas)
        End If
    End Sub

    Private Function prosesSimpanPENUNJANG() As Boolean
        Dim cek As Boolean = True
        If modCore.checkEntry(tlppPenunjang) = False Then
            dizMsgbox("Penunjang belum benar", dizMsgboxStyle.Peringatan, Me)
            cek = False
        End If

        If cek = True Then
            Dim idpenunjang As String
            Dim field2 As New List(Of String)
            field2.AddRange(New String() {"idpemeriksaanpenunjang", "idregistrasi", "penunjangtype", "hasilpemeriksaan", "isdeleted", "deletereason", "createdby", "createddate"})

            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("update pemeriksaanpenunjang set isdeleted=1,updatedby='" & userid & "',updateddate=getdate() where penunjangtype=1 and idregistrasi='" & idselect & "'", False)
            sqls.DMLQuery("update pemeriksaanpenunjang set isdeleted=1,updatedby='" & userid & "',updateddate=getdate()  where penunjangtype=2 and idregistrasi='" & idselect & "'", False)
            sqls.DMLQuery("update pemeriksaanpenunjang set isdeleted=1,updatedby='" & userid & "',updateddate=getdate()  where penunjangtype=3 and idregistrasi='" & idselect & "'", False)

            idpenunjang = GenerateGUID()
            Dim dtsqls2 As New dtsetSQLS(dbstring)
            Dim value2 As New List(Of Object)
            value2.AddRange(New Object() {idpenunjang, idselect, 1, meEKG.Text, 0, "-", userid, nowTime})
            cek = dtsqls2.datasetSave("pemeriksaanpenunjang", idpenunjang, field2, value2, False)
            meEKG.Tag = idpenunjang

            idpenunjang = GenerateGUID()
            dtsqls2 = New dtsetSQLS(dbstring)
            value2 = New List(Of Object)
            value2.AddRange(New Object() {idpenunjang, idselect, 2, meLAB.Text, 0, "-", userid, nowTime})
            cek = dtsqls2.datasetSave("pemeriksaanpenunjang", idpenunjang, field2, value2, False)
            meLAB.Tag = idpenunjang

            idpenunjang = GenerateGUID()
            dtsqls2 = New dtsetSQLS(dbstring)
            value2 = New List(Of Object)
            value2.AddRange(New Object() {idpenunjang, idselect, 3, meRAD.Text, 0, "-", userid, nowTime})
            cek = dtsqls2.datasetSave("pemeriksaanpenunjang", idpenunjang, field2, value2, False)
            meRAD.Tag = idpenunjang
        End If
        If cek = True Then
            'dizMsgbox("Penunjang telah tersimpan", dizMsgboxStyle.Info, Me)
        End If
        Return cek
    End Function

    Private Sub btnAllDPJP_Click(sender As Object, e As EventArgs) Handles btnAllDPJP.Click
        If btnAllDPJP.Text = "SEMUA DPJP" Then
            showDPJP(idselect, 1)
            btnAllDPJP.Text = "DPJP AKTIF"
        Else
            showDPJP(idselect, 0)
            btnAllDPJP.Text = "SEMUA DPJP"
        End If
    End Sub

    Private iddpjp As String = "-1"
    Private Sub btnSimpanDPJP_Click(sender As Object, e As EventArgs) Handles btnSimpanDPJP.Click
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
        If meAdvis.Text = "" Then
            cek = False
        End If
        If cek = False Then
            dizMsgbox("Isian DPJP belum benar", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        If iddpjp = "-1" Then
            Dim pair As KeyValuePair(Of String, String) = generateno2(idunitselect, iddeptselect, "SOAPMedis", False)
            idtransselectso = pair.Key
            teNoSOAP.Text = pair.Value
            'btnBaruDiagnosaKerja.Enabled = False
        End If

        iddpjp = GenerateGUID()
        Dim dtsqls2 As New dtsetSQLS(dbstring)
        Dim field2 As New List(Of String)
        Dim value2 As New List(Of Object)
        field2.AddRange(New String() {"idsoapnote", "idregistrasi", "transactiontype", "soapnotetype", "soapnoteno", "soapnotedate", "subyektif", "obyektif", "asesmen", "planning", "createdby", "createddate", "idparamediscreator", "idspesialiscreator", "paramediscreatortype"})
        value2.AddRange(New Object() {iddpjp, idselect, idtransselectso, 2, teNoSOAP.Text, nowTime, "", "", "", meAdvis.Text, userid, nowTime, lueParamedis.EditValue, If(lueSpesialis.EditValue, 0), lueSebagai.EditValue})
        Dim cekb As Boolean = dtsqls2.datasetSave("soapnote", iddso, field2, value2, False)

        'Dim dts As New dtsetSQLS(dbstring)
        'Dim field As New List(Of String)
        'Dim value As New List(Of Object)
        'field.AddRange(New String() {"idregistrasidpjp", "idregistrasi", "idparamedis", "idspesialis", "dpjptype", "remarks", "createdby", "idcompany"})
        'value.AddRange(New Object() {iddpjp, idselect, lueParamedis.EditValue, If(lueSpesialis.EditValue, 0), lueSebagai.EditValue, meAdvis.Text, userid, idcomp})
        'Dim cekb As Boolean = dts.datasetSave("registrasidpjp", iddpjp, field, value, False)

        If cekb = True Then
            dizMsgbox("DPJP telah tersimpan", dizMsgboxStyle.Info, Me)
            dpjpbaru()
        End If

        If btnAllDPJP.Text = "SEMUA DPJP" Then
            showDPJP(idselect, 0)
        Else
            showDPJP(idselect, 1)
        End If
    End Sub

    Private Sub dpjpbaru()
        lueParamedis.EditValue = Nothing
        lueSpesialis.EditValue = Nothing
        lueSebagai.EditValue = Nothing
        meAdvis.Text = ""
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

    Private _anatomi As anatomiType

    Private Enum anatomiType
        ZZ = 0
        A = 1
        B = 2
        C = 3
        CF = 4
        D = 5
        H = 6
        N = 7
        OF1 = 8
        U = 9
        V = 10
        ST = 11
        SD = 12
        OE = 13
        CR = 14
        W = 15
        Int = 99
    End Enum

    Private Sub btnAnatomiTools_Click(sender As Object, e As EventArgs) Handles btnAnatomiA.Click, btnAnatomiC.Click, btnAnatomiCF.Click, btnAnatomiD.Click, btnAnatomiH.Click, btnAnatomiN.Click, btnAnatomiOF.Click, btnAnatomiU.Click, btnAnatomiV.Click, btnAnatomi.Click, btnAnatomiB.Click, btnAnatomiST.Click, btnAnatomiSD.Click, btnAnatomiOE.Click, btnAnatomiCR.Click, btnAnatomiW.Click, btnNumbering.Click
        For Each btn As Button In tlpAnatomiTools.Controls
            btn.BackColor = Color.FromArgb(224, 224, 224)
        Next
        btnNumbering.BackColor = Color.FromArgb(224, 224, 224)
        CType(sender, Button).BackColor = Color.Gray
        If CType(sender, Button) Is btnAnatomiB Then
            _anatomi = anatomiType.B
        ElseIf CType(sender, Button) Is btnAnatomiA Then
            _anatomi = anatomiType.A
        ElseIf CType(sender, Button) Is btnAnatomiC Then
            _anatomi = anatomiType.C
        ElseIf CType(sender, Button) Is btnAnatomiCF Then
            _anatomi = anatomiType.CF
        ElseIf CType(sender, Button) Is btnAnatomiD Then
            _anatomi = anatomiType.D
        ElseIf CType(sender, Button) Is btnAnatomiH Then
            _anatomi = anatomiType.H
        ElseIf CType(sender, Button) Is btnAnatomiN Then
            _anatomi = anatomiType.N
        ElseIf CType(sender, Button) Is btnAnatomiOF Then
            _anatomi = anatomiType.OF1
        ElseIf CType(sender, Button) Is btnAnatomiU Then
            _anatomi = anatomiType.U
        ElseIf CType(sender, Button) Is btnAnatomiV Then
            _anatomi = anatomiType.V
        ElseIf CType(sender, Button) Is btnAnatomiST Then
            _anatomi = anatomiType.ST
        ElseIf CType(sender, Button) Is btnAnatomiSD Then
            _anatomi = anatomiType.SD
        ElseIf CType(sender, Button) Is btnAnatomiOE Then
            _anatomi = anatomiType.OE
        ElseIf CType(sender, Button) Is btnAnatomiCR Then
            _anatomi = anatomiType.CR
        ElseIf CType(sender, Button) Is btnAnatomiW Then
            _anatomi = anatomiType.W
        ElseIf CType(sender, Button) Is btnNumbering Then
            _anatomi = anatomiType.Int
        End If
    End Sub

    Private Sub frmAMIGD201801_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Dim pntx As Integer = (Me.Size.Width / 2) - (pAnatomi.Size.Width / 2)
        Dim pnty As Integer = (Me.Size.Height / 2) - (pAnatomi.Size.Height / 2)
        pAnatomi.Location = New Point(pntx, pnty)
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

    Private Sub xtcAsesmen_Click(sender As Object, e As EventArgs) Handles xtcAsesmen.Click
        If xtcAsesmen.SelectedTabPage Is xtpDPJP Then
            btnSimpanASESMEN.Enabled = False
            btnCetakASESMEN.Enabled = False
        Else
            If idselect <> "-1" Then
                btnSimpanASESMEN.Enabled = True
                btnCetakASESMEN.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
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
            showDPJP(idselect, 1)
        Else
            showDPJP(idselect, 0)
        End If
    End Sub

    Enum cu
        preview = 1
        cetak = 2
    End Enum

    Private Sub btnCetakUlang_Click(sender As Object, e As EventArgs) Handles btnCetakUlang.Click
        Dim idasmu As String = "-1"
        Dim idregu As String = "-1"

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select r.idregistrasi,convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as 'Tgl Registrasi',r.registrasino as 'No Registrasi',pm.nama as 'Tenaga Medis',dbo.fformatnorm(rm.rekammedisno) as 'No RM',rm.nama as 'Nama Pasien',jk.generalcode as 'Jenis Kelamin',convert(varchar,rm.tanggallahir,105) as 'Tgl Lahir',dbo.fUmurRegister(rm.tanggallahir,r.registrasidate) as 'Umur',kw.wilayah as 'Kewarganegaraan' from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' left join wilayah kw on rm.kewarganegaraan=kw.idwilayah  left join paramedis pm on r.iddokterruangan=pm.idparamedis where r.registrasistatus=0 and rm.rekammedisno<>0 and r.iddepartment=(select top 1 [value] from sys_appsetting where variable='IDEmergencyDept') order by r.registrasidate desc", "search")
        Dim cari As New frmSearch(sqls.dataSet, "search", "idregistrasi")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim idselectu As String = CStr(cari.GetIDSelectData)

            sqls.DMLQuery("select r.asalpx,r.asalpx2,r.asalrujukan,r.iddokterrujukan,r.idrekammedis,r.iddepartment,r.idunit,r.registrasino,convert(varchar,r.registrasidate,105) + ' '+convert(varchar,r.registrasidate,108) as registrasidate,ha.generalcode as hamil from registrasi r left join sys_generalcode ha on r.ishamil=ha.idgeneral and ha.gctype='ISHAMIL' where r.idregistrasi='" & idselectu & "'", "getidrm")

            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"@idrm"})
            value.AddRange(New Object() {sqls.getDataSet("getidrm", 0, "idrekammedis")})
            sqls.CallSP("spGetPasienRegistrasi", "registrasi", field, value)

            Dim iddeptu As String = sqls.getDataSet("getidrm", 0, "iddepartment")
            Dim idunitu As String = sqls.getDataSet("getidrm", 0, "idunit")

            sqls.DMLQuery("select idtransactiontype,jenistransaksi,formatstring,formatperiode from transactiontype where jenistransaksi like '%AssessmentM%' and iddepartment='" & iddeptu & "' and idunit='" & idunitu & "'", "getidtransas")
            Dim idtranstypeu As String = "-1"
            If sqls.getDataSet("getidtransas") > 0 Then
                idtranstypeu = sqls.getDataSet("getidtransas", 0, "idtransactiontype")
            End If

            sqls.DMLQuery("select idassessment from assessment where idregistrasi='" & idselectu & "' and transactiontype='" & idtranstypeu & "' and isdeleted=0 order by idassessment desc", "getidass")
            If sqls.getDataSet("getidass") > 0 Then
                idregu = idselectu
                idasmu = sqls.getDataSet("getidass", 0, "idassessment")
            End If
            If idasmu = "-1" Then
                dizMsgbox("Belum dilakukan Assessment Medis", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
            Dim selectPrint As New frmPrintSelect()
            tambahChild(selectPrint)
            selectPrint.ShowDialog()

            If selectPrint.getStringPilih = "PREVIEW" Then
                previewBerkasAMIGD(idasmu, idregu, cu.preview)
            ElseIf selectPrint.getStringPilih = "CETAK" Then
                previewBerkasAMIGD(idasmu, idregu, cu.cetak)
            End If
        End If
    End Sub

    Private Sub previewBerkasAMIGD(iddata As String, idreg As String, cetaktype As cu)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@id"})
        value.AddRange(New Object() {iddata})

        Dim field2 As New List(Of String)
        Dim value2 As New List(Of Object)
        field2.AddRange(New String() {"@id"})
        value2.AddRange(New Object() {idreg})

        Dim mys As New SQLs(dbstring)
        mys.CallSP("spAMIGD201801", "asmigd", field, value)

        Dim mysSOAP As New SQLs(dbstring)
        mysSOAP.CallSP("spSN201801", "soap", field2, value2)

        Dim mysAMU As New SQLs(dbstring)
        mysAMU.CallSP("spAMunit", "unit", field, value)

        Dim mysA As New SQLs(dbstring)
        mysA.CallSP("spRiwayatA201801", "a", field2, value2)

        Dim mysS As New SQLs(dbstring)
        mysS.CallSP("spRiwayatS201801", "s", field2, value2)

        Dim mysD As New SQLs(dbstring)
        mysD.CallSP("spRiwayatD201801", "d", field2, value2)

        Dim mysO As New SQLs(dbstring)
        mysO.CallSP("spRiwayatO201801", "o", field2, value2)

        Dim mysSNU As New SQLs(dbstring)
        mysSNU.CallSP("spSNunit", "unit", field2, value2)

        Dim mysAn As New SQLs(dbstring)
        mysAn.CallSP("spAnatomi", "anatomi", field2, value2)

        Dim mysE As New SQLs(dbstring)
        mysE.CallSP("spPenunjangEKG", "ekg", field2, value2)

        Dim mysL As New SQLs(dbstring)
        mysL.CallSP("spPenunjangLAB", "lab", field2, value2)

        Dim mysR As New SQLs(dbstring)
        mysR.CallSP("spPenunjangRAD", "rad", field2, value2)

        Dim mysP As New SQLs(dbstring)
        mysP.CallSP("spRegDPJP", "dpjp", field2, value2)

        Dim rptA As New xrRiwayatA201801
        rptA.RequestParameters = False
        rptA.DataAdapter = mysA.getDataAdapter
        rptA.DataSource = mysA.dataSet
        rptA.DataMember = "a"

        Dim rptS As New xrRiwayatS201801
        rptS.RequestParameters = False
        rptS.DataAdapter = mysS.getDataAdapter
        rptS.DataSource = mysS.dataSet
        rptS.DataMember = "s"

        Dim rptD As New xrRiwayatD201801
        rptD.RequestParameters = False
        rptD.DataAdapter = mysD.getDataAdapter
        rptD.DataSource = mysD.dataSet
        rptD.DataMember = "d"

        Dim rptO As New xrRiwayatO201801
        rptO.RequestParameters = False
        rptO.DataAdapter = mysO.getDataAdapter
        rptO.DataSource = mysO.dataSet
        rptO.DataMember = "o"

        Dim rptAn As New xrAnatomiSQ
        rptAn.RequestParameters = False
        rptAn.DataAdapter = mysAn.getDataAdapter
        rptAn.DataSource = mysAn.dataSet
        rptAn.DataMember = "anatomi"

        Dim rptE As New xrPenunjangE201801
        rptE.RequestParameters = False
        rptE.DataAdapter = mysE.getDataAdapter
        rptE.DataSource = mysE.dataSet
        rptE.DataMember = "ekg"

        Dim rptL As New xrPenunjangL201801
        rptL.RequestParameters = False
        rptL.DataAdapter = mysL.getDataAdapter
        rptL.DataSource = mysL.dataSet
        rptL.DataMember = "lab"

        Dim rptR As New xrPenunjangR201801
        rptR.RequestParameters = False
        rptR.DataAdapter = mysR.getDataAdapter
        rptR.DataSource = mysR.dataSet
        rptR.DataMember = "rad"

        Dim rptDPJP As New xrDPJPIGD201801
        rptDPJP.RequestParameters = False
        rptDPJP.DataAdapter = mysP.getDataAdapter
        rptDPJP.DataSource = mysP.dataSet
        rptDPJP.DataMember = "dpjp"

        Dim rptSOAP As New xrSOAPIncIGD201801
        rptSOAP.subAnatomi.ReportSource = rptAn
        rptSOAP.subEKG.ReportSource = rptE
        rptSOAP.subLAB.ReportSource = rptL
        rptSOAP.subRAD.ReportSource = rptR
        rptSOAP.subSkrg.ReportSource = rptS
        rptSOAP.subDulu.ReportSource = rptD
        rptSOAP.subObat.ReportSource = rptO
        rptSOAP.RequestParameters = False
        rptSOAP.DataAdapter = mysSOAP.getDataAdapter
        rptSOAP.DataSource = mysSOAP.dataSet
        rptSOAP.DataMember = "soap"

        Dim rpt As New xrAMIGD201801
        rpt.subAlergi.ReportSource = rptA
        rpt.subSOAP.ReportSource = rptSOAP
        rpt.subDPJP.ReportSource = rptDPJP
        rpt.RequestParameters = False
        rpt.DataAdapter = mys.getDataAdapter
        rpt.DataSource = mys.dataSet
        rpt.DataMember = "asmigd"
        rpt.DisplayName = "AMIGD201801"
        rpt.Parameters("pID").Value = iddata
        rpt.Parameters("pID").Visible = False
        rpt.Parameters("pNo").Value = iddata
        rpt.Parameters("pID").Visible = False
        rpt.Parameters("pUnit").Value = mysAMU.getDataSet("unit", 0, "unit")
        rpt.Parameters("pUnit").Visible = False
        rpt.Parameters("pNotes").Value = mysSNU.getDataSet("unit", 0, "notes")
        rpt.Parameters("pNotes").Visible = False
        rpt.Parameters("pFooter").Value = "dicetak oleh " & username & " pada " & Format(nowTime, "dd ") & NamaBulan(nowTime.Month) & Format(nowTime, " yyyy HH: mm")
        rpt.Parameters("pFooter").Visible = False
        rpt.ShowPrintMarginsWarning = False

        Dim pt As New DevExpress.XtraReports.UI.ReportPrintTool(rpt)
        pt.Report.CreateDocument(False)
        AddHandler pt.PreviewForm.Load, AddressOf PreviewForm_Load
        If cetaktype = cu.cetak Then
            Dim sharename As String = getPrinter("ASMIGD")
            If sharename <> "" Then
                Try
                    pt.Print(sharename)
                Catch ex As Exception
                    dizMsgbox("Printer tidak ditemukan/tidak ada akses", dizMsgboxStyle.Peringatan)
                End Try
            Else
                dizMsgbox("Printer belum disetting untuk cetak dokumen ini", dizMsgboxStyle.Peringatan, Me)
            End If
        Else
            pt.AutoShowParametersPanel = False
            pt.ShowPreview()
        End If
    End Sub

    Private Sub btnCetakGelang_Click(sender As Object, e As EventArgs) Handles btnCetakGelang.Click
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select r.idregistrasi,convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as 'Tgl Registrasi',r.registrasino as 'No Registrasi',pm.nama as 'Tenaga Medis',dbo.fformatnorm(rm.rekammedisno) as 'No RM',rm.nama as 'Nama Pasien',jk.generalcode as 'Jenis Kelamin',convert(varchar,rm.tanggallahir,105) as 'Tgl Lahir',dbo.fUmurRegister(rm.tanggallahir,r.registrasidate) as 'Umur',kw.wilayah as 'Kewarganegaraan' from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' left join wilayah kw on rm.kewarganegaraan=kw.idwilayah  left join paramedis pm on r.iddokterruangan=pm.idparamedis where (r.registrasistatus=0 and rm.rekammedisno<>0 and r.iddepartment=(select top 1 [value] from sys_appsetting where variable='IDInpatientDept')) or (r.registrasistatus=0 and rm.rekammedisno<>0 and r.isoneday=1 and r.iddepartment=(select top 1 [value] from sys_appsetting where variable='IDEmergencyDept')) order by r.registrasidate desc", "search")
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
            lstdata.Add("REG-" & idregu)
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

    Private Sub lueGayaHidup_EditValueChanged(sender As Object, e As EventArgs) Handles lueGayaHidup.EditValueChanged
        If lueGayaHidup.EditValue Is Nothing Then
            teGayaHidup.Text = "-"
            teGayaHidup.ReadOnly = True
        Else
            If lueGayaHidup.EditValue = 0 Then
                teGayaHidup.Text = "-"
            Else
                teGayaHidup.Text = ""
            End If
            teGayaHidup.ReadOnly = False
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        kosongkanIsian(tlpRegistrasi)
        kosongkanIsian(tlpPasien)
        kosongkanIsian(tlpAlamat)
        kosongkanIsian(tlpTriage)
        kosongkanIsian(tlpTandaVital1)
        kosongkanIsian(tlpTandaVital2)
        kosongkanIsian(tlpTandaVital3)
        kosongkanIsian(tlpLainlain)
        kosongkanIsian(tlppSOAP)
        kosongkanIsian(tlppPenunjang)
        kosongkanIsian(tlppDPJP)
        meDiagnosaKerja.Text = ""
        meDiagnosaKerja.EditValue = Nothing

        If lueAlergi.EditValue Is Nothing Then
            meAlergi.Text = "-"
            meReaksiAlergi.Text = "-"
            meAlergi.Properties.ReadOnly = True
            meReaksiAlergi.Properties.ReadOnly = True
        End If
        If luePengantar.EditValue Is Nothing Then
            tePengantar.Text = "-"
            tePengantar.Properties.ReadOnly = True
        End If
        If luePenyebab.EditValue Is Nothing Then
            tePenyebab.Text = "-"
            tePenyebab.Properties.ReadOnly = True
        End If
        If lueHubungan.EditValue Is Nothing Then
            teHubungan.Text = "-"
            teHubungan.Properties.ReadOnly = True
        End If
        If lueGangguan.EditValue Is Nothing Then
            lueMembahayakan.EditValue = Nothing
            lueMembahayakan.Properties.ReadOnly = True
        End If
        If lueSumberInfo.EditValue Is Nothing Then
            lueHubungan.Properties.DataSource = Nothing
            lueHubungan.EditValue = Nothing
            lueHubungan.Properties.ReadOnly = True
            teHubungan.EditValue = Nothing
            teHubungan.Properties.ReadOnly = False
        End If
        If lueParamedis.EditValue Is Nothing Then
            lueSpesialis.Properties.DataSource = Nothing
            lueSpesialis.EditValue = Nothing
        End If
        If lueAsalPx.EditValue Is Nothing Then
            lblAsalPx2.Text = ""
            lblAsalPx2.Visible = False
            lueAsalPx2.Visible = False
            lblAsalPx3.Text = ""
            lblAsalPx3.Visible = False
            lueAsalPx3.Visible = False
            lblAsalPx4.Text = ""
            lblAsalPx4.Visible = False
            lueAsalPx4.Visible = False
        End If
        If lueSkalaTriage.EditValue Is Nothing Then
            teWaktuTunggu.Text = ""
        End If
        If lueGayaHidup.EditValue Is Nothing Then
            teGayaHidup.Text = "-"
            teGayaHidup.ReadOnly = True
        End If
        For Each btn As Button In tlpAnatomiTools.Controls
            btn.BackColor = Color.FromArgb(224, 224, 224)
        Next
        btnNumbering.BackColor = Color.FromArgb(224, 224, 224)
        _anatomi = anatomiType.ZZ

        teNoRegistrasi.Text = ""
        teNoRegistrasi.Tag = 0
        teNoRM.Tag = 0
        teNoRM.Text = 0
        teTanggalRegistrasi.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        teTanggalAsesmen.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        teTanggalSOAP.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        teGolonganDarah.Tag = ""
        teJenisKelamin.Tag = ""
        teWarganegara.Tag = ""

        btnSearch.Enabled = True
        btnSimpanASESMEN.Enabled = True
        btnCetakASESMEN.Enabled = True
        statData = statusData.Baru

        iddeptselect = 0
        idunitselect = 0
        idselect = "-1"
        noreg = ""

        isoneday = 0
        If isoneday = 0 Then
            btnODS.Text = "ODS / ODC"
            teNoRegistrasi.Text = noreg
        ElseIf isoneday = 1 Then
            btnODS.Text = "REGULER"
            teNoRegistrasi.Text = noreg & " (ODS)"
        End If

        iddas = "-1"
        idtransselectas = 0
        jenistransselectas = ""
        formatstringas = ""
        formatperiodeas = ""

        iddso = "-1"
        'btnBaruDiagnosaKerja.Enabled = False
        idtransselectso = 0
        jenistransselectso = ""
        formatstringso = ""
        formatperiodeso = ""

        teNoAsesmen.Text = "XXXX/IGD/ASM/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
        teNoSOAP.Text = "XXXX/IGD/SOAPM/" & Format(nowTime, "yyyyMMdd") & "/XXXX"

        lblAsalPx2.Visible = False
        lueAsalPx2.Visible = False
        lueAsalPx2.EditValue = Nothing
        lblAsalPx3.Visible = False
        lueAsalPx3.Visible = False
        lueAsalPx3.EditValue = Nothing
        lblAsalPx4.Visible = False
        lueAsalPx4.Visible = False
        lueAsalPx4.EditValue = Nothing

        lueAlergi.EditValue = Nothing
        lueHubungan.EditValue = Nothing
        luePengantar.EditValue = Nothing
        luePenyebab.EditValue = Nothing

        imgAnatomi = Nothing
        peAnatomi.Image = Nothing
        isPoint = False

        tmrCek.Stop()
        tlpAsesmen.Enabled = False
        tlpSOAP.Enabled = False
        tlpPenunjang.Enabled = False
        tlpDPJP.Enabled = False

        btnSearch.Enabled = True
        btnSimpanASESMEN.Enabled = False
        btnCetakASESMEN.Enabled = False
        btnSimpanSOAP.Enabled = False
        btnCetakSOAP.Enabled = False
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
        sqls.DMLQuery("select variable,value from sys_appsetting where variable in('idemergencydept')", "getid")
        Dim rs As New frmRegistrasiUpdate(sqls.getDataSet("getid", 0, "value").ToString)
        tambahChild(rs)
        rs.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        rs.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        rs.StartPosition = FormStartPosition.CenterScreen
        rs.tlpForm.RowCount = 4
        rs.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        rs.ShowDialog(Me)
    End Sub

    Private Sub btnBaruDiagnosaKerja_Click(sender As Object, e As EventArgs) Handles btnBaruDiagnosaKerja.Click
        Dim diagkerja As New frmDiagnosaKerja(iddso, idreg, "IGD")
        tambahChild(diagkerja)
        diagkerja.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        diagkerja.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        diagkerja.StartPosition = FormStartPosition.CenterScreen
        diagkerja.tlpForm.RowCount = 4
        diagkerja.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        diagkerja.ShowDialog(Me)

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select d.idanalisarmdt,d.idicd,d.jenisdiagnosa,jd.generalcode as jnsdiagnosa,i.icdtype,i.kode,i.diagnosa,d.remarks,d.isdeleted,del.generalcode as statdata,it.generalcode as jenisicd from analisarmdt d left join icd i on d.idicd=i.idicd left join sys_generalcode del on d.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode it on i.icdtype=it.idgeneral and it.gctype='ICDTYPE' left join sys_generalcode jd on d.jenisdiagnosa=jd.idgeneral and jd.gctype='JENISDIAGNOSA' where d.analisarmtype=1 and d.isdeleted=0 and d.idregistrasi='" & idreg & "' order by d.jenisdiagnosa asc,d.createddate desc", "getdiagnosa")
        If sqls.getDataSet("getdiagnosa") > 0 Then
            Me.meDiagnosaKerja.Text = ""
            For i As Integer = 0 To sqls.getDataSet("getdiagnosa") - 1
                If sqls.getDataSet("getdiagnosa", i, "remarks") = "-" Then
                    meDiagnosaKerja.Text &= sqls.getDataSet("getdiagnosa", i, "diagnosa")
                Else
                    meDiagnosaKerja.Text &= sqls.getDataSet("getdiagnosa", i, "diagnosa") & " - " & sqls.getDataSet("getdiagnosa", i, "remarks")
                End If
                If i < sqls.getDataSet("getdiagnosa") - 1 Then
                    meDiagnosaKerja.Text &= vbCrLf
                End If
            Next
        Else
            meDiagnosaKerja.Text = ""
        End If
        diagkerja.Dispose()

        If iddso <> "-1" Then
            Dim dtsqls2 As New dtsetSQLS(dbstring)
            Dim field2 As New List(Of String)
            Dim value2 As New List(Of Object)
            field2.AddRange(New String() {"idsoapnote", "asesmen", "updatedby", "updateddate"})
            value2.AddRange(New Object() {teNoSOAP.Tag, "Diagnosa Kerja:" & vbCrLf & meDiagnosaKerja.Text & vbCrLf & "Diagnosa Banding:" & vbCrLf & meDiagnosaBanding.Text, userid, nowTime})
            dtsqls2.datasetSave("soapnote", teNoSOAP.Tag, field2, value2, False)
        End If
    End Sub

    Private Sub btnMonReg_Click(sender As Object, e As EventArgs) Handles btnMonReg.Click
        formTitle = ""
        Dim rs As New frmMonRegisterIGDday()
        tambahChild(rs)
        rs.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        rs.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        rs.StartPosition = FormStartPosition.CenterScreen
        rs.tlpForm.RowCount = 4
        rs.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        rs.ShowDialog(Me)
    End Sub

    Private Sub btnODS_Click(sender As Object, e As EventArgs) Handles btnODS.Click
        If idselect = "-1" Then
            dizMsgbox("Register belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If isoneday = 0 Then
            isoneday = 1
            btnODS.Text = "REGULER"
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("update registrasi set isoneday=1,updateddate=getdate(),updatedby='" & userid & "' where idregistrasi='" & idreg & "'", False)
            teNoRegistrasi.Text = noreg & " (ODS)"
        ElseIf isoneday = 1 Then
            isoneday = 0
            btnODS.Text = "ODS / ODC"
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("update registrasi set isoneday=0,updateddate=getdate(),updatedby='" & userid & "' where idregistrasi='" & idreg & "'", False)
            teNoRegistrasi.Text = noreg
        End If
    End Sub

    Private Sub gvDPJP_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvDPJP.FocusedRowChanged
        Try
            Dim dcol As DataRow = gvDPJP.GetDataRow(e.FocusedRowHandle)
            lueParamedis.EditValue = dcol("idparamedis")
            lueSpesialis.EditValue = dcol("idspesialis")
            lueSebagai.EditValue = dcol("dpjptype")
            meAdvis.EditValue = dcol("remarks")

            iddpjp = dcol("idsoapnote")

            Dim isdeleted As Integer = dcol("isdeleted")
            If isdeleted = 1 Then
                btnDelete.Text = "AKTIF"
            Else
                btnDelete.Text = "HAPUS"
            End If

            btnSimpanDPJP.Enabled = True
            btnDelete.Enabled = True
        Catch ex As Exception
            dpjpbaru()
        End Try
    End Sub

    Private Sub gvDPJP_FocusedColumnChanged(sender As Object, e As FocusedColumnChangedEventArgs) Handles gvDPJP.FocusedColumnChanged
        If gvDPJP.RowCount = 1 Then
            Try
                Dim dcol As DataRow = gvDPJP.GetDataRow(0)
                lueParamedis.EditValue = dcol("idparamedis")
                lueSpesialis.EditValue = dcol("idspesialis")
                lueSebagai.EditValue = dcol("dpjptype")
                meAdvis.EditValue = dcol("remarks")

                iddpjp = dcol("idregistrasidpjp")

                Dim isdeleted As Integer = dcol("isdeleted")
                If isdeleted = 1 Then
                    btnDelete.Text = "AKTIF"
                Else
                    btnDelete.Text = "HAPUS"
                End If

                btnSimpanDPJP.Enabled = True
                btnDelete.Enabled = True
            Catch ex As Exception
                dpjpbaru()
            End Try
        End If
    End Sub

    Private Sub btnBaruDPJP_Click(sender As Object, e As EventArgs) Handles btnBaruDPJP.Click
        dpjpbaru()
    End Sub

    Private Sub lueCaraMasuk_EditValueChanged(sender As Object, e As EventArgs) Handles lueCaraMasuk.EditValueChanged
        If lueCaraMasuk.EditValue Is Nothing Then
            teCaraMasuk.ReadOnly = True
            teCaraMasuk.EditValue = "-"
            Exit Sub
        End If
        If lueCaraMasuk.EditValue = CLng(5) Then
            teCaraMasuk.ReadOnly = False
            teCaraMasuk.EditValue = "-"
        ElseIf lueCaraMasuk.EditValue <> CLng(5) Then
            teCaraMasuk.ReadOnly = True
            teCaraMasuk.EditValue = "-"
        End If
    End Sub

    Private Sub btnAntrianMin_Click(sender As Object, e As EventArgs) Handles btnAntrianMin.Click
        If btnAntrianMin.Tag = "Max" Then
            gcAntrian.Location = New Point(gcAntrian.Location.X, Me.Size.Height - gcAntrian.Size.Height)
            btnAntrianMin.Tag = "Min"
        Else
            gcAntrian.Location = New Point(gcAntrian.Location.X, Me.Size.Height - ((gcAntrian.Size.Height - tlpAntrian.Size.Height) + lblAntrian.Size.Height - 2))
            btnAntrianMin.Tag = "Max"
        End If
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

End Class