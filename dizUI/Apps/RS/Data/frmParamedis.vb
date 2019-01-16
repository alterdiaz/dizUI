Public Class frmParamedis
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

    Private Sub loadLOV()
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='SCHDAYS' order by idgeneral asc", "schdays")
        ccboJadwalHari.Properties.DataSource = mysqls.dataTable("schdays")
        ccboJadwalHari.Properties.DisplayMember = "content"
        ccboJadwalHari.Properties.ValueMember = "id"
        ccboJadwalHari.Properties.AutoHeight = True
        If mysqls.getDataSet("schdays") = 0 Then
            dizMsgbox("Hari Jadwal tidak ditemukan" & vbCrLf & "Hari Jadwal harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idunit as id, unit as content from unit where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isdeleted=0 and (idunit<>(select isnull(value,0) from sys_appsetting where variable='IDSystemUnit') and idunit<>(select isnull(value,0) from sys_appsetting where variable='IDVendorUnit')) order by unit asc", "munit")
        lueUnit.Properties.DataSource = mysqls.dataTable("munit")
        lueUnit.Properties.DisplayMember = "content"
        lueUnit.Properties.ValueMember = "id"
        lueUnit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueUnit.Properties.BestFit()
        If mysqls.getDataSet("munit") = 0 Then
            dizMsgbox("Unit tidak ditemukan" & vbCrLf & "Unit harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idjadwalsesi as id,nama + ' (' + substring(convert(varchar,jammulai,108),0,6)+' - ' + substring(convert(varchar,jamselesai,108),0,6)+')' as content from jadwalsesi where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isnull(isdeleted,0)=0 order by priority asc", "sesi")
        lueJadwalSesi.Properties.DataSource = mysqls.dataTable("sesi")
        lueJadwalSesi.Properties.DisplayMember = "content"
        lueJadwalSesi.Properties.ValueMember = "id"
        lueJadwalSesi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueJadwalSesi.Properties.BestFit()
        If mysqls.getDataSet("sesi") = 0 Then
            dizMsgbox("Sesi Jadwal tidak ditemukan" & vbCrLf & "Sesi Jadwal harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idlokasi as id,nama as content from lokasi where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and iddepartment in (select [value] from sys_appsetting where variable='IDOutpatientDept') order by nama asc", "jadwallokasi")
        lueJadwalLokasi.Properties.DataSource = mysqls.dataTable("jadwallokasi")
        lueJadwalLokasi.Properties.DisplayMember = "content"
        lueJadwalLokasi.Properties.ValueMember = "id"
        lueJadwalLokasi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueJadwalLokasi.Properties.BestFit()
        If mysqls.getDataSet("jadwallokasi") = 0 Then
            dizMsgbox("Lokasi Jadwal tidak ditemukan" & vbCrLf & "Sesi Jadwal harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and levelwilayah=1 order by wilayah asc", "kwn")
        lueKewarganegaraan.Properties.DataSource = mysqls.dataTable("kwn")
        lueKewarganegaraan.Properties.DisplayMember = "content"
        lueKewarganegaraan.Properties.ValueMember = "id"
        lueKewarganegaraan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueKewarganegaraan.Properties.BestFit()
        If mysqls.getDataSet("kwn") = 0 Then
            dizMsgbox("Kewarganegaraan tidak ditemukan" & vbCrLf & "Kewarganegaraan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='RELIGION'", "agama")
        lueAgama.Properties.DataSource = mysqls.dataTable("agama")
        lueAgama.Properties.DisplayMember = "content"
        lueAgama.Properties.ValueMember = "id"
        lueAgama.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueAgama.Properties.BestFit()
        If mysqls.getDataSet("agama") = 0 Then
            dizMsgbox("Agama tidak ditemukan" & vbCrLf & "Agama harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='SERVICE'", "service")
        lueService.Properties.DataSource = mysqls.dataTable("service")
        lueService.Properties.DisplayMember = "content"
        lueService.Properties.ValueMember = "id"
        lueService.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueService.Properties.BestFit()
        If mysqls.getDataSet("service") = 0 Then
            dizMsgbox("Ketersediaan tidak ditemukan" & vbCrLf & "Ketersediaan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='CARDDATETYPE'", "carddatetype")
        lueJenisTanggalKartu.Properties.DataSource = mysqls.dataTable("carddatetype")
        lueJenisTanggalKartu.Properties.DisplayMember = "content"
        lueJenisTanggalKartu.Properties.ValueMember = "id"
        lueJenisTanggalKartu.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueJenisTanggalKartu.Properties.BestFit()
        If mysqls.getDataSet("carddatetype") = 0 Then
            dizMsgbox("Jenis Tanggal Kartu tidak ditemukan" & vbCrLf & "Jenis Tanggal Kartu harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='CARDTYPE'", "cardtype")
        lueJenisKartu.Properties.DataSource = mysqls.dataTable("cardtype")
        lueJenisKartu.Properties.DisplayMember = "content"
        lueJenisKartu.Properties.ValueMember = "id"
        lueJenisKartu.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueJenisKartu.Properties.BestFit()
        If mysqls.getDataSet("cardtype") = 0 Then
            dizMsgbox("Jenis Kartu tidak ditemukan" & vbCrLf & "Jenis Kartu harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='SEXTYPE'", "sex")
        lueJenisKelamin.Properties.DataSource = mysqls.dataTable("sex")
        lueJenisKelamin.Properties.DisplayMember = "content"
        lueJenisKelamin.Properties.ValueMember = "id"
        lueJenisKelamin.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueJenisKelamin.Properties.BestFit()
        If mysqls.getDataSet("sex") = 0 Then
            dizMsgbox("Jenis Kelamin tidak ditemukan" & vbCrLf & "Jenis Kelamin harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select ps.idparamedisspesialis as id,s.nama as content,s.remarks as remarks from paramedisspesialis ps left join spesialis s on ps.idspesialis=s.idspesialis and s.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where ps.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and 1=0 order by s.remarks asc", "mparamspesialis")
        lueParamedisSpesialis.Properties.DataSource = mysqls.dataTable("mparamspesialis")
        lueParamedisSpesialis.Properties.DisplayMember = "content"
        lueParamedisSpesialis.Properties.ValueMember = "id"
        lueParamedisSpesialis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueParamedisSpesialis.Properties.BestFit()

        mysqls.DMLQuery("select idspesialis as id, remarks as content,nama as remarks from spesialis where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isnull(isdeleted,0)=0 order by remarks asc", "mspesialis")
        lueSpesialis.Properties.DataSource = mysqls.dataTable("mspesialis")
        lueSpesialis.Properties.DisplayMember = "content"
        lueSpesialis.Properties.ValueMember = "id"
        lueSpesialis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueSpesialis.Properties.BestFit()
        If mysqls.getDataSet("mspesialis") = 0 Then
            dizMsgbox("Spesialis tidak ditemukan" & vbCrLf & "Spesialis harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content,priority from sys_generalcode where gctype='SOCIALMEDIA' order by priority asc", "socialmedia")
        lueJenisSosmed.Properties.DataSource = mysqls.dataTable("socialmedia")
        lueJenisSosmed.Properties.DisplayMember = "content"
        lueJenisSosmed.Properties.ValueMember = "id"
        lueJenisSosmed.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueJenisSosmed.Properties.BestFit()
        If mysqls.getDataSet("socialmedia") = 0 Then
            dizMsgbox("Sosial Media tidak ditemukan" & vbCrLf & "Sosial Media harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content,priority from sys_generalcode where gctype='PARAMEDISTYPE' order by priority asc", "mparamtype")
        lueParamedisType.Properties.DataSource = mysqls.dataTable("mparamtype")
        lueParamedisType.Properties.DisplayMember = "content"
        lueParamedisType.Properties.ValueMember = "id"
        lueParamedisType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueParamedisType.Properties.BestFit()
        If mysqls.getDataSet("mparamtype") = 0 Then
            dizMsgbox("Jenis Paramedis tidak ditemukan" & vbCrLf & "Jenis Paramedis harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isnull(isdeleted,0)=0 and levelwilayah=1", "negara")
        lueNegara.Properties.DataSource = mysqls.dataTable("negara")
        lueNegara.Properties.DisplayMember = "content"
        lueNegara.Properties.ValueMember = "id"
        lueNegara.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueNegara.Properties.BestFit()
        If mysqls.getDataSet("negara") = 0 Then
            dizMsgbox("Negara tidak ditemukan" & vbCrLf & "Negara harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If
        lueKelurahan.EditValue = Nothing
        lueKecamatan.EditValue = Nothing
        lueKabupaten.EditValue = Nothing
        luePropinsi.EditValue = Nothing

        mysqls.DMLQuery("select u.iduser,u.username,l.userlevel from sys_user u left join sys_userlevel l on u.iduserlevel=l.iduserlevel where u.iduser<>1", "user")
        lueUsername.Properties.DataSource = mysqls.dataTable("user")
        lueUsername.Properties.DisplayMember = "username"
        lueUsername.Properties.ValueMember = "iduser"
        lueUsername.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueUsername.Properties.BestFit()
        If mysqls.getDataSet("user") = 0 Then
            dizMsgbox("User tidak ditemukan" & vbCrLf & "User harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content,priority from sys_generalcode where gctype='ADDRESSTYPE' order by generalcode asc", "addresstype")
        lueAddressType.Properties.DataSource = mysqls.dataTable("addresstype")
        lueAddressType.Properties.DisplayMember = "content"
        lueAddressType.Properties.ValueMember = "id"
        lueAddressType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueAddressType.Properties.BestFit()
        If mysqls.getDataSet("addresstype") = 0 Then
            dizMsgbox("Jenis Alamat tidak ditemukan" & vbCrLf & "Jenis Alamat harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content,priority from sys_generalcode where gctype='EMAILTYPE' order by priority asc", "emailtype")
        lueEmailType.Properties.DataSource = mysqls.dataTable("emailtype")
        lueEmailType.Properties.DisplayMember = "content"
        lueEmailType.Properties.ValueMember = "id"
        lueEmailType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueEmailType.Properties.BestFit()
        If mysqls.getDataSet("emailtype") = 0 Then
            dizMsgbox("Jenis Email tidak ditemukan" & vbCrLf & "Jenis Email harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content,priority from sys_generalcode where gctype='PHONETYPE' order by priority asc", "phonetype")
        luePhoneType.Properties.DataSource = mysqls.dataTable("phonetype")
        luePhoneType.Properties.DisplayMember = "content"
        luePhoneType.Properties.ValueMember = "id"
        luePhoneType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        luePhoneType.Properties.BestFit()
        If mysqls.getDataSet("phonetype") = 0 Then
            dizMsgbox("Jenis Telepon tidak ditemukan" & vbCrLf & "Jenis Telepon harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content,priority from sys_generalcode where gctype='TEGURAN' order by priority asc", "tegurantype")
        lueTeguranType.Properties.DataSource = mysqls.dataTable("tegurantype")
        lueTeguranType.Properties.DisplayMember = "content"
        lueTeguranType.Properties.ValueMember = "id"
        lueTeguranType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueTeguranType.Properties.BestFit()
        If mysqls.getDataSet("tegurantype") = 0 Then
            dizMsgbox("Jenis Teguran tidak ditemukan" & vbCrLf & "Jenis Teguran harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content,priority from sys_generalcode where gctype='PENDIDIKAN' order by priority asc", "pendidikan")
        luePendidikan.Properties.DataSource = mysqls.dataTable("pendidikan")
        luePendidikan.Properties.DisplayMember = "content"
        luePendidikan.Properties.ValueMember = "id"
        luePendidikan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        luePendidikan.Properties.BestFit()
        If mysqls.getDataSet("pendidikan") = 0 Then
            dizMsgbox("Pendidikan tidak ditemukan" & vbCrLf & "Pendidikan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If
    End Sub

    Private Sub loadGrid()
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select k.idparamedis,k.iduser,k.isdeleted,k.isservice,se.generalcode as ketersediaan,k.nama,u.username,del.generalcode as statdata,st.generalcode as jenisparamedis,k.paramedistype,k.jeniskelamin as jk,jk.generalcode as jeniskelamin,k.agama,rel.generalcode as religion,k.kewarganegaraan,n.wilayah as negara,k.kotalahir,kb.wilayah as tempatlahir,convert(varchar,k.tanggallahir,105) as tanggallahir from paramedis k left join sys_user u on k.iduser=u.iduser left join sys_generalcode se on se.idgeneral=k.isservice and se.gctype='SERVICE' left join sys_generalcode jk on jk.idgeneral=k.jeniskelamin and jk.gctype='SEXTYPE' left join sys_generalcode st on st.idgeneral=k.paramedistype and st.gctype='PARAMEDISTYPE' left join sys_generalcode del on del.idgeneral=k.isdeleted and del.gctype='DELETE' left join sys_generalcode rel on rel.idgeneral=k.agama and rel.gctype='RELIGION' left join wilayah n on k.kewarganegaraan=n.idwilayah and n.levelwilayah=1 and n.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join wilayah kb on k.idkotalahir=kb.idwilayah where k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') order by k.paramedistype asc, k.nama asc", "data")
        gcData.DataSource = mysqls.dataTable("data")
        gvData.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        loadGrid()

        xtcProfile.SelectedTabPage = xtpEntry
        TileBoxItem_ItemClick(tbiSpesialis, Nothing)
        tbAdditional.SelectedItem = tbiSpesialis
        tbAdditional.Enabled = False
        'xtcAdditional.SelectedTabPage = xtpSpesialis
        xtcAdditional.Enabled = False
        btnExport.Enabled = False
        kosongkanIsian(tlpAlamat1)
        kosongkanIsian(tlpAlamat1)
        kosongkanIsian(tlpEmail)
        kosongkanIsian(tlpJadwal1)
        kosongkanIsian(tlpJadwal2)
        kosongkanIsian(tlpKartu)
        kosongkanIsian(tlpPelatihan)
        kosongkanIsian(tlpPendidikan)
        kosongkanIsian(tlpRegister)
        kosongkanIsian(tlpSosmed)
        kosongkanIsian(tlpTelepon)
        kosongkanIsian(tlpTeguran)

        kosongkanIsian(tlpField)
        btnNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnDelete.Text = "HAPUS"
        statData = statusData.Baru
        idData = "-1"
        idDatachild = "-1"
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If isRestrictedString(teParamedis.Text, dbstring) = True Then
            dizMsgbox("NAMA tidak boleh " & teParamedis.Text & ", silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If checkEntry(tlpField) = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If statData = statusData.Baru Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select nama from paramedis where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and replace(nama,' ','')='" & teParamedis.Text.Replace(" ", "") & "'", "cek")
            If sqls.getDataSet("cek") = 0 Then
                idData = "-1"
            Else
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teParamedis.Focus()
                Exit Sub
            End If
            sqls.DMLQuery("select nama from paramedis where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and (iduser<>0 and iduser='" & lueUsername.EditValue & "')", "cekuser")
            If sqls.getDataSet("cekuser") = 0 Then
                idData = "-1"
            Else
                dizMsgbox("Username tersebut sudah dipakai", dizMsgboxStyle.Info, Me)
                teParamedis.Focus()
                Exit Sub
            End If
        ElseIf statData = statusData.Edit Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select nama from paramedis where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and replace(nama,' ','')='" & teParamedis.Text.Replace(" ", "") & "' and idparamedis<>'" & idData & "'", "cek")
            If sqls.getDataSet("cek") > 0 Then
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teParamedis.Focus()
                Exit Sub
            End If
            sqls.DMLQuery("select nama from paramedis where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and (iduser<>0 and iduser='" & lueUsername.EditValue & "') and idparamedis<>'" & idData & "'", "cekuser")
            If sqls.getDataSet("cekuser") > 0 Then
                dizMsgbox("Username tersebut sudah dipakai", dizMsgboxStyle.Info, Me)
                teParamedis.Focus()
                Exit Sub
            End If
        End If

        Dim sqls1 As New SQLs(dbstring)
        sqls1.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqls1.getDataSet("CompID", 0, "value")

        Dim dtSQL As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        Dim engine As New dizEngine.engine
        If statData = statusData.Baru Then
            idData = GenerateGUID()
        End If
        field.AddRange(New String() {"idparamedis", "idcompany", "iduser", "nama", "jeniskelamin", "paramedistype", "agama", "kewarganegaraan", "kotalahir", "tanggallahir", "isdeleted", "createdby", "createddate", "isservice"})
        value.AddRange(New Object() {idData, idcomp, If(lueUsername.EditValue, CObj(DBNull.Value)), teParamedis.Text, lueJenisKelamin.EditValue, lueParamedisType.EditValue, lueAgama.EditValue, lueKewarganegaraan.EditValue, lueTempatLahir.EditValue, CDate(deTanggalLahir.EditValue), 0, userid, nowTime, lueService.EditValue})

        If dtSQL.datasetSave("paramedis", idData, field, value, False) = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            isiLog(userid, dbstring, field, value, "paramedis")

            btnNew_Click(Me, Nothing)
        Else
            dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim retval As Boolean = False
        'Dim sqls As New SQLs(dbstring)
        Dim sqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If btnDelete.Text = "HAPUS" Then
            field.AddRange(New String() {"idparamedis", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 1, userid, nowTime})
            retval = sqls.datasetSave("paramedis", idData, field, value, False)
            isiLog(userid, dbstring, field, value, "paramedis")
        ElseIf btnDelete.Text = "AKTIF" Then
            field.AddRange(New String() {"idparamedis", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 0, userid, nowTime})
            retval = sqls.datasetSave("paramedis", idData, field, value, False)
            isiLog(userid, dbstring, field, value, "paramedis")
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

    Private fromGrid As Boolean = False
    Private fromGridChild As Boolean = False
    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        Try
            fromGrid = True
            Dim dcol As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
            teParamedis.Text = dcol("nama")
            lueParamedisType.EditValue = dcol("paramedistype")

            Dim idp As Integer = 0
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select priority from sys_generalcode where gctype='PARAMEDISTYPE' and idgeneral='" & dcol("paramedistype") & "'", "idp")
            idp = CInt(sqls.getDataSet("idp", 0, "priority"))

            lueJenisKelamin.EditValue = dcol("jk")
            lueUsername.EditValue = If(dcol("iduser"), Nothing)
            lueService.EditValue = dcol("isservice")
            lueKewarganegaraan.EditValue = dcol("kewarganegaraan")
            lueTempatLahir.EditValue = dcol("kotalahir")
            lueAgama.EditValue = dcol("agama")
            deTanggalLahir.EditValue = Strdate2Date(dcol("tanggallahir").ToString)

            idData = dcol("idparamedis")
            If dcol("isdeleted") = 0 Then
                btnDelete.Text = "HAPUS"
            ElseIf dcol("isdeleted") = 1 Then
                btnDelete.Text = "AKTIF"
            End If
            statData = statusData.Edit

            btnNew.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True
            enablePanel(True, True, True, True, True, True, True, True)

            tbAdditional.Enabled = True
            'xtcAdditional.SelectedTabPage = xtpSpesialis
            xtcAdditional.Enabled = True

            loadSpesialis(idData)
            loadAlamat(idData)
            loadPendidikan(idData)
            loadKartu(idData)
            loadEmail(idData)
            loadPhone(idData)
            loadSosmed(idData)
            loadTeguran(idData)
            loadPelatihan(idData)
            loadJadwal(idData)
            loadParamSpesialis(idData)

            If idp = 1 Or idp = 2 Or idp = 3 Or idp = 5 Then
                xtpSpesialis.PageEnabled = True
                tbiSpesialis.Enabled = True
                xtpJadwal.PageEnabled = True
                tbiJadwal.Enabled = True

                TileBoxItem_ItemClick(tbiSpesialis, Nothing)
                tbAdditional.SelectedItem = tbiSpesialis
                btnNewSpesialis_Click(btnNewSpesialis, Nothing)
            Else
                gcSpesialis.DataSource = Nothing
                xtpSpesialis.PageEnabled = False
                tbiSpesialis.Enabled = False
                xtpJadwal.PageEnabled = False
                tbiJadwal.Enabled = False

                TileBoxItem_ItemClick(tbiAlamat, Nothing)
                tbAdditional.SelectedItem = tbiAlamat
                btnNewAlamat_Click(btnNewAlamat, Nothing)
            End If

            fromGrid = False
            fromGridChild = False
        Catch ex As Exception
            btnNew_Click(Me, Nothing)
        End Try
    End Sub

    Private Sub loadSpesialis(idreff As String)
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        fromGridChild = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select ps.idparamedisspesialis,ps.idspesialis,s.nama as spesialis,ps.remarks,ps.isdeleted,del.generalcode as statdata from paramedisspesialis ps left join spesialis s on ps.idspesialis=s.idspesialis and s.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join sys_generalcode del on ps.isdeleted=del.idgeneral and del.gctype='DELETE' where ps.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and ps.idparamedis='" & idreff & "' order by s.nama asc,ps.isdeleted asc", "paramspesialis")
        gcSpesialis.DataSource = sqls.dataTable("paramspesialis")
        gvSpesialis.BestFitColumns()
        fromGridChild = True

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub loadAlamat(idreff As String)
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        fromGridChild = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select a.idalamat,a.idnegara,a.idpropinsi,a.idkabupaten,a.idkecamatan,a.idkelurahan,a.alamat,a.addresstype,a.isdeleted,a.isprimary,n.wilayah as negara,p.wilayah as propinsi,b.wilayah as kabupaten,c.wilayah as kecamatan,l.wilayah as kelurahan,del.generalcode as statdata,pri.generalcode as [primary],adt.generalcode as jenisalamat,a.kodepos  from alamat a left join wilayah n on a.idnegara=n.idwilayah and n.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join wilayah p on a.idpropinsi=p.idwilayah and p.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join wilayah b on a.idkabupaten=b.idwilayah and b.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join wilayah c on a.idkecamatan=c.idwilayah and c.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join wilayah l on a.idkelurahan=l.idwilayah and l.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join sys_generalcode del on a.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode pri on a.isprimary=pri.idgeneral and pri.gctype='ISPRIMARY' left join sys_generalcode adt on a.addresstype=adt.idgeneral and adt.gctype='ADDRESSTYPE' where a.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and  a.tablereff='PARAMEDIS' and a.idreff='" & idreff & "'", "alamat")
        gcAlamat.DataSource = sqls.dataTable("alamat")
        gvAlamat.BestFitColumns()
        fromGridChild = True

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub loadPendidikan(idreff As String)
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        fromGridChild = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select d.idpendidikan,d.pendidikan,p.generalcode as jenispendidikan,d.nomorijazah,d.nama,d.jurusan,year(d.tahunmasuk) as tahunmasuk,year(d.tahunlulus) as tahunlulus,d.nilaiakhir,d.remarks,d.isvalid,v.generalcode as valid,d.isdeleted,l.generalcode as statdata,d.createdby,d.createddate from pendidikan d left join sys_generalcode v on d.isvalid=v.idgeneral and v.gctype='ISVALID' left join sys_generalcode l on d.isdeleted=l.idgeneral and l.gctype='DELETE' left join sys_generalcode p on d.pendidikan=p.idgeneral and p.gctype='PENDIDIKAN' where d.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and d.tablereff='PARAMEDIS' and d.idreff='" & idreff & "'", "pendidikan")
        gcPendidikan.DataSource = sqls.dataTable("pendidikan")
        gvPendidikan.BestFitColumns()
        fromGridChild = True

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

        fromGridChild = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select e.idemail,e.email,e.emailtype,e.isdeleted,e.isprimary,del.generalcode as statdata,pri.generalcode as [primary],et.generalcode as jenisemail from email e left join sys_generalcode et on e.emailtype=et.idgeneral and et.gctype='EMAILTYPE' left join sys_generalcode del on e.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode pri on e.isprimary=pri.idgeneral and pri.gctype='ISPRIMARY' where e.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and e.tablereff='PARAMEDIS' and e.idreff='" & idreff & "'", "email")
        gcEmail.DataSource = sqls.dataTable("email")
        gvEmail.BestFitColumns()
        fromGridChild = True

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

        fromGridChild = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select p.idphone,p.phone,p.extension,p.phonetype,p.isdeleted,p.isprimary,del.generalcode as statdata,pri.generalcode as [primary],et.generalcode as jenistelepon from phone p left join sys_generalcode et on p.phonetype=et.idgeneral and et.gctype='PHONETYPE' left join sys_generalcode del on p.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode pri on p.isprimary=pri.idgeneral and pri.gctype='ISPRIMARY' where p.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and p.tablereff='PARAMEDIS' and p.idreff='" & idreff & "'", "phone")
        gcTelepon.DataSource = sqls.dataTable("phone")
        gvTelepon.BestFitColumns()
        fromGridChild = True

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

        fromGridChild = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select k.idkartu,k.jeniskartu,ct.generalcode as cardtype,k.isdeleted,del.generalcode as statdata,k.jenistanggal,cdt.generalcode as carddatetype,k.nomorkartu,k.namakartu,convert(varchar,k.tanggalkartu,105) as tanggalkartu from kartu k left join sys_generalcode ct on k.jeniskartu=ct.idgeneral and ct.gctype='CARDTYPE' left join sys_generalcode cdt on k.jenistanggal=cdt.idgeneral and cdt.gctype='CARDDATETYPE' left join sys_generalcode del on k.isdeleted=del.idgeneral and del.gctype='DELETE' where k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and k.tablereff='PARAMEDIS' and k.idreff='" & idreff & "'", "kartu")
        gcKartu.DataSource = sqls.dataTable("kartu")
        gvKartu.BestFitColumns()
        fromGridChild = True

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub loadParamSpesialis(idreff As String)
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)

        sqls.DMLQuery("select ps.idparamedisspesialis as id,s.nama as content,s.remarks as remarks from paramedisspesialis ps left join spesialis s on ps.idspesialis=s.idspesialis and s.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where ps.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isnull(ps.isdeleted,0)=0 and ps.idparamedis='" & idreff & "' order by s.remarks asc", "mparamspesialis")
        lueParamedisSpesialis.Properties.DataSource = sqls.dataTable("mparamspesialis")
        lueParamedisSpesialis.Properties.DisplayMember = "content"
        lueParamedisSpesialis.Properties.ValueMember = "id"
        lueParamedisSpesialis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueParamedisSpesialis.Properties.BestFit()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub loadJadwal(idreff As String)
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        fromGridChild = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select pj.idunit,u.unit,pj.hari,ps.idparamedisspesialis,p.idparamedis,s.idspesialis,p.nama,s.nama as spesialis, case  when p.paramedistype=1 then s.nama  when p.paramedistype<>1 then p.nama end as paramedis, pj.idparamedisjadwal, pj.idjadwalsesi, pj.idlokasi, pj.isparamedissms, pj.ispasiensms, pj.ismonitor, pj.isdeleted, js.nama as sesi, l.nama as lokasi, case when pj.hari like '%0%' then 'Ya' else 'Tidak' end as minggu, case when pj.hari like '%1%' then 'Ya' else 'Tidak' end as senin, case  when pj.hari like '%2%' then 'Ya' else 'Tidak' end as selasa, case when pj.hari like '%3%' then 'Ya' else 'Tidak' end as rabu, case when pj.hari like '%4%' then 'Ya' else 'Tidak' end as kamis, case  when pj.hari like '%5%' then 'Ya' else 'Tidak' end as jumat, case  when pj.hari like '%6%' then 'Ya' else 'Tidak' end as sabtu, sd.generalcode as statdata, convert(varchar,pj.tanggalmulai,105) as tanggalmulai, convert(varchar,pj.tanggalselesai,105) as tanggalselesai, substring(convert(varchar,pj.jammulai,108),0,6) as jammulai, substring(convert(varchar,pj.jamselesai,108),0,6) as jamselesai, pj.maxapp, pj.durasi, prs.generalcode as paramedissms, pps.generalcode as pasiensms, pms.generalcode as monitor, pj.remarks from paramedisjadwal pj left join unit u on pj.idunit=u.idunit left join paramedisspesialis ps on pj.idparamedisspesialis=ps.idparamedisspesialis and ps.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join paramedis p on ps.idparamedis=p.idparamedis and p.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join spesialis s on ps.idspesialis=s.idspesialis and s.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join jadwalsesi js on js.idjadwalsesi=pj.idjadwalsesi and js.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join lokasi l on pj.idlokasi=l.idlokasi and l.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join sys_generalcode sd on pj.isdeleted=sd.idgeneral and sd.gctype='DELETE' left join sys_generalcode prs on pj.isparamedissms=prs.idgeneral and prs.gctype='ISSMS' left join sys_generalcode pps on pj.ispasiensms=pps.idgeneral and pps.gctype='ISSMS' left join sys_generalcode pms on pj.ismonitor=pms.idgeneral and pms.gctype='ISMONITOR' where p.idparamedis='" & idreff & "' order by s.nama asc,p.nama asc ", "jadwal")
        gcJadwal.DataSource = sqls.dataTable("jadwal")
        gvJadwal.BestFitColumns()
        fromGridChild = True

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub loadSosmed(idreff As String)
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        fromGridChild = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select s.idsosialmedia,s.sosialmedia,s.sosialmediatype,s.isdeleted,s.isvalid,del.generalcode as statdata,isv.generalcode as validasi,et.generalcode as jenissosmed from sosialmedia s left join sys_generalcode et on s.sosialmediatype=et.idgeneral and et.gctype='SOCIALMEDIA' left join sys_generalcode del on s.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode isv on s.isvalid=isv.idgeneral and isv.gctype='ISVALID' where s.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and s.tablereff='PARAMEDIS' and s.idreff='" & idreff & "'", "sosmed")
        gcSosialMedia.DataSource = sqls.dataTable("sosmed")
        gvSosialMedia.BestFitColumns()
        fromGridChild = True

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub loadTeguran(idreff As String)
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        fromGridChild = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select t.idteguran, t.idunit,u.unit,t.teguranno, convert(varchar,t.tegurandate,105) as tegurandate, convert(varchar,t.teguranduedate,105) as teguranduedate, t.tegurantype, t.remarks, t.isdeleted,teg.generalcode as jenisteguran,del.generalcode as statdata from teguran t left join unit u on t.idunit=u.idunit left join sys_generalcode del on t.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode teg on t.tegurantype=teg.idgeneral and teg.gctype='TEGURAN' where t.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and t.tablereff='PARAMEDIS' and t.idreff='" & idreff & "'", "teguran")
        gcTeguran.DataSource = sqls.dataTable("teguran")
        gvTeguran.BestFitColumns()
        fromGridChild = True

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub loadPelatihan(idreff As String)
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        fromGridChild = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select l.idpelatihan,l.idreff,l.tablereff,l.nomorsertifikat,l.judul,l.tempat,convert(varchar,l.tanggalpelatihan,105) as tanggalpelatihan,l.remarks,l.isdeleted,del.generalcode as statdata from pelatihan l left join sys_generalcode as del on del.idgeneral=l.isdeleted and del.generalcode='DELETE' where l.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and l.tablereff='PARAMEDIS' and l.idreff='" & idreff & "'", "pelatihan")
        gcPelatihan.DataSource = sqls.dataTable("pelatihan")
        gvPelatihan.BestFitColumns()
        fromGridChild = True

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub loadRegister(idreff As String)
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        fromGridChild = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select i.idsuratijinkerja,i.instansipenerbit,i.nomor,convert(varchar,i.tanggalakhir,105) as tanggalakhir,i.remarks,i.isdeleted,del.generalcode as statdata from suratijinkerja i left join sys_generalcode as del on del.idgeneral=i.isdeleted and del.generalcode='DELETE' where i.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and i.tablereff='PARAMEDIS' and i.idreff='" & idreff & "'", "pelatihan")
        gcRegister.DataSource = sqls.dataTable("pelatihan")
        gvRegister.BestFitColumns()
        fromGridChild = True

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub enablePanel(alamat As Boolean, email As Boolean, telepon As Boolean, sosmed As Boolean, teguran As Boolean, kartu As Boolean, pelatihan As Boolean, pendidikan As Boolean)
        btnNewAlamat.Enabled = alamat
        btnSaveAlamat.Enabled = alamat
        btnPrimaryAlamat.Enabled = alamat
        btnDeleteAlamat.Enabled = alamat
        btnNewEmail.Enabled = email
        btnSaveEmail.Enabled = email
        btnPrimaryEmail.Enabled = email
        btnDeleteEmail.Enabled = email
        btnNewTelepon.Enabled = telepon
        btnSaveTelepon.Enabled = telepon
        btnPrimaryTelepon.Enabled = telepon
        btnDeleteTelepon.Enabled = telepon
        btnNewSosmed.Enabled = sosmed
        btnSaveSosmed.Enabled = sosmed
        btnValidSosmed.Enabled = sosmed
        btnDeleteSosmed.Enabled = sosmed
        btnNewTeguran.Enabled = teguran
        btnSaveTeguran.Enabled = teguran
        btnDeleteTeguran.Enabled = teguran
        btnNewKartu.Enabled = kartu
        btnSaveKartu.Enabled = kartu
        btnDeleteKartu.Enabled = kartu
        btnNewPelatihan.Enabled = pelatihan
        btnSavePelatihan.Enabled = pelatihan
        btnDeletePelatihan.Enabled = pelatihan
        btnNewPendidikan.Enabled = pendidikan
        btnSavePendidikan.Enabled = pendidikan
        btnValidPendidikan.Enabled = pendidikan
        btnDeletePendidikan.Enabled = pendidikan
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        checkFieldMaxLength(dbstring, tlpField, "paramedis")
        checkFieldMaxLength(dbstring, tlpSpesialis, "paramedisspesialis")
        checkFieldMaxLength(dbstring, tlpAlamat1, "alamat")
        checkFieldMaxLength(dbstring, tlpAlamat2, "alamat")
        checkFieldMaxLength(dbstring, tlpPendidikan, "pendidikan")
        checkFieldMaxLength(dbstring, tlpKartu, "kartu")
        checkFieldMaxLength(dbstring, tlpEmail, "email")
        checkFieldMaxLength(dbstring, tlpTelepon, "phone")
        checkFieldMaxLength(dbstring, tlpSosmed, "sosialmedia")
        checkFieldMaxLength(dbstring, tlpTeguran, "teguran")
        checkFieldMaxLength(dbstring, tlpPelatihan, "pelatihan")
        checkFieldMaxLength(dbstring, tlpJadwal1, "paramedisjadwal")
        checkFieldMaxLength(dbstring, tlpJadwal2, "paramedisjadwal")
        checkFieldMaxLength(dbstring, tlpRegister, "suratijinkerja")
        deTanggalLahir.Properties.MaxValue = nowTime

        loadLOV()
        btnNew_Click(Me, Nothing)
    End Sub

    Private Sub lueNegara_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueNegara.EditValueChanged
        Try
            If fromGridChild = True Then Exit Sub
            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isnull(isdeleted,0)=0 and idparent='" & sender.EditValue & "'", "propinsi")
            luePropinsi.Properties.DataSource = mysqls.dataTable("propinsi")
            luePropinsi.Properties.DisplayMember = "content"
            luePropinsi.Properties.ValueMember = "id"
            luePropinsi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

            luePropinsi.EditValue = Nothing
        Catch ex As Exception
            luePropinsi.Properties.DataSource = Nothing
            luePropinsi.EditValue = Nothing
        End Try
    End Sub

    Private Sub luePropinsi_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePropinsi.EditValueChanged
        Try
            If fromGridChild = True Then Exit Sub
            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isnull(isdeleted,0)=0 and idparent='" & sender.EditValue & "'", "kabupaten")
            lueKabupaten.Properties.DataSource = mysqls.dataTable("kabupaten")
            lueKabupaten.Properties.DisplayMember = "content"
            lueKabupaten.Properties.ValueMember = "id"
            lueKabupaten.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

            lueKabupaten.EditValue = Nothing
        Catch ex As Exception
            lueKabupaten.Properties.DataSource = Nothing
            lueKabupaten.EditValue = Nothing
        End Try
    End Sub

    Private Sub lueKabupaten_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueKabupaten.EditValueChanged
        Try
            If fromGridChild = True Then Exit Sub
            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isnull(isdeleted,0)=0 and idparent='" & sender.EditValue & "'", "kecamatan")
            lueKecamatan.Properties.DataSource = mysqls.dataTable("kecamatan")
            lueKecamatan.Properties.DisplayMember = "content"
            lueKecamatan.Properties.ValueMember = "id"
            lueKecamatan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

            lueKecamatan.EditValue = Nothing
        Catch ex As Exception
            lueKecamatan.Properties.DataSource = Nothing
            lueKecamatan.EditValue = Nothing
        End Try
    End Sub

    Private Sub lueKelurahan_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueKelurahan.EditValueChanged
        Try
            If fromGridChild = True Then Exit Sub
            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isnull(isdeleted,0)=0 and idparent='" & sender.EditValue & "'", "kelurahan")
            lueKelurahan.Properties.DataSource = mysqls.dataTable("kelurahan")
            lueKelurahan.Properties.DisplayMember = "content"
            lueKelurahan.Properties.ValueMember = "id"
            lueKelurahan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

            lueKelurahan.EditValue = Nothing
        Catch ex As Exception
            lueKelurahan.Properties.DataSource = Nothing
            lueKelurahan.EditValue = Nothing
        End Try
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        If gvData.RowCount > 0 Then
            Dim exp As New frmExport(gvData)
            tambahChild(exp)
            exp.ShowDialog()
        Else
            dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
        End If
    End Sub

    Private Sub btnClearUsername_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearUsername.Click
        lueUsername.EditValue = Nothing
    End Sub

    Private Sub Angka_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tePhone.KeyPress, teExtension.KeyPress, teKodepos.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rNumeric) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Email_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teEmail.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rEmail) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnNewSpesialis_Click(sender As Object, e As EventArgs) Handles btnNewSpesialis.Click
        kosongkanIsian(tlpSpesialis)

        btnNewSpesialis.Enabled = False
        btnSaveSpesialis.Enabled = True
        btnDeleteSpesialis.Enabled = False
        btnDeleteSpesialis.Text = "HAPUS"
        statDataChild = statusData.Baru
        idDatachild = "-1"
    End Sub

    Private Sub btnDeleteSpesialis_Click(sender As Object, e As EventArgs) Handles btnDeleteSpesialis.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idparamedisspesialis", "isdeleted", "updatedby", "updateddate"})
        If btnDeleteSpesialis.Text = "HAPUS" Then
            value.AddRange(New Object() {idDataChild, 1, userid, nowTime})
            dtsql.datasetSave("paramedisspesialis", idDataChild, field, value, False)
            btnDeleteSpesialis.Text = "AKTIF"
        ElseIf btnDeleteSpesialis.Text = "AKTIF" Then
            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("paramedisspesialis", idDataChild, field, value, False)
            btnDeleteSpesialis.Text = "HAPUS"
        End If
        loadSpesialis(idData)
        btnNewSpesialis_Click(btnNewSpesialis, Nothing)
    End Sub

    Private Sub btnSaveSpesialis_Click(sender As Object, e As EventArgs) Handles btnSaveSpesialis.Click
        Dim bentry As Boolean = True
        bentry = checkEntry(tlpSpesialis)
        If bentry = False Then
            dizMsgbox("Data Spesialis belum diisi dengan benar", dizMsgboxStyle.Peringatan, "Peringatan", Me)
            Exit Sub
        End If

        Dim sqls1 As New SQLs(dbstring)
        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        If statDataChild = statusData.Baru Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select idspesialis from paramedisspesialis where idparamedis='" & idData & "' and idspesialis='" & lueSpesialis.EditValue & "'", "cek")
            If sqls.getDataSet("cek") = 0 Then
                idDataChild = GenerateGUID() '-1
            Else
                dizMsgbox("Spesialis tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teEmail.Focus()
                Exit Sub
            End If

            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idparamedisspesialis", "idcompany", "idparamedis", "idspesialis", "remarks", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idDataChild, idcomp, idData, lueSpesialis.EditValue, teSpesialisRemarks.Text, 0, userid, nowTime})
            If dtsql.datasetSave("paramedisspesialis", idDataChild, field, value, False) = True Then
                dizMsgbox("Spesialis telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idparamedisspesialis", "idparamedis", "idspesialis", "remarks", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, idData, lueSpesialis.EditValue, teSpesialisRemarks.Text, userid, nowTime})
            If dtsql.datasetSave("paramedisspesialis", idDataChild, field, value, False) = True Then
                dizMsgbox("Spesialis telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        End If
        loadSpesialis(idData)
        btnNewSpesialis_Click(btnNewSpesialis, Nothing)
    End Sub

    Private Sub gvSpesialis_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvSpesialis.FocusedRowChanged
        fromGridChild = True
        If e.FocusedRowHandle < 0 Then Exit Sub
        Dim dcol As DataRow = gvSpesialis.GetDataRow(e.FocusedRowHandle)

        statDataChild = statusData.Edit
        idDataChild = dcol("idparamedisspesialis")
        lueSpesialis.EditValue = dcol("idspesialis")
        teSpesialisRemarks.Text = dcol("remarks")
        If dcol("isdeleted") = 0 Then
            btnDeleteSpesialis.Text = "HAPUS"
        ElseIf dcol("isdeleted") = 1 Then
            btnDeleteSpesialis.Text = "AKTIF"
        End If
        btnNewSpesialis.Enabled = True
        btnSaveSpesialis.Enabled = True
        btnDeleteSpesialis.Enabled = True
        fromGridChild = False
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
            sqls.DMLQuery("update alamat set isprimary=0 where idreff='" & idData & "' and tablereff='PARAMEDIS'", False)

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

        Dim sqls1 As New SQLs(dbstring)
        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        If statDataChild = statusData.Baru Then
            idDataChild = GenerateGUID()

            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idalamat", "idcompany", "idreff", "tablereff", "idnegara", "idpropinsi", "idkabupaten", "idkecamatan", "idkelurahan", "alamat", "addresstype", "kodepos", "isdeleted", "isprimary", "createdby", "createddate"})
            If gvAlamat.RowCount = 0 Then
                value.AddRange(New Object() {idDataChild, idcomp, idData, "PARAMEDIS", If(lueNegara.EditValue, CObj(DBNull.Value)), If(luePropinsi.EditValue, CObj(DBNull.Value)), If(lueKabupaten.EditValue, CObj(DBNull.Value)), If(lueKecamatan.EditValue, CObj(DBNull.Value)), If(lueKelurahan.EditValue, CObj(DBNull.Value)), meAlamat.Text, lueAddressType.EditValue, teKodepos.Text, 0, 1, userid, nowTime})
            Else
                value.AddRange(New Object() {idDataChild, idcomp, idData, "PARAMEDIS", If(lueNegara.EditValue, CObj(DBNull.Value)), If(luePropinsi.EditValue, CObj(DBNull.Value)), If(lueKabupaten.EditValue, CObj(DBNull.Value)), If(lueKecamatan.EditValue, CObj(DBNull.Value)), If(lueKelurahan.EditValue, CObj(DBNull.Value)), meAlamat.Text, lueAddressType.EditValue, teKodepos.Text, 0, 0, userid, nowTime})
            End If
            If dtsql.datasetSave("alamat", idDataChild, field, value, False) = True Then
                dizMsgbox("Alamat telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idalamat", "idreff", "tablereff", "idnegara", "idpropinsi", "idkabupaten", "idkecamatan", "idkelurahan", "alamat", "addresstype", "kodepos", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, idData, "PARAMEDIS", If(lueNegara.EditValue, CObj(DBNull.Value)), If(luePropinsi.EditValue, CObj(DBNull.Value)), If(lueKabupaten.EditValue, CObj(DBNull.Value)), If(lueKecamatan.EditValue, CObj(DBNull.Value)), If(lueKelurahan.EditValue, CObj(DBNull.Value)), meAlamat.Text, lueAddressType.EditValue, teKodepos.Text, userid, nowTime})
            If dtsql.datasetSave("alamat", idDataChild, field, value, False) = True Then
                dizMsgbox("Alamat telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        End If
        loadAlamat(idData)
        btnNewAlamat_Click(btnNewAlamat, Nothing)
    End Sub

    Private Sub gvAlamat_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvAlamat.FocusedRowChanged
        fromGridChild = True
        If e.FocusedRowHandle < 0 Then Exit Sub
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
        fromGridChild = False
    End Sub

    Private Sub btnNewPendidikan_Click(sender As Object, e As EventArgs) Handles btnNewPendidikan.Click
        kosongkanIsian(tlpPendidikan)

        btnNewPendidikan.Enabled = False
        btnSavePendidikan.Enabled = True
        btnValidPendidikan.Enabled = False
        btnValidPendidikan.Text = "VALID"
        btnDeletePendidikan.Enabled = False
        btnDeletePendidikan.Text = "HAPUS"
        statDataChild = statusData.Baru
        idDatachild = "-1"
    End Sub

    Private Sub btnDeletePendidikan_Click(sender As Object, e As EventArgs) Handles btnDeletePendidikan.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idpendidikan", "isdeleted", "updatedby", "updateddate"})
        If btnDeletePendidikan.Text = "HAPUS" Then
            value.AddRange(New Object() {idDataChild, 1, userid, nowTime})
            dtsql.datasetSave("pendidikan", idDataChild, field, value, False)
            btnDeletePendidikan.Text = "AKTIF"
        ElseIf btnDeletePendidikan.Text = "AKTIF" Then
            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("pendidikan", idDataChild, field, value, False)
            btnDeletePendidikan.Text = "HAPUS"
        End If
        loadPendidikan(idData)
        btnNewPendidikan_Click(btnNewPendidikan, Nothing)
    End Sub

    Private Sub btnValidPendidikan_Click(sender As Object, e As EventArgs) Handles btnValidPendidikan.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idpendidikan", "isvalid", "updatedby", "updateddate"})
        If btnValidPendidikan.Text = "VALID" Then
            value.AddRange(New Object() {idDataChild, 1, userid, nowTime})
            dtsql.datasetSave("pendidikan", idDataChild, field, value, False)
            btnValidPendidikan.Text = "NOT VALID"
        ElseIf btnValidPendidikan.Text = "NOT VALID" Then
            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("pendidikan", idDataChild, field, value, False)
            btnValidPendidikan.Text = "VALID"
        End If
        loadPendidikan(idData)
        btnNewPendidikan_Click(btnNewPendidikan, Nothing)
    End Sub

    Private Sub btnSavePendidikan_Click(sender As Object, e As EventArgs) Handles btnSavePendidikan.Click
        Dim bentry As Boolean = True
        bentry = checkEntry(tlpPendidikan)
        If bentry = False Then
            dizMsgbox("Data Pendidikan belum diisi dengan benar", dizMsgboxStyle.Peringatan, "Peringatan", Me)
            Exit Sub
        End If

        Dim sqls1 As New SQLs(dbstring)
        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        If statDataChild = statusData.Baru Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select pendidikan from pendidikan where tablereff='PARAMEDIS' and idreff='" & idData & "' and pendidikan='" & luePendidikan.EditValue & "' and replace(nama,' ','')='" & teInstansi.Text.Replace(" ", "") & "' and replace(jurusan,' ','')='" & teJurusan.Text.Replace(" ", "") & "'", "cek")
            If sqls.getDataSet("cek") = 0 Then
                idDataChild = GenerateGUID() '-1
            Else
                dizMsgbox("Pendidikan tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teEmail.Focus()
                Exit Sub
            End If
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idpendidikan", "idcompany", "idreff", "tablereff", "pendidikan", "nomorijazah", "nama", "jurusan", "tahunmasuk", "tahunlulus", "nilaiakhir", "isvalid", "remarks", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idDataChild, idcomp, idData, "PARAMEDIS", luePendidikan.EditValue, teNomorIjazah.Text, teInstansi.Text, teJurusan.Text, CDate(deTahunMasuk.EditValue), CDate(deTahunLulus.EditValue), seNilaiAkhir.Value, 0, tePendidikanRemarks.Text, 0, userid, nowTime})
            If dtsql.datasetSave("pendidikan", idDataChild, field, value, False) = True Then
                dizMsgbox("Pendidikan telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idpendidikan", "idreff", "tablereff", "pendidikan", "nomorijazah", "nama", "jurusan", "tahunmasuk", "tahunlulus", "nilaiakhir", "isvalid", "remarks", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, idData, "PARAMEDIS", luePendidikan.EditValue, teNomorIjazah.Text, teInstansi.Text, teJurusan.Text, CDate(deTahunMasuk.EditValue), CDate(deTahunLulus.EditValue), seNilaiAkhir.Value, 0, tePendidikanRemarks.Text, userid, nowTime})
            If dtsql.datasetSave("pendidikan", idDataChild, field, value, False) = True Then
                dizMsgbox("Pendidikan telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        End If
        loadPendidikan(idData)
        btnNewPendidikan_Click(btnNewPendidikan, Nothing)
    End Sub

    Private Sub gvPendidikan_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvPendidikan.FocusedRowChanged
        fromGridChild = True
        If e.FocusedRowHandle < 0 Then Exit Sub
        Dim dcol As DataRow = gvPendidikan.GetDataRow(e.FocusedRowHandle)

        statDataChild = statusData.Edit
        idDataChild = dcol("idpendidikan")
        luePendidikan.EditValue = dcol("pendidikan")
        teNomorIjazah.EditValue = dcol("nomorijazah")
        teInstansi.EditValue = dcol("nama")
        teJurusan.EditValue = dcol("jurusan")
        deTahunMasuk.EditValue = New Date(dcol("tahunmasuk"), 1, 1)
        deTahunLulus.EditValue = New Date(dcol("tahunlulus"), 1, 1)
        seNilaiAkhir.EditValue = dcol("nilaiakhir")
        tePendidikanRemarks.EditValue = dcol("remarks")
        If dcol("isdeleted") = 0 Then
            btnDeletePendidikan.Text = "HAPUS"
        ElseIf dcol("isdeleted") = 1 Then
            btnDeletePendidikan.Text = "AKTIF"
        End If
        If dcol("isvalid") = 0 Then
            btnValidPendidikan.Text = "VALID"
        ElseIf dcol("isvalid") = 1 Then
            btnValidPendidikan.Text = "NOT VALID"
        End If
        btnNewPendidikan.Enabled = True
        btnSavePendidikan.Enabled = True
        btnValidPendidikan.Enabled = True
        btnDeletePendidikan.Enabled = True
        fromGridChild = False
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
            sqls.DMLQuery("select email from email where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and tablereff='PARAMEDIS' and idreff='" & idData & "' and email='" & teEmail.Text & "'", "cek")
            If sqls.getDataSet("cek") = 0 Then
                idDatachild = "-1"
            Else
                dizMsgbox("Email tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teEmail.Focus()
                Exit Sub
            End If

            Dim sqls1 As New SQLs(dbstring)
            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")
            idDataChild = GenerateGUID()

            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idemail", "idcompany", "idreff", "tablereff", "email", "emailtype", "isdeleted", "isprimary", "createdby", "createddate"})
            If gvEmail.RowCount = 0 Then
                value.AddRange(New Object() {idDataChild, idcomp, idData, "PARAMEDIS", teEmail.Text, lueEmailType.EditValue, 0, 1, userid, nowTime})
            Else
                value.AddRange(New Object() {idDataChild, idcomp, idData, "PARAMEDIS", teEmail.Text, lueEmailType.EditValue, 0, 0, userid, nowTime})
            End If
            If dtsql.datasetSave("email", idDataChild, field, value, False) = True Then
                dizMsgbox("Email telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idemail", "idreff", "tablereff", "email", "emailtype", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, idData, "PARAMEDIS", teEmail.Text, lueEmailType.EditValue, userid, nowTime})
            If dtsql.datasetSave("email", idDataChild, field, value, False) = True Then
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
            sqls.DMLQuery("update email set isprimary=0 where idreff='" & idData & "' and tablereff='PARAMEDIS'", False)

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
        fromGridChild = True
        If e.FocusedRowHandle < 0 Then Exit Sub
        Dim dcol As DataRow = gvEmail.GetDataRow(e.FocusedRowHandle)

        statDataChild = statusData.Edit
        idDataChild = dcol("idemail")
        lueEmailType.EditValue = dcol("emailtype")
        teEmail.Text = dcol("email")
        If dcol("isprimary") = 0 Then
            btnPrimaryEmail.Text = "PRIMARY"
        ElseIf dcol("isprimary") = 1 Then
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
        fromGridChild = False
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
            sqls.DMLQuery("update phone set isprimary=0 where phonetype='" & luePhoneType.EditValue & "' and idreff'='" & idData & "' and tablereff='PARAMEDIS'", False)

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
            sqls.DMLQuery("select phone from phone where tablereff='PARAMEDIS' and idreff='" & idData & "' and phone='" & tePhone.Text & "'", "cek")
            If sqls.getDataSet("cek") = 0 Then
                idDataChild = GenerateGUID() '-1
            Else
                dizMsgbox("Telepon tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teEmail.Focus()
                Exit Sub
            End If

            Dim sqls1 As New SQLs(dbstring)
            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idphone", "idcompany", "idreff", "tablereff", "phone", "extension", "phonetype", "isdeleted", "isprimary", "createdby", "createddate"})
            If gvTelepon.RowCount = 0 Then
                value.AddRange(New Object() {idDataChild, idcomp, idData, "PARAMEDIS", tePhone.Text, teExtension.Text, luePhoneType.EditValue, 0, 1, userid, nowTime})
            Else
                value.AddRange(New Object() {idDataChild, idcomp, idData, "PARAMEDIS", tePhone.Text, teExtension.Text, luePhoneType.EditValue, 0, 0, userid, nowTime})
            End If
            If dtsql.datasetSave("phone", idDataChild, field, value, False) = True Then
                dizMsgbox("Telepon telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idphone", "idreff", "tablereff", "phone", "extension", "phonetype", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, idData, "PARAMEDIS", tePhone.Text, teExtension.Text, luePhoneType.EditValue, userid, nowTime})

            If dtsql.datasetSave("phone", idDataChild, field, value, False) = True Then
                dizMsgbox("Telepon telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        End If
        loadPhone(idData)
        btnNewtelepon_Click(btnNewTelepon, Nothing)
    End Sub

    Private Sub gvTelepon_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvTelepon.FocusedRowChanged
        fromGridChild = True
        If e.FocusedRowHandle < 0 Then Exit Sub
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
        fromGridChild = False
    End Sub

    Private Sub btnNewSosmed_Click(sender As Object, e As EventArgs) Handles btnNewSosmed.Click
        kosongkanIsian(tlpSosmed)

        btnNewSosmed.Enabled = False
        btnSaveSosmed.Enabled = True
        btnValidSosmed.Enabled = False
        btnValidSosmed.Text = "VALID"
        btnDeleteSosmed.Enabled = False
        btnDeleteSosmed.Text = "HAPUS"
        statDataChild = statusData.Baru
        idDatachild = "-1"
    End Sub

    Private Sub btnDeleteSosmed_Click(sender As Object, e As EventArgs) Handles btnDeleteSosmed.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idsosialmedia", "isdeleted", "updatedby", "updateddate"})
        If btnDeleteSosmed.Text = "HAPUS" Then
            value.AddRange(New Object() {idDataChild, 1, userid, nowTime})
            dtsql.datasetSave("sosialmedia", idDataChild, field, value, False)
            btnDeleteSosmed.Text = "AKTIF"
        ElseIf btnDeleteSosmed.Text = "AKTIF" Then
            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("sosialmedia", idDataChild, field, value, False)
            btnDeleteSosmed.Text = "HAPUS"
        End If
        loadSosmed(idData)
        btnNewSosmed_Click(btnNewSosmed, Nothing)
    End Sub

    Private Sub btnValidSosmed_Click(sender As Object, e As EventArgs) Handles btnValidSosmed.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idsosialmedia", "isvalid", "updatedby", "updateddate"})
        If btnValidSosmed.Text = "VALID" Then
            value.AddRange(New Object() {idDataChild, 1, userid, nowTime})
            dtsql.datasetSave("pendidikan", idDataChild, field, value, False)
            btnValidSosmed.Text = "NOT VALID"
        ElseIf btnValidSosmed.Text = "NOT VALID" Then
            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("pendidikan", idDataChild, field, value, False)
            btnValidSosmed.Text = "VALID"
        End If
        loadSosmed(idData)
        btnNewSosmed_Click(btnNewSosmed, Nothing)
    End Sub

    Private Sub btnSaveSosmed_Click(sender As Object, e As EventArgs) Handles btnSaveSosmed.Click
        Dim bentry As Boolean = True
        bentry = checkEntry(tlpSosmed)
        If bentry = False Then
            dizMsgbox("Data Sosial Media belum diisi dengan benar", dizMsgboxStyle.Peringatan, "Peringatan", Me)
            Exit Sub
        End If
        If statDataChild = statusData.Baru Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select sosialmedia from sosialmedia where tablereff='PARAMEDIS' and idreff='" & idData & "' and sosialmediatype='" & lueJenisSosmed.EditValue & "'", "cek")
            If sqls.getDataSet("cek") = 0 Then
                idDataChild = GenerateGUID() '-1
            Else
                dizMsgbox("Sosial Media tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teEmail.Focus()
                Exit Sub
            End If

            Dim sqls1 As New SQLs(dbstring)
            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idsosialmedia", "idcompany", "idreff", "tablereff", "sosialmedia", "sosialmediatype", "isdeleted", "isvalid", "createdby", "createddate"})
            value.AddRange(New Object() {idDataChild, idcomp, idData, "PARAMEDIS", teUsernameSosmed.Text, lueJenisSosmed.EditValue, 0, 0, userid, nowTime})
            If dtsql.datasetSave("sosialmedia", idDataChild, field, value, False) = True Then
                dizMsgbox("Sosial Media telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idsosialmedia", "idreff", "tablereff", "sosialmedia", "sosialmediatype", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, idData, "PARAMEDIS", teUsernameSosmed.Text, lueJenisSosmed.EditValue, userid, nowTime})
            If dtsql.datasetSave("sosialmedia", idDataChild, field, value, False) = True Then
                dizMsgbox("Sosial Media telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        End If
        loadSosmed(idData)
        btnNewSosmed_Click(btnNewSosmed, Nothing)
    End Sub

    Private Sub gvSosialMedia_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvSosialMedia.FocusedRowChanged
        fromGridChild = True
        If e.FocusedRowHandle < 0 Then Exit Sub
        Dim dcol As DataRow = gvSosialMedia.GetDataRow(e.FocusedRowHandle)

        statDataChild = statusData.Edit
        idDataChild = dcol("idsosialmedia")
        lueJenisSosmed.EditValue = dcol("sosialmediatype")
        teUsernameSosmed.Text = dcol("sosialmedia")
        If dcol("isvalid") = 0 Then
            btnValidSosmed.Text = "VALID"
        ElseIf dcol("isvalid") = 1 Then
            btnValidSosmed.Text = "NOT VALID"
        End If
        If dcol("isdeleted") = 0 Then
            btnDeleteSosmed.Text = "HAPUS"
        ElseIf dcol("isdeleted") = 1 Then
            btnDeleteSosmed.Text = "AKTIF"
        End If
        btnNewSosmed.Enabled = True
        btnSaveSosmed.Enabled = True
        btnDeleteSosmed.Enabled = True
        btnValidSosmed.Enabled = True
        fromGridChild = False
    End Sub

    Private Sub btnNewTeguran_Click(sender As Object, e As EventArgs) Handles btnNewTeguran.Click
        kosongkanIsian(tlpTeguran)

        lueTeguranUnit.EditValue = Nothing
        lueTeguranUnit.ReadOnly = False
        btnNewTeguran.Enabled = False
        btnSaveTeguran.Enabled = True
        btnDeleteTeguran.Enabled = False
        btnDeleteTeguran.Text = "HAPUS"
        statDataChild = statusData.Baru
        idDatachild = "-1"
    End Sub

    Private Sub btnDeleteTeguran_Click(sender As Object, e As EventArgs) Handles btnDeleteTeguran.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idteguran", "isdeleted", "updatedby", "updateddate"})
        If btnDeleteTeguran.Text = "HAPUS" Then
            value.AddRange(New Object() {idDataChild, 1, userid, nowTime})
            dtsql.datasetSave("teguran", idDataChild, field, value, False)
            btnDeleteTeguran.Text = "AKTIF"
        ElseIf btnDeleteTeguran.Text = "AKTIF" Then
            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("teguran", idDataChild, field, value, False)
            btnDeleteTeguran.Text = "HAPUS"
        End If
        loadTeguran(idData)
        btnNewTeguran_Click(btnNewTeguran, Nothing)
    End Sub

    Private Sub btnSaveTeguran_Click(sender As Object, e As EventArgs) Handles btnSaveTeguran.Click
        Dim bentry As Boolean = True
        bentry = checkEntry(tlpTeguran)
        If CDate(deTanggalTeguran.EditValue) > CDate(deTanggalAkhir.EditValue) Then
            bentry = False
        End If

        If bentry = False Then
            dizMsgbox("Data Teguran belum diisi dengan benar", dizMsgboxStyle.Peringatan, "Peringatan", Me)
            Exit Sub
        End If
        If statDataChild = statusData.Baru Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select teguranno from teguran where tablereff='PARAMEDIS' and idreff='" & idData & "' and tegurantype='" & lueTeguranType.EditValue & "' and convert(varchar,tegurandate,105)='" & Format(CDate(deTanggalTeguran.EditValue), "dd-MM-yyyy") & "'", "cek")
            If sqls.getDataSet("cek") = 0 Then
                idDataChild = GenerateGUID() '-1
            Else
                dizMsgbox("Teguran tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teEmail.Focus()
                Exit Sub
            End If

            Dim sqls1 As New SQLs(dbstring)
            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idteguran", "idunit", "idcompany", "idreff", "tablereff", "teguranno", "tegurandate", "teguranduedate", "tegurantype", "remarks", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idDataChild, lueTeguranUnit.EditValue, idcomp, idData, "PARAMEDIS", teTeguranNo.Text, CDate(deTanggalTeguran.EditValue), CDate(deTanggalAkhir.EditValue), lueTeguranType.EditValue, teTeguranRemarks.Text, 0, userid, nowTime})
            If dtsql.datasetSave("teguran", idDataChild, field, value, False) = True Then
                dizMsgbox("Teguran telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idteguran", "teguranno", "tegurandate", "teguranduedate", "tegurantype", "remarks", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, teTeguranNo.Text, CDate(deTanggalTeguran.EditValue), CDate(deTanggalAkhir.EditValue), lueTeguranType.EditValue, teTeguranRemarks.Text, userid, nowTime})
            If dtsql.datasetSave("teguran", idDataChild, field, value, False) = True Then
                dizMsgbox("Teguran telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        End If
        loadTeguran(idData)
        btnNewTeguran_Click(btnNewTeguran, Nothing)
    End Sub

    Private Sub gvTeguran_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvTeguran.FocusedRowChanged
        fromGridChild = True
        If e.FocusedRowHandle < 0 Then Exit Sub
        Dim dcol As DataRow = gvTeguran.GetDataRow(e.FocusedRowHandle)

        statDataChild = statusData.Edit
        idDataChild = dcol("idteguran")
        teTeguranNo.Text = dcol("teguranno")
        lueTeguranUnit.EditValue = dcol("idunit")
        lueTeguranUnit.ReadOnly = True
        lueTeguranType.EditValue = dcol("tegurantype")
        teTeguranRemarks.Text = dcol("remarks")
        deTanggalTeguran.EditValue = Strdate2Date(dcol("tegurandate").ToString)
        deTanggalAkhir.EditValue = Strdate2Date(dcol("teguranduedate").ToString)
        If dcol("isdeleted") = 0 Then
            btnDeleteTeguran.Text = "HAPUS"
        ElseIf dcol("isdeleted") = 1 Then
            btnDeleteTeguran.Text = "AKTIF"
        End If
        btnNewTeguran.Enabled = True
        btnSaveTeguran.Enabled = True
        btnDeleteTeguran.Enabled = True
        fromGridChild = False
    End Sub

    Private Sub btnNewPelatihan_Click(sender As Object, e As EventArgs) Handles btnNewPelatihan.Click
        kosongkanIsian(tlpPelatihan)

        btnNewPelatihan.Enabled = False
        btnSavePelatihan.Enabled = True
        btnDeletePelatihan.Enabled = False
        btnDeletePelatihan.Text = "HAPUS"
        statDataChild = statusData.Baru
        idDatachild = "-1"
    End Sub

    Private Sub btnDeletePelatihan_Click(sender As Object, e As EventArgs) Handles btnDeletePelatihan.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idpelatihan", "isdeleted", "updatedby", "updateddate"})
        If btnDeletePelatihan.Text = "HAPUS" Then
            value.AddRange(New Object() {idDataChild, 1, userid, nowTime})
            dtsql.datasetSave("pelatihan", idDataChild, field, value, False)
            btnDeletePelatihan.Text = "AKTIF"
        ElseIf btnDeletePelatihan.Text = "AKTIF" Then
            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("pelatihan", idDataChild, field, value, False)
            btnDeletePelatihan.Text = "HAPUS"
        End If
        loadPelatihan(idData)
        btnNewPelatihan_Click(btnNewPelatihan, Nothing)
    End Sub

    Private Sub btnSavePelatihan_Click(sender As Object, e As EventArgs) Handles btnSavePelatihan.Click
        Dim bentry As Boolean = True
        bentry = checkEntry(tlpPelatihan)
        If CDate(deTanggalTeguran.EditValue) > CDate(deTanggalAkhir.EditValue) Then
            bentry = False
        End If
        If bentry = False Then
            dizMsgbox("Data Pelatihan belum diisi dengan benar", dizMsgboxStyle.Peringatan, "Peringatan", Me)
            Exit Sub
        End If
        If statDataChild = statusData.Baru Then
            Dim sqls1 As New SQLs(dbstring)
            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select nomorsertifikat from pelatihan where tablereff='PARAMEDIS' and idreff='" & idData & "' and replace(tempat,' ','')='" & tePelatihanTempat.Text.Replace(" ", "") & "' and replace(judul,' ','')='" & tePelatihanJudul.Text.Replace(" ", "") & "' and convert(varchar,tanggalpelatihan,105)='" & Format(CDate(deTanggalPelatihan.EditValue), "dd-MM-yyyy") & "'", "cek")
            If sqls.getDataSet("cek") = 0 Then
                idDataChild = GenerateGUID() '-1
            Else
                dizMsgbox("Pelatihan tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teEmail.Focus()
                Exit Sub
            End If
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idpelatihan", "idcompany", "idreff", "tablereff", "nomorsertifikat", "judul", "tempat", "tanggalpelatihan", "remarks", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idDataChild, idcomp, idData, "PARAMEDIS", tePelatihanNo.Text, tePelatihanJudul.Text, tePelatihanTempat.Text, CDate(deTanggalPelatihan.EditValue), tePelatihanRemarks.Text, 0, userid, nowTime})
            If dtsql.datasetSave("pelatihan", idDataChild, field, value, False) = True Then
                dizMsgbox("Pelatihan telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idpelatihan", "idreff", "tablereff", "nomorsertifikat", "judul", "tempat", "tanggalpelatihan", "remarks", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, idData, "PARAMEDIS", tePelatihanNo.Text, tePelatihanJudul.Text, tePelatihanTempat.Text, CDate(deTanggalPelatihan.EditValue), tePelatihanRemarks.Text, userid, nowTime})
            If dtsql.datasetSave("pelatihan", idDataChild, field, value, False) = True Then
                dizMsgbox("Pelatihan telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        End If
        loadPelatihan(idData)
        btnNewPelatihan_Click(btnNewPelatihan, Nothing)
    End Sub

    Private Sub gvPelatihan_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvPelatihan.FocusedRowChanged
        fromGridChild = True
        If e.FocusedRowHandle < 0 Then Exit Sub
        Dim dcol As DataRow = gvPelatihan.GetDataRow(e.FocusedRowHandle)

        statDataChild = statusData.Edit
        idDataChild = dcol("idpelatihan")
        tePelatihanNo.Text = dcol("nomorsertifikat")
        tePelatihanJudul.Text = dcol("judul")
        tePelatihanRemarks.Text = dcol("remarks")
        tePelatihanTempat.Text = dcol("tempat")
        deTanggalPelatihan.EditValue = Strdate2Date(dcol("tanggalpelatihan").ToString)
        If dcol("isdeleted") = 0 Then
            btnDeletePelatihan.Text = "HAPUS"
        ElseIf dcol("isdeleted") = 1 Then
            btnDeletePelatihan.Text = "AKTIF"
        End If
        btnNewPelatihan.Enabled = True
        btnSavePelatihan.Enabled = True
        btnDeletePelatihan.Enabled = True
        fromGridChild = False
    End Sub

    Private Sub xtcAdditional_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtcAdditional.SelectedPageChanged
        If e.Page Is xtpSpesialis Then
            btnNewSpesialis_Click(btnNewSpesialis, Nothing)
        ElseIf e.Page Is xtpAddress Then
            btnNewAlamat_Click(btnNewAlamat, Nothing)
        ElseIf e.Page Is xtpPendidikan Then
            btnNewPendidikan_Click(btnNewPendidikan, Nothing)
        ElseIf e.Page Is xtpKartu Then
            btnNewKartu_Click(btnNewKartu, Nothing)
        ElseIf e.Page Is xtpEmail Then
            btnNewEmail_Click(btnNewEmail, Nothing)
        ElseIf e.Page Is xtpTelepon Then
            btnNewtelepon_Click(btnNewTelepon, Nothing)
        ElseIf e.Page Is xtpSosialMedia Then
            btnNewSosmed_Click(btnNewSosmed, Nothing)
        ElseIf e.Page Is xtpTeguran Then
            btnNewTeguran_Click(btnNewTeguran, Nothing)
        ElseIf e.Page Is xtpPelatihan Then
            btnNewPelatihan_Click(btnNewPelatihan, Nothing)
        ElseIf e.Page Is xtpJadwal Then
            loadParamSpesialis(idData)
            btnNewJadwal_Click(btnNewJadwal, Nothing)
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

    Private statData As statusData = statusData.Baru
    Private statDataChild As statusData = statusData.Baru
    Private idData As String = "-1"
    Private idDataChild As String = "-1"

    Private Sub btnSaveKartu_Click(sender As Object, e As EventArgs) Handles btnSaveKartu.Click
        Dim bentry As Boolean = True
        bentry = checkEntry(tlpKartu)
        If bentry = False Then
            dizMsgbox("Data Kartu belum diisi dengan benar", dizMsgboxStyle.Peringatan, "Peringatan", Me)
            Exit Sub
        End If
        If statDataChild = statusData.Baru Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select nomorkartu from kartu where tablereff='PARAMEDIS' and jeniskartu='" & lueJenisKartu.EditValue & "' and idreff='" & idData & "' and replace(nomorkartu,' ','')='" & teNomorKartu.Text.Replace(" ", "") & "'", "cek")
            If sqls.getDataSet("cek") = 0 Then
                idDatachild = "-1"
            Else
                dizMsgbox("Kartu tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teNomorKartu.Focus()
                Exit Sub
            End If

            Dim sqls1 As New SQLs(dbstring)
            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")
            idDataChild = GenerateGUID()

            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idkartu", "idcompany", "idreff", "tablereff", "jeniskartu", "nomorkartu", "namakartu", "tanggalkartu", "jenistanggal", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idDataChild, idcomp, idData, "PARAMEDIS", lueJenisKartu.EditValue, teNomorKartu.Text, teNamaKartu.Text, If(deTanggalKartu.EditValue, CObj(DBNull.Value)), If(lueJenisTanggalKartu.EditValue, CObj(DBNull.Value)), 0, userid, nowTime})
            If dtsql.datasetSave("kartu", idDataChild, field, value, False) = True Then
                dizMsgbox("Kartu telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idkartu", "idreff", "tablereff", "jeniskartu", "nomorkartu", "namakartu", "tanggalkartu", "jenistanggal", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, idData, "PARAMEDIS", lueJenisKartu.EditValue, teNomorKartu.Text, teNamaKartu.Text, If(deTanggalKartu.EditValue, CObj(DBNull.Value)), If(lueJenisTanggalKartu.EditValue, CObj(DBNull.Value)), userid, nowTime})
            If dtsql.datasetSave("kartu", idDataChild, field, value, False) = True Then
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

    Private Sub gvKartu_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvKartu.FocusedRowChanged
        fromGridChild = True
        If e.FocusedRowHandle < 0 Then Exit Sub
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
        btnNewKartu.Enabled = True
        btnSaveKartu.Enabled = True
        btnDeleteKartu.Enabled = True
        fromGridChild = False
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

    Private Sub xtcProfile_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtcProfile.SelectedPageChanged
        If e.Page Is xtpData Then
            btnExport.Enabled = True
        Else
            btnExport.Enabled = False
        End If
    End Sub

    Private minJamMulai As Date = Now
    Private maxJamMulai As Date = Now
    Private fromLOV As Boolean = False
    Private Sub lueJadwalSesi_EditValueChanged(sender As Object, e As EventArgs) Handles lueJadwalSesi.EditValueChanged
        fromLOV = True
        If lueJadwalSesi.EditValue Is Nothing Then
            minJamMulai = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
            maxJamMulai = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
            teJamMulai.Time = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
            teJamSelesai.Time = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
            fromLOV = False
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select jammulai,jamselesai from jadwalsesi where idjadwalsesi='" & lueJadwalSesi.EditValue & "'", "getjamawal")
        If sqls.getDataSet("getjamawal") = 0 Then
            dizMsgbox("Sesi Jadwal tidak ditemukan" & vbCrLf & "Sesi Jadwal harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            fromLOV = False
            pExit_Click(Me, Nothing)
            Exit Sub
        Else
            Dim jam As Integer = CInt(sqls.getDataSet("getjamawal", 0, "jammulai").ToString.Split(":")(0))
            Dim menit As Integer = CInt(sqls.getDataSet("getjamawal", 0, "jammulai").ToString.Split(":")(1))

            Dim jamselesai As Integer = CInt(sqls.getDataSet("getjamawal", 0, "jamselesai").ToString.Split(":")(0))
            Dim menitselesai As Integer = CInt(sqls.getDataSet("getjamawal", 0, "jamselesai").ToString.Split(":")(1))

            teJamMulai.Time = New Date(nowTime.Year, nowTime.Month, nowTime.Day, jam, menit, 0)
            teJamSelesai.Time = New Date(nowTime.Year, nowTime.Month, nowTime.Day, jam, menit, 0)
            minJamMulai = New Date(nowTime.Year, nowTime.Month, nowTime.Day, jam, menit, 0)
            maxJamMulai = New Date(nowTime.Year, nowTime.Month, nowTime.Day, jamselesai, menitselesai, 0)
        End If
        fromLOV = False
    End Sub

    Private Sub btnNewJadwal_Click(sender As Object, e As EventArgs) Handles btnNewJadwal.Click
        minJamMulai = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
        maxJamMulai = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 23, 59, 0)

        lueSpesialis.EditValue = Nothing
        lueJadwalSesi.EditValue = Nothing
        ccboJadwalHari.EditValue = Nothing
        For i As Integer = 0 To ccboJadwalHari.Properties.Items.Count - 1
            ccboJadwalHari.Properties.Items.Item(i).CheckState = CheckState.Unchecked
        Next
        ccboJadwalHari.ShowPopup()
        ccboJadwalHari.ClosePopup()

        deJadwalMulai.EditValue = nowTime
        deJadwalSelesai.EditValue = nowTime
        teJamMulai.Time = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
        teJamSelesai.EditValue = Nothing

        lueUnit.EditValue = Nothing
        lueUnit.ReadOnly = False
        lueJadwalLokasi.EditValue = Nothing
        seJadwalMaxApp.EditValue = 0
        seJadwalDurasi.EditValue = 0
        tsJadwalParamedisSMS.EditValue = False
        tsJadwalPasienSMS.EditValue = False
        tsJadwalMonitor.EditValue = False

        meJadwalRemarks.EditValue = Nothing

        btnExport.Enabled = False
        btnNewJadwal.Enabled = False
        btnSaveJadwal.Enabled = True
        btnDeleteJadwal.Enabled = False
        btnDeleteJadwal.Text = "HAPUS"
        statDataChild = statusData.Baru
        idDatachild = "-1"
    End Sub

    Private Sub btnSaveJadwal_Click(sender As Object, e As EventArgs) Handles btnSaveJadwal.Click
        Dim bentry As Boolean = True
        bentry = checkEntry(tlpJadwal1)
        bentry = checkEntry(tlpJadwal2)
        Dim bcekjam As Boolean = True
        If CDate(teJamMulai.EditValue).Hour >= CDate(teJamSelesai.EditValue).Hour Then
            bentry = False
            bcekjam = False
        End If

        If bcekjam = False Then
            dizMsgbox("Data Jam Jadwal belum diisi dengan benar", dizMsgboxStyle.Peringatan, "Peringatan", Me)
            Exit Sub
        End If
        If bentry = False Then
            dizMsgbox("Data Jadwal Paramedis belum diisi dengan benar", dizMsgboxStyle.Peringatan, "Peringatan", Me)
            Exit Sub
        End If
        If statDataChild = statusData.Baru Then
            Dim strjammulai As String = teJamMulai.Text
            Dim strjam As String = strjammulai.Split(":")(0)
            Dim strmenit As String = strjammulai.Split(":")(1)
            Dim hari() As String
            Dim strhari As String = ccboJadwalHari.EditValue
            strhari = strhari.Replace(" ", "")
            hari = strhari.Split(",")
            Dim wherehari As String = ""
            For i As Integer = 0 To hari.Length - 1
                wherehari &= " and (case when pj.hari like '%" & hari(i) & "%' then 'Ya' else 'Tidak' end) = 'Ya' "
            Next
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select pj.idparamedisjadwal from paramedisjadwal pj left join paramedisspesialis ps on pj.idparamedisspesialis=ps.idparamedisspesialis and ps.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where pj.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isnull(pj.isdeleted,0)=0 and ps.idparamedis='" & idData & "' and ('" & strjam & ":" & strmenit & ":00' between pj.jammulai and pj.jamselesai)" & wherehari, "cek")
            If sqls.getDataSet("cek") = 0 Then
                idData = GenerateGUID() '-1
            Else
                dizMsgbox("Jadwal Paramedis tersebut sudah ada", dizMsgboxStyle.Info, Me)
                lueParamedisSpesialis.Focus()
                Exit Sub
            End If

            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idparamedisjadwal", "idcompany", "idparamedisspesialis", "idjadwalsesi", "idlokasi", "idunit", "hari", "tanggalmulai", "tanggalselesai", "jammulai", "jamselesai", "maxapp", "durasi", "isparamedissms", "ispasiensms", "ismonitor", "remarks", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idDataChild, idcomp, lueParamedisSpesialis.EditValue, lueJadwalSesi.EditValue, lueJadwalLokasi.EditValue, lueUnit.EditValue, ccboJadwalHari.EditValue, CDate(deJadwalMulai.EditValue), CDate(deJadwalSelesai.EditValue), CDate(teJamMulai.EditValue).TimeOfDay, CDate(teJamSelesai.EditValue).TimeOfDay, seJadwalMaxApp.Value, seJadwalDurasi.Value, tsJadwalParamedisSMS.EditValue, tsJadwalPasienSMS.EditValue, tsJadwalMonitor.EditValue, meJadwalRemarks.Text, 0, userid, nowTime})
            If dtsql.datasetSave("paramedisjadwal", idDataChild, field, value, False) = True Then
                dizMsgbox("Jadwal telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idparamedisjadwal", "idparamedisspesialis", "idjadwalsesi", "idlokasi", "hari", "tanggalmulai", "tanggalselesai", "jammulai", "jamselesai", "maxapp", "durasi", "isparamedissms", "ispasiensms", "ismonitor", "remarks", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, lueParamedisSpesialis.EditValue, lueJadwalSesi.EditValue, lueJadwalLokasi.EditValue, ccboJadwalHari.EditValue, CDate(deJadwalMulai.EditValue), CDate(deJadwalSelesai.EditValue), CDate(teJamMulai.EditValue).TimeOfDay, CDate(teJamSelesai.EditValue).TimeOfDay, seJadwalMaxApp.Value, seJadwalDurasi.Value, tsJadwalParamedisSMS.EditValue, tsJadwalPasienSMS.EditValue, tsJadwalMonitor.EditValue, meJadwalRemarks.Text, userid, nowTime})
            If dtsql.datasetSave("paramedisjadwal", idDataChild, field, value, False) = True Then
                dizMsgbox("Jadwal telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        End If
        loadJadwal(idData)
        btnNewJadwal_Click(btnNewJadwal, Nothing)
    End Sub

    Private Sub btnDeleteJadwal_Click(sender As Object, e As EventArgs) Handles btnDeleteJadwal.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idparamedisjadwal", "isdeleted", "updatedby", "updateddate"})
        If btnDeleteJadwal.Text = "HAPUS" Then
            value.AddRange(New Object() {idDataChild, 1, userid, nowTime})
            dtsql.datasetSave("paramedisjadwal", idDataChild, field, value, False)
            btnDeleteJadwal.Text = "AKTIF"
        ElseIf btnDeleteJadwal.Text = "AKTIF" Then
            Dim strjammulai As String = teJamMulai.Text
            Dim strjam As String = strjammulai.Split(":")(0)
            Dim strmenit As String = strjammulai.Split(":")(1)
            Dim hari() As String
            Dim strhari As String = ccboJadwalHari.EditValue
            strhari = strhari.Replace(" ", "")
            hari = strhari.Split(",")
            Dim wherehari As String = ""
            For i As Integer = 0 To hari.Length - 1
                wherehari &= " and (case when pj.hari like '%" & hari(i) & "%' then 'Ya' else 'Tidak' end) = 'Ya' "
            Next
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select pj.idparamedisjadwal from paramedisjadwal pj left join paramedisspesialis ps on pj.idparamedisspesialis=ps.idparamedisspesialis where pj.isdeleted=0 and ps.idparamedis='" & idData & "' and ('" & strjam & ":" & strmenit & ":00' between pj.jammulai and pj.jamselesai)" & wherehari, "cek")
            If sqls.getDataSet("cek") > 0 Then
                dizMsgbox("Jadwal Paramedis tersebut sudah ada", dizMsgboxStyle.Info, Me)
                lueParamedisSpesialis.Focus()
                Exit Sub
            End If

            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("paramedisjadwal", idDataChild, field, value, False)
            btnDeleteJadwal.Text = "HAPUS"
        End If
        loadjadwal(idData)
        btnNewJadwal_Click(btnNewJadwal, Nothing)
    End Sub

    Private Sub gvJadwal_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvJadwal.FocusedRowChanged
        fromGridChild = True
        If e.FocusedRowHandle < 0 Then Exit Sub
        For i As Integer = 0 To ccboJadwalHari.Properties.Items.Count - 1
            ccboJadwalHari.Properties.Items.Item(i).CheckState = CheckState.Unchecked
        Next

        Dim dcol As DataRow = gvJadwal.GetDataRow(e.FocusedRowHandle)

        statDataChild = statusData.Edit
        idDataChild = dcol("idparamedisjadwal")

        lueUnit.EditValue = dcol("idunit")
        lueUnit.ReadOnly = True
        lueParamedisSpesialis.EditValue = dcol("idparamedisspesialis")
        lueJadwalSesi.EditValue = dcol("idjadwalsesi")
        Dim strhari As String = dcol("hari")
        strhari = strhari.Replace(" ", "")
        For i As Integer = 0 To strhari.Split(",").Length - 1
            For a As Integer = 0 To ccboJadwalHari.Properties.Items.Count - 1
                If ccboJadwalHari.Properties.Items.Item(a).Value = strhari.Split(",")(i) Then
                    ccboJadwalHari.Properties.Items.Item(a).CheckState = CheckState.Checked
                End If
            Next
        Next
        ccboJadwalHari.Invalidate()
        deJadwalMulai.EditValue = Strdate2Date(dcol("tanggalmulai").ToString)
        deJadwalSelesai.EditValue = Strdate2Date(dcol("tanggalselesai").ToString)
        teJamMulai.Time = New Date(nowTime.Year, nowTime.Month, nowTime.Day, dcol("jammulai").ToString.Split(":")(0), dcol("jammulai").ToString.Split(":")(1), 0)
        teJamSelesai.Time = New Date(nowTime.Year, nowTime.Month, nowTime.Day, dcol("jamselesai").ToString.Split(":")(0), dcol("jamselesai").ToString.Split(":")(1), 0)

        lueJadwalLokasi.EditValue = dcol("idlokasi")
        seJadwalMaxApp.EditValue = dcol("maxapp")
        seJadwalDurasi.EditValue = dcol("durasi")
        tsJadwalParamedisSMS.EditValue = CBool(dcol("isparamedissms"))
        tsJadwalPasienSMS.EditValue = CBool(dcol("ispasiensms"))
        tsJadwalMonitor.EditValue = CBool(dcol("ismonitor"))

        meJadwalRemarks.EditValue = dcol("remarks")
        
        If dcol("isdeleted") = 0 Then
            btnDeleteJadwal.Text = "HAPUS"
        ElseIf dcol("isdeleted") = 1 Then
            btnDeleteJadwal.Text = "AKTIF"
        End If
        btnNewJadwal.Enabled = True
        btnSaveJadwal.Enabled = True
        btnDeleteJadwal.Enabled = True
        fromGridChild = False
    End Sub

    Private Sub teJamMulai_EditValueChanged(sender As Object, e As EventArgs) Handles teJamMulai.EditValueChanged
        If CDate(teJamMulai.EditValue) < minJamMulai Then
            teJamMulai.Time = minJamMulai
        End If
        If CDate(teJamMulai.EditValue) > maxJamMulai Then
            teJamMulai.Time = maxJamMulai
        End If
    End Sub

    Private Sub teJamSelesai_EditValueChanged(sender As Object, e As EventArgs) Handles teJamSelesai.EditValueChanged
        If CDate(teJamSelesai.EditValue) < CDate(teJamMulai.EditValue) Then
            teJamSelesai.Time = teJamMulai.EditValue
        End If
    End Sub

    Private Sub seJadwalDurasi_ValueChanged(sender As Object, e As EventArgs) Handles seJadwalDurasi.ValueChanged
        If seJadwalDurasi.Value > 0 Then
            seJadwalMaxApp.Value = 0
        End If
    End Sub

    Private Sub seJadwalMaxApp_EditValueChanged(sender As Object, e As EventArgs) Handles seJadwalMaxApp.EditValueChanged
        If seJadwalMaxApp.Value > 0 Then
            seJadwalDurasi.Value = 0
        End If
    End Sub

    Private Sub TileBoxItem_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tbiAbsensi.ItemClick, tbiAlamat.ItemClick, tbiEmail.ItemClick, tbiJadwal.ItemClick, tbiKartu.ItemClick, tbiPelatihan.ItemClick, tbiPendidikan.ItemClick, tbiSosialMedia.ItemClick, tbiSpesialis.ItemClick, tbiTeguran.ItemClick, tbiTelepon.ItemClick, tbiRegister.ItemClick
        If sender Is tbiAbsensi Then
            xtcAdditional.SelectedTabPage = xtpAbsensi
        ElseIf sender Is tbiAlamat Then
            xtcAdditional.SelectedTabPage = xtpAddress
        ElseIf sender Is tbiEmail Then
            xtcAdditional.SelectedTabPage = xtpEmail
        ElseIf sender Is tbiJadwal Then
            xtcAdditional.SelectedTabPage = xtpJadwal
        ElseIf sender Is tbiKartu Then
            xtcAdditional.SelectedTabPage = xtpKartu
        ElseIf sender Is tbiPelatihan Then
            xtcAdditional.SelectedTabPage = xtpPelatihan
        ElseIf sender Is tbiPendidikan Then
            xtcAdditional.SelectedTabPage = xtpPendidikan
        ElseIf sender Is tbiSosialMedia Then
            xtcAdditional.SelectedTabPage = xtpSosialMedia
        ElseIf sender Is tbiSpesialis Then
            xtcAdditional.SelectedTabPage = xtpSpesialis
        ElseIf sender Is tbiTeguran Then
            xtcAdditional.SelectedTabPage = xtpTeguran
        ElseIf sender Is tbiTelepon Then
            xtcAdditional.SelectedTabPage = xtpTelepon
        ElseIf sender Is tbiRegister Then
            xtcAdditional.SelectedTabPage = xtpRegister
        End If
    End Sub

    Private Sub btnNewRegister_Click(sender As Object, e As EventArgs) Handles btnNewRegister.Click
        kosongkanIsian(tlpPelatihan)

        btnNewRegister.Enabled = False
        btnSaveRegister.Enabled = True
        btnDeleteRegister.Enabled = False
        btnDeleteRegister.Text = "HAPUS"
        statDataChild = statusData.Baru
        idDatachild = "-1"
    End Sub

    Private Sub btnDeleteRegister_Click(sender As Object, e As EventArgs) Handles btnDeleteRegister.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idsuratijinkerja", "isdeleted", "updatedby", "updateddate"})
        If btnDeleteRegister.Text = "HAPUS" Then
            value.AddRange(New Object() {idDataChild, 1, userid, nowTime})
            dtsql.datasetSave("suratijinkerja", idDataChild, field, value, False)
            btnDeleteRegister.Text = "AKTIF"
        ElseIf btnDeleteRegister.Text = "AKTIF" Then
            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("suratijinkerja", idDataChild, field, value, False)
            btnDeleteRegister.Text = "HAPUS"
        End If
        loadRegister(idData)
        btnNewRegister_Click(btnNewRegister, Nothing)
    End Sub

    Private Sub btnSaveRegister_Click(sender As Object, e As EventArgs) Handles btnSaveRegister.Click
        Dim bentry As Boolean = True
        bentry = checkEntry(tlpRegister)
        If bentry = False Then
            dizMsgbox("Data Register belum diisi dengan benar", dizMsgboxStyle.Peringatan, "Peringatan", Me)
            Exit Sub
        End If
        If statDataChild = statusData.Baru Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select nomor from pelatihan where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and tablereff='PARAMEDIS' and idreff='" & idData & "'", "cek")
            If sqls.getDataSet("cek") = 0 Then
                idDataChild = GenerateGUID() '-1
            Else
                dizMsgbox("Data Register tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teEmail.Focus()
                Exit Sub
            End If

            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idsuratijinkerja", "idcompany", "idreff", "tablereff", "nomor", "instansipenerbit", "tanggalakhir", "remarks", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idDataChild, idcomp, idData, "PARAMEDIS", teRegisterNo.Text, teRegisterInstansi.Text, CDate(deTanggalAkhir.EditValue), teRegisterRemarks.Text, 0, userid, nowTime})
            If dtsql.datasetSave("suratijinkerja", idDataChild, field, value, False) = True Then
                dizMsgbox("Data Register telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idsuratijinkerja", "idreff", "tablereff", "nomor", "instansipenerbit", "tanggalakhir", "remarks", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, idData, "PARAMEDIS", teRegisterNo.Text, teRegisterInstansi.Text, CDate(deTanggalAkhir.EditValue), teRegisterRemarks.Text, userid, nowTime})
            If dtsql.datasetSave("suratijinkerja", idDataChild, field, value, False) = True Then
                dizMsgbox("Data Register telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        End If
        loadregister(idData)
        btnNewRegister_Click(btnNewRegister, Nothing)
    End Sub

    Private Sub gvRegister_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvregister.FocusedRowChanged
        fromGridChild = True
        If e.FocusedRowHandle < 0 Then Exit Sub
        Dim dcol As DataRow = gvRegister.GetDataRow(e.FocusedRowHandle)

        statDataChild = statusData.Edit
        idDataChild = dcol("idsuratijinkerja")
        teRegisterNo.Text = dcol("nomor")
        teRegisterInstansi.Text = dcol("instansipenerbit")
        teRegisterRemarks.Text = dcol("remarks")
        deRegisterTglAkhir.EditValue = Strdate2Date(dcol("tanggalakhir").ToString)
        If dcol("isdeleted") = 0 Then
            btnDeleteRegister.Text = "HAPUS"
        ElseIf dcol("isdeleted") = 1 Then
            btnDeleteRegister.Text = "AKTIF"
        End If
        btnNewRegister.Enabled = True
        btnSaveRegister.Enabled = True
        btnDeleteRegister.Enabled = True
        fromGridChild = False
    End Sub

    Private Sub lueParamedisSpesialis_EditValueChanged(sender As Object, e As EventArgs) Handles lueParamedisSpesialis.EditValueChanged
        If lueParamedisSpesialis.EditValue Is Nothing Then
            lueJadwalLokasi.Properties.DataSource = Nothing
            lueJadwalLokasi.EditValue = Nothing
            Exit Sub
        End If
        Dim sqls As New SQLs(dbstring)
        Dim idsp As String = ""
        sqls.DMLQuery("select idspesialis from paramedisspesialis where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and idparamedisspesialis='" & lueParamedisSpesialis.EditValue & "'", "ids")
        idsp = sqls.getDataSet("ids", 0, "idspesialis")
        sqls.DMLQuery("select idlokasi as id,nama as content from lokasi where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and nama = (select case when variable='IDSPPK' then 'Laboratorium' when variable='IDSPRad' then 'Radiologi' end as 'department' from sys_appsetting where variable in ('IDSPPK','IDSPRad') and [value]='" & idsp & "')", "jadwallokasi")
        lueJadwalLokasi.Properties.DataSource = sqls.dataTable("jadwallokasi")
        lueJadwalLokasi.Properties.DisplayMember = "content"
        lueJadwalLokasi.Properties.ValueMember = "id"
        lueJadwalLokasi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueJadwalLokasi.Properties.BestFit()
        lueJadwalLokasi.EditValue = Nothing
        If sqls.getDataSet("jadwallokasi") = 0 Then

            sqls.DMLQuery("select idlokasi as id,nama as content from lokasi where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and iddepartment in (select [value] from sys_appsetting where variable='IDOutpatientDept') order by nama asc", "jadwallokasi2")
            lueJadwalLokasi.Properties.DataSource = sqls.dataTable("jadwallokasi2")
            lueJadwalLokasi.Properties.DisplayMember = "content"
            lueJadwalLokasi.Properties.ValueMember = "id"
            lueJadwalLokasi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            lueJadwalLokasi.Properties.BestFit()

            If sqls.getDataSet("jadwallokasi2") = 0 Then
                dizMsgbox("Ruang tidak ditemukan" & vbCrLf & "Ruang harap entry dulu", dizMsgboxStyle.Peringatan, Me)
                pExit_Click(Me, Nothing)
                Exit Sub
            ElseIf sqls.getDataSet("jadwallokasi2") = 1 Then
                lueJadwalLokasi.EditValue = sqls.getDataSet("jadwallokasi2", 0, "id")
            End If
        ElseIf sqls.getDataSet("jadwallokasi") = 1 Then
            lueJadwalLokasi.EditValue = sqls.getDataSet("jadwallokasi", 0, "id")
        End If
    End Sub
End Class