Public Class frmPasienSimple
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

    Private senderWilayah As Object
    Private senderkWilayah As Object
    Private Sub loadLOV()
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='HAMBATANKOM' order by generalcode asc", "hambatan")
        lueHambatan.Properties.DataSource = mysqls.dataTable("hambatan")
        lueHambatan.Properties.DisplayMember = "content"
        lueHambatan.Properties.ValueMember = "id"

        mysqls.DMLQuery("select idgeneral as id, generalcode as content,priority from sys_generalcode where gctype='MARITALSTATUS' order by generalcode asc", "maritalstatus")
        luePernikahan.Properties.DataSource = mysqls.dataTable("maritalstatus")
        luePernikahan.Properties.DisplayMember = "content"
        luePernikahan.Properties.ValueMember = "id"

        mysqls.DMLQuery("select idgeneral as id, generalcode as content,priority from sys_generalcode where gctype='FAMILYTYPE' order by priority asc", "familytype")
        lueJenisKeluarga.Properties.DataSource = mysqls.dataTable("familytype")
        lueJenisKeluarga.Properties.DisplayMember = "content"
        lueJenisKeluarga.Properties.ValueMember = "id"

        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ASALPX' order by idgeneral asc", "asalpx1")
        lueAsalPx.Properties.DataSource = mysqls.dataTable("asalpx1")
        lueAsalPx.Properties.DisplayMember = "content"
        lueAsalPx.Properties.ValueMember = "id"
        If mysqls.getDataSet("asalpx1") = 0 Then
            dizMsgbox("Asal Pasien tidak ditemukan" & vbCrLf & "Asal Pasien harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where levelwilayah=1 order by idwilayah asc", "kwn")
        lueKewarganegaraan.Properties.DataSource = mysqls.dataTable("kwn")
        lueKewarganegaraan.Properties.DisplayMember = "content"
        lueKewarganegaraan.Properties.ValueMember = "id"
        If mysqls.getDataSet("kwn") = 0 Then
            dizMsgbox("Kewarganegaraan tidak ditemukan" & vbCrLf & "Kewarganegaraan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idwilayah as id,wilayah as content from wilayah where isdeleted=0 order by wilayah asc", "kota")
        'mysqls.DMLQuery("if (select count(k.idwilayah) from wilayah p left join wilayah k on p.idwilayah=k.idparent where k.levelwilayah=3)=0 begin select idwilayah as id, wilayah as content from wilayah where levelwilayah=0 order by wilayah asc end else begin select k.idwilayah as id, k.wilayah as content from wilayah p left join wilayah k on p.idwilayah=k.idparent where k.levelwilayah=3 order by k.wilayah asc end", "kota")
        lueTempatLahir.Properties.DataSource = mysqls.dataTable("kota")
        lueTempatLahir.Properties.DisplayMember = "content"
        lueTempatLahir.Properties.ValueMember = "id"
        If mysqls.getDataSet("kota") = 0 Then
            dizMsgbox("Tempat Lahir tidak ditemukan" & vbCrLf & "Tempat Lahir harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='PENDIDIKAN'", "pendidikan")
        luePendidikan.Properties.DataSource = mysqls.dataTable("pendidikan")
        luePendidikan.Properties.DisplayMember = "content"
        luePendidikan.Properties.ValueMember = "id"
        If mysqls.getDataSet("pendidikan") = 0 Then
            dizMsgbox("Pendidikan tidak ditemukan" & vbCrLf & "Pendidikan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='PEKERJAAN'", "pekerjaan")
        luePekerjaan.Properties.DataSource = mysqls.dataTable("pekerjaan")
        luePekerjaan.Properties.DisplayMember = "content"
        luePekerjaan.Properties.ValueMember = "id"
        If mysqls.getDataSet("pekerjaan") = 0 Then
            dizMsgbox("Pekerjaan tidak ditemukan" & vbCrLf & "Pekerjaan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='RELIGION'", "agama")
        lueAgama.Properties.DataSource = mysqls.dataTable("agama")
        lueAgama.Properties.DisplayMember = "content"
        lueAgama.Properties.ValueMember = "id"
        If mysqls.getDataSet("agama") = 0 Then
            dizMsgbox("Agama tidak ditemukan" & vbCrLf & "Agama harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='GOLONGANDARAH'", "goldar")
        lueGolonganDarah.Properties.DataSource = mysqls.dataTable("goldar")
        lueGolonganDarah.Properties.DisplayMember = "content"
        lueGolonganDarah.Properties.ValueMember = "id"
        If mysqls.getDataSet("goldar") = 0 Then
            dizMsgbox("Golongan Darah tidak ditemukan" & vbCrLf & "Golongan Darah harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='RHESUS'", "rhesus")
        lueRhesus.Properties.DataSource = mysqls.dataTable("rhesus")
        lueRhesus.Properties.DisplayMember = "content"
        lueRhesus.Properties.ValueMember = "id"
        If mysqls.getDataSet("rhesus") = 0 Then
            dizMsgbox("Rhesus tidak ditemukan" & vbCrLf & "Rhesus harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='CARDTYPE' and idreff=1 order by priority asc", "cardtype")
        lueJenisKartu.Properties.DataSource = mysqls.dataTable("cardtype")
        lueJenisKartu.Properties.DisplayMember = "content"
        lueJenisKartu.Properties.ValueMember = "id"
        If mysqls.getDataSet("cardtype") = 0 Then
            dizMsgbox("Jenis Kartu tidak ditemukan" & vbCrLf & "Jenis Kartu harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='SEXTYPE'", "sex")
        lueJenisKelamin.Properties.DataSource = mysqls.dataTable("sex")
        lueJenisKelamin.Properties.DisplayMember = "content"
        lueJenisKelamin.Properties.ValueMember = "id"
        If mysqls.getDataSet("sex") = 0 Then
            dizMsgbox("Jenis Kelamin tidak ditemukan" & vbCrLf & "Jenis Kelamin harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isdeleted=0 and levelwilayah=1 order by idwilayah asc", "negara")
        lueNegara.Properties.DataSource = mysqls.dataTable("negara")
        lueNegara.Properties.DisplayMember = "content"
        lueNegara.Properties.ValueMember = "id"
        lueNegara.EditValue = Nothing
        If mysqls.getDataSet("negara") = 0 Then
            dizMsgbox("Negara tidak ditemukan" & vbCrLf & "Negara harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        'mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isdeleted=0 and levelwilayah=2 order by wilayah asc", "propinsi")
        'luePropinsi.Properties.DataSource = mysqls.dataTable("propinsi")
        'luePropinsi.Properties.DisplayMember = "content"
        'luePropinsi.Properties.ValueMember = "id"
        'luePropinsi.EditValue = Nothing

        'mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isdeleted=0 and levelwilayah=3 order by wilayah asc", "kabupaten")
        'lueKabupaten.Properties.DataSource = mysqls.dataTable("kabupaten")
        'lueKabupaten.Properties.DisplayMember = "content"
        'lueKabupaten.Properties.ValueMember = "id"
        'lueKabupaten.EditValue = Nothing

        'mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isdeleted=0 and levelwilayah=4 order by wilayah asc", "kecamatan")
        'lueKecamatan.Properties.DataSource = mysqls.dataTable("kecamatan")
        'lueKecamatan.Properties.DisplayMember = "content"
        'lueKecamatan.Properties.ValueMember = "id"
        'lueKecamatan.EditValue = Nothing

        'mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isdeleted=0 and levelwilayah=5 order by wilayah asc", "kelurahan")
        'lueKelurahan.Properties.DataSource = mysqls.dataTable("kelurahan")
        'lueKelurahan.Properties.DisplayMember = "content"
        'lueKelurahan.Properties.ValueMember = "id"
        'lueKelurahan.EditValue = Nothing

        lueKelurahan.EditValue = Nothing
        lueKecamatan.EditValue = Nothing
        lueKabupaten.EditValue = Nothing
        luePropinsi.EditValue = Nothing

        mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isdeleted=0 and levelwilayah=1", "knegara")
        lueKNegara.Properties.DataSource = mysqls.dataTable("knegara")
        lueKNegara.Properties.DisplayMember = "content"
        lueKNegara.Properties.ValueMember = "id"
        If mysqls.getDataSet("knegara") = 0 Then
            dizMsgbox("Negara tidak ditemukan" & vbCrLf & "Negara harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        'mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isdeleted=0 and levelwilayah=2 order by wilayah asc", "kpropinsi")
        'lueKPropinsi.Properties.DataSource = mysqls.dataTable("kpropinsi")
        'lueKPropinsi.Properties.DisplayMember = "content"
        'lueKPropinsi.Properties.ValueMember = "id"
        'lueKPropinsi.EditValue = Nothing

        'mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isdeleted=0 and levelwilayah=3 order by wilayah asc", "kkabupaten")
        'lueKKabupaten.Properties.DataSource = mysqls.dataTable("kkabupaten")
        'lueKKabupaten.Properties.DisplayMember = "content"
        'lueKKabupaten.Properties.ValueMember = "id"
        'lueKKabupaten.EditValue = Nothing

        'mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isdeleted=0 and levelwilayah=4 order by wilayah asc", "kkecamatan")
        'lueKKecamatan.Properties.DataSource = mysqls.dataTable("kkecamatan")
        'lueKKecamatan.Properties.DisplayMember = "content"
        'lueKKecamatan.Properties.ValueMember = "id"
        'lueKKecamatan.EditValue = Nothing

        'mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isdeleted=0 and levelwilayah=5 order by wilayah asc", "kkelurahan")
        'lueKKelurahan.Properties.DataSource = mysqls.dataTable("kkelurahan")
        'lueKKelurahan.Properties.DisplayMember = "content"
        'lueKKelurahan.Properties.ValueMember = "id"
        'lueKKelurahan.EditValue = Nothing

        lueKKelurahan.EditValue = Nothing
        lueKKecamatan.EditValue = Nothing
        lueKKabupaten.EditValue = Nothing
        lueKPropinsi.EditValue = Nothing
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        'lblSearch.Visible = False
        'teSearch.Visible = False
        'btnCari.Visible = False
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        checkFieldMaxLength(dbstring, tlpAsalPasien, "rekammedis")
        checkFieldMaxLength(dbstring, tlpPasien, "rekammedis")
        checkFieldMaxLength(dbstring, tlpAlamat1, "alamat")
        checkFieldMaxLength(dbstring, tlpAlamat2, "alamat")
        checkFieldMaxLength(dbstring, tlpEmail, "email")
        checkFieldMaxLength(dbstring, tlpTelepon, "phone")
        checkFieldMaxLength(dbstring, tlpPasien, "kartu")
        checkFieldMaxLength(dbstring, tlpKeluarga, "keluarga")
        checkFieldMaxLength(dbstring, tlpKeluarga, "phone")
        checkFieldMaxLength(dbstring, tlpKeluargaAlamat1, "alamat")
        checkFieldMaxLength(dbstring, tlpKeluargaAlamat2, "alamat")
        deTanggalLahir.Properties.MaxValue = nowTime
        loadLOV()
        btnNew_Click(Me, Nothing)
    End Sub

    Private isFromLoad As Boolean = True
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        kosongkanIsian(tlpAsalPasien)
        kosongkanIsian(tlpPasien)
        kosongkanIsian(tlpAlamat1)
        kosongkanIsian(tlpAlamat2)
        kosongkanIsian(tlpTelepon)
        kosongkanIsian(tlpEmail)
        kosongkanIsian(tlpKeluarga)
        kosongkanIsian(tlpKeluargaAlamat1)
        kosongkanIsian(tlpKeluargaAlamat2)

        btnNew.Enabled = True
        btnSave.Enabled = True
        btnSavePrint.Enabled = True
        btnDelete.Enabled = False
        btnDelete.Text = "HAPUS"
        statData = statusData.Baru
        idData = "-1"
        idDatachild = "-1"

        ceSalinAlamat.EditValue = False
        lblAsalPx2.Visible = False
        lueAsalPx2.Visible = False
        lueAsalPx2.EditValue = Nothing
        lblAsalPx3.Visible = False
        lueAsalPx3.Visible = False
        lueAsalPx3.EditValue = Nothing
        lblAsalPx4.Visible = False
        lueAsalPx4.Visible = False
        lueAsalPx4.EditValue = Nothing

        If isFromLoad = True Then
            tlpAsalPasien.Enabled = False
            tlpPasien.Enabled = False
            tlpAlamat1.Enabled = False
            tlpAlamat2.Enabled = False
            tlpTelepon.Enabled = False
            tlpEmail.Enabled = False
            tlpKeluarga.Enabled = False
            tlpKeluargaAlamat1.Enabled = False
            tlpKeluargaAlamat2.Enabled = False
            teNoRM.Properties.ReadOnly = True

            btnNew.Enabled = True
            btnSave.Enabled = False
            btnSavePrint.Enabled = False
            senderWilayah = Nothing
            senderkWilayah = Nothing
        Else
            tlpAsalPasien.Enabled = True
            tlpPasien.Enabled = True
            tlpAlamat1.Enabled = True
            tlpAlamat2.Enabled = True
            tlpTelepon.Enabled = True
            tlpEmail.Enabled = True
            tlpKeluarga.Enabled = True
            tlpKeluargaAlamat1.Enabled = True
            tlpKeluargaAlamat2.Enabled = True
            teNoRM.Properties.ReadOnly = False

            senderWilayah = Nothing
            senderkWilayah = Nothing

            Dim selectPelayanan As New frmRMSelect
            tambahChild(selectPelayanan)
            selectPelayanan.ShowDialog()
            If selectPelayanan.getStringPilih = "Dengan NoRM" Then
                Dim sqls As New SQLs(dbstring)
                sqls.DMLQuery("select case when isnull(max(convert(bigint,rekammedisno)),0)=0 then 1 else max(convert(bigint,rekammedisno))+1 end as mrn from rekammedis where isdeleted=0", "lastmrn")
                teNoRM.Text = Format(CLng(sqls.getDataSet("lastmrn", 0, "mrn").ToString.Replace("-", "")), "0#######")
                teNoRM.Properties.ReadOnly = False
                pBody.AutoScrollPosition = New Point(0, 0)

                tlpKeluarga.Enabled = True
                tlpKeluargaAlamat1.Enabled = True
                tlpKeluargaAlamat2.Enabled = True
            ElseIf selectPelayanan.getStringPilih = "Tanpa NoRM" Then
                teNoRM.Text = 0
                teNoRM.Properties.ReadOnly = True
                pBody.AutoScrollPosition = New Point(0, 0)

                tlpKeluarga.Enabled = False
                tlpKeluargaAlamat1.Enabled = False
                tlpKeluargaAlamat2.Enabled = False
            End If
            If selectPelayanan.getStringPilih <> "" Then
                lueAsalPx.Properties.ReadOnly = False
                lueAsalPx.BackColor = entryEnabled
                lueAsalPx2.Properties.ReadOnly = False
                lueAsalPx2.BackColor = entryEnabled
                lueAsalPx3.Properties.ReadOnly = False
                lueAsalPx3.BackColor = entryEnabled
                lueAsalPx4.Properties.ReadOnly = False
                lueAsalPx4.BackColor = entryEnabled
            Else
                lueAsalPx.Properties.ReadOnly = True
                lueAsalPx.BackColor = entryDisabled
                lueAsalPx2.Properties.ReadOnly = True
                lueAsalPx2.BackColor = entryDisabled
                lueAsalPx3.Properties.ReadOnly = True
                lueAsalPx3.BackColor = entryDisabled
                lueAsalPx4.Properties.ReadOnly = True
                lueAsalPx4.BackColor = entryDisabled
            End If
            disposechild(selectPelayanan, Nothing)
        End If
        isFromLoad = False
        isrmaktif = False
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim retval As Boolean = False
        'Dim sqls As New SQLs(dbstring)
        Dim sqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If btnDelete.Text = "HAPUS" Then
            field.AddRange(New String() {"idrekammedis", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 1, userid, nowTime})
            retval = sqls.datasetSave("rekammedis", idData, field, value, False)
            isiLog(userid, dbstring, field, value, "rekammedis")
        ElseIf btnDelete.Text = "AKTIF" Then
            field.AddRange(New String() {"idrekammedis", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 0, userid, nowTime})
            retval = sqls.datasetSave("rekammedis", idData, field, value, False)
            isiLog(userid, dbstring, field, value, "rekammedis")
        End If
        If btnDelete.Text = "HAPUS" Then
            If retval Then
                btnDelete.Text = "AKTIF"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        ElseIf btnDelete.Text = "AKTIF" Then
            If retval Then
                btnDelete.Text = "HAPUS"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        End If
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

    Private Sub teNomorKartu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teNomorKartu.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rNoID) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private exceedMaxNoRM As Long = 0
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If statData = statusData.Baru Then
            If teNoRM.Text <> "00-00-00-00" Then
                Dim sqls As New SQLs(dbstring)
                Dim field2 As New List(Of String)
                Dim value2 As New List(Of Object)
                field2.AddRange(New String() {"@nama", "@nokartu"})
                value2.AddRange(New Object() {teNama.Text.Replace(" ", ""), teNomorKartu.Text})
                sqls.CallSP("spCheckRMbaru", "cek", field2, value2)
                'sqls.DMLQuery("select nama from rekammedis where rekammedisno<>0 and replace(nama,' ','')='" & teNama.Text.Replace(" ", "") & "'", "cek")
                If sqls.getDataSet("cek") = 0 Then
                    idData = "-1"
                Else
                    dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
                    teNama.Focus()
                    Exit Sub
                End If
            End If
        ElseIf statData = statusData.Edit Then
            If teNoRM.Text <> "00-00-00-00" Then
                Dim sqls As New SQLs(dbstring)
                Dim field2 As New List(Of String)
                Dim value2 As New List(Of Object)
                field2.AddRange(New String() {"@nama", "@nokartu", "@idrm"})
                value2.AddRange(New Object() {teNama.Text.Replace(" ", ""), teNomorKartu.Text, idData})
                sqls.CallSP("spCheckRMlama", "cek", field2, value2)
                'sqls.DMLQuery("select nama from rekammedis where isdeleted=0 and rekammedisno<>0 and replace(nama,' ','')='" & teNama.Text.Replace(" ", "") & "' and idrekammedis<>" & idData, "cek")
                If sqls.getDataSet("cek") > 0 Then
                    dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
                    teNama.Focus()
                    Exit Sub
                End If
            End If
        End If

        If isRestrictedString(teNama.Text, dbstring) = True Then
            dizMsgbox("NAMA tidak boleh " & teNama.Text & ", silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If isRestrictedString(teNamaPanggilan.Text, dbstring) = True Then
            dizMsgbox("NAMA tidak boleh " & teNamaPanggilan.Text & ", silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If deTanggalLahir.EditValue Is Nothing Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda" & vbCrLf & ctrlname, dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If checkEntry(tlpAsalPasien) = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda" & vbCrLf & ctrlname, dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If checkEntry(tlpPasien) = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda" & vbCrLf & ctrlname, dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If checkEntry(tlpAlamat1) = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda" & vbCrLf & ctrlname, dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If checkEntry(tlpAlamat2) = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda" & vbCrLf & ctrlname, dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim bTelpR As Boolean = True
        Dim bTelpK As Boolean = True
        Dim bTelpH As Boolean = True
        If teTelpRumah.Text = "" Then
            bTelpR = False
        End If
        If IsNumeric(teTelpRumah.Text) Then
            If teTelpRumah.Text = 0 Then
                bTelpR = False
            End If
        Else
            bTelpR = False
        End If
        If teTelpKantor.Text = "" Then
            bTelpK = False
        End If
        If IsNumeric(teTelpKantor.Text) Then
            If teTelpKantor.Text = 0 Then
                bTelpK = False
            End If
        Else
            bTelpK = False
        End If
        If teTelpHP.Text = "" Then
            bTelpH = False
        End If
        If IsNumeric(teTelpHP.Text) Then
            If teTelpHP.Text = 0 Then
                bTelpH = False
            End If
        Else
            bTelpH = False
        End If

        If bTelpR = False And bTelpK = False And bTelpH = False Then
            dizMsgbox("Isian Telepon belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        'If checkEntry(tlpEmail) = False Then
        '    dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
        '    Exit Sub
        'End If
        If teNoRM.Text <> "00-00-00-00" Then
            If teNamaKeluarga.Text = "" Then
                dizMsgbox("Isian Keluarga belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If
            If lueJenisKeluarga.EditValue = Nothing Then
                dizMsgbox("Isian Keluarga belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If

            Dim bTelpk1 As Boolean = True
            Dim bTelpk2 As Boolean = True
            If teKeluargaPhone1.Text = "" Then
                bTelpk1 = False
            End If
            If IsNumeric(teKeluargaPhone1.Text) Then
                If teKeluargaPhone1.Text = 0 Then
                    bTelpk1 = False
                End If
            Else
                bTelpk1 = False
            End If
            If teKeluargaPhone2.Text = "" Then
                bTelpk2 = False
            End If
            If IsNumeric(teKeluargaPhone2.Text) Then
                If teKeluargaPhone2.Text = 0 Then
                    bTelpk2 = False
                End If
            Else
                bTelpk2 = False
            End If
            If bTelpk1 = False And bTelpk2 = False Then
                dizMsgbox("Isian Telepon belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If

            If checkEntry(tlpKeluargaAlamat1) = False Then
                dizMsgbox("Isian Alamat Keluarga belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If
            If checkEntry(tlpKeluargaAlamat2) = False Then
                dizMsgbox("Isian Alamat Keluarga belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If

            Dim sqls2 As New SQLs(dbstring)
            If statData = statusData.Baru Then
                sqls2.DMLQuery("select rekammedisno from rekammedis where isdeleted=0 and rekammedisno='" & CLng(teNoRM.Text.Replace("-", "")) & "'", "ceknorm")
            ElseIf statData = statusData.Edit Then
                sqls2.DMLQuery("select rekammedisno from rekammedis where isdeleted=0 and rekammedisno='" & CLng(teNoRM.Text.Replace("-", "")) & "' and idrekammedis<>'" & idData & "'", "ceknorm")
            End If
            If sqls2.getDataSet("ceknorm") > 0 Then
                dizMsgbox("No RM tersebut masih aktif", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If

            Dim sqlscekusia As New SQLs(dbstring)
            sqlscekusia.DMLQuery("select value from sys_appsetting where variable='MaxUsiaWarning'", "maxusia")
            Dim maxusia As Integer = 100
            If sqlscekusia.getDataSet("maxusia") > 0 Then
                If IsNumeric(sqlscekusia.getDataSet("maxusia")) Then
                    maxusia = CInt(sqlscekusia.getDataSet("maxusia", 0, "value"))
                End If
            End If
            If nowTime.Year - CDate(deTanggalLahir.EditValue).Year > maxusia Then
                If dizMsgbox("Usia Pasien lebih dari " & maxusia & vbCrLf & "Data sudah benar ?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
                    Exit Sub
                End If
            End If

            sqls2.DMLQuery("select value from sys_appsetting where variable='AllowMelebihiMaxNoRM'", "cekset")
            If sqls2.getDataSet("cekset") > 0 Then
                exceedMaxNoRM = sqls2.getDataSet("cekset", 0, "value")
            Else
                exceedMaxNoRM = 0
            End If

            If exceedMaxNoRM = 0 Then
                Dim maxnorm As Long = 0
                sqls2.DMLQuery("select case when isnull(max(convert(bigint,rekammedisno)),0)=0 then 1 else max(convert(bigint,rekammedisno))+1 end as mrn from rekammedis", "maxmrn")
                maxnorm = CLng(sqls2.getDataSet("maxmrn", 0, "mrn"))
                If maxnorm < CLng(teNoRM.Text.Replace("-", "")) Then
                    sqls2.DMLQuery("select dbo.fformatnorm(" & maxnorm & ") as norm", "formaxrm")
                    Dim maxrm As String = sqls2.getDataSet("formaxrm", 0, "norm")
                    sqls2.DMLQuery("select dbo.fformatnorm(" & CLng(teNoRM.Text.Replace("-", "")) & ") as norm", "formatrm")
                    Dim matrm As String = sqls2.getDataSet("formatrm", 0, "norm")
                    dizMsgbox("No RM tersebut melebihi batas No RM Terakhir" & vbCrLf & "No RM " & matrm & "dan No RM Terakhir " & maxrm, dizMsgboxStyle.Peringatan, Me)
                    Exit Sub
                End If
            End If
        End If

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        Dim dtSQL As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        'Dim engine As New dizEngine.engine
        If idData = "-1" Then
            'engine = New dizEngine.engine
            idData = GenerateGUID()
            field.AddRange(New String() {"idrekammedis", "idcompany", "rekammedisno", "asalpx", "asalpx2", "asalrujukan", "iddokterrujukan", "sapaan", "namapanggilan", "nama", "tanggallahir", "jeniskelamin", "pekerjaan", "pendidikan", "kotalahir", "pernikahan", "agama", "golongandarah", "rhesus", "kewarganegaraan", "ishamil", "hambatankom", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idData, idcomp, CLng(teNoRM.Text.Replace("-", "")), lueAsalPx.EditValue, lueAsalPx2.EditValue, If(lueAsalPx3.EditValue, 0), If(lueAsalPx4.EditValue, 0), lueSapaan.EditValue, teNamaPanggilan.Text, teNama.Text, CDate(deTanggalLahir.EditValue), lueJenisKelamin.EditValue, luePekerjaan.EditValue, luePendidikan.EditValue, lueTempatLahir.EditValue, luePernikahan.EditValue, lueAgama.EditValue, lueGolonganDarah.EditValue, lueRhesus.EditValue, lueKewarganegaraan.EditValue, 0, lueHambatan.EditValue, 0, userid, nowTime})
        Else
            field.AddRange(New String() {"idrekammedis", "rekammedisno", "sapaan", "namapanggilan", "nama", "tanggallahir", "jeniskelamin", "pekerjaan", "pendidikan", "kotalahir", "pernikahan", "agama", "golongandarah", "rhesus", "kewarganegaraan", "hambatankom", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, CLng(teNoRM.Text.Replace("-", "")), lueSapaan.EditValue, teNamaPanggilan.Text, teNama.Text, CDate(deTanggalLahir.EditValue), lueJenisKelamin.EditValue, luePekerjaan.EditValue, luePendidikan.EditValue, lueTempatLahir.EditValue, luePernikahan.EditValue, lueAgama.EditValue, lueGolonganDarah.EditValue, lueRhesus.EditValue, lueKewarganegaraan.EditValue, lueHambatan.EditValue, userid, nowTime})
        End If
        If dtSQL.datasetSave("rekammedis", idData, field, value, False) = True Then
            isiLog(userid, dbstring, field, value, "rekammedis")

            Dim sqls As New SQLs(dbstring)
            sqls = New SQLs(dbstring)
            Dim idtmp As String

            'email
            idtmp = GenerateGUID()
            Dim cekEmail As Boolean = True
            If teEmail.EditValue IsNot Nothing Then
                cekEmail = False
            End If
            If teEmail.Text.Replace(" ", "") = "" Then
                cekEmail = False
            End If
            If cekEmail = True Then
                dtSQL = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.Clear()
                value.Clear()

                idtmp = GenerateGUID()
                field.AddRange(New String() {"idemail", "idcompany", "idreff", "tablereff", "email", "emailtype", "isdeleted", "isprimary", "createdby", "createddate"})
                value.AddRange(New Object() {idtmp, idcomp, idData, "PASIEN", teEmail.Text, 1, 0, 1, userid, nowTime})
                sqls.DMLQuery("update email set isdeleted=1,isprimary=0 where emailtype=1 and tablereff='PASIEN' and idreff='" & idData & "'", False)
                dtSQL.datasetSave("email", idtmp, field, value, False)
                isiLog(userid, dbstring, field, value, "email")
            End If

            'kartu
            idtmp = GenerateGUID()
            dtSQL = New dtsetSQLS(dbstring)
            field = New List(Of String)
            value = New List(Of Object)
            field.Clear()
            value.Clear()

            field.AddRange(New String() {"idkartu", "idcompany", "idreff", "tablereff", "idpenerbit", "jenispenerbit", "jeniskartu", "nomorkartu", "namakartu", "jenistanggal", "tanggalkartu", "isdeleted", "isprimary", "createdby", "createddate"})
            value.AddRange(New Object() {idtmp, idcomp, idData, "PASIEN", 0, "", lueJenisKartu.EditValue, teNomorKartu.Text, teNama.Text, 3, nowTime, 0, 1, userid, nowTime})
            sqls.DMLQuery("update kartu set isdeleted=1,isprimary=0 where jeniskartu='" & lueJenisKartu.EditValue & "' and tablereff='PASIEN' and idreff='" & idData & "'", False)
            dtSQL.datasetSave("kartu", idtmp, field, value, False)
            isiLog(userid, dbstring, field, value, "kartu")

            'alamat
            idtmp = GenerateGUID()
            dtSQL = New dtsetSQLS(dbstring)
            field = New List(Of String)
            value = New List(Of Object)
            field.Clear()
            value.Clear()

            field.AddRange(New String() {"idalamat", "idcompany", "idreff", "tablereff", "addresstype", "idnegara", "idpropinsi", "idkabupaten", "idkecamatan", "idkelurahan", "alamat", "kodepos", "isdeleted", "isprimary", "createdby", "createddate"})
            value.AddRange(New Object() {idtmp, idcomp, idData, "PASIEN", 2, lueNegara.EditValue, If(luePropinsi.EditValue, 0), If(lueKabupaten.EditValue, 0), If(lueKecamatan.EditValue, 0), If(lueKelurahan.EditValue, 0), meAlamat.Text, If(teKodepos.Text, 0), 0, 1, userid, nowTime})
            sqls.DMLQuery("update alamat set isdeleted=1,isprimary=0 where tablereff='PASIEN' and idreff='" & idData & "'", False)
            dtSQL.datasetSave("alamat", idtmp, field, value, False)
            isiLog(userid, dbstring, field, value, "alamat")

            'phone
            If IsNumeric(teTelpKantor.Text) Then
                idtmp = GenerateGUID()
                dtSQL = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.Clear()
                value.Clear()

                field.AddRange(New String() {"idphone", "idcompany", "idreff", "tablereff", "phonetype", "phone", "extension", "isdeleted", "isprimary", "createdby", "createddate"})
                value.AddRange(New Object() {idtmp, idcomp, idData, "PASIEN", 1, teTelpKantor.Text, If(teExtension.Text, 0), 0, 1, userid, nowTime})
                sqls.DMLQuery("update phone set isdeleted=1,isprimary=0 where tablereff='PASIEN' and phonetype=1 and idreff='" & idData & "'", False)
                dtSQL.datasetSave("phone", idtmp, field, value, False)
                isiLog(userid, dbstring, field, value, "phone")
            End If

            If IsNumeric(teTelpRumah.Text) Then
                idtmp = GenerateGUID()
                dtSQL = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.Clear()
                value.Clear()

                field.AddRange(New String() {"idphone", "idcompany", "idreff", "tablereff", "phonetype", "phone", "extension", "isdeleted", "isprimary", "createdby", "createddate"})
                value.AddRange(New Object() {idtmp, idcomp, idData, "PASIEN", 2, teTelpRumah.Text, 0, 0, 1, userid, nowTime})
                sqls.DMLQuery("update phone set isdeleted=1,isprimary=0 where tablereff='PASIEN' and phonetype=2 and idreff='" & idData & "'", False)
                dtSQL.datasetSave("phone", idtmp, field, value, False)
                isiLog(userid, dbstring, field, value, "phone")
            End If

            If IsNumeric(teTelpHP.Text) Then
                idtmp = GenerateGUID()
                dtSQL = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.Clear()
                value.Clear()

                field.AddRange(New String() {"idphone", "idcompany", "idreff", "tablereff", "phonetype", "phone", "extension", "isdeleted", "isprimary", "createdby", "createddate"})
                value.AddRange(New Object() {idtmp, idcomp, idData, "PASIEN", 3, teTelpHP.Text, 0, 0, 1, userid, nowTime})
                sqls.DMLQuery("update phone set isdeleted=1,isprimary=0 where tablereff='PASIEN' and phonetype=3 and idreff='" & idData & "'", False)
                dtSQL.datasetSave("phone", idtmp, field, value, False)
                isiLog(userid, dbstring, field, value, "phone")
            End If

            'keluarga
            If teNoRM.Text <> "00-00-00-00" Then
                idDataChild = GenerateGUID()
                dtSQL = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.Clear()
                value.Clear()

                field.AddRange(New String() {"idkeluarga", "idcompany", "idreff", "tablereff", "familytype", "nama", "isdeleted", "createdby", "createddate"})
                value.AddRange(New Object() {idDataChild, idcomp, idData, "PASIEN", lueJenisKeluarga.EditValue, teNamaKeluarga.Text, 0, userid, nowTime})
                sqls.DMLQuery("update keluarga set isdeleted=1 where tablereff='PASIEN' and idreff='" & idData & "'", False)
                dtSQL.datasetSave("keluarga", idDataChild, field, value, False)
                isiLog(userid, dbstring, field, value, "keluarga")

                sqls = New SQLs(dbstring)
                'phonekeluarga
                If IsNumeric(teKeluargaPhone1.Text) Then
                    idtmp = GenerateGUID()
                    dtSQL = New dtsetSQLS(dbstring)
                    field = New List(Of String)
                    value = New List(Of Object)
                    field.Clear()
                    value.Clear()

                    field.AddRange(New String() {"idphone", "idcompany", "idreff", "tablereff", "phonetype", "phone", "extension", "isdeleted", "isprimary", "createdby", "createddate"})
                    value.AddRange(New Object() {idtmp, idcomp, idDataChild, "KELUARGAPASIEN", 3, teKeluargaPhone1.Text, 0, 0, 1, userid, nowTime})
                    sqls.DMLQuery("update phone set isdeleted=1,isprimary=0 where tablereff='KELUARGAPASIEN' and phonetype=3 and idreff='" & idDataChild & "'", False)
                    dtSQL.datasetSave("phone", idtmp, field, value, False)
                    isiLog(userid, dbstring, field, value, "phone")
                End If

                If IsNumeric(teKeluargaPhone2.Text) Then
                    idtmp = GenerateGUID()
                    dtSQL = New dtsetSQLS(dbstring)
                    field = New List(Of String)
                    value = New List(Of Object)
                    field.Clear()
                    value.Clear()

                    field.AddRange(New String() {"idphone", "idcompany", "idreff", "tablereff", "phonetype", "phone", "extension", "isdeleted", "isprimary", "createdby", "createddate"})
                    value.AddRange(New Object() {idtmp, idcomp, idDataChild, "KELUARGAPASIEN", 2, teKeluargaPhone1.Text, 0, 0, 1, userid, nowTime})
                    sqls.DMLQuery("update phone set isdeleted=1,isprimary=0 where tablereff='KELUARGAPASIEN' and phonetype=2 and idreff='" & idDataChild & "'", False)
                    dtSQL.datasetSave("phone", idtmp, field, value, False)
                    isiLog(userid, dbstring, field, value, "phone")
                End If

                idtmp = GenerateGUID()
                dtSQL = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.Clear()
                value.Clear()

                field.AddRange(New String() {"idalamat", "idcompany", "idreff", "tablereff", "addresstype", "idnegara", "idpropinsi", "idkabupaten", "idkecamatan", "idkelurahan", "alamat", "kodepos", "isdeleted", "isprimary", "createdby", "createddate"})
                value.AddRange(New Object() {idtmp, idcomp, idDataChild, "KELUARGAPASIEN", 2, lueKNegara.EditValue, If(lueKPropinsi.EditValue, 0), If(lueKKabupaten.EditValue, 0), If(lueKKecamatan.EditValue, 0), If(lueKKelurahan.EditValue, 0), meKAlamat.Text, teKKodepos.Text, 0, 1, userid, nowTime})
                sqls.DMLQuery("update alamat set isdeleted=1,isprimary=0 where tablereff='KELUARGAPASIEN' and idreff='" & idDataChild & "'", False)
                dtSQL.datasetSave("alamat", idtmp, field, value, False)
                isiLog(userid, dbstring, field, value, "alamat")
            End If

            idtmp = GenerateGUID()
            dtSQL = New dtsetSQLS(dbstring)
            field = New List(Of String)
            value = New List(Of Object)
            field.Clear()
            value.Clear()

            field.AddRange(New String() {"idrekammedisriwayat", "idrekammedis", "iduser", "createddate", "remarks"})
            If statData = statusData.Baru Then
                value.AddRange(New Object() {idtmp, idData, userid, nowTime, "Rekam Medis dibuat oleh " & username})
            Else
                value.AddRange(New Object() {idtmp, idData, userid, nowTime, "Rekam Medis diedit oleh " & username})
            End If
            dtSQL.datasetSave("rekammedisriwayat", idtmp, field, value, False)

            statData = statusData.Edit
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
        Else
            dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

    Private statData As statusData = statusData.Baru
    Private statDataChild As statusData = statusData.Baru
    Private idData As String = "-1"
    Private idDataChild As String = "-1"

    Private Sub btnSavePrint_Click(sender As Object, e As EventArgs) Handles btnSavePrint.Click
        If statData = statusData.Baru Then
            If teNoRM.Text <> "00-00-00-00" Then
                Dim sqls As New SQLs(dbstring)
                Dim field2 As New List(Of String)
                Dim value2 As New List(Of Object)
                field2.AddRange(New String() {"@nama", "@nokartu"})
                value2.AddRange(New Object() {teNama.Text.Replace(" ", ""), teNomorKartu.Text})
                sqls.CallSP("spCheckRMbaru", "cek", field2, value2)
                'sqls.DMLQuery("select nama from rekammedis where rekammedisno<>0 and replace(nama,' ','')='" & teNama.Text.Replace(" ", "") & "'", "cek")
                If sqls.getDataSet("cek") = 0 Then
                    idData = "-1"
                Else
                    dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
                    teNama.Focus()
                    Exit Sub
                End If
            End If
        ElseIf statData = statusData.Edit Then
            If teNoRM.Text <> "00-00-00-00" Then
                Dim sqls As New SQLs(dbstring)
                Dim field2 As New List(Of String)
                Dim value2 As New List(Of Object)
                field2.AddRange(New String() {"@nama", "@nokartu", "@idrm"})
                value2.AddRange(New Object() {teNama.Text.Replace(" ", ""), teNomorKartu.Text, idData})
                sqls.CallSP("spCheckRMlama", "cek", field2, value2)
                'sqls.DMLQuery("select nama from rekammedis where isdeleted=0 and rekammedisno<>0 and replace(nama,' ','')='" & teNama.Text.Replace(" ", "") & "' and idrekammedis<>" & idData, "cek")
                If sqls.getDataSet("cek") > 0 Then
                    dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
                    teNama.Focus()
                    Exit Sub
                End If
            End If
        End If

        Dim sqlscekusia As New SQLs(dbstring)
        sqlscekusia.DMLQuery("select value from sys_appsetting where variable='MaxUsiaWarning'", "maxusia")
        Dim maxusia As Integer = 100
        If sqlscekusia.getDataSet("maxusia") > 0 Then
            If IsNumeric(sqlscekusia.getDataSet("maxusia")) Then
                maxusia = CInt(sqlscekusia.getDataSet("maxusia", 0, "value"))
            End If
        End If
        If nowTime.Year - CDate(deTanggalLahir.EditValue).Year > maxusia Then
            If dizMsgbox("Usia Pasien lebih dari " & maxusia & vbCrLf & "Data sudah benar ?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
                Exit Sub
            End If
        End If

        If isRestrictedString(teNama.Text, dbstring) = True Then
            dizMsgbox("NAMA tidak boleh " & teNama.Text & ", silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If isRestrictedString(teNamaPanggilan.Text, dbstring) = True Then
            dizMsgbox("NAMA tidak boleh " & teNamaPanggilan.Text & ", silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If deTanggalLahir.EditValue Is Nothing Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda" & vbCrLf & ctrlname, dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If checkEntry(tlpAsalPasien) = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If checkEntry(tlpPasien) = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If checkEntry(tlpAlamat1) = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If checkEntry(tlpAlamat2) = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim bTelpR As Boolean = True
        Dim bTelpK As Boolean = True
        Dim bTelpH As Boolean = True
        If teTelpRumah.Text = "" Then
            bTelpR = False
        End If
        If IsNumeric(teTelpRumah.Text) Then
            If teTelpRumah.Text = 0 Then
                bTelpR = False
            End If
        Else
            bTelpR = False
        End If
        If teTelpKantor.Text = "" Then
            bTelpK = False
        End If
        If IsNumeric(teTelpKantor.Text) Then
            If teTelpKantor.Text = 0 Then
                bTelpK = False
            End If
        Else
            bTelpK = False
        End If
        If teTelpHP.Text = "" Then
            bTelpH = False
        End If
        If IsNumeric(teTelpHP.Text) Then
            If teTelpHP.Text = 0 Then
                bTelpH = False
            End If
        Else
            bTelpH = False
        End If

        If bTelpR = False And bTelpK = False And bTelpH = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        'If checkEntry(tlpEmail) = False Then
        '    dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
        '    Exit Sub
        'End If
        If teNoRM.Text <> "00-00-00-00" Then
            If teNamaKeluarga.Text = "" Then
                dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If
            If lueJenisKeluarga.EditValue = Nothing Then
                dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If

            Dim bTelpk1 As Boolean = True
            Dim bTelpk2 As Boolean = True
            If teKeluargaPhone1.Text = "" Then
                bTelpk1 = False
            End If
            If IsNumeric(teKeluargaPhone1.Text) Then
                If teKeluargaPhone1.Text = 0 Then
                    bTelpk1 = False
                End If
            Else
                bTelpk1 = False
            End If
            If teKeluargaPhone2.Text = "" Then
                bTelpk2 = False
            End If
            If IsNumeric(teKeluargaPhone2.Text) Then
                If teKeluargaPhone2.Text = 0 Then
                    bTelpk2 = False
                End If
            Else
                bTelpk2 = False
            End If
            If bTelpk1 = False And bTelpk2 = False Then
                dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If

            If checkEntry(tlpKeluargaAlamat1) = False Then
                dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If
            If checkEntry(tlpKeluargaAlamat2) = False Then
                dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If

            Dim sqls2 As New SQLs(dbstring)
            If idData = "-1" Then
                sqls2.DMLQuery("select rekammedisno from rekammedis where isdeleted=0 and rekammedisno='" & CLng(teNoRM.Text.Replace("-", "")) & "'", "ceknorm")
            Else
                sqls2.DMLQuery("select rekammedisno from rekammedis where isdeleted=0 and rekammedisno='" & CLng(teNoRM.Text.Replace("-", "")) & "' and idrekammedis<>'" & idData & "'", "ceknorm")
            End If
            If sqls2.getDataSet("ceknorm") > 0 Then
                dizMsgbox("No RM tersebut masih aktif", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If

            Dim maxnorm As Long = 0
            sqls2.DMLQuery("select case when isnull(max(convert(bigint,rekammedisno)),0)=0 then 1 else max(convert(bigint,rekammedisno))+1 end as mrn from rekammedis", "maxmrn")
            maxnorm = CLng(sqls2.getDataSet("maxmrn", 0, "mrn"))
            If maxnorm < CLng(teNoRM.Text.Replace("-", "")) Then
                sqls2.DMLQuery("select dbo.fformatnorm(" & maxnorm & ") as norm", "formaxrm")
                Dim maxrm As String = sqls2.getDataSet("formaxrm", 0, "norm")
                sqls2.DMLQuery("select dbo.fformatnorm(" & CLng(teNoRM.Text.Replace("-", "")) & ") as norm", "formatrm")
                Dim matrm As String = sqls2.getDataSet("formatrm", 0, "norm")
                dizMsgbox("No RM tersebut melebihi batas No RM Terakhir" & vbCrLf & "No RM " & matrm & "dan No RM Terakhir " & maxrm, dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If
        End If

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        Dim dtSQL As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If idData = "-1" Then
            idData = GenerateGUID()
            field.AddRange(New String() {"idrekammedis", "idcompany", "rekammedisno", "asalpx", "asalpx2", "asalrujukan", "iddokterrujukan", "sapaan", "namapanggilan", "nama", "tanggallahir", "jeniskelamin", "pekerjaan", "pendidikan", "kotalahir", "pernikahan", "agama", "golongandarah", "rhesus", "kewarganegaraan", "ishamil", "hambatankom", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idData, idcomp, CLng(teNoRM.Text.Replace("-", "")), lueAsalPx.EditValue, lueAsalPx2.EditValue, If(lueAsalPx3.EditValue, 0), If(lueAsalPx4.EditValue, 0), lueSapaan.EditValue, teNamaPanggilan.Text, teNama.Text, CDate(deTanggalLahir.EditValue), lueJenisKelamin.EditValue, luePekerjaan.EditValue, luePendidikan.EditValue, lueTempatLahir.EditValue, luePernikahan.EditValue, lueAgama.EditValue, lueGolonganDarah.EditValue, lueRhesus.EditValue, lueKewarganegaraan.EditValue, 0, lueHambatan.EditValue, 0, userid, nowTime})
        Else
            field.AddRange(New String() {"idrekammedis", "sapaan", "namapanggilan", "nama", "tanggallahir", "jeniskelamin", "pekerjaan", "pendidikan", "kotalahir", "pernikahan", "agama", "golongandarah", "rhesus", "kewarganegaraan", "hambatankom", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, lueSapaan.EditValue, teNamaPanggilan.Text, teNama.Text, CDate(deTanggalLahir.EditValue), lueJenisKelamin.EditValue, luePekerjaan.EditValue, luePendidikan.EditValue, lueTempatLahir.EditValue, luePernikahan.EditValue, lueAgama.EditValue, lueGolonganDarah.EditValue, lueRhesus.EditValue, lueKewarganegaraan.EditValue, lueHambatan.EditValue, userid, nowTime})
        End If
        If dtSQL.datasetSave("rekammedis", idData, field, value, False) = True Then
            isiLog(userid, dbstring, field, value, "rekammedis")

            Dim sqls As New SQLs(dbstring)
            sqls = New SQLs(dbstring)
            Dim idtmp As String

            'email
            idtmp = GenerateGUID()
            Dim cekEmail As Boolean = True
            If teEmail.EditValue IsNot Nothing Then
                cekEmail = False
            End If
            If teEmail.Text.Replace(" ", "") = "" Then
                cekEmail = False
            End If
            If cekEmail = True Then
                dtSQL = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.Clear()
                value.Clear()

                field.AddRange(New String() {"idemail", "idcompany", "idreff", "tablereff", "email", "emailtype", "isdeleted", "isprimary", "createdby", "createddate"})
                value.AddRange(New Object() {idtmp, idcomp, idData, "PASIEN", teEmail.Text, 1, 0, 1, userid, nowTime})
                sqls.DMLQuery("update email set isdeleted=1,isprimary=0 where emailtype=1 and tablereff='PASIEN' and idreff='" & idData & "'", False)
                dtSQL.datasetSave("email", idtmp, field, value, False)
                isiLog(userid, dbstring, field, value, "email")
            End If

            'kartu
            dtSQL = New dtsetSQLS(dbstring)
            field = New List(Of String)
            value = New List(Of Object)
            field.Clear()
            value.Clear()
            idtmp = GenerateGUID()

            field.AddRange(New String() {"idkartu", "idcompany", "idreff", "tablereff", "idpenerbit", "jenispenerbit", "jeniskartu", "nomorkartu", "namakartu", "jenistanggal", "tanggalkartu", "isdeleted", "isprimary", "createdby", "createddate"})
            value.AddRange(New Object() {idtmp, idcomp, idData, "PASIEN", 0, "", lueJenisKartu.EditValue, teNomorKartu.Text, teNama.Text, 3, nowTime, 0, 1, userid, nowTime})
            sqls.DMLQuery("update kartu set isdeleted=1,isprimary=0 where jeniskartu='" & lueJenisKartu.EditValue & "' and tablereff='PASIEN' and idreff='" & idData & "'", False)
            dtSQL.datasetSave("kartu", idtmp, field, value, False)
            isiLog(userid, dbstring, field, value, "kartu")

            'alamat
            dtSQL = New dtsetSQLS(dbstring)
            field = New List(Of String)
            value = New List(Of Object)
            field.Clear()
            value.Clear()

            idtmp = GenerateGUID()
            field.AddRange(New String() {"idalamat", "idcompany", "idreff", "tablereff", "addresstype", "idnegara", "idpropinsi", "idkabupaten", "idkecamatan", "idkelurahan", "alamat", "kodepos", "isdeleted", "isprimary", "createdby", "createddate"})
            value.AddRange(New Object() {idtmp, idcomp, idData, "PASIEN", 2, lueNegara.EditValue, If(luePropinsi.EditValue, 0), If(lueKabupaten.EditValue, 0), If(lueKecamatan.EditValue, 0), If(lueKelurahan.EditValue, 0), meAlamat.Text, If(teKodepos.Text, 0), 0, 1, userid, nowTime})
            sqls.DMLQuery("update alamat set isdeleted=1,isprimary=0 where tablereff='PASIEN' and idreff='" & idData & "'", False)
            dtSQL.datasetSave("alamat", idtmp, field, value, False)
            isiLog(userid, dbstring, field, value, "alamat")

            'phone
            If IsNumeric(teTelpKantor.Text) Then
                dtSQL = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.Clear()
                value.Clear()

                idtmp = GenerateGUID()
                field.AddRange(New String() {"idphone", "idcompany", "idreff", "tablereff", "phonetype", "phone", "extension", "isdeleted", "isprimary", "createdby", "createddate"})
                value.AddRange(New Object() {idtmp, idcomp, idData, "PASIEN", 1, teTelpKantor.Text, teExtension.Text, 0, 1, userid, nowTime})
                sqls.DMLQuery("update phone set isdeleted=1,isprimary=0  where tablereff='PASIEN' and phonetype=1 and idreff='" & idData & "'", False)
                dtSQL.datasetSave("phone", idtmp, field, value, False)
                isiLog(userid, dbstring, field, value, "phone")
            End If

            If IsNumeric(teTelpRumah.Text) Then
                dtSQL = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.Clear()
                value.Clear()

                idtmp = GenerateGUID()
                field.AddRange(New String() {"idphone", "idcompany", "idreff", "tablereff", "phonetype", "phone", "extension", "isdeleted", "isprimary", "createdby", "createddate"})
                value.AddRange(New Object() {idtmp, idcomp, idData, "PASIEN", 2, teTelpRumah.Text, 0, 0, 1, userid, nowTime})
                sqls.DMLQuery("update phone set isdeleted=1,isprimary=0 where tablereff='PASIEN' and phonetype=2 and idreff='" & idData & "'", False)
                dtSQL.datasetSave("phone", idtmp, field, value, False)
                isiLog(userid, dbstring, field, value, "phone")
            End If

            If IsNumeric(teTelpHP.Text) Then
                dtSQL = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.Clear()
                value.Clear()

                idtmp = GenerateGUID()
                field.AddRange(New String() {"idphone", "idcompany", "idreff", "tablereff", "phonetype", "phone", "extension", "isdeleted", "isprimary", "createdby", "createddate"})
                value.AddRange(New Object() {idtmp, idcomp, idData, "PASIEN", 3, teTelpHP.Text, 0, 0, 1, userid, nowTime})
                sqls.DMLQuery("update phone set isdeleted=1,isprimary=0 where tablereff='PASIEN' and phonetype=3 and idreff='" & idData & "'", False)
                dtSQL.datasetSave("phone", idtmp, field, value, False)
                isiLog(userid, dbstring, field, value, "phone")
            End If

            'keluarga
            If teNoRM.Text <> "00-00-00-00" Then
                dtSQL = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.Clear()
                value.Clear()

                Dim idklg As String = GenerateGUID()
                field.AddRange(New String() {"idkeluarga", "idcompany", "idreff", "tablereff", "familytype", "nama", "isdeleted", "createdby", "createddate"})
                value.AddRange(New Object() {idklg, idcomp, idData, "PASIEN", lueJenisKeluarga.EditValue, teNamaKeluarga.Text, 0, userid, nowTime})
                sqls.DMLQuery("update keluarga set isdeleted=1 where tablereff='PASIEN' and idreff='" & idData & "'", False)
                dtSQL.datasetSave("keluarga", idklg, field, value, False)
                isiLog(userid, dbstring, field, value, "keluarga")

                idDataChild = idklg

                'phonekeluarga
                If IsNumeric(teKeluargaPhone1.Text) Then
                    dtSQL = New dtsetSQLS(dbstring)
                    field = New List(Of String)
                    value = New List(Of Object)
                    field.Clear()
                    value.Clear()

                    idtmp = GenerateGUID()
                    field.AddRange(New String() {"idphone", "idcompany", "idreff", "tablereff", "phonetype", "phone", "extension", "isdeleted", "isprimary", "createdby", "createddate"})
                    value.AddRange(New Object() {idtmp, idcomp, idDataChild, "KELUARGAPASIEN", 3, teKeluargaPhone1.Text, 0, 0, 1, userid, nowTime})
                    sqls.DMLQuery("update phone set isdeleted=1,isprimary=0 where tablereff='KELUARGAPASIEN' and phonetype=3 and idreff='" & idDataChild & "'", False)
                    dtSQL.datasetSave("phone", idtmp, field, value, False)
                    isiLog(userid, dbstring, field, value, "phone")
                End If

                If IsNumeric(teKeluargaPhone2.Text) Then
                    dtSQL = New dtsetSQLS(dbstring)
                    field = New List(Of String)
                    value = New List(Of Object)
                    field.Clear()
                    value.Clear()

                    idtmp = GenerateGUID()
                    field.AddRange(New String() {"idphone", "idcompany", "idreff", "tablereff", "phonetype", "phone", "extension", "isdeleted", "isprimary", "createdby", "createddate"})
                    value.AddRange(New Object() {idtmp, idcomp, idDataChild, "KELUARGAPASIEN", 2, teKeluargaPhone1.Text, 0, 0, 1, userid, nowTime})
                    sqls.DMLQuery("update phone set isdeleted=1,isprimary=0 where tablereff='KELUARGAPASIEN' and phonetype=2 and idreff='" & idDataChild & "'", False)
                    dtSQL.datasetSave("phone", idtmp, field, value, False)
                    isiLog(userid, dbstring, field, value, "phone")
                End If

                dtSQL = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.Clear()
                value.Clear()

                idtmp = GenerateGUID()
                field.AddRange(New String() {"idalamat", "idcompany", "idreff", "tablereff", "addresstype", "idnegara", "idpropinsi", "idkabupaten", "idkecamatan", "idkelurahan", "alamat", "kodepos", "isdeleted", "isprimary", "createdby", "createddate"})
                value.AddRange(New Object() {idtmp, idcomp, idDataChild, "KELUARGAPASIEN", 2, lueKNegara.EditValue, If(lueKPropinsi.EditValue, 0), If(lueKKabupaten.EditValue, 0), If(lueKKecamatan.EditValue, 0), If(lueKKelurahan.EditValue, 0), meKAlamat.Text, teKKodepos.Text, 0, 1, userid, nowTime})
                sqls.DMLQuery("update alamat set isdeleted=1,isprimary=0 where tablereff='KELUARGAPASIEN' and idreff='" & idDataChild & "'", False)
                dtSQL.datasetSave("alamat", idtmp, field, value, False)
                isiLog(userid, dbstring, field, value, "alamat")
            End If

            dtSQL = New dtsetSQLS(dbstring)
            field = New List(Of String)
            value = New List(Of Object)
            field.Clear()
            value.Clear()

            idtmp = GenerateGUID()
            field.AddRange(New String() {"idrekammedisriwayat", "idrekammedis", "iduser", "createddate", "remarks"})
            If statData = statusData.Baru Then
                value.AddRange(New Object() {idtmp, idData, userid, nowTime, "Rekam Medis dibuat oleh " & username})
            Else
                value.AddRange(New Object() {idtmp, idData, userid, nowTime, "Rekam Medis diedit oleh " & username})
            End If
            dtSQL.datasetSave("rekammedisriwayat", idtmp, field, value, False)

            Dim prntname As String = ""
            'Dim sd As New frmSelectDevice
            'tambahChild(sd)
            'If sd.ShowDialog() = DialogResult.OK Then
            'prntname = sd.getdevicename
            prntname = getPrinter("PXNEW")
            cetakBerkas(idData, cu.cetak, prntname)
            'End If

            statData = statusData.Edit
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            'isFromLoad = True
            'btnNew_Click(Me, Nothing)
        Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

    Private Sub cetakBerkas(iddata As String, cetaktype As cu, Optional printername As String = "")
        Dim mys As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@idrm"})
        value.AddRange(New Object() {iddata})
        mys.CallSP("spRegistrasiPasienBaru", "pasienbaru", field, value)

        Dim rpt As New xrPasienBaru01
        rpt.RequestParameters = False
        rpt.DataSource = mys.dataTable("pasienbaru")
        rpt.DataMember = "spRegistrasiPasienBaru"

        If teNama.EditValue Is Nothing Then
            mys.DMLQuery("select rm.nama from rekammedis rm left join registrasi r on r.idrekammedis=rm.idrekammedis where r.idregistrasi='" & iddata & "'", "getrm")
            rpt.DisplayName = mys.getDataSet("getrm", 0, "nama")
        Else
            rpt.DisplayName = teNama.Text
        End If
        rpt.Parameters("pID").Value = iddata
        rpt.Parameters("pID").Visible = False
        rpt.Parameters("pFooter").Value = "dicetak oleh " & username & " pada " & Format(nowTime, "dd ") & NamaBulan(nowTime.Month) & Format(nowTime, " yyyy HH:mm")
        rpt.Parameters("pFooter").Visible = False
        rpt.ShowPrintMarginsWarning = False

        Dim pt As New DevExpress.XtraReports.UI.ReportPrintTool(rpt)
        pt.Report.CreateDocument(False)
        AddHandler pt.PreviewForm.Load, AddressOf PreviewForm_Load
        If printername = "" Then
            If cetaktype = cu.cetak Then
                pt.Print()
            Else
                pt.AutoShowParametersPanel = False
                pt.ShowPreview()
            End If
        Else
            If cetaktype = cu.cetak Then
                pt.Print(printername)
            Else
                pt.AutoShowParametersPanel = False
                pt.ShowPreview()
            End If
        End If
    End Sub

    Private Sub PreviewForm_Load(sender As Object, ByVal e As EventArgs)
        Dim frm As DevExpress.XtraPrinting.Preview.PrintPreviewFormEx = CType(sender, DevExpress.XtraPrinting.Preview.PrintPreviewFormEx)
        frm.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.Scale, New Object() {1.0F})
    End Sub

    Private Sub Angka_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles teTelpRumah.KeyPress, teTelpKantor.KeyPress, teTelpHP.KeyPress, teExtension.KeyPress, teKodepos.KeyPress, teKeluargaPhone1.KeyPress, teKeluargaPhone2.KeyPress, tekkodepos.keypress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rNumeric) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private fromGrid As Boolean = False

    Private Sub Email_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teEmail.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rEmail) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub lueJenisKelamin_EditValueChanged(sender As Object, e As EventArgs) Handles lueJenisKelamin.EditValueChanged
        lueSapaan.Properties.DataSource = Nothing
        lueSapaan.EditValue = Nothing

        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='SAPAAN' and (idreff=2 or idreff='" & lueJenisKelamin.EditValue & "') order by generalcode asc", "sapaan")
        lueSapaan.Properties.DataSource = mysqls.dataTable("sapaan")
        lueSapaan.Properties.DisplayMember = "content"
        lueSapaan.Properties.ValueMember = "id"
        If mysqls.getDataSet("sapaan") = 0 Then
            dizMsgbox("Sapaan tidak ditemukan" & vbCrLf & "Sapaan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If
    End Sub

    Private Sub lueNegara_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueNegara.EditValueChanged
        Try
            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isdeleted=0 and idparent='" & sender.EditValue & "'", "propinsi")
            luePropinsi.Properties.DataSource = mysqls.dataTable("propinsi")
            luePropinsi.Properties.DisplayMember = "content"
            luePropinsi.Properties.ValueMember = "id"

            luePropinsi.EditValue = Nothing
        Catch ex As Exception
            luePropinsi.Properties.DataSource = Nothing
            luePropinsi.EditValue = Nothing
        End Try
        'senderWilayah = Nothing
        'If sender.EditValue Is Nothing Then Exit Sub
        'luePropinsi.EditValue = Nothing
        'lueKabupaten.EditValue = Nothing
        'lueKecamatan.EditValue = Nothing
        'lueKelurahan.EditValue = Nothing
    End Sub

    Private Sub luePropinsi_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePropinsi.EditValueChanged
        Try
            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isdeleted=0 and idparent='" & sender.EditValue & "'", "kabupaten")
            lueKabupaten.Properties.DataSource = mysqls.dataTable("kabupaten")
            lueKabupaten.Properties.DisplayMember = "content"
            lueKabupaten.Properties.ValueMember = "id"

            lueKabupaten.EditValue = Nothing
        Catch ex As Exception
            lueKabupaten.Properties.DataSource = Nothing
            lueKabupaten.EditValue = Nothing
        End Try
    End Sub

    Private Sub lueKabupaten_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueKabupaten.EditValueChanged
        Try
            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isdeleted=0 and idparent='" & sender.EditValue & "'", "kecamatan")
            lueKecamatan.Properties.DataSource = mysqls.dataTable("kecamatan")
            lueKecamatan.Properties.DisplayMember = "content"
            lueKecamatan.Properties.ValueMember = "id"

            lueKecamatan.EditValue = Nothing
        Catch ex As Exception
            lueKecamatan.Properties.DataSource = Nothing
            lueKecamatan.EditValue = Nothing
        End Try
    End Sub

    Private Sub lueKecamatan_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueKecamatan.EditValueChanged
        Try
            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isdeleted=0 and idparent='" & sender.EditValue & "'", "kecamatan")
            lueKecamatan.Properties.DataSource = mysqls.dataTable("kecamatan")
            lueKecamatan.Properties.DisplayMember = "content"
            lueKecamatan.Properties.ValueMember = "id"

            lueKecamatan.EditValue = Nothing
        Catch ex As Exception
            lueKecamatan.Properties.DataSource = Nothing
            lueKecamatan.EditValue = Nothing
        End Try
    End Sub

    Private Sub lueKelurahan_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueKelurahan.EditValueChanged
        Try
            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isdeleted=0 and idparent='" & sender.EditValue & "'", "kelurahan")
            lueKelurahan.Properties.DataSource = mysqls.dataTable("kelurahan")
            lueKelurahan.Properties.DisplayMember = "content"
            lueKelurahan.Properties.ValueMember = "id"

            lueKelurahan.EditValue = Nothing
        Catch ex As Exception
            lueKelurahan.Properties.DataSource = Nothing
            lueKelurahan.EditValue = Nothing
        End Try
    End Sub

    Private Sub lueKNegara_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueKNegara.EditValueChanged
        Try
            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isdeleted=0 and idparent='" & sender.EditValue & "'", "propinsi")
            lueKPropinsi.Properties.DataSource = mysqls.dataTable("propinsi")
            lueKPropinsi.Properties.DisplayMember = "content"
            lueKPropinsi.Properties.ValueMember = "id"

            lueKPropinsi.EditValue = Nothing
        Catch ex As Exception
            lueKPropinsi.Properties.DataSource = Nothing
            lueKPropinsi.EditValue = Nothing
        End Try
    End Sub

    Private Sub lueKPropinsi_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueKPropinsi.EditValueChanged
        Try
            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isdeleted=0 and idparent='" & sender.EditValue & "'", "kabupaten")
            lueKKabupaten.Properties.DataSource = mysqls.dataTable("kabupaten")
            lueKKabupaten.Properties.DisplayMember = "content"
            lueKKabupaten.Properties.ValueMember = "id"

            lueKKabupaten.EditValue = Nothing
        Catch ex As Exception
            lueKKabupaten.Properties.DataSource = Nothing
            lueKKabupaten.EditValue = Nothing
        End Try
    End Sub

    Private Sub lueKKabupaten_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueKKabupaten.EditValueChanged
        Try
            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isdeleted=0 and idparent='" & sender.EditValue & "'", "kecamatan")
            lueKKecamatan.Properties.DataSource = mysqls.dataTable("kecamatan")
            lueKKecamatan.Properties.DisplayMember = "content"
            lueKKecamatan.Properties.ValueMember = "id"

            lueKKecamatan.EditValue = Nothing
        Catch ex As Exception
            lueKKecamatan.Properties.DataSource = Nothing
            lueKKecamatan.EditValue = Nothing
        End Try
    End Sub

    Private Sub lueKKecamatan_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueKKecamatan.EditValueChanged
        Try
            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isdeleted=0 and idparent='" & sender.EditValue & "'", "kecamatan")
            lueKecamatan.Properties.DataSource = mysqls.dataTable("kecamatan")
            lueKecamatan.Properties.DisplayMember = "content"
            lueKecamatan.Properties.ValueMember = "id"

            lueKecamatan.EditValue = Nothing
        Catch ex As Exception
            lueKecamatan.Properties.DataSource = Nothing
            lueKecamatan.EditValue = Nothing
        End Try
    End Sub

    Private Sub luekKelurahan_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueKKelurahan.EditValueChanged
        Try
            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isdeleted=0 and idparent='" & sender.EditValue & "'", "kelurahan")
            lueKelurahan.Properties.DataSource = mysqls.dataTable("kelurahan")
            lueKelurahan.Properties.DisplayMember = "content"
            lueKelurahan.Properties.ValueMember = "id"

            lueKelurahan.EditValue = Nothing
        Catch ex As Exception
            lueKelurahan.Properties.DataSource = Nothing
            lueKelurahan.EditValue = Nothing
        End Try
    End Sub

    Private idselect As String = ""
    Private strQuery As String = ""

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If teSearch.EditValue Is Nothing Then
            dizMsgbox("Tidak disarankan melakukan pencarian seluruh Pasien", dizMsgboxStyle.Info, "Info", Me)
            Exit Sub
        End If
        If teSearch.Text.Replace(" ", "") = "" Then
            dizMsgbox("Tidak disarankan melakukan pencarian seluruh Pasien", dizMsgboxStyle.Info, "Info", Me)
            Exit Sub
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
        strQuery &= " and r.rekammedisno<>0"
        If teSearch.Text <> "" Then
            strQuery &= " and (r.idrekammedis='" & teSearch.Text & "' or r.nama like '%" & teSearch.Text & "%' or replace(dbo.fformatnorm(r.rekammedisno),'-','') like '%" & teSearch.Text & "%' or dbo.fformatnorm(r.rekammedisno) like '%" & teSearch.Text & "%' or convert(varchar,r.rekammedisno) like '%" & teSearch.Text & "%')"
        End If
        strQuery &= " order by r.rekammedisno desc"

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

            sqls.DMLQuery("select rm.asalpx,rm.asalpx2,rm.asalrujukan,rm.iddokterrujukan,rm.rekammedisno,rm.namapanggilan,rm.nama,rm.jeniskelamin,rm.sapaan,rm.golongandarah,rm.rhesus,rm.agama,rm.kewarganegaraan,rm.kotalahir,convert(varchar,rm.tanggallahir,105) as tanggallahir,rm.pendidikan,rm.pekerjaan,rm.pernikahan,rm.hambatankom,rm.isdeleted from rekammedis rm where rm.idrekammedis='" & idselect & "'", "getrm")

            If sqls.getDataSet("getrm") = 0 Then
                dizMsgbox("Data Rekam Medis tidak ditemukan", dizMsgboxStyle.Peringatan, "Tidak Ditemukan")
                btnNew_Click(Me, Nothing)
            Else
                btnNew.Enabled = True
                btnSave.Enabled = True
                btnSavePrint.Enabled = True
                btnDelete.Enabled = True
                btnDelete.Text = "HAPUS"
                statData = statusData.Edit

                tlpAsalPasien.Enabled = True
                tlpPasien.Enabled = True
                tlpAlamat1.Enabled = True
                tlpAlamat2.Enabled = True
                tlpTelepon.Enabled = True
                tlpEmail.Enabled = True
                tlpKeluarga.Enabled = True
                tlpKeluargaAlamat1.Enabled = True
                tlpKeluargaAlamat2.Enabled = True
                teNoRM.Properties.ReadOnly = False

                idData = idselect

                lueAsalPx.Properties.ReadOnly = True
                lueAsalPx2.Properties.ReadOnly = True
                lueAsalPx3.Properties.ReadOnly = True
                lueAsalPx4.Properties.ReadOnly = True

                'kartu
                sqls.DMLQuery("select jeniskartu,nomorkartu from kartu where tablereff='PASIEN' and isdeleted=0 and isprimary=1 and idreff='" & idselect & "'", "kartu")
                lueJenisKartu.EditValue = sqls.getDataSet("kartu", 0, "jeniskartu")
                teNomorKartu.EditValue = sqls.getDataSet("kartu", 0, "nomorkartu")

                'asal
                lueAsalPx.EditValue = sqls.getDataSet("getrm", 0, "asalpx")
                lueAsalPx2.EditValue = sqls.getDataSet("getrm", 0, "asalpx2")
                lueAsalPx3.EditValue = sqls.getDataSet("getrm", 0, "asalrujukan")
                lueAsalPx4.EditValue = sqls.getDataSet("getrm", 0, "iddokterrujukan")
                teNoRM.Text = Format(CLng(sqls.getDataSet("getrm", 0, "rekammedisno").ToString.Replace("-", "")), "0#######")
                teNamaPanggilan.Text = sqls.getDataSet("getrm", 0, "namapanggilan")
                teNama.Text = sqls.getDataSet("getrm", 0, "nama")
                lueJenisKelamin.EditValue = sqls.getDataSet("getrm", 0, "jeniskelamin")
                lueSapaan.EditValue = sqls.getDataSet("getrm", 0, "sapaan")
                lueGolonganDarah.EditValue = sqls.getDataSet("getrm", 0, "golongandarah")
                lueRhesus.EditValue = sqls.getDataSet("getrm", 0, "rhesus")
                lueAgama.EditValue = sqls.getDataSet("getrm", 0, "agama")
                lueKewarganegaraan.EditValue = sqls.getDataSet("getrm", 0, "kewarganegaraan")
                lueTempatLahir.EditValue = sqls.getDataSet("getrm", 0, "kotalahir")
                If sqls.getDataSet("getrm", 0, "tanggallahir") Is Nothing Then
                    deTanggalLahir.EditValue = Nothing
                Else
                    Dim tgllahir As String = sqls.getDataSet("getrm", 0, "tanggallahir")
                    If tgllahir = "" Then
                        deTanggalLahir.EditValue = Nothing
                    Else
                        deTanggalLahir.EditValue = Strdate2Date(tgllahir)
                    End If
                End If
                luePendidikan.EditValue = sqls.getDataSet("getrm", 0, "pendidikan")
                luePekerjaan.EditValue = sqls.getDataSet("getrm", 0, "pekerjaan")
                luePernikahan.EditValue = sqls.getDataSet("getrm", 0, "pernikahan")
                lueHambatan.EditValue = sqls.getDataSet("getrm", 0, "hambatankom")

                'alamat
                sqls.DMLQuery("select a.idalamat,a.idnegara,a.idpropinsi,a.idkabupaten,a.idkecamatan,a.idkelurahan,a.alamat,a.addresstype,a.isdeleted,a.isprimary,isnull(a.kodepos,'0') as kodepos from alamat a where a.addresstype=2 and a.tablereff='PASIEN' and a.idreff='" & idselect & "'", "alamat")
                lueNegara.EditValue = sqls.getDataSet("alamat", 0, "idnegara")
                luePropinsi.EditValue = If(sqls.getDataSet("alamat", 0, "idpropinsi"), Nothing)
                lueKabupaten.EditValue = If(sqls.getDataSet("alamat", 0, "idkabupaten"), Nothing)
                lueKecamatan.EditValue = If(sqls.getDataSet("alamat", 0, "idkecamatan"), Nothing)
                lueKelurahan.EditValue = If(sqls.getDataSet("alamat", 0, "idkelurahan"), Nothing)
                teKodepos.EditValue = sqls.getDataSet("alamat", 0, "kodepos")
                meAlamat.EditValue = sqls.getDataSet("alamat", 0, "alamat")

                'phone
                sqls.DMLQuery("select p.idphone,p.phone,p.extension,p.phonetype,p.isdeleted,p.isprimary from phone p where p.tablereff='PASIEN' and isprimary=1 and isdeleted=0 and phonetype=2 and p.idreff='" & idselect & "'", "phonerumah")
                teTelpRumah.EditValue = IIf(sqls.getDataSet("phonerumah") > 0, sqls.getDataSet("phonerumah", 0, "phone"), Nothing)
                sqls.DMLQuery("select p.idphone,p.phone,p.extension,p.phonetype,p.isdeleted,p.isprimary from phone p where p.tablereff='PASIEN' and isprimary=1 and isdeleted=0 and phonetype=1 and p.idreff='" & idselect & "'", "phonekantor")
                teTelpKantor.EditValue = IIf(sqls.getDataSet("phonekantor") > 0, sqls.getDataSet("phonekantor", 0, "phone"), Nothing)
                teExtension.EditValue = IIf(sqls.getDataSet("phonekantor") > 0, sqls.getDataSet("phonekantor", 0, "extension"), Nothing)
                sqls.DMLQuery("select p.idphone,p.phone,p.extension,p.phonetype,p.isdeleted,p.isprimary from phone p where p.tablereff='PASIEN' and isprimary=1 and isdeleted=0 and phonetype=3 and p.idreff='" & idselect & "'", "phonehp")
                teTelpHP.EditValue = IIf(sqls.getDataSet("phonehp") > 0, sqls.getDataSet("phonehp", 0, "phone"), Nothing)

                'email
                sqls.DMLQuery("select e.idemail,e.email,e.emailtype,e.isdeleted,e.isprimary from email e where e.emailtype=1 and e.isprimary=1 and isdeleted=0 and e.tablereff='PASIEN' and e.idreff='" & idselect & "'", "email")
                teEmail.EditValue = IIf(sqls.getDataSet("email") > 0, sqls.getDataSet("email", 0, "email"), Nothing)

                'keluarga
                sqls.DMLQuery("select idkeluarga,familytype,nama from keluarga where isdeleted=0 and tablereff='PASIEN' and idreff='" & idselect & "'", "keluarga")

                Dim tmpidkeluarga As String = 0
                If sqls.getDataSet("keluarga") > 0 Then
                    teNamaKeluarga.EditValue = sqls.getDataSet("keluarga", 0, "nama")
                    lueJenisKeluarga.EditValue = sqls.getDataSet("keluarga", 0, "familytype")

                    tmpidkeluarga = CStr(sqls.getDataSet("keluarga", 0, "idkeluarga"))

                    'telepon keluarga
                    sqls.DMLQuery("select phone from phone where phonetype=3 and tablereff='KELUARGAPASIEN' and idreff='" & tmpidkeluarga & "'", "kphone1")
                    If sqls.getDataSet("kphone1") > 0 Then
                        teKeluargaPhone1.EditValue = sqls.getDataSet("kphone1", 0, "phone")
                    Else
                        teKeluargaPhone1.EditValue = Nothing
                    End If
                    sqls.DMLQuery("select phone from phone where phonetype=2 and tablereff='KELUARGAPASIEN' and idreff='" & tmpidkeluarga & "'", "kphone2")
                    If sqls.getDataSet("kphone2") > 0 Then
                        teKeluargaPhone2.EditValue = sqls.getDataSet("kphone2", 0, "phone")
                    Else
                        teKeluargaPhone2.EditValue = Nothing
                    End If

                    sqls.DMLQuery("select idalamat,idnegara,idpropinsi,idkabupaten,idkecamatan,idkelurahan,alamat,kodepos from alamat where isdeleted=0 and isprimary=1 and addresstype=2 and idreff='" & tmpidkeluarga & "' and tablereff='KELUARGAPASIEN'", "kalamat")
                    If sqls.getDataSet("kalamat") > 0 Then
                        lueKNegara.EditValue = sqls.getDataSet("kalamat", 0, "idnegara")
                        lueKPropinsi.EditValue = If(sqls.getDataSet("kalamat", 0, "idpropinsi"), Nothing)
                        lueKKabupaten.EditValue = If(sqls.getDataSet("kalamat", 0, "idkabupaten"), Nothing)
                        lueKKecamatan.EditValue = If(sqls.getDataSet("kalamat", 0, "idkecamatan"), Nothing)
                        lueKKelurahan.EditValue = If(sqls.getDataSet("kalamat", 0, "idkelurahan"), Nothing)
                        meKAlamat.EditValue = sqls.getDataSet("kalamat", 0, "alamat")
                        teKKodepos.EditValue = sqls.getDataSet("kalamat", 0, "kodepos")
                    Else
                        lueKNegara.EditValue = Nothing
                        lueKPropinsi.EditValue = Nothing
                        lueKKabupaten.EditValue = Nothing
                        lueKKecamatan.EditValue = Nothing
                        lueKKelurahan.EditValue = Nothing
                        meKAlamat.EditValue = Nothing
                        teKKodepos.EditValue = Nothing
                    End If
                Else
                    teNamaKeluarga.EditValue = Nothing
                    lueJenisKeluarga.EditValue = Nothing
                    teKeluargaPhone1.EditValue = Nothing
                    teKeluargaPhone2.EditValue = Nothing

                    lueKNegara.EditValue = Nothing
                    lueKPropinsi.EditValue = Nothing
                    lueKKabupaten.EditValue = Nothing
                    lueKKecamatan.EditValue = Nothing
                    lueKKelurahan.EditValue = Nothing
                    meKAlamat.EditValue = Nothing
                    teKKodepos.EditValue = Nothing
                End If
            End If
        End If
        disposechild(cari, Nothing)
    End Sub

    Private Sub ceSalinAlamat_CheckedChanged(sender As Object, e As EventArgs) Handles ceSalinAlamat.CheckedChanged
        If ceSalinAlamat.EditValue = True Then
            lueKNegara.EditValue = lueNegara.EditValue
            lueKPropinsi.EditValue = luePropinsi.EditValue
            lueKKabupaten.EditValue = lueKabupaten.EditValue
            lueKKecamatan.EditValue = lueKecamatan.EditValue
            lueKKelurahan.EditValue = lueKelurahan.EditValue
            teKKodepos.Text = teKodepos.Text
            meKAlamat.Text = meAlamat.Text
        Else
            lueKNegara.EditValue = Nothing
            lueKPropinsi.EditValue = Nothing
            lueKKabupaten.EditValue = Nothing
            lueKKecamatan.EditValue = Nothing
            lueKKelurahan.EditValue = Nothing
            teKKodepos.Text = ""
            meKAlamat.Text = ""
        End If
    End Sub

    Private Sub btnRMOldData_Click(sender As Object, e As EventArgs) Handles btnRMOldData.Click
        formTitle = ""
        Dim rmold As New frmRMOldData()
        tambahChild(rmold)
        rmold.Size = New Size(800, 600)
        rmold.MaximumSize = New Size(800, 600)
        rmold.StartPosition = FormStartPosition.CenterScreen
        rmold.pMinimize.Enabled = False
        rmold.pMaximize.Enabled = False
        rmold.tlpForm.RowCount = 4
        rmold.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        rmold.ShowDialog(Me)
        disposechild(rmold, Nothing)
    End Sub

    Enum cu
        preview = 1
        cetak = 2
    End Enum
    Private Sub btnCetakRegistrasi_Click(sender As Object, e As EventArgs) Handles btnCetakRegistrasi.Click
        Dim sqls As New SQLs(dbstring)
        'sqls.DMLQuery("Select r.idregistrasi, Convert(varchar, r.registrasidate, 105) +' '+convert(varchar,r.registrasidate,108) as 'Tgl Registrasi',r.registrasino as 'No Registrasi',pm.nama as 'Tenaga Medis',dbo.fformatnorm(rm.rekammedisno) as 'No RM',rm.nama as 'Nama Pasien',jk.generalcode as 'Jenis Kelamin',convert(varchar,rm.tanggallahir,105) as 'Tgl Lahir',dbo.fUmurRegister(rm.tanggallahir,r.registrasidate) as 'Umur',kw.wilayah as 'Kewarganegaraan' from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' left join wilayah kw on rm.kewarganegaraan=kw.idwilayah  left join paramedis pm on r.iddokterruangan=pm.idparamedis where (r.registrasistatus=0 or r.registrasistatus=1) and convert(varchar,r.registrasidate,105)=convert(varchar,getdate(),105) order by r.registrasino desc,r.registrasidate desc", "search")
        sqls.DMLQuery("select r.idrekammedis,convert(varchar,r.createddate,105)+' '+convert(varchar,r.createddate,108) as 'Tgl. Simpan',dbo.fFormatNoRM(r.rekammedisno) as 'No. RM',r.nama as 'Nama Pasien',jk.generalcode as 'Jenis Kelamin',convert(varchar,r.tanggallahir,105) as 'Tgl. Lahir',dbo.fUmurRegister(r.tanggallahir,r.createddate) as 'Umur',kw.wilayah as 'Kewarganegaraan' from rekammedis r left join sys_generalcode jk on r.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' left join wilayah kw on r.kewarganegaraan=kw.idwilayah where r.rekammedisno<>0 order by r.rekammedisno desc", "search")
        Dim cari As New frmSearch(sqls.dataSet, "search", "idrekammedis")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim idselectu As String = CStr(cari.GetIDSelectData)

            Dim selectPrint As New frmPrintSelect()
            tambahChild(selectPrint)
            selectPrint.ShowDialog()

            Dim prntname As String = ""
            If selectPrint.getStringPilih = "PREVIEW" Then
                cetakBerkas(idselectu, cu.preview)
            ElseIf selectPrint.getStringPilih = "CETAK" Then
                prntname = getPrinter("PXNEW")
                cetakBerkas(idselectu, cu.cetak, prntname)
            End If
            'sqls.DMLQuery("select rm.idrekammedis from rekammedis rm left join registrasi r on r.idrekammedis=rm.idrekammedis where r.idregistrasi='" & idselectu & "'", "getrm")
            'idselectu = sqls.getDataSet("getrm", 0, "idrekammedis")
            'Dim sd As New frmSelectDevice
            'tambahChild(sd)
            ' If sd.ShowDialog() = DialogResult.OK Then
            'prntname = sd.getdevicename
            'End If
        End If
    End Sub

    Private Sub btnWilayah_Click(sender As Object, e As EventArgs) Handles btnWilayah.Click
        Dim cariwil As New frmCariWilayah()
        tambahChild(cariwil)
        cariwil.ShowDialog(Me)
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
        disposechild(child, Nothing)
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

    Private Sub teSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teSearch.KeyPress
        If teSearch.Text.Replace(" ", "") = "" Then Exit Sub
        If Asc(e.KeyChar) = 13 Then
            btnCari_Click(btnCari, Nothing)
        End If
    End Sub

    Private isrmaktif As Boolean = False
    Private Sub teNoRM_LostFocus(sender As Object, e As EventArgs) Handles teNoRM.LostFocus
        If CLng(teNoRM.Text.Replace("-", "")) <> 0 Then
            If isrmaktif = False Then
                Dim sqls2 As New SQLs(dbstring)
                If statData = statusData.Baru Then
                    sqls2.DMLQuery("select rekammedisno from rekammedis where isdeleted=0 and rekammedisno='" & CLng(teNoRM.Text.Replace("-", "")) & "'", "ceknorm")
                ElseIf statData = statusData.Edit Then
                    sqls2.DMLQuery("select rekammedisno from rekammedis where isdeleted=0 and rekammedisno='" & CLng(teNoRM.Text.Replace("-", "")) & "' and idrekammedis<>'" & idData & "'", "ceknorm")
                End If
                If sqls2.getDataSet("ceknorm") > 0 Then
                    isrmaktif = True
                    dizMsgbox("No RM tersebut masih aktif", dizMsgboxStyle.Peringatan, Me)
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub teNoRM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teNoRM.KeyPress
        isrmaktif = False
    End Sub

    Private Sub btnCetakStiker_Click(sender As Object, e As EventArgs) Handles btnCetakStiker.Click
        Dim radsel10 As New frmSelectLabel10RM()
        radsel10.ShowDialog(Me)
    End Sub

End Class