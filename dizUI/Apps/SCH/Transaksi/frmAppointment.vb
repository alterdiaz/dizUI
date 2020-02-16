Imports DevExpress.Utils

Public Class frmAppointment
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
        lueSpesialis.Properties.DataSource = Nothing
        lueSpesialis.Properties.DisplayMember = "content"
        lueSpesialis.Properties.ValueMember = "id"
        lueSpesialis.EditValue = Nothing
    End Sub

    Private Sub loadParamedis()
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select distinct p.idparamedis as id,p.nama as content from paramedisjadwal pj inner join paramedisspesialis ps on pj.idparamedisspesialis=ps.idparamedisspesialis and ps.idspesialis not in (select [value] from sys_appsetting where variable in ('IDSPPK','IDSPRad')) left join paramedis p on p.idparamedis=ps.idparamedis order by p.nama asc", "paramedisschedule")
        lueParamedis.Properties.DataSource = mysqls.dataTable("paramedisschedule")
        lueParamedis.Properties.DisplayMember = "content"
        lueParamedis.Properties.ValueMember = "id"
        lueParamedis.EditValue = Nothing
    End Sub

    Private Sub loadPasien()
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select r.idrekammedis as id,dbo.fFormatNoRM(r.rekammedisno) as 'rekammedisno',r.nama,convert(varchar,r.tanggallahir,105) as tanggallahir from rekammedis r where r.isdeleted=0 and r.rekammedisno<>0 order by r.rekammedisno asc", "pasiennama")

        slueLamaNama.Properties.DataSource = mysqls.dataTable("pasiennama")
        slueLamaNama.Properties.DisplayMember = "nama"
        slueLamaNama.Properties.ValueMember = "id"
        slueLamaNama.EditValue = Nothing
        slueLamaNama.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

        lueLamaNoRM.Properties.DataSource = mysqls.dataTable("pasiennama")
        lueLamaNoRM.Properties.DisplayMember = "rekammedisno"
        lueLamaNoRM.Properties.ValueMember = "id"
        lueLamaNoRM.EditValue = Nothing

        mysqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='SEXTYPE'", "sex")
        lueBaruJenisKelamin.Properties.DataSource = mysqls.dataTable("sex")
        lueBaruJenisKelamin.Properties.DisplayMember = "content"
        lueBaruJenisKelamin.Properties.ValueMember = "id"
        lueBaruJenisKelamin.EditValue = Nothing
        If mysqls.getDataSet("sex") = 0 Then
            dizMsgbox("Jenis Kelamin tidak ditemukan" & vbCrLf & "Jenis Kelamin harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='APPVIA' and idreff=0 order by generalcode asc", "appvia")
        lueBaruAppVia.Properties.DataSource = mysqls.dataTable("appvia")
        lueBaruAppVia.Properties.DisplayMember = "content"
        lueBaruAppVia.Properties.ValueMember = "id"
        lueBaruAppVia.EditValue = CLng(0)
        If mysqls.getDataSet("appvia") = 0 Then
            dizMsgbox("Appointment Via tidak ditemukan" & vbCrLf & "Appointment Via harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='APPVIA' and idreff=0 order by generalcode asc", "appvial")
        lueLamaAppVia.Properties.DataSource = mysqls.dataTable("appvial")
        lueLamaAppVia.Properties.DisplayMember = "content"
        lueLamaAppVia.Properties.ValueMember = "id"
        lueLamaAppVia.EditValue = CLng(0)
        If mysqls.getDataSet("appvial") = 0 Then
            dizMsgbox("Appointment Via tidak ditemukan" & vbCrLf & "Appointment Via harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id, generalcode as content from sys_generalcode where gctype='APPTYPE' order by generalcode asc", "apptype")
        lueLamaAppType.Properties.DataSource = mysqls.dataTable("apptype")
        lueLamaAppType.Properties.DisplayMember = "content"
        lueLamaAppType.Properties.ValueMember = "id"
        lueLamaAppType.EditValue = CLng(0)
        If mysqls.getDataSet("apptype") = 0 Then
            dizMsgbox("Appointment Type tidak ditemukan" & vbCrLf & "Appointment Type harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If
    End Sub

    Private lenParamedis As Integer = 400
    Private Sub frmAppointment_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        loadParamedis()
        loadPasien()
        loadLOV()
        loadButton()

        gcDataPasien.Visible = True
        btnShowHidePasien.Tag = 2
        btnShowHidePasien.Text = "<< PASIEN DATA"
        btnShowHideParamedis.Tag = 2
        btnShowHideParamedis.Text = "<< PARAMEDIS DATA"
        'btnNew_Click(Me, Nothing)
        lenParamedis = tlpAppointment.ColumnStyles.Item(0).Width
    End Sub

    Private Sub loadButton()
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        tlpTanggal.Visible = False
        Dim counter As Integer = 0
        Me.tlpTanggal.RowCount = 0
        Me.tlpTanggal.RowStyles.Clear()
        Me.tlpTanggal.Controls.Clear()
        Me.tlpTanggal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))

        For i As Integer = 0 To 180 - 1
            tlpTanggal.SuspendLayout()

            Dim btnObj As New btnSchedule()
            btnObj.Name = "btnTanggal" & i
            btnObj.labelTanggal = nowTime.AddDays(i)
            btnObj.Dock = DockStyle.None
            btnObj.Anchor = AnchorStyles.None
            AddHandler btnObj.Button1.Click, AddressOf buttonClick

            Me.tlpTanggal.RowCount = counter + 1
            Me.tlpTanggal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
            Me.tlpTanggal.Controls.Add(btnObj, 1, counter + 1)
            Me.tlpTanggal.Size = New System.Drawing.Size(385, (counter * 70) + 10)
            counter += 1

            tlpTanggal.ResumeLayout()
        Next

        Me.tlpTanggal.RowCount = counter
        Me.tlpTanggal.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.tlpTanggal.Size = New System.Drawing.Size(385, (counter * 70) + 10)
        tlpTanggal.Visible = True

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub lueParamedis_EditValueChanged(sender As Object, e As EventArgs) Handles lueParamedis.EditValueChanged
        If lueParamedis.EditValue Is Nothing Then
            lueSpesialis.Properties.DataSource = Nothing
            lueSpesialis.EditValue = Nothing
            teParamedisTelepon1.Text = "-"
            teParamedisTelepon2.Text = "-"
            lueJadwalSesi.Properties.DataSource = Nothing
            lueJadwalSesi.EditValue = Nothing

            showPanelInfo(InfoType.noinfo, "", "")
            Exit Sub
        End If

        Try
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select s.idspesialis as id,s.nama as content from spesialis s left join paramedisspesialis ps on s.idspesialis=ps.idspesialis where ps.idparamedis='" & lueParamedis.EditValue & "' order by s.nama asc", "paramedisspesialis2")

            lueSpesialis.Properties.DataSource = sqls.dataTable("paramedisspesialis2")
            lueSpesialis.Properties.DisplayMember = "content"
            lueSpesialis.Properties.ValueMember = "id"
            lueSpesialis.EditValue = Nothing

            If sqls.getDataSet("paramedisspesialis2") = 1 Then
                lueSpesialis.EditValue = sqls.getDataSet("paramedisspesialis2", 0, "id")
            End If

            sqls.DMLQuery("select top 2 case when phonetype=1 then isnull(phone + ' (' + extension +')','-') else isnull(phone,'-') end as phone from phone where tablereff='PARAMEDIS' and isdeleted=0 and isprimary=1 and idreff='" & lueParamedis.EditValue & "' order by idphone asc", "phone")
            If sqls.getDataSet("phone") > 0 Then
                teParamedisTelepon1.Text = sqls.getDataSet("phone", 0, "phone")
            Else
                teParamedisTelepon1.Text = "-"
            End If
            If sqls.getDataSet("phone") > 1 Then
                teParamedisTelepon2.Text = sqls.getDataSet("phone", 1, "phone")
            Else
                teParamedisTelepon2.Text = "-"
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            splashClosed = True
        End Try
    End Sub

    Private Sub lueSpesialis_EditValueChanged(sender As Object, e As EventArgs) Handles lueSpesialis.EditValueChanged
        If lueSpesialis.EditValue Is Nothing Then
            showPanelInfo(InfoType.noinfo, "", "")
            Exit Sub
        End If

        Try
            Dim loadScr As New frmLoading()
            splashClosed = False
            loadScr.Show(Me)
            loadScr.BringToFront()
            Application.DoEvents()
            Me.Cursor = Cursors.WaitCursor

            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select pj.tanggalmulai,pj.tanggalselesai,replace(pj.hari,' ','') hari from paramedisjadwal pj left join paramedisspesialis ps on pj.idparamedisspesialis=ps.idparamedisspesialis where (getdate() >= pj.tanggalmulai and getdate() <= pj.tanggalselesai) and ps.idparamedis='" & lueParamedis.EditValue & "' and ps.idspesialis='" & lueSpesialis.EditValue & "'", "hari")

            Dim hari As String = ""
            Dim tmphari As String = ""
            For i As Integer = 0 To mysqls.getDataSet("hari") - 1
                Dim tmpstr As String = mysqls.getDataSet("hari", i, "hari")
                If tmpstr.Chars(tmpstr.Length - 1) <> "," Then
                    tmpstr &= ","
                End If
                tmphari &= tmpstr
            Next
            For i As Integer = 0 To tmphari.Split(",").Length - 1
                If hari.Contains(tmphari.Split(",")(i)) = False Then
                    hari &= tmphari.Split(",")(i)
                End If
            Next

            lueJadwalSesi.Properties.DataSource = Nothing
            lueJadwalSesi.Properties.ValueMember = "id"
            lueJadwalSesi.Properties.DisplayMember = "content"
            lueJadwalSesi.EditValue = Nothing

            mysqls.DMLQuery("select top 1 convert(varchar,pj.tanggalselesai,105) as tanggalselesai from paramedisjadwal pj left join paramedisspesialis ps on pj.idparamedisspesialis=ps.idparamedisspesialis where (getdate() >= pj.tanggalmulai and getdate() <= pj.tanggalselesai) and ps.idparamedis='" & lueParamedis.EditValue & "' and ps.idspesialis='" & lueSpesialis.EditValue & "' order by pj.tanggalselesai desc", "tglmax")
            Dim strtglselesai As String = mysqls.getDataSet("tglmax", 0, "tanggalselesai")
            Dim tglselesai As Date = Strdate2Date(strtglselesai)

            Dim intdiff As Long = 0
            intdiff = DateDiff(DateInterval.Day, nowTime, tglselesai)
            If intdiff > 180 Then intdiff = 180

            Dim mys As New SQLs(dbstring)
            Dim counter As Integer = 0

            xtcTanggal.SelectedTabPage = xtpTanggalSlot
            lueJadwalSesi.EditValue = Nothing

            Me.Cursor = Cursors.Default
            splashClosed = True
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            splashClosed = True
        End Try
    End Sub

    Private btnDate As Object
    Private sizePanel As Size
    Private isButton As Boolean = False

    Private Sub buttonClick(ByVal sender As Object, ByVal e As System.EventArgs)
        If lueParamedis.EditValue Is Nothing Then
            showPanelInfo(InfoType.noinfo, "", "")
            Exit Sub
        End If
        If lueSpesialis.EditValue Is Nothing Then
            showPanelInfo(InfoType.noinfo, "", "")
            Exit Sub
        End If

        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        showPanelInfo(InfoType.noinfo, "", "")
        sizePanel = pnlSlot.Size
        For Each ctrl As Control In tlpTanggal.Controls
            For Each ctrl1 As Control In ctrl.Controls
                CType(ctrl1, Button).FlatAppearance.BorderColor = Color.FromArgb(246, 139, 31)
                CType(ctrl1, Button).Image = My.Resources.slot1
            Next
        Next
        CType(sender, Button).FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0)
        CType(sender, Button).Image = My.Resources.slotr

        btnDate = sender
        Dim strDate As String = sender.Tag
        Dim dateDate As Date = Strdate2Date(strDate)
        isButton = True
        dnKalender.EditValue = dateDate
        isButton = False

        lueJadwalSesi.Properties.DataSource = Nothing
        lueJadwalSesi.Properties.DisplayMember = "content"
        lueJadwalSesi.Properties.ValueMember = "id"
        lueJadwalSesi.EditValue = Nothing

        Dim mys As New SQLs(dbstring)
        mys.DMLQuery("select top 1 idvacation,kehadiran,remarks from vacation where convert(varchar,vacationdate,105)='" & strDate & "' and isdeleted=0 and kehadiran<>0 and idreff='" & lueParamedis.EditValue & "' and tablereff='PARAMEDIS' order by idvacation desc", "cekijin")
        If mys.getDataSet("cekijin") > 0 Then
            If mys.getDataSet("cekijin", 0, "kehadiran") = 1 Then
                showPanelInfo(InfoType.info, "Tidak Hadir - Sakit", mys.getDataSet("cekijin", 0, "remarks"))
            ElseIf mys.getDataSet("cekijin", 0, "kehadiran") = 2 Then
                showPanelInfo(InfoType.info, "Tidak Hadir - Ijin", mys.getDataSet("cekijin", 0, "remarks"))
            ElseIf mys.getDataSet("cekijin", 0, "kehadiran") = 3 Then
                showPanelInfo(InfoType.info, "Tidak Hadir Tanpa Keterangan", mys.getDataSet("cekijin", 0, "remarks"))
            End If
            Me.Cursor = Cursors.Default
            splashClosed = True
            Exit Sub
        End If

        mys.DMLQuery("select pj.idjadwalsesi as id,js.nama +' ('+ substring(convert(varchar,ISNULL(jp.jammulaipengganti,pj.jammulai),108),0,6) + ' - ' +substring(convert(varchar,ISNULL(jp.jamselesaipengganti,pj.jamselesai),108),0,6)+')' as content from paramedisjadwal pj left join paramedisspesialis ps on pj.idparamedisspesialis=ps.idparamedisspesialis left join jadwalsesi js on pj.idjadwalsesi=js.idjadwalsesi left join jadwalparamedis jp on ps.idparamedis=jp.idparamedis and convert(varchar,jp.jadwaltanggal,105)='" & Format(dateDate, "dd-MM-yyyy") & "' and jp.idjadwalsesi=pj.idjadwalsesi and jp.isdeleted=0 where (convert(date,'" & Format(dateDate, "yyyy-MM-dd") & "') >= pj.tanggalmulai and convert(date,'" & Format(dateDate, "yyyy-MM-dd") & "') <= pj.tanggalselesai) and pj.hari like '%" & dateDate.DayOfWeek & "%' and ps.idparamedis='" & lueParamedis.EditValue & "' and ps.idspesialis='" & lueSpesialis.EditValue & "'", "jadwalsesi")
        lueJadwalSesi.Properties.DataSource = mys.dataTable("jadwalsesi")
        lueJadwalSesi.Properties.DisplayMember = "content"
        lueJadwalSesi.Properties.ValueMember = "id"
        lueJadwalSesi.EditValue = Nothing

        If mys.getDataSet("jadwalsesi") > 0 Then
            lblTanggal.Text = dateDate.Day & " " & NamaBulan(dateDate.Month) & " " & dateDate.Year
        Else
            showPanelInfo(InfoType.info, "Tidak Ditemukan", "Jadwal Tidak Ditemukan")
        End If
        lblTanggal.Tag = strDate

        kosongkanIsian(tlpPasienLama)
        kosongkanIsian(tlpPasienBaru)

        lueLamaAppType.EditValue = CLng(0)
        lueLamaAppVia.EditValue = CLng(0)
        lueBaruAppVia.EditValue = CLng(0)

        xtccPatientData.SelectedTabPage = xtpPasienLama

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub btnShowHidePasien_Click(sender As Object, e As EventArgs) Handles btnShowHidePasien.Click
        If btnShowHidePasien.Tag = 1 Then
            gcDataPasien.Visible = True
            btnShowHidePasien.Tag = 2
            btnShowHidePasien.Text = "<< PASIEN DATA"
        ElseIf btnShowHidePasien.Tag = 2 Then
            gcDataPasien.Visible = False
            btnShowHidePasien.Tag = 1
            btnShowHidePasien.Text = ">> PASIEN DATA"
        End If
    End Sub

    Private Sub btnShowHideParamedis_Click(sender As Object, e As EventArgs) Handles btnShowHideParamedis.Click
        If btnShowHideParamedis.Tag = 1 Then
            tlpAppointment.ColumnStyles.Item(0).Width = lenParamedis
            btnShowHideParamedis.Tag = 2
            btnShowHideParamedis.Text = "<< PARAMEDIS DATA"
        ElseIf btnShowHideParamedis.Tag = 2 Then
            tlpAppointment.ColumnStyles.Item(0).Width = 0
            btnShowHideParamedis.Tag = 1
            btnShowHideParamedis.Text = ">> PARAMEDIS DATA"
        End If
    End Sub

    Private Sub btnRefreshDokter_Click(sender As Object, e As EventArgs) Handles btnRefreshDokter.Click
        loadParamedis()
    End Sub

    Private Sub btnRefreshPasien_Click(sender As Object, e As EventArgs) Handles btnRefreshPasien.Click
        loadPasien()
    End Sub

    Private isPatient As Boolean = False
    Private isMRN As Boolean = False

    Private Sub slueLamaNama_EditValueChanged(sender As Object, e As EventArgs) Handles slueLamaNama.EditValueChanged
        If slueLamaNama.EditValue Is Nothing Then
            teLamaJenisKelamin.Text = "-"
            teLamaTanggalLahir.Text = "-"
            teLamaAlamat.Text = "-"
            teLamaTelepon1.Text = "0"
            teLamaTelepon2.Text = "0"
            teLamaRemarks.EditValue = Nothing
            lueLamaAppType.EditValue = CLng(0)
            lueLamaAppVia.EditValue = CLng(0)
            Exit Sub
        End If
        If isPatient = True Then Exit Sub
        isPatient = True
        lueLamaNoRM.EditValue = slueLamaNama.EditValue
        isPatient = False

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select r.idrekammedis,r.jeniskelamin as idjeniskelamin,jk.generalcode as jeniskelamin,convert(varchar,r.tanggallahir,105) as tanggallahir,isnull(a.alamat,'-') as alamat,isnull(t1.phone,0) as phone1,isnull(t2.phone,0) as phone2 from rekammedis r left join sys_generalcode jk on r.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' left join (select idreff,alamat from alamat where tablereff='PASIEN' and isdeleted=0 and isprimary=1 and addresstype=2) a on r.idrekammedis=a.idreff left join (select idreff,phone from phone where tablereff='PASIEN' and isdeleted=0 and isprimary=1 and phonetype=3) t1 on r.idrekammedis=t1.idreff left join (select idreff,phone from phone where tablereff='PASIEN' and isdeleted=0 and isprimary=1 and phonetype=2) t2 on r.idrekammedis=t2.idreff where r.idrekammedis='" & slueLamaNama.EditValue & "'", "data")
        teLamaJenisKelamin.Tag = sqls.getDataSet("data", 0, "idjeniskelamin")
        teLamaJenisKelamin.Text = sqls.getDataSet("data", 0, "jeniskelamin")
        teLamaTanggalLahir.Text = sqls.getDataSet("data", 0, "tanggallahir")
        teLamaAlamat.Text = sqls.getDataSet("data", 0, "alamat")

        If sqls.getDataSet("data") > 0 Then
            teLamaTelepon1.Text = sqls.getDataSet("data", 0, "phone1")
        Else
            teLamaTelepon1.Text = "0"
        End If
        If sqls.getDataSet("data") > 0 Then
            teLamaTelepon2.Text = sqls.getDataSet("data", 0, "phone2")
        Else
            teLamaTelepon2.Text = "0"
        End If
        teLamaRemarks.EditValue = Nothing
        lueLamaAppType.EditValue = CLng(0)
        lueLamaAppVia.EditValue = CLng(0)
    End Sub

    Private Sub lueLamaNoRM_EditValueChanged(sender As Object, e As EventArgs) Handles lueLamaNoRM.EditValueChanged
        If sender Is lueLamaNoRM Then
            If lueLamaNoRM.EditValue Is Nothing Then
                Exit Sub
            End If
            If isMRN = True Then
                Exit Sub
            End If
            isMRN = True
            slueLamaNama.EditValue = lueLamaNoRM.EditValue
            isMRN = False
        End If
    End Sub

    Private Sub dnKalender_EditValueChanged(sender As Object, e As EventArgs) Handles dnKalender.EditValueChanged
        If lueParamedis.EditValue Is Nothing Then
            showPanelInfo(InfoType.noinfo, "", "")
            Exit Sub
        End If
        If lueSpesialis.EditValue Is Nothing Then
            showPanelInfo(InfoType.noinfo, "", "")
            Exit Sub
        End If

        If isButton = False Then
            If dnKalender.EditValue Is Nothing Then
                Exit Sub
            End If
            If CDate(dnKalender.EditValue) < nowTime Then
                'dizMsgbox("Dilarang mengubah jadwal sebelumnya", dizMsgboxStyle.Peringatan, Me)
                dnKalender.EditValue = nowTime
                Exit Sub
            End If

            Dim ctrltag As Object = Nothing
            Dim isfound As Boolean = False
            For Each ctrl As Control In tlpTanggal.Controls
                For Each ctrl1 As Control In ctrl.Controls
                    CType(ctrl1, Button).FlatAppearance.BorderColor = Color.FromArgb(246, 139, 31)
                    CType(ctrl1, Button).Image = My.Resources.slot1

                    If CType(ctrl1, Button).Tag = Format(dnKalender.DateTime, "dd-MM-yyyy") Then
                        ctrltag = ctrl
                        isfound = True
                    End If
                Next
            Next

            Dim strDate As String = ""
            If isfound = True Then
                For Each ctrl1 As Control In CType(ctrltag, btnSchedule).Controls
                    CType(ctrl1, Button).FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0)
                    CType(ctrl1, Button).Image = My.Resources.slotr
                    strDate = CType(ctrl1, Button).Tag
                Next
            Else
                strDate = Format(dnKalender.EditValue, "dd-MM-yyyy")
            End If

            Dim loadScr As New frmLoading()
            splashClosed = False
            loadScr.Show(Me)
            loadScr.BringToFront()
            Application.DoEvents()
            Me.Cursor = Cursors.WaitCursor

            showPanelInfo(InfoType.noinfo, "", "")

            btnDate = sender
            Dim dateDate As Date = Strdate2Date(strDate)

            lblTanggal.Text = dateDate.Day & " " & NamaBulan(dateDate.Month) & " " & dateDate.Year
            lblTanggal.Tag = strDate

            lueJadwalSesi.Properties.DataSource = Nothing
            lueJadwalSesi.Properties.DisplayMember = "content"
            lueJadwalSesi.Properties.ValueMember = "id"
            lueJadwalSesi.EditValue = Nothing

            Dim mys As New SQLs(dbstring)
            mys.DMLQuery("select top 1 idvacation,kehadiran,remarks from vacation where convert(varchar,vacationdate,105)='" & strDate & "' and isdeleted=0 and kehadiran<>0 and idreff='" & lueParamedis.EditValue & "' and tablereff='PARAMEDIS' order by createddate desc", "cekijin")
            If mys.getDataSet("cekijin") > 0 Then
                If mys.getDataSet("cekijin", 0, "kehadiran") = 1 Then
                    showPanelInfo(InfoType.info, "Tidak Hadir - Sakit", mys.getDataSet("cekijin", 0, "remarks"))
                ElseIf mys.getDataSet("cekijin", 0, "kehadiran") = 2 Then
                    showPanelInfo(InfoType.info, "Tidak Hadir - Ijin", mys.getDataSet("cekijin", 0, "remarks"))
                ElseIf mys.getDataSet("cekijin", 0, "kehadiran") = 3 Then
                    showPanelInfo(InfoType.info, "Tidak Hadir Tanpa Keterangan", mys.getDataSet("cekijin", 0, "remarks"))
                End If
                Me.Cursor = Cursors.Default
                splashClosed = True
                Exit Sub
            End If

            mys.DMLQuery("select pj.idjadwalsesi as id,js.nama +' ('+ substring(convert(varchar,ISNULL(jp.jammulaipengganti,pj.jammulai),108),0,6) + ' - ' +substring(convert(varchar,ISNULL(jp.jamselesaipengganti,pj.jamselesai),108),0,6)+')' as content from paramedisjadwal pj left join paramedisspesialis ps on pj.idparamedisspesialis=ps.idparamedisspesialis left join jadwalsesi js on pj.idjadwalsesi=js.idjadwalsesi left join jadwalparamedis jp on ps.idparamedis=jp.idparamedis and convert(varchar,jp.jadwaltanggal,105)='" & Format(dateDate, "dd-MM-yyyy") & "' and jp.idjadwalsesi=pj.idjadwalsesi and jp.isdeleted=0 where (convert(date,'" & Format(dateDate, "yyyy-MM-dd") & "') >= pj.tanggalmulai and convert(date,'" & Format(dateDate, "yyyy-MM-dd") & "') <= pj.tanggalselesai) and pj.hari like '%" & dateDate.DayOfWeek & "%' and ps.idparamedis='" & lueParamedis.EditValue & "' and ps.idspesialis='" & lueSpesialis.EditValue & "'", "jadwalsesi")

            lueJadwalSesi.Properties.DataSource = mys.dataTable("jadwalsesi")
            lueJadwalSesi.Properties.DisplayMember = "content"
            lueJadwalSesi.Properties.ValueMember = "id"
            lueJadwalSesi.EditValue = Nothing

            If mys.getDataSet("jadwalsesi") > 0 Then
                lblTanggal.Text = dateDate.Day & " " & NamaBulan(dateDate.Month) & " " & dateDate.Year
            Else
                showPanelInfo(InfoType.info, "Tidak Ditemukan", "Jadwal Tidak Ditemukan")
            End If

            Me.Cursor = Cursors.Default
            splashClosed = True
            Exit Sub
        End If
    End Sub

    Private warnColor As Color = Color.FromArgb(119, 5, 6)
    Private infoColor As Color = Color.FromArgb(0, 102, 0)
    Private defaultTitleInfo As String = "Peringatan : Slot Appointment Tidak Tersedia"

    Private Enum InfoType
        noinfo = 0
        info = 1
        warn = 2
    End Enum

    Private Sub showPanelInfo(ByVal paneltype As InfoType, ByVal titlestr As String, ByVal contentstr As String)
        If paneltype = 0 Then
            pnlInfo.Visible = False
            pnlInfo.SendToBack()
            pnlInfo.Dock = DockStyle.None

            pnlPasienSesi.Visible = True
            pnlPasienSesi.BringToFront()
            pnlPasienSesi.Dock = DockStyle.Fill
        Else
            pnlPasienSesi.Visible = False
            pnlPasienSesi.SendToBack()
            pnlPasienSesi.Dock = DockStyle.None

            pnlInfo.Visible = True
            pnlInfo.BringToFront()
            pnlInfo.Dock = DockStyle.Fill
            lblcTitle.Text = titlestr
            lblcContent.Text = contentstr
            If paneltype = 1 Then
                pbcIcon.Image = My.Resources.info27
                lblcTitle.ForeColor = infoColor
                lblcContent.ForeColor = infoColor
            ElseIf paneltype = 2 Then
                pbcIcon.Image = My.Resources.cancel21
                lblcTitle.ForeColor = warnColor
                lblcContent.ForeColor = warnColor
            End If
        End If
    End Sub

    Private Sub showPanelSlotInfo(ByVal paneltype As InfoType, ByVal titlestr As String, ByVal contentstr As String)
        If paneltype = 0 Then
            pnlInfoSlot.Visible = False
            pnlInfoSlot.SendToBack()
            pnlInfoSlot.Dock = DockStyle.None

            tlpSlot.Visible = True
            tlpSlot.BringToFront()
            tlpSlot.Dock = DockStyle.Top
        Else
            tlpSlot.Visible = False
            tlpSlot.SendToBack()
            tlpSlot.Dock = DockStyle.None

            pnlInfoSlot.Visible = True
            pnlInfoSlot.BringToFront()
            pnlInfoSlot.Dock = DockStyle.Fill
            lblcTitleSlot.Text = titlestr
            lblcContentSlot.Text = contentstr
            If paneltype = 1 Then
                pbcIconSlot.Image = My.Resources.info27
                lblcTitleSlot.ForeColor = infoColor
                lblcContentSlot.ForeColor = infoColor
            ElseIf paneltype = 2 Then
                pbcIconSlot.Image = My.Resources.cancel21
                lblcTitleSlot.ForeColor = warnColor
                lblcContentSlot.ForeColor = warnColor
            End If
        End If
    End Sub

    Private maxApp As Integer = 30
    Private durasi As Integer = 0
    Private Sub lueJadwalSesi_EditValueChanged(sender As Object, e As EventArgs) Handles lueJadwalSesi.EditValueChanged
        If lueJadwalSesi.EditValue Is Nothing Then
            tlpSlot.Controls.Clear()
            tlpSlot.RowCount = 0
            tlpSlot.RowStyles.Clear()
            showPanelSlotInfo(InfoType.noinfo, "", "")
            Exit Sub
        End If

        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        btnDate = sender
        showPanelSlotInfo(InfoType.noinfo, "", "")

        Dim idxAktif As Integer = -1
        Dim strDate As String = lblTanggal.Tag
        Dim thisDate As Date = Strdate2Date(strDate)

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select top 1 idvacation,kehadiran,remarks from vacation where convert(varchar,vacationdate,105)='" & strDate & "' and isdeleted=0 and kehadiran<>0 and idjadwalsesi='" & lueJadwalSesi.EditValue & "' and idreff='" & lueParamedis.EditValue & "' and tablereff='PARAMEDIS' order by idvacation desc", "cekijin")
        If sqls.getDataSet("cekijin") > 0 Then
            If sqls.getDataSet("cekijin", 0, "kehadiran") = 1 Then
                showPanelSlotInfo(InfoType.info, "Tidak Hadir - Sakit", sqls.getDataSet("cekijin", 0, "remarks"))
            ElseIf sqls.getDataSet("cekijin", 0, "kehadiran") = 2 Then
                showPanelSlotInfo(InfoType.info, "Tidak Hadir - Ijin", sqls.getDataSet("cekijin", 0, "remarks"))
            ElseIf sqls.getDataSet("cekijin", 0, "kehadiran") = 3 Then
                showPanelSlotInfo(InfoType.info, "Tidak Hadir Tanpa Keterangan", sqls.getDataSet("cekijin", 0, "remarks"))
            End If

            Me.Cursor = Cursors.Default
            splashClosed = True
            Exit Sub
        End If

        sqls.DMLQuery("select substring(convert(varchar,ISNULL(jp.jammulaipengganti,pj.jammulai),108),0,6) as jammulai,substring(convert(varchar,ISNULL(jp.jamselesaipengganti,pj.jamselesai),108),0,6) as jamselesai,pj.maxapp,pj.durasi from paramedisjadwal pj left join paramedisspesialis ps on pj.idparamedisspesialis=ps.idparamedisspesialis left join jadwalparamedis jp on ps.idparamedis=jp.idparamedis and convert(varchar,jp.jadwaltanggal,105)='" & strDate & "' and jp.idjadwalsesi='" & lueJadwalSesi.EditValue & "' and jp.isdeleted=0  where pj.hari like '%" & thisDate.DayOfWeek & "%' and pj.idparamedisspesialis=(select idparamedisspesialis from paramedisspesialis where idparamedis='" & lueParamedis.EditValue & "' and idspesialis='" & lueSpesialis.EditValue & "')", "cektgl")

        Dim strJamMulai As String = 8
        Dim strMenitMulai As String = 0
        Dim strJamSelesai As String = 8
        Dim strMenitSelesai As String = 0
        maxApp = 30
        durasi = 0
        If sqls.getDataSet("cektgl") > 0 Then
            strJamMulai = sqls.getDataSet("cektgl", 0, "jammulai").ToString.Split(":")(0)
            strMenitMulai = sqls.getDataSet("cektgl", 0, "jammulai").ToString.Split(":")(1)
            strJamSelesai = sqls.getDataSet("cektgl", 0, "jamselesai").ToString.Split(":")(0)
            strMenitSelesai = sqls.getDataSet("cektgl", 0, "jamselesai").ToString.Split(":")(1)
            maxApp = CInt(sqls.getDataSet("cektgl", 0, "maxapp"))
            durasi = CInt(sqls.getDataSet("cektgl", 0, "durasi"))
        End If

        Dim jammulai As Date = New Date(thisDate.Year, thisDate.Month, thisDate.Day, CInt(strJamMulai), CInt(strMenitMulai), 0)
        Dim jamselesai As Date = New Date(thisDate.Year, thisDate.Month, thisDate.Day, CInt(strJamSelesai), CInt(strMenitSelesai), 0)
        Dim isdurasi As Boolean = False
        If durasi > 0 Then
            maxApp = DateDiff(DateInterval.Minute, jammulai, jamselesai) / durasi
            isdurasi = True
        End If
        If maxApp > 0 And isdurasi = False Then
            durasi = DateDiff(DateInterval.Minute, jammulai, jamselesai) / maxApp
            isdurasi = False
        End If

        tlpSlot.Controls.Clear()
        tlpSlot.RowCount = 0
        tlpSlot.RowStyles.Clear()
        tlpSlot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        tlpSlot.Visible = False

        Dim counter As Integer = 0
        Dim idappointment As String = "-1"

        For a As Integer = 0 To maxApp - 1
            tlpSlot.SuspendLayout()

            Dim jamskrg As DateTime = jammulai.AddMinutes(durasi * a)
            Dim btnObj As New btnBooking
            btnObj.BackColor = color.fromargb(240, 240, 240)
            btnObj.Name = "btnAppointment" & a
            btnObj.labelTanggal = jamskrg
            btnObj.nomorUrut = a + 1
            btnObj.sessionString = lueJadwalSesi.Text
            btnObj.sessionNo = lueJadwalSesi.EditValue
            btnObj.setStatus = 0
            btnObj.id = "-1"
            btnObj.Size = New Size(900, 65)
            btnObj.Anchor = AnchorStyles.None
            btnObj.Dock = DockStyle.None

            AddHandler btnObj.Button1.Click, AddressOf infoClick
            AddHandler btnObj.Button2.Click, AddressOf appointmentClick
            AddHandler btnObj.Button3.Click, AddressOf cancelClick
            AddHandler btnObj.Button4.Click, AddressOf okClick
            counter += 1

            sqls.DMLQuery("select a.idappointment,a.idjadwalsesi,j.nama as jadwalsesi,convert(varchar,a.appointmentdate,105) + ' ' + convert(varchar,a.appointmentdate,108) as appointmentdate,convert(varchar,a.bookingdate,105) + ' ' + convert(varchar,a.bookingdate,108) as bookingdate,a.bookingstatus,a.nomorurut,a.idrekammedis,isnull(dbo.fFormatNoRM(r.rekammedisno),'00-00-00-00') as rekammedisno,a.nama,a.telepon1,a.telepon2,a.jeniskelamin,a.alamat,a.tanggallahir,a.remarks,a.idregistrasi,a.issms,a.issmssent,a.isdeleted,a.createdby,a.createddate,a.updatedby,a.updateddate,a.remarks,isnull(a.appointmenttype,0) as appointmenttype,isnull(a.appointmentvia,0) as appointmentvia,at.generalcode as apptype,av.generalcode as appvia from appointment a left join rekammedis r on a.idrekammedis=r.idrekammedis left join jadwalsesi j on a.idjadwalsesi=j.idjadwalsesi left join sys_generalcode at on isnull(a.appointmenttype,0)=at.idgeneral and at.gctype='APPTYPE' left join sys_generalcode av on isnull(a.appointmentvia,0)=av.idgeneral and av.gctype='APPVIA' where a.idparamedisspesialis=(select top 1 idparamedisspesialis from paramedisspesialis where idparamedis='" & lueParamedis.EditValue & "' and idspesialis='" & lueSpesialis.EditValue & "') and a.idjadwalsesi='" & lueJadwalSesi.EditValue & "' and a.nomorurut='" & (a + 1) & "' and convert(varchar,a.bookingdate,105)='" & strDate & "' and a.isdeleted=0 order by a.createddate asc", "cekappointment")
            If sqls.getDataSet("cekappointment") > 0 Then
                Dim jamslot As String = sqls.getDataSet("cekappointment", 0, "bookingdate").ToString.Split(" ")(1)
                Dim schdate As DateTime = New DateTime(thisDate.Year, thisDate.Month, thisDate.Day, jamslot.Split(":")(0), jamslot.Split(":")(1), jamslot.Split(":")(2))
                Dim tanggalangka As String = schdate.Day & " " & schdate.Month & " " & schdate.Year & " " & schdate.Hour & " " & schdate.Minute & " " & schdate.Second
                Dim patientname As String = sqls.getDataSet("cekappointment", 0, "nama")
                Dim mrn As String = sqls.getDataSet("cekappointment", 0, "rekammedisno")
                Dim cell1 As String = sqls.getDataSet("cekappointment", 0, "telepon1")
                Dim cell2 As String = sqls.getDataSet("cekappointment", 0, "telepon2")
                Dim bookstat As String = sqls.getDataSet("cekappointment", 0, "bookingstatus")
                Dim intSession As String = sqls.getDataSet("cekappointment", 0, "idjadwalsesi")
                Dim strSession As String = sqls.getDataSet("cekappointment", 0, "jadwalsesi")
                Dim appremarks As String = sqls.getDataSet("cekappointment", 0, "remarks")
                If appremarks = "-" Then
                    appremarks = ""
                End If
                Dim appnote As String = ""
                If CLng(sqls.getDataSet("cekappointment", 0, "appointmentvia")) <> CLng(0) Then
                    If appremarks <> "" Then
                        appnote &= ", "
                    End If
                    appnote &= sqls.getDataSet("cekappointment", 0, "appvia")
                End If
                If CLng(sqls.getDataSet("cekappointment", 0, "appointmenttype")) <> CLng(0) Then
                    If appnote <> "" Then
                        appnote &= ", "
                    End If
                    appnote &= sqls.getDataSet("cekappointment", 0, "apptype")
                End If

                idappointment = sqls.getDataSet("cekappointment", 0, "idappointment")
                btnObj.labelTanggal = schdate
                btnObj.namapasien = patientname
                btnObj.norm = mrn
                btnObj.notelp1 = cell1
                btnObj.notelp2 = cell2
                btnObj.setStatus = bookstat
                btnObj.sessionNo = intSession
                btnObj.sessionString = strSession
                btnObj.remarks = appremarks & appnote
                btnObj.id = idappointment

                'MsgBox(sqls.getDataSet("cekappointment", 0, "appointmenttype"))
                '8 1 2018 19 0 0|4|1|-]-]-]-]-1]-1
                If sqls.getDataSet("cekappointment") > 1 Then
                    For t As Integer = 1 To sqls.getDataSet("cekappointment") - 1
                        sqls.DMLQuery("delete from appointment where isdeleted=0 and idappointment='" & sqls.getDataSet("cekappointment", t, "idappointment") & "'", False)
                    Next
                End If
            End If
            sqls.clearDataSet("cekappointment")
            btnObj.buildObj()

            tlpSlot.RowCount = a + 1
            tlpSlot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
            tlpSlot.Controls.Add(btnObj, 1, a + 1)
            tlpSlot.Size = New System.Drawing.Size(947, (counter * 75) + 10)
            btnObj.Size = New Size(900, 65)

            tlpSlot.ResumeLayout()
        Next
        tlpSlot.RowCount = counter
        tlpSlot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        tlpSlot.Size = New System.Drawing.Size(947, (counter * 75) + 10)
        tlpSlot.Visible = True

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub infoClick(ByVal sender As Object, ByVal e As System.EventArgs)
        retForm = ""
        Dim tagStr As String = sender.tag
        Dim mys As New dtsetSQLS(dbstring)
        Dim schid As String = ""
        Dim idapp As String = ""
        Dim nourutstr As String = ""
        schid = lueJadwalSesi.EditValue
        nourutstr = tagStr.Split("|")(1)
        idapp = tagStr.Split("|")(0)
        Dim info As New frmAppointmentInfo
        info.NoUrut = idapp
        info.ShowDialog()
        If retForm = "Save" Then
            btnRefreshSlot_Click(btnRefreshSlot, Nothing)
            'buttonClick(btnDate, Nothing)
        End If
    End Sub

    Private objPage As Object
    Private Sub appointmentClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim cekPatient As Boolean = True
        Dim cekRequired As Boolean = True
        If xtccPatientData.SelectedTabPage Is xtpPasienLama Then
            If slueLamaNama.EditValue Is Nothing Then
                cekPatient = False
            End If
        ElseIf xtccPatientData.SelectedTabPage Is xtpPasienBaru Then
            If teBaruNama.Text = "" Or teBaruNama.EditValue Is Nothing Or (teBaruNama.Text = "" And teBaruNama.EditValue Is Nothing) Then
                cekPatient = False
            End If
        End If
        If xtccPatientData.SelectedTabPage Is xtpPasienLama Then
            If teLamaTelepon1.Text = "" Then
                cekRequired = False
                If teLamaTelepon2.Text = "" Then
                    cekRequired = False
                Else
                    cekRequired = True
                End If
            End If
            If teLamaTelepon1.Text = "0" Then
                cekRequired = False
                If teLamaTelepon2.Text = "0" Then
                    cekRequired = False
                Else
                    cekRequired = True
                End If
            End If
            If lueLamaAppVia.EditValue Is Nothing Then
                cekRequired = False
            End If
            If lueLamaAppType.EditValue Is Nothing Then
                cekRequired = False
            End If
        ElseIf xtccPatientData.SelectedTabPage Is xtpPasienBaru Then
            If teBaruTelepon1.Text = "" Then
                cekRequired = False
                If teBaruTelepon2.Text = "" Then
                    cekRequired = False
                Else
                    cekRequired = True
                End If
            End If
            If teBaruTelepon1.Text = "0" Then
                cekRequired = False
                If teBaruTelepon2.Text = "0" Then
                    cekRequired = False
                Else
                    cekRequired = True
                End If
            End If
            If deBaruTanggalLahir.EditValue Is Nothing Then
                cekRequired = False
            End If
            If lueBaruJenisKelamin.EditValue Is Nothing Then
                cekRequired = False
            End If
            If lueBaruAppVia.EditValue Is Nothing Then
                cekRequired = False
            End If
        End If
        If sender.tag.ToString.Split("|")(0) = "-1" Then
            If cekPatient = False Then
                dizMsgbox("Nama Pasien harus diisi", dizMsgboxStyle.Peringatan, "Peringatan", Me)
                Exit Sub
            End If
            If cekRequired = False Then
                dizMsgbox("Data Pasien belum lengkap", dizMsgboxStyle.Peringatan, "Peringatan", Me)
                Exit Sub
            End If
            If cekPatient = True And cekRequired = True Then
                Me.Cursor = Cursors.WaitCursor
                Dim sqls As New SQLs(dbstring)

                Dim sqlscomp As New SQLs(dbstring)
                sqlscomp.CallSP("spGetCompany", "CompID")
                Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

                Dim idps As String = 0
                sqls.DMLQuery("select idparamedisspesialis from paramedisspesialis where idparamedis='" & lueParamedis.EditValue & "' and idspesialis='" & lueSpesialis.EditValue & "'", "getps")
                If sqls.getDataSet("getps") > 0 Then
                    idps = sqls.getDataSet("getps", 0, "idparamedisspesialis")
                End If

                Dim mys As New dtsetSQLS(dbstring)
                Dim field As New List(Of String)
                Dim value As New List(Of Object)
                field.AddRange(New String() {"idappointment", "idparamedisspesialis", "idjadwalsesi", "idregistrasi", "appointmentdate", "bookingdate", "bookingstatus", "durasi", "nomorurut", "idrekammedis", "nama", "isdeleted", "tanggallahir", "telepon1", "telepon2", "jeniskelamin", "alamat", "remarks", "issms", "issmssent", "isdeleted", "deletereason", "idcompany", "createdby", "createddate", "appointmenttype", "appointmentvia"})

                Dim appdate As DateTime = nowTime
                Dim dateAngka As String = sender.tag.ToString.Split("|")(2)
                Dim schdate As DateTime = New DateTime(dateAngka.Split(" ")(2), dateAngka.Split(" ")(1), dateAngka.Split(" ")(0), dateAngka.Split(" ")(3), dateAngka.Split(" ")(4), dateAngka.Split(" ")(5))
                Dim nourut As String = sender.tag.ToString.Split("|")(1)
                Dim sessionid As String = lueJadwalSesi.EditValue
                Dim isSMS As Integer = 0
                If xtccPatientData.SelectedTabPage Is xtpPasienLama Then
                    isSMS = 0
                ElseIf xtccPatientData.SelectedTabPage Is xtpPasienBaru Then
                    isSMS = 0
                End If
                Dim birthdate As Date
                Dim idappointment As String = GenerateGUID()

                If xtccPatientData.SelectedTabPage Is xtpPasienLama Then
                    sqls.DMLQuery("select top 1 idregistrasi,registrasistatus,registrasidate from registrasi where convert(varchar,registrasidate,105)='" & Format(schdate, "dd-MM-yyyy") & "' and iddokterruangan='" & lueParamedis.EditValue & "' and idspesialisruangan='" & lueSpesialis.EditValue & "' and idrekammedis='" & slueLamaNama.EditValue & "' order by registrasidate asc", "regstat")
                    If teLamaRemarks.EditValue Is Nothing Then
                        teLamaRemarks.EditValue = ""
                    End If

                    If sqls.getDataSet("regstat") = 0 Then
                        If teLamaTanggalLahir.EditValue Is Nothing Then
                            birthdate = Nothing
                            value.AddRange(New Object() {idappointment, idps, lueJadwalSesi.EditValue, 0, appdate, schdate, 0, durasi, nourut, slueLamaNama.EditValue, slueLamaNama.Text, 0, DBNull.Value, teLamaTelepon1.Text, teLamaTelepon2.Text, teLamaJenisKelamin.Tag, teLamaAlamat.Text, teLamaRemarks.Text, isSMS, 0, 0, "-", idcomp, userid, nowTime, lueLamaAppType.EditValue, lueLamaAppVia.EditValue})
                            'debugList(value)
                        Else
                            birthdate = Strdate2Date(teLamaTanggalLahir.Text)
                            value.AddRange(New Object() {idappointment, idps, lueJadwalSesi.EditValue, 0, appdate, schdate, 0, durasi, nourut, slueLamaNama.EditValue, slueLamaNama.Text, 0, birthdate, teLamaTelepon1.Text, teLamaTelepon2.Text, teLamaJenisKelamin.Tag, teLamaAlamat.Text, teLamaRemarks.Text, isSMS, 0, 0, "-", idcomp, userid, nowTime, lueLamaAppType.EditValue, lueLamaAppVia.EditValue})
                            'debugList(value)
                        End If
                    Else
                        If sqls.getDataSet("regstat", 0, "registrasistatus") = 0 Then
                            Dim idreg As String = CStr(sqls.getDataSet("regstat", 0, "idregistrasi"))

                            If teLamaTanggalLahir.EditValue Is Nothing Then
                                birthdate = Nothing
                                value.AddRange(New Object() {idappointment, idps, lueJadwalSesi.EditValue, 0, appdate, schdate, 2, durasi, nourut, slueLamaNama.EditValue, slueLamaNama.Text, 0, DBNull.Value, teLamaTelepon1.Text, teLamaTelepon2.Text, teLamaJenisKelamin.Tag, teLamaAlamat.Text, teLamaRemarks.Text, isSMS, 0, 0, "-", idcomp, userid, nowTime, lueLamaAppType.EditValue, lueLamaAppVia.EditValue})
                                'debugList(value)
                            Else
                                birthdate = Strdate2Date(teLamaTanggalLahir.Text)
                                value.AddRange(New Object() {idappointment, idps, lueJadwalSesi.EditValue, 0, appdate, schdate, 2, durasi, nourut, slueLamaNama.EditValue, slueLamaNama.Text, 0, birthdate, teLamaTelepon1.Text, teLamaTelepon2.Text, teLamaJenisKelamin.Tag, teLamaAlamat.Text, teLamaRemarks.Text, isSMS, 0, 0, "-", idcomp, userid, nowTime, lueLamaAppType.EditValue, lueLamaAppVia.EditValue})
                                'debugList(value)
                            End If
                        ElseIf sqls.getDataSet("regstat", 0, "registrasistatus") = 2 Or sqls.getDataSet("regstat", 0, "registrasistatus") = 5 Then
                            Dim idreg As String = CStr(sqls.getDataSet("regstat", 0, "idregistrasi"))

                            If teLamaTanggalLahir.EditValue Is Nothing Then
                                birthdate = Nothing
                                value.AddRange(New Object() {idappointment, idps, lueJadwalSesi.EditValue, 0, appdate, schdate, 2, durasi, nourut, slueLamaNama.EditValue, slueLamaNama.Text, 1, DBNull.Value, teLamaTelepon1.Text, teLamaTelepon2.Text, teLamaJenisKelamin.Tag, teLamaAlamat.Text, teLamaRemarks.Text, isSMS, 0, 0, "-", idcomp, userid, nowTime, lueLamaAppType.EditValue, lueLamaAppVia.EditValue})
                                'debugList(value)
                            Else
                                birthdate = Strdate2Date(teLamaTanggalLahir.Text)
                                value.AddRange(New Object() {idappointment, idps, lueJadwalSesi.EditValue, 0, appdate, schdate, 2, durasi, nourut, slueLamaNama.EditValue, slueLamaNama.Text, 1, birthdate, teLamaTelepon1.Text, teLamaTelepon2.Text, teLamaJenisKelamin.Tag, teLamaAlamat.Text, teLamaRemarks.Text, isSMS, 0, 0, "-", idcomp, userid, nowTime, lueLamaAppType.EditValue, lueLamaAppVia.EditValue})
                                'debugList(value)
                            End If
                        ElseIf sqls.getDataSet("regstat", 0, "registrasistatus") = 7 Then
                            Dim idreg As String = CStr(sqls.getDataSet("regstat", 0, "idregistrasi"))

                            If teLamaTanggalLahir.EditValue Is Nothing Then
                                birthdate = Nothing
                                value.AddRange(New Object() {idappointment, idps, lueJadwalSesi.EditValue, 0, appdate, schdate, 3, durasi, nourut, slueLamaNama.EditValue, slueLamaNama.Text, 0, DBNull.Value, teLamaTelepon1.Text, teLamaTelepon2.Text, teLamaJenisKelamin.Tag, teLamaAlamat.Text, teLamaRemarks.Text, isSMS, 0, 0, "-", idcomp, userid, nowTime, lueLamaAppType.EditValue, lueLamaAppVia.EditValue})
                                'debugList(value)
                            Else
                                birthdate = Strdate2Date(teLamaTanggalLahir.Text)
                                value.AddRange(New Object() {idappointment, idps, lueJadwalSesi.EditValue, 0, appdate, schdate, 3, durasi, nourut, slueLamaNama.EditValue, slueLamaNama.Text, 0, birthdate, teLamaTelepon1.Text, teLamaTelepon2.Text, teLamaJenisKelamin.Tag, teLamaAlamat.Text, teLamaRemarks.Text, isSMS, 0, 0, "-", idcomp, userid, nowTime, lueLamaAppType.EditValue, lueLamaAppVia.EditValue})
                                'debugList(value)
                            End If
                        End If
                    End If
                Else
                    If teBaruRemarks.EditValue Is Nothing Then
                        teBaruRemarks.EditValue = ""
                    End If

                    birthdate = CDate(deBaruTanggalLahir.EditValue)
                    value.AddRange(New Object() {idappointment, idps, lueJadwalSesi.EditValue, 0, appdate, schdate, 0, durasi, nourut, 0, teBaruNama.Text, 0, birthdate, teBaruTelepon1.Text, teBaruTelepon2.Text, lueBaruJenisKelamin.EditValue, teBaruAlamat.Text, teBaruRemarks.Text, isSMS, 0, 0, "-", idcomp, userid, nowTime, 0, lueBaruAppVia.EditValue})
                    'debugList(value)
                End If

                mys.datasetSave("appointment", idappointment, field, value, False)
                isiLog(userid, dbstring, field, value, "appointment")

                Me.Cursor = Cursors.Default

                objPage = xtccPatientData.SelectedTabPage
                clearData()
                btnRefreshSlot_Click(btnRefreshSlot, Nothing)
                'buttonClick(btnDate, Nothing)
            End If
        End If
    End Sub

    Private Sub cancelClick(ByVal sender As Object, ByVal e As System.EventArgs)
        If dizMsgbox("Batalkan slot appointment ini ?", dizMsgboxStyle.Konfirmasi, "Pembatalan", Me) = dizMsgboxValue.OK Then
            Dim strreason As String = ""
            Dim editbool As String = "1"
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select value from sys_appsetting where variable='AppointmentDeleteReason'", "AppEdit")
            If sqls.getDataSet("AppEdit") > 0 Then
                editbool = sqls.getDataSet("AppEdit", 0, "value")
            End If
            If editbool = "1" Then
                Dim reason As New frmDeleteReason
                If reason.ShowDialog = Windows.Forms.DialogResult.OK Then
                    If reason.reason.Length = 0 Then
                        dizMsgbox("Alasan hapus appointment harus diisi", dizMsgboxStyle.Peringatan, "Peringatan", Me)
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If
                strreason = "DELETE NOTE : " & vbCrLf & reason.reason
            End If

            Dim mys As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            Dim idapp As String = sender.tag.ToString.Split("|")(0)
            field.AddRange(New String() {"idappointment", "isdeleted", "updatedby", "updateddate", "deletereason"})
            value.AddRange(New Object() {idapp, 1, userid, nowTime, strreason})

            mys.datasetSave("appointment", idapp, field, value, False)
            isiLog(userid, dbstring, field, value, "appointment")

            btnRefreshSlot_Click(btnRefreshSlot, Nothing)
            'buttonClick(btnDate, Nothing)
        End If
    End Sub

    Private Sub okClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim mys As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim idapp As String = sender.tag.ToString.Split("|")(0)

        Dim sqls As New SQLs(dbstring)
        Dim idps As String = 0
        Dim norm As Long = 0
        norm = CLng(CType(CType(sender, System.Windows.Forms.Button).Parent, btnBooking).norm.Replace("-", ""))
        sqls.DMLQuery("select idrekammedis from rekammedis where isdeleted=0 and rekammedisno='" & norm & "'", "getidrm")
        Dim idrm As String = 0
        idrm = CStr(sqls.getDataSet("getidrm", 0, "idrekammedis"))
        sqls.DMLQuery("select idparamedisspesialis from paramedisspesialis where idparamedis='" & lueParamedis.EditValue & "' and idspesialis='" & lueSpesialis.EditValue & "'", "getps")
        If sqls.getDataSet("getps") > 0 Then
            idps = sqls.getDataSet("getps", 0, "idparamedisspesialis")

            Dim idreg As String = 0
            Dim dateAngka As String = sender.tag.ToString.Split("|")(2)
            Dim schdate As DateTime = New DateTime(dateAngka.Split(" ")(2), dateAngka.Split(" ")(1), dateAngka.Split(" ")(0), dateAngka.Split(" ")(3), dateAngka.Split(" ")(4), dateAngka.Split(" ")(5))

            sqls.DMLQuery("select top 1 idregistrasi,registrasistatus,registrasidate from registrasi where convert(varchar,registrasidate,105)='" & Format(schdate, "dd-MM-yyyy") & "' and iddokterruangan='" & lueParamedis.EditValue & "' and idspesialisruangan='" & lueSpesialis.EditValue & "' and idrekammedis='" & idrm & "' order by registrasidate asc", "regstat")
            If sqls.getDataSet("regstat") > 0 Then
                If sqls.getDataSet("regstat", 0, "registrasistatus") = 0 Then
                    idreg = CStr(sqls.getDataSet("regstat", 0, "idregistrasi"))
                    field.AddRange(New String() {"idappointment", "idregistrasi", "bookingstatus", "updatedby", "updateddate"})
                    value.AddRange(New Object() {idapp, idreg, 2, userid, nowTime})
                    mys.datasetSave("appointment", idapp, field, value, False)
                    isiLog(userid, dbstring, field, value, "appointment")
                ElseIf sqls.getDataSet("regstat", 0, "registrasistatus") = 2 Or sqls.getDataSet("regstat", 0, "registrasistatus") = 5 Then
                    idreg = CStr(sqls.getDataSet("regstat", 0, "idregistrasi"))
                    field.AddRange(New String() {"idappointment", "idregistrasi", "bookingstatus", "isdeleted", "updatedby", "updateddate"})
                    value.AddRange(New Object() {idapp, idreg, 2, 1, userid, nowTime})
                    mys.datasetSave("appointment", idapp, field, value, False)
                    isiLog(userid, dbstring, field, value, "appointment")
                ElseIf sqls.getDataSet("regstat", 0, "registrasistatus") = 7 Then
                    idreg = CStr(sqls.getDataSet("regstat", 0, "idregistrasi"))
                    field.AddRange(New String() {"idappointment", "idregistrasi", "bookingstatus", "updatedby", "updateddate"})
                    value.AddRange(New Object() {idapp, idreg, 3, userid, nowTime})
                    mys.datasetSave("appointment", idapp, field, value, False)
                    isiLog(userid, dbstring, field, value, "appointment")
                End If
            Else
                field.AddRange(New String() {"idappointment", "bookingstatus", "updatedby", "updateddate"})
                value.AddRange(New Object() {idapp, 1, userid, nowTime})
                mys.datasetSave("appointment", idapp, field, value, False)
                isiLog(userid, dbstring, field, value, "appointment")
            End If
        Else
            field.AddRange(New String() {"idappointment", "bookingstatus", "updatedby", "updateddate"})
            value.AddRange(New Object() {idapp, 1, userid, nowTime})
            mys.datasetSave("appointment", idapp, field, value, False)
            isiLog(userid, dbstring, field, value, "appointment")
        End If

        btnRefreshSlot_Click(btnRefreshSlot, Nothing)
        'buttonClick(btnDate, Nothing)
    End Sub

    Private Sub clearData()
        kosongkanIsian(tlpPasienLama)
        kosongkanIsian(tlpPasienBaru)

        slueLamaNama.EditValue = Nothing
        lueLamaNoRM.EditValue = Nothing
        teLamaAlamat.EditValue = Nothing
        teLamaJenisKelamin.EditValue = Nothing
        teLamaRemarks.EditValue = Nothing
        teLamaTanggalLahir.EditValue = Nothing
        teLamaTelepon1.EditValue = Nothing
        teLamaTelepon2.EditValue = Nothing
        lueLamaAppType.EditValue = CLng(0)
        lueLamaAppVia.EditValue = CLng(0)

        teBaruAlamat.EditValue = Nothing
        teBaruNoRM.EditValue = Nothing
        teBaruTelepon1.EditValue = Nothing
        teBaruTelepon2.EditValue = Nothing
        lueBaruJenisKelamin.EditValue = Nothing
        deBaruTanggalLahir.EditValue = Nothing
        teBaruRemarks.EditValue = Nothing
        lueBaruAppVia.EditValue = CLng(0)
    End Sub

    Private Sub btnRefreshSlot_Click(sender As Object, e As EventArgs) Handles btnRefreshSlot.Click
        If lueJadwalSesi.EditValue IsNot Nothing Then
            lueJadwalSesi_EditValueChanged(lueJadwalSesi, Nothing)
        End If
    End Sub

    Private Sub Angka_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles teLamaTelepon1.KeyPress, teLamaTelepon2.KeyPress, teBaruTelepon1.KeyPress, teBaruTelepon2.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rNumeric) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnAppDokter_Click(sender As Object, e As EventArgs) Handles btnAppDokter.Click
        formTitle = "Monitoring Appointment Dokter"
        Dim frmMon As New frmMonAppointmentParamedis
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

    Private Sub btnAppPasien_Click(sender As Object, e As EventArgs) Handles btnAppPasien.Click
        formTitle = "Monitoring Appointment Pasien"
        Dim frmMon As New frmMonAppointmentPasien
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

    Private Sub btnAppHarian_Click(sender As Object, e As EventArgs) Handles btnAppHarian.Click
        formTitle = "Monitoring Appointment Harian"
        Dim frmMon As New frmMonAppointmentHarian
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

End Class