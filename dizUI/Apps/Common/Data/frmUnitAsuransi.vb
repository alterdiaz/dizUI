Imports DevExpress.XtraGrid.Views.Base
Public Class frmUnitAsuransi

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
        Threading.Thread.Sleep(100)
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

    Declare Function GetDC Lib "user32.dll" (ByVal hwnd As Int32) As Int32
    Declare Function ReleaseDC Lib "user32.dll" (ByVal hwnd As Int32, ByVal hdc As Int32) As Int32

    Private Sub frmUnitAsuransi_Load(sender As Object, e As EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        loadLOV()
        loadgrid()
        kosongkan()
    End Sub

    Private Sub loadgrid()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select ua.idunitasuransi,ua.idunit,u.unit,left(convert(varchar,ua.periode,120),7) as periode,ua.remarks,ua.isdeleted,del.generalcode as statdata,ua.asuransigigi,g.nama as gigi,ua.asuransimata,m.nama as mata,ua.asuransikesehatan,s.nama as kesehatan, ua.asuransipendidikan,d.nama as pendidikan,ua.asuransikerja,k.nama as kerja, ua.asuransipensiun,p.nama as pensiun,ua.asuransiharitua,ht.nama as haritua, ua.asuransikematian,t.nama as kematian,ua.asuransigigi,g.nama as gigi from unitasuransi ua left join unit u on ua.idunit=u.idunit left join businesspartner g on ua.asuransigigi=g.idbusinesspartner left join businesspartner m on ua.asuransimata=m.idbusinesspartner left join businesspartner s on ua.asuransikesehatan=s.idbusinesspartner left join businesspartner d on ua.asuransipendidikan=d.idbusinesspartner left join businesspartner k on ua.asuransikerja=k.idbusinesspartner left join businesspartner p on ua.asuransipensiun=p.idbusinesspartner left join businesspartner ht on ua.asuransiharitua=ht.idbusinesspartner left join businesspartner t on ua.asuransikematian=t.idbusinesspartner left join sys_generalcode del on ua.isdeleted=del.idgeneral and del.gctype='DELETE' order by ua.periode desc,u.unit asc", "data")
        gcData.DataSource = sqls.dataTable("data")
        gvData.BestFitColumns()
    End Sub

    Private Sub kosongkan()
        lueUnit.EditValue = Nothing
        lueDept.EditValue = Nothing
        lueJabatan.EditValue = Nothing

        lueGigi.EditValue = Nothing
        lueMata.EditValue = Nothing
        lueKesehatan.EditValue = Nothing
        luePendidikan.EditValue = Nothing

        lueKerja.EditValue = Nothing
        luePensiun.EditValue = Nothing
        lueHariTua.EditValue = Nothing
        lueKematian.EditValue = Nothing
        teNote.EditValue = Nothing
        dePeriode.EditValue = nowTime
    End Sub

    Private Sub loadLOV()
        Dim sqls As New SQLs(dbstring)
        sqls.DMLQuery("select idunit as id,unit as content from unit where isdeleted=0 order by unit asc", "unit")
        lueUnit.Properties.DataSource = sqls.dataTable("unit")
        lueUnit.Properties.ValueMember = "id"
        lueUnit.Properties.DisplayMember = "content"
        lueUnit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueUnit.EditValue = Nothing

        sqls.DMLQuery("select iddepartment as id,department as content from department where isdeleted=0 order by department", "dept")
        lueDept.Properties.DataSource = sqls.dataTable("dept")
        lueDept.Properties.ValueMember = "id"
        lueDept.Properties.DisplayMember = "content"
        lueDept.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueDept.EditValue = Nothing

        sqls.DMLQuery("select idposition as id,position as content from position where isdeleted=0 order by position", "post")
        lueJabatan.Properties.DataSource = sqls.dataTable("post")
        lueJabatan.Properties.ValueMember = "id"
        lueJabatan.Properties.DisplayMember = "content"
        lueJabatan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueJabatan.EditValue = Nothing

        sqls.DMLQuery("select idbusinesspartner as id,nama as content from businesspartner where businesspartnertype=3 and isdeleted=0 order by nama asc", "gigi")
        lueGigi.Properties.DataSource = sqls.dataTable("gigi")
        lueGigi.Properties.ValueMember = "id"
        lueGigi.Properties.DisplayMember = "content"
        lueGigi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueGigi.EditValue = Nothing

        sqls.DMLQuery("select idbusinesspartner as id,nama as content from businesspartner where businesspartnertype=3 and isdeleted=0 order by nama asc", "mata")
        lueMata.Properties.DataSource = sqls.dataTable("mata")
        lueMata.Properties.ValueMember = "id"
        lueMata.Properties.DisplayMember = "content"
        lueMata.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueMata.EditValue = Nothing

        sqls.DMLQuery("select idbusinesspartner as id,nama as content from businesspartner where businesspartnertype=3 and isdeleted=0 order by nama asc", "kesehatan")
        lueKesehatan.Properties.DataSource = sqls.dataTable("kesehatan")
        lueKesehatan.Properties.ValueMember = "id"
        lueKesehatan.Properties.DisplayMember = "content"
        lueKesehatan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueKesehatan.EditValue = Nothing

        sqls.DMLQuery("select idbusinesspartner as id,nama as content from businesspartner where businesspartnertype=3 and isdeleted=0 order by nama asc", "pendidikan")
        luePendidikan.Properties.DataSource = sqls.dataTable("pendidikan")
        luePendidikan.Properties.ValueMember = "id"
        luePendidikan.Properties.DisplayMember = "content"
        luePendidikan.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        luePendidikan.EditValue = Nothing

        sqls.DMLQuery("select idbusinesspartner as id,nama as content from businesspartner where businesspartnertype=3 and isdeleted=0 order by nama asc", "kerja")
        lueKerja.Properties.DataSource = sqls.dataTable("kerja")
        lueKerja.Properties.ValueMember = "id"
        lueKerja.Properties.DisplayMember = "content"
        lueKerja.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueKerja.EditValue = Nothing

        sqls.DMLQuery("select idbusinesspartner as id,nama as content from businesspartner where businesspartnertype=3 and isdeleted=0 order by nama asc", "pensiun")
        luePensiun.Properties.DataSource = sqls.dataTable("pensiun")
        luePensiun.Properties.ValueMember = "id"
        luePensiun.Properties.DisplayMember = "content"
        luePensiun.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        luePensiun.EditValue = Nothing

        sqls.DMLQuery("select idbusinesspartner as id,nama as content from businesspartner where businesspartnertype=3 and isdeleted=0 order by nama asc", "haritua")
        lueHariTua.Properties.DataSource = sqls.dataTable("haritua")
        lueHariTua.Properties.ValueMember = "id"
        lueHariTua.Properties.DisplayMember = "content"
        lueHariTua.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueHariTua.EditValue = Nothing

        sqls.DMLQuery("select idbusinesspartner as id,nama as content from businesspartner where businesspartnertype=3 and isdeleted=0 order by nama asc", "kematian")
        lueKematian.Properties.DataSource = sqls.dataTable("kematian")
        lueKematian.Properties.ValueMember = "id"
        lueKematian.Properties.DisplayMember = "content"
        lueKematian.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        lueKematian.EditValue = Nothing
    End Sub

    Private iddata As String = "-1"
    Private statdata As statusData = statusData.Baru
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        kosongkan()
        statdata = statusData.Baru
        iddata = "-1"
    End Sub

    Private Sub dePeriode_EditValueChanged(sender As Object, e As EventArgs) Handles dePeriode.EditValueChanged
        If dePeriode.EditValue Is Nothing Then Exit Sub
        RemoveHandler dePeriode.EditValueChanged, AddressOf dePeriode_EditValueChanged

        Dim tmpstr As String = dePeriode.Text
        Dim tmpdate As Date = New Date(tmpstr.Split("-")(0), tmpstr.Split("-")(1), 1, 0, 0, 0)
        dePeriode.EditValue = tmpdate

        AddHandler dePeriode.EditValueChanged, AddressOf dePeriode_EditValueChanged
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cekisian() = False Then
            dizMsgbox("Data belum diisi dengan benar", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        If statdata = statusData.Baru Then
            iddata = GenerateGUID()
        End If

        Dim sqls As New SQLs(dbstring)
        If statdata = statusData.Baru Then
            sqls.DMLQuery("select * from unitasuransi where right(convert(varchar,periode,105),7)='" & Format(dePeriode.EditValue, "MM-yyyy") & "' and idunit='" & lueUnit.EditValue & "' and iddepartment='" & If(lueDept.EditValue, "0") & "' and idjabatan='" & If(lueUnit.EditValue, "0") & "'", "cek")
        Else
            sqls.DMLQuery("select * from unitasuransi where idunitasuransi<>'" & iddata & "' and right(convert(varchar,periode,105),7)='" & Format(dePeriode.EditValue, "MM-yyyy") & "' and idunit='" & lueUnit.EditValue & "' and iddepartment='" & If(lueDept.EditValue, "0") & "' and idjabatan='" & If(lueUnit.EditValue, "0") & "'", "cek")
        End If
        If sqls.getDataSet("cek") > 0 Then
            dizMsgbox("Data sudah ada", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        Dim dtsqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        If statdata = statusData.Baru Then
            field.AddRange(New String() {"idunitasuransi", "idunit", "iddepartment", "idposition", "periode", "asuransigigi", "asuransikesehatan", "asuransimata", "asuransipendidikan", "asuransikerja", "asuransipensiun", "asuransiharitua", "asuransikematian", "remarks", "idcompany", "createdby", "createddate"})
            value.AddRange(New Object() {iddata, lueUnit.EditValue, If(lueDept.EditValue, "0"), If(lueJabatan.EditValue, "0"), CDate(dePeriode.EditValue), If(lueGigi.EditValue, "0"), If(lueGigi.EditValue, "0"), If(lueGigi.EditValue, "0"), If(lueGigi.EditValue, "0"), If(lueGigi.EditValue, "0"), If(lueGigi.EditValue, "0"), If(lueGigi.EditValue, "0"), If(lueGigi.EditValue, "0"), teNote.Text, idcomp, userid, nowTime})
        ElseIf statdata = statusData.edit Then
            field.AddRange(New String() {"idunitasuransi", "asuransigigi", "asuransikesehatan", "asuransimata", "asuransipendidikan", "asuransikerja", "asuransipensiun", "asuransiharitua", "asuransikematian", "remarks", "updatedby", "updateddate"})
            value.AddRange(New Object() {iddata, If(lueGigi.EditValue, "0"), If(lueGigi.EditValue, "0"), If(lueGigi.EditValue, "0"), If(lueGigi.EditValue, "0"), If(lueGigi.EditValue, "0"), If(lueGigi.EditValue, "0"), If(lueGigi.EditValue, "0"), If(lueGigi.EditValue, "0"), teNote.Text, userid, nowTime})
        End If

        If dtsqls.datasetSave("unitasuransi", iddata, field, value, False) = True Then
            dizMsgbox("Data telah tersimpan", dizMsgboxStyle.Info, Me)
            btnNew_Click(btnNew, Nothing)
        End If
    End Sub

    Private Function cekisian() As Boolean
        Dim retval As Boolean = True

        If dePeriode.EditValue Is Nothing Then retval = False
        If lueUnit.EditValue Is Nothing Then retval = False

        'If lueGigi.EditValue Is Nothing Then retval = False
        'If lueKesehatan.EditValue Is Nothing Then retval = False
        'If lueMata.EditValue Is Nothing Then retval = False
        'If luePendidikan.EditValue Is Nothing Then retval = False

        'If lueKerja.EditValue Is Nothing Then retval = False
        'If luePensiun.EditValue Is Nothing Then retval = False
        'If lueHariTua.EditValue Is Nothing Then retval = False
        'If lueKematian.EditValue Is Nothing Then retval = False

        If lueGigi.EditValue Is Nothing And lueKesehatan.EditValue Is Nothing And lueMata.EditValue Is Nothing And luePendidikan.EditValue Is Nothing And lueKerja.EditValue Is Nothing And luePensiun.EditValue Is Nothing And lueHariTua.EditValue Is Nothing And lueKematian.EditValue Is Nothing Then retval = False

        If teNote.EditValue Is Nothing Then teNote.EditValue = "-"
        If teNote.EditValue = "" Then teNote.EditValue = "-"

        Return retval
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim retval As Boolean = False
        Dim sqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If btnDelete.Text = "HAPUS" Then
            field.AddRange(New String() {"idunitasuransi", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {iddata, 1, userid, nowTime})
            retval = sqls.datasetSave("unitasuransi", iddata, field, value, False)

            If retval Then
                btnDelete.Text = "AKTIF"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        Else
            field.AddRange(New String() {"idunitasuransi", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {iddata, 0, userid, nowTime})
            retval = sqls.datasetSave("unitasuransi", iddata, field, value, False)
            If retval Then
                btnDelete.Text = "HAPUS"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        End If
        isiLog(userid, dbstring, field, value, "unitasuransi")
        btnNew_Click(Me, Nothing)
    End Sub

    Private Sub gvData_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        If e.FocusedRowHandle < 0 Then Exit Sub

        Dim dr As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
        iddata = dr("idunitasuransi")
        lueUnit.EditValue = If(dr("idunit") = "0", Nothing)
        lueDept.EditValue = If(dr("iddepartment") = "0", Nothing)
        lueJabatan.EditValue = If(dr("idposition") = "0", Nothing)

        lueGigi.EditValue = If(dr("asuransigigi") = "0", Nothing)
        lueMata.EditValue = If(dr("asuransimata") = "0", Nothing)
        luePendidikan.EditValue = If(dr("asuransipendidikan") = "0", Nothing)
        lueKesehatan.EditValue = If(dr("asuransikesehatan") = "0", Nothing)

        lueKerja.EditValue = If(dr("asuransikerja") = "0", Nothing)
        luePensiun.EditValue = If(dr("asuransipensiun") = "0", Nothing)
        lueHariTua.EditValue = If(dr("asuransiharitua") = "0", Nothing)
        lueKematian.EditValue = If(dr("asuransikematian") = "0", Nothing)

        Dim tmpstr As String = dr("periode")
        Dim tmpdate As Date = New Date(tmpstr.Split("-")(0), tmpstr.Split("-")(1), 1, 0, 0, 0)
        dePeriode.EditValue = tmpdate
        lueUnit.EditValue = dr("idunit")
        teNote.Text = dr("remarks")

        If dr("isdeleted") = "1" Then
            btnDelete.Text = "AKTIF"
        Else
            btnDelete.Text = "HAPUS"
        End If
        statdata = statusData.Edit
    End Sub

    Private Sub btnDeptClear_Click(sender As Object, e As EventArgs) Handles btnDeptClear.Click
        lueDept.EditValue = Nothing
    End Sub

    Private Sub btnJabtClear_Click(sender As Object, e As EventArgs) Handles btnJabtClear.Click
        lueJabatan.EditValue = Nothing
    End Sub

End Class