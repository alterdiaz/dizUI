Public Class frmKaryawan
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

        mysqls.DMLQuery("select idunit as id, unit as content from unit where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isdeleted=0 and (idunit<>(select isnull(value,0) from sys_appsetting where variable='IDSystemUnit') and idunit<>(select isnull(value,0) from sys_appsetting where variable='IDVendorUnit')) order by unit asc", "unit")
        lueEntryUnit.Properties.DataSource = mysqls.dataTable("unit")
        lueEntryUnit.Properties.DisplayMember = "content"
        lueEntryUnit.Properties.ValueMember = "id"
        lueEntryUnit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueEntryUnit.Properties.BestFit()
        If mysqls.getDataSet("unit") = 0 Then
            dizMsgbox("Unit tidak ditemukan" & vbCrLf & "Unit harap entry dulu", dizMsgboxStyle.Peringatan, Me)
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

        mysqls.DMLQuery("select iddepartment as id, department as content from department where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isdeleted=0 and department<>'SYSTEM'", "department")
        lueEntryDepartment.Properties.DataSource = mysqls.dataTable("department")
        lueEntryDepartment.Properties.DisplayMember = "content"
        lueEntryDepartment.Properties.ValueMember = "id"
        lueEntryDepartment.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueEntryDepartment.Properties.BestFit()
        If mysqls.getDataSet("department") = 0 Then
            dizMsgbox("Department tidak ditemukan" & vbCrLf & "Department harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select iddepartment as id, department as content from department where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isdeleted=0 and department<>'SYSTEM'", "mdepartment")
        lueDepartment.Properties.DataSource = mysqls.dataTable("mdepartment")
        lueDepartment.Properties.DisplayMember = "content"
        lueDepartment.Properties.ValueMember = "id"
        lueDepartment.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueDepartment.Properties.BestFit()
        If mysqls.getDataSet("mdepartment") = 0 Then
            dizMsgbox("Department tidak ditemukan" & vbCrLf & "Department harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idposition as id, position as content from position where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isdeleted=0 and (idposition<>(select isnull(value,0) from sys_appsetting where variable='IDSystemJabatan') and idposition<>(select isnull(value,0) from sys_appsetting where variable='IDVendorJabatan')) order by priority", "position")
        lueEntryJabatan.Properties.DataSource = mysqls.dataTable("position")
        lueEntryJabatan.Properties.DisplayMember = "content"
        lueEntryJabatan.Properties.ValueMember = "id"
        lueEntryJabatan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueEntryJabatan.Properties.BestFit()
        If mysqls.getDataSet("position") = 0 Then
            dizMsgbox("Jabatan tidak ditemukan" & vbCrLf & "Jabatan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idposition as id, position as content from position where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isdeleted=0 and (idposition<>(select isnull(value,0) from sys_appsetting where variable='IDSystemJabatan') and idposition<>(select isnull(value,0) from sys_appsetting where variable='IDVendorJabatan')) order by priority", "mposition")
        lueJabatan.Properties.DataSource = mysqls.dataTable("mposition")
        lueJabatan.Properties.DisplayMember = "content"
        lueJabatan.Properties.ValueMember = "id"
        lueJabatan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueJabatan.Properties.BestFit()
        If mysqls.getDataSet("mposition") = 0 Then
            dizMsgbox("Jabatan tidak ditemukan" & vbCrLf & "Jabatan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
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

        mysqls.DMLQuery("select idgeneral as id, generalcode as content,priority from sys_generalcode where gctype='STAFFTYPE' order by priority asc", "stafftype")
        lueEntryJenisKaryawan.Properties.DataSource = mysqls.dataTable("stafftype")
        lueEntryJenisKaryawan.Properties.DisplayMember = "content"
        lueEntryJenisKaryawan.Properties.ValueMember = "id"
        lueEntryJenisKaryawan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueEntryJenisKaryawan.Properties.BestFit()
        If mysqls.getDataSet("stafftype") = 0 Then
            dizMsgbox("Jenis Karyawan tidak ditemukan" & vbCrLf & "Jenis Karyawan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content,priority from sys_generalcode where gctype='STAFFTYPE' order by priority asc", "mstafftype")
        lueJenisKaryawan.Properties.DataSource = mysqls.dataTable("mstafftype")
        lueJenisKaryawan.Properties.DisplayMember = "content"
        lueJenisKaryawan.Properties.ValueMember = "id"
        lueJenisKaryawan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueJenisKaryawan.Properties.BestFit()
        If mysqls.getDataSet("mstafftype") = 0 Then
            dizMsgbox("Jenis Karyawan tidak ditemukan" & vbCrLf & "Jenis Karyawan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isdeleted=0 and levelwilayah=1", "negara")
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

        mysqls.DMLQuery("select idgeneral as id, generalcode as content,priority from sys_generalcode where gctype='EMAILTYPE' order by priority asc", "emailtype")
        lueEmailType.Properties.DataSource = mysqls.dataTable("emailtype")
        lueEmailType.Properties.DisplayMember = "content"
        lueEmailType.Properties.ValueMember = "id"
        lueEmailType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueEmailType.Properties.BestFit()

        mysqls.DMLQuery("select idgeneral as id, generalcode as content,priority from sys_generalcode where gctype='PHONETYPE' order by priority asc", "phonetype")
        luePhoneType.Properties.DataSource = mysqls.dataTable("phonetype")
        luePhoneType.Properties.DisplayMember = "content"
        luePhoneType.Properties.ValueMember = "id"
        luePhoneType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        luePhoneType.Properties.BestFit()

        mysqls.DMLQuery("select idgeneral as id, generalcode as content,priority from sys_generalcode where gctype='TEGURAN' order by priority asc", "tegurantype")
        lueTeguranType.Properties.DataSource = mysqls.dataTable("tegurantype")
        lueTeguranType.Properties.DisplayMember = "content"
        lueTeguranType.Properties.ValueMember = "id"
        lueTeguranType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueTeguranType.Properties.BestFit()

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

        mysqls.DMLQuery("select idgeneral as id, generalcode as content,priority from sys_generalcode where gctype='FAMILYTYPE' order by priority asc", "familytype")
        lueJenisKeluarga.Properties.DataSource = mysqls.dataTable("familytype")
        lueJenisKeluarga.Properties.DisplayMember = "content"
        lueJenisKeluarga.Properties.ValueMember = "id"
        If mysqls.getDataSet("familytype") = 0 Then
            dizMsgbox("Jenis Keluarga tidak ditemukan" & vbCrLf & "Jenis Keluarga harap entry dulu", dizMsgboxStyle.Peringatan, Me)
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
        mysqls.DMLQuery("select k.idstaff,k.idposition,k.iddepartment,k.iduser,k.idunit,k.isdeleted,k.nik,k.nama,k.namapanggilan,p.position,d.department,un.unit,u.username,del.generalcode as statdata,st.generalcode as jeniskaryawan,k.stafftype,k.jeniskelamin as jk,jk.generalcode as jeniskelamin,k.agama,rel.generalcode as religion,k.kewarganegaraan,n.wilayah as negara,k.idkotalahir,kb.wilayah as tempatlahir,convert(varchar,k.tanggallahir,105) as tanggallahir from staff k left join unit un on k.idunit=un.idunit and un.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join position p on k.idposition=p.idposition and p.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join department d on k.iddepartment=d.iddepartment and d.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join sys_user u on k.iduser=u.iduser left join sys_generalcode jk on jk.idgeneral=k.jeniskelamin and jk.gctype='SEXTYPE' left join sys_generalcode st on st.idgeneral=k.stafftype and st.gctype='STAFFTYPE' left join sys_generalcode del on del.idgeneral=k.isdeleted and del.gctype='DELETE' left join sys_generalcode rel on rel.idgeneral=k.agama and rel.gctype='RELIGION' left join wilayah n on k.kewarganegaraan=n.idwilayah and n.levelwilayah=1 left join wilayah kb on k.idkotalahir=kb.idwilayah where k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and (k.idstaff<>(select isnull(value,0) from sys_appsetting where variable='IDSystem') and k.idstaff<>(select isnull(value,0) from sys_appsetting where variable='IDVendor'))", "data")
        gcData.DataSource = mysqls.dataTable("data")
        gvData.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        loadGrid()

        xtcProfile.SelectedTabPage = xtpEntry
        tbAdditional.SelectedItem = tbiAlamat
        TileBoxItem_ItemClick(tbiAlamat, Nothing)
        tbAdditional.Enabled = False
        'xtcAdditional.SelectedTabPage = xtpAddress
        xtcAdditional.Enabled = False
        btnExport.Enabled = False
        kosongkanIsian(tlpAlamat1)
        kosongkanIsian(tlpAlamat1)
        kosongkanIsian(tlpEmail)
        kosongkanIsian(tlpTelepon)
        kosongkanIsian(tlpMutasi)
        kosongkanIsian(tlpSosmed)
        kosongkanIsian(tlpTeguran)
        kosongkanIsian(tlpKeluarga)

        lueEntryJabatan.Enabled = True
        lueEntryJabatan.BackColor = entryEnabled
        lueEntryJenisKaryawan.Enabled = True
        lueEntryJenisKaryawan.BackColor = entryEnabled
        lueEntryDepartment.Enabled = True
        lueEntryDepartment.BackColor = entryEnabled
        lueEntryUnit.Enabled = True
        lueEntryUnit.BackColor = entryEnabled
        teEntryMutasiNo.Enabled = True
        teEntryMutasiNo.BackColor = entryEnabled
        deTanggalBekerja.Enabled = True
        deTanggalBekerja.BackColor = entryEnabled

        kosongkanIsian(tlpField)
        btnNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnDelete.Text = "HAPUS"
        statData = statusData.Baru
        idData = "-1"
        idDatachild = "-1"

        lblEntryMutasiNo.Visible = True
        teEntryMutasiNo.Visible = True
        lblTanggalBekerja.Visible = True
        deTanggalBekerja.Visible = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If isRestrictedString(teNIK.Text, dbstring) = True Then
            dizMsgbox("NIK tidak boleh " & teKaryawan.Text & ", silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If isRestrictedString(teKaryawan.Text, dbstring) = True Then
            dizMsgbox("NAMA tidak boleh " & teKaryawan.Text & ", silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If isRestrictedString(tePanggilan.Text, dbstring) = True Then
            dizMsgbox("PANGGILAN tidak boleh " & teKaryawan.Text & ", silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If checkEntry(tlpField) = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If statData = statusData.Baru Then
            Dim sqls1 As New SQLs(dbstring)
            sqls1.DMLQuery("select nama from staff where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and replace(nama,' ','')='" & teKaryawan.Text.Replace(" ", "") & "'", "cek")
            If sqls1.getDataSet("cek") = 0 Then
                idData = "-1"
            Else
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teKaryawan.Focus()
                Exit Sub
            End If
            sqls1.DMLQuery("select nama from staff where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and (iduser<>0 and iduser='" & lueUsername.EditValue & "')", "cekuser")
            If sqls1.getDataSet("cekuser") = 0 Then
                idData = "-1"
            Else
                dizMsgbox("Username tersebut sudah dipakai", dizMsgboxStyle.Info, Me)
                teKaryawan.Focus()
                Exit Sub
            End If
        ElseIf statData = statusData.Edit Then
            Dim sqls1 As New SQLs(dbstring)
            sqls1.DMLQuery("select nama from staff where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and replace(nama,' ','')='" & teKaryawan.Text.Replace(" ", "") & "' and idstaff<>'" & idData & "'", "cek")
            If sqls1.getDataSet("cek") > 0 Then
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teKaryawan.Focus()
                Exit Sub
            End If
            sqls1.DMLQuery("select nama from staff where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and (iduser<>0 and iduser='" & lueUsername.EditValue & "') and idstaff<>'" & idData & "'", "cekuser")
            If sqls1.getDataSet("cekuser") > 0 Then
                dizMsgbox("Username tersebut sudah dipakai", dizMsgboxStyle.Info, Me)
                teKaryawan.Focus()
                Exit Sub
            End If
        End If

        Dim dtSQL As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        If statData = statusData.Baru Then
            idData = GenerateGUID()

            'Dim engine As New dizEngine.engine
            'hashcode = engine.processE(Format(nowTime, "ddMMyyyyHHmmssffffff") & getIPAddress(ipaddparam.IP))
            field.AddRange(New String() {"idstaff", "idcomp", "idposition", "iddepartment", "idunit", "iduser", "nik", "nama", "namapanggilan", "jeniskelamin", "stafftype", "agama", "kewarganegaraan", "kotalahir", "tanggallahir", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idData, idcomp, If(lueEntryJabatan.EditValue, CObj(DBNull.Value)), If(lueEntryDepartment.EditValue, CObj(DBNull.Value)), If(lueEntryUnit.EditValue, CObj(DBNull.Value)), If(lueUsername.EditValue, CObj(DBNull.Value)), teNIK.Text, teKaryawan.Text, tePanggilan.Text, lueJenisKelamin.EditValue, lueEntryJenisKaryawan.EditValue, lueAgama.EditValue, lueKewarganegaraan.EditValue, lueTempatLahir.EditValue, CDate(deTanggalLahir.EditValue), 0, userid, nowTime})
        Else
            field.AddRange(New String() {"idstaff", "iduser", "nik", "nama", "namapanggilan", "jeniskelamin", "agama", "kewarganegaraan", "kotalahir", "tanggallahir", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, If(lueUsername.EditValue, CObj(DBNull.Value)), teNIK.Text, teKaryawan.Text, tePanggilan.Text, lueJenisKelamin.EditValue, lueAgama.EditValue, lueKewarganegaraan.EditValue, lueTempatLahir.EditValue, CDate(deTanggalLahir.EditValue), userid, nowTime})
        End If
        If dtSQL.datasetSave("staff", idData, field, value, False) = True Then
            If statData = statusData.Baru Then
                Dim idtmp As String
                idtmp = GenerateGUID()

                field.Clear()
                value.Clear()

                field.AddRange(New String() {"idmutasistaff", "idcompany", "idstaff", "idposition", "iddepartment", "idunit", "stafftype", "mutasino", "mutasidate", "remarks", "isdeleted", "createdby", "createddate"})
                value.AddRange(New Object() {idtmp, idcomp, idData, If(lueEntryJabatan.EditValue, CObj(DBNull.Value)), If(lueEntryDepartment.EditValue, CObj(DBNull.Value)), If(lueEntryUnit.EditValue, CObj(DBNull.Value)), lueEntryJenisKaryawan.EditValue, teEntryMutasiNo.Text, CDate(deTanggalBekerja.EditValue), "Karyawan Baru", 0, userid, nowTime})
                dtSQL = New dtsetSQLS(dbstring)
                dtSQL.datasetSave("mutasistaff", idtmp, field, value, False)
            End If

            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            isiLog(userid, dbstring, field, value, "staff")

            btnNew_Click(Me, Nothing)
        Else
            dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim retval As Boolean = False
        Dim sqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If btnDelete.Text = "HAPUS" Then
            field.AddRange(New String() {"idstaff", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 1, userid, nowTime})
            retval = sqls.datasetSave("staff", idData, field, value, False)
            isiLog(userid, dbstring, field, value, "staff")
        ElseIf btnDelete.Text = "AKTIF" Then
            field.AddRange(New String() {"idstaff", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 0, userid, nowTime})
            retval = sqls.datasetSave("staff", idData, field, value, False)
            isiLog(userid, dbstring, field, value, "staff")
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

    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        Try
            fromGrid = True
            Dim dcol As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
            teNIK.Text = dcol("nik")
            teKaryawan.Text = dcol("nama")
            tePanggilan.Text = dcol("namapanggilan")
            lueEntryUnit.EditValue = dcol("idunit")
            lueEntryDepartment.EditValue = dcol("iddepartment")
            lueEntryJabatan.EditValue = dcol("idposition")
            lueEntryJenisKaryawan.EditValue = dcol("stafftype")
            lueJenisKelamin.EditValue = dcol("jk")
            lueUsername.EditValue = If(dcol("iduser"), Nothing)
            lueKewarganegaraan.EditValue = dcol("kewarganegaraan")
            lueTempatLahir.EditValue = dcol("kotalahir")
            lueAgama.EditValue = dcol("agama")
            deTanggalLahir.EditValue = Strdate2Date(dcol("tanggallahir").ToString)

            lueEntryJabatan.Enabled = False
            lueEntryJabatan.BackColor = entryDisabled
            lueEntryJenisKaryawan.Enabled = False
            lueEntryJenisKaryawan.BackColor = entryDisabled
            lueEntryDepartment.Enabled = False
            lueEntryDepartment.BackColor = entryDisabled
            lueEntryUnit.Enabled = False
            lueEntryUnit.BackColor = entryDisabled
            teEntryMutasiNo.Enabled = False
            teEntryMutasiNo.BackColor = entryDisabled
            deTanggalBekerja.Enabled = False
            deTanggalBekerja.BackColor = entryDisabled

            idData = dcol("idstaff")
            If dcol("isdeleted") = 0 Then
                btnDelete.Text = "HAPUS"
            ElseIf dcol("isdeleted") = 1 Then
                btnDelete.Text = "AKTIF"
            End If
            statData = statusData.Edit

            btnNew.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True
            enablePanel(True, True, True, True, True, True, True, True, True)
            If dcol("nik") = "VENDOR" Then
                btnSave.Enabled = False
                btnDelete.Enabled = False

                enablePanel(False, False, False, False, False, False, False, False, False)
            End If

            tbAdditional.SelectedItem = tbiAlamat
            TileBoxItem_ItemClick(tbiAlamat, Nothing)
            tbAdditional.Enabled = True
            'xtcAdditional.SelectedTabPage = xtpAddress
            xtcAdditional.Enabled = True

            loadAlamat(idData)
            btnNewAlamat_Click(btnNewAlamat, Nothing)
            loadPendidikan(idData)
            loadKartu(idData)
            loadEmail(idData)
            loadPhone(idData)
            loadSosmed(idData)
            loadMutasi(idData)
            loadTeguran(idData)
            loadPelatihan(idData)
            loadKeluarga(idData)

            fromGrid = False
            fromGridChild = False
        Catch ex As Exception
            btnNew_Click(Me, Nothing)
        End Try
    End Sub

    Private Sub loadAlamat(idreff As String)
        fromGridChild = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select a.idalamat,a.idnegara,a.idpropinsi,a.idkabupaten,a.idkecamatan,a.idkelurahan,a.alamat,a.addresstype,a.isdeleted,a.isprimary,n.wilayah as negara,p.wilayah as propinsi,b.wilayah as kabupaten,c.wilayah as kecamatan,l.wilayah as kelurahan,del.generalcode as statdata,pri.generalcode as [primary],adt.generalcode as jenisalamat,a.kodepos from alamat a left join wilayah n on a.idnegara=n.idwilayah left join wilayah p on a.idpropinsi=p.idwilayah left join wilayah b on a.idkabupaten=b.idwilayah left join wilayah c on a.idkecamatan=c.idwilayah left join wilayah l on a.idkelurahan=l.idwilayah left join sys_generalcode del on a.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode pri on a.isprimary=pri.idgeneral and pri.gctype='ISPRIMARY' left join sys_generalcode adt on a.addresstype=adt.idgeneral and adt.gctype='ADDRESSTYPE' where a.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and a.tablereff='KARYAWAN' and a.idreff='" & idreff & "'", "alamat")
        gcAlamat.DataSource = sqls.dataTable("alamat")
        gvAlamat.BestFitColumns()
        fromGridChild = True
    End Sub

    Private Sub loadPendidikan(idreff As String)
        fromGridChild = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select d.idpendidikan,d.pendidikan,p.generalcode as jenispendidikan,d.nomorijazah,d.nama,d.jurusan,year(d.tahunmasuk) as tahunmasuk,year(d.tahunlulus) as tahunlulus,d.nilaiakhir,d.remarks,d.isvalid,v.generalcode as valid,d.isdeleted,l.generalcode as statdata,d.createdby,d.createddate from pendidikan d left join sys_generalcode v on d.isvalid=v.idgeneral and v.gctype='ISVALID' left join sys_generalcode l on d.isdeleted=l.idgeneral and l.gctype='DELETE' left join sys_generalcode p on d.pendidikan=p.idgeneral and p.gctype='PENDIDIKAN' where d.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and d.tablereff='KARYAWAN' and d.idreff='" & idreff & "'", "pendidikan")
        gcPendidikan.DataSource = sqls.dataTable("pendidikan")
        gvPendidikan.BestFitColumns()
        fromGridChild = True
    End Sub

    Private Sub loadEmail(idreff As String)
        fromGridChild = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select e.idemail,e.email,e.emailtype,e.isdeleted,e.isprimary,del.generalcode as statdata,pri.generalcode as [primary],et.generalcode as jenisemail from email e left join sys_generalcode et on e.emailtype=et.idgeneral and et.gctype='EMAILTYPE' left join sys_generalcode del on e.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode pri on e.isprimary=pri.idgeneral and pri.gctype='ISPRIMARY' where e.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and e.tablereff='KARYAWAN' and e.idreff='" & idreff & "'", "email")
        gcEmail.DataSource = sqls.dataTable("email")
        gvemail.BestFitColumns()
        fromGridChild = True
    End Sub

    Private Sub loadPhone(idreff As String)
        fromGridChild = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select p.idphone,p.phone,p.extension,p.phonetype,p.isdeleted,p.isprimary,del.generalcode as statdata,pri.generalcode as [primary],et.generalcode as jenistelepon from phone p left join sys_generalcode et on p.phonetype=et.idgeneral and et.gctype='PHONETYPE' left join sys_generalcode del on p.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode pri on p.isprimary=pri.idgeneral and pri.gctype='ISPRIMARY' where p.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and p.tablereff='KARYAWAN' and p.idreff='" & idreff & "'", "phone")
        gcTelepon.DataSource = sqls.dataTable("phone")
        gvTelepon.BestFitColumns()
        fromGridChild = True
    End Sub

    Private Sub loadKartu(idreff As String)
        fromGridChild = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select k.idkartu,k.jeniskartu,ct.generalcode as cardtype,k.isdeleted,del.generalcode as statdata,k.jenistanggal,cdt.generalcode as carddatetype,k.nomorkartu,k.namakartu,convert(varchar,k.tanggalkartu,105) as tanggalkartu from kartu k left join sys_generalcode ct on k.jeniskartu=ct.idgeneral and ct.gctype='CARDTYPE' left join sys_generalcode cdt on k.jenistanggal=cdt.idgeneral and cdt.gctype='CARDDATETYPE' left join sys_generalcode del on k.isdeleted=del.idgeneral and del.gctype='DELETE' where k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and k.tablereff='KARYAWAN' and k.idreff='" & idreff & "'", "kartu")
        gcKartu.DataSource = sqls.dataTable("kartu")
        gvKartu.BestFitColumns()
        fromGridChild = True
    End Sub

    Private Sub loadSosmed(idreff As String)
        fromGridChild = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select s.idsosialmedia,s.sosialmedia,s.sosialmediatype,s.isdeleted,s.isvalid,del.generalcode as statdata,isv.generalcode as validasi,et.generalcode as jenissosmed from sosialmedia s left join sys_generalcode et on s.sosialmediatype=et.idgeneral and et.gctype='SOCIALMEDIA' left join sys_generalcode del on s.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode isv on s.isvalid=isv.idgeneral and isv.gctype='ISVALID' where s.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and s.tablereff='KARYAWAN' and s.idreff='" & idreff & "'", "sosmed")
        gcSosialMedia.DataSource = sqls.dataTable("sosmed")
        gvSosialMedia.BestFitColumns()
        fromGridChild = True
    End Sub

    Private Sub loadMutasi(idreff As String)
        fromGridChild = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select m.idmutasistaff,m.mutasino,convert(varchar,m.mutasidate,105) as mutasidate,m.idposition,m.iddepartment,m.idunit,m.stafftype,m.remarks,m.isdeleted,st.generalcode as jeniskaryawan,del.generalcode as statdata, p.position,d.department,u.unit from mutasistaff m left join position p on m.idposition=p.idposition left join department d on m.iddepartment=d.iddepartment left join unit u on m.idunit=u.idunit left join sys_generalcode del on m.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode st on m.stafftype=st.idgeneral and st.gctype='STAFFTYPE' where m.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and m.idstaff='" & idreff & "'", "mutasi")
        gcMutasi.DataSource = sqls.dataTable("mutasi")
        gvMutasi.BestFitColumns()
        fromGridChild = True
    End Sub

    Private Sub loadTeguran(idreff As String)
        fromGridChild = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select t.idteguran, t.idunit,u.unit,t.teguranno, convert(varchar,t.tegurandate,105) as tegurandate, convert(varchar,t.teguranduedate,105) as teguranduedate, t.tegurantype, t.remarks, t.isdeleted,teg.generalcode as jenisteguran,del.generalcode as statdata from teguran t left join unit u on t.idunit=u.idunit left join sys_generalcode del on t.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode teg on t.tegurantype=teg.idgeneral and teg.gctype='TEGURAN' where t.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and t.tablereff='KARYAWAN' and t.idreff='" & idreff & "'", "teguran")
        gcTeguran.DataSource = sqls.dataTable("teguran")
        gvTeguran.BestFitColumns()
        fromGridChild = True
    End Sub

    Private Sub loadPelatihan(idreff As String)
        fromGridChild = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select l.idpelatihan,l.idreff,l.tablereff,l.nomorsertifikat,l.judul,l.tempat,convert(varchar,l.tanggalpelatihan,105) as tanggalpelatihan,l.remarks,l.isdeleted,del.generalcode as statdata from pelatihan l left join sys_generalcode as del on del.idgeneral=l.isdeleted and del.generalcode='DELETE' where l.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and l.tablereff='KARYAWAN' and l.idreff='" & idreff & "'", "pelatihan")
        gcPelatihan.DataSource = sqls.dataTable("pelatihan")
        gvPelatihan.BestFitColumns()
        fromGridChild = True
    End Sub

    Private Sub loadKeluarga(idreff As String)
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select k.idkeluarga,k.nama,k.familytype,ft.generalcode as jeniskeluarga,k.isdeleted,del.generalcode as statdata,pp.idphone as idphone1,isnull(pp.phone,0) as phone1,ps.idphone as idphone2,isnull(ps.phone,0) as phone2 from keluarga k left join sys_generalcode ft on k.familytype=ft.idgeneral and ft.gctype='FAMILYTYPE' left join sys_generalcode del on k.isdeleted=del.idgeneral and del.gctype='DELETE' left join phone pp on k.idkeluarga=pp.idreff and pp.tablereff='KELUARGASTAFF' and pp.isprimary=1 and pp.phonetype=2 left join phone ps on k.idkeluarga=ps.idreff and ps.tablereff='KELUARGASTAFF' and ps.isprimary=1 and ps.phonetype=3 where k.tablereff='PASIEN' and k.idreff='" & idreff & "'", "keluarga")
        gcKeluarga.DataSource = sqls.dataTable("keluarga")
        gvKeluarga.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub enablePanel(alamat As Boolean, email As Boolean, telepon As Boolean, sosmed As Boolean, mutasi As Boolean, teguran As Boolean, kartu As Boolean, pelatihan As Boolean, pendidikan As Boolean)
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
        btnNewMutasi.Enabled = mutasi
        btnSaveMutasi.Enabled = mutasi
        btnDeleteMutasi.Enabled = mutasi
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
        checkFieldMaxLength(dbstring, tlpField, "staff")
        checkFieldMaxLength(dbstring, tlpField, "mutasistaff")
        checkFieldMaxLength(dbstring, tlpAlamat1, "alamat")
        checkFieldMaxLength(dbstring, tlpAlamat2, "alamat")
        checkFieldMaxLength(dbstring, tlpPendidikan, "pendidikan")
        checkFieldMaxLength(dbstring, tlpKartu, "kartu")
        checkFieldMaxLength(dbstring, tlpEmail, "email")
        checkFieldMaxLength(dbstring, tlpTelepon, "phone")
        checkFieldMaxLength(dbstring, tlpSosmed, "sosialmedia")
        checkFieldMaxLength(dbstring, tlpMutasi, "mutasistaff")
        checkFieldMaxLength(dbstring, tlpTeguran, "teguran")
        checkFieldMaxLength(dbstring, tlpPelatihan, "pelatihan")
        deTanggalLahir.Properties.MaxValue = nowTime

        loadLOV()
        btnNew_Click(Me, Nothing)
    End Sub

    Private Sub lueNegara_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueNegara.EditValueChanged
        Try
            If fromGridChild = True Then Exit Sub
            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isdeleted=0 and idparent='" & sender.EditValue & "'", "propinsi")
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
            mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isdeleted=0 and idparent='" & sender.EditValue & "'", "kabupaten")
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
            mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isdeleted=0 and idparent='" & sender.EditValue & "'", "kecamatan")
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
            mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isdeleted=0 and idparent='" & sender.EditValue & "'", "kelurahan")
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

    Private fromGridChild As Boolean = False
    Private fromGrid As Boolean = False
    Private Sub lueDepartment_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueEntryDepartment.EditValueChanged, lueEntryJabatan.EditValueChanged, lueEntryUnit.EditValueChanged
        If fromGrid = True Then Exit Sub
        If sender.text = "VENDOR" Then
            dizMsgbox("Tidak diijinkan memilih VENDOR", dizMsgboxStyle.Peringatan, Me)
            sender.editvalue = Nothing
        End If
    End Sub

    Private Sub NIK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles teNIK.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rNIK) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

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
            sqls.DMLQuery("update alamat set isprimary=0 where idreff='" & idData & "' and tablereff='KARYAWAN'", False)

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

            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            field.AddRange(New String() {"idalamat", "idcompany", "idreff", "tablereff", "idnegara", "idpropinsi", "idkabupaten", "idkecamatan", "idkelurahan", "alamat", "addresstype", "kodepos", "isdeleted", "isprimary", "createdby", "createddate"})
            If gvAlamat.RowCount = 0 Then
                value.AddRange(New Object() {idDataChild, idcomp, idData, "KARYAWAN", If(lueNegara.EditValue, CObj(DBNull.Value)), If(luePropinsi.EditValue, CObj(DBNull.Value)), If(lueKabupaten.EditValue, CObj(DBNull.Value)), If(lueKecamatan.EditValue, CObj(DBNull.Value)), If(lueKelurahan.EditValue, CObj(DBNull.Value)), meAlamat.Text, lueAddressType.EditValue, teKodepos.Text, 0, 1, userid, nowTime})
            Else
                value.AddRange(New Object() {idDataChild, idcomp, idData, "KARYAWAN", If(lueNegara.EditValue, CObj(DBNull.Value)), If(luePropinsi.EditValue, CObj(DBNull.Value)), If(lueKabupaten.EditValue, CObj(DBNull.Value)), If(lueKecamatan.EditValue, CObj(DBNull.Value)), If(lueKelurahan.EditValue, CObj(DBNull.Value)), meAlamat.Text, lueAddressType.EditValue, teKodepos.Text, 0, 0, userid, nowTime})
            End If
            If dtsql.datasetSave("alamat", idDataChild, field, value, False) = True Then
                isiLog(userid, dbstring, field, value, "alamat")
                dizMsgbox("Alamat telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            field.AddRange(New String() {"idalamat", "idreff", "tablereff", "idnegara", "idpropinsi", "idkabupaten", "idkecamatan", "idkelurahan", "alamat", "addresstype", "kodepos", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, idData, "KARYAWAN", If(lueNegara.EditValue, CObj(DBNull.Value)), If(luePropinsi.EditValue, CObj(DBNull.Value)), If(lueKabupaten.EditValue, CObj(DBNull.Value)), If(lueKecamatan.EditValue, CObj(DBNull.Value)), If(lueKelurahan.EditValue, CObj(DBNull.Value)), meAlamat.Text, lueAddressType.EditValue, teKodepos.Text, userid, nowTime})
            If dtsql.datasetSave("alamat", idDataChild, field, value, False) = True Then
                isiLog(userid, dbstring, field, value, "alamat")
                dizMsgbox("Alamat telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        End If
        loadAlamat(idData)
        btnNewAlamat_Click(btnNewAlamat, Nothing)
    End Sub

    Private Sub gvAlamat_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvAlamat.FocusedRowChanged
        fromGridChild = True
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
        loadpendidikan(idData)
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
        If statDataChild = statusData.Baru Then
            Dim sqls1 As New SQLs(dbstring)
            sqls1.DMLQuery("select pendidikan from pendidikan where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and tablereff='KARYAWAN' and idreff='" & idData & "' and pendidikan='" & luePendidikan.EditValue & "' and replace(nama,' ','')='" & teInstansi.Text.Replace(" ", "") & "' and replace(jurusan,' ','')='" & teJurusan.Text.Replace(" ", "") & "'", "cek")
            If sqls1.getDataSet("cek") = 0 Then
                idDatachild = "-1"
            Else
                dizMsgbox("Pendidikan tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teEmail.Focus()
                Exit Sub
            End If
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            field.AddRange(New String() {"idpendidikan", "idcompany", "idreff", "tablereff", "pendidikan", "nomorijazah", "nama", "jurusan", "tahunmasuk", "tahunlulus", "nilaiakhir", "isvalid", "remarks", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idDataChild, idcomp, idData, "KARYAWAN", luePendidikan.EditValue, teNomorIjazah.Text, teInstansi.Text, teJurusan.Text, CDate(deTahunMasuk.EditValue), CDate(deTahunLulus.EditValue), seNilaiAkhir.Value, 0, tePendidikanRemarks.Text, 0, userid, nowTime})
            If dtsql.datasetSave("pendidikan", idDataChild, field, value, False) = True Then
                isiLog(userid, dbstring, field, value, "pendidikan")
                dizMsgbox("Pendidikan telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            field.AddRange(New String() {"idpendidikan", "idreff", "tablereff", "pendidikan", "nomorijazah", "nama", "jurusan", "tahunmasuk", "tahunlulus", "nilaiakhir", "isvalid", "remarks", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, idData, "KARYAWAN", luePendidikan.EditValue, teNomorIjazah.Text, teInstansi.Text, teJurusan.Text, CDate(deTahunMasuk.EditValue), CDate(deTahunLulus.EditValue), seNilaiAkhir.Value, 0, tePendidikanRemarks.Text, userid, nowTime})
            If dtsql.datasetSave("pendidikan", idDataChild, field, value, False) = True Then
                isiLog(userid, dbstring, field, value, "pendidikan")
                dizMsgbox("Pendidikan telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        End If
        loadPendidikan(idData)
        btnNewPendidikan_Click(btnNewPendidikan, Nothing)
    End Sub

    Private Sub gvPendidikan_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvPendidikan.FocusedRowChanged
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
            btnDeletePendidikan.Text = "AKTIF"
        ElseIf dcol("isdeleted") = 1 Then
            btnDeletePendidikan.Text = "HAPUS"
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
            sqls.DMLQuery("select email from email where tablereff='KARYAWAN' and idreff='" & idData & "' and email='" & teEmail.Text & "'", "cek")
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
            If gvEmail.RowCount = 0 Then
                value.AddRange(New Object() {idDataChild, idcomp, idData, "KARYAWAN", teEmail.Text, lueEmailType.EditValue, 0, 1, userid, nowTime})
            Else
                value.AddRange(New Object() {idDataChild, idcomp, idData, "KARYAWAN", teEmail.Text, lueEmailType.EditValue, 0, 0, userid, nowTime})
            End If
            If dtsql.datasetSave("email", idDataChild, field, value, False) = True Then
                isiLog(userid, dbstring, field, value, "email")
                dizMsgbox("Email telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            field.AddRange(New String() {"idemail", "idreff", "tablereff", "email", "emailtype", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, idData, "KARYAWAN", teEmail.Text, lueEmailType.EditValue, userid, nowTime})
            If dtsql.datasetSave("email", idDataChild, field, value, False) = True Then
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
            sqls.DMLQuery("update email set isprimary=0 where idreff='" & idData & "' and tablereff='KARYAWAN'", False)

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
            btnDeleteEmail.Text = "AKTIF"
        ElseIf dcol("isdeleted") = 1 Then
            btnDeleteEmail.Text = "HAPUS"
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
            sqls.DMLQuery("update phone set isprimary=0 where phonetype='" & luePhoneType.EditValue & "' and idreff='" & idData & "' and tablereff='KARYAWAN'", False)

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
            sqls.DMLQuery("select phone from phone where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and tablereff='KARYAWAN' and idreff='" & idData & "' and phone='" & tePhone.Text & "'", "cek")
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
                value.AddRange(New Object() {idDataChild, idcomp, idData, "KARYAWAN", tePhone.Text, teExtension.Text, luePhoneType.EditValue, 0, 1, userid, nowTime})
            Else
                value.AddRange(New Object() {idDataChild, idcomp, idData, "KARYAWAN", tePhone.Text, teExtension.Text, luePhoneType.EditValue, 0, 0, userid, nowTime})
            End If
            If dtsql.datasetSave("phone", idDataChild, field, value, False) = True Then
                isiLog(userid, dbstring, field, value, "phone")
                dizMsgbox("Telepon telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            field.AddRange(New String() {"idphone", "idreff", "tablereff", "phone", "extension", "phonetype", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, idData, "KARYAWAN", tePhone.Text, teExtension.Text, luePhoneType.EditValue, userid, nowTime})

            If dtsql.datasetSave("phone", idDataChild, field, value, False) = True Then
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
            btnDeleteTelepon.Text = "AKTIF"
        ElseIf dcol("isdeleted") = 1 Then
            btnDeleteTelepon.Text = "HAPUS"
        End If
        btnNewTelepon.Enabled = True
        btnSaveTelepon.Enabled = True
        btnDeleteTelepon.Enabled = True
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
            sqls.DMLQuery("select sosialmedia from sosialmedia where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and tablereff='KARYAWAN' and idreff='" & idData & "' and sosialmediatype='" & lueJenisSosmed.EditValue & "'", "cek")
            If sqls.getDataSet("cek") = 0 Then
                idDatachild = "-1"
            Else
                dizMsgbox("Sosial Media tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teEmail.Focus()
                Exit Sub
            End If
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            field.AddRange(New String() {"idsosialmedia", "idcompany", "idreff", "tablereff", "sosialmedia", "sosialmediatype", "isdeleted", "isvalid", "createdby", "createddate"})
            value.AddRange(New Object() {idDataChild, idcomp, idData, "KARYAWAN", teUsernameSosmed.Text, lueJenisSosmed.EditValue, 0, 0, userid, nowTime})
            If dtsql.datasetSave("sosialmedia", idDataChild, field, value, False) = True Then
                isiLog(userid, dbstring, field, value, "sosialmedia")
                dizMsgbox("Sosial Media telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            field.AddRange(New String() {"idsosialmedia", "idreff", "tablereff", "sosialmedia", "sosialmediatype", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, idData, "KARYAWAN", teUsernameSosmed.Text, lueJenisSosmed.EditValue, userid, nowTime})
            If dtsql.datasetSave("sosialmedia", idDataChild, field, value, False) = True Then
                isiLog(userid, dbstring, field, value, "sosialmedia")
                dizMsgbox("Sosial Media telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        End If
        loadSosmed(idData)
        btnNewSosmed_Click(btnNewSosmed, Nothing)
    End Sub

    Private Sub gvSosialMedia_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvSosialMedia.FocusedRowChanged
        Dim dcol As DataRow = gvSosialMedia.GetDataRow(e.FocusedRowHandle)

        statDataChild = statusData.Edit
        idDataChild = dcol("idsosialmedia")
        lueJenisSosmed.EditValue = dcol("sosialmediatype")
        teUsernameSosmed.Text = dcol("sosialmedia")
        If dcol("isvalid") = 0 Then
            btnvalidsosmed.text = "VALID"
        ElseIf dcol("isvalid") = 1 Then
            btnvalidsosmed.text = "NOT VALID"
        End If
        If dcol("isdeleted") = 0 Then
            btnDeleteSosmed.Text = "AKTIF"
        ElseIf dcol("isdeleted") = 1 Then
            btnDeleteSosmed.Text = "HAPUS"
        End If
        btnNewSosmed.Enabled = True
        btnSaveSosmed.Enabled = True
        btnDeleteSosmed.Enabled = True
        btnValidSosmed.Enabled = True
    End Sub

    Private Sub btnNewMutasi_Click(sender As Object, e As EventArgs) Handles btnNewMutasi.Click
        kosongkanIsian(tlpMutasi)

        btnNewMutasi.Enabled = False
        btnSaveMutasi.Enabled = True
        btnDeleteMutasi.Enabled = False
        btnDeleteMutasi.Text = "HAPUS"
        statDataChild = statusData.Baru
        idDatachild = "-1"
    End Sub

    Private Sub btnDeleteMutasi_Click(sender As Object, e As EventArgs) Handles btnDeleteMutasi.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idmutasistaff", "isdeleted", "updatedby", "updateddate"})
        If btnDeleteMutasi.Text = "HAPUS" Then
            value.AddRange(New Object() {idDataChild, 1, userid, nowTime})
            dtsql.datasetSave("mutasistaff", idDataChild, field, value, False)
            btnDeleteMutasi.Text = "AKTIF"
        ElseIf btnDeleteMutasi.Text = "AKTIF" Then
            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("mutasistaff", idDataChild, field, value, False)
            btnDeleteMutasi.Text = "HAPUS"
        End If
        loadMutasi(idData)
        btnNewMutasi_Click(btnNewMutasi, Nothing)
    End Sub

    Private Sub btnSaveMutasi_Click(sender As Object, e As EventArgs) Handles btnSaveMutasi.Click
        Dim bentry As Boolean = True
        bentry = checkEntry(tlpMutasi)
        If bentry = False Then
            dizMsgbox("Data Mutasi belum diisi dengan benar", dizMsgboxStyle.Peringatan, "Peringatan", Me)
            Exit Sub
        End If
        If statDataChild = statusData.Baru Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select mutasino from mutasistaff where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and idstaff='" & idData & "' and idposition='" & lueJabatan.EditValue & "' and iddepartment='" & lueDepartment.EditValue & "' and idunit='" & lueUnit.EditValue & "' and stafftype='" & lueJenisKaryawan.EditValue & "'", "cek")
            If sqls.getDataSet("cek") = 0 Then
                idDatachild = "-1"
            Else
                dizMsgbox("Mutasi tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teEmail.Focus()
                Exit Sub
            End If
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            field.AddRange(New String() {"idmutasistaff", "idcompany", "idstaff", "idposition", "iddepartment", "idunit", "stafftype", "mutasino", "mutasidate", "remarks", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idDataChild, idcomp, idData, lueJabatan.EditValue, lueDepartment.EditValue, lueUnit.EditValue, lueJenisKaryawan.EditValue, teMutasiNo.Text, CDate(deTanggalMutasi.EditValue), teMutasiRemarks.Text, 0, userid, nowTime})
            If dtsql.datasetSave("mutasistaff", idDataChild, field, value, False) = True Then
                isiLog(userid, dbstring, field, value, "mutasistaff")

                Dim ss As New dtsetSQLS(dbstring)
                Dim fs As New List(Of String)
                Dim vs As New List(Of Object)
                fs.AddRange(New String() {"idstaff", "idposition", "iddepartment", "idunit", "stafftype"})
                vs.AddRange(New Object() {idData, lueJabatan.EditValue, lueDepartment.EditValue, lueUnit.EditValue, lueJenisKaryawan.EditValue})
                ss.datasetSave("staff", idData, fs, vs, False)
                isiLog(userid, dbstring, fs, vs, "staff")

                If lueJenisKaryawan.EditValue = 99 Or lueJenisKaryawan.EditValue = 999 Then
                    Dim sd As New dtsetSQLS(dbstring)
                    Dim fd As New List(Of String)
                    Dim vd As New List(Of Object)

                    fd.AddRange(New String() {"idstaff", "isdeleted", "updatedby", "updateddate"})
                    vd.AddRange(New Object() {idData, 1, userid, nowTime})
                    sd.datasetSave("staff", idData, fd, vd, False)
                    isiLog(userid, dbstring, field, value, "staff")
                End If

                dizMsgbox("Mutasi telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
                btnNew_Click(Me, Nothing)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            field.AddRange(New String() {"idmutasistaff", "idstaff", "idposition", "iddepartment", "idunit", "stafftype", "mutasino", "mutasidate", "remarks", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, idData, lueJabatan.EditValue, lueDepartment.EditValue, lueUnit.EditValue, lueJenisKaryawan.EditValue, teMutasiNo.Text, CDate(deTanggalMutasi.EditValue), teMutasiRemarks.Text, userid, nowTime})
            If dtsql.datasetSave("mutasistaff", idDataChild, field, value, False) = True Then
                isiLog(userid, dbstring, field, value, "mutasistaff")

                dizMsgbox("Mutasi telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)

                loadMutasi(idData)
                btnNewMutasi_Click(btnNewMutasi, Nothing)
            End If
        End If
    End Sub

    Private Sub gvMutasi_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvMutasi.FocusedRowChanged
        Dim dcol As DataRow = gvMutasi.GetDataRow(e.FocusedRowHandle)

        statDataChild = statusData.Edit
        idDataChild = dcol("idmutasistaff")
        lueJabatan.EditValue = dcol("idposition")
        lueDepartment.EditValue = dcol("iddepartment")
        lueUnit.EditValue = dcol("idunit")
        lueJenisKaryawan.EditValue = dcol("stafftype")
        teMutasiNo.Text = dcol("mutasino")
        deTanggalMutasi.EditValue = Strdate2Date(dcol("mutasidate").ToString)
        teMutasiRemarks.Text = dcol("remarks")
        If dcol("isdeleted") = 0 Then
            btnDeleteMutasi.Text = "AKTIF"
        ElseIf dcol("isdeleted") = 1 Then
            btnDeleteMutasi.Text = "HAPUS"
        End If
        btnNewMutasi.Enabled = True
        btnSaveMutasi.Enabled = True
        btnDeleteMutasi.Enabled = True
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
            sqls.DMLQuery("select teguranno from teguran where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and tablereff='KARYAWAN' and idreff='" & idData & "' and tegurantype='" & lueTeguranType.EditValue & "' and convert(varchar,tegurandate,105)='" & Format(CDate(deTanggalTeguran.EditValue), "dd-MM-yyyy") & "'", "cek")
            If sqls.getDataSet("cek") = 0 Then
                idDatachild = "-1"
            Else
                dizMsgbox("Teguran tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teEmail.Focus()
                Exit Sub
            End If
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            field.AddRange(New String() {"idteguran", "idunit", "idcompany", "idreff", "tablereff", "teguranno", "tegurandate", "teguranduedate", "tegurantype", "remarks", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idDataChild, lueTeguranUnit.EditValue, idcomp, idData, "KARYAWAN", teTeguranNo.Text, CDate(deTanggalTeguran.EditValue), CDate(deTanggalAkhir.EditValue), lueTeguranType.EditValue, teTeguranRemarks.Text, 0, userid, nowTime})
            If dtsql.datasetSave("teguran", idDataChild, field, value, False) = True Then
                isiLog(userid, dbstring, field, value, "teguran")
                dizMsgbox("Teguran telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            field.AddRange(New String() {"idteguran", "teguranno", "tegurandate", "teguranduedate", "tegurantype", "remarks", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, teTeguranNo.Text, CDate(deTanggalTeguran.EditValue), CDate(deTanggalAkhir.EditValue), lueTeguranType.EditValue, teTeguranRemarks.Text, userid, nowTime})
            If dtsql.datasetSave("teguran", idDataChild, field, value, False) = True Then
                isiLog(userid, dbstring, field, value, "teguran")
                dizMsgbox("Teguran telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        End If
        loadTeguran(idData)
        btnNewTeguran_Click(btnNewTeguran, Nothing)
    End Sub

    Private Sub gvteguran_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvTeguran.FocusedRowChanged
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
            btnDeleteTeguran.Text = "AKTIF"
        ElseIf dcol("isdeleted") = 1 Then
            btnDeleteTeguran.Text = "HAPUS"
        End If
        btnNewTeguran.Enabled = True
        btnSaveTeguran.Enabled = True
        btnDeleteTeguran.Enabled = True
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
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select nomorsertifikat from pelatihan where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and tablereff='KARYAWAN' and idreff='" & idData & "' and replace(tempat,' ','')='" & tePelatihanTempat.Text.Replace(" ", "") & "' and replace(judul,' ','')='" & tePelatihanJudul.Text.Replace(" ", "") & "' and convert(varchar,tanggalpelatihan,108)='" & Format(CDate(deTanggalPelatihan.EditValue), "dd-MM-yyyy") & "'", "cek")
            If sqls.getDataSet("cek") = 0 Then
                idDatachild = "-1"
            Else
                dizMsgbox("Pelatihan tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teEmail.Focus()
                Exit Sub
            End If
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            field.AddRange(New String() {"idpelatihan", "idcompany", "idreff", "tablereff", "nomorsertifikat", "judul", "tempat", "tanggalpelatihan", "remarks", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idDataChild, idcomp, idData, "KARYAWAN", tePelatihanNo.Text, tePelatihanJudul.Text, tePelatihanTempat.Text, CDate(deTanggalPelatihan.EditValue), tePelatihanRemarks.Text, 0, userid, nowTime})
            If dtsql.datasetSave("pelatihan", idDataChild, field, value, False) = True Then
                isiLog(userid, dbstring, field, value, "pelatihan")
                dizMsgbox("Pelatihan telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            field.AddRange(New String() {"idpelatihan", "idreff", "tablereff", "nomorsertifikat", "judul", "tempat", "tanggalpelatihan", "remarks", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, idData, "KARYAWAN", tePelatihanNo.Text, tePelatihanJudul.Text, tePelatihanTempat.Text, CDate(deTanggalPelatihan.EditValue), tePelatihanRemarks.Text, userid, nowTime})
            If dtsql.datasetSave("pelatihan", idDataChild, field, value, False) = True Then
                isiLog(userid, dbstring, field, value, "pelatihan")
                dizMsgbox("Pelatihan telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        End If
        loadPelatihan(idData)
        btnNewPelatihan_Click(btnNewPelatihan, Nothing)
    End Sub

    Private Sub gvPelatihan_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvPelatihan.FocusedRowChanged
        Dim dcol As DataRow = gvPelatihan.GetDataRow(e.FocusedRowHandle)

        statDataChild = statusData.Edit
        idDataChild = dcol("idpelatihan")
        tePelatihanNo.Text = dcol("nomorsertifikat")
        tePelatihanJudul.Text = dcol("judul")
        tePelatihanRemarks.Text = dcol("remarks")
        tePelatihanTempat.Text = dcol("tempat")
        deTanggalPelatihan.EditValue = Strdate2Date(dcol("tanggalpelatihan").ToString)
        If dcol("isdeleted") = 0 Then
            btnDeletePelatihan.Text = "AKTIF"
        ElseIf dcol("isdeleted") = 1 Then
            btnDeletePelatihan.Text = "HAPUS"
        End If
        btnNewPelatihan.Enabled = True
        btnSavePelatihan.Enabled = True
        btnDeletePelatihan.Enabled = True
    End Sub

    Private Sub xtcAdditional_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtcAdditional.SelectedPageChanged
        If e.Page Is xtpAddress Then
            btnNewAlamat_Click(btnNewAlamat, Nothing)
        ElseIf e.Page Is xtppendidikan Then
            btnNewPendidikan_Click(btnNewPendidikan, Nothing)
        ElseIf e.Page Is xtpKartu Then
            btnNewKartu_Click(btnNewKartu, Nothing)
        ElseIf e.Page Is xtpEmail Then
            btnNewEmail_Click(btnNewEmail, Nothing)
        ElseIf e.Page Is xtpTelepon Then
            btnNewtelepon_Click(btnNewTelepon, Nothing)
        ElseIf e.Page Is xtpSosialMedia Then
            btnNewSosmed_Click(btnNewSosmed, Nothing)
        ElseIf e.Page Is xtpMutasi Then
            btnNewMutasi_Click(btnNewMutasi, Nothing)
        ElseIf e.Page Is xtpTeguran Then
            btnNewTeguran_Click(btnNewTeguran, Nothing)
        ElseIf e.Page Is xtpPelatihan Then
            btnNewPelatihan_Click(btnNewPelatihan, Nothing)
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
            sqls.DMLQuery("select nomorkartu from kartu where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and tablereff='KARYAWAN' and jeniskartu='" & lueJenisKartu.EditValue & "' and idreff='" & idData & "' and replace(nomorkartu,' ','')='" & teNomorKartu.Text.Replace(" ", "") & "'", "cek")
            If sqls.getDataSet("cek") = 0 Then
                idDatachild = "-1"
            Else
                dizMsgbox("Kartu tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teNomorKartu.Focus()
                Exit Sub
            End If
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            field.AddRange(New String() {"idkartu", "idcompany", "idreff", "tablereff", "jeniskartu", "nomorkartu", "namakartu", "tanggalkartu", "jenistanggal", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idDataChild, idcomp, idData, "KARYAWAN", lueJenisKartu.EditValue, teNomorKartu.Text, teNamaKartu.Text, If(deTanggalKartu.EditValue, CObj(DBNull.Value)), If(lueJenisTanggalKartu.EditValue, CObj(DBNull.Value)), 0, userid, nowTime})
            If dtsql.datasetSave("kartu", idDataChild, field, value, False) = True Then
                isiLog(userid, dbstring, field, value, "kartu")
                dizMsgbox("Kartu telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            field.AddRange(New String() {"idkartu", "idreff", "tablereff", "jeniskartu", "nomorkartu", "namakartu", "tanggalkartu", "jenistanggal", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, idData, "KARYAWAN", lueJenisKartu.EditValue, teNomorKartu.Text, teNamaKartu.Text, If(deTanggalKartu.EditValue, CObj(DBNull.Value)), If(lueJenisTanggalKartu.EditValue, CObj(DBNull.Value)), userid, nowTime})
            If dtsql.datasetSave("kartu", idDataChild, field, value, False) = True Then
                isiLog(userid, dbstring, field, value, "kartu")
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
            btnDeleteKartu.Text = "AKTIF"
        ElseIf dcol("isdeleted") = 1 Then
            btnDeleteKartu.Text = "HAPUS"
        End If
        btnNewKartu.Enabled = True
        btnSaveKartu.Enabled = True
        btnDeleteKartu.Enabled = True
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
            idDataChild = GenerateGUID()
            Dim engine As New dizEngine.engine
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idkeluarga", "idreff", "tablereff", "nama", "familytype", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idDataChild, idData, "PASIEN", teNamaKeluarga.Text, lueJenisKeluarga.EditValue, 0, userid, nowTime})
            If dtsql.datasetSave("keluarga", idDataChild, field, value, False) = True Then
                Dim tmpidkeluarga As String = idDataChild
                Dim sqls As New SQLs(dbstring)
                Dim idtmp As String = GenerateGUID()

                field.Clear()
                value.Clear()
                field = New List(Of String)
                value = New List(Of Object)
                dtsql = New dtsetSQLS(dbstring)

                field.AddRange(New String() {"idphone", "idreff", "tablereff", "phone", "extension", "phonetype", "isdeleted", "isprimary", "createdby", "createddate"})
                'If teKeluargaPhone1.Text = "" Then
                '    value.AddRange(New Object() {idtmp, tmpidkeluarga, "KELUARGA", 0, 0, 2, 0, 1, userid, nowTime})
                'Else
                '    value.AddRange(New Object() {idtmp, tmpidkeluarga, "KELUARGA", teKeluargaPhone1.Text, 0, 2, 0, 1, userid, nowTime})
                'End If
                dtsql.datasetSave("phone", idtmp, field, value, False)

                idtmp = GenerateGUID()
                field.Clear()
                value.Clear()
                field = New List(Of String)
                value = New List(Of Object)
                dtsql = New dtsetSQLS(dbstring)

                field.AddRange(New String() {"idphone", "idreff", "tablereff", "phone", "extension", "phonetype", "isdeleted", "isprimary", "createdby", "createddate"})
                'If teKeluargaPhone2.Text = "" Then
                '    value.AddRange(New Object() {idtmp, tmpidkeluarga, "KELUARGA", 0, 0, 3, 0, 1, userid, nowTime})
                'Else
                '    value.AddRange(New Object() {idtmp, tmpidkeluarga, "KELUARGA", teKeluargaPhone1.Text, 0, 3, 0, 0, userid, nowTime})
                'End If
                dtsql.datasetSave("phone", idtmp, field, value, False)

                dizMsgbox("Keluarga telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idkeluarga", "idreff", "tablereff", "nama", "familytype", "isdeleted", "createdby", "createddate"})
            If btnDeleteKeluarga.Text = "AKTIF" Then
                value.AddRange(New Object() {idDataChild, idData, "PASIEN", teNamaKeluarga.Text, lueJenisKeluarga.EditValue, 0, userid, nowTime})
            Else
                value.AddRange(New Object() {idDataChild, idData, "PASIEN", teNamaKeluarga.Text, lueJenisKeluarga.EditValue, 1, userid, nowTime})
            End If
            If dtsql.datasetSave("keluarga", idDataChild, field, value, False) = True Then
                field.Clear()
                value.Clear()
                field = New List(Of String)
                value = New List(Of Object)
                dtsql = New dtsetSQLS(dbstring)

                field.AddRange(New String() {"idphone", "idreff", "tablereff", "phone", "extension", "phonetype", "isdeleted", "isprimary", "createdby", "createddate"})
                'If teKeluargaPhone1.Text = "" Then
                '    value.AddRange(New Object() {teKeluargaPhone1.Tag, idDataChild, "KELUARGA", 0, 0, 2, 0, 1, userid, nowTime})
                'Else
                '    value.AddRange(New Object() {teKeluargaPhone1.Tag, idDataChild, "KELUARGA", teKeluargaPhone1.Text, 0, 2, 0, 1, userid, nowTime})
                'End If
                'dtsql.datasetSave("phone", tekeluargaphone1.tag, field, value, False)

                field.Clear()
                value.Clear()
                field = New List(Of String)
                value = New List(Of Object)
                dtsql = New dtsetSQLS(dbstring)

                field.AddRange(New String() {"idphone", "idreff", "tablereff", "phone", "extension", "phonetype", "isdeleted", "isprimary", "createdby", "createddate"})
                'If teKeluargaPhone2.Text = "" Then
                '    value.AddRange(New Object() {teKeluargaPhone2.Tag, idDataChild, "KELUARGA", 0, 0, 3, 0, 1, userid, nowTime})
                'Else
                '    value.AddRange(New Object() {teKeluargaPhone2.Tag, idDataChild, "KELUARGA", teKeluargaPhone1.Text, 0, 3, 0, 0, userid, nowTime})
                'End If
                'dtsql.datasetSave("phone", teKeluargaPhone2.Tag, field, value, False)

                dizMsgbox("Keluarga telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        End If
        loadKeluarga(idData)
        btnNewKeluarga_Click(btnNewKeluarga, Nothing)
    End Sub

    Private Sub btnDeleteKeluarga_Click(sender As Object, e As EventArgs) Handles btnDeleteKeluarga.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idkeluarga", "isdeleted", "updatedby", "updateddate"})
        If btnDeleteKeluarga.Text = "HAPUS" Then
            value.AddRange(New Object() {idDataChild, 1, userid, nowTime})
            dtsql.datasetSave("Keluarga", idDataChild, field, value, False)
            btnDeleteKeluarga.Text = "AKTIF"
        ElseIf btnDeleteKeluarga.Text = "AKTIF" Then
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
        'teKeluargaPhone1.Text = dcol("phone1")
        'teKeluargaPhone2.Text = dcol("phone2")
        'teKeluargaPhone1.Tag = dcol("idphone1")
        'teKeluargaPhone2.Tag = dcol("idphone2")
        If dcol("isdeleted") = 0 Then
            btnDeleteKeluarga.Text = "AKTIF"
        ElseIf dcol("isdeleted") = 1 Then
            btnDeleteKeluarga.Text = "HAPUS"
        End If
        btnNewKeluarga.Enabled = True
        btnSaveKeluarga.Enabled = True
        btnDeleteKeluarga.Enabled = True
    End Sub

    Private Sub lueKewarganegaraan_EditValueChanged(sender As Object, e As EventArgs) Handles lueKewarganegaraan.EditValueChanged
        If lueKewarganegaraan.EditValue Is Nothing Then
            lueTempatLahir.EditValue = Nothing
            Exit Sub
        End If
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("if (select count(k.idwilayah) from wilayah p left join wilayah k on p.idwilayah=k.idparent where k.levelwilayah=3 and p.idparent='" & lueKewarganegaraan.EditValue & "')=0 begin select idwilayah as id, wilayah as content from wilayah where levelwilayah=0 order by wilayah asc end else begin select k.idwilayah as id, k.wilayah as content from wilayah p left join wilayah k on p.idwilayah=k.idparent where k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and k.levelwilayah=3 and p.idparent='" & lueKewarganegaraan.EditValue & "' order by k.wilayah asc end", "kota")
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

    Private Sub TileBoxItem_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tbiAbsensi.ItemClick, tbiAlamat.ItemClick, tbiEmail.ItemClick, tbiJadwal.ItemClick, tbiKartu.ItemClick, tbiPelatihan.ItemClick, tbiPendidikan.ItemClick, tbiSosialMedia.ItemClick, tbiTeguran.ItemClick, tbiTelepon.ItemClick, tbiPenilaian.ItemClick, tbiMutasi.ItemClick
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
        ElseIf sender Is tbiMutasi Then
            xtcAdditional.SelectedTabPage = xtpMutasi
        ElseIf sender Is tbiTeguran Then
            xtcAdditional.SelectedTabPage = xtpTeguran
        ElseIf sender Is tbiTelepon Then
            xtcAdditional.SelectedTabPage = xtpTelepon
        ElseIf sender Is tbiPenilaian Then
            xtcAdditional.SelectedTabPage = xtpPenilaian
        End If
    End Sub

End Class