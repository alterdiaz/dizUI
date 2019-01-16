Public Class frmInternalPUMPB
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

    'Private Function generateNO() As String
    '    Dim retval As String = ""
    '    Dim mysqls As New SQLs(dbstring)
    '    Dim tblname As String = "Pengajuan" & Format(nowTime, "yyyy")
    '    mysqls.DMLQuery("select idgeneratenumber,tablename,formatstring,lastnumber,positionnumber,digitnumber from sys_generatenumber where tablename='" & tblname & "'", "GetLast")
    '    Dim idgen As Integer = -1
    '    Dim formatStr As String = ""
    '    Dim currid As Integer = 0
    '    Dim currStrId As String = ""
    '    Dim posnumber As String = ""
    '    Dim lenStr As String = ""
    '    Dim lenId As Integer = 0

    '    If mysqls.getDataSet("GetLast") = 0 Then
    '        formatStr = "UM" & Format(nowTime, "yyyy") & "/"
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
    '    'retval = "SPB/" & codeDept & "/" & Format(nowTime, "MM") & "/" & Format(nowTime, "yyyy").Remove(0, 2) & "/"
    '    'Dim cnt As Integer = CInt(loadSingleData("count(nospb)", "nospb like '" & retval & "%'", "spb"))
    '    'retval = retval & Format(cnt + 1, "0##")
    'End Function

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        unitid = "-1"
        lueKategori.EditValue = Nothing
        slueCOA.EditValue = Nothing
        kosongkanIsian(tlpField)
        kosongkanIsian(tlpHuruf)
        kosongkanIsian(tlpPemohon)
        kosongkanIsian(tlpUntuk)
        kosongkanIsian(tlpMengetahui)
        tePengajuanNo.Text = "UM" & Format(nowTime, "yyyy") & "/XXXX"
        teHurufUang.Text = "nol rupiah"

        If usersuper = 1 Then
            Dim iddept As New List(Of String)
            iddept.AddRange(New String() {"*"})
            Dim iddeptexcept As New List(Of String)
            iddeptexcept.AddRange(New String() {55})

            Dim selkary As New frmSelectKaryawan()
            selkary.deptdeptexceptpost(iddept, iddeptexcept, 1)
            tambahChild(selkary)
            If selkary.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If
            staffid = String.Join(",", selkary.getID)

            Dim mys As New SQLs(dbstring)
            mys.DMLQuery("select k.idstaff,k.nama,p.idposition,p.position,d.iddepartment,d.kode,d.department,k.idunit,un.unit from staff k left join unit un on k.idunit=un.idunit and un.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join position p on k.idposition=p.idposition and p.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and left join department d on k.iddepartment=d.iddepartment and d.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where k.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and k.idstaff='" & staffid & "'", "datakary")

            staffname = mys.getDataSet("datakary", 0, "nama")
            levelid = mys.getDataSet("datakary", 0, "idposition")
            levelname = mys.getDataSet("datakary", 0, "position")
            deptid = mys.getDataSet("datakary", 0, "iddepartment")
            deptkd = mys.getDataSet("datakary", 0, "kode")
            deptname = mys.getDataSet("datakary", 0, "department")
            unitid = mys.getDataSet("datakary", 0, "idunit")
            unitname = mys.getDataSet("datakary", 0, "unit")

            teNamaPemohon.Text = staffname
            teJabatanPemohon.Text = unitname
        Else
            Dim mys As New SQLs(dbstring)
            mys.DMLQuery("select k.idstaff,k.nama,p.idposition,p.position,d.iddepartment,d.kode,d.department,k.idunit,un.unit from staff k left join unit un on k.idunit=un.idunit and un.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join position p on k.idposition=p.idposition and p.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') left join department d on k.iddepartment=d.iddepartment and d.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where p.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and p.positiontype=1 and k.iduser='" & userid & "'", "datakary")

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

                teNamaPemohon.Text = staffname
                teJabatanPemohon.Text = unitname

                Dim pair As KeyValuePair(Of String, String) = generateno2(unitid, deptid, "Pengajuan Int", True)
                Dim idtrans As String = pair.Key
                Dim notrans As String = pair.Value
                tePengajuanNo.Text = notrans
            Else
                dizMsgbox("User anda tidak terkait dengan data karyawan", dizMsgboxStyle.Peringatan, Me)
                btnSave.Enabled = False
                Exit Sub
            End If
        End If

        deTanggal.Properties.MinValue = New Date(nowTime.Year, 1, 1)
        deTanggal.Properties.MaxValue = New Date(nowTime.Year, 12, 31)

        'generateNO()
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

    Private Sub frmInternalUMPB_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        deTanggal.Properties.MinValue = New Date(nowTime.Year, 1, 1)
        deTanggal.Properties.MaxValue = New Date(nowTime.Year, 12, 31)

        checkFieldMaxLength(dbstring, tlpField, "pengajuan")
        checkFieldMaxLength(dbstring, tlpHuruf, "pengajuan")
        checkFieldMaxLength(dbstring, tlpPemohon, "pengajuan")
        checkFieldMaxLength(dbstring, tlpUntuk, "pengajuan")
        checkFieldMaxLength(dbstring, tlpMengetahui, "pengajuan")
        meUntuk.Properties.MaxLength = 4800

        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select idkategoriuntuk, kategoriuntuk from kategoriuntuk where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isnull(isdeleted,0)=0", "kategoriuntuk")
        lueKategori.Properties.DataSource = mysqls.dataTable("kategoriuntuk")
        lueKategori.Properties.DisplayMember = "kategoriuntuk"
        lueKategori.Properties.ValueMember = "idkategoriuntuk"
        If mysqls.getDataSet("kategoriuntuk") = 0 Then
            dizMsgbox("Kategori Pengajuan tidak ditemukan" & vbCrLf & "Kategori Pengajuan harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idcoa, coa, remarks from coa where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and len(convert(decimal(20,0),COA))>=3 and (isnull(isdeleted,0)=0 or coa<>'-1') order by convert(varchar(20),COA) asc", "coa")
        slueCOA.Properties.DataSource = mysqls.dataTable("coa")
        slueCOA.Properties.DisplayMember = "coa"
        slueCOA.Properties.ValueMember = "idcoa"
        slueCOA.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

        btnNew_Click(btnNew, Nothing)
    End Sub

    Private Sub nudJumlahUang_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudJumlahUang.EditValueChanged
        If nudJumlahUang.Value = 0 Then
            teHurufUang.Text = "nol rupiah"
        Else
            teHurufUang.Text = Terbilang(nudJumlahUang.Value) & " rupiah"
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If dizMsgbox("Tanggal pengajuan : " & Format(deTanggal.EditValue, "dd-MM-yyyy") & vbCrLf & "Apakah tanggal sudah benar ?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.OK Then
            Dim isKosong As Boolean = False
            If deTanggal.EditValue Is Nothing Then
                isKosong = True
            End If
            If nudJumlahUang.Value = 0 Then
                isKosong = True
            End If
            If meUntuk.Text = "" Then
                isKosong = True
            End If
            If meUntuk.EditValue Is Nothing Then
                isKosong = True
            End If
            If lueKategori.EditValue Is Nothing Then
                isKosong = True
            End If
            If slueCOA.EditValue Is Nothing Then
                isKosong = True
            End If
            If unitid = "-1" Then
                isKosong = True
            End If

            If isKosong = True Then
                dizMsgbox("Isian belum benar", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If
            If meUntuk.Text = "SALDO AWAL" Then
                dizMsgbox("Untuk tidak boleh SALDO AWAL", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If

            Dim loadScr As New frmLoading()
            splashClosed = False
            loadScr.Show(Me)
            loadScr.BringToFront()
            Application.DoEvents()
            Me.Cursor = Cursors.WaitCursor

            Dim pair As KeyValuePair(Of String, String) = generateno2(unitid, deptid, "Pengajuan Int", True)
            Dim idtrans As String = pair.Key
            Dim notrans As String = pair.Value

            tePengajuanNo.Text = notrans

            Dim mys As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)

            Dim sqls As New SQLs(dbstring)
            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")
            Dim idtmp As String = GenerateGUID()

            field.AddRange(New String() {"idpengajuan", "idcompany", "idcoa", "nopengajuan", "tanggalpengajuan", "jumlahuang", "hurufuang", "keperluan", "idpemohon", "idunitpemohon", "namapemohon", "jabatanpemohon", "deptpemohon", "isdeleted", "isreviewed", "rejectreason", "tipepengajuan"})
            value.AddRange(New Object() {idtmp, idcomp, slueCOA.EditValue, tePengajuanNo.Text, CDate(deTanggal.EditValue), nudJumlahUang.Value, teHurufUang.Text, "( " & lueKategori.Text & " )" & vbCrLf & meUntuk.Text, staffid, unitid, staffname, levelname, deptname, -1, 0, "-", 1})
            Dim statSave As Boolean = False
            statSave = mys.datasetSave("pengajuan", idtmp, field, value, False)
            isiLog(userid, dbstring, field, value, "pengajuan")

            If statSave Then
                dizMsgbox("Data Pengajuan berhasil disimpan", dizMsgboxStyle.Info, Me)
                If Format(CDate(deTanggal.EditValue), "dd-MM-yyyy") <> Format(nowTime, "dd-MM-yyyy") Then

                    Dim recall As New clsRenumberingDocument
                    recall.calculate("Pengajuan", "", CDate(deTanggal.EditValue).Year, "UM" & CDate(deTanggal.EditValue).Year & "/", "nopengajuan", "idpengajuan", "tanggalpengajuan", "Belakang", 4)
                End If
                Me.Cursor = Cursors.Default
                splashClosed = True

                btnNew_Click(btnNew, Nothing)
            End If
        End If
    End Sub

    Private Sub slueCOA_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles slueCOA.EditValueChanged
        If slueCOA.EditValue Is Nothing Then
            teRemarks.EditValue = Nothing
            seSisaAnggaran.Value = 0
            Exit Sub
        End If

        Dim mys As New SQLs(dbstring)
        Dim strquery As String = "select c.idcoa,c.coa,c.remarks,isnull(angjur.sisaang,0) as sisaang from coa c left join (select a.idcoa,a.jumlahuang-isnull(jur.saldo,0) as sisaang from anggaran a left join ( select j.idcoa, dbt.totaldbt-krd.totalkrd as saldo from jurnal j left join (select idcoa,convert(varchar,tanggaljurnal,121) as periode, sum(jumlahuang) as totaldbt from jurnal where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and convert(varchar,tanggaljurnal,121) like 'PERIODEFORMAT%' and isnull(isdeleted,0)=0 and posisidk=1 and idcoa=IDCOASELECT group by convert(varchar,tanggaljurnal,121), idcoa ) dbt on j.idcoa=dbt.idcoa left join ( select idcoa,convert(varchar,tanggaljurnal,121) as periode, sum(jumlahuang) as totalkrd from jurnal where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and convert(varchar,tanggaljurnal,121) like 'PERIODEFORMAT%' and isdeleted=0 and posisidk=2 and idcoa=IDCOASELECT group by convert(varchar,tanggaljurnal,121), idcoa ) krd on j.idcoa=krd.idcoa group by j.idcoa,dbt.totaldbt,krd.totalkrd ) jur on a.idcoa=jur.idcoa where a.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and ((len(a.periode)=4 and a.periode='YEARFORMAT') or (len(a.periode)=7 and a.periode = 'PERIODEFORMAT')) ) angjur on c.idcoa=angjur.idcoa where c.idcoa=IDCOASELECT"
        strquery = strquery.Replace("IDCOASELECT", slueCOA.EditValue)
        strquery = strquery.Replace("PERIODEFORMAT", Format(CDate(deTanggal.EditValue), "yyyy-MM"))
        strquery = strquery.Replace("YEARFORMAT", Format(CDate(deTanggal.EditValue), "yyyy"))
        mys.DMLQuery(strquery, "ang")

        teRemarks.Text = mys.getDataSet("ang", 0, "remarks")
        seSisaAnggaran.Value = mys.getDataSet("ang", 0, "sisaang")
    End Sub

End Class