Public Class frmLaboratoriumRujukan
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

    Private fromGridChild As Boolean = False
    Private fromGrid As Boolean = False

    Private Sub loadGrid()
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select bp.idbusinesspartner,bp.isdeleted,d.generalcode as statdata,bp.businesspartnertype,gc.generalcode as type,bp.paymenttype,pt.generalcode as jenisbayar,bp.kode,bp.nama from businesspartner bp left join sys_generalcode pt on bp.paymenttype=pt.idgeneral and pt.gctype='PAYTYPE' left join sys_generalcode gc on gc.idgeneral=bp.businesspartnertype and gc.gctype='BPTYPE' left join sys_generalcode d on d.idgeneral=bp.isdeleted and d.gctype='DELETE' WHERE bp.businesspartnertype=(select top 1 idgeneral from sys_generalcode where generalcode='LABORATORIUM' and gctype='BPTYPE') ORDER BY type asc,nama asc", "data")
        gcData.DataSource = mysqls.dataTable("data")
        gvData.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub loadEmail(idreff As String)
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        fromGridChild = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select e.idemail,e.email,e.emailtype,e.isdeleted,e.isprimary,del.generalcode as statdata,pri.generalcode as [primary],et.generalcode as jenisemail from email e left join sys_generalcode et on e.emailtype=et.idgeneral and et.gctype='EMAILTYPE' left join sys_generalcode del on e.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode pri on e.isprimary=pri.idgeneral and pri.gctype='ISPRIMARY' where e.tablereff='BP' and e.idreff='" & idreff & "'", "email")
        gcEmail.DataSource = sqls.dataTable("email")
        gvEmail.BestFitColumns()
        fromGridChild = True

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub loadPhone(idreff As String)
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        fromGridChild = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select p.idphone,p.phone,p.extension,p.phonetype,p.isdeleted,p.isprimary,del.generalcode as statdata,pri.generalcode as [primary],et.generalcode as jenistelepon from phone p left join sys_generalcode et on p.phonetype=et.idgeneral and et.gctype='PHONETYPE' left join sys_generalcode del on p.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode pri on p.isprimary=pri.idgeneral and pri.gctype='ISPRIMARY' where p.tablereff='BP' and p.idreff='" & idreff & "'", "phone")
        gcTelepon.DataSource = sqls.dataTable("phone")
        gvTelepon.BestFitColumns()
        fromGridChild = True

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub loadAlamat(idreff As String)
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        fromGridChild = False
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select a.idalamat,a.idnegara,a.idpropinsi,a.idkabupaten,a.idkecamatan,a.idkelurahan,a.alamat,a.addresstype,a.isdeleted,a.isprimary,n.wilayah as negara,p.wilayah as propinsi,b.wilayah as kabupaten,c.wilayah as kecamatan,l.wilayah as kelurahan,del.generalcode as statdata,pri.generalcode as [primary],adt.generalcode as jenisalamat,a.kodepos  from alamat a left join wilayah n on a.idnegara=n.idwilayah left join wilayah p on a.idpropinsi=p.idwilayah left join wilayah b on a.idkabupaten=b.idwilayah left join wilayah c on a.idkecamatan=c.idwilayah left join wilayah l on a.idkelurahan=l.idwilayah left join sys_generalcode del on a.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode pri on a.isprimary=pri.idgeneral and pri.gctype='ISPRIMARY' left join sys_generalcode adt on a.addresstype=adt.idgeneral and adt.gctype='ADDRESSTYPE' where a.tablereff='BP' and a.idreff='" & idreff & "'", "alamat")
        gcAlamat.DataSource = sqls.dataTable("alamat")
        gvAlamat.BestFitColumns()
        fromGridChild = True

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub loadLOV()
        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where generalcode='LABORATORIUM' and gctype='BPTYPE'", "type")
        lueType.Properties.DataSource = mysqls.dataTable("type")
        lueType.Properties.ValueMember = "id"
        lueType.Properties.DisplayMember = "content"

        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='PAYTYPE'", "paytype")
        luePaymentType.Properties.DataSource = mysqls.dataTable("paytype")
        luePaymentType.Properties.ValueMember = "id"
        luePaymentType.Properties.DisplayMember = "content"

        mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isnull(isdeleted,0)=0 and levelwilayah=1", "negara")
        lueNegara.Properties.DataSource = mysqls.dataTable("negara")
        lueNegara.Properties.DisplayMember = "content"
        lueNegara.Properties.ValueMember = "id"
        lueNegara.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueNegara.Properties.BestFit()
        If mysqls.getDataSet("negara") = 0 Then
            dizMsgbox("Negara tidak ditemukan" & vbCrLf & "Negara harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If
        lueKelurahan.EditValue = Nothing
        lueKecamatan.EditValue = Nothing
        lueKabupaten.EditValue = Nothing
        luePropinsi.EditValue = Nothing

        mysqls.DMLQuery("select idgeneral as id, generalcode as content,priority from sys_generalcode where gctype='ADDRESSTYPE' order by priority asc", "addresstype")
        lueAddressType.Properties.DataSource = mysqls.dataTable("addresstype")
        lueAddressType.Properties.DisplayMember = "content"
        lueAddressType.Properties.ValueMember = "id"
        lueAddressType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueAddressType.Properties.BestFit()

        mysqls.DMLQuery("select idgeneral as id, generalcode as content,priority from sys_generalcode where gctype='EMAILTYPE' order by priority asc", "emailtype")
        lueEmailType.Properties.DataSource = mysqls.dataTable("emailtype")
        lueEmailType.Properties.DisplayMember = "content"
        lueEmailType.Properties.ValueMember = "id"
        lueEmailType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueEmailType.Properties.BestFit()

        mysqls.DMLQuery("select idgeneral as id, generalcode as content,priority from sys_generalcode where gctype='PHONETYPE' order by priority asc", "phonetype")
        luePhoneType.Properties.DataSource = mysqls.dataTable("phonetype")
        luePhoneType.Properties.DisplayMember = "content"
        luePhoneType.Properties.ValueMember = "id"
        luePhoneType.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        luePhoneType.Properties.BestFit()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        loadGrid()

        xtcProfile.SelectedTabPage = xtpEntry
        tbAdditional.SelectedItem = tbiAlamat
        TileBoxItem_ItemClick(tbiAlamat, Nothing)

        tbAdditional.Enabled = False
        'xtcAdditional.SelectedTabPage = xtpAddress
        xtcAdditional.Enabled = False
        btnExport.Enabled = False
        kosongkanIsian(tlpAlamat1)
        kosongkanIsian(tlpAlamat1)
        kosongkanIsian(tlpEmail)
        kosongkanIsian(tlpTelepon)

        lueType.Properties.Appearance.BackColor = canWrite
        lueType.Properties.ReadOnly = False
        lueType.Enabled = True

        luePaymentType.Properties.Appearance.BackColor = canWrite
        luePaymentType.Properties.ReadOnly = False
        luePaymentType.Enabled = True

        kosongkanIsian(tlpField)
        btnNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnDelete.Text = "HAPUS"
        statData = statusData.Baru
    End Sub

    Private Sub lueNegara_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueNegara.EditValueChanged
        Try
            If fromGridChild = True Then Exit Sub
            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isnull(isdeleted,0)=0 and idparent='" & sender.EditValue & "'", "propinsi")
            luePropinsi.Properties.DataSource = mysqls.dataTable("propinsi")
            luePropinsi.Properties.DisplayMember = "content"
            luePropinsi.Properties.ValueMember = "id"
            luePropinsi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

            luePropinsi.EditValue = Nothing
        Catch ex As Exception
            luePropinsi.Properties.DataSource = Nothing
            luePropinsi.EditValue = Nothing
        End Try
    End Sub

    Private Sub luePropinsi_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePropinsi.EditValueChanged
        Try
            If fromGridChild = True Then Exit Sub
            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isnull(isdeleted,0)=0 and idparent='" & sender.EditValue & "'", "kabupaten")
            lueKabupaten.Properties.DataSource = mysqls.dataTable("kabupaten")
            lueKabupaten.Properties.DisplayMember = "content"
            lueKabupaten.Properties.ValueMember = "id"
            lueKabupaten.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

            lueKabupaten.EditValue = Nothing
        Catch ex As Exception
            lueKabupaten.Properties.DataSource = Nothing
            lueKabupaten.EditValue = Nothing
        End Try
    End Sub

    Private Sub lueKabupaten_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueKabupaten.EditValueChanged
        Try
            If fromGridChild = True Then Exit Sub
            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isnull(isdeleted,0)=0 and idparent='" & sender.EditValue & "'", "kecamatan")
            lueKecamatan.Properties.DataSource = mysqls.dataTable("kecamatan")
            lueKecamatan.Properties.DisplayMember = "content"
            lueKecamatan.Properties.ValueMember = "id"
            lueKecamatan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

            lueKecamatan.EditValue = Nothing
        Catch ex As Exception
            lueKecamatan.Properties.DataSource = Nothing
            lueKecamatan.EditValue = Nothing
        End Try
    End Sub

    Private Sub lueKelurahan_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueKelurahan.EditValueChanged
        Try
            If fromGridChild = True Then Exit Sub
            Dim mysqls As New SQLs(dbstring)
            mysqls.DMLQuery("select idwilayah as id, wilayah as content from wilayah where isnull(isdeleted,0)=0 and idparent='" & sender.EditValue & "'", "kelurahan")
            lueKelurahan.Properties.DataSource = mysqls.dataTable("kelurahan")
            lueKelurahan.Properties.DisplayMember = "content"
            lueKelurahan.Properties.ValueMember = "id"
            lueKelurahan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup

            lueKelurahan.EditValue = Nothing
        Catch ex As Exception
            lueKelurahan.Properties.DataSource = Nothing
            lueKelurahan.EditValue = Nothing
        End Try
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

    Private statData As statusData = statusData.Baru
    Private statDataChild As statusData = statusData.Baru
    Private idData As String = "-1"
    Private idDataChild As String = "-1"

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If checkEntry(tlpField) = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If statData = statusData.Baru Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select nama from businesspartner where replace(nama,' ','')='" & teNama.Text.Replace(" ", "") & "' and businesspartnertype='" & lueType.EditValue & "'", "exist")
            If sqls.getDataSet("exist") = 0 Then
                idData = "-1"
            Else
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teNama.Focus()
                Exit Sub
            End If
        ElseIf statData = statusData.Edit Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select nama from businesspartner where (nama,' ','')='" & teNama.Text.Replace(" ", "") & "' and businesspartnertype='" & lueType.EditValue & "' and idbusinesspartner<>'" & idData & "'", "exist")
            If sqls.getDataSet("exist") > 0 Then
                dizMsgbox("Data tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teNama.Focus()
                Exit Sub
            End If
        End If

        Dim sqls1 As New SQLs(dbstring)
        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        Dim dtSQL As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        If statData = statusData.Baru Then
            idData = GenerateGUID()
            teKode.Text = generateno3("", lueType.Text.ToUpper.Chars(0), "yyyy", False)
            field.AddRange(New String() {"idbusinesspartner", "idcompany", "businesspartnertype", "kode", "nama", "paymenttype", "isdeleted", "createdby", "createddate"})
            value.AddRange(New Object() {idData, idcomp, lueType.EditValue, teKode.Text, teNama.Text, luePaymentType.EditValue, 0, userid, nowTime})
        Else
            field.AddRange(New String() {"idbusinesspartner", "nama", "paymenttype", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, teNama.Text, luePaymentType.EditValue, userid, nowTime})
        End If

        If dtSQL.datasetSave("businesspartner", idData, field, value, False) = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            isiLog(userid, dbstring, field, value, "businesspartner")

            btnNew_Click(Me, Nothing)
        Else
            dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim retval As Boolean = False
        Dim sqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If btnDelete.Text = "HAPUS" Then
            field.AddRange(New String() {"idbusinesspartner", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 1, userid, nowTime})
            retval = sqls.datasetSave("businesspartner", idData, field, value, False)
            If retval Then
                btnDelete.Text = "AKTIF"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        Else
            field.AddRange(New String() {"idbusinesspartner", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 0, userid, nowTime})
            retval = sqls.datasetSave("businesspartner", idData, field, value, False)
            If retval Then
                btnDelete.Text = "HAPUS"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        End If
        isiLog(userid, dbstring, field, value, "businesspartner")
        btnNew_Click(Me, Nothing)
    End Sub

    Private isdeleted As String = ""
    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        Try
            fromGrid = True
            Dim dcol As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
            lueType.Properties.Appearance.BackColor = justRead
            lueType.Properties.ReadOnly = True
            lueType.EditValue = dcol("businesspartnertype")

            teKode.Text = dcol("kode")
            teNama.Text = dcol("nama")

            idData = dcol("idbusinesspartner")
            luePaymentType.EditValue = dcol("paymenttype")
            statData = statusData.Edit
            isdeleted = dcol("isdeleted")
            If isdeleted = 1 Then
                btnDelete.Text = "AKTIF"
            Else
                btnDelete.Text = "HAPUS"
            End If

            btnNew.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True

            tbAdditional.SelectedItem = tbiAlamat
            TileBoxItem_ItemClick(tbiAlamat, Nothing)
            tbAdditional.Enabled = True
            'xtcAdditional.SelectedTabPage = xtpAddress
            xtcAdditional.Enabled = True

            loadAlamat(idData)
            btnNewAlamat_Click(btnNewAlamat, Nothing)
            loadEmail(idData)
            loadPhone(idData)

            fromGridChild = False
            fromGrid = False
        Catch ex As Exception
            btnNew_Click(Me, Nothing)
        End Try
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        luePaymentType.Properties.ReadOnly = False
        luePaymentType.Properties.Appearance.BackColor = canWrite
        checkFieldMaxLength(dbstring, tlpField, "businesspartner")
        checkFieldMaxLength(dbstring, tlpAlamat1, "alamat")
        checkFieldMaxLength(dbstring, tlpAlamat2, "alamat")
        checkFieldMaxLength(dbstring, tlpEmail, "email")
        checkFieldMaxLength(dbstring, tlpTelepon, "phone")

        loadLOV()
        btnNew_Click(Me, Nothing)
    End Sub

    Private Sub lueType_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueType.EditValueChanged
        If sender.editvalue Is Nothing Then
            teKode.Text = "XXXXX-XXXX"
            luePaymentType.Properties.ReadOnly = True
            luePaymentType.Properties.Appearance.BackColor = justRead
            Exit Sub
        End If
        teKode.Text = lueType.Text.ToUpper.Chars(0) & "XXXX-XXXX"
        If lueType.EditValue = 1 Then
            luePaymentType.EditValue = 1
        ElseIf lueType.EditValue = 2 Then
            luePaymentType.EditValue = 0
        End If
        luePaymentType.Properties.ReadOnly = False
        luePaymentType.Properties.Appearance.BackColor = canWrite
    End Sub

    Private Sub xtcProfile_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtcProfile.SelectedPageChanged
        If e.Page Is xtpData Then
            btnExport.Enabled = True
        Else
            btnExport.Enabled = False
        End If
    End Sub

    Private Sub TileBoxItem_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles tbiAlamat.ItemClick, tbiEmail.ItemClick, tbiTelepon.ItemClick
        If sender Is tbiAlamat Then
            xtcAdditional.SelectedTabPage = xtpAddress
        ElseIf sender Is tbiEmail Then
            xtcAdditional.SelectedTabPage = xtpEmail
        ElseIf sender Is tbiTelepon Then
            xtcAdditional.SelectedTabPage = xtpTelepon
        End If
    End Sub

    Private Sub btnNewEmail_Click(sender As Object, e As EventArgs) Handles btnNewEmail.Click
        kosongkanIsian(tlpEmail)

        btnNewEmail.Enabled = False
        btnSaveEmail.Enabled = True
        btnPrimaryEmail.Enabled = False
        btnPrimaryEmail.Text = "PRIMARY"
        btnDeleteEmail.Enabled = False
        btnDeleteEmail.Text = "HAPUS"
        statDataChild = statusData.Baru
        fromGridChild = False
        idDatachild = "-1"
    End Sub

    Private Sub btnDeleteEmail_Click(sender As Object, e As EventArgs) Handles btnDeleteEmail.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idemail", "isdeleted", "updatedby", "updateddate"})
        If btnDeleteEmail.Text = "HAPUS" Then
            value.AddRange(New Object() {idDataChild, 1, userid, nowTime})
            dtsql.datasetSave("email", idDataChild, field, value, False)
            btnDeleteEmail.Text = "AKTIF"
        ElseIf btnDeleteEmail.Text = "AKTIF" Then
            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("email", idDataChild, field, value, False)
            btnDeleteEmail.Text = "HAPUS"
        End If
        loadEmail(idData)
        btnNewEmail_Click(btnNewEmail, Nothing)
    End Sub

    Private Sub btnSaveEmail_Click(sender As Object, e As EventArgs) Handles btnSaveEmail.Click
        Dim bentry As Boolean = True
        bentry = checkEntry(tlpEmail)
        If bentry = False Then
            dizMsgbox("Data Email belum diisi dengan benar", dizMsgboxStyle.Peringatan, "Peringatan", Me)
            Exit Sub
        End If
        If statDataChild = statusData.Baru Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select email from email where tablereff='BP' and idreff='" & idData & "' and email='" & teEmail.Text & "'", "cek")
            If sqls.getDataSet("cek") = 0 Then
                idDatachild = "-1"
            Else
                dizMsgbox("Email tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teEmail.Focus()
                Exit Sub
            End If

            Dim sqls1 As New SQLs(dbstring)
            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idemail", "idcompany", "idreff", "tablereff", "email", "emailtype", "isdeleted", "isprimary", "createdby", "createddate"})
            idDataChild = GenerateGUID()
            If gvAlamat.RowCount = 0 Then
                value.AddRange(New Object() {idDataChild, idcomp, idData, "BP", teEmail.Text, lueEmailType.EditValue, 0, 1, userid, nowTime})
            Else
                value.AddRange(New Object() {idDataChild, idcomp, idData, "BP", teEmail.Text, lueEmailType.EditValue, 0, 0, userid, nowTime})
            End If
            If dtsql.datasetSave("email", idDataChild, field, value, False) = True Then
                dizMsgbox("Email telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then

            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idemail", "idreff", "tablereff", "email", "emailtype", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, idData, "BP", teEmail.Text, lueEmailType.EditValue, userid, nowTime})
            If dtsql.datasetSave("email", idDataChild, field, value, False) = True Then
                dizMsgbox("Email telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        End If
        loadEmail(idData)
        btnNewEmail_Click(btnNewEmail, Nothing)
    End Sub

    Private Sub btnPrimaryEmail_Click(sender As Object, e As EventArgs) Handles btnPrimaryEmail.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idemail", "isprimary", "updatedby", "updateddate"})
        If btnPrimaryAlamat.Text = "PRIMARY" Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("update email set isprimary=0 where idreff='" & idData & "' and tablereff='BP'", False)

            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("email", idDataChild, field, value, False)
            btnPrimaryAlamat.Text = "NOT PRIMARY"
        ElseIf btnDeleteAlamat.Text = "NOT PRIMARY" Then
            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("email", idDataChild, field, value, False)
            btnPrimaryAlamat.Text = "PRIMARY"
        End If
        loadEmail(idData)
        btnNewEmail_Click(btnNewEmail, Nothing)
    End Sub

    Private Sub gvEmail_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvEmail.FocusedRowChanged
        fromGridChild = True
        Dim dcol As DataRow = gvEmail.GetDataRow(e.FocusedRowHandle)

        statDataChild = statusData.Edit
        idDataChild = dcol("idemail")
        lueEmailType.EditValue = dcol("emailtype")
        teEmail.Text = dcol("email")
        If dcol("isprimary") = 0 Then
            btnPrimaryEmail.Text = "PRIMARY"
        ElseIf dcol("isprimary") = 1 Then
            btnPrimaryEmail.Text = "NOT PRIMARY"
        End If
        If dcol("isdeleted") = 0 Then
            btnDeleteEmail.Text = "AKTIF"
        ElseIf dcol("isdeleted") = 1 Then
            btnDeleteEmail.Text = "HAPUS"
        End If
        btnNewEmail.Enabled = True
        btnSaveEmail.Enabled = True
        btnDeleteEmail.Enabled = True
        fromGridChild = False
    End Sub

    Private Sub btnNewtelepon_Click(sender As Object, e As EventArgs) Handles btnNewTelepon.Click
        kosongkanIsian(tlpTelepon)

        btnNewTelepon.Enabled = False
        btnSaveTelepon.Enabled = True
        btnPrimaryTelepon.Enabled = False
        btnPrimaryTelepon.Text = "PRIMARY"
        btnDeleteTelepon.Enabled = False
        btnDeleteTelepon.Text = "HAPUS"
        statDataChild = statusData.Baru
        fromGridChild = False
        idDatachild = "-1"
    End Sub

    Private Sub btnPrimaryTelepon_Click(sender As Object, e As EventArgs) Handles btnPrimaryTelepon.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idphone", "isprimary", "updatedby", "updateddate"})
        If btnPrimaryAlamat.Text = "PRIMARY" Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("update phone set isprimary=0 where phonetype='" & luePhoneType.EditValue & "' and idreff='" & idData & "' and tablereff='BP'", False)

            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("phone", idDataChild, field, value, False)
            btnPrimaryAlamat.Text = "NOT PRIMARY"
        ElseIf btnDeleteAlamat.Text = "NOT PRIMARY" Then
            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("phone", idDataChild, field, value, False)
            btnPrimaryAlamat.Text = "PRIMARY"
        End If
        loadPhone(idData)
        btnNewtelepon_Click(btnNewTelepon, Nothing)
    End Sub

    Private Sub btnDeleteTelepon_Click(sender As Object, e As EventArgs) Handles btnDeleteTelepon.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idphone", "isdeleted", "updatedby", "updateddate"})
        If btnDeleteTelepon.Text = "HAPUS" Then
            value.AddRange(New Object() {idDataChild, 1, userid, nowTime})
            dtsql.datasetSave("phone", idDataChild, field, value, False)
            btnDeleteTelepon.Text = "AKTIF"
        ElseIf btnDeleteTelepon.Text = "AKTIF" Then
            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("phone", idDataChild, field, value, False)
            btnDeleteTelepon.Text = "HAPUS"
        End If
        loadPhone(idData)
        btnNewtelepon_Click(btnNewTelepon, Nothing)
    End Sub

    Private Sub btnSaveTelepon_Click(sender As Object, e As EventArgs) Handles btnSaveTelepon.Click
        Dim bentry As Boolean = True
        bentry = checkEntry(tlpTelepon)
        If bentry = False Then
            dizMsgbox("Data Telepon belum diisi dengan benar", dizMsgboxStyle.Peringatan, "Peringatan", Me)
            Exit Sub
        End If
        If statDataChild = statusData.Baru Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select phone from phone where tablereff='BP' and idreff='" & idData & "' and phone='" & tePhone.Text & "'", "cek")
            If sqls.getDataSet("cek") = 0 Then
                idDatachild = "-1"
            Else
                dizMsgbox("Telepon tersebut sudah ada", dizMsgboxStyle.Info, Me)
                teEmail.Focus()
                Exit Sub
            End If

            Dim sqls1 As New SQLs(dbstring)
            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idphone", "idcompany", "idreff", "tablereff", "phone", "extension", "phonetype", "isdeleted", "isprimary", "createdby", "createddate"})
            idDataChild = GenerateGUID()
            If gvTelepon.RowCount = 0 Then
                value.AddRange(New Object() {idDataChild, idcomp, idData, "BP", tePhone.Text, teExtension.Text, luePhoneType.EditValue, 0, 1, userid, nowTime})
            Else
                value.AddRange(New Object() {idDataChild, idcomp, idData, "BP", tePhone.Text, teExtension.Text, luePhoneType.EditValue, 0, 0, userid, nowTime})
            End If
            If dtsql.datasetSave("phone", idDataChild, field, value, False) = True Then
                dizMsgbox("Telepon telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then

            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idphone", "idreff", "tablereff", "phone", "extension", "phonetype", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, idData, "BP", tePhone.Text, teExtension.Text, luePhoneType.EditValue, userid, nowTime})

            If dtsql.datasetSave("phone", idDataChild, field, value, False) = True Then
                dizMsgbox("Telepon telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        End If
        loadPhone(idData)
        btnNewtelepon_Click(btnNewTelepon, Nothing)
    End Sub

    Private Sub gvTelepon_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvTelepon.FocusedRowChanged
        Dim dcol As DataRow = gvTelepon.GetDataRow(e.FocusedRowHandle)

        statDataChild = statusData.Edit
        idDataChild = dcol("idphone")
        luePhoneType.EditValue = dcol("phonetype")
        tePhone.Text = dcol("phone")
        If dcol("isprimary") = 0 Then
            btnPrimaryTelepon.Text = "PRIMARY"
        ElseIf dcol("isprimary") = 1 Then
            btnPrimaryTelepon.Text = "NOT PRIMARY"
        End If
        If dcol("isdeleted") = 0 Then
            btnDeleteTelepon.Text = "AKTIF"
        ElseIf dcol("isdeleted") = 1 Then
            btnDeleteTelepon.Text = "HAPUS"
        End If
        btnNewTelepon.Enabled = True
        btnSaveTelepon.Enabled = True
        btnDeleteTelepon.Enabled = True
    End Sub

    Private Sub Angka_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tePhone.KeyPress, teExtension.KeyPress, teKodepos.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rNumeric) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Email_KeyPress(sender As Object, e As KeyPressEventArgs) Handles teEmail.KeyPress
        If System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, rEmail) = False And Asc(e.KeyChar) <> 8 Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnNewAlamat_Click(sender As Object, e As EventArgs) Handles btnNewAlamat.Click
        kosongkanIsian(tlpAlamat1)
        kosongkanIsian(tlpAlamat2)

        btnNewAlamat.Enabled = False
        btnSaveAlamat.Enabled = True
        btnPrimaryAlamat.Enabled = False
        btnPrimaryAlamat.Text = "PRIMARY"
        btnDeleteAlamat.Enabled = False
        btnDeleteAlamat.Text = "HAPUS"
        statDataChild = statusData.Baru
        fromGridChild = False
        idDatachild = "-1"
    End Sub

    Private Sub btnPrimaryAlamat_Click(sender As Object, e As EventArgs) Handles btnPrimaryAlamat.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idalamat", "isprimary", "updatedby", "updateddate"})
        If btnPrimaryAlamat.Text = "PRIMARY" Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("update alamat set isprimary=0 where idreff='" & idData & "' and tablereff='BP'", False)

            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("alamat", idDataChild, field, value, False)
            btnPrimaryAlamat.Text = "NOT PRIMARY"
        ElseIf btnDeleteAlamat.Text = "NOT PRIMARY" Then
            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("alamat", idDataChild, field, value, False)
            btnPrimaryAlamat.Text = "PRIMARY"
        End If
        loadAlamat(idData)
        btnNewAlamat_Click(btnNewAlamat, Nothing)
    End Sub

    Private Sub btnDeleteAlamat_Click(sender As Object, e As EventArgs) Handles btnDeleteAlamat.Click
        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idalamat", "isdeleted", "updatedby", "updateddate"})
        If btnDeleteAlamat.Text = "HAPUS" Then
            value.AddRange(New Object() {idDataChild, 1, userid, nowTime})
            dtsql.datasetSave("alamat", idDataChild, field, value, False)
            btnDeleteAlamat.Text = "AKTIF"
        ElseIf btnDeleteAlamat.Text = "AKTIF" Then
            value.AddRange(New Object() {idDataChild, 0, userid, nowTime})
            dtsql.datasetSave("alamat", idDataChild, field, value, False)
            btnDeleteAlamat.Text = "HAPUS"
        End If
        loadAlamat(idData)
        btnNewAlamat_Click(btnNewAlamat, Nothing)
    End Sub

    Private Sub btnSaveAlamat_Click(sender As Object, e As EventArgs) Handles btnSaveAlamat.Click
        Dim bentry As Boolean = True
        bentry = checkEntry(tlpAlamat1)
        bentry = checkEntry(tlpAlamat2)
        If bentry = False Then
            dizMsgbox("Data Alamat belum diisi dengan benar", dizMsgboxStyle.Peringatan, "Peringatan", Me)
            Exit Sub
        End If
        If statDataChild = statusData.Baru Then
            Dim sqls1 As New SQLs(dbstring)
            Dim sqlscomp As New SQLs(dbstring)
            sqlscomp.CallSP("spGetCompany", "CompID")
            Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idalamat", "idcompany", "idreff", "tablereff", "idnegara", "idpropinsi", "idkabupaten", "idkecamatan", "idkelurahan", "alamat", "addresstype", "kodepos", "isdeleted", "isprimary", "createdby", "createddate"})
            idDataChild = GenerateGUID()
            If gvAlamat.RowCount = 0 Then
                value.AddRange(New Object() {idDataChild, idcomp, idData, "BP", If(lueNegara.EditValue, CObj(DBNull.Value)), If(luePropinsi.EditValue, CObj(DBNull.Value)), If(lueKabupaten.EditValue, CObj(DBNull.Value)), If(lueKecamatan.EditValue, CObj(DBNull.Value)), If(lueKelurahan.EditValue, CObj(DBNull.Value)), meAlamat.Text, lueAddressType.EditValue, teKodepos.Text, 0, 1, userid, nowTime})
            Else
                value.AddRange(New Object() {idDataChild, idcomp, idData, "BP", If(lueNegara.EditValue, CObj(DBNull.Value)), If(luePropinsi.EditValue, CObj(DBNull.Value)), If(lueKabupaten.EditValue, CObj(DBNull.Value)), If(lueKecamatan.EditValue, CObj(DBNull.Value)), If(lueKelurahan.EditValue, CObj(DBNull.Value)), meAlamat.Text, lueAddressType.EditValue, teKodepos.Text, 0, 0, userid, nowTime})
            End If
            If dtsql.datasetSave("alamat", idDataChild, field, value, False) = True Then
                dizMsgbox("Alamat telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        ElseIf statDataChild = statusData.Edit Then
            Dim dtsql As New dtsetSQLS(dbstring)
            Dim field As New List(Of String)
            Dim value As New List(Of Object)
            field.AddRange(New String() {"idalamat", "idreff", "tablereff", "idnegara", "idpropinsi", "idkabupaten", "idkecamatan", "idkelurahan", "alamat", "addresstype", "kodepos", "updatedby", "updateddate"})
            value.AddRange(New Object() {idDataChild, idData, "BP", If(lueNegara.EditValue, CObj(DBNull.Value)), If(luePropinsi.EditValue, CObj(DBNull.Value)), If(lueKabupaten.EditValue, CObj(DBNull.Value)), If(lueKecamatan.EditValue, CObj(DBNull.Value)), If(lueKelurahan.EditValue, CObj(DBNull.Value)), meAlamat.Text, lueAddressType.EditValue, teKodepos.Text, userid, nowTime})
            If dtsql.datasetSave("alamat", idDataChild, field, value, False) = True Then
                dizMsgbox("Alamat telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        End If
        loadAlamat(idData)
        btnNewAlamat_Click(btnNewAlamat, Nothing)
    End Sub

    Private Sub gvAlamat_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvAlamat.FocusedRowChanged
        fromGridChild = True
        Dim dcol As DataRow = gvAlamat.GetDataRow(e.FocusedRowHandle)

        statDataChild = statusData.Edit
        idDataChild = dcol("idalamat")
        lueNegara.EditValue = dcol("idnegara")
        luePropinsi.EditValue = dcol("idpropinsi")
        lueKabupaten.EditValue = dcol("idkabupaten")
        lueKecamatan.EditValue = dcol("idkecamatan")
        lueKelurahan.EditValue = dcol("idkelurahan")
        lueAddressType.EditValue = dcol("addresstype")
        teKodepos.Text = dcol("kodepos")
        meAlamat.Text = dcol("alamat")
        If dcol("isprimary") = CLng(0) Then
            btnPrimaryAlamat.Text = "PRIMARY"
        ElseIf dcol("isprimary") = CLng(1) Then
            btnPrimaryAlamat.Text = "NOT PRIMARY"
        End If
        If dcol("isdeleted") = 0 Then
            btnDeleteAlamat.Text = "HAPUS"
        ElseIf dcol("isdeleted") = 1 Then
            btnDeleteAlamat.Text = "AKTIF"
        End If
        btnNewAlamat.Enabled = True
        btnSaveAlamat.Enabled = True
        btnDeleteAlamat.Enabled = True
        fromGridChild = False
    End Sub

End Class