Public Class frmRujukanInternal

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private jenisPelayanan As String = ""
    Private idregparent As String = ""
    Public Sub New(strParam As String, idreginduk As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        jenisPelayanan = strParam
        idregparent = idreginduk
    End Sub

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
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISODS' order by idgeneral asc", "isods")
        lueODS.Properties.DataSource = mysqls.dataTable("isods")
        lueODS.Properties.DisplayMember = "content"
        lueODS.Properties.ValueMember = "id"
        If mysqls.getDataSet("isods") = 0 Then
            dizMsgbox("Status ODC/ODS tidak ditemukan" & vbCrLf & "Status ODC/ODS harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If
    End Sub

    Private Sub baru()
        lueODS.EditValue = CLng(0)

        If jenisPelayanan = "KONSULTASI" Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select case when isnull(max(convert(bigint,rekammedisno)),0)=0 then 1 else max(convert(bigint,rekammedisno))+1 end as mrn from rekammedis", "lastmrn")
            teJenisKunjungan.Text = "Konsultasi & Tindakan"
            teJenisKunjungan.Tag = 1

            lueODS.Properties.ReadOnly = False
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
        ElseIf jenisPelayanan = "ODS" Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select case when isnull(max(convert(bigint,rekammedisno)),0)=0 then 1 else max(convert(bigint,rekammedisno))+1 end as mrn from rekammedis", "lastmrn")
            teJenisKunjungan.Text = "Konsultasi & Tindakan"
            teJenisKunjungan.Tag = 1

            lueODS.Properties.ReadOnly = False
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
        ElseIf jenisPelayanan = "REHABILITASI" Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select case when isnull(max(convert(bigint,rekammedisno)),0)=0 then 1 else max(convert(bigint,rekammedisno))+1 end as mrn from rekammedis", "lastmrn")
            teJenisKunjungan.Text = "Rehabilitasi Medik"
            teJenisKunjungan.Tag = 1

            lueODS.Properties.ReadOnly = True
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
        ElseIf jenisPelayanan = "PEMERIKSAAN" Or jenisPelayanan = "PEMERIKSAAN APS" Then
            teJenisKunjungan.Text = "Pemeriksaan"
            teJenisKunjungan.Tag = 2

            If jenisPelayanan = "PEMERIKSAAN" Then
                lueODS.Properties.ReadOnly = True
                teNoRegistrasiInduk.Visible = True
                lblDeptInduk.Visible = True
                teDeptInduk.Visible = True
            ElseIf jenisPelayanan = "PEMERIKSAAN APS" Then
                lueODS.Properties.ReadOnly = True
                teNoRegistrasiInduk.Visible = True
                lblDeptInduk.Visible = False
                teDeptInduk.Visible = False
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
        ElseIf jenisPelayanan = "IGD" Or jenisPelayanan = "IGD ELEKTIF" Then
            teJenisKunjungan.Text = "Pemeriksaan"
            teJenisKunjungan.Tag = 2

            If jenisPelayanan = "IGD" Then
                lueODS.Properties.ReadOnly = False
                teNoRegistrasiInduk.Visible = True
                lblDeptInduk.Visible = False
                teDeptInduk.Visible = False
            ElseIf jenisPelayanan = "IGD ELEKTIF" Then
                lueODS.Properties.ReadOnly = False
                teNoRegistrasiInduk.Visible = True
                lblDeptInduk.Visible = False
                teDeptInduk.Visible = False
            End If

            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select p.idparamedis as id,p.nama as content from paramedis p where p.isservice=1 and p.isdeleted=0 and p.paramedistype=2 order by p.nama asc", "listdokter")
            lueParamedis.Properties.DataSource = sqls.dataTable("listdokter")
            lueParamedis.Properties.DisplayMember = "content"
            lueParamedis.Properties.ValueMember = "id"
            lueParamedis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            'lueParamedis.Properties.BestFit()
        ElseIf jenisPelayanan = "UMUM" Then
            teJenisKunjungan.Text = "Pemeriksaan"
            teJenisKunjungan.Tag = 2

            If jenisPelayanan = "UMUM" Then
                lueODS.Properties.ReadOnly = False
                teNoRegistrasiInduk.Visible = True
                lblDeptInduk.Visible = True
                teDeptInduk.Visible = True
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
        ElseIf jenisPelayanan = "MCU" Then
            teJenisKunjungan.Text = "Pemeriksaan"
            teJenisKunjungan.Tag = 2

            If jenisPelayanan = "MCU" Then
                lueODS.Properties.ReadOnly = True
                teNoRegistrasiInduk.Visible = True
                lblDeptInduk.Visible = True
                teDeptInduk.Visible = True
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
            btnSave.Enabled = True
        End If
    End Sub

    Private Sub frmRujukanInternal_Load(sender As Object, e As EventArgs) Handles Me.Load
        pMinimize.Visible = False
        pMaximize.Visible = False

        loadLOV()
        baru()

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select r.registrasino,d.department,r.idrekammedis from registrasi r left join department d on r.iddepartment=d.iddepartment where r.idregistrasi='" & idregparent & "'", "getparent")
        teTanggalPendaftaran.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        teNoRegistrasiInduk.Text = sqls.getDataSet("getparent", 0, "registrasino")
        teDeptInduk.Text = sqls.getDataSet("getparent", 0, "department")
        idrm = sqls.getDataSet("getparent", 0, "idrekammedis")
    End Sub

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
            If jenisPelayanan = "REHABILITASI" Then
                sqls.DMLQuery("select s.nama as content,s.idspesialis as id from spesialis s left join paramedisspesialis ps on s.idspesialis=ps.idspesialis where ps.idspesialis in (select value from sys_appsetting where variable in ('IDSPKFR')) and ps.idparamedis='" & lueParamedis.EditValue & "'", "spesialis")
        Else
                sqls.DMLQuery("select s.nama as content,s.idspesialis as id from spesialis s left join paramedisspesialis ps on s.idspesialis=ps.idspesialis where ps.idspesialis not in (select value from sys_appsetting where variable in ('IDSPKFR','IDSPPK','IDSPRad')) and ps.idparamedis='" & lueParamedis.EditValue & "'", "spesialis")
            End If
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
            idtrans = pair.Key
            teNoRegistrasi.Text = pair.Value
        End If
    End Sub

    Private idrm As String = ""
    Private idData As String = ""
    Private idkelas As String = "0"
    Private iddept As String = "0"
    Private kddept As String = ""
    Private idunit As String = "0"
    Private kdunit As String = ""
    Private idtrans As String = "0"
    Private jenistrans As String = ""
    Private formatstring As String = ""
    Private formatperiode As String = ""
    Private cnt As Long = 0
    Private cntdept As Long = 0
    Private cntdokter As Long = 0

    Private Function checkEntry() As Boolean
        Dim retval As Boolean = True
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
        Return retval
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If checkEntry() = False Then
            dizMsgbox("Isian belum benar", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idregistrasi from registrasi where isdeleted=0 and iddokterruangan='" & lueParamedis.EditValue & "' and idrekammedis='" & idrm & "' and convert(varchar,createddate,105)=convert(varchar,getdate(),105)", "cekregexist")
        If sqls.getDataSet("cekregexist") > 0 Then
            If dizMsgbox("Register aktif ditemukan untuk " & idrm & " ke Dokter/Tenaga Medis " & lueParamedis.Text & vbCrLf & "Melanjutkan untuk diregister ulang?", dizMsgboxStyle.Konfirmasi, "Konfirmasi") = dizMsgboxValue.Batal Then
                Exit Sub
            End If
        End If

        Dim pair As KeyValuePair(Of String, String) = generateno2(idunit, iddept, "Registrasi", False)
        Dim idtrans As String = pair.Key
        teNoRegistrasi.Text = pair.Value

        sqls.DMLQuery("select count(idregistrasi) as count from registrasi where registrasistatus<>2 and idrekammedis='" & idrm & "'", "cnt")
        cnt = sqls.getDataSet("cnt", 0, "count")

        If iddept <> "0" Then
            sqls.DMLQuery("select count(idregistrasi) as count from registrasi where registrasistatus<>2 and iddepartment='" & iddept & "' and idunit='" & idunit & "' and idrekammedis='" & idrm & "'", "cntdept")
            cntdept = sqls.getDataSet("cntdept", 0, "count")
        End If
        If lueParamedis.EditValue IsNot Nothing Then
            sqls.DMLQuery("select count(idregistrasi) as count from registrasi where registrasistatus<>2 and iddokterruangan='" & lueParamedis.EditValue & "' and idrekammedis='" & idrm & "'", "cntdokter")
            cntdokter = sqls.getDataSet("cntdokter", 0, "count")
        End If

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        sqls.DMLQuery("select * from registrasi where idregistrasi='" & idregparent & "'", "getparent")
        Dim asalpx As String = sqls.getDataSet("getparent", 0, "asalpx")
        Dim asalpx2 As String = sqls.getDataSet("getparent", 0, "asalpx2")
        Dim asalpx3 As String = sqls.getDataSet("getparent", 0, "asalrujukan")
        Dim asalpx4 As String = sqls.getDataSet("getparent", 0, "iddokterrujukan")
        Dim payertype As String = sqls.getDataSet("getparent", 0, "payertype")
        Dim idpayer As String = sqls.getDataSet("getparent", 0, "idpayer")
        Dim idasuransi As String = sqls.getDataSet("getparent", 0, "idasuransi")
        Dim ishamil As String = sqls.getDataSet("getparent", 0, "ishamil")

        idData = GenerateGUID()

        Dim dtsqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        field.AddRange(New String() {"idregistrasi", "transactiontype", "idjadwalsesi", "idcompany", "idregistrasiparent", "iddepartment", "idunit", "idrekammedis", "idlokasi", "idkelas", "iddokterruangan", "idspesialisruangan", "registrasino", "kunjunganke", "kunjungandokterke", "kunjungandepartmentke", "asalpx", "asalpx2", "asalrujukan", "iddokterrujukan", "jeniskunjungan", "registrasistatus", "remarks", "payertype", "idpayer", "idasuransi", "ishamil", "isdeleted", "deletereason", "createdby", "isoneday"})
        value.AddRange(New Object() {idData, idtrans, If(lueSesi.EditValue, "0"), idcomp, idregparent, iddept, idunit, idrm, lueRuang.EditValue, idkelas, lueParamedis.EditValue, If(lueSpesialis.EditValue, 0), teNoRegistrasi.Text, cnt + 1, cntdokter + 1, cntdept + 1, asalpx, asalpx2, asalpx3, asalpx4, CLng(teJenisKunjungan.Tag), 0, "", payertype, idpayer, idasuransi, ishamil, 0, "-", userid, If(lueODS.EditValue, 0)})
        Dim cek As Boolean = dtsqls.datasetSave("registrasi", idData, field, value, False)
        If cek = True Then
            ceksimpanAppointment(lueParamedis.EditValue, If(lueSpesialis.EditValue, 0), If(lueSesi.EditValue, 0), idrm, idData)
            dizMsgbox("Registrasi telah tersimpan", dizMsgboxStyle.Info, Me)
            Me.Dispose()
        End If
    End Sub

    Private Sub ceksimpanAppointment(idparam As String, idsp As String, idjs As String, idrm As String, idreg As String)
        Dim idps As String = "-1"
        Dim idapp As String = "-1"
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
            sqls.DMLQuery("select idappointment from appointment where convert(varchar,bookingdate,105)=convert(varchar,getdate(),105) and idparamedisspesialis='" & idps & "' and idjadwalsesi='" & idjs & "' and idrekammedis='" & idrm & "'", "getidapp")
            If sqls.getDataSet("getidapp") > 0 Then
                idapp = sqls.getDataSet("getidapp", 0, "idappointment").ToString
                sqls.DMLQuery("update appointment set idregistrasi='" & idreg & "',bookingstatus=2,updateddate=getdate(),updatedby='" & userid & "' where idappointment='" & idapp & "'", False)
            End If
        End If
    End Sub

End Class