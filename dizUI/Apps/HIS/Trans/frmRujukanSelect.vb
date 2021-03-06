﻿Public Class frmRujukanSelect

    'Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
    '    If txtPilih = "" Then
    '        dizMsgbox("Jenis Pelayanan belum dipilih", dizMsgboxStyle.Peringatan, Me)
    '        Exit Sub
    '    End If
    '    bClose = False
    '    Me.Dispose()
    'End Sub

    Private txtPilih As String = ""
    Private Sub btnKonsultasi_Click(sender As Object, e As EventArgs) Handles btnKonsultasi.Click, btnPemeriksaan.Click, btnIGD.Click, btnUmum.Click, btnRehabilitasi.Click
        txtPilih = sender.tag
        If sender.name = "btnKonsultasi" Then
            btnKonsultasi.BackColor = Color.Olive
            btnRehabilitasi.BackColor = Color.FromArgb(64, 0, 64)
            btnPemeriksaan.BackColor = Color.FromArgb(64, 0, 64)
            btnIGD.BackColor = Color.FromArgb(64, 0, 64)
            btnUmum.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnPemeriksaan" Then
            btnKonsultasi.BackColor = Color.FromArgb(64, 0, 64)
            btnRehabilitasi.BackColor = Color.FromArgb(64, 0, 64)
            btnPemeriksaan.BackColor = Color.Olive
            btnIGD.BackColor = Color.FromArgb(64, 0, 64)
            btnUmum.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnIGD" Then
            btnKonsultasi.BackColor = Color.FromArgb(64, 0, 64)
            btnRehabilitasi.BackColor = Color.FromArgb(64, 0, 64)
            btnPemeriksaan.BackColor = Color.FromArgb(64, 0, 64)
            btnIGD.BackColor = Color.Olive
            btnUmum.BackColor = Color.FromArgb(64, 0, 64)
        ElseIf sender.name = "btnUmum" Then
            btnKonsultasi.BackColor = Color.FromArgb(64, 0, 64)
            btnRehabilitasi.BackColor = Color.FromArgb(64, 0, 64)
            btnPemeriksaan.BackColor = Color.FromArgb(64, 0, 64)
            btnIGD.BackColor = Color.FromArgb(64, 0, 64)
            btnUmum.BackColor = Color.Olive
        ElseIf sender.name = "btnRehabilitasi" Then
            btnKonsultasi.BackColor = Color.FromArgb(64, 0, 64)
            btnRehabilitasi.BackColor = Color.Olive
            btnPemeriksaan.BackColor = Color.FromArgb(64, 0, 64)
            btnIGD.BackColor = Color.FromArgb(64, 0, 64)
            btnUmum.BackColor = Color.FromArgb(64, 0, 64)
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
        lblKonsultasi.Visible = False
        lblPemeriksaan.Visible = False
        lblRehabilitasi.Visible = False
        lblUmum.Visible = False

        If sqls.getDataSet("konsultasi") = 0 Then
            btnKonsultasi.Enabled = False
            lblKonsultasi.Visible = True
        End If
        If sqls.getDataSet("rehabilitasi") = 0 Then
            btnRehabilitasi.Enabled = False
            lblRehabilitasi.Visible = True
        End If
        If sqls.getDataSet("penunjang") = 0 Then
            btnPemeriksaan.Enabled = False
            lblPemeriksaan.Visible = True
        End If
        If sqls.getDataSet("igd") = 0 Then
            btnIGD.Enabled = False
            lblIGD.Visible = True
        End If
        If sqls.getDataSet("umum") = 0 Then
            btnUmum.Enabled = False
            lblUmum.Visible = True
        End If
    End Sub

    Public ReadOnly Property getStringPilih() As String
        Get
            Return txtPilih
        End Get
    End Property

End Class