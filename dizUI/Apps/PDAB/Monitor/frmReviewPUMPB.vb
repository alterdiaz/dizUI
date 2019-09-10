Public Class frmReviewPUMPB
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

    Private idselect As String = ""
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim mys As New SQLs(dbstring)
        If usersuper = 1 Then
            Dim iddept As New List(Of String)
            iddept.AddRange(New String() {"*"})
            Dim idpost As New List(Of String)
            idpost.AddRange(New String() {"'785A28E2-C4C2-4B54-893D-D9DDE21536E9'"})

            Dim selkary As New frmSelectKaryawan2()
            'selkary.deptpost(iddept, idpost)
            tambahChild(selkary)
            If selkary.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If
            staffid = String.Join(",", selkary.getID)

            mys.DMLQuery("select k.idstaff,k.nama,p.idposition,p.position,d.iddepartment,d.kode,d.department,k.idunit,un.unit from staff k left join unit un on k.idunit=un.idunit left join position p on k.idposition=p.idposition left join department d on k.iddepartment=d.iddepartment where k.idstaff='" & staffid & "'", "datakary")

            staffname = mys.getDataSet("datakary", 0, "nama")
            levelid = mys.getDataSet("datakary", 0, "idposition")
            levelname = mys.getDataSet("datakary", 0, "position")
            deptid = mys.getDataSet("datakary", 0, "iddepartment")
            deptkd = mys.getDataSet("datakary", 0, "kode")
            deptname = mys.getDataSet("datakary", 0, "department")
            unitid = mys.getDataSet("datakary", 0, "idunit")
            unitname = mys.getDataSet("datakary", 0, "unit")

            teNamaAtasan.Text = staffname
            teJabatanAtasan.Text = levelname
        Else
            mys.DMLQuery("select k.idstaff,k.nama,p.idposition,p.position,d.iddepartment,d.kode,d.department,k.idunit,un.unit from staff k left join unit un on k.idunit=un.idunit left join position p on k.idposition=p.idposition left join department d on k.iddepartment=d.iddepartment where k.iduser='" & userid & "'", "datakary")

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

                teNamaAtasan.Text = staffname
                teJabatanAtasan.Text = levelname
            Else
                dizMsgbox("User anda tidak terkait dengan data karyawan", dizMsgboxStyle.Peringatan, Me)
                btnSave.Enabled = False
                Exit Sub
            End If
        End If

        Dim idanak As String = ""
        If usersuper = 1 Then
            mys.DMLQuery("select ''''+idstaff+'''' as idstaff from staff where iddepartment in(select iddepartment from department)", "anak")
        Else
            mys.DMLQuery("select ''''+idstaff+'''' as idstaff from staff where iddepartment in(select iddepartment from department where idparent=(select iddepartment from staff where iduser='" & userid & "'))", "anak")
        End If
        For i As Integer = 0 To mys.getDataSet("anak") - 1
            idanak &= mys.getDataSet("anak", i, "idstaff")
            If i <> mys.getDataSet("anak") - 1 Then
                idanak &= ","
            End If
        Next

        If idanak.Length = 0 Then
            mys.DMLQuery("select p.idpengajuan, p.nopengajuan, convert(varchar,p.tanggalpengajuan,105) + ' ' + convert(varchar,p.tanggalpengajuan,108) as tanggalpengajuan, p.idpemohon, p.namapemohon, p.jabatanpemohon, p.deptpemohon, un.unit, p.jumlahuang, p.keperluan from pengajuan p left join unit un on p.idunitpemohon=un.idunit where convert(varchar,p.tanggalpengajuan,105) like '%" & nowTime.Year & "' and p.isreviewed=0 order by p.tanggalpengajuan desc", "data")
        Else
            mys.DMLQuery("select p.idpengajuan, p.nopengajuan, convert(varchar,p.tanggalpengajuan,105) + ' ' + convert(varchar,p.tanggalpengajuan,108) as tanggalpengajuan, p.idpemohon, p.namapemohon, p.jabatanpemohon, p.deptpemohon, un.unit, p.jumlahuang, p.keperluan from pengajuan p left join unit un on p.idunitpemohon=un.idunit where p.idpemohon in (" & idanak & ") and convert(varchar,p.tanggalpengajuan,105) like '%" & nowTime.Year & "' and p.isreviewed=0 order by p.tanggalpengajuan desc", "data")
        End If
        Dim cari As New frmSearch(mys.dataSet, "data", "idpengajuan")
        tambahChild(cari)
        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            idselect = cari.GetIDSelectData
            mys.DMLQuery("select p.nopengajuan,isnull(p.idcoa,0) as idcoa,p.tanggalpengajuan,p.jumlahuang,p.hurufuang,p.idpemohon,s.nama as pemohon,p.jabatanpemohon,p.keperluan,un.unit from pengajuan p left join unit un on p.idunitpemohon=un.idunit left join staff s on p.idpemohon=s.idstaff where p.idpengajuan='" & idselect & "'", "getdata")

            tePengajuanNo.Text = mys.getDataSet("getdata", 0, "nopengajuan")
            deTanggal.EditValue = CDate(mys.getDataSet("getdata", 0, "tanggalpengajuan"))
            nudJumlahUang.EditValue = mys.getDataSet("getdata", 0, "jumlahuang")
            teHurufUang.Text = mys.getDataSet("getdata", 0, "hurufuang")
            meUntuk.Text = mys.getDataSet("getdata", 0, "keperluan")
            teNamaPemohon.Tag = mys.getDataSet("getdata", 0, "idpemohon")
            teNamaPemohon.Text = mys.getDataSet("getdata", 0, "pemohon")
            teJabatanPemohon.Text = mys.getDataSet("getdata", 0, "jabatanpemohon")
            ceCheck.EditValue = False
            coaid = mys.getDataSet("getdata", 0, "idcoa")

            Dim strquery As String = "select c.idcoa,c.coa,c.remarks,isnull(angjur.sisaang,0) as sisaang from coa c left join (select a.idcoa,a.jumlahuang-isnull(jur.saldo,0) as sisaang from anggaran a left join ( select j.idcoa, dbt.totaldbt-krd.totalkrd as saldo from jurnal j left join (select idcoa,convert(varchar,tanggaljurnal,121) as periode, sum(jumlahuang) as totaldbt from jurnal where convert(varchar,tanggaljurnal,121) like 'PERIODEFORMAT%' isdeleted=0 and posisidk=1 and idcoa=IDCOASELECT group by convert(varchar,tanggaljurnal,121), idcoa ) dbt on j.idcoa=dbt.idcoa left join ( select idcoa,convert(varchar,tanggaljurnal,121) as periode, sum(jumlahuang) as totalkrd from jurnal where convert(varchar,tanggaljurnal,121) like 'PERIODEFORMAT%' and isdeleted=0 and posisidk=2 and idcoa=IDCOASELECT group by convert(varchar,tanggaljurnal,121), idcoa ) krd on j.idcoa=krd.idcoa group by j.idcoa,dbt.totaldbt,krd.totalkrd ) jur on a.idcoa=jur.idcoa where ((len(a.periode)=4 and a.periode='YEARFORMAT') or (len(a.periode)=7 and a.periode = 'PERIODEFORMAT')) ) angjur on c.idcoa=angjur.idcoa where c.idcoa=IDCOASELECT"
            strquery = strquery.Replace("IDCOASELECT", coaid)
            strquery = strquery.Replace("PERIODEFORMAT", Format(CDate(deTanggal.EditValue), "yyyy-MM"))
            strquery = strquery.Replace("YEARFORMAT", Format(CDate(deTanggal.EditValue), "yyyy"))
            mys.DMLQuery(strquery, "ang")

            teCOA.Text = mys.getDataSet("ang", 0, "coa")
            teRemarks.Text = mys.getDataSet("ang", 0, "remarks")
            seSisaAnggaran.Value = mys.getDataSet("ang", 0, "sisaang")
        Else
            baru()
        End If
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
    Private coaid As String

    Private Sub baru()
        kosongkanIsian(tlpField)
        kosongkanIsian(tlpHuruf)
        kosongkanIsian(tlpPemohon)
        kosongkanIsian(tlpUntuk)
        kosongkanIsian(tlpMengetahui)
        tePengajuanNo.Text = "UM" & Format(nowTime, "yyyy") & "-xxxx"
        teHurufUang.Text = "nol rupiah"
        idselect = ""
    End Sub

    Private Sub frmReviewPUMPB_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        checkFieldMaxLength(dbstring, tlpField, "pengajuan")
        checkFieldMaxLength(dbstring, tlpHuruf, "pengajuan")
        checkFieldMaxLength(dbstring, tlpPemohon, "pengajuan")
        checkFieldMaxLength(dbstring, tlpUntuk, "pengajuan")
        checkFieldMaxLength(dbstring, tlpMengetahui, "pengajuan")
        baru()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If idselect <> "" Then
            If ceCheck.EditValue = False Then
                dizMsgbox("Data Pengajuan belum direview", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If
            If (ceReject.EditValue = True And teAlasan.Text = "") Or (ceReject.EditValue = True And teAlasan.Text = "-") Then
                dizMsgbox("Jika reject, harus disertai alasan", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If

            Dim loadScr As New frmLoading()
            splashClosed = False
            loadScr.Show(Me)
            loadScr.BringToFront()
            Application.DoEvents()
            Me.Cursor = Cursors.WaitCursor

            Dim dtmy As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idpengajuan", "idunitreview", "idreview", "namareview", "jabatanreview", "deptreview", "tanggalreview", "isreviewed", "isdeleted", "rejectreason"})
            If ceReject.EditValue = False Then
                value.AddRange(New Object() {idselect, unitid, staffid, staffname, levelname, deptname, nowTime, 1, 0, "-"})
            Else
                value.AddRange(New Object() {idselect, unitid, staffid, staffname, levelname, deptname, nowTime, 1, 1, teAlasan.Text})
            End If
            dtmy.datasetSave("pengajuan", idselect, field, value, False)
            isiLog(userid, dbstring, field, value, "pengajuan")

            Me.Cursor = Cursors.Default
            splashClosed = True

            dizMsgbox("Pengajuan sudah direview", dizMsgboxStyle.Info, Me)
            baru()
        Else
            Me.Cursor = Cursors.Default
            splashClosed = True
            dizMsgbox("Data Pengajuan belum dipilih", dizMsgboxStyle.Peringatan, Me)
        End If
    End Sub

    Private Sub ceReject_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ceReject.CheckedChanged
        If ceReject.EditValue = False Then
            teAlasan.Properties.ReadOnly = True
            teAlasan.BackColor = justRead
            teAlasan.Text = "-"
        Else
            teAlasan.Properties.ReadOnly = False
            teAlasan.BackColor = canWrite
        End If
    End Sub

End Class