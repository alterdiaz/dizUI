Imports DevExpress.XtraGrid.Views.Base
Public Class frmInternalNote
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

    Private Sub frmInternalNote_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        loadLOV()

        deTanggal.EditValue = nowTime
        deTanggalMutasi.EditValue = nowTime

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idstaff,idunit,iddepartment from staff where iduser='" & userid & "'", "cekuserstaff")
        If sqls.getDataSet("cekuserstaff") > 0 Then
            RemoveHandler lueUsername.EditValueChanged, AddressOf lueUsername_EditValueChanged
            lueUsername.EditValue = userid
            AddHandler lueUsername.EditValueChanged, AddressOf lueUsername_EditValueChanged

            slueUnit.EditValue = sqls.getDataSet("cekuserstaff", 0, "idunit")
            slueDept.EditValue = sqls.getDataSet("cekuserstaff", 0, "iddepartment")
            idstaff = sqls.getDataSet("cekuserstaff", 0, "idstaff")
        End If
        If usersuper = 0 Then
            lueUsername.ReadOnly = True
            slueUnit.ReadOnly = True
            slueDept.ReadOnly = True
            deTanggal.ReadOnly = True

            If idstaff = "" Then
                dizMsgbox("Pengguna belum mapping dengan data staff", dizMsgboxStyle.Kesalahan, "Kesalahan", Me)
                Me.Dispose()
                Exit Sub
            End If
        Else
            lueUsername.ReadOnly = False
            slueUnit.ReadOnly = False
            slueDept.ReadOnly = False
            deTanggal.ReadOnly = True
            idstaff = ""
        End If

        deTanggal.EditValue = nowTime
        teJudul.EditValue = "Catatan Internal " & Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        meRemarks.EditValue = Nothing

        btnAuto_Click(btnAuto, Nothing)

        sqls.DMLQuery("select isnull(isnotereview,0) as isnotereview,isnull(isnotedelete,0) as isnotedelete from sys_user where iduser='" & userid & "'", "getrd")
        isnotereview = sqls.getDataSet("getrd", 0, "isnotereview")
        isnotedelete = sqls.getDataSet("getrd", 0, "isnotedelete")
        If isnotereview = 0 Then
            btnProses.Enabled = False
        Else
            btnProses.Enabled = True
        End If
        If isnotedelete = 0 Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
        End If
        btnNew_Click(btnNew, Nothing)
    End Sub

    Private isnotereview As Long = 0
    Private isnotedelete As Long = 0
    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idunit as id,unit as content from unit where idunit not in (select value from sys_appsetting where variable in ('IDSystemUnit','IDVendorUnit')) and idunit<>'0' and isdeleted=0 order by unit asc", "unit")
        slueUnit.Properties.DataSource = sqls.dataTable("unit")
        slueUnit.Properties.ValueMember = "id"
        slueUnit.Properties.DisplayMember = "content"
        slueUnit.EditValue = Nothing

        sqls.DMLQuery("select iddepartment as id,department as content from department where iddepartment not in (select value from sys_appsetting where variable in ('IDSystemDept','IDVendorDept')) and  iddepartment<>'0' and isdeleted=0 order by department asc", "dept")
        slueDept.Properties.DataSource = sqls.dataTable("dept")
        slueDept.Properties.ValueMember = "id"
        slueDept.Properties.DisplayMember = "content"
        slueDept.EditValue = Nothing

        sqls.DMLQuery("select iduser as id,username as content from sys_user order by username asc", "user")
        lueUsername.Properties.DataSource = sqls.dataTable("user")
        lueUsername.Properties.ValueMember = "id"
        lueUsername.Properties.DisplayMember = "content"
        lueUsername.EditValue = Nothing
    End Sub

    Private idstaff As String = ""
    Private iddata As String = ""
    Private statdata As statusData = statusData.Baru
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        'If lueUsername.ReadOnly = False Then lueUsername.EditValue = Nothing
        'If slueUnit.ReadOnly = False Then slueUnit.EditValue = Nothing
        'If slueDept.ReadOnly = False Then slueDept.EditValue = Nothing
        deTanggal.Properties.ReadOnly = True
        deTanggal.EditValue = nowTime
        teJudul.EditValue = "Catatan Internal " & Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        meRemarks.EditValue = Nothing
        iddata = ""
        btnDelete.Text = "HAPUS"
        btnSave.Enabled = True
        statdata = statusData.Baru

        btnBaruReminder_Click(btnBaruReminder, Nothing)
        loadReminder(slueDept.EditValue, "-")
    End Sub

    Private fromReminder As Boolean = False
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cekIsian() = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            isinternalsaved = False
            Exit Sub
        End If

        Dim sqls1 As New SQLs(dbstring)
        sqls1.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqls1.getDataSet("CompID", 0, "value")

        Dim dtsqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If statdata = statusData.Baru Then
            iddata = GenerateGUID()
        End If
        If statdata = statusData.Baru Then
            field.AddRange(New String() {"idinternalnote", "idstaff", "idunit", "iddepartment", "judul", "remarks", "createdby", "createddate", "idcompany"})
            value.AddRange(New Object() {iddata, idstaff, slueUnit.EditValue, slueDept.EditValue, teJudul.EditValue, meRemarks.EditValue, lueUsername.EditValue, nowTime, idcomp})
        Else
            field.AddRange(New String() {"idinternalnote", "idstaff", "idunit", "iddepartment", "judul", "remarks", "updatedby", "updateddate", "idcompany"})
            value.AddRange(New Object() {iddata, idstaff, slueUnit.EditValue, slueDept.EditValue, teJudul.EditValue, meRemarks.EditValue, lueUsername.EditValue, nowTime, idcomp})
        End If
        If dtsqls.datasetSave("internalnote", iddata, field, value, False) Then
            If fromReminder = False Then
                dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
                btnNew_Click(btnNew, Nothing)
                btnRefresh_Click(btnRefresh, Nothing)
            Else
                isinternalsaved = True
            End If
        End If
    End Sub

    Private isinternalsaved As Boolean = False
    Private Function cekIsian() As Boolean
        Dim retval As Boolean = True
        If lueUsername.EditValue Is Nothing Then retval = False
        If slueUnit.EditValue Is Nothing Then retval = False
        If slueDept.EditValue Is Nothing Then retval = False
        If meRemarks.EditValue Is Nothing Then retval = False
        If teJudul.EditValue Is Nothing Then teJudul.EditValue = "Catatan Internal " & Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        If teJudul.Text = "" Then teJudul.EditValue = "Catatan Internal " & Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        If teJudul.Text = "-" Then teJudul.EditValue = "Catatan Internal " & Format(nowTime, "dd-MM-yyyy HH:mm:ss")
        If meRemarks.Text = "" Then retval = False
        If meRemarks.Text.Replace(" ", "") = "" Then retval = False
        Return retval
    End Function

    Private Sub lueUsername_EditValueChanged(sender As Object, e As EventArgs) Handles lueUsername.EditValueChanged
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idstaff,idunit,iddepartment from staff where iduser='" & lueUsername.EditValue & "'", "cekuserstaff")
        If sqls.getDataSet("cekuserstaff") > 0 Then
            slueUnit.EditValue = sqls.getDataSet("cekuserstaff", 0, "idunit")
            slueDept.EditValue = sqls.getDataSet("cekuserstaff", 0, "iddepartment")
            idstaff = sqls.getDataSet("cekuserstaff", 0, "idstaff")

            sqls.DMLQuery("select isnull(isnotereview,0) as isnotereview,isnull(isnotedelete,0) as isnotedelete from sys_user where iduser='" & lueUsername.EditValue & "'", "getrd")
            isnotereview = sqls.getDataSet("getrd", 0, "isnotereview")
            isnotedelete = sqls.getDataSet("getrd", 0, "isnotedelete")

            btnRefresh_Click(btnRefresh, Nothing)
        End If
    End Sub

    Private Sub loadGrid(idunit As String, iddept As String, tglentry As String)
        Dim sqls As New SQLs(dbstring)
        Dim iddept2 As New List(Of String)
        Dim iddepttmp As String = ""
        sqls.DMLQuery("WITH DepartmentCTE AS ( SELECT iddepartment, department, idparent,1 as Level FROM dbo.department WHERE iddepartment='" & iddept & "' UNION ALL SELECT a.iddepartment, a.department, a.idparent,Level+1 FROM dbo.department a INNER JOIN DepartmentCTE s ON a.idparent = s.iddepartment ) SELECT iddepartment FROM DepartmentCTE", "alldept")
        For i As Integer = 0 To sqls.getDataSet("alldept") - 1
            iddept2.Add("'" & sqls.getDataSet("alldept", i, "iddepartment").ToString & "'")
            iddepttmp &= ("'" & sqls.getDataSet("alldept", i, "iddepartment").ToString & "'")
            If i <> sqls.getDataSet("alldept") - 1 Then
                iddepttmp &= ","
            End If
        Next

        sqls.DMLQuery("select ni.idinternalnote,ni.iddepartment,ni.judul,ni.remarks as isi,convert(varchar,ni.createddate,105)+' '+convert(varchar,ni.createddate,108) as notedate,ni.isdeleted,ni.isreviewed,case when reviewedby is null then d.department + ' Dibuat '+convert(varchar,ni.createddate,105)+' '+convert(varchar,ni.createddate,108) +' '+ uc.username else d.department + ' Dibuat '+convert(varchar,ni.createddate,105)+' '+convert(varchar,ni.createddate,108) +' '+ uc.username + ' Direview '+convert(varchar,ni.revieweddate,105)+' '+convert(varchar,ni.revieweddate,108) +' '+ ur.username end as note,'JUDUL ' + ni.judul + char(13) + char(10) + ni.remarks as catatan from internalnote ni left join department d on ni.iddepartment=d.iddepartment left join sys_user uc on ni.createdby=uc.iduser left join sys_user ur on ni.reviewedby=ur.iduser where ni.isdeleted=0 and ni.idunit='" & idunit & "' and ni.iddepartment in (" & iddepttmp & ") and convert(varchar,ni.createddate,105)='" & tglentry & "' order by ni.createddate desc", "getdata")
        RemoveHandler gvData.FocusedRowChanged, AddressOf gvData_FocusedRowChanged
        gcData.DataSource = sqls.dataTable("getdata")
        gvData.BestFitColumns()
        gvData.PreviewIndent = 0 'GridColumn2.Width
        gvData.ViewCaption = "Catatan Internal " & tglentry.Split("-")(0) & " " & NamaBulan(CInt(tglentry.Split("-")(1))) & " " & tglentry.Split("-")(2)
        AddHandler gvData.FocusedRowChanged, AddressOf gvData_FocusedRowChanged
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        cnt = 15
        loadGrid(slueUnit.EditValue, slueDept.EditValue, Format(CDate(deTanggalMutasi.EditValue), "dd-MM-yyyy"))
    End Sub

    Private cnt As Integer = 15
    Private Sub tmrWaktu_Tick(sender As Object, e As EventArgs) Handles tmrWaktu.Tick
        lblRefresh.Text = "REFRESH " & cnt & " DETIK"
        cnt -= 1
        If cnt = 0 Then
            cnt = 15
            btnRefresh_Click(btnRefresh, Nothing)
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If gvData.RowCount = 0 Then
            dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If gvData.FocusedRowHandle < 0 Then
            dizMsgbox("Data belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If dizMsgbox("Proses Hapus tidak dapat dibatalkan, tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
            Exit Sub
        End If
        If gvData.RowCount = 1 Then gvData.FocusedRowHandle = 0

        Dim dr As DataRow = gvData.GetDataRow(gvData.FocusedRowHandle)
        If dr("isdeleted") = 0 Then
            iddata = dr("idinternalnote")
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("update internalnote set isdeleted=1,updateddate=getdate(),updatedby='" & userid & "' where idinternalnote='" & iddata & "'", False)

            sqls.DMLQuery("delete from sys_notifications where tableid='" & idreminder & "' and tablename='InternalNote'", False)
            'btnDelete.Text = "AKTIF"
        Else
            iddata = dr("idinternalnote")
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("update internalnote set isdeleted=0,updateddate=getdate(),updatedby='" & userid & "' where idinternalnote='" & iddata & "'", False)
            'btnDelete.Text = "HAPUS"
        End If
        btnNew_Click(btnNew, Nothing)
        btnRefresh_Click(btnRefresh, Nothing)
    End Sub

    Private Sub btnAuto_Click(sender As Object, e As EventArgs) Handles btnAuto.Click
        If btnAuto.Text = "AUTO REFRESH" Then
            cnt = 15
            lblRefresh.Text = "REFRESH " & cnt & " DETIK"
            tmrWaktu.Start()
            lblRefresh.Visible = True
            btnAuto.Text = "MANUAL"
        Else
            tmrWaktu.Stop()
            lblRefresh.Visible = False
            btnAuto.Text = "AUTO REFRESH"
        End If
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If gvData.RowCount = 0 Then
            dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If gvData.FocusedRowHandle < 0 Then
            dizMsgbox("Data belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If dizMsgbox("Proses Review tidak dapat dibatalkan, tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
            Exit Sub
        End If
        If gvData.RowCount = 1 Then gvData.FocusedRowHandle = 0

        Dim dr As DataRow = gvData.GetDataRow(gvData.FocusedRowHandle)
        If dr("iddepartment") <> slueDept.EditValue Then
            Exit Sub
        End If
        If dr("isreviewed") = 0 Then
            iddata = dr("idinternalnote")
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("update internalnote set isreviewed=1,revieweddate=getdate(),reviewedby='" & userid & "' where idinternalnote='" & iddata & "'", False)
            btnRefresh_Click(btnRefresh, Nothing)
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If gvData.RowCount > 0 Then
            Dim exp As New frmExport(gcData)
            tambahChild(exp)
            exp.ShowDialog()
        Else
            dizMsgbox("Data tidak ditemukan", dizMsgboxStyle.Peringatan, Me)
        End If
    End Sub

    Private Sub gvData_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        If e.FocusedRowHandle < 0 Then Exit Sub
        Dim idxfocus As Integer = e.FocusedRowHandle
        If gvData.RowCount = 1 Then
            idxfocus = 0
        End If
        Dim dr As DataRow = gvData.GetDataRow(idxfocus)
        If dr("isreviewed") = 0 Then
            iddata = dr("idinternalnote")
            teJudul.EditValue = dr("judul")
            meRemarks.EditValue = dr("isi")
            deTanggal.EditValue = Strdatetime2Datetime(dr("notedate"))
            btnSave.Enabled = True
            btnProses.Enabled = True
            statdata = statusData.Edit

            If isnotereview = 0 Then
                btnProses.Enabled = False
            Else
                btnProses.Enabled = True
            End If
        Else
            iddata = dr("idinternalnote")
            teJudul.EditValue = dr("judul")
            meRemarks.EditValue = dr("isi")
            deTanggal.EditValue = Strdatetime2Datetime(dr("notedate"))
            btnSave.Enabled = False
            btnProses.Enabled = False
            statdata = statusData.Edit
        End If
        If dr("isdeleted") = 0 Then
            btnDelete.Text = "HAPUS"
        Else
            btnDelete.Text = "AKTIF"
        End If
        If isnotedelete = 0 Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
        End If
        loadReminder(slueDept.EditValue, iddata)
    End Sub

    Private Sub meRemarks_TextChanged(sender As Object, e As EventArgs) Handles meRemarks.TextChanged
        Label2.Text = "Catatan" & vbCrLf & meRemarks.Text.Length & "/8000"
    End Sub

    Private Sub btnKunjunganReg_Click(sender As Object, e As EventArgs) Handles btnKunjunganReg.Click
        formTitle = "Rekap Register Pasien"
        Dim frmMon As New frmRekapRegPasien
        tambahChild(frmMon)
        frmMon.StartPosition = FormStartPosition.CenterScreen
        frmMon.pMinimize.Enabled = False
        frmMon.pMaximize.Enabled = False
        frmMon.tlpForm.RowCount = 4
        frmMon.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        frmMon.ShowDialog(Me)
        formTitle = Me.lblTitle.Text
    End Sub

    Private Sub btnKunjunganApp_Click(sender As Object, e As EventArgs) Handles btnKunjunganApp.Click
        formTitle = "Rekap App Pasien"
        Dim frmMon As New frmRekapAppPasien
        tambahChild(frmMon)
        frmMon.StartPosition = FormStartPosition.CenterScreen
        frmMon.pMinimize.Enabled = False
        frmMon.pMaximize.Enabled = False
        frmMon.tlpForm.RowCount = 4
        frmMon.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        frmMon.ShowDialog(Me)
        formTitle = Me.lblTitle.Text
    End Sub

    Private Sub gvData_FocusedColumnChanged(sender As Object, e As FocusedColumnChangedEventArgs) Handles gvData.FocusedColumnChanged
        If gvData.FocusedRowHandle < 0 Then Exit Sub
        Dim idxfocus As Integer = gvData.FocusedRowHandle
        If gvData.RowCount = 1 Then
            idxfocus = 0
        End If
        Dim dr As DataRow = gvData.GetDataRow(idxfocus)
        If dr("isreviewed") = 0 Then
            iddata = dr("idinternalnote")
            teJudul.EditValue = dr("judul")
            meRemarks.EditValue = dr("isi")
            deTanggal.EditValue = Strdatetime2Datetime(dr("notedate"))
            btnSave.Enabled = True
            btnProses.Enabled = True
            statdata = statusData.Edit

            If isnotereview = 0 Then
                btnProses.Enabled = False
            Else
                btnProses.Enabled = True
            End If
        Else
            iddata = dr("idinternalnote")
            teJudul.EditValue = dr("judul")
            meRemarks.EditValue = dr("isi")
            deTanggal.EditValue = Strdatetime2Datetime(dr("notedate"))
            btnSave.Enabled = False
            btnProses.Enabled = False
            statdata = statusData.Edit
        End If
        If dr("isdeleted") = 0 Then
            btnDelete.Text = "HAPUS"
        Else
            btnDelete.Text = "AKTIF"
        End If
        If isnotedelete = 0 Then
            btnDelete.Enabled = False
        Else
            btnDelete.Enabled = True
        End If
        loadReminder(slueDept.EditValue, iddata)
    End Sub

    Private statreminder As statusData = statusData.Baru
    Private idreminder As String = ""

    Private Sub btnBaruReminder_Click(sender As Object, e As EventArgs) Handles btnBaruReminder.Click
        deReminder.EditValue = nowTime
        meReminder.EditValue = Nothing
        idreminder = ""
        btnHapusReminder.Text = "HAPUS"

        btnSimpanReminder.Enabled = True
        btnHapusReminder.Enabled = True
        statreminder = statusData.Baru
    End Sub

    Private Sub btnSimpanReminder_Click(sender As Object, e As EventArgs) Handles btnSimpanReminder.Click
        If cekReminder() = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        fromReminder = True
        btnSave_Click(btnSave, Nothing)
        statdata = statusData.Edit
        If isinternalsaved = False Then
            Exit Sub
        End If

        Dim sqls1 As New SQLs(dbstring)
        sqls1.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqls1.getDataSet("CompID", 0, "value")

        sqls1.DMLQuery("select kode from department where iddepartment='" & slueDept.EditValue & "'", "DeptKode")
        Dim kodedept As String = ""
        If sqls1.getDataSet("DeptKode") > 0 Then
            kodedept = sqls1.getDataSet("DeptKode", 0, "kode")
        Else
            dizMsgbox("Department tidak ditemukan", dizMsgboxStyle.Kesalahan, Me)
            fromReminder = False
            Exit Sub
        End If

        Dim dtsqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If statreminder = statusData.Baru Then
            idreminder = GenerateGUID()
        End If
        If statreminder = statusData.Baru Then
            field.AddRange(New String() {"idnotifications", "kode", "kodedept", "judul", "konten", "createddate", "duedate", "tableid", "tablename"})
            value.AddRange(New Object() {idreminder, "REMND", kodedept, teJudul.Text, meReminder.Text, CDate(deReminder.EditValue), CDate(deReminder.EditValue), iddata, "InternalNote"})
        Else
            field.AddRange(New String() {"idnotifications", "kode", "kodedept", "judul", "konten", "createddate", "duedate", "tableid", "tablename"})
            value.AddRange(New Object() {idreminder, "REMND", kodedept, teJudul.Text, meReminder.Text, CDate(deReminder.EditValue), CDate(deReminder.EditValue), iddata, "InternalNote"})
        End If
        If dtsqls.datasetSave("sys_notifications", idreminder, field, value, False) Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            fromReminder = False

            loadReminder(slueDept.EditValue, iddata)
            btnBaruReminder_Click(btnBaruReminder, Nothing)
        End If
    End Sub

    Private Sub loadReminder(iddept As String, idinternal As String)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select n.idnotifications,n.iskonfirm,convert(varchar,n.duedate,105)+' '+convert(varchar,n.duedate,108) as duedate,n.konten,case when n.konfirmby is null then ' Dibuat '+convert(varchar,n.createddate,105)+' '+convert(varchar,n.createddate,108)  else ' Dibuat '+convert(varchar,n.createddate,105)+' '+convert(varchar,n.createddate,108) + ' Dikonfirm '+convert(varchar,n.konfirmdate,105)+' '+convert(varchar,n.konfirmdate,108) +' '+ ur.username end as note from sys_notifications n left join sys_user ur on n.konfirmby=ur.iduser where n.kode='REMND' and n.kodedept in (select kode from department where iddepartment='" & iddept & "') and n.tableid='" & idinternal & "' and n.tablename='InternalNote' order by n.duedate desc", "reminder")
        gcReminder.DataSource = sqls.dataTable("reminder")
        gvReminder.BestFitColumns()
    End Sub

    Private Function cekReminder() As Boolean
        Dim retval As Boolean = True
        If deReminder.EditValue Is Nothing Then retval = False
        If meReminder.EditValue Is Nothing Then retval = False
        If meReminder.Text = "" Then retval = False
        If meReminder.Text.Replace(" ", "") = "" Then retval = False
        Return retval
    End Function

    Private Sub btnHapusReminder_Click(sender As Object, e As EventArgs) Handles btnHapusReminder.Click
        If dizMsgbox("Proses Hapus tidak dapat dibatalkan, tetap melanjutkan?", dizMsgboxStyle.Konfirmasi, Me) = dizMsgboxValue.Batal Then
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("delete from sys_notifications where idnotifications='" & idreminder & "'", False)

        loadReminder(slueDept.EditValue, iddata)
        btnBaruReminder_Click(btnBaruReminder, Nothing)
    End Sub

    Private Sub gvReminder_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvReminder.FocusedRowChanged
        If gvReminder.FocusedRowHandle < 0 Then Exit Sub
        Dim idxfocus As Integer = gvReminder.FocusedRowHandle
        If gvReminder.RowCount = 1 Then
            idxfocus = 0
        End If
        Dim dr As DataRow = gvReminder.GetDataRow(idxfocus)
        idreminder = dr("idnotifications")
        deReminder.EditValue = Strdatetime2Datetime(dr("duedate"))
        meReminder.EditValue = dr("konten")
        statreminder = statusData.Edit

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select iskonfirm from sys_notifications where idnotifications='" & idreminder & "'", "cekkonfirm")
        If sqls.getDataSet("cekkonfirm") > 0 Then
            If sqls.getDataSet("cekkonfirm", 0, "iskonfirm") = "0" Then
                btnSimpanReminder.Enabled = True
                btnHapusReminder.Enabled = True
            Else
                btnSimpanReminder.Enabled = False
                btnHapusReminder.Enabled = False
            End If
        Else
            btnSimpanReminder.Enabled = False
            btnHapusReminder.Enabled = False
        End If
    End Sub

    Private Sub gvReminder_FocusedColumnChanged(sender As Object, e As FocusedColumnChangedEventArgs) Handles gvReminder.FocusedColumnChanged
        If gvReminder.FocusedRowHandle < 0 Then Exit Sub
        Dim idxfocus As Integer = gvReminder.FocusedRowHandle
        If gvReminder.RowCount = 1 Then
            idxfocus = 0
        End If
        Dim dr As DataRow = gvReminder.GetDataRow(idxfocus)
        idreminder = dr("idnotifications")
        deReminder.EditValue = Strdatetime2Datetime(dr("duedate"))
        meReminder.EditValue = dr("konten")
        statreminder = statusData.Edit

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select iskonfirm from sys_notifications where idnotifications='" & idreminder & "'", "cekkonfirm")
        If sqls.getDataSet("cekkonfirm") > 0 Then
            If sqls.getDataSet("cekkonfirm", 0, "iskonfirm") = "0" Then
                btnSimpanReminder.Enabled = True
                btnHapusReminder.Enabled = True
            Else
                btnSimpanReminder.Enabled = False
                btnHapusReminder.Enabled = False
            End If
        Else
            btnSimpanReminder.Enabled = False
            btnHapusReminder.Enabled = False
        End If
    End Sub

    Private Sub deTanggalMutasi_EditValueChanged(sender As Object, e As EventArgs) Handles deTanggalMutasi.EditValueChanged
        btnRefresh_Click(btnRefresh, Nothing)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If slueUnit.EditValue Is Nothing Then Exit Sub
        If slueDept.EditValue Is Nothing Then Exit Sub

        formTitle = "Pencarian Catatan Internal"
        Dim frmMon As New frmInternalSearch(slueUnit.EditValue, slueDept.EditValue)
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