Public Class frmLembur
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
        mysqls.DMLQuery("select idunit as id,unit as content from unit where isdeleted=0 order by unit asc", "unit")
        lueUnit.Properties.DataSource = mysqls.dataTable("unit")
        lueUnit.Properties.DisplayMember = "content"
        lueUnit.Properties.ValueMember = "id"

        mysqls.DMLQuery("select iddepartment as id,department as content from department where isdeleted=0 order by department asc", "dept")
        lueDepartment.Properties.DataSource = mysqls.dataTable("dept")
        lueDepartment.Properties.DisplayMember = "content"
        lueDepartment.Properties.ValueMember = "id"

        mysqls.DMLQuery("select idposition as id,position as content,priority from position where isdeleted=0 order by priority asc", "jabt")
        luePosition.Properties.DataSource = mysqls.dataTable("jabt")
        luePosition.Properties.DisplayMember = "content"
        luePosition.Properties.ValueMember = "id"

        mysqls.DMLQuery("select idkomponengaji as id,komponengaji as content from komponengaji where isdeleted=0 order by komponengaji asc", "kompgaji")
        lueKomponenGaji.Properties.DataSource = mysqls.dataTable("kompgaji")
        lueKomponenGaji.Properties.DisplayMember = "content"
        lueKomponenGaji.Properties.ValueMember = "id"

        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='JENISNOMINALLEMBUR' order by generalcode asc", "jen")
        lueJenisNominal.Properties.DataSource = mysqls.dataTable("jen")
        lueJenisNominal.Properties.DisplayMember = "content"
        lueJenisNominal.Properties.ValueMember = "id"

        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='JENISHARILEMBUR' order by generalcode asc", "jhl")
        lueJenisHari.Properties.DataSource = mysqls.dataTable("jhl")
        lueJenisHari.Properties.DisplayMember = "content"
        lueJenisHari.Properties.ValueMember = "id"
    End Sub

    Private Sub loadGrid()
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select l.idlembur,l.idunit,isnull(u.unit,'-') as unit,l.iddepartment,isnull(d.department,'-') as department,l.idposition,isnull(p.position,'-') as position,l.idkomponengaji,kg.komponengaji,left(convert(varchar,l.periode,112),6) as periode,l.jamke,l.jenisnominallembur,jnl.generalcode as jenisnominal,l.jenisharilembur,jhl.generalcode as jenishari,l.nominal,l.isdeleted,del.generalcode as statdata from lembur l left join unit u on l.idunit=u.idunit left join department d on l.iddepartment=d.iddepartment left join position p on l.idposition=p.idposition left join komponengaji kg on l.idkomponengaji=kg.idkomponengaji left join sys_generalcode jhl on l.jenisharilembur=jhl.idgeneral and jhl.gctype='jenisharilembur' left join sys_generalcode jnl on l.jenisnominallembur=jnl.idgeneral and jnl.gctype='jenisnominallembur' left join sys_generalcode del on l.isdeleted=del.idgeneral and del.gctype='delete' order by left(convert(varchar,l.periode,112),6),l.jamke,u.unit,d.department,kg.komponengaji", "data")
        gcData.DataSource = mysqls.dataTable("data")
        gvData.BestFitColumns()

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        loadGrid()

        kosongkanIsian(tlpField)
        lueJenisHari.EditValue = CLng(0)
        btnNew.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnDelete.Text = "HAPUS"
        statData = statusData.Baru
    End Sub

    Private Function cekIsian() As Boolean
        Dim retval As Boolean = True
        If lueUnit.EditValue Is Nothing Then retval = False
        If seJam.EditValue = 0 Then retval = False
        If deTanggal.EditValue Is Nothing Then retval = False
        If lueKomponenGaji.EditValue Is Nothing Then retval = False
        If lueJenisNominal.EditValue Is Nothing Then retval = False
        If seNominal.EditValue = 0 Then retval = False

        Return retval
    End Function
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If checkEntry(tlpField) = False Then
            dizMsgbox("Isian belum benar, silahkan cek isian anda", dizMsgboxStyle.Peringatan, Me)
            Exit Sub
        End If

        Dim dtSQL As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        If statData = statusData.Baru Then
            idData = GenerateGUID()
        End If
        Dim sqls As New SQLs(dbstring)
        If lueDepartment.EditValue Is Nothing And luePosition.EditValue Is Nothing Then
            sqls.DMLQuery("select idlembur from lembur where jenisharilembur=" & lueJenisHari.EditValue & " and jamke=" & seJam.EditValue & " and left(replace(convert(varchar,periode,126),'-',''),6)='" & Format(CDate(deTanggal.EditValue), "yyyyMM") & "' and idunit='" & lueUnit.EditValue & "' and iddepartment='0' and idposition='0'", "cekdata")
        ElseIf lueDepartment.EditValue IsNot Nothing And luePosition.EditValue Is Nothing Then
            sqls.DMLQuery("select idlembur from lembur where jenisharilembur=" & lueJenisHari.EditValue & " and jamke=" & seJam.EditValue & " and left(replace(convert(varchar,periode,126),'-',''),6)='" & Format(CDate(deTanggal.EditValue), "yyyyMM") & "' and idunit='" & lueUnit.EditValue & "' and iddepartment='" & lueDepartment.EditValue & "' and idposition='0'", "cekdata")
        ElseIf lueDepartment.EditValue Is Nothing And luePosition.EditValue IsNot Nothing Then
            sqls.DMLQuery("select idlembur from lembur where jenisharilembur=" & lueJenisHari.EditValue & " and jamke=" & seJam.EditValue & " and left(replace(convert(varchar,periode,126),'-',''),6)='" & Format(CDate(deTanggal.EditValue), "yyyyMM") & "' and idunit='" & lueUnit.EditValue & "' and iddepartment='0' and idposition='" & luePosition.EditValue & "'", "cekdata")
        ElseIf lueDepartment.EditValue IsNot Nothing And luePosition.EditValue IsNot Nothing Then
            sqls.DMLQuery("select idlembur from lembur where jenisharilembur=" & lueJenisHari.EditValue & " and jamke=" & seJam.EditValue & " and left(replace(convert(varchar,periode,126),'-',''),6)='" & Format(CDate(deTanggal.EditValue), "yyyyMM") & "' and idunit='" & lueUnit.EditValue & "' and iddepartment='" & lueDepartment.EditValue & "' and idposition='" & luePosition.EditValue & "'", "cekdata")
        End If

        If sqls.getDataSet("cekdata") > 0 Then
            statData = statusData.Edit
            idData = sqls.getDataSet("cekdata", 0, "idlembur")
        End If

        If statData = statusData.Baru Then
            idData = GenerateGUID()
            field.AddRange(New String() {"idlembur", "idunit", "iddepartment", "idposition", "idkomponengaji", "periode", "jamke", "jenisnominallembur", "jenisharilembur", "nominal", "isdeleted", "createdby", "createddate", "idcompany"})
            value.AddRange(New Object() {idData, lueUnit.EditValue, If(lueDepartment.EditValue, "0"), If(luePosition.EditValue, "0"), lueKomponenGaji.EditValue, CDate(deTanggal.EditValue), seJam.EditValue, lueJenisNominal.EditValue, lueJenisHari.EditValue, seNominal.EditValue, 0, userid, nowTime, idcomp})
        Else
            field.AddRange(New String() {"idlembur", "idunit", "iddepartment", "idposition", "idkomponengaji", "periode", "jamke", "jenisnominallembur", "jenisharilembur", "nominal", "isdeleted", "updatedby", "updateddate", "idcompany"})
            value.AddRange(New Object() {idData, lueUnit.EditValue, If(lueDepartment.EditValue, "0"), If(luePosition.EditValue, "0"), lueKomponenGaji.EditValue, CDate(deTanggal.EditValue), seJam.EditValue, lueJenisNominal.EditValue, lueJenisHari.EditValue, seNominal.EditValue, 0, userid, nowTime, idcomp})
        End If
        If dtSQL.datasetSave("lembur", idData, field, value, False) = True Then
            dizMsgbox("Data tersimpan", dizMsgboxStyle.Info, Me)
            isiLog(userid, dbstring, field, value, "lembur")

            btnNew_Click(Me, Nothing)
        Else
            dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Kesalahan, Me)
        End If
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim retval As Boolean = False
        Dim sqls As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If btnDelete.Text = "HAPUS" Then
            field.AddRange(New String() {"idlembur", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 1, userid, nowTime})
            retval = sqls.datasetSave("lembur", idData, field, value, False)
            If retval Then
                btnDelete.Text = "AKTIF"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        Else
            field.AddRange(New String() {"idlembur", "isdeleted", "updatedby", "updateddate"})
            value.AddRange(New Object() {idData, 0, userid, nowTime})
            retval = sqls.datasetSave("lembur", idData, field, value, False)
            If retval Then
                btnDelete.Text = "HAPUS"
            Else
                dizMsgbox("Data tidak tersimpan" & vbCrLf & "Koneksi jaringan terputus atau hubungi administrator", dizMsgboxStyle.Info, Me)
                Exit Sub
            End If
        End If
        isiLog(userid, dbstring, field, value, "lembur")
        btnNew_Click(Me, Nothing)
    End Sub

    Private isdeleted As String = ""
    Private Sub gvData_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        Try
            Dim dcol As DataRow = gvData.GetDataRow(e.FocusedRowHandle)
            idData = dcol("idlembur")
            lueUnit.EditValue = dcol("idunit")
            lueDepartment.EditValue = dcol("iddepartment")
            luePosition.EditValue = dcol("idposition")
            seJam.EditValue = dcol("jamke")
            lueJenisNominal.EditValue = dcol("jenisnominallembur")
            lueJenisHari.EditValue = dcol("jenisharilembur")
            lueKomponenGaji.EditValue = dcol("idkomponengaji")
            seNominal.EditValue = dcol("nominal")
            Dim periode As String = dcol("periode")
            deTanggal.EditValue = New Date(periode.Remove(4, 2), periode.Remove(0, 4), 1)
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
        Catch ex As Exception
            btnNew_Click(Me, Nothing)
        End Try
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If
        checkFieldMaxLength(dbstring, tlpField, "lembur")
        loadLOV()
        btnNew_Click(Me, Nothing)
    End Sub

    Private Sub btnClearDept_Click(sender As Object, e As EventArgs) Handles btnClearDept.Click
        lueDepartment.EditValue = Nothing
    End Sub

    Private Sub btnClearJabt_Click(sender As Object, e As EventArgs) Handles btnClearJabt.Click
        luePosition.EditValue = Nothing
    End Sub

End Class