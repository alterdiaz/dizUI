Public Class frmPelayananSelect

    'Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
    '    If txtPilih = "" Then
    '        dizMsgbox("Jenis Pelayanan belum dipilih", dizMsgboxStyle.Peringatan, Me)
    '        Exit Sub
    '    End If
    '    bClose = False
    '    Me.Dispose()
    'End Sub

    Private txtPilih As String = ""
    Private Sub btnKonsultasi_Click(sender As Object, e As EventArgs) Handles btnKonsultasi.Click, btnPemeriksaan.Click, btnPemeriksaanAPS.Click, btnIGD.Click, btnIGDelektif.Click, btnUmum.Click, btnRehabilitasi.Click, btnMCU.Click, btnODS.Click
        txtPilih = sender.tag
        If sender.name = "btnKonsultasi" Then
            btnKonsultasi.BackColor = Color.Olive
            btnRehabilitasi.BackColor = Color.FromArgb(64, 0, 64)
            btnPemeriksaan.BackColor = Color.FromArgb(64, 0, 64)
            btnPemeriksaanAPS.BackColor = Color.FromArgb(64, 0, 64)
            btnIGD.BackColor = Color.FromArgb(64, 0, 64)
            btnIGDelektif.BackColor = Color.FromArgb(64, 0, 64)
            btnUmum.BackColor = Color.FromArgb(64, 0, 64)
            btnMCU.BackColor = Color.FromArgb(64, 0, 64)
            btnODS.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnPemeriksaan" Then
            btnKonsultasi.BackColor = Color.FromArgb(64, 0, 64)
            btnRehabilitasi.BackColor = Color.FromArgb(64, 0, 64)
            btnPemeriksaan.BackColor = Color.Olive
            btnPemeriksaanAPS.BackColor = Color.FromArgb(64, 0, 64)
            btnIGD.BackColor = Color.FromArgb(64, 0, 64)
            btnIGDelektif.BackColor = Color.FromArgb(64, 0, 64)
            btnUmum.BackColor = Color.FromArgb(64, 0, 64)
            btnMCU.BackColor = Color.FromArgb(64, 0, 64)
            btnODS.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnPemeriksaanAPS" Then
            btnKonsultasi.BackColor = Color.FromArgb(64, 0, 64)
            btnRehabilitasi.BackColor = Color.FromArgb(64, 0, 64)
            btnPemeriksaan.BackColor = Color.FromArgb(64, 0, 64)
            btnPemeriksaanAPS.BackColor = Color.Olive
            btnIGD.BackColor = Color.FromArgb(64, 0, 64)
            btnIGDelektif.BackColor = Color.FromArgb(64, 0, 64)
            btnUmum.BackColor = Color.FromArgb(64, 0, 64)
            btnMCU.BackColor = Color.FromArgb(64, 0, 64)
            btnODS.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnIGD" Then
            btnKonsultasi.BackColor = Color.FromArgb(64, 0, 64)
            btnRehabilitasi.BackColor = Color.FromArgb(64, 0, 64)
            btnPemeriksaan.BackColor = Color.FromArgb(64, 0, 64)
            btnPemeriksaanAPS.BackColor = Color.FromArgb(64, 0, 64)
            btnIGD.BackColor = Color.Olive
            btnIGDelektif.BackColor = Color.FromArgb(64, 0, 64)
            btnUmum.BackColor = Color.FromArgb(64, 0, 64)
            btnMCU.BackColor = Color.FromArgb(64, 0, 64)
            btnODS.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnIGDelektif" Then
            btnKonsultasi.BackColor = Color.FromArgb(64, 0, 64)
            btnRehabilitasi.BackColor = Color.FromArgb(64, 0, 64)
            btnPemeriksaan.BackColor = Color.FromArgb(64, 0, 64)
            btnPemeriksaanAPS.BackColor = Color.FromArgb(64, 0, 64)
            btnIGD.BackColor = Color.FromArgb(64, 0, 64)
            btnIGDelektif.BackColor = Color.Olive
            btnUmum.BackColor = Color.FromArgb(64, 0, 64)
            btnMCU.BackColor = Color.FromArgb(64, 0, 64)
            btnODS.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnUmum" Then
            btnKonsultasi.BackColor = Color.FromArgb(64, 0, 64)
            btnRehabilitasi.BackColor = Color.FromArgb(64, 0, 64)
            btnPemeriksaan.BackColor = Color.FromArgb(64, 0, 64)
            btnPemeriksaanAPS.BackColor = Color.FromArgb(64, 0, 64)
            btnIGD.BackColor = Color.FromArgb(64, 0, 64)
            btnIGDelektif.BackColor = Color.FromArgb(64, 0, 64)
            btnUmum.BackColor = Color.Olive
            btnMCU.BackColor = Color.FromArgb(64, 0, 64)
            btnODS.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnRehabilitasi" Then
            btnKonsultasi.BackColor = Color.FromArgb(64, 0, 64)
            btnRehabilitasi.BackColor = Color.Olive
            btnPemeriksaan.BackColor = Color.FromArgb(64, 0, 64)
            btnPemeriksaanAPS.BackColor = Color.FromArgb(64, 0, 64)
            btnIGD.BackColor = Color.FromArgb(64, 0, 64)
            btnIGDelektif.BackColor = Color.FromArgb(64, 0, 64)
            btnUmum.BackColor = Color.FromArgb(64, 0, 64)
            btnMCU.BackColor = Color.FromArgb(64, 0, 64)
            btnODS.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnMCU" Then
            btnKonsultasi.BackColor = Color.FromArgb(64, 0, 64)
            btnRehabilitasi.BackColor = Color.FromArgb(64, 0, 64)
            btnPemeriksaan.BackColor = Color.FromArgb(64, 0, 64)
            btnPemeriksaanAPS.BackColor = Color.FromArgb(64, 0, 64)
            btnIGD.BackColor = Color.FromArgb(64, 0, 64)
            btnIGDelektif.BackColor = Color.FromArgb(64, 0, 64)
            btnUmum.BackColor = Color.FromArgb(64, 0, 64)
            btnMCU.BackColor = Color.Olive
            btnODS.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnODS" Then
            btnKonsultasi.BackColor = Color.FromArgb(64, 0, 64)
            btnRehabilitasi.BackColor = Color.FromArgb(64, 0, 64)
            btnPemeriksaan.BackColor = Color.FromArgb(64, 0, 64)
            btnPemeriksaanAPS.BackColor = Color.FromArgb(64, 0, 64)
            btnIGD.BackColor = Color.FromArgb(64, 0, 64)
            btnIGDelektif.BackColor = Color.FromArgb(64, 0, 64)
            btnUmum.BackColor = Color.FromArgb(64, 0, 64)
            btnMCU.BackColor = Color.FromArgb(64, 0, 64)
            btnODS.BackColor = Color.Olive
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        bClose = False
        Me.Dispose()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        txtPilih = ""
        bClose = False
        Me.Dispose()
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = bClose
    End Sub

    Private Sub frmPelayananSelect_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select sp.idparamedis as id,p.nama + ' ('+ s.nama + ')' as content from paramedis p left join paramedisspesialis sp on p.idparamedis=sp.idparamedis left join spesialis s on s.idspesialis=sp.idspesialis where p.isservice=1 and p.isdeleted=0 and p.paramedistype in (select idgeneral from sys_generalcode where gctype='paramedistype' and priority in (1,2,3)) and p.idparamedis in (select distinct(ps.idparamedis) as idparamedis from paramedisjadwal pj left join paramedisspesialis ps on pj.idparamedisspesialis=ps.idparamedisspesialis where pj.hari like '%" & nowTime.DayOfWeek & "%' and ps.idspesialis not in (select [value] from sys_appsetting where variable in ('IDSPPK','IDSPRad','IDSPKFR'))) and p.isdeleted=0 and s.idspesialis not in (select [value] from sys_appsetting where variable in ('IDSPPK','IDSPRad','IDSPKFR')) order by s.nama,p.nama asc", "konsultasi")
        sqls.DMLQuery("select sp.idparamedis as id,p.nama + ' ('+ s.nama + ')' as content from paramedis p left join paramedisspesialis sp on p.idparamedis=sp.idparamedis left join spesialis s on s.idspesialis=sp.idspesialis where p.isservice=1 and p.isdeleted=0 and p.paramedistype>0 and p.idparamedis in (select distinct(ps.idparamedis) as idparamedis from paramedisjadwal pj left join paramedisspesialis ps on pj.idparamedisspesialis=ps.idparamedisspesialis where pj.hari like '%" & nowTime.DayOfWeek & "%' and ps.idspesialis in (select [value] from sys_appsetting where variable in ('IDSPKFR'))) and p.isdeleted=0 and s.idspesialis in (select [value] from sys_appsetting where variable in ('IDSPKFR')) order by s.nama,p.nama asc", "rehabilitasi")
        sqls.DMLQuery("select sp.idparamedis as id,p.nama + ' ('+ s.nama + ')' as content from paramedis p left join paramedisspesialis sp on p.idparamedis=sp.idparamedis left join spesialis s on s.idspesialis=sp.idspesialis where p.isservice=1 and p.isdeleted=0 and s.idspesialis in (select [value] from sys_appsetting where variable in ('IDSPPK','IDSPRad')) order by s.nama,p.nama asc", "penunjang")
        sqls.DMLQuery("select p.idparamedis as id,p.nama as content from paramedis p where p.isservice=1 and p.isdeleted=0 and p.paramedistype=2 order by p.nama asc", "igd")
        sqls.DMLQuery("select p.idparamedis as id,p.nama as content from paramedis p where p.isservice=1 and p.isdeleted=0 and p.paramedistype=2 order by p.nama asc", "umum")

        lblIGD.Visible = False
        lblIGDelektif.Visible = False
        lblKonsultasi.Visible = False
        lblPemeriksaan.Visible = False
        lblPemeriksaanAPS.Visible = False
        lblRehabilitasi.Visible = False
        lblUmum.Visible = False
        lblODS.Visible = False
        lblMCU.Visible = False

        If sqls.getDataSet("konsultasi") = 0 Then
            btnKonsultasi.Enabled = False
            lblKonsultasi.Visible = True
            btnODS.Enabled = False
            lblODS.Visible = True
        Else
            sqls.DMLQuery("select idlokasi as id,nama as content from lokasi where lokasitype in (3,4) and iddepartment in (select [value] from sys_appsetting where variable='IDODSDept') order by nama asc", "jadwallokasi")
            If sqls.getDataSet("jadwallokasi") = 0 Then
                btnODS.Enabled = False
                lblODS.Visible = True
            End If
        End If
            If sqls.getDataSet("rehabilitasi") = 0 Then
            btnRehabilitasi.Enabled = False
            lblRehabilitasi.Visible = True
        End If
        If sqls.getDataSet("penunjang") = 0 Then
            btnPemeriksaan.Enabled = False
            lblPemeriksaan.Visible = True
            btnPemeriksaanAPS.Enabled = False
            lblPemeriksaanAPS.Visible = True
        End If
        If sqls.getDataSet("igd") = 0 Then
            btnIGD.Enabled = False
            lblIGD.Visible = True
            btnIGDelektif.Enabled = False
            lblIGDelektif.Visible = True
        End If
        If sqls.getDataSet("umum") = 0 Then
            btnUmum.Enabled = False
            lblUmum.Visible = True
            btnMCU.Enabled = False
            lblMCU.Visible = True
        Else
            sqls.DMLQuery("select idlokasi as id,nama as content from lokasi where lokasitype in (3) and iddepartment in (select [value] from sys_appsetting where variable='IDMCUDept') order by nama asc", "jadwallokasi")
            If sqls.getDataSet("jadwallokasi") = 0 Then
                btnMCU.Enabled = False
                lblMCU.Visible = True
            End If
        End If
    End Sub

    Public ReadOnly Property getStringPilih() As String
        Get
            Return txtPilih
        End Get
    End Property

End Class