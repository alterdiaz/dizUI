Public Class frmPasien
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

        mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where levelwilayah=1 order by wilayah asc", "kwn")
        lueKewarganegaraan.Properties.DataSource = mysqls.dataTable("kwn")
        lueKewarganegaraan.Properties.DisplayMember = "content"
        lueKewarganegaraan.Properties.ValueMember = "id"
        If mysqls.getDataSet("kwn") = 0 Then
            dizMsgbox("Kewarganegaraan tidak ditemukan" & vbCrLf & "Kewarganegaraan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
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

        mysqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='CARDDATETYPE'", "carddatetype")
        lueJenisTanggalKartu.Properties.DataSource = mysqls.dataTable("carddatetype")
        lueJenisTanggalKartu.Properties.DisplayMember = "content"
        lueJenisTanggalKartu.Properties.ValueMember = "id"
        If mysqls.getDataSet("carddatetype") = 0 Then
            dizMsgbox("Jenis Tanggal Kartu tidak ditemukan" & vbCrLf & "Jenis Tanggal Kartu harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='CARDTYPE'", "cardtype")
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

        mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isdeleted=0 and levelwilayah=1", "negara")
        lueNegara.Properties.DataSource = mysqls.dataTable("negara")
        lueNegara.Properties.DisplayMember = "content"
        lueNegara.Properties.ValueMember = "id"
        If mysqls.getDataSet("negara") = 0 Then
            dizMsgbox("Negara tidak ditemukan" & vbCrLf & "Negara harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If
        lueKelurahan.EditValue = Nothing
        lueKecamatan.EditValue = Nothing
        lueKabupaten.EditValue = Nothing
        luePropinsi.EditValue = Nothing

        mysqls.DMLQuery("select idgeneral as id, generalcode as content,priority from sys_generalcode where gctype='ADDRESSTYPE' order by priority asc", "addresstype")
        lueAddressType.Properties.DataSource = mysqls.dataTable("addresstype")
        lueAddressType.Properties.DisplayMember = "content"
        lueAddressType.Properties.ValueMember = "id"

        mysqls.DMLQuery("select idgeneral as id, generalcode as content,priority from sys_generalcode where gctype='EMAILTYPE' order by priority asc", "emailtype")
        lueEmailType.Properties.DataSource = mysqls.dataTable("emailtype")
        lueEmailType.Properties.DisplayMember = "content"
        lueEmailType.Properties.ValueMember = "id"

        mysqls.DMLQuery("select idgeneral as id, generalcode as content,priority from sys_generalcode where gctype='PHONETYPE' order by priority asc", "phonetype")
        luePhoneType.Properties.DataSource = mysqls.dataTable("phonetype")
        luePhoneType.Properties.DisplayMember = "content"
        luePhoneType.Properties.ValueMember = "id"
    End Sub

    Private isFromLoad As Boolean = True
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        xtcAdditional.SelectedTabPage = xtpInfo

        xtpInfo.PageEnabled = True
        xtpAddress.PageVisible = False
        xtpEmail.PageVisible = False
        xtpKartu.PageVisible = False
        xtpKeluarga.PageVisible = False
        xtpTelepon.PageVisible = False
        xtcAdditional.SelectedTabPage = xtpInfo

        kosongkanIsian(tlpAlamat1)
        kosongkanIsian(tlpAlamat2)
        kosongkanIsian(tlpEmail)
        kosongkanIsian(tlpTelepon)
        kosongkanIsian(tlpKartu)
        kosongkanIsian(tlpKeluarga)

        kosongkanIsian(tlpAsalPasien)
        kosongkanIsian(tlpPasien)
        'btnNew.Enabled = True
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnDelete.Text = "HAPUS"
        btnPrintForm.Enabled = False
        btnPrintKartu.Enabled = False
        statData = statusData.Baru
        idData = "-1"
        idDatachild = "-1"

        lblAsalPx2.Visible = False
        lueAsalPx2.Visible = False
        lueAsalPx2.EditValue = Nothing
        lblAsalPx3.Visible = False
        lueAsalPx3.Visible = False
        lueAsalPx3.EditValue = Nothing
        lblAsalPx4.Visible = False
        lueAsalPx4.Visible = False
        lueAsalPx4.EditValue = Nothing

        lueAsalPx.Properties.ReadOnly = True
        lueAsalPx.BackColor = entryDisabled
        lueAsalPx2.Properties.ReadOnly = True
        lueAsalPx2.BackColor = entryDisabled
        lueAsalPx3.Properties.ReadOnly = True
        lueAsalPx3.BackColor = entryDisabled
        lueAsalPx4.Properties.ReadOnly = True
        lueAsalPx4.BackColor = entryDisabled

        If isFromLoad = True Then
            'btnNew.Enabled = True
            btnSave.Enabled = False
        Else
            Dim selectPelayanan As New frmRMSelect()
            tambahChild(selectPelayanan)
            selectPelayanan.ShowDialog()
            If selectPelayanan.getStringPilih = "Dengan NoRM" Then
                Dim sqls As New SQLs(dbstring)
                sqls.DMLQuery("select case when isnull(max(convert(bigint,rekammedisno)),0)=0 then 1 else max(convert(bigint,rekammedisno))+1 end as mrn from rekammedis", "lastmrn")
                teNoRM.Text = Format(CLng(sqls.getDataSet("lastmrn", 0, "mrn").ToString.Replace("-", "")), "0#######")
                pBody.AutoScrollPosition = New Point(0, 0)
            ElseIf selectPelayanan.getStringPilih = "Tanpa NoRM" Then
                teNoRM.Text = 0
                pBody.AutoScrollPosition = New Point(0, 0)
            End If
            disposechild(selectPelayanan, Nothing)
        End If
        isFromLoad = False
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
            sqls.DMLQuery("select rekammedisno from rekammedis where isdeleted=0 and rekammedisno='" & CLng(teNoRM.Text.Replace("-", "")) & "'", "cekrm")
            If sqls.getDataSetRowCount("cekrm") = 0 Then
                field.AddRange(New String() {"idrekammedis", "isdeleted", "updatedby", "updateddate"})
                value.AddRange(New Object() {idData, 0, userid, nowTime})
                retval = sqls.datasetSave("rekammedis", idData, field, value, False)
                isiLog(userid, dbstring, field, value, "rekammedis")
            Else
                dizMsgbox("Data aktif masih ada", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
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
        isFromLoad = True
        btnNew_Click(Me, Nothing)
    End Sub

    Private Sub loadAlamat(idreff As String)
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select a.idalamat,a.idnegara,a.idpropinsi,a.idkabupaten,a.idkecamatan,a.idkelurahan,a.alamat,a.addresstype,a.isdeleted,a.isprimary,isnull(n.wilayah,'-') as negara,isnull(p.wilayah,'-') as propinsi,isnull(b.wilayah,'-') as kabupaten,isnull(c.wilayah,'-') as kecamatan,isnull(l.wilayah,'-') as kelurahan,del.generalcode as statdata,pri.generalcode as [primary],adt.generalcode as jenisalamat,isnull(a.kodepos,'-') as kodepos from alamat a left join wilayah n on a.idnegara=n.idwilayah left join wilayah p on a.idpropinsi=p.idwilayah left join wilayah b on a.idkabupaten=b.idwilayah left join wilayah c on a.idkecamatan=c.idwilayah left join wilayah l on a.idkelurahan=l.idwilayah left join sys_generalcode del on a.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode pri on a.isprimary=pri.idgeneral and pri.gctype='ISPRIMARY' left join sys_generalcode adt on a.addresstype=adt.idgeneral and adt.gctype='ADDRESSTYPE' where a.tablereff='PASIEN' and a.idreff='" & idreff & "'", "alamat")
        gcAlamat.DataSource = sqls.dataTable("alamat")
        gvAlamat.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub loadEmail(idreff As String)
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select e.idemail,e.email,e.emailtype,e.isdeleted,e.isprimary,del.generalcode as statdata,pri.generalcode as [primary],et.generalcode as jenisemail from email e left join sys_generalcode et on e.emailtype=et.idgeneral and et.gctype='EMAILTYPE' left join sys_generalcode del on e.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode pri on e.isprimary=pri.idgeneral and pri.gctype='ISPRIMARY' where e.tablereff='PASIEN' and e.idreff='" & idreff & "'", "email")
        gcEmail.DataSource = sqls.dataTable("email")
        gvEmail.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub loadPhone(idreff As String)
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select p.idphone,p.phone,p.extension,p.phonetype,p.isdeleted,p.isprimary,del.generalcode as statdata,pri.generalcode as [primary],et.generalcode as jenistelepon from phone p left join sys_generalcode et on p.phonetype=et.idgeneral and et.gctype='PHONETYPE' left join sys_generalcode del on p.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode pri on p.isprimary=pri.idgeneral and pri.gctype='ISPRIMARY' where p.tablereff='PASIEN' and p.idreff='" & idreff & "'", "phone")
        gcTelepon.DataSource = sqls.dataTable("phone")
        gvTelepon.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub loadKartu(idreff As String)
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select k.idkartu,k.jeniskartu,ct.generalcode as cardtype,k.isdeleted,del.generalcode as statdata,k.jenistanggal,cdt.generalcode as carddatetype,k.nomorkartu,k.namakartu,convert(varchar,k.tanggalkartu,105) as tanggalkartu,k.isprimary,kt.generalcode as primary1 from kartu k left join sys_generalcode kt on k.isprimary=kt.idgeneral and kt.gctype='ISPRIMARY' left join sys_generalcode ct on k.jeniskartu=ct.idgeneral and ct.gctype='CARDTYPE' left join sys_generalcode cdt on k.jenistanggal=cdt.idgeneral and cdt.gctype='CARDDATETYPE' left join sys_generalcode del on k.isdeleted=del.idgeneral and del.gctype='DELETE' where k.tablereff='PASIEN' and k.idreff='" & idreff & "'", "kartu")
        gcKartu.DataSource = sqls.dataTable("kartu")
        gvKartu.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub loadKeluarga(idreff As String)
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select k.idkeluarga,k.nama,k.familytype,ft.generalcode as jeniskeluarga,k.isdeleted,del.generalcode as statdata,pp.idphone as idphone1,isnull(pp.phone,0) as phone1,ps.idphone as idphone2,isnull(ps.phone,0) as phone2 from keluarga k left join sys_generalcode ft on k.familytype=ft.idgeneral and ft.gctype='FAMILYTYPE' left join sys_generalcode del on k.isdeleted=del.idgeneral and del.gctype='DELETE' left join phone pp on k.idkeluarga=pp.idreff and pp.tablereff='KELUARGAPASIEN' and pp.isprimary=1 and pp.phonetype=2 left join phone ps on k.idkeluarga=ps.idreff and ps.tablereff='KELUARGAPASIEN' and ps.isprimary=1 and ps.phonetype=3 where k.tablereff='PASIEN' and k.idreff='" & idreff & "'", "keluarga")
        gcKeluarga.DataSource = sqls.dataTable("keluarga")
        gvKeluarga.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub enablePanel(alamat As Boolean, email As Boolean, telepon As Boolean, kartu As Boolean)
        btnNewAlamat.Enabled = alamat
        btnSaveAlamat.Enabled = alamat
        btnDeleteAlamat.Enabled = alamat
        btnNewEmail.Enabled = email
        btnSaveEmail.Enabled = email
        btnDeleteEmail.Enabled = email
        btnNewTelepon.Enabled = telepon
        btnSaveTelepon.Enabled = telepon
        btnDeleteTelepon.Enabled = telepon
        btnNewKartu.Enabled = kartu
        btnSaveKartu.Enabled = kartu
        btnDeleteKartu.Enabled = kartu
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'btnNew.Visible = False

        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        checkFieldMaxLength(dbstring, tlpAsalPasien, "rekammedis")
        checkFieldMaxLength(dbstring, tlpPasien, "rekammedis")

        checkFieldMaxLength(dbstring, tlpPasien, "rekammedis")
        checkFieldMaxLength(dbstring, tlpAlamat1, "alamat")
        checkFieldMaxLength(dbstring, tlpAlamat2, "alamat")
        checkFieldMaxLength(dbstring, tlpEmail, "email")
        checkFieldMaxLength(dbstring, tlpTelepon, "phone")
        checkFieldMaxLength(dbstring, tlpKartu, "kartu")
        checkFieldMaxLength(dbstring, tlpKeluarga, "keluarga")
        checkFieldMaxLength(dbstring, tlpKeluarga, "phone")
        deTanggalLahir.Properties.MaxValue = nowTime

        loadLOV()
        btnNew_Click(Me, Nothing)
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

    Private Sub Angka_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tePhone.KeyPress, teExtension.KeyPress, teKodepos.KeyPress
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

    Private Sub btnNewAlamat_Click(sender As Object, e As EventArgs) Handles btnNewAlamat.Click
        kosongkanIsian(tlpAlamat1)
        kosongkanIsian(tlpAlamat2)

        btnNewAlamat.Enabled = False
        btnSaveAlamat.Enabled = True
        btnPrimaryAlamat.Enabled = False
        btnPrimaryAlamat.Text = "PRIMARY"
        btnDeleteAlamat.Enabled = False
        btnDeleteAlamat.Text = "HAPUS"
        statDataChild = statusData.Baru
        idDatachild = "-1"
    End Sub

    Private Sub btnPrimaryAlamat_Click(sender As Object, e As EventArgs) Handles btnPrimaryAlamat.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idalamat", "isprimary", "updatedby", "updateddate"})
        If btnPrimaryAlamat.Text = "PRIMARY" Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("update alamat set isprimary=0 where idreff='" & idData & "' and tablereff='PASIEN'", False)

            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("alamat", idDataChild, field, value, False)
            btnPrimaryAlamat.Text = "NOT PRIMARY"
        ElseIf btnDeleteAlamat.Text = "NOT PRIMARY" Then
            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("alamat", idDataChild, field, value, False)
            btnPrimaryAlamat.Text = "PRIMARY"
        End If
        loadAlamat(idData)
        btnNewAlamat_Click(btnNewAlamat, Nothing)
    End Sub

    Private Sub btnDeleteAlamat_Click(sender As Object, e As EventArgs) Handles btnDeleteAlamat.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idalamat", "isdeleted", "updatedby", "updateddate"})
        If btnDeleteAlamat.Text = "HAPUS" Then
            value.AddRange(New Object() {idDataChild, 1, userid, nowTime})
            dtsql.datasetSave("alamat", idDataChild, field, value, False)
            btnDeleteAlamat.Text = "AKTIF"
        ElseIf btnDeleteAlamat.Text = "AKTIF" Then
            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("alamat", idDataChild, field, value, False)
            btnDeleteAlamat.Text = "HAPUS"
        End If
        loadAlamat(idData)
        btnNewAlamat_Click(btnNewAlamat, Nothing)
    End Sub

    Private Sub btnSaveAlamat_Click(sender As Object, e As EventArgs) Handles btnSaveAlamat.Click
        Dim bentry As Boolean = True
        bentry = checkEntry(tlpAlamat1)
        bentry = checkEntry(tlpAlamat2)
        If bentry = False Then
            dizMsgbox("Data Alamat belum diisi dengan benar", dizMsgboxStyle.Peringatan, "Peringatan", Me)
            Exit Sub
        End If
        If statDataChild = statusData.Baru Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            Dim sqls As New SQLs(dbstring)
            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            field.AddRange(New String() {"idalamat", "idcompany", "idreff", "tablereff", "idnegara", "idpropinsi", "idkabupaten", "idkecamatan", "idkelurahan", "alamat", "addresstype", "kodepos", "isdeleted", "isprimary", "createdby", "createddate"})
            If gvAlamat.RowCount = 0 Then
                value.AddRange(New Object() {idDataChild, idcomp, idData, "PASIEN", If(lueNegara.EditValue, CObj(DBNull.Value)), If(luePropinsi.EditValue, CObj(DBNull.Value)), If(lueKabupaten.EditValue, CObj(DBNull.Value)), If(lueKecamatan.EditValue, CObj(DBNull.Value)), If(lueKelurahan.EditValue, CObj(DBNull.Value)), meAlamat.Text, lueAddressType.EditValue, teKodepos.Text, 0, 1, userid, nowTime})
            Else
                value.AddRange(New Object() {idDataChild, idcomp, idData, "PASIEN", If(lueNegara.EditValue, CObj(DBNull.Value)), If(luePropinsi.EditValue, CObj(DBNull.Value)), If(lueKabupaten.EditValue, CObj(DBNull.Value)), If(lueKecamatan.EditValue, CObj(DBNull.Value)), If(lueKelurahan.EditValue, CObj(DBNull.Value)), meAlamat.Text, lueAddressType.EditValue, teKodepos.Text, 0, 0, userid, nowTime})
            End If
            If dtsql.datasetSave("alamat", idDataChild, field, value, False) = True Then
                Dim idtmp As String = GenerateGUID()
                dtsql = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.Clear()
                value.Clear()

                field.AddRange(New String() {"idrekammedisriwayat", "idrekammedis", "iduser", "createddate", "remarks"})
                value.AddRange(New Object() {idtmp, idData, userid, nowTime, "Rekam Medis - Alamat ditambahkan oleh " & username})
                dtsql.datasetSave("rekammedisriwayat", idtmp, field, value, False)

                isiLog(userid, dbstring, field, value, "alamat")
                dizMsgbox("Alamat telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            field.AddRange(New String() {"idalamat", "idreff", "tablereff", "idnegara", "idpropinsi", "idkabupaten", "idkecamatan", "idkelurahan", "alamat", "addresstype", "kodepos", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, idData, "PASIEN", If(lueNegara.EditValue, CObj(DBNull.Value)), If(luePropinsi.EditValue, CObj(DBNull.Value)), If(lueKabupaten.EditValue, CObj(DBNull.Value)), If(lueKecamatan.EditValue, CObj(DBNull.Value)), If(lueKelurahan.EditValue, CObj(DBNull.Value)), meAlamat.Text, lueAddressType.EditValue, teKodepos.Text, userid, nowTime})
            If dtsql.datasetSave("alamat", idDataChild, field, value, False) = True Then
                Dim idtmp As String = GenerateGUID()
                dtsql = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.Clear()
                value.Clear()

                field.AddRange(New String() {"idrekammedisriwayat", "idrekammedis", "iduser", "createddate", "remarks"})
                value.AddRange(New Object() {idtmp, idData, userid, nowTime, "Rekam Medis - Alamat diedit oleh " & username})
                dtsql.datasetSave("rekammedisriwayat", idtmp, field, value, False)

                isiLog(userid, dbstring, field, value, "alamat")
                dizMsgbox("Alamat telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        End If
        loadAlamat(idData)
        btnNewAlamat_Click(btnNewAlamat, Nothing)
    End Sub

    Private Sub gvAlamat_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvAlamat.FocusedRowChanged
        Dim dcol As DataRow = gvAlamat.GetDataRow(e.FocusedRowHandle)

        statDataChild = statusData.Edit
        idDataChild = dcol("idalamat")
        lueNegara.EditValue = dcol("idnegara")
        luePropinsi.EditValue = dcol("idpropinsi")
        lueKabupaten.EditValue = dcol("idkabupaten")
        lueKecamatan.EditValue = dcol("idkecamatan")
        lueKelurahan.EditValue = dcol("idkelurahan")
        lueAddressType.EditValue = dcol("addresstype")
        teKodepos.Text = dcol("kodepos")
        meAlamat.Text = dcol("alamat")
        If dcol("isprimary") = CLng(0) Then
            btnPrimaryAlamat.Text = "PRIMARY"
        ElseIf dcol("isprimary") = CLng(1) Then
            btnPrimaryAlamat.Text = "NOT PRIMARY"
        End If
        If dcol("isdeleted") = 0 Then
            btnDeleteAlamat.Text = "HAPUS"
        ElseIf dcol("isdeleted") = 1 Then
            btnDeleteAlamat.Text = "AKTIF"
        End If
        btnNewAlamat.Enabled = True
        btnSaveAlamat.Enabled = True
        btnDeleteAlamat.Enabled = True
    End Sub


    Private Sub btnNewEmail_Click(sender As Object, e As EventArgs) Handles btnNewEmail.Click
        kosongkanIsian(tlpEmail)

        btnNewEmail.Enabled = False
        btnSaveEmail.Enabled = True
        btnPrimaryEmail.Enabled = False
        btnPrimaryEmail.Text = "PRIMARY"
        btnDeleteEmail.Enabled = False
        btnDeleteEmail.Text = "HAPUS"
        statDataChild = statusData.Baru
        idDatachild = "-1"
    End Sub

    Private Sub btnDeleteEmail_Click(sender As Object, e As EventArgs) Handles btnDeleteEmail.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idemail", "isdeleted", "updatedby", "updateddate"})
        If btnDeleteEmail.Text = "HAPUS" Then
            value.AddRange(New Object() {idDataChild, 1, userid, nowTime})
            dtsql.datasetSave("email", idDataChild, field, value, False)
            btnDeleteEmail.Text = "AKTIF"
        ElseIf btnDeleteEmail.Text = "AKTIF" Then
            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("email", idDataChild, field, value, False)
            btnDeleteEmail.Text = "HAPUS"
        End If
        loadEmail(idData)
        btnNewEmail_Click(btnNewEmail, Nothing)
    End Sub

    Private Sub btnSaveEmail_Click(sender As Object, e As EventArgs) Handles btnSaveEmail.Click
        Dim bentry As Boolean = True
        bentry = checkEntry(tlpEmail)
        If bentry = False Then
            dizMsgbox("Data Email belum diisi dengan benar", dizMsgboxStyle.Peringatan, "Peringatan", Me)
            Exit Sub
        End If
        If statDataChild = statusData.Baru Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select email from email where tablereff='PASIEN' and idreff='" & idData & "' and email='" & teEmail.Text & "'", "cek")
            If sqls.getDataSet("cek") = 0 Then
                idDatachild = "-1"
            Else
                dizMsgbox("Email tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teEmail.Focus()
                Exit Sub
            End If
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            field.AddRange(New String() {"idemail", "idcompany", "idreff", "tablereff", "email", "emailtype", "isdeleted", "isprimary", "createdby", "createddate"})
            If gvAlamat.RowCount = 0 Then
                value.AddRange(New Object() {idDataChild, idcomp, idData, "PASIEN", teEmail.Text, lueEmailType.EditValue, 0, 1, userid, nowTime})
            Else
                value.AddRange(New Object() {idDataChild, idcomp, idData, "PASIEN", teEmail.Text, lueEmailType.EditValue, 0, 0, userid, nowTime})
            End If
            If dtsql.datasetSave("email", idDataChild, field, value, False) = True Then
                dtsql = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.Clear()
                value.Clear()
                Dim idtmp As String = GenerateGUID()

                field.AddRange(New String() {"idrekammedisriwayat", "idrekammedis", "iduser", "createddate", "remarks"})
                value.AddRange(New Object() {idtmp, idData, userid, nowTime, "Rekam Medis - Email ditambahkan oleh " & username})
                dtsql.datasetSave("rekammedisriwayat", idtmp, field, value, False)

                isiLog(userid, dbstring, field, value, "email")
                dizMsgbox("Email telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            field.AddRange(New String() {"idemail", "idreff", "tablereff", "email", "emailtype", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, idData, "PASIEN", teEmail.Text, lueEmailType.EditValue, userid, nowTime})
            If dtsql.datasetSave("email", idDataChild, field, value, False) = True Then
                dtsql = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.Clear()
                value.Clear()
                Dim idtmp As String = GenerateGUID()

                field.AddRange(New String() {"idrekammedisriwayat", "idrekammedis", "iduser", "createddate", "remarks"})
                value.AddRange(New Object() {idtmp, idData, userid, nowTime, "Rekam Medis - Email diedit oleh " & username})
                dtsql.datasetSave("rekammedisriwayat", idtmp, field, value, False)

                isiLog(userid, dbstring, field, value, "email")
                dizMsgbox("Email telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        End If
        loadEmail(idData)
        btnNewEmail_Click(btnNewEmail, Nothing)
    End Sub

    Private Sub btnPrimaryEmail_Click(sender As Object, e As EventArgs) Handles btnPrimaryEmail.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idemail", "isprimary", "updatedby", "updateddate"})
        If btnPrimaryAlamat.Text = "PRIMARY" Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("update email set isprimary=0 where idreff='" & idData & "' and tablereff='PASIEN'", False)

            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("email", idDataChild, field, value, False)
            btnPrimaryAlamat.Text = "NOT PRIMARY"
        ElseIf btnDeleteAlamat.Text = "NOT PRIMARY" Then
            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("email", idDataChild, field, value, False)
            btnPrimaryAlamat.Text = "PRIMARY"
        End If
        loadEmail(idData)
        btnNewEmail_Click(btnNewEmail, Nothing)
    End Sub

    Private Sub gvEmail_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvEmail.FocusedRowChanged
        Dim dcol As DataRow = gvEmail.GetDataRow(e.FocusedRowHandle)

        statDataChild = statusData.Edit
        idDataChild = dcol("idemail")
        lueEmailType.EditValue = dcol("emailtype")
        teEmail.Text = dcol("email")
        If dcol("isprimary") = CLng(0) Then
            btnPrimaryEmail.Text = "PRIMARY"
        ElseIf dcol("isprimary") = CLng(1) Then
            btnPrimaryEmail.Text = "NOT PRIMARY"
        End If
        If dcol("isdeleted") = 0 Then
            btnDeleteEmail.Text = "HAPUS"
        ElseIf dcol("isdeleted") = 1 Then
            btnDeleteEmail.Text = "AKTIF"
        End If
        btnNewEmail.Enabled = True
        btnSaveEmail.Enabled = True
        btnDeleteEmail.Enabled = True
    End Sub


    Private Sub btnNewtelepon_Click(sender As Object, e As EventArgs) Handles btnNewTelepon.Click
        kosongkanIsian(tlpTelepon)

        btnNewTelepon.Enabled = False
        btnSaveTelepon.Enabled = True
        btnPrimaryTelepon.Enabled = False
        btnPrimaryTelepon.Text = "PRIMARY"
        btnDeleteTelepon.Enabled = False
        btnDeleteTelepon.Text = "HAPUS"
        statDataChild = statusData.Baru
        idDatachild = "-1"
    End Sub

    Private Sub btnPrimaryTelepon_Click(sender As Object, e As EventArgs) Handles btnPrimaryTelepon.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idphone", "isprimary", "updatedby", "updateddate"})
        If btnPrimaryAlamat.Text = "PRIMARY" Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("update phone set isprimary=0 where phonetype='" & luePhoneType.EditValue & "' and idreff='" & idData & "' and tablereff='PASIEN'", False)

            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("phone", idDataChild, field, value, False)
            btnPrimaryAlamat.Text = "NOT PRIMARY"
        ElseIf btnDeleteAlamat.Text = "NOT PRIMARY" Then
            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("phone", idDataChild, field, value, False)
            btnPrimaryAlamat.Text = "PRIMARY"
        End If
        loadPhone(idData)
        btnNewtelepon_Click(btnNewTelepon, Nothing)
    End Sub

    Private Sub btnDeleteTelepon_Click(sender As Object, e As EventArgs) Handles btnDeleteTelepon.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idphone", "isdeleted", "updatedby", "updateddate"})
        If btnDeleteTelepon.Text = "HAPUS" Then
            value.AddRange(New Object() {idDataChild, 1, userid, nowTime})
            dtsql.datasetSave("phone", idDataChild, field, value, False)
            btnDeleteTelepon.Text = "AKTIF"
        ElseIf btnDeleteTelepon.Text = "AKTIF" Then
            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("phone", idDataChild, field, value, False)
            btnDeleteTelepon.Text = "HAPUS"
        End If
        loadPhone(idData)
        btnNewtelepon_Click(btnNewTelepon, Nothing)
    End Sub

    Private Sub btnSaveTelepon_Click(sender As Object, e As EventArgs) Handles btnSaveTelepon.Click
        Dim bentry As Boolean = True
        bentry = checkEntry(tlpTelepon)
        If bentry = False Then
            dizMsgbox("Data Telepon belum diisi dengan benar", dizMsgboxStyle.Peringatan, "Peringatan", Me)
            Exit Sub
        End If
        If statDataChild = statusData.Baru Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select phone from phone where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and tablereff='PASIEN' and idreff='" & idData & "' and phone='" & tePhone.Text & "'", "cek")
            If sqls.getDataSet("cek") = 0 Then
                idDatachild = "-1"
            Else
                dizMsgbox("Telepon tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teEmail.Focus()
                Exit Sub
            End If
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            field.AddRange(New String() {"idphone", "idcompany", "idreff", "tablereff", "phone", "extension", "phonetype", "isdeleted", "isprimary", "createdby", "createddate"})
            If gvTelepon.RowCount = 0 Then
                value.AddRange(New Object() {idDataChild, idcomp, idData, "PASIEN", tePhone.Text, teExtension.Text, luePhoneType.EditValue, 0, 1, userid, nowTime})
            Else
                value.AddRange(New Object() {idDataChild, idcomp, idData, "PASIEN", tePhone.Text, teExtension.Text, luePhoneType.EditValue, 0, 0, userid, nowTime})
            End If
            If dtsql.datasetSave("phone", idDataChild, field, value, False) = True Then
                Dim idtmp As String = GenerateGUID()
                dtsql = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.Clear()
                value.Clear()

                field.AddRange(New String() {"idrekammedisriwayat", "idrekammedis", "iduser", "createddate", "remarks"})
                value.AddRange(New Object() {idtmp, idData, userid, nowTime, "Rekam Medis - Telepon ditambahkan oleh " & username})
                dtsql.datasetSave("rekammedisriwayat", idtmp, field, value, False)

                isiLog(userid, dbstring, field, value, "phone")
                dizMsgbox("Telepon telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            field.AddRange(New String() {"idphone", "idreff", "tablereff", "phone", "extension", "phonetype", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, idData, "PASIEN", tePhone.Text, teExtension.Text, luePhoneType.EditValue, userid, nowTime})

            If dtsql.datasetSave("phone", idDataChild, field, value, False) = True Then
                Dim idtmp As String = GenerateGUID()
                dtsql = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.Clear()
                value.Clear()

                field.AddRange(New String() {"idrekammedisriwayat", "idrekammedis", "iduser", "createddate", "remarks"})
                value.AddRange(New Object() {idtmp, idData, userid, nowTime, "Rekam Medis - Telepon diedit oleh " & username})
                dtsql.datasetSave("rekammedisriwayat", idtmp, field, value, False)

                isiLog(userid, dbstring, field, value, "phone")
                dizMsgbox("Telepon telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        End If
        loadPhone(idData)
        btnNewtelepon_Click(btnNewTelepon, Nothing)
    End Sub

    Private Sub gvTelepon_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvTelepon.FocusedRowChanged
        Dim dcol As DataRow = gvTelepon.GetDataRow(e.FocusedRowHandle)

        statDataChild = statusData.Edit
        idDataChild = dcol("idphone")
        luePhoneType.EditValue = dcol("phonetype")
        tePhone.Text = dcol("phone")
        If dcol("isprimary") = 0 Then
            btnPrimaryTelepon.Text = "PRIMARY"
        ElseIf dcol("isprimary") = 1 Then
            btnPrimaryTelepon.Text = "NOT PRIMARY"
        End If
        If dcol("isdeleted") = 0 Then
            btnDeleteTelepon.Text = "HAPUS"
        ElseIf dcol("isdeleted") = 1 Then
            btnDeleteTelepon.Text = "AKTIF"
        End If
        btnNewTelepon.Enabled = True
        btnSaveTelepon.Enabled = True
        btnDeleteTelepon.Enabled = True
    End Sub

    Private Sub xtcAdditional_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtcAdditional.SelectedPageChanged
        If e.Page Is xtpAddress Then
            btnNewAlamat_Click(btnNewAlamat, Nothing)
        ElseIf e.Page Is xtpTelepon Then
            btnNewtelepon_Click(btnNewTelepon, Nothing)
        ElseIf e.Page Is xtpEmail Then
            btnNewEmail_Click(btnNewEmail, Nothing)
        ElseIf e.Page Is xtpKartu Then
            btnNewKartu_Click(btnNewKartu, Nothing)
        End If
    End Sub

    Private Sub btnNewKartu_Click(sender As Object, e As EventArgs) Handles btnNewKartu.Click
        kosongkanIsian(tlpKartu)

        btnNewKartu.Enabled = False
        btnSaveKartu.Enabled = True
        btnDeleteKartu.Enabled = False
        btnDeleteKartu.Text = "HAPUS"
        statDataChild = statusData.Baru
        idDatachild = "-1"
    End Sub

    Private Sub btnSaveKartu_Click(sender As Object, e As EventArgs) Handles btnSaveKartu.Click
        Dim bentry As Boolean = True
        bentry = checkEntry(tlpKartu)
        If bentry = False Then
            dizMsgbox("Data Kartu belum diisi dengan benar", dizMsgboxStyle.Peringatan, "Peringatan", Me)
            Exit Sub
        End If
        If statDataChild = statusData.Baru Then
            Dim isprimary As Long = 0
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select idkartu from kartu where tablereff='PASIEN' and idreff='" & idData & "'", "cntkartu")
            If sqls.getDataSet("cntkartu") = 0 Then
                isprimary = 1
            End If

            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idkartu", "idreff", "tablereff", "jeniskartu", "nomorkartu", "namakartu", "tanggalkartu", "jenistanggal", "isdeleted", "createdby", "createddate", "isprimary", "iscompany"})
            value.AddRange(New Object() {idDataChild, idData, "PASIEN", lueJenisKartu.EditValue, teNomorKartu.Text, teNamaKartu.Text, If(deTanggalKartu.EditValue, CObj(DBNull.Value)), If(lueJenisTanggalKartu.EditValue, 0), 0, userid, nowTime, isprimary, idcomp})
            If dtsql.datasetSave("kartu", idDataChild, field, value, False) = True Then
                Dim idtmp As String = GenerateGUID()
                dtsql = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.Clear()
                value.Clear()

                field.AddRange(New String() {"idrekammedisriwayat", "idrekammedis", "iduser", "createddate", "remarks"})
                value.AddRange(New Object() {idtmp, idData, userid, nowTime, "Rekam Medis - Kartu ditambahkan oleh " & username})
                dtsql.datasetSave("rekammedisriwayat", idtmp, field, value, False)

                dizMsgbox("Kartu telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idkartu", "idreff", "tablereff", "jeniskartu", "nomorkartu", "namakartu", "tanggalkartu", "jenistanggal", "isdeleted", "updatedby", "updateddate"})
            If btnDeleteKartu.Text = "AKTIF" Then
                value.AddRange(New Object() {idDataChild, idData, "PASIEN", lueJenisKartu.EditValue, teNomorKartu.Text, teNamaKartu.Text, If(deTanggalKartu.EditValue, 0), If(lueJenisTanggalKartu.EditValue, CObj(DBNull.Value)), 0, userid, nowTime})
            Else
                value.AddRange(New Object() {idDataChild, idData, "PASIEN", lueJenisKartu.EditValue, teNomorKartu.Text, teNamaKartu.Text, If(deTanggalKartu.EditValue, 0), If(lueJenisTanggalKartu.EditValue, CObj(DBNull.Value)), 10, userid, nowTime})
            End If
            If dtsql.datasetSave("kartu", idDataChild, field, value, False) = True Then
                Dim idtmp As String = GenerateGUID()
                dtsql = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.Clear()
                value.Clear()

                field.AddRange(New String() {"idrekammedisriwayat", "idrekammedis", "iduser", "createddate", "remarks"})
                value.AddRange(New Object() {idtmp, idData, userid, nowTime, "Rekam Medis - Kartu diedit oleh " & username})
                dtsql.datasetSave("rekammedisriwayat", idtmp, field, value, False)

                dizMsgbox("Kartu telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        End If
        loadKartu(idData)
        btnNewKartu_Click(btnNewKartu, Nothing)
    End Sub

    Private Sub btnDeleteKartu_Click(sender As Object, e As EventArgs) Handles btnDeleteKartu.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idkartu", "isdeleted", "updatedby", "updateddate"})
        If btnDeleteKartu.Text = "HAPUS" Then
            value.AddRange(New Object() {idDataChild, 1, userid, nowTime})
            dtsql.datasetSave("kartu", idDataChild, field, value, False)
            btnDeleteKartu.Text = "AKTIF"
        ElseIf btnDeleteKartu.Text = "AKTIF" Then
            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("kartu", idDataChild, field, value, False)
            btnDeleteKartu.Text = "HAPUS"
        End If
        loadKartu(idData)
        btnNewKartu_Click(btnNewKartu, Nothing)
    End Sub

    Private Sub btnPrimaryKartu_Click(sender As Object, e As EventArgs) Handles btnPrimaryKartu.Click
        Dim sqls As New SQLs(dbstring)
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idkartu", "isprimary", "updatedby", "updateddate"})
        If btnPrimaryKartu.Text = "PRIMARY" Then
            sqls.DMLQuery("update kartu set isprimary=0 where tablereff='PASIEN' and idreff='" & idData & "' and idkartu<>'" & idDataChild & "'", False)
            value.AddRange(New Object() {idDataChild, 1, userid, nowTime})
            dtsql.datasetSave("kartu", idDataChild, field, value, False)
            btnDeleteKartu.Text = "NOT PRIMARY"
        ElseIf btnPrimaryKartu.Text = "NOT PRIMARY" Then
            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("kartu", idDataChild, field, value, False)
            btnDeleteKartu.Text = "PRIMARY"
        End If
        loadKartu(idData)
        btnNewKartu_Click(btnNewKartu, Nothing)
    End Sub

    Private Sub gvKartu_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvKartu.FocusedRowChanged
        Dim dcol As DataRow = gvKartu.GetDataRow(e.FocusedRowHandle)

        statDataChild = statusData.Edit
        idDataChild = dcol("idkartu")
        lueJenisKartu.EditValue = dcol("jeniskartu")
        lueJenisTanggalKartu.EditValue = dcol("carddatetype")
        teNamaKartu.Text = dcol("namakartu")
        teNomorKartu.Text = dcol("nomorkartu")
        If IsDBNull(dcol("tanggalkartu")) = False Then
            deTanggalKartu.EditValue = Strdate2Date(dcol("tanggalkartu").ToString)
        Else
            deTanggalKartu.EditValue = Nothing
        End If
        If dcol("isdeleted") = 0 Then
            btnDeleteKartu.Text = "HAPUS"
        ElseIf dcol("isdeleted") = 1 Then
            btnDeleteKartu.Text = "AKTIF"
        End If
        If dcol("isprimary") = 0 Then
            btnPrimaryKartu.Text = "PRIMARY"
        ElseIf dcol("isprimary") = 1 Then
            btnPrimaryKartu.Text = "NOT PRIMARY"
        End If
        btnNewKartu.Enabled = True
        btnSaveKartu.Enabled = True
        btnDeleteKartu.Enabled = True
    End Sub

    Private Sub lueKewarganegaraan_EditValueChanged(sender As Object, e As EventArgs) Handles lueKewarganegaraan.EditValueChanged
        If lueKewarganegaraan.EditValue Is Nothing Then
            lueTempatLahir.EditValue = Nothing
            Exit Sub
        End If
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("if (select count(k.idwilayah) from wilayah p left join wilayah k on p.idwilayah=k.idparent where k.levelwilayah=3 and p.idparent='" & lueKewarganegaraan.EditValue & "')=0 begin select idwilayah as id, wilayah as content from wilayah where levelwilayah=0 order by wilayah asc end else begin select k.idwilayah as id, k.wilayah as content from wilayah p left join wilayah k on p.idwilayah=k.idparent where k.levelwilayah=3 and p.idparent='" & lueKewarganegaraan.EditValue & "' order by k.wilayah asc end", "kota")
        lueTempatLahir.Properties.DataSource = mysqls.dataTable("kota")
        lueTempatLahir.Properties.DisplayMember = "content"
        lueTempatLahir.Properties.ValueMember = "id"
        If mysqls.getDataSet("kota") = 0 Then
            dizMsgbox("Tempat Lahir tidak ditemukan" & vbCrLf & "Tempat Lahir harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If
    End Sub

    Private Sub lueJenisKelamin_EditValueChanged(sender As Object, e As EventArgs) Handles lueJenisKelamin.EditValueChanged
        If lueJenisKelamin.EditValue Is Nothing Then
            lueSapaan.EditValue = Nothing
            Exit Sub
        End If
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If isRestrictedString(teNama.Text, dbstring) = True Then
            dizMsgbox("NAMA tidak boleh " & teNama.Text & ", silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If isRestrictedString(teNamaPanggilan.Text, dbstring) = True Then
            dizMsgbox("NAMA tidak boleh " & teNamaPanggilan.Text & ", silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
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
        If statData = statusData.Baru Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select nama from rekammedis where rekammedisno<>0 and replace(nama,' ','')='" & teNama.Text.Replace(" ", "") & "'", "cek")
            If sqls.getDataSet("cek") = 0 Then
                idData = "-1"
            Else
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teNama.Focus()
                Exit Sub
            End If
        ElseIf statData = statusData.Edit Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select nama from rekammedis where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isdeleted=0 and rekammedisno<>0 and replace(nama,' ','')='" & teNama.Text.Replace(" ", "") & "' and idrekammedis<>'" & idData & "'", "cek")
            If sqls.getDataSet("cek") > 0 Then
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teNama.Focus()
                Exit Sub
            End If
        End If

        Dim dtSQL As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        If statData = statusData.Baru Then
            idData = GenerateGUID()
            field.AddRange(New String() {"idrekammedis", "rekammedisno", "asalpx", "asalpx2", "asalrujukan", "iddokterrujukan", "sapaan", "namapanggilan", "nama", "tanggallahir", "jeniskelamin", "pekerjaan", "pendidikan", "kotalahir", "pernikahan", "agama", "golongandarah", "rhesus", "kewarganegaraan", "ishamil", "hambatankom", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idData, CLng(teNoRM.Text.Replace("-", "")), lueAsalPx.EditValue, lueAsalPx2.EditValue, If(lueAsalPx3.EditValue, 0), If(lueAsalPx4.EditValue, 0), lueSapaan.EditValue, teNamaPanggilan.Text, teNama.Text, CDate(deTanggalLahir.EditValue), lueJenisKelamin.EditValue, luePekerjaan.EditValue, luePendidikan.EditValue, lueTempatLahir.EditValue, luePernikahan.EditValue, lueAgama.EditValue, lueGolonganDarah.EditValue, lueRhesus.EditValue, lueKewarganegaraan.EditValue, 0, lueHambatan.EditValue, 0, userid, nowTime})
        Else
            field.AddRange(New String() {"idrekammedis", "sapaan", "namapanggilan", "nama", "tanggallahir", "jeniskelamin", "pekerjaan", "pendidikan", "kotalahir", "pernikahan", "agama", "golongandarah", "rhesus", "kewarganegaraan", "hambatankom", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, lueSapaan.EditValue, teNamaPanggilan.Text, teNama.Text, CDate(deTanggalLahir.EditValue), lueJenisKelamin.EditValue, luePekerjaan.EditValue, luePendidikan.EditValue, lueTempatLahir.EditValue, luePernikahan.EditValue, lueAgama.EditValue, lueGolonganDarah.EditValue, lueRhesus.EditValue, lueKewarganegaraan.EditValue, lueHambatan.EditValue, userid, nowTime})
        End If
        If dtSQL.datasetSave("rekammedis", idData, field, value, False) = True Then
            Dim idtmp As String = GenerateGUID()
            If statData = statusData.Baru Then
                Dim sqls As New SQLs(dbstring)
                'sqls.DMLQuery("select idrekammedis from rekammedis where hashcode='" & hashcode & "'", "getid")
                'idData = sqls.getDataSet("getid", 0, "idrekammedis")

                value.Clear()
                value.AddRange(New Object() {idtmp, idData, userid, nowTime, "Rekam Medis dibuat oleh " & username})
            Else
                value.Clear()
                value.AddRange(New Object() {idtmp, idData, userid, nowTime, "Rekam Medis diedit oleh " & username})
            End If

            dtSQL = New dtsetSQLS(dbstring)
            field = New List(Of String)
            value = New List(Of Object)
            field.Clear()
            value.Clear()

            field.AddRange(New String() {"idrekammedisriwayat", "idrekammedis", "iduser", "createddate", "remarks"})
            value.AddRange(New Object() {idtmp, idData, userid, nowTime, "Rekam Medis diedit oleh " & username})
            dtSQL.datasetSave("rekammedisriwayat", idtmp, field, value, False)

            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            isiLog(userid, dbstring, field, value, "rekammedis")

            btnNew_Click(Me, Nothing)
        Else
            dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

    Private idselect As String = ""
    Private strQuery As String = ""
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If teSearch.EditValue Is Nothing Then
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
            strQuery &= " and (r.nama like '%" & teSearch.Text & "%' or convert(varchar,r.rekammedisno) like '%" & teSearch.Text & "%')"
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

            sqls = New SQLs(dbstring)
            sqls.DMLQuery("select rm.asalpx,rm.asalpx2,rm.asalrujukan,rm.iddokterrujukan,rm.rekammedisno,rm.namapanggilan,rm.nama,rm.jeniskelamin,rm.sapaan,rm.golongandarah,rm.rhesus,rm.agama,rm.kewarganegaraan,rm.kotalahir,convert(varchar,rm.tanggallahir,105) as tanggallahir,rm.pendidikan,rm.pekerjaan,rm.pernikahan,rm.hambatankom,rm.isdeleted from rekammedis rm where rm.idrekammedis='" & idselect & "'", "getrm")

            If sqls.getDataSet("getrm") = 0 Then
                dizMsgbox("Data Rekam Medis tidak ditemukan", dizMsgboxStyle.Peringatan, "Tidak Ditemukan")
                btnNew_Click(Me, Nothing)
            Else
                idData = idselect

                xtpInfo.PageEnabled = True
                xtpAddress.PageVisible = True
                xtpEmail.PageVisible = True
                xtpKartu.PageVisible = True
                xtpKeluarga.PageVisible = True
                xtpTelepon.PageVisible = True
                xtcAdditional.SelectedTabPage = xtpInfo

                lueAsalPx.Properties.ReadOnly = True
                lueAsalPx.BackColor = entryDisabled
                lueAsalPx2.Properties.ReadOnly = True
                lueAsalPx2.BackColor = entryDisabled
                lueAsalPx3.Properties.ReadOnly = True
                lueAsalPx3.BackColor = entryDisabled
                lueAsalPx4.Properties.ReadOnly = True
                lueAsalPx4.BackColor = entryDisabled

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
                Dim tgllahir As String = sqls.getDataSet("getrm", 0, "tanggallahir")
                deTanggalLahir.EditValue = Strdate2Date(tgllahir)
                luePendidikan.EditValue = sqls.getDataSet("getrm", 0, "pendidikan")
                luePekerjaan.EditValue = sqls.getDataSet("getrm", 0, "pekerjaan")
                luePernikahan.EditValue = sqls.getDataSet("getrm", 0, "pernikahan")
                lueHambatan.EditValue = sqls.getDataSet("getrm", 0, "hambatankom")

                'btnNew.Enabled = True
                btnSave.Enabled = True
                btnDelete.Enabled = True
                If sqls.getDataSet("getrm", 0, "isdeleted") = 0 Then
                    btnDelete.Text = "HAPUS"
                Else
                    btnDelete.Text = "AKTIF"
                End If
                btnPrintForm.Enabled = True
                btnPrintKartu.Enabled = True
                statData = statusData.Edit

                teNamaPanggilan.Enabled = True
                teNama.Enabled = True
                lueJenisKelamin.Enabled = True
                lueSapaan.Enabled = True
                lueGolonganDarah.Enabled = True
                lueRhesus.Enabled = True
                lueAgama.Enabled = True
                lueKewarganegaraan.Enabled = True
                lueTempatLahir.Enabled = True
                deTanggalLahir.Enabled = True
                luePendidikan.Enabled = True
                luePekerjaan.Enabled = True
                luePernikahan.Enabled = True

                loadAlamat(idData)
                loadEmail(idData)
                loadKartu(idData)
                loadKeluarga(idData)
                loadPhone(idData)
            End If
            disposechild(cari, Nothing)
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

    Private Sub btnNewKeluarga_Click(sender As Object, e As EventArgs) Handles btnNewKeluarga.Click
        kosongkanIsian(tlpKeluarga)

        btnNewKeluarga.Enabled = False
        btnSaveKeluarga.Enabled = True
        btnDeleteKeluarga.Enabled = False
        btnDeleteKeluarga.Text = "HAPUS"
        statDataChild = statusData.Baru
        idDatachild = "-1"
    End Sub

    Private Sub btnSaveKeluarga_Click(sender As Object, e As EventArgs) Handles btnSaveKeluarga.Click
        Dim bentry As Boolean = True
        bentry = checkEntry(tlpKeluarga)
        If bentry = False Then
            dizMsgbox("Data Keluarga belum diisi dengan benar", dizMsgboxStyle.Peringatan, "Peringatan", Me)
            Exit Sub
        End If
        If statDataChild = statusData.Baru Then
            Dim sqls As New SQLs(dbstring)
            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")
            idDataChild = GenerateGUID()

            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            sqls.DMLQuery("select idkeluarga from keluarga where tablereff='PASIEN' and idreff='" & idData & "'", "cekklg")
            field.AddRange(New String() {"idkeluarga", "idreff", "tablereff", "nama", "familytype", "isdeleted", "createdby", "createddate", "idcompany"})
            If sqls.getDataSet("cekklg") > 0 Then
                sqls.DMLQuery("update keluarga set isdeleted=1 where tablereff='PASIEN' and idreff='" & idData & "'", False)
            End If
            value.AddRange(New Object() {idDataChild, idData, "PASIEN", teNamaKeluarga.Text, lueJenisKeluarga.EditValue, 0, userid, nowTime, idcomp})
            If dtsql.datasetSave("keluarga", idDataChild, field, value, False) = True Then
                Dim idtmp As String
                idtmp = GenerateGUID()
                field.Clear()
                value.Clear()
                field = New List(Of String)
                value = New List(Of Object)
                dtsql = New dtsetSQLS(dbstring)

                field.AddRange(New String() {"idphone", "idreff", "tablereff", "phone", "extension", "phonetype", "isdeleted", "isprimary", "createdby", "createddate", "idcompany"})
                If teKeluargaPhone1.Text = "" Then
                    value.AddRange(New Object() {idtmp, idDataChild, "KELUARGA", 0, 0, 2, 0, 1, userid, nowTime, idcomp})
                Else
                    value.AddRange(New Object() {idtmp, idDataChild, "KELUARGA", teKeluargaPhone1.Text, 0, 2, 0, 1, userid, nowTime, idcomp})
                End If
                dtsql.datasetSave("phone", idtmp, field, value, False)

                idtmp = GenerateGUID()
                field.Clear()
                value.Clear()
                field = New List(Of String)
                value = New List(Of Object)
                dtsql = New dtsetSQLS(dbstring)

                field.AddRange(New String() {"idphone", "idreff", "tablereff", "phone", "extension", "phonetype", "isdeleted", "isprimary", "createdby", "createddate", "idcompany"})
                If teKeluargaPhone2.Text = "" Then
                    value.AddRange(New Object() {idtmp, idDataChild, "KELUARGA", 0, 0, 3, 0, 1, userid, nowTime, idcomp})
                Else
                    value.AddRange(New Object() {idtmp, idDataChild, "KELUARGA", teKeluargaPhone1.Text, 0, 3, 0, 0, userid, nowTime, idcomp})
                End If
                dtsql.datasetSave("phone", idtmp, field, value, False)

                idtmp = GenerateGUID()
                field.Clear()
                value.Clear()
                dtsql = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)

                field.AddRange(New String() {"idrekammedisriwayat", "idrekammedis", "iduser", "createddate", "remarks"})
                value.AddRange(New Object() {idtmp, idData, userid, nowTime, "Rekam Medis - Keluarga ditambahkan oleh " & username})
                dtsql.datasetSave("rekammedisriwayat", idtmp, field, value, False)

                dizMsgbox("Keluarga telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim sqls As New SQLs(dbstring)
            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idkeluarga", "idreff", "tablereff", "nama", "familytype", "isdeleted", "createdby", "createddate", "idcompany"})
            If btnDeleteKeluarga.Text = "AKTIF" Then
                value.AddRange(New Object() {idDataChild, idData, "PASIEN", teNamaKeluarga.Text, lueJenisKeluarga.EditValue, 0, userid, nowTime, idcomp})
            Else
                value.AddRange(New Object() {idDataChild, idData, "PASIEN", teNamaKeluarga.Text, lueJenisKeluarga.EditValue, 1, userid, nowTime, idcomp})
            End If
            If dtsql.datasetSave("keluarga", idDataChild, field, value, False) = True Then
                field.Clear()
                value.Clear()
                field = New List(Of String)
                value = New List(Of Object)
                dtsql = New dtsetSQLS(dbstring)

                field.AddRange(New String() {"idphone", "idreff", "tablereff", "phone", "extension", "phonetype", "isdeleted", "isprimary", "createdby", "createddate", "idcompany"})
                If teKeluargaPhone1.Text = "" Then
                    value.AddRange(New Object() {teKeluargaPhone1.Tag, idDataChild, "KELUARGA", 0, 0, 2, 0, 1, userid, nowTime, idcomp})
                Else
                    value.AddRange(New Object() {teKeluargaPhone1.Tag, idDataChild, "KELUARGA", teKeluargaPhone1.Text, 0, 2, 0, 1, userid, nowTime, idcomp})
                End If
                dtsql.datasetSave("phone", -1, field, value, False)

                field.Clear()
                value.Clear()
                field = New List(Of String)
                value = New List(Of Object)
                dtsql = New dtsetSQLS(dbstring)

                field.AddRange(New String() {"idphone", "idreff", "tablereff", "phone", "extension", "phonetype", "isdeleted", "isprimary", "createdby", "createddate", "idcompany"})
                If teKeluargaPhone2.Text = "" Then
                    value.AddRange(New Object() {teKeluargaPhone2.Tag, idDataChild, "KELUARGA", 0, 0, 3, 0, 1, userid, nowTime, idcomp})
                Else
                    value.AddRange(New Object() {teKeluargaPhone2.Tag, idDataChild, "KELUARGA", teKeluargaPhone1.Text, 0, 3, 0, 0, userid, nowTime, idcomp})
                End If
                dtsql.datasetSave("phone", -1, field, value, False)

                dtsql = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.Clear()
                value.Clear()
                Dim idtmp As String = GenerateGUID()

                field.AddRange(New String() {"idrekammedisriwayat", "idrekammedis", "iduser", "createddate", "remarks"})
                value.AddRange(New Object() {idtmp, idData, userid, nowTime, "Rekam Medis - Keluarga diedit oleh " & username})
                dtsql.datasetSave("rekammedisriwayat", idtmp, field, value, False)

                dizMsgbox("Keluarga telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        End If
        loadKeluarga(idData)
        btnNewKeluarga_Click(btnNewKeluarga, Nothing)
    End Sub

    Private statData As statusData = statusData.Baru
    Private statDataChild As statusData = statusData.Baru
    Private idData As String = "-1"
    Private idDataChild As String = "-1"

    Private Sub btnDeleteKeluarga_Click(sender As Object, e As EventArgs) Handles btnDeleteKeluarga.Click
        Dim sqls As New SQLs(dbstring)
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idkeluarga", "isdeleted", "updatedby", "updateddate"})
        If btnDeleteKeluarga.Text = "HAPUS" Then
            value.AddRange(New Object() {idDataChild, 1, userid, nowTime})
            dtsql.datasetSave("Keluarga", idDataChild, field, value, False)
            btnDeleteKeluarga.Text = "AKTIF"
        ElseIf btnDeleteKeluarga.Text = "AKTIF" Then
            sqls.DMLQuery("update keluarga set isdeleted=1 where tablereff='PASIEN' and idreff='" & idData & "' and idkeluarga<>'" & idDataChild & "'", False)
            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("Keluarga", idDataChild, field, value, False)
            btnDeleteKeluarga.Text = "HAPUS"
        End If
        loadKeluarga(idData)
        btnNewKeluarga_Click(btnNewKeluarga, Nothing)
    End Sub

    Private Sub gvKeluarga_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvKeluarga.FocusedRowChanged
        Dim dcol As DataRow = gvKeluarga.GetDataRow(e.FocusedRowHandle)

        statDataChild = statusData.Edit
        idDataChild = dcol("idKeluarga")
        lueJenisKeluarga.EditValue = dcol("familytype")
        teNamaKeluarga.Text = dcol("nama")
        teKeluargaPhone1.Text = dcol("phone1")
        teKeluargaPhone2.Text = dcol("phone2")
        teKeluargaPhone1.Tag = dcol("idphone1")
        teKeluargaPhone2.Tag = dcol("idphone2")
        If dcol("isdeleted") = 0 Then
            btnDeleteKeluarga.Text = "HAPUS"
        ElseIf dcol("isdeleted") = 1 Then
            btnDeleteKeluarga.Text = "AKTIF"
        End If
        btnNewKeluarga.Enabled = True
        btnSaveKeluarga.Enabled = True
        btnDeleteKeluarga.Enabled = True
    End Sub

    Private Sub teNomorKartu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teNomorKartu.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rNoID) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub cetakBerkas(iddata As String)
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
        rpt.DisplayName = teNama.Text
        rpt.Parameters("pID").Value = iddata
        rpt.Parameters("pFooter").Value = "dicetak oleh " & username & " pada " & Format(nowTime, "dd ") & NamaBulan(nowTime.Month) & Format(nowTime, " yyyy HH:mm")
        rpt.ShowPrintMarginsWarning = False

        Dim pt As New DevExpress.XtraReports.UI.ReportPrintTool(rpt)
        pt.Report.CreateDocument(False)
        AddHandler pt.PreviewForm.Load, AddressOf PreviewForm_Load
        pt.Print()
    End Sub

    Private Sub PreviewForm_Load(sender As Object, ByVal e As EventArgs)
        Dim frm As DevExpress.XtraPrinting.Preview.PrintPreviewFormEx = CType(sender, DevExpress.XtraPrinting.Preview.PrintPreviewFormEx)
        frm.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.Scale, New Object() {1.0F})
    End Sub

    Private Sub btnPrintForm_Click(sender As Object, e As EventArgs) Handles btnPrintForm.Click
        cetakBerkas(idData)
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

    Private Sub btnWilayah_Click(sender As Object, e As EventArgs) Handles btnWilayah.Click
        Dim cariwil As New frmCariWilayah()
        tambahChild(cariwil)
        cariwil.ShowDialog(Me)
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
    End Sub

End Class