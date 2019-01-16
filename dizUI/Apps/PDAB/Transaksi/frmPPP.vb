Public Class frmPPP
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

    Private Sub tabPenerimaan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabPenerimaan.Click
        tabPengeluaran.Text = "PENGELUARAN"
        tabPenerimaan.Text = "> PENERIMAAN <"
        xtcPenerimaanPengeluaran.SelectedTabPage = xtpPenerimaan
        xtpPengeluaran.Hide()
        tabPenerimaan.BackColor = Color.DarkGray
        tabPenerimaan.ForeColor = Color.White
        tabPengeluaran.BackColor = Color.FromArgb(80, 0, 0)
        tabPengeluaran.ForeColor = Color.White
    End Sub

    Private Sub tabPengeluaran_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabPengeluaran.Click
        tabPengeluaran.Text = "> PENGELUARAN <"
        tabPenerimaan.Text = "PENERIMAAN"
        xtcPenerimaanPengeluaran.SelectedTabPage = xtpPengeluaran
        xtpPenerimaan.Hide()
        tabPenerimaan.BackColor = Color.FromArgb(80, 0, 0)
        tabPenerimaan.ForeColor = Color.White
        tabPengeluaran.BackColor = Color.DarkGray
        tabPengeluaran.ForeColor = Color.White
    End Sub

    Private dtKeluar As New DataSet
    Private dtMasuk As New DataSet
    Private Sub frmPengajuanPenerimaanPengeluaran_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        deTanggal.Properties.MinValue = New Date(nowTime.Year, 1, 1)
        deTanggal.Properties.MaxValue = New Date(nowTime.Year, 12, 31)

        Dim ds As New DataSet
        Dim dttbl As New DataTable("jenis")
        Dim dc As New DataColumn
        dc.Caption = "ID"
        dc.ColumnName = "id"
        dc.DataType = GetType(Integer)

        dttbl.Columns.Add(dc)
        dc = New DataColumn
        dc.Caption = "Jenis Transaksi"
        dc.ColumnName = "content"
        dc.DataType = GetType(String)
        dttbl.Columns.Add(dc)

        Dim dr As DataRow = dttbl.NewRow
        dr("id") = 1
        dr("content") = "Penerimaan"
        dttbl.Rows.Add(dr)

        dr = dttbl.NewRow
        dr("id") = 2
        dr("content") = "Pengeluaran"
        dttbl.Rows.Add(dr)
        ds.Tables.Add(dttbl)

        lueJenis.Properties.DataSource = ds.Tables("jenis")
        lueJenis.Properties.ValueMember = "id"
        lueJenis.Properties.DisplayMember = "content"

        tabPenerimaan_Click(tabPenerimaan, Nothing)
        'tabPengeluaran.Text = "PENGELUARAN"
        'tabPenerimaan.Text = "> PENERIMAAN"
        'xtcPenerimaanPengeluaran.SelectedTabPage = xtpPenerimaan
        'tabPenerimaan.BackColor = Color.DarkGray

        dbstring = readSettingFile()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select dt.idaruspengajuandt,dt.idpengajuan,dt.idcoa,'' as coa,dt.idunit,dt.jumlahuang,dt.keperluan,dt.nodokumen,dt.nomorurut,dt.posisidk from aruspengajuandt dt where dt.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and dt.idaruspengajuandt=-1 and dt.posisidk='DEBET'", "penerimaan")
        sqls.DMLQuery("select dt.idaruspengajuandt,dt.idpengajuan,dt.idcoa,'' as coa,dt.idunit,dt.jumlahuang,dt.keperluan,dt.nodokumen,dt.nomorurut,dt.posisidk from aruspengajuandt dt where dt.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and dt.idaruspengajuandt=-1 and dt.posisidk='KREDIT'", "pengeluaran")
        dtMasuk = sqls.dataSet
        dtKeluar = sqls.dataSet
        gcPenerimaanData.DataSource = dtMasuk.Tables("penerimaan")
        gcPengeluaranData.DataSource = dtKeluar.Tables("pengeluaran")

        sqls.DMLQuery("select idcoa, coa, remarks from coa where isdeleted=0", "coa")
        lueCOA.Properties.DataSource = sqls.dataTable("coa")
        lueCOA.Properties.DisplayMember = "coa"
        lueCOA.Properties.ValueMember = "idcoa"

        modCore.kosongkanIsian(tlpField)
        modCore.kosongkanIsian(tlpPenerimaan1)
        modCore.kosongkanIsian(tlpPenerimaan2)
        modCore.kosongkanIsian(tlpPengeluaran1)
        modCore.kosongkanIsian(tlpPengeluaran2)
        tearuspengajuanNo.Text = "PP" & Format(nowTime, "yyyy") & "/XXXX"
        modCore.checkFieldMaxLength(dbstring, tlpField, "aruspengajuan")

        btnNew_Click(btnNew, Nothing)
    End Sub

    Private staffid As String
    Private staffname As String
    Private levelid As String
    Private levelname As String
    Private deptid As String
    Private deptkd As String
    Private deptname As String
    Private unitid As String
    Private unitname As String

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        staffid = "-1"
        xtpPenerimaan.PageEnabled = False
        xtpPengeluaran.PageEnabled = False
        btnSave.Enabled = False
        lueJenis.Enabled = False
        lueBank.Properties.DataSource = Nothing
        lueBank.EditValue = Nothing

        modCore.kosongkanIsian(tlpField)
        modCore.kosongkanIsian(tlpPenerimaan1)
        modCore.kosongkanIsian(tlpPenerimaan2)
        modCore.kosongkanIsian(tlpPengeluaran1)
        modCore.kosongkanIsian(tlpPengeluaran2)
        tearuspengajuanNo.Text = "PPX" & Format(nowTime, "yyyy") & "/XXXX"

        Dim mys As New SQLs(dbstring)
        mys.DMLQuery("select value from sys_appsetting where variable='PPUBKas' or variable='PPUBNonKas' order by variable asc", "level1")
        Dim idusrkas As String = mys.getDataSet("level1", 0, "value")
        Dim idusrnonkas As String = mys.getDataSet("level1", 1, "value")
        mys.DMLQuery("select value from sys_appsetting where variable='IDBankKas'", "idbankkas")
        Dim idkas As String = mys.getDataSet("idbankkas", 0, "value")

        If usersuper = 1 Then
            Dim idlist As New List(Of String)
            For i As Integer = 0 To mys.getDataSet("level1") - 1
                idlist.Add(mys.getDataSet("level1", i, "value"))
            Next
            Dim selkary As New frmSelectKaryawan()
            selkary.dept(idlist)
            tambahChild(selkary)
            If selkary.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If
            staffid = String.Join(",", selkary.getID)

            mys.DMLQuery("select k.idstaff,k.nama,p.idposition,p.position,d.iddepartment,d.kode,d.department,k.idunit,un.unit from staff k left join unit un on k.idunit=un.idunit and un.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join position p on k.idposition=p.idposition and p.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join department d on k.iddepartment=d.iddepartment and d.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and k.idstaff='" & staffid & "'", "datakary")

            staffname = mys.getDataSet("datakary", 0, "nama")
            levelid = mys.getDataSet("datakary", 0, "idposition")
            levelname = mys.getDataSet("datakary", 0, "position")
            deptid = mys.getDataSet("datakary", 0, "iddepartment")
            deptkd = mys.getDataSet("datakary", 0, "kode")
            deptname = mys.getDataSet("datakary", 0, "department")
            unitid = mys.getDataSet("datakary", 0, "idunit")
            unitname = mys.getDataSet("datakary", 0, "unit")

            If staffid = idusrkas Then
                mys.DMLQuery("select b.idbank,b.bank,b.norekening,b.remarks from bank b where b.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isnull(b.isdeleted,0)=0 and isnull(b.idcoa,-1)<>'-1' and b.idbank='" & idkas & "'", "bank")
            ElseIf staffid = idusrnonkas Then
                mys.DMLQuery("select b.idbank,b.bank,b.norekening,b.remarks from bank b where b.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isnull(b.isdeleted,0)=0 and isnull(b.idcoa,-1)<>'-1' and b.idbank<>'" & idkas & "'", "bank")
            End If
            lueBank.Properties.DataSource = mys.dataTable("bank")
            lueBank.Properties.ValueMember = "idbank"
            lueBank.Properties.DisplayMember = "bank"
            lueBank.EditValue = Nothing
            btnSave.Enabled = True
            lueJenis.Enabled = True
        Else
            Dim idkary As String = ""
            Dim idlist As New List(Of String)
            For i As Integer = 0 To mys.getDataSet("level1") - 1
                idlist.Add(mys.getDataSet("level1", i, "value"))
            Next
            For Each str As String In idlist
                idkary &= "'" & str & "'" & ","
            Next
            idkary = idkary.Remove(idkary.Length - 1, 1)
            mys.DMLQuery("select k.idstaff,k.nama,p.idposition,p.position,d.iddepartment,d.kode,d.department,k.idunit,un.unit from staff k left join unit un on k.idunit=un.idunit and un.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join position p on k.idposition=p.idposition and p.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join department d on k.iddepartment=d.iddepartment and d.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and p.positiontype in (1,2) and k.idstaff in (" & idkary & ") and k.iduser='" & userid & "'", "getuser")

            If mys.getDataSet("getuser") > 0 Then
                mys.DMLQuery("select k.idstaff,k.nama,p.idposition,p.position,d.iddepartment,d.kode,d.department,k.idunit,un.unit from staff k left join unit un on k.idunit=un.idunit and un.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join position p on k.idposition=p.idposition and p.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join department d on k.iddepartment=d.iddepartment and d.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and p.positiontype in (1,2) and k.iduser='" & userid & "'", "datakary")

                If mys.getDataSet("datakary") > 0 Then
                    staffid = mys.getDataSet("datakary", 0, "idstaff")
                    staffname = mys.getDataSet("datakary", 0, "nama")
                    levelid = mys.getDataSet("datakary", 0, "idposition")
                    levelname = mys.getDataSet("datakary", 0, "position")
                    deptid = mys.getDataSet("datakary", 0, "iddepartment")
                    deptkd = mys.getDataSet("datakary", 0, "kode")
                    deptname = mys.getDataSet("datakary", 0, "department")
                    unitid = mys.getDataSet("datakary", 0, "idunit")
                    unitname = mys.getDataSet("datakary", 0, "unit")

                    If staffid = idusrkas Then
                        mys.DMLQuery("select b.idbank,b.bank,b.norekening,b.remarks from bank b where b.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isnull(b.isdeleted,0)=0 and isnull(b.idcoa,-1)<>'-1' and b.idbank='" & idkas & "'", "bank")
                    ElseIf staffid = idusrnonkas Then
                        mys.DMLQuery("select b.idbank,b.bank,b.norekening,b.remarks from bank b where b.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isnull(b.isdeleted,0)=0 and isnull(b.idcoa,-1)<>'-1' and b.idbank<>'" & idkas & "'", "bank")
                    End If
                    lueBank.Properties.DataSource = mys.dataTable("bank")
                    lueBank.Properties.ValueMember = "idbank"
                    lueBank.Properties.DisplayMember = "bank"
                    lueBank.EditValue = Nothing
                    btnSave.Enabled = True
                    lueJenis.Enabled = True
                Else
                    dizMsgbox("User anda tidak terkait dengan data karyawan", dizMsgboxStyle.Peringatan, Me)
                    btnSave.Enabled = False
                    lueJenis.Enabled = False
                    pExit_Click(pExit, Nothing)
                    Exit Sub
                End If
            Else
                dizMsgbox("User anda tidak diijinkan menggunakan form ini", dizMsgboxStyle.Peringatan, Me)
                btnSave.Enabled = False
                lueJenis.Enabled = False
                pExit_Click(pExit, Nothing)
                Exit Sub
            End If
        End If
        deTanggal.Properties.MinValue = New Date(nowTime.Year, 1, 1)
        deTanggal.Properties.MaxValue = New Date(nowTime.Year, 12, 31)
    End Sub

    Private Sub btnPenerimaanBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPenerimaanBaru.Click
        modCore.kosongkanIsian(tlpPenerimaan1)
        modCore.kosongkanIsian(tlpPenerimaan2)
        tePenerimaanNoDokumen.Focus()
    End Sub

    Dim idselect As String = ""
    Private Sub btnPengeluaranBaru()
        idselect = ""
        modCore.kosongkanIsian(tlpPengeluaran1)
        modCore.kosongkanIsian(tlpPengeluaran2)
    End Sub

    Private Sub btnPengeluaranSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPengeluaranSearch.Click
        btnPengeluaranBaru()

        If lueBank.EditValue Is Nothing Then
            dizMsgbox("Belum memilih Bank", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select value from sys_appsetting where variable='IDBankKas'", "idbankkas")
        Dim idkas As String = sqls.getDataSet("idbankkas", 0, "value")
        If lueBank.EditValue IsNot Nothing Then
            If lueBank.EditValue = idkas Then
                sqls.DMLQuery("select p.idpengajuan, p.nopengajuan, convert(varchar,p.tanggalpengajuan,105) + ' ' + convert(varchar,p.tanggalpengajuan,108) as tanggalpengajuan, p.idpemohon, p.namapemohon, p.jabatanpemohon, p.deptpemohon, un.unit, p.jumlahuang, p.keperluan, p.idreview, p.namareview, p.jabatanreview, p.deptreview from pengajuan p left join unit un on p.idunitpemohon=un.idunit and un.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where p.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and convert(varchar,p.tanggalpengajuan,105) like '%" & nowTime.Year & "' and p.tipepengajuan=1 and p.isreviewed=1 and isnull(p.isdeleted,0)=0 and isnull(p.idkabid,-1)<>-1 and p.idpengajuan not in (select dt.idpengajuan from aruspengajuandt dt) order by p.tanggalpengajuan asc", "cari")
            Else
                sqls.DMLQuery("select p.idpengajuan, p.nopengajuan, convert(varchar,p.tanggalpengajuan,105) + ' ' + convert(varchar,p.tanggalpengajuan,108) as tanggalpengajuan, p.idpemohon, p.namapemohon, p.jabatanpemohon, p.deptpemohon, un.unit, p.jumlahuang, p.keperluan, p.idreview, p.namareview, p.jabatanreview, p.deptreview from pengajuan p left join unit un on p.idunitpemohon=un.idunit and un.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where p.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and convert(varchar,p.tanggalpengajuan,105) like '%" & nowTime.Year & "' and p.tipepengajuan=2 and p.isreviewed=1 and isnull(p.isdeleted,0)=0 and isnull(p.idkabid,-1)<>-1 and p.idpengajuan not in (select dt.idpengajuan from aruspengajuandt dt) order by p.tanggalpengajuan asc", "cari")
            End If
        Else
            sqls.DMLQuery("select p.idpengajuan, p.nopengajuan, convert(varchar,p.tanggalpengajuan,105) + ' ' + convert(varchar,p.tanggalpengajuan,108) as tanggalpengajuan, p.idpemohon, p.namapemohon, p.jabatanpemohon, p.deptpemohon, un.unit, p.jumlahuang, p.keperluan, p.idreview, p.namareview, p.jabatanreview, p.deptreview from pengajuan p left join unit un on p.idunitpemohon=un.idunit and un.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where p.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and convert(varchar,p.tanggalpengajuan,105) like '%" & nowTime.Year & "' and p.tipepengajuan=2 and p.isreviewed=1 and isnull(p.isdeleted,0)=0 and isnull(p.idkabid,-1)<>-1 and p.idpengajuan not in (select dt.idpengajuan from aruspengajuandt dt) order by p.tanggalpengajuan asc", "cari")
        End If
        Dim cari As New frmSearch(sqls.dataSet, "cari", "idpengajuan")
        tambahChild(cari)
        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim cekdt As DataTable = gcPengeluaranData.DataSource
            If cekdt.Select("idpengajuan='" & cari.GetIDSelectData & "'").Length > 0 Then
                dizMsgbox("Data Pengajuan ini sudah dicantumkan", dizMsgboxStyle.Peringatan, Me)
            Else
                idselect = cari.GetIDSelectData
                sqls.DMLQuery("select p.idpengajuan, p.idcoa, c.coa, p.idunitpemohon, p.nopengajuan, convert(varchar,p.tanggalpengajuan,105) + ' ' + convert(varchar,p.tanggalpengajuan,108) as tanggalpengajuan, p.idpemohon, p.namapemohon, p.jabatanpemohon, p.deptpemohon, p.jumlahuang, p.keperluan, p.idreview, p.namareview, p.jabatanreview, p.deptreview from pengajuan p left join coa c on p.idcoa=c.idcoa and c.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where p.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and p.idpengajuan='" & idselect & "'", "hasilcari")

                tePengeluaranKeperluan.Text = sqls.getDataSet("hasilcari", 0, "keperluan")
                tePengeluaranNoDokumen.Text = ""
                tePengeluaranNoDokumen.Tag = sqls.getDataSet("hasilcari", 0, "coa")
                tePengeluaranNoUMPB.Text = sqls.getDataSet("hasilcari", 0, "nopengajuan")
                tePengeluaranNoUMPB.Tag = sqls.getDataSet("hasilcari", 0, "idcoa")
                tePengeluaranTanggalUMPB.Text = sqls.getDataSet("hasilcari", 0, "tanggalpengajuan")
                tePengeluaranTanggalUMPB.Tag = sqls.getDataSet("hasilcari", 0, "idunitpemohon")
                sePengeluaranUang.Value = CDec(sqls.getDataSet("hasilcari", 0, "jumlahuang"))
                tePengeluaranNoDokumen.Focus()
            End If
        End If
    End Sub

    Private Sub btnPengeluaranSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPengeluaranSave.Click
        If idselect = "" Then
            dizMsgbox("Belum memilih data pengajuan", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If tePengeluaranNoDokumen.Text = "" Then
            dizMsgbox("Belum mengisi No Dokumen", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim dr As DataRow = dtKeluar.Tables("pengeluaran").NewRow
        dr("idaruspengajuandt") = -1
        dr("idpengajuan") = idselect
        dr("idcoa") = tePengeluaranNoUMPB.Tag
        dr("coa") = tePengeluaranNoDokumen.Tag
        dr("idunit") = tePengeluaranTanggalUMPB.Tag
        dr("jumlahuang") = sePengeluaranUang.Value
        dr("keperluan") = tePengeluaranKeperluan.Text
        dr("nodokumen") = IIf(tePengeluaranNoDokumen.Text = "", "-", tePengeluaranNoDokumen.Text)
        dr("nomorurut") = gvPengeluaranData.RowCount + 1
        dr("posisidk") = 1
        dtKeluar.Tables("pengeluaran").Rows.Add(dr)
        gcPengeluaranData.DataSource = dtKeluar.Tables("pengeluaran")
        gvPengeluaranData.BestFitColumns()
        seTotalPengeluaran.Value = CLng(gckJumlahUang.SummaryText)

        btnPengeluaranBaru()
    End Sub

    Private Sub btnPenerimaanSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPenerimaanSave.Click
        Dim cekval As Boolean = True
        If tePenerimaanKeperluan.Text = "" Then
            cekval = False
        End If
        If tePenerimaanNoDokumen.Text = "" Then
            cekval = False
        End If
        If sePenerimaanUang.Value = 0 Then
            cekval = False
        End If
        'If lueCOA.EditValue Is Nothing Then
        '    cekval = False
        'End If
        If cekval = False Then
            dizMsgbox("Belum mengisi data penerimaan", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idcoa,coa from coa where coa='-1'", "coa")
        Dim dr As DataRow = dtMasuk.Tables("penerimaan").NewRow
        dr("idaruspengajuandt") = -1
        dr("idpengajuan") = -1
        dr("idcoa") = sqls.dataTable("coa").Rows(0).Item("idcoa")
        dr("coa") = sqls.dataTable("coa").Rows(0).Item("coa")
        dr("idunit") = unitid
        dr("jumlahuang") = sePenerimaanUang.Value
        dr("keperluan") = tePenerimaanKeperluan.Text
        dr("nodokumen") = tePenerimaanNoDokumen.Text
        dr("nomorurut") = gvPenerimaanData.RowCount + 1
        dr("posisidk") = 2
        dtMasuk.Tables("penerimaan").Rows.Add(dr)
        gcPenerimaanData.DataSource = dtMasuk.Tables("penerimaan")
        gvPenerimaanData.BestFitColumns()
        seTotalPenerimaan.Value = CLng(gctJumlahUang.SummaryText)

        btnPenerimaanBaru_Click(btnPenerimaanBaru, Nothing)
    End Sub

    'Private Function generateNO(ByVal prefix As String) As String
    '    Dim retval As String = ""
    '    Dim mysqls As New SQLs(dbstring)
    '    Dim tblname As String = "ArusPengajuan" & prefix & Format(nowTime, "yyyy")
    '    mysqls.DMLQuery("select idgeneratenumber,tablename,formatstring,lastnumber,positionnumber,digitnumber from sys_generatenumber where tablename='" & tblname & prefix & "'", "GetLast")
    '    Dim idgen As Integer = -1
    '    Dim formatStr As String = ""
    '    Dim currid As Integer = 0
    '    Dim currStrId As String = ""
    '    Dim posnumber As String = ""
    '    Dim lenStr As String = ""
    '    Dim lenId As Integer = 0

    '    If mysqls.getDataSet("GetLast") = 0 Then
    '        formatStr = "PP" & prefix & Format(nowTime, "yyyy") & "/"
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

    Private bdiketahui As Boolean = False
    Private iddiketahui As String
    Private namadiketahui As String
    Private jabatandiketahui As String
    Private deptdiketahui As String

    Private bdisetujui As Boolean = False
    Private iddisetujui As String
    Private namadisetujui As String
    Private jabatandisetujui As String
    Private deptdisetujui As String

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If dizMsgbox("Tanggal pengajuan : " & Format(deTanggal.EditValue, "dd-MM-yyyy") & vbCrLf & "Apakah tanggal sudah benar ?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then

            Dim iskosong As Boolean = False
            If checkEntry(tlpField) = False Then
                dizMsgbox("Isian belum benar", dizMsgboxStyle.Peringatan, Me)
                iskosong = True
            End If
            If lueJenis.EditValue = 1 Then
                If gvPenerimaanData.RowCount = 0 And iskosong = False Then
                    If dizMsgbox("Transaksi Penerimaan belum diisi. Melanjutkan penyimpanan data?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
                        iskosong = True
                    End If
                End If
            End If
            If lueJenis.EditValue = 2 Then
                If gvPengeluaranData.RowCount = 0 And iskosong = False Then
                    If dizMsgbox("Transaksi Pengeluaran belum diisi. Melanjutkan penyimpanan data?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
                        iskosong = True
                    End If
                End If
            End If
            If staffid = "-1" Then
                iskosong = True
            End If
            If iskosong = True Then
                Exit Sub
            End If

            Dim loadScr As New frmLoading()
            splashClosed = False
            loadScr.Show(Me)
            loadScr.BringToFront()
            Application.DoEvents()
            Me.Cursor = Cursors.WaitCursor

            Dim issuccess As Boolean = True
            Dim sqls As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            Dim noaruspengajuan As String
            If lueJenis.EditValue = CLng(2) Then
                noaruspengajuan = generateno3("PP", "K", "yyyy", False)
            Else
                noaruspengajuan = generateno3("PP", "M", "yyyy", False)
            End If

            Dim cekkas As New SQLs(dbstring)
            cekkas.DMLQuery("select value from sys_appsetting where variable='IDBankKas'", "cekkas")
            Dim idkasval As String = ""
            If cekkas.getDataSet("cekkas") > 0 Then
                idkasval = cekkas.getDataSet("cekkas", 0, "value")
            End If

            Dim mys As New SQLs(dbstring)
            If idkasval <> "" Then
                If lueBank.EditValue = idkasval Then
                    mys.DMLQuery("select idstaff as value from staff where nik='SYSTEM'", "getidsys")
                    If mys.getDataSet("getidsys") > 0 Then
                        bdiketahui = True
                        mys.DMLQuery("select k.idstaff,k.nama,p.idposition,p.position,d.iddepartment,d.kode,d.department from staff k left join position p on k.idposition=p.idposition and p.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join department d on k.iddepartment=d.iddepartment and d.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and k.idstaff='" & mys.getDataSet("getidsys", 0, "value") & "'", "diketahui")
                        iddiketahui = mys.getDataSet("diketahui", 0, "idstaff")
                        namadiketahui = mys.getDataSet("diketahui", 0, "nama")
                        jabatandiketahui = mys.getDataSet("diketahui", 0, "position")
                        deptdiketahui = mys.getDataSet("diketahui", 0, "department")
                    End If

                    mys.DMLQuery("select value from sys_appsetting where variable='IDKabidKeuangan'", "kabidkeu")
                    If mys.getDataSet("kabidkeu") > 0 Then
                        bdisetujui = True
                        mys.DMLQuery("select k.idstaff,k.nama,p.idposition,p.position,d.iddepartment,d.kode,d.department from staff k left join position p on k.idposition=p.idposition and p.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join department d on k.iddepartment=d.iddepartment and d.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and k.idstaff='" & mys.getDataSet("kabidkeu", 0, "value") & "'", "disetujui")
                        iddisetujui = mys.getDataSet("disetujui", 0, "idstaff")
                        namadisetujui = mys.getDataSet("disetujui", 0, "nama")
                        jabatandisetujui = mys.getDataSet("disetujui", 0, "position")
                        deptdisetujui = mys.getDataSet("disetujui", 0, "department")
                    End If
                Else
                    mys.DMLQuery("select value from sys_appsetting where variable='IDDirekturUtama'", "dirut")
                    If mys.getDataSet("dirut") > 0 Then
                        bdiketahui = True
                        mys.DMLQuery("select k.idstaff,k.nama,p.idposition,p.position,d.iddepartment,d.kode,d.department from staff k left join position p on k.idposition=p.idposition and p.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join department d on k.iddepartment=d.iddepartment and d.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and k.idstaff='" & mys.getDataSet("dirut", 0, "value") & "'", "diketahui")
                        iddiketahui = mys.getDataSet("diketahui", 0, "idstaff")
                        namadiketahui = mys.getDataSet("diketahui", 0, "nama")
                        jabatandiketahui = mys.getDataSet("diketahui", 0, "position")
                        deptdiketahui = mys.getDataSet("diketahui", 0, "department")
                    End If

                    mys.DMLQuery("select value from sys_appsetting where variable='IDDirekturKeuangan'", "dirkeu")
                    If mys.getDataSet("dirkeu") > 0 Then
                        bdisetujui = True
                        mys.DMLQuery("select k.idstaff,k.nama,p.idposition,p.position,d.iddepartment,d.kode,d.department from staff k left join position p on k.idposition=p.idposition and p.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join department d on k.iddepartment=d.iddepartment and d.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and k.idstaff='" & mys.getDataSet("dirkeu", 0, "value") & "'", "disetujui")
                        iddisetujui = mys.getDataSet("disetujui", 0, "idstaff")
                        namadisetujui = mys.getDataSet("disetujui", 0, "nama")
                        jabatandisetujui = mys.getDataSet("disetujui", 0, "position")
                        deptdisetujui = mys.getDataSet("disetujui", 0, "department")
                    End If
                End If
            Else
                mys.DMLQuery("select value from sys_appsetting where variable='IDDirekturUtama'", "dirut")
                If mys.getDataSet("dirut") > 0 Then
                    bdiketahui = True
                    mys.DMLQuery("select k.idstaff,k.nama,p.idposition,p.position,d.iddepartment,d.kode,d.department from staff k left join position p on k.idposition=p.idposition left join department d on k.iddepartment=d.iddepartment where k.idstaff='" & mys.getDataSet("dirut", 0, "value") & "'", "diketahui")
                    iddiketahui = mys.getDataSet("diketahui", 0, "idstaff")
                    namadiketahui = mys.getDataSet("diketahui", 0, "nama")
                    jabatandiketahui = mys.getDataSet("diketahui", 0, "position")
                    deptdiketahui = mys.getDataSet("diketahui", 0, "department")
                End If

                mys.DMLQuery("select value from sys_appsetting where variable='IDDirekturKeuangan'", "dirkeu")
                If mys.getDataSet("dirkeu") > 0 Then
                    bdisetujui = True
                    mys.DMLQuery("select k.idstaff,k.nama,p.idposition,p.position,d.iddepartment,d.kode,d.department from staff k left join position p on k.idposition=p.idposition and p.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join department d on k.iddepartment=d.iddepartment and d.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and k.idstaff='" & mys.getDataSet("dirkeu", 0, "value") & "'", "disetujui")
                    iddisetujui = mys.getDataSet("disetujui", 0, "idstaff")
                    namadisetujui = mys.getDataSet("disetujui", 0, "nama")
                    jabatandisetujui = mys.getDataSet("disetujui", 0, "position")
                    deptdisetujui = mys.getDataSet("disetujui", 0, "department")
                End If
            End If

            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")
            Dim iddata As String = GenerateGUID()

            If bdiketahui = False And bdisetujui = False Then
                field.AddRange(New String() {"idaruspengajuan", "idcompany", "idbank", "noaruspengajuan", "idpemohon", "namapemohon", "jabatanpemohon", "deptpemohon", "tanggalpemohon", "isdeleted", "deletereason"})
                value.AddRange(New Object() {iddata, idcomp, lueBank.EditValue, noaruspengajuan, staffid, staffname, levelname, deptname, CDate(deTanggal.EditValue), 0, "-"})
            ElseIf bdiketahui = False And bdisetujui = True Then
                field.AddRange(New String() {"idaruspengajuan", "idcompany", "idbank", "noaruspengajuan", "idpemohon", "namapemohon", "jabatanpemohon", "deptpemohon", "tanggalpemohon", "namadisetujui", "jabatandisetujui", "deptdisetujui", "isdeleted", "deletereason"})
                value.AddRange(New Object() {iddata, idcomp, lueBank.EditValue, noaruspengajuan, staffid, staffname, levelname, deptname, CDate(deTanggal.EditValue), namadisetujui, jabatandisetujui, deptdisetujui, 0, "-"})
            ElseIf bdiketahui = True And bdisetujui = True Then
                field.AddRange(New String() {"idaruspengajuan", "idcompany", "idbank", "noaruspengajuan", "idpemohon", "namapemohon", "jabatanpemohon", "deptpemohon", "tanggalpemohon", "namadisetujui", "jabatandisetujui", "deptdisetujui", "namadiketahui", "jabatandiketahui", "deptdiketahui", "isdeleted", "deletereason"})
                value.AddRange(New Object() {iddata, idcomp, lueBank.EditValue, noaruspengajuan, staffid, staffname, levelname, deptname, CDate(deTanggal.EditValue), namadisetujui, jabatandisetujui, deptdisetujui, namadiketahui, jabatandiketahui, deptdiketahui, 0, "-"})
            End If
            issuccess = sqls.datasetSave("aruspengajuan", iddata, field, value, False)
            isiLog(userid, dbstring, field, value, "aruspengajuan")
            If issuccess = False Then
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If

            'sqls.DMLQuery("select idaruspengajuan from aruspengajuan where idunique='" & hashunique & "'", "cekhash")
            'Dim iddata As String = sqls.dataTable("cekhash").Rows(0).Item("idaruspengajuan")
            field = New List(Of String)
            field.AddRange(New String() {"idaruspengajuandt", "idcompany", "idaruspengajuan", "idbank", "idpengajuan", "idunit", "idcoa", "nomorurut", "keperluan", "nodokumen", "jumlahuang", "posisidk", "isdeleted", "deletereason"})
            For i As Integer = 0 To gvPenerimaanData.RowCount - 1
                Dim idtmp As String = GenerateGUID()
                Dim dr As DataRow = gvPenerimaanData.GetDataRow(i)
                sqls = New dtsetSQLS(dbstring)
                value = New List(Of Object)
                value.AddRange(New Object() {idtmp, idcomp, iddata, lueBank.EditValue, dr("idpengajuan"), dr("idunit"), dr("idcoa"), dr("nomorurut"), dr("keperluan"), dr("nodokumen"), dr("jumlahuang"), dr("posisidk"), 0, "-"})
                issuccess = sqls.datasetSave("aruspengajuandt", idtmp, field, value, False)
                isiLog(userid, dbstring, field, value, "aruspengajuandt")
                If issuccess = False Then
                    dizMsgbox("Data Penerimaan tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                    Exit Sub
                End If
            Next
            For i As Integer = 0 To gvPengeluaranData.RowCount - 1
                Dim idtmp As String = GenerateGUID()
                Dim dr As DataRow = gvPengeluaranData.GetDataRow(i)
                sqls = New dtsetSQLS(dbstring)
                value = New List(Of Object)
                value.AddRange(New Object() {idtmp, idcomp, iddata, lueBank.EditValue, dr("idpengajuan"), dr("idunit"), dr("idcoa"), dr("nomorurut"), dr("keperluan"), dr("nodokumen"), dr("jumlahuang"), dr("posisidk"), 0, "-"})
                issuccess = sqls.datasetSave("aruspengajuandt", idtmp, field, value, False)
                isiLog(userid, dbstring, field, value, "aruspengajuandt")
                If issuccess = False Then
                    dizMsgbox("Data Pengeluaran tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                    Exit Sub
                End If
            Next
            If issuccess = True Then
                dizMsgbox("Data Penerimaan Pengeluaran Uang Bank berhasil disimpan", dizMsgboxStyle.Info, Me)

                Dim recall As New clsRenumberingDtSN
                recall.calculate(Format(deTanggal.EditValue, "yyyy"))

                'Dim hdrecall As New clsRenumberingDocument
                Dim hdrecall As New clsRenumberingArusPengajuan
                If lueJenis.EditValue = 1 Then
                    'hdrecall.calculate("ArusPengajuan", "M", CDate(deTanggal.EditValue).Year, "PPM" & CDate(deTanggal.EditValue).Year & "/", "noaruspengajuan", "idaruspengajuan", "tanggalpemohon", "Belakang", 4)
                    hdrecall.calculate(CDate(deTanggal.EditValue).Year, "M")
                Else
                    'hdrecall.calculate("ArusPengajuan", "K", CDate(deTanggal.EditValue).Year, "PPK" & CDate(deTanggal.EditValue).Year & "/", "noaruspengajuan", "idaruspengajuan", "tanggalpemohon", "Belakang", 4)
                    hdrecall.calculate(CDate(deTanggal.EditValue).Year, "K")
                End If

                Dim updppp As New SQLs(dbstring)
                updppp.DMLQuery("select distinct(idreff2) as idreff2,tbreff2 from jurnal where tbreff2='aruspengajuan' and year(tanggaljurnal)='" & CDate(deTanggal.EditValue).Year & "'", "jur")
                For i As Integer = 0 To updppp.getDataSet("jur") - 1
                    Dim dr As DataRow = updppp.dataTable("jur").Rows(i)
                    updppp.DMLQuery("update jurnal set nobukti=(select noaruspengajuan from aruspengajuan where idaruspengajuan='" & dr("idreff2") & "') where idreff2='" & dr("idreff2") & "'", False)
                Next

                Me.Cursor = Cursors.Default
                splashClosed = True

                frmPengajuanPenerimaanPengeluaran_Load(Me, Nothing)
            End If

            Me.Cursor = Cursors.Default
            splashClosed = True
        End If
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler gcPenerimaanData.EmbeddedNavigator.ButtonClick, AddressOf gvPenerimaanNavigator_ButtonClick
        AddHandler gcPengeluaranData.EmbeddedNavigator.ButtonClick, AddressOf gvPengeluaranNavigator_ButtonClick
    End Sub

    Private Sub gvPenerimaanNavigator_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Remove Then
            If dizMsgbox("Apakah akan menghapus penerimaan ini ?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
                e.Handled = True

                For i As Integer = 0 To dtMasuk.Tables("penerimaan").Rows.Count - 1
                    Dim dr As DataRow = dtMasuk.Tables("penerimaan").Rows(i)
                    dr("nomorurut") = i + 1
                Next
                gvPenerimaanData.RefreshData()
            End If
        End If
    End Sub

    Private Sub gvPengeluaranNavigator_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Remove Then
            If dizMsgbox("Apakah akan menghapus pengeluaran ini ?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
                e.Handled = True

                For i As Integer = 0 To dtKeluar.Tables("pengeluaran").Rows.Count - 1
                    Dim dr As DataRow = dtKeluar.Tables("pengeluaran").Rows(i)
                    dr("nomorurut") = i + 1
                Next
                gvPengeluaranData.RefreshData()
            End If
        End If
    End Sub

    Private Sub lueBank_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueBank.EditValueChanged
        If lueBank.EditValue Is Nothing Then
            xtpPenerimaan.PageEnabled = False
            xtpPengeluaran.PageEnabled = False
            Exit Sub
        End If
        'xtpPenerimaan.PageEnabled = True
        'xtpPengeluaran.PageEnabled = True

        'Dim sqls As New SQLs(dbstring)
        'SQLs.DMLQuery("select dt.idaruspengajuandt,dt.idpengajuan,dt.idcoa,'' as coa,dt.idunit,dt.jumlahuang,dt.keperluan,dt.nodokumen,dt.nomorurut,dt.posisidk from aruspengajuandt dt where dt.idaruspengajuandt=-1 and dt.posisidk='DEBET'", "penerimaan")
        'SQLs.DMLQuery("select dt.idaruspengajuandt,dt.idpengajuan,dt.idcoa,'' as coa,dt.idunit,dt.jumlahuang,dt.keperluan,dt.nodokumen,dt.nomorurut,dt.posisidk from aruspengajuandt dt where dt.idaruspengajuandt=-1 and dt.posisidk='KREDIT'", "pengeluaran")
        'dtMasuk = SQLs.dataSet
        'dtKeluar = SQLs.dataSet
        'gcPenerimaanData.DataSource = dtMasuk.Tables("penerimaan")
        'gcPengeluaranData.DataSource = dtKeluar.Tables("pengeluaran")

        lueJenis.EditValue = 1
    End Sub

    Private Sub lueJenis_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueJenis.EditValueChanged
        If lueJenis.EditValue = 1 Then
            xtpPenerimaan.PageEnabled = True
            xtpPengeluaran.PageEnabled = False

            tabPenerimaan_Click(tabPenerimaan, Nothing)

            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select dt.idaruspengajuandt,dt.idpengajuan,dt.idcoa,'' as coa,dt.idunit,dt.jumlahuang,dt.keperluan,dt.nodokumen,dt.nomorurut,dt.posisidk from aruspengajuandt dt where dt.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and dt.idaruspengajuandt=-1 and dt.posisidk='DEBET'", "penerimaan")
            dtMasuk = sqls.dataSet
            gcPenerimaanData.DataSource = dtMasuk.Tables("penerimaan")
            tearuspengajuanNo.Text = "PPM" & Format(nowTime, "yyyy") & "/XXXX"
            seTotalPenerimaan.Value = 0
            seTotalPengeluaran.Value = 0
        ElseIf lueJenis.EditValue = 2 Then
            xtpPenerimaan.PageEnabled = False
            xtpPengeluaran.PageEnabled = True

            tabPengeluaran_Click(tabPengeluaran, Nothing)

            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select dt.idaruspengajuandt,dt.idpengajuan,dt.idcoa,'' as coa,dt.idunit,dt.jumlahuang,dt.keperluan,dt.nodokumen,dt.nomorurut,dt.posisidk from aruspengajuandt dt where dt.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and dt.idaruspengajuandt=-1 and dt.posisidk='KREDIT'", "pengeluaran")
            dtKeluar = sqls.dataSet
            gcPengeluaranData.DataSource = dtKeluar.Tables("pengeluaran")
            tearuspengajuanNo.Text = "PPK" & Format(nowTime, "yyyy") & "/XXXX"
            seTotalPenerimaan.Value = 0
            seTotalPengeluaran.Value = 0
        End If
    End Sub

End Class