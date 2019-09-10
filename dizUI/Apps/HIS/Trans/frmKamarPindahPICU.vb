Public Class frmKamarPindahPICU
    Const HTCAPTION = &H2
    Const WM_NCLBUTTONDOWN = &HA1
    Private idreg As String = "-1"
    Private withparam As Long = 0
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub New(id As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        idreg = id
        withparam = 1
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
        If idreg = "-1" Then
            teNama.EditValue = Nothing
            teNoRegistrasi.EditValue = Nothing
            teNoRM.EditValue = Nothing
            lueRuangAsal.EditValue = Nothing
            lueRuangTujuan.EditValue = Nothing
            teKelasAsal.EditValue = Nothing
            lueKelasTujuan.EditValue = Nothing
        Else
            sqls.DMLQuery("select r.registrasino,convert(bigint,rm.rekammedisno) as rekammedisno,rm.nama,r.idlokasi from registrasi r left join rekammedis rm on r.idrekammedis=rm.idrekammedis where r.idregistrasi='" & idreg & "'", "data")
            teNama.Text = sqls.getDataSet("data", 0, "nama")
            teNoRegistrasi.Text = sqls.getDataSet("data", 0, "registrasino")
            teNoRM.Text = Format(CLng(sqls.getDataSet("data", 0, "rekammedisno")), "0#######")
            teKelasAsal.EditValue = Nothing
            lueKelasTujuan.EditValue = Nothing
            lueRuangAsal.EditValue = sqls.getDataSet("data", 0, "idlokasi")
            lueRuangTujuan.EditValue = Nothing
        End If
        If withparam = 1 Then
            btnNew.Visible = False
        Else
            btnNew.Visible = True
        End If
    End Sub

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select distinct l.idlokasi as id,k.kelas,l.nama as content from lokasi l left join kelaskamar kk on l.idlokasi=kk.idlokasi left join kelas k on kk.idkelas=k.idkelas and k.isdeleted=0 where l.isdeleted=0 and l.lokasitype=22 and l.iddepartment in (select value from sys_appsetting where variable in ('IDNICUDept','IDPICUDept')) order by k.kelas asc,l.nama asc", "ruang")
        lueRuangAsal.Properties.DataSource = sqls.dataTable("ruang")
        lueRuangAsal.Properties.DisplayMember = "content"
        lueRuangAsal.Properties.ValueMember = "id"
        lueRuangAsal.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueRuangAsal.Properties.BestFit()
        lueRuangAsal.EditValue = Nothing
        teKelasAsal.EditValue = Nothing

        sqls.DMLQuery("select distinct l.idlokasi as id,k.kelas,l.nama as content from lokasi l left join kelaskamar kk on l.idlokasi=kk.idlokasi left join kelas k on kk.idkelas=k.idkelas and k.isdeleted=0 where l.isdeleted=0 and l.idlokasi not in (select idlokasi from kamar where checkout is null) and l.lokasitype=22 and l.iddepartment in (select value from sys_appsetting where variable in ('IDNICUDept','IDPICUDept')) order by k.kelas asc,l.nama asc", "ruangtujuan")
        lueRuangTujuan.Properties.DataSource = sqls.dataTable("ruangtujuan")
        lueRuangTujuan.Properties.DisplayMember = "content"
        lueRuangTujuan.Properties.ValueMember = "id"
        lueRuangTujuan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueRuangTujuan.Properties.BestFit()
        lueRuangTujuan.EditValue = Nothing

        sqls.DMLQuery("select idkelas as id,kelas as content,priority from kelas where isdeleted=0 order by priority asc", "kelas")
        lueKelasTujuan.Properties.DataSource = sqls.dataTable("kelas")
        lueKelasTujuan.Properties.DisplayMember = "content"
        lueKelasTujuan.Properties.ValueMember = "id"
        If sqls.getDataSet("kelas") = 0 Then
            dizMsgbox("Kelas tidak ditemukan" & vbCrLf & "Kelas harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If
        lueKelasTujuan.EditValue = Nothing
    End Sub

    Private Sub lueRuangAsal_EditValueChanged(sender As Object, e As EventArgs) Handles lueRuangAsal.EditValueChanged
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select l.iddepartment,l.idunit,u.kode as kodeunit,d.kode as kodedept,k.kelas from lokasi l left join kelaskamar kk on l.idlokasi=kk.idlokasi and l.isdeleted=0 left join kelas k on kk.idkelas=k.idkelas and k.isdeleted=0 left join unit u on l.idunit=u.idunit left join department d on l.iddepartment=d.iddepartment where l.idlokasi='" & lueRuangAsal.EditValue & "'", "getid")
        If sqls.getDataSet("getid") > 0 Then
            teKelasAsal.Text = sqls.getDataSet("getid", 0, "kelas")
        End If
    End Sub

    Private Sub lueRuangTujuan_EditValueChanged(sender As Object, e As EventArgs) Handles lueRuangTujuan.EditValueChanged
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select l.iddepartment,l.idunit,u.kode as kodeunit,d.kode as kodedept,k.idkelas,k.kelas from lokasi l left join kelaskamar kk on l.idlokasi=kk.idlokasi and l.isdeleted=0 left join kelas k on kk.idkelas=k.idkelas and k.isdeleted=0 left join unit u on l.idunit=u.idunit left join department d on l.iddepartment=d.iddepartment where l.idlokasi='" & lueRuangTujuan.EditValue & "'", "getid")
        If sqls.getDataSet("getid") > 0 Then
            lueKelasTujuan.EditValue = sqls.getDataSet("getid", 0, "idkelas")
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim sqls As New SQLs(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"@vardept"})
        value.AddRange(New Object() {"IDNICUDept,IDPICUDept"})
        sqls.CallSP("spMonKamarAktifMulti", "data", field, value)

        Dim cari As New frmSearch(sqls.dataSet, "data", "id")
        tambahChild(cari)

        If cari.ShowDialog = Windows.Forms.DialogResult.OK Then
            idreg = cari.GetIDSelectData
            frmKamarPindah_Load(Me, Nothing)
            If withparam = 1 Then
                btnNew.Visible = False
            Else
                btnNew.Visible = True
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If lueRuangTujuan.EditValue Is Nothing Then
            dizMsgbox("Kamar Tujuan belum dipilih", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If
        If idreg = "-1" Then
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

        sqls.DMLQuery("Select idkamar from kamar where idregistrasi='" & idreg & "'", "getidkamar")
        If sqls.getDataSet("getidkamar") > 0 Then
            idkamarasal = sqls.getDataSet("getidkamar", 0, "idkamar")
        End If
        sqls.DMLQuery("select idregistrasikamar from registrasikamar where idlokasi='" & lueRuangAsal.EditValue & "' and idregistrasi='" & idreg & "'", "getidregkamar")
        idregkamar = sqls.getDataSet("getidregkamar", 0, "idregistrasikamar")

        Dim dtsqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        field.AddRange(New String() {"idregistrasi", "idlokasi", "updatedby", "updateddate", "idcompany"})
        value.AddRange(New Object() {idreg, lueRuangTujuan.EditValue, userid, nowTime, idcomp})
        retval = dtsqls.datasetSave("registrasi", idreg, field, value, False)
        If retval = False Then
            dizMsgbox("Update Registrasi Gagal", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        dtsqls = New dtsetSQLS(dbstring)
        field = New List(Of String)
        value = New List(Of Object)
        field.AddRange(New String() {"idkamar", "idregistrasi", "checkin", "checkout", "statusbed", "updatedby", "updateddate", "idcompany"})
        value.AddRange(New Object() {idkamarasal, 0, DBNull.Value, nowTime, 2, userid, nowTime, idcomp})
        retval = dtsqls.datasetSave("kamar", idkamarasal, field, value, False)
        If retval = False Then
            dizMsgbox("Update Kamar Lama Gagal", dizMsgboxStyle.Peringatan, Me)
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
        value.AddRange(New Object() {idkamartujuan, idreg, lueRuangTujuan.EditValue, nowTime, 5, userid, nowTime, idcomp})
        retval = dtsqls.datasetSave("kamar", idkamartujuan, field, value, False)
        If retval = False Then
            dizMsgbox("Tambah Kamar Baru Gagal", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        dtsqls = New dtsetSQLS(dbstring)
        field = New List(Of String)
        value = New List(Of Object)
        field.AddRange(New String() {"idregistrasikamar", "idregistrasi", "checkout", "updatedby", "updateddate"})
        value.AddRange(New Object() {idregkamar, idreg, nowTime, userid, nowTime})
        retval = dtsqls.datasetSave("registrasikamar", idregkamar, field, value, False)
        If retval = False Then
            dizMsgbox("Update Registrasi Kamar Gagal", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim idtmp As String = GenerateGUID()
        dtsqls = New dtsetSQLS(dbstring)
        field = New List(Of String)
        value = New List(Of Object)
        field.AddRange(New String() {"idregistrasikamar", "idregistrasi", "idlokasi", "checkin", "createdby", "createddate"})
        value.AddRange(New Object() {idtmp, idreg, lueRuangTujuan.EditValue, nowTime, userid, nowTime})
        retval = dtsqls.datasetSave("registrasikamar", idtmp, field, value, False)
        If retval = False Then
            dizMsgbox("Tambah Registrasi Kamar Gagal", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        If retval = True Then
            dizMsgbox("Pindah Kamar berhasil dilakukan", dizMsgboxStyle.Info, Me)
            idreg = -1
            frmKamarPindah_Load(Me, Nothing)
            If withparam = 1 Then
                btnNew.Visible = False
            Else
                btnNew.Visible = True
            End If
        End If
    End Sub

End Class