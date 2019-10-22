Public Class frmRMRequest
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

    Private Sub frmManajemenBerkasRM_Load(sender As Object, e As EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        deTanggalMutasi.EditValue = Nothing
        gvData.ViewCaption = " "
        deTanggalMutasi.EditValue = nowTime
        Threading.Thread.Sleep(100)

        kosongkanisian()
        loadlov()

        If usersuper = 0 Then
            lueUsernameRequest.EditValue = userid
            lueUsernameRequest.Enabled = False
        Else
            lueUsernameRequest.EditValue = userid
        End If
    End Sub

    Private Sub loadlov()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select iduser as id,username as content from sys_user order by username asc", "userreq")
        lueUsernameRequest.Properties.DataSource = sqls.dataTable("userreq")
        lueUsernameRequest.Properties.ValueMember = "id"
        lueUsernameRequest.Properties.DisplayMember = "content"
        lueUsernameRequest.EditValue = Nothing

        sqls.DMLQuery("select iduser as id,username as content from sys_user order by username asc", "userrec")
        lueUsernameTerima.Properties.DataSource = sqls.dataTable("userrec")
        lueUsernameTerima.Properties.ValueMember = "id"
        lueUsernameTerima.Properties.DisplayMember = "content"
        lueUsernameTerima.EditValue = Nothing

        sqls.DMLQuery("select idlokasi as id,nama as content from lokasi order by nama asc", "lokasi")
        lueLokasi.Properties.DataSource = sqls.dataTable("lokasi")
        lueLokasi.Properties.ValueMember = "id"
        lueLokasi.Properties.DisplayMember = "content"
        lueLokasi.EditValue = Nothing
    End Sub

    Private idrm As String = ""
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If teSearch.EditValue Is Nothing Then
            dizMsgbox("Tidak disarankan melakukan pencarian seluruh Pasien", dizMsgboxStyle.Info, "Info", Me)
            Exit Sub
        End If
        If teSearch.Text.Replace(" ", "") = "" Then
            dizMsgbox("Tidak disarankan melakukan pencarian seluruh Pasien", dizMsgboxStyle.Info, "Info", Me)
            Exit Sub
        End If
        Dim appPath As String = Application.StartupPath
        If appPath.Chars(appPath.Length - 1) <> "\" Then
            appPath &= "\"
        End If

        Dim strQuery As String = "select r.idrekammedis as 'ID',del.generalcode as 'Status Data',dbo.fformatnorm(r.rekammedisno) as 'No RM',sap.generalcode + ' ' + r.nama as 'Nama Pasien',st.generalcode as 'Jenis Kelamin',w.wilayah as 'Warganegara',kot.wilayah as 'Tempat Lahir',convert(varchar,r.tanggallahir,105) as 'Tgl Lahir',ms.generalcode as 'Status Pernikahan',isnull(a.alamat,'-') as 'Alamat',isnull(telk.phone,convert(varchar,0)) + ' ext. ' + isnull(telk.extension,convert(varchar,0)) as 'Telp Kantor',isnull(telr.phone,0) as 'Telp Rumah',isnull(telh.phone,0) as 'Handphone' from rekammedis r left join sys_generalcode sap on r.sapaan=sap.idgeneral and sap.gctype='SAPAAN' left join sys_generalcode st on r.jeniskelamin=st.idgeneral and st.gctype='SEXTYPE' left join sys_generalcode ms on r.pernikahan=ms.idgeneral and ms.gctype='MARITALSTATUS' left join alamat a on r.idrekammedis=a.idreff and a.tablereff='PASIEN'and a.isprimary=1 and a.isdeleted=0 left join wilayah w on r.kewarganegaraan=w.idwilayah left join wilayah kot on r.kotalahir=kot.idwilayah left join phone telk on r.idrekammedis=telk.idreff and telk.tablereff='PASIEN' and telk.isprimary=1 and telk.isdeleted=0 and telk.phonetype=1 left join phone telr on r.idrekammedis=telr.idreff and telr.tablereff='PASIEN' and telr.isprimary=1 and telr.isdeleted=0 and telr.phonetype=2 left join phone telh on r.idrekammedis=telh.idreff and telh.tablereff='PASIEN' and telh.isprimary=1 and telh.isdeleted=0 and telh.phonetype=3 left join sys_generalcode del on r.isdeleted=del.idgeneral and del.gctype='delete' where r.rekammedisno<>0 and (r.nama like '%" & teSearch.Text & "%' or convert(varchar,r.rekammedisno) like '%" & teSearch.Text & "%') order by r.rekammedisno desc"

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery(strQuery, "searchpasien")
        Dim cari As New frmSearch(sqls.dataSet, "searchpasien", "ID")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            idrm = cari.GetIDSelectData
            sqls.DMLQuery("select rm.isdeleted,rm.rekammedisno,rm.nama,rm.jeniskelamin,st.generalcode as sextype,convert(varchar,rm.tanggallahir,105) as tanggallahir from rekammedis rm left join sys_generalcode st on rm.jeniskelamin=st.idgeneral and st.gctype='SEXTYPE' where rm.idrekammedis='" & idrm & "'", "lama")
            teNoRM.Text = Format(CLng(sqls.getDataSet("lama", 0, "rekammedisno")), "0#######")
            teNama.Text = sqls.getDataSet("lama", 0, "nama")
            teJenisKelamin.Text = sqls.getDataSet("lama", 0, "sextype")
            teTglLahir.Text = sqls.getDataSet("lama", 0, "tanggallahir")
            lueUsernameRequest.EditValue = Nothing

            If usersuper = 0 Then
                lueUsernameRequest.EditValue = userid
                lueUsernameRequest.Enabled = False
            Else
                lueUsernameRequest.EditValue = userid
            End If
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        deTanggalMutasi_EditValueChanged(deTanggalMutasi, Nothing)
    End Sub

    Private Sub deTanggalMutasi_EditValueChanged(sender As Object, e As EventArgs) Handles deTanggalMutasi.EditValueChanged
        Dim cekRec As Boolean = True
        If deTanggalMutasi.EditValue Is Nothing Then cekRec = False
        If lueUsernameTerima.EditValue Is Nothing Then cekRec = False
        If cekRec = False Then
            gcData.DataSource = Nothing
            gvData.BestFitColumns()
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@tanggal", "@iduser"})
        value.AddRange(New Object() {Format(CDate(deTanggalMutasi.EditValue), "dd-MM-yyyy"), lueUsernameTerima.EditValue})
        sqls.CallSP("spMonRMRequest", "TrackingRM", field, value)
        gcData.DataSource = sqls.dataTable("TrackingRM")
        gvData.BestFitColumns()

        gvData.ViewCaption = "Request Berkas RM - " & CDate(deTanggalMutasi.EditValue).Day & " " & NamaBulan(CDate(deTanggalMutasi.EditValue).Month) & " " & CDate(deTanggalMutasi.EditValue).Year
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If idrm = "" Then
            dizMsgbox("Rekam Medis belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If lueUsernameRequest.EditValue Is Nothing Then
            dizMsgbox("Isian belum benar", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        If lueLokasi.EditValue Is Nothing Then
            dizMsgbox("Isian belum benar", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        Dim idunit As String = ""
        Dim iddept As String = ""
        sqls.DMLQuery("select iddepartment,idunit from lokasi where idlokasi='" & lueLokasi.EditValue & "'", "lokasi")
        idunit = sqls.getDataSet("lokasi", 0, "idunit")
        iddept = sqls.getDataSet("lokasi", 0, "iddepartment")

        Dim iddata As String = GenerateGUID()
        Dim currtime As Date = nowTime

        Dim pair As KeyValuePair(Of String, String) = generateno2(idunit, iddept, "Request RM", False)
        Dim notrans As String = pair.Value

        Dim dtsqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idtracking", "idreff", "tablereff", "noreff", "idreff2", "tablereff2", "noreff2", "trackingtype", "createdby", "createddate", "trackingdate", "trackingno", "borrowedby", "borroweddate", "requestby", "requestdate", "receivedby", "receiveddate", "idunit", "iddepartment", "idlokasi"})
        value.AddRange(New Object() {iddata, idrm, "Pasien", teNoRM.Text, "0", "-", "0", 2, userid, currtime, currtime, notrans, DBNull.Value, DBNull.Value, lueUsernameRequest.EditValue, currtime, DBNull.Value, DBNull.Value, idunit, iddept, lueLokasi.EditValue})
        dtsqls.datasetSave("tracking", iddata, field, value, False)
        kosongkanisian()
    End Sub

    Private Sub kosongkanisian()
        idrm = ""
        teNoRM.Text = "0"
        teNama.EditValue = Nothing
        teJenisKelamin.EditValue = Nothing
        teTglLahir.EditValue = Nothing
        lueLokasi.EditValue = Nothing
        lueUsernameRequest.EditValue = Nothing

        If usersuper = 0 Then
            lueUsernameRequest.EditValue = userid
            lueUsernameRequest.Enabled = False
        Else
            lueUsernameRequest.EditValue = userid
        End If
    End Sub

    Private Sub btndone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If gvData.RowCount = 0 Then
            dizMsgbox("Data Mutasi belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        Dim cekbool As Boolean = False
        For i As Integer = 0 To gvData.RowCount - 1
            Dim dra As DataRow = gvData.GetDataRow(i)
            If dra.RowState = DataRowState.Modified Then
                If dra("cek") = "True" Then
                    cekbool = True
                End If
            End If
        Next
        If cekbool = False Then
            dizMsgbox("Data Mutasi belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If

        For i As Integer = 0 To gvData.RowCount - 1
            Dim dra As DataRow = gvData.GetDataRow(i)
            If dra.RowState = DataRowState.Modified Then
                If dra("cek") = "True" Then
                    Dim iddata As String = dra("idtracking")
                    Dim sqls As New SQLs(dbstring)
                    sqls.DMLQuery("update tracking set trackingtype=8,updatedby='" & userid & "',updateddate=getdate() where isdeleted=0 and idtracking='" & iddata & "' and trackingtype=2 and receivedby is not null", False)
                    sqls.DMLQuery("update tracking set trackingtype=7,updatedby='" & userid & "',updateddate=getdate() where isdeleted=0 and idtracking='" & iddata & "' and trackingtype=1 and receivedby is not null", False)
                    sqls.DMLQuery("update tracking set trackingtype=6,updatedby='" & userid & "',updateddate=getdate() where isdeleted=0 and idtracking='" & iddata & "' and trackingtype=0 and receivedby is not null", False)
                End If
                dra("cek") = 0
            End If
        Next
        'Dim dr As DataRow
        'If gvData.RowCount = 1 Then
        '    dr = gvData.GetDataRow(0)
        'Else
        '    dr = gvData.GetDataRow(gvData.FocusedRowHandle)
        'End If

        btnRefresh_Click(btnRefresh, Nothing)
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If gvData.RowCount = 0 Then
            dizMsgbox("Data Mutasi belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        Dim cekbool As Boolean = False
        For i As Integer = 0 To gvData.RowCount - 1
            Dim dra As DataRow = gvData.GetDataRow(i)
            If dra.RowState = DataRowState.Modified Then
                If dra("cek") = "True" Then
                    cekbool = True
                End If
            End If
        Next
        If cekbool = False Then
            dizMsgbox("Data Mutasi belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If

        'Dim dr As DataRow
        'If gvData.RowCount = 1 Then
        '    dr = gvData.GetDataRow(0)
        'Else
        '    dr = gvData.GetDataRow(gvData.FocusedRowHandle)
        'End If
        For i As Integer = 0 To gvData.RowCount - 1
            Dim dra As DataRow = gvData.GetDataRow(i)
            If dra.RowState = DataRowState.Modified Then
                If dra("cek") = "True" Then
                    Dim iddata As String = dra("idtracking")
                    Dim sqls As New SQLs(dbstring)
                    sqls.DMLQuery("update tracking set receivedby='" & userid & "',receiveddate=getdate(),updatedby='" & userid & "',updateddate=getdate() where isdeleted=0 and idtracking='" & iddata & "' and receivedby is null and borrowedby is not null", False)
                    sqls.DMLQuery("update rekammedis set idlokasiskrg=(select idlokasi from tracking where idtracking='" & iddata & "') where idrekammedis=(select idreff from tracking where isdeleted=0 and idtracking='" & iddata & "' and receivedby is not null and borrowedby is not null)", False)
                End If
                dra("cek") = 0
            End If
        Next
        btnRefresh_Click(btnRefresh, Nothing)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If gvData.RowCount = 0 Then
            dizMsgbox("Data Mutasi belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If
        Dim cekbool As Boolean = False
        For i As Integer = 0 To gvData.RowCount - 1
            Dim dra As DataRow = gvData.GetDataRow(i)
            If dra.RowState = DataRowState.Modified Then
                If dra("cek") = "True" Then
                    cekbool = True
                End If
            End If
        Next
        If cekbool = False Then
            dizMsgbox("Data Mutasi belum dipilih", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If

        'Dim dr As DataRow
        'If gvData.RowCount = 1 Then
        '    dr = gvData.GetDataRow(0)
        'Else
        '    dr = gvData.GetDataRow(gvData.FocusedRowHandle)
        'End If
        For i As Integer = 0 To gvData.RowCount - 1
            Dim dra As DataRow = gvData.GetDataRow(i)
            If dra.RowState = DataRowState.Modified Then
                If dra("cek") = "True" Then
                    Dim iddata As String = dra("idtracking")
                    Dim sqls As New SQLs(dbstring)
                    sqls.DMLQuery("update tracking set trackingtype=3,isdeleted=1,updatedby='" & userid & "',updateddate=getdate() where idtracking='" & iddata & "' and trackingtype=0 and isdeleted=0", False)
                    sqls.DMLQuery("update tracking set trackingtype=4,isdeleted=1,updatedby='" & userid & "',updateddate=getdate() where idtracking='" & iddata & "' and trackingtype=1 and isdeleted=0", False)
                    sqls.DMLQuery("update tracking set trackingtype=5,isdeleted=1,updatedby='" & userid & "',updateddate=getdate() where idtracking='" & iddata & "' and trackingtype=2 and isdeleted=0", False)
                End If
                dra("cek") = 0
            End If
        Next

        btnRefresh_Click(btnRefresh, Nothing)
    End Sub

    Private Sub lueUsernameTerima_EditValueChanged(sender As Object, e As EventArgs) Handles lueUsernameTerima.EditValueChanged
        deTanggalMutasi_EditValueChanged(deTanggalMutasi, Nothing)
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

    Private Sub btnMultiRM_Click(sender As Object, e As EventArgs) Handles btnMultiRM.Click
        formTitle = "Request Berkas RM 2"
        Dim frmMon As New frmRMRequestMulti
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