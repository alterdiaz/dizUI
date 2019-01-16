Public Class frmParamedisJadwal
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

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub loadLOV()
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='SCHDAYS' order by idgeneral asc", "schdays")
        ccboJadwalHari.Properties.DataSource = mysqls.dataTable("schdays")
        ccboJadwalHari.Properties.DisplayMember = "content"
        ccboJadwalHari.Properties.ValueMember = "id"
        ccboJadwalHari.Properties.AutoHeight = True
        If mysqls.getDataSet("schdays") = 0 Then
            dizMsgbox("Hari Jadwal tidak ditemukan" & vbCrLf & "Hari Jadwal harap entry dulu", dizMsgboxStyle.Peringatan, Me)
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

        mysqls.DMLQuery("select s.idspesialis as id, s.nama as content,s.remarks as remarks from paramedisspesialis ps left join spesialis s on ps.idspesialis=s.idspesialis and s.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where ps.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and 1=0 order by s.remarks asc", "mparamspesialis")
        lueSpesialis.Properties.DataSource = mysqls.dataTable("mparamspesialis")
        lueSpesialis.Properties.DisplayMember = "content"
        lueSpesialis.Properties.ValueMember = "id"
        lueSpesialis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueSpesialis.Properties.BestFit()

        mysqls.DMLQuery("select idjadwalsesi as id,nama + ' (' + substring(convert(varchar,jammulai,108),0,6)+' - ' + substring(convert(varchar,jamselesai,108),0,6)+')' as content from jadwalsesi where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isnull(isdeleted,0)=0 order by priority asc", "sesi")
        lueJadwalSesi.Properties.DataSource = mysqls.dataTable("sesi")
        lueJadwalSesi.Properties.DisplayMember = "content"
        lueJadwalSesi.Properties.ValueMember = "id"
        lueJadwalSesi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueJadwalSesi.Properties.BestFit()
        If mysqls.getDataSet("sesi") = 0 Then
            dizMsgbox("Sesi Jadwal tidak ditemukan" & vbCrLf & "Sesi Jadwal harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        'mysqls.DMLQuery("select idlokasi as id,nama as content from lokasi where iddepartment in (select [value] from sys_appsetting where variable='IDOutpatientDept') order by nama asc", "jadwallokasi")
        'lueJadwalLokasi.Properties.DataSource = mysqls.dataTable("jadwallokasi")
        'lueJadwalLokasi.Properties.DisplayMember = "content"
        'lueJadwalLokasi.Properties.ValueMember = "id"
        'lueJadwalLokasi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        'lueJadwalLokasi.Properties.BestFit()
        'If mysqls.getDataSet("jadwallokasi") = 0 Then
        '    dizMsgbox("Lokasi Jadwal tidak ditemukan" & vbCrLf & "Sesi Jadwal harap entry dulu", dizMsgboxStyle.Peringatan, Me)
        '    pExit_Click(Me, Nothing)
        '    Exit Sub
        'End If

        mysqls.DMLQuery("select idparamedis as id,nama as content from paramedis where idparamedis in (select idparamedis from paramedisspesialis) and paramedistype in (select idgeneral from sys_generalcode where gctype='paramedistype' and priority in (1,2,3,5)) order by nama asc", "paramedis")
        lueParamedis.Properties.DataSource = mysqls.dataTable("paramedis")
        lueParamedis.Properties.DisplayMember = "content"
        lueParamedis.Properties.ValueMember = "id"
        lueParamedis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueParamedis.Properties.BestFit()
        If mysqls.getDataSet("paramedis") = 0 Then
            dizMsgbox("Paramedis Spesialis tidak ditemukan" & vbCrLf & "Paramedis Spesialis harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

    End Sub

    Private Sub loadParamSpesialis(idreff As String)
        Dim sqls As New SQLs(dbstring)

        sqls.DMLQuery("select s.idspesialis as id, s.nama as content,s.remarks as remarks from paramedisspesialis ps left join spesialis s on ps.idspesialis=s.idspesialis and s.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where ps.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and ps.idparamedis='" & idreff & "' order by s.remarks asc", "mparamspesialis")
        lueSpesialis.Properties.DataSource = sqls.dataTable("mparamspesialis")
        lueSpesialis.Properties.DisplayMember = "content"
        lueSpesialis.Properties.ValueMember = "id"
        lueSpesialis.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueSpesialis.Properties.BestFit()
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

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        checkFieldMaxLength(dbstring, tlpJadwal1, "paramedisjadwal")
        checkFieldMaxLength(dbstring, tlpJadwal2, "paramedisjadwal")

        loadLOV()
        loadGrid()
        btnNew_Click(Me, Nothing)
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        minJamMulai = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
        maxJamMulai = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 23, 59, 0)

        lueParamedis.EditValue = Nothing
        lueParamedis.ReadOnly = False
        lueJadwalSesi.EditValue = Nothing
        lueJadwalSesi.ReadOnly = False
        ccboJadwalHari.EditValue = Nothing
        For i As Integer = 0 To ccboJadwalHari.Properties.Items.Count - 1
            ccboJadwalHari.Properties.Items.Item(i).CheckState = CheckState.Unchecked
        Next
        ccboJadwalHari.ShowPopup()
        ccboJadwalHari.ClosePopup()
        ccboJadwalHari.ReadOnly = False

        deJadwalMulai.EditValue = nowTime
        deJadwalMulai.ReadOnly = False
        deJadwalSelesai.EditValue = nowTime
        deJadwalSelesai.Properties.MinValue = nowTime
        deJadwalSelesai.ReadOnly = False
        teJamMulai.Time = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
        teJamMulai.ReadOnly = False
        teJamSelesai.EditValue = Nothing
        teJamSelesai.ReadOnly = False

        lueUnit.EditValue = Nothing
        lueUnit.ReadOnly = False
        lueSpesialis.EditValue = Nothing
        lueSpesialis.ReadOnly = False
        lueJadwalLokasi.EditValue = Nothing
        lueJadwalLokasi.ReadOnly = False
        seJadwalMaxApp.EditValue = 0
        seJadwalMaxApp.ReadOnly = False
        seJadwalDurasi.EditValue = 0
        seJadwalDurasi.ReadOnly = False
        tsJadwalParamedisSMS.EditValue = False
        tsJadwalParamedisSMS.ReadOnly = False
        tsJadwalPasienSMS.EditValue = False
        tsJadwalPasienSMS.ReadOnly = False
        tsJadwalMonitor.EditValue = False
        tsJadwalMonitor.ReadOnly = False

        meJadwalRemarks.EditValue = Nothing
        meJadwalRemarks.ReadOnly = False

        btnNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnDelete.Text = "HAPUS"
        btnDeletePermanen.Enabled = False
        statData = statusData.Baru
        idData = "-1"
    End Sub

    Private Sub loadGrid()
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqls As New SQLs(dbstring)
        sqls.CallSP("spParamedisJadwal", "jadwal")
        gcData.DataSource = sqls.dataTable("jadwal")
        gvData.BestFitColumns()
        If gvData.RowCount = 0 Then
            btnExport.Enabled = False
        Else
            btnExport.Enabled = True
        End If

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub lueParamedis_EditValueChanged(sender As Object, e As EventArgs) Handles lueParamedis.EditValueChanged
        If lueParamedis.EditValue Is Nothing Then
            lueSpesialis.Properties.DataSource = Nothing
            lueSpesialis.EditValue = Nothing
            lueJadwalLokasi.Properties.DataSource = Nothing
            lueJadwalLokasi.EditValue = Nothing
            Exit Sub
        End If
        loadParamSpesialis(lueParamedis.EditValue)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dizMsgbox("Jadwal tersebut sudah tidak berlaku?", dizMsgboxStyle.Konfirmasi) = dizMsgboxValue.Batal Then
            Exit Sub
        End If

        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idparamedisjadwal", "isdeleted", "updatedby", "updateddate"})
        If btnDelete.Text = "HAPUS" Then
            value.AddRange(New Object() {idData, 1, userid, nowTime})
            dtsql.datasetSave("paramedisjadwal", idData, field, value, False)
            btnDelete.Text = "AKTIF"
        ElseIf btnDelete.Text = "AKTIF" Then
            Dim strjammulai As String = teJamMulai.Text
            Dim strjam As String = strjammulai.Split(":")(0)
            Dim strmenit As String = strjammulai.Split(":")(1)
            Dim hari() As String
            Dim strhari As String = ccboJadwalHari.EditValue
            strhari = strhari.Replace(" ", "")
            hari = strhari.Split(",")
            Dim wherehari As String = ""
            For i As Integer = 0 To hari.Length - 1
                wherehari &= " and (case when pj.hari like '%" & hari(i) & "%' then 'Ya' else 'Tidak' end) = 'Ya' "
            Next
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select pj.idparamedisjadwal from paramedisjadwal pj left join paramedisspesialis ps on pj.idparamedisspesialis=ps.idparamedisspesialis and ps.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where pj.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and (isnull(pj.isdeleted,0)<>2 or isnull(pj.isdeleted,0)=1) and ps.idparamedis='" & idData & "' and ('" & strjam & ":" & strmenit & ":00' between pj.jammulai and pj.jamselesai)" & wherehari, "cek")
            If sqls.getDataSet("cek") > 0 Then
                dizMsgbox("Jadwal Paramedis tersebut sudah ada", dizMsgboxStyle.Info, Me)
                lueParamedis.Focus()
                Exit Sub
            End If

            value.AddRange(New Object() {idData, 0, userid, nowTime})
            dtsql.datasetSave("paramedisjadwal", idData, field, value, False)
            btnDelete.Text = "HAPUS"
        End If
        loadGrid()
        btnNew_Click(btnNew, Nothing)
    End Sub

    Private Sub btnDeletePermanen_Click(sender As Object, e As EventArgs) Handles btnDeletePermanen.Click
        If dizMsgbox("Hapus Jadwal secara permanen?", dizMsgboxStyle.Konfirmasi) = dizMsgboxValue.Batal Then
            Exit Sub
        End If

        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idparamedisjadwal", "isdeleted", "updatedby", "updateddate"})
        If btnDelete.Text = "HAPUS" Then
            value.AddRange(New Object() {idData, 2, userid, nowTime})
            dtsql.datasetSave("paramedisjadwal", idData, field, value, False)
            btnDelete.Text = "AKTIF"
        ElseIf btnDelete.Text = "AKTIF" Then
            Dim strjammulai As String = teJamMulai.Text
            Dim strjam As String = strjammulai.Split(":")(0)
            Dim strmenit As String = strjammulai.Split(":")(1)
            Dim hari() As String
            Dim strhari As String = ccboJadwalHari.EditValue
            strhari = strhari.Replace(" ", "")
            hari = strhari.Split(",")
            Dim wherehari As String = ""
            For i As Integer = 0 To hari.Length - 1
                wherehari &= " and (case when pj.hari like '%" & hari(i) & "%' then 'Ya' else 'Tidak' end) = 'Ya' "
            Next
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select pj.idparamedisjadwal from paramedisjadwal pj left join paramedisspesialis ps on pj.idparamedisspesialis=ps.idparamedisspesialis and ps.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where pj.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and isnull(pj.isdeleted,0)<>2 and ps.idparamedis='" & idData & "' and ('" & strjam & ":" & strmenit & ":00' between pj.jammulai and pj.jamselesai)" & wherehari, "cek")
            If sqls.getDataSet("cek") > 0 Then
                dizMsgbox("Jadwal Paramedis tersebut sudah ada", dizMsgboxStyle.Info, Me)
                lueParamedis.Focus()
                Exit Sub
            End If

            value.AddRange(New Object() {idData, 0, userid, nowTime})
            dtsql.datasetSave("paramedisjadwal", idData, field, value, False)
            btnDelete.Text = "HAPUS"
        End If
        loadGrid()
        btnNew_Click(btnNew, Nothing)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim bentry As Boolean = True
        bentry = checkEntry(tlpJadwal1)
        bentry = checkEntry(tlpJadwal2)
        If seJadwalDurasi.Value = 0 And seJadwalMaxApp.Value = 0 Then
            bentry = False
        End If
        Dim bcekjam As Boolean = True
        If teJamMulai.EditValue Is Nothing Then
            bentry = False
            bcekjam = False
        End If
        If teJamSelesai.EditValue Is Nothing Then
            bentry = False
            bcekjam = False
        End If
        If CDate(teJamMulai.EditValue).Hour >= CDate(teJamSelesai.EditValue).Hour Then
            bentry = False
            bcekjam = False
        End If

        If bcekjam = False Then
            dizMsgbox("Data Jam Jadwal belum diisi dengan benar", dizMsgboxStyle.Peringatan, "Peringatan", Me)
            Exit Sub
        End If
        If bentry = False Then
            dizMsgbox("Data Jadwal Paramedis belum diisi dengan benar", dizMsgboxStyle.Peringatan, "Peringatan", Me)
            Exit Sub
        End If
        If statData = statusData.Baru Then
            Dim strjammulai As String = teJamMulai.Text
            Dim strjam As String = strjammulai.Split(":")(0)
            Dim strmenit As String = strjammulai.Split(":")(1)
            Dim hari() As String
            Dim strhari As String = ccboJadwalHari.EditValue
            strhari = strhari.Replace(" ", "")
            hari = strhari.Split(",")
            Dim wherehari As String = ""
            For i As Integer = 0 To hari.Length - 1
                wherehari &= " and (case when pj.hari like '%" & hari(i) & "%' then 'Ya' else 'Tidak' end) = 'Ya' "
            Next
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select pj.idparamedisjadwal from paramedisjadwal pj left join paramedisspesialis ps on pj.idparamedisspesialis=ps.idparamedisspesialis and ps.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where pj.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and pj.isdeleted<>2 and ps.idparamedis='" & lueParamedis.EditValue & "' and idjadwalsesi='" & lueJadwalSesi.EditValue & "' " & wherehari, "cek")
            '('" & strjam & ":" & strmenit & ":00' between pj.jammulai and pj.jamselesai)
            If sqls.getDataSet("cek") = 0 Then
                idData = GenerateGUID()
            Else
                dizMsgbox("Jadwal Paramedis tersebut sudah ada", dizMsgboxStyle.Info, Me)
                lueParamedis.Focus()
                Exit Sub
            End If
            Dim idps As String = ""
            sqls.DMLQuery("select idparamedisspesialis from paramedisspesialis where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and idspesialis='" & lueSpesialis.EditValue & "' and idparamedis='" & lueParamedis.EditValue & "'", "getidps")
            idps = sqls.getDataSet("getidps", 0, "idparamedisspesialis")

            Dim sqls1 As New SQLs(dbstring)
            sqls1.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqls1.getDataSet("CompID", 0, "value")

            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idparamedisjadwal", "idcompany", "idparamedisspesialis", "idjadwalsesi", "idlokasi", "idunit", "hari", "tanggalmulai", "tanggalselesai", "jammulai", "jamselesai", "maxapp", "durasi", "isparamedissms", "ispasiensms", "ismonitor", "remarks", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idData, idcomp, idps, lueJadwalSesi.EditValue, lueJadwalLokasi.EditValue, lueUnit.EditValue, ccboJadwalHari.EditValue, CDate(deJadwalMulai.EditValue), CDate(deJadwalSelesai.EditValue), CDate(teJamMulai.EditValue).TimeOfDay, CDate(teJamSelesai.EditValue).TimeOfDay, seJadwalMaxApp.Value, seJadwalDurasi.Value, tsJadwalParamedisSMS.EditValue, tsJadwalPasienSMS.EditValue, tsJadwalMonitor.EditValue, meJadwalRemarks.Text, 0, userid, nowTime})
            If dtsql.datasetSave("paramedisjadwal", idData, field, value, False) = True Then
                dizMsgbox("Jadwal telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statData = statusData.Edit Then
            Dim sqls As New SQLs(dbstring)
            Dim idps As String = ""
            sqls.DMLQuery("select idparamedisspesialis from paramedisspesialis where idspesialis='" & lueSpesialis.EditValue & "' and idparamedis='" & lueParamedis.EditValue & "'", "getidps")
            idps = sqls.getDataSet("getidps", 0, "idparamedisspesialis")

            Dim hari() As String
            Dim strhari As String = ccboJadwalHari.EditValue
            strhari = strhari.Replace(" ", "")
            hari = strhari.Split(",")
            Dim wherehari As String = ""
            For i As Integer = 0 To hari.Length - 1
                wherehari &= " and (case when pj.hari like '%" & hari(i) & "%' then 'Ya' else 'Tidak' end) = 'Ya' "
            Next
            sqls.DMLQuery("select pj.idparamedisjadwal from paramedisjadwal pj left join paramedisspesialis ps on pj.idparamedisspesialis=ps.idparamedisspesialis and ps.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') where pj.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and pj.idparamedisjadwal<>'" & idData & "' and pj.isdeleted<>2 and ps.idparamedis='" & lueParamedis.EditValue & "' and idjadwalsesi='" & lueJadwalSesi.EditValue & "' and " & wherehari, "cek")

            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idparamedisjadwal", "tanggalselesai", "isparamedissms", "ispasiensms", "ismonitor", "remarks", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, CDate(deJadwalSelesai.EditValue), tsJadwalParamedisSMS.EditValue, tsJadwalPasienSMS.EditValue, tsJadwalMonitor.EditValue, meJadwalRemarks.Text, userid, nowTime})
            If dtsql.datasetSave("paramedisjadwal", idData, field, value, False) = True Then
                dizMsgbox("Jadwal telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        End If
        loadGrid()
        btnNew_Click(btnNew, Nothing)
    End Sub

    Private Sub teJamMulai_EditValueChanged(sender As Object, e As EventArgs) Handles teJamMulai.EditValueChanged
        If fromLOV = True Then Exit Sub
        If CDate(teJamMulai.EditValue) < minJamMulai Then
            teJamMulai.Time = minJamMulai
        End If
        If CDate(teJamMulai.EditValue) > maxJamMulai Then
            teJamMulai.Time = maxJamMulai
        End If
    End Sub

    Private Sub teJamSelesai_EditValueChanged(sender As Object, e As EventArgs) Handles teJamSelesai.EditValueChanged
        If fromLOV = True Then Exit Sub
        If teJamMulai.EditValue Is Nothing Then Exit Sub
        If CDate(teJamSelesai.EditValue) < CDate(teJamMulai.EditValue) Then
            teJamSelesai.Time = teJamMulai.EditValue
        End If
    End Sub

    Private Sub gvData_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        If e.FocusedRowHandle < 0 Then Exit Sub
        For i As Integer = 0 To ccboJadwalHari.Properties.Items.Count - 1
            ccboJadwalHari.Properties.Items.Item(i).CheckState = CheckState.Unchecked
        Next

        Dim dcol As DataRow = gvData.GetDataRow(e.FocusedRowHandle)

        statData = statusData.Edit
        idData = dcol("idparamedisjadwal")

        lueUnit.EditValue = dcol("idunit")
        lueUnit.ReadOnly = True
        lueParamedis.EditValue = dcol("idparamedis")
        lueParamedis.ReadOnly = True
        lueSpesialis.EditValue = dcol("idspesialis")
        lueSpesialis.ReadOnly = True
        lueJadwalSesi.EditValue = dcol("idjadwalsesi")
        lueJadwalSesi.ReadOnly = True
        Dim strhari As String = dcol("hari")
        strhari = strhari.Replace(" ", "")
        For i As Integer = 0 To strhari.Split(",").Length - 1
            For a As Integer = 0 To ccboJadwalHari.Properties.Items.Count - 1
                If ccboJadwalHari.Properties.Items.Item(a).Value = strhari.Split(",")(i) Then
                    ccboJadwalHari.Properties.Items.Item(a).CheckState = CheckState.Checked
                End If
            Next
        Next
        ccboJadwalHari.Invalidate()
        ccboJadwalHari.ReadOnly = True
        deJadwalMulai.EditValue = Strdate2Date(dcol("tanggalmulai").ToString)
        deJadwalMulai.ReadOnly = True
        deJadwalSelesai.EditValue = Strdate2Date(dcol("tanggalselesai").ToString)
        deJadwalSelesai.ReadOnly = False
        deJadwalSelesai.Properties.MinValue = nowTime
        teJamMulai.Time = New Date(nowTime.Year, nowTime.Month, nowTime.Day, dcol("jammulai").ToString.Split(":")(0), dcol("jammulai").ToString.Split(":")(1), 0)
        teJamMulai.ReadOnly = True
        teJamSelesai.Time = New Date(nowTime.Year, nowTime.Month, nowTime.Day, dcol("jamselesai").ToString.Split(":")(0), dcol("jamselesai").ToString.Split(":")(1), 0)
        teJamSelesai.ReadOnly = True

        lueJadwalLokasi.EditValue = dcol("idlokasi")
        lueJadwalLokasi.ReadOnly = True
        seJadwalMaxApp.EditValue = dcol("maxapp")
        seJadwalMaxApp.ReadOnly = True
        seJadwalDurasi.EditValue = dcol("durasi")
        seJadwalDurasi.ReadOnly = True
        tsJadwalParamedisSMS.EditValue = CBool(dcol("isparamedissms"))
        tsJadwalParamedisSMS.ReadOnly = False
        tsJadwalPasienSMS.EditValue = CBool(dcol("ispasiensms"))
        tsJadwalPasienSMS.ReadOnly = False
        tsJadwalMonitor.EditValue = CBool(dcol("ismonitor"))
        tsJadwalMonitor.ReadOnly = False
        meJadwalRemarks.EditValue = dcol("remarks")
        meJadwalRemarks.ReadOnly = False
        If dcol("isdeleted") = 0 Then
            btnDelete.Text = "HAPUS"
        ElseIf dcol("isdeleted") = 1 Then
            btnDelete.Text = "AKTIF"
        End If
        btnNew.Enabled = True
        btnSave.Enabled = True
        btnDelete.Enabled = True
        btnDeletePermanen.Enabled = True
    End Sub

    Private minJamMulai As Date = Now
    Private maxJamMulai As Date = Now
    Private fromLOV As Boolean = False
    Private Sub lueJadwalSesi_EditValueChanged(sender As Object, e As EventArgs) Handles lueJadwalSesi.EditValueChanged
        fromLOV = True
        If lueJadwalSesi.EditValue Is Nothing Then
            minJamMulai = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
            maxJamMulai = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
            teJamMulai.Time = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
            teJamSelesai.Time = New Date(nowTime.Year, nowTime.Month, nowTime.Day, 0, 0, 0)
            fromLOV = False
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select jammulai,jamselesai from jadwalsesi where idjadwalsesi='" & lueJadwalSesi.EditValue & "'", "getjamawal")
        If sqls.getDataSet("getjamawal") = 0 Then
            dizMsgbox("Sesi Jadwal tidak ditemukan" & vbCrLf & "Sesi Jadwal harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            fromLOV = False
            pExit_Click(Me, Nothing)
            Exit Sub
        Else
            Dim jam As Integer = CInt(sqls.getDataSet("getjamawal", 0, "jammulai").ToString.Split(":")(0))
            Dim menit As Integer = CInt(sqls.getDataSet("getjamawal", 0, "jammulai").ToString.Split(":")(1))
            Dim jamselesai As Integer = CInt(sqls.getDataSet("getjamawal", 0, "jamselesai").ToString.Split(":")(0))
            Dim menitselesai As Integer = CInt(sqls.getDataSet("getjamawal", 0, "jamselesai").ToString.Split(":")(1))

            teJamMulai.Time = New Date(nowTime.Year, nowTime.Month, nowTime.Day, jam, menit, 0)
            teJamSelesai.Time = New Date(nowTime.Year, nowTime.Month, nowTime.Day, jamselesai, menitselesai, 0)
            minJamMulai = New Date(nowTime.Year, nowTime.Month, nowTime.Day, jam, menit, 0)
            maxJamMulai = New Date(nowTime.Year, nowTime.Month, nowTime.Day, jamselesai, menitselesai, 0)
        End If
        fromLOV = False
    End Sub

    Private Sub seJadwalDurasi_ValueChanged(sender As Object, e As EventArgs) Handles seJadwalDurasi.ValueChanged
        If seJadwalDurasi.Value > 0 Then
            seJadwalMaxApp.Value = 0
        End If
    End Sub

    Private Sub seJadwalMaxApp_EditValueChanged(sender As Object, e As EventArgs) Handles seJadwalMaxApp.EditValueChanged
        If seJadwalMaxApp.Value > 0 Then
            seJadwalDurasi.Value = 0
        End If
    End Sub

    Private Sub lueSpesialis_EditValueChanged(sender As Object, e As EventArgs) Handles lueSpesialis.EditValueChanged
        If lueSpesialis.EditValue Is Nothing Then Exit Sub
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idlokasi as id,nama as content from lokasi where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and iddepartment in (select case when variable='IDSPKFR' then (select value from sys_appsetting where variable='IDPhysioDept') when variable='IDSPPK' then (select value from sys_appsetting where variable='IDLabDept') when variable='IDSPRad' then (select value from sys_appsetting where variable='IDRadDept') end as iddepartment from sys_appsetting where variable in ('IDSPPK','IDSPRad','IDSPKFR') and [value]='" & lueSpesialis.EditValue & "')", "jadwallokasi")
        lueJadwalLokasi.Properties.DataSource = sqls.dataTable("jadwallokasi")
        lueJadwalLokasi.Properties.DisplayMember = "content"
        lueJadwalLokasi.Properties.ValueMember = "id"
        lueJadwalLokasi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueJadwalLokasi.Properties.BestFit()
        lueJadwalLokasi.EditValue = Nothing
        If sqls.getDataSet("jadwallokasi") = 0 Then

            sqls.DMLQuery("select idlokasi as id,nama as content from lokasi where idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and lokasitype=3 and iddepartment in (select [value] from sys_appsetting where variable='IDOutpatientDept') order by nama asc", "jadwallokasi2")
            lueJadwalLokasi.Properties.DataSource = sqls.dataTable("jadwallokasi2")
            lueJadwalLokasi.Properties.DisplayMember = "content"
            lueJadwalLokasi.Properties.ValueMember = "id"
            lueJadwalLokasi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
            lueJadwalLokasi.Properties.BestFit()

            If sqls.getDataSet("jadwallokasi2") = 0 Then
                dizMsgbox("Ruang tidak ditemukan" & vbCrLf & "Ruang harap entry dulu", dizMsgboxStyle.Peringatan, Me)
                pExit_Click(Me, Nothing)
                Exit Sub
            ElseIf sqls.getDataSet("jadwallokasi2") = 1 Then
                lueJadwalLokasi.EditValue = sqls.getDataSet("jadwallokasi2", 0, "id")
            End If
        ElseIf sqls.getDataSet("jadwallokasi") = 1 Then
            lueJadwalLokasi.EditValue = sqls.getDataSet("jadwallokasi", 0, "id")
        End If
    End Sub

End Class