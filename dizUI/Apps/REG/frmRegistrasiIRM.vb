Public Class frmRegistrasiIRM
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

    Private statData As statusData = statusData.Baru
    Private statDataChild As statusData = statusData.Baru
    Private idData As String = "-1"
    Private idDataChild As String = "-1"

    Private Sub loadLOV()
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISHAMIL' order by idgeneral asc", "ishamil")
        lueHamil.Properties.DataSource = mysqls.dataTable("ishamil")
        lueHamil.Properties.DisplayMember = "content"
        lueHamil.Properties.ValueMember = "id"
        If mysqls.getDataSet("ishamil") = 0 Then
            dizMsgbox("Status Pasien Hamil tidak ditemukan" & vbCrLf & "Status Pasien Hamil harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISODS' order by idgeneral asc", "isods")
        lueODS.Properties.DataSource = mysqls.dataTable("isods")
        lueODS.Properties.DisplayMember = "content"
        lueODS.Properties.ValueMember = "id"
        If mysqls.getDataSet("isods") = 0 Then
            dizMsgbox("Status ODC/ODS tidak ditemukan" & vbCrLf & "Status ODC/ODS harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ASALPX' order by idgeneral asc", "asalpx1")
        lueAsalPx.Properties.DataSource = mysqls.dataTable("asalpx1")
        lueAsalPx.Properties.DisplayMember = "content"
        lueAsalPx.Properties.ValueMember = "id"
        If mysqls.getDataSet("asalpx1") = 0 Then
            dizMsgbox("Asal Pasien tidak ditemukan" & vbCrLf & "Asal Pasien harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='PAYERTYPE' order by idgeneral asc", "payertype")
        lueJenisPembayar.Properties.DataSource = mysqls.dataTable("payertype")
        lueJenisPembayar.Properties.DisplayMember = "content"
        lueJenisPembayar.Properties.ValueMember = "id"
        lueAsuransi.Properties.DataSource = Nothing
        If mysqls.getDataSet("payertype") = 0 Then
            dizMsgbox("Jenis Pembayar tidak ditemukan" & vbCrLf & "Jenis Pembayar harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If
    End Sub

    Private isFromLoad As Boolean = True
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        kosongkanIsian(tlpRegistrasi)
        kosongkanIsian(tlpAsal)
        kosongkanIsian(tlpKunjungan)
        kosongkanIsian(tlpPasien)
        kosongkanIsian(tlpAlamat)
        kosongkanIsian(tlpPembayar)

        teNoRegistrasiInduk.Text = ""
        teNoRegistrasiInduk.Tag = ""
        teDeptInduk.Text = ""
        teNoRM.Tag = ""
        teNoRM.Text = 0
        teTanggalPendaftaran.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        teGolonganDarah.Tag = ""
        teJenisKelamin.Tag = ""
        teWarganegara.Tag = ""

        btnNew.Enabled = True
        btnSave.Enabled = True
        btnSavePrint.Enabled = True
        statData = statusData.Baru
        idData = "-1"
        idDataChild = "-1"
        idselect = 0
        idselectparent = 0

        lueAsalPx2.EditValue = Nothing
        lblAsalPx2.Visible = False
        lueAsalPx2.Visible = False
        lueAsalPx3.EditValue = Nothing
        lblAsalPx3.Visible = False
        lueAsalPx3.Visible = False
        lueAsalPx4.EditValue = Nothing
        lblAsalPx4.Visible = False
        lueAsalPx4.Visible = False

        lueRuang.Properties.DataSource = Nothing
        lueRuang.EditValue = Nothing
        lueODS.EditValue = Nothing
        lueODS.Properties.ReadOnly = False
        lueJenisPembayar.EditValue = Nothing
        lueAsuransi.Visible = False
        lblAsuransi.Visible = False
        luePayer.Visible = False
        lblPayer.Visible = False
        teNoAsuransi.Visible = False
        lblNoAsuransi.Visible = False

        If isFromLoad = True Then
            tlpField.Enabled = False
            btnNew.Enabled = True
            btnSave.Enabled = False
            btnSavePrint.Enabled = False
            btnTunggakan.Enabled = False
            btnAppointment.Enabled = True
            btnDataRM.Enabled = True

            lblNoAsuransi.Visible = False
            teNoAsuransi.Visible = False
            teNoRegistrasi.Text = "XXX/XXX/REG/" & Format(nowTime, "yyyyMMdd") & "/XXXX"

            lnkNoRegistrasiInduk.Visible = False
            teNoRegistrasiInduk.Visible = False
            lblDeptInduk.Visible = False
            teDeptInduk.Visible = False

            lnkNoRM.Enabled = True
            lnkTanggalLahir.Enabled = True
            lnkNama.Enabled = True
        Else
            lnkNoRegistrasiInduk.Visible = False
            teNoRegistrasiInduk.Visible = False
            lblDeptInduk.Visible = False
            teDeptInduk.Visible = False

            jenisPelayanan = ""
            teJenisKunjungan.Tag = 0
            teJenisKunjungan.Text = ""
            tlpField.Enabled = False
            Dim selectPelayanan As New clsPelayananSelect("REHABILITASI")

            lnkNoRM.Enabled = True
            lnkTanggalLahir.Enabled = True
            lnkNama.Enabled = True
            lueODS.EditValue = CLng(0)

            If selectPelayanan.getStringPilih = "KONSULTASI" Then
                Dim sqls As New SQLs(dbstring)
                sqls.DMLQuery("select case when isnull(max(convert(bigint,rekammedisno)),0)=0 then 1 else max(convert(bigint,rekammedisno))+1 end as mrn from rekammedis", "lastmrn")
                teNoRM.Text = Format(CLng(sqls.getDataSet("lastmrn", 0, "mrn").ToString.Replace("-", "")), "0#######")
                jenisPelayanan = selectPelayanan.getStringPilih
                teJenisKunjungan.Text = "Konsultasi & Tindakan"
                teJenisKunjungan.Tag = 1

                lueODS.Properties.ReadOnly = False
                lnkNoRegistrasiInduk.Visible = True
                teNoRegistrasiInduk.Visible = True
                lblDeptInduk.Visible = True
                teDeptInduk.Visible = True

                sqls.DMLQuery("select sp.idparamedis as id,p.nama + ' ('+ s.nama + ')' as content from paramedis p left join paramedisspesialis sp on p.idparamedis=sp.idparamedis left join spesialis s on s.idspesialis=sp.idspesialis where p.isservice=1 and p.isdeleted=0 and p.paramedistype in (select idgeneral from sys_generalcode where gctype='paramedistype' and priority in (1,2,3,5)) and p.idparamedis in (select distinct(ps.idparamedis) as idparamedis from paramedisjadwal pj left join paramedisspesialis ps on pj.idparamedisspesialis=ps.idparamedisspesialis where pj.hari like '%" & nowTime.DayOfWeek & "%' and ps.idspesialis not in (select [value] from sys_appsetting where variable in ('IDSPPK','IDSPRad','IDSPKFR'))) and p.isdeleted=0 and s.idspesialis not in (select [value] from sys_appsetting where variable in ('IDSPPK','IDSPRad','IDSPKFR')) order by s.nama,p.nama asc", "listdokter")
                lueParamedis.Properties.DataSource = sqls.dataTable("listdokter")
                lueParamedis.Properties.DisplayMember = "content"
                lueParamedis.Properties.ValueMember = "id"
                lueParamedis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                'lueParamedis.Properties.BestFit()

                sqls.DMLQuery("select idlokasi as id,nama as content from lokasi where lokasitype=3 and iddepartment in (select [value] from sys_appsetting where variable='IDIRJDept') order by nama asc", "jadwallokasi")
                lueRuang.Properties.DataSource = sqls.dataTable("jadwallokasi")
                lueRuang.Properties.DisplayMember = "content"
                lueRuang.Properties.ValueMember = "id"
                lueRuang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                lueRuang.Properties.BestFit()
                lueRuang.EditValue = Nothing
                If sqls.getDataSet("jadwallokasi") = 0 Then
                    dizMsgbox("Lokasi tidak ditemukan" & vbCrLf & "Lokasi harap entry dulu", dizMsgboxStyle.Peringatan, Me)
                    pExit_Click(Me, Nothing)
                    Exit Sub
                End If
                btnTunggakan.Enabled = False
                btnAppointment.Enabled = True
                btnDataRM.Enabled = True
            ElseIf selectPelayanan.getStringPilih = "ODS" Then
                Dim sqls As New SQLs(dbstring)
                sqls.DMLQuery("select case when isnull(max(convert(bigint,rekammedisno)),0)=0 then 1 else max(convert(bigint,rekammedisno))+1 end as mrn from rekammedis", "lastmrn")
                teNoRM.Text = Format(CLng(sqls.getDataSet("lastmrn", 0, "mrn").ToString.Replace("-", "")), "0#######")
                jenisPelayanan = selectPelayanan.getStringPilih
                teJenisKunjungan.Text = "Konsultasi & Tindakan"
                teJenisKunjungan.Tag = 1

                lueODS.Properties.ReadOnly = False
                lnkNoRegistrasiInduk.Visible = True
                teNoRegistrasiInduk.Visible = True
                lblDeptInduk.Visible = True
                teDeptInduk.Visible = True

                sqls.DMLQuery("select sp.idparamedis as id,p.nama + ' ('+ s.nama + ')' as content from paramedis p left join paramedisspesialis sp on p.idparamedis=sp.idparamedis left join spesialis s on s.idspesialis=sp.idspesialis where p.isservice=1 and p.isdeleted=0 and p.paramedistype in (select idgeneral from sys_generalcode where gctype='paramedistype' and priority in (1,2,3,5)) and p.idparamedis in (select distinct(ps.idparamedis) as idparamedis from paramedisjadwal pj left join paramedisspesialis ps on pj.idparamedisspesialis=ps.idparamedisspesialis where pj.hari like '%" & nowTime.DayOfWeek & "%' and ps.idspesialis not in (select [value] from sys_appsetting where variable in ('IDSPPK','IDSPRad','IDSPKFR'))) and p.isdeleted=0 and s.idspesialis not in (select [value] from sys_appsetting where variable in ('IDSPPK','IDSPRad','IDSPKFR')) order by s.nama,p.nama asc", "listdokter")
                lueParamedis.Properties.DataSource = sqls.dataTable("listdokter")
                lueParamedis.Properties.DisplayMember = "content"
                lueParamedis.Properties.ValueMember = "id"
                lueParamedis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                'lueParamedis.Properties.BestFit()

                sqls.DMLQuery("select idlokasi as id,nama as content from lokasi where lokasitype in (3,4) and iddepartment in (select [value] from sys_appsetting where variable='IDODSDept') order by nama asc", "jadwallokasi")
                lueRuang.Properties.DataSource = sqls.dataTable("jadwallokasi")
                lueRuang.Properties.DisplayMember = "content"
                lueRuang.Properties.ValueMember = "id"
                lueRuang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                lueRuang.Properties.BestFit()
                lueRuang.EditValue = Nothing
                If sqls.getDataSet("jadwallokasi") = 0 Then
                    dizMsgbox("Lokasi tidak ditemukan" & vbCrLf & "Lokasi harap entry dulu", dizMsgboxStyle.Peringatan, Me)
                    pExit_Click(Me, Nothing)
                    Exit Sub
                End If
                btnTunggakan.Enabled = False
                btnAppointment.Enabled = True
                btnDataRM.Enabled = True
            ElseIf selectPelayanan.getStringPilih = "REHABILITASI" Then
                Dim sqls As New SQLs(dbstring)
                sqls.DMLQuery("select case when isnull(max(convert(bigint,rekammedisno)),0)=0 then 1 else max(convert(bigint,rekammedisno))+1 end as mrn from rekammedis", "lastmrn")
                teNoRM.Text = Format(CLng(sqls.getDataSet("lastmrn", 0, "mrn").ToString.Replace("-", "")), "0#######")
                jenisPelayanan = selectPelayanan.getStringPilih
                teJenisKunjungan.Text = "Rehabilitasi Medik"
                teJenisKunjungan.Tag = 1

                lueODS.Properties.ReadOnly = True
                lnkNoRegistrasiInduk.Visible = True
                teNoRegistrasiInduk.Visible = True
                lblDeptInduk.Visible = True
                teDeptInduk.Visible = True

                sqls.DMLQuery("select sp.idparamedis as id,p.nama + ' ('+ s.nama + ')' as content from paramedis p left join paramedisspesialis sp on p.idparamedis=sp.idparamedis left join spesialis s on s.idspesialis=sp.idspesialis where p.isservice=1 and p.isdeleted=0 and p.paramedistype>0 and p.idparamedis in (select distinct(ps.idparamedis) as idparamedis from paramedisjadwal pj left join paramedisspesialis ps on pj.idparamedisspesialis=ps.idparamedisspesialis where pj.hari like '%" & nowTime.DayOfWeek & "%' and ps.idspesialis in (select [value] from sys_appsetting where variable in ('IDSPKFR'))) and p.isdeleted=0 and s.idspesialis in (select [value] from sys_appsetting where variable in ('IDSPKFR')) order by s.nama,p.nama asc", "listdokter")
                lueParamedis.Properties.DataSource = sqls.dataTable("listdokter")
                lueParamedis.Properties.DisplayMember = "content"
                lueParamedis.Properties.ValueMember = "id"
                lueParamedis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                'lueParamedis.Properties.BestFit()

                sqls.DMLQuery("select idlokasi as id,nama as content from lokasi where lokasitype=27 and iddepartment in (select [value] from sys_appsetting where variable='idirmdept') order by nama asc", "jadwallokasi")
                lueRuang.Properties.DataSource = sqls.dataTable("jadwallokasi")
                lueRuang.Properties.DisplayMember = "content"
                lueRuang.Properties.ValueMember = "id"
                lueRuang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                lueRuang.Properties.BestFit()
                lueRuang.EditValue = Nothing
                If sqls.getDataSet("jadwallokasi") = 0 Then
                    dizMsgbox("Lokasi tidak ditemukan" & vbCrLf & "Lokasi harap entry dulu", dizMsgboxStyle.Peringatan, Me)
                    pExit_Click(Me, Nothing)
                    Exit Sub
                End If
                btnTunggakan.Enabled = True
                btnAppointment.Enabled = True
                btnDataRM.Enabled = True
            ElseIf selectPelayanan.getStringPilih = "PEMERIKSAAN" Or selectPelayanan.getStringPilih = "PEMERIKSAAN APS" Then
                teNoRM.Text = 0
                jenisPelayanan = selectPelayanan.getStringPilih
                teJenisKunjungan.Text = "Pemeriksaan"
                teJenisKunjungan.Tag = 2

                If selectPelayanan.getStringPilih = "PEMERIKSAAN" Then
                    lueODS.Properties.ReadOnly = True
                    lnkNoRegistrasiInduk.Visible = True
                    teNoRegistrasiInduk.Visible = True
                    lblDeptInduk.Visible = True
                    teDeptInduk.Visible = True

                    btnTunggakan.Enabled = True
                    btnAppointment.Enabled = True
                    btnDataRM.Enabled = True
                ElseIf selectPelayanan.getStringPilih = "PEMERIKSAAN APS" Then
                    lueODS.Properties.ReadOnly = True
                    lnkNoRegistrasiInduk.Visible = False
                    teNoRegistrasiInduk.Visible = False
                    lblDeptInduk.Visible = False
                    teDeptInduk.Visible = False

                    btnTunggakan.Enabled = False
                    btnAppointment.Enabled = True
                    btnDataRM.Enabled = True
                End If

                Dim sqls As New SQLs(dbstring)
                sqls.DMLQuery("select sp.idparamedis as id,p.nama + ' ('+ s.nama + ')' as content from paramedis p left join paramedisspesialis sp on p.idparamedis=sp.idparamedis left join spesialis s on s.idspesialis=sp.idspesialis where p.isservice=1 and p.isdeleted=0 and s.idspesialis in (select [value] from sys_appsetting where variable in ('IDSPPK','IDSPRad')) order by s.nama,p.nama asc", "listdokter")
                lueParamedis.Properties.DataSource = sqls.dataTable("listdokter")
                lueParamedis.Properties.DisplayMember = "content"
                lueParamedis.Properties.ValueMember = "id"
                lueParamedis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                'lueParamedis.Properties.BestFit()

                lueRuang.Properties.DataSource = Nothing
                lueRuang.EditValue = Nothing
            ElseIf selectPelayanan.getStringPilih = "IGD" Or selectPelayanan.getStringPilih = "IGD ELEKTIF" Then
                teNoRM.Text = 0
                jenisPelayanan = selectPelayanan.getStringPilih
                teJenisKunjungan.Text = "Pemeriksaan"
                teJenisKunjungan.Tag = 2

                If selectPelayanan.getStringPilih = "IGD" Then
                    lueODS.Properties.ReadOnly = False
                    lnkNoRegistrasiInduk.Visible = False
                    teNoRegistrasiInduk.Visible = False
                    lblDeptInduk.Visible = False
                    teDeptInduk.Visible = False

                    btnTunggakan.Enabled = True
                    btnAppointment.Enabled = True
                    btnDataRM.Enabled = True
                ElseIf selectPelayanan.getStringPilih = "IGD ELEKTIF" Then
                    lueODS.Properties.ReadOnly = False
                    lnkNoRegistrasiInduk.Visible = False
                    teNoRegistrasiInduk.Visible = False
                    lblDeptInduk.Visible = False
                    teDeptInduk.Visible = False

                    btnTunggakan.Enabled = True
                    btnAppointment.Enabled = True
                    btnDataRM.Enabled = True
                End If

                Dim sqls As New SQLs(dbstring)
                sqls.DMLQuery("select p.idparamedis as id,p.nama as content from paramedis p where p.isservice=1 and p.isdeleted=0 and p.paramedistype=2 order by p.nama asc", "listdokter")
                lueParamedis.Properties.DataSource = sqls.dataTable("listdokter")
                lueParamedis.Properties.DisplayMember = "content"
                lueParamedis.Properties.ValueMember = "id"
                lueParamedis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                'lueParamedis.Properties.BestFit()
            ElseIf selectPelayanan.getStringPilih = "UMUM" Then
                teNoRM.Text = 0
                jenisPelayanan = selectPelayanan.getStringPilih
                teJenisKunjungan.Text = "Pemeriksaan"
                teJenisKunjungan.Tag = 2

                If selectPelayanan.getStringPilih = "UMUM" Then
                    lueODS.Properties.ReadOnly = False
                    lnkNoRegistrasiInduk.Visible = True
                    teNoRegistrasiInduk.Visible = True
                    lblDeptInduk.Visible = True
                    teDeptInduk.Visible = True

                    btnTunggakan.Enabled = True
                    btnAppointment.Enabled = True
                    btnDataRM.Enabled = True
                End If

                Dim sqls As New SQLs(dbstring)
                sqls.DMLQuery("select p.idparamedis as id,p.nama as content from paramedis p where p.isservice=1 and p.isdeleted=0 and p.paramedistype=2 order by p.nama asc", "listdokter")
                lueParamedis.Properties.DataSource = sqls.dataTable("listdokter")
                lueParamedis.Properties.DisplayMember = "content"
                lueParamedis.Properties.ValueMember = "id"
                lueParamedis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                'lueParamedis.Properties.BestFit()

                sqls.DMLQuery("select idlokasi as id,nama as content from lokasi where lokasitype in (3) and iddepartment in (select [value] from sys_appsetting where variable='IDIRJDept') order by nama asc", "jadwallokasi")
                lueRuang.Properties.DataSource = sqls.dataTable("jadwallokasi")
                lueRuang.Properties.DisplayMember = "content"
                lueRuang.Properties.ValueMember = "id"
                lueRuang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                lueRuang.Properties.BestFit()
                lueRuang.EditValue = Nothing
                If sqls.getDataSet("jadwallokasi") = 0 Then
                    dizMsgbox("Lokasi tidak ditemukan" & vbCrLf & "Lokasi harap entry dulu", dizMsgboxStyle.Peringatan, Me)
                    pExit_Click(Me, Nothing)
                    Exit Sub
                End If
            ElseIf selectPelayanan.getStringPilih = "MCU" Then
                teNoRM.Text = 0
                jenisPelayanan = selectPelayanan.getStringPilih
                teJenisKunjungan.Text = "Pemeriksaan"
                teJenisKunjungan.Tag = 2

                If selectPelayanan.getStringPilih = "MCU" Then
                    lueODS.Properties.ReadOnly = True
                    lnkNoRegistrasiInduk.Visible = True
                    teNoRegistrasiInduk.Visible = True
                    lblDeptInduk.Visible = True
                    teDeptInduk.Visible = True

                    btnTunggakan.Enabled = True
                    btnAppointment.Enabled = True
                    btnDataRM.Enabled = True
                End If

                Dim sqls As New SQLs(dbstring)
                sqls.DMLQuery("select p.idparamedis as id,p.nama as content from paramedis p where p.isservice=1 and p.isdeleted=0 and p.paramedistype=2 order by p.nama asc", "listdokter")
                lueParamedis.Properties.DataSource = sqls.dataTable("listdokter")
                lueParamedis.Properties.DisplayMember = "content"
                lueParamedis.Properties.ValueMember = "id"
                lueParamedis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                'lueParamedis.Properties.BestFit()

                sqls.DMLQuery("select idlokasi as id,nama as content from lokasi where lokasitype in (3) and iddepartment in (select [value] from sys_appsetting where variable='IDMCUDept') order by nama asc", "jadwallokasi")
                lueRuang.Properties.DataSource = sqls.dataTable("jadwallokasi")
                lueRuang.Properties.DisplayMember = "content"
                lueRuang.Properties.ValueMember = "id"
                lueRuang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                lueRuang.Properties.BestFit()
                lueRuang.EditValue = Nothing
                If sqls.getDataSet("jadwallokasi") = 0 Then
                    dizMsgbox("Lokasi tidak ditemukan" & vbCrLf & "Lokasi harap entry dulu", dizMsgboxStyle.Peringatan, Me)
                    pExit_Click(Me, Nothing)
                    Exit Sub
                End If
            End If
            If jenisPelayanan <> "" Then
                teNoRegistrasi.Text = "XXX/XXX/REG/" & Format(nowTime, "yyyyMMdd") & "/XXXX"

                tlpField.Enabled = True
                btnNew.Enabled = True
                btnSave.Enabled = True
                btnSavePrint.Enabled = True
            End If
        End If
        isFromLoad = False
    End Sub

    Private jenisPelayanan As String = ""
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        checkFieldMaxLength(dbstring, tlpAsal, "rekammedis")
        checkFieldMaxLength(dbstring, tlpPembayar, "kartu")

        loadLOV()
        btnNew_Click(Me, Nothing)
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

            If lueAsalPx.EditValue = CLng(1) Then
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
            ElseIf lueAsalPx.EditValue = CLng(2) Then
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
        If lueAsalPx.EditValue = CLng(2) Then
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
        If lueAsalPx2.EditValue = CLng(1) Then
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
            If mysqls.getDataSet("asalpx3") = 0 Then
                dizMsgbox("Dokter tidak ditemukan" & vbCrLf & "Dokter harap entry dulu", dizMsgboxStyle.Peringatan, Me)
                pExit_Click(Me, Nothing)
                Exit Sub
            End If
        ElseIf lueAsalPx2.EditValue = CLng(2) Then
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
            If lueAsalPx.EditValue = CLng(1) Then
                If lueAsalPx2.EditValue <> CLng(2) Then
                    lblAsalPx4.Text = ""
                    lblAsalPx4.Visible = False
                    lueAsalPx4.Visible = False
                    lueAsalPx4.EditValue = Nothing
                    lueAsalPx4.Properties.DataSource = Nothing
                ElseIf lueAsalPx2.EditValue = CLng(2) Then
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
                    If mysqls.getDataSet("asalpx4") = 0 Then
                        dizMsgbox("Dokter tidak ditemukan" & vbCrLf & "Dokter harap entry dulu", dizMsgboxStyle.Peringatan, Me)
                        pExit_Click(Me, Nothing)
                        Exit Sub
                    End If
                End If
            End If
        End If
    End Sub

    Private idselect As String = ""
    Private strQuery As String = ""
    Private cnt As Long = 0
    Private cntdept As Long = 0
    Private cntdokter As Long = 0

    Private Sub SearchRM_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkNoRM.LinkClicked, lnkNama.LinkClicked, lnkTanggalLahir.LinkClicked
        If jenisPelayanan = "" Then
            dizMsgbox("Belum memilih Jenis Pelayanan", dizMsgboxStyle.Peringatan, "Jenis Pelayanan", Me)
            Exit Sub
        End If
        If sender Is lnkNama Then
            If teNama.Text.Replace(" ", "") = "" Then
                dizMsgbox("Tidak disarankan melakukan pencarian seluruh Pasien", dizMsgboxStyle.Info, "Info", Me)
                Exit Sub
            End If
        End If

        Dim appPath As String = Application.StartupPath
        If appPath.Chars(appPath.Length - 1) <> "\" Then
            appPath &= "\"
        End If

        strQuery = ""
        Dim tmparr() As String = IO.File.ReadAllLines(appPath & "SearchPasienLengkap.txt")
        For i As Integer = 0 To tmparr.Length - 1
            strQuery &= tmparr(i)
            If tmparr(i).Length > 0 Then
                If tmparr(i).Chars(tmparr(i).Length - 1) <> " " Then
                    strQuery &= " "
                End If
            End If
        Next
        Dim strcek As String = " where isdeleted=0 "
        Dim strfilter As String = ""
        If jenisPelayanan = "KONSULTASI" Then
            If sender.name = "lnkNoRM" Then
                strQuery &= " and r.rekammedisno<>0 and dbo.fFormatNoRM(r.rekammedisno) = '" & teNoRM.Text & "'"
                strcek &= " and r.rekammedisno<>0 and dbo.fFormatNoRM(r.rekammedisno) = '" & teNoRM.Text & "'"
                strfilter = teNoRM.Text '.Replace("-", "").TrimStart(New Char() {"0"})
            ElseIf sender.name = "lnkNama" Then
                strQuery &= " and r.rekammedisno<>0 and r.nama like '%" & teNama.Text & "%'"
                strcek &= " and r.rekammedisno<>0 and r.nama like '%" & teNama.Text & "%'"
                strfilter = teNama.Text
            ElseIf sender.name = "lnkTanggalLahir" Then
                strQuery &= " and r.rekammedisno<>0 and convert(varchar,r.tanggallahir,105) like '%" & Format(CDate(deTanggalLahir.EditValue), "dd-MM-yyyy") & "%'"
                strcek &= " and r.rekammedisno<>0 and convert(varchar,r.tanggallahir,105) like '%" & Format(CDate(deTanggalLahir.EditValue), "dd-MM-yyyy") & "%'"
                strfilter = Format(CDate(deTanggalLahir.EditValue), "dd-MM-yyyy")
            End If
        ElseIf jenisPelayanan = "PEMERIKSAAN" Then
            If sender.name = "lnkNoRM" Then
                strQuery &= " and r.rekammedisno<>0 and dbo.fFormatNoRM(r.rekammedisno) = '" & teNoRM.Text & "'"
                strcek &= " and r.rekammedisno<>0 and dbo.fFormatNoRM(r.rekammedisno) = '" & teNoRM.Text & "'"
                strfilter = teNoRM.Text '.Replace("-", "").TrimStart(New Char() {"0"})
            ElseIf sender.name = "lnkNama" Then
                strQuery &= " and r.rekammedisno<>0 and r.nama like '%" & teNama.Text & "%'"
                strcek &= " and r.rekammedisno<>0 and r.nama like '%" & teNama.Text & "%'"
                strfilter = teNama.Text
            ElseIf sender.name = "lnkTanggalLahir" Then
                strQuery &= " and r.rekammedisno<>0 and convert(varchar,r.tanggallahir,105) like '%" & Format(CDate(deTanggalLahir.EditValue), "dd-MM-yyyy") & "%'"
                strcek &= " and r.rekammedisno<>0 and convert(varchar,r.tanggallahir,105) like '%" & Format(CDate(deTanggalLahir.EditValue), "dd-MM-yyyy") & "%'"
                strfilter = Format(CDate(deTanggalLahir.EditValue), "dd-MM-yyyy")
            End If
        ElseIf jenisPelayanan = "PEMERIKSAAN APS" Then
            If sender.name = "lnkNoRM" Then
                strQuery &= " and r.createddate>=DATEADD(HOUR,-2,GETDATE()) and r.rekammedisno=0"
                strcek &= " and r.createddate>=DATEADD(HOUR,-2,GETDATE()) and r.rekammedisno=0"
                strfilter = teNoRM.Text '.Replace("-", "").TrimStart(New Char() {"0"})
            ElseIf sender.name = "lnkNama" Then
                strQuery &= " and r.createddate>=DATEADD(HOUR,-2,GETDATE()) and r.rekammedisno=0 and r.nama like '%" & teNama.Text & "%'"
                strcek &= " and r.createddate>=DATEADD(HOUR,-2,GETDATE()) and r.rekammedisno=0 and r.nama like '%" & teNama.Text & "%'"
                strfilter = teNama.Text
            ElseIf sender.name = "lnkTanggalLahir" Then
                strQuery &= " and r.createddate>=DATEADD(HOUR,-2,GETDATE()) and r.rekammedisno=0 and convert(varchar,r.tanggallahir,105) like '%" & Format(CDate(deTanggalLahir.EditValue), "dd-MM-yyyy") & "%'"
                strcek &= " and r.createddate>=DATEADD(HOUR,-2,GETDATE()) and r.rekammedisno=0 and convert(varchar,r.tanggallahir,105) like '%" & Format(CDate(deTanggalLahir.EditValue), "dd-MM-yyyy") & "%'"
                strfilter = Format(CDate(deTanggalLahir.EditValue), "dd-MM-yyyy")
            End If
        ElseIf jenisPelayanan = "IGD" Or jenisPelayanan = "IGD ELEKTIF" Then
            If sender.name = "lnkNoRM" Then
                strQuery &= " and r.rekammedisno<>0 and dbo.fFormatNoRM(r.rekammedisno) = '" & teNoRM.Text & "'"
                strcek &= " and r.rekammedisno<>0 and dbo.fFormatNoRM(r.rekammedisno) = '" & teNoRM.Text & "'"
                strfilter = teNoRM.Text '.Replace("-", "").TrimStart(New Char() {"0"})
            ElseIf sender.name = "lnkNama" Then
                strQuery &= " and ((r.rekammedisno<>0 and r.nama like '%" & teNama.Text & "%') or (r.createddate>=DATEADD(HOUR,-2,GETDATE()) and r.rekammedisno=0 and r.nama like '%" & teNama.Text & "%'))"
                strcek &= " and ((r.rekammedisno<>0 and r.nama like '%" & teNama.Text & "%') or (r.createddate>=DATEADD(HOUR,-2,GETDATE()) and r.rekammedisno=0 and r.nama like '%" & teNama.Text & "%'))"
                strfilter = teNama.Text
            ElseIf sender.name = "lnkTanggalLahir" Then
                strQuery &= " and ((r.rekammedisno<>0 and convert(varchar,r.tanggallahir,105) like '%" & Format(CDate(deTanggalLahir.EditValue), "dd-MM-yyyy") & "%') or (r.createddate>=DATEADD(HOUR,-2,GETDATE()) and r.rekammedisno=0 and convert(varchar,r.tanggallahir,105) like '%" & Format(CDate(deTanggalLahir.EditValue), "dd-MM-yyyy") & "%'))"
                strcek &= " and ((r.rekammedisno<>0 and convert(varchar,r.tanggallahir,105) like '%" & Format(CDate(deTanggalLahir.EditValue), "dd-MM-yyyy") & "%') or (r.createddate>=DATEADD(HOUR,-2,GETDATE()) and r.rekammedisno=0 and convert(varchar,r.tanggallahir,105) like '%" & Format(CDate(deTanggalLahir.EditValue), "dd-MM-yyyy") & "%'))"
                strfilter = Format(CDate(deTanggalLahir.EditValue), "dd-MM-yyyy")
            End If
        ElseIf jenisPelayanan = "UMUM" Then
            If sender.name = "lnkNoRM" Then
                strQuery &= " and r.rekammedisno<>0 and dbo.fFormatNoRM(r.rekammedisno) = '" & teNoRM.Text & "'"
                strcek &= " and r.rekammedisno<>0 and dbo.fFormatNoRM(r.rekammedisno) = '" & teNoRM.Text & "'"
                strfilter = teNoRM.Text '.Replace("-", "").TrimStart(New Char() {"0"})
            ElseIf sender.name = "lnkNama" Then
                strQuery &= " and r.rekammedisno<>0 and r.nama like '%" & teNama.Text & "%'"
                strcek &= " and r.rekammedisno<>0 and r.nama like '%" & teNama.Text & "%'"
                strfilter = teNama.Text
            ElseIf sender.name = "lnkTanggalLahir" Then
                strQuery &= " and r.rekammedisno<>0 and convert(varchar,r.tanggallahir,105) like '%" & Format(CDate(deTanggalLahir.EditValue), "dd-MM-yyyy") & "%'"
                strcek &= " and r.rekammedisno<>0 and convert(varchar,r.tanggallahir,105) like '%" & Format(CDate(deTanggalLahir.EditValue), "dd-MM-yyyy") & "%'"
                strfilter = Format(CDate(deTanggalLahir.EditValue), "dd-MM-yyyy")
            End If
        ElseIf jenisPelayanan = "REHABILITASI" Then
            If sender.name = "lnkNoRM" Then
                strQuery &= " and r.rekammedisno<>0 and dbo.fFormatNoRM(r.rekammedisno) = '" & teNoRM.Text & "'"
                strcek &= " and r.rekammedisno<>0 and dbo.fFormatNoRM(r.rekammedisno) = '" & teNoRM.Text & "'"
                strfilter = teNoRM.Text '.Replace("-", "").TrimStart(New Char() {"0"})
            ElseIf sender.name = "lnkNama" Then
                strQuery &= " and r.rekammedisno<>0 and r.nama like '%" & teNama.Text & "%'"
                strcek &= " and r.rekammedisno<>0 and r.nama like '%" & teNama.Text & "%'"
                strfilter = teNama.Text
            ElseIf sender.name = "lnkTanggalLahir" Then
                strQuery &= " and r.rekammedisno<>0 and convert(varchar,r.tanggallahir,105) like '%" & Format(CDate(deTanggalLahir.EditValue), "dd-MM-yyyy") & "%'"
                strcek &= " and r.rekammedisno<>0 and convert(varchar,r.tanggallahir,105) like '%" & Format(CDate(deTanggalLahir.EditValue), "dd-MM-yyyy") & "%'"
                strfilter = Format(CDate(deTanggalLahir.EditValue), "dd-MM-yyyy")
            End If
        End If
        strQuery &= " order by r.rekammedisno asc"

        'Dim loadScr As New frmLoading()
        'splashClosed = False
        'loadScr.Show(Me)
        'loadScr.BringToFront()
        'Application.DoEvents()
        'Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select r.rekammedisno from rekammedis r " & strcek, "cekdatapx")
        If sqls.getDataSet("cekdatapx") = 0 Then
            dizMsgbox("Data Tidak Ditemukan", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        sqls.DMLQuery(strQuery, "searchpasien")

        'Me.Cursor = Cursors.Default
        'splashClosed = True

        Dim cari As New frmSearch(sqls.dataSet, "searchpasien", "ID")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            idselect = cari.GetIDSelectData

            strQuery = ""
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"@idrm"})
            value.AddRange(New Object() {idselect})
            sqls.CallSP("spGetPasienRegistrasi", "getpasienreg", field, value)

            cnt = 0
            cntdept = 0
            cntdokter = 0
            teNoRM.Tag = idselect
            teNoRM.Text = sqls.getDataSet("getpasienreg", 0, "rekammedisno")
            teJenisKartu.Text = sqls.getDataSet("getpasienreg", 0, "jeniskartu")
            teNomorKartu.Text = sqls.getDataSet("getpasienreg", 0, "nomorkartu")
            lueHamil.EditValue = CLng(0)
            teGolonganDarah.Tag = sqls.getDataSet("getpasienreg", 0, "idgolongandarah")
            teGolonganDarah.Text = sqls.getDataSet("getpasienreg", 0, "golongandarah")
            teRhesus.Text = sqls.getDataSet("getpasienreg", 0, "rhesus")

            teNamaPanggilan.Text = sqls.getDataSet("getpasienreg", 0, "namapanggilan")
            teNama.Text = sqls.getDataSet("getpasienreg", 0, "nama")
            teJenisKelamin.Tag = sqls.getDataSet("getpasienreg", 0, "idjeniskelamin")
            teJenisKelamin.Text = sqls.getDataSet("getpasienreg", 0, "jeniskelamin")
            teWarganegara.Tag = sqls.getDataSet("getpasienreg", 0, "kewarganegaraan")
            teWarganegara.Text = sqls.getDataSet("getpasienreg", 0, "warganegara")
            Dim strtgllahir As String = sqls.getDataSet("getpasienreg", 0, "tanggallahir")
            deTanggalLahir.EditValue = Strdate2Date(strtgllahir)
            teUmur.Text = sqls.getDataSet("getpasienreg", 0, "usia")

            meAlamat.Text = sqls.getDataSet("getpasienreg", 0, "alamat")

            lueAsalPx.EditValue = sqls.getDataSet("getpasienreg", 0, "asalpx")
            lueAsalPx2.EditValue = sqls.getDataSet("getpasienreg", 0, "asalpx2")
            lueAsalPx3.EditValue = sqls.getDataSet("getpasienreg", 0, "asalrujukan")
            lueAsalPx4.EditValue = sqls.getDataSet("getpasienreg", 0, "iddokterrujukan")
        End If
    End Sub

    Private Sub teNoRM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teNoRM.KeyPress
        If teNoRM.Text = "00-00-00-00" Then Exit Sub
        If Asc(e.KeyChar) = 13 Then
            SearchRM_LinkClicked(lnkNoRM, Nothing)
        End If
    End Sub

    Private Sub teNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teNama.KeyPress
        If teNama.Text.Replace(" ", "") = "" Then Exit Sub
        If Asc(e.KeyChar) = 13 Then
            SearchRM_LinkClicked(lnkNama, Nothing)
        End If
    End Sub

    Private Sub Tanggal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles deTanggalLahir.KeyPress
        If Asc(e.KeyChar) = 13 Then
            SearchRM_LinkClicked(lnkTanggalLahir, Nothing)
        End If
    End Sub

    Private Sub lueJenisPembayar_EditValueChanged(sender As Object, e As EventArgs) Handles lueJenisPembayar.EditValueChanged
        If lueJenisPembayar.EditValue Is Nothing Then
            lueAsuransi.Properties.DataSource = Nothing
            lueAsuransi.EditValue = Nothing
            lblAsuransi.Visible = False
            lueAsuransi.Visible = False
            lblNoAsuransi.Visible = False
            teNoAsuransi.Visible = False
            luePayer.Properties.DataSource = Nothing
            luePayer.EditValue = Nothing
            lblPayer.Visible = False
            luePayer.Visible = False
        Else
            If lueJenisPembayar.EditValue = CLng(1) Then
                lueAsuransi.Properties.DataSource = Nothing
                lueAsuransi.EditValue = CLng(0)
                lblAsuransi.Visible = True
                lblAsuransi.Text = "Perusahaan"
                lblNoAsuransi.Visible = False
                teNoAsuransi.Visible = False
                teNoAsuransi.Text = ""
                lblAsuransi.Visible = False
                lueAsuransi.Visible = False
                lblPayer.Visible = True
                luePayer.Visible = True

                Dim mysqls As New SQLs(dbstring)
                mysqls.DMLQuery("select idbusinesspartner as id,nama as content from businesspartner where businesspartnertype=4 order by idbusinesspartner asc", "bp4")
                luePayer.Properties.DataSource = mysqls.dataTable("bp4")
                luePayer.Properties.DisplayMember = "content"
                luePayer.Properties.ValueMember = "id"
                If mysqls.getDataSet("bp4") = 0 Then
                    dizMsgbox("Payer tidak ditemukan" & vbCrLf & "Payer harap entry dulu", dizMsgboxStyle.Peringatan, Me)
                    pExit_Click(Me, Nothing)
                    Exit Sub
                End If
                luePayer.EditValue = Nothing
            ElseIf lueJenisPembayar.EditValue = CLng(2) Then
                lblAsuransi.Visible = True
                lblAsuransi.Text = "Perusahaan"
                lblNoAsuransi.Visible = False
                teNoAsuransi.Visible = False
                teNoAsuransi.Text = ""
                lblAsuransi.Visible = True
                lueAsuransi.Visible = True
                lblPayer.Visible = False
                luePayer.Visible = False

                Dim mysqls As New SQLs(dbstring)
                mysqls.DMLQuery("select idbusinesspartner as id,nama as content from businesspartner where businesspartnertype=6 order by idbusinesspartner asc", "bp6")
                lueAsuransi.Properties.DataSource = mysqls.dataTable("bp6")
                lueAsuransi.Properties.DisplayMember = "content"
                lueAsuransi.Properties.ValueMember = "id"
                If mysqls.getDataSet("bp6") = 0 Then
                    dizMsgbox("Perusahaan tidak ditemukan" & vbCrLf & "Perusahaan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
                    pExit_Click(Me, Nothing)
                    Exit Sub
                End If
                lueAsuransi.EditValue = Nothing

                luePayer.Properties.DataSource = Nothing
                luePayer.EditValue = CLng(0)
            ElseIf lueJenisPembayar.EditValue = CLng(3) Then
                lblAsuransi.Visible = True
                lblAsuransi.Text = "Asuransi"
                lblNoAsuransi.Visible = True
                teNoAsuransi.Visible = True
                teNoAsuransi.Text = ""
                lblAsuransi.Visible = True
                lueAsuransi.Visible = True
                lblPayer.Visible = True
                luePayer.Visible = True

                Dim mysqls As New SQLs(dbstring)
                mysqls.DMLQuery("select idbusinesspartner as id,nama as content from businesspartner where businesspartnertype=3 order by idbusinesspartner asc", "bp3")
                lueAsuransi.Properties.DataSource = mysqls.dataTable("bp3")
                lueAsuransi.Properties.DisplayMember = "content"
                lueAsuransi.Properties.ValueMember = "id"
                If mysqls.getDataSet("bp3") = 0 Then
                    dizMsgbox("Perusahaan tidak ditemukan" & vbCrLf & "Perusahaan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
                    pExit_Click(Me, Nothing)
                    Exit Sub
                End If
                lueAsuransi.EditValue = Nothing

                mysqls.DMLQuery("select idbusinesspartner as id,nama as content from businesspartner where businesspartnertype=4 order by idbusinesspartner asc", "bp4")
                luePayer.Properties.DataSource = mysqls.dataTable("bp4")
                luePayer.Properties.DisplayMember = "content"
                luePayer.Properties.ValueMember = "id"
                If mysqls.getDataSet("bp4") = 0 Then
                    dizMsgbox("Payer tidak ditemukan" & vbCrLf & "Payer harap entry dulu", dizMsgboxStyle.Peringatan, Me)
                    pExit_Click(Me, Nothing)
                    Exit Sub
                End If
                luePayer.EditValue = Nothing
            Else
                lblAsuransi.Visible = False
                lueAsuransi.Visible = False
                lblPayer.Visible = False
                luePayer.Visible = False
                lblNoAsuransi.Visible = False
                teNoAsuransi.Visible = False
                lueAsuransi.Properties.DataSource = Nothing
                lueAsuransi.EditValue = Nothing
                luePayer.Properties.DataSource = Nothing
                luePayer.EditValue = Nothing
            End If
        End If
    End Sub

    Private Sub btnNewPatient_Click(sender As Object, e As EventArgs) Handles btnNewPatient.Click
        formTitle = "Pasien Baru"
        Dim pasienbaru As New frmPasienSimple()
        tambahChild(pasienbaru)
        pasienbaru.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        pasienbaru.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        pasienbaru.StartPosition = FormStartPosition.CenterScreen
        pasienbaru.pMinimize.Enabled = False
        pasienbaru.pMaximize.Enabled = False
        pasienbaru.tlpForm.RowCount = 4
        pasienbaru.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        pasienbaru.ShowDialog(Me)
        formTitle = Me.lblTitle.Text
    End Sub

    Private Sub ceksimpanAppointment(idparam As String, idsp As String, idjs As String, idrm As String, idreg As String)
        Dim idps As String = -1
        Dim idapp As String = -1
        If idsp = "0" Then
            Exit Sub
        End If
        If idjs = "0" Then
            Exit Sub
        End If
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idparamedisspesialis from paramedisspesialis where idparamedis='" & idparam & "' and idspesialis='" & idsp & "'", "getidps")
        If sqls.getDataSet("getidps") > 0 Then
            idps = sqls.getDataSet("getidps", 0, "idparamedisspesialis").ToString
            sqls.DMLQuery("select idappointment from appointment where convert(varchar,bookingdate,105)=convert(varchar,getdate(),105)and idparamedisspesialis='" & idps & "' and idjadwalsesi='" & idjs & "' and idrekammedis='" & idrm & "'", "getidapp")
            If sqls.getDataSet("getidapp") > 0 Then
                idapp = sqls.getDataSet("getidapp", 0, "idappointment").ToString
                sqls.DMLQuery("update appointment set idregistrasi='" & idreg & "',bookingstatus=2,updateddate=getdate(),updatedby='" & userid & "' where idappointment='" & idapp & "'", False)
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If checkEntry() = False Then
            dizMsgbox("Isian belum benar", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        Dim pair As KeyValuePair(Of String, String) = generateno2(idunit, iddept, "Registrasi", False)
        Dim idtrans As String = pair.Key
        teNoRegistrasi.Text = pair.Value

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idregistrasi from registrasi where isdeleted=0 and iddokterruangan='" & lueParamedis.EditValue & "' and idrekammedis='" & teNoRM.Tag & "' and convert(varchar,createddate,105)=convert(varchar,getdate(),105)", "cekregexist")
        If sqls.getDataSet("cekregexist") > 0 Then
            If dizMsgbox("Register aktif ditemukan untuk " & teNoRM.Text & " ke Dokter/Tenaga Medis " & lueParamedis.Text & vbCrLf & "Melanjutkan untuk diregister ulang?", dizMsgboxStyle.Konfirmasi, "Konfirmasi") = dizMsgboxValue.Batal Then
                Exit Sub
            End If
        End If

        sqls.DMLQuery("select count(idregistrasi) as count from registrasi where isdeleted=0 and idrekammedis='" & teNoRM.Tag & "'", "cnt")
        cnt = sqls.getDataSet("cnt", 0, "count")

        If iddept <> "0" Then
            sqls.DMLQuery("select count(idregistrasi) as count from registrasi where isdeleted=0 and iddepartment='" & iddept & "' and idunit='" & idunit & "' and idrekammedis='" & teNoRM.Tag & "'", "cntdept")
            cntdept = sqls.getDataSet("cntdept", 0, "count")
        End If
        If lueParamedis.EditValue IsNot Nothing Then
            sqls.DMLQuery("select count(idregistrasi) as count from registrasi where isdeleted=0 and iddokterruangan='" & lueParamedis.EditValue & "' and idrekammedis='" & teNoRM.Tag & "'", "cntdokter")
            cntdokter = sqls.getDataSet("cntdokter", 0, "count")
        End If

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim remarks As String = "-"
        If jenisPelayanan = "IGD ELEKTIF" Then
            remarks = "IGD ELEKTIF"
        End If

        idData = GenerateGUID()
        If idselectparent = "0" Then
            field.AddRange(New String() {"idregistrasi", "transactiontype", "idjadwalsesi", "idcompany", "iddepartment", "idunit", "idrekammedis", "idlokasi", "idkelas", "iddokterruangan", "idspesialisruangan", "registrasino", "kunjunganke", "kunjungandokterke", "kunjungandepartmentke", "asalpx", "asalpx2", "asalrujukan", "iddokterrujukan", "jeniskunjungan", "registrasistatus", "remarks", "payertype", "idpayer", "idasuransi", "ishamil", "isdeleted", "deletereason", "createdby", "isoneday"})
            value.AddRange(New Object() {idData, idtrans, If(lueSesi.EditValue, 0), idcomp, iddept, idunit, teNoRM.Tag, lueRuang.EditValue, idkelas, lueParamedis.EditValue, If(lueSpesialis.EditValue, 0), teNoRegistrasi.Text, cnt + 1, cntdokter + 1, cntdept + 1, If(lueAsalPx.EditValue, 0), If(lueAsalPx2.EditValue, 0), If(lueAsalPx3.EditValue, 0), If(lueAsalPx4.EditValue, 0), CLng(teJenisKunjungan.Tag), 0, remarks, lueJenisPembayar.EditValue, If(luePayer.EditValue, 0), If(lueAsuransi.EditValue, 0), lueHamil.EditValue, 0, "-", userid, If(lueODS.EditValue, 0)})
        Else
            field.AddRange(New String() {"idregistrasi", "transactiontype", "idjadwalsesi", "idcompany", "idregistrasiparent", "iddepartment", "idunit", "idrekammedis", "idlokasi", "idkelas", "iddokterruangan", "idspesialisruangan", "registrasino", "kunjunganke", "kunjungandokterke", "kunjungandepartmentke", "asalpx", "asalpx2", "asalrujukan", "iddokterrujukan", "jeniskunjungan", "registrasistatus", "remarks", "payertype", "idpayer", "idasuransi", "ishamil", "isdeleted", "deletereason", "createdby", "isoneday"})
            value.AddRange(New Object() {idData, idtrans, If(lueSesi.EditValue, 0), idcomp, teNoRegistrasiInduk.Tag, iddept, idunit, teNoRM.Tag, lueRuang.EditValue, idkelas, lueParamedis.EditValue, If(lueSpesialis.EditValue, 0), teNoRegistrasi.Text, cnt + 1, cntdokter + 1, cntdept + 1, If(lueAsalPx.EditValue, 0), If(lueAsalPx2.EditValue, 0), If(lueAsalPx3.EditValue, 0), If(lueAsalPx4.EditValue, 0), CLng(teJenisKunjungan.Tag), 0, remarks, lueJenisPembayar.EditValue, If(luePayer.EditValue, 0), If(lueAsuransi.EditValue, 0), lueHamil.EditValue, 0, "-", userid, If(lueODS.EditValue, 0)})
        End If
        Dim dtsetsqls As New dtsetSQLS(dbstring)
        Dim cek As Boolean = dtsetsqls.datasetSave("registrasi", idData, field, value, False)
        If cek = True Then
            Dim idtmp As String
            If teNoAsuransi.Visible = True Then
                sqls = New SQLs(dbstring)
                sqls.DMLQuery("select idkartu from kartu where jeniskartu=11 and isdeleted=0 and idreff='" & CStr(teNoRM.Tag) & "' and tablereff='PASIEN' and nomorkartu='" & teNoAsuransi.Text & "'", "cekkartu")
                If sqls.getDataSet("cekkartu") = 0 Then
                    idtmp = GenerateGUID()
                    Dim fkartu As New List(Of String)
                    Dim vkartu As New List(Of Object)
                    fkartu.AddRange(New String() {"idkartu", "idreff", "tablereff", "idpenerbit", "jenispenerbit", "jeniskartu", "nomorkartu", "namakartu", "jenistanggal", "tanggalkartu", "isdeleted", "createdby", "idcompany"})
                    vkartu.AddRange(New Object() {idtmp, teNoRM.Tag, "PASIEN", lueAsuransi.EditValue, "ASURANSI", 11, teNoAsuransi.Text, teNama.Text, 3, nowTime, 0, userid, idcomp})
                    dtsetsqls = New dtsetSQLS(dbstring)
                    sqls.DMLQuery("update kartu set isdeleted=1 where jeniskartu=11 and tablereff='PASIEN' and idreff='" & teNoRM.Tag & "'", False)
                    dtsetsqls.datasetSave("kartu", idtmp, fkartu, vkartu, False)
                End If
            End If
            ceksimpanAppointment(lueParamedis.EditValue, If(lueSpesialis.EditValue, 0), If(lueSesi.EditValue, 0), teNoRM.Tag, idData)
            Dim nodata As String = sqls.getDataSet("getid", 0, "registrasino")
            dizMsgbox("Registrasi telah tersimpan", dizMsgboxStyle.Info, Me)
        End If
        isFromLoad = True
        btnNew_Click(btnNew, Nothing)
    End Sub

    Private Function checkEntry() As Boolean
        Dim retval As Boolean = True
        If lueAsalPx.Visible = True And lueAsalPx.EditValue Is Nothing Then
            retval = False
        End If
        If lueAsalPx2.Visible = True And lueAsalPx2.EditValue Is Nothing Then
            retval = False
        End If
        If lueAsalPx3.Visible = True And lueAsalPx3.EditValue Is Nothing Then
            retval = False
        End If
        If lueAsalPx4.Visible = True And lueAsalPx4.EditValue Is Nothing Then
            retval = False
        End If
        If lueParamedis.EditValue Is Nothing Then
            retval = False
        End If
        If jenisPelayanan <> "IGD" And jenisPelayanan <> "IGD ELEKTIF" And jenisPelayanan <> "UMUM" Then
            If lueSpesialis.EditValue Is Nothing Then
                retval = False
            End If
        End If
        If jenisPelayanan <> "IGD" And jenisPelayanan <> "IGD ELEKTIF" And jenisPelayanan <> "UMUM" Then
            If lueSesi.EditValue Is Nothing Then
                retval = False
            End If
        End If
        If lueRuang.EditValue Is Nothing Then
            retval = False
        End If
        If lueHamil.EditValue Is Nothing Then
            retval = False
        End If
        If teNoRM.Tag.ToString = "" Then
            retval = False
        End If
        If lueJenisPembayar.Visible = True And lueJenisPembayar.EditValue Is Nothing Then
            retval = False
        End If
        If lueAsuransi.Visible = True And lueAsuransi.EditValue Is Nothing Then
            retval = False
        End If
        If luePayer.Visible = True And luePayer.EditValue Is Nothing Then
            retval = False
        End If
        If teNoAsuransi.Visible = True And teNoAsuransi.Text = "" Then
            retval = False
        End If
        Return retval
    End Function

    Private Sub lueParamedis_EditValueChanged(sender As Object, e As EventArgs) Handles lueParamedis.EditValueChanged
        If lueParamedis.EditValue Is Nothing Then
            lueSpesialis.Properties.DataSource = Nothing
            lueSpesialis.EditValue = Nothing
            lueRuang.Properties.DataSource = Nothing
            lueRuang.EditValue = Nothing
            lueSesi.Properties.DataSource = Nothing
            lueSesi.EditValue = Nothing

            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        If teJenisKunjungan.Tag = 1 Then
            sqls.DMLQuery("select s.nama as content,s.idspesialis as id from spesialis s left join paramedisspesialis ps on s.idspesialis=ps.idspesialis where ps.idspesialis not in (select value from sys_appsetting where variable in ('IDSPPK','IDSPRad')) and ps.idparamedis='" & lueParamedis.EditValue & "'", "spesialis")
        Else
            sqls.DMLQuery("select s.nama as content,s.idspesialis as id from spesialis s left join paramedisspesialis ps on s.idspesialis=ps.idspesialis where ps.idspesialis in (select value from sys_appsetting where variable in ('IDSPPK','IDSPRad')) and ps.idparamedis='" & lueParamedis.EditValue & "'", "spesialis")
        End If
        lueSpesialis.Properties.DataSource = sqls.dataTable("spesialis")
        lueSpesialis.Properties.DisplayMember = "content"
        lueSpesialis.Properties.ValueMember = "id"
        lueSpesialis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueSpesialis.Properties.BestFit()
        lueSpesialis.EditValue = Nothing

        If sqls.getDataSet("spesialis") = 1 Then
            lueSpesialis.EditValue = sqls.getDataSet("spesialis", 0, "id")
        End If

        If jenisPelayanan = "IGD" Or jenisPelayanan = "IGD ELEKTIF" Then
            sqls.DMLQuery("select idlokasi as id,nama as content from lokasi where nama = (select case when variable='idigddept' then 'IGD' end as 'department' from sys_appsetting where variable in ('idigddept'))", "jadwallokasi")
            lueRuang.Properties.DataSource = sqls.dataTable("jadwallokasi")
            lueRuang.Properties.DisplayMember = "content"
            lueRuang.Properties.ValueMember = "id"
            lueRuang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            lueRuang.Properties.BestFit()
            lueRuang.EditValue = Nothing
            If sqls.getDataSet("jadwallokasi") = 1 Then
                lueRuang.EditValue = sqls.getDataSet("jadwallokasi", 0, "id")
            End If
            'ElseIf jenisPelayanan = "PEMERIKSAAN" Or jenisPelayanan = "PEMERIKSAAN APS" Then
            '    sqls.DMLQuery("select idlokasi as id,nama as content from lokasi where nama in (select case when variable='IDSPPK' then 'Laboratorium' when variable='IDSPRad' then 'Radiologi' end as 'department' from sys_appsetting where variable in ('IDSPPK','IDSPRad')) and ", "jadwallokasi")
            '    lueRuang.Properties.DataSource = sqls.dataTable("jadwallokasi")
            '    lueRuang.Properties.DisplayMember = "content"
            '    lueRuang.Properties.ValueMember = "id"
            '    lueRuang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            '    lueRuang.Properties.BestFit()
            '    lueRuang.EditValue = Nothing
            '    If sqls.getDataSet("jadwallokasi") = 1 Then
            '        lueRuang.EditValue = sqls.getDataSet("jadwallokasi", 0, "id")
            '    End If
        ElseIf jenisPelayanan = "KONSULTASI" Then
            sqls.DMLQuery("select idlokasi as id,nama as content from lokasi where lokasitype=3 and iddepartment in (select [value] from sys_appsetting where variable='IDIRJDept') order by nama asc", "jadwallokasi")
            lueRuang.Properties.DataSource = sqls.dataTable("jadwallokasi")
            lueRuang.Properties.DisplayMember = "content"
            lueRuang.Properties.ValueMember = "id"
            lueRuang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            lueRuang.Properties.BestFit()
            lueRuang.EditValue = Nothing
            If sqls.getDataSet("jadwallokasi") = 1 Then
                lueRuang.EditValue = sqls.getDataSet("jadwallokasi", 0, "id")
            End If
        End If
    End Sub

    Private Sub lueSpesialis_EditValueChanged(sender As Object, e As EventArgs) Handles lueSpesialis.EditValueChanged
        If lueSpesialis.EditValue Is Nothing Then
            lueRuang.Properties.DataSource = Nothing
            lueRuang.Properties.DisplayMember = "content"
            lueRuang.Properties.ValueMember = "id"
            lueRuang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            lueRuang.Properties.BestFit()
            lueRuang.EditValue = Nothing

            lueSesi.Properties.DataSource = Nothing
            lueSesi.Properties.DisplayMember = "content"
            lueSesi.Properties.ValueMember = "id"
            lueSesi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            lueSesi.Properties.BestFit()
            lueSesi.EditValue = Nothing

            Exit Sub
        End If
        Dim sqls As New SQLs(dbstring)
        If jenisPelayanan = "PEMERIKSAAN" Or jenisPelayanan = "PEMERIKSAAN APS" Then
            sqls.DMLQuery("select idlokasi as id,nama as content from lokasi where nama in (select case when variable='IDSPPK' then 'Laboratorium' when variable='IDSPRad' then 'Radiologi' end as 'department' from sys_appsetting where variable in ('IDSPPK','IDSPRad') and [value]='" & lueSpesialis.EditValue & "')", "jadwallokasi")
            lueRuang.Properties.DataSource = sqls.dataTable("jadwallokasi")
            lueRuang.Properties.DisplayMember = "content"
            lueRuang.Properties.ValueMember = "id"
            lueRuang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            lueRuang.Properties.BestFit()
            lueRuang.EditValue = Nothing
            If sqls.getDataSet("jadwallokasi") = 1 Then
                lueRuang.EditValue = sqls.getDataSet("jadwallokasi", 0, "id")
            End If
        End If

        sqls.DMLQuery("select js.idjadwalsesi as id,js.nama + ' (' + substring(convert(varchar,pj.jammulai,108),0,6)+' - ' + substring(convert(varchar,pj.jamselesai,108),0,6)+')' as content,js.priority from jadwalsesi js left join paramedisjadwal pj on js.idjadwalsesi=pj.idjadwalsesi left join paramedisspesialis ps on pj.idparamedisspesialis=ps.idparamedisspesialis where ps.idparamedis='" & lueParamedis.EditValue & "' and ps.idspesialis='" & lueSpesialis.EditValue & "' and js.isdeleted=0 and pj.isdeleted=0 and pj.hari like '%" & nowTime.DayOfWeek & "%' order by js.priority asc", "sesi")
        lueSesi.Properties.DataSource = sqls.dataTable("sesi")
        lueSesi.Properties.DisplayMember = "content"
        lueSesi.Properties.ValueMember = "id"
        lueSesi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueSesi.Properties.BestFit()
        lueSesi.EditValue = Nothing
        If sqls.getDataSet("sesi") = 1 Then
            lueSesi.EditValue = sqls.getDataSet("sesi", 0, "id")
        End If
    End Sub

    Private idkelas As String = "0"
    Private iddept As String = "0"
    Private kddept As String = ""
    Private idunit As String = "0"
    Private kdunit As String = ""
    Private idtrans As String = "0"
    Private jenistrans As String = ""
    Private formatstring As String = ""
    Private formatperiode As String = ""

    Private Sub teNoAsuransi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teNoAsuransi.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rVarchar) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub lueRuang_EditValueChanged(sender As Object, e As EventArgs) Handles lueRuang.EditValueChanged
        If lueRuang.EditValue Is Nothing Then
            idkelas = "0"
            iddept = "0"
            kddept = ""
            idunit = "0"
            kdunit = ""
            idtrans = "0"
            jenistrans = ""
            formatstring = ""
            formatperiode = ""
            teNoRegistrasi.Text = "XXX/XXX/REG/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
            Exit Sub
        End If
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("Select l.iddepartment,l.idunit,k.idkelas,u.kode As kodeunit,d.kode As kodedept from lokasi l left join unit u On l.idunit=u.idunit left join department d On l.iddepartment=d.iddepartment left join kelaskamar kk On l.idlokasi=kk.idlokasi left join kelas k On kk.idkelas=k.idkelas where l.idlokasi='" & lueRuang.EditValue & "'", "getid")
        If sqls.getDataSet("getid") > 0 Then
            iddept = sqls.getDataSet("getid", 0, "iddepartment")
            idunit = sqls.getDataSet("getid", 0, "idunit")
            idkelas = sqls.getDataSet("getid", 0, "idkelas")

            Dim pair As KeyValuePair(Of String, String) = generateno2(idunit, iddept, "Registrasi", True)
            Dim idtrans As String = pair.Key
            teNoRegistrasi.Text = pair.Value
        End If
    End Sub

    Private Sub btnSavePrint_Click(sender As Object, e As EventArgs) Handles btnSavePrint.Click
        If checkEntry() = False Then
            dizMsgbox("Isian belum benar", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        Dim pair As KeyValuePair(Of String, String) = generateno2(idunit, iddept, "Registrasi", False)
        Dim idtrans As String = pair.Key
        teNoRegistrasi.Text = pair.Value

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idregistrasi from registrasi where isdeleted=0 and iddokterruangan='" & lueParamedis.EditValue & "' and idrekammedis='" & teNoRM.Tag & "' and convert(varchar,createddate,105)=convert(varchar,getdate(),105)", "cekregexist")
        If sqls.getDataSet("cekregexist") > 0 Then
            If dizMsgbox("Register aktif ditemukan untuk " & teNoRM.Text & " ke Dokter/Tenaga Medis " & lueParamedis.Text & vbCrLf & "Melanjutkan untuk diregister ulang?", dizMsgboxStyle.Konfirmasi, "Konfirmasi") = dizMsgboxValue.Batal Then
                Exit Sub
            End If
        End If

        sqls.DMLQuery("select count(idregistrasi) as count from registrasi where registrasistatus<>1 and idrekammedis='" & teNoRM.Tag & "'", "cnt")
        If iddept <> "0" Then
            sqls.DMLQuery("select count(idregistrasi) as count from registrasi where registrasistatus<>1 and iddepartment='" & iddept & "' and idunit='" & idunit & "' and idrekammedis='" & teNoRM.Tag & "'", "cntdept")
            cntdept = sqls.getDataSet("cntdept", 0, "count")
        End If
        If lueParamedis.EditValue IsNot Nothing Then
            sqls.DMLQuery("select count(idregistrasi) as count from registrasi where registrasistatus<>1 and iddokterruangan='" & lueParamedis.EditValue & "' and idrekammedis='" & teNoRM.Tag & "'", "cntdokter")
            cntdokter = sqls.getDataSet("cntdokter", 0, "count")
        End If

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim remarks As String = "-"
        If jenisPelayanan = "IGD ELEKTIF" Then
            remarks = "IGD ELEKTIF"
        End If

        idData = GenerateGUID()
        If idselectparent = "0" Then
            field.AddRange(New String() {"idregistrasi", "transactiontype", "idjadwalsesi", "idcompany", "iddepartment", "idunit", "idrekammedis", "idlokasi", "idkelas", "iddokterruangan", "idspesialisruangan", "registrasino", "kunjunganke", "kunjungandokterke", "kunjungandepartmentke", "asalpx", "asalpx2", "asalrujukan", "iddokterrujukan", "jeniskunjungan", "registrasistatus", "remarks", "payertype", "idpayer", "idasuransi", "ishamil", "isdeleted", "deletereason", "createdby", "isoneday"})
            value.AddRange(New Object() {idData, idtrans, If(lueSesi.EditValue, 0), idcomp, iddept, idunit, teNoRM.Tag, lueRuang.EditValue, idkelas, lueParamedis.EditValue, If(lueSpesialis.EditValue, 0), teNoRegistrasi.Text, cnt + 1, cntdokter + 1, cntdept + 1, If(lueAsalPx.EditValue, 0), If(lueAsalPx2.EditValue, 0), If(lueAsalPx3.EditValue, 0), If(lueAsalPx4.EditValue, 0), CLng(teJenisKunjungan.Tag), 0, remarks, lueJenisPembayar.EditValue, If(luePayer.EditValue, 0), If(lueAsuransi.EditValue, 0), lueHamil.EditValue, 0, "-", userid, If(lueODS.EditValue, 0)})
        Else
            field.AddRange(New String() {"idregistrasi", "transactiontype", "idjadwalsesi", "idcompany", "idregistrasiparent", "iddepartment", "idunit", "idrekammedis", "idlokasi", "idkelas", "iddokterruangan", "idspesialisruangan", "registrasino", "kunjunganke", "kunjungandokterke", "kunjungandepartmentke", "asalpx", "asalpx2", "asalrujukan", "iddokterrujukan", "jeniskunjungan", "registrasistatus", "remarks", "payertype", "idpayer", "idasuransi", "ishamil", "isdeleted", "deletereason", "createdby", "isoneday"})
            value.AddRange(New Object() {idData, idtrans, If(lueSesi.EditValue, 0), idcomp, CStr(teNoRegistrasiInduk.Tag), iddept, idunit, teNoRM.Tag, lueRuang.EditValue, idkelas, lueParamedis.EditValue, If(lueSpesialis.EditValue, 0), teNoRegistrasi.Text, cnt + 1, cntdokter + 1, cntdept + 1, If(lueAsalPx.EditValue, 0), If(lueAsalPx2.EditValue, 0), If(lueAsalPx3.EditValue, 0), If(lueAsalPx4.EditValue, 0), CLng(teJenisKunjungan.Tag), 0, remarks, lueJenisPembayar.EditValue, If(luePayer.EditValue, 0), If(lueAsuransi.EditValue, 0), lueHamil.EditValue, 0, "-", userid, If(lueODS.EditValue, 0)})
        End If
        Dim dtsetsqls As New dtsetSQLS(dbstring)
        Dim cek As Boolean = dtsetsqls.datasetSave("registrasi", idData, field, value, False)
        If cek = True Then
            Dim idtmp As String
            If teNoAsuransi.Visible = True Then
                sqls = New SQLs(dbstring)
                sqls.DMLQuery("select idkartu from kartu where jeniskartu=11 and isdeleted=0 and idreff='" & CStr(teNoRM.Tag) & "' and tablereff='PASIEN' and nomorkartu='" & teNoAsuransi.Text & "'", "cekkartu")
                If sqls.getDataSet("cekkartu") = 0 Then
                    idtmp = GenerateGUID()
                    Dim fkartu As New List(Of String)
                    Dim vkartu As New List(Of Object)
                    fkartu.AddRange(New String() {"idkartu", "idreff", "tablereff", "idpenerbit", "jenispenerbit", "jeniskartu", "nomorkartu", "namakartu", "jenistanggal", "tanggalkartu", "isdeleted", "createdby", "idcompany"})
                    vkartu.AddRange(New Object() {idtmp, teNoRM.Tag, "PASIEN", lueAsuransi.EditValue, "ASURANSI", 11, teNoAsuransi.Text, teNama.Text, 3, nowTime, 0, userid, idcomp})
                    dtsetsqls = New dtsetSQLS(dbstring)
                    sqls.DMLQuery("update kartu set isdeleted=1 where jeniskartu=11 and tablereff='PASIEN' and idreff='" & teNoRM.Tag & "'", False)
                    dtsetsqls.datasetSave("kartu", idtmp, fkartu, vkartu, False)
                End If
            End If
            Dim nodata As String = sqls.getDataSet("getid", 0, "registrasino")
            Dim regdate As String = sqls.getDataSet("getid", 0, "registrasidate")

            Dim prntname As String = ""
            'Dim sd As New frmSelectDevice
            'tambahChild(sd)
            'If sd.ShowDialog() = DialogResult.OK Then
            'prntname = sd.getdevicename
            cetakBerkas(idData, cu.cetak, prntname)
            'End If

            'Dim lstdata As New List(Of String)
            'lstdata.Add(teNama.Text & " ( " & teJenisKelamin.Text & " )")
            'lstdata.Add("No. RM " & teNoRM.Text)
            'lstdata.Add("Tgl. Lahir " & CDate(deTanggalLahir.EditValue).Day & " " & NamaBulan(CDate(deTanggalLahir.EditValue).Month) & " " & CDate(deTanggalLahir.EditValue).Year)
            'lstdata.Add(nodata)
            'lstdata.Add("Umur " & teUmur.Text)
            'lstdata.Add(regdate)
            'cetakWristband(lstdata)
            dizMsgbox("Registrasi telah tersimpan", dizMsgboxStyle.Info, Me)
        End If
        isFromLoad = True
        btnNew_Click(btnNew, Nothing)
    End Sub

    Private Sub cetakBerkas(iddata As String, cetaktype As cu, Optional printername As String = "")
        Dim mys As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@idreg"})
        value.AddRange(New Object() {iddata})
        mys.CallSP("spRegistrasiSlip", "regslip", field, value)

        Dim rpt As New xrRegistrasiSlip081201
        rpt.RequestParameters = False
        rpt.DataSource = mys.dataTable("regslip")
        rpt.DataMember = "spRegistrasiSlip"
        rpt.DisplayName = "Slip Registrasi"
        rpt.Parameters("pID").Value = iddata
        rpt.Parameters("pNo").Value = iddata
        rpt.Parameters("pFooter").Value = "dicetak oleh " & username & " pada " & Format(nowTime, "dd ") & NamaBulan(nowTime.Month) & Format(nowTime, " yyyy HH:mm")
        rpt.ShowPrintMarginsWarning = False

        Dim pt As New DevExpress.XtraReports.UI.ReportPrintTool(rpt)
        pt.Report.CreateDocument(False)
        AddHandler pt.PreviewForm.Load, AddressOf PreviewForm_Load
        If cetaktype = cu.cetak Then
            If printername = "" Then
                Try
                    pt.PrintDialog()
                Catch ex1 As Exception
                    dizMsgbox(ex1.Message, dizMsgboxStyle.Kesalahan, Me)
                End Try
            Else
                Dim sharename As String = getPrinter("REGANTRIAN")
                If sharename <> "" Then
                    Try
                        pt.Print(sharename)
                    Catch ex As Exception
                        Try
                            pt.PrintDialog()
                        Catch ex1 As Exception
                            dizMsgbox(ex1.Message, dizMsgboxStyle.Kesalahan, Me)
                        End Try
                    End Try
                Else
                    Try
                        pt.PrintDialog()
                    Catch ex1 As Exception
                        dizMsgbox(ex1.Message, dizMsgboxStyle.Kesalahan, Me)
                    End Try
                End If
            End If
        ElseIf cetaktype = cu.preview Then
            pt.AutoShowParametersPanel = False
            pt.ShowPreview()
        End If
    End Sub

    Private Sub PrintPageHandler(ByVal sender As Object,
       ByVal args As Printing.PrintPageEventArgs)
    End Sub

    Private Sub PreviewForm_Load(sender As Object, ByVal e As EventArgs)
        Dim frm As DevExpress.XtraPrinting.Preview.PrintPreviewFormEx = CType(sender, DevExpress.XtraPrinting.Preview.PrintPreviewFormEx)
        frm.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.Scale, New Object() {1.0F})
    End Sub

    Private Sub btnTunggakan_Click(sender As Object, e As EventArgs) Handles btnTunggakan.Click
        dizMsgbox("Menu belum tersedia", dizMsgboxStyle.Info, Me)
    End Sub

    Private Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click
        dizMsgbox("Menu belum tersedia", dizMsgboxStyle.Info, Me)
    End Sub

    Private Sub btnDataRM_Click(sender As Object, e As EventArgs) Handles btnDataRM.Click
        dizMsgbox("Menu belum tersedia", dizMsgboxStyle.Info, Me)
    End Sub

    Private idselectparent As String
    Private iddokterparent As String
    Private Sub lnkNoRegistrasiInduk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkNoRegistrasiInduk.LinkClicked
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select r.idregistrasi,convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as 'Tgl Registrasi',r.registrasino as 'No Registrasi',pm.nama as 'Tenaga Medis',dbo.fformatnorm(rm.rekammedisno) as 'No RM',rm.nama as 'Nama Pasien',jk.generalcode as 'Jenis Kelamin',convert(varchar,rm.tanggallahir,105) as 'Tgl Lahir',dbo.fUmurRegister(rm.tanggallahir,r.registrasidate) as 'Umur',kw.wilayah as 'Kewarganegaraan' from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' left join wilayah kw on rm.kewarganegaraan=kw.idwilayah  left join paramedis pm on r.iddokterruangan=pm.idparamedis where convert(varchar,r.registrasidate,105) in ('" & Format(nowTime, "dd-MM-yyyy") & "','" & Format(nowTime.AddDays(-1), "dd-MM-yyyy") & "') and r.idregistrasiparent=0 and r.isdeleted=0 and r.registrasistatus=7 and r.transactiontype in (select idtransactiontype from transactiontype where kodetransaksi='REG' and iddepartment in (select [value] from sys_appsetting where variable in ('idirmdept','idigddept','IDIRJDept'))) and rm.rekammedisno<>0  order by r.registrasidate desc", "search")
        Dim cari As New frmSearch(sqls.dataSet, "search", "idregistrasi")
        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            idselectparent = cari.GetIDSelectData
            sqls.DMLQuery("select r.asalpx,r.asalpx2,r.asalrujukan,r.iddokterrujukan,r.idrekammedis,r.iddepartment,r.idunit,d.department,r.registrasino,convert(varchar,r.registrasidate,105) + ' '+convert(varchar,r.registrasidate,108) as registrasidate,ha.generalcode as hamil,r.iddokterruangan from registrasi r left join department d on d.iddepartment=r.iddepartment left join sys_generalcode ha on r.ishamil=ha.idgeneral and ha.gctype='ISHAMIL' where r.idregistrasi='" & idselectparent & "'", "getidrm")
            teNoRegistrasiInduk.Text = sqls.getDataSet("getidrm", 0, "registrasino")
            teNoRegistrasiInduk.Tag = idselectparent
            teDeptInduk.Text = sqls.getDataSet("getidrm", 0, "department")
            iddokterparent = sqls.getDataSet("getidrm", 0, "iddokterruangan")
            idselect = sqls.getDataSet("getidrm", 0, "idrekammedis")
            lueJenisPembayar.EditValue = sqls.getDataSet("getidrm", 0, "payertype")
            lueAsuransi.EditValue = sqls.getDataSet("getidrm", 0, "idasuransi")
            luePayer.EditValue = sqls.getDataSet("getidrm", 0, "idpayer")

            sqls.DMLQuery("select top 1 * from kartu where idreff='" & idselect & "' and idpenerbit='" & sqls.getDataSet("getidrm", 0, "idasuransi") & "' and tablereff='PASIEN' and jenispenerbit='ASURANSI' and jeniskartu=11 and isdeleted=0 order by createddate desc", "kartu")
            If sqls.getDataSet("kartu") > 0 Then
                teNoAsuransi.Text = sqls.getDataSet("kartu", 0, "nomorkartu")
            Else
                teNoAsuransi.Text = ""
            End If

            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"@idrm"})
            value.AddRange(New Object() {idselect})
            sqls.CallSP("spGetPasienRegistrasi", "getpasienreg", field, value)

            cnt = 0
            cntdept = 0
            cntdokter = 0
            teNoRM.Tag = idselect
            teNoRM.Text = Format(CLng(sqls.getDataSet("getpasienreg", 0, "rekammedisno").ToString.Replace("-", "")), "0#######")
            teJenisKartu.Text = sqls.getDataSet("getpasienreg", 0, "jeniskartu")
            teNomorKartu.Text = sqls.getDataSet("getpasienreg", 0, "nomorkartu")
            lueHamil.EditValue = CLng(0)
            teGolonganDarah.Tag = sqls.getDataSet("getpasienreg", 0, "idgolongandarah")
            teGolonganDarah.Text = sqls.getDataSet("getpasienreg", 0, "golongandarah")
            teRhesus.Text = sqls.getDataSet("getpasienreg", 0, "rhesus")

            teNamaPanggilan.Text = sqls.getDataSet("getpasienreg", 0, "namapanggilan")
            teNama.Text = sqls.getDataSet("getpasienreg", 0, "nama")
            teJenisKelamin.Tag = sqls.getDataSet("getpasienreg", 0, "idjeniskelamin")
            teJenisKelamin.Text = sqls.getDataSet("getpasienreg", 0, "jeniskelamin")
            teWarganegara.Tag = sqls.getDataSet("getpasienreg", 0, "kewarganegaraan")
            teWarganegara.Text = sqls.getDataSet("getpasienreg", 0, "warganegara")
            Dim strtgllahir As String = sqls.getDataSet("getpasienreg", 0, "tanggallahir")
            deTanggalLahir.EditValue = Strdate2Date(strtgllahir)
            teUmur.Text = sqls.getDataSet("getpasienreg", 0, "usia")

            meAlamat.Text = sqls.getDataSet("getpasienreg", 0, "alamat")

            lueAsalPx.EditValue = CLng(1) 'sqls.getDataSet("getpasienreg", 0, "asalpx")
            lueAsalPx2.EditValue = CLng(1) 'sqls.getDataSet("getpasienreg", 0, "asalpx2")
            lueAsalPx3.EditValue = iddokterparent 'sqls.getDataSet("getpasienreg", 0, "asalrujukan")
            lueAsalPx4.EditValue = Nothing 'sqls.getDataSet("getpasienreg", 0, "iddokterrujukan")

            lnkNoRM.Enabled = False
            lnkTanggalLahir.Enabled = False
            lnkNama.Enabled = False
        End If
    End Sub

    Private Sub btnCetakUlang_Click(sender As Object, e As EventArgs) Handles btnCetakUlang.Click
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select r.idregistrasi,convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as 'Tgl Registrasi',r.registrasino as 'No Registrasi',pm.nama as 'Tenaga Medis',dbo.fformatnorm(rm.rekammedisno) as 'No RM',rm.nama as 'Nama Pasien',jk.generalcode as 'Jenis Kelamin',convert(varchar,rm.tanggallahir,105) as 'Tgl Lahir',dbo.fUmurRegister(rm.tanggallahir,r.registrasidate) as 'Umur',kw.wilayah as 'Kewarganegaraan' from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' left join wilayah kw on rm.kewarganegaraan=kw.idwilayah  left join paramedis pm on r.iddokterruangan=pm.idparamedis where (r.registrasistatus=0 or r.registrasistatus=1) and r.iddepartment in (select [value] from sys_appsetting where variable in ('IDIRJDept','IDLabDept','IDRadDept','idirmdept')) and convert(varchar,r.registrasidate,105)=convert(varchar,getdate(),105) order by r.registrasino desc,r.registrasidate desc", "search")
        Dim cari As New frmSearch(sqls.dataSet, "search", "idregistrasi")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim idselectu As String = cari.GetIDSelectData

            Dim selectPrint As New frmPrintSelect()
            tambahChild(selectPrint)
            selectPrint.ShowDialog()

            If selectPrint.getStringPilih = "PREVIEW" Then
                cetakBerkas(idselectu, cu.preview, "")
            ElseIf selectPrint.getStringPilih = "CETAK" Then
                Dim prntname As String = ""
                prntname = getPrinter("REGANTRIAN")
                'Dim sd As New frmSelectDevice
                'tambahChild(sd)
                'If sd.ShowDialog() = DialogResult.OK Then
                'prntname = sd.getdevicename
                cetakBerkas(idselectu, cu.cetak, prntname)
                'End If
                'cetakBerkas(idselectu, cu.cetak, "")
            End If
        End If
    End Sub

    Private Sub btnCetakRegister_Click(sender As Object, e As EventArgs)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select r.idregistrasi,convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as 'Tgl Registrasi',r.registrasino as 'No Registrasi',pm.nama as 'Tenaga Medis',dbo.fformatnorm(rm.rekammedisno) as 'No RM',rm.nama as 'Nama Pasien',jk.generalcode as 'Jenis Kelamin',convert(varchar,rm.tanggallahir,105) as 'Tgl Lahir',dbo.fUmurRegister(rm.tanggallahir,r.registrasidate) as 'Umur',kw.wilayah as 'Kewarganegaraan' from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' left join wilayah kw on rm.kewarganegaraan=kw.idwilayah  left join paramedis pm on r.iddokterruangan=pm.idparamedis where (r.registrasistatus=0 or r.registrasistatus=1) and convert(varchar,r.registrasidate,105)=convert(varchar,getdate(),105) order by r.registrasino desc,r.registrasidate desc", "search")
        Dim cari As New frmSearch(sqls.dataSet, "search", "idregistrasi")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim idselectu As String = cari.GetIDSelectData

            Dim selectPrint As New frmPrintSelect()
            tambahChild(selectPrint)
            selectPrint.ShowDialog()

            If selectPrint.getStringPilih = "PREVIEW" Then
                cetakBerkas(idselectu, cu.preview, "")
            ElseIf selectPrint.getStringPilih = "CETAK" Then
                Dim prntname As String = ""
                'Dim sd As New frmSelectDevice
                'tambahChild(sd)
                'If sd.ShowDialog() = DialogResult.OK Then
                'prntname = sd.getdevicename
                cetakBerkas(idselectu, cu.cetak, prntname)
                'End If
                'cetakBerkas(idselectu, cu.cetak, "")
            End If
        End If
    End Sub

    Enum cu
        preview = 1
        cetak = 2
    End Enum

    Private Sub btnLabel_Click(sender As Object, e As EventArgs) Handles btnLabel.Click
        Dim radsel10 As New frmSelectLabel10("IRM")
        radsel10.ShowDialog(Me)
    End Sub

    Private Sub btnAppDokter_Click(sender As Object, e As EventArgs) Handles btnAppDokter.Click
        formTitle = "Monitoring Appointment Dokter"
        Dim frmMon As New frmMonAppointment
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

    Private Sub btnAppPasien_Click(sender As Object, e As EventArgs) Handles btnAppPasien.Click
        formTitle = "Monitoring Appointment Pasien"
        Dim frmMon As New frmMonAppointmentPasien
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

    Private Sub btnMonRegister_Click(sender As Object, e As EventArgs) Handles btnMonRegister.Click
        formTitle = "Monitoring Registrasi"
        Dim frmMon As New frmMonRegisterIRM
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

    Private Sub btnSwap_Click(sender As Object, e As EventArgs) Handles btnSwap.Click
        formTitle = ""
        Dim child As New frmPasienSwapData()
        tambahChild(child)
        child.StartPosition = FormStartPosition.CenterScreen
        child.pMinimize.Enabled = False
        child.pMaximize.Enabled = False
        child.tlpForm.RowCount = 4
        child.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        child.ShowDialog(Me)
        disposeChild(child, Nothing)
    End Sub

    Private Sub btnQuickEdit_Click(sender As Object, e As EventArgs) Handles btnQuickEdit.Click
        formTitle = "Data Pasien - Edit Cepat"
        Dim frmMon As New frmPasienQuickEdit
        tambahChild(frmMon)
        'frmMon.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        'frmMon.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        frmMon.StartPosition = FormStartPosition.CenterScreen
        frmMon.pMinimize.Enabled = False
        frmMon.pMaximize.Enabled = False
        frmMon.tlpForm.RowCount = 4
        frmMon.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        frmMon.ShowDialog(Me)
        formTitle = Me.lblTitle.Text
    End Sub

    Private Sub btnAppHarian_Click(sender As Object, e As EventArgs) Handles btnAppHarian.Click
        formTitle = "Monitoring Appointment Harian"
        Dim frmMon As New frmMonAppointmentHarian
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

    Private Sub btnMonRegHarian_Click(sender As Object, e As EventArgs) Handles btnMonRegHarian.Click
        formTitle = "Monitoring Register"
        Dim frmMon As New frmMonRegister
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

    Private Sub btnDokter_Click(sender As Object, e As EventArgs) Handles btnDokter.Click
        formTitle = "Data Paramedis - Tambah Cepat"
        Dim frmMon As New frmParamedisQuickAdd
        tambahChild(frmMon)
        'frmMon.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        'frmMon.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        frmMon.StartPosition = FormStartPosition.CenterScreen
        frmMon.pMinimize.Enabled = False
        frmMon.pMaximize.Enabled = False
        frmMon.tlpForm.RowCount = 4
        frmMon.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        frmMon.ShowDialog(Me)
        formTitle = Me.lblTitle.Text

        lueAsalPx.EditValue = Nothing
    End Sub

    Private Sub btnInstansi_Click(sender As Object, e As EventArgs) Handles btnInstansi.Click
        formTitle = "Data Partner Bisnis - Tambah Cepat"
        Dim frmMon As New frmBusinessPartnerQuickAdd
        tambahChild(frmMon)
        'frmMon.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        'frmMon.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        frmMon.StartPosition = FormStartPosition.CenterScreen
        frmMon.pMinimize.Enabled = False
        frmMon.pMaximize.Enabled = False
        frmMon.tlpForm.RowCount = 4
        frmMon.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        frmMon.ShowDialog(Me)
        formTitle = Me.lblTitle.Text

        lueAsalPx.EditValue = Nothing
    End Sub

    Private Sub btnRegistrasiCCL_Click(sender As Object, e As EventArgs) Handles btnRegistrasiCCL.Click
        formTitle = "Pembatalan Registrasi"
        Dim frmMon As New frmRegistrasiCancel
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

End Class