Imports DevExpress.XtraGrid.Views.Base

Public Class frmCPPT
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

    Private Sub baru()
        Dim sqls As New SQLs(dbstring)

        sqls.DMLQuery("select left(replace(convert(varchar,s.soapnotedate,120),'-',''),8) as id,convert(varchar,s.soapnotedate,105) as content from soapnote s left join registrasi r on r.idregistrasi=s.idregistrasi where r.idrekammedis=''", "tanggal")
        lueTanggalCPPT.Properties.DataSource = sqls.dataTable("tanggal")
        lueTanggalCPPT.Properties.DisplayMember = "content"
        lueTanggalCPPT.Properties.ValueMember = "id"
        lueTanggalCPPT.EditValue = Nothing

        gcDPJP.DataSource = Nothing
    End Sub

    Private Sub loaddata(idrm As String)
        Dim sqls As New SQLs(dbstring)

        sqls.DMLQuery("select distinct left(replace(convert(varchar,s.soapnotedate,120),'-',''),8) as id,convert(varchar,s.soapnotedate,105) as content from soapnote s left join registrasi r on r.idregistrasi=s.idregistrasi where r.idrekammedis='" & idrm & "' order by left(replace(convert(varchar,s.soapnotedate,120),'-',''),8) desc", "tanggal")
        lueTanggalCPPT.Properties.DataSource = sqls.dataTable("tanggal")
        lueTanggalCPPT.Properties.DisplayMember = "content"
        lueTanggalCPPT.Properties.ValueMember = "id"
        lueTanggalCPPT.EditValue = Nothing

        gcDPJP.DataSource = Nothing
    End Sub

    Private idselect As String = "-1"

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If teSearch.EditValue Is Nothing Then
            dizMsgbox("Tidak disarankan melakukan pencarian seluruh Pasien", dizMsgboxStyle.Info, "Info", Me)
            Exit Sub
        End If
        If teSearch.Text.Replace(" ", "") = "" Then
            dizMsgbox("Tidak disarankan melakukan pencarian seluruh Pasien", dizMsgboxStyle.Info, "Info", Me)
            Exit Sub
        End If

        Dim strQuery As String = "select r.idrekammedis as 'ID',del.generalcode as 'Status Data',dbo.fformatnorm(r.rekammedisno) as 'No RM',sap.generalcode + ' ' + r.nama as 'Nama Pasien',st.generalcode as 'Jenis Kelamin',w.wilayah as 'Warganegara',kot.wilayah as 'Tempat Lahir',convert(varchar,r.tanggallahir,105) as 'Tgl Lahir',ms.generalcode as 'Status Pernikahan',isnull(a.alamat,'-') as 'Alamat',isnull(telk.phone,convert(varchar,0)) + ' ext. ' + isnull(telk.extension,convert(varchar,0)) as 'Telp Kantor',isnull(telr.phone,0) as 'Telp Rumah',isnull(telh.phone,0) as 'Handphone' from rekammedis r left join sys_generalcode sap on r.sapaan=sap.idgeneral and sap.gctype='SAPAAN' left join sys_generalcode st on r.jeniskelamin=st.idgeneral and st.gctype='SEXTYPE' left join sys_generalcode ms on r.pernikahan=ms.idgeneral and ms.gctype='MARITALSTATUS' left join alamat a on r.idrekammedis=a.idreff and a.tablereff='PASIEN'and a.isprimary=1 and a.isdeleted=0 left join wilayah w on r.kewarganegaraan=w.idwilayah left join wilayah kot on r.kotalahir=kot.idwilayah left join phone telk on r.idrekammedis=telk.idreff and telk.tablereff='PASIEN' and telk.isprimary=1 and telk.isdeleted=0 and telk.phonetype=1 left join phone telr on r.idrekammedis=telr.idreff and telr.tablereff='PASIEN' and telr.isprimary=1 and telr.isdeleted=0 and telr.phonetype=2 left join phone telh on r.idrekammedis=telh.idreff and telh.tablereff='PASIEN' and telh.isprimary=1 and telh.isdeleted=0 and telh.phonetype=3 left join sys_generalcode del on r.isdeleted=del.idgeneral and del.gctype='delete' where r.rekammedisno<>0 and (r.nama like '%" & teSearch.Text & "%' or convert(varchar,r.rekammedisno) like '%" & teSearch.Text & "%') order by r.rekammedisno desc"

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery(strQuery, "searchpasien")
        Dim cari As New frmSearch(sqls.dataSet, "searchpasien", "ID")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            idselect = CStr(cari.GetIDSelectData)

            kosongkanIsian(tlpPasien)
            kosongkanIsian(tlpAlamat)
            baru()

            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"@idrm"})
            value.AddRange(New Object() {idselect})
            sqls.CallSP("spGetPasienRegistrasi", "registrasi", field, value)

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

            loaddata(idselect)
            showCPPT(idselect, 1, Nothing)
            btnAllDPJP.Text = "SEMUA CPPT"
        End If
    End Sub

    Private Sub showCPPT(Optional idrm As String = "0", Optional isdeleted As Long = 0, Optional tanggal As Object = Nothing)
        'DPJP
        If tanggal Is Nothing Then tanggal = nowTime
        Dim sqls As New SQLs(dbstring)

        If isdeleted = 1 Then
            sqls.DMLQuery("select case when tt.iddepartment in (select value from sys_appsetting where variable in('IDICUDept','IDICCUDept','IDHCUDept')) then 'OK' else 'NOT' end as cekdept,reg.registrasino,dp.idsoapnote,dp.idparamediscreator,dp.idspesialiscreator,dp.paramediscreatortype,pa.nama as paramedis,ps.nama as spesialis,dt.generalcode as dpjptype,sd.generalcode as statdata,dp.planning,dt.priority as dpjpprioritas,dp.isdeleted,case when pt.idreff=1 then isnull(pa.nama,0) + isnull(' (' + ps.nama + ')' ,'') + case when dp.reviewedby is null then ' - Belum Direview' else ' - Sudah Direview' end + char(13) + char(10) + 'sebagai ' + dt.generalcode + ' ' + convert(varchar,dp.createddate,105) + ' ' + convert(varchar,dp.createddate,108) + char(13) + char(10) + 'S: ' + dp.subyektif + char(13) + char(10) + 'B: ' + dp.obyektif + char(13) + char(10) + 'A: ' + dp.asesmen + char(13) + char(10) + 'R: ' + dp.planning else isnull(pa.nama,0) + isnull(' (' + ps.nama + ')' ,'') + case when dp.reviewedby is null then ' - Belum Direview' else ' - Sudah Direview' end + char(13) + char(10) + 'sebagai ' + dt.generalcode + ' ' + convert(varchar,dp.createddate,105) + ' ' + convert(varchar,dp.createddate,108) + char(13) + char(10) + 'S: ' + dp.subyektif + char(13) + char(10) + 'O: ' + dp.obyektif + char(13) + char(10) + 'A: ' + dp.asesmen + char(13) + char(10) + 'P: ' + dp.planning end as note from soapnote dp left join registrasi reg on dp.idregistrasi=reg.idregistrasi left join transactiontype tt on dp.transactiontype=tt.idtransactiontype left join spesialis ps on dp.idspesialiscreator=ps.idspesialis left join paramedis pa on dp.idparamediscreator=pa.idparamedis left join sys_generalcode pt on pa.paramedistype=pt.idgeneral and pt.gctype='PARAMEDISTYPE' left join sys_generalcode dt on dp.paramediscreatortype=dt.idgeneral and dt.gctype='DPJPTYPE' left join sys_generalcode sd on dp.isdeleted=sd.idgeneral and sd.gctype='DELETE' where reg.idrekammedis='" & idrm & "' and convert(varchar,dp.soapnotedate,105)='" & Format(tanggal, "dd-MM-yyyy") & "' and dp.soapnotetype in (1,2,3,4) order by dp.createddate desc", "dpjp")
            'sqls.DMLQuery("select case when tt.iddepartment in (select value from sys_appsetting where variable in('IDICUDept','IDICCUDept','IDHCUDept')) then 'OK' else 'NOT' end as cekdept,dp.idsoapnote,dp.idparamediscreator,dp.idspesialiscreator,dp.paramediscreatortype,pa.nama as paramedis,ps.nama as spesialis,dt.generalcode as dpjptype,sd.generalcode as statdata,dp.planning,dt.priority as dpjpprioritas,dp.isdeleted,case when pt.idreff=1 then isnull(pa.nama,0) + isnull(' (' + ps.nama + ')' ,'') + case when dp.reviewedby is null then ' - Belum Direview' else ' - Sudah Direview' end + char(13) + char(10) + 'sebagai ' + dt.generalcode + ' ' + convert(varchar,dp.createddate,105) + ' ' + convert(varchar,dp.createddate,108) + char(13) + char(10) + 'S: ' + dp.subyektif + char(13) + char(10) + 'B: ' + dp.obyektif + char(13) + char(10) + 'A: ' + dp.asesmen + char(13) + char(10) + 'R: ' + dp.planning else isnull(pa.nama,0) + isnull(' (' + ps.nama + ')' ,'') + case when dp.reviewedby is null then ' - Belum Direview' else ' - Sudah Direview' end + char(13) + char(10) + 'sebagai ' + dt.generalcode + ' ' + convert(varchar,dp.createddate,105) + ' ' + convert(varchar,dp.createddate,108) + char(13) + char(10) + 'S: ' + dp.subyektif + char(13) + char(10) + 'O: ' + dp.obyektif + char(13) + char(10) + 'A: ' + dp.asesmen + char(13) + char(10) + 'P: ' + dp.planning end as note from soapnote dp left join transactiontype tt on dp.transactiontype=tt.idtransactiontype left join spesialis ps on dp.idspesialiscreator=ps.idspesialis left join paramedis pa on dp.idparamediscreator=pa.idparamedis left join sys_generalcode pt on pa.paramedistype=pt.idgeneral and pt.gctype='PARAMEDISTYPE' left join sys_generalcode dt on dp.paramediscreatortype=dt.idgeneral and dt.gctype='DPJPTYPE' left join sys_generalcode sd on dp.isdeleted=sd.idgeneral and sd.gctype='DELETE' where (dp.idregistrasi='" & idparent & "' or dp.idregistrasi='" & idreg & "') and dp.soapnotetype=4 order by dp.createddate desc", "dpjp")
        Else
            sqls.DMLQuery("select case when tt.iddepartment in (select value from sys_appsetting where variable in('IDICUDept','IDICCUDept','IDHCUDept')) then 'OK' else 'NOT' end as cekdept,reg.registrasino,dp.idsoapnote,dp.idparamediscreator,dp.idspesialiscreator,dp.paramediscreatortype,pa.nama as paramedis,ps.nama as spesialis,dt.generalcode as dpjptype,sd.generalcode as statdata,dp.planning,dt.priority as dpjpprioritas,dp.isdeleted,case when pt.idreff=1 then isnull(pa.nama,0) + isnull(' (' + ps.nama + ')' ,'') + case when dp.reviewedby is null then ' - Belum Direview' else ' - Sudah Direview' end + char(13) + char(10) + 'sebagai ' + dt.generalcode + ' ' + convert(varchar,dp.createddate,105) + ' ' + convert(varchar,dp.createddate,108) + char(13) + char(10) + 'S: ' + dp.subyektif + char(13) + char(10) + 'B: ' + dp.obyektif + char(13) + char(10) + 'A: ' + dp.asesmen + char(13) + char(10) + 'R: ' + dp.planning else isnull(pa.nama,0) + isnull(' (' + ps.nama + ')' ,'') + case when dp.reviewedby is null then ' - Belum Direview' else ' - Sudah Direview' end + char(13) + char(10) + 'sebagai ' + dt.generalcode + ' ' + convert(varchar,dp.createddate,105) + ' ' + convert(varchar,dp.createddate,108) + char(13) + char(10) + 'S: ' + dp.subyektif + char(13) + char(10) + 'O: ' + dp.obyektif + char(13) + char(10) + 'A: ' + dp.asesmen + char(13) + char(10) + 'P: ' + dp.planning end as note from soapnote dp left join registrasi reg on dp.idregistrasi=reg.idregistrasi left join transactiontype tt on dp.transactiontype=tt.idtransactiontype left join spesialis ps on dp.idspesialiscreator=ps.idspesialis left join paramedis pa on dp.idparamediscreator=pa.idparamedis left join sys_generalcode pt on pa.paramedistype=pt.idgeneral and pt.gctype='PARAMEDISTYPE' left join sys_generalcode dt on dp.paramediscreatortype=dt.idgeneral and dt.gctype='DPJPTYPE' left join sys_generalcode sd on dp.isdeleted=sd.idgeneral and sd.gctype='DELETE' where reg.idrekammedis='" & idrm & "' and convert(varchar,dp.soapnotedate,105)='" & Format(tanggal, "dd-MM-yyyy") & "' and dp.soapnotetype in (1,2,3,4) and dp.isdeleted=0 order by dp.createddate desc", "dpjp")
            '            sqls.DMLQuery("select case when tt.iddepartment in (select value from sys_appsetting where variable in('IDICUDept','IDICCUDept','IDHCUDept')) then 'OK' else 'NOT' end as cekdept,dp.idsoapnote,dp.idparamediscreator,dp.idspesialiscreator,dp.paramediscreatortype,pa.nama as paramedis,ps.nama as spesialis,dt.generalcode as dpjptype,sd.generalcode as statdata,dp.planning,dt.priority as dpjpprioritas,dp.isdeleted,case when pt.idreff=1 then isnull(pa.nama,0) + isnull(' (' + ps.nama + ')' ,'') + case when dp.reviewedby is null then ' - Belum Direview' else ' - Sudah Direview' end + char(13) + char(10) + 'sebagai ' + dt.generalcode + ' ' + convert(varchar,dp.createddate,105) + ' ' + convert(varchar,dp.createddate,108) + char(13) + char(10) + 'S: ' + dp.subyektif + char(13) + char(10) + 'B: ' + dp.obyektif + char(13) + char(10) + 'A: ' + dp.asesmen + char(13) + char(10) + 'R: ' + dp.planning else isnull(pa.nama,0) + isnull(' (' + ps.nama + ')' ,'') + case when dp.reviewedby is null then ' - Belum Direview' else ' - Sudah Direview' end + char(13) + char(10) + 'sebagai ' + dt.generalcode + ' ' + convert(varchar,dp.createddate,105) + ' ' + convert(varchar,dp.createddate,108) + char(13) + char(10) + 'S: ' + dp.subyektif + char(13) + char(10) + 'O: ' + dp.obyektif + char(13) + char(10) + 'A: ' + dp.asesmen + char(13) + char(10) + 'P: ' + dp.planning end as note from soapnote dp left join transactiontype tt on dp.transactiontype=tt.idtransactiontype left join spesialis ps on dp.idspesialiscreator=ps.idspesialis left join paramedis pa on dp.idparamediscreator=pa.idparamedis left join sys_generalcode pt on pa.paramedistype=pt.idgeneral and pt.gctype='PARAMEDISTYPE' left join sys_generalcode dt on dp.paramediscreatortype=dt.idgeneral and dt.gctype='DPJPTYPE' left join sys_generalcode sd on dp.isdeleted=sd.idgeneral and sd.gctype='DELETE' where (dp.idregistrasi='" & idparent & "' or dp.idregistrasi='" & idreg & "') and dp.soapnotetype=4 and dp.isdeleted=0 order by dp.createddate desc", "dpjp")
        End If
        gcDPJP.DataSource = sqls.dataTable("dpjp")
        gvDPJP.ExpandAllGroups()
        gvDPJP.BestFitColumns()
    End Sub

    Private Sub btnAllDPJP_Click(sender As Object, e As EventArgs) Handles btnAllDPJP.Click
        If btnAllDPJP.Text = "SEMUA CPPT" Then
            'showCPPT(idselect, 1)
            showCPPT(idselect, 1, Strdate2Date(lueTanggalCPPT.Text))
            btnAllDPJP.Text = "CPPT AKTIF"
        Else
            'showCPPT(idselect, 0)
            showCPPT(idselect, 0, Strdate2Date(lueTanggalCPPT.Text))
            btnAllDPJP.Text = "SEMUA CPPT"
        End If
    End Sub

    Private Sub btnRefreshCPPT_Click(sender As Object, e As EventArgs) Handles btnRefreshCPPT.Click
        If idselect = "-1" Then
            dizMsgbox("Rekam Medis belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        If btnAllDPJP.Text = "SEMUA DPJP" Then
            showCPPT(idselect, 1, Strdate2Date(lueTanggalCPPT.Text))
        Else
            showCPPT(idselect, 0, Strdate2Date(lueTanggalCPPT.Text))
        End If
    End Sub

    Private Sub frmCPPT_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        kosongkanIsian(tlpPasien)
        kosongkanIsian(tlpAlamat)
        baru()
    End Sub

    Private Sub btnHistoriPasien_Click(sender As Object, e As EventArgs) Handles btnHistoriPasien.Click
        If idselect = "-1" Then
            dizMsgbox("Rekam Medis belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        formTitle = ""
        Dim frmMon As New frmMonHistoriPasien(teNoRM.Tag)
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

    Private Sub btnInfoPasien_Click(sender As Object, e As EventArgs) Handles btnInfoPasien.Click
        If idselect = "-1" Then
            dizMsgbox("Rekam Medis belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        formTitle = ""
        Dim frminfopx As New frmInfoPasien(teNoRM.Tag)
        tambahChild(frminfopx)
        frminfopx.StartPosition = FormStartPosition.CenterScreen
        frminfopx.pMinimize.Enabled = False
        frminfopx.pMaximize.Enabled = False
        frminfopx.tlpForm.RowCount = 4
        frminfopx.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        frminfopx.ShowDialog(Me)
        formTitle = Me.lblTitle.Text
    End Sub

    Private Sub lueTanggalCPPT_EditValueChanged(sender As Object, e As EventArgs) Handles lueTanggalCPPT.EditValueChanged
        If lueTanggalCPPT.EditValue Is Nothing Then
            Exit Sub
        End If
        btnRefreshCPPT_Click(Me, Nothing)
    End Sub

    Private Sub teSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teSearch.KeyPress
        If teSearch.Text.Replace(" ", "") = "" Then Exit Sub
        If Asc(e.KeyChar) = 13 Then
            btnSearch_Click(btnSearch, Nothing)
        End If
    End Sub

End Class