Imports DevExpress.XtraGrid.Views.Base

Public Class frmKaryawanCuti
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
        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='RANGETANGGAL' order by idgeneral asc", "rt")
        lueJenisTanggal.Properties.DataSource = mysqls.dataTable("rt")
        lueJenisTanggal.Properties.DisplayMember = "content"
        lueJenisTanggal.Properties.ValueMember = "id"
        If mysqls.getDataSet("rt") = 0 Then
            dizMsgbox("Jenis Tanggal tidak ditemukan" & vbCrLf & "Jenis Tanggal harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select idgeneral as id,generalcode as content from sys_generalcode where gctype='KEHADIRAN' order by idgeneral asc", "hdr")
        lueKehadiran.Properties.DataSource = mysqls.dataTable("hdr")
        lueKehadiran.Properties.DisplayMember = "content"
        lueKehadiran.Properties.ValueMember = "id"
        If mysqls.getDataSet("hdr") = 0 Then
            dizMsgbox("Kehadiran tidak ditemukan" & vbCrLf & "Kehadiran harap entry dulu", dizMsgboxStyle.Peringatan, Me)
            pExit_Click(Me, Nothing)
            Exit Sub
        End If

        mysqls.DMLQuery("select s.idstaff as id,s.nama as content,d.department + ' - '+ u.unit as remarks from staff s left join department d on s.iddepartment=d.iddepartment left join unit u on u.idunit=s.idunit where s.isdeleted=0 and s.idstaff not in (select value from sys_appsetting where variable in('IDVendor','IDSystem'))", "kary")
        slueKaryawan.Properties.DataSource = mysqls.dataTable("kary")
        slueKaryawan.Properties.ValueMember = "id"
        slueKaryawan.Properties.DisplayMember = "content"
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        getRegex(dbstring)
        If formTitle <> "" Then
            Me.Text = formTitle
            lblTitle.Text = formTitle
        End If

        loadLOV()
        btnNew_Click(btnNew, Nothing)
    End Sub

    Private Sub loadGrid()
        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim mysqls As New SQLs(dbstring)
        mysqls.DMLQuery("select v.idvacation,convert(varchar,v.vacationdate,105) as vacationdate,v.idreff,s.nama as karyawan,v.kehadiran,hdr.generalcode as stathadir,v.remarks,v.isdeleted,del.generalcode as statdata from vacation v left join staff s on v.idreff=s.idstaff and v.tablereff='KARYAWAN' left join sys_generalcode hdr on v.kehadiran=hdr.idgeneral and hdr.gctype='KEHADIRAN' left join sys_generalcode del on v.isdeleted=del.idgeneral and del.gctype='DELETE' where s.isdeleted=0 and v.idcompany=(select top 1 value from sys_appsetting where variable='CompanyID') and v.tablereff='KARYAWAN' order by s.nama asc,v.vacationdate desc", "kc")
        If mysqls.getDataSet("kc") = 0 Then
            gcData.DataSource = Nothing
            gvData.ViewCaption = "Karyawan Cuti"
        Else
            gcData.DataSource = mysqls.dataTable("kc")
            gvData.BestFitColumns()
            gvData.ViewCaption = "Karyawan Cuti"
        End If

        Me.Cursor = Cursors.Default
        splashClosed = True
    End Sub

    Private Sub gvData_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gvData.FocusedRowChanged
        If gvData.FocusedRowHandle < 0 Then
        Else
        End If
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim bentry As Boolean = True
        If lueJenisTanggal.EditValue = 0 Then
            If deTanggalAwal.EditValue Is Nothing Then
                bentry = False
            End If
        Else
            If deTanggalAwal.EditValue Is Nothing Then
                bentry = False
            End If
            If deTanggalAkhir.EditValue Is Nothing Then
                bentry = False
            End If
        End If
        If slueKaryawan.EditValue Is Nothing Then
            bentry = False
        End If
        If lueKehadiran.EditValue Is Nothing Then
            bentry = False
        End If
        If teRemarks.Text = "" Then
            bentry = False
        End If
        If bentry = False Then
            dizMsgbox("Data Cuti belum diisi dengan benar", dizMsgboxStyle.Peringatan, "Peringatan", Me)
            Exit Sub
        End If

        Dim loadScr As New frmLoading()
        splashClosed = False
        loadScr.Show(Me)
        loadScr.BringToFront()
        Application.DoEvents()
        Me.Cursor = Cursors.WaitCursor

        Dim sqlscomp As New SQLs(dbstring)
        sqlscomp.CallSP("spGetCompany", "CompID")
        Dim idcomp As String = sqlscomp.getDataSet("CompID", 0, "value")

        Dim dtsql As New dtsetSQLS(dbstring)
        Dim field As New List(Of String)
        Dim value As New List(Of Object)
        If lueJenisTanggal.EditValue = 0 Then
            Dim sqls2 As New SQLs(dbstring)

            sqls2.DMLQuery("select idvacation from vacation where idreff='" & slueKaryawan.EditValue & "' and tablereff='KARYAWAN' and convert(varchar,vacationdate,105)='" & Format(CDate(deTanggalAwal.EditValue), "dd-MM-yyyy") & "'", "cekdata")
            field.Clear()
            value.Clear()

            If sqls2.getDataSet("cekdata") = 0 Then
                idData = GenerateGUID()
                field.AddRange(New String() {"idvacation", "vacationdate", "idreff", "tablereff", "kehadiran", "remarks", "isdeleted", "createdby", "idcompany"})
                value.AddRange(New Object() {idData, CDate(deTanggalAwal.EditValue), slueKaryawan.EditValue, "KARYAWAN", lueKehadiran.EditValue, teRemarks.Text, 0, userid, idcomp})
            Else
                field.AddRange(New String() {"idvacation", "vacationdate", "idreff", "tablereff", "kehadiran", "remarks", "isdeleted", "updatedby", "updateddate", "idcompany"})
                idData = sqls2.getDataSet("cekdata", 0, "idvacation")
                value.AddRange(New Object() {idData, CDate(deTanggalAwal.EditValue), slueKaryawan.EditValue, "KARYAWAN", lueKehadiran.EditValue, teRemarks.Text, 0, userid, nowTime, idcomp})
            End If
            If dtsql.datasetSave("vacation", idData, field, value, False) = True Then
                dizMsgbox("Cuti telah tersimpan", dizMsgboxStyle.Info, "Informasi", Me)
            End If
        Else
            Dim sqls2 As New SQLs(dbstring)
            Dim dtdiff As Integer = DateDiff(DateInterval.Day, CDate(deTanggalAwal.EditValue), CDate(deTanggalAkhir.EditValue))
            For i As Integer = 0 To dtdiff
                dtsql = New dtsetSQLS(dbstring)
                sqls2 = New SQLs(dbstring)

                sqls2.DMLQuery("select idvacation from vacation where idreff='" & slueKaryawan.EditValue & "' and tablereff='KARYAWAN' and convert(varchar,vacationdate,105)='" & Format(CDate(deTanggalAwal.EditValue).AddDays(i), "dd-MM-yyyy") & "'", "cekdata")
                field.Clear()
                value.Clear()

                If sqls2.getDataSet("cekdata") = 0 Then
                    idData = GenerateGUID()
                    field.AddRange(New String() {"idvacation", "vacationdate", "idreff", "tablereff", "kehadiran", "remarks", "isdeleted", "createdby", "idcompany"})
                    value.AddRange(New Object() {idData, CDate(deTanggalAwal.EditValue).AddDays(i), slueKaryawan.EditValue, "KARYAWAN", lueKehadiran.EditValue, teRemarks.Text, 0, userid, idcomp})
                Else
                    field.AddRange(New String() {"idvacation", "vacationdate", "idreff", "tablereff", "kehadiran", "remarks", "isdeleted", "updatedby", "updateddate", "idcompany"})
                    idData = sqls2.getDataSet("cekdata", 0, "idvacation")
                    value.AddRange(New Object() {idData, CDate(deTanggalAwal.EditValue).AddDays(i), slueKaryawan.EditValue, "KARYAWAN", lueKehadiran.EditValue, teRemarks.Text, 0, userid, nowTime, idcomp})
                End If
                dtsql.datasetSave("vacation", idData, field, value, False)
            Next
        End If

        Me.Cursor = Cursors.Default
        splashClosed = True

        btnNew_Click(btnNew, Nothing)
    End Sub

    Private statData As statusData = statusData.Baru
    Private idData As String = "-1"

    Private Sub lueJenisTanggal_EditValueChanged(sender As Object, e As EventArgs) Handles lueJenisTanggal.EditValueChanged
        If lueJenisTanggal.EditValue Is Nothing Then
            lblTanggalAkhir.Visible = False
            deTanggalAkhir.Visible = False
            lblTanggalAwal.Text = "Tanggal"
        Else
            If lueJenisTanggal.EditValue = 0 Then
                lblTanggalAkhir.Visible = False
                deTanggalAkhir.Visible = False
                lblTanggalAwal.Text = "Tanggal"
            ElseIf lueJenisTanggal.EditValue = 1 Then
                lblTanggalAkhir.Visible = True
                lblTanggalAkhir.Text = "Tanggal Akhir"
                deTanggalAkhir.Visible = True
                lblTanggalAwal.Text = "Tanggal Awal"
            End If
        End If
    End Sub

    Private Sub lueKehadiran_EditValueChanged(sender As Object, e As EventArgs) Handles lueKehadiran.EditValueChanged
        If lueKehadiran.EditValue Is Nothing Then
            teRemarks.Text = "-"
            teRemarks.Properties.ReadOnly = True
        Else
            If lueKehadiran.EditValue = 1 Or lueKehadiran.EditValue = 2 Then
                teRemarks.Text = ""
                teRemarks.Properties.ReadOnly = False
            Else
                teRemarks.Text = "-"
                teRemarks.Properties.ReadOnly = True
            End If
        End If
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        loadGrid()

        lueJenisTanggal.EditValue = Nothing
        deTanggalAwal.EditValue = Nothing
        deTanggalAkhir.EditValue = Nothing
        slueKaryawan.EditValue = Nothing
        lueKehadiran.EditValue = Nothing
        teRemarks.Text = "-"
        lblTanggalAwal.Text = "Tanggal"
        statData = statusData.Baru
    End Sub

End Class