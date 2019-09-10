Public Class frmReviewDirekturPPP
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

    Private Sub frmReviewPPP_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        tabPengeluaran.Text = "PENGELUARAN"
        tabPenerimaan.Text = "> PENERIMAAN <"
        xtcPenerimaanPengeluaran.SelectedTabPage = xtpPenerimaan
        tabPenerimaan.BackColor = Color.DarkGray
        tabPenerimaan_Click(tabPenerimaan, Nothing)

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idgeneral,generalcode from sys_generalcode where gctype='REJECT' and idgeneral<>-1", "status")
        rceStatus.DataSource = sqls.dataTable("status")
        rceStatus.DisplayMember = "generalcode"
        rceStatus.ValueMember = "idgeneral"

        rce2Status.DataSource = sqls.dataTable("status")
        rce2Status.DisplayMember = "generalcode"
        rce2Status.ValueMember = "idgeneral"
    End Sub

    Private Sub baru()
        kosongkanIsian(tlpField)
        kosongkanIsian(tlpUntuk)

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select dt.idaruspengajuandt,dt.idpengajuan,dt.jumlahuang,dt.keperluan,dt.nodokumen,dt.nomorurut,dt.posisidk,dt.idcoa,c.coa,dt.idunit from aruspengajuandt dt left join coa c on dt.idcoa=c.idcoa where dt.idaruspengajuandt=-1 and dt.posisidk=1", "penerimaan")
        sqls.DMLQuery("select dt.idaruspengajuandt,dt.idpengajuan,dt.jumlahuang,dt.keperluan,dt.nodokumen,dt.nomorurut,dt.posisidk,dt.idcoa,c.coa,dt.idunit from aruspengajuandt dt left join coa c on dt.idcoa=c.idcoa where dt.idaruspengajuandt=-1 and dt.posisidk=2", "pengeluaran")
        gcPenerimaanData.DataSource = sqls.dataTable("penerimaan")
        gcPengeluaranData.DataSource = sqls.dataTable("pengeluaran")
        idselect = ""
    End Sub

    Private staffid As String
    Private staffname As String
    Private levelid As String
    Private levelname As String
    Private deptid As String
    Private deptkd As String
    Private deptname As String
    Private idcoabank As String
    Private idselect As String
    Private saveDate As Date
    Private bdisetujui As Boolean = False
    Private iddisetujui As String
    Private namadisetujui As String
    Private jabatandisetujui As String
    Private deptdisetujui As String

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        baru()
        Dim mys As New SQLs(dbstring)
        mys.DMLQuery("select ''''+value+'''' as value from sys_appsetting where variable='IDDirekturUtama'", "level3")
        Dim iddirut As String = mys.getDataSet("level3", 0, "value")

        If usersuper = 1 Then
            Dim idlist As New List(Of String)
            For i As Integer = 0 To mys.getDataSet("level3") - 1
                idlist.Add(mys.getDataSet("level3", i, "value"))
            Next
            Dim selkary As New frmSelectKaryawanUnit()
            selkary.kary(idlist)
            tambahChild(selkary)
            If selkary.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If
            staffid = selkary.getID(0)

            mys.DMLQuery("select k.idstaff,k.nama,p.idposition,p.position,d.iddepartment,d.kode,d.department from staff k left join position p on k.idposition=p.idposition left join department d on k.iddepartment=d.iddepartment where k.idstaff='" & staffid & "'", "datakary")

            staffname = mys.getDataSet("datakary", 0, "nama")
            levelid = mys.getDataSet("datakary", 0, "idposition")
            levelname = mys.getDataSet("datakary", 0, "position")
            deptid = mys.getDataSet("datakary", 0, "iddepartment")
            deptkd = mys.getDataSet("datakary", 0, "kode")
            deptname = mys.getDataSet("datakary", 0, "department")
        Else
            Dim idkary As String = ""
            Dim idlist As New List(Of String)
            For i As Integer = 0 To mys.getDataSet("level3") - 1
                idlist.Add(mys.getDataSet("level3", i, "value"))
            Next
            For Each str As String In idlist
                idkary &= "'" & str & "'" & ","
            Next
            idkary = idkary.Remove(idkary.Length - 1, 1)
            mys.DMLQuery("select k.idstaff,k.nama,p.idposition,p.position,d.iddepartment,d.kode,d.department,k.idunit,un.unit from staff k left join unit un on k.idunit=un.idunit left join position p on k.idposition=p.idposition left join department d on k.iddepartment=d.iddepartment where k.idstaff in (" & idkary & ") and k.iduser='" & userid & "'", "getuser")

            If mys.getDataSet("getuser") > 0 Then
                mys.DMLQuery("select k.idstaff,k.nama,p.idposition,p.position,d.iddepartment,d.kode,d.department,k.idunit,un.unit from staff k left join unit un on k.idunit=un.idunit left join position p on k.idposition=p.idposition left join department d on k.iddepartment=d.iddepartment where k.iduser='" & userid & "'", "datakary")

                If mys.getDataSet("datakary") > 0 Then
                    staffid = mys.getDataSet("datakary", 0, "idstaff")
                    staffname = mys.getDataSet("datakary", 0, "nama")
                    levelid = mys.getDataSet("datakary", 0, "idposition")
                    levelname = mys.getDataSet("datakary", 0, "position")
                    deptid = mys.getDataSet("datakary", 0, "iddepartment")
                    deptkd = mys.getDataSet("datakary", 0, "kode")
                    deptname = mys.getDataSet("datakary", 0, "department")
                Else
                    dizMsgbox("User anda tidak terkait dengan data karyawan", dizMsgboxStyle.Peringatan, Me)
                    btnSave.Enabled = False
                    Exit Sub
                End If
            Else
                dizMsgbox("User anda tidak diijinkan menggunakan form ini", dizMsgboxStyle.Peringatan, Me)
                btnSave.Enabled = False
                Exit Sub
            End If
        End If

        mys.DMLQuery("select value from sys_appsetting where variable='IDDirekturKeuangan'", "dirkeu")
        If mys.getDataSet("dirkeu") > 0 Then
            bdisetujui = True
            mys.DMLQuery("select k.idstaff,k.nama,p.idposition,p.position,d.iddepartment,d.kode,d.department from staff k left join position p on k.idposition=p.idposition left join department d on k.iddepartment=d.iddepartment where k.idstaff='" & mys.getDataSet("dirkeu", 0, "value") & "'", "disetujui")
            iddisetujui = mys.getDataSet("disetujui", 0, "idstaff")
            namadisetujui = mys.getDataSet("disetujui", 0, "nama")
            jabatandisetujui = mys.getDataSet("disetujui", 0, "position")
            deptdisetujui = mys.getDataSet("disetujui", 0, "department")
        Else
            bdisetujui = False
        End If

        mys.DMLQuery("select ap.idaruspengajuan,ap.idbank,ba.bank,ap.noaruspengajuan, convert(varchar,ap.tanggalpemohon,105) +' '+ convert(varchar,ap.tanggalpemohon,108) as tanggalpemohon, ap.idpemohon,ap.namapemohon,ap.jabatanpemohon,ap.deptpemohon, isnull(dbt.jumlahuang,0) as totaldebet, isnull(kre.jumlahuang,0) as totalkredit from aruspengajuan ap left join bank ba on ap.idbank=ba.idbank left join sys_generalcode gc on ap.isdeleted=gc.idgeneral and gc.gctype='REJECT' left join (select ddt.idaruspengajuan,sum(isnull(ddt.jumlahuang,0)) as jumlahuang from aruspengajuandt ddt where ddt.posisidk=1 group by ddt.idaruspengajuan) dbt on ap.idaruspengajuan=dbt.idaruspengajuan left join (select kdt.idaruspengajuan,sum(isnull(kdt.jumlahuang,0)) as jumlahuang from aruspengajuandt kdt where kdt.posisidk=2 group by kdt.idaruspengajuan) kre on ap.idaruspengajuan=kre.idaruspengajuan where year(ap.tanggalpemohon)='" & nowTime.Year & "' and (isnull(ap.iddiketahui,'0')='0' or isnull(ap.iddiketahui,'-1')='-1') order by ap.tanggalpemohon desc", "data")
        Dim cari As New frmSearch(mys.dataSet, "data", "idaruspengajuan")
        tambahChild(cari)
        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            idselect = cari.GetIDSelectData

            mys.DMLQuery("select ap.idaruspengajuan,ap.idbank,ba.bank,ba.idcoa,ap.noaruspengajuan, convert(varchar,ap.tanggalpemohon,105) +' '+ convert(varchar,ap.tanggalpemohon,108) as tanggalpemohon, ap.idpemohon,ap.namapemohon,ap.jabatanpemohon,ap.deptpemohon, isnull(dbt.jumlahuang,0) as totaldebet, isnull(kre.jumlahuang,0) as totalkredit from aruspengajuan ap left join bank ba on ap.idbank=ba.idbank left join sys_generalcode gc on ap.isdeleted=gc.idgeneral and gc.gctype='REJECT' left join (select ddt.idaruspengajuan,sum(isnull(ddt.jumlahuang,0)) as jumlahuang from aruspengajuandt ddt where ddt.posisidk=1 group by ddt.idaruspengajuan) dbt on ap.idaruspengajuan=dbt.idaruspengajuan left join (select kdt.idaruspengajuan,sum(isnull(kdt.jumlahuang,0)) as jumlahuang from aruspengajuandt kdt where kdt.posisidk=2 group by kdt.idaruspengajuan) kre on ap.idaruspengajuan=kre.idaruspengajuan where ap.idaruspengajuan='" & idselect & "'", "getdata")

            idcoabank = mys.getDataSet("getdata", 0, "idcoa")
            tearuspengajuanNo.Text = mys.getDataSet("getdata", 0, "noaruspengajuan")
            saveDate = CDate(mys.getDataSet("getdata", 0, "tanggalpemohon"))
            teTanggal.Text = Format(CDate(mys.getDataSet("getdata", 0, "tanggalpemohon")), "dd-MM-yyyy HH:mm:ss")
            teBank.Text = mys.getDataSet("getdata", 0, "bank")
            seTotalPenerimaan.Value = mys.getDataSet("getdata", 0, "totalkredit")
            seTotalPengeluaran.Value = mys.getDataSet("getdata", 0, "totaldebet")
            ceCheck.EditValue = False

            mys.DMLQuery("select dt.idaruspengajuandt,dt.idpengajuan,dt.jumlahuang,dt.keperluan,dt.nodokumen,dt.nomorurut,dt.posisidk,0 as isdeleted,dt.deletereason,dt.idcoa,c.coa,dt.idunit from aruspengajuandt dt left join coa c on dt.idcoa=c.idcoa where dt.idaruspengajuan='" & idselect & "' and dt.posisidk=2 order by dt.idaruspengajuandt asc", "penerimaan")
            mys.DMLQuery("select dt.idaruspengajuandt,dt.idpengajuan,dt.jumlahuang,dt.keperluan,dt.nodokumen,dt.nomorurut,dt.posisidk,0 as isdeleted,dt.deletereason,dt.idcoa,c.coa,dt.idunit from aruspengajuandt dt left join coa c on dt.idcoa=c.idcoa where dt.idaruspengajuan='" & idselect & "' and dt.posisidk=1 order by dt.idaruspengajuandt asc", "pengeluaran")

            gcPenerimaanData.DataSource = mys.dataTable("penerimaan")
            gcPengeluaranData.DataSource = mys.dataTable("pengeluaran")
            If gvPenerimaanData.RowCount > gvPengeluaranData.RowCount Then
                tabPenerimaan_Click(tabPenerimaan, Nothing)
                tabPenerimaan.Enabled = True
                tabPengeluaran.Enabled = False
            Else
                tabPengeluaran_Click(tabPengeluaran, Nothing)
                tabPenerimaan.Enabled = False
                tabPengeluaran.Enabled = True
            End If
        Else
            baru()
            tabPenerimaan.Enabled = True
            tabPengeluaran.Enabled = True
        End If
    End Sub

    Private Sub ceReject_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ceReject.CheckedChanged
        If ceReject.EditValue = False Then
            teAlasan.Properties.ReadOnly = True
            teAlasan.BackColor = justRead
            teAlasan.Text = "-"

            For i As Integer = 0 To gvPenerimaanData.RowCount - 1
                Dim dr As DataRow = gvPenerimaanData.GetDataRow(i)
                dr("isdeleted") = 0
                dr("deletereason") = "-"
            Next
            For i As Integer = 0 To gvPengeluaranData.RowCount - 1
                Dim dr As DataRow = gvPengeluaranData.GetDataRow(i)
                dr("isdeleted") = 0
                dr("deletereason") = "-"
            Next
        Else
            teAlasan.Properties.ReadOnly = False
            teAlasan.BackColor = canWrite
            teAlasan.Text = "-"

            For i As Integer = 0 To gvPenerimaanData.RowCount - 1
                Dim dr As DataRow = gvPenerimaanData.GetDataRow(i)
                dr("isdeleted") = 1
                dr("deletereason") = "-"
            Next
            For i As Integer = 0 To gvPengeluaranData.RowCount - 1
                Dim dr As DataRow = gvPengeluaranData.GetDataRow(i)
                dr("isdeleted") = 1
                dr("deletereason") = "-"
            Next
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

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If idselect <> "" Then
            If ceCheck.EditValue = False Then
                dizMsgbox("Data Pengajuan belum direview", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If
            If (ceReject.EditValue = True And teAlasan.Text = "") Or (ceReject.EditValue = True And teAlasan.Text = "-") Then
                dizMsgbox("Jika reject, harus disertai alasan", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If
            Dim cekbool As Boolean
            cekbool = True
            For i As Integer = 0 To gvPenerimaanData.RowCount - 1
                Dim dr As DataRow = gvPenerimaanData.GetDataRow(i)
                If (dr("isdeleted") = 1 And dr("deletereason") = "-") Or (dr("isdeleted") = 1 And dr("deletereason") = "") Then
                    cekbool = False
                End If
                If cekbool = False Then
                    dizMsgbox("Harap Cek Tabel Penerimaan" & vbCrLf & "Jika reject, harus disertai alasan", dizMsgboxStyle.Peringatan, Me)
                    Exit Sub
                End If
            Next

            For i As Integer = 0 To gvPengeluaranData.RowCount - 1
                Dim dr As DataRow = gvPengeluaranData.GetDataRow(i)
                If (dr("isdeleted") = 1 And dr("deletereason") = "-") Or (dr("isdeleted") = 1 And dr("deletereason") = "") Then
                    cekbool = False
                End If
                If cekbool = False Then
                    dizMsgbox("Harap Cek Tabel Pengeluaran" & vbCrLf & "Jika reject, harus disertai alasan", dizMsgboxStyle.Peringatan, Me)
                    Exit Sub
                End If
            Next

            Dim loadScr As New frmLoading()
            splashClosed = False
            loadScr.Show(Me)
            loadScr.BringToFront()
            Application.DoEvents()
            Me.Cursor = Cursors.WaitCursor

            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            Dim issuccess As Boolean = True
            Dim dtset As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            Dim fjurnal As New List(Of String)
            Dim vjurnal As New List(Of Object)
            fjurnal.AddRange(New String() {"idjurnal", "idcompany", "idunit", "idcoalama", "idcoa", "idreff", "tablereff", "tanggaljurnal", "jumlahuang", "remarks", "nodokumen", "posisidk", "isdeleted", "createdby", "createddate", "idreff2", "tablereff2", "nobukti", "issystem", "jurnaltype"})
            If bdisetujui = False Then
                field.AddRange(New String() {"idaruspengajuan", "iddiketahui", "namadiketahui", "jabatandiketahui", "deptdiketahui", "tanggaldiketahui", "isdeleted", "deletereason"})
                value.AddRange(New Object() {idselect, staffid, staffname, levelname, deptname, nowTime, ceReject.EditValue, teAlasan.Text})
            Else
                field.AddRange(New String() {"idaruspengajuan", "iddiketahui", "namadiketahui", "jabatandiketahui", "deptdiketahui", "tanggaldiketahui", "namadisetujui", "jabatandisetujui", "deptdisetujui", "isdeleted", "deletereason"})
                value.AddRange(New Object() {idselect, staffid, staffname, levelname, deptname, nowTime, namadisetujui, jabatandisetujui, deptdisetujui, ceReject.EditValue, teAlasan.Text})
            End If

            issuccess = dtset.datasetSave("aruspengajuan", idselect, field, value, False)
            isiLog(userid, dbstring, field, value, "aruspengajuan")
            If issuccess = False Then
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If

            field.Clear()
            field.AddRange(New String() {"idaruspengajuandt", "isdeleted", "deletereason"})
            For i As Integer = 0 To gvPenerimaanData.RowCount - 1
                Dim idtmp As String = GenerateGUID()
                Dim dr As DataRow = gvPenerimaanData.GetDataRow(i)
                dtset = New dtsetSQLS(dbstring)
                value.Clear()
                value.AddRange(New Object() {dr("idaruspengajuandt"), dr("isdeleted"), dr("deletereason")})
                issuccess = dtset.datasetSave("aruspengajuandt", dr("idaruspengajuandt"), field, value, False)
                isiLog(userid, dbstring, field, value, "aruspengajuandt")
                If dr("isdeleted") = 0 Then
                    vjurnal.Clear()
                    vjurnal.AddRange(New Object() {idtmp, idcomp, dr("idunit"), dr("idcoa"), dr("idcoa"), dr("idaruspengajuandt"), "aruspengajuandt", saveDate, dr("jumlahuang"), dr("keperluan"), dr("nodokumen"), dr("posisidk"), 0, userid, nowTime, idselect, "aruspengajuan", tearuspengajuanNo.Text, 0, 1})
                    dtset.datasetSave("jurnal", idtmp, fjurnal, vjurnal, False)
                    isiLog(userid, dbstring, fjurnal, vjurnal, "jurnal")
                End If
                If issuccess = False Then
                    dizMsgbox("Data Penerimaan tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                    Exit Sub
                End If
            Next
            If gvPenerimaanData.RowCount > 0 Then
                'BALANCING PENERIMAAN 2 JADI 1
                Dim idtmp As String = GenerateGUID()
                dtset = New dtsetSQLS(dbstring)
                vjurnal.Clear()
                vjurnal.AddRange(New Object() {idtmp, idcomp, "-1", idcoabank, idcoabank, "-1", "AUTOPOST KREDIT", saveDate, seTotalPenerimaan.Value, "KAS (" & teBank.Text & ")", "-", 1, 0, userid, nowTime, idselect, "aruspengajuan", tearuspengajuanNo.Text, 1, 1})
                dtset.datasetSave("jurnal", idtmp, fjurnal, vjurnal, False)
            End If

            For i As Integer = 0 To gvPengeluaranData.RowCount - 1
                Dim idtmp As String = GenerateGUID()
                Dim dr As DataRow = gvPengeluaranData.GetDataRow(i)
                dtset = New dtsetSQLS(dbstring)
                value.Clear()
                value.AddRange(New Object() {dr("idaruspengajuandt"), dr("isdeleted"), dr("deletereason")})
                issuccess = dtset.datasetSave("aruspengajuandt", dr("idaruspengajuandt"), field, value, False)
                isiLog(userid, dbstring, field, value, "aruspengajuandt")
                If dr("isdeleted") = 0 Then
                    vjurnal.Clear()
                    vjurnal.AddRange(New Object() {idtmp, idcomp, dr("idunit"), dr("idcoa"), dr("idcoa"), dr("idaruspengajuandt"), "aruspengajuandt", saveDate, dr("jumlahuang"), dr("keperluan"), dr("nodokumen"), dr("posisidk"), 0, userid, nowTime, idselect, "aruspengajuan", tearuspengajuanNo.Text, 0, 1})
                    dtset.datasetSave("jurnal", idtmp, fjurnal, vjurnal, False)
                    isiLog(userid, dbstring, fjurnal, vjurnal, "jurnal")
                End If
                If issuccess = False Then
                    dizMsgbox("Data Pengeluaran tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                    Exit Sub
                End If
            Next
            If gvPengeluaranData.RowCount > 0 Then
                'BALANCING PENGELUARAN 1 JADI 2
                Dim idtmp As String = GenerateGUID()
                dtset = New dtsetSQLS(dbstring)
                vjurnal.Clear()
                vjurnal.AddRange(New Object() {idtmp, idcomp, "-1", idcoabank, idcoabank, "-1", "AUTOPOST KREDIT", saveDate, seTotalPengeluaran.Value, "KAS (" & teBank.Text & ")", "-", 2, 0, userid, nowTime, idselect, "aruspengajuan", tearuspengajuanNo.Text, 1, 1})
                dtset.datasetSave("jurnal", idtmp, fjurnal, vjurnal, False)
            End If

            If issuccess = True Then
                Dim updppp As New SQLs(dbstring)
                updppp.DMLQuery("select distinct(idreff2) as idreff2,tablereff2 from jurnal where tablereff2='aruspengajuan' and year(tanggaljurnal)='" & nowTime.Year & "'", "jur")
                For i As Integer = 0 To updppp.getDataSet("jur") - 1
                    Dim dr As DataRow = updppp.dataTable("jur").Rows(i)
                    updppp.DMLQuery("update jurnal set nobukti=(select noaruspengajuan from aruspengajuan where idaruspengajuan='" & dr("idreff2") & "') where idreff2='" & dr("idreff2") & "'", False)
                Next

                Me.Cursor = Cursors.Default
                splashClosed = True

                dizMsgbox("Data Penerimaan Pengeluaran Uang Bank berhasil direview", dizMsgboxStyle.Info, Me)
                frmReviewPPP_Load(Me, Nothing)
                baru()
            Else
                Me.Cursor = Cursors.Default
                splashClosed = True
            End If
        Else
            dizMsgbox("Data belum dipilih", dizMsgboxStyle.Peringatan, Me)
        End If
    End Sub

    Private Sub teAlasan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teAlasan.EditValueChanged
        If ceReject.EditValue = True Then
            For i As Integer = 0 To gvPenerimaanData.RowCount - 1
                Dim dr As DataRow = gvPenerimaanData.GetDataRow(i)
                dr("deletereason") = teAlasan.Text
            Next
            For i As Integer = 0 To gvPengeluaranData.RowCount - 1
                Dim dr As DataRow = gvPengeluaranData.GetDataRow(i)
                dr("deletereason") = teAlasan.Text
            Next
        End If
    End Sub

End Class