Imports DevExpress.XtraGrid.Views.Base

Public Class frmAnalisaRM
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
        Dim mysqls As New SQLs(dbstring)

        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='ICDTYPE' order by idgeneral asc", "icdtype")
        lueType.Properties.DataSource = mysqls.dataTable("icdtype")
        lueType.Properties.DisplayMember = "content"
        lueType.Properties.ValueMember = "id"
        lueType.EditValue = Nothing
        If mysqls.getDataSet("icdtype") = 0 Then
            dizMsgbox("Jenis ICD tidak ditemukan" & vbCrLf & "Jenis ICD harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='LENGKAPBERKAS' order by idgeneral asc", "klpcm")
        lueKLPCM.Properties.DataSource = mysqls.dataTable("klpcm")
        lueKLPCM.Properties.DisplayMember = "content"
        lueKLPCM.Properties.ValueMember = "id"
        lueKLPCM.EditValue = Nothing
        If mysqls.getDataSet("klpcm") = 0 Then
            dizMsgbox("Lengkap Berkas tidak ditemukan" & vbCrLf & "Lengkap Berkas harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='JENISDIAGNOSA' order by idgeneral asc", "jenisdiagnosa")
        lueDiagnosa.Properties.DataSource = mysqls.dataTable("jenisdiagnosa")
        lueDiagnosa.Properties.DisplayMember = "content"
        lueDiagnosa.Properties.ValueMember = "id"
        lueDiagnosa.EditValue = Nothing
        If mysqls.getDataSet("jenisdiagnosa") = 0 Then
            dizMsgbox("Jenis Diagnosa tidak ditemukan" & vbCrLf & "lueDiagnosa harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='LENGKAPBERKAS' order by idgeneral asc", "subyektif")
        lueSubyektif.Properties.DataSource = mysqls.dataTable("subyektif")
        lueSubyektif.Properties.DisplayMember = "content"
        lueSubyektif.Properties.ValueMember = "id"
        lueSubyektif.EditValue = Nothing
        If mysqls.getDataSet("subyektif") = 0 Then
            dizMsgbox("Lengkap Berkas tidak ditemukan" & vbCrLf & "Lengkap Berkas harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='LENGKAPBERKAS' order by idgeneral asc", "obyektif")
        lueObyektif.Properties.DataSource = mysqls.dataTable("obyektif")
        lueObyektif.Properties.DisplayMember = "content"
        lueObyektif.Properties.ValueMember = "id"
        lueObyektif.EditValue = Nothing
        If mysqls.getDataSet("obyektif") = 0 Then
            dizMsgbox("Lengkap Berkas tidak ditemukan" & vbCrLf & "Lengkap Berkas harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='LENGKAPBERKAS' order by idgeneral asc", "asesmen")
        lueAsesmen.Properties.DataSource = mysqls.dataTable("asesmen")
        lueAsesmen.Properties.DisplayMember = "content"
        lueAsesmen.Properties.ValueMember = "id"
        lueAsesmen.EditValue = Nothing
        If mysqls.getDataSet("asesmen") = 0 Then
            dizMsgbox("Lengkap Berkas tidak ditemukan" & vbCrLf & "Lengkap Berkas harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='LENGKAPBERKAS' order by idgeneral asc", "planning")
        luePlanning.Properties.DataSource = mysqls.dataTable("planning")
        luePlanning.Properties.DisplayMember = "content"
        luePlanning.Properties.ValueMember = "id"
        luePlanning.EditValue = Nothing
        If mysqls.getDataSet("planning") = 0 Then
            dizMsgbox("Lengkap Berkas tidak ditemukan" & vbCrLf & "Lengkap Berkas harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        slueKode.Properties.DataSource = Nothing
        slueKode.Properties.DisplayMember = "content"
        slueKode.Properties.ValueMember = "id"
        slueKode.EditValue = Nothing
    End Sub

    Private Sub kosongkanIsian()
        idselect = "-1"
        idreg = -1
        iddept = -1
        idunit = -1
        idtty = -1
        idsn = -1
        teNoRegistrasi.Text = ""
        teTanggalRegistrasi.Text = ""
        lueKLPCM.EditValue = Nothing
        lueSubyektif.EditValue = Nothing
        lueObyektif.EditValue = Nothing
        lueAsesmen.EditValue = Nothing
        luePlanning.EditValue = Nothing
        lueType.EditValue = Nothing
        slueKode.EditValue = Nothing
        slueKode.EditValue = Nothing
        meDiagnosa.Text = ""
        meAsesmen.Text = ""
        meRemarks.Text = ""
        gcICD.DataSource = Nothing
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        kosongkanIsian()
        lueKLPCM.Enabled = False
        lueSubyektif.Enabled = False
        lueObyektif.Enabled = False
        lueAsesmen.Enabled = False
        luePlanning.Enabled = False
        lueDiagnosa.Enabled = False
        lueType.Enabled = False
        slueKode.Enabled = False
        btnBaruICD.Enabled = False
        btnSimpanICD.Enabled = False
        btnDeleteICD.Enabled = False
        btnSimpan.Enabled = False
        loadgridicd(-2)
    End Sub

    Private idselect As String = "-1"
    Private idreg As String = "-1"
    Private iddept As String = -1
    Private idunit As String = -1
    Private idtty As String = -1
    Private idsn As String = -1
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sqls As New SQLs(dbstring) 'r.registrasistatus<>0 and 
        sqls.DMLQuery("select r.idregistrasi,convert(varchar,r.registrasidate,105)+' '+convert(varchar,r.registrasidate,108) as 'Tgl Registrasi',r.registrasino as 'No Registrasi',pm.nama as 'Tenaga Medis',dbo.fformatnorm(rm.rekammedisno) as 'No RM',rm.nama as 'Nama Pasien',jk.generalcode as 'Jenis Kelamin',convert(varchar,rm.tanggallahir,105) as 'Tgl Lahir',dbo.fUmurRegister(rm.tanggallahir,r.registrasidate) as 'Umur',kw.wilayah as 'Kewarganegaraan' from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis left join sys_generalcode jk on rm.jeniskelamin=jk.idgeneral and jk.gctype='SEXTYPE' left join wilayah kw on rm.kewarganegaraan=kw.idwilayah left join paramedis pm on r.iddokterruangan=pm.idparamedis where r.isasesmenmedis=1 and r.registrasistatus=7 and rm.rekammedisno<>0 and (convert(varchar,r.registrasidate,105) = convert(varchar,DATEADD(day,-1,getdate()),105) or convert(varchar,r.registrasidate,105)=convert(varchar,getdate(),105)) and r.iddepartment in (select [value] from sys_appsetting where variable in ('idigddept','idirmdept','IDIRJDept')) order by r.registrasino desc,r.registrasidate desc", "search")
        Dim cari As New frmSearch(sqls.dataSet, "search", "idregistrasi")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            btnClose_Click(btnClose, Nothing)

            idselect = CStr(cari.GetIDSelectData)
            sqls.DMLQuery("select iddepartment,idunit,registrasino,convert(varchar,registrasidate,105)+' '+convert(varchar,registrasidate,108) as registrasidate from registrasi where idregistrasi='" & idselect & "'", "selreg")
            teTanggalRegistrasi.Text = sqls.getDataSet("selreg", 0, "registrasidate")
            teNoRegistrasi.Text = sqls.getDataSet("selreg", 0, "registrasino")

            idreg = idselect
            iddept = CStr(sqls.getDataSet("selreg", 0, "iddepartment"))
            idunit = CStr(sqls.getDataSet("selreg", 0, "idunit"))

            sqls.DMLQuery("select idtransactiontype from transactiontype where kodetransaksi='SOAPM' and iddepartment='" & iddept & "' and idunit='" & idunit & "'", "tty")
            idtty = CStr(sqls.getDataSet("tty", 0, "idtransactiontype"))
            sqls.DMLQuery("select idsoapnote,isnull(subyektif,'-') as subyektif,isnull(obyektif,'-') as obyektif,isnull(asesmen,'-') as asesmen,isnull(planning,'-') as planning from soapnote where soapnotetype=1 and idregistrasi='" & idreg & "' and transactiontype='" & idtty & "'", "sn")

            If sqls.getDataSet("sn") = 0 Then
                dizMsgbox("SOAP Note tidak ditemukan" & vbCrLf & "Belum melakukan Asesmen Medis", dizMsgboxStyle.Peringatan, Me)
                btnClose_Click(btnClose, Nothing)
            Else
                idsn = CStr(sqls.getDataSet("sn", 0, "idsoapnote"))
                Dim strNote As String = ""
                strNote = "Subyektif" & vbCrLf & sqls.getDataSet("sn", 0, "subyektif") & vbCrLf & vbCrLf
                strNote &= "Obyektif" & vbCrLf & sqls.getDataSet("sn", 0, "obyektif") & vbCrLf & vbCrLf
                strNote &= "Asesmen" & vbCrLf & sqls.getDataSet("sn", 0, "asesmen") & vbCrLf & vbCrLf
                strNote &= "Planning" & vbCrLf & sqls.getDataSet("sn", 0, "planning")
                meAsesmen.Text = strNote

                sqls.DMLQuery("select idanalisarm,subyektif,obyektif,asesmen,planning,klpcm from analisarm where idsoapnote='" & idsn & "'", "getarm")
                If sqls.getDataSet("getarm") = 0 Then
                    idselect = "-1"
                    lueSubyektif.EditValue = Nothing
                    lueObyektif.EditValue = Nothing
                    lueAsesmen.EditValue = Nothing
                    luePlanning.EditValue = Nothing
                    lueKLPCM.EditValue = Nothing
                Else
                    idselect = sqls.getDataSet("getarm", 0, "idanalisarm")
                    lueSubyektif.EditValue = sqls.getDataSet("getarm", 0, "subyektif")
                    lueObyektif.EditValue = sqls.getDataSet("getarm", 0, "obyektif")
                    lueAsesmen.EditValue = sqls.getDataSet("getarm", 0, "asesmen")
                    luePlanning.EditValue = sqls.getDataSet("getarm", 0, "planning")
                    lueKLPCM.EditValue = sqls.getDataSet("getarm", 0, "klpcm")
                End If

                lueKLPCM.Enabled = True
                lueSubyektif.Enabled = True
                lueObyektif.Enabled = True
                lueAsesmen.Enabled = True
                luePlanning.Enabled = True
                lueDiagnosa.Enabled = True
                lueType.Enabled = True
                slueKode.Enabled = True

                btnSimpan.Enabled = True
                loadgridicd(idreg)
                btnBaruICD_Click(btnBaruICD, Nothing)
            End If
        End If
    End Sub

    Private Sub frmAnalisaRM_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadLOV()
        btnClose_Click(btnClose, Nothing)
    End Sub

    Private Sub lueType_EditValueChanged(sender As Object, e As EventArgs) Handles lueType.EditValueChanged
        If lueType.EditValue Is Nothing Then
            slueKode.Properties.DataSource = Nothing
            slueKode.EditValue = Nothing
            meDiagnosa.Text = ""
            meRemarks.Text = ""
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idicd as id,kode,diagnosa from icd where idgeneral<>3 and icdtype='" & lueType.EditValue & "' order by kode asc", "kode")
        slueKode.Properties.DataSource = sqls.dataTable("kode")
        slueKode.Properties.ValueMember = "id"
        slueKode.Properties.DisplayMember = "kode"
        slueKode.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        slueKode.EditValue = Nothing
        meDiagnosa.Text = ""
        meRemarks.Text = ""
    End Sub

    Private Sub slueKode_EditValueChanged(sender As Object, e As EventArgs) Handles slueKode.EditValueChanged
        If slueKode.EditValue Is Nothing Then
            meDiagnosa.Text = ""
            meRemarks.Text = ""
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select kode,diagnosa,remarks from icd where idicd='" & slueKode.EditValue & "'", "selectkode")
        meDiagnosa.Text = sqls.getDataSet("selectkode", 0, "diagnosa")
        meRemarks.Text = sqls.getDataSet("selectkode", 0, "remarks")
    End Sub

    Private Sub btnBaruICD_Click(sender As Object, e As EventArgs) Handles btnBaruICD.Click
        lueDiagnosa.EditValue = Nothing
        lueType.EditValue = Nothing
        slueKode.EditValue = Nothing
        meDiagnosa.Text = ""
        meRemarks.Text = ""
        btnBaruICD.Enabled = True
        btnSimpanICD.Enabled = True
        btnDeleteICD.Enabled = False
        idselecticd = -1
    End Sub

    Private Sub btnSimpanICD_Click(sender As Object, e As EventArgs) Handles btnSimpanICD.Click
        Dim cek As Boolean = True
        If lueDiagnosa.EditValue Is Nothing Then
            cek = False
        End If
        If lueType.EditValue Is Nothing Then
            cek = False
        End If
        If slueKode.EditValue Is Nothing Then
            cek = False
        End If
        If cek = False Then
            dizMsgbox("Isian belum benar", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idicd from analisarmdt where isdeleted=0 and idicd='" & slueKode.EditValue & "' and idregistrasi='" & idreg & "'", "cekdata")
        If sqls.getDataSet("cekdata") > 0 Then
            dizMsgbox("ICD tersebut sudah ada", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If lueDiagnosa.EditValue = CLng(1) Then
            sqls.DMLQuery("select idicd from analisarmdt where isdeleted=0 and jenisdiagnosa=1 and idregistrasi='" & idreg & "'", "cek1")
            If sqls.getDataSet("cek1") > 0 Then
                dizMsgbox("Diagnosa Utama sudah ada", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If
        End If
        If lueDiagnosa.EditValue = CLng(2) Then
            sqls.DMLQuery("select idicd from analisarmdt where isdeleted=0 and jenisdiagnosa=2 and idregistrasi='" & idreg & "'", "cek2")
            If sqls.getDataSet("cek2") > 0 Then
                dizMsgbox("Diagnosa Kedua sudah ada", dizMsgboxStyle.Peringatan, Me)
                Exit Sub
            End If
        End If

        Dim idtmp As String = GenerateGUID()
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim dtsqls As New dtsetSQLS(dbstring)
        field.AddRange(New String() {"idanalisarmdt", "idregistrasi", "jenisdiagnosa", "idicd", "createdby"})
        value.AddRange(New Object() {idtmp, idreg, lueDiagnosa.EditValue, slueKode.EditValue, userid})
        dtsqls.datasetSave("analisarmdt", idtmp, field, value, False)
        loadgridicd(idreg)

        btnBaruICD_Click(btnBaruICD, Nothing)
    End Sub

    Private Sub loadgridicd(idreg As String)
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select d.idanalisarmdt,d.idicd,d.jenisdiagnosa,jd.generalcode as jnsdiagnosa,i.icdtype,i.kode,i.diagnosa,i.remarks,d.isdeleted,del.generalcode as statdata,it.generalcode as jenisicd from analisarmdt d left join icd i on d.idicd=i.idicd left join sys_generalcode del on d.isdeleted=del.idgeneral and del.gctype='DELETE' left join sys_generalcode it on i.icdtype=it.idgeneral and it.gctype='ICDTYPE' left join sys_generalcode jd on d.jenisdiagnosa=jd.idgeneral and jd.gctype='JENISDIAGNOSA' where d.analisarmtype=2 and d.idregistrasi='" & idreg & "' order by d.jenisdiagnosa asc,d.createddate desc", "data")
        gcICD.DataSource = sqls.dataTable("data")
        gvICD.BestFitColumns()
    End Sub

    Private Sub btnDeleteICD_Click(sender As Object, e As EventArgs) Handles btnDeleteICD.Click
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim dtsqls As New dtsetSQLS(dbstring)
        field.AddRange(New String() {"idanalisarmdt", "idicd", "isdeleted", "updatedby", "updateddate"})
        value.AddRange(New Object() {idselecticd, slueKode.EditValue, 1, userid, nowTime})
        dtsqls.datasetSave("analisarmdt", idselecticd, field, value, False)
        loadgridicd(idreg)
        btnBaruICD_Click(btnBaruICD, Nothing)
    End Sub

    Private idselecticd As String = -1
    Private Sub gvICD_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvICD.FocusedRowChanged
        Try
            Dim dcol As DataRow = gvICD.GetDataRow(e.FocusedRowHandle)

            Dim isdeleted As Long = dcol("isdeleted")
            If isdeleted = 1 Then
                btnBaruICD_Click(btnBaruICD, Nothing)
                Exit Sub
            End If

            idselecticd = dcol("idanalisarmdt")
            lueType.EditValue = dcol("icdtype")
            slueKode.EditValue = dcol("idicd")

            btnBaruICD.Enabled = True
            btnSimpanICD.Enabled = False
            btnDeleteICD.Enabled = True
        Catch ex As Exception
            btnBaruICD_Click(btnBaruICD, Nothing)
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim cek As Boolean = True
        If lueSubyektif.EditValue Is Nothing Then cek = False
        If lueObyektif.EditValue Is Nothing Then cek = False
        If lueAsesmen.EditValue Is Nothing Then cek = False
        If luePlanning.EditValue Is Nothing Then cek = False
        If cek = False Then
            dizMsgbox("Isian belum benar", dizMsgboxStyle.Info, Me)
            Exit Sub
        End If

        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim dtsqls As New dtsetSQLS(dbstring)
        If idselect = "-1" Then
            field.AddRange(New String() {"idanalisarm", "analisarmtype", "idsoapnote", "subyektif", "obyektif", "asesmen", "planning", "klpcm", "createdby"})
            value.AddRange(New Object() {idselect, 2, idsn, lueSubyektif.EditValue, lueObyektif.EditValue, lueAsesmen.EditValue, luePlanning.EditValue, lueKLPCM.EditValue, userid})
        Else
            field.AddRange(New String() {"idanalisarm", "analisarmtype", "subyektif", "obyektif", "asesmen", "planning", "klpcm", "updatedby", "updateddate"})
            value.AddRange(New Object() {idselect, 2, lueSubyektif.EditValue, lueObyektif.EditValue, lueAsesmen.EditValue, luePlanning.EditValue, lueKLPCM.EditValue, userid, nowTime})
        End If
        dtsqls.datasetSave("analisarm", idselect, field, value, False)

        If idselect = "-1" Then
            Dim sqls As New SQLs(dbstring)
            sqls.DMLQuery("select idanalisarm,createddate from analisarm where idsoapnote='" & idsn & "' order by createddate desc", "arm")
            If sqls.getDataSet("arm") > 0 Then
                idselect = sqls.getDataSet("arm", 0, "idanalisarm")
            End If
        End If
        dizMsgbox("Analisa Rekam Medis telah tersimpan", dizMsgboxStyle.Info, Me)
    End Sub


End Class