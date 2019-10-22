Public Class frmPasienQuickEdit
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

    Private Sub frmPasienSwapData_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        checkFieldMaxLength(dbstring, tlpField, "rekammedis")
        checkFieldMaxLength(dbstring, tlpAlamat1, "alamat")
        checkFieldMaxLength(dbstring, tlpAlamat2, "alamat")
        checkFieldMaxLength(dbstring, tlpTelepon, "phone")
        loadLOV()
        kosongkanisian()
    End Sub

    Private Sub loadLOV()
        Dim mysqls As New SQLs(dbstring)
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

        mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where levelwilayah=1 order by idwilayah asc", "kwn")
        lueKewarganegaraan.Properties.DataSource = mysqls.dataTable("kwn")
        lueKewarganegaraan.Properties.DisplayMember = "content"
        lueKewarganegaraan.Properties.ValueMember = "id"
        If mysqls.getDataSet("kwn") = 0 Then
            dizMsgbox("Kewarganegaraan tidak ditemukan" & vbCrLf & "Kewarganegaraan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If
    End Sub

    Private Sub lueKewarganegaraan_EditValueChanged(sender As Object, e As EventArgs) Handles lueKewarganegaraan.EditValueChanged
        If lueKewarganegaraan.EditValue Is Nothing Then
            lueTempatLahir.EditValue = Nothing
            Exit Sub
        End If
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("if (select count(k.idwilayah) from wilayah p left join wilayah k on p.idwilayah=k.idparent where k.levelwilayah=3)=0 begin select idwilayah as id, wilayah as content from wilayah where levelwilayah=0 order by wilayah asc end else begin select k.idwilayah as id, k.wilayah as content from wilayah p left join wilayah k on p.idwilayah=k.idparent where k.levelwilayah=3 order by k.wilayah asc end", "kota")
        lueTempatLahir.Properties.DataSource = mysqls.dataTable("kota")
        lueTempatLahir.Properties.DisplayMember = "content"
        lueTempatLahir.Properties.ValueMember = "id"
        lueTempatLahir.EditValue = Nothing
        If mysqls.getDataSet("kota") = 0 Then
            dizMsgbox("Tempat Lahir tidak ditemukan" & vbCrLf & "Tempat Lahir harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If
    End Sub

    Private Sub kosongkanisian()
        idrm = "-1"
        teNoRM.Text = 0
        teNama.EditValue = Nothing
        teNamaPanggilan.EditValue = Nothing
        deTanggalLahir.EditValue = Nothing
        lueJenisKelamin.EditValue = Nothing
        lueJenisKelamin.Properties.DataSource = Nothing

        lueNegara.Properties.DataSource = Nothing
        luePropinsi.Properties.DataSource = Nothing
        lueKabupaten.Properties.DataSource = Nothing
        lueKecamatan.Properties.DataSource = Nothing
        lueKelurahan.Properties.DataSource = Nothing
        meAlamat.EditValue = Nothing

        lueNegara.EditValue = Nothing
        luePropinsi.EditValue = Nothing
        lueKabupaten.EditValue = Nothing
        lueKecamatan.EditValue = Nothing
        lueKelurahan.EditValue = Nothing

        teTelpKantor.EditValue = Nothing
        teExtension.EditValue = Nothing
        teTelpRumah.EditValue = Nothing
        teTelpHP.EditValue = Nothing

        loadLOV()
    End Sub

    Private idrm As String = -1
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
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

        Dim strQuery As String = "select r.idrekammedis as 'ID',del.generalcode as 'Status Data',dbo.fformatnorm(r.rekammedisno) as 'No RM',sap.generalcode + ' ' + r.nama as 'Nama Pasien',st.generalcode as 'Jenis Kelamin',w.wilayah as 'Warganegara',kot.wilayah as 'Tempat Lahir',convert(varchar,r.tanggallahir,105) as 'Tgl Lahir',ms.generalcode as 'Status Pernikahan',isnull(a.alamat,'-') as 'Alamat',isnull(telk.phone,convert(varchar,0)) + ' ext. ' + isnull(telk.extension,convert(varchar,0)) as 'Telp Kantor',isnull(telr.phone,0) as 'Telp Rumah',isnull(telh.phone,0) as 'Handphone' from rekammedis r left join sys_generalcode sap on r.sapaan=sap.idgeneral and sap.gctype='SAPAAN' left join sys_generalcode st on r.jeniskelamin=st.idgeneral and st.gctype='SEXTYPE' left join sys_generalcode ms on r.pernikahan=ms.idgeneral and ms.gctype='MARITALSTATUS' left join alamat a on r.idrekammedis=a.idreff and a.tablereff='PASIEN'and a.isprimary=1 and a.isdeleted=0 left join wilayah w on r.kewarganegaraan=w.idwilayah left join wilayah kot on r.kotalahir=kot.idwilayah left join phone telk on r.idrekammedis=telk.idreff and telk.tablereff='PASIEN' and telk.isprimary=1 and telk.isdeleted=0 and telk.phonetype=1 left join phone telr on r.idrekammedis=telr.idreff and telr.tablereff='PASIEN' and telr.isprimary=1 and telr.isdeleted=0 and telr.phonetype=2 left join phone telh on r.idrekammedis=telh.idreff and telh.tablereff='PASIEN' and telh.isprimary=1 and telh.isdeleted=0 and telh.phonetype=3 left join sys_generalcode del on r.isdeleted=del.idgeneral and del.gctype='delete' where r.rekammedisno<>0 and (r.nama like '%" & teSearch.Text & "%' or convert(varchar,r.rekammedisno) like '%" & teSearch.Text & "%') order by r.rekammedisno desc"

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery(strQuery, "searchpasien")
        Dim cari As New frmSearch(sqls.dataSet, "searchpasien", "ID")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            idrm = cari.GetIDSelectData
            sqls.DMLQuery("select isdeleted,rekammedisno,nama,namapanggilan,jeniskelamin,convert(varchar,tanggallahir,105) as tanggallahir,kewarganegaraan,kotalahir,sapaan from rekammedis where idrekammedis='" & idrm & "'", "lama")
            teNoRM.Text = Format(CLng(sqls.getDataSet("lama", 0, "rekammedisno")), "0#######")
            teNama.Text = sqls.getDataSet("lama", 0, "nama")
            teNamaPanggilan.Text = sqls.getDataSet("lama", 0, "namapanggilan")
            lueJenisKelamin.EditValue = sqls.getDataSet("lama", 0, "jeniskelamin")
            lueSapaan.EditValue = sqls.getDataSet("lama", 0, "sapaan")
            Dim tgllahir As String = sqls.getDataSet("lama", 0, "tanggallahir")
            deTanggalLahir.EditValue = Strdate2Date(tgllahir)
            lueKewarganegaraan.EditValue = If(sqls.getDataSet("lama", 0, "kewarganegaraan"), Nothing)
            lueTempatLahir.EditValue = If(sqls.getDataSet("lama", 0, "kotalahir"), Nothing)

            If sqls.getDataSet("lama", 0, "isdeleted") = "1" Then
                btnDelete.Text = "AKTIF"
            Else
                btnDelete.Text = "HAPUS"
            End If

            sqls.DMLQuery("select idnegara,idpropinsi,idkabupaten,idkecamatan,idkelurahan,kodepos,alamat from alamat where tablereff='PASIEN' and isprimary=1 and addresstype=2 and idreff='" & idrm & "'", "getaddress")
            lueNegara.EditValue = sqls.getDataSet("getaddress", 0, "idnegara")
            luePropinsi.EditValue = sqls.getDataSet("getaddress", 0, "idpropinsi")
            lueKabupaten.EditValue = sqls.getDataSet("getaddress", 0, "idkabupaten")
            lueKecamatan.EditValue = sqls.getDataSet("getaddress", 0, "idkecamatan")
            lueKelurahan.EditValue = sqls.getDataSet("getaddress", 0, "idkelurahan")
            teKodepos.EditValue = sqls.getDataSet("getaddress", 0, "kodepos")
            meAlamat.EditValue = sqls.getDataSet("getaddress", 0, "alamat")

            sqls.DMLQuery("select phone,extension from phone where isdeleted=0 and isprimary=1 and tablereff='PASIEN' and phonetype=1 and idreff='" & idrm & "'", "gettelpkantor")
            If sqls.getDataSet("gettelpkantor") > 0 Then
                teTelpKantor.Text = sqls.getDataSet("gettelpkantor", 0, "phone")
                teExtension.Text = sqls.getDataSet("gettelprumah", 0, "extension")
            Else
                teTelpKantor.EditValue = Nothing
                teExtension.EditValue = Nothing
            End If
            sqls.DMLQuery("select phone,extension from phone where isdeleted=0 and isprimary=1 and tablereff='PASIEN' and phonetype=2 and idreff='" & idrm & "'", "gettelprumah")
            If sqls.getDataSet("gettelprumah") > 0 Then
                teTelpRumah.Text = sqls.getDataSet("gettelprumah", 0, "phone")
            Else
                teTelpRumah.EditValue = Nothing
            End If
            sqls.DMLQuery("select phone,extension from phone where isdeleted=0 and isprimary=1 and tablereff='PASIEN' and phonetype=3 and idreff='" & idrm & "'", "gettelphp")
            If sqls.getDataSet("gettelphp") > 0 Then
                teTelpHP.Text = sqls.getDataSet("gettelphp", 0, "phone")
            Else
                teTelpHP.EditValue = Nothing
            End If
        End If
    End Sub

    Private Function cekIsian() As Boolean
        Dim retval As Boolean = True

        If teNama.EditValue Is Nothing Then retval = False
        If teNamaPanggilan.EditValue Is Nothing Then retval = False
        If teNama.Text = "" Then retval = False
        If teNamaPanggilan.Text = "" Then retval = False

        If lueJenisKelamin.EditValue Is Nothing Then retval = False
        If lueSapaan.EditValue Is Nothing Then retval = False
        If lueKewarganegaraan.EditValue Is Nothing Then retval = False
        If lueTempatLahir.EditValue Is Nothing Then retval = False
        If deTanggalLahir.EditValue Is Nothing Then retval = False

        Return retval
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If idrm = "-1" Then
            dizMsgbox("Rekam Medis belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If cekIsian() = False Then
            dizMsgbox("Isian belum benar", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        Dim sqls2 As New SQLs(dbstring)
        sqls2.DMLQuery("select rekammedisno from rekammedis where isdeleted=0 and rekammedisno='" & CLng(teNoRM.Text.Replace("-", "")) & "' and idrekammedis<>'" & idrm & "'", "ceknorm")
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

        Dim sqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idrekammedis", "rekammedisno", "nama", "namapanggilan", "jeniskelamin", "sapaan", "tanggallahir", "kotalahir", "kewarganegaraan", "updatedby", "updateddate"})
        value.AddRange(New Object() {idrm, CLng(teNoRM.Text.Replace("-", "")), teNama.Text, teNamaPanggilan.Text, lueJenisKelamin.EditValue, lueSapaan.EditValue, CDate(deTanggalLahir.EditValue), lueTempatLahir.EditValue, lueKewarganegaraan.EditValue, userid, nowTime})
        If sqls.datasetSave("rekammedis", idrm, field, value, False) Then
            isiLog(userid, dbstring, field, value, "rekammedis")

            Dim idtmp As String = GenerateGUID()
            Dim dtSQL As New dtsetSQLS(dbstring)
            field = New List(Of String)
            value = New List(Of Object)
            field.Clear()
            value.Clear()

            field.AddRange(New String() {"idrekammedisriwayat", "idrekammedis", "iduser", "createddate", "remarks"})
            value.AddRange(New Object() {idtmp, idrm, userid, nowTime, "Rekam Medis " & teNoRM.Text & " diedit (Edit Cepat) oleh " & username})
            dtSQL.datasetSave("rekammedisriwayat", idtmp, field, value, False)

            dizMsgbox("Data Pasien telah tersimpan", dizMsgboxStyle.Info, Me)
            'kosongkanisian()
        End If
    End Sub

    Private Sub btnSaveAlamat_Click(sender As Object, e As EventArgs) Handles btnSaveAlamat.Click
        If idrm = "-1" Then
            dizMsgbox("Rekam Medis belum dipilih", dizMsgboxStyle.Info, Me)
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

        'alamat
        Dim sqls As New SQLs(dbstring)
        Dim dtSQL As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.Clear()
        value.Clear()

        Dim idtmp As String = GenerateGUID()
        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        field.AddRange(New String() {"idalamat", "idcompany", "idreff", "tablereff", "addresstype", "idnegara", "idpropinsi", "idkabupaten", "idkecamatan", "idkelurahan", "alamat", "kodepos", "isdeleted", "isprimary", "createdby", "createddate"})
        value.AddRange(New Object() {idtmp, idcomp, idrm, "PASIEN", 2, lueNegara.EditValue, If(luePropinsi.EditValue, 0), If(lueKabupaten.EditValue, 0), If(lueKecamatan.EditValue, 0), If(lueKelurahan.EditValue, 0), meAlamat.Text, If(teKodepos.Text, 0), 0, 1, userid, nowTime})

        sqls.DMLQuery("update alamat set isprimary=0 where tablereff='PASIEN' and idreff='" & idrm & "'", False)
        If dtSQL.datasetSave("alamat", idtmp, field, value, False) = True Then
            isiLog(userid, dbstring, field, value, "alamat")

            idtmp = GenerateGUID()
            dtSQL = New dtsetSQLS(dbstring)
            field = New List(Of String)
            value = New List(Of Object)
            field.Clear()
            value.Clear()

            field.AddRange(New String() {"idrekammedisriwayat", "idrekammedis", "iduser", "createddate", "remarks"})
            value.AddRange(New Object() {idtmp, idrm, userid, nowTime, "Rekam Medis - Alamat ditambahkan via Edit Cepat oleh " & username})
            dtSQL.datasetSave("rekammedisriwayat", idtmp, field, value, False)

            dizMsgbox("Alamat Pasien telah tersimpan", dizMsgboxStyle.Info, Me)
            'kosongkanisian()
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

    Private Sub btnWilayah_Click(sender As Object, e As EventArgs) Handles btnWilayah.Click
        Dim cariwil As New frmCariWilayah()
        tambahChild(cariwil)
        cariwil.ShowDialog(Me)
    End Sub

    Private Sub btnSaveTelepon_Click(sender As Object, e As EventArgs) Handles btnSaveTelepon.Click
        If idrm = "-1" Then
            dizMsgbox("Rekam Medis belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If

        Dim cektelp As Boolean = True
        If teTelpRumah.EditValue Is Nothing And teTelpHP.EditValue Is Nothing And teTelpKantor.EditValue Is Nothing Then
            cektelp = False
        End If
        If teTelpRumah.Text = "" And teTelpHP.Text = "" And teTelpKantor.Text = "" Then
            cektelp = False
        End If
        If cektelp = False Then
            dizMsgbox("Isian Telepon belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        If IsNumeric(teTelpKantor.Text) Then
            Dim idtmp As String = GenerateGUID()
            dtsql = New dtsetSQLS(dbstring)
            field = New List(Of String)
            value = New List(Of Object)
            field.Clear()
            value.Clear()

            field.AddRange(New String() {"idphone", "idcompany", "idreff", "tablereff", "phonetype", "phone", "extension", "isdeleted", "isprimary", "createdby", "createddate"})
            value.AddRange(New Object() {idtmp, idcomp, idrm, "PASIEN", 1, teTelpKantor.Text, If(teExtension.Text, 0), 0, 1, userid, nowTime})
            sqls.DMLQuery("update phone set isdeleted=1,isprimary=0 where tablereff='PASIEN' and phonetype=1 and idreff='" & idrm & "'", False)
            If dtsql.datasetSave("phone", idtmp, field, value, False) = True Then
                isiLog(userid, dbstring, field, value, "phone")
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Kesalahan, Me)
                Exit Sub
            End If
        End If

        If IsNumeric(teTelpRumah.Text) Then
            Dim idtmp As String = GenerateGUID()
            dtsql = New dtsetSQLS(dbstring)
            field = New List(Of String)
            value = New List(Of Object)
            field.Clear()
            value.Clear()

            field.AddRange(New String() {"idphone", "idcompany", "idreff", "tablereff", "phonetype", "phone", "extension", "isdeleted", "isprimary", "createdby", "createddate"})
            value.AddRange(New Object() {idtmp, idcomp, idrm, "PASIEN", 2, teTelpRumah.Text, 0, 0, 1, userid, nowTime})
            sqls.DMLQuery("update phone set isdeleted=1,isprimary=0 where tablereff='PASIEN' and phonetype=2 and idreff='" & idrm & "'", False)
            If dtsql.datasetSave("phone", idtmp, field, value, False) = True Then
                isiLog(userid, dbstring, field, value, "phone")
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Kesalahan, Me)
            End If
        End If

        If IsNumeric(teTelpHP.Text) Then
            Dim idtmp As String = GenerateGUID()
            dtsql = New dtsetSQLS(dbstring)
            field = New List(Of String)
            value = New List(Of Object)
            field.Clear()
            value.Clear()

            field.AddRange(New String() {"idphone", "idcompany", "idreff", "tablereff", "phonetype", "phone", "extension", "isdeleted", "isprimary", "createdby", "createddate"})
            value.AddRange(New Object() {idtmp, idcomp, idrm, "PASIEN", 3, teTelpHP.Text, 0, 0, 1, userid, nowTime})
            sqls.DMLQuery("update phone set isdeleted=1,isprimary=0 where tablereff='PASIEN' and phonetype=3 and idreff='" & idrm & "'", False)
            If dtsql.datasetSave("phone", idtmp, field, value, False) = True Then
                isiLog(userid, dbstring, field, value, "phone")
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Kesalahan, Me)
            End If
        End If

        If cektelp = True Then
            Dim idtmp As String = GenerateGUID()
            dtsql = New dtsetSQLS(dbstring)
            field = New List(Of String)
            value = New List(Of Object)
            field.Clear()
            value.Clear()

            field.AddRange(New String() {"idrekammedisriwayat", "idrekammedis", "iduser", "createddate", "remarks"})
            value.AddRange(New Object() {idtmp, idrm, userid, nowTime, "Rekam Medis - Alamat ditambahkan via Edit Cepat oleh " & username})
            dtsql.datasetSave("rekammedisriwayat", idtmp, field, value, False)

            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            'kosongkanisian()
        End If
    End Sub

    Private Sub Angka_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles teTelpRumah.KeyPress, teTelpKantor.KeyPress, teTelpHP.KeyPress, teExtension.KeyPress, teKodepos.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rNumeric) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If idrm = "-1" Then
            dizMsgbox("Rekam Medis belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If

        Dim norm As Long = CLng(teNoRM.Text.Replace("-", ""))
        Dim sqls As New dtsetSQLS(dbstring)
        sqls.DMLQuery("select idrekammedis from rekammedis where rekammedisno=" & norm & " and idrekammedis<>'" & idrm & "'", "cekrm")
        If sqls.getDataSetRowCount("cekrm") > 0 Then
            If btnDelete.Text = "AKTIF" Then
                If dizMsgbox("Rekam Medis lain dengan Nomor yang sama akan dihapus" & vbCrLf & "Tetap melanjutkan ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Konfirmasi", Me) = dizMsgboxValue.Batal Then
                    Exit Sub
                End If
            End If
        End If

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idrekammedis", "isdeleted", "updatedby", "updateddate"})

        If btnDelete.Text = "AKTIF" Then
            sqls.DMLQuery("update rekammedis set isdeleted=1 where rekammedisno=" & norm & "  and idrekammedis<>'" & idrm & "'", False)
            value.AddRange(New Object() {idrm, 0, userid, nowTime})
        Else
            value.AddRange(New Object() {idrm, 1, userid, nowTime})
        End If

        sqls = New dtsetSQLS(dbstring)
        If sqls.datasetSave("rekammedis", idrm, field, value, False) Then
            isiLog(userid, dbstring, field, value, "rekammedis")

            Dim idtmp As String = GenerateGUID()
            Dim dtSQL As New dtsetSQLS(dbstring)
            field = New List(Of String)
            value = New List(Of Object)
            field.Clear()
            value.Clear()

            field.AddRange(New String() {"idrekammedisriwayat", "idrekammedis", "iduser", "createddate", "remarks"})
            If btnDelete.Text = "HAPUS" Then
                value.AddRange(New Object() {idtmp, idrm, userid, nowTime, "Rekam Medis " & teNoRM.Text & " dihapus (Edit Cepat) oleh " & username})
            Else
                value.AddRange(New Object() {idtmp, idrm, userid, nowTime, "Rekam Medis " & teNoRM.Text & " diaktifkan (Edit Cepat) oleh " & username})
            End If
            dtSQL.datasetSave("rekammedisriwayat", idtmp, field, value, False)

            'kosongkanisian()
        End If
        If btnDelete.Text = "HAPUS" Then
            dizMsgbox("Data Pasien telah dihapus", dizMsgboxStyle.Info, Me)
            btnDelete.Text = "AKTIF"
        Else
            dizMsgbox("Data Pasien telah diaktifkan", dizMsgboxStyle.Info, Me)
            btnDelete.Text = "HAPUS"
        End If
    End Sub

    Private Sub teSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teSearch.KeyPress
        If teSearch.Text.Replace(" ", "") = "" Then Exit Sub
        If Asc(e.KeyChar) = 13 Then
            btnSearch_Click(btnSearch, Nothing)
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

End Class