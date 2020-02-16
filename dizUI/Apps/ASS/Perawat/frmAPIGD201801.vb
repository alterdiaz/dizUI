Imports DevExpress.XtraTab

Public Class frmAPIGD201801
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
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='AIRWAY' order by generalcode asc", "airway")
        lueAirway.Properties.DataSource = sqls.dataTable("airway")
        lueAirway.Properties.DisplayMember = "content"
        lueAirway.Properties.ValueMember = "id"
        lueAirway.EditValue = Nothing
        If sqls.getDataSet("airway") = 0 Then
            dizMsgbox("Airway tidak ditemukan" & vbCrLf & "Airway harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='AKTHARIAN' order by generalcode asc", "aktharian")
        lueAktifitas.Properties.DataSource = sqls.dataTable("aktharian")
        lueAktifitas.Properties.DisplayMember = "content"
        lueAktifitas.Properties.ValueMember = "id"
        lueAktifitas.EditValue = Nothing
        If sqls.getDataSet("aktharian") = 0 Then
            dizMsgbox("Aktifitas Harian tidak ditemukan" & vbCrLf & "Aktifitas Harian harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISALATBANTU' order by generalcode asc", "alatbantu")
        lueAlatBantu.Properties.DataSource = sqls.dataTable("alatbantu")
        lueAlatBantu.Properties.DisplayMember = "content"
        lueAlatBantu.Properties.ValueMember = "id"
        lueAlatBantu.EditValue = Nothing
        If sqls.getDataSet("alatbantu") = 0 Then
            dizMsgbox("Alat Bantu tidak ditemukan" & vbCrLf & "Alat Bantu harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='BREATHING' order by generalcode asc", "breathing")
        lueBreathing.Properties.DataSource = sqls.dataTable("breathing")
        lueBreathing.Properties.DisplayMember = "content"
        lueBreathing.Properties.ValueMember = "id"
        lueBreathing.EditValue = Nothing
        If sqls.getDataSet("breathing") = 0 Then
            dizMsgbox("Breathing tidak ditemukan" & vbCrLf & "Breathing harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='CRT' order by generalcode asc", "crt")
        lueCRT.Properties.DataSource = sqls.dataTable("crt")
        lueCRT.Properties.DisplayMember = "content"
        lueCRT.Properties.ValueMember = "id"
        lueCRT.EditValue = Nothing
        If sqls.getDataSet("crt") = 0 Then
            dizMsgbox("CRT tidak ditemukan" & vbCrLf & "CRT harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='FREKNYERI' order by generalcode asc", "freknyeri")
        lueFrekNyeri.Properties.DataSource = sqls.dataTable("freknyeri")
        lueFrekNyeri.Properties.DisplayMember = "content"
        lueFrekNyeri.Properties.ValueMember = "id"
        lueFrekNyeri.EditValue = Nothing
        If sqls.getDataSet("freknyeri") = 0 Then
            dizMsgbox("Frekuensi Nyeri tidak ditemukan" & vbCrLf & "Frekuensi Nyeri harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='HAMBATANTERDAPAT' order by generalcode asc", "hambatanterdapat")
        lueHambatanEdukasi.Properties.DataSource = sqls.dataTable("hambatanterdapat")
        lueHambatanEdukasi.Properties.DisplayMember = "content"
        lueHambatanEdukasi.Properties.ValueMember = "id"
        lueHambatanEdukasi.EditValue = Nothing
        If sqls.getDataSet("hambatanterdapat") = 0 Then
            dizMsgbox("Hambatan Edukasi tidak ditemukan" & vbCrLf & "Hambatan Edukasi harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='HAMBATANEDUKASI' order by generalcode asc", "hambatanedukasi")
        lueHambatanJenis.Properties.DataSource = sqls.dataTable("hambatanedukasi")
        lueHambatanJenis.Properties.DisplayMember = "content"
        lueHambatanJenis.Properties.ValueMember = "id"
        lueHambatanJenis.EditValue = Nothing
        If sqls.getDataSet("hambatanedukasi") = 0 Then
            dizMsgbox("Jenis Hambatan tidak ditemukan" & vbCrLf & "Jenis Hambatan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISHAMIL' order by generalcode asc", "ishamil")
        lueHamil.Properties.DataSource = sqls.dataTable("ishamil")
        lueHamil.Properties.DisplayMember = "content"
        lueHamil.Properties.ValueMember = "id"
        lueHamil.EditValue = Nothing
        If sqls.getDataSet("ishamil") = 0 Then
            dizMsgbox("Status Kehamilan tidak ditemukan" & vbCrLf & "Status Kehamilan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='INFORMASI' order by generalcode asc", "informasi")
        lueInformasi.Properties.DataSource = sqls.dataTable("informasi")
        lueInformasi.Properties.DisplayMember = "content"
        lueInformasi.Properties.ValueMember = "id"
        lueInformasi.EditValue = Nothing
        If sqls.getDataSet("informasi") = 0 Then
            dizMsgbox("Informasi tidak ditemukan" & vbCrLf & "Informasi harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISJATUH' order by generalcode asc", "jatuh")
        lueJatuh3bln.Properties.DataSource = sqls.dataTable("jatuh")
        lueJatuh3bln.Properties.DisplayMember = "content"
        lueJatuh3bln.Properties.ValueMember = "id"
        lueJatuh3bln.EditValue = Nothing
        If sqls.getDataSet("jatuh") = 0 Then
            dizMsgbox("Jatuh 3 Bulan tidak ditemukan" & vbCrLf & "Jatuh 3 Bulan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='JENISSKALANYERI' order by generalcode asc", "skalanyeri")
        lueJenisSkala.Properties.DataSource = sqls.dataTable("skalanyeri")
        lueJenisSkala.Properties.DisplayMember = "content"
        lueJenisSkala.Properties.ValueMember = "id"
        lueJenisSkala.EditValue = Nothing
        If sqls.getDataSet("skalanyeri") = 0 Then
            dizMsgbox("Jenis Skala tidak ditemukan" & vbCrLf & "Jenis Skala harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISKESADARAN' order by generalcode asc", "kesadaran")
        lueKesadaran.Properties.DataSource = sqls.dataTable("kesadaran")
        lueKesadaran.Properties.DisplayMember = "content"
        lueKesadaran.Properties.ValueMember = "id"
        lueKesadaran.EditValue = Nothing
        If sqls.getDataSet("kesadaran") = 0 Then
            dizMsgbox("Jenis Kesadaran tidak ditemukan" & vbCrLf & "Jenis Kesadaran harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISSULITJALAN' order by generalcode asc", "sulitjalan")
        lueKesulitanJalan.Properties.DataSource = sqls.dataTable("sulitjalan")
        lueKesulitanJalan.Properties.DisplayMember = "content"
        lueKesulitanJalan.Properties.ValueMember = "id"
        lueKesulitanJalan.EditValue = Nothing
        If sqls.getDataSet("sulitjalan") = 0 Then
            dizMsgbox("Kesulitan Jalan tidak ditemukan" & vbCrLf & "Kesulitan Jalan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISYAKINLAYAN' order by generalcode asc", "yakinlayan")
        lueKeyakinan.Properties.DataSource = sqls.dataTable("yakinlayan")
        lueKeyakinan.Properties.DisplayMember = "content"
        lueKeyakinan.Properties.ValueMember = "id"
        lueKeyakinan.EditValue = Nothing
        If sqls.getDataSet("yakinlayan") = 0 Then
            dizMsgbox("Keyakinan Pelayanan tidak ditemukan" & vbCrLf & "Keyakinan Pelayanan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='KUALITASNYERI' order by generalcode asc", "kualitasnyeri")
        lueKualitasNyeri.Properties.DataSource = sqls.dataTable("kualitasnyeri")
        lueKualitasNyeri.Properties.DisplayMember = "content"
        lueKualitasNyeri.Properties.ValueMember = "id"
        lueKualitasNyeri.EditValue = Nothing
        If sqls.getDataSet("kualitasnyeri") = 0 Then
            dizMsgbox("Kualitas Nyeri tidak ditemukan" & vbCrLf & "Kualitas Nyeri harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='JENISMENINGGAL' order by generalcode asc", "meninggaljenis")
        lueMeninggalJenis.Properties.DataSource = sqls.dataTable("meninggaljenis")
        lueMeninggalJenis.Properties.DisplayMember = "content"
        lueMeninggalJenis.Properties.ValueMember = "id"
        lueMeninggalJenis.EditValue = Nothing
        If sqls.getDataSet("meninggaljenis") = 0 Then
            dizMsgbox("Jenis Meninggal tidak ditemukan" & vbCrLf & "Jenis Meninggal harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='MENJALAR' order by generalcode asc", "menjalar")
        lueMenjalar.Properties.DataSource = sqls.dataTable("menjalar")
        lueMenjalar.Properties.DisplayMember = "content"
        lueMenjalar.Properties.ValueMember = "id"
        lueMenjalar.EditValue = Nothing
        If sqls.getDataSet("menjalar") = 0 Then
            dizMsgbox("Menjalar tidak ditemukan" & vbCrLf & "Menjalar harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select * from vkamar order by priority asc,ward asc", "mrsjenis")
        lueMRSJenis.Properties.DataSource = sqls.dataTable("mrsjenis")
        lueMRSJenis.Properties.DisplayMember = "content"
        lueMRSJenis.Properties.ValueMember = "id"
        lueMRSJenis.EditValue = Nothing
        If sqls.getDataSet("mrsjenis") = 0 Then
            dizMsgbox("Jenis Kamar tidak ditemukan" & vbCrLf & "Jenis Kamar harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ISNADI' order by idgeneral asc", "isnadi")
        lueNadiJenis.Properties.DataSource = sqls.dataTable("isnadi")
        lueNadiJenis.Properties.DisplayMember = "content"
        lueNadiJenis.Properties.ValueMember = "id"
        lueNadiJenis.EditValue = Nothing
        If sqls.getDataSet("isnadi") = 0 Then
            dizMsgbox("Jenis Nadi tidak ditemukan" & vbCrLf & "Jenis Nadi harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='PENDIDIKAN'", "pendidikan")
        luePendidikan.Properties.DataSource = sqls.dataTable("pendidikan")
        luePendidikan.Properties.DisplayMember = "content"
        luePendidikan.Properties.ValueMember = "id"
        If sqls.getDataSet("pendidikan") = 0 Then
            dizMsgbox("Pendidikan tidak ditemukan" & vbCrLf & "Pendidikan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='ISPENERJEMAH'", "penerjemah")
        luePenerjemah.Properties.DataSource = sqls.dataTable("penerjemah")
        luePenerjemah.Properties.DisplayMember = "content"
        luePenerjemah.Properties.ValueMember = "id"
        If sqls.getDataSet("penerjemah") = 0 Then
            dizMsgbox("Penerjemah tidak ditemukan" & vbCrLf & "Penerjemah harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where levelwilayah=1 order by wilayah asc", "kwn")
        luePenerjemahBahasa.Properties.DataSource = sqls.dataTable("kwn")
        luePenerjemahBahasa.Properties.DisplayMember = "content"
        luePenerjemahBahasa.Properties.ValueMember = "id"
        If sqls.getDataSet("kwn") = 0 Then
            dizMsgbox("Bahasa tidak ditemukan" & vbCrLf & "Bahasa harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='PENDARAHAN'", "pendarahan")
        luePendarahan.Properties.DataSource = sqls.dataTable("pendarahan")
        luePendarahan.Properties.DisplayMember = "content"
        luePendarahan.Properties.ValueMember = "id"
        If sqls.getDataSet("pendarahan") = 0 Then
            dizMsgbox("Pendarahan tidak ditemukan" & vbCrLf & "Pendarahan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='PSIKOLOGIS'", "psikologi")
        luePsikologis.Properties.DataSource = sqls.dataTable("psikologi")
        luePsikologis.Properties.DisplayMember = "content"
        luePsikologis.Properties.ValueMember = "id"
        If sqls.getDataSet("psikologi") = 0 Then
            dizMsgbox("Psikologis tidak ditemukan" & vbCrLf & "Psikologis harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idbusinesspartner as id,nama as content from businesspartner where businesspartnertype=5 order by idbusinesspartner asc", "rujukrs")
        lueRujukRS.Properties.DataSource = sqls.dataTable("rujukrs")
        lueRujukRS.Properties.DisplayMember = "content"
        lueRujukRS.Properties.ValueMember = "id"
        If sqls.getDataSet("rujukrs") = 0 Then
            dizMsgbox("Rumah Sakit/Klinik tidak ditemukan" & vbCrLf & "Rumah Sakit/Klinik harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='JENISTINDAKLANJUT'", "tindaklanjut")
        lueTindakLanjut.Properties.DataSource = sqls.dataTable("tindaklanjut")
        lueTindakLanjut.Properties.DisplayMember = "content"
        lueTindakLanjut.Properties.ValueMember = "id"
        If sqls.getDataSet("tindaklanjut") = 0 Then
            dizMsgbox("Tindak Lanjut tidak ditemukan" & vbCrLf & "Tindak Lanjut harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='JENISPULANG'", "pulang")
        luePulangJenis.Properties.DataSource = sqls.dataTable("pulang")
        luePulangJenis.Properties.DisplayMember = "content"
        luePulangJenis.Properties.ValueMember = "id"
        If sqls.getDataSet("pulang") = 0 Then
            dizMsgbox("Jenis Pulang tidak ditemukan" & vbCrLf & "Jenis Pulang harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='TRANSPULANG'", "transpulang")
        luePulangTransportasi.Properties.DataSource = sqls.dataTable("transpulang")
        luePulangTransportasi.Properties.DisplayMember = "content"
        luePulangTransportasi.Properties.ValueMember = "id"
        If sqls.getDataSet("transpulang") = 0 Then
            dizMsgbox("Tranportasi Pulang tidak ditemukan" & vbCrLf & "Tranportasi Pulang harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='TURGOR'", "turgor")
        lueTurgor.Properties.DataSource = sqls.dataTable("turgor")
        lueTurgor.Properties.DisplayMember = "content"
        lueTurgor.Properties.ValueMember = "id"
        If sqls.getDataSet("turgor") = 0 Then
            dizMsgbox("Turgor tidak ditemukan" & vbCrLf & "Turgor harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='WARNAKULIT'", "warnakulit")
        lueWarnaKulit.Properties.DataSource = sqls.dataTable("warnakulit")
        lueWarnaKulit.Properties.DisplayMember = "content"
        lueWarnaKulit.Properties.ValueMember = "id"
        If sqls.getDataSet("warnakulit") = 0 Then
            dizMsgbox("Warna Kulit tidak ditemukan" & vbCrLf & "Warna Kulit harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='PERAWATMASALAH'", "perawatmasalah")
        lueMasalah.Properties.DataSource = sqls.dataTable("perawatmasalah")
        lueMasalah.Properties.DisplayMember = "content"
        lueMasalah.Properties.ValueMember = "id"
        If sqls.getDataSet("perawatmasalah") = 0 Then
            dizMsgbox("Masalah Perawat tidak ditemukan" & vbCrLf & "Masalah Perawat harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='INTERVENSIJATUH'", "intervensijatuh")
        clbcIntervensi.DataSource = sqls.dataTable("intervensijatuh")
        clbcIntervensi.DisplayMember = "content"
        clbcIntervensi.ValueMember = "id"
        If sqls.getDataSet("intervensijatuh") = 0 Then
            dizMsgbox("Intervensi Jatuh tidak ditemukan" & vbCrLf & "Intervensi Jatuh harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        sqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='KEBUTUHANEDUKASI'", "kebutuhanedukasi")
        clbcKebutuhanEdukasi.DataSource = sqls.dataTable("kebutuhanedukasi")
        clbcKebutuhanEdukasi.DisplayMember = "content"
        clbcKebutuhanEdukasi.ValueMember = "id"
        If sqls.getDataSet("kebutuhanedukasi") = 0 Then
            dizMsgbox("Kebutuhan Edukasi tidak ditemukan" & vbCrLf & "Kebutuhan Edukasi harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If
    End Sub

    Private iddas As String = "-1"
    Private iddso As String = "-1"

    Private idselect As String = "-1"

    Private jenistransselectso As String = ""
    Private idtransselectso As String = 0
    Private formatstringso As String = ""
    Private formatperiodeso As String = ""

    Private jenistransselectas As String = ""
    Private idtransselectas As String = 0
    Private formatstringas As String = ""
    Private formatperiodeas As String = ""

    Private iddeptselect As String = "-1"
    Private idunitselect As String = "-1"
    Private isFromLoad As Boolean = True

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If isFromLoad = True Then
            kosongkanIsian(tlpRegistrasi)
            kosongkanIsian(tlpPasien)
            kosongkanIsian(tlpAlamat)
            kosongkanIsian(tlpTandaVital1)
            kosongkanIsian(tlpTandaVital2)
            kosongkanIsian(tlpTandaVital3)
            kosongkanIsian(tlpTandaVital4)
            kosongkanIsian(tlpTandaVital5)
            kosongkanIsian(tlpTandaVital6)
            kosongkanIsian(tlpTandaVital7)
            kosongkanIsian(tlppSOAP)
            kosongkanIsian(tlppPenunjang)
            kosongkanIsian(tlpKebutuhanEdukasi1)
            kosongkanIsian(tlpPulangJenis)
            kosongkanIsian(tlpDipulangkan)
            kosongkanIsian(tlpPulangAPS)
            kosongkanIsian(tlpTransportasiPulang)
            kosongkanIsian(tlpMeninggal)
            kosongkanIsian(tlpAsesmen)

            If lueHamil.EditValue Is Nothing Then
                seGravida.ReadOnly = True
                sePara.ReadOnly = True
                seAbortus.ReadOnly = True
                deHPHT.ReadOnly = True

                seGravida.Value = 0
                sePara.Value = 0
                seAbortus.Value = 0
                deHPHT.EditValue = Nothing
            End If
            If lueKeyakinan.EditValue Is Nothing Then
                teKeyakinan.ReadOnly = True
                teKeyakinan.Text = "-"
            End If
            If lueKualitasNyeri.EditValue Is Nothing Then
                teKualitasNyeri.ReadOnly = True
                teKualitasNyeri.Text = "-"
            End If
            If lueMenjalar.EditValue Is Nothing Then
                seMenjalar.ReadOnly = True
                seMenjalar.Value = 0
            End If
            If luePenerjemah.EditValue Is Nothing Then
                luePenerjemahBahasa.ReadOnly = True
                luePenerjemahBahasa.EditValue = Nothing
            End If
            If lueTindakLanjut.EditValue Is Nothing Then
                xtcTindakLanjut.Visible = False
                xtcTindakLanjut.SelectedTabPage = Nothing
            End If
            If luePulangJenis.EditValue Is Nothing Then
                tlpDipulangkan.Visible = False
                tlpPulangAPS.Visible = False
                tlpTransportasiPulang.Visible = False
            End If
            If lueHambatanEdukasi.EditValue Is Nothing Then
                lueHambatanJenis.ReadOnly = True
                lueHambatanJenis.EditValue = Nothing
            End If
            If lueMenjalar.EditValue Is Nothing Then
                seMenjalar.ReadOnly = True
                seMenjalar.Value = 0
            End If

            teNoRegistrasi.Text = ""
            teNoRegistrasi.Tag = 0
            teNoRM.Tag = 0
            teNoRM.Text = 0
            teTanggalRegistrasi.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
            teTanggalAsesmen.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
            teTanggalSOAP.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
            teGolonganDarah.Tag = ""
            teJenisKelamin.Tag = ""
            teWarganegara.Tag = ""

            btnSearch.Enabled = True
            btnSimpanASESMEN.Enabled = True
            btnCetakASESMEN.Enabled = True
            statData = statusData.Baru

            iddeptselect = 0
            idunitselect = 0
            idselect = "-1"

            iddas = "-1"
            idtransselectas = 0
            jenistransselectas = ""
            formatstringas = ""
            formatperiodeas = ""

            iddso = "-1"
            idtransselectso = 0
            jenistransselectso = ""
            formatstringso = ""
            formatperiodeso = ""

            teNoAsesmen.Text = "ASP/IGD/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
            teNoSOAP.Text = "SOAPP/IGD/" & Format(nowTime, "yyyyMMdd") & "/XXXX"

            xtcMIE.SelectedTabPage = xtpMasalah
            tmrCek.Stop()
            tlpAsesmen.Enabled = False
            tlpSOAP.Enabled = False
            tlpKeperawatan.Enabled = False

            btnSearch.Enabled = True
            btnSimpanASESMEN.Enabled = False
            btnCetakASESMEN.Enabled = False
            btnSimpanSOAP.Enabled = False
            btnCetakSOAP.Enabled = False
        Else
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select r.idregistrasi,convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as 'Tgl Registrasi',r.registrasino as 'No Registrasi',pm.nama as 'Tenaga Medis',dbo.fformatnorm(rm.rekammedisno) as 'No RM',rm.nama as 'Nama Pasien',jk.generalcode as 'Jenis Kelamin',convert(varchar,rm.tanggallahir,105) as 'Tgl Lahir',dbo.fUmurRegister(rm.tanggallahir,r.registrasidate) as 'Umur',kw.wilayah as 'Kewarganegaraan' from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' left join wilayah kw on rm.kewarganegaraan=kw.idwilayah  left join paramedis pm on r.iddokterruangan=pm.idparamedis where r.registrasistatus=0 and rm.rekammedisno<>0 and r.iddepartment=(select top 1 [value] from sys_appsetting where variable='idigddept') order by r.registrasidate desc", "search")
            Dim cari As New frmSearch(sqls.dataSet, "search", "idregistrasi")
            tambahChild(cari)

            If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
                sqls = New SQLs(dbstring)
                sqls.DMLQuery("select isnull(dbo.fGetUsername(lockby),0) as username,isnull(dbo.fGetUsernama(lockby),'-') as nama,isnull(lockipaddress,'0.0.0.0') as lockipaddress from registrasi where datediff(second,lockdate,getdate())<=4 and idregistrasi='" & idselect & "'", "ceklock")
                If sqls.getDataSet("ceklock") > 0 Then
                    dizMsgbox("Sedang digunakan oleh" & vbCrLf &
                              sqls.getDataSet("ceklock", 0, "username") & " (" & sqls.getDataSet("ceklock", 0, "username") & ")" & vbCrLf &
                              "IP Address " & sqls.getDataSet("ceklock", 0, "lockipaddress"), dizMsgboxStyle.Info, Me)
                    Exit Sub
                End If

                iddas = "-1"
                iddso = "-1"
                teNoAsesmen.Tag = "-1"
                teNoSOAP.Tag = "-1"

                idselect = CStr(cari.GetIDSelectData)
                tmrCek.Start()

                sqls.DMLQuery("select r.asalpx,r.asalpx2,r.asalrujukan,r.iddokterrujukan,r.idrekammedis,r.iddepartment,r.idunit,r.registrasino,convert(varchar,r.registrasidate,105) + ' '+convert(varchar,r.registrasidate,108) as registrasidate,ha.generalcode as hamil from registrasi r left join sys_generalcode ha on r.ishamil=ha.idgeneral and ha.gctype='ISHAMIL' where r.idregistrasi='" & idselect & "'", "getidrm")
                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                field.AddRange(New String() {"@idrm"})
                value.AddRange(New Object() {sqls.getDataSet("getidrm", 0, "idrekammedis")})
                sqls.CallSP("spGetPasienRegistrasi", "registrasi", field, value)

                iddeptselect = sqls.getDataSet("getidrm", 0, "iddepartment")
                idunitselect = sqls.getDataSet("getidrm", 0, "idunit")

                sqls.DMLQuery("select idtransactiontype,jenistransaksi,formatstring,formatperiode from transactiontype where jenistransaksi like '%AssessmentP%' and iddepartment='" & iddeptselect & "' and idunit='" & idunitselect & "'", "getidtransas")
                If sqls.getDataSet("getidtransas") > 0 Then
                    idtransselectas = sqls.getDataSet("getidtransas", 0, "idtransactiontype")
                    jenistransselectas = sqls.getDataSet("getidtransas", 0, "jenistransaksi")
                    formatstringas = sqls.getDataSet("getidtransas", 0, "formatstring")
                    formatperiodeas = sqls.getDataSet("getidtransas", 0, "formatperiode")
                Else
                    idtransselectas = "0"
                    jenistransselectas = ""
                    formatstringas = ""
                    formatperiodeas = ""
                End If
                If idtransselectas <> "0" Then
                    teNoAsesmen.Text = formatstringas & Format(nowTime, formatperiodeas) & "/XXXX"
                Else
                    teNoAsesmen.Text = "ASP/IGD/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
                End If

                sqls.DMLQuery("select idtransactiontype,jenistransaksi,formatstring,formatperiode from transactiontype where jenistransaksi like '%SOAPP%' and iddepartment='" & iddeptselect & "' and idunit='" & idunitselect & "'", "getidtransso")
                If sqls.getDataSet("getidtransso") > 0 Then
                    idtransselectso = sqls.getDataSet("getidtransso", 0, "idtransactiontype")
                    jenistransselectso = sqls.getDataSet("getidtransso", 0, "jenistransaksi")
                    formatstringso = sqls.getDataSet("getidtransso", 0, "formatstring")
                    formatperiodeso = sqls.getDataSet("getidtransso", 0, "formatperiode")
                Else
                    idtransselectso = "0"
                    jenistransselectso = ""
                    formatstringso = ""
                    formatperiodeso = ""
                End If
                If idtransselectso > 0 Then
                    teNoSOAP.Text = formatstringso & Format(nowTime, formatperiodeso) & " / XXXX"
                Else
                    teNoSOAP.Text = "SOAPP/IGD/" & Format(nowTime, "yyyyMMdd") & "/XXXX"
                End If

                teNoRegistrasi.Text = sqls.getDataSet("getidrm", 0, "registrasino")
                teNoRegistrasi.Tag = idselect
                teTanggalRegistrasi.Text = sqls.getDataSet("getidrm", 0, "registrasidate")
                teTanggalAsesmen.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")
                teTanggalSOAP.Text = Format(nowTime, "dd-MM-yyyy HH:mm:ss")

                teNoRM.Text = sqls.getDataSet("registrasi", 0, "rekammedisno")
                teJenisKartu.Text = sqls.getDataSet("registrasi", 0, "jeniskartu")
                teNomorKartu.Text = sqls.getDataSet("registrasi", 0, "nomorkartu")
                teHamil.Text = sqls.getDataSet("getidrm", 0, "hamil")
                teGolonganDarah.Text = sqls.getDataSet("registrasi", 0, "golongandarah")
                teRhesus.Text = sqls.getDataSet("registrasi", 0, "rhesus")

                teNoRM.Tag = sqls.getDataSet("registrasi", 0, "idrekammedis")
                teNamaPanggilan.Text = sqls.getDataSet("registrasi", 0, "namapanggilan")
                teNama.Text = sqls.getDataSet("registrasi", 0, "namapanggilan")
                teJenisKelamin.Text = sqls.getDataSet("registrasi", 0, "jeniskelamin")
                teJenisKelamin.Tag = sqls.getDataSet("registrasi", 0, "idjeniskelamin")

                teWarganegara.Text = sqls.getDataSet("registrasi", 0, "warganegara")
                teTanggalLahir.Text = sqls.getDataSet("registrasi", 0, "tanggallahir")
                teUmur.Text = sqls.getDataSet("registrasi", 0, "usia")

                'Assessment
                sqls.DMLQuery("select idassessment from assessment where idregistrasi='" & idselect & "' and transactiontype='" & idtransselectas & "' and isdeleted=0 order by idassessment desc", "getidass")
                If sqls.getDataSet("getidass") > 0 Then
                    iddas = sqls.getDataSet("getidass", 0, "idassessment")
                End If

                If iddas <> "-1" Then
                    sqls.DMLQuery("select assessmentno,skalatriage,tanggaldatang,tanggalkejadian,gcse,gcsv,gcsm,tdsis,tddias,denyutnadi,isnadi,suhu,isakral,iskesadaran,pupila,pupilb,isrefcahaya,nafas,oksigendarah,isgangguanperilaku,isperilakubahaya,isinformasi,familytype,namainformasi,iscaramasuk,ispengantar,namapengantar,ispenyebab,penyebab,gayahidup,asalpx,asalpx2,asalrujukan,iddokterrujukan from assessment where idassessment='" & iddas & "'", "getass")

                    teNoAsesmen.Tag = iddas
                    teNoAsesmen.Text = sqls.getDataSet("getass", 0, "assessmentno")
                    nudGCSE.Value = sqls.getDataSet("getass", 0, "gcse")
                    nudGCSV.Value = sqls.getDataSet("getass", 0, "gcsv")
                    nudGCSM.Value = sqls.getDataSet("getass", 0, "gcsm")
                    nudSistol.Value = sqls.getDataSet("getass", 0, "tdsis")
                    nudDiastol.Value = sqls.getDataSet("getass", 0, "tddias")
                    nudNadi.Value = sqls.getDataSet("getass", 0, "denyutnadi")
                    lueNadiJenis.EditValue = sqls.getDataSet("getass", 0, "isnadi")
                    nudSuhu.Value = sqls.getDataSet("getass", 0, "suhu")
                    lueKesadaran.EditValue = sqls.getDataSet("getass", 0, "iskesadaran")
                End If

                'SOAP
                sqls.DMLQuery("select idsoapnote from soapnote where idregistrasi='" & idselect & "' and transactiontype='" & idtransselectso & "' and isdeleted=0", "getidso")
                If sqls.getDataSet("getidso") > 0 Then
                    iddso = sqls.getDataSet("getidso", 0, "idsoapnote")
                End If

                If iddso <> "-1" Then
                    sqls.DMLQuery("select soapnoteno,convert(varchar,soapnotedate,105)+' '+convert(varchar,soapnotedate,108) as soapnotedate,subyektif,obyektif,asesmen,planning from soapnote where idsoapnote='" & iddso & "'", "getso")
                    teNoSOAP.Tag = iddso

                    Dim oTrim() As Char = {vbCr, vbLf}
                    Dim ases As String = sqls.getDataSet("getso", 0, "asesmen")
                    ases = ases.Replace("Diagnosa Kerja:", "`")
                    ases = ases.Replace("Diagnosa Banding:", "`")

                    teNoSOAP.Text = sqls.getDataSet("getso", 0, "soapnoteno")
                    meSubjektif.Text = sqls.getDataSet("getso", 0, "subyektif")
                    meObjektif.Text = sqls.getDataSet("getso", 0, "obyektif")

                    mePlanning.Text = sqls.getDataSet("getso", 0, "planning")
                End If

                xtcMIE.SelectedTabPage = xtpMasalah

                tlpAsesmen.Enabled = True
                tlpSOAP.Enabled = True
                tlpKeperawatan.Enabled = True

                btnSearch.Enabled = True
                btnSimpanASESMEN.Enabled = True
                btnCetakASESMEN.Enabled = True
                btnSimpanSOAP.Enabled = True
                btnCetakSOAP.Enabled = True
            End If
        End If
        isFromLoad = False
    End Sub

    Private ipadd As String
    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        tlpAsesmen.Dock = DockStyle.Top

        checkFieldMaxLength(dbstring, tlpTandaVital1, "assessment")
        checkFieldMaxLength(dbstring, tlpTandaVital2, "assessment")
        checkFieldMaxLength(dbstring, tlpTandaVital3, "assessment")
        checkFieldMaxLength(dbstring, tlppSOAP, "soapnote")
        checkFieldMaxLength(dbstring, tlppPenunjang, "pemeriksaanpenunjang")
        tmrCek.Stop()
        ipadd = getIPAddress(ipaddparam.IP)

        loadLOV()
        btnSearch_Click(Me, Nothing)
    End Sub

    Private Sub seTB_EditValueChanged(sender As Object, e As EventArgs) Handles seTB.EditValueChanged, seBB.EditValueChanged
        If seTB.Value <= 0 Then
            seIMT.Value = 0
            Exit Sub
        End If
        If seBB.Value <= 0 Then
            seIMT.Value = 0
            Exit Sub
        End If
        If seTB.Value > 0 And seBB.Value > 0 Then
            seIMT.Value = seBB.Value / ((seTB.Value / 100) ^ 2)
        End If
    End Sub

    Private Sub seIMT_EditValueChanged(sender As Object, e As EventArgs) Handles seIMT.EditValueChanged
        If seIMT.Value = 0 Then
            teStatusGizi.Text = "-"
            Exit Sub
        End If
        If seIMT.Value < 18.5 Then
            teStatusGizi.Text = "Underweight"
        ElseIf seIMT.Value >= 18.5 And seIMT.Value <= 22.9 Then
            teStatusGizi.Text = "Normal"
        ElseIf seIMT.Value >= 23.0 And seIMT.Value <= 24.9 Then
            teStatusGizi.Text = "Overweight"
        ElseIf seIMT.Value >= 25.0 Then
            teStatusGizi.Text = "Obesity"
        End If
    End Sub

    Private Sub lueHamil_EditValueChanged(sender As Object, e As EventArgs) Handles lueHamil.EditValueChanged
        If lueHamil.EditValue Is Nothing Then
            seGravida.ReadOnly = True
            sePara.ReadOnly = True
            seAbortus.ReadOnly = True
            deHPHT.ReadOnly = True

            seGravida.Value = 0
            sePara.Value = 0
            seAbortus.Value = 0
            deHPHT.EditValue = Nothing
            Exit Sub
        End If
        If lueHamil.EditValue = 0 Then
            seGravida.ReadOnly = True
            sePara.ReadOnly = True
            seAbortus.ReadOnly = True
            deHPHT.ReadOnly = True

            seGravida.Value = 0
            sePara.Value = 0
            seAbortus.Value = 0
            deHPHT.EditValue = Nothing
        Else
            seGravida.ReadOnly = False
            sePara.ReadOnly = False
            seAbortus.ReadOnly = False
            deHPHT.ReadOnly = False

            seGravida.Value = 0
            sePara.Value = 0
            seAbortus.Value = 0
            deHPHT.EditValue = Nothing
        End If
    End Sub

    Private Sub lueKeyakinan_EditValueChanged(sender As Object, e As EventArgs) Handles lueKeyakinan.EditValueChanged
        If lueKeyakinan.EditValue Is Nothing Then
            teKeyakinan.ReadOnly = True
            teKeyakinan.Text = "-"
            Exit Sub
        End If
        If lueKeyakinan.EditValue = 0 Then
            teKeyakinan.ReadOnly = True
            teKeyakinan.Text = "-"
        Else
            teKeyakinan.ReadOnly = False
            teKeyakinan.Text = ""
        End If
    End Sub

    Private Sub teSkalaNyeri_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teSkalaNyeri.KeyPress
        If teSkalaNyeri.Text.Length = 0 Or teSkalaNyeri.Text.Length = 2 Then
            If teSkalaNyeri.Text <> "10" Then
                If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, "[0-9]") = False And (Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13) Then
                    e.Handled = True
                End If
            Else
                If (Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13) Then
                    e.Handled = True
                End If
            End If
        ElseIf teSkalaNyeri.Text.Length = 3 Then
            If teSkalaNyeri.Text = "1-1" Then
                If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, "[0]") = False And (Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13) Then
                    e.Handled = True
                End If
            End If
        ElseIf teSkalaNyeri.Text.Length = 1 Then
            If teSkalaNyeri.Text = "1" Then
                If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, "[0-]") = False And (Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13) Then
                    e.Handled = True
                End If
            Else
                If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, "[-]") = False And (Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 13) Then
                    e.Handled = True
                End If
            End If
        ElseIf teSkalaNyeri.Text.Length > 3 Then
            If Asc(e.KeyChar) <> 8 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub lueKualitasNyeri_EditValueChanged(sender As Object, e As EventArgs) Handles lueKualitasNyeri.EditValueChanged
        If lueKualitasNyeri.EditValue Is Nothing Then
            teKualitasNyeri.ReadOnly = True
            teKualitasNyeri.Text = "-"
            Exit Sub
        End If
        If lueKualitasNyeri.EditValue <> 1 Then
            teKualitasNyeri.ReadOnly = True
            teKualitasNyeri.Text = "-"
        Else
            teKualitasNyeri.ReadOnly = False
            teKualitasNyeri.Text = ""
        End If
    End Sub

    Private Sub lueMenjalar_EditValueChanged(sender As Object, e As EventArgs) Handles lueMenjalar.EditValueChanged
        If lueMenjalar.EditValue Is Nothing Then
            seMenjalar.ReadOnly = True
            seMenjalar.Value = 0
            Exit Sub
        End If
        If lueMenjalar.EditValue = 0 Then
            seMenjalar.ReadOnly = True
            seMenjalar.Value = 0
        Else
            seMenjalar.ReadOnly = False
            seMenjalar.Value = 0
        End If
    End Sub

    Private Sub luePenerjemah_EditValueChanged(sender As Object, e As EventArgs) Handles luePenerjemah.EditValueChanged
        If luePenerjemah.EditValue Is Nothing Then
            luePenerjemahBahasa.ReadOnly = True
            luePenerjemahBahasa.EditValue = Nothing
            Exit Sub
        End If
        If luePenerjemah.EditValue = 0 Then
            luePenerjemahBahasa.ReadOnly = True
            luePenerjemahBahasa.EditValue = Nothing
        Else
            luePenerjemahBahasa.ReadOnly = False
            luePenerjemahBahasa.EditValue = Nothing
        End If
    End Sub

    Private Sub lueTindakLanjut_EditValueChanged(sender As Object, e As EventArgs) Handles lueTindakLanjut.EditValueChanged
        If lueTindakLanjut.EditValue Is Nothing Then
            xtcTindakLanjut.Visible = False
            xtcTindakLanjut.SelectedTabPage = Nothing
            Exit Sub
        End If
        If lueTindakLanjut.EditValue = 1 Then
            xtcTindakLanjut.Visible = True
            xtcTindakLanjut.SelectedTabPage = xtpMRS
            xtpMRS.Focus()
        ElseIf lueTindakLanjut.EditValue = 2 Then
            xtcTindakLanjut.Visible = True
            xtcTindakLanjut.SelectedTabPage = xtpRujuk
            xtpRujuk.Focus()
        ElseIf lueTindakLanjut.EditValue = 3 Then
            xtcTindakLanjut.Visible = True
            xtcTindakLanjut.SelectedTabPage = xtpPulang
            xtpPulang.Focus()
        ElseIf lueTindakLanjut.EditValue = 4 Then
            xtcTindakLanjut.Visible = True
            xtcTindakLanjut.SelectedTabPage = xtpMeninggal
            xtpMeninggal.Focus()
        End If
    End Sub

    Private Sub lueHambatanEdukasi_EditValueChanged(sender As Object, e As EventArgs) Handles lueHambatanEdukasi.EditValueChanged
        If lueHambatanEdukasi.EditValue Is Nothing Then
            lueHambatanJenis.ReadOnly = True
            lueHambatanJenis.EditValue = Nothing
            Exit Sub
        End If
        If lueHambatanEdukasi.EditValue = 0 Then
            lueHambatanJenis.ReadOnly = True
            lueHambatanJenis.EditValue = Nothing
        Else
            lueHambatanJenis.ReadOnly = False
            lueHambatanJenis.EditValue = Nothing
        End If
    End Sub

    Private Sub xtcTindakLanjut_SelectedPageChanged(sender As Object, e As TabPageChangedEventArgs) Handles xtcTindakLanjut.SelectedPageChanged
        For i As Integer = 0 To xtcTindakLanjut.TabPages.Count - 1
            Try
                If xtcTindakLanjut.SelectedTabPage.Equals(xtcTindakLanjut.TabPages.Item(i)) = False Then
                    For Each a As Object In xtcTindakLanjut.TabPages.Item(i).Controls
                        Try
                            If a.ToString = "System.Windows.Forms.TextBox" Then
                                CType(a, Windows.Forms.TextBox).Text = ""
                            ElseIf a.ToString = "System.Windows.Forms.ComboBox" Then
                                Try
                                    CType(a, Windows.Forms.ComboBox).SelectedValue = Nothing
                                Catch ex As Exception
                                End Try
                            ElseIf a.ToString = "System.Windows.Forms.NumericUpDown" Then
                                CType(a, Windows.Forms.NumericUpDown).Value = CType(a, Windows.Forms.NumericUpDown).Minimum
                            ElseIf a.ToString = "System.Windows.Forms.DateTimePicker" Then
                                CType(a, Windows.Forms.DateTimePicker).Value = CType(a, Windows.Forms.DateTimePicker).MinDate
                            ElseIf a.ToString = "System.Windows.Forms.CheckBox" Then
                                CType(a, Windows.Forms.CheckBox).Checked = False
                            ElseIf a.ToString = "DevExpress.XtraEditors.DateEdit" Then
                                CType(a, DevExpress.XtraEditors.DateEdit).EditValue = Now
                            ElseIf a.ToString = "DevExpress.XtraEditors.TextEdit" Then
                                CType(a, DevExpress.XtraEditors.TextEdit).EditValue = Nothing
                            ElseIf a.ToString = "DevExpress.XtraEditors.MemoEdit" Then
                                CType(a, DevExpress.XtraEditors.MemoEdit).EditValue = Nothing
                            ElseIf a.ToString = "DevExpress.XtraEditors.LookUpEdit" Then
                                CType(a, DevExpress.XtraEditors.LookUpEdit).EditValue = Nothing
                            ElseIf a.ToString = "DevExpress.XtraEditors.SpinEdit" Then
                                CType(a, DevExpress.XtraEditors.SpinEdit).Value = CType(a, DevExpress.XtraEditors.SpinEdit).Properties.MinValue
                            ElseIf a.ToString = "DevExpress.XtraEditors.CheckEdit" Then
                                CType(a, DevExpress.XtraEditors.CheckEdit).EditValue = False
                            ElseIf a.ToString = "DevExpress.XtraEditors.ToggleSwitch" Then
                                CType(a, DevExpress.XtraEditors.ToggleSwitch).IsOn = False
                            ElseIf a.ToString = "DevExpress.XtraEditors.TimeEdit" Then
                                CType(a, DevExpress.XtraEditors.TimeEdit).EditValue = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
                            ElseIf a.ToString = "DevExpress.XtraEditors.CheckedComboBoxEdit" Then
                                For b As Integer = 0 To CType(a, DevExpress.XtraEditors.CheckedComboBoxEdit).Properties.Items.Count - 1
                                    CType(a, DevExpress.XtraEditors.CheckedComboBoxEdit).Properties.Items.Item(b).CheckState = CheckState.Unchecked
                                Next
                            End If
                            CType(a, Control).Enabled = False
                        Catch ex As Exception
                            'MsgBox(a.name & vbCrLf & ex.Message)
                        End Try
                    Next
                Else
                    For Each a As Object In xtcTindakLanjut.TabPages.Item(i).Controls
                        Try
                            CType(a, Control).Enabled = True
                        Catch ex As Exception
                            'MsgBox(a.name & vbCrLf & ex.Message)
                        End Try
                    Next
                End If
            Catch ex As Exception
                'MsgBox(a.name & vbCrLf & ex.Message)
            End Try
        Next
    End Sub
    Private Sub loadMasalah()
        Dim sqls As New SQLs(dbstring)
        If idselect = "-1" Then
            sqls.DMLQuery("select idperawatmasalah,isdeleted,remarks from perawatmasalah where 1=0", "masalah")
        Else
            sqls.DMLQuery("select idperawatmasalah,isdeleted,remarks from perawatmasalah where masalahtype=1 and isdeleted=0 and idregistrasi='" & idselect & "'", "masalah")
        End If
        gcMasalah.DataSource = sqls.dataTable("masalah")
        gvMasalah.BestFitColumns()
        lueMasalah.EditValue = Nothing
    End Sub

    Private Sub btnMasalahSimpan_Click(sender As Object, e As EventArgs) Handles btnMasalahSimpan.Click
        If idselect = "-1" Then
            dizMsgbox("Registrasi belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If lueMasalah.EditValue Is Nothing Then
            dizMsgbox("Masalah Keperawatan belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        Dim idtmp As String = GenerateGUID()
        Dim cek As Boolean = False
        Dim sqlset As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idperawatmasalah", "idregistrasi", "masalahtype", "remarks", "createdby", "createddate"})
        value.AddRange(New Object() {idtmp, idselect, 1, lueMasalah.Text, userid, nowTime})
        sqlset.datasetSave("perawatmasalah", idtmp, field, value, False)
        If cek = True Then
            dizMsgbox("Masalah Keperawatan telah tersimpan", dizMsgboxStyle.Info, Me)
            loadMasalah()
        End If
    End Sub

    Private Sub btnMasalahHapus_Click(sender As Object, e As EventArgs) Handles btnMasalahHapus.Click
        If idselect = "-1" Then
            dizMsgbox("Registrasi belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If gvMasalah.FocusedRowHandle < 0 Then
            dizMsgbox("Masalah Keperawatan belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        Dim idx As Long = gvMasalah.GetFocusedDataRow("idperawatmasalah")
        Dim cek As Boolean = False
        Dim sqlset As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idperawatmasalah", "idregistrasi", "isdeleted", "updatedby", "updateddate"})
        value.AddRange(New Object() {idx, idselect, 1, userid, nowTime})
        sqlset.datasetSave("perawatmasalah", idx, field, value, False)
        If cek = True Then
            dizMsgbox("Masalah Keperawatan telah dihapus", dizMsgboxStyle.Info, Me)
            loadMasalah()
        End If
    End Sub

    Private Sub loadImplementasi()
        Dim sqls As New SQLs(dbstring)
        If idselect = "-1" Then
            sqls.DMLQuery("select idperawatmasalah,isdeleted,remarks from perawatmasalah where 1=0", "implementasi")
        Else
            sqls.DMLQuery("select idperawatmasalah,isdeleted,remarks from perawatmasalah where masalahtype=2 and isdeleted=0 and idregistrasi='" & idselect & "'", "implementasi")
        End If
        gcImplementasi.DataSource = sqls.dataTable("implementasi")
        gvImplementasi.BestFitColumns()
        teImplementasi.Text = ""
    End Sub

    Private Sub btnImplementasiSimpan_Click(sender As Object, e As EventArgs) Handles btnImplementasiSimpan.Click
        If idselect = "-1" Then
            dizMsgbox("Registrasi belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If teImplementasi.Text.Replace(" ", "") = "" Then
            dizMsgbox("Implementasi Keperawatan belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        Dim idtmp As String = GenerateGUID()
        Dim cek As Boolean = False
        Dim sqlset As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idperawatmasalah", "idregistrasi", "masalahtype", "remarks", "createdby", "createddate"})
        value.AddRange(New Object() {idtmp, idselect, 2, lueMasalah.Text, userid, nowTime})
        sqlset.datasetSave("perawatmasalah", idtmp, field, value, False)
        If cek = True Then
            dizMsgbox("Implementasi Keperawatan telah tersimpan", dizMsgboxStyle.Info, Me)
            loadMasalah()
        End If
    End Sub

    Private Sub btnImplementasiHapus_Click(sender As Object, e As EventArgs) Handles btnImplementasiHapus.Click
        If idselect = "-1" Then
            dizMsgbox("Registrasi belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If gvImplementasi.FocusedRowHandle < 0 Then
            dizMsgbox("Implementasi Keperawatan belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        Dim idx As Long = gvMasalah.GetFocusedDataRow("idperawatmasalah")
        Dim cek As Boolean = False
        Dim sqlset As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idperawatmasalah", "idregistrasi", "isdeleted", "updatedby", "updateddate"})
        value.AddRange(New Object() {idx, idselect, 1, userid, nowTime})
        sqlset.datasetSave("perawatmasalah", idx, field, value, False)
        If cek = True Then
            dizMsgbox("Implementasi Keperawatan telah dihapus", dizMsgboxStyle.Info, Me)
            loadMasalah()
        End If
    End Sub

    Private Sub loadEvaluasi()
        Dim sqls As New SQLs(dbstring)
        If idselect = "-1" Then
            sqls.DMLQuery("select idperawatmasalah,isdeleted,remarks from perawatmasalah where 1=0", "evaluasi")
        Else
            sqls.DMLQuery("select idperawatmasalah,isdeleted,remarks from perawatmasalah where masalahtype=3 and isdeleted=0 and idregistrasi='" & idselect & "'", "evaluasi")
        End If
        gcEvaluasi.DataSource = sqls.dataTable("evaluasi")
        gvEvaluasi.BestFitColumns()
    End Sub

    Private Sub btnEvaluasiSimpan_Click(sender As Object, e As EventArgs) Handles btnEvaluasiSimpan.Click
        If idselect = "-1" Then
            dizMsgbox("Registrasi belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If teEvaluasi.Text.Replace(" ", "") = "" Then
            dizMsgbox("Evaluasi Keperawatan belum diisi", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        Dim idtmp As String = GenerateGUID()
        Dim cek As Boolean = False
        Dim sqlset As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idperawatmasalah", "idregistrasi", "masalahtype", "remarks", "createdby", "createddate"})
        value.AddRange(New Object() {idtmp, idselect, 3, lueMasalah.Text, userid, nowTime})
        sqlset.datasetSave("perawatmasalah", idtmp, field, value, False)
        If cek = True Then
            dizMsgbox("Evaluasi Keperawatan telah tersimpan", dizMsgboxStyle.Info, Me)
            loadEvaluasi()
        End If
    End Sub

    Private Sub btnEvaluasiHapus_Click(sender As Object, e As EventArgs) Handles btnEvaluasiHapus.Click
        If idselect = "-1" Then
            dizMsgbox("Registrasi belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If gvEvaluasi.FocusedRowHandle < 0 Then
            dizMsgbox("Evaluasi Keperawatan belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        Dim idx As Long = gvMasalah.GetFocusedDataRow("idperawatmasalah")
        Dim cek As Boolean = False
        Dim sqlset As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idperawatmasalah", "idregistrasi", "isdeleted", "updatedby", "updateddate"})
        value.AddRange(New Object() {idx, idselect, 1, userid, nowTime})
        sqlset.datasetSave("perawatmasalah", idx, field, value, False)
        If cek = True Then
            dizMsgbox("Evaluasi Keperawatan telah dihapus", dizMsgboxStyle.Info, Me)
            loadMasalah()
        End If
    End Sub

    Private Function generateNO(jenisregistrasi As String, ByVal prefix As String, formatperiode As String, Optional wildchar As String = "") As String
        Dim retval As String = ""
        Dim mysqls As New SQLs(dbstring)
        Dim tblname As String = jenisregistrasi & Format(nowTime, "yyyyMMdd")
        mysqls.DMLQuery("select idgeneratenumber,tablename,formatstring,lastnumber,positionnumber,digitnumber from sys_generatenumber where tablename='" & tblname & "'", "GetLast")
        Dim idgen As Integer = -1
        Dim formatStr As String = ""
        Dim currid As Integer = 0
        Dim currStrId As String = ""
        Dim posnumber As String = ""
        Dim lenStr As String = ""
        Dim lenId As Integer = 0

        If mysqls.getDataSet("GetLast") = 0 Then
            formatStr = prefix & Format(nowTime, formatperiode) & "/"
            currid = 1
            posnumber = "Belakang"
            lenId = 4
        Else
            idgen = mysqls.getDataSet("GetLast", 0, "idgeneratenumber")

            formatStr = mysqls.getDataSet("GetLast", 0, "formatstring")
            currid = CInt(mysqls.getDataSet("GetLast", 0, "lastnumber")) + 1
            posnumber = mysqls.getDataSet("GetLast", 0, "positionnumber")
            lenId = CInt(mysqls.getDataSet("GetLast", 0, "digitnumber"))
        End If
        Dim strwildchar As String = wildchar.Substring(0)
        If wildchar = "" Then
            For i As Integer = 0 To lenId - 1
                If i = 0 Then
                    lenStr = "0"
                Else
                    lenStr &= "#"
                End If
            Next
            currStrId = Format(currid, lenStr)
        Else
            For i As Integer = 0 To lenId - 1
                lenStr &= strwildchar
            Next
            currStrId = lenStr
        End If

        If posnumber = "Belakang" Then
            retval = formatStr & currStrId
        ElseIf posnumber = "Depan" Then
            retval = currStrId & formatStr
        End If

        Dim dtsave As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idgeneratenumber", "tablename", "formatstring", "lastnumber", "positionnumber", "digitnumber"})
        value.AddRange(New String() {idgen, tblname, formatStr, currid, posnumber, lenId})
        dtsave.datasetSave("sys_generatenumber", idgen, field, value, False)

        Return retval
    End Function

    Private Sub btnSimpanASESMEN_Click(sender As Object, e As EventArgs) Handles btnSimpanASESMEN.Click
        prosesSimpan()
    End Sub

    Private Function prosesSimpan() As Boolean
        Dim cek As Boolean = True
        If checkEntry() = False Then
            dizMsgbox("Isian belum benar", dizMsgboxStyle.Peringatan, Me)
            cek = False
        End If
        If clbcIntervensi.CheckedItemsCount = 0 Then
            dizMsgbox("Intervensi belum dipilih", dizMsgboxStyle.Peringatan, Me)
            cek = False
        End If
        If clbcKebutuhanEdukasi.CheckedItemsCount = 0 Then
            dizMsgbox("Kebutuhan Edukasi belum dipilih", dizMsgboxStyle.Peringatan, Me)
            cek = False
        End If
        If cek = True Then
            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            Dim dtsqls As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            If iddas <> "-1" Then
                field.AddRange(New String() {"idassessment", "isdeleted", "updatedby", "updateddate"})
                value.AddRange(New Object() {iddas, 1, userid, nowTime})
                dtsqls.datasetSave("assessment", iddas, field, value, False)
            End If

            If teNoAsesmen.Tag = "-1" Then
                teNoAsesmen.Text = generateNO(jenistransselectas, formatstringas, formatperiodeas)
            End If

            Dim dtsqls1 As New dtsetSQLS(dbstring)
            Dim field1 As New List(Of String)
            Dim value1 As New List(Of Object)

            field1.AddRange(New String() {"idassessment", "idregistrasi", "transactiontype", "assessmentno", "skalatriage", "tanggaldatang", "tanggalkejadian", "gcse", "gcsv", "gcsm", "iskesadaran", "pupila", "pupilb", "isrefcahaya", "tdsis", "tddias", "denyutnadi", "isnadi", "suhu", "nafas", "oksigendarah", "isakral", "isgangguanperilaku", "isperilakubahaya", "isinformasi", "familytype", "namainformasi", "iscaramasuk", "ispengantar", "namapengantar", "ispenyebab", "penyebab", "gayahidup", "asalpx", "asalpx2", "asalrujukan", "iddokterrujukan", "isdeleted", "createdby", "idcompany", "nomorform"})

            'value1.AddRange(New Object() {teNoAsesmen.Tag, idselect, idtransselectas, teNoAsesmen.Text, lueSkalaTriage.EditValue, CDate(deDatang.EditValue), CDate(deKejadian.EditValue), nudGCSE.EditValue, nudGCSV.EditValue, nudGCSM.EditValue, lueKesadaran.EditValue, nudPupil1.EditValue, nudPupil2.EditValue, lueRefleks.EditValue, nudSistol.EditValue, nudDiastol.EditValue, nudNadi.EditValue, lueNadiJenis.EditValue, nudSuhu.EditValue, nudNafas.EditValue, nudSpO2.EditValue, lueAkral.EditValue, lueGangguan.EditValue, If(lueMembahayakan.EditValue, 0), lueSumberInfo.EditValue, lueHubungan.EditValue, teHubungan.Text, lueCaraMasuk.EditValue, luePengantar.EditValue, tePengantar.Text, luePenyebab.EditValue, tePenyebab.Text, lueGayaHidup.EditValue, If(lueAsalPx.EditValue, 0), If(lueAsalPx2.EditValue, 0), If(lueAsalPx3.EditValue, 0), If(lueAsalPx4.EditValue, 0), 0, userid,  idcomp, "AMIGD201801"})

            'cek = dtsqls1.datasetSave("assessment", teNoAsesmen.Tag, field1, value1, False)
            'Dim sqls As New SQLs(dbstring)
            'sqls.DMLQuery("select idassessment from assessment where guid='" & strguid & "'", "getidas")
            'iddas = cstr(sqls.getDataSet("getidas", 0, "idassessment"))
        End If

        If cek = True Then
            dizMsgbox("Asesmen telah tersimpan", dizMsgboxStyle.Info, Me)
        End If
        Return cek
    End Function

    Private Function checkEntry() As Boolean
        Dim retval As Boolean = True

        retval = modCore.checkEntry(tlpAsesmen)
        retval = modCore.checkEntry(tlpTandaVital1)
        retval = modCore.checkEntry(tlpTandaVital2)
        retval = modCore.checkEntry(tlpTandaVital3)
        retval = modCore.checkEntry(tlpTandaVital4)
        retval = modCore.checkEntry(tlpTandaVital5)
        retval = modCore.checkEntry(tlpTandaVital6)
        retval = modCore.checkEntry(tlpTandaVital7)
        retval = modCore.checkEntry(tlpKebutuhanEdukasi1)
        retval = modCore.checkEntry(tlpKebutuhanEdukasi2)
        retval = modCore.checkEntry(tlpTindakLanjut)

        If idselect = "-1" Then retval = False
        Return retval
    End Function

    Private Sub luePulangJenis_EditValueChanged(sender As Object, e As EventArgs) Handles luePulangJenis.EditValueChanged
        If luePulangJenis.EditValue Is Nothing Then
            tlpDipulangkan.Visible = False
            tlpPulangAPS.Visible = False
            tlpTransportasiPulang.Visible = False
            Exit Sub
        End If
        If luePulangJenis.EditValue = 1 Then
            tlpDipulangkan.Visible = True
            tlpPulangAPS.Visible = False
            tlpTransportasiPulang.Visible = False
        ElseIf luePulangJenis.EditValue = 2 Then
            tlpDipulangkan.Visible = False
            tlpPulangAPS.Visible = True
            tlpTransportasiPulang.Visible = False
        ElseIf luePulangJenis.EditValue = 3 Then
            tlpDipulangkan.Visible = False
            tlpPulangAPS.Visible = False
            tlpTransportasiPulang.Visible = True
        End If
        If tlpDipulangkan.Visible = False Then
            kosongkanIsian(tlpDipulangkan)
        End If
        If tlpPulangAPS.Visible = False Then
            kosongkanIsian(tlpPulangAPS)
        End If
        If tlpTransportasiPulang.Visible = False Then
            kosongkanIsian(tlpTransportasiPulang)
        End If
    End Sub

End Class