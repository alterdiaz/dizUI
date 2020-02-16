Public Class frmRegistrasiPICU
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

        mysqls.DMLQuery("select idkelas as id,kelas as content,priority from kelas where isdeleted=0 order by priority asc", "kelas")
        lueKelas.Properties.DataSource = mysqls.dataTable("kelas")
        lueKelas.Properties.DisplayMember = "content"
        lueKelas.Properties.ValueMember = "id"
        If mysqls.getDataSet("kelas") = 0 Then
            dizMsgbox("Kelas tidak ditemukan" & vbCrLf & "Kelas harap entry dulu", dizMsgboxStyle.Peringatan, Me)
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

            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select p.idparamedis as id,case when isnull(s.nama,'')='' then p.nama else p.nama + ' ('+ convert(varchar,s.nama) + ')' end as content from paramedis p left join paramedisspesialis sp on p.idparamedis=sp.idparamedis left join spesialis s on s.idspesialis=sp.idspesialis where p.paramedistype in (2,3,4,5) and p.isservice=1 and p.isdeleted=0 order by s.nama,p.nama asc", "listdokter")
            lueParamedis.Properties.DataSource = sqls.dataTable("listdokter")
            lueParamedis.Properties.DisplayMember = "content"
            lueParamedis.Properties.ValueMember = "id"
            lueParamedis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            'lueParamedis.Properties.BestFit()

            sqls.DMLQuery("select p.idparamedis as id,case when isnull(s.nama,'')='' then p.nama else p.nama + ' ('+ convert(varchar,s.nama) + ')' end as content from paramedis p left join paramedisspesialis sp on p.idparamedis=sp.idparamedis left join spesialis s on s.idspesialis=sp.idspesialis where p.paramedistype in (2,3,4,5) and p.isservice=1 and p.isdeleted=0 order by s.nama,p.nama asc", "listdoktercase")
            lueParamedisCase.Properties.DataSource = sqls.dataTable("listdoktercase")
            lueParamedisCase.Properties.DisplayMember = "content"
            lueParamedisCase.Properties.ValueMember = "id"
            lueParamedisCase.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            'lueParamedisCase.Properties.BestFit()

            sqls.DMLQuery("select distinct l.idlokasi as id,k.kelas,l.nama as content from lokasi l left join kelaskamar kk on l.idlokasi=kk.idlokasi left join kelas k on kk.idkelas=k.idkelas and k.isdeleted=0 where l.isdeleted=0 and l.idlokasi not in (select idlokasi from kamar where statusbed<>1) and l.lokasitype=22 and l.iddepartment in (select value from sys_appsetting where variable in ('IDNICUDept','IDPICUDept')) order by k.kelas asc,l.nama asc", "ruang")
            lueRuang.Properties.DataSource = sqls.dataTable("ruang")
            lueRuang.Properties.DisplayMember = "content"
            lueRuang.Properties.ValueMember = "id"
            lueRuang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            lueRuang.Properties.BestFit()
            lueRuang.EditValue = Nothing

            If sqls.getDataSet("ruang") = 0 Then
                dizMsgbox("Lokasi tidak ditemukan" & vbCrLf & "Lokasi harap entry dulu", dizMsgboxStyle.Peringatan, Me)
                pExit_Click(Me, Nothing)
                Exit Sub
            End If

            btnDataRM.Enabled = True

            lblNoAsuransi.Visible = False
            teNoAsuransi.Visible = False
            teNoRegistrasi.Text = "XXX/XXX/REG/" & Format(nowTime, "yyyyMMdd") & "/XXXX"

            lnkNoRegistrasiInduk.Visible = True
            teNoRegistrasiInduk.Visible = True
        Else
            lnkNoRegistrasiInduk.Visible = True
            teNoRegistrasiInduk.Visible = True

            tlpField.Enabled = False

            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select case when isnull(max(convert(bigint,rekammedisno)),0)=0 then 1 else max(convert(bigint,rekammedisno))+1 end as mrn from rekammedis", "lastmrn")
            teNoRM.Text = Format(CLng(sqls.getDataSet("lastmrn", 0, "mrn").ToString.Replace("-", "")), "0#######")

            lnkNoRegistrasiInduk.Visible = True
            teNoRegistrasiInduk.Visible = True

            sqls.DMLQuery("select p.idparamedis as id,case when isnull(s.nama,'')='' then p.nama else p.nama + ' ('+ convert(varchar,s.nama) + ')' end as content from paramedis p left join paramedisspesialis sp on p.idparamedis=sp.idparamedis left join spesialis s on s.idspesialis=sp.idspesialis where p.paramedistype in (2,3,4,5) and p.isservice=1 and p.isdeleted=0 order by s.nama,p.nama asc", "listdokter")
            lueParamedis.Properties.DataSource = sqls.dataTable("listdokter")
            lueParamedis.Properties.DisplayMember = "content"
            lueParamedis.Properties.ValueMember = "id"
            lueParamedis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            'lueParamedis.Properties.BestFit()

            sqls.DMLQuery("select p.idparamedis as id,case when isnull(s.nama,'')='' then p.nama else p.nama + ' ('+ convert(varchar,s.nama) + ')' end as content from paramedis p left join paramedisspesialis sp on p.idparamedis=sp.idparamedis left join spesialis s on s.idspesialis=sp.idspesialis where p.paramedistype in (2,3,4,5) and p.isservice=1 and p.isdeleted=0  order by s.nama,p.nama asc", "listdoktercase")
            lueParamedisCase.Properties.DataSource = sqls.dataTable("listdoktercase")
            lueParamedisCase.Properties.DisplayMember = "content"
            lueParamedisCase.Properties.ValueMember = "id"
            lueParamedisCase.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            'lueParamedisCase.Properties.BestFit()

            sqls.DMLQuery("select distinct l.idlokasi as id,k.kelas,l.nama as content from lokasi l left join kelaskamar kk on l.idlokasi=kk.idlokasi left join kelas k on kk.idkelas=k.idkelas and k.isdeleted=0 where l.isdeleted=0 and l.idlokasi not in (select idlokasi from kamar where statusbed<>1) and l.lokasitype=22 and l.iddepartment in (select value from sys_appsetting where variable in ('IDNICUDept','IDPICUDept')) order by k.kelas asc,l.nama asc", "ruang")
            lueRuang.Properties.DataSource = sqls.dataTable("ruang")
            lueRuang.Properties.DisplayMember = "content"
            lueRuang.Properties.ValueMember = "id"
            lueRuang.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            lueRuang.Properties.BestFit()
            lueRuang.EditValue = Nothing

            If sqls.getDataSet("ruang") = 0 Then
                dizMsgbox("Lokasi tidak ditemukan" & vbCrLf & "Lokasi harap entry dulu", dizMsgboxStyle.Peringatan, Me)
                pExit_Click(Me, Nothing)
                Exit Sub
            End If
            btnDataRM.Enabled = True

            teNoRegistrasi.Text = "XXX/XXX/REG/" & Format(nowTime, "yyyyMMdd") & "/XXXX"

            tlpField.Enabled = True
            btnNew.Enabled = True
            btnSave.Enabled = True
        End If
        isFromLoad = False
    End Sub

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
                lblAsalPx4.Text = ""
                lblAsalPx4.Visible = False
                lueAsalPx4.Visible = False
                lueAsalPx4.EditValue = Nothing

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

            lblAsalPx3.Text = ""
            lblAsalPx3.Visible = False
            lueAsalPx3.Visible = False
            lueAsalPx3.EditValue = CLng(0) 'Nothing
            lblAsalPx4.Text = ""
            lblAsalPx4.Visible = False
            lueAsalPx4.Visible = False
            lueAsalPx4.EditValue = CLng(0)

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
        ElseIf lueAsalPx2.EditValue = CLng(2) Then
            lblAsalPx3.Text = "Rumah Sakit/Klinik *3"
            lblAsalPx3.Visible = True
            lueAsalPx3.Visible = True
            lueAsalPx3.EditValue = Nothing
            lblAsalPx4.Text = ""
            lblAsalPx4.Visible = False
            lueAsalPx4.Visible = False
            lueAsalPx4.EditValue = Nothing

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
            lblAsalPx4.Text = ""
            lblAsalPx4.Visible = False
            lueAsalPx4.Visible = False
            lueAsalPx4.EditValue = CLng(0)
        Else
            If lueAsalPx2.EditValue <> CLng(2) Then
                lblAsalPx4.Text = ""
                lblAsalPx4.Visible = False
                lueAsalPx4.Visible = False
                lueAsalPx4.EditValue = 0
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
                lueAsalPx4.Properties.BestFit()
                If mysqls.getDataSet("asalpx4") = 0 Then
                    dizMsgbox("Dokter tidak ditemukan" & vbCrLf & "Dokter harap entry dulu", dizMsgboxStyle.Peringatan, Me)
                    pExit_Click(Me, Nothing)
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private idselect As String = 0
    Private strQuery As String = ""
    Private cnt As Integer = 0
    Private cntdept As Integer = 0
    Private cntdokter As Integer = 0

    Private Sub SearchRM_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        'If sender Is lnkNama Then
        '    If teNama.Text.Replace(" ", "") = "" Then
        '        dizMsgbox("Tidak disarankan melakukan pencarian seluruh Pasien", dizMsgboxStyle.Info, "Info", Me)
        '        Exit Sub
        '    End If
        'End If

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
        Dim strfilter As String = ""

        If sender.name = "lnkNoRM" Then
            strQuery &= " and r.rekammedisno<>0 and dbo.fFormatNoRM(r.rekammedisno) = '" & teNoRM.Text & "'"
            strfilter = teNoRM.Text '.Replace("-", "").TrimStart(New Char() {"0"})
        ElseIf sender.name = "lnkNama" Then
            strQuery &= " and r.rekammedisno<>0 and r.nama like '%" & teNama.Text & "%'"
            strfilter = teNama.Text
        ElseIf sender.name = "lnkTanggalLahir" Then
            strQuery &= " and r.rekammedisno<>0 and convert(varchar,r.tanggallahir,105) like '%" & Format(CDate(deTanggalLahir.EditValue), "dd-MM-yyyy") & "%'"
            strfilter = Format(CDate(deTanggalLahir.EditValue), "dd-MM-yyyy")
        End If
        strQuery &= " order by r.rekammedisno asc"

        'Dim loadScr As New frmLoading()
        'splashClosed = False
        'loadScr.Show(Me)
        'loadScr.BringToFront()
        'Application.DoEvents()
        'Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery(strQuery, "searchpasien")

        'Me.Cursor = Cursors.Default
        'splashClosed = True

        Dim cari As New frmSearch(sqls.dataSet, "searchpasien", "ID")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            idselect = cari.GetIDSelectData

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
        If Asc(e.KeyChar) = 13 Then
            'SearchRM_LinkClicked(lnkNoRM, Nothing)
        End If
    End Sub

    Private Sub teNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teNama.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'SearchRM_LinkClicked(lnkNama, Nothing)
        End If
    End Sub

    Private Sub Tanggal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles deTanggalLahir.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'SearchRM_LinkClicked(lnkTanggalLahir, Nothing)
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

    Private Sub btnNewPatient_Click(sender As Object, e As EventArgs)
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

    Private Function checkkamar(idlokasi As String) As Boolean
        Dim retval As Boolean = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select a.* from (select distinct l.idlokasi as id,k.kelas,l.nama as content from lokasi l left join kelaskamar kk on l.idlokasi=kk.idlokasi left join kelas k on kk.idkelas=k.idkelas and k.isdeleted=0 where l.isdeleted=0 and l.idlokasi not in (select idlokasi from kamar where statusbed<>1) and l.lokasitype=22 and l.iddepartment in (select value from sys_appsetting where variable in ('IDNICUDept','IDPICUDept'))) a where a.id='" & idlokasi & "'", "cek")
        If sqls.getDataSet("cek") > 0 Then
            retval = True
        End If
        Return retval
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If idselectparent = "0" Then
            dizMsgbox("Registrasi Induk belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If lueParamedis.EditValue Is Nothing Then
            dizMsgbox("DPJP belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If lueParamedisCase.EditValue Is Nothing Then
            dizMsgbox("Case Manager belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        'If lueSpesialisCase.EditValue Is Nothing Then
        '    dizMsgbox("Case Manager belum dipilih", dizMsgboxStyle.Peringatan, Me)
        '    Exit Sub
        'End If
        If checkEntry() = False Then
            dizMsgbox("Isian belum benar", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If checkkamar(lueRuang.EditValue) = False Then
            dizMsgbox("Ruang tidak tersedia", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim isPindah As Boolean = False
        If dizMsgbox("Pasien pindah kamar ke PICU/NICU?" & vbCrLf & "Jika tidak pindah, billing akan berjalan pada PICU", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            isPindah = True
        End If

        Dim pair As KeyValuePair(Of String, String) = generateno2(idunit, iddept, "Registrasi", False)
        Dim idtrans As String = pair.Key
        teNoRegistrasi.Text = pair.Value

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idregistrasi from registrasi where convert(varchar,createddate,105)=convert(varchar,getdate(),105) and  registrasistatus=0 and iddepartment='" & iddept & "' and idrekammedis='" & teNoRM.Tag & "'", "cekreg")
        If sqls.getDataSet("cekreg") > 0 Then
            dizMsgbox("Masih ada registrasi yang aktif", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
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

        idData = GenerateGUID()
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim remarks As String = "-"

        field.AddRange(New String() {"idregistrasi", "transactiontype", "idjadwalsesi", "idcompany", "idregistrasiparent", "iddepartment", "idunit", "idrekammedis", "idlokasi", "idkelas", "iddokterruangan", "idspesialisruangan", "iddoktercase", "idspesialiscase", "registrasino", "kunjunganke", "kunjungandokterke", "kunjungandepartmentke", "asalpx", "asalpx2", "asalrujukan", "iddokterrujukan", "jeniskunjungan", "registrasistatus", "remarks", "payertype", "idpayer", "idasuransi", "ishamil", "isdeleted", "deletereason", "createdby"})
        value.AddRange(New Object() {idData, idtrans, 0, idcomp, CStr(teNoRegistrasiInduk.Tag), iddept, idunit, CStr(teNoRM.Tag), lueRuang.EditValue, lueKelas.EditValue, lueParamedis.EditValue, If(lueSpesialis.EditValue, 0), lueParamedisCase.EditValue, If(lueSpesialisCase.EditValue, 0), teNoRegistrasi.Text, cnt + 1, cntdokter + 1, cntdept + 1, If(lueAsalPx.EditValue, 0), If(lueAsalPx2.EditValue, 0), If(lueAsalPx3.EditValue, 0), If(lueAsalPx4.EditValue, 0), 0, 0, remarks, lueJenisPembayar.EditValue, If(luePayer.EditValue, 0), If(lueAsuransi.EditValue, 0), lueHamil.EditValue, 0, "-", userid})

        Dim dtsetsqls As New dtsetSQLS(dbstring)
        Dim cek As Boolean = dtsetsqls.datasetSave("registrasi", idData, field, value, False)
        If cek = True Then
            'Dim fslip As New List(Of String)
            'Dim vslip As New List(Of Object)
            'fslip.Add("@idreg")
            'vslip.Add(idData)
            'sqls = New SQLs(dbstring)
            'sqls.CallSP("spRegistrasiSlip", "rslip", fslip, vslip)
            'Dim strttl As String = sqls.getDataSet("rslip", 0, "regno")
            'Dim strmsg As String = sqls.getDataSet("rslip", 0, "norm") & " (" & sqls.getDataSet("rslip", 0, "sex") & ")" & vbCrLf & sqls.getDataSet("rslip", 0, "namapasien") & vbCrLf & sqls.getDataSet("rslip", 0, "paramedis") & vbCrLf & sqls.getDataSet("rslip", 0, "spesialis")

            'Dim idnotif As String
            'Dim fnotif As New List(Of String)
            'Dim vnotif As New List(Of Object)

            'fnotif.Clear()
            'vnotif.Clear()
            'idnotif = GenerateGUID()
            'fnotif.AddRange(New String() {"idnotifications", "kode", "judul", "konten", "frmname", "tableid", "tablename", "tablecolumnid", "tablecolumndate", "tablecolumnflag", "tablecolumniduser"})
            'vnotif.AddRange(New Object() {idnotif, "REGB", strttl, strmsg, "-", idData, "registrasi", "idregistrasi", "prepareddate", "-", "preparedby"})
            'dtsetsqls = New dtsetSQLS(dbstring)
            'dtsetsqls.datasetSave("sys_notifications", idnotif, fnotif, vnotif, False)

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

            If isPindah = True Then
                pindahKamar(idselectparent)
            End If

            Dim checkin As Date = nowTime
            sqls.DMLQuery("select idkamar from kamar where idlokasi='" & lueRuang.EditValue & "'", "getidkamar")
            Dim idkamar As String = "-1"
            If sqls.getDataSet("getidkamar") > 0 Then
                idkamar = sqls.getDataSet("getidkamar", 0, "idkamar")
            Else
                idkamar = GenerateGUID()
            End If
            dtsetsqls = New dtsetSQLS(dbstring)
            field = New List(Of String)
            value = New List(Of Object)
            field.Clear()
            value.Clear()
            field.AddRange(New String() {"idkamar", "idlokasi", "priority", "idregistrasi", "checkin", "statusbed", "createdby", "idcompany"})
            value.AddRange(New Object() {idkamar, lueRuang.EditValue, 0, idData, checkin, 5, userid, idcomp})
            dtsetsqls.datasetSave("kamar", idkamar, field, value, False)

            idtmp = GenerateGUID()
            dtsetsqls = New dtsetSQLS(dbstring)
            field = New List(Of String)
            value = New List(Of Object)
            field.Clear()
            value.Clear()
            field.AddRange(New String() {"idregistrasikamar", "idlokasi", "idregistrasi", "checkin", "createdby", "idcompany"})
            value.AddRange(New Object() {idtmp, lueRuang.EditValue, idData, checkin, userid, idcomp})
            dtsetsqls.datasetSave("registrasikamar", idtmp, field, value, False)

            idtmp = GenerateGUID()
            dtsetsqls = New dtsetSQLS(dbstring)
            field = New List(Of String)
            value = New List(Of Object)
            field.Clear()
            value.Clear()
            field.AddRange(New String() {"idregistrasidpjp", "idregistrasi", "idparamedis", "idspesialis", "dpjptype", "remarks", "createdby", "idcompany"})
            value.AddRange(New Object() {idtmp, idselect, lueParamedis.EditValue, If(lueSpesialis.EditValue, 0), 1, "", userid, idcomp})
            dtsetsqls.datasetSave("registrasidpjp", idtmp, field, value, False)

            idtmp = GenerateGUID()
            dtsetsqls = New dtsetSQLS(dbstring)
            field = New List(Of String)
            value = New List(Of Object)
            field.Clear()
            value.Clear()
            field.AddRange(New String() {"idregistrasidpjp", "idregistrasi", "idparamedis", "idspesialis", "dpjptype", "remarks", "createdby", "idcompany"})
            value.AddRange(New Object() {idtmp, idselect, lueParamedisCase.EditValue, If(lueSpesialisCase.EditValue, 0), 3, "", userid, idcomp})
            dtsetsqls.datasetSave("registrasidpjp", idtmp, field, value, False)

            Dim nodata As String = sqls.getDataSet("getid", 0, "registrasino")
            dizMsgbox("Registrasi telah tersimpan", dizMsgboxStyle.Info, Me)
        End If
        isFromLoad = True
        btnNew_Click(btnNew, Nothing)
    End Sub

    Private Sub pindahKamar(idregasal As String)
        If idregasal = "" Then
            dizMsgbox("Registrasi Asal belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim retval As Boolean = True
        Dim idkamarasal As String = "-1"
        Dim idlokasiasal As String = "-1"
        Dim idregkamarasal As String = "-1"
        Dim sqls As New SQLs(dbstring)

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        sqls.DMLQuery("Select idlokasi from registrasi where idregistrasi='" & idregasal & "'", "getidlokasi")
        If sqls.getDataSet("getidlokasi") > 0 Then
            idlokasiasal = sqls.getDataSet("getidlokasi", 0, "idlokasi")
        End If
        sqls.DMLQuery("Select idkamar from kamar where idregistrasi='" & idregasal & "'", "getidkamar")
        If sqls.getDataSet("getidkamar") > 0 Then
            idkamarasal = sqls.getDataSet("getidkamar", 0, "idkamar")
        End If
        sqls.DMLQuery("select idregistrasikamar from registrasikamar where idlokasi='" & idlokasiasal & "' and idregistrasi='" & idregasal & "'", "getidregkamar")
        idregkamarasal = sqls.getDataSet("getidregkamar", 0, "idregistrasikamar")

        Dim dtsqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        dtsqls = New dtsetSQLS(dbstring)
        field = New List(Of String)
        value = New List(Of Object)
        field.AddRange(New String() {"idkamar", "idregistrasi", "checkin", "checkout", "statusbed", "updatedby", "updateddate", "idcompany"})
        value.AddRange(New Object() {idkamarasal, 0, DBNull.Value, nowTime, 2, userid, nowTime, idcomp})
        retval = dtsqls.datasetSave("kamar", idkamarasal, field, value, False)
        If retval = False Then
            dizMsgbox("Update Kamar Lama Gagal", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        dtsqls = New dtsetSQLS(dbstring)
        field = New List(Of String)
        value = New List(Of Object)
        field.AddRange(New String() {"idregistrasikamar", "idregistrasi", "checkout", "updatedby", "updateddate"})
        value.AddRange(New Object() {idregkamarasal, idregasal, nowTime, userid, nowTime})
        retval = dtsqls.datasetSave("registrasikamar", idregkamarasal, field, value, False)
        If retval = False Then
            dizMsgbox("Update Registrasi Kamar Gagal", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        If retval = True Then
            dizMsgbox("Pindah Kamar berhasil dilakukan", dizMsgboxStyle.Info, Me)
        End If
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
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select s.nama as content,s.idspesialis as id from spesialis s left join paramedisspesialis ps on s.idspesialis=ps.idspesialis where ps.idparamedis='" & lueParamedis.EditValue & "'", "spesialis")
        lueSpesialis.Properties.DataSource = sqls.dataTable("spesialis")
        lueSpesialis.Properties.DisplayMember = "content"
        lueSpesialis.Properties.ValueMember = "id"
        lueSpesialis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueSpesialis.Properties.BestFit()
        lueSpesialis.EditValue = Nothing

        If sqls.getDataSet("spesialis") = 1 Then
            lueSpesialis.EditValue = sqls.getDataSet("spesialis", 0, "id")
        End If
    End Sub

    Private idkelas As String = 0
    Private iddept As String = 0
    Private kddept As String = ""
    Private idunit As String = 0
    Private kdunit As String = ""
    Private idtrans As String = 0
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
            idkelas = 0
            iddept = 0
            kddept = ""
            idunit = 0
            kdunit = ""
            idtrans = 0
            jenistrans = ""
            formatstring = ""
            formatperiode = ""
            teNoRegistrasi.Text = "XXX/XXX/REG/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
            lueKelas.EditValue = Nothing
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select l.iddepartment,l.idunit,u.kode as kodeunit,d.kode as kodedept,k.idkelas,k.kelas from lokasi l left join kelaskamar kk on l.idlokasi=kk.idlokasi and l.isdeleted=0 left join kelas k on kk.idkelas=k.idkelas and k.isdeleted=0 left join unit u on l.idunit=u.idunit left join department d on l.iddepartment=d.iddepartment where l.idlokasi='" & lueRuang.EditValue & "'", "getid")
        If sqls.getDataSet("getid") > 0 Then
            iddept = sqls.getDataSet("getid", 0, "iddepartment")
            idunit = sqls.getDataSet("getid", 0, "idunit")
            idkelas = sqls.getDataSet("getid", 0, "idkelas")
            lueKelas.EditValue = sqls.getDataSet("getid", 0, "idkelas")

            Dim pair As KeyValuePair(Of String, String) = generateno2(idunit, iddept, "Registrasi", True)
            Dim idtrans As String = pair.Key
            teNoRegistrasi.Text = pair.Value
        Else
            lueKelas.EditValue = Nothing
        End If
    End Sub

    'Private Function generateNO(jenisregistrasi As String, ByVal prefix As String, formatperiode As String) As String
    '    Dim retval As String = ""
    '    Dim mysqls As New SQLs(dbstring)
    '    Dim tblname As String = jenisregistrasi & Format(nowTime, "yyyyMMdd")
    '    mysqls.DMLQuery("select idgeneratenumber,tablename,formatstring,lastnumber,positionnumber,digitnumber from sys_generatenumber where tablename='" & tblname & "'", "GetLast")
    '    Dim idgen As Integer = -1
    '    Dim formatStr As String = ""
    '    Dim currid As Integer = 0
    '    Dim currStrId As String = ""
    '    Dim posnumber As String = ""
    '    Dim lenStr As String = ""
    '    Dim lenId As Integer = 0

    '    If mysqls.getDataSet("GetLast") = 0 Then
    '        formatStr = prefix & Format(nowTime, formatperiode) & "/"
    '        currid = 1
    '        posnumber = "Belakang"
    '        lenId = 4
    '    Else
    '        idgen = mysqls.getDataSet("GetLast", 0, "idgeneratenumber")

    '        formatStr = mysqls.getDataSet("GetLast", 0, "formatstring")
    '        currid = CInt(mysqls.getDataSet("GetLast", 0, "lastnumber")) + 1
    '        posnumber = mysqls.getDataSet("GetLast", 0, "positionnumber")
    '        lenId = CInt(mysqls.getDataSet("GetLast", 0, "digitnumber"))
    '    End If
    '    For i As Integer = 0 To lenId - 1
    '        If i = 0 Then
    '            lenStr = "0"
    '        Else
    '            lenStr &= "#"
    '        End If
    '    Next
    '    currStrId = Format(currid, lenStr)

    '    If posnumber = "Belakang" Then
    '        retval = formatStr & currStrId
    '    ElseIf posnumber = "Depan" Then
    '        retval = currStrId & formatStr
    '    End If

    '    Dim dtsave As New dtsetSQLS(dbstring)
    '    Dim field As New List(Of String)
    '    Dim value As New List(Of Object)
    '    field.AddRange(New String() {"idgeneratenumber", "tablename", "formatstring", "lastnumber", "positionnumber", "digitnumber"})
    '    value.AddRange(New String() {idgen, tblname, formatStr, currid, posnumber, lenId})
    '    dtsave.datasetSave("sys_generatenumber", idgen, field, value, False)

    '    Return retval
    'End Function

    Private Sub PrintPageHandler(ByVal sender As Object,
       ByVal args As Printing.PrintPageEventArgs)
    End Sub

    Private Sub PreviewForm_Load(sender As Object, ByVal e As EventArgs)
        Dim frm As DevExpress.XtraPrinting.Preview.PrintPreviewFormEx = CType(sender, DevExpress.XtraPrinting.Preview.PrintPreviewFormEx)
        frm.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.Scale, New Object() {1.0F})
    End Sub

    Private Sub btnTunggakan_Click(sender As Object, e As EventArgs)
        dizMsgbox("Menu belum tersedia", dizMsgboxStyle.Info, Me)
    End Sub

    Private Sub btnAppointment_Click(sender As Object, e As EventArgs)
        dizMsgbox("Menu belum tersedia", dizMsgboxStyle.Info, Me)
    End Sub

    Private Sub btnDataRM_Click(sender As Object, e As EventArgs) Handles btnDataRM.Click
        dizMsgbox("Menu belum tersedia", dizMsgboxStyle.Info, Me)
    End Sub

    Private idselectparent As String = "0"
    Private iddokterparent As String = "0"
    Private Sub lnkNoRegistrasiInduk_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkNoRegistrasiInduk.LinkClicked
        Dim sqls As New SQLs(dbstring)

        sqls.DMLQuery("select r.idregistrasi,convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as 'Tgl Registrasi',r.registrasino as 'No Registrasi',pm.nama as 'Tenaga Medis',dbo.fformatnorm(rm.rekammedisno) as 'No RM',rm.nama as 'Nama Pasien',jk.generalcode as 'Jenis Kelamin',convert(varchar,rm.tanggallahir,105) as 'Tgl Lahir',dbo.fUmurRegister(rm.tanggallahir,r.registrasidate) as 'Umur',kw.wilayah as 'Kewarganegaraan' from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' left join wilayah kw on rm.kewarganegaraan=kw.idwilayah  left join paramedis pm on r.iddokterruangan=pm.idparamedis where r.isdeleted=0 and ((convert(varchar,r.registrasidate,105) in ('" & Format(nowTime, "dd-MM-yyyy") & "','" & Format(nowTime.AddDays(-1), "dd-MM-yyyy") & "') and r.registrasistatus in (0,1,4,7) and r.transactiontype in (select idtransactiontype from transactiontype where kodetransaksi='REG' and iddepartment in (select [value] from sys_appsetting where variable in ('idigddept','IDIRJDept')))) or (r.registrasistatus=0 and r.transactiontype in (select idtransactiontype from transactiontype where kodetransaksi='REG' and iddepartment in (select [value] from sys_appsetting where variable in ('idirnadept','idibsdept','IDVKDept'))))) and rm.rekammedisno<>0 and r.idregistrasi not in (select r.idregistrasiparent from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis where convert(varchar,r.registrasidate,105) in ('" & Format(nowTime, "dd-MM-yyyy") & "','" & Format(nowTime.AddDays(-1), "dd-MM-yyyy") & "') and r.isdeleted=0 and r.transactiontype in (select idtransactiontype from transactiontype where kodetransaksi='REG' and iddepartment in (select [value] from sys_appsetting where variable in ('IDPICUDept','IDNICUDept'))) and rm.rekammedisno<>0) order by r.registrasidate desc", "search")
        Dim cari As New frmSearch(sqls.dataSet, "search", "idregistrasi")
        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            idselectparent = CStr(cari.GetIDSelectData)
            sqls.DMLQuery("select r.idrekammedis,r.asalpx,r.asalpx2,r.asalrujukan,r.iddokterrujukan,r.iddepartment,r.idunit,d.department,r.registrasino,convert(varchar,r.registrasidate,105) + ' '+convert(varchar,r.registrasidate,108) as registrasidate,ha.generalcode as hamil,r.iddokterruangan,r.idspesialisruangan,r.iddoktercase,r.idspesialiscase,r.payertype,r.idpayer,r.idasuransi from registrasi r left join department d on d.iddepartment=r.iddepartment left join sys_generalcode ha on r.ishamil=ha.idgeneral and ha.gctype='ISHAMIL' where r.idregistrasi='" & idselectparent & "'", "getidrm")
            teNoRegistrasiInduk.Text = sqls.getDataSet("getidrm", 0, "registrasino")
            teNoRegistrasiInduk.Tag = idselectparent
            teDeptInduk.Text = sqls.getDataSet("getidrm", 0, "department")
            iddokterparent = sqls.getDataSet("getidrm", 0, "iddokterruangan")
            idselect = sqls.getDataSet("getidrm", 0, "idrekammedis")
            lueParamedis.EditValue = sqls.getDataSet("getidrm", 0, "iddokterruangan")
            lueSpesialis.EditValue = sqls.getDataSet("getidrm", 0, "idspesialisruangan")
            lueParamedisCase.EditValue = sqls.getDataSet("getidrm", 0, "iddoktercase")
            lueSpesialisCase.EditValue = sqls.getDataSet("getidrm", 0, "idspesialiscase")
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
            teNoRM.Tag = sqls.getDataSet("getpasienreg", 0, "idrekammedis")
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
        End If
    End Sub

    Private Sub btnCetakGelang_Click(sender As Object, e As EventArgs) Handles btnCetakGelang.Click
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select r.idregistrasi,convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as 'Tgl Registrasi',r.registrasino as 'No Registrasi',pm.nama as 'Tenaga Medis',dbo.fformatnorm(rm.rekammedisno) as 'No RM',rm.nama as 'Nama Pasien',jk.generalcode as 'Jenis Kelamin',convert(varchar,rm.tanggallahir,105) as 'Tgl Lahir',dbo.fUmurRegister(rm.tanggallahir,r.registrasidate) as 'Umur',kw.wilayah as 'Kewarganegaraan' from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' left join wilayah kw on rm.kewarganegaraan=kw.idwilayah  left join paramedis pm on r.iddokterruangan=pm.idparamedis where r.registrasistatus=0 and rm.rekammedisno<>0 and r.iddepartment=(select top 1 [value] from sys_appsetting where variable='idirnadept') order by r.registrasidate desc", "search")
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

            Dim selectWB As New frmWristbandSelect
            tambahChild(selectWB)
            selectWB.ShowDialog()
            If selectWB.getStringPilih = "Dewasa" Then
                If idjnskelamin = "0" Then
                    Dim sharename As String = getPrinter("WRBAF")
                    If sharename <> "" Then
                        cetakWristband(lstdata, sharename)
                    Else
                        Dim pd As New PrintDialog
                        If pd.ShowDialog() = DialogResult.OK Then
                            cetakWristband(lstdata, pd.PrinterSettings.PrinterName)
                        End If
                    End If
                Else
                    Dim sharename As String = getPrinter("WRBAM")
                    If sharename <> "" Then
                        cetakWristband(lstdata, sharename)
                    Else
                        Dim pd As New PrintDialog
                        If pd.ShowDialog() = DialogResult.OK Then
                            cetakWristband(lstdata, pd.PrinterSettings.PrinterName)
                        End If
                    End If
                End If
            ElseIf selectWB.getStringPilih = "Anak" Then
                Dim sharename As String = getPrinter("WRBB")
                If sharename <> "" Then
                    cetakWristband(lstdata, sharename)
                Else
                    Dim pd As New PrintDialog
                    If pd.ShowDialog() = DialogResult.OK Then
                        cetakWristband(lstdata, pd.PrinterSettings.PrinterName)
                    End If
                End If
            End If
            'cetakWristband(lstdata, "")
        End If
    End Sub

    Private Sub btnLabel_Click(sender As Object, e As EventArgs) Handles btnLabel.Click
        Dim radsel10 As New frmSelectLabel10("PICU")
        radsel10.ShowDialog(Me)
    End Sub

    Private Sub lueParamedisCase_EditValueChanged(sender As Object, e As EventArgs) Handles lueParamedisCase.EditValueChanged
        If lueParamedisCase.EditValue Is Nothing Then
            lueSpesialisCase.Properties.DataSource = Nothing
            lueSpesialisCase.EditValue = Nothing
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select s.nama as content,s.idspesialis as id from spesialis s left join paramedisspesialis ps on s.idspesialis=ps.idspesialis where ps.idparamedis='" & lueParamedisCase.EditValue & "'", "spesialis")
        lueSpesialisCase.Properties.DataSource = sqls.dataTable("spesialis")
        lueSpesialisCase.Properties.DisplayMember = "content"
        lueSpesialisCase.Properties.ValueMember = "id"
        lueSpesialisCase.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueSpesialisCase.Properties.BestFit()
        lueSpesialisCase.EditValue = Nothing

        If sqls.getDataSet("spesialis") = 1 Then
            lueSpesialisCase.EditValue = sqls.getDataSet("spesialis", 0, "id")
        End If
    End Sub

    Private Sub btnMonRegister_Click(sender As Object, e As EventArgs) Handles btnMonRegister.Click
        formTitle = "Monitoring Registrasi"
        Dim frmMon As New frmMonRegisterNICU
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

    Private Sub btnStatusRuang_Click(sender As Object, e As EventArgs) Handles btnStatusRuang.Click
        formTitle = "Status Kamar"
        Dim frmMon As New frmMonKamar
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

    Private Sub btnPindahKamar_Click(sender As Object, e As EventArgs) Handles btnPindahKamar.Click
        formTitle = "Pindah Kamar"
        Dim frmMon As New frmKamarPindahPICU
        tambahChild(frmMon)
        frmMon.StartPosition = FormStartPosition.CenterScreen
        frmMon.pMinimize.Enabled = False
        frmMon.pMaximize.Enabled = False
        frmMon.tlpForm.RowCount = 4
        frmMon.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        frmMon.ShowDialog(Me)
        formTitle = Me.lblTitle.Text
    End Sub

    Private Sub btnHistKamar_Click(sender As Object, e As EventArgs) Handles btnHistKamar.Click
        formTitle = "Riwayat Kamar"
        Dim frmMon As New frmMonHistoriKamar
        tambahChild(frmMon)
        frmMon.StartPosition = FormStartPosition.CenterScreen
        frmMon.pMinimize.Enabled = False
        frmMon.pMaximize.Enabled = False
        frmMon.tlpForm.RowCount = 4
        frmMon.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        frmMon.ShowDialog(Me)
        formTitle = Me.lblTitle.Text
    End Sub

    Private Sub btnSwap_Click(sender As Object, e As EventArgs)
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

    Private Sub btnRegStatus_Click(sender As Object, e As EventArgs) Handles btnRegStatus.Click
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select variable,value from sys_appsetting where variable in ('IDNICUDept','IDPICUDept')", "getid")
        Dim rs As New frmRegistrasiUpdate(sqls.getDataSet("getid", 0, "value").ToString)
        tambahChild(rs)
        rs.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        rs.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width - 100, Screen.PrimaryScreen.WorkingArea.Height - 100)
        rs.StartPosition = FormStartPosition.CenterScreen
        rs.tlpForm.RowCount = 4
        rs.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        rs.ShowDialog(Me)
    End Sub

    Private Sub btnAntarDept_Click(sender As Object, e As EventArgs) Handles btnAntarDept.Click
        formTitle = "Pindah Kamar Antar Dept"
        Dim frmMon As New frmKamarPindahDept("IDNICUDept,IDPICUDept")
        tambahChild(frmMon)
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

    Private Sub btnAlihDPJP_Click(sender As Object, e As EventArgs) Handles btnAlihDPJP.Click
        formTitle = "Alih DPJP"
        Dim frmMon As New frmAlihDPJP("IDPICUDept,IDNICUDept")
        tambahChild(frmMon)
        frmMon.StartPosition = FormStartPosition.CenterScreen
        frmMon.pMinimize.Enabled = False
        frmMon.pMaximize.Enabled = False
        frmMon.tlpForm.RowCount = 4
        frmMon.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        frmMon.ShowDialog(Me)
        formTitle = Me.lblTitle.Text
    End Sub

End Class