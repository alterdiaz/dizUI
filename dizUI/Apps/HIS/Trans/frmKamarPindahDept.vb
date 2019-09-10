Public Class frmKamarPindahDept
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1
    Private idreg As String = ""
    Private idregtujuan As String = ""
    Private iddeptasal As String = ""
    Private iddepttujuan As String = ""
    Private idrm As String = ""

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

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

    Private Sub frmKamarPindah_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadLOV()

        Dim sqls As New SQLs(dbstring)
        If idreg = "" Then
            teNama.EditValue = Nothing
            teNoRegistrasi.EditValue = Nothing
            teNoRM.EditValue = Nothing
            lueRuangAsal.EditValue = Nothing
            lueRuangTujuan.EditValue = Nothing
            teKelasAsal.EditValue = Nothing
            lueKelasTujuan.EditValue = Nothing
            teNoRegistrasiTujuan.EditValue = Nothing
            iddeptasal = ""
            iddepttujuan = ""
            idregtujuan = ""
            idrm = ""
            iddeptasal = ""
            iddepttujuan = ""
        Else
            sqls.DMLQuery("select r.registrasino,r.idrekammedis,convert(bigint,rm.rekammedisno) as rekammedisno,rm.nama,r.idlokasi,k.kelas,r.iddepartment from registrasi r left join kelas k on r.idkelas=k.idkelas left join rekammedis rm on r.idrekammedis=rm.idrekammedis where r.idregistrasi='" & idreg & "'", "data")
            iddeptasal = sqls.getDataSet("data", 0, "iddepartment")
            idrm = sqls.getDataSet("data", 0, "idrekammedis")
            teNama.Text = sqls.getDataSet("data", 0, "nama")
            teNoRegistrasi.Text = SQLs.getDataSet("data", 0, "registrasino")
            teNoRM.Text = Format(CLng(SQLs.getDataSet("data", 0, "rekammedisno")), "0#######")
            lueRuangTujuan.EditValue = Nothing
            lueKelasTujuan.EditValue = Nothing
            teNoRegistrasiTujuan.EditValue = Nothing

            sqls.DMLQuery("select r.registrasino,r.idrekammedis,convert(bigint,rm.rekammedisno) as rekammedisno,rm.nama,r.idlokasi,r.idkelas,k.kelas,r.iddepartment from registrasi r left join kelas k on r.idkelas=k.idkelas left join rekammedis rm on r.idrekammedis=rm.idrekammedis where r.idregistrasi='" & idregtujuan & "'", "datatuj")
            iddepttujuan = sqls.getDataSet("datatuj", 0, "iddepartment")
            loadLOV()
            lueRuangAsal.EditValue = sqls.getDataSet("data", 0, "idlokasi")
            teKelasAsal.EditValue = sqls.getDataSet("data", 0, "kelas")
            teNoRegistrasiTujuan.EditValue = sqls.getDataSet("datatuj", 0, "registrasino")
            lueRuangTujuan.EditValue = sqls.getDataSet("datatuj", 0, "idlokasi")
            lueKelasTujuan.EditValue = sqls.getDataSet("datatuj", 0, "idkelas")
        End If
    End Sub

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select distinct l.idlokasi as id,k.kelas,l.nama as content from lokasi l left join kelaskamar kk on l.idlokasi=kk.idlokasi left join kelas k on kk.idkelas=k.idkelas and k.isdeleted=0 where l.isdeleted=0 and l.lokasitype in (3,4,22) and l.iddepartment='" & iddeptasal & "' order by k.kelas asc,l.nama asc", "ruang")
        lueRuangAsal.Properties.DataSource = sqls.dataTable("ruang")
        lueRuangAsal.Properties.DisplayMember = "content"
        lueRuangAsal.Properties.ValueMember = "id"
        lueRuangAsal.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueRuangAsal.Properties.BestFit()
        lueRuangAsal.EditValue = Nothing
        teKelasAsal.EditValue = Nothing

        sqls.DMLQuery("select lk.id,lk.kelas,lk.content from (select distinct l.idlokasi as id,k.kelas,l.nama as content,isnull(km.idregistrasi,'0') as idregistrasi,isnull(km.statusbed,1) as statusbed from lokasi l left join kelaskamar kk on l.idlokasi=kk.idlokasi left join kelas k on kk.idkelas=k.idkelas and k.isdeleted=0 left join kamar km on km.idlokasi=l.idlokasi where l.isdeleted=0 and l.lokasitype in (3,4,22) and l.iddepartment='" & iddepttujuan & "' ) lk where lk.id in ( select kkl.idlokasi from ( select l.idlokasi,isnull(km.idregistrasi,'0') as idregistrasi,isnull(km.statusbed,1) as statusbed from lokasi l left join kamar km on km.idlokasi=l.idlokasi where l.isdeleted=0 and l.lokasitype in (3,4,22) and l.iddepartment='" & iddepttujuan & "') kkl where kkl.idregistrasi='" & idregtujuan & "' or (kkl.idregistrasi='0' and kkl.statusbed=1)) order by lk.kelas asc,lk.content asc", "ruangtujuan")
        lueRuangTujuan.Properties.DataSource = sqls.dataTable("ruangtujuan")
        lueRuangTujuan.Properties.DisplayMember = "content"
        lueRuangTujuan.Properties.ValueMember = "id"
        lueRuangTujuan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueRuangTujuan.Properties.BestFit()
        lueRuangTujuan.EditValue = Nothing
        lueKelasTujuan.EditValue = Nothing

        sqls.DMLQuery("select idkelas as id,kelas as content,priority from kelas where isdeleted=0 order by priority asc", "kelas")
        lueKelasTujuan.Properties.DataSource = sqls.dataTable("kelas")
        lueKelasTujuan.Properties.DisplayMember = "content"
        lueKelasTujuan.Properties.ValueMember = "id"
        If sqls.getDataSet("kelas") = 0 Then
            dizMsgbox("Kelas tidak ditemukan" & vbCrLf & "Kelas harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If
    End Sub

    'Private Sub lueRuangAsal_EditValueChanged(sender As Object, e As EventArgs) Handles lueRuangAsal.EditValueChanged
    '    Dim sqls As New SQLs(dbstring)
    '    sqls.DMLQuery("select l.iddepartment,l.idunit,u.kode as kodeunit,d.kode as kodedept,k.kelas from lokasi l left join kelaskamar kk on l.idlokasi=kk.idlokasi and l.isdeleted=0 left join kelas k on kk.idkelas=k.idkelas and k.isdeleted=0 left join unit u on l.idunit=u.idunit left join department d on l.iddepartment=d.iddepartment where l.idlokasi='" & lueRuangAsal.EditValue & "'", "getid")
    '    If sqls.getDataSet("getid") > 0 Then
    '        teKelasAsal.Text = sqls.getDataSet("getid", 0, "kelas")
    '    End If
    'End Sub

    Private Sub lueRuangTujuan_EditValueChanged(sender As Object, e As EventArgs) Handles lueRuangTujuan.EditValueChanged
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select l.iddepartment,l.idunit,u.kode as kodeunit,d.kode as kodedept,k.kelas,kk.idkelas from lokasi l left join kelaskamar kk on l.idlokasi=kk.idlokasi and l.isdeleted=0 left join kelas k on kk.idkelas=k.idkelas and k.isdeleted=0 left join unit u on l.idunit=u.idunit left join department d on l.iddepartment=d.iddepartment where l.idlokasi='" & lueRuangTujuan.EditValue & "'", "getid")
        If sqls.getDataSet("getid") > 0 Then
            lueKelasTujuan.EditValue = sqls.getDataSet("getid", 0, "idkelas")
        End If
    End Sub

    Private vardept As String = "IDICUDept,IDHCUDept,IDICCUDept,IDNICUDept,IDPICUDept,IDVKDept,idibsdept,IDHDDept,IDCATHDept"
    Public Sub New(Optional dept As String = "IDICUDept,IDHCUDept,IDICCUDept,IDNICUDept,IDPICUDept,IDVKDept,idibsdept,IDHDDept,IDCATHDept")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        vardept = dept
        idreg = ""
        idregtujuan = ""
        idrm = ""
        iddeptasal = ""
        iddepttujuan = ""
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@vardept"})
        value.AddRange(New Object() {vardept})
        If vardept.Split(",").Count > 1 Then
            sqls.CallSP("spMonKamarClosingMulti", "data", field, value)
        Else
            sqls.CallSP("spMonKamarClosing", "data", field, value)
        End If

        Dim cari As New frmSearch(sqls.dataSet, "data", "id")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            idreg = cari.GetIDSelectData
            frmKamarPindah_Load(Me, Nothing)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If lueRuangTujuan.EditValue Is Nothing Then
            dizMsgbox("Kamar Tujuan belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If idreg = "" Then
            dizMsgbox("Registrasi belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim retval As Boolean = True
        Dim idkamarasal As String = "-1"
        Dim idkamartujuan As String = "-1"
        Dim idregkamar As String = "-1"
        Dim sqls As New SQLs(dbstring)

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        Dim dtsqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        sqls.DMLQuery("Select idkamar from kamar where idregistrasi='" & idregtujuan & "'", "getidkamar")
        If sqls.getDataSet("getidkamar") > 0 Then
            idkamarasal = sqls.getDataSet("getidkamar", 0, "idkamar")
        End If
        sqls.DMLQuery("select idregistrasikamar,idlokasi from registrasikamar where checkout is null and idregistrasi='" & idregtujuan & "'", "getidregkamar")
        If sqls.getDataSet("getidregkamar") > 0 Then
            idregkamar = sqls.getDataSet("getidregkamar", 0, "idregistrasikamar")
            If lueRuangTujuan.EditValue <> sqls.getDataSet("getidregkamar", 0, "idlokasi") Then
                sqls.DMLQuery("update registrasikamar set checkout=getdate() where checkout is null and idregistrasikamar='" & idregkamar & "'", False)
                sqls.DMLQuery("update kamar set checkin=null,checkout=getdate(),idregistrasi='0',statusbed=2 where checkout is null and idregistrasi='" & idregtujuan & "'", False)

                dtsqls = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.AddRange(New String() {"idregistrasi", "idlokasi", "updatedby", "updateddate", "idcompany"})
                value.AddRange(New Object() {idregtujuan, lueRuangTujuan.EditValue, userid, nowTime, idcomp})
                retval = dtsqls.datasetSave("registrasi", idregtujuan, field, value, False)
                If retval = False Then
                    dizMsgbox("Update Registrasi Gagal", dizMsgboxStyle.Peringatan, Me)
                    Exit Sub
                End If

                sqls.DMLQuery("select idkamar from kamar where idlokasi='" & lueRuangTujuan.EditValue & "'", "getidtujuan")
                If sqls.getDataSet("getidtujuan") > 0 Then
                    idkamartujuan = sqls.getDataSet("getidtujuan", 0, "idkamar")
                Else
                    idkamartujuan = GenerateGUID()
                End If

                dtsqls = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.AddRange(New String() {"idkamar", "idregistrasi", "idlokasi", "checkin", "statusbed", "updatedby", "updateddate", "idcompany"})
                value.AddRange(New Object() {idkamartujuan, idregtujuan, lueRuangTujuan.EditValue, nowTime, 5, userid, nowTime, idcomp})
                retval = dtsqls.datasetSave("kamar", idkamartujuan, field, value, False)
                If retval = False Then
                    dizMsgbox("Tambah Kamar Baru Gagal", dizMsgboxStyle.Peringatan, Me)
                    Exit Sub
                End If

                Dim idtmp As String = GenerateGUID()
                dtsqls = New dtsetSQLS(dbstring)
                field = New List(Of String)
                value = New List(Of Object)
                field.AddRange(New String() {"idregistrasikamar", "idregistrasi", "idlokasi", "checkin", "createdby", "createddate"})
                value.AddRange(New Object() {idtmp, idregtujuan, lueRuangTujuan.EditValue, nowTime, userid, nowTime})
                retval = dtsqls.datasetSave("registrasikamar", idtmp, field, value, False)
                If retval = False Then
                    dizMsgbox("Tambah Registrasi Kamar Gagal", dizMsgboxStyle.Peringatan, Me)
                    Exit Sub
                End If
            End If
        End If

        If retval = True Then
            dizMsgbox("Pindah Kamar berhasil dilakukan", dizMsgboxStyle.Info, Me)
            idreg = ""
            frmKamarPindah_Load(Me, Nothing)
        End If
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        If idrm = "" Then
            dizMsgbox("Registrasi belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        Dim vardept2 As String = "idirnadept,IDICUDept,IDICCUDept,IDHCUDept,IDNICUDept,IDPICUDept"
        field.AddRange(New String() {"@vardept", "@varidrm"})
        value.AddRange(New Object() {vardept2, idrm})
        If vardept2.Split(",").Count > 1 Then
            sqls.CallSP("spMonKamarAktifRMMulti", "data", field, value)
        Else
            sqls.CallSP("spMonKamarAktifRM", "data", field, value)
        End If

        Dim cari As New frmSearch(sqls.dataSet, "data", "id")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            idregtujuan = cari.GetIDSelectData
            frmKamarPindah_Load(Me, Nothing)
        End If
    End Sub

End Class